namespace Roblox.Platform.TranslationResources.Feature {
    /// <summary>

/// This class overrides BuildersClubResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class BuildersClubResources_ja_jp : BuildersClubResources_en_us, IBuildersClubResources, ITranslationResources
{
	/// <summary>
	/// Key: "Action.BuidlersClubOnlyCancel"
	/// English String: "Cancel"
	/// </summary>
	public override string ActionBuidlersClubOnlyCancel => "ã‚­ãƒ£ãƒ³ã‚»ãƒ«";

	/// <summary>
	/// Key: "Action.BuidlersClubOnlyUpgradeNow"
	/// English String: "Upgrade Now"
	/// </summary>
	public override string ActionBuidlersClubOnlyUpgradeNow => "ã‚¢ãƒƒãƒ—ã‚°ãƒ¬ãƒ¼ãƒ‰ã™ã‚‹";

	/// <summary>
	/// Key: "Heading.BuildersClubOnly"
	/// English String: "Builders Club Only"
	/// </summary>
	public override string HeadingBuildersClubOnly => "Builders Clubå°‚ç”¨";

	/// <summary>
	/// Key: "Label.BuidlersClubOnlyClose"
	/// English String: "Close"
	/// </summary>
	public override string LabelBuidlersClubOnlyClose => "é–‰ã˜ã‚‹";

	public BuildersClubResources_ja_jp(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionBuidlersClubOnlyCancel()
	{
		return "ã‚­ãƒ£ãƒ³ã‚»ãƒ«";
	}

	protected override string _GetTemplateForActionBuidlersClubOnlyUpgradeNow()
	{
		return "ã‚¢ãƒƒãƒ—ã‚°ãƒ¬ãƒ¼ãƒ‰ã™ã‚‹";
	}

	/// <summary>
	/// Key: "DescriptionBuildersClubOnlyModel"
	/// English String: "This is a premium item only available to our {bcRequirementName} members."
	/// </summary>
	public override string DescriptionBuildersClubOnlyModel(string bcRequirementName)
	{
		return $"ã“ã‚Œã¯ã€{bcRequirementName}ã®ãƒ¡ãƒ³ãƒãƒ¼å°‚ç”¨ã®ãƒ—ãƒ¬ãƒŸã‚¢ãƒ ã‚¢ã‚¤ãƒ†ãƒ ã§ã™ã€‚";
	}

	protected override string _GetTemplateForDescriptionBuildersClubOnlyModel()
	{
		return "ã“ã‚Œã¯ã€{bcRequirementName}ã®ãƒ¡ãƒ³ãƒãƒ¼å°‚ç”¨ã®ãƒ—ãƒ¬ãƒŸã‚¢ãƒ ã‚¢ã‚¤ãƒ†ãƒ ã§ã™ã€‚";
	}

	protected override string _GetTemplateForHeadingBuildersClubOnly()
	{
		return "Builders Clubå°‚ç”¨";
	}

	protected override string _GetTemplateForLabelBuidlersClubOnlyClose()
	{
		return "é–‰ã˜ã‚‹";
	}
}


}
