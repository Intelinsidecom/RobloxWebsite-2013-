using System;

namespace Roblox.Platform.Counters;

/// <summary>
/// Provides durable counters
/// </summary>
public interface IDurableCounterFactory
{
	/// <summary>
	/// Constructs the counter key and returns the associated bucketed counter
	/// </summary>
	/// <param name="targetType">counter's type</param>
	/// <param name="counterGroup">counter's group</param>
	/// <param name="targetEntityId">counter's entity id</param>
	/// <returns>a <see cref="T:Roblox.Platform.Counters.ITimeBucketedCounter" /> with the specified configuration</returns>
	[Obsolete("Should be using GetTimeBucketedCounter(CounterType counterType, string targetType, string counterGroup, long targetEntityId) instead.")]
	ITimeBucketedCounter GetTimeBucketedCounter(string targetType, string counterGroup, long targetEntityId);

	/// <summary>
	/// Gets a time bucketed counter for a key
	/// </summary>
	/// <param name="counterKey">the counter key</param>
	/// <returns>a <see cref="T:Roblox.Platform.Counters.ITimeBucketedCounter" /> with the specified configuration</returns>
	[Obsolete("Should be using GetTimeBucketedCounter(CounterType counterType, string counterKey) instead.")]
	ITimeBucketedCounter GetTimeBucketedCounter(string counterKey);

	/// <summary>
	/// Gets a time bucketed counter for a key
	/// </summary>
	/// <param name="counterType">counter's time buckets</param>
	/// <param name="counterKey">the counter key</param>
	/// <returns>a <see cref="T:Roblox.Platform.Counters.ITimeBucketedCounter" /> with the specified configuration</returns>
	ITimeBucketedCounter GetTimeBucketedCounter(CounterType counterType, string counterKey);

	/// <summary>
	/// Constructs the counter key and returns the associated bucketed counter
	/// </summary>
	/// <param name="counterType">counter's time buckets</param>
	/// <param name="targetType">counter's type</param>
	/// <param name="counterGroup">counter's group</param>
	/// <param name="targetEntityId">counter's entity id</param>
	/// <returns>a <see cref="T:Roblox.Platform.Counters.ITimeBucketedCounter" /> with the specified configuration</returns>
	ITimeBucketedCounter GetTimeBucketedCounter(CounterType counterType, string targetType, string counterGroup, long targetEntityId);

	/// <summary>
	/// Constructs the counter key and returns the associated counter 
	/// </summary>
	/// <param name="targetType">counter's type</param>
	/// <param name="counterType">counter's group</param>
	/// <param name="targetEntityId">counter's entity id</param>
	/// <returns>a <see cref="T:Roblox.Platform.Counters.ICounter" /> with the specified configuration</returns>
	ICounter GetCounter(string targetType, string counterType, long targetEntityId);

	/// <summary>
	/// Gets a counter for a key
	/// </summary>
	/// <param name="counterKey">counter's key</param>
	/// <returns>a <see cref="T:Roblox.Platform.Counters.ICounter" /> with the specified configuration</returns>
	ICounter GetCounter(string counterKey);
}
