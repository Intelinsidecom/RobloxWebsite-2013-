namespace Roblox.Platform.TranslationResources.Feature {
    /// <summary>

/// This class overrides PeopleListResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class PeopleListResources_zh_tw : PeopleListResources_en_us, IPeopleListResources, ITranslationResources
{
	/// <summary>
	/// Key: "Action.Buy"
	/// Purchase game and play
	/// English String: "Buy to Play"
	/// </summary>
	public override string ActionBuy => "è²·ä¾†çŽ©";

	/// <summary>
	/// Key: "Action.Join"
	/// Join game with friends
	/// English String: "Join"
	/// </summary>
	public override string ActionJoin => "åŠ å…¥";

	/// <summary>
	/// Key: "Action.ViewDetails"
	/// View game details page
	/// English String: "View Details"
	/// </summary>
	public override string ActionViewDetails => "æª¢è¦–è©³ç´°è³‡æ–™";

	/// <summary>
	/// Key: "Heading.Friends"
	/// English String: "Friends"
	/// </summary>
	public override string HeadingFriends => "å¥½å‹";

	/// <summary>
	/// Key: "Heading.SeeAll"
	/// English String: "See All"
	/// </summary>
	public override string HeadingSeeAll => "æŸ¥çœ‹å…¨éƒ¨";

	/// <summary>
	/// Key: "Label.ViewProfile"
	/// Go to Profile page and view
	/// English String: "View Profile"
	/// </summary>
	public override string LabelViewProfile => "æª¢è¦–å€‹äººæª”æ¡ˆ";

	public PeopleListResources_zh_tw(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionBuy()
	{
		return "è²·ä¾†çŽ©";
	}

	protected override string _GetTemplateForActionJoin()
	{
		return "åŠ å…¥";
	}

	protected override string _GetTemplateForActionViewDetails()
	{
		return "æª¢è¦–è©³ç´°è³‡æ–™";
	}

	protected override string _GetTemplateForHeadingFriends()
	{
		return "å¥½å‹";
	}

	protected override string _GetTemplateForHeadingSeeAll()
	{
		return "æŸ¥çœ‹å…¨éƒ¨";
	}

	/// <summary>
	/// Key: "Label.Chat"
	/// Chat with friends
	/// English String: "Chat with {username}"
	/// </summary>
	public override string LabelChat(string username)
	{
		return $"èˆ‡ {username} èŠå¤©";
	}

	protected override string _GetTemplateForLabelChat()
	{
		return "èˆ‡ {username} èŠå¤©";
	}

	protected override string _GetTemplateForLabelViewProfile()
	{
		return "æª¢è¦–å€‹äººæª”æ¡ˆ";
	}
}


}
