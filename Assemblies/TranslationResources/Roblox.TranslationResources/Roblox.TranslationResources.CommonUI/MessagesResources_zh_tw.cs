namespace Roblox.TranslationResources.CommonUI;

/// <summary>
/// This class overrides MessagesResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class MessagesResources_zh_tw : MessagesResources_en_us, IMessagesResources, ITranslationResources
{
	/// <summary>
	/// Key: "Action.PreviousPage"
	/// button title
	/// English String: "Go to the Previous Page"
	/// </summary>
	public override string ActionPreviousPage => "返回上一頁";

	/// <summary>
	/// Key: "Action.ReturnHome"
	/// button title
	/// English String: "Return Home"
	/// </summary>
	public override string ActionReturnHome => "返回首頁";

	/// <summary>
	/// Key: "Label.Error"
	/// English String: "Error"
	/// </summary>
	public override string LabelError => "錯誤";

	/// <summary>
	/// Key: "Label.ErrorImage"
	/// alternate text shown for error image
	/// English String: "Error Image"
	/// </summary>
	public override string LabelErrorImage => "錯誤圖像";

	/// <summary>
	/// Key: "Label.TooManyCharacters"
	/// English String: "Too many characters!"
	/// </summary>
	public override string LabelTooManyCharacters => "字元過多！";

	/// <summary>
	/// Key: "Message.AlwaysAllowed"
	/// English String: "Always allowed"
	/// </summary>
	public override string MessageAlwaysAllowed => "始終允許";

	/// <summary>
	/// Key: "Message.AnalyiticsCookies"
	/// English String: "Analytics Cookies"
	/// </summary>
	public override string MessageAnalyiticsCookies => "Analytics Cookies";

	/// <summary>
	/// Key: "Message.AnalyiticsCookiesDescription"
	/// English String: "These cookies used for improving site performance or understanding site usage."
	/// </summary>
	public override string MessageAnalyiticsCookiesDescription => "我們使用這些 Cookies 增強網站性能或取得網站使用資訊。";

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
	public override string MessageEssentialCookies => "Essential Cookies";

	/// <summary>
	/// Key: "Message.EssentialCookiesDescription"
	/// English String: "These cookies are required to provide the functionality on the site, such as for user authentication, securing the system or saving cookie preferences."
	/// </summary>
	public override string MessageEssentialCookiesDescription => "我們需要使用這些 Cookies 提供網站上的某些功能，包括使用者驗證、系統維護及保存 Cookie 偏好。";

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
	public override string MessageManageCookies => "管理 Cookies";

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
	public override string ResponseAccessDenied => "存取遭拒";

	/// <summary>
	/// Key: "Response.AccessDeniedDescription"
	/// 403 error message detail
	/// English String: "You don't have permission to view this page"
	/// </summary>
	public override string ResponseAccessDeniedDescription => "您沒有檢視此頁面的權限";

	/// <summary>
	/// Key: "Response.BadRequest"
	/// 400 error message title
	/// English String: "Bad Request"
	/// </summary>
	public override string ResponseBadRequest => "錯誤請求";

	/// <summary>
	/// Key: "Response.BadRequestDescription"
	/// error message detail for 400 error
	/// English String: "There was a problem with your request"
	/// </summary>
	public override string ResponseBadRequestDescription => "請求發生錯誤";

	/// <summary>
	/// Key: "Response.InternalServerError"
	/// 500 error message title
	/// English String: "Internal Server Error"
	/// </summary>
	public override string ResponseInternalServerError => "伺服器內部錯誤";

	/// <summary>
	/// Key: "Response.InternalServerErrorDescription"
	/// 500 error message description
	/// English String: "An unexpected error occurred"
	/// </summary>
	public override string ResponseInternalServerErrorDescription => "發生意外錯誤";

	/// <summary>
	/// Key: "Response.PageNotFound"
	/// 404 error message title
	/// English String: "Page Not found"
	/// </summary>
	public override string ResponsePageNotFound => "找不到頁面";

	/// <summary>
	/// Key: "Response.PageNotFoundDescrition"
	/// 404 error message description
	/// English String: "Page cannot be found or no longer exists"
	/// </summary>
	public override string ResponsePageNotFoundDescrition => "頁面找不到或不存在";

	/// <summary>
	/// Key: "Response.RequestError"
	/// error message for incorrect request
	/// English String: "Error with your request"
	/// </summary>
	public override string ResponseRequestError => "請求發生錯誤";

	/// <summary>
	/// Key: "Response.SomethingWentWrong"
	/// default error message
	/// English String: "Something went wrong"
	/// </summary>
	public override string ResponseSomethingWentWrong => "發生錯誤";

	/// <summary>
	/// Key: "Response.TooManyAttemptsText"
	/// English String: "Too Many Attempts"
	/// </summary>
	public override string ResponseTooManyAttemptsText => "嘗試次數過多";

	/// <summary>
	/// Key: "Response.UnexpectedError"
	/// default error description
	/// English String: "An unexpected error occurred. Please try again later."
	/// </summary>
	public override string ResponseUnexpectedError => "發生意外錯誤，請稍後再試。";

	public MessagesResources_zh_tw(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionPreviousPage()
	{
		return "返回上一頁";
	}

	protected override string _GetTemplateForActionReturnHome()
	{
		return "返回首頁";
	}

	/// <summary>
	/// Key: "CookieLawNoticev2"
	/// Incorrect key, obsoleted
	/// English String: "Roblox uses cookies to personalize content, provide social media features and analyze the traffic on our site. To learn about how we use cookies and how you can {startLink}manage cookie preferences{endLink}, please refer to our {startLink2}Privacy and Cookie Policy{endLink2}."
	/// </summary>
	public override string CookieLawNoticev2(string startLink, string endLink, string startLink2, string endLink2)
	{
		return $"Roblox 使用 Cookies 提供個人化內容、提供社交媒體功能及分析網站流量。若您需要更多資訊和了解如何{startLink}管理 Cookies 偏好{endLink}，請前往我們的{startLink2}隱私權及 Cookies 政策{endLink2}。";
	}

	protected override string _GetTemplateForCookieLawNoticev2()
	{
		return "Roblox 使用 Cookies 提供個人化內容、提供社交媒體功能及分析網站流量。若您需要更多資訊和了解如何{startLink}管理 Cookies 偏好{endLink}，請前往我們的{startLink2}隱私權及 Cookies 政策{endLink2}。";
	}

	/// <summary>
	/// Key: "Description.ContactCustomerService"
	/// message shown on common error pages
	/// English String: "If you continue to receive this page, please contact customer service at {emailLink}"
	/// </summary>
	public override string DescriptionContactCustomerService(string emailLink)
	{
		return $"若此頁面持續顯示，請在 {emailLink} 聯絡客服人員。";
	}

	protected override string _GetTemplateForDescriptionContactCustomerService()
	{
		return "若此頁面持續顯示，請在 {emailLink} 聯絡客服人員。";
	}

	protected override string _GetTemplateForLabelError()
	{
		return "錯誤";
	}

	protected override string _GetTemplateForLabelErrorImage()
	{
		return "錯誤圖像";
	}

	protected override string _GetTemplateForLabelTooManyCharacters()
	{
		return "字元過多！";
	}

	protected override string _GetTemplateForMessageAlwaysAllowed()
	{
		return "始終允許";
	}

	protected override string _GetTemplateForMessageAnalyiticsCookies()
	{
		return "Analytics Cookies";
	}

	protected override string _GetTemplateForMessageAnalyiticsCookiesDescription()
	{
		return "我們使用這些 Cookies 增強網站性能或取得網站使用資訊。";
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
		return $"Roblox 使用 Cookies 給您更好的體驗。若您需要更多資訊，包括如何撤回同意及如何管理 Cookies 的使用方式，請前往我們的{startLink}隱私權及 Cookies 政策{endLink}。";
	}

	protected override string _GetTemplateForMessageCookieLawNotice()
	{
		return "Roblox 使用 Cookies 給您更好的體驗。若您需要更多資訊，包括如何撤回同意及如何管理 Cookies 的使用方式，請前往我們的{startLink}隱私權及 Cookies 政策{endLink}。";
	}

	/// <summary>
	/// Key: "Message.CookieLawNoticev2"
	/// English String: "Roblox uses cookies to personalize content, provide social media features and analyze the traffic on our site. To learn about how we use cookies and how you can {startLink}manage cookie preferences{endLink}, please refer to our {startLink2}Privacy and Cookie Policy{endLink2}."
	/// </summary>
	public override string MessageCookieLawNoticev2(string startLink, string endLink, string startLink2, string endLink2)
	{
		return $"Roblox 使用 Cookies 提供個人化內容、提供社交媒體功能及分析網站流量。若您需要更多資訊和了解如何{startLink}管理 Cookies 偏好{endLink}，請前往我們的{startLink2}隱私權及 Cookies 政策{endLink2}。";
	}

	protected override string _GetTemplateForMessageCookieLawNoticev2()
	{
		return "Roblox 使用 Cookies 提供個人化內容、提供社交媒體功能及分析網站流量。若您需要更多資訊和了解如何{startLink}管理 Cookies 偏好{endLink}，請前往我們的{startLink2}隱私權及 Cookies 政策{endLink2}。";
	}

	/// <summary>
	/// Key: "Message.CookieModalText"
	/// English String: "Please choose whether this site may use cookies as described below. You can learn more about how this site uses cookies and related technologies by reading our {startLink}privacy policy{endLink}."
	/// </summary>
	public override string MessageCookieModalText(string startLink, string endLink)
	{
		return $"請選擇此網站能否以下列方式使用 Cookies。若您想了解此網站使用 Cookies 及相關技術的方式，請前往我們的{startLink}隱私權政策{endLink}。";
	}

	protected override string _GetTemplateForMessageCookieModalText()
	{
		return "請選擇此網站能否以下列方式使用 Cookies。若您想了解此網站使用 Cookies 及相關技術的方式，請前往我們的{startLink}隱私權政策{endLink}。";
	}

	protected override string _GetTemplateForMessageEssentialCookies()
	{
		return "Essential Cookies";
	}

	protected override string _GetTemplateForMessageEssentialCookiesDescription()
	{
		return "我們需要使用這些 Cookies 提供網站上的某些功能，包括使用者驗證、系統維護及保存 Cookie 偏好。";
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
		return "管理 Cookies";
	}

	protected override string _GetTemplateForMessageEssentialCookiesItem3()
	{
		return "Gigya";
	}

	protected override string _GetTemplateForResponseAccessDenied()
	{
		return "存取遭拒";
	}

	protected override string _GetTemplateForResponseAccessDeniedDescription()
	{
		return "您沒有檢視此頁面的權限";
	}

	protected override string _GetTemplateForResponseBadRequest()
	{
		return "錯誤請求";
	}

	protected override string _GetTemplateForResponseBadRequestDescription()
	{
		return "請求發生錯誤";
	}

	protected override string _GetTemplateForResponseInternalServerError()
	{
		return "伺服器內部錯誤";
	}

	protected override string _GetTemplateForResponseInternalServerErrorDescription()
	{
		return "發生意外錯誤";
	}

	protected override string _GetTemplateForResponsePageNotFound()
	{
		return "找不到頁面";
	}

	protected override string _GetTemplateForResponsePageNotFoundDescrition()
	{
		return "頁面找不到或不存在";
	}

	protected override string _GetTemplateForResponseRequestError()
	{
		return "請求發生錯誤";
	}

	protected override string _GetTemplateForResponseSomethingWentWrong()
	{
		return "發生錯誤";
	}

	protected override string _GetTemplateForResponseTooManyAttemptsText()
	{
		return "嘗試次數過多";
	}

	protected override string _GetTemplateForResponseUnexpectedError()
	{
		return "發生意外錯誤，請稍後再試。";
	}
}
