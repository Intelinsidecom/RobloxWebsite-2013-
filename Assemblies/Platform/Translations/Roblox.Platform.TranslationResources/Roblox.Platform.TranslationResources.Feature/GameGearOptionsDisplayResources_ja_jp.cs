namespace Roblox.Platform.TranslationResources.Feature {
    /// <summary>

/// This class overrides GameGearOptionsDisplayResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class GameGearOptionsDisplayResources_ja_jp : GameGearOptionsDisplayResources_en_us, IGameGearOptionsDisplayResources, ITranslationResources
{
	/// <summary>
	/// Key: "LabelAllGenreAllowed"
	/// English String: "All Genres Allowed"
	/// </summary>
	public override string LabelAllGenreAllowed => "ã™ã¹ã¦ã®ã‚¸ãƒ£ãƒ³ãƒ«ã‚’è¨±å¯";

	/// <summary>
	/// Key: "LabelNoGear"
	/// English String: "No Gear Allowed"
	/// </summary>
	public override string LabelNoGear => "è¨±å¯ã•ã‚ŒãŸã‚®ã‚¢ã¯ã‚ã‚Šã¾ã›ã‚“";

	public GameGearOptionsDisplayResources_ja_jp(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForLabelAllGenreAllowed()
	{
		return "ã™ã¹ã¦ã®ã‚¸ãƒ£ãƒ³ãƒ«ã‚’è¨±å¯";
	}

	/// <summary>
	/// Key: "LabelGearOnly"
	/// English String: "{GearName} Gear Only"
	/// </summary>
	public override string LabelGearOnly(string GearName)
	{
		return $"{GearName} ã‚®ã‚¢ã®ã¿";
	}

	protected override string _GetTemplateForLabelGearOnly()
	{
		return "{GearName} ã‚®ã‚¢ã®ã¿";
	}

	protected override string _GetTemplateForLabelNoGear()
	{
		return "è¨±å¯ã•ã‚ŒãŸã‚®ã‚¢ã¯ã‚ã‚Šã¾ã›ã‚“";
	}
}


}
