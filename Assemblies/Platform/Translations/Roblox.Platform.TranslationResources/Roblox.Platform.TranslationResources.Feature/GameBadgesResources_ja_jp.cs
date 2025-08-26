namespace Roblox.Platform.TranslationResources.Feature {
    /// <summary>

/// This class overrides GameBadgesResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class GameBadgesResources_ja_jp : GameBadgesResources_en_us, IGameBadgesResources, ITranslationResources
{
	/// <summary>
	/// Key: "HeadingGameBadges"
	/// English String: "Game Badges"
	/// </summary>
	public override string HeadingGameBadges => "ã‚²ãƒ¼ãƒ ãƒãƒƒã‚¸";

	/// <summary>
	/// Key: "Label.RarityCakeWalk"
	/// It would be extremely easy for the user to accomplish this goal.
	/// English String: "Cake Walk"
	/// </summary>
	public override string LabelRarityCakeWalk => "è¶…ã‚«ãƒ³ã‚¿ãƒ³";

	/// <summary>
	/// Key: "Label.RarityChallenging"
	/// It would be somewhat difficult for the user to accomplish this goal.
	/// English String: "Challenging"
	/// </summary>
	public override string LabelRarityChallenging => "æ‰‹ã”ãŸãˆã‚¢ãƒª";

	/// <summary>
	/// Key: "Label.RarityEasy"
	/// It would be easy for the user to accomplish this goal.
	/// English String: "Easy"
	/// </summary>
	public override string LabelRarityEasy => "ã‚«ãƒ³ã‚¿ãƒ³";

	/// <summary>
	/// Key: "Label.RarityExtreme"
	/// It would be extremely difficult for the user to accomplish this goal.
	/// English String: "Extreme"
	/// </summary>
	public override string LabelRarityExtreme => "ã‚¨ã‚¯ã‚¹ãƒˆãƒªãƒ¼ãƒ ";

	/// <summary>
	/// Key: "Label.RarityFreebie"
	/// The user will get this badge for free.
	/// English String: "Freebie"
	/// </summary>
	public override string LabelRarityFreebie => "ç„¡æ–™";

	/// <summary>
	/// Key: "Label.RarityHard"
	/// It would be difficult for the user to accomplish this goal.
	/// English String: "Hard"
	/// </summary>
	public override string LabelRarityHard => "é«˜é›£åº¦";

	/// <summary>
	/// Key: "Label.RarityImpossible"
	/// It is impossible for the user to accomplish this goal.
	/// English String: "Impossible"
	/// </summary>
	public override string LabelRarityImpossible => "ä¸å¯èƒ½";

	/// <summary>
	/// Key: "Label.RarityInsane"
	/// It is nearly impossible for the user to accomplish this goal.
	/// English String: "Insane"
	/// </summary>
	public override string LabelRarityInsane => "æ¿€ãƒ ã‚º";

	/// <summary>
	/// Key: "Label.RarityModerate"
	/// It would be moderate for the user to accomplish this goal. It is neither easy nor hard.
	/// English String: "Moderate"
	/// </summary>
	public override string LabelRarityModerate => "æ¨™æº–";

	/// <summary>
	/// Key: "LabelRarity"
	/// English String: "Rarity"
	/// </summary>
	public override string LabelRarity => "ãƒ¬ã‚¢åº¦";

	/// <summary>
	/// Key: "LabelSeeMore"
	/// English String: "See More"
	/// </summary>
	public override string LabelSeeMore => "ã‚‚ã£ã¨è¦‹ã‚‹";

	/// <summary>
	/// Key: "LabelWonEver"
	/// English String: "Won Ever"
	/// </summary>
	public override string LabelWonEver => "éŽåŽ»ã«ç²å¾—";

	/// <summary>
	/// Key: "LabelWonYesterday"
	/// English String: "Won Yesterday"
	/// </summary>
	public override string LabelWonYesterday => "æ˜¨æ—¥ç²å¾—";

	public GameBadgesResources_ja_jp(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForHeadingGameBadges()
	{
		return "ã‚²ãƒ¼ãƒ ãƒãƒƒã‚¸";
	}

	protected override string _GetTemplateForLabelRarityCakeWalk()
	{
		return "è¶…ã‚«ãƒ³ã‚¿ãƒ³";
	}

	protected override string _GetTemplateForLabelRarityChallenging()
	{
		return "æ‰‹ã”ãŸãˆã‚¢ãƒª";
	}

	protected override string _GetTemplateForLabelRarityEasy()
	{
		return "ã‚«ãƒ³ã‚¿ãƒ³";
	}

	protected override string _GetTemplateForLabelRarityExtreme()
	{
		return "ã‚¨ã‚¯ã‚¹ãƒˆãƒªãƒ¼ãƒ ";
	}

	protected override string _GetTemplateForLabelRarityFreebie()
	{
		return "ç„¡æ–™";
	}

	protected override string _GetTemplateForLabelRarityHard()
	{
		return "é«˜é›£åº¦";
	}

	protected override string _GetTemplateForLabelRarityImpossible()
	{
		return "ä¸å¯èƒ½";
	}

	protected override string _GetTemplateForLabelRarityInsane()
	{
		return "æ¿€ãƒ ã‚º";
	}

	protected override string _GetTemplateForLabelRarityModerate()
	{
		return "æ¨™æº–";
	}

	protected override string _GetTemplateForLabelRarity()
	{
		return "ãƒ¬ã‚¢åº¦";
	}

	protected override string _GetTemplateForLabelSeeMore()
	{
		return "ã‚‚ã£ã¨è¦‹ã‚‹";
	}

	protected override string _GetTemplateForLabelWonEver()
	{
		return "éŽåŽ»ã«ç²å¾—";
	}

	protected override string _GetTemplateForLabelWonYesterday()
	{
		return "æ˜¨æ—¥ç²å¾—";
	}
}


}
