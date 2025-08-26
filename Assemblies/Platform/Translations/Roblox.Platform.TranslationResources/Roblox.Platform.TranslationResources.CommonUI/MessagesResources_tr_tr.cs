namespace Roblox.Platform.TranslationResources.CommonUI {
    /// <summary>

/// This class overrides MessagesResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class MessagesResources_tr_tr : MessagesResources_en_us, IMessagesResources, ITranslationResources
{
	/// <summary>
	/// Key: "Action.PreviousPage"
	/// button title
	/// English String: "Go to the Previous Page"
	/// </summary>
	public override string ActionPreviousPage => "Ã–nceki Sayfaya Git";

	/// <summary>
	/// Key: "Action.ReturnHome"
	/// button title
	/// English String: "Return Home"
	/// </summary>
	public override string ActionReturnHome => "GiriÅŸe DÃ¶n";

	/// <summary>
	/// Key: "Label.Error"
	/// English String: "Error"
	/// </summary>
	public override string LabelError => "Hata";

	/// <summary>
	/// Key: "Label.ErrorImage"
	/// alternate text shown for error image
	/// English String: "Error Image"
	/// </summary>
	public override string LabelErrorImage => "Hata GÃ¶rseli";

	/// <summary>
	/// Key: "Label.TooManyCharacters"
	/// English String: "Too many characters!"
	/// </summary>
	public override string LabelTooManyCharacters => "Ã‡ok fazla karakter!";

	/// <summary>
	/// Key: "Message.AlwaysAllowed"
	/// English String: "Always allowed"
	/// </summary>
	public override string MessageAlwaysAllowed => "Her zaman izin verilir";

	/// <summary>
	/// Key: "Message.AnalyiticsCookies"
	/// English String: "Analytics Cookies"
	/// </summary>
	public override string MessageAnalyiticsCookies => "Analiz Ã‡erezleri";

	/// <summary>
	/// Key: "Message.AnalyiticsCookiesDescription"
	/// English String: "These cookies used for improving site performance or understanding site usage."
	/// </summary>
	public override string MessageAnalyiticsCookiesDescription => "Bu Ã§erezler, site performansÄ±nÄ± iyileÅŸtirmek veya site kullanÄ±mÄ±nÄ± anlamak iÃ§in kullanÄ±lÄ±r.";

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
	public override string MessageEssentialCookies => "Temel Ã‡erezler";

	/// <summary>
	/// Key: "Message.EssentialCookiesDescription"
	/// English String: "These cookies are required to provide the functionality on the site, such as for user authentication, securing the system or saving cookie preferences."
	/// </summary>
	public override string MessageEssentialCookiesDescription => "Bu Ã§erezler, kullanÄ±cÄ± doÄŸrulama, sistemi gÃ¼vende tutma veya Ã§erez tercihlerini kaydetme gibi iÅŸlevleri sitede saÄŸlayabilmek iÃ§in gereklidir.";

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
	public override string MessageManageCookies => "Ã‡erezleri YÃ¶net";

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
	public override string ResponseAccessDenied => "EriÅŸim Reddedildi";

	/// <summary>
	/// Key: "Response.AccessDeniedDescription"
	/// 403 error message detail
	/// English String: "You don't have permission to view this page"
	/// </summary>
	public override string ResponseAccessDeniedDescription => "Bu sayfayÄ± gÃ¶rÃ¼ntÃ¼leme iznin yok";

	/// <summary>
	/// Key: "Response.BadRequest"
	/// 400 error message title
	/// English String: "Bad Request"
	/// </summary>
	public override string ResponseBadRequest => "GeÃ§ersiz Ä°stek";

	/// <summary>
	/// Key: "Response.BadRequestDescription"
	/// error message detail for 400 error
	/// English String: "There was a problem with your request"
	/// </summary>
	public override string ResponseBadRequestDescription => "Ä°steÄŸinle ilgili bir sorun Ã§Ä±ktÄ±";

	/// <summary>
	/// Key: "Response.InternalServerError"
	/// 500 error message title
	/// English String: "Internal Server Error"
	/// </summary>
	public override string ResponseInternalServerError => "Dahili Sunucu HatasÄ±";

	/// <summary>
	/// Key: "Response.InternalServerErrorDescription"
	/// 500 error message description
	/// English String: "An unexpected error occurred"
	/// </summary>
	public override string ResponseInternalServerErrorDescription => "Beklenmedik bir hata meydana geldi";

	/// <summary>
	/// Key: "Response.PageNotFound"
	/// 404 error message title
	/// English String: "Page Not found"
	/// </summary>
	public override string ResponsePageNotFound => "Sayfa BulunamadÄ±";

	/// <summary>
	/// Key: "Response.PageNotFoundDescrition"
	/// 404 error message description
	/// English String: "Page cannot be found or no longer exists"
	/// </summary>
	public override string ResponsePageNotFoundDescrition => "Sayfa bulunamadÄ± veya artÄ±k mevcut deÄŸil";

	/// <summary>
	/// Key: "Response.RequestError"
	/// error message for incorrect request
	/// English String: "Error with your request"
	/// </summary>
	public override string ResponseRequestError => "Ä°steÄŸinle ilgili hata";

	/// <summary>
	/// Key: "Response.SomethingWentWrong"
	/// default error message
	/// English String: "Something went wrong"
	/// </summary>
	public override string ResponseSomethingWentWrong => "Bir ÅŸeyler yanlÄ±ÅŸ gitti";

	/// <summary>
	/// Key: "Response.TooManyAttemptsText"
	/// English String: "Too Many Attempts"
	/// </summary>
	public override string ResponseTooManyAttemptsText => "Ã‡ok SayÄ±da Deneme";

	/// <summary>
	/// Key: "Response.UnexpectedError"
	/// default error description
	/// English String: "An unexpected error occurred. Please try again later."
	/// </summary>
	public override string ResponseUnexpectedError => "Beklenmedik bir hata meydana geldi. LÃ¼tfen daha sonra tekrar dene.";

	public MessagesResources_tr_tr(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionPreviousPage()
	{
		return "Ã–nceki Sayfaya Git";
	}

	protected override string _GetTemplateForActionReturnHome()
	{
		return "GiriÅŸe DÃ¶n";
	}

	/// <summary>
	/// Key: "CookieLawNoticev2"
	/// Incorrect key, obsoleted
	/// English String: "Roblox uses cookies to personalize content, provide social media features and analyze the traffic on our site. To learn about how we use cookies and how you can {startLink}manage cookie preferences{endLink}, please refer to our {startLink2}Privacy and Cookie Policy{endLink2}."
	/// </summary>
	public override string CookieLawNoticev2(string startLink, string endLink, string startLink2, string endLink2)
	{
		return $"Roblox, iÃ§eriÄŸi kiÅŸiselleÅŸtirmek, sosyal medya Ã¶zellikleri sunmak ve sitemizdeki trafiÄŸi analiz etmek iÃ§in Ã§erezleri kullanÄ±r. Ã‡erezleri nasÄ±l kullandÄ±ÄŸÄ±mÄ±zÄ± ve {startLink}Ã§erez tercihlerini nasÄ±l yÃ¶netebileceÄŸini{endLink} Ã¶ÄŸrenmek iÃ§in lÃ¼tfen {startLink2}Gizlilik ve Ã‡erez PolitikamÄ±zÄ±{endLink2} incele.";
	}

	protected override string _GetTemplateForCookieLawNoticev2()
	{
		return "Roblox, iÃ§eriÄŸi kiÅŸiselleÅŸtirmek, sosyal medya Ã¶zellikleri sunmak ve sitemizdeki trafiÄŸi analiz etmek iÃ§in Ã§erezleri kullanÄ±r. Ã‡erezleri nasÄ±l kullandÄ±ÄŸÄ±mÄ±zÄ± ve {startLink}Ã§erez tercihlerini nasÄ±l yÃ¶netebileceÄŸini{endLink} Ã¶ÄŸrenmek iÃ§in lÃ¼tfen {startLink2}Gizlilik ve Ã‡erez PolitikamÄ±zÄ±{endLink2} incele.";
	}

	/// <summary>
	/// Key: "Description.ContactCustomerService"
	/// message shown on common error pages
	/// English String: "If you continue to receive this page, please contact customer service at {emailLink}"
	/// </summary>
	public override string DescriptionContactCustomerService(string emailLink)
	{
		return $"Bu sayfayÄ± almaya devam edersen lÃ¼tfen {emailLink} baÄŸlantÄ±sÄ±ndan mÃ¼ÅŸteri hizmetleriyle iletiÅŸime geÃ§";
	}

	protected override string _GetTemplateForDescriptionContactCustomerService()
	{
		return "Bu sayfayÄ± almaya devam edersen lÃ¼tfen {emailLink} baÄŸlantÄ±sÄ±ndan mÃ¼ÅŸteri hizmetleriyle iletiÅŸime geÃ§";
	}

	protected override string _GetTemplateForLabelError()
	{
		return "Hata";
	}

	protected override string _GetTemplateForLabelErrorImage()
	{
		return "Hata GÃ¶rseli";
	}

	protected override string _GetTemplateForLabelTooManyCharacters()
	{
		return "Ã‡ok fazla karakter!";
	}

	protected override string _GetTemplateForMessageAlwaysAllowed()
	{
		return "Her zaman izin verilir";
	}

	protected override string _GetTemplateForMessageAnalyiticsCookies()
	{
		return "Analiz Ã‡erezleri";
	}

	protected override string _GetTemplateForMessageAnalyiticsCookiesDescription()
	{
		return "Bu Ã§erezler, site performansÄ±nÄ± iyileÅŸtirmek veya site kullanÄ±mÄ±nÄ± anlamak iÃ§in kullanÄ±lÄ±r.";
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
		return $"Roblox, sana daha iyi bir deneyim sunabilmek iÃ§in Ã§erezler kullanÄ±r. RÄ±zanÄ± nasÄ±l geri Ã§ekeceÄŸine ve Roblox'ta Ã§erezlerin kullanÄ±mÄ±nÄ± nasÄ±l yÃ¶netebileceÄŸine dair daha fazla bilgi iÃ§in lÃ¼tfen {startLink}Gizlilik ve Ã‡erez PolitikamÄ±za{endLink} gÃ¶z at.";
	}

	protected override string _GetTemplateForMessageCookieLawNotice()
	{
		return "Roblox, sana daha iyi bir deneyim sunabilmek iÃ§in Ã§erezler kullanÄ±r. RÄ±zanÄ± nasÄ±l geri Ã§ekeceÄŸine ve Roblox'ta Ã§erezlerin kullanÄ±mÄ±nÄ± nasÄ±l yÃ¶netebileceÄŸine dair daha fazla bilgi iÃ§in lÃ¼tfen {startLink}Gizlilik ve Ã‡erez PolitikamÄ±za{endLink} gÃ¶z at.";
	}

	/// <summary>
	/// Key: "Message.CookieLawNoticev2"
	/// English String: "Roblox uses cookies to personalize content, provide social media features and analyze the traffic on our site. To learn about how we use cookies and how you can {startLink}manage cookie preferences{endLink}, please refer to our {startLink2}Privacy and Cookie Policy{endLink2}."
	/// </summary>
	public override string MessageCookieLawNoticev2(string startLink, string endLink, string startLink2, string endLink2)
	{
		return $"Roblox, iÃ§eriÄŸi kiÅŸiselleÅŸtirmek, sosyal medya Ã¶zellikleri sunmak ve sitemizdeki trafiÄŸi analiz etmek iÃ§in Ã§erezleri kullanÄ±r. Ã‡erezleri nasÄ±l kullandÄ±ÄŸÄ±mÄ±zÄ± ve {startLink}Ã§erez tercihlerini nasÄ±l yÃ¶netebileceÄŸini{endLink} Ã¶ÄŸrenmek iÃ§in lÃ¼tfen {startLink2}Gizlilik ve Ã‡erez PolitikamÄ±zÄ±{endLink2} incele.";
	}

	protected override string _GetTemplateForMessageCookieLawNoticev2()
	{
		return "Roblox, iÃ§eriÄŸi kiÅŸiselleÅŸtirmek, sosyal medya Ã¶zellikleri sunmak ve sitemizdeki trafiÄŸi analiz etmek iÃ§in Ã§erezleri kullanÄ±r. Ã‡erezleri nasÄ±l kullandÄ±ÄŸÄ±mÄ±zÄ± ve {startLink}Ã§erez tercihlerini nasÄ±l yÃ¶netebileceÄŸini{endLink} Ã¶ÄŸrenmek iÃ§in lÃ¼tfen {startLink2}Gizlilik ve Ã‡erez PolitikamÄ±zÄ±{endLink2} incele.";
	}

	/// <summary>
	/// Key: "Message.CookieModalText"
	/// English String: "Please choose whether this site may use cookies as described below. You can learn more about how this site uses cookies and related technologies by reading our {startLink}privacy policy{endLink}."
	/// </summary>
	public override string MessageCookieModalText(string startLink, string endLink)
	{
		return $"LÃ¼tfen bu sitenin Ã§erezleri aÅŸaÄŸÄ±da tarif edildiÄŸi ÅŸekilde kullanÄ±p kullanamayacaÄŸÄ±nÄ± seÃ§. Bu sitenin Ã§erezleri ve ilgili teknolojileri nasÄ±l kullandÄ±ÄŸÄ±na dair daha fazla bilgiyi {startLink}gizlilik politikamÄ±zÄ±{endLink} okuyarak edinebilirsin.";
	}

	protected override string _GetTemplateForMessageCookieModalText()
	{
		return "LÃ¼tfen bu sitenin Ã§erezleri aÅŸaÄŸÄ±da tarif edildiÄŸi ÅŸekilde kullanÄ±p kullanamayacaÄŸÄ±nÄ± seÃ§. Bu sitenin Ã§erezleri ve ilgili teknolojileri nasÄ±l kullandÄ±ÄŸÄ±na dair daha fazla bilgiyi {startLink}gizlilik politikamÄ±zÄ±{endLink} okuyarak edinebilirsin.";
	}

	protected override string _GetTemplateForMessageEssentialCookies()
	{
		return "Temel Ã‡erezler";
	}

	protected override string _GetTemplateForMessageEssentialCookiesDescription()
	{
		return "Bu Ã§erezler, kullanÄ±cÄ± doÄŸrulama, sistemi gÃ¼vende tutma veya Ã§erez tercihlerini kaydetme gibi iÅŸlevleri sitede saÄŸlayabilmek iÃ§in gereklidir.";
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
		return "Ã‡erezleri YÃ¶net";
	}

	protected override string _GetTemplateForMessageEssentialCookiesItem3()
	{
		return "Gigya";
	}

	protected override string _GetTemplateForResponseAccessDenied()
	{
		return "EriÅŸim Reddedildi";
	}

	protected override string _GetTemplateForResponseAccessDeniedDescription()
	{
		return "Bu sayfayÄ± gÃ¶rÃ¼ntÃ¼leme iznin yok";
	}

	protected override string _GetTemplateForResponseBadRequest()
	{
		return "GeÃ§ersiz Ä°stek";
	}

	protected override string _GetTemplateForResponseBadRequestDescription()
	{
		return "Ä°steÄŸinle ilgili bir sorun Ã§Ä±ktÄ±";
	}

	protected override string _GetTemplateForResponseInternalServerError()
	{
		return "Dahili Sunucu HatasÄ±";
	}

	protected override string _GetTemplateForResponseInternalServerErrorDescription()
	{
		return "Beklenmedik bir hata meydana geldi";
	}

	protected override string _GetTemplateForResponsePageNotFound()
	{
		return "Sayfa BulunamadÄ±";
	}

	protected override string _GetTemplateForResponsePageNotFoundDescrition()
	{
		return "Sayfa bulunamadÄ± veya artÄ±k mevcut deÄŸil";
	}

	protected override string _GetTemplateForResponseRequestError()
	{
		return "Ä°steÄŸinle ilgili hata";
	}

	protected override string _GetTemplateForResponseSomethingWentWrong()
	{
		return "Bir ÅŸeyler yanlÄ±ÅŸ gitti";
	}

	protected override string _GetTemplateForResponseTooManyAttemptsText()
	{
		return "Ã‡ok SayÄ±da Deneme";
	}

	protected override string _GetTemplateForResponseUnexpectedError()
	{
		return "Beklenmedik bir hata meydana geldi. LÃ¼tfen daha sonra tekrar dene.";
	}
}


}
