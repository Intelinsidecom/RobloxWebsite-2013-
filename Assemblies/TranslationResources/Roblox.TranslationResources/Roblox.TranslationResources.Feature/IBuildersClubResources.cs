namespace Roblox.TranslationResources.Feature;

public interface IBuildersClubResources : ITranslationResources
{
	/// <summary>
	/// Key: "Action.BuidlersClubOnlyCancel"
	/// English String: "Cancel"
	/// </summary>
	string ActionBuidlersClubOnlyCancel { get; }

	/// <summary>
	/// Key: "Action.BuidlersClubOnlyUpgradeNow"
	/// English String: "Upgrade Now"
	/// </summary>
	string ActionBuidlersClubOnlyUpgradeNow { get; }

	/// <summary>
	/// Key: "Heading.BuildersClubOnly"
	/// English String: "Builders Club Only"
	/// </summary>
	string HeadingBuildersClubOnly { get; }

	/// <summary>
	/// Key: "Label.BuidlersClubOnlyClose"
	/// English String: "Close"
	/// </summary>
	string LabelBuidlersClubOnlyClose { get; }

	/// <summary>
	/// Key: "DescriptionBuildersClubOnlyModel"
	/// English String: "This is a premium item only available to our {bcRequirementName} members."
	/// </summary>
	string DescriptionBuildersClubOnlyModel(string bcRequirementName);
}
