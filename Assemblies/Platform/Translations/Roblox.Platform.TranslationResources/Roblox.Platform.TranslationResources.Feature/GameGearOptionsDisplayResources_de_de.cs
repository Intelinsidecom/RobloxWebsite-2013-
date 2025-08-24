namespace Roblox.TranslationResources.Feature;

/// <summary>
/// This class overrides GameGearOptionsDisplayResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class GameGearOptionsDisplayResources_de_de : GameGearOptionsDisplayResources_en_us, IGameGearOptionsDisplayResources, ITranslationResources
{
	/// <summary>
	/// Key: "LabelAllGenreAllowed"
	/// English String: "All Genres Allowed"
	/// </summary>
	public override string LabelAllGenreAllowed => "Alle Genres erlaubt";

	/// <summary>
	/// Key: "LabelNoGear"
	/// English String: "No Gear Allowed"
	/// </summary>
	public override string LabelNoGear => "Keine Ausrüstung erlaubt";

	public GameGearOptionsDisplayResources_de_de(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForLabelAllGenreAllowed()
	{
		return "Alle Genres erlaubt";
	}

	/// <summary>
	/// Key: "LabelGearOnly"
	/// English String: "{GearName} Gear Only"
	/// </summary>
	public override string LabelGearOnly(string GearName)
	{
		return $"Nur „{GearName}“-Ausrüstung";
	}

	protected override string _GetTemplateForLabelGearOnly()
	{
		return "Nur „{GearName}“-Ausrüstung";
	}

	protected override string _GetTemplateForLabelNoGear()
	{
		return "Keine Ausrüstung erlaubt";
	}
}
