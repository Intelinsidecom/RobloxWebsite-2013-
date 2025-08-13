namespace Roblox.TranslationResources.Authentication;

/// <summary>
/// This class overrides TwoStepVerificationResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class TwoStepVerificationResources_zh_cjv : TwoStepVerificationResources_en_us, ITwoStepVerificationResources, ITranslationResources
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
	public override string ActionResend => "重新发送验证码";

	/// <summary>
	/// Key: "Action.StartOver"
	/// link text to restart verification
	/// English String: "Start Over"
	/// </summary>
	public override string ActionStartOver => "重新开始";

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
	public override string ActionVerify => "验证";

	/// <summary>
	/// Key: "Label.Code"
	/// verification code for 2 factor authentication
	/// English String: "Code"
	/// </summary>
	public override string LabelCode => "验证码";

	/// <summary>
	/// Key: "Label.DidNotReceive"
	/// English String: "Didn't receive the code?"
	/// </summary>
	public override string LabelDidNotReceive => "没收到验证码？";

	/// <summary>
	/// Key: "Label.EnterCode"
	/// English String: "Enter Code (6-digit)"
	/// </summary>
	public override string LabelEnterCode => "输入验证码（6 位）";

	/// <summary>
	/// Key: "Label.EnterEmailCode"
	/// English String: "Enter the code we just sent you via email"
	/// </summary>
	public override string LabelEnterEmailCode => "请输入我们通过电子邮件发送给你的验证码";

	/// <summary>
	/// Key: "Label.EnterTextCode"
	/// English String: "Enter the code we just sent you via text message"
	/// </summary>
	public override string LabelEnterTextCode => "请输入我们通过短信发送给你的验证码";

	/// <summary>
	/// Key: "Label.EnterTwoStepVerificationCode"
	/// Enter your two step verification code.
	/// English String: "Enter your two step verification code."
	/// </summary>
	public override string LabelEnterTwoStepVerificationCode => "输入你的两步验证码。";

	/// <summary>
	/// Key: "Label.FacebookPasswordWarning"
	/// If you have been signing in with Facebook, you must set a password.
	/// English String: "If you have been signing in with Facebook, you must set a password."
	/// </summary>
	public override string LabelFacebookPasswordWarning => "如果你使用 Facebook 登录，则必须设定密码。";

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
	public override string LabelNewCode => "新验证码";

	/// <summary>
	/// Key: "Label.RobloxSupport"
	/// English String: "Roblox Support"
	/// </summary>
	public override string LabelRobloxSupport => "Roblox 支持";

	/// <summary>
	/// Key: "Label.TrustThisDevice"
	/// English String: "Trust this device for 30 days"
	/// </summary>
	public override string LabelTrustThisDevice => "信任此装置 30 天";

	/// <summary>
	/// Key: "Label.TwoStepVerification"
	/// English String: "2-Step Verification"
	/// </summary>
	public override string LabelTwoStepVerification => "两步验证";

	/// <summary>
	/// Key: "Response.CodeSent"
	/// English String: "Code Sent"
	/// </summary>
	public override string ResponseCodeSent => "验证码已发送";

	/// <summary>
	/// Key: "Response.FeatureNotAvailable"
	/// English String: "Feature not available. Please contact support."
	/// </summary>
	public override string ResponseFeatureNotAvailable => "功能不可用。请联系技术支持。";

	/// <summary>
	/// Key: "Response.InvalidCode"
	/// English String: "Invalid code."
	/// </summary>
	public override string ResponseInvalidCode => "验证码无效。";

	/// <summary>
	/// Key: "Response.SystemErrorReturnToLogin"
	/// English String: "System error. Please return to login screen."
	/// </summary>
	public override string ResponseSystemErrorReturnToLogin => "系统错误。请返回登录屏幕。";

	/// <summary>
	/// Key: "Response.TooManyAttempts"
	/// English String: "Too many attempts. Please try again later."
	/// </summary>
	public override string ResponseTooManyAttempts => "尝试次数过多。请稍后重试。";

	/// <summary>
	/// Key: "Response.TooManyCharacters"
	/// error message
	/// English String: "Too many characters"
	/// </summary>
	public override string ResponseTooManyCharacters => "字符过多";

	public TwoStepVerificationResources_zh_cjv(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionCancel()
	{
		return "取消";
	}

	protected override string _GetTemplateForActionResend()
	{
		return "重新发送验证码";
	}

	protected override string _GetTemplateForActionStartOver()
	{
		return "重新开始";
	}

	protected override string _GetTemplateForActionSubmit()
	{
		return "提交";
	}

	protected override string _GetTemplateForActionVerify()
	{
		return "验证";
	}

	/// <summary>
	/// Key: "Description.TwoStepVerificationActivationEmail.Body.Over13"
	/// Body for 2SV activation email for over 13 users
	/// English String: "Hi {accountName},{lineBreak}{lineBreak}You have activated 2-Step Verification for your Roblox account. Next time you log in from a new device, you will need to enter a 6-digit security code that Roblox sends to you via email.{lineBreak}{lineBreak}Roblox"
	/// </summary>
	public override string DescriptionTwoStepVerificationActivationEmailBodyOver13(string accountName, string lineBreak)
	{
		return $"你好，{accountName}：{lineBreak}{lineBreak}你已成功为你的 Roblox 帐户激活两步验证。下次当你从新设备登录时，你将需要输入 Roblox 通过电子邮件发送给你的 6 位安全代码。{lineBreak}{lineBreak}Roblox";
	}

	protected override string _GetTemplateForDescriptionTwoStepVerificationActivationEmailBodyOver13()
	{
		return "你好，{accountName}：{lineBreak}{lineBreak}你已成功为你的 Roblox 帐户激活两步验证。下次当你从新设备登录时，你将需要输入 Roblox 通过电子邮件发送给你的 6 位安全代码。{lineBreak}{lineBreak}Roblox";
	}

	/// <summary>
	/// Key: "Description.TwoStepVerificationActivationEmail.Body.Under13"
	/// Body for 2SV activation email for under 13 users
	/// English String: "Hi,{lineBreak}{lineBreak}2-Step Verification has been activated for your child's Roblox account, {accountName}. Next time they log in from a new device, they will need to enter a 6-digit security code that Roblox sends to you via email.{lineBreak}{lineBreak}Roblox"
	/// </summary>
	public override string DescriptionTwoStepVerificationActivationEmailBodyUnder13(string lineBreak, string accountName)
	{
		return $"您好，{lineBreak}{lineBreak}已为您孩子的帐户：{accountName} 激活两步认证。当他们下次在新设备上登录时，他们将需要输入一个 6 位数的安全代码，Roblox 会通过电子邮件将此代码发送给您。{lineBreak}{lineBreak}Roblox";
	}

	protected override string _GetTemplateForDescriptionTwoStepVerificationActivationEmailBodyUnder13()
	{
		return "您好，{lineBreak}{lineBreak}已为您孩子的帐户：{accountName} 激活两步认证。当他们下次在新设备上登录时，他们将需要输入一个 6 位数的安全代码，Roblox 会通过电子邮件将此代码发送给您。{lineBreak}{lineBreak}Roblox";
	}

	/// <summary>
	/// Key: "Description.TwoStepVerificationActivationEmail.Subject"
	/// Subject for 2SV activation email
	/// English String: "2-Step Verification Activated for Roblox Account: {accountName}"
	/// </summary>
	public override string DescriptionTwoStepVerificationActivationEmailSubject(string accountName)
	{
		return $"已为 Roblox 帐户：{accountName} 激活两步验证";
	}

	protected override string _GetTemplateForDescriptionTwoStepVerificationActivationEmailSubject()
	{
		return "已为 Roblox 帐户：{accountName} 激活两步验证";
	}

	/// <summary>
	/// Key: "Description.TwoStepVerificationDeactivationEmail.Body.Over13"
	/// Body for 2SV deactivation email for over 13 users
	/// English String: "Hi {accountName},{lineBreak}{lineBreak}You have deactivated 2-Step Verification for your Roblox account. A security code will no longer be required when you log into your account.{lineBreak}{lineBreak}Roblox"
	/// </summary>
	public override string DescriptionTwoStepVerificationDeactivationEmailBodyOver13(string accountName, string lineBreak)
	{
		return $"你好，{accountName}：{lineBreak}{lineBreak}你已成功为你的 Roblox 帐户停用两步验证。当你登录你的帐户时，你将不再需要输入安全代码。{lineBreak}{lineBreak}Roblox";
	}

	protected override string _GetTemplateForDescriptionTwoStepVerificationDeactivationEmailBodyOver13()
	{
		return "你好，{accountName}：{lineBreak}{lineBreak}你已成功为你的 Roblox 帐户停用两步验证。当你登录你的帐户时，你将不再需要输入安全代码。{lineBreak}{lineBreak}Roblox";
	}

	/// <summary>
	/// Key: "Description.TwoStepVerificationDeactivationEmail.Body.Under13"
	/// Body for 2SV deactivation email for under 13 users
	/// English String: "Hi,{lineBreak}{lineBreak}2-Step Verification has been deactivated for your child's Roblox account, {accountName}. A security code will no longer be required when they log into the account.{lineBreak}{lineBreak}Roblox"
	/// </summary>
	public override string DescriptionTwoStepVerificationDeactivationEmailBodyUnder13(string lineBreak, string accountName)
	{
		return $"您好，{lineBreak}{lineBreak}已为您孩子的帐户：{accountName} 停用两步认证。当他们登录他们的帐户时，将不再需要安全代码。{lineBreak}{lineBreak}Roblox";
	}

	protected override string _GetTemplateForDescriptionTwoStepVerificationDeactivationEmailBodyUnder13()
	{
		return "您好，{lineBreak}{lineBreak}已为您孩子的帐户：{accountName} 停用两步认证。当他们登录他们的帐户时，将不再需要安全代码。{lineBreak}{lineBreak}Roblox";
	}

	/// <summary>
	/// Key: "Description.TwoStepVerificationDeactivationEmail.Subject	"
	/// Subject for 2SV deactivation email
	/// English String: "2-Step Verification Deactivated for Roblox Account: {accountName}"
	/// </summary>
	public override string DescriptionTwoStepVerificationDeactivationEmailSubject(string accountName)
	{
		return $"已为 Roblox 帐户：{accountName} 停用两步验证";
	}

	protected override string _GetTemplateForDescriptionTwoStepVerificationDeactivationEmailSubject()
	{
		return "已为 Roblox 帐户：{accountName} 停用两步验证";
	}

	/// <summary>
	/// Key: "Description.TwoStepVerificationLoginEmail.Html.GeolocationInfo1"
	/// Geolocation information about IP trying to login
	/// English String: "{spanStartTagWithBold}Login request received from {username} located in {region}, {country} ({ipAddress}).{spanEndTag}{lineBreak}{lineBreak}"
	/// </summary>
	public override string DescriptionTwoStepVerificationLoginEmailHtmlGeolocationInfo1(string spanStartTagWithBold, string username, string region, string country, string ipAddress, string spanEndTag, string lineBreak)
	{
		return $"{spanStartTagWithBold}接收到来自{username}，位于{country} {region} ({ipAddress}) 的登录请求。{spanEndTag}{lineBreak}{lineBreak}";
	}

	protected override string _GetTemplateForDescriptionTwoStepVerificationLoginEmailHtmlGeolocationInfo1()
	{
		return "{spanStartTagWithBold}接收到来自{username}，位于{country} {region} ({ipAddress}) 的登录请求。{spanEndTag}{lineBreak}{lineBreak}";
	}

	/// <summary>
	/// Key: "Description.TwoStepVerificationLoginEmail.Html.GeolocationInfo2"
	/// Geolocation info about IP trying to login
	/// English String: "{spanStartTagWithBold}Login request received from {username} located in {country} ({ipAddress}).{spanEndTag}{lineBreak}{lineBreak}\t"
	/// </summary>
	public override string DescriptionTwoStepVerificationLoginEmailHtmlGeolocationInfo2(string spanStartTagWithBold, string username, string country, string ipAddress, string spanEndTag, string lineBreak)
	{
		return $"{spanStartTagWithBold}接收到来自{username}，位于{country} ({ipAddress}) 的登录请求。{spanEndTag}{lineBreak}{lineBreak}";
	}

	protected override string _GetTemplateForDescriptionTwoStepVerificationLoginEmailHtmlGeolocationInfo2()
	{
		return "{spanStartTagWithBold}接收到来自{username}，位于{country} ({ipAddress}) 的登录请求。{spanEndTag}{lineBreak}{lineBreak}";
	}

	/// <summary>
	/// Key: "Description.TwoStepVerificationLoginEmail.Html.GeolocationInfo3"
	/// Geolocation info about IP trying to log in
	/// English String: "{spanStartTagWithBold}Login request received from {username} (From Roblox Internal).{spanEndTag}{lineBreak}{lineBreak}\t"
	/// </summary>
	public override string DescriptionTwoStepVerificationLoginEmailHtmlGeolocationInfo3(string spanStartTagWithBold, string username, string spanEndTag, string lineBreak)
	{
		return $"{spanStartTagWithBold}接收到来自{username}（从 Roblox 内部）的登录请求。{spanEndTag}{lineBreak}{lineBreak}";
	}

	protected override string _GetTemplateForDescriptionTwoStepVerificationLoginEmailHtmlGeolocationInfo3()
	{
		return "{spanStartTagWithBold}接收到来自{username}（从 Roblox 内部）的登录请求。{spanEndTag}{lineBreak}{lineBreak}";
	}

	/// <summary>
	/// Key: "Description.TwoStepVerificationLoginEmail.Html.GeolocationInfo4"
	/// Geolocation info of IP trying to login
	/// English String: "{spanStartTagWithBold}Login request received from {username} located in {country}.{spanEndTag}{lineBreak}{lineBreak}"
	/// </summary>
	public override string DescriptionTwoStepVerificationLoginEmailHtmlGeolocationInfo4(string spanStartTagWithBold, string username, string country, string spanEndTag, string lineBreak)
	{
		return $"{spanStartTagWithBold}接收到来自{username}，位于{country}的登录请求。{spanEndTag}{lineBreak}{lineBreak}";
	}

	protected override string _GetTemplateForDescriptionTwoStepVerificationLoginEmailHtmlGeolocationInfo4()
	{
		return "{spanStartTagWithBold}接收到来自{username}，位于{country}的登录请求。{spanEndTag}{lineBreak}{lineBreak}";
	}

	/// <summary>
	/// Key: "Description.TwoStepVerificationLoginEmail.Html.GeolocationInfo5"
	/// Geolocation info of IP trying to login
	/// English String: "{spanStartTagWithBold}Login request received from {username} located in {region}, {country}.{spanEndTag}{lineBreak}{lineBreak}"
	/// </summary>
	public override string DescriptionTwoStepVerificationLoginEmailHtmlGeolocationInfo5(string spanStartTagWithBold, string username, string region, string country, string spanEndTag, string lineBreak)
	{
		return $"{spanStartTagWithBold}接收到来自{username}，位于{country}{region}的登录请求。{spanEndTag}{lineBreak}{lineBreak}";
	}

	protected override string _GetTemplateForDescriptionTwoStepVerificationLoginEmailHtmlGeolocationInfo5()
	{
		return "{spanStartTagWithBold}接收到来自{username}，位于{country}{region}的登录请求。{spanEndTag}{lineBreak}{lineBreak}";
	}

	/// <summary>
	/// Key: "Description.TwoStepVerificationLoginEmail.Html.GeolocationInfo6"
	/// Geolocation info of IP trying to login
	/// English String: "{spanStartTagWithBold}Login request received from {username} located in {city}, {region}, {country}.{spanEndTag}{lineBreak}{lineBreak}"
	/// </summary>
	public override string DescriptionTwoStepVerificationLoginEmailHtmlGeolocationInfo6(string spanStartTagWithBold, string username, string city, string region, string country, string spanEndTag, string lineBreak)
	{
		return $"{spanStartTagWithBold}接收到来自{username}，位于{country}{region}{city}的登录请求。{spanEndTag}{lineBreak}{lineBreak}";
	}

	protected override string _GetTemplateForDescriptionTwoStepVerificationLoginEmailHtmlGeolocationInfo6()
	{
		return "{spanStartTagWithBold}接收到来自{username}，位于{country}{region}{city}的登录请求。{spanEndTag}{lineBreak}{lineBreak}";
	}

	/// <summary>
	/// Key: "Description.TwoStepVerificationLoginEmail.HtmlBody"
	/// Html body for 2SV login email
	/// English String: "{geoLocationInformation}{spanStartTagWithBold}Login code for {accountName}: {lineBreak}{lineBreak}{code} {spanEndTag}{lineBreak}{lineBreak}Enter this code into the 2-Step Verification screen to finish logging in. This code will expire in 15 minutes.{lineBreak}{lineBreak}This email was sent because your account tried to login to Roblox from a new browser or device. If you haven't tried logging into Roblox, someone else may be trying to access your account. You are strongly advised to change your password if you did not generate this request.{lineBreak}{lineBreak}Resources:{lineBreak}{aTagStartWithHref}{ChangePasswordLink}{hrefEnd}Change Your Password{aTagEnd} {lineBreak}{aTagStartWithHref}{TwoStepVerificationArticleLink}{hrefEnd}Learn More About 2-Step Verification{aTagEnd} {lineBreak}{aTagStartWithHref}{AccountSafetyArticleLink}{hrefEnd}Keeping Your Account Safe{aTagEnd} {lineBreak}{aTagStartWithHref}{SupportLink}{hrefEnd}General Roblox Support{aTagEnd} {lineBreak}{lineBreak}Thank you,{lineBreak}{lineBreak}The Roblox Team"
	/// </summary>
	public override string DescriptionTwoStepVerificationLoginEmailHtmlBody(string geoLocationInformation, string spanStartTagWithBold, string accountName, string lineBreak, string code, string spanEndTag, string aTagStartWithHref, string ChangePasswordLink, string hrefEnd, string aTagEnd, string TwoStepVerificationArticleLink, string AccountSafetyArticleLink, string SupportLink)
	{
		return $"{geoLocationInformation}{spanStartTagWithBold}{accountName} 的登录代码： {lineBreak}{lineBreak}{code}{spanEndTag}{lineBreak}{lineBreak}在两步验证屏幕输入此代码，以完成登录。此代码将于 15 分钟后过期。{lineBreak}{lineBreak}发送此电子邮件，是由于你的帐户试图从新的浏览器或设备登录 Roblox。如果你还没有尝试登录 Roblox，那么其他人可能正尝试访问你的帐户。如果你从未提交过此请求，我们强烈建议你更改密码。{lineBreak}{lineBreak}资源：{lineBreak}{aTagStartWithHref}{ChangePasswordLink}{hrefEnd}更改你的密码{aTagEnd}{lineBreak}{aTagStartWithHref}{TwoStepVerificationArticleLink}{hrefEnd}进一步了解两步验证{aTagEnd}{lineBreak}{aTagStartWithHref}{AccountSafetyArticleLink}{hrefEnd}保持你的帐户安全{aTagEnd}{lineBreak}{aTagStartWithHref}{SupportLink}{hrefEnd}Roblox 常规技术支持{aTagEnd}{lineBreak}{lineBreak}谢谢！{lineBreak}{lineBreak}Roblox 团队";
	}

	protected override string _GetTemplateForDescriptionTwoStepVerificationLoginEmailHtmlBody()
	{
		return "{geoLocationInformation}{spanStartTagWithBold}{accountName} 的登录代码： {lineBreak}{lineBreak}{code}{spanEndTag}{lineBreak}{lineBreak}在两步验证屏幕输入此代码，以完成登录。此代码将于 15 分钟后过期。{lineBreak}{lineBreak}发送此电子邮件，是由于你的帐户试图从新的浏览器或设备登录 Roblox。如果你还没有尝试登录 Roblox，那么其他人可能正尝试访问你的帐户。如果你从未提交过此请求，我们强烈建议你更改密码。{lineBreak}{lineBreak}资源：{lineBreak}{aTagStartWithHref}{ChangePasswordLink}{hrefEnd}更改你的密码{aTagEnd}{lineBreak}{aTagStartWithHref}{TwoStepVerificationArticleLink}{hrefEnd}进一步了解两步验证{aTagEnd}{lineBreak}{aTagStartWithHref}{AccountSafetyArticleLink}{hrefEnd}保持你的帐户安全{aTagEnd}{lineBreak}{aTagStartWithHref}{SupportLink}{hrefEnd}Roblox 常规技术支持{aTagEnd}{lineBreak}{lineBreak}谢谢！{lineBreak}{lineBreak}Roblox 团队";
	}

	/// <summary>
	/// Key: "Description.TwoStepVerificationLoginEmail.PlainBody"
	/// Plain body for 2SV login email
	/// English String: "{geoLocationInformation}Login code for {accountName}: {lineBreak}{lineBreak} {code} {lineBreak}{lineBreak}Enter this code into the 2-Step Verification screen to finish logging in. This code will expire in 15 minutes. {lineBreak}{lineBreak}This email was sent because your account tried to login to Roblox from a new browser or device. If you haven't tried logging into Roblox, someone else may be trying to access your account. You are strongly advised to change your password if you did not generate this request. {lineBreak}{lineBreak}Resources: {lineBreak}Change Your Password [{accountInfoPageLink}] {lineBreak}Learn More About 2-Step Verification [{twoStepVerificationHelpArticleLink}]{lineBreak}Keeping Your Account Safe [{keepAccountSafeArticleLink}] {lineBreak}General Roblox Support [{supportPageLink}] {lineBreak}{lineBreak}Thank you, {lineBreak}{lineBreak}The Roblox Team"
	/// </summary>
	public override string DescriptionTwoStepVerificationLoginEmailPlainBody(string geoLocationInformation, string accountName, string lineBreak, string code, string accountInfoPageLink, string twoStepVerificationHelpArticleLink, string keepAccountSafeArticleLink, string supportPageLink)
	{
		return $"{geoLocationInformation}{accountName} 的登录代码： {lineBreak}{lineBreak}{code}{lineBreak}{lineBreak}在两步验证屏幕输入此代码，以完成登录。此代码将于 15 分钟后过期。 {lineBreak}{lineBreak}发送此电子邮件，是由于你的帐户试图从新的浏览器或设备登录 Roblox。如果你还没有尝试登录 Roblox，那么其他人可能正在尝试访问你的帐户。如果你从未提交过此请求，我们强烈建议你更改密码。 {lineBreak}{lineBreak}资源：{lineBreak}更改你的密码[{accountInfoPageLink}] {lineBreak}进一步了解两步验证[{twoStepVerificationHelpArticleLink}]{lineBreak}保持你的帐户安全 [{keepAccountSafeArticleLink}] {lineBreak}Roblox 常规技术支持 [{supportPageLink}] {lineBreak}{lineBreak}谢谢！ {lineBreak}{lineBreak}Roblox 团队";
	}

	protected override string _GetTemplateForDescriptionTwoStepVerificationLoginEmailPlainBody()
	{
		return "{geoLocationInformation}{accountName} 的登录代码： {lineBreak}{lineBreak}{code}{lineBreak}{lineBreak}在两步验证屏幕输入此代码，以完成登录。此代码将于 15 分钟后过期。 {lineBreak}{lineBreak}发送此电子邮件，是由于你的帐户试图从新的浏览器或设备登录 Roblox。如果你还没有尝试登录 Roblox，那么其他人可能正在尝试访问你的帐户。如果你从未提交过此请求，我们强烈建议你更改密码。 {lineBreak}{lineBreak}资源：{lineBreak}更改你的密码[{accountInfoPageLink}] {lineBreak}进一步了解两步验证[{twoStepVerificationHelpArticleLink}]{lineBreak}保持你的帐户安全 [{keepAccountSafeArticleLink}] {lineBreak}Roblox 常规技术支持 [{supportPageLink}] {lineBreak}{lineBreak}谢谢！ {lineBreak}{lineBreak}Roblox 团队";
	}

	/// <summary>
	/// Key: "Description.TwoStepVerificationLoginEmail.PlainText.GeolocationInfo1"
	/// GeoLocation info of IP trying to login
	/// English String: "Login request received from {username} located in {region}, {country} ({ipAddress}).{lineBreak}{lineBreak}"
	/// </summary>
	public override string DescriptionTwoStepVerificationLoginEmailPlainTextGeolocationInfo1(string username, string region, string country, string ipAddress, string lineBreak)
	{
		return $"接收到来自{username}，位于{country} {region} ({ipAddress}) 的登录请求。{lineBreak}{lineBreak}";
	}

	protected override string _GetTemplateForDescriptionTwoStepVerificationLoginEmailPlainTextGeolocationInfo1()
	{
		return "接收到来自{username}，位于{country} {region} ({ipAddress}) 的登录请求。{lineBreak}{lineBreak}";
	}

	/// <summary>
	/// Key: "Description.TwoStepVerificationLoginEmail.PlainText.GeolocationInfo2"
	/// Geolocation info of IP trying to login
	/// English String: "Login request received from {username} located in {country} ({ipAddress}).{lineBreak}{lineBreak}"
	/// </summary>
	public override string DescriptionTwoStepVerificationLoginEmailPlainTextGeolocationInfo2(string username, string country, string ipAddress, string lineBreak)
	{
		return $"接收到来自{username}，位于{country} ({ipAddress}) 的登录请求。{lineBreak}{lineBreak}";
	}

	protected override string _GetTemplateForDescriptionTwoStepVerificationLoginEmailPlainTextGeolocationInfo2()
	{
		return "接收到来自{username}，位于{country} ({ipAddress}) 的登录请求。{lineBreak}{lineBreak}";
	}

	/// <summary>
	/// Key: "Description.TwoStepVerificationLoginEmail.PlainText.GeolocationInfo3"
	/// Geolocation info of IP trying to login
	/// English String: "Login request received from {username} (From Roblox Internal).{lineBreak}{lineBreak}"
	/// </summary>
	public override string DescriptionTwoStepVerificationLoginEmailPlainTextGeolocationInfo3(string username, string lineBreak)
	{
		return $"接收到来自{username}（从 Roblox 内部）的登录请求。{lineBreak}{lineBreak}";
	}

	protected override string _GetTemplateForDescriptionTwoStepVerificationLoginEmailPlainTextGeolocationInfo3()
	{
		return "接收到来自{username}（从 Roblox 内部）的登录请求。{lineBreak}{lineBreak}";
	}

	/// <summary>
	/// Key: "Description.TwoStepVerificationLoginEmail.PlainText.GeolocationInfo4"
	/// Geolocation info of IP trying to login
	/// English String: "Login request received from {username} located in {country}.{lineBreak}{lineBreak}"
	/// </summary>
	public override string DescriptionTwoStepVerificationLoginEmailPlainTextGeolocationInfo4(string username, string country, string lineBreak)
	{
		return $"接收到来自{username}，位于{country}的登录请求。{lineBreak}{lineBreak}";
	}

	protected override string _GetTemplateForDescriptionTwoStepVerificationLoginEmailPlainTextGeolocationInfo4()
	{
		return "接收到来自{username}，位于{country}的登录请求。{lineBreak}{lineBreak}";
	}

	/// <summary>
	/// Key: "Description.TwoStepVerificationLoginEmail.PlainText.GeolocationInfo5"
	/// Geolocation info of IP trying to login
	/// English String: "Login request received from {username} located in {region}, {country}.{lineBreak}{lineBreak}"
	/// </summary>
	public override string DescriptionTwoStepVerificationLoginEmailPlainTextGeolocationInfo5(string username, string region, string country, string lineBreak)
	{
		return $"接收到来自{username}，位于{country}{region}的登录请求。{lineBreak}{lineBreak}";
	}

	protected override string _GetTemplateForDescriptionTwoStepVerificationLoginEmailPlainTextGeolocationInfo5()
	{
		return "接收到来自{username}，位于{country}{region}的登录请求。{lineBreak}{lineBreak}";
	}

	/// <summary>
	/// Key: "Description.TwoStepVerificationLoginEmail.PlainText.GeolocationInfo6"
	/// Geolocation info of IP trying to login
	/// English String: "Login request received from {username} located in {city}, {region}, {country}.{lineBreak}{lineBreak}"
	/// </summary>
	public override string DescriptionTwoStepVerificationLoginEmailPlainTextGeolocationInfo6(string username, string city, string region, string country, string lineBreak)
	{
		return $"接收到来自{username}，位于{country}{region}{city}的登录请求。{lineBreak}{lineBreak}";
	}

	protected override string _GetTemplateForDescriptionTwoStepVerificationLoginEmailPlainTextGeolocationInfo6()
	{
		return "接收到来自{username}，位于{country}{region}{city}的登录请求。{lineBreak}{lineBreak}";
	}

	/// <summary>
	/// Key: "Description.TwoStepVerificationLoginEmail.Subject"
	/// Subject for 2SV login email
	/// English String: "Verification Code for Roblox Account: {accountName}"
	/// </summary>
	public override string DescriptionTwoStepVerificationLoginEmailSubject(string accountName)
	{
		return $"Roblox 帐户：{accountName} 的验证码";
	}

	protected override string _GetTemplateForDescriptionTwoStepVerificationLoginEmailSubject()
	{
		return "Roblox 帐户：{accountName} 的验证码";
	}

	protected override string _GetTemplateForLabelCode()
	{
		return "验证码";
	}

	/// <summary>
	/// Key: "Label.CodeInputPlaceholderText"
	/// example: Enter 4-digit code
	/// English String: "Enter {codeLength}-digit Code"
	/// </summary>
	public override string LabelCodeInputPlaceholderText(string codeLength)
	{
		return $"输入 {codeLength} 位验证码";
	}

	protected override string _GetTemplateForLabelCodeInputPlaceholderText()
	{
		return "输入 {codeLength} 位验证码";
	}

	protected override string _GetTemplateForLabelDidNotReceive()
	{
		return "没收到验证码？";
	}

	protected override string _GetTemplateForLabelEnterCode()
	{
		return "输入验证码（6 位）";
	}

	protected override string _GetTemplateForLabelEnterEmailCode()
	{
		return "请输入我们通过电子邮件发送给你的验证码";
	}

	protected override string _GetTemplateForLabelEnterTextCode()
	{
		return "请输入我们通过短信发送给你的验证码";
	}

	protected override string _GetTemplateForLabelEnterTwoStepVerificationCode()
	{
		return "输入你的两步验证码。";
	}

	protected override string _GetTemplateForLabelFacebookPasswordWarning()
	{
		return "如果你使用 Facebook 登录，则必须设定密码。";
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
		return $"需要帮助？请联系 {supportLink}";
	}

	protected override string _GetTemplateForLabelNeedHelpContactSupport()
	{
		return "需要帮助？请联系 {supportLink}";
	}

	protected override string _GetTemplateForLabelNewCode()
	{
		return "新验证码";
	}

	protected override string _GetTemplateForLabelRobloxSupport()
	{
		return "Roblox 支持";
	}

	protected override string _GetTemplateForLabelTrustThisDevice()
	{
		return "信任此装置 30 天";
	}

	protected override string _GetTemplateForLabelTwoStepVerification()
	{
		return "两步验证";
	}

	protected override string _GetTemplateForResponseCodeSent()
	{
		return "验证码已发送";
	}

	protected override string _GetTemplateForResponseFeatureNotAvailable()
	{
		return "功能不可用。请联系技术支持。";
	}

	protected override string _GetTemplateForResponseInvalidCode()
	{
		return "验证码无效。";
	}

	protected override string _GetTemplateForResponseSystemErrorReturnToLogin()
	{
		return "系统错误。请返回登录屏幕。";
	}

	protected override string _GetTemplateForResponseTooManyAttempts()
	{
		return "尝试次数过多。请稍后重试。";
	}

	protected override string _GetTemplateForResponseTooManyCharacters()
	{
		return "字符过多";
	}
}
