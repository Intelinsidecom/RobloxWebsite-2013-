namespace Roblox.Platform.TranslationResources.Authentication {
    /// <summary>

/// This class overrides LoginResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class LoginResources_ko_kr : LoginResources_en_us, ILoginResources, ITranslationResources
{
	/// <summary>
	/// Key: "Action.Cancel"
	/// Cancel button text
	/// English String: "Cancel"
	/// </summary>
	public override string ActionCancel => "ì·¨ì†Œ";

	/// <summary>
	/// Key: "Action.Facebook"
	/// facebook button label
	/// English String: "Facebook"
	/// </summary>
	public override string ActionFacebook => "Facebook:";

	/// <summary>
	/// Key: "Action.ForgotPasswordOrUsernameQuestion"
	/// English String: "Forgot password or username?"
	/// </summary>
	public override string ActionForgotPasswordOrUsernameQuestion => "ë¹„ë°€ë²ˆí˜¸ ë˜ëŠ” ì‚¬ìš©ìž ì´ë¦„ì„ ìžŠìœ¼ì…¨ë‚˜ìš”?";

	/// <summary>
	/// Key: "Action.ForgotPasswordOrUsernameQuestionCapitalized"
	/// link under login form
	/// English String: "Forgot Password or Username?"
	/// </summary>
	public override string ActionForgotPasswordOrUsernameQuestionCapitalized => "ë¹„ë°€ë²ˆí˜¸ ë˜ëŠ” ì‚¬ìš©ìž ì´ë¦„ì„ ìžŠìœ¼ì…¨ë‚˜ìš”?";

	/// <summary>
	/// Key: "Action.Login"
	/// English String: "Login"
	/// </summary>
	public override string ActionLogin => "ë¡œê·¸ì¸";

	/// <summary>
	/// Key: "Action.LogInCapitalized"
	/// login button label. please note this is different from 'Login' or 'Log in'.
	/// English String: "Log In"
	/// </summary>
	public override string ActionLogInCapitalized => "ë¡œê·¸ì¸";

	/// <summary>
	/// Key: "Action.Ok"
	/// button text
	/// English String: "OK"
	/// </summary>
	public override string ActionOk => "í™•ì¸";

	/// <summary>
	/// Key: "Action.PlayAsGuest"
	/// Play as Guest
	/// English String: "Play as Guest"
	/// </summary>
	public override string ActionPlayAsGuest => "ê²ŒìŠ¤íŠ¸ë¡œ í”Œë ˆì´";

	/// <summary>
	/// Key: "Action.Resend"
	/// button text for resending verification email
	/// English String: "Resend"
	/// </summary>
	public override string ActionResend => "ìž¬ì „ì†¡";

	/// <summary>
	/// Key: "Action.ResendEmail"
	/// link that resends verification email to user
	/// English String: "Resend Email"
	/// </summary>
	public override string ActionResendEmail => "ì´ë©”ì¼ ìž¬ì „ì†¡";

	/// <summary>
	/// Key: "Action.SendVerificationEmail"
	/// button user can click to send a verification link to their email
	/// English String: "Send Verification Email"
	/// </summary>
	public override string ActionSendVerificationEmail => "ì¸ì¦ ì´ë©”ì¼ ë³´ë‚´ê¸°";

	/// <summary>
	/// Key: "Action.SignIn"
	/// Sign In button text
	/// English String: "Sign In"
	/// </summary>
	public override string ActionSignIn => "ë¡œê·¸ì¸";

	/// <summary>
	/// Key: "Action.SignInWithFacebook"
	/// Sign In with Facebook
	/// English String: "Sign In with Facebook"
	/// </summary>
	public override string ActionSignInWithFacebook => "Facebookìœ¼ë¡œ ë¡œê·¸ì¸";

	/// <summary>
	/// Key: "Action.SignUp"
	/// English String: "Sign up"
	/// </summary>
	public override string ActionSignUp => "íšŒì›ê°€ìž…";

	/// <summary>
	/// Key: "Action.SignUpCapitalized"
	/// link which takes user to sign up page
	/// English String: "Sign Up"
	/// </summary>
	public override string ActionSignUpCapitalized => "íšŒì›ê°€ìž…";

	/// <summary>
	/// Key: "Action.WeChatLogin"
	/// button text for logging in with WeChat
	/// English String: "WeChat Login"
	/// </summary>
	public override string ActionWeChatLogin => "WeChat ë¡œê·¸ì¸";

	/// <summary>
	/// Key: "Heading.Login"
	/// heading on the login page
	/// English String: "Login"
	/// </summary>
	public override string HeadingLogin => "ë¡œê·¸ì¸";

	/// <summary>
	/// Key: "Heading.LoginRoblox"
	/// current login page heading
	/// English String: "Login to Roblox"
	/// </summary>
	public override string HeadingLoginRoblox => "Robloxì— ë¡œê·¸ì¸";

	public override string HeadingSignUpMakeFriends => "íšŒì›ê°€ìž…í•˜ì…”ì„œ ê²Œìž„ë„ ë§Œë“¤ê³  ì¹œêµ¬ë„ ì‚¬ê·€ì–´ ë³´ì„¸ìš”";

	/// <summary>
	/// Key: "Label.AccountNotNeeded"
	/// You don't need an account to play Roblox
	/// English String: "You don't need an account to play Roblox"
	/// </summary>
	public override string LabelAccountNotNeeded => "ê³„ì •ì´ ì—†ì–´ë„ Robloxë¥¼ ì¦ê¸¸ ìˆ˜ ìžˆì–´ìš”";

	/// <summary>
	/// Key: "Label.EmailNeedsVerification"
	/// modal header used for prompting user they need to verify their email in order to log in with it
	/// English String: "Your email needs verification"
	/// </summary>
	public override string LabelEmailNeedsVerification => "ì´ë©”ì¼ ì¸ì¦ì´ í•„ìš”í•©ë‹ˆë‹¤";

	/// <summary>
	/// Key: "Label.FacebookCreatePasswordWarning"
	/// If you have been signing in with Facebook, you must set a password.
	/// English String: "If you have been signing in with Facebook, you must set a password."
	/// </summary>
	public override string LabelFacebookCreatePasswordWarning => "Facebookìœ¼ë¡œ ë¡œê·¸ì¸í•œ ê²½ìš°, ë¹„ë°€ë²ˆí˜¸ë¥¼ ì„¤ì •í•´ì•¼ í•©ë‹ˆë‹¤.";

	/// <summary>
	/// Key: "Label.ForgotUsernamePassword"
	/// landing page top right link for password reset
	/// English String: "Forgot Username/Password?"
	/// </summary>
	public override string LabelForgotUsernamePassword => "ì‚¬ìš©ìž ì´ë¦„/ë¹„ë°€ë²ˆí˜¸ë¥¼ ìžŠìœ¼ì…¨ë‚˜ìš”?";

	/// <summary>
	/// Key: "Label.LearnMore"
	/// learn more link text
	/// English String: "Learn more"
	/// </summary>
	public override string LabelLearnMore => "ë” ì•Œì•„ë³´ê¸°";

	/// <summary>
	/// Key: "Label.LoggingInSpinnerText"
	/// English String: "Logging inâ€¦"
	/// </summary>
	public override string LabelLoggingInSpinnerText => "ë¡œê·¸ì¸ ì¤‘...";

	/// <summary>
	/// Key: "Label.Login"
	/// English String: "Log in"
	/// </summary>
	public override string LabelLogin => "ë¡œê·¸ì¸";

	/// <summary>
	/// Key: "Label.LoginWithYour"
	/// Label for a partition line between login with email and facebook login. Please keep the text in lowercase for roman characters.
	/// English String: "login with your"
	/// </summary>
	public override string LabelLoginWithYour => "ë‹¤ìŒìœ¼ë¡œ ë¡œê·¸ì¸";

	/// <summary>
	/// Key: "Label.NoAccount"
	/// Don't have an account?
	/// English String: "Don't have an account?"
	/// </summary>
	public override string LabelNoAccount => "ê³„ì •ì´ ì—†ìœ¼ì‹ ê°€ìš”?";

	/// <summary>
	/// Key: "Label.NonAMemberQuestion"
	/// The question heading for the section on the login page to take use to sign up page.
	/// English String: "Not a member?"
	/// </summary>
	public override string LabelNonAMemberQuestion => "íšŒì›ì´ ì•„ë‹ˆì‹ ê°€ìš”?";

	/// <summary>
	/// Key: "Label.NotReceived"
	/// prompt for allowing users to resend verification email
	/// English String: "Didn't receive it?"
	/// </summary>
	public override string LabelNotReceived => "ì´ë©”ì¼ì„ ë°›ì§€ ëª»í•˜ì…¨ë‚˜ìš”?";

	/// <summary>
	/// Key: "Label.Or"
	/// partition between email login and facebook login
	/// English String: "Or"
	/// </summary>
	public override string LabelOr => "ë˜ëŠ”";

	/// <summary>
	/// Key: "Label.Password"
	/// Password
	/// English String: "Password"
	/// </summary>
	public override string LabelPassword => "ë¹„ë°€ë²ˆí˜¸";

	/// <summary>
	/// Key: "Label.PasswordWithColumn"
	/// label for the password field on the login page
	/// English String: "Password:"
	/// </summary>
	public override string LabelPasswordWithColumn => "ë¹„ë°€ë²ˆí˜¸:";

	/// <summary>
	/// Key: "Label.StartPlaying"
	/// You can start playing right now, in guest mode!
	/// English String: "You can start playing right now, in guest mode!"
	/// </summary>
	public override string LabelStartPlaying => "ê²ŒìŠ¤íŠ¸ ëª¨ë“œë¡œ ì§€ê¸ˆ ê²Œìž„ì„ ì‹œìž‘í•´ë³´ì„¸ìš”!";

	/// <summary>
	/// Key: "Label.UnverifiedEmailInstructions"
	/// message shown in a modal when user logs in with unverified email
	/// English String: "To log in with your email, it must be verified. You can also log in with your username."
	/// </summary>
	public override string LabelUnverifiedEmailInstructions => "ì´ë©”ì¼ë¡œ ë¡œê·¸ì¸í•˜ë ¤ë©´ ë¨¼ì € ì¸ì¦í•´ì•¼ í•©ë‹ˆë‹¤. ì‚¬ìš©ìž ì´ë¦„ìœ¼ë¡œë„ ë¡œê·¸ì¸í•  ìˆ˜ ìžˆì–´ìš”.";

	/// <summary>
	/// Key: "Label.Username"
	/// English String: "Username"
	/// </summary>
	public override string LabelUsername => "ì‚¬ìš©ìž ì´ë¦„";

	/// <summary>
	/// Key: "Label.UsernameEmail"
	/// placeholder text for input field that accepts username or email
	/// English String: "Username/Email"
	/// </summary>
	public override string LabelUsernameEmail => "ì‚¬ìš©ìž ì´ë¦„/ì´ë©”ì¼";

	/// <summary>
	/// Key: "Label.UsernameEmailPhone"
	/// placeholder text for input fields that accept username, email or phone
	/// English String: "Username/Email/Phone"
	/// </summary>
	public override string LabelUsernameEmailPhone => "ì‚¬ìš©ìž ì´ë¦„/ì´ë©”ì¼/ì „í™”ë²ˆí˜¸";

	/// <summary>
	/// Key: "Label.UsernamePhone"
	/// placeholder text for input field that accepts username or phone
	/// English String: "Username/Phone"
	/// </summary>
	public override string LabelUsernamePhone => "ì‚¬ìš©ìž ì´ë¦„/ì „í™”ë²ˆí˜¸";

	/// <summary>
	/// Key: "Label.UsernameWithColumn"
	/// label for username field on login page
	/// English String: "Username:"
	/// </summary>
	public override string LabelUsernameWithColumn => "ì‚¬ìš©ìž ì´ë¦„:";

	/// <summary>
	/// Key: "Label.VerificationEmailSent"
	/// message telling user a verification email was sent to them
	/// English String: "Verification Email Sent!"
	/// </summary>
	public override string LabelVerificationEmailSent => "ì¸ì¦ ì´ë©”ì¼ ì „ì†¡ ì™„ë£Œ!";

	/// <summary>
	/// Key: "Label.WeChatAntiAddictionText"
	/// English String: "Boycott bad games, refuse pirated games. Be aware of self-defense and being deceived. Playing games is good for your brain, but too much game play can harm your health. Manage your time well and enjoy a healthy lifestyle."
	/// </summary>
	public override string LabelWeChatAntiAddictionText => "ê±´ì „í•˜ì§€ ì•Šì€ ê²Œìž„ê³¼ ì €ìž‘ê¶Œ ë¬¸ì œê°€ ìžˆëŠ” ê²Œìž„ì€ í”Œë ˆì´í•˜ì§€ ë§ˆì‹œê³ , ì‚¬ê¸° í–‰ìœ„ì— ì—°ë£¨ë˜ì§€ ì•Šë„ë¡ ìŠ¤ìŠ¤ë¡œë¥¼ ë³´í˜¸í•˜ì„¸ìš”. ê²Œìž„ì€ ë‘ë‡Œ ë°œë‹¬ì— ë„ì›€ì´ ë˜ì§€ë§Œ, ì§€ë‚˜ì¹œ ê²Œìž„ í”Œë ˆì´ëŠ” ê±´ê°•ì— ì¢‹ì§€ ì•ŠìŠµë‹ˆë‹¤. í”Œë ˆì´ ì‹œê°„ì„ ìž˜ ì¡°ì ˆí•´ì„œ ê±´ê°•í•˜ê²Œ ê²Œìž„ì„ ì¦ê¸°ì„¸ìš”.";

	/// <summary>
	/// Key: "Message.UnknownErrorTryAgain"
	/// An unknown error occurred. Please try again.
	/// English String: "An unknown error occurred. Please try again."
	/// </summary>
	public override string MessageUnknownErrorTryAgain => "ì•Œ ìˆ˜ ì—†ëŠ” ì˜¤ë¥˜ê°€ ë°œìƒí–ˆìŠµë‹ˆë‹¤.\u00a0ë‚˜ì¤‘ì— ë‹¤ì‹œ ì‹œë„í•˜ì„¸ìš”.";

	/// <summary>
	/// Key: "Message.UsernameAndPasswordRequired"
	/// message shown to user when they attempt to login without entering a username or password
	/// English String: "Username and password required"
	/// </summary>
	public override string MessageUsernameAndPasswordRequired => "ì‚¬ìš©ìž ì´ë¦„ ë° ë¹„ë°€ë²ˆí˜¸ê°€ í•„ìš”í•©ë‹ˆë‹¤";

	/// <summary>
	/// Key: "Response.AccountIssueErrorContactSupport"
	/// English String: "Account issue. Please contact Support."
	/// </summary>
	public override string ResponseAccountIssueErrorContactSupport => "ê³„ì • ì˜¤ë¥˜.\u00a0ê³ ê°ì§€ì›ìœ¼ë¡œ ë¬¸ì˜í•˜ì„¸ìš”.";

	/// <summary>
	/// Key: "Response.AccountLockedRequestReset"
	/// Account has been locked. Please request a password reset.
	/// English String: "Account has been locked. Please request a password reset."
	/// </summary>
	public override string ResponseAccountLockedRequestReset => "ê³„ì •ì´ ìž ê²¼ìŠµë‹ˆë‹¤. ë¹„ë°€ë²ˆí˜¸ ìž¬ì„¤ì •ì„ ìš”ì²­í•˜ì„¸ìš”.";

	/// <summary>
	/// Key: "Response.AccountNotFound"
	/// Account not found. Please try again.
	/// English String: "Account not found. Please try again."
	/// </summary>
	public override string ResponseAccountNotFound => "ê³„ì •ì„ ì°¾ì„ ìˆ˜ ì—†ìŠµë‹ˆë‹¤. ë‹¤ì‹œ ì‹œë„í•˜ì„¸ìš”.";

	/// <summary>
	/// Key: "Response.EmailLinkedToMultipleAccountsLoginWithUsername"
	/// error message displayed when user attempts to log in with an email that is linked to multiple accounts
	/// English String: "Your email is associated with more than 1 username. Please login with your username."
	/// </summary>
	public override string ResponseEmailLinkedToMultipleAccountsLoginWithUsername => "ì´ë©”ì¼ì´ 1ê°œ ì´ìƒì˜ ì‚¬ìš©ìž ì´ë¦„ê³¼ ì—°ê²°ë˜ì–´ ìžˆìŠµë‹ˆë‹¤. ì‚¬ìš©ìž ì´ë¦„ìœ¼ë¡œ ë¡œê·¸ì¸í•˜ì„¸ìš”.";

	/// <summary>
	/// Key: "Response.EmailSent"
	/// response telling user that a verification email has been sent to them
	/// English String: "Email sent!"
	/// </summary>
	public override string ResponseEmailSent => "ì´ë©”ì¼ ì „ì†¡ ì™„ë£Œ!";

	/// <summary>
	/// Key: "Response.IncorrectEmailOrPassword"
	/// error message displayed when user logs in with an invalid email or password
	/// English String: "Incorrect email or password."
	/// </summary>
	public override string ResponseIncorrectEmailOrPassword => "ì´ë©”ì¼ ë˜ëŠ” ë¹„ë°€ë²ˆí˜¸ê°€ ì¼ì¹˜í•˜ì§€ ì•ŠìŠµë‹ˆë‹¤.";

	/// <summary>
	/// Key: "Response.IncorrectPhoneOrPassword"
	/// error message displayed when user logs in with an invalid phone or password
	/// English String: "Incorrect phone or password."
	/// </summary>
	public override string ResponseIncorrectPhoneOrPassword => "ì „í™”ë²ˆí˜¸ ë˜ëŠ” ë¹„ë°€ë²ˆí˜¸ê°€ ì¼ì¹˜í•˜ì§€ ì•ŠìŠµë‹ˆë‹¤.";

	/// <summary>
	/// Key: "Response.IncorrectUsernamePassword"
	/// English String: "Incorrect username or password."
	/// </summary>
	public override string ResponseIncorrectUsernamePassword => "ì‚¬ìš©ìž ì´ë¦„ ë˜ëŠ” ë¹„ë°€ë²ˆí˜¸ê°€ ì¼ì¹˜í•˜ì§€ ì•ŠìŠµë‹ˆë‹¤.";

	/// <summary>
	/// Key: "Response.LoginWithUsername"
	/// error message shown when user attempts to login with method other than username and an error occurred
	/// English String: "Something went wrong. Please login with your username."
	/// </summary>
	public override string ResponseLoginWithUsername => "ì˜¤ë¥˜ê°€ ë°œìƒí–ˆì–´ìš”. ì‚¬ìš©ìž ì´ë¦„ìœ¼ë¡œ ë¡œê·¸ì¸í•˜ì„¸ìš”.";

	/// <summary>
	/// Key: "Response.PasswordNotProvided"
	/// password field is empty
	/// English String: "You must enter a password."
	/// </summary>
	public override string ResponsePasswordNotProvided => "ë¹„ë°€ë²ˆí˜¸ë¥¼ ìž…ë ¥í•´ì•¼ í•©ë‹ˆë‹¤.";

	/// <summary>
	/// Key: "Response.TooManyAttemptsPleaseWait"
	/// English String: "Too many attempts. Please wait a bit."
	/// </summary>
	public override string ResponseTooManyAttemptsPleaseWait => "ì‹œë„ ê°€ëŠ¥ íšŸìˆ˜ë¥¼ ì´ˆê³¼í–ˆìŠµë‹ˆë‹¤. ìž ì‹œ ê¸°ë‹¤ë ¤ì£¼ì„¸ìš”.";

	/// <summary>
	/// Key: "Response.UnknownError"
	/// English String: "Unknown Error"
	/// </summary>
	public override string ResponseUnknownError => "ì•Œ ìˆ˜ ì—†ëŠ” ì˜¤ë¥˜";

	/// <summary>
	/// Key: "Response.UnknownLoginError"
	/// Unknown login failure.
	/// English String: "Unknown login failure."
	/// </summary>
	public override string ResponseUnknownLoginError => "ì•Œ ìˆ˜ ì—†ëŠ” ë¡œê·¸ì¸ ì‹¤íŒ¨.";

	/// <summary>
	/// Key: "Response.UnverifiedEmailLoginWithUsername"
	/// error message shown when user attempts to login with unverified email
	/// English String: "Your email is not verified. Please login with your username."
	/// </summary>
	public override string ResponseUnverifiedEmailLoginWithUsername => "ì¸ì¦ë˜ì§€ ì•Šì€ ì´ë©”ì¼ìž…ë‹ˆë‹¤. ì‚¬ìš©ìž ì´ë¦„ìœ¼ë¡œ ë¡œê·¸ì¸í•˜ì„¸ìš”.";

	/// <summary>
	/// Key: "Response.UnverifiedPhoneLoginWithUsername"
	/// error message shown when user attempts to login with an unverified phone number
	/// English String: "Your phone is not verified. Please login with your username."
	/// </summary>
	public override string ResponseUnverifiedPhoneLoginWithUsername => "ì¸ì¦ë˜ì§€ ì•Šì€ ì „í™”ë²ˆí˜¸ìž…ë‹ˆë‹¤. ì‚¬ìš©ìž ì´ë¦„ìœ¼ë¡œ ë¡œê·¸ì¸í•˜ì„¸ìš”.";

	/// <summary>
	/// Key: "Response.UsernameNotProvided"
	/// username field is empty
	/// English String: "You must enter a username."
	/// </summary>
	public override string ResponseUsernameNotProvided => "ì‚¬ìš©ìž ì´ë¦„ì„ ìž…ë ¥í•´ì•¼ í•©ë‹ˆë‹¤.";

	/// <summary>
	/// Key: "Response.UseSocialSignOn"
	/// Unable to login. Please use Social Network sign on.
	/// English String: "Unable to login. Please use Social Network sign on."
	/// </summary>
	public override string ResponseUseSocialSignOn => "ë¡œê·¸ì¸ ë¶ˆê°€. ì†Œì…œ ë„¤íŠ¸ì›Œí¬ë¡œ ë¡œê·¸ì¸í•˜ì„¸ìš”.";

	/// <summary>
	/// Key: "WeChat.AntiAddictionText"
	/// English String: "Boycott bad games, refuse pirated games. Be aware of self-defense and being deceived. Playing games is good for your brain, but too much game play can harm your health. Manage your time well and enjoy a healthy lifestyle."
	/// </summary>
	public override string WeChatAntiAddictionText => "ê±´ì „í•˜ì§€ ì•Šì€ ê²Œìž„ê³¼ ì €ìž‘ê¶Œ ë¬¸ì œê°€ ìžˆëŠ” ê²Œìž„ì€ í”Œë ˆì´í•˜ì§€ ë§ˆì‹œê³ , ì‚¬ê¸° í–‰ìœ„ì— ì—°ë£¨ë˜ì§€ ì•Šë„ë¡ ìŠ¤ìŠ¤ë¡œë¥¼ ë³´í˜¸í•˜ì„¸ìš”. ê²Œìž„ì€ ë‘ë‡Œ ë°œë‹¬ì— ë„ì›€ì´ ë˜ì§€ë§Œ, ì§€ë‚˜ì¹œ ê²Œìž„ í”Œë ˆì´ëŠ” ê±´ê°•ì— ì¢‹ì§€ ì•ŠìŠµë‹ˆë‹¤. í”Œë ˆì´ ì‹œê°„ì„ ìž˜ ì¡°ì ˆí•´ì„œ ê±´ê°•í•˜ê²Œ ê²Œìž„ì„ ì¦ê¸°ì„¸ìš”.";

	/// <summary>
	/// Key: "WeChat.RealNameNotVerified"
	/// English String: "Your WeChat is not real-name verified. Please use a real-name verified WeChat account and try again. Please visit https://jiazhang.qq.com/zk/home.html"
	/// </summary>
	public override string WeChatRealNameNotVerified => "ì‹¤ëª… ì¸ì¦ì´ ë˜ì§€ ì•Šì€ WeChat ê³„ì •ì´ì—ìš”. ì‹¤ëª… ì¸ì¦ëœ WeChat ê³„ì •ìœ¼ë¡œ ë‹¤ì‹œ ì‹œë„í•´ì•¼ í•´ìš”. ë‹¤ìŒ ë§í¬ë¥¼ ë°©ë¬¸í•´ ì£¼ì„¸ìš”. https://jiazhang.qq.com/zk/home.html";

	public LoginResources_ko_kr(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionCancel()
	{
		return "ì·¨ì†Œ";
	}

	protected override string _GetTemplateForActionFacebook()
	{
		return "Facebook:";
	}

	protected override string _GetTemplateForActionForgotPasswordOrUsernameQuestion()
	{
		return "ë¹„ë°€ë²ˆí˜¸ ë˜ëŠ” ì‚¬ìš©ìž ì´ë¦„ì„ ìžŠìœ¼ì…¨ë‚˜ìš”?";
	}

	protected override string _GetTemplateForActionForgotPasswordOrUsernameQuestionCapitalized()
	{
		return "ë¹„ë°€ë²ˆí˜¸ ë˜ëŠ” ì‚¬ìš©ìž ì´ë¦„ì„ ìžŠìœ¼ì…¨ë‚˜ìš”?";
	}

	protected override string _GetTemplateForActionLogin()
	{
		return "ë¡œê·¸ì¸";
	}

	protected override string _GetTemplateForActionLogInCapitalized()
	{
		return "ë¡œê·¸ì¸";
	}

	protected override string _GetTemplateForActionOk()
	{
		return "í™•ì¸";
	}

	protected override string _GetTemplateForActionPlayAsGuest()
	{
		return "ê²ŒìŠ¤íŠ¸ë¡œ í”Œë ˆì´";
	}

	protected override string _GetTemplateForActionResend()
	{
		return "ìž¬ì „ì†¡";
	}

	protected override string _GetTemplateForActionResendEmail()
	{
		return "ì´ë©”ì¼ ìž¬ì „ì†¡";
	}

	protected override string _GetTemplateForActionSendVerificationEmail()
	{
		return "ì¸ì¦ ì´ë©”ì¼ ë³´ë‚´ê¸°";
	}

	protected override string _GetTemplateForActionSignIn()
	{
		return "ë¡œê·¸ì¸";
	}

	protected override string _GetTemplateForActionSignInWithFacebook()
	{
		return "Facebookìœ¼ë¡œ ë¡œê·¸ì¸";
	}

	protected override string _GetTemplateForActionSignUp()
	{
		return "íšŒì›ê°€ìž…";
	}

	protected override string _GetTemplateForActionSignUpCapitalized()
	{
		return "íšŒì›ê°€ìž…";
	}

	protected override string _GetTemplateForActionWeChatLogin()
	{
		return "WeChat ë¡œê·¸ì¸";
	}

	protected override string _GetTemplateForHeadingLogin()
	{
		return "ë¡œê·¸ì¸";
	}

	protected override string _GetTemplateForHeadingLoginRoblox()
	{
		return "Robloxì— ë¡œê·¸ì¸";
	}

	protected override string _GetTemplateForHeadingSignUpMakeFriends()
	{
		return "íšŒì›ê°€ìž…í•˜ì…”ì„œ ê²Œìž„ë„ ë§Œë“¤ê³  ì¹œêµ¬ë„ ì‚¬ê·€ì–´ ë³´ì„¸ìš”";
	}

	protected override string _GetTemplateForLabelAccountNotNeeded()
	{
		return "ê³„ì •ì´ ì—†ì–´ë„ Robloxë¥¼ ì¦ê¸¸ ìˆ˜ ìžˆì–´ìš”";
	}

	protected override string _GetTemplateForLabelEmailNeedsVerification()
	{
		return "ì´ë©”ì¼ ì¸ì¦ì´ í•„ìš”í•©ë‹ˆë‹¤";
	}

	protected override string _GetTemplateForLabelFacebookCreatePasswordWarning()
	{
		return "Facebookìœ¼ë¡œ ë¡œê·¸ì¸í•œ ê²½ìš°, ë¹„ë°€ë²ˆí˜¸ë¥¼ ì„¤ì •í•´ì•¼ í•©ë‹ˆë‹¤.";
	}

	protected override string _GetTemplateForLabelForgotUsernamePassword()
	{
		return "ì‚¬ìš©ìž ì´ë¦„/ë¹„ë°€ë²ˆí˜¸ë¥¼ ìžŠìœ¼ì…¨ë‚˜ìš”?";
	}

	/// <summary>
	/// Key: "Label.GreetingForNewAccount"
	/// Shown when a username doesn't exist on the login page to invite to create a new account.
	/// English String: "Nice to meet you, {username}. {linkStartSignup}Let's make an account! {linkEndSignup}"
	/// </summary>
	public override string LabelGreetingForNewAccount(string username, string linkStartSignup, string linkEndSignup)
	{
		return $"{username} ë‹˜, ì•ˆë…•í•˜ì„¸ìš”. {linkStartSignup}ê³„ì •ì„ ë§Œë“œì„¸ìš”! {linkEndSignup}";
	}

	protected override string _GetTemplateForLabelGreetingForNewAccount()
	{
		return "{username} ë‹˜, ì•ˆë…•í•˜ì„¸ìš”. {linkStartSignup}ê³„ì •ì„ ë§Œë“œì„¸ìš”! {linkEndSignup}";
	}

	protected override string _GetTemplateForLabelLearnMore()
	{
		return "ë” ì•Œì•„ë³´ê¸°";
	}

	protected override string _GetTemplateForLabelLoggingInSpinnerText()
	{
		return "ë¡œê·¸ì¸ ì¤‘...";
	}

	protected override string _GetTemplateForLabelLogin()
	{
		return "ë¡œê·¸ì¸";
	}

	protected override string _GetTemplateForLabelLoginWithYour()
	{
		return "ë‹¤ìŒìœ¼ë¡œ ë¡œê·¸ì¸";
	}

	protected override string _GetTemplateForLabelNoAccount()
	{
		return "ê³„ì •ì´ ì—†ìœ¼ì‹ ê°€ìš”?";
	}

	protected override string _GetTemplateForLabelNonAMemberQuestion()
	{
		return "íšŒì›ì´ ì•„ë‹ˆì‹ ê°€ìš”?";
	}

	protected override string _GetTemplateForLabelNotReceived()
	{
		return "ì´ë©”ì¼ì„ ë°›ì§€ ëª»í•˜ì…¨ë‚˜ìš”?";
	}

	protected override string _GetTemplateForLabelOr()
	{
		return "ë˜ëŠ”";
	}

	protected override string _GetTemplateForLabelPassword()
	{
		return "ë¹„ë°€ë²ˆí˜¸";
	}

	protected override string _GetTemplateForLabelPasswordWithColumn()
	{
		return "ë¹„ë°€ë²ˆí˜¸:";
	}

	protected override string _GetTemplateForLabelStartPlaying()
	{
		return "ê²ŒìŠ¤íŠ¸ ëª¨ë“œë¡œ ì§€ê¸ˆ ê²Œìž„ì„ ì‹œìž‘í•´ë³´ì„¸ìš”!";
	}

	protected override string _GetTemplateForLabelUnverifiedEmailInstructions()
	{
		return "ì´ë©”ì¼ë¡œ ë¡œê·¸ì¸í•˜ë ¤ë©´ ë¨¼ì € ì¸ì¦í•´ì•¼ í•©ë‹ˆë‹¤. ì‚¬ìš©ìž ì´ë¦„ìœ¼ë¡œë„ ë¡œê·¸ì¸í•  ìˆ˜ ìžˆì–´ìš”.";
	}

	protected override string _GetTemplateForLabelUsername()
	{
		return "ì‚¬ìš©ìž ì´ë¦„";
	}

	protected override string _GetTemplateForLabelUsernameEmail()
	{
		return "ì‚¬ìš©ìž ì´ë¦„/ì´ë©”ì¼";
	}

	protected override string _GetTemplateForLabelUsernameEmailPhone()
	{
		return "ì‚¬ìš©ìž ì´ë¦„/ì´ë©”ì¼/ì „í™”ë²ˆí˜¸";
	}

	protected override string _GetTemplateForLabelUsernamePhone()
	{
		return "ì‚¬ìš©ìž ì´ë¦„/ì „í™”ë²ˆí˜¸";
	}

	protected override string _GetTemplateForLabelUsernameWithColumn()
	{
		return "ì‚¬ìš©ìž ì´ë¦„:";
	}

	protected override string _GetTemplateForLabelVerificationEmailSent()
	{
		return "ì¸ì¦ ì´ë©”ì¼ ì „ì†¡ ì™„ë£Œ!";
	}

	protected override string _GetTemplateForLabelWeChatAntiAddictionText()
	{
		return "ê±´ì „í•˜ì§€ ì•Šì€ ê²Œìž„ê³¼ ì €ìž‘ê¶Œ ë¬¸ì œê°€ ìžˆëŠ” ê²Œìž„ì€ í”Œë ˆì´í•˜ì§€ ë§ˆì‹œê³ , ì‚¬ê¸° í–‰ìœ„ì— ì—°ë£¨ë˜ì§€ ì•Šë„ë¡ ìŠ¤ìŠ¤ë¡œë¥¼ ë³´í˜¸í•˜ì„¸ìš”. ê²Œìž„ì€ ë‘ë‡Œ ë°œë‹¬ì— ë„ì›€ì´ ë˜ì§€ë§Œ, ì§€ë‚˜ì¹œ ê²Œìž„ í”Œë ˆì´ëŠ” ê±´ê°•ì— ì¢‹ì§€ ì•ŠìŠµë‹ˆë‹¤. í”Œë ˆì´ ì‹œê°„ì„ ìž˜ ì¡°ì ˆí•´ì„œ ê±´ê°•í•˜ê²Œ ê²Œìž„ì„ ì¦ê¸°ì„¸ìš”.";
	}

	protected override string _GetTemplateForMessageUnknownErrorTryAgain()
	{
		return "ì•Œ ìˆ˜ ì—†ëŠ” ì˜¤ë¥˜ê°€ ë°œìƒí–ˆìŠµë‹ˆë‹¤.\u00a0ë‚˜ì¤‘ì— ë‹¤ì‹œ ì‹œë„í•˜ì„¸ìš”.";
	}

	protected override string _GetTemplateForMessageUsernameAndPasswordRequired()
	{
		return "ì‚¬ìš©ìž ì´ë¦„ ë° ë¹„ë°€ë²ˆí˜¸ê°€ í•„ìš”í•©ë‹ˆë‹¤";
	}

	protected override string _GetTemplateForResponseAccountIssueErrorContactSupport()
	{
		return "ê³„ì • ì˜¤ë¥˜.\u00a0ê³ ê°ì§€ì›ìœ¼ë¡œ ë¬¸ì˜í•˜ì„¸ìš”.";
	}

	protected override string _GetTemplateForResponseAccountLockedRequestReset()
	{
		return "ê³„ì •ì´ ìž ê²¼ìŠµë‹ˆë‹¤. ë¹„ë°€ë²ˆí˜¸ ìž¬ì„¤ì •ì„ ìš”ì²­í•˜ì„¸ìš”.";
	}

	protected override string _GetTemplateForResponseAccountNotFound()
	{
		return "ê³„ì •ì„ ì°¾ì„ ìˆ˜ ì—†ìŠµë‹ˆë‹¤. ë‹¤ì‹œ ì‹œë„í•˜ì„¸ìš”.";
	}

	protected override string _GetTemplateForResponseEmailLinkedToMultipleAccountsLoginWithUsername()
	{
		return "ì´ë©”ì¼ì´ 1ê°œ ì´ìƒì˜ ì‚¬ìš©ìž ì´ë¦„ê³¼ ì—°ê²°ë˜ì–´ ìžˆìŠµë‹ˆë‹¤. ì‚¬ìš©ìž ì´ë¦„ìœ¼ë¡œ ë¡œê·¸ì¸í•˜ì„¸ìš”.";
	}

	protected override string _GetTemplateForResponseEmailSent()
	{
		return "ì´ë©”ì¼ ì „ì†¡ ì™„ë£Œ!";
	}

	protected override string _GetTemplateForResponseIncorrectEmailOrPassword()
	{
		return "ì´ë©”ì¼ ë˜ëŠ” ë¹„ë°€ë²ˆí˜¸ê°€ ì¼ì¹˜í•˜ì§€ ì•ŠìŠµë‹ˆë‹¤.";
	}

	protected override string _GetTemplateForResponseIncorrectPhoneOrPassword()
	{
		return "ì „í™”ë²ˆí˜¸ ë˜ëŠ” ë¹„ë°€ë²ˆí˜¸ê°€ ì¼ì¹˜í•˜ì§€ ì•ŠìŠµë‹ˆë‹¤.";
	}

	protected override string _GetTemplateForResponseIncorrectUsernamePassword()
	{
		return "ì‚¬ìš©ìž ì´ë¦„ ë˜ëŠ” ë¹„ë°€ë²ˆí˜¸ê°€ ì¼ì¹˜í•˜ì§€ ì•ŠìŠµë‹ˆë‹¤.";
	}

	protected override string _GetTemplateForResponseLoginWithUsername()
	{
		return "ì˜¤ë¥˜ê°€ ë°œìƒí–ˆì–´ìš”. ì‚¬ìš©ìž ì´ë¦„ìœ¼ë¡œ ë¡œê·¸ì¸í•˜ì„¸ìš”.";
	}

	protected override string _GetTemplateForResponsePasswordNotProvided()
	{
		return "ë¹„ë°€ë²ˆí˜¸ë¥¼ ìž…ë ¥í•´ì•¼ í•©ë‹ˆë‹¤.";
	}

	protected override string _GetTemplateForResponseTooManyAttemptsPleaseWait()
	{
		return "ì‹œë„ ê°€ëŠ¥ íšŸìˆ˜ë¥¼ ì´ˆê³¼í–ˆìŠµë‹ˆë‹¤. ìž ì‹œ ê¸°ë‹¤ë ¤ì£¼ì„¸ìš”.";
	}

	protected override string _GetTemplateForResponseUnknownError()
	{
		return "ì•Œ ìˆ˜ ì—†ëŠ” ì˜¤ë¥˜";
	}

	protected override string _GetTemplateForResponseUnknownLoginError()
	{
		return "ì•Œ ìˆ˜ ì—†ëŠ” ë¡œê·¸ì¸ ì‹¤íŒ¨.";
	}

	protected override string _GetTemplateForResponseUnverifiedEmailLoginWithUsername()
	{
		return "ì¸ì¦ë˜ì§€ ì•Šì€ ì´ë©”ì¼ìž…ë‹ˆë‹¤. ì‚¬ìš©ìž ì´ë¦„ìœ¼ë¡œ ë¡œê·¸ì¸í•˜ì„¸ìš”.";
	}

	protected override string _GetTemplateForResponseUnverifiedPhoneLoginWithUsername()
	{
		return "ì¸ì¦ë˜ì§€ ì•Šì€ ì „í™”ë²ˆí˜¸ìž…ë‹ˆë‹¤. ì‚¬ìš©ìž ì´ë¦„ìœ¼ë¡œ ë¡œê·¸ì¸í•˜ì„¸ìš”.";
	}

	protected override string _GetTemplateForResponseUsernameNotProvided()
	{
		return "ì‚¬ìš©ìž ì´ë¦„ì„ ìž…ë ¥í•´ì•¼ í•©ë‹ˆë‹¤.";
	}

	protected override string _GetTemplateForResponseUseSocialSignOn()
	{
		return "ë¡œê·¸ì¸ ë¶ˆê°€. ì†Œì…œ ë„¤íŠ¸ì›Œí¬ë¡œ ë¡œê·¸ì¸í•˜ì„¸ìš”.";
	}

	/// <summary>
	/// Key: "Response.WeChatNotRealNameVerified"
	/// English String: "Your WeChat is not real-name verified. Please use a real-name verified WeChat account and try again. Please visit {url}"
	/// </summary>
	public override string ResponseWeChatNotRealNameVerified(string url)
	{
		return $"ì‹¤ëª… ì¸ì¦ì´ ë˜ì§€ ì•Šì€ WeChat ê³„ì •ì´ì—ìš”. ì‹¤ëª… ì¸ì¦ëœ WeChat ê³„ì •ìœ¼ë¡œ ë‹¤ì‹œ ì‹œë„í•´ ì£¼ì„¸ìš”. ë‹¤ìŒ ë§í¬ë¥¼ ë°©ë¬¸í•˜ì„¸ìš”. {url}";
	}

	protected override string _GetTemplateForResponseWeChatNotRealNameVerified()
	{
		return "ì‹¤ëª… ì¸ì¦ì´ ë˜ì§€ ì•Šì€ WeChat ê³„ì •ì´ì—ìš”. ì‹¤ëª… ì¸ì¦ëœ WeChat ê³„ì •ìœ¼ë¡œ ë‹¤ì‹œ ì‹œë„í•´ ì£¼ì„¸ìš”. ë‹¤ìŒ ë§í¬ë¥¼ ë°©ë¬¸í•˜ì„¸ìš”. {url}";
	}

	protected override string _GetTemplateForWeChatAntiAddictionText()
	{
		return "ê±´ì „í•˜ì§€ ì•Šì€ ê²Œìž„ê³¼ ì €ìž‘ê¶Œ ë¬¸ì œê°€ ìžˆëŠ” ê²Œìž„ì€ í”Œë ˆì´í•˜ì§€ ë§ˆì‹œê³ , ì‚¬ê¸° í–‰ìœ„ì— ì—°ë£¨ë˜ì§€ ì•Šë„ë¡ ìŠ¤ìŠ¤ë¡œë¥¼ ë³´í˜¸í•˜ì„¸ìš”. ê²Œìž„ì€ ë‘ë‡Œ ë°œë‹¬ì— ë„ì›€ì´ ë˜ì§€ë§Œ, ì§€ë‚˜ì¹œ ê²Œìž„ í”Œë ˆì´ëŠ” ê±´ê°•ì— ì¢‹ì§€ ì•ŠìŠµë‹ˆë‹¤. í”Œë ˆì´ ì‹œê°„ì„ ìž˜ ì¡°ì ˆí•´ì„œ ê±´ê°•í•˜ê²Œ ê²Œìž„ì„ ì¦ê¸°ì„¸ìš”.";
	}

	protected override string _GetTemplateForWeChatRealNameNotVerified()
	{
		return "ì‹¤ëª… ì¸ì¦ì´ ë˜ì§€ ì•Šì€ WeChat ê³„ì •ì´ì—ìš”. ì‹¤ëª… ì¸ì¦ëœ WeChat ê³„ì •ìœ¼ë¡œ ë‹¤ì‹œ ì‹œë„í•´ì•¼ í•´ìš”. ë‹¤ìŒ ë§í¬ë¥¼ ë°©ë¬¸í•´ ì£¼ì„¸ìš”. https://jiazhang.qq.com/zk/home.html";
	}
}


}
