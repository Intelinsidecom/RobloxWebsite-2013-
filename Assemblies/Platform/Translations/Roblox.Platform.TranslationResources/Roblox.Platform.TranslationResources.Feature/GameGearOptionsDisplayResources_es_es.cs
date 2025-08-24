namespace Roblox.TranslationResources.Feature;

/// <summary>
/// This class overrides GameGearOptionsDisplayResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class GameGearOptionsDisplayResources_es_es : GameGearOptionsDisplayResources_en_us, IGameGearOptionsDisplayResources, ITranslationResources
{
	/// <summary>
	/// Key: "LabelAllGenreAllowed"
	/// English String: "All Genres Allowed"
	/// </summary>
	public override string LabelAllGenreAllowed => "Se permiten todos los géneros";

	/// <summary>
	/// Key: "LabelNoGear"
	/// English String: "No Gear Allowed"
	/// </summary>
	public override string LabelNoGear => "No se permite equipamiento";

	public GameGearOptionsDisplayResources_es_es(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForLabelAllGenreAllowed()
	{
		return "Se permiten todos los géneros";
	}

	/// <summary>
	/// Key: "LabelGearOnly"
	/// English String: "{GearName} Gear Only"
	/// </summary>
	public override string LabelGearOnly(string GearName)
	{
		return $"{GearName} solo equipamiento";
	}

	protected override string _GetTemplateForLabelGearOnly()
	{
		return "{GearName} solo equipamiento";
	}

	protected override string _GetTemplateForLabelNoGear()
	{
		return "No se permite equipamiento";
	}
}
