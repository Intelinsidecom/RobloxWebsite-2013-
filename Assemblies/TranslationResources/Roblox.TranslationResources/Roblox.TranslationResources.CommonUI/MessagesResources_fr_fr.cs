namespace Roblox.TranslationResources.CommonUI;

/// <summary>
/// This class overrides MessagesResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class MessagesResources_fr_fr : MessagesResources_en_us, IMessagesResources, ITranslationResources
{
	/// <summary>
	/// Key: "Action.PreviousPage"
	/// button title
	/// English String: "Go to the Previous Page"
	/// </summary>
	public override string ActionPreviousPage => "Aller à la page précédente";

	/// <summary>
	/// Key: "Action.ReturnHome"
	/// button title
	/// English String: "Return Home"
	/// </summary>
	public override string ActionReturnHome => "Retour à l'accueil";

	/// <summary>
	/// Key: "Label.Error"
	/// English String: "Error"
	/// </summary>
	public override string LabelError => "Erreur";

	/// <summary>
	/// Key: "Label.ErrorImage"
	/// alternate text shown for error image
	/// English String: "Error Image"
	/// </summary>
	public override string LabelErrorImage => "Erreur image";

	/// <summary>
	/// Key: "Label.TooManyCharacters"
	/// English String: "Too many characters!"
	/// </summary>
	public override string LabelTooManyCharacters => "Trop de caractères\u00a0!";

	/// <summary>
	/// Key: "Message.AlwaysAllowed"
	/// English String: "Always allowed"
	/// </summary>
	public override string MessageAlwaysAllowed => "Toujours autorisés";

	/// <summary>
	/// Key: "Message.AnalyiticsCookies"
	/// English String: "Analytics Cookies"
	/// </summary>
	public override string MessageAnalyiticsCookies => "Cookies d'analyse";

	/// <summary>
	/// Key: "Message.AnalyiticsCookiesDescription"
	/// English String: "These cookies used for improving site performance or understanding site usage."
	/// </summary>
	public override string MessageAnalyiticsCookiesDescription => "Ces cookies servent à améliorer les performances du site ou la compréhension de son utilisation.";

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
	public override string MessageEssentialCookies => "Cookies essentiels";

	/// <summary>
	/// Key: "Message.EssentialCookiesDescription"
	/// English String: "These cookies are required to provide the functionality on the site, such as for user authentication, securing the system or saving cookie preferences."
	/// </summary>
	public override string MessageEssentialCookiesDescription => "Ces cookies sont nécessaires pour utiliser certaines fonctionnalités du site, telles que l'authentification des utilisateurs, la sécurisation du système et les préférences d'enregistrement des cookies.";

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
	public override string MessageManageCookies => "Gérer les cookies";

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
	public override string ResponseAccessDenied => "Accès refusé";

	/// <summary>
	/// Key: "Response.AccessDeniedDescription"
	/// 403 error message detail
	/// English String: "You don't have permission to view this page"
	/// </summary>
	public override string ResponseAccessDeniedDescription => "Vous n'avez pas l'autorisation de voir cette page";

	/// <summary>
	/// Key: "Response.BadRequest"
	/// 400 error message title
	/// English String: "Bad Request"
	/// </summary>
	public override string ResponseBadRequest => "Erreur de requête";

	/// <summary>
	/// Key: "Response.BadRequestDescription"
	/// error message detail for 400 error
	/// English String: "There was a problem with your request"
	/// </summary>
	public override string ResponseBadRequestDescription => "Votre requête a rencontré un problème";

	/// <summary>
	/// Key: "Response.InternalServerError"
	/// 500 error message title
	/// English String: "Internal Server Error"
	/// </summary>
	public override string ResponseInternalServerError => "Erreur serveur interne";

	/// <summary>
	/// Key: "Response.InternalServerErrorDescription"
	/// 500 error message description
	/// English String: "An unexpected error occurred"
	/// </summary>
	public override string ResponseInternalServerErrorDescription => "Une erreur inattendue est survenue.";

	/// <summary>
	/// Key: "Response.PageNotFound"
	/// 404 error message title
	/// English String: "Page Not found"
	/// </summary>
	public override string ResponsePageNotFound => "Page introuvable";

	/// <summary>
	/// Key: "Response.PageNotFoundDescrition"
	/// 404 error message description
	/// English String: "Page cannot be found or no longer exists"
	/// </summary>
	public override string ResponsePageNotFoundDescrition => "La page est introuvable ou n'existe plus";

	/// <summary>
	/// Key: "Response.RequestError"
	/// error message for incorrect request
	/// English String: "Error with your request"
	/// </summary>
	public override string ResponseRequestError => "Erreur avec votre requête";

	/// <summary>
	/// Key: "Response.SomethingWentWrong"
	/// default error message
	/// English String: "Something went wrong"
	/// </summary>
	public override string ResponseSomethingWentWrong => "Quelque chose s'est mal passé";

	/// <summary>
	/// Key: "Response.TooManyAttemptsText"
	/// English String: "Too Many Attempts"
	/// </summary>
	public override string ResponseTooManyAttemptsText => "Trop de tentatives";

	/// <summary>
	/// Key: "Response.UnexpectedError"
	/// default error description
	/// English String: "An unexpected error occurred. Please try again later."
	/// </summary>
	public override string ResponseUnexpectedError => "Une erreur inconnue est survenue. Veuillez réessayer plus tard.";

	public MessagesResources_fr_fr(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionPreviousPage()
	{
		return "Aller à la page précédente";
	}

	protected override string _GetTemplateForActionReturnHome()
	{
		return "Retour à l'accueil";
	}

	/// <summary>
	/// Key: "CookieLawNoticev2"
	/// Incorrect key, obsoleted
	/// English String: "Roblox uses cookies to personalize content, provide social media features and analyze the traffic on our site. To learn about how we use cookies and how you can {startLink}manage cookie preferences{endLink}, please refer to our {startLink2}Privacy and Cookie Policy{endLink2}."
	/// </summary>
	public override string CookieLawNoticev2(string startLink, string endLink, string startLink2, string endLink2)
	{
		return $"Roblox utilise les cookies pour l'affichage de contenu personnalisé, les fonctionnalités des réseaux sociaux et l'analyse du trafic sur le site. Pour en savoir plus sur la façon dont nous utilisons les cookies et comment vous pouvez {startLink}gérer les préférences des cookies{endLink}, veuillez consulter notre {startLink2}Politique de confidentialité et de cookies{endLink2}.";
	}

	protected override string _GetTemplateForCookieLawNoticev2()
	{
		return "Roblox utilise les cookies pour l'affichage de contenu personnalisé, les fonctionnalités des réseaux sociaux et l'analyse du trafic sur le site. Pour en savoir plus sur la façon dont nous utilisons les cookies et comment vous pouvez {startLink}gérer les préférences des cookies{endLink}, veuillez consulter notre {startLink2}Politique de confidentialité et de cookies{endLink2}.";
	}

	/// <summary>
	/// Key: "Description.ContactCustomerService"
	/// message shown on common error pages
	/// English String: "If you continue to receive this page, please contact customer service at {emailLink}"
	/// </summary>
	public override string DescriptionContactCustomerService(string emailLink)
	{
		return $"Si vous continuez de recevoir cette page, veuillez contacter notre assistance clientèle à l'adresse\u00a0: {emailLink}";
	}

	protected override string _GetTemplateForDescriptionContactCustomerService()
	{
		return "Si vous continuez de recevoir cette page, veuillez contacter notre assistance clientèle à l'adresse\u00a0: {emailLink}";
	}

	protected override string _GetTemplateForLabelError()
	{
		return "Erreur";
	}

	protected override string _GetTemplateForLabelErrorImage()
	{
		return "Erreur image";
	}

	protected override string _GetTemplateForLabelTooManyCharacters()
	{
		return "Trop de caractères\u00a0!";
	}

	protected override string _GetTemplateForMessageAlwaysAllowed()
	{
		return "Toujours autorisés";
	}

	protected override string _GetTemplateForMessageAnalyiticsCookies()
	{
		return "Cookies d'analyse";
	}

	protected override string _GetTemplateForMessageAnalyiticsCookiesDescription()
	{
		return "Ces cookies servent à améliorer les performances du site ou la compréhension de son utilisation.";
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
		return $"Roblox utilise des cookies afin d'améliorer votre expérience. Pour plus d'informations, notamment sur la manière de retirer votre autorisation et gérer l'utilisation des cookies sur Roblox, veuillez consulter notre {startLink}politique de confidentialité et relative aux cookies{endLink}.";
	}

	protected override string _GetTemplateForMessageCookieLawNotice()
	{
		return "Roblox utilise des cookies afin d'améliorer votre expérience. Pour plus d'informations, notamment sur la manière de retirer votre autorisation et gérer l'utilisation des cookies sur Roblox, veuillez consulter notre {startLink}politique de confidentialité et relative aux cookies{endLink}.";
	}

	/// <summary>
	/// Key: "Message.CookieLawNoticev2"
	/// English String: "Roblox uses cookies to personalize content, provide social media features and analyze the traffic on our site. To learn about how we use cookies and how you can {startLink}manage cookie preferences{endLink}, please refer to our {startLink2}Privacy and Cookie Policy{endLink2}."
	/// </summary>
	public override string MessageCookieLawNoticev2(string startLink, string endLink, string startLink2, string endLink2)
	{
		return $"Roblox utilise les cookies pour l'affichage de contenu personnalisé, les fonctionnalités des réseaux sociaux et l'analyse du trafic sur le site. Pour en savoir plus sur la façon dont nous utilisons les cookies et comment vous pouvez {startLink}gérer les préférences des cookies{endLink}, veuillez consulter notre {startLink2}Politique de confidentialité et de cookies{endLink2}.";
	}

	protected override string _GetTemplateForMessageCookieLawNoticev2()
	{
		return "Roblox utilise les cookies pour l'affichage de contenu personnalisé, les fonctionnalités des réseaux sociaux et l'analyse du trafic sur le site. Pour en savoir plus sur la façon dont nous utilisons les cookies et comment vous pouvez {startLink}gérer les préférences des cookies{endLink}, veuillez consulter notre {startLink2}Politique de confidentialité et de cookies{endLink2}.";
	}

	/// <summary>
	/// Key: "Message.CookieModalText"
	/// English String: "Please choose whether this site may use cookies as described below. You can learn more about how this site uses cookies and related technologies by reading our {startLink}privacy policy{endLink}."
	/// </summary>
	public override string MessageCookieModalText(string startLink, string endLink)
	{
		return $"Décidez si vous voulez autoriser ce site à utiliser des cookies comme décrit ci-dessous. Découvrez comment ils sont utilisés ainsi que les technologies liées en lisant notre {startLink}politique de confidentialité{endLink}.";
	}

	protected override string _GetTemplateForMessageCookieModalText()
	{
		return "Décidez si vous voulez autoriser ce site à utiliser des cookies comme décrit ci-dessous. Découvrez comment ils sont utilisés ainsi que les technologies liées en lisant notre {startLink}politique de confidentialité{endLink}.";
	}

	protected override string _GetTemplateForMessageEssentialCookies()
	{
		return "Cookies essentiels";
	}

	protected override string _GetTemplateForMessageEssentialCookiesDescription()
	{
		return "Ces cookies sont nécessaires pour utiliser certaines fonctionnalités du site, telles que l'authentification des utilisateurs, la sécurisation du système et les préférences d'enregistrement des cookies.";
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
		return "Gérer les cookies";
	}

	protected override string _GetTemplateForMessageEssentialCookiesItem3()
	{
		return "Gigya";
	}

	protected override string _GetTemplateForResponseAccessDenied()
	{
		return "Accès refusé";
	}

	protected override string _GetTemplateForResponseAccessDeniedDescription()
	{
		return "Vous n'avez pas l'autorisation de voir cette page";
	}

	protected override string _GetTemplateForResponseBadRequest()
	{
		return "Erreur de requête";
	}

	protected override string _GetTemplateForResponseBadRequestDescription()
	{
		return "Votre requête a rencontré un problème";
	}

	protected override string _GetTemplateForResponseInternalServerError()
	{
		return "Erreur serveur interne";
	}

	protected override string _GetTemplateForResponseInternalServerErrorDescription()
	{
		return "Une erreur inattendue est survenue.";
	}

	protected override string _GetTemplateForResponsePageNotFound()
	{
		return "Page introuvable";
	}

	protected override string _GetTemplateForResponsePageNotFoundDescrition()
	{
		return "La page est introuvable ou n'existe plus";
	}

	protected override string _GetTemplateForResponseRequestError()
	{
		return "Erreur avec votre requête";
	}

	protected override string _GetTemplateForResponseSomethingWentWrong()
	{
		return "Quelque chose s'est mal passé";
	}

	protected override string _GetTemplateForResponseTooManyAttemptsText()
	{
		return "Trop de tentatives";
	}

	protected override string _GetTemplateForResponseUnexpectedError()
	{
		return "Une erreur inconnue est survenue. Veuillez réessayer plus tard.";
	}
}
