namespace Roblox.Platform.TranslationResources.Authentication {
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
	public override string ActionCancel => "å–æ¶ˆ";

	/// <summary>
	/// Key: "Action.Resend"
	/// English String: "Resend Code"
	/// </summary>
	public override string ActionResend => "é‡æ–°å‘é€éªŒè¯ç ";

	/// <summary>
	/// Key: "Action.StartOver"
	/// link text to restart verification
	/// English String: "Start Over"
	/// </summary>
	public override string ActionStartOver => "é‡æ–°å¼€å§‹";

	/// <summary>
	/// Key: "Action.Submit"
	/// submit button text
	/// English String: "Submit"
	/// </summary>
	public override string ActionSubmit => "æäº¤";

	/// <summary>
	/// Key: "Action.Verify"
	/// English String: "Verify"
	/// </summary>
	public override string ActionVerify => "éªŒè¯";

	/// <summary>
	/// Key: "Label.Code"
	/// verification code for 2 factor authentication
	/// English String: "Code"
	/// </summary>
	public override string LabelCode => "éªŒè¯ç ";

	/// <summary>
	/// Key: "Label.DidNotReceive"
	/// English String: "Didn't receive the code?"
	/// </summary>
	public override string LabelDidNotReceive => "æ²¡æ”¶åˆ°éªŒè¯ç ï¼Ÿ";

	/// <summary>
	/// Key: "Label.EnterCode"
	/// English String: "Enter Code (6-digit)"
	/// </summary>
	public override string LabelEnterCode => "è¾“å…¥éªŒè¯ç ï¼ˆ6 ä½ï¼‰";

	/// <summary>
	/// Key: "Label.EnterEmailCode"
	/// English String: "Enter the code we just sent you via email"
	/// </summary>
	public override string LabelEnterEmailCode => "è¯·è¾“å…¥æˆ‘ä»¬é€šè¿‡ç”µå­é‚®ä»¶å‘é€ç»™ä½ çš„éªŒè¯ç ";

	/// <summary>
	/// Key: "Label.EnterTextCode"
	/// English String: "Enter the code we just sent you via text message"
	/// </summary>
	public override string LabelEnterTextCode => "è¯·è¾“å…¥æˆ‘ä»¬é€šè¿‡çŸ­ä¿¡å‘é€ç»™ä½ çš„éªŒè¯ç ";

	/// <summary>
	/// Key: "Label.EnterTwoStepVerificationCode"
	/// Enter your two step verification code.
	/// English String: "Enter your two step verification code."
	/// </summary>
	public override string LabelEnterTwoStepVerificationCode => "è¾“å…¥ä½ çš„ä¸¤æ­¥éªŒè¯ç ã€‚";

	/// <summary>
	/// Key: "Label.FacebookPasswordWarning"
	/// If you have been signing in with Facebook, you must set a password.
	/// English String: "If you have been signing in with Facebook, you must set a password."
	/// </summary>
	public override string LabelFacebookPasswordWarning => "å¦‚æžœä½ ä½¿ç”¨ Facebook ç™»å½•ï¼Œåˆ™å¿…é¡»è®¾å®šå¯†ç ã€‚";

	/// <summary>
	/// Key: "Label.LearnMore"
	/// Learn More link text
	/// English String: "Learn More"
	/// </summary>
	public override string LabelLearnMore => "äº†è§£æ›´å¤š";

	/// <summary>
	/// Key: "Label.NewCode"
	/// verification code resent, label changes to new code
	/// English String: "New Code"
	/// </summary>
	public override string LabelNewCode => "æ–°éªŒè¯ç ";

	/// <summary>
	/// Key: "Label.RobloxSupport"
	/// English String: "Roblox Support"
	/// </summary>
	public override string LabelRobloxSupport => "Roblox æ”¯æŒ";

	/// <summary>
	/// Key: "Label.TrustThisDevice"
	/// English String: "Trust this device for 30 days"
	/// </summary>
	public override string LabelTrustThisDevice => "ä¿¡ä»»æ­¤è£…ç½® 30 å¤©";

	/// <summary>
	/// Key: "Label.TwoStepVerification"
	/// English String: "2-Step Verification"
	/// </summary>
	public override string LabelTwoStepVerification => "ä¸¤æ­¥éªŒè¯";

	/// <summary>
	/// Key: "Response.CodeSent"
	/// English String: "Code Sent"
	/// </summary>
	public override string ResponseCodeSent => "éªŒè¯ç å·²å‘é€";

	/// <summary>
	/// Key: "Response.FeatureNotAvailable"
	/// English String: "Feature not available. Please contact support."
	/// </summary>
	public override string ResponseFeatureNotAvailable => "åŠŸèƒ½ä¸å¯ç”¨ã€‚è¯·è”ç³»æŠ€æœ¯æ”¯æŒã€‚";

	/// <summary>
	/// Key: "Response.InvalidCode"
	/// English String: "Invalid code."
	/// </summary>
	public override string ResponseInvalidCode => "éªŒè¯ç æ— æ•ˆã€‚";

	/// <summary>
	/// Key: "Response.SystemErrorReturnToLogin"
	/// English String: "System error. Please return to login screen."
	/// </summary>
	public override string ResponseSystemErrorReturnToLogin => "ç³»ç»Ÿé”™è¯¯ã€‚è¯·è¿”å›žç™»å½•å±å¹•ã€‚";

	/// <summary>
	/// Key: "Response.TooManyAttempts"
	/// English String: "Too many attempts. Please try again later."
	/// </summary>
	public override string ResponseTooManyAttempts => "å°è¯•æ¬¡æ•°è¿‡å¤šã€‚è¯·ç¨åŽé‡è¯•ã€‚";

	/// <summary>
	/// Key: "Response.TooManyCharacters"
	/// error message
	/// English String: "Too many characters"
	/// </summary>
	public override string ResponseTooManyCharacters => "å­—ç¬¦è¿‡å¤š";

