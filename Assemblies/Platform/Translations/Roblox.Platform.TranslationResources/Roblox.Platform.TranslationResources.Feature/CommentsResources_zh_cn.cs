namespace Roblox.Platform.TranslationResources.Feature {
    /// <summary>

/// This class overrides CommentsResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class CommentsResources_zh_cn : CommentsResources_en_us, ICommentsResources, ITranslationResources
{
	/// <summary>
	/// Key: "Action.Login"
	/// button text
	/// English String: "Login"
	/// </summary>
	public override string ActionLogin => "ç™»å½•";

	/// <summary>
	/// Key: "Heading.Comments"
	/// English String: "Comments"
	/// </summary>
	public override string HeadingComments => "è¯„è®º";

	/// <summary>
	/// Key: "Heading.LoginToComment"
	/// modal heading
	/// English String: "Login to Comment"
	/// </summary>
	public override string HeadingLoginToComment => "å‘è¡¨è¯„è®ºå‰è¯·å…ˆç™»å½•";

	/// <summary>
	/// Key: "Label.AccountPageTitle"
	/// English String: "Account"
	/// </summary>
	public override string LabelAccountPageTitle => "å¸æˆ·";

	/// <summary>
	/// Key: "Label.Cancel"
	/// English String: "Cancel"
	/// </summary>
	public override string LabelCancel => "å–æ¶ˆ";

	/// <summary>
	/// Key: "Label.CharactersRemaining"
	/// English String: "characters remaining"
	/// </summary>
	public override string LabelCharactersRemaining => "ä¸ªå‰©ä½™å­—ç¬¦";

	/// <summary>
	/// Key: "Label.CommentModerated"
	/// Feedback for user when their comment has been moderated
	/// English String: "Your comment has been moderated."
	/// </summary>
	public override string LabelCommentModerated => "ä½ çš„è¯„è®ºå·²è¢«è¿‡æ»¤ã€‚";

	/// <summary>
	/// Key: "Label.EmailVerifiedTitle"
	/// English String: "Verify Your Email"
	/// </summary>
	public override string LabelEmailVerifiedTitle => "éªŒè¯ä½ çš„ç”µå­é‚®ä»¶";

	/// <summary>
	/// Key: "Label.FeatureNotAvailable"
	/// English String: "This feature is not available."
	/// </summary>
	public override string LabelFeatureNotAvailable => "æ­¤åŠŸèƒ½ä¸å¯ç”¨ã€‚";

	/// <summary>
	/// Key: "Label.LinksNotAllowedMessage"
	/// English String: "Comments should be about the item or place on which you are commenting. Links are not permitted."
	/// </summary>
	public override string LabelLinksNotAllowedMessage => "è¯„è®ºåº”å’Œä½ æ‰€è¯„è®ºçš„ç‰©å“æˆ–åœºæ™¯ç›¸å…³ã€‚ç¦æ­¢ä½¿ç”¨é“¾æŽ¥ã€‚";

	/// <summary>
	/// Key: "Label.LinksNotAllowedTitle"
	/// English String: "Links Not Allowed"
	/// </summary>
	public override string LabelLinksNotAllowedTitle => "ä¸å…è®¸ä½¿ç”¨é“¾æŽ¥";

	/// <summary>
	/// Key: "Label.MoreComments"
	/// English String: "More Comments"
	/// </summary>
	public override string LabelMoreComments => "æ›´å¤šè¯„è®º";

	/// <summary>
	/// Key: "Label.NoCommentsFound"
	/// English String: "No comments found."
	/// </summary>
	public override string LabelNoCommentsFound => "æœªæ‰¾åˆ°è¯„è®ºã€‚";

	/// <summary>
	/// Key: "Label.PostComment"
	/// English String: "Post Comment"
	/// </summary>
	public override string LabelPostComment => "å‘å¸ƒè¯„è®º";

	/// <summary>
	/// Key: "Label.ReportAbuse"
	/// English String: "Report Abuse"
	/// </summary>
	public override string LabelReportAbuse => "æŠ¥å‘Šæ»¥ç”¨è¡Œä¸º";

	/// <summary>
	/// Key: "Label.SeeMore"
	/// English String: "See More"
	/// </summary>
	public override string LabelSeeMore => "æŸ¥çœ‹æ›´å¤š";

	/// <summary>
	/// Key: "Label.SorryWrong"
	/// English String: "Sorry, something went wrong."
	/// </summary>
	public override string LabelSorryWrong => "æŠ±æ­‰ï¼Œå‘ç”Ÿé”™è¯¯ã€‚";

	/// <summary>
	/// Key: "Label.Text"
	/// English String: "text"
	/// </summary>
	public override string LabelText => "æ–‡æœ¬";

	/// <summary>
	/// Key: "Label.TooManyChracters"
	/// English String: "Too many characters!"
	/// </summary>
	public override string LabelTooManyChracters => "å­—ç¬¦è¿‡å¤šï¼";

	/// <summary>
	/// Key: "Label.TooManyNewLines"
	/// English String: "Too many newlines!"
	/// </summary>
	public override string LabelTooManyNewLines => "æ¢è¡Œç¬¦è¿‡å¤šï¼";

	/// <summary>
	/// Key: "Label.UnknownError"
	/// English String: "Unknown error occurred."
	/// </summary>
	public override string LabelUnknownError => "å‘ç”ŸæœªçŸ¥é”™è¯¯ã€‚";

	/// <summary>
	/// Key: "Label.UserFlooded"
	/// Feedback for users when they are flooded (both globally and per specific item) when posting comments for an item
	/// English String: "You are posting comments too fast. Wait a while before your next comment."
	/// </summary>
	public override string LabelUserFlooded => "ä½ å‘å¸ƒè¯„è®ºçš„æ¬¡æ•°å¤ªé¢‘ç¹ã€‚è¯·ç¨å€™å†å‘è¡¨ä¸‹ä¸€æ¡è¯„è®ºã€‚";

	/// <summary>
	/// Key: "Label.Username"
	/// English String: "username"
	/// </summary>
	public override string LabelUsername => "ç”¨æˆ·å";

	/// <summary>
	/// Key: "Label.UserTooNew"
	/// Feedback for user when they try to post a comments for an item with a newly registered account
	/// English String: "Accounts must be older than 1 day to post comments."
	/// </summary>
	public override string LabelUserTooNew => "å»ºç«‹å¸æˆ·åŽéœ€ç­‰å¾… 1 å¤©æ‰èƒ½å‘è¡¨è¯„è®ºã€‚";

	/// <summary>
	/// Key: "Label.Verify"
	/// English String: "Verify"
	/// </summary>
	public override string LabelVerify => "éªŒè¯";

	/// <summary>
	/// Key: "Label.WriteAComment"
	/// English String: "Write a comment!"
	/// </summary>
	public override string LabelWriteAComment => "å†™ä¸‹è¯„è®ºï¼";

	public CommentsResources_zh_cn(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionLogin()
	{
		return "ç™»å½•";
	}

	/// <summary>
	/// Key: "Description.LoginToComment"
	/// modal body text
	/// English String: "You must login to comment. Please {linkStart}login or register{linkEnd} to continue."
	/// </summary>
	public override string DescriptionLoginToComment(string linkStart, string linkEnd)
	{
		return $"ä½ å¿…é¡»å…ˆç™»å½•æ‰èƒ½å‘è¡¨è¯„è®ºã€‚è¯·{linkStart}ç™»å½•æˆ–æ³¨å†Œ{linkEnd}ä»¥ç»§ç»­ã€‚";
	}

	protected override string _GetTemplateForDescriptionLoginToComment()
	{
		return "ä½ å¿…é¡»å…ˆç™»å½•æ‰èƒ½å‘è¡¨è¯„è®ºã€‚è¯·{linkStart}ç™»å½•æˆ–æ³¨å†Œ{linkEnd}ä»¥ç»§ç»­ã€‚";
	}

	protected override string _GetTemplateForHeadingComments()
	{
		return "è¯„è®º";
	}

	protected override string _GetTemplateForHeadingLoginToComment()
	{
		return "å‘è¡¨è¯„è®ºå‰è¯·å…ˆç™»å½•";
	}

	protected override string _GetTemplateForLabelAccountPageTitle()
	{
		return "å¸æˆ·";
	}

	protected override string _GetTemplateForLabelCancel()
	{
		return "å–æ¶ˆ";
	}

	protected override string _GetTemplateForLabelCharactersRemaining()
	{
		return "ä¸ªå‰©ä½™å­—ç¬¦";
	}

	protected override string _GetTemplateForLabelCommentModerated()
	{
		return "ä½ çš„è¯„è®ºå·²è¢«è¿‡æ»¤ã€‚";
	}

	/// <summary>
	/// Key: "Label.EmailVerifiedMessage"
	/// English String: "You must verify your email before you can comment. You can verify your email on the {accountPageLink} page."
	/// </summary>
	public override string LabelEmailVerifiedMessage(string accountPageLink)
	{
		return $"ä½ å¿…é¡»éªŒè¯ç”µå­é‚®ä»¶ï¼Œç„¶åŽæ‰èƒ½è¯„è®ºã€‚ä½ å¯ä»¥åœ¨ {accountPageLink} é¡µé¢éªŒè¯ä½ çš„ç”µå­é‚®ä»¶ã€‚";
	}

	protected override string _GetTemplateForLabelEmailVerifiedMessage()
	{
		return "ä½ å¿…é¡»éªŒè¯ç”µå­é‚®ä»¶ï¼Œç„¶åŽæ‰èƒ½è¯„è®ºã€‚ä½ å¯ä»¥åœ¨ {accountPageLink} é¡µé¢éªŒè¯ä½ çš„ç”µå­é‚®ä»¶ã€‚";
	}

	protected override string _GetTemplateForLabelEmailVerifiedTitle()
	{
		return "éªŒè¯ä½ çš„ç”µå­é‚®ä»¶";
	}

	protected override string _GetTemplateForLabelFeatureNotAvailable()
	{
		return "æ­¤åŠŸèƒ½ä¸å¯ç”¨ã€‚";
	}

	protected override string _GetTemplateForLabelLinksNotAllowedMessage()
	{
		return "è¯„è®ºåº”å’Œä½ æ‰€è¯„è®ºçš„ç‰©å“æˆ–åœºæ™¯ç›¸å…³ã€‚ç¦æ­¢ä½¿ç”¨é“¾æŽ¥ã€‚";
	}

	protected override string _GetTemplateForLabelLinksNotAllowedTitle()
	{
		return "ä¸å…è®¸ä½¿ç”¨é“¾æŽ¥";
	}

	protected override string _GetTemplateForLabelMoreComments()
	{
		return "æ›´å¤šè¯„è®º";
	}

	protected override string _GetTemplateForLabelNoCommentsFound()
	{
		return "æœªæ‰¾åˆ°è¯„è®ºã€‚";
	}

	protected override string _GetTemplateForLabelPostComment()
	{
		return "å‘å¸ƒè¯„è®º";
	}

	protected override string _GetTemplateForLabelReportAbuse()
	{
		return "æŠ¥å‘Šæ»¥ç”¨è¡Œä¸º";
	}

	protected override string _GetTemplateForLabelSeeMore()
	{
		return "æŸ¥çœ‹æ›´å¤š";
	}

	protected override string _GetTemplateForLabelSorryWrong()
	{
		return "æŠ±æ­‰ï¼Œå‘ç”Ÿé”™è¯¯ã€‚";
	}

	protected override string _GetTemplateForLabelText()
	{
		return "æ–‡æœ¬";
	}

	protected override string _GetTemplateForLabelTooManyChracters()
	{
		return "å­—ç¬¦è¿‡å¤šï¼";
	}

	protected override string _GetTemplateForLabelTooManyNewLines()
	{
		return "æ¢è¡Œç¬¦è¿‡å¤šï¼";
	}

	protected override string _GetTemplateForLabelUnknownError()
	{
		return "å‘ç”ŸæœªçŸ¥é”™è¯¯ã€‚";
	}

	protected override string _GetTemplateForLabelUserFlooded()
	{
		return "ä½ å‘å¸ƒè¯„è®ºçš„æ¬¡æ•°å¤ªé¢‘ç¹ã€‚è¯·ç¨å€™å†å‘è¡¨ä¸‹ä¸€æ¡è¯„è®ºã€‚";
	}

	protected override string _GetTemplateForLabelUsername()
	{
		return "ç”¨æˆ·å";
	}

	protected override string _GetTemplateForLabelUserTooNew()
	{
		return "å»ºç«‹å¸æˆ·åŽéœ€ç­‰å¾… 1 å¤©æ‰èƒ½å‘è¡¨è¯„è®ºã€‚";
	}

	protected override string _GetTemplateForLabelVerify()
	{
		return "éªŒè¯";
	}

	protected override string _GetTemplateForLabelWriteAComment()
	{
		return "å†™ä¸‹è¯„è®ºï¼";
	}

	/// <summary>
	/// Key: "Label.XHoursAgo"
	/// English String: "{numberOfHours} hours ago"
	/// </summary>
	public override string LabelXHoursAgo(string numberOfHours)
	{
		return $"{numberOfHours} å°æ—¶å‰";
	}

	protected override string _GetTemplateForLabelXHoursAgo()
	{
		return "{numberOfHours} å°æ—¶å‰";
	}
}


}
