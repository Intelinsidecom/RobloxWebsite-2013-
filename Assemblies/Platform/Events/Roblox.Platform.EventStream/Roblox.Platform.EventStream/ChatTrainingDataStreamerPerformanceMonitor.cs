using System;
using Roblox.Instrumentation;

namespace Roblox.Platform.EventStream;

internal class ChatTrainingDataStreamerPerformanceMonitor
{
	private const string _PerformanceCategory = "Roblox.ChatDataStreamerV1";

	public IRateOfCountsPerSecondCounter GdprRegionChatDataAttemptedToSentPerSecond { get; set; }

	public IRateOfCountsPerSecondCounter UnitedStatesRegionChatDataAttemptedToSentPerSecond { get; set; }

	public ChatTrainingDataStreamerPerformanceMonitor(ICounterRegistry counterRegistry)
	{
		if (counterRegistry == null)
		{
			throw new ArgumentNullException("counterRegistry");
		}
		GdprRegionChatDataAttemptedToSentPerSecond = counterRegistry.GetRateOfCountsPerSecondCounter("Roblox.ChatDataStreamerV1", "GdprRegionChatDataAttemptedToSentPerSecond");
		UnitedStatesRegionChatDataAttemptedToSentPerSecond = counterRegistry.GetRateOfCountsPerSecondCounter("Roblox.ChatDataStreamerV1", "UnitedStatesRegionChatDataAttemptedToSentPerSecond");
	}
}
