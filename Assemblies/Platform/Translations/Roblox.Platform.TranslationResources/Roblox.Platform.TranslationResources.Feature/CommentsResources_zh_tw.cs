namespace Roblox.Platform.TranslationResources.Feature {
    /// <summary>

/// This class overrides CommentsResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class CommentsResources_zh_tw : CommentsResources_en_us, ICommentsResources, ITranslationResources
{
	/// <summary>
	/// Key: "Action.Login"
	/// button text
	/// English String: "Login"
	/// </summary>
	public override string ActionLogin => "ç™»å…¥";

	/// <summary>
	/// Key: "Heading.Comments"
	/// English String: "Comments"
	/// </summary>
	public override string HeadingComments => "ç•™è¨€";

	/// <summary>
	/// Key: "Heading.LoginToComment"
	/// modal heading
	/// English String: "Login to Comment"
	/// </summary>
	public override string HeadingLoginToComment => "ç•™è¨€å‰è«‹ç™»å…¥";

	/// <summary>
	/// Key: "Label.AccountPageTitle"
	/// English String: "Account"
	/// </summary>
	public override string LabelAccountPageTitle => "å¸³è™Ÿ";

	/// <summary>
	/// Key: "Label.Cancel"
	/// English String: "Cancel"
	/// </summary>
	public override string LabelCancel => "å–æ¶ˆ";

	/// <summary>
	/// Key: "Label.CharactersRemaining"
	/// English String: "characters remaining"
	/// </summary>
	public override string LabelCharactersRemaining => "å€‹å‰©é¤˜å­—å…ƒ";

	/// <summary>
	/// Key: "Label.CommentModerated"
	/// Feedback for user when their comment has been moderated
	/// English String: "Your comment has been moderated."
	/// </summary>
	public override string LabelCommentModerated => "æ‚¨çš„ç•™è¨€é­åˆ°éŽæ¿¾ã€‚";

	/// <summary>
	/// Key: "Label.EmailVerifiedTitle"
	/// English String: "Verify Your Email"
	/// </summary>
	public override string LabelEmailVerifiedTitle => "é©—è­‰æ‚¨çš„é›»å­éƒµä»¶åœ°å€";

	/// <summary>
	/// Key: "Label.FeatureNotAvailable"
	/// English String: "This feature is not available."
	/// </summary>
	public override string LabelFeatureNotAvailable => "ç„¡æ³•ä½¿ç”¨æ­¤åŠŸèƒ½ã€‚";

	/// <summary>
	/// Key: "Label.LinksNotAllowedMessage"
	/// English String: "Comments should be about the item or place on which you are commenting. Links are not permitted."
	/// </summary>
	public override string LabelLinksNotAllowedMessage => "ç•™è¨€æ‡‰å’Œç›¸å°æ‡‰çš„é“å…·æˆ–åœ°é»žç›¸é—œã€‚ç¦æ­¢è²¼ä¸Šé€£çµã€‚";

	/// <summary>
	/// Key: "Label.LinksNotAllowedTitle"
	/// English String: "Links Not Allowed"
	/// </summary>
	public override string LabelLinksNotAllowedTitle => "ç¦æ­¢è²¼ä¸Šé€£çµ";

	/// <summary>
	/// Key: "Label.MoreComments"
	/// English String: "More Comments"
	/// </summary>
	public override string LabelMoreComments => "æ›´å¤šç•™è¨€";

	/// <summary>
	/// Key: "Label.NoCommentsFound"
	/// English String: "No comments found."
	/// </summary>
	public override string LabelNoCommentsFound => "æ²’æœ‰ç•™è¨€ã€‚";

	/// <summary>
	/// Key: "Label.PostComment"
	/// English String: "Post Comment"
	/// </summary>
	public override string LabelPostComment => "ç™¼è¡¨ç•™è¨€";

	/// <summary>
	/// Key: "Label.ReportAbuse"
	/// English String: "Report Abuse"
	/// </summary>
	public override string LabelReportAbuse => "æª¢èˆ‰æ¿«ç”¨";

	/// <summary>
	/// Key: "Label.SeeMore"
	/// English String: "See More"
	/// </summary>
	public override string LabelSeeMore => "æŸ¥çœ‹æ›´å¤š";

	/// <summary>
	/// Key: "Label.SorryWrong"
	/// English String: "Sorry, something went wrong."
	/// </summary>
	public override string LabelSorryWrong => "å°ä¸èµ·ï¼Œç™¼ç”ŸéŒ¯èª¤ã€‚";

	/// <summary>
	/// Key: "Label.Text"
	/// English String: "text"
	/// </summary>
	public override string LabelText => "å…§æ–‡";

	/// <summary>
	/// Key: "Label.TooManyChracters"
	/// English String: "Too many characters!"
	/// </summary>
	public override string LabelTooManyChracters => "å­—å…ƒéŽå¤šï¼";

	/// <summary>
	/// Key: "Label.TooManyNewLines"
	/// English String: "Too many newlines!"
	/// </summary>
	public override string LabelTooManyNewLines => "è¡Œæ•¸éŽå¤šï¼";

	/// <summary>
	/// Key: "Label.UnknownError"
	/// English String: "Unknown error occurred."
	/// </summary>
	public override string LabelUnknownError => "ç™¼ç”ŸæœªçŸ¥éŒ¯èª¤ã€‚";

	/// <summary>
	/// Key: "Label.UserFlooded"
	/// Feedback for users when they are flooded (both globally and per specific item) when posting comments for an item
	/// English String: "You are posting comments too fast. Wait a while before your next comment."
	/// </summary>
	public override string LabelUserFlooded => "æ‚¨çš„ç•™è¨€é »çŽ‡éŽé«˜ï¼Œè«‹ç¨å¾Œå†è©¦ã€‚";

	/// <summary>
	/// Key: "Label.Username"
	/// English String: "username"
	/// </summary>
	public override string LabelUsername => "ä½¿ç”¨è€…åç¨±";

	/// <summary>
	/// Key: "Label.UserTooNew"
	/// Feedback for user when they try to post a comments for an item with a newly registered account
	/// English String: "Accounts must be older than 1 day to post comments."
	/// </summary>
	public override string LabelUserTooNew => "åªæœ‰å»ºç«‹æ™‚é–“è¶…éŽ 1 å¤©çš„å¸³è™Ÿå¯ä»¥ç•™è¨€ã€‚";

	/// <summary>
	/// Key: "Label.Verify"
	/// English String: "Verify"
	/// </summary>
	public override string LabelVerify => "é©—è­‰";

	/// <summary>
	/// Key: "Label.WriteAComment"
	/// English String: "Write a comment!"
	/// </summary>
	public override string LabelWriteAComment => "å¯«ä¸‹ç•™è¨€ï¼";

	public CommentsResources_zh_tw(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionLogin()
	{
		return "ç™»å…¥";
	}

	/// <summary>
	/// Key: "Description.LoginToComment"
	/// modal body text
	/// English String: "You must login to comment. Please {linkStart}login or register{linkEnd} to continue."
	/// </summary>
	public override string DescriptionLoginToComment(string linkStart, string linkEnd)
	{
		return $"æ‚¨å¿…é ˆç™»å…¥æ‰èƒ½ç•™è¨€ï¼Œè«‹å…ˆ{linkStart}ç™»å…¥æˆ–è¨»å†Š{linkEnd}ã€‚";
	}

	protected override string _GetTemplateForDescriptionLoginToComment()
	{
		return "æ‚¨å¿…é ˆç™»å…¥æ‰èƒ½ç•™è¨€ï¼Œè«‹å…ˆ{linkStart}ç™»å…¥æˆ–è¨»å†Š{linkEnd}ã€‚";
	}

	protected override string _GetTemplateForHeadingComments()
	{
		return "ç•™è¨€";
	}

	protected override string _GetTemplateForHeadingLoginToComment()
	{
		return "ç•™è¨€å‰è«‹ç™»å…¥";
	}

	protected override string _GetTemplateForLabelAccountPageTitle()
	{
		return "å¸³è™Ÿ";
	}

	protected override string _GetTemplateForLabelCancel()
	{
		return "å–æ¶ˆ";
	}

	protected override string _GetTemplateForLabelCharactersRemaining()
	{
		return "å€‹å‰©é¤˜å­—å…ƒ";
	}

	protected override string _GetTemplateForLabelCommentModerated()
	{
		return "æ‚¨çš„ç•™è¨€é­åˆ°éŽæ¿¾ã€‚";
	}

	/// <summary>
	/// Key: "Label.EmailVerifiedMessage"
	/// English String: "You must verify your email before you can comment. You can verify your email on the {accountPageLink} page."
	/// </summary>
	public override string LabelEmailVerifiedMessage(string accountPageLink)
	{
		return $"è‹¥è¦ç•™è¨€ï¼Œè«‹å…ˆé©—è­‰é›»å­éƒµä»¶åœ°å€ã€‚æ‚¨å¯ä»¥åœ¨ {accountPageLink} é€²è¡Œé©—è­‰ã€‚";
	}

	protected override string _GetTemplateForLabelEmailVerifiedMessage()
	{
		return "è‹¥è¦ç•™è¨€ï¼Œè«‹å…ˆé©—è­‰é›»å­éƒµä»¶åœ°å€ã€‚æ‚¨å¯ä»¥åœ¨ {accountPageLink} é€²è¡Œé©—è­‰ã€‚";
	}

	protected override string _GetTemplateForLabelEmailVerifiedTitle()
	{
		return "é©—è­‰æ‚¨çš„é›»å­éƒµä»¶åœ°å€";
	}

	protected override string _GetTemplateForLabelFeatureNotAvailable()
	{
		return "ç„¡æ³•ä½¿ç”¨æ­¤åŠŸèƒ½ã€‚";
	}

	protected override string _GetTemplateForLabelLinksNotAllowedMessage()
	{
		return "ç•™è¨€æ‡‰å’Œç›¸å°æ‡‰çš„é“å…·æˆ–åœ°é»žç›¸é—œã€‚ç¦æ­¢è²¼ä¸Šé€£çµã€‚";
	}

	protected override string _GetTemplateForLabelLinksNotAllowedTitle()
	{
		return "ç¦æ­¢è²¼ä¸Šé€£çµ";
	}

	protected override string _GetTemplateForLabelMoreComments()
	{
		return "æ›´å¤šç•™è¨€";
	}

	protected override string _GetTemplateForLabelNoCommentsFound()
	{
		return "æ²’æœ‰ç•™è¨€ã€‚";
	}

	protected override string _GetTemplateForLabelPostComment()
	{
		return "ç™¼è¡¨ç•™è¨€";
	}

	protected override string _GetTemplateForLabelReportAbuse()
	{
		return "æª¢èˆ‰æ¿«ç”¨";
	}

	protected override string _GetTemplateForLabelSeeMore()
	{
		return "æŸ¥çœ‹æ›´å¤š";
	}

	protected override string _GetTemplateForLabelSorryWrong()
	{
		return "å°ä¸èµ·ï¼Œç™¼ç”ŸéŒ¯èª¤ã€‚";
	}

	protected override string _GetTemplateForLabelText()
	{
		return "å…§æ–‡";
	}

	protected override string _GetTemplateForLabelTooManyChracters()
	{
		return "å­—å…ƒéŽå¤šï¼";
	}

	protected override string _GetTemplateForLabelTooManyNewLines()
	{
		return "è¡Œæ•¸éŽå¤šï¼";
	}

	protected override string _GetTemplateForLabelUnknownError()
	{
		return "ç™¼ç”ŸæœªçŸ¥éŒ¯èª¤ã€‚";
	}

	protected override string _GetTemplateForLabelUserFlooded()
	{
		return "æ‚¨çš„ç•™è¨€é »çŽ‡éŽé«˜ï¼Œè«‹ç¨å¾Œå†è©¦ã€‚";
	}

	protected override string _GetTemplateForLabelUsername()
	{
		return "ä½¿ç”¨è€…åç¨±";
	}

	protected override string _GetTemplateForLabelUserTooNew()
	{
		return "åªæœ‰å»ºç«‹æ™‚é–“è¶…éŽ 1 å¤©çš„å¸³è™Ÿå¯ä»¥ç•™è¨€ã€‚";
	}

	protected override string _GetTemplateForLabelVerify()
	{
		return "é©—è­‰";
	}

	protected override string _GetTemplateForLabelWriteAComment()
	{
		return "å¯«ä¸‹ç•™è¨€ï¼";
	}

	/// <summary>
	/// Key: "Label.XHoursAgo"
	/// English String: "{numberOfHours} hours ago"
	/// </summary>
	public override string LabelXHoursAgo(string numberOfHours)
	{
		return $"{numberOfHours} å°æ™‚å‰";
	}

	protected override string _GetTemplateForLabelXHoursAgo()
	{
		return "{numberOfHours} å°æ™‚å‰";
	}
}


}
