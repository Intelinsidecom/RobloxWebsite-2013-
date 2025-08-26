namespace Roblox.Platform.TranslationResources.Authentication {
    /// <summary>

/// This class overrides LoginResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class LoginResources_zh_cn : LoginResources_en_us, ILoginResources, ITranslationResources
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
	public override string ActionForgotPasswordOrUsernameQuestion => "å¿˜è®°å¯†ç æˆ–ç”¨æˆ·åï¼Ÿ";

	/// <summary>
	/// Key: "Action.ForgotPasswordOrUsernameQuestionCapitalized"
	/// link under login form
	/// English String: "Forgot Password or Username?"
	/// </summary>
	public override string ActionForgotPasswordOrUsernameQuestionCapitalized => "å¿˜è®°å¯†ç æˆ–ç”¨æˆ·åï¼Ÿ";

	/// <summary>
	/// Key: "Action.Login"
	/// English String: "Login"
	/// </summary>
	public override string ActionLogin => "ç™»å½•";

	/// <summary>
	/// Key: "Action.LogInCapitalized"
	/// login button label. please note this is different from 'Login' or 'Log in'.
	/// English String: "Log In"
	/// </summary>
	public override string ActionLogInCapitalized => "ç™»å½•";

	/// <summary>
	/// Key: "Action.Ok"
	/// button text
	/// English String: "OK"
	/// </summary>
	public override string ActionOk => "å¥½";

	/// <summary>
	/// Key: "Action.PlayAsGuest"
	/// Play as Guest
	/// English String: "Play as Guest"
	/// </summary>
	public override string ActionPlayAsGuest => "ä»¥æ¸¸å®¢èº«ä»½çŽ©";

	/// <summary>
	/// Key: "Action.Resend"
	/// button text for resending verification email
	/// English String: "Resend"
	/// </summary>
	public override string ActionResend => "é‡æ–°å‘é€";

	/// <summary>
	/// Key: "Action.ResendEmail"
	/// link that resends verification email to user
	/// English String: "Resend Email"
	/// </summary>
	public override string ActionResendEmail => "é‡æ–°å‘é€ç”µå­é‚®ä»¶";

	/// <summary>
	/// Key: "Action.SendVerificationEmail"
	/// button user can click to send a verification link to their email
	/// English String: "Send Verification Email"
	/// </summary>
	public override string ActionSendVerificationEmail => "å‘é€éªŒè¯ç”µå­é‚®ä»¶";

	/// <summary>
	/// Key: "Action.SignIn"
	/// Sign In button text
	/// English String: "Sign In"
	/// </summary>
	public override string ActionSignIn => "ç™»å½•";

	/// <summary>
	/// Key: "Action.SignInWithFacebook"
	/// Sign In with Facebook
	/// English String: "Sign In with Facebook"
	/// </summary>
	public override string ActionSignInWithFacebook => "ä½¿ç”¨ Facebook ç™»å½•";

	/// <summary>
	/// Key: "Action.SignUp"
	/// English String: "Sign up"
	/// </summary>
	public override string ActionSignUp => "æ³¨å†Œ";

	/// <summary>
	/// Key: "Action.SignUpCapitalized"
	/// link which takes user to sign up page
	/// English String: "Sign Up"
	/// </summary>
	public override string ActionSignUpCapitalized => "æ³¨å†Œ";

	/// <summary>
	/// Key: "Action.WeChatLogin"
	/// button text for logging in with WeChat
	/// English String: "WeChat Login"
	/// </summary>
	public override string ActionWeChatLogin => "å¾®ä¿¡ç™»å½•";

	/// <summary>
	/// Key: "Heading.Login"
	/// heading on the login page
	/// English String: "Login"
	/// </summary>
	public override string HeadingLogin => "ç™»å½•";

	/// <summary>
	/// Key: "Heading.LoginRoblox"
	/// current login page heading
	/// English String: "Login to Roblox"
	/// </summary>
	public override string HeadingLoginRoblox => "ç™»å½• Roblox";

	public override string HeadingSignUpMakeFriends => "æ³¨å†Œä»¥åˆ›å»ºå’Œè®¤è¯†æ–°æœ‹å‹";

	/// <summary>
	/// Key: "Label.AccountNotNeeded"
	/// You don't need an account to play Roblox
	/// English String: "You don't need an account to play Roblox"
	/// </summary>
	public override string LabelAccountNotNeeded => "ä½ ä¸éœ€è¦å¸æˆ·å°±èƒ½çŽ© Robloxã€‚";

	/// <summary>
	/// Key: "Label.EmailNeedsVerification"
	/// modal header used for prompting user they need to verify their email in order to log in with it
	/// English String: "Your email needs verification"
	/// </summary>
	public override string LabelEmailNeedsVerification => "ä½ çš„ç”µå­é‚®ä»¶éœ€è¦éªŒè¯";

	/// <summary>
	/// Key: "Label.FacebookCreatePasswordWarning"
	/// If you have been signing in with Facebook, you must set a password.
	/// English String: "If you have been signing in with Facebook, you must set a password."
	/// </summary>
	public override string LabelFacebookCreatePasswordWarning => "å¦‚æžœä½ ä½¿ç”¨ Facebook ç™»å½•ï¼Œåˆ™å¿…é¡»è®¾å®šå¯†ç ã€‚";

	/// <summary>
	/// Key: "Label.ForgotUsernamePassword"
	/// landing page top right link for password reset
	/// English String: "Forgot Username/Password?"
	/// </summary>
	public override string LabelForgotUsernamePassword => "å¿˜è®°ç”¨æˆ·å/å¯†ç ï¼Ÿ";

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
	public override string LabelLoggingInSpinnerText => "æ­£åœ¨ç™»å½•...";

	/// <summary>
	/// Key: "Label.Login"
	/// English String: "Log in"
	/// </summary>
	public override string LabelLogin => "ç™»å½•";

	/// <summary>
	/// Key: "Label.LoginWithYour"
	/// Label for a partition line between login with email and facebook login. Please keep the text in lowercase for roman characters.
	/// English String: "login with your"
	/// </summary>
	public override string LabelLoginWithYour => "ä½¿ç”¨ä¸‹åˆ—æ–¹å¼ç™»å½•";

	/// <summary>
	/// Key: "Label.NoAccount"
	/// Don't have an account?
	/// English String: "Don't have an account?"
	/// </summary>
	public override string LabelNoAccount => "æ²¡æœ‰å¸æˆ·ï¼Ÿ";

	/// <summary>
	/// Key: "Label.NonAMemberQuestion"
	/// The question heading for the section on the login page to take use to sign up page.
	/// English String: "Not a member?"
	/// </summary>
	public override string LabelNonAMemberQuestion => "ä¸æ˜¯ä¼šå‘˜ï¼Ÿ";

	/// <summary>
	/// Key: "Label.NotReceived"
	/// prompt for allowing users to resend verification email
	/// English String: "Didn't receive it?"
	/// </summary>
	public override string LabelNotReceived => "æ²¡æœ‰æ”¶åˆ°ï¼Ÿ";

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
	public override string LabelPassword => "å¯†ç ";

	/// <summary>
	/// Key: "Label.PasswordWithColumn"
	/// label for the password field on the login page
	/// English String: "Password:"
	/// </summary>
	public override string LabelPasswordWithColumn => "å¯†ç ï¼š";

	/// <summary>
	/// Key: "Label.StartPlaying"
	/// You can start playing right now, in guest mode!
	/// English String: "You can start playing right now, in guest mode!"
	/// </summary>
	public override string LabelStartPlaying => "ä½¿ç”¨æ¸¸å®¢æ¨¡å¼ï¼Œä½ çŽ°åœ¨å°±å¯ä»¥å¼€å§‹æ¸¸æˆäº†ï¼";

	/// <summary>
	/// Key: "Label.UnverifiedEmailInstructions"
	/// message shown in a modal when user logs in with unverified email
	/// English String: "To log in with your email, it must be verified. You can also log in with your username."
	/// </summary>
	public override string LabelUnverifiedEmailInstructions => "è¦ä½¿ç”¨ç”µå­é‚®ä»¶ç™»å½•ï¼Œå¿…é¡»å…ˆè¿›è¡ŒéªŒè¯ã€‚ä½ ä¹Ÿå¯ä»¥ä½¿ç”¨ä½ çš„ç”¨æˆ·åç™»å½•ã€‚";

	/// <summary>
	/// Key: "Label.Username"
	/// English String: "Username"
	/// </summary>
	public override string LabelUsername => "ç”¨æˆ·å";

	/// <summary>
	/// Key: "Label.UsernameEmail"
	/// placeholder text for input field that accepts username or email
	/// English String: "Username/Email"
	/// </summary>
	public override string LabelUsernameEmail => "ç”¨æˆ·å/ç”µå­é‚®ä»¶";

	/// <summary>
	/// Key: "Label.UsernameEmailPhone"
	/// placeholder text for input fields that accept username, email or phone
	/// English String: "Username/Email/Phone"
	/// </summary>
	public override string LabelUsernameEmailPhone => "ç”¨æˆ·å/ç”µå­é‚®ä»¶/æ‰‹æœº";

	/// <summary>
	/// Key: "Label.UsernamePhone"
	/// placeholder text for input field that accepts username or phone
	/// English String: "Username/Phone"
	/// </summary>
	public override string LabelUsernamePhone => "ç”¨æˆ·å/æ‰‹æœº";

	/// <summary>
	/// Key: "Label.UsernameWithColumn"
	/// label for username field on login page
	/// English String: "Username:"
	/// </summary>
	public override string LabelUsernameWithColumn => "ç”¨æˆ·åï¼š";

	/// <summary>
	/// Key: "Label.VerificationEmailSent"
	/// message telling user a verification email was sent to them
	/// English String: "Verification Email Sent!"
	/// </summary>
	public override string LabelVerificationEmailSent => "éªŒè¯é‚®ä»¶å·²å‘é€ï¼";

	/// <summary>
	/// Key: "Label.WeChatAntiAddictionText"
	/// English String: "Boycott bad games, refuse pirated games. Be aware of self-defense and being deceived. Playing games is good for your brain, but too much game play can harm your health. Manage your time well and enjoy a healthy lifestyle."
	/// </summary>
	public override string LabelWeChatAntiAddictionText => "æŠµåˆ¶ä¸è‰¯æ¸¸æˆï¼Œæ‹’ç»ç›—ç‰ˆæ¸¸æˆã€‚æ³¨æ„è‡ªæˆ‘ä¿æŠ¤ï¼Œè°¨é˜²å—éª—ä¸Šå½“ã€‚é€‚åº¦æ¸¸æˆç›Šè„‘ï¼Œæ²‰è¿·æ¸¸æˆä¼¤èº«ã€‚åˆç†å®‰æŽ’æ—¶é—´ï¼Œäº«å—å¥åº·ç”Ÿæ´»ã€‚";

	/// <summary>
	/// Key: "Message.UnknownErrorTryAgain"
	/// An unknown error occurred. Please try again.
	/// English String: "An unknown error occurred. Please try again."
	/// </summary>
	public override string MessageUnknownErrorTryAgain => "å‘ç”ŸæœªçŸ¥é”™è¯¯ã€‚è¯·é‡è¯•ã€‚";

	/// <summary>
	/// Key: "Message.UsernameAndPasswordRequired"
	/// message shown to user when they attempt to login without entering a username or password
	/// English String: "Username and password required"
	/// </summary>
	public override string MessageUsernameAndPasswordRequired => "éœ€è¦æä¾›ç”¨æˆ·ååŠå¯†ç ";

	/// <summary>
	/// Key: "Response.AccountIssueErrorContactSupport"
	/// English String: "Account issue. Please contact Support."
	/// </summary>
	public override string ResponseAccountIssueErrorContactSupport => "å¸æˆ·é—®é¢˜ã€‚è¯·è”ç³»æŠ€æœ¯æ”¯æŒã€‚";

	/// <summary>
	/// Key: "Response.AccountLockedRequestReset"
	/// Account has been locked. Please request a password reset.
	/// English String: "Account has been locked. Please request a password reset."
	/// </summary>
	public override string ResponseAccountLockedRequestReset => "å¸æˆ·å·²é”å®šã€‚è¯·æäº¤å¯†ç é‡ç½®è¯·æ±‚ã€‚";

	/// <summary>
	/// Key: "Response.AccountNotFound"
	/// Account not found. Please try again.
	/// English String: "Account not found. Please try again."
	/// </summary>
	public override string ResponseAccountNotFound => "æœªæ‰¾åˆ°å¸æˆ·ã€‚è¯·é‡è¯•ã€‚";

	/// <summary>
	/// Key: "Response.EmailLinkedToMultipleAccountsLoginWithUsername"
	/// error message displayed when user attempts to log in with an email that is linked to multiple accounts
	/// English String: "Your email is associated with more than 1 username. Please login with your username."
	/// </summary>
	public override string ResponseEmailLinkedToMultipleAccountsLoginWithUsername => "ä½ çš„ç”µå­é‚®ä»¶ä¸Žä¸æ­¢ 1 ä¸ªç”¨æˆ·åå…³è”ã€‚è¯·ä½¿ç”¨ä½ çš„ç”¨æˆ·åç™»å½•ã€‚";

	/// <summary>
	/// Key: "Response.EmailSent"
	/// response telling user that a verification email has been sent to them
	/// English String: "Email sent!"
	/// </summary>
	public override string ResponseEmailSent => "ç”µå­é‚®ä»¶å·²å‘é€ï¼";

	/// <summary>
	/// Key: "Response.IncorrectEmailOrPassword"
	/// error message displayed when user logs in with an invalid email or password
	/// English String: "Incorrect email or password."
	/// </summary>
	public override string ResponseIncorrectEmailOrPassword => "ç”µå­é‚®ä»¶æˆ–å¯†ç ä¸æ­£ç¡®ã€‚";

	/// <summary>
	/// Key: "Response.IncorrectPhoneOrPassword"
	/// error message displayed when user logs in with an invalid phone or password
	/// English String: "Incorrect phone or password."
	/// </summary>
	public override string ResponseIncorrectPhoneOrPassword => "ç”µè¯æˆ–å¯†ç ä¸æ­£ç¡®ã€‚";

	/// <summary>
	/// Key: "Response.IncorrectUsernamePassword"
	/// English String: "Incorrect username or password."
	/// </summary>
	public override string ResponseIncorrectUsernamePassword => "ç”¨æˆ·åæˆ–å¯†ç ä¸æ­£ç¡®ã€‚";

	/// <summary>
	/// Key: "Response.LoginWithUsername"
	/// error message shown when user attempts to login with method other than username and an error occurred
	/// English String: "Something went wrong. Please login with your username."
	/// </summary>
	public override string ResponseLoginWithUsername => "æœ‰åœ°æ–¹å‡ºé”™ï¼Œè¯·ä½¿ç”¨ä½ çš„ç”¨æˆ·åç™»å½•ã€‚";

	/// <summary>
	/// Key: "Response.PasswordNotProvided"
	/// password field is empty
	/// English String: "You must enter a password."
	/// </summary>
	public override string ResponsePasswordNotProvided => "ä½ å¿…é¡»è¾“å…¥å¯†ç ã€‚";

	/// <summary>
	/// Key: "Response.TooManyAttemptsPleaseWait"
	/// English String: "Too many attempts. Please wait a bit."
	/// </summary>
	public override string ResponseTooManyAttemptsPleaseWait => "å°è¯•æ¬¡æ•°è¿‡å¤šã€‚è¯·ç¨å€™ã€‚";

	/// <summary>
	/// Key: "Response.UnknownError"
	/// English String: "Unknown Error"
	/// </summary>
	public override string ResponseUnknownError => "æœªçŸ¥é”™è¯¯";

	/// <summary>
	/// Key: "Response.UnknownLoginError"
	/// Unknown login failure.
	/// English String: "Unknown login failure."
	/// </summary>
	public override string ResponseUnknownLoginError => "æœªçŸ¥ç™»å½•å¤±è´¥ã€‚";

	/// <summary>
	/// Key: "Response.UnverifiedEmailLoginWithUsername"
	/// error message shown when user attempts to login with unverified email
	/// English String: "Your email is not verified. Please login with your username."
	/// </summary>
	public override string ResponseUnverifiedEmailLoginWithUsername => "ä½ çš„ç”µå­é‚®ä»¶æœªç»éªŒè¯ã€‚è¯·ä½¿ç”¨ä½ çš„ç”¨æˆ·åç™»å½•ã€‚";

	/// <summary>
	/// Key: "Response.UnverifiedPhoneLoginWithUsername"
	/// error message shown when user attempts to login with an unverified phone number
	/// English String: "Your phone is not verified. Please login with your username."
	/// </summary>
	public override string ResponseUnverifiedPhoneLoginWithUsername => "ä½ çš„æ‰‹æœºæœªç»éªŒè¯ã€‚è¯·ä½¿ç”¨ä½ çš„ç”¨æˆ·åç™»å½•ã€‚";

	/// <summary>
	/// Key: "Response.UsernameNotProvided"
	/// username field is empty
	/// English String: "You must enter a username."
	/// </summary>
	public override string ResponseUsernameNotProvided => "ä½ å¿…é¡»è¾“å…¥ç”¨æˆ·åã€‚";

	/// <summary>
	/// Key: "Response.UseSocialSignOn"
	/// Unable to login. Please use Social Network sign on.
	/// English String: "Unable to login. Please use Social Network sign on."
	/// </summary>
	public override string ResponseUseSocialSignOn => "æ— æ³•ç™»å½•ã€‚è¯·ä½¿ç”¨ç¤¾äº¤ç½‘ç»œç™»å½•ã€‚";

	/// <summary>
	/// Key: "WeChat.AntiAddictionText"
	/// English String: "Boycott bad games, refuse pirated games. Be aware of self-defense and being deceived. Playing games is good for your brain, but too much game play can harm your health. Manage your time well and enjoy a healthy lifestyle."
	/// </summary>
	public override string WeChatAntiAddictionText => "æŠµåˆ¶ä¸è‰¯æ¸¸æˆï¼Œæ‹’ç»ç›—ç‰ˆæ¸¸æˆã€‚æ³¨æ„è‡ªæˆ‘ä¿æŠ¤ï¼Œè°¨é˜²å—éª—ä¸Šå½“ã€‚é€‚åº¦æ¸¸æˆç›Šè„‘ï¼Œæ²‰è¿·æ¸¸æˆä¼¤èº«ã€‚åˆç†å®‰æŽ’æ—¶é—´ï¼Œäº«å—å¥åº·ç”Ÿæ´»ã€‚";

	/// <summary>
	/// Key: "WeChat.RealNameNotVerified"
	/// English String: "Your WeChat is not real-name verified. Please use a real-name verified WeChat account and try again. Please visit https://jiazhang.qq.com/zk/home.html"
	/// </summary>
	public override string WeChatRealNameNotVerified => "ä½ çš„å¾®ä¿¡æœªç»è¿‡å®žåè®¤è¯ã€‚è¯·ä½¿ç”¨é€šè¿‡å®žåéªŒè¯çš„å¾®ä¿¡å¸æˆ·å¹¶é‡è¯•ã€‚è¦äº†è§£æ›´å¤šä¿¡æ¯ï¼Œè¯·è®¿é—® https://jiazhang.qq.com/zk/home.html";

	public LoginResources_zh_cn(TranslationResourceState state)
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
		return "å¿˜è®°å¯†ç æˆ–ç”¨æˆ·åï¼Ÿ";
	}

	protected override string _GetTemplateForActionForgotPasswordOrUsernameQuestionCapitalized()
	{
		return "å¿˜è®°å¯†ç æˆ–ç”¨æˆ·åï¼Ÿ";
	}

	protected override string _GetTemplateForActionLogin()
	{
		return "ç™»å½•";
	}

	protected override string _GetTemplateForActionLogInCapitalized()
	{
		return "ç™»å½•";
	}

	protected override string _GetTemplateForActionOk()
	{
		return "å¥½";
	}

	protected override string _GetTemplateForActionPlayAsGuest()
	{
		return "ä»¥æ¸¸å®¢èº«ä»½çŽ©";
	}

	protected override string _GetTemplateForActionResend()
	{
		return "é‡æ–°å‘é€";
	}

	protected override string _GetTemplateForActionResendEmail()
	{
		return "é‡æ–°å‘é€ç”µå­é‚®ä»¶";
	}

	protected override string _GetTemplateForActionSendVerificationEmail()
	{
		return "å‘é€éªŒè¯ç”µå­é‚®ä»¶";
	}

	protected override string _GetTemplateForActionSignIn()
	{
		return "ç™»å½•";
	}

	protected override string _GetTemplateForActionSignInWithFacebook()
	{
		return "ä½¿ç”¨ Facebook ç™»å½•";
	}

	protected override string _GetTemplateForActionSignUp()
	{
		return "æ³¨å†Œ";
	}

	protected override string _GetTemplateForActionSignUpCapitalized()
	{
		return "æ³¨å†Œ";
	}

	protected override string _GetTemplateForActionWeChatLogin()
	{
		return "å¾®ä¿¡ç™»å½•";
	}

	protected override string _GetTemplateForHeadingLogin()
	{
		return "ç™»å½•";
	}

	protected override string _GetTemplateForHeadingLoginRoblox()
	{
		return "ç™»å½• Roblox";
	}

	protected override string _GetTemplateForHeadingSignUpMakeFriends()
	{
		return "æ³¨å†Œä»¥åˆ›å»ºå’Œè®¤è¯†æ–°æœ‹å‹";
	}

	protected override string _GetTemplateForLabelAccountNotNeeded()
	{
		return "ä½ ä¸éœ€è¦å¸æˆ·å°±èƒ½çŽ© Robloxã€‚";
	}

	protected override string _GetTemplateForLabelEmailNeedsVerification()
	{
		return "ä½ çš„ç”µå­é‚®ä»¶éœ€è¦éªŒè¯";
	}

	protected override string _GetTemplateForLabelFacebookCreatePasswordWarning()
	{
		return "å¦‚æžœä½ ä½¿ç”¨ Facebook ç™»å½•ï¼Œåˆ™å¿…é¡»è®¾å®šå¯†ç ã€‚";
	}

	protected override string _GetTemplateForLabelForgotUsernamePassword()
	{
		return "å¿˜è®°ç”¨æˆ·å/å¯†ç ï¼Ÿ";
	}

	/// <summary>
	/// Key: "Label.GreetingForNewAccount"
	/// Shown when a username doesn't exist on the login page to invite to create a new account.
	/// English String: "Nice to meet you, {username}. {linkStartSignup}Let's make an account! {linkEndSignup}"
	/// </summary>
	public override string LabelGreetingForNewAccount(string username, string linkStartSignup, string linkEndSignup)
	{
		return $"å¾ˆé«˜å…´è®¤è¯†ä½ ï¼Œ {username}ã€‚ {linkStartSignup}æˆ‘ä»¬æ¥åˆ›å»ºå¸æˆ·å§ï¼ {linkEndSignup}";
	}

	protected override string _GetTemplateForLabelGreetingForNewAccount()
	{
		return "å¾ˆé«˜å…´è®¤è¯†ä½ ï¼Œ {username}ã€‚ {linkStartSignup}æˆ‘ä»¬æ¥åˆ›å»ºå¸æˆ·å§ï¼ {linkEndSignup}";
	}

	protected override string _GetTemplateForLabelLearnMore()
	{
		return "äº†è§£æ›´å¤š";
	}

	protected override string _GetTemplateForLabelLoggingInSpinnerText()
	{
		return "æ­£åœ¨ç™»å½•...";
	}

	protected override string _GetTemplateForLabelLogin()
	{
		return "ç™»å½•";
	}

	protected override string _GetTemplateForLabelLoginWithYour()
	{
		return "ä½¿ç”¨ä¸‹åˆ—æ–¹å¼ç™»å½•";
	}

	protected override string _GetTemplateForLabelNoAccount()
	{
		return "æ²¡æœ‰å¸æˆ·ï¼Ÿ";
	}

	protected override string _GetTemplateForLabelNonAMemberQuestion()
	{
		return "ä¸æ˜¯ä¼šå‘˜ï¼Ÿ";
	}

	protected override string _GetTemplateForLabelNotReceived()
	{
		return "æ²¡æœ‰æ”¶åˆ°ï¼Ÿ";
	}

	protected override string _GetTemplateForLabelOr()
	{
		return "æˆ–";
	}

	protected override string _GetTemplateForLabelPassword()
	{
		return "å¯†ç ";
	}

	protected override string _GetTemplateForLabelPasswordWithColumn()
	{
		return "å¯†ç ï¼š";
	}

	protected override string _GetTemplateForLabelStartPlaying()
	{
		return "ä½¿ç”¨æ¸¸å®¢æ¨¡å¼ï¼Œä½ çŽ°åœ¨å°±å¯ä»¥å¼€å§‹æ¸¸æˆäº†ï¼";
	}

	protected override string _GetTemplateForLabelUnverifiedEmailInstructions()
	{
		return "è¦ä½¿ç”¨ç”µå­é‚®ä»¶ç™»å½•ï¼Œå¿…é¡»å…ˆè¿›è¡ŒéªŒè¯ã€‚ä½ ä¹Ÿå¯ä»¥ä½¿ç”¨ä½ çš„ç”¨æˆ·åç™»å½•ã€‚";
	}

	protected override string _GetTemplateForLabelUsername()
	{
		return "ç”¨æˆ·å";
	}

	protected override string _GetTemplateForLabelUsernameEmail()
	{
		return "ç”¨æˆ·å/ç”µå­é‚®ä»¶";
	}

	protected override string _GetTemplateForLabelUsernameEmailPhone()
	{
		return "ç”¨æˆ·å/ç”µå­é‚®ä»¶/æ‰‹æœº";
	}

	protected override string _GetTemplateForLabelUsernamePhone()
	{
		return "ç”¨æˆ·å/æ‰‹æœº";
	}

	protected override string _GetTemplateForLabelUsernameWithColumn()
	{
		return "ç”¨æˆ·åï¼š";
	}

	protected override string _GetTemplateForLabelVerificationEmailSent()
	{
		return "éªŒè¯é‚®ä»¶å·²å‘é€ï¼";
	}

	protected override string _GetTemplateForLabelWeChatAntiAddictionText()
	{
		return "æŠµåˆ¶ä¸è‰¯æ¸¸æˆï¼Œæ‹’ç»ç›—ç‰ˆæ¸¸æˆã€‚æ³¨æ„è‡ªæˆ‘ä¿æŠ¤ï¼Œè°¨é˜²å—éª—ä¸Šå½“ã€‚é€‚åº¦æ¸¸æˆç›Šè„‘ï¼Œæ²‰è¿·æ¸¸æˆä¼¤èº«ã€‚åˆç†å®‰æŽ’æ—¶é—´ï¼Œäº«å—å¥åº·ç”Ÿæ´»ã€‚";
	}

	protected override string _GetTemplateForMessageUnknownErrorTryAgain()
	{
		return "å‘ç”ŸæœªçŸ¥é”™è¯¯ã€‚è¯·é‡è¯•ã€‚";
	}

	protected override string _GetTemplateForMessageUsernameAndPasswordRequired()
	{
		return "éœ€è¦æä¾›ç”¨æˆ·ååŠå¯†ç ";
	}

	protected override string _GetTemplateForResponseAccountIssueErrorContactSupport()
	{
		return "å¸æˆ·é—®é¢˜ã€‚è¯·è”ç³»æŠ€æœ¯æ”¯æŒã€‚";
	}

	protected override string _GetTemplateForResponseAccountLockedRequestReset()
	{
		return "å¸æˆ·å·²é”å®šã€‚è¯·æäº¤å¯†ç é‡ç½®è¯·æ±‚ã€‚";
	}

	protected override string _GetTemplateForResponseAccountNotFound()
	{
		return "æœªæ‰¾åˆ°å¸æˆ·ã€‚è¯·é‡è¯•ã€‚";
	}

	protected override string _GetTemplateForResponseEmailLinkedToMultipleAccountsLoginWithUsername()
	{
		return "ä½ çš„ç”µå­é‚®ä»¶ä¸Žä¸æ­¢ 1 ä¸ªç”¨æˆ·åå…³è”ã€‚è¯·ä½¿ç”¨ä½ çš„ç”¨æˆ·åç™»å½•ã€‚";
	}

	protected override string _GetTemplateForResponseEmailSent()
	{
		return "ç”µå­é‚®ä»¶å·²å‘é€ï¼";
	}

	protected override string _GetTemplateForResponseIncorrectEmailOrPassword()
	{
		return "ç”µå­é‚®ä»¶æˆ–å¯†ç ä¸æ­£ç¡®ã€‚";
	}

	protected override string _GetTemplateForResponseIncorrectPhoneOrPassword()
	{
		return "ç”µè¯æˆ–å¯†ç ä¸æ­£ç¡®ã€‚";
	}

	protected override string _GetTemplateForResponseIncorrectUsernamePassword()
	{
		return "ç”¨æˆ·åæˆ–å¯†ç ä¸æ­£ç¡®ã€‚";
	}

	protected override string _GetTemplateForResponseLoginWithUsername()
	{
		return "æœ‰åœ°æ–¹å‡ºé”™ï¼Œè¯·ä½¿ç”¨ä½ çš„ç”¨æˆ·åç™»å½•ã€‚";
	}

	protected override string _GetTemplateForResponsePasswordNotProvided()
	{
		return "ä½ å¿…é¡»è¾“å…¥å¯†ç ã€‚";
	}

	protected override string _GetTemplateForResponseTooManyAttemptsPleaseWait()
	{
		return "å°è¯•æ¬¡æ•°è¿‡å¤šã€‚è¯·ç¨å€™ã€‚";
	}

	protected override string _GetTemplateForResponseUnknownError()
	{
		return "æœªçŸ¥é”™è¯¯";
	}

	protected override string _GetTemplateForResponseUnknownLoginError()
	{
		return "æœªçŸ¥ç™»å½•å¤±è´¥ã€‚";
	}

	protected override string _GetTemplateForResponseUnverifiedEmailLoginWithUsername()
	{
		return "ä½ çš„ç”µå­é‚®ä»¶æœªç»éªŒè¯ã€‚è¯·ä½¿ç”¨ä½ çš„ç”¨æˆ·åç™»å½•ã€‚";
	}

	protected override string _GetTemplateForResponseUnverifiedPhoneLoginWithUsername()
	{
		return "ä½ çš„æ‰‹æœºæœªç»éªŒè¯ã€‚è¯·ä½¿ç”¨ä½ çš„ç”¨æˆ·åç™»å½•ã€‚";
	}

	protected override string _GetTemplateForResponseUsernameNotProvided()
	{
		return "ä½ å¿…é¡»è¾“å…¥ç”¨æˆ·åã€‚";
	}

	protected override string _GetTemplateForResponseUseSocialSignOn()
	{
		return "æ— æ³•ç™»å½•ã€‚è¯·ä½¿ç”¨ç¤¾äº¤ç½‘ç»œç™»å½•ã€‚";
	}

	/// <summary>
	/// Key: "Response.WeChatNotRealNameVerified"
	/// English String: "Your WeChat is not real-name verified. Please use a real-name verified WeChat account and try again. Please visit {url}"
	/// </summary>
	public override string ResponseWeChatNotRealNameVerified(string url)
	{
		return $"ä½ çš„å¾®ä¿¡æœªç»è¿‡å®žåè®¤è¯ã€‚è¯·ä½¿ç”¨é€šè¿‡å®žåéªŒè¯çš„å¾®ä¿¡å¸æˆ·å¹¶é‡è¯•ã€‚è¦äº†è§£æ›´å¤šä¿¡æ¯ï¼Œè¯·è®¿é—® {url}";
	}

	protected override string _GetTemplateForResponseWeChatNotRealNameVerified()
	{
		return "ä½ çš„å¾®ä¿¡æœªç»è¿‡å®žåè®¤è¯ã€‚è¯·ä½¿ç”¨é€šè¿‡å®žåéªŒè¯çš„å¾®ä¿¡å¸æˆ·å¹¶é‡è¯•ã€‚è¦äº†è§£æ›´å¤šä¿¡æ¯ï¼Œè¯·è®¿é—® {url}";
	}

	protected override string _GetTemplateForWeChatAntiAddictionText()
	{
		return "æŠµåˆ¶ä¸è‰¯æ¸¸æˆï¼Œæ‹’ç»ç›—ç‰ˆæ¸¸æˆã€‚æ³¨æ„è‡ªæˆ‘ä¿æŠ¤ï¼Œè°¨é˜²å—éª—ä¸Šå½“ã€‚é€‚åº¦æ¸¸æˆç›Šè„‘ï¼Œæ²‰è¿·æ¸¸æˆä¼¤èº«ã€‚åˆç†å®‰æŽ’æ—¶é—´ï¼Œäº«å—å¥åº·ç”Ÿæ´»ã€‚";
	}

	protected override string _GetTemplateForWeChatRealNameNotVerified()
	{
		return "ä½ çš„å¾®ä¿¡æœªç»è¿‡å®žåè®¤è¯ã€‚è¯·ä½¿ç”¨é€šè¿‡å®žåéªŒè¯çš„å¾®ä¿¡å¸æˆ·å¹¶é‡è¯•ã€‚è¦äº†è§£æ›´å¤šä¿¡æ¯ï¼Œè¯·è®¿é—® https://jiazhang.qq.com/zk/home.html";
	}
}


}
