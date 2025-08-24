namespace Roblox.TranslationResources.Feature;

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
	public override string ActionBuidlersClubOnlyCancel => "취소";

	/// <summary>
	/// Key: "Action.BuidlersClubOnlyUpgradeNow"
	/// English String: "Upgrade Now"
	/// </summary>
	public override string ActionBuidlersClubOnlyUpgradeNow => "업그레이드";

	/// <summary>
	/// Key: "Heading.BuildersClubOnly"
	/// English String: "Builders Club Only"
	/// </summary>
	public override string HeadingBuildersClubOnly => "Builders Club 전용";

	/// <summary>
	/// Key: "Label.BuidlersClubOnlyClose"
	/// English String: "Close"
	/// </summary>
	public override string LabelBuidlersClubOnlyClose => "닫기";

	public BuildersClubResources_ko_kr(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionBuidlersClubOnlyCancel()
	{
		return "취소";
	}

	protected override string _GetTemplateForActionBuidlersClubOnlyUpgradeNow()
	{
		return "업그레이드";
	}

	/// <summary>
	/// Key: "DescriptionBuildersClubOnlyModel"
	/// English String: "This is a premium item only available to our {bcRequirementName} members."
	/// </summary>
	public override string DescriptionBuildersClubOnlyModel(string bcRequirementName)
	{
		return $"{bcRequirementName} 멤버만 이용 가능한 프리미엄 아이템입니다.";
	}

	protected override string _GetTemplateForDescriptionBuildersClubOnlyModel()
	{
		return "{bcRequirementName} 멤버만 이용 가능한 프리미엄 아이템입니다.";
	}

	protected override string _GetTemplateForHeadingBuildersClubOnly()
	{
		return "Builders Club 전용";
	}

	protected override string _GetTemplateForLabelBuidlersClubOnlyClose()
	{
		return "닫기";
	}
}
