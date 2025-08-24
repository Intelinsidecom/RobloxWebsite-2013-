using System;

namespace Roblox.Platform.Marketing;

public interface IPrerollSettingsProvider
{
	string HidePrerollForFirstNDaysExperimentName { get; }

	TimeSpan PrerollHiddenTimespan { get; }

	double PrerollSimplePercentageChance { get; }

	double PrerollSimplePercentageChanceForDFP { get; }

	bool IsPrerollShownEveryXMinutesEnabled { get; }
}
