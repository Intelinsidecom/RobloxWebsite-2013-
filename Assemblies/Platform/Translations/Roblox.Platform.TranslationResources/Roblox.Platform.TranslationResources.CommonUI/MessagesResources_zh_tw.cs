namespace Roblox.Platform.TranslationResources.CommonUI {
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
	public override string ActionPreviousPage => "è¿”å›žä¸Šä¸€é ";

	/// <summary>
	/// Key: "Action.ReturnHome"
	/// button title
	/// English String: "Return Home"
	/// </summary>
	public override string ActionReturnHome => "è¿”å›žé¦–é ";

	/// <summary>
	/// Key: "Label.Error"
	/// English String: "Error"
	/// </summary>
	public override string LabelError => "éŒ¯èª¤";

	/// <summary>
	/// Key: "Label.ErrorImage"
	/// alternate text shown for error image
	/// English String: "Error Image"
	/// </summary>
	public override string LabelErrorImage => "éŒ¯èª¤åœ–åƒ";

	/// <summary>
	/// Key: "Label.TooManyCharacters"
	/// English String: "Too many characters!"
	/// </summary>
	public override string LabelTooManyCharacters => "å­—å…ƒéŽå¤šï¼";

	/// <summary>
	/// Key: "Message.AlwaysAllowed"
	/// English String: "Always allowed"
	/// </summary>
	public override string MessageAlwaysAllowed => "å§‹çµ‚å…è¨±";

	/// <summary>
	/// Key: "Message.AnalyiticsCookies"
	/// English String: "Analytics Cookies"
	/// </summary>
	public override string MessageAnalyiticsCookies => "Analytics Cookies";

	/// <summary>
	/// Key: "Message.AnalyiticsCookiesDescription"
	/// English String: "These cookies used for improving site performance or understanding site usage."
	/// </summary>
	public override string MessageAnalyiticsCookiesDescription => "æˆ‘å€‘ä½¿ç”¨é€™äº› Cookies å¢žå¼·ç¶²ç«™æ€§èƒ½æˆ–å–å¾—ç¶²ç«™ä½¿ç”¨è³‡è¨Šã€‚";

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
	public override string MessageEssentialCookiesDescription => "æˆ‘å€‘éœ€è¦ä½¿ç”¨é€™äº› Cookies æä¾›ç¶²ç«™ä¸Šçš„æŸäº›åŠŸèƒ½ï¼ŒåŒ…æ‹¬ä½¿ç”¨è€…é©—è­‰ã€ç³»çµ±ç¶­è­·åŠä¿å­˜ Cookie åå¥½ã€‚";

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
	public override string MessageManageCookies => "ç®¡ç† Cookies";

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
	public override string ResponseAccessDenied => "å­˜å–é­æ‹’";

	/// <summary>
	/// Key: "Response.AccessDeniedDescription"
	/// 403 error message detail
	/// English String: "You don't have permission to view this page"
	/// </summary>
	public override string ResponseAccessDeniedDescription => "æ‚¨æ²’æœ‰æª¢è¦–æ­¤é é¢çš„æ¬Šé™";

	/// <summary>
	/// Key: "Response.BadRequest"
	/// 400 error message title
	/// English String: "Bad Request"
	/// </summary>
	public override string ResponseBadRequest => "éŒ¯èª¤è«‹æ±‚";

	/// <summary>
	/// Key: "Response.BadRequestDescription"
	/// error message detail for 400 error
	/// English String: "There was a problem with your request"
	/// </summary>
	public override string ResponseBadRequestDescription => "è«‹æ±‚ç™¼ç”ŸéŒ¯èª¤";

	/// <summary>
	/// Key: "Response.InternalServerError"
	/// 500 error message title
	/// English String: "Internal Server Error"
	/// </summary>
	public override string ResponseInternalServerError => "ä¼ºæœå™¨å…§éƒ¨éŒ¯èª¤";

	/// <summary>
	/// Key: "Response.InternalServerErrorDescription"
	/// 500 error message description
	/// English String: "An unexpected error occurred"
	/// </summary>
	public override string ResponseInternalServerErrorDescription => "ç™¼ç”Ÿæ„å¤–éŒ¯èª¤";

	/// <summary>
	/// Key: "Response.PageNotFound"
	/// 404 error message title
	/// English String: "Page Not found"
	/// </summary>
	public override string ResponsePageNotFound => "æ‰¾ä¸åˆ°é é¢";

	/// <summary>
	/// Key: "Response.PageNotFoundDescrition"
	/// 404 error message description
	/// English String: "Page cannot be found or no longer exists"
	/// </summary>
	public override string ResponsePageNotFoundDescrition => "é é¢æ‰¾ä¸åˆ°æˆ–ä¸å­˜åœ¨";

	/// <summary>
	/// Key: "Response.RequestError"
	/// error message for incorrect request
	/// English String: "Error with your request"
	/// </summary>
	public override string ResponseRequestError => "è«‹æ±‚ç™¼ç”ŸéŒ¯èª¤";

	/// <summary>
	/// Key: "Response.SomethingWentWrong"
	/// default error message
	/// English String: "Something went wrong"
	/// </summary>
	public override string ResponseSomethingWentWrong => "ç™¼ç”ŸéŒ¯èª¤";

	/// <summary>
	/// Key: "Response.TooManyAttemptsText"
	/// English String: "Too Many Attempts"
	/// </summary>
	public override string ResponseTooManyAttemptsText => "å˜—è©¦æ¬¡æ•¸éŽå¤š";

	/// <summary>
	/// Key: "Response.UnexpectedError"
	/// default error description
	/// English String: "An unexpected error occurred. Please try again later."
	/// </summary>
	public override string ResponseUnexpectedError => "ç™¼ç”Ÿæ„å¤–éŒ¯èª¤ï¼Œè«‹ç¨å¾Œå†è©¦ã€‚";

	public MessagesResources_zh_tw(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionPreviousPage()
	{
		return "è¿”å›žä¸Šä¸€é ";
	}

	protected override string _GetTemplateForActionReturnHome()
	{
		return "è¿”å›žé¦–é ";
	}

	/// <summary>
	/// Key: "CookieLawNoticev2"
	/// Incorrect key, obsoleted
	/// English String: "Roblox uses cookies to personalize content, provide social media features and analyze the traffic on our site. To learn about how we use cookies and how you can {startLink}manage cookie preferences{endLink}, please refer to our {startLink2}Privacy and Cookie Policy{endLink2}."
	/// </summary>
	public override string CookieLawNoticev2(string startLink, string endLink, string startLink2, string endLink2)
	{
		return $"Roblox ä½¿ç”¨ Cookies æä¾›å€‹äººåŒ–å…§å®¹ã€æä¾›ç¤¾äº¤åª’é«”åŠŸèƒ½åŠåˆ†æžç¶²ç«™æµé‡ã€‚è‹¥æ‚¨éœ€è¦æ›´å¤šè³‡è¨Šå’Œäº†è§£å¦‚ä½•{startLink}ç®¡ç† Cookies åå¥½{endLink}ï¼Œè«‹å‰å¾€æˆ‘å€‘çš„{startLink2}éš±ç§æ¬ŠåŠ Cookies æ”¿ç­–{endLink2}ã€‚";
	}

	protected override string _GetTemplateForCookieLawNoticev2()
	{
		return "Roblox ä½¿ç”¨ Cookies æä¾›å€‹äººåŒ–å…§å®¹ã€æä¾›ç¤¾äº¤åª’é«”åŠŸèƒ½åŠåˆ†æžç¶²ç«™æµé‡ã€‚è‹¥æ‚¨éœ€è¦æ›´å¤šè³‡è¨Šå’Œäº†è§£å¦‚ä½•{startLink}ç®¡ç† Cookies åå¥½{endLink}ï¼Œè«‹å‰å¾€æˆ‘å€‘çš„{startLink2}éš±ç§æ¬ŠåŠ Cookies æ”¿ç­–{endLink2}ã€‚";
	}

	/// <summary>
	/// Key: "Description.ContactCustomerService"
	/// message shown on common error pages
	/// English String: "If you continue to receive this page, please contact customer service at {emailLink}"
	/// </summary>
	public override string DescriptionContactCustomerService(string emailLink)
	{
		return $"è‹¥æ­¤é é¢æŒçºŒé¡¯ç¤ºï¼Œè«‹åœ¨ {emailLink} è¯çµ¡å®¢æœäººå“¡ã€‚";
	}

	protected override string _GetTemplateForDescriptionContactCustomerService()
	{
		return "è‹¥æ­¤é é¢æŒçºŒé¡¯ç¤ºï¼Œè«‹åœ¨ {emailLink} è¯çµ¡å®¢æœäººå“¡ã€‚";
	}

	protected override string _GetTemplateForLabelError()
	{
		return "éŒ¯èª¤";
	}

	protected override string _GetTemplateForLabelErrorImage()
	{
		return "éŒ¯èª¤åœ–åƒ";
	}

	protected override string _GetTemplateForLabelTooManyCharacters()
	{
		return "å­—å…ƒéŽå¤šï¼";
	}

	protected override string _GetTemplateForMessageAlwaysAllowed()
	{
		return "å§‹çµ‚å…è¨±";
	}

	protected override string _GetTemplateForMessageAnalyiticsCookies()
	{
		return "Analytics Cookies";
	}

	protected override string _GetTemplateForMessageAnalyiticsCookiesDescription()
	{
		return "æˆ‘å€‘ä½¿ç”¨é€™äº› Cookies å¢žå¼·ç¶²ç«™æ€§èƒ½æˆ–å–å¾—ç¶²ç«™ä½¿ç”¨è³‡è¨Šã€‚";
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
		return $"Roblox ä½¿ç”¨ Cookies çµ¦æ‚¨æ›´å¥½çš„é«”é©—ã€‚è‹¥æ‚¨éœ€è¦æ›´å¤šè³‡è¨Šï¼ŒåŒ…æ‹¬å¦‚ä½•æ’¤å›žåŒæ„åŠå¦‚ä½•ç®¡ç† Cookies çš„ä½¿ç”¨æ–¹å¼ï¼Œè«‹å‰å¾€æˆ‘å€‘çš„{startLink}éš±ç§æ¬ŠåŠ Cookies æ”¿ç­–{endLink}ã€‚";
	}

	protected override string _GetTemplateForMessageCookieLawNotice()
	{
		return "Roblox ä½¿ç”¨ Cookies çµ¦æ‚¨æ›´å¥½çš„é«”é©—ã€‚è‹¥æ‚¨éœ€è¦æ›´å¤šè³‡è¨Šï¼ŒåŒ…æ‹¬å¦‚ä½•æ’¤å›žåŒæ„åŠå¦‚ä½•ç®¡ç† Cookies çš„ä½¿ç”¨æ–¹å¼ï¼Œè«‹å‰å¾€æˆ‘å€‘çš„{startLink}éš±ç§æ¬ŠåŠ Cookies æ”¿ç­–{endLink}ã€‚";
	}

	/// <summary>
	/// Key: "Message.CookieLawNoticev2"
	/// English String: "Roblox uses cookies to personalize content, provide social media features and analyze the traffic on our site. To learn about how we use cookies and how you can {startLink}manage cookie preferences{endLink}, please refer to our {startLink2}Privacy and Cookie Policy{endLink2}."
	/// </summary>
	public override string MessageCookieLawNoticev2(string startLink, string endLink, string startLink2, string endLink2)
	{
		return $"Roblox ä½¿ç”¨ Cookies æä¾›å€‹äººåŒ–å…§å®¹ã€æä¾›ç¤¾äº¤åª’é«”åŠŸèƒ½åŠåˆ†æžç¶²ç«™æµé‡ã€‚è‹¥æ‚¨éœ€è¦æ›´å¤šè³‡è¨Šå’Œäº†è§£å¦‚ä½•{startLink}ç®¡ç† Cookies åå¥½{endLink}ï¼Œè«‹å‰å¾€æˆ‘å€‘çš„{startLink2}éš±ç§æ¬ŠåŠ Cookies æ”¿ç­–{endLink2}ã€‚";
	}

	protected override string _GetTemplateForMessageCookieLawNoticev2()
	{
		return "Roblox ä½¿ç”¨ Cookies æä¾›å€‹äººåŒ–å…§å®¹ã€æä¾›ç¤¾äº¤åª’é«”åŠŸèƒ½åŠåˆ†æžç¶²ç«™æµé‡ã€‚è‹¥æ‚¨éœ€è¦æ›´å¤šè³‡è¨Šå’Œäº†è§£å¦‚ä½•{startLink}ç®¡ç† Cookies åå¥½{endLink}ï¼Œè«‹å‰å¾€æˆ‘å€‘çš„{startLink2}éš±ç§æ¬ŠåŠ Cookies æ”¿ç­–{endLink2}ã€‚";
	}

	/// <summary>
	/// Key: "Message.CookieModalText"
	/// English String: "Please choose whether this site may use cookies as described below. You can learn more about how this site uses cookies and related technologies by reading our {startLink}privacy policy{endLink}."
	/// </summary>
	public override string MessageCookieModalText(string startLink, string endLink)
	{
		return $"è«‹é¸æ“‡æ­¤ç¶²ç«™èƒ½å¦ä»¥ä¸‹åˆ—æ–¹å¼ä½¿ç”¨ Cookiesã€‚è‹¥æ‚¨æƒ³äº†è§£æ­¤ç¶²ç«™ä½¿ç”¨ Cookies åŠç›¸é—œæŠ€è¡“çš„æ–¹å¼ï¼Œè«‹å‰å¾€æˆ‘å€‘çš„{startLink}éš±ç§æ¬Šæ”¿ç­–{endLink}ã€‚";
	}

	protected override string _GetTemplateForMessageCookieModalText()
	{
		return "è«‹é¸æ“‡æ­¤ç¶²ç«™èƒ½å¦ä»¥ä¸‹åˆ—æ–¹å¼ä½¿ç”¨ Cookiesã€‚è‹¥æ‚¨æƒ³äº†è§£æ­¤ç¶²ç«™ä½¿ç”¨ Cookies åŠç›¸é—œæŠ€è¡“çš„æ–¹å¼ï¼Œè«‹å‰å¾€æˆ‘å€‘çš„{startLink}éš±ç§æ¬Šæ”¿ç­–{endLink}ã€‚";
	}

	protected override string _GetTemplateForMessageEssentialCookies()
	{
		return "Essential Cookies";
	}

	protected override string _GetTemplateForMessageEssentialCookiesDescription()
	{
		return "æˆ‘å€‘éœ€è¦ä½¿ç”¨é€™äº› Cookies æä¾›ç¶²ç«™ä¸Šçš„æŸäº›åŠŸèƒ½ï¼ŒåŒ…æ‹¬ä½¿ç”¨è€…é©—è­‰ã€ç³»çµ±ç¶­è­·åŠä¿å­˜ Cookie åå¥½ã€‚";
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
		return "ç®¡ç† Cookies";
	}

	protected override string _GetTemplateForMessageEssentialCookiesItem3()
	{
		return "Gigya";
	}

	protected override string _GetTemplateForResponseAccessDenied()
	{
		return "å­˜å–é­æ‹’";
	}

	protected override string _GetTemplateForResponseAccessDeniedDescription()
	{
		return "æ‚¨æ²’æœ‰æª¢è¦–æ­¤é é¢çš„æ¬Šé™";
	}

	protected override string _GetTemplateForResponseBadRequest()
	{
		return "éŒ¯èª¤è«‹æ±‚";
	}

	protected override string _GetTemplateForResponseBadRequestDescription()
	{
		return "è«‹æ±‚ç™¼ç”ŸéŒ¯èª¤";
	}

	protected override string _GetTemplateForResponseInternalServerError()
	{
		return "ä¼ºæœå™¨å…§éƒ¨éŒ¯èª¤";
	}

	protected override string _GetTemplateForResponseInternalServerErrorDescription()
	{
		return "ç™¼ç”Ÿæ„å¤–éŒ¯èª¤";
	}

	protected override string _GetTemplateForResponsePageNotFound()
	{
		return "æ‰¾ä¸åˆ°é é¢";
	}

	protected override string _GetTemplateForResponsePageNotFoundDescrition()
	{
		return "é é¢æ‰¾ä¸åˆ°æˆ–ä¸å­˜åœ¨";
	}

	protected override string _GetTemplateForResponseRequestError()
	{
		return "è«‹æ±‚ç™¼ç”ŸéŒ¯èª¤";
	}

	protected override string _GetTemplateForResponseSomethingWentWrong()
	{
		return "ç™¼ç”ŸéŒ¯èª¤";
	}

	protected override string _GetTemplateForResponseTooManyAttemptsText()
	{
		return "å˜—è©¦æ¬¡æ•¸éŽå¤š";
	}

	protected override string _GetTemplateForResponseUnexpectedError()
	{
		return "ç™¼ç”Ÿæ„å¤–éŒ¯èª¤ï¼Œè«‹ç¨å¾Œå†è©¦ã€‚";
	}
}


}
