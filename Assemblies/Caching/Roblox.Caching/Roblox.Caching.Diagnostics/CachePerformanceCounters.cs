using System;
using Roblox.Caching.Interfaces;
using Roblox.Instrumentation;

namespace Roblox.Caching.Diagnostics;

public class CachePerformanceCounters : IRobloxCacheListener
{
	private const string _PerformanceCategory = "Roblox.Caching";

	private readonly string _InstanceName;

	private readonly ICounterRegistry _CounterRegistry;

	private readonly IRawValueCounter _Queries;

	private readonly IRateOfCountsPerSecondCounter _QueriesPerSec;

	private readonly IRawValueCounter _Misses;

	private readonly IRateOfCountsPerSecondCounter _MissesPerSec;

	private readonly IRawValueCounter _Hits;

	private readonly IRateOfCountsPerSecondCounter _HitsPerSec;

	private readonly IFractionCounter _HitRatio;

	public CachePerformanceCounters(ICounterRegistry counterRegistry, string instanceName = "Total")
	{
		_CounterRegistry = counterRegistry ?? throw new ArgumentNullException("counterRegistry");
		_InstanceName = instanceName ?? throw new ArgumentNullException("instanceName");
		_Queries = _CounterRegistry.GetRawValueCounter("Roblox.Caching", "Queries", _InstanceName);
		_QueriesPerSec = _CounterRegistry.GetRateOfCountsPerSecondCounter("Roblox.Caching", "Queries/s", _InstanceName);
		_Misses = _CounterRegistry.GetRawValueCounter("Roblox.Caching", "Misses", _InstanceName);
		_MissesPerSec = _CounterRegistry.GetRateOfCountsPerSecondCounter("Roblox.Caching", "Misses/s", _InstanceName);
		_Hits = _CounterRegistry.GetRawValueCounter("Roblox.Caching", "Hits", _InstanceName);
		_HitsPerSec = _CounterRegistry.GetRateOfCountsPerSecondCounter("Roblox.Caching", "Hits/s", _InstanceName);
		_HitRatio = _CounterRegistry.GetFractionCounter("Roblox.Caching", "Hit Ratio", _InstanceName);
	}

	public void OnQuery()
	{
		_Queries.Increment();
		_QueriesPerSec.Increment();
		_HitRatio.IncrementBase();
	}

	public void OnQuery(string entityType)
	{
		OnQuery(entityType, 1);
	}

	public void OnHit(string entityType)
	{
		OnHit(entityType, 1);
	}

	public void OnMiss(string entityType)
	{
		OnMiss(entityType, 1);
	}

	public void OnQuery(string entityType, int count)
	{
		_Queries.IncrementBy(count);
		_QueriesPerSec.IncrementBy(count);
		_HitRatio.IncrementBase();
	}

	public void OnHit(string entityType, int count)
	{
		_Hits.IncrementBy(count);
		_HitsPerSec.IncrementBy(count);
		_HitRatio.Increment();
	}

	public void OnMiss(string entityType, int count)
	{
		_Misses.IncrementBy(count);
		_MissesPerSec.IncrementBy(count);
	}
}
