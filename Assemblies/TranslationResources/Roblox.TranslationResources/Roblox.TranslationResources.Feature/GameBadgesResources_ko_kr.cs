namespace Roblox.TranslationResources.Feature;

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
	public override string HeadingGameBadges => "게임 배지";

	/// <summary>
	/// Key: "Label.RarityCakeWalk"
	/// It would be extremely easy for the user to accomplish this goal.
	/// English String: "Cake Walk"
	/// </summary>
	public override string LabelRarityCakeWalk => "하급";

	/// <summary>
	/// Key: "Label.RarityChallenging"
	/// It would be somewhat difficult for the user to accomplish this goal.
	/// English String: "Challenging"
	/// </summary>
	public override string LabelRarityChallenging => "중상급";

	/// <summary>
	/// Key: "Label.RarityEasy"
	/// It would be easy for the user to accomplish this goal.
	/// English String: "Easy"
	/// </summary>
	public override string LabelRarityEasy => "중하급";

	/// <summary>
	/// Key: "Label.RarityExtreme"
	/// It would be extremely difficult for the user to accomplish this goal.
	/// English String: "Extreme"
	/// </summary>
	public override string LabelRarityExtreme => "희귀";

	/// <summary>
	/// Key: "Label.RarityFreebie"
	/// The user will get this badge for free.
	/// English String: "Freebie"
	/// </summary>
	public override string LabelRarityFreebie => "무료";

	/// <summary>
	/// Key: "Label.RarityHard"
	/// It would be difficult for the user to accomplish this goal.
	/// English String: "Hard"
	/// </summary>
	public override string LabelRarityHard => "상급";

	/// <summary>
	/// Key: "Label.RarityImpossible"
	/// It is impossible for the user to accomplish this goal.
	/// English String: "Impossible"
	/// </summary>
	public override string LabelRarityImpossible => "불가능";

	/// <summary>
	/// Key: "Label.RarityInsane"
	/// It is nearly impossible for the user to accomplish this goal.
	/// English String: "Insane"
	/// </summary>
	public override string LabelRarityInsane => "초희귀";

	/// <summary>
	/// Key: "Label.RarityModerate"
	/// It would be moderate for the user to accomplish this goal. It is neither easy nor hard.
	/// English String: "Moderate"
	/// </summary>
	public override string LabelRarityModerate => "검열";

	/// <summary>
	/// Key: "LabelRarity"
	/// English String: "Rarity"
	/// </summary>
	public override string LabelRarity => "희귀도";

	/// <summary>
	/// Key: "LabelSeeMore"
	/// English String: "See More"
	/// </summary>
	public override string LabelSeeMore => "더 보기";

	/// <summary>
	/// Key: "LabelWonEver"
	/// English String: "Won Ever"
	/// </summary>
	public override string LabelWonEver => "현재까지 획득";

	/// <summary>
	/// Key: "LabelWonYesterday"
	/// English String: "Won Yesterday"
	/// </summary>
	public override string LabelWonYesterday => "어제 획득";

	public GameBadgesResources_ko_kr(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForHeadingGameBadges()
	{
		return "게임 배지";
	}

	protected override string _GetTemplateForLabelRarityCakeWalk()
	{
		return "하급";
	}

	protected override string _GetTemplateForLabelRarityChallenging()
	{
		return "중상급";
	}

	protected override string _GetTemplateForLabelRarityEasy()
	{
		return "중하급";
	}

	protected override string _GetTemplateForLabelRarityExtreme()
	{
		return "희귀";
	}

	protected override string _GetTemplateForLabelRarityFreebie()
	{
		return "무료";
	}

	protected override string _GetTemplateForLabelRarityHard()
	{
		return "상급";
	}

	protected override string _GetTemplateForLabelRarityImpossible()
	{
		return "불가능";
	}

	protected override string _GetTemplateForLabelRarityInsane()
	{
		return "초희귀";
	}

	protected override string _GetTemplateForLabelRarityModerate()
	{
		return "검열";
	}

	protected override string _GetTemplateForLabelRarity()
	{
		return "희귀도";
	}

	protected override string _GetTemplateForLabelSeeMore()
	{
		return "더 보기";
	}

	protected override string _GetTemplateForLabelWonEver()
	{
		return "현재까지 획득";
	}

	protected override string _GetTemplateForLabelWonYesterday()
	{
		return "어제 획득";
	}
}
