namespace Roblox.TranslationResources.Feature;

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
	public override string HeadingGameBadges => "ゲームバッジ";

	/// <summary>
	/// Key: "Label.RarityCakeWalk"
	/// It would be extremely easy for the user to accomplish this goal.
	/// English String: "Cake Walk"
	/// </summary>
	public override string LabelRarityCakeWalk => "超カンタン";

	/// <summary>
	/// Key: "Label.RarityChallenging"
	/// It would be somewhat difficult for the user to accomplish this goal.
	/// English String: "Challenging"
	/// </summary>
	public override string LabelRarityChallenging => "手ごたえアリ";

	/// <summary>
	/// Key: "Label.RarityEasy"
	/// It would be easy for the user to accomplish this goal.
	/// English String: "Easy"
	/// </summary>
	public override string LabelRarityEasy => "カンタン";

	/// <summary>
	/// Key: "Label.RarityExtreme"
	/// It would be extremely difficult for the user to accomplish this goal.
	/// English String: "Extreme"
	/// </summary>
	public override string LabelRarityExtreme => "エクストリーム";

	/// <summary>
	/// Key: "Label.RarityFreebie"
	/// The user will get this badge for free.
	/// English String: "Freebie"
	/// </summary>
	public override string LabelRarityFreebie => "無料";

	/// <summary>
	/// Key: "Label.RarityHard"
	/// It would be difficult for the user to accomplish this goal.
	/// English String: "Hard"
	/// </summary>
	public override string LabelRarityHard => "高難度";

	/// <summary>
	/// Key: "Label.RarityImpossible"
	/// It is impossible for the user to accomplish this goal.
	/// English String: "Impossible"
	/// </summary>
	public override string LabelRarityImpossible => "不可能";

	/// <summary>
	/// Key: "Label.RarityInsane"
	/// It is nearly impossible for the user to accomplish this goal.
	/// English String: "Insane"
	/// </summary>
	public override string LabelRarityInsane => "激ムズ";

	/// <summary>
	/// Key: "Label.RarityModerate"
	/// It would be moderate for the user to accomplish this goal. It is neither easy nor hard.
	/// English String: "Moderate"
	/// </summary>
	public override string LabelRarityModerate => "標準";

	/// <summary>
	/// Key: "LabelRarity"
	/// English String: "Rarity"
	/// </summary>
	public override string LabelRarity => "レア度";

	/// <summary>
	/// Key: "LabelSeeMore"
	/// English String: "See More"
	/// </summary>
	public override string LabelSeeMore => "もっと見る";

	/// <summary>
	/// Key: "LabelWonEver"
	/// English String: "Won Ever"
	/// </summary>
	public override string LabelWonEver => "過去に獲得";

	/// <summary>
	/// Key: "LabelWonYesterday"
	/// English String: "Won Yesterday"
	/// </summary>
	public override string LabelWonYesterday => "昨日獲得";

	public GameBadgesResources_ja_jp(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForHeadingGameBadges()
	{
		return "ゲームバッジ";
	}

	protected override string _GetTemplateForLabelRarityCakeWalk()
	{
		return "超カンタン";
	}

	protected override string _GetTemplateForLabelRarityChallenging()
	{
		return "手ごたえアリ";
	}

	protected override string _GetTemplateForLabelRarityEasy()
	{
		return "カンタン";
	}

	protected override string _GetTemplateForLabelRarityExtreme()
	{
		return "エクストリーム";
	}

	protected override string _GetTemplateForLabelRarityFreebie()
	{
		return "無料";
	}

	protected override string _GetTemplateForLabelRarityHard()
	{
		return "高難度";
	}

	protected override string _GetTemplateForLabelRarityImpossible()
	{
		return "不可能";
	}

	protected override string _GetTemplateForLabelRarityInsane()
	{
		return "激ムズ";
	}

	protected override string _GetTemplateForLabelRarityModerate()
	{
		return "標準";
	}

	protected override string _GetTemplateForLabelRarity()
	{
		return "レア度";
	}

	protected override string _GetTemplateForLabelSeeMore()
	{
		return "もっと見る";
	}

	protected override string _GetTemplateForLabelWonEver()
	{
		return "過去に獲得";
	}

	protected override string _GetTemplateForLabelWonYesterday()
	{
		return "昨日獲得";
	}
}
