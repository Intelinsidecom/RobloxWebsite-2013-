namespace Roblox.TranslationResources.CommonUI;

/// <summary>
/// This class overrides MessagesResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class MessagesResources_it_it : MessagesResources_en_us, IMessagesResources, ITranslationResources
{
	/// <summary>
	/// Key: "Action.PreviousPage"
	/// button title
	/// English String: "Go to the Previous Page"
	/// </summary>
	public override string ActionPreviousPage => "Vai alla pagina precedente";

	/// <summary>
	/// Key: "Action.ReturnHome"
	/// button title
	/// English String: "Return Home"
	/// </summary>
	public override string ActionReturnHome => "Torna alla Home";

	/// <summary>
	/// Key: "Label.Error"
	/// English String: "Error"
	/// </summary>
	public override string LabelError => "Errore";

	/// <summary>
	/// Key: "Label.ErrorImage"
	/// alternate text shown for error image
	/// English String: "Error Image"
	/// </summary>
	public override string LabelErrorImage => "Immagine d'errore";

	/// <summary>
	/// Key: "Label.TooManyCharacters"
	/// English String: "Too many characters!"
	/// </summary>
	public override string LabelTooManyCharacters => "Troppi caratteri!";

	/// <summary>
	/// Key: "Message.AlwaysAllowed"
	/// English String: "Always allowed"
	/// </summary>
	public override string MessageAlwaysAllowed => "Sempre consentiti";

	/// <summary>
	/// Key: "Message.AnalyiticsCookies"
	/// English String: "Analytics Cookies"
	/// </summary>
	public override string MessageAnalyiticsCookies => "Cookie analitici";

	/// <summary>
	/// Key: "Message.AnalyiticsCookiesDescription"
	/// English String: "These cookies used for improving site performance or understanding site usage."
	/// </summary>
	public override string MessageAnalyiticsCookiesDescription => "Questi cookie servono per migliorare le prestazioni del sito o per comprendere come viene utilizzato il sito.";

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
	public override string MessageEssentialCookies => "Cookie essenziali";

	/// <summary>
	/// Key: "Message.EssentialCookiesDescription"
	/// English String: "These cookies are required to provide the functionality on the site, such as for user authentication, securing the system or saving cookie preferences."
	/// </summary>
	public override string MessageEssentialCookiesDescription => "Questi cookie sono necessari per alcune funzionalità del sito, come l'autenticazione dell'utente, la sicurezza del sistema o il salvataggio delle preferenze sui cookie.";

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
	public override string MessageManageCookies => "Gestisci cookie";

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
	public override string ResponseAccessDenied => "Accesso negato";

	/// <summary>
	/// Key: "Response.AccessDeniedDescription"
	/// 403 error message detail
	/// English String: "You don't have permission to view this page"
	/// </summary>
	public override string ResponseAccessDeniedDescription => "Non hai i permessi necessari per visualizzare questa pagina";

	/// <summary>
	/// Key: "Response.BadRequest"
	/// 400 error message title
	/// English String: "Bad Request"
	/// </summary>
	public override string ResponseBadRequest => "Richiesta errata";

	/// <summary>
	/// Key: "Response.BadRequestDescription"
	/// error message detail for 400 error
	/// English String: "There was a problem with your request"
	/// </summary>
	public override string ResponseBadRequestDescription => "C'è stato un problema con la tua richiesta";

	/// <summary>
	/// Key: "Response.InternalServerError"
	/// 500 error message title
	/// English String: "Internal Server Error"
	/// </summary>
	public override string ResponseInternalServerError => "Errore interno del server";

	/// <summary>
	/// Key: "Response.InternalServerErrorDescription"
	/// 500 error message description
	/// English String: "An unexpected error occurred"
	/// </summary>
	public override string ResponseInternalServerErrorDescription => "Si è verificato un errore imprevisto.";

	/// <summary>
	/// Key: "Response.PageNotFound"
	/// 404 error message title
	/// English String: "Page Not found"
	/// </summary>
	public override string ResponsePageNotFound => "Pagina non trovata";

	/// <summary>
	/// Key: "Response.PageNotFoundDescrition"
	/// 404 error message description
	/// English String: "Page cannot be found or no longer exists"
	/// </summary>
	public override string ResponsePageNotFoundDescrition => "La pagina non è stata trovata o è stata rimossa";

	/// <summary>
	/// Key: "Response.RequestError"
	/// error message for incorrect request
	/// English String: "Error with your request"
	/// </summary>
	public override string ResponseRequestError => "Errore con la tua richiesta";

	/// <summary>
	/// Key: "Response.SomethingWentWrong"
	/// default error message
	/// English String: "Something went wrong"
	/// </summary>
	public override string ResponseSomethingWentWrong => "Qualcosa è andato storto";

	/// <summary>
	/// Key: "Response.TooManyAttemptsText"
	/// English String: "Too Many Attempts"
	/// </summary>
	public override string ResponseTooManyAttemptsText => "Troppi tentativi.";

	/// <summary>
	/// Key: "Response.UnexpectedError"
	/// default error description
	/// English String: "An unexpected error occurred. Please try again later."
	/// </summary>
	public override string ResponseUnexpectedError => "Si è verificato un errore imprevisto. Riprova più tardi.";

	public MessagesResources_it_it(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionPreviousPage()
	{
		return "Vai alla pagina precedente";
	}

	protected override string _GetTemplateForActionReturnHome()
	{
		return "Torna alla Home";
	}

	/// <summary>
	/// Key: "CookieLawNoticev2"
	/// Incorrect key, obsoleted
	/// English String: "Roblox uses cookies to personalize content, provide social media features and analyze the traffic on our site. To learn about how we use cookies and how you can {startLink}manage cookie preferences{endLink}, please refer to our {startLink2}Privacy and Cookie Policy{endLink2}."
	/// </summary>
	public override string CookieLawNoticev2(string startLink, string endLink, string startLink2, string endLink2)
	{
		return $"Roblox utilizza i cookie per personalizzare il contenuto, fornire funzionalità relative ai social media e analizzare il traffico sul nostro sito. Per scoprire come utilizziamo i cookie e come puoi {startLink}gestire le preferenze dei cookie{endLink}, fai riferimento alla nostra {startLink2}Informativa sulla privacy e sui cookie{endLink2}.";
	}

	protected override string _GetTemplateForCookieLawNoticev2()
	{
		return "Roblox utilizza i cookie per personalizzare il contenuto, fornire funzionalità relative ai social media e analizzare il traffico sul nostro sito. Per scoprire come utilizziamo i cookie e come puoi {startLink}gestire le preferenze dei cookie{endLink}, fai riferimento alla nostra {startLink2}Informativa sulla privacy e sui cookie{endLink2}.";
	}

	/// <summary>
	/// Key: "Description.ContactCustomerService"
	/// message shown on common error pages
	/// English String: "If you continue to receive this page, please contact customer service at {emailLink}"
	/// </summary>
	public override string DescriptionContactCustomerService(string emailLink)
	{
		return $"Se continui a ricevere questa pagina, contatta l'assistenza clienti a questo indirizzo: {emailLink}";
	}

	protected override string _GetTemplateForDescriptionContactCustomerService()
	{
		return "Se continui a ricevere questa pagina, contatta l'assistenza clienti a questo indirizzo: {emailLink}";
	}

	protected override string _GetTemplateForLabelError()
	{
		return "Errore";
	}

	protected override string _GetTemplateForLabelErrorImage()
	{
		return "Immagine d'errore";
	}

	protected override string _GetTemplateForLabelTooManyCharacters()
	{
		return "Troppi caratteri!";
	}

	protected override string _GetTemplateForMessageAlwaysAllowed()
	{
		return "Sempre consentiti";
	}

	protected override string _GetTemplateForMessageAnalyiticsCookies()
	{
		return "Cookie analitici";
	}

	protected override string _GetTemplateForMessageAnalyiticsCookiesDescription()
	{
		return "Questi cookie servono per migliorare le prestazioni del sito o per comprendere come viene utilizzato il sito.";
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
		return $"Roblox utilizza i cookie per offrirti un'esperienza migliore. Puoi trovare maggiori informazioni su come gestirne l'uso in Roblox o ritirare il tuo consenso tramite {startLink}Informativa sulla privacy e sui cookie{endLink}.";
	}

	protected override string _GetTemplateForMessageCookieLawNotice()
	{
		return "Roblox utilizza i cookie per offrirti un'esperienza migliore. Puoi trovare maggiori informazioni su come gestirne l'uso in Roblox o ritirare il tuo consenso tramite {startLink}Informativa sulla privacy e sui cookie{endLink}.";
	}

	/// <summary>
	/// Key: "Message.CookieLawNoticev2"
	/// English String: "Roblox uses cookies to personalize content, provide social media features and analyze the traffic on our site. To learn about how we use cookies and how you can {startLink}manage cookie preferences{endLink}, please refer to our {startLink2}Privacy and Cookie Policy{endLink2}."
	/// </summary>
	public override string MessageCookieLawNoticev2(string startLink, string endLink, string startLink2, string endLink2)
	{
		return $"Roblox utilizza i cookie per personalizzare il contenuto, fornire funzionalità relative ai social media e analizzare il traffico sul nostro sito. Per scoprire come utilizziamo i cookie e come puoi {startLink}gestire le preferenze dei cookie{endLink}, fai riferimento alla nostra {startLink2}Informativa sulla privacy e sui cookie{endLink2}.";
	}

	protected override string _GetTemplateForMessageCookieLawNoticev2()
	{
		return "Roblox utilizza i cookie per personalizzare il contenuto, fornire funzionalità relative ai social media e analizzare il traffico sul nostro sito. Per scoprire come utilizziamo i cookie e come puoi {startLink}gestire le preferenze dei cookie{endLink}, fai riferimento alla nostra {startLink2}Informativa sulla privacy e sui cookie{endLink2}.";
	}

	/// <summary>
	/// Key: "Message.CookieModalText"
	/// English String: "Please choose whether this site may use cookies as described below. You can learn more about how this site uses cookies and related technologies by reading our {startLink}privacy policy{endLink}."
	/// </summary>
	public override string MessageCookieModalText(string startLink, string endLink)
	{
		return $"Scegli se autorizzare questo sito a usare i cookie come descritto di seguito. Per maggiori dettagli su come questo sito utilizza i cookie e le relative tecnologie, leggi la nostra {startLink}Informativa sulla privacy{endLink}.";
	}

	protected override string _GetTemplateForMessageCookieModalText()
	{
		return "Scegli se autorizzare questo sito a usare i cookie come descritto di seguito. Per maggiori dettagli su come questo sito utilizza i cookie e le relative tecnologie, leggi la nostra {startLink}Informativa sulla privacy{endLink}.";
	}

	protected override string _GetTemplateForMessageEssentialCookies()
	{
		return "Cookie essenziali";
	}

	protected override string _GetTemplateForMessageEssentialCookiesDescription()
	{
		return "Questi cookie sono necessari per alcune funzionalità del sito, come l'autenticazione dell'utente, la sicurezza del sistema o il salvataggio delle preferenze sui cookie.";
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
		return "Gestisci cookie";
	}

	protected override string _GetTemplateForMessageEssentialCookiesItem3()
	{
		return "Gigya";
	}

	protected override string _GetTemplateForResponseAccessDenied()
	{
		return "Accesso negato";
	}

	protected override string _GetTemplateForResponseAccessDeniedDescription()
	{
		return "Non hai i permessi necessari per visualizzare questa pagina";
	}

	protected override string _GetTemplateForResponseBadRequest()
	{
		return "Richiesta errata";
	}

	protected override string _GetTemplateForResponseBadRequestDescription()
	{
		return "C'è stato un problema con la tua richiesta";
	}

	protected override string _GetTemplateForResponseInternalServerError()
	{
		return "Errore interno del server";
	}

	protected override string _GetTemplateForResponseInternalServerErrorDescription()
	{
		return "Si è verificato un errore imprevisto.";
	}

	protected override string _GetTemplateForResponsePageNotFound()
	{
		return "Pagina non trovata";
	}

	protected override string _GetTemplateForResponsePageNotFoundDescrition()
	{
		return "La pagina non è stata trovata o è stata rimossa";
	}

	protected override string _GetTemplateForResponseRequestError()
	{
		return "Errore con la tua richiesta";
	}

	protected override string _GetTemplateForResponseSomethingWentWrong()
	{
		return "Qualcosa è andato storto";
	}

	protected override string _GetTemplateForResponseTooManyAttemptsText()
	{
		return "Troppi tentativi.";
	}

	protected override string _GetTemplateForResponseUnexpectedError()
	{
		return "Si è verificato un errore imprevisto. Riprova più tardi.";
	}
}
