using System;

namespace Roblox.Platform.Marketing.Properties;

public interface ISettings
{
	bool ABTestFrameworkEnabled { get; }

	string HidePrerollForFirstNDaysExperimentName { get; }

	TimeSpan PrerollHiddenTimespan { get; }

	double PrerollSimplePercentageChance { get; }

	double PrerollSimplePercentageChanceForDFP { get; }

	bool IsPrerollShownEveryXMinutesEnabled { get; }

	int DaysBeforeShowPrerollToNewUser { get; }

	bool TakeoverFrequencyCapEnabled { get; }

	bool IsHomeSpecialLowValueTakeoverVisibleForAllUsers { get; }

	bool IsSponsoredPageDevicesSelectorEnabled { get; }

	bool IsSponsoredPageAgeRatingEnabled { get; }
}
