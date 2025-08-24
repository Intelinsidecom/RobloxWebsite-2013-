using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;

namespace Roblox.DurableCounters.Client
{
    [Flags]
    public enum CounterType
    {
        Hourly = 4,
        Daily = 8,
        Monthly = 0x10,
        AllTime = 0x20,
    }

    public sealed class CounterValue
    {
        public DateTime Bucket { get; set; }
        public double Value { get; set; }
    }

    public interface IDurableCountersClient
    {
        void Increment(string counterKey, double value, CounterType counterType, DateTime? timeStamp);
        void Decrement(string counterKey, double value, CounterType counterType, DateTime? timeStamp);

        double GetCount(string counterKey, CounterType counterType, DateTime? from, DateTime? to, bool useCache, TimeSpan? cacheDuration);
        IEnumerable<CounterValue> GetCounterValues(string counterKey, DateTime start, DateTime end, bool useCache, CounterType counterType);
    }

    // Simple in-memory implementation to allow the platform to function without external services.
    public sealed class InProcessDurableCountersClient : IDurableCountersClient
    {
        private readonly ConcurrentDictionary<string, ConcurrentDictionary<DateTime, double>> _store = new();

        public void Increment(string counterKey, double value, CounterType counterType, DateTime? timeStamp)
        {
            Add(counterKey, Math.Abs(value), counterType, timeStamp);
        }

        public void Decrement(string counterKey, double value, CounterType counterType, DateTime? timeStamp)
        {
            Add(counterKey, -Math.Abs(value), counterType, timeStamp);
        }

        public double GetCount(string counterKey, CounterType counterType, DateTime? from, DateTime? to, bool useCache, TimeSpan? cacheDuration)
        {
            if (!_store.TryGetValue(counterKey, out var series)) return 0d;
            var start = from ?? DateTime.MinValue;
            var end = to ?? DateTime.MaxValue;
            return series.Where(kv => kv.Key >= start && kv.Key <= end).Sum(kv => kv.Value);
        }

        public IEnumerable<CounterValue> GetCounterValues(string counterKey, DateTime start, DateTime end, bool useCache, CounterType counterType)
        {
            if (!_store.TryGetValue(counterKey, out var series)) return Enumerable.Empty<CounterValue>();
            return series.Where(kv => kv.Key >= start && kv.Key <= end)
                         .OrderBy(kv => kv.Key)
                         .Select(kv => new CounterValue { Bucket = kv.Key, Value = kv.Value })
                         .ToArray();
        }

        private void Add(string counterKey, double value, CounterType counterType, DateTime? timeStamp)
        {
            var ts = timeStamp ?? DateTime.Now;
            var bucket = GetBucket(counterType, ts);
            var series = _store.GetOrAdd(counterKey, _ => new ConcurrentDictionary<DateTime, double>());
            series.AddOrUpdate(bucket, value, (_, existing) => existing + value);
        }

        private static DateTime GetBucket(CounterType type, DateTime ts)
        {
            return type switch
            {
                CounterType.Hourly => new DateTime(ts.Year, ts.Month, ts.Day, ts.Hour, 0, 0),
                CounterType.Daily => new DateTime(ts.Year, ts.Month, ts.Day, 0, 0, 0),
                CounterType.Monthly => new DateTime(ts.Year, ts.Month, 1, 0, 0, 0),
                CounterType.AllTime => DateTime.MinValue,
                _ => ts,
            };
        }
    }
}
