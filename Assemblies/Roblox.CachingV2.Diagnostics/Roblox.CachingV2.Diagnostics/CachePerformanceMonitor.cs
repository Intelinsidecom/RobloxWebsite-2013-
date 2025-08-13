using System;
using Roblox.CachingV2.Core;
using Roblox.Instrumentation;

namespace Roblox.CachingV2.Diagnostics;

/// <summary>
/// Represents an object that monitors an <see cref="T:Roblox.CachingV2.Core.ICache`2" />'s performance.
/// </summary>
/// <seealso cref="T:Roblox.CachingV2.Core.ICache`2" />
/// <seealso cref="T:Roblox.CachingV2.Core.BasicMetadata" />
/// <seealso cref="T:Roblox.CachingV2.Core.BasicSetArgs" />
public class CachePerformanceMonitor<TCache, TMetadata, TSetArgs> where TCache : class, ICache<TMetadata, TSetArgs> where TMetadata : BasicMetadata where TSetArgs : BasicSetArgs
{
	private const string _PerformanceCategory = "Roblox.CachingV2.Diagnostics.Cache";

	private readonly object _RegistrationLock = new object();

	private IRateOfCountsPerSecondCounter _EntriesQueriedPerSecondPerformanceCounter;

	private IRateOfCountsPerSecondCounter _EntriesMissedPerSecondPerformanceCounter;

	private IRateOfCountsPerSecondCounter _EntriesRetrievedPerSecondPerformanceCounter;

	private IRateOfCountsPerSecondCounter _EntriesSetPerSecondPerformanceCounter;

	private IRateOfCountsPerSecondCounter _EntriesRemovedPerSecondPerformanceCounter;

	private IRateOfCountsPerSecondCounter _ErrorsPerSecondPerformanceCounter;

	private IFractionCounter _HitRatioPerformanceCounter;

	private bool _IsRegistered;

	/// <summary>
	/// Gets the cache being monitored.
	/// </summary>
	protected TCache Cache { get; }

	/// <summary>
	/// Initializes a new instance of the <see cref="T:Roblox.CachingV2.Diagnostics.CachePerformanceMonitor`3" /> class.
	/// </summary>
	/// <param name="counterRegistry">The counter registry injected.</param>
	/// <param name="cache">The cache to monitor.</param>
	/// <exception cref="T:System.ArgumentNullException"><paramref name="cache" /></exception>
	public CachePerformanceMonitor(ICounterRegistry counterRegistry, TCache cache)
	{
		if (counterRegistry == null)
		{
			throw new ArgumentNullException("counterRegistry");
		}
		Cache = cache ?? throw new ArgumentNullException("cache");
		_EntriesQueriedPerSecondPerformanceCounter = counterRegistry.GetRateOfCountsPerSecondCounter("Roblox.CachingV2.Diagnostics.Cache", "EntriesQueriedPerSecond", Cache.Name);
		_EntriesMissedPerSecondPerformanceCounter = counterRegistry.GetRateOfCountsPerSecondCounter("Roblox.CachingV2.Diagnostics.Cache", "EntriesMissedPerSecond", Cache.Name);
		_EntriesRetrievedPerSecondPerformanceCounter = counterRegistry.GetRateOfCountsPerSecondCounter("Roblox.CachingV2.Diagnostics.Cache", "EntriesRetrievedPerSecond", Cache.Name);
		_EntriesSetPerSecondPerformanceCounter = counterRegistry.GetRateOfCountsPerSecondCounter("Roblox.CachingV2.Diagnostics.Cache", "EntriesSetPerSecond", Cache.Name);
		_EntriesRemovedPerSecondPerformanceCounter = counterRegistry.GetRateOfCountsPerSecondCounter("Roblox.CachingV2.Diagnostics.Cache", "EntriesRemovedPerSecond", Cache.Name);
		_ErrorsPerSecondPerformanceCounter = counterRegistry.GetRateOfCountsPerSecondCounter("Roblox.CachingV2.Diagnostics.Cache", "ErrorsPerSecond", Cache.Name);
		_HitRatioPerformanceCounter = counterRegistry.GetFractionCounter("Roblox.CachingV2.Diagnostics.Cache", "HitRatio", Cache.Name);
	}

	/// <summary>
	/// Registers the monitor to begin listening to the <see cref="T:Roblox.CachingV2.Core.ICache`2" />'s events.
	/// </summary>
	public void Register()
	{
		if (_IsRegistered)
		{
			return;
		}
		lock (_RegistrationLock)
		{
			if (!_IsRegistered)
			{
				DoRegistration();
				_IsRegistered = true;
			}
		}
	}

	/// <summary>
	/// Unregisters the monitor from listening to the <see cref="T:Roblox.CachingV2.Core.ICache`2" />'s events.
	/// </summary>
	public void Unregister()
	{
		if (!_IsRegistered)
		{
			return;
		}
		lock (_RegistrationLock)
		{
			if (_IsRegistered)
			{
				DoUnregistration();
				_IsRegistered = false;
			}
		}
	}

	/// <summary>
	/// Performs any event registration.
	/// </summary>
	protected virtual void DoRegistration()
	{
		Cache.EntryMissed += HandleEntryMissed;
		Cache.EntryQueried += HandleEntryQueried;
		Cache.EntryRetrieved += HandleEntryRetrieved;
		Cache.EntryRemoved += HandleEntryRemoved;
		Cache.EntrySet += HandleEntrySet;
		Cache.Error += HandleError;
	}

	/// <summary>
	/// Performs any event unregistration.
	/// </summary>
	protected virtual void DoUnregistration()
	{
		Cache.EntryMissed -= HandleEntryMissed;
		Cache.EntryQueried -= HandleEntryQueried;
		Cache.EntryRetrieved -= HandleEntryRetrieved;
		Cache.EntryRemoved -= HandleEntryRemoved;
		Cache.EntrySet -= HandleEntrySet;
		Cache.Error -= HandleError;
	}

	private void HandleEntryMissed(object sender, EntryMissedEventArgs args)
	{
		_EntriesMissedPerSecondPerformanceCounter.Increment();
	}

	private void HandleEntryQueried(object sender, EntryQueriedEventArgs args)
	{
		_EntriesQueriedPerSecondPerformanceCounter.Increment();
		_HitRatioPerformanceCounter.IncrementBase();
	}

	private void HandleEntryRetrieved(object sender, EntryRetrievalEventArgs args)
	{
		_EntriesRetrievedPerSecondPerformanceCounter.Increment();
		_HitRatioPerformanceCounter.Increment();
	}

	private void HandleEntryRemoved(object sender, EntryRemovedEventArgs args)
	{
		_EntriesRemovedPerSecondPerformanceCounter.Increment();
	}

	private void HandleEntrySet(object sender, EntrySetEventArgs args)
	{
		_EntriesSetPerSecondPerformanceCounter.Increment();
	}

	private void HandleError(object sender, ErrorEventArgs args)
	{
		_ErrorsPerSecondPerformanceCounter.Increment();
	}
}
