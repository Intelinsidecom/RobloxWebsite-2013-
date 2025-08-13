using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Roblox.DurableCounters.Client;
using Roblox.EventLog;

namespace Roblox.Platform.Counters;

/// <summary>
/// Default implementation of an <see cref="T:Roblox.Platform.Counters.ITimeBucketedCounter" />
/// </summary>
internal class TimeBucketedCounter : ITimeBucketedCounter
{
	private readonly IDurableCountersClient _DurableCountersClient;

	private readonly string _CounterKey;

	private readonly CounterType _CounterType;

	private readonly CounterType _ClientCounterType;

	/// <summary>
	/// Constructs a new <see cref="T:Roblox.Platform.Counters.TimeBucketedCounter" />.
	/// </summary>
	/// <param name="client">An <see cref="T:Roblox.DurableCounters.Client.IDurableCountersClient" />.</param>
	/// <param name="counterType">An <see cref="T:Roblox.Platform.Counters.CounterType" />.</param>
	/// <param name="counterKey">The counter's key.</param>
	/// <param name="logger">An <see cref="T:Roblox.EventLog.ILogger" />.</param>
	internal TimeBucketedCounter(IDurableCountersClient client, CounterType counterType, string counterKey, ILogger logger)
	{
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		_DurableCountersClient = client ?? throw new ArgumentNullException("client");
		_CounterKey = counterKey ?? throw new ArgumentNullException("counterKey");
		_CounterType = counterType;
		_ClientCounterType = (CounterType)counterType;
	}

	/// <inheritdoc />
	public double GetCount(Frequency timeFrequency)
	{
		DateTime endDate = DateTime.Now.AddHours(-1.0);
		return GetCount(timeFrequency switch
		{
			Frequency.PastMonth => DateTime.Now.AddMonths(-1), 
			Frequency.PastWeek => DateTime.Now.AddDays(-7.0), 
			Frequency.Past3Days => DateTime.Now.AddDays(-3.0), 
			Frequency.PastDay => DateTime.Now.AddDays(-1.0), 
			Frequency.Past12Hours => DateTime.Now.AddHours(-12.0), 
			_ => DateTime.Now.AddDays(-1.0), 
		}, endDate);
	}

	/// <inheritdoc />
	public CounterType GetCounterType()
	{
		return _CounterType;
	}

	/// <inheritdoc />
	public double GetCountForDate(DateTime date)
	{
		return GetCount(date.Date, date.Date.AddDays(1.0));
	}

	/// <inheritdoc />
	public double GetCountByBucketByStartDate(DateTime dateTime)
	{
		var (bucketBeginning, bucketEnding) = GetStartAndEnd(dateTime);
		return GetCount(bucketBeginning, bucketEnding);
	}

	internal (DateTime StartDate, DateTime EndDate) GetStartAndEnd(DateTime someDateTimeInTheBucketRange)
	{
		DateTime start;
		DateTime end;
		switch (_CounterType)
		{
		case CounterType.Hourly:
			start = StartOfHour(someDateTimeInTheBucketRange);
			end = EndOfHour(someDateTimeInTheBucketRange);
			break;
		case CounterType.Daily:
			start = StartOfDay(someDateTimeInTheBucketRange);
			end = EndOfDay(someDateTimeInTheBucketRange);
			break;
		case CounterType.Monthly:
			start = StartOfMonth(someDateTimeInTheBucketRange);
			end = EndOfMonth(someDateTimeInTheBucketRange);
			break;
		case CounterType.AllTime:
			start = DateTime.MinValue;
			end = DateTime.MaxValue;
			break;
		default:
			throw new ArgumentException("Unsupported CounterType in TimeBucketedCounter");
		}
		return (start, end);
	}

	internal DateTime StartOfHour(DateTime someDateTime)
	{
		return new DateTime(someDateTime.Year, someDateTime.Month, someDateTime.Day, someDateTime.Hour, 0, 0);
	}

	internal DateTime EndOfHour(DateTime someDateTime)
	{
		return StartOfHour(someDateTime.AddHours(1.0)).Subtract(TimeSpan.FromMilliseconds(1.0));
	}

	internal DateTime StartOfDay(DateTime someDateTime)
	{
		return new DateTime(someDateTime.Year, someDateTime.Month, someDateTime.Day);
	}

	internal DateTime EndOfDay(DateTime someDateTime)
	{
		return StartOfDay(someDateTime.AddDays(1.0)).Subtract(TimeSpan.FromMilliseconds(1.0));
	}

	internal DateTime StartOfMonth(DateTime someDateTime)
	{
		return new DateTime(someDateTime.Year, someDateTime.Month, 1);
	}

	internal DateTime EndOfMonth(DateTime someDateTime)
	{
		return StartOfMonth(someDateTime.AddMonths(1)).Subtract(TimeSpan.FromMilliseconds(1.0));
	}

	private double GetCount(DateTime fromDate, DateTime endDate)
	{
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		return _DurableCountersClient.GetCount(_CounterKey, _ClientCounterType, (DateTime?)fromDate, (DateTime?)endDate, true, (TimeSpan?)null);
	}

	/// <inheritdoc />
	public IEnumerable<CounterValue> GetCounterValues(DateTime startDate, DateTime endDate)
	{
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		return (from c in _DurableCountersClient.GetCounterValues(_CounterKey, startDate, endDate, true, _ClientCounterType)
			select new CounterValue(c)).ToArray();
	}

	/// <inheritdoc />
	public void IncrementInBackground(DateTime timeStamp, double value = 1.0, Action<Exception> exceptionHandler = null)
	{
		QueueDurableCountersApiCall(delegate
		{
			Increment(timeStamp, value);
		}, exceptionHandler);
	}

	/// <inheritdoc />
	public void DecrementInBackground(DateTime timeStamp, double value = 1.0, Action<Exception> exceptionHandler = null)
	{
		QueueDurableCountersApiCall(delegate
		{
			Decrement(timeStamp, value);
		}, exceptionHandler);
	}

	/// <inheritdoc />
	public void Increment(DateTime timeStamp, double value = 1.0)
	{
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		_DurableCountersClient.Increment(_CounterKey, value, _ClientCounterType, (DateTime?)timeStamp);
	}

	/// <inheritdoc />
	public void Decrement(DateTime timeStamp, double value = 1.0)
	{
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		_DurableCountersClient.Decrement(_CounterKey, value, _ClientCounterType, (DateTime?)timeStamp);
	}

	/// <inheritdoc />
	public string GetKey()
	{
		return _CounterKey;
	}

	protected void QueueDurableCountersApiCall(Action action, Action<Exception> errorLogger = null)
	{
		Task.Factory.StartNew(delegate
		{
			try
			{
				action();
			}
			catch (Exception obj)
			{
				if (errorLogger != null)
				{
					try
					{
						errorLogger(obj);
						return;
					}
					catch
					{
						return;
					}
				}
			}
		});
	}
}
