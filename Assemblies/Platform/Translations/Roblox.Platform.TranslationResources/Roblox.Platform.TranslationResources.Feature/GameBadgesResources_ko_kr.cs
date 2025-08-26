namespace Roblox.Platform.TranslationResources.Feature {
    /// <summary>

/// This class overrides GameBadgesResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class GameBadgesResources_ko_kr : GameBadgesResources_en_us, IGameBadgesResources, ITranslationResources
{
	/// <summary>
	/// Key: "HeadingGameBadges"
	/// English String: "Game Badges"
	/// </summary>
	public override string HeadingGameBadges => "ê²Œìž„ ë°°ì§€";

	/// <summary>
	/// Key: "Label.RarityCakeWalk"
	/// It would be extremely easy for the user to accomplish this goal.
	/// English String: "Cake Walk"
	/// </summary>
	public override string LabelRarityCakeWalk => "í•˜ê¸‰";

	/// <summary>
	/// Key: "Label.RarityChallenging"
	/// It would be somewhat difficult for the user to accomplish this goal.
	/// English String: "Challenging"
	/// </summary>
	public override string LabelRarityChallenging => "ì¤‘ìƒê¸‰";

	/// <summary>
	/// Key: "Label.RarityEasy"
	/// It would be easy for the user to accomplish this goal.
	/// English String: "Easy"
	/// </summary>
	public override string LabelRarityEasy => "ì¤‘í•˜ê¸‰";

	/// <summary>
	/// Key: "Label.RarityExtreme"
	/// It would be extremely difficult for the user to accomplish this goal.
	/// English String: "Extreme"
	/// </summary>
	public override string LabelRarityExtreme => "í¬ê·€";

	/// <summary>
	/// Key: "Label.RarityFreebie"
	/// The user will get this badge for free.
	/// English String: "Freebie"
	/// </summary>
	public override string LabelRarityFreebie => "ë¬´ë£Œ";

	/// <summary>
	/// Key: "Label.RarityHard"
	/// It would be difficult for the user to accomplish this goal.
	/// English String: "Hard"
	/// </summary>
	public override string LabelRarityHard => "ìƒê¸‰";

	/// <summary>
	/// Key: "Label.RarityImpossible"
	/// It is impossible for the user to accomplish this goal.
	/// English String: "Impossible"
	/// </summary>
	public override string LabelRarityImpossible => "ë¶ˆê°€ëŠ¥";

	/// <summary>
	/// Key: "Label.RarityInsane"
	/// It is nearly impossible for the user to accomplish this goal.
	/// English String: "Insane"
	/// </summary>
	public override string LabelRarityInsane => "ì´ˆí¬ê·€";

	/// <summary>
	/// Key: "Label.RarityModerate"
	/// It would be moderate for the user to accomplish this goal. It is neither easy nor hard.
	/// English String: "Moderate"
	/// </summary>
	public override string LabelRarityModerate => "ê²€ì—´";

	/// <summary>
	/// Key: "LabelRarity"
	/// English String: "Rarity"
	/// </summary>
	public override string LabelRarity => "í¬ê·€ë„";

	/// <summary>
	/// Key: "LabelSeeMore"
	/// English String: "See More"
	/// </summary>
	public override string LabelSeeMore => "ë” ë³´ê¸°";

	/// <summary>
	/// Key: "LabelWonEver"
	/// English String: "Won Ever"
	/// </summary>
	public override string LabelWonEver => "í˜„ìž¬ê¹Œì§€ íšë“";

	/// <summary>
	/// Key: "LabelWonYesterday"
	/// English String: "Won Yesterday"
	/// </summary>
	public override string LabelWonYesterday => "ì–´ì œ íšë“";

	public GameBadgesResources_ko_kr(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForHeadingGameBadges()
	{
		return "ê²Œìž„ ë°°ì§€";
	}

	protected override string _GetTemplateForLabelRarityCakeWalk()
	{
		return "í•˜ê¸‰";
	}

	protected override string _GetTemplateForLabelRarityChallenging()
	{
		return "ì¤‘ìƒê¸‰";
	}

	protected override string _GetTemplateForLabelRarityEasy()
	{
		return "ì¤‘í•˜ê¸‰";
	}

	protected override string _GetTemplateForLabelRarityExtreme()
	{
		return "í¬ê·€";
	}

	protected override string _GetTemplateForLabelRarityFreebie()
	{
		return "ë¬´ë£Œ";
	}

	protected override string _GetTemplateForLabelRarityHard()
	{
		return "ìƒê¸‰";
	}

	protected override string _GetTemplateForLabelRarityImpossible()
	{
		return "ë¶ˆê°€ëŠ¥";
	}

	protected override string _GetTemplateForLabelRarityInsane()
	{
		return "ì´ˆí¬ê·€";
	}

	protected override string _GetTemplateForLabelRarityModerate()
	{
		return "ê²€ì—´";
	}

	protected override string _GetTemplateForLabelRarity()
	{
		return "í¬ê·€ë„";
	}

	protected override string _GetTemplateForLabelSeeMore()
	{
		return "ë” ë³´ê¸°";
	}

	protected override string _GetTemplateForLabelWonEver()
	{
		return "í˜„ìž¬ê¹Œì§€ íšë“";
	}

	protected override string _GetTemplateForLabelWonYesterday()
	{
		return "ì–´ì œ íšë“";
	}
}


}
