namespace Roblox.TranslationResources.Common;

public interface IAlertsAndOptionsResources : ITranslationResources
{
	/// <summary>
	/// Key: "Label.sBuyRobux"
	/// English String: "Buy Robux"
	/// </summary>
	string LabelsBuyRobux { get; }

	/// <summary>
	/// Key: "Label.sHelp"
	/// English String: "Help"
	/// </summary>
	string LabelsHelp { get; }

	/// <summary>
	/// Key: "Label.sLogout"
	/// English String: "Logout"
	/// </summary>
	string LabelsLogout { get; }

	/// <summary>
	/// Key: "Label.sRobux"
	/// English String: "Robux"
	/// </summary>
	string LabelsRobux { get; }

	/// <summary>
	/// Key: "Label.sSettings"
	/// English String: "Settings"
	/// </summary>
	string LabelsSettings { get; }

	/// <summary>
	/// Key: "Label.sRobuxMessage"
	/// English String: "{robuxValue} Robux"
	/// </summary>
	string LabelsRobuxMessage(string robuxValue);
}
