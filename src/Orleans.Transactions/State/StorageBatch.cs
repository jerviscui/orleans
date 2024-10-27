using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Orleans.Transactions.Abstractions;

namespace Orleans.Transactions
{
    /// <summary>
    /// Events streamed to storage. 
    /// </summary>
    public interface ITransactionalStateStorageEvents<TState> where TState : class, new()
    {
        void Prepare(
            long sequenceNumber,
            Guid transactionId,
            DateTime timestamp,
            ParticipantId transactionManager,
            TState state);

        void Read(DateTime timestamp);

        void Cancel(long sequenceNumber);

        void Confirm(long sequenceNumber);

        void Commit(Guid transactionId, DateTime timestamp, List<ParticipantId> writeResources);

        void Collect(Guid transactionId);
    }

    /// <summary>
    /// Accumulates storage events, for submitting them to storage as a batch.
    /// <para>批量提交 prepares 到 storage</para>
    /// </summary>
    /// <typeparam name="TState"></typeparam>
    internal class StorageBatch<TState> : ITransactionalStateStorageEvents<TState> where TState : class, new()
    {
        // watermarks for commit, prepare, abort
        /// <summary>
        /// Committed SequenceId
        /// </summary>
        private long _confirmUpTo;
        /// <summary>
        /// prepare SequenceId, 取消 SequenceId 及以前的事务
        /// </summary>
        private long _cancelAbove;
        /// <summary>
        /// abort SequenceId, 终止 SequenceId 及以前的事务
        /// </summary>
        private readonly long _cancelAboveStart;

        // prepare records
        private readonly SortedDictionary<long, PendingTransactionState<TState>> _prepares;

        // follow-up actions, to be executed after storing this batch
        private readonly List<Action> _followUpActions;
        private readonly List<Func<Task<bool>>> _storeConditions;
        private int _prepare;
        private int _read;
        private int _commit;
        private int _confirm;
        private int _collect;
        private int _cancel;

        public TransactionalStateMetaData MetaData { get; private set; }

        public string ETag { get; set; }

        public int BatchSize { get; private set; }

        public override string ToString()
        {
            return $"batchsize={BatchSize} [{_read}r {_prepare}p {_commit}c {_confirm}cf {_collect}cl {_cancel}cc]";
        }

        public StorageBatch(TransactionalStateMetaData metaData, string etag, long confirmUpTo, long cancelAbove)
        {
            this.MetaData = metaData ?? throw new ArgumentNullException(nameof(metaData));
            this.ETag = etag;
            this._confirmUpTo = confirmUpTo;
            this._cancelAbove = cancelAbove;
            this._cancelAboveStart = cancelAbove;
            this._followUpActions = [];
            this._storeConditions = [];
            this._prepares = [];
        }

        public StorageBatch(StorageBatch<TState> previous)
            : this(previous.MetaData, previous.ETag, previous._confirmUpTo, previous._cancelAbove)
        {
        }

        public StorageBatch(TransactionalStorageLoadResponse<TState> loadresponse)
            : this(
            loadresponse.Metadata,
            loadresponse.ETag,
            loadresponse.CommittedSequenceId,
            loadresponse.PendingStates.Count > 0
                ? loadresponse.PendingStates[^1].SequenceId
                : loadresponse.CommittedSequenceId)
        {
        }

        public Task<string> Store(ITransactionalStateStorage<TState> storage)
        {
            List<PendingTransactionState<TState>> list = this._prepares.Values.ToList();
            return storage.Store(
                ETag,
                this.MetaData,
                list,
                (_confirm > 0) ? _confirmUpTo : (long?)null,
                (_cancelAbove < _cancelAboveStart) ? _cancelAbove : (long?)null);
        }

        public void RunFollowUpActions()
        {
            foreach (var action in _followUpActions)
            {
                action();
            }
        }

        public void Read(DateTime timestamp)
        {
            _read++;
            BatchSize++;

            if (MetaData.TimeStamp < timestamp)
            {
                MetaData.TimeStamp = timestamp;
            }
        }

        /// <summary>
        /// add to prepares
        /// </summary>
        public void Prepare(
            long sequenceNumber,
            Guid transactionId,
            DateTime timestamp,
            ParticipantId transactionManager,
            TState state)
        {
            _prepare++;
            BatchSize++;

            if (MetaData.TimeStamp < timestamp)
                MetaData.TimeStamp = timestamp;

            this._prepares[sequenceNumber] =
                new PendingTransactionState<TState>
                {
                    SequenceId = sequenceNumber,
                    TransactionId = transactionId.ToString(),
                    TimeStamp = timestamp,
                    TransactionManager = transactionManager,
                    State = state
                };

            if (_cancelAbove < sequenceNumber)
            {
                _cancelAbove = sequenceNumber;
            }
        }

        public void Cancel(long sequenceNumber)
        {
            _cancel++;
            BatchSize++;

            this._prepares.Remove(sequenceNumber);

            if (_cancelAbove > sequenceNumber - 1)
            {
                _cancelAbove = sequenceNumber - 1;
            }
        }

        /// <summary>
        /// clear prepares
        /// </summary>
        public void Confirm(long sequenceNumber)
        {
            _confirm++;
            BatchSize++;

            _confirmUpTo = sequenceNumber;

            // remove all redundant prepare records that are superseded by a later confirmed state
            while (true)
            {
                long? first = this._prepares.Values.FirstOrDefault()?.SequenceId;

                if (first.HasValue && first < _confirmUpTo)
                {
                    this._prepares.Remove(first.Value);
                }
                else
                {
                    break;
                }
            }
        }

        /// <summary>
        /// add to CommitRecords
        /// </summary>
        public void Commit(Guid transactionId, DateTime timestamp, List<ParticipantId> writeResources)
        {
            _commit++;
            BatchSize++;

            MetaData.CommitRecords
                .Add(transactionId, new CommitRecord { Timestamp = timestamp, WriteParticipants = writeResources });
        }

        /// <summary>
        /// clear CommitRecords
        /// </summary>
        public void Collect(Guid transactionId)
        {
            _collect++;
            BatchSize++;

            MetaData.CommitRecords.Remove(transactionId);
        }

        public void FollowUpAction(Action action)
        {
            _followUpActions.Add(action);
        }

        public void AddStorePreCondition(Func<Task<bool>> action)
        {
            this._storeConditions.Add(action);
        }

        public async Task<bool> CheckStorePreConditions()
        {
            if (this._storeConditions.Count == 0)
                return true;

            bool[] results = await Task.WhenAll(this._storeConditions.Select(a => a.Invoke()));
            return Array.TrueForAll(results, b => b);
        }
    }
}
