namespace Roblox.TranslationResources.Feature;

/// <summary>
/// This class overrides PlayerSearchResultsResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class PlayerSearchResultsResources_zh_tw : PlayerSearchResultsResources_en_us, IPlayerSearchResultsResources, ITranslationResources
{
	/// <summary>
	/// Key: "Action.AcceptRequest"
	/// English String: "Accept Request"
	/// </summary>
	public override string ActionAcceptRequest => "接受邀請";

	/// <summary>
	/// Key: "Action.AddFriend"
	/// English String: "Add Friend"
	/// </summary>
	public override string ActionAddFriend => "新增好友";

	/// <summary>
	/// Key: "Action.Chat"
	/// English String: "Chat"
	/// </summary>
	public override string ActionChat => "聊天";

	/// <summary>
	/// Key: "Action.JoinGame"
	/// English String: "Join Game"
	/// </summary>
	public override string ActionJoinGame => "加入遊戲";

	/// <summary>
	/// Key: "Action.RequestSent"
	/// English String: "Request Sent"
	/// </summary>
	public override string ActionRequestSent => "已傳送邀請";

	/// <summary>
	/// Key: "Label.AlsoKnownAsAbbreviation"
	/// English String: "aka."
	/// </summary>
	public override string LabelAlsoKnownAsAbbreviation => "又稱";

	/// <summary>
	/// Key: "Label.Offline"
	/// English String: "Offline"
	/// </summary>
	public override string LabelOffline => "離線";

	/// <summary>
	/// Key: "Label.Online"
	/// English String: "Online"
	/// </summary>
	public override string LabelOnline => "在線";

	/// <summary>
	/// Key: "Label.Search"
	/// English String: "Search"
	/// </summary>
	public override string LabelSearch => "搜尋";

	/// <summary>
	/// Key: "Label.ThisIsYou"
	/// English String: "This is you"
	/// </summary>
	public override string LabelThisIsYou => "這是您";

	/// <summary>
	/// Key: "Label.UnsafeInput"
	/// English String: "You have entered unsafe input. Please try your search again."
	/// </summary>
	public override string LabelUnsafeInput => "您輸入的內容不安全，請重新搜尋。";

	/// <summary>
	/// Key: "Label.YouAreFollowing"
	/// English String: "You are following"
	/// </summary>
	public override string LabelYouAreFollowing => "您在追蹤";

	/// <summary>
	/// Key: "Label.YouAreFriends"
	/// English String: "You are friends"
	/// </summary>
	public override string LabelYouAreFriends => "你們是好友";

	public PlayerSearchResultsResources_zh_tw(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionAcceptRequest()
	{
		return "接受邀請";
	}

	protected override string _GetTemplateForActionAddFriend()
	{
		return "新增好友";
	}

	protected override string _GetTemplateForActionChat()
	{
		return "聊天";
	}

	protected override string _GetTemplateForActionJoinGame()
	{
		return "加入遊戲";
	}

	protected override string _GetTemplateForActionRequestSent()
	{
		return "已傳送邀請";
	}

	/// <summary>
	/// Key: "Heading.PlayerResultsFor"
	/// English String: "Player Results for {startSpan}{keyword}{endSpan}"
	/// </summary>
	public override string HeadingPlayerResultsFor(string startSpan, string keyword, string endSpan)
	{
		return $"搜尋玩家 {startSpan}{keyword}{endSpan} 的結果";
	}

	protected override string _GetTemplateForHeadingPlayerResultsFor()
	{
		return "搜尋玩家 {startSpan}{keyword}{endSpan} 的結果";
	}

	protected override string _GetTemplateForLabelAlsoKnownAsAbbreviation()
	{
		return "又稱";
	}

	/// <summary>
	/// Key: "Label.EnterMinCharacters"
	/// English String: "Please enter at least {keywordMinLength} characters."
	/// </summary>
	public override string LabelEnterMinCharacters(string keywordMinLength)
	{
		return $"請輸入 {keywordMinLength} 個字元以上。";
	}

	protected override string _GetTemplateForLabelEnterMinCharacters()
	{
		return "請輸入 {keywordMinLength} 個字元以上。";
	}

	/// <summary>
	/// Key: "Label.NoMatchesAvailable"
	/// English String: "There are no matches available for \"{keyword}\""
	/// </summary>
	public override string LabelNoMatchesAvailable(string keyword)
	{
		return $"無「{keyword}」的相符結果";
	}

	protected override string _GetTemplateForLabelNoMatchesAvailable()
	{
		return "無「{keyword}」的相符結果";
	}

	protected override string _GetTemplateForLabelOffline()
	{
		return "離線";
	}

	protected override string _GetTemplateForLabelOnline()
	{
		return "在線";
	}

	protected override string _GetTemplateForLabelSearch()
	{
		return "搜尋";
	}

	/// <summary>
	/// Key: "Label.ShowingCountOfResults"
	/// English String: "{countStartSpan}{resultsStart} - {resultsInPage} of {countEndSpan}{totalStartSpan}{totalResults}{totalEndSpan}"
	/// </summary>
	public override string LabelShowingCountOfResults(string countStartSpan, string resultsStart, string resultsInPage, string countEndSpan, string totalStartSpan, string totalResults, string totalEndSpan)
	{
		return $"{countStartSpan}{resultsStart} - {resultsInPage} of {countEndSpan}{totalStartSpan}{totalResults}{totalEndSpan}";
	}

	protected override string _GetTemplateForLabelShowingCountOfResults()
	{
		return "{countStartSpan}{resultsStart} - {resultsInPage} of {countEndSpan}{totalStartSpan}{totalResults}{totalEndSpan}";
	}

	protected override string _GetTemplateForLabelThisIsYou()
	{
		return "這是您";
	}

	protected override string _GetTemplateForLabelUnsafeInput()
	{
		return "您輸入的內容不安全，請重新搜尋。";
	}

	protected override string _GetTemplateForLabelYouAreFollowing()
	{
		return "您在追蹤";
	}

	protected override string _GetTemplateForLabelYouAreFriends()
	{
		return "你們是好友";
	}
}
