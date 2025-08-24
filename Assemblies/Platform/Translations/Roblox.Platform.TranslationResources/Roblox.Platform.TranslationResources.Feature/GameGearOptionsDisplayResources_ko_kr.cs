namespace Roblox.TranslationResources.Feature;

/// <summary>
/// This class overrides GameGearOptionsDisplayResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class GameGearOptionsDisplayResources_ko_kr : GameGearOptionsDisplayResources_en_us, IGameGearOptionsDisplayResources, ITranslationResources
{
	/// <summary>
	/// Key: "LabelAllGenreAllowed"
	/// English String: "All Genres Allowed"
	/// </summary>
	public override string LabelAllGenreAllowed => "모든 장르 허용됨";

	/// <summary>
	/// Key: "LabelNoGear"
	/// English String: "No Gear Allowed"
	/// </summary>
	public override string LabelNoGear => "장비 사용 불가";

	public GameGearOptionsDisplayResources_ko_kr(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForLabelAllGenreAllowed()
	{
		return "모든 장르 허용됨";
	}

	/// <summary>
	/// Key: "LabelGearOnly"
	/// English String: "{GearName} Gear Only"
	/// </summary>
	public override string LabelGearOnly(string GearName)
	{
		return $"{GearName} 장비 전용";
	}

	protected override string _GetTemplateForLabelGearOnly()
	{
		return "{GearName} 장비 전용";
	}

	protected override string _GetTemplateForLabelNoGear()
	{
		return "장비 사용 불가";
	}
}
