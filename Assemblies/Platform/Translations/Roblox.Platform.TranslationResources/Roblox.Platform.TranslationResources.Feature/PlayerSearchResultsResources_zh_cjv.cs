namespace Roblox.TranslationResources.Feature;

/// <summary>
/// This class overrides PlayerSearchResultsResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class PlayerSearchResultsResources_zh_cjv : PlayerSearchResultsResources_en_us, IPlayerSearchResultsResources, ITranslationResources
{
	/// <summary>
	/// Key: "Action.AcceptRequest"
	/// English String: "Accept Request"
	/// </summary>
	public override string ActionAcceptRequest => "接受邀请";

	/// <summary>
	/// Key: "Action.AddFriend"
	/// English String: "Add Friend"
	/// </summary>
	public override string ActionAddFriend => "添加好友";

	/// <summary>
	/// Key: "Action.Chat"
	/// English String: "Chat"
	/// </summary>
	public override string ActionChat => "聊天";

	/// <summary>
	/// Key: "Action.JoinGame"
	/// English String: "Join Game"
	/// </summary>
	public override string ActionJoinGame => "加入游戏";

	/// <summary>
	/// Key: "Action.RequestSent"
	/// English String: "Request Sent"
	/// </summary>
	public override string ActionRequestSent => "邀请已发送";

	/// <summary>
	/// Key: "Label.AlsoKnownAsAbbreviation"
	/// English String: "aka."
	/// </summary>
	public override string LabelAlsoKnownAsAbbreviation => "又名";

	/// <summary>
	/// Key: "Label.Offline"
	/// English String: "Offline"
	/// </summary>
	public override string LabelOffline => "离线";

	/// <summary>
	/// Key: "Label.Online"
	/// English String: "Online"
	/// </summary>
	public override string LabelOnline => "在线";

	/// <summary>
	/// Key: "Label.Search"
	/// English String: "Search"
	/// </summary>
	public override string LabelSearch => "搜索";

	/// <summary>
	/// Key: "Label.ThisIsYou"
	/// English String: "This is you"
	/// </summary>
	public override string LabelThisIsYou => "这是你";

	/// <summary>
	/// Key: "Label.UnsafeInput"
	/// English String: "You have entered unsafe input. Please try your search again."
	/// </summary>
	public override string LabelUnsafeInput => "你输入的内容不安全。请重新搜索。";

	/// <summary>
	/// Key: "Label.YouAreFollowing"
	/// English String: "You are following"
	/// </summary>
	public override string LabelYouAreFollowing => "你正关注";

	/// <summary>
	/// Key: "Label.YouAreFriends"
	/// English String: "You are friends"
	/// </summary>
	public override string LabelYouAreFriends => "你们是好友";

	public PlayerSearchResultsResources_zh_cjv(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionAcceptRequest()
	{
		return "接受邀请";
	}

	protected override string _GetTemplateForActionAddFriend()
	{
		return "添加好友";
	}

	protected override string _GetTemplateForActionChat()
	{
		return "聊天";
	}

	protected override string _GetTemplateForActionJoinGame()
	{
		return "加入游戏";
	}

	protected override string _GetTemplateForActionRequestSent()
	{
		return "邀请已发送";
	}

	/// <summary>
	/// Key: "Heading.PlayerResultsFor"
	/// English String: "Player Results for {startSpan}{keyword}{endSpan}"
	/// </summary>
	public override string HeadingPlayerResultsFor(string startSpan, string keyword, string endSpan)
	{
		return $"搜索玩家{startSpan}“{keyword}”{endSpan}的结果";
	}

	protected override string _GetTemplateForHeadingPlayerResultsFor()
	{
		return "搜索玩家{startSpan}“{keyword}”{endSpan}的结果";
	}

	protected override string _GetTemplateForLabelAlsoKnownAsAbbreviation()
	{
		return "又名";
	}

	/// <summary>
	/// Key: "Label.EnterMinCharacters"
	/// English String: "Please enter at least {keywordMinLength} characters."
	/// </summary>
	public override string LabelEnterMinCharacters(string keywordMinLength)
	{
		return $"请输入至少 {keywordMinLength} 个字符。";
	}

	protected override string _GetTemplateForLabelEnterMinCharacters()
	{
		return "请输入至少 {keywordMinLength} 个字符。";
	}

	/// <summary>
	/// Key: "Label.NoMatchesAvailable"
	/// English String: "There are no matches available for \"{keyword}\""
	/// </summary>
	public override string LabelNoMatchesAvailable(string keyword)
	{
		return $"没有与“{keyword}”匹配的项目";
	}

	protected override string _GetTemplateForLabelNoMatchesAvailable()
	{
		return "没有与“{keyword}”匹配的项目";
	}

	protected override string _GetTemplateForLabelOffline()
	{
		return "离线";
	}

	protected override string _GetTemplateForLabelOnline()
	{
		return "在线";
	}

	protected override string _GetTemplateForLabelSearch()
	{
		return "搜索";
	}

	/// <summary>
	/// Key: "Label.ShowingCountOfResults"
	/// English String: "{countStartSpan}{resultsStart} - {resultsInPage} of {countEndSpan}{totalStartSpan}{totalResults}{totalEndSpan}"
	/// </summary>
	public override string LabelShowingCountOfResults(string countStartSpan, string resultsStart, string resultsInPage, string countEndSpan, string totalStartSpan, string totalResults, string totalEndSpan)
	{
		return $"{countStartSpan}{resultsStart} - {resultsInPage}/{countEndSpan}{totalStartSpan}{totalResults}{totalEndSpan}";
	}

	protected override string _GetTemplateForLabelShowingCountOfResults()
	{
		return "{countStartSpan}{resultsStart} - {resultsInPage}/{countEndSpan}{totalStartSpan}{totalResults}{totalEndSpan}";
	}

	protected override string _GetTemplateForLabelThisIsYou()
	{
		return "这是你";
	}

	protected override string _GetTemplateForLabelUnsafeInput()
	{
		return "你输入的内容不安全。请重新搜索。";
	}

	protected override string _GetTemplateForLabelYouAreFollowing()
	{
		return "你正关注";
	}

	protected override string _GetTemplateForLabelYouAreFriends()
	{
		return "你们是好友";
	}
}
