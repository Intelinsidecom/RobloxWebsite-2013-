namespace Roblox.Platform.TranslationResources.Feature {
    /// <summary>

/// This class overrides GameBadgesResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class GameBadgesResources_zh_cn : GameBadgesResources_en_us, IGameBadgesResources, ITranslationResources
{
	/// <summary>
	/// Key: "HeadingGameBadges"
	/// English String: "Game Badges"
	/// </summary>
	public override string HeadingGameBadges => "æ¸¸æˆå¾½ç« ";

	/// <summary>
	/// Key: "Label.RarityCakeWalk"
	/// It would be extremely easy for the user to accomplish this goal.
	/// English String: "Cake Walk"
	/// </summary>
	public override string LabelRarityCakeWalk => "å…¥é—¨";

	/// <summary>
	/// Key: "Label.RarityChallenging"
	/// It would be somewhat difficult for the user to accomplish this goal.
	/// English String: "Challenging"
	/// </summary>
	public override string LabelRarityChallenging => "æŒ‘æˆ˜";

	/// <summary>
	/// Key: "Label.RarityEasy"
	/// It would be easy for the user to accomplish this goal.
	/// English String: "Easy"
	/// </summary>
	public override string LabelRarityEasy => "ç®€å•";

	/// <summary>
	/// Key: "Label.RarityExtreme"
	/// It would be extremely difficult for the user to accomplish this goal.
	/// English String: "Extreme"
	/// </summary>
	public override string LabelRarityExtreme => "è¶…éš¾";

	/// <summary>
	/// Key: "Label.RarityFreebie"
	/// The user will get this badge for free.
	/// English String: "Freebie"
	/// </summary>
	public override string LabelRarityFreebie => "å…è´¹";

	/// <summary>
	/// Key: "Label.RarityHard"
	/// It would be difficult for the user to accomplish this goal.
	/// English String: "Hard"
	/// </summary>
	public override string LabelRarityHard => "å›°éš¾";

	/// <summary>
	/// Key: "Label.RarityImpossible"
	/// It is impossible for the user to accomplish this goal.
	/// English String: "Impossible"
	/// </summary>
	public override string LabelRarityImpossible => "ç‚¼ç‹±";

	/// <summary>
	/// Key: "Label.RarityInsane"
	/// It is nearly impossible for the user to accomplish this goal.
	/// English String: "Insane"
	/// </summary>
	public override string LabelRarityInsane => "æžéš¾";

	/// <summary>
	/// Key: "Label.RarityModerate"
	/// It would be moderate for the user to accomplish this goal. It is neither easy nor hard.
	/// English String: "Moderate"
	/// </summary>
	public override string LabelRarityModerate => "ä¸­ç­‰";

	/// <summary>
	/// Key: "LabelRarity"
	/// English String: "Rarity"
	/// </summary>
	public override string LabelRarity => "ç¨€æœ‰åº¦";

	/// <summary>
	/// Key: "LabelSeeMore"
	/// English String: "See More"
	/// </summary>
	public override string LabelSeeMore => "æŸ¥çœ‹æ›´å¤š";

	/// <summary>
	/// Key: "LabelWonEver"
	/// English String: "Won Ever"
	/// </summary>
	public override string LabelWonEver => "åŽ†æ¥èµ¢å¾—";

	/// <summary>
	/// Key: "LabelWonYesterday"
	/// English String: "Won Yesterday"
	/// </summary>
	public override string LabelWonYesterday => "æ˜¨å¤©èµ¢å¾—";

	public GameBadgesResources_zh_cn(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForHeadingGameBadges()
	{
		return "æ¸¸æˆå¾½ç« ";
	}

	protected override string _GetTemplateForLabelRarityCakeWalk()
	{
		return "å…¥é—¨";
	}

	protected override string _GetTemplateForLabelRarityChallenging()
	{
		return "æŒ‘æˆ˜";
	}

	protected override string _GetTemplateForLabelRarityEasy()
	{
		return "ç®€å•";
	}

	protected override string _GetTemplateForLabelRarityExtreme()
	{
		return "è¶…éš¾";
	}

	protected override string _GetTemplateForLabelRarityFreebie()
	{
		return "å…è´¹";
	}

	protected override string _GetTemplateForLabelRarityHard()
	{
		return "å›°éš¾";
	}

	protected override string _GetTemplateForLabelRarityImpossible()
	{
		return "ç‚¼ç‹±";
	}

	protected override string _GetTemplateForLabelRarityInsane()
	{
		return "æžéš¾";
	}

	protected override string _GetTemplateForLabelRarityModerate()
	{
		return "ä¸­ç­‰";
	}

	protected override string _GetTemplateForLabelRarity()
	{
		return "ç¨€æœ‰åº¦";
	}

	protected override string _GetTemplateForLabelSeeMore()
	{
		return "æŸ¥çœ‹æ›´å¤š";
	}

	protected override string _GetTemplateForLabelWonEver()
	{
		return "åŽ†æ¥èµ¢å¾—";
	}

	protected override string _GetTemplateForLabelWonYesterday()
	{
		return "æ˜¨å¤©èµ¢å¾—";
	}
}


}
