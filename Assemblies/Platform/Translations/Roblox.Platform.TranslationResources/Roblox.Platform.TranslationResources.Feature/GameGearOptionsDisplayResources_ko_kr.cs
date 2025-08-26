namespace Roblox.Platform.TranslationResources.Feature {
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
	public override string LabelAllGenreAllowed => "ëª¨ë“  ìž¥ë¥´ í—ˆìš©ë¨";

	/// <summary>
	/// Key: "LabelNoGear"
	/// English String: "No Gear Allowed"
	/// </summary>
	public override string LabelNoGear => "ìž¥ë¹„ ì‚¬ìš© ë¶ˆê°€";

	public GameGearOptionsDisplayResources_ko_kr(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForLabelAllGenreAllowed()
	{
		return "ëª¨ë“  ìž¥ë¥´ í—ˆìš©ë¨";
	}

	/// <summary>
	/// Key: "LabelGearOnly"
	/// English String: "{GearName} Gear Only"
	/// </summary>
	public override string LabelGearOnly(string GearName)
	{
		return $"{GearName} ìž¥ë¹„ ì „ìš©";
	}

	protected override string _GetTemplateForLabelGearOnly()
	{
		return "{GearName} ìž¥ë¹„ ì „ìš©";
	}

	protected override string _GetTemplateForLabelNoGear()
	{
		return "ìž¥ë¹„ ì‚¬ìš© ë¶ˆê°€";
	}
}


}
