namespace Roblox.Platform.TranslationResources.Feature {
    /// <summary>

/// This class overrides CommentsResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class CommentsResources_ja_jp : CommentsResources_en_us, ICommentsResources, ITranslationResources
{
	/// <summary>
	/// Key: "Action.Login"
	/// button text
	/// English String: "Login"
	/// </summary>
	public override string ActionLogin => "ãƒ­ã‚°ã‚¤ãƒ³";

	/// <summary>
	/// Key: "Heading.Comments"
	/// English String: "Comments"
	/// </summary>
	public override string HeadingComments => "ã‚³ãƒ¡ãƒ³ãƒˆ";

	/// <summary>
	/// Key: "Heading.LoginToComment"
	/// modal heading
	/// English String: "Login to Comment"
	/// </summary>
	public override string HeadingLoginToComment => "ãƒ­ã‚°ã‚¤ãƒ³ã—ã¦ã‚³ãƒ¡ãƒ³ãƒˆã™ã‚‹";

	/// <summary>
	/// Key: "Label.AccountPageTitle"
	/// English String: "Account"
	/// </summary>
	public override string LabelAccountPageTitle => "ã‚¢ã‚«ã‚¦ãƒ³ãƒˆ";

	/// <summary>
	/// Key: "Label.Cancel"
	/// English String: "Cancel"
	/// </summary>
	public override string LabelCancel => "ã‚­ãƒ£ãƒ³ã‚»ãƒ«";

	/// <summary>
	/// Key: "Label.CharactersRemaining"
	/// English String: "characters remaining"
	/// </summary>
	public override string LabelCharactersRemaining => "æ–‡å­—æ®‹ã£ã¦ã„ã¾ã™";

	/// <summary>
	/// Key: "Label.CommentModerated"
	/// Feedback for user when their comment has been moderated
	/// English String: "Your comment has been moderated."
	/// </summary>
	public override string LabelCommentModerated => "è¦åˆ¶å¯¾è±¡ã®ã‚³ãƒ¡ãƒ³ãƒˆã§ã™ã€‚";

	/// <summary>
	/// Key: "Label.EmailVerifiedTitle"
	/// English String: "Verify Your Email"
	/// </summary>
	public override string LabelEmailVerifiedTitle => "ãƒ¡ãƒ¼ãƒ«ã‚¢ãƒ‰ãƒ¬ã‚¹ã‚’èªè¨¼";

	/// <summary>
	/// Key: "Label.FeatureNotAvailable"
	/// English String: "This feature is not available."
	/// </summary>
	public override string LabelFeatureNotAvailable => "ã“ã®æ©Ÿèƒ½ã¯ã”åˆ©ç”¨ã„ãŸã ã‘ã¾ã›ã‚“ã€‚";

	/// <summary>
	/// Key: "Label.LinksNotAllowedMessage"
	/// English String: "Comments should be about the item or place on which you are commenting. Links are not permitted."
	/// </summary>
	public override string LabelLinksNotAllowedMessage => "ã‚³ãƒ¡ãƒ³ãƒˆã¯ã‚¢ã‚¤ãƒ†ãƒ ã‚„ãƒ—ãƒ¬ãƒ¼ã‚¹ã«é–¢ã™ã‚‹ã‚‚ã®ã§ã‚ã‚‹å¿…è¦ãŒã‚ã‚Šã¾ã™ã€‚ãƒªãƒ³ã‚¯ã¯è¨±å¯ã•ã‚Œã¦ã„ã¾ã›ã‚“ã€‚";

	/// <summary>
	/// Key: "Label.LinksNotAllowedTitle"
	/// English String: "Links Not Allowed"
	/// </summary>
	public override string LabelLinksNotAllowedTitle => "ãƒªãƒ³ã‚¯ãŒè¨±å¯ã•ã‚Œã¦ã„ã¾ã›ã‚“";

	/// <summary>
	/// Key: "Label.MoreComments"
	/// English String: "More Comments"
	/// </summary>
	public override string LabelMoreComments => "ä»–ã®ã‚³ãƒ¡ãƒ³ãƒˆ";

	/// <summary>
	/// Key: "Label.NoCommentsFound"
	/// English String: "No comments found."
	/// </summary>
	public override string LabelNoCommentsFound => "ã‚³ãƒ¡ãƒ³ãƒˆãŒè¦‹ã¤ã‹ã‚Šã¾ã›ã‚“ã€‚";

	/// <summary>
	/// Key: "Label.PostComment"
	/// English String: "Post Comment"
	/// </summary>
	public override string LabelPostComment => "ã‚³ãƒ¡ãƒ³ãƒˆã‚’æŠ•ç¨¿";

	/// <summary>
	/// Key: "Label.ReportAbuse"
	/// English String: "Report Abuse"
	/// </summary>
	public override string LabelReportAbuse => "è¦ç´„é•åã‚’å ±å‘Š";

	/// <summary>
	/// Key: "Label.SeeMore"
	/// English String: "See More"
	/// </summary>
	public override string LabelSeeMore => "ã‚‚ã£ã¨è¦‹ã‚‹";

	/// <summary>
	/// Key: "Label.SorryWrong"
	/// English String: "Sorry, something went wrong."
	/// </summary>
	public override string LabelSorryWrong => "ç”³ã—è¨³ã‚ã‚Šã¾ã›ã‚“ã€‚å•é¡ŒãŒç™ºç”Ÿã—ã¾ã—ãŸã€‚";

	/// <summary>
	/// Key: "Label.Text"
	/// English String: "text"
	/// </summary>
	public override string LabelText => "ãƒ†ã‚­ã‚¹ãƒˆ";

	/// <summary>
	/// Key: "Label.TooManyChracters"
	/// English String: "Too many characters!"
	/// </summary>
	public override string LabelTooManyChracters => "æ–‡å­—æ•°ãŒå¤šã™ãŽã¾ã™ï¼";

	/// <summary>
	/// Key: "Label.TooManyNewLines"
	/// English String: "Too many newlines!"
	/// </summary>
	public override string LabelTooManyNewLines => "æ–°ã—ã„è¡ŒãŒå¤šã™ãŽã¾ã™ï¼";

	/// <summary>
	/// Key: "Label.UnknownError"
	/// English String: "Unknown error occurred."
	/// </summary>
	public override string LabelUnknownError => "ä¸æ˜Žãªã‚¨ãƒ©ãƒ¼ãŒç™ºç”Ÿã—ã¾ã—ãŸã€‚";

	/// <summary>
	/// Key: "Label.UserFlooded"
	/// Feedback for users when they are flooded (both globally and per specific item) when posting comments for an item
	/// English String: "You are posting comments too fast. Wait a while before your next comment."
	/// </summary>
	public override string LabelUserFlooded => "ã‚³ãƒ¡ãƒ³ãƒˆæŠ•ç¨¿ã®é–“éš”ãŒçŸ­ã‹ã™ãŽã¾ã™ã€‚ã—ã°ã‚‰ãã—ã¦ã‹ã‚‰æŠ•ç¨¿ã—ã¦ãã ã•ã„ã€‚";

	/// <summary>
	/// Key: "Label.Username"
	/// English String: "username"
	/// </summary>
	public override string LabelUsername => "ãƒ¦ãƒ¼ã‚¶ãƒ¼ãƒãƒ¼ãƒ ";

	/// <summary>
	/// Key: "Label.UserTooNew"
	/// Feedback for user when they try to post a comments for an item with a newly registered account
	/// English String: "Accounts must be older than 1 day to post comments."
	/// </summary>
	public override string LabelUserTooNew => "ã‚³ãƒ¡ãƒ³ãƒˆã‚’æŠ•ç¨¿ã™ã‚‹ã«ã¯ã€1æ—¥ä»¥ä¸ŠçµŒéŽã—ãŸã‚¢ã‚«ã‚¦ãƒ³ãƒˆã§ã‚ã‚‹å¿…è¦ãŒã‚ã‚Šã¾ã™ã€‚";

	/// <summary>
	/// Key: "Label.Verify"
	/// English String: "Verify"
	/// </summary>
	public override string LabelVerify => "èªè¨¼";

	/// <summary>
	/// Key: "Label.WriteAComment"
	/// English String: "Write a comment!"
	/// </summary>
	public override string LabelWriteAComment => "ã‚³ãƒ¡ãƒ³ãƒˆã‚’æ›¸ãã¾ã—ã‚‡ã†ï¼";

	public CommentsResources_ja_jp(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionLogin()
	{
		return "ãƒ­ã‚°ã‚¤ãƒ³";
	}

	/// <summary>
	/// Key: "Description.LoginToComment"
	/// modal body text
	/// English String: "You must login to comment. Please {linkStart}login or register{linkEnd} to continue."
	/// </summary>
	public override string DescriptionLoginToComment(string linkStart, string linkEnd)
	{
		return $"ã‚³ãƒ¡ãƒ³ãƒˆã™ã‚‹ã«ã¯ãƒ­ã‚°ã‚¤ãƒ³ã™ã‚‹å¿…è¦ãŒã‚ã‚Šã¾ã™ã€‚ {linkStart}ãƒ­ã‚°ã‚¤ãƒ³ã¾ãŸã¯æ–°è¦ç™»éŒ²{linkEnd} ã—ã¦ãã ã•ã„ã€‚";
	}

	protected override string _GetTemplateForDescriptionLoginToComment()
	{
		return "ã‚³ãƒ¡ãƒ³ãƒˆã™ã‚‹ã«ã¯ãƒ­ã‚°ã‚¤ãƒ³ã™ã‚‹å¿…è¦ãŒã‚ã‚Šã¾ã™ã€‚ {linkStart}ãƒ­ã‚°ã‚¤ãƒ³ã¾ãŸã¯æ–°è¦ç™»éŒ²{linkEnd} ã—ã¦ãã ã•ã„ã€‚";
	}

	protected override string _GetTemplateForHeadingComments()
	{
		return "ã‚³ãƒ¡ãƒ³ãƒˆ";
	}

	protected override string _GetTemplateForHeadingLoginToComment()
	{
		return "ãƒ­ã‚°ã‚¤ãƒ³ã—ã¦ã‚³ãƒ¡ãƒ³ãƒˆã™ã‚‹";
	}

	protected override string _GetTemplateForLabelAccountPageTitle()
	{
		return "ã‚¢ã‚«ã‚¦ãƒ³ãƒˆ";
	}

	protected override string _GetTemplateForLabelCancel()
	{
		return "ã‚­ãƒ£ãƒ³ã‚»ãƒ«";
	}

	protected override string _GetTemplateForLabelCharactersRemaining()
	{
		return "æ–‡å­—æ®‹ã£ã¦ã„ã¾ã™";
	}

	protected override string _GetTemplateForLabelCommentModerated()
	{
		return "è¦åˆ¶å¯¾è±¡ã®ã‚³ãƒ¡ãƒ³ãƒˆã§ã™ã€‚";
	}

	/// <summary>
	/// Key: "Label.EmailVerifiedMessage"
	/// English String: "You must verify your email before you can comment. You can verify your email on the {accountPageLink} page."
	/// </summary>
	public override string LabelEmailVerifiedMessage(string accountPageLink)
	{
		return $"ã‚³ãƒ¡ãƒ³ãƒˆã‚’è¡Œã†å‰ã«ãƒ¡ãƒ¼ãƒ«ã‚¢ãƒ‰ãƒ¬ã‚¹ã®èªè¨¼ã‚’è¡Œã†å¿…è¦ãŒã‚ã‚Šã¾ã™ã€‚ãƒ¡ãƒ¼ãƒ«ã‚¢ãƒ‰ãƒ¬ã‚¹ã®èªè¨¼ã¯ã€{accountPageLink} ãƒšãƒ¼ã‚¸ã§è¡Œãˆã¾ã™ã€‚";
	}

	protected override string _GetTemplateForLabelEmailVerifiedMessage()
	{
		return "ã‚³ãƒ¡ãƒ³ãƒˆã‚’è¡Œã†å‰ã«ãƒ¡ãƒ¼ãƒ«ã‚¢ãƒ‰ãƒ¬ã‚¹ã®èªè¨¼ã‚’è¡Œã†å¿…è¦ãŒã‚ã‚Šã¾ã™ã€‚ãƒ¡ãƒ¼ãƒ«ã‚¢ãƒ‰ãƒ¬ã‚¹ã®èªè¨¼ã¯ã€{accountPageLink} ãƒšãƒ¼ã‚¸ã§è¡Œãˆã¾ã™ã€‚";
	}

	protected override string _GetTemplateForLabelEmailVerifiedTitle()
	{
		return "ãƒ¡ãƒ¼ãƒ«ã‚¢ãƒ‰ãƒ¬ã‚¹ã‚’èªè¨¼";
	}

	protected override string _GetTemplateForLabelFeatureNotAvailable()
	{
		return "ã“ã®æ©Ÿèƒ½ã¯ã”åˆ©ç”¨ã„ãŸã ã‘ã¾ã›ã‚“ã€‚";
	}

	protected override string _GetTemplateForLabelLinksNotAllowedMessage()
	{
		return "ã‚³ãƒ¡ãƒ³ãƒˆã¯ã‚¢ã‚¤ãƒ†ãƒ ã‚„ãƒ—ãƒ¬ãƒ¼ã‚¹ã«é–¢ã™ã‚‹ã‚‚ã®ã§ã‚ã‚‹å¿…è¦ãŒã‚ã‚Šã¾ã™ã€‚ãƒªãƒ³ã‚¯ã¯è¨±å¯ã•ã‚Œã¦ã„ã¾ã›ã‚“ã€‚";
	}

	protected override string _GetTemplateForLabelLinksNotAllowedTitle()
	{
		return "ãƒªãƒ³ã‚¯ãŒè¨±å¯ã•ã‚Œã¦ã„ã¾ã›ã‚“";
	}

	protected override string _GetTemplateForLabelMoreComments()
	{
		return "ä»–ã®ã‚³ãƒ¡ãƒ³ãƒˆ";
	}

	protected override string _GetTemplateForLabelNoCommentsFound()
	{
		return "ã‚³ãƒ¡ãƒ³ãƒˆãŒè¦‹ã¤ã‹ã‚Šã¾ã›ã‚“ã€‚";
	}

	protected override string _GetTemplateForLabelPostComment()
	{
		return "ã‚³ãƒ¡ãƒ³ãƒˆã‚’æŠ•ç¨¿";
	}

	protected override string _GetTemplateForLabelReportAbuse()
	{
		return "è¦ç´„é•åã‚’å ±å‘Š";
	}

	protected override string _GetTemplateForLabelSeeMore()
	{
		return "ã‚‚ã£ã¨è¦‹ã‚‹";
	}

	protected override string _GetTemplateForLabelSorryWrong()
	{
		return "ç”³ã—è¨³ã‚ã‚Šã¾ã›ã‚“ã€‚å•é¡ŒãŒç™ºç”Ÿã—ã¾ã—ãŸã€‚";
	}

	protected override string _GetTemplateForLabelText()
	{
		return "ãƒ†ã‚­ã‚¹ãƒˆ";
	}

	protected override string _GetTemplateForLabelTooManyChracters()
	{
		return "æ–‡å­—æ•°ãŒå¤šã™ãŽã¾ã™ï¼";
	}

	protected override string _GetTemplateForLabelTooManyNewLines()
	{
		return "æ–°ã—ã„è¡ŒãŒå¤šã™ãŽã¾ã™ï¼";
	}

	protected override string _GetTemplateForLabelUnknownError()
	{
		return "ä¸æ˜Žãªã‚¨ãƒ©ãƒ¼ãŒç™ºç”Ÿã—ã¾ã—ãŸã€‚";
	}

	protected override string _GetTemplateForLabelUserFlooded()
	{
		return "ã‚³ãƒ¡ãƒ³ãƒˆæŠ•ç¨¿ã®é–“éš”ãŒçŸ­ã‹ã™ãŽã¾ã™ã€‚ã—ã°ã‚‰ãã—ã¦ã‹ã‚‰æŠ•ç¨¿ã—ã¦ãã ã•ã„ã€‚";
	}

	protected override string _GetTemplateForLabelUsername()
	{
		return "ãƒ¦ãƒ¼ã‚¶ãƒ¼ãƒãƒ¼ãƒ ";
	}

	protected override string _GetTemplateForLabelUserTooNew()
	{
		return "ã‚³ãƒ¡ãƒ³ãƒˆã‚’æŠ•ç¨¿ã™ã‚‹ã«ã¯ã€1æ—¥ä»¥ä¸ŠçµŒéŽã—ãŸã‚¢ã‚«ã‚¦ãƒ³ãƒˆã§ã‚ã‚‹å¿…è¦ãŒã‚ã‚Šã¾ã™ã€‚";
	}

	protected override string _GetTemplateForLabelVerify()
	{
		return "èªè¨¼";
	}

	protected override string _GetTemplateForLabelWriteAComment()
	{
		return "ã‚³ãƒ¡ãƒ³ãƒˆã‚’æ›¸ãã¾ã—ã‚‡ã†ï¼";
	}

	/// <summary>
	/// Key: "Label.XHoursAgo"
	/// English String: "{numberOfHours} hours ago"
	/// </summary>
	public override string LabelXHoursAgo(string numberOfHours)
	{
		return $"{numberOfHours} æ™‚é–“å‰";
	}

	protected override string _GetTemplateForLabelXHoursAgo()
	{
		return "{numberOfHours} æ™‚é–“å‰";
	}
}


}
