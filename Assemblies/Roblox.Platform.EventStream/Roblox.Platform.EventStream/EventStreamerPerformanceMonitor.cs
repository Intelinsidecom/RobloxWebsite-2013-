using System;
using Roblox.Instrumentation;

namespace Roblox.Platform.EventStream;

internal class EventStreamerPerformanceMonitor
{
	private const string _PerformanceCategory = "Roblox.EventStreamerV1";

	public IRateOfCountsPerSecondCounter MessagesAttemptedToSentPerSecond { get; set; }

	public EventStreamerPerformanceMonitor(ICounterRegistry counterRegistry)
	{
		if (counterRegistry == null)
		{
			throw new ArgumentNullException("counterRegistry");
		}
		MessagesAttemptedToSentPerSecond = counterRegistry.GetRateOfCountsPerSecondCounter("Roblox.EventStreamerV1", "MessagesAttemptedToSentPerSecond");
	}
}
