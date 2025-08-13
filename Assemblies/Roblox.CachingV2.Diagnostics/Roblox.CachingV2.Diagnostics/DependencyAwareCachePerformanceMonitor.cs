using System;
using Roblox.CachingV2.Core;
using Roblox.Instrumentation;

namespace Roblox.CachingV2.Diagnostics;

/// <summary>
/// Represents an object that monitors an <seealso cref="T:Roblox.CachingV2.Core.IDependencyAwareCache" />'s performance.
/// </summary>
/// <seealso cref="T:Roblox.CachingV2.Diagnostics.CachePerformanceMonitor`3" />
/// <seealso cref="T:Roblox.CachingV2.Core.IDependencyAwareCache" />
/// <seealso cref="T:Roblox.CachingV2.Core.DependencyAwareMetadata" />
/// <seealso cref="T:Roblox.CachingV2.Core.DependencyAwareSetArgs" />
public sealed class DependencyAwareCachePerformanceMonitor : CachePerformanceMonitor<IDependencyAwareCache, DependencyAwareMetadata, DependencyAwareSetArgs>
{
	private const string _PerformanceCategory = "Roblox.CachingV2.Diagnostics.DependencyAwareCache";

	private readonly IRateOfCountsPerSecondCounter _DependencyChecksFailedPerSecondPerformanceCounter;

	private readonly IRateOfCountsPerSecondCounter _DependencyChecksSucceededPerSecondPerformanceCounter;

	private readonly IFractionCounter _DependencyCheckSuccessRatePerformanceCounter;

	/// <summary>
	/// Initializes a new instance of the <see cref="T:Roblox.CachingV2.Diagnostics.DependencyAwareCachePerformanceMonitor" /> class.
	/// </summary>
	/// <param name="counterRegistry">The counter registry injected.</param>
	/// <param name="cache">The cache to monitor.</param>
	/// <exception cref="T:System.ArgumentNullException"><paramref name="cache" /></exception>
	public DependencyAwareCachePerformanceMonitor(ICounterRegistry counterRegistry, IDependencyAwareCache cache)
		: base(counterRegistry, cache)
	{
		if (counterRegistry == null)
		{
			throw new ArgumentNullException("counterRegistry");
		}
		_DependencyChecksFailedPerSecondPerformanceCounter = counterRegistry.GetRateOfCountsPerSecondCounter("Roblox.CachingV2.Diagnostics.DependencyAwareCache", "DependencyChecksFailedPerSecond", base.Cache.Name);
		_DependencyChecksSucceededPerSecondPerformanceCounter = counterRegistry.GetRateOfCountsPerSecondCounter("Roblox.CachingV2.Diagnostics.DependencyAwareCache", "DependencyChecksSucceededPerSecond", base.Cache.Name);
		_DependencyCheckSuccessRatePerformanceCounter = counterRegistry.GetFractionCounter("Roblox.CachingV2.Diagnostics.DependencyAwareCache", "DependencyCheckSuccessRate", base.Cache.Name);
	}

	/// <inheritdoc />
	protected override void DoRegistration()
	{
		base.Cache.DependencyCheckSucceeded += HandleDependencyCheckSucceeded;
		base.Cache.DependencyCheckFailed += HandleDependencyCheckFailed;
		base.DoRegistration();
	}

	/// <inheritdoc />
	protected override void DoUnregistration()
	{
		base.Cache.DependencyCheckSucceeded -= HandleDependencyCheckSucceeded;
		base.Cache.DependencyCheckFailed -= HandleDependencyCheckFailed;
		base.DoUnregistration();
	}

	private void HandleDependencyCheckFailed(object sender, DependencyCheckFailedEventArgs e)
	{
		_DependencyChecksFailedPerSecondPerformanceCounter.Increment();
		_DependencyCheckSuccessRatePerformanceCounter.IncrementBase();
	}

	private void HandleDependencyCheckSucceeded(object sender, DependencyCheckSucceededEventArgs e)
	{
		_DependencyChecksSucceededPerSecondPerformanceCounter.Increment();
		_DependencyCheckSuccessRatePerformanceCounter.Increment();
		_DependencyCheckSuccessRatePerformanceCounter.IncrementBase();
	}
}
