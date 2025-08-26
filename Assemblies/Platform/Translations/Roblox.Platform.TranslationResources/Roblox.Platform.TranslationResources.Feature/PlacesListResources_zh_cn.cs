namespace Roblox.Platform.TranslationResources.Feature {
    /// <summary>

/// This class overrides PlacesListResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class PlacesListResources_zh_cn : PlacesListResources_en_us, IPlacesListResources, ITranslationResources
{
	/// <summary>
	/// Key: "Action.JoinGame"
	/// Join game
	/// English String: "Join"
	/// </summary>
	public override string ActionJoinGame => "åŠ å…¥";

	/// <summary>
	/// Key: "Action.SeeAll"
	/// English String: "See All"
	/// </summary>
	public override string ActionSeeAll => "æŸ¥çœ‹å…¨éƒ¨";

	/// <summary>
	/// Key: "Action.ViewDetails"
	/// check game details page
	/// English String: "View Details"
	/// </summary>
	public override string ActionViewDetails => "æŸ¥çœ‹è¯¦æƒ…";

	/// <summary>
	/// Key: "Label.ContextMenuTitle"
	/// English String: "Game"
	/// </summary>
	public override string LabelContextMenuTitle => "æ¸¸æˆ";

	/// <summary>
	/// Key: "Label.PlacesListName"
	/// Title of game list
	/// English String: "Games"
	/// </summary>
	public override string LabelPlacesListName => "æ¸¸æˆ";

	public PlacesListResources_zh_cn(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionJoinGame()
	{
		return "åŠ å…¥";
	}

	protected override string _GetTemplateForActionSeeAll()
	{
		return "æŸ¥çœ‹å…¨éƒ¨";
	}

	protected override string _GetTemplateForActionViewDetails()
	{
		return "æŸ¥çœ‹è¯¦æƒ…";
	}

	protected override string _GetTemplateForLabelContextMenuTitle()
	{
		return "æ¸¸æˆ";
	}

	/// <summary>
	/// Key: "Label.CreatorBy"
	/// English String: "By {creatorLink}"
	/// </summary>
	public override string LabelCreatorBy(string creatorLink)
	{
		return $"åˆ›ä½œè€… {creatorLink}";
	}

	protected override string _GetTemplateForLabelCreatorBy()
	{
		return "åˆ›ä½œè€… {creatorLink}";
	}

	protected override string _GetTemplateForLabelPlacesListName()
	{
		return "æ¸¸æˆ";
	}

	/// <summary>
	/// Key: "Label.PlayingPhrase"
	/// number of players playing
	/// English String: "{playerCount} Playing"
	/// </summary>
	public override string LabelPlayingPhrase(string playerCount)
	{
		return $"{playerCount} äººæ­£åœ¨çŽ©";
	}

	protected override string _GetTemplateForLabelPlayingPhrase()
	{
		return "{playerCount} äººæ­£åœ¨çŽ©";
	}
}


}
