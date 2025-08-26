namespace Roblox.Platform.TranslationResources.Authentication {
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
	public override string ActionCancel => "Há»§y";

	/// <summary>
	/// Key: "Action.Resend"
	/// English String: "Resend Code"
	/// </summary>
	public override string ActionResend => "Gá»­i láº¡i mÃ£";

	/// <summary>
	/// Key: "Action.StartOver"
	/// link text to restart verification
	/// English String: "Start Over"
	/// </summary>
	public override string ActionStartOver => "Báº¯t Ä‘áº§u láº¡i";

	/// <summary>
	/// Key: "Action.Submit"
	/// submit button text
	/// English String: "Submit"
	/// </summary>
	public override string ActionSubmit => "Gá»­i";

	/// <summary>
	/// Key: "Action.Verify"
	/// English String: "Verify"
	/// </summary>
	public override string ActionVerify => "XÃ¡c minh";

	/// <summary>
	/// Key: "Label.Code"
	/// verification code for 2 factor authentication
	/// English String: "Code"
	/// </summary>
	public override string LabelCode => "MÃ£";

	/// <summary>
	/// Key: "Label.DidNotReceive"
	/// English String: "Didn't receive the code?"
	/// </summary>
	public override string LabelDidNotReceive => "Báº¡n khÃ´ng nháº­n Ä‘Æ°á»£c mÃ£?";

	/// <summary>
	/// Key: "Label.EnterCode"
	/// English String: "Enter Code (6-digit)"
	/// </summary>
	public override string LabelEnterCode => "Nháº­p mÃ£ (6 chá»¯ sá»‘)";

	/// <summary>
	/// Key: "Label.EnterEmailCode"
	/// English String: "Enter the code we just sent you via email"
	/// </summary>
	public override string LabelEnterEmailCode => "Nháº­p mÃ£ chÃºng tÃ´i vá»«a gá»­i cho báº¡n qua email";

	/// <summary>
	/// Key: "Label.EnterTextCode"
	/// English String: "Enter the code we just sent you via text message"
	/// </summary>
	public override string LabelEnterTextCode => "Nháº­p mÃ£ chÃºng tÃ´i vá»«a gá»­i cho báº¡n qua tin nháº¯n vÄƒn báº£n";

	/// <summary>
	/// Key: "Label.EnterTwoStepVerificationCode"
	/// Enter your two step verification code.
	/// English String: "Enter your two step verification code."
	/// </summary>
	public override string LabelEnterTwoStepVerificationCode => "Nháº­p mÃ£ xÃ¡c minh hai bÆ°á»›c cá»§a báº¡n.";

	/// <summary>
	/// Key: "Label.FacebookPasswordWarning"
	/// If you have been signing in with Facebook, you must set a password.
	/// English String: "If you have been signing in with Facebook, you must set a password."
	/// </summary>
	public override string LabelFacebookPasswordWarning => "Náº¿u báº¡n Ä‘Ã£ Ä‘Äƒng nháº­p báº±ng Facebook, báº¡n pháº£i Ä‘áº·t má»™t máº­t kháº©u.";

	/// <summary>
	/// Key: "Label.LearnMore"
	/// Learn More link text
	/// English String: "Learn More"
	/// </summary>
	public override string LabelLearnMore => "TÃ¬m hiá»ƒu thÃªm";

	/// <summary>
	/// Key: "Label.NewCode"
	/// verification code resent, label changes to new code
	/// English String: "New Code"
	/// </summary>
	public override string LabelNewCode => "MÃ£ má»›i";

	/// <summary>
	/// Key: "Label.RobloxSupport"
	/// English String: "Roblox Support"
	/// </summary>
	public override string LabelRobloxSupport => "Há»— trá»£ cá»§a Roblox";

	/// <summary>
	/// Key: "Label.TrustThisDevice"
	/// English String: "Trust this device for 30 days"
	/// </summary>
	public override string LabelTrustThisDevice => "Tin tÆ°á»Ÿng thiáº¿t bá»‹ nÃ y trong vÃ²ng 30 ngÃ y";

	/// <summary>
	/// Key: "Label.TwoStepVerification"
	/// English String: "2-Step Verification"
	/// </summary>
	public override string LabelTwoStepVerification => "XÃ¡c minh 2 bÆ°á»›c";

	/// <summary>
	/// Key: "Response.CodeSent"
	/// English String: "Code Sent"
	/// </summary>
	public override string ResponseCodeSent => "ÄÃ£ gá»­i mÃ£";

	/// <summary>
	/// Key: "Response.FeatureNotAvailable"
	/// English String: "Feature not available. Please contact support."
	/// </summary>
	public override string ResponseFeatureNotAvailable => "TÃ­nh nÄƒng khÃ´ng kháº£ dá»¥ng. Vui lÃ²ng liÃªn há»‡ há»— trá»£.";

	/// <summary>
	/// Key: "Response.InvalidCode"
	/// English String: "Invalid code."
	/// </summary>
	public override string ResponseInvalidCode => "MÃ£ khÃ´ng há»£p lá»‡.";

	/// <summary>
	/// Key: "Response.SystemErrorReturnToLogin"
	/// English String: "System error. Please return to login screen."
	/// </summary>
	public override string ResponseSystemErrorReturnToLogin => "Lá»—i há»‡ thá»‘ng. Vui lÃ²ng quay láº¡i mÃ n hÃ¬nh Ä‘Äƒng nháº­p.";

	/// <summary>
	/// Key: "Response.TooManyAttempts"
	/// English String: "Too many attempts. Please try again later."
	/// </summary>
	public override string ResponseTooManyAttempts => "QuÃ¡ nhiá»u láº§n thá»­. Vui lÃ²ng thá»­ láº¡i sau.";

	/// <summary>
	/// Key: "Response.TooManyCharacters"
	/// error message
	/// English String: "Too many characters"
	/// </summary>
	public override string ResponseTooManyCharacters => "QuÃ¡ nhiá»u kÃ½ tá»±";

	public TwoStepVerificationResources_vi_vn(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionCancel()
	{
		return "Há»§y";
	}

	protected override string _GetTemplateForActionResend()
	{
		return "Gá»­i láº¡i mÃ£";
	}

	protected override string _GetTemplateForActionStartOver()
	{
		return "Báº¯t Ä‘áº§u láº¡i";
	}

	protected override string _GetTemplateForActionSubmit()
	{
		return "Gá»­i";
	}

	protected override string _GetTemplateForActionVerify()
	{
		return "XÃ¡c minh";
	}

	/// <summary>
	/// Key: "Description.TwoStepVerificationActivationEmail.Body.Over13"
	/// Body for 2SV activation email for over 13 users
	/// English String: "Hi {accountName},{lineBreak}{lineBreak}You have activated 2-Step Verification for your Roblox account. Next time you log in from a new device, you will need to enter a 6-digit security code that Roblox sends to you via email.{lineBreak}{lineBreak}Roblox"
	/// </summary>
	public override string DescriptionTwoStepVerificationActivationEmailBodyOver13(string accountName, string lineBreak)
	{
		return $"ChÃ o {accountName},{lineBreak}{lineBreak}Báº¡n Ä‘Ã£ kÃ­ch hoáº¡t XÃ¡c minh 2 bÆ°á»›c cho tÃ i khoáº£n Roblox cá»§a mÃ¬nh. Láº§n tá»›i, khi Ä‘Äƒng nháº­p tá»« thiáº¿t bá»‹ má»›i, báº¡n sáº½ cáº§n nháº­p mÃ£ báº£o máº­t 6 chá»¯ sá»‘ Ä‘Æ°á»£c Roblox gá»­i cho báº¡n qua email.{lineBreak}{lineBreak}Roblox";
	}

	protected override string _GetTemplateForDescriptionTwoStepVerificationActivationEmailBodyOver13()
	{
		return "ChÃ o {accountName},{lineBreak}{lineBreak}Báº¡n Ä‘Ã£ kÃ­ch hoáº¡t XÃ¡c minh 2 bÆ°á»›c cho tÃ i khoáº£n Roblox cá»§a mÃ¬nh. Láº§n tá»›i, khi Ä‘Äƒng nháº­p tá»« thiáº¿t bá»‹ má»›i, báº¡n sáº½ cáº§n nháº­p mÃ£ báº£o máº­t 6 chá»¯ sá»‘ Ä‘Æ°á»£c Roblox gá»­i cho báº¡n qua email.{lineBreak}{lineBreak}Roblox";
	}

	/// <summary>
	/// Key: "Description.TwoStepVerificationActivationEmail.Body.Under13"
	/// Body for 2SV activation email for under 13 users
	/// English String: "Hi,{lineBreak}{lineBreak}2-Step Verification has been activated for your child's Roblox account, {accountName}. Next time they log in from a new device, they will need to enter a 6-digit security code that Roblox sends to you via email.{lineBreak}{lineBreak}Roblox"
	/// </summary>
	public override string DescriptionTwoStepVerificationActivationEmailBodyUnder13(string lineBreak, string accountName)
	{
		return $"ChÃ o báº¡n,{lineBreak}{lineBreak}XÃ¡c minh 2 bÆ°á»›c Ä‘Ã£ Ä‘Æ°á»£c kÃ­ch hoáº¡t cho tÃ i khoáº£n Roblox cá»§a con báº¡n, {accountName}. Láº§n tá»›i, khi Ä‘Äƒng nháº­p tá»« thiáº¿t bá»‹ má»›i, con báº¡n sáº½ cáº§n nháº­p mÃ£ báº£o máº­t 6 chá»¯ sá»‘ Ä‘Æ°á»£c Roblox gá»­i cho báº¡n qua email.{lineBreak}{lineBreak}Roblox";
	}

	protected override string _GetTemplateForDescriptionTwoStepVerificationActivationEmailBodyUnder13()
	{
		return "ChÃ o báº¡n,{lineBreak}{lineBreak}XÃ¡c minh 2 bÆ°á»›c Ä‘Ã£ Ä‘Æ°á»£c kÃ­ch hoáº¡t cho tÃ i khoáº£n Roblox cá»§a con báº¡n, {accountName}. Láº§n tá»›i, khi Ä‘Äƒng nháº­p tá»« thiáº¿t bá»‹ má»›i, con báº¡n sáº½ cáº§n nháº­p mÃ£ báº£o máº­t 6 chá»¯ sá»‘ Ä‘Æ°á»£c Roblox gá»­i cho báº¡n qua email.{lineBreak}{lineBreak}Roblox";
	}

	/// <summary>
	/// Key: "Description.TwoStepVerificationActivationEmail.Subject"
	/// Subject for 2SV activation email
	/// English String: "2-Step Verification Activated for Roblox Account: {accountName}"
	/// </summary>
	public override string DescriptionTwoStepVerificationActivationEmailSubject(string accountName)
	{
		return $"XÃ¡c minh 2 bÆ°á»›c Ä‘Ã£ Ä‘Æ°á»£c kÃ­ch hoáº¡t cho TÃ i khoáº£n Roblox: {accountName}";
	}

	protected override string _GetTemplateForDescriptionTwoStepVerificationActivationEmailSubject()
	{
		return "XÃ¡c minh 2 bÆ°á»›c Ä‘Ã£ Ä‘Æ°á»£c kÃ­ch hoáº¡t cho TÃ i khoáº£n Roblox: {accountName}";
	}

	/// <summary>
	/// Key: "Description.TwoStepVerificationDeactivationEmail.Body.Over13"
	/// Body for 2SV deactivation email for over 13 users
	/// English String: "Hi {accountName},{lineBreak}{lineBreak}You have deactivated 2-Step Verification for your Roblox account. A security code will no longer be required when you log into your account.{lineBreak}{lineBreak}Roblox"
	/// </summary>
	public override string DescriptionTwoStepVerificationDeactivationEmailBodyOver13(string accountName, string lineBreak)
	{
		return $"ChÃ o {accountName},{lineBreak}{lineBreak}Báº¡n Ä‘Ã£ há»§y kÃ­ch hoáº¡t XÃ¡c minh 2 bÆ°á»›c cho tÃ i khoáº£n Roblox cá»§a mÃ¬nh. Khi Ä‘Äƒng nháº­p vÃ o tÃ i khoáº£n, báº¡n sáº½ khÃ´ng cÃ²n cáº§n mÃ£ báº£o máº­t.{lineBreak}{lineBreak}Roblox";
	}

	protected override string _GetTemplateForDescriptionTwoStepVerificationDeactivationEmailBodyOver13()
	{
		return "ChÃ o {accountName},{lineBreak}{lineBreak}Báº¡n Ä‘Ã£ há»§y kÃ­ch hoáº¡t XÃ¡c minh 2 bÆ°á»›c cho tÃ i khoáº£n Roblox cá»§a mÃ¬nh. Khi Ä‘Äƒng nháº­p vÃ o tÃ i khoáº£n, báº¡n sáº½ khÃ´ng cÃ²n cáº§n mÃ£ báº£o máº­t.{lineBreak}{lineBreak}Roblox";
	}

	/// <summary>
	/// Key: "Description.TwoStepVerificationDeactivationEmail.Body.Under13"
	/// Body for 2SV deactivation email for under 13 users
	/// English String: "Hi,{lineBreak}{lineBreak}2-Step Verification has been deactivated for your child's Roblox account, {accountName}. A security code will no longer be required when they log into the account.{lineBreak}{lineBreak}Roblox"
	/// </summary>
	public override string DescriptionTwoStepVerificationDeactivationEmailBodyUnder13(string lineBreak, string accountName)
	{
		return $"ChÃ o báº¡n,{lineBreak}{lineBreak}XÃ¡c minh 2 bÆ°á»›c Ä‘Ã£ Ä‘Æ°á»£c há»§y kÃ­ch hoáº¡t cho tÃ i khoáº£n Roblox cá»§a con báº¡n, {accountName}. Khi Ä‘Äƒng nháº­p vÃ o tÃ i khoáº£n, con báº¡n sáº½ khÃ´ng cÃ²n cáº§n mÃ£ báº£o máº­t.{lineBreak}{lineBreak}Roblox";
	}

	protected override string _GetTemplateForDescriptionTwoStepVerificationDeactivationEmailBodyUnder13()
	{
		return "ChÃ o báº¡n,{lineBreak}{lineBreak}XÃ¡c minh 2 bÆ°á»›c Ä‘Ã£ Ä‘Æ°á»£c há»§y kÃ­ch hoáº¡t cho tÃ i khoáº£n Roblox cá»§a con báº¡n, {accountName}. Khi Ä‘Äƒng nháº­p vÃ o tÃ i khoáº£n, con báº¡n sáº½ khÃ´ng cÃ²n cáº§n mÃ£ báº£o máº­t.{lineBreak}{lineBreak}Roblox";
	}

	/// <summary>
	/// Key: "Description.TwoStepVerificationDeactivationEmail.Subject	"
	/// Subject for 2SV deactivation email
	/// English String: "2-Step Verification Deactivated for Roblox Account: {accountName}"
	/// </summary>
	public override string DescriptionTwoStepVerificationDeactivationEmailSubject(string accountName)
	{
		return $"XÃ¡c minh 2 bÆ°á»›c Ä‘Ã£ Ä‘Æ°á»£c há»§y kÃ­ch hoáº¡t cho TÃ i khoáº£n Roblox: {accountName}";
	}

	protected override string _GetTemplateForDescriptionTwoStepVerificationDeactivationEmailSubject()
	{
		return "XÃ¡c minh 2 bÆ°á»›c Ä‘Ã£ Ä‘Æ°á»£c há»§y kÃ­ch hoáº¡t cho TÃ i khoáº£n Roblox: {accountName}";
	}

	/// <summary>
	/// Key: "Description.TwoStepVerificationLoginEmail.Html.GeolocationInfo1"
	/// Geolocation information about IP trying to login
	/// English String: "{spanStartTagWithBold}Login request received from {username} located in {region}, {country} ({ipAddress}).{spanEndTag}{lineBreak}{lineBreak}"
	/// </summary>
	public override string DescriptionTwoStepVerificationLoginEmailHtmlGeolocationInfo1(string spanStartTagWithBold, string username, string region, string country, string ipAddress, string spanEndTag, string lineBreak)
	{
		return $"{spanStartTagWithBold}YÃªu cáº§u Ä‘Äƒng nháº­p Ä‘Æ°á»£c nháº­n tá»« {username} táº¡i {region}, {country} ({ipAddress}).{spanEndTag}{lineBreak}{lineBreak}";
	}

	protected override string _GetTemplateForDescriptionTwoStepVerificationLoginEmailHtmlGeolocationInfo1()
	{
		return "{spanStartTagWithBold}YÃªu cáº§u Ä‘Äƒng nháº­p Ä‘Æ°á»£c nháº­n tá»« {username} táº¡i {region}, {country} ({ipAddress}).{spanEndTag}{lineBreak}{lineBreak}";
	}

	/// <summary>
	/// Key: "Description.TwoStepVerificationLoginEmail.Html.GeolocationInfo2"
	/// Geolocation info about IP trying to login
	/// English String: "{spanStartTagWithBold}Login request received from {username} located in {country} ({ipAddress}).{spanEndTag}{lineBreak}{lineBreak}\t"
	/// </summary>
	public override string DescriptionTwoStepVerificationLoginEmailHtmlGeolocationInfo2(string spanStartTagWithBold, string username, string country, string ipAddress, string spanEndTag, string lineBreak)
	{
		return $"{spanStartTagWithBold}YÃªu cáº§u Ä‘Äƒng nháº­p Ä‘Æ°á»£c nháº­n tá»« {username} táº¡i {country} ({ipAddress}).{spanEndTag}{lineBreak}{lineBreak}\t";
	}

	protected override string _GetTemplateForDescriptionTwoStepVerificationLoginEmailHtmlGeolocationInfo2()
	{
		return "{spanStartTagWithBold}YÃªu cáº§u Ä‘Äƒng nháº­p Ä‘Æ°á»£c nháº­n tá»« {username} táº¡i {country} ({ipAddress}).{spanEndTag}{lineBreak}{lineBreak}\t";
	}

	/// <summary>
	/// Key: "Description.TwoStepVerificationLoginEmail.Html.GeolocationInfo3"
	/// Geolocation info about IP trying to log in
	/// English String: "{spanStartTagWithBold}Login request received from {username} (From Roblox Internal).{spanEndTag}{lineBreak}{lineBreak}\t"
	/// </summary>
	public override string DescriptionTwoStepVerificationLoginEmailHtmlGeolocationInfo3(string spanStartTagWithBold, string username, string spanEndTag, string lineBreak)
	{
		return $"{spanStartTagWithBold}YÃªu cáº§u Ä‘Äƒng nháº­p Ä‘Æ°á»£c nháº­n tá»« {username} (Thuá»™c Ná»™i bá»™ Roblox).{spanEndTag}{lineBreak}{lineBreak}\t";
	}

	protected override string _GetTemplateForDescriptionTwoStepVerificationLoginEmailHtmlGeolocationInfo3()
	{
		return "{spanStartTagWithBold}YÃªu cáº§u Ä‘Äƒng nháº­p Ä‘Æ°á»£c nháº­n tá»« {username} (Thuá»™c Ná»™i bá»™ Roblox).{spanEndTag}{lineBreak}{lineBreak}\t";
	}

	/// <summary>
	/// Key: "Description.TwoStepVerificationLoginEmail.Html.GeolocationInfo4"
	/// Geolocation info of IP trying to login
	/// English String: "{spanStartTagWithBold}Login request received from {username} located in {country}.{spanEndTag}{lineBreak}{lineBreak}"
	/// </summary>
	public override string DescriptionTwoStepVerificationLoginEmailHtmlGeolocationInfo4(string spanStartTagWithBold, string username, string country, string spanEndTag, string lineBreak)
	{
		return $"{spanStartTagWithBold}YÃªu cáº§u Ä‘Äƒng nháº­p Ä‘Æ°á»£c nháº­n tá»« {username} táº¡i {country}.{spanEndTag}{lineBreak}{lineBreak}";
	}

	protected override string _GetTemplateForDescriptionTwoStepVerificationLoginEmailHtmlGeolocationInfo4()
	{
		return "{spanStartTagWithBold}YÃªu cáº§u Ä‘Äƒng nháº­p Ä‘Æ°á»£c nháº­n tá»« {username} táº¡i {country}.{spanEndTag}{lineBreak}{lineBreak}";
	}

	/// <summary>
	/// Key: "Description.TwoStepVerificationLoginEmail.Html.GeolocationInfo5"
	/// Geolocation info of IP trying to login
	/// English String: "{spanStartTagWithBold}Login request received from {username} located in {region}, {country}.{spanEndTag}{lineBreak}{lineBreak}"
	/// </summary>
	public override string DescriptionTwoStepVerificationLoginEmailHtmlGeolocationInfo5(string spanStartTagWithBold, string username, string region, string country, string spanEndTag, string lineBreak)
	{
		return $"{spanStartTagWithBold}YÃªu cáº§u Ä‘Äƒng nháº­p Ä‘Æ°á»£c nháº­n tá»« {username} táº¡i {region}, {country}.{spanEndTag}{lineBreak}{lineBreak}";
	}

	protected override string _GetTemplateForDescriptionTwoStepVerificationLoginEmailHtmlGeolocationInfo5()
	{
		return "{spanStartTagWithBold}YÃªu cáº§u Ä‘Äƒng nháº­p Ä‘Æ°á»£c nháº­n tá»« {username} táº¡i {region}, {country}.{spanEndTag}{lineBreak}{lineBreak}";
	}

	/// <summary>
	/// Key: "Description.TwoStepVerificationLoginEmail.Html.GeolocationInfo6"
	/// Geolocation info of IP trying to login
	/// English String: "{spanStartTagWithBold}Login request received from {username} located in {city}, {region}, {country}.{spanEndTag}{lineBreak}{lineBreak}"
	/// </summary>
	public override string DescriptionTwoStepVerificationLoginEmailHtmlGeolocationInfo6(string spanStartTagWithBold, string username, string city, string region, string country, string spanEndTag, string lineBreak)
	{
		return $"{spanStartTagWithBold}YÃªu cáº§u Ä‘Äƒng nháº­p Ä‘Æ°á»£c nháº­n tá»« {username} táº¡i {city}, {region}, {country}.{spanEndTag}{lineBreak}{lineBreak}";
	}

	protected override string _GetTemplateForDescriptionTwoStepVerificationLoginEmailHtmlGeolocationInfo6()
	{
		return "{spanStartTagWithBold}YÃªu cáº§u Ä‘Äƒng nháº­p Ä‘Æ°á»£c nháº­n tá»« {username} táº¡i {city}, {region}, {country}.{spanEndTag}{lineBreak}{lineBreak}";
	}

	/// <summary>
	/// Key: "Description.TwoStepVerificationLoginEmail.HtmlBody"
	/// Html body for 2SV login email
	/// English String: "{geoLocationInformation}{spanStartTagWithBold}Login code for {accountName}: {lineBreak}{lineBreak}{code} {spanEndTag}{lineBreak}{lineBreak}Enter this code into the 2-Step Verification screen to finish logging in. This code will expire in 15 minutes.{lineBreak}{lineBreak}This email was sent because your account tried to login to Roblox from a new browser or device. If you haven't tried logging into Roblox, someone else may be trying to access your account. You are strongly advised to change your password if you did not generate this request.{lineBreak}{lineBreak}Resources:{lineBreak}{aTagStartWithHref}{ChangePasswordLink}{hrefEnd}Change Your Password{aTagEnd} {lineBreak}{aTagStartWithHref}{TwoStepVerificationArticleLink}{hrefEnd}Learn More About 2-Step Verification{aTagEnd} {lineBreak}{aTagStartWithHref}{AccountSafetyArticleLink}{hrefEnd}Keeping Your Account Safe{aTagEnd} {lineBreak}{aTagStartWithHref}{SupportLink}{hrefEnd}General Roblox Support{aTagEnd} {lineBreak}{lineBreak}Thank you,{lineBreak}{lineBreak}The Roblox Team"
	/// </summary>
	public override string DescriptionTwoStepVerificationLoginEmailHtmlBody(string geoLocationInformation, string spanStartTagWithBold, string accountName, string lineBreak, string code, string spanEndTag, string aTagStartWithHref, string ChangePasswordLink, string hrefEnd, string aTagEnd, string TwoStepVerificationArticleLink, string AccountSafetyArticleLink, string SupportLink)
	{
		return $"{geoLocationInformation}{spanStartTagWithBold}MÃ£ Ä‘Äƒng nháº­p cho {accountName}: {lineBreak}{lineBreak}{code} {spanEndTag}{lineBreak}{lineBreak}Nháº­p mÃ£ nÃ y vÃ o mÃ n hÃ¬nh XÃ¡c minh 2 bÆ°á»›c Ä‘á»ƒ hoÃ n táº¥t Ä‘Äƒng nháº­p. MÃ£ nÃ y sáº½ háº¿t háº¡n sau 15 phÃºt.{lineBreak}{lineBreak}Báº¡n nháº­n Ä‘Æ°á»£c email nÃ y bá»Ÿi vÃ¬ tÃ i khoáº£n cá»§a báº¡n Ä‘Ã£ cá»‘ Ä‘Äƒng nháº­p vÃ o Roblox tá»« trÃ¬nh duyá»‡t hoáº·c thiáº¿t bá»‹ má»›i. Náº¿u báº¡n khÃ´ng cá»‘ Ä‘Äƒng nháº­p vÃ o Roblox thÃ¬ ngÆ°á»i khÃ¡c cÃ³ thá»ƒ Ä‘ang cá»‘ truy cáº­p tÃ i khoáº£n cá»§a báº¡n. ChÃºng tÃ´i Ä‘áº·c biá»‡t khuyáº¿n cÃ¡o báº¡n thay Ä‘á»•i máº­t kháº©u náº¿u báº¡n khÃ´ng táº¡o yÃªu cáº§u nÃ y.{lineBreak}{lineBreak}TÃ i nguyÃªn:{lineBreak}{aTagStartWithHref}{ChangePasswordLink}{hrefEnd}Äá»•i máº­t kháº©u cá»§a báº¡n{aTagEnd} {lineBreak}{aTagStartWithHref}{TwoStepVerificationArticleLink}{hrefEnd}TÃ¬m hiá»ƒu thÃªm vá» XÃ¡c minh 2 bÆ°á»›c{aTagEnd} {lineBreak}{aTagStartWithHref}{AccountSafetyArticleLink}{hrefEnd}Giá»¯ an toÃ n cho tÃ i khoáº£n cá»§a báº¡n{aTagEnd} {lineBreak}{aTagStartWithHref}{SupportLink}{hrefEnd}Há»— trá»£ chung cá»§a Roblox{aTagEnd} {lineBreak}{lineBreak}Cáº£m Æ¡n báº¡n,{lineBreak}{lineBreak}Äá»™i ngÅ© Roblox";
	}

	protected override string _GetTemplateForDescriptionTwoStepVerificationLoginEmailHtmlBody()
	{
		return "{geoLocationInformation}{spanStartTagWithBold}MÃ£ Ä‘Äƒng nháº­p cho {accountName}: {lineBreak}{lineBreak}{code} {spanEndTag}{lineBreak}{lineBreak}Nháº­p mÃ£ nÃ y vÃ o mÃ n hÃ¬nh XÃ¡c minh 2 bÆ°á»›c Ä‘á»ƒ hoÃ n táº¥t Ä‘Äƒng nháº­p. MÃ£ nÃ y sáº½ háº¿t háº¡n sau 15 phÃºt.{lineBreak}{lineBreak}Báº¡n nháº­n Ä‘Æ°á»£c email nÃ y bá»Ÿi vÃ¬ tÃ i khoáº£n cá»§a báº¡n Ä‘Ã£ cá»‘ Ä‘Äƒng nháº­p vÃ o Roblox tá»« trÃ¬nh duyá»‡t hoáº·c thiáº¿t bá»‹ má»›i. Náº¿u báº¡n khÃ´ng cá»‘ Ä‘Äƒng nháº­p vÃ o Roblox thÃ¬ ngÆ°á»i khÃ¡c cÃ³ thá»ƒ Ä‘ang cá»‘ truy cáº­p tÃ i khoáº£n cá»§a báº¡n. ChÃºng tÃ´i Ä‘áº·c biá»‡t khuyáº¿n cÃ¡o báº¡n thay Ä‘á»•i máº­t kháº©u náº¿u báº¡n khÃ´ng táº¡o yÃªu cáº§u nÃ y.{lineBreak}{lineBreak}TÃ i nguyÃªn:{lineBreak}{aTagStartWithHref}{ChangePasswordLink}{hrefEnd}Äá»•i máº­t kháº©u cá»§a báº¡n{aTagEnd} {lineBreak}{aTagStartWithHref}{TwoStepVerificationArticleLink}{hrefEnd}TÃ¬m hiá»ƒu thÃªm vá» XÃ¡c minh 2 bÆ°á»›c{aTagEnd} {lineBreak}{aTagStartWithHref}{AccountSafetyArticleLink}{hrefEnd}Giá»¯ an toÃ n cho tÃ i khoáº£n cá»§a báº¡n{aTagEnd} {lineBreak}{aTagStartWithHref}{SupportLink}{hrefEnd}Há»— trá»£ chung cá»§a Roblox{aTagEnd} {lineBreak}{lineBreak}Cáº£m Æ¡n báº¡n,{lineBreak}{lineBreak}Äá»™i ngÅ© Roblox";
	}

	/// <summary>
	/// Key: "Description.TwoStepVerificationLoginEmail.PlainBody"
	/// Plain body for 2SV login email
	/// English String: "{geoLocationInformation}Login code for {accountName}: {lineBreak}{lineBreak} {code} {lineBreak}{lineBreak}Enter this code into the 2-Step Verification screen to finish logging in. This code will expire in 15 minutes. {lineBreak}{lineBreak}This email was sent because your account tried to login to Roblox from a new browser or device. If you haven't tried logging into Roblox, someone else may be trying to access your account. You are strongly advised to change your password if you did not generate this request. {lineBreak}{lineBreak}Resources: {lineBreak}Change Your Password [{accountInfoPageLink}] {lineBreak}Learn More About 2-Step Verification [{twoStepVerificationHelpArticleLink}]{lineBreak}Keeping Your Account Safe [{keepAccountSafeArticleLink}] {lineBreak}General Roblox Support [{supportPageLink}] {lineBreak}{lineBreak}Thank you, {lineBreak}{lineBreak}The Roblox Team"
	/// </summary>
	public override string DescriptionTwoStepVerificationLoginEmailPlainBody(string geoLocationInformation, string accountName, string lineBreak, string code, string accountInfoPageLink, string twoStepVerificationHelpArticleLink, string keepAccountSafeArticleLink, string supportPageLink)
	{
		return $"{geoLocationInformation}MÃ£ Ä‘Äƒng nháº­p cho {accountName}: {lineBreak}{lineBreak} {code} {lineBreak}{lineBreak}Nháº­p mÃ£ nÃ y vÃ o mÃ n hÃ¬nh XÃ¡c minh 2 bÆ°á»›c Ä‘á»ƒ hoÃ n táº¥t Ä‘Äƒng nháº­p. MÃ£ nÃ y sáº½ háº¿t háº¡n sau 15 phÃºt. {lineBreak}{lineBreak}Báº¡n nháº­n Ä‘Æ°á»£c email nÃ y bá»Ÿi vÃ¬ tÃ i khoáº£n cá»§a báº¡n Ä‘Ã£ cá»‘ Ä‘Äƒng nháº­p vÃ o Roblox tá»« trÃ¬nh duyá»‡t hoáº·c thiáº¿t bá»‹ má»›i. Náº¿u báº¡n khÃ´ng cá»‘ Ä‘Äƒng nháº­p vÃ o Roblox thÃ¬ ngÆ°á»i khÃ¡c cÃ³ thá»ƒ Ä‘ang cá»‘ truy cáº­p tÃ i khoáº£n cá»§a báº¡n. ChÃºng tÃ´i Ä‘áº·c biá»‡t khuyáº¿n cÃ¡o báº¡n thay Ä‘á»•i máº­t kháº©u náº¿u báº¡n khÃ´ng táº¡o yÃªu cáº§u nÃ y. {lineBreak}{lineBreak}TÃ i nguyÃªn: {lineBreak}Äá»•i máº­t kháº©u cá»§a báº¡n [{accountInfoPageLink}] {lineBreak}TÃ¬m hiá»ƒu thÃªm vá» XÃ¡c minh 2 bÆ°á»›c [{twoStepVerificationHelpArticleLink}]{lineBreak}Giá»¯ an toÃ n cho tÃ i khoáº£n cá»§a báº¡n [{keepAccountSafeArticleLink}] {lineBreak}Há»— trá»£ chung cá»§a Roblox [{supportPageLink}] {lineBreak}{lineBreak}Cáº£m Æ¡n báº¡n, {lineBreak}{lineBreak}Äá»™i ngÅ© Roblox";
	}

	protected override string _GetTemplateForDescriptionTwoStepVerificationLoginEmailPlainBody()
	{
		return "{geoLocationInformation}MÃ£ Ä‘Äƒng nháº­p cho {accountName}: {lineBreak}{lineBreak} {code} {lineBreak}{lineBreak}Nháº­p mÃ£ nÃ y vÃ o mÃ n hÃ¬nh XÃ¡c minh 2 bÆ°á»›c Ä‘á»ƒ hoÃ n táº¥t Ä‘Äƒng nháº­p. MÃ£ nÃ y sáº½ háº¿t háº¡n sau 15 phÃºt. {lineBreak}{lineBreak}Báº¡n nháº­n Ä‘Æ°á»£c email nÃ y bá»Ÿi vÃ¬ tÃ i khoáº£n cá»§a báº¡n Ä‘Ã£ cá»‘ Ä‘Äƒng nháº­p vÃ o Roblox tá»« trÃ¬nh duyá»‡t hoáº·c thiáº¿t bá»‹ má»›i. Náº¿u báº¡n khÃ´ng cá»‘ Ä‘Äƒng nháº­p vÃ o Roblox thÃ¬ ngÆ°á»i khÃ¡c cÃ³ thá»ƒ Ä‘ang cá»‘ truy cáº­p tÃ i khoáº£n cá»§a báº¡n. ChÃºng tÃ´i Ä‘áº·c biá»‡t khuyáº¿n cÃ¡o báº¡n thay Ä‘á»•i máº­t kháº©u náº¿u báº¡n khÃ´ng táº¡o yÃªu cáº§u nÃ y. {lineBreak}{lineBreak}TÃ i nguyÃªn: {lineBreak}Äá»•i máº­t kháº©u cá»§a báº¡n [{accountInfoPageLink}] {lineBreak}TÃ¬m hiá»ƒu thÃªm vá» XÃ¡c minh 2 bÆ°á»›c [{twoStepVerificationHelpArticleLink}]{lineBreak}Giá»¯ an toÃ n cho tÃ i khoáº£n cá»§a báº¡n [{keepAccountSafeArticleLink}] {lineBreak}Há»— trá»£ chung cá»§a Roblox [{supportPageLink}] {lineBreak}{lineBreak}Cáº£m Æ¡n báº¡n, {lineBreak}{lineBreak}Äá»™i ngÅ© Roblox";
	}

	/// <summary>
	/// Key: "Description.TwoStepVerificationLoginEmail.PlainText.GeolocationInfo1"
	/// GeoLocation info of IP trying to login
	/// English String: "Login request received from {username} located in {region}, {country} ({ipAddress}).{lineBreak}{lineBreak}"
	/// </summary>
	public override string DescriptionTwoStepVerificationLoginEmailPlainTextGeolocationInfo1(string username, string region, string country, string ipAddress, string lineBreak)
	{
		return $"YÃªu cáº§u Ä‘Äƒng nháº­p Ä‘Æ°á»£c nháº­n tá»« {username} táº¡i {region}, {country} ({ipAddress}).{lineBreak}{lineBreak}";
	}

	protected override string _GetTemplateForDescriptionTwoStepVerificationLoginEmailPlainTextGeolocationInfo1()
	{
		return "YÃªu cáº§u Ä‘Äƒng nháº­p Ä‘Æ°á»£c nháº­n tá»« {username} táº¡i {region}, {country} ({ipAddress}).{lineBreak}{lineBreak}";
	}

	/// <summary>
	/// Key: "Description.TwoStepVerificationLoginEmail.PlainText.GeolocationInfo2"
	/// Geolocation info of IP trying to login
	/// English String: "Login request received from {username} located in {country} ({ipAddress}).{lineBreak}{lineBreak}"
	/// </summary>
	public override string DescriptionTwoStepVerificationLoginEmailPlainTextGeolocationInfo2(string username, string country, string ipAddress, string lineBreak)
	{
		return $"YÃªu cáº§u Ä‘Äƒng nháº­p Ä‘Æ°á»£c nháº­n tá»« {username} táº¡i {country} ({ipAddress}).{lineBreak}{lineBreak}";
	}

	protected override string _GetTemplateForDescriptionTwoStepVerificationLoginEmailPlainTextGeolocationInfo2()
	{
		return "YÃªu cáº§u Ä‘Äƒng nháº­p Ä‘Æ°á»£c nháº­n tá»« {username} táº¡i {country} ({ipAddress}).{lineBreak}{lineBreak}";
	}

	/// <summary>
	/// Key: "Description.TwoStepVerificationLoginEmail.PlainText.GeolocationInfo3"
	/// Geolocation info of IP trying to login
	/// English String: "Login request received from {username} (From Roblox Internal).{lineBreak}{lineBreak}"
	/// </summary>
	public override string DescriptionTwoStepVerificationLoginEmailPlainTextGeolocationInfo3(string username, string lineBreak)
	{
		return $"YÃªu cáº§u Ä‘Äƒng nháº­p Ä‘Æ°á»£c nháº­n tá»« {username} (Thuá»™c Ná»™i bá»™ Roblox).{lineBreak}{lineBreak}";
	}

	protected override string _GetTemplateForDescriptionTwoStepVerificationLoginEmailPlainTextGeolocationInfo3()
	{
		return "YÃªu cáº§u Ä‘Äƒng nháº­p Ä‘Æ°á»£c nháº­n tá»« {username} (Thuá»™c Ná»™i bá»™ Roblox).{lineBreak}{lineBreak}";
	}

	/// <summary>
	/// Key: "Description.TwoStepVerificationLoginEmail.PlainText.GeolocationInfo4"
	/// Geolocation info of IP trying to login
	/// English String: "Login request received from {username} located in {country}.{lineBreak}{lineBreak}"
	/// </summary>
	public override string DescriptionTwoStepVerificationLoginEmailPlainTextGeolocationInfo4(string username, string country, string lineBreak)
	{
		return $"YÃªu cáº§u Ä‘Äƒng nháº­p Ä‘Æ°á»£c nháº­n tá»« {username} táº¡i {country}.{lineBreak}{lineBreak}";
	}

	protected override string _GetTemplateForDescriptionTwoStepVerificationLoginEmailPlainTextGeolocationInfo4()
	{
		return "YÃªu cáº§u Ä‘Äƒng nháº­p Ä‘Æ°á»£c nháº­n tá»« {username} táº¡i {country}.{lineBreak}{lineBreak}";
	}

	/// <summary>
	/// Key: "Description.TwoStepVerificationLoginEmail.PlainText.GeolocationInfo5"
	/// Geolocation info of IP trying to login
	/// English String: "Login request received from {username} located in {region}, {country}.{lineBreak}{lineBreak}"
	/// </summary>
	public override string DescriptionTwoStepVerificationLoginEmailPlainTextGeolocationInfo5(string username, string region, string country, string lineBreak)
	{
		return $"YÃªu cáº§u Ä‘Äƒng nháº­p Ä‘Æ°á»£c nháº­n tá»« {username} táº¡i {region}, {country}.{lineBreak}{lineBreak}";
	}

	protected override string _GetTemplateForDescriptionTwoStepVerificationLoginEmailPlainTextGeolocationInfo5()
	{
		return "YÃªu cáº§u Ä‘Äƒng nháº­p Ä‘Æ°á»£c nháº­n tá»« {username} táº¡i {region}, {country}.{lineBreak}{lineBreak}";
	}

	/// <summary>
	/// Key: "Description.TwoStepVerificationLoginEmail.PlainText.GeolocationInfo6"
	/// Geolocation info of IP trying to login
	/// English String: "Login request received from {username} located in {city}, {region}, {country}.{lineBreak}{lineBreak}"
	/// </summary>
	public override string DescriptionTwoStepVerificationLoginEmailPlainTextGeolocationInfo6(string username, string city, string region, string country, string lineBreak)
	{
		return $"YÃªu cáº§u Ä‘Äƒng nháº­p Ä‘Æ°á»£c nháº­n tá»« {username} táº¡i {city}, {region}, {country}.{lineBreak}{lineBreak}";
	}

	protected override string _GetTemplateForDescriptionTwoStepVerificationLoginEmailPlainTextGeolocationInfo6()
	{
		return "YÃªu cáº§u Ä‘Äƒng nháº­p Ä‘Æ°á»£c nháº­n tá»« {username} táº¡i {city}, {region}, {country}.{lineBreak}{lineBreak}";
	}

	/// <summary>
	/// Key: "Description.TwoStepVerificationLoginEmail.Subject"
	/// Subject for 2SV login email
	/// English String: "Verification Code for Roblox Account: {accountName}"
	/// </summary>
	public override string DescriptionTwoStepVerificationLoginEmailSubject(string accountName)
	{
		return $"MÃ£ xÃ¡c minh cho TÃ i khoáº£n Roblox: {accountName}";
	}

	protected override string _GetTemplateForDescriptionTwoStepVerificationLoginEmailSubject()
	{
		return "MÃ£ xÃ¡c minh cho TÃ i khoáº£n Roblox: {accountName}";
	}

	protected override string _GetTemplateForLabelCode()
	{
		return "MÃ£";
	}

	/// <summary>
	/// Key: "Label.CodeInputPlaceholderText"
	/// example: Enter 4-digit code
	/// English String: "Enter {codeLength}-digit Code"
	/// </summary>
	public override string LabelCodeInputPlaceholderText(string codeLength)
	{
		return $"Nháº­p mÃ£ {codeLength} chá»¯ sá»‘";
	}

	protected override string _GetTemplateForLabelCodeInputPlaceholderText()
	{
		return "Nháº­p mÃ£ {codeLength} chá»¯ sá»‘";
	}

	protected override string _GetTemplateForLabelDidNotReceive()
	{
		return "Báº¡n khÃ´ng nháº­n Ä‘Æ°á»£c mÃ£?";
	}

	protected override string _GetTemplateForLabelEnterCode()
	{
		return "Nháº­p mÃ£ (6 chá»¯ sá»‘)";
	}

	protected override string _GetTemplateForLabelEnterEmailCode()
	{
		return "Nháº­p mÃ£ chÃºng tÃ´i vá»«a gá»­i cho báº¡n qua email";
	}

	protected override string _GetTemplateForLabelEnterTextCode()
	{
		return "Nháº­p mÃ£ chÃºng tÃ´i vá»«a gá»­i cho báº¡n qua tin nháº¯n vÄƒn báº£n";
	}

	protected override string _GetTemplateForLabelEnterTwoStepVerificationCode()
	{
		return "Nháº­p mÃ£ xÃ¡c minh hai bÆ°á»›c cá»§a báº¡n.";
	}

	protected override string _GetTemplateForLabelFacebookPasswordWarning()
	{
		return "Náº¿u báº¡n Ä‘Ã£ Ä‘Äƒng nháº­p báº±ng Facebook, báº¡n pháº£i Ä‘áº·t má»™t máº­t kháº©u.";
	}

	protected override string _GetTemplateForLabelLearnMore()
	{
		return "TÃ¬m hiá»ƒu thÃªm";
	}

	/// <summary>
	/// Key: "Label.NeedHelpContactSupport"
	/// label for the support article link
	/// English String: "Need help? Contact {supportLink}"
	/// </summary>
	public override string LabelNeedHelpContactSupport(string supportLink)
	{
		return $"Báº¡n cáº§n trá»£ giÃºp? HÃ£y liÃªn há»‡ {supportLink}";
	}

	protected override string _GetTemplateForLabelNeedHelpContactSupport()
	{
		return "Báº¡n cáº§n trá»£ giÃºp? HÃ£y liÃªn há»‡ {supportLink}";
	}

	protected override string _GetTemplateForLabelNewCode()
	{
		return "MÃ£ má»›i";
	}

	protected override string _GetTemplateForLabelRobloxSupport()
	{
		return "Há»— trá»£ cá»§a Roblox";
	}

	protected override string _GetTemplateForLabelTrustThisDevice()
	{
		return "Tin tÆ°á»Ÿng thiáº¿t bá»‹ nÃ y trong vÃ²ng 30 ngÃ y";
	}

	protected override string _GetTemplateForLabelTwoStepVerification()
	{
		return "XÃ¡c minh 2 bÆ°á»›c";
	}

	protected override string _GetTemplateForResponseCodeSent()
	{
		return "ÄÃ£ gá»­i mÃ£";
	}

	protected override string _GetTemplateForResponseFeatureNotAvailable()
	{
		return "TÃ­nh nÄƒng khÃ´ng kháº£ dá»¥ng. Vui lÃ²ng liÃªn há»‡ há»— trá»£.";
	}

	protected override string _GetTemplateForResponseInvalidCode()
	{
		return "MÃ£ khÃ´ng há»£p lá»‡.";
	}

	protected override string _GetTemplateForResponseSystemErrorReturnToLogin()
	{
		return "Lá»—i há»‡ thá»‘ng. Vui lÃ²ng quay láº¡i mÃ n hÃ¬nh Ä‘Äƒng nháº­p.";
	}

	protected override string _GetTemplateForResponseTooManyAttempts()
	{
		return "QuÃ¡ nhiá»u láº§n thá»­. Vui lÃ²ng thá»­ láº¡i sau.";
	}

	protected override string _GetTemplateForResponseTooManyCharacters()
	{
		return "QuÃ¡ nhiá»u kÃ½ tá»±";
	}
}


}
