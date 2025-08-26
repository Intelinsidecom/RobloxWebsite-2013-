namespace Roblox.Platform.TranslationResources.Authentication {
    /// <summary>

/// This class overrides TwoStepVerificationResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class TwoStepVerificationResources_th_th : TwoStepVerificationResources_en_us, ITwoStepVerificationResources, ITranslationResources
{
	/// <summary>
	/// Key: "Action.Cancel"
	/// English String: "Cancel"
	/// </summary>
	public override string ActionCancel => "à¸¢à¸à¹€à¸¥\u0e34à¸";

	/// <summary>
	/// Key: "Action.Resend"
	/// English String: "Resend Code"
	/// </summary>
	public override string ActionResend => "à¸ª\u0e48à¸‡à¸£à¸«\u0e31à¸ªà¹ƒà¸«à¸¡\u0e48";

	/// <summary>
	/// Key: "Action.StartOver"
	/// link text to restart verification
	/// English String: "Start Over"
	/// </summary>
	public override string ActionStartOver => "à¹€à¸£\u0e34\u0e48à¸¡à¸•\u0e49à¸™à¹ƒà¸«à¸¡\u0e48à¸«à¸¡à¸”";

	/// <summary>
	/// Key: "Action.Submit"
	/// submit button text
	/// English String: "Submit"
	/// </summary>
	public override string ActionSubmit => "à¸ª\u0e48à¸‡";

	/// <summary>
	/// Key: "Action.Verify"
	/// English String: "Verify"
	/// </summary>
	public override string ActionVerify => "à¸•à¸£à¸§à¸ˆà¸ªà¸­à¸š";

	/// <summary>
	/// Key: "Label.Code"
	/// verification code for 2 factor authentication
	/// English String: "Code"
	/// </summary>
	public override string LabelCode => "à¸£à¸«\u0e31à¸ª";

	/// <summary>
	/// Key: "Label.DidNotReceive"
	/// English String: "Didn't receive the code?"
	/// </summary>
	public override string LabelDidNotReceive => "à¹„à¸¡\u0e48à¹„à¸”\u0e49à¸£\u0e31à¸šà¸£à¸«\u0e31à¸ª?";

	/// <summary>
	/// Key: "Label.EnterCode"
	/// English String: "Enter Code (6-digit)"
	/// </summary>
	public override string LabelEnterCode => "à¸›\u0e49à¸­à¸™à¸£à¸«\u0e31à¸ª (6 à¸«à¸¥\u0e31à¸)";

	/// <summary>
	/// Key: "Label.EnterEmailCode"
	/// English String: "Enter the code we just sent you via email"
	/// </summary>
	public override string LabelEnterEmailCode => "à¸›\u0e49à¸­à¸™à¸£à¸«\u0e31à¸ªà¸—\u0e35\u0e48à¹€à¸£à¸²à¹€à¸ž\u0e34\u0e48à¸‡à¸ª\u0e48à¸‡à¹ƒà¸«\u0e49à¸„\u0e38à¸“à¸—à¸²à¸‡à¸­\u0e35à¹€à¸¡à¸¥";

	/// <summary>
	/// Key: "Label.EnterTextCode"
	/// English String: "Enter the code we just sent you via text message"
	/// </summary>
	public override string LabelEnterTextCode => "à¸›\u0e49à¸­à¸™à¸£à¸«\u0e31à¸ªà¸—\u0e35\u0e48à¹€à¸£à¸²à¹€à¸ž\u0e34\u0e48à¸‡à¸ª\u0e48à¸‡à¹ƒà¸«\u0e49à¸„\u0e38à¸“à¸—à¸²à¸‡à¸à¸²à¸£à¸ª\u0e48à¸‡à¸‚\u0e49à¸­à¸„à¸§à¸²à¸¡";

	/// <summary>
	/// Key: "Label.EnterTwoStepVerificationCode"
	/// Enter your two step verification code.
	/// English String: "Enter your two step verification code."
	/// </summary>
	public override string LabelEnterTwoStepVerificationCode => "à¸›\u0e49à¸­à¸™à¸£à¸«\u0e31à¸ªà¸à¸²à¸£à¸¢\u0e37à¸™à¸¢\u0e31à¸™à¸ªà¸­à¸‡à¸‚\u0e31\u0e49à¸™à¸•à¸­à¸™à¸‚à¸­à¸‡à¸„\u0e38à¸“";

	/// <summary>
	/// Key: "Label.FacebookPasswordWarning"
	/// If you have been signing in with Facebook, you must set a password.
	/// English String: "If you have been signing in with Facebook, you must set a password."
	/// </summary>
	public override string LabelFacebookPasswordWarning => "à¸«à¸²à¸à¸„\u0e38à¸“à¹„à¸”\u0e49à¹ƒà¸Š\u0e49à¸à¸²à¸£à¸¥à¸‡à¸Š\u0e37\u0e48à¸­à¹€à¸‚\u0e49à¸²à¸ª\u0e39\u0e48à¸£à¸°à¸šà¸šà¸”\u0e49à¸§à¸¢ Facebook à¸¡à¸²à¸\u0e48à¸­à¸™ à¸„\u0e38à¸“à¸ˆà¸°à¸•\u0e49à¸­à¸‡à¸•\u0e31\u0e49à¸‡à¸£à¸«\u0e31à¸ªà¸œ\u0e48à¸²à¸™";

	/// <summary>
	/// Key: "Label.LearnMore"
	/// Learn More link text
	/// English String: "Learn More"
	/// </summary>
	public override string LabelLearnMore => "à¹€à¸£\u0e35à¸¢à¸™à¸£\u0e39\u0e49à¹€à¸ž\u0e34\u0e48à¸¡à¹€à¸•\u0e34à¸¡";

	/// <summary>
	/// Key: "Label.NewCode"
	/// verification code resent, label changes to new code
	/// English String: "New Code"
	/// </summary>
	public override string LabelNewCode => "à¸£à¸«\u0e31à¸ªà¹ƒà¸«à¸¡\u0e48";

	/// <summary>
	/// Key: "Label.RobloxSupport"
	/// English String: "Roblox Support"
	/// </summary>
	public override string LabelRobloxSupport => "à¸\u0e48à¸²à¸¢à¸ªà¸™\u0e31à¸šà¸ªà¸™\u0e38à¸™ Roblox";

	/// <summary>
	/// Key: "Label.TrustThisDevice"
	/// English String: "Trust this device for 30 days"
	/// </summary>
	public override string LabelTrustThisDevice => "à¹€à¸Š\u0e37\u0e48à¸­à¸­\u0e38à¸›à¸à¸£à¸“\u0e4cà¸™\u0e35\u0e49à¹€à¸›\u0e47à¸™à¹€à¸§à¸¥à¸² 30 à¸§\u0e31à¸™";

	/// <summary>
	/// Key: "Label.TwoStepVerification"
	/// English String: "2-Step Verification"
	/// </summary>
	public override string LabelTwoStepVerification => "à¸à¸²à¸£à¸•à¸£à¸§à¸ˆà¸ªà¸­à¸šà¸¢\u0e37à¸™à¸¢\u0e31à¸™à¸•\u0e31à¸§à¸•à¸™ 2 à¸‚\u0e31\u0e49à¸™";

	/// <summary>
	/// Key: "Response.CodeSent"
	/// English String: "Code Sent"
	/// </summary>
	public override string ResponseCodeSent => "à¸ª\u0e48à¸‡à¸£à¸«\u0e31à¸ªà¹à¸¥\u0e49à¸§";

	/// <summary>
	/// Key: "Response.FeatureNotAvailable"
	/// English String: "Feature not available. Please contact support."
	/// </summary>
	public override string ResponseFeatureNotAvailable => "à¸Ÿ\u0e35à¹€à¸ˆà¸­à¸£\u0e4cà¹„à¸¡\u0e48à¸žà¸£\u0e49à¸­à¸¡à¹ƒà¸Š\u0e49à¸‡à¸²à¸™ à¸à¸£\u0e38à¸“à¸²à¸•\u0e34à¸”à¸•\u0e48à¸­à¸\u0e48à¸²à¸¢à¸ªà¸™\u0e31à¸šà¸ªà¸™\u0e38à¸™";

	/// <summary>
	/// Key: "Response.InvalidCode"
	/// English String: "Invalid code."
	/// </summary>
	public override string ResponseInvalidCode => "à¸£à¸«\u0e31à¸ªà¹„à¸¡\u0e48à¸–\u0e39à¸à¸•\u0e49à¸­à¸‡";

	/// <summary>
	/// Key: "Response.SystemErrorReturnToLogin"
	/// English String: "System error. Please return to login screen."
	/// </summary>
	public override string ResponseSystemErrorReturnToLogin => "à¹€à¸\u0e34à¸”à¸‚\u0e49à¸­à¸œ\u0e34à¸”à¸žà¸¥à¸²à¸”à¸\u0e31à¸šà¸£à¸°à¸šà¸š à¸à¸£\u0e38à¸“à¸²à¸à¸¥\u0e31à¸šà¸ª\u0e39\u0e48à¸«à¸™\u0e49à¸²à¸à¸²à¸£à¹€à¸‚\u0e49à¸²à¸ª\u0e39\u0e48à¸£à¸°à¸šà¸š";

	/// <summary>
	/// Key: "Response.TooManyAttempts"
	/// English String: "Too many attempts. Please try again later."
	/// </summary>
	public override string ResponseTooManyAttempts => "à¸¡\u0e35à¸à¸²à¸£à¸”à¸³à¹€à¸™\u0e34à¸™à¸à¸²à¸£à¸‹\u0e49à¸³à¸¡à¸²à¸à¹€à¸\u0e34à¸™à¹„à¸› à¸à¸£\u0e38à¸“à¸²à¸¥à¸­à¸‡à¹ƒà¸«à¸¡\u0e48à¸­\u0e35à¸à¸„à¸£\u0e31\u0e49à¸‡à¹ƒà¸™à¸ à¸²à¸¢à¸«à¸¥\u0e31à¸‡";

	/// <summary>
	/// Key: "Response.TooManyCharacters"
	/// error message
	/// English String: "Too many characters"
	/// </summary>
	public override string ResponseTooManyCharacters => "à¸¡\u0e35à¸­\u0e31à¸à¸‚à¸£à¸°à¸¡à¸²à¸à¹€à¸\u0e34à¸™à¹„à¸›";

	public TwoStepVerificationResources_th_th(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionCancel()
	{
		return "à¸¢à¸à¹€à¸¥\u0e34à¸";
	}

	protected override string _GetTemplateForActionResend()
	{
		return "à¸ª\u0e48à¸‡à¸£à¸«\u0e31à¸ªà¹ƒà¸«à¸¡\u0e48";
	}

	protected override string _GetTemplateForActionStartOver()
	{
		return "à¹€à¸£\u0e34\u0e48à¸¡à¸•\u0e49à¸™à¹ƒà¸«à¸¡\u0e48à¸«à¸¡à¸”";
	}

	protected override string _GetTemplateForActionSubmit()
	{
		return "à¸ª\u0e48à¸‡";
	}

	protected override string _GetTemplateForActionVerify()
	{
		return "à¸•à¸£à¸§à¸ˆà¸ªà¸­à¸š";
	}

	/// <summary>
	/// Key: "Description.TwoStepVerificationActivationEmail.Body.Over13"
	/// Body for 2SV activation email for over 13 users
	/// English String: "Hi {accountName},{lineBreak}{lineBreak}You have activated 2-Step Verification for your Roblox account. Next time you log in from a new device, you will need to enter a 6-digit security code that Roblox sends to you via email.{lineBreak}{lineBreak}Roblox"
	/// </summary>
	public override string DescriptionTwoStepVerificationActivationEmailBodyOver13(string accountName, string lineBreak)
	{
		return $"à¸ªà¸§\u0e31à¸ªà¸”\u0e35 {accountName}{lineBreak}{lineBreak}à¸„\u0e38à¸“à¹€à¸›\u0e34à¸”à¸à¸²à¸£à¹ƒà¸Š\u0e49à¸‡à¸²à¸™à¸à¸²à¸£à¸•à¸£à¸§à¸ˆà¸ªà¸­à¸šà¸¢\u0e37à¸™à¸¢\u0e31à¸™à¸•\u0e31à¸§à¸•à¸™ 2 à¸‚\u0e31\u0e49à¸™à¸ªà¸³à¸«à¸£\u0e31à¸šà¸š\u0e31à¸à¸Š\u0e35 Roblox à¸‚à¸­à¸‡à¸„\u0e38à¸“ à¸„à¸£\u0e31\u0e49à¸‡à¸–\u0e31à¸”à¹„à¸›à¸—\u0e35\u0e48à¸„\u0e38à¸“à¹€à¸‚\u0e49à¸²à¸ª\u0e39\u0e48à¸£à¸°à¸šà¸šà¸ˆà¸²à¸à¸­\u0e38à¸›à¸à¸£à¸“\u0e4cà¹ƒà¸«à¸¡\u0e48 à¸„\u0e38à¸“à¸\u0e47à¸ˆà¸°à¸•\u0e49à¸­à¸‡à¸›\u0e49à¸­à¸™à¸£à¸«\u0e31à¸ªà¸£\u0e31à¸à¸©à¸²à¸„à¸§à¸²à¸¡à¸›à¸¥à¸­à¸”à¸ \u0e31à¸¢ 6 à¸«à¸¥\u0e31à¸à¸—\u0e35\u0e48à¸—à¸²à¸‡ Roblox à¹„à¸”\u0e49à¸ª\u0e48à¸‡à¹ƒà¸«\u0e49à¸\u0e31à¸šà¸„\u0e38à¸“à¸—à¸²à¸‡à¸­\u0e35à¹€à¸¡à¸¥{lineBreak}{lineBreak}Roblox";
	}

	protected override string _GetTemplateForDescriptionTwoStepVerificationActivationEmailBodyOver13()
	{
		return "à¸ªà¸§\u0e31à¸ªà¸”\u0e35 {accountName}{lineBreak}{lineBreak}à¸„\u0e38à¸“à¹€à¸›\u0e34à¸”à¸à¸²à¸£à¹ƒà¸Š\u0e49à¸‡à¸²à¸™à¸à¸²à¸£à¸•à¸£à¸§à¸ˆà¸ªà¸­à¸šà¸¢\u0e37à¸™à¸¢\u0e31à¸™à¸•\u0e31à¸§à¸•à¸™ 2 à¸‚\u0e31\u0e49à¸™à¸ªà¸³à¸«à¸£\u0e31à¸šà¸š\u0e31à¸à¸Š\u0e35 Roblox à¸‚à¸­à¸‡à¸„\u0e38à¸“ à¸„à¸£\u0e31\u0e49à¸‡à¸–\u0e31à¸”à¹„à¸›à¸—\u0e35\u0e48à¸„\u0e38à¸“à¹€à¸‚\u0e49à¸²à¸ª\u0e39\u0e48à¸£à¸°à¸šà¸šà¸ˆà¸²à¸à¸­\u0e38à¸›à¸à¸£à¸“\u0e4cà¹ƒà¸«à¸¡\u0e48 à¸„\u0e38à¸“à¸\u0e47à¸ˆà¸°à¸•\u0e49à¸­à¸‡à¸›\u0e49à¸­à¸™à¸£à¸«\u0e31à¸ªà¸£\u0e31à¸à¸©à¸²à¸„à¸§à¸²à¸¡à¸›à¸¥à¸­à¸”à¸ \u0e31à¸¢ 6 à¸«à¸¥\u0e31à¸à¸—\u0e35\u0e48à¸—à¸²à¸‡ Roblox à¹„à¸”\u0e49à¸ª\u0e48à¸‡à¹ƒà¸«\u0e49à¸\u0e31à¸šà¸„\u0e38à¸“à¸—à¸²à¸‡à¸­\u0e35à¹€à¸¡à¸¥{lineBreak}{lineBreak}Roblox";
	}

	/// <summary>
	/// Key: "Description.TwoStepVerificationActivationEmail.Body.Under13"
	/// Body for 2SV activation email for under 13 users
	/// English String: "Hi,{lineBreak}{lineBreak}2-Step Verification has been activated for your child's Roblox account, {accountName}. Next time they log in from a new device, they will need to enter a 6-digit security code that Roblox sends to you via email.{lineBreak}{lineBreak}Roblox"
	/// </summary>
	public override string DescriptionTwoStepVerificationActivationEmailBodyUnder13(string lineBreak, string accountName)
	{
		return $"à¸ªà¸§\u0e31à¸ªà¸”\u0e35{lineBreak}{lineBreak}à¸¡\u0e35à¸à¸²à¸£à¹€à¸›\u0e34à¸”à¸à¸²à¸£à¹ƒà¸Š\u0e49à¸‡à¸²à¸™à¸à¸²à¸£à¸•à¸£à¸§à¸ˆà¸ªà¸­à¸šà¸¢\u0e37à¸™à¸¢\u0e31à¸™à¸•\u0e31à¸§à¸•à¸™ 2 à¸‚\u0e31\u0e49à¸™à¸ªà¸³à¸«à¸£\u0e31à¸šà¸š\u0e31à¸à¸Š\u0e35à¸¥\u0e39à¸à¸‚à¸­à¸‡ Roblox à¸‚à¸­à¸‡à¸„\u0e38à¸“ {accountName} à¸„à¸£\u0e31\u0e49à¸‡à¸–\u0e31à¸”à¹„à¸›à¸—\u0e35\u0e48à¸žà¸§à¸à¹€à¸‚à¸²à¹€à¸‚\u0e49à¸²à¸ª\u0e39\u0e48à¸£à¸°à¸šà¸šà¸ˆà¸²à¸à¸­\u0e38à¸›à¸à¸£à¸“\u0e4cà¹ƒà¸«à¸¡\u0e48 à¸žà¸§à¸à¹€à¸‚à¸²à¸\u0e47à¸ˆà¸°à¸•\u0e49à¸­à¸‡à¸›\u0e49à¸­à¸™à¸£à¸«\u0e31à¸ªà¸£\u0e31à¸à¸©à¸²à¸„à¸§à¸²à¸¡à¸›à¸¥à¸­à¸”à¸ \u0e31à¸¢ 6 à¸«à¸¥\u0e31à¸à¸—\u0e35\u0e48à¸—à¸²à¸‡ Roblox à¹„à¸”\u0e49à¸ª\u0e48à¸‡à¹ƒà¸«\u0e49à¸\u0e31à¸šà¸„\u0e38à¸“à¸—à¸²à¸‡à¸­\u0e35à¹€à¸¡à¸¥{lineBreak}{lineBreak}Roblox";
	}

	protected override string _GetTemplateForDescriptionTwoStepVerificationActivationEmailBodyUnder13()
	{
		return "à¸ªà¸§\u0e31à¸ªà¸”\u0e35{lineBreak}{lineBreak}à¸¡\u0e35à¸à¸²à¸£à¹€à¸›\u0e34à¸”à¸à¸²à¸£à¹ƒà¸Š\u0e49à¸‡à¸²à¸™à¸à¸²à¸£à¸•à¸£à¸§à¸ˆà¸ªà¸­à¸šà¸¢\u0e37à¸™à¸¢\u0e31à¸™à¸•\u0e31à¸§à¸•à¸™ 2 à¸‚\u0e31\u0e49à¸™à¸ªà¸³à¸«à¸£\u0e31à¸šà¸š\u0e31à¸à¸Š\u0e35à¸¥\u0e39à¸à¸‚à¸­à¸‡ Roblox à¸‚à¸­à¸‡à¸„\u0e38à¸“ {accountName} à¸„à¸£\u0e31\u0e49à¸‡à¸–\u0e31à¸”à¹„à¸›à¸—\u0e35\u0e48à¸žà¸§à¸à¹€à¸‚à¸²à¹€à¸‚\u0e49à¸²à¸ª\u0e39\u0e48à¸£à¸°à¸šà¸šà¸ˆà¸²à¸à¸­\u0e38à¸›à¸à¸£à¸“\u0e4cà¹ƒà¸«à¸¡\u0e48 à¸žà¸§à¸à¹€à¸‚à¸²à¸\u0e47à¸ˆà¸°à¸•\u0e49à¸­à¸‡à¸›\u0e49à¸­à¸™à¸£à¸«\u0e31à¸ªà¸£\u0e31à¸à¸©à¸²à¸„à¸§à¸²à¸¡à¸›à¸¥à¸­à¸”à¸ \u0e31à¸¢ 6 à¸«à¸¥\u0e31à¸à¸—\u0e35\u0e48à¸—à¸²à¸‡ Roblox à¹„à¸”\u0e49à¸ª\u0e48à¸‡à¹ƒà¸«\u0e49à¸\u0e31à¸šà¸„\u0e38à¸“à¸—à¸²à¸‡à¸­\u0e35à¹€à¸¡à¸¥{lineBreak}{lineBreak}Roblox";
	}

	/// <summary>
	/// Key: "Description.TwoStepVerificationActivationEmail.Subject"
	/// Subject for 2SV activation email
	/// English String: "2-Step Verification Activated for Roblox Account: {accountName}"
	/// </summary>
	public override string DescriptionTwoStepVerificationActivationEmailSubject(string accountName)
	{
		return $"à¹€à¸›\u0e34à¸”à¸à¸²à¸£à¸—à¸³à¸‡à¸²à¸™à¸à¸²à¸£à¸•à¸£à¸§à¸ˆà¸ªà¸­à¸šà¸¢\u0e37à¸™à¸¢\u0e31à¸™à¸•\u0e31à¸§à¸•à¸™ 2 à¸‚\u0e31\u0e49à¸™à¸ªà¸³à¸«à¸£\u0e31à¸šà¸š\u0e31à¸à¸Š\u0e35 Roblox à¹à¸¥\u0e49à¸§: {accountName}";
	}

	protected override string _GetTemplateForDescriptionTwoStepVerificationActivationEmailSubject()
	{
		return "à¹€à¸›\u0e34à¸”à¸à¸²à¸£à¸—à¸³à¸‡à¸²à¸™à¸à¸²à¸£à¸•à¸£à¸§à¸ˆà¸ªà¸­à¸šà¸¢\u0e37à¸™à¸¢\u0e31à¸™à¸•\u0e31à¸§à¸•à¸™ 2 à¸‚\u0e31\u0e49à¸™à¸ªà¸³à¸«à¸£\u0e31à¸šà¸š\u0e31à¸à¸Š\u0e35 Roblox à¹à¸¥\u0e49à¸§: {accountName}";
	}

	/// <summary>
	/// Key: "Description.TwoStepVerificationDeactivationEmail.Body.Over13"
	/// Body for 2SV deactivation email for over 13 users
	/// English String: "Hi {accountName},{lineBreak}{lineBreak}You have deactivated 2-Step Verification for your Roblox account. A security code will no longer be required when you log into your account.{lineBreak}{lineBreak}Roblox"
	/// </summary>
	public override string DescriptionTwoStepVerificationDeactivationEmailBodyOver13(string accountName, string lineBreak)
	{
		return $"à¸ªà¸§\u0e31à¸ªà¸”\u0e35{accountName}{lineBreak}{lineBreak}à¸„\u0e38à¸“à¸›\u0e34à¸”à¸à¸²à¸£à¹ƒà¸Š\u0e49à¸‡à¸²à¸™à¸à¸²à¸£à¸•à¸£à¸§à¸ˆà¸ªà¸­à¸šà¸¢\u0e37à¸™à¸¢\u0e31à¸™à¸•\u0e31à¸§à¸•à¸™ 2 à¸‚\u0e31\u0e49à¸™à¸ªà¸³à¸«à¸£\u0e31à¸šà¸š\u0e31à¸à¸Š\u0e35 Roblox à¸‚à¸­à¸‡à¸„\u0e38à¸“ à¸„\u0e38à¸“à¸ˆà¸°à¹„à¸¡\u0e48à¸ˆà¸³à¹€à¸›\u0e47à¸™à¸•\u0e49à¸­à¸‡à¸›\u0e49à¸­à¸™à¸£à¸«\u0e31à¸ªà¸£\u0e31à¸à¸©à¸²à¸„à¸§à¸²à¸¡à¸›à¸¥à¸­à¸”à¸ \u0e31à¸¢à¸ªà¸³à¸«à¸£\u0e31à¸šà¸à¸²à¸£à¹€à¸‚\u0e49à¸²à¸ª\u0e39\u0e48à¸š\u0e31à¸à¸Š\u0e35à¸‚à¸­à¸‡à¸„\u0e38à¸“à¸­\u0e35à¸à¸•\u0e48à¸­à¹„à¸›{lineBreak}{lineBreak}Roblox";
	}

	protected override string _GetTemplateForDescriptionTwoStepVerificationDeactivationEmailBodyOver13()
	{
		return "à¸ªà¸§\u0e31à¸ªà¸”\u0e35{accountName}{lineBreak}{lineBreak}à¸„\u0e38à¸“à¸›\u0e34à¸”à¸à¸²à¸£à¹ƒà¸Š\u0e49à¸‡à¸²à¸™à¸à¸²à¸£à¸•à¸£à¸§à¸ˆà¸ªà¸­à¸šà¸¢\u0e37à¸™à¸¢\u0e31à¸™à¸•\u0e31à¸§à¸•à¸™ 2 à¸‚\u0e31\u0e49à¸™à¸ªà¸³à¸«à¸£\u0e31à¸šà¸š\u0e31à¸à¸Š\u0e35 Roblox à¸‚à¸­à¸‡à¸„\u0e38à¸“ à¸„\u0e38à¸“à¸ˆà¸°à¹„à¸¡\u0e48à¸ˆà¸³à¹€à¸›\u0e47à¸™à¸•\u0e49à¸­à¸‡à¸›\u0e49à¸­à¸™à¸£à¸«\u0e31à¸ªà¸£\u0e31à¸à¸©à¸²à¸„à¸§à¸²à¸¡à¸›à¸¥à¸­à¸”à¸ \u0e31à¸¢à¸ªà¸³à¸«à¸£\u0e31à¸šà¸à¸²à¸£à¹€à¸‚\u0e49à¸²à¸ª\u0e39\u0e48à¸š\u0e31à¸à¸Š\u0e35à¸‚à¸­à¸‡à¸„\u0e38à¸“à¸­\u0e35à¸à¸•\u0e48à¸­à¹„à¸›{lineBreak}{lineBreak}Roblox";
	}

	/// <summary>
	/// Key: "Description.TwoStepVerificationDeactivationEmail.Body.Under13"
	/// Body for 2SV deactivation email for under 13 users
	/// English String: "Hi,{lineBreak}{lineBreak}2-Step Verification has been deactivated for your child's Roblox account, {accountName}. A security code will no longer be required when they log into the account.{lineBreak}{lineBreak}Roblox"
	/// </summary>
	public override string DescriptionTwoStepVerificationDeactivationEmailBodyUnder13(string lineBreak, string accountName)
	{
		return $"à¸ªà¸§\u0e31à¸ªà¸”\u0e35{lineBreak}{lineBreak}à¸¡\u0e35à¸à¸²à¸£à¸›\u0e34à¸”à¸à¸²à¸£à¹ƒà¸Š\u0e49à¸‡à¸²à¸™à¸à¸²à¸£à¸•à¸£à¸§à¸ˆà¸ªà¸­à¸šà¸¢\u0e37à¸™à¸¢\u0e31à¸™à¸•\u0e31à¸§à¸•à¸™ 2 à¸‚\u0e31\u0e49à¸™à¸ªà¸³à¸«à¸£\u0e31à¸šà¸š\u0e31à¸à¸Š\u0e35à¸¥\u0e39à¸à¸‚à¸­à¸‡ Roblox à¸‚à¸­à¸‡à¸„\u0e38à¸“ {accountName} à¸žà¸§à¸à¹€à¸‚à¸²à¸ˆà¸°à¹„à¸¡\u0e48à¸ˆà¸³à¹€à¸›\u0e47à¸™à¸•\u0e49à¸­à¸‡à¸›\u0e49à¸­à¸™à¸£à¸«\u0e31à¸ªà¸£\u0e31à¸à¸©à¸²à¸„à¸§à¸²à¸¡à¸›à¸¥à¸­à¸”à¸ \u0e31à¸¢à¸ªà¸³à¸«à¸£\u0e31à¸šà¸à¸²à¸£à¹€à¸‚\u0e49à¸²à¸ª\u0e39\u0e48à¸š\u0e31à¸à¸Š\u0e35à¸™\u0e31\u0e49à¸™à¸­\u0e35à¸à¸•\u0e48à¸­à¹„à¸›{lineBreak}{lineBreak}Roblox";
	}

	protected override string _GetTemplateForDescriptionTwoStepVerificationDeactivationEmailBodyUnder13()
	{
		return "à¸ªà¸§\u0e31à¸ªà¸”\u0e35{lineBreak}{lineBreak}à¸¡\u0e35à¸à¸²à¸£à¸›\u0e34à¸”à¸à¸²à¸£à¹ƒà¸Š\u0e49à¸‡à¸²à¸™à¸à¸²à¸£à¸•à¸£à¸§à¸ˆà¸ªà¸­à¸šà¸¢\u0e37à¸™à¸¢\u0e31à¸™à¸•\u0e31à¸§à¸•à¸™ 2 à¸‚\u0e31\u0e49à¸™à¸ªà¸³à¸«à¸£\u0e31à¸šà¸š\u0e31à¸à¸Š\u0e35à¸¥\u0e39à¸à¸‚à¸­à¸‡ Roblox à¸‚à¸­à¸‡à¸„\u0e38à¸“ {accountName} à¸žà¸§à¸à¹€à¸‚à¸²à¸ˆà¸°à¹„à¸¡\u0e48à¸ˆà¸³à¹€à¸›\u0e47à¸™à¸•\u0e49à¸­à¸‡à¸›\u0e49à¸­à¸™à¸£à¸«\u0e31à¸ªà¸£\u0e31à¸à¸©à¸²à¸„à¸§à¸²à¸¡à¸›à¸¥à¸­à¸”à¸ \u0e31à¸¢à¸ªà¸³à¸«à¸£\u0e31à¸šà¸à¸²à¸£à¹€à¸‚\u0e49à¸²à¸ª\u0e39\u0e48à¸š\u0e31à¸à¸Š\u0e35à¸™\u0e31\u0e49à¸™à¸­\u0e35à¸à¸•\u0e48à¸­à¹„à¸›{lineBreak}{lineBreak}Roblox";
	}

	/// <summary>
	/// Key: "Description.TwoStepVerificationDeactivationEmail.Subject	"
	/// Subject for 2SV deactivation email
	/// English String: "2-Step Verification Deactivated for Roblox Account: {accountName}"
	/// </summary>
	public override string DescriptionTwoStepVerificationDeactivationEmailSubject(string accountName)
	{
		return $"à¸›\u0e34à¸”à¸à¸²à¸£à¸—à¸³à¸‡à¸²à¸™à¸à¸²à¸£à¸•à¸£à¸§à¸ˆà¸ªà¸­à¸šà¸¢\u0e37à¸™à¸¢\u0e31à¸™à¸•\u0e31à¸§à¸•à¸™ 2 à¸‚\u0e31\u0e49à¸™à¸ªà¸³à¸«à¸£\u0e31à¸šà¸š\u0e31à¸à¸Š\u0e35 Roblox à¹à¸¥\u0e49à¸§: {accountName}";
	}

	protected override string _GetTemplateForDescriptionTwoStepVerificationDeactivationEmailSubject()
	{
		return "à¸›\u0e34à¸”à¸à¸²à¸£à¸—à¸³à¸‡à¸²à¸™à¸à¸²à¸£à¸•à¸£à¸§à¸ˆà¸ªà¸­à¸šà¸¢\u0e37à¸™à¸¢\u0e31à¸™à¸•\u0e31à¸§à¸•à¸™ 2 à¸‚\u0e31\u0e49à¸™à¸ªà¸³à¸«à¸£\u0e31à¸šà¸š\u0e31à¸à¸Š\u0e35 Roblox à¹à¸¥\u0e49à¸§: {accountName}";
	}

	/// <summary>
	/// Key: "Description.TwoStepVerificationLoginEmail.Html.GeolocationInfo1"
	/// Geolocation information about IP trying to login
	/// English String: "{spanStartTagWithBold}Login request received from {username} located in {region}, {country} ({ipAddress}).{spanEndTag}{lineBreak}{lineBreak}"
	/// </summary>
	public override string DescriptionTwoStepVerificationLoginEmailHtmlGeolocationInfo1(string spanStartTagWithBold, string username, string region, string country, string ipAddress, string spanEndTag, string lineBreak)
	{
		return $"{spanStartTagWithBold}à¸à¸²à¸£à¸£\u0e49à¸­à¸‡à¸‚à¸­à¸à¸²à¸£à¹€à¸‚\u0e49à¸²à¸ª\u0e39\u0e48à¸£à¸°à¸šà¸šà¸—\u0e35\u0e48à¹„à¸”\u0e49à¸£\u0e31à¸šà¸ˆà¸²à¸ {username} à¸—\u0e35\u0e48à¸ˆà¸²à¸ {region}, {country}({ipAddress}){spanEndTag}{lineBreak}{lineBreak}";
	}

	protected override string _GetTemplateForDescriptionTwoStepVerificationLoginEmailHtmlGeolocationInfo1()
	{
		return "{spanStartTagWithBold}à¸à¸²à¸£à¸£\u0e49à¸­à¸‡à¸‚à¸­à¸à¸²à¸£à¹€à¸‚\u0e49à¸²à¸ª\u0e39\u0e48à¸£à¸°à¸šà¸šà¸—\u0e35\u0e48à¹„à¸”\u0e49à¸£\u0e31à¸šà¸ˆà¸²à¸ {username} à¸—\u0e35\u0e48à¸ˆà¸²à¸ {region}, {country}({ipAddress}){spanEndTag}{lineBreak}{lineBreak}";
	}

	/// <summary>
	/// Key: "Description.TwoStepVerificationLoginEmail.Html.GeolocationInfo2"
	/// Geolocation info about IP trying to login
	/// English String: "{spanStartTagWithBold}Login request received from {username} located in {country} ({ipAddress}).{spanEndTag}{lineBreak}{lineBreak}\t"
	/// </summary>
	public override string DescriptionTwoStepVerificationLoginEmailHtmlGeolocationInfo2(string spanStartTagWithBold, string username, string country, string ipAddress, string spanEndTag, string lineBreak)
	{
		return $"{spanStartTagWithBold}à¸à¸²à¸£à¸£\u0e49à¸­à¸‡à¸‚à¸­à¸à¸²à¸£à¹€à¸‚\u0e49à¸²à¸ª\u0e39\u0e48à¸£à¸°à¸šà¸šà¸—\u0e35\u0e48à¹„à¸”\u0e49à¸£\u0e31à¸šà¸ˆà¸²à¸ {username} à¸—\u0e35\u0e48à¸ˆà¸²à¸ {country} ({ipAddress}){spanEndTag}{lineBreak}{lineBreak}\t";
	}

	protected override string _GetTemplateForDescriptionTwoStepVerificationLoginEmailHtmlGeolocationInfo2()
	{
		return "{spanStartTagWithBold}à¸à¸²à¸£à¸£\u0e49à¸­à¸‡à¸‚à¸­à¸à¸²à¸£à¹€à¸‚\u0e49à¸²à¸ª\u0e39\u0e48à¸£à¸°à¸šà¸šà¸—\u0e35\u0e48à¹„à¸”\u0e49à¸£\u0e31à¸šà¸ˆà¸²à¸ {username} à¸—\u0e35\u0e48à¸ˆà¸²à¸ {country} ({ipAddress}){spanEndTag}{lineBreak}{lineBreak}\t";
	}

	/// <summary>
	/// Key: "Description.TwoStepVerificationLoginEmail.Html.GeolocationInfo3"
	/// Geolocation info about IP trying to log in
	/// English String: "{spanStartTagWithBold}Login request received from {username} (From Roblox Internal).{spanEndTag}{lineBreak}{lineBreak}\t"
	/// </summary>
	public override string DescriptionTwoStepVerificationLoginEmailHtmlGeolocationInfo3(string spanStartTagWithBold, string username, string spanEndTag, string lineBreak)
	{
		return $"{spanStartTagWithBold}à¸à¸²à¸£à¸£\u0e49à¸­à¸‡à¸‚à¸­à¸à¸²à¸£à¹€à¸‚\u0e49à¸²à¸ª\u0e39\u0e48à¸£à¸°à¸šà¸šà¸—\u0e35\u0e48à¹„à¸”\u0e49à¸£\u0e31à¸šà¸ˆà¸²à¸ {username} (à¸ˆà¸²à¸à¸ à¸²à¸¢à¹ƒà¸™ Roblox){spanEndTag}{lineBreak}{lineBreak}\t";
	}

	protected override string _GetTemplateForDescriptionTwoStepVerificationLoginEmailHtmlGeolocationInfo3()
	{
		return "{spanStartTagWithBold}à¸à¸²à¸£à¸£\u0e49à¸­à¸‡à¸‚à¸­à¸à¸²à¸£à¹€à¸‚\u0e49à¸²à¸ª\u0e39\u0e48à¸£à¸°à¸šà¸šà¸—\u0e35\u0e48à¹„à¸”\u0e49à¸£\u0e31à¸šà¸ˆà¸²à¸ {username} (à¸ˆà¸²à¸à¸ à¸²à¸¢à¹ƒà¸™ Roblox){spanEndTag}{lineBreak}{lineBreak}\t";
	}

	/// <summary>
	/// Key: "Description.TwoStepVerificationLoginEmail.Html.GeolocationInfo4"
	/// Geolocation info of IP trying to login
	/// English String: "{spanStartTagWithBold}Login request received from {username} located in {country}.{spanEndTag}{lineBreak}{lineBreak}"
	/// </summary>
	public override string DescriptionTwoStepVerificationLoginEmailHtmlGeolocationInfo4(string spanStartTagWithBold, string username, string country, string spanEndTag, string lineBreak)
	{
		return $"{spanStartTagWithBold}à¸à¸²à¸£à¸£\u0e49à¸­à¸‡à¸‚à¸­à¸à¸²à¸£à¹€à¸‚\u0e49à¸²à¸ª\u0e39\u0e48à¸£à¸°à¸šà¸šà¸—\u0e35\u0e48à¹„à¸”\u0e49à¸£\u0e31à¸šà¸ˆà¸²à¸ {username} à¸—\u0e35\u0e48à¸ˆà¸²à¸ {country}{spanEndTag}{lineBreak}{lineBreak}";
	}

	protected override string _GetTemplateForDescriptionTwoStepVerificationLoginEmailHtmlGeolocationInfo4()
	{
		return "{spanStartTagWithBold}à¸à¸²à¸£à¸£\u0e49à¸­à¸‡à¸‚à¸­à¸à¸²à¸£à¹€à¸‚\u0e49à¸²à¸ª\u0e39\u0e48à¸£à¸°à¸šà¸šà¸—\u0e35\u0e48à¹„à¸”\u0e49à¸£\u0e31à¸šà¸ˆà¸²à¸ {username} à¸—\u0e35\u0e48à¸ˆà¸²à¸ {country}{spanEndTag}{lineBreak}{lineBreak}";
	}

	/// <summary>
	/// Key: "Description.TwoStepVerificationLoginEmail.Html.GeolocationInfo5"
	/// Geolocation info of IP trying to login
	/// English String: "{spanStartTagWithBold}Login request received from {username} located in {region}, {country}.{spanEndTag}{lineBreak}{lineBreak}"
	/// </summary>
	public override string DescriptionTwoStepVerificationLoginEmailHtmlGeolocationInfo5(string spanStartTagWithBold, string username, string region, string country, string spanEndTag, string lineBreak)
	{
		return $"{spanStartTagWithBold}à¸à¸²à¸£à¸£\u0e49à¸­à¸‡à¸‚à¸­à¸à¸²à¸£à¹€à¸‚\u0e49à¸²à¸ª\u0e39\u0e48à¸£à¸°à¸šà¸šà¸—\u0e35\u0e48à¹„à¸”\u0e49à¸£\u0e31à¸šà¸ˆà¸²à¸ {username} à¸—\u0e35\u0e48à¸ˆà¸²à¸ {region}, {country}{spanEndTag}{lineBreak}{lineBreak}";
	}

	protected override string _GetTemplateForDescriptionTwoStepVerificationLoginEmailHtmlGeolocationInfo5()
	{
		return "{spanStartTagWithBold}à¸à¸²à¸£à¸£\u0e49à¸­à¸‡à¸‚à¸­à¸à¸²à¸£à¹€à¸‚\u0e49à¸²à¸ª\u0e39\u0e48à¸£à¸°à¸šà¸šà¸—\u0e35\u0e48à¹„à¸”\u0e49à¸£\u0e31à¸šà¸ˆà¸²à¸ {username} à¸—\u0e35\u0e48à¸ˆà¸²à¸ {region}, {country}{spanEndTag}{lineBreak}{lineBreak}";
	}

	/// <summary>
	/// Key: "Description.TwoStepVerificationLoginEmail.Html.GeolocationInfo6"
	/// Geolocation info of IP trying to login
	/// English String: "{spanStartTagWithBold}Login request received from {username} located in {city}, {region}, {country}.{spanEndTag}{lineBreak}{lineBreak}"
	/// </summary>
	public override string DescriptionTwoStepVerificationLoginEmailHtmlGeolocationInfo6(string spanStartTagWithBold, string username, string city, string region, string country, string spanEndTag, string lineBreak)
	{
		return $"{spanStartTagWithBold}à¸à¸²à¸£à¸£\u0e49à¸­à¸‡à¸‚à¸­à¸à¸²à¸£à¹€à¸‚\u0e49à¸²à¸ª\u0e39\u0e48à¸£à¸°à¸šà¸šà¸—\u0e35\u0e48à¹„à¸”\u0e49à¸£\u0e31à¸šà¸ˆà¸²à¸ {username} à¸—\u0e35\u0e48à¸ˆà¸²à¸ {city}, {region}, {country}{spanEndTag}{lineBreak}{lineBreak}";
	}

	protected override string _GetTemplateForDescriptionTwoStepVerificationLoginEmailHtmlGeolocationInfo6()
	{
		return "{spanStartTagWithBold}à¸à¸²à¸£à¸£\u0e49à¸­à¸‡à¸‚à¸­à¸à¸²à¸£à¹€à¸‚\u0e49à¸²à¸ª\u0e39\u0e48à¸£à¸°à¸šà¸šà¸—\u0e35\u0e48à¹„à¸”\u0e49à¸£\u0e31à¸šà¸ˆà¸²à¸ {username} à¸—\u0e35\u0e48à¸ˆà¸²à¸ {city}, {region}, {country}{spanEndTag}{lineBreak}{lineBreak}";
	}

	/// <summary>
	/// Key: "Description.TwoStepVerificationLoginEmail.HtmlBody"
	/// Html body for 2SV login email
	/// English String: "{geoLocationInformation}{spanStartTagWithBold}Login code for {accountName}: {lineBreak}{lineBreak}{code} {spanEndTag}{lineBreak}{lineBreak}Enter this code into the 2-Step Verification screen to finish logging in. This code will expire in 15 minutes.{lineBreak}{lineBreak}This email was sent because your account tried to login to Roblox from a new browser or device. If you haven't tried logging into Roblox, someone else may be trying to access your account. You are strongly advised to change your password if you did not generate this request.{lineBreak}{lineBreak}Resources:{lineBreak}{aTagStartWithHref}{ChangePasswordLink}{hrefEnd}Change Your Password{aTagEnd} {lineBreak}{aTagStartWithHref}{TwoStepVerificationArticleLink}{hrefEnd}Learn More About 2-Step Verification{aTagEnd} {lineBreak}{aTagStartWithHref}{AccountSafetyArticleLink}{hrefEnd}Keeping Your Account Safe{aTagEnd} {lineBreak}{aTagStartWithHref}{SupportLink}{hrefEnd}General Roblox Support{aTagEnd} {lineBreak}{lineBreak}Thank you,{lineBreak}{lineBreak}The Roblox Team"
	/// </summary>
	public override string DescriptionTwoStepVerificationLoginEmailHtmlBody(string geoLocationInformation, string spanStartTagWithBold, string accountName, string lineBreak, string code, string spanEndTag, string aTagStartWithHref, string ChangePasswordLink, string hrefEnd, string aTagEnd, string TwoStepVerificationArticleLink, string AccountSafetyArticleLink, string SupportLink)
	{
		return $"{geoLocationInformation}{spanStartTagWithBold}à¸£à¸«\u0e31à¸ªà¸à¸²à¸£à¹€à¸‚\u0e49à¸²à¸ª\u0e39\u0e48à¸£à¸°à¸šà¸šà¸ªà¸³à¸«à¸£\u0e31à¸š {accountName}: {lineBreak}{lineBreak} {code} {spanEndTag}{lineBreak}{lineBreak}à¸›\u0e49à¸­à¸™à¸£à¸«\u0e31à¸ªà¸™\u0e35\u0e49à¹ƒà¸™à¸«à¸™\u0e49à¸²à¸ˆà¸­à¸à¸²à¸£à¸¢\u0e37à¸™à¸¢\u0e31à¸™ 2 à¸‚\u0e31\u0e49à¸™à¸•à¸­à¸™à¹€à¸ž\u0e37\u0e48à¸­à¸ˆà¸šà¸à¸²à¸£à¹€à¸‚\u0e49à¸²à¸ª\u0e39\u0e48à¸£à¸°à¸šà¸š à¸£à¸«\u0e31à¸ªà¸™\u0e35\u0e49à¸ˆà¸°à¸«à¸¡à¸”à¸­à¸²à¸¢\u0e38à¹ƒà¸™ 15 à¸™à¸²à¸—\u0e35 {lineBreak}{lineBreak}à¸­\u0e35à¹€à¸¡à¸¥à¸™\u0e35\u0e49à¸ª\u0e48à¸‡à¸¡à¸²à¹ƒà¸«\u0e49à¸„\u0e38à¸“à¹€à¸™\u0e37\u0e48à¸­à¸‡à¸ˆà¸²à¸à¸š\u0e31à¸à¸Š\u0e35à¸‚à¸­à¸‡à¸„\u0e38à¸“à¸žà¸¢à¸²à¸¢à¸²à¸¡à¹€à¸‚\u0e49à¸²à¸ª\u0e39\u0e48à¸£à¸°à¸šà¸š Roblox à¸ˆà¸²à¸à¹€à¸šà¸£à¸²à¸§\u0e4cà¹€à¸‹à¸­à¸£\u0e4cà¹ƒà¸«à¸¡\u0e48à¸«à¸£\u0e37à¸­à¸­\u0e38à¸›à¸à¸£à¸“\u0e4cà¹ƒà¸«à¸¡\u0e48 à¸«à¸²à¸à¸„\u0e38à¸“à¹„à¸¡\u0e48à¹„à¸”\u0e49à¸žà¸¢à¸²à¸¢à¸²à¸¡à¹€à¸‚\u0e49à¸²à¸ª\u0e39\u0e48à¸£à¸°à¸šà¸š Roblox à¸­à¸²à¸ˆà¸¡\u0e35à¹ƒà¸„à¸£à¸šà¸²à¸‡à¸„à¸™à¸žà¸¢à¸²à¸¢à¸²à¸¡à¹€à¸‚\u0e49à¸²à¸–\u0e36à¸‡à¸š\u0e31à¸à¸Š\u0e35à¸‚à¸­à¸‡à¸„\u0e38à¸“ à¹€à¸£à¸²à¸‚à¸­à¹à¸™à¸°à¸™à¸³à¹ƒà¸«\u0e49à¸„\u0e38à¸“à¹€à¸›à¸¥\u0e35\u0e48à¸¢à¸™à¸£à¸«\u0e31à¸ªà¸œ\u0e48à¸²à¸™à¸‚à¸­à¸‡à¸„\u0e38à¸“ à¸«à¸²à¸à¸„\u0e38à¸“à¹„à¸¡\u0e48à¹ƒà¸Š\u0e48à¸œ\u0e39\u0e49à¸—à¸³à¸à¸²à¸£à¸£\u0e49à¸­à¸‡à¸‚à¸­à¸™\u0e35\u0e49{lineBreak}{lineBreak}à¸£\u0e35à¸‹à¸­à¸£\u0e4cà¸ª:{lineBreak}{aTagStartWithHref}{ChangePasswordLink}{hrefEnd}à¹€à¸›à¸¥\u0e35\u0e48à¸¢à¸™à¸£à¸«\u0e31à¸ªà¸œ\u0e48à¸²à¸™à¸‚à¸­à¸‡à¸„\u0e38à¸“{aTagEnd}{lineBreak}{aTagStartWithHref}{TwoStepVerificationArticleLink}{hrefEnd}à¹€à¸£\u0e35à¸¢à¸™à¸£\u0e39\u0e49à¹€à¸ž\u0e34\u0e48à¸¡à¹€à¸•\u0e34à¸¡à¹€à¸\u0e35\u0e48à¸¢à¸§à¸\u0e31à¸šà¸à¸²à¸£à¸¢\u0e37à¸™à¸¢\u0e31à¸™ 2 à¸‚\u0e31\u0e49à¸™à¸•à¸­à¸™{aTagEnd}{lineBreak}{aTagStartWithHref}{AccountSafetyArticleLink}{hrefEnd}à¸›à¸à¸›\u0e49à¸­à¸‡à¸š\u0e31à¸à¸Š\u0e35à¸‚à¸­à¸‡à¸„\u0e38à¸“à¹ƒà¸«\u0e49à¸›à¸¥à¸­à¸”à¸ \u0e31à¸¢{aTagEnd}{lineBreak}{aTagStartWithHref}{SupportLink}{hrefEnd}à¸\u0e48à¸²à¸¢à¸ªà¸™\u0e31à¸šà¸ªà¸™\u0e38à¸™à¸—\u0e31\u0e48à¸§à¹„à¸›à¸‚à¸­à¸‡ Roblox{aTagEnd}{lineBreak}{lineBreak}à¸‚à¸­à¸šà¸„\u0e38à¸“{lineBreak}{lineBreak}à¸—\u0e35à¸¡à¸‡à¸²à¸™ Roblox";
	}

	protected override string _GetTemplateForDescriptionTwoStepVerificationLoginEmailHtmlBody()
	{
		return "{geoLocationInformation}{spanStartTagWithBold}à¸£à¸«\u0e31à¸ªà¸à¸²à¸£à¹€à¸‚\u0e49à¸²à¸ª\u0e39\u0e48à¸£à¸°à¸šà¸šà¸ªà¸³à¸«à¸£\u0e31à¸š {accountName}: {lineBreak}{lineBreak} {code} {spanEndTag}{lineBreak}{lineBreak}à¸›\u0e49à¸­à¸™à¸£à¸«\u0e31à¸ªà¸™\u0e35\u0e49à¹ƒà¸™à¸«à¸™\u0e49à¸²à¸ˆà¸­à¸à¸²à¸£à¸¢\u0e37à¸™à¸¢\u0e31à¸™ 2 à¸‚\u0e31\u0e49à¸™à¸•à¸­à¸™à¹€à¸ž\u0e37\u0e48à¸­à¸ˆà¸šà¸à¸²à¸£à¹€à¸‚\u0e49à¸²à¸ª\u0e39\u0e48à¸£à¸°à¸šà¸š à¸£à¸«\u0e31à¸ªà¸™\u0e35\u0e49à¸ˆà¸°à¸«à¸¡à¸”à¸­à¸²à¸¢\u0e38à¹ƒà¸™ 15 à¸™à¸²à¸—\u0e35 {lineBreak}{lineBreak}à¸­\u0e35à¹€à¸¡à¸¥à¸™\u0e35\u0e49à¸ª\u0e48à¸‡à¸¡à¸²à¹ƒà¸«\u0e49à¸„\u0e38à¸“à¹€à¸™\u0e37\u0e48à¸­à¸‡à¸ˆà¸²à¸à¸š\u0e31à¸à¸Š\u0e35à¸‚à¸­à¸‡à¸„\u0e38à¸“à¸žà¸¢à¸²à¸¢à¸²à¸¡à¹€à¸‚\u0e49à¸²à¸ª\u0e39\u0e48à¸£à¸°à¸šà¸š Roblox à¸ˆà¸²à¸à¹€à¸šà¸£à¸²à¸§\u0e4cà¹€à¸‹à¸­à¸£\u0e4cà¹ƒà¸«à¸¡\u0e48à¸«à¸£\u0e37à¸­à¸­\u0e38à¸›à¸à¸£à¸“\u0e4cà¹ƒà¸«à¸¡\u0e48 à¸«à¸²à¸à¸„\u0e38à¸“à¹„à¸¡\u0e48à¹„à¸”\u0e49à¸žà¸¢à¸²à¸¢à¸²à¸¡à¹€à¸‚\u0e49à¸²à¸ª\u0e39\u0e48à¸£à¸°à¸šà¸š Roblox à¸­à¸²à¸ˆà¸¡\u0e35à¹ƒà¸„à¸£à¸šà¸²à¸‡à¸„à¸™à¸žà¸¢à¸²à¸¢à¸²à¸¡à¹€à¸‚\u0e49à¸²à¸–\u0e36à¸‡à¸š\u0e31à¸à¸Š\u0e35à¸‚à¸­à¸‡à¸„\u0e38à¸“ à¹€à¸£à¸²à¸‚à¸­à¹à¸™à¸°à¸™à¸³à¹ƒà¸«\u0e49à¸„\u0e38à¸“à¹€à¸›à¸¥\u0e35\u0e48à¸¢à¸™à¸£à¸«\u0e31à¸ªà¸œ\u0e48à¸²à¸™à¸‚à¸­à¸‡à¸„\u0e38à¸“ à¸«à¸²à¸à¸„\u0e38à¸“à¹„à¸¡\u0e48à¹ƒà¸Š\u0e48à¸œ\u0e39\u0e49à¸—à¸³à¸à¸²à¸£à¸£\u0e49à¸­à¸‡à¸‚à¸­à¸™\u0e35\u0e49{lineBreak}{lineBreak}à¸£\u0e35à¸‹à¸­à¸£\u0e4cà¸ª:{lineBreak}{aTagStartWithHref}{ChangePasswordLink}{hrefEnd}à¹€à¸›à¸¥\u0e35\u0e48à¸¢à¸™à¸£à¸«\u0e31à¸ªà¸œ\u0e48à¸²à¸™à¸‚à¸­à¸‡à¸„\u0e38à¸“{aTagEnd}{lineBreak}{aTagStartWithHref}{TwoStepVerificationArticleLink}{hrefEnd}à¹€à¸£\u0e35à¸¢à¸™à¸£\u0e39\u0e49à¹€à¸ž\u0e34\u0e48à¸¡à¹€à¸•\u0e34à¸¡à¹€à¸\u0e35\u0e48à¸¢à¸§à¸\u0e31à¸šà¸à¸²à¸£à¸¢\u0e37à¸™à¸¢\u0e31à¸™ 2 à¸‚\u0e31\u0e49à¸™à¸•à¸­à¸™{aTagEnd}{lineBreak}{aTagStartWithHref}{AccountSafetyArticleLink}{hrefEnd}à¸›à¸à¸›\u0e49à¸­à¸‡à¸š\u0e31à¸à¸Š\u0e35à¸‚à¸­à¸‡à¸„\u0e38à¸“à¹ƒà¸«\u0e49à¸›à¸¥à¸­à¸”à¸ \u0e31à¸¢{aTagEnd}{lineBreak}{aTagStartWithHref}{SupportLink}{hrefEnd}à¸\u0e48à¸²à¸¢à¸ªà¸™\u0e31à¸šà¸ªà¸™\u0e38à¸™à¸—\u0e31\u0e48à¸§à¹„à¸›à¸‚à¸­à¸‡ Roblox{aTagEnd}{lineBreak}{lineBreak}à¸‚à¸­à¸šà¸„\u0e38à¸“{lineBreak}{lineBreak}à¸—\u0e35à¸¡à¸‡à¸²à¸™ Roblox";
	}

	/// <summary>
	/// Key: "Description.TwoStepVerificationLoginEmail.PlainBody"
	/// Plain body for 2SV login email
	/// English String: "{geoLocationInformation}Login code for {accountName}: {lineBreak}{lineBreak} {code} {lineBreak}{lineBreak}Enter this code into the 2-Step Verification screen to finish logging in. This code will expire in 15 minutes. {lineBreak}{lineBreak}This email was sent because your account tried to login to Roblox from a new browser or device. If you haven't tried logging into Roblox, someone else may be trying to access your account. You are strongly advised to change your password if you did not generate this request. {lineBreak}{lineBreak}Resources: {lineBreak}Change Your Password [{accountInfoPageLink}] {lineBreak}Learn More About 2-Step Verification [{twoStepVerificationHelpArticleLink}]{lineBreak}Keeping Your Account Safe [{keepAccountSafeArticleLink}] {lineBreak}General Roblox Support [{supportPageLink}] {lineBreak}{lineBreak}Thank you, {lineBreak}{lineBreak}The Roblox Team"
	/// </summary>
	public override string DescriptionTwoStepVerificationLoginEmailPlainBody(string geoLocationInformation, string accountName, string lineBreak, string code, string accountInfoPageLink, string twoStepVerificationHelpArticleLink, string keepAccountSafeArticleLink, string supportPageLink)
	{
		return $"{geoLocationInformation}à¸£à¸«\u0e31à¸ªà¸à¸²à¸£à¹€à¸‚\u0e49à¸²à¸ª\u0e39\u0e48à¸£à¸°à¸šà¸šà¸ªà¸³à¸«à¸£\u0e31à¸š {accountName}: {lineBreak}{lineBreak} {code} {lineBreak}{lineBreak}à¸›\u0e49à¸­à¸™à¸£à¸«\u0e31à¸ªà¸™\u0e35\u0e49à¹ƒà¸™à¸«à¸™\u0e49à¸²à¸ˆà¸­à¸à¸²à¸£à¸¢\u0e37à¸™à¸¢\u0e31à¸™ 2 à¸‚\u0e31\u0e49à¸™à¸•à¸­à¸™à¹€à¸ž\u0e37\u0e48à¸­à¸ˆà¸šà¸à¸²à¸£à¹€à¸‚\u0e49à¸²à¸ª\u0e39\u0e48à¸£à¸°à¸šà¸š à¸£à¸«\u0e31à¸ªà¸™\u0e35\u0e49à¸ˆà¸°à¸«à¸¡à¸”à¸­à¸²à¸¢\u0e38à¹ƒà¸™ 15 à¸™à¸²à¸—\u0e35 {lineBreak}{lineBreak}à¸­\u0e35à¹€à¸¡à¸¥à¸™\u0e35\u0e49à¸ª\u0e48à¸‡à¸¡à¸²à¹ƒà¸«\u0e49à¸„\u0e38à¸“à¹€à¸™\u0e37\u0e48à¸­à¸‡à¸ˆà¸²à¸à¸š\u0e31à¸à¸Š\u0e35à¸‚à¸­à¸‡à¸„\u0e38à¸“à¸žà¸¢à¸²à¸¢à¸²à¸¡à¹€à¸‚\u0e49à¸²à¸ª\u0e39\u0e48à¸£à¸°à¸šà¸š Roblox à¸ˆà¸²à¸à¹€à¸šà¸£à¸²à¸§\u0e4cà¹€à¸‹à¸­à¸£\u0e4cà¹ƒà¸«à¸¡\u0e48à¸«à¸£\u0e37à¸­à¸­\u0e38à¸›à¸à¸£à¸“\u0e4cà¹ƒà¸«à¸¡\u0e48 à¸«à¸²à¸à¸„\u0e38à¸“à¹„à¸¡\u0e48à¹„à¸”\u0e49à¸žà¸¢à¸²à¸¢à¸²à¸¡à¹€à¸‚\u0e49à¸²à¸ª\u0e39\u0e48à¸£à¸°à¸šà¸š Roblox à¸­à¸²à¸ˆà¸¡\u0e35à¹ƒà¸„à¸£à¸šà¸²à¸‡à¸„à¸™à¸žà¸¢à¸²à¸¢à¸²à¸¡à¹€à¸‚\u0e49à¸²à¸–\u0e36à¸‡à¸š\u0e31à¸à¸Š\u0e35à¸‚à¸­à¸‡à¸„\u0e38à¸“ à¹€à¸£à¸²à¸‚à¸­à¹à¸™à¸°à¸™à¸³à¹ƒà¸«\u0e49à¸„\u0e38à¸“à¹€à¸›à¸¥\u0e35\u0e48à¸¢à¸™à¸£à¸«\u0e31à¸ªà¸œ\u0e48à¸²à¸™à¸‚à¸­à¸‡à¸„\u0e38à¸“ à¸«à¸²à¸à¸„\u0e38à¸“à¹„à¸¡\u0e48à¹ƒà¸Š\u0e48à¸œ\u0e39\u0e49à¸—à¸³à¸à¸²à¸£à¸£\u0e49à¸­à¸‡à¸‚à¸­à¸™\u0e35\u0e49{lineBreak}{lineBreak}à¸£\u0e35à¸‹à¸­à¸£\u0e4cà¸ª: {lineBreak}à¹€à¸›à¸¥\u0e35\u0e48à¸¢à¸™à¸£à¸«\u0e31à¸ªà¸œ\u0e48à¸²à¸™à¸‚à¸­à¸‡à¸„\u0e38à¸“ [{accountInfoPageLink}] {lineBreak}à¹€à¸£\u0e35à¸¢à¸™à¸£\u0e39\u0e49à¹€à¸ž\u0e34\u0e48à¸¡à¹€à¸•\u0e34à¸¡à¹€à¸\u0e35\u0e48à¸¢à¸§à¸\u0e31à¸šà¸à¸²à¸£à¸¢\u0e37à¸™à¸¢\u0e31à¸™ 2 à¸‚\u0e31\u0e49à¸™à¸•à¸­à¸™ [{twoStepVerificationHelpArticleLink}]{lineBreak}à¸›à¸à¸›\u0e49à¸­à¸‡à¸š\u0e31à¸à¸Š\u0e35à¸‚à¸­à¸‡à¸„\u0e38à¸“à¹ƒà¸«\u0e49à¸›à¸¥à¸­à¸”à¸ \u0e31à¸¢ [{keepAccountSafeArticleLink}]{lineBreak}à¸\u0e48à¸²à¸¢à¸ªà¸™\u0e31à¸šà¸ªà¸™\u0e38à¸™à¸—\u0e31\u0e48à¸§à¹„à¸›à¸‚à¸­à¸‡ Roblox [{supportPageLink}] {lineBreak}{lineBreak}à¸‚à¸­à¸šà¸„\u0e38à¸“{lineBreak}{lineBreak}à¸—\u0e35à¸¡à¸‡à¸²à¸™ Roblox";
	}

	protected override string _GetTemplateForDescriptionTwoStepVerificationLoginEmailPlainBody()
	{
		return "{geoLocationInformation}à¸£à¸«\u0e31à¸ªà¸à¸²à¸£à¹€à¸‚\u0e49à¸²à¸ª\u0e39\u0e48à¸£à¸°à¸šà¸šà¸ªà¸³à¸«à¸£\u0e31à¸š {accountName}: {lineBreak}{lineBreak} {code} {lineBreak}{lineBreak}à¸›\u0e49à¸­à¸™à¸£à¸«\u0e31à¸ªà¸™\u0e35\u0e49à¹ƒà¸™à¸«à¸™\u0e49à¸²à¸ˆà¸­à¸à¸²à¸£à¸¢\u0e37à¸™à¸¢\u0e31à¸™ 2 à¸‚\u0e31\u0e49à¸™à¸•à¸­à¸™à¹€à¸ž\u0e37\u0e48à¸­à¸ˆà¸šà¸à¸²à¸£à¹€à¸‚\u0e49à¸²à¸ª\u0e39\u0e48à¸£à¸°à¸šà¸š à¸£à¸«\u0e31à¸ªà¸™\u0e35\u0e49à¸ˆà¸°à¸«à¸¡à¸”à¸­à¸²à¸¢\u0e38à¹ƒà¸™ 15 à¸™à¸²à¸—\u0e35 {lineBreak}{lineBreak}à¸­\u0e35à¹€à¸¡à¸¥à¸™\u0e35\u0e49à¸ª\u0e48à¸‡à¸¡à¸²à¹ƒà¸«\u0e49à¸„\u0e38à¸“à¹€à¸™\u0e37\u0e48à¸­à¸‡à¸ˆà¸²à¸à¸š\u0e31à¸à¸Š\u0e35à¸‚à¸­à¸‡à¸„\u0e38à¸“à¸žà¸¢à¸²à¸¢à¸²à¸¡à¹€à¸‚\u0e49à¸²à¸ª\u0e39\u0e48à¸£à¸°à¸šà¸š Roblox à¸ˆà¸²à¸à¹€à¸šà¸£à¸²à¸§\u0e4cà¹€à¸‹à¸­à¸£\u0e4cà¹ƒà¸«à¸¡\u0e48à¸«à¸£\u0e37à¸­à¸­\u0e38à¸›à¸à¸£à¸“\u0e4cà¹ƒà¸«à¸¡\u0e48 à¸«à¸²à¸à¸„\u0e38à¸“à¹„à¸¡\u0e48à¹„à¸”\u0e49à¸žà¸¢à¸²à¸¢à¸²à¸¡à¹€à¸‚\u0e49à¸²à¸ª\u0e39\u0e48à¸£à¸°à¸šà¸š Roblox à¸­à¸²à¸ˆà¸¡\u0e35à¹ƒà¸„à¸£à¸šà¸²à¸‡à¸„à¸™à¸žà¸¢à¸²à¸¢à¸²à¸¡à¹€à¸‚\u0e49à¸²à¸–\u0e36à¸‡à¸š\u0e31à¸à¸Š\u0e35à¸‚à¸­à¸‡à¸„\u0e38à¸“ à¹€à¸£à¸²à¸‚à¸­à¹à¸™à¸°à¸™à¸³à¹ƒà¸«\u0e49à¸„\u0e38à¸“à¹€à¸›à¸¥\u0e35\u0e48à¸¢à¸™à¸£à¸«\u0e31à¸ªà¸œ\u0e48à¸²à¸™à¸‚à¸­à¸‡à¸„\u0e38à¸“ à¸«à¸²à¸à¸„\u0e38à¸“à¹„à¸¡\u0e48à¹ƒà¸Š\u0e48à¸œ\u0e39\u0e49à¸—à¸³à¸à¸²à¸£à¸£\u0e49à¸­à¸‡à¸‚à¸­à¸™\u0e35\u0e49{lineBreak}{lineBreak}à¸£\u0e35à¸‹à¸­à¸£\u0e4cà¸ª: {lineBreak}à¹€à¸›à¸¥\u0e35\u0e48à¸¢à¸™à¸£à¸«\u0e31à¸ªà¸œ\u0e48à¸²à¸™à¸‚à¸­à¸‡à¸„\u0e38à¸“ [{accountInfoPageLink}] {lineBreak}à¹€à¸£\u0e35à¸¢à¸™à¸£\u0e39\u0e49à¹€à¸ž\u0e34\u0e48à¸¡à¹€à¸•\u0e34à¸¡à¹€à¸\u0e35\u0e48à¸¢à¸§à¸\u0e31à¸šà¸à¸²à¸£à¸¢\u0e37à¸™à¸¢\u0e31à¸™ 2 à¸‚\u0e31\u0e49à¸™à¸•à¸­à¸™ [{twoStepVerificationHelpArticleLink}]{lineBreak}à¸›à¸à¸›\u0e49à¸­à¸‡à¸š\u0e31à¸à¸Š\u0e35à¸‚à¸­à¸‡à¸„\u0e38à¸“à¹ƒà¸«\u0e49à¸›à¸¥à¸­à¸”à¸ \u0e31à¸¢ [{keepAccountSafeArticleLink}]{lineBreak}à¸\u0e48à¸²à¸¢à¸ªà¸™\u0e31à¸šà¸ªà¸™\u0e38à¸™à¸—\u0e31\u0e48à¸§à¹„à¸›à¸‚à¸­à¸‡ Roblox [{supportPageLink}] {lineBreak}{lineBreak}à¸‚à¸­à¸šà¸„\u0e38à¸“{lineBreak}{lineBreak}à¸—\u0e35à¸¡à¸‡à¸²à¸™ Roblox";
	}

	/// <summary>
	/// Key: "Description.TwoStepVerificationLoginEmail.PlainText.GeolocationInfo1"
	/// GeoLocation info of IP trying to login
	/// English String: "Login request received from {username} located in {region}, {country} ({ipAddress}).{lineBreak}{lineBreak}"
	/// </summary>
	public override string DescriptionTwoStepVerificationLoginEmailPlainTextGeolocationInfo1(string username, string region, string country, string ipAddress, string lineBreak)
	{
		return $"à¸à¸²à¸£à¸£\u0e49à¸­à¸‡à¸‚à¸­à¸à¸²à¸£à¹€à¸‚\u0e49à¸²à¸ª\u0e39\u0e48à¸£à¸°à¸šà¸šà¸—\u0e35\u0e48à¹„à¸”\u0e49à¸£\u0e31à¸šà¸ˆà¸²à¸ {username} à¸—\u0e35\u0e48à¸ˆà¸²à¸ {region}, {country}({ipAddress}){lineBreak}{lineBreak}";
	}

	protected override string _GetTemplateForDescriptionTwoStepVerificationLoginEmailPlainTextGeolocationInfo1()
	{
		return "à¸à¸²à¸£à¸£\u0e49à¸­à¸‡à¸‚à¸­à¸à¸²à¸£à¹€à¸‚\u0e49à¸²à¸ª\u0e39\u0e48à¸£à¸°à¸šà¸šà¸—\u0e35\u0e48à¹„à¸”\u0e49à¸£\u0e31à¸šà¸ˆà¸²à¸ {username} à¸—\u0e35\u0e48à¸ˆà¸²à¸ {region}, {country}({ipAddress}){lineBreak}{lineBreak}";
	}

	/// <summary>
	/// Key: "Description.TwoStepVerificationLoginEmail.PlainText.GeolocationInfo2"
	/// Geolocation info of IP trying to login
	/// English String: "Login request received from {username} located in {country} ({ipAddress}).{lineBreak}{lineBreak}"
	/// </summary>
	public override string DescriptionTwoStepVerificationLoginEmailPlainTextGeolocationInfo2(string username, string country, string ipAddress, string lineBreak)
	{
		return $"à¸à¸²à¸£à¸£\u0e49à¸­à¸‡à¸‚à¸­à¸à¸²à¸£à¹€à¸‚\u0e49à¸²à¸ª\u0e39\u0e48à¸£à¸°à¸šà¸šà¸—\u0e35\u0e48à¹„à¸”\u0e49à¸£\u0e31à¸šà¸ˆà¸²à¸ {username} à¸—\u0e35\u0e48à¸ˆà¸²à¸ {country} ({ipAddress}){lineBreak}{lineBreak}";
	}

	protected override string _GetTemplateForDescriptionTwoStepVerificationLoginEmailPlainTextGeolocationInfo2()
	{
		return "à¸à¸²à¸£à¸£\u0e49à¸­à¸‡à¸‚à¸­à¸à¸²à¸£à¹€à¸‚\u0e49à¸²à¸ª\u0e39\u0e48à¸£à¸°à¸šà¸šà¸—\u0e35\u0e48à¹„à¸”\u0e49à¸£\u0e31à¸šà¸ˆà¸²à¸ {username} à¸—\u0e35\u0e48à¸ˆà¸²à¸ {country} ({ipAddress}){lineBreak}{lineBreak}";
	}

	/// <summary>
	/// Key: "Description.TwoStepVerificationLoginEmail.PlainText.GeolocationInfo3"
	/// Geolocation info of IP trying to login
	/// English String: "Login request received from {username} (From Roblox Internal).{lineBreak}{lineBreak}"
	/// </summary>
	public override string DescriptionTwoStepVerificationLoginEmailPlainTextGeolocationInfo3(string username, string lineBreak)
	{
		return $"à¸à¸²à¸£à¸£\u0e49à¸­à¸‡à¸‚à¸­à¸à¸²à¸£à¹€à¸‚\u0e49à¸²à¸ª\u0e39\u0e48à¸£à¸°à¸šà¸šà¸—\u0e35\u0e48à¹„à¸”\u0e49à¸£\u0e31à¸šà¸ˆà¸²à¸ {username} (à¸ˆà¸²à¸à¸ à¸²à¸¢à¹ƒà¸™ Roblox){lineBreak}{lineBreak}";
	}

	protected override string _GetTemplateForDescriptionTwoStepVerificationLoginEmailPlainTextGeolocationInfo3()
	{
		return "à¸à¸²à¸£à¸£\u0e49à¸­à¸‡à¸‚à¸­à¸à¸²à¸£à¹€à¸‚\u0e49à¸²à¸ª\u0e39\u0e48à¸£à¸°à¸šà¸šà¸—\u0e35\u0e48à¹„à¸”\u0e49à¸£\u0e31à¸šà¸ˆà¸²à¸ {username} (à¸ˆà¸²à¸à¸ à¸²à¸¢à¹ƒà¸™ Roblox){lineBreak}{lineBreak}";
	}

	/// <summary>
	/// Key: "Description.TwoStepVerificationLoginEmail.PlainText.GeolocationInfo4"
	/// Geolocation info of IP trying to login
	/// English String: "Login request received from {username} located in {country}.{lineBreak}{lineBreak}"
	/// </summary>
	public override string DescriptionTwoStepVerificationLoginEmailPlainTextGeolocationInfo4(string username, string country, string lineBreak)
	{
		return $"à¸à¸²à¸£à¸£\u0e49à¸­à¸‡à¸‚à¸­à¸à¸²à¸£à¹€à¸‚\u0e49à¸²à¸ª\u0e39\u0e48à¸£à¸°à¸šà¸šà¸—\u0e35\u0e48à¹„à¸”\u0e49à¸£\u0e31à¸šà¸ˆà¸²à¸ {username} à¸—\u0e35\u0e48à¸ˆà¸²à¸ {country}{lineBreak}{lineBreak}";
	}

	protected override string _GetTemplateForDescriptionTwoStepVerificationLoginEmailPlainTextGeolocationInfo4()
	{
		return "à¸à¸²à¸£à¸£\u0e49à¸­à¸‡à¸‚à¸­à¸à¸²à¸£à¹€à¸‚\u0e49à¸²à¸ª\u0e39\u0e48à¸£à¸°à¸šà¸šà¸—\u0e35\u0e48à¹„à¸”\u0e49à¸£\u0e31à¸šà¸ˆà¸²à¸ {username} à¸—\u0e35\u0e48à¸ˆà¸²à¸ {country}{lineBreak}{lineBreak}";
	}

	/// <summary>
	/// Key: "Description.TwoStepVerificationLoginEmail.PlainText.GeolocationInfo5"
	/// Geolocation info of IP trying to login
	/// English String: "Login request received from {username} located in {region}, {country}.{lineBreak}{lineBreak}"
	/// </summary>
	public override string DescriptionTwoStepVerificationLoginEmailPlainTextGeolocationInfo5(string username, string region, string country, string lineBreak)
	{
		return $"à¸à¸²à¸£à¸£\u0e49à¸­à¸‡à¸‚à¸­à¸à¸²à¸£à¹€à¸‚\u0e49à¸²à¸ª\u0e39\u0e48à¸£à¸°à¸šà¸šà¸—\u0e35\u0e48à¹„à¸”\u0e49à¸£\u0e31à¸šà¸ˆà¸²à¸ {username} à¸—\u0e35\u0e48à¸ˆà¸²à¸ {region}, {country}{lineBreak}{lineBreak}";
	}

	protected override string _GetTemplateForDescriptionTwoStepVerificationLoginEmailPlainTextGeolocationInfo5()
	{
		return "à¸à¸²à¸£à¸£\u0e49à¸­à¸‡à¸‚à¸­à¸à¸²à¸£à¹€à¸‚\u0e49à¸²à¸ª\u0e39\u0e48à¸£à¸°à¸šà¸šà¸—\u0e35\u0e48à¹„à¸”\u0e49à¸£\u0e31à¸šà¸ˆà¸²à¸ {username} à¸—\u0e35\u0e48à¸ˆà¸²à¸ {region}, {country}{lineBreak}{lineBreak}";
	}

	/// <summary>
	/// Key: "Description.TwoStepVerificationLoginEmail.PlainText.GeolocationInfo6"
	/// Geolocation info of IP trying to login
	/// English String: "Login request received from {username} located in {city}, {region}, {country}.{lineBreak}{lineBreak}"
	/// </summary>
	public override string DescriptionTwoStepVerificationLoginEmailPlainTextGeolocationInfo6(string username, string city, string region, string country, string lineBreak)
	{
		return $"à¸à¸²à¸£à¸£\u0e49à¸­à¸‡à¸‚à¸­à¸à¸²à¸£à¹€à¸‚\u0e49à¸²à¸ª\u0e39\u0e48à¸£à¸°à¸šà¸šà¸—\u0e35\u0e48à¹„à¸”\u0e49à¸£\u0e31à¸šà¸ˆà¸²à¸ {username} à¸—\u0e35\u0e48à¸ˆà¸²à¸ {city}, {region}, {country}{lineBreak}{lineBreak}";
	}

	protected override string _GetTemplateForDescriptionTwoStepVerificationLoginEmailPlainTextGeolocationInfo6()
	{
		return "à¸à¸²à¸£à¸£\u0e49à¸­à¸‡à¸‚à¸­à¸à¸²à¸£à¹€à¸‚\u0e49à¸²à¸ª\u0e39\u0e48à¸£à¸°à¸šà¸šà¸—\u0e35\u0e48à¹„à¸”\u0e49à¸£\u0e31à¸šà¸ˆà¸²à¸ {username} à¸—\u0e35\u0e48à¸ˆà¸²à¸ {city}, {region}, {country}{lineBreak}{lineBreak}";
	}

	/// <summary>
	/// Key: "Description.TwoStepVerificationLoginEmail.Subject"
	/// Subject for 2SV login email
	/// English String: "Verification Code for Roblox Account: {accountName}"
	/// </summary>
	public override string DescriptionTwoStepVerificationLoginEmailSubject(string accountName)
	{
		return $"à¸£à¸«\u0e31à¸ªà¸à¸²à¸£à¸¢\u0e37à¸™à¸¢\u0e31à¸™à¸ªà¸³à¸«à¸£\u0e31à¸šà¸š\u0e31à¸à¸Š\u0e35 Roblox: {accountName}";
	}

	protected override string _GetTemplateForDescriptionTwoStepVerificationLoginEmailSubject()
	{
		return "à¸£à¸«\u0e31à¸ªà¸à¸²à¸£à¸¢\u0e37à¸™à¸¢\u0e31à¸™à¸ªà¸³à¸«à¸£\u0e31à¸šà¸š\u0e31à¸à¸Š\u0e35 Roblox: {accountName}";
	}

	protected override string _GetTemplateForLabelCode()
	{
		return "à¸£à¸«\u0e31à¸ª";
	}

	/// <summary>
	/// Key: "Label.CodeInputPlaceholderText"
	/// example: Enter 4-digit code
	/// English String: "Enter {codeLength}-digit Code"
	/// </summary>
	public override string LabelCodeInputPlaceholderText(string codeLength)
	{
		return $"à¸›\u0e49à¸­à¸™à¸£à¸«\u0e31à¸ª {codeLength} à¸«à¸¥\u0e31à¸";
	}

	protected override string _GetTemplateForLabelCodeInputPlaceholderText()
	{
		return "à¸›\u0e49à¸­à¸™à¸£à¸«\u0e31à¸ª {codeLength} à¸«à¸¥\u0e31à¸";
	}

	protected override string _GetTemplateForLabelDidNotReceive()
	{
		return "à¹„à¸¡\u0e48à¹„à¸”\u0e49à¸£\u0e31à¸šà¸£à¸«\u0e31à¸ª?";
	}

	protected override string _GetTemplateForLabelEnterCode()
	{
		return "à¸›\u0e49à¸­à¸™à¸£à¸«\u0e31à¸ª (6 à¸«à¸¥\u0e31à¸)";
	}

	protected override string _GetTemplateForLabelEnterEmailCode()
	{
		return "à¸›\u0e49à¸­à¸™à¸£à¸«\u0e31à¸ªà¸—\u0e35\u0e48à¹€à¸£à¸²à¹€à¸ž\u0e34\u0e48à¸‡à¸ª\u0e48à¸‡à¹ƒà¸«\u0e49à¸„\u0e38à¸“à¸—à¸²à¸‡à¸­\u0e35à¹€à¸¡à¸¥";
	}

	protected override string _GetTemplateForLabelEnterTextCode()
	{
		return "à¸›\u0e49à¸­à¸™à¸£à¸«\u0e31à¸ªà¸—\u0e35\u0e48à¹€à¸£à¸²à¹€à¸ž\u0e34\u0e48à¸‡à¸ª\u0e48à¸‡à¹ƒà¸«\u0e49à¸„\u0e38à¸“à¸—à¸²à¸‡à¸à¸²à¸£à¸ª\u0e48à¸‡à¸‚\u0e49à¸­à¸„à¸§à¸²à¸¡";
	}

	protected override string _GetTemplateForLabelEnterTwoStepVerificationCode()
	{
		return "à¸›\u0e49à¸­à¸™à¸£à¸«\u0e31à¸ªà¸à¸²à¸£à¸¢\u0e37à¸™à¸¢\u0e31à¸™à¸ªà¸­à¸‡à¸‚\u0e31\u0e49à¸™à¸•à¸­à¸™à¸‚à¸­à¸‡à¸„\u0e38à¸“";
	}

	protected override string _GetTemplateForLabelFacebookPasswordWarning()
	{
		return "à¸«à¸²à¸à¸„\u0e38à¸“à¹„à¸”\u0e49à¹ƒà¸Š\u0e49à¸à¸²à¸£à¸¥à¸‡à¸Š\u0e37\u0e48à¸­à¹€à¸‚\u0e49à¸²à¸ª\u0e39\u0e48à¸£à¸°à¸šà¸šà¸”\u0e49à¸§à¸¢ Facebook à¸¡à¸²à¸\u0e48à¸­à¸™ à¸„\u0e38à¸“à¸ˆà¸°à¸•\u0e49à¸­à¸‡à¸•\u0e31\u0e49à¸‡à¸£à¸«\u0e31à¸ªà¸œ\u0e48à¸²à¸™";
	}

	protected override string _GetTemplateForLabelLearnMore()
	{
		return "à¹€à¸£\u0e35à¸¢à¸™à¸£\u0e39\u0e49à¹€à¸ž\u0e34\u0e48à¸¡à¹€à¸•\u0e34à¸¡";
	}

	/// <summary>
	/// Key: "Label.NeedHelpContactSupport"
	/// label for the support article link
	/// English String: "Need help? Contact {supportLink}"
	/// </summary>
	public override string LabelNeedHelpContactSupport(string supportLink)
	{
		return $"à¸•\u0e49à¸­à¸‡à¸à¸²à¸£à¸„à¸§à¸²à¸¡à¸Š\u0e48à¸§à¸¢à¹€à¸«à¸¥\u0e37à¸­à¸‡\u0e31\u0e49à¸™à¹€à¸«à¸£à¸­? à¸•\u0e34à¸”à¸•\u0e48à¸­ {supportLink}";
	}

	protected override string _GetTemplateForLabelNeedHelpContactSupport()
	{
		return "à¸•\u0e49à¸­à¸‡à¸à¸²à¸£à¸„à¸§à¸²à¸¡à¸Š\u0e48à¸§à¸¢à¹€à¸«à¸¥\u0e37à¸­à¸‡\u0e31\u0e49à¸™à¹€à¸«à¸£à¸­? à¸•\u0e34à¸”à¸•\u0e48à¸­ {supportLink}";
	}

	protected override string _GetTemplateForLabelNewCode()
	{
		return "à¸£à¸«\u0e31à¸ªà¹ƒà¸«à¸¡\u0e48";
	}

	protected override string _GetTemplateForLabelRobloxSupport()
	{
		return "à¸\u0e48à¸²à¸¢à¸ªà¸™\u0e31à¸šà¸ªà¸™\u0e38à¸™ Roblox";
	}

	protected override string _GetTemplateForLabelTrustThisDevice()
	{
		return "à¹€à¸Š\u0e37\u0e48à¸­à¸­\u0e38à¸›à¸à¸£à¸“\u0e4cà¸™\u0e35\u0e49à¹€à¸›\u0e47à¸™à¹€à¸§à¸¥à¸² 30 à¸§\u0e31à¸™";
	}

	protected override string _GetTemplateForLabelTwoStepVerification()
	{
		return "à¸à¸²à¸£à¸•à¸£à¸§à¸ˆà¸ªà¸­à¸šà¸¢\u0e37à¸™à¸¢\u0e31à¸™à¸•\u0e31à¸§à¸•à¸™ 2 à¸‚\u0e31\u0e49à¸™";
	}

	protected override string _GetTemplateForResponseCodeSent()
	{
		return "à¸ª\u0e48à¸‡à¸£à¸«\u0e31à¸ªà¹à¸¥\u0e49à¸§";
	}

	protected override string _GetTemplateForResponseFeatureNotAvailable()
	{
		return "à¸Ÿ\u0e35à¹€à¸ˆà¸­à¸£\u0e4cà¹„à¸¡\u0e48à¸žà¸£\u0e49à¸­à¸¡à¹ƒà¸Š\u0e49à¸‡à¸²à¸™ à¸à¸£\u0e38à¸“à¸²à¸•\u0e34à¸”à¸•\u0e48à¸­à¸\u0e48à¸²à¸¢à¸ªà¸™\u0e31à¸šà¸ªà¸™\u0e38à¸™";
	}

	protected override string _GetTemplateForResponseInvalidCode()
	{
		return "à¸£à¸«\u0e31à¸ªà¹„à¸¡\u0e48à¸–\u0e39à¸à¸•\u0e49à¸­à¸‡";
	}

	protected override string _GetTemplateForResponseSystemErrorReturnToLogin()
	{
		return "à¹€à¸\u0e34à¸”à¸‚\u0e49à¸­à¸œ\u0e34à¸”à¸žà¸¥à¸²à¸”à¸\u0e31à¸šà¸£à¸°à¸šà¸š à¸à¸£\u0e38à¸“à¸²à¸à¸¥\u0e31à¸šà¸ª\u0e39\u0e48à¸«à¸™\u0e49à¸²à¸à¸²à¸£à¹€à¸‚\u0e49à¸²à¸ª\u0e39\u0e48à¸£à¸°à¸šà¸š";
	}

	protected override string _GetTemplateForResponseTooManyAttempts()
	{
		return "à¸¡\u0e35à¸à¸²à¸£à¸”à¸³à¹€à¸™\u0e34à¸™à¸à¸²à¸£à¸‹\u0e49à¸³à¸¡à¸²à¸à¹€à¸\u0e34à¸™à¹„à¸› à¸à¸£\u0e38à¸“à¸²à¸¥à¸­à¸‡à¹ƒà¸«à¸¡\u0e48à¸­\u0e35à¸à¸„à¸£\u0e31\u0e49à¸‡à¹ƒà¸™à¸ à¸²à¸¢à¸«à¸¥\u0e31à¸‡";
	}

	protected override string _GetTemplateForResponseTooManyCharacters()
	{
		return "à¸¡\u0e35à¸­\u0e31à¸à¸‚à¸£à¸°à¸¡à¸²à¸à¹€à¸\u0e34à¸™à¹„à¸›";
	}
}


}
