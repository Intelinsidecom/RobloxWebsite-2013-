namespace Roblox.Platform.TranslationResources.Authentication {
    /// <summary>

/// This class overrides LoginResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class LoginResources_ja_jp : LoginResources_en_us, ILoginResources, ITranslationResources
{
	/// <summary>
	/// Key: "Action.Cancel"
	/// Cancel button text
	/// English String: "Cancel"
	/// </summary>
	public override string ActionCancel => "ã‚­ãƒ£ãƒ³ã‚»ãƒ«";

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
	public override string ActionForgotPasswordOrUsernameQuestion => "ãƒ‘ã‚¹ãƒ¯ãƒ¼ãƒ‰ã€ã¾ãŸã¯ãƒ¦ãƒ¼ã‚¶ãƒ¼ãƒãƒ¼ãƒ ã‚’ãŠå¿˜ã‚Œã§ã™ã‹ï¼Ÿ";

	/// <summary>
	/// Key: "Action.ForgotPasswordOrUsernameQuestionCapitalized"
	/// link under login form
	/// English String: "Forgot Password or Username?"
	/// </summary>
	public override string ActionForgotPasswordOrUsernameQuestionCapitalized => "ãƒ‘ã‚¹ãƒ¯ãƒ¼ãƒ‰ã€ã¾ãŸã¯ãƒ¦ãƒ¼ã‚¶ãƒ¼ãƒãƒ¼ãƒ ã‚’ãŠå¿˜ã‚Œã§ã™ã‹ï¼Ÿ";

	/// <summary>
	/// Key: "Action.Login"
	/// English String: "Login"
	/// </summary>
	public override string ActionLogin => "ãƒ­ã‚°ã‚¤ãƒ³";

	/// <summary>
	/// Key: "Action.LogInCapitalized"
	/// login button label. please note this is different from 'Login' or 'Log in'.
	/// English String: "Log In"
	/// </summary>
	public override string ActionLogInCapitalized => "ãƒ­ã‚°ã‚¤ãƒ³";

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
	public override string ActionPlayAsGuest => "ã‚²ã‚¹ãƒˆã¨ã—ã¦ãƒ—ãƒ¬ã‚¤ã™ã‚‹";

	/// <summary>
	/// Key: "Action.Resend"
	/// button text for resending verification email
	/// English String: "Resend"
	/// </summary>
	public override string ActionResend => "å†é€ä¿¡";

	/// <summary>
	/// Key: "Action.ResendEmail"
	/// link that resends verification email to user
	/// English String: "Resend Email"
	/// </summary>
	public override string ActionResendEmail => "ãƒ¡ãƒ¼ãƒ«ã‚’å†é€ä¿¡";

	/// <summary>
	/// Key: "Action.SendVerificationEmail"
	/// button user can click to send a verification link to their email
	/// English String: "Send Verification Email"
	/// </summary>
	public override string ActionSendVerificationEmail => "ç¢ºèªãƒ¡ãƒ¼ãƒ«ã‚’é€ä¿¡";

	/// <summary>
	/// Key: "Action.SignIn"
	/// Sign In button text
	/// English String: "Sign In"
	/// </summary>
	public override string ActionSignIn => "ã‚µã‚¤ãƒ³ã‚¤ãƒ³";

	/// <summary>
	/// Key: "Action.SignInWithFacebook"
	/// Sign In with Facebook
	/// English String: "Sign In with Facebook"
	/// </summary>
	public override string ActionSignInWithFacebook => "Facebookã§ã‚µã‚¤ãƒ³ã‚¤ãƒ³ã™ã‚‹";

	/// <summary>
	/// Key: "Action.SignUp"
	/// English String: "Sign up"
	/// </summary>
	public override string ActionSignUp => "æ–°è¦ç™»éŒ²";

	/// <summary>
	/// Key: "Action.SignUpCapitalized"
	/// link which takes user to sign up page
	/// English String: "Sign Up"
	/// </summary>
	public override string ActionSignUpCapitalized => "æ–°è¦ç™»éŒ²";

	/// <summary>
	/// Key: "Action.WeChatLogin"
	/// button text for logging in with WeChat
	/// English String: "WeChat Login"
	/// </summary>
	public override string ActionWeChatLogin => "WeChatãƒ­ã‚°ã‚¤ãƒ³";

	/// <summary>
	/// Key: "Heading.Login"
	/// heading on the login page
	/// English String: "Login"
	/// </summary>
	public override string HeadingLogin => "ãƒ­ã‚°ã‚¤ãƒ³";

	/// <summary>
	/// Key: "Heading.LoginRoblox"
	/// current login page heading
	/// English String: "Login to Roblox"
	/// </summary>
	public override string HeadingLoginRoblox => "Robloxã«ãƒ­ã‚°ã‚¤ãƒ³ã™ã‚‹";

	public override string HeadingSignUpMakeFriends => "æ–°è¦ç™»éŒ²ã—ã¦ã‚²ãƒ¼ãƒ åˆ¶ä½œã—ãŸã‚Šã€å‹é”ã‚’ä½œã‚‹";

	/// <summary>
	/// Key: "Label.AccountNotNeeded"
	/// You don't need an account to play Roblox
	/// English String: "You don't need an account to play Roblox"
	/// </summary>
	public override string LabelAccountNotNeeded => "Robloxã‚’ãƒ—ãƒ¬ã‚¤ã™ã‚‹ã®ã«ã‚¢ã‚«ã‚¦ãƒ³ãƒˆã¯å¿…è¦ã‚ã‚Šã¾ã›ã‚“ã€‚";

	/// <summary>
	/// Key: "Label.EmailNeedsVerification"
	/// modal header used for prompting user they need to verify their email in order to log in with it
	/// English String: "Your email needs verification"
	/// </summary>
	public override string LabelEmailNeedsVerification => "ãƒ¡ãƒ¼ãƒ«ç¢ºèªã®æ‰‹ç¶šããŒå¿…è¦ã§ã™";

	/// <summary>
	/// Key: "Label.FacebookCreatePasswordWarning"
	/// If you have been signing in with Facebook, you must set a password.
	/// English String: "If you have been signing in with Facebook, you must set a password."
	/// </summary>
	public override string LabelFacebookCreatePasswordWarning => "Facebookã§ã‚µã‚¤ãƒ³ã‚¤ãƒ³ã—ã¦ã„ã‚‹å ´åˆã«ã¯ã€ãƒ‘ã‚¹ãƒ¯ãƒ¼ãƒ‰ã®è¨­å®šãŒå¿…è¦ã§ã™ã€‚";

	/// <summary>
	/// Key: "Label.ForgotUsernamePassword"
	/// landing page top right link for password reset
	/// English String: "Forgot Username/Password?"
	/// </summary>
	public override string LabelForgotUsernamePassword => "ãƒ¦ãƒ¼ã‚¶ãƒ¼ãƒãƒ¼ãƒ ã‹ãƒ‘ã‚¹ãƒ¯ãƒ¼ãƒ‰ã‚’ãŠå¿˜ã‚Œã§ã™ã‹ï¼Ÿ";

	/// <summary>
	/// Key: "Label.LearnMore"
	/// learn more link text
	/// English String: "Learn more"
	/// </summary>
	public override string LabelLearnMore => "è©³ã—ãçŸ¥ã‚‹";

	/// <summary>
	/// Key: "Label.LoggingInSpinnerText"
	/// English String: "Logging inâ€¦"
	/// </summary>
	public override string LabelLoggingInSpinnerText => "ãƒ­ã‚°ã‚¤ãƒ³ä¸­â€¦";

	/// <summary>
	/// Key: "Label.Login"
	/// English String: "Log in"
	/// </summary>
	public override string LabelLogin => "ãƒ­ã‚°ã‚¤ãƒ³";

	/// <summary>
	/// Key: "Label.LoginWithYour"
	/// Label for a partition line between login with email and facebook login. Please keep the text in lowercase for roman characters.
	/// English String: "login with your"
	/// </summary>
	public override string LabelLoginWithYour => "ä»¥ä¸‹ã§ãƒ­ã‚°ã‚¤ãƒ³ã—ã¦ãã ã•ã„";

	/// <summary>
	/// Key: "Label.NoAccount"
	/// Don't have an account?
	/// English String: "Don't have an account?"
	/// </summary>
	public override string LabelNoAccount => "ã‚¢ã‚«ã‚¦ãƒ³ãƒˆã‚’ãŠæŒã¡ã§ã¯ã‚ã‚Šã¾ã›ã‚“ã‹ï¼Ÿ";

	/// <summary>
	/// Key: "Label.NonAMemberQuestion"
	/// The question heading for the section on the login page to take use to sign up page.
	/// English String: "Not a member?"
	/// </summary>
	public override string LabelNonAMemberQuestion => "ãƒ¡ãƒ³ãƒãƒ¼ã§ã¯ã‚ã‚Šã¾ã›ã‚“ã‹ï¼Ÿ";

	/// <summary>
	/// Key: "Label.NotReceived"
	/// prompt for allowing users to resend verification email
	/// English String: "Didn't receive it?"
	/// </summary>
	public override string LabelNotReceived => "å—ä¿¡ã§ãã¾ã›ã‚“ã§ã—ãŸã‹ï¼Ÿ";

	/// <summary>
	/// Key: "Label.Or"
	/// partition between email login and facebook login
	/// English String: "Or"
	/// </summary>
	public override string LabelOr => "ã¾ãŸã¯";

	/// <summary>
	/// Key: "Label.Password"
	/// Password
	/// English String: "Password"
	/// </summary>
	public override string LabelPassword => "ãƒ‘ã‚¹ãƒ¯ãƒ¼ãƒ‰";

	/// <summary>
	/// Key: "Label.PasswordWithColumn"
	/// label for the password field on the login page
	/// English String: "Password:"
	/// </summary>
	public override string LabelPasswordWithColumn => "ãƒ‘ã‚¹ãƒ¯ãƒ¼ãƒ‰ï¼š";

	/// <summary>
	/// Key: "Label.StartPlaying"
	/// You can start playing right now, in guest mode!
	/// English String: "You can start playing right now, in guest mode!"
	/// </summary>
	public override string LabelStartPlaying => "ã‚²ã‚¹ãƒˆãƒ¢ãƒ¼ãƒ‰ã§ä»Šã™ããƒ—ãƒ¬ã‚¤ã§ãã¾ã™ï¼";

	/// <summary>
	/// Key: "Label.UnverifiedEmailInstructions"
	/// message shown in a modal when user logs in with unverified email
	/// English String: "To log in with your email, it must be verified. You can also log in with your username."
	/// </summary>
	public override string LabelUnverifiedEmailInstructions => "ãƒ¡ãƒ¼ãƒ«ã‚¢ãƒ‰ãƒ¬ã‚¹ã§ãƒ­ã‚°ã‚¤ãƒ³ã™ã‚‹ãŸã‚ã«ã¯ã€ã¾ãšèªè¨¼ãŒå¿…è¦ã§ã™ã€‚ãƒ¦ãƒ¼ã‚¶ãƒ¼ãƒãƒ¼ãƒ ã§ãƒ­ã‚°ã‚¤ãƒ³ã™ã‚‹ã“ã¨ã‚‚ã§ãã¾ã™ã€‚";

	/// <summary>
	/// Key: "Label.Username"
	/// English String: "Username"
	/// </summary>
	public override string LabelUsername => "ãƒ¦ãƒ¼ã‚¶ãƒ¼ãƒãƒ¼ãƒ ";

	/// <summary>
	/// Key: "Label.UsernameEmail"
	/// placeholder text for input field that accepts username or email
	/// English String: "Username/Email"
	/// </summary>
	public override string LabelUsernameEmail => "ãƒ¦ãƒ¼ã‚¶ãƒ¼ãƒãƒ¼ãƒ /ãƒ¡ãƒ¼ãƒ«ã‚¢ãƒ‰ãƒ¬ã‚¹";

	/// <summary>
	/// Key: "Label.UsernameEmailPhone"
	/// placeholder text for input fields that accept username, email or phone
	/// English String: "Username/Email/Phone"
	/// </summary>
	public override string LabelUsernameEmailPhone => "ãƒ¦ãƒ¼ã‚¶ãƒ¼ãƒãƒ¼ãƒ /ãƒ¡ãƒ¼ãƒ«ã‚¢ãƒ‰ãƒ¬ã‚¹/é›»è©±ç•ªå·";

	/// <summary>
	/// Key: "Label.UsernamePhone"
	/// placeholder text for input field that accepts username or phone
	/// English String: "Username/Phone"
	/// </summary>
	public override string LabelUsernamePhone => "ãƒ¦ãƒ¼ã‚¶ãƒ¼ãƒãƒ¼ãƒ /é›»è©±ç•ªå·";

	/// <summary>
	/// Key: "Label.UsernameWithColumn"
	/// label for username field on login page
	/// English String: "Username:"
	/// </summary>
	public override string LabelUsernameWithColumn => "ãƒ¦ãƒ¼ã‚¶ãƒ¼ãƒãƒ¼ãƒ :";

	/// <summary>
	/// Key: "Label.VerificationEmailSent"
	/// message telling user a verification email was sent to them
	/// English String: "Verification Email Sent!"
	/// </summary>
	public override string LabelVerificationEmailSent => "ç¢ºèªãƒ¡ãƒ¼ãƒ«ãŒé€ä¿¡ã•ã‚Œã¾ã—ãŸï¼";

	/// <summary>
	/// Key: "Label.WeChatAntiAddictionText"
	/// English String: "Boycott bad games, refuse pirated games. Be aware of self-defense and being deceived. Playing games is good for your brain, but too much game play can harm your health. Manage your time well and enjoy a healthy lifestyle."
	/// </summary>
	public override string LabelWeChatAntiAddictionText => "ä¸é©åˆ‡ãªã‚²ãƒ¼ãƒ ã«ã¯å‚åŠ ã—ãªã„ã‚ˆã†ã«å¿ƒæŽ›ã‘ã€æµ·è³Šç‰ˆã¯æ‹’å¦ã—ã¾ã—ã‚‡ã†ã€‚è‡ªè¡›æ„è­˜ã‚’é«˜ã‚ã€é¨™ã•ã‚Œãªã„ã‚ˆã†ã«ã—ã¾ã—ã‚‡ã†ã€‚ã‚²ãƒ¼ãƒ ã‚’ãƒ—ãƒ¬ã‚¤ã™ã‚‹ã“ã¨ã¯è„³ã®åƒãã‚’é«˜ã‚ã¦ãã‚Œã¾ã™ãŒã€ãƒ—ãƒ¬ã‚¤ã—ã™ãŽã‚‹ã¨å¥åº·ã‚’å®³ã™ã‚‹æã‚ŒãŒã‚ã‚Šã¾ã™ã€‚æ™‚é–“ç®¡ç†ã‚’ãã¡ã‚“ã¨è¡Œã„ã€å¥åº·çš„ãªãƒ©ã‚¤ãƒ•ã‚¹ã‚¿ã‚¤ãƒ«ã‚’ãŠæ¥½ã—ã¿ãã ã•ã„ã€‚";

	/// <summary>
	/// Key: "Message.UnknownErrorTryAgain"
	/// An unknown error occurred. Please try again.
	/// English String: "An unknown error occurred. Please try again."
	/// </summary>
	public override string MessageUnknownErrorTryAgain => "ä¸æ˜Žãªã‚¨ãƒ©ãƒ¼ãŒç™ºç”Ÿã—ã¾ã—ãŸã€‚ã‚‚ã†ä¸€åº¦ãŠè©¦ã—ãã ã•ã„ã€‚";

	/// <summary>
	/// Key: "Message.UsernameAndPasswordRequired"
	/// message shown to user when they attempt to login without entering a username or password
	/// English String: "Username and password required"
	/// </summary>
	public override string MessageUsernameAndPasswordRequired => "ãƒ¦ãƒ¼ã‚¶ãƒ¼ãƒãƒ¼ãƒ ã¨ãƒ‘ã‚¹ãƒ¯ãƒ¼ãƒ‰ãŒå¿…è¦ã§ã™";

	/// <summary>
	/// Key: "Response.AccountIssueErrorContactSupport"
	/// English String: "Account issue. Please contact Support."
	/// </summary>
	public override string ResponseAccountIssueErrorContactSupport => "ã‚¢ã‚«ã‚¦ãƒ³ãƒˆã«é–¢ã™ã‚‹å•é¡ŒãŒç™ºç”Ÿã—ã¾ã—ãŸã€‚ã‚µãƒãƒ¼ãƒˆã«ãŠå•ã„åˆã‚ã›ãã ã•ã„ã€‚";

	/// <summary>
	/// Key: "Response.AccountLockedRequestReset"
	/// Account has been locked. Please request a password reset.
	/// English String: "Account has been locked. Please request a password reset."
	/// </summary>
	public override string ResponseAccountLockedRequestReset => "ã‚¢ã‚«ã‚¦ãƒ³ãƒˆãŒãƒ­ãƒƒã‚¯ã•ã‚Œã¦ã„ã¾ã™ã€‚ãƒ‘ã‚¹ãƒ¯ãƒ¼ãƒ‰ãƒªã‚»ãƒƒãƒˆã‚’ãƒªã‚¯ã‚¨ã‚¹ãƒˆã—ã¦ãã ã•ã„ã€‚";

	/// <summary>
	/// Key: "Response.AccountNotFound"
	/// Account not found. Please try again.
	/// English String: "Account not found. Please try again."
	/// </summary>
	public override string ResponseAccountNotFound => "ã‚¢ã‚«ã‚¦ãƒ³ãƒˆãŒè¦‹ã¤ã‹ã‚Šã¾ã›ã‚“ã§ã—ãŸã€‚ã‚‚ã†ä¸€åº¦ãŠè©¦ã—ãã ã•ã„ã€‚";

	/// <summary>
	/// Key: "Response.EmailLinkedToMultipleAccountsLoginWithUsername"
	/// error message displayed when user attempts to log in with an email that is linked to multiple accounts
	/// English String: "Your email is associated with more than 1 username. Please login with your username."
	/// </summary>
	public override string ResponseEmailLinkedToMultipleAccountsLoginWithUsername => "ãƒ¡ãƒ¼ãƒ«ã‚¢ãƒ‰ãƒ¬ã‚¹ãŒè¤‡æ•°ã®ãƒ¦ãƒ¼ã‚¶ãƒ¼ãƒãƒ¼ãƒ ã«é–¢é€£ä»˜ã‘ã‚‰ã‚Œã¦ã„ã¾ã™ã€‚ãƒ¦ãƒ¼ã‚¶ãƒ¼ãƒãƒ¼ãƒ ã§ãƒ­ã‚°ã‚¤ãƒ³ã—ã¦ãã ã•ã„ã€‚";

	/// <summary>
	/// Key: "Response.EmailSent"
	/// response telling user that a verification email has been sent to them
	/// English String: "Email sent!"
	/// </summary>
	public override string ResponseEmailSent => "ãƒ¡ãƒ¼ãƒ«ãŒé€ä¿¡ã•ã‚Œã¾ã—ãŸï¼";

	/// <summary>
	/// Key: "Response.IncorrectEmailOrPassword"
	/// error message displayed when user logs in with an invalid email or password
	/// English String: "Incorrect email or password."
	/// </summary>
	public override string ResponseIncorrectEmailOrPassword => "ãƒ¡ãƒ¼ãƒ«ã‚¢ãƒ‰ãƒ¬ã‚¹ã¾ãŸã¯ãƒ‘ã‚¹ãƒ¯ãƒ¼ãƒ‰ãŒé–“é•ã£ã¦ã„ã¾ã™ã€‚";

	/// <summary>
	/// Key: "Response.IncorrectPhoneOrPassword"
	/// error message displayed when user logs in with an invalid phone or password
	/// English String: "Incorrect phone or password."
	/// </summary>
	public override string ResponseIncorrectPhoneOrPassword => "é›»è©±ç•ªå·ã¾ãŸã¯ãƒ‘ã‚¹ãƒ¯ãƒ¼ãƒ‰ãŒé–“é•ã£ã¦ã„ã¾ã™ã€‚";

	/// <summary>
	/// Key: "Response.IncorrectUsernamePassword"
	/// English String: "Incorrect username or password."
	/// </summary>
	public override string ResponseIncorrectUsernamePassword => "ãƒ¦ãƒ¼ã‚¶ãƒ¼ãƒãƒ¼ãƒ ã€ã¾ãŸã¯ãƒ‘ã‚¹ãƒ¯ãƒ¼ãƒ‰ãŒé–“é•ã£ã¦ã„ã¾ã™ã€‚";

	/// <summary>
	/// Key: "Response.LoginWithUsername"
	/// error message shown when user attempts to login with method other than username and an error occurred
	/// English String: "Something went wrong. Please login with your username."
	/// </summary>
	public override string ResponseLoginWithUsername => "ä½•ã‚‰ã‹ã®å•é¡ŒãŒç™ºç”Ÿã—ã¾ã—ãŸã€‚ã‚‚ã†ä¸€åº¦ãŠè©¦ã—ãã ã•ã„ã€‚";

	/// <summary>
	/// Key: "Response.PasswordNotProvided"
	/// password field is empty
	/// English String: "You must enter a password."
	/// </summary>
	public override string ResponsePasswordNotProvided => "ãƒ‘ã‚¹ãƒ¯ãƒ¼ãƒ‰ã¯å¿…é ˆã§ã™ã€‚";

	/// <summary>
	/// Key: "Response.TooManyAttemptsPleaseWait"
	/// English String: "Too many attempts. Please wait a bit."
	/// </summary>
	public override string ResponseTooManyAttemptsPleaseWait => "è©¦è¡Œå›žæ•°ãŒå¤šã™ãŽã¾ã™ã€‚ã—ã°ã‚‰ãã—ã¦ã‹ã‚‰ã‚„ã‚Šç›´ã—ã¦ãã ã•ã„ã€‚";

	/// <summary>
	/// Key: "Response.UnknownError"
	/// English String: "Unknown Error"
	/// </summary>
	public override string ResponseUnknownError => "ä¸æ˜Žãªã‚¨ãƒ©ãƒ¼ãŒç™ºç”Ÿã—ã¾ã—ãŸ";

	/// <summary>
	/// Key: "Response.UnknownLoginError"
	/// Unknown login failure.
	/// English String: "Unknown login failure."
	/// </summary>
	public override string ResponseUnknownLoginError => "ä¸æ˜Žãªãƒ­ã‚°ã‚¤ãƒ³ã®å¤±æ•—ã€‚";

	/// <summary>
	/// Key: "Response.UnverifiedEmailLoginWithUsername"
	/// error message shown when user attempts to login with unverified email
	/// English String: "Your email is not verified. Please login with your username."
	/// </summary>
	public override string ResponseUnverifiedEmailLoginWithUsername => "ãƒ¡ãƒ¼ãƒ«ã‚¢ãƒ‰ãƒ¬ã‚¹ãŒèªè¨¼ã•ã‚Œã¦ã„ã¾ã›ã‚“ã€‚ãƒ¦ãƒ¼ã‚¶ãƒ¼ãƒãƒ¼ãƒ ã§ãƒ­ã‚°ã‚¤ãƒ³ã—ã¦ãã ã•ã„ã€‚";

	/// <summary>
	/// Key: "Response.UnverifiedPhoneLoginWithUsername"
	/// error message shown when user attempts to login with an unverified phone number
	/// English String: "Your phone is not verified. Please login with your username."
	/// </summary>
	public override string ResponseUnverifiedPhoneLoginWithUsername => "é›»è©±ç•ªå·ãŒèªè¨¼ã•ã‚Œã¦ã„ã¾ã›ã‚“ã€‚ãƒ¦ãƒ¼ã‚¶ãƒ¼ãƒãƒ¼ãƒ ã§ãƒ­ã‚°ã‚¤ãƒ³ã—ã¦ãã ã•ã„ã€‚";

	/// <summary>
	/// Key: "Response.UsernameNotProvided"
	/// username field is empty
	/// English String: "You must enter a username."
	/// </summary>
	public override string ResponseUsernameNotProvided => "ãƒ¦ãƒ¼ã‚¶ãƒ¼ãƒãƒ¼ãƒ ã¯å¿…é ˆã§ã™ã€‚";

	/// <summary>
	/// Key: "Response.UseSocialSignOn"
	/// Unable to login. Please use Social Network sign on.
	/// English String: "Unable to login. Please use Social Network sign on."
	/// </summary>
	public override string ResponseUseSocialSignOn => "ãƒ­ã‚°ã‚¤ãƒ³ã§ãã¾ã›ã‚“ã§ã—ãŸã€‚ã‚½ãƒ¼ã‚·ãƒ£ãƒ«ãƒãƒƒãƒˆãƒ¯ãƒ¼ã‚¯ãƒ»ã‚µã‚¤ãƒ³ã‚ªãƒ³ã‚’ã”åˆ©ç”¨ãã ã•ã„ã€‚";

	/// <summary>
	/// Key: "WeChat.AntiAddictionText"
	/// English String: "Boycott bad games, refuse pirated games. Be aware of self-defense and being deceived. Playing games is good for your brain, but too much game play can harm your health. Manage your time well and enjoy a healthy lifestyle."
	/// </summary>
	public override string WeChatAntiAddictionText => "ä¸é©åˆ‡ãªã‚²ãƒ¼ãƒ ã«ã¯å‚åŠ ã—ãªã„ã‚ˆã†ã«å¿ƒæŽ›ã‘ã€æµ·è³Šç‰ˆã¯æ‹’å¦ã—ã¾ã—ã‚‡ã†ã€‚è‡ªè¡›æ„è­˜ã‚’é«˜ã‚ã€é¨™ã•ã‚Œãªã„ã‚ˆã†ã«ã—ã¾ã—ã‚‡ã†ã€‚ã‚²ãƒ¼ãƒ ã‚’ãƒ—ãƒ¬ã‚¤ã™ã‚‹ã“ã¨ã¯è„³ã®åƒãã‚’é«˜ã‚ã¦ãã‚Œã¾ã™ãŒã€ãƒ—ãƒ¬ã‚¤ã—ã™ãŽã‚‹ã¨å¥åº·ã‚’å®³ã™ã‚‹æã‚ŒãŒã‚ã‚Šã¾ã™ã€‚æ™‚é–“ç®¡ç†ã‚’ãã¡ã‚“ã¨è¡Œã„ã€å¥åº·çš„ãªãƒ©ã‚¤ãƒ•ã‚¹ã‚¿ã‚¤ãƒ«ã‚’ãŠæ¥½ã—ã¿ãã ã•ã„ã€‚";

	/// <summary>
	/// Key: "WeChat.RealNameNotVerified"
	/// English String: "Your WeChat is not real-name verified. Please use a real-name verified WeChat account and try again. Please visit https://jiazhang.qq.com/zk/home.html"
	/// </summary>
	public override string WeChatRealNameNotVerified => "WeChatã§ã€æœ¬åã®èªè¨¼ãŒè¡Œã‚ã‚Œã¦ã„ã¾ã›ã‚“ã€‚æœ¬åã®èªè¨¼ã‚’è¡Œã£ãŸWeChatã‚¢ã‚«ã‚¦ãƒ³ãƒˆã‚’ä½¿ç”¨ã—ã¦ã‚„ã‚Šç›´ã—ã¦ãã ã•ã„ã€‚https://jiazhang.qq.com/zk/home.html ã«ã‚¢ã‚¯ã‚»ã‚¹ã—ã¦ãã ã•ã„ã€‚";

	public LoginResources_ja_jp(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionCancel()
	{
		return "ã‚­ãƒ£ãƒ³ã‚»ãƒ«";
	}

	protected override string _GetTemplateForActionFacebook()
	{
		return "Facebook";
	}

	protected override string _GetTemplateForActionForgotPasswordOrUsernameQuestion()
	{
		return "ãƒ‘ã‚¹ãƒ¯ãƒ¼ãƒ‰ã€ã¾ãŸã¯ãƒ¦ãƒ¼ã‚¶ãƒ¼ãƒãƒ¼ãƒ ã‚’ãŠå¿˜ã‚Œã§ã™ã‹ï¼Ÿ";
	}

	protected override string _GetTemplateForActionForgotPasswordOrUsernameQuestionCapitalized()
	{
		return "ãƒ‘ã‚¹ãƒ¯ãƒ¼ãƒ‰ã€ã¾ãŸã¯ãƒ¦ãƒ¼ã‚¶ãƒ¼ãƒãƒ¼ãƒ ã‚’ãŠå¿˜ã‚Œã§ã™ã‹ï¼Ÿ";
	}

	protected override string _GetTemplateForActionLogin()
	{
		return "ãƒ­ã‚°ã‚¤ãƒ³";
	}

	protected override string _GetTemplateForActionLogInCapitalized()
	{
		return "ãƒ­ã‚°ã‚¤ãƒ³";
	}

	protected override string _GetTemplateForActionOk()
	{
		return "OK";
	}

	protected override string _GetTemplateForActionPlayAsGuest()
	{
		return "ã‚²ã‚¹ãƒˆã¨ã—ã¦ãƒ—ãƒ¬ã‚¤ã™ã‚‹";
	}

	protected override string _GetTemplateForActionResend()
	{
		return "å†é€ä¿¡";
	}

	protected override string _GetTemplateForActionResendEmail()
	{
		return "ãƒ¡ãƒ¼ãƒ«ã‚’å†é€ä¿¡";
	}

	protected override string _GetTemplateForActionSendVerificationEmail()
	{
		return "ç¢ºèªãƒ¡ãƒ¼ãƒ«ã‚’é€ä¿¡";
	}

	protected override string _GetTemplateForActionSignIn()
	{
		return "ã‚µã‚¤ãƒ³ã‚¤ãƒ³";
	}

	protected override string _GetTemplateForActionSignInWithFacebook()
	{
		return "Facebookã§ã‚µã‚¤ãƒ³ã‚¤ãƒ³ã™ã‚‹";
	}

	protected override string _GetTemplateForActionSignUp()
	{
		return "æ–°è¦ç™»éŒ²";
	}

	protected override string _GetTemplateForActionSignUpCapitalized()
	{
		return "æ–°è¦ç™»éŒ²";
	}

	protected override string _GetTemplateForActionWeChatLogin()
	{
		return "WeChatãƒ­ã‚°ã‚¤ãƒ³";
	}

	protected override string _GetTemplateForHeadingLogin()
	{
		return "ãƒ­ã‚°ã‚¤ãƒ³";
	}

	protected override string _GetTemplateForHeadingLoginRoblox()
	{
		return "Robloxã«ãƒ­ã‚°ã‚¤ãƒ³ã™ã‚‹";
	}

	protected override string _GetTemplateForHeadingSignUpMakeFriends()
	{
		return "æ–°è¦ç™»éŒ²ã—ã¦ã‚²ãƒ¼ãƒ åˆ¶ä½œã—ãŸã‚Šã€å‹é”ã‚’ä½œã‚‹";
	}

	protected override string _GetTemplateForLabelAccountNotNeeded()
	{
		return "Robloxã‚’ãƒ—ãƒ¬ã‚¤ã™ã‚‹ã®ã«ã‚¢ã‚«ã‚¦ãƒ³ãƒˆã¯å¿…è¦ã‚ã‚Šã¾ã›ã‚“ã€‚";
	}

	protected override string _GetTemplateForLabelEmailNeedsVerification()
	{
		return "ãƒ¡ãƒ¼ãƒ«ç¢ºèªã®æ‰‹ç¶šããŒå¿…è¦ã§ã™";
	}

	protected override string _GetTemplateForLabelFacebookCreatePasswordWarning()
	{
		return "Facebookã§ã‚µã‚¤ãƒ³ã‚¤ãƒ³ã—ã¦ã„ã‚‹å ´åˆã«ã¯ã€ãƒ‘ã‚¹ãƒ¯ãƒ¼ãƒ‰ã®è¨­å®šãŒå¿…è¦ã§ã™ã€‚";
	}

	protected override string _GetTemplateForLabelForgotUsernamePassword()
	{
		return "ãƒ¦ãƒ¼ã‚¶ãƒ¼ãƒãƒ¼ãƒ ã‹ãƒ‘ã‚¹ãƒ¯ãƒ¼ãƒ‰ã‚’ãŠå¿˜ã‚Œã§ã™ã‹ï¼Ÿ";
	}

	/// <summary>
	/// Key: "Label.GreetingForNewAccount"
	/// Shown when a username doesn't exist on the login page to invite to create a new account.
	/// English String: "Nice to meet you, {username}. {linkStartSignup}Let's make an account! {linkEndSignup}"
	/// </summary>
	public override string LabelGreetingForNewAccount(string username, string linkStartSignup, string linkEndSignup)
	{
		return $"ã¯ã˜ã‚ã¾ã—ã¦ã€ {username}ã•ã‚“ã€‚ {linkStartSignup}ã‚¢ã‚«ã‚¦ãƒ³ãƒˆã‚’ä½œã‚Šã¾ã—ã‚‡ã†! {linkEndSignup}";
	}

	protected override string _GetTemplateForLabelGreetingForNewAccount()
	{
		return "ã¯ã˜ã‚ã¾ã—ã¦ã€ {username}ã•ã‚“ã€‚ {linkStartSignup}ã‚¢ã‚«ã‚¦ãƒ³ãƒˆã‚’ä½œã‚Šã¾ã—ã‚‡ã†! {linkEndSignup}";
	}

	protected override string _GetTemplateForLabelLearnMore()
	{
		return "è©³ã—ãçŸ¥ã‚‹";
	}

	protected override string _GetTemplateForLabelLoggingInSpinnerText()
	{
		return "ãƒ­ã‚°ã‚¤ãƒ³ä¸­â€¦";
	}

	protected override string _GetTemplateForLabelLogin()
	{
		return "ãƒ­ã‚°ã‚¤ãƒ³";
	}

	protected override string _GetTemplateForLabelLoginWithYour()
	{
		return "ä»¥ä¸‹ã§ãƒ­ã‚°ã‚¤ãƒ³ã—ã¦ãã ã•ã„";
	}

	protected override string _GetTemplateForLabelNoAccount()
	{
		return "ã‚¢ã‚«ã‚¦ãƒ³ãƒˆã‚’ãŠæŒã¡ã§ã¯ã‚ã‚Šã¾ã›ã‚“ã‹ï¼Ÿ";
	}

	protected override string _GetTemplateForLabelNonAMemberQuestion()
	{
		return "ãƒ¡ãƒ³ãƒãƒ¼ã§ã¯ã‚ã‚Šã¾ã›ã‚“ã‹ï¼Ÿ";
	}

	protected override string _GetTemplateForLabelNotReceived()
	{
		return "å—ä¿¡ã§ãã¾ã›ã‚“ã§ã—ãŸã‹ï¼Ÿ";
	}

	protected override string _GetTemplateForLabelOr()
	{
		return "ã¾ãŸã¯";
	}

	protected override string _GetTemplateForLabelPassword()
	{
		return "ãƒ‘ã‚¹ãƒ¯ãƒ¼ãƒ‰";
	}

	protected override string _GetTemplateForLabelPasswordWithColumn()
	{
		return "ãƒ‘ã‚¹ãƒ¯ãƒ¼ãƒ‰ï¼š";
	}

	protected override string _GetTemplateForLabelStartPlaying()
	{
		return "ã‚²ã‚¹ãƒˆãƒ¢ãƒ¼ãƒ‰ã§ä»Šã™ããƒ—ãƒ¬ã‚¤ã§ãã¾ã™ï¼";
	}

	protected override string _GetTemplateForLabelUnverifiedEmailInstructions()
	{
		return "ãƒ¡ãƒ¼ãƒ«ã‚¢ãƒ‰ãƒ¬ã‚¹ã§ãƒ­ã‚°ã‚¤ãƒ³ã™ã‚‹ãŸã‚ã«ã¯ã€ã¾ãšèªè¨¼ãŒå¿…è¦ã§ã™ã€‚ãƒ¦ãƒ¼ã‚¶ãƒ¼ãƒãƒ¼ãƒ ã§ãƒ­ã‚°ã‚¤ãƒ³ã™ã‚‹ã“ã¨ã‚‚ã§ãã¾ã™ã€‚";
	}

	protected override string _GetTemplateForLabelUsername()
	{
		return "ãƒ¦ãƒ¼ã‚¶ãƒ¼ãƒãƒ¼ãƒ ";
	}

	protected override string _GetTemplateForLabelUsernameEmail()
	{
		return "ãƒ¦ãƒ¼ã‚¶ãƒ¼ãƒãƒ¼ãƒ /ãƒ¡ãƒ¼ãƒ«ã‚¢ãƒ‰ãƒ¬ã‚¹";
	}

	protected override string _GetTemplateForLabelUsernameEmailPhone()
	{
		return "ãƒ¦ãƒ¼ã‚¶ãƒ¼ãƒãƒ¼ãƒ /ãƒ¡ãƒ¼ãƒ«ã‚¢ãƒ‰ãƒ¬ã‚¹/é›»è©±ç•ªå·";
	}

	protected override string _GetTemplateForLabelUsernamePhone()
	{
		return "ãƒ¦ãƒ¼ã‚¶ãƒ¼ãƒãƒ¼ãƒ /é›»è©±ç•ªå·";
	}

	protected override string _GetTemplateForLabelUsernameWithColumn()
	{
		return "ãƒ¦ãƒ¼ã‚¶ãƒ¼ãƒãƒ¼ãƒ :";
	}

	protected override string _GetTemplateForLabelVerificationEmailSent()
	{
		return "ç¢ºèªãƒ¡ãƒ¼ãƒ«ãŒé€ä¿¡ã•ã‚Œã¾ã—ãŸï¼";
	}

	protected override string _GetTemplateForLabelWeChatAntiAddictionText()
	{
		return "ä¸é©åˆ‡ãªã‚²ãƒ¼ãƒ ã«ã¯å‚åŠ ã—ãªã„ã‚ˆã†ã«å¿ƒæŽ›ã‘ã€æµ·è³Šç‰ˆã¯æ‹’å¦ã—ã¾ã—ã‚‡ã†ã€‚è‡ªè¡›æ„è­˜ã‚’é«˜ã‚ã€é¨™ã•ã‚Œãªã„ã‚ˆã†ã«ã—ã¾ã—ã‚‡ã†ã€‚ã‚²ãƒ¼ãƒ ã‚’ãƒ—ãƒ¬ã‚¤ã™ã‚‹ã“ã¨ã¯è„³ã®åƒãã‚’é«˜ã‚ã¦ãã‚Œã¾ã™ãŒã€ãƒ—ãƒ¬ã‚¤ã—ã™ãŽã‚‹ã¨å¥åº·ã‚’å®³ã™ã‚‹æã‚ŒãŒã‚ã‚Šã¾ã™ã€‚æ™‚é–“ç®¡ç†ã‚’ãã¡ã‚“ã¨è¡Œã„ã€å¥åº·çš„ãªãƒ©ã‚¤ãƒ•ã‚¹ã‚¿ã‚¤ãƒ«ã‚’ãŠæ¥½ã—ã¿ãã ã•ã„ã€‚";
	}

	protected override string _GetTemplateForMessageUnknownErrorTryAgain()
	{
		return "ä¸æ˜Žãªã‚¨ãƒ©ãƒ¼ãŒç™ºç”Ÿã—ã¾ã—ãŸã€‚ã‚‚ã†ä¸€åº¦ãŠè©¦ã—ãã ã•ã„ã€‚";
	}

	protected override string _GetTemplateForMessageUsernameAndPasswordRequired()
	{
		return "ãƒ¦ãƒ¼ã‚¶ãƒ¼ãƒãƒ¼ãƒ ã¨ãƒ‘ã‚¹ãƒ¯ãƒ¼ãƒ‰ãŒå¿…è¦ã§ã™";
	}

	protected override string _GetTemplateForResponseAccountIssueErrorContactSupport()
	{
		return "ã‚¢ã‚«ã‚¦ãƒ³ãƒˆã«é–¢ã™ã‚‹å•é¡ŒãŒç™ºç”Ÿã—ã¾ã—ãŸã€‚ã‚µãƒãƒ¼ãƒˆã«ãŠå•ã„åˆã‚ã›ãã ã•ã„ã€‚";
	}

	protected override string _GetTemplateForResponseAccountLockedRequestReset()
	{
		return "ã‚¢ã‚«ã‚¦ãƒ³ãƒˆãŒãƒ­ãƒƒã‚¯ã•ã‚Œã¦ã„ã¾ã™ã€‚ãƒ‘ã‚¹ãƒ¯ãƒ¼ãƒ‰ãƒªã‚»ãƒƒãƒˆã‚’ãƒªã‚¯ã‚¨ã‚¹ãƒˆã—ã¦ãã ã•ã„ã€‚";
	}

	protected override string _GetTemplateForResponseAccountNotFound()
	{
		return "ã‚¢ã‚«ã‚¦ãƒ³ãƒˆãŒè¦‹ã¤ã‹ã‚Šã¾ã›ã‚“ã§ã—ãŸã€‚ã‚‚ã†ä¸€åº¦ãŠè©¦ã—ãã ã•ã„ã€‚";
	}

	protected override string _GetTemplateForResponseEmailLinkedToMultipleAccountsLoginWithUsername()
	{
		return "ãƒ¡ãƒ¼ãƒ«ã‚¢ãƒ‰ãƒ¬ã‚¹ãŒè¤‡æ•°ã®ãƒ¦ãƒ¼ã‚¶ãƒ¼ãƒãƒ¼ãƒ ã«é–¢é€£ä»˜ã‘ã‚‰ã‚Œã¦ã„ã¾ã™ã€‚ãƒ¦ãƒ¼ã‚¶ãƒ¼ãƒãƒ¼ãƒ ã§ãƒ­ã‚°ã‚¤ãƒ³ã—ã¦ãã ã•ã„ã€‚";
	}

	protected override string _GetTemplateForResponseEmailSent()
	{
		return "ãƒ¡ãƒ¼ãƒ«ãŒé€ä¿¡ã•ã‚Œã¾ã—ãŸï¼";
	}

	protected override string _GetTemplateForResponseIncorrectEmailOrPassword()
	{
		return "ãƒ¡ãƒ¼ãƒ«ã‚¢ãƒ‰ãƒ¬ã‚¹ã¾ãŸã¯ãƒ‘ã‚¹ãƒ¯ãƒ¼ãƒ‰ãŒé–“é•ã£ã¦ã„ã¾ã™ã€‚";
	}

	protected override string _GetTemplateForResponseIncorrectPhoneOrPassword()
	{
		return "é›»è©±ç•ªå·ã¾ãŸã¯ãƒ‘ã‚¹ãƒ¯ãƒ¼ãƒ‰ãŒé–“é•ã£ã¦ã„ã¾ã™ã€‚";
	}

	protected override string _GetTemplateForResponseIncorrectUsernamePassword()
	{
		return "ãƒ¦ãƒ¼ã‚¶ãƒ¼ãƒãƒ¼ãƒ ã€ã¾ãŸã¯ãƒ‘ã‚¹ãƒ¯ãƒ¼ãƒ‰ãŒé–“é•ã£ã¦ã„ã¾ã™ã€‚";
	}

	protected override string _GetTemplateForResponseLoginWithUsername()
	{
		return "ä½•ã‚‰ã‹ã®å•é¡ŒãŒç™ºç”Ÿã—ã¾ã—ãŸã€‚ã‚‚ã†ä¸€åº¦ãŠè©¦ã—ãã ã•ã„ã€‚";
	}

	protected override string _GetTemplateForResponsePasswordNotProvided()
	{
		return "ãƒ‘ã‚¹ãƒ¯ãƒ¼ãƒ‰ã¯å¿…é ˆã§ã™ã€‚";
	}

	protected override string _GetTemplateForResponseTooManyAttemptsPleaseWait()
	{
		return "è©¦è¡Œå›žæ•°ãŒå¤šã™ãŽã¾ã™ã€‚ã—ã°ã‚‰ãã—ã¦ã‹ã‚‰ã‚„ã‚Šç›´ã—ã¦ãã ã•ã„ã€‚";
	}

	protected override string _GetTemplateForResponseUnknownError()
	{
		return "ä¸æ˜Žãªã‚¨ãƒ©ãƒ¼ãŒç™ºç”Ÿã—ã¾ã—ãŸ";
	}

	protected override string _GetTemplateForResponseUnknownLoginError()
	{
		return "ä¸æ˜Žãªãƒ­ã‚°ã‚¤ãƒ³ã®å¤±æ•—ã€‚";
	}

	protected override string _GetTemplateForResponseUnverifiedEmailLoginWithUsername()
	{
		return "ãƒ¡ãƒ¼ãƒ«ã‚¢ãƒ‰ãƒ¬ã‚¹ãŒèªè¨¼ã•ã‚Œã¦ã„ã¾ã›ã‚“ã€‚ãƒ¦ãƒ¼ã‚¶ãƒ¼ãƒãƒ¼ãƒ ã§ãƒ­ã‚°ã‚¤ãƒ³ã—ã¦ãã ã•ã„ã€‚";
	}

	protected override string _GetTemplateForResponseUnverifiedPhoneLoginWithUsername()
	{
		return "é›»è©±ç•ªå·ãŒèªè¨¼ã•ã‚Œã¦ã„ã¾ã›ã‚“ã€‚ãƒ¦ãƒ¼ã‚¶ãƒ¼ãƒãƒ¼ãƒ ã§ãƒ­ã‚°ã‚¤ãƒ³ã—ã¦ãã ã•ã„ã€‚";
	}

	protected override string _GetTemplateForResponseUsernameNotProvided()
	{
		return "ãƒ¦ãƒ¼ã‚¶ãƒ¼ãƒãƒ¼ãƒ ã¯å¿…é ˆã§ã™ã€‚";
	}

	protected override string _GetTemplateForResponseUseSocialSignOn()
	{
		return "ãƒ­ã‚°ã‚¤ãƒ³ã§ãã¾ã›ã‚“ã§ã—ãŸã€‚ã‚½ãƒ¼ã‚·ãƒ£ãƒ«ãƒãƒƒãƒˆãƒ¯ãƒ¼ã‚¯ãƒ»ã‚µã‚¤ãƒ³ã‚ªãƒ³ã‚’ã”åˆ©ç”¨ãã ã•ã„ã€‚";
	}

	/// <summary>
	/// Key: "Response.WeChatNotRealNameVerified"
	/// English String: "Your WeChat is not real-name verified. Please use a real-name verified WeChat account and try again. Please visit {url}"
	/// </summary>
	public override string ResponseWeChatNotRealNameVerified(string url)
	{
		return $"WeChatã§ã€æœ¬åã®èªè¨¼ãŒè¡Œã‚ã‚Œã¦ã„ã¾ã›ã‚“ã€‚æœ¬åã®èªè¨¼ã‚’è¡Œã£ãŸWeChatã‚¢ã‚«ã‚¦ãƒ³ãƒˆã‚’ä½¿ç”¨ã—ã¦ã‚„ã‚Šç›´ã—ã¦ãã ã•ã„ã€‚ {url} ã«ã‚¢ã‚¯ã‚»ã‚¹ã—ã¦ãã ã•ã„ã€‚";
	}

	protected override string _GetTemplateForResponseWeChatNotRealNameVerified()
	{
		return "WeChatã§ã€æœ¬åã®èªè¨¼ãŒè¡Œã‚ã‚Œã¦ã„ã¾ã›ã‚“ã€‚æœ¬åã®èªè¨¼ã‚’è¡Œã£ãŸWeChatã‚¢ã‚«ã‚¦ãƒ³ãƒˆã‚’ä½¿ç”¨ã—ã¦ã‚„ã‚Šç›´ã—ã¦ãã ã•ã„ã€‚ {url} ã«ã‚¢ã‚¯ã‚»ã‚¹ã—ã¦ãã ã•ã„ã€‚";
	}

	protected override string _GetTemplateForWeChatAntiAddictionText()
	{
		return "ä¸é©åˆ‡ãªã‚²ãƒ¼ãƒ ã«ã¯å‚åŠ ã—ãªã„ã‚ˆã†ã«å¿ƒæŽ›ã‘ã€æµ·è³Šç‰ˆã¯æ‹’å¦ã—ã¾ã—ã‚‡ã†ã€‚è‡ªè¡›æ„è­˜ã‚’é«˜ã‚ã€é¨™ã•ã‚Œãªã„ã‚ˆã†ã«ã—ã¾ã—ã‚‡ã†ã€‚ã‚²ãƒ¼ãƒ ã‚’ãƒ—ãƒ¬ã‚¤ã™ã‚‹ã“ã¨ã¯è„³ã®åƒãã‚’é«˜ã‚ã¦ãã‚Œã¾ã™ãŒã€ãƒ—ãƒ¬ã‚¤ã—ã™ãŽã‚‹ã¨å¥åº·ã‚’å®³ã™ã‚‹æã‚ŒãŒã‚ã‚Šã¾ã™ã€‚æ™‚é–“ç®¡ç†ã‚’ãã¡ã‚“ã¨è¡Œã„ã€å¥åº·çš„ãªãƒ©ã‚¤ãƒ•ã‚¹ã‚¿ã‚¤ãƒ«ã‚’ãŠæ¥½ã—ã¿ãã ã•ã„ã€‚";
	}

	protected override string _GetTemplateForWeChatRealNameNotVerified()
	{
		return "WeChatã§ã€æœ¬åã®èªè¨¼ãŒè¡Œã‚ã‚Œã¦ã„ã¾ã›ã‚“ã€‚æœ¬åã®èªè¨¼ã‚’è¡Œã£ãŸWeChatã‚¢ã‚«ã‚¦ãƒ³ãƒˆã‚’ä½¿ç”¨ã—ã¦ã‚„ã‚Šç›´ã—ã¦ãã ã•ã„ã€‚https://jiazhang.qq.com/zk/home.html ã«ã‚¢ã‚¯ã‚»ã‚¹ã—ã¦ãã ã•ã„ã€‚";
	}
}


}
