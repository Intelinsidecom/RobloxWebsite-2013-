namespace Roblox.TranslationResources.Feature;

public interface IGameGearOptionsDisplayResources : ITranslationResources
{
	/// <summary>
	/// Key: "LabelAllGenreAllowed"
	/// English String: "All Genres Allowed"
	/// </summary>
	string LabelAllGenreAllowed { get; }

	/// <summary>
	/// Key: "LabelNoGear"
	/// English String: "No Gear Allowed"
	/// </summary>
	string LabelNoGear { get; }

	/// <summary>
	/// Key: "LabelGearOnly"
	/// English String: "{GearName} Gear Only"
	/// </summary>
	string LabelGearOnly(string GearName);
}
