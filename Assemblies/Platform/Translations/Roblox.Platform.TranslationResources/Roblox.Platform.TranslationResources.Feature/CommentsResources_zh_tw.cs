namespace Roblox.TranslationResources.Feature;

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
	public override string ActionLogin => "登入";

	/// <summary>
	/// Key: "Heading.Comments"
	/// English String: "Comments"
	/// </summary>
	public override string HeadingComments => "留言";

	/// <summary>
	/// Key: "Heading.LoginToComment"
	/// modal heading
	/// English String: "Login to Comment"
	/// </summary>
	public override string HeadingLoginToComment => "留言前請登入";

	/// <summary>
	/// Key: "Label.AccountPageTitle"
	/// English String: "Account"
	/// </summary>
	public override string LabelAccountPageTitle => "帳號";

	/// <summary>
	/// Key: "Label.Cancel"
	/// English String: "Cancel"
	/// </summary>
	public override string LabelCancel => "取消";

	/// <summary>
	/// Key: "Label.CharactersRemaining"
	/// English String: "characters remaining"
	/// </summary>
	public override string LabelCharactersRemaining => "個剩餘字元";

	/// <summary>
	/// Key: "Label.CommentModerated"
	/// Feedback for user when their comment has been moderated
	/// English String: "Your comment has been moderated."
	/// </summary>
	public override string LabelCommentModerated => "您的留言遭到過濾。";

	/// <summary>
	/// Key: "Label.EmailVerifiedTitle"
	/// English String: "Verify Your Email"
	/// </summary>
	public override string LabelEmailVerifiedTitle => "驗證您的電子郵件地址";

	/// <summary>
	/// Key: "Label.FeatureNotAvailable"
	/// English String: "This feature is not available."
	/// </summary>
	public override string LabelFeatureNotAvailable => "無法使用此功能。";

	/// <summary>
	/// Key: "Label.LinksNotAllowedMessage"
	/// English String: "Comments should be about the item or place on which you are commenting. Links are not permitted."
	/// </summary>
	public override string LabelLinksNotAllowedMessage => "留言應和相對應的道具或地點相關。禁止貼上連結。";

	/// <summary>
	/// Key: "Label.LinksNotAllowedTitle"
	/// English String: "Links Not Allowed"
	/// </summary>
	public override string LabelLinksNotAllowedTitle => "禁止貼上連結";

	/// <summary>
	/// Key: "Label.MoreComments"
	/// English String: "More Comments"
	/// </summary>
	public override string LabelMoreComments => "更多留言";

	/// <summary>
	/// Key: "Label.NoCommentsFound"
	/// English String: "No comments found."
	/// </summary>
	public override string LabelNoCommentsFound => "沒有留言。";

	/// <summary>
	/// Key: "Label.PostComment"
	/// English String: "Post Comment"
	/// </summary>
	public override string LabelPostComment => "發表留言";

	/// <summary>
	/// Key: "Label.ReportAbuse"
	/// English String: "Report Abuse"
	/// </summary>
	public override string LabelReportAbuse => "檢舉濫用";

	/// <summary>
	/// Key: "Label.SeeMore"
	/// English String: "See More"
	/// </summary>
	public override string LabelSeeMore => "查看更多";

	/// <summary>
	/// Key: "Label.SorryWrong"
	/// English String: "Sorry, something went wrong."
	/// </summary>
	public override string LabelSorryWrong => "對不起，發生錯誤。";

	/// <summary>
	/// Key: "Label.Text"
	/// English String: "text"
	/// </summary>
	public override string LabelText => "內文";

	/// <summary>
	/// Key: "Label.TooManyChracters"
	/// English String: "Too many characters!"
	/// </summary>
	public override string LabelTooManyChracters => "字元過多！";

	/// <summary>
	/// Key: "Label.TooManyNewLines"
	/// English String: "Too many newlines!"
	/// </summary>
	public override string LabelTooManyNewLines => "行數過多！";

	/// <summary>
	/// Key: "Label.UnknownError"
	/// English String: "Unknown error occurred."
	/// </summary>
	public override string LabelUnknownError => "發生未知錯誤。";

	/// <summary>
	/// Key: "Label.UserFlooded"
	/// Feedback for users when they are flooded (both globally and per specific item) when posting comments for an item
	/// English String: "You are posting comments too fast. Wait a while before your next comment."
	/// </summary>
	public override string LabelUserFlooded => "您的留言頻率過高，請稍後再試。";

	/// <summary>
	/// Key: "Label.Username"
	/// English String: "username"
	/// </summary>
	public override string LabelUsername => "使用者名稱";

	/// <summary>
	/// Key: "Label.UserTooNew"
	/// Feedback for user when they try to post a comments for an item with a newly registered account
	/// English String: "Accounts must be older than 1 day to post comments."
	/// </summary>
	public override string LabelUserTooNew => "只有建立時間超過 1 天的帳號可以留言。";

	/// <summary>
	/// Key: "Label.Verify"
	/// English String: "Verify"
	/// </summary>
	public override string LabelVerify => "驗證";

	/// <summary>
	/// Key: "Label.WriteAComment"
	/// English String: "Write a comment!"
	/// </summary>
	public override string LabelWriteAComment => "寫下留言！";

	public CommentsResources_zh_tw(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionLogin()
	{
		return "登入";
	}

	/// <summary>
	/// Key: "Description.LoginToComment"
	/// modal body text
	/// English String: "You must login to comment. Please {linkStart}login or register{linkEnd} to continue."
	/// </summary>
	public override string DescriptionLoginToComment(string linkStart, string linkEnd)
	{
		return $"您必須登入才能留言，請先{linkStart}登入或註冊{linkEnd}。";
	}

	protected override string _GetTemplateForDescriptionLoginToComment()
	{
		return "您必須登入才能留言，請先{linkStart}登入或註冊{linkEnd}。";
	}

	protected override string _GetTemplateForHeadingComments()
	{
		return "留言";
	}

	protected override string _GetTemplateForHeadingLoginToComment()
	{
		return "留言前請登入";
	}

	protected override string _GetTemplateForLabelAccountPageTitle()
	{
		return "帳號";
	}

	protected override string _GetTemplateForLabelCancel()
	{
		return "取消";
	}

	protected override string _GetTemplateForLabelCharactersRemaining()
	{
		return "個剩餘字元";
	}

	protected override string _GetTemplateForLabelCommentModerated()
	{
		return "您的留言遭到過濾。";
	}

	/// <summary>
	/// Key: "Label.EmailVerifiedMessage"
	/// English String: "You must verify your email before you can comment. You can verify your email on the {accountPageLink} page."
	/// </summary>
	public override string LabelEmailVerifiedMessage(string accountPageLink)
	{
		return $"若要留言，請先驗證電子郵件地址。您可以在 {accountPageLink} 進行驗證。";
	}

	protected override string _GetTemplateForLabelEmailVerifiedMessage()
	{
		return "若要留言，請先驗證電子郵件地址。您可以在 {accountPageLink} 進行驗證。";
	}

	protected override string _GetTemplateForLabelEmailVerifiedTitle()
	{
		return "驗證您的電子郵件地址";
	}

	protected override string _GetTemplateForLabelFeatureNotAvailable()
	{
		return "無法使用此功能。";
	}

	protected override string _GetTemplateForLabelLinksNotAllowedMessage()
	{
		return "留言應和相對應的道具或地點相關。禁止貼上連結。";
	}

	protected override string _GetTemplateForLabelLinksNotAllowedTitle()
	{
		return "禁止貼上連結";
	}

	protected override string _GetTemplateForLabelMoreComments()
	{
		return "更多留言";
	}

	protected override string _GetTemplateForLabelNoCommentsFound()
	{
		return "沒有留言。";
	}

	protected override string _GetTemplateForLabelPostComment()
	{
		return "發表留言";
	}

	protected override string _GetTemplateForLabelReportAbuse()
	{
		return "檢舉濫用";
	}

	protected override string _GetTemplateForLabelSeeMore()
	{
		return "查看更多";
	}

	protected override string _GetTemplateForLabelSorryWrong()
	{
		return "對不起，發生錯誤。";
	}

	protected override string _GetTemplateForLabelText()
	{
		return "內文";
	}

	protected override string _GetTemplateForLabelTooManyChracters()
	{
		return "字元過多！";
	}

	protected override string _GetTemplateForLabelTooManyNewLines()
	{
		return "行數過多！";
	}

	protected override string _GetTemplateForLabelUnknownError()
	{
		return "發生未知錯誤。";
	}

	protected override string _GetTemplateForLabelUserFlooded()
	{
		return "您的留言頻率過高，請稍後再試。";
	}

	protected override string _GetTemplateForLabelUsername()
	{
		return "使用者名稱";
	}

	protected override string _GetTemplateForLabelUserTooNew()
	{
		return "只有建立時間超過 1 天的帳號可以留言。";
	}

	protected override string _GetTemplateForLabelVerify()
	{
		return "驗證";
	}

	protected override string _GetTemplateForLabelWriteAComment()
	{
		return "寫下留言！";
	}

	/// <summary>
	/// Key: "Label.XHoursAgo"
	/// English String: "{numberOfHours} hours ago"
	/// </summary>
	public override string LabelXHoursAgo(string numberOfHours)
	{
		return $"{numberOfHours} 小時前";
	}

	protected override string _GetTemplateForLabelXHoursAgo()
	{
		return "{numberOfHours} 小時前";
	}
}
