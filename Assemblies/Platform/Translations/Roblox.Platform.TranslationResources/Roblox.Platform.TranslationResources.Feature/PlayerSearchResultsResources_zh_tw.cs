namespace Roblox.Platform.TranslationResources.Feature {
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
	public override string ActionAcceptRequest => "æŽ¥å—é‚€è«‹";

	/// <summary>
	/// Key: "Action.AddFriend"
	/// English String: "Add Friend"
	/// </summary>
	public override string ActionAddFriend => "æ–°å¢žå¥½å‹";

	/// <summary>
	/// Key: "Action.Chat"
	/// English String: "Chat"
	/// </summary>
	public override string ActionChat => "èŠå¤©";

	/// <summary>
	/// Key: "Action.JoinGame"
	/// English String: "Join Game"
	/// </summary>
	public override string ActionJoinGame => "åŠ å…¥éŠæˆ²";

	/// <summary>
	/// Key: "Action.RequestSent"
	/// English String: "Request Sent"
	/// </summary>
	public override string ActionRequestSent => "å·²å‚³é€é‚€è«‹";

	/// <summary>
	/// Key: "Label.AlsoKnownAsAbbreviation"
	/// English String: "aka."
	/// </summary>
	public override string LabelAlsoKnownAsAbbreviation => "åˆç¨±";

	/// <summary>
	/// Key: "Label.Offline"
	/// English String: "Offline"
	/// </summary>
	public override string LabelOffline => "é›¢ç·š";

	/// <summary>
	/// Key: "Label.Online"
	/// English String: "Online"
	/// </summary>
	public override string LabelOnline => "åœ¨ç·š";

	/// <summary>
	/// Key: "Label.Search"
	/// English String: "Search"
	/// </summary>
	public override string LabelSearch => "æœå°‹";

	/// <summary>
	/// Key: "Label.ThisIsYou"
	/// English String: "This is you"
	/// </summary>
	public override string LabelThisIsYou => "é€™æ˜¯æ‚¨";

	/// <summary>
	/// Key: "Label.UnsafeInput"
	/// English String: "You have entered unsafe input. Please try your search again."
	/// </summary>
	public override string LabelUnsafeInput => "æ‚¨è¼¸å…¥çš„å…§å®¹ä¸å®‰å…¨ï¼Œè«‹é‡æ–°æœå°‹ã€‚";

	/// <summary>
	/// Key: "Label.YouAreFollowing"
	/// English String: "You are following"
	/// </summary>
	public override string LabelYouAreFollowing => "æ‚¨åœ¨è¿½è¹¤";

	/// <summary>
	/// Key: "Label.YouAreFriends"
	/// English String: "You are friends"
	/// </summary>
	public override string LabelYouAreFriends => "ä½ å€‘æ˜¯å¥½å‹";

	public PlayerSearchResultsResources_zh_tw(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionAcceptRequest()
	{
		return "æŽ¥å—é‚€è«‹";
	}

	protected override string _GetTemplateForActionAddFriend()
	{
		return "æ–°å¢žå¥½å‹";
	}

	protected override string _GetTemplateForActionChat()
	{
		return "èŠå¤©";
	}

	protected override string _GetTemplateForActionJoinGame()
	{
		return "åŠ å…¥éŠæˆ²";
	}

	protected override string _GetTemplateForActionRequestSent()
	{
		return "å·²å‚³é€é‚€è«‹";
	}

	/// <summary>
	/// Key: "Heading.PlayerResultsFor"
	/// English String: "Player Results for {startSpan}{keyword}{endSpan}"
	/// </summary>
	public override string HeadingPlayerResultsFor(string startSpan, string keyword, string endSpan)
	{
		return $"æœå°‹çŽ©å®¶ {startSpan}{keyword}{endSpan} çš„çµæžœ";
	}

	protected override string _GetTemplateForHeadingPlayerResultsFor()
	{
		return "æœå°‹çŽ©å®¶ {startSpan}{keyword}{endSpan} çš„çµæžœ";
	}

	protected override string _GetTemplateForLabelAlsoKnownAsAbbreviation()
	{
		return "åˆç¨±";
	}

	/// <summary>
	/// Key: "Label.EnterMinCharacters"
	/// English String: "Please enter at least {keywordMinLength} characters."
	/// </summary>
	public override string LabelEnterMinCharacters(string keywordMinLength)
	{
		return $"è«‹è¼¸å…¥ {keywordMinLength} å€‹å­—å…ƒä»¥ä¸Šã€‚";
	}

	protected override string _GetTemplateForLabelEnterMinCharacters()
	{
		return "è«‹è¼¸å…¥ {keywordMinLength} å€‹å­—å…ƒä»¥ä¸Šã€‚";
	}

	/// <summary>
	/// Key: "Label.NoMatchesAvailable"
	/// English String: "There are no matches available for \"{keyword}\""
	/// </summary>
	public override string LabelNoMatchesAvailable(string keyword)
	{
		return $"ç„¡ã€Œ{keyword}ã€çš„ç›¸ç¬¦çµæžœ";
	}

	protected override string _GetTemplateForLabelNoMatchesAvailable()
	{
		return "ç„¡ã€Œ{keyword}ã€çš„ç›¸ç¬¦çµæžœ";
	}

	protected override string _GetTemplateForLabelOffline()
	{
		return "é›¢ç·š";
	}

	protected override string _GetTemplateForLabelOnline()
	{
		return "åœ¨ç·š";
	}

	protected override string _GetTemplateForLabelSearch()
	{
		return "æœå°‹";
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
		return "é€™æ˜¯æ‚¨";
	}

	protected override string _GetTemplateForLabelUnsafeInput()
	{
		return "æ‚¨è¼¸å…¥çš„å…§å®¹ä¸å®‰å…¨ï¼Œè«‹é‡æ–°æœå°‹ã€‚";
	}

	protected override string _GetTemplateForLabelYouAreFollowing()
	{
		return "æ‚¨åœ¨è¿½è¹¤";
	}

	protected override string _GetTemplateForLabelYouAreFriends()
	{
		return "ä½ å€‘æ˜¯å¥½å‹";
	}
}


}
