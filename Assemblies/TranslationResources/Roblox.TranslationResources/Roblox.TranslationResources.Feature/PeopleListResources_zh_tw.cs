namespace Roblox.TranslationResources.Feature;

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
	public override string ActionBuy => "買來玩";

	/// <summary>
	/// Key: "Action.Join"
	/// Join game with friends
	/// English String: "Join"
	/// </summary>
	public override string ActionJoin => "加入";

	/// <summary>
	/// Key: "Action.ViewDetails"
	/// View game details page
	/// English String: "View Details"
	/// </summary>
	public override string ActionViewDetails => "檢視詳細資料";

	/// <summary>
	/// Key: "Heading.Friends"
	/// English String: "Friends"
	/// </summary>
	public override string HeadingFriends => "好友";

	/// <summary>
	/// Key: "Heading.SeeAll"
	/// English String: "See All"
	/// </summary>
	public override string HeadingSeeAll => "查看全部";

	/// <summary>
	/// Key: "Label.ViewProfile"
	/// Go to Profile page and view
	/// English String: "View Profile"
	/// </summary>
	public override string LabelViewProfile => "檢視個人檔案";

	public PeopleListResources_zh_tw(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionBuy()
	{
		return "買來玩";
	}

	protected override string _GetTemplateForActionJoin()
	{
		return "加入";
	}

	protected override string _GetTemplateForActionViewDetails()
	{
		return "檢視詳細資料";
	}

	protected override string _GetTemplateForHeadingFriends()
	{
		return "好友";
	}

	protected override string _GetTemplateForHeadingSeeAll()
	{
		return "查看全部";
	}

	/// <summary>
	/// Key: "Label.Chat"
	/// Chat with friends
	/// English String: "Chat with {username}"
	/// </summary>
	public override string LabelChat(string username)
	{
		return $"與 {username} 聊天";
	}

	protected override string _GetTemplateForLabelChat()
	{
		return "與 {username} 聊天";
	}

	protected override string _GetTemplateForLabelViewProfile()
	{
		return "檢視個人檔案";
	}
}
