namespace Roblox.TranslationResources.Feature;

/// <summary>
/// This class overrides PlacesListResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class PlacesListResources_ko_kr : PlacesListResources_en_us, IPlacesListResources, ITranslationResources
{
	/// <summary>
	/// Key: "Action.JoinGame"
	/// Join game
	/// English String: "Join"
	/// </summary>
	public override string ActionJoinGame => "참가";

	/// <summary>
	/// Key: "Action.SeeAll"
	/// English String: "See All"
	/// </summary>
	public override string ActionSeeAll => "전체 보기";

	/// <summary>
	/// Key: "Action.ViewDetails"
	/// check game details page
	/// English String: "View Details"
	/// </summary>
	public override string ActionViewDetails => "자세히 보기";

	/// <summary>
	/// Key: "Label.ContextMenuTitle"
	/// English String: "Game"
	/// </summary>
	public override string LabelContextMenuTitle => "게임";

	/// <summary>
	/// Key: "Label.PlacesListName"
	/// Title of game list
	/// English String: "Games"
	/// </summary>
	public override string LabelPlacesListName => "게임";

	public PlacesListResources_ko_kr(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionJoinGame()
	{
		return "참가";
	}

	protected override string _GetTemplateForActionSeeAll()
	{
		return "전체 보기";
	}

	protected override string _GetTemplateForActionViewDetails()
	{
		return "자세히 보기";
	}

	protected override string _GetTemplateForLabelContextMenuTitle()
	{
		return "게임";
	}

	/// <summary>
	/// Key: "Label.CreatorBy"
	/// English String: "By {creatorLink}"
	/// </summary>
	public override string LabelCreatorBy(string creatorLink)
	{
		return $"개발: {creatorLink}";
	}

	protected override string _GetTemplateForLabelCreatorBy()
	{
		return "개발: {creatorLink}";
	}

	protected override string _GetTemplateForLabelPlacesListName()
	{
		return "게임";
	}

	/// <summary>
	/// Key: "Label.PlayingPhrase"
	/// number of players playing
	/// English String: "{playerCount} Playing"
	/// </summary>
	public override string LabelPlayingPhrase(string playerCount)
	{
		return $"{playerCount}명 플레이 중";
	}

	protected override string _GetTemplateForLabelPlayingPhrase()
	{
		return "{playerCount}명 플레이 중";
	}
}
