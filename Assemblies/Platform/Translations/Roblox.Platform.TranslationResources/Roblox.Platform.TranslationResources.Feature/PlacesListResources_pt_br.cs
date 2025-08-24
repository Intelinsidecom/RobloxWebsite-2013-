namespace Roblox.TranslationResources.Feature;

/// <summary>
/// This class overrides PlacesListResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class PlacesListResources_pt_br : PlacesListResources_en_us, IPlacesListResources, ITranslationResources
{
	/// <summary>
	/// Key: "Action.JoinGame"
	/// Join game
	/// English String: "Join"
	/// </summary>
	public override string ActionJoinGame => "Entrar";

	/// <summary>
	/// Key: "Action.SeeAll"
	/// English String: "See All"
	/// </summary>
	public override string ActionSeeAll => "Ver todos";

	/// <summary>
	/// Key: "Action.ViewDetails"
	/// check game details page
	/// English String: "View Details"
	/// </summary>
	public override string ActionViewDetails => "Ver detalhes";

	/// <summary>
	/// Key: "Label.ContextMenuTitle"
	/// English String: "Game"
	/// </summary>
	public override string LabelContextMenuTitle => "Jogo";

	/// <summary>
	/// Key: "Label.PlacesListName"
	/// Title of game list
	/// English String: "Games"
	/// </summary>
	public override string LabelPlacesListName => "Jogos";

	public PlacesListResources_pt_br(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionJoinGame()
	{
		return "Entrar";
	}

	protected override string _GetTemplateForActionSeeAll()
	{
		return "Ver todos";
	}

	protected override string _GetTemplateForActionViewDetails()
	{
		return "Ver detalhes";
	}

	protected override string _GetTemplateForLabelContextMenuTitle()
	{
		return "Jogo";
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
		return "Jogos";
	}

	/// <summary>
	/// Key: "Label.PlayingPhrase"
	/// number of players playing
	/// English String: "{playerCount} Playing"
	/// </summary>
	public override string LabelPlayingPhrase(string playerCount)
	{
		return $"{playerCount} jogando";
	}

	protected override string _GetTemplateForLabelPlayingPhrase()
	{
		return "{playerCount} jogando";
	}
}
