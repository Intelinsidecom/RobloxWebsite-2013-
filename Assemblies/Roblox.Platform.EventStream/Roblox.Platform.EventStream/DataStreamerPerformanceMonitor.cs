using System;
using Roblox.Instrumentation;

namespace Roblox.Platform.EventStream;

internal class DataStreamerPerformanceMonitor
{
	private const string _PerformanceCategory = "Roblox.DataStreamerV1";

	public IRateOfCountsPerSecondCounter AssetHandlerDataAttemptedToSentPerSecond { get; set; }

	public DataStreamerPerformanceMonitor(ICounterRegistry counterRegistry)
	{
		if (counterRegistry == null)
		{
			throw new ArgumentNullException("counterRegistry");
		}
		AssetHandlerDataAttemptedToSentPerSecond = counterRegistry.GetRateOfCountsPerSecondCounter("Roblox.DataStreamerV1", "AssetHandlerDataAttemptedToSentPerSecond");
	}
}
