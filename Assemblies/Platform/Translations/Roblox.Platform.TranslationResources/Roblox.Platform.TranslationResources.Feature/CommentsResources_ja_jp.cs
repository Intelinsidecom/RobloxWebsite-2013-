namespace Roblox.TranslationResources.Feature;

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
	public override string ActionLogin => "ログイン";

	/// <summary>
	/// Key: "Heading.Comments"
	/// English String: "Comments"
	/// </summary>
	public override string HeadingComments => "コメント";

	/// <summary>
	/// Key: "Heading.LoginToComment"
	/// modal heading
	/// English String: "Login to Comment"
	/// </summary>
	public override string HeadingLoginToComment => "ログインしてコメントする";

	/// <summary>
	/// Key: "Label.AccountPageTitle"
	/// English String: "Account"
	/// </summary>
	public override string LabelAccountPageTitle => "アカウント";

	/// <summary>
	/// Key: "Label.Cancel"
	/// English String: "Cancel"
	/// </summary>
	public override string LabelCancel => "キャンセル";

	/// <summary>
	/// Key: "Label.CharactersRemaining"
	/// English String: "characters remaining"
	/// </summary>
	public override string LabelCharactersRemaining => "文字残っています";

	/// <summary>
	/// Key: "Label.CommentModerated"
	/// Feedback for user when their comment has been moderated
	/// English String: "Your comment has been moderated."
	/// </summary>
	public override string LabelCommentModerated => "規制対象のコメントです。";

	/// <summary>
	/// Key: "Label.EmailVerifiedTitle"
	/// English String: "Verify Your Email"
	/// </summary>
	public override string LabelEmailVerifiedTitle => "メールアドレスを認証";

	/// <summary>
	/// Key: "Label.FeatureNotAvailable"
	/// English String: "This feature is not available."
	/// </summary>
	public override string LabelFeatureNotAvailable => "この機能はご利用いただけません。";

	/// <summary>
	/// Key: "Label.LinksNotAllowedMessage"
	/// English String: "Comments should be about the item or place on which you are commenting. Links are not permitted."
	/// </summary>
	public override string LabelLinksNotAllowedMessage => "コメントはアイテムやプレースに関するものである必要があります。リンクは許可されていません。";

	/// <summary>
	/// Key: "Label.LinksNotAllowedTitle"
	/// English String: "Links Not Allowed"
	/// </summary>
	public override string LabelLinksNotAllowedTitle => "リンクが許可されていません";

	/// <summary>
	/// Key: "Label.MoreComments"
	/// English String: "More Comments"
	/// </summary>
	public override string LabelMoreComments => "他のコメント";

	/// <summary>
	/// Key: "Label.NoCommentsFound"
	/// English String: "No comments found."
	/// </summary>
	public override string LabelNoCommentsFound => "コメントが見つかりません。";

	/// <summary>
	/// Key: "Label.PostComment"
	/// English String: "Post Comment"
	/// </summary>
	public override string LabelPostComment => "コメントを投稿";

	/// <summary>
	/// Key: "Label.ReportAbuse"
	/// English String: "Report Abuse"
	/// </summary>
	public override string LabelReportAbuse => "規約違反を報告";

	/// <summary>
	/// Key: "Label.SeeMore"
	/// English String: "See More"
	/// </summary>
	public override string LabelSeeMore => "もっと見る";

	/// <summary>
	/// Key: "Label.SorryWrong"
	/// English String: "Sorry, something went wrong."
	/// </summary>
	public override string LabelSorryWrong => "申し訳ありません。問題が発生しました。";

	/// <summary>
	/// Key: "Label.Text"
	/// English String: "text"
	/// </summary>
	public override string LabelText => "テキスト";

	/// <summary>
	/// Key: "Label.TooManyChracters"
	/// English String: "Too many characters!"
	/// </summary>
	public override string LabelTooManyChracters => "文字数が多すぎます！";

	/// <summary>
	/// Key: "Label.TooManyNewLines"
	/// English String: "Too many newlines!"
	/// </summary>
	public override string LabelTooManyNewLines => "新しい行が多すぎます！";

	/// <summary>
	/// Key: "Label.UnknownError"
	/// English String: "Unknown error occurred."
	/// </summary>
	public override string LabelUnknownError => "不明なエラーが発生しました。";

	/// <summary>
	/// Key: "Label.UserFlooded"
	/// Feedback for users when they are flooded (both globally and per specific item) when posting comments for an item
	/// English String: "You are posting comments too fast. Wait a while before your next comment."
	/// </summary>
	public override string LabelUserFlooded => "コメント投稿の間隔が短かすぎます。しばらくしてから投稿してください。";

	/// <summary>
	/// Key: "Label.Username"
	/// English String: "username"
	/// </summary>
	public override string LabelUsername => "ユーザーネーム";

	/// <summary>
	/// Key: "Label.UserTooNew"
	/// Feedback for user when they try to post a comments for an item with a newly registered account
	/// English String: "Accounts must be older than 1 day to post comments."
	/// </summary>
	public override string LabelUserTooNew => "コメントを投稿するには、1日以上経過したアカウントである必要があります。";

	/// <summary>
	/// Key: "Label.Verify"
	/// English String: "Verify"
	/// </summary>
	public override string LabelVerify => "認証";

	/// <summary>
	/// Key: "Label.WriteAComment"
	/// English String: "Write a comment!"
	/// </summary>
	public override string LabelWriteAComment => "コメントを書きましょう！";

	public CommentsResources_ja_jp(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionLogin()
	{
		return "ログイン";
	}

	/// <summary>
	/// Key: "Description.LoginToComment"
	/// modal body text
	/// English String: "You must login to comment. Please {linkStart}login or register{linkEnd} to continue."
	/// </summary>
	public override string DescriptionLoginToComment(string linkStart, string linkEnd)
	{
		return $"コメントするにはログインする必要があります。 {linkStart}ログインまたは新規登録{linkEnd} してください。";
	}

	protected override string _GetTemplateForDescriptionLoginToComment()
	{
		return "コメントするにはログインする必要があります。 {linkStart}ログインまたは新規登録{linkEnd} してください。";
	}

	protected override string _GetTemplateForHeadingComments()
	{
		return "コメント";
	}

	protected override string _GetTemplateForHeadingLoginToComment()
	{
		return "ログインしてコメントする";
	}

	protected override string _GetTemplateForLabelAccountPageTitle()
	{
		return "アカウント";
	}

	protected override string _GetTemplateForLabelCancel()
	{
		return "キャンセル";
	}

	protected override string _GetTemplateForLabelCharactersRemaining()
	{
		return "文字残っています";
	}

	protected override string _GetTemplateForLabelCommentModerated()
	{
		return "規制対象のコメントです。";
	}

	/// <summary>
	/// Key: "Label.EmailVerifiedMessage"
	/// English String: "You must verify your email before you can comment. You can verify your email on the {accountPageLink} page."
	/// </summary>
	public override string LabelEmailVerifiedMessage(string accountPageLink)
	{
		return $"コメントを行う前にメールアドレスの認証を行う必要があります。メールアドレスの認証は、{accountPageLink} ページで行えます。";
	}

	protected override string _GetTemplateForLabelEmailVerifiedMessage()
	{
		return "コメントを行う前にメールアドレスの認証を行う必要があります。メールアドレスの認証は、{accountPageLink} ページで行えます。";
	}

	protected override string _GetTemplateForLabelEmailVerifiedTitle()
	{
		return "メールアドレスを認証";
	}

	protected override string _GetTemplateForLabelFeatureNotAvailable()
	{
		return "この機能はご利用いただけません。";
	}

	protected override string _GetTemplateForLabelLinksNotAllowedMessage()
	{
		return "コメントはアイテムやプレースに関するものである必要があります。リンクは許可されていません。";
	}

	protected override string _GetTemplateForLabelLinksNotAllowedTitle()
	{
		return "リンクが許可されていません";
	}

	protected override string _GetTemplateForLabelMoreComments()
	{
		return "他のコメント";
	}

	protected override string _GetTemplateForLabelNoCommentsFound()
	{
		return "コメントが見つかりません。";
	}

	protected override string _GetTemplateForLabelPostComment()
	{
		return "コメントを投稿";
	}

	protected override string _GetTemplateForLabelReportAbuse()
	{
		return "規約違反を報告";
	}

	protected override string _GetTemplateForLabelSeeMore()
	{
		return "もっと見る";
	}

	protected override string _GetTemplateForLabelSorryWrong()
	{
		return "申し訳ありません。問題が発生しました。";
	}

	protected override string _GetTemplateForLabelText()
	{
		return "テキスト";
	}

	protected override string _GetTemplateForLabelTooManyChracters()
	{
		return "文字数が多すぎます！";
	}

	protected override string _GetTemplateForLabelTooManyNewLines()
	{
		return "新しい行が多すぎます！";
	}

	protected override string _GetTemplateForLabelUnknownError()
	{
		return "不明なエラーが発生しました。";
	}

	protected override string _GetTemplateForLabelUserFlooded()
	{
		return "コメント投稿の間隔が短かすぎます。しばらくしてから投稿してください。";
	}

	protected override string _GetTemplateForLabelUsername()
	{
		return "ユーザーネーム";
	}

	protected override string _GetTemplateForLabelUserTooNew()
	{
		return "コメントを投稿するには、1日以上経過したアカウントである必要があります。";
	}

	protected override string _GetTemplateForLabelVerify()
	{
		return "認証";
	}

	protected override string _GetTemplateForLabelWriteAComment()
	{
		return "コメントを書きましょう！";
	}

	/// <summary>
	/// Key: "Label.XHoursAgo"
	/// English String: "{numberOfHours} hours ago"
	/// </summary>
	public override string LabelXHoursAgo(string numberOfHours)
	{
		return $"{numberOfHours} 時間前";
	}

	protected override string _GetTemplateForLabelXHoursAgo()
	{
		return "{numberOfHours} 時間前";
	}
}
