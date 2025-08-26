namespace Roblox.Platform.TranslationResources.CommonUI {
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
	public override string ActionPreviousPage => "è¿”å›žä¸Šä¸€é¡µ";

	/// <summary>
	/// Key: "Action.ReturnHome"
	/// button title
	/// English String: "Return Home"
	/// </summary>
	public override string ActionReturnHome => "è¿”å›žé¦–é¡µ";

	/// <summary>
	/// Key: "Label.Error"
	/// English String: "Error"
	/// </summary>
	public override string LabelError => "é”™è¯¯";

	/// <summary>
	/// Key: "Label.ErrorImage"
	/// alternate text shown for error image
	/// English String: "Error Image"
	/// </summary>
	public override string LabelErrorImage => "å›¾åƒé”™è¯¯";

	/// <summary>
	/// Key: "Label.TooManyCharacters"
	/// English String: "Too many characters!"
	/// </summary>
	public override string LabelTooManyCharacters => "å­—ç¬¦è¿‡å¤šï¼";

	/// <summary>
	/// Key: "Message.AlwaysAllowed"
	/// English String: "Always allowed"
	/// </summary>
	public override string MessageAlwaysAllowed => "å§‹ç»ˆå…è®¸";

	/// <summary>
	/// Key: "Message.AnalyiticsCookies"
	/// English String: "Analytics Cookies"
	/// </summary>
	public override string MessageAnalyiticsCookies => "åˆ†æž Cookies";

	/// <summary>
	/// Key: "Message.AnalyiticsCookiesDescription"
	/// English String: "These cookies used for improving site performance or understanding site usage."
	/// </summary>
	public override string MessageAnalyiticsCookiesDescription => "è¿™äº› cookie ç”¨äºŽæé«˜ç½‘ç«™æ€§èƒ½æˆ–äº†è§£ç½‘ç«™ä½¿ç”¨æƒ…å†µã€‚";

	/// <summary>
	/// Key: "Message.AnalyiticsCookiesItem1"
	/// English String: "Google Analytics"
	/// </summary>
	public override string MessageAnalyiticsCookiesItem1 => "Google Analyticsï¼ˆåˆ†æžï¼‰";

	/// <summary>
	/// Key: "Message.AnalyiticsCookiesItem2"
	/// English String: "Google Universal Analytics"
	/// </summary>
	public override string MessageAnalyiticsCookiesItem2 => "Google Universal Analytics";

	/// <summary>
	/// Key: "Message.EssentialCookies"
	/// English String: "Essential Cookies"
	/// </summary>
	public override string MessageEssentialCookies => "åŸºæœ¬ Cookies";

	/// <summary>
	/// Key: "Message.EssentialCookiesDescription"
	/// English String: "These cookies are required to provide the functionality on the site, such as for user authentication, securing the system or saving cookie preferences."
	/// </summary>
	public override string MessageEssentialCookiesDescription => "è¿™äº›æ˜¯æä¾›ç½‘ç«™ä¸ŠåŠŸèƒ½æ‰€å¿…éœ€çš„ cookiesï¼Œä¾‹å¦‚ç”¨äºŽç”¨æˆ·èº«ä»½éªŒè¯ã€ä¿æŠ¤ç³»ç»Ÿå®‰å…¨æˆ–ä¿å­˜ cookie é¦–é€‰é¡¹ã€‚";

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
	public override string ResponseAccessDenied => "è®¿é—®è¢«æ‹’ç»";

	/// <summary>
	/// Key: "Response.AccessDeniedDescription"
	/// 403 error message detail
	/// English String: "You don't have permission to view this page"
	/// </summary>
	public override string ResponseAccessDeniedDescription => "ä½ æ²¡æœ‰æŸ¥çœ‹æ­¤é¡µé¢çš„æƒé™ã€‚";

	/// <summary>
	/// Key: "Response.BadRequest"
	/// 400 error message title
	/// English String: "Bad Request"
	/// </summary>
	public override string ResponseBadRequest => "é”™è¯¯è¯·æ±‚";

	/// <summary>
	/// Key: "Response.BadRequestDescription"
	/// error message detail for 400 error
	/// English String: "There was a problem with your request"
	/// </summary>
	public override string ResponseBadRequestDescription => "ä½ çš„è¯·æ±‚é‡åˆ°äº›é—®é¢˜";

	/// <summary>
	/// Key: "Response.InternalServerError"
	/// 500 error message title
	/// English String: "Internal Server Error"
	/// </summary>
	public override string ResponseInternalServerError => "å†…éƒ¨æœåŠ¡å™¨é”™è¯¯";

	/// <summary>
	/// Key: "Response.InternalServerErrorDescription"
	/// 500 error message description
	/// English String: "An unexpected error occurred"
	/// </summary>
	public override string ResponseInternalServerErrorDescription => "å‘ç”Ÿæ„å¤–é”™è¯¯";

	/// <summary>
	/// Key: "Response.PageNotFound"
	/// 404 error message title
	/// English String: "Page Not found"
	/// </summary>
	public override string ResponsePageNotFound => "æ‰¾ä¸åˆ°é¡µé¢";

	/// <summary>
	/// Key: "Response.PageNotFoundDescrition"
	/// 404 error message description
	/// English String: "Page cannot be found or no longer exists"
	/// </summary>
	public override string ResponsePageNotFoundDescrition => "é¡µé¢æ‰¾ä¸åˆ°æˆ–å·²ä¸å­˜åœ¨";

	/// <summary>
	/// Key: "Response.RequestError"
	/// error message for incorrect request
	/// English String: "Error with your request"
	/// </summary>
	public override string ResponseRequestError => "ä½ çš„è¯·æ±‚é”™è¯¯";

	/// <summary>
	/// Key: "Response.SomethingWentWrong"
	/// default error message
	/// English String: "Something went wrong"
	/// </summary>
	public override string ResponseSomethingWentWrong => "æœ‰åœ°æ–¹å‡ºé”™äº†";

	/// <summary>
	/// Key: "Response.TooManyAttemptsText"
	/// English String: "Too Many Attempts"
	/// </summary>
	public override string ResponseTooManyAttemptsText => "å°è¯•æ¬¡æ•°è¿‡å¤š";

	/// <summary>
	/// Key: "Response.UnexpectedError"
	/// default error description
	/// English String: "An unexpected error occurred. Please try again later."
	/// </summary>
	public override string ResponseUnexpectedError => "å‘ç”Ÿæ„å¤–é”™è¯¯ã€‚è¯·ç¨åŽé‡è¯•ã€‚";

	public MessagesResources_zh_cn(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionPreviousPage()
	{
		return "è¿”å›žä¸Šä¸€é¡µ";
	}

	protected override string _GetTemplateForActionReturnHome()
	{
		return "è¿”å›žé¦–é¡µ";
	}

	/// <summary>
	/// Key: "CookieLawNoticev2"
	/// Incorrect key, obsoleted
	/// English String: "Roblox uses cookies to personalize content, provide social media features and analyze the traffic on our site. To learn about how we use cookies and how you can {startLink}manage cookie preferences{endLink}, please refer to our {startLink2}Privacy and Cookie Policy{endLink2}."
	/// </summary>
	public override string CookieLawNoticev2(string startLink, string endLink, string startLink2, string endLink2)
	{
		return $"Roblox ä½¿ç”¨ cookies æ¥ä¸ªæ€§åŒ–å†…å®¹ï¼Œæä¾›ç¤¾äº¤åª’ä½“åŠŸèƒ½ï¼Œå¹¶åˆ†æžæˆ‘ä»¬ç½‘ç«™ä¸Šçš„æµé‡ã€‚è‹¥è¦äº†è§£æˆ‘ä»¬å¦‚ä½•ä½¿ç”¨ cookies ä»¥åŠå¦‚ä½•{startLink}ç®¡ç† cookie åå¥½è®¾ç½®{endLink}ï¼Œè¯·å‚é˜…æˆ‘ä»¬çš„{startLink2}éšç§ä¸Ž cookie æ”¿ç­–{endLink2}ã€‚";
	}

	protected override string _GetTemplateForCookieLawNoticev2()
	{
		return "Roblox ä½¿ç”¨ cookies æ¥ä¸ªæ€§åŒ–å†…å®¹ï¼Œæä¾›ç¤¾äº¤åª’ä½“åŠŸèƒ½ï¼Œå¹¶åˆ†æžæˆ‘ä»¬ç½‘ç«™ä¸Šçš„æµé‡ã€‚è‹¥è¦äº†è§£æˆ‘ä»¬å¦‚ä½•ä½¿ç”¨ cookies ä»¥åŠå¦‚ä½•{startLink}ç®¡ç† cookie åå¥½è®¾ç½®{endLink}ï¼Œè¯·å‚é˜…æˆ‘ä»¬çš„{startLink2}éšç§ä¸Ž cookie æ”¿ç­–{endLink2}ã€‚";
	}

	/// <summary>
	/// Key: "Description.ContactCustomerService"
	/// message shown on common error pages
	/// English String: "If you continue to receive this page, please contact customer service at {emailLink}"
	/// </summary>
	public override string DescriptionContactCustomerService(string emailLink)
	{
		return $"å¦‚æžœä½ ç»§ç»­æ”¶åˆ°æ­¤é¡µé¢ï¼Œè¯·é€šè¿‡ {emailLink} è”ç³»å®¢æˆ·æœåŠ¡ã€‚";
	}

	protected override string _GetTemplateForDescriptionContactCustomerService()
	{
		return "å¦‚æžœä½ ç»§ç»­æ”¶åˆ°æ­¤é¡µé¢ï¼Œè¯·é€šè¿‡ {emailLink} è”ç³»å®¢æˆ·æœåŠ¡ã€‚";
	}

	protected override string _GetTemplateForLabelError()
	{
		return "é”™è¯¯";
	}

	protected override string _GetTemplateForLabelErrorImage()
	{
		return "å›¾åƒé”™è¯¯";
	}

	protected override string _GetTemplateForLabelTooManyCharacters()
	{
		return "å­—ç¬¦è¿‡å¤šï¼";
	}

	protected override string _GetTemplateForMessageAlwaysAllowed()
	{
		return "å§‹ç»ˆå…è®¸";
	}

	protected override string _GetTemplateForMessageAnalyiticsCookies()
	{
		return "åˆ†æž Cookies";
	}

	protected override string _GetTemplateForMessageAnalyiticsCookiesDescription()
	{
		return "è¿™äº› cookie ç”¨äºŽæé«˜ç½‘ç«™æ€§èƒ½æˆ–äº†è§£ç½‘ç«™ä½¿ç”¨æƒ…å†µã€‚";
	}

	protected override string _GetTemplateForMessageAnalyiticsCookiesItem1()
	{
		return "Google Analyticsï¼ˆåˆ†æžï¼‰";
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
		return $"Roblox ä½¿ç”¨ cookie ä»¥ä¸ºä½ æä¾›æ›´å¥½çš„ä½“éªŒã€‚è‹¥è¦äº†è§£è¿›ä¸€æ­¥ä¿¡æ¯ï¼ŒåŒ…æ‹¬å¦‚ä½•æ’¤å›žåŒæ„ä»¥åŠå¦‚ä½•ç®¡ç† Roblox ä¸­ cookieçš„ä½¿ç”¨ç­‰ç›¸å…³ä¿¡æ¯ï¼Œè¯·å‚é˜…æˆ‘ä»¬çš„{startLink}éšç§ä¸Ž Cookie æ”¿ç­–{endLink}ã€‚";
	}

	protected override string _GetTemplateForMessageCookieLawNotice()
	{
		return "Roblox ä½¿ç”¨ cookie ä»¥ä¸ºä½ æä¾›æ›´å¥½çš„ä½“éªŒã€‚è‹¥è¦äº†è§£è¿›ä¸€æ­¥ä¿¡æ¯ï¼ŒåŒ…æ‹¬å¦‚ä½•æ’¤å›žåŒæ„ä»¥åŠå¦‚ä½•ç®¡ç† Roblox ä¸­ cookieçš„ä½¿ç”¨ç­‰ç›¸å…³ä¿¡æ¯ï¼Œè¯·å‚é˜…æˆ‘ä»¬çš„{startLink}éšç§ä¸Ž Cookie æ”¿ç­–{endLink}ã€‚";
	}

	/// <summary>
	/// Key: "Message.CookieLawNoticev2"
	/// English String: "Roblox uses cookies to personalize content, provide social media features and analyze the traffic on our site. To learn about how we use cookies and how you can {startLink}manage cookie preferences{endLink}, please refer to our {startLink2}Privacy and Cookie Policy{endLink2}."
	/// </summary>
	public override string MessageCookieLawNoticev2(string startLink, string endLink, string startLink2, string endLink2)
	{
		return $"Roblox ä½¿ç”¨ cookies æ¥ä¸ªæ€§åŒ–å†…å®¹ï¼Œæä¾›ç¤¾äº¤åª’ä½“åŠŸèƒ½ï¼Œå¹¶åˆ†æžæˆ‘ä»¬ç½‘ç«™ä¸Šçš„æµé‡ã€‚è‹¥è¦äº†è§£æˆ‘ä»¬å¦‚ä½•ä½¿ç”¨ cookies ä»¥åŠå¦‚ä½•{startLink}ç®¡ç† cookie åå¥½è®¾ç½®{endLink}ï¼Œè¯·å‚é˜…æˆ‘ä»¬çš„{startLink2}éšç§ä¸Ž cookie æ”¿ç­–{endLink2}ã€‚";
	}

	protected override string _GetTemplateForMessageCookieLawNoticev2()
	{
		return "Roblox ä½¿ç”¨ cookies æ¥ä¸ªæ€§åŒ–å†…å®¹ï¼Œæä¾›ç¤¾äº¤åª’ä½“åŠŸèƒ½ï¼Œå¹¶åˆ†æžæˆ‘ä»¬ç½‘ç«™ä¸Šçš„æµé‡ã€‚è‹¥è¦äº†è§£æˆ‘ä»¬å¦‚ä½•ä½¿ç”¨ cookies ä»¥åŠå¦‚ä½•{startLink}ç®¡ç† cookie åå¥½è®¾ç½®{endLink}ï¼Œè¯·å‚é˜…æˆ‘ä»¬çš„{startLink2}éšç§ä¸Ž cookie æ”¿ç­–{endLink2}ã€‚";
	}

	/// <summary>
	/// Key: "Message.CookieModalText"
	/// English String: "Please choose whether this site may use cookies as described below. You can learn more about how this site uses cookies and related technologies by reading our {startLink}privacy policy{endLink}."
	/// </summary>
	public override string MessageCookieModalText(string startLink, string endLink)
	{
		return $"è¯·é€‰æ‹©æ­¤ç½‘ç«™æ˜¯å¦å¯ä»¥ä½¿ç”¨ä¸‹åˆ— cookieã€‚ä½ å¯ä»¥é€šè¿‡é˜…è¯»æˆ‘ä»¬çš„{startLink}éšç§æ”¿ç­–{endLink}ï¼Œäº†è§£æ›´å¤šå…³äºŽæœ¬ç½‘ç«™å¦‚ä½•ä½¿ç”¨ cookie å’Œç›¸å…³æŠ€æœ¯çš„ä¿¡æ¯ã€‚";
	}

	protected override string _GetTemplateForMessageCookieModalText()
	{
		return "è¯·é€‰æ‹©æ­¤ç½‘ç«™æ˜¯å¦å¯ä»¥ä½¿ç”¨ä¸‹åˆ— cookieã€‚ä½ å¯ä»¥é€šè¿‡é˜…è¯»æˆ‘ä»¬çš„{startLink}éšç§æ”¿ç­–{endLink}ï¼Œäº†è§£æ›´å¤šå…³äºŽæœ¬ç½‘ç«™å¦‚ä½•ä½¿ç”¨ cookie å’Œç›¸å…³æŠ€æœ¯çš„ä¿¡æ¯ã€‚";
	}

	protected override string _GetTemplateForMessageEssentialCookies()
	{
		return "åŸºæœ¬ Cookies";
	}

	protected override string _GetTemplateForMessageEssentialCookiesDescription()
	{
		return "è¿™äº›æ˜¯æä¾›ç½‘ç«™ä¸ŠåŠŸèƒ½æ‰€å¿…éœ€çš„ cookiesï¼Œä¾‹å¦‚ç”¨äºŽç”¨æˆ·èº«ä»½éªŒè¯ã€ä¿æŠ¤ç³»ç»Ÿå®‰å…¨æˆ–ä¿å­˜ cookie é¦–é€‰é¡¹ã€‚";
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
		return "è®¿é—®è¢«æ‹’ç»";
	}

	protected override string _GetTemplateForResponseAccessDeniedDescription()
	{
		return "ä½ æ²¡æœ‰æŸ¥çœ‹æ­¤é¡µé¢çš„æƒé™ã€‚";
	}

	protected override string _GetTemplateForResponseBadRequest()
	{
		return "é”™è¯¯è¯·æ±‚";
	}

	protected override string _GetTemplateForResponseBadRequestDescription()
	{
		return "ä½ çš„è¯·æ±‚é‡åˆ°äº›é—®é¢˜";
	}

	protected override string _GetTemplateForResponseInternalServerError()
	{
		return "å†…éƒ¨æœåŠ¡å™¨é”™è¯¯";
	}

	protected override string _GetTemplateForResponseInternalServerErrorDescription()
	{
		return "å‘ç”Ÿæ„å¤–é”™è¯¯";
	}

	protected override string _GetTemplateForResponsePageNotFound()
	{
		return "æ‰¾ä¸åˆ°é¡µé¢";
	}

	protected override string _GetTemplateForResponsePageNotFoundDescrition()
	{
		return "é¡µé¢æ‰¾ä¸åˆ°æˆ–å·²ä¸å­˜åœ¨";
	}

	protected override string _GetTemplateForResponseRequestError()
	{
		return "ä½ çš„è¯·æ±‚é”™è¯¯";
	}

	protected override string _GetTemplateForResponseSomethingWentWrong()
	{
		return "æœ‰åœ°æ–¹å‡ºé”™äº†";
	}

	protected override string _GetTemplateForResponseTooManyAttemptsText()
	{
		return "å°è¯•æ¬¡æ•°è¿‡å¤š";
	}

	protected override string _GetTemplateForResponseUnexpectedError()
	{
		return "å‘ç”Ÿæ„å¤–é”™è¯¯ã€‚è¯·ç¨åŽé‡è¯•ã€‚";
	}
}


}
