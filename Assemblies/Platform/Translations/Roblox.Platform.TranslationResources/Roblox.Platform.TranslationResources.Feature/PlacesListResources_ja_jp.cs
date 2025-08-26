namespace Roblox.Platform.TranslationResources.Feature {
    /// <summary>

/// This class overrides PlacesListResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class PlacesListResources_ja_jp : PlacesListResources_en_us, IPlacesListResources, ITranslationResources
{
	/// <summary>
	/// Key: "Action.JoinGame"
	/// Join game
	/// English String: "Join"
	/// </summary>
	public override string ActionJoinGame => "å‚åŠ ";

	/// <summary>
	/// Key: "Action.SeeAll"
	/// English String: "See All"
	/// </summary>
	public override string ActionSeeAll => "ã™ã¹ã¦è¦‹ã‚‹";

	/// <summary>
	/// Key: "Action.ViewDetails"
	/// check game details page
	/// English String: "View Details"
	/// </summary>
	public override string ActionViewDetails => "è©³ç´°ã‚’è¡¨ç¤º";

	/// <summary>
	/// Key: "Label.ContextMenuTitle"
	/// English String: "Game"
	/// </summary>
	public override string LabelContextMenuTitle => "ã‚²ãƒ¼ãƒ ";

	/// <summary>
	/// Key: "Label.PlacesListName"
	/// Title of game list
	/// English String: "Games"
	/// </summary>
	public override string LabelPlacesListName => "ã‚²ãƒ¼ãƒ ";

	public PlacesListResources_ja_jp(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionJoinGame()
	{
		return "å‚åŠ ";
	}

	protected override string _GetTemplateForActionSeeAll()
	{
		return "ã™ã¹ã¦è¦‹ã‚‹";
	}

	protected override string _GetTemplateForActionViewDetails()
	{
		return "è©³ç´°ã‚’è¡¨ç¤º";
	}

	protected override string _GetTemplateForLabelContextMenuTitle()
	{
		return "ã‚²ãƒ¼ãƒ ";
	}

	/// <summary>
	/// Key: "Label.CreatorBy"
	/// English String: "By {creatorLink}"
	/// </summary>
	public override string LabelCreatorBy(string creatorLink)
	{
		return $"ä½œï¼š{creatorLink}";
	}

	protected override string _GetTemplateForLabelCreatorBy()
	{
		return "ä½œï¼š{creatorLink}";
	}

	protected override string _GetTemplateForLabelPlacesListName()
	{
		return "ã‚²ãƒ¼ãƒ ";
	}

	/// <summary>
	/// Key: "Label.PlayingPhrase"
	/// number of players playing
	/// English String: "{playerCount} Playing"
	/// </summary>
	public override string LabelPlayingPhrase(string playerCount)
	{
		return $"{playerCount}äººãŒãƒ—ãƒ¬ã‚¤ä¸­";
	}

	protected override string _GetTemplateForLabelPlayingPhrase()
	{
		return "{playerCount}äººãŒãƒ—ãƒ¬ã‚¤ä¸­";
	}
}


}
