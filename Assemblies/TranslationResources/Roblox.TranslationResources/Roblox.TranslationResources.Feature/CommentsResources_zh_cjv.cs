namespace Roblox.TranslationResources.Feature;

/// <summary>
/// This class overrides CommentsResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class CommentsResources_zh_cjv : CommentsResources_en_us, ICommentsResources, ITranslationResources
{
	/// <summary>
	/// Key: "Action.Login"
	/// button text
	/// English String: "Login"
	/// </summary>
	public override string ActionLogin => "登录";

	/// <summary>
	/// Key: "Heading.Comments"
	/// English String: "Comments"
	/// </summary>
	public override string HeadingComments => "评论";

	/// <summary>
	/// Key: "Heading.LoginToComment"
	/// modal heading
	/// English String: "Login to Comment"
	/// </summary>
	public override string HeadingLoginToComment => "发表评论前请先登录";

	/// <summary>
	/// Key: "Label.AccountPageTitle"
	/// English String: "Account"
	/// </summary>
	public override string LabelAccountPageTitle => "帐户";

	/// <summary>
	/// Key: "Label.Cancel"
	/// English String: "Cancel"
	/// </summary>
	public override string LabelCancel => "取消";

	/// <summary>
	/// Key: "Label.CharactersRemaining"
	/// English String: "characters remaining"
	/// </summary>
	public override string LabelCharactersRemaining => "个剩余字符";

	/// <summary>
	/// Key: "Label.CommentModerated"
	/// Feedback for user when their comment has been moderated
	/// English String: "Your comment has been moderated."
	/// </summary>
	public override string LabelCommentModerated => "你的评论已被过滤。";

	/// <summary>
	/// Key: "Label.EmailVerifiedTitle"
	/// English String: "Verify Your Email"
	/// </summary>
	public override string LabelEmailVerifiedTitle => "验证你的电子邮件";

	/// <summary>
	/// Key: "Label.FeatureNotAvailable"
	/// English String: "This feature is not available."
	/// </summary>
	public override string LabelFeatureNotAvailable => "此功能不可用。";

	/// <summary>
	/// Key: "Label.LinksNotAllowedMessage"
	/// English String: "Comments should be about the item or place on which you are commenting. Links are not permitted."
	/// </summary>
	public override string LabelLinksNotAllowedMessage => "评论应和你所评论的物品或场景相关。禁止使用链接。";

	/// <summary>
	/// Key: "Label.LinksNotAllowedTitle"
	/// English String: "Links Not Allowed"
	/// </summary>
	public override string LabelLinksNotAllowedTitle => "不允许使用链接";

	/// <summary>
	/// Key: "Label.MoreComments"
	/// English String: "More Comments"
	/// </summary>
	public override string LabelMoreComments => "更多评论";

	/// <summary>
	/// Key: "Label.NoCommentsFound"
	/// English String: "No comments found."
	/// </summary>
	public override string LabelNoCommentsFound => "未找到评论。";

	/// <summary>
	/// Key: "Label.PostComment"
	/// English String: "Post Comment"
	/// </summary>
	public override string LabelPostComment => "发布评论";

	/// <summary>
	/// Key: "Label.ReportAbuse"
	/// English String: "Report Abuse"
	/// </summary>
	public override string LabelReportAbuse => "报告滥用行为";

	/// <summary>
	/// Key: "Label.SeeMore"
	/// English String: "See More"
	/// </summary>
	public override string LabelSeeMore => "查看更多";

	/// <summary>
	/// Key: "Label.SorryWrong"
	/// English String: "Sorry, something went wrong."
	/// </summary>
	public override string LabelSorryWrong => "抱歉，发生错误。";

	/// <summary>
	/// Key: "Label.Text"
	/// English String: "text"
	/// </summary>
	public override string LabelText => "文本";

	/// <summary>
	/// Key: "Label.TooManyChracters"
	/// English String: "Too many characters!"
	/// </summary>
	public override string LabelTooManyChracters => "字符过多！";

	/// <summary>
	/// Key: "Label.TooManyNewLines"
	/// English String: "Too many newlines!"
	/// </summary>
	public override string LabelTooManyNewLines => "换行符过多！";

	/// <summary>
	/// Key: "Label.UnknownError"
	/// English String: "Unknown error occurred."
	/// </summary>
	public override string LabelUnknownError => "发生未知错误。";

	/// <summary>
	/// Key: "Label.UserFlooded"
	/// Feedback for users when they are flooded (both globally and per specific item) when posting comments for an item
	/// English String: "You are posting comments too fast. Wait a while before your next comment."
	/// </summary>
	public override string LabelUserFlooded => "你发布评论的次数太频繁。请稍候再发表下一条评论。";

	/// <summary>
	/// Key: "Label.Username"
	/// English String: "username"
	/// </summary>
	public override string LabelUsername => "用户名";

	/// <summary>
	/// Key: "Label.UserTooNew"
	/// Feedback for user when they try to post a comments for an item with a newly registered account
	/// English String: "Accounts must be older than 1 day to post comments."
	/// </summary>
	public override string LabelUserTooNew => "建立帐户后需等待 1 天才能发表评论。";

	/// <summary>
	/// Key: "Label.Verify"
	/// English String: "Verify"
	/// </summary>
	public override string LabelVerify => "验证";

	/// <summary>
	/// Key: "Label.WriteAComment"
	/// English String: "Write a comment!"
	/// </summary>
	public override string LabelWriteAComment => "写下评论！";

	public CommentsResources_zh_cjv(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionLogin()
	{
		return "登录";
	}

	/// <summary>
	/// Key: "Description.LoginToComment"
	/// modal body text
	/// English String: "You must login to comment. Please {linkStart}login or register{linkEnd} to continue."
	/// </summary>
	public override string DescriptionLoginToComment(string linkStart, string linkEnd)
	{
		return $"你必须先登录才能发表评论。请{linkStart}登录或注册{linkEnd}以继续。";
	}

	protected override string _GetTemplateForDescriptionLoginToComment()
	{
		return "你必须先登录才能发表评论。请{linkStart}登录或注册{linkEnd}以继续。";
	}

	protected override string _GetTemplateForHeadingComments()
	{
		return "评论";
	}

	protected override string _GetTemplateForHeadingLoginToComment()
	{
		return "发表评论前请先登录";
	}

	protected override string _GetTemplateForLabelAccountPageTitle()
	{
		return "帐户";
	}

	protected override string _GetTemplateForLabelCancel()
	{
		return "取消";
	}

	protected override string _GetTemplateForLabelCharactersRemaining()
	{
		return "个剩余字符";
	}

	protected override string _GetTemplateForLabelCommentModerated()
	{
		return "你的评论已被过滤。";
	}

	/// <summary>
	/// Key: "Label.EmailVerifiedMessage"
	/// English String: "You must verify your email before you can comment. You can verify your email on the {accountPageLink} page."
	/// </summary>
	public override string LabelEmailVerifiedMessage(string accountPageLink)
	{
		return $"你必须验证电子邮件，然后才能评论。你可以在 {accountPageLink} 页面验证你的电子邮件。";
	}

	protected override string _GetTemplateForLabelEmailVerifiedMessage()
	{
		return "你必须验证电子邮件，然后才能评论。你可以在 {accountPageLink} 页面验证你的电子邮件。";
	}

	protected override string _GetTemplateForLabelEmailVerifiedTitle()
	{
		return "验证你的电子邮件";
	}

	protected override string _GetTemplateForLabelFeatureNotAvailable()
	{
		return "此功能不可用。";
	}

	protected override string _GetTemplateForLabelLinksNotAllowedMessage()
	{
		return "评论应和你所评论的物品或场景相关。禁止使用链接。";
	}

	protected override string _GetTemplateForLabelLinksNotAllowedTitle()
	{
		return "不允许使用链接";
	}

	protected override string _GetTemplateForLabelMoreComments()
	{
		return "更多评论";
	}

	protected override string _GetTemplateForLabelNoCommentsFound()
	{
		return "未找到评论。";
	}

	protected override string _GetTemplateForLabelPostComment()
	{
		return "发布评论";
	}

	protected override string _GetTemplateForLabelReportAbuse()
	{
		return "报告滥用行为";
	}

	protected override string _GetTemplateForLabelSeeMore()
	{
		return "查看更多";
	}

	protected override string _GetTemplateForLabelSorryWrong()
	{
		return "抱歉，发生错误。";
	}

	protected override string _GetTemplateForLabelText()
	{
		return "文本";
	}

	protected override string _GetTemplateForLabelTooManyChracters()
	{
		return "字符过多！";
	}

	protected override string _GetTemplateForLabelTooManyNewLines()
	{
		return "换行符过多！";
	}

	protected override string _GetTemplateForLabelUnknownError()
	{
		return "发生未知错误。";
	}

	protected override string _GetTemplateForLabelUserFlooded()
	{
		return "你发布评论的次数太频繁。请稍候再发表下一条评论。";
	}

	protected override string _GetTemplateForLabelUsername()
	{
		return "用户名";
	}

	protected override string _GetTemplateForLabelUserTooNew()
	{
		return "建立帐户后需等待 1 天才能发表评论。";
	}

	protected override string _GetTemplateForLabelVerify()
	{
		return "验证";
	}

	protected override string _GetTemplateForLabelWriteAComment()
	{
		return "写下评论！";
	}

	/// <summary>
	/// Key: "Label.XHoursAgo"
	/// English String: "{numberOfHours} hours ago"
	/// </summary>
	public override string LabelXHoursAgo(string numberOfHours)
	{
		return $"{numberOfHours} 小时前";
	}

	protected override string _GetTemplateForLabelXHoursAgo()
	{
		return "{numberOfHours} 小时前";
	}
}
