namespace Roblox.TranslationResources.Feature;

/// <summary>
/// This class overrides GameBadgesResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class GameBadgesResources_de_de : GameBadgesResources_en_us, IGameBadgesResources, ITranslationResources
{
	/// <summary>
	/// Key: "HeadingGameBadges"
	/// English String: "Game Badges"
	/// </summary>
	public override string HeadingGameBadges => "Spielabzeichen";

	/// <summary>
	/// Key: "Label.RarityCakeWalk"
	/// It would be extremely easy for the user to accomplish this goal.
	/// English String: "Cake Walk"
	/// </summary>
	public override string LabelRarityCakeWalk => "Kinderspiel";

	/// <summary>
	/// Key: "Label.RarityChallenging"
	/// It would be somewhat difficult for the user to accomplish this goal.
	/// English String: "Challenging"
	/// </summary>
	public override string LabelRarityChallenging => "Fordernd";

	/// <summary>
	/// Key: "Label.RarityEasy"
	/// It would be easy for the user to accomplish this goal.
	/// English String: "Easy"
	/// </summary>
	public override string LabelRarityEasy => "Einfach";

	/// <summary>
	/// Key: "Label.RarityExtreme"
	/// It would be extremely difficult for the user to accomplish this goal.
	/// English String: "Extreme"
	/// </summary>
	public override string LabelRarityExtreme => "Extrem";

	/// <summary>
	/// Key: "Label.RarityFreebie"
	/// The user will get this badge for free.
	/// English String: "Freebie"
	/// </summary>
	public override string LabelRarityFreebie => "Geschenkt";

	/// <summary>
	/// Key: "Label.RarityHard"
	/// It would be difficult for the user to accomplish this goal.
	/// English String: "Hard"
	/// </summary>
	public override string LabelRarityHard => "Schwierig";

	/// <summary>
	/// Key: "Label.RarityImpossible"
	/// It is impossible for the user to accomplish this goal.
	/// English String: "Impossible"
	/// </summary>
	public override string LabelRarityImpossible => "Unmöglich";

	/// <summary>
	/// Key: "Label.RarityInsane"
	/// It is nearly impossible for the user to accomplish this goal.
	/// English String: "Insane"
	/// </summary>
	public override string LabelRarityInsane => "Wahnsinnig";

	/// <summary>
	/// Key: "Label.RarityModerate"
	/// It would be moderate for the user to accomplish this goal. It is neither easy nor hard.
	/// English String: "Moderate"
	/// </summary>
	public override string LabelRarityModerate => "Mittelmäßig";

	/// <summary>
	/// Key: "LabelRarity"
	/// English String: "Rarity"
	/// </summary>
	public override string LabelRarity => "Seltenheit";

	/// <summary>
	/// Key: "LabelSeeMore"
	/// English String: "See More"
	/// </summary>
	public override string LabelSeeMore => "Mehr ansehen";

	/// <summary>
	/// Key: "LabelWonEver"
	/// English String: "Won Ever"
	/// </summary>
	public override string LabelWonEver => "Seit Beginn gewonnen";

	/// <summary>
	/// Key: "LabelWonYesterday"
	/// English String: "Won Yesterday"
	/// </summary>
	public override string LabelWonYesterday => "Gestern gewonnen";

	public GameBadgesResources_de_de(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForHeadingGameBadges()
	{
		return "Spielabzeichen";
	}

	protected override string _GetTemplateForLabelRarityCakeWalk()
	{
		return "Kinderspiel";
	}

	protected override string _GetTemplateForLabelRarityChallenging()
	{
		return "Fordernd";
	}

	protected override string _GetTemplateForLabelRarityEasy()
	{
		return "Einfach";
	}

	protected override string _GetTemplateForLabelRarityExtreme()
	{
		return "Extrem";
	}

	protected override string _GetTemplateForLabelRarityFreebie()
	{
		return "Geschenkt";
	}

	protected override string _GetTemplateForLabelRarityHard()
	{
		return "Schwierig";
	}

	protected override string _GetTemplateForLabelRarityImpossible()
	{
		return "Unmöglich";
	}

	protected override string _GetTemplateForLabelRarityInsane()
	{
		return "Wahnsinnig";
	}

	protected override string _GetTemplateForLabelRarityModerate()
	{
		return "Mittelmäßig";
	}

	protected override string _GetTemplateForLabelRarity()
	{
		return "Seltenheit";
	}

	protected override string _GetTemplateForLabelSeeMore()
	{
		return "Mehr ansehen";
	}

	protected override string _GetTemplateForLabelWonEver()
	{
		return "Seit Beginn gewonnen";
	}

	protected override string _GetTemplateForLabelWonYesterday()
	{
		return "Gestern gewonnen";
	}
}
