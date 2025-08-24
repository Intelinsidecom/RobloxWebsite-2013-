namespace Roblox.TranslationResources.CommonUI;

/// <summary>
/// This class overrides MessagesResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class MessagesResources_es_es : MessagesResources_en_us, IMessagesResources, ITranslationResources
{
	/// <summary>
	/// Key: "Action.PreviousPage"
	/// button title
	/// English String: "Go to the Previous Page"
	/// </summary>
	public override string ActionPreviousPage => "Ir a la página anterior";

	/// <summary>
	/// Key: "Action.ReturnHome"
	/// button title
	/// English String: "Return Home"
	/// </summary>
	public override string ActionReturnHome => "Volver a Inicio";

	/// <summary>
	/// Key: "Label.Error"
	/// English String: "Error"
	/// </summary>
	public override string LabelError => "Error";

	/// <summary>
	/// Key: "Label.ErrorImage"
	/// alternate text shown for error image
	/// English String: "Error Image"
	/// </summary>
	public override string LabelErrorImage => "Imagen del error";

	/// <summary>
	/// Key: "Label.TooManyCharacters"
	/// English String: "Too many characters!"
	/// </summary>
	public override string LabelTooManyCharacters => "¡Demasiados caracteres!";

	/// <summary>
	/// Key: "Message.AlwaysAllowed"
	/// English String: "Always allowed"
	/// </summary>
	public override string MessageAlwaysAllowed => "Siempre permitido";

	/// <summary>
	/// Key: "Message.AnalyiticsCookies"
	/// English String: "Analytics Cookies"
	/// </summary>
	public override string MessageAnalyiticsCookies => "Cookies analíticas";

	/// <summary>
	/// Key: "Message.AnalyiticsCookiesDescription"
	/// English String: "These cookies used for improving site performance or understanding site usage."
	/// </summary>
	public override string MessageAnalyiticsCookiesDescription => "Se utilizan estas cookies para mejorar el rendimiento del sitio o para entender la utilización de este mismo.";

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
	public override string MessageEssentialCookies => "Cookies esenciales";

	/// <summary>
	/// Key: "Message.EssentialCookiesDescription"
	/// English String: "These cookies are required to provide the functionality on the site, such as for user authentication, securing the system or saving cookie preferences."
	/// </summary>
	public override string MessageEssentialCookiesDescription => "Estas cookies son necesarias para proporcionar la funcionalidad en el sitio, como la autenticación del usuario, asegurando el sistema y guardando las preferencias de cookies.";

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
	public override string MessageManageCookies => "Administrar las cookies";

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
	public override string ResponseAccessDenied => "Acceso denegado";

	/// <summary>
	/// Key: "Response.AccessDeniedDescription"
	/// 403 error message detail
	/// English String: "You don't have permission to view this page"
	/// </summary>
	public override string ResponseAccessDeniedDescription => "No tienes permiso para ver esta página.";

	/// <summary>
	/// Key: "Response.BadRequest"
	/// 400 error message title
	/// English String: "Bad Request"
	/// </summary>
	public override string ResponseBadRequest => "Solicitud incorrecta";

	/// <summary>
	/// Key: "Response.BadRequestDescription"
	/// error message detail for 400 error
	/// English String: "There was a problem with your request"
	/// </summary>
	public override string ResponseBadRequestDescription => "Ha habido un problema con tu solicitud.";

	/// <summary>
	/// Key: "Response.InternalServerError"
	/// 500 error message title
	/// English String: "Internal Server Error"
	/// </summary>
	public override string ResponseInternalServerError => "Error interno del servidor";

	/// <summary>
	/// Key: "Response.InternalServerErrorDescription"
	/// 500 error message description
	/// English String: "An unexpected error occurred"
	/// </summary>
	public override string ResponseInternalServerErrorDescription => "Se ha producido un error inesperado.";

	/// <summary>
	/// Key: "Response.PageNotFound"
	/// 404 error message title
	/// English String: "Page Not found"
	/// </summary>
	public override string ResponsePageNotFound => "Página no encontrada";

	/// <summary>
	/// Key: "Response.PageNotFoundDescrition"
	/// 404 error message description
	/// English String: "Page cannot be found or no longer exists"
	/// </summary>
	public override string ResponsePageNotFoundDescrition => "Página no encontrada o inexistente";

	/// <summary>
	/// Key: "Response.RequestError"
	/// error message for incorrect request
	/// English String: "Error with your request"
	/// </summary>
	public override string ResponseRequestError => "Error con tu solicitud";

	/// <summary>
	/// Key: "Response.SomethingWentWrong"
	/// default error message
	/// English String: "Something went wrong"
	/// </summary>
	public override string ResponseSomethingWentWrong => "Algo ha ido mal.";

	/// <summary>
	/// Key: "Response.TooManyAttemptsText"
	/// English String: "Too Many Attempts"
	/// </summary>
	public override string ResponseTooManyAttemptsText => "Demasiados intentos.";

	/// <summary>
	/// Key: "Response.UnexpectedError"
	/// default error description
	/// English String: "An unexpected error occurred. Please try again later."
	/// </summary>
	public override string ResponseUnexpectedError => "Se ha producido un error inesperado. Inténtalo de nuevo más tarde.";

	public MessagesResources_es_es(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionPreviousPage()
	{
		return "Ir a la página anterior";
	}

	protected override string _GetTemplateForActionReturnHome()
	{
		return "Volver a Inicio";
	}

	/// <summary>
	/// Key: "CookieLawNoticev2"
	/// Incorrect key, obsoleted
	/// English String: "Roblox uses cookies to personalize content, provide social media features and analyze the traffic on our site. To learn about how we use cookies and how you can {startLink}manage cookie preferences{endLink}, please refer to our {startLink2}Privacy and Cookie Policy{endLink2}."
	/// </summary>
	public override string CookieLawNoticev2(string startLink, string endLink, string startLink2, string endLink2)
	{
		return $"Roblox utiliza cookies para personalizar el contenido, proporcionar funciones de redes sociales y analizar el tráfico en el sitio. Para obtener más información sobre cómo puedes {startLink}gestionar las preferencias de cookies{endLink}, consulta nuestra {startLink2}Política de privacidad y cookies{endLink2}.";
	}

	protected override string _GetTemplateForCookieLawNoticev2()
	{
		return "Roblox utiliza cookies para personalizar el contenido, proporcionar funciones de redes sociales y analizar el tráfico en el sitio. Para obtener más información sobre cómo puedes {startLink}gestionar las preferencias de cookies{endLink}, consulta nuestra {startLink2}Política de privacidad y cookies{endLink2}.";
	}

	/// <summary>
	/// Key: "Description.ContactCustomerService"
	/// message shown on common error pages
	/// English String: "If you continue to receive this page, please contact customer service at {emailLink}"
	/// </summary>
	public override string DescriptionContactCustomerService(string emailLink)
	{
		return $"Si sigues recibiendo esta página, ponte en contacto con el servicio al cliente aquí {emailLink}.";
	}

	protected override string _GetTemplateForDescriptionContactCustomerService()
	{
		return "Si sigues recibiendo esta página, ponte en contacto con el servicio al cliente aquí {emailLink}.";
	}

	protected override string _GetTemplateForLabelError()
	{
		return "Error";
	}

	protected override string _GetTemplateForLabelErrorImage()
	{
		return "Imagen del error";
	}

	protected override string _GetTemplateForLabelTooManyCharacters()
	{
		return "¡Demasiados caracteres!";
	}

	protected override string _GetTemplateForMessageAlwaysAllowed()
	{
		return "Siempre permitido";
	}

	protected override string _GetTemplateForMessageAnalyiticsCookies()
	{
		return "Cookies analíticas";
	}

	protected override string _GetTemplateForMessageAnalyiticsCookiesDescription()
	{
		return "Se utilizan estas cookies para mejorar el rendimiento del sitio o para entender la utilización de este mismo.";
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
		return $"Roblox utiliza cookies para ofrecerte una mejor experiencia. Para obtener más información, que incluye cómo revocar el consentimiento y gestionar el uso de cookies en Roblox, consulta nuestra {startLink}Política de privacidad y cookies{endLink}.";
	}

	protected override string _GetTemplateForMessageCookieLawNotice()
	{
		return "Roblox utiliza cookies para ofrecerte una mejor experiencia. Para obtener más información, que incluye cómo revocar el consentimiento y gestionar el uso de cookies en Roblox, consulta nuestra {startLink}Política de privacidad y cookies{endLink}.";
	}

	/// <summary>
	/// Key: "Message.CookieLawNoticev2"
	/// English String: "Roblox uses cookies to personalize content, provide social media features and analyze the traffic on our site. To learn about how we use cookies and how you can {startLink}manage cookie preferences{endLink}, please refer to our {startLink2}Privacy and Cookie Policy{endLink2}."
	/// </summary>
	public override string MessageCookieLawNoticev2(string startLink, string endLink, string startLink2, string endLink2)
	{
		return $"Roblox utiliza cookies para personalizar el contenido, proporcionar funciones de redes sociales y analizar el tráfico en el sitio. Para obtener más información sobre cómo puedes {startLink}gestionar las preferencias de cookies{endLink}, consulta nuestra {startLink2}Política de privacidad y cookies{endLink2}.";
	}

	protected override string _GetTemplateForMessageCookieLawNoticev2()
	{
		return "Roblox utiliza cookies para personalizar el contenido, proporcionar funciones de redes sociales y analizar el tráfico en el sitio. Para obtener más información sobre cómo puedes {startLink}gestionar las preferencias de cookies{endLink}, consulta nuestra {startLink2}Política de privacidad y cookies{endLink2}.";
	}

	/// <summary>
	/// Key: "Message.CookieModalText"
	/// English String: "Please choose whether this site may use cookies as described below. You can learn more about how this site uses cookies and related technologies by reading our {startLink}privacy policy{endLink}."
	/// </summary>
	public override string MessageCookieModalText(string startLink, string endLink)
	{
		return $"Elige si este sitio puede utilizar cookies como se describe a continuación. Puedes obtener más información sobre cómo este sitio usa las cookies y otras tecnologías relacionadas leyendo nuestra {startLink}Política de privacidad{endLink}.";
	}

	protected override string _GetTemplateForMessageCookieModalText()
	{
		return "Elige si este sitio puede utilizar cookies como se describe a continuación. Puedes obtener más información sobre cómo este sitio usa las cookies y otras tecnologías relacionadas leyendo nuestra {startLink}Política de privacidad{endLink}.";
	}

	protected override string _GetTemplateForMessageEssentialCookies()
	{
		return "Cookies esenciales";
	}

	protected override string _GetTemplateForMessageEssentialCookiesDescription()
	{
		return "Estas cookies son necesarias para proporcionar la funcionalidad en el sitio, como la autenticación del usuario, asegurando el sistema y guardando las preferencias de cookies.";
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
		return "Administrar las cookies";
	}

	protected override string _GetTemplateForMessageEssentialCookiesItem3()
	{
		return "Gigya";
	}

	protected override string _GetTemplateForResponseAccessDenied()
	{
		return "Acceso denegado";
	}

	protected override string _GetTemplateForResponseAccessDeniedDescription()
	{
		return "No tienes permiso para ver esta página.";
	}

	protected override string _GetTemplateForResponseBadRequest()
	{
		return "Solicitud incorrecta";
	}

	protected override string _GetTemplateForResponseBadRequestDescription()
	{
		return "Ha habido un problema con tu solicitud.";
	}

	protected override string _GetTemplateForResponseInternalServerError()
	{
		return "Error interno del servidor";
	}

	protected override string _GetTemplateForResponseInternalServerErrorDescription()
	{
		return "Se ha producido un error inesperado.";
	}

	protected override string _GetTemplateForResponsePageNotFound()
	{
		return "Página no encontrada";
	}

	protected override string _GetTemplateForResponsePageNotFoundDescrition()
	{
		return "Página no encontrada o inexistente";
	}

	protected override string _GetTemplateForResponseRequestError()
	{
		return "Error con tu solicitud";
	}

	protected override string _GetTemplateForResponseSomethingWentWrong()
	{
		return "Algo ha ido mal.";
	}

	protected override string _GetTemplateForResponseTooManyAttemptsText()
	{
		return "Demasiados intentos.";
	}

	protected override string _GetTemplateForResponseUnexpectedError()
	{
		return "Se ha producido un error inesperado. Inténtalo de nuevo más tarde.";
	}
}
