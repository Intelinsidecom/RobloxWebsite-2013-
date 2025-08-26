namespace Roblox.Platform.TranslationResources.Feature {
    /// <summary>

/// This class overrides BuildersClubResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class BuildersClubResources_zh_cn : BuildersClubResources_en_us, IBuildersClubResources, ITranslationResources
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
	public override string ActionBuidlersClubOnlyUpgradeNow => "ç«‹å³å‡çº§";

	/// <summary>
	/// Key: "Heading.BuildersClubOnly"
	/// English String: "Builders Club Only"
	/// </summary>
	public override string HeadingBuildersClubOnly => "ä»…é™ Builders Club";

	/// <summary>
	/// Key: "Label.BuidlersClubOnlyClose"
	/// English String: "Close"
	/// </summary>
	public override string LabelBuidlersClubOnlyClose => "å…³é—­";

	public BuildersClubResources_zh_cn(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionBuidlersClubOnlyCancel()
	{
		return "å–æ¶ˆ";
	}

	protected override string _GetTemplateForActionBuidlersClubOnlyUpgradeNow()
	{
		return "ç«‹å³å‡çº§";
	}

	/// <summary>
	/// Key: "DescriptionBuildersClubOnlyModel"
	/// English String: "This is a premium item only available to our {bcRequirementName} members."
	/// </summary>
	public override string DescriptionBuildersClubOnlyModel(string bcRequirementName)
	{
		return $"æ­¤é«˜çº§ç‰©å“ä»…é™ {bcRequirementName} ä¼šå‘˜è´­ä¹°ã€‚";
	}

	protected override string _GetTemplateForDescriptionBuildersClubOnlyModel()
	{
		return "æ­¤é«˜çº§ç‰©å“ä»…é™ {bcRequirementName} ä¼šå‘˜è´­ä¹°ã€‚";
	}

	protected override string _GetTemplateForHeadingBuildersClubOnly()
	{
		return "ä»…é™ Builders Club";
	}

	protected override string _GetTemplateForLabelBuidlersClubOnlyClose()
	{
		return "å…³é—­";
	}
}


}
