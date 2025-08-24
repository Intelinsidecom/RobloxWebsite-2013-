namespace Roblox.TranslationResources.CommonUI;

/// <summary>
/// This class overrides MessagesResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class MessagesResources_zh_cn : MessagesResources_en_us, IMessagesResources, ITranslationResources
{
	/// <summary>
	/// Key: "Action.PreviousPage"
	/// button title
	/// English String: "Go to the Previous Page"
	/// </summary>
	public override string ActionPreviousPage => "返回上一页";

	/// <summary>
	/// Key: "Action.ReturnHome"
	/// button title
	/// English String: "Return Home"
	/// </summary>
	public override string ActionReturnHome => "返回首页";

	/// <summary>
	/// Key: "Label.Error"
	/// English String: "Error"
	/// </summary>
	public override string LabelError => "错误";

	/// <summary>
	/// Key: "Label.ErrorImage"
	/// alternate text shown for error image
	/// English String: "Error Image"
	/// </summary>
	public override string LabelErrorImage => "图像错误";

	/// <summary>
	/// Key: "Label.TooManyCharacters"
	/// English String: "Too many characters!"
	/// </summary>
	public override string LabelTooManyCharacters => "字符过多！";

	/// <summary>
	/// Key: "Message.AlwaysAllowed"
	/// English String: "Always allowed"
	/// </summary>
	public override string MessageAlwaysAllowed => "始终允许";

	/// <summary>
	/// Key: "Message.AnalyiticsCookies"
	/// English String: "Analytics Cookies"
	/// </summary>
	public override string MessageAnalyiticsCookies => "分析 Cookies";

	/// <summary>
	/// Key: "Message.AnalyiticsCookiesDescription"
	/// English String: "These cookies used for improving site performance or understanding site usage."
	/// </summary>
	public override string MessageAnalyiticsCookiesDescription => "这些 cookie 用于提高网站性能或了解网站使用情况。";

	/// <summary>
	/// Key: "Message.AnalyiticsCookiesItem1"
	/// English String: "Google Analytics"
	/// </summary>
	public override string MessageAnalyiticsCookiesItem1 => "Google Analytics（分析）";

	/// <summary>
	/// Key: "Message.AnalyiticsCookiesItem2"
	/// English String: "Google Universal Analytics"
	/// </summary>
	public override string MessageAnalyiticsCookiesItem2 => "Google Universal Analytics";

	/// <summary>
	/// Key: "Message.EssentialCookies"
	/// English String: "Essential Cookies"
	/// </summary>
	public override string MessageEssentialCookies => "基本 Cookies";

	/// <summary>
	/// Key: "Message.EssentialCookiesDescription"
	/// English String: "These cookies are required to provide the functionality on the site, such as for user authentication, securing the system or saving cookie preferences."
	/// </summary>
	public override string MessageEssentialCookiesDescription => "这些是提供网站上功能所必需的 cookies，例如用于用户身份验证、保护系统安全或保存 cookie 首选项。";

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
	public override string ResponseAccessDenied => "访问被拒绝";

	/// <summary>
	/// Key: "Response.AccessDeniedDescription"
	/// 403 error message detail
	/// English String: "You don't have permission to view this page"
	/// </summary>
	public override string ResponseAccessDeniedDescription => "你没有查看此页面的权限。";

	/// <summary>
	/// Key: "Response.BadRequest"
	/// 400 error message title
	/// English String: "Bad Request"
	/// </summary>
	public override string ResponseBadRequest => "错误请求";

	/// <summary>
	/// Key: "Response.BadRequestDescription"
	/// error message detail for 400 error
	/// English String: "There was a problem with your request"
	/// </summary>
	public override string ResponseBadRequestDescription => "你的请求遇到些问题";

	/// <summary>
	/// Key: "Response.InternalServerError"
	/// 500 error message title
	/// English String: "Internal Server Error"
	/// </summary>
	public override string ResponseInternalServerError => "内部服务器错误";

	/// <summary>
	/// Key: "Response.InternalServerErrorDescription"
	/// 500 error message description
	/// English String: "An unexpected error occurred"
	/// </summary>
	public override string ResponseInternalServerErrorDescription => "发生意外错误";

	/// <summary>
	/// Key: "Response.PageNotFound"
	/// 404 error message title
	/// English String: "Page Not found"
	/// </summary>
	public override string ResponsePageNotFound => "找不到页面";

	/// <summary>
	/// Key: "Response.PageNotFoundDescrition"
	/// 404 error message description
	/// English String: "Page cannot be found or no longer exists"
	/// </summary>
	public override string ResponsePageNotFoundDescrition => "页面找不到或已不存在";

	/// <summary>
	/// Key: "Response.RequestError"
	/// error message for incorrect request
	/// English String: "Error with your request"
	/// </summary>
	public override string ResponseRequestError => "你的请求错误";

	/// <summary>
	/// Key: "Response.SomethingWentWrong"
	/// default error message
	/// English String: "Something went wrong"
	/// </summary>
	public override string ResponseSomethingWentWrong => "有地方出错了";

	/// <summary>
	/// Key: "Response.TooManyAttemptsText"
	/// English String: "Too Many Attempts"
	/// </summary>
	public override string ResponseTooManyAttemptsText => "尝试次数过多";

	/// <summary>
	/// Key: "Response.UnexpectedError"
	/// default error description
	/// English String: "An unexpected error occurred. Please try again later."
	/// </summary>
	public override string ResponseUnexpectedError => "发生意外错误。请稍后重试。";

	public MessagesResources_zh_cn(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionPreviousPage()
	{
		return "返回上一页";
	}

	protected override string _GetTemplateForActionReturnHome()
	{
		return "返回首页";
	}

	/// <summary>
	/// Key: "CookieLawNoticev2"
	/// Incorrect key, obsoleted
	/// English String: "Roblox uses cookies to personalize content, provide social media features and analyze the traffic on our site. To learn about how we use cookies and how you can {startLink}manage cookie preferences{endLink}, please refer to our {startLink2}Privacy and Cookie Policy{endLink2}."
	/// </summary>
	public override string CookieLawNoticev2(string startLink, string endLink, string startLink2, string endLink2)
	{
		return $"Roblox 使用 cookies 来个性化内容，提供社交媒体功能，并分析我们网站上的流量。若要了解我们如何使用 cookies 以及如何{startLink}管理 cookie 偏好设置{endLink}，请参阅我们的{startLink2}隐私与 cookie 政策{endLink2}。";
	}

	protected override string _GetTemplateForCookieLawNoticev2()
	{
		return "Roblox 使用 cookies 来个性化内容，提供社交媒体功能，并分析我们网站上的流量。若要了解我们如何使用 cookies 以及如何{startLink}管理 cookie 偏好设置{endLink}，请参阅我们的{startLink2}隐私与 cookie 政策{endLink2}。";
	}

	/// <summary>
	/// Key: "Description.ContactCustomerService"
	/// message shown on common error pages
	/// English String: "If you continue to receive this page, please contact customer service at {emailLink}"
	/// </summary>
	public override string DescriptionContactCustomerService(string emailLink)
	{
		return $"如果你继续收到此页面，请通过 {emailLink} 联系客户服务。";
	}

	protected override string _GetTemplateForDescriptionContactCustomerService()
	{
		return "如果你继续收到此页面，请通过 {emailLink} 联系客户服务。";
	}

	protected override string _GetTemplateForLabelError()
	{
		return "错误";
	}

	protected override string _GetTemplateForLabelErrorImage()
	{
		return "图像错误";
	}

	protected override string _GetTemplateForLabelTooManyCharacters()
	{
		return "字符过多！";
	}

	protected override string _GetTemplateForMessageAlwaysAllowed()
	{
		return "始终允许";
	}

	protected override string _GetTemplateForMessageAnalyiticsCookies()
	{
		return "分析 Cookies";
	}

	protected override string _GetTemplateForMessageAnalyiticsCookiesDescription()
	{
		return "这些 cookie 用于提高网站性能或了解网站使用情况。";
	}

	protected override string _GetTemplateForMessageAnalyiticsCookiesItem1()
	{
		return "Google Analytics（分析）";
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
		return $"Roblox 使用 cookie 以为你提供更好的体验。若要了解进一步信息，包括如何撤回同意以及如何管理 Roblox 中 cookie的使用等相关信息，请参阅我们的{startLink}隐私与 Cookie 政策{endLink}。";
	}

	protected override string _GetTemplateForMessageCookieLawNotice()
	{
		return "Roblox 使用 cookie 以为你提供更好的体验。若要了解进一步信息，包括如何撤回同意以及如何管理 Roblox 中 cookie的使用等相关信息，请参阅我们的{startLink}隐私与 Cookie 政策{endLink}。";
	}

	/// <summary>
	/// Key: "Message.CookieLawNoticev2"
	/// English String: "Roblox uses cookies to personalize content, provide social media features and analyze the traffic on our site. To learn about how we use cookies and how you can {startLink}manage cookie preferences{endLink}, please refer to our {startLink2}Privacy and Cookie Policy{endLink2}."
	/// </summary>
	public override string MessageCookieLawNoticev2(string startLink, string endLink, string startLink2, string endLink2)
	{
		return $"Roblox 使用 cookies 来个性化内容，提供社交媒体功能，并分析我们网站上的流量。若要了解我们如何使用 cookies 以及如何{startLink}管理 cookie 偏好设置{endLink}，请参阅我们的{startLink2}隐私与 cookie 政策{endLink2}。";
	}

	protected override string _GetTemplateForMessageCookieLawNoticev2()
	{
		return "Roblox 使用 cookies 来个性化内容，提供社交媒体功能，并分析我们网站上的流量。若要了解我们如何使用 cookies 以及如何{startLink}管理 cookie 偏好设置{endLink}，请参阅我们的{startLink2}隐私与 cookie 政策{endLink2}。";
	}

	/// <summary>
	/// Key: "Message.CookieModalText"
	/// English String: "Please choose whether this site may use cookies as described below. You can learn more about how this site uses cookies and related technologies by reading our {startLink}privacy policy{endLink}."
	/// </summary>
	public override string MessageCookieModalText(string startLink, string endLink)
	{
		return $"请选择此网站是否可以使用下列 cookie。你可以通过阅读我们的{startLink}隐私政策{endLink}，了解更多关于本网站如何使用 cookie 和相关技术的信息。";
	}

	protected override string _GetTemplateForMessageCookieModalText()
	{
		return "请选择此网站是否可以使用下列 cookie。你可以通过阅读我们的{startLink}隐私政策{endLink}，了解更多关于本网站如何使用 cookie 和相关技术的信息。";
	}

	protected override string _GetTemplateForMessageEssentialCookies()
	{
		return "基本 Cookies";
	}

	protected override string _GetTemplateForMessageEssentialCookiesDescription()
	{
		return "这些是提供网站上功能所必需的 cookies，例如用于用户身份验证、保护系统安全或保存 cookie 首选项。";
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
		return "访问被拒绝";
	}

	protected override string _GetTemplateForResponseAccessDeniedDescription()
	{
		return "你没有查看此页面的权限。";
	}

	protected override string _GetTemplateForResponseBadRequest()
	{
		return "错误请求";
	}

	protected override string _GetTemplateForResponseBadRequestDescription()
	{
		return "你的请求遇到些问题";
	}

	protected override string _GetTemplateForResponseInternalServerError()
	{
		return "内部服务器错误";
	}

	protected override string _GetTemplateForResponseInternalServerErrorDescription()
	{
		return "发生意外错误";
	}

	protected override string _GetTemplateForResponsePageNotFound()
	{
		return "找不到页面";
	}

	protected override string _GetTemplateForResponsePageNotFoundDescrition()
	{
		return "页面找不到或已不存在";
	}

	protected override string _GetTemplateForResponseRequestError()
	{
		return "你的请求错误";
	}

	protected override string _GetTemplateForResponseSomethingWentWrong()
	{
		return "有地方出错了";
	}

	protected override string _GetTemplateForResponseTooManyAttemptsText()
	{
		return "尝试次数过多";
	}

	protected override string _GetTemplateForResponseUnexpectedError()
	{
		return "发生意外错误。请稍后重试。";
	}
}
