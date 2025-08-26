namespace Roblox.Platform.TranslationResources.Feature {
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
	public override string ActionJoinGame => "ì°¸ê°€";

	/// <summary>
	/// Key: "Action.SeeAll"
	/// English String: "See All"
	/// </summary>
	public override string ActionSeeAll => "ì „ì²´ ë³´ê¸°";

	/// <summary>
	/// Key: "Action.ViewDetails"
	/// check game details page
	/// English String: "View Details"
	/// </summary>
	public override string ActionViewDetails => "ìžì„¸ížˆ ë³´ê¸°";

	/// <summary>
	/// Key: "Label.ContextMenuTitle"
	/// English String: "Game"
	/// </summary>
	public override string LabelContextMenuTitle => "ê²Œìž„";

	/// <summary>
	/// Key: "Label.PlacesListName"
	/// Title of game list
	/// English String: "Games"
	/// </summary>
	public override string LabelPlacesListName => "ê²Œìž„";

	public PlacesListResources_ko_kr(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionJoinGame()
	{
		return "ì°¸ê°€";
	}

	protected override string _GetTemplateForActionSeeAll()
	{
		return "ì „ì²´ ë³´ê¸°";
	}

	protected override string _GetTemplateForActionViewDetails()
	{
		return "ìžì„¸ížˆ ë³´ê¸°";
	}

	protected override string _GetTemplateForLabelContextMenuTitle()
	{
		return "ê²Œìž„";
	}

	/// <summary>
	/// Key: "Label.CreatorBy"
	/// English String: "By {creatorLink}"
	/// </summary>
	public override string LabelCreatorBy(string creatorLink)
	{
		return $"ê°œë°œ: {creatorLink}";
	}

	protected override string _GetTemplateForLabelCreatorBy()
	{
		return "ê°œë°œ: {creatorLink}";
	}

	protected override string _GetTemplateForLabelPlacesListName()
	{
		return "ê²Œìž„";
	}

	/// <summary>
	/// Key: "Label.PlayingPhrase"
	/// number of players playing
	/// English String: "{playerCount} Playing"
	/// </summary>
	public override string LabelPlayingPhrase(string playerCount)
	{
		return $"{playerCount}ëª… í”Œë ˆì´ ì¤‘";
	}

	protected override string _GetTemplateForLabelPlayingPhrase()
	{
		return "{playerCount}ëª… í”Œë ˆì´ ì¤‘";
	}
}


}
