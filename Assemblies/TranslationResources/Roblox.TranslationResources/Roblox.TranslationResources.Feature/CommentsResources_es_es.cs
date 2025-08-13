namespace Roblox.TranslationResources.Feature;

/// <summary>
/// This class overrides CommentsResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class CommentsResources_es_es : CommentsResources_en_us, ICommentsResources, ITranslationResources
{
	/// <summary>
	/// Key: "Action.Login"
	/// button text
	/// English String: "Login"
	/// </summary>
	public override string ActionLogin => "Iniciar sesión";

	/// <summary>
	/// Key: "Heading.Comments"
	/// English String: "Comments"
	/// </summary>
	public override string HeadingComments => "Comentarios";

	/// <summary>
	/// Key: "Heading.LoginToComment"
	/// modal heading
	/// English String: "Login to Comment"
	/// </summary>
	public override string HeadingLoginToComment => "Iniciar sesión para dejar un comentario";

	/// <summary>
	/// Key: "Label.AccountPageTitle"
	/// English String: "Account"
	/// </summary>
	public override string LabelAccountPageTitle => "Cuenta";

	/// <summary>
	/// Key: "Label.Cancel"
	/// English String: "Cancel"
	/// </summary>
	public override string LabelCancel => "Cancelar";

	/// <summary>
	/// Key: "Label.CharactersRemaining"
	/// English String: "characters remaining"
	/// </summary>
	public override string LabelCharactersRemaining => "caracteres restantes";

	/// <summary>
	/// Key: "Label.CommentModerated"
	/// Feedback for user when their comment has been moderated
	/// English String: "Your comment has been moderated."
	/// </summary>
	public override string LabelCommentModerated => "Tu comentario ha sido moderado.";

	/// <summary>
	/// Key: "Label.EmailVerifiedTitle"
	/// English String: "Verify Your Email"
	/// </summary>
	public override string LabelEmailVerifiedTitle => "Verifica tu correo electrónico";

	/// <summary>
	/// Key: "Label.FeatureNotAvailable"
	/// English String: "This feature is not available."
	/// </summary>
	public override string LabelFeatureNotAvailable => "Esta función no está disponible.";

	/// <summary>
	/// Key: "Label.LinksNotAllowedMessage"
	/// English String: "Comments should be about the item or place on which you are commenting. Links are not permitted."
	/// </summary>
	public override string LabelLinksNotAllowedMessage => "Los comentarios deben referirse al objeto o lugar del cual estás comentando. No se permite publicar enlaces.";

	/// <summary>
	/// Key: "Label.LinksNotAllowedTitle"
	/// English String: "Links Not Allowed"
	/// </summary>
	public override string LabelLinksNotAllowedTitle => "No se permiten enlaces";

	/// <summary>
	/// Key: "Label.MoreComments"
	/// English String: "More Comments"
	/// </summary>
	public override string LabelMoreComments => "Más comentarios";

	/// <summary>
	/// Key: "Label.NoCommentsFound"
	/// English String: "No comments found."
	/// </summary>
	public override string LabelNoCommentsFound => "No hay comentarios.";

	/// <summary>
	/// Key: "Label.PostComment"
	/// English String: "Post Comment"
	/// </summary>
	public override string LabelPostComment => "Publicar comentario";

	/// <summary>
	/// Key: "Label.ReportAbuse"
	/// English String: "Report Abuse"
	/// </summary>
	public override string LabelReportAbuse => "Denunciar abuso";

	/// <summary>
	/// Key: "Label.SeeMore"
	/// English String: "See More"
	/// </summary>
	public override string LabelSeeMore => "Ver más";

	/// <summary>
	/// Key: "Label.SorryWrong"
	/// English String: "Sorry, something went wrong."
	/// </summary>
	public override string LabelSorryWrong => "Lo sentimos, algo ha ido mal.";

	/// <summary>
	/// Key: "Label.Text"
	/// English String: "text"
	/// </summary>
	public override string LabelText => "texto";

	/// <summary>
	/// Key: "Label.TooManyChracters"
	/// English String: "Too many characters!"
	/// </summary>
	public override string LabelTooManyChracters => "Demasiados caracteres";

	/// <summary>
	/// Key: "Label.TooManyNewLines"
	/// English String: "Too many newlines!"
	/// </summary>
	public override string LabelTooManyNewLines => "Demasiadas líneas nuevas";

	/// <summary>
	/// Key: "Label.UnknownError"
	/// English String: "Unknown error occurred."
	/// </summary>
	public override string LabelUnknownError => "Se ha producido un error desconocido.";

	/// <summary>
	/// Key: "Label.UserFlooded"
	/// Feedback for users when they are flooded (both globally and per specific item) when posting comments for an item
	/// English String: "You are posting comments too fast. Wait a while before your next comment."
	/// </summary>
	public override string LabelUserFlooded => "Estás publicando comentarios demasiado rápido. Espera unos minutos antes de publicar el siguiente.";

	/// <summary>
	/// Key: "Label.Username"
	/// English String: "username"
	/// </summary>
	public override string LabelUsername => "nombre de usuario";

	/// <summary>
	/// Key: "Label.UserTooNew"
	/// Feedback for user when they try to post a comments for an item with a newly registered account
	/// English String: "Accounts must be older than 1 day to post comments."
	/// </summary>
	public override string LabelUserTooNew => "Las cuentas deben tener una antigüedad superior a un día para publicar comentarios.";

	/// <summary>
	/// Key: "Label.Verify"
	/// English String: "Verify"
	/// </summary>
	public override string LabelVerify => "Verificar";

	/// <summary>
	/// Key: "Label.WriteAComment"
	/// English String: "Write a comment!"
	/// </summary>
	public override string LabelWriteAComment => "¡Escribe un comentario!";

	public CommentsResources_es_es(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionLogin()
	{
		return "Iniciar sesión";
	}

	/// <summary>
	/// Key: "Description.LoginToComment"
	/// modal body text
	/// English String: "You must login to comment. Please {linkStart}login or register{linkEnd} to continue."
	/// </summary>
	public override string DescriptionLoginToComment(string linkStart, string linkEnd)
	{
		return $"Debes iniciar sesión para dejar un comentario. {linkStart}Inicia sesión o regístrate{linkEnd} para continuar.";
	}

	protected override string _GetTemplateForDescriptionLoginToComment()
	{
		return "Debes iniciar sesión para dejar un comentario. {linkStart}Inicia sesión o regístrate{linkEnd} para continuar.";
	}

	protected override string _GetTemplateForHeadingComments()
	{
		return "Comentarios";
	}

	protected override string _GetTemplateForHeadingLoginToComment()
	{
		return "Iniciar sesión para dejar un comentario";
	}

	protected override string _GetTemplateForLabelAccountPageTitle()
	{
		return "Cuenta";
	}

	protected override string _GetTemplateForLabelCancel()
	{
		return "Cancelar";
	}

	protected override string _GetTemplateForLabelCharactersRemaining()
	{
		return "caracteres restantes";
	}

	protected override string _GetTemplateForLabelCommentModerated()
	{
		return "Tu comentario ha sido moderado.";
	}

	/// <summary>
	/// Key: "Label.EmailVerifiedMessage"
	/// English String: "You must verify your email before you can comment. You can verify your email on the {accountPageLink} page."
	/// </summary>
	public override string LabelEmailVerifiedMessage(string accountPageLink)
	{
		return $"Debes verificar tu correo electrónico para poder publicar comentarios. Puedes verificar tu correo electrónico en {accountPageLink}.";
	}

	protected override string _GetTemplateForLabelEmailVerifiedMessage()
	{
		return "Debes verificar tu correo electrónico para poder publicar comentarios. Puedes verificar tu correo electrónico en {accountPageLink}.";
	}

	protected override string _GetTemplateForLabelEmailVerifiedTitle()
	{
		return "Verifica tu correo electrónico";
	}

	protected override string _GetTemplateForLabelFeatureNotAvailable()
	{
		return "Esta función no está disponible.";
	}

	protected override string _GetTemplateForLabelLinksNotAllowedMessage()
	{
		return "Los comentarios deben referirse al objeto o lugar del cual estás comentando. No se permite publicar enlaces.";
	}

	protected override string _GetTemplateForLabelLinksNotAllowedTitle()
	{
		return "No se permiten enlaces";
	}

	protected override string _GetTemplateForLabelMoreComments()
	{
		return "Más comentarios";
	}

	protected override string _GetTemplateForLabelNoCommentsFound()
	{
		return "No hay comentarios.";
	}

	protected override string _GetTemplateForLabelPostComment()
	{
		return "Publicar comentario";
	}

	protected override string _GetTemplateForLabelReportAbuse()
	{
		return "Denunciar abuso";
	}

	protected override string _GetTemplateForLabelSeeMore()
	{
		return "Ver más";
	}

	protected override string _GetTemplateForLabelSorryWrong()
	{
		return "Lo sentimos, algo ha ido mal.";
	}

	protected override string _GetTemplateForLabelText()
	{
		return "texto";
	}

	protected override string _GetTemplateForLabelTooManyChracters()
	{
		return "Demasiados caracteres";
	}

	protected override string _GetTemplateForLabelTooManyNewLines()
	{
		return "Demasiadas líneas nuevas";
	}

	protected override string _GetTemplateForLabelUnknownError()
	{
		return "Se ha producido un error desconocido.";
	}

	protected override string _GetTemplateForLabelUserFlooded()
	{
		return "Estás publicando comentarios demasiado rápido. Espera unos minutos antes de publicar el siguiente.";
	}

	protected override string _GetTemplateForLabelUsername()
	{
		return "nombre de usuario";
	}

	protected override string _GetTemplateForLabelUserTooNew()
	{
		return "Las cuentas deben tener una antigüedad superior a un día para publicar comentarios.";
	}

	protected override string _GetTemplateForLabelVerify()
	{
		return "Verificar";
	}

	protected override string _GetTemplateForLabelWriteAComment()
	{
		return "¡Escribe un comentario!";
	}

	/// <summary>
	/// Key: "Label.XHoursAgo"
	/// English String: "{numberOfHours} hours ago"
	/// </summary>
	public override string LabelXHoursAgo(string numberOfHours)
	{
		return $"hace {numberOfHours} horas";
	}

	protected override string _GetTemplateForLabelXHoursAgo()
	{
		return "hace {numberOfHours} horas";
	}
}
