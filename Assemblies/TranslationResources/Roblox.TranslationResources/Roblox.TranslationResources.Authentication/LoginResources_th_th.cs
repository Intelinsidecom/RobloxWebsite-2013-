namespace Roblox.TranslationResources.Authentication;

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
	public override string ActionCancel => "ยกเล\u0e34ก";

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
	public override string ActionForgotPasswordOrUsernameQuestion => "ล\u0e37มรห\u0e31สผ\u0e48านหร\u0e37อช\u0e37\u0e48อผ\u0e39\u0e49ใช\u0e49?";

	/// <summary>
	/// Key: "Action.ForgotPasswordOrUsernameQuestionCapitalized"
	/// link under login form
	/// English String: "Forgot Password or Username?"
	/// </summary>
	public override string ActionForgotPasswordOrUsernameQuestionCapitalized => "ล\u0e37มรห\u0e31สผ\u0e48านหร\u0e37อช\u0e37\u0e48อผ\u0e39\u0e49ใช\u0e49?";

	/// <summary>
	/// Key: "Action.Login"
	/// English String: "Login"
	/// </summary>
	public override string ActionLogin => "เข\u0e49าส\u0e39\u0e48ระบบ";

	/// <summary>
	/// Key: "Action.LogInCapitalized"
	/// login button label. please note this is different from 'Login' or 'Log in'.
	/// English String: "Log In"
	/// </summary>
	public override string ActionLogInCapitalized => "เข\u0e49าส\u0e39\u0e48ระบบ";

	/// <summary>
	/// Key: "Action.Ok"
	/// button text
	/// English String: "OK"
	/// </summary>
	public override string ActionOk => "ตกลง";

	/// <summary>
	/// Key: "Action.PlayAsGuest"
	/// Play as Guest
	/// English String: "Play as Guest"
	/// </summary>
	public override string ActionPlayAsGuest => "เล\u0e48นในฐานะแขก";

	/// <summary>
	/// Key: "Action.Resend"
	/// button text for resending verification email
	/// English String: "Resend"
	/// </summary>
	public override string ActionResend => "ส\u0e48งอ\u0e35กคร\u0e31\u0e49ง";

	/// <summary>
	/// Key: "Action.ResendEmail"
	/// link that resends verification email to user
	/// English String: "Resend Email"
	/// </summary>
	public override string ActionResendEmail => "ส\u0e48งอ\u0e35เมลใหม\u0e48";

	/// <summary>
	/// Key: "Action.SendVerificationEmail"
	/// button user can click to send a verification link to their email
	/// English String: "Send Verification Email"
	/// </summary>
	public override string ActionSendVerificationEmail => "ส\u0e48งอ\u0e35เมลย\u0e37นย\u0e31น";

	/// <summary>
	/// Key: "Action.SignIn"
	/// Sign In button text
	/// English String: "Sign In"
	/// </summary>
	public override string ActionSignIn => "ลงช\u0e37\u0e48อเข\u0e49าใช\u0e49งาน";

	/// <summary>
	/// Key: "Action.SignInWithFacebook"
	/// Sign In with Facebook
	/// English String: "Sign In with Facebook"
	/// </summary>
	public override string ActionSignInWithFacebook => "ลงช\u0e37\u0e48อเข\u0e49าใช\u0e49งานด\u0e49วย Facebook";

	/// <summary>
	/// Key: "Action.SignUp"
	/// English String: "Sign up"
	/// </summary>
	public override string ActionSignUp => "สม\u0e31ครบ\u0e31ญช\u0e35";

	/// <summary>
	/// Key: "Action.SignUpCapitalized"
	/// link which takes user to sign up page
	/// English String: "Sign Up"
	/// </summary>
	public override string ActionSignUpCapitalized => "สม\u0e31ครบ\u0e31ญช\u0e35ผ\u0e39\u0e49ใช\u0e49";

	/// <summary>
	/// Key: "Action.WeChatLogin"
	/// button text for logging in with WeChat
	/// English String: "WeChat Login"
	/// </summary>
	public override string ActionWeChatLogin => "เข\u0e49าส\u0e39\u0e48ระบบ WeChat";

	/// <summary>
	/// Key: "Heading.Login"
	/// heading on the login page
	/// English String: "Login"
	/// </summary>
	public override string HeadingLogin => "เข\u0e49าส\u0e39\u0e48ระบบ";

	/// <summary>
	/// Key: "Heading.LoginRoblox"
	/// current login page heading
	/// English String: "Login to Roblox"
	/// </summary>
	public override string HeadingLoginRoblox => "เข\u0e49าส\u0e39\u0e48ระบบ Roblox";

	public override string HeadingSignUpMakeFriends => "สม\u0e31ครบ\u0e31ญช\u0e35เพ\u0e37\u0e48อก\u0e48อสร\u0e49างและหาเพ\u0e37\u0e48อนมากข\u0e36\u0e49น";

	/// <summary>
	/// Key: "Label.AccountNotNeeded"
	/// You don't need an account to play Roblox
	/// English String: "You don't need an account to play Roblox"
	/// </summary>
	public override string LabelAccountNotNeeded => "ค\u0e38ณไม\u0e48จำเป\u0e47นต\u0e49องม\u0e35บ\u0e31ญช\u0e35เพ\u0e37\u0e48อท\u0e35\u0e48จะเล\u0e48น Roblox";

	/// <summary>
	/// Key: "Label.EmailNeedsVerification"
	/// modal header used for prompting user they need to verify their email in order to log in with it
	/// English String: "Your email needs verification"
	/// </summary>
	public override string LabelEmailNeedsVerification => "อ\u0e35เมลของค\u0e38ณจำเป\u0e47นต\u0e49องได\u0e49ร\u0e31บการย\u0e37นย\u0e31น";

	/// <summary>
	/// Key: "Label.FacebookCreatePasswordWarning"
	/// If you have been signing in with Facebook, you must set a password.
	/// English String: "If you have been signing in with Facebook, you must set a password."
	/// </summary>
	public override string LabelFacebookCreatePasswordWarning => "หากค\u0e38ณได\u0e49ใช\u0e49การลงช\u0e37\u0e48อเข\u0e49าส\u0e39\u0e48ระบบด\u0e49วย Facebook มาก\u0e48อน ค\u0e38ณจะต\u0e49องต\u0e31\u0e49งรห\u0e31สผ\u0e48าน";

	/// <summary>
	/// Key: "Label.ForgotUsernamePassword"
	/// landing page top right link for password reset
	/// English String: "Forgot Username/Password?"
	/// </summary>
	public override string LabelForgotUsernamePassword => "ล\u0e37มช\u0e37\u0e48อผ\u0e39\u0e49ใช\u0e49/รห\u0e31สผ\u0e48านอย\u0e48างน\u0e31\u0e49นหร\u0e37อ?";

	/// <summary>
	/// Key: "Label.LearnMore"
	/// learn more link text
	/// English String: "Learn more"
	/// </summary>
	public override string LabelLearnMore => "เร\u0e35ยนร\u0e39\u0e49เพ\u0e34\u0e48มเต\u0e34ม";

	/// <summary>
	/// Key: "Label.LoggingInSpinnerText"
	/// English String: "Logging in…"
	/// </summary>
	public override string LabelLoggingInSpinnerText => "กำล\u0e31งเข\u0e49าส\u0e39\u0e48ระบบ…";

	/// <summary>
	/// Key: "Label.Login"
	/// English String: "Log in"
	/// </summary>
	public override string LabelLogin => "เข\u0e49าส\u0e39\u0e48ระบบ";

	/// <summary>
	/// Key: "Label.LoginWithYour"
	/// Label for a partition line between login with email and facebook login. Please keep the text in lowercase for roman characters.
	/// English String: "login with your"
	/// </summary>
	public override string LabelLoginWithYour => "ม\u0e35บางอย\u0e48างผ\u0e34ดปกต\u0e34 กร\u0e38ณาเข\u0e49าส\u0e39\u0e48บ\u0e31ญช\u0e35ของค\u0e38ณ";

	/// <summary>
	/// Key: "Label.NoAccount"
	/// Don't have an account?
	/// English String: "Don't have an account?"
	/// </summary>
	public override string LabelNoAccount => "ย\u0e31งไม\u0e48ม\u0e35บ\u0e31ญช\u0e35หร\u0e37อ?";

	/// <summary>
	/// Key: "Label.NonAMemberQuestion"
	/// The question heading for the section on the login page to take use to sign up page.
	/// English String: "Not a member?"
	/// </summary>
	public override string LabelNonAMemberQuestion => "ไม\u0e48ใช\u0e48สมาช\u0e34กอย\u0e48างน\u0e31\u0e49นหร\u0e37อ?";

	/// <summary>
	/// Key: "Label.NotReceived"
	/// prompt for allowing users to resend verification email
	/// English String: "Didn't receive it?"
	/// </summary>
	public override string LabelNotReceived => "ค\u0e38ณไม\u0e48ได\u0e49ร\u0e31บอ\u0e35เมลอย\u0e48างน\u0e31\u0e49นหร\u0e37อ?";

	/// <summary>
	/// Key: "Label.Or"
	/// partition between email login and facebook login
	/// English String: "Or"
	/// </summary>
	public override string LabelOr => "หร\u0e37อ";

	/// <summary>
	/// Key: "Label.Password"
	/// Password
	/// English String: "Password"
	/// </summary>
	public override string LabelPassword => "รห\u0e31สผ\u0e48าน";

	/// <summary>
	/// Key: "Label.PasswordWithColumn"
	/// label for the password field on the login page
	/// English String: "Password:"
	/// </summary>
	public override string LabelPasswordWithColumn => "รห\u0e31สผ\u0e48าน:";

	/// <summary>
	/// Key: "Label.StartPlaying"
	/// You can start playing right now, in guest mode!
	/// English String: "You can start playing right now, in guest mode!"
	/// </summary>
	public override string LabelStartPlaying => "ค\u0e38ณสามารถเร\u0e34\u0e48มต\u0e49นเล\u0e48นได\u0e49ตอนน\u0e35\u0e49เลย ในโหมดแขก!";

	/// <summary>
	/// Key: "Label.UnverifiedEmailInstructions"
	/// message shown in a modal when user logs in with unverified email
	/// English String: "To log in with your email, it must be verified. You can also log in with your username."
	/// </summary>
	public override string LabelUnverifiedEmailInstructions => "หากต\u0e49องการเข\u0e49าส\u0e39\u0e48ระบบด\u0e49วยอ\u0e35เมลของค\u0e38ณ ค\u0e38ณจะต\u0e49องทำการย\u0e37นย\u0e31นอ\u0e35เมลน\u0e31\u0e49นก\u0e48อน ค\u0e38ณย\u0e31งสามารถเข\u0e49าส\u0e39\u0e48ระบบด\u0e49วยช\u0e37\u0e48อผ\u0e39\u0e49ใช\u0e49ของค\u0e38ณได\u0e49";

	/// <summary>
	/// Key: "Label.Username"
	/// English String: "Username"
	/// </summary>
	public override string LabelUsername => "ช\u0e37\u0e48อผ\u0e39\u0e49ใช\u0e49";

	/// <summary>
	/// Key: "Label.UsernameEmail"
	/// placeholder text for input field that accepts username or email
	/// English String: "Username/Email"
	/// </summary>
	public override string LabelUsernameEmail => "ช\u0e37\u0e48อผ\u0e39\u0e49ใช\u0e49/อ\u0e35เมล";

	/// <summary>
	/// Key: "Label.UsernameEmailPhone"
	/// placeholder text for input fields that accept username, email or phone
	/// English String: "Username/Email/Phone"
	/// </summary>
	public override string LabelUsernameEmailPhone => "ช\u0e37\u0e48อผ\u0e39\u0e49ใช\u0e49/อ\u0e35เมล/หมายเลขโทรศ\u0e31พท\u0e4c";

	/// <summary>
	/// Key: "Label.UsernamePhone"
	/// placeholder text for input field that accepts username or phone
	/// English String: "Username/Phone"
	/// </summary>
	public override string LabelUsernamePhone => "ช\u0e37\u0e48อผ\u0e39\u0e49ใช\u0e49/หมายเลขโทรศ\u0e31พท\u0e4c";

	/// <summary>
	/// Key: "Label.UsernameWithColumn"
	/// label for username field on login page
	/// English String: "Username:"
	/// </summary>
	public override string LabelUsernameWithColumn => "ช\u0e37\u0e48อผ\u0e39\u0e49ใช\u0e49:";

	/// <summary>
	/// Key: "Label.VerificationEmailSent"
	/// message telling user a verification email was sent to them
	/// English String: "Verification Email Sent!"
	/// </summary>
	public override string LabelVerificationEmailSent => "ส\u0e48งอ\u0e35เมลย\u0e37นย\u0e31นแล\u0e49ว!";

	/// <summary>
	/// Key: "Label.WeChatAntiAddictionText"
	/// English String: "Boycott bad games, refuse pirated games. Be aware of self-defense and being deceived. Playing games is good for your brain, but too much game play can harm your health. Manage your time well and enjoy a healthy lifestyle."
	/// </summary>
	public override string LabelWeChatAntiAddictionText => "บอยคอตต\u0e4cเกมแย\u0e48ๆ ปฏ\u0e34เสธเกมละเม\u0e34ดล\u0e34ขส\u0e34ทธ\u0e34\u0e4c ร\u0e39\u0e49ถ\u0e36งการป\u0e49องก\u0e31นต\u0e31วและการถ\u0e39กหลอกลวง การเล\u0e48นเกมน\u0e31\u0e49นด\u0e35ต\u0e48อสมองของค\u0e38ณ แต\u0e48การเล\u0e48นเกมมากเก\u0e34นไปก\u0e47อาจเป\u0e47นอ\u0e31นตรายต\u0e48อส\u0e38ขภาพของค\u0e38ณได\u0e49 บร\u0e34หารเวลาของค\u0e38ณให\u0e49ด\u0e35 แล\u0e49วใช\u0e49ช\u0e35ว\u0e34ตท\u0e35\u0e48ม\u0e35ส\u0e38ขภาพด\u0e35";

	/// <summary>
	/// Key: "Message.UnknownErrorTryAgain"
	/// An unknown error occurred. Please try again.
	/// English String: "An unknown error occurred. Please try again."
	/// </summary>
	public override string MessageUnknownErrorTryAgain => "เก\u0e34ดข\u0e49อผ\u0e34ดพลาดท\u0e35\u0e48ไม\u0e48ทราบสาเหต\u0e38 กร\u0e38ณาลองใหม\u0e48อ\u0e35กคร\u0e31\u0e49ง";

	/// <summary>
	/// Key: "Message.UsernameAndPasswordRequired"
	/// message shown to user when they attempt to login without entering a username or password
	/// English String: "Username and password required"
	/// </summary>
	public override string MessageUsernameAndPasswordRequired => "จำเป\u0e47นต\u0e49องม\u0e35ช\u0e37\u0e48อผ\u0e39\u0e49ใช\u0e49และรห\u0e31สผ\u0e48าน";

	/// <summary>
	/// Key: "Response.AccountIssueErrorContactSupport"
	/// English String: "Account issue. Please contact Support."
	/// </summary>
	public override string ResponseAccountIssueErrorContactSupport => "ป\u0e31ญหาด\u0e49านบ\u0e31ญช\u0e35 กร\u0e38ณาต\u0e34ดต\u0e48อฝ\u0e48ายสน\u0e31บสน\u0e38น";

	/// <summary>
	/// Key: "Response.AccountLockedRequestReset"
	/// Account has been locked. Please request a password reset.
	/// English String: "Account has been locked. Please request a password reset."
	/// </summary>
	public override string ResponseAccountLockedRequestReset => "บ\u0e31ญช\u0e35ถ\u0e39กล\u0e47อค กร\u0e38ณาขอการร\u0e35เซ\u0e47ตรห\u0e31สผ\u0e48าน";

	/// <summary>
	/// Key: "Response.AccountNotFound"
	/// Account not found. Please try again.
	/// English String: "Account not found. Please try again."
	/// </summary>
	public override string ResponseAccountNotFound => "ไม\u0e48พบบ\u0e31ญช\u0e35 กร\u0e38ณาลองใหม\u0e48อ\u0e35กคร\u0e31\u0e49ง";

	/// <summary>
	/// Key: "Response.EmailLinkedToMultipleAccountsLoginWithUsername"
	/// error message displayed when user attempts to log in with an email that is linked to multiple accounts
	/// English String: "Your email is associated with more than 1 username. Please login with your username."
	/// </summary>
	public override string ResponseEmailLinkedToMultipleAccountsLoginWithUsername => "อ\u0e35เมลของค\u0e38ณเช\u0e37\u0e48อมโยงก\u0e31บช\u0e37\u0e48อผ\u0e39\u0e49ใช\u0e49มากกว\u0e48า 1 บ\u0e31ญช\u0e35 กร\u0e38ณาเข\u0e49าส\u0e39\u0e48ระบบด\u0e49วยช\u0e37\u0e48อผ\u0e39\u0e49ใช\u0e49ของค\u0e38ณ";

	/// <summary>
	/// Key: "Response.EmailSent"
	/// response telling user that a verification email has been sent to them
	/// English String: "Email sent!"
	/// </summary>
	public override string ResponseEmailSent => "ส\u0e48งอ\u0e35เมลแล\u0e49ว!";

	/// <summary>
	/// Key: "Response.IncorrectEmailOrPassword"
	/// error message displayed when user logs in with an invalid email or password
	/// English String: "Incorrect email or password."
	/// </summary>
	public override string ResponseIncorrectEmailOrPassword => "อ\u0e35เมลหร\u0e37อรห\u0e31สผ\u0e48านไม\u0e48ถ\u0e39กต\u0e49อง";

	/// <summary>
	/// Key: "Response.IncorrectPhoneOrPassword"
	/// error message displayed when user logs in with an invalid phone or password
	/// English String: "Incorrect phone or password."
	/// </summary>
	public override string ResponseIncorrectPhoneOrPassword => "หมายเลขโทรศ\u0e31พท\u0e4cหร\u0e37อรห\u0e31สผ\u0e48านไม\u0e48ถ\u0e39กต\u0e49อง";

	/// <summary>
	/// Key: "Response.IncorrectUsernamePassword"
	/// English String: "Incorrect username or password."
	/// </summary>
	public override string ResponseIncorrectUsernamePassword => "ช\u0e37\u0e48อผ\u0e39\u0e49ใช\u0e49หร\u0e37อรห\u0e31สผ\u0e48านไม\u0e48ถ\u0e39กต\u0e49อง";

	/// <summary>
	/// Key: "Response.LoginWithUsername"
	/// error message shown when user attempts to login with method other than username and an error occurred
	/// English String: "Something went wrong. Please login with your username."
	/// </summary>
	public override string ResponseLoginWithUsername => "ม\u0e35บางอย\u0e48างผ\u0e34ดปกต\u0e34 กร\u0e38ณาเข\u0e49าส\u0e39\u0e48ระบบด\u0e49วยช\u0e37\u0e48อผ\u0e39\u0e49ใช\u0e49ของค\u0e38ณ";

	/// <summary>
	/// Key: "Response.PasswordNotProvided"
	/// password field is empty
	/// English String: "You must enter a password."
	/// </summary>
	public override string ResponsePasswordNotProvided => "ค\u0e38ณจะต\u0e49องป\u0e49อนรห\u0e31สผ\u0e48าน";

	/// <summary>
	/// Key: "Response.TooManyAttemptsPleaseWait"
	/// English String: "Too many attempts. Please wait a bit."
	/// </summary>
	public override string ResponseTooManyAttemptsPleaseWait => "ม\u0e35การดำเน\u0e34นการซ\u0e49ำมากเก\u0e34นไป กร\u0e38ณารอส\u0e31กคร\u0e39\u0e48";

	/// <summary>
	/// Key: "Response.UnknownError"
	/// English String: "Unknown Error"
	/// </summary>
	public override string ResponseUnknownError => "ข\u0e49อผ\u0e34ดพลาดท\u0e35\u0e48ไม\u0e48ทราบสาเหต\u0e38";

	/// <summary>
	/// Key: "Response.UnknownLoginError"
	/// Unknown login failure.
	/// English String: "Unknown login failure."
	/// </summary>
	public override string ResponseUnknownLoginError => "เก\u0e34ดความผ\u0e34ดพลาดในการเข\u0e49าส\u0e39\u0e48ระบบท\u0e35\u0e48ไม\u0e48ทราบสาเหต\u0e38";

	/// <summary>
	/// Key: "Response.UnverifiedEmailLoginWithUsername"
	/// error message shown when user attempts to login with unverified email
	/// English String: "Your email is not verified. Please login with your username."
	/// </summary>
	public override string ResponseUnverifiedEmailLoginWithUsername => "อ\u0e35เมลของค\u0e38ณไม\u0e48ได\u0e49ร\u0e31บการตรวจสอบความถ\u0e39กต\u0e49อง กร\u0e38ณาเข\u0e49าส\u0e39\u0e48ระบบด\u0e49วยช\u0e37\u0e48อผ\u0e39\u0e49ใช\u0e49ของค\u0e38ณ";

	/// <summary>
	/// Key: "Response.UnverifiedPhoneLoginWithUsername"
	/// error message shown when user attempts to login with an unverified phone number
	/// English String: "Your phone is not verified. Please login with your username."
	/// </summary>
	public override string ResponseUnverifiedPhoneLoginWithUsername => "หมายเลขโทรศ\u0e31พท\u0e4cของค\u0e38ณไม\u0e48ได\u0e49ร\u0e31บการตรวจสอบความถ\u0e39กต\u0e49อง กร\u0e38ณาเข\u0e49าส\u0e39\u0e48ระบบด\u0e49วยช\u0e37\u0e48อผ\u0e39\u0e49ใช\u0e49ของค\u0e38ณ";

	/// <summary>
	/// Key: "Response.UsernameNotProvided"
	/// username field is empty
	/// English String: "You must enter a username."
	/// </summary>
	public override string ResponseUsernameNotProvided => "ค\u0e38ณจะต\u0e49องป\u0e49อนช\u0e37\u0e48อผ\u0e39\u0e49ใช\u0e49";

	/// <summary>
	/// Key: "Response.UseSocialSignOn"
	/// Unable to login. Please use Social Network sign on.
	/// English String: "Unable to login. Please use Social Network sign on."
	/// </summary>
	public override string ResponseUseSocialSignOn => "ไม\u0e48สามารถเข\u0e49าส\u0e39\u0e48ระบบได\u0e49 กร\u0e38ณาใช\u0e49บ\u0e31ญช\u0e35โซเช\u0e35ยลเน\u0e47ตเว\u0e34ร\u0e4cคเพ\u0e37\u0e48อลงช\u0e37\u0e48อเข\u0e49าใช\u0e49งาน";

	/// <summary>
	/// Key: "WeChat.AntiAddictionText"
	/// English String: "Boycott bad games, refuse pirated games. Be aware of self-defense and being deceived. Playing games is good for your brain, but too much game play can harm your health. Manage your time well and enjoy a healthy lifestyle."
	/// </summary>
	public override string WeChatAntiAddictionText => "บอยคอตต\u0e4cเกมแย\u0e48ๆ ปฏ\u0e34เสธเกมละเม\u0e34ดล\u0e34ขส\u0e34ทธ\u0e34\u0e4c ร\u0e39\u0e49ถ\u0e36งการป\u0e49องก\u0e31นต\u0e31ว และการถ\u0e39กหลอกลวง การเล\u0e48นเกมน\u0e31\u0e49นด\u0e35ต\u0e48อสมองของค\u0e38ณ แต\u0e48การเล\u0e48นเกมมากเก\u0e34นไปก\u0e47อาจเป\u0e47นอ\u0e31นตรายต\u0e48อส\u0e38ขภาพของค\u0e38ณได\u0e49 บร\u0e34หารเวลาของค\u0e38ณให\u0e49ด\u0e35 แล\u0e49วใช\u0e49ช\u0e35ว\u0e34ตท\u0e35\u0e48ม\u0e35ส\u0e38ขภาพด\u0e35";

	/// <summary>
	/// Key: "WeChat.RealNameNotVerified"
	/// English String: "Your WeChat is not real-name verified. Please use a real-name verified WeChat account and try again. Please visit https://jiazhang.qq.com/zk/home.html"
	/// </summary>
	public override string WeChatRealNameNotVerified => "บ\u0e31ญช\u0e35 WeChat ของค\u0e38ณย\u0e31งไม\u0e48ได\u0e49ทำการย\u0e37นย\u0e31นช\u0e37\u0e48อจร\u0e34ง กร\u0e38ณาทำการย\u0e37นย\u0e31นช\u0e37\u0e48อจร\u0e34งสำหร\u0e31บบ\u0e31ญช\u0e35 WeChat แล\u0e49วลองใหม\u0e48อ\u0e35กคร\u0e31\u0e49ง กร\u0e38ณาไปท\u0e35\u0e48 https://jiazhang.qq.com/zk/home.html";

	public LoginResources_th_th(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionCancel()
	{
		return "ยกเล\u0e34ก";
	}

	protected override string _GetTemplateForActionFacebook()
	{
		return "Facebook";
	}

	protected override string _GetTemplateForActionForgotPasswordOrUsernameQuestion()
	{
		return "ล\u0e37มรห\u0e31สผ\u0e48านหร\u0e37อช\u0e37\u0e48อผ\u0e39\u0e49ใช\u0e49?";
	}

	protected override string _GetTemplateForActionForgotPasswordOrUsernameQuestionCapitalized()
	{
		return "ล\u0e37มรห\u0e31สผ\u0e48านหร\u0e37อช\u0e37\u0e48อผ\u0e39\u0e49ใช\u0e49?";
	}

	protected override string _GetTemplateForActionLogin()
	{
		return "เข\u0e49าส\u0e39\u0e48ระบบ";
	}

	protected override string _GetTemplateForActionLogInCapitalized()
	{
		return "เข\u0e49าส\u0e39\u0e48ระบบ";
	}

	protected override string _GetTemplateForActionOk()
	{
		return "ตกลง";
	}

	protected override string _GetTemplateForActionPlayAsGuest()
	{
		return "เล\u0e48นในฐานะแขก";
	}

	protected override string _GetTemplateForActionResend()
	{
		return "ส\u0e48งอ\u0e35กคร\u0e31\u0e49ง";
	}

	protected override string _GetTemplateForActionResendEmail()
	{
		return "ส\u0e48งอ\u0e35เมลใหม\u0e48";
	}

	protected override string _GetTemplateForActionSendVerificationEmail()
	{
		return "ส\u0e48งอ\u0e35เมลย\u0e37นย\u0e31น";
	}

	protected override string _GetTemplateForActionSignIn()
	{
		return "ลงช\u0e37\u0e48อเข\u0e49าใช\u0e49งาน";
	}

	protected override string _GetTemplateForActionSignInWithFacebook()
	{
		return "ลงช\u0e37\u0e48อเข\u0e49าใช\u0e49งานด\u0e49วย Facebook";
	}

	protected override string _GetTemplateForActionSignUp()
	{
		return "สม\u0e31ครบ\u0e31ญช\u0e35";
	}

	protected override string _GetTemplateForActionSignUpCapitalized()
	{
		return "สม\u0e31ครบ\u0e31ญช\u0e35ผ\u0e39\u0e49ใช\u0e49";
	}

	protected override string _GetTemplateForActionWeChatLogin()
	{
		return "เข\u0e49าส\u0e39\u0e48ระบบ WeChat";
	}

	protected override string _GetTemplateForHeadingLogin()
	{
		return "เข\u0e49าส\u0e39\u0e48ระบบ";
	}

	protected override string _GetTemplateForHeadingLoginRoblox()
	{
		return "เข\u0e49าส\u0e39\u0e48ระบบ Roblox";
	}

	protected override string _GetTemplateForHeadingSignUpMakeFriends()
	{
		return "สม\u0e31ครบ\u0e31ญช\u0e35เพ\u0e37\u0e48อก\u0e48อสร\u0e49างและหาเพ\u0e37\u0e48อนมากข\u0e36\u0e49น";
	}

	protected override string _GetTemplateForLabelAccountNotNeeded()
	{
		return "ค\u0e38ณไม\u0e48จำเป\u0e47นต\u0e49องม\u0e35บ\u0e31ญช\u0e35เพ\u0e37\u0e48อท\u0e35\u0e48จะเล\u0e48น Roblox";
	}

	protected override string _GetTemplateForLabelEmailNeedsVerification()
	{
		return "อ\u0e35เมลของค\u0e38ณจำเป\u0e47นต\u0e49องได\u0e49ร\u0e31บการย\u0e37นย\u0e31น";
	}

	protected override string _GetTemplateForLabelFacebookCreatePasswordWarning()
	{
		return "หากค\u0e38ณได\u0e49ใช\u0e49การลงช\u0e37\u0e48อเข\u0e49าส\u0e39\u0e48ระบบด\u0e49วย Facebook มาก\u0e48อน ค\u0e38ณจะต\u0e49องต\u0e31\u0e49งรห\u0e31สผ\u0e48าน";
	}

	protected override string _GetTemplateForLabelForgotUsernamePassword()
	{
		return "ล\u0e37มช\u0e37\u0e48อผ\u0e39\u0e49ใช\u0e49/รห\u0e31สผ\u0e48านอย\u0e48างน\u0e31\u0e49นหร\u0e37อ?";
	}

	/// <summary>
	/// Key: "Label.GreetingForNewAccount"
	/// Shown when a username doesn't exist on the login page to invite to create a new account.
	/// English String: "Nice to meet you, {username}. {linkStartSignup}Let's make an account! {linkEndSignup}"
	/// </summary>
	public override string LabelGreetingForNewAccount(string username, string linkStartSignup, string linkEndSignup)
	{
		return $"ย\u0e34นด\u0e35ท\u0e35\u0e48ได\u0e49ร\u0e39\u0e49จ\u0e31ก ค\u0e38ณ {username} {linkStartSignup}เรามาสร\u0e49างบ\u0e31ญช\u0e35ก\u0e31น! {linkEndSignup}";
	}

	protected override string _GetTemplateForLabelGreetingForNewAccount()
	{
		return "ย\u0e34นด\u0e35ท\u0e35\u0e48ได\u0e49ร\u0e39\u0e49จ\u0e31ก ค\u0e38ณ {username} {linkStartSignup}เรามาสร\u0e49างบ\u0e31ญช\u0e35ก\u0e31น! {linkEndSignup}";
	}

	protected override string _GetTemplateForLabelLearnMore()
	{
		return "เร\u0e35ยนร\u0e39\u0e49เพ\u0e34\u0e48มเต\u0e34ม";
	}

	protected override string _GetTemplateForLabelLoggingInSpinnerText()
	{
		return "กำล\u0e31งเข\u0e49าส\u0e39\u0e48ระบบ…";
	}

	protected override string _GetTemplateForLabelLogin()
	{
		return "เข\u0e49าส\u0e39\u0e48ระบบ";
	}

	protected override string _GetTemplateForLabelLoginWithYour()
	{
		return "ม\u0e35บางอย\u0e48างผ\u0e34ดปกต\u0e34 กร\u0e38ณาเข\u0e49าส\u0e39\u0e48บ\u0e31ญช\u0e35ของค\u0e38ณ";
	}

	protected override string _GetTemplateForLabelNoAccount()
	{
		return "ย\u0e31งไม\u0e48ม\u0e35บ\u0e31ญช\u0e35หร\u0e37อ?";
	}

	protected override string _GetTemplateForLabelNonAMemberQuestion()
	{
		return "ไม\u0e48ใช\u0e48สมาช\u0e34กอย\u0e48างน\u0e31\u0e49นหร\u0e37อ?";
	}

	protected override string _GetTemplateForLabelNotReceived()
	{
		return "ค\u0e38ณไม\u0e48ได\u0e49ร\u0e31บอ\u0e35เมลอย\u0e48างน\u0e31\u0e49นหร\u0e37อ?";
	}

	protected override string _GetTemplateForLabelOr()
	{
		return "หร\u0e37อ";
	}

	protected override string _GetTemplateForLabelPassword()
	{
		return "รห\u0e31สผ\u0e48าน";
	}

	protected override string _GetTemplateForLabelPasswordWithColumn()
	{
		return "รห\u0e31สผ\u0e48าน:";
	}

	protected override string _GetTemplateForLabelStartPlaying()
	{
		return "ค\u0e38ณสามารถเร\u0e34\u0e48มต\u0e49นเล\u0e48นได\u0e49ตอนน\u0e35\u0e49เลย ในโหมดแขก!";
	}

	protected override string _GetTemplateForLabelUnverifiedEmailInstructions()
	{
		return "หากต\u0e49องการเข\u0e49าส\u0e39\u0e48ระบบด\u0e49วยอ\u0e35เมลของค\u0e38ณ ค\u0e38ณจะต\u0e49องทำการย\u0e37นย\u0e31นอ\u0e35เมลน\u0e31\u0e49นก\u0e48อน ค\u0e38ณย\u0e31งสามารถเข\u0e49าส\u0e39\u0e48ระบบด\u0e49วยช\u0e37\u0e48อผ\u0e39\u0e49ใช\u0e49ของค\u0e38ณได\u0e49";
	}

	protected override string _GetTemplateForLabelUsername()
	{
		return "ช\u0e37\u0e48อผ\u0e39\u0e49ใช\u0e49";
	}

	protected override string _GetTemplateForLabelUsernameEmail()
	{
		return "ช\u0e37\u0e48อผ\u0e39\u0e49ใช\u0e49/อ\u0e35เมล";
	}

	protected override string _GetTemplateForLabelUsernameEmailPhone()
	{
		return "ช\u0e37\u0e48อผ\u0e39\u0e49ใช\u0e49/อ\u0e35เมล/หมายเลขโทรศ\u0e31พท\u0e4c";
	}

	protected override string _GetTemplateForLabelUsernamePhone()
	{
		return "ช\u0e37\u0e48อผ\u0e39\u0e49ใช\u0e49/หมายเลขโทรศ\u0e31พท\u0e4c";
	}

	protected override string _GetTemplateForLabelUsernameWithColumn()
	{
		return "ช\u0e37\u0e48อผ\u0e39\u0e49ใช\u0e49:";
	}

	protected override string _GetTemplateForLabelVerificationEmailSent()
	{
		return "ส\u0e48งอ\u0e35เมลย\u0e37นย\u0e31นแล\u0e49ว!";
	}

	protected override string _GetTemplateForLabelWeChatAntiAddictionText()
	{
		return "บอยคอตต\u0e4cเกมแย\u0e48ๆ ปฏ\u0e34เสธเกมละเม\u0e34ดล\u0e34ขส\u0e34ทธ\u0e34\u0e4c ร\u0e39\u0e49ถ\u0e36งการป\u0e49องก\u0e31นต\u0e31วและการถ\u0e39กหลอกลวง การเล\u0e48นเกมน\u0e31\u0e49นด\u0e35ต\u0e48อสมองของค\u0e38ณ แต\u0e48การเล\u0e48นเกมมากเก\u0e34นไปก\u0e47อาจเป\u0e47นอ\u0e31นตรายต\u0e48อส\u0e38ขภาพของค\u0e38ณได\u0e49 บร\u0e34หารเวลาของค\u0e38ณให\u0e49ด\u0e35 แล\u0e49วใช\u0e49ช\u0e35ว\u0e34ตท\u0e35\u0e48ม\u0e35ส\u0e38ขภาพด\u0e35";
	}

	protected override string _GetTemplateForMessageUnknownErrorTryAgain()
	{
		return "เก\u0e34ดข\u0e49อผ\u0e34ดพลาดท\u0e35\u0e48ไม\u0e48ทราบสาเหต\u0e38 กร\u0e38ณาลองใหม\u0e48อ\u0e35กคร\u0e31\u0e49ง";
	}

	protected override string _GetTemplateForMessageUsernameAndPasswordRequired()
	{
		return "จำเป\u0e47นต\u0e49องม\u0e35ช\u0e37\u0e48อผ\u0e39\u0e49ใช\u0e49และรห\u0e31สผ\u0e48าน";
	}

	protected override string _GetTemplateForResponseAccountIssueErrorContactSupport()
	{
		return "ป\u0e31ญหาด\u0e49านบ\u0e31ญช\u0e35 กร\u0e38ณาต\u0e34ดต\u0e48อฝ\u0e48ายสน\u0e31บสน\u0e38น";
	}

	protected override string _GetTemplateForResponseAccountLockedRequestReset()
	{
		return "บ\u0e31ญช\u0e35ถ\u0e39กล\u0e47อค กร\u0e38ณาขอการร\u0e35เซ\u0e47ตรห\u0e31สผ\u0e48าน";
	}

	protected override string _GetTemplateForResponseAccountNotFound()
	{
		return "ไม\u0e48พบบ\u0e31ญช\u0e35 กร\u0e38ณาลองใหม\u0e48อ\u0e35กคร\u0e31\u0e49ง";
	}

	protected override string _GetTemplateForResponseEmailLinkedToMultipleAccountsLoginWithUsername()
	{
		return "อ\u0e35เมลของค\u0e38ณเช\u0e37\u0e48อมโยงก\u0e31บช\u0e37\u0e48อผ\u0e39\u0e49ใช\u0e49มากกว\u0e48า 1 บ\u0e31ญช\u0e35 กร\u0e38ณาเข\u0e49าส\u0e39\u0e48ระบบด\u0e49วยช\u0e37\u0e48อผ\u0e39\u0e49ใช\u0e49ของค\u0e38ณ";
	}

	protected override string _GetTemplateForResponseEmailSent()
	{
		return "ส\u0e48งอ\u0e35เมลแล\u0e49ว!";
	}

	protected override string _GetTemplateForResponseIncorrectEmailOrPassword()
	{
		return "อ\u0e35เมลหร\u0e37อรห\u0e31สผ\u0e48านไม\u0e48ถ\u0e39กต\u0e49อง";
	}

	protected override string _GetTemplateForResponseIncorrectPhoneOrPassword()
	{
		return "หมายเลขโทรศ\u0e31พท\u0e4cหร\u0e37อรห\u0e31สผ\u0e48านไม\u0e48ถ\u0e39กต\u0e49อง";
	}

	protected override string _GetTemplateForResponseIncorrectUsernamePassword()
	{
		return "ช\u0e37\u0e48อผ\u0e39\u0e49ใช\u0e49หร\u0e37อรห\u0e31สผ\u0e48านไม\u0e48ถ\u0e39กต\u0e49อง";
	}

	protected override string _GetTemplateForResponseLoginWithUsername()
	{
		return "ม\u0e35บางอย\u0e48างผ\u0e34ดปกต\u0e34 กร\u0e38ณาเข\u0e49าส\u0e39\u0e48ระบบด\u0e49วยช\u0e37\u0e48อผ\u0e39\u0e49ใช\u0e49ของค\u0e38ณ";
	}

	protected override string _GetTemplateForResponsePasswordNotProvided()
	{
		return "ค\u0e38ณจะต\u0e49องป\u0e49อนรห\u0e31สผ\u0e48าน";
	}

	protected override string _GetTemplateForResponseTooManyAttemptsPleaseWait()
	{
		return "ม\u0e35การดำเน\u0e34นการซ\u0e49ำมากเก\u0e34นไป กร\u0e38ณารอส\u0e31กคร\u0e39\u0e48";
	}

	protected override string _GetTemplateForResponseUnknownError()
	{
		return "ข\u0e49อผ\u0e34ดพลาดท\u0e35\u0e48ไม\u0e48ทราบสาเหต\u0e38";
	}

	protected override string _GetTemplateForResponseUnknownLoginError()
	{
		return "เก\u0e34ดความผ\u0e34ดพลาดในการเข\u0e49าส\u0e39\u0e48ระบบท\u0e35\u0e48ไม\u0e48ทราบสาเหต\u0e38";
	}

	protected override string _GetTemplateForResponseUnverifiedEmailLoginWithUsername()
	{
		return "อ\u0e35เมลของค\u0e38ณไม\u0e48ได\u0e49ร\u0e31บการตรวจสอบความถ\u0e39กต\u0e49อง กร\u0e38ณาเข\u0e49าส\u0e39\u0e48ระบบด\u0e49วยช\u0e37\u0e48อผ\u0e39\u0e49ใช\u0e49ของค\u0e38ณ";
	}

	protected override string _GetTemplateForResponseUnverifiedPhoneLoginWithUsername()
	{
		return "หมายเลขโทรศ\u0e31พท\u0e4cของค\u0e38ณไม\u0e48ได\u0e49ร\u0e31บการตรวจสอบความถ\u0e39กต\u0e49อง กร\u0e38ณาเข\u0e49าส\u0e39\u0e48ระบบด\u0e49วยช\u0e37\u0e48อผ\u0e39\u0e49ใช\u0e49ของค\u0e38ณ";
	}

	protected override string _GetTemplateForResponseUsernameNotProvided()
	{
		return "ค\u0e38ณจะต\u0e49องป\u0e49อนช\u0e37\u0e48อผ\u0e39\u0e49ใช\u0e49";
	}

	protected override string _GetTemplateForResponseUseSocialSignOn()
	{
		return "ไม\u0e48สามารถเข\u0e49าส\u0e39\u0e48ระบบได\u0e49 กร\u0e38ณาใช\u0e49บ\u0e31ญช\u0e35โซเช\u0e35ยลเน\u0e47ตเว\u0e34ร\u0e4cคเพ\u0e37\u0e48อลงช\u0e37\u0e48อเข\u0e49าใช\u0e49งาน";
	}

	/// <summary>
	/// Key: "Response.WeChatNotRealNameVerified"
	/// English String: "Your WeChat is not real-name verified. Please use a real-name verified WeChat account and try again. Please visit {url}"
	/// </summary>
	public override string ResponseWeChatNotRealNameVerified(string url)
	{
		return $"บ\u0e31ญช\u0e35 WeChat ของค\u0e38ณย\u0e31งไม\u0e48ได\u0e49ทำการย\u0e37นย\u0e31นช\u0e37\u0e48อจร\u0e34ง กร\u0e38ณาทำการย\u0e37นย\u0e31นช\u0e37\u0e48อจร\u0e34งสำหร\u0e31บบ\u0e31ญช\u0e35 WeChat แล\u0e49วลองใหม\u0e48อ\u0e35กคร\u0e31\u0e49ง กร\u0e38ณาไปท\u0e35\u0e48 {url}";
	}

	protected override string _GetTemplateForResponseWeChatNotRealNameVerified()
	{
		return "บ\u0e31ญช\u0e35 WeChat ของค\u0e38ณย\u0e31งไม\u0e48ได\u0e49ทำการย\u0e37นย\u0e31นช\u0e37\u0e48อจร\u0e34ง กร\u0e38ณาทำการย\u0e37นย\u0e31นช\u0e37\u0e48อจร\u0e34งสำหร\u0e31บบ\u0e31ญช\u0e35 WeChat แล\u0e49วลองใหม\u0e48อ\u0e35กคร\u0e31\u0e49ง กร\u0e38ณาไปท\u0e35\u0e48 {url}";
	}

	protected override string _GetTemplateForWeChatAntiAddictionText()
	{
		return "บอยคอตต\u0e4cเกมแย\u0e48ๆ ปฏ\u0e34เสธเกมละเม\u0e34ดล\u0e34ขส\u0e34ทธ\u0e34\u0e4c ร\u0e39\u0e49ถ\u0e36งการป\u0e49องก\u0e31นต\u0e31ว และการถ\u0e39กหลอกลวง การเล\u0e48นเกมน\u0e31\u0e49นด\u0e35ต\u0e48อสมองของค\u0e38ณ แต\u0e48การเล\u0e48นเกมมากเก\u0e34นไปก\u0e47อาจเป\u0e47นอ\u0e31นตรายต\u0e48อส\u0e38ขภาพของค\u0e38ณได\u0e49 บร\u0e34หารเวลาของค\u0e38ณให\u0e49ด\u0e35 แล\u0e49วใช\u0e49ช\u0e35ว\u0e34ตท\u0e35\u0e48ม\u0e35ส\u0e38ขภาพด\u0e35";
	}

	protected override string _GetTemplateForWeChatRealNameNotVerified()
	{
		return "บ\u0e31ญช\u0e35 WeChat ของค\u0e38ณย\u0e31งไม\u0e48ได\u0e49ทำการย\u0e37นย\u0e31นช\u0e37\u0e48อจร\u0e34ง กร\u0e38ณาทำการย\u0e37นย\u0e31นช\u0e37\u0e48อจร\u0e34งสำหร\u0e31บบ\u0e31ญช\u0e35 WeChat แล\u0e49วลองใหม\u0e48อ\u0e35กคร\u0e31\u0e49ง กร\u0e38ณาไปท\u0e35\u0e48 https://jiazhang.qq.com/zk/home.html";
	}
}
