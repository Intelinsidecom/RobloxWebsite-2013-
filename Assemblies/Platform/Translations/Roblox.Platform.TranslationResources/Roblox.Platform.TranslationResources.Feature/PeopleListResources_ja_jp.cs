namespace Roblox.Platform.TranslationResources.Feature {
    /// <summary>

/// This class overrides PeopleListResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class PeopleListResources_ja_jp : PeopleListResources_en_us, IPeopleListResources, ITranslationResources
{
	/// <summary>
	/// Key: "Action.Buy"
	/// Purchase game and play
	/// English String: "Buy to Play"
	/// </summary>
	public override string ActionBuy => "è²·ã£ã¦ãƒ—ãƒ¬ã‚¤";

	/// <summary>
	/// Key: "Action.Join"
	/// Join game with friends
	/// English String: "Join"
	/// </summary>
	public override string ActionJoin => "å‚åŠ ";

	/// <summary>
	/// Key: "Action.ViewDetails"
	/// View game details page
	/// English String: "View Details"
	/// </summary>
	public override string ActionViewDetails => "è©³ç´°ã‚’è¡¨ç¤º";

	/// <summary>
	/// Key: "Heading.Friends"
	/// English String: "Friends"
	/// </summary>
	public override string HeadingFriends => "å‹é”";

	/// <summary>
	/// Key: "Heading.SeeAll"
	/// English String: "See All"
	/// </summary>
	public override string HeadingSeeAll => "ã™ã¹ã¦è¦‹ã‚‹";

	/// <summary>
	/// Key: "Label.ViewProfile"
	/// Go to Profile page and view
	/// English String: "View Profile"
	/// </summary>
	public override string LabelViewProfile => "ãƒ—ãƒ­ãƒ•ã‚£ãƒ¼ãƒ«ã‚’è¡¨ç¤º";

	public PeopleListResources_ja_jp(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionBuy()
	{
		return "è²·ã£ã¦ãƒ—ãƒ¬ã‚¤";
	}

	protected override string _GetTemplateForActionJoin()
	{
		return "å‚åŠ ";
	}

	protected override string _GetTemplateForActionViewDetails()
	{
		return "è©³ç´°ã‚’è¡¨ç¤º";
	}

	protected override string _GetTemplateForHeadingFriends()
	{
		return "å‹é”";
	}

	protected override string _GetTemplateForHeadingSeeAll()
	{
		return "ã™ã¹ã¦è¦‹ã‚‹";
	}

	/// <summary>
	/// Key: "Label.Chat"
	/// Chat with friends
	/// English String: "Chat with {username}"
	/// </summary>
	public override string LabelChat(string username)
	{
		return $"{username} ã•ã‚“ã¨ãƒãƒ£ãƒƒãƒˆ";
	}

	protected override string _GetTemplateForLabelChat()
	{
		return "{username} ã•ã‚“ã¨ãƒãƒ£ãƒƒãƒˆ";
	}

	protected override string _GetTemplateForLabelViewProfile()
	{
		return "ãƒ—ãƒ­ãƒ•ã‚£ãƒ¼ãƒ«ã‚’è¡¨ç¤º";
	}
}


}
