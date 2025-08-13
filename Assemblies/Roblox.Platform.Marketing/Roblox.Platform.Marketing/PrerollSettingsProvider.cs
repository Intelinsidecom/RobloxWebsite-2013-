using System;
using Roblox.Platform.Marketing.Properties;

namespace Roblox.Platform.Marketing;

public class PrerollSettingsProvider : IPrerollSettingsProvider
{
	public string HidePrerollForFirstNDaysExperimentName => Settings.Default.HidePrerollForFirstNDaysExperimentName;

	public TimeSpan PrerollHiddenTimespan => Settings.Default.PrerollHiddenTimespan;

	public double PrerollSimplePercentageChance => Settings.Default.PrerollSimplePercentageChance;

	public double PrerollSimplePercentageChanceForDFP => Settings.Default.PrerollSimplePercentageChanceForDFP;

	public bool IsPrerollShownEveryXMinutesEnabled => Settings.Default.IsPrerollShownEveryXMinutesEnabled;
}
