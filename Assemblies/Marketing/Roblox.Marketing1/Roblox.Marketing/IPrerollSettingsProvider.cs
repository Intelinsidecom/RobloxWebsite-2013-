using System;
namespace Roblox.Marketingpublic {
    interface IPrerollSettingsProvider

{
	string HidePrerollForFirstNDaysExperimentName { get; }

	TimeSpan PrerollHiddenTimespan { get; }

	double PrerollSimplePercentageChance { get; }

	double PrerollSimplePercentageChanceForDFP { get; }

	bool IsPrerollShownEveryXMinutesEnabled { get; }
}


}
