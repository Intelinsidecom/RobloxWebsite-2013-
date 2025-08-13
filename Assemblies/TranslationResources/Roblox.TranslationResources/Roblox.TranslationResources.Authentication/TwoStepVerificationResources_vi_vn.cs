namespace Roblox.TranslationResources.Authentication;

/// <summary>
/// This class overrides TwoStepVerificationResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class TwoStepVerificationResources_vi_vn : TwoStepVerificationResources_en_us, ITwoStepVerificationResources, ITranslationResources
{
	/// <summary>
	/// Key: "Action.Cancel"
	/// English String: "Cancel"
	/// </summary>
	public override string ActionCancel => "Hủy";

	/// <summary>
	/// Key: "Action.Resend"
	/// English String: "Resend Code"
	/// </summary>
	public override string ActionResend => "Gửi lại mã";

	/// <summary>
	/// Key: "Action.StartOver"
	/// link text to restart verification
	/// English String: "Start Over"
	/// </summary>
	public override string ActionStartOver => "Bắt đầu lại";

	/// <summary>
	/// Key: "Action.Submit"
	/// submit button text
	/// English String: "Submit"
	/// </summary>
	public override string ActionSubmit => "Gửi";

	/// <summary>
	/// Key: "Action.Verify"
	/// English String: "Verify"
	/// </summary>
	public override string ActionVerify => "Xác minh";

	/// <summary>
	/// Key: "Label.Code"
	/// verification code for 2 factor authentication
	/// English String: "Code"
	/// </summary>
	public override string LabelCode => "Mã";

	/// <summary>
	/// Key: "Label.DidNotReceive"
	/// English String: "Didn't receive the code?"
	/// </summary>
	public override string LabelDidNotReceive => "Bạn không nhận được mã?";

	/// <summary>
	/// Key: "Label.EnterCode"
	/// English String: "Enter Code (6-digit)"
	/// </summary>
	public override string LabelEnterCode => "Nhập mã (6 chữ số)";

	/// <summary>
	/// Key: "Label.EnterEmailCode"
	/// English String: "Enter the code we just sent you via email"
	/// </summary>
	public override string LabelEnterEmailCode => "Nhập mã chúng tôi vừa gửi cho bạn qua email";

	/// <summary>
	/// Key: "Label.EnterTextCode"
	/// English String: "Enter the code we just sent you via text message"
	/// </summary>
	public override string LabelEnterTextCode => "Nhập mã chúng tôi vừa gửi cho bạn qua tin nhắn văn bản";

	/// <summary>
	/// Key: "Label.EnterTwoStepVerificationCode"
	/// Enter your two step verification code.
	/// English String: "Enter your two step verification code."
	/// </summary>
	public override string LabelEnterTwoStepVerificationCode => "Nhập mã xác minh hai bước của bạn.";

	/// <summary>
	/// Key: "Label.FacebookPasswordWarning"
	/// If you have been signing in with Facebook, you must set a password.
	/// English String: "If you have been signing in with Facebook, you must set a password."
	/// </summary>
	public override string LabelFacebookPasswordWarning => "Nếu bạn đã đăng nhập bằng Facebook, bạn phải đặt một mật khẩu.";

	/// <summary>
	/// Key: "Label.LearnMore"
	/// Learn More link text
	/// English String: "Learn More"
	/// </summary>
	public override string LabelLearnMore => "Tìm hiểu thêm";

	/// <summary>
	/// Key: "Label.NewCode"
	/// verification code resent, label changes to new code
	/// English String: "New Code"
	/// </summary>
	public override string LabelNewCode => "Mã mới";

	/// <summary>
	/// Key: "Label.RobloxSupport"
	/// English String: "Roblox Support"
	/// </summary>
	public override string LabelRobloxSupport => "Hỗ trợ của Roblox";

	/// <summary>
	/// Key: "Label.TrustThisDevice"
	/// English String: "Trust this device for 30 days"
	/// </summary>
	public override string LabelTrustThisDevice => "Tin tưởng thiết bị này trong vòng 30 ngày";

	/// <summary>
	/// Key: "Label.TwoStepVerification"
	/// English String: "2-Step Verification"
	/// </summary>
	public override string LabelTwoStepVerification => "Xác minh 2 bước";

	/// <summary>
	/// Key: "Response.CodeSent"
	/// English String: "Code Sent"
	/// </summary>
	public override string ResponseCodeSent => "Đã gửi mã";

	/// <summary>
	/// Key: "Response.FeatureNotAvailable"
	/// English String: "Feature not available. Please contact support."
	/// </summary>
	public override string ResponseFeatureNotAvailable => "Tính năng không khả dụng. Vui lòng liên hệ hỗ trợ.";

	/// <summary>
	/// Key: "Response.InvalidCode"
	/// English String: "Invalid code."
	/// </summary>
	public override string ResponseInvalidCode => "Mã không hợp lệ.";

	/// <summary>
	/// Key: "Response.SystemErrorReturnToLogin"
	/// English String: "System error. Please return to login screen."
	/// </summary>
	public override string ResponseSystemErrorReturnToLogin => "Lỗi hệ thống. Vui lòng quay lại màn hình đăng nhập.";

	/// <summary>
	/// Key: "Response.TooManyAttempts"
	/// English String: "Too many attempts. Please try again later."
	/// </summary>
	public override string ResponseTooManyAttempts => "Quá nhiều lần thử. Vui lòng thử lại sau.";

	/// <summary>
	/// Key: "Response.TooManyCharacters"
	/// error message
	/// English String: "Too many characters"
	/// </summary>
	public override string ResponseTooManyCharacters => "Quá nhiều ký tự";

	public TwoStepVerificationResources_vi_vn(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionCancel()
	{
		return "Hủy";
	}

	protected override string _GetTemplateForActionResend()
	{
		return "Gửi lại mã";
	}

	protected override string _GetTemplateForActionStartOver()
	{
		return "Bắt đầu lại";
	}

	protected override string _GetTemplateForActionSubmit()
	{
		return "Gửi";
	}

	protected override string _GetTemplateForActionVerify()
	{
		return "Xác minh";
	}

	/// <summary>
	/// Key: "Description.TwoStepVerificationActivationEmail.Body.Over13"
	/// Body for 2SV activation email for over 13 users
	/// English String: "Hi {accountName},{lineBreak}{lineBreak}You have activated 2-Step Verification for your Roblox account. Next time you log in from a new device, you will need to enter a 6-digit security code that Roblox sends to you via email.{lineBreak}{lineBreak}Roblox"
	/// </summary>
	public override string DescriptionTwoStepVerificationActivationEmailBodyOver13(string accountName, string lineBreak)
	{
		return $"Chào {accountName},{lineBreak}{lineBreak}Bạn đã kích hoạt Xác minh 2 bước cho tài khoản Roblox của mình. Lần tới, khi đăng nhập từ thiết bị mới, bạn sẽ cần nhập mã bảo mật 6 chữ số được Roblox gửi cho bạn qua email.{lineBreak}{lineBreak}Roblox";
	}

	protected override string _GetTemplateForDescriptionTwoStepVerificationActivationEmailBodyOver13()
	{
		return "Chào {accountName},{lineBreak}{lineBreak}Bạn đã kích hoạt Xác minh 2 bước cho tài khoản Roblox của mình. Lần tới, khi đăng nhập từ thiết bị mới, bạn sẽ cần nhập mã bảo mật 6 chữ số được Roblox gửi cho bạn qua email.{lineBreak}{lineBreak}Roblox";
	}

	/// <summary>
	/// Key: "Description.TwoStepVerificationActivationEmail.Body.Under13"
	/// Body for 2SV activation email for under 13 users
	/// English String: "Hi,{lineBreak}{lineBreak}2-Step Verification has been activated for your child's Roblox account, {accountName}. Next time they log in from a new device, they will need to enter a 6-digit security code that Roblox sends to you via email.{lineBreak}{lineBreak}Roblox"
	/// </summary>
	public override string DescriptionTwoStepVerificationActivationEmailBodyUnder13(string lineBreak, string accountName)
	{
		return $"Chào bạn,{lineBreak}{lineBreak}Xác minh 2 bước đã được kích hoạt cho tài khoản Roblox của con bạn, {accountName}. Lần tới, khi đăng nhập từ thiết bị mới, con bạn sẽ cần nhập mã bảo mật 6 chữ số được Roblox gửi cho bạn qua email.{lineBreak}{lineBreak}Roblox";
	}

	protected override string _GetTemplateForDescriptionTwoStepVerificationActivationEmailBodyUnder13()
	{
		return "Chào bạn,{lineBreak}{lineBreak}Xác minh 2 bước đã được kích hoạt cho tài khoản Roblox của con bạn, {accountName}. Lần tới, khi đăng nhập từ thiết bị mới, con bạn sẽ cần nhập mã bảo mật 6 chữ số được Roblox gửi cho bạn qua email.{lineBreak}{lineBreak}Roblox";
	}

	/// <summary>
	/// Key: "Description.TwoStepVerificationActivationEmail.Subject"
	/// Subject for 2SV activation email
	/// English String: "2-Step Verification Activated for Roblox Account: {accountName}"
	/// </summary>
	public override string DescriptionTwoStepVerificationActivationEmailSubject(string accountName)
	{
		return $"Xác minh 2 bước đã được kích hoạt cho Tài khoản Roblox: {accountName}";
	}

	protected override string _GetTemplateForDescriptionTwoStepVerificationActivationEmailSubject()
	{
		return "Xác minh 2 bước đã được kích hoạt cho Tài khoản Roblox: {accountName}";
	}

	/// <summary>
	/// Key: "Description.TwoStepVerificationDeactivationEmail.Body.Over13"
	/// Body for 2SV deactivation email for over 13 users
	/// English String: "Hi {accountName},{lineBreak}{lineBreak}You have deactivated 2-Step Verification for your Roblox account. A security code will no longer be required when you log into your account.{lineBreak}{lineBreak}Roblox"
	/// </summary>
	public override string DescriptionTwoStepVerificationDeactivationEmailBodyOver13(string accountName, string lineBreak)
	{
		return $"Chào {accountName},{lineBreak}{lineBreak}Bạn đã hủy kích hoạt Xác minh 2 bước cho tài khoản Roblox của mình. Khi đăng nhập vào tài khoản, bạn sẽ không còn cần mã bảo mật.{lineBreak}{lineBreak}Roblox";
	}

	protected override string _GetTemplateForDescriptionTwoStepVerificationDeactivationEmailBodyOver13()
	{
		return "Chào {accountName},{lineBreak}{lineBreak}Bạn đã hủy kích hoạt Xác minh 2 bước cho tài khoản Roblox của mình. Khi đăng nhập vào tài khoản, bạn sẽ không còn cần mã bảo mật.{lineBreak}{lineBreak}Roblox";
	}

	/// <summary>
	/// Key: "Description.TwoStepVerificationDeactivationEmail.Body.Under13"
	/// Body for 2SV deactivation email for under 13 users
	/// English String: "Hi,{lineBreak}{lineBreak}2-Step Verification has been deactivated for your child's Roblox account, {accountName}. A security code will no longer be required when they log into the account.{lineBreak}{lineBreak}Roblox"
	/// </summary>
	public override string DescriptionTwoStepVerificationDeactivationEmailBodyUnder13(string lineBreak, string accountName)
	{
		return $"Chào bạn,{lineBreak}{lineBreak}Xác minh 2 bước đã được hủy kích hoạt cho tài khoản Roblox của con bạn, {accountName}. Khi đăng nhập vào tài khoản, con bạn sẽ không còn cần mã bảo mật.{lineBreak}{lineBreak}Roblox";
	}

	protected override string _GetTemplateForDescriptionTwoStepVerificationDeactivationEmailBodyUnder13()
	{
		return "Chào bạn,{lineBreak}{lineBreak}Xác minh 2 bước đã được hủy kích hoạt cho tài khoản Roblox của con bạn, {accountName}. Khi đăng nhập vào tài khoản, con bạn sẽ không còn cần mã bảo mật.{lineBreak}{lineBreak}Roblox";
	}

	/// <summary>
	/// Key: "Description.TwoStepVerificationDeactivationEmail.Subject	"
	/// Subject for 2SV deactivation email
	/// English String: "2-Step Verification Deactivated for Roblox Account: {accountName}"
	/// </summary>
	public override string DescriptionTwoStepVerificationDeactivationEmailSubject(string accountName)
	{
		return $"Xác minh 2 bước đã được hủy kích hoạt cho Tài khoản Roblox: {accountName}";
	}

	protected override string _GetTemplateForDescriptionTwoStepVerificationDeactivationEmailSubject()
	{
		return "Xác minh 2 bước đã được hủy kích hoạt cho Tài khoản Roblox: {accountName}";
	}

	/// <summary>
	/// Key: "Description.TwoStepVerificationLoginEmail.Html.GeolocationInfo1"
	/// Geolocation information about IP trying to login
	/// English String: "{spanStartTagWithBold}Login request received from {username} located in {region}, {country} ({ipAddress}).{spanEndTag}{lineBreak}{lineBreak}"
	/// </summary>
	public override string DescriptionTwoStepVerificationLoginEmailHtmlGeolocationInfo1(string spanStartTagWithBold, string username, string region, string country, string ipAddress, string spanEndTag, string lineBreak)
	{
		return $"{spanStartTagWithBold}Yêu cầu đăng nhập được nhận từ {username} tại {region}, {country} ({ipAddress}).{spanEndTag}{lineBreak}{lineBreak}";
	}

	protected override string _GetTemplateForDescriptionTwoStepVerificationLoginEmailHtmlGeolocationInfo1()
	{
		return "{spanStartTagWithBold}Yêu cầu đăng nhập được nhận từ {username} tại {region}, {country} ({ipAddress}).{spanEndTag}{lineBreak}{lineBreak}";
	}

	/// <summary>
	/// Key: "Description.TwoStepVerificationLoginEmail.Html.GeolocationInfo2"
	/// Geolocation info about IP trying to login
	/// English String: "{spanStartTagWithBold}Login request received from {username} located in {country} ({ipAddress}).{spanEndTag}{lineBreak}{lineBreak}\t"
	/// </summary>
	public override string DescriptionTwoStepVerificationLoginEmailHtmlGeolocationInfo2(string spanStartTagWithBold, string username, string country, string ipAddress, string spanEndTag, string lineBreak)
	{
		return $"{spanStartTagWithBold}Yêu cầu đăng nhập được nhận từ {username} tại {country} ({ipAddress}).{spanEndTag}{lineBreak}{lineBreak}\t";
	}

	protected override string _GetTemplateForDescriptionTwoStepVerificationLoginEmailHtmlGeolocationInfo2()
	{
		return "{spanStartTagWithBold}Yêu cầu đăng nhập được nhận từ {username} tại {country} ({ipAddress}).{spanEndTag}{lineBreak}{lineBreak}\t";
	}

	/// <summary>
	/// Key: "Description.TwoStepVerificationLoginEmail.Html.GeolocationInfo3"
	/// Geolocation info about IP trying to log in
	/// English String: "{spanStartTagWithBold}Login request received from {username} (From Roblox Internal).{spanEndTag}{lineBreak}{lineBreak}\t"
	/// </summary>
	public override string DescriptionTwoStepVerificationLoginEmailHtmlGeolocationInfo3(string spanStartTagWithBold, string username, string spanEndTag, string lineBreak)
	{
		return $"{spanStartTagWithBold}Yêu cầu đăng nhập được nhận từ {username} (Thuộc Nội bộ Roblox).{spanEndTag}{lineBreak}{lineBreak}\t";
	}

	protected override string _GetTemplateForDescriptionTwoStepVerificationLoginEmailHtmlGeolocationInfo3()
	{
		return "{spanStartTagWithBold}Yêu cầu đăng nhập được nhận từ {username} (Thuộc Nội bộ Roblox).{spanEndTag}{lineBreak}{lineBreak}\t";
	}

	/// <summary>
	/// Key: "Description.TwoStepVerificationLoginEmail.Html.GeolocationInfo4"
	/// Geolocation info of IP trying to login
	/// English String: "{spanStartTagWithBold}Login request received from {username} located in {country}.{spanEndTag}{lineBreak}{lineBreak}"
	/// </summary>
	public override string DescriptionTwoStepVerificationLoginEmailHtmlGeolocationInfo4(string spanStartTagWithBold, string username, string country, string spanEndTag, string lineBreak)
	{
		return $"{spanStartTagWithBold}Yêu cầu đăng nhập được nhận từ {username} tại {country}.{spanEndTag}{lineBreak}{lineBreak}";
	}

	protected override string _GetTemplateForDescriptionTwoStepVerificationLoginEmailHtmlGeolocationInfo4()
	{
		return "{spanStartTagWithBold}Yêu cầu đăng nhập được nhận từ {username} tại {country}.{spanEndTag}{lineBreak}{lineBreak}";
	}

	/// <summary>
	/// Key: "Description.TwoStepVerificationLoginEmail.Html.GeolocationInfo5"
	/// Geolocation info of IP trying to login
	/// English String: "{spanStartTagWithBold}Login request received from {username} located in {region}, {country}.{spanEndTag}{lineBreak}{lineBreak}"
	/// </summary>
	public override string DescriptionTwoStepVerificationLoginEmailHtmlGeolocationInfo5(string spanStartTagWithBold, string username, string region, string country, string spanEndTag, string lineBreak)
	{
		return $"{spanStartTagWithBold}Yêu cầu đăng nhập được nhận từ {username} tại {region}, {country}.{spanEndTag}{lineBreak}{lineBreak}";
	}

	protected override string _GetTemplateForDescriptionTwoStepVerificationLoginEmailHtmlGeolocationInfo5()
	{
		return "{spanStartTagWithBold}Yêu cầu đăng nhập được nhận từ {username} tại {region}, {country}.{spanEndTag}{lineBreak}{lineBreak}";
	}

	/// <summary>
	/// Key: "Description.TwoStepVerificationLoginEmail.Html.GeolocationInfo6"
	/// Geolocation info of IP trying to login
	/// English String: "{spanStartTagWithBold}Login request received from {username} located in {city}, {region}, {country}.{spanEndTag}{lineBreak}{lineBreak}"
	/// </summary>
	public override string DescriptionTwoStepVerificationLoginEmailHtmlGeolocationInfo6(string spanStartTagWithBold, string username, string city, string region, string country, string spanEndTag, string lineBreak)
	{
		return $"{spanStartTagWithBold}Yêu cầu đăng nhập được nhận từ {username} tại {city}, {region}, {country}.{spanEndTag}{lineBreak}{lineBreak}";
	}

	protected override string _GetTemplateForDescriptionTwoStepVerificationLoginEmailHtmlGeolocationInfo6()
	{
		return "{spanStartTagWithBold}Yêu cầu đăng nhập được nhận từ {username} tại {city}, {region}, {country}.{spanEndTag}{lineBreak}{lineBreak}";
	}

	/// <summary>
	/// Key: "Description.TwoStepVerificationLoginEmail.HtmlBody"
	/// Html body for 2SV login email
	/// English String: "{geoLocationInformation}{spanStartTagWithBold}Login code for {accountName}: {lineBreak}{lineBreak}{code} {spanEndTag}{lineBreak}{lineBreak}Enter this code into the 2-Step Verification screen to finish logging in. This code will expire in 15 minutes.{lineBreak}{lineBreak}This email was sent because your account tried to login to Roblox from a new browser or device. If you haven't tried logging into Roblox, someone else may be trying to access your account. You are strongly advised to change your password if you did not generate this request.{lineBreak}{lineBreak}Resources:{lineBreak}{aTagStartWithHref}{ChangePasswordLink}{hrefEnd}Change Your Password{aTagEnd} {lineBreak}{aTagStartWithHref}{TwoStepVerificationArticleLink}{hrefEnd}Learn More About 2-Step Verification{aTagEnd} {lineBreak}{aTagStartWithHref}{AccountSafetyArticleLink}{hrefEnd}Keeping Your Account Safe{aTagEnd} {lineBreak}{aTagStartWithHref}{SupportLink}{hrefEnd}General Roblox Support{aTagEnd} {lineBreak}{lineBreak}Thank you,{lineBreak}{lineBreak}The Roblox Team"
	/// </summary>
	public override string DescriptionTwoStepVerificationLoginEmailHtmlBody(string geoLocationInformation, string spanStartTagWithBold, string accountName, string lineBreak, string code, string spanEndTag, string aTagStartWithHref, string ChangePasswordLink, string hrefEnd, string aTagEnd, string TwoStepVerificationArticleLink, string AccountSafetyArticleLink, string SupportLink)
	{
		return $"{geoLocationInformation}{spanStartTagWithBold}Mã đăng nhập cho {accountName}: {lineBreak}{lineBreak}{code} {spanEndTag}{lineBreak}{lineBreak}Nhập mã này vào màn hình Xác minh 2 bước để hoàn tất đăng nhập. Mã này sẽ hết hạn sau 15 phút.{lineBreak}{lineBreak}Bạn nhận được email này bởi vì tài khoản của bạn đã cố đăng nhập vào Roblox từ trình duyệt hoặc thiết bị mới. Nếu bạn không cố đăng nhập vào Roblox thì người khác có thể đang cố truy cập tài khoản của bạn. Chúng tôi đặc biệt khuyến cáo bạn thay đổi mật khẩu nếu bạn không tạo yêu cầu này.{lineBreak}{lineBreak}Tài nguyên:{lineBreak}{aTagStartWithHref}{ChangePasswordLink}{hrefEnd}Đổi mật khẩu của bạn{aTagEnd} {lineBreak}{aTagStartWithHref}{TwoStepVerificationArticleLink}{hrefEnd}Tìm hiểu thêm về Xác minh 2 bước{aTagEnd} {lineBreak}{aTagStartWithHref}{AccountSafetyArticleLink}{hrefEnd}Giữ an toàn cho tài khoản của bạn{aTagEnd} {lineBreak}{aTagStartWithHref}{SupportLink}{hrefEnd}Hỗ trợ chung của Roblox{aTagEnd} {lineBreak}{lineBreak}Cảm ơn bạn,{lineBreak}{lineBreak}Đội ngũ Roblox";
	}

	protected override string _GetTemplateForDescriptionTwoStepVerificationLoginEmailHtmlBody()
	{
		return "{geoLocationInformation}{spanStartTagWithBold}Mã đăng nhập cho {accountName}: {lineBreak}{lineBreak}{code} {spanEndTag}{lineBreak}{lineBreak}Nhập mã này vào màn hình Xác minh 2 bước để hoàn tất đăng nhập. Mã này sẽ hết hạn sau 15 phút.{lineBreak}{lineBreak}Bạn nhận được email này bởi vì tài khoản của bạn đã cố đăng nhập vào Roblox từ trình duyệt hoặc thiết bị mới. Nếu bạn không cố đăng nhập vào Roblox thì người khác có thể đang cố truy cập tài khoản của bạn. Chúng tôi đặc biệt khuyến cáo bạn thay đổi mật khẩu nếu bạn không tạo yêu cầu này.{lineBreak}{lineBreak}Tài nguyên:{lineBreak}{aTagStartWithHref}{ChangePasswordLink}{hrefEnd}Đổi mật khẩu của bạn{aTagEnd} {lineBreak}{aTagStartWithHref}{TwoStepVerificationArticleLink}{hrefEnd}Tìm hiểu thêm về Xác minh 2 bước{aTagEnd} {lineBreak}{aTagStartWithHref}{AccountSafetyArticleLink}{hrefEnd}Giữ an toàn cho tài khoản của bạn{aTagEnd} {lineBreak}{aTagStartWithHref}{SupportLink}{hrefEnd}Hỗ trợ chung của Roblox{aTagEnd} {lineBreak}{lineBreak}Cảm ơn bạn,{lineBreak}{lineBreak}Đội ngũ Roblox";
	}

	/// <summary>
	/// Key: "Description.TwoStepVerificationLoginEmail.PlainBody"
	/// Plain body for 2SV login email
	/// English String: "{geoLocationInformation}Login code for {accountName}: {lineBreak}{lineBreak} {code} {lineBreak}{lineBreak}Enter this code into the 2-Step Verification screen to finish logging in. This code will expire in 15 minutes. {lineBreak}{lineBreak}This email was sent because your account tried to login to Roblox from a new browser or device. If you haven't tried logging into Roblox, someone else may be trying to access your account. You are strongly advised to change your password if you did not generate this request. {lineBreak}{lineBreak}Resources: {lineBreak}Change Your Password [{accountInfoPageLink}] {lineBreak}Learn More About 2-Step Verification [{twoStepVerificationHelpArticleLink}]{lineBreak}Keeping Your Account Safe [{keepAccountSafeArticleLink}] {lineBreak}General Roblox Support [{supportPageLink}] {lineBreak}{lineBreak}Thank you, {lineBreak}{lineBreak}The Roblox Team"
	/// </summary>
	public override string DescriptionTwoStepVerificationLoginEmailPlainBody(string geoLocationInformation, string accountName, string lineBreak, string code, string accountInfoPageLink, string twoStepVerificationHelpArticleLink, string keepAccountSafeArticleLink, string supportPageLink)
	{
		return $"{geoLocationInformation}Mã đăng nhập cho {accountName}: {lineBreak}{lineBreak} {code} {lineBreak}{lineBreak}Nhập mã này vào màn hình Xác minh 2 bước để hoàn tất đăng nhập. Mã này sẽ hết hạn sau 15 phút. {lineBreak}{lineBreak}Bạn nhận được email này bởi vì tài khoản của bạn đã cố đăng nhập vào Roblox từ trình duyệt hoặc thiết bị mới. Nếu bạn không cố đăng nhập vào Roblox thì người khác có thể đang cố truy cập tài khoản của bạn. Chúng tôi đặc biệt khuyến cáo bạn thay đổi mật khẩu nếu bạn không tạo yêu cầu này. {lineBreak}{lineBreak}Tài nguyên: {lineBreak}Đổi mật khẩu của bạn [{accountInfoPageLink}] {lineBreak}Tìm hiểu thêm về Xác minh 2 bước [{twoStepVerificationHelpArticleLink}]{lineBreak}Giữ an toàn cho tài khoản của bạn [{keepAccountSafeArticleLink}] {lineBreak}Hỗ trợ chung của Roblox [{supportPageLink}] {lineBreak}{lineBreak}Cảm ơn bạn, {lineBreak}{lineBreak}Đội ngũ Roblox";
	}

	protected override string _GetTemplateForDescriptionTwoStepVerificationLoginEmailPlainBody()
	{
		return "{geoLocationInformation}Mã đăng nhập cho {accountName}: {lineBreak}{lineBreak} {code} {lineBreak}{lineBreak}Nhập mã này vào màn hình Xác minh 2 bước để hoàn tất đăng nhập. Mã này sẽ hết hạn sau 15 phút. {lineBreak}{lineBreak}Bạn nhận được email này bởi vì tài khoản của bạn đã cố đăng nhập vào Roblox từ trình duyệt hoặc thiết bị mới. Nếu bạn không cố đăng nhập vào Roblox thì người khác có thể đang cố truy cập tài khoản của bạn. Chúng tôi đặc biệt khuyến cáo bạn thay đổi mật khẩu nếu bạn không tạo yêu cầu này. {lineBreak}{lineBreak}Tài nguyên: {lineBreak}Đổi mật khẩu của bạn [{accountInfoPageLink}] {lineBreak}Tìm hiểu thêm về Xác minh 2 bước [{twoStepVerificationHelpArticleLink}]{lineBreak}Giữ an toàn cho tài khoản của bạn [{keepAccountSafeArticleLink}] {lineBreak}Hỗ trợ chung của Roblox [{supportPageLink}] {lineBreak}{lineBreak}Cảm ơn bạn, {lineBreak}{lineBreak}Đội ngũ Roblox";
	}

	/// <summary>
	/// Key: "Description.TwoStepVerificationLoginEmail.PlainText.GeolocationInfo1"
	/// GeoLocation info of IP trying to login
	/// English String: "Login request received from {username} located in {region}, {country} ({ipAddress}).{lineBreak}{lineBreak}"
	/// </summary>
	public override string DescriptionTwoStepVerificationLoginEmailPlainTextGeolocationInfo1(string username, string region, string country, string ipAddress, string lineBreak)
	{
		return $"Yêu cầu đăng nhập được nhận từ {username} tại {region}, {country} ({ipAddress}).{lineBreak}{lineBreak}";
	}

	protected override string _GetTemplateForDescriptionTwoStepVerificationLoginEmailPlainTextGeolocationInfo1()
	{
		return "Yêu cầu đăng nhập được nhận từ {username} tại {region}, {country} ({ipAddress}).{lineBreak}{lineBreak}";
	}

	/// <summary>
	/// Key: "Description.TwoStepVerificationLoginEmail.PlainText.GeolocationInfo2"
	/// Geolocation info of IP trying to login
	/// English String: "Login request received from {username} located in {country} ({ipAddress}).{lineBreak}{lineBreak}"
	/// </summary>
	public override string DescriptionTwoStepVerificationLoginEmailPlainTextGeolocationInfo2(string username, string country, string ipAddress, string lineBreak)
	{
		return $"Yêu cầu đăng nhập được nhận từ {username} tại {country} ({ipAddress}).{lineBreak}{lineBreak}";
	}

	protected override string _GetTemplateForDescriptionTwoStepVerificationLoginEmailPlainTextGeolocationInfo2()
	{
		return "Yêu cầu đăng nhập được nhận từ {username} tại {country} ({ipAddress}).{lineBreak}{lineBreak}";
	}

	/// <summary>
	/// Key: "Description.TwoStepVerificationLoginEmail.PlainText.GeolocationInfo3"
	/// Geolocation info of IP trying to login
	/// English String: "Login request received from {username} (From Roblox Internal).{lineBreak}{lineBreak}"
	/// </summary>
	public override string DescriptionTwoStepVerificationLoginEmailPlainTextGeolocationInfo3(string username, string lineBreak)
	{
		return $"Yêu cầu đăng nhập được nhận từ {username} (Thuộc Nội bộ Roblox).{lineBreak}{lineBreak}";
	}

	protected override string _GetTemplateForDescriptionTwoStepVerificationLoginEmailPlainTextGeolocationInfo3()
	{
		return "Yêu cầu đăng nhập được nhận từ {username} (Thuộc Nội bộ Roblox).{lineBreak}{lineBreak}";
	}

	/// <summary>
	/// Key: "Description.TwoStepVerificationLoginEmail.PlainText.GeolocationInfo4"
	/// Geolocation info of IP trying to login
	/// English String: "Login request received from {username} located in {country}.{lineBreak}{lineBreak}"
	/// </summary>
	public override string DescriptionTwoStepVerificationLoginEmailPlainTextGeolocationInfo4(string username, string country, string lineBreak)
	{
		return $"Yêu cầu đăng nhập được nhận từ {username} tại {country}.{lineBreak}{lineBreak}";
	}

	protected override string _GetTemplateForDescriptionTwoStepVerificationLoginEmailPlainTextGeolocationInfo4()
	{
		return "Yêu cầu đăng nhập được nhận từ {username} tại {country}.{lineBreak}{lineBreak}";
	}

	/// <summary>
	/// Key: "Description.TwoStepVerificationLoginEmail.PlainText.GeolocationInfo5"
	/// Geolocation info of IP trying to login
	/// English String: "Login request received from {username} located in {region}, {country}.{lineBreak}{lineBreak}"
	/// </summary>
	public override string DescriptionTwoStepVerificationLoginEmailPlainTextGeolocationInfo5(string username, string region, string country, string lineBreak)
	{
		return $"Yêu cầu đăng nhập được nhận từ {username} tại {region}, {country}.{lineBreak}{lineBreak}";
	}

	protected override string _GetTemplateForDescriptionTwoStepVerificationLoginEmailPlainTextGeolocationInfo5()
	{
		return "Yêu cầu đăng nhập được nhận từ {username} tại {region}, {country}.{lineBreak}{lineBreak}";
	}

	/// <summary>
	/// Key: "Description.TwoStepVerificationLoginEmail.PlainText.GeolocationInfo6"
	/// Geolocation info of IP trying to login
	/// English String: "Login request received from {username} located in {city}, {region}, {country}.{lineBreak}{lineBreak}"
	/// </summary>
	public override string DescriptionTwoStepVerificationLoginEmailPlainTextGeolocationInfo6(string username, string city, string region, string country, string lineBreak)
	{
		return $"Yêu cầu đăng nhập được nhận từ {username} tại {city}, {region}, {country}.{lineBreak}{lineBreak}";
	}

	protected override string _GetTemplateForDescriptionTwoStepVerificationLoginEmailPlainTextGeolocationInfo6()
	{
		return "Yêu cầu đăng nhập được nhận từ {username} tại {city}, {region}, {country}.{lineBreak}{lineBreak}";
	}

	/// <summary>
	/// Key: "Description.TwoStepVerificationLoginEmail.Subject"
	/// Subject for 2SV login email
	/// English String: "Verification Code for Roblox Account: {accountName}"
	/// </summary>
	public override string DescriptionTwoStepVerificationLoginEmailSubject(string accountName)
	{
		return $"Mã xác minh cho Tài khoản Roblox: {accountName}";
	}

	protected override string _GetTemplateForDescriptionTwoStepVerificationLoginEmailSubject()
	{
		return "Mã xác minh cho Tài khoản Roblox: {accountName}";
	}

	protected override string _GetTemplateForLabelCode()
	{
		return "Mã";
	}

	/// <summary>
	/// Key: "Label.CodeInputPlaceholderText"
	/// example: Enter 4-digit code
	/// English String: "Enter {codeLength}-digit Code"
	/// </summary>
	public override string LabelCodeInputPlaceholderText(string codeLength)
	{
		return $"Nhập mã {codeLength} chữ số";
	}

	protected override string _GetTemplateForLabelCodeInputPlaceholderText()
	{
		return "Nhập mã {codeLength} chữ số";
	}

	protected override string _GetTemplateForLabelDidNotReceive()
	{
		return "Bạn không nhận được mã?";
	}

	protected override string _GetTemplateForLabelEnterCode()
	{
		return "Nhập mã (6 chữ số)";
	}

	protected override string _GetTemplateForLabelEnterEmailCode()
	{
		return "Nhập mã chúng tôi vừa gửi cho bạn qua email";
	}

	protected override string _GetTemplateForLabelEnterTextCode()
	{
		return "Nhập mã chúng tôi vừa gửi cho bạn qua tin nhắn văn bản";
	}

	protected override string _GetTemplateForLabelEnterTwoStepVerificationCode()
	{
		return "Nhập mã xác minh hai bước của bạn.";
	}

	protected override string _GetTemplateForLabelFacebookPasswordWarning()
	{
		return "Nếu bạn đã đăng nhập bằng Facebook, bạn phải đặt một mật khẩu.";
	}

	protected override string _GetTemplateForLabelLearnMore()
	{
		return "Tìm hiểu thêm";
	}

	/// <summary>
	/// Key: "Label.NeedHelpContactSupport"
	/// label for the support article link
	/// English String: "Need help? Contact {supportLink}"
	/// </summary>
	public override string LabelNeedHelpContactSupport(string supportLink)
	{
		return $"Bạn cần trợ giúp? Hãy liên hệ {supportLink}";
	}

	protected override string _GetTemplateForLabelNeedHelpContactSupport()
	{
		return "Bạn cần trợ giúp? Hãy liên hệ {supportLink}";
	}

	protected override string _GetTemplateForLabelNewCode()
	{
		return "Mã mới";
	}

	protected override string _GetTemplateForLabelRobloxSupport()
	{
		return "Hỗ trợ của Roblox";
	}

	protected override string _GetTemplateForLabelTrustThisDevice()
	{
		return "Tin tưởng thiết bị này trong vòng 30 ngày";
	}

	protected override string _GetTemplateForLabelTwoStepVerification()
	{
		return "Xác minh 2 bước";
	}

	protected override string _GetTemplateForResponseCodeSent()
	{
		return "Đã gửi mã";
	}

	protected override string _GetTemplateForResponseFeatureNotAvailable()
	{
		return "Tính năng không khả dụng. Vui lòng liên hệ hỗ trợ.";
	}

	protected override string _GetTemplateForResponseInvalidCode()
	{
		return "Mã không hợp lệ.";
	}

	protected override string _GetTemplateForResponseSystemErrorReturnToLogin()
	{
		return "Lỗi hệ thống. Vui lòng quay lại màn hình đăng nhập.";
	}

	protected override string _GetTemplateForResponseTooManyAttempts()
	{
		return "Quá nhiều lần thử. Vui lòng thử lại sau.";
	}

	protected override string _GetTemplateForResponseTooManyCharacters()
	{
		return "Quá nhiều ký tự";
	}
}
