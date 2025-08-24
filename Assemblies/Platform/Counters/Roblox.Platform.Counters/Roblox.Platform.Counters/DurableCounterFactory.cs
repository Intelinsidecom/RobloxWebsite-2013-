using System;
using Roblox.DurableCounters.Client;
using Roblox.EventLog;

namespace Roblox.Platform.Counters;

/// <summary>
/// The default implementation of a IDurableCounterFactory, each update to a counter triggers a call to the service.
/// </summary>
public class DurableCounterFactory : IDurableCounterFactory
{
	private readonly IDurableCountersClient _DurableCountersClient;

	private readonly ILogger _Logger;

	/// <summary>
	/// Creates a new <see cref="T:Roblox.Platform.Counters.DurableCounterFactory" /> with a default logger
	/// </summary>
	/// <param name="durableCountersClient">An <see cref="T:Roblox.DurableCounters.Client.DurableCountersClient" /></param>
	/// <param name="logger">An <see cref="T:Roblox.EventLog.ILogger" /></param>
	public DurableCounterFactory(IDurableCountersClient durableCountersClient, ILogger logger)
	{
		_DurableCountersClient = durableCountersClient ?? throw new ArgumentNullException("durableCountersClient");
		_Logger = logger ?? throw new ArgumentNullException("logger");
	}

	/// <inheritdoc />
	public ITimeBucketedCounter GetTimeBucketedCounter(string targetType, string counterGroup, long targetEntityId)
	{
		return GetTimeBucketedCounter(CounterType.Hourly, targetType, counterGroup, targetEntityId);
	}

	/// <inheritdoc />
	public ITimeBucketedCounter GetTimeBucketedCounter(string counterKey)
	{
		return GetTimeBucketedCounter(CounterType.Hourly, counterKey);
	}

	/// <inheritdoc />
	public ITimeBucketedCounter GetTimeBucketedCounter(CounterType counterType, string targetType, string counterGroup, long targetEntityId)
	{
		string key = $"{targetType}{counterGroup}_{targetEntityId}";
		return GetTimeBucketedCounter(counterType, key);
	}

	/// <inheritdoc />
	public ITimeBucketedCounter GetTimeBucketedCounter(CounterType counterType, string counterKey)
	{
		return new TimeBucketedCounter(_DurableCountersClient, counterType, counterKey, _Logger);
	}

	/// <inheritdoc />
	public ICounter GetCounter(string targetType, string counterGroup, long targetEntityId)
	{
		string key = $"{targetType}{counterGroup}_{targetEntityId}";
		return GetCounter(key);
	}

	/// <inheritdoc />
	public ICounter GetCounter(string counterKey)
	{
		return new Counter(_DurableCountersClient, counterKey, _Logger);
	}
}
