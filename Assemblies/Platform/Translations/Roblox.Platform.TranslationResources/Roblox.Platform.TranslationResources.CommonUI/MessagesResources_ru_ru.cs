namespace Roblox.TranslationResources.CommonUI;

/// <summary>
/// This class overrides MessagesResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class MessagesResources_ru_ru : MessagesResources_en_us, IMessagesResources, ITranslationResources
{
	/// <summary>
	/// Key: "Action.PreviousPage"
	/// button title
	/// English String: "Go to the Previous Page"
	/// </summary>
	public override string ActionPreviousPage => "Вернуться на предыдущую страницу";

	/// <summary>
	/// Key: "Action.ReturnHome"
	/// button title
	/// English String: "Return Home"
	/// </summary>
	public override string ActionReturnHome => "Домой";

	/// <summary>
	/// Key: "Label.Error"
	/// English String: "Error"
	/// </summary>
	public override string LabelError => "Ошибка";

	/// <summary>
	/// Key: "Label.ErrorImage"
	/// alternate text shown for error image
	/// English String: "Error Image"
	/// </summary>
	public override string LabelErrorImage => "Ошибка изображения";

	/// <summary>
	/// Key: "Label.TooManyCharacters"
	/// English String: "Too many characters!"
	/// </summary>
	public override string LabelTooManyCharacters => "Слишком много символов!";

	/// <summary>
	/// Key: "Message.AlwaysAllowed"
	/// English String: "Always allowed"
	/// </summary>
	public override string MessageAlwaysAllowed => "Всегда разрешено";

	/// <summary>
	/// Key: "Message.AnalyiticsCookies"
	/// English String: "Analytics Cookies"
	/// </summary>
	public override string MessageAnalyiticsCookies => "Аналитика файлов cookies";

	/// <summary>
	/// Key: "Message.AnalyiticsCookiesDescription"
	/// English String: "These cookies used for improving site performance or understanding site usage."
	/// </summary>
	public override string MessageAnalyiticsCookiesDescription => "Файлы cookies используются для повышения производительности сайта и выяснения целей его использования.";

	/// <summary>
	/// Key: "Message.AnalyiticsCookiesItem1"
	/// English String: "Google Analytics"
	/// </summary>
	public override string MessageAnalyiticsCookiesItem1 => "Аналитика Google";

	/// <summary>
	/// Key: "Message.AnalyiticsCookiesItem2"
	/// English String: "Google Universal Analytics"
	/// </summary>
	public override string MessageAnalyiticsCookiesItem2 => "Универсальная аналитика Google";

	/// <summary>
	/// Key: "Message.EssentialCookies"
	/// English String: "Essential Cookies"
	/// </summary>
	public override string MessageEssentialCookies => "Необходимые файлы cookies";

	/// <summary>
	/// Key: "Message.EssentialCookiesDescription"
	/// English String: "These cookies are required to provide the functionality on the site, such as for user authentication, securing the system or saving cookie preferences."
	/// </summary>
	public override string MessageEssentialCookiesDescription => "Файлы cookies необходимы для осуществления полноценного функционирования сайта, например, для аутентефикации пользователя, безопасности и сохранения пользовательских данных.";

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
	public override string MessageManageCookies => "Управление файлами cookies";

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
	public override string ResponseAccessDenied => "Доступ закрыт";

	/// <summary>
	/// Key: "Response.AccessDeniedDescription"
	/// 403 error message detail
	/// English String: "You don't have permission to view this page"
	/// </summary>
	public override string ResponseAccessDeniedDescription => "У вас нет разрешения на просмотр этой страницы";

	/// <summary>
	/// Key: "Response.BadRequest"
	/// 400 error message title
	/// English String: "Bad Request"
	/// </summary>
	public override string ResponseBadRequest => "Некорректный запрос";

	/// <summary>
	/// Key: "Response.BadRequestDescription"
	/// error message detail for 400 error
	/// English String: "There was a problem with your request"
	/// </summary>
	public override string ResponseBadRequestDescription => "С вашим запросом произошла ошибка";

	/// <summary>
	/// Key: "Response.InternalServerError"
	/// 500 error message title
	/// English String: "Internal Server Error"
	/// </summary>
	public override string ResponseInternalServerError => "Внутренняя ошибка сервера";

	/// <summary>
	/// Key: "Response.InternalServerErrorDescription"
	/// 500 error message description
	/// English String: "An unexpected error occurred"
	/// </summary>
	public override string ResponseInternalServerErrorDescription => "Произошла непредвиденная ошибка";

	/// <summary>
	/// Key: "Response.PageNotFound"
	/// 404 error message title
	/// English String: "Page Not found"
	/// </summary>
	public override string ResponsePageNotFound => "Страница не найдена";

	/// <summary>
	/// Key: "Response.PageNotFoundDescrition"
	/// 404 error message description
	/// English String: "Page cannot be found or no longer exists"
	/// </summary>
	public override string ResponsePageNotFoundDescrition => "Страница не найдена или не существует";

	/// <summary>
	/// Key: "Response.RequestError"
	/// error message for incorrect request
	/// English String: "Error with your request"
	/// </summary>
	public override string ResponseRequestError => "Ошибка вашего запроса";

	/// <summary>
	/// Key: "Response.SomethingWentWrong"
	/// default error message
	/// English String: "Something went wrong"
	/// </summary>
	public override string ResponseSomethingWentWrong => "Что-то пошло не так";

	/// <summary>
	/// Key: "Response.TooManyAttemptsText"
	/// English String: "Too Many Attempts"
	/// </summary>
	public override string ResponseTooManyAttemptsText => "Слишком много попыток";

	/// <summary>
	/// Key: "Response.UnexpectedError"
	/// default error description
	/// English String: "An unexpected error occurred. Please try again later."
	/// </summary>
	public override string ResponseUnexpectedError => "Произошла неизвестная ошибка. Повторите попытку позже.";

	public MessagesResources_ru_ru(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionPreviousPage()
	{
		return "Вернуться на предыдущую страницу";
	}

	protected override string _GetTemplateForActionReturnHome()
	{
		return "Домой";
	}

	/// <summary>
	/// Key: "CookieLawNoticev2"
	/// Incorrect key, obsoleted
	/// English String: "Roblox uses cookies to personalize content, provide social media features and analyze the traffic on our site. To learn about how we use cookies and how you can {startLink}manage cookie preferences{endLink}, please refer to our {startLink2}Privacy and Cookie Policy{endLink2}."
	/// </summary>
	public override string CookieLawNoticev2(string startLink, string endLink, string startLink2, string endLink2)
	{
		return $"Roblox использует файлы-cookies для персонализации контента, предоставления возможностей социальных сетей и анализа траффика на нашем сайте. Для получения сведений об использовании файлов-cookies и {startLink}их настройке{endLink}, пожалуйста, ознакомьтесь с нашими {startLink2}Политикой конфиденциальности и использованием файлов-cookies{endLink2}.";
	}

	protected override string _GetTemplateForCookieLawNoticev2()
	{
		return "Roblox использует файлы-cookies для персонализации контента, предоставления возможностей социальных сетей и анализа траффика на нашем сайте. Для получения сведений об использовании файлов-cookies и {startLink}их настройке{endLink}, пожалуйста, ознакомьтесь с нашими {startLink2}Политикой конфиденциальности и использованием файлов-cookies{endLink2}.";
	}

	/// <summary>
	/// Key: "Description.ContactCustomerService"
	/// message shown on common error pages
	/// English String: "If you continue to receive this page, please contact customer service at {emailLink}"
	/// </summary>
	public override string DescriptionContactCustomerService(string emailLink)
	{
		return $"Если у вас продолжает появляться эта страница, пожалуйста, свяжитесь с обслуживанием клиентов: {emailLink}";
	}

	protected override string _GetTemplateForDescriptionContactCustomerService()
	{
		return "Если у вас продолжает появляться эта страница, пожалуйста, свяжитесь с обслуживанием клиентов: {emailLink}";
	}

	protected override string _GetTemplateForLabelError()
	{
		return "Ошибка";
	}

	protected override string _GetTemplateForLabelErrorImage()
	{
		return "Ошибка изображения";
	}

	protected override string _GetTemplateForLabelTooManyCharacters()
	{
		return "Слишком много символов!";
	}

	protected override string _GetTemplateForMessageAlwaysAllowed()
	{
		return "Всегда разрешено";
	}

	protected override string _GetTemplateForMessageAnalyiticsCookies()
	{
		return "Аналитика файлов cookies";
	}

	protected override string _GetTemplateForMessageAnalyiticsCookiesDescription()
	{
		return "Файлы cookies используются для повышения производительности сайта и выяснения целей его использования.";
	}

	protected override string _GetTemplateForMessageAnalyiticsCookiesItem1()
	{
		return "Аналитика Google";
	}

	protected override string _GetTemplateForMessageAnalyiticsCookiesItem2()
	{
		return "Универсальная аналитика Google";
	}

	/// <summary>
	/// Key: "Message.CookieLawNotice"
	/// Cookies are used for Internet-based data storage, and this message warns users that we use them to improve their experience. See https://en.wikipedia.org/wiki/HTTP_cookie for more information.
	/// English String: "Roblox uses cookies to offer you a better experience. For further information, including information on how to withdraw consent and how to manage the use of cookies on Roblox, please refer to our {startLink}Privacy and Cookie Policy{endLink}."
	/// </summary>
	public override string MessageCookieLawNotice(string startLink, string endLink)
	{
		return $"Roblox использует файлы-cookies для вашего удобства. Для получения более полной информации, включая отзыв согласия на использование cookies и управления ими, пожалуйста ознакомьтесь с {startLink}«Конфиденциальностью и Политикой использования cookies»{endLink}.";
	}

	protected override string _GetTemplateForMessageCookieLawNotice()
	{
		return "Roblox использует файлы-cookies для вашего удобства. Для получения более полной информации, включая отзыв согласия на использование cookies и управления ими, пожалуйста ознакомьтесь с {startLink}«Конфиденциальностью и Политикой использования cookies»{endLink}.";
	}

	/// <summary>
	/// Key: "Message.CookieLawNoticev2"
	/// English String: "Roblox uses cookies to personalize content, provide social media features and analyze the traffic on our site. To learn about how we use cookies and how you can {startLink}manage cookie preferences{endLink}, please refer to our {startLink2}Privacy and Cookie Policy{endLink2}."
	/// </summary>
	public override string MessageCookieLawNoticev2(string startLink, string endLink, string startLink2, string endLink2)
	{
		return $"Roblox использует файлы-cookies для персонализации контента, предоставления возможностей социальных сетей и анализа траффика на нашем сайте. Для получения сведений об использовании файлов-cookies и {startLink}их настройке{endLink}, пожалуйста, ознакомьтесь с нашими {startLink2}Политикой конфиденциальности и использованием файлов-cookies{endLink2}.";
	}

	protected override string _GetTemplateForMessageCookieLawNoticev2()
	{
		return "Roblox использует файлы-cookies для персонализации контента, предоставления возможностей социальных сетей и анализа траффика на нашем сайте. Для получения сведений об использовании файлов-cookies и {startLink}их настройке{endLink}, пожалуйста, ознакомьтесь с нашими {startLink2}Политикой конфиденциальности и использованием файлов-cookies{endLink2}.";
	}

	/// <summary>
	/// Key: "Message.CookieModalText"
	/// English String: "Please choose whether this site may use cookies as described below. You can learn more about how this site uses cookies and related technologies by reading our {startLink}privacy policy{endLink}."
	/// </summary>
	public override string MessageCookieModalText(string startLink, string endLink)
	{
		return $"Пожалуйста, укажите, может ли этот сайт использовать файлы cookies, как указано ниже. Вы можете узнать, как этот сайт использует файлы cookies и связанные с ними технологии, прочитав нашу {startLink}Политику конфиденциальности{endLink}.";
	}

	protected override string _GetTemplateForMessageCookieModalText()
	{
		return "Пожалуйста, укажите, может ли этот сайт использовать файлы cookies, как указано ниже. Вы можете узнать, как этот сайт использует файлы cookies и связанные с ними технологии, прочитав нашу {startLink}Политику конфиденциальности{endLink}.";
	}

	protected override string _GetTemplateForMessageEssentialCookies()
	{
		return "Необходимые файлы cookies";
	}

	protected override string _GetTemplateForMessageEssentialCookiesDescription()
	{
		return "Файлы cookies необходимы для осуществления полноценного функционирования сайта, например, для аутентефикации пользователя, безопасности и сохранения пользовательских данных.";
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
		return "Управление файлами cookies";
	}

	protected override string _GetTemplateForMessageEssentialCookiesItem3()
	{
		return "Gigya";
	}

	protected override string _GetTemplateForResponseAccessDenied()
	{
		return "Доступ закрыт";
	}

	protected override string _GetTemplateForResponseAccessDeniedDescription()
	{
		return "У вас нет разрешения на просмотр этой страницы";
	}

	protected override string _GetTemplateForResponseBadRequest()
	{
		return "Некорректный запрос";
	}

	protected override string _GetTemplateForResponseBadRequestDescription()
	{
		return "С вашим запросом произошла ошибка";
	}

	protected override string _GetTemplateForResponseInternalServerError()
	{
		return "Внутренняя ошибка сервера";
	}

	protected override string _GetTemplateForResponseInternalServerErrorDescription()
	{
		return "Произошла непредвиденная ошибка";
	}

	protected override string _GetTemplateForResponsePageNotFound()
	{
		return "Страница не найдена";
	}

	protected override string _GetTemplateForResponsePageNotFoundDescrition()
	{
		return "Страница не найдена или не существует";
	}

	protected override string _GetTemplateForResponseRequestError()
	{
		return "Ошибка вашего запроса";
	}

	protected override string _GetTemplateForResponseSomethingWentWrong()
	{
		return "Что-то пошло не так";
	}

	protected override string _GetTemplateForResponseTooManyAttemptsText()
	{
		return "Слишком много попыток";
	}

	protected override string _GetTemplateForResponseUnexpectedError()
	{
		return "Произошла неизвестная ошибка. Повторите попытку позже.";
	}
}
