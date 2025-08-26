namespace Roblox.Platform.TranslationResources.Feature {
    /// <summary>

/// This class overrides BuildersClubResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class BuildersClubResources_ko_kr : BuildersClubResources_en_us, IBuildersClubResources, ITranslationResources
{
	/// <summary>
	/// Key: "Action.BuidlersClubOnlyCancel"
	/// English String: "Cancel"
	/// </summary>
	public override string ActionBuidlersClubOnlyCancel => "ì·¨ì†Œ";

	/// <summary>
	/// Key: "Action.BuidlersClubOnlyUpgradeNow"
	/// English String: "Upgrade Now"
	/// </summary>
	public override string ActionBuidlersClubOnlyUpgradeNow => "ì—…ê·¸ë ˆì´ë“œ";

	/// <summary>
	/// Key: "Heading.BuildersClubOnly"
	/// English String: "Builders Club Only"
	/// </summary>
	public override string HeadingBuildersClubOnly => "Builders Club ì „ìš©";

	/// <summary>
	/// Key: "Label.BuidlersClubOnlyClose"
	/// English String: "Close"
	/// </summary>
	public override string LabelBuidlersClubOnlyClose => "ë‹«ê¸°";

	public BuildersClubResources_ko_kr(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionBuidlersClubOnlyCancel()
	{
		return "ì·¨ì†Œ";
	}

	protected override string _GetTemplateForActionBuidlersClubOnlyUpgradeNow()
	{
		return "ì—…ê·¸ë ˆì´ë“œ";
	}

	/// <summary>
	/// Key: "DescriptionBuildersClubOnlyModel"
	/// English String: "This is a premium item only available to our {bcRequirementName} members."
	/// </summary>
	public override string DescriptionBuildersClubOnlyModel(string bcRequirementName)
	{
		return $"{bcRequirementName} ë©¤ë²„ë§Œ ì´ìš© ê°€ëŠ¥í•œ í”„ë¦¬ë¯¸ì—„ ì•„ì´í…œìž…ë‹ˆë‹¤.";
	}

	protected override string _GetTemplateForDescriptionBuildersClubOnlyModel()
	{
		return "{bcRequirementName} ë©¤ë²„ë§Œ ì´ìš© ê°€ëŠ¥í•œ í”„ë¦¬ë¯¸ì—„ ì•„ì´í…œìž…ë‹ˆë‹¤.";
	}

	protected override string _GetTemplateForHeadingBuildersClubOnly()
	{
		return "Builders Club ì „ìš©";
	}

	protected override string _GetTemplateForLabelBuidlersClubOnlyClose()
	{
		return "ë‹«ê¸°";
	}
}


}
