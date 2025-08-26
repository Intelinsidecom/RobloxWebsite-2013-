namespace Roblox.Platform.TranslationResources.Authentication {
    /// <summary>

/// This class overrides LoginResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class LoginResources_ru_ru : LoginResources_en_us, ILoginResources, ITranslationResources
{
	/// <summary>
	/// Key: "Action.Cancel"
	/// Cancel button text
	/// English String: "Cancel"
	/// </summary>
	public override string ActionCancel => "ÐžÑ‚Ð¼ÐµÐ½Ð°";

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
	public override string ActionForgotPasswordOrUsernameQuestion => "Ð—Ð°Ð±Ñ‹Ð»Ð¸ Ð¿Ð°Ñ€Ð¾Ð»ÑŒ Ð¸Ð»Ð¸ Ð¸Ð¼Ñ Ð¿Ð¾Ð»ÑŒÐ·Ð¾Ð²Ð°Ñ‚ÐµÐ»Ñ?";

	/// <summary>
	/// Key: "Action.ForgotPasswordOrUsernameQuestionCapitalized"
	/// link under login form
	/// English String: "Forgot Password or Username?"
	/// </summary>
	public override string ActionForgotPasswordOrUsernameQuestionCapitalized => "Ð—Ð°Ð±Ñ‹Ð»Ð¸ Ð¿Ð°Ñ€Ð¾Ð»ÑŒ Ð¸Ð»Ð¸ Ð¸Ð¼Ñ Ð¿Ð¾Ð»ÑŒÐ·Ð¾Ð²Ð°Ñ‚ÐµÐ»Ñ?";

	/// <summary>
	/// Key: "Action.Login"
	/// English String: "Login"
	/// </summary>
	public override string ActionLogin => "Ð’Ñ…Ð¾Ð´";

	/// <summary>
	/// Key: "Action.LogInCapitalized"
	/// login button label. please note this is different from 'Login' or 'Log in'.
	/// English String: "Log In"
	/// </summary>
	public override string ActionLogInCapitalized => "Ð’Ñ…Ð¾Ð´";

	/// <summary>
	/// Key: "Action.Ok"
	/// button text
	/// English String: "OK"
	/// </summary>
	public override string ActionOk => "OK";

	/// <summary>
	/// Key: "Action.PlayAsGuest"
	/// Play as Guest
	/// English String: "Play as Guest"
	/// </summary>
	public override string ActionPlayAsGuest => "Ð˜Ð³Ñ€Ð°Ñ‚ÑŒ Ð² Ð³Ð¾ÑÑ‚ÐµÐ²Ð¾Ð¼ Ñ€ÐµÐ¶Ð¸Ð¼Ðµ";

	/// <summary>
	/// Key: "Action.Resend"
	/// button text for resending verification email
	/// English String: "Resend"
	/// </summary>
	public override string ActionResend => "ÐžÑ‚Ð¿Ñ€Ð°Ð²Ð¸Ñ‚ÑŒ Ð·Ð°Ð½Ð¾Ð²Ð¾";

	/// <summary>
	/// Key: "Action.ResendEmail"
	/// link that resends verification email to user
	/// English String: "Resend Email"
	/// </summary>
	public override string ActionResendEmail => "ÐžÑ‚Ð¿Ñ€Ð°Ð²Ð¸Ñ‚ÑŒ ÑÐ¾Ð¾Ð±Ñ‰ÐµÐ½Ð¸Ðµ Ð·Ð°Ð½Ð¾Ð²Ð¾";

	/// <summary>
	/// Key: "Action.SendVerificationEmail"
	/// button user can click to send a verification link to their email
	/// English String: "Send Verification Email"
	/// </summary>
	public override string ActionSendVerificationEmail => "Ð’Ñ‹ÑÐ»Ð°Ñ‚ÑŒ Ð¿Ð¸ÑÑŒÐ¼Ð¾ Ð´Ð»Ñ Ð¿Ð¾Ð´Ñ‚Ð²ÐµÑ€Ð¶Ð´ÐµÐ½Ð¸Ñ";

	/// <summary>
	/// Key: "Action.SignIn"
	/// Sign In button text
	/// English String: "Sign In"
	/// </summary>
	public override string ActionSignIn => "Ð’Ð¾Ð¹Ñ‚Ð¸";

	/// <summary>
	/// Key: "Action.SignInWithFacebook"
	/// Sign In with Facebook
	/// English String: "Sign In with Facebook"
	/// </summary>
	public override string ActionSignInWithFacebook => "Ð’Ð¾Ð¹Ñ‚Ð¸ Ñ‡ÐµÑ€ÐµÐ· Facebook";

	/// <summary>
	/// Key: "Action.SignUp"
	/// English String: "Sign up"
	/// </summary>
	public override string ActionSignUp => "Ð ÐµÐ³Ð¸ÑÑ‚Ñ€Ð°Ñ†Ð¸Ñ";

	/// <summary>
	/// Key: "Action.SignUpCapitalized"
	/// link which takes user to sign up page
	/// English String: "Sign Up"
	/// </summary>
	public override string ActionSignUpCapitalized => "Ð ÐµÐ³Ð¸ÑÑ‚Ñ€Ð°Ñ†Ð¸Ñ";

	/// <summary>
	/// Key: "Action.WeChatLogin"
	/// button text for logging in with WeChat
	/// English String: "WeChat Login"
	/// </summary>
	public override string ActionWeChatLogin => "Ð’Ñ…Ð¾Ð´ Ð² WeChat";

	/// <summary>
	/// Key: "Heading.Login"
	/// heading on the login page
	/// English String: "Login"
	/// </summary>
	public override string HeadingLogin => "Ð’Ñ…Ð¾Ð´";

	/// <summary>
	/// Key: "Heading.LoginRoblox"
	/// current login page heading
	/// English String: "Login to Roblox"
	/// </summary>
	public override string HeadingLoginRoblox => "Ð’Ñ…Ð¾Ð´ Ð² Roblox";

	public override string HeadingSignUpMakeFriends => "Ð—Ð°Ñ€ÐµÐ³Ð¸ÑÑ‚Ñ€Ð¸Ñ€ÑƒÐ¹Ñ‚ÐµÑÑŒ, Ñ‡Ñ‚Ð¾Ð±Ñ‹ ÑÑ‚Ñ€Ð¾Ð¸Ñ‚ÑŒ Ð¸ Ð·Ð°Ð²Ð¾Ð´Ð¸Ñ‚ÑŒ Ð´Ñ€ÑƒÐ·ÐµÐ¹";

	/// <summary>
	/// Key: "Label.AccountNotNeeded"
	/// You don't need an account to play Roblox
	/// English String: "You don't need an account to play Roblox"
	/// </summary>
	public override string LabelAccountNotNeeded => "Ð’Ñ‹ Ð¼Ð¾Ð¶ÐµÑ‚Ðµ Ð¸Ð³Ñ€Ð°Ñ‚ÑŒ Ð² Roblox Ð±ÐµÐ· ÑƒÑ‡ÐµÑ‚Ð½Ð¾Ð¹ Ð·Ð°Ð¿Ð¸ÑÐ¸";

	/// <summary>
	/// Key: "Label.EmailNeedsVerification"
	/// modal header used for prompting user they need to verify their email in order to log in with it
	/// English String: "Your email needs verification"
	/// </summary>
	public override string LabelEmailNeedsVerification => "ÐÐ´Ñ€ÐµÑ Ð’Ð°ÑˆÐµÐ¹ ÑÐ». Ð¿Ð¾Ñ‡Ñ‚Ñ‹ Ð½ÑƒÐ¶Ð½Ð¾ Ð¿Ð¾Ð´Ñ‚Ð²ÐµÑ€Ð´Ð¸Ñ‚ÑŒ";

	/// <summary>
	/// Key: "Label.FacebookCreatePasswordWarning"
	/// If you have been signing in with Facebook, you must set a password.
	/// English String: "If you have been signing in with Facebook, you must set a password."
	/// </summary>
	public override string LabelFacebookCreatePasswordWarning => "Ð•ÑÐ»Ð¸ Ð²Ñ‹ Ð¸ÑÐ¿Ð¾Ð»ÑŒÐ·Ð¾Ð²Ð°Ð»Ð¸ ÑƒÑ‡ÐµÑ‚Ð½ÑƒÑŽ Ð·Ð°Ð¿Ð¸ÑÑŒ Facebook, Ð½ÐµÐ¾Ð±Ñ…Ð¾Ð´Ð¸Ð¼Ð¾ ÑƒÐºÐ°Ð·Ð°Ñ‚ÑŒ Ð¿Ð°Ñ€Ð¾Ð»ÑŒ.";

	/// <summary>
	/// Key: "Label.ForgotUsernamePassword"
	/// landing page top right link for password reset
	/// English String: "Forgot Username/Password?"
	/// </summary>
	public override string LabelForgotUsernamePassword => "Ð—Ð°Ð±Ñ‹Ð»Ð¸ Ð¸Ð¼Ñ Ð¿Ð¾Ð»ÑŒÐ·Ð¾Ð²Ð°Ñ‚ÐµÐ»Ñ Ð¸Ð»Ð¸ Ð¿Ð°Ñ€Ð¾Ð»ÑŒ?";

	/// <summary>
	/// Key: "Label.LearnMore"
	/// learn more link text
	/// English String: "Learn more"
	/// </summary>
	public override string LabelLearnMore => "ÐŸÐ¾Ð´Ñ€Ð¾Ð±Ð½ÐµÐµ";

	/// <summary>
	/// Key: "Label.LoggingInSpinnerText"
	/// English String: "Logging inâ€¦"
	/// </summary>
	public override string LabelLoggingInSpinnerText => "Ð’Ñ…Ð¾Ð´...";

	/// <summary>
	/// Key: "Label.Login"
	/// English String: "Log in"
	/// </summary>
	public override string LabelLogin => "Ð’Ñ…Ð¾Ð´";

	/// <summary>
	/// Key: "Label.LoginWithYour"
	/// Label for a partition line between login with email and facebook login. Please keep the text in lowercase for roman characters.
	/// English String: "login with your"
	/// </summary>
	public override string LabelLoginWithYour => "Ð’Ñ…Ð¾Ð´ Ñ Ð¿Ð¾Ð¼Ð¾Ñ‰ÑŒÑŽ";

	/// <summary>
	/// Key: "Label.NoAccount"
	/// Don't have an account?
	/// English String: "Don't have an account?"
	/// </summary>
	public override string LabelNoAccount => "ÐÐµÑ‚ ÑƒÑ‡ÐµÑ‚Ð½Ð¾Ð¹ Ð·Ð°Ð¿Ð¸ÑÐ¸?";

	/// <summary>
	/// Key: "Label.NonAMemberQuestion"
	/// The question heading for the section on the login page to take use to sign up page.
	/// English String: "Not a member?"
	/// </summary>
	public override string LabelNonAMemberQuestion => "ÐÐµ Ð·Ð°Ñ€ÐµÐ³Ð¸ÑÑ‚Ñ€Ð¸Ñ€Ð¾Ð²Ð°Ð½Ñ‹?";

	/// <summary>
	/// Key: "Label.NotReceived"
	/// prompt for allowing users to resend verification email
	/// English String: "Didn't receive it?"
	/// </summary>
	public override string LabelNotReceived => "Ð’Ñ‹ Ð½Ðµ Ð¿Ð¾Ð»ÑƒÑ‡Ð¸Ð»Ð¸ ÐµÐ³Ð¾?";

	/// <summary>
	/// Key: "Label.Or"
	/// partition between email login and facebook login
	/// English String: "Or"
	/// </summary>
	public override string LabelOr => "Ð˜Ð»Ð¸";

	/// <summary>
	/// Key: "Label.Password"
	/// Password
	/// English String: "Password"
	/// </summary>
	public override string LabelPassword => "ÐŸÐ°Ñ€Ð¾Ð»ÑŒ";

	/// <summary>
	/// Key: "Label.PasswordWithColumn"
	/// label for the password field on the login page
	/// English String: "Password:"
	/// </summary>
	public override string LabelPasswordWithColumn => "ÐŸÐ°Ñ€Ð¾Ð»ÑŒ:";

	/// <summary>
	/// Key: "Label.StartPlaying"
	/// You can start playing right now, in guest mode!
	/// English String: "You can start playing right now, in guest mode!"
	/// </summary>
	public override string LabelStartPlaying => "ÐÐ°Ñ‡Ð½Ð¸Ñ‚Ðµ Ð¸Ð³Ñ€Ð°Ñ‚ÑŒ Ð¿Ñ€ÑÐ¼Ð¾ ÑÐµÐ¹Ñ‡Ð°Ñ Ð² Ð³Ð¾ÑÑ‚ÐµÐ²Ð¾Ð¼ Ñ€ÐµÐ¶Ð¸Ð¼Ðµ!";

	/// <summary>
	/// Key: "Label.UnverifiedEmailInstructions"
	/// message shown in a modal when user logs in with unverified email
	/// English String: "To log in with your email, it must be verified. You can also log in with your username."
	/// </summary>
	public override string LabelUnverifiedEmailInstructions => "Ð§Ñ‚Ð¾Ð±Ñ‹ Ð²Ð¾Ð¹Ñ‚Ð¸ Ñ Ð¿Ð¾Ð¼Ð¾Ñ‰ÑŒÑŽ ÑÐ». Ð¿Ð¾Ñ‡Ñ‚Ñ‹, Ð°Ð´Ñ€ÐµÑ Ð½ÑƒÐ¶Ð½Ð¾ Ð¿Ð¾Ð´Ñ‚Ð²ÐµÑ€Ð´Ð¸Ñ‚ÑŒ. Ð’Ñ‹ Ñ‚Ð°ÐºÐ¶Ðµ Ð¼Ð¾Ð¶ÐµÑ‚Ðµ Ð¸ÑÐ¿Ð¾Ð»ÑŒÐ·Ð¾Ð²Ð°Ñ‚ÑŒ Ð¸Ð¼Ñ Ð¿Ð¾Ð»ÑŒÐ·Ð¾Ð²Ð°Ñ‚ÐµÐ»Ñ Ð´Ð»Ñ Ð²Ñ…Ð¾Ð´Ð°.";

	/// <summary>
	/// Key: "Label.Username"
	/// English String: "Username"
	/// </summary>
	public override string LabelUsername => "Ð˜Ð¼Ñ Ð¿Ð¾Ð»ÑŒÐ·Ð¾Ð²Ð°Ñ‚ÐµÐ»Ñ";

	/// <summary>
	/// Key: "Label.UsernameEmail"
	/// placeholder text for input field that accepts username or email
	/// English String: "Username/Email"
	/// </summary>
	public override string LabelUsernameEmail => "Ð˜Ð¼Ñ Ð¿Ð¾Ð»ÑŒÐ·Ð¾Ð²Ð°Ñ‚ÐµÐ»Ñ/ÑÐ». Ð¿Ð¾Ñ‡Ñ‚Ð°";

	/// <summary>
	/// Key: "Label.UsernameEmailPhone"
	/// placeholder text for input fields that accept username, email or phone
	/// English String: "Username/Email/Phone"
	/// </summary>
	public override string LabelUsernameEmailPhone => "Ð˜Ð¼Ñ Ð¿Ð¾Ð»ÑŒÐ·Ð¾Ð²Ð°Ñ‚ÐµÐ»Ñ/ÑÐ». Ð¿Ð¾Ñ‡Ñ‚Ð°/Ð½Ð¾Ð¼ÐµÑ€ Ñ‚ÐµÐ»ÐµÑ„Ð¾Ð½Ð°";

	/// <summary>
	/// Key: "Label.UsernamePhone"
	/// placeholder text for input field that accepts username or phone
	/// English String: "Username/Phone"
	/// </summary>
	public override string LabelUsernamePhone => "Ð˜Ð¼Ñ Ð¿Ð¾Ð»ÑŒÐ·Ð¾Ð²Ð°Ñ‚ÐµÐ»Ñ/Ð½Ð¾Ð¼ÐµÑ€ Ñ‚ÐµÐ»ÐµÑ„Ð¾Ð½Ð°";

	/// <summary>
	/// Key: "Label.UsernameWithColumn"
	/// label for username field on login page
	/// English String: "Username:"
	/// </summary>
	public override string LabelUsernameWithColumn => "Ð˜Ð¼Ñ Ð¿Ð¾Ð»ÑŒÐ·Ð¾Ð²Ð°Ñ‚ÐµÐ»Ñ:";

	/// <summary>
	/// Key: "Label.VerificationEmailSent"
	/// message telling user a verification email was sent to them
	/// English String: "Verification Email Sent!"
	/// </summary>
	public override string LabelVerificationEmailSent => "ÐŸÐ¸ÑÑŒÐ¼Ð¾ Ð´Ð»Ñ Ð¿Ð¾Ð´Ñ‚Ð²ÐµÑ€Ð¶Ð´ÐµÐ½Ð¸Ñ Ð¾Ñ‚Ð¿Ñ€Ð°Ð²Ð»ÐµÐ½Ð¾!";

	/// <summary>
	/// Key: "Label.WeChatAntiAddictionText"
	/// English String: "Boycott bad games, refuse pirated games. Be aware of self-defense and being deceived. Playing games is good for your brain, but too much game play can harm your health. Manage your time well and enjoy a healthy lifestyle."
	/// </summary>
	public override string LabelWeChatAntiAddictionText => "Ð˜Ð·Ð±ÐµÐ³Ð°Ð¹Ñ‚Ðµ Ð¿Ð»Ð¾Ñ…Ð¸Ñ… Ð¸ Ð¿Ð¸Ñ€Ð°Ñ‚ÑÐºÐ¸Ñ… Ð¸Ð³Ñ€. Ð‘ÑƒÐ´ÑŒÑ‚Ðµ Ð¾ÑÑ‚Ð¾Ñ€Ð¾Ð¶Ð½Ñ‹, Ð¸ Ð²Ð°Ñ Ð½Ðµ Ð¾Ð±Ð¼Ð°Ð½ÑƒÑ‚. Ð˜Ð³Ñ€Ñ‹ Ð¿Ð¾Ð¼Ð¾Ð³Ð°ÑŽÑ‚ Ñ€Ð°Ð·Ð²Ð¸Ð²Ð°Ñ‚ÑŒ Ð¼Ð¾Ð·Ð³, Ð¾Ð´Ð½Ð°ÐºÐ¾ Ð½Ðµ Ð½Ð°Ð´Ð¾ Ð¸Ð¼Ð¸ Ð·Ð»Ð¾ÑƒÐ¿Ð¾Ñ‚Ñ€ÐµÐ±Ð»ÑÑ‚ÑŒ â€“ ÑÑ‚Ð¾ Ð¼Ð¾Ð¶ÐµÑ‚ Ð½Ð°Ð½ÐµÑÑ‚Ð¸ Ð²Ñ€ÐµÐ´ Ð·Ð´Ð¾Ñ€Ð¾Ð²ÑŒÑŽ. Ð Ð°Ð·ÑƒÐ¼Ð½Ð¾ Ñ€Ð°ÑÐ¿Ñ€ÐµÐ´ÐµÐ»ÑÐ¹Ñ‚Ðµ ÑÐ²Ð¾Ðµ Ð²Ñ€ÐµÐ¼Ñ Ð¸ Ð½Ð°ÑÐ»Ð°Ð¶Ð´Ð°Ð¹Ñ‚ÐµÑÑŒ Ð¿Ñ€Ð°Ð²Ð¸Ð»ÑŒÐ½Ñ‹Ð¼ Ð¾Ð±Ñ€Ð°Ð·Ð¾Ð¼ Ð¶Ð¸Ð·Ð½Ð¸!";

	/// <summary>
	/// Key: "Message.UnknownErrorTryAgain"
	/// An unknown error occurred. Please try again.
	/// English String: "An unknown error occurred. Please try again."
	/// </summary>
	public override string MessageUnknownErrorTryAgain => "ÐŸÑ€Ð¾Ð¸Ð·Ð¾ÑˆÐ»Ð° Ð½ÐµÐ¸Ð·Ð²ÐµÑÑ‚Ð½Ð°Ñ Ð¾ÑˆÐ¸Ð±ÐºÐ°. ÐŸÐ¾Ð²Ñ‚Ð¾Ñ€Ð¸Ñ‚Ðµ Ð¿Ð¾Ð¿Ñ‹Ñ‚ÐºÑƒ.";

	/// <summary>
	/// Key: "Message.UsernameAndPasswordRequired"
	/// message shown to user when they attempt to login without entering a username or password
	/// English String: "Username and password required"
	/// </summary>
	public override string MessageUsernameAndPasswordRequired => "ÐÐµÐ¾Ð±Ñ…Ð¾Ð´Ð¸Ð¼Ð¾ ÑƒÐºÐ°Ð·Ð°Ñ‚ÑŒ Ð¸Ð¼Ñ Ð¿Ð¾Ð»ÑŒÐ·Ð¾Ð²Ð°Ñ‚ÐµÐ»Ñ Ð¸ Ð¿Ð°Ñ€Ð¾Ð»ÑŒ";

	/// <summary>
	/// Key: "Response.AccountIssueErrorContactSupport"
	/// English String: "Account issue. Please contact Support."
	/// </summary>
	public override string ResponseAccountIssueErrorContactSupport => "ÐžÑˆÐ¸Ð±ÐºÐ° ÑƒÑ‡ÐµÑ‚Ð½Ð¾Ð¹ Ð·Ð°Ð¿Ð¸ÑÐ¸. ÐžÐ±Ñ€Ð°Ñ‚Ð¸Ñ‚ÐµÑÑŒ Ð² ÑÐ»ÑƒÐ¶Ð±Ñƒ Ð¿Ð¾Ð´Ð´ÐµÑ€Ð¶ÐºÐ¸.";

	/// <summary>
	/// Key: "Response.AccountLockedRequestReset"
	/// Account has been locked. Please request a password reset.
	/// English String: "Account has been locked. Please request a password reset."
	/// </summary>
	public override string ResponseAccountLockedRequestReset => "Ð£Ñ‡ÐµÑ‚Ð½Ð°Ñ Ð·Ð°Ð¿Ð¸ÑÑŒ Ð·Ð°Ð±Ð»Ð¾ÐºÐ¸Ñ€Ð¾Ð²Ð°Ð½Ð°. Ð—Ð°Ð¿Ñ€Ð¾ÑÐ¸Ñ‚Ðµ ÑÐ±Ñ€Ð¾Ñ Ð¿Ð°Ñ€Ð¾Ð»Ñ.";

	/// <summary>
	/// Key: "Response.AccountNotFound"
	/// Account not found. Please try again.
	/// English String: "Account not found. Please try again."
	/// </summary>
	public override string ResponseAccountNotFound => "Ð£Ñ‡ÐµÑ‚Ð½Ð°Ñ Ð·Ð°Ð¿Ð¸ÑÑŒ Ð½Ðµ Ð½Ð°Ð¹Ð´ÐµÐ½Ð°. ÐŸÐ¾Ð²Ñ‚Ð¾Ñ€Ð¸Ñ‚Ðµ Ð¿Ð¾Ð¿Ñ‹Ñ‚ÐºÑƒ.";

	/// <summary>
	/// Key: "Response.EmailLinkedToMultipleAccountsLoginWithUsername"
	/// error message displayed when user attempts to log in with an email that is linked to multiple accounts
	/// English String: "Your email is associated with more than 1 username. Please login with your username."
	/// </summary>
	public override string ResponseEmailLinkedToMultipleAccountsLoginWithUsername => "Ð­Ñ‚Ð° ÑÐ». Ð¿Ð¾Ñ‡Ñ‚Ð° Ð¿Ñ€Ð¸Ð²ÑÐ·Ð°Ð½Ð° Ðº Ð½ÐµÑÐºÐ¾Ð»ÑŒÐºÐ¸Ð¼ Ð¿Ð¾Ð»ÑŒÐ·Ð¾Ð²Ð°Ñ‚ÐµÐ»ÑÐ¼. ÐŸÐ¾Ð¶Ð°Ð»ÑƒÐ¹ÑÑ‚Ð°, Ð²Ð²ÐµÐ´Ð¸Ñ‚Ðµ ÑÐ²Ð¾Ðµ Ð¸Ð¼Ñ Ð¿Ð¾Ð»ÑŒÐ·Ð¾Ð²Ð°Ñ‚ÐµÐ»Ñ.";

	/// <summary>
	/// Key: "Response.EmailSent"
	/// response telling user that a verification email has been sent to them
	/// English String: "Email sent!"
	/// </summary>
	public override string ResponseEmailSent => "Ð¡Ð¾Ð¾Ð±Ñ‰ÐµÐ½Ð¸Ðµ Ð¾Ñ‚Ð¿Ñ€Ð°Ð²Ð»ÐµÐ½Ð¾!";

	/// <summary>
	/// Key: "Response.IncorrectEmailOrPassword"
	/// error message displayed when user logs in with an invalid email or password
	/// English String: "Incorrect email or password."
	/// </summary>
	public override string ResponseIncorrectEmailOrPassword => "ÐÐµÐºÐ¾Ñ€Ñ€ÐµÐºÑ‚Ð½Ñ‹Ðµ ÑÐ». Ð¿Ð¾Ñ‡Ñ‚Ð° Ð¸Ð»Ð¸ Ð¿Ð°Ñ€Ð¾Ð»ÑŒ.";

	/// <summary>
	/// Key: "Response.IncorrectPhoneOrPassword"
	/// error message displayed when user logs in with an invalid phone or password
	/// English String: "Incorrect phone or password."
	/// </summary>
	public override string ResponseIncorrectPhoneOrPassword => "ÐÐµÐºÐ¾Ñ€Ñ€ÐµÐºÑ‚Ð½Ñ‹Ðµ Ð½Ð¾Ð¼ÐµÑ€ Ñ‚ÐµÐ»ÐµÑ„Ð¾Ð½Ð° Ð¸Ð»Ð¸ Ð¿Ð°Ñ€Ð¾Ð»ÑŒ.";

	/// <summary>
	/// Key: "Response.IncorrectUsernamePassword"
	/// English String: "Incorrect username or password."
	/// </summary>
	public override string ResponseIncorrectUsernamePassword => "ÐÐµÐ¿Ñ€Ð°Ð²Ð¸Ð»ÑŒÐ½Ñ‹Ðµ Ð¸Ð¼Ñ Ð¿Ð¾Ð»ÑŒÐ·Ð¾Ð²Ð°Ñ‚ÐµÐ»Ñ Ð¸Ð»Ð¸ Ð¿Ð°Ñ€Ð¾Ð»ÑŒ.";

	/// <summary>
	/// Key: "Response.LoginWithUsername"
	/// error message shown when user attempts to login with method other than username and an error occurred
	/// English String: "Something went wrong. Please login with your username."
	/// </summary>
	public override string ResponseLoginWithUsername => "Ð’Ð¾Ð·Ð½Ð¸ÐºÐ»Ð¸ Ð¿Ñ€Ð¾Ð±Ð»ÐµÐ¼Ñ‹. ÐŸÐ¾Ð¶Ð°Ð»ÑƒÐ¹ÑÑ‚Ð°, Ð²Ð²ÐµÐ´Ð¸Ñ‚Ðµ ÑÐ²Ð¾Ðµ Ð¸Ð¼Ñ Ð¿Ð¾Ð»ÑŒÐ·Ð¾Ð²Ð°Ñ‚ÐµÐ»Ñ.";

	/// <summary>
	/// Key: "Response.PasswordNotProvided"
	/// password field is empty
	/// English String: "You must enter a password."
	/// </summary>
	public override string ResponsePasswordNotProvided => "ÐÐµÐ¾Ð±Ñ…Ð¾Ð´Ð¸Ð¼Ð¾ Ð²Ð²ÐµÑÑ‚Ð¸ Ð¿Ð°Ñ€Ð¾Ð»ÑŒ.";

	/// <summary>
	/// Key: "Response.TooManyAttemptsPleaseWait"
	/// English String: "Too many attempts. Please wait a bit."
	/// </summary>
	public override string ResponseTooManyAttemptsPleaseWait => "Ð¡Ð»Ð¸ÑˆÐºÐ¾Ð¼ Ð¼Ð½Ð¾Ð³Ð¾ Ð¿Ð¾Ð¿Ñ‹Ñ‚Ð¾Ðº. ÐŸÐ¾Ð´Ð¾Ð¶Ð´Ð¸Ñ‚Ðµ.";

	/// <summary>
	/// Key: "Response.UnknownError"
	/// English String: "Unknown Error"
	/// </summary>
	public override string ResponseUnknownError => "ÐÐµÐ¸Ð·Ð²ÐµÑÑ‚Ð½Ð°Ñ Ð¾ÑˆÐ¸Ð±ÐºÐ°";

	/// <summary>
	/// Key: "Response.UnknownLoginError"
	/// Unknown login failure.
	/// English String: "Unknown login failure."
	/// </summary>
	public override string ResponseUnknownLoginError => "ÐÐµÐ¸Ð·Ð²ÐµÑÑ‚Ð½Ð°Ñ Ð¾ÑˆÐ¸Ð±ÐºÐ° Ð²Ñ…Ð¾Ð´Ð°";

	/// <summary>
	/// Key: "Response.UnverifiedEmailLoginWithUsername"
	/// error message shown when user attempts to login with unverified email
	/// English String: "Your email is not verified. Please login with your username."
	/// </summary>
	public override string ResponseUnverifiedEmailLoginWithUsername => "Ð­Ñ‚Ð° ÑÐ». Ð¿Ð¾Ñ‡Ñ‚Ð° Ð½Ðµ Ð¿Ð¾Ð´Ñ‚Ð²ÐµÑ€Ð¶Ð´ÐµÐ½Ð°. ÐŸÐ¾Ð¶Ð°Ð»ÑƒÐ¹ÑÑ‚Ð°, Ð²Ð²ÐµÐ´Ð¸Ñ‚Ðµ ÑÐ²Ð¾Ðµ Ð¸Ð¼Ñ Ð¿Ð¾Ð»ÑŒÐ·Ð¾Ð²Ð°Ñ‚ÐµÐ»Ñ.";

	/// <summary>
	/// Key: "Response.UnverifiedPhoneLoginWithUsername"
	/// error message shown when user attempts to login with an unverified phone number
	/// English String: "Your phone is not verified. Please login with your username."
	/// </summary>
	public override string ResponseUnverifiedPhoneLoginWithUsername => "Ð­Ñ‚Ð¾Ñ‚ Ð½Ð¾Ð¼ÐµÑ€ Ñ‚ÐµÐ»ÐµÑ„Ð¾Ð½Ð° Ð½Ðµ Ð¿Ð¾Ð´Ñ‚Ð²ÐµÑ€Ð¶Ð´ÐµÐ½. ÐŸÐ¾Ð¶Ð°Ð»ÑƒÐ¹ÑÑ‚Ð°, Ð²Ð²ÐµÐ´Ð¸Ñ‚Ðµ ÑÐ²Ð¾Ðµ Ð¸Ð¼Ñ Ð¿Ð¾Ð»ÑŒÐ·Ð¾Ð²Ð°Ñ‚ÐµÐ»Ñ.";

	/// <summary>
	/// Key: "Response.UsernameNotProvided"
	/// username field is empty
	/// English String: "You must enter a username."
	/// </summary>
	public override string ResponseUsernameNotProvided => "ÐÐµÐ¾Ð±Ñ…Ð¾Ð´Ð¸Ð¼Ð¾ Ð²Ð²ÐµÑÑ‚Ð¸ Ð¸Ð¼Ñ Ð¿Ð¾Ð»ÑŒÐ·Ð¾Ð²Ð°Ñ‚ÐµÐ»Ñ.";

	/// <summary>
	/// Key: "Response.UseSocialSignOn"
	/// Unable to login. Please use Social Network sign on.
	/// English String: "Unable to login. Please use Social Network sign on."
	/// </summary>
	public override string ResponseUseSocialSignOn => "ÐÐµ ÑƒÐ´Ð°Ð»Ð¾ÑÑŒ Ð²Ð¾Ð¹Ñ‚Ð¸ Ð² ÑƒÑ‡ÐµÑ‚Ð½ÑƒÑŽ Ð·Ð°Ð¿Ð¸ÑÑŒ. Ð’Ð¾Ð¹Ð´Ð¸Ñ‚Ðµ Ñ‡ÐµÑ€ÐµÐ· ÑÐ¾Ñ†Ð¸Ð°Ð»ÑŒÐ½ÑƒÑŽ ÑÐµÑ‚ÑŒ.";

	/// <summary>
	/// Key: "WeChat.AntiAddictionText"
	/// English String: "Boycott bad games, refuse pirated games. Be aware of self-defense and being deceived. Playing games is good for your brain, but too much game play can harm your health. Manage your time well and enjoy a healthy lifestyle."
	/// </summary>
	public override string WeChatAntiAddictionText => "Ð˜Ð·Ð±ÐµÐ³Ð°Ð¹Ñ‚Ðµ Ð¿Ð»Ð¾Ñ…Ð¸Ñ… Ð¸ Ð¿Ð¸Ñ€Ð°Ñ‚ÑÐºÐ¸Ñ… Ð¸Ð³Ñ€. Ð‘ÑƒÐ´ÑŒÑ‚Ðµ Ð¾ÑÑ‚Ð¾Ñ€Ð¾Ð¶Ð½Ñ‹, Ð¸ Ð²Ð°Ñ Ð½Ðµ Ð¾Ð±Ð¼Ð°Ð½ÑƒÑ‚. Ð˜Ð³Ñ€Ñ‹ Ð¿Ð¾Ð¼Ð¾Ð³Ð°ÑŽÑ‚ Ñ€Ð°Ð·Ð²Ð¸Ð²Ð°Ñ‚ÑŒ Ð¼Ð¾Ð·Ð³, Ð¾Ð´Ð½Ð°ÐºÐ¾ Ð½Ðµ Ð½Ð°Ð´Ð¾ Ñ ÑÑ‚Ð¸Ð¼ Ð·Ð»Ð¾ÑƒÐ¿Ð¾Ñ‚Ñ€ÐµÐ±Ð»ÑÑ‚ÑŒ â€“ ÑÑ‚Ð¾ Ð¼Ð¾Ð¶ÐµÑ‚ Ð½Ð°Ð½ÐµÑÑ‚Ð¸ Ð²Ñ€ÐµÐ´ Ð·Ð´Ð¾Ñ€Ð¾Ð²ÑŒÑŽ. Ð Ð°Ð·ÑƒÐ¼Ð½Ð¾ Ñ€Ð°ÑÐ¿Ñ€ÐµÐ´ÐµÐ»ÑÐ¹Ñ‚Ðµ ÑÐ²Ð¾Ðµ Ð²Ñ€ÐµÐ¼Ñ Ð¸ Ð½Ð°ÑÐ»Ð°Ð¶Ð´Ð°Ð¹Ñ‚ÐµÑÑŒ Ð¿Ñ€Ð°Ð²Ð¸Ð»ÑŒÐ½Ñ‹Ð¼ Ð¾Ð±Ñ€Ð°Ð·Ð¾Ð¼ Ð¶Ð¸Ð·Ð½Ð¸!";

	/// <summary>
	/// Key: "WeChat.RealNameNotVerified"
	/// English String: "Your WeChat is not real-name verified. Please use a real-name verified WeChat account and try again. Please visit https://jiazhang.qq.com/zk/home.html"
	/// </summary>
	public override string WeChatRealNameNotVerified => "Ð’Ð°ÑˆÐµ Ð½Ð°ÑÑ‚Ð¾ÑÑ‰ÐµÐµ Ð¸Ð¼Ñ Ð² WeChat Ð½Ðµ Ð¿Ð¾Ð´Ñ‚Ð²ÐµÑ€Ð¶Ð´ÐµÐ½Ð¾. ÐŸÐ¾Ð¶Ð°Ð»ÑƒÐ¹ÑÑ‚Ð°, Ð¸ÑÐ¿Ð¾Ð»ÑŒÐ·ÑƒÐ¹Ñ‚Ðµ ÑÐ²Ð¾ÑŽ Ñ€ÐµÐ°Ð»ÑŒÐ½ÑƒÑŽ, Ð¿Ð¾Ð´Ñ‚Ð²ÐµÑ€Ð¶Ð´ÐµÐ½Ð½ÑƒÑŽ Ð² WeChat ÑƒÑ‡ÐµÑ‚Ð½ÑƒÑŽ Ð·Ð°Ð¿Ð¸ÑÑŒ, Ð¸ Ð¿Ð¾Ð¿Ñ€Ð¾Ð±ÑƒÐ¹Ñ‚Ðµ ÐµÑ‰Ðµ Ñ€Ð°Ð·. ÐŸÐ¾Ð¶Ð°Ð»ÑƒÐ¹ÑÑ‚Ð°, Ð¿ÐµÑ€ÐµÐ¹Ð´Ð¸Ñ‚Ðµ Ð½Ð° https://jiazhang.qq.com/zk/home.html";

	public LoginResources_ru_ru(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionCancel()
	{
		return "ÐžÑ‚Ð¼ÐµÐ½Ð°";
	}

	protected override string _GetTemplateForActionFacebook()
	{
		return "Facebook";
	}

	protected override string _GetTemplateForActionForgotPasswordOrUsernameQuestion()
	{
		return "Ð—Ð°Ð±Ñ‹Ð»Ð¸ Ð¿Ð°Ñ€Ð¾Ð»ÑŒ Ð¸Ð»Ð¸ Ð¸Ð¼Ñ Ð¿Ð¾Ð»ÑŒÐ·Ð¾Ð²Ð°Ñ‚ÐµÐ»Ñ?";
	}

	protected override string _GetTemplateForActionForgotPasswordOrUsernameQuestionCapitalized()
	{
		return "Ð—Ð°Ð±Ñ‹Ð»Ð¸ Ð¿Ð°Ñ€Ð¾Ð»ÑŒ Ð¸Ð»Ð¸ Ð¸Ð¼Ñ Ð¿Ð¾Ð»ÑŒÐ·Ð¾Ð²Ð°Ñ‚ÐµÐ»Ñ?";
	}

	protected override string _GetTemplateForActionLogin()
	{
		return "Ð’Ñ…Ð¾Ð´";
	}

	protected override string _GetTemplateForActionLogInCapitalized()
	{
		return "Ð’Ñ…Ð¾Ð´";
	}

	protected override string _GetTemplateForActionOk()
	{
		return "OK";
	}

	protected override string _GetTemplateForActionPlayAsGuest()
	{
		return "Ð˜Ð³Ñ€Ð°Ñ‚ÑŒ Ð² Ð³Ð¾ÑÑ‚ÐµÐ²Ð¾Ð¼ Ñ€ÐµÐ¶Ð¸Ð¼Ðµ";
	}

	protected override string _GetTemplateForActionResend()
	{
		return "ÐžÑ‚Ð¿Ñ€Ð°Ð²Ð¸Ñ‚ÑŒ Ð·Ð°Ð½Ð¾Ð²Ð¾";
	}

	protected override string _GetTemplateForActionResendEmail()
	{
		return "ÐžÑ‚Ð¿Ñ€Ð°Ð²Ð¸Ñ‚ÑŒ ÑÐ¾Ð¾Ð±Ñ‰ÐµÐ½Ð¸Ðµ Ð·Ð°Ð½Ð¾Ð²Ð¾";
	}

	protected override string _GetTemplateForActionSendVerificationEmail()
	{
		return "Ð’Ñ‹ÑÐ»Ð°Ñ‚ÑŒ Ð¿Ð¸ÑÑŒÐ¼Ð¾ Ð´Ð»Ñ Ð¿Ð¾Ð´Ñ‚Ð²ÐµÑ€Ð¶Ð´ÐµÐ½Ð¸Ñ";
	}

	protected override string _GetTemplateForActionSignIn()
	{
		return "Ð’Ð¾Ð¹Ñ‚Ð¸";
	}

	protected override string _GetTemplateForActionSignInWithFacebook()
	{
		return "Ð’Ð¾Ð¹Ñ‚Ð¸ Ñ‡ÐµÑ€ÐµÐ· Facebook";
	}

	protected override string _GetTemplateForActionSignUp()
	{
		return "Ð ÐµÐ³Ð¸ÑÑ‚Ñ€Ð°Ñ†Ð¸Ñ";
	}

	protected override string _GetTemplateForActionSignUpCapitalized()
	{
		return "Ð ÐµÐ³Ð¸ÑÑ‚Ñ€Ð°Ñ†Ð¸Ñ";
	}

	protected override string _GetTemplateForActionWeChatLogin()
	{
		return "Ð’Ñ…Ð¾Ð´ Ð² WeChat";
	}

	protected override string _GetTemplateForHeadingLogin()
	{
		return "Ð’Ñ…Ð¾Ð´";
	}

	protected override string _GetTemplateForHeadingLoginRoblox()
	{
		return "Ð’Ñ…Ð¾Ð´ Ð² Roblox";
	}

	protected override string _GetTemplateForHeadingSignUpMakeFriends()
	{
		return "Ð—Ð°Ñ€ÐµÐ³Ð¸ÑÑ‚Ñ€Ð¸Ñ€ÑƒÐ¹Ñ‚ÐµÑÑŒ, Ñ‡Ñ‚Ð¾Ð±Ñ‹ ÑÑ‚Ñ€Ð¾Ð¸Ñ‚ÑŒ Ð¸ Ð·Ð°Ð²Ð¾Ð´Ð¸Ñ‚ÑŒ Ð´Ñ€ÑƒÐ·ÐµÐ¹";
	}

	protected override string _GetTemplateForLabelAccountNotNeeded()
	{
		return "Ð’Ñ‹ Ð¼Ð¾Ð¶ÐµÑ‚Ðµ Ð¸Ð³Ñ€Ð°Ñ‚ÑŒ Ð² Roblox Ð±ÐµÐ· ÑƒÑ‡ÐµÑ‚Ð½Ð¾Ð¹ Ð·Ð°Ð¿Ð¸ÑÐ¸";
	}

	protected override string _GetTemplateForLabelEmailNeedsVerification()
	{
		return "ÐÐ´Ñ€ÐµÑ Ð’Ð°ÑˆÐµÐ¹ ÑÐ». Ð¿Ð¾Ñ‡Ñ‚Ñ‹ Ð½ÑƒÐ¶Ð½Ð¾ Ð¿Ð¾Ð´Ñ‚Ð²ÐµÑ€Ð´Ð¸Ñ‚ÑŒ";
	}

	protected override string _GetTemplateForLabelFacebookCreatePasswordWarning()
	{
		return "Ð•ÑÐ»Ð¸ Ð²Ñ‹ Ð¸ÑÐ¿Ð¾Ð»ÑŒÐ·Ð¾Ð²Ð°Ð»Ð¸ ÑƒÑ‡ÐµÑ‚Ð½ÑƒÑŽ Ð·Ð°Ð¿Ð¸ÑÑŒ Facebook, Ð½ÐµÐ¾Ð±Ñ…Ð¾Ð´Ð¸Ð¼Ð¾ ÑƒÐºÐ°Ð·Ð°Ñ‚ÑŒ Ð¿Ð°Ñ€Ð¾Ð»ÑŒ.";
	}

	protected override string _GetTemplateForLabelForgotUsernamePassword()
	{
		return "Ð—Ð°Ð±Ñ‹Ð»Ð¸ Ð¸Ð¼Ñ Ð¿Ð¾Ð»ÑŒÐ·Ð¾Ð²Ð°Ñ‚ÐµÐ»Ñ Ð¸Ð»Ð¸ Ð¿Ð°Ñ€Ð¾Ð»ÑŒ?";
	}

	/// <summary>
	/// Key: "Label.GreetingForNewAccount"
	/// Shown when a username doesn't exist on the login page to invite to create a new account.
	/// English String: "Nice to meet you, {username}. {linkStartSignup}Let's make an account! {linkEndSignup}"
	/// </summary>
	public override string LabelGreetingForNewAccount(string username, string linkStartSignup, string linkEndSignup)
	{
		return $"Ð”Ð¾Ð±Ñ€Ð¾ Ð¿Ð¾Ð¶Ð°Ð»Ð¾Ð²Ð°Ñ‚ÑŒ, {username}. {linkStartSignup}Ð”Ð°Ð²Ð°Ð¹Ñ‚Ðµ ÑÐ¾Ð·Ð´Ð°Ð´Ð¸Ð¼ ÑƒÑ‡ÐµÑ‚Ð½ÑƒÑŽ Ð·Ð°Ð¿Ð¸ÑÑŒ! {linkEndSignup}";
	}

	protected override string _GetTemplateForLabelGreetingForNewAccount()
	{
		return "Ð”Ð¾Ð±Ñ€Ð¾ Ð¿Ð¾Ð¶Ð°Ð»Ð¾Ð²Ð°Ñ‚ÑŒ, {username}. {linkStartSignup}Ð”Ð°Ð²Ð°Ð¹Ñ‚Ðµ ÑÐ¾Ð·Ð´Ð°Ð´Ð¸Ð¼ ÑƒÑ‡ÐµÑ‚Ð½ÑƒÑŽ Ð·Ð°Ð¿Ð¸ÑÑŒ! {linkEndSignup}";
	}

	protected override string _GetTemplateForLabelLearnMore()
	{
		return "ÐŸÐ¾Ð´Ñ€Ð¾Ð±Ð½ÐµÐµ";
	}

	protected override string _GetTemplateForLabelLoggingInSpinnerText()
	{
		return "Ð’Ñ…Ð¾Ð´...";
	}

	protected override string _GetTemplateForLabelLogin()
	{
		return "Ð’Ñ…Ð¾Ð´";
	}

	protected override string _GetTemplateForLabelLoginWithYour()
	{
		return "Ð’Ñ…Ð¾Ð´ Ñ Ð¿Ð¾Ð¼Ð¾Ñ‰ÑŒÑŽ";
	}

	protected override string _GetTemplateForLabelNoAccount()
	{
		return "ÐÐµÑ‚ ÑƒÑ‡ÐµÑ‚Ð½Ð¾Ð¹ Ð·Ð°Ð¿Ð¸ÑÐ¸?";
	}

	protected override string _GetTemplateForLabelNonAMemberQuestion()
	{
		return "ÐÐµ Ð·Ð°Ñ€ÐµÐ³Ð¸ÑÑ‚Ñ€Ð¸Ñ€Ð¾Ð²Ð°Ð½Ñ‹?";
	}

	protected override string _GetTemplateForLabelNotReceived()
	{
		return "Ð’Ñ‹ Ð½Ðµ Ð¿Ð¾Ð»ÑƒÑ‡Ð¸Ð»Ð¸ ÐµÐ³Ð¾?";
	}

	protected override string _GetTemplateForLabelOr()
	{
		return "Ð˜Ð»Ð¸";
	}

	protected override string _GetTemplateForLabelPassword()
	{
		return "ÐŸÐ°Ñ€Ð¾Ð»ÑŒ";
	}

	protected override string _GetTemplateForLabelPasswordWithColumn()
	{
		return "ÐŸÐ°Ñ€Ð¾Ð»ÑŒ:";
	}

	protected override string _GetTemplateForLabelStartPlaying()
	{
		return "ÐÐ°Ñ‡Ð½Ð¸Ñ‚Ðµ Ð¸Ð³Ñ€Ð°Ñ‚ÑŒ Ð¿Ñ€ÑÐ¼Ð¾ ÑÐµÐ¹Ñ‡Ð°Ñ Ð² Ð³Ð¾ÑÑ‚ÐµÐ²Ð¾Ð¼ Ñ€ÐµÐ¶Ð¸Ð¼Ðµ!";
	}

	protected override string _GetTemplateForLabelUnverifiedEmailInstructions()
	{
		return "Ð§Ñ‚Ð¾Ð±Ñ‹ Ð²Ð¾Ð¹Ñ‚Ð¸ Ñ Ð¿Ð¾Ð¼Ð¾Ñ‰ÑŒÑŽ ÑÐ». Ð¿Ð¾Ñ‡Ñ‚Ñ‹, Ð°Ð´Ñ€ÐµÑ Ð½ÑƒÐ¶Ð½Ð¾ Ð¿Ð¾Ð´Ñ‚Ð²ÐµÑ€Ð´Ð¸Ñ‚ÑŒ. Ð’Ñ‹ Ñ‚Ð°ÐºÐ¶Ðµ Ð¼Ð¾Ð¶ÐµÑ‚Ðµ Ð¸ÑÐ¿Ð¾Ð»ÑŒÐ·Ð¾Ð²Ð°Ñ‚ÑŒ Ð¸Ð¼Ñ Ð¿Ð¾Ð»ÑŒÐ·Ð¾Ð²Ð°Ñ‚ÐµÐ»Ñ Ð´Ð»Ñ Ð²Ñ…Ð¾Ð´Ð°.";
	}

	protected override string _GetTemplateForLabelUsername()
	{
		return "Ð˜Ð¼Ñ Ð¿Ð¾Ð»ÑŒÐ·Ð¾Ð²Ð°Ñ‚ÐµÐ»Ñ";
	}

	protected override string _GetTemplateForLabelUsernameEmail()
	{
		return "Ð˜Ð¼Ñ Ð¿Ð¾Ð»ÑŒÐ·Ð¾Ð²Ð°Ñ‚ÐµÐ»Ñ/ÑÐ». Ð¿Ð¾Ñ‡Ñ‚Ð°";
	}

	protected override string _GetTemplateForLabelUsernameEmailPhone()
	{
		return "Ð˜Ð¼Ñ Ð¿Ð¾Ð»ÑŒÐ·Ð¾Ð²Ð°Ñ‚ÐµÐ»Ñ/ÑÐ». Ð¿Ð¾Ñ‡Ñ‚Ð°/Ð½Ð¾Ð¼ÐµÑ€ Ñ‚ÐµÐ»ÐµÑ„Ð¾Ð½Ð°";
	}

	protected override string _GetTemplateForLabelUsernamePhone()
	{
		return "Ð˜Ð¼Ñ Ð¿Ð¾Ð»ÑŒÐ·Ð¾Ð²Ð°Ñ‚ÐµÐ»Ñ/Ð½Ð¾Ð¼ÐµÑ€ Ñ‚ÐµÐ»ÐµÑ„Ð¾Ð½Ð°";
	}

	protected override string _GetTemplateForLabelUsernameWithColumn()
	{
		return "Ð˜Ð¼Ñ Ð¿Ð¾Ð»ÑŒÐ·Ð¾Ð²Ð°Ñ‚ÐµÐ»Ñ:";
	}

	protected override string _GetTemplateForLabelVerificationEmailSent()
	{
		return "ÐŸÐ¸ÑÑŒÐ¼Ð¾ Ð´Ð»Ñ Ð¿Ð¾Ð´Ñ‚Ð²ÐµÑ€Ð¶Ð´ÐµÐ½Ð¸Ñ Ð¾Ñ‚Ð¿Ñ€Ð°Ð²Ð»ÐµÐ½Ð¾!";
	}

	protected override string _GetTemplateForLabelWeChatAntiAddictionText()
	{
		return "Ð˜Ð·Ð±ÐµÐ³Ð°Ð¹Ñ‚Ðµ Ð¿Ð»Ð¾Ñ…Ð¸Ñ… Ð¸ Ð¿Ð¸Ñ€Ð°Ñ‚ÑÐºÐ¸Ñ… Ð¸Ð³Ñ€. Ð‘ÑƒÐ´ÑŒÑ‚Ðµ Ð¾ÑÑ‚Ð¾Ñ€Ð¾Ð¶Ð½Ñ‹, Ð¸ Ð²Ð°Ñ Ð½Ðµ Ð¾Ð±Ð¼Ð°Ð½ÑƒÑ‚. Ð˜Ð³Ñ€Ñ‹ Ð¿Ð¾Ð¼Ð¾Ð³Ð°ÑŽÑ‚ Ñ€Ð°Ð·Ð²Ð¸Ð²Ð°Ñ‚ÑŒ Ð¼Ð¾Ð·Ð³, Ð¾Ð´Ð½Ð°ÐºÐ¾ Ð½Ðµ Ð½Ð°Ð´Ð¾ Ð¸Ð¼Ð¸ Ð·Ð»Ð¾ÑƒÐ¿Ð¾Ñ‚Ñ€ÐµÐ±Ð»ÑÑ‚ÑŒ â€“ ÑÑ‚Ð¾ Ð¼Ð¾Ð¶ÐµÑ‚ Ð½Ð°Ð½ÐµÑÑ‚Ð¸ Ð²Ñ€ÐµÐ´ Ð·Ð´Ð¾Ñ€Ð¾Ð²ÑŒÑŽ. Ð Ð°Ð·ÑƒÐ¼Ð½Ð¾ Ñ€Ð°ÑÐ¿Ñ€ÐµÐ´ÐµÐ»ÑÐ¹Ñ‚Ðµ ÑÐ²Ð¾Ðµ Ð²Ñ€ÐµÐ¼Ñ Ð¸ Ð½Ð°ÑÐ»Ð°Ð¶Ð´Ð°Ð¹Ñ‚ÐµÑÑŒ Ð¿Ñ€Ð°Ð²Ð¸Ð»ÑŒÐ½Ñ‹Ð¼ Ð¾Ð±Ñ€Ð°Ð·Ð¾Ð¼ Ð¶Ð¸Ð·Ð½Ð¸!";
	}

	protected override string _GetTemplateForMessageUnknownErrorTryAgain()
	{
		return "ÐŸÑ€Ð¾Ð¸Ð·Ð¾ÑˆÐ»Ð° Ð½ÐµÐ¸Ð·Ð²ÐµÑÑ‚Ð½Ð°Ñ Ð¾ÑˆÐ¸Ð±ÐºÐ°. ÐŸÐ¾Ð²Ñ‚Ð¾Ñ€Ð¸Ñ‚Ðµ Ð¿Ð¾Ð¿Ñ‹Ñ‚ÐºÑƒ.";
	}

	protected override string _GetTemplateForMessageUsernameAndPasswordRequired()
	{
		return "ÐÐµÐ¾Ð±Ñ…Ð¾Ð´Ð¸Ð¼Ð¾ ÑƒÐºÐ°Ð·Ð°Ñ‚ÑŒ Ð¸Ð¼Ñ Ð¿Ð¾Ð»ÑŒÐ·Ð¾Ð²Ð°Ñ‚ÐµÐ»Ñ Ð¸ Ð¿Ð°Ñ€Ð¾Ð»ÑŒ";
	}

	protected override string _GetTemplateForResponseAccountIssueErrorContactSupport()
	{
		return "ÐžÑˆÐ¸Ð±ÐºÐ° ÑƒÑ‡ÐµÑ‚Ð½Ð¾Ð¹ Ð·Ð°Ð¿Ð¸ÑÐ¸. ÐžÐ±Ñ€Ð°Ñ‚Ð¸Ñ‚ÐµÑÑŒ Ð² ÑÐ»ÑƒÐ¶Ð±Ñƒ Ð¿Ð¾Ð´Ð´ÐµÑ€Ð¶ÐºÐ¸.";
	}

	protected override string _GetTemplateForResponseAccountLockedRequestReset()
	{
		return "Ð£Ñ‡ÐµÑ‚Ð½Ð°Ñ Ð·Ð°Ð¿Ð¸ÑÑŒ Ð·Ð°Ð±Ð»Ð¾ÐºÐ¸Ñ€Ð¾Ð²Ð°Ð½Ð°. Ð—Ð°Ð¿Ñ€Ð¾ÑÐ¸Ñ‚Ðµ ÑÐ±Ñ€Ð¾Ñ Ð¿Ð°Ñ€Ð¾Ð»Ñ.";
	}

	protected override string _GetTemplateForResponseAccountNotFound()
	{
		return "Ð£Ñ‡ÐµÑ‚Ð½Ð°Ñ Ð·Ð°Ð¿Ð¸ÑÑŒ Ð½Ðµ Ð½Ð°Ð¹Ð´ÐµÐ½Ð°. ÐŸÐ¾Ð²Ñ‚Ð¾Ñ€Ð¸Ñ‚Ðµ Ð¿Ð¾Ð¿Ñ‹Ñ‚ÐºÑƒ.";
	}

	protected override string _GetTemplateForResponseEmailLinkedToMultipleAccountsLoginWithUsername()
	{
		return "Ð­Ñ‚Ð° ÑÐ». Ð¿Ð¾Ñ‡Ñ‚Ð° Ð¿Ñ€Ð¸Ð²ÑÐ·Ð°Ð½Ð° Ðº Ð½ÐµÑÐºÐ¾Ð»ÑŒÐºÐ¸Ð¼ Ð¿Ð¾Ð»ÑŒÐ·Ð¾Ð²Ð°Ñ‚ÐµÐ»ÑÐ¼. ÐŸÐ¾Ð¶Ð°Ð»ÑƒÐ¹ÑÑ‚Ð°, Ð²Ð²ÐµÐ´Ð¸Ñ‚Ðµ ÑÐ²Ð¾Ðµ Ð¸Ð¼Ñ Ð¿Ð¾Ð»ÑŒÐ·Ð¾Ð²Ð°Ñ‚ÐµÐ»Ñ.";
	}

	protected override string _GetTemplateForResponseEmailSent()
	{
		return "Ð¡Ð¾Ð¾Ð±Ñ‰ÐµÐ½Ð¸Ðµ Ð¾Ñ‚Ð¿Ñ€Ð°Ð²Ð»ÐµÐ½Ð¾!";
	}

	protected override string _GetTemplateForResponseIncorrectEmailOrPassword()
	{
		return "ÐÐµÐºÐ¾Ñ€Ñ€ÐµÐºÑ‚Ð½Ñ‹Ðµ ÑÐ». Ð¿Ð¾Ñ‡Ñ‚Ð° Ð¸Ð»Ð¸ Ð¿Ð°Ñ€Ð¾Ð»ÑŒ.";
	}

	protected override string _GetTemplateForResponseIncorrectPhoneOrPassword()
	{
		return "ÐÐµÐºÐ¾Ñ€Ñ€ÐµÐºÑ‚Ð½Ñ‹Ðµ Ð½Ð¾Ð¼ÐµÑ€ Ñ‚ÐµÐ»ÐµÑ„Ð¾Ð½Ð° Ð¸Ð»Ð¸ Ð¿Ð°Ñ€Ð¾Ð»ÑŒ.";
	}

	protected override string _GetTemplateForResponseIncorrectUsernamePassword()
	{
		return "ÐÐµÐ¿Ñ€Ð°Ð²Ð¸Ð»ÑŒÐ½Ñ‹Ðµ Ð¸Ð¼Ñ Ð¿Ð¾Ð»ÑŒÐ·Ð¾Ð²Ð°Ñ‚ÐµÐ»Ñ Ð¸Ð»Ð¸ Ð¿Ð°Ñ€Ð¾Ð»ÑŒ.";
	}

	protected override string _GetTemplateForResponseLoginWithUsername()
	{
		return "Ð’Ð¾Ð·Ð½Ð¸ÐºÐ»Ð¸ Ð¿Ñ€Ð¾Ð±Ð»ÐµÐ¼Ñ‹. ÐŸÐ¾Ð¶Ð°Ð»ÑƒÐ¹ÑÑ‚Ð°, Ð²Ð²ÐµÐ´Ð¸Ñ‚Ðµ ÑÐ²Ð¾Ðµ Ð¸Ð¼Ñ Ð¿Ð¾Ð»ÑŒÐ·Ð¾Ð²Ð°Ñ‚ÐµÐ»Ñ.";
	}

	protected override string _GetTemplateForResponsePasswordNotProvided()
	{
		return "ÐÐµÐ¾Ð±Ñ…Ð¾Ð´Ð¸Ð¼Ð¾ Ð²Ð²ÐµÑÑ‚Ð¸ Ð¿Ð°Ñ€Ð¾Ð»ÑŒ.";
	}

	protected override string _GetTemplateForResponseTooManyAttemptsPleaseWait()
	{
		return "Ð¡Ð»Ð¸ÑˆÐºÐ¾Ð¼ Ð¼Ð½Ð¾Ð³Ð¾ Ð¿Ð¾Ð¿Ñ‹Ñ‚Ð¾Ðº. ÐŸÐ¾Ð´Ð¾Ð¶Ð´Ð¸Ñ‚Ðµ.";
	}

	protected override string _GetTemplateForResponseUnknownError()
	{
		return "ÐÐµÐ¸Ð·Ð²ÐµÑÑ‚Ð½Ð°Ñ Ð¾ÑˆÐ¸Ð±ÐºÐ°";
	}

	protected override string _GetTemplateForResponseUnknownLoginError()
	{
		return "ÐÐµÐ¸Ð·Ð²ÐµÑÑ‚Ð½Ð°Ñ Ð¾ÑˆÐ¸Ð±ÐºÐ° Ð²Ñ…Ð¾Ð´Ð°";
	}

	protected override string _GetTemplateForResponseUnverifiedEmailLoginWithUsername()
	{
		return "Ð­Ñ‚Ð° ÑÐ». Ð¿Ð¾Ñ‡Ñ‚Ð° Ð½Ðµ Ð¿Ð¾Ð´Ñ‚Ð²ÐµÑ€Ð¶Ð´ÐµÐ½Ð°. ÐŸÐ¾Ð¶Ð°Ð»ÑƒÐ¹ÑÑ‚Ð°, Ð²Ð²ÐµÐ´Ð¸Ñ‚Ðµ ÑÐ²Ð¾Ðµ Ð¸Ð¼Ñ Ð¿Ð¾Ð»ÑŒÐ·Ð¾Ð²Ð°Ñ‚ÐµÐ»Ñ.";
	}

	protected override string _GetTemplateForResponseUnverifiedPhoneLoginWithUsername()
	{
		return "Ð­Ñ‚Ð¾Ñ‚ Ð½Ð¾Ð¼ÐµÑ€ Ñ‚ÐµÐ»ÐµÑ„Ð¾Ð½Ð° Ð½Ðµ Ð¿Ð¾Ð´Ñ‚Ð²ÐµÑ€Ð¶Ð´ÐµÐ½. ÐŸÐ¾Ð¶Ð°Ð»ÑƒÐ¹ÑÑ‚Ð°, Ð²Ð²ÐµÐ´Ð¸Ñ‚Ðµ ÑÐ²Ð¾Ðµ Ð¸Ð¼Ñ Ð¿Ð¾Ð»ÑŒÐ·Ð¾Ð²Ð°Ñ‚ÐµÐ»Ñ.";
	}

	protected override string _GetTemplateForResponseUsernameNotProvided()
	{
		return "ÐÐµÐ¾Ð±Ñ…Ð¾Ð´Ð¸Ð¼Ð¾ Ð²Ð²ÐµÑÑ‚Ð¸ Ð¸Ð¼Ñ Ð¿Ð¾Ð»ÑŒÐ·Ð¾Ð²Ð°Ñ‚ÐµÐ»Ñ.";
	}

	protected override string _GetTemplateForResponseUseSocialSignOn()
	{
		return "ÐÐµ ÑƒÐ´Ð°Ð»Ð¾ÑÑŒ Ð²Ð¾Ð¹Ñ‚Ð¸ Ð² ÑƒÑ‡ÐµÑ‚Ð½ÑƒÑŽ Ð·Ð°Ð¿Ð¸ÑÑŒ. Ð’Ð¾Ð¹Ð´Ð¸Ñ‚Ðµ Ñ‡ÐµÑ€ÐµÐ· ÑÐ¾Ñ†Ð¸Ð°Ð»ÑŒÐ½ÑƒÑŽ ÑÐµÑ‚ÑŒ.";
	}

	/// <summary>
	/// Key: "Response.WeChatNotRealNameVerified"
	/// English String: "Your WeChat is not real-name verified. Please use a real-name verified WeChat account and try again. Please visit {url}"
	/// </summary>
	public override string ResponseWeChatNotRealNameVerified(string url)
	{
		return $"Ð’Ð°ÑˆÐµ Ð½Ð°ÑÑ‚Ð¾ÑÑ‰ÐµÐµ Ð¸Ð¼Ñ Ð² WeChat Ð½Ðµ Ð¿Ð¾Ð´Ñ‚Ð²ÐµÑ€Ð¶Ð´ÐµÐ½Ð¾. ÐŸÐ¾Ð¶Ð°Ð»ÑƒÐ¹ÑÑ‚Ð°, Ð¸ÑÐ¿Ð¾Ð»ÑŒÐ·ÑƒÐ¹Ñ‚Ðµ ÑÐ²Ð¾ÑŽ Ñ€ÐµÐ°Ð»ÑŒÐ½ÑƒÑŽ, Ð¿Ð¾Ð´Ñ‚Ð²ÐµÑ€Ð¶Ð´ÐµÐ½Ð½ÑƒÑŽ Ð² WeChat ÑƒÑ‡ÐµÑ‚Ð½ÑƒÑŽ Ð·Ð°Ð¿Ð¸ÑÑŒ, Ð¸ Ð¿Ð¾Ð¿Ñ€Ð¾Ð±ÑƒÐ¹Ñ‚Ðµ ÐµÑ‰Ðµ Ñ€Ð°Ð·. ÐŸÐ¾Ð¶Ð°Ð»ÑƒÐ¹ÑÑ‚Ð°, Ð¿ÐµÑ€ÐµÐ¹Ð´Ð¸Ñ‚Ðµ Ð½Ð° {url}";
	}

	protected override string _GetTemplateForResponseWeChatNotRealNameVerified()
	{
		return "Ð’Ð°ÑˆÐµ Ð½Ð°ÑÑ‚Ð¾ÑÑ‰ÐµÐµ Ð¸Ð¼Ñ Ð² WeChat Ð½Ðµ Ð¿Ð¾Ð´Ñ‚Ð²ÐµÑ€Ð¶Ð´ÐµÐ½Ð¾. ÐŸÐ¾Ð¶Ð°Ð»ÑƒÐ¹ÑÑ‚Ð°, Ð¸ÑÐ¿Ð¾Ð»ÑŒÐ·ÑƒÐ¹Ñ‚Ðµ ÑÐ²Ð¾ÑŽ Ñ€ÐµÐ°Ð»ÑŒÐ½ÑƒÑŽ, Ð¿Ð¾Ð´Ñ‚Ð²ÐµÑ€Ð¶Ð´ÐµÐ½Ð½ÑƒÑŽ Ð² WeChat ÑƒÑ‡ÐµÑ‚Ð½ÑƒÑŽ Ð·Ð°Ð¿Ð¸ÑÑŒ, Ð¸ Ð¿Ð¾Ð¿Ñ€Ð¾Ð±ÑƒÐ¹Ñ‚Ðµ ÐµÑ‰Ðµ Ñ€Ð°Ð·. ÐŸÐ¾Ð¶Ð°Ð»ÑƒÐ¹ÑÑ‚Ð°, Ð¿ÐµÑ€ÐµÐ¹Ð´Ð¸Ñ‚Ðµ Ð½Ð° {url}";
	}

	protected override string _GetTemplateForWeChatAntiAddictionText()
	{
		return "Ð˜Ð·Ð±ÐµÐ³Ð°Ð¹Ñ‚Ðµ Ð¿Ð»Ð¾Ñ…Ð¸Ñ… Ð¸ Ð¿Ð¸Ñ€Ð°Ñ‚ÑÐºÐ¸Ñ… Ð¸Ð³Ñ€. Ð‘ÑƒÐ´ÑŒÑ‚Ðµ Ð¾ÑÑ‚Ð¾Ñ€Ð¾Ð¶Ð½Ñ‹, Ð¸ Ð²Ð°Ñ Ð½Ðµ Ð¾Ð±Ð¼Ð°Ð½ÑƒÑ‚. Ð˜Ð³Ñ€Ñ‹ Ð¿Ð¾Ð¼Ð¾Ð³Ð°ÑŽÑ‚ Ñ€Ð°Ð·Ð²Ð¸Ð²Ð°Ñ‚ÑŒ Ð¼Ð¾Ð·Ð³, Ð¾Ð´Ð½Ð°ÐºÐ¾ Ð½Ðµ Ð½Ð°Ð´Ð¾ Ñ ÑÑ‚Ð¸Ð¼ Ð·Ð»Ð¾ÑƒÐ¿Ð¾Ñ‚Ñ€ÐµÐ±Ð»ÑÑ‚ÑŒ â€“ ÑÑ‚Ð¾ Ð¼Ð¾Ð¶ÐµÑ‚ Ð½Ð°Ð½ÐµÑÑ‚Ð¸ Ð²Ñ€ÐµÐ´ Ð·Ð´Ð¾Ñ€Ð¾Ð²ÑŒÑŽ. Ð Ð°Ð·ÑƒÐ¼Ð½Ð¾ Ñ€Ð°ÑÐ¿Ñ€ÐµÐ´ÐµÐ»ÑÐ¹Ñ‚Ðµ ÑÐ²Ð¾Ðµ Ð²Ñ€ÐµÐ¼Ñ Ð¸ Ð½Ð°ÑÐ»Ð°Ð¶Ð´Ð°Ð¹Ñ‚ÐµÑÑŒ Ð¿Ñ€Ð°Ð²Ð¸Ð»ÑŒÐ½Ñ‹Ð¼ Ð¾Ð±Ñ€Ð°Ð·Ð¾Ð¼ Ð¶Ð¸Ð·Ð½Ð¸!";
	}

	protected override string _GetTemplateForWeChatRealNameNotVerified()
	{
		return "Ð’Ð°ÑˆÐµ Ð½Ð°ÑÑ‚Ð¾ÑÑ‰ÐµÐµ Ð¸Ð¼Ñ Ð² WeChat Ð½Ðµ Ð¿Ð¾Ð´Ñ‚Ð²ÐµÑ€Ð¶Ð´ÐµÐ½Ð¾. ÐŸÐ¾Ð¶Ð°Ð»ÑƒÐ¹ÑÑ‚Ð°, Ð¸ÑÐ¿Ð¾Ð»ÑŒÐ·ÑƒÐ¹Ñ‚Ðµ ÑÐ²Ð¾ÑŽ Ñ€ÐµÐ°Ð»ÑŒÐ½ÑƒÑŽ, Ð¿Ð¾Ð´Ñ‚Ð²ÐµÑ€Ð¶Ð´ÐµÐ½Ð½ÑƒÑŽ Ð² WeChat ÑƒÑ‡ÐµÑ‚Ð½ÑƒÑŽ Ð·Ð°Ð¿Ð¸ÑÑŒ, Ð¸ Ð¿Ð¾Ð¿Ñ€Ð¾Ð±ÑƒÐ¹Ñ‚Ðµ ÐµÑ‰Ðµ Ñ€Ð°Ð·. ÐŸÐ¾Ð¶Ð°Ð»ÑƒÐ¹ÑÑ‚Ð°, Ð¿ÐµÑ€ÐµÐ¹Ð´Ð¸Ñ‚Ðµ Ð½Ð° https://jiazhang.qq.com/zk/home.html";
	}
}


}
