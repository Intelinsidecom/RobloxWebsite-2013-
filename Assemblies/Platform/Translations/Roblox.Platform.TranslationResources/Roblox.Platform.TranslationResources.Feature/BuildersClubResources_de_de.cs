namespace Roblox.TranslationResources.Feature;

/// <summary>
/// This class overrides BuildersClubResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class BuildersClubResources_de_de : BuildersClubResources_en_us, IBuildersClubResources, ITranslationResources
{
	/// <summary>
	/// Key: "Action.BuidlersClubOnlyCancel"
	/// English String: "Cancel"
	/// </summary>
	public override string ActionBuidlersClubOnlyCancel => "Abbrechen";

	/// <summary>
	/// Key: "Action.BuidlersClubOnlyUpgradeNow"
	/// English String: "Upgrade Now"
	/// </summary>
	public override string ActionBuidlersClubOnlyUpgradeNow => "Jetzt aufwerten";

	/// <summary>
	/// Key: "Heading.BuildersClubOnly"
	/// English String: "Builders Club Only"
	/// </summary>
	public override string HeadingBuildersClubOnly => "Nur für „Builders Club“-Mitglieder";

	/// <summary>
	/// Key: "Label.BuidlersClubOnlyClose"
	/// English String: "Close"
	/// </summary>
	public override string LabelBuidlersClubOnlyClose => "Schließen";

	public BuildersClubResources_de_de(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionBuidlersClubOnlyCancel()
	{
		return "Abbrechen";
	}

	protected override string _GetTemplateForActionBuidlersClubOnlyUpgradeNow()
	{
		return "Jetzt aufwerten";
	}

	/// <summary>
	/// Key: "DescriptionBuildersClubOnlyModel"
	/// English String: "This is a premium item only available to our {bcRequirementName} members."
	/// </summary>
	public override string DescriptionBuildersClubOnlyModel(string bcRequirementName)
	{
		return $"Dies ist ein Premium-Artikel, der nur für unsere {bcRequirementName}-Mitglieder verfügbar ist.";
	}

	protected override string _GetTemplateForDescriptionBuildersClubOnlyModel()
	{
		return "Dies ist ein Premium-Artikel, der nur für unsere {bcRequirementName}-Mitglieder verfügbar ist.";
	}

	protected override string _GetTemplateForHeadingBuildersClubOnly()
	{
		return "Nur für „Builders Club“-Mitglieder";
	}

	protected override string _GetTemplateForLabelBuidlersClubOnlyClose()
	{
		return "Schließen";
	}
}
