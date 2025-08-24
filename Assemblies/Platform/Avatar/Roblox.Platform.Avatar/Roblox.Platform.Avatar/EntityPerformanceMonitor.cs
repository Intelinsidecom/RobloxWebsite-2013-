using System;
using System.Collections.Concurrent;
using Roblox.EventLog;
using Roblox.Instrumentation;

namespace Roblox.Platform.Avatar;

/// <summary>
/// Performance monitor for tracking requests / methodName.
/// </summary>
internal class EntityPerformanceMonitor
{
	private readonly ConcurrentDictionary<string, Lazy<IRateOfCountsPerSecondCounter>> _EntityCounters;

	private readonly ICounterRegistry _CounterRegistry;

	private readonly ILogger _Logger;

	private const string _CounterCategory = "Roblox.Platform.Avatar.RequestsByEntityOperations";

	internal EntityPerformanceMonitor(ICounterRegistry counterRegistry, ILogger logger)
	{
		_CounterRegistry = counterRegistry ?? throw new ArgumentNullException("counterRegistry");
		_Logger = logger ?? throw new ArgumentNullException("logger");
		_EntityCounters = new ConcurrentDictionary<string, Lazy<IRateOfCountsPerSecondCounter>>();
	}

	private IRateOfCountsPerSecondCounter GetRateCounter(string methodName)
	{
		return _EntityCounters.GetOrAdd(methodName, (string _) => new Lazy<IRateOfCountsPerSecondCounter>(() => _CounterRegistry.GetRateOfCountsPerSecondCounter("Roblox.Platform.Avatar.RequestsByEntityOperations", methodName))).Value;
	}

	internal void AccoutrementCRUDEvent(string methodName)
	{
		try
		{
			GetRateCounter(methodName)?.Increment();
		}
		catch (Exception e)
		{
			_Logger.Error(e);
		}
	}
}
