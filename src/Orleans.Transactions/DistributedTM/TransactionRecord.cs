using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Orleans.Transactions
{
    /// <summary>
    /// Each participant plays a particular role in the commit protocol
    /// </summary>
    internal enum CommitRole
    {
        NotYetDetermined,  // role is known only when prepare message is received from TA
        ReadOnly,          // this participant has not written
        RemoteCommit,      // this participant has written, but is not the TM
        LocalCommit,       // this participant has written, and is the TM
    }

    /// <summary>
    /// Record that is kept for each transaction at each participant
    /// </summary>
    /// <typeparam name="TState">The type of state</typeparam>
    internal class TransactionRecord<TState>
    {
        public TransactionRecord()
        {
        }

        /// <summary>
        /// a unique identifier for this transaction
        /// </summary>
        public Guid TransactionId;

        // the time at which this transaction was started on the TA
        public DateTime Priority;

        /// <summary>
        /// a deadline for the transaction to complete successfully, set by the TA
        /// <para>transaction 等待锁可用的最大时间</para>
        /// </summary>
        public DateTime Deadline;

        /// <summary>
        /// the transaction timestamp as computed by the algorithm
        /// </summary>
        public DateTime Timestamp;

        // the number of reads and writes that this transaction has performed on this transactional participant
        public int NumberReads;
        public int NumberWrites;

        // the state for this transaction, and the sequence number of this state
        public TState State;
        public long SequenceNumber;
        public bool HasCopiedState;

        public void AddRead()
        {
            NumberReads++;
        }

        public void AddWrite()
        {
            NumberWrites++;
        }

        public CommitRole Role;

        /// <summary>
        /// used for readonly and local commit
        /// </summary>
        public TaskCompletionSource<TransactionalStatus> PromiseForTA;

        /// <summary>
        /// used for local and remote commit
        /// </summary>
        public ParticipantId TransactionManager;

        // used for local commit
        public List<ParticipantId> WriteParticipants;
        public int WaitCount;
        public DateTime WaitingSince;

        // used for remote commit
        public DateTime? LastSent;
        public bool PrepareIsPersisted;
        public TaskCompletionSource<bool> ConfirmationResponsePromise;

        /// <summary>
        /// Indicates whether a transaction record is ready to commit
        /// </summary>
        public bool ReadyToCommit
        {
            get
            {
                switch (Role)
                {
                    case CommitRole.ReadOnly:
                        return true;

                    case CommitRole.LocalCommit:
                        return WaitCount == 0; // received all "Prepared" messages

                    case CommitRole.RemoteCommit:
                        return
                            (ConfirmationResponsePromise != null)  // TM has sent confirm and is waiting for response
                            || (NumberWrites == 0 && LastSent.HasValue);  // this participant did not write and finished prepare
                    case CommitRole.NotYetDetermined:
                    default:
                        throw new NotSupportedException($"{Role} is not a supported CommitRole.");
                }
            }
        }

        public bool IsReadOnly
        {
            get
            {
                switch (Role)
                {
                    case CommitRole.ReadOnly:
                        return true;
                    case CommitRole.LocalCommit:
                        return false;
                    case CommitRole.RemoteCommit:
                        return NumberWrites == 0;
                    case CommitRole.NotYetDetermined:
                    default:
                        throw new NotSupportedException($"{Role} is not a supported CommitRole.");
                }
            }
        }

        public bool Batchable
        {
            get
            {
                switch (Role)
                {
                    case CommitRole.ReadOnly:
                    case CommitRole.LocalCommit:
                        return true;
                    case CommitRole.RemoteCommit:
                        return NumberWrites == 0;
                    case CommitRole.NotYetDetermined:
                    default:
                        throw new NotImplementedException();
                }
            }
        }

        // formatted for debugging commit queue contents
        public override string ToString()
        {
            return Role switch
            {
                CommitRole.NotYetDetermined => $"ND tid={TransactionId} v{SequenceNumber}",
                CommitRole.ReadOnly => $"RE tid={TransactionId} v{SequenceNumber}",
                CommitRole.LocalCommit => $"LCE tid={TransactionId} v{SequenceNumber} wc={WaitCount} rtb={ReadyToCommit}",
                CommitRole.RemoteCommit => $"RCE tid={TransactionId} v{SequenceNumber} pip={PrepareIsPersisted} ls={LastSent.HasValue} ro={IsReadOnly} rtb={ReadyToCommit} tm={TransactionManager}",
                _ => throw new NotSupportedException($"{Role} is not a supported CommitRole."),
            };
        }
    }
}
