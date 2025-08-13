using System;
using Roblox.Instrumentation;

namespace Roblox.Web.ElevatedActions.Base;

public class RobloxElevatedActionPerformanceCounterFactory : IRobloxElevatedActionPerformanceCounterFactory
{
	private readonly ICounterRegistry _CounterRegistry;

	public RobloxElevatedActionPerformanceCounterFactory(ICounterRegistry counterRegistry)
	{
		_CounterRegistry = counterRegistry ?? throw new ArgumentNullException("counterRegistry");
	}

	public IRobloxElevatedActionPerformanceCounters GetRobloxElevatedActionPerformanceCounters(Type typeOfIRobloxElevatedAction)
	{
		return new RobloxElevatedActionPerformanceCounters(_CounterRegistry, typeOfIRobloxElevatedAction);
	}

	public IRobloxElevatedActionAuthorizationCheckerPerformanceCounters GetRobloxElevatedActionAuthorizationCheckerPerformanceCounters()
	{
		return new RobloxElevatedActionAuthorizationCheckerPerformanceCounters(_CounterRegistry);
	}
}
