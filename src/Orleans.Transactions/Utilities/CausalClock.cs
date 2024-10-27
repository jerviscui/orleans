using System;

namespace Orleans.Transactions
{
    public class CausalClock
    {
        private readonly object _lockable = new object();
        private readonly IClock _clock;
        private long _previous;

        public CausalClock(IClock clock)
        {
            this._clock = clock ?? throw new ArgumentNullException(nameof(clock));
        }

        public DateTime UtcNow()
        {
            lock (this._lockable)
            {
                var ticks = _previous = Math.Max(_previous + 1, this._clock.UtcNow().Ticks);
                return new DateTime(ticks, DateTimeKind.Utc);
            }
        }

        /// <summary>
        /// 更新时间
        /// </summary>
        public DateTime Merge(DateTime timestamp)
        {
            lock (this._lockable)
            {
                var ticks = _previous = Math.Max(_previous, timestamp.Ticks);
                return new DateTime(ticks, DateTimeKind.Utc);
            }
        }

        /// <summary>
        /// 将时间设置为较大的值，保证消息链中的时间单调递增
        /// </summary>
        public DateTime MergeUtcNow(DateTime timestamp)
        {
            lock (this._lockable)
            {
                var ticks =
                    _previous = Math.Max(Math.Max(_previous + 1, timestamp.Ticks + 1), this._clock.UtcNow().Ticks);
                return new DateTime(ticks, DateTimeKind.Utc);
            }
        }
    }
}
