namespace Roblox.Platform.TranslationResources.Feature {
    /// <summary>

/// This class overrides BuildersClubResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class BuildersClubResources_zh_tw : BuildersClubResources_en_us, IBuildersClubResources, ITranslationResources
{
	/// <summary>
	/// Key: "Action.BuidlersClubOnlyCancel"
	/// English String: "Cancel"
	/// </summary>
	public override string ActionBuidlersClubOnlyCancel => "å–æ¶ˆ";

	/// <summary>
	/// Key: "Action.BuidlersClubOnlyUpgradeNow"
	/// English String: "Upgrade Now"
	/// </summary>
	public override string ActionBuidlersClubOnlyUpgradeNow => "ç¾åœ¨å‡ç´š";

	/// <summary>
	/// Key: "Heading.BuildersClubOnly"
	/// English String: "Builders Club Only"
	/// </summary>
	public override string HeadingBuildersClubOnly => "Builders Club é™å®š";

	/// <summary>
	/// Key: "Label.BuidlersClubOnlyClose"
	/// English String: "Close"
	/// </summary>
	public override string LabelBuidlersClubOnlyClose => "é—œé–‰";

	public BuildersClubResources_zh_tw(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionBuidlersClubOnlyCancel()
	{
		return "å–æ¶ˆ";
	}

	protected override string _GetTemplateForActionBuidlersClubOnlyUpgradeNow()
	{
		return "ç¾åœ¨å‡ç´š";
	}

	/// <summary>
	/// Key: "DescriptionBuildersClubOnlyModel"
	/// English String: "This is a premium item only available to our {bcRequirementName} members."
	/// </summary>
	public override string DescriptionBuildersClubOnlyModel(string bcRequirementName)
	{
		return $"æ­¤é«˜ç´šé“å…·åªé–‹æ”¾ {bcRequirementName} æœƒå“¡è³¼è²·ã€‚";
	}

	protected override string _GetTemplateForDescriptionBuildersClubOnlyModel()
	{
		return "æ­¤é«˜ç´šé“å…·åªé–‹æ”¾ {bcRequirementName} æœƒå“¡è³¼è²·ã€‚";
	}

	protected override string _GetTemplateForHeadingBuildersClubOnly()
	{
		return "Builders Club é™å®š";
	}

	protected override string _GetTemplateForLabelBuidlersClubOnlyClose()
	{
		return "é—œé–‰";
	}
}


}
