using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;
using Azure;
using Azure.Data.Tables;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using Orleans.Transactions.Abstractions;

namespace Orleans.Transactions.AzureStorage
{
    public class AzureTableTransactionalStateStorage<TState> : ITransactionalStateStorage<TState>
        where TState : class, new()
    {
        private readonly TableClient _table;
        private readonly string _partition;
        private readonly JsonSerializerSettings _jsonSettings;
        private readonly ILogger _logger;

        private KeyEntity _key;
        private List<KeyValuePair<long, StateEntity>> _states;

        public AzureTableTransactionalStateStorage(
            TableClient table,
            string partition,
            JsonSerializerSettings jsonSettings,
            ILogger<AzureTableTransactionalStateStorage<TState>> logger)
        {
            _table = table;
            _partition = partition;
            _jsonSettings = jsonSettings;
            _logger = logger;

            // default values must be included
            // otherwise, we get errors for explicitly specified default values
            // (e.g.  Orleans.Transactions.Azure.Tests.TestState.state)
            _jsonSettings.DefaultValueHandling = DefaultValueHandling.Include;
        }

        public async Task<TransactionalStorageLoadResponse<TState>> Load()
        {
            try
            {
                var keyTask = ReadKey();
                var statesTask = ReadStates();
                _key = await keyTask.ConfigureAwait(false);
                _states = await statesTask.ConfigureAwait(false);

                //? 表中没有存储 ETag，读取如何获得 ETag？
                if (string.IsNullOrEmpty(_key.ETag.ToString()))
                {
                    if (_logger.IsEnabled(LogLevel.Debug))
                        _logger.LogDebug("{Partition} Loaded v0, fresh", _partition);

                    // first time load
                    return new TransactionalStorageLoadResponse<TState>();
                }
                else
                {
                    TState committedState;
                    if (_key.CommittedSequenceId == 0)
                    {
                        committedState = new TState();
                    }
                    else
                    {
                        if (!FindState(_key.CommittedSequenceId, out var pos))
                        {
                            var error = $"Storage state corrupted: no record for committed state v{_key.CommittedSequenceId}";
                            _logger.LogCritical("{Partition} {Error}", _partition, error);
                            throw new InvalidOperationException(error);
                        }
                        committedState = _states[pos].Value.GetState<TState>(_jsonSettings);
                    }

                    var prepareRecordsToRecover = new List<PendingTransactionState<TState>>();
                    for (int i = 0; i < _states.Count; i++)
                    {
                        var kvp = _states[i];

                        // pending states for already committed transactions can be ignored
                        if (kvp.Key <= _key.CommittedSequenceId)
                            continue;

                        // upon recovery, local non-committed transactions are considered aborted
                        if (kvp.Value.TransactionManager == null)
                            break;

                        ParticipantId tm = JsonConvert.DeserializeObject<ParticipantId>(
                            kvp.Value.TransactionManager,
                            _jsonSettings);

                        prepareRecordsToRecover.Add(
                            new PendingTransactionState<TState>
                            {
                                SequenceId = kvp.Key,
                                State = kvp.Value.GetState<TState>(_jsonSettings),
                                TimeStamp = kvp.Value.TransactionTimestamp,
                                TransactionId = kvp.Value.TransactionId,
                                TransactionManager = tm
                            });
                    }

                    // clear the state strings... no longer needed, ok to GC now
                    for (int i = 0; i < _states.Count; i++)
                    {
                        var entity = _states[i].Value;
                        entity.StateJson = null;
                    }

                    if (_logger.IsEnabled(LogLevel.Debug))
                        _logger.LogDebug(
                            "{PartitionKey} Loaded v{CommittedSequenceId} rows={Data}",
                            _partition,
                            _key.CommittedSequenceId,
                            string.Join(",", _states.Select(s => s.Key.ToString("x16", CultureInfo.InvariantCulture))));

                    TransactionalStateMetaData metadata = JsonConvert.DeserializeObject<TransactionalStateMetaData>(
                        _key.Metadata,
                        _jsonSettings);
                    return new TransactionalStorageLoadResponse<TState>(
                        _key.ETag.ToString(),
                        committedState,
                        _key.CommittedSequenceId,
                        metadata,
                        prepareRecordsToRecover);
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Transactional state load failed");
                throw;
            }
        }

        public async Task<string> Store(
            string expectedETag,
            TransactionalStateMetaData metadata,
            List<PendingTransactionState<TState>> statesToPrepare,
            long? commitUpTo,
            long? abortAfter)
        {
            var keyETag = _key.ETag.ToString();
            if ((!string.IsNullOrWhiteSpace(keyETag) || !string.IsNullOrWhiteSpace(expectedETag))
                && keyETag != expectedETag)
            {
                throw new ArgumentException("Etag does not match", nameof(expectedETag));
            }

            // assemble all storage operations into a single batch
            // these operations must commit in sequence, but not necessarily atomically
            // so we can split this up if needed
            var batchOperation = new BatchOperation(_logger, _key, _table);

            // first, clean up aborted records
            if (abortAfter.HasValue && _states.Count != 0)
            {
                while (_states.Count > 0 && _states[^1].Key > abortAfter)
                {
                    var entity = _states[^1].Value;
                    await batchOperation.Add(
                        new TableTransactionAction(TableTransactionActionType.Delete, entity.Entity, entity.ETag))
                        .ConfigureAwait(false);
                    _key.ETag = batchOperation.KeyETag;
                    _states.RemoveAt(_states.Count - 1);

                    if (_logger.IsEnabled(LogLevel.Trace))
                        _logger.LogTrace(
                            "{PartitionKey}.{RowKey} Delete {TransactionId}",
                            _partition,
                            entity.RowKey,
                            entity.TransactionId);
                }
            }

            // second, persist non-obsolete prepare records
            var obsoleteBefore = commitUpTo ?? _key.CommittedSequenceId;
            if (statesToPrepare != null)
                foreach (var s in statesToPrepare)
                    if (s.SequenceId >= obsoleteBefore)
                    {
                        if (FindState(s.SequenceId, out var pos))
                        {
                            // overwrite with new pending state
                            StateEntity existing = _states[pos].Value;
                            existing.TransactionId = s.TransactionId;
                            existing.TransactionTimestamp = s.TimeStamp;
                            existing.TransactionManager = JsonConvert.SerializeObject(
                                s.TransactionManager,
                                _jsonSettings);
                            existing.SetState(s.State, _jsonSettings);
                            await batchOperation.Add(
                                new TableTransactionAction(
                                    TableTransactionActionType.UpdateReplace,
                                    existing.Entity,
                                    existing.ETag))
                                .ConfigureAwait(false);
                            _key.ETag = batchOperation.KeyETag;

                            if (_logger.IsEnabled(LogLevel.Trace))
                                _logger.LogTrace(
                                    "{PartitionKey}.{RowKey} Update {TransactionId}",
                                    _partition,
                                    existing.RowKey,
                                    existing.TransactionId);
                        }
                        else
                        {
                            var entity = StateEntity.Create(_jsonSettings, _partition, s);
                            await batchOperation.Add(
                                new TableTransactionAction(TableTransactionActionType.Add, entity.Entity))
                                .ConfigureAwait(false);
                            _key.ETag = batchOperation.KeyETag;
                            _states.Insert(pos, new KeyValuePair<long, StateEntity>(s.SequenceId, entity));

                            if (_logger.IsEnabled(LogLevel.Trace))
                                _logger.LogTrace(
                                    "{PartitionKey}.{RowKey} Insert {TransactionId}",
                                    _partition,
                                    entity.RowKey,
                                    entity.TransactionId);
                        }
                    }

            // third, persist metadata and commit position
            _key.Metadata = JsonConvert.SerializeObject(metadata, _jsonSettings);
            if (commitUpTo.HasValue && commitUpTo.Value > _key.CommittedSequenceId)
            {
                _key.CommittedSequenceId = commitUpTo.Value;
            }
            if (string.IsNullOrEmpty(_key.ETag.ToString()))
            {
                await batchOperation.Add(new TableTransactionAction(TableTransactionActionType.Add, _key))
                    .ConfigureAwait(false);
                _key.ETag = batchOperation.KeyETag;

                if (_logger.IsEnabled(LogLevel.Trace))
                    _logger.LogTrace(
                        "{PartitionKey}.{RowKey} Insert. v{CommittedSequenceId}, {CommitRecordsCount}c",
                        _partition,
                        KeyEntity.RK,
                        _key.CommittedSequenceId,
                        metadata.CommitRecords.Count);
            }
            else
            {
                await batchOperation.Add(
                    new TableTransactionAction(TableTransactionActionType.UpdateReplace, _key, _key.ETag))
                    .ConfigureAwait(false);
                _key.ETag = batchOperation.KeyETag;

                if (_logger.IsEnabled(LogLevel.Trace))
                    _logger.LogTrace(
                        "{PartitionKey}.{RowKey} Update. v{CommittedSequenceId}, {CommitRecordsCount}c",
                        _partition,
                        KeyEntity.RK,
                        _key.CommittedSequenceId,
                        metadata.CommitRecords.Count);
            }

            // fourth, remove obsolete records
            if (_states.Count > 0 && _states[0].Key < obsoleteBefore)
            {
                _ = FindState(obsoleteBefore, out var pos);
                for (int i = 0; i < pos; i++)
                {
                    await batchOperation.Add(
                        new TableTransactionAction(
                            TableTransactionActionType.Delete,
                            _states[i].Value.Entity,
                            _states[i].Value.ETag))
                        .ConfigureAwait(false);
                    _key.ETag = batchOperation.KeyETag;

                    if (_logger.IsEnabled(LogLevel.Trace))
                        _logger.LogTrace(
                            "{PartitionKey}.{RowKey} Delete {TransactionId}",
                            _partition,
                            _states[i].Value.RowKey,
                            _states[i].Value.TransactionId);
                }
                _states.RemoveRange(0, pos);
            }

            await batchOperation.Flush().ConfigureAwait(false);

            if (_logger.IsEnabled(LogLevel.Debug))
                _logger.LogDebug(
                    "{PartitionKey} Stored v{CommittedSequenceId} eTag={ETag}",
                    _partition,
                    _key.CommittedSequenceId,
                    _key.ETag);

            return _key.ETag.ToString();
        }

        private bool FindState(long sequenceId, out int pos)
        {
            pos = 0;
            while (pos < _states.Count)
            {
                switch (_states[pos].Key.CompareTo(sequenceId))
                {
                    case 0: // equal
                        return true;
                    case -1: // smaller
                        pos++;
                        continue;
                    case 1: // greater, and no equals
                        return false;
                    default:
                        throw new NotImplementedException();
                }
            }
            return false;
        }

        private async Task<KeyEntity> ReadKey()
        {
            var queryResult = _table.QueryAsync<KeyEntity>(AzureTableUtils.PointQuery(_partition, KeyEntity.RK))
                .ConfigureAwait(false);
            await foreach (var result in queryResult)
            {
#pragma warning disable S1751 // Loops with at most one iteration should be refactored
                // only one record
                return result;
#pragma warning restore S1751 // Loops with at most one iteration should be refactored
            }

            return new KeyEntity { PartitionKey = _partition, RowKey = KeyEntity.RK };
        }

        private async Task<List<KeyValuePair<long, StateEntity>>> ReadStates()
        {
            var query = AzureTableUtils.RangeQuery(_partition, StateEntity.RK_MIN, StateEntity.RK_MAX);
            var results = new List<KeyValuePair<long, StateEntity>>();
            var queryResult = _table.QueryAsync<TableEntity>(query).ConfigureAwait(false);
            await foreach (var entity in queryResult)
            {
                var state = new StateEntity(entity);
                results.Add(new KeyValuePair<long, StateEntity>(state.SequenceId, state));
            }
            return results;
        }

        private class BatchOperation
        {
            private readonly List<TableTransactionAction> _batchOperation;
            private readonly ILogger _logger;
            private readonly TableClient _table;
            private KeyEntity _key;

            private int _keyIndex = -1;

            public BatchOperation(ILogger logger, KeyEntity key, TableClient table)
            {
                _batchOperation = [];
                this._logger = logger;
                this._key = key;
                this._table = table;
            }

            public ETag KeyETag => _key.ETag;

            private bool BatchHasKey => _keyIndex >= 0;

            public async ValueTask Add(TableTransactionAction operation)
            {
                if (!BatchHasKey
                    && operation.Entity.RowKey == _key.RowKey
                    && operation.Entity.PartitionKey == _key.PartitionKey)
                {
                    _key = (KeyEntity)operation.Entity;
                    _keyIndex = _batchOperation.Count;
                }

                _batchOperation.Add(operation);

                if (_batchOperation.Count == AzureTableConstants.MaxBatchSize - (BatchHasKey ? 0 : 1))
                {
                    // the key serves as a synchronizer, to prevent modification by multiple grains under edge conditions,
                    // like duplicate activations or deployments.Every batch write needs to include the key,
                    // even if the key values don't change.

                    if (!BatchHasKey)
                    {
                        _keyIndex = _batchOperation.Count;
                        if (string.IsNullOrEmpty(_key.ETag.ToString()))
                        {
                            _batchOperation.Add(new TableTransactionAction(TableTransactionActionType.Add, _key));
                        }
                        else
                        {
                            _batchOperation.Add(
                                new TableTransactionAction(TableTransactionActionType.UpdateReplace, _key, _key.ETag));
                        }
                    }

                    await Flush().ConfigureAwait(false);
                }
            }

            public async Task Flush()
            {
                if (_batchOperation.Count > 0)
                {
                    try
                    {
                        var batchResponse = await _table.SubmitTransactionAsync(_batchOperation).ConfigureAwait(false);

                        if (batchResponse?.Value is { Count: > 0 } responses
                            && BatchHasKey
                            && responses.Count >= _keyIndex
                            && responses[_keyIndex].Headers.ETag is { } etag)
                        {
                            _key.ETag = etag;
                        }

                        if (_logger.IsEnabled(LogLevel.Trace))
                        {
                            for (int i = 0; i < _batchOperation.Count; i++)
                            {
                                _logger.LogTrace(
                                    "{PartitionKey}.{RowKey} batch-op ok {BatchCount}",
                                    _batchOperation[i].Entity.PartitionKey,
                                    _batchOperation[i].Entity.RowKey,
                                    i);
                            }
                        }

                        _batchOperation.Clear();
                        _keyIndex = -1;
                    }
                    catch (Exception ex)
                    {
                        if (_logger.IsEnabled(LogLevel.Trace))
                        {
                            for (int i = 0; i < _batchOperation.Count; i++)
                            {
                                _logger.LogTrace(
                                    "{PartitionKey}.{RowKey} batch-op failed {BatchCount}",
                                    _batchOperation[i].Entity.PartitionKey,
                                    _batchOperation[i].Entity.RowKey,
                                    i);
                            }
                        }

                        _logger.LogError(ex, "Transactional state store failed.");
                        throw;
                    }
                }
            }
        }
    }
}
