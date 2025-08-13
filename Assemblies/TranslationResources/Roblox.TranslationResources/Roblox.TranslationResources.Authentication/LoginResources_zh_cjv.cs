namespace Roblox.TranslationResources.Authentication;

/// <summary>
/// This class overrides LoginResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class LoginResources_zh_cjv : LoginResources_en_us, ILoginResources, ITranslationResources
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
	public override string ActionForgotPasswordOrUsernameQuestion => "忘记密码或用户名？";

	/// <summary>
	/// Key: "Action.ForgotPasswordOrUsernameQuestionCapitalized"
	/// link under login form
	/// English String: "Forgot Password or Username?"
	/// </summary>
	public override string ActionForgotPasswordOrUsernameQuestionCapitalized => "忘记密码或用户名？";

	/// <summary>
	/// Key: "Action.Login"
	/// English String: "Login"
	/// </summary>
	public override string ActionLogin => "登录";

	/// <summary>
	/// Key: "Action.LogInCapitalized"
	/// login button label. please note this is different from 'Login' or 'Log in'.
	/// English String: "Log In"
	/// </summary>
	public override string ActionLogInCapitalized => "登录";

	/// <summary>
	/// Key: "Action.Ok"
	/// button text
	/// English String: "OK"
	/// </summary>
	public override string ActionOk => "好";

	/// <summary>
	/// Key: "Action.PlayAsGuest"
	/// Play as Guest
	/// English String: "Play as Guest"
	/// </summary>
	public override string ActionPlayAsGuest => "以游客身份玩";

	/// <summary>
	/// Key: "Action.Resend"
	/// button text for resending verification email
	/// English String: "Resend"
	/// </summary>
	public override string ActionResend => "重新发送";

	/// <summary>
	/// Key: "Action.ResendEmail"
	/// link that resends verification email to user
	/// English String: "Resend Email"
	/// </summary>
	public override string ActionResendEmail => "重新发送电子邮件";

	/// <summary>
	/// Key: "Action.SendVerificationEmail"
	/// button user can click to send a verification link to their email
	/// English String: "Send Verification Email"
	/// </summary>
	public override string ActionSendVerificationEmail => "发送验证电子邮件";

	/// <summary>
	/// Key: "Action.SignIn"
	/// Sign In button text
	/// English String: "Sign In"
	/// </summary>
	public override string ActionSignIn => "登录";

	/// <summary>
	/// Key: "Action.SignInWithFacebook"
	/// Sign In with Facebook
	/// English String: "Sign In with Facebook"
	/// </summary>
	public override string ActionSignInWithFacebook => "使用 Facebook 登录";

	/// <summary>
	/// Key: "Action.SignUp"
	/// English String: "Sign up"
	/// </summary>
	public override string ActionSignUp => "注册";

	/// <summary>
	/// Key: "Action.SignUpCapitalized"
	/// link which takes user to sign up page
	/// English String: "Sign Up"
	/// </summary>
	public override string ActionSignUpCapitalized => "注册";

	/// <summary>
	/// Key: "Action.WeChatLogin"
	/// button text for logging in with WeChat
	/// English String: "WeChat Login"
	/// </summary>
	public override string ActionWeChatLogin => "微信登录";

	/// <summary>
	/// Key: "Heading.Login"
	/// heading on the login page
	/// English String: "Login"
	/// </summary>
	public override string HeadingLogin => "登录";

	/// <summary>
	/// Key: "Heading.LoginRoblox"
	/// current login page heading
	/// English String: "Login to Roblox"
	/// </summary>
	public override string HeadingLoginRoblox => "登录 Roblox";

	public override string HeadingSignUpMakeFriends => "注册以创建和认识新朋友";

	/// <summary>
	/// Key: "Label.AccountNotNeeded"
	/// You don't need an account to play Roblox
	/// English String: "You don't need an account to play Roblox"
	/// </summary>
	public override string LabelAccountNotNeeded => "你不需要帐户就能玩 Roblox。";

	/// <summary>
	/// Key: "Label.EmailNeedsVerification"
	/// modal header used for prompting user they need to verify their email in order to log in with it
	/// English String: "Your email needs verification"
	/// </summary>
	public override string LabelEmailNeedsVerification => "你的电子邮件需要验证";

	/// <summary>
	/// Key: "Label.FacebookCreatePasswordWarning"
	/// If you have been signing in with Facebook, you must set a password.
	/// English String: "If you have been signing in with Facebook, you must set a password."
	/// </summary>
	public override string LabelFacebookCreatePasswordWarning => "如果你使用 Facebook 登录，则必须设定密码。";

	/// <summary>
	/// Key: "Label.ForgotUsernamePassword"
	/// landing page top right link for password reset
	/// English String: "Forgot Username/Password?"
	/// </summary>
	public override string LabelForgotUsernamePassword => "忘记用户名/密码？";

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
	public override string LabelLoggingInSpinnerText => "正在登录...";

	/// <summary>
	/// Key: "Label.Login"
	/// English String: "Log in"
	/// </summary>
	public override string LabelLogin => "登录";

	/// <summary>
	/// Key: "Label.LoginWithYour"
	/// Label for a partition line between login with email and facebook login. Please keep the text in lowercase for roman characters.
	/// English String: "login with your"
	/// </summary>
	public override string LabelLoginWithYour => "使用下列方式登录";

	/// <summary>
	/// Key: "Label.NoAccount"
	/// Don't have an account?
	/// English String: "Don't have an account?"
	/// </summary>
	public override string LabelNoAccount => "没有帐户？";

	/// <summary>
	/// Key: "Label.NonAMemberQuestion"
	/// The question heading for the section on the login page to take use to sign up page.
	/// English String: "Not a member?"
	/// </summary>
	public override string LabelNonAMemberQuestion => "不是会员？";

	/// <summary>
	/// Key: "Label.NotReceived"
	/// prompt for allowing users to resend verification email
	/// English String: "Didn't receive it?"
	/// </summary>
	public override string LabelNotReceived => "没有收到？";

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
	public override string LabelPassword => "密码";

	/// <summary>
	/// Key: "Label.PasswordWithColumn"
	/// label for the password field on the login page
	/// English String: "Password:"
	/// </summary>
	public override string LabelPasswordWithColumn => "密码：";

	/// <summary>
	/// Key: "Label.StartPlaying"
	/// You can start playing right now, in guest mode!
	/// English String: "You can start playing right now, in guest mode!"
	/// </summary>
	public override string LabelStartPlaying => "使用游客模式，你现在就可以开始游戏了！";

	/// <summary>
	/// Key: "Label.UnverifiedEmailInstructions"
	/// message shown in a modal when user logs in with unverified email
	/// English String: "To log in with your email, it must be verified. You can also log in with your username."
	/// </summary>
	public override string LabelUnverifiedEmailInstructions => "要使用电子邮件登录，必须先进行验证。你也可以使用你的用户名登录。";

	/// <summary>
	/// Key: "Label.Username"
	/// English String: "Username"
	/// </summary>
	public override string LabelUsername => "用户名";

	/// <summary>
	/// Key: "Label.UsernameEmail"
	/// placeholder text for input field that accepts username or email
	/// English String: "Username/Email"
	/// </summary>
	public override string LabelUsernameEmail => "用户名/电子邮件";

	/// <summary>
	/// Key: "Label.UsernameEmailPhone"
	/// placeholder text for input fields that accept username, email or phone
	/// English String: "Username/Email/Phone"
	/// </summary>
	public override string LabelUsernameEmailPhone => "用户名/电子邮件/手机";

	/// <summary>
	/// Key: "Label.UsernamePhone"
	/// placeholder text for input field that accepts username or phone
	/// English String: "Username/Phone"
	/// </summary>
	public override string LabelUsernamePhone => "用户名/手机";

	/// <summary>
	/// Key: "Label.UsernameWithColumn"
	/// label for username field on login page
	/// English String: "Username:"
	/// </summary>
	public override string LabelUsernameWithColumn => "用户名：";

	/// <summary>
	/// Key: "Label.VerificationEmailSent"
	/// message telling user a verification email was sent to them
	/// English String: "Verification Email Sent!"
	/// </summary>
	public override string LabelVerificationEmailSent => "验证邮件已发送！";

	/// <summary>
	/// Key: "Label.WeChatAntiAddictionText"
	/// English String: "Boycott bad games, refuse pirated games. Be aware of self-defense and being deceived. Playing games is good for your brain, but too much game play can harm your health. Manage your time well and enjoy a healthy lifestyle."
	/// </summary>
	public override string LabelWeChatAntiAddictionText => "抵制不良游戏，拒绝盗版游戏。注意自我保护，谨防受骗上当。适度游戏益脑，沉迷游戏伤身。合理安排时间，享受健康生活。";

	/// <summary>
	/// Key: "Message.UnknownErrorTryAgain"
	/// An unknown error occurred. Please try again.
	/// English String: "An unknown error occurred. Please try again."
	/// </summary>
	public override string MessageUnknownErrorTryAgain => "发生未知错误。请重试。";

	/// <summary>
	/// Key: "Message.UsernameAndPasswordRequired"
	/// message shown to user when they attempt to login without entering a username or password
	/// English String: "Username and password required"
	/// </summary>
	public override string MessageUsernameAndPasswordRequired => "需要提供用户名及密码";

	/// <summary>
	/// Key: "Response.AccountIssueErrorContactSupport"
	/// English String: "Account issue. Please contact Support."
	/// </summary>
	public override string ResponseAccountIssueErrorContactSupport => "帐户问题。请联系技术支持。";

	/// <summary>
	/// Key: "Response.AccountLockedRequestReset"
	/// Account has been locked. Please request a password reset.
	/// English String: "Account has been locked. Please request a password reset."
	/// </summary>
	public override string ResponseAccountLockedRequestReset => "帐户已锁定。请提交密码重置请求。";

	/// <summary>
	/// Key: "Response.AccountNotFound"
	/// Account not found. Please try again.
	/// English String: "Account not found. Please try again."
	/// </summary>
	public override string ResponseAccountNotFound => "未找到帐户。请重试。";

	/// <summary>
	/// Key: "Response.EmailLinkedToMultipleAccountsLoginWithUsername"
	/// error message displayed when user attempts to log in with an email that is linked to multiple accounts
	/// English String: "Your email is associated with more than 1 username. Please login with your username."
	/// </summary>
	public override string ResponseEmailLinkedToMultipleAccountsLoginWithUsername => "你的电子邮件与不止 1 个用户名关联。请使用你的用户名登录。";

	/// <summary>
	/// Key: "Response.EmailSent"
	/// response telling user that a verification email has been sent to them
	/// English String: "Email sent!"
	/// </summary>
	public override string ResponseEmailSent => "电子邮件已发送！";

	/// <summary>
	/// Key: "Response.IncorrectEmailOrPassword"
	/// error message displayed when user logs in with an invalid email or password
	/// English String: "Incorrect email or password."
	/// </summary>
	public override string ResponseIncorrectEmailOrPassword => "电子邮件或密码不正确。";

	/// <summary>
	/// Key: "Response.IncorrectPhoneOrPassword"
	/// error message displayed when user logs in with an invalid phone or password
	/// English String: "Incorrect phone or password."
	/// </summary>
	public override string ResponseIncorrectPhoneOrPassword => "电话或密码不正确。";

	/// <summary>
	/// Key: "Response.IncorrectUsernamePassword"
	/// English String: "Incorrect username or password."
	/// </summary>
	public override string ResponseIncorrectUsernamePassword => "用户名或密码不正确。";

	/// <summary>
	/// Key: "Response.LoginWithUsername"
	/// error message shown when user attempts to login with method other than username and an error occurred
	/// English String: "Something went wrong. Please login with your username."
	/// </summary>
	public override string ResponseLoginWithUsername => "有地方出错，请使用你的用户名登录。";

	/// <summary>
	/// Key: "Response.PasswordNotProvided"
	/// password field is empty
	/// English String: "You must enter a password."
	/// </summary>
	public override string ResponsePasswordNotProvided => "你必须输入密码。";

	/// <summary>
	/// Key: "Response.TooManyAttemptsPleaseWait"
	/// English String: "Too many attempts. Please wait a bit."
	/// </summary>
	public override string ResponseTooManyAttemptsPleaseWait => "尝试次数过多。请稍候。";

	/// <summary>
	/// Key: "Response.UnknownError"
	/// English String: "Unknown Error"
	/// </summary>
	public override string ResponseUnknownError => "未知错误";

	/// <summary>
	/// Key: "Response.UnknownLoginError"
	/// Unknown login failure.
	/// English String: "Unknown login failure."
	/// </summary>
	public override string ResponseUnknownLoginError => "未知登录失败。";

	/// <summary>
	/// Key: "Response.UnverifiedEmailLoginWithUsername"
	/// error message shown when user attempts to login with unverified email
	/// English String: "Your email is not verified. Please login with your username."
	/// </summary>
	public override string ResponseUnverifiedEmailLoginWithUsername => "你的电子邮件未经验证。请使用你的用户名登录。";

	/// <summary>
	/// Key: "Response.UnverifiedPhoneLoginWithUsername"
	/// error message shown when user attempts to login with an unverified phone number
	/// English String: "Your phone is not verified. Please login with your username."
	/// </summary>
	public override string ResponseUnverifiedPhoneLoginWithUsername => "你的手机未经验证。请使用你的用户名登录。";

	/// <summary>
	/// Key: "Response.UsernameNotProvided"
	/// username field is empty
	/// English String: "You must enter a username."
	/// </summary>
	public override string ResponseUsernameNotProvided => "你必须输入用户名。";

	/// <summary>
	/// Key: "Response.UseSocialSignOn"
	/// Unable to login. Please use Social Network sign on.
	/// English String: "Unable to login. Please use Social Network sign on."
	/// </summary>
	public override string ResponseUseSocialSignOn => "无法登录。请使用社交网络登录。";

	/// <summary>
	/// Key: "WeChat.AntiAddictionText"
	/// English String: "Boycott bad games, refuse pirated games. Be aware of self-defense and being deceived. Playing games is good for your brain, but too much game play can harm your health. Manage your time well and enjoy a healthy lifestyle."
	/// </summary>
	public override string WeChatAntiAddictionText => "抵制不良游戏，拒绝盗版游戏。注意自我保护，谨防受骗上当。适度游戏益脑，沉迷游戏伤身。合理安排时间，享受健康生活。";

	/// <summary>
	/// Key: "WeChat.RealNameNotVerified"
	/// English String: "Your WeChat is not real-name verified. Please use a real-name verified WeChat account and try again. Please visit https://jiazhang.qq.com/zk/home.html"
	/// </summary>
	public override string WeChatRealNameNotVerified => "你的微信未经过实名认证。请使用通过实名验证的微信帐户并重试。要了解更多信息，请访问 https://jiazhang.qq.com/zk/home.html";

	public LoginResources_zh_cjv(TranslationResourceState state)
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
		return "忘记密码或用户名？";
	}

	protected override string _GetTemplateForActionForgotPasswordOrUsernameQuestionCapitalized()
	{
		return "忘记密码或用户名？";
	}

	protected override string _GetTemplateForActionLogin()
	{
		return "登录";
	}

	protected override string _GetTemplateForActionLogInCapitalized()
	{
		return "登录";
	}

	protected override string _GetTemplateForActionOk()
	{
		return "好";
	}

	protected override string _GetTemplateForActionPlayAsGuest()
	{
		return "以游客身份玩";
	}

	protected override string _GetTemplateForActionResend()
	{
		return "重新发送";
	}

	protected override string _GetTemplateForActionResendEmail()
	{
		return "重新发送电子邮件";
	}

	protected override string _GetTemplateForActionSendVerificationEmail()
	{
		return "发送验证电子邮件";
	}

	protected override string _GetTemplateForActionSignIn()
	{
		return "登录";
	}

	protected override string _GetTemplateForActionSignInWithFacebook()
	{
		return "使用 Facebook 登录";
	}

	protected override string _GetTemplateForActionSignUp()
	{
		return "注册";
	}

	protected override string _GetTemplateForActionSignUpCapitalized()
	{
		return "注册";
	}

	protected override string _GetTemplateForActionWeChatLogin()
	{
		return "微信登录";
	}

	protected override string _GetTemplateForHeadingLogin()
	{
		return "登录";
	}

	protected override string _GetTemplateForHeadingLoginRoblox()
	{
		return "登录 Roblox";
	}

	protected override string _GetTemplateForHeadingSignUpMakeFriends()
	{
		return "注册以创建和认识新朋友";
	}

	protected override string _GetTemplateForLabelAccountNotNeeded()
	{
		return "你不需要帐户就能玩 Roblox。";
	}

	protected override string _GetTemplateForLabelEmailNeedsVerification()
	{
		return "你的电子邮件需要验证";
	}

	protected override string _GetTemplateForLabelFacebookCreatePasswordWarning()
	{
		return "如果你使用 Facebook 登录，则必须设定密码。";
	}

	protected override string _GetTemplateForLabelForgotUsernamePassword()
	{
		return "忘记用户名/密码？";
	}

	/// <summary>
	/// Key: "Label.GreetingForNewAccount"
	/// Shown when a username doesn't exist on the login page to invite to create a new account.
	/// English String: "Nice to meet you, {username}. {linkStartSignup}Let's make an account! {linkEndSignup}"
	/// </summary>
	public override string LabelGreetingForNewAccount(string username, string linkStartSignup, string linkEndSignup)
	{
		return $"很高兴认识你， {username}。 {linkStartSignup}我们来创建帐户吧！ {linkEndSignup}";
	}

	protected override string _GetTemplateForLabelGreetingForNewAccount()
	{
		return "很高兴认识你， {username}。 {linkStartSignup}我们来创建帐户吧！ {linkEndSignup}";
	}

	protected override string _GetTemplateForLabelLearnMore()
	{
		return "了解更多";
	}

	protected override string _GetTemplateForLabelLoggingInSpinnerText()
	{
		return "正在登录...";
	}

	protected override string _GetTemplateForLabelLogin()
	{
		return "登录";
	}

	protected override string _GetTemplateForLabelLoginWithYour()
	{
		return "使用下列方式登录";
	}

	protected override string _GetTemplateForLabelNoAccount()
	{
		return "没有帐户？";
	}

	protected override string _GetTemplateForLabelNonAMemberQuestion()
	{
		return "不是会员？";
	}

	protected override string _GetTemplateForLabelNotReceived()
	{
		return "没有收到？";
	}

	protected override string _GetTemplateForLabelOr()
	{
		return "或";
	}

	protected override string _GetTemplateForLabelPassword()
	{
		return "密码";
	}

	protected override string _GetTemplateForLabelPasswordWithColumn()
	{
		return "密码：";
	}

	protected override string _GetTemplateForLabelStartPlaying()
	{
		return "使用游客模式，你现在就可以开始游戏了！";
	}

	protected override string _GetTemplateForLabelUnverifiedEmailInstructions()
	{
		return "要使用电子邮件登录，必须先进行验证。你也可以使用你的用户名登录。";
	}

	protected override string _GetTemplateForLabelUsername()
	{
		return "用户名";
	}

	protected override string _GetTemplateForLabelUsernameEmail()
	{
		return "用户名/电子邮件";
	}

	protected override string _GetTemplateForLabelUsernameEmailPhone()
	{
		return "用户名/电子邮件/手机";
	}

	protected override string _GetTemplateForLabelUsernamePhone()
	{
		return "用户名/手机";
	}

	protected override string _GetTemplateForLabelUsernameWithColumn()
	{
		return "用户名：";
	}

	protected override string _GetTemplateForLabelVerificationEmailSent()
	{
		return "验证邮件已发送！";
	}

	protected override string _GetTemplateForLabelWeChatAntiAddictionText()
	{
		return "抵制不良游戏，拒绝盗版游戏。注意自我保护，谨防受骗上当。适度游戏益脑，沉迷游戏伤身。合理安排时间，享受健康生活。";
	}

	protected override string _GetTemplateForMessageUnknownErrorTryAgain()
	{
		return "发生未知错误。请重试。";
	}

	protected override string _GetTemplateForMessageUsernameAndPasswordRequired()
	{
		return "需要提供用户名及密码";
	}

	protected override string _GetTemplateForResponseAccountIssueErrorContactSupport()
	{
		return "帐户问题。请联系技术支持。";
	}

	protected override string _GetTemplateForResponseAccountLockedRequestReset()
	{
		return "帐户已锁定。请提交密码重置请求。";
	}

	protected override string _GetTemplateForResponseAccountNotFound()
	{
		return "未找到帐户。请重试。";
	}

	protected override string _GetTemplateForResponseEmailLinkedToMultipleAccountsLoginWithUsername()
	{
		return "你的电子邮件与不止 1 个用户名关联。请使用你的用户名登录。";
	}

	protected override string _GetTemplateForResponseEmailSent()
	{
		return "电子邮件已发送！";
	}

	protected override string _GetTemplateForResponseIncorrectEmailOrPassword()
	{
		return "电子邮件或密码不正确。";
	}

	protected override string _GetTemplateForResponseIncorrectPhoneOrPassword()
	{
		return "电话或密码不正确。";
	}

	protected override string _GetTemplateForResponseIncorrectUsernamePassword()
	{
		return "用户名或密码不正确。";
	}

	protected override string _GetTemplateForResponseLoginWithUsername()
	{
		return "有地方出错，请使用你的用户名登录。";
	}

	protected override string _GetTemplateForResponsePasswordNotProvided()
	{
		return "你必须输入密码。";
	}

	protected override string _GetTemplateForResponseTooManyAttemptsPleaseWait()
	{
		return "尝试次数过多。请稍候。";
	}

	protected override string _GetTemplateForResponseUnknownError()
	{
		return "未知错误";
	}

	protected override string _GetTemplateForResponseUnknownLoginError()
	{
		return "未知登录失败。";
	}

	protected override string _GetTemplateForResponseUnverifiedEmailLoginWithUsername()
	{
		return "你的电子邮件未经验证。请使用你的用户名登录。";
	}

	protected override string _GetTemplateForResponseUnverifiedPhoneLoginWithUsername()
	{
		return "你的手机未经验证。请使用你的用户名登录。";
	}

	protected override string _GetTemplateForResponseUsernameNotProvided()
	{
		return "你必须输入用户名。";
	}

	protected override string _GetTemplateForResponseUseSocialSignOn()
	{
		return "无法登录。请使用社交网络登录。";
	}

	/// <summary>
	/// Key: "Response.WeChatNotRealNameVerified"
	/// English String: "Your WeChat is not real-name verified. Please use a real-name verified WeChat account and try again. Please visit {url}"
	/// </summary>
	public override string ResponseWeChatNotRealNameVerified(string url)
	{
		return $"你的微信未经过实名认证。请使用通过实名验证的微信帐户并重试。要了解更多信息，请访问 {url}";
	}

	protected override string _GetTemplateForResponseWeChatNotRealNameVerified()
	{
		return "你的微信未经过实名认证。请使用通过实名验证的微信帐户并重试。要了解更多信息，请访问 {url}";
	}

	protected override string _GetTemplateForWeChatAntiAddictionText()
	{
		return "抵制不良游戏，拒绝盗版游戏。注意自我保护，谨防受骗上当。适度游戏益脑，沉迷游戏伤身。合理安排时间，享受健康生活。";
	}

	protected override string _GetTemplateForWeChatRealNameNotVerified()
	{
		return "你的微信未经过实名认证。请使用通过实名验证的微信帐户并重试。要了解更多信息，请访问 https://jiazhang.qq.com/zk/home.html";
	}
}
