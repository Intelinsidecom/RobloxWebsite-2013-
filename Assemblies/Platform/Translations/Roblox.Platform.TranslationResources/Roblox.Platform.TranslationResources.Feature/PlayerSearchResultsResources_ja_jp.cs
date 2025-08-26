namespace Roblox.Platform.TranslationResources.Feature {
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
	public override string ActionAcceptRequest => "ãƒªã‚¯ã‚¨ã‚¹ãƒˆã‚’æ‰¿èªã™ã‚‹";

	/// <summary>
	/// Key: "Action.AddFriend"
	/// English String: "Add Friend"
	/// </summary>
	public override string ActionAddFriend => "å‹é”ã‚’è¿½åŠ ";

	/// <summary>
	/// Key: "Action.Chat"
	/// English String: "Chat"
	/// </summary>
	public override string ActionChat => "ãƒãƒ£ãƒƒãƒˆ";

	/// <summary>
	/// Key: "Action.JoinGame"
	/// English String: "Join Game"
	/// </summary>
	public override string ActionJoinGame => "ã‚²ãƒ¼ãƒ ã«å‚åŠ ";

	/// <summary>
	/// Key: "Action.RequestSent"
	/// English String: "Request Sent"
	/// </summary>
	public override string ActionRequestSent => "ãƒªã‚¯ã‚¨ã‚¹ãƒˆã‚’é€ä¿¡ã—ã¾ã—ãŸ";

	/// <summary>
	/// Key: "Label.AlsoKnownAsAbbreviation"
	/// English String: "aka."
	/// </summary>
	public override string LabelAlsoKnownAsAbbreviation => "åˆ¥å";

	/// <summary>
	/// Key: "Label.Offline"
	/// English String: "Offline"
	/// </summary>
	public override string LabelOffline => "ã‚ªãƒ•ãƒ©ã‚¤ãƒ³";

	/// <summary>
	/// Key: "Label.Online"
	/// English String: "Online"
	/// </summary>
	public override string LabelOnline => "ã‚ªãƒ³ãƒ©ã‚¤ãƒ³";

	/// <summary>
	/// Key: "Label.Search"
	/// English String: "Search"
	/// </summary>
	public override string LabelSearch => "æ¤œç´¢";

	/// <summary>
	/// Key: "Label.ThisIsYou"
	/// English String: "This is you"
	/// </summary>
	public override string LabelThisIsYou => "ã“ã‚ŒãŒã‚ãªãŸã§ã™";

	/// <summary>
	/// Key: "Label.UnsafeInput"
	/// English String: "You have entered unsafe input. Please try your search again."
	/// </summary>
	public override string LabelUnsafeInput => "å®‰å…¨ã§ãªã„å…¥åŠ›ãŒã‚ã‚Šã¾ã—ãŸã€‚ã‚‚ã†ä¸€åº¦æ¤œç´¢ã—ã¦ãã ã•ã„ã€‚";

	/// <summary>
	/// Key: "Label.YouAreFollowing"
	/// English String: "You are following"
	/// </summary>
	public override string LabelYouAreFollowing => "ãƒ•ã‚©ãƒ­ãƒ¼ã—ã¦ã„ã¾ã™";

	/// <summary>
	/// Key: "Label.YouAreFriends"
	/// English String: "You are friends"
	/// </summary>
	public override string LabelYouAreFriends => "å‹é”ã«ãªã‚Šã¾ã—ãŸ";

	public PlayerSearchResultsResources_ja_jp(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionAcceptRequest()
	{
		return "ãƒªã‚¯ã‚¨ã‚¹ãƒˆã‚’æ‰¿èªã™ã‚‹";
	}

	protected override string _GetTemplateForActionAddFriend()
	{
		return "å‹é”ã‚’è¿½åŠ ";
	}

	protected override string _GetTemplateForActionChat()
	{
		return "ãƒãƒ£ãƒƒãƒˆ";
	}

	protected override string _GetTemplateForActionJoinGame()
	{
		return "ã‚²ãƒ¼ãƒ ã«å‚åŠ ";
	}

	protected override string _GetTemplateForActionRequestSent()
	{
		return "ãƒªã‚¯ã‚¨ã‚¹ãƒˆã‚’é€ä¿¡ã—ã¾ã—ãŸ";
	}

	/// <summary>
	/// Key: "Heading.PlayerResultsFor"
	/// English String: "Player Results for {startSpan}{keyword}{endSpan}"
	/// </summary>
	public override string HeadingPlayerResultsFor(string startSpan, string keyword, string endSpan)
	{
		return $"{startSpan}{keyword}{endSpan} ã®ãƒ—ãƒ¬ã‚¤ãƒ¤ãƒ¼æ¤œç´¢çµæžœ";
	}

	protected override string _GetTemplateForHeadingPlayerResultsFor()
	{
		return "{startSpan}{keyword}{endSpan} ã®ãƒ—ãƒ¬ã‚¤ãƒ¤ãƒ¼æ¤œç´¢çµæžœ";
	}

	protected override string _GetTemplateForLabelAlsoKnownAsAbbreviation()
	{
		return "åˆ¥å";
	}

	/// <summary>
	/// Key: "Label.EnterMinCharacters"
	/// English String: "Please enter at least {keywordMinLength} characters."
	/// </summary>
	public override string LabelEnterMinCharacters(string keywordMinLength)
	{
		return $"{keywordMinLength}æ–‡å­—ä»¥ä¸Šå…¥åŠ›ã—ã¦ãã ã•ã„ã€‚";
	}

	protected override string _GetTemplateForLabelEnterMinCharacters()
	{
		return "{keywordMinLength}æ–‡å­—ä»¥ä¸Šå…¥åŠ›ã—ã¦ãã ã•ã„ã€‚";
	}

	/// <summary>
	/// Key: "Label.NoMatchesAvailable"
	/// English String: "There are no matches available for \"{keyword}\""
	/// </summary>
	public override string LabelNoMatchesAvailable(string keyword)
	{
		return $"ã€Œ{keyword}ã€ã«è©²å½“ã™ã‚‹ã‚‚ã®ã¯ã‚ã‚Šã¾ã›ã‚“";
	}

	protected override string _GetTemplateForLabelNoMatchesAvailable()
	{
		return "ã€Œ{keyword}ã€ã«è©²å½“ã™ã‚‹ã‚‚ã®ã¯ã‚ã‚Šã¾ã›ã‚“";
	}

	protected override string _GetTemplateForLabelOffline()
	{
		return "ã‚ªãƒ•ãƒ©ã‚¤ãƒ³";
	}

	protected override string _GetTemplateForLabelOnline()
	{
		return "ã‚ªãƒ³ãƒ©ã‚¤ãƒ³";
	}

	protected override string _GetTemplateForLabelSearch()
	{
		return "æ¤œç´¢";
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
		return "ã“ã‚ŒãŒã‚ãªãŸã§ã™";
	}

	protected override string _GetTemplateForLabelUnsafeInput()
	{
		return "å®‰å…¨ã§ãªã„å…¥åŠ›ãŒã‚ã‚Šã¾ã—ãŸã€‚ã‚‚ã†ä¸€åº¦æ¤œç´¢ã—ã¦ãã ã•ã„ã€‚";
	}

	protected override string _GetTemplateForLabelYouAreFollowing()
	{
		return "ãƒ•ã‚©ãƒ­ãƒ¼ã—ã¦ã„ã¾ã™";
	}

	protected override string _GetTemplateForLabelYouAreFriends()
	{
		return "å‹é”ã«ãªã‚Šã¾ã—ãŸ";
	}
}


}
