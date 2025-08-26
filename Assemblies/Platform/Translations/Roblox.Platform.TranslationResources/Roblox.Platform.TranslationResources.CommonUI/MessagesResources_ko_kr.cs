namespace Roblox.Platform.TranslationResources.CommonUI {
    /// <summary>

/// This class overrides MessagesResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class MessagesResources_ko_kr : MessagesResources_en_us, IMessagesResources, ITranslationResources
{
	/// <summary>
	/// Key: "Action.PreviousPage"
	/// button title
	/// English String: "Go to the Previous Page"
	/// </summary>
	public override string ActionPreviousPage => "ì´ì „ íŽ˜ì´ì§€ë¡œ ì´ë™";

	/// <summary>
	/// Key: "Action.ReturnHome"
	/// button title
	/// English String: "Return Home"
	/// </summary>
	public override string ActionReturnHome => "í™ˆìœ¼ë¡œ ëŒì•„ê°€ê¸°";

	/// <summary>
	/// Key: "Label.Error"
	/// English String: "Error"
	/// </summary>
	public override string LabelError => "ì˜¤ë¥˜";

	/// <summary>
	/// Key: "Label.ErrorImage"
	/// alternate text shown for error image
	/// English String: "Error Image"
	/// </summary>
	public override string LabelErrorImage => "ì˜¤ë¥˜ ì´ë¯¸ì§€";

	/// <summary>
	/// Key: "Label.TooManyCharacters"
	/// English String: "Too many characters!"
	/// </summary>
	public override string LabelTooManyCharacters => "ê¸€ìž ìˆ˜ê°€ ë„ˆë¬´ ë§Žì•„ìš”!";

	/// <summary>
	/// Key: "Message.AlwaysAllowed"
	/// English String: "Always allowed"
	/// </summary>
	public override string MessageAlwaysAllowed => "í•­ìƒ í—ˆìš©";

	/// <summary>
	/// Key: "Message.AnalyiticsCookies"
	/// English String: "Analytics Cookies"
	/// </summary>
	public override string MessageAnalyiticsCookies => "ë¶„ì„ ì¿ í‚¤";

	/// <summary>
	/// Key: "Message.AnalyiticsCookiesDescription"
	/// English String: "These cookies used for improving site performance or understanding site usage."
	/// </summary>
	public override string MessageAnalyiticsCookiesDescription => "ë³¸ ì¿ í‚¤ëŠ” ì‚¬ì´íŠ¸ ì„±ëŠ¥ì„ ê°œì„ í•˜ê±°ë‚˜ ì‚¬ì´íŠ¸ ì‚¬ìš© ì •ë³´ë¥¼ íŒŒì•…í•˜ëŠ” ë° ì´ìš©ë©ë‹ˆë‹¤.";

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
	public override string MessageEssentialCookies => "í•„ìˆ˜ ì¿ í‚¤";

	/// <summary>
	/// Key: "Message.EssentialCookiesDescription"
	/// English String: "These cookies are required to provide the functionality on the site, such as for user authentication, securing the system or saving cookie preferences."
	/// </summary>
	public override string MessageEssentialCookiesDescription => "ì¿ í‚¤ëŠ” ì‚¬ìš©ìž ì¸ì¦, ì‹œìŠ¤í…œ ë³´ì•ˆ ë˜ëŠ” ì¿ í‚¤ í™˜ê²½ ì„¤ì • ì €ìž¥ ë“±ì˜ ê¸°ëŠ¥ì„ ì‚¬ì´íŠ¸ì— ì œê³µí•˜ê¸° ìœ„í•´ í•„ìš”í•©ë‹ˆë‹¤.";

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
	public override string MessageManageCookies => "ì¿ í‚¤ ê´€ë¦¬";

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
	public override string ResponseAccessDenied => "ì ‘ê·¼ ê±°ë¶€ë¨";

	/// <summary>
	/// Key: "Response.AccessDeniedDescription"
	/// 403 error message detail
	/// English String: "You don't have permission to view this page"
	/// </summary>
	public override string ResponseAccessDeniedDescription => "ì´ íŽ˜ì´ì§€ë¥¼ ë³¼ ìˆ˜ ìžˆëŠ” ê¶Œí•œì´ ì—†ìŠµë‹ˆë‹¤";

	/// <summary>
	/// Key: "Response.BadRequest"
	/// 400 error message title
	/// English String: "Bad Request"
	/// </summary>
	public override string ResponseBadRequest => "ìš”ì²­ ì‹¤íŒ¨";

	/// <summary>
	/// Key: "Response.BadRequestDescription"
	/// error message detail for 400 error
	/// English String: "There was a problem with your request"
	/// </summary>
	public override string ResponseBadRequestDescription => "ìš”ì²­ì— ì˜¤ë¥˜ê°€ ìžˆìŠµë‹ˆë‹¤";

	/// <summary>
	/// Key: "Response.InternalServerError"
	/// 500 error message title
	/// English String: "Internal Server Error"
	/// </summary>
	public override string ResponseInternalServerError => "ë‚´ë¶€ ì„œë²„ ì˜¤ë¥˜";

	/// <summary>
	/// Key: "Response.InternalServerErrorDescription"
	/// 500 error message description
	/// English String: "An unexpected error occurred"
	/// </summary>
	public override string ResponseInternalServerErrorDescription => "ì˜ˆê¸°ì¹˜ ëª»í•œ ì˜¤ë¥˜ ë°œìƒ";

	/// <summary>
	/// Key: "Response.PageNotFound"
	/// 404 error message title
	/// English String: "Page Not found"
	/// </summary>
	public override string ResponsePageNotFound => "íŽ˜ì´ì§€ë¥¼ ì°¾ì„ ìˆ˜ ì—†ìŒ";

	/// <summary>
	/// Key: "Response.PageNotFoundDescrition"
	/// 404 error message description
	/// English String: "Page cannot be found or no longer exists"
	/// </summary>
	public override string ResponsePageNotFoundDescrition => "íŽ˜ì´ì§€ë¥¼ ì°¾ì„ ìˆ˜ ì—†ê±°ë‚˜ ì¡´ìž¬í•˜ì§€ ì•ŠìŠµë‹ˆë‹¤";

	/// <summary>
	/// Key: "Response.RequestError"
	/// error message for incorrect request
	/// English String: "Error with your request"
	/// </summary>
	public override string ResponseRequestError => "ìš”ì²­ ê´€ë ¨ ì˜¤ë¥˜";

	/// <summary>
	/// Key: "Response.SomethingWentWrong"
	/// default error message
	/// English String: "Something went wrong"
	/// </summary>
	public override string ResponseSomethingWentWrong => "ì˜¤ë¥˜ê°€ ë°œìƒí–ˆì–´ìš”";

	/// <summary>
	/// Key: "Response.TooManyAttemptsText"
	/// English String: "Too Many Attempts"
	/// </summary>
	public override string ResponseTooManyAttemptsText => "ì‹œë„ ê°€ëŠ¥ íšŸìˆ˜ë¥¼ ì´ˆê³¼í–ˆìŠµë‹ˆë‹¤";

	/// <summary>
	/// Key: "Response.UnexpectedError"
	/// default error description
	/// English String: "An unexpected error occurred. Please try again later."
	/// </summary>
	public override string ResponseUnexpectedError => "ì˜ˆê¸°ì¹˜ ëª»í•œ ì˜¤ë¥˜ê°€ ë°œìƒí–ˆì–´ìš”. ë‚˜ì¤‘ì— ë‹¤ì‹œ ì‹œë„í•˜ì„¸ìš”.";

	public MessagesResources_ko_kr(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionPreviousPage()
	{
		return "ì´ì „ íŽ˜ì´ì§€ë¡œ ì´ë™";
	}

	protected override string _GetTemplateForActionReturnHome()
	{
		return "í™ˆìœ¼ë¡œ ëŒì•„ê°€ê¸°";
	}

	/// <summary>
	/// Key: "CookieLawNoticev2"
	/// Incorrect key, obsoleted
	/// English String: "Roblox uses cookies to personalize content, provide social media features and analyze the traffic on our site. To learn about how we use cookies and how you can {startLink}manage cookie preferences{endLink}, please refer to our {startLink2}Privacy and Cookie Policy{endLink2}."
	/// </summary>
	public override string CookieLawNoticev2(string startLink, string endLink, string startLink2, string endLink2)
	{
		return $"RobloxëŠ” ë§žì¶¤í˜• ì½˜í…ì¸ , ì†Œì…œ ë¯¸ë””ì–´ ê¸°ëŠ¥ ì œê³µ ë° ì‚¬ì´íŠ¸ íŠ¸ëž˜í”½ì„ ë¶„ì„ì„ ìœ„í•´ ì¿ í‚¤ë¥¼ ì‚¬ìš©í•©ë‹ˆë‹¤. Robloxì˜ ì¿ í‚¤ ì‚¬ìš© ë°©ë²• ë° {startLink}ì¿ í‚¤ í™˜ê²½ì„¤ì • ê´€ë¦¬{endLink} ë°©ë²•ì— ëŒ€í•œ ìƒì„¸ ì •ë³´ëŠ” {startLink2}ê°œì¸ì •ë³´ ë° ì¿ í‚¤ ì •ì±…{endLink2}ì„ ì°¸ê³ í•˜ì„¸ìš”.";
	}

	protected override string _GetTemplateForCookieLawNoticev2()
	{
		return "RobloxëŠ” ë§žì¶¤í˜• ì½˜í…ì¸ , ì†Œì…œ ë¯¸ë””ì–´ ê¸°ëŠ¥ ì œê³µ ë° ì‚¬ì´íŠ¸ íŠ¸ëž˜í”½ì„ ë¶„ì„ì„ ìœ„í•´ ì¿ í‚¤ë¥¼ ì‚¬ìš©í•©ë‹ˆë‹¤. Robloxì˜ ì¿ í‚¤ ì‚¬ìš© ë°©ë²• ë° {startLink}ì¿ í‚¤ í™˜ê²½ì„¤ì • ê´€ë¦¬{endLink} ë°©ë²•ì— ëŒ€í•œ ìƒì„¸ ì •ë³´ëŠ” {startLink2}ê°œì¸ì •ë³´ ë° ì¿ í‚¤ ì •ì±…{endLink2}ì„ ì°¸ê³ í•˜ì„¸ìš”.";
	}

	/// <summary>
	/// Key: "Description.ContactCustomerService"
	/// message shown on common error pages
	/// English String: "If you continue to receive this page, please contact customer service at {emailLink}"
	/// </summary>
	public override string DescriptionContactCustomerService(string emailLink)
	{
		return $"ì´ íŽ˜ì´ì§€ê°€ ê³„ì†í•´ì„œ ë‚˜íƒ€ë‚˜ëŠ” ê²½ìš° {emailLink}ì„(ë¥¼) í†µí•´ ë¬¸ì˜í•˜ì„¸ìš”";
	}

	protected override string _GetTemplateForDescriptionContactCustomerService()
	{
		return "ì´ íŽ˜ì´ì§€ê°€ ê³„ì†í•´ì„œ ë‚˜íƒ€ë‚˜ëŠ” ê²½ìš° {emailLink}ì„(ë¥¼) í†µí•´ ë¬¸ì˜í•˜ì„¸ìš”";
	}

	protected override string _GetTemplateForLabelError()
	{
		return "ì˜¤ë¥˜";
	}

	protected override string _GetTemplateForLabelErrorImage()
	{
		return "ì˜¤ë¥˜ ì´ë¯¸ì§€";
	}

	protected override string _GetTemplateForLabelTooManyCharacters()
	{
		return "ê¸€ìž ìˆ˜ê°€ ë„ˆë¬´ ë§Žì•„ìš”!";
	}

	protected override string _GetTemplateForMessageAlwaysAllowed()
	{
		return "í•­ìƒ í—ˆìš©";
	}

	protected override string _GetTemplateForMessageAnalyiticsCookies()
	{
		return "ë¶„ì„ ì¿ í‚¤";
	}

	protected override string _GetTemplateForMessageAnalyiticsCookiesDescription()
	{
		return "ë³¸ ì¿ í‚¤ëŠ” ì‚¬ì´íŠ¸ ì„±ëŠ¥ì„ ê°œì„ í•˜ê±°ë‚˜ ì‚¬ì´íŠ¸ ì‚¬ìš© ì •ë³´ë¥¼ íŒŒì•…í•˜ëŠ” ë° ì´ìš©ë©ë‹ˆë‹¤.";
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
		return $"RobloxëŠ” ë” ë‚˜ì€ í™˜ê²½ì„ ì œê³µí•˜ê¸° ìœ„í•´ ì¿ í‚¤ë¥¼ ì‚¬ìš©í•©ë‹ˆë‹¤. Robloxì—ì„œì˜ ì¿ í‚¤ ì‚¬ìš© ë™ì˜ ì·¨ì†Œ ë°©ë²• ë° ì¿ í‚¤ ì‚¬ìš© ê´€ë¦¬ ë°©ë²•ì— ëŒ€í•œ ìžì„¸í•œ ì •ë³´ëŠ” {startLink}ê°œì¸ì •ë³´ ë° ì¿ í‚¤ ì •ì±…{endLink}ì„ í™•ì¸í•˜ì„¸ìš”.";
	}

	protected override string _GetTemplateForMessageCookieLawNotice()
	{
		return "RobloxëŠ” ë” ë‚˜ì€ í™˜ê²½ì„ ì œê³µí•˜ê¸° ìœ„í•´ ì¿ í‚¤ë¥¼ ì‚¬ìš©í•©ë‹ˆë‹¤. Robloxì—ì„œì˜ ì¿ í‚¤ ì‚¬ìš© ë™ì˜ ì·¨ì†Œ ë°©ë²• ë° ì¿ í‚¤ ì‚¬ìš© ê´€ë¦¬ ë°©ë²•ì— ëŒ€í•œ ìžì„¸í•œ ì •ë³´ëŠ” {startLink}ê°œì¸ì •ë³´ ë° ì¿ í‚¤ ì •ì±…{endLink}ì„ í™•ì¸í•˜ì„¸ìš”.";
	}

	/// <summary>
	/// Key: "Message.CookieLawNoticev2"
	/// English String: "Roblox uses cookies to personalize content, provide social media features and analyze the traffic on our site. To learn about how we use cookies and how you can {startLink}manage cookie preferences{endLink}, please refer to our {startLink2}Privacy and Cookie Policy{endLink2}."
	/// </summary>
	public override string MessageCookieLawNoticev2(string startLink, string endLink, string startLink2, string endLink2)
	{
		return $"RobloxëŠ” ë§žì¶¤í˜• ì½˜í…ì¸ , ì†Œì…œ ë¯¸ë””ì–´ ê¸°ëŠ¥ ì œê³µ ë° ì‚¬ì´íŠ¸ íŠ¸ëž˜í”½ ë¶„ì„ì„ ìœ„í•´ ì¿ í‚¤ë¥¼ ì‚¬ìš©í•©ë‹ˆë‹¤. Robloxì˜ ì¿ í‚¤ ì‚¬ìš© ë°©ë²• ë° {startLink}ì¿ í‚¤ í™˜ê²½ì„¤ì • ê´€ë¦¬{endLink} ë°©ë²•ì— ëŒ€í•œ ìƒì„¸ ì •ë³´ëŠ” {startLink2}ê°œì¸ì •ë³´ ë° ì¿ í‚¤ ì •ì±…{endLink2}ì„ ì°¸ê³ í•˜ì„¸ìš”.";
	}

	protected override string _GetTemplateForMessageCookieLawNoticev2()
	{
		return "RobloxëŠ” ë§žì¶¤í˜• ì½˜í…ì¸ , ì†Œì…œ ë¯¸ë””ì–´ ê¸°ëŠ¥ ì œê³µ ë° ì‚¬ì´íŠ¸ íŠ¸ëž˜í”½ ë¶„ì„ì„ ìœ„í•´ ì¿ í‚¤ë¥¼ ì‚¬ìš©í•©ë‹ˆë‹¤. Robloxì˜ ì¿ í‚¤ ì‚¬ìš© ë°©ë²• ë° {startLink}ì¿ í‚¤ í™˜ê²½ì„¤ì • ê´€ë¦¬{endLink} ë°©ë²•ì— ëŒ€í•œ ìƒì„¸ ì •ë³´ëŠ” {startLink2}ê°œì¸ì •ë³´ ë° ì¿ í‚¤ ì •ì±…{endLink2}ì„ ì°¸ê³ í•˜ì„¸ìš”.";
	}

	/// <summary>
	/// Key: "Message.CookieModalText"
	/// English String: "Please choose whether this site may use cookies as described below. You can learn more about how this site uses cookies and related technologies by reading our {startLink}privacy policy{endLink}."
	/// </summary>
	public override string MessageCookieModalText(string startLink, string endLink)
	{
		return $"ì•„ëž˜ ì„¤ëª…ì— ë”°ë¥¸ ë³¸ ì‚¬ì´íŠ¸ì˜ ì¿ í‚¤ ì‚¬ìš© ì—¬ë¶€ë¥¼ ì„ íƒí•˜ì„¸ìš”. ë³¸ ì‚¬ì´íŠ¸ì˜ ì¿ í‚¤ ì‚¬ìš© ë°©ë²•ê³¼ ê´€ë ¨ ê¸°ìˆ ì— ëŒ€í•œ ìƒì„¸ ì •ë³´ëŠ” {startLink}ê°œì¸ì •ë³´ ì²˜ë¦¬ë°©ì¹¨{endLink}ì„ ì°¸ê³ í•˜ì„¸ìš”.";
	}

	protected override string _GetTemplateForMessageCookieModalText()
	{
		return "ì•„ëž˜ ì„¤ëª…ì— ë”°ë¥¸ ë³¸ ì‚¬ì´íŠ¸ì˜ ì¿ í‚¤ ì‚¬ìš© ì—¬ë¶€ë¥¼ ì„ íƒí•˜ì„¸ìš”. ë³¸ ì‚¬ì´íŠ¸ì˜ ì¿ í‚¤ ì‚¬ìš© ë°©ë²•ê³¼ ê´€ë ¨ ê¸°ìˆ ì— ëŒ€í•œ ìƒì„¸ ì •ë³´ëŠ” {startLink}ê°œì¸ì •ë³´ ì²˜ë¦¬ë°©ì¹¨{endLink}ì„ ì°¸ê³ í•˜ì„¸ìš”.";
	}

	protected override string _GetTemplateForMessageEssentialCookies()
	{
		return "í•„ìˆ˜ ì¿ í‚¤";
	}

	protected override string _GetTemplateForMessageEssentialCookiesDescription()
	{
		return "ì¿ í‚¤ëŠ” ì‚¬ìš©ìž ì¸ì¦, ì‹œìŠ¤í…œ ë³´ì•ˆ ë˜ëŠ” ì¿ í‚¤ í™˜ê²½ ì„¤ì • ì €ìž¥ ë“±ì˜ ê¸°ëŠ¥ì„ ì‚¬ì´íŠ¸ì— ì œê³µí•˜ê¸° ìœ„í•´ í•„ìš”í•©ë‹ˆë‹¤.";
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
		return "ì¿ í‚¤ ê´€ë¦¬";
	}

	protected override string _GetTemplateForMessageEssentialCookiesItem3()
	{
		return "Gigya";
	}

	protected override string _GetTemplateForResponseAccessDenied()
	{
		return "ì ‘ê·¼ ê±°ë¶€ë¨";
	}

	protected override string _GetTemplateForResponseAccessDeniedDescription()
	{
		return "ì´ íŽ˜ì´ì§€ë¥¼ ë³¼ ìˆ˜ ìžˆëŠ” ê¶Œí•œì´ ì—†ìŠµë‹ˆë‹¤";
	}

	protected override string _GetTemplateForResponseBadRequest()
	{
		return "ìš”ì²­ ì‹¤íŒ¨";
	}

	protected override string _GetTemplateForResponseBadRequestDescription()
	{
		return "ìš”ì²­ì— ì˜¤ë¥˜ê°€ ìžˆìŠµë‹ˆë‹¤";
	}

	protected override string _GetTemplateForResponseInternalServerError()
	{
		return "ë‚´ë¶€ ì„œë²„ ì˜¤ë¥˜";
	}

	protected override string _GetTemplateForResponseInternalServerErrorDescription()
	{
		return "ì˜ˆê¸°ì¹˜ ëª»í•œ ì˜¤ë¥˜ ë°œìƒ";
	}

	protected override string _GetTemplateForResponsePageNotFound()
	{
		return "íŽ˜ì´ì§€ë¥¼ ì°¾ì„ ìˆ˜ ì—†ìŒ";
	}

	protected override string _GetTemplateForResponsePageNotFoundDescrition()
	{
		return "íŽ˜ì´ì§€ë¥¼ ì°¾ì„ ìˆ˜ ì—†ê±°ë‚˜ ì¡´ìž¬í•˜ì§€ ì•ŠìŠµë‹ˆë‹¤";
	}

	protected override string _GetTemplateForResponseRequestError()
	{
		return "ìš”ì²­ ê´€ë ¨ ì˜¤ë¥˜";
	}

	protected override string _GetTemplateForResponseSomethingWentWrong()
	{
		return "ì˜¤ë¥˜ê°€ ë°œìƒí–ˆì–´ìš”";
	}

	protected override string _GetTemplateForResponseTooManyAttemptsText()
	{
		return "ì‹œë„ ê°€ëŠ¥ íšŸìˆ˜ë¥¼ ì´ˆê³¼í–ˆìŠµë‹ˆë‹¤";
	}

	protected override string _GetTemplateForResponseUnexpectedError()
	{
		return "ì˜ˆê¸°ì¹˜ ëª»í•œ ì˜¤ë¥˜ê°€ ë°œìƒí–ˆì–´ìš”. ë‚˜ì¤‘ì— ë‹¤ì‹œ ì‹œë„í•˜ì„¸ìš”.";
	}
}


}
