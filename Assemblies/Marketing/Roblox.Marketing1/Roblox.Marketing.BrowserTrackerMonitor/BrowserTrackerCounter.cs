using Roblox.Instrumentation;

namespace Roblox.Marketing.BrowserTrackerMonitor;

internal class BrowserTrackerCounter
{
	private const string _PerformanceCategory = "Roblox.Website.BrowserTrackerCounter";

	private IRateOfCountsPerSecondCounter RBXEventTrackerCounter { get; set; }

	internal BrowserTrackerCounter(ICounterRegistry counterRegistry, string instanceName)
	{
		RBXEventTrackerCounter = counterRegistry.GetRateOfCountsPerSecondCounter("Roblox.Website.BrowserTrackerCounter", "RBXEventTrackerCounter", instanceName);
	}

	internal void Increment()
	{
		RBXEventTrackerCounter.Increment();
	}
}
