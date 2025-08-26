namespace Roblox.Platform.TranslationResources.Authentication {
    /// <summary>

/// This class overrides TwoStepVerificationResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class TwoStepVerificationResources_ja_jp : TwoStepVerificationResources_en_us, ITwoStepVerificationResources, ITranslationResources
{
	/// <summary>
	/// Key: "Action.Cancel"
	/// English String: "Cancel"
	/// </summary>
	public override string ActionCancel => "ã‚­ãƒ£ãƒ³ã‚»ãƒ«";

	/// <summary>
	/// Key: "Action.Resend"
	/// English String: "Resend Code"
	/// </summary>
	public override string ActionResend => "ã‚³ãƒ¼ãƒ‰ã‚’å†é€ä¿¡";

	/// <summary>
	/// Key: "Action.StartOver"
	/// link text to restart verification
	/// English String: "Start Over"
	/// </summary>
	public override string ActionStartOver => "ã‚„ã‚Šç›´ã™";

	/// <summary>
	/// Key: "Action.Submit"
	/// submit button text
	/// English String: "Submit"
	/// </summary>
	public override string ActionSubmit => "é€ä¿¡";

	/// <summary>
	/// Key: "Action.Verify"
	/// English String: "Verify"
	/// </summary>
	public override string ActionVerify => "ç¢ºèª";

	/// <summary>
	/// Key: "Label.Code"
	/// verification code for 2 factor authentication
	/// English String: "Code"
	/// </summary>
	public override string LabelCode => "ã‚³ãƒ¼ãƒ‰";

	/// <summary>
	/// Key: "Label.DidNotReceive"
	/// English String: "Didn't receive the code?"
	/// </summary>
	public override string LabelDidNotReceive => "ã‚³ãƒ¼ãƒ‰ã‚’å—ã‘å–ã‚Šã¾ã›ã‚“ã§ã—ãŸã‹ï¼Ÿ";

	/// <summary>
	/// Key: "Label.EnterCode"
	/// English String: "Enter Code (6-digit)"
	/// </summary>
	public override string LabelEnterCode => "ã‚³ãƒ¼ãƒ‰ã‚’å…¥åŠ› (6æ¡)";

	/// <summary>
	/// Key: "Label.EnterEmailCode"
	/// English String: "Enter the code we just sent you via email"
	/// </summary>
	public override string LabelEnterEmailCode => "ä»Šãƒ¡ãƒ¼ãƒ«ã§é€ä¿¡ã—ãŸã‚³ãƒ¼ãƒ‰ã‚’å…¥åŠ›ã—ã¦ãã ã•ã„";

	/// <summary>
	/// Key: "Label.EnterTextCode"
	/// English String: "Enter the code we just sent you via text message"
	/// </summary>
	public override string LabelEnterTextCode => "ä»Šãƒ†ã‚­ã‚¹ãƒˆãƒ¡ãƒƒã‚»ãƒ¼ã‚¸ã§é€ä¿¡ã—ãŸã‚³ãƒ¼ãƒ‰ã‚’å…¥åŠ›ã—ã¦ãã ã•ã„";

	/// <summary>
	/// Key: "Label.EnterTwoStepVerificationCode"
	/// Enter your two step verification code.
	/// English String: "Enter your two step verification code."
	/// </summary>
	public override string LabelEnterTwoStepVerificationCode => "äºŒæ®µéšŽèªè¨¼ã‚³ãƒ¼ãƒ‰ã‚’å…¥åŠ›ã—ã¦ãã ã•ã„ã€‚";

	/// <summary>
	/// Key: "Label.FacebookPasswordWarning"
	/// If you have been signing in with Facebook, you must set a password.
	/// English String: "If you have been signing in with Facebook, you must set a password."
	/// </summary>
	public override string LabelFacebookPasswordWarning => "Facebookã§ã‚µã‚¤ãƒ³ã‚¤ãƒ³ã—ã¦ã„ã‚‹å ´åˆã«ã¯ã€ãƒ‘ã‚¹ãƒ¯ãƒ¼ãƒ‰ã®è¨­å®šãŒå¿…è¦ã§ã™ã€‚";

	/// <summary>
	/// Key: "Label.LearnMore"
	/// Learn More link text
	/// English String: "Learn More"
	/// </summary>
	public override string LabelLearnMore => "è©³ã—ãçŸ¥ã‚‹";

	/// <summary>
	/// Key: "Label.NewCode"
	/// verification code resent, label changes to new code
	/// English String: "New Code"
	/// </summary>
	public override string LabelNewCode => "æ–°ã—ã„ã‚³ãƒ¼ãƒ‰";

	/// <summary>
	/// Key: "Label.RobloxSupport"
	/// English String: "Roblox Support"
	/// </summary>
	public override string LabelRobloxSupport => "Robloxã‚µãƒãƒ¼ãƒˆ";

	/// <summary>
	/// Key: "Label.TrustThisDevice"
	/// English String: "Trust this device for 30 days"
	/// </summary>
	public override string LabelTrustThisDevice => "ã“ã®ãƒ‡ãƒã‚¤ã‚¹ã‚’30æ—¥é–“ä¿¡é ¼ã™ã‚‹";

	/// <summary>
	/// Key: "Label.TwoStepVerification"
	/// English String: "2-Step Verification"
	/// </summary>
	public override string LabelTwoStepVerification => "2æ®µéšŽèªè¨¼";

	/// <summary>
	/// Key: "Response.CodeSent"
	/// English String: "Code Sent"
	/// </summary>
	public override string ResponseCodeSent => "ã‚³ãƒ¼ãƒ‰ãŒé€ä¿¡ã•ã‚Œã¾ã—ãŸ";

	/// <summary>
	/// Key: "Response.FeatureNotAvailable"
	/// English String: "Feature not available. Please contact support."
	/// </summary>
	public override string ResponseFeatureNotAvailable => "æ©Ÿèƒ½ãŒåˆ©ç”¨ã§ãã¾ã›ã‚“ã€‚ã‚µãƒãƒ¼ãƒˆã¾ã§ã”é€£çµ¡ãã ã•ã„ã€‚";

	/// <summary>
	/// Key: "Response.InvalidCode"
	/// English String: "Invalid code."
	/// </summary>
	public override string ResponseInvalidCode => "ç„¡åŠ¹ãªã‚³ãƒ¼ãƒ‰ã€‚";

	/// <summary>
	/// Key: "Response.SystemErrorReturnToLogin"
	/// English String: "System error. Please return to login screen."
	/// </summary>
	public override string ResponseSystemErrorReturnToLogin => "ã‚·ã‚¹ãƒ†ãƒ ã‚¨ãƒ©ãƒ¼ã€‚ãƒ­ã‚°ã‚¤ãƒ³ç”»é¢ã«ãŠæˆ»ã‚Šãã ã•ã„ã€‚";

	/// <summary>
	/// Key: "Response.TooManyAttempts"
	/// English String: "Too many attempts. Please try again later."
	/// </summary>
	public override string ResponseTooManyAttempts => "è©¦è¡Œå›žæ•°ãŒå¤šã™ãŽã¾ã™ã€‚ã—ã°ã‚‰ãã—ã¦ã‹ã‚‰ã‚„ã‚Šç›´ã—ã¦ãã ã•ã„ã€‚";

	/// <summary>
	/// Key: "Response.TooManyCharacters"
	/// error message
	/// English String: "Too many characters"
	/// </summary>
	public override string ResponseTooManyCharacters => "æ–‡å­—æ•°ãŒå¤šã™ãŽã¾ã™";

	public TwoStepVerificationResources_ja_jp(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionCancel()
	{
		return "ã‚­ãƒ£ãƒ³ã‚»ãƒ«";
	}

	protected override string _GetTemplateForActionResend()
	{
		return "ã‚³ãƒ¼ãƒ‰ã‚’å†é€ä¿¡";
	}

	protected override string _GetTemplateForActionStartOver()
	{
		return "ã‚„ã‚Šç›´ã™";
	}

	protected override string _GetTemplateForActionSubmit()
	{
		return "é€ä¿¡";
	}

	protected override string _GetTemplateForActionVerify()
	{
		return "ç¢ºèª";
	}

	/// <summary>
	/// Key: "Description.TwoStepVerificationActivationEmail.Body.Over13"
	/// Body for 2SV activation email for over 13 users
	/// English String: "Hi {accountName},{lineBreak}{lineBreak}You have activated 2-Step Verification for your Roblox account. Next time you log in from a new device, you will need to enter a 6-digit security code that Roblox sends to you via email.{lineBreak}{lineBreak}Roblox"
	/// </summary>
	public override string DescriptionTwoStepVerificationActivationEmailBodyOver13(string accountName, string lineBreak)
	{
		return $"{accountName}ã•ã‚“ã€ã“ã‚“ã«ã¡ã¯ã€‚{lineBreak}{lineBreak}Robloxã‚¢ã‚«ã‚¦ãƒ³ãƒˆã®2æ®µéšŽèªè¨¼ãƒ—ãƒ­ã‚»ã‚¹ãŒæœ‰åŠ¹ã«ãªã‚Šã¾ã—ãŸã€‚ æ–°ã—ã„ãƒ‡ãƒã‚¤ã‚¹ã‹ã‚‰æ¬¡å›žãƒ­ã‚°ã‚¤ãƒ³ã™ã‚‹æ™‚ã«ã€RobloxãŒãƒ¡ãƒ¼ãƒ«ã§ãŠé€ã‚Šã™ã‚‹ï¼–æ¡ã®ã‚»ã‚­ãƒ¥ãƒªãƒ†ã‚£ã‚³ãƒ¼ãƒ‰ã®å…¥åŠ›ãŒå¿…è¦ã¨ãªã‚Šã¾ã™ã€‚{lineBreak}{lineBreak}Roblox";
	}

	protected override string _GetTemplateForDescriptionTwoStepVerificationActivationEmailBodyOver13()
	{
		return "{accountName}ã•ã‚“ã€ã“ã‚“ã«ã¡ã¯ã€‚{lineBreak}{lineBreak}Robloxã‚¢ã‚«ã‚¦ãƒ³ãƒˆã®2æ®µéšŽèªè¨¼ãƒ—ãƒ­ã‚»ã‚¹ãŒæœ‰åŠ¹ã«ãªã‚Šã¾ã—ãŸã€‚ æ–°ã—ã„ãƒ‡ãƒã‚¤ã‚¹ã‹ã‚‰æ¬¡å›žãƒ­ã‚°ã‚¤ãƒ³ã™ã‚‹æ™‚ã«ã€RobloxãŒãƒ¡ãƒ¼ãƒ«ã§ãŠé€ã‚Šã™ã‚‹ï¼–æ¡ã®ã‚»ã‚­ãƒ¥ãƒªãƒ†ã‚£ã‚³ãƒ¼ãƒ‰ã®å…¥åŠ›ãŒå¿…è¦ã¨ãªã‚Šã¾ã™ã€‚{lineBreak}{lineBreak}Roblox";
	}

	/// <summary>
	/// Key: "Description.TwoStepVerificationActivationEmail.Body.Under13"
	/// Body for 2SV activation email for under 13 users
	/// English String: "Hi,{lineBreak}{lineBreak}2-Step Verification has been activated for your child's Roblox account, {accountName}. Next time they log in from a new device, they will need to enter a 6-digit security code that Roblox sends to you via email.{lineBreak}{lineBreak}Roblox"
	/// </summary>
	public override string DescriptionTwoStepVerificationActivationEmailBodyUnder13(string lineBreak, string accountName)
	{
		return $"ã“ã‚“ã«ã¡ã¯ã€‚{lineBreak}{lineBreak}ãŠå­æ§˜ã®Robloxã‚¢ã‚«ã‚¦ãƒ³ãƒˆ{accountName}ã®2æ®µéšŽèªè¨¼ãƒ—ãƒ­ã‚»ã‚¹ãŒæœ‰åŠ¹ã«ãªã‚Šã¾ã—ãŸã€‚ ãŠå­æ§˜ãŒæ–°ã—ã„ãƒ‡ãƒã‚¤ã‚¹ã‹ã‚‰æ¬¡å›žãƒ­ã‚°ã‚¤ãƒ³ã™ã‚‹æ™‚ã«ã€RobloxãŒãƒ¡ãƒ¼ãƒ«ã§ãŠé€ã‚Šã™ã‚‹ï¼–æ¡ã®ã‚»ã‚­ãƒ¥ãƒªãƒ†ã‚£ã‚³ãƒ¼ãƒ‰ã®å…¥åŠ›ãŒå¿…è¦ã¨ãªã‚Šã¾ã™ã€‚{lineBreak}{lineBreak}Roblox";
	}

	protected override string _GetTemplateForDescriptionTwoStepVerificationActivationEmailBodyUnder13()
	{
		return "ã“ã‚“ã«ã¡ã¯ã€‚{lineBreak}{lineBreak}ãŠå­æ§˜ã®Robloxã‚¢ã‚«ã‚¦ãƒ³ãƒˆ{accountName}ã®2æ®µéšŽèªè¨¼ãƒ—ãƒ­ã‚»ã‚¹ãŒæœ‰åŠ¹ã«ãªã‚Šã¾ã—ãŸã€‚ ãŠå­æ§˜ãŒæ–°ã—ã„ãƒ‡ãƒã‚¤ã‚¹ã‹ã‚‰æ¬¡å›žãƒ­ã‚°ã‚¤ãƒ³ã™ã‚‹æ™‚ã«ã€RobloxãŒãƒ¡ãƒ¼ãƒ«ã§ãŠé€ã‚Šã™ã‚‹ï¼–æ¡ã®ã‚»ã‚­ãƒ¥ãƒªãƒ†ã‚£ã‚³ãƒ¼ãƒ‰ã®å…¥åŠ›ãŒå¿…è¦ã¨ãªã‚Šã¾ã™ã€‚{lineBreak}{lineBreak}Roblox";
	}

	/// <summary>
	/// Key: "Description.TwoStepVerificationActivationEmail.Subject"
	/// Subject for 2SV activation email
	/// English String: "2-Step Verification Activated for Roblox Account: {accountName}"
	/// </summary>
	public override string DescriptionTwoStepVerificationActivationEmailSubject(string accountName)
	{
		return $"Robloxã‚¢ã‚«ã‚¦ãƒ³ãƒˆã®2æ®µéšŽèªè¨¼ãƒ—ãƒ­ã‚»ã‚¹ãŒæœ‰åŠ¹ã«ãªã‚Šã¾ã—ãŸï¼š {accountName}";
	}

	protected override string _GetTemplateForDescriptionTwoStepVerificationActivationEmailSubject()
	{
		return "Robloxã‚¢ã‚«ã‚¦ãƒ³ãƒˆã®2æ®µéšŽèªè¨¼ãƒ—ãƒ­ã‚»ã‚¹ãŒæœ‰åŠ¹ã«ãªã‚Šã¾ã—ãŸï¼š {accountName}";
	}

	/// <summary>
	/// Key: "Description.TwoStepVerificationDeactivationEmail.Body.Over13"
	/// Body for 2SV deactivation email for over 13 users
	/// English String: "Hi {accountName},{lineBreak}{lineBreak}You have deactivated 2-Step Verification for your Roblox account. A security code will no longer be required when you log into your account.{lineBreak}{lineBreak}Roblox"
	/// </summary>
	public override string DescriptionTwoStepVerificationDeactivationEmailBodyOver13(string accountName, string lineBreak)
	{
		return $"{accountName}ã•ã‚“ã€ã“ã‚“ã«ã¡ã¯ã€‚{lineBreak}{lineBreak}Robloxã‚¢ã‚«ã‚¦ãƒ³ãƒˆã®2æ®µéšŽèªè¨¼ãƒ—ãƒ­ã‚»ã‚¹ãŒç„¡åŠ¹ã«ãªã‚Šã¾ã—ãŸã€‚ ã‚¢ã‚«ã‚¦ãƒ³ãƒˆã«æ¬¡å›žãƒ­ã‚°ã‚¤ãƒ³ã™ã‚‹æ™‚ã«ã€ã‚»ã‚­ãƒ¥ãƒªãƒ†ã‚£ã‚³ãƒ¼ãƒ‰ã®å…¥åŠ›ã¯ä¸è¦ã«ãªã‚Šã¾ã™ã€‚{lineBreak}{lineBreak}Roblox";
	}

	protected override string _GetTemplateForDescriptionTwoStepVerificationDeactivationEmailBodyOver13()
	{
		return "{accountName}ã•ã‚“ã€ã“ã‚“ã«ã¡ã¯ã€‚{lineBreak}{lineBreak}Robloxã‚¢ã‚«ã‚¦ãƒ³ãƒˆã®2æ®µéšŽèªè¨¼ãƒ—ãƒ­ã‚»ã‚¹ãŒç„¡åŠ¹ã«ãªã‚Šã¾ã—ãŸã€‚ ã‚¢ã‚«ã‚¦ãƒ³ãƒˆã«æ¬¡å›žãƒ­ã‚°ã‚¤ãƒ³ã™ã‚‹æ™‚ã«ã€ã‚»ã‚­ãƒ¥ãƒªãƒ†ã‚£ã‚³ãƒ¼ãƒ‰ã®å…¥åŠ›ã¯ä¸è¦ã«ãªã‚Šã¾ã™ã€‚{lineBreak}{lineBreak}Roblox";
	}

	/// <summary>
	/// Key: "Description.TwoStepVerificationDeactivationEmail.Body.Under13"
	/// Body for 2SV deactivation email for under 13 users
	/// English String: "Hi,{lineBreak}{lineBreak}2-Step Verification has been deactivated for your child's Roblox account, {accountName}. A security code will no longer be required when they log into the account.{lineBreak}{lineBreak}Roblox"
	/// </summary>
	public override string DescriptionTwoStepVerificationDeactivationEmailBodyUnder13(string lineBreak, string accountName)
	{
		return $"ã“ã‚“ã«ã¡ã¯ã€‚{lineBreak}{lineBreak}ãŠå­æ§˜ã®Robloxã‚¢ã‚«ã‚¦ãƒ³ãƒˆ{accountName}ã®2æ®µéšŽèªè¨¼ãƒ—ãƒ­ã‚»ã‚¹ãŒç„¡åŠ¹ã«ãªã‚Šã¾ã—ãŸã€‚ ãŠå­æ§˜ãŒã‚¢ã‚«ã‚¦ãƒ³ãƒˆã«æ¬¡å›žãƒ­ã‚°ã‚¤ãƒ³ã™ã‚‹æ™‚ã«ã€ã‚»ã‚­ãƒ¥ãƒªãƒ†ã‚£ã‚³ãƒ¼ãƒ‰ã®å…¥åŠ›ã¯ä¸è¦ã«ãªã‚Šã¾ã™ã€‚{lineBreak}{lineBreak}Roblox";
	}

	protected override string _GetTemplateForDescriptionTwoStepVerificationDeactivationEmailBodyUnder13()
	{
		return "ã“ã‚“ã«ã¡ã¯ã€‚{lineBreak}{lineBreak}ãŠå­æ§˜ã®Robloxã‚¢ã‚«ã‚¦ãƒ³ãƒˆ{accountName}ã®2æ®µéšŽèªè¨¼ãƒ—ãƒ­ã‚»ã‚¹ãŒç„¡åŠ¹ã«ãªã‚Šã¾ã—ãŸã€‚ ãŠå­æ§˜ãŒã‚¢ã‚«ã‚¦ãƒ³ãƒˆã«æ¬¡å›žãƒ­ã‚°ã‚¤ãƒ³ã™ã‚‹æ™‚ã«ã€ã‚»ã‚­ãƒ¥ãƒªãƒ†ã‚£ã‚³ãƒ¼ãƒ‰ã®å…¥åŠ›ã¯ä¸è¦ã«ãªã‚Šã¾ã™ã€‚{lineBreak}{lineBreak}Roblox";
	}

	/// <summary>
	/// Key: "Description.TwoStepVerificationDeactivationEmail.Subject	"
	/// Subject for 2SV deactivation email
	/// English String: "2-Step Verification Deactivated for Roblox Account: {accountName}"
	/// </summary>
	public override string DescriptionTwoStepVerificationDeactivationEmailSubject(string accountName)
	{
		return $"Robloxã‚¢ã‚«ã‚¦ãƒ³ãƒˆã®2æ®µéšŽèªè¨¼ãƒ—ãƒ­ã‚»ã‚¹ãŒç„¡åŠ¹ã«ãªã‚Šã¾ã—ãŸï¼š{accountName}";
	}

	protected override string _GetTemplateForDescriptionTwoStepVerificationDeactivationEmailSubject()
	{
		return "Robloxã‚¢ã‚«ã‚¦ãƒ³ãƒˆã®2æ®µéšŽèªè¨¼ãƒ—ãƒ­ã‚»ã‚¹ãŒç„¡åŠ¹ã«ãªã‚Šã¾ã—ãŸï¼š{accountName}";
	}

	/// <summary>
	/// Key: "Description.TwoStepVerificationLoginEmail.Html.GeolocationInfo1"
	/// Geolocation information about IP trying to login
	/// English String: "{spanStartTagWithBold}Login request received from {username} located in {region}, {country} ({ipAddress}).{spanEndTag}{lineBreak}{lineBreak}"
	/// </summary>
	public override string DescriptionTwoStepVerificationLoginEmailHtmlGeolocationInfo1(string spanStartTagWithBold, string username, string region, string country, string ipAddress, string spanEndTag, string lineBreak)
	{
		return $"{spanStartTagWithBold}{country}({ipAddress})ã®{region}ã«å±…ä½ã™ã‚‹{username} ã‹ã‚‰ãƒ­ã‚°ã‚¤ãƒ³ãƒªã‚¯ã‚¨ã‚¹ãƒˆã‚’å—ã‘ã¾ã—ãŸã€‚{spanEndTag}{lineBreak}{lineBreak}";
	}

	protected override string _GetTemplateForDescriptionTwoStepVerificationLoginEmailHtmlGeolocationInfo1()
	{
		return "{spanStartTagWithBold}{country}({ipAddress})ã®{region}ã«å±…ä½ã™ã‚‹{username} ã‹ã‚‰ãƒ­ã‚°ã‚¤ãƒ³ãƒªã‚¯ã‚¨ã‚¹ãƒˆã‚’å—ã‘ã¾ã—ãŸã€‚{spanEndTag}{lineBreak}{lineBreak}";
	}

	/// <summary>
	/// Key: "Description.TwoStepVerificationLoginEmail.Html.GeolocationInfo2"
	/// Geolocation info about IP trying to login
	/// English String: "{spanStartTagWithBold}Login request received from {username} located in {country} ({ipAddress}).{spanEndTag}{lineBreak}{lineBreak}\t"
	/// </summary>
	public override string DescriptionTwoStepVerificationLoginEmailHtmlGeolocationInfo2(string spanStartTagWithBold, string username, string country, string ipAddress, string spanEndTag, string lineBreak)
	{
		return $"{spanStartTagWithBold}{country}({ipAddress})ã«ä½ã‚€ {username} ã•ã‚“ã‹ã‚‰ãƒ­ã‚°ã‚¤ãƒ³ãƒªã‚¯ã‚¨ã‚¹ãƒˆã‚’å—ã‘ã¾ã—ãŸã€‚{spanEndTag}{lineBreak}{lineBreak}\t";
	}

	protected override string _GetTemplateForDescriptionTwoStepVerificationLoginEmailHtmlGeolocationInfo2()
	{
		return "{spanStartTagWithBold}{country}({ipAddress})ã«ä½ã‚€ {username} ã•ã‚“ã‹ã‚‰ãƒ­ã‚°ã‚¤ãƒ³ãƒªã‚¯ã‚¨ã‚¹ãƒˆã‚’å—ã‘ã¾ã—ãŸã€‚{spanEndTag}{lineBreak}{lineBreak}\t";
	}

	/// <summary>
	/// Key: "Description.TwoStepVerificationLoginEmail.Html.GeolocationInfo3"
	/// Geolocation info about IP trying to log in
	/// English String: "{spanStartTagWithBold}Login request received from {username} (From Roblox Internal).{spanEndTag}{lineBreak}{lineBreak}\t"
	/// </summary>
	public override string DescriptionTwoStepVerificationLoginEmailHtmlGeolocationInfo3(string spanStartTagWithBold, string username, string spanEndTag, string lineBreak)
	{
		return $"{spanStartTagWithBold}{username} (Robloxå†…éƒ¨)ã‹ã‚‰ãƒ­ã‚°ã‚¤ãƒ³ãƒªã‚¯ã‚¨ã‚¹ãƒˆã‚’å—ã‘ã¾ã—ãŸã€‚{spanEndTag}{lineBreak}{lineBreak}\t";
	}

	protected override string _GetTemplateForDescriptionTwoStepVerificationLoginEmailHtmlGeolocationInfo3()
	{
		return "{spanStartTagWithBold}{username} (Robloxå†…éƒ¨)ã‹ã‚‰ãƒ­ã‚°ã‚¤ãƒ³ãƒªã‚¯ã‚¨ã‚¹ãƒˆã‚’å—ã‘ã¾ã—ãŸã€‚{spanEndTag}{lineBreak}{lineBreak}\t";
	}

	/// <summary>
	/// Key: "Description.TwoStepVerificationLoginEmail.Html.GeolocationInfo4"
	/// Geolocation info of IP trying to login
	/// English String: "{spanStartTagWithBold}Login request received from {username} located in {country}.{spanEndTag}{lineBreak}{lineBreak}"
	/// </summary>
	public override string DescriptionTwoStepVerificationLoginEmailHtmlGeolocationInfo4(string spanStartTagWithBold, string username, string country, string spanEndTag, string lineBreak)
	{
		return $"{spanStartTagWithBold}{country}ã«ä½ã‚€ {username} ã•ã‚“ã‹ã‚‰ãƒ­ã‚°ã‚¤ãƒ³ãƒªã‚¯ã‚¨ã‚¹ãƒˆã‚’å—ã‘ã¾ã—ãŸã€‚{spanEndTag}{lineBreak}{lineBreak}";
	}

	protected override string _GetTemplateForDescriptionTwoStepVerificationLoginEmailHtmlGeolocationInfo4()
	{
		return "{spanStartTagWithBold}{country}ã«ä½ã‚€ {username} ã•ã‚“ã‹ã‚‰ãƒ­ã‚°ã‚¤ãƒ³ãƒªã‚¯ã‚¨ã‚¹ãƒˆã‚’å—ã‘ã¾ã—ãŸã€‚{spanEndTag}{lineBreak}{lineBreak}";
	}

	/// <summary>
	/// Key: "Description.TwoStepVerificationLoginEmail.Html.GeolocationInfo5"
	/// Geolocation info of IP trying to login
	/// English String: "{spanStartTagWithBold}Login request received from {username} located in {region}, {country}.{spanEndTag}{lineBreak}{lineBreak}"
	/// </summary>
	public override string DescriptionTwoStepVerificationLoginEmailHtmlGeolocationInfo5(string spanStartTagWithBold, string username, string region, string country, string spanEndTag, string lineBreak)
	{
		return $"{spanStartTagWithBold}{country}ã€{region}ã«ä½ã‚€ {username} ã•ã‚“ã‹ã‚‰ãƒ­ã‚°ã‚¤ãƒ³ãƒªã‚¯ã‚¨ã‚¹ãƒˆã‚’å—ã‘ã¾ã—ãŸã€‚{spanEndTag}{lineBreak}{lineBreak}";
	}

	protected override string _GetTemplateForDescriptionTwoStepVerificationLoginEmailHtmlGeolocationInfo5()
	{
		return "{spanStartTagWithBold}{country}ã€{region}ã«ä½ã‚€ {username} ã•ã‚“ã‹ã‚‰ãƒ­ã‚°ã‚¤ãƒ³ãƒªã‚¯ã‚¨ã‚¹ãƒˆã‚’å—ã‘ã¾ã—ãŸã€‚{spanEndTag}{lineBreak}{lineBreak}";
	}

	/// <summary>
	/// Key: "Description.TwoStepVerificationLoginEmail.Html.GeolocationInfo6"
	/// Geolocation info of IP trying to login
	/// English String: "{spanStartTagWithBold}Login request received from {username} located in {city}, {region}, {country}.{spanEndTag}{lineBreak}{lineBreak}"
	/// </summary>
	public override string DescriptionTwoStepVerificationLoginEmailHtmlGeolocationInfo6(string spanStartTagWithBold, string username, string city, string region, string country, string spanEndTag, string lineBreak)
	{
		return $"{spanStartTagWithBold}{country}ã€{region}ã€{city}ã«ä½ã‚€ {username} ã•ã‚“ã‹ã‚‰ãƒ­ã‚°ã‚¤ãƒ³ãƒªã‚¯ã‚¨ã‚¹ãƒˆã‚’å—ã‘ã¾ã—ãŸã€‚{spanEndTag}{lineBreak}{lineBreak}";
	}

	protected override string _GetTemplateForDescriptionTwoStepVerificationLoginEmailHtmlGeolocationInfo6()
	{
		return "{spanStartTagWithBold}{country}ã€{region}ã€{city}ã«ä½ã‚€ {username} ã•ã‚“ã‹ã‚‰ãƒ­ã‚°ã‚¤ãƒ³ãƒªã‚¯ã‚¨ã‚¹ãƒˆã‚’å—ã‘ã¾ã—ãŸã€‚{spanEndTag}{lineBreak}{lineBreak}";
	}

	/// <summary>
	/// Key: "Description.TwoStepVerificationLoginEmail.HtmlBody"
	/// Html body for 2SV login email
	/// English String: "{geoLocationInformation}{spanStartTagWithBold}Login code for {accountName}: {lineBreak}{lineBreak}{code} {spanEndTag}{lineBreak}{lineBreak}Enter this code into the 2-Step Verification screen to finish logging in. This code will expire in 15 minutes.{lineBreak}{lineBreak}This email was sent because your account tried to login to Roblox from a new browser or device. If you haven't tried logging into Roblox, someone else may be trying to access your account. You are strongly advised to change your password if you did not generate this request.{lineBreak}{lineBreak}Resources:{lineBreak}{aTagStartWithHref}{ChangePasswordLink}{hrefEnd}Change Your Password{aTagEnd} {lineBreak}{aTagStartWithHref}{TwoStepVerificationArticleLink}{hrefEnd}Learn More About 2-Step Verification{aTagEnd} {lineBreak}{aTagStartWithHref}{AccountSafetyArticleLink}{hrefEnd}Keeping Your Account Safe{aTagEnd} {lineBreak}{aTagStartWithHref}{SupportLink}{hrefEnd}General Roblox Support{aTagEnd} {lineBreak}{lineBreak}Thank you,{lineBreak}{lineBreak}The Roblox Team"
	/// </summary>
	public override string DescriptionTwoStepVerificationLoginEmailHtmlBody(string geoLocationInformation, string spanStartTagWithBold, string accountName, string lineBreak, string code, string spanEndTag, string aTagStartWithHref, string ChangePasswordLink, string hrefEnd, string aTagEnd, string TwoStepVerificationArticleLink, string AccountSafetyArticleLink, string SupportLink)
	{
		return $"{geoLocationInformation}{spanStartTagWithBold}ã®ãƒ­ã‚°ã‚¤ãƒ³ã‚³ãƒ¼ãƒ‰{accountName}: {lineBreak}{lineBreak}{code}{spanEndTag}{lineBreak}{lineBreak}ã“ã®ã‚³ãƒ¼ãƒ‰ã‚’2æ®µéšŽèªè¨¼ç”»é¢ã«å…¥åŠ›ã™ã‚Œã°ãƒ­ã‚°ã‚¤ãƒ³ãŒå®Œäº†ã—ã¾ã™ã€‚ã‚³ãƒ¼ãƒ‰ã¯15åˆ†å¾Œã«æœŸé™åˆ‡ã‚Œã«ãªã‚Šã¾ã™ã€‚{lineBreak}{lineBreak}ã‚¢ã‚«ã‚¦ãƒ³ãƒˆãŒæ–°ã—ã„ãƒ–ãƒ©ã‚¦ã‚¶ã€ã¾ãŸã¯ãƒ‡ãƒã‚¤ã‚¹ã‹ã‚‰ã®Robloxã¸ã®ãƒ­ã‚°ã‚¤ãƒ³ã«ä½¿ç”¨ã•ã‚ŒãŸãŸã‚ã€ã“ã®ãƒ¡ãƒ¼ãƒ«ã‚’ãŠé€ã‚Šã—ã¦ã„ã¾ã™ã€‚Robloxã«ãƒ­ã‚°ã‚¤ãƒ³ã—ã‚ˆã†ã¨ã—ã¦ã„ãªã„å ´åˆã¯ã‚¢ã‚«ã‚¦ãƒ³ãƒˆã¯ä¸æ­£ã‚¢ã‚¯ã‚»ã‚¹ã•ã‚Œã¦ã„ã‚‹å¯èƒ½æ€§ãŒã‚ã‚Šã¾ã™ã€‚ã“ã®ãƒªã‚¯ã‚¨ã‚¹ãƒˆã«è¦šãˆãŒå ´åˆã¯ãƒ‘ã‚¹ãƒ¯ãƒ¼ãƒ‰ã‚’å¤‰æ›´ã™ã‚‹ã“ã¨ã‚’å¼·ããŠã™ã™ã‚ã—ã¾ã™ã€‚{lineBreak}{lineBreak}ãƒªã‚½ãƒ¼ã‚¹: {lineBreak}{aTagStartWithHref}{ChangePasswordLink}{hrefEnd}ãƒ‘ã‚¹ãƒ¯ãƒ¼ãƒ‰ã®å¤‰æ›´{aTagEnd}{lineBreak}{aTagStartWithHref}{TwoStepVerificationArticleLink}{hrefEnd}2æ®µéšŽèªè¨¼ã«ã¤ã„ã¦ {aTagEnd}{lineBreak}{aTagStartWithHref}{AccountSafetyArticleLink}{hrefEnd}ã‚¢ã‚«ã‚¦ãƒ³ãƒˆã‚’å®‰å…¨ã«ä¿ã¡ç¶šã‘ã¾ã—ã‚‡ã† {aTagEnd}{lineBreak}{aTagStartWithHref}{SupportLink}{hrefEnd}Robloxã«é–¢ã™ã‚‹å…¨èˆ¬çš„ãªã‚µãƒãƒ¼ãƒˆ{aTagEnd}{lineBreak}{lineBreak}ã‚ˆã‚ã—ããŠé¡˜ã„ã„ãŸã—ã¾ã™ã€‚{lineBreak}{lineBreak}Robloxãƒãƒ¼ãƒ ";
	}

	protected override string _GetTemplateForDescriptionTwoStepVerificationLoginEmailHtmlBody()
	{
		return "{geoLocationInformation}{spanStartTagWithBold}ã®ãƒ­ã‚°ã‚¤ãƒ³ã‚³ãƒ¼ãƒ‰{accountName}: {lineBreak}{lineBreak}{code}{spanEndTag}{lineBreak}{lineBreak}ã“ã®ã‚³ãƒ¼ãƒ‰ã‚’2æ®µéšŽèªè¨¼ç”»é¢ã«å…¥åŠ›ã™ã‚Œã°ãƒ­ã‚°ã‚¤ãƒ³ãŒå®Œäº†ã—ã¾ã™ã€‚ã‚³ãƒ¼ãƒ‰ã¯15åˆ†å¾Œã«æœŸé™åˆ‡ã‚Œã«ãªã‚Šã¾ã™ã€‚{lineBreak}{lineBreak}ã‚¢ã‚«ã‚¦ãƒ³ãƒˆãŒæ–°ã—ã„ãƒ–ãƒ©ã‚¦ã‚¶ã€ã¾ãŸã¯ãƒ‡ãƒã‚¤ã‚¹ã‹ã‚‰ã®Robloxã¸ã®ãƒ­ã‚°ã‚¤ãƒ³ã«ä½¿ç”¨ã•ã‚ŒãŸãŸã‚ã€ã“ã®ãƒ¡ãƒ¼ãƒ«ã‚’ãŠé€ã‚Šã—ã¦ã„ã¾ã™ã€‚Robloxã«ãƒ­ã‚°ã‚¤ãƒ³ã—ã‚ˆã†ã¨ã—ã¦ã„ãªã„å ´åˆã¯ã‚¢ã‚«ã‚¦ãƒ³ãƒˆã¯ä¸æ­£ã‚¢ã‚¯ã‚»ã‚¹ã•ã‚Œã¦ã„ã‚‹å¯èƒ½æ€§ãŒã‚ã‚Šã¾ã™ã€‚ã“ã®ãƒªã‚¯ã‚¨ã‚¹ãƒˆã«è¦šãˆãŒå ´åˆã¯ãƒ‘ã‚¹ãƒ¯ãƒ¼ãƒ‰ã‚’å¤‰æ›´ã™ã‚‹ã“ã¨ã‚’å¼·ããŠã™ã™ã‚ã—ã¾ã™ã€‚{lineBreak}{lineBreak}ãƒªã‚½ãƒ¼ã‚¹: {lineBreak}{aTagStartWithHref}{ChangePasswordLink}{hrefEnd}ãƒ‘ã‚¹ãƒ¯ãƒ¼ãƒ‰ã®å¤‰æ›´{aTagEnd}{lineBreak}{aTagStartWithHref}{TwoStepVerificationArticleLink}{hrefEnd}2æ®µéšŽèªè¨¼ã«ã¤ã„ã¦ {aTagEnd}{lineBreak}{aTagStartWithHref}{AccountSafetyArticleLink}{hrefEnd}ã‚¢ã‚«ã‚¦ãƒ³ãƒˆã‚’å®‰å…¨ã«ä¿ã¡ç¶šã‘ã¾ã—ã‚‡ã† {aTagEnd}{lineBreak}{aTagStartWithHref}{SupportLink}{hrefEnd}Robloxã«é–¢ã™ã‚‹å…¨èˆ¬çš„ãªã‚µãƒãƒ¼ãƒˆ{aTagEnd}{lineBreak}{lineBreak}ã‚ˆã‚ã—ããŠé¡˜ã„ã„ãŸã—ã¾ã™ã€‚{lineBreak}{lineBreak}Robloxãƒãƒ¼ãƒ ";
	}

	/// <summary>
	/// Key: "Description.TwoStepVerificationLoginEmail.PlainBody"
	/// Plain body for 2SV login email
	/// English String: "{geoLocationInformation}Login code for {accountName}: {lineBreak}{lineBreak} {code} {lineBreak}{lineBreak}Enter this code into the 2-Step Verification screen to finish logging in. This code will expire in 15 minutes. {lineBreak}{lineBreak}This email was sent because your account tried to login to Roblox from a new browser or device. If you haven't tried logging into Roblox, someone else may be trying to access your account. You are strongly advised to change your password if you did not generate this request. {lineBreak}{lineBreak}Resources: {lineBreak}Change Your Password [{accountInfoPageLink}] {lineBreak}Learn More About 2-Step Verification [{twoStepVerificationHelpArticleLink}]{lineBreak}Keeping Your Account Safe [{keepAccountSafeArticleLink}] {lineBreak}General Roblox Support [{supportPageLink}] {lineBreak}{lineBreak}Thank you, {lineBreak}{lineBreak}The Roblox Team"
	/// </summary>
	public override string DescriptionTwoStepVerificationLoginEmailPlainBody(string geoLocationInformation, string accountName, string lineBreak, string code, string accountInfoPageLink, string twoStepVerificationHelpArticleLink, string keepAccountSafeArticleLink, string supportPageLink)
	{
		return $"{geoLocationInformation}{accountName}ã®ãƒ­ã‚°ã‚¤ãƒ³ã‚³ãƒ¼ãƒ‰: {lineBreak}{lineBreak}{code}{lineBreak}{lineBreak}ã“ã®ã‚³ãƒ¼ãƒ‰ã‚’2æ®µéšŽèªè¨¼ç”»é¢ã«å…¥åŠ›ã™ã‚Œã°ãƒ­ã‚°ã‚¤ãƒ³ãŒå®Œäº†ã—ã¾ã™ã€‚ã‚³ãƒ¼ãƒ‰ã¯15åˆ†å¾Œã«æœŸé™åˆ‡ã‚Œã«ãªã‚Šã¾ã™ã€‚{lineBreak}{lineBreak}ã‚¢ã‚«ã‚¦ãƒ³ãƒˆãŒæ–°ã—ã„ãƒ–ãƒ©ã‚¦ã‚¶ã€ã¾ãŸã¯ãƒ‡ãƒã‚¤ã‚¹ã‹ã‚‰ã®Robloxã¸ã®ãƒ­ã‚°ã‚¤ãƒ³ã«ä½¿ç”¨ã•ã‚ŒãŸãŸã‚ã€ã“ã®ãƒ¡ãƒ¼ãƒ«ã‚’ãŠé€ã‚Šã—ã¦ã„ã¾ã™ã€‚Robloxã«ãƒ­ã‚°ã‚¤ãƒ³ã—ã‚ˆã†ã¨ã—ã¦ã„ãªã„å ´åˆã¯ã‚¢ã‚«ã‚¦ãƒ³ãƒˆãŒä¸æ­£ã«ã‚¢ã‚¯ã‚»ã‚¹ã•ã‚Œã¦ã„ã‚‹å¯èƒ½æ€§ãŒã‚ã‚Šã¾ã™ã€‚ã“ã®ãƒªã‚¯ã‚¨ã‚¹ãƒˆã«è¦šãˆãŒãªã„å ´åˆã¯ãƒ‘ã‚¹ãƒ¯ãƒ¼ãƒ‰ã‚’å¤‰æ›´ã™ã‚‹ã“ã¨ã‚’å¼·ããŠã™ã™ã‚ã—ã¾ã™ã€‚{lineBreak}{lineBreak}ãƒªã‚½ãƒ¼ã‚¹: {lineBreak}ãƒ‘ã‚¹ãƒ¯ãƒ¼ãƒ‰ã®å¤‰æ›´ [{accountInfoPageLink}] {lineBreak}2æ®µéšŽèªè¨¼ã«ã¤ã„ã¦ [{twoStepVerificationHelpArticleLink}]{lineBreak}ã‚¢ã‚«ã‚¦ãƒ³ãƒˆã‚’å®‰å…¨ã«ä¿ã¡ç¶šã‘ã¾ã—ã‚‡ã† [{keepAccountSafeArticleLink}] {lineBreak}Robloxã«é–¢ã™ã‚‹å…¨èˆ¬çš„ãªã‚µãƒãƒ¼ãƒˆ [{supportPageLink}] {lineBreak}{lineBreak}ã‚ˆã‚ã—ããŠé¡˜ã„ã„ãŸã—ã¾ã™ã€‚{lineBreak}{lineBreak}Robloxãƒãƒ¼ãƒ ";
	}

	protected override string _GetTemplateForDescriptionTwoStepVerificationLoginEmailPlainBody()
	{
		return "{geoLocationInformation}{accountName}ã®ãƒ­ã‚°ã‚¤ãƒ³ã‚³ãƒ¼ãƒ‰: {lineBreak}{lineBreak}{code}{lineBreak}{lineBreak}ã“ã®ã‚³ãƒ¼ãƒ‰ã‚’2æ®µéšŽèªè¨¼ç”»é¢ã«å…¥åŠ›ã™ã‚Œã°ãƒ­ã‚°ã‚¤ãƒ³ãŒå®Œäº†ã—ã¾ã™ã€‚ã‚³ãƒ¼ãƒ‰ã¯15åˆ†å¾Œã«æœŸé™åˆ‡ã‚Œã«ãªã‚Šã¾ã™ã€‚{lineBreak}{lineBreak}ã‚¢ã‚«ã‚¦ãƒ³ãƒˆãŒæ–°ã—ã„ãƒ–ãƒ©ã‚¦ã‚¶ã€ã¾ãŸã¯ãƒ‡ãƒã‚¤ã‚¹ã‹ã‚‰ã®Robloxã¸ã®ãƒ­ã‚°ã‚¤ãƒ³ã«ä½¿ç”¨ã•ã‚ŒãŸãŸã‚ã€ã“ã®ãƒ¡ãƒ¼ãƒ«ã‚’ãŠé€ã‚Šã—ã¦ã„ã¾ã™ã€‚Robloxã«ãƒ­ã‚°ã‚¤ãƒ³ã—ã‚ˆã†ã¨ã—ã¦ã„ãªã„å ´åˆã¯ã‚¢ã‚«ã‚¦ãƒ³ãƒˆãŒä¸æ­£ã«ã‚¢ã‚¯ã‚»ã‚¹ã•ã‚Œã¦ã„ã‚‹å¯èƒ½æ€§ãŒã‚ã‚Šã¾ã™ã€‚ã“ã®ãƒªã‚¯ã‚¨ã‚¹ãƒˆã«è¦šãˆãŒãªã„å ´åˆã¯ãƒ‘ã‚¹ãƒ¯ãƒ¼ãƒ‰ã‚’å¤‰æ›´ã™ã‚‹ã“ã¨ã‚’å¼·ããŠã™ã™ã‚ã—ã¾ã™ã€‚{lineBreak}{lineBreak}ãƒªã‚½ãƒ¼ã‚¹: {lineBreak}ãƒ‘ã‚¹ãƒ¯ãƒ¼ãƒ‰ã®å¤‰æ›´ [{accountInfoPageLink}] {lineBreak}2æ®µéšŽèªè¨¼ã«ã¤ã„ã¦ [{twoStepVerificationHelpArticleLink}]{lineBreak}ã‚¢ã‚«ã‚¦ãƒ³ãƒˆã‚’å®‰å…¨ã«ä¿ã¡ç¶šã‘ã¾ã—ã‚‡ã† [{keepAccountSafeArticleLink}] {lineBreak}Robloxã«é–¢ã™ã‚‹å…¨èˆ¬çš„ãªã‚µãƒãƒ¼ãƒˆ [{supportPageLink}] {lineBreak}{lineBreak}ã‚ˆã‚ã—ããŠé¡˜ã„ã„ãŸã—ã¾ã™ã€‚{lineBreak}{lineBreak}Robloxãƒãƒ¼ãƒ ";
	}

	/// <summary>
	/// Key: "Description.TwoStepVerificationLoginEmail.PlainText.GeolocationInfo1"
	/// GeoLocation info of IP trying to login
	/// English String: "Login request received from {username} located in {region}, {country} ({ipAddress}).{lineBreak}{lineBreak}"
	/// </summary>
	public override string DescriptionTwoStepVerificationLoginEmailPlainTextGeolocationInfo1(string username, string region, string country, string ipAddress, string lineBreak)
	{
		return $" {country}ã®{region} ({ipAddress})ã«å±…ä½ã™ã‚‹{username} ã‹ã‚‰ãƒ­ã‚°ã‚¤ãƒ³ãƒªã‚¯ã‚¨ã‚¹ãƒˆã‚’å—ã‘ã¾ã—ãŸã€‚{lineBreak}{lineBreak}";
	}

	protected override string _GetTemplateForDescriptionTwoStepVerificationLoginEmailPlainTextGeolocationInfo1()
	{
		return " {country}ã®{region} ({ipAddress})ã«å±…ä½ã™ã‚‹{username} ã‹ã‚‰ãƒ­ã‚°ã‚¤ãƒ³ãƒªã‚¯ã‚¨ã‚¹ãƒˆã‚’å—ã‘ã¾ã—ãŸã€‚{lineBreak}{lineBreak}";
	}

	/// <summary>
	/// Key: "Description.TwoStepVerificationLoginEmail.PlainText.GeolocationInfo2"
	/// Geolocation info of IP trying to login
	/// English String: "Login request received from {username} located in {country} ({ipAddress}).{lineBreak}{lineBreak}"
	/// </summary>
	public override string DescriptionTwoStepVerificationLoginEmailPlainTextGeolocationInfo2(string username, string country, string ipAddress, string lineBreak)
	{
		return $"({ipAddress})ã®{country}ã«å±…ä½ã™ã‚‹{username} ã‹ã‚‰ãƒ­ã‚°ã‚¤ãƒ³ãƒªã‚¯ã‚¨ã‚¹ãƒˆã‚’å—ã‘ã¾ã—ãŸã€‚{lineBreak}{lineBreak}";
	}

	protected override string _GetTemplateForDescriptionTwoStepVerificationLoginEmailPlainTextGeolocationInfo2()
	{
		return "({ipAddress})ã®{country}ã«å±…ä½ã™ã‚‹{username} ã‹ã‚‰ãƒ­ã‚°ã‚¤ãƒ³ãƒªã‚¯ã‚¨ã‚¹ãƒˆã‚’å—ã‘ã¾ã—ãŸã€‚{lineBreak}{lineBreak}";
	}

	/// <summary>
	/// Key: "Description.TwoStepVerificationLoginEmail.PlainText.GeolocationInfo3"
	/// Geolocation info of IP trying to login
	/// English String: "Login request received from {username} (From Roblox Internal).{lineBreak}{lineBreak}"
	/// </summary>
	public override string DescriptionTwoStepVerificationLoginEmailPlainTextGeolocationInfo3(string username, string lineBreak)
	{
		return $"{username} (Robloxå†…éƒ¨)ã‹ã‚‰ãƒ­ã‚°ã‚¤ãƒ³ãƒªã‚¯ã‚¨ã‚¹ãƒˆã‚’å—ã‘ã¾ã—ãŸã€‚{lineBreak}{lineBreak}";
	}

	protected override string _GetTemplateForDescriptionTwoStepVerificationLoginEmailPlainTextGeolocationInfo3()
	{
		return "{username} (Robloxå†…éƒ¨)ã‹ã‚‰ãƒ­ã‚°ã‚¤ãƒ³ãƒªã‚¯ã‚¨ã‚¹ãƒˆã‚’å—ã‘ã¾ã—ãŸã€‚{lineBreak}{lineBreak}";
	}

	/// <summary>
	/// Key: "Description.TwoStepVerificationLoginEmail.PlainText.GeolocationInfo4"
	/// Geolocation info of IP trying to login
	/// English String: "Login request received from {username} located in {country}.{lineBreak}{lineBreak}"
	/// </summary>
	public override string DescriptionTwoStepVerificationLoginEmailPlainTextGeolocationInfo4(string username, string country, string lineBreak)
	{
		return $"{country}ã«å±…ä½ã™ã‚‹{username} ã‹ã‚‰ãƒ­ã‚°ã‚¤ãƒ³ãƒªã‚¯ã‚¨ã‚¹ãƒˆã‚’å—ã‘ã¾ã—ãŸã€‚{lineBreak}{lineBreak}";
	}

	protected override string _GetTemplateForDescriptionTwoStepVerificationLoginEmailPlainTextGeolocationInfo4()
	{
		return "{country}ã«å±…ä½ã™ã‚‹{username} ã‹ã‚‰ãƒ­ã‚°ã‚¤ãƒ³ãƒªã‚¯ã‚¨ã‚¹ãƒˆã‚’å—ã‘ã¾ã—ãŸã€‚{lineBreak}{lineBreak}";
	}

	/// <summary>
	/// Key: "Description.TwoStepVerificationLoginEmail.PlainText.GeolocationInfo5"
	/// Geolocation info of IP trying to login
	/// English String: "Login request received from {username} located in {region}, {country}.{lineBreak}{lineBreak}"
	/// </summary>
	public override string DescriptionTwoStepVerificationLoginEmailPlainTextGeolocationInfo5(string username, string region, string country, string lineBreak)
	{
		return $"{country}ã€{region}ã«å±…ä½ã™ã‚‹{username} ã‹ã‚‰ãƒ­ã‚°ã‚¤ãƒ³ãƒªã‚¯ã‚¨ã‚¹ãƒˆã‚’å—ã‘ã¾ã—ãŸã€‚{lineBreak}{lineBreak}";
	}

	protected override string _GetTemplateForDescriptionTwoStepVerificationLoginEmailPlainTextGeolocationInfo5()
	{
		return "{country}ã€{region}ã«å±…ä½ã™ã‚‹{username} ã‹ã‚‰ãƒ­ã‚°ã‚¤ãƒ³ãƒªã‚¯ã‚¨ã‚¹ãƒˆã‚’å—ã‘ã¾ã—ãŸã€‚{lineBreak}{lineBreak}";
	}

	/// <summary>
	/// Key: "Description.TwoStepVerificationLoginEmail.PlainText.GeolocationInfo6"
	/// Geolocation info of IP trying to login
	/// English String: "Login request received from {username} located in {city}, {region}, {country}.{lineBreak}{lineBreak}"
	/// </summary>
	public override string DescriptionTwoStepVerificationLoginEmailPlainTextGeolocationInfo6(string username, string city, string region, string country, string lineBreak)
	{
		return $"{country}ã€{region}ã€{city}ã«å±…ä½ã™ã‚‹{username} ã‹ã‚‰ãƒ­ã‚°ã‚¤ãƒ³ãƒªã‚¯ã‚¨ã‚¹ãƒˆã‚’å—ã‘ã¾ã—ãŸã€‚{lineBreak}{lineBreak}";
	}

	protected override string _GetTemplateForDescriptionTwoStepVerificationLoginEmailPlainTextGeolocationInfo6()
	{
		return "{country}ã€{region}ã€{city}ã«å±…ä½ã™ã‚‹{username} ã‹ã‚‰ãƒ­ã‚°ã‚¤ãƒ³ãƒªã‚¯ã‚¨ã‚¹ãƒˆã‚’å—ã‘ã¾ã—ãŸã€‚{lineBreak}{lineBreak}";
	}

	/// <summary>
	/// Key: "Description.TwoStepVerificationLoginEmail.Subject"
	/// Subject for 2SV login email
	/// English String: "Verification Code for Roblox Account: {accountName}"
	/// </summary>
	public override string DescriptionTwoStepVerificationLoginEmailSubject(string accountName)
	{
		return $"Robloxã‚¢ã‚«ã‚¦ãƒ³ãƒˆã®èªè¨¼ã‚³ãƒ¼ãƒ‰: {accountName}";
	}

	protected override string _GetTemplateForDescriptionTwoStepVerificationLoginEmailSubject()
	{
		return "Robloxã‚¢ã‚«ã‚¦ãƒ³ãƒˆã®èªè¨¼ã‚³ãƒ¼ãƒ‰: {accountName}";
	}

	protected override string _GetTemplateForLabelCode()
	{
		return "ã‚³ãƒ¼ãƒ‰";
	}

	/// <summary>
	/// Key: "Label.CodeInputPlaceholderText"
	/// example: Enter 4-digit code
	/// English String: "Enter {codeLength}-digit Code"
	/// </summary>
	public override string LabelCodeInputPlaceholderText(string codeLength)
	{
		return $"{codeLength}æ¡ã®ã‚³ãƒ¼ãƒ‰ã‚’å…¥åŠ›ã—ã¦ãã ã•ã„";
	}

	protected override string _GetTemplateForLabelCodeInputPlaceholderText()
	{
		return "{codeLength}æ¡ã®ã‚³ãƒ¼ãƒ‰ã‚’å…¥åŠ›ã—ã¦ãã ã•ã„";
	}

	protected override string _GetTemplateForLabelDidNotReceive()
	{
		return "ã‚³ãƒ¼ãƒ‰ã‚’å—ã‘å–ã‚Šã¾ã›ã‚“ã§ã—ãŸã‹ï¼Ÿ";
	}

	protected override string _GetTemplateForLabelEnterCode()
	{
		return "ã‚³ãƒ¼ãƒ‰ã‚’å…¥åŠ› (6æ¡)";
	}

	protected override string _GetTemplateForLabelEnterEmailCode()
	{
		return "ä»Šãƒ¡ãƒ¼ãƒ«ã§é€ä¿¡ã—ãŸã‚³ãƒ¼ãƒ‰ã‚’å…¥åŠ›ã—ã¦ãã ã•ã„";
	}

	protected override string _GetTemplateForLabelEnterTextCode()
	{
		return "ä»Šãƒ†ã‚­ã‚¹ãƒˆãƒ¡ãƒƒã‚»ãƒ¼ã‚¸ã§é€ä¿¡ã—ãŸã‚³ãƒ¼ãƒ‰ã‚’å…¥åŠ›ã—ã¦ãã ã•ã„";
	}

	protected override string _GetTemplateForLabelEnterTwoStepVerificationCode()
	{
		return "äºŒæ®µéšŽèªè¨¼ã‚³ãƒ¼ãƒ‰ã‚’å…¥åŠ›ã—ã¦ãã ã•ã„ã€‚";
	}

	protected override string _GetTemplateForLabelFacebookPasswordWarning()
	{
		return "Facebookã§ã‚µã‚¤ãƒ³ã‚¤ãƒ³ã—ã¦ã„ã‚‹å ´åˆã«ã¯ã€ãƒ‘ã‚¹ãƒ¯ãƒ¼ãƒ‰ã®è¨­å®šãŒå¿…è¦ã§ã™ã€‚";
	}

	protected override string _GetTemplateForLabelLearnMore()
	{
		return "è©³ã—ãçŸ¥ã‚‹";
	}

	/// <summary>
	/// Key: "Label.NeedHelpContactSupport"
	/// label for the support article link
	/// English String: "Need help? Contact {supportLink}"
	/// </summary>
	public override string LabelNeedHelpContactSupport(string supportLink)
	{
		return $"ãƒ˜ãƒ«ãƒ—ãŒå¿…è¦ã§ã™ã‹ï¼Ÿ{supportLink}ã¾ã§ãŠå•ã„åˆã‚ã›ãã ã•ã„";
	}

	protected override string _GetTemplateForLabelNeedHelpContactSupport()
	{
		return "ãƒ˜ãƒ«ãƒ—ãŒå¿…è¦ã§ã™ã‹ï¼Ÿ{supportLink}ã¾ã§ãŠå•ã„åˆã‚ã›ãã ã•ã„";
	}

	protected override string _GetTemplateForLabelNewCode()
	{
		return "æ–°ã—ã„ã‚³ãƒ¼ãƒ‰";
	}

	protected override string _GetTemplateForLabelRobloxSupport()
	{
		return "Robloxã‚µãƒãƒ¼ãƒˆ";
	}

	protected override string _GetTemplateForLabelTrustThisDevice()
	{
		return "ã“ã®ãƒ‡ãƒã‚¤ã‚¹ã‚’30æ—¥é–“ä¿¡é ¼ã™ã‚‹";
	}

	protected override string _GetTemplateForLabelTwoStepVerification()
	{
		return "2æ®µéšŽèªè¨¼";
	}

	protected override string _GetTemplateForResponseCodeSent()
	{
		return "ã‚³ãƒ¼ãƒ‰ãŒé€ä¿¡ã•ã‚Œã¾ã—ãŸ";
	}

	protected override string _GetTemplateForResponseFeatureNotAvailable()
	{
		return "æ©Ÿèƒ½ãŒåˆ©ç”¨ã§ãã¾ã›ã‚“ã€‚ã‚µãƒãƒ¼ãƒˆã¾ã§ã”é€£çµ¡ãã ã•ã„ã€‚";
	}

	protected override string _GetTemplateForResponseInvalidCode()
	{
		return "ç„¡åŠ¹ãªã‚³ãƒ¼ãƒ‰ã€‚";
	}

	protected override string _GetTemplateForResponseSystemErrorReturnToLogin()
	{
		return "ã‚·ã‚¹ãƒ†ãƒ ã‚¨ãƒ©ãƒ¼ã€‚ãƒ­ã‚°ã‚¤ãƒ³ç”»é¢ã«ãŠæˆ»ã‚Šãã ã•ã„ã€‚";
	}

	protected override string _GetTemplateForResponseTooManyAttempts()
	{
		return "è©¦è¡Œå›žæ•°ãŒå¤šã™ãŽã¾ã™ã€‚ã—ã°ã‚‰ãã—ã¦ã‹ã‚‰ã‚„ã‚Šç›´ã—ã¦ãã ã•ã„ã€‚";
	}

	protected override string _GetTemplateForResponseTooManyCharacters()
	{
		return "æ–‡å­—æ•°ãŒå¤šã™ãŽã¾ã™";
	}
}


}
