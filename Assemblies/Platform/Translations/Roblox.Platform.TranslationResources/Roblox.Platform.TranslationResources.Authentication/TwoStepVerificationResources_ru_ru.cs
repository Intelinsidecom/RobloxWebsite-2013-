namespace Roblox.Platform.TranslationResources.Authentication {
    /// <summary>

/// This class overrides TwoStepVerificationResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class TwoStepVerificationResources_ru_ru : TwoStepVerificationResources_en_us, ITwoStepVerificationResources, ITranslationResources
{
	/// <summary>
	/// Key: "Action.Cancel"
	/// English String: "Cancel"
	/// </summary>
	public override string ActionCancel => "ÐžÑ‚Ð¼ÐµÐ½Ð°";

	/// <summary>
	/// Key: "Action.Resend"
	/// English String: "Resend Code"
	/// </summary>
	public override string ActionResend => "ÐžÑ‚Ð¿Ñ€Ð°Ð²Ð¸Ñ‚ÑŒ ÐºÐ¾Ð´ Ð·Ð°Ð½Ð¾Ð²Ð¾";

	/// <summary>
	/// Key: "Action.StartOver"
	/// link text to restart verification
	/// English String: "Start Over"
	/// </summary>
	public override string ActionStartOver => "ÐÐ°Ñ‡Ð°Ñ‚ÑŒ Ð·Ð°Ð½Ð¾Ð²Ð¾";

	/// <summary>
	/// Key: "Action.Submit"
	/// submit button text
	/// English String: "Submit"
	/// </summary>
	public override string ActionSubmit => "ÐžÑ‚Ð¿Ñ€Ð°Ð²Ð¸Ñ‚ÑŒ";

	/// <summary>
	/// Key: "Action.Verify"
	/// English String: "Verify"
	/// </summary>
	public override string ActionVerify => "ÐŸÑ€Ð¾Ð²ÐµÑ€Ð¸Ñ‚ÑŒ";

	/// <summary>
	/// Key: "Label.Code"
	/// verification code for 2 factor authentication
	/// English String: "Code"
	/// </summary>
	public override string LabelCode => "ÐšÐ¾Ð´";

	/// <summary>
	/// Key: "Label.DidNotReceive"
	/// English String: "Didn't receive the code?"
	/// </summary>
	public override string LabelDidNotReceive => "ÐÐµ Ð¿Ð¾Ð»ÑƒÑ‡Ð¸Ð»Ð¸ ÐºÐ¾Ð´?";

	/// <summary>
	/// Key: "Label.EnterCode"
	/// English String: "Enter Code (6-digit)"
	/// </summary>
	public override string LabelEnterCode => "Ð’Ð²ÐµÐ´Ð¸Ñ‚Ðµ ÐºÐ¾Ð´ (6 Ñ†Ð¸Ñ„Ñ€)";

	/// <summary>
	/// Key: "Label.EnterEmailCode"
	/// English String: "Enter the code we just sent you via email"
	/// </summary>
	public override string LabelEnterEmailCode => "Ð’Ð²ÐµÐ´Ð¸Ñ‚Ðµ ÐºÐ¾Ð´, Ð¾Ñ‚Ð¿Ñ€Ð°Ð²Ð»ÐµÐ½Ð½Ñ‹Ð¹ Ð²Ð°Ð¼ Ð¿Ð¾ ÑÐ»ÐµÐºÑ‚Ñ€Ð¾Ð½Ð½Ð¾Ð¹ Ð¿Ð¾Ñ‡Ñ‚Ðµ";

	/// <summary>
	/// Key: "Label.EnterTextCode"
	/// English String: "Enter the code we just sent you via text message"
	/// </summary>
	public override string LabelEnterTextCode => "Ð’Ð²ÐµÐ´Ð¸Ñ‚Ðµ ÐºÐ¾Ð´, Ð¾Ñ‚Ð¿Ñ€Ð°Ð²Ð»ÐµÐ½Ð½Ñ‹Ð¹ Ð²Ð°Ð¼ Ð² ÑÐ¾Ð¾Ð±Ñ‰ÐµÐ½Ð¸Ð¸";

	/// <summary>
	/// Key: "Label.EnterTwoStepVerificationCode"
	/// Enter your two step verification code.
	/// English String: "Enter your two step verification code."
	/// </summary>
	public override string LabelEnterTwoStepVerificationCode => "Ð’Ð²ÐµÐ´Ð¸Ñ‚Ðµ ÐºÐ¾Ð´ Ð´Ð²ÑƒÑ…ÑÑ‚Ð°Ð¿Ð½Ð¾Ð¹ Ð¸Ð´ÐµÐ½Ñ‚Ð¸Ñ„Ð¸ÐºÐ°Ñ†Ð¸Ð¸.";

	/// <summary>
	/// Key: "Label.FacebookPasswordWarning"
	/// If you have been signing in with Facebook, you must set a password.
	/// English String: "If you have been signing in with Facebook, you must set a password."
	/// </summary>
	public override string LabelFacebookPasswordWarning => "Ð•ÑÐ»Ð¸ Ð²Ñ‹ Ð¸ÑÐ¿Ð¾Ð»ÑŒÐ·Ð¾Ð²Ð°Ð»Ð¸ ÑƒÑ‡ÐµÑ‚Ð½ÑƒÑŽ Ð·Ð°Ð¿Ð¸ÑÑŒ Facebook, Ð½ÐµÐ¾Ð±Ñ…Ð¾Ð´Ð¸Ð¼Ð¾ ÑƒÐºÐ°Ð·Ð°Ñ‚ÑŒ Ð¿Ð°Ñ€Ð¾Ð»ÑŒ.";

	/// <summary>
	/// Key: "Label.LearnMore"
	/// Learn More link text
	/// English String: "Learn More"
	/// </summary>
	public override string LabelLearnMore => "ÐŸÐ¾Ð´Ñ€Ð¾Ð±Ð½ÐµÐµ";

	/// <summary>
	/// Key: "Label.NewCode"
	/// verification code resent, label changes to new code
	/// English String: "New Code"
	/// </summary>
	public override string LabelNewCode => "ÐÐ¾Ð²Ñ‹Ð¹ ÐºÐ¾Ð´";

	/// <summary>
	/// Key: "Label.RobloxSupport"
	/// English String: "Roblox Support"
	/// </summary>
	public override string LabelRobloxSupport => "Ð¡Ð»ÑƒÐ¶Ð±Ð° Ð¿Ð¾Ð´Ð´ÐµÑ€Ð¶ÐºÐ¸ Roblox";

	/// <summary>
	/// Key: "Label.TrustThisDevice"
	/// English String: "Trust this device for 30 days"
	/// </summary>
	public override string LabelTrustThisDevice => "Ð¡Ñ‡Ð¸Ñ‚Ð°Ñ‚ÑŒ ÑƒÑÑ‚Ñ€Ð¾Ð¹ÑÑ‚Ð²Ð¾ Ð¿Ñ€Ð¾Ð²ÐµÑ€ÐµÐ½Ð½Ñ‹Ð¼ 30 Ð´Ð½ÐµÐ¹";

	/// <summary>
	/// Key: "Label.TwoStepVerification"
	/// English String: "2-Step Verification"
	/// </summary>
	public override string LabelTwoStepVerification => "Ð”Ð²ÑƒÑ…ÑÑ‚Ð°Ð¿Ð½Ð°Ñ Ð¿Ñ€Ð¾Ð²ÐµÑ€ÐºÐ°";

	/// <summary>
	/// Key: "Response.CodeSent"
	/// English String: "Code Sent"
	/// </summary>
	public override string ResponseCodeSent => "ÐšÐ¾Ð´ Ð¾Ñ‚Ð¿Ñ€Ð°Ð²Ð»ÐµÐ½";

	/// <summary>
	/// Key: "Response.FeatureNotAvailable"
	/// English String: "Feature not available. Please contact support."
	/// </summary>
	public override string ResponseFeatureNotAvailable => "Ð¤ÑƒÐ½ÐºÑ†Ð¸Ñ Ð½ÐµÐ´Ð¾ÑÑ‚ÑƒÐ¿Ð½Ð°. ÐžÐ±Ñ€Ð°Ñ‚Ð¸Ñ‚ÐµÑÑŒ Ð² ÑÐ»ÑƒÐ¶Ð±Ñƒ Ð¿Ð¾Ð´Ð´ÐµÑ€Ð¶ÐºÐ¸.";

	/// <summary>
	/// Key: "Response.InvalidCode"
	/// English String: "Invalid code."
	/// </summary>
	public override string ResponseInvalidCode => "ÐÐµÐ´Ð¾Ð¿ÑƒÑÑ‚Ð¸Ð¼Ñ‹Ð¹ ÐºÐ¾Ð´";

	/// <summary>
	/// Key: "Response.SystemErrorReturnToLogin"
	/// English String: "System error. Please return to login screen."
	/// </summary>
	public override string ResponseSystemErrorReturnToLogin => "ÐžÑˆÐ¸Ð±ÐºÐ° ÑÐ¸ÑÑ‚ÐµÐ¼Ñ‹. Ð’ÐµÑ€Ð½Ð¸Ñ‚ÐµÑÑŒ Ð½Ð° ÑÐºÑ€Ð°Ð½ Ð²Ñ…Ð¾Ð´Ð°.";

	/// <summary>
	/// Key: "Response.TooManyAttempts"
	/// English String: "Too many attempts. Please try again later."
	/// </summary>
	public override string ResponseTooManyAttempts => "Ð¡Ð»Ð¸ÑˆÐºÐ¾Ð¼ Ð¼Ð½Ð¾Ð³Ð¾ Ð¿Ð¾Ð¿Ñ‹Ñ‚Ð¾Ðº. ÐŸÐ¾Ð²Ñ‚Ð¾Ñ€Ð¸Ñ‚Ðµ Ð¿Ð¾Ð¿Ñ‹Ñ‚ÐºÑƒ Ð¿Ð¾Ð·Ð¶Ðµ.";

	/// <summary>
	/// Key: "Response.TooManyCharacters"
	/// error message
	/// English String: "Too many characters"
	/// </summary>
	public override string ResponseTooManyCharacters => "Ð¡Ð»Ð¸ÑˆÐºÐ¾Ð¼ Ð¼Ð½Ð¾Ð³Ð¾ ÑÐ¸Ð¼Ð²Ð¾Ð»Ð¾Ð²";

	public TwoStepVerificationResources_ru_ru(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionCancel()
	{
		return "ÐžÑ‚Ð¼ÐµÐ½Ð°";
	}

	protected override string _GetTemplateForActionResend()
	{
		return "ÐžÑ‚Ð¿Ñ€Ð°Ð²Ð¸Ñ‚ÑŒ ÐºÐ¾Ð´ Ð·Ð°Ð½Ð¾Ð²Ð¾";
	}

	protected override string _GetTemplateForActionStartOver()
	{
		return "ÐÐ°Ñ‡Ð°Ñ‚ÑŒ Ð·Ð°Ð½Ð¾Ð²Ð¾";
	}

	protected override string _GetTemplateForActionSubmit()
	{
		return "ÐžÑ‚Ð¿Ñ€Ð°Ð²Ð¸Ñ‚ÑŒ";
	}

	protected override string _GetTemplateForActionVerify()
	{
		return "ÐŸÑ€Ð¾Ð²ÐµÑ€Ð¸Ñ‚ÑŒ";
	}

	/// <summary>
	/// Key: "Description.TwoStepVerificationActivationEmail.Body.Over13"
	/// Body for 2SV activation email for over 13 users
	/// English String: "Hi {accountName},{lineBreak}{lineBreak}You have activated 2-Step Verification for your Roblox account. Next time you log in from a new device, you will need to enter a 6-digit security code that Roblox sends to you via email.{lineBreak}{lineBreak}Roblox"
	/// </summary>
	public override string DescriptionTwoStepVerificationActivationEmailBodyOver13(string accountName, string lineBreak)
	{
		return $"ÐŸÑ€Ð¸Ð²ÐµÑ‚, {accountName},{lineBreak}{lineBreak}Ð’Ñ‹ Ð°ÐºÑ‚Ð¸Ð²Ð¸Ñ€Ð¾Ð²Ð°Ð»Ð¸ Ð´Ð²ÑƒÑ…ÑÑ‚Ð°Ð¿Ð½ÑƒÑŽ Ð¿Ñ€Ð¾Ð²ÐµÑ€ÐºÑƒ Ð´Ð»Ñ Ð²Ð°ÑˆÐµÐ¹ ÑƒÑ‡ÐµÑ‚Ð½Ð¾Ð¹ Ð·Ð°Ð¿Ð¸ÑÐ¸ Roblox. Ð’ ÑÐ»ÐµÐ´ÑƒÑŽÑ‰Ð¸Ð¹ Ñ€Ð°Ð·, ÐºÐ¾Ð³Ð´Ð° Ð²Ñ‹ Ð²Ð¾Ð¹Ð´ÐµÑ‚Ðµ Ñ Ð½Ð¾Ð²Ð¾Ð³Ð¾ ÑƒÑÑ‚Ñ€Ð¾Ð¹ÑÑ‚Ð²Ð°, Ð²Ð°Ð¼ Ð±ÑƒÐ´ÐµÑ‚ Ð½ÑƒÐ¶Ð½Ð¾ Ð²Ð²ÐµÑÑ‚Ð¸ ÑˆÐµÑÑ‚Ð¸Ð·Ð½Ð°Ñ‡Ð½Ñ‹Ð¹ ÐºÐ¾Ð´ Ð±ÐµÐ·Ð¾Ð¿Ð°ÑÐ½Ð¾ÑÑ‚Ð¸, ÐºÐ¾Ñ‚Ð¾Ñ€Ñ‹Ð¹ Ð±ÑƒÑ‚ÐµÑ‚ Ð¾Ñ‚Ð¿Ñ€Ð°Ð²Ð»ÐµÐ½ Ð²Ð°Ð¼ Ð¿Ð¾ ÑÐ». Ð¿Ð¾Ñ‡Ñ‚Ðµ.{lineBreak}{lineBreak}Roblox";
	}

	protected override string _GetTemplateForDescriptionTwoStepVerificationActivationEmailBodyOver13()
	{
		return "ÐŸÑ€Ð¸Ð²ÐµÑ‚, {accountName},{lineBreak}{lineBreak}Ð’Ñ‹ Ð°ÐºÑ‚Ð¸Ð²Ð¸Ñ€Ð¾Ð²Ð°Ð»Ð¸ Ð´Ð²ÑƒÑ…ÑÑ‚Ð°Ð¿Ð½ÑƒÑŽ Ð¿Ñ€Ð¾Ð²ÐµÑ€ÐºÑƒ Ð´Ð»Ñ Ð²Ð°ÑˆÐµÐ¹ ÑƒÑ‡ÐµÑ‚Ð½Ð¾Ð¹ Ð·Ð°Ð¿Ð¸ÑÐ¸ Roblox. Ð’ ÑÐ»ÐµÐ´ÑƒÑŽÑ‰Ð¸Ð¹ Ñ€Ð°Ð·, ÐºÐ¾Ð³Ð´Ð° Ð²Ñ‹ Ð²Ð¾Ð¹Ð´ÐµÑ‚Ðµ Ñ Ð½Ð¾Ð²Ð¾Ð³Ð¾ ÑƒÑÑ‚Ñ€Ð¾Ð¹ÑÑ‚Ð²Ð°, Ð²Ð°Ð¼ Ð±ÑƒÐ´ÐµÑ‚ Ð½ÑƒÐ¶Ð½Ð¾ Ð²Ð²ÐµÑÑ‚Ð¸ ÑˆÐµÑÑ‚Ð¸Ð·Ð½Ð°Ñ‡Ð½Ñ‹Ð¹ ÐºÐ¾Ð´ Ð±ÐµÐ·Ð¾Ð¿Ð°ÑÐ½Ð¾ÑÑ‚Ð¸, ÐºÐ¾Ñ‚Ð¾Ñ€Ñ‹Ð¹ Ð±ÑƒÑ‚ÐµÑ‚ Ð¾Ñ‚Ð¿Ñ€Ð°Ð²Ð»ÐµÐ½ Ð²Ð°Ð¼ Ð¿Ð¾ ÑÐ». Ð¿Ð¾Ñ‡Ñ‚Ðµ.{lineBreak}{lineBreak}Roblox";
	}

	/// <summary>
	/// Key: "Description.TwoStepVerificationActivationEmail.Body.Under13"
	/// Body for 2SV activation email for under 13 users
	/// English String: "Hi,{lineBreak}{lineBreak}2-Step Verification has been activated for your child's Roblox account, {accountName}. Next time they log in from a new device, they will need to enter a 6-digit security code that Roblox sends to you via email.{lineBreak}{lineBreak}Roblox"
	/// </summary>
	public override string DescriptionTwoStepVerificationActivationEmailBodyUnder13(string lineBreak, string accountName)
	{
		return $"ÐŸÑ€Ð¸Ð²ÐµÑ‚,,{lineBreak}{lineBreak}Ð’Ñ‹ Ð°ÐºÑ‚Ð¸Ð²Ð¸Ñ€Ð¾Ð²Ð°Ð»Ð¸ Ð´Ð²ÑƒÑ…ÑÑ‚Ð°Ð¿Ð½ÑƒÑŽ Ð¿Ñ€Ð¾Ð²ÐµÑ€ÐºÑƒ Ð´Ð»Ñ ÑƒÑ‡ÐµÑ‚Ð½Ð¾Ð¹ Ð·Ð°Ð¿Ð¸ÑÐ¸ Roblox Ð²Ð°ÑˆÐµÐ³Ð¾ Ñ€ÐµÐ±ÐµÐ½ÐºÐ°, {accountName}. Ð’ ÑÐ»ÐµÐ´ÑƒÑŽÑ‰Ð¸Ð¹ Ñ€Ð°Ð·, ÐºÐ¾Ð³Ð´Ð° Ð¾Ð½ Ð²Ð¾Ð¹Ð´ÐµÑ‚ Ñ Ð½Ð¾Ð²Ð¾Ð³Ð¾ ÑƒÑÑ‚Ñ€Ð¾Ð¹ÑÑ‚Ð²Ð°, Ð²Ð°Ð¼ Ð±ÑƒÐ´ÐµÑ‚ Ð½ÑƒÐ¶Ð½Ð¾ Ð²Ð²ÐµÑÑ‚Ð¸ ÑˆÐµÑÑ‚Ð¸Ð·Ð½Ð°Ñ‡Ð½Ñ‹Ð¹ ÐºÐ¾Ð´ Ð±ÐµÐ·Ð¾Ð¿Ð°ÑÐ½Ð¾ÑÑ‚Ð¸, ÐºÐ¾Ñ‚Ð¾Ñ€Ñ‹Ð¹ Ð±ÑƒÑ‚ÐµÑ‚ Ð¾Ñ‚Ð¿Ñ€Ð°Ð²Ð»ÐµÐ½ Ð²Ð°Ð¼ Ð¿Ð¾ ÑÐ». Ð¿Ð¾Ñ‡Ñ‚Ðµ..{lineBreak}{lineBreak}Roblox";
	}

	protected override string _GetTemplateForDescriptionTwoStepVerificationActivationEmailBodyUnder13()
	{
		return "ÐŸÑ€Ð¸Ð²ÐµÑ‚,,{lineBreak}{lineBreak}Ð’Ñ‹ Ð°ÐºÑ‚Ð¸Ð²Ð¸Ñ€Ð¾Ð²Ð°Ð»Ð¸ Ð´Ð²ÑƒÑ…ÑÑ‚Ð°Ð¿Ð½ÑƒÑŽ Ð¿Ñ€Ð¾Ð²ÐµÑ€ÐºÑƒ Ð´Ð»Ñ ÑƒÑ‡ÐµÑ‚Ð½Ð¾Ð¹ Ð·Ð°Ð¿Ð¸ÑÐ¸ Roblox Ð²Ð°ÑˆÐµÐ³Ð¾ Ñ€ÐµÐ±ÐµÐ½ÐºÐ°, {accountName}. Ð’ ÑÐ»ÐµÐ´ÑƒÑŽÑ‰Ð¸Ð¹ Ñ€Ð°Ð·, ÐºÐ¾Ð³Ð´Ð° Ð¾Ð½ Ð²Ð¾Ð¹Ð´ÐµÑ‚ Ñ Ð½Ð¾Ð²Ð¾Ð³Ð¾ ÑƒÑÑ‚Ñ€Ð¾Ð¹ÑÑ‚Ð²Ð°, Ð²Ð°Ð¼ Ð±ÑƒÐ´ÐµÑ‚ Ð½ÑƒÐ¶Ð½Ð¾ Ð²Ð²ÐµÑÑ‚Ð¸ ÑˆÐµÑÑ‚Ð¸Ð·Ð½Ð°Ñ‡Ð½Ñ‹Ð¹ ÐºÐ¾Ð´ Ð±ÐµÐ·Ð¾Ð¿Ð°ÑÐ½Ð¾ÑÑ‚Ð¸, ÐºÐ¾Ñ‚Ð¾Ñ€Ñ‹Ð¹ Ð±ÑƒÑ‚ÐµÑ‚ Ð¾Ñ‚Ð¿Ñ€Ð°Ð²Ð»ÐµÐ½ Ð²Ð°Ð¼ Ð¿Ð¾ ÑÐ». Ð¿Ð¾Ñ‡Ñ‚Ðµ..{lineBreak}{lineBreak}Roblox";
	}

	/// <summary>
	/// Key: "Description.TwoStepVerificationActivationEmail.Subject"
	/// Subject for 2SV activation email
	/// English String: "2-Step Verification Activated for Roblox Account: {accountName}"
	/// </summary>
	public override string DescriptionTwoStepVerificationActivationEmailSubject(string accountName)
	{
		return $"Ð”Ð»Ñ ÑƒÑ‡ÐµÑ‚Ð½Ð¾Ð¹ Ð·Ð°Ð¿Ð¸ÑÐ¸ Roblox Ð°ÐºÑ‚Ð¸Ð²Ð¸Ñ€Ð¾Ð²Ð°Ð½Ð° Ð´Ð²ÑƒÑ…ÑÑ‚Ð°Ð¿Ð½Ð°Ñ Ð¿Ñ€Ð¾Ð²ÐµÑ€ÐºÐ°: {accountName}";
	}

	protected override string _GetTemplateForDescriptionTwoStepVerificationActivationEmailSubject()
	{
		return "Ð”Ð»Ñ ÑƒÑ‡ÐµÑ‚Ð½Ð¾Ð¹ Ð·Ð°Ð¿Ð¸ÑÐ¸ Roblox Ð°ÐºÑ‚Ð¸Ð²Ð¸Ñ€Ð¾Ð²Ð°Ð½Ð° Ð´Ð²ÑƒÑ…ÑÑ‚Ð°Ð¿Ð½Ð°Ñ Ð¿Ñ€Ð¾Ð²ÐµÑ€ÐºÐ°: {accountName}";
	}

	/// <summary>
	/// Key: "Description.TwoStepVerificationDeactivationEmail.Body.Over13"
	/// Body for 2SV deactivation email for over 13 users
	/// English String: "Hi {accountName},{lineBreak}{lineBreak}You have deactivated 2-Step Verification for your Roblox account. A security code will no longer be required when you log into your account.{lineBreak}{lineBreak}Roblox"
	/// </summary>
	public override string DescriptionTwoStepVerificationDeactivationEmailBodyOver13(string accountName, string lineBreak)
	{
		return $"ÐŸÑ€Ð¸Ð²ÐµÑ‚, {accountName},{lineBreak}{lineBreak}Ð’Ñ‹ Ð´ÐµÐ°ÐºÑ‚Ð¸Ð²Ð¸Ñ€Ð¾Ð²Ð°Ð»Ð¸ Ð´Ð²ÑƒÑ…ÑÑ‚Ð°Ð¿Ð½ÑƒÑŽ Ð¿Ñ€Ð¾Ð²ÐµÑ€ÐºÑƒ Ð´Ð»Ñ Ð²Ð°ÑˆÐµÐ¹ ÑƒÑ‡ÐµÑ‚Ð½Ð¾Ð¹ Ð·Ð°Ð¿Ð¸ÑÐ¸ Roblox. Ð”Ð»Ñ Ð² Ñ…Ð¾Ð´Ð° Ð² ÑƒÑ‡ÐµÑ‚Ð½ÑƒÑŽ Ð·Ð°Ð¿Ð¸ÑÑŒ ÐºÐ¾Ð´ Ð±ÐµÐ·Ð¾Ð¿Ð°ÑÐ½Ð¾ÑÑ‚Ð¸ Ð±Ð¾Ð»ÑŒÑˆÐµ Ð½Ðµ Ñ‚Ñ€ÐµÐ±ÑƒÐµÑ‚ÑÑ.{lineBreak}{lineBreak}Roblox";
	}

	protected override string _GetTemplateForDescriptionTwoStepVerificationDeactivationEmailBodyOver13()
	{
		return "ÐŸÑ€Ð¸Ð²ÐµÑ‚, {accountName},{lineBreak}{lineBreak}Ð’Ñ‹ Ð´ÐµÐ°ÐºÑ‚Ð¸Ð²Ð¸Ñ€Ð¾Ð²Ð°Ð»Ð¸ Ð´Ð²ÑƒÑ…ÑÑ‚Ð°Ð¿Ð½ÑƒÑŽ Ð¿Ñ€Ð¾Ð²ÐµÑ€ÐºÑƒ Ð´Ð»Ñ Ð²Ð°ÑˆÐµÐ¹ ÑƒÑ‡ÐµÑ‚Ð½Ð¾Ð¹ Ð·Ð°Ð¿Ð¸ÑÐ¸ Roblox. Ð”Ð»Ñ Ð² Ñ…Ð¾Ð´Ð° Ð² ÑƒÑ‡ÐµÑ‚Ð½ÑƒÑŽ Ð·Ð°Ð¿Ð¸ÑÑŒ ÐºÐ¾Ð´ Ð±ÐµÐ·Ð¾Ð¿Ð°ÑÐ½Ð¾ÑÑ‚Ð¸ Ð±Ð¾Ð»ÑŒÑˆÐµ Ð½Ðµ Ñ‚Ñ€ÐµÐ±ÑƒÐµÑ‚ÑÑ.{lineBreak}{lineBreak}Roblox";
	}

	/// <summary>
	/// Key: "Description.TwoStepVerificationDeactivationEmail.Body.Under13"
	/// Body for 2SV deactivation email for under 13 users
	/// English String: "Hi,{lineBreak}{lineBreak}2-Step Verification has been deactivated for your child's Roblox account, {accountName}. A security code will no longer be required when they log into the account.{lineBreak}{lineBreak}Roblox"
	/// </summary>
	public override string DescriptionTwoStepVerificationDeactivationEmailBodyUnder13(string lineBreak, string accountName)
	{
		return $"ÐŸÑ€Ð¸Ð²ÐµÑ‚,{lineBreak}{lineBreak}Ð’Ñ‹ Ð´ÐµÐ°ÐºÑ‚Ð¸Ð²Ð¸Ñ€Ð¾Ð²Ð°Ð»Ð¸ Ð´Ð²ÑƒÑ…ÑÑ‚Ð°Ð¿Ð½ÑƒÑŽ Ð¿Ñ€Ð¾Ð²ÐµÑ€ÐºÑƒ Ð´Ð»Ñ ÑƒÑ‡ÐµÑ‚Ð½Ð¾Ð¹ Ð·Ð°Ð¿Ð¸ÑÐ¸ Roblox Ð²Ð°ÑˆÐµÐ³Ð¾ Ñ€ÐµÐ±ÐµÐ½ÐºÐ°, {accountName}. A security code will no longer be required when they log into the account.{lineBreak}{lineBreak}Roblox";
	}

	protected override string _GetTemplateForDescriptionTwoStepVerificationDeactivationEmailBodyUnder13()
	{
		return "ÐŸÑ€Ð¸Ð²ÐµÑ‚,{lineBreak}{lineBreak}Ð’Ñ‹ Ð´ÐµÐ°ÐºÑ‚Ð¸Ð²Ð¸Ñ€Ð¾Ð²Ð°Ð»Ð¸ Ð´Ð²ÑƒÑ…ÑÑ‚Ð°Ð¿Ð½ÑƒÑŽ Ð¿Ñ€Ð¾Ð²ÐµÑ€ÐºÑƒ Ð´Ð»Ñ ÑƒÑ‡ÐµÑ‚Ð½Ð¾Ð¹ Ð·Ð°Ð¿Ð¸ÑÐ¸ Roblox Ð²Ð°ÑˆÐµÐ³Ð¾ Ñ€ÐµÐ±ÐµÐ½ÐºÐ°, {accountName}. A security code will no longer be required when they log into the account.{lineBreak}{lineBreak}Roblox";
	}

	/// <summary>
	/// Key: "Description.TwoStepVerificationDeactivationEmail.Subject	"
	/// Subject for 2SV deactivation email
	/// English String: "2-Step Verification Deactivated for Roblox Account: {accountName}"
	/// </summary>
	public override string DescriptionTwoStepVerificationDeactivationEmailSubject(string accountName)
	{
		return $"Ð”Ð»Ñ ÑƒÑ‡ÐµÑ‚Ð½Ð¾Ð¹ Ð·Ð°Ð¿Ð¸ÑÐ¸ Roblox Ð´ÐµÐ°ÐºÑ‚Ð¸Ð²Ð¸Ñ€Ð¾Ð²Ð°Ð½Ð° Ð´Ð²ÑƒÑ…ÑÑ‚Ð°Ð¿Ð½Ð°Ñ Ð¿Ñ€Ð¾Ð²ÐµÑ€ÐºÐ°: {accountName}";
	}

	protected override string _GetTemplateForDescriptionTwoStepVerificationDeactivationEmailSubject()
	{
		return "Ð”Ð»Ñ ÑƒÑ‡ÐµÑ‚Ð½Ð¾Ð¹ Ð·Ð°Ð¿Ð¸ÑÐ¸ Roblox Ð´ÐµÐ°ÐºÑ‚Ð¸Ð²Ð¸Ñ€Ð¾Ð²Ð°Ð½Ð° Ð´Ð²ÑƒÑ…ÑÑ‚Ð°Ð¿Ð½Ð°Ñ Ð¿Ñ€Ð¾Ð²ÐµÑ€ÐºÐ°: {accountName}";
	}

	/// <summary>
	/// Key: "Description.TwoStepVerificationLoginEmail.Html.GeolocationInfo1"
	/// Geolocation information about IP trying to login
	/// English String: "{spanStartTagWithBold}Login request received from {username} located in {region}, {country} ({ipAddress}).{spanEndTag}{lineBreak}{lineBreak}"
	/// </summary>
	public override string DescriptionTwoStepVerificationLoginEmailHtmlGeolocationInfo1(string spanStartTagWithBold, string username, string region, string country, string ipAddress, string spanEndTag, string lineBreak)
	{
		return $"{spanStartTagWithBold}Ð—Ð°Ð¿Ñ€Ð¾Ñ Ð½Ð° Ð²Ñ…Ð¾Ð´ Ð¿Ð¾Ð»ÑƒÑ‡ÐµÐ½ Ð¾Ñ‚ Ð¿Ð¾Ð»ÑŒÐ·Ð¾Ð²Ð°Ñ‚ÐµÐ»Ñ {username}, Ñ€Ð°ÑÐ¿Ð¾Ð»Ð¾Ð¶ÐµÐ½Ð½Ð¾Ð³Ð¾ Ð² {region}, {country} ({ipAddress}).{spanEndTag}{lineBreak}{lineBreak}";
	}

	protected override string _GetTemplateForDescriptionTwoStepVerificationLoginEmailHtmlGeolocationInfo1()
	{
		return "{spanStartTagWithBold}Ð—Ð°Ð¿Ñ€Ð¾Ñ Ð½Ð° Ð²Ñ…Ð¾Ð´ Ð¿Ð¾Ð»ÑƒÑ‡ÐµÐ½ Ð¾Ñ‚ Ð¿Ð¾Ð»ÑŒÐ·Ð¾Ð²Ð°Ñ‚ÐµÐ»Ñ {username}, Ñ€Ð°ÑÐ¿Ð¾Ð»Ð¾Ð¶ÐµÐ½Ð½Ð¾Ð³Ð¾ Ð² {region}, {country} ({ipAddress}).{spanEndTag}{lineBreak}{lineBreak}";
	}

	/// <summary>
	/// Key: "Description.TwoStepVerificationLoginEmail.Html.GeolocationInfo2"
	/// Geolocation info about IP trying to login
	/// English String: "{spanStartTagWithBold}Login request received from {username} located in {country} ({ipAddress}).{spanEndTag}{lineBreak}{lineBreak}\t"
	/// </summary>
	public override string DescriptionTwoStepVerificationLoginEmailHtmlGeolocationInfo2(string spanStartTagWithBold, string username, string country, string ipAddress, string spanEndTag, string lineBreak)
	{
		return $"{spanStartTagWithBold}Ð—Ð°Ð¿Ñ€Ð¾Ñ Ð½Ð° Ð²Ñ…Ð¾Ð´ Ð¿Ð¾Ð»ÑƒÑ‡ÐµÐ½ Ð¾Ñ‚ Ð¿Ð¾Ð»ÑŒÐ·Ð¾Ð²Ð°Ñ‚ÐµÐ»Ñ {username}, Ñ€Ð°ÑÐ¿Ð¾Ð»Ð¾Ð¶ÐµÐ½Ð½Ð¾Ð³Ð¾ Ð² {country},  ({ipAddress}).{spanEndTag}{lineBreak}{lineBreak}\t";
	}

	protected override string _GetTemplateForDescriptionTwoStepVerificationLoginEmailHtmlGeolocationInfo2()
	{
		return "{spanStartTagWithBold}Ð—Ð°Ð¿Ñ€Ð¾Ñ Ð½Ð° Ð²Ñ…Ð¾Ð´ Ð¿Ð¾Ð»ÑƒÑ‡ÐµÐ½ Ð¾Ñ‚ Ð¿Ð¾Ð»ÑŒÐ·Ð¾Ð²Ð°Ñ‚ÐµÐ»Ñ {username}, Ñ€Ð°ÑÐ¿Ð¾Ð»Ð¾Ð¶ÐµÐ½Ð½Ð¾Ð³Ð¾ Ð² {country},  ({ipAddress}).{spanEndTag}{lineBreak}{lineBreak}\t";
	}

	/// <summary>
	/// Key: "Description.TwoStepVerificationLoginEmail.Html.GeolocationInfo3"
	/// Geolocation info about IP trying to log in
	/// English String: "{spanStartTagWithBold}Login request received from {username} (From Roblox Internal).{spanEndTag}{lineBreak}{lineBreak}\t"
	/// </summary>
	public override string DescriptionTwoStepVerificationLoginEmailHtmlGeolocationInfo3(string spanStartTagWithBold, string username, string spanEndTag, string lineBreak)
	{
		return $"{spanStartTagWithBold}Ð—Ð°Ð¿Ñ€Ð¾Ñ Ð½Ð° Ð²Ñ…Ð¾Ð´ Ð¿Ð¾Ð»ÑƒÑ‡ÐµÐ½ Ð¾Ñ‚ Ð¿Ð¾Ð»ÑŒÐ·Ð¾Ð²Ð°Ñ‚ÐµÐ»Ñ {username}, (Ð¸Ð· Roblox).{spanEndTag}{lineBreak}{lineBreak}\t";
	}

	protected override string _GetTemplateForDescriptionTwoStepVerificationLoginEmailHtmlGeolocationInfo3()
	{
		return "{spanStartTagWithBold}Ð—Ð°Ð¿Ñ€Ð¾Ñ Ð½Ð° Ð²Ñ…Ð¾Ð´ Ð¿Ð¾Ð»ÑƒÑ‡ÐµÐ½ Ð¾Ñ‚ Ð¿Ð¾Ð»ÑŒÐ·Ð¾Ð²Ð°Ñ‚ÐµÐ»Ñ {username}, (Ð¸Ð· Roblox).{spanEndTag}{lineBreak}{lineBreak}\t";
	}

	/// <summary>
	/// Key: "Description.TwoStepVerificationLoginEmail.Html.GeolocationInfo4"
	/// Geolocation info of IP trying to login
	/// English String: "{spanStartTagWithBold}Login request received from {username} located in {country}.{spanEndTag}{lineBreak}{lineBreak}"
	/// </summary>
	public override string DescriptionTwoStepVerificationLoginEmailHtmlGeolocationInfo4(string spanStartTagWithBold, string username, string country, string spanEndTag, string lineBreak)
	{
		return $"{spanStartTagWithBold}Ð—Ð°Ð¿Ñ€Ð¾Ñ Ð½Ð° Ð²Ñ…Ð¾Ð´ Ð¿Ð¾Ð»ÑƒÑ‡ÐµÐ½ Ð¾Ñ‚ Ð¿Ð¾Ð»ÑŒÐ·Ð¾Ð²Ð°Ñ‚ÐµÐ»Ñ {username} Ñ€Ð°ÑÐ¿Ð¾Ð»Ð¾Ð¶ÐµÐ½Ð½Ð¾Ð³Ð¾ Ð² ÑÑ‚Ñ€Ð°Ð½Ðµ {country}.{spanEndTag}{lineBreak}{lineBreak}";
	}

	protected override string _GetTemplateForDescriptionTwoStepVerificationLoginEmailHtmlGeolocationInfo4()
	{
		return "{spanStartTagWithBold}Ð—Ð°Ð¿Ñ€Ð¾Ñ Ð½Ð° Ð²Ñ…Ð¾Ð´ Ð¿Ð¾Ð»ÑƒÑ‡ÐµÐ½ Ð¾Ñ‚ Ð¿Ð¾Ð»ÑŒÐ·Ð¾Ð²Ð°Ñ‚ÐµÐ»Ñ {username} Ñ€Ð°ÑÐ¿Ð¾Ð»Ð¾Ð¶ÐµÐ½Ð½Ð¾Ð³Ð¾ Ð² ÑÑ‚Ñ€Ð°Ð½Ðµ {country}.{spanEndTag}{lineBreak}{lineBreak}";
	}

	/// <summary>
	/// Key: "Description.TwoStepVerificationLoginEmail.Html.GeolocationInfo5"
	/// Geolocation info of IP trying to login
	/// English String: "{spanStartTagWithBold}Login request received from {username} located in {region}, {country}.{spanEndTag}{lineBreak}{lineBreak}"
	/// </summary>
	public override string DescriptionTwoStepVerificationLoginEmailHtmlGeolocationInfo5(string spanStartTagWithBold, string username, string region, string country, string spanEndTag, string lineBreak)
	{
		return $"{spanStartTagWithBold}Ð—Ð°Ð¿Ñ€Ð¾Ñ Ð½Ð° Ð²Ñ…Ð¾Ð´ Ð¿Ð¾Ð»ÑƒÑ‡ÐµÐ½ Ð¾Ñ‚ Ð¿Ð¾Ð»ÑŒÐ·Ð¾Ð²Ð°Ñ‚ÐµÐ»Ñ {username} Ñ€Ð°ÑÐ¿Ð¾Ð»Ð¾Ð¶ÐµÐ½Ð½Ð¾Ð³Ð¾ Ð² Ñ€ÐµÐ³Ð¸Ð¾Ð½Ðµ {region}, {country}.{spanEndTag}{lineBreak}{lineBreak}";
	}

	protected override string _GetTemplateForDescriptionTwoStepVerificationLoginEmailHtmlGeolocationInfo5()
	{
		return "{spanStartTagWithBold}Ð—Ð°Ð¿Ñ€Ð¾Ñ Ð½Ð° Ð²Ñ…Ð¾Ð´ Ð¿Ð¾Ð»ÑƒÑ‡ÐµÐ½ Ð¾Ñ‚ Ð¿Ð¾Ð»ÑŒÐ·Ð¾Ð²Ð°Ñ‚ÐµÐ»Ñ {username} Ñ€Ð°ÑÐ¿Ð¾Ð»Ð¾Ð¶ÐµÐ½Ð½Ð¾Ð³Ð¾ Ð² Ñ€ÐµÐ³Ð¸Ð¾Ð½Ðµ {region}, {country}.{spanEndTag}{lineBreak}{lineBreak}";
	}

	/// <summary>
	/// Key: "Description.TwoStepVerificationLoginEmail.Html.GeolocationInfo6"
	/// Geolocation info of IP trying to login
	/// English String: "{spanStartTagWithBold}Login request received from {username} located in {city}, {region}, {country}.{spanEndTag}{lineBreak}{lineBreak}"
	/// </summary>
	public override string DescriptionTwoStepVerificationLoginEmailHtmlGeolocationInfo6(string spanStartTagWithBold, string username, string city, string region, string country, string spanEndTag, string lineBreak)
	{
		return $"{spanStartTagWithBold}Ð—Ð°Ð¿Ñ€Ð¾Ñ Ð½Ð° Ð²Ñ…Ð¾Ð´ Ð¿Ð¾Ð»ÑƒÑ‡ÐµÐ½ Ð¾Ñ‚ Ð¿Ð¾Ð»ÑŒÐ·Ð¾Ð²Ð°Ñ‚ÐµÐ»Ñ {username} Ñ€Ð°ÑÐ¿Ð¾Ð»Ð¾Ð¶ÐµÐ½Ð½Ð¾Ð³Ð¾ Ð² Ð³Ð¾Ñ€Ð¾Ð´Ðµ {city}, {region}, {country}.{spanEndTag}{lineBreak}{lineBreak}";
	}

	protected override string _GetTemplateForDescriptionTwoStepVerificationLoginEmailHtmlGeolocationInfo6()
	{
		return "{spanStartTagWithBold}Ð—Ð°Ð¿Ñ€Ð¾Ñ Ð½Ð° Ð²Ñ…Ð¾Ð´ Ð¿Ð¾Ð»ÑƒÑ‡ÐµÐ½ Ð¾Ñ‚ Ð¿Ð¾Ð»ÑŒÐ·Ð¾Ð²Ð°Ñ‚ÐµÐ»Ñ {username} Ñ€Ð°ÑÐ¿Ð¾Ð»Ð¾Ð¶ÐµÐ½Ð½Ð¾Ð³Ð¾ Ð² Ð³Ð¾Ñ€Ð¾Ð´Ðµ {city}, {region}, {country}.{spanEndTag}{lineBreak}{lineBreak}";
	}

	/// <summary>
	/// Key: "Description.TwoStepVerificationLoginEmail.HtmlBody"
	/// Html body for 2SV login email
	/// English String: "{geoLocationInformation}{spanStartTagWithBold}Login code for {accountName}: {lineBreak}{lineBreak}{code} {spanEndTag}{lineBreak}{lineBreak}Enter this code into the 2-Step Verification screen to finish logging in. This code will expire in 15 minutes.{lineBreak}{lineBreak}This email was sent because your account tried to login to Roblox from a new browser or device. If you haven't tried logging into Roblox, someone else may be trying to access your account. You are strongly advised to change your password if you did not generate this request.{lineBreak}{lineBreak}Resources:{lineBreak}{aTagStartWithHref}{ChangePasswordLink}{hrefEnd}Change Your Password{aTagEnd} {lineBreak}{aTagStartWithHref}{TwoStepVerificationArticleLink}{hrefEnd}Learn More About 2-Step Verification{aTagEnd} {lineBreak}{aTagStartWithHref}{AccountSafetyArticleLink}{hrefEnd}Keeping Your Account Safe{aTagEnd} {lineBreak}{aTagStartWithHref}{SupportLink}{hrefEnd}General Roblox Support{aTagEnd} {lineBreak}{lineBreak}Thank you,{lineBreak}{lineBreak}The Roblox Team"
	/// </summary>
	public override string DescriptionTwoStepVerificationLoginEmailHtmlBody(string geoLocationInformation, string spanStartTagWithBold, string accountName, string lineBreak, string code, string spanEndTag, string aTagStartWithHref, string ChangePasswordLink, string hrefEnd, string aTagEnd, string TwoStepVerificationArticleLink, string AccountSafetyArticleLink, string SupportLink)
	{
		return $"{geoLocationInformation}{spanStartTagWithBold}ÐšÐ¾Ð´ Ð½Ð° Ð²Ñ…Ð¾Ð´ Ð´Ð»Ñ ÑƒÑ‡ÐµÑ‚Ð½Ð¾Ð¹ Ð·Ð°Ð¿Ð¸ÑÐ¸ {accountName}: {lineBreak}{lineBreak} {code} {spanEndTag}{lineBreak}{lineBreak}Ð’Ð²ÐµÐ´Ð¸Ñ‚Ðµ ÑÑ‚Ð¾Ñ‚ ÐºÐ¾Ð´ Ð½Ð° ÑÐºÑ€Ð°Ð½Ðµ Ð´Ð²ÑƒÑ…ÑÑ‚Ð°Ð¿Ð½Ð¾Ð¹ Ð¿Ñ€Ð¾Ð²ÐµÑ€ÐºÐ¸ Ð´Ð»Ñ Ð·Ð°Ð²ÐµÑ€ÑˆÐµÐ½Ð¸Ñ Ð²Ñ…Ð¾Ð´Ð° Ð² ÑÐ¸ÑÑ‚ÐµÐ¼Ñƒ. Ð¡Ñ€Ð¾Ðº Ð´ÐµÐ¹ÑÑ‚Ð²Ð¸Ñ ÐºÐ¾Ð´Ð° Ð¸ÑÑ‚ÐµÐºÐ°ÐµÑ‚ Ñ‡ÐµÑ€ÐµÐ· 15 Ð¼Ð¸Ð½ÑƒÑ‚. {lineBreak}{lineBreak}Ð­Ñ‚Ð¾ ÑÐ¾Ð¾Ð±Ñ‰ÐµÐ½Ð¸Ðµ Ð±Ñ‹Ð»Ð¾ Ð¾Ñ‚Ð¿Ñ€Ð°Ð²Ð»ÐµÐ½Ð¾ Ð²Ð°Ð¼, Ñ‚Ð°Ðº ÐºÐ°Ðº Ð² Ð²Ð°ÑˆÑƒ ÑƒÑ‡ÐµÑ‚Ð½ÑƒÑŽ Ð·Ð°Ð¿Ð¸ÑÑŒ Roblox Ð±Ñ‹Ð»Ð° Ð¿Ñ€ÐµÐ´Ð¿Ñ€Ð¸Ð½ÑÑ‚Ð° Ð¿Ð¾Ð¿Ñ‹Ñ‚ÐºÐ° Ð²Ñ…Ð¾Ð´Ð° Ñ‡ÐµÑ€ÐµÐ· Ð´Ñ€ÑƒÐ³Ð¾Ð¹ Ð±Ñ€Ð°ÑƒÐ·ÐµÑ€ Ð¸Ð»Ð¸ Ñ Ð´Ñ€ÑƒÐ³Ð¾Ð³Ð¾ ÑƒÑÑ‚Ñ€Ð¾Ð¹ÑÑ‚Ð²Ð°. Ð•ÑÐ»Ð¸ Ð²Ñ‹ Ð½Ðµ Ð¿Ñ‹Ñ‚Ð°Ð»Ð¸ÑÑŒ Ð²Ð¾Ð¹Ñ‚Ð¸ Ð² Roblox, Ð²Ð¾Ð·Ð¼Ð¾Ð¶Ð½Ð¾, ÐºÑ‚Ð¾-Ñ‚Ð¾ Ð´Ñ€ÑƒÐ³Ð¾Ð¹ Ð¿Ñ‹Ñ‚Ð°Ð»ÑÑ Ð¿Ð¾Ð»ÑƒÑ‡Ð¸Ñ‚ÑŒ Ð´Ð¾ÑÑ‚ÑƒÐ¿ Ðº Ð²Ð°ÑˆÐµÐ¹ ÑƒÑ‡ÐµÑ‚Ð½Ð¾Ð¹ Ð·Ð°Ð¿Ð¸ÑÐ¸. Ð’ ÑÑ‚Ð¾Ð¼ ÑÐ»ÑƒÑ‡Ð°Ðµ Ð¼Ñ‹ Ð½Ð°ÑÑ‚Ð¾ÑÑ‚ÐµÐ»ÑŒÐ½Ð¾ Ñ€ÐµÐºÐ¾Ð¼ÐµÐ½Ð´ÑƒÐµÐ¼ ÑÐ¼ÐµÐ½Ð¸Ñ‚ÑŒ Ð²Ð°Ñˆ Ð¿Ð°Ñ€Ð¾Ð»ÑŒ. {lineBreak}{lineBreak}Ð˜ÑÑ‚Ð¾Ñ‡Ð½Ð¸ÐºÐ¸: {lineBreak}{aTagStartWithHref}{ChangePasswordLink}{hrefEnd}Ð˜Ð·Ð¼ÐµÐ½Ð¸Ñ‚ÑŒ Ð¿Ð°Ñ€Ð¾Ð»ÑŒ  {aTagEnd}{lineBreak}{aTagStartWithHref}{TwoStepVerificationArticleLink}{hrefEnd}ÐŸÐ¾Ð´Ñ€Ð¾Ð±Ð½ÐµÐµ Ð¾ Ð´Ð²ÑƒÑ…ÑÑ‚Ð°Ð¿Ð½Ð¾Ð¹ Ð¿Ñ€Ð¾Ð²ÐµÑ€ÐºÐµ {aTagEnd}{lineBreak}{aTagStartWithHref}{AccountSafetyArticleLink}{hrefEnd}ÐžÐ±ÐµÑÐ¿ÐµÑ‡ÐµÐ½Ð¸Ðµ Ð±ÐµÐ·Ð¾Ð¿Ð°ÑÐ½Ð¾ÑÑ‚Ð¸ Ð²Ð°ÑˆÐµÐ¹ ÑƒÑ‡ÐµÑ‚Ð½Ð¾Ð¹ Ð·Ð°Ð¿Ð¸ÑÐ¸ {aTagEnd}{lineBreak}{aTagStartWithHref}{SupportLink}{hrefEnd}Ð¢ÐµÑ…Ð½Ð¸Ñ‡ÐµÑÐºÐ°Ñ Ð¿Ð¾Ð´Ð´ÐµÑ€Ð¶ÐºÐ° Roblox {aTagEnd}{lineBreak}{lineBreak}Ð¡ Ð±Ð»Ð°Ð³Ð¾Ð´Ð°Ñ€Ð½Ð¾ÑÑ‚ÑŒÑŽ, {lineBreak}{lineBreak}ÐšÐ¾Ð¼Ð°Ð½Ð´Ð° Roblox";
	}

	protected override string _GetTemplateForDescriptionTwoStepVerificationLoginEmailHtmlBody()
	{
		return "{geoLocationInformation}{spanStartTagWithBold}ÐšÐ¾Ð´ Ð½Ð° Ð²Ñ…Ð¾Ð´ Ð´Ð»Ñ ÑƒÑ‡ÐµÑ‚Ð½Ð¾Ð¹ Ð·Ð°Ð¿Ð¸ÑÐ¸ {accountName}: {lineBreak}{lineBreak} {code} {spanEndTag}{lineBreak}{lineBreak}Ð’Ð²ÐµÐ´Ð¸Ñ‚Ðµ ÑÑ‚Ð¾Ñ‚ ÐºÐ¾Ð´ Ð½Ð° ÑÐºÑ€Ð°Ð½Ðµ Ð´Ð²ÑƒÑ…ÑÑ‚Ð°Ð¿Ð½Ð¾Ð¹ Ð¿Ñ€Ð¾Ð²ÐµÑ€ÐºÐ¸ Ð´Ð»Ñ Ð·Ð°Ð²ÐµÑ€ÑˆÐµÐ½Ð¸Ñ Ð²Ñ…Ð¾Ð´Ð° Ð² ÑÐ¸ÑÑ‚ÐµÐ¼Ñƒ. Ð¡Ñ€Ð¾Ðº Ð´ÐµÐ¹ÑÑ‚Ð²Ð¸Ñ ÐºÐ¾Ð´Ð° Ð¸ÑÑ‚ÐµÐºÐ°ÐµÑ‚ Ñ‡ÐµÑ€ÐµÐ· 15 Ð¼Ð¸Ð½ÑƒÑ‚. {lineBreak}{lineBreak}Ð­Ñ‚Ð¾ ÑÐ¾Ð¾Ð±Ñ‰ÐµÐ½Ð¸Ðµ Ð±Ñ‹Ð»Ð¾ Ð¾Ñ‚Ð¿Ñ€Ð°Ð²Ð»ÐµÐ½Ð¾ Ð²Ð°Ð¼, Ñ‚Ð°Ðº ÐºÐ°Ðº Ð² Ð²Ð°ÑˆÑƒ ÑƒÑ‡ÐµÑ‚Ð½ÑƒÑŽ Ð·Ð°Ð¿Ð¸ÑÑŒ Roblox Ð±Ñ‹Ð»Ð° Ð¿Ñ€ÐµÐ´Ð¿Ñ€Ð¸Ð½ÑÑ‚Ð° Ð¿Ð¾Ð¿Ñ‹Ñ‚ÐºÐ° Ð²Ñ…Ð¾Ð´Ð° Ñ‡ÐµÑ€ÐµÐ· Ð´Ñ€ÑƒÐ³Ð¾Ð¹ Ð±Ñ€Ð°ÑƒÐ·ÐµÑ€ Ð¸Ð»Ð¸ Ñ Ð´Ñ€ÑƒÐ³Ð¾Ð³Ð¾ ÑƒÑÑ‚Ñ€Ð¾Ð¹ÑÑ‚Ð²Ð°. Ð•ÑÐ»Ð¸ Ð²Ñ‹ Ð½Ðµ Ð¿Ñ‹Ñ‚Ð°Ð»Ð¸ÑÑŒ Ð²Ð¾Ð¹Ñ‚Ð¸ Ð² Roblox, Ð²Ð¾Ð·Ð¼Ð¾Ð¶Ð½Ð¾, ÐºÑ‚Ð¾-Ñ‚Ð¾ Ð´Ñ€ÑƒÐ³Ð¾Ð¹ Ð¿Ñ‹Ñ‚Ð°Ð»ÑÑ Ð¿Ð¾Ð»ÑƒÑ‡Ð¸Ñ‚ÑŒ Ð´Ð¾ÑÑ‚ÑƒÐ¿ Ðº Ð²Ð°ÑˆÐµÐ¹ ÑƒÑ‡ÐµÑ‚Ð½Ð¾Ð¹ Ð·Ð°Ð¿Ð¸ÑÐ¸. Ð’ ÑÑ‚Ð¾Ð¼ ÑÐ»ÑƒÑ‡Ð°Ðµ Ð¼Ñ‹ Ð½Ð°ÑÑ‚Ð¾ÑÑ‚ÐµÐ»ÑŒÐ½Ð¾ Ñ€ÐµÐºÐ¾Ð¼ÐµÐ½Ð´ÑƒÐµÐ¼ ÑÐ¼ÐµÐ½Ð¸Ñ‚ÑŒ Ð²Ð°Ñˆ Ð¿Ð°Ñ€Ð¾Ð»ÑŒ. {lineBreak}{lineBreak}Ð˜ÑÑ‚Ð¾Ñ‡Ð½Ð¸ÐºÐ¸: {lineBreak}{aTagStartWithHref}{ChangePasswordLink}{hrefEnd}Ð˜Ð·Ð¼ÐµÐ½Ð¸Ñ‚ÑŒ Ð¿Ð°Ñ€Ð¾Ð»ÑŒ  {aTagEnd}{lineBreak}{aTagStartWithHref}{TwoStepVerificationArticleLink}{hrefEnd}ÐŸÐ¾Ð´Ñ€Ð¾Ð±Ð½ÐµÐµ Ð¾ Ð´Ð²ÑƒÑ…ÑÑ‚Ð°Ð¿Ð½Ð¾Ð¹ Ð¿Ñ€Ð¾Ð²ÐµÑ€ÐºÐµ {aTagEnd}{lineBreak}{aTagStartWithHref}{AccountSafetyArticleLink}{hrefEnd}ÐžÐ±ÐµÑÐ¿ÐµÑ‡ÐµÐ½Ð¸Ðµ Ð±ÐµÐ·Ð¾Ð¿Ð°ÑÐ½Ð¾ÑÑ‚Ð¸ Ð²Ð°ÑˆÐµÐ¹ ÑƒÑ‡ÐµÑ‚Ð½Ð¾Ð¹ Ð·Ð°Ð¿Ð¸ÑÐ¸ {aTagEnd}{lineBreak}{aTagStartWithHref}{SupportLink}{hrefEnd}Ð¢ÐµÑ…Ð½Ð¸Ñ‡ÐµÑÐºÐ°Ñ Ð¿Ð¾Ð´Ð´ÐµÑ€Ð¶ÐºÐ° Roblox {aTagEnd}{lineBreak}{lineBreak}Ð¡ Ð±Ð»Ð°Ð³Ð¾Ð´Ð°Ñ€Ð½Ð¾ÑÑ‚ÑŒÑŽ, {lineBreak}{lineBreak}ÐšÐ¾Ð¼Ð°Ð½Ð´Ð° Roblox";
	}

	/// <summary>
	/// Key: "Description.TwoStepVerificationLoginEmail.PlainBody"
	/// Plain body for 2SV login email
	/// English String: "{geoLocationInformation}Login code for {accountName}: {lineBreak}{lineBreak} {code} {lineBreak}{lineBreak}Enter this code into the 2-Step Verification screen to finish logging in. This code will expire in 15 minutes. {lineBreak}{lineBreak}This email was sent because your account tried to login to Roblox from a new browser or device. If you haven't tried logging into Roblox, someone else may be trying to access your account. You are strongly advised to change your password if you did not generate this request. {lineBreak}{lineBreak}Resources: {lineBreak}Change Your Password [{accountInfoPageLink}] {lineBreak}Learn More About 2-Step Verification [{twoStepVerificationHelpArticleLink}]{lineBreak}Keeping Your Account Safe [{keepAccountSafeArticleLink}] {lineBreak}General Roblox Support [{supportPageLink}] {lineBreak}{lineBreak}Thank you, {lineBreak}{lineBreak}The Roblox Team"
	/// </summary>
	public override string DescriptionTwoStepVerificationLoginEmailPlainBody(string geoLocationInformation, string accountName, string lineBreak, string code, string accountInfoPageLink, string twoStepVerificationHelpArticleLink, string keepAccountSafeArticleLink, string supportPageLink)
	{
		return $"{geoLocationInformation}ÐšÐ¾Ð´ Ð½Ð° Ð²Ñ…Ð¾Ð´ Ð´Ð»Ñ ÑƒÑ‡ÐµÑ‚Ð½Ð¾Ð¹ Ð·Ð°Ð¿Ð¸ÑÐ¸ {accountName}: {lineBreak}{lineBreak} {code} {lineBreak}{lineBreak}Ð’Ð²ÐµÐ´Ð¸Ñ‚Ðµ ÑÑ‚Ð¾Ñ‚ ÐºÐ¾Ð´ Ð½Ð° ÑÐºÑ€Ð°Ð½Ðµ Ð´Ð²ÑƒÑ…ÑÑ‚Ð°Ð¿Ð½Ð¾Ð¹ Ð¿Ñ€Ð¾Ð²ÐµÑ€ÐºÐ¸ Ð´Ð»Ñ Ð·Ð°Ð²ÐµÑ€ÑˆÐµÐ½Ð¸Ñ Ð²Ñ…Ð¾Ð´Ð° Ð² ÑÐ¸ÑÑ‚ÐµÐ¼Ñƒ. Ð¡Ñ€Ð¾Ðº Ð´ÐµÐ¹ÑÑ‚Ð²Ð¸Ñ ÐºÐ¾Ð´Ð° Ð¸ÑÑ‚ÐµÐºÐ°ÐµÑ‚ Ñ‡ÐµÑ€ÐµÐ· 15 Ð¼Ð¸Ð½ÑƒÑ‚. {lineBreak}{lineBreak}Ð­Ñ‚Ð¾ ÑÐ¾Ð¾Ð±Ñ‰ÐµÐ½Ð¸Ðµ Ð±Ñ‹Ð»Ð¾ Ð¾Ñ‚Ð¿Ñ€Ð°Ð²Ð»ÐµÐ½Ð¾ Ð²Ð°Ð¼, Ñ‚Ð°Ðº ÐºÐ°Ðº Ð² Ð²Ð°ÑˆÑƒ ÑƒÑ‡ÐµÑ‚Ð½ÑƒÑŽ Ð·Ð°Ð¿Ð¸ÑÑŒ Roblox Ð±Ñ‹Ð»Ð° Ð¿Ñ€ÐµÐ´Ð¿Ñ€Ð¸Ð½ÑÑ‚Ð° Ð¿Ð¾Ð¿Ñ‹Ñ‚ÐºÐ° Ð²Ñ…Ð¾Ð´Ð° Ñ‡ÐµÑ€ÐµÐ· Ð´Ñ€ÑƒÐ³Ð¾Ð¹ Ð±Ñ€Ð°ÑƒÐ·ÐµÑ€ Ð¸Ð»Ð¸ Ñ Ð´Ñ€ÑƒÐ³Ð¾Ð³Ð¾ ÑƒÑÑ‚Ñ€Ð¾Ð¹ÑÑ‚Ð²Ð°. Ð•ÑÐ»Ð¸ Ð²Ñ‹ Ð½Ðµ Ð¿Ñ‹Ñ‚Ð°Ð»Ð¸ÑÑŒ Ð²Ð¾Ð¹Ñ‚Ð¸ Ð² Roblox, Ð²Ð¾Ð·Ð¼Ð¾Ð¶Ð½Ð¾, ÐºÑ‚Ð¾-Ñ‚Ð¾ Ð´Ñ€ÑƒÐ³Ð¾Ð¹ Ð¿Ñ‹Ñ‚Ð°Ð»ÑÑ Ð¿Ð¾Ð»ÑƒÑ‡Ð¸Ñ‚ÑŒ Ð´Ð¾ÑÑ‚ÑƒÐ¿ Ðº Ð²Ð°ÑˆÐµÐ¹ ÑƒÑ‡ÐµÑ‚Ð½Ð¾Ð¹ Ð·Ð°Ð¿Ð¸ÑÐ¸. Ð’ ÑÑ‚Ð¾Ð¼ ÑÐ»ÑƒÑ‡Ð°Ðµ Ð¼Ñ‹ Ð½Ð°ÑÑ‚Ð¾ÑÑ‚ÐµÐ»ÑŒÐ½Ð¾ Ñ€ÐµÐºÐ¾Ð¼ÐµÐ½Ð´ÑƒÐµÐ¼ ÑÐ¼ÐµÐ½Ð¸Ñ‚ÑŒ Ð²Ð°Ñˆ Ð¿Ð°Ñ€Ð¾Ð»ÑŒ.{lineBreak}{lineBreak}Ð˜ÑÑ‚Ð¾Ñ‡Ð½Ð¸ÐºÐ¸: {lineBreak}Ð˜Ð·Ð¼ÐµÐ½Ð¸Ñ‚ÑŒ Ð¿Ð°Ñ€Ð¾Ð»ÑŒ [{accountInfoPageLink}] {lineBreak}ÐŸÐ¾Ð´Ñ€Ð¾Ð±Ð½ÐµÐµ Ð¾ Ð´Ð²ÑƒÑ…ÑÑ‚Ð°Ð¿Ð½Ð¾Ð¹ Ð¿Ñ€Ð¾Ð²ÐµÑ€ÐºÐµ [{twoStepVerificationHelpArticleLink}]{lineBreak}ÐžÐ±ÐµÑÐ¿ÐµÑ‡ÐµÐ½Ð¸Ðµ Ð±ÐµÐ·Ð¾Ð¿Ð°ÑÐ½Ð¾ÑÑ‚Ð¸ Ð²Ð°ÑˆÐµÐ¹ ÑƒÑ‡ÐµÑ‚Ð½Ð¾Ð¹ Ð·Ð°Ð¿Ð¸ÑÐ¸ [{keepAccountSafeArticleLink}] {lineBreak}Ð¢ÐµÑ…Ð½Ð¸Ñ‡ÐµÑÐºÐ°Ñ Ð¿Ð¾Ð´Ð´ÐµÑ€Ð¶ÐºÐ° Roblox [{supportPageLink}] {lineBreak}{lineBreak}Ð¡ Ð±Ð»Ð°Ð³Ð¾Ð´Ð°Ñ€Ð½Ð¾ÑÑ‚ÑŒÑŽ, {lineBreak}{lineBreak}ÐšÐ¾Ð¼Ð°Ð½Ð´Ð° Roblox";
	}

	protected override string _GetTemplateForDescriptionTwoStepVerificationLoginEmailPlainBody()
	{
		return "{geoLocationInformation}ÐšÐ¾Ð´ Ð½Ð° Ð²Ñ…Ð¾Ð´ Ð´Ð»Ñ ÑƒÑ‡ÐµÑ‚Ð½Ð¾Ð¹ Ð·Ð°Ð¿Ð¸ÑÐ¸ {accountName}: {lineBreak}{lineBreak} {code} {lineBreak}{lineBreak}Ð’Ð²ÐµÐ´Ð¸Ñ‚Ðµ ÑÑ‚Ð¾Ñ‚ ÐºÐ¾Ð´ Ð½Ð° ÑÐºÑ€Ð°Ð½Ðµ Ð´Ð²ÑƒÑ…ÑÑ‚Ð°Ð¿Ð½Ð¾Ð¹ Ð¿Ñ€Ð¾Ð²ÐµÑ€ÐºÐ¸ Ð´Ð»Ñ Ð·Ð°Ð²ÐµÑ€ÑˆÐµÐ½Ð¸Ñ Ð²Ñ…Ð¾Ð´Ð° Ð² ÑÐ¸ÑÑ‚ÐµÐ¼Ñƒ. Ð¡Ñ€Ð¾Ðº Ð´ÐµÐ¹ÑÑ‚Ð²Ð¸Ñ ÐºÐ¾Ð´Ð° Ð¸ÑÑ‚ÐµÐºÐ°ÐµÑ‚ Ñ‡ÐµÑ€ÐµÐ· 15 Ð¼Ð¸Ð½ÑƒÑ‚. {lineBreak}{lineBreak}Ð­Ñ‚Ð¾ ÑÐ¾Ð¾Ð±Ñ‰ÐµÐ½Ð¸Ðµ Ð±Ñ‹Ð»Ð¾ Ð¾Ñ‚Ð¿Ñ€Ð°Ð²Ð»ÐµÐ½Ð¾ Ð²Ð°Ð¼, Ñ‚Ð°Ðº ÐºÐ°Ðº Ð² Ð²Ð°ÑˆÑƒ ÑƒÑ‡ÐµÑ‚Ð½ÑƒÑŽ Ð·Ð°Ð¿Ð¸ÑÑŒ Roblox Ð±Ñ‹Ð»Ð° Ð¿Ñ€ÐµÐ´Ð¿Ñ€Ð¸Ð½ÑÑ‚Ð° Ð¿Ð¾Ð¿Ñ‹Ñ‚ÐºÐ° Ð²Ñ…Ð¾Ð´Ð° Ñ‡ÐµÑ€ÐµÐ· Ð´Ñ€ÑƒÐ³Ð¾Ð¹ Ð±Ñ€Ð°ÑƒÐ·ÐµÑ€ Ð¸Ð»Ð¸ Ñ Ð´Ñ€ÑƒÐ³Ð¾Ð³Ð¾ ÑƒÑÑ‚Ñ€Ð¾Ð¹ÑÑ‚Ð²Ð°. Ð•ÑÐ»Ð¸ Ð²Ñ‹ Ð½Ðµ Ð¿Ñ‹Ñ‚Ð°Ð»Ð¸ÑÑŒ Ð²Ð¾Ð¹Ñ‚Ð¸ Ð² Roblox, Ð²Ð¾Ð·Ð¼Ð¾Ð¶Ð½Ð¾, ÐºÑ‚Ð¾-Ñ‚Ð¾ Ð´Ñ€ÑƒÐ³Ð¾Ð¹ Ð¿Ñ‹Ñ‚Ð°Ð»ÑÑ Ð¿Ð¾Ð»ÑƒÑ‡Ð¸Ñ‚ÑŒ Ð´Ð¾ÑÑ‚ÑƒÐ¿ Ðº Ð²Ð°ÑˆÐµÐ¹ ÑƒÑ‡ÐµÑ‚Ð½Ð¾Ð¹ Ð·Ð°Ð¿Ð¸ÑÐ¸. Ð’ ÑÑ‚Ð¾Ð¼ ÑÐ»ÑƒÑ‡Ð°Ðµ Ð¼Ñ‹ Ð½Ð°ÑÑ‚Ð¾ÑÑ‚ÐµÐ»ÑŒÐ½Ð¾ Ñ€ÐµÐºÐ¾Ð¼ÐµÐ½Ð´ÑƒÐµÐ¼ ÑÐ¼ÐµÐ½Ð¸Ñ‚ÑŒ Ð²Ð°Ñˆ Ð¿Ð°Ñ€Ð¾Ð»ÑŒ.{lineBreak}{lineBreak}Ð˜ÑÑ‚Ð¾Ñ‡Ð½Ð¸ÐºÐ¸: {lineBreak}Ð˜Ð·Ð¼ÐµÐ½Ð¸Ñ‚ÑŒ Ð¿Ð°Ñ€Ð¾Ð»ÑŒ [{accountInfoPageLink}] {lineBreak}ÐŸÐ¾Ð´Ñ€Ð¾Ð±Ð½ÐµÐµ Ð¾ Ð´Ð²ÑƒÑ…ÑÑ‚Ð°Ð¿Ð½Ð¾Ð¹ Ð¿Ñ€Ð¾Ð²ÐµÑ€ÐºÐµ [{twoStepVerificationHelpArticleLink}]{lineBreak}ÐžÐ±ÐµÑÐ¿ÐµÑ‡ÐµÐ½Ð¸Ðµ Ð±ÐµÐ·Ð¾Ð¿Ð°ÑÐ½Ð¾ÑÑ‚Ð¸ Ð²Ð°ÑˆÐµÐ¹ ÑƒÑ‡ÐµÑ‚Ð½Ð¾Ð¹ Ð·Ð°Ð¿Ð¸ÑÐ¸ [{keepAccountSafeArticleLink}] {lineBreak}Ð¢ÐµÑ…Ð½Ð¸Ñ‡ÐµÑÐºÐ°Ñ Ð¿Ð¾Ð´Ð´ÐµÑ€Ð¶ÐºÐ° Roblox [{supportPageLink}] {lineBreak}{lineBreak}Ð¡ Ð±Ð»Ð°Ð³Ð¾Ð´Ð°Ñ€Ð½Ð¾ÑÑ‚ÑŒÑŽ, {lineBreak}{lineBreak}ÐšÐ¾Ð¼Ð°Ð½Ð´Ð° Roblox";
	}

	/// <summary>
	/// Key: "Description.TwoStepVerificationLoginEmail.PlainText.GeolocationInfo1"
	/// GeoLocation info of IP trying to login
	/// English String: "Login request received from {username} located in {region}, {country} ({ipAddress}).{lineBreak}{lineBreak}"
	/// </summary>
	public override string DescriptionTwoStepVerificationLoginEmailPlainTextGeolocationInfo1(string username, string region, string country, string ipAddress, string lineBreak)
	{
		return $"Ð—Ð°Ð¿Ñ€Ð¾Ñ Ð½Ð° Ð²Ñ…Ð¾Ð´ Ð¿Ð¾Ð»ÑƒÑ‡ÐµÐ½ Ð¾Ñ‚ Ð¿Ð¾Ð»ÑŒÐ·Ð¾Ð²Ð°Ñ‚ÐµÐ»Ñ {username}, Ñ€Ð°ÑÐ¿Ð¾Ð»Ð¾Ð¶ÐµÐ½Ð½Ð¾Ð³Ð¾ Ð² {region}, {country} ({ipAddress}).{lineBreak}{lineBreak}";
	}

	protected override string _GetTemplateForDescriptionTwoStepVerificationLoginEmailPlainTextGeolocationInfo1()
	{
		return "Ð—Ð°Ð¿Ñ€Ð¾Ñ Ð½Ð° Ð²Ñ…Ð¾Ð´ Ð¿Ð¾Ð»ÑƒÑ‡ÐµÐ½ Ð¾Ñ‚ Ð¿Ð¾Ð»ÑŒÐ·Ð¾Ð²Ð°Ñ‚ÐµÐ»Ñ {username}, Ñ€Ð°ÑÐ¿Ð¾Ð»Ð¾Ð¶ÐµÐ½Ð½Ð¾Ð³Ð¾ Ð² {region}, {country} ({ipAddress}).{lineBreak}{lineBreak}";
	}

	/// <summary>
	/// Key: "Description.TwoStepVerificationLoginEmail.PlainText.GeolocationInfo2"
	/// Geolocation info of IP trying to login
	/// English String: "Login request received from {username} located in {country} ({ipAddress}).{lineBreak}{lineBreak}"
	/// </summary>
	public override string DescriptionTwoStepVerificationLoginEmailPlainTextGeolocationInfo2(string username, string country, string ipAddress, string lineBreak)
	{
		return $"Ð—Ð°Ð¿Ñ€Ð¾Ñ Ð½Ð° Ð²Ñ…Ð¾Ð´ Ð¿Ð¾Ð»ÑƒÑ‡ÐµÐ½ Ð¾Ñ‚ Ð¿Ð¾Ð»ÑŒÐ·Ð¾Ð²Ð°Ñ‚ÐµÐ»Ñ {username}, Ñ€Ð°ÑÐ¿Ð¾Ð»Ð¾Ð¶ÐµÐ½Ð½Ð¾Ð³Ð¾ Ð² {country},  ({ipAddress}).{lineBreak}{lineBreak}";
	}

	protected override string _GetTemplateForDescriptionTwoStepVerificationLoginEmailPlainTextGeolocationInfo2()
	{
		return "Ð—Ð°Ð¿Ñ€Ð¾Ñ Ð½Ð° Ð²Ñ…Ð¾Ð´ Ð¿Ð¾Ð»ÑƒÑ‡ÐµÐ½ Ð¾Ñ‚ Ð¿Ð¾Ð»ÑŒÐ·Ð¾Ð²Ð°Ñ‚ÐµÐ»Ñ {username}, Ñ€Ð°ÑÐ¿Ð¾Ð»Ð¾Ð¶ÐµÐ½Ð½Ð¾Ð³Ð¾ Ð² {country},  ({ipAddress}).{lineBreak}{lineBreak}";
	}

	/// <summary>
	/// Key: "Description.TwoStepVerificationLoginEmail.PlainText.GeolocationInfo3"
	/// Geolocation info of IP trying to login
	/// English String: "Login request received from {username} (From Roblox Internal).{lineBreak}{lineBreak}"
	/// </summary>
	public override string DescriptionTwoStepVerificationLoginEmailPlainTextGeolocationInfo3(string username, string lineBreak)
	{
		return $"Ð—Ð°Ð¿Ñ€Ð¾Ñ Ð½Ð° Ð²Ñ…Ð¾Ð´ Ð¿Ð¾Ð»ÑƒÑ‡ÐµÐ½ Ð¾Ñ‚ Ð¿Ð¾Ð»ÑŒÐ·Ð¾Ð²Ð°Ñ‚ÐµÐ»Ñ {username}, (Ð¸Ð· Roblox).{lineBreak}{lineBreak}";
	}

	protected override string _GetTemplateForDescriptionTwoStepVerificationLoginEmailPlainTextGeolocationInfo3()
	{
		return "Ð—Ð°Ð¿Ñ€Ð¾Ñ Ð½Ð° Ð²Ñ…Ð¾Ð´ Ð¿Ð¾Ð»ÑƒÑ‡ÐµÐ½ Ð¾Ñ‚ Ð¿Ð¾Ð»ÑŒÐ·Ð¾Ð²Ð°Ñ‚ÐµÐ»Ñ {username}, (Ð¸Ð· Roblox).{lineBreak}{lineBreak}";
	}

	/// <summary>
	/// Key: "Description.TwoStepVerificationLoginEmail.PlainText.GeolocationInfo4"
	/// Geolocation info of IP trying to login
	/// English String: "Login request received from {username} located in {country}.{lineBreak}{lineBreak}"
	/// </summary>
	public override string DescriptionTwoStepVerificationLoginEmailPlainTextGeolocationInfo4(string username, string country, string lineBreak)
	{
		return $"Ð—Ð°Ð¿Ñ€Ð¾Ñ Ð½Ð° Ð²Ñ…Ð¾Ð´ Ð¿Ð¾Ð»ÑƒÑ‡ÐµÐ½ Ð¾Ñ‚ Ð¿Ð¾Ð»ÑŒÐ·Ð¾Ð²Ð°Ñ‚ÐµÐ»Ñ {username} Ñ€Ð°ÑÐ¿Ð¾Ð»Ð¾Ð¶ÐµÐ½Ð½Ð¾Ð³Ð¾ Ð² ÑÑ‚Ñ€Ð°Ð½Ðµ {country}.{lineBreak}{lineBreak}";
	}

	protected override string _GetTemplateForDescriptionTwoStepVerificationLoginEmailPlainTextGeolocationInfo4()
	{
		return "Ð—Ð°Ð¿Ñ€Ð¾Ñ Ð½Ð° Ð²Ñ…Ð¾Ð´ Ð¿Ð¾Ð»ÑƒÑ‡ÐµÐ½ Ð¾Ñ‚ Ð¿Ð¾Ð»ÑŒÐ·Ð¾Ð²Ð°Ñ‚ÐµÐ»Ñ {username} Ñ€Ð°ÑÐ¿Ð¾Ð»Ð¾Ð¶ÐµÐ½Ð½Ð¾Ð³Ð¾ Ð² ÑÑ‚Ñ€Ð°Ð½Ðµ {country}.{lineBreak}{lineBreak}";
	}

	/// <summary>
	/// Key: "Description.TwoStepVerificationLoginEmail.PlainText.GeolocationInfo5"
	/// Geolocation info of IP trying to login
	/// English String: "Login request received from {username} located in {region}, {country}.{lineBreak}{lineBreak}"
	/// </summary>
	public override string DescriptionTwoStepVerificationLoginEmailPlainTextGeolocationInfo5(string username, string region, string country, string lineBreak)
	{
		return $"Ð—Ð°Ð¿Ñ€Ð¾Ñ Ð½Ð° Ð²Ñ…Ð¾Ð´ Ð¿Ð¾Ð»ÑƒÑ‡ÐµÐ½ Ð¾Ñ‚ Ð¿Ð¾Ð»ÑŒÐ·Ð¾Ð²Ð°Ñ‚ÐµÐ»Ñ {username} Ñ€Ð°ÑÐ¿Ð¾Ð»Ð¾Ð¶ÐµÐ½Ð½Ð¾Ð³Ð¾ Ð² Ñ€ÐµÐ³Ð¸Ð¾Ð½Ðµ {region}, {country}.{lineBreak}{lineBreak}";
	}

	protected override string _GetTemplateForDescriptionTwoStepVerificationLoginEmailPlainTextGeolocationInfo5()
	{
		return "Ð—Ð°Ð¿Ñ€Ð¾Ñ Ð½Ð° Ð²Ñ…Ð¾Ð´ Ð¿Ð¾Ð»ÑƒÑ‡ÐµÐ½ Ð¾Ñ‚ Ð¿Ð¾Ð»ÑŒÐ·Ð¾Ð²Ð°Ñ‚ÐµÐ»Ñ {username} Ñ€Ð°ÑÐ¿Ð¾Ð»Ð¾Ð¶ÐµÐ½Ð½Ð¾Ð³Ð¾ Ð² Ñ€ÐµÐ³Ð¸Ð¾Ð½Ðµ {region}, {country}.{lineBreak}{lineBreak}";
	}

	/// <summary>
	/// Key: "Description.TwoStepVerificationLoginEmail.PlainText.GeolocationInfo6"
	/// Geolocation info of IP trying to login
	/// English String: "Login request received from {username} located in {city}, {region}, {country}.{lineBreak}{lineBreak}"
	/// </summary>
	public override string DescriptionTwoStepVerificationLoginEmailPlainTextGeolocationInfo6(string username, string city, string region, string country, string lineBreak)
	{
		return $"Ð—Ð°Ð¿Ñ€Ð¾Ñ Ð½Ð° Ð²Ñ…Ð¾Ð´ Ð¿Ð¾Ð»ÑƒÑ‡ÐµÐ½ Ð¾Ñ‚ Ð¿Ð¾Ð»ÑŒÐ·Ð¾Ð²Ð°Ñ‚ÐµÐ»Ñ {username} Ñ€Ð°ÑÐ¿Ð¾Ð»Ð¾Ð¶ÐµÐ½Ð½Ð¾Ð³Ð¾ Ð² Ð³Ð¾Ñ€Ð¾Ð´Ðµ {city}, {region}, {country}.{lineBreak}{lineBreak}";
	}

	protected override string _GetTemplateForDescriptionTwoStepVerificationLoginEmailPlainTextGeolocationInfo6()
	{
		return "Ð—Ð°Ð¿Ñ€Ð¾Ñ Ð½Ð° Ð²Ñ…Ð¾Ð´ Ð¿Ð¾Ð»ÑƒÑ‡ÐµÐ½ Ð¾Ñ‚ Ð¿Ð¾Ð»ÑŒÐ·Ð¾Ð²Ð°Ñ‚ÐµÐ»Ñ {username} Ñ€Ð°ÑÐ¿Ð¾Ð»Ð¾Ð¶ÐµÐ½Ð½Ð¾Ð³Ð¾ Ð² Ð³Ð¾Ñ€Ð¾Ð´Ðµ {city}, {region}, {country}.{lineBreak}{lineBreak}";
	}

	/// <summary>
	/// Key: "Description.TwoStepVerificationLoginEmail.Subject"
	/// Subject for 2SV login email
	/// English String: "Verification Code for Roblox Account: {accountName}"
	/// </summary>
	public override string DescriptionTwoStepVerificationLoginEmailSubject(string accountName)
	{
		return $"Ð˜Ð´ÐµÐ½Ñ‚Ð¸Ñ„Ð¸ÐºÐ°Ñ†Ð¸Ð¾Ð½Ð½Ñ‹Ð¹ ÐºÐ¾Ð´ Ð´Ð»Ñ ÑƒÑ‡ÐµÑ‚Ð½Ð¾Ð¹ Ð·Ð°Ð¿Ð¸ÑÐ¸ Roblox: {accountName}";
	}

	protected override string _GetTemplateForDescriptionTwoStepVerificationLoginEmailSubject()
	{
		return "Ð˜Ð´ÐµÐ½Ñ‚Ð¸Ñ„Ð¸ÐºÐ°Ñ†Ð¸Ð¾Ð½Ð½Ñ‹Ð¹ ÐºÐ¾Ð´ Ð´Ð»Ñ ÑƒÑ‡ÐµÑ‚Ð½Ð¾Ð¹ Ð·Ð°Ð¿Ð¸ÑÐ¸ Roblox: {accountName}";
	}

	protected override string _GetTemplateForLabelCode()
	{
		return "ÐšÐ¾Ð´";
	}

	/// <summary>
	/// Key: "Label.CodeInputPlaceholderText"
	/// example: Enter 4-digit code
	/// English String: "Enter {codeLength}-digit Code"
	/// </summary>
	public override string LabelCodeInputPlaceholderText(string codeLength)
	{
		return $"Ð’Ð²ÐµÐ´Ð¸Ñ‚Ðµ {codeLength}-Ð·Ð½Ð°Ñ‡Ð½Ñ‹Ð¹ ÐºÐ¾Ð´";
	}

	protected override string _GetTemplateForLabelCodeInputPlaceholderText()
	{
		return "Ð’Ð²ÐµÐ´Ð¸Ñ‚Ðµ {codeLength}-Ð·Ð½Ð°Ñ‡Ð½Ñ‹Ð¹ ÐºÐ¾Ð´";
	}

	protected override string _GetTemplateForLabelDidNotReceive()
	{
		return "ÐÐµ Ð¿Ð¾Ð»ÑƒÑ‡Ð¸Ð»Ð¸ ÐºÐ¾Ð´?";
	}

	protected override string _GetTemplateForLabelEnterCode()
	{
		return "Ð’Ð²ÐµÐ´Ð¸Ñ‚Ðµ ÐºÐ¾Ð´ (6 Ñ†Ð¸Ñ„Ñ€)";
	}

	protected override string _GetTemplateForLabelEnterEmailCode()
	{
		return "Ð’Ð²ÐµÐ´Ð¸Ñ‚Ðµ ÐºÐ¾Ð´, Ð¾Ñ‚Ð¿Ñ€Ð°Ð²Ð»ÐµÐ½Ð½Ñ‹Ð¹ Ð²Ð°Ð¼ Ð¿Ð¾ ÑÐ»ÐµÐºÑ‚Ñ€Ð¾Ð½Ð½Ð¾Ð¹ Ð¿Ð¾Ñ‡Ñ‚Ðµ";
	}

	protected override string _GetTemplateForLabelEnterTextCode()
	{
		return "Ð’Ð²ÐµÐ´Ð¸Ñ‚Ðµ ÐºÐ¾Ð´, Ð¾Ñ‚Ð¿Ñ€Ð°Ð²Ð»ÐµÐ½Ð½Ñ‹Ð¹ Ð²Ð°Ð¼ Ð² ÑÐ¾Ð¾Ð±Ñ‰ÐµÐ½Ð¸Ð¸";
	}

	protected override string _GetTemplateForLabelEnterTwoStepVerificationCode()
	{
		return "Ð’Ð²ÐµÐ´Ð¸Ñ‚Ðµ ÐºÐ¾Ð´ Ð´Ð²ÑƒÑ…ÑÑ‚Ð°Ð¿Ð½Ð¾Ð¹ Ð¸Ð´ÐµÐ½Ñ‚Ð¸Ñ„Ð¸ÐºÐ°Ñ†Ð¸Ð¸.";
	}

	protected override string _GetTemplateForLabelFacebookPasswordWarning()
	{
		return "Ð•ÑÐ»Ð¸ Ð²Ñ‹ Ð¸ÑÐ¿Ð¾Ð»ÑŒÐ·Ð¾Ð²Ð°Ð»Ð¸ ÑƒÑ‡ÐµÑ‚Ð½ÑƒÑŽ Ð·Ð°Ð¿Ð¸ÑÑŒ Facebook, Ð½ÐµÐ¾Ð±Ñ…Ð¾Ð´Ð¸Ð¼Ð¾ ÑƒÐºÐ°Ð·Ð°Ñ‚ÑŒ Ð¿Ð°Ñ€Ð¾Ð»ÑŒ.";
	}

	protected override string _GetTemplateForLabelLearnMore()
	{
		return "ÐŸÐ¾Ð´Ñ€Ð¾Ð±Ð½ÐµÐµ";
	}

	/// <summary>
	/// Key: "Label.NeedHelpContactSupport"
	/// label for the support article link
	/// English String: "Need help? Contact {supportLink}"
	/// </summary>
	public override string LabelNeedHelpContactSupport(string supportLink)
	{
		return $"Ð¢Ñ€ÐµÐ±ÑƒÐµÑ‚ÑÑ Ð¿Ð¾Ð¼Ð¾Ñ‰ÑŒ? ÐžÐ±Ñ€Ð°Ñ‚Ð¸Ñ‚ÐµÑÑŒ: {supportLink}";
	}

	protected override string _GetTemplateForLabelNeedHelpContactSupport()
	{
		return "Ð¢Ñ€ÐµÐ±ÑƒÐµÑ‚ÑÑ Ð¿Ð¾Ð¼Ð¾Ñ‰ÑŒ? ÐžÐ±Ñ€Ð°Ñ‚Ð¸Ñ‚ÐµÑÑŒ: {supportLink}";
	}

	protected override string _GetTemplateForLabelNewCode()
	{
		return "ÐÐ¾Ð²Ñ‹Ð¹ ÐºÐ¾Ð´";
	}

	protected override string _GetTemplateForLabelRobloxSupport()
	{
		return "Ð¡Ð»ÑƒÐ¶Ð±Ð° Ð¿Ð¾Ð´Ð´ÐµÑ€Ð¶ÐºÐ¸ Roblox";
	}

	protected override string _GetTemplateForLabelTrustThisDevice()
	{
		return "Ð¡Ñ‡Ð¸Ñ‚Ð°Ñ‚ÑŒ ÑƒÑÑ‚Ñ€Ð¾Ð¹ÑÑ‚Ð²Ð¾ Ð¿Ñ€Ð¾Ð²ÐµÑ€ÐµÐ½Ð½Ñ‹Ð¼ 30 Ð´Ð½ÐµÐ¹";
	}

	protected override string _GetTemplateForLabelTwoStepVerification()
	{
		return "Ð”Ð²ÑƒÑ…ÑÑ‚Ð°Ð¿Ð½Ð°Ñ Ð¿Ñ€Ð¾Ð²ÐµÑ€ÐºÐ°";
	}

	protected override string _GetTemplateForResponseCodeSent()
	{
		return "ÐšÐ¾Ð´ Ð¾Ñ‚Ð¿Ñ€Ð°Ð²Ð»ÐµÐ½";
	}

	protected override string _GetTemplateForResponseFeatureNotAvailable()
	{
		return "Ð¤ÑƒÐ½ÐºÑ†Ð¸Ñ Ð½ÐµÐ´Ð¾ÑÑ‚ÑƒÐ¿Ð½Ð°. ÐžÐ±Ñ€Ð°Ñ‚Ð¸Ñ‚ÐµÑÑŒ Ð² ÑÐ»ÑƒÐ¶Ð±Ñƒ Ð¿Ð¾Ð´Ð´ÐµÑ€Ð¶ÐºÐ¸.";
	}

	protected override string _GetTemplateForResponseInvalidCode()
	{
		return "ÐÐµÐ´Ð¾Ð¿ÑƒÑÑ‚Ð¸Ð¼Ñ‹Ð¹ ÐºÐ¾Ð´";
	}

	protected override string _GetTemplateForResponseSystemErrorReturnToLogin()
	{
		return "ÐžÑˆÐ¸Ð±ÐºÐ° ÑÐ¸ÑÑ‚ÐµÐ¼Ñ‹. Ð’ÐµÑ€Ð½Ð¸Ñ‚ÐµÑÑŒ Ð½Ð° ÑÐºÑ€Ð°Ð½ Ð²Ñ…Ð¾Ð´Ð°.";
	}

	protected override string _GetTemplateForResponseTooManyAttempts()
	{
		return "Ð¡Ð»Ð¸ÑˆÐºÐ¾Ð¼ Ð¼Ð½Ð¾Ð³Ð¾ Ð¿Ð¾Ð¿Ñ‹Ñ‚Ð¾Ðº. ÐŸÐ¾Ð²Ñ‚Ð¾Ñ€Ð¸Ñ‚Ðµ Ð¿Ð¾Ð¿Ñ‹Ñ‚ÐºÑƒ Ð¿Ð¾Ð·Ð¶Ðµ.";
	}

	protected override string _GetTemplateForResponseTooManyCharacters()
	{
		return "Ð¡Ð»Ð¸ÑˆÐºÐ¾Ð¼ Ð¼Ð½Ð¾Ð³Ð¾ ÑÐ¸Ð¼Ð²Ð¾Ð»Ð¾Ð²";
	}
}


}
