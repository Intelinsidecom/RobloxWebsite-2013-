namespace Roblox.Platform.TranslationResources.Feature {
    /// <summary>

/// This class overrides CommentsResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class CommentsResources_ko_kr : CommentsResources_en_us, ICommentsResources, ITranslationResources
{
	/// <summary>
	/// Key: "Action.Login"
	/// button text
	/// English String: "Login"
	/// </summary>
	public override string ActionLogin => "ë¡œê·¸ì¸";

	/// <summary>
	/// Key: "Heading.Comments"
	/// English String: "Comments"
	/// </summary>
	public override string HeadingComments => "ì½”ë©˜íŠ¸";

	/// <summary>
	/// Key: "Heading.LoginToComment"
	/// modal heading
	/// English String: "Login to Comment"
	/// </summary>
	public override string HeadingLoginToComment => "ë¡œê·¸ì¸ ë° ì½”ë©˜íŠ¸";

	/// <summary>
	/// Key: "Label.AccountPageTitle"
	/// English String: "Account"
	/// </summary>
	public override string LabelAccountPageTitle => "ê³„ì •";

	/// <summary>
	/// Key: "Label.Cancel"
	/// English String: "Cancel"
	/// </summary>
	public override string LabelCancel => "ì·¨ì†Œ";

	/// <summary>
	/// Key: "Label.CharactersRemaining"
	/// English String: "characters remaining"
	/// </summary>
	public override string LabelCharactersRemaining => "ìž ë‚¨ìŒ";

	/// <summary>
	/// Key: "Label.CommentModerated"
	/// Feedback for user when their comment has been moderated
	/// English String: "Your comment has been moderated."
	/// </summary>
	public override string LabelCommentModerated => "ì½”ë©˜íŠ¸ì˜ ê²€í†  ìš”ì²­ì„ ë°›ì•˜ì–´ìš”.";

	/// <summary>
	/// Key: "Label.EmailVerifiedTitle"
	/// English String: "Verify Your Email"
	/// </summary>
	public override string LabelEmailVerifiedTitle => "ì´ë©”ì¼ ì¸ì¦";

	/// <summary>
	/// Key: "Label.FeatureNotAvailable"
	/// English String: "This feature is not available."
	/// </summary>
	public override string LabelFeatureNotAvailable => "ì´ìš©í•  ìˆ˜ ì—†ëŠ” ê¸°ëŠ¥ì´ì—ìš”.";

	/// <summary>
	/// Key: "Label.LinksNotAllowedMessage"
	/// English String: "Comments should be about the item or place on which you are commenting. Links are not permitted."
	/// </summary>
	public override string LabelLinksNotAllowedMessage => "ì½”ë©˜íŠ¸ëŠ” ì•„ì´í…œì´ë‚˜ ìž¥ì†Œì— ê´€í•œ ë‚´ìš©ì´ì–´ì•¼ í•©ë‹ˆë‹¤. ë§í¬ëŠ” ì‚¬ìš©í•˜ì‹¤ ìˆ˜ ì—†ì–´ìš”.";

	/// <summary>
	/// Key: "Label.LinksNotAllowedTitle"
	/// English String: "Links Not Allowed"
	/// </summary>
	public override string LabelLinksNotAllowedTitle => "ë§í¬ ì‚¬ìš© ê¸ˆì§€";

	/// <summary>
	/// Key: "Label.MoreComments"
	/// English String: "More Comments"
	/// </summary>
	public override string LabelMoreComments => "ì½”ë©˜íŠ¸ ë” ë³´ê¸°";

	/// <summary>
	/// Key: "Label.NoCommentsFound"
	/// English String: "No comments found."
	/// </summary>
	public override string LabelNoCommentsFound => "ì½”ë©˜íŠ¸ê°€ ì—†ì–´ìš”.";

	/// <summary>
	/// Key: "Label.PostComment"
	/// English String: "Post Comment"
	/// </summary>
	public override string LabelPostComment => "ì½”ë©˜íŠ¸ ë‹¬ê¸°";

	/// <summary>
	/// Key: "Label.ReportAbuse"
	/// English String: "Report Abuse"
	/// </summary>
	public override string LabelReportAbuse => "ì‹ ê³ í•˜ê¸°";

	/// <summary>
	/// Key: "Label.SeeMore"
	/// English String: "See More"
	/// </summary>
	public override string LabelSeeMore => "ë” ë³´ê¸°";

	/// <summary>
	/// Key: "Label.SorryWrong"
	/// English String: "Sorry, something went wrong."
	/// </summary>
	public override string LabelSorryWrong => "ì£„ì†¡í•©ë‹ˆë‹¤. ì˜¤ë¥˜ê°€ ë°œìƒí–ˆì–´ìš”.";

	/// <summary>
	/// Key: "Label.Text"
	/// English String: "text"
	/// </summary>
	public override string LabelText => "í…ìŠ¤íŠ¸";

	/// <summary>
	/// Key: "Label.TooManyChracters"
	/// English String: "Too many characters!"
	/// </summary>
	public override string LabelTooManyChracters => "ê¸€ìž ìˆ˜ê°€ ë„ˆë¬´ ë§Žì•„ìš”!";

	/// <summary>
	/// Key: "Label.TooManyNewLines"
	/// English String: "Too many newlines!"
	/// </summary>
	public override string LabelTooManyNewLines => "ì¤„ ìˆ˜ê°€ ë„ˆë¬´ ë§Žì•„ìš”!";

	/// <summary>
	/// Key: "Label.UnknownError"
	/// English String: "Unknown error occurred."
	/// </summary>
	public override string LabelUnknownError => "ì•Œ ìˆ˜ ì—†ëŠ” ì˜¤ë¥˜ê°€ ë°œìƒí–ˆì–´ìš”.";

	/// <summary>
	/// Key: "Label.UserFlooded"
	/// Feedback for users when they are flooded (both globally and per specific item) when posting comments for an item
	/// English String: "You are posting comments too fast. Wait a while before your next comment."
	/// </summary>
	public override string LabelUserFlooded => "ì½”ë©˜íŠ¸ë¥¼ ë„ˆë¬´ ë¹¨ë¦¬ ë‹¬ê³  ìžˆì–´ìš”. ë‹¤ìŒ ì½”ë©˜íŠ¸ë¥¼ ì“°ê¸° ì „ì— ì¡°ê¸ˆ ê¸°ë‹¤ë¦¬ì„¸ìš”.";

	/// <summary>
	/// Key: "Label.Username"
	/// English String: "username"
	/// </summary>
	public override string LabelUsername => "ì‚¬ìš©ìž ì´ë¦„";

	/// <summary>
	/// Key: "Label.UserTooNew"
	/// Feedback for user when they try to post a comments for an item with a newly registered account
	/// English String: "Accounts must be older than 1 day to post comments."
	/// </summary>
	public override string LabelUserTooNew => "ê³„ì •ì„ ë§Œë“¤ê³  í•˜ë£¨ê°€ ì§€ë‚˜ì•¼ ì½”ë©˜íŠ¸ë¥¼ ìž‘ì„±í•  ìˆ˜ ìžˆì–´ìš”.";

	/// <summary>
	/// Key: "Label.Verify"
	/// English String: "Verify"
	/// </summary>
	public override string LabelVerify => "ì¸ì¦";

	/// <summary>
	/// Key: "Label.WriteAComment"
	/// English String: "Write a comment!"
	/// </summary>
	public override string LabelWriteAComment => "ì½”ë©˜íŠ¸ë¥¼ ë‹¬ì•„ì£¼ì„¸ìš”!";

	public CommentsResources_ko_kr(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionLogin()
	{
		return "ë¡œê·¸ì¸";
	}

	/// <summary>
	/// Key: "Description.LoginToComment"
	/// modal body text
	/// English String: "You must login to comment. Please {linkStart}login or register{linkEnd} to continue."
	/// </summary>
	public override string DescriptionLoginToComment(string linkStart, string linkEnd)
	{
		return $"ì½”ë©˜íŠ¸ë¥¼ ë‚¨ê¸°ë ¤ë©´ ë¡œê·¸ì¸í•´ì•¼ í•©ë‹ˆë‹¤. ê³„ì†í•˜ë ¤ë©´ {linkStart}ë¡œê·¸ì¸ ë˜ëŠ” ê°€ìž…{linkEnd}í•˜ì„¸ìš”.";
	}

	protected override string _GetTemplateForDescriptionLoginToComment()
	{
		return "ì½”ë©˜íŠ¸ë¥¼ ë‚¨ê¸°ë ¤ë©´ ë¡œê·¸ì¸í•´ì•¼ í•©ë‹ˆë‹¤. ê³„ì†í•˜ë ¤ë©´ {linkStart}ë¡œê·¸ì¸ ë˜ëŠ” ê°€ìž…{linkEnd}í•˜ì„¸ìš”.";
	}

	protected override string _GetTemplateForHeadingComments()
	{
		return "ì½”ë©˜íŠ¸";
	}

	protected override string _GetTemplateForHeadingLoginToComment()
	{
		return "ë¡œê·¸ì¸ ë° ì½”ë©˜íŠ¸";
	}

	protected override string _GetTemplateForLabelAccountPageTitle()
	{
		return "ê³„ì •";
	}

	protected override string _GetTemplateForLabelCancel()
	{
		return "ì·¨ì†Œ";
	}

	protected override string _GetTemplateForLabelCharactersRemaining()
	{
		return "ìž ë‚¨ìŒ";
	}

	protected override string _GetTemplateForLabelCommentModerated()
	{
		return "ì½”ë©˜íŠ¸ì˜ ê²€í†  ìš”ì²­ì„ ë°›ì•˜ì–´ìš”.";
	}

	/// <summary>
	/// Key: "Label.EmailVerifiedMessage"
	/// English String: "You must verify your email before you can comment. You can verify your email on the {accountPageLink} page."
	/// </summary>
	public override string LabelEmailVerifiedMessage(string accountPageLink)
	{
		return $"ì½”ë©˜íŠ¸ë¥¼ ë‹¬ë ¤ë©´ ë¨¼ì € ì´ë©”ì¼ ì¸ì¦ì„ í•´ì•¼í•©ë‹ˆë‹¤. {accountPageLink} íŽ˜ì´ì§€ì—ì„œ ì´ë©”ì¼ì„ ì¸ì¦í•  ìˆ˜ ìžˆì–´ìš”.";
	}

	protected override string _GetTemplateForLabelEmailVerifiedMessage()
	{
		return "ì½”ë©˜íŠ¸ë¥¼ ë‹¬ë ¤ë©´ ë¨¼ì € ì´ë©”ì¼ ì¸ì¦ì„ í•´ì•¼í•©ë‹ˆë‹¤. {accountPageLink} íŽ˜ì´ì§€ì—ì„œ ì´ë©”ì¼ì„ ì¸ì¦í•  ìˆ˜ ìžˆì–´ìš”.";
	}

	protected override string _GetTemplateForLabelEmailVerifiedTitle()
	{
		return "ì´ë©”ì¼ ì¸ì¦";
	}

	protected override string _GetTemplateForLabelFeatureNotAvailable()
	{
		return "ì´ìš©í•  ìˆ˜ ì—†ëŠ” ê¸°ëŠ¥ì´ì—ìš”.";
	}

	protected override string _GetTemplateForLabelLinksNotAllowedMessage()
	{
		return "ì½”ë©˜íŠ¸ëŠ” ì•„ì´í…œì´ë‚˜ ìž¥ì†Œì— ê´€í•œ ë‚´ìš©ì´ì–´ì•¼ í•©ë‹ˆë‹¤. ë§í¬ëŠ” ì‚¬ìš©í•˜ì‹¤ ìˆ˜ ì—†ì–´ìš”.";
	}

	protected override string _GetTemplateForLabelLinksNotAllowedTitle()
	{
		return "ë§í¬ ì‚¬ìš© ê¸ˆì§€";
	}

	protected override string _GetTemplateForLabelMoreComments()
	{
		return "ì½”ë©˜íŠ¸ ë” ë³´ê¸°";
	}

	protected override string _GetTemplateForLabelNoCommentsFound()
	{
		return "ì½”ë©˜íŠ¸ê°€ ì—†ì–´ìš”.";
	}

	protected override string _GetTemplateForLabelPostComment()
	{
		return "ì½”ë©˜íŠ¸ ë‹¬ê¸°";
	}

	protected override string _GetTemplateForLabelReportAbuse()
	{
		return "ì‹ ê³ í•˜ê¸°";
	}

	protected override string _GetTemplateForLabelSeeMore()
	{
		return "ë” ë³´ê¸°";
	}

	protected override string _GetTemplateForLabelSorryWrong()
	{
		return "ì£„ì†¡í•©ë‹ˆë‹¤. ì˜¤ë¥˜ê°€ ë°œìƒí–ˆì–´ìš”.";
	}

	protected override string _GetTemplateForLabelText()
	{
		return "í…ìŠ¤íŠ¸";
	}

	protected override string _GetTemplateForLabelTooManyChracters()
	{
		return "ê¸€ìž ìˆ˜ê°€ ë„ˆë¬´ ë§Žì•„ìš”!";
	}

	protected override string _GetTemplateForLabelTooManyNewLines()
	{
		return "ì¤„ ìˆ˜ê°€ ë„ˆë¬´ ë§Žì•„ìš”!";
	}

	protected override string _GetTemplateForLabelUnknownError()
	{
		return "ì•Œ ìˆ˜ ì—†ëŠ” ì˜¤ë¥˜ê°€ ë°œìƒí–ˆì–´ìš”.";
	}

	protected override string _GetTemplateForLabelUserFlooded()
	{
		return "ì½”ë©˜íŠ¸ë¥¼ ë„ˆë¬´ ë¹¨ë¦¬ ë‹¬ê³  ìžˆì–´ìš”. ë‹¤ìŒ ì½”ë©˜íŠ¸ë¥¼ ì“°ê¸° ì „ì— ì¡°ê¸ˆ ê¸°ë‹¤ë¦¬ì„¸ìš”.";
	}

	protected override string _GetTemplateForLabelUsername()
	{
		return "ì‚¬ìš©ìž ì´ë¦„";
	}

	protected override string _GetTemplateForLabelUserTooNew()
	{
		return "ê³„ì •ì„ ë§Œë“¤ê³  í•˜ë£¨ê°€ ì§€ë‚˜ì•¼ ì½”ë©˜íŠ¸ë¥¼ ìž‘ì„±í•  ìˆ˜ ìžˆì–´ìš”.";
	}

	protected override string _GetTemplateForLabelVerify()
	{
		return "ì¸ì¦";
	}

	protected override string _GetTemplateForLabelWriteAComment()
	{
		return "ì½”ë©˜íŠ¸ë¥¼ ë‹¬ì•„ì£¼ì„¸ìš”!";
	}

	/// <summary>
	/// Key: "Label.XHoursAgo"
	/// English String: "{numberOfHours} hours ago"
	/// </summary>
	public override string LabelXHoursAgo(string numberOfHours)
	{
		return $"{numberOfHours}ì‹œê°„ ì „";
	}

	protected override string _GetTemplateForLabelXHoursAgo()
	{
		return "{numberOfHours}ì‹œê°„ ì „";
	}
}


}
