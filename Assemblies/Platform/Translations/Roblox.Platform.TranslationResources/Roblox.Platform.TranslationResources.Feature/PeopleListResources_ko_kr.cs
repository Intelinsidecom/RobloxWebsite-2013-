namespace Roblox.Platform.TranslationResources.Feature {
    /// <summary>

/// This class overrides PeopleListResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class PeopleListResources_ko_kr : PeopleListResources_en_us, IPeopleListResources, ITranslationResources
{
	/// <summary>
	/// Key: "Action.Buy"
	/// Purchase game and play
	/// English String: "Buy to Play"
	/// </summary>
	public override string ActionBuy => "êµ¬ìž…í•˜ì—¬ í”Œë ˆì´";

	/// <summary>
	/// Key: "Action.Join"
	/// Join game with friends
	/// English String: "Join"
	/// </summary>
	public override string ActionJoin => "ì°¸ê°€";

	/// <summary>
	/// Key: "Action.ViewDetails"
	/// View game details page
	/// English String: "View Details"
	/// </summary>
	public override string ActionViewDetails => "ìžì„¸ížˆ ë³´ê¸°";

	/// <summary>
	/// Key: "Heading.Friends"
	/// English String: "Friends"
	/// </summary>
	public override string HeadingFriends => "ì¹œêµ¬";

	/// <summary>
	/// Key: "Heading.SeeAll"
	/// English String: "See All"
	/// </summary>
	public override string HeadingSeeAll => "ì „ì²´ ë³´ê¸°";

	/// <summary>
	/// Key: "Label.ViewProfile"
	/// Go to Profile page and view
	/// English String: "View Profile"
	/// </summary>
	public override string LabelViewProfile => "í”„ë¡œí•„ ë³´ê¸°";

	public PeopleListResources_ko_kr(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionBuy()
	{
		return "êµ¬ìž…í•˜ì—¬ í”Œë ˆì´";
	}

	protected override string _GetTemplateForActionJoin()
	{
		return "ì°¸ê°€";
	}

	protected override string _GetTemplateForActionViewDetails()
	{
		return "ìžì„¸ížˆ ë³´ê¸°";
	}

	protected override string _GetTemplateForHeadingFriends()
	{
		return "ì¹œêµ¬";
	}

	protected override string _GetTemplateForHeadingSeeAll()
	{
		return "ì „ì²´ ë³´ê¸°";
	}

	/// <summary>
	/// Key: "Label.Chat"
	/// Chat with friends
	/// English String: "Chat with {username}"
	/// </summary>
	public override string LabelChat(string username)
	{
		return $"{username}ë‹˜ê³¼ ì±„íŒ…";
	}

	protected override string _GetTemplateForLabelChat()
	{
		return "{username}ë‹˜ê³¼ ì±„íŒ…";
	}

	protected override string _GetTemplateForLabelViewProfile()
	{
		return "í”„ë¡œí•„ ë³´ê¸°";
	}
}


}
