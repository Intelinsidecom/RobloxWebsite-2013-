namespace Roblox.Platform.TranslationResources.Authentication {
    /// <summary>

/// This class overrides LoginResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class LoginResources_th_th : LoginResources_en_us, ILoginResources, ITranslationResources
{
	/// <summary>
	/// Key: "Action.Cancel"
	/// Cancel button text
	/// English String: "Cancel"
	/// </summary>
	public override string ActionCancel => "à¸¢à¸à¹€à¸¥\u0e34à¸";

	/// <summary>
	/// Key: "Action.Facebook"
	/// facebook button label
	/// English String: "Facebook"
	/// </summary>
	public override string ActionFacebook => "Facebook";

	/// <summary>
	/// Key: "Action.ForgotPasswordOrUsernameQuestion"
	/// English String: "Forgot password or username?"
	/// </summary>
	public override string ActionForgotPasswordOrUsernameQuestion => "à¸¥\u0e37à¸¡à¸£à¸«\u0e31à¸ªà¸œ\u0e48à¸²à¸™à¸«à¸£\u0e37à¸­à¸Š\u0e37\u0e48à¸­à¸œ\u0e39\u0e49à¹ƒà¸Š\u0e49?";

	/// <summary>
	/// Key: "Action.ForgotPasswordOrUsernameQuestionCapitalized"
	/// link under login form
	/// English String: "Forgot Password or Username?"
	/// </summary>
	public override string ActionForgotPasswordOrUsernameQuestionCapitalized => "à¸¥\u0e37à¸¡à¸£à¸«\u0e31à¸ªà¸œ\u0e48à¸²à¸™à¸«à¸£\u0e37à¸­à¸Š\u0e37\u0e48à¸­à¸œ\u0e39\u0e49à¹ƒà¸Š\u0e49?";

	/// <summary>
	/// Key: "Action.Login"
	/// English String: "Login"
	/// </summary>
	public override string ActionLogin => "à¹€à¸‚\u0e49à¸²à¸ª\u0e39\u0e48à¸£à¸°à¸šà¸š";

	/// <summary>
	/// Key: "Action.LogInCapitalized"
	/// login button label. please note this is different from 'Login' or 'Log in'.
	/// English String: "Log In"
	/// </summary>
	public override string ActionLogInCapitalized => "à¹€à¸‚\u0e49à¸²à¸ª\u0e39\u0e48à¸£à¸°à¸šà¸š";

	/// <summary>
	/// Key: "Action.Ok"
	/// button text
	/// English String: "OK"
	/// </summary>
	public override string ActionOk => "à¸•à¸à¸¥à¸‡";

	/// <summary>
	/// Key: "Action.PlayAsGuest"
	/// Play as Guest
	/// English String: "Play as Guest"
	/// </summary>
	public override string ActionPlayAsGuest => "à¹€à¸¥\u0e48à¸™à¹ƒà¸™à¸à¸²à¸™à¸°à¹à¸‚à¸";

	/// <summary>
	/// Key: "Action.Resend"
	/// button text for resending verification email
	/// English String: "Resend"
	/// </summary>
	public override string ActionResend => "à¸ª\u0e48à¸‡à¸­\u0e35à¸à¸„à¸£\u0e31\u0e49à¸‡";

	/// <summary>
	/// Key: "Action.ResendEmail"
	/// link that resends verification email to user
	/// English String: "Resend Email"
	/// </summary>
	public override string ActionResendEmail => "à¸ª\u0e48à¸‡à¸­\u0e35à¹€à¸¡à¸¥à¹ƒà¸«à¸¡\u0e48";

	/// <summary>
	/// Key: "Action.SendVerificationEmail"
	/// button user can click to send a verification link to their email
	/// English String: "Send Verification Email"
	/// </summary>
	public override string ActionSendVerificationEmail => "à¸ª\u0e48à¸‡à¸­\u0e35à¹€à¸¡à¸¥à¸¢\u0e37à¸™à¸¢\u0e31à¸™";

	/// <summary>
	/// Key: "Action.SignIn"
	/// Sign In button text
	/// English String: "Sign In"
	/// </summary>
	public override string ActionSignIn => "à¸¥à¸‡à¸Š\u0e37\u0e48à¸­à¹€à¸‚\u0e49à¸²à¹ƒà¸Š\u0e49à¸‡à¸²à¸™";

	/// <summary>
	/// Key: "Action.SignInWithFacebook"
	/// Sign In with Facebook
	/// English String: "Sign In with Facebook"
	/// </summary>
	public override string ActionSignInWithFacebook => "à¸¥à¸‡à¸Š\u0e37\u0e48à¸­à¹€à¸‚\u0e49à¸²à¹ƒà¸Š\u0e49à¸‡à¸²à¸™à¸”\u0e49à¸§à¸¢ Facebook";

	/// <summary>
	/// Key: "Action.SignUp"
	/// English String: "Sign up"
	/// </summary>
	public override string ActionSignUp => "à¸ªà¸¡\u0e31à¸„à¸£à¸š\u0e31à¸à¸Š\u0e35";

	/// <summary>
	/// Key: "Action.SignUpCapitalized"
	/// link which takes user to sign up page
	/// English String: "Sign Up"
	/// </summary>
	public override string ActionSignUpCapitalized => "à¸ªà¸¡\u0e31à¸„à¸£à¸š\u0e31à¸à¸Š\u0e35à¸œ\u0e39\u0e49à¹ƒà¸Š\u0e49";

	/// <summary>
	/// Key: "Action.WeChatLogin"
	/// button text for logging in with WeChat
	/// English String: "WeChat Login"
	/// </summary>
	public override string ActionWeChatLogin => "à¹€à¸‚\u0e49à¸²à¸ª\u0e39\u0e48à¸£à¸°à¸šà¸š WeChat";

	/// <summary>
	/// Key: "Heading.Login"
	/// heading on the login page
	/// English String: "Login"
	/// </summary>
	public override string HeadingLogin => "à¹€à¸‚\u0e49à¸²à¸ª\u0e39\u0e48à¸£à¸°à¸šà¸š";

	/// <summary>
	/// Key: "Heading.LoginRoblox"
	/// current login page heading
	/// English String: "Login to Roblox"
	/// </summary>
	public override string HeadingLoginRoblox => "à¹€à¸‚\u0e49à¸²à¸ª\u0e39\u0e48à¸£à¸°à¸šà¸š Roblox";

	public override string HeadingSignUpMakeFriends => "à¸ªà¸¡\u0e31à¸„à¸£à¸š\u0e31à¸à¸Š\u0e35à¹€à¸ž\u0e37\u0e48à¸­à¸\u0e48à¸­à¸ªà¸£\u0e49à¸²à¸‡à¹à¸¥à¸°à¸«à¸²à¹€à¸ž\u0e37\u0e48à¸­à¸™à¸¡à¸²à¸à¸‚\u0e36\u0e49à¸™";

	/// <summary>
	/// Key: "Label.AccountNotNeeded"
	/// You don't need an account to play Roblox
	/// English String: "You don't need an account to play Roblox"
	/// </summary>
	public override string LabelAccountNotNeeded => "à¸„\u0e38à¸“à¹„à¸¡\u0e48à¸ˆà¸³à¹€à¸›\u0e47à¸™à¸•\u0e49à¸­à¸‡à¸¡\u0e35à¸š\u0e31à¸à¸Š\u0e35à¹€à¸ž\u0e37\u0e48à¸­à¸—\u0e35\u0e48à¸ˆà¸°à¹€à¸¥\u0e48à¸™ Roblox";

	/// <summary>
	/// Key: "Label.EmailNeedsVerification"
	/// modal header used for prompting user they need to verify their email in order to log in with it
	/// English String: "Your email needs verification"
	/// </summary>
	public override string LabelEmailNeedsVerification => "à¸­\u0e35à¹€à¸¡à¸¥à¸‚à¸­à¸‡à¸„\u0e38à¸“à¸ˆà¸³à¹€à¸›\u0e47à¸™à¸•\u0e49à¸­à¸‡à¹„à¸”\u0e49à¸£\u0e31à¸šà¸à¸²à¸£à¸¢\u0e37à¸™à¸¢\u0e31à¸™";

	/// <summary>
	/// Key: "Label.FacebookCreatePasswordWarning"
	/// If you have been signing in with Facebook, you must set a password.
	/// English String: "If you have been signing in with Facebook, you must set a password."
	/// </summary>
	public override string LabelFacebookCreatePasswordWarning => "à¸«à¸²à¸à¸„\u0e38à¸“à¹„à¸”\u0e49à¹ƒà¸Š\u0e49à¸à¸²à¸£à¸¥à¸‡à¸Š\u0e37\u0e48à¸­à¹€à¸‚\u0e49à¸²à¸ª\u0e39\u0e48à¸£à¸°à¸šà¸šà¸”\u0e49à¸§à¸¢ Facebook à¸¡à¸²à¸\u0e48à¸­à¸™ à¸„\u0e38à¸“à¸ˆà¸°à¸•\u0e49à¸­à¸‡à¸•\u0e31\u0e49à¸‡à¸£à¸«\u0e31à¸ªà¸œ\u0e48à¸²à¸™";

	/// <summary>
	/// Key: "Label.ForgotUsernamePassword"
	/// landing page top right link for password reset
	/// English String: "Forgot Username/Password?"
	/// </summary>
	public override string LabelForgotUsernamePassword => "à¸¥\u0e37à¸¡à¸Š\u0e37\u0e48à¸­à¸œ\u0e39\u0e49à¹ƒà¸Š\u0e49/à¸£à¸«\u0e31à¸ªà¸œ\u0e48à¸²à¸™à¸­à¸¢\u0e48à¸²à¸‡à¸™\u0e31\u0e49à¸™à¸«à¸£\u0e37à¸­?";

	/// <summary>
	/// Key: "Label.LearnMore"
	/// learn more link text
	/// English String: "Learn more"
	/// </summary>
	public override string LabelLearnMore => "à¹€à¸£\u0e35à¸¢à¸™à¸£\u0e39\u0e49à¹€à¸ž\u0e34\u0e48à¸¡à¹€à¸•\u0e34à¸¡";

	/// <summary>
	/// Key: "Label.LoggingInSpinnerText"
	/// English String: "Logging inâ€¦"
	/// </summary>
	public override string LabelLoggingInSpinnerText => "à¸à¸³à¸¥\u0e31à¸‡à¹€à¸‚\u0e49à¸²à¸ª\u0e39\u0e48à¸£à¸°à¸šà¸šâ€¦";

	/// <summary>
	/// Key: "Label.Login"
	/// English String: "Log in"
	/// </summary>
	public override string LabelLogin => "à¹€à¸‚\u0e49à¸²à¸ª\u0e39\u0e48à¸£à¸°à¸šà¸š";

	/// <summary>
	/// Key: "Label.LoginWithYour"
	/// Label for a partition line between login with email and facebook login. Please keep the text in lowercase for roman characters.
	/// English String: "login with your"
	/// </summary>
	public override string LabelLoginWithYour => "à¸¡\u0e35à¸šà¸²à¸‡à¸­à¸¢\u0e48à¸²à¸‡à¸œ\u0e34à¸”à¸›à¸à¸•\u0e34 à¸à¸£\u0e38à¸“à¸²à¹€à¸‚\u0e49à¸²à¸ª\u0e39\u0e48à¸š\u0e31à¸à¸Š\u0e35à¸‚à¸­à¸‡à¸„\u0e38à¸“";

	/// <summary>
	/// Key: "Label.NoAccount"
	/// Don't have an account?
	/// English String: "Don't have an account?"
	/// </summary>
	public override string LabelNoAccount => "à¸¢\u0e31à¸‡à¹„à¸¡\u0e48à¸¡\u0e35à¸š\u0e31à¸à¸Š\u0e35à¸«à¸£\u0e37à¸­?";

	/// <summary>
	/// Key: "Label.NonAMemberQuestion"
	/// The question heading for the section on the login page to take use to sign up page.
	/// English String: "Not a member?"
	/// </summary>
	public override string LabelNonAMemberQuestion => "à¹„à¸¡\u0e48à¹ƒà¸Š\u0e48à¸ªà¸¡à¸²à¸Š\u0e34à¸à¸­à¸¢\u0e48à¸²à¸‡à¸™\u0e31\u0e49à¸™à¸«à¸£\u0e37à¸­?";

	/// <summary>
	/// Key: "Label.NotReceived"
	/// prompt for allowing users to resend verification email
	/// English String: "Didn't receive it?"
	/// </summary>
	public override string LabelNotReceived => "à¸„\u0e38à¸“à¹„à¸¡\u0e48à¹„à¸”\u0e49à¸£\u0e31à¸šà¸­\u0e35à¹€à¸¡à¸¥à¸­à¸¢\u0e48à¸²à¸‡à¸™\u0e31\u0e49à¸™à¸«à¸£\u0e37à¸­?";

	/// <summary>
	/// Key: "Label.Or"
	/// partition between email login and facebook login
	/// English String: "Or"
	/// </summary>
	public override string LabelOr => "à¸«à¸£\u0e37à¸­";

	/// <summary>
	/// Key: "Label.Password"
	/// Password
	/// English String: "Password"
	/// </summary>
	public override string LabelPassword => "à¸£à¸«\u0e31à¸ªà¸œ\u0e48à¸²à¸™";

	/// <summary>
	/// Key: "Label.PasswordWithColumn"
	/// label for the password field on the login page
	/// English String: "Password:"
	/// </summary>
	public override string LabelPasswordWithColumn => "à¸£à¸«\u0e31à¸ªà¸œ\u0e48à¸²à¸™:";

	/// <summary>
	/// Key: "Label.StartPlaying"
	/// You can start playing right now, in guest mode!
	/// English String: "You can start playing right now, in guest mode!"
	/// </summary>
	public override string LabelStartPlaying => "à¸„\u0e38à¸“à¸ªà¸²à¸¡à¸²à¸£à¸–à¹€à¸£\u0e34\u0e48à¸¡à¸•\u0e49à¸™à¹€à¸¥\u0e48à¸™à¹„à¸”\u0e49à¸•à¸­à¸™à¸™\u0e35\u0e49à¹€à¸¥à¸¢ à¹ƒà¸™à¹‚à¸«à¸¡à¸”à¹à¸‚à¸!";

	/// <summary>
	/// Key: "Label.UnverifiedEmailInstructions"
	/// message shown in a modal when user logs in with unverified email
	/// English String: "To log in with your email, it must be verified. You can also log in with your username."
	/// </summary>
	public override string LabelUnverifiedEmailInstructions => "à¸«à¸²à¸à¸•\u0e49à¸­à¸‡à¸à¸²à¸£à¹€à¸‚\u0e49à¸²à¸ª\u0e39\u0e48à¸£à¸°à¸šà¸šà¸”\u0e49à¸§à¸¢à¸­\u0e35à¹€à¸¡à¸¥à¸‚à¸­à¸‡à¸„\u0e38à¸“ à¸„\u0e38à¸“à¸ˆà¸°à¸•\u0e49à¸­à¸‡à¸—à¸³à¸à¸²à¸£à¸¢\u0e37à¸™à¸¢\u0e31à¸™à¸­\u0e35à¹€à¸¡à¸¥à¸™\u0e31\u0e49à¸™à¸\u0e48à¸­à¸™ à¸„\u0e38à¸“à¸¢\u0e31à¸‡à¸ªà¸²à¸¡à¸²à¸£à¸–à¹€à¸‚\u0e49à¸²à¸ª\u0e39\u0e48à¸£à¸°à¸šà¸šà¸”\u0e49à¸§à¸¢à¸Š\u0e37\u0e48à¸­à¸œ\u0e39\u0e49à¹ƒà¸Š\u0e49à¸‚à¸­à¸‡à¸„\u0e38à¸“à¹„à¸”\u0e49";

	/// <summary>
	/// Key: "Label.Username"
	/// English String: "Username"
	/// </summary>
	public override string LabelUsername => "à¸Š\u0e37\u0e48à¸­à¸œ\u0e39\u0e49à¹ƒà¸Š\u0e49";

	/// <summary>
	/// Key: "Label.UsernameEmail"
	/// placeholder text for input field that accepts username or email
	/// English String: "Username/Email"
	/// </summary>
	public override string LabelUsernameEmail => "à¸Š\u0e37\u0e48à¸­à¸œ\u0e39\u0e49à¹ƒà¸Š\u0e49/à¸­\u0e35à¹€à¸¡à¸¥";

	/// <summary>
	/// Key: "Label.UsernameEmailPhone"
	/// placeholder text for input fields that accept username, email or phone
	/// English String: "Username/Email/Phone"
	/// </summary>
	public override string LabelUsernameEmailPhone => "à¸Š\u0e37\u0e48à¸­à¸œ\u0e39\u0e49à¹ƒà¸Š\u0e49/à¸­\u0e35à¹€à¸¡à¸¥/à¸«à¸¡à¸²à¸¢à¹€à¸¥à¸‚à¹‚à¸—à¸£à¸¨\u0e31à¸žà¸—\u0e4c";

	/// <summary>
	/// Key: "Label.UsernamePhone"
	/// placeholder text for input field that accepts username or phone
	/// English String: "Username/Phone"
	/// </summary>
	public override string LabelUsernamePhone => "à¸Š\u0e37\u0e48à¸­à¸œ\u0e39\u0e49à¹ƒà¸Š\u0e49/à¸«à¸¡à¸²à¸¢à¹€à¸¥à¸‚à¹‚à¸—à¸£à¸¨\u0e31à¸žà¸—\u0e4c";

	/// <summary>
	/// Key: "Label.UsernameWithColumn"
	/// label for username field on login page
	/// English String: "Username:"
	/// </summary>
	public override string LabelUsernameWithColumn => "à¸Š\u0e37\u0e48à¸­à¸œ\u0e39\u0e49à¹ƒà¸Š\u0e49:";

	/// <summary>
	/// Key: "Label.VerificationEmailSent"
	/// message telling user a verification email was sent to them
	/// English String: "Verification Email Sent!"
	/// </summary>
	public override string LabelVerificationEmailSent => "à¸ª\u0e48à¸‡à¸­\u0e35à¹€à¸¡à¸¥à¸¢\u0e37à¸™à¸¢\u0e31à¸™à¹à¸¥\u0e49à¸§!";

	/// <summary>
	/// Key: "Label.WeChatAntiAddictionText"
	/// English String: "Boycott bad games, refuse pirated games. Be aware of self-defense and being deceived. Playing games is good for your brain, but too much game play can harm your health. Manage your time well and enjoy a healthy lifestyle."
	/// </summary>
	public override string LabelWeChatAntiAddictionText => "à¸šà¸­à¸¢à¸„à¸­à¸•à¸•\u0e4cà¹€à¸à¸¡à¹à¸¢\u0e48à¹† à¸›à¸\u0e34à¹€à¸ªà¸˜à¹€à¸à¸¡à¸¥à¸°à¹€à¸¡\u0e34à¸”à¸¥\u0e34à¸‚à¸ª\u0e34à¸—à¸˜\u0e34\u0e4c à¸£\u0e39\u0e49à¸–\u0e36à¸‡à¸à¸²à¸£à¸›\u0e49à¸­à¸‡à¸\u0e31à¸™à¸•\u0e31à¸§à¹à¸¥à¸°à¸à¸²à¸£à¸–\u0e39à¸à¸«à¸¥à¸­à¸à¸¥à¸§à¸‡ à¸à¸²à¸£à¹€à¸¥\u0e48à¸™à¹€à¸à¸¡à¸™\u0e31\u0e49à¸™à¸”\u0e35à¸•\u0e48à¸­à¸ªà¸¡à¸­à¸‡à¸‚à¸­à¸‡à¸„\u0e38à¸“ à¹à¸•\u0e48à¸à¸²à¸£à¹€à¸¥\u0e48à¸™à¹€à¸à¸¡à¸¡à¸²à¸à¹€à¸\u0e34à¸™à¹„à¸›à¸\u0e47à¸­à¸²à¸ˆà¹€à¸›\u0e47à¸™à¸­\u0e31à¸™à¸•à¸£à¸²à¸¢à¸•\u0e48à¸­à¸ª\u0e38à¸‚à¸ à¸²à¸žà¸‚à¸­à¸‡à¸„\u0e38à¸“à¹„à¸”\u0e49 à¸šà¸£\u0e34à¸«à¸²à¸£à¹€à¸§à¸¥à¸²à¸‚à¸­à¸‡à¸„\u0e38à¸“à¹ƒà¸«\u0e49à¸”\u0e35 à¹à¸¥\u0e49à¸§à¹ƒà¸Š\u0e49à¸Š\u0e35à¸§\u0e34à¸•à¸—\u0e35\u0e48à¸¡\u0e35à¸ª\u0e38à¸‚à¸ à¸²à¸žà¸”\u0e35";

	/// <summary>
	/// Key: "Message.UnknownErrorTryAgain"
	/// An unknown error occurred. Please try again.
	/// English String: "An unknown error occurred. Please try again."
	/// </summary>
	public override string MessageUnknownErrorTryAgain => "à¹€à¸\u0e34à¸”à¸‚\u0e49à¸­à¸œ\u0e34à¸”à¸žà¸¥à¸²à¸”à¸—\u0e35\u0e48à¹„à¸¡\u0e48à¸—à¸£à¸²à¸šà¸ªà¸²à¹€à¸«à¸•\u0e38 à¸à¸£\u0e38à¸“à¸²à¸¥à¸­à¸‡à¹ƒà¸«à¸¡\u0e48à¸­\u0e35à¸à¸„à¸£\u0e31\u0e49à¸‡";

	/// <summary>
	/// Key: "Message.UsernameAndPasswordRequired"
	/// message shown to user when they attempt to login without entering a username or password
	/// English String: "Username and password required"
	/// </summary>
	public override string MessageUsernameAndPasswordRequired => "à¸ˆà¸³à¹€à¸›\u0e47à¸™à¸•\u0e49à¸­à¸‡à¸¡\u0e35à¸Š\u0e37\u0e48à¸­à¸œ\u0e39\u0e49à¹ƒà¸Š\u0e49à¹à¸¥à¸°à¸£à¸«\u0e31à¸ªà¸œ\u0e48à¸²à¸™";

	/// <summary>
	/// Key: "Response.AccountIssueErrorContactSupport"
	/// English String: "Account issue. Please contact Support."
	/// </summary>
	public override string ResponseAccountIssueErrorContactSupport => "à¸›\u0e31à¸à¸«à¸²à¸”\u0e49à¸²à¸™à¸š\u0e31à¸à¸Š\u0e35 à¸à¸£\u0e38à¸“à¸²à¸•\u0e34à¸”à¸•\u0e48à¸­à¸\u0e48à¸²à¸¢à¸ªà¸™\u0e31à¸šà¸ªà¸™\u0e38à¸™";

	/// <summary>
	/// Key: "Response.AccountLockedRequestReset"
	/// Account has been locked. Please request a password reset.
	/// English String: "Account has been locked. Please request a password reset."
	/// </summary>
	public override string ResponseAccountLockedRequestReset => "à¸š\u0e31à¸à¸Š\u0e35à¸–\u0e39à¸à¸¥\u0e47à¸­à¸„ à¸à¸£\u0e38à¸“à¸²à¸‚à¸­à¸à¸²à¸£à¸£\u0e35à¹€à¸‹\u0e47à¸•à¸£à¸«\u0e31à¸ªà¸œ\u0e48à¸²à¸™";

	/// <summary>
	/// Key: "Response.AccountNotFound"
	/// Account not found. Please try again.
	/// English String: "Account not found. Please try again."
	/// </summary>
	public override string ResponseAccountNotFound => "à¹„à¸¡\u0e48à¸žà¸šà¸š\u0e31à¸à¸Š\u0e35 à¸à¸£\u0e38à¸“à¸²à¸¥à¸­à¸‡à¹ƒà¸«à¸¡\u0e48à¸­\u0e35à¸à¸„à¸£\u0e31\u0e49à¸‡";

	/// <summary>
	/// Key: "Response.EmailLinkedToMultipleAccountsLoginWithUsername"
	/// error message displayed when user attempts to log in with an email that is linked to multiple accounts
	/// English String: "Your email is associated with more than 1 username. Please login with your username."
	/// </summary>
	public override string ResponseEmailLinkedToMultipleAccountsLoginWithUsername => "à¸­\u0e35à¹€à¸¡à¸¥à¸‚à¸­à¸‡à¸„\u0e38à¸“à¹€à¸Š\u0e37\u0e48à¸­à¸¡à¹‚à¸¢à¸‡à¸\u0e31à¸šà¸Š\u0e37\u0e48à¸­à¸œ\u0e39\u0e49à¹ƒà¸Š\u0e49à¸¡à¸²à¸à¸à¸§\u0e48à¸² 1 à¸š\u0e31à¸à¸Š\u0e35 à¸à¸£\u0e38à¸“à¸²à¹€à¸‚\u0e49à¸²à¸ª\u0e39\u0e48à¸£à¸°à¸šà¸šà¸”\u0e49à¸§à¸¢à¸Š\u0e37\u0e48à¸­à¸œ\u0e39\u0e49à¹ƒà¸Š\u0e49à¸‚à¸­à¸‡à¸„\u0e38à¸“";

	/// <summary>
	/// Key: "Response.EmailSent"
	/// response telling user that a verification email has been sent to them
	/// English String: "Email sent!"
	/// </summary>
	public override string ResponseEmailSent => "à¸ª\u0e48à¸‡à¸­\u0e35à¹€à¸¡à¸¥à¹à¸¥\u0e49à¸§!";

	/// <summary>
	/// Key: "Response.IncorrectEmailOrPassword"
	/// error message displayed when user logs in with an invalid email or password
	/// English String: "Incorrect email or password."
	/// </summary>
	public override string ResponseIncorrectEmailOrPassword => "à¸­\u0e35à¹€à¸¡à¸¥à¸«à¸£\u0e37à¸­à¸£à¸«\u0e31à¸ªà¸œ\u0e48à¸²à¸™à¹„à¸¡\u0e48à¸–\u0e39à¸à¸•\u0e49à¸­à¸‡";

	/// <summary>
	/// Key: "Response.IncorrectPhoneOrPassword"
	/// error message displayed when user logs in with an invalid phone or password
	/// English String: "Incorrect phone or password."
	/// </summary>
	public override string ResponseIncorrectPhoneOrPassword => "à¸«à¸¡à¸²à¸¢à¹€à¸¥à¸‚à¹‚à¸—à¸£à¸¨\u0e31à¸žà¸—\u0e4cà¸«à¸£\u0e37à¸­à¸£à¸«\u0e31à¸ªà¸œ\u0e48à¸²à¸™à¹„à¸¡\u0e48à¸–\u0e39à¸à¸•\u0e49à¸­à¸‡";

	/// <summary>
	/// Key: "Response.IncorrectUsernamePassword"
	/// English String: "Incorrect username or password."
	/// </summary>
	public override string ResponseIncorrectUsernamePassword => "à¸Š\u0e37\u0e48à¸­à¸œ\u0e39\u0e49à¹ƒà¸Š\u0e49à¸«à¸£\u0e37à¸­à¸£à¸«\u0e31à¸ªà¸œ\u0e48à¸²à¸™à¹„à¸¡\u0e48à¸–\u0e39à¸à¸•\u0e49à¸­à¸‡";

	/// <summary>
	/// Key: "Response.LoginWithUsername"
	/// error message shown when user attempts to login with method other than username and an error occurred
	/// English String: "Something went wrong. Please login with your username."
	/// </summary>
	public override string ResponseLoginWithUsername => "à¸¡\u0e35à¸šà¸²à¸‡à¸­à¸¢\u0e48à¸²à¸‡à¸œ\u0e34à¸”à¸›à¸à¸•\u0e34 à¸à¸£\u0e38à¸“à¸²à¹€à¸‚\u0e49à¸²à¸ª\u0e39\u0e48à¸£à¸°à¸šà¸šà¸”\u0e49à¸§à¸¢à¸Š\u0e37\u0e48à¸­à¸œ\u0e39\u0e49à¹ƒà¸Š\u0e49à¸‚à¸­à¸‡à¸„\u0e38à¸“";

	/// <summary>
	/// Key: "Response.PasswordNotProvided"
	/// password field is empty
	/// English String: "You must enter a password."
	/// </summary>
	public override string ResponsePasswordNotProvided => "à¸„\u0e38à¸“à¸ˆà¸°à¸•\u0e49à¸­à¸‡à¸›\u0e49à¸­à¸™à¸£à¸«\u0e31à¸ªà¸œ\u0e48à¸²à¸™";

	/// <summary>
	/// Key: "Response.TooManyAttemptsPleaseWait"
	/// English String: "Too many attempts. Please wait a bit."
	/// </summary>
	public override string ResponseTooManyAttemptsPleaseWait => "à¸¡\u0e35à¸à¸²à¸£à¸”à¸³à¹€à¸™\u0e34à¸™à¸à¸²à¸£à¸‹\u0e49à¸³à¸¡à¸²à¸à¹€à¸\u0e34à¸™à¹„à¸› à¸à¸£\u0e38à¸“à¸²à¸£à¸­à¸ª\u0e31à¸à¸„à¸£\u0e39\u0e48";

	/// <summary>
	/// Key: "Response.UnknownError"
	/// English String: "Unknown Error"
	/// </summary>
	public override string ResponseUnknownError => "à¸‚\u0e49à¸­à¸œ\u0e34à¸”à¸žà¸¥à¸²à¸”à¸—\u0e35\u0e48à¹„à¸¡\u0e48à¸—à¸£à¸²à¸šà¸ªà¸²à¹€à¸«à¸•\u0e38";

	/// <summary>
	/// Key: "Response.UnknownLoginError"
	/// Unknown login failure.
	/// English String: "Unknown login failure."
	/// </summary>
	public override string ResponseUnknownLoginError => "à¹€à¸\u0e34à¸”à¸„à¸§à¸²à¸¡à¸œ\u0e34à¸”à¸žà¸¥à¸²à¸”à¹ƒà¸™à¸à¸²à¸£à¹€à¸‚\u0e49à¸²à¸ª\u0e39\u0e48à¸£à¸°à¸šà¸šà¸—\u0e35\u0e48à¹„à¸¡\u0e48à¸—à¸£à¸²à¸šà¸ªà¸²à¹€à¸«à¸•\u0e38";

	/// <summary>
	/// Key: "Response.UnverifiedEmailLoginWithUsername"
	/// error message shown when user attempts to login with unverified email
	/// English String: "Your email is not verified. Please login with your username."
	/// </summary>
	public override string ResponseUnverifiedEmailLoginWithUsername => "à¸­\u0e35à¹€à¸¡à¸¥à¸‚à¸­à¸‡à¸„\u0e38à¸“à¹„à¸¡\u0e48à¹„à¸”\u0e49à¸£\u0e31à¸šà¸à¸²à¸£à¸•à¸£à¸§à¸ˆà¸ªà¸­à¸šà¸„à¸§à¸²à¸¡à¸–\u0e39à¸à¸•\u0e49à¸­à¸‡ à¸à¸£\u0e38à¸“à¸²à¹€à¸‚\u0e49à¸²à¸ª\u0e39\u0e48à¸£à¸°à¸šà¸šà¸”\u0e49à¸§à¸¢à¸Š\u0e37\u0e48à¸­à¸œ\u0e39\u0e49à¹ƒà¸Š\u0e49à¸‚à¸­à¸‡à¸„\u0e38à¸“";

	/// <summary>
	/// Key: "Response.UnverifiedPhoneLoginWithUsername"
	/// error message shown when user attempts to login with an unverified phone number
	/// English String: "Your phone is not verified. Please login with your username."
	/// </summary>
	public override string ResponseUnverifiedPhoneLoginWithUsername => "à¸«à¸¡à¸²à¸¢à¹€à¸¥à¸‚à¹‚à¸—à¸£à¸¨\u0e31à¸žà¸—\u0e4cà¸‚à¸­à¸‡à¸„\u0e38à¸“à¹„à¸¡\u0e48à¹„à¸”\u0e49à¸£\u0e31à¸šà¸à¸²à¸£à¸•à¸£à¸§à¸ˆà¸ªà¸­à¸šà¸„à¸§à¸²à¸¡à¸–\u0e39à¸à¸•\u0e49à¸­à¸‡ à¸à¸£\u0e38à¸“à¸²à¹€à¸‚\u0e49à¸²à¸ª\u0e39\u0e48à¸£à¸°à¸šà¸šà¸”\u0e49à¸§à¸¢à¸Š\u0e37\u0e48à¸­à¸œ\u0e39\u0e49à¹ƒà¸Š\u0e49à¸‚à¸­à¸‡à¸„\u0e38à¸“";

	/// <summary>
	/// Key: "Response.UsernameNotProvided"
	/// username field is empty
	/// English String: "You must enter a username."
	/// </summary>
	public override string ResponseUsernameNotProvided => "à¸„\u0e38à¸“à¸ˆà¸°à¸•\u0e49à¸­à¸‡à¸›\u0e49à¸­à¸™à¸Š\u0e37\u0e48à¸­à¸œ\u0e39\u0e49à¹ƒà¸Š\u0e49";

	/// <summary>
	/// Key: "Response.UseSocialSignOn"
	/// Unable to login. Please use Social Network sign on.
	/// English String: "Unable to login. Please use Social Network sign on."
	/// </summary>
	public override string ResponseUseSocialSignOn => "à¹„à¸¡\u0e48à¸ªà¸²à¸¡à¸²à¸£à¸–à¹€à¸‚\u0e49à¸²à¸ª\u0e39\u0e48à¸£à¸°à¸šà¸šà¹„à¸”\u0e49 à¸à¸£\u0e38à¸“à¸²à¹ƒà¸Š\u0e49à¸š\u0e31à¸à¸Š\u0e35à¹‚à¸‹à¹€à¸Š\u0e35à¸¢à¸¥à¹€à¸™\u0e47à¸•à¹€à¸§\u0e34à¸£\u0e4cà¸„à¹€à¸ž\u0e37\u0e48à¸­à¸¥à¸‡à¸Š\u0e37\u0e48à¸­à¹€à¸‚\u0e49à¸²à¹ƒà¸Š\u0e49à¸‡à¸²à¸™";

	/// <summary>
	/// Key: "WeChat.AntiAddictionText"
	/// English String: "Boycott bad games, refuse pirated games. Be aware of self-defense and being deceived. Playing games is good for your brain, but too much game play can harm your health. Manage your time well and enjoy a healthy lifestyle."
	/// </summary>
	public override string WeChatAntiAddictionText => "à¸šà¸­à¸¢à¸„à¸­à¸•à¸•\u0e4cà¹€à¸à¸¡à¹à¸¢\u0e48à¹† à¸›à¸\u0e34à¹€à¸ªà¸˜à¹€à¸à¸¡à¸¥à¸°à¹€à¸¡\u0e34à¸”à¸¥\u0e34à¸‚à¸ª\u0e34à¸—à¸˜\u0e34\u0e4c à¸£\u0e39\u0e49à¸–\u0e36à¸‡à¸à¸²à¸£à¸›\u0e49à¸­à¸‡à¸\u0e31à¸™à¸•\u0e31à¸§ à¹à¸¥à¸°à¸à¸²à¸£à¸–\u0e39à¸à¸«à¸¥à¸­à¸à¸¥à¸§à¸‡ à¸à¸²à¸£à¹€à¸¥\u0e48à¸™à¹€à¸à¸¡à¸™\u0e31\u0e49à¸™à¸”\u0e35à¸•\u0e48à¸­à¸ªà¸¡à¸­à¸‡à¸‚à¸­à¸‡à¸„\u0e38à¸“ à¹à¸•\u0e48à¸à¸²à¸£à¹€à¸¥\u0e48à¸™à¹€à¸à¸¡à¸¡à¸²à¸à¹€à¸\u0e34à¸™à¹„à¸›à¸\u0e47à¸­à¸²à¸ˆà¹€à¸›\u0e47à¸™à¸­\u0e31à¸™à¸•à¸£à¸²à¸¢à¸•\u0e48à¸­à¸ª\u0e38à¸‚à¸ à¸²à¸žà¸‚à¸­à¸‡à¸„\u0e38à¸“à¹„à¸”\u0e49 à¸šà¸£\u0e34à¸«à¸²à¸£à¹€à¸§à¸¥à¸²à¸‚à¸­à¸‡à¸„\u0e38à¸“à¹ƒà¸«\u0e49à¸”\u0e35 à¹à¸¥\u0e49à¸§à¹ƒà¸Š\u0e49à¸Š\u0e35à¸§\u0e34à¸•à¸—\u0e35\u0e48à¸¡\u0e35à¸ª\u0e38à¸‚à¸ à¸²à¸žà¸”\u0e35";

	/// <summary>
	/// Key: "WeChat.RealNameNotVerified"
	/// English String: "Your WeChat is not real-name verified. Please use a real-name verified WeChat account and try again. Please visit https://jiazhang.qq.com/zk/home.html"
	/// </summary>
	public override string WeChatRealNameNotVerified => "à¸š\u0e31à¸à¸Š\u0e35 WeChat à¸‚à¸­à¸‡à¸„\u0e38à¸“à¸¢\u0e31à¸‡à¹„à¸¡\u0e48à¹„à¸”\u0e49à¸—à¸³à¸à¸²à¸£à¸¢\u0e37à¸™à¸¢\u0e31à¸™à¸Š\u0e37\u0e48à¸­à¸ˆà¸£\u0e34à¸‡ à¸à¸£\u0e38à¸“à¸²à¸—à¸³à¸à¸²à¸£à¸¢\u0e37à¸™à¸¢\u0e31à¸™à¸Š\u0e37\u0e48à¸­à¸ˆà¸£\u0e34à¸‡à¸ªà¸³à¸«à¸£\u0e31à¸šà¸š\u0e31à¸à¸Š\u0e35 WeChat à¹à¸¥\u0e49à¸§à¸¥à¸­à¸‡à¹ƒà¸«à¸¡\u0e48à¸­\u0e35à¸à¸„à¸£\u0e31\u0e49à¸‡ à¸à¸£\u0e38à¸“à¸²à¹„à¸›à¸—\u0e35\u0e48 https://jiazhang.qq.com/zk/home.html";

	public LoginResources_th_th(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionCancel()
	{
		return "à¸¢à¸à¹€à¸¥\u0e34à¸";
	}

	protected override string _GetTemplateForActionFacebook()
	{
		return "Facebook";
	}

	protected override string _GetTemplateForActionForgotPasswordOrUsernameQuestion()
	{
		return "à¸¥\u0e37à¸¡à¸£à¸«\u0e31à¸ªà¸œ\u0e48à¸²à¸™à¸«à¸£\u0e37à¸­à¸Š\u0e37\u0e48à¸­à¸œ\u0e39\u0e49à¹ƒà¸Š\u0e49?";
	}

	protected override string _GetTemplateForActionForgotPasswordOrUsernameQuestionCapitalized()
	{
		return "à¸¥\u0e37à¸¡à¸£à¸«\u0e31à¸ªà¸œ\u0e48à¸²à¸™à¸«à¸£\u0e37à¸­à¸Š\u0e37\u0e48à¸­à¸œ\u0e39\u0e49à¹ƒà¸Š\u0e49?";
	}

	protected override string _GetTemplateForActionLogin()
	{
		return "à¹€à¸‚\u0e49à¸²à¸ª\u0e39\u0e48à¸£à¸°à¸šà¸š";
	}

	protected override string _GetTemplateForActionLogInCapitalized()
	{
		return "à¹€à¸‚\u0e49à¸²à¸ª\u0e39\u0e48à¸£à¸°à¸šà¸š";
	}

	protected override string _GetTemplateForActionOk()
	{
		return "à¸•à¸à¸¥à¸‡";
	}

	protected override string _GetTemplateForActionPlayAsGuest()
	{
		return "à¹€à¸¥\u0e48à¸™à¹ƒà¸™à¸à¸²à¸™à¸°à¹à¸‚à¸";
	}

	protected override string _GetTemplateForActionResend()
	{
		return "à¸ª\u0e48à¸‡à¸­\u0e35à¸à¸„à¸£\u0e31\u0e49à¸‡";
	}

	protected override string _GetTemplateForActionResendEmail()
	{
		return "à¸ª\u0e48à¸‡à¸­\u0e35à¹€à¸¡à¸¥à¹ƒà¸«à¸¡\u0e48";
	}

	protected override string _GetTemplateForActionSendVerificationEmail()
	{
		return "à¸ª\u0e48à¸‡à¸­\u0e35à¹€à¸¡à¸¥à¸¢\u0e37à¸™à¸¢\u0e31à¸™";
	}

	protected override string _GetTemplateForActionSignIn()
	{
		return "à¸¥à¸‡à¸Š\u0e37\u0e48à¸­à¹€à¸‚\u0e49à¸²à¹ƒà¸Š\u0e49à¸‡à¸²à¸™";
	}

	protected override string _GetTemplateForActionSignInWithFacebook()
	{
		return "à¸¥à¸‡à¸Š\u0e37\u0e48à¸­à¹€à¸‚\u0e49à¸²à¹ƒà¸Š\u0e49à¸‡à¸²à¸™à¸”\u0e49à¸§à¸¢ Facebook";
	}

	protected override string _GetTemplateForActionSignUp()
	{
		return "à¸ªà¸¡\u0e31à¸„à¸£à¸š\u0e31à¸à¸Š\u0e35";
	}

	protected override string _GetTemplateForActionSignUpCapitalized()
	{
		return "à¸ªà¸¡\u0e31à¸„à¸£à¸š\u0e31à¸à¸Š\u0e35à¸œ\u0e39\u0e49à¹ƒà¸Š\u0e49";
	}

	protected override string _GetTemplateForActionWeChatLogin()
	{
		return "à¹€à¸‚\u0e49à¸²à¸ª\u0e39\u0e48à¸£à¸°à¸šà¸š WeChat";
	}

	protected override string _GetTemplateForHeadingLogin()
	{
		return "à¹€à¸‚\u0e49à¸²à¸ª\u0e39\u0e48à¸£à¸°à¸šà¸š";
	}

	protected override string _GetTemplateForHeadingLoginRoblox()
	{
		return "à¹€à¸‚\u0e49à¸²à¸ª\u0e39\u0e48à¸£à¸°à¸šà¸š Roblox";
	}

	protected override string _GetTemplateForHeadingSignUpMakeFriends()
	{
		return "à¸ªà¸¡\u0e31à¸„à¸£à¸š\u0e31à¸à¸Š\u0e35à¹€à¸ž\u0e37\u0e48à¸­à¸\u0e48à¸­à¸ªà¸£\u0e49à¸²à¸‡à¹à¸¥à¸°à¸«à¸²à¹€à¸ž\u0e37\u0e48à¸­à¸™à¸¡à¸²à¸à¸‚\u0e36\u0e49à¸™";
	}

	protected override string _GetTemplateForLabelAccountNotNeeded()
	{
		return "à¸„\u0e38à¸“à¹„à¸¡\u0e48à¸ˆà¸³à¹€à¸›\u0e47à¸™à¸•\u0e49à¸­à¸‡à¸¡\u0e35à¸š\u0e31à¸à¸Š\u0e35à¹€à¸ž\u0e37\u0e48à¸­à¸—\u0e35\u0e48à¸ˆà¸°à¹€à¸¥\u0e48à¸™ Roblox";
	}

	protected override string _GetTemplateForLabelEmailNeedsVerification()
	{
		return "à¸­\u0e35à¹€à¸¡à¸¥à¸‚à¸­à¸‡à¸„\u0e38à¸“à¸ˆà¸³à¹€à¸›\u0e47à¸™à¸•\u0e49à¸­à¸‡à¹„à¸”\u0e49à¸£\u0e31à¸šà¸à¸²à¸£à¸¢\u0e37à¸™à¸¢\u0e31à¸™";
	}

	protected override string _GetTemplateForLabelFacebookCreatePasswordWarning()
	{
		return "à¸«à¸²à¸à¸„\u0e38à¸“à¹„à¸”\u0e49à¹ƒà¸Š\u0e49à¸à¸²à¸£à¸¥à¸‡à¸Š\u0e37\u0e48à¸­à¹€à¸‚\u0e49à¸²à¸ª\u0e39\u0e48à¸£à¸°à¸šà¸šà¸”\u0e49à¸§à¸¢ Facebook à¸¡à¸²à¸\u0e48à¸­à¸™ à¸„\u0e38à¸“à¸ˆà¸°à¸•\u0e49à¸­à¸‡à¸•\u0e31\u0e49à¸‡à¸£à¸«\u0e31à¸ªà¸œ\u0e48à¸²à¸™";
	}

	protected override string _GetTemplateForLabelForgotUsernamePassword()
	{
		return "à¸¥\u0e37à¸¡à¸Š\u0e37\u0e48à¸­à¸œ\u0e39\u0e49à¹ƒà¸Š\u0e49/à¸£à¸«\u0e31à¸ªà¸œ\u0e48à¸²à¸™à¸­à¸¢\u0e48à¸²à¸‡à¸™\u0e31\u0e49à¸™à¸«à¸£\u0e37à¸­?";
	}

	/// <summary>
	/// Key: "Label.GreetingForNewAccount"
	/// Shown when a username doesn't exist on the login page to invite to create a new account.
	/// English String: "Nice to meet you, {username}. {linkStartSignup}Let's make an account! {linkEndSignup}"
	/// </summary>
	public override string LabelGreetingForNewAccount(string username, string linkStartSignup, string linkEndSignup)
	{
		return $"à¸¢\u0e34à¸™à¸”\u0e35à¸—\u0e35\u0e48à¹„à¸”\u0e49à¸£\u0e39\u0e49à¸ˆ\u0e31à¸ à¸„\u0e38à¸“ {username} {linkStartSignup}à¹€à¸£à¸²à¸¡à¸²à¸ªà¸£\u0e49à¸²à¸‡à¸š\u0e31à¸à¸Š\u0e35à¸\u0e31à¸™! {linkEndSignup}";
	}

	protected override string _GetTemplateForLabelGreetingForNewAccount()
	{
		return "à¸¢\u0e34à¸™à¸”\u0e35à¸—\u0e35\u0e48à¹„à¸”\u0e49à¸£\u0e39\u0e49à¸ˆ\u0e31à¸ à¸„\u0e38à¸“ {username} {linkStartSignup}à¹€à¸£à¸²à¸¡à¸²à¸ªà¸£\u0e49à¸²à¸‡à¸š\u0e31à¸à¸Š\u0e35à¸\u0e31à¸™! {linkEndSignup}";
	}

	protected override string _GetTemplateForLabelLearnMore()
	{
		return "à¹€à¸£\u0e35à¸¢à¸™à¸£\u0e39\u0e49à¹€à¸ž\u0e34\u0e48à¸¡à¹€à¸•\u0e34à¸¡";
	}

	protected override string _GetTemplateForLabelLoggingInSpinnerText()
	{
		return "à¸à¸³à¸¥\u0e31à¸‡à¹€à¸‚\u0e49à¸²à¸ª\u0e39\u0e48à¸£à¸°à¸šà¸šâ€¦";
	}

	protected override string _GetTemplateForLabelLogin()
	{
		return "à¹€à¸‚\u0e49à¸²à¸ª\u0e39\u0e48à¸£à¸°à¸šà¸š";
	}

	protected override string _GetTemplateForLabelLoginWithYour()
	{
		return "à¸¡\u0e35à¸šà¸²à¸‡à¸­à¸¢\u0e48à¸²à¸‡à¸œ\u0e34à¸”à¸›à¸à¸•\u0e34 à¸à¸£\u0e38à¸“à¸²à¹€à¸‚\u0e49à¸²à¸ª\u0e39\u0e48à¸š\u0e31à¸à¸Š\u0e35à¸‚à¸­à¸‡à¸„\u0e38à¸“";
	}

	protected override string _GetTemplateForLabelNoAccount()
	{
		return "à¸¢\u0e31à¸‡à¹„à¸¡\u0e48à¸¡\u0e35à¸š\u0e31à¸à¸Š\u0e35à¸«à¸£\u0e37à¸­?";
	}

	protected override string _GetTemplateForLabelNonAMemberQuestion()
	{
		return "à¹„à¸¡\u0e48à¹ƒà¸Š\u0e48à¸ªà¸¡à¸²à¸Š\u0e34à¸à¸­à¸¢\u0e48à¸²à¸‡à¸™\u0e31\u0e49à¸™à¸«à¸£\u0e37à¸­?";
	}

	protected override string _GetTemplateForLabelNotReceived()
	{
		return "à¸„\u0e38à¸“à¹„à¸¡\u0e48à¹„à¸”\u0e49à¸£\u0e31à¸šà¸­\u0e35à¹€à¸¡à¸¥à¸­à¸¢\u0e48à¸²à¸‡à¸™\u0e31\u0e49à¸™à¸«à¸£\u0e37à¸­?";
	}

	protected override string _GetTemplateForLabelOr()
	{
		return "à¸«à¸£\u0e37à¸­";
	}

	protected override string _GetTemplateForLabelPassword()
	{
		return "à¸£à¸«\u0e31à¸ªà¸œ\u0e48à¸²à¸™";
	}

	protected override string _GetTemplateForLabelPasswordWithColumn()
	{
		return "à¸£à¸«\u0e31à¸ªà¸œ\u0e48à¸²à¸™:";
	}

	protected override string _GetTemplateForLabelStartPlaying()
	{
		return "à¸„\u0e38à¸“à¸ªà¸²à¸¡à¸²à¸£à¸–à¹€à¸£\u0e34\u0e48à¸¡à¸•\u0e49à¸™à¹€à¸¥\u0e48à¸™à¹„à¸”\u0e49à¸•à¸­à¸™à¸™\u0e35\u0e49à¹€à¸¥à¸¢ à¹ƒà¸™à¹‚à¸«à¸¡à¸”à¹à¸‚à¸!";
	}

	protected override string _GetTemplateForLabelUnverifiedEmailInstructions()
	{
		return "à¸«à¸²à¸à¸•\u0e49à¸­à¸‡à¸à¸²à¸£à¹€à¸‚\u0e49à¸²à¸ª\u0e39\u0e48à¸£à¸°à¸šà¸šà¸”\u0e49à¸§à¸¢à¸­\u0e35à¹€à¸¡à¸¥à¸‚à¸­à¸‡à¸„\u0e38à¸“ à¸„\u0e38à¸“à¸ˆà¸°à¸•\u0e49à¸­à¸‡à¸—à¸³à¸à¸²à¸£à¸¢\u0e37à¸™à¸¢\u0e31à¸™à¸­\u0e35à¹€à¸¡à¸¥à¸™\u0e31\u0e49à¸™à¸\u0e48à¸­à¸™ à¸„\u0e38à¸“à¸¢\u0e31à¸‡à¸ªà¸²à¸¡à¸²à¸£à¸–à¹€à¸‚\u0e49à¸²à¸ª\u0e39\u0e48à¸£à¸°à¸šà¸šà¸”\u0e49à¸§à¸¢à¸Š\u0e37\u0e48à¸­à¸œ\u0e39\u0e49à¹ƒà¸Š\u0e49à¸‚à¸­à¸‡à¸„\u0e38à¸“à¹„à¸”\u0e49";
	}

	protected override string _GetTemplateForLabelUsername()
	{
		return "à¸Š\u0e37\u0e48à¸­à¸œ\u0e39\u0e49à¹ƒà¸Š\u0e49";
	}

	protected override string _GetTemplateForLabelUsernameEmail()
	{
		return "à¸Š\u0e37\u0e48à¸­à¸œ\u0e39\u0e49à¹ƒà¸Š\u0e49/à¸­\u0e35à¹€à¸¡à¸¥";
	}

	protected override string _GetTemplateForLabelUsernameEmailPhone()
	{
		return "à¸Š\u0e37\u0e48à¸­à¸œ\u0e39\u0e49à¹ƒà¸Š\u0e49/à¸­\u0e35à¹€à¸¡à¸¥/à¸«à¸¡à¸²à¸¢à¹€à¸¥à¸‚à¹‚à¸—à¸£à¸¨\u0e31à¸žà¸—\u0e4c";
	}

	protected override string _GetTemplateForLabelUsernamePhone()
	{
		return "à¸Š\u0e37\u0e48à¸­à¸œ\u0e39\u0e49à¹ƒà¸Š\u0e49/à¸«à¸¡à¸²à¸¢à¹€à¸¥à¸‚à¹‚à¸—à¸£à¸¨\u0e31à¸žà¸—\u0e4c";
	}

	protected override string _GetTemplateForLabelUsernameWithColumn()
	{
		return "à¸Š\u0e37\u0e48à¸­à¸œ\u0e39\u0e49à¹ƒà¸Š\u0e49:";
	}

	protected override string _GetTemplateForLabelVerificationEmailSent()
	{
		return "à¸ª\u0e48à¸‡à¸­\u0e35à¹€à¸¡à¸¥à¸¢\u0e37à¸™à¸¢\u0e31à¸™à¹à¸¥\u0e49à¸§!";
	}

	protected override string _GetTemplateForLabelWeChatAntiAddictionText()
	{
		return "à¸šà¸­à¸¢à¸„à¸­à¸•à¸•\u0e4cà¹€à¸à¸¡à¹à¸¢\u0e48à¹† à¸›à¸\u0e34à¹€à¸ªà¸˜à¹€à¸à¸¡à¸¥à¸°à¹€à¸¡\u0e34à¸”à¸¥\u0e34à¸‚à¸ª\u0e34à¸—à¸˜\u0e34\u0e4c à¸£\u0e39\u0e49à¸–\u0e36à¸‡à¸à¸²à¸£à¸›\u0e49à¸­à¸‡à¸\u0e31à¸™à¸•\u0e31à¸§à¹à¸¥à¸°à¸à¸²à¸£à¸–\u0e39à¸à¸«à¸¥à¸­à¸à¸¥à¸§à¸‡ à¸à¸²à¸£à¹€à¸¥\u0e48à¸™à¹€à¸à¸¡à¸™\u0e31\u0e49à¸™à¸”\u0e35à¸•\u0e48à¸­à¸ªà¸¡à¸­à¸‡à¸‚à¸­à¸‡à¸„\u0e38à¸“ à¹à¸•\u0e48à¸à¸²à¸£à¹€à¸¥\u0e48à¸™à¹€à¸à¸¡à¸¡à¸²à¸à¹€à¸\u0e34à¸™à¹„à¸›à¸\u0e47à¸­à¸²à¸ˆà¹€à¸›\u0e47à¸™à¸­\u0e31à¸™à¸•à¸£à¸²à¸¢à¸•\u0e48à¸­à¸ª\u0e38à¸‚à¸ à¸²à¸žà¸‚à¸­à¸‡à¸„\u0e38à¸“à¹„à¸”\u0e49 à¸šà¸£\u0e34à¸«à¸²à¸£à¹€à¸§à¸¥à¸²à¸‚à¸­à¸‡à¸„\u0e38à¸“à¹ƒà¸«\u0e49à¸”\u0e35 à¹à¸¥\u0e49à¸§à¹ƒà¸Š\u0e49à¸Š\u0e35à¸§\u0e34à¸•à¸—\u0e35\u0e48à¸¡\u0e35à¸ª\u0e38à¸‚à¸ à¸²à¸žà¸”\u0e35";
	}

	protected override string _GetTemplateForMessageUnknownErrorTryAgain()
	{
		return "à¹€à¸\u0e34à¸”à¸‚\u0e49à¸­à¸œ\u0e34à¸”à¸žà¸¥à¸²à¸”à¸—\u0e35\u0e48à¹„à¸¡\u0e48à¸—à¸£à¸²à¸šà¸ªà¸²à¹€à¸«à¸•\u0e38 à¸à¸£\u0e38à¸“à¸²à¸¥à¸­à¸‡à¹ƒà¸«à¸¡\u0e48à¸­\u0e35à¸à¸„à¸£\u0e31\u0e49à¸‡";
	}

	protected override string _GetTemplateForMessageUsernameAndPasswordRequired()
	{
		return "à¸ˆà¸³à¹€à¸›\u0e47à¸™à¸•\u0e49à¸­à¸‡à¸¡\u0e35à¸Š\u0e37\u0e48à¸­à¸œ\u0e39\u0e49à¹ƒà¸Š\u0e49à¹à¸¥à¸°à¸£à¸«\u0e31à¸ªà¸œ\u0e48à¸²à¸™";
	}

	protected override string _GetTemplateForResponseAccountIssueErrorContactSupport()
	{
		return "à¸›\u0e31à¸à¸«à¸²à¸”\u0e49à¸²à¸™à¸š\u0e31à¸à¸Š\u0e35 à¸à¸£\u0e38à¸“à¸²à¸•\u0e34à¸”à¸•\u0e48à¸­à¸\u0e48à¸²à¸¢à¸ªà¸™\u0e31à¸šà¸ªà¸™\u0e38à¸™";
	}

	protected override string _GetTemplateForResponseAccountLockedRequestReset()
	{
		return "à¸š\u0e31à¸à¸Š\u0e35à¸–\u0e39à¸à¸¥\u0e47à¸­à¸„ à¸à¸£\u0e38à¸“à¸²à¸‚à¸­à¸à¸²à¸£à¸£\u0e35à¹€à¸‹\u0e47à¸•à¸£à¸«\u0e31à¸ªà¸œ\u0e48à¸²à¸™";
	}

	protected override string _GetTemplateForResponseAccountNotFound()
	{
		return "à¹„à¸¡\u0e48à¸žà¸šà¸š\u0e31à¸à¸Š\u0e35 à¸à¸£\u0e38à¸“à¸²à¸¥à¸­à¸‡à¹ƒà¸«à¸¡\u0e48à¸­\u0e35à¸à¸„à¸£\u0e31\u0e49à¸‡";
	}

	protected override string _GetTemplateForResponseEmailLinkedToMultipleAccountsLoginWithUsername()
	{
		return "à¸­\u0e35à¹€à¸¡à¸¥à¸‚à¸­à¸‡à¸„\u0e38à¸“à¹€à¸Š\u0e37\u0e48à¸­à¸¡à¹‚à¸¢à¸‡à¸\u0e31à¸šà¸Š\u0e37\u0e48à¸­à¸œ\u0e39\u0e49à¹ƒà¸Š\u0e49à¸¡à¸²à¸à¸à¸§\u0e48à¸² 1 à¸š\u0e31à¸à¸Š\u0e35 à¸à¸£\u0e38à¸“à¸²à¹€à¸‚\u0e49à¸²à¸ª\u0e39\u0e48à¸£à¸°à¸šà¸šà¸”\u0e49à¸§à¸¢à¸Š\u0e37\u0e48à¸­à¸œ\u0e39\u0e49à¹ƒà¸Š\u0e49à¸‚à¸­à¸‡à¸„\u0e38à¸“";
	}

	protected override string _GetTemplateForResponseEmailSent()
	{
		return "à¸ª\u0e48à¸‡à¸­\u0e35à¹€à¸¡à¸¥à¹à¸¥\u0e49à¸§!";
	}

	protected override string _GetTemplateForResponseIncorrectEmailOrPassword()
	{
		return "à¸­\u0e35à¹€à¸¡à¸¥à¸«à¸£\u0e37à¸­à¸£à¸«\u0e31à¸ªà¸œ\u0e48à¸²à¸™à¹„à¸¡\u0e48à¸–\u0e39à¸à¸•\u0e49à¸­à¸‡";
	}

	protected override string _GetTemplateForResponseIncorrectPhoneOrPassword()
	{
		return "à¸«à¸¡à¸²à¸¢à¹€à¸¥à¸‚à¹‚à¸—à¸£à¸¨\u0e31à¸žà¸—\u0e4cà¸«à¸£\u0e37à¸­à¸£à¸«\u0e31à¸ªà¸œ\u0e48à¸²à¸™à¹„à¸¡\u0e48à¸–\u0e39à¸à¸•\u0e49à¸­à¸‡";
	}

	protected override string _GetTemplateForResponseIncorrectUsernamePassword()
	{
		return "à¸Š\u0e37\u0e48à¸­à¸œ\u0e39\u0e49à¹ƒà¸Š\u0e49à¸«à¸£\u0e37à¸­à¸£à¸«\u0e31à¸ªà¸œ\u0e48à¸²à¸™à¹„à¸¡\u0e48à¸–\u0e39à¸à¸•\u0e49à¸­à¸‡";
	}

	protected override string _GetTemplateForResponseLoginWithUsername()
	{
		return "à¸¡\u0e35à¸šà¸²à¸‡à¸­à¸¢\u0e48à¸²à¸‡à¸œ\u0e34à¸”à¸›à¸à¸•\u0e34 à¸à¸£\u0e38à¸“à¸²à¹€à¸‚\u0e49à¸²à¸ª\u0e39\u0e48à¸£à¸°à¸šà¸šà¸”\u0e49à¸§à¸¢à¸Š\u0e37\u0e48à¸­à¸œ\u0e39\u0e49à¹ƒà¸Š\u0e49à¸‚à¸­à¸‡à¸„\u0e38à¸“";
	}

	protected override string _GetTemplateForResponsePasswordNotProvided()
	{
		return "à¸„\u0e38à¸“à¸ˆà¸°à¸•\u0e49à¸­à¸‡à¸›\u0e49à¸­à¸™à¸£à¸«\u0e31à¸ªà¸œ\u0e48à¸²à¸™";
	}

	protected override string _GetTemplateForResponseTooManyAttemptsPleaseWait()
	{
		return "à¸¡\u0e35à¸à¸²à¸£à¸”à¸³à¹€à¸™\u0e34à¸™à¸à¸²à¸£à¸‹\u0e49à¸³à¸¡à¸²à¸à¹€à¸\u0e34à¸™à¹„à¸› à¸à¸£\u0e38à¸“à¸²à¸£à¸­à¸ª\u0e31à¸à¸„à¸£\u0e39\u0e48";
	}

	protected override string _GetTemplateForResponseUnknownError()
	{
		return "à¸‚\u0e49à¸­à¸œ\u0e34à¸”à¸žà¸¥à¸²à¸”à¸—\u0e35\u0e48à¹„à¸¡\u0e48à¸—à¸£à¸²à¸šà¸ªà¸²à¹€à¸«à¸•\u0e38";
	}

	protected override string _GetTemplateForResponseUnknownLoginError()
	{
		return "à¹€à¸\u0e34à¸”à¸„à¸§à¸²à¸¡à¸œ\u0e34à¸”à¸žà¸¥à¸²à¸”à¹ƒà¸™à¸à¸²à¸£à¹€à¸‚\u0e49à¸²à¸ª\u0e39\u0e48à¸£à¸°à¸šà¸šà¸—\u0e35\u0e48à¹„à¸¡\u0e48à¸—à¸£à¸²à¸šà¸ªà¸²à¹€à¸«à¸•\u0e38";
	}

	protected override string _GetTemplateForResponseUnverifiedEmailLoginWithUsername()
	{
		return "à¸­\u0e35à¹€à¸¡à¸¥à¸‚à¸­à¸‡à¸„\u0e38à¸“à¹„à¸¡\u0e48à¹„à¸”\u0e49à¸£\u0e31à¸šà¸à¸²à¸£à¸•à¸£à¸§à¸ˆà¸ªà¸­à¸šà¸„à¸§à¸²à¸¡à¸–\u0e39à¸à¸•\u0e49à¸­à¸‡ à¸à¸£\u0e38à¸“à¸²à¹€à¸‚\u0e49à¸²à¸ª\u0e39\u0e48à¸£à¸°à¸šà¸šà¸”\u0e49à¸§à¸¢à¸Š\u0e37\u0e48à¸­à¸œ\u0e39\u0e49à¹ƒà¸Š\u0e49à¸‚à¸­à¸‡à¸„\u0e38à¸“";
	}

	protected override string _GetTemplateForResponseUnverifiedPhoneLoginWithUsername()
	{
		return "à¸«à¸¡à¸²à¸¢à¹€à¸¥à¸‚à¹‚à¸—à¸£à¸¨\u0e31à¸žà¸—\u0e4cà¸‚à¸­à¸‡à¸„\u0e38à¸“à¹„à¸¡\u0e48à¹„à¸”\u0e49à¸£\u0e31à¸šà¸à¸²à¸£à¸•à¸£à¸§à¸ˆà¸ªà¸­à¸šà¸„à¸§à¸²à¸¡à¸–\u0e39à¸à¸•\u0e49à¸­à¸‡ à¸à¸£\u0e38à¸“à¸²à¹€à¸‚\u0e49à¸²à¸ª\u0e39\u0e48à¸£à¸°à¸šà¸šà¸”\u0e49à¸§à¸¢à¸Š\u0e37\u0e48à¸­à¸œ\u0e39\u0e49à¹ƒà¸Š\u0e49à¸‚à¸­à¸‡à¸„\u0e38à¸“";
	}

	protected override string _GetTemplateForResponseUsernameNotProvided()
	{
		return "à¸„\u0e38à¸“à¸ˆà¸°à¸•\u0e49à¸­à¸‡à¸›\u0e49à¸­à¸™à¸Š\u0e37\u0e48à¸­à¸œ\u0e39\u0e49à¹ƒà¸Š\u0e49";
	}

	protected override string _GetTemplateForResponseUseSocialSignOn()
	{
		return "à¹„à¸¡\u0e48à¸ªà¸²à¸¡à¸²à¸£à¸–à¹€à¸‚\u0e49à¸²à¸ª\u0e39\u0e48à¸£à¸°à¸šà¸šà¹„à¸”\u0e49 à¸à¸£\u0e38à¸“à¸²à¹ƒà¸Š\u0e49à¸š\u0e31à¸à¸Š\u0e35à¹‚à¸‹à¹€à¸Š\u0e35à¸¢à¸¥à¹€à¸™\u0e47à¸•à¹€à¸§\u0e34à¸£\u0e4cà¸„à¹€à¸ž\u0e37\u0e48à¸­à¸¥à¸‡à¸Š\u0e37\u0e48à¸­à¹€à¸‚\u0e49à¸²à¹ƒà¸Š\u0e49à¸‡à¸²à¸™";
	}

	/// <summary>
	/// Key: "Response.WeChatNotRealNameVerified"
	/// English String: "Your WeChat is not real-name verified. Please use a real-name verified WeChat account and try again. Please visit {url}"
	/// </summary>
	public override string ResponseWeChatNotRealNameVerified(string url)
	{
		return $"à¸š\u0e31à¸à¸Š\u0e35 WeChat à¸‚à¸­à¸‡à¸„\u0e38à¸“à¸¢\u0e31à¸‡à¹„à¸¡\u0e48à¹„à¸”\u0e49à¸—à¸³à¸à¸²à¸£à¸¢\u0e37à¸™à¸¢\u0e31à¸™à¸Š\u0e37\u0e48à¸­à¸ˆà¸£\u0e34à¸‡ à¸à¸£\u0e38à¸“à¸²à¸—à¸³à¸à¸²à¸£à¸¢\u0e37à¸™à¸¢\u0e31à¸™à¸Š\u0e37\u0e48à¸­à¸ˆà¸£\u0e34à¸‡à¸ªà¸³à¸«à¸£\u0e31à¸šà¸š\u0e31à¸à¸Š\u0e35 WeChat à¹à¸¥\u0e49à¸§à¸¥à¸­à¸‡à¹ƒà¸«à¸¡\u0e48à¸­\u0e35à¸à¸„à¸£\u0e31\u0e49à¸‡ à¸à¸£\u0e38à¸“à¸²à¹„à¸›à¸—\u0e35\u0e48 {url}";
	}

	protected override string _GetTemplateForResponseWeChatNotRealNameVerified()
	{
		return "à¸š\u0e31à¸à¸Š\u0e35 WeChat à¸‚à¸­à¸‡à¸„\u0e38à¸“à¸¢\u0e31à¸‡à¹„à¸¡\u0e48à¹„à¸”\u0e49à¸—à¸³à¸à¸²à¸£à¸¢\u0e37à¸™à¸¢\u0e31à¸™à¸Š\u0e37\u0e48à¸­à¸ˆà¸£\u0e34à¸‡ à¸à¸£\u0e38à¸“à¸²à¸—à¸³à¸à¸²à¸£à¸¢\u0e37à¸™à¸¢\u0e31à¸™à¸Š\u0e37\u0e48à¸­à¸ˆà¸£\u0e34à¸‡à¸ªà¸³à¸«à¸£\u0e31à¸šà¸š\u0e31à¸à¸Š\u0e35 WeChat à¹à¸¥\u0e49à¸§à¸¥à¸­à¸‡à¹ƒà¸«à¸¡\u0e48à¸­\u0e35à¸à¸„à¸£\u0e31\u0e49à¸‡ à¸à¸£\u0e38à¸“à¸²à¹„à¸›à¸—\u0e35\u0e48 {url}";
	}

	protected override string _GetTemplateForWeChatAntiAddictionText()
	{
		return "à¸šà¸­à¸¢à¸„à¸­à¸•à¸•\u0e4cà¹€à¸à¸¡à¹à¸¢\u0e48à¹† à¸›à¸\u0e34à¹€à¸ªà¸˜à¹€à¸à¸¡à¸¥à¸°à¹€à¸¡\u0e34à¸”à¸¥\u0e34à¸‚à¸ª\u0e34à¸—à¸˜\u0e34\u0e4c à¸£\u0e39\u0e49à¸–\u0e36à¸‡à¸à¸²à¸£à¸›\u0e49à¸­à¸‡à¸\u0e31à¸™à¸•\u0e31à¸§ à¹à¸¥à¸°à¸à¸²à¸£à¸–\u0e39à¸à¸«à¸¥à¸­à¸à¸¥à¸§à¸‡ à¸à¸²à¸£à¹€à¸¥\u0e48à¸™à¹€à¸à¸¡à¸™\u0e31\u0e49à¸™à¸”\u0e35à¸•\u0e48à¸­à¸ªà¸¡à¸­à¸‡à¸‚à¸­à¸‡à¸„\u0e38à¸“ à¹à¸•\u0e48à¸à¸²à¸£à¹€à¸¥\u0e48à¸™à¹€à¸à¸¡à¸¡à¸²à¸à¹€à¸\u0e34à¸™à¹„à¸›à¸\u0e47à¸­à¸²à¸ˆà¹€à¸›\u0e47à¸™à¸­\u0e31à¸™à¸•à¸£à¸²à¸¢à¸•\u0e48à¸­à¸ª\u0e38à¸‚à¸ à¸²à¸žà¸‚à¸­à¸‡à¸„\u0e38à¸“à¹„à¸”\u0e49 à¸šà¸£\u0e34à¸«à¸²à¸£à¹€à¸§à¸¥à¸²à¸‚à¸­à¸‡à¸„\u0e38à¸“à¹ƒà¸«\u0e49à¸”\u0e35 à¹à¸¥\u0e49à¸§à¹ƒà¸Š\u0e49à¸Š\u0e35à¸§\u0e34à¸•à¸—\u0e35\u0e48à¸¡\u0e35à¸ª\u0e38à¸‚à¸ à¸²à¸žà¸”\u0e35";
	}

	protected override string _GetTemplateForWeChatRealNameNotVerified()
	{
		return "à¸š\u0e31à¸à¸Š\u0e35 WeChat à¸‚à¸­à¸‡à¸„\u0e38à¸“à¸¢\u0e31à¸‡à¹„à¸¡\u0e48à¹„à¸”\u0e49à¸—à¸³à¸à¸²à¸£à¸¢\u0e37à¸™à¸¢\u0e31à¸™à¸Š\u0e37\u0e48à¸­à¸ˆà¸£\u0e34à¸‡ à¸à¸£\u0e38à¸“à¸²à¸—à¸³à¸à¸²à¸£à¸¢\u0e37à¸™à¸¢\u0e31à¸™à¸Š\u0e37\u0e48à¸­à¸ˆà¸£\u0e34à¸‡à¸ªà¸³à¸«à¸£\u0e31à¸šà¸š\u0e31à¸à¸Š\u0e35 WeChat à¹à¸¥\u0e49à¸§à¸¥à¸­à¸‡à¹ƒà¸«à¸¡\u0e48à¸­\u0e35à¸à¸„à¸£\u0e31\u0e49à¸‡ à¸à¸£\u0e38à¸“à¸²à¹„à¸›à¸—\u0e35\u0e48 https://jiazhang.qq.com/zk/home.html";
	}
}


}
