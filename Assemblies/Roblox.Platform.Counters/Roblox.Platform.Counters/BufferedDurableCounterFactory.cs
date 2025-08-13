using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Timers;
using Roblox.DurableCounters.Client;
using Roblox.EventLog;
using Roblox.Platform.Counters.Properties;

namespace Roblox.Platform.Counters;

/// <summary>
/// A IDurableCounterFactory for high-traffic scenarios - batches updates to the service.
/// </summary>
public class BufferedDurableCounterFactory : IDurableCounterFactory, IDisposable
{
	private readonly ConcurrentDictionary<string, WeakReference<ITimeBucketedCounter>> _TimeBucketedCounters;

	private readonly ConcurrentDictionary<string, WeakReference<ICounter>> _Counters;

	private readonly IDurableCountersClient _DurableCountersClient;

	private readonly TimeSpan _CommitInterval;

	private readonly ILogger _Logger;

	private readonly PerformanceCollector _PerformanceCollector;

	private readonly Timer _CleanupTimer;

	private TimeSpan DefaultBufferedCounterCommitInterval => Settings.Default.DefaultBufferedCounterCommitInterval;

	/// <summary>
	/// Creates a new <see cref="T:Roblox.Platform.Counters.BufferedDurableCounterFactory" />
	/// </summary>
	/// <param name="client">An <see cref="T:Roblox.DurableCounters.Client.IDurableCountersClient" /></param>
	/// <param name="counterNamespace">Prefix for perfmon counters.</param>
	/// <param name="commitInterval">Defaults to </param>
	/// <param name="logger">An <see cref="T:Roblox.EventLog.ILogger" /></param>
	/// <param name="cleanupInterval">The time between two cleaning iterations over the internal <see cref="T:System.Collections.IDictionary" /></param>.
	public BufferedDurableCounterFactory(IDurableCountersClient client, string counterNamespace, TimeSpan? commitInterval, ILogger logger, TimeSpan? cleanupInterval = null)
	{
		_CommitInterval = commitInterval ?? DefaultBufferedCounterCommitInterval;
		_DurableCountersClient = client ?? throw new ArgumentNullException("client");
		_Logger = logger;
		_TimeBucketedCounters = new ConcurrentDictionary<string, WeakReference<ITimeBucketedCounter>>();
		_Counters = new ConcurrentDictionary<string, WeakReference<ICounter>>();
		_PerformanceCollector = new PerformanceCollector($"{counterNamespace}.BufferedDurableCounterFactory");
		_CleanupTimer = new Timer((cleanupInterval ?? Settings.Default.DefaultBufferedCounterCleanupInterval).TotalMilliseconds);
		_CleanupTimer.Elapsed += delegate
		{
			CleanCollectedWeakReferences(_TimeBucketedCounters);
			CleanCollectedWeakReferences(_Counters);
		};
		_CleanupTimer.Start();
	}

	/// <summary>
	/// Creates a new <see cref="T:Roblox.Platform.Counters.BufferedDurableCounterFactory" />
	/// </summary>
	/// <param name="client">An <see cref="T:Roblox.DurableCounters.Client.IDurableCountersClient" /></param>
	/// <param name="commitInterval">Defaults to </param>
	/// <param name="logger">An <see cref="T:Roblox.EventLog.ILogger" /></param>
	public BufferedDurableCounterFactory(IDurableCountersClient client, TimeSpan? commitInterval, ILogger logger)
		: this(client, "Roblox", commitInterval, logger)
	{
	}

	public void Dispose()
	{
		_CleanupTimer?.Dispose();
	}

	/// <inheritdoc />
	public ITimeBucketedCounter GetTimeBucketedCounter(string targetType, string counterType, long targetEntityId)
	{
		return GetTimeBucketedCounter(CounterType.Hourly, targetType, counterType, targetEntityId);
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
		string cacheKey = $"{counterType}_{counterKey}";
		if (!_TimeBucketedCounters.GetOrAdd(cacheKey, NewCounterMember).TryGetTarget(out var timeBucketedCounter))
		{
			_TimeBucketedCounters.AddOrUpdate(cacheKey, NewCounterMember, UpdateCounterMember).TryGetTarget(out timeBucketedCounter);
		}
		UpdatePerformanceCounter();
		return timeBucketedCounter;
		WeakReference<ITimeBucketedCounter> NewCounterMember(string key)
		{
			TimeBucketedCounter counter = new TimeBucketedCounter(_DurableCountersClient, counterType, counterKey, _Logger);
			timeBucketedCounter = new BufferedTimeBucketedCounter(counter, _CommitInterval, _Logger);
			return new WeakReference<ITimeBucketedCounter>(timeBucketedCounter);
		}
		WeakReference<ITimeBucketedCounter> UpdateCounterMember(string key, WeakReference<ITimeBucketedCounter> oldCounter)
		{
			return NewCounterMember(key);
		}
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
		if (!_Counters.GetOrAdd(counterKey, NewCounterMember).TryGetTarget(out var resultCounter))
		{
			_Counters.AddOrUpdate(counterKey, NewCounterMember, UpdateCounterMember).TryGetTarget(out resultCounter);
		}
		UpdatePerformanceCounter();
		return resultCounter;
		ICounter counter;
		WeakReference<ICounter> NewCounterMember(string key)
		{
			Counter backingCounter = new Counter(_DurableCountersClient, counterKey, _Logger);
			counter = new BufferedCounter(backingCounter, _CommitInterval, _Logger);
			return new WeakReference<ICounter>(counter);
		}
		WeakReference<ICounter> UpdateCounterMember(string key, WeakReference<ICounter> oldCounter)
		{
			return NewCounterMember(key);
		}
	}

	private void UpdatePerformanceCounter()
	{
		_PerformanceCollector.NumberOfCounterReferences.RawValue = _Counters.Count;
		_PerformanceCollector.NumberOfTimeBucketedCounterReferences.RawValue = _TimeBucketedCounters.Count;
	}

	private void CleanCollectedWeakReferences<T>(ConcurrentDictionary<string, WeakReference<T>> dictionary) where T : class
	{
		foreach (KeyValuePair<string, WeakReference<T>> keyValuePair in dictionary)
		{
			if (!keyValuePair.Value.TryGetTarget(out var _))
			{
				dictionary.TryRemove(keyValuePair.Key, out var _);
			}
		}
	}
}
