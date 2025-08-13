using System;
using Roblox.Instrumentation;

namespace Roblox.FloodCheckers;

internal class FloodCheckerPerformanceCounter
{
	private IRateOfCountsPerSecondCounter _FloodcheckerPerformanceCounter { get; set; }

	internal FloodCheckerPerformanceCounter(ICounterRegistry counterRegistry, string performanceCategory, string type)
	{
		if (counterRegistry == null)
		{
			throw new ArgumentNullException("counterRegistry");
		}
		_FloodcheckerPerformanceCounter = counterRegistry.GetRateOfCountsPerSecondCounter(performanceCategory, "Flooded/s", type);
	}

	internal void Increment()
	{
		_FloodcheckerPerformanceCounter.Increment();
	}
}
