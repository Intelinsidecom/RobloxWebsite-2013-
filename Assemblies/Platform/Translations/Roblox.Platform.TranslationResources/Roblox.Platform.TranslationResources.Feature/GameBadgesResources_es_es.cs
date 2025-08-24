namespace Roblox.TranslationResources.Feature;

/// <summary>
/// This class overrides GameBadgesResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class GameBadgesResources_es_es : GameBadgesResources_en_us, IGameBadgesResources, ITranslationResources
{
	/// <summary>
	/// Key: "HeadingGameBadges"
	/// English String: "Game Badges"
	/// </summary>
	public override string HeadingGameBadges => "Emblemas del juego";

	/// <summary>
	/// Key: "Label.RarityCakeWalk"
	/// It would be extremely easy for the user to accomplish this goal.
	/// English String: "Cake Walk"
	/// </summary>
	public override string LabelRarityCakeWalk => "Muy fácil";

	/// <summary>
	/// Key: "Label.RarityChallenging"
	/// It would be somewhat difficult for the user to accomplish this goal.
	/// English String: "Challenging"
	/// </summary>
	public override string LabelRarityChallenging => "Complicado";

	/// <summary>
	/// Key: "Label.RarityEasy"
	/// It would be easy for the user to accomplish this goal.
	/// English String: "Easy"
	/// </summary>
	public override string LabelRarityEasy => "Fácil";

	/// <summary>
	/// Key: "Label.RarityExtreme"
	/// It would be extremely difficult for the user to accomplish this goal.
	/// English String: "Extreme"
	/// </summary>
	public override string LabelRarityExtreme => "Extremo";

	/// <summary>
	/// Key: "Label.RarityFreebie"
	/// The user will get this badge for free.
	/// English String: "Freebie"
	/// </summary>
	public override string LabelRarityFreebie => "Gratuito";

	/// <summary>
	/// Key: "Label.RarityHard"
	/// It would be difficult for the user to accomplish this goal.
	/// English String: "Hard"
	/// </summary>
	public override string LabelRarityHard => "Difícil";

	/// <summary>
	/// Key: "Label.RarityImpossible"
	/// It is impossible for the user to accomplish this goal.
	/// English String: "Impossible"
	/// </summary>
	public override string LabelRarityImpossible => "Imposible";

	/// <summary>
	/// Key: "Label.RarityInsane"
	/// It is nearly impossible for the user to accomplish this goal.
	/// English String: "Insane"
	/// </summary>
	public override string LabelRarityInsane => "De locos";

	/// <summary>
	/// Key: "Label.RarityModerate"
	/// It would be moderate for the user to accomplish this goal. It is neither easy nor hard.
	/// English String: "Moderate"
	/// </summary>
	public override string LabelRarityModerate => "Moderado";

	/// <summary>
	/// Key: "LabelRarity"
	/// English String: "Rarity"
	/// </summary>
	public override string LabelRarity => "Rareza";

	/// <summary>
	/// Key: "LabelSeeMore"
	/// English String: "See More"
	/// </summary>
	public override string LabelSeeMore => "Ver más";

	/// <summary>
	/// Key: "LabelWonEver"
	/// English String: "Won Ever"
	/// </summary>
	public override string LabelWonEver => "Ganados hasta la fecha";

	/// <summary>
	/// Key: "LabelWonYesterday"
	/// English String: "Won Yesterday"
	/// </summary>
	public override string LabelWonYesterday => "Ganados ayer";

	public GameBadgesResources_es_es(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForHeadingGameBadges()
	{
		return "Emblemas del juego";
	}

	protected override string _GetTemplateForLabelRarityCakeWalk()
	{
		return "Muy fácil";
	}

	protected override string _GetTemplateForLabelRarityChallenging()
	{
		return "Complicado";
	}

	protected override string _GetTemplateForLabelRarityEasy()
	{
		return "Fácil";
	}

	protected override string _GetTemplateForLabelRarityExtreme()
	{
		return "Extremo";
	}

	protected override string _GetTemplateForLabelRarityFreebie()
	{
		return "Gratuito";
	}

	protected override string _GetTemplateForLabelRarityHard()
	{
		return "Difícil";
	}

	protected override string _GetTemplateForLabelRarityImpossible()
	{
		return "Imposible";
	}

	protected override string _GetTemplateForLabelRarityInsane()
	{
		return "De locos";
	}

	protected override string _GetTemplateForLabelRarityModerate()
	{
		return "Moderado";
	}

	protected override string _GetTemplateForLabelRarity()
	{
		return "Rareza";
	}

	protected override string _GetTemplateForLabelSeeMore()
	{
		return "Ver más";
	}

	protected override string _GetTemplateForLabelWonEver()
	{
		return "Ganados hasta la fecha";
	}

	protected override string _GetTemplateForLabelWonYesterday()
	{
		return "Ganados ayer";
	}
}
