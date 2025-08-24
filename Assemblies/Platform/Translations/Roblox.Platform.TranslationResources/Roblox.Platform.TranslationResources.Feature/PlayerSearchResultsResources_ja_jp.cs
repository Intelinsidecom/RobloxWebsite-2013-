namespace Roblox.TranslationResources.Feature;

/// <summary>
/// This class overrides PlayerSearchResultsResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class PlayerSearchResultsResources_ja_jp : PlayerSearchResultsResources_en_us, IPlayerSearchResultsResources, ITranslationResources
{
	/// <summary>
	/// Key: "Action.AcceptRequest"
	/// English String: "Accept Request"
	/// </summary>
	public override string ActionAcceptRequest => "リクエストを承認する";

	/// <summary>
	/// Key: "Action.AddFriend"
	/// English String: "Add Friend"
	/// </summary>
	public override string ActionAddFriend => "友達を追加";

	/// <summary>
	/// Key: "Action.Chat"
	/// English String: "Chat"
	/// </summary>
	public override string ActionChat => "チャット";

	/// <summary>
	/// Key: "Action.JoinGame"
	/// English String: "Join Game"
	/// </summary>
	public override string ActionJoinGame => "ゲームに参加";

	/// <summary>
	/// Key: "Action.RequestSent"
	/// English String: "Request Sent"
	/// </summary>
	public override string ActionRequestSent => "リクエストを送信しました";

	/// <summary>
	/// Key: "Label.AlsoKnownAsAbbreviation"
	/// English String: "aka."
	/// </summary>
	public override string LabelAlsoKnownAsAbbreviation => "別名";

	/// <summary>
	/// Key: "Label.Offline"
	/// English String: "Offline"
	/// </summary>
	public override string LabelOffline => "オフライン";

	/// <summary>
	/// Key: "Label.Online"
	/// English String: "Online"
	/// </summary>
	public override string LabelOnline => "オンライン";

	/// <summary>
	/// Key: "Label.Search"
	/// English String: "Search"
	/// </summary>
	public override string LabelSearch => "検索";

	/// <summary>
	/// Key: "Label.ThisIsYou"
	/// English String: "This is you"
	/// </summary>
	public override string LabelThisIsYou => "これがあなたです";

	/// <summary>
	/// Key: "Label.UnsafeInput"
	/// English String: "You have entered unsafe input. Please try your search again."
	/// </summary>
	public override string LabelUnsafeInput => "安全でない入力がありました。もう一度検索してください。";

	/// <summary>
	/// Key: "Label.YouAreFollowing"
	/// English String: "You are following"
	/// </summary>
	public override string LabelYouAreFollowing => "フォローしています";

	/// <summary>
	/// Key: "Label.YouAreFriends"
	/// English String: "You are friends"
	/// </summary>
	public override string LabelYouAreFriends => "友達になりました";

	public PlayerSearchResultsResources_ja_jp(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionAcceptRequest()
	{
		return "リクエストを承認する";
	}

	protected override string _GetTemplateForActionAddFriend()
	{
		return "友達を追加";
	}

	protected override string _GetTemplateForActionChat()
	{
		return "チャット";
	}

	protected override string _GetTemplateForActionJoinGame()
	{
		return "ゲームに参加";
	}

	protected override string _GetTemplateForActionRequestSent()
	{
		return "リクエストを送信しました";
	}

	/// <summary>
	/// Key: "Heading.PlayerResultsFor"
	/// English String: "Player Results for {startSpan}{keyword}{endSpan}"
	/// </summary>
	public override string HeadingPlayerResultsFor(string startSpan, string keyword, string endSpan)
	{
		return $"{startSpan}{keyword}{endSpan} のプレイヤー検索結果";
	}

	protected override string _GetTemplateForHeadingPlayerResultsFor()
	{
		return "{startSpan}{keyword}{endSpan} のプレイヤー検索結果";
	}

	protected override string _GetTemplateForLabelAlsoKnownAsAbbreviation()
	{
		return "別名";
	}

	/// <summary>
	/// Key: "Label.EnterMinCharacters"
	/// English String: "Please enter at least {keywordMinLength} characters."
	/// </summary>
	public override string LabelEnterMinCharacters(string keywordMinLength)
	{
		return $"{keywordMinLength}文字以上入力してください。";
	}

	protected override string _GetTemplateForLabelEnterMinCharacters()
	{
		return "{keywordMinLength}文字以上入力してください。";
	}

	/// <summary>
	/// Key: "Label.NoMatchesAvailable"
	/// English String: "There are no matches available for \"{keyword}\""
	/// </summary>
	public override string LabelNoMatchesAvailable(string keyword)
	{
		return $"「{keyword}」に該当するものはありません";
	}

	protected override string _GetTemplateForLabelNoMatchesAvailable()
	{
		return "「{keyword}」に該当するものはありません";
	}

	protected override string _GetTemplateForLabelOffline()
	{
		return "オフライン";
	}

	protected override string _GetTemplateForLabelOnline()
	{
		return "オンライン";
	}

	protected override string _GetTemplateForLabelSearch()
	{
		return "検索";
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
		return "これがあなたです";
	}

	protected override string _GetTemplateForLabelUnsafeInput()
	{
		return "安全でない入力がありました。もう一度検索してください。";
	}

	protected override string _GetTemplateForLabelYouAreFollowing()
	{
		return "フォローしています";
	}

	protected override string _GetTemplateForLabelYouAreFriends()
	{
		return "友達になりました";
	}
}
