using System;
using Roblox.Instrumentation;

namespace Roblox.Platform.GameInstances;

internal class JoinTypePerformanceMonitor
{
	private const string _Category = "Roblox.Platform.GameInstances.JoinType";

	private const string _CounterName = "ReservationsWithJoinTypePerSecond";

	private readonly ICounterRegistry _CounterRegistry;

	public JoinTypePerformanceMonitor(ICounterRegistry counterRegistry)
	{
		_CounterRegistry = counterRegistry ?? throw new ArgumentNullException("counterRegistry");
	}

	internal void OnPlaySessionStart(string joinType)
	{
		_CounterRegistry.GetRateOfCountsPerSecondCounter("Roblox.Platform.GameInstances.JoinType", "ReservationsWithJoinTypePerSecond", joinType).Increment();
	}
}
