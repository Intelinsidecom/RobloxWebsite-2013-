using System;
using System.Collections.Concurrent;
using Roblox.EventLog;
using Roblox.Instrumentation;

namespace Roblox.FloodCheckers;

public class FloodCheckerStatisticsTracker
{
	private readonly ConcurrentDictionary<string, FloodCheckerPerformanceCounter> _FloodCheckerPerformanceCounterLookup = new ConcurrentDictionary<string, FloodCheckerPerformanceCounter>();

	private readonly string _PerformanceCounterCategoryPrefix;

	private readonly ILogger _Logger;

	private readonly ICounterRegistry _CounterRegistry;

	public FloodCheckerStatisticsTracker(ICounterRegistry counterRegistry, string performanceCounterCategoryPrefix, ILogger logger)
	{
		if (string.IsNullOrWhiteSpace(performanceCounterCategoryPrefix))
		{
			throw new ArgumentException("Performance counter prefix must not be null or whitespace.", "performanceCounterCategoryPrefix");
		}
		_CounterRegistry = counterRegistry ?? throw new ArgumentNullException("counterRegistry");
		_PerformanceCounterCategoryPrefix = performanceCounterCategoryPrefix;
		_Logger = logger;
	}

	public void OnFlooded(string floodcheckerType)
	{
		try
		{
			Increment(floodcheckerType);
		}
		catch (Exception)
		{
		}
	}

	private void Increment(string floodcheckerType)
	{
		if (_FloodCheckerPerformanceCounterLookup.TryGetValue(floodcheckerType, out var counter))
		{
			counter.Increment();
			return;
		}
		lock (_FloodCheckerPerformanceCounterLookup)
		{
			string counterCategory = GetPerformanceCounterCategory(_PerformanceCounterCategoryPrefix);
			counter = new FloodCheckerPerformanceCounter(_CounterRegistry, counterCategory, floodcheckerType);
			_FloodCheckerPerformanceCounterLookup[floodcheckerType] = counter;
			counter.Increment();
		}
	}

	private string GetPerformanceCounterCategory(string prefix)
	{
		return prefix + ".FloodCheckers";
	}
}
