namespace Roblox.Platform.TranslationResources.Authentication {
    /// <summary>

/// This class overrides LoginResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class LoginResources_zh_tw : LoginResources_en_us, ILoginResources, ITranslationResources
{
	/// <summary>
	/// Key: "Action.Cancel"
	/// Cancel button text
	/// English String: "Cancel"
	/// </summary>
	public override string ActionCancel => "å–æ¶ˆ";

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
	public override string ActionForgotPasswordOrUsernameQuestion => "å¿˜è¨˜å¯†ç¢¼æˆ–ä½¿ç”¨è€…åç¨±ï¼Ÿ";

	/// <summary>
	/// Key: "Action.ForgotPasswordOrUsernameQuestionCapitalized"
	/// link under login form
	/// English String: "Forgot Password or Username?"
	/// </summary>
	public override string ActionForgotPasswordOrUsernameQuestionCapitalized => "å¿˜è¨˜å¯†ç¢¼æˆ–ä½¿ç”¨è€…åç¨±ï¼Ÿ";

	/// <summary>
	/// Key: "Action.Login"
	/// English String: "Login"
	/// </summary>
	public override string ActionLogin => "ç™»å…¥";

	/// <summary>
	/// Key: "Action.LogInCapitalized"
	/// login button label. please note this is different from 'Login' or 'Log in'.
	/// English String: "Log In"
	/// </summary>
	public override string ActionLogInCapitalized => "ç™»å…¥";

	/// <summary>
	/// Key: "Action.Ok"
	/// button text
	/// English String: "OK"
	/// </summary>
	public override string ActionOk => "ç¢ºå®š";

	/// <summary>
	/// Key: "Action.PlayAsGuest"
	/// Play as Guest
	/// English String: "Play as Guest"
	/// </summary>
	public override string ActionPlayAsGuest => "ä»¥è¨ªå®¢èº«åˆ†éŠçŽ©";

	/// <summary>
	/// Key: "Action.Resend"
	/// button text for resending verification email
	/// English String: "Resend"
	/// </summary>
	public override string ActionResend => "é‡æ–°å‚³é€";

	/// <summary>
	/// Key: "Action.ResendEmail"
	/// link that resends verification email to user
	/// English String: "Resend Email"
	/// </summary>
	public override string ActionResendEmail => "é‡æ–°å‚³é€é›»å­éƒµä»¶";

	/// <summary>
	/// Key: "Action.SendVerificationEmail"
	/// button user can click to send a verification link to their email
	/// English String: "Send Verification Email"
	/// </summary>
	public override string ActionSendVerificationEmail => "å‚³é€é©—è­‰é›»å­éƒµä»¶";

	/// <summary>
	/// Key: "Action.SignIn"
	/// Sign In button text
	/// English String: "Sign In"
	/// </summary>
	public override string ActionSignIn => "ç™»å…¥";

	/// <summary>
	/// Key: "Action.SignInWithFacebook"
	/// Sign In with Facebook
	/// English String: "Sign In with Facebook"
	/// </summary>
	public override string ActionSignInWithFacebook => "ä»¥ Facebook ç™»å…¥";

	/// <summary>
	/// Key: "Action.SignUp"
	/// English String: "Sign up"
	/// </summary>
	public override string ActionSignUp => "è¨»å†Š";

	/// <summary>
	/// Key: "Action.SignUpCapitalized"
	/// link which takes user to sign up page
	/// English String: "Sign Up"
	/// </summary>
	public override string ActionSignUpCapitalized => "è¨»å†Š";

	/// <summary>
	/// Key: "Action.WeChatLogin"
	/// button text for logging in with WeChat
	/// English String: "WeChat Login"
	/// </summary>
	public override string ActionWeChatLogin => "å¾®ä¿¡ç™»å…¥";

	/// <summary>
	/// Key: "Heading.Login"
	/// heading on the login page
	/// English String: "Login"
	/// </summary>
	public override string HeadingLogin => "ç™»å…¥";

	/// <summary>
	/// Key: "Heading.LoginRoblox"
	/// current login page heading
	/// English String: "Login to Roblox"
	/// </summary>
	public override string HeadingLoginRoblox => "ç™»å…¥ Roblox";

	public override string HeadingSignUpMakeFriends => "è¨»å†Šå¸³è™Ÿï¼Œé–‹å§‹äº¤å‹å’Œå‰µä½œ";

	/// <summary>
	/// Key: "Label.AccountNotNeeded"
	/// You don't need an account to play Roblox
	/// English String: "You don't need an account to play Roblox"
	/// </summary>
	public override string LabelAccountNotNeeded => "çŽ© Roblox ä¸éœ€è¦è¨»å†Šå¸³è™Ÿ";

	/// <summary>
	/// Key: "Label.EmailNeedsVerification"
	/// modal header used for prompting user they need to verify their email in order to log in with it
	/// English String: "Your email needs verification"
	/// </summary>
	public override string LabelEmailNeedsVerification => "æ‚¨çš„é›»å­éƒµä»¶åœ°å€éœ€è¦é©—è­‰";

	/// <summary>
	/// Key: "Label.FacebookCreatePasswordWarning"
	/// If you have been signing in with Facebook, you must set a password.
	/// English String: "If you have been signing in with Facebook, you must set a password."
	/// </summary>
	public override string LabelFacebookCreatePasswordWarning => "è‹¥æ‚¨ä»¥ Facebook ç™»å…¥ï¼Œè«‹è¨­å®šå¯†ç¢¼ã€‚";

	/// <summary>
	/// Key: "Label.ForgotUsernamePassword"
	/// landing page top right link for password reset
	/// English String: "Forgot Username/Password?"
	/// </summary>
	public override string LabelForgotUsernamePassword => "å¿˜è¨˜ä½¿ç”¨è€…åç¨±æˆ–å¯†ç¢¼ï¼Ÿ";

	/// <summary>
	/// Key: "Label.LearnMore"
	/// learn more link text
	/// English String: "Learn more"
	/// </summary>
	public override string LabelLearnMore => "äº†è§£æ›´å¤š";

	/// <summary>
	/// Key: "Label.LoggingInSpinnerText"
	/// English String: "Logging inâ€¦"
	/// </summary>
	public override string LabelLoggingInSpinnerText => "æ­£åœ¨ç™»å…¥â€¦";

	/// <summary>
	/// Key: "Label.Login"
	/// English String: "Log in"
	/// </summary>
	public override string LabelLogin => "ç™»å…¥";

	/// <summary>
	/// Key: "Label.LoginWithYour"
	/// Label for a partition line between login with email and facebook login. Please keep the text in lowercase for roman characters.
	/// English String: "login with your"
	/// </summary>
	public override string LabelLoginWithYour => "ç™»å…¥æ–¹æ³•ï¼š";

	/// <summary>
	/// Key: "Label.NoAccount"
	/// Don't have an account?
	/// English String: "Don't have an account?"
	/// </summary>
	public override string LabelNoAccount => "æ²’æœ‰å¸³è™Ÿï¼Ÿ";

	/// <summary>
	/// Key: "Label.NonAMemberQuestion"
	/// The question heading for the section on the login page to take use to sign up page.
	/// English String: "Not a member?"
	/// </summary>
	public override string LabelNonAMemberQuestion => "ä¸æ˜¯æœƒå“¡ï¼Ÿ";

	/// <summary>
	/// Key: "Label.NotReceived"
	/// prompt for allowing users to resend verification email
	/// English String: "Didn't receive it?"
	/// </summary>
	public override string LabelNotReceived => "æ²’æœ‰æ”¶åˆ°ï¼Ÿ";

	/// <summary>
	/// Key: "Label.Or"
	/// partition between email login and facebook login
	/// English String: "Or"
	/// </summary>
	public override string LabelOr => "æˆ–";

	/// <summary>
	/// Key: "Label.Password"
	/// Password
	/// English String: "Password"
	/// </summary>
	public override string LabelPassword => "å¯†ç¢¼";

	/// <summary>
	/// Key: "Label.PasswordWithColumn"
	/// label for the password field on the login page
	/// English String: "Password:"
	/// </summary>
	public override string LabelPasswordWithColumn => "å¯†ç¢¼ï¼š";

	/// <summary>
	/// Key: "Label.StartPlaying"
	/// You can start playing right now, in guest mode!
	/// English String: "You can start playing right now, in guest mode!"
	/// </summary>
	public override string LabelStartPlaying => "ç¾åœ¨ä»¥è¨ªå®¢æ¨¡å¼éŠçŽ©ï¼";

	/// <summary>
	/// Key: "Label.UnverifiedEmailInstructions"
	/// message shown in a modal when user logs in with unverified email
	/// English String: "To log in with your email, it must be verified. You can also log in with your username."
	/// </summary>
	public override string LabelUnverifiedEmailInstructions => "è‹¥è¦ä»¥æ‚¨çš„é›»å­éƒµä»¶åœ°å€ç™»å…¥ï¼Œè«‹å…ˆé©—è­‰é›»å­éƒµä»¶åœ°å€ã€‚æ‚¨ä¹Ÿèƒ½ä»¥ä½¿ç”¨è€…åç¨±ç™»å…¥ã€‚";

	/// <summary>
	/// Key: "Label.Username"
	/// English String: "Username"
	/// </summary>
	public override string LabelUsername => "ä½¿ç”¨è€…åç¨±";

	/// <summary>
	/// Key: "Label.UsernameEmail"
	/// placeholder text for input field that accepts username or email
	/// English String: "Username/Email"
	/// </summary>
	public override string LabelUsernameEmail => "ä½¿ç”¨è€…åç¨±ï¼é›»å­éƒµä»¶åœ°å€";

	/// <summary>
	/// Key: "Label.UsernameEmailPhone"
	/// placeholder text for input fields that accept username, email or phone
	/// English String: "Username/Email/Phone"
	/// </summary>
	public override string LabelUsernameEmailPhone => "ä½¿ç”¨è€…åç¨±ï¼é›»å­éƒµä»¶åœ°å€ï¼æ‰‹æ©Ÿè™Ÿç¢¼";

	/// <summary>
	/// Key: "Label.UsernamePhone"
	/// placeholder text for input field that accepts username or phone
	/// English String: "Username/Phone"
	/// </summary>
	public override string LabelUsernamePhone => "ä½¿ç”¨è€…åç¨±ï¼æ‰‹æ©Ÿè™Ÿç¢¼";

	/// <summary>
	/// Key: "Label.UsernameWithColumn"
	/// label for username field on login page
	/// English String: "Username:"
	/// </summary>
	public override string LabelUsernameWithColumn => "ä½¿ç”¨è€…åç¨±ï¼š";

	/// <summary>
	/// Key: "Label.VerificationEmailSent"
	/// message telling user a verification email was sent to them
	/// English String: "Verification Email Sent!"
	/// </summary>
	public override string LabelVerificationEmailSent => "é©—è­‰é›»å­éƒµä»¶å·²å‚³é€ï¼";

	/// <summary>
	/// Key: "Label.WeChatAntiAddictionText"
	/// English String: "Boycott bad games, refuse pirated games. Be aware of self-defense and being deceived. Playing games is good for your brain, but too much game play can harm your health. Manage your time well and enjoy a healthy lifestyle."
	/// </summary>
	public override string LabelWeChatAntiAddictionText => "æŠµåˆ¶åŠ£è³ªèˆ‡æŠ„è¥²éŠæˆ²ï¼çŽ©éŠæˆ²æœ‰ç›Šèº«å¿ƒï¼Œä½†éŽåº¦æ²‰è¿·æœƒå°èº«é«”é€ æˆå½±éŸ¿ã€‚æŽ§åˆ¶éŠæˆ²æ™‚é–“ï¼Œäº«å—å¥åº·äººç”Ÿï¼";

	/// <summary>
	/// Key: "Message.UnknownErrorTryAgain"
	/// An unknown error occurred. Please try again.
	/// English String: "An unknown error occurred. Please try again."
	/// </summary>
	public override string MessageUnknownErrorTryAgain => "ç™¼ç”ŸæœªçŸ¥éŒ¯èª¤ã€‚è«‹é‡æ–°å˜—è©¦ã€‚";

	/// <summary>
	/// Key: "Message.UsernameAndPasswordRequired"
	/// message shown to user when they attempt to login without entering a username or password
	/// English String: "Username and password required"
	/// </summary>
	public override string MessageUsernameAndPasswordRequired => "ä½¿ç”¨è€…åç¨±æˆ–å¯†ç¢¼ç©ºç™½";

	/// <summary>
	/// Key: "Response.AccountIssueErrorContactSupport"
	/// English String: "Account issue. Please contact Support."
	/// </summary>
	public override string ResponseAccountIssueErrorContactSupport => "å¸³è™Ÿç™¼ç”Ÿå•é¡Œï¼Œè«‹è¯çµ¡å®¢æœäººå“¡ã€‚";

	/// <summary>
	/// Key: "Response.AccountLockedRequestReset"
	/// Account has been locked. Please request a password reset.
	/// English String: "Account has been locked. Please request a password reset."
	/// </summary>
	public override string ResponseAccountLockedRequestReset => "å¸³è™Ÿå·²é­éŽ–å®šï¼Œè«‹é€²è¡Œå¯†ç¢¼é‡ç½®ã€‚";

	/// <summary>
	/// Key: "Response.AccountNotFound"
	/// Account not found. Please try again.
	/// English String: "Account not found. Please try again."
	/// </summary>
	public override string ResponseAccountNotFound => "æ‰¾ä¸åˆ°å¸³è™Ÿï¼Œè«‹é‡æ–°å˜—è©¦ã€‚";

	/// <summary>
	/// Key: "Response.EmailLinkedToMultipleAccountsLoginWithUsername"
	/// error message displayed when user attempts to log in with an email that is linked to multiple accounts
	/// English String: "Your email is associated with more than 1 username. Please login with your username."
	/// </summary>
	public override string ResponseEmailLinkedToMultipleAccountsLoginWithUsername => "æœ‰å¤šçµ„å¸³è™ŸåŠ å…¥æ­¤é›»å­éƒµä»¶åœ°å€ï¼Œè«‹ä»¥æ‚¨çš„ä½¿ç”¨è€…åç¨±ç™»å…¥ã€‚";

	/// <summary>
	/// Key: "Response.EmailSent"
	/// response telling user that a verification email has been sent to them
	/// English String: "Email sent!"
	/// </summary>
	public override string ResponseEmailSent => "é©—è­‰éƒµä»¶å·²å‚³é€ï¼";

	/// <summary>
	/// Key: "Response.IncorrectEmailOrPassword"
	/// error message displayed when user logs in with an invalid email or password
	/// English String: "Incorrect email or password."
	/// </summary>
	public override string ResponseIncorrectEmailOrPassword => "é›»å­éƒµä»¶æˆ–å¯†ç¢¼ä¸æ­£ç¢ºã€‚";

	/// <summary>
	/// Key: "Response.IncorrectPhoneOrPassword"
	/// error message displayed when user logs in with an invalid phone or password
	/// English String: "Incorrect phone or password."
	/// </summary>
	public override string ResponseIncorrectPhoneOrPassword => "æ‰‹æ©Ÿæˆ–å¯†ç¢¼ä¸æ­£ç¢ºã€‚";

	/// <summary>
	/// Key: "Response.IncorrectUsernamePassword"
	/// English String: "Incorrect username or password."
	/// </summary>
	public override string ResponseIncorrectUsernamePassword => "ä½¿ç”¨è€…åç¨±æˆ–å¯†ç¢¼ä¸æ­£ç¢ºã€‚";

	/// <summary>
	/// Key: "Response.LoginWithUsername"
	/// error message shown when user attempts to login with method other than username and an error occurred
	/// English String: "Something went wrong. Please login with your username."
	/// </summary>
	public override string ResponseLoginWithUsername => "ç™¼ç”ŸéŒ¯èª¤ï¼Œè«‹ä»¥æ‚¨çš„ä½¿ç”¨è€…åç¨±ç™»å…¥ã€‚";

	/// <summary>
	/// Key: "Response.PasswordNotProvided"
	/// password field is empty
	/// English String: "You must enter a password."
	/// </summary>
	public override string ResponsePasswordNotProvided => "å¿…é ˆè¼¸å…¥å¯†ç¢¼ã€‚";

	/// <summary>
	/// Key: "Response.TooManyAttemptsPleaseWait"
	/// English String: "Too many attempts. Please wait a bit."
	/// </summary>
	public override string ResponseTooManyAttemptsPleaseWait => "å˜—è©¦æ¬¡æ•¸éŽå¤šï¼Œè«‹ç¨å¾Œå†è©¦ã€‚";

	/// <summary>
	/// Key: "Response.UnknownError"
	/// English String: "Unknown Error"
	/// </summary>
	public override string ResponseUnknownError => "æœªçŸ¥éŒ¯èª¤";

	/// <summary>
	/// Key: "Response.UnknownLoginError"
	/// Unknown login failure.
	/// English String: "Unknown login failure."
	/// </summary>
	public override string ResponseUnknownLoginError => "ç™»å…¥æ™‚ç™¼ç”ŸæœªçŸ¥éŒ¯èª¤ã€‚";

	/// <summary>
	/// Key: "Response.UnverifiedEmailLoginWithUsername"
	/// error message shown when user attempts to login with unverified email
	/// English String: "Your email is not verified. Please login with your username."
	/// </summary>
	public override string ResponseUnverifiedEmailLoginWithUsername => "æ‚¨çš„é›»å­éƒµä»¶æœªé©—è­‰ï¼Œè«‹ä»¥æ‚¨çš„ä½¿ç”¨è€…åç¨±ç™»å…¥ã€‚";

	/// <summary>
	/// Key: "Response.UnverifiedPhoneLoginWithUsername"
	/// error message shown when user attempts to login with an unverified phone number
	/// English String: "Your phone is not verified. Please login with your username."
	/// </summary>
	public override string ResponseUnverifiedPhoneLoginWithUsername => "æ‚¨çš„æ‰‹æ©Ÿæœªé©—è­‰ï¼Œè«‹ä»¥æ‚¨çš„ä½¿ç”¨è€…åç¨±ç™»å…¥ã€‚";

	/// <summary>
	/// Key: "Response.UsernameNotProvided"
	/// username field is empty
	/// English String: "You must enter a username."
	/// </summary>
	public override string ResponseUsernameNotProvided => "å¿…é ˆè¼¸å…¥ä½¿ç”¨è€…åç¨±ã€‚";

	/// <summary>
	/// Key: "Response.UseSocialSignOn"
	/// Unable to login. Please use Social Network sign on.
	/// English String: "Unable to login. Please use Social Network sign on."
	/// </summary>
	public override string ResponseUseSocialSignOn => "ç„¡æ³•ç™»å…¥ï¼Œè«‹ä»¥ç¤¾äº¤ç¶²è·¯ç™»å…¥ã€‚";

	/// <summary>
	/// Key: "WeChat.AntiAddictionText"
	/// English String: "Boycott bad games, refuse pirated games. Be aware of self-defense and being deceived. Playing games is good for your brain, but too much game play can harm your health. Manage your time well and enjoy a healthy lifestyle."
	/// </summary>
	public override string WeChatAntiAddictionText => "æŠµåˆ¶åŠ£è³ªèˆ‡æŠ„è¥²éŠæˆ²ï¼çŽ©éŠæˆ²æœ‰ç›Šèº«å¿ƒï¼Œä½†éŽåº¦æ²‰è¿·æœƒå°èº«é«”é€ æˆå½±éŸ¿ã€‚æŽ§åˆ¶éŠæˆ²æ™‚é–“ï¼Œäº«å—å¥åº·äººç”Ÿï¼";

	/// <summary>
	/// Key: "WeChat.RealNameNotVerified"
	/// English String: "Your WeChat is not real-name verified. Please use a real-name verified WeChat account and try again. Please visit https://jiazhang.qq.com/zk/home.html"
	/// </summary>
	public override string WeChatRealNameNotVerified => "æ‚¨çš„å¾®ä¿¡å°šæœªé€²è¡Œå¯¦åèªè­‰ï¼Œè«‹é€²è¡Œå¯¦åèªè­‰å†é‡æ–°å˜—è©¦ã€‚è«‹å‰å¾€ https://jiazhang.qq.com/zk/home.html";

	public LoginResources_zh_tw(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionCancel()
	{
		return "å–æ¶ˆ";
	}

	protected override string _GetTemplateForActionFacebook()
	{
		return "Facebook";
	}

	protected override string _GetTemplateForActionForgotPasswordOrUsernameQuestion()
	{
		return "å¿˜è¨˜å¯†ç¢¼æˆ–ä½¿ç”¨è€…åç¨±ï¼Ÿ";
	}

	protected override string _GetTemplateForActionForgotPasswordOrUsernameQuestionCapitalized()
	{
		return "å¿˜è¨˜å¯†ç¢¼æˆ–ä½¿ç”¨è€…åç¨±ï¼Ÿ";
	}

	protected override string _GetTemplateForActionLogin()
	{
		return "ç™»å…¥";
	}

	protected override string _GetTemplateForActionLogInCapitalized()
	{
		return "ç™»å…¥";
	}

	protected override string _GetTemplateForActionOk()
	{
		return "ç¢ºå®š";
	}

	protected override string _GetTemplateForActionPlayAsGuest()
	{
		return "ä»¥è¨ªå®¢èº«åˆ†éŠçŽ©";
	}

	protected override string _GetTemplateForActionResend()
	{
		return "é‡æ–°å‚³é€";
	}

	protected override string _GetTemplateForActionResendEmail()
	{
		return "é‡æ–°å‚³é€é›»å­éƒµä»¶";
	}

	protected override string _GetTemplateForActionSendVerificationEmail()
	{
		return "å‚³é€é©—è­‰é›»å­éƒµä»¶";
	}

	protected override string _GetTemplateForActionSignIn()
	{
		return "ç™»å…¥";
	}

	protected override string _GetTemplateForActionSignInWithFacebook()
	{
		return "ä»¥ Facebook ç™»å…¥";
	}

	protected override string _GetTemplateForActionSignUp()
	{
		return "è¨»å†Š";
	}

	protected override string _GetTemplateForActionSignUpCapitalized()
	{
		return "è¨»å†Š";
	}

	protected override string _GetTemplateForActionWeChatLogin()
	{
		return "å¾®ä¿¡ç™»å…¥";
	}

	protected override string _GetTemplateForHeadingLogin()
	{
		return "ç™»å…¥";
	}

	protected override string _GetTemplateForHeadingLoginRoblox()
	{
		return "ç™»å…¥ Roblox";
	}

	protected override string _GetTemplateForHeadingSignUpMakeFriends()
	{
		return "è¨»å†Šå¸³è™Ÿï¼Œé–‹å§‹äº¤å‹å’Œå‰µä½œ";
	}

	protected override string _GetTemplateForLabelAccountNotNeeded()
	{
		return "çŽ© Roblox ä¸éœ€è¦è¨»å†Šå¸³è™Ÿ";
	}

	protected override string _GetTemplateForLabelEmailNeedsVerification()
	{
		return "æ‚¨çš„é›»å­éƒµä»¶åœ°å€éœ€è¦é©—è­‰";
	}

	protected override string _GetTemplateForLabelFacebookCreatePasswordWarning()
	{
		return "è‹¥æ‚¨ä»¥ Facebook ç™»å…¥ï¼Œè«‹è¨­å®šå¯†ç¢¼ã€‚";
	}

	protected override string _GetTemplateForLabelForgotUsernamePassword()
	{
		return "å¿˜è¨˜ä½¿ç”¨è€…åç¨±æˆ–å¯†ç¢¼ï¼Ÿ";
	}

	/// <summary>
	/// Key: "Label.GreetingForNewAccount"
	/// Shown when a username doesn't exist on the login page to invite to create a new account.
	/// English String: "Nice to meet you, {username}. {linkStartSignup}Let's make an account! {linkEndSignup}"
	/// </summary>
	public override string LabelGreetingForNewAccount(string username, string linkStartSignup, string linkEndSignup)
	{
		return $"æ‚¨å¥½ï¼Œ{username}ã€‚{linkStartSignup}ä¾†è¨»å†Šå¸³è™Ÿå§ï¼{linkEndSignup}";
	}

	protected override string _GetTemplateForLabelGreetingForNewAccount()
	{
		return "æ‚¨å¥½ï¼Œ{username}ã€‚{linkStartSignup}ä¾†è¨»å†Šå¸³è™Ÿå§ï¼{linkEndSignup}";
	}

	protected override string _GetTemplateForLabelLearnMore()
	{
		return "äº†è§£æ›´å¤š";
	}

	protected override string _GetTemplateForLabelLoggingInSpinnerText()
	{
		return "æ­£åœ¨ç™»å…¥â€¦";
	}

	protected override string _GetTemplateForLabelLogin()
	{
		return "ç™»å…¥";
	}

	protected override string _GetTemplateForLabelLoginWithYour()
	{
		return "ç™»å…¥æ–¹æ³•ï¼š";
	}

	protected override string _GetTemplateForLabelNoAccount()
	{
		return "æ²’æœ‰å¸³è™Ÿï¼Ÿ";
	}

	protected override string _GetTemplateForLabelNonAMemberQuestion()
	{
		return "ä¸æ˜¯æœƒå“¡ï¼Ÿ";
	}

	protected override string _GetTemplateForLabelNotReceived()
	{
		return "æ²’æœ‰æ”¶åˆ°ï¼Ÿ";
	}

	protected override string _GetTemplateForLabelOr()
	{
		return "æˆ–";
	}

	protected override string _GetTemplateForLabelPassword()
	{
		return "å¯†ç¢¼";
	}

	protected override string _GetTemplateForLabelPasswordWithColumn()
	{
		return "å¯†ç¢¼ï¼š";
	}

	protected override string _GetTemplateForLabelStartPlaying()
	{
		return "ç¾åœ¨ä»¥è¨ªå®¢æ¨¡å¼éŠçŽ©ï¼";
	}

	protected override string _GetTemplateForLabelUnverifiedEmailInstructions()
	{
		return "è‹¥è¦ä»¥æ‚¨çš„é›»å­éƒµä»¶åœ°å€ç™»å…¥ï¼Œè«‹å…ˆé©—è­‰é›»å­éƒµä»¶åœ°å€ã€‚æ‚¨ä¹Ÿèƒ½ä»¥ä½¿ç”¨è€…åç¨±ç™»å…¥ã€‚";
	}

	protected override string _GetTemplateForLabelUsername()
	{
		return "ä½¿ç”¨è€…åç¨±";
	}

	protected override string _GetTemplateForLabelUsernameEmail()
	{
		return "ä½¿ç”¨è€…åç¨±ï¼é›»å­éƒµä»¶åœ°å€";
	}

	protected override string _GetTemplateForLabelUsernameEmailPhone()
	{
		return "ä½¿ç”¨è€…åç¨±ï¼é›»å­éƒµä»¶åœ°å€ï¼æ‰‹æ©Ÿè™Ÿç¢¼";
	}

	protected override string _GetTemplateForLabelUsernamePhone()
	{
		return "ä½¿ç”¨è€…åç¨±ï¼æ‰‹æ©Ÿè™Ÿç¢¼";
	}

	protected override string _GetTemplateForLabelUsernameWithColumn()
	{
		return "ä½¿ç”¨è€…åç¨±ï¼š";
	}

	protected override string _GetTemplateForLabelVerificationEmailSent()
	{
		return "é©—è­‰é›»å­éƒµä»¶å·²å‚³é€ï¼";
	}

	protected override string _GetTemplateForLabelWeChatAntiAddictionText()
	{
		return "æŠµåˆ¶åŠ£è³ªèˆ‡æŠ„è¥²éŠæˆ²ï¼çŽ©éŠæˆ²æœ‰ç›Šèº«å¿ƒï¼Œä½†éŽåº¦æ²‰è¿·æœƒå°èº«é«”é€ æˆå½±éŸ¿ã€‚æŽ§åˆ¶éŠæˆ²æ™‚é–“ï¼Œäº«å—å¥åº·äººç”Ÿï¼";
	}

	protected override string _GetTemplateForMessageUnknownErrorTryAgain()
	{
		return "ç™¼ç”ŸæœªçŸ¥éŒ¯èª¤ã€‚è«‹é‡æ–°å˜—è©¦ã€‚";
	}

	protected override string _GetTemplateForMessageUsernameAndPasswordRequired()
	{
		return "ä½¿ç”¨è€…åç¨±æˆ–å¯†ç¢¼ç©ºç™½";
	}

	protected override string _GetTemplateForResponseAccountIssueErrorContactSupport()
	{
		return "å¸³è™Ÿç™¼ç”Ÿå•é¡Œï¼Œè«‹è¯çµ¡å®¢æœäººå“¡ã€‚";
	}

	protected override string _GetTemplateForResponseAccountLockedRequestReset()
	{
		return "å¸³è™Ÿå·²é­éŽ–å®šï¼Œè«‹é€²è¡Œå¯†ç¢¼é‡ç½®ã€‚";
	}

	protected override string _GetTemplateForResponseAccountNotFound()
	{
		return "æ‰¾ä¸åˆ°å¸³è™Ÿï¼Œè«‹é‡æ–°å˜—è©¦ã€‚";
	}

	protected override string _GetTemplateForResponseEmailLinkedToMultipleAccountsLoginWithUsername()
	{
		return "æœ‰å¤šçµ„å¸³è™ŸåŠ å…¥æ­¤é›»å­éƒµä»¶åœ°å€ï¼Œè«‹ä»¥æ‚¨çš„ä½¿ç”¨è€…åç¨±ç™»å…¥ã€‚";
	}

	protected override string _GetTemplateForResponseEmailSent()
	{
		return "é©—è­‰éƒµä»¶å·²å‚³é€ï¼";
	}

	protected override string _GetTemplateForResponseIncorrectEmailOrPassword()
	{
		return "é›»å­éƒµä»¶æˆ–å¯†ç¢¼ä¸æ­£ç¢ºã€‚";
	}

	protected override string _GetTemplateForResponseIncorrectPhoneOrPassword()
	{
		return "æ‰‹æ©Ÿæˆ–å¯†ç¢¼ä¸æ­£ç¢ºã€‚";
	}

	protected override string _GetTemplateForResponseIncorrectUsernamePassword()
	{
		return "ä½¿ç”¨è€…åç¨±æˆ–å¯†ç¢¼ä¸æ­£ç¢ºã€‚";
	}

	protected override string _GetTemplateForResponseLoginWithUsername()
	{
		return "ç™¼ç”ŸéŒ¯èª¤ï¼Œè«‹ä»¥æ‚¨çš„ä½¿ç”¨è€…åç¨±ç™»å…¥ã€‚";
	}

	protected override string _GetTemplateForResponsePasswordNotProvided()
	{
		return "å¿…é ˆè¼¸å…¥å¯†ç¢¼ã€‚";
	}

	protected override string _GetTemplateForResponseTooManyAttemptsPleaseWait()
	{
		return "å˜—è©¦æ¬¡æ•¸éŽå¤šï¼Œè«‹ç¨å¾Œå†è©¦ã€‚";
	}

	protected override string _GetTemplateForResponseUnknownError()
	{
		return "æœªçŸ¥éŒ¯èª¤";
	}

	protected override string _GetTemplateForResponseUnknownLoginError()
	{
		return "ç™»å…¥æ™‚ç™¼ç”ŸæœªçŸ¥éŒ¯èª¤ã€‚";
	}

	protected override string _GetTemplateForResponseUnverifiedEmailLoginWithUsername()
	{
		return "æ‚¨çš„é›»å­éƒµä»¶æœªé©—è­‰ï¼Œè«‹ä»¥æ‚¨çš„ä½¿ç”¨è€…åç¨±ç™»å…¥ã€‚";
	}

	protected override string _GetTemplateForResponseUnverifiedPhoneLoginWithUsername()
	{
		return "æ‚¨çš„æ‰‹æ©Ÿæœªé©—è­‰ï¼Œè«‹ä»¥æ‚¨çš„ä½¿ç”¨è€…åç¨±ç™»å…¥ã€‚";
	}

	protected override string _GetTemplateForResponseUsernameNotProvided()
	{
		return "å¿…é ˆè¼¸å…¥ä½¿ç”¨è€…åç¨±ã€‚";
	}

	protected override string _GetTemplateForResponseUseSocialSignOn()
	{
		return "ç„¡æ³•ç™»å…¥ï¼Œè«‹ä»¥ç¤¾äº¤ç¶²è·¯ç™»å…¥ã€‚";
	}

	/// <summary>
	/// Key: "Response.WeChatNotRealNameVerified"
	/// English String: "Your WeChat is not real-name verified. Please use a real-name verified WeChat account and try again. Please visit {url}"
	/// </summary>
	public override string ResponseWeChatNotRealNameVerified(string url)
	{
		return $"æ‚¨çš„å¾®ä¿¡å°šæœªé€²è¡Œå¯¦åèªè­‰ï¼Œè«‹é€²è¡Œå¯¦åèªè­‰å†é‡æ–°å˜—è©¦ã€‚è«‹å‰å¾€ {url}";
	}

	protected override string _GetTemplateForResponseWeChatNotRealNameVerified()
	{
		return "æ‚¨çš„å¾®ä¿¡å°šæœªé€²è¡Œå¯¦åèªè­‰ï¼Œè«‹é€²è¡Œå¯¦åèªè­‰å†é‡æ–°å˜—è©¦ã€‚è«‹å‰å¾€ {url}";
	}

	protected override string _GetTemplateForWeChatAntiAddictionText()
	{
		return "æŠµåˆ¶åŠ£è³ªèˆ‡æŠ„è¥²éŠæˆ²ï¼çŽ©éŠæˆ²æœ‰ç›Šèº«å¿ƒï¼Œä½†éŽåº¦æ²‰è¿·æœƒå°èº«é«”é€ æˆå½±éŸ¿ã€‚æŽ§åˆ¶éŠæˆ²æ™‚é–“ï¼Œäº«å—å¥åº·äººç”Ÿï¼";
	}

	protected override string _GetTemplateForWeChatRealNameNotVerified()
	{
		return "æ‚¨çš„å¾®ä¿¡å°šæœªé€²è¡Œå¯¦åèªè­‰ï¼Œè«‹é€²è¡Œå¯¦åèªè­‰å†é‡æ–°å˜—è©¦ã€‚è«‹å‰å¾€ https://jiazhang.qq.com/zk/home.html";
	}
}


}
