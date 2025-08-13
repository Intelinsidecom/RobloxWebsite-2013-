namespace Roblox.TranslationResources.Feature;

/// <summary>
/// This class overrides CommentsResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class CommentsResources_fr_fr : CommentsResources_en_us, ICommentsResources, ITranslationResources
{
	/// <summary>
	/// Key: "Action.Login"
	/// button text
	/// English String: "Login"
	/// </summary>
	public override string ActionLogin => "Connexion";

	/// <summary>
	/// Key: "Heading.Comments"
	/// English String: "Comments"
	/// </summary>
	public override string HeadingComments => "Commentaires";

	/// <summary>
	/// Key: "Heading.LoginToComment"
	/// modal heading
	/// English String: "Login to Comment"
	/// </summary>
	public override string HeadingLoginToComment => "Connectez-vous pour laisser un commentaire";

	/// <summary>
	/// Key: "Label.AccountPageTitle"
	/// English String: "Account"
	/// </summary>
	public override string LabelAccountPageTitle => "Compte";

	/// <summary>
	/// Key: "Label.Cancel"
	/// English String: "Cancel"
	/// </summary>
	public override string LabelCancel => "Annuler";

	/// <summary>
	/// Key: "Label.CharactersRemaining"
	/// English String: "characters remaining"
	/// </summary>
	public override string LabelCharactersRemaining => "caractères restants";

	/// <summary>
	/// Key: "Label.CommentModerated"
	/// Feedback for user when their comment has been moderated
	/// English String: "Your comment has been moderated."
	/// </summary>
	public override string LabelCommentModerated => "Ton commentaire a été modéré.";

	/// <summary>
	/// Key: "Label.EmailVerifiedTitle"
	/// English String: "Verify Your Email"
	/// </summary>
	public override string LabelEmailVerifiedTitle => "Vérifie ton adresse e-mail";

	/// <summary>
	/// Key: "Label.FeatureNotAvailable"
	/// English String: "This feature is not available."
	/// </summary>
	public override string LabelFeatureNotAvailable => "Cette fonctionnalité n'est pas disponible.";

	/// <summary>
	/// Key: "Label.LinksNotAllowedMessage"
	/// English String: "Comments should be about the item or place on which you are commenting. Links are not permitted."
	/// </summary>
	public override string LabelLinksNotAllowedMessage => "Les commentaires doivent porter sur l'objet ou l'emplacement que vous commentez. Les liens ne sont pas autorisés.";

	/// <summary>
	/// Key: "Label.LinksNotAllowedTitle"
	/// English String: "Links Not Allowed"
	/// </summary>
	public override string LabelLinksNotAllowedTitle => "Liens non autorisés";

	/// <summary>
	/// Key: "Label.MoreComments"
	/// English String: "More Comments"
	/// </summary>
	public override string LabelMoreComments => "Plus de commentaires";

	/// <summary>
	/// Key: "Label.NoCommentsFound"
	/// English String: "No comments found."
	/// </summary>
	public override string LabelNoCommentsFound => "Aucun commentaire.";

	/// <summary>
	/// Key: "Label.PostComment"
	/// English String: "Post Comment"
	/// </summary>
	public override string LabelPostComment => "Publier le commentaire";

	/// <summary>
	/// Key: "Label.ReportAbuse"
	/// English String: "Report Abuse"
	/// </summary>
	public override string LabelReportAbuse => "Signaler un comportement abusif";

	/// <summary>
	/// Key: "Label.SeeMore"
	/// English String: "See More"
	/// </summary>
	public override string LabelSeeMore => "Afficher plus";

	/// <summary>
	/// Key: "Label.SorryWrong"
	/// English String: "Sorry, something went wrong."
	/// </summary>
	public override string LabelSorryWrong => "Désolé, un problème est survenu.";

	/// <summary>
	/// Key: "Label.Text"
	/// English String: "text"
	/// </summary>
	public override string LabelText => "texte";

	/// <summary>
	/// Key: "Label.TooManyChracters"
	/// English String: "Too many characters!"
	/// </summary>
	public override string LabelTooManyChracters => "Trop de caractères\u00a0!";

	/// <summary>
	/// Key: "Label.TooManyNewLines"
	/// English String: "Too many newlines!"
	/// </summary>
	public override string LabelTooManyNewLines => "Trop de sauts de ligne\u00a0!";

	/// <summary>
	/// Key: "Label.UnknownError"
	/// English String: "Unknown error occurred."
	/// </summary>
	public override string LabelUnknownError => "Une erreur inconnue s'est produite.";

	/// <summary>
	/// Key: "Label.UserFlooded"
	/// Feedback for users when they are flooded (both globally and per specific item) when posting comments for an item
	/// English String: "You are posting comments too fast. Wait a while before your next comment."
	/// </summary>
	public override string LabelUserFlooded => "Vous publiez trop de commentaires. Attendez un moment avant d'en écrire un nouveau.";

	/// <summary>
	/// Key: "Label.Username"
	/// English String: "username"
	/// </summary>
	public override string LabelUsername => "nom d'utilisateur";

	/// <summary>
	/// Key: "Label.UserTooNew"
	/// Feedback for user when they try to post a comments for an item with a newly registered account
	/// English String: "Accounts must be older than 1 day to post comments."
	/// </summary>
	public override string LabelUserTooNew => "Un compte doit dater de plus d'un jour pour publier des commentaires.";

	/// <summary>
	/// Key: "Label.Verify"
	/// English String: "Verify"
	/// </summary>
	public override string LabelVerify => "Vérifier";

	/// <summary>
	/// Key: "Label.WriteAComment"
	/// English String: "Write a comment!"
	/// </summary>
	public override string LabelWriteAComment => "Rédigez un commentaire\u00a0!";

	public CommentsResources_fr_fr(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionLogin()
	{
		return "Connexion";
	}

	/// <summary>
	/// Key: "Description.LoginToComment"
	/// modal body text
	/// English String: "You must login to comment. Please {linkStart}login or register{linkEnd} to continue."
	/// </summary>
	public override string DescriptionLoginToComment(string linkStart, string linkEnd)
	{
		return $"Vous devez vous connecter pour laisser un commentaire. Veuillez {linkStart}vous connecter ou vous inscrire{linkEnd} pour continuer.";
	}

	protected override string _GetTemplateForDescriptionLoginToComment()
	{
		return "Vous devez vous connecter pour laisser un commentaire. Veuillez {linkStart}vous connecter ou vous inscrire{linkEnd} pour continuer.";
	}

	protected override string _GetTemplateForHeadingComments()
	{
		return "Commentaires";
	}

	protected override string _GetTemplateForHeadingLoginToComment()
	{
		return "Connectez-vous pour laisser un commentaire";
	}

	protected override string _GetTemplateForLabelAccountPageTitle()
	{
		return "Compte";
	}

	protected override string _GetTemplateForLabelCancel()
	{
		return "Annuler";
	}

	protected override string _GetTemplateForLabelCharactersRemaining()
	{
		return "caractères restants";
	}

	protected override string _GetTemplateForLabelCommentModerated()
	{
		return "Ton commentaire a été modéré.";
	}

	/// <summary>
	/// Key: "Label.EmailVerifiedMessage"
	/// English String: "You must verify your email before you can comment. You can verify your email on the {accountPageLink} page."
	/// </summary>
	public override string LabelEmailVerifiedMessage(string accountPageLink)
	{
		return $"Tu dois vérifier ton adresse e-mail avant de pouvoir écrire un commentaire. Pour ce faire, rendez-vous sur la page\u00a0: {accountPageLink}.";
	}

	protected override string _GetTemplateForLabelEmailVerifiedMessage()
	{
		return "Tu dois vérifier ton adresse e-mail avant de pouvoir écrire un commentaire. Pour ce faire, rendez-vous sur la page\u00a0: {accountPageLink}.";
	}

	protected override string _GetTemplateForLabelEmailVerifiedTitle()
	{
		return "Vérifie ton adresse e-mail";
	}

	protected override string _GetTemplateForLabelFeatureNotAvailable()
	{
		return "Cette fonctionnalité n'est pas disponible.";
	}

	protected override string _GetTemplateForLabelLinksNotAllowedMessage()
	{
		return "Les commentaires doivent porter sur l'objet ou l'emplacement que vous commentez. Les liens ne sont pas autorisés.";
	}

	protected override string _GetTemplateForLabelLinksNotAllowedTitle()
	{
		return "Liens non autorisés";
	}

	protected override string _GetTemplateForLabelMoreComments()
	{
		return "Plus de commentaires";
	}

	protected override string _GetTemplateForLabelNoCommentsFound()
	{
		return "Aucun commentaire.";
	}

	protected override string _GetTemplateForLabelPostComment()
	{
		return "Publier le commentaire";
	}

	protected override string _GetTemplateForLabelReportAbuse()
	{
		return "Signaler un comportement abusif";
	}

	protected override string _GetTemplateForLabelSeeMore()
	{
		return "Afficher plus";
	}

	protected override string _GetTemplateForLabelSorryWrong()
	{
		return "Désolé, un problème est survenu.";
	}

	protected override string _GetTemplateForLabelText()
	{
		return "texte";
	}

	protected override string _GetTemplateForLabelTooManyChracters()
	{
		return "Trop de caractères\u00a0!";
	}

	protected override string _GetTemplateForLabelTooManyNewLines()
	{
		return "Trop de sauts de ligne\u00a0!";
	}

	protected override string _GetTemplateForLabelUnknownError()
	{
		return "Une erreur inconnue s'est produite.";
	}

	protected override string _GetTemplateForLabelUserFlooded()
	{
		return "Vous publiez trop de commentaires. Attendez un moment avant d'en écrire un nouveau.";
	}

	protected override string _GetTemplateForLabelUsername()
	{
		return "nom d'utilisateur";
	}

	protected override string _GetTemplateForLabelUserTooNew()
	{
		return "Un compte doit dater de plus d'un jour pour publier des commentaires.";
	}

	protected override string _GetTemplateForLabelVerify()
	{
		return "Vérifier";
	}

	protected override string _GetTemplateForLabelWriteAComment()
	{
		return "Rédigez un commentaire\u00a0!";
	}

	/// <summary>
	/// Key: "Label.XHoursAgo"
	/// English String: "{numberOfHours} hours ago"
	/// </summary>
	public override string LabelXHoursAgo(string numberOfHours)
	{
		return $"Il y a {numberOfHours}\u00a0heures";
	}

	protected override string _GetTemplateForLabelXHoursAgo()
	{
		return "Il y a {numberOfHours}\u00a0heures";
	}
}
