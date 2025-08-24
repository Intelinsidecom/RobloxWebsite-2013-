namespace Roblox.TranslationResources.Feature;

/// <summary>
/// This class overrides GameGearOptionsDisplayResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class GameGearOptionsDisplayResources_fr_fr : GameGearOptionsDisplayResources_en_us, IGameGearOptionsDisplayResources, ITranslationResources
{
	/// <summary>
	/// Key: "LabelAllGenreAllowed"
	/// English String: "All Genres Allowed"
	/// </summary>
	public override string LabelAllGenreAllowed => "Tous genres autorisés";

	/// <summary>
	/// Key: "LabelNoGear"
	/// English String: "No Gear Allowed"
	/// </summary>
	public override string LabelNoGear => "Aucun équipement autorisé";

	public GameGearOptionsDisplayResources_fr_fr(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForLabelAllGenreAllowed()
	{
		return "Tous genres autorisés";
	}

	/// <summary>
	/// Key: "LabelGearOnly"
	/// English String: "{GearName} Gear Only"
	/// </summary>
	public override string LabelGearOnly(string GearName)
	{
		return $"Équipement {GearName} uniquement";
	}

	protected override string _GetTemplateForLabelGearOnly()
	{
		return "Équipement {GearName} uniquement";
	}

	protected override string _GetTemplateForLabelNoGear()
	{
		return "Aucun équipement autorisé";
	}
}
