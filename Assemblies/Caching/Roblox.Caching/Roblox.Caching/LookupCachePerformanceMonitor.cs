using System;
using Roblox.Instrumentation;

namespace Roblox.Caching;

internal class LookupCachePerformanceMonitor
{
	private const string _Category = "Roblox.Caching.LookupCache";

	public IRateOfCountsPerSecondCounter GetCountPerSecond { get; }

	public IRateOfCountsPerSecondCounter GetCountErrorPerSecond { get; }

	public IRateOfCountsPerSecondCounter SetCountPerSecond { get; }

	public IRateOfCountsPerSecondCounter SetCountErrorPerSecond { get; }

	public IFractionCounter EntityCountHitRate { get; }

	public IRateOfCountsPerSecondCounter GetLookupPerSecond { get; }

	public IRateOfCountsPerSecondCounter GetLookupErrorPerSecond { get; }

	public IRateOfCountsPerSecondCounter SetLookupPerSecond { get; }

	public IRateOfCountsPerSecondCounter SetLookupErrorPerSecond { get; }

	public IFractionCounter EntityLookupHitRate { get; }

	public LookupCachePerformanceMonitor(ICounterRegistry counterRegistry, string instance)
	{
		if (counterRegistry == null)
		{
			throw new ArgumentNullException("counterRegistry");
		}
		if (string.IsNullOrWhiteSpace(instance))
		{
			throw new ArgumentNullException("instance");
		}
		GetCountPerSecond = counterRegistry.GetRateOfCountsPerSecondCounter("Roblox.Caching.LookupCache", "GetCountPerSecond", instance);
		GetCountErrorPerSecond = counterRegistry.GetRateOfCountsPerSecondCounter("Roblox.Caching.LookupCache", "GetCountErrorPerSecond", instance);
		SetCountPerSecond = counterRegistry.GetRateOfCountsPerSecondCounter("Roblox.Caching.LookupCache", "SetCountPerSecond", instance);
		SetCountErrorPerSecond = counterRegistry.GetRateOfCountsPerSecondCounter("Roblox.Caching.LookupCache", "SetCountErrorPerSecond", instance);
		EntityCountHitRate = counterRegistry.GetFractionCounter("Roblox.Caching.LookupCache", "EntityCountHitRate", instance);
		GetLookupPerSecond = counterRegistry.GetRateOfCountsPerSecondCounter("Roblox.Caching.LookupCache", "GetLookupPerSecond", instance);
		GetLookupErrorPerSecond = counterRegistry.GetRateOfCountsPerSecondCounter("Roblox.Caching.LookupCache", "GetLookupErrorPerSecond", instance);
		SetLookupPerSecond = counterRegistry.GetRateOfCountsPerSecondCounter("Roblox.Caching.LookupCache", "SetLookupPerSecond", instance);
		SetLookupErrorPerSecond = counterRegistry.GetRateOfCountsPerSecondCounter("Roblox.Caching.LookupCache", "SetLookupErrorPerSecond", instance);
		EntityLookupHitRate = counterRegistry.GetFractionCounter("Roblox.Caching.LookupCache", "EntityLookupHitRate", instance);
	}

	internal LookupCachePerformanceMonitor()
	{
	}
}
