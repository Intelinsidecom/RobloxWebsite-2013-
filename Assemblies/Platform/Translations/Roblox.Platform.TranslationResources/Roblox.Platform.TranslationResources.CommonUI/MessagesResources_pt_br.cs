namespace Roblox.TranslationResources.CommonUI;

/// <summary>
/// This class overrides MessagesResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class MessagesResources_pt_br : MessagesResources_en_us, IMessagesResources, ITranslationResources
{
	/// <summary>
	/// Key: "Action.PreviousPage"
	/// button title
	/// English String: "Go to the Previous Page"
	/// </summary>
	public override string ActionPreviousPage => "Ir para a página anterior";

	/// <summary>
	/// Key: "Action.ReturnHome"
	/// button title
	/// English String: "Return Home"
	/// </summary>
	public override string ActionReturnHome => "Voltar ao início";

	/// <summary>
	/// Key: "Label.Error"
	/// English String: "Error"
	/// </summary>
	public override string LabelError => "Erro";

	/// <summary>
	/// Key: "Label.ErrorImage"
	/// alternate text shown for error image
	/// English String: "Error Image"
	/// </summary>
	public override string LabelErrorImage => "Imagem de erro";

	/// <summary>
	/// Key: "Label.TooManyCharacters"
	/// English String: "Too many characters!"
	/// </summary>
	public override string LabelTooManyCharacters => "Caracteres demais!";

	/// <summary>
	/// Key: "Message.AlwaysAllowed"
	/// English String: "Always allowed"
	/// </summary>
	public override string MessageAlwaysAllowed => "Sempre permitidos";

	/// <summary>
	/// Key: "Message.AnalyiticsCookies"
	/// English String: "Analytics Cookies"
	/// </summary>
	public override string MessageAnalyiticsCookies => "Cookies analíticos";

	/// <summary>
	/// Key: "Message.AnalyiticsCookiesDescription"
	/// English String: "These cookies used for improving site performance or understanding site usage."
	/// </summary>
	public override string MessageAnalyiticsCookiesDescription => "Esses cookies são usados para melhorar o desempenho do site ou entender melhor o uso do site.";

	/// <summary>
	/// Key: "Message.AnalyiticsCookiesItem1"
	/// English String: "Google Analytics"
	/// </summary>
	public override string MessageAnalyiticsCookiesItem1 => "Google Analytics";

	/// <summary>
	/// Key: "Message.AnalyiticsCookiesItem2"
	/// English String: "Google Universal Analytics"
	/// </summary>
	public override string MessageAnalyiticsCookiesItem2 => "Google Universal Analytics";

	/// <summary>
	/// Key: "Message.EssentialCookies"
	/// English String: "Essential Cookies"
	/// </summary>
	public override string MessageEssentialCookies => "Cookies essenciais";

	/// <summary>
	/// Key: "Message.EssentialCookiesDescription"
	/// English String: "These cookies are required to provide the functionality on the site, such as for user authentication, securing the system or saving cookie preferences."
	/// </summary>
	public override string MessageEssentialCookiesDescription => "Esses cookies são necessários para a funcionalidade do site, como por exemplo, a autenticação do usuário, segurança do sistema e salvamento de preferências de cookies.";

	/// <summary>
	/// Key: "Message.EssentialCookiesItem1"
	/// English String: "Roblox"
	/// </summary>
	public override string MessageEssentialCookiesItem1 => "Roblox";

	/// <summary>
	/// Key: "Message.EssentialCookiesItem2"
	/// English String: "Zendesk"
	/// </summary>
	public override string MessageEssentialCookiesItem2 => "Zendesk";

	/// <summary>
	/// Key: "Message.ManageCookies"
	/// English String: "Manage Cookies"
	/// </summary>
	public override string MessageManageCookies => "Gerenciar cookies";

	/// <summary>
	/// Key: "MessageEssentialCookiesItem3"
	/// English String: "Gigya"
	/// </summary>
	public override string MessageEssentialCookiesItem3 => "Gigya";

	/// <summary>
	/// Key: "Response.AccessDenied"
	/// 403 error message
	/// English String: "Access Denied"
	/// </summary>
	public override string ResponseAccessDenied => "Acesso negado";

	/// <summary>
	/// Key: "Response.AccessDeniedDescription"
	/// 403 error message detail
	/// English String: "You don't have permission to view this page"
	/// </summary>
	public override string ResponseAccessDeniedDescription => "Você não tem permissão para ver esta página";

	/// <summary>
	/// Key: "Response.BadRequest"
	/// 400 error message title
	/// English String: "Bad Request"
	/// </summary>
	public override string ResponseBadRequest => "Solicitação incorreta";

	/// <summary>
	/// Key: "Response.BadRequestDescription"
	/// error message detail for 400 error
	/// English String: "There was a problem with your request"
	/// </summary>
	public override string ResponseBadRequestDescription => "Ocorreu um erro com seu pedido";

	/// <summary>
	/// Key: "Response.InternalServerError"
	/// 500 error message title
	/// English String: "Internal Server Error"
	/// </summary>
	public override string ResponseInternalServerError => "Erro de servidor interno";

	/// <summary>
	/// Key: "Response.InternalServerErrorDescription"
	/// 500 error message description
	/// English String: "An unexpected error occurred"
	/// </summary>
	public override string ResponseInternalServerErrorDescription => "Um erro inesperado ocorreu";

	/// <summary>
	/// Key: "Response.PageNotFound"
	/// 404 error message title
	/// English String: "Page Not found"
	/// </summary>
	public override string ResponsePageNotFound => "Página não encontrada";

	/// <summary>
	/// Key: "Response.PageNotFoundDescrition"
	/// 404 error message description
	/// English String: "Page cannot be found or no longer exists"
	/// </summary>
	public override string ResponsePageNotFoundDescrition => "A página não foi encontrada ou não existe mais";

	/// <summary>
	/// Key: "Response.RequestError"
	/// error message for incorrect request
	/// English String: "Error with your request"
	/// </summary>
	public override string ResponseRequestError => "Erro no seu pedido";

	/// <summary>
	/// Key: "Response.SomethingWentWrong"
	/// default error message
	/// English String: "Something went wrong"
	/// </summary>
	public override string ResponseSomethingWentWrong => "Algo deu errado";

	/// <summary>
	/// Key: "Response.TooManyAttemptsText"
	/// English String: "Too Many Attempts"
	/// </summary>
	public override string ResponseTooManyAttemptsText => "Tentativas excessivas";

	/// <summary>
	/// Key: "Response.UnexpectedError"
	/// default error description
	/// English String: "An unexpected error occurred. Please try again later."
	/// </summary>
	public override string ResponseUnexpectedError => "Um erro inesperado ocorreu. Tente novamente mais tarde.";

	public MessagesResources_pt_br(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionPreviousPage()
	{
		return "Ir para a página anterior";
	}

	protected override string _GetTemplateForActionReturnHome()
	{
		return "Voltar ao início";
	}

	/// <summary>
	/// Key: "CookieLawNoticev2"
	/// Incorrect key, obsoleted
	/// English String: "Roblox uses cookies to personalize content, provide social media features and analyze the traffic on our site. To learn about how we use cookies and how you can {startLink}manage cookie preferences{endLink}, please refer to our {startLink2}Privacy and Cookie Policy{endLink2}."
	/// </summary>
	public override string CookieLawNoticev2(string startLink, string endLink, string startLink2, string endLink2)
	{
		return $"Roblox usa cookies para personalizar conteúdo, fornecer funções de rede social e analisar o tráfego no site. Para saber mais sobre como utilizamos os cookies e como {startLink}gerenciar as preferências de cookies{endLink}, consulte nossa {startLink2}Política de Privacidade e Cookies{endLink2}.";
	}

	protected override string _GetTemplateForCookieLawNoticev2()
	{
		return "Roblox usa cookies para personalizar conteúdo, fornecer funções de rede social e analisar o tráfego no site. Para saber mais sobre como utilizamos os cookies e como {startLink}gerenciar as preferências de cookies{endLink}, consulte nossa {startLink2}Política de Privacidade e Cookies{endLink2}.";
	}

	/// <summary>
	/// Key: "Description.ContactCustomerService"
	/// message shown on common error pages
	/// English String: "If you continue to receive this page, please contact customer service at {emailLink}"
	/// </summary>
	public override string DescriptionContactCustomerService(string emailLink)
	{
		return $"Se continuar recebendo esta página, entre em contato com o atendimento ao cliente em {emailLink}";
	}

	protected override string _GetTemplateForDescriptionContactCustomerService()
	{
		return "Se continuar recebendo esta página, entre em contato com o atendimento ao cliente em {emailLink}";
	}

	protected override string _GetTemplateForLabelError()
	{
		return "Erro";
	}

	protected override string _GetTemplateForLabelErrorImage()
	{
		return "Imagem de erro";
	}

	protected override string _GetTemplateForLabelTooManyCharacters()
	{
		return "Caracteres demais!";
	}

	protected override string _GetTemplateForMessageAlwaysAllowed()
	{
		return "Sempre permitidos";
	}

	protected override string _GetTemplateForMessageAnalyiticsCookies()
	{
		return "Cookies analíticos";
	}

	protected override string _GetTemplateForMessageAnalyiticsCookiesDescription()
	{
		return "Esses cookies são usados para melhorar o desempenho do site ou entender melhor o uso do site.";
	}

	protected override string _GetTemplateForMessageAnalyiticsCookiesItem1()
	{
		return "Google Analytics";
	}

	protected override string _GetTemplateForMessageAnalyiticsCookiesItem2()
	{
		return "Google Universal Analytics";
	}

	/// <summary>
	/// Key: "Message.CookieLawNotice"
	/// Cookies are used for Internet-based data storage, and this message warns users that we use them to improve their experience. See https://en.wikipedia.org/wiki/HTTP_cookie for more information.
	/// English String: "Roblox uses cookies to offer you a better experience. For further information, including information on how to withdraw consent and how to manage the use of cookies on Roblox, please refer to our {startLink}Privacy and Cookie Policy{endLink}."
	/// </summary>
	public override string MessageCookieLawNotice(string startLink, string endLink)
	{
		return $"Roblox usa cookies para oferecer a você a melhor experiência possível. Para obter mais informações, incluindo informações sobre como revogar seu consentimento e como gerenciar o uso de cookies no Roblox, não hesite em consultar nossa {startLink}Política de Privacidade e Cookie{endLink}.";
	}

	protected override string _GetTemplateForMessageCookieLawNotice()
	{
		return "Roblox usa cookies para oferecer a você a melhor experiência possível. Para obter mais informações, incluindo informações sobre como revogar seu consentimento e como gerenciar o uso de cookies no Roblox, não hesite em consultar nossa {startLink}Política de Privacidade e Cookie{endLink}.";
	}

	/// <summary>
	/// Key: "Message.CookieLawNoticev2"
	/// English String: "Roblox uses cookies to personalize content, provide social media features and analyze the traffic on our site. To learn about how we use cookies and how you can {startLink}manage cookie preferences{endLink}, please refer to our {startLink2}Privacy and Cookie Policy{endLink2}."
	/// </summary>
	public override string MessageCookieLawNoticev2(string startLink, string endLink, string startLink2, string endLink2)
	{
		return $"Roblox usa cookies para personalizar conteúdo, fornecer funções de rede social e analisar o tráfego no site. Para saber mais sobre como utilizamos os cookies e como {startLink}gerenciar as preferências de cookies{endLink}, consulte nossa {startLink2}Política de Privacidade e Cookies{endLink2}.";
	}

	protected override string _GetTemplateForMessageCookieLawNoticev2()
	{
		return "Roblox usa cookies para personalizar conteúdo, fornecer funções de rede social e analisar o tráfego no site. Para saber mais sobre como utilizamos os cookies e como {startLink}gerenciar as preferências de cookies{endLink}, consulte nossa {startLink2}Política de Privacidade e Cookies{endLink2}.";
	}

	/// <summary>
	/// Key: "Message.CookieModalText"
	/// English String: "Please choose whether this site may use cookies as described below. You can learn more about how this site uses cookies and related technologies by reading our {startLink}privacy policy{endLink}."
	/// </summary>
	public override string MessageCookieModalText(string startLink, string endLink)
	{
		return $"Escolha se este site pode usar cookies como descrito abaixo. Você pode saber mais sobre o uso de cookies e tecnologias relacionadas deste site lendo nossa {startLink}política de privacidade{endLink}.";
	}

	protected override string _GetTemplateForMessageCookieModalText()
	{
		return "Escolha se este site pode usar cookies como descrito abaixo. Você pode saber mais sobre o uso de cookies e tecnologias relacionadas deste site lendo nossa {startLink}política de privacidade{endLink}.";
	}

	protected override string _GetTemplateForMessageEssentialCookies()
	{
		return "Cookies essenciais";
	}

	protected override string _GetTemplateForMessageEssentialCookiesDescription()
	{
		return "Esses cookies são necessários para a funcionalidade do site, como por exemplo, a autenticação do usuário, segurança do sistema e salvamento de preferências de cookies.";
	}

	protected override string _GetTemplateForMessageEssentialCookiesItem1()
	{
		return "Roblox";
	}

	protected override string _GetTemplateForMessageEssentialCookiesItem2()
	{
		return "Zendesk";
	}

	protected override string _GetTemplateForMessageManageCookies()
	{
		return "Gerenciar cookies";
	}

	protected override string _GetTemplateForMessageEssentialCookiesItem3()
	{
		return "Gigya";
	}

	protected override string _GetTemplateForResponseAccessDenied()
	{
		return "Acesso negado";
	}

	protected override string _GetTemplateForResponseAccessDeniedDescription()
	{
		return "Você não tem permissão para ver esta página";
	}

	protected override string _GetTemplateForResponseBadRequest()
	{
		return "Solicitação incorreta";
	}

	protected override string _GetTemplateForResponseBadRequestDescription()
	{
		return "Ocorreu um erro com seu pedido";
	}

	protected override string _GetTemplateForResponseInternalServerError()
	{
		return "Erro de servidor interno";
	}

	protected override string _GetTemplateForResponseInternalServerErrorDescription()
	{
		return "Um erro inesperado ocorreu";
	}

	protected override string _GetTemplateForResponsePageNotFound()
	{
		return "Página não encontrada";
	}

	protected override string _GetTemplateForResponsePageNotFoundDescrition()
	{
		return "A página não foi encontrada ou não existe mais";
	}

	protected override string _GetTemplateForResponseRequestError()
	{
		return "Erro no seu pedido";
	}

	protected override string _GetTemplateForResponseSomethingWentWrong()
	{
		return "Algo deu errado";
	}

	protected override string _GetTemplateForResponseTooManyAttemptsText()
	{
		return "Tentativas excessivas";
	}

	protected override string _GetTemplateForResponseUnexpectedError()
	{
		return "Um erro inesperado ocorreu. Tente novamente mais tarde.";
	}
}
