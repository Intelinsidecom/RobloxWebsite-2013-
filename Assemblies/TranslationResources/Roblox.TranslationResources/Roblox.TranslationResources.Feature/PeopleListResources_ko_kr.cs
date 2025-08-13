namespace Roblox.TranslationResources.Feature;

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
	public override string ActionBuy => "구입하여 플레이";

	/// <summary>
	/// Key: "Action.Join"
	/// Join game with friends
	/// English String: "Join"
	/// </summary>
	public override string ActionJoin => "참가";

	/// <summary>
	/// Key: "Action.ViewDetails"
	/// View game details page
	/// English String: "View Details"
	/// </summary>
	public override string ActionViewDetails => "자세히 보기";

	/// <summary>
	/// Key: "Heading.Friends"
	/// English String: "Friends"
	/// </summary>
	public override string HeadingFriends => "친구";

	/// <summary>
	/// Key: "Heading.SeeAll"
	/// English String: "See All"
	/// </summary>
	public override string HeadingSeeAll => "전체 보기";

	/// <summary>
	/// Key: "Label.ViewProfile"
	/// Go to Profile page and view
	/// English String: "View Profile"
	/// </summary>
	public override string LabelViewProfile => "프로필 보기";

	public PeopleListResources_ko_kr(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionBuy()
	{
		return "구입하여 플레이";
	}

	protected override string _GetTemplateForActionJoin()
	{
		return "참가";
	}

	protected override string _GetTemplateForActionViewDetails()
	{
		return "자세히 보기";
	}

	protected override string _GetTemplateForHeadingFriends()
	{
		return "친구";
	}

	protected override string _GetTemplateForHeadingSeeAll()
	{
		return "전체 보기";
	}

	/// <summary>
	/// Key: "Label.Chat"
	/// Chat with friends
	/// English String: "Chat with {username}"
	/// </summary>
	public override string LabelChat(string username)
	{
		return $"{username}님과 채팅";
	}

	protected override string _GetTemplateForLabelChat()
	{
		return "{username}님과 채팅";
	}

	protected override string _GetTemplateForLabelViewProfile()
	{
		return "프로필 보기";
	}
}
