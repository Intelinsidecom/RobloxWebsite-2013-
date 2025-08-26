namespace Roblox.Platform.TranslationResources.Feature {
    /// <summary>

/// This class overrides PlayerSearchResultsResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class PlayerSearchResultsResources_ko_kr : PlayerSearchResultsResources_en_us, IPlayerSearchResultsResources, ITranslationResources
{
	/// <summary>
	/// Key: "Action.AcceptRequest"
	/// English String: "Accept Request"
	/// </summary>
	public override string ActionAcceptRequest => "ìš”ì²­ ìˆ˜ë½";

	/// <summary>
	/// Key: "Action.AddFriend"
	/// English String: "Add Friend"
	/// </summary>
	public override string ActionAddFriend => "ì¹œêµ¬ ì¶”ê°€";

	/// <summary>
	/// Key: "Action.Chat"
	/// English String: "Chat"
	/// </summary>
	public override string ActionChat => "ì±„íŒ…";

	/// <summary>
	/// Key: "Action.JoinGame"
	/// English String: "Join Game"
	/// </summary>
	public override string ActionJoinGame => "ê²Œìž„ ì°¸ê°€";

	/// <summary>
	/// Key: "Action.RequestSent"
	/// English String: "Request Sent"
	/// </summary>
	public override string ActionRequestSent => "ìš”ì²­ ì „ì†¡";

	/// <summary>
	/// Key: "Label.AlsoKnownAsAbbreviation"
	/// English String: "aka."
	/// </summary>
	public override string LabelAlsoKnownAsAbbreviation => "ì¼ëª….";

	/// <summary>
	/// Key: "Label.Offline"
	/// English String: "Offline"
	/// </summary>
	public override string LabelOffline => "ì˜¤í”„ë¼ì¸";

	/// <summary>
	/// Key: "Label.Online"
	/// English String: "Online"
	/// </summary>
	public override string LabelOnline => "ì˜¨ë¼ì¸";

	/// <summary>
	/// Key: "Label.Search"
	/// English String: "Search"
	/// </summary>
	public override string LabelSearch => "ê²€ìƒ‰";

	/// <summary>
	/// Key: "Label.ThisIsYou"
	/// English String: "This is you"
	/// </summary>
	public override string LabelThisIsYou => "íšŒì›ë‹˜ì´ë„¤ìš”";

	/// <summary>
	/// Key: "Label.UnsafeInput"
	/// English String: "You have entered unsafe input. Please try your search again."
	/// </summary>
	public override string LabelUnsafeInput => "ê±´ì „í•˜ì§€ ëª»í•œ ë‚´ìš©ì„ ìž…ë ¥í–ˆìŠµë‹ˆë‹¤. ë‹¤ì‹œ ê²€ìƒ‰í•˜ì„¸ìš”. ";

	/// <summary>
	/// Key: "Label.YouAreFollowing"
	/// English String: "You are following"
	/// </summary>
	public override string LabelYouAreFollowing => "íŒ”ë¡œìš° ì¤‘ì´ì—ìš”";

	/// <summary>
	/// Key: "Label.YouAreFriends"
	/// English String: "You are friends"
	/// </summary>
	public override string LabelYouAreFriends => "ì—¬ëŸ¬ë¶„ì€ ì¹œêµ¬ì˜ˆìš”";

	public PlayerSearchResultsResources_ko_kr(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionAcceptRequest()
	{
		return "ìš”ì²­ ìˆ˜ë½";
	}

	protected override string _GetTemplateForActionAddFriend()
	{
		return "ì¹œêµ¬ ì¶”ê°€";
	}

	protected override string _GetTemplateForActionChat()
	{
		return "ì±„íŒ…";
	}

	protected override string _GetTemplateForActionJoinGame()
	{
		return "ê²Œìž„ ì°¸ê°€";
	}

	protected override string _GetTemplateForActionRequestSent()
	{
		return "ìš”ì²­ ì „ì†¡";
	}

	/// <summary>
	/// Key: "Heading.PlayerResultsFor"
	/// English String: "Player Results for {startSpan}{keyword}{endSpan}"
	/// </summary>
	public override string HeadingPlayerResultsFor(string startSpan, string keyword, string endSpan)
	{
		return $"ë‹¤ìŒ í”Œë ˆì´ì–´ ê²€ìƒ‰ ê²°ê³¼: {startSpan}{keyword}{endSpan}";
	}

	protected override string _GetTemplateForHeadingPlayerResultsFor()
	{
		return "ë‹¤ìŒ í”Œë ˆì´ì–´ ê²€ìƒ‰ ê²°ê³¼: {startSpan}{keyword}{endSpan}";
	}

	protected override string _GetTemplateForLabelAlsoKnownAsAbbreviation()
	{
		return "ì¼ëª….";
	}

	/// <summary>
	/// Key: "Label.EnterMinCharacters"
	/// English String: "Please enter at least {keywordMinLength} characters."
	/// </summary>
	public override string LabelEnterMinCharacters(string keywordMinLength)
	{
		return $"{keywordMinLength}ìž ì´ìƒ ìž…ë ¥í•˜ì„¸ìš”.";
	}

	protected override string _GetTemplateForLabelEnterMinCharacters()
	{
		return "{keywordMinLength}ìž ì´ìƒ ìž…ë ¥í•˜ì„¸ìš”.";
	}

	/// <summary>
	/// Key: "Label.NoMatchesAvailable"
	/// English String: "There are no matches available for \"{keyword}\""
	/// </summary>
	public override string LabelNoMatchesAvailable(string keyword)
	{
		return $"'{keyword}'ê³¼(ì™€) ì¼ì¹˜í•˜ëŠ” í•­ëª©ì´ ì—†ì–´ìš”";
	}

	protected override string _GetTemplateForLabelNoMatchesAvailable()
	{
		return "'{keyword}'ê³¼(ì™€) ì¼ì¹˜í•˜ëŠ” í•­ëª©ì´ ì—†ì–´ìš”";
	}

	protected override string _GetTemplateForLabelOffline()
	{
		return "ì˜¤í”„ë¼ì¸";
	}

	protected override string _GetTemplateForLabelOnline()
	{
		return "ì˜¨ë¼ì¸";
	}

	protected override string _GetTemplateForLabelSearch()
	{
		return "ê²€ìƒ‰";
	}

	/// <summary>
	/// Key: "Label.ShowingCountOfResults"
	/// English String: "{countStartSpan}{resultsStart} - {resultsInPage} of {countEndSpan}{totalStartSpan}{totalResults}{totalEndSpan}"
	/// </summary>
	public override string LabelShowingCountOfResults(string countStartSpan, string resultsStart, string resultsInPage, string countEndSpan, string totalStartSpan, string totalResults, string totalEndSpan)
	{
		return $"{countStartSpan}{resultsStart} - {resultsInPage} / {countEndSpan}{totalStartSpan}{totalResults}{totalEndSpan}";
	}

	protected override string _GetTemplateForLabelShowingCountOfResults()
	{
		return "{countStartSpan}{resultsStart} - {resultsInPage} / {countEndSpan}{totalStartSpan}{totalResults}{totalEndSpan}";
	}

	protected override string _GetTemplateForLabelThisIsYou()
	{
		return "íšŒì›ë‹˜ì´ë„¤ìš”";
	}

	protected override string _GetTemplateForLabelUnsafeInput()
	{
		return "ê±´ì „í•˜ì§€ ëª»í•œ ë‚´ìš©ì„ ìž…ë ¥í–ˆìŠµë‹ˆë‹¤. ë‹¤ì‹œ ê²€ìƒ‰í•˜ì„¸ìš”. ";
	}

	protected override string _GetTemplateForLabelYouAreFollowing()
	{
		return "íŒ”ë¡œìš° ì¤‘ì´ì—ìš”";
	}

	protected override string _GetTemplateForLabelYouAreFriends()
	{
		return "ì—¬ëŸ¬ë¶„ì€ ì¹œêµ¬ì˜ˆìš”";
	}
}


}
