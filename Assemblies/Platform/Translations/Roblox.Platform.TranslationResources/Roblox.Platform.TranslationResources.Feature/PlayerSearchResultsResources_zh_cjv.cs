namespace Roblox.Platform.TranslationResources.Feature {
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
	public override string ActionAcceptRequest => "æŽ¥å—é‚€è¯·";

	/// <summary>
	/// Key: "Action.AddFriend"
	/// English String: "Add Friend"
	/// </summary>
	public override string ActionAddFriend => "æ·»åŠ å¥½å‹";

	/// <summary>
	/// Key: "Action.Chat"
	/// English String: "Chat"
	/// </summary>
	public override string ActionChat => "èŠå¤©";

	/// <summary>
	/// Key: "Action.JoinGame"
	/// English String: "Join Game"
	/// </summary>
	public override string ActionJoinGame => "åŠ å…¥æ¸¸æˆ";

	/// <summary>
	/// Key: "Action.RequestSent"
	/// English String: "Request Sent"
	/// </summary>
	public override string ActionRequestSent => "é‚€è¯·å·²å‘é€";

	/// <summary>
	/// Key: "Label.AlsoKnownAsAbbreviation"
	/// English String: "aka."
	/// </summary>
	public override string LabelAlsoKnownAsAbbreviation => "åˆå";

	/// <summary>
	/// Key: "Label.Offline"
	/// English String: "Offline"
	/// </summary>
	public override string LabelOffline => "ç¦»çº¿";

	/// <summary>
	/// Key: "Label.Online"
	/// English String: "Online"
	/// </summary>
	public override string LabelOnline => "åœ¨çº¿";

	/// <summary>
	/// Key: "Label.Search"
	/// English String: "Search"
	/// </summary>
	public override string LabelSearch => "æœç´¢";

	/// <summary>
	/// Key: "Label.ThisIsYou"
	/// English String: "This is you"
	/// </summary>
	public override string LabelThisIsYou => "è¿™æ˜¯ä½ ";

	/// <summary>
	/// Key: "Label.UnsafeInput"
	/// English String: "You have entered unsafe input. Please try your search again."
	/// </summary>
	public override string LabelUnsafeInput => "ä½ è¾“å…¥çš„å†…å®¹ä¸å®‰å…¨ã€‚è¯·é‡æ–°æœç´¢ã€‚";

	/// <summary>
	/// Key: "Label.YouAreFollowing"
	/// English String: "You are following"
	/// </summary>
	public override string LabelYouAreFollowing => "ä½ æ­£å…³æ³¨";

	/// <summary>
	/// Key: "Label.YouAreFriends"
	/// English String: "You are friends"
	/// </summary>
	public override string LabelYouAreFriends => "ä½ ä»¬æ˜¯å¥½å‹";

	public PlayerSearchResultsResources_zh_cjv(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionAcceptRequest()
	{
		return "æŽ¥å—é‚€è¯·";
	}

	protected override string _GetTemplateForActionAddFriend()
	{
		return "æ·»åŠ å¥½å‹";
	}

	protected override string _GetTemplateForActionChat()
	{
		return "èŠå¤©";
	}

	protected override string _GetTemplateForActionJoinGame()
	{
		return "åŠ å…¥æ¸¸æˆ";
	}

	protected override string _GetTemplateForActionRequestSent()
	{
		return "é‚€è¯·å·²å‘é€";
	}

	/// <summary>
	/// Key: "Heading.PlayerResultsFor"
	/// English String: "Player Results for {startSpan}{keyword}{endSpan}"
	/// </summary>
	public override string HeadingPlayerResultsFor(string startSpan, string keyword, string endSpan)
	{
		return $"æœç´¢çŽ©å®¶{startSpan}â€œ{keyword}â€{endSpan}çš„ç»“æžœ";
	}

	protected override string _GetTemplateForHeadingPlayerResultsFor()
	{
		return "æœç´¢çŽ©å®¶{startSpan}â€œ{keyword}â€{endSpan}çš„ç»“æžœ";
	}

	protected override string _GetTemplateForLabelAlsoKnownAsAbbreviation()
	{
		return "åˆå";
	}

	/// <summary>
	/// Key: "Label.EnterMinCharacters"
	/// English String: "Please enter at least {keywordMinLength} characters."
	/// </summary>
	public override string LabelEnterMinCharacters(string keywordMinLength)
	{
		return $"è¯·è¾“å…¥è‡³å°‘ {keywordMinLength} ä¸ªå­—ç¬¦ã€‚";
	}

	protected override string _GetTemplateForLabelEnterMinCharacters()
	{
		return "è¯·è¾“å…¥è‡³å°‘ {keywordMinLength} ä¸ªå­—ç¬¦ã€‚";
	}

	/// <summary>
	/// Key: "Label.NoMatchesAvailable"
	/// English String: "There are no matches available for \"{keyword}\""
	/// </summary>
	public override string LabelNoMatchesAvailable(string keyword)
	{
		return $"æ²¡æœ‰ä¸Žâ€œ{keyword}â€åŒ¹é…çš„é¡¹ç›®";
	}

	protected override string _GetTemplateForLabelNoMatchesAvailable()
	{
		return "æ²¡æœ‰ä¸Žâ€œ{keyword}â€åŒ¹é…çš„é¡¹ç›®";
	}

	protected override string _GetTemplateForLabelOffline()
	{
		return "ç¦»çº¿";
	}

	protected override string _GetTemplateForLabelOnline()
	{
		return "åœ¨çº¿";
	}

	protected override string _GetTemplateForLabelSearch()
	{
		return "æœç´¢";
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
		return "è¿™æ˜¯ä½ ";
	}

	protected override string _GetTemplateForLabelUnsafeInput()
	{
		return "ä½ è¾“å…¥çš„å†…å®¹ä¸å®‰å…¨ã€‚è¯·é‡æ–°æœç´¢ã€‚";
	}

	protected override string _GetTemplateForLabelYouAreFollowing()
	{
		return "ä½ æ­£å…³æ³¨";
	}

	protected override string _GetTemplateForLabelYouAreFriends()
	{
		return "ä½ ä»¬æ˜¯å¥½å‹";
	}
}


}
