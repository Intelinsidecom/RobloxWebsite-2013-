namespace Roblox.TranslationResources.CommonUI;

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
	public override string ActionPreviousPage => "이전 페이지로 이동";

	/// <summary>
	/// Key: "Action.ReturnHome"
	/// button title
	/// English String: "Return Home"
	/// </summary>
	public override string ActionReturnHome => "홈으로 돌아가기";

	/// <summary>
	/// Key: "Label.Error"
	/// English String: "Error"
	/// </summary>
	public override string LabelError => "오류";

	/// <summary>
	/// Key: "Label.ErrorImage"
	/// alternate text shown for error image
	/// English String: "Error Image"
	/// </summary>
	public override string LabelErrorImage => "오류 이미지";

	/// <summary>
	/// Key: "Label.TooManyCharacters"
	/// English String: "Too many characters!"
	/// </summary>
	public override string LabelTooManyCharacters => "글자 수가 너무 많아요!";

	/// <summary>
	/// Key: "Message.AlwaysAllowed"
	/// English String: "Always allowed"
	/// </summary>
	public override string MessageAlwaysAllowed => "항상 허용";

	/// <summary>
	/// Key: "Message.AnalyiticsCookies"
	/// English String: "Analytics Cookies"
	/// </summary>
	public override string MessageAnalyiticsCookies => "분석 쿠키";

	/// <summary>
	/// Key: "Message.AnalyiticsCookiesDescription"
	/// English String: "These cookies used for improving site performance or understanding site usage."
	/// </summary>
	public override string MessageAnalyiticsCookiesDescription => "본 쿠키는 사이트 성능을 개선하거나 사이트 사용 정보를 파악하는 데 이용됩니다.";

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
	public override string MessageEssentialCookies => "필수 쿠키";

	/// <summary>
	/// Key: "Message.EssentialCookiesDescription"
	/// English String: "These cookies are required to provide the functionality on the site, such as for user authentication, securing the system or saving cookie preferences."
	/// </summary>
	public override string MessageEssentialCookiesDescription => "쿠키는 사용자 인증, 시스템 보안 또는 쿠키 환경 설정 저장 등의 기능을 사이트에 제공하기 위해 필요합니다.";

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
	public override string MessageManageCookies => "쿠키 관리";

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
	public override string ResponseAccessDenied => "접근 거부됨";

	/// <summary>
	/// Key: "Response.AccessDeniedDescription"
	/// 403 error message detail
	/// English String: "You don't have permission to view this page"
	/// </summary>
	public override string ResponseAccessDeniedDescription => "이 페이지를 볼 수 있는 권한이 없습니다";

	/// <summary>
	/// Key: "Response.BadRequest"
	/// 400 error message title
	/// English String: "Bad Request"
	/// </summary>
	public override string ResponseBadRequest => "요청 실패";

	/// <summary>
	/// Key: "Response.BadRequestDescription"
	/// error message detail for 400 error
	/// English String: "There was a problem with your request"
	/// </summary>
	public override string ResponseBadRequestDescription => "요청에 오류가 있습니다";

	/// <summary>
	/// Key: "Response.InternalServerError"
	/// 500 error message title
	/// English String: "Internal Server Error"
	/// </summary>
	public override string ResponseInternalServerError => "내부 서버 오류";

	/// <summary>
	/// Key: "Response.InternalServerErrorDescription"
	/// 500 error message description
	/// English String: "An unexpected error occurred"
	/// </summary>
	public override string ResponseInternalServerErrorDescription => "예기치 못한 오류 발생";

	/// <summary>
	/// Key: "Response.PageNotFound"
	/// 404 error message title
	/// English String: "Page Not found"
	/// </summary>
	public override string ResponsePageNotFound => "페이지를 찾을 수 없음";

	/// <summary>
	/// Key: "Response.PageNotFoundDescrition"
	/// 404 error message description
	/// English String: "Page cannot be found or no longer exists"
	/// </summary>
	public override string ResponsePageNotFoundDescrition => "페이지를 찾을 수 없거나 존재하지 않습니다";

	/// <summary>
	/// Key: "Response.RequestError"
	/// error message for incorrect request
	/// English String: "Error with your request"
	/// </summary>
	public override string ResponseRequestError => "요청 관련 오류";

	/// <summary>
	/// Key: "Response.SomethingWentWrong"
	/// default error message
	/// English String: "Something went wrong"
	/// </summary>
	public override string ResponseSomethingWentWrong => "오류가 발생했어요";

	/// <summary>
	/// Key: "Response.TooManyAttemptsText"
	/// English String: "Too Many Attempts"
	/// </summary>
	public override string ResponseTooManyAttemptsText => "시도 가능 횟수를 초과했습니다";

	/// <summary>
	/// Key: "Response.UnexpectedError"
	/// default error description
	/// English String: "An unexpected error occurred. Please try again later."
	/// </summary>
	public override string ResponseUnexpectedError => "예기치 못한 오류가 발생했어요. 나중에 다시 시도하세요.";

	public MessagesResources_ko_kr(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionPreviousPage()
	{
		return "이전 페이지로 이동";
	}

	protected override string _GetTemplateForActionReturnHome()
	{
		return "홈으로 돌아가기";
	}

	/// <summary>
	/// Key: "CookieLawNoticev2"
	/// Incorrect key, obsoleted
	/// English String: "Roblox uses cookies to personalize content, provide social media features and analyze the traffic on our site. To learn about how we use cookies and how you can {startLink}manage cookie preferences{endLink}, please refer to our {startLink2}Privacy and Cookie Policy{endLink2}."
	/// </summary>
	public override string CookieLawNoticev2(string startLink, string endLink, string startLink2, string endLink2)
	{
		return $"Roblox는 맞춤형 콘텐츠, 소셜 미디어 기능 제공 및 사이트 트래픽을 분석을 위해 쿠키를 사용합니다. Roblox의 쿠키 사용 방법 및 {startLink}쿠키 환경설정 관리{endLink} 방법에 대한 상세 정보는 {startLink2}개인정보 및 쿠키 정책{endLink2}을 참고하세요.";
	}

	protected override string _GetTemplateForCookieLawNoticev2()
	{
		return "Roblox는 맞춤형 콘텐츠, 소셜 미디어 기능 제공 및 사이트 트래픽을 분석을 위해 쿠키를 사용합니다. Roblox의 쿠키 사용 방법 및 {startLink}쿠키 환경설정 관리{endLink} 방법에 대한 상세 정보는 {startLink2}개인정보 및 쿠키 정책{endLink2}을 참고하세요.";
	}

	/// <summary>
	/// Key: "Description.ContactCustomerService"
	/// message shown on common error pages
	/// English String: "If you continue to receive this page, please contact customer service at {emailLink}"
	/// </summary>
	public override string DescriptionContactCustomerService(string emailLink)
	{
		return $"이 페이지가 계속해서 나타나는 경우 {emailLink}을(를) 통해 문의하세요";
	}

	protected override string _GetTemplateForDescriptionContactCustomerService()
	{
		return "이 페이지가 계속해서 나타나는 경우 {emailLink}을(를) 통해 문의하세요";
	}

	protected override string _GetTemplateForLabelError()
	{
		return "오류";
	}

	protected override string _GetTemplateForLabelErrorImage()
	{
		return "오류 이미지";
	}

	protected override string _GetTemplateForLabelTooManyCharacters()
	{
		return "글자 수가 너무 많아요!";
	}

	protected override string _GetTemplateForMessageAlwaysAllowed()
	{
		return "항상 허용";
	}

	protected override string _GetTemplateForMessageAnalyiticsCookies()
	{
		return "분석 쿠키";
	}

	protected override string _GetTemplateForMessageAnalyiticsCookiesDescription()
	{
		return "본 쿠키는 사이트 성능을 개선하거나 사이트 사용 정보를 파악하는 데 이용됩니다.";
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
		return $"Roblox는 더 나은 환경을 제공하기 위해 쿠키를 사용합니다. Roblox에서의 쿠키 사용 동의 취소 방법 및 쿠키 사용 관리 방법에 대한 자세한 정보는 {startLink}개인정보 및 쿠키 정책{endLink}을 확인하세요.";
	}

	protected override string _GetTemplateForMessageCookieLawNotice()
	{
		return "Roblox는 더 나은 환경을 제공하기 위해 쿠키를 사용합니다. Roblox에서의 쿠키 사용 동의 취소 방법 및 쿠키 사용 관리 방법에 대한 자세한 정보는 {startLink}개인정보 및 쿠키 정책{endLink}을 확인하세요.";
	}

	/// <summary>
	/// Key: "Message.CookieLawNoticev2"
	/// English String: "Roblox uses cookies to personalize content, provide social media features and analyze the traffic on our site. To learn about how we use cookies and how you can {startLink}manage cookie preferences{endLink}, please refer to our {startLink2}Privacy and Cookie Policy{endLink2}."
	/// </summary>
	public override string MessageCookieLawNoticev2(string startLink, string endLink, string startLink2, string endLink2)
	{
		return $"Roblox는 맞춤형 콘텐츠, 소셜 미디어 기능 제공 및 사이트 트래픽 분석을 위해 쿠키를 사용합니다. Roblox의 쿠키 사용 방법 및 {startLink}쿠키 환경설정 관리{endLink} 방법에 대한 상세 정보는 {startLink2}개인정보 및 쿠키 정책{endLink2}을 참고하세요.";
	}

	protected override string _GetTemplateForMessageCookieLawNoticev2()
	{
		return "Roblox는 맞춤형 콘텐츠, 소셜 미디어 기능 제공 및 사이트 트래픽 분석을 위해 쿠키를 사용합니다. Roblox의 쿠키 사용 방법 및 {startLink}쿠키 환경설정 관리{endLink} 방법에 대한 상세 정보는 {startLink2}개인정보 및 쿠키 정책{endLink2}을 참고하세요.";
	}

	/// <summary>
	/// Key: "Message.CookieModalText"
	/// English String: "Please choose whether this site may use cookies as described below. You can learn more about how this site uses cookies and related technologies by reading our {startLink}privacy policy{endLink}."
	/// </summary>
	public override string MessageCookieModalText(string startLink, string endLink)
	{
		return $"아래 설명에 따른 본 사이트의 쿠키 사용 여부를 선택하세요. 본 사이트의 쿠키 사용 방법과 관련 기술에 대한 상세 정보는 {startLink}개인정보 처리방침{endLink}을 참고하세요.";
	}

	protected override string _GetTemplateForMessageCookieModalText()
	{
		return "아래 설명에 따른 본 사이트의 쿠키 사용 여부를 선택하세요. 본 사이트의 쿠키 사용 방법과 관련 기술에 대한 상세 정보는 {startLink}개인정보 처리방침{endLink}을 참고하세요.";
	}

	protected override string _GetTemplateForMessageEssentialCookies()
	{
		return "필수 쿠키";
	}

	protected override string _GetTemplateForMessageEssentialCookiesDescription()
	{
		return "쿠키는 사용자 인증, 시스템 보안 또는 쿠키 환경 설정 저장 등의 기능을 사이트에 제공하기 위해 필요합니다.";
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
		return "쿠키 관리";
	}

	protected override string _GetTemplateForMessageEssentialCookiesItem3()
	{
		return "Gigya";
	}

	protected override string _GetTemplateForResponseAccessDenied()
	{
		return "접근 거부됨";
	}

	protected override string _GetTemplateForResponseAccessDeniedDescription()
	{
		return "이 페이지를 볼 수 있는 권한이 없습니다";
	}

	protected override string _GetTemplateForResponseBadRequest()
	{
		return "요청 실패";
	}

	protected override string _GetTemplateForResponseBadRequestDescription()
	{
		return "요청에 오류가 있습니다";
	}

	protected override string _GetTemplateForResponseInternalServerError()
	{
		return "내부 서버 오류";
	}

	protected override string _GetTemplateForResponseInternalServerErrorDescription()
	{
		return "예기치 못한 오류 발생";
	}

	protected override string _GetTemplateForResponsePageNotFound()
	{
		return "페이지를 찾을 수 없음";
	}

	protected override string _GetTemplateForResponsePageNotFoundDescrition()
	{
		return "페이지를 찾을 수 없거나 존재하지 않습니다";
	}

	protected override string _GetTemplateForResponseRequestError()
	{
		return "요청 관련 오류";
	}

	protected override string _GetTemplateForResponseSomethingWentWrong()
	{
		return "오류가 발생했어요";
	}

	protected override string _GetTemplateForResponseTooManyAttemptsText()
	{
		return "시도 가능 횟수를 초과했습니다";
	}

	protected override string _GetTemplateForResponseUnexpectedError()
	{
		return "예기치 못한 오류가 발생했어요. 나중에 다시 시도하세요.";
	}
}
