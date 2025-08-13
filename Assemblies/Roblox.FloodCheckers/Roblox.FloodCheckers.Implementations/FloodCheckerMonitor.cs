using System;
using Roblox.Instrumentation;

namespace Roblox.FloodCheckers.Implementations;

internal class FloodCheckerMonitor
{
	private const string _Category = "Roblox.FloodCheckers";

	internal IRateOfCountsPerSecondCounter MemcachedOperationsPerSecond { get; }

	internal IRateOfCountsPerSecondCounter GetCountOperationsPerSecond { get; }

	internal IRateOfCountsPerSecondCounter GetCountOverLimitOperationsPerSecond { get; }

	internal IRateOfCountsPerSecondCounter CheckOperationsPerSecond { get; }

	internal IRateOfCountsPerSecondCounter IsFloodedOperationsPerSecond { get; }

	internal IRateOfCountsPerSecondCounter UpdateCountOperationsPerSecond { get; }

	internal IRateOfCountsPerSecondCounter ResetOperationsPerSecond { get; }

	internal FloodCheckerMonitor(ICounterRegistry counterRegistry, string instanceName)
	{
		if (counterRegistry == null)
		{
			throw new ArgumentNullException("counterRegistry");
		}
		if (string.IsNullOrWhiteSpace(instanceName))
		{
			throw new ArgumentException("instanceName");
		}
		MemcachedOperationsPerSecond = counterRegistry.GetRateOfCountsPerSecondCounter("Roblox.FloodCheckers", "MemcachedOperationsPerSecond", instanceName);
		GetCountOperationsPerSecond = counterRegistry.GetRateOfCountsPerSecondCounter("Roblox.FloodCheckers", "GetCountOperationsPerSecond", instanceName);
		GetCountOverLimitOperationsPerSecond = counterRegistry.GetRateOfCountsPerSecondCounter("Roblox.FloodCheckers", "GetCountOverLimitOperationsPerSecond", instanceName);
		CheckOperationsPerSecond = counterRegistry.GetRateOfCountsPerSecondCounter("Roblox.FloodCheckers", "CheckOperationsPerSecond", instanceName);
		IsFloodedOperationsPerSecond = counterRegistry.GetRateOfCountsPerSecondCounter("Roblox.FloodCheckers", "IsFloodedOperationsPerSecond", instanceName);
		UpdateCountOperationsPerSecond = counterRegistry.GetRateOfCountsPerSecondCounter("Roblox.FloodCheckers", "UpdateCountOperationsPerSecond", instanceName);
		ResetOperationsPerSecond = counterRegistry.GetRateOfCountsPerSecondCounter("Roblox.FloodCheckers", "ResetOperationsPerSecond", instanceName);
	}
}
