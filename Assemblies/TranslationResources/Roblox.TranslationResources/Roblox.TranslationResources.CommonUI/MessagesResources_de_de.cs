namespace Roblox.TranslationResources.CommonUI;

/// <summary>
/// This class overrides MessagesResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class MessagesResources_de_de : MessagesResources_en_us, IMessagesResources, ITranslationResources
{
	/// <summary>
	/// Key: "Action.PreviousPage"
	/// button title
	/// English String: "Go to the Previous Page"
	/// </summary>
	public override string ActionPreviousPage => "Zurück zur vorherigen Seite";

	/// <summary>
	/// Key: "Action.ReturnHome"
	/// button title
	/// English String: "Return Home"
	/// </summary>
	public override string ActionReturnHome => "Zurück zum Hauptmenü";

	/// <summary>
	/// Key: "Label.Error"
	/// English String: "Error"
	/// </summary>
	public override string LabelError => "Fehler";

	/// <summary>
	/// Key: "Label.ErrorImage"
	/// alternate text shown for error image
	/// English String: "Error Image"
	/// </summary>
	public override string LabelErrorImage => "Fehlerbild";

	/// <summary>
	/// Key: "Label.TooManyCharacters"
	/// English String: "Too many characters!"
	/// </summary>
	public override string LabelTooManyCharacters => "Zu viele Zeichen!";

	/// <summary>
	/// Key: "Message.AlwaysAllowed"
	/// English String: "Always allowed"
	/// </summary>
	public override string MessageAlwaysAllowed => "Immer erlaubt";

	/// <summary>
	/// Key: "Message.AnalyiticsCookies"
	/// English String: "Analytics Cookies"
	/// </summary>
	public override string MessageAnalyiticsCookies => "Analyse-Cookies";

	/// <summary>
	/// Key: "Message.AnalyiticsCookiesDescription"
	/// English String: "These cookies used for improving site performance or understanding site usage."
	/// </summary>
	public override string MessageAnalyiticsCookiesDescription => "Diese Cookies werden benutzt, um die Leistung der Seite zu verbessern oder die Seitenbenutzung nachzuvollziehen.";

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
	public override string MessageEssentialCookies => "Benötigte Cookies";

	/// <summary>
	/// Key: "Message.EssentialCookiesDescription"
	/// English String: "These cookies are required to provide the functionality on the site, such as for user authentication, securing the system or saving cookie preferences."
	/// </summary>
	public override string MessageEssentialCookiesDescription => "Diese Cookies sind für die Funktionalität der Seite notwendig, zum Beispiel für die Benutzerauthentifizierung, zur Sicherung des Systems oder zum Speichern von Cookie-Vorlieben.";

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
	public override string MessageManageCookies => "Cookies verwalten";

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
	public override string ResponseAccessDenied => "Zugriff verweigert";

	/// <summary>
	/// Key: "Response.AccessDeniedDescription"
	/// 403 error message detail
	/// English String: "You don't have permission to view this page"
	/// </summary>
	public override string ResponseAccessDeniedDescription => "Du hast nicht die nötigen Rechte, um diese Seite anzuzeigen";

	/// <summary>
	/// Key: "Response.BadRequest"
	/// 400 error message title
	/// English String: "Bad Request"
	/// </summary>
	public override string ResponseBadRequest => "Anfragefehler";

	/// <summary>
	/// Key: "Response.BadRequestDescription"
	/// error message detail for 400 error
	/// English String: "There was a problem with your request"
	/// </summary>
	public override string ResponseBadRequestDescription => "Bei deiner Anfrage ist ein Problem aufgetreten";

	/// <summary>
	/// Key: "Response.InternalServerError"
	/// 500 error message title
	/// English String: "Internal Server Error"
	/// </summary>
	public override string ResponseInternalServerError => "Interner Serverfehler";

	/// <summary>
	/// Key: "Response.InternalServerErrorDescription"
	/// 500 error message description
	/// English String: "An unexpected error occurred"
	/// </summary>
	public override string ResponseInternalServerErrorDescription => "Es ist ein unerwarteter Fehler aufgetreten";

	/// <summary>
	/// Key: "Response.PageNotFound"
	/// 404 error message title
	/// English String: "Page Not found"
	/// </summary>
	public override string ResponsePageNotFound => "Seite nicht gefunden";

	/// <summary>
	/// Key: "Response.PageNotFoundDescrition"
	/// 404 error message description
	/// English String: "Page cannot be found or no longer exists"
	/// </summary>
	public override string ResponsePageNotFoundDescrition => "Seite konnte nicht gefunden werden oder sie existiert nicht";

	/// <summary>
	/// Key: "Response.RequestError"
	/// error message for incorrect request
	/// English String: "Error with your request"
	/// </summary>
	public override string ResponseRequestError => "Bei deiner Anfrage gab es einen Fehler";

	/// <summary>
	/// Key: "Response.SomethingWentWrong"
	/// default error message
	/// English String: "Something went wrong"
	/// </summary>
	public override string ResponseSomethingWentWrong => "Es ist ein Problem aufgetreten";

	/// <summary>
	/// Key: "Response.TooManyAttemptsText"
	/// English String: "Too Many Attempts"
	/// </summary>
	public override string ResponseTooManyAttemptsText => "Zu viele Versuche";

	/// <summary>
	/// Key: "Response.UnexpectedError"
	/// default error description
	/// English String: "An unexpected error occurred. Please try again later."
	/// </summary>
	public override string ResponseUnexpectedError => "Es ist ein unerwarteter Fehler aufgetreten. Bitte versuche es später erneut.";

	public MessagesResources_de_de(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionPreviousPage()
	{
		return "Zurück zur vorherigen Seite";
	}

	protected override string _GetTemplateForActionReturnHome()
	{
		return "Zurück zum Hauptmenü";
	}

	/// <summary>
	/// Key: "CookieLawNoticev2"
	/// Incorrect key, obsoleted
	/// English String: "Roblox uses cookies to personalize content, provide social media features and analyze the traffic on our site. To learn about how we use cookies and how you can {startLink}manage cookie preferences{endLink}, please refer to our {startLink2}Privacy and Cookie Policy{endLink2}."
	/// </summary>
	public override string CookieLawNoticev2(string startLink, string endLink, string startLink2, string endLink2)
	{
		return $"Roblox benutzt Cookies, um Inhalte zu personalisieren, Funktionen sozialer Medien anzubieten und den Datenverkehr auf unserer Website zu analysieren. Sieh dir unsere {startLink2}Datenschutz- und Cookie-Richtlinien{endLink2} an, um mehr darüber zu erfahren, wie wir Cookies einsetzen und wie du die {startLink}Cookie-Einstellungen anpassen{endLink} kannst.";
	}

	protected override string _GetTemplateForCookieLawNoticev2()
	{
		return "Roblox benutzt Cookies, um Inhalte zu personalisieren, Funktionen sozialer Medien anzubieten und den Datenverkehr auf unserer Website zu analysieren. Sieh dir unsere {startLink2}Datenschutz- und Cookie-Richtlinien{endLink2} an, um mehr darüber zu erfahren, wie wir Cookies einsetzen und wie du die {startLink}Cookie-Einstellungen anpassen{endLink} kannst.";
	}

	/// <summary>
	/// Key: "Description.ContactCustomerService"
	/// message shown on common error pages
	/// English String: "If you continue to receive this page, please contact customer service at {emailLink}"
	/// </summary>
	public override string DescriptionContactCustomerService(string emailLink)
	{
		return $"Wenn du weiterhin diese Seite siehst, wende dich bitte an unseren Kundenservice unter {emailLink}";
	}

	protected override string _GetTemplateForDescriptionContactCustomerService()
	{
		return "Wenn du weiterhin diese Seite siehst, wende dich bitte an unseren Kundenservice unter {emailLink}";
	}

	protected override string _GetTemplateForLabelError()
	{
		return "Fehler";
	}

	protected override string _GetTemplateForLabelErrorImage()
	{
		return "Fehlerbild";
	}

	protected override string _GetTemplateForLabelTooManyCharacters()
	{
		return "Zu viele Zeichen!";
	}

	protected override string _GetTemplateForMessageAlwaysAllowed()
	{
		return "Immer erlaubt";
	}

	protected override string _GetTemplateForMessageAnalyiticsCookies()
	{
		return "Analyse-Cookies";
	}

	protected override string _GetTemplateForMessageAnalyiticsCookiesDescription()
	{
		return "Diese Cookies werden benutzt, um die Leistung der Seite zu verbessern oder die Seitenbenutzung nachzuvollziehen.";
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
		return $"Roblox verwendet Cookies, um deine Nutzungserfahrung zu verbessern. Weitere Informationen, darunter auch Hinweise, wie du deine Einwilligung zurückziehen und die Verwendung von Cookies bei Roblox verwalten kannst, findest du in unseren {startLink}Datenschutz- und Cookie-Richtlinien{endLink}.";
	}

	protected override string _GetTemplateForMessageCookieLawNotice()
	{
		return "Roblox verwendet Cookies, um deine Nutzungserfahrung zu verbessern. Weitere Informationen, darunter auch Hinweise, wie du deine Einwilligung zurückziehen und die Verwendung von Cookies bei Roblox verwalten kannst, findest du in unseren {startLink}Datenschutz- und Cookie-Richtlinien{endLink}.";
	}

	/// <summary>
	/// Key: "Message.CookieLawNoticev2"
	/// English String: "Roblox uses cookies to personalize content, provide social media features and analyze the traffic on our site. To learn about how we use cookies and how you can {startLink}manage cookie preferences{endLink}, please refer to our {startLink2}Privacy and Cookie Policy{endLink2}."
	/// </summary>
	public override string MessageCookieLawNoticev2(string startLink, string endLink, string startLink2, string endLink2)
	{
		return $"Roblox benutzt Cookies, um die Inhalte zu personalisieren, Funktionen sozialer Medien anzubieten und den Datenverkehr auf unserer Website zu analysieren. Sieh dir unsere {startLink2}Datenschutz- und Cookie-Richtlinien{endLink2} an, um mehr darüber zu erfahren, wie wir Cookies einsetzen und wie du die {startLink}Cookie-Einstellungen anpassen{endLink} kannst.";
	}

	protected override string _GetTemplateForMessageCookieLawNoticev2()
	{
		return "Roblox benutzt Cookies, um die Inhalte zu personalisieren, Funktionen sozialer Medien anzubieten und den Datenverkehr auf unserer Website zu analysieren. Sieh dir unsere {startLink2}Datenschutz- und Cookie-Richtlinien{endLink2} an, um mehr darüber zu erfahren, wie wir Cookies einsetzen und wie du die {startLink}Cookie-Einstellungen anpassen{endLink} kannst.";
	}

	/// <summary>
	/// Key: "Message.CookieModalText"
	/// English String: "Please choose whether this site may use cookies as described below. You can learn more about how this site uses cookies and related technologies by reading our {startLink}privacy policy{endLink}."
	/// </summary>
	public override string MessageCookieModalText(string startLink, string endLink)
	{
		return $"Bitte wähle aus, ob diese Seite wie unten beschrieben Cookies benutzen darf. Du kannst mehr darüber erfahren, wie diese Seite Cookies und damit verbundene Technologien benutzt, indem du dir unsere {startLink}Datenschutzrichtlinien{endLink} durchliest.";
	}

	protected override string _GetTemplateForMessageCookieModalText()
	{
		return "Bitte wähle aus, ob diese Seite wie unten beschrieben Cookies benutzen darf. Du kannst mehr darüber erfahren, wie diese Seite Cookies und damit verbundene Technologien benutzt, indem du dir unsere {startLink}Datenschutzrichtlinien{endLink} durchliest.";
	}

	protected override string _GetTemplateForMessageEssentialCookies()
	{
		return "Benötigte Cookies";
	}

	protected override string _GetTemplateForMessageEssentialCookiesDescription()
	{
		return "Diese Cookies sind für die Funktionalität der Seite notwendig, zum Beispiel für die Benutzerauthentifizierung, zur Sicherung des Systems oder zum Speichern von Cookie-Vorlieben.";
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
		return "Cookies verwalten";
	}

	protected override string _GetTemplateForMessageEssentialCookiesItem3()
	{
		return "Gigya";
	}

	protected override string _GetTemplateForResponseAccessDenied()
	{
		return "Zugriff verweigert";
	}

	protected override string _GetTemplateForResponseAccessDeniedDescription()
	{
		return "Du hast nicht die nötigen Rechte, um diese Seite anzuzeigen";
	}

	protected override string _GetTemplateForResponseBadRequest()
	{
		return "Anfragefehler";
	}

	protected override string _GetTemplateForResponseBadRequestDescription()
	{
		return "Bei deiner Anfrage ist ein Problem aufgetreten";
	}

	protected override string _GetTemplateForResponseInternalServerError()
	{
		return "Interner Serverfehler";
	}

	protected override string _GetTemplateForResponseInternalServerErrorDescription()
	{
		return "Es ist ein unerwarteter Fehler aufgetreten";
	}

	protected override string _GetTemplateForResponsePageNotFound()
	{
		return "Seite nicht gefunden";
	}

	protected override string _GetTemplateForResponsePageNotFoundDescrition()
	{
		return "Seite konnte nicht gefunden werden oder sie existiert nicht";
	}

	protected override string _GetTemplateForResponseRequestError()
	{
		return "Bei deiner Anfrage gab es einen Fehler";
	}

	protected override string _GetTemplateForResponseSomethingWentWrong()
	{
		return "Es ist ein Problem aufgetreten";
	}

	protected override string _GetTemplateForResponseTooManyAttemptsText()
	{
		return "Zu viele Versuche";
	}

	protected override string _GetTemplateForResponseUnexpectedError()
	{
		return "Es ist ein unerwarteter Fehler aufgetreten. Bitte versuche es später erneut.";
	}
}
