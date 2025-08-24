namespace Roblox.TranslationResources.Feature;

/// <summary>
/// This class overrides GameBadgesResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class GameBadgesResources_zh_tw : GameBadgesResources_en_us, IGameBadgesResources, ITranslationResources
{
	/// <summary>
	/// Key: "HeadingGameBadges"
	/// English String: "Game Badges"
	/// </summary>
	public override string HeadingGameBadges => "遊戲徽章";

	/// <summary>
	/// Key: "Label.RarityCakeWalk"
	/// It would be extremely easy for the user to accomplish this goal.
	/// English String: "Cake Walk"
	/// </summary>
	public override string LabelRarityCakeWalk => "入門";

	/// <summary>
	/// Key: "Label.RarityChallenging"
	/// It would be somewhat difficult for the user to accomplish this goal.
	/// English String: "Challenging"
	/// </summary>
	public override string LabelRarityChallenging => "挑戰";

	/// <summary>
	/// Key: "Label.RarityEasy"
	/// It would be easy for the user to accomplish this goal.
	/// English String: "Easy"
	/// </summary>
	public override string LabelRarityEasy => "簡單";

	/// <summary>
	/// Key: "Label.RarityExtreme"
	/// It would be extremely difficult for the user to accomplish this goal.
	/// English String: "Extreme"
	/// </summary>
	public override string LabelRarityExtreme => "超難";

	/// <summary>
	/// Key: "Label.RarityFreebie"
	/// The user will get this badge for free.
	/// English String: "Freebie"
	/// </summary>
	public override string LabelRarityFreebie => "免費";

	/// <summary>
	/// Key: "Label.RarityHard"
	/// It would be difficult for the user to accomplish this goal.
	/// English String: "Hard"
	/// </summary>
	public override string LabelRarityHard => "困難";

	/// <summary>
	/// Key: "Label.RarityImpossible"
	/// It is impossible for the user to accomplish this goal.
	/// English String: "Impossible"
	/// </summary>
	public override string LabelRarityImpossible => "神人";

	/// <summary>
	/// Key: "Label.RarityInsane"
	/// It is nearly impossible for the user to accomplish this goal.
	/// English String: "Insane"
	/// </summary>
	public override string LabelRarityInsane => "極難";

	/// <summary>
	/// Key: "Label.RarityModerate"
	/// It would be moderate for the user to accomplish this goal. It is neither easy nor hard.
	/// English String: "Moderate"
	/// </summary>
	public override string LabelRarityModerate => "中等";

	/// <summary>
	/// Key: "LabelRarity"
	/// English String: "Rarity"
	/// </summary>
	public override string LabelRarity => "稀有度";

	/// <summary>
	/// Key: "LabelSeeMore"
	/// English String: "See More"
	/// </summary>
	public override string LabelSeeMore => "查看更多";

	/// <summary>
	/// Key: "LabelWonEver"
	/// English String: "Won Ever"
	/// </summary>
	public override string LabelWonEver => "歷來贏得";

	/// <summary>
	/// Key: "LabelWonYesterday"
	/// English String: "Won Yesterday"
	/// </summary>
	public override string LabelWonYesterday => "昨天贏得";

	public GameBadgesResources_zh_tw(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForHeadingGameBadges()
	{
		return "遊戲徽章";
	}

	protected override string _GetTemplateForLabelRarityCakeWalk()
	{
		return "入門";
	}

	protected override string _GetTemplateForLabelRarityChallenging()
	{
		return "挑戰";
	}

	protected override string _GetTemplateForLabelRarityEasy()
	{
		return "簡單";
	}

	protected override string _GetTemplateForLabelRarityExtreme()
	{
		return "超難";
	}

	protected override string _GetTemplateForLabelRarityFreebie()
	{
		return "免費";
	}

	protected override string _GetTemplateForLabelRarityHard()
	{
		return "困難";
	}

	protected override string _GetTemplateForLabelRarityImpossible()
	{
		return "神人";
	}

	protected override string _GetTemplateForLabelRarityInsane()
	{
		return "極難";
	}

	protected override string _GetTemplateForLabelRarityModerate()
	{
		return "中等";
	}

	protected override string _GetTemplateForLabelRarity()
	{
		return "稀有度";
	}

	protected override string _GetTemplateForLabelSeeMore()
	{
		return "查看更多";
	}

	protected override string _GetTemplateForLabelWonEver()
	{
		return "歷來贏得";
	}

	protected override string _GetTemplateForLabelWonYesterday()
	{
		return "昨天贏得";
	}
}
