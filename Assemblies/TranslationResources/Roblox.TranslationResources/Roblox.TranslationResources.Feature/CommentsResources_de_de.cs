namespace Roblox.TranslationResources.Feature;

/// <summary>
/// This class overrides CommentsResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class CommentsResources_de_de : CommentsResources_en_us, ICommentsResources, ITranslationResources
{
	/// <summary>
	/// Key: "Action.Login"
	/// button text
	/// English String: "Login"
	/// </summary>
	public override string ActionLogin => "Anmelden";

	/// <summary>
	/// Key: "Heading.Comments"
	/// English String: "Comments"
	/// </summary>
	public override string HeadingComments => "Kommentare";

	/// <summary>
	/// Key: "Heading.LoginToComment"
	/// modal heading
	/// English String: "Login to Comment"
	/// </summary>
	public override string HeadingLoginToComment => "Anmelden, um einen Kommentar zu posten";

	/// <summary>
	/// Key: "Label.AccountPageTitle"
	/// English String: "Account"
	/// </summary>
	public override string LabelAccountPageTitle => "Konto";

	/// <summary>
	/// Key: "Label.Cancel"
	/// English String: "Cancel"
	/// </summary>
	public override string LabelCancel => "Abbrechen";

	/// <summary>
	/// Key: "Label.CharactersRemaining"
	/// English String: "characters remaining"
	/// </summary>
	public override string LabelCharactersRemaining => "verbleibende Zeichen";

	/// <summary>
	/// Key: "Label.CommentModerated"
	/// Feedback for user when their comment has been moderated
	/// English String: "Your comment has been moderated."
	/// </summary>
	public override string LabelCommentModerated => "Dein Kommentar wurde moderiert.";

	/// <summary>
	/// Key: "Label.EmailVerifiedTitle"
	/// English String: "Verify Your Email"
	/// </summary>
	public override string LabelEmailVerifiedTitle => "Verifiziere deine E-Mail-Adresse";

	/// <summary>
	/// Key: "Label.FeatureNotAvailable"
	/// English String: "This feature is not available."
	/// </summary>
	public override string LabelFeatureNotAvailable => "Dieses Feature ist nicht verfügbar.";

	/// <summary>
	/// Key: "Label.LinksNotAllowedMessage"
	/// English String: "Comments should be about the item or place on which you are commenting. Links are not permitted."
	/// </summary>
	public override string LabelLinksNotAllowedMessage => "Kommentare sollten auf den Artikel oder Ort Bezug nehmen, zu dem du etwas sagen möchtest. Links sind nicht erlaubt.";

	/// <summary>
	/// Key: "Label.LinksNotAllowedTitle"
	/// English String: "Links Not Allowed"
	/// </summary>
	public override string LabelLinksNotAllowedTitle => "Keine Links erlaubt";

	/// <summary>
	/// Key: "Label.MoreComments"
	/// English String: "More Comments"
	/// </summary>
	public override string LabelMoreComments => "Mehr Kommentare";

	/// <summary>
	/// Key: "Label.NoCommentsFound"
	/// English String: "No comments found."
	/// </summary>
	public override string LabelNoCommentsFound => "Keine Kommentare gefunden.";

	/// <summary>
	/// Key: "Label.PostComment"
	/// English String: "Post Comment"
	/// </summary>
	public override string LabelPostComment => "Kommentar posten";

	/// <summary>
	/// Key: "Label.ReportAbuse"
	/// English String: "Report Abuse"
	/// </summary>
	public override string LabelReportAbuse => "Verstoß melden";

	/// <summary>
	/// Key: "Label.SeeMore"
	/// English String: "See More"
	/// </summary>
	public override string LabelSeeMore => "Mehr ansehen";

	/// <summary>
	/// Key: "Label.SorryWrong"
	/// English String: "Sorry, something went wrong."
	/// </summary>
	public override string LabelSorryWrong => "Tut uns leid, ein Problem ist aufgetreten.";

	/// <summary>
	/// Key: "Label.Text"
	/// English String: "text"
	/// </summary>
	public override string LabelText => "Text";

	/// <summary>
	/// Key: "Label.TooManyChracters"
	/// English String: "Too many characters!"
	/// </summary>
	public override string LabelTooManyChracters => "Zu viele Zeichen!";

	/// <summary>
	/// Key: "Label.TooManyNewLines"
	/// English String: "Too many newlines!"
	/// </summary>
	public override string LabelTooManyNewLines => "Zu viele Zeilenumbrüche!";

	/// <summary>
	/// Key: "Label.UnknownError"
	/// English String: "Unknown error occurred."
	/// </summary>
	public override string LabelUnknownError => "Ein unbekannter Fehler ist aufgetreten.";

	/// <summary>
	/// Key: "Label.UserFlooded"
	/// Feedback for users when they are flooded (both globally and per specific item) when posting comments for an item
	/// English String: "You are posting comments too fast. Wait a while before your next comment."
	/// </summary>
	public override string LabelUserFlooded => "Du veröffentlichst Kommentare zu schnell. Warte eine Weile, bevor du den nächsten Kommentar eingibst.";

	/// <summary>
	/// Key: "Label.Username"
	/// English String: "username"
	/// </summary>
	public override string LabelUsername => "Benutzername";

	/// <summary>
	/// Key: "Label.UserTooNew"
	/// Feedback for user when they try to post a comments for an item with a newly registered account
	/// English String: "Accounts must be older than 1 day to post comments."
	/// </summary>
	public override string LabelUserTooNew => "Dein Konto muss älter als 1 Tag sein, damit du ein Kommentar hinterlassen kannst.";

	/// <summary>
	/// Key: "Label.Verify"
	/// English String: "Verify"
	/// </summary>
	public override string LabelVerify => "Verifizieren";

	/// <summary>
	/// Key: "Label.WriteAComment"
	/// English String: "Write a comment!"
	/// </summary>
	public override string LabelWriteAComment => "Verfasse einen Kommentar!";

	public CommentsResources_de_de(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionLogin()
	{
		return "Anmelden";
	}

	/// <summary>
	/// Key: "Description.LoginToComment"
	/// modal body text
	/// English String: "You must login to comment. Please {linkStart}login or register{linkEnd} to continue."
	/// </summary>
	public override string DescriptionLoginToComment(string linkStart, string linkEnd)
	{
		return $"Melde dich an, um einen Kommentar zu posten. Bitte {linkStart}anmelden oder registrieren{linkEnd}, um fortzufahren.";
	}

	protected override string _GetTemplateForDescriptionLoginToComment()
	{
		return "Melde dich an, um einen Kommentar zu posten. Bitte {linkStart}anmelden oder registrieren{linkEnd}, um fortzufahren.";
	}

	protected override string _GetTemplateForHeadingComments()
	{
		return "Kommentare";
	}

	protected override string _GetTemplateForHeadingLoginToComment()
	{
		return "Anmelden, um einen Kommentar zu posten";
	}

	protected override string _GetTemplateForLabelAccountPageTitle()
	{
		return "Konto";
	}

	protected override string _GetTemplateForLabelCancel()
	{
		return "Abbrechen";
	}

	protected override string _GetTemplateForLabelCharactersRemaining()
	{
		return "verbleibende Zeichen";
	}

	protected override string _GetTemplateForLabelCommentModerated()
	{
		return "Dein Kommentar wurde moderiert.";
	}

	/// <summary>
	/// Key: "Label.EmailVerifiedMessage"
	/// English String: "You must verify your email before you can comment. You can verify your email on the {accountPageLink} page."
	/// </summary>
	public override string LabelEmailVerifiedMessage(string accountPageLink)
	{
		return $"Bevor du Kommentare verfassen kannst, musst du deine E-Mail-Adresse verifizieren. Dies kannst du auf der Seite „{accountPageLink}“ tun.";
	}

	protected override string _GetTemplateForLabelEmailVerifiedMessage()
	{
		return "Bevor du Kommentare verfassen kannst, musst du deine E-Mail-Adresse verifizieren. Dies kannst du auf der Seite „{accountPageLink}“ tun.";
	}

	protected override string _GetTemplateForLabelEmailVerifiedTitle()
	{
		return "Verifiziere deine E-Mail-Adresse";
	}

	protected override string _GetTemplateForLabelFeatureNotAvailable()
	{
		return "Dieses Feature ist nicht verfügbar.";
	}

	protected override string _GetTemplateForLabelLinksNotAllowedMessage()
	{
		return "Kommentare sollten auf den Artikel oder Ort Bezug nehmen, zu dem du etwas sagen möchtest. Links sind nicht erlaubt.";
	}

	protected override string _GetTemplateForLabelLinksNotAllowedTitle()
	{
		return "Keine Links erlaubt";
	}

	protected override string _GetTemplateForLabelMoreComments()
	{
		return "Mehr Kommentare";
	}

	protected override string _GetTemplateForLabelNoCommentsFound()
	{
		return "Keine Kommentare gefunden.";
	}

	protected override string _GetTemplateForLabelPostComment()
	{
		return "Kommentar posten";
	}

	protected override string _GetTemplateForLabelReportAbuse()
	{
		return "Verstoß melden";
	}

	protected override string _GetTemplateForLabelSeeMore()
	{
		return "Mehr ansehen";
	}

	protected override string _GetTemplateForLabelSorryWrong()
	{
		return "Tut uns leid, ein Problem ist aufgetreten.";
	}

	protected override string _GetTemplateForLabelText()
	{
		return "Text";
	}

	protected override string _GetTemplateForLabelTooManyChracters()
	{
		return "Zu viele Zeichen!";
	}

	protected override string _GetTemplateForLabelTooManyNewLines()
	{
		return "Zu viele Zeilenumbrüche!";
	}

	protected override string _GetTemplateForLabelUnknownError()
	{
		return "Ein unbekannter Fehler ist aufgetreten.";
	}

	protected override string _GetTemplateForLabelUserFlooded()
	{
		return "Du veröffentlichst Kommentare zu schnell. Warte eine Weile, bevor du den nächsten Kommentar eingibst.";
	}

	protected override string _GetTemplateForLabelUsername()
	{
		return "Benutzername";
	}

	protected override string _GetTemplateForLabelUserTooNew()
	{
		return "Dein Konto muss älter als 1 Tag sein, damit du ein Kommentar hinterlassen kannst.";
	}

	protected override string _GetTemplateForLabelVerify()
	{
		return "Verifizieren";
	}

	protected override string _GetTemplateForLabelWriteAComment()
	{
		return "Verfasse einen Kommentar!";
	}

	/// <summary>
	/// Key: "Label.XHoursAgo"
	/// English String: "{numberOfHours} hours ago"
	/// </summary>
	public override string LabelXHoursAgo(string numberOfHours)
	{
		return $"vor {numberOfHours} Stunden";
	}

	protected override string _GetTemplateForLabelXHoursAgo()
	{
		return "vor {numberOfHours} Stunden";
	}
}
