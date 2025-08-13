namespace Roblox.TranslationResources.CommonUI;

/// <summary>
/// This class overrides MessagesResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class MessagesResources_vi_vn : MessagesResources_en_us, IMessagesResources, ITranslationResources
{
	/// <summary>
	/// Key: "Action.PreviousPage"
	/// button title
	/// English String: "Go to the Previous Page"
	/// </summary>
	public override string ActionPreviousPage => "Trở lại trang trước";

	/// <summary>
	/// Key: "Action.ReturnHome"
	/// button title
	/// English String: "Return Home"
	/// </summary>
	public override string ActionReturnHome => "Trở lại Trang chủ";

	/// <summary>
	/// Key: "Label.Error"
	/// English String: "Error"
	/// </summary>
	public override string LabelError => "Lỗi";

	/// <summary>
	/// Key: "Label.ErrorImage"
	/// alternate text shown for error image
	/// English String: "Error Image"
	/// </summary>
	public override string LabelErrorImage => "Ảnh lỗi";

	/// <summary>
	/// Key: "Label.TooManyCharacters"
	/// English String: "Too many characters!"
	/// </summary>
	public override string LabelTooManyCharacters => "Quá nhiều ký tự!";

	/// <summary>
	/// Key: "Message.AlwaysAllowed"
	/// English String: "Always allowed"
	/// </summary>
	public override string MessageAlwaysAllowed => "Luôn cho phép";

	/// <summary>
	/// Key: "Message.AnalyiticsCookies"
	/// English String: "Analytics Cookies"
	/// </summary>
	public override string MessageAnalyiticsCookies => "Cookie Phân tích";

	/// <summary>
	/// Key: "Message.AnalyiticsCookiesDescription"
	/// English String: "These cookies used for improving site performance or understanding site usage."
	/// </summary>
	public override string MessageAnalyiticsCookiesDescription => "Đây là những cookie được sử dụng để cải tiến hiệu năng của trang web hoặc để hiểu cách người dùng sử dụng trang web.";

	/// <summary>
	/// Key: "Message.AnalyiticsCookiesItem1"
	/// English String: "Google Analytics"
	/// </summary>
	public override string MessageAnalyiticsCookiesItem1 => "Công cụ Analytics của Google";

	/// <summary>
	/// Key: "Message.AnalyiticsCookiesItem2"
	/// English String: "Google Universal Analytics"
	/// </summary>
	public override string MessageAnalyiticsCookiesItem2 => "Công cụ Universal Analytics của Google";

	/// <summary>
	/// Key: "Message.EssentialCookies"
	/// English String: "Essential Cookies"
	/// </summary>
	public override string MessageEssentialCookies => "Cookie cần thiết";

	/// <summary>
	/// Key: "Message.EssentialCookiesDescription"
	/// English String: "These cookies are required to provide the functionality on the site, such as for user authentication, securing the system or saving cookie preferences."
	/// </summary>
	public override string MessageEssentialCookiesDescription => "Đây là những cookie cần thiết để cung cấp chức năng trên trang web như xác thực người dùng, bảo đảm an ninh cho hệ thống hoặc lưu các tùy chọn cookie.";

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
	public override string MessageManageCookies => "Quản lý cookie";

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
	public override string ResponseAccessDenied => "Truy cập bị từ chối";

	/// <summary>
	/// Key: "Response.AccessDeniedDescription"
	/// 403 error message detail
	/// English String: "You don't have permission to view this page"
	/// </summary>
	public override string ResponseAccessDeniedDescription => "Bạn không có quyền xem trang này";

	/// <summary>
	/// Key: "Response.BadRequest"
	/// 400 error message title
	/// English String: "Bad Request"
	/// </summary>
	public override string ResponseBadRequest => "Yêu cầu không hợp lệ";

	/// <summary>
	/// Key: "Response.BadRequestDescription"
	/// error message detail for 400 error
	/// English String: "There was a problem with your request"
	/// </summary>
	public override string ResponseBadRequestDescription => "Đã xảy ra sự cố với yêu cầu của bạn";

	/// <summary>
	/// Key: "Response.InternalServerError"
	/// 500 error message title
	/// English String: "Internal Server Error"
	/// </summary>
	public override string ResponseInternalServerError => "Lỗi bên trong máy chủ";

	/// <summary>
	/// Key: "Response.InternalServerErrorDescription"
	/// 500 error message description
	/// English String: "An unexpected error occurred"
	/// </summary>
	public override string ResponseInternalServerErrorDescription => "Đã xảy ra lỗi đột xuất";

	/// <summary>
	/// Key: "Response.PageNotFound"
	/// 404 error message title
	/// English String: "Page Not found"
	/// </summary>
	public override string ResponsePageNotFound => "Không tìm thấy trang";

	/// <summary>
	/// Key: "Response.PageNotFoundDescrition"
	/// 404 error message description
	/// English String: "Page cannot be found or no longer exists"
	/// </summary>
	public override string ResponsePageNotFoundDescrition => "Không tìm thấy trang hoặc trang không còn tồn tại";

	/// <summary>
	/// Key: "Response.RequestError"
	/// error message for incorrect request
	/// English String: "Error with your request"
	/// </summary>
	public override string ResponseRequestError => "Đã xảy ra lỗi với yêu cầu của bạn";

	/// <summary>
	/// Key: "Response.SomethingWentWrong"
	/// default error message
	/// English String: "Something went wrong"
	/// </summary>
	public override string ResponseSomethingWentWrong => "Đã xảy ra sự cố";

	/// <summary>
	/// Key: "Response.TooManyAttemptsText"
	/// English String: "Too Many Attempts"
	/// </summary>
	public override string ResponseTooManyAttemptsText => "Quá nhiều lần thử";

	/// <summary>
	/// Key: "Response.UnexpectedError"
	/// default error description
	/// English String: "An unexpected error occurred. Please try again later."
	/// </summary>
	public override string ResponseUnexpectedError => "Đã xảy ra lỗi đột xuất. Vui lòng thử lại sau.";

	public MessagesResources_vi_vn(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionPreviousPage()
	{
		return "Trở lại trang trước";
	}

	protected override string _GetTemplateForActionReturnHome()
	{
		return "Trở lại Trang chủ";
	}

	/// <summary>
	/// Key: "CookieLawNoticev2"
	/// Incorrect key, obsoleted
	/// English String: "Roblox uses cookies to personalize content, provide social media features and analyze the traffic on our site. To learn about how we use cookies and how you can {startLink}manage cookie preferences{endLink}, please refer to our {startLink2}Privacy and Cookie Policy{endLink2}."
	/// </summary>
	public override string CookieLawNoticev2(string startLink, string endLink, string startLink2, string endLink2)
	{
		return $"Roblox sử dụng cookie để cá nhân hóa nội dung, cung cấp các tính năng mạng xã hội và phân tích lưu lượng truy cập trên trang web của chúng tôi. Để tìm hiểu về cách chúng tôi sử dụng cookie và cách bạn có thể {startLink}quản lý tùy chọn cookie{endLink}, vui lòng tham khảo {startLink2}Chính sách Quyền riêng tư và Cookie{endLink2} của chúng tôi.";
	}

	protected override string _GetTemplateForCookieLawNoticev2()
	{
		return "Roblox sử dụng cookie để cá nhân hóa nội dung, cung cấp các tính năng mạng xã hội và phân tích lưu lượng truy cập trên trang web của chúng tôi. Để tìm hiểu về cách chúng tôi sử dụng cookie và cách bạn có thể {startLink}quản lý tùy chọn cookie{endLink}, vui lòng tham khảo {startLink2}Chính sách Quyền riêng tư và Cookie{endLink2} của chúng tôi.";
	}

	/// <summary>
	/// Key: "Description.ContactCustomerService"
	/// message shown on common error pages
	/// English String: "If you continue to receive this page, please contact customer service at {emailLink}"
	/// </summary>
	public override string DescriptionContactCustomerService(string emailLink)
	{
		return $"Nếu bạn tiếp tục nhận được trang này, vui lòng liên hệ với bộ phận chăm sóc khách hàng theo {emailLink}";
	}

	protected override string _GetTemplateForDescriptionContactCustomerService()
	{
		return "Nếu bạn tiếp tục nhận được trang này, vui lòng liên hệ với bộ phận chăm sóc khách hàng theo {emailLink}";
	}

	protected override string _GetTemplateForLabelError()
	{
		return "Lỗi";
	}

	protected override string _GetTemplateForLabelErrorImage()
	{
		return "Ảnh lỗi";
	}

	protected override string _GetTemplateForLabelTooManyCharacters()
	{
		return "Quá nhiều ký tự!";
	}

	protected override string _GetTemplateForMessageAlwaysAllowed()
	{
		return "Luôn cho phép";
	}

	protected override string _GetTemplateForMessageAnalyiticsCookies()
	{
		return "Cookie Phân tích";
	}

	protected override string _GetTemplateForMessageAnalyiticsCookiesDescription()
	{
		return "Đây là những cookie được sử dụng để cải tiến hiệu năng của trang web hoặc để hiểu cách người dùng sử dụng trang web.";
	}

	protected override string _GetTemplateForMessageAnalyiticsCookiesItem1()
	{
		return "Công cụ Analytics của Google";
	}

	protected override string _GetTemplateForMessageAnalyiticsCookiesItem2()
	{
		return "Công cụ Universal Analytics của Google";
	}

	/// <summary>
	/// Key: "Message.CookieLawNotice"
	/// Cookies are used for Internet-based data storage, and this message warns users that we use them to improve their experience. See https://en.wikipedia.org/wiki/HTTP_cookie for more information.
	/// English String: "Roblox uses cookies to offer you a better experience. For further information, including information on how to withdraw consent and how to manage the use of cookies on Roblox, please refer to our {startLink}Privacy and Cookie Policy{endLink}."
	/// </summary>
	public override string MessageCookieLawNotice(string startLink, string endLink)
	{
		return $"Roblox sử dụng cookie để mang đến cho bạn trải nghiệm tốt hơn. Để biết thêm thông tin, bao gồm thông tin về cách thu hồi đồng ý và cách quản lý việc sử dụng cookie trên Roblox, vui lòng tham khảo {startLink}Chính sách riêng tư và Chính sách cookie{endLink} của chúng tôi.";
	}

	protected override string _GetTemplateForMessageCookieLawNotice()
	{
		return "Roblox sử dụng cookie để mang đến cho bạn trải nghiệm tốt hơn. Để biết thêm thông tin, bao gồm thông tin về cách thu hồi đồng ý và cách quản lý việc sử dụng cookie trên Roblox, vui lòng tham khảo {startLink}Chính sách riêng tư và Chính sách cookie{endLink} của chúng tôi.";
	}

	/// <summary>
	/// Key: "Message.CookieLawNoticev2"
	/// English String: "Roblox uses cookies to personalize content, provide social media features and analyze the traffic on our site. To learn about how we use cookies and how you can {startLink}manage cookie preferences{endLink}, please refer to our {startLink2}Privacy and Cookie Policy{endLink2}."
	/// </summary>
	public override string MessageCookieLawNoticev2(string startLink, string endLink, string startLink2, string endLink2)
	{
		return $"Roblox sử dụng cookie để cá nhân hóa nội dung, cung cấp các tính năng mạng xã hội và phân tích lưu lượng truy cập trên trang web của chúng tôi. Để tìm hiểu về cách chúng tôi sử dụng cookie và cách bạn có thể {startLink}quản lý tùy chọn cookie{endLink}, vui lòng tham khảo {startLink2}Chính sách Quyền riêng tư và Cookie{endLink2} của chúng tôi.";
	}

	protected override string _GetTemplateForMessageCookieLawNoticev2()
	{
		return "Roblox sử dụng cookie để cá nhân hóa nội dung, cung cấp các tính năng mạng xã hội và phân tích lưu lượng truy cập trên trang web của chúng tôi. Để tìm hiểu về cách chúng tôi sử dụng cookie và cách bạn có thể {startLink}quản lý tùy chọn cookie{endLink}, vui lòng tham khảo {startLink2}Chính sách Quyền riêng tư và Cookie{endLink2} của chúng tôi.";
	}

	/// <summary>
	/// Key: "Message.CookieModalText"
	/// English String: "Please choose whether this site may use cookies as described below. You can learn more about how this site uses cookies and related technologies by reading our {startLink}privacy policy{endLink}."
	/// </summary>
	public override string MessageCookieModalText(string startLink, string endLink)
	{
		return $"Vui lòng chọn cho phép trang này sử dụng cookie hay không theo mô tả bên dưới. Bạn có thể tìm hiểu thêm về cách thức trang này sử dụng cookie và các công nghệ liên quan bằng cách đọc {startLink}chính sách quyền riêng tư{endLink} của chúng tôi.";
	}

	protected override string _GetTemplateForMessageCookieModalText()
	{
		return "Vui lòng chọn cho phép trang này sử dụng cookie hay không theo mô tả bên dưới. Bạn có thể tìm hiểu thêm về cách thức trang này sử dụng cookie và các công nghệ liên quan bằng cách đọc {startLink}chính sách quyền riêng tư{endLink} của chúng tôi.";
	}

	protected override string _GetTemplateForMessageEssentialCookies()
	{
		return "Cookie cần thiết";
	}

	protected override string _GetTemplateForMessageEssentialCookiesDescription()
	{
		return "Đây là những cookie cần thiết để cung cấp chức năng trên trang web như xác thực người dùng, bảo đảm an ninh cho hệ thống hoặc lưu các tùy chọn cookie.";
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
		return "Quản lý cookie";
	}

	protected override string _GetTemplateForMessageEssentialCookiesItem3()
	{
		return "Gigya";
	}

	protected override string _GetTemplateForResponseAccessDenied()
	{
		return "Truy cập bị từ chối";
	}

	protected override string _GetTemplateForResponseAccessDeniedDescription()
	{
		return "Bạn không có quyền xem trang này";
	}

	protected override string _GetTemplateForResponseBadRequest()
	{
		return "Yêu cầu không hợp lệ";
	}

	protected override string _GetTemplateForResponseBadRequestDescription()
	{
		return "Đã xảy ra sự cố với yêu cầu của bạn";
	}

	protected override string _GetTemplateForResponseInternalServerError()
	{
		return "Lỗi bên trong máy chủ";
	}

	protected override string _GetTemplateForResponseInternalServerErrorDescription()
	{
		return "Đã xảy ra lỗi đột xuất";
	}

	protected override string _GetTemplateForResponsePageNotFound()
	{
		return "Không tìm thấy trang";
	}

	protected override string _GetTemplateForResponsePageNotFoundDescrition()
	{
		return "Không tìm thấy trang hoặc trang không còn tồn tại";
	}

	protected override string _GetTemplateForResponseRequestError()
	{
		return "Đã xảy ra lỗi với yêu cầu của bạn";
	}

	protected override string _GetTemplateForResponseSomethingWentWrong()
	{
		return "Đã xảy ra sự cố";
	}

	protected override string _GetTemplateForResponseTooManyAttemptsText()
	{
		return "Quá nhiều lần thử";
	}

	protected override string _GetTemplateForResponseUnexpectedError()
	{
		return "Đã xảy ra lỗi đột xuất. Vui lòng thử lại sau.";
	}
}
