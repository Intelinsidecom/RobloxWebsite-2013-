namespace Roblox.TranslationResources.Feature;

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
	public override string ActionLogin => "로그인";

	/// <summary>
	/// Key: "Heading.Comments"
	/// English String: "Comments"
	/// </summary>
	public override string HeadingComments => "코멘트";

	/// <summary>
	/// Key: "Heading.LoginToComment"
	/// modal heading
	/// English String: "Login to Comment"
	/// </summary>
	public override string HeadingLoginToComment => "로그인 및 코멘트";

	/// <summary>
	/// Key: "Label.AccountPageTitle"
	/// English String: "Account"
	/// </summary>
	public override string LabelAccountPageTitle => "계정";

	/// <summary>
	/// Key: "Label.Cancel"
	/// English String: "Cancel"
	/// </summary>
	public override string LabelCancel => "취소";

	/// <summary>
	/// Key: "Label.CharactersRemaining"
	/// English String: "characters remaining"
	/// </summary>
	public override string LabelCharactersRemaining => "자 남음";

	/// <summary>
	/// Key: "Label.CommentModerated"
	/// Feedback for user when their comment has been moderated
	/// English String: "Your comment has been moderated."
	/// </summary>
	public override string LabelCommentModerated => "코멘트의 검토 요청을 받았어요.";

	/// <summary>
	/// Key: "Label.EmailVerifiedTitle"
	/// English String: "Verify Your Email"
	/// </summary>
	public override string LabelEmailVerifiedTitle => "이메일 인증";

	/// <summary>
	/// Key: "Label.FeatureNotAvailable"
	/// English String: "This feature is not available."
	/// </summary>
	public override string LabelFeatureNotAvailable => "이용할 수 없는 기능이에요.";

	/// <summary>
	/// Key: "Label.LinksNotAllowedMessage"
	/// English String: "Comments should be about the item or place on which you are commenting. Links are not permitted."
	/// </summary>
	public override string LabelLinksNotAllowedMessage => "코멘트는 아이템이나 장소에 관한 내용이어야 합니다. 링크는 사용하실 수 없어요.";

	/// <summary>
	/// Key: "Label.LinksNotAllowedTitle"
	/// English String: "Links Not Allowed"
	/// </summary>
	public override string LabelLinksNotAllowedTitle => "링크 사용 금지";

	/// <summary>
	/// Key: "Label.MoreComments"
	/// English String: "More Comments"
	/// </summary>
	public override string LabelMoreComments => "코멘트 더 보기";

	/// <summary>
	/// Key: "Label.NoCommentsFound"
	/// English String: "No comments found."
	/// </summary>
	public override string LabelNoCommentsFound => "코멘트가 없어요.";

	/// <summary>
	/// Key: "Label.PostComment"
	/// English String: "Post Comment"
	/// </summary>
	public override string LabelPostComment => "코멘트 달기";

	/// <summary>
	/// Key: "Label.ReportAbuse"
	/// English String: "Report Abuse"
	/// </summary>
	public override string LabelReportAbuse => "신고하기";

	/// <summary>
	/// Key: "Label.SeeMore"
	/// English String: "See More"
	/// </summary>
	public override string LabelSeeMore => "더 보기";

	/// <summary>
	/// Key: "Label.SorryWrong"
	/// English String: "Sorry, something went wrong."
	/// </summary>
	public override string LabelSorryWrong => "죄송합니다. 오류가 발생했어요.";

	/// <summary>
	/// Key: "Label.Text"
	/// English String: "text"
	/// </summary>
	public override string LabelText => "텍스트";

	/// <summary>
	/// Key: "Label.TooManyChracters"
	/// English String: "Too many characters!"
	/// </summary>
	public override string LabelTooManyChracters => "글자 수가 너무 많아요!";

	/// <summary>
	/// Key: "Label.TooManyNewLines"
	/// English String: "Too many newlines!"
	/// </summary>
	public override string LabelTooManyNewLines => "줄 수가 너무 많아요!";

	/// <summary>
	/// Key: "Label.UnknownError"
	/// English String: "Unknown error occurred."
	/// </summary>
	public override string LabelUnknownError => "알 수 없는 오류가 발생했어요.";

	/// <summary>
	/// Key: "Label.UserFlooded"
	/// Feedback for users when they are flooded (both globally and per specific item) when posting comments for an item
	/// English String: "You are posting comments too fast. Wait a while before your next comment."
	/// </summary>
	public override string LabelUserFlooded => "코멘트를 너무 빨리 달고 있어요. 다음 코멘트를 쓰기 전에 조금 기다리세요.";

	/// <summary>
	/// Key: "Label.Username"
	/// English String: "username"
	/// </summary>
	public override string LabelUsername => "사용자 이름";

	/// <summary>
	/// Key: "Label.UserTooNew"
	/// Feedback for user when they try to post a comments for an item with a newly registered account
	/// English String: "Accounts must be older than 1 day to post comments."
	/// </summary>
	public override string LabelUserTooNew => "계정을 만들고 하루가 지나야 코멘트를 작성할 수 있어요.";

	/// <summary>
	/// Key: "Label.Verify"
	/// English String: "Verify"
	/// </summary>
	public override string LabelVerify => "인증";

	/// <summary>
	/// Key: "Label.WriteAComment"
	/// English String: "Write a comment!"
	/// </summary>
	public override string LabelWriteAComment => "코멘트를 달아주세요!";

	public CommentsResources_ko_kr(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionLogin()
	{
		return "로그인";
	}

	/// <summary>
	/// Key: "Description.LoginToComment"
	/// modal body text
	/// English String: "You must login to comment. Please {linkStart}login or register{linkEnd} to continue."
	/// </summary>
	public override string DescriptionLoginToComment(string linkStart, string linkEnd)
	{
		return $"코멘트를 남기려면 로그인해야 합니다. 계속하려면 {linkStart}로그인 또는 가입{linkEnd}하세요.";
	}

	protected override string _GetTemplateForDescriptionLoginToComment()
	{
		return "코멘트를 남기려면 로그인해야 합니다. 계속하려면 {linkStart}로그인 또는 가입{linkEnd}하세요.";
	}

	protected override string _GetTemplateForHeadingComments()
	{
		return "코멘트";
	}

	protected override string _GetTemplateForHeadingLoginToComment()
	{
		return "로그인 및 코멘트";
	}

	protected override string _GetTemplateForLabelAccountPageTitle()
	{
		return "계정";
	}

	protected override string _GetTemplateForLabelCancel()
	{
		return "취소";
	}

	protected override string _GetTemplateForLabelCharactersRemaining()
	{
		return "자 남음";
	}

	protected override string _GetTemplateForLabelCommentModerated()
	{
		return "코멘트의 검토 요청을 받았어요.";
	}

	/// <summary>
	/// Key: "Label.EmailVerifiedMessage"
	/// English String: "You must verify your email before you can comment. You can verify your email on the {accountPageLink} page."
	/// </summary>
	public override string LabelEmailVerifiedMessage(string accountPageLink)
	{
		return $"코멘트를 달려면 먼저 이메일 인증을 해야합니다. {accountPageLink} 페이지에서 이메일을 인증할 수 있어요.";
	}

	protected override string _GetTemplateForLabelEmailVerifiedMessage()
	{
		return "코멘트를 달려면 먼저 이메일 인증을 해야합니다. {accountPageLink} 페이지에서 이메일을 인증할 수 있어요.";
	}

	protected override string _GetTemplateForLabelEmailVerifiedTitle()
	{
		return "이메일 인증";
	}

	protected override string _GetTemplateForLabelFeatureNotAvailable()
	{
		return "이용할 수 없는 기능이에요.";
	}

	protected override string _GetTemplateForLabelLinksNotAllowedMessage()
	{
		return "코멘트는 아이템이나 장소에 관한 내용이어야 합니다. 링크는 사용하실 수 없어요.";
	}

	protected override string _GetTemplateForLabelLinksNotAllowedTitle()
	{
		return "링크 사용 금지";
	}

	protected override string _GetTemplateForLabelMoreComments()
	{
		return "코멘트 더 보기";
	}

	protected override string _GetTemplateForLabelNoCommentsFound()
	{
		return "코멘트가 없어요.";
	}

	protected override string _GetTemplateForLabelPostComment()
	{
		return "코멘트 달기";
	}

	protected override string _GetTemplateForLabelReportAbuse()
	{
		return "신고하기";
	}

	protected override string _GetTemplateForLabelSeeMore()
	{
		return "더 보기";
	}

	protected override string _GetTemplateForLabelSorryWrong()
	{
		return "죄송합니다. 오류가 발생했어요.";
	}

	protected override string _GetTemplateForLabelText()
	{
		return "텍스트";
	}

	protected override string _GetTemplateForLabelTooManyChracters()
	{
		return "글자 수가 너무 많아요!";
	}

	protected override string _GetTemplateForLabelTooManyNewLines()
	{
		return "줄 수가 너무 많아요!";
	}

	protected override string _GetTemplateForLabelUnknownError()
	{
		return "알 수 없는 오류가 발생했어요.";
	}

	protected override string _GetTemplateForLabelUserFlooded()
	{
		return "코멘트를 너무 빨리 달고 있어요. 다음 코멘트를 쓰기 전에 조금 기다리세요.";
	}

	protected override string _GetTemplateForLabelUsername()
	{
		return "사용자 이름";
	}

	protected override string _GetTemplateForLabelUserTooNew()
	{
		return "계정을 만들고 하루가 지나야 코멘트를 작성할 수 있어요.";
	}

	protected override string _GetTemplateForLabelVerify()
	{
		return "인증";
	}

	protected override string _GetTemplateForLabelWriteAComment()
	{
		return "코멘트를 달아주세요!";
	}

	/// <summary>
	/// Key: "Label.XHoursAgo"
	/// English String: "{numberOfHours} hours ago"
	/// </summary>
	public override string LabelXHoursAgo(string numberOfHours)
	{
		return $"{numberOfHours}시간 전";
	}

	protected override string _GetTemplateForLabelXHoursAgo()
	{
		return "{numberOfHours}시간 전";
	}
}
