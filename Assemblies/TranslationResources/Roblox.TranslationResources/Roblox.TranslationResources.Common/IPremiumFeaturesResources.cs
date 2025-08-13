namespace Roblox.TranslationResources.Common;

public interface IPremiumFeaturesResources : ITranslationResources
{
	/// <summary>
	/// Key: "Label.RobloxPremiumName"
	/// English String: "Roblox Premium"
	/// </summary>
	string LabelRobloxPremiumName { get; }

	/// <summary>
	/// Key: "Label.RobloxPremium"
	/// English String: "Roblox Premium {amount}"
	/// </summary>
	string LabelRobloxPremium(string amount);

	/// <summary>
	/// Key: "Label.RobuxPackage"
	/// English String: "{amount} Robux"
	/// </summary>
	string LabelRobuxPackage(string amount);
}
