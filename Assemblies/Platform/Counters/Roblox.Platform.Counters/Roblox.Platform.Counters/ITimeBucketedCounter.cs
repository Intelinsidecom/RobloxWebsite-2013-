using System;
using System.Collections.Generic;

namespace Roblox.Platform.Counters;

/// <summary>
/// A counter bucketed by time
/// </summary>
public interface ITimeBucketedCounter
{
	/// <summary>
	/// Get the counter's value at a specified date's bucket
	/// </summary>
	/// <param name="date">bucket's date</param>
	/// <returns>the counter at the specified <see cref="T:System.DateTime" /></returns>
	double GetCountForDate(DateTime date);

	/// <summary>
	/// Returns the counter's values for the specified time frequency
	/// </summary>
	/// <param name="timeFrequency">An <see cref="T:Roblox.Platform.Counters.Frequency" /></param>
	/// <returns>counter's value within the specified frequency</returns>
	double GetCount(Frequency timeFrequency);

	/// <summary>
	/// Returns the counter's value for the bucket whose start and end dates bound the argument
	/// </summary>
	/// <param name="dateTime">A DateTime that occurs within the bucket for which you wish to retrieve the count.</param>
	/// <returns></returns>
	double GetCountByBucketByStartDate(DateTime dateTime);

	/// <summary>
	/// Returns the counter's key
	/// </summary>
	/// <returns>counter's key</returns>
	string GetKey();

	/// <summary>
	/// Increments the counter at a specified date
	/// </summary>
	/// <param name="timeStamp">increment counter at this timestamp</param>
	/// <param name="value">increment by</param>
	void Increment(DateTime timeStamp, double value = 1.0);

	/// <summary>
	/// Decrements the counter at a specified date
	/// </summary>
	/// <param name="timeStamp">decrement counter at this timestamp</param>
	/// <param name="value">decrement by</param>
	void Decrement(DateTime timeStamp, double value = 1.0);

	/// <summary>
	/// Gets a list of counter buckets
	/// </summary>
	/// <param name="startDate">time of the first sample</param>
	/// <param name="endDate">time of the last sample</param>
	/// <returns>An <see cref="T:System.Collections.Generic.IEnumerable`1" /> containing the buckets between the two dates</returns>
	IEnumerable<CounterValue> GetCounterValues(DateTime startDate, DateTime endDate);

	/// <summary>
	/// Increments the counter at a specified date without blocking the thread
	/// </summary>
	/// <param name="timeStamp">increment counter at this timestamp</param>
	/// <param name="value">increment by</param>
	/// <param name="exceptionHandler">handler to call if an exception occurs</param>
	[Obsolete("Should be using a buffered counter instead.")]
	void IncrementInBackground(DateTime timeStamp, double value = 1.0, Action<Exception> exceptionHandler = null);

	/// <summary>
	/// Decrements the counter at a specified date without blocking the thread
	/// </summary>
	/// <param name="timeStamp">decrement counter at this timestamp</param>
	/// <param name="value">decrement by</param>
	/// <param name="exceptionHandler">handler to call if an exception occurs</param>
	[Obsolete("Should be using a buffered counter instead.")]
	void DecrementInBackground(DateTime timeStamp, double value = 1.0, Action<Exception> exceptionHandler = null);

	/// <summary>
	/// Gets the counter's <see cref="T:Roblox.Platform.Counters.CounterType" />
	/// </summary>
	/// <returns>the counter's <see cref="T:Roblox.Platform.Counters.CounterType" /></returns>
	CounterType GetCounterType();
}
