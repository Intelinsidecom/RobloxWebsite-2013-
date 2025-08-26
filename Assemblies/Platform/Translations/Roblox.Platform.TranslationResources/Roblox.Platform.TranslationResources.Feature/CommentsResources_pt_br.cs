namespace Roblox.Platform.TranslationResources.Feature {
    /// <summary>

/// This class overrides CommentsResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class CommentsResources_pt_br : CommentsResources_en_us, ICommentsResources, ITranslationResources
{
	/// <summary>
	/// Key: "Action.Login"
	/// button text
	/// English String: "Login"
	/// </summary>
	public override string ActionLogin => "Conectar-se";

	/// <summary>
	/// Key: "Heading.Comments"
	/// English String: "Comments"
	/// </summary>
	public override string HeadingComments => "ComentÃ¡rios";

	/// <summary>
	/// Key: "Heading.LoginToComment"
	/// modal heading
	/// English String: "Login to Comment"
	/// </summary>
	public override string HeadingLoginToComment => "Conecte-se para comentar";

	/// <summary>
	/// Key: "Label.AccountPageTitle"
	/// English String: "Account"
	/// </summary>
	public override string LabelAccountPageTitle => "Conta";

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
	public override string LabelCommentModerated => "Seu comentÃ¡rio foi moderado.";

	/// <summary>
	/// Key: "Label.EmailVerifiedTitle"
	/// English String: "Verify Your Email"
	/// </summary>
	public override string LabelEmailVerifiedTitle => "Verifique seu e-mail";

	/// <summary>
	/// Key: "Label.FeatureNotAvailable"
	/// English String: "This feature is not available."
	/// </summary>
	public override string LabelFeatureNotAvailable => "Esta funcionalidade nÃ£o estÃ¡ disponÃ­vel.";

	/// <summary>
	/// Key: "Label.LinksNotAllowedMessage"
	/// English String: "Comments should be about the item or place on which you are commenting. Links are not permitted."
	/// </summary>
	public override string LabelLinksNotAllowedMessage => "Os comentÃ¡rios devem ser sobre o item ou lugar do qual vocÃª estÃ¡ comentando. Links nÃ£o sÃ£o permitidos.";

	/// <summary>
	/// Key: "Label.LinksNotAllowedTitle"
	/// English String: "Links Not Allowed"
	/// </summary>
	public override string LabelLinksNotAllowedTitle => "Links nÃ£o permitidos";

	/// <summary>
	/// Key: "Label.MoreComments"
	/// English String: "More Comments"
	/// </summary>
	public override string LabelMoreComments => "Mais comentÃ¡rios";

	/// <summary>
	/// Key: "Label.NoCommentsFound"
	/// English String: "No comments found."
	/// </summary>
	public override string LabelNoCommentsFound => "Nenhum comentÃ¡rio encontrado.";

	/// <summary>
	/// Key: "Label.PostComment"
	/// English String: "Post Comment"
	/// </summary>
	public override string LabelPostComment => "Publicar comentÃ¡rio";

	/// <summary>
	/// Key: "Label.ReportAbuse"
	/// English String: "Report Abuse"
	/// </summary>
	public override string LabelReportAbuse => "Denunciar abuso";

	/// <summary>
	/// Key: "Label.SeeMore"
	/// English String: "See More"
	/// </summary>
	public override string LabelSeeMore => "Ver mais";

	/// <summary>
	/// Key: "Label.SorryWrong"
	/// English String: "Sorry, something went wrong."
	/// </summary>
	public override string LabelSorryWrong => "Ops! Algo deu errado.";

	/// <summary>
	/// Key: "Label.Text"
	/// English String: "text"
	/// </summary>
	public override string LabelText => "texto";

	/// <summary>
	/// Key: "Label.TooManyChracters"
	/// English String: "Too many characters!"
	/// </summary>
	public override string LabelTooManyChracters => "Caracteres demais!";

	/// <summary>
	/// Key: "Label.TooManyNewLines"
	/// English String: "Too many newlines!"
	/// </summary>
	public override string LabelTooManyNewLines => "Linhas demais!";

	/// <summary>
	/// Key: "Label.UnknownError"
	/// English String: "Unknown error occurred."
	/// </summary>
	public override string LabelUnknownError => "Um erro desconhecido ocorreu.";

	/// <summary>
	/// Key: "Label.UserFlooded"
	/// Feedback for users when they are flooded (both globally and per specific item) when posting comments for an item
	/// English String: "You are posting comments too fast. Wait a while before your next comment."
	/// </summary>
	public override string LabelUserFlooded => "VocÃª estÃ¡ publicando comentÃ¡rios rÃ¡pido demais. Espere um pouco antes do seu prÃ³ximo comentÃ¡rio.";

	/// <summary>
	/// Key: "Label.Username"
	/// English String: "username"
	/// </summary>
	public override string LabelUsername => "nome de usuÃ¡rio";

	/// <summary>
	/// Key: "Label.UserTooNew"
	/// Feedback for user when they try to post a comments for an item with a newly registered account
	/// English String: "Accounts must be older than 1 day to post comments."
	/// </summary>
	public override string LabelUserTooNew => "Contas devem existir hÃ¡ mais de 1 dia para publicarem comentÃ¡rios.";

	/// <summary>
	/// Key: "Label.Verify"
	/// English String: "Verify"
	/// </summary>
	public override string LabelVerify => "Verificar";

	/// <summary>
	/// Key: "Label.WriteAComment"
	/// English String: "Write a comment!"
	/// </summary>
	public override string LabelWriteAComment => "Escreva um comentÃ¡rio!";

	public CommentsResources_pt_br(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionLogin()
	{
		return "Conectar-se";
	}

	/// <summary>
	/// Key: "Description.LoginToComment"
	/// modal body text
	/// English String: "You must login to comment. Please {linkStart}login or register{linkEnd} to continue."
	/// </summary>
	public override string DescriptionLoginToComment(string linkStart, string linkEnd)
	{
		return $"VocÃª deve se conectar para comentar. {linkStart}Conecte-se ou cadastre-se{linkEnd} para continuar.";
	}

	protected override string _GetTemplateForDescriptionLoginToComment()
	{
		return "VocÃª deve se conectar para comentar. {linkStart}Conecte-se ou cadastre-se{linkEnd} para continuar.";
	}

	protected override string _GetTemplateForHeadingComments()
	{
		return "ComentÃ¡rios";
	}

	protected override string _GetTemplateForHeadingLoginToComment()
	{
		return "Conecte-se para comentar";
	}

	protected override string _GetTemplateForLabelAccountPageTitle()
	{
		return "Conta";
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
		return "Seu comentÃ¡rio foi moderado.";
	}

	/// <summary>
	/// Key: "Label.EmailVerifiedMessage"
	/// English String: "You must verify your email before you can comment. You can verify your email on the {accountPageLink} page."
	/// </summary>
	public override string LabelEmailVerifiedMessage(string accountPageLink)
	{
		return $"VocÃª precisa validar o seu e-mail antes de poder comentar. VocÃª pode verificar seu e-mail na pÃ¡gina {accountPageLink}.";
	}

	protected override string _GetTemplateForLabelEmailVerifiedMessage()
	{
		return "VocÃª precisa validar o seu e-mail antes de poder comentar. VocÃª pode verificar seu e-mail na pÃ¡gina {accountPageLink}.";
	}

	protected override string _GetTemplateForLabelEmailVerifiedTitle()
	{
		return "Verifique seu e-mail";
	}

	protected override string _GetTemplateForLabelFeatureNotAvailable()
	{
		return "Esta funcionalidade nÃ£o estÃ¡ disponÃ­vel.";
	}

	protected override string _GetTemplateForLabelLinksNotAllowedMessage()
	{
		return "Os comentÃ¡rios devem ser sobre o item ou lugar do qual vocÃª estÃ¡ comentando. Links nÃ£o sÃ£o permitidos.";
	}

	protected override string _GetTemplateForLabelLinksNotAllowedTitle()
	{
		return "Links nÃ£o permitidos";
	}

	protected override string _GetTemplateForLabelMoreComments()
	{
		return "Mais comentÃ¡rios";
	}

	protected override string _GetTemplateForLabelNoCommentsFound()
	{
		return "Nenhum comentÃ¡rio encontrado.";
	}

	protected override string _GetTemplateForLabelPostComment()
	{
		return "Publicar comentÃ¡rio";
	}

	protected override string _GetTemplateForLabelReportAbuse()
	{
		return "Denunciar abuso";
	}

	protected override string _GetTemplateForLabelSeeMore()
	{
		return "Ver mais";
	}

	protected override string _GetTemplateForLabelSorryWrong()
	{
		return "Ops! Algo deu errado.";
	}

	protected override string _GetTemplateForLabelText()
	{
		return "texto";
	}

	protected override string _GetTemplateForLabelTooManyChracters()
	{
		return "Caracteres demais!";
	}

	protected override string _GetTemplateForLabelTooManyNewLines()
	{
		return "Linhas demais!";
	}

	protected override string _GetTemplateForLabelUnknownError()
	{
		return "Um erro desconhecido ocorreu.";
	}

	protected override string _GetTemplateForLabelUserFlooded()
	{
		return "VocÃª estÃ¡ publicando comentÃ¡rios rÃ¡pido demais. Espere um pouco antes do seu prÃ³ximo comentÃ¡rio.";
	}

	protected override string _GetTemplateForLabelUsername()
	{
		return "nome de usuÃ¡rio";
	}

	protected override string _GetTemplateForLabelUserTooNew()
	{
		return "Contas devem existir hÃ¡ mais de 1 dia para publicarem comentÃ¡rios.";
	}

	protected override string _GetTemplateForLabelVerify()
	{
		return "Verificar";
	}

	protected override string _GetTemplateForLabelWriteAComment()
	{
		return "Escreva um comentÃ¡rio!";
	}

	/// <summary>
	/// Key: "Label.XHoursAgo"
	/// English String: "{numberOfHours} hours ago"
	/// </summary>
	public override string LabelXHoursAgo(string numberOfHours)
	{
		return $"HÃ¡ {numberOfHours} horas";
	}

	protected override string _GetTemplateForLabelXHoursAgo()
	{
		return "HÃ¡ {numberOfHours} horas";
	}
}


}
