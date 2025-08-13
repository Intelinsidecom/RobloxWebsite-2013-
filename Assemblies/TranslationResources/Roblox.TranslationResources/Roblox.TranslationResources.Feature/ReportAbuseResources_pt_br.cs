namespace Roblox.TranslationResources.Feature;

/// <summary>
/// This class overrides ReportAbuseResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class ReportAbuseResources_pt_br : ReportAbuseResources_en_us, IReportAbuseResources, ITranslationResources
{
	/// <summary>
	/// Key: "Action.Close"
	/// English String: "Close"
	/// </summary>
	public override string ActionClose => "Fechar";

	/// <summary>
	/// Key: "Action.ReportAbuse"
	/// English String: "Report Abuse"
	/// </summary>
	public override string ActionReportAbuse => "Denunciar abuso";

	/// <summary>
	/// Key: "Action.Submit"
	/// English String: "Submit"
	/// </summary>
	public override string ActionSubmit => "Enviar";

	/// <summary>
	/// Key: "Example.Comment"
	/// English String: "Comment (optional)..."
	/// </summary>
	public override string ExampleComment => "Comentário (opcional)...";

	/// <summary>
	/// Key: "Heading.ReportAbuse"
	/// English String: "Report Abuse"
	/// </summary>
	public override string HeadingReportAbuse => "Denunciar abuso";

	/// <summary>
	/// Key: "Heading.Success"
	/// English String: "Thank You!"
	/// </summary>
	public override string HeadingSuccess => "Obrigado!";

	/// <summary>
	/// Key: "Label.AllRulesLink"
	/// English String: "See all rules."
	/// </summary>
	public override string LabelAllRulesLink => "Ver todas as regras.";

	/// <summary>
	/// Key: "Label.BlockWarning"
	/// English String: "Users who don't follow the rules will get a warning at first but if they keep it up we may ask them to not come to Roblox anymore. That way we can keep Roblox fun and safe!"
	/// </summary>
	public override string LabelBlockWarning => "Os usuários que não seguirem as regras serão avisados, mas se continuarem, vamos pedir para que não voltem mais ao Roblox. Desta forma poderemos manter o Roblox um lugar divertido e seguro!";

	/// <summary>
	/// Key: "Label.CategoryBullying"
	/// English String: "Bullying, Harassment, Hate Speech"
	/// </summary>
	public override string LabelCategoryBullying => "Bullying, assédio, descriminação";

	/// <summary>
	/// Key: "Label.CategoryBullyingV2"
	/// English String: "Bullying, Harassment, Discrimination"
	/// </summary>
	public override string LabelCategoryBullyingV2 => "Bullying, assédio, descriminação";

	/// <summary>
	/// Key: "Label.CategoryContent"
	/// English String: "Inappropriate Content - Place, Image, Model"
	/// </summary>
	public override string LabelCategoryContent => "Conteúdo inapropriado - Lugar, imagem, modelo";

	/// <summary>
	/// Key: "Label.CategoryDating"
	/// English String: "Dating"
	/// </summary>
	public override string LabelCategoryDating => "Namoro";

	public override string LabelCategoryInappropriate => "Linguajar inapropriado - Palavrões e conteúdo adulto";

	/// <summary>
	/// Key: "Label.CategoryOther"
	/// English String: "Other rule violation"
	/// </summary>
	public override string LabelCategoryOther => "Outras violações de regras";

	/// <summary>
	/// Key: "Label.CategoryPrivateInfo"
	/// English String: "Asking for or Giving Private Information"
	/// </summary>
	public override string LabelCategoryPrivateInfo => "Oferecer ou pedir informações pessoais";

	/// <summary>
	/// Key: "Label.CategoryScamming"
	/// English String: "Exploiting, Cheating, Scamming"
	/// </summary>
	public override string LabelCategoryScamming => "Exploração indevida, trapaça, esquema malicioso";

	/// <summary>
	/// Key: "Label.CategoryTheft"
	/// English String: "Account Theft - Phishing, Hacking, Trading"
	/// </summary>
	public override string LabelCategoryTheft => "Roubo de conta - Phishing, hacking, troca";

	public override string LabelCategoryThreats => "Ameaças na vida real e de suicídio";

	/// <summary>
	/// Key: "Label.Comment"
	/// English String: "Comment:"
	/// </summary>
	public override string LabelComment => "Comentário:";

	/// <summary>
	/// Key: "Label.DeletePost"
	/// English String: "Delete Post (and any replies)"
	/// </summary>
	public override string LabelDeletePost => "Excluir publicação (e respostas)";

	/// <summary>
	/// Key: "Label.LeaveUnchanged"
	/// English String: "Leave post unchanged"
	/// </summary>
	public override string LabelLeaveUnchanged => "Deixar publicação inalterada";

	/// <summary>
	/// Key: "Label.ModCategoryAdultContent"
	/// English String: "Adult Content"
	/// </summary>
	public override string LabelModCategoryAdultContent => "Conteúdo adulto";

	/// <summary>
	/// Key: "Label.ModCategoryAdvertisement"
	/// English String: "Advertisement"
	/// </summary>
	public override string LabelModCategoryAdvertisement => "Propaganda";

	/// <summary>
	/// Key: "Label.ModCategoryHarrasment"
	/// English String: "Harrasment"
	/// </summary>
	public override string LabelModCategoryHarrasment => "Assédio";

	/// <summary>
	/// Key: "Label.ModCategoryInappropriate"
	/// English String: "Inappropriate"
	/// </summary>
	public override string LabelModCategoryInappropriate => "Inapropriado";

	/// <summary>
	/// Key: "Label.ModCategoryNone"
	/// English String: "None"
	/// </summary>
	public override string LabelModCategoryNone => "Nenhuma";

	/// <summary>
	/// Key: "Label.ModCategoryPrivacy"
	/// English String: "Privacy"
	/// </summary>
	public override string LabelModCategoryPrivacy => "Privacidade";

	/// <summary>
	/// Key: "Label.ModCategoryProfanity"
	/// English String: "Profanity"
	/// </summary>
	public override string LabelModCategoryProfanity => "Palavrões";

	/// <summary>
	/// Key: "Label.ModCategoryScamming"
	/// English String: "Scamming"
	/// </summary>
	public override string LabelModCategoryScamming => "Esquema malicioso";

	/// <summary>
	/// Key: "Label.ModCategorySpam"
	/// English String: "Spam"
	/// </summary>
	public override string LabelModCategorySpam => "Spam";

	/// <summary>
	/// Key: "Label.ModCategoryUnclassified"
	/// English String: "Unclassified Mild"
	/// </summary>
	public override string LabelModCategoryUnclassified => "Leve, não classificado";

	/// <summary>
	/// Key: "Label.ModeratorNote"
	/// English String: "NOTE: Deleting this post you will also delete replies. If you choose to scrub or delete the post, this report will skip the abuse queue and go directly to the user queue."
	/// </summary>
	public override string LabelModeratorNote => "AVISO: Excluindo esta publicação também excluirá suas respostas. Se você decidir moderar ou excluir esta publicação, esta denúncia pulará a fila de abuso, indo diretamente para a fila de usuário.";

	/// <summary>
	/// Key: "Label.NeedJavaScript"
	/// English String: "You need JavaScript enabled to view this video."
	/// </summary>
	public override string LabelNeedJavaScript => "Você precisa ter JavaScript habilitado para ver este vídeo.";

	/// <summary>
	/// Key: "Label.NotSureQuestion"
	/// English String: "Not sure if the thing you are trying to report is really against the rules?"
	/// </summary>
	public override string LabelNotSureQuestion => "Não tem certeza se o que você está tentando denunciar é contra as regras?";

	/// <summary>
	/// Key: "Label.PrivacyPolicyLink"
	/// English String: "Privacy Policy"
	/// </summary>
	public override string LabelPrivacyPolicyLink => "Política de Privacidade";

	/// <summary>
	/// Key: "Label.Reason"
	/// English String: "Reason"
	/// </summary>
	public override string LabelReason => "Motivo";

	/// <summary>
	/// Key: "Label.Rules1"
	/// English String: "No swear words"
	/// </summary>
	public override string LabelRules1 => "Palavrões não são permitidos";

	/// <summary>
	/// Key: "Label.Rules2"
	/// English String: "No account sharing or trading"
	/// </summary>
	public override string LabelRules2 => "Troca e compartilhamento de contas não são permitidos";

	/// <summary>
	/// Key: "Label.Rules3"
	/// English String: "No dating - no asking for boyfriends or girlfriends"
	/// </summary>
	public override string LabelRules3 => "Relações amorosas não são permitidas - não se deve procurar por namorado/namorada";

	/// <summary>
	/// Key: "Label.Rules4"
	/// English String: "No asking real life info about each other - no asking for phone numbers or email addresses"
	/// </summary>
	public override string LabelRules4 => "Não se deve pedir informações pessoais - não se deve pedir número de telefone ou endereço de e-mail";

	/// <summary>
	/// Key: "Label.RulesHeading"
	/// English String: "Some of the basic rules of Roblox include the following:"
	/// </summary>
	public override string LabelRulesHeading => "Algumas regras básicas do Roblox incluem as seguintes:";

	/// <summary>
	/// Key: "Label.SafetyHelpLink"
	/// Display text for a link to the safety help page
	/// English String: "Roblox Safety."
	/// </summary>
	public override string LabelSafetyHelpLink => "Segurança no Roblox.";

	/// <summary>
	/// Key: "Label.ScrubBody"
	/// English String: "Scrub Body"
	/// </summary>
	public override string LabelScrubBody => "Moderar corpo";

	/// <summary>
	/// Key: "Label.ScrubSubjectAndBody"
	/// English String: "Scrub Subject and Body"
	/// </summary>
	public override string LabelScrubSubjectAndBody => "Moderar corpo e assunto";

	/// <summary>
	/// Key: "Label.SeeCommunityRules"
	/// English String: "See Community Rules"
	/// </summary>
	public override string LabelSeeCommunityRules => "Ver as regras da comunidade";

	/// <summary>
	/// Key: "Label.SelectCategory"
	/// English String: "Please select a category"
	/// </summary>
	public override string LabelSelectCategory => "Selecione uma categoria";

	/// <summary>
	/// Key: "Label.SelectMedia"
	/// English String: "Select any inappropriate media:"
	/// </summary>
	public override string LabelSelectMedia => "Selecione qualquer mídia inapropriada:";

	/// <summary>
	/// Key: "Label.SelectReason"
	/// English String: "Select a reason for your moderation action:"
	/// </summary>
	public override string LabelSelectReason => "Selecione um motivo para sua ação de moderação:";

	/// <summary>
	/// Key: "Label.Subject"
	/// English String: "Subject:"
	/// </summary>
	public override string LabelSubject => "Assunto:";

	/// <summary>
	/// Key: "Message.ErrorMissingParams"
	/// English String: "One or more required parameters are missing or invalid"
	/// </summary>
	public override string MessageErrorMissingParams => "Um ou mais dos parâmetros obrigatórios estão faltando ou são inválidos";

	/// <summary>
	/// Key: "Message.ErrorReportingCategories"
	/// English String: "There was a problem loading reporting categories."
	/// </summary>
	public override string MessageErrorReportingCategories => "Ocorreu um erro ao carregar as categorias de denúncia.";

	/// <summary>
	/// Key: "Message.ErrorSubmit"
	/// English String: "There was a problem submitting your report."
	/// </summary>
	public override string MessageErrorSubmit => "Ocorreu um erro ao enviar sua denúncia.";

	/// <summary>
	/// Key: "Message.GenericError"
	/// English String: "There was a problem with the page"
	/// </summary>
	public override string MessageGenericError => "Ocorreu um erro na página";

	/// <summary>
	/// Key: "Message.Success"
	/// English String: "Your report has been sent."
	/// </summary>
	public override string MessageSuccess => "Sua denúncia foi enviada.";

	/// <summary>
	/// Key: "Message.ThankYou"
	/// Thank you message to appear with confirmation of successful report. Followed by a link to the localized help page
	/// English String: "Thank you for your report.  We will investigate further to determine if there has been a violation of our Terms of Use.  For more information check out "
	/// </summary>
	public override string MessageThankYou => "Obrigado pela denúncia. Vamos investigar mais o assunto para determinar se houve violação dos Termos de Uso. Para mais informações confira ";

	/// <summary>
	/// Key: "Response.PermissionError"
	/// English String: "This account does not have enough permissions"
	/// </summary>
	public override string ResponsePermissionError => "Esta conta não tem permissões suficientes";

	public ReportAbuseResources_pt_br(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionClose()
	{
		return "Fechar";
	}

	protected override string _GetTemplateForActionReportAbuse()
	{
		return "Denunciar abuso";
	}

	protected override string _GetTemplateForActionSubmit()
	{
		return "Enviar";
	}

	protected override string _GetTemplateForExampleComment()
	{
		return "Comentário (opcional)...";
	}

	protected override string _GetTemplateForHeadingReportAbuse()
	{
		return "Denunciar abuso";
	}

	protected override string _GetTemplateForHeadingSuccess()
	{
		return "Obrigado!";
	}

	protected override string _GetTemplateForLabelAllRulesLink()
	{
		return "Ver todas as regras.";
	}

	protected override string _GetTemplateForLabelBlockWarning()
	{
		return "Os usuários que não seguirem as regras serão avisados, mas se continuarem, vamos pedir para que não voltem mais ao Roblox. Desta forma poderemos manter o Roblox um lugar divertido e seguro!";
	}

	protected override string _GetTemplateForLabelCategoryBullying()
	{
		return "Bullying, assédio, descriminação";
	}

	protected override string _GetTemplateForLabelCategoryBullyingV2()
	{
		return "Bullying, assédio, descriminação";
	}

	protected override string _GetTemplateForLabelCategoryContent()
	{
		return "Conteúdo inapropriado - Lugar, imagem, modelo";
	}

	protected override string _GetTemplateForLabelCategoryDating()
	{
		return "Namoro";
	}

	protected override string _GetTemplateForLabelCategoryInappropriate()
	{
		return "Linguajar inapropriado - Palavrões e conteúdo adulto";
	}

	protected override string _GetTemplateForLabelCategoryOther()
	{
		return "Outras violações de regras";
	}

	protected override string _GetTemplateForLabelCategoryPrivateInfo()
	{
		return "Oferecer ou pedir informações pessoais";
	}

	protected override string _GetTemplateForLabelCategoryScamming()
	{
		return "Exploração indevida, trapaça, esquema malicioso";
	}

	protected override string _GetTemplateForLabelCategoryTheft()
	{
		return "Roubo de conta - Phishing, hacking, troca";
	}

	protected override string _GetTemplateForLabelCategoryThreats()
	{
		return "Ameaças na vida real e de suicídio";
	}

	protected override string _GetTemplateForLabelComment()
	{
		return "Comentário:";
	}

	protected override string _GetTemplateForLabelDeletePost()
	{
		return "Excluir publicação (e respostas)";
	}

	protected override string _GetTemplateForLabelLeaveUnchanged()
	{
		return "Deixar publicação inalterada";
	}

	protected override string _GetTemplateForLabelModCategoryAdultContent()
	{
		return "Conteúdo adulto";
	}

	protected override string _GetTemplateForLabelModCategoryAdvertisement()
	{
		return "Propaganda";
	}

	protected override string _GetTemplateForLabelModCategoryHarrasment()
	{
		return "Assédio";
	}

	protected override string _GetTemplateForLabelModCategoryInappropriate()
	{
		return "Inapropriado";
	}

	protected override string _GetTemplateForLabelModCategoryNone()
	{
		return "Nenhuma";
	}

	protected override string _GetTemplateForLabelModCategoryPrivacy()
	{
		return "Privacidade";
	}

	protected override string _GetTemplateForLabelModCategoryProfanity()
	{
		return "Palavrões";
	}

	protected override string _GetTemplateForLabelModCategoryScamming()
	{
		return "Esquema malicioso";
	}

	protected override string _GetTemplateForLabelModCategorySpam()
	{
		return "Spam";
	}

	protected override string _GetTemplateForLabelModCategoryUnclassified()
	{
		return "Leve, não classificado";
	}

	protected override string _GetTemplateForLabelModeratorNote()
	{
		return "AVISO: Excluindo esta publicação também excluirá suas respostas. Se você decidir moderar ou excluir esta publicação, esta denúncia pulará a fila de abuso, indo diretamente para a fila de usuário.";
	}

	protected override string _GetTemplateForLabelNeedJavaScript()
	{
		return "Você precisa ter JavaScript habilitado para ver este vídeo.";
	}

	protected override string _GetTemplateForLabelNotSureQuestion()
	{
		return "Não tem certeza se o que você está tentando denunciar é contra as regras?";
	}

	protected override string _GetTemplateForLabelPrivacyPolicyLink()
	{
		return "Política de Privacidade";
	}

	protected override string _GetTemplateForLabelReason()
	{
		return "Motivo";
	}

	protected override string _GetTemplateForLabelRules1()
	{
		return "Palavrões não são permitidos";
	}

	protected override string _GetTemplateForLabelRules2()
	{
		return "Troca e compartilhamento de contas não são permitidos";
	}

	protected override string _GetTemplateForLabelRules3()
	{
		return "Relações amorosas não são permitidas - não se deve procurar por namorado/namorada";
	}

	protected override string _GetTemplateForLabelRules4()
	{
		return "Não se deve pedir informações pessoais - não se deve pedir número de telefone ou endereço de e-mail";
	}

	protected override string _GetTemplateForLabelRulesHeading()
	{
		return "Algumas regras básicas do Roblox incluem as seguintes:";
	}

	protected override string _GetTemplateForLabelSafetyHelpLink()
	{
		return "Segurança no Roblox.";
	}

	protected override string _GetTemplateForLabelScrubBody()
	{
		return "Moderar corpo";
	}

	protected override string _GetTemplateForLabelScrubSubjectAndBody()
	{
		return "Moderar corpo e assunto";
	}

	protected override string _GetTemplateForLabelSeeCommunityRules()
	{
		return "Ver as regras da comunidade";
	}

	protected override string _GetTemplateForLabelSelectCategory()
	{
		return "Selecione uma categoria";
	}

	protected override string _GetTemplateForLabelSelectMedia()
	{
		return "Selecione qualquer mídia inapropriada:";
	}

	protected override string _GetTemplateForLabelSelectReason()
	{
		return "Selecione um motivo para sua ação de moderação:";
	}

	protected override string _GetTemplateForLabelSubject()
	{
		return "Assunto:";
	}

	/// <summary>
	/// Key: "Label.TellUsHow"
	/// English String: "Tell us how you think {creatorName} is breaking the rules of Roblox."
	/// </summary>
	public override string LabelTellUsHow(string creatorName)
	{
		return $"Conte-nos por que você acha que {creatorName} está quebrando as regras do Roblox.";
	}

	protected override string _GetTemplateForLabelTellUsHow()
	{
		return "Conte-nos por que você acha que {creatorName} está quebrando as regras do Roblox.";
	}

	protected override string _GetTemplateForMessageErrorMissingParams()
	{
		return "Um ou mais dos parâmetros obrigatórios estão faltando ou são inválidos";
	}

	protected override string _GetTemplateForMessageErrorReportingCategories()
	{
		return "Ocorreu um erro ao carregar as categorias de denúncia.";
	}

	protected override string _GetTemplateForMessageErrorSubmit()
	{
		return "Ocorreu um erro ao enviar sua denúncia.";
	}

	protected override string _GetTemplateForMessageGenericError()
	{
		return "Ocorreu um erro na página";
	}

	protected override string _GetTemplateForMessageSuccess()
	{
		return "Sua denúncia foi enviada.";
	}

	protected override string _GetTemplateForMessageThankYou()
	{
		return "Obrigado pela denúncia. Vamos investigar mais o assunto para determinar se houve violação dos Termos de Uso. Para mais informações confira ";
	}

	protected override string _GetTemplateForResponsePermissionError()
	{
		return "Esta conta não tem permissões suficientes";
	}
}
