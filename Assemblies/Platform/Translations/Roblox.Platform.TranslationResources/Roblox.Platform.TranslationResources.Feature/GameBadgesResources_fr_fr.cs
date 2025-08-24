namespace Roblox.TranslationResources.Feature;

/// <summary>
/// This class overrides GameBadgesResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class GameBadgesResources_fr_fr : GameBadgesResources_en_us, IGameBadgesResources, ITranslationResources
{
	/// <summary>
	/// Key: "HeadingGameBadges"
	/// English String: "Game Badges"
	/// </summary>
	public override string HeadingGameBadges => "Badges du jeu";

	/// <summary>
	/// Key: "Label.RarityCakeWalk"
	/// It would be extremely easy for the user to accomplish this goal.
	/// English String: "Cake Walk"
	/// </summary>
	public override string LabelRarityCakeWalk => "Promenade de santé";

	/// <summary>
	/// Key: "Label.RarityChallenging"
	/// It would be somewhat difficult for the user to accomplish this goal.
	/// English String: "Challenging"
	/// </summary>
	public override string LabelRarityChallenging => "Compliqué";

	/// <summary>
	/// Key: "Label.RarityEasy"
	/// It would be easy for the user to accomplish this goal.
	/// English String: "Easy"
	/// </summary>
	public override string LabelRarityEasy => "Facile";

	/// <summary>
	/// Key: "Label.RarityExtreme"
	/// It would be extremely difficult for the user to accomplish this goal.
	/// English String: "Extreme"
	/// </summary>
	public override string LabelRarityExtreme => "Extrême";

	/// <summary>
	/// Key: "Label.RarityFreebie"
	/// The user will get this badge for free.
	/// English String: "Freebie"
	/// </summary>
	public override string LabelRarityFreebie => "Gratuit";

	/// <summary>
	/// Key: "Label.RarityHard"
	/// It would be difficult for the user to accomplish this goal.
	/// English String: "Hard"
	/// </summary>
	public override string LabelRarityHard => "Difficile";

	/// <summary>
	/// Key: "Label.RarityImpossible"
	/// It is impossible for the user to accomplish this goal.
	/// English String: "Impossible"
	/// </summary>
	public override string LabelRarityImpossible => "Impossible";

	/// <summary>
	/// Key: "Label.RarityInsane"
	/// It is nearly impossible for the user to accomplish this goal.
	/// English String: "Insane"
	/// </summary>
	public override string LabelRarityInsane => "Cauchemardesque";

	/// <summary>
	/// Key: "Label.RarityModerate"
	/// It would be moderate for the user to accomplish this goal. It is neither easy nor hard.
	/// English String: "Moderate"
	/// </summary>
	public override string LabelRarityModerate => "Moyen";

	/// <summary>
	/// Key: "LabelRarity"
	/// English String: "Rarity"
	/// </summary>
	public override string LabelRarity => "Rareté";

	/// <summary>
	/// Key: "LabelSeeMore"
	/// English String: "See More"
	/// </summary>
	public override string LabelSeeMore => "Afficher plus";

	/// <summary>
	/// Key: "LabelWonEver"
	/// English String: "Won Ever"
	/// </summary>
	public override string LabelWonEver => "Gagné (tous les temps)";

	/// <summary>
	/// Key: "LabelWonYesterday"
	/// English String: "Won Yesterday"
	/// </summary>
	public override string LabelWonYesterday => "Gagné hier";

	public GameBadgesResources_fr_fr(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForHeadingGameBadges()
	{
		return "Badges du jeu";
	}

	protected override string _GetTemplateForLabelRarityCakeWalk()
	{
		return "Promenade de santé";
	}

	protected override string _GetTemplateForLabelRarityChallenging()
	{
		return "Compliqué";
	}

	protected override string _GetTemplateForLabelRarityEasy()
	{
		return "Facile";
	}

	protected override string _GetTemplateForLabelRarityExtreme()
	{
		return "Extrême";
	}

	protected override string _GetTemplateForLabelRarityFreebie()
	{
		return "Gratuit";
	}

	protected override string _GetTemplateForLabelRarityHard()
	{
		return "Difficile";
	}

	protected override string _GetTemplateForLabelRarityImpossible()
	{
		return "Impossible";
	}

	protected override string _GetTemplateForLabelRarityInsane()
	{
		return "Cauchemardesque";
	}

	protected override string _GetTemplateForLabelRarityModerate()
	{
		return "Moyen";
	}

	protected override string _GetTemplateForLabelRarity()
	{
		return "Rareté";
	}

	protected override string _GetTemplateForLabelSeeMore()
	{
		return "Afficher plus";
	}

	protected override string _GetTemplateForLabelWonEver()
	{
		return "Gagné (tous les temps)";
	}

	protected override string _GetTemplateForLabelWonYesterday()
	{
		return "Gagné hier";
	}
}
