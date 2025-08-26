namespace Roblox.Platform.TranslationResources.Authentication {
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
	public override string ActionCancel => "ì·¨ì†Œ";

	/// <summary>
	/// Key: "Action.Resend"
	/// English String: "Resend Code"
	/// </summary>
	public override string ActionResend => "ì½”ë“œ ìž¬ì „ì†¡";

	/// <summary>
	/// Key: "Action.StartOver"
	/// link text to restart verification
	/// English String: "Start Over"
	/// </summary>
	public override string ActionStartOver => "ì‹œìž‘í•˜ê¸°";

	/// <summary>
	/// Key: "Action.Submit"
	/// submit button text
	/// English String: "Submit"
	/// </summary>
	public override string ActionSubmit => "ìž…ë ¥";

	/// <summary>
	/// Key: "Action.Verify"
	/// English String: "Verify"
	/// </summary>
	public override string ActionVerify => "í™•ì¸";

	/// <summary>
	/// Key: "Label.Code"
	/// verification code for 2 factor authentication
	/// English String: "Code"
	/// </summary>
	public override string LabelCode => "ì½”ë“œ";

	/// <summary>
	/// Key: "Label.DidNotReceive"
	/// English String: "Didn't receive the code?"
	/// </summary>
	public override string LabelDidNotReceive => "ì½”ë“œë¥¼ ë°›ì§€ ëª»í•˜ì…¨ë‚˜ìš”?";

	/// <summary>
	/// Key: "Label.EnterCode"
	/// English String: "Enter Code (6-digit)"
	/// </summary>
	public override string LabelEnterCode => "ì½”ë“œ ìž…ë ¥ (6ìžë¦¬)";

	/// <summary>
	/// Key: "Label.EnterEmailCode"
	/// English String: "Enter the code we just sent you via email"
	/// </summary>
	public override string LabelEnterEmailCode => "ë°©ê¸ˆ ì´ë©”ì¼ë¡œ ì „ì†¡ëœ ì½”ë“œë¥¼ ìž…ë ¥í•˜ì„¸ìš”.";

	/// <summary>
	/// Key: "Label.EnterTextCode"
	/// English String: "Enter the code we just sent you via text message"
	/// </summary>
	public override string LabelEnterTextCode => "ë°©ê¸ˆ ë¬¸ìž ë©”ì‹œì§€ë¡œ ì „ì†¡ëœ ì½”ë“œë¥¼ ìž…ë ¥í•˜ì„¸ìš”.";

	/// <summary>
	/// Key: "Label.EnterTwoStepVerificationCode"
	/// Enter your two step verification code.
	/// English String: "Enter your two step verification code."
	/// </summary>
	public override string LabelEnterTwoStepVerificationCode => "2ë‹¨ê³„ ì¸ì¦ ì½”ë“œë¥¼ ìž…ë ¥í•˜ì„¸ìš”.";

	/// <summary>
	/// Key: "Label.FacebookPasswordWarning"
	/// If you have been signing in with Facebook, you must set a password.
	/// English String: "If you have been signing in with Facebook, you must set a password."
	/// </summary>
	public override string LabelFacebookPasswordWarning => "Facebookìœ¼ë¡œ ë¡œê·¸ì¸í•œ ê²½ìš°, ë¹„ë°€ë²ˆí˜¸ë¥¼ ì„¤ì •í•´ì•¼ í•©ë‹ˆë‹¤.";

	/// <summary>
	/// Key: "Label.LearnMore"
	/// Learn More link text
	/// English String: "Learn More"
	/// </summary>
	public override string LabelLearnMore => "ë” ì•Œì•„ë³´ê¸°";

	/// <summary>
	/// Key: "Label.NewCode"
	/// verification code resent, label changes to new code
	/// English String: "New Code"
	/// </summary>
	public override string LabelNewCode => "ìƒˆ ì½”ë“œ";

	/// <summary>
	/// Key: "Label.RobloxSupport"
	/// English String: "Roblox Support"
	/// </summary>
	public override string LabelRobloxSupport => "Roblox ê³ ê°ì§€ì›";

	/// <summary>
	/// Key: "Label.TrustThisDevice"
	/// English String: "Trust this device for 30 days"
	/// </summary>
	public override string LabelTrustThisDevice => "30ì¼ ë™ì•ˆ ë³¸ ê¸°ê¸° ì‹ ë¢°";

	/// <summary>
	/// Key: "Label.TwoStepVerification"
	/// English String: "2-Step Verification"
	/// </summary>
	public override string LabelTwoStepVerification => "2ë‹¨ê³„ ì¸ì¦";

	/// <summary>
	/// Key: "Response.CodeSent"
	/// English String: "Code Sent"
	/// </summary>
	public override string ResponseCodeSent => "ì½”ë“œ ì „ì†¡ ì™„ë£Œ";

	/// <summary>
	/// Key: "Response.FeatureNotAvailable"
	/// English String: "Feature not available. Please contact support."
	/// </summary>
	public override string ResponseFeatureNotAvailable => "ì‚¬ìš©í•  ìˆ˜ ì—†ëŠ” ê¸°ëŠ¥.\u00a0ê³ ê°ì§€ì›ìœ¼ë¡œ ë¬¸ì˜í•˜ì„¸ìš”.";

	/// <summary>
	/// Key: "Response.InvalidCode"
	/// English String: "Invalid code."
	/// </summary>
	public override string ResponseInvalidCode => "ìœ íš¨í•˜ì§€ ì•Šì€ ì½”ë“œ";

	/// <summary>
	/// Key: "Response.SystemErrorReturnToLogin"
	/// English String: "System error. Please return to login screen."
	/// </summary>
	public override string ResponseSystemErrorReturnToLogin => "ì‹œìŠ¤í…œ ì˜¤ë¥˜.\u00a0ë¡œê·¸ì¸ í™”ë©´ìœ¼ë¡œ ëŒì•„ê°€ì„¸ìš”.";

	/// <summary>
	/// Key: "Response.TooManyAttempts"
	/// English String: "Too many attempts. Please try again later."
	/// </summary>
	public override string ResponseTooManyAttempts => "ì‹œë„ ê°€ëŠ¥ íšŸìˆ˜ë¥¼ ì´ˆê³¼í–ˆìŠµë‹ˆë‹¤.\u00a0ë‚˜ì¤‘ì— ë‹¤ì‹œ ì‹œë„í•˜ì„¸ìš”.";

	/// <summary>
	/// Key: "Response.TooManyCharacters"
	/// error message
	/// English String: "Too many characters"
	/// </summary>
	public override string ResponseTooManyCharacters => "ìž…ë ¥ ê°€ëŠ¥ ê¸€ìž ìˆ˜ë¥¼ ì´ˆê³¼í–ˆìŠµë‹ˆë‹¤";

	public TwoStepVerificationResources_ko_kr(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionCancel()
	{
		return "ì·¨ì†Œ";
	}

	protected override string _GetTemplateForActionResend()
	{
		return "ì½”ë“œ ìž¬ì „ì†¡";
	}

	protected override string _GetTemplateForActionStartOver()
	{
		return "ì‹œìž‘í•˜ê¸°";
	}

	protected override string _GetTemplateForActionSubmit()
	{
		return "ìž…ë ¥";
	}

	protected override string _GetTemplateForActionVerify()
	{
		return "í™•ì¸";
	}

	/// <summary>
	/// Key: "Description.TwoStepVerificationActivationEmail.Body.Over13"
	/// Body for 2SV activation email for over 13 users
	/// English String: "Hi {accountName},{lineBreak}{lineBreak}You have activated 2-Step Verification for your Roblox account. Next time you log in from a new device, you will need to enter a 6-digit security code that Roblox sends to you via email.{lineBreak}{lineBreak}Roblox"
	/// </summary>
	public override string DescriptionTwoStepVerificationActivationEmailBodyOver13(string accountName, string lineBreak)
	{
		return $"{accountName} ë‹˜ ì•ˆë…•í•˜ì„¸ìš”,{lineBreak}{lineBreak}ê·€í•˜ì˜ Roblox ê³„ì • ì— ëŒ€í•œ 2ë‹¨ê³„ ì¸ì¦ì´ í™œì„±í™”ë˜ì—ˆìŠµë‹ˆë‹¤. ë‹¤ìŒ ë²ˆì— ìƒˆ ê¸°ê¸°ì—ì„œ ë¡œê·¸ì¸í•  ë•Œ Robloxì—ì„œ ì´ë©”ì¼ì„ í†µí•´ ë³´ë‚´ëŠ” 6ìžë¦¬ ë³´ì•ˆ ì½”ë“œë¥¼ ìž…ë ¥í•´ì•¼ í•©ë‹ˆë‹¤.{lineBreak}{lineBreak}Roblox";
	}

	protected override string _GetTemplateForDescriptionTwoStepVerificationActivationEmailBodyOver13()
	{
		return "{accountName} ë‹˜ ì•ˆë…•í•˜ì„¸ìš”,{lineBreak}{lineBreak}ê·€í•˜ì˜ Roblox ê³„ì • ì— ëŒ€í•œ 2ë‹¨ê³„ ì¸ì¦ì´ í™œì„±í™”ë˜ì—ˆìŠµë‹ˆë‹¤. ë‹¤ìŒ ë²ˆì— ìƒˆ ê¸°ê¸°ì—ì„œ ë¡œê·¸ì¸í•  ë•Œ Robloxì—ì„œ ì´ë©”ì¼ì„ í†µí•´ ë³´ë‚´ëŠ” 6ìžë¦¬ ë³´ì•ˆ ì½”ë“œë¥¼ ìž…ë ¥í•´ì•¼ í•©ë‹ˆë‹¤.{lineBreak}{lineBreak}Roblox";
	}

	/// <summary>
	/// Key: "Description.TwoStepVerificationActivationEmail.Body.Under13"
	/// Body for 2SV activation email for under 13 users
	/// English String: "Hi,{lineBreak}{lineBreak}2-Step Verification has been activated for your child's Roblox account, {accountName}. Next time they log in from a new device, they will need to enter a 6-digit security code that Roblox sends to you via email.{lineBreak}{lineBreak}Roblox"
	/// </summary>
	public override string DescriptionTwoStepVerificationActivationEmailBodyUnder13(string lineBreak, string accountName)
	{
		return $"ì•ˆë…•í•˜ì„¸ìš”,{lineBreak}{lineBreak}ìžë…€ì˜ Roblox ê³„ì • {accountName}ì— ëŒ€í•œ 2ë‹¨ê³„ ì¸ì¦ì´ í™œì„±í™”ë˜ì—ˆìŠµë‹ˆë‹¤. ë‹¤ìŒ ë²ˆì— ìƒˆ ê¸°ê¸°ì—ì„œ ë¡œê·¸ì¸í•  ë•Œ Robloxì—ì„œ ì´ë©”ì¼ì„ í†µí•´ ë³´ë‚´ëŠ” 6ìžë¦¬ ë³´ì•ˆ ì½”ë“œë¥¼ ìž…ë ¥í•´ì•¼ í•©ë‹ˆë‹¤.{lineBreak}{lineBreak}Roblox";
	}

	protected override string _GetTemplateForDescriptionTwoStepVerificationActivationEmailBodyUnder13()
	{
		return "ì•ˆë…•í•˜ì„¸ìš”,{lineBreak}{lineBreak}ìžë…€ì˜ Roblox ê³„ì • {accountName}ì— ëŒ€í•œ 2ë‹¨ê³„ ì¸ì¦ì´ í™œì„±í™”ë˜ì—ˆìŠµë‹ˆë‹¤. ë‹¤ìŒ ë²ˆì— ìƒˆ ê¸°ê¸°ì—ì„œ ë¡œê·¸ì¸í•  ë•Œ Robloxì—ì„œ ì´ë©”ì¼ì„ í†µí•´ ë³´ë‚´ëŠ” 6ìžë¦¬ ë³´ì•ˆ ì½”ë“œë¥¼ ìž…ë ¥í•´ì•¼ í•©ë‹ˆë‹¤.{lineBreak}{lineBreak}Roblox";
	}

	/// <summary>
	/// Key: "Description.TwoStepVerificationActivationEmail.Subject"
	/// Subject for 2SV activation email
	/// English String: "2-Step Verification Activated for Roblox Account: {accountName}"
	/// </summary>
	public override string DescriptionTwoStepVerificationActivationEmailSubject(string accountName)
	{
		return $"Roblox ê³„ì • {accountName}ì˜ 2ë‹¨ê³„ ì¸ì¦ í™œì„±í™” ì™„ë£Œ ";
	}

	protected override string _GetTemplateForDescriptionTwoStepVerificationActivationEmailSubject()
	{
		return "Roblox ê³„ì • {accountName}ì˜ 2ë‹¨ê³„ ì¸ì¦ í™œì„±í™” ì™„ë£Œ ";
	}

	/// <summary>
	/// Key: "Description.TwoStepVerificationDeactivationEmail.Body.Over13"
	/// Body for 2SV deactivation email for over 13 users
	/// English String: "Hi {accountName},{lineBreak}{lineBreak}You have deactivated 2-Step Verification for your Roblox account. A security code will no longer be required when you log into your account.{lineBreak}{lineBreak}Roblox"
	/// </summary>
	public override string DescriptionTwoStepVerificationDeactivationEmailBodyOver13(string accountName, string lineBreak)
	{
		return $"{accountName} ë‹˜ ì•ˆë…•í•˜ì„¸ìš”,{lineBreak}{lineBreak}íšŒì›ë‹˜ì˜ Roblox ê³„ì •ì— ëŒ€í•œ 2ë‹¨ê³„ ì¸ì¦ì„ ë¹„í™œì„±í™”í–ˆìŠµë‹ˆë‹¤. ë¡œê·¸ì¸ ì‹œ ë³´ì•ˆ ì½”ë“œê°€ ë” ì´ìƒ í•„ìš”í•˜ì§€ ì•ŠìŠµë‹ˆë‹¤.{lineBreak}{lineBreak}Roblox";
	}

	protected override string _GetTemplateForDescriptionTwoStepVerificationDeactivationEmailBodyOver13()
	{
		return "{accountName} ë‹˜ ì•ˆë…•í•˜ì„¸ìš”,{lineBreak}{lineBreak}íšŒì›ë‹˜ì˜ Roblox ê³„ì •ì— ëŒ€í•œ 2ë‹¨ê³„ ì¸ì¦ì„ ë¹„í™œì„±í™”í–ˆìŠµë‹ˆë‹¤. ë¡œê·¸ì¸ ì‹œ ë³´ì•ˆ ì½”ë“œê°€ ë” ì´ìƒ í•„ìš”í•˜ì§€ ì•ŠìŠµë‹ˆë‹¤.{lineBreak}{lineBreak}Roblox";
	}

	/// <summary>
	/// Key: "Description.TwoStepVerificationDeactivationEmail.Body.Under13"
	/// Body for 2SV deactivation email for under 13 users
	/// English String: "Hi,{lineBreak}{lineBreak}2-Step Verification has been deactivated for your child's Roblox account, {accountName}. A security code will no longer be required when they log into the account.{lineBreak}{lineBreak}Roblox"
	/// </summary>
	public override string DescriptionTwoStepVerificationDeactivationEmailBodyUnder13(string lineBreak, string accountName)
	{
		return $"ì•ˆë…•í•˜ì„¸ìš”,{lineBreak}{lineBreak}ìžë…€ì˜ Roblox ê³„ì • {accountName}ì— ëŒ€í•œ 2ë‹¨ê³„ ì¸ì¦ì„ ë¹„í™œì„±í™”í–ˆìŠµë‹ˆë‹¤. ë¡œê·¸ì¸ ì‹œ ë³´ì•ˆ ì½”ë“œê°€ ë” ì´ìƒ í•„ìš”í•˜ì§€ ì•ŠìŠµë‹ˆë‹¤.{lineBreak}{lineBreak}Roblox";
	}

	protected override string _GetTemplateForDescriptionTwoStepVerificationDeactivationEmailBodyUnder13()
	{
		return "ì•ˆë…•í•˜ì„¸ìš”,{lineBreak}{lineBreak}ìžë…€ì˜ Roblox ê³„ì • {accountName}ì— ëŒ€í•œ 2ë‹¨ê³„ ì¸ì¦ì„ ë¹„í™œì„±í™”í–ˆìŠµë‹ˆë‹¤. ë¡œê·¸ì¸ ì‹œ ë³´ì•ˆ ì½”ë“œê°€ ë” ì´ìƒ í•„ìš”í•˜ì§€ ì•ŠìŠµë‹ˆë‹¤.{lineBreak}{lineBreak}Roblox";
	}

	/// <summary>
	/// Key: "Description.TwoStepVerificationDeactivationEmail.Subject	"
	/// Subject for 2SV deactivation email
	/// English String: "2-Step Verification Deactivated for Roblox Account: {accountName}"
	/// </summary>
	public override string DescriptionTwoStepVerificationDeactivationEmailSubject(string accountName)
	{
		return $"Roblox ê³„ì • {accountName}ì˜ 2ë‹¨ê³„ ì¸ì¦ ë¹„í™œì„±í™” ì™„ë£Œ: ";
	}

	protected override string _GetTemplateForDescriptionTwoStepVerificationDeactivationEmailSubject()
	{
		return "Roblox ê³„ì • {accountName}ì˜ 2ë‹¨ê³„ ì¸ì¦ ë¹„í™œì„±í™” ì™„ë£Œ: ";
	}

	/// <summary>
	/// Key: "Description.TwoStepVerificationLoginEmail.Html.GeolocationInfo1"
	/// Geolocation information about IP trying to login
	/// English String: "{spanStartTagWithBold}Login request received from {username} located in {region}, {country} ({ipAddress}).{spanEndTag}{lineBreak}{lineBreak}"
	/// </summary>
	public override string DescriptionTwoStepVerificationLoginEmailHtmlGeolocationInfo1(string spanStartTagWithBold, string username, string region, string country, string ipAddress, string spanEndTag, string lineBreak)
	{
		return $"{spanStartTagWithBold}{username} ë‹˜ì´ {region}, {country}({ipAddress})ì—ì„œ ë¡œê·¸ì¸ì„ ìš”ì²­í–ˆì–´ìš”.{spanEndTag}{lineBreak}{lineBreak}";
	}

	protected override string _GetTemplateForDescriptionTwoStepVerificationLoginEmailHtmlGeolocationInfo1()
	{
		return "{spanStartTagWithBold}{username} ë‹˜ì´ {region}, {country}({ipAddress})ì—ì„œ ë¡œê·¸ì¸ì„ ìš”ì²­í–ˆì–´ìš”.{spanEndTag}{lineBreak}{lineBreak}";
	}

	/// <summary>
	/// Key: "Description.TwoStepVerificationLoginEmail.Html.GeolocationInfo2"
	/// Geolocation info about IP trying to login
	/// English String: "{spanStartTagWithBold}Login request received from {username} located in {country} ({ipAddress}).{spanEndTag}{lineBreak}{lineBreak}\t"
	/// </summary>
	public override string DescriptionTwoStepVerificationLoginEmailHtmlGeolocationInfo2(string spanStartTagWithBold, string username, string country, string ipAddress, string spanEndTag, string lineBreak)
	{
		return $"{spanStartTagWithBold}{username} ë‹˜ì´ {country}({ipAddress})ì—ì„œ ë¡œê·¸ì¸ì„ ìš”ì²­í–ˆì–´ìš”.{spanEndTag}{lineBreak}{lineBreak}\t";
	}

	protected override string _GetTemplateForDescriptionTwoStepVerificationLoginEmailHtmlGeolocationInfo2()
	{
		return "{spanStartTagWithBold}{username} ë‹˜ì´ {country}({ipAddress})ì—ì„œ ë¡œê·¸ì¸ì„ ìš”ì²­í–ˆì–´ìš”.{spanEndTag}{lineBreak}{lineBreak}\t";
	}

	/// <summary>
	/// Key: "Description.TwoStepVerificationLoginEmail.Html.GeolocationInfo3"
	/// Geolocation info about IP trying to log in
	/// English String: "{spanStartTagWithBold}Login request received from {username} (From Roblox Internal).{spanEndTag}{lineBreak}{lineBreak}\t"
	/// </summary>
	public override string DescriptionTwoStepVerificationLoginEmailHtmlGeolocationInfo3(string spanStartTagWithBold, string username, string spanEndTag, string lineBreak)
	{
		return $"{spanStartTagWithBold}(Roblox ë‚´ë¶€ì˜) {username} ë‹˜ì´ ë¡œê·¸ì¸ì„ ìš”ì²­í–ˆì–´ìš”.{spanEndTag}{lineBreak}{lineBreak}\t";
	}

	protected override string _GetTemplateForDescriptionTwoStepVerificationLoginEmailHtmlGeolocationInfo3()
	{
		return "{spanStartTagWithBold}(Roblox ë‚´ë¶€ì˜) {username} ë‹˜ì´ ë¡œê·¸ì¸ì„ ìš”ì²­í–ˆì–´ìš”.{spanEndTag}{lineBreak}{lineBreak}\t";
	}

	/// <summary>
	/// Key: "Description.TwoStepVerificationLoginEmail.Html.GeolocationInfo4"
	/// Geolocation info of IP trying to login
	/// English String: "{spanStartTagWithBold}Login request received from {username} located in {country}.{spanEndTag}{lineBreak}{lineBreak}"
	/// </summary>
	public override string DescriptionTwoStepVerificationLoginEmailHtmlGeolocationInfo4(string spanStartTagWithBold, string username, string country, string spanEndTag, string lineBreak)
	{
		return $"{spanStartTagWithBold}{username} ë‹˜ì´ {country}ì—ì„œ ë¡œê·¸ì¸ì„ ìš”ì²­í–ˆì–´ìš”.{spanEndTag}{lineBreak}{lineBreak}";
	}

	protected override string _GetTemplateForDescriptionTwoStepVerificationLoginEmailHtmlGeolocationInfo4()
	{
		return "{spanStartTagWithBold}{username} ë‹˜ì´ {country}ì—ì„œ ë¡œê·¸ì¸ì„ ìš”ì²­í–ˆì–´ìš”.{spanEndTag}{lineBreak}{lineBreak}";
	}

	/// <summary>
	/// Key: "Description.TwoStepVerificationLoginEmail.Html.GeolocationInfo5"
	/// Geolocation info of IP trying to login
	/// English String: "{spanStartTagWithBold}Login request received from {username} located in {region}, {country}.{spanEndTag}{lineBreak}{lineBreak}"
	/// </summary>
	public override string DescriptionTwoStepVerificationLoginEmailHtmlGeolocationInfo5(string spanStartTagWithBold, string username, string region, string country, string spanEndTag, string lineBreak)
	{
		return $"{spanStartTagWithBold}{username} ë‹˜ì´ {country} {region}ì—ì„œ ë¡œê·¸ì¸ì„ ìš”ì²­í–ˆì–´ìš”.{spanEndTag}{lineBreak}{lineBreak}";
	}

	protected override string _GetTemplateForDescriptionTwoStepVerificationLoginEmailHtmlGeolocationInfo5()
	{
		return "{spanStartTagWithBold}{username} ë‹˜ì´ {country} {region}ì—ì„œ ë¡œê·¸ì¸ì„ ìš”ì²­í–ˆì–´ìš”.{spanEndTag}{lineBreak}{lineBreak}";
	}

	/// <summary>
	/// Key: "Description.TwoStepVerificationLoginEmail.Html.GeolocationInfo6"
	/// Geolocation info of IP trying to login
	/// English String: "{spanStartTagWithBold}Login request received from {username} located in {city}, {region}, {country}.{spanEndTag}{lineBreak}{lineBreak}"
	/// </summary>
	public override string DescriptionTwoStepVerificationLoginEmailHtmlGeolocationInfo6(string spanStartTagWithBold, string username, string city, string region, string country, string spanEndTag, string lineBreak)
	{
		return $"{spanStartTagWithBold}{username} ë‹˜ì´ {country} {region} {city}ì—ì„œ ë¡œê·¸ì¸ì„ ìš”ì²­í–ˆì–´ìš”.{spanEndTag}{lineBreak}{lineBreak}";
	}

	protected override string _GetTemplateForDescriptionTwoStepVerificationLoginEmailHtmlGeolocationInfo6()
	{
		return "{spanStartTagWithBold}{username} ë‹˜ì´ {country} {region} {city}ì—ì„œ ë¡œê·¸ì¸ì„ ìš”ì²­í–ˆì–´ìš”.{spanEndTag}{lineBreak}{lineBreak}";
	}

	/// <summary>
	/// Key: "Description.TwoStepVerificationLoginEmail.HtmlBody"
	/// Html body for 2SV login email
	/// English String: "{geoLocationInformation}{spanStartTagWithBold}Login code for {accountName}: {lineBreak}{lineBreak}{code} {spanEndTag}{lineBreak}{lineBreak}Enter this code into the 2-Step Verification screen to finish logging in. This code will expire in 15 minutes.{lineBreak}{lineBreak}This email was sent because your account tried to login to Roblox from a new browser or device. If you haven't tried logging into Roblox, someone else may be trying to access your account. You are strongly advised to change your password if you did not generate this request.{lineBreak}{lineBreak}Resources:{lineBreak}{aTagStartWithHref}{ChangePasswordLink}{hrefEnd}Change Your Password{aTagEnd} {lineBreak}{aTagStartWithHref}{TwoStepVerificationArticleLink}{hrefEnd}Learn More About 2-Step Verification{aTagEnd} {lineBreak}{aTagStartWithHref}{AccountSafetyArticleLink}{hrefEnd}Keeping Your Account Safe{aTagEnd} {lineBreak}{aTagStartWithHref}{SupportLink}{hrefEnd}General Roblox Support{aTagEnd} {lineBreak}{lineBreak}Thank you,{lineBreak}{lineBreak}The Roblox Team"
	/// </summary>
	public override string DescriptionTwoStepVerificationLoginEmailHtmlBody(string geoLocationInformation, string spanStartTagWithBold, string accountName, string lineBreak, string code, string spanEndTag, string aTagStartWithHref, string ChangePasswordLink, string hrefEnd, string aTagEnd, string TwoStepVerificationArticleLink, string AccountSafetyArticleLink, string SupportLink)
	{
		return $"{geoLocationInformation}{spanStartTagWithBold}{accountName}ì˜ ë¡œê·¸ì¸ ì½”ë“œ: {lineBreak}{lineBreak}{code} {spanEndTag}{lineBreak}{lineBreak}ë¡œê·¸ì¸ì„ ì™„ë£Œí•˜ë ¤ë©´ ë³¸ ì½”ë“œë¥¼ 2ë‹¨ê³„ ì¸ì¦ í™”ë©´ì— ìž…ë ¥í•˜ì„¸ìš”. ì½”ë“œëŠ” 15ë¶„ í›„ ë§Œë£Œë©ë‹ˆë‹¤.{lineBreak}{lineBreak}ë³¸ ì´ë©”ì¼ì€ ìƒˆë¡œìš´ ë¸Œë¼ìš°ì € ë˜ëŠ” ê¸°ê¸°ì—ì„œ íšŒì›ë‹˜ì˜ ê³„ì •ìœ¼ë¡œ Robloxì— ë¡œê·¸ì¸í•˜ë ¤ í–ˆê¸° ë•Œë¬¸ì— ë³´ë‚´ë“œë¦½ë‹ˆë‹¤. Robloxì— ë¡œê·¸ì¸í•˜ë ¤ í•œ ì ì´ ì—†ìœ¼ì…¨ë‹¤ë©´, ë‹¤ë¥¸ ëˆ„êµ°ê°€ê°€ íšŒì›ë‹˜ì˜ ê³„ì •ì— ì ‘ì†í•˜ë ¤ í–ˆì„ ìˆ˜ë„ ìžˆìŠµë‹ˆë‹¤. ë¡œê·¸ì¸ ìš”ì²­ì„ í•œ ì ì´ ì—†ëŠ” ê²½ìš° ë¹„ë°€ë²ˆí˜¸ë¥¼ ë°”ê¾¸ê¸¸ ê°•ë ¥í•˜ê²Œ ê¶Œê³ ë“œë¦½ë‹ˆë‹¤.{lineBreak}{lineBreak}ë¦¬ì†ŒìŠ¤:{lineBreak}{aTagStartWithHref}{ChangePasswordLink}{hrefEnd}ë¹„ë°€ë²ˆí˜¸ ë³€ê²½{aTagEnd} {lineBreak}{aTagStartWithHref}{TwoStepVerificationArticleLink}{hrefEnd}2ë‹¨ê³„ ì¸ì¦ ë” ì•Œì•„ë³´ê¸°{aTagEnd} {lineBreak}{aTagStartWithHref}{AccountSafetyArticleLink}{hrefEnd}ê³„ì • ë³´í˜¸ ë°©ë²•{aTagEnd} {lineBreak}{aTagStartWithHref}{SupportLink}{hrefEnd}ì¼ë°˜ì ì¸ Roblox ê³ ê°ì§€ì›{aTagEnd} {lineBreak}{lineBreak}ê°ì‚¬í•©ë‹ˆë‹¤.{lineBreak}{lineBreak}Roblox íŒ€";
	}

	protected override string _GetTemplateForDescriptionTwoStepVerificationLoginEmailHtmlBody()
	{
		return "{geoLocationInformation}{spanStartTagWithBold}{accountName}ì˜ ë¡œê·¸ì¸ ì½”ë“œ: {lineBreak}{lineBreak}{code} {spanEndTag}{lineBreak}{lineBreak}ë¡œê·¸ì¸ì„ ì™„ë£Œí•˜ë ¤ë©´ ë³¸ ì½”ë“œë¥¼ 2ë‹¨ê³„ ì¸ì¦ í™”ë©´ì— ìž…ë ¥í•˜ì„¸ìš”. ì½”ë“œëŠ” 15ë¶„ í›„ ë§Œë£Œë©ë‹ˆë‹¤.{lineBreak}{lineBreak}ë³¸ ì´ë©”ì¼ì€ ìƒˆë¡œìš´ ë¸Œë¼ìš°ì € ë˜ëŠ” ê¸°ê¸°ì—ì„œ íšŒì›ë‹˜ì˜ ê³„ì •ìœ¼ë¡œ Robloxì— ë¡œê·¸ì¸í•˜ë ¤ í–ˆê¸° ë•Œë¬¸ì— ë³´ë‚´ë“œë¦½ë‹ˆë‹¤. Robloxì— ë¡œê·¸ì¸í•˜ë ¤ í•œ ì ì´ ì—†ìœ¼ì…¨ë‹¤ë©´, ë‹¤ë¥¸ ëˆ„êµ°ê°€ê°€ íšŒì›ë‹˜ì˜ ê³„ì •ì— ì ‘ì†í•˜ë ¤ í–ˆì„ ìˆ˜ë„ ìžˆìŠµë‹ˆë‹¤. ë¡œê·¸ì¸ ìš”ì²­ì„ í•œ ì ì´ ì—†ëŠ” ê²½ìš° ë¹„ë°€ë²ˆí˜¸ë¥¼ ë°”ê¾¸ê¸¸ ê°•ë ¥í•˜ê²Œ ê¶Œê³ ë“œë¦½ë‹ˆë‹¤.{lineBreak}{lineBreak}ë¦¬ì†ŒìŠ¤:{lineBreak}{aTagStartWithHref}{ChangePasswordLink}{hrefEnd}ë¹„ë°€ë²ˆí˜¸ ë³€ê²½{aTagEnd} {lineBreak}{aTagStartWithHref}{TwoStepVerificationArticleLink}{hrefEnd}2ë‹¨ê³„ ì¸ì¦ ë” ì•Œì•„ë³´ê¸°{aTagEnd} {lineBreak}{aTagStartWithHref}{AccountSafetyArticleLink}{hrefEnd}ê³„ì • ë³´í˜¸ ë°©ë²•{aTagEnd} {lineBreak}{aTagStartWithHref}{SupportLink}{hrefEnd}ì¼ë°˜ì ì¸ Roblox ê³ ê°ì§€ì›{aTagEnd} {lineBreak}{lineBreak}ê°ì‚¬í•©ë‹ˆë‹¤.{lineBreak}{lineBreak}Roblox íŒ€";
	}

	/// <summary>
	/// Key: "Description.TwoStepVerificationLoginEmail.PlainBody"
	/// Plain body for 2SV login email
	/// English String: "{geoLocationInformation}Login code for {accountName}: {lineBreak}{lineBreak} {code} {lineBreak}{lineBreak}Enter this code into the 2-Step Verification screen to finish logging in. This code will expire in 15 minutes. {lineBreak}{lineBreak}This email was sent because your account tried to login to Roblox from a new browser or device. If you haven't tried logging into Roblox, someone else may be trying to access your account. You are strongly advised to change your password if you did not generate this request. {lineBreak}{lineBreak}Resources: {lineBreak}Change Your Password [{accountInfoPageLink}] {lineBreak}Learn More About 2-Step Verification [{twoStepVerificationHelpArticleLink}]{lineBreak}Keeping Your Account Safe [{keepAccountSafeArticleLink}] {lineBreak}General Roblox Support [{supportPageLink}] {lineBreak}{lineBreak}Thank you, {lineBreak}{lineBreak}The Roblox Team"
	/// </summary>
	public override string DescriptionTwoStepVerificationLoginEmailPlainBody(string geoLocationInformation, string accountName, string lineBreak, string code, string accountInfoPageLink, string twoStepVerificationHelpArticleLink, string keepAccountSafeArticleLink, string supportPageLink)
	{
		return $"{geoLocationInformation}{accountName}ì˜ ë¡œê·¸ì¸ ì½”ë“œ: {lineBreak}{lineBreak} {code} {lineBreak}{lineBreak}ë¡œê·¸ì¸ì„ ì™„ë£Œí•˜ë ¤ë©´ ë³¸ ì½”ë“œë¥¼ 2ë‹¨ê³„ ì¸ì¦ í™”ë©´ì— ìž…ë ¥í•˜ì„¸ìš”. ì½”ë“œëŠ” 15ë¶„ í›„ ë§Œë£Œë©ë‹ˆë‹¤. {lineBreak}{lineBreak}ë³¸ ì´ë©”ì¼ì€ ìƒˆë¡œìš´ ë¸Œë¼ìš°ì € ë˜ëŠ” ê¸°ê¸°ì—ì„œ íšŒì›ë‹˜ì˜ ê³„ì •ìœ¼ë¡œ Robloxì— ë¡œê·¸ì¸í•˜ë ¤ í–ˆê¸° ë•Œë¬¸ì— ë³´ë‚´ë“œë¦½ë‹ˆë‹¤. Robloxì— ë¡œê·¸ì¸í•˜ë ¤ í•œ ì ì´ ì—†ìœ¼ì…¨ë‹¤ë©´, ë‹¤ë¥¸ ëˆ„êµ°ê°€ê°€ íšŒì›ë‹˜ì˜ ê³„ì •ì— ì ‘ì†í•˜ë ¤ í–ˆì„ ìˆ˜ë„ ìžˆìŠµë‹ˆë‹¤. ë¡œê·¸ì¸ ìš”ì²­ì„ í•œ ì ì´ ì—†ëŠ” ê²½ìš° ë¹„ë°€ë²ˆí˜¸ë¥¼ ë°”ê¾¸ê¸¸ ê°•ë ¥í•˜ê²Œ ê¶Œê³ ë“œë¦½ë‹ˆë‹¤. {lineBreak}{lineBreak}ë¦¬ì†ŒìŠ¤: {lineBreak}ë¹„ë°€ë²ˆí˜¸ ë³€ê²½ [{accountInfoPageLink}] {lineBreak}2ë‹¨ê³„ ì¸ì¦ ë” ì•Œì•„ë³´ê¸° [{twoStepVerificationHelpArticleLink}]{lineBreak}ê³„ì • ë³´í˜¸ ë°©ë²• [{keepAccountSafeArticleLink}] {lineBreak}ì¼ë°˜ì ì¸ Roblox ê³ ê°ì§€ì› [{supportPageLink}] {lineBreak}{lineBreak}ê°ì‚¬í•©ë‹ˆë‹¤. {lineBreak}{lineBreak}Roblox íŒ€";
	}

	protected override string _GetTemplateForDescriptionTwoStepVerificationLoginEmailPlainBody()
	{
		return "{geoLocationInformation}{accountName}ì˜ ë¡œê·¸ì¸ ì½”ë“œ: {lineBreak}{lineBreak} {code} {lineBreak}{lineBreak}ë¡œê·¸ì¸ì„ ì™„ë£Œí•˜ë ¤ë©´ ë³¸ ì½”ë“œë¥¼ 2ë‹¨ê³„ ì¸ì¦ í™”ë©´ì— ìž…ë ¥í•˜ì„¸ìš”. ì½”ë“œëŠ” 15ë¶„ í›„ ë§Œë£Œë©ë‹ˆë‹¤. {lineBreak}{lineBreak}ë³¸ ì´ë©”ì¼ì€ ìƒˆë¡œìš´ ë¸Œë¼ìš°ì € ë˜ëŠ” ê¸°ê¸°ì—ì„œ íšŒì›ë‹˜ì˜ ê³„ì •ìœ¼ë¡œ Robloxì— ë¡œê·¸ì¸í•˜ë ¤ í–ˆê¸° ë•Œë¬¸ì— ë³´ë‚´ë“œë¦½ë‹ˆë‹¤. Robloxì— ë¡œê·¸ì¸í•˜ë ¤ í•œ ì ì´ ì—†ìœ¼ì…¨ë‹¤ë©´, ë‹¤ë¥¸ ëˆ„êµ°ê°€ê°€ íšŒì›ë‹˜ì˜ ê³„ì •ì— ì ‘ì†í•˜ë ¤ í–ˆì„ ìˆ˜ë„ ìžˆìŠµë‹ˆë‹¤. ë¡œê·¸ì¸ ìš”ì²­ì„ í•œ ì ì´ ì—†ëŠ” ê²½ìš° ë¹„ë°€ë²ˆí˜¸ë¥¼ ë°”ê¾¸ê¸¸ ê°•ë ¥í•˜ê²Œ ê¶Œê³ ë“œë¦½ë‹ˆë‹¤. {lineBreak}{lineBreak}ë¦¬ì†ŒìŠ¤: {lineBreak}ë¹„ë°€ë²ˆí˜¸ ë³€ê²½ [{accountInfoPageLink}] {lineBreak}2ë‹¨ê³„ ì¸ì¦ ë” ì•Œì•„ë³´ê¸° [{twoStepVerificationHelpArticleLink}]{lineBreak}ê³„ì • ë³´í˜¸ ë°©ë²• [{keepAccountSafeArticleLink}] {lineBreak}ì¼ë°˜ì ì¸ Roblox ê³ ê°ì§€ì› [{supportPageLink}] {lineBreak}{lineBreak}ê°ì‚¬í•©ë‹ˆë‹¤. {lineBreak}{lineBreak}Roblox íŒ€";
	}

	/// <summary>
	/// Key: "Description.TwoStepVerificationLoginEmail.PlainText.GeolocationInfo1"
	/// GeoLocation info of IP trying to login
	/// English String: "Login request received from {username} located in {region}, {country} ({ipAddress}).{lineBreak}{lineBreak}"
	/// </summary>
	public override string DescriptionTwoStepVerificationLoginEmailPlainTextGeolocationInfo1(string username, string region, string country, string ipAddress, string lineBreak)
	{
		return $"{username} ë‹˜ì´ {region}, {country}({ipAddress})ì—ì„œ ë¡œê·¸ì¸ì„ ìš”ì²­í–ˆì–´ìš”.{lineBreak}{lineBreak}";
	}

	protected override string _GetTemplateForDescriptionTwoStepVerificationLoginEmailPlainTextGeolocationInfo1()
	{
		return "{username} ë‹˜ì´ {region}, {country}({ipAddress})ì—ì„œ ë¡œê·¸ì¸ì„ ìš”ì²­í–ˆì–´ìš”.{lineBreak}{lineBreak}";
	}

	/// <summary>
	/// Key: "Description.TwoStepVerificationLoginEmail.PlainText.GeolocationInfo2"
	/// Geolocation info of IP trying to login
	/// English String: "Login request received from {username} located in {country} ({ipAddress}).{lineBreak}{lineBreak}"
	/// </summary>
	public override string DescriptionTwoStepVerificationLoginEmailPlainTextGeolocationInfo2(string username, string country, string ipAddress, string lineBreak)
	{
		return $"{username} ë‹˜ì´ {country}({ipAddress})ì—ì„œ ë¡œê·¸ì¸ì„ ìš”ì²­í–ˆì–´ìš”.{lineBreak}{lineBreak}";
	}

	protected override string _GetTemplateForDescriptionTwoStepVerificationLoginEmailPlainTextGeolocationInfo2()
	{
		return "{username} ë‹˜ì´ {country}({ipAddress})ì—ì„œ ë¡œê·¸ì¸ì„ ìš”ì²­í–ˆì–´ìš”.{lineBreak}{lineBreak}";
	}

	/// <summary>
	/// Key: "Description.TwoStepVerificationLoginEmail.PlainText.GeolocationInfo3"
	/// Geolocation info of IP trying to login
	/// English String: "Login request received from {username} (From Roblox Internal).{lineBreak}{lineBreak}"
	/// </summary>
	public override string DescriptionTwoStepVerificationLoginEmailPlainTextGeolocationInfo3(string username, string lineBreak)
	{
		return $"(Roblox ë‚´ë¶€ì˜) {username} ë‹˜ì´ ë¡œê·¸ì¸ì„ ìš”ì²­í–ˆì–´ìš”.{lineBreak}{lineBreak}";
	}

	protected override string _GetTemplateForDescriptionTwoStepVerificationLoginEmailPlainTextGeolocationInfo3()
	{
		return "(Roblox ë‚´ë¶€ì˜) {username} ë‹˜ì´ ë¡œê·¸ì¸ì„ ìš”ì²­í–ˆì–´ìš”.{lineBreak}{lineBreak}";
	}

	/// <summary>
	/// Key: "Description.TwoStepVerificationLoginEmail.PlainText.GeolocationInfo4"
	/// Geolocation info of IP trying to login
	/// English String: "Login request received from {username} located in {country}.{lineBreak}{lineBreak}"
	/// </summary>
	public override string DescriptionTwoStepVerificationLoginEmailPlainTextGeolocationInfo4(string username, string country, string lineBreak)
	{
		return $"{username} ë‹˜ì´ {country}ì—ì„œ ë¡œê·¸ì¸ì„ ìš”ì²­í–ˆì–´ìš”.{lineBreak}{lineBreak}";
	}

	protected override string _GetTemplateForDescriptionTwoStepVerificationLoginEmailPlainTextGeolocationInfo4()
	{
		return "{username} ë‹˜ì´ {country}ì—ì„œ ë¡œê·¸ì¸ì„ ìš”ì²­í–ˆì–´ìš”.{lineBreak}{lineBreak}";
	}

	/// <summary>
	/// Key: "Description.TwoStepVerificationLoginEmail.PlainText.GeolocationInfo5"
	/// Geolocation info of IP trying to login
	/// English String: "Login request received from {username} located in {region}, {country}.{lineBreak}{lineBreak}"
	/// </summary>
	public override string DescriptionTwoStepVerificationLoginEmailPlainTextGeolocationInfo5(string username, string region, string country, string lineBreak)
	{
		return $"{username} ë‹˜ì´ {country} {region}ì—ì„œ ë¡œê·¸ì¸ì„ ìš”ì²­í–ˆì–´ìš”.{lineBreak}{lineBreak}";
	}

	protected override string _GetTemplateForDescriptionTwoStepVerificationLoginEmailPlainTextGeolocationInfo5()
	{
		return "{username} ë‹˜ì´ {country} {region}ì—ì„œ ë¡œê·¸ì¸ì„ ìš”ì²­í–ˆì–´ìš”.{lineBreak}{lineBreak}";
	}

	/// <summary>
	/// Key: "Description.TwoStepVerificationLoginEmail.PlainText.GeolocationInfo6"
	/// Geolocation info of IP trying to login
	/// English String: "Login request received from {username} located in {city}, {region}, {country}.{lineBreak}{lineBreak}"
	/// </summary>
	public override string DescriptionTwoStepVerificationLoginEmailPlainTextGeolocationInfo6(string username, string city, string region, string country, string lineBreak)
	{
		return $"{username} ë‹˜ì´ {country} {region} {city}ì—ì„œ ë¡œê·¸ì¸ì„ ìš”ì²­í–ˆì–´ìš”.{lineBreak}{lineBreak}";
	}

	protected override string _GetTemplateForDescriptionTwoStepVerificationLoginEmailPlainTextGeolocationInfo6()
	{
		return "{username} ë‹˜ì´ {country} {region} {city}ì—ì„œ ë¡œê·¸ì¸ì„ ìš”ì²­í–ˆì–´ìš”.{lineBreak}{lineBreak}";
	}

	/// <summary>
	/// Key: "Description.TwoStepVerificationLoginEmail.Subject"
	/// Subject for 2SV login email
	/// English String: "Verification Code for Roblox Account: {accountName}"
	/// </summary>
	public override string DescriptionTwoStepVerificationLoginEmailSubject(string accountName)
	{
		return $"Roblox ê³„ì • {accountName}ì— ëŒ€í•œ ì¸ì¦ ì½”ë“œ";
	}

	protected override string _GetTemplateForDescriptionTwoStepVerificationLoginEmailSubject()
	{
		return "Roblox ê³„ì • {accountName}ì— ëŒ€í•œ ì¸ì¦ ì½”ë“œ";
	}

	protected override string _GetTemplateForLabelCode()
	{
		return "ì½”ë“œ";
	}

	/// <summary>
	/// Key: "Label.CodeInputPlaceholderText"
	/// example: Enter 4-digit code
	/// English String: "Enter {codeLength}-digit Code"
	/// </summary>
	public override string LabelCodeInputPlaceholderText(string codeLength)
	{
		return $"{codeLength}ìžë¦¬ ì½”ë“œ ìž…ë ¥";
	}

	protected override string _GetTemplateForLabelCodeInputPlaceholderText()
	{
		return "{codeLength}ìžë¦¬ ì½”ë“œ ìž…ë ¥";
	}

	protected override string _GetTemplateForLabelDidNotReceive()
	{
		return "ì½”ë“œë¥¼ ë°›ì§€ ëª»í•˜ì…¨ë‚˜ìš”?";
	}

	protected override string _GetTemplateForLabelEnterCode()
	{
		return "ì½”ë“œ ìž…ë ¥ (6ìžë¦¬)";
	}

	protected override string _GetTemplateForLabelEnterEmailCode()
	{
		return "ë°©ê¸ˆ ì´ë©”ì¼ë¡œ ì „ì†¡ëœ ì½”ë“œë¥¼ ìž…ë ¥í•˜ì„¸ìš”.";
	}

	protected override string _GetTemplateForLabelEnterTextCode()
	{
		return "ë°©ê¸ˆ ë¬¸ìž ë©”ì‹œì§€ë¡œ ì „ì†¡ëœ ì½”ë“œë¥¼ ìž…ë ¥í•˜ì„¸ìš”.";
	}

	protected override string _GetTemplateForLabelEnterTwoStepVerificationCode()
	{
		return "2ë‹¨ê³„ ì¸ì¦ ì½”ë“œë¥¼ ìž…ë ¥í•˜ì„¸ìš”.";
	}

	protected override string _GetTemplateForLabelFacebookPasswordWarning()
	{
		return "Facebookìœ¼ë¡œ ë¡œê·¸ì¸í•œ ê²½ìš°, ë¹„ë°€ë²ˆí˜¸ë¥¼ ì„¤ì •í•´ì•¼ í•©ë‹ˆë‹¤.";
	}

	protected override string _GetTemplateForLabelLearnMore()
	{
		return "ë” ì•Œì•„ë³´ê¸°";
	}

	/// <summary>
	/// Key: "Label.NeedHelpContactSupport"
	/// label for the support article link
	/// English String: "Need help? Contact {supportLink}"
	/// </summary>
	public override string LabelNeedHelpContactSupport(string supportLink)
	{
		return $"ë„ì›€ì´ í•„ìš”í•˜ì„¸ìš”? {supportLink}(ìœ¼)ë¡œ ë¬¸ì˜í•˜ì„¸ìš”";
	}

	protected override string _GetTemplateForLabelNeedHelpContactSupport()
	{
		return "ë„ì›€ì´ í•„ìš”í•˜ì„¸ìš”? {supportLink}(ìœ¼)ë¡œ ë¬¸ì˜í•˜ì„¸ìš”";
	}

	protected override string _GetTemplateForLabelNewCode()
	{
		return "ìƒˆ ì½”ë“œ";
	}

	protected override string _GetTemplateForLabelRobloxSupport()
	{
		return "Roblox ê³ ê°ì§€ì›";
	}

	protected override string _GetTemplateForLabelTrustThisDevice()
	{
		return "30ì¼ ë™ì•ˆ ë³¸ ê¸°ê¸° ì‹ ë¢°";
	}

	protected override string _GetTemplateForLabelTwoStepVerification()
	{
		return "2ë‹¨ê³„ ì¸ì¦";
	}

	protected override string _GetTemplateForResponseCodeSent()
	{
		return "ì½”ë“œ ì „ì†¡ ì™„ë£Œ";
	}

	protected override string _GetTemplateForResponseFeatureNotAvailable()
	{
		return "ì‚¬ìš©í•  ìˆ˜ ì—†ëŠ” ê¸°ëŠ¥.\u00a0ê³ ê°ì§€ì›ìœ¼ë¡œ ë¬¸ì˜í•˜ì„¸ìš”.";
	}

	protected override string _GetTemplateForResponseInvalidCode()
	{
		return "ìœ íš¨í•˜ì§€ ì•Šì€ ì½”ë“œ";
	}

	protected override string _GetTemplateForResponseSystemErrorReturnToLogin()
	{
		return "ì‹œìŠ¤í…œ ì˜¤ë¥˜.\u00a0ë¡œê·¸ì¸ í™”ë©´ìœ¼ë¡œ ëŒì•„ê°€ì„¸ìš”.";
	}

	protected override string _GetTemplateForResponseTooManyAttempts()
	{
		return "ì‹œë„ ê°€ëŠ¥ íšŸìˆ˜ë¥¼ ì´ˆê³¼í–ˆìŠµë‹ˆë‹¤.\u00a0ë‚˜ì¤‘ì— ë‹¤ì‹œ ì‹œë„í•˜ì„¸ìš”.";
	}

	protected override string _GetTemplateForResponseTooManyCharacters()
	{
		return "ìž…ë ¥ ê°€ëŠ¥ ê¸€ìž ìˆ˜ë¥¼ ì´ˆê³¼í–ˆìŠµë‹ˆë‹¤";
	}
}


}
