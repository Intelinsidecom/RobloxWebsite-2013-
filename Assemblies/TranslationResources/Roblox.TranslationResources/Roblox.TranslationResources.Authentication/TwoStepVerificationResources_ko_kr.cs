namespace Roblox.TranslationResources.Authentication;

/// <summary>
/// This class overrides TwoStepVerificationResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class TwoStepVerificationResources_ko_kr : TwoStepVerificationResources_en_us, ITwoStepVerificationResources, ITranslationResources
{
	/// <summary>
	/// Key: "Action.Cancel"
	/// English String: "Cancel"
	/// </summary>
	public override string ActionCancel => "취소";

	/// <summary>
	/// Key: "Action.Resend"
	/// English String: "Resend Code"
	/// </summary>
	public override string ActionResend => "코드 재전송";

	/// <summary>
	/// Key: "Action.StartOver"
	/// link text to restart verification
	/// English String: "Start Over"
	/// </summary>
	public override string ActionStartOver => "시작하기";

	/// <summary>
	/// Key: "Action.Submit"
	/// submit button text
	/// English String: "Submit"
	/// </summary>
	public override string ActionSubmit => "입력";

	/// <summary>
	/// Key: "Action.Verify"
	/// English String: "Verify"
	/// </summary>
	public override string ActionVerify => "확인";

	/// <summary>
	/// Key: "Label.Code"
	/// verification code for 2 factor authentication
	/// English String: "Code"
	/// </summary>
	public override string LabelCode => "코드";

	/// <summary>
	/// Key: "Label.DidNotReceive"
	/// English String: "Didn't receive the code?"
	/// </summary>
	public override string LabelDidNotReceive => "코드를 받지 못하셨나요?";

	/// <summary>
	/// Key: "Label.EnterCode"
	/// English String: "Enter Code (6-digit)"
	/// </summary>
	public override string LabelEnterCode => "코드 입력 (6자리)";

	/// <summary>
	/// Key: "Label.EnterEmailCode"
	/// English String: "Enter the code we just sent you via email"
	/// </summary>
	public override string LabelEnterEmailCode => "방금 이메일로 전송된 코드를 입력하세요.";

	/// <summary>
	/// Key: "Label.EnterTextCode"
	/// English String: "Enter the code we just sent you via text message"
	/// </summary>
	public override string LabelEnterTextCode => "방금 문자 메시지로 전송된 코드를 입력하세요.";

	/// <summary>
	/// Key: "Label.EnterTwoStepVerificationCode"
	/// Enter your two step verification code.
	/// English String: "Enter your two step verification code."
	/// </summary>
	public override string LabelEnterTwoStepVerificationCode => "2단계 인증 코드를 입력하세요.";

	/// <summary>
	/// Key: "Label.FacebookPasswordWarning"
	/// If you have been signing in with Facebook, you must set a password.
	/// English String: "If you have been signing in with Facebook, you must set a password."
	/// </summary>
	public override string LabelFacebookPasswordWarning => "Facebook으로 로그인한 경우, 비밀번호를 설정해야 합니다.";

	/// <summary>
	/// Key: "Label.LearnMore"
	/// Learn More link text
	/// English String: "Learn More"
	/// </summary>
	public override string LabelLearnMore => "더 알아보기";

	/// <summary>
	/// Key: "Label.NewCode"
	/// verification code resent, label changes to new code
	/// English String: "New Code"
	/// </summary>
	public override string LabelNewCode => "새 코드";

	/// <summary>
	/// Key: "Label.RobloxSupport"
	/// English String: "Roblox Support"
	/// </summary>
	public override string LabelRobloxSupport => "Roblox 고객지원";

	/// <summary>
	/// Key: "Label.TrustThisDevice"
	/// English String: "Trust this device for 30 days"
	/// </summary>
	public override string LabelTrustThisDevice => "30일 동안 본 기기 신뢰";

	/// <summary>
	/// Key: "Label.TwoStepVerification"
	/// English String: "2-Step Verification"
	/// </summary>
	public override string LabelTwoStepVerification => "2단계 인증";

	/// <summary>
	/// Key: "Response.CodeSent"
	/// English String: "Code Sent"
	/// </summary>
	public override string ResponseCodeSent => "코드 전송 완료";

	/// <summary>
	/// Key: "Response.FeatureNotAvailable"
	/// English String: "Feature not available. Please contact support."
	/// </summary>
	public override string ResponseFeatureNotAvailable => "사용할 수 없는 기능.\u00a0고객지원으로 문의하세요.";

	/// <summary>
	/// Key: "Response.InvalidCode"
	/// English String: "Invalid code."
	/// </summary>
	public override string ResponseInvalidCode => "유효하지 않은 코드";

	/// <summary>
	/// Key: "Response.SystemErrorReturnToLogin"
	/// English String: "System error. Please return to login screen."
	/// </summary>
	public override string ResponseSystemErrorReturnToLogin => "시스템 오류.\u00a0로그인 화면으로 돌아가세요.";

	/// <summary>
	/// Key: "Response.TooManyAttempts"
	/// English String: "Too many attempts. Please try again later."
	/// </summary>
	public override string ResponseTooManyAttempts => "시도 가능 횟수를 초과했습니다.\u00a0나중에 다시 시도하세요.";

	/// <summary>
	/// Key: "Response.TooManyCharacters"
	/// error message
	/// English String: "Too many characters"
	/// </summary>
	public override string ResponseTooManyCharacters => "입력 가능 글자 수를 초과했습니다";

	public TwoStepVerificationResources_ko_kr(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionCancel()
	{
		return "취소";
	}

	protected override string _GetTemplateForActionResend()
	{
		return "코드 재전송";
	}

	protected override string _GetTemplateForActionStartOver()
	{
		return "시작하기";
	}

	protected override string _GetTemplateForActionSubmit()
	{
		return "입력";
	}

	protected override string _GetTemplateForActionVerify()
	{
		return "확인";
	}

	/// <summary>
	/// Key: "Description.TwoStepVerificationActivationEmail.Body.Over13"
	/// Body for 2SV activation email for over 13 users
	/// English String: "Hi {accountName},{lineBreak}{lineBreak}You have activated 2-Step Verification for your Roblox account. Next time you log in from a new device, you will need to enter a 6-digit security code that Roblox sends to you via email.{lineBreak}{lineBreak}Roblox"
	/// </summary>
	public override string DescriptionTwoStepVerificationActivationEmailBodyOver13(string accountName, string lineBreak)
	{
		return $"{accountName} 님 안녕하세요,{lineBreak}{lineBreak}귀하의 Roblox 계정 에 대한 2단계 인증이 활성화되었습니다. 다음 번에 새 기기에서 로그인할 때 Roblox에서 이메일을 통해 보내는 6자리 보안 코드를 입력해야 합니다.{lineBreak}{lineBreak}Roblox";
	}

	protected override string _GetTemplateForDescriptionTwoStepVerificationActivationEmailBodyOver13()
	{
		return "{accountName} 님 안녕하세요,{lineBreak}{lineBreak}귀하의 Roblox 계정 에 대한 2단계 인증이 활성화되었습니다. 다음 번에 새 기기에서 로그인할 때 Roblox에서 이메일을 통해 보내는 6자리 보안 코드를 입력해야 합니다.{lineBreak}{lineBreak}Roblox";
	}

	/// <summary>
	/// Key: "Description.TwoStepVerificationActivationEmail.Body.Under13"
	/// Body for 2SV activation email for under 13 users
	/// English String: "Hi,{lineBreak}{lineBreak}2-Step Verification has been activated for your child's Roblox account, {accountName}. Next time they log in from a new device, they will need to enter a 6-digit security code that Roblox sends to you via email.{lineBreak}{lineBreak}Roblox"
	/// </summary>
	public override string DescriptionTwoStepVerificationActivationEmailBodyUnder13(string lineBreak, string accountName)
	{
		return $"안녕하세요,{lineBreak}{lineBreak}자녀의 Roblox 계정 {accountName}에 대한 2단계 인증이 활성화되었습니다. 다음 번에 새 기기에서 로그인할 때 Roblox에서 이메일을 통해 보내는 6자리 보안 코드를 입력해야 합니다.{lineBreak}{lineBreak}Roblox";
	}

	protected override string _GetTemplateForDescriptionTwoStepVerificationActivationEmailBodyUnder13()
	{
		return "안녕하세요,{lineBreak}{lineBreak}자녀의 Roblox 계정 {accountName}에 대한 2단계 인증이 활성화되었습니다. 다음 번에 새 기기에서 로그인할 때 Roblox에서 이메일을 통해 보내는 6자리 보안 코드를 입력해야 합니다.{lineBreak}{lineBreak}Roblox";
	}

	/// <summary>
	/// Key: "Description.TwoStepVerificationActivationEmail.Subject"
	/// Subject for 2SV activation email
	/// English String: "2-Step Verification Activated for Roblox Account: {accountName}"
	/// </summary>
	public override string DescriptionTwoStepVerificationActivationEmailSubject(string accountName)
	{
		return $"Roblox 계정 {accountName}의 2단계 인증 활성화 완료 ";
	}

	protected override string _GetTemplateForDescriptionTwoStepVerificationActivationEmailSubject()
	{
		return "Roblox 계정 {accountName}의 2단계 인증 활성화 완료 ";
	}

	/// <summary>
	/// Key: "Description.TwoStepVerificationDeactivationEmail.Body.Over13"
	/// Body for 2SV deactivation email for over 13 users
	/// English String: "Hi {accountName},{lineBreak}{lineBreak}You have deactivated 2-Step Verification for your Roblox account. A security code will no longer be required when you log into your account.{lineBreak}{lineBreak}Roblox"
	/// </summary>
	public override string DescriptionTwoStepVerificationDeactivationEmailBodyOver13(string accountName, string lineBreak)
	{
		return $"{accountName} 님 안녕하세요,{lineBreak}{lineBreak}회원님의 Roblox 계정에 대한 2단계 인증을 비활성화했습니다. 로그인 시 보안 코드가 더 이상 필요하지 않습니다.{lineBreak}{lineBreak}Roblox";
	}

	protected override string _GetTemplateForDescriptionTwoStepVerificationDeactivationEmailBodyOver13()
	{
		return "{accountName} 님 안녕하세요,{lineBreak}{lineBreak}회원님의 Roblox 계정에 대한 2단계 인증을 비활성화했습니다. 로그인 시 보안 코드가 더 이상 필요하지 않습니다.{lineBreak}{lineBreak}Roblox";
	}

	/// <summary>
	/// Key: "Description.TwoStepVerificationDeactivationEmail.Body.Under13"
	/// Body for 2SV deactivation email for under 13 users
	/// English String: "Hi,{lineBreak}{lineBreak}2-Step Verification has been deactivated for your child's Roblox account, {accountName}. A security code will no longer be required when they log into the account.{lineBreak}{lineBreak}Roblox"
	/// </summary>
	public override string DescriptionTwoStepVerificationDeactivationEmailBodyUnder13(string lineBreak, string accountName)
	{
		return $"안녕하세요,{lineBreak}{lineBreak}자녀의 Roblox 계정 {accountName}에 대한 2단계 인증을 비활성화했습니다. 로그인 시 보안 코드가 더 이상 필요하지 않습니다.{lineBreak}{lineBreak}Roblox";
	}

	protected override string _GetTemplateForDescriptionTwoStepVerificationDeactivationEmailBodyUnder13()
	{
		return "안녕하세요,{lineBreak}{lineBreak}자녀의 Roblox 계정 {accountName}에 대한 2단계 인증을 비활성화했습니다. 로그인 시 보안 코드가 더 이상 필요하지 않습니다.{lineBreak}{lineBreak}Roblox";
	}

	/// <summary>
	/// Key: "Description.TwoStepVerificationDeactivationEmail.Subject	"
	/// Subject for 2SV deactivation email
	/// English String: "2-Step Verification Deactivated for Roblox Account: {accountName}"
	/// </summary>
	public override string DescriptionTwoStepVerificationDeactivationEmailSubject(string accountName)
	{
		return $"Roblox 계정 {accountName}의 2단계 인증 비활성화 완료: ";
	}

	protected override string _GetTemplateForDescriptionTwoStepVerificationDeactivationEmailSubject()
	{
		return "Roblox 계정 {accountName}의 2단계 인증 비활성화 완료: ";
	}

	/// <summary>
	/// Key: "Description.TwoStepVerificationLoginEmail.Html.GeolocationInfo1"
	/// Geolocation information about IP trying to login
	/// English String: "{spanStartTagWithBold}Login request received from {username} located in {region}, {country} ({ipAddress}).{spanEndTag}{lineBreak}{lineBreak}"
	/// </summary>
	public override string DescriptionTwoStepVerificationLoginEmailHtmlGeolocationInfo1(string spanStartTagWithBold, string username, string region, string country, string ipAddress, string spanEndTag, string lineBreak)
	{
		return $"{spanStartTagWithBold}{username} 님이 {region}, {country}({ipAddress})에서 로그인을 요청했어요.{spanEndTag}{lineBreak}{lineBreak}";
	}

	protected override string _GetTemplateForDescriptionTwoStepVerificationLoginEmailHtmlGeolocationInfo1()
	{
		return "{spanStartTagWithBold}{username} 님이 {region}, {country}({ipAddress})에서 로그인을 요청했어요.{spanEndTag}{lineBreak}{lineBreak}";
	}

	/// <summary>
	/// Key: "Description.TwoStepVerificationLoginEmail.Html.GeolocationInfo2"
	/// Geolocation info about IP trying to login
	/// English String: "{spanStartTagWithBold}Login request received from {username} located in {country} ({ipAddress}).{spanEndTag}{lineBreak}{lineBreak}\t"
	/// </summary>
	public override string DescriptionTwoStepVerificationLoginEmailHtmlGeolocationInfo2(string spanStartTagWithBold, string username, string country, string ipAddress, string spanEndTag, string lineBreak)
	{
		return $"{spanStartTagWithBold}{username} 님이 {country}({ipAddress})에서 로그인을 요청했어요.{spanEndTag}{lineBreak}{lineBreak}\t";
	}

	protected override string _GetTemplateForDescriptionTwoStepVerificationLoginEmailHtmlGeolocationInfo2()
	{
		return "{spanStartTagWithBold}{username} 님이 {country}({ipAddress})에서 로그인을 요청했어요.{spanEndTag}{lineBreak}{lineBreak}\t";
	}

	/// <summary>
	/// Key: "Description.TwoStepVerificationLoginEmail.Html.GeolocationInfo3"
	/// Geolocation info about IP trying to log in
	/// English String: "{spanStartTagWithBold}Login request received from {username} (From Roblox Internal).{spanEndTag}{lineBreak}{lineBreak}\t"
	/// </summary>
	public override string DescriptionTwoStepVerificationLoginEmailHtmlGeolocationInfo3(string spanStartTagWithBold, string username, string spanEndTag, string lineBreak)
	{
		return $"{spanStartTagWithBold}(Roblox 내부의) {username} 님이 로그인을 요청했어요.{spanEndTag}{lineBreak}{lineBreak}\t";
	}

	protected override string _GetTemplateForDescriptionTwoStepVerificationLoginEmailHtmlGeolocationInfo3()
	{
		return "{spanStartTagWithBold}(Roblox 내부의) {username} 님이 로그인을 요청했어요.{spanEndTag}{lineBreak}{lineBreak}\t";
	}

	/// <summary>
	/// Key: "Description.TwoStepVerificationLoginEmail.Html.GeolocationInfo4"
	/// Geolocation info of IP trying to login
	/// English String: "{spanStartTagWithBold}Login request received from {username} located in {country}.{spanEndTag}{lineBreak}{lineBreak}"
	/// </summary>
	public override string DescriptionTwoStepVerificationLoginEmailHtmlGeolocationInfo4(string spanStartTagWithBold, string username, string country, string spanEndTag, string lineBreak)
	{
		return $"{spanStartTagWithBold}{username} 님이 {country}에서 로그인을 요청했어요.{spanEndTag}{lineBreak}{lineBreak}";
	}

	protected override string _GetTemplateForDescriptionTwoStepVerificationLoginEmailHtmlGeolocationInfo4()
	{
		return "{spanStartTagWithBold}{username} 님이 {country}에서 로그인을 요청했어요.{spanEndTag}{lineBreak}{lineBreak}";
	}

	/// <summary>
	/// Key: "Description.TwoStepVerificationLoginEmail.Html.GeolocationInfo5"
	/// Geolocation info of IP trying to login
	/// English String: "{spanStartTagWithBold}Login request received from {username} located in {region}, {country}.{spanEndTag}{lineBreak}{lineBreak}"
	/// </summary>
	public override string DescriptionTwoStepVerificationLoginEmailHtmlGeolocationInfo5(string spanStartTagWithBold, string username, string region, string country, string spanEndTag, string lineBreak)
	{
		return $"{spanStartTagWithBold}{username} 님이 {country} {region}에서 로그인을 요청했어요.{spanEndTag}{lineBreak}{lineBreak}";
	}

	protected override string _GetTemplateForDescriptionTwoStepVerificationLoginEmailHtmlGeolocationInfo5()
	{
		return "{spanStartTagWithBold}{username} 님이 {country} {region}에서 로그인을 요청했어요.{spanEndTag}{lineBreak}{lineBreak}";
	}

	/// <summary>
	/// Key: "Description.TwoStepVerificationLoginEmail.Html.GeolocationInfo6"
	/// Geolocation info of IP trying to login
	/// English String: "{spanStartTagWithBold}Login request received from {username} located in {city}, {region}, {country}.{spanEndTag}{lineBreak}{lineBreak}"
	/// </summary>
	public override string DescriptionTwoStepVerificationLoginEmailHtmlGeolocationInfo6(string spanStartTagWithBold, string username, string city, string region, string country, string spanEndTag, string lineBreak)
	{
		return $"{spanStartTagWithBold}{username} 님이 {country} {region} {city}에서 로그인을 요청했어요.{spanEndTag}{lineBreak}{lineBreak}";
	}

	protected override string _GetTemplateForDescriptionTwoStepVerificationLoginEmailHtmlGeolocationInfo6()
	{
		return "{spanStartTagWithBold}{username} 님이 {country} {region} {city}에서 로그인을 요청했어요.{spanEndTag}{lineBreak}{lineBreak}";
	}

	/// <summary>
	/// Key: "Description.TwoStepVerificationLoginEmail.HtmlBody"
	/// Html body for 2SV login email
	/// English String: "{geoLocationInformation}{spanStartTagWithBold}Login code for {accountName}: {lineBreak}{lineBreak}{code} {spanEndTag}{lineBreak}{lineBreak}Enter this code into the 2-Step Verification screen to finish logging in. This code will expire in 15 minutes.{lineBreak}{lineBreak}This email was sent because your account tried to login to Roblox from a new browser or device. If you haven't tried logging into Roblox, someone else may be trying to access your account. You are strongly advised to change your password if you did not generate this request.{lineBreak}{lineBreak}Resources:{lineBreak}{aTagStartWithHref}{ChangePasswordLink}{hrefEnd}Change Your Password{aTagEnd} {lineBreak}{aTagStartWithHref}{TwoStepVerificationArticleLink}{hrefEnd}Learn More About 2-Step Verification{aTagEnd} {lineBreak}{aTagStartWithHref}{AccountSafetyArticleLink}{hrefEnd}Keeping Your Account Safe{aTagEnd} {lineBreak}{aTagStartWithHref}{SupportLink}{hrefEnd}General Roblox Support{aTagEnd} {lineBreak}{lineBreak}Thank you,{lineBreak}{lineBreak}The Roblox Team"
	/// </summary>
	public override string DescriptionTwoStepVerificationLoginEmailHtmlBody(string geoLocationInformation, string spanStartTagWithBold, string accountName, string lineBreak, string code, string spanEndTag, string aTagStartWithHref, string ChangePasswordLink, string hrefEnd, string aTagEnd, string TwoStepVerificationArticleLink, string AccountSafetyArticleLink, string SupportLink)
	{
		return $"{geoLocationInformation}{spanStartTagWithBold}{accountName}의 로그인 코드: {lineBreak}{lineBreak}{code} {spanEndTag}{lineBreak}{lineBreak}로그인을 완료하려면 본 코드를 2단계 인증 화면에 입력하세요. 코드는 15분 후 만료됩니다.{lineBreak}{lineBreak}본 이메일은 새로운 브라우저 또는 기기에서 회원님의 계정으로 Roblox에 로그인하려 했기 때문에 보내드립니다. Roblox에 로그인하려 한 적이 없으셨다면, 다른 누군가가 회원님의 계정에 접속하려 했을 수도 있습니다. 로그인 요청을 한 적이 없는 경우 비밀번호를 바꾸길 강력하게 권고드립니다.{lineBreak}{lineBreak}리소스:{lineBreak}{aTagStartWithHref}{ChangePasswordLink}{hrefEnd}비밀번호 변경{aTagEnd} {lineBreak}{aTagStartWithHref}{TwoStepVerificationArticleLink}{hrefEnd}2단계 인증 더 알아보기{aTagEnd} {lineBreak}{aTagStartWithHref}{AccountSafetyArticleLink}{hrefEnd}계정 보호 방법{aTagEnd} {lineBreak}{aTagStartWithHref}{SupportLink}{hrefEnd}일반적인 Roblox 고객지원{aTagEnd} {lineBreak}{lineBreak}감사합니다.{lineBreak}{lineBreak}Roblox 팀";
	}

	protected override string _GetTemplateForDescriptionTwoStepVerificationLoginEmailHtmlBody()
	{
		return "{geoLocationInformation}{spanStartTagWithBold}{accountName}의 로그인 코드: {lineBreak}{lineBreak}{code} {spanEndTag}{lineBreak}{lineBreak}로그인을 완료하려면 본 코드를 2단계 인증 화면에 입력하세요. 코드는 15분 후 만료됩니다.{lineBreak}{lineBreak}본 이메일은 새로운 브라우저 또는 기기에서 회원님의 계정으로 Roblox에 로그인하려 했기 때문에 보내드립니다. Roblox에 로그인하려 한 적이 없으셨다면, 다른 누군가가 회원님의 계정에 접속하려 했을 수도 있습니다. 로그인 요청을 한 적이 없는 경우 비밀번호를 바꾸길 강력하게 권고드립니다.{lineBreak}{lineBreak}리소스:{lineBreak}{aTagStartWithHref}{ChangePasswordLink}{hrefEnd}비밀번호 변경{aTagEnd} {lineBreak}{aTagStartWithHref}{TwoStepVerificationArticleLink}{hrefEnd}2단계 인증 더 알아보기{aTagEnd} {lineBreak}{aTagStartWithHref}{AccountSafetyArticleLink}{hrefEnd}계정 보호 방법{aTagEnd} {lineBreak}{aTagStartWithHref}{SupportLink}{hrefEnd}일반적인 Roblox 고객지원{aTagEnd} {lineBreak}{lineBreak}감사합니다.{lineBreak}{lineBreak}Roblox 팀";
	}

	/// <summary>
	/// Key: "Description.TwoStepVerificationLoginEmail.PlainBody"
	/// Plain body for 2SV login email
	/// English String: "{geoLocationInformation}Login code for {accountName}: {lineBreak}{lineBreak} {code} {lineBreak}{lineBreak}Enter this code into the 2-Step Verification screen to finish logging in. This code will expire in 15 minutes. {lineBreak}{lineBreak}This email was sent because your account tried to login to Roblox from a new browser or device. If you haven't tried logging into Roblox, someone else may be trying to access your account. You are strongly advised to change your password if you did not generate this request. {lineBreak}{lineBreak}Resources: {lineBreak}Change Your Password [{accountInfoPageLink}] {lineBreak}Learn More About 2-Step Verification [{twoStepVerificationHelpArticleLink}]{lineBreak}Keeping Your Account Safe [{keepAccountSafeArticleLink}] {lineBreak}General Roblox Support [{supportPageLink}] {lineBreak}{lineBreak}Thank you, {lineBreak}{lineBreak}The Roblox Team"
	/// </summary>
	public override string DescriptionTwoStepVerificationLoginEmailPlainBody(string geoLocationInformation, string accountName, string lineBreak, string code, string accountInfoPageLink, string twoStepVerificationHelpArticleLink, string keepAccountSafeArticleLink, string supportPageLink)
	{
		return $"{geoLocationInformation}{accountName}의 로그인 코드: {lineBreak}{lineBreak} {code} {lineBreak}{lineBreak}로그인을 완료하려면 본 코드를 2단계 인증 화면에 입력하세요. 코드는 15분 후 만료됩니다. {lineBreak}{lineBreak}본 이메일은 새로운 브라우저 또는 기기에서 회원님의 계정으로 Roblox에 로그인하려 했기 때문에 보내드립니다. Roblox에 로그인하려 한 적이 없으셨다면, 다른 누군가가 회원님의 계정에 접속하려 했을 수도 있습니다. 로그인 요청을 한 적이 없는 경우 비밀번호를 바꾸길 강력하게 권고드립니다. {lineBreak}{lineBreak}리소스: {lineBreak}비밀번호 변경 [{accountInfoPageLink}] {lineBreak}2단계 인증 더 알아보기 [{twoStepVerificationHelpArticleLink}]{lineBreak}계정 보호 방법 [{keepAccountSafeArticleLink}] {lineBreak}일반적인 Roblox 고객지원 [{supportPageLink}] {lineBreak}{lineBreak}감사합니다. {lineBreak}{lineBreak}Roblox 팀";
	}

	protected override string _GetTemplateForDescriptionTwoStepVerificationLoginEmailPlainBody()
	{
		return "{geoLocationInformation}{accountName}의 로그인 코드: {lineBreak}{lineBreak} {code} {lineBreak}{lineBreak}로그인을 완료하려면 본 코드를 2단계 인증 화면에 입력하세요. 코드는 15분 후 만료됩니다. {lineBreak}{lineBreak}본 이메일은 새로운 브라우저 또는 기기에서 회원님의 계정으로 Roblox에 로그인하려 했기 때문에 보내드립니다. Roblox에 로그인하려 한 적이 없으셨다면, 다른 누군가가 회원님의 계정에 접속하려 했을 수도 있습니다. 로그인 요청을 한 적이 없는 경우 비밀번호를 바꾸길 강력하게 권고드립니다. {lineBreak}{lineBreak}리소스: {lineBreak}비밀번호 변경 [{accountInfoPageLink}] {lineBreak}2단계 인증 더 알아보기 [{twoStepVerificationHelpArticleLink}]{lineBreak}계정 보호 방법 [{keepAccountSafeArticleLink}] {lineBreak}일반적인 Roblox 고객지원 [{supportPageLink}] {lineBreak}{lineBreak}감사합니다. {lineBreak}{lineBreak}Roblox 팀";
	}

	/// <summary>
	/// Key: "Description.TwoStepVerificationLoginEmail.PlainText.GeolocationInfo1"
	/// GeoLocation info of IP trying to login
	/// English String: "Login request received from {username} located in {region}, {country} ({ipAddress}).{lineBreak}{lineBreak}"
	/// </summary>
	public override string DescriptionTwoStepVerificationLoginEmailPlainTextGeolocationInfo1(string username, string region, string country, string ipAddress, string lineBreak)
	{
		return $"{username} 님이 {region}, {country}({ipAddress})에서 로그인을 요청했어요.{lineBreak}{lineBreak}";
	}

	protected override string _GetTemplateForDescriptionTwoStepVerificationLoginEmailPlainTextGeolocationInfo1()
	{
		return "{username} 님이 {region}, {country}({ipAddress})에서 로그인을 요청했어요.{lineBreak}{lineBreak}";
	}

	/// <summary>
	/// Key: "Description.TwoStepVerificationLoginEmail.PlainText.GeolocationInfo2"
	/// Geolocation info of IP trying to login
	/// English String: "Login request received from {username} located in {country} ({ipAddress}).{lineBreak}{lineBreak}"
	/// </summary>
	public override string DescriptionTwoStepVerificationLoginEmailPlainTextGeolocationInfo2(string username, string country, string ipAddress, string lineBreak)
	{
		return $"{username} 님이 {country}({ipAddress})에서 로그인을 요청했어요.{lineBreak}{lineBreak}";
	}

	protected override string _GetTemplateForDescriptionTwoStepVerificationLoginEmailPlainTextGeolocationInfo2()
	{
		return "{username} 님이 {country}({ipAddress})에서 로그인을 요청했어요.{lineBreak}{lineBreak}";
	}

	/// <summary>
	/// Key: "Description.TwoStepVerificationLoginEmail.PlainText.GeolocationInfo3"
	/// Geolocation info of IP trying to login
	/// English String: "Login request received from {username} (From Roblox Internal).{lineBreak}{lineBreak}"
	/// </summary>
	public override string DescriptionTwoStepVerificationLoginEmailPlainTextGeolocationInfo3(string username, string lineBreak)
	{
		return $"(Roblox 내부의) {username} 님이 로그인을 요청했어요.{lineBreak}{lineBreak}";
	}

	protected override string _GetTemplateForDescriptionTwoStepVerificationLoginEmailPlainTextGeolocationInfo3()
	{
		return "(Roblox 내부의) {username} 님이 로그인을 요청했어요.{lineBreak}{lineBreak}";
	}

	/// <summary>
	/// Key: "Description.TwoStepVerificationLoginEmail.PlainText.GeolocationInfo4"
	/// Geolocation info of IP trying to login
	/// English String: "Login request received from {username} located in {country}.{lineBreak}{lineBreak}"
	/// </summary>
	public override string DescriptionTwoStepVerificationLoginEmailPlainTextGeolocationInfo4(string username, string country, string lineBreak)
	{
		return $"{username} 님이 {country}에서 로그인을 요청했어요.{lineBreak}{lineBreak}";
	}

	protected override string _GetTemplateForDescriptionTwoStepVerificationLoginEmailPlainTextGeolocationInfo4()
	{
		return "{username} 님이 {country}에서 로그인을 요청했어요.{lineBreak}{lineBreak}";
	}

	/// <summary>
	/// Key: "Description.TwoStepVerificationLoginEmail.PlainText.GeolocationInfo5"
	/// Geolocation info of IP trying to login
	/// English String: "Login request received from {username} located in {region}, {country}.{lineBreak}{lineBreak}"
	/// </summary>
	public override string DescriptionTwoStepVerificationLoginEmailPlainTextGeolocationInfo5(string username, string region, string country, string lineBreak)
	{
		return $"{username} 님이 {country} {region}에서 로그인을 요청했어요.{lineBreak}{lineBreak}";
	}

	protected override string _GetTemplateForDescriptionTwoStepVerificationLoginEmailPlainTextGeolocationInfo5()
	{
		return "{username} 님이 {country} {region}에서 로그인을 요청했어요.{lineBreak}{lineBreak}";
	}

	/// <summary>
	/// Key: "Description.TwoStepVerificationLoginEmail.PlainText.GeolocationInfo6"
	/// Geolocation info of IP trying to login
	/// English String: "Login request received from {username} located in {city}, {region}, {country}.{lineBreak}{lineBreak}"
	/// </summary>
	public override string DescriptionTwoStepVerificationLoginEmailPlainTextGeolocationInfo6(string username, string city, string region, string country, string lineBreak)
	{
		return $"{username} 님이 {country} {region} {city}에서 로그인을 요청했어요.{lineBreak}{lineBreak}";
	}

	protected override string _GetTemplateForDescriptionTwoStepVerificationLoginEmailPlainTextGeolocationInfo6()
	{
		return "{username} 님이 {country} {region} {city}에서 로그인을 요청했어요.{lineBreak}{lineBreak}";
	}

	/// <summary>
	/// Key: "Description.TwoStepVerificationLoginEmail.Subject"
	/// Subject for 2SV login email
	/// English String: "Verification Code for Roblox Account: {accountName}"
	/// </summary>
	public override string DescriptionTwoStepVerificationLoginEmailSubject(string accountName)
	{
		return $"Roblox 계정 {accountName}에 대한 인증 코드";
	}

	protected override string _GetTemplateForDescriptionTwoStepVerificationLoginEmailSubject()
	{
		return "Roblox 계정 {accountName}에 대한 인증 코드";
	}

	protected override string _GetTemplateForLabelCode()
	{
		return "코드";
	}

	/// <summary>
	/// Key: "Label.CodeInputPlaceholderText"
	/// example: Enter 4-digit code
	/// English String: "Enter {codeLength}-digit Code"
	/// </summary>
	public override string LabelCodeInputPlaceholderText(string codeLength)
	{
		return $"{codeLength}자리 코드 입력";
	}

	protected override string _GetTemplateForLabelCodeInputPlaceholderText()
	{
		return "{codeLength}자리 코드 입력";
	}

	protected override string _GetTemplateForLabelDidNotReceive()
	{
		return "코드를 받지 못하셨나요?";
	}

	protected override string _GetTemplateForLabelEnterCode()
	{
		return "코드 입력 (6자리)";
	}

	protected override string _GetTemplateForLabelEnterEmailCode()
	{
		return "방금 이메일로 전송된 코드를 입력하세요.";
	}

	protected override string _GetTemplateForLabelEnterTextCode()
	{
		return "방금 문자 메시지로 전송된 코드를 입력하세요.";
	}

	protected override string _GetTemplateForLabelEnterTwoStepVerificationCode()
	{
		return "2단계 인증 코드를 입력하세요.";
	}

	protected override string _GetTemplateForLabelFacebookPasswordWarning()
	{
		return "Facebook으로 로그인한 경우, 비밀번호를 설정해야 합니다.";
	}

	protected override string _GetTemplateForLabelLearnMore()
	{
		return "더 알아보기";
	}

	/// <summary>
	/// Key: "Label.NeedHelpContactSupport"
	/// label for the support article link
	/// English String: "Need help? Contact {supportLink}"
	/// </summary>
	public override string LabelNeedHelpContactSupport(string supportLink)
	{
		return $"도움이 필요하세요? {supportLink}(으)로 문의하세요";
	}

	protected override string _GetTemplateForLabelNeedHelpContactSupport()
	{
		return "도움이 필요하세요? {supportLink}(으)로 문의하세요";
	}

	protected override string _GetTemplateForLabelNewCode()
	{
		return "새 코드";
	}

	protected override string _GetTemplateForLabelRobloxSupport()
	{
		return "Roblox 고객지원";
	}

	protected override string _GetTemplateForLabelTrustThisDevice()
	{
		return "30일 동안 본 기기 신뢰";
	}

	protected override string _GetTemplateForLabelTwoStepVerification()
	{
		return "2단계 인증";
	}

	protected override string _GetTemplateForResponseCodeSent()
	{
		return "코드 전송 완료";
	}

	protected override string _GetTemplateForResponseFeatureNotAvailable()
	{
		return "사용할 수 없는 기능.\u00a0고객지원으로 문의하세요.";
	}

	protected override string _GetTemplateForResponseInvalidCode()
	{
		return "유효하지 않은 코드";
	}

	protected override string _GetTemplateForResponseSystemErrorReturnToLogin()
	{
		return "시스템 오류.\u00a0로그인 화면으로 돌아가세요.";
	}

	protected override string _GetTemplateForResponseTooManyAttempts()
	{
		return "시도 가능 횟수를 초과했습니다.\u00a0나중에 다시 시도하세요.";
	}

	protected override string _GetTemplateForResponseTooManyCharacters()
	{
		return "입력 가능 글자 수를 초과했습니다";
	}
}
