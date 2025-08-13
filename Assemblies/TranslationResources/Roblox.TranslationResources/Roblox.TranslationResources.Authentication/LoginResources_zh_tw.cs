namespace Roblox.TranslationResources.Authentication;

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
	public override string ActionCancel => "取消";

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
	public override string ActionForgotPasswordOrUsernameQuestion => "忘記密碼或使用者名稱？";

	/// <summary>
	/// Key: "Action.ForgotPasswordOrUsernameQuestionCapitalized"
	/// link under login form
	/// English String: "Forgot Password or Username?"
	/// </summary>
	public override string ActionForgotPasswordOrUsernameQuestionCapitalized => "忘記密碼或使用者名稱？";

	/// <summary>
	/// Key: "Action.Login"
	/// English String: "Login"
	/// </summary>
	public override string ActionLogin => "登入";

	/// <summary>
	/// Key: "Action.LogInCapitalized"
	/// login button label. please note this is different from 'Login' or 'Log in'.
	/// English String: "Log In"
	/// </summary>
	public override string ActionLogInCapitalized => "登入";

	/// <summary>
	/// Key: "Action.Ok"
	/// button text
	/// English String: "OK"
	/// </summary>
	public override string ActionOk => "確定";

	/// <summary>
	/// Key: "Action.PlayAsGuest"
	/// Play as Guest
	/// English String: "Play as Guest"
	/// </summary>
	public override string ActionPlayAsGuest => "以訪客身分遊玩";

	/// <summary>
	/// Key: "Action.Resend"
	/// button text for resending verification email
	/// English String: "Resend"
	/// </summary>
	public override string ActionResend => "重新傳送";

	/// <summary>
	/// Key: "Action.ResendEmail"
	/// link that resends verification email to user
	/// English String: "Resend Email"
	/// </summary>
	public override string ActionResendEmail => "重新傳送電子郵件";

	/// <summary>
	/// Key: "Action.SendVerificationEmail"
	/// button user can click to send a verification link to their email
	/// English String: "Send Verification Email"
	/// </summary>
	public override string ActionSendVerificationEmail => "傳送驗證電子郵件";

	/// <summary>
	/// Key: "Action.SignIn"
	/// Sign In button text
	/// English String: "Sign In"
	/// </summary>
	public override string ActionSignIn => "登入";

	/// <summary>
	/// Key: "Action.SignInWithFacebook"
	/// Sign In with Facebook
	/// English String: "Sign In with Facebook"
	/// </summary>
	public override string ActionSignInWithFacebook => "以 Facebook 登入";

	/// <summary>
	/// Key: "Action.SignUp"
	/// English String: "Sign up"
	/// </summary>
	public override string ActionSignUp => "註冊";

	/// <summary>
	/// Key: "Action.SignUpCapitalized"
	/// link which takes user to sign up page
	/// English String: "Sign Up"
	/// </summary>
	public override string ActionSignUpCapitalized => "註冊";

	/// <summary>
	/// Key: "Action.WeChatLogin"
	/// button text for logging in with WeChat
	/// English String: "WeChat Login"
	/// </summary>
	public override string ActionWeChatLogin => "微信登入";

	/// <summary>
	/// Key: "Heading.Login"
	/// heading on the login page
	/// English String: "Login"
	/// </summary>
	public override string HeadingLogin => "登入";

	/// <summary>
	/// Key: "Heading.LoginRoblox"
	/// current login page heading
	/// English String: "Login to Roblox"
	/// </summary>
	public override string HeadingLoginRoblox => "登入 Roblox";

	public override string HeadingSignUpMakeFriends => "註冊帳號，開始交友和創作";

	/// <summary>
	/// Key: "Label.AccountNotNeeded"
	/// You don't need an account to play Roblox
	/// English String: "You don't need an account to play Roblox"
	/// </summary>
	public override string LabelAccountNotNeeded => "玩 Roblox 不需要註冊帳號";

	/// <summary>
	/// Key: "Label.EmailNeedsVerification"
	/// modal header used for prompting user they need to verify their email in order to log in with it
	/// English String: "Your email needs verification"
	/// </summary>
	public override string LabelEmailNeedsVerification => "您的電子郵件地址需要驗證";

	/// <summary>
	/// Key: "Label.FacebookCreatePasswordWarning"
	/// If you have been signing in with Facebook, you must set a password.
	/// English String: "If you have been signing in with Facebook, you must set a password."
	/// </summary>
	public override string LabelFacebookCreatePasswordWarning => "若您以 Facebook 登入，請設定密碼。";

	/// <summary>
	/// Key: "Label.ForgotUsernamePassword"
	/// landing page top right link for password reset
	/// English String: "Forgot Username/Password?"
	/// </summary>
	public override string LabelForgotUsernamePassword => "忘記使用者名稱或密碼？";

	/// <summary>
	/// Key: "Label.LearnMore"
	/// learn more link text
	/// English String: "Learn more"
	/// </summary>
	public override string LabelLearnMore => "了解更多";

	/// <summary>
	/// Key: "Label.LoggingInSpinnerText"
	/// English String: "Logging in…"
	/// </summary>
	public override string LabelLoggingInSpinnerText => "正在登入…";

	/// <summary>
	/// Key: "Label.Login"
	/// English String: "Log in"
	/// </summary>
	public override string LabelLogin => "登入";

	/// <summary>
	/// Key: "Label.LoginWithYour"
	/// Label for a partition line between login with email and facebook login. Please keep the text in lowercase for roman characters.
	/// English String: "login with your"
	/// </summary>
	public override string LabelLoginWithYour => "登入方法：";

	/// <summary>
	/// Key: "Label.NoAccount"
	/// Don't have an account?
	/// English String: "Don't have an account?"
	/// </summary>
	public override string LabelNoAccount => "沒有帳號？";

	/// <summary>
	/// Key: "Label.NonAMemberQuestion"
	/// The question heading for the section on the login page to take use to sign up page.
	/// English String: "Not a member?"
	/// </summary>
	public override string LabelNonAMemberQuestion => "不是會員？";

	/// <summary>
	/// Key: "Label.NotReceived"
	/// prompt for allowing users to resend verification email
	/// English String: "Didn't receive it?"
	/// </summary>
	public override string LabelNotReceived => "沒有收到？";

	/// <summary>
	/// Key: "Label.Or"
	/// partition between email login and facebook login
	/// English String: "Or"
	/// </summary>
	public override string LabelOr => "或";

	/// <summary>
	/// Key: "Label.Password"
	/// Password
	/// English String: "Password"
	/// </summary>
	public override string LabelPassword => "密碼";

	/// <summary>
	/// Key: "Label.PasswordWithColumn"
	/// label for the password field on the login page
	/// English String: "Password:"
	/// </summary>
	public override string LabelPasswordWithColumn => "密碼：";

	/// <summary>
	/// Key: "Label.StartPlaying"
	/// You can start playing right now, in guest mode!
	/// English String: "You can start playing right now, in guest mode!"
	/// </summary>
	public override string LabelStartPlaying => "現在以訪客模式遊玩！";

	/// <summary>
	/// Key: "Label.UnverifiedEmailInstructions"
	/// message shown in a modal when user logs in with unverified email
	/// English String: "To log in with your email, it must be verified. You can also log in with your username."
	/// </summary>
	public override string LabelUnverifiedEmailInstructions => "若要以您的電子郵件地址登入，請先驗證電子郵件地址。您也能以使用者名稱登入。";

	/// <summary>
	/// Key: "Label.Username"
	/// English String: "Username"
	/// </summary>
	public override string LabelUsername => "使用者名稱";

	/// <summary>
	/// Key: "Label.UsernameEmail"
	/// placeholder text for input field that accepts username or email
	/// English String: "Username/Email"
	/// </summary>
	public override string LabelUsernameEmail => "使用者名稱／電子郵件地址";

	/// <summary>
	/// Key: "Label.UsernameEmailPhone"
	/// placeholder text for input fields that accept username, email or phone
	/// English String: "Username/Email/Phone"
	/// </summary>
	public override string LabelUsernameEmailPhone => "使用者名稱／電子郵件地址／手機號碼";

	/// <summary>
	/// Key: "Label.UsernamePhone"
	/// placeholder text for input field that accepts username or phone
	/// English String: "Username/Phone"
	/// </summary>
	public override string LabelUsernamePhone => "使用者名稱／手機號碼";

	/// <summary>
	/// Key: "Label.UsernameWithColumn"
	/// label for username field on login page
	/// English String: "Username:"
	/// </summary>
	public override string LabelUsernameWithColumn => "使用者名稱：";

	/// <summary>
	/// Key: "Label.VerificationEmailSent"
	/// message telling user a verification email was sent to them
	/// English String: "Verification Email Sent!"
	/// </summary>
	public override string LabelVerificationEmailSent => "驗證電子郵件已傳送！";

	/// <summary>
	/// Key: "Label.WeChatAntiAddictionText"
	/// English String: "Boycott bad games, refuse pirated games. Be aware of self-defense and being deceived. Playing games is good for your brain, but too much game play can harm your health. Manage your time well and enjoy a healthy lifestyle."
	/// </summary>
	public override string LabelWeChatAntiAddictionText => "抵制劣質與抄襲遊戲！玩遊戲有益身心，但過度沉迷會對身體造成影響。控制遊戲時間，享受健康人生！";

	/// <summary>
	/// Key: "Message.UnknownErrorTryAgain"
	/// An unknown error occurred. Please try again.
	/// English String: "An unknown error occurred. Please try again."
	/// </summary>
	public override string MessageUnknownErrorTryAgain => "發生未知錯誤。請重新嘗試。";

	/// <summary>
	/// Key: "Message.UsernameAndPasswordRequired"
	/// message shown to user when they attempt to login without entering a username or password
	/// English String: "Username and password required"
	/// </summary>
	public override string MessageUsernameAndPasswordRequired => "使用者名稱或密碼空白";

	/// <summary>
	/// Key: "Response.AccountIssueErrorContactSupport"
	/// English String: "Account issue. Please contact Support."
	/// </summary>
	public override string ResponseAccountIssueErrorContactSupport => "帳號發生問題，請聯絡客服人員。";

	/// <summary>
	/// Key: "Response.AccountLockedRequestReset"
	/// Account has been locked. Please request a password reset.
	/// English String: "Account has been locked. Please request a password reset."
	/// </summary>
	public override string ResponseAccountLockedRequestReset => "帳號已遭鎖定，請進行密碼重置。";

	/// <summary>
	/// Key: "Response.AccountNotFound"
	/// Account not found. Please try again.
	/// English String: "Account not found. Please try again."
	/// </summary>
	public override string ResponseAccountNotFound => "找不到帳號，請重新嘗試。";

	/// <summary>
	/// Key: "Response.EmailLinkedToMultipleAccountsLoginWithUsername"
	/// error message displayed when user attempts to log in with an email that is linked to multiple accounts
	/// English String: "Your email is associated with more than 1 username. Please login with your username."
	/// </summary>
	public override string ResponseEmailLinkedToMultipleAccountsLoginWithUsername => "有多組帳號加入此電子郵件地址，請以您的使用者名稱登入。";

	/// <summary>
	/// Key: "Response.EmailSent"
	/// response telling user that a verification email has been sent to them
	/// English String: "Email sent!"
	/// </summary>
	public override string ResponseEmailSent => "驗證郵件已傳送！";

	/// <summary>
	/// Key: "Response.IncorrectEmailOrPassword"
	/// error message displayed when user logs in with an invalid email or password
	/// English String: "Incorrect email or password."
	/// </summary>
	public override string ResponseIncorrectEmailOrPassword => "電子郵件或密碼不正確。";

	/// <summary>
	/// Key: "Response.IncorrectPhoneOrPassword"
	/// error message displayed when user logs in with an invalid phone or password
	/// English String: "Incorrect phone or password."
	/// </summary>
	public override string ResponseIncorrectPhoneOrPassword => "手機或密碼不正確。";

	/// <summary>
	/// Key: "Response.IncorrectUsernamePassword"
	/// English String: "Incorrect username or password."
	/// </summary>
	public override string ResponseIncorrectUsernamePassword => "使用者名稱或密碼不正確。";

	/// <summary>
	/// Key: "Response.LoginWithUsername"
	/// error message shown when user attempts to login with method other than username and an error occurred
	/// English String: "Something went wrong. Please login with your username."
	/// </summary>
	public override string ResponseLoginWithUsername => "發生錯誤，請以您的使用者名稱登入。";

	/// <summary>
	/// Key: "Response.PasswordNotProvided"
	/// password field is empty
	/// English String: "You must enter a password."
	/// </summary>
	public override string ResponsePasswordNotProvided => "必須輸入密碼。";

	/// <summary>
	/// Key: "Response.TooManyAttemptsPleaseWait"
	/// English String: "Too many attempts. Please wait a bit."
	/// </summary>
	public override string ResponseTooManyAttemptsPleaseWait => "嘗試次數過多，請稍後再試。";

	/// <summary>
	/// Key: "Response.UnknownError"
	/// English String: "Unknown Error"
	/// </summary>
	public override string ResponseUnknownError => "未知錯誤";

	/// <summary>
	/// Key: "Response.UnknownLoginError"
	/// Unknown login failure.
	/// English String: "Unknown login failure."
	/// </summary>
	public override string ResponseUnknownLoginError => "登入時發生未知錯誤。";

	/// <summary>
	/// Key: "Response.UnverifiedEmailLoginWithUsername"
	/// error message shown when user attempts to login with unverified email
	/// English String: "Your email is not verified. Please login with your username."
	/// </summary>
	public override string ResponseUnverifiedEmailLoginWithUsername => "您的電子郵件未驗證，請以您的使用者名稱登入。";

	/// <summary>
	/// Key: "Response.UnverifiedPhoneLoginWithUsername"
	/// error message shown when user attempts to login with an unverified phone number
	/// English String: "Your phone is not verified. Please login with your username."
	/// </summary>
	public override string ResponseUnverifiedPhoneLoginWithUsername => "您的手機未驗證，請以您的使用者名稱登入。";

	/// <summary>
	/// Key: "Response.UsernameNotProvided"
	/// username field is empty
	/// English String: "You must enter a username."
	/// </summary>
	public override string ResponseUsernameNotProvided => "必須輸入使用者名稱。";

	/// <summary>
	/// Key: "Response.UseSocialSignOn"
	/// Unable to login. Please use Social Network sign on.
	/// English String: "Unable to login. Please use Social Network sign on."
	/// </summary>
	public override string ResponseUseSocialSignOn => "無法登入，請以社交網路登入。";

	/// <summary>
	/// Key: "WeChat.AntiAddictionText"
	/// English String: "Boycott bad games, refuse pirated games. Be aware of self-defense and being deceived. Playing games is good for your brain, but too much game play can harm your health. Manage your time well and enjoy a healthy lifestyle."
	/// </summary>
	public override string WeChatAntiAddictionText => "抵制劣質與抄襲遊戲！玩遊戲有益身心，但過度沉迷會對身體造成影響。控制遊戲時間，享受健康人生！";

	/// <summary>
	/// Key: "WeChat.RealNameNotVerified"
	/// English String: "Your WeChat is not real-name verified. Please use a real-name verified WeChat account and try again. Please visit https://jiazhang.qq.com/zk/home.html"
	/// </summary>
	public override string WeChatRealNameNotVerified => "您的微信尚未進行實名認證，請進行實名認證再重新嘗試。請前往 https://jiazhang.qq.com/zk/home.html";

	public LoginResources_zh_tw(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionCancel()
	{
		return "取消";
	}

	protected override string _GetTemplateForActionFacebook()
	{
		return "Facebook";
	}

	protected override string _GetTemplateForActionForgotPasswordOrUsernameQuestion()
	{
		return "忘記密碼或使用者名稱？";
	}

	protected override string _GetTemplateForActionForgotPasswordOrUsernameQuestionCapitalized()
	{
		return "忘記密碼或使用者名稱？";
	}

	protected override string _GetTemplateForActionLogin()
	{
		return "登入";
	}

	protected override string _GetTemplateForActionLogInCapitalized()
	{
		return "登入";
	}

	protected override string _GetTemplateForActionOk()
	{
		return "確定";
	}

	protected override string _GetTemplateForActionPlayAsGuest()
	{
		return "以訪客身分遊玩";
	}

	protected override string _GetTemplateForActionResend()
	{
		return "重新傳送";
	}

	protected override string _GetTemplateForActionResendEmail()
	{
		return "重新傳送電子郵件";
	}

	protected override string _GetTemplateForActionSendVerificationEmail()
	{
		return "傳送驗證電子郵件";
	}

	protected override string _GetTemplateForActionSignIn()
	{
		return "登入";
	}

	protected override string _GetTemplateForActionSignInWithFacebook()
	{
		return "以 Facebook 登入";
	}

	protected override string _GetTemplateForActionSignUp()
	{
		return "註冊";
	}

	protected override string _GetTemplateForActionSignUpCapitalized()
	{
		return "註冊";
	}

	protected override string _GetTemplateForActionWeChatLogin()
	{
		return "微信登入";
	}

	protected override string _GetTemplateForHeadingLogin()
	{
		return "登入";
	}

	protected override string _GetTemplateForHeadingLoginRoblox()
	{
		return "登入 Roblox";
	}

	protected override string _GetTemplateForHeadingSignUpMakeFriends()
	{
		return "註冊帳號，開始交友和創作";
	}

	protected override string _GetTemplateForLabelAccountNotNeeded()
	{
		return "玩 Roblox 不需要註冊帳號";
	}

	protected override string _GetTemplateForLabelEmailNeedsVerification()
	{
		return "您的電子郵件地址需要驗證";
	}

	protected override string _GetTemplateForLabelFacebookCreatePasswordWarning()
	{
		return "若您以 Facebook 登入，請設定密碼。";
	}

	protected override string _GetTemplateForLabelForgotUsernamePassword()
	{
		return "忘記使用者名稱或密碼？";
	}

	/// <summary>
	/// Key: "Label.GreetingForNewAccount"
	/// Shown when a username doesn't exist on the login page to invite to create a new account.
	/// English String: "Nice to meet you, {username}. {linkStartSignup}Let's make an account! {linkEndSignup}"
	/// </summary>
	public override string LabelGreetingForNewAccount(string username, string linkStartSignup, string linkEndSignup)
	{
		return $"您好，{username}。{linkStartSignup}來註冊帳號吧！{linkEndSignup}";
	}

	protected override string _GetTemplateForLabelGreetingForNewAccount()
	{
		return "您好，{username}。{linkStartSignup}來註冊帳號吧！{linkEndSignup}";
	}

	protected override string _GetTemplateForLabelLearnMore()
	{
		return "了解更多";
	}

	protected override string _GetTemplateForLabelLoggingInSpinnerText()
	{
		return "正在登入…";
	}

	protected override string _GetTemplateForLabelLogin()
	{
		return "登入";
	}

	protected override string _GetTemplateForLabelLoginWithYour()
	{
		return "登入方法：";
	}

	protected override string _GetTemplateForLabelNoAccount()
	{
		return "沒有帳號？";
	}

	protected override string _GetTemplateForLabelNonAMemberQuestion()
	{
		return "不是會員？";
	}

	protected override string _GetTemplateForLabelNotReceived()
	{
		return "沒有收到？";
	}

	protected override string _GetTemplateForLabelOr()
	{
		return "或";
	}

	protected override string _GetTemplateForLabelPassword()
	{
		return "密碼";
	}

	protected override string _GetTemplateForLabelPasswordWithColumn()
	{
		return "密碼：";
	}

	protected override string _GetTemplateForLabelStartPlaying()
	{
		return "現在以訪客模式遊玩！";
	}

	protected override string _GetTemplateForLabelUnverifiedEmailInstructions()
	{
		return "若要以您的電子郵件地址登入，請先驗證電子郵件地址。您也能以使用者名稱登入。";
	}

	protected override string _GetTemplateForLabelUsername()
	{
		return "使用者名稱";
	}

	protected override string _GetTemplateForLabelUsernameEmail()
	{
		return "使用者名稱／電子郵件地址";
	}

	protected override string _GetTemplateForLabelUsernameEmailPhone()
	{
		return "使用者名稱／電子郵件地址／手機號碼";
	}

	protected override string _GetTemplateForLabelUsernamePhone()
	{
		return "使用者名稱／手機號碼";
	}

	protected override string _GetTemplateForLabelUsernameWithColumn()
	{
		return "使用者名稱：";
	}

	protected override string _GetTemplateForLabelVerificationEmailSent()
	{
		return "驗證電子郵件已傳送！";
	}

	protected override string _GetTemplateForLabelWeChatAntiAddictionText()
	{
		return "抵制劣質與抄襲遊戲！玩遊戲有益身心，但過度沉迷會對身體造成影響。控制遊戲時間，享受健康人生！";
	}

	protected override string _GetTemplateForMessageUnknownErrorTryAgain()
	{
		return "發生未知錯誤。請重新嘗試。";
	}

	protected override string _GetTemplateForMessageUsernameAndPasswordRequired()
	{
		return "使用者名稱或密碼空白";
	}

	protected override string _GetTemplateForResponseAccountIssueErrorContactSupport()
	{
		return "帳號發生問題，請聯絡客服人員。";
	}

	protected override string _GetTemplateForResponseAccountLockedRequestReset()
	{
		return "帳號已遭鎖定，請進行密碼重置。";
	}

	protected override string _GetTemplateForResponseAccountNotFound()
	{
		return "找不到帳號，請重新嘗試。";
	}

	protected override string _GetTemplateForResponseEmailLinkedToMultipleAccountsLoginWithUsername()
	{
		return "有多組帳號加入此電子郵件地址，請以您的使用者名稱登入。";
	}

	protected override string _GetTemplateForResponseEmailSent()
	{
		return "驗證郵件已傳送！";
	}

	protected override string _GetTemplateForResponseIncorrectEmailOrPassword()
	{
		return "電子郵件或密碼不正確。";
	}

	protected override string _GetTemplateForResponseIncorrectPhoneOrPassword()
	{
		return "手機或密碼不正確。";
	}

	protected override string _GetTemplateForResponseIncorrectUsernamePassword()
	{
		return "使用者名稱或密碼不正確。";
	}

	protected override string _GetTemplateForResponseLoginWithUsername()
	{
		return "發生錯誤，請以您的使用者名稱登入。";
	}

	protected override string _GetTemplateForResponsePasswordNotProvided()
	{
		return "必須輸入密碼。";
	}

	protected override string _GetTemplateForResponseTooManyAttemptsPleaseWait()
	{
		return "嘗試次數過多，請稍後再試。";
	}

	protected override string _GetTemplateForResponseUnknownError()
	{
		return "未知錯誤";
	}

	protected override string _GetTemplateForResponseUnknownLoginError()
	{
		return "登入時發生未知錯誤。";
	}

	protected override string _GetTemplateForResponseUnverifiedEmailLoginWithUsername()
	{
		return "您的電子郵件未驗證，請以您的使用者名稱登入。";
	}

	protected override string _GetTemplateForResponseUnverifiedPhoneLoginWithUsername()
	{
		return "您的手機未驗證，請以您的使用者名稱登入。";
	}

	protected override string _GetTemplateForResponseUsernameNotProvided()
	{
		return "必須輸入使用者名稱。";
	}

	protected override string _GetTemplateForResponseUseSocialSignOn()
	{
		return "無法登入，請以社交網路登入。";
	}

	/// <summary>
	/// Key: "Response.WeChatNotRealNameVerified"
	/// English String: "Your WeChat is not real-name verified. Please use a real-name verified WeChat account and try again. Please visit {url}"
	/// </summary>
	public override string ResponseWeChatNotRealNameVerified(string url)
	{
		return $"您的微信尚未進行實名認證，請進行實名認證再重新嘗試。請前往 {url}";
	}

	protected override string _GetTemplateForResponseWeChatNotRealNameVerified()
	{
		return "您的微信尚未進行實名認證，請進行實名認證再重新嘗試。請前往 {url}";
	}

	protected override string _GetTemplateForWeChatAntiAddictionText()
	{
		return "抵制劣質與抄襲遊戲！玩遊戲有益身心，但過度沉迷會對身體造成影響。控制遊戲時間，享受健康人生！";
	}

	protected override string _GetTemplateForWeChatRealNameNotVerified()
	{
		return "您的微信尚未進行實名認證，請進行實名認證再重新嘗試。請前往 https://jiazhang.qq.com/zk/home.html";
	}
}
