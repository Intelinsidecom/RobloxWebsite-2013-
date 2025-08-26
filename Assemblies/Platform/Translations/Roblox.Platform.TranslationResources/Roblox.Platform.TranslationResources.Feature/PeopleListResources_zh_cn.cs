namespace Roblox.Platform.TranslationResources.Feature {
    /// <summary>

/// This class overrides PeopleListResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class PeopleListResources_zh_cn : PeopleListResources_en_us, IPeopleListResources, ITranslationResources
{
	/// <summary>
	/// Key: "Action.Buy"
	/// Purchase game and play
	/// English String: "Buy to Play"
	/// </summary>
	public override string ActionBuy => "è´­ä¹°ä»¥å¼€å§‹æ¸¸æˆ";

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
	public override string ActionViewDetails => "æŸ¥çœ‹è¯¦æƒ…";

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
	public override string LabelViewProfile => "æŸ¥çœ‹ä¸ªäººèµ„æ–™";

	public PeopleListResources_zh_cn(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionBuy()
	{
		return "è´­ä¹°ä»¥å¼€å§‹æ¸¸æˆ";
	}

	protected override string _GetTemplateForActionJoin()
	{
		return "åŠ å…¥";
	}

	protected override string _GetTemplateForActionViewDetails()
	{
		return "æŸ¥çœ‹è¯¦æƒ…";
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
		return $"ä¸Žâ€œ{username}\"èŠå¤©";
	}

	protected override string _GetTemplateForLabelChat()
	{
		return "ä¸Žâ€œ{username}\"èŠå¤©";
	}

	protected override string _GetTemplateForLabelViewProfile()
	{
		return "æŸ¥çœ‹ä¸ªäººèµ„æ–™";
	}
}


}
