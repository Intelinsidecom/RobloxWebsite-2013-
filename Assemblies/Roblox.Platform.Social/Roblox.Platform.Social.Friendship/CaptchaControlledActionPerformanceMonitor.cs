using System;
using Roblox.Instrumentation;

namespace Roblox.Platform.Social.Friendship;

internal class CaptchaControlledActionPerformanceMonitor
{
	private const string _PerformanceCategory = "Roblox.Platform.Social.CaptchaControlledAction";

	public IRateOfCountsPerSecondCounter OtherSentPerSecond { get; set; }

	public IRateOfCountsPerSecondCounter SentFromInAppPerSecond { get; set; }

	public IRateOfCountsPerSecondCounter SentFromInGamePerSecond { get; set; }

	public IRateOfCountsPerSecondCounter SentFromInGameInAppPerSecond { get; set; }

	public CaptchaControlledActionPerformanceMonitor(ICounterRegistry counterRegistry, string actionName)
	{
		if (counterRegistry == null)
		{
			throw new ArgumentNullException("counterRegistry");
		}
		OtherSentPerSecond = counterRegistry.GetRateOfCountsPerSecondCounter("Roblox.Platform.Social.CaptchaControlledAction", "OtherSentPerSecond", actionName);
		SentFromInAppPerSecond = counterRegistry.GetRateOfCountsPerSecondCounter("Roblox.Platform.Social.CaptchaControlledAction", "SentFromInAppPerSecond", actionName);
		SentFromInGamePerSecond = counterRegistry.GetRateOfCountsPerSecondCounter("Roblox.Platform.Social.CaptchaControlledAction", "SentFromInGamePerSecond", actionName);
		SentFromInGameInAppPerSecond = counterRegistry.GetRateOfCountsPerSecondCounter("Roblox.Platform.Social.CaptchaControlledAction", "SentFromInGameInAppPerSecond", actionName);
	}
}
