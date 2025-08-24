namespace Roblox.TranslationResources.Authentication;

/// <summary>
/// This class overrides TwoStepVerificationResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class TwoStepVerificationResources_zh_tw : TwoStepVerificationResources_en_us, ITwoStepVerificationResources, ITranslationResources
{
	/// <summary>
	/// Key: "Action.Cancel"
	/// English String: "Cancel"
	/// </summary>
	public override string ActionCancel => "取消";

	/// <summary>
	/// Key: "Action.Resend"
	/// English String: "Resend Code"
	/// </summary>
	public override string ActionResend => "重新傳送驗證碼";

	/// <summary>
	/// Key: "Action.StartOver"
	/// link text to restart verification
	/// English String: "Start Over"
	/// </summary>
	public override string ActionStartOver => "重新開始";

	/// <summary>
	/// Key: "Action.Submit"
	/// submit button text
	/// English String: "Submit"
	/// </summary>
	public override string ActionSubmit => "提交";

	/// <summary>
	/// Key: "Action.Verify"
	/// English String: "Verify"
	/// </summary>
	public override string ActionVerify => "驗證";

	/// <summary>
	/// Key: "Label.Code"
	/// verification code for 2 factor authentication
	/// English String: "Code"
	/// </summary>
	public override string LabelCode => "驗證碼";

	/// <summary>
	/// Key: "Label.DidNotReceive"
	/// English String: "Didn't receive the code?"
	/// </summary>
	public override string LabelDidNotReceive => "沒有收到代碼？";

	/// <summary>
	/// Key: "Label.EnterCode"
	/// English String: "Enter Code (6-digit)"
	/// </summary>
	public override string LabelEnterCode => "輸入驗證碼（6 位數）";

	/// <summary>
	/// Key: "Label.EnterEmailCode"
	/// English String: "Enter the code we just sent you via email"
	/// </summary>
	public override string LabelEnterEmailCode => "請輸入傳送到您的電子郵件信箱的驗證碼";

	/// <summary>
	/// Key: "Label.EnterTextCode"
	/// English String: "Enter the code we just sent you via text message"
	/// </summary>
	public override string LabelEnterTextCode => "請輸入傳送到您的手機的驗證碼";

	/// <summary>
	/// Key: "Label.EnterTwoStepVerificationCode"
	/// Enter your two step verification code.
	/// English String: "Enter your two step verification code."
	/// </summary>
	public override string LabelEnterTwoStepVerificationCode => "請輸入雙步驟驗證碼。";

	/// <summary>
	/// Key: "Label.FacebookPasswordWarning"
	/// If you have been signing in with Facebook, you must set a password.
	/// English String: "If you have been signing in with Facebook, you must set a password."
	/// </summary>
	public override string LabelFacebookPasswordWarning => "若您以 Facebook 登入，請設定密碼。";

	/// <summary>
	/// Key: "Label.LearnMore"
	/// Learn More link text
	/// English String: "Learn More"
	/// </summary>
	public override string LabelLearnMore => "了解更多";

	/// <summary>
	/// Key: "Label.NewCode"
	/// verification code resent, label changes to new code
	/// English String: "New Code"
	/// </summary>
	public override string LabelNewCode => "新驗證碼";

	/// <summary>
	/// Key: "Label.RobloxSupport"
	/// English String: "Roblox Support"
	/// </summary>
	public override string LabelRobloxSupport => "Roblox 協助";

	/// <summary>
	/// Key: "Label.TrustThisDevice"
	/// English String: "Trust this device for 30 days"
	/// </summary>
	public override string LabelTrustThisDevice => "信任此裝置 30 天";

	/// <summary>
	/// Key: "Label.TwoStepVerification"
	/// English String: "2-Step Verification"
	/// </summary>
	public override string LabelTwoStepVerification => "雙步驟驗證";

	/// <summary>
	/// Key: "Response.CodeSent"
	/// English String: "Code Sent"
	/// </summary>
	public override string ResponseCodeSent => "驗證碼已傳送";

	/// <summary>
	/// Key: "Response.FeatureNotAvailable"
	/// English String: "Feature not available. Please contact support."
	/// </summary>
	public override string ResponseFeatureNotAvailable => "無法使用此功能，請聯絡客服人員。";

	/// <summary>
	/// Key: "Response.InvalidCode"
	/// English String: "Invalid code."
	/// </summary>
	public override string ResponseInvalidCode => "驗證碼無效。";

	/// <summary>
	/// Key: "Response.SystemErrorReturnToLogin"
	/// English String: "System error. Please return to login screen."
	/// </summary>
	public override string ResponseSystemErrorReturnToLogin => "系統錯誤，請返回登入畫面。";

	/// <summary>
	/// Key: "Response.TooManyAttempts"
	/// English String: "Too many attempts. Please try again later."
	/// </summary>
	public override string ResponseTooManyAttempts => "嘗試次數過多，請稍後再試。";

	/// <summary>
	/// Key: "Response.TooManyCharacters"
	/// error message
	/// English String: "Too many characters"
	/// </summary>
	public override string ResponseTooManyCharacters => "字元過多";

	public TwoStepVerificationResources_zh_tw(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionCancel()
	{
		return "取消";
	}

	protected override string _GetTemplateForActionResend()
	{
		return "重新傳送驗證碼";
	}

	protected override string _GetTemplateForActionStartOver()
	{
		return "重新開始";
	}

	protected override string _GetTemplateForActionSubmit()
	{
		return "提交";
	}

	protected override string _GetTemplateForActionVerify()
	{
		return "驗證";
	}

	/// <summary>
	/// Key: "Description.TwoStepVerificationActivationEmail.Body.Over13"
	/// Body for 2SV activation email for over 13 users
	/// English String: "Hi {accountName},{lineBreak}{lineBreak}You have activated 2-Step Verification for your Roblox account. Next time you log in from a new device, you will need to enter a 6-digit security code that Roblox sends to you via email.{lineBreak}{lineBreak}Roblox"
	/// </summary>
	public override string DescriptionTwoStepVerificationActivationEmailBodyOver13(string accountName, string lineBreak)
	{
		return $"您好，{accountName}，{lineBreak}{lineBreak}您已為 Roblox 帳戶啟用 2 步驟驗證。下次您從新的裝置登入時，會需要輸入 6 位安全碼，Roblox 已將此安全碼經由電子郵件傳送給您。{lineBreak}{lineBreak}Roblox 敬上";
	}

	protected override string _GetTemplateForDescriptionTwoStepVerificationActivationEmailBodyOver13()
	{
		return "您好，{accountName}，{lineBreak}{lineBreak}您已為 Roblox 帳戶啟用 2 步驟驗證。下次您從新的裝置登入時，會需要輸入 6 位安全碼，Roblox 已將此安全碼經由電子郵件傳送給您。{lineBreak}{lineBreak}Roblox 敬上";
	}

	/// <summary>
	/// Key: "Description.TwoStepVerificationActivationEmail.Body.Under13"
	/// Body for 2SV activation email for under 13 users
	/// English String: "Hi,{lineBreak}{lineBreak}2-Step Verification has been activated for your child's Roblox account, {accountName}. Next time they log in from a new device, they will need to enter a 6-digit security code that Roblox sends to you via email.{lineBreak}{lineBreak}Roblox"
	/// </summary>
	public override string DescriptionTwoStepVerificationActivationEmailBodyUnder13(string lineBreak, string accountName)
	{
		return $"您好，{lineBreak}{lineBreak}您孩子的 Roblox 帳戶 {accountName} 現已啟用 2 步驟驗證。他們下次從新的裝置登入時，會需要輸入 6 位安全碼，Roblox 已將此安全碼經由電子郵件傳送給您。{lineBreak}{lineBreak}Roblox 敬上";
	}

	protected override string _GetTemplateForDescriptionTwoStepVerificationActivationEmailBodyUnder13()
	{
		return "您好，{lineBreak}{lineBreak}您孩子的 Roblox 帳戶 {accountName} 現已啟用 2 步驟驗證。他們下次從新的裝置登入時，會需要輸入 6 位安全碼，Roblox 已將此安全碼經由電子郵件傳送給您。{lineBreak}{lineBreak}Roblox 敬上";
	}

	/// <summary>
	/// Key: "Description.TwoStepVerificationActivationEmail.Subject"
	/// Subject for 2SV activation email
	/// English String: "2-Step Verification Activated for Roblox Account: {accountName}"
	/// </summary>
	public override string DescriptionTwoStepVerificationActivationEmailSubject(string accountName)
	{
		return $"已啟用 Roblox 帳戶的 2 步驟驗證：{accountName}";
	}

	protected override string _GetTemplateForDescriptionTwoStepVerificationActivationEmailSubject()
	{
		return "已啟用 Roblox 帳戶的 2 步驟驗證：{accountName}";
	}

	/// <summary>
	/// Key: "Description.TwoStepVerificationDeactivationEmail.Body.Over13"
	/// Body for 2SV deactivation email for over 13 users
	/// English String: "Hi {accountName},{lineBreak}{lineBreak}You have deactivated 2-Step Verification for your Roblox account. A security code will no longer be required when you log into your account.{lineBreak}{lineBreak}Roblox"
	/// </summary>
	public override string DescriptionTwoStepVerificationDeactivationEmailBodyOver13(string accountName, string lineBreak)
	{
		return $"您好，{accountName}，{lineBreak}{lineBreak}您已為 Roblox 帳戶停用 2 步驟驗證。當您登入帳戶時，不再需要使用安全碼。{lineBreak}{lineBreak}Roblox 敬上";
	}

	protected override string _GetTemplateForDescriptionTwoStepVerificationDeactivationEmailBodyOver13()
	{
		return "您好，{accountName}，{lineBreak}{lineBreak}您已為 Roblox 帳戶停用 2 步驟驗證。當您登入帳戶時，不再需要使用安全碼。{lineBreak}{lineBreak}Roblox 敬上";
	}

	/// <summary>
	/// Key: "Description.TwoStepVerificationDeactivationEmail.Body.Under13"
	/// Body for 2SV deactivation email for under 13 users
	/// English String: "Hi,{lineBreak}{lineBreak}2-Step Verification has been deactivated for your child's Roblox account, {accountName}. A security code will no longer be required when they log into the account.{lineBreak}{lineBreak}Roblox"
	/// </summary>
	public override string DescriptionTwoStepVerificationDeactivationEmailBodyUnder13(string lineBreak, string accountName)
	{
		return $"您好，{lineBreak}{lineBreak}您孩子的 Roblox 帳戶 {accountName} 已停用 2 步驟驗證。他們登入帳戶時，不再需要使用安全碼。{lineBreak}{lineBreak}Roblox 敬上";
	}

	protected override string _GetTemplateForDescriptionTwoStepVerificationDeactivationEmailBodyUnder13()
	{
		return "您好，{lineBreak}{lineBreak}您孩子的 Roblox 帳戶 {accountName} 已停用 2 步驟驗證。他們登入帳戶時，不再需要使用安全碼。{lineBreak}{lineBreak}Roblox 敬上";
	}

	/// <summary>
	/// Key: "Description.TwoStepVerificationDeactivationEmail.Subject	"
	/// Subject for 2SV deactivation email
	/// English String: "2-Step Verification Deactivated for Roblox Account: {accountName}"
	/// </summary>
	public override string DescriptionTwoStepVerificationDeactivationEmailSubject(string accountName)
	{
		return $"已停用 Roblox 帳戶的 2 步驟驗證：{accountName}";
	}

	protected override string _GetTemplateForDescriptionTwoStepVerificationDeactivationEmailSubject()
	{
		return "已停用 Roblox 帳戶的 2 步驟驗證：{accountName}";
	}

	/// <summary>
	/// Key: "Description.TwoStepVerificationLoginEmail.Html.GeolocationInfo1"
	/// Geolocation information about IP trying to login
	/// English String: "{spanStartTagWithBold}Login request received from {username} located in {region}, {country} ({ipAddress}).{spanEndTag}{lineBreak}{lineBreak}"
	/// </summary>
	public override string DescriptionTwoStepVerificationLoginEmailHtmlGeolocationInfo1(string spanStartTagWithBold, string username, string region, string country, string ipAddress, string spanEndTag, string lineBreak)
	{
		return $"{spanStartTagWithBold}收到位於{country}、{region}（{ipAddress}），來自{username}的登入請求。{spanEndTag}{lineBreak}{lineBreak}";
	}

	protected override string _GetTemplateForDescriptionTwoStepVerificationLoginEmailHtmlGeolocationInfo1()
	{
		return "{spanStartTagWithBold}收到位於{country}、{region}（{ipAddress}），來自{username}的登入請求。{spanEndTag}{lineBreak}{lineBreak}";
	}

	/// <summary>
	/// Key: "Description.TwoStepVerificationLoginEmail.Html.GeolocationInfo2"
	/// Geolocation info about IP trying to login
	/// English String: "{spanStartTagWithBold}Login request received from {username} located in {country} ({ipAddress}).{spanEndTag}{lineBreak}{lineBreak}\t"
	/// </summary>
	public override string DescriptionTwoStepVerificationLoginEmailHtmlGeolocationInfo2(string spanStartTagWithBold, string username, string country, string ipAddress, string spanEndTag, string lineBreak)
	{
		return $"{spanStartTagWithBold}收到位於{country}，來自{username}的登入請求（{ipAddress}）。{spanEndTag}{lineBreak}{lineBreak}\t";
	}

	protected override string _GetTemplateForDescriptionTwoStepVerificationLoginEmailHtmlGeolocationInfo2()
	{
		return "{spanStartTagWithBold}收到位於{country}，來自{username}的登入請求（{ipAddress}）。{spanEndTag}{lineBreak}{lineBreak}\t";
	}

	/// <summary>
	/// Key: "Description.TwoStepVerificationLoginEmail.Html.GeolocationInfo3"
	/// Geolocation info about IP trying to log in
	/// English String: "{spanStartTagWithBold}Login request received from {username} (From Roblox Internal).{spanEndTag}{lineBreak}{lineBreak}\t"
	/// </summary>
	public override string DescriptionTwoStepVerificationLoginEmailHtmlGeolocationInfo3(string spanStartTagWithBold, string username, string spanEndTag, string lineBreak)
	{
		return $"{spanStartTagWithBold}收到來自 {username}的登入請求（來自Roblox 內部）。{spanEndTag}{lineBreak}{lineBreak}\t";
	}

	protected override string _GetTemplateForDescriptionTwoStepVerificationLoginEmailHtmlGeolocationInfo3()
	{
		return "{spanStartTagWithBold}收到來自 {username}的登入請求（來自Roblox 內部）。{spanEndTag}{lineBreak}{lineBreak}\t";
	}

	/// <summary>
	/// Key: "Description.TwoStepVerificationLoginEmail.Html.GeolocationInfo4"
	/// Geolocation info of IP trying to login
	/// English String: "{spanStartTagWithBold}Login request received from {username} located in {country}.{spanEndTag}{lineBreak}{lineBreak}"
	/// </summary>
	public override string DescriptionTwoStepVerificationLoginEmailHtmlGeolocationInfo4(string spanStartTagWithBold, string username, string country, string spanEndTag, string lineBreak)
	{
		return $"{spanStartTagWithBold}收到 {username} 來自{country}的登入請求。{spanEndTag}{lineBreak}{lineBreak}";
	}

	protected override string _GetTemplateForDescriptionTwoStepVerificationLoginEmailHtmlGeolocationInfo4()
	{
		return "{spanStartTagWithBold}收到 {username} 來自{country}的登入請求。{spanEndTag}{lineBreak}{lineBreak}";
	}

	/// <summary>
	/// Key: "Description.TwoStepVerificationLoginEmail.Html.GeolocationInfo5"
	/// Geolocation info of IP trying to login
	/// English String: "{spanStartTagWithBold}Login request received from {username} located in {region}, {country}.{spanEndTag}{lineBreak}{lineBreak}"
	/// </summary>
	public override string DescriptionTwoStepVerificationLoginEmailHtmlGeolocationInfo5(string spanStartTagWithBold, string username, string region, string country, string spanEndTag, string lineBreak)
	{
		return $"{spanStartTagWithBold}收到 {username} 來自{country}{region}的登入請求。{spanEndTag}{lineBreak}{lineBreak}";
	}

	protected override string _GetTemplateForDescriptionTwoStepVerificationLoginEmailHtmlGeolocationInfo5()
	{
		return "{spanStartTagWithBold}收到 {username} 來自{country}{region}的登入請求。{spanEndTag}{lineBreak}{lineBreak}";
	}

	/// <summary>
	/// Key: "Description.TwoStepVerificationLoginEmail.Html.GeolocationInfo6"
	/// Geolocation info of IP trying to login
	/// English String: "{spanStartTagWithBold}Login request received from {username} located in {city}, {region}, {country}.{spanEndTag}{lineBreak}{lineBreak}"
	/// </summary>
	public override string DescriptionTwoStepVerificationLoginEmailHtmlGeolocationInfo6(string spanStartTagWithBold, string username, string city, string region, string country, string spanEndTag, string lineBreak)
	{
		return $"{spanStartTagWithBold}收到 {username} 來自{country}{region}{city}的登入請求。{spanEndTag}{lineBreak}{lineBreak}";
	}

	protected override string _GetTemplateForDescriptionTwoStepVerificationLoginEmailHtmlGeolocationInfo6()
	{
		return "{spanStartTagWithBold}收到 {username} 來自{country}{region}{city}的登入請求。{spanEndTag}{lineBreak}{lineBreak}";
	}

	/// <summary>
	/// Key: "Description.TwoStepVerificationLoginEmail.HtmlBody"
	/// Html body for 2SV login email
	/// English String: "{geoLocationInformation}{spanStartTagWithBold}Login code for {accountName}: {lineBreak}{lineBreak}{code} {spanEndTag}{lineBreak}{lineBreak}Enter this code into the 2-Step Verification screen to finish logging in. This code will expire in 15 minutes.{lineBreak}{lineBreak}This email was sent because your account tried to login to Roblox from a new browser or device. If you haven't tried logging into Roblox, someone else may be trying to access your account. You are strongly advised to change your password if you did not generate this request.{lineBreak}{lineBreak}Resources:{lineBreak}{aTagStartWithHref}{ChangePasswordLink}{hrefEnd}Change Your Password{aTagEnd} {lineBreak}{aTagStartWithHref}{TwoStepVerificationArticleLink}{hrefEnd}Learn More About 2-Step Verification{aTagEnd} {lineBreak}{aTagStartWithHref}{AccountSafetyArticleLink}{hrefEnd}Keeping Your Account Safe{aTagEnd} {lineBreak}{aTagStartWithHref}{SupportLink}{hrefEnd}General Roblox Support{aTagEnd} {lineBreak}{lineBreak}Thank you,{lineBreak}{lineBreak}The Roblox Team"
	/// </summary>
	public override string DescriptionTwoStepVerificationLoginEmailHtmlBody(string geoLocationInformation, string spanStartTagWithBold, string accountName, string lineBreak, string code, string spanEndTag, string aTagStartWithHref, string ChangePasswordLink, string hrefEnd, string aTagEnd, string TwoStepVerificationArticleLink, string AccountSafetyArticleLink, string SupportLink)
	{
		return $"{geoLocationInformation}{spanStartTagWithBold}{accountName}的登入代碼：{lineBreak}{lineBreak}{code} {spanEndTag}{lineBreak}{lineBreak}在 2 步驟驗證畫面輸入此代碼可完成登入。此代碼將在 15 分鐘後到期。{lineBreak}{lineBreak}寄送此電子郵件是因為正在嘗試從新的瀏覽器或裝置以您的帳戶登入 Roblox。若您並未嘗試登入 Roblox，可能有其他人試圖存取您的帳戶。若您並未發出此要求，極力建議您變更密碼。{lineBreak}{lineBreak}資源：{lineBreak}{aTagStartWithHref}{ChangePasswordLink}{hrefEnd}變更您的密碼{aTagEnd} {lineBreak}{aTagStartWithHref}{TwoStepVerificationArticleLink}{hrefEnd}進一步瞭解 2 步驟驗證{aTagEnd} {lineBreak}{aTagStartWithHref}{AccountSafetyArticleLink}{hrefEnd}保持您的帳戶安全{aTagEnd} {lineBreak}{aTagStartWithHref}{SupportLink}{hrefEnd}一般 Roblox 支援{aTagEnd} {lineBreak}{lineBreak}感謝您{lineBreak}{lineBreak}Roblox 團隊敬上";
	}

	protected override string _GetTemplateForDescriptionTwoStepVerificationLoginEmailHtmlBody()
	{
		return "{geoLocationInformation}{spanStartTagWithBold}{accountName}的登入代碼：{lineBreak}{lineBreak}{code} {spanEndTag}{lineBreak}{lineBreak}在 2 步驟驗證畫面輸入此代碼可完成登入。此代碼將在 15 分鐘後到期。{lineBreak}{lineBreak}寄送此電子郵件是因為正在嘗試從新的瀏覽器或裝置以您的帳戶登入 Roblox。若您並未嘗試登入 Roblox，可能有其他人試圖存取您的帳戶。若您並未發出此要求，極力建議您變更密碼。{lineBreak}{lineBreak}資源：{lineBreak}{aTagStartWithHref}{ChangePasswordLink}{hrefEnd}變更您的密碼{aTagEnd} {lineBreak}{aTagStartWithHref}{TwoStepVerificationArticleLink}{hrefEnd}進一步瞭解 2 步驟驗證{aTagEnd} {lineBreak}{aTagStartWithHref}{AccountSafetyArticleLink}{hrefEnd}保持您的帳戶安全{aTagEnd} {lineBreak}{aTagStartWithHref}{SupportLink}{hrefEnd}一般 Roblox 支援{aTagEnd} {lineBreak}{lineBreak}感謝您{lineBreak}{lineBreak}Roblox 團隊敬上";
	}

	/// <summary>
	/// Key: "Description.TwoStepVerificationLoginEmail.PlainBody"
	/// Plain body for 2SV login email
	/// English String: "{geoLocationInformation}Login code for {accountName}: {lineBreak}{lineBreak} {code} {lineBreak}{lineBreak}Enter this code into the 2-Step Verification screen to finish logging in. This code will expire in 15 minutes. {lineBreak}{lineBreak}This email was sent because your account tried to login to Roblox from a new browser or device. If you haven't tried logging into Roblox, someone else may be trying to access your account. You are strongly advised to change your password if you did not generate this request. {lineBreak}{lineBreak}Resources: {lineBreak}Change Your Password [{accountInfoPageLink}] {lineBreak}Learn More About 2-Step Verification [{twoStepVerificationHelpArticleLink}]{lineBreak}Keeping Your Account Safe [{keepAccountSafeArticleLink}] {lineBreak}General Roblox Support [{supportPageLink}] {lineBreak}{lineBreak}Thank you, {lineBreak}{lineBreak}The Roblox Team"
	/// </summary>
	public override string DescriptionTwoStepVerificationLoginEmailPlainBody(string geoLocationInformation, string accountName, string lineBreak, string code, string accountInfoPageLink, string twoStepVerificationHelpArticleLink, string keepAccountSafeArticleLink, string supportPageLink)
	{
		return $"{geoLocationInformation}{accountName}的登入代碼：{lineBreak}{lineBreak} {code} {lineBreak}{lineBreak}在 2 步驟驗證畫面輸入此代碼可完成登入。此代碼將在 15 分鐘後到期。{lineBreak}{lineBreak}寄送此電子郵件是因為正在嘗試從新的瀏覽器或裝置以您的帳戶登入 Roblox。若您並未嘗試登入 Roblox，可能有其他人試圖存取您的帳戶。若您並未發出此要求，極力建議您變更密碼。{lineBreak}{lineBreak}資源：{lineBreak}變更您的密碼 [{accountInfoPageLink}] {lineBreak}進一步瞭解 2 步驟驗證 [{twoStepVerificationHelpArticleLink}]{lineBreak}保持您的帳戶安全 [{keepAccountSafeArticleLink}] {lineBreak}一般 Roblox 支援 [{supportPageLink}] {lineBreak}{lineBreak}感謝您{lineBreak}{lineBreak}Roblox 團隊敬上";
	}

	protected override string _GetTemplateForDescriptionTwoStepVerificationLoginEmailPlainBody()
	{
		return "{geoLocationInformation}{accountName}的登入代碼：{lineBreak}{lineBreak} {code} {lineBreak}{lineBreak}在 2 步驟驗證畫面輸入此代碼可完成登入。此代碼將在 15 分鐘後到期。{lineBreak}{lineBreak}寄送此電子郵件是因為正在嘗試從新的瀏覽器或裝置以您的帳戶登入 Roblox。若您並未嘗試登入 Roblox，可能有其他人試圖存取您的帳戶。若您並未發出此要求，極力建議您變更密碼。{lineBreak}{lineBreak}資源：{lineBreak}變更您的密碼 [{accountInfoPageLink}] {lineBreak}進一步瞭解 2 步驟驗證 [{twoStepVerificationHelpArticleLink}]{lineBreak}保持您的帳戶安全 [{keepAccountSafeArticleLink}] {lineBreak}一般 Roblox 支援 [{supportPageLink}] {lineBreak}{lineBreak}感謝您{lineBreak}{lineBreak}Roblox 團隊敬上";
	}

	/// <summary>
	/// Key: "Description.TwoStepVerificationLoginEmail.PlainText.GeolocationInfo1"
	/// GeoLocation info of IP trying to login
	/// English String: "Login request received from {username} located in {region}, {country} ({ipAddress}).{lineBreak}{lineBreak}"
	/// </summary>
	public override string DescriptionTwoStepVerificationLoginEmailPlainTextGeolocationInfo1(string username, string region, string country, string ipAddress, string lineBreak)
	{
		return $"收到位於{country}、{region}（{ipAddress}），來自{username}的登入請求。{lineBreak}{lineBreak}";
	}

	protected override string _GetTemplateForDescriptionTwoStepVerificationLoginEmailPlainTextGeolocationInfo1()
	{
		return "收到位於{country}、{region}（{ipAddress}），來自{username}的登入請求。{lineBreak}{lineBreak}";
	}

	/// <summary>
	/// Key: "Description.TwoStepVerificationLoginEmail.PlainText.GeolocationInfo2"
	/// Geolocation info of IP trying to login
	/// English String: "Login request received from {username} located in {country} ({ipAddress}).{lineBreak}{lineBreak}"
	/// </summary>
	public override string DescriptionTwoStepVerificationLoginEmailPlainTextGeolocationInfo2(string username, string country, string ipAddress, string lineBreak)
	{
		return $"收到 {username} 來自{country}的登入請求（{ipAddress}）。{lineBreak}{lineBreak}";
	}

	protected override string _GetTemplateForDescriptionTwoStepVerificationLoginEmailPlainTextGeolocationInfo2()
	{
		return "收到 {username} 來自{country}的登入請求（{ipAddress}）。{lineBreak}{lineBreak}";
	}

	/// <summary>
	/// Key: "Description.TwoStepVerificationLoginEmail.PlainText.GeolocationInfo3"
	/// Geolocation info of IP trying to login
	/// English String: "Login request received from {username} (From Roblox Internal).{lineBreak}{lineBreak}"
	/// </summary>
	public override string DescriptionTwoStepVerificationLoginEmailPlainTextGeolocationInfo3(string username, string lineBreak)
	{
		return $"收到 {username} 來自 Roblox 內部的登入請求。{lineBreak}{lineBreak}";
	}

	protected override string _GetTemplateForDescriptionTwoStepVerificationLoginEmailPlainTextGeolocationInfo3()
	{
		return "收到 {username} 來自 Roblox 內部的登入請求。{lineBreak}{lineBreak}";
	}

	/// <summary>
	/// Key: "Description.TwoStepVerificationLoginEmail.PlainText.GeolocationInfo4"
	/// Geolocation info of IP trying to login
	/// English String: "Login request received from {username} located in {country}.{lineBreak}{lineBreak}"
	/// </summary>
	public override string DescriptionTwoStepVerificationLoginEmailPlainTextGeolocationInfo4(string username, string country, string lineBreak)
	{
		return $"收到 {username} 來自{country}的登入請求。{lineBreak}{lineBreak}";
	}

	protected override string _GetTemplateForDescriptionTwoStepVerificationLoginEmailPlainTextGeolocationInfo4()
	{
		return "收到 {username} 來自{country}的登入請求。{lineBreak}{lineBreak}";
	}

	/// <summary>
	/// Key: "Description.TwoStepVerificationLoginEmail.PlainText.GeolocationInfo5"
	/// Geolocation info of IP trying to login
	/// English String: "Login request received from {username} located in {region}, {country}.{lineBreak}{lineBreak}"
	/// </summary>
	public override string DescriptionTwoStepVerificationLoginEmailPlainTextGeolocationInfo5(string username, string region, string country, string lineBreak)
	{
		return $"收到 {username} 來自{country}{region}的登入請求。{lineBreak}{lineBreak}";
	}

	protected override string _GetTemplateForDescriptionTwoStepVerificationLoginEmailPlainTextGeolocationInfo5()
	{
		return "收到 {username} 來自{country}{region}的登入請求。{lineBreak}{lineBreak}";
	}

	/// <summary>
	/// Key: "Description.TwoStepVerificationLoginEmail.PlainText.GeolocationInfo6"
	/// Geolocation info of IP trying to login
	/// English String: "Login request received from {username} located in {city}, {region}, {country}.{lineBreak}{lineBreak}"
	/// </summary>
	public override string DescriptionTwoStepVerificationLoginEmailPlainTextGeolocationInfo6(string username, string city, string region, string country, string lineBreak)
	{
		return $"收到 {username} 來自{country}{region}{city}的登入請求。{lineBreak}{lineBreak}";
	}

	protected override string _GetTemplateForDescriptionTwoStepVerificationLoginEmailPlainTextGeolocationInfo6()
	{
		return "收到 {username} 來自{country}{region}{city}的登入請求。{lineBreak}{lineBreak}";
	}

	/// <summary>
	/// Key: "Description.TwoStepVerificationLoginEmail.Subject"
	/// Subject for 2SV login email
	/// English String: "Verification Code for Roblox Account: {accountName}"
	/// </summary>
	public override string DescriptionTwoStepVerificationLoginEmailSubject(string accountName)
	{
		return $"Roblox 帳號 {accountName} 的驗證碼";
	}

	protected override string _GetTemplateForDescriptionTwoStepVerificationLoginEmailSubject()
	{
		return "Roblox 帳號 {accountName} 的驗證碼";
	}

	protected override string _GetTemplateForLabelCode()
	{
		return "驗證碼";
	}

	/// <summary>
	/// Key: "Label.CodeInputPlaceholderText"
	/// example: Enter 4-digit code
	/// English String: "Enter {codeLength}-digit Code"
	/// </summary>
	public override string LabelCodeInputPlaceholderText(string codeLength)
	{
		return $"輸入 {codeLength} 位數驗證碼";
	}

	protected override string _GetTemplateForLabelCodeInputPlaceholderText()
	{
		return "輸入 {codeLength} 位數驗證碼";
	}

	protected override string _GetTemplateForLabelDidNotReceive()
	{
		return "沒有收到代碼？";
	}

	protected override string _GetTemplateForLabelEnterCode()
	{
		return "輸入驗證碼（6 位數）";
	}

	protected override string _GetTemplateForLabelEnterEmailCode()
	{
		return "請輸入傳送到您的電子郵件信箱的驗證碼";
	}

	protected override string _GetTemplateForLabelEnterTextCode()
	{
		return "請輸入傳送到您的手機的驗證碼";
	}

	protected override string _GetTemplateForLabelEnterTwoStepVerificationCode()
	{
		return "請輸入雙步驟驗證碼。";
	}

	protected override string _GetTemplateForLabelFacebookPasswordWarning()
	{
		return "若您以 Facebook 登入，請設定密碼。";
	}

	protected override string _GetTemplateForLabelLearnMore()
	{
		return "了解更多";
	}

	/// <summary>
	/// Key: "Label.NeedHelpContactSupport"
	/// label for the support article link
	/// English String: "Need help? Contact {supportLink}"
	/// </summary>
	public override string LabelNeedHelpContactSupport(string supportLink)
	{
		return $"需要協助？請聯絡{supportLink}";
	}

	protected override string _GetTemplateForLabelNeedHelpContactSupport()
	{
		return "需要協助？請聯絡{supportLink}";
	}

	protected override string _GetTemplateForLabelNewCode()
	{
		return "新驗證碼";
	}

	protected override string _GetTemplateForLabelRobloxSupport()
	{
		return "Roblox 協助";
	}

	protected override string _GetTemplateForLabelTrustThisDevice()
	{
		return "信任此裝置 30 天";
	}

	protected override string _GetTemplateForLabelTwoStepVerification()
	{
		return "雙步驟驗證";
	}

	protected override string _GetTemplateForResponseCodeSent()
	{
		return "驗證碼已傳送";
	}

	protected override string _GetTemplateForResponseFeatureNotAvailable()
	{
		return "無法使用此功能，請聯絡客服人員。";
	}

	protected override string _GetTemplateForResponseInvalidCode()
	{
		return "驗證碼無效。";
	}

	protected override string _GetTemplateForResponseSystemErrorReturnToLogin()
	{
		return "系統錯誤，請返回登入畫面。";
	}

	protected override string _GetTemplateForResponseTooManyAttempts()
	{
		return "嘗試次數過多，請稍後再試。";
	}

	protected override string _GetTemplateForResponseTooManyCharacters()
	{
		return "字元過多";
	}
}
