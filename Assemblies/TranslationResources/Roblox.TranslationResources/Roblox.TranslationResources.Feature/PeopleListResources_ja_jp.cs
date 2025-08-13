namespace Roblox.TranslationResources.Feature;

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
	public override string ActionBuy => "買ってプレイ";

	/// <summary>
	/// Key: "Action.Join"
	/// Join game with friends
	/// English String: "Join"
	/// </summary>
	public override string ActionJoin => "参加";

	/// <summary>
	/// Key: "Action.ViewDetails"
	/// View game details page
	/// English String: "View Details"
	/// </summary>
	public override string ActionViewDetails => "詳細を表示";

	/// <summary>
	/// Key: "Heading.Friends"
	/// English String: "Friends"
	/// </summary>
	public override string HeadingFriends => "友達";

	/// <summary>
	/// Key: "Heading.SeeAll"
	/// English String: "See All"
	/// </summary>
	public override string HeadingSeeAll => "すべて見る";

	/// <summary>
	/// Key: "Label.ViewProfile"
	/// Go to Profile page and view
	/// English String: "View Profile"
	/// </summary>
	public override string LabelViewProfile => "プロフィールを表示";

	public PeopleListResources_ja_jp(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionBuy()
	{
		return "買ってプレイ";
	}

	protected override string _GetTemplateForActionJoin()
	{
		return "参加";
	}

	protected override string _GetTemplateForActionViewDetails()
	{
		return "詳細を表示";
	}

	protected override string _GetTemplateForHeadingFriends()
	{
		return "友達";
	}

	protected override string _GetTemplateForHeadingSeeAll()
	{
		return "すべて見る";
	}

	/// <summary>
	/// Key: "Label.Chat"
	/// Chat with friends
	/// English String: "Chat with {username}"
	/// </summary>
	public override string LabelChat(string username)
	{
		return $"{username} さんとチャット";
	}

	protected override string _GetTemplateForLabelChat()
	{
		return "{username} さんとチャット";
	}

	protected override string _GetTemplateForLabelViewProfile()
	{
		return "プロフィールを表示";
	}
}
