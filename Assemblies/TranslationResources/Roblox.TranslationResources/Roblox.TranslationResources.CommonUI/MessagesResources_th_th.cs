namespace Roblox.TranslationResources.CommonUI;

/// <summary>
/// This class overrides MessagesResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class MessagesResources_th_th : MessagesResources_en_us, IMessagesResources, ITranslationResources
{
	/// <summary>
	/// Key: "Action.PreviousPage"
	/// button title
	/// English String: "Go to the Previous Page"
	/// </summary>
	public override string ActionPreviousPage => "ไปย\u0e31งหน\u0e49าก\u0e48อนหน\u0e49า";

	/// <summary>
	/// Key: "Action.ReturnHome"
	/// button title
	/// English String: "Return Home"
	/// </summary>
	public override string ActionReturnHome => "กล\u0e31บไปหน\u0e49าหล\u0e31ก";

	/// <summary>
	/// Key: "Label.Error"
	/// English String: "Error"
	/// </summary>
	public override string LabelError => "ข\u0e49อผ\u0e34ดพลาด";

	/// <summary>
	/// Key: "Label.ErrorImage"
	/// alternate text shown for error image
	/// English String: "Error Image"
	/// </summary>
	public override string LabelErrorImage => "ภาพข\u0e49อผ\u0e34ดพลาด";

	/// <summary>
	/// Key: "Label.TooManyCharacters"
	/// English String: "Too many characters!"
	/// </summary>
	public override string LabelTooManyCharacters => "ม\u0e35อ\u0e31กขระมากเก\u0e34นไป!";

	/// <summary>
	/// Key: "Message.AlwaysAllowed"
	/// English String: "Always allowed"
	/// </summary>
	public override string MessageAlwaysAllowed => "อน\u0e38ญาตเสมอ";

	/// <summary>
	/// Key: "Message.AnalyiticsCookies"
	/// English String: "Analytics Cookies"
	/// </summary>
	public override string MessageAnalyiticsCookies => "ค\u0e38กก\u0e35\u0e49ว\u0e34เคราะห\u0e4c";

	/// <summary>
	/// Key: "Message.AnalyiticsCookiesDescription"
	/// English String: "These cookies used for improving site performance or understanding site usage."
	/// </summary>
	public override string MessageAnalyiticsCookiesDescription => "ค\u0e38กก\u0e35\u0e49เหล\u0e48าน\u0e35\u0e49ถ\u0e39กใช\u0e49ในการปร\u0e31บปร\u0e38งประส\u0e34ทธ\u0e34ภาพของเว\u0e47บไซต\u0e4cหร\u0e37อการว\u0e34เคราะห\u0e4cการใช\u0e49งานเว\u0e47บไซต\u0e4c";

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
	public override string MessageEssentialCookies => "ค\u0e38กก\u0e35\u0e49ท\u0e35\u0e48สำค\u0e31ญ";

	/// <summary>
	/// Key: "Message.EssentialCookiesDescription"
	/// English String: "These cookies are required to provide the functionality on the site, such as for user authentication, securing the system or saving cookie preferences."
	/// </summary>
	public override string MessageEssentialCookiesDescription => "ค\u0e38กก\u0e35\u0e49เหล\u0e48าน\u0e35\u0e49เป\u0e47นส\u0e34\u0e48งท\u0e35\u0e48จำเป\u0e47นสำหร\u0e31บการทำงานของเว\u0e47บไซต\u0e4cน\u0e35\u0e49 อย\u0e48างเช\u0e48นการตรวจสอบต\u0e31วตนของผ\u0e39\u0e49ใช\u0e49 การร\u0e31กษาความปลอดภ\u0e31ยของระบบ หร\u0e37อการบ\u0e31นท\u0e36กต\u0e31วเล\u0e37อกการใช\u0e49งานค\u0e38กก\u0e35\u0e49";

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
	public override string MessageManageCookies => "จ\u0e31ดการค\u0e38กก\u0e35\u0e49";

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
	public override string ResponseAccessDenied => "การเข\u0e49าถ\u0e36งถ\u0e39กปฏ\u0e34เสธ";

	/// <summary>
	/// Key: "Response.AccessDeniedDescription"
	/// 403 error message detail
	/// English String: "You don't have permission to view this page"
	/// </summary>
	public override string ResponseAccessDeniedDescription => "ค\u0e38ณไม\u0e48ม\u0e35ส\u0e34ทธ\u0e34ด\u0e39หน\u0e49าเพจน\u0e35\u0e49";

	/// <summary>
	/// Key: "Response.BadRequest"
	/// 400 error message title
	/// English String: "Bad Request"
	/// </summary>
	public override string ResponseBadRequest => "คำร\u0e49องขอท\u0e35\u0e48ไม\u0e48ถ\u0e39กต\u0e49อง";

	/// <summary>
	/// Key: "Response.BadRequestDescription"
	/// error message detail for 400 error
	/// English String: "There was a problem with your request"
	/// </summary>
	public override string ResponseBadRequestDescription => "ม\u0e35ป\u0e31ญหาก\u0e31บคำร\u0e49องขอของค\u0e38ณ";

	/// <summary>
	/// Key: "Response.InternalServerError"
	/// 500 error message title
	/// English String: "Internal Server Error"
	/// </summary>
	public override string ResponseInternalServerError => "เก\u0e34ดข\u0e49อผ\u0e34ดพลาดภายในเซ\u0e34ร\u0e4cฟเวอร\u0e4c";

	/// <summary>
	/// Key: "Response.InternalServerErrorDescription"
	/// 500 error message description
	/// English String: "An unexpected error occurred"
	/// </summary>
	public override string ResponseInternalServerErrorDescription => "เก\u0e34ดข\u0e49อผ\u0e34ดพลาดท\u0e35\u0e48ไม\u0e48ทราบสาเหต\u0e38";

	/// <summary>
	/// Key: "Response.PageNotFound"
	/// 404 error message title
	/// English String: "Page Not found"
	/// </summary>
	public override string ResponsePageNotFound => "ไม\u0e48พบหน\u0e49าเพจ";

	/// <summary>
	/// Key: "Response.PageNotFoundDescrition"
	/// 404 error message description
	/// English String: "Page cannot be found or no longer exists"
	/// </summary>
	public override string ResponsePageNotFoundDescrition => "ไม\u0e48พบหน\u0e49าเพจหร\u0e37อไม\u0e48ม\u0e35หน\u0e49าเพจอย\u0e39\u0e48อ\u0e35กต\u0e48อไปแล\u0e49ว";

	/// <summary>
	/// Key: "Response.RequestError"
	/// error message for incorrect request
	/// English String: "Error with your request"
	/// </summary>
	public override string ResponseRequestError => "ข\u0e49อผ\u0e34ดพลาดก\u0e31บคำร\u0e49องขอของค\u0e38ณ";

	/// <summary>
	/// Key: "Response.SomethingWentWrong"
	/// default error message
	/// English String: "Something went wrong"
	/// </summary>
	public override string ResponseSomethingWentWrong => "ม\u0e35บางอย\u0e48างผ\u0e34ดปกต\u0e34";

	/// <summary>
	/// Key: "Response.TooManyAttemptsText"
	/// English String: "Too Many Attempts"
	/// </summary>
	public override string ResponseTooManyAttemptsText => "ม\u0e35การดำเน\u0e34นการซ\u0e49ำมากเก\u0e34นไป";

	/// <summary>
	/// Key: "Response.UnexpectedError"
	/// default error description
	/// English String: "An unexpected error occurred. Please try again later."
	/// </summary>
	public override string ResponseUnexpectedError => "เก\u0e34ดข\u0e49อผ\u0e34ดพลาดท\u0e35\u0e48ไม\u0e48ทราบสาเหต\u0e38 กร\u0e38ณาลองใหม\u0e48อ\u0e35กคร\u0e31\u0e49งในภายหล\u0e31ง";

	public MessagesResources_th_th(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionPreviousPage()
	{
		return "ไปย\u0e31งหน\u0e49าก\u0e48อนหน\u0e49า";
	}

	protected override string _GetTemplateForActionReturnHome()
	{
		return "กล\u0e31บไปหน\u0e49าหล\u0e31ก";
	}

	/// <summary>
	/// Key: "CookieLawNoticev2"
	/// Incorrect key, obsoleted
	/// English String: "Roblox uses cookies to personalize content, provide social media features and analyze the traffic on our site. To learn about how we use cookies and how you can {startLink}manage cookie preferences{endLink}, please refer to our {startLink2}Privacy and Cookie Policy{endLink2}."
	/// </summary>
	public override string CookieLawNoticev2(string startLink, string endLink, string startLink2, string endLink2)
	{
		return $"Roblox ใช\u0e49งานค\u0e38กก\u0e35\u0e49เพ\u0e37\u0e48อจ\u0e31ดเน\u0e37\u0e49อหาให\u0e49เป\u0e47นส\u0e48วนต\u0e31ว ให\u0e49ค\u0e38ณล\u0e31กษณะด\u0e49านโซเช\u0e35ยลม\u0e35เด\u0e35ย และว\u0e34เคราะห\u0e4cปร\u0e34มาณการเข\u0e49าใช\u0e49เว\u0e47บไซต\u0e4cของเรา ค\u0e38ณสามารถเร\u0e35ยนร\u0e39\u0e49เก\u0e35\u0e48ยวก\u0e31บการใช\u0e49งานค\u0e38กก\u0e35\u0e49ของเรารวมถ\u0e36งว\u0e34ธ\u0e35การท\u0e35\u0e48ค\u0e38ณสามารถ{startLink}ปร\u0e31บการต\u0e31\u0e49งค\u0e48าการใช\u0e49งานค\u0e38กก\u0e35\u0e49{endLink}ได\u0e49โดยการอ\u0e48านท\u0e35\u0e48{startLink2}นโยบายความเป\u0e47นส\u0e48วนต\u0e31วและการใช\u0e49ค\u0e38กก\u0e35\u0e49{endLink2}ของเรา";
	}

	protected override string _GetTemplateForCookieLawNoticev2()
	{
		return "Roblox ใช\u0e49งานค\u0e38กก\u0e35\u0e49เพ\u0e37\u0e48อจ\u0e31ดเน\u0e37\u0e49อหาให\u0e49เป\u0e47นส\u0e48วนต\u0e31ว ให\u0e49ค\u0e38ณล\u0e31กษณะด\u0e49านโซเช\u0e35ยลม\u0e35เด\u0e35ย และว\u0e34เคราะห\u0e4cปร\u0e34มาณการเข\u0e49าใช\u0e49เว\u0e47บไซต\u0e4cของเรา ค\u0e38ณสามารถเร\u0e35ยนร\u0e39\u0e49เก\u0e35\u0e48ยวก\u0e31บการใช\u0e49งานค\u0e38กก\u0e35\u0e49ของเรารวมถ\u0e36งว\u0e34ธ\u0e35การท\u0e35\u0e48ค\u0e38ณสามารถ{startLink}ปร\u0e31บการต\u0e31\u0e49งค\u0e48าการใช\u0e49งานค\u0e38กก\u0e35\u0e49{endLink}ได\u0e49โดยการอ\u0e48านท\u0e35\u0e48{startLink2}นโยบายความเป\u0e47นส\u0e48วนต\u0e31วและการใช\u0e49ค\u0e38กก\u0e35\u0e49{endLink2}ของเรา";
	}

	/// <summary>
	/// Key: "Description.ContactCustomerService"
	/// message shown on common error pages
	/// English String: "If you continue to receive this page, please contact customer service at {emailLink}"
	/// </summary>
	public override string DescriptionContactCustomerService(string emailLink)
	{
		return $"หากค\u0e38ณย\u0e31งพบก\u0e31บหน\u0e49าเพจน\u0e35\u0e49อย\u0e39\u0e48 กร\u0e38ณาต\u0e34ดต\u0e48อฝ\u0e48ายสน\u0e31บสน\u0e38นล\u0e39กค\u0e49าท\u0e35\u0e48 {emailLink}";
	}

	protected override string _GetTemplateForDescriptionContactCustomerService()
	{
		return "หากค\u0e38ณย\u0e31งพบก\u0e31บหน\u0e49าเพจน\u0e35\u0e49อย\u0e39\u0e48 กร\u0e38ณาต\u0e34ดต\u0e48อฝ\u0e48ายสน\u0e31บสน\u0e38นล\u0e39กค\u0e49าท\u0e35\u0e48 {emailLink}";
	}

	protected override string _GetTemplateForLabelError()
	{
		return "ข\u0e49อผ\u0e34ดพลาด";
	}

	protected override string _GetTemplateForLabelErrorImage()
	{
		return "ภาพข\u0e49อผ\u0e34ดพลาด";
	}

	protected override string _GetTemplateForLabelTooManyCharacters()
	{
		return "ม\u0e35อ\u0e31กขระมากเก\u0e34นไป!";
	}

	protected override string _GetTemplateForMessageAlwaysAllowed()
	{
		return "อน\u0e38ญาตเสมอ";
	}

	protected override string _GetTemplateForMessageAnalyiticsCookies()
	{
		return "ค\u0e38กก\u0e35\u0e49ว\u0e34เคราะห\u0e4c";
	}

	protected override string _GetTemplateForMessageAnalyiticsCookiesDescription()
	{
		return "ค\u0e38กก\u0e35\u0e49เหล\u0e48าน\u0e35\u0e49ถ\u0e39กใช\u0e49ในการปร\u0e31บปร\u0e38งประส\u0e34ทธ\u0e34ภาพของเว\u0e47บไซต\u0e4cหร\u0e37อการว\u0e34เคราะห\u0e4cการใช\u0e49งานเว\u0e47บไซต\u0e4c";
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
		return $"Roblox ใช\u0e49ค\u0e38กก\u0e35\u0e49เพ\u0e37\u0e48อการมอบประสบการณ\u0e4cท\u0e35\u0e48เหน\u0e37อกว\u0e48า สำหร\u0e31บข\u0e49อม\u0e39ลเพ\u0e34\u0e48มเต\u0e34ม รวมถ\u0e36งข\u0e49อม\u0e39ลว\u0e34ธ\u0e35การถอนความสม\u0e31ครใจ และว\u0e34ธ\u0e35การจ\u0e31ดการค\u0e38กก\u0e35\u0e49ของ Roblox กร\u0e38ณาอ\u0e49างอ\u0e34งถ\u0e36ง {startLink}นโยบายความเป\u0e47นส\u0e48วนต\u0e31วและการใช\u0e49ค\u0e38กก\u0e35\u0e49{endLink} ของเรา";
	}

	protected override string _GetTemplateForMessageCookieLawNotice()
	{
		return "Roblox ใช\u0e49ค\u0e38กก\u0e35\u0e49เพ\u0e37\u0e48อการมอบประสบการณ\u0e4cท\u0e35\u0e48เหน\u0e37อกว\u0e48า สำหร\u0e31บข\u0e49อม\u0e39ลเพ\u0e34\u0e48มเต\u0e34ม รวมถ\u0e36งข\u0e49อม\u0e39ลว\u0e34ธ\u0e35การถอนความสม\u0e31ครใจ และว\u0e34ธ\u0e35การจ\u0e31ดการค\u0e38กก\u0e35\u0e49ของ Roblox กร\u0e38ณาอ\u0e49างอ\u0e34งถ\u0e36ง {startLink}นโยบายความเป\u0e47นส\u0e48วนต\u0e31วและการใช\u0e49ค\u0e38กก\u0e35\u0e49{endLink} ของเรา";
	}

	/// <summary>
	/// Key: "Message.CookieLawNoticev2"
	/// English String: "Roblox uses cookies to personalize content, provide social media features and analyze the traffic on our site. To learn about how we use cookies and how you can {startLink}manage cookie preferences{endLink}, please refer to our {startLink2}Privacy and Cookie Policy{endLink2}."
	/// </summary>
	public override string MessageCookieLawNoticev2(string startLink, string endLink, string startLink2, string endLink2)
	{
		return $"Roblox ใช\u0e49งานค\u0e38กก\u0e35\u0e49เพ\u0e37\u0e48อจ\u0e31ดเน\u0e37\u0e49อหาให\u0e49เป\u0e47นส\u0e48วนต\u0e31ว ให\u0e49ค\u0e38ณล\u0e31กษณะด\u0e49านโซเช\u0e35ยลม\u0e35เด\u0e35ย และว\u0e34เคราะห\u0e4cปร\u0e34มาณการเข\u0e49าใช\u0e49เว\u0e47บไซต\u0e4cของเรา ค\u0e38ณสามารถเร\u0e35ยนร\u0e39\u0e49เก\u0e35\u0e48ยวก\u0e31บการใช\u0e49งานค\u0e38กก\u0e35\u0e49ของเรารวมถ\u0e36งว\u0e34ธ\u0e35การท\u0e35\u0e48ค\u0e38ณสามารถ{startLink}ปร\u0e31บการต\u0e31\u0e49งค\u0e48าการใช\u0e49งานค\u0e38กก\u0e35\u0e49{endLink}ได\u0e49โดยการอ\u0e48านท\u0e35\u0e48{startLink2}นโยบายความเป\u0e47นส\u0e48วนต\u0e31วและการใช\u0e49ค\u0e38กก\u0e35\u0e49{endLink2}ของเรา";
	}

	protected override string _GetTemplateForMessageCookieLawNoticev2()
	{
		return "Roblox ใช\u0e49งานค\u0e38กก\u0e35\u0e49เพ\u0e37\u0e48อจ\u0e31ดเน\u0e37\u0e49อหาให\u0e49เป\u0e47นส\u0e48วนต\u0e31ว ให\u0e49ค\u0e38ณล\u0e31กษณะด\u0e49านโซเช\u0e35ยลม\u0e35เด\u0e35ย และว\u0e34เคราะห\u0e4cปร\u0e34มาณการเข\u0e49าใช\u0e49เว\u0e47บไซต\u0e4cของเรา ค\u0e38ณสามารถเร\u0e35ยนร\u0e39\u0e49เก\u0e35\u0e48ยวก\u0e31บการใช\u0e49งานค\u0e38กก\u0e35\u0e49ของเรารวมถ\u0e36งว\u0e34ธ\u0e35การท\u0e35\u0e48ค\u0e38ณสามารถ{startLink}ปร\u0e31บการต\u0e31\u0e49งค\u0e48าการใช\u0e49งานค\u0e38กก\u0e35\u0e49{endLink}ได\u0e49โดยการอ\u0e48านท\u0e35\u0e48{startLink2}นโยบายความเป\u0e47นส\u0e48วนต\u0e31วและการใช\u0e49ค\u0e38กก\u0e35\u0e49{endLink2}ของเรา";
	}

	/// <summary>
	/// Key: "Message.CookieModalText"
	/// English String: "Please choose whether this site may use cookies as described below. You can learn more about how this site uses cookies and related technologies by reading our {startLink}privacy policy{endLink}."
	/// </summary>
	public override string MessageCookieModalText(string startLink, string endLink)
	{
		return $"กร\u0e38ณาเล\u0e37อกว\u0e48าเว\u0e47บไซต\u0e4cน\u0e35\u0e49สามารถใช\u0e49ค\u0e38กก\u0e35\u0e49ได\u0e49ตามท\u0e35\u0e48ระบ\u0e38ไว\u0e49ด\u0e49านล\u0e48างน\u0e35\u0e49หร\u0e37อไม\u0e48 ค\u0e38ณสามารถเร\u0e35ยนร\u0e39\u0e49ได\u0e49มากย\u0e34\u0e48งข\u0e36\u0e49นเก\u0e35\u0e48ยวก\u0e31บการใช\u0e49งานค\u0e38กก\u0e35\u0e49ของเว\u0e47บไซต\u0e4cน\u0e35\u0e49ได\u0e49โดยการอ\u0e48าน{startLink}นโยบายความเป\u0e47นส\u0e48วนต\u0e31ว{endLink}ของเรา";
	}

	protected override string _GetTemplateForMessageCookieModalText()
	{
		return "กร\u0e38ณาเล\u0e37อกว\u0e48าเว\u0e47บไซต\u0e4cน\u0e35\u0e49สามารถใช\u0e49ค\u0e38กก\u0e35\u0e49ได\u0e49ตามท\u0e35\u0e48ระบ\u0e38ไว\u0e49ด\u0e49านล\u0e48างน\u0e35\u0e49หร\u0e37อไม\u0e48 ค\u0e38ณสามารถเร\u0e35ยนร\u0e39\u0e49ได\u0e49มากย\u0e34\u0e48งข\u0e36\u0e49นเก\u0e35\u0e48ยวก\u0e31บการใช\u0e49งานค\u0e38กก\u0e35\u0e49ของเว\u0e47บไซต\u0e4cน\u0e35\u0e49ได\u0e49โดยการอ\u0e48าน{startLink}นโยบายความเป\u0e47นส\u0e48วนต\u0e31ว{endLink}ของเรา";
	}

	protected override string _GetTemplateForMessageEssentialCookies()
	{
		return "ค\u0e38กก\u0e35\u0e49ท\u0e35\u0e48สำค\u0e31ญ";
	}

	protected override string _GetTemplateForMessageEssentialCookiesDescription()
	{
		return "ค\u0e38กก\u0e35\u0e49เหล\u0e48าน\u0e35\u0e49เป\u0e47นส\u0e34\u0e48งท\u0e35\u0e48จำเป\u0e47นสำหร\u0e31บการทำงานของเว\u0e47บไซต\u0e4cน\u0e35\u0e49 อย\u0e48างเช\u0e48นการตรวจสอบต\u0e31วตนของผ\u0e39\u0e49ใช\u0e49 การร\u0e31กษาความปลอดภ\u0e31ยของระบบ หร\u0e37อการบ\u0e31นท\u0e36กต\u0e31วเล\u0e37อกการใช\u0e49งานค\u0e38กก\u0e35\u0e49";
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
		return "จ\u0e31ดการค\u0e38กก\u0e35\u0e49";
	}

	protected override string _GetTemplateForMessageEssentialCookiesItem3()
	{
		return "Gigya";
	}

	protected override string _GetTemplateForResponseAccessDenied()
	{
		return "การเข\u0e49าถ\u0e36งถ\u0e39กปฏ\u0e34เสธ";
	}

	protected override string _GetTemplateForResponseAccessDeniedDescription()
	{
		return "ค\u0e38ณไม\u0e48ม\u0e35ส\u0e34ทธ\u0e34ด\u0e39หน\u0e49าเพจน\u0e35\u0e49";
	}

	protected override string _GetTemplateForResponseBadRequest()
	{
		return "คำร\u0e49องขอท\u0e35\u0e48ไม\u0e48ถ\u0e39กต\u0e49อง";
	}

	protected override string _GetTemplateForResponseBadRequestDescription()
	{
		return "ม\u0e35ป\u0e31ญหาก\u0e31บคำร\u0e49องขอของค\u0e38ณ";
	}

	protected override string _GetTemplateForResponseInternalServerError()
	{
		return "เก\u0e34ดข\u0e49อผ\u0e34ดพลาดภายในเซ\u0e34ร\u0e4cฟเวอร\u0e4c";
	}

	protected override string _GetTemplateForResponseInternalServerErrorDescription()
	{
		return "เก\u0e34ดข\u0e49อผ\u0e34ดพลาดท\u0e35\u0e48ไม\u0e48ทราบสาเหต\u0e38";
	}

	protected override string _GetTemplateForResponsePageNotFound()
	{
		return "ไม\u0e48พบหน\u0e49าเพจ";
	}

	protected override string _GetTemplateForResponsePageNotFoundDescrition()
	{
		return "ไม\u0e48พบหน\u0e49าเพจหร\u0e37อไม\u0e48ม\u0e35หน\u0e49าเพจอย\u0e39\u0e48อ\u0e35กต\u0e48อไปแล\u0e49ว";
	}

	protected override string _GetTemplateForResponseRequestError()
	{
		return "ข\u0e49อผ\u0e34ดพลาดก\u0e31บคำร\u0e49องขอของค\u0e38ณ";
	}

	protected override string _GetTemplateForResponseSomethingWentWrong()
	{
		return "ม\u0e35บางอย\u0e48างผ\u0e34ดปกต\u0e34";
	}

	protected override string _GetTemplateForResponseTooManyAttemptsText()
	{
		return "ม\u0e35การดำเน\u0e34นการซ\u0e49ำมากเก\u0e34นไป";
	}

	protected override string _GetTemplateForResponseUnexpectedError()
	{
		return "เก\u0e34ดข\u0e49อผ\u0e34ดพลาดท\u0e35\u0e48ไม\u0e48ทราบสาเหต\u0e38 กร\u0e38ณาลองใหม\u0e48อ\u0e35กคร\u0e31\u0e49งในภายหล\u0e31ง";
	}
}
