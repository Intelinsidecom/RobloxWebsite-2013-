namespace Roblox.TranslationResources.Feature;

/// <summary>
/// This class overrides PlacesListResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class PlacesListResources_es_es : PlacesListResources_en_us, IPlacesListResources, ITranslationResources
{
	/// <summary>
	/// Key: "Action.JoinGame"
	/// Join game
	/// English String: "Join"
	/// </summary>
	public override string ActionJoinGame => "Unirse";

	/// <summary>
	/// Key: "Action.SeeAll"
	/// English String: "See All"
	/// </summary>
	public override string ActionSeeAll => "Ver todo";

	/// <summary>
	/// Key: "Action.ViewDetails"
	/// check game details page
	/// English String: "View Details"
	/// </summary>
	public override string ActionViewDetails => "Ver detalles";

	/// <summary>
	/// Key: "Label.ContextMenuTitle"
	/// English String: "Game"
	/// </summary>
	public override string LabelContextMenuTitle => "Juego";

	/// <summary>
	/// Key: "Label.PlacesListName"
	/// Title of game list
	/// English String: "Games"
	/// </summary>
	public override string LabelPlacesListName => "Juegos";

	public PlacesListResources_es_es(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionJoinGame()
	{
		return "Unirse";
	}

	protected override string _GetTemplateForActionSeeAll()
	{
		return "Ver todo";
	}

	protected override string _GetTemplateForActionViewDetails()
	{
		return "Ver detalles";
	}

	protected override string _GetTemplateForLabelContextMenuTitle()
	{
		return "Juego";
	}

	/// <summary>
	/// Key: "Label.CreatorBy"
	/// English String: "By {creatorLink}"
	/// </summary>
	public override string LabelCreatorBy(string creatorLink)
	{
		return $"De {creatorLink}";
	}

	protected override string _GetTemplateForLabelCreatorBy()
	{
		return "De {creatorLink}";
	}

	protected override string _GetTemplateForLabelPlacesListName()
	{
		return "Juegos";
	}

	/// <summary>
	/// Key: "Label.PlayingPhrase"
	/// number of players playing
	/// English String: "{playerCount} Playing"
	/// </summary>
	public override string LabelPlayingPhrase(string playerCount)
	{
		return $"{playerCount} jugando";
	}

	protected override string _GetTemplateForLabelPlayingPhrase()
	{
		return "{playerCount} jugando";
	}
}
