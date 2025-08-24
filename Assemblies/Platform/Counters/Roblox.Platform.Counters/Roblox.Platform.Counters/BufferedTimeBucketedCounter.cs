using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;
using Roblox.EventLog;
using Roblox.Platform.Counters.Properties;

namespace Roblox.Platform.Counters;

internal class BufferedTimeBucketedCounter : ITimeBucketedCounter, IDisposable
{
	private ConcurrentDictionary<DateTime, double> _Updates;

	private readonly ITimeBucketedCounter _TimeBucketedCounter;

	private readonly ILogger _Logger;

	private readonly TimeSpan _CommitInterval;

	private readonly System.Timers.Timer _CommitTimer;

	private int MaxDegreeOfParallelismBufferedCounterCommit => Settings.Default.DefaultMaxDegreeOfParallelismBufferedCounterCommit;

	private TimeSpan _DefaultBufferedCounterCommitInterval => Settings.Default.DefaultBufferedCounterCommitInterval;

	/// <summary>
	/// Creates a new BufferedTimeBucketedCounter
	/// </summary>
	/// <param name="timeBucketedCounter">An <see cref="T:Roblox.Platform.Counters.ITimeBucketedCounter" /></param>
	/// <param name="commitInterval">How often to send updates to the service</param>
	/// <param name="logger">An <see cref="T:Roblox.EventLog.ILogger" /></param>
	public BufferedTimeBucketedCounter(ITimeBucketedCounter timeBucketedCounter, TimeSpan? commitInterval, ILogger logger)
	{
		_TimeBucketedCounter = timeBucketedCounter ?? throw new ArgumentNullException("timeBucketedCounter");
		_Logger = logger ?? throw new ArgumentNullException("timeBucketedCounter");
		_CommitInterval = commitInterval ?? _DefaultBufferedCounterCommitInterval;
		_CommitTimer = new System.Timers.Timer(_CommitInterval.TotalMilliseconds);
		_CommitTimer.Elapsed += delegate
		{
			DoCommit();
		};
		_Updates = new ConcurrentDictionary<DateTime, double>();
	}

	/// <inheritdoc cref="M:Roblox.Platform.Counters.ITimeBucketedCounter.Decrement(System.DateTime,System.Double)" />
	public void Decrement(DateTime timeStamp, double value = 1.0)
	{
		DateTime roundedTimestamp = ToLowestTimeUnitForCounterType(_TimeBucketedCounter.GetCounterType(), timeStamp);
		_Updates.AddOrUpdate(roundedTimestamp, 0.0 - value, (DateTime k, double v) => v - value);
		_CommitTimer.Enabled = true;
	}

	/// <inheritdoc cref="M:Roblox.Platform.Counters.ITimeBucketedCounter.Increment(System.DateTime,System.Double)" />
	public void Increment(DateTime timeStamp, double value = 1.0)
	{
		DateTime roundedTimestamp = ToLowestTimeUnitForCounterType(_TimeBucketedCounter.GetCounterType(), timeStamp);
		_Updates.AddOrUpdate(roundedTimestamp, value, (DateTime k, double v) => v + value);
		_CommitTimer.Enabled = true;
	}

	/// <inheritdoc cref="M:Roblox.Platform.Counters.ITimeBucketedCounter.IncrementInBackground(System.DateTime,System.Double,System.Action{System.Exception})" />
	public void IncrementInBackground(DateTime timeStamp, double value = 1.0, Action<Exception> exceptionHandler = null)
	{
		Increment(timeStamp, value);
	}

	/// <inheritdoc cref="M:Roblox.Platform.Counters.ITimeBucketedCounter.DecrementInBackground(System.DateTime,System.Double,System.Action{System.Exception})" />
	public void DecrementInBackground(DateTime timeStamp, double value = 1.0, Action<Exception> exceptionHandler = null)
	{
		Decrement(timeStamp, value);
	}

	/// <inheritdoc cref="M:Roblox.Platform.Counters.ITimeBucketedCounter.GetCountByBucketByStartDate(System.DateTime)" />
	public double GetCountByBucketByStartDate(DateTime dateTime)
	{
		return _TimeBucketedCounter.GetCountByBucketByStartDate(dateTime);
	}

	/// <inheritdoc cref="M:Roblox.Platform.Counters.ITimeBucketedCounter.GetKey" />
	public string GetKey()
	{
		return _TimeBucketedCounter.GetKey();
	}

	/// <inheritdoc cref="M:Roblox.Platform.Counters.ITimeBucketedCounter.GetCounterType" />
	public CounterType GetCounterType()
	{
		return _TimeBucketedCounter.GetCounterType();
	}

	/// <inheritdoc cref="M:Roblox.Platform.Counters.ITimeBucketedCounter.GetCountForDate(System.DateTime)" />
	public double GetCountForDate(DateTime date)
	{
		return _TimeBucketedCounter.GetCountForDate(date);
	}

	/// <inheritdoc cref="M:Roblox.Platform.Counters.ITimeBucketedCounter.GetCount(Roblox.Platform.Counters.Frequency)" />
	public double GetCount(Frequency frequency)
	{
		return _TimeBucketedCounter.GetCount(frequency);
	}

	/// <inheritdoc cref="M:Roblox.Platform.Counters.ITimeBucketedCounter.GetCounterValues(System.DateTime,System.DateTime)" />
	public IEnumerable<CounterValue> GetCounterValues(DateTime start, DateTime end)
	{
		return _TimeBucketedCounter.GetCounterValues(start, end);
	}

	internal void Commit(ConcurrentDictionary<DateTime, double> updates)
	{
		if (updates.IsEmpty)
		{
			_CommitTimer.Enabled = false;
			return;
		}
		try
		{
			ParallelOptions parallelOptions = new ParallelOptions
			{
				MaxDegreeOfParallelism = MaxDegreeOfParallelismBufferedCounterCommit
			};
			Parallel.ForEach(updates, parallelOptions, delegate(KeyValuePair<DateTime, double> kvp)
			{
				_TimeBucketedCounter.Increment(kvp.Key, kvp.Value);
			});
		}
		catch (Exception ex)
		{
			_Logger.Error(ex);
		}
	}

	internal void DoCommit()
	{
		ConcurrentDictionary<DateTime, double> newDictionary = new ConcurrentDictionary<DateTime, double>();
		ConcurrentDictionary<DateTime, double> toCommit = Interlocked.Exchange(ref _Updates, newDictionary);
		Commit(toCommit);
	}

	public void Dispose()
	{
		_CommitTimer?.Dispose();
		DoCommit();
	}

	private static DateTime ToLowestTimeUnitForCounterType(CounterType counterType, DateTime input)
	{
		if (counterType.HasFlag(CounterType.Hourly))
		{
			return ConvertTimeToLowestHour(input);
		}
		if (counterType.HasFlag(CounterType.Daily))
		{
			return ConvertTimeToLowestDay(input);
		}
		if (counterType.HasFlag(CounterType.Monthly))
		{
			return ConvertTimeToLowestMonth(input);
		}
		throw new ArgumentException($"Unknown {counterType}");
	}

	private static DateTime ConvertTimeToLowestHour(DateTime startDate)
	{
		return startDate.Date.AddHours(startDate.Hour);
	}

	private static DateTime ConvertTimeToLowestDay(DateTime startDate)
	{
		return new DateTime(startDate.Year, startDate.Month, startDate.Day);
	}

	private static DateTime ConvertTimeToLowestMonth(DateTime startDate)
	{
		return new DateTime(startDate.Year, startDate.Month, 1);
	}
}
