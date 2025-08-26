namespace Roblox.Platform.TranslationResources.Feature {
    /// <summary>

/// This class overrides GameGearOptionsDisplayResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class GameGearOptionsDisplayResources_zh_cjv : GameGearOptionsDisplayResources_en_us, IGameGearOptionsDisplayResources, ITranslationResources
{
	/// <summary>
	/// Key: "LabelAllGenreAllowed"
	/// English String: "All Genres Allowed"
	/// </summary>
	public override string LabelAllGenreAllowed => "å…è®¸æ‰€æœ‰ä¸»é¢˜";

	/// <summary>
	/// Key: "LabelNoGear"
	/// English String: "No Gear Allowed"
	/// </summary>
	public override string LabelNoGear => "ä¸å…è®¸è£…å¤‡";

	public GameGearOptionsDisplayResources_zh_cjv(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForLabelAllGenreAllowed()
	{
		return "å…è®¸æ‰€æœ‰ä¸»é¢˜";
	}

	/// <summary>
	/// Key: "LabelGearOnly"
	/// English String: "{GearName} Gear Only"
	/// </summary>
	public override string LabelGearOnly(string GearName)
	{
		return $"ä»…é™ {GearName} è£…å¤‡";
	}

	protected override string _GetTemplateForLabelGearOnly()
	{
		return "ä»…é™ {GearName} è£…å¤‡";
	}

	protected override string _GetTemplateForLabelNoGear()
	{
		return "ä¸å…è®¸è£…å¤‡";
	}
}


}