	public TwoStepVerificationResources_zh_cjv(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionCancel()
	{
		return "å–æ¶ˆ";
	}

	protected override string _GetTemplateForActionResend()
	{
		return "é‡æ–°å‘é€éªŒè¯ç ";
	}

	protected override string _GetTemplateForActionStartOver()
	{
		return "é‡æ–°å¼€å§‹";
	}

	protected override string _GetTemplateForActionSubmit()
	{
		return "æäº¤";
	}

	protected override string _GetTemplateForActionVerify()
	{
		return "éªŒè¯";
	}

	/// <summary>
	/// Key: "Description.TwoStepVerificationActivationEmail.Body.Over13"
	/// Body for 2SV activation email for over 13 users
	/// English String: "Hi {accountName},{lineBreak}{lineBreak}You have activated 2-Step Verification for your Roblox account. Next time you log in from a new device, you will need to enter a 6-digit security code that Roblox sends to you via email.{lineBreak}{lineBreak}Roblox"
	/// </summary>
	public override string DescriptionTwoStepVerificationActivationEmailBodyOver13(string accountName, string lineBreak)
	{
		return $"ä½ å¥½ï¼Œ{accountName}ï¼š{lineBreak}{lineBreak}ä½ å·²æˆåŠŸä¸ºä½ çš„ Roblox å¸æˆ·æ¿€æ´»ä¸¤æ­¥éªŒè¯ã€‚ä¸‹æ¬¡å½“ä½ ä»Žæ–°è®¾å¤‡ç™»å½•æ—¶ï¼Œä½ å°†éœ€è¦è¾“å…¥ Roblox é€šè¿‡ç”µå­é‚®ä»¶å‘é€ç»™ä½ çš„ 6 ä½å®‰å…¨ä»£ç ã€‚{lineBreak}{lineBreak}Roblox";
	}

	protected override string _GetTemplateForDescriptionTwoStepVerificationActivationEmailBodyOver13()
	{
		return "ä½ å¥½ï¼Œ{accountName}ï¼š{lineBreak}{lineBreak}ä½ å·²æˆåŠŸä¸ºä½ çš„ Roblox å¸æˆ·æ¿€æ´»ä¸¤æ­¥éªŒè¯ã€‚ä¸‹æ¬¡å½“ä½ ä»Žæ–°è®¾å¤‡ç™»å½•æ—¶ï¼Œä½ å°†éœ€è¦è¾“å…¥ Roblox é€šè¿‡ç”µå­é‚®ä»¶å‘é€ç»™ä½ çš„ 6 ä½å®‰å…¨ä»£ç ã€‚{lineBreak}{lineBreak}Roblox";
	}

	/// <summary>
	/// Key: "Description.TwoStepVerificationActivationEmail.Body.Under13"
	/// Body for 2SV activation email for under 13 users
	/// English String: "Hi,{lineBreak}{lineBreak}2-Step Verification has been activated for your child's Roblox account, {accountName}. Next time they log in from a new device, they will need to enter a 6-digit security code that Roblox sends to you via email.{lineBreak}{lineBreak}Roblox"
	/// </summary>
	public override string DescriptionTwoStepVerificationActivationEmailBodyUnder13(string lineBreak, string accountName)
	{
		return $"æ‚¨å¥½ï¼Œ{lineBreak}{lineBreak}å·²ä¸ºæ‚¨å­©å­çš„å¸æˆ·ï¼š{accountName} æ¿€æ´»ä¸¤æ­¥è®¤è¯ã€‚å½“ä»–ä»¬ä¸‹æ¬¡åœ¨æ–°è®¾å¤‡ä¸Šç™»å½•æ—¶ï¼Œä»–ä»¬å°†éœ€è¦è¾“å…¥ä¸€ä¸ª 6 ä½æ•°çš„å®‰å…¨ä»£ç ï¼ŒRoblox ä¼šé€šè¿‡ç”µå­é‚®ä»¶å°†æ­¤ä»£ç å‘é€ç»™æ‚¨ã€‚{lineBreak}{lineBreak}Roblox";
	}

	protected override string _GetTemplateForDescriptionTwoStepVerificationActivationEmailBodyUnder13()
	{
		return "æ‚¨å¥½ï¼Œ{lineBreak}{lineBreak}å·²ä¸ºæ‚¨å­©å­çš„å¸æˆ·ï¼š{accountName} æ¿€æ´»ä¸¤æ­¥è®¤è¯ã€‚å½“ä»–ä»¬ä¸‹æ¬¡åœ¨æ–°è®¾å¤‡ä¸Šç™»å½•æ—¶ï¼Œä»–ä»¬å°†éœ€è¦è¾“å…¥ä¸€ä¸ª 6 ä½æ•°çš„å®‰å…¨ä»£ç ï¼ŒRoblox ä¼šé€šè¿‡ç”µå­é‚®ä»¶å°†æ­¤ä»£ç å‘é€ç»™æ‚¨ã€‚{lineBreak}{lineBreak}Roblox";
	}

	/// <summary>
	/// Key: "Description.TwoStepVerificationActivationEmail.Subject"
	/// Subject for 2SV activation email
	/// English String: "2-Step Verification Activated for Roblox Account: {accountName}"
	/// </summary>
	public override string DescriptionTwoStepVerificationActivationEmailSubject(string accountName)
	{
		return $"å·²ä¸º Roblox å¸æˆ·ï¼š{accountName} æ¿€æ´»ä¸¤æ­¥éªŒè¯";
	}

	protected override string _GetTemplateForDescriptionTwoStepVerificationActivationEmailSubject()
	{
		return "å·²ä¸º Roblox å¸æˆ·ï¼š{accountName} æ¿€æ´»ä¸¤æ­¥éªŒè¯";
	}

	/// <summary>
	/// Key: "Description.TwoStepVerificationDeactivationEmail.Body.Over13"
	/// Body for 2SV deactivation email for over 13 users
	/// English String: "Hi {accountName},{lineBreak}{lineBreak}You have deactivated 2-Step Verification for your Roblox account. A security code will no longer be required when you log into your account.{lineBreak}{lineBreak}Roblox"
	/// </summary>
	public override string DescriptionTwoStepVerificationDeactivationEmailBodyOver13(string accountName, string lineBreak)
	{
		return $"ä½ å¥½ï¼Œ{accountName}ï¼š{lineBreak}{lineBreak}ä½ å·²æˆåŠŸä¸ºä½ çš„ Roblox å¸æˆ·åœç”¨ä¸¤æ­¥éªŒè¯ã€‚å½“ä½ ç™»å½•ä½ çš„å¸æˆ·æ—¶ï¼Œä½ å°†ä¸å†éœ€è¦è¾“å…¥å®‰å…¨ä»£ç ã€‚{lineBreak}{lineBreak}Roblox";
	}

	protected override string _GetTemplateForDescriptionTwoStepVerificationDeactivationEmailBodyOver13()
	{
		return "ä½ å¥½ï¼Œ{accountName}ï¼š{lineBreak}{lineBreak}ä½ å·²æˆåŠŸä¸ºä½ çš„ Roblox å¸æˆ·åœç”¨ä¸¤æ­¥éªŒè¯ã€‚å½“ä½ ç™»å½•ä½ çš„å¸æˆ·æ—¶ï¼Œä½ å°†ä¸å†éœ€è¦è¾“å…¥å®‰å…¨ä»£ç ã€‚{lineBreak}{lineBreak}Roblox";
	}

	/// <summary>
	/// Key: "Description.TwoStepVerificationDeactivationEmail.Body.Under13"
	/// Body for 2SV deactivation email for under 13 users
	/// English String: "Hi,{lineBreak}{lineBreak}2-Step Verification has been deactivated for your child's Roblox account, {accountName}. A security code will no longer be required when they log into the account.{lineBreak}{lineBreak}Roblox"
	/// </summary>
	public override string DescriptionTwoStepVerificationDeactivationEmailBodyUnder13(string lineBreak, string accountName)
	{
		return $"æ‚¨å¥½ï¼Œ{lineBreak}{lineBreak}å·²ä¸ºæ‚¨å­©å­çš„å¸æˆ·ï¼š{accountName} åœç”¨ä¸¤æ­¥è®¤è¯ã€‚å½“ä»–ä»¬ç™»å½•ä»–ä»¬çš„å¸æˆ·æ—¶ï¼Œå°†ä¸å†éœ€è¦å®‰å…¨ä»£ç ã€‚{lineBreak}{lineBreak}Roblox";
	}

	protected override string _GetTemplateForDescriptionTwoStepVerificationDeactivationEmailBodyUnder13()
	{
		return "æ‚¨å¥½ï¼Œ{lineBreak}{lineBreak}å·²ä¸ºæ‚¨å­©å­çš„å¸æˆ·ï¼š{accountName} åœç”¨ä¸¤æ­¥è®¤è¯ã€‚å½“ä»–ä»¬ç™»å½•ä»–ä»¬çš„å¸æˆ·æ—¶ï¼Œå°†ä¸å†éœ€è¦å®‰å…¨ä»£ç ã€‚{lineBreak}{lineBreak}Roblox";
	}

	/// <summary>
	/// Key: "Description.TwoStepVerificationDeactivationEmail.Subject	"
	/// Subject for 2SV deactivation email
	/// English String: "2-Step Verification Deactivated for Roblox Account: {accountName}"
	/// </summary>
	public override string DescriptionTwoStepVerificationDeactivationEmailSubject(string accountName)
	{
		return $"å·²ä¸º Roblox å¸æˆ·ï¼š{accountName} åœç”¨ä¸¤æ­¥éªŒè¯";
	}

	protected override string _GetTemplateForDescriptionTwoStepVerificationDeactivationEmailSubject()
	{
		return "å·²ä¸º Roblox å¸æˆ·ï¼š{accountName} åœç”¨ä¸¤æ­¥éªŒè¯";
	}

	/// <summary>
	/// Key: "Description.TwoStepVerificationLoginEmail.Html.GeolocationInfo1"
	/// Geolocation information about IP trying to login
	/// English String: "{spanStartTagWithBold}Login request received from {username} located in {region}, {country} ({ipAddress}).{spanEndTag}{lineBreak}{lineBreak}"
	/// </summary>
	public override string DescriptionTwoStepVerificationLoginEmailHtmlGeolocationInfo1(string spanStartTagWithBold, string username, string region, string country, string ipAddress, string spanEndTag, string lineBreak)
	{
		return $"{spanStartTagWithBold}æŽ¥æ”¶åˆ°æ¥è‡ª{username}ï¼Œä½äºŽ{country} {region} ({ipAddress}) çš„ç™»å½•è¯·æ±‚ã€‚{spanEndTag}{lineBreak}{lineBreak}";
	}

	protected override string _GetTemplateForDescriptionTwoStepVerificationLoginEmailHtmlGeolocationInfo1()
	{
		return "{spanStartTagWithBold}æŽ¥æ”¶åˆ°æ¥è‡ª{username}ï¼Œä½äºŽ{country} {region} ({ipAddress}) çš„ç™»å½•è¯·æ±‚ã€‚{spanEndTag}{lineBreak}{lineBreak}";
	}

	/// <summary>
	/// Key: "Description.TwoStepVerificationLoginEmail.Html.GeolocationInfo2"
	/// Geolocation info about IP trying to login
	/// English String: "{spanStartTagWithBold}Login request received from {username} located in {country} ({ipAddress}).{spanEndTag}{lineBreak}{lineBreak}\t"
	/// </summary>
	public override string DescriptionTwoStepVerificationLoginEmailHtmlGeolocationInfo2(string spanStartTagWithBold, string username, string country, string ipAddress, string spanEndTag, string lineBreak)
	{
		return $"{spanStartTagWithBold}æŽ¥æ”¶åˆ°æ¥è‡ª{username}ï¼Œä½äºŽ{country} ({ipAddress}) çš„ç™»å½•è¯·æ±‚ã€‚{spanEndTag}{lineBreak}{lineBreak}";
	}

	protected override string _GetTemplateForDescriptionTwoStepVerificationLoginEmailHtmlGeolocationInfo2()
	{
		return "{spanStartTagWithBold}æŽ¥æ”¶åˆ°æ¥è‡ª{username}ï¼Œä½äºŽ{country} ({ipAddress}) çš„ç™»å½•è¯·æ±‚ã€‚{spanEndTag}{lineBreak}{lineBreak}";
	}

	/// <summary>
	/// Key: "Description.TwoStepVerificationLoginEmail.Html.GeolocationInfo3"
	/// Geolocation info about IP trying to log in
	/// English String: "{spanStartTagWithBold}Login request received from {username} (From Roblox Internal).{spanEndTag}{lineBreak}{lineBreak}\t"
	/// </summary>
	public override string DescriptionTwoStepVerificationLoginEmailHtmlGeolocationInfo3(string spanStartTagWithBold, string username, string spanEndTag, string lineBreak)
	{
		return $"{spanStartTagWithBold}æŽ¥æ”¶åˆ°æ¥è‡ª{username}ï¼ˆä»Ž Roblox å†…éƒ¨ï¼‰çš„ç™»å½•è¯·æ±‚ã€‚{spanEndTag}{lineBreak}{lineBreak}";
	}

	protected override string _GetTemplateForDescriptionTwoStepVerificationLoginEmailHtmlGeolocationInfo3()
	{
		return "{spanStartTagWithBold}æŽ¥æ”¶åˆ°æ¥è‡ª{username}ï¼ˆä»Ž Roblox å†…éƒ¨ï¼‰çš„ç™»å½•è¯·æ±‚ã€‚{spanEndTag}{lineBreak}{lineBreak}";
	}

	/// <summary>
	/// Key: "Description.TwoStepVerificationLoginEmail.Html.GeolocationInfo4"
	/// Geolocation info of IP trying to login
	/// English String: "{spanStartTagWithBold}Login request received from {username} located in {country}.{spanEndTag}{lineBreak}{lineBreak}"
	/// </summary>
	public override string DescriptionTwoStepVerificationLoginEmailHtmlGeolocationInfo4(string spanStartTagWithBold, string username, string country, string spanEndTag, string lineBreak)
	{
		return $"{spanStartTagWithBold}æŽ¥æ”¶åˆ°æ¥è‡ª{username}ï¼Œä½äºŽ{country}çš„ç™»å½•è¯·æ±‚ã€‚{spanEndTag}{lineBreak}{lineBreak}";
	}

	protected override string _GetTemplateForDescriptionTwoStepVerificationLoginEmailHtmlGeolocationInfo4()
	{
		return "{spanStartTagWithBold}æŽ¥æ”¶åˆ°æ¥è‡ª{username}ï¼Œä½äºŽ{country}çš„ç™»å½•è¯·æ±‚ã€‚{spanEndTag}{lineBreak}{lineBreak}";
	}

	/// <summary>
	/// Key: "Description.TwoStepVerificationLoginEmail.Html.GeolocationInfo5"
	/// Geolocation info of IP trying to login
	/// English String: "{spanStartTagWithBold}Login request received from {username} located in {region}, {country}.{spanEndTag}{lineBreak}{lineBreak}"
	/// </summary>
	public override string DescriptionTwoStepVerificationLoginEmailHtmlGeolocationInfo5(string spanStartTagWithBold, string username, string region, string country, string spanEndTag, string lineBreak)
	{
		return $"{spanStartTagWithBold}æŽ¥æ”¶åˆ°æ¥è‡ª{username}ï¼Œä½äºŽ{country}{region}çš„ç™»å½•è¯·æ±‚ã€‚{spanEndTag}{lineBreak}{lineBreak}";
	}

	protected override string _GetTemplateForDescriptionTwoStepVerificationLoginEmailHtmlGeolocationInfo5()
	{
		return "{spanStartTagWithBold}æŽ¥æ”¶åˆ°æ¥è‡ª{username}ï¼Œä½äºŽ{country}{region}çš„ç™»å½•è¯·æ±‚ã€‚{spanEndTag}{lineBreak}{lineBreak}";
	}

	/// <summary>
	/// Key: "Description.TwoStepVerificationLoginEmail.Html.GeolocationInfo6"
	/// Geolocation info of IP trying to login
	/// English String: "{spanStartTagWithBold}Login request received from {username} located in {city}, {region}, {country}.{spanEndTag}{lineBreak}{lineBreak}"
	/// </summary>
	public override string DescriptionTwoStepVerificationLoginEmailHtmlGeolocationInfo6(string spanStartTagWithBold, string username, string city, string region, string country, string spanEndTag, string lineBreak)
	{
		return $"{spanStartTagWithBold}æŽ¥æ”¶åˆ°æ¥è‡ª{username}ï¼Œä½äºŽ{country}{region}{city}çš„ç™»å½•è¯·æ±‚ã€‚{spanEndTag}{lineBreak}{lineBreak}";
	}

	protected override string _GetTemplateForDescriptionTwoStepVerificationLoginEmailHtmlGeolocationInfo6()
	{
		return "{spanStartTagWithBold}æŽ¥æ”¶åˆ°æ¥è‡ª{username}ï¼Œä½äºŽ{country}{region}{city}çš„ç™»å½•è¯·æ±‚ã€‚{spanEndTag}{lineBreak}{lineBreak}";
	}

	/// <summary>
	/// Key: "Description.TwoStepVerificationLoginEmail.HtmlBody"
	/// Html body for 2SV login email
	/// English String: "{geoLocationInformation}{spanStartTagWithBold}Login code for {accountName}: {lineBreak}{lineBreak}{code} {spanEndTag}{lineBreak}{lineBreak}Enter this code into the 2-Step Verification screen to finish logging in. This code will expire in 15 minutes.{lineBreak}{lineBreak}This email was sent because your account tried to login to Roblox from a new browser or device. If you haven't tried logging into Roblox, someone else may be trying to access your account. You are strongly advised to change your password if you did not generate this request.{lineBreak}{lineBreak}Resources:{lineBreak}{aTagStartWithHref}{ChangePasswordLink}{hrefEnd}Change Your Password{aTagEnd} {lineBreak}{aTagStartWithHref}{TwoStepVerificationArticleLink}{hrefEnd}Learn More About 2-Step Verification{aTagEnd} {lineBreak}{aTagStartWithHref}{AccountSafetyArticleLink}{hrefEnd}Keeping Your Account Safe{aTagEnd} {lineBreak}{aTagStartWithHref}{SupportLink}{hrefEnd}General Roblox Support{aTagEnd} {lineBreak}{lineBreak}Thank you,{lineBreak}{lineBreak}The Roblox Team"
	/// </summary>
	public override string DescriptionTwoStepVerificationLoginEmailHtmlBody(string geoLocationInformation, string spanStartTagWithBold, string accountName, string lineBreak, string code, string spanEndTag, string aTagStartWithHref, string ChangePasswordLink, string hrefEnd, string aTagEnd, string TwoStepVerificationArticleLink, string AccountSafetyArticleLink, string SupportLink)
	{
		return $"{geoLocationInformation}{spanStartTagWithBold}{accountName} çš„ç™»å½•ä»£ç ï¼š {lineBreak}{lineBreak}{code}{spanEndTag}{lineBreak}{lineBreak}åœ¨ä¸¤æ­¥éªŒè¯å±å¹•è¾“å…¥æ­¤ä»£ç ï¼Œä»¥å®Œæˆç™»å½•ã€‚æ­¤ä»£ç å°†äºŽ 15 åˆ†é’ŸåŽè¿‡æœŸã€‚{lineBreak}{lineBreak}å‘é€æ­¤ç”µå­é‚®ä»¶ï¼Œæ˜¯ç”±äºŽä½ çš„å¸æˆ·è¯•å›¾ä»Žæ–°çš„æµè§ˆå™¨æˆ–è®¾å¤‡ç™»å½• Robloxã€‚å¦‚æžœä½ è¿˜æ²¡æœ‰å°è¯•ç™»å½• Robloxï¼Œé‚£ä¹ˆå…¶ä»–äººå¯èƒ½æ­£å°è¯•è®¿é—®ä½ çš„å¸æˆ·ã€‚å¦‚æžœä½ ä»Žæœªæäº¤è¿‡æ­¤è¯·æ±‚ï¼Œæˆ‘ä»¬å¼ºçƒˆå»ºè®®ä½ æ›´æ”¹å¯†ç ã€‚{lineBreak}{lineBreak}èµ„æºï¼š{lineBreak}{aTagStartWithHref}{ChangePasswordLink}{hrefEnd}æ›´æ”¹ä½ çš„å¯†ç {aTagEnd}{lineBreak}{aTagStartWithHref}{TwoStepVerificationArticleLink}{hrefEnd}è¿›ä¸€æ­¥äº†è§£ä¸¤æ­¥éªŒè¯{aTagEnd}{lineBreak}{aTagStartWithHref}{AccountSafetyArticleLink}{hrefEnd}ä¿æŒä½ çš„å¸æˆ·å®‰å…¨{aTagEnd}{lineBreak}{aTagStartWithHref}{SupportLink}{hrefEnd}Roblox å¸¸è§„æŠ€æœ¯æ”¯æŒ{aTagEnd}{lineBreak}{lineBreak}è°¢è°¢ï¼{lineBreak}{lineBreak}Roblox å›¢é˜Ÿ";
	}

	protected override string _GetTemplateForDescriptionTwoStepVerificationLoginEmailHtmlBody()
	{
		return "{geoLocationInformation}{spanStartTagWithBold}{accountName} çš„ç™»å½•ä»£ç ï¼š {lineBreak}{lineBreak}{code}{spanEndTag}{lineBreak}{lineBreak}åœ¨ä¸¤æ­¥éªŒè¯å±å¹•è¾“å…¥æ­¤ä»£ç ï¼Œä»¥å®Œæˆç™»å½•ã€‚æ­¤ä»£ç å°†äºŽ 15 åˆ†é’ŸåŽè¿‡æœŸã€‚{lineBreak}{lineBreak}å‘é€æ­¤ç”µå­é‚®ä»¶ï¼Œæ˜¯ç”±äºŽä½ çš„å¸æˆ·è¯•å›¾ä»Žæ–°çš„æµè§ˆå™¨æˆ–è®¾å¤‡ç™»å½• Robloxã€‚å¦‚æžœä½ è¿˜æ²¡æœ‰å°è¯•ç™»å½• Robloxï¼Œé‚£ä¹ˆå…¶ä»–äººå¯èƒ½æ­£å°è¯•è®¿é—®ä½ çš„å¸æˆ·ã€‚å¦‚æžœä½ ä»Žæœªæäº¤è¿‡æ­¤è¯·æ±‚ï¼Œæˆ‘ä»¬å¼ºçƒˆå»ºè®®ä½ æ›´æ”¹å¯†ç ã€‚{lineBreak}{lineBreak}èµ„æºï¼š{lineBreak}{aTagStartWithHref}{ChangePasswordLink}{hrefEnd}æ›´æ”¹ä½ çš„å¯†ç {aTagEnd}{lineBreak}{aTagStartWithHref}{TwoStepVerificationArticleLink}{hrefEnd}è¿›ä¸€æ­¥äº†è§£ä¸¤æ­¥éªŒè¯{aTagEnd}{lineBreak}{aTagStartWithHref}{AccountSafetyArticleLink}{hrefEnd}ä¿æŒä½ çš„å¸æˆ·å®‰å…¨{aTagEnd}{lineBreak}{aTagStartWithHref}{SupportLink}{hrefEnd}Roblox å¸¸è§„æŠ€æœ¯æ”¯æŒ{aTagEnd}{lineBreak}{lineBreak}è°¢è°¢ï¼{lineBreak}{lineBreak}Roblox å›¢é˜Ÿ";
	}

	/// <summary>
	/// Key: "Description.TwoStepVerificationLoginEmail.PlainBody"
	/// Plain body for 2SV login email
	/// English String: "{geoLocationInformation}Login code for {accountName}: {lineBreak}{lineBreak} {code} {lineBreak}{lineBreak}Enter this code into the 2-Step Verification screen to finish logging in. This code will expire in 15 minutes. {lineBreak}{lineBreak}This email was sent because your account tried to login to Roblox from a new browser or device. If you haven't tried logging into Roblox, someone else may be trying to access your account. You are strongly advised to change your password if you did not generate this request. {lineBreak}{lineBreak}Resources: {lineBreak}Change Your Password [{accountInfoPageLink}] {lineBreak}Learn More About 2-Step Verification [{twoStepVerificationHelpArticleLink}]{lineBreak}Keeping Your Account Safe [{keepAccountSafeArticleLink}] {lineBreak}General Roblox Support [{supportPageLink}] {lineBreak}{lineBreak}Thank you, {lineBreak}{lineBreak}The Roblox Team"
	/// </summary>
	public override string DescriptionTwoStepVerificationLoginEmailPlainBody(string geoLocationInformation, string accountName, string lineBreak, string code, string accountInfoPageLink, string twoStepVerificationHelpArticleLink, string keepAccountSafeArticleLink, string supportPageLink)
	{
		return $"{geoLocationInformation}{accountName} çš„ç™»å½•ä»£ç ï¼š {lineBreak}{lineBreak}{code}{lineBreak}{lineBreak}åœ¨ä¸¤æ­¥éªŒè¯å±å¹•è¾“å…¥æ­¤ä»£ç ï¼Œä»¥å®Œæˆç™»å½•ã€‚æ­¤ä»£ç å°†äºŽ 15 åˆ†é’ŸåŽè¿‡æœŸã€‚ {lineBreak}{lineBreak}å‘é€æ­¤ç”µå­é‚®ä»¶ï¼Œæ˜¯ç”±äºŽä½ çš„å¸æˆ·è¯•å›¾ä»Žæ–°çš„æµè§ˆå™¨æˆ–è®¾å¤‡ç™»å½• Robloxã€‚å¦‚æžœä½ è¿˜æ²¡æœ‰å°è¯•ç™»å½• Robloxï¼Œé‚£ä¹ˆå…¶ä»–äººå¯èƒ½æ­£åœ¨å°è¯•è®¿é—®ä½ çš„å¸æˆ·ã€‚å¦‚æžœä½ ä»Žæœªæäº¤è¿‡æ­¤è¯·æ±‚ï¼Œæˆ‘ä»¬å¼ºçƒˆå»ºè®®ä½ æ›´æ”¹å¯†ç ã€‚ {lineBreak}{lineBreak}èµ„æºï¼š{lineBreak}æ›´æ”¹ä½ çš„å¯†ç [{accountInfoPageLink}] {lineBreak}è¿›ä¸€æ­¥äº†è§£ä¸¤æ­¥éªŒè¯[{twoStepVerificationHelpArticleLink}]{lineBreak}ä¿æŒä½ çš„å¸æˆ·å®‰å…¨ [{keepAccountSafeArticleLink}] {lineBreak}Roblox å¸¸è§„æŠ€æœ¯æ”¯æŒ [{supportPageLink}] {lineBreak}{lineBreak}è°¢è°¢ï¼ {lineBreak}{lineBreak}Roblox å›¢é˜Ÿ";
	}

	protected override string _GetTemplateForDescriptionTwoStepVerificationLoginEmailPlainBody()
	{
		return "{geoLocationInformation}{accountName} çš„ç™»å½•ä»£ç ï¼š {lineBreak}{lineBreak}{code}{lineBreak}{lineBreak}åœ¨ä¸¤æ­¥éªŒè¯å±å¹•è¾“å…¥æ­¤ä»£ç ï¼Œä»¥å®Œæˆç™»å½•ã€‚æ­¤ä»£ç å°†äºŽ 15 åˆ†é’ŸåŽè¿‡æœŸã€‚ {lineBreak}{lineBreak}å‘é€æ­¤ç”µå­é‚®ä»¶ï¼Œæ˜¯ç”±äºŽä½ çš„å¸æˆ·è¯•å›¾ä»Žæ–°çš„æµè§ˆå™¨æˆ–è®¾å¤‡ç™»å½• Robloxã€‚å¦‚æžœä½ è¿˜æ²¡æœ‰å°è¯•ç™»å½• Robloxï¼Œé‚£ä¹ˆå…¶ä»–äººå¯èƒ½æ­£åœ¨å°è¯•è®¿é—®ä½ çš„å¸æˆ·ã€‚å¦‚æžœä½ ä»Žæœªæäº¤è¿‡æ­¤è¯·æ±‚ï¼Œæˆ‘ä»¬å¼ºçƒˆå»ºè®®ä½ æ›´æ”¹å¯†ç ã€‚ {lineBreak}{lineBreak}èµ„æºï¼š{lineBreak}æ›´æ”¹ä½ çš„å¯†ç [{accountInfoPageLink}] {lineBreak}è¿›ä¸€æ­¥äº†è§£ä¸¤æ­¥éªŒè¯[{twoStepVerificationHelpArticleLink}]{lineBreak}ä¿æŒä½ çš„å¸æˆ·å®‰å…¨ [{keepAccountSafeArticleLink}] {lineBreak}Roblox å¸¸è§„æŠ€æœ¯æ”¯æŒ [{supportPageLink}] {lineBreak}{lineBreak}è°¢è°¢ï¼ {lineBreak}{lineBreak}Roblox å›¢é˜Ÿ";
	}

	/// <summary>
	/// Key: "Description.TwoStepVerificationLoginEmail.PlainText.GeolocationInfo1"
	/// GeoLocation info of IP trying to login
	/// English String: "Login request received from {username} located in {region}, {country} ({ipAddress}).{lineBreak}{lineBreak}"
	/// </summary>
	public override string DescriptionTwoStepVerificationLoginEmailPlainTextGeolocationInfo1(string username, string region, string country, string ipAddress, string lineBreak)
	{
		return $"æŽ¥æ”¶åˆ°æ¥è‡ª{username}ï¼Œä½äºŽ{country} {region} ({ipAddress}) çš„ç™»å½•è¯·æ±‚ã€‚{lineBreak}{lineBreak}";
	}

	protected override string _GetTemplateForDescriptionTwoStepVerificationLoginEmailPlainTextGeolocationInfo1()
	{
		return "æŽ¥æ”¶åˆ°æ¥è‡ª{username}ï¼Œä½äºŽ{country} {region} ({ipAddress}) çš„ç™»å½•è¯·æ±‚ã€‚{lineBreak}{lineBreak}";
	}

	/// <summary>
	/// Key: "Description.TwoStepVerificationLoginEmail.PlainText.GeolocationInfo2"
	/// Geolocation info of IP trying to login
	/// English String: "Login request received from {username} located in {country} ({ipAddress}).{lineBreak}{lineBreak}"
	/// </summary>
	public override string DescriptionTwoStepVerificationLoginEmailPlainTextGeolocationInfo2(string username, string country, string ipAddress, string lineBreak)
	{
		return $"æŽ¥æ”¶åˆ°æ¥è‡ª{username}ï¼Œä½äºŽ{country} ({ipAddress}) çš„ç™»å½•è¯·æ±‚ã€‚{lineBreak}{lineBreak}";
	}

	protected override string _GetTemplateForDescriptionTwoStepVerificationLoginEmailPlainTextGeolocationInfo2()
	{
		return "æŽ¥æ”¶åˆ°æ¥è‡ª{username}ï¼Œä½äºŽ{country} ({ipAddress}) çš„ç™»å½•è¯·æ±‚ã€‚{lineBreak}{lineBreak}";
	}

	/// <summary>
	/// Key: "Description.TwoStepVerificationLoginEmail.PlainText.GeolocationInfo3"
	/// Geolocation info of IP trying to login
	/// English String: "Login request received from {username} (From Roblox Internal).{lineBreak}{lineBreak}"
	/// </summary>
	public override string DescriptionTwoStepVerificationLoginEmailPlainTextGeolocationInfo3(string username, string lineBreak)
	{
		return $"æŽ¥æ”¶åˆ°æ¥è‡ª{username}ï¼ˆä»Ž Roblox å†…éƒ¨ï¼‰çš„ç™»å½•è¯·æ±‚ã€‚{lineBreak}{lineBreak}";
	}

	protected override string _GetTemplateForDescriptionTwoStepVerificationLoginEmailPlainTextGeolocationInfo3()
	{
		return "æŽ¥æ”¶åˆ°æ¥è‡ª{username}ï¼ˆä»Ž Roblox å†…éƒ¨ï¼‰çš„ç™»å½•è¯·æ±‚ã€‚{lineBreak}{lineBreak}";
	}

	/// <summary>
	/// Key: "Description.TwoStepVerificationLoginEmail.PlainText.GeolocationInfo4"
	/// Geolocation info of IP trying to login
	/// English String: "Login request received from {username} located in {country}.{lineBreak}{lineBreak}"
	/// </summary>
	public override string DescriptionTwoStepVerificationLoginEmailPlainTextGeolocationInfo4(string username, string country, string lineBreak)
	{
		return $"æŽ¥æ”¶åˆ°æ¥è‡ª{username}ï¼Œä½äºŽ{country}çš„ç™»å½•è¯·æ±‚ã€‚{lineBreak}{lineBreak}";
	}

	protected override string _GetTemplateForDescriptionTwoStepVerificationLoginEmailPlainTextGeolocationInfo4()
	{
		return "æŽ¥æ”¶åˆ°æ¥è‡ª{username}ï¼Œä½äºŽ{country}çš„ç™»å½•è¯·æ±‚ã€‚{lineBreak}{lineBreak}";
	}

	/// <summary>
	/// Key: "Description.TwoStepVerificationLoginEmail.PlainText.GeolocationInfo5"
	/// Geolocation info of IP trying to login
	/// English String: "Login request received from {username} located in {region}, {country}.{lineBreak}{lineBreak}"
	/// </summary>
	public override string DescriptionTwoStepVerificationLoginEmailPlainTextGeolocationInfo5(string username, string region, string country, string lineBreak)
	{
		return $"æŽ¥æ”¶åˆ°æ¥è‡ª{username}ï¼Œä½äºŽ{country}{region}çš„ç™»å½•è¯·æ±‚ã€‚{lineBreak}{lineBreak}";
	}

	protected override string _GetTemplateForDescriptionTwoStepVerificationLoginEmailPlainTextGeolocationInfo5()
	{
		return "æŽ¥æ”¶åˆ°æ¥è‡ª{username}ï¼Œä½äºŽ{country}{region}çš„ç™»å½•è¯·æ±‚ã€‚{lineBreak}{lineBreak}";
	}

	/// <summary>
	/// Key: "Description.TwoStepVerificationLoginEmail.PlainText.GeolocationInfo6"
	/// Geolocation info of IP trying to login
	/// English String: "Login request received from {username} located in {city}, {region}, {country}.{lineBreak}{lineBreak}"
	/// </summary>
	public override string DescriptionTwoStepVerificationLoginEmailPlainTextGeolocationInfo6(string username, string city, string region, string country, string lineBreak)
	{
		return $"æŽ¥æ”¶åˆ°æ¥è‡ª{username}ï¼Œä½äºŽ{country}{region}{city}çš„ç™»å½•è¯·æ±‚ã€‚{lineBreak}{lineBreak}";
	}

	protected override string _GetTemplateForDescriptionTwoStepVerificationLoginEmailPlainTextGeolocationInfo6()
	{
		return "æŽ¥æ”¶åˆ°æ¥è‡ª{username}ï¼Œä½äºŽ{country}{region}{city}çš„ç™»å½•è¯·æ±‚ã€‚{lineBreak}{lineBreak}";
	}

	/// <summary>
	/// Key: "Description.TwoStepVerificationLoginEmail.Subject"
	/// Subject for 2SV login email
	/// English String: "Verification Code for Roblox Account: {accountName}"
	/// </summary>
	public override string DescriptionTwoStepVerificationLoginEmailSubject(string accountName)
	{
		return $"Roblox å¸æˆ·ï¼š{accountName} çš„éªŒè¯ç ";
	}

	protected override string _GetTemplateForDescriptionTwoStepVerificationLoginEmailSubject()
	{
		return "Roblox å¸æˆ·ï¼š{accountName} çš„éªŒè¯ç ";
	}

	protected override string _GetTemplateForLabelCode()
	{
		return "éªŒè¯ç ";
	}

	/// <summary>
	/// Key: "Label.CodeInputPlaceholderText"
	/// example: Enter 4-digit code
	/// English String: "Enter {codeLength}-digit Code"
	/// </summary>
	public override string LabelCodeInputPlaceholderText(string codeLength)
	{
		return $"è¾“å…¥ {codeLength} ä½éªŒè¯ç ";
	}

	protected override string _GetTemplateForLabelCodeInputPlaceholderText()
	{
		return "è¾“å…¥ {codeLength} ä½éªŒè¯ç ";
	}

	protected override string _GetTemplateForLabelDidNotReceive()
	{
		return "æ²¡æ”¶åˆ°éªŒè¯ç ï¼Ÿ";
	}

	protected override string _GetTemplateForLabelEnterCode()
	{
		return "è¾“å…¥éªŒè¯ç ï¼ˆ6 ä½ï¼‰";
	}

	protected override string _GetTemplateForLabelEnterEmailCode()
	{
		return "è¯·è¾“å…¥æˆ‘ä»¬é€šè¿‡ç”µå­é‚®ä»¶å‘é€ç»™ä½ çš„éªŒè¯ç ";
	}

	protected override string _GetTemplateForLabelEnterTextCode()
	{
		return "è¯·è¾“å…¥æˆ‘ä»¬é€šè¿‡çŸ­ä¿¡å‘é€ç»™ä½ çš„éªŒè¯ç ";
	}

	protected override string _GetTemplateForLabelEnterTwoStepVerificationCode()
	{
		return "è¾“å…¥ä½ çš„ä¸¤æ­¥éªŒè¯ç ã€‚";
	}

	protected override string _GetTemplateForLabelFacebookPasswordWarning()
	{
		return "å¦‚æžœä½ ä½¿ç”¨ Facebook ç™»å½•ï¼Œåˆ™å¿…é¡»è®¾å®šå¯†ç ã€‚";
	}

	protected override string _GetTemplateForLabelLearnMore()
	{
		return "äº†è§£æ›´å¤š";
	}

	/// <summary>
	/// Key: "Label.NeedHelpContactSupport"
	/// label for the support article link
	/// English String: "Need help? Contact {supportLink}"
	/// </summary>
	public override string LabelNeedHelpContactSupport(string supportLink)
	{
		return $"éœ€è¦å¸®åŠ©ï¼Ÿè¯·è”ç³» {supportLink}";
	}

	protected override string _GetTemplateForLabelNeedHelpContactSupport()
	{
		return "éœ€è¦å¸®åŠ©ï¼Ÿè¯·è”ç³» {supportLink}";
	}

	protected override string _GetTemplateForLabelNewCode()
	{
		return "æ–°éªŒè¯ç ";
	}

	protected override string _GetTemplateForLabelRobloxSupport()
	{
		return "Roblox æ”¯æŒ";
	}

	protected override string _GetTemplateForLabelTrustThisDevice()
	{
		return "ä¿¡ä»»æ­¤è£…ç½® 30 å¤©";
	}

	protected override string _GetTemplateForLabelTwoStepVerification()
	{
		return "ä¸¤æ­¥éªŒè¯";
	}

	protected override string _GetTemplateForResponseCodeSent()
	{
		return "éªŒè¯ç å·²å‘é€";
	}

	protected override string _GetTemplateForResponseFeatureNotAvailable()
	{
		return "åŠŸèƒ½ä¸å¯ç”¨ã€‚è¯·è”ç³»æŠ€æœ¯æ”¯æŒã€‚";
	}

	protected override string _GetTemplateForResponseInvalidCode()
	{
		return "éªŒè¯ç æ— æ•ˆã€‚";
	}

	protected override string _GetTemplateForResponseSystemErrorReturnToLogin()
	{
		return "ç³»ç»Ÿé”™è¯¯ã€‚è¯·è¿”å›žç™»å½•å±å¹•ã€‚";
	}

	protected override string _GetTemplateForResponseTooManyAttempts()
	{
		return "å°è¯•æ¬¡æ•°è¿‡å¤šã€‚è¯·ç¨åŽé‡è¯•ã€‚";
	}

	protected override string _GetTemplateForResponseTooManyCharacters()
	{
		return "å­—ç¬¦è¿‡å¤š";
	}
}


}
