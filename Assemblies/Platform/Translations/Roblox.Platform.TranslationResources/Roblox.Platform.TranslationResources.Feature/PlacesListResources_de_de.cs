namespace Roblox.TranslationResources.Feature;

/// <summary>
/// This class overrides PlacesListResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class PlacesListResources_de_de : PlacesListResources_en_us, IPlacesListResources, ITranslationResources
{
	/// <summary>
	/// Key: "Action.JoinGame"
	/// Join game
	/// English String: "Join"
	/// </summary>
	public override string ActionJoinGame => "Beitreten";

	/// <summary>
	/// Key: "Action.SeeAll"
	/// English String: "See All"
	/// </summary>
	public override string ActionSeeAll => "Alle ansehen";

	/// <summary>
	/// Key: "Action.ViewDetails"
	/// check game details page
	/// English String: "View Details"
	/// </summary>
	public override string ActionViewDetails => "Infos anzeigen";

	/// <summary>
	/// Key: "Label.ContextMenuTitle"
	/// English String: "Game"
	/// </summary>
	public override string LabelContextMenuTitle => "Spiel";

	/// <summary>
	/// Key: "Label.PlacesListName"
	/// Title of game list
	/// English String: "Games"
	/// </summary>
	public override string LabelPlacesListName => "Spiele";

	public PlacesListResources_de_de(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionJoinGame()
	{
		return "Beitreten";
	}

	protected override string _GetTemplateForActionSeeAll()
	{
		return "Alle ansehen";
	}

	protected override string _GetTemplateForActionViewDetails()
	{
		return "Infos anzeigen";
	}

	protected override string _GetTemplateForLabelContextMenuTitle()
	{
		return "Spiel";
	}

	/// <summary>
	/// Key: "Label.CreatorBy"
	/// English String: "By {creatorLink}"
	/// </summary>
	public override string LabelCreatorBy(string creatorLink)
	{
		return $"Von {creatorLink}";
	}

	protected override string _GetTemplateForLabelCreatorBy()
	{
		return "Von {creatorLink}";
	}

	protected override string _GetTemplateForLabelPlacesListName()
	{
		return "Spiele";
	}

	/// <summary>
	/// Key: "Label.PlayingPhrase"
	/// number of players playing
	/// English String: "{playerCount} Playing"
	/// </summary>
	public override string LabelPlayingPhrase(string playerCount)
	{
		return $"{playerCount} Spieler";
	}

	protected override string _GetTemplateForLabelPlayingPhrase()
	{
		return "{playerCount} Spieler";
	}
}
