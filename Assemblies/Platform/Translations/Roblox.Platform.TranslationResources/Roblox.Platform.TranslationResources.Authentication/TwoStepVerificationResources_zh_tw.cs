namespace Roblox.Platform.TranslationResources.Authentication {
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
	public override string ActionCancel => "å–æ¶ˆ";

	/// <summary>
	/// Key: "Action.Resend"
	/// English String: "Resend Code"
	/// </summary>
	public override string ActionResend => "é‡æ–°å‚³é€é©—è­‰ç¢¼";

	/// <summary>
	/// Key: "Action.StartOver"
	/// link text to restart verification
	/// English String: "Start Over"
	/// </summary>
	public override string ActionStartOver => "é‡æ–°é–‹å§‹";

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
	public override string ActionVerify => "é©—è­‰";

	/// <summary>
	/// Key: "Label.Code"
	/// verification code for 2 factor authentication
	/// English String: "Code"
	/// </summary>
	public override string LabelCode => "é©—è­‰ç¢¼";

	/// <summary>
	/// Key: "Label.DidNotReceive"
	/// English String: "Didn't receive the code?"
	/// </summary>
	public override string LabelDidNotReceive => "æ²’æœ‰æ”¶åˆ°ä»£ç¢¼ï¼Ÿ";

	/// <summary>
	/// Key: "Label.EnterCode"
	/// English String: "Enter Code (6-digit)"
	/// </summary>
	public override string LabelEnterCode => "è¼¸å…¥é©—è­‰ç¢¼ï¼ˆ6 ä½æ•¸ï¼‰";

	/// <summary>
	/// Key: "Label.EnterEmailCode"
	/// English String: "Enter the code we just sent you via email"
	/// </summary>
	public override string LabelEnterEmailCode => "è«‹è¼¸å…¥å‚³é€åˆ°æ‚¨çš„é›»å­éƒµä»¶ä¿¡ç®±çš„é©—è­‰ç¢¼";

	/// <summary>
	/// Key: "Label.EnterTextCode"
	/// English String: "Enter the code we just sent you via text message"
	/// </summary>
	public override string LabelEnterTextCode => "è«‹è¼¸å…¥å‚³é€åˆ°æ‚¨çš„æ‰‹æ©Ÿçš„é©—è­‰ç¢¼";

	/// <summary>
	/// Key: "Label.EnterTwoStepVerificationCode"
	/// Enter your two step verification code.
	/// English String: "Enter your two step verification code."
	/// </summary>
	public override string LabelEnterTwoStepVerificationCode => "è«‹è¼¸å…¥é›™æ­¥é©Ÿé©—è­‰ç¢¼ã€‚";

	/// <summary>
	/// Key: "Label.FacebookPasswordWarning"
	/// If you have been signing in with Facebook, you must set a password.
	/// English String: "If you have been signing in with Facebook, you must set a password."
	/// </summary>
	public override string LabelFacebookPasswordWarning => "è‹¥æ‚¨ä»¥ Facebook ç™»å…¥ï¼Œè«‹è¨­å®šå¯†ç¢¼ã€‚";

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
	public override string LabelNewCode => "æ–°é©—è­‰ç¢¼";

	/// <summary>
	/// Key: "Label.RobloxSupport"
	/// English String: "Roblox Support"
	/// </summary>
	public override string LabelRobloxSupport => "Roblox å”åŠ©";

	/// <summary>
	/// Key: "Label.TrustThisDevice"
	/// English String: "Trust this device for 30 days"
	/// </summary>
	public override string LabelTrustThisDevice => "ä¿¡ä»»æ­¤è£ç½® 30 å¤©";

	/// <summary>
	/// Key: "Label.TwoStepVerification"
	/// English String: "2-Step Verification"
	/// </summary>
	public override string LabelTwoStepVerification => "é›™æ­¥é©Ÿé©—è­‰";

	/// <summary>
	/// Key: "Response.CodeSent"
	/// English String: "Code Sent"
	/// </summary>
	public override string ResponseCodeSent => "é©—è­‰ç¢¼å·²å‚³é€";

	/// <summary>
	/// Key: "Response.FeatureNotAvailable"
	/// English String: "Feature not available. Please contact support."
	/// </summary>
	public override string ResponseFeatureNotAvailable => "ç„¡æ³•ä½¿ç”¨æ­¤åŠŸèƒ½ï¼Œè«‹è¯çµ¡å®¢æœäººå“¡ã€‚";

	/// <summary>
	/// Key: "Response.InvalidCode"
	/// English String: "Invalid code."
	/// </summary>
	public override string ResponseInvalidCode => "é©—è­‰ç¢¼ç„¡æ•ˆã€‚";

	/// <summary>
	/// Key: "Response.SystemErrorReturnToLogin"
	/// English String: "System error. Please return to login screen."
	/// </summary>
	public override string ResponseSystemErrorReturnToLogin => "ç³»çµ±éŒ¯èª¤ï¼Œè«‹è¿”å›žç™»å…¥ç•«é¢ã€‚";

	/// <summary>
	/// Key: "Response.TooManyAttempts"
	/// English String: "Too many attempts. Please try again later."
	/// </summary>
	public override string ResponseTooManyAttempts => "å˜—è©¦æ¬¡æ•¸éŽå¤šï¼Œè«‹ç¨å¾Œå†è©¦ã€‚";

	/// <summary>
	/// Key: "Response.TooManyCharacters"
	/// error message
	/// English String: "Too many characters"
	/// </summary>
	public override string ResponseTooManyCharacters => "å­—å…ƒéŽå¤š";

	public TwoStepVerificationResources_zh_tw(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionCancel()
	{
		return "å–æ¶ˆ";
	}

	protected override string _GetTemplateForActionResend()
	{
		return "é‡æ–°å‚³é€é©—è­‰ç¢¼";
	}

	protected override string _GetTemplateForActionStartOver()
	{
		return "é‡æ–°é–‹å§‹";
	}

	protected override string _GetTemplateForActionSubmit()
	{
		return "æäº¤";
	}

	protected override string _GetTemplateForActionVerify()
	{
		return "é©—è­‰";
	}

	/// <summary>
	/// Key: "Description.TwoStepVerificationActivationEmail.Body.Over13"
	/// Body for 2SV activation email for over 13 users
	/// English String: "Hi {accountName},{lineBreak}{lineBreak}You have activated 2-Step Verification for your Roblox account. Next time you log in from a new device, you will need to enter a 6-digit security code that Roblox sends to you via email.{lineBreak}{lineBreak}Roblox"
	/// </summary>
	public override string DescriptionTwoStepVerificationActivationEmailBodyOver13(string accountName, string lineBreak)
	{
		return $"æ‚¨å¥½ï¼Œ{accountName}ï¼Œ{lineBreak}{lineBreak}æ‚¨å·²ç‚º Roblox å¸³æˆ¶å•Ÿç”¨ 2 æ­¥é©Ÿé©—è­‰ã€‚ä¸‹æ¬¡æ‚¨å¾žæ–°çš„è£ç½®ç™»å…¥æ™‚ï¼Œæœƒéœ€è¦è¼¸å…¥ 6 ä½å®‰å…¨ç¢¼ï¼ŒRoblox å·²å°‡æ­¤å®‰å…¨ç¢¼ç¶“ç”±é›»å­éƒµä»¶å‚³é€çµ¦æ‚¨ã€‚{lineBreak}{lineBreak}Roblox æ•¬ä¸Š";
	}

	protected override string _GetTemplateForDescriptionTwoStepVerificationActivationEmailBodyOver13()
	{
		return "æ‚¨å¥½ï¼Œ{accountName}ï¼Œ{lineBreak}{lineBreak}æ‚¨å·²ç‚º Roblox å¸³æˆ¶å•Ÿç”¨ 2 æ­¥é©Ÿé©—è­‰ã€‚ä¸‹æ¬¡æ‚¨å¾žæ–°çš„è£ç½®ç™»å…¥æ™‚ï¼Œæœƒéœ€è¦è¼¸å…¥ 6 ä½å®‰å…¨ç¢¼ï¼ŒRoblox å·²å°‡æ­¤å®‰å…¨ç¢¼ç¶“ç”±é›»å­éƒµä»¶å‚³é€çµ¦æ‚¨ã€‚{lineBreak}{lineBreak}Roblox æ•¬ä¸Š";
	}

	/// <summary>
	/// Key: "Description.TwoStepVerificationActivationEmail.Body.Under13"
	/// Body for 2SV activation email for under 13 users
	/// English String: "Hi,{lineBreak}{lineBreak}2-Step Verification has been activated for your child's Roblox account, {accountName}. Next time they log in from a new device, they will need to enter a 6-digit security code that Roblox sends to you via email.{lineBreak}{lineBreak}Roblox"
	/// </summary>
	public override string DescriptionTwoStepVerificationActivationEmailBodyUnder13(string lineBreak, string accountName)
	{
		return $"æ‚¨å¥½ï¼Œ{lineBreak}{lineBreak}æ‚¨å­©å­çš„ Roblox å¸³æˆ¶ {accountName} ç¾å·²å•Ÿç”¨ 2 æ­¥é©Ÿé©—è­‰ã€‚ä»–å€‘ä¸‹æ¬¡å¾žæ–°çš„è£ç½®ç™»å…¥æ™‚ï¼Œæœƒéœ€è¦è¼¸å…¥ 6 ä½å®‰å…¨ç¢¼ï¼ŒRoblox å·²å°‡æ­¤å®‰å…¨ç¢¼ç¶“ç”±é›»å­éƒµä»¶å‚³é€çµ¦æ‚¨ã€‚{lineBreak}{lineBreak}Roblox æ•¬ä¸Š";
	}

	protected override string _GetTemplateForDescriptionTwoStepVerificationActivationEmailBodyUnder13()
	{
		return "æ‚¨å¥½ï¼Œ{lineBreak}{lineBreak}æ‚¨å­©å­çš„ Roblox å¸³æˆ¶ {accountName} ç¾å·²å•Ÿç”¨ 2 æ­¥é©Ÿé©—è­‰ã€‚ä»–å€‘ä¸‹æ¬¡å¾žæ–°çš„è£ç½®ç™»å…¥æ™‚ï¼Œæœƒéœ€è¦è¼¸å…¥ 6 ä½å®‰å…¨ç¢¼ï¼ŒRoblox å·²å°‡æ­¤å®‰å…¨ç¢¼ç¶“ç”±é›»å­éƒµä»¶å‚³é€çµ¦æ‚¨ã€‚{lineBreak}{lineBreak}Roblox æ•¬ä¸Š";
	}

	/// <summary>
	/// Key: "Description.TwoStepVerificationActivationEmail.Subject"
	/// Subject for 2SV activation email
	/// English String: "2-Step Verification Activated for Roblox Account: {accountName}"
	/// </summary>
	public override string DescriptionTwoStepVerificationActivationEmailSubject(string accountName)
	{
		return $"å·²å•Ÿç”¨ Roblox å¸³æˆ¶çš„ 2 æ­¥é©Ÿé©—è­‰ï¼š{accountName}";
	}

	protected override string _GetTemplateForDescriptionTwoStepVerificationActivationEmailSubject()
	{
		return "å·²å•Ÿç”¨ Roblox å¸³æˆ¶çš„ 2 æ­¥é©Ÿé©—è­‰ï¼š{accountName}";
	}

	/// <summary>
	/// Key: "Description.TwoStepVerificationDeactivationEmail.Body.Over13"
	/// Body for 2SV deactivation email for over 13 users
	/// English String: "Hi {accountName},{lineBreak}{lineBreak}You have deactivated 2-Step Verification for your Roblox account. A security code will no longer be required when you log into your account.{lineBreak}{lineBreak}Roblox"
	/// </summary>
	public override string DescriptionTwoStepVerificationDeactivationEmailBodyOver13(string accountName, string lineBreak)
	{
		return $"æ‚¨å¥½ï¼Œ{accountName}ï¼Œ{lineBreak}{lineBreak}æ‚¨å·²ç‚º Roblox å¸³æˆ¶åœç”¨ 2 æ­¥é©Ÿé©—è­‰ã€‚ç•¶æ‚¨ç™»å…¥å¸³æˆ¶æ™‚ï¼Œä¸å†éœ€è¦ä½¿ç”¨å®‰å…¨ç¢¼ã€‚{lineBreak}{lineBreak}Roblox æ•¬ä¸Š";
	}

	protected override string _GetTemplateForDescriptionTwoStepVerificationDeactivationEmailBodyOver13()
	{
		return "æ‚¨å¥½ï¼Œ{accountName}ï¼Œ{lineBreak}{lineBreak}æ‚¨å·²ç‚º Roblox å¸³æˆ¶åœç”¨ 2 æ­¥é©Ÿé©—è­‰ã€‚ç•¶æ‚¨ç™»å…¥å¸³æˆ¶æ™‚ï¼Œä¸å†éœ€è¦ä½¿ç”¨å®‰å…¨ç¢¼ã€‚{lineBreak}{lineBreak}Roblox æ•¬ä¸Š";
	}

	/// <summary>
	/// Key: "Description.TwoStepVerificationDeactivationEmail.Body.Under13"
	/// Body for 2SV deactivation email for under 13 users
	/// English String: "Hi,{lineBreak}{lineBreak}2-Step Verification has been deactivated for your child's Roblox account, {accountName}. A security code will no longer be required when they log into the account.{lineBreak}{lineBreak}Roblox"
	/// </summary>
	public override string DescriptionTwoStepVerificationDeactivationEmailBodyUnder13(string lineBreak, string accountName)
	{
		return $"æ‚¨å¥½ï¼Œ{lineBreak}{lineBreak}æ‚¨å­©å­çš„ Roblox å¸³æˆ¶ {accountName} å·²åœç”¨ 2 æ­¥é©Ÿé©—è­‰ã€‚ä»–å€‘ç™»å…¥å¸³æˆ¶æ™‚ï¼Œä¸å†éœ€è¦ä½¿ç”¨å®‰å…¨ç¢¼ã€‚{lineBreak}{lineBreak}Roblox æ•¬ä¸Š";
	}

	protected override string _GetTemplateForDescriptionTwoStepVerificationDeactivationEmailBodyUnder13()
	{
		return "æ‚¨å¥½ï¼Œ{lineBreak}{lineBreak}æ‚¨å­©å­çš„ Roblox å¸³æˆ¶ {accountName} å·²åœç”¨ 2 æ­¥é©Ÿé©—è­‰ã€‚ä»–å€‘ç™»å…¥å¸³æˆ¶æ™‚ï¼Œä¸å†éœ€è¦ä½¿ç”¨å®‰å…¨ç¢¼ã€‚{lineBreak}{lineBreak}Roblox æ•¬ä¸Š";
	}

	/// <summary>
	/// Key: "Description.TwoStepVerificationDeactivationEmail.Subject	"
	/// Subject for 2SV deactivation email
	/// English String: "2-Step Verification Deactivated for Roblox Account: {accountName}"
	/// </summary>
	public override string DescriptionTwoStepVerificationDeactivationEmailSubject(string accountName)
	{
		return $"å·²åœç”¨ Roblox å¸³æˆ¶çš„ 2 æ­¥é©Ÿé©—è­‰ï¼š{accountName}";
	}

	protected override string _GetTemplateForDescriptionTwoStepVerificationDeactivationEmailSubject()
	{
		return "å·²åœç”¨ Roblox å¸³æˆ¶çš„ 2 æ­¥é©Ÿé©—è­‰ï¼š{accountName}";
	}

	/// <summary>
	/// Key: "Description.TwoStepVerificationLoginEmail.Html.GeolocationInfo1"
	/// Geolocation information about IP trying to login
	/// English String: "{spanStartTagWithBold}Login request received from {username} located in {region}, {country} ({ipAddress}).{spanEndTag}{lineBreak}{lineBreak}"
	/// </summary>
	public override string DescriptionTwoStepVerificationLoginEmailHtmlGeolocationInfo1(string spanStartTagWithBold, string username, string region, string country, string ipAddress, string spanEndTag, string lineBreak)
	{
		return $"{spanStartTagWithBold}æ”¶åˆ°ä½æ–¼{country}ã€{region}ï¼ˆ{ipAddress}ï¼‰ï¼Œä¾†è‡ª{username}çš„ç™»å…¥è«‹æ±‚ã€‚{spanEndTag}{lineBreak}{lineBreak}";
	}

	protected override string _GetTemplateForDescriptionTwoStepVerificationLoginEmailHtmlGeolocationInfo1()
	{
		return "{spanStartTagWithBold}æ”¶åˆ°ä½æ–¼{country}ã€{region}ï¼ˆ{ipAddress}ï¼‰ï¼Œä¾†è‡ª{username}çš„ç™»å…¥è«‹æ±‚ã€‚{spanEndTag}{lineBreak}{lineBreak}";
	}

	/// <summary>
	/// Key: "Description.TwoStepVerificationLoginEmail.Html.GeolocationInfo2"
	/// Geolocation info about IP trying to login
	/// English String: "{spanStartTagWithBold}Login request received from {username} located in {country} ({ipAddress}).{spanEndTag}{lineBreak}{lineBreak}\t"
	/// </summary>
	public override string DescriptionTwoStepVerificationLoginEmailHtmlGeolocationInfo2(string spanStartTagWithBold, string username, string country, string ipAddress, string spanEndTag, string lineBreak)
	{
		return $"{spanStartTagWithBold}æ”¶åˆ°ä½æ–¼{country}ï¼Œä¾†è‡ª{username}çš„ç™»å…¥è«‹æ±‚ï¼ˆ{ipAddress}ï¼‰ã€‚{spanEndTag}{lineBreak}{lineBreak}\t";
	}

	protected override string _GetTemplateForDescriptionTwoStepVerificationLoginEmailHtmlGeolocationInfo2()
	{
		return "{spanStartTagWithBold}æ”¶åˆ°ä½æ–¼{country}ï¼Œä¾†è‡ª{username}çš„ç™»å…¥è«‹æ±‚ï¼ˆ{ipAddress}ï¼‰ã€‚{spanEndTag}{lineBreak}{lineBreak}\t";
	}

	/// <summary>
	/// Key: "Description.TwoStepVerificationLoginEmail.Html.GeolocationInfo3"
	/// Geolocation info about IP trying to log in
	/// English String: "{spanStartTagWithBold}Login request received from {username} (From Roblox Internal).{spanEndTag}{lineBreak}{lineBreak}\t"
	/// </summary>
	public override string DescriptionTwoStepVerificationLoginEmailHtmlGeolocationInfo3(string spanStartTagWithBold, string username, string spanEndTag, string lineBreak)
	{
		return $"{spanStartTagWithBold}æ”¶åˆ°ä¾†è‡ª {username}çš„ç™»å…¥è«‹æ±‚ï¼ˆä¾†è‡ªRoblox å…§éƒ¨ï¼‰ã€‚{spanEndTag}{lineBreak}{lineBreak}\t";
	}

	protected override string _GetTemplateForDescriptionTwoStepVerificationLoginEmailHtmlGeolocationInfo3()
	{
		return "{spanStartTagWithBold}æ”¶åˆ°ä¾†è‡ª {username}çš„ç™»å…¥è«‹æ±‚ï¼ˆä¾†è‡ªRoblox å…§éƒ¨ï¼‰ã€‚{spanEndTag}{lineBreak}{lineBreak}\t";
	}

	/// <summary>
	/// Key: "Description.TwoStepVerificationLoginEmail.Html.GeolocationInfo4"
	/// Geolocation info of IP trying to login
	/// English String: "{spanStartTagWithBold}Login request received from {username} located in {country}.{spanEndTag}{lineBreak}{lineBreak}"
	/// </summary>
	public override string DescriptionTwoStepVerificationLoginEmailHtmlGeolocationInfo4(string spanStartTagWithBold, string username, string country, string spanEndTag, string lineBreak)
	{
		return $"{spanStartTagWithBold}æ”¶åˆ° {username} ä¾†è‡ª{country}çš„ç™»å…¥è«‹æ±‚ã€‚{spanEndTag}{lineBreak}{lineBreak}";
	}

	protected override string _GetTemplateForDescriptionTwoStepVerificationLoginEmailHtmlGeolocationInfo4()
	{
		return "{spanStartTagWithBold}æ”¶åˆ° {username} ä¾†è‡ª{country}çš„ç™»å…¥è«‹æ±‚ã€‚{spanEndTag}{lineBreak}{lineBreak}";
	}

	/// <summary>
	/// Key: "Description.TwoStepVerificationLoginEmail.Html.GeolocationInfo5"
	/// Geolocation info of IP trying to login
	/// English String: "{spanStartTagWithBold}Login request received from {username} located in {region}, {country}.{spanEndTag}{lineBreak}{lineBreak}"
	/// </summary>
	public override string DescriptionTwoStepVerificationLoginEmailHtmlGeolocationInfo5(string spanStartTagWithBold, string username, string region, string country, string spanEndTag, string lineBreak)
	{
		return $"{spanStartTagWithBold}æ”¶åˆ° {username} ä¾†è‡ª{country}{region}çš„ç™»å…¥è«‹æ±‚ã€‚{spanEndTag}{lineBreak}{lineBreak}";
	}

	protected override string _GetTemplateForDescriptionTwoStepVerificationLoginEmailHtmlGeolocationInfo5()
	{
		return "{spanStartTagWithBold}æ”¶åˆ° {username} ä¾†è‡ª{country}{region}çš„ç™»å…¥è«‹æ±‚ã€‚{spanEndTag}{lineBreak}{lineBreak}";
	}

	/// <summary>
	/// Key: "Description.TwoStepVerificationLoginEmail.Html.GeolocationInfo6"
	/// Geolocation info of IP trying to login
	/// English String: "{spanStartTagWithBold}Login request received from {username} located in {city}, {region}, {country}.{spanEndTag}{lineBreak}{lineBreak}"
	/// </summary>
	public override string DescriptionTwoStepVerificationLoginEmailHtmlGeolocationInfo6(string spanStartTagWithBold, string username, string city, string region, string country, string spanEndTag, string lineBreak)
	{
		return $"{spanStartTagWithBold}æ”¶åˆ° {username} ä¾†è‡ª{country}{region}{city}çš„ç™»å…¥è«‹æ±‚ã€‚{spanEndTag}{lineBreak}{lineBreak}";
	}

	protected override string _GetTemplateForDescriptionTwoStepVerificationLoginEmailHtmlGeolocationInfo6()
	{
		return "{spanStartTagWithBold}æ”¶åˆ° {username} ä¾†è‡ª{country}{region}{city}çš„ç™»å…¥è«‹æ±‚ã€‚{spanEndTag}{lineBreak}{lineBreak}";
	}

	/// <summary>
	/// Key: "Description.TwoStepVerificationLoginEmail.HtmlBody"
	/// Html body for 2SV login email
	/// English String: "{geoLocationInformation}{spanStartTagWithBold}Login code for {accountName}: {lineBreak}{lineBreak}{code} {spanEndTag}{lineBreak}{lineBreak}Enter this code into the 2-Step Verification screen to finish logging in. This code will expire in 15 minutes.{lineBreak}{lineBreak}This email was sent because your account tried to login to Roblox from a new browser or device. If you haven't tried logging into Roblox, someone else may be trying to access your account. You are strongly advised to change your password if you did not generate this request.{lineBreak}{lineBreak}Resources:{lineBreak}{aTagStartWithHref}{ChangePasswordLink}{hrefEnd}Change Your Password{aTagEnd} {lineBreak}{aTagStartWithHref}{TwoStepVerificationArticleLink}{hrefEnd}Learn More About 2-Step Verification{aTagEnd} {lineBreak}{aTagStartWithHref}{AccountSafetyArticleLink}{hrefEnd}Keeping Your Account Safe{aTagEnd} {lineBreak}{aTagStartWithHref}{SupportLink}{hrefEnd}General Roblox Support{aTagEnd} {lineBreak}{lineBreak}Thank you,{lineBreak}{lineBreak}The Roblox Team"
	/// </summary>
	public override string DescriptionTwoStepVerificationLoginEmailHtmlBody(string geoLocationInformation, string spanStartTagWithBold, string accountName, string lineBreak, string code, string spanEndTag, string aTagStartWithHref, string ChangePasswordLink, string hrefEnd, string aTagEnd, string TwoStepVerificationArticleLink, string AccountSafetyArticleLink, string SupportLink)
	{
		return $"{geoLocationInformation}{spanStartTagWithBold}{accountName}çš„ç™»å…¥ä»£ç¢¼ï¼š{lineBreak}{lineBreak}{code} {spanEndTag}{lineBreak}{lineBreak}åœ¨ 2 æ­¥é©Ÿé©—è­‰ç•«é¢è¼¸å…¥æ­¤ä»£ç¢¼å¯å®Œæˆç™»å…¥ã€‚æ­¤ä»£ç¢¼å°‡åœ¨ 15 åˆ†é˜å¾Œåˆ°æœŸã€‚{lineBreak}{lineBreak}å¯„é€æ­¤é›»å­éƒµä»¶æ˜¯å› ç‚ºæ­£åœ¨å˜—è©¦å¾žæ–°çš„ç€è¦½å™¨æˆ–è£ç½®ä»¥æ‚¨çš„å¸³æˆ¶ç™»å…¥ Robloxã€‚è‹¥æ‚¨ä¸¦æœªå˜—è©¦ç™»å…¥ Robloxï¼Œå¯èƒ½æœ‰å…¶ä»–äººè©¦åœ–å­˜å–æ‚¨çš„å¸³æˆ¶ã€‚è‹¥æ‚¨ä¸¦æœªç™¼å‡ºæ­¤è¦æ±‚ï¼Œæ¥µåŠ›å»ºè­°æ‚¨è®Šæ›´å¯†ç¢¼ã€‚{lineBreak}{lineBreak}è³‡æºï¼š{lineBreak}{aTagStartWithHref}{ChangePasswordLink}{hrefEnd}è®Šæ›´æ‚¨çš„å¯†ç¢¼{aTagEnd} {lineBreak}{aTagStartWithHref}{TwoStepVerificationArticleLink}{hrefEnd}é€²ä¸€æ­¥çž­è§£ 2 æ­¥é©Ÿé©—è­‰{aTagEnd} {lineBreak}{aTagStartWithHref}{AccountSafetyArticleLink}{hrefEnd}ä¿æŒæ‚¨çš„å¸³æˆ¶å®‰å…¨{aTagEnd} {lineBreak}{aTagStartWithHref}{SupportLink}{hrefEnd}ä¸€èˆ¬ Roblox æ”¯æ´{aTagEnd} {lineBreak}{lineBreak}æ„Ÿè¬æ‚¨{lineBreak}{lineBreak}Roblox åœ˜éšŠæ•¬ä¸Š";
	}

	protected override string _GetTemplateForDescriptionTwoStepVerificationLoginEmailHtmlBody()
	{
		return "{geoLocationInformation}{spanStartTagWithBold}{accountName}çš„ç™»å…¥ä»£ç¢¼ï¼š{lineBreak}{lineBreak}{code} {spanEndTag}{lineBreak}{lineBreak}åœ¨ 2 æ­¥é©Ÿé©—è­‰ç•«é¢è¼¸å…¥æ­¤ä»£ç¢¼å¯å®Œæˆç™»å…¥ã€‚æ­¤ä»£ç¢¼å°‡åœ¨ 15 åˆ†é˜å¾Œåˆ°æœŸã€‚{lineBreak}{lineBreak}å¯„é€æ­¤é›»å­éƒµä»¶æ˜¯å› ç‚ºæ­£åœ¨å˜—è©¦å¾žæ–°çš„ç€è¦½å™¨æˆ–è£ç½®ä»¥æ‚¨çš„å¸³æˆ¶ç™»å…¥ Robloxã€‚è‹¥æ‚¨ä¸¦æœªå˜—è©¦ç™»å…¥ Robloxï¼Œå¯èƒ½æœ‰å…¶ä»–äººè©¦åœ–å­˜å–æ‚¨çš„å¸³æˆ¶ã€‚è‹¥æ‚¨ä¸¦æœªç™¼å‡ºæ­¤è¦æ±‚ï¼Œæ¥µåŠ›å»ºè­°æ‚¨è®Šæ›´å¯†ç¢¼ã€‚{lineBreak}{lineBreak}è³‡æºï¼š{lineBreak}{aTagStartWithHref}{ChangePasswordLink}{hrefEnd}è®Šæ›´æ‚¨çš„å¯†ç¢¼{aTagEnd} {lineBreak}{aTagStartWithHref}{TwoStepVerificationArticleLink}{hrefEnd}é€²ä¸€æ­¥çž­è§£ 2 æ­¥é©Ÿé©—è­‰{aTagEnd} {lineBreak}{aTagStartWithHref}{AccountSafetyArticleLink}{hrefEnd}ä¿æŒæ‚¨çš„å¸³æˆ¶å®‰å…¨{aTagEnd} {lineBreak}{aTagStartWithHref}{SupportLink}{hrefEnd}ä¸€èˆ¬ Roblox æ”¯æ´{aTagEnd} {lineBreak}{lineBreak}æ„Ÿè¬æ‚¨{lineBreak}{lineBreak}Roblox åœ˜éšŠæ•¬ä¸Š";
	}

	/// <summary>
	/// Key: "Description.TwoStepVerificationLoginEmail.PlainBody"
	/// Plain body for 2SV login email
	/// English String: "{geoLocationInformation}Login code for {accountName}: {lineBreak}{lineBreak} {code} {lineBreak}{lineBreak}Enter this code into the 2-Step Verification screen to finish logging in. This code will expire in 15 minutes. {lineBreak}{lineBreak}This email was sent because your account tried to login to Roblox from a new browser or device. If you haven't tried logging into Roblox, someone else may be trying to access your account. You are strongly advised to change your password if you did not generate this request. {lineBreak}{lineBreak}Resources: {lineBreak}Change Your Password [{accountInfoPageLink}] {lineBreak}Learn More About 2-Step Verification [{twoStepVerificationHelpArticleLink}]{lineBreak}Keeping Your Account Safe [{keepAccountSafeArticleLink}] {lineBreak}General Roblox Support [{supportPageLink}] {lineBreak}{lineBreak}Thank you, {lineBreak}{lineBreak}The Roblox Team"
	/// </summary>
	public override string DescriptionTwoStepVerificationLoginEmailPlainBody(string geoLocationInformation, string accountName, string lineBreak, string code, string accountInfoPageLink, string twoStepVerificationHelpArticleLink, string keepAccountSafeArticleLink, string supportPageLink)
	{
		return $"{geoLocationInformation}{accountName}çš„ç™»å…¥ä»£ç¢¼ï¼š{lineBreak}{lineBreak} {code} {lineBreak}{lineBreak}åœ¨ 2 æ­¥é©Ÿé©—è­‰ç•«é¢è¼¸å…¥æ­¤ä»£ç¢¼å¯å®Œæˆç™»å…¥ã€‚æ­¤ä»£ç¢¼å°‡åœ¨ 15 åˆ†é˜å¾Œåˆ°æœŸã€‚{lineBreak}{lineBreak}å¯„é€æ­¤é›»å­éƒµä»¶æ˜¯å› ç‚ºæ­£åœ¨å˜—è©¦å¾žæ–°çš„ç€è¦½å™¨æˆ–è£ç½®ä»¥æ‚¨çš„å¸³æˆ¶ç™»å…¥ Robloxã€‚è‹¥æ‚¨ä¸¦æœªå˜—è©¦ç™»å…¥ Robloxï¼Œå¯èƒ½æœ‰å…¶ä»–äººè©¦åœ–å­˜å–æ‚¨çš„å¸³æˆ¶ã€‚è‹¥æ‚¨ä¸¦æœªç™¼å‡ºæ­¤è¦æ±‚ï¼Œæ¥µåŠ›å»ºè­°æ‚¨è®Šæ›´å¯†ç¢¼ã€‚{lineBreak}{lineBreak}è³‡æºï¼š{lineBreak}è®Šæ›´æ‚¨çš„å¯†ç¢¼ [{accountInfoPageLink}] {lineBreak}é€²ä¸€æ­¥çž­è§£ 2 æ­¥é©Ÿé©—è­‰ [{twoStepVerificationHelpArticleLink}]{lineBreak}ä¿æŒæ‚¨çš„å¸³æˆ¶å®‰å…¨ [{keepAccountSafeArticleLink}] {lineBreak}ä¸€èˆ¬ Roblox æ”¯æ´ [{supportPageLink}] {lineBreak}{lineBreak}æ„Ÿè¬æ‚¨{lineBreak}{lineBreak}Roblox åœ˜éšŠæ•¬ä¸Š";
	}

	protected override string _GetTemplateForDescriptionTwoStepVerificationLoginEmailPlainBody()
	{
		return "{geoLocationInformation}{accountName}çš„ç™»å…¥ä»£ç¢¼ï¼š{lineBreak}{lineBreak} {code} {lineBreak}{lineBreak}åœ¨ 2 æ­¥é©Ÿé©—è­‰ç•«é¢è¼¸å…¥æ­¤ä»£ç¢¼å¯å®Œæˆç™»å…¥ã€‚æ­¤ä»£ç¢¼å°‡åœ¨ 15 åˆ†é˜å¾Œåˆ°æœŸã€‚{lineBreak}{lineBreak}å¯„é€æ­¤é›»å­éƒµä»¶æ˜¯å› ç‚ºæ­£åœ¨å˜—è©¦å¾žæ–°çš„ç€è¦½å™¨æˆ–è£ç½®ä»¥æ‚¨çš„å¸³æˆ¶ç™»å…¥ Robloxã€‚è‹¥æ‚¨ä¸¦æœªå˜—è©¦ç™»å…¥ Robloxï¼Œå¯èƒ½æœ‰å…¶ä»–äººè©¦åœ–å­˜å–æ‚¨çš„å¸³æˆ¶ã€‚è‹¥æ‚¨ä¸¦æœªç™¼å‡ºæ­¤è¦æ±‚ï¼Œæ¥µåŠ›å»ºè­°æ‚¨è®Šæ›´å¯†ç¢¼ã€‚{lineBreak}{lineBreak}è³‡æºï¼š{lineBreak}è®Šæ›´æ‚¨çš„å¯†ç¢¼ [{accountInfoPageLink}] {lineBreak}é€²ä¸€æ­¥çž­è§£ 2 æ­¥é©Ÿé©—è­‰ [{twoStepVerificationHelpArticleLink}]{lineBreak}ä¿æŒæ‚¨çš„å¸³æˆ¶å®‰å…¨ [{keepAccountSafeArticleLink}] {lineBreak}ä¸€èˆ¬ Roblox æ”¯æ´ [{supportPageLink}] {lineBreak}{lineBreak}æ„Ÿè¬æ‚¨{lineBreak}{lineBreak}Roblox åœ˜éšŠæ•¬ä¸Š";
	}

	/// <summary>
	/// Key: "Description.TwoStepVerificationLoginEmail.PlainText.GeolocationInfo1"
	/// GeoLocation info of IP trying to login
	/// English String: "Login request received from {username} located in {region}, {country} ({ipAddress}).{lineBreak}{lineBreak}"
	/// </summary>
	public override string DescriptionTwoStepVerificationLoginEmailPlainTextGeolocationInfo1(string username, string region, string country, string ipAddress, string lineBreak)
	{
		return $"æ”¶åˆ°ä½æ–¼{country}ã€{region}ï¼ˆ{ipAddress}ï¼‰ï¼Œä¾†è‡ª{username}çš„ç™»å…¥è«‹æ±‚ã€‚{lineBreak}{lineBreak}";
	}

	protected override string _GetTemplateForDescriptionTwoStepVerificationLoginEmailPlainTextGeolocationInfo1()
	{
		return "æ”¶åˆ°ä½æ–¼{country}ã€{region}ï¼ˆ{ipAddress}ï¼‰ï¼Œä¾†è‡ª{username}çš„ç™»å…¥è«‹æ±‚ã€‚{lineBreak}{lineBreak}";
	}

	/// <summary>
	/// Key: "Description.TwoStepVerificationLoginEmail.PlainText.GeolocationInfo2"
	/// Geolocation info of IP trying to login
	/// English String: "Login request received from {username} located in {country} ({ipAddress}).{lineBreak}{lineBreak}"
	/// </summary>
	public override string DescriptionTwoStepVerificationLoginEmailPlainTextGeolocationInfo2(string username, string country, string ipAddress, string lineBreak)
	{
		return $"æ”¶åˆ° {username} ä¾†è‡ª{country}çš„ç™»å…¥è«‹æ±‚ï¼ˆ{ipAddress}ï¼‰ã€‚{lineBreak}{lineBreak}";
	}

	protected override string _GetTemplateForDescriptionTwoStepVerificationLoginEmailPlainTextGeolocationInfo2()
	{
		return "æ”¶åˆ° {username} ä¾†è‡ª{country}çš„ç™»å…¥è«‹æ±‚ï¼ˆ{ipAddress}ï¼‰ã€‚{lineBreak}{lineBreak}";
	}

	/// <summary>
	/// Key: "Description.TwoStepVerificationLoginEmail.PlainText.GeolocationInfo3"
	/// Geolocation info of IP trying to login
	/// English String: "Login request received from {username} (From Roblox Internal).{lineBreak}{lineBreak}"
	/// </summary>
	public override string DescriptionTwoStepVerificationLoginEmailPlainTextGeolocationInfo3(string username, string lineBreak)
	{
		return $"æ”¶åˆ° {username} ä¾†è‡ª Roblox å…§éƒ¨çš„ç™»å…¥è«‹æ±‚ã€‚{lineBreak}{lineBreak}";
	}

	protected override string _GetTemplateForDescriptionTwoStepVerificationLoginEmailPlainTextGeolocationInfo3()
	{
		return "æ”¶åˆ° {username} ä¾†è‡ª Roblox å…§éƒ¨çš„ç™»å…¥è«‹æ±‚ã€‚{lineBreak}{lineBreak}";
	}

	/// <summary>
	/// Key: "Description.TwoStepVerificationLoginEmail.PlainText.GeolocationInfo4"
	/// Geolocation info of IP trying to login
	/// English String: "Login request received from {username} located in {country}.{lineBreak}{lineBreak}"
	/// </summary>
	public override string DescriptionTwoStepVerificationLoginEmailPlainTextGeolocationInfo4(string username, string country, string lineBreak)
	{
		return $"æ”¶åˆ° {username} ä¾†è‡ª{country}çš„ç™»å…¥è«‹æ±‚ã€‚{lineBreak}{lineBreak}";
	}

	protected override string _GetTemplateForDescriptionTwoStepVerificationLoginEmailPlainTextGeolocationInfo4()
	{
		return "æ”¶åˆ° {username} ä¾†è‡ª{country}çš„ç™»å…¥è«‹æ±‚ã€‚{lineBreak}{lineBreak}";
	}

	/// <summary>
	/// Key: "Description.TwoStepVerificationLoginEmail.PlainText.GeolocationInfo5"
	/// Geolocation info of IP trying to login
	/// English String: "Login request received from {username} located in {region}, {country}.{lineBreak}{lineBreak}"
	/// </summary>
	public override string DescriptionTwoStepVerificationLoginEmailPlainTextGeolocationInfo5(string username, string region, string country, string lineBreak)
	{
		return $"æ”¶åˆ° {username} ä¾†è‡ª{country}{region}çš„ç™»å…¥è«‹æ±‚ã€‚{lineBreak}{lineBreak}";
	}

	protected override string _GetTemplateForDescriptionTwoStepVerificationLoginEmailPlainTextGeolocationInfo5()
	{
		return "æ”¶åˆ° {username} ä¾†è‡ª{country}{region}çš„ç™»å…¥è«‹æ±‚ã€‚{lineBreak}{lineBreak}";
	}

	/// <summary>
	/// Key: "Description.TwoStepVerificationLoginEmail.PlainText.GeolocationInfo6"
	/// Geolocation info of IP trying to login
	/// English String: "Login request received from {username} located in {city}, {region}, {country}.{lineBreak}{lineBreak}"
	/// </summary>
	public override string DescriptionTwoStepVerificationLoginEmailPlainTextGeolocationInfo6(string username, string city, string region, string country, string lineBreak)
	{
		return $"æ”¶åˆ° {username} ä¾†è‡ª{country}{region}{city}çš„ç™»å…¥è«‹æ±‚ã€‚{lineBreak}{lineBreak}";
	}

	protected override string _GetTemplateForDescriptionTwoStepVerificationLoginEmailPlainTextGeolocationInfo6()
	{
		return "æ”¶åˆ° {username} ä¾†è‡ª{country}{region}{city}çš„ç™»å…¥è«‹æ±‚ã€‚{lineBreak}{lineBreak}";
	}

	/// <summary>
	/// Key: "Description.TwoStepVerificationLoginEmail.Subject"
	/// Subject for 2SV login email
	/// English String: "Verification Code for Roblox Account: {accountName}"
	/// </summary>
	public override string DescriptionTwoStepVerificationLoginEmailSubject(string accountName)
	{
		return $"Roblox å¸³è™Ÿ {accountName} çš„é©—è­‰ç¢¼";
	}

	protected override string _GetTemplateForDescriptionTwoStepVerificationLoginEmailSubject()
	{
		return "Roblox å¸³è™Ÿ {accountName} çš„é©—è­‰ç¢¼";
	}

	protected override string _GetTemplateForLabelCode()
	{
		return "é©—è­‰ç¢¼";
	}

	/// <summary>
	/// Key: "Label.CodeInputPlaceholderText"
	/// example: Enter 4-digit code
	/// English String: "Enter {codeLength}-digit Code"
	/// </summary>
	public override string LabelCodeInputPlaceholderText(string codeLength)
	{
		return $"è¼¸å…¥ {codeLength} ä½æ•¸é©—è­‰ç¢¼";
	}

	protected override string _GetTemplateForLabelCodeInputPlaceholderText()
	{
		return "è¼¸å…¥ {codeLength} ä½æ•¸é©—è­‰ç¢¼";
	}

	protected override string _GetTemplateForLabelDidNotReceive()
	{
		return "æ²’æœ‰æ”¶åˆ°ä»£ç¢¼ï¼Ÿ";
	}

	protected override string _GetTemplateForLabelEnterCode()
	{
		return "è¼¸å…¥é©—è­‰ç¢¼ï¼ˆ6 ä½æ•¸ï¼‰";
	}

	protected override string _GetTemplateForLabelEnterEmailCode()
	{
		return "è«‹è¼¸å…¥å‚³é€åˆ°æ‚¨çš„é›»å­éƒµä»¶ä¿¡ç®±çš„é©—è­‰ç¢¼";
	}

	protected override string _GetTemplateForLabelEnterTextCode()
	{
		return "è«‹è¼¸å…¥å‚³é€åˆ°æ‚¨çš„æ‰‹æ©Ÿçš„é©—è­‰ç¢¼";
	}

	protected override string _GetTemplateForLabelEnterTwoStepVerificationCode()
	{
		return "è«‹è¼¸å…¥é›™æ­¥é©Ÿé©—è­‰ç¢¼ã€‚";
	}

	protected override string _GetTemplateForLabelFacebookPasswordWarning()
	{
		return "è‹¥æ‚¨ä»¥ Facebook ç™»å…¥ï¼Œè«‹è¨­å®šå¯†ç¢¼ã€‚";
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
		return $"éœ€è¦å”åŠ©ï¼Ÿè«‹è¯çµ¡{supportLink}";
	}

	protected override string _GetTemplateForLabelNeedHelpContactSupport()
	{
		return "éœ€è¦å”åŠ©ï¼Ÿè«‹è¯çµ¡{supportLink}";
	}

	protected override string _GetTemplateForLabelNewCode()
	{
		return "æ–°é©—è­‰ç¢¼";
	}

	protected override string _GetTemplateForLabelRobloxSupport()
	{
		return "Roblox å”åŠ©";
	}

	protected override string _GetTemplateForLabelTrustThisDevice()
	{
		return "ä¿¡ä»»æ­¤è£ç½® 30 å¤©";
	}

	protected override string _GetTemplateForLabelTwoStepVerification()
	{
		return "é›™æ­¥é©Ÿé©—è­‰";
	}

	protected override string _GetTemplateForResponseCodeSent()
	{
		return "é©—è­‰ç¢¼å·²å‚³é€";
	}

	protected override string _GetTemplateForResponseFeatureNotAvailable()
	{
		return "ç„¡æ³•ä½¿ç”¨æ­¤åŠŸèƒ½ï¼Œè«‹è¯çµ¡å®¢æœäººå“¡ã€‚";
	}

	protected override string _GetTemplateForResponseInvalidCode()
	{
		return "é©—è­‰ç¢¼ç„¡æ•ˆã€‚";
	}

	protected override string _GetTemplateForResponseSystemErrorReturnToLogin()
	{
		return "ç³»çµ±éŒ¯èª¤ï¼Œè«‹è¿”å›žç™»å…¥ç•«é¢ã€‚";
	}

	protected override string _GetTemplateForResponseTooManyAttempts()
	{
		return "å˜—è©¦æ¬¡æ•¸éŽå¤šï¼Œè«‹ç¨å¾Œå†è©¦ã€‚";
	}

	protected override string _GetTemplateForResponseTooManyCharacters()
	{
		return "å­—å…ƒéŽå¤š";
	}
}


}
