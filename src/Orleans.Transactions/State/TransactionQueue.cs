using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Orleans.Runtime;
using Orleans.Transactions.Abstractions;
using Orleans.Storage;
using Orleans.Configuration;
using Orleans.Timers.Internal;

namespace Orleans.Transactions.State
{
    internal class TransactionQueue<TState>
        where TState : class, new()
    {
        private readonly TransactionalStateOptions _options;
        private readonly ParticipantId _resource;
        private readonly Action _deactivate;
        private readonly ITransactionalStateStorage<TState> _storage;
        private readonly BatchWorker _storageWorker;
        protected readonly ILogger Logger;
        private readonly IActivationLifetime _activationLifetime;
        private readonly ConfirmationWorker<TState> _confirmationWorker;
        private CommitQueue<TState> _commitQueue;
        private Task _readyTask;

        protected StorageBatch<TState> StorageBatch;

        private int _failCounter;

        // collection tasks
        private readonly Dictionary<DateTime, PreparedMessages> _unprocessedPreparedMessages;
        private class PreparedMessages
        {
            public PreparedMessages(TransactionalStatus status)
            {
                this.Status = status;
            }
            public int Count;
            public TransactionalStatus Status;
        }

        private TState _stableState;
        private long _stableSequenceNumber;
        public ReadWriteLock<TState> RWLock { get; }
        public CausalClock Clock { get; }

        public TransactionQueue(
            IOptions<TransactionalStateOptions> options,
            ParticipantId resource,
            Action deactivate,
            ITransactionalStateStorage<TState> storage,
            IClock clock,
            ILogger logger,
            ITimerManager timerManager,
            IActivationLifetime activationLifetime)
        {
            this._options = options.Value;
            this._resource = resource;
            this._deactivate = deactivate;
            this._storage = storage;
            this.Clock = new CausalClock(clock);
            this.Logger = logger;
            this._activationLifetime = activationLifetime;
            this._storageWorker = new BatchWorkerFromDelegate(StorageWork, this._activationLifetime.OnDeactivating);
            this.RWLock = new ReadWriteLock<TState>(options, this, this._storageWorker, logger, activationLifetime);
            this._confirmationWorker = new ConfirmationWorker<TState>(options, this._resource, this._storageWorker, () => this.StorageBatch, this.Logger, timerManager, activationLifetime);
            this._unprocessedPreparedMessages = new Dictionary<DateTime, PreparedMessages>();
            this._commitQueue = new CommitQueue<TState>();
            this._readyTask = Task.CompletedTask;
        }

        public async Task EnqueueCommit(TransactionRecord<TState> record)
        {
            try
            {
                if (Logger.IsEnabled(LogLevel.Trace))
                    Logger.LogTrace("Start two-phase-commit {TransactionId} {Timestamp}", record.TransactionId, record.Timestamp.ToString("O"));

                _commitQueue.Add(record);

                // additional actions for each commit type
                switch (record.Role)
                {
                    case CommitRole.ReadOnly:
                        {
                            // no extra actions needed
                            break;
                        }

                    case CommitRole.LocalCommit:
                        {
                            // process prepared messages received ahead of time
                            if (_unprocessedPreparedMessages.TryGetValue(record.Timestamp, out PreparedMessages info))
                            {
                                if (info.Status == TransactionalStatus.Ok)
                                {
                                    record.WaitCount -= info.Count;
                                }
                                else
                                {
                                    await AbortCommits(info.Status, _commitQueue.Count - 1);

                                    this.RWLock.Notify();
                                }
                                _unprocessedPreparedMessages.Remove(record.Timestamp);
                            }
                            break;
                        }

                    case CommitRole.RemoteCommit:
                        {

                            // optimization: can immediately proceed if dependency is implied
                            bool behindRemoteEntryBySameTM = false;
                                /* disabled - jbragg - TODO - revisit
                                _commitQueue.Count >= 2
                                && _commitQueue[_commitQueue.Count - 2] is TransactionRecord<TState> rce
                                && rce.Role == CommitRole.RemoteCommit
                                && rce.TransactionManager.Equals(record.TransactionManager);
                                */

                            if (record.NumberWrites > 0)
                            {
                                this.StorageBatch.Prepare(record.SequenceNumber, record.TransactionId, record.Timestamp, record.TransactionManager, record.State);
                            }
                            else
                            {
                                this.StorageBatch.Read(record.Timestamp);
                            }

                            this.StorageBatch.FollowUpAction(() =>
                            {
                                if (Logger.IsEnabled(LogLevel.Trace))
                                {
                                    Logger.LogTrace("Persisted {Record}", record);
                                }

                                record.PrepareIsPersisted = true;

                                if (behindRemoteEntryBySameTM)
                                {
                                    if (Logger.IsEnabled(LogLevel.Trace))
                                    {
                                        Logger.LogTrace("Sending immediate prepared {Record}", record);
                                    }
                                    // can send prepared message immediately after persisting prepare record
                                    record.TransactionManager.Reference.AsReference<ITransactionManagerExtension>()
                                          .Prepared(record.TransactionManager.Name, record.TransactionId, record.Timestamp, this._resource, TransactionalStatus.Ok)
                                          .Ignore();
                                    record.LastSent = DateTime.UtcNow;
                                }
                            });
                            break;
                        }

                    default:
                        {
                            Logger.LogError(777, "internal error: impossible case {CommitRole}", record.Role);
                            throw new NotSupportedException($"{record.Role} is not a supported CommitRole.");
                        }
                }
            }
            catch (Exception exception)
            {
                Logger.LogError(exception, $"Transaction abort due to internal error in {nameof(EnqueueCommit)}");
                await NotifyOfAbort(record, TransactionalStatus.UnknownException, exception);
            }
        }

        public async Task NotifyOfPrepared(Guid transactionId, DateTime timeStamp, TransactionalStatus status)
        {
            var pos = _commitQueue.Find(transactionId, timeStamp);
            if (Logger.IsEnabled(LogLevel.Trace))
                Logger.LogTrace("NotifyOfPrepared - TransactionId:{TransactionId} Timestamp:{Timestamp}, TransactionalStatus{TransactionalStatus}", transactionId, timeStamp, status);

            if (pos != -1)
            {

                var localEntry = _commitQueue[pos];

                if (localEntry.Role != CommitRole.LocalCommit)
                {
                    Logger.LogError($"Transaction abort due to internal error in {nameof(NotifyOfPrepared)}: Wrong commit type");
                    throw new InvalidOperationException($"Wrong commit type: {localEntry.Role}");
                }

                if (status == TransactionalStatus.Ok)
                {
                    localEntry.WaitCount--;

                    _storageWorker.Notify();
                }
                else
                {
                    await AbortCommits(status, pos);

                    this.RWLock.Notify();
                }
            }
            else
            {
                // this message has arrived ahead of the commit request - we need to remember it
                if (!this._unprocessedPreparedMessages.TryGetValue(timeStamp, out PreparedMessages info))
                {
                    this._unprocessedPreparedMessages[timeStamp] = info = new PreparedMessages(status);
                }
                if (status == TransactionalStatus.Ok)
                {
                    info.Count++;
                }
                else
                {
                    info.Status = status;
                }

                // TODO fix memory leak if corresponding commit messages never arrive
            }
        }

        public async Task NotifyOfPrepare(Guid transactionId, AccessCounter accessCount, DateTime timeStamp, ParticipantId transactionManager)
        {
            var locked = await this.RWLock.ValidateLock(transactionId, accessCount);
            var status = locked.Item1;
            var record = locked.Item2; // record 来自 currentGroup
            var valid = status == TransactionalStatus.Ok;

            record.Timestamp = timeStamp;
            record.Role = CommitRole.RemoteCommit; // we are not the TM
            record.TransactionManager = transactionManager;
            record.LastSent = null;
            record.PrepareIsPersisted = false;

            if (!valid)
            {
                await this.NotifyOfAbort(record, status, exception: null);
            }
            else
            {
                this.Clock.Merge(record.Timestamp);
            }

            this.RWLock.Notify();
        }

        public async Task NotifyOfAbort(TransactionRecord<TState> entry, TransactionalStatus status, Exception exception)
        {
            switch (entry.Role)
            {
                case CommitRole.NotYetDetermined:
                    {
                        // cannot notify anyone. TA will detect broken lock during prepare.
                        break;
                    }
                case CommitRole.RemoteCommit:
                    {
                        if (Logger.IsEnabled(LogLevel.Trace))
                            Logger.LogTrace("Aborting status={Status} {Entry}", status, entry);

                        entry.ConfirmationResponsePromise?.TrySetException(new OrleansException($"Confirm failed: Status {status}"));

                        if (entry.LastSent.HasValue)
                            return; // cannot abort anymore if we already sent prepare-ok message

                        if (Logger.IsEnabled(LogLevel.Trace))
                            Logger.LogTrace("Aborting via Prepared. Status={Status} Entry={Entry}", status, entry);

                        entry.TransactionManager.Reference.AsReference<ITransactionManagerExtension>()
                             .Prepared(entry.TransactionManager.Name, entry.TransactionId, entry.Timestamp, _resource, status)
                             .Ignore();
                        break;
                    }
                case CommitRole.LocalCommit:
                    {
                        if (Logger.IsEnabled(LogLevel.Trace))
                            Logger.LogTrace("Aborting status={Status} {Entry}", status, entry);

                        try
                        {
                            // tell remote participants
                            await Task.WhenAll(entry.WriteParticipants
                                .Where(p => !p.Equals(_resource))
                                .Select(p => p.Reference.AsReference<ITransactionalResourceExtension>()
                                     .Cancel(p.Name, entry.TransactionId, entry.Timestamp, status)));
                        }
                        catch(Exception ex)
                        {
                            this.Logger.LogWarning(ex, "Failed to notify all transaction participants of cancellation.  TransactionId: {TransactionId}, Timestamp: {Timestamp}, Status: {Status}", entry.TransactionId, entry.Timestamp, status);
                        }

                        // reply to transaction agent
                        if (exception is not null)
                        {
                            entry.PromiseForTA.TrySetException(exception);
                        }
                        else
                        {
                            entry.PromiseForTA.TrySetResult(status);
                        }

                        break;
                    }
                case CommitRole.ReadOnly:
                    {
                        if (Logger.IsEnabled(LogLevel.Trace))
                            Logger.LogTrace("Aborting status={Status} {Entry}", status, entry);

                        // reply to transaction agent
                        if (exception is not null)
                        {
                            entry.PromiseForTA.TrySetException(exception);
                        }
                        else
                        {
                            entry.PromiseForTA.TrySetResult(status);
                        }

                        break;
                    }
                default:
                    {
                        Logger.LogError(777, "internal error: impossible case {CommitRole}", entry.Role);
                        throw new NotSupportedException($"{entry.Role} is not a supported CommitRole.");
                    }
            }
        }

        public async Task NotifyOfPing(Guid transactionId, DateTime timeStamp, ParticipantId resource)
        {
            if (this._commitQueue.Find(transactionId, timeStamp) != -1)
            {
                // no need to take special action now - the transaction is still
                // in the commit queue and its status is not yet determined.
                // confirmation or cancellation will be sent after committing or aborting.

                if (Logger.IsEnabled(LogLevel.Trace))
                    Logger.LogTrace("Received ping for {TransactionId}, irrelevant (still processing)", transactionId);

                this._storageWorker.Notify(); // just in case the worker fell asleep or something
            }
            else
            {
                if (!this._confirmationWorker.IsConfirmed(transactionId))
                {
                    if (Logger.IsEnabled(LogLevel.Trace))
                        Logger.LogTrace("Received ping for {TransactionId}, unknown - presumed abort", transactionId);

                    // we never heard of this transaction - so it must have aborted
                    await resource.Reference.AsReference<ITransactionalResourceExtension>()
                            .Cancel(resource.Name, transactionId, timeStamp, TransactionalStatus.PresumedAbort);
                }
            }
        }

        public async Task NotifyOfConfirm(Guid transactionId, DateTime timeStamp)
        {
            if (Logger.IsEnabled(LogLevel.Trace))
                Logger.LogTrace("NotifyOfConfirm: {TransactionId} {TimeStamp}", transactionId, timeStamp);

            // find in _queue
            var pos = _commitQueue.Find(transactionId, timeStamp);

            if (pos == -1)
                return; // must have already been confirmed

            var remoteEntry = _commitQueue[pos];

            if (remoteEntry.Role != CommitRole.RemoteCommit)
            {
                Logger.LogError($"Internal error in {nameof(NotifyOfConfirm)}: wrong commit type");
                throw new InvalidOperationException($"Wrong commit type: {remoteEntry.Role}");
            }

            // setting this field makes this entry ready for batching

            remoteEntry.ConfirmationResponsePromise = remoteEntry.ConfirmationResponsePromise ?? new TaskCompletionSource<bool>(TaskCreationOptions.RunContinuationsAsynchronously);

            _storageWorker.Notify();

            // now we wait for the batch to finish

            await remoteEntry.ConfirmationResponsePromise.Task;
        }

        public async Task NotifyOfCancel(Guid transactionId, DateTime timeStamp, TransactionalStatus status)
        {
            if (Logger.IsEnabled(LogLevel.Trace))
                Logger.LogTrace("{MethodName}. TransactionId: {TransactionId}, TimeStamp: {TimeStamp} Status: {TransactionalStatus}", nameof(NotifyOfCancel), transactionId, timeStamp, status);

            // find in _queue
            var pos = _commitQueue.Find(transactionId, timeStamp);

            if (pos == -1)
                return;

            this.StorageBatch.Cancel(_commitQueue[pos].SequenceNumber);

            await AbortCommits(status, pos);

            _storageWorker.Notify();

            this.RWLock.Notify();
        }

        /// <summary>
        /// called on activation, and when recovering from storage conflicts or other exceptions.
        /// </summary>
        public async Task NotifyOfRestore()
        {
            try
            {
                await Ready();
            }
            finally
            {
                this._readyTask = Restore();
            }
            await this._readyTask;
        }

        /// <summary>
        /// Ensures queue is ready to process requests.
        /// </summary>
        /// <returns></returns>
        public Task Ready()
        {
            if (this._readyTask.Status == TaskStatus.RanToCompletion)
            {
                return _readyTask;
            }
            return ReadyAsync();
            async Task ReadyAsync()
            {
                try
                {
                    await _readyTask;
                }
                catch (Exception exception)
                {
                    Logger.LogWarning(exception, "Exception in TransactionQueue");
                    await AbortAndRestore(TransactionalStatus.UnknownException, exception);
                }
            }
        }

        private async Task Restore()
        {
            TransactionalStorageLoadResponse<TState> loadresponse = await _storage.Load();

            this.StorageBatch = new StorageBatch<TState>(loadresponse);

            this._stableState = loadresponse.CommittedState;
            this._stableSequenceNumber = loadresponse.CommittedSequenceId;

            if (Logger.IsEnabled(LogLevel.Debug))
            {
                Logger.LogDebug(
                    "Load v{StableSequenceNumber} {PendingStatesCount}p {CommitRecordsCount}c",
                    this._stableSequenceNumber,
                    loadresponse.PendingStates.Count,
                    StorageBatch.MetaData.CommitRecords.Count);
            }

            // ensure clock is consistent with loaded state
            this.Clock.Merge(StorageBatch.MetaData.TimeStamp);

            // resume prepared transactions (not TM)
            foreach (var pr in loadresponse.PendingStates.OrderBy(ps => ps.TimeStamp))
            {
                if (pr.SequenceId > loadresponse.CommittedSequenceId && pr.TransactionManager.Reference != null)
                {
                    if (Logger.IsEnabled(LogLevel.Debug))
                        Logger.LogDebug("Recover two-phase-commit {TransactionId}", pr.TransactionId);

                    ParticipantId tm = pr.TransactionManager;

                    _commitQueue.Add(new TransactionRecord<TState>()
                    {
                        Role = CommitRole.RemoteCommit,
                        TransactionId = Guid.Parse(pr.TransactionId),
                        Timestamp = pr.TimeStamp,
                        State = pr.State,
                        SequenceNumber = pr.SequenceId,
                        TransactionManager = tm,
                        PrepareIsPersisted = true,
                        LastSent = default(DateTime),
                        ConfirmationResponsePromise = null,
                        NumberWrites = 1 // was a writing transaction
                    });
                    this._stableSequenceNumber = pr.SequenceId;
                }
            }

            // resume committed transactions (on TM)
            foreach (var kvp in StorageBatch.MetaData.CommitRecords)
            {
                if (Logger.IsEnabled(LogLevel.Debug))
                    Logger.LogDebug(
                        "Recover commit confirmation {Key}",
                        kvp.Key);
                this._confirmationWorker.Add(kvp.Key, kvp.Value.Timestamp, kvp.Value.WriteParticipants);
            }

            // check for work
            this._storageWorker.Notify();
            this.RWLock.Notify();
        }

        public void GetMostRecentState(out TState state, out long sequenceNumber)
        {
            if (_commitQueue.Count == 0)
            {
                state = this._stableState;
                sequenceNumber = this._stableSequenceNumber;
            }
            else
            {
                var record = _commitQueue.Last;
                state = record.State;
                sequenceNumber = record.SequenceNumber;
            }
        }

        public int BatchableOperationsCount()
        {
            int count = 0;
            int pos = _commitQueue.Count - 1;
            while (pos >= 0 && _commitQueue[pos].Batchable)
            {
                pos--;
                count++;
            }
            return count;
        }

        private async Task StorageWork()
        {
            // Stop if this activation is stopping/stopped.
            if (this._activationLifetime.OnDeactivating.IsCancellationRequested) return;

            using (this._activationLifetime.BlockDeactivation())
            {
                try
                {
                    // count committable entries at the bottom of the commit _queue
                    int committableEntries = 0;
                    while (committableEntries < _commitQueue.Count && _commitQueue[committableEntries].ReadyToCommit)
                    {
                        committableEntries++;
                    }

                    // process all committable entries, assembling a _storage batch
                    if (committableEntries > 0)
                    {
                        // process all committable entries, adding _storage events to the _storage batch
                        CollectEventsForBatch(committableEntries);

                        if (Logger.IsEnabled(LogLevel.Debug))
                        {
                            var recordString = _commitQueue.Count > committableEntries ? _commitQueue[committableEntries].ToString() : "";
                            Logger.LogDebug(
                                "BatchCommit: {CommittableEntries} Leave: {UncommittableEntries}, Record: {Record}",
                                committableEntries,
                                _commitQueue.Count - committableEntries,
                                recordString);
                        }
                    }
                    else
                    {
                        // send or re-send messages and detect timeouts
                        await CheckProgressOfCommitQueue();
                    }

                    // store the current storage batch, if it is not empty
                    StorageBatch<TState> batchBeingSentToStorage = null;
                    if (this.StorageBatch.BatchSize > 0)
                    {
                        // get the next batch in place so it can be filled while we store the old one
                        batchBeingSentToStorage = this.StorageBatch;
                        this.StorageBatch = new StorageBatch<TState>(batchBeingSentToStorage);

                        try
                        {
                            if (await batchBeingSentToStorage.CheckStorePreConditions())
                            {
                                // perform the actual store, and record the e-tag
                                this.StorageBatch.ETag = await batchBeingSentToStorage.Store(_storage);
                                _failCounter = 0;
                            }
                            else
                            {
                                Logger.LogWarning("Store pre conditions not met.");
                                await AbortAndRestore(TransactionalStatus.CommitFailure, exception: null);
                                return;
                            }
                        }
                        catch (InconsistentStateException exception)
                        {
                            Logger.LogWarning(888, exception, "Reload from _storage triggered by e-tag mismatch.");
                            await AbortAndRestore(TransactionalStatus.StorageConflict, exception, true);
                            return;
                        }
                        catch (Exception exception)
                        {
                            Logger.LogWarning(exception, "Storage exception in _storage worker.");
                            await AbortAndRestore(TransactionalStatus.UnknownException, exception);
                            return;
                        }
                    }

                    if (committableEntries > 0)
                    {
                        // update stable state
                        var lastCommittedEntry = _commitQueue[committableEntries - 1];
                        this._stableState = lastCommittedEntry.State;
                        this._stableSequenceNumber = lastCommittedEntry.SequenceNumber;
                        if (Logger.IsEnabled(LogLevel.Trace))
                            Logger.LogTrace("Stable state version: {StableSequenceNumber}", _stableSequenceNumber);

                        // remove committed entries from commit _queue
                        _commitQueue.RemoveFromFront(committableEntries);
                        _storageWorker.Notify();  // we have to re-check for work
                    }

                    if (batchBeingSentToStorage != null)
                    {
                        batchBeingSentToStorage.RunFollowUpActions();
                        _storageWorker.Notify();  // we have to re-check for work
                    }
                }
                catch (Exception exception)
                {
                    Logger.LogWarning(888, exception, "Exception in _storageWorker.  Retry {FailCounter}", _failCounter);
                    await AbortAndRestore(TransactionalStatus.UnknownException, exception);
                }
            }
        }

        private Task AbortAndRestore(TransactionalStatus status, Exception exception, bool force = false)
        {
            this._readyTask = Bail(status, exception, force);
            return this._readyTask;
        }

        private async Task Bail(TransactionalStatus status, Exception exception, bool force = false)
        {
            List<Task> pending = new List<Task>();
            pending.Add(RWLock.AbortExecutingTransactions(exception));
            this.RWLock.AbortQueuedTransactions();

            // abort all entries in the commit queue
            foreach (var entry in commitQueue.Elements)
            {
                pending.Add(NotifyOfAbort(entry, status, exception: exception));
            }

            _commitQueue.Clear();

            await Task.WhenAll(pending);
            if (++_failCounter >= 10 || force)
            {
                Logger.LogDebug("StorageWorker triggering grain Deactivation");
                this._deactivate();
            }
            await this.Restore();
        }

        private async Task CheckProgressOfCommitQueue()
        {
            if (_commitQueue.Count > 0)
            {
                var bottom = _commitQueue[0];
                var now = DateTime.UtcNow;

                if (Logger.IsEnabled(LogLevel.Trace))
                    Logger.LogTrace("{CommitQueueSize} entries in _queue waiting for bottom: {BottomEntry}", _commitQueue.Count, bottom);

                switch (bottom.Role)
                {
                    case CommitRole.LocalCommit:
                        {
                            // check for timeout periodically
                            if (bottom.WaitingSince + this._options.PrepareTimeout <= now)
                            {
                                await AbortCommits(TransactionalStatus.PrepareTimeout);
                                this.RWLock.Notify();
                            }
                            else
                            {
                                _storageWorker.Notify(bottom.WaitingSince + this._options.PrepareTimeout);
                            }
                            break;
                        }

                    case CommitRole.RemoteCommit:
                        {
                            if (bottom.PrepareIsPersisted && !bottom.LastSent.HasValue)
                            {
                                // send PreparedMessage to remote TM
                                bottom.TransactionManager.Reference.AsReference<ITransactionManagerExtension>()
                                      .Prepared(bottom.TransactionManager.Name, bottom.TransactionId, bottom.Timestamp, _resource, TransactionalStatus.Ok)
                                      .Ignore();                                
                                    
                                bottom.LastSent = now;

                                if (Logger.IsEnabled(LogLevel.Trace))
                                    Logger.LogTrace("Sent Prepared {BottomEntry}", bottom);

                                if (bottom.IsReadOnly)
                                {
                                    _storageWorker.Notify(); // we are ready to batch now
                                }
                                else
                                {
                                    _storageWorker.Notify(bottom.LastSent.Value + this._options.RemoteTransactionPingFrequency);
                                }
                            }
                            else if (!bottom.IsReadOnly && bottom.LastSent.HasValue)
                            {
                                // send ping messages periodically to reactivate crashed TMs

                                if (bottom.LastSent + this._options.RemoteTransactionPingFrequency <= now)
                                {
                                    if (Logger.IsEnabled(LogLevel.Trace))
                                        Logger.LogTrace("Sent ping {BottomEntry}", bottom);
                                    bottom.TransactionManager.Reference.AsReference<ITransactionManagerExtension>()
                                          .Ping(bottom.TransactionManager.Name, bottom.TransactionId, bottom.Timestamp, _resource).Ignore();
                                    bottom.LastSent = now;
                                }
                                _storageWorker.Notify(bottom.LastSent.Value + this._options.RemoteTransactionPingFrequency);
                            }

                            break;
                        }

                    default:
                        {
                            Logger.LogError(777, "internal error: impossible case {CommitRole}", bottom.Role);
                            throw new NotSupportedException($"{bottom.Role} is not a supported CommitRole.");
                        }
                }
            }
        }

        private void CollectEventsForBatch(int batchsize)
        {
            // collect events for batch
            for (int i = 0; i < batchsize; i++)
            {
                TransactionRecord<TState> entry = _commitQueue[i];

                if (Logger.IsEnabled(LogLevel.Trace))
                {
                    Logger.LogTrace("Committing {Entry}", entry);
                }

                switch (entry.Role)
                {
                    case CommitRole.LocalCommit:
                        {
                            OnLocalCommit(entry);
                            break;
                        }

                    case CommitRole.RemoteCommit:
                        {
                            if (entry.ConfirmationResponsePromise == null)
                            {
                                // this is a read-only participant that has sent
                                // its prepared message.
                                // So we are really done and need not store or do anything.
                            }
                            else
                            {
                                // we must confirm in storage, and then respond to TM so it can collect
                                this.storageBatch.Confirm(entry.SequenceNumber);
                                this.storageBatch.FollowUpAction(() =>
                                {
                                    entry.ConfirmationResponsePromise.TrySetResult(true);
                                    if (this.Logger.IsEnabled(LogLevel.Trace))
                                    {
                                        this.Logger.LogTrace(
                                            "Confirmed remote commit v{SequenceNumber}. TransactionId:{TransactionId} Timestamp:{Timestamp} TransactionManager:{TransactionManager}",
                                            entry.SequenceNumber,
                                            entry.TransactionId,
                                            entry.Timestamp,
                                            entry.TransactionManager);
                                    }
                                });
                            }

                            break;
                        }

                    case CommitRole.ReadOnly:
                        {
                            // we are a participant of a read-only transaction. Must store timestamp and then respond.
                            this.StorageBatch.Read(entry.Timestamp);
                            this.StorageBatch.FollowUpAction(() =>
                            {
                                entry.PromiseForTA.TrySetResult(TransactionalStatus.Ok);
                            });

                            break;
                        }

                    default:
                        {
                            Logger.LogError(777, "internal error: impossible case {CommitRole}", entry.Role);
                            throw new NotSupportedException($"{entry.Role} is not a supported CommitRole.");
                        }
                }
            }
        }

        protected virtual void OnLocalCommit(TransactionRecord<TState> entry)
        {
            this.StorageBatch.Prepare(entry.SequenceNumber, entry.TransactionId, entry.Timestamp, entry.TransactionManager, entry.State);
            this.StorageBatch.Commit(entry.TransactionId, entry.Timestamp, entry.WriteParticipants);
            this.StorageBatch.Confirm(entry.SequenceNumber);

            // after store, send response back to TA
            this.StorageBatch.FollowUpAction(() =>
            {
                if (this.Logger.IsEnabled(LogLevel.Trace))
                {
                    this.Logger.LogTrace(
                        "Locally committed {TransactionId} {Timestamp}",
                        entry.TransactionId,
                        entry.Timestamp.ToString("O"));
                }
                entry.PromiseForTA.TrySetResult(TransactionalStatus.Ok);
            });

            if (entry.WriteParticipants.Count > 1)
            {
                // after committing, we need to run a task to confirm and collect
                this.StorageBatch.FollowUpAction(() =>
                {
                    if (this.Logger.IsEnabled(LogLevel.Trace))
                    {
                        this.Logger.LogTrace(
                            "Adding confirmation to worker for {TransactionId} {Timestamp}",
                            entry.TransactionId,
                            entry.Timestamp.ToString("O"));
                    }
                    this._confirmationWorker.Add(entry.TransactionId, entry.Timestamp, entry.WriteParticipants);
                });
            }
            else
            {
                // there are no remote write participants to notify, so we can finish it all in one shot
                this.StorageBatch.Collect(entry.TransactionId);
            }
        }

        private async Task AbortCommits(TransactionalStatus status, int from = 0)
        {
            List<Task> pending = new List<Task>();
            // emtpy the back of the commit queue, starting at specified position
            for (int i = from; i < commitQueue.Count; i++)
            {
                pending.Add(NotifyOfAbort(_commitQueue[i], i == from ? status : TransactionalStatus.CascadingAbort, exception: null));
            }
            _commitQueue.RemoveFromBack(_commitQueue.Count - from);

            pending.Add(this.RWLock.AbortExecutingTransactions(exception: null));
            await Task.WhenAll(pending);
        }
    }
}
