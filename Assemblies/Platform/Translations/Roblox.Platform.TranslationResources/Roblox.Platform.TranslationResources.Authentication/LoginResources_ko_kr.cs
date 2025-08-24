namespace Roblox.TranslationResources.Authentication;

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
	public override string ActionCancel => "취소";

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
	public override string ActionForgotPasswordOrUsernameQuestion => "비밀번호 또는 사용자 이름을 잊으셨나요?";

	/// <summary>
	/// Key: "Action.ForgotPasswordOrUsernameQuestionCapitalized"
	/// link under login form
	/// English String: "Forgot Password or Username?"
	/// </summary>
	public override string ActionForgotPasswordOrUsernameQuestionCapitalized => "비밀번호 또는 사용자 이름을 잊으셨나요?";

	/// <summary>
	/// Key: "Action.Login"
	/// English String: "Login"
	/// </summary>
	public override string ActionLogin => "로그인";

	/// <summary>
	/// Key: "Action.LogInCapitalized"
	/// login button label. please note this is different from 'Login' or 'Log in'.
	/// English String: "Log In"
	/// </summary>
	public override string ActionLogInCapitalized => "로그인";

	/// <summary>
	/// Key: "Action.Ok"
	/// button text
	/// English String: "OK"
	/// </summary>
	public override string ActionOk => "확인";

	/// <summary>
	/// Key: "Action.PlayAsGuest"
	/// Play as Guest
	/// English String: "Play as Guest"
	/// </summary>
	public override string ActionPlayAsGuest => "게스트로 플레이";

	/// <summary>
	/// Key: "Action.Resend"
	/// button text for resending verification email
	/// English String: "Resend"
	/// </summary>
	public override string ActionResend => "재전송";

	/// <summary>
	/// Key: "Action.ResendEmail"
	/// link that resends verification email to user
	/// English String: "Resend Email"
	/// </summary>
	public override string ActionResendEmail => "이메일 재전송";

	/// <summary>
	/// Key: "Action.SendVerificationEmail"
	/// button user can click to send a verification link to their email
	/// English String: "Send Verification Email"
	/// </summary>
	public override string ActionSendVerificationEmail => "인증 이메일 보내기";

	/// <summary>
	/// Key: "Action.SignIn"
	/// Sign In button text
	/// English String: "Sign In"
	/// </summary>
	public override string ActionSignIn => "로그인";

	/// <summary>
	/// Key: "Action.SignInWithFacebook"
	/// Sign In with Facebook
	/// English String: "Sign In with Facebook"
	/// </summary>
	public override string ActionSignInWithFacebook => "Facebook으로 로그인";

	/// <summary>
	/// Key: "Action.SignUp"
	/// English String: "Sign up"
	/// </summary>
	public override string ActionSignUp => "회원가입";

	/// <summary>
	/// Key: "Action.SignUpCapitalized"
	/// link which takes user to sign up page
	/// English String: "Sign Up"
	/// </summary>
	public override string ActionSignUpCapitalized => "회원가입";

	/// <summary>
	/// Key: "Action.WeChatLogin"
	/// button text for logging in with WeChat
	/// English String: "WeChat Login"
	/// </summary>
	public override string ActionWeChatLogin => "WeChat 로그인";

	/// <summary>
	/// Key: "Heading.Login"
	/// heading on the login page
	/// English String: "Login"
	/// </summary>
	public override string HeadingLogin => "로그인";

	/// <summary>
	/// Key: "Heading.LoginRoblox"
	/// current login page heading
	/// English String: "Login to Roblox"
	/// </summary>
	public override string HeadingLoginRoblox => "Roblox에 로그인";

	public override string HeadingSignUpMakeFriends => "회원가입하셔서 게임도 만들고 친구도 사귀어 보세요";

	/// <summary>
	/// Key: "Label.AccountNotNeeded"
	/// You don't need an account to play Roblox
	/// English String: "You don't need an account to play Roblox"
	/// </summary>
	public override string LabelAccountNotNeeded => "계정이 없어도 Roblox를 즐길 수 있어요";

	/// <summary>
	/// Key: "Label.EmailNeedsVerification"
	/// modal header used for prompting user they need to verify their email in order to log in with it
	/// English String: "Your email needs verification"
	/// </summary>
	public override string LabelEmailNeedsVerification => "이메일 인증이 필요합니다";

	/// <summary>
	/// Key: "Label.FacebookCreatePasswordWarning"
	/// If you have been signing in with Facebook, you must set a password.
	/// English String: "If you have been signing in with Facebook, you must set a password."
	/// </summary>
	public override string LabelFacebookCreatePasswordWarning => "Facebook으로 로그인한 경우, 비밀번호를 설정해야 합니다.";

	/// <summary>
	/// Key: "Label.ForgotUsernamePassword"
	/// landing page top right link for password reset
	/// English String: "Forgot Username/Password?"
	/// </summary>
	public override string LabelForgotUsernamePassword => "사용자 이름/비밀번호를 잊으셨나요?";

	/// <summary>
	/// Key: "Label.LearnMore"
	/// learn more link text
	/// English String: "Learn more"
	/// </summary>
	public override string LabelLearnMore => "더 알아보기";

	/// <summary>
	/// Key: "Label.LoggingInSpinnerText"
	/// English String: "Logging in…"
	/// </summary>
	public override string LabelLoggingInSpinnerText => "로그인 중...";

	/// <summary>
	/// Key: "Label.Login"
	/// English String: "Log in"
	/// </summary>
	public override string LabelLogin => "로그인";

	/// <summary>
	/// Key: "Label.LoginWithYour"
	/// Label for a partition line between login with email and facebook login. Please keep the text in lowercase for roman characters.
	/// English String: "login with your"
	/// </summary>
	public override string LabelLoginWithYour => "다음으로 로그인";

	/// <summary>
	/// Key: "Label.NoAccount"
	/// Don't have an account?
	/// English String: "Don't have an account?"
	/// </summary>
	public override string LabelNoAccount => "계정이 없으신가요?";

	/// <summary>
	/// Key: "Label.NonAMemberQuestion"
	/// The question heading for the section on the login page to take use to sign up page.
	/// English String: "Not a member?"
	/// </summary>
	public override string LabelNonAMemberQuestion => "회원이 아니신가요?";

	/// <summary>
	/// Key: "Label.NotReceived"
	/// prompt for allowing users to resend verification email
	/// English String: "Didn't receive it?"
	/// </summary>
	public override string LabelNotReceived => "이메일을 받지 못하셨나요?";

	/// <summary>
	/// Key: "Label.Or"
	/// partition between email login and facebook login
	/// English String: "Or"
	/// </summary>
	public override string LabelOr => "또는";

	/// <summary>
	/// Key: "Label.Password"
	/// Password
	/// English String: "Password"
	/// </summary>
	public override string LabelPassword => "비밀번호";

	/// <summary>
	/// Key: "Label.PasswordWithColumn"
	/// label for the password field on the login page
	/// English String: "Password:"
	/// </summary>
	public override string LabelPasswordWithColumn => "비밀번호:";

	/// <summary>
	/// Key: "Label.StartPlaying"
	/// You can start playing right now, in guest mode!
	/// English String: "You can start playing right now, in guest mode!"
	/// </summary>
	public override string LabelStartPlaying => "게스트 모드로 지금 게임을 시작해보세요!";

	/// <summary>
	/// Key: "Label.UnverifiedEmailInstructions"
	/// message shown in a modal when user logs in with unverified email
	/// English String: "To log in with your email, it must be verified. You can also log in with your username."
	/// </summary>
	public override string LabelUnverifiedEmailInstructions => "이메일로 로그인하려면 먼저 인증해야 합니다. 사용자 이름으로도 로그인할 수 있어요.";

	/// <summary>
	/// Key: "Label.Username"
	/// English String: "Username"
	/// </summary>
	public override string LabelUsername => "사용자 이름";

	/// <summary>
	/// Key: "Label.UsernameEmail"
	/// placeholder text for input field that accepts username or email
	/// English String: "Username/Email"
	/// </summary>
	public override string LabelUsernameEmail => "사용자 이름/이메일";

	/// <summary>
	/// Key: "Label.UsernameEmailPhone"
	/// placeholder text for input fields that accept username, email or phone
	/// English String: "Username/Email/Phone"
	/// </summary>
	public override string LabelUsernameEmailPhone => "사용자 이름/이메일/전화번호";

	/// <summary>
	/// Key: "Label.UsernamePhone"
	/// placeholder text for input field that accepts username or phone
	/// English String: "Username/Phone"
	/// </summary>
	public override string LabelUsernamePhone => "사용자 이름/전화번호";

	/// <summary>
	/// Key: "Label.UsernameWithColumn"
	/// label for username field on login page
	/// English String: "Username:"
	/// </summary>
	public override string LabelUsernameWithColumn => "사용자 이름:";

	/// <summary>
	/// Key: "Label.VerificationEmailSent"
	/// message telling user a verification email was sent to them
	/// English String: "Verification Email Sent!"
	/// </summary>
	public override string LabelVerificationEmailSent => "인증 이메일 전송 완료!";

	/// <summary>
	/// Key: "Label.WeChatAntiAddictionText"
	/// English String: "Boycott bad games, refuse pirated games. Be aware of self-defense and being deceived. Playing games is good for your brain, but too much game play can harm your health. Manage your time well and enjoy a healthy lifestyle."
	/// </summary>
	public override string LabelWeChatAntiAddictionText => "건전하지 않은 게임과 저작권 문제가 있는 게임은 플레이하지 마시고, 사기 행위에 연루되지 않도록 스스로를 보호하세요. 게임은 두뇌 발달에 도움이 되지만, 지나친 게임 플레이는 건강에 좋지 않습니다. 플레이 시간을 잘 조절해서 건강하게 게임을 즐기세요.";

	/// <summary>
	/// Key: "Message.UnknownErrorTryAgain"
	/// An unknown error occurred. Please try again.
	/// English String: "An unknown error occurred. Please try again."
	/// </summary>
	public override string MessageUnknownErrorTryAgain => "알 수 없는 오류가 발생했습니다.\u00a0나중에 다시 시도하세요.";

	/// <summary>
	/// Key: "Message.UsernameAndPasswordRequired"
	/// message shown to user when they attempt to login without entering a username or password
	/// English String: "Username and password required"
	/// </summary>
	public override string MessageUsernameAndPasswordRequired => "사용자 이름 및 비밀번호가 필요합니다";

	/// <summary>
	/// Key: "Response.AccountIssueErrorContactSupport"
	/// English String: "Account issue. Please contact Support."
	/// </summary>
	public override string ResponseAccountIssueErrorContactSupport => "계정 오류.\u00a0고객지원으로 문의하세요.";

	/// <summary>
	/// Key: "Response.AccountLockedRequestReset"
	/// Account has been locked. Please request a password reset.
	/// English String: "Account has been locked. Please request a password reset."
	/// </summary>
	public override string ResponseAccountLockedRequestReset => "계정이 잠겼습니다. 비밀번호 재설정을 요청하세요.";

	/// <summary>
	/// Key: "Response.AccountNotFound"
	/// Account not found. Please try again.
	/// English String: "Account not found. Please try again."
	/// </summary>
	public override string ResponseAccountNotFound => "계정을 찾을 수 없습니다. 다시 시도하세요.";

	/// <summary>
	/// Key: "Response.EmailLinkedToMultipleAccountsLoginWithUsername"
	/// error message displayed when user attempts to log in with an email that is linked to multiple accounts
	/// English String: "Your email is associated with more than 1 username. Please login with your username."
	/// </summary>
	public override string ResponseEmailLinkedToMultipleAccountsLoginWithUsername => "이메일이 1개 이상의 사용자 이름과 연결되어 있습니다. 사용자 이름으로 로그인하세요.";

	/// <summary>
	/// Key: "Response.EmailSent"
	/// response telling user that a verification email has been sent to them
	/// English String: "Email sent!"
	/// </summary>
	public override string ResponseEmailSent => "이메일 전송 완료!";

	/// <summary>
	/// Key: "Response.IncorrectEmailOrPassword"
	/// error message displayed when user logs in with an invalid email or password
	/// English String: "Incorrect email or password."
	/// </summary>
	public override string ResponseIncorrectEmailOrPassword => "이메일 또는 비밀번호가 일치하지 않습니다.";

	/// <summary>
	/// Key: "Response.IncorrectPhoneOrPassword"
	/// error message displayed when user logs in with an invalid phone or password
	/// English String: "Incorrect phone or password."
	/// </summary>
	public override string ResponseIncorrectPhoneOrPassword => "전화번호 또는 비밀번호가 일치하지 않습니다.";

	/// <summary>
	/// Key: "Response.IncorrectUsernamePassword"
	/// English String: "Incorrect username or password."
	/// </summary>
	public override string ResponseIncorrectUsernamePassword => "사용자 이름 또는 비밀번호가 일치하지 않습니다.";

	/// <summary>
	/// Key: "Response.LoginWithUsername"
	/// error message shown when user attempts to login with method other than username and an error occurred
	/// English String: "Something went wrong. Please login with your username."
	/// </summary>
	public override string ResponseLoginWithUsername => "오류가 발생했어요. 사용자 이름으로 로그인하세요.";

	/// <summary>
	/// Key: "Response.PasswordNotProvided"
	/// password field is empty
	/// English String: "You must enter a password."
	/// </summary>
	public override string ResponsePasswordNotProvided => "비밀번호를 입력해야 합니다.";

	/// <summary>
	/// Key: "Response.TooManyAttemptsPleaseWait"
	/// English String: "Too many attempts. Please wait a bit."
	/// </summary>
	public override string ResponseTooManyAttemptsPleaseWait => "시도 가능 횟수를 초과했습니다. 잠시 기다려주세요.";

	/// <summary>
	/// Key: "Response.UnknownError"
	/// English String: "Unknown Error"
	/// </summary>
	public override string ResponseUnknownError => "알 수 없는 오류";

	/// <summary>
	/// Key: "Response.UnknownLoginError"
	/// Unknown login failure.
	/// English String: "Unknown login failure."
	/// </summary>
	public override string ResponseUnknownLoginError => "알 수 없는 로그인 실패.";

	/// <summary>
	/// Key: "Response.UnverifiedEmailLoginWithUsername"
	/// error message shown when user attempts to login with unverified email
	/// English String: "Your email is not verified. Please login with your username."
	/// </summary>
	public override string ResponseUnverifiedEmailLoginWithUsername => "인증되지 않은 이메일입니다. 사용자 이름으로 로그인하세요.";

	/// <summary>
	/// Key: "Response.UnverifiedPhoneLoginWithUsername"
	/// error message shown when user attempts to login with an unverified phone number
	/// English String: "Your phone is not verified. Please login with your username."
	/// </summary>
	public override string ResponseUnverifiedPhoneLoginWithUsername => "인증되지 않은 전화번호입니다. 사용자 이름으로 로그인하세요.";

	/// <summary>
	/// Key: "Response.UsernameNotProvided"
	/// username field is empty
	/// English String: "You must enter a username."
	/// </summary>
	public override string ResponseUsernameNotProvided => "사용자 이름을 입력해야 합니다.";

	/// <summary>
	/// Key: "Response.UseSocialSignOn"
	/// Unable to login. Please use Social Network sign on.
	/// English String: "Unable to login. Please use Social Network sign on."
	/// </summary>
	public override string ResponseUseSocialSignOn => "로그인 불가. 소셜 네트워크로 로그인하세요.";

	/// <summary>
	/// Key: "WeChat.AntiAddictionText"
	/// English String: "Boycott bad games, refuse pirated games. Be aware of self-defense and being deceived. Playing games is good for your brain, but too much game play can harm your health. Manage your time well and enjoy a healthy lifestyle."
	/// </summary>
	public override string WeChatAntiAddictionText => "건전하지 않은 게임과 저작권 문제가 있는 게임은 플레이하지 마시고, 사기 행위에 연루되지 않도록 스스로를 보호하세요. 게임은 두뇌 발달에 도움이 되지만, 지나친 게임 플레이는 건강에 좋지 않습니다. 플레이 시간을 잘 조절해서 건강하게 게임을 즐기세요.";

	/// <summary>
	/// Key: "WeChat.RealNameNotVerified"
	/// English String: "Your WeChat is not real-name verified. Please use a real-name verified WeChat account and try again. Please visit https://jiazhang.qq.com/zk/home.html"
	/// </summary>
	public override string WeChatRealNameNotVerified => "실명 인증이 되지 않은 WeChat 계정이에요. 실명 인증된 WeChat 계정으로 다시 시도해야 해요. 다음 링크를 방문해 주세요. https://jiazhang.qq.com/zk/home.html";

	public LoginResources_ko_kr(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionCancel()
	{
		return "취소";
	}

	protected override string _GetTemplateForActionFacebook()
	{
		return "Facebook:";
	}

	protected override string _GetTemplateForActionForgotPasswordOrUsernameQuestion()
	{
		return "비밀번호 또는 사용자 이름을 잊으셨나요?";
	}

	protected override string _GetTemplateForActionForgotPasswordOrUsernameQuestionCapitalized()
	{
		return "비밀번호 또는 사용자 이름을 잊으셨나요?";
	}

	protected override string _GetTemplateForActionLogin()
	{
		return "로그인";
	}

	protected override string _GetTemplateForActionLogInCapitalized()
	{
		return "로그인";
	}

	protected override string _GetTemplateForActionOk()
	{
		return "확인";
	}

	protected override string _GetTemplateForActionPlayAsGuest()
	{
		return "게스트로 플레이";
	}

	protected override string _GetTemplateForActionResend()
	{
		return "재전송";
	}

	protected override string _GetTemplateForActionResendEmail()
	{
		return "이메일 재전송";
	}

	protected override string _GetTemplateForActionSendVerificationEmail()
	{
		return "인증 이메일 보내기";
	}

	protected override string _GetTemplateForActionSignIn()
	{
		return "로그인";
	}

	protected override string _GetTemplateForActionSignInWithFacebook()
	{
		return "Facebook으로 로그인";
	}

	protected override string _GetTemplateForActionSignUp()
	{
		return "회원가입";
	}

	protected override string _GetTemplateForActionSignUpCapitalized()
	{
		return "회원가입";
	}

	protected override string _GetTemplateForActionWeChatLogin()
	{
		return "WeChat 로그인";
	}

	protected override string _GetTemplateForHeadingLogin()
	{
		return "로그인";
	}

	protected override string _GetTemplateForHeadingLoginRoblox()
	{
		return "Roblox에 로그인";
	}

	protected override string _GetTemplateForHeadingSignUpMakeFriends()
	{
		return "회원가입하셔서 게임도 만들고 친구도 사귀어 보세요";
	}

	protected override string _GetTemplateForLabelAccountNotNeeded()
	{
		return "계정이 없어도 Roblox를 즐길 수 있어요";
	}

	protected override string _GetTemplateForLabelEmailNeedsVerification()
	{
		return "이메일 인증이 필요합니다";
	}

	protected override string _GetTemplateForLabelFacebookCreatePasswordWarning()
	{
		return "Facebook으로 로그인한 경우, 비밀번호를 설정해야 합니다.";
	}

	protected override string _GetTemplateForLabelForgotUsernamePassword()
	{
		return "사용자 이름/비밀번호를 잊으셨나요?";
	}

	/// <summary>
	/// Key: "Label.GreetingForNewAccount"
	/// Shown when a username doesn't exist on the login page to invite to create a new account.
	/// English String: "Nice to meet you, {username}. {linkStartSignup}Let's make an account! {linkEndSignup}"
	/// </summary>
	public override string LabelGreetingForNewAccount(string username, string linkStartSignup, string linkEndSignup)
	{
		return $"{username} 님, 안녕하세요. {linkStartSignup}계정을 만드세요! {linkEndSignup}";
	}

	protected override string _GetTemplateForLabelGreetingForNewAccount()
	{
		return "{username} 님, 안녕하세요. {linkStartSignup}계정을 만드세요! {linkEndSignup}";
	}

	protected override string _GetTemplateForLabelLearnMore()
	{
		return "더 알아보기";
	}

	protected override string _GetTemplateForLabelLoggingInSpinnerText()
	{
		return "로그인 중...";
	}

	protected override string _GetTemplateForLabelLogin()
	{
		return "로그인";
	}

	protected override string _GetTemplateForLabelLoginWithYour()
	{
		return "다음으로 로그인";
	}

	protected override string _GetTemplateForLabelNoAccount()
	{
		return "계정이 없으신가요?";
	}

	protected override string _GetTemplateForLabelNonAMemberQuestion()
	{
		return "회원이 아니신가요?";
	}

	protected override string _GetTemplateForLabelNotReceived()
	{
		return "이메일을 받지 못하셨나요?";
	}

	protected override string _GetTemplateForLabelOr()
	{
		return "또는";
	}

	protected override string _GetTemplateForLabelPassword()
	{
		return "비밀번호";
	}

	protected override string _GetTemplateForLabelPasswordWithColumn()
	{
		return "비밀번호:";
	}

	protected override string _GetTemplateForLabelStartPlaying()
	{
		return "게스트 모드로 지금 게임을 시작해보세요!";
	}

	protected override string _GetTemplateForLabelUnverifiedEmailInstructions()
	{
		return "이메일로 로그인하려면 먼저 인증해야 합니다. 사용자 이름으로도 로그인할 수 있어요.";
	}

	protected override string _GetTemplateForLabelUsername()
	{
		return "사용자 이름";
	}

	protected override string _GetTemplateForLabelUsernameEmail()
	{
		return "사용자 이름/이메일";
	}

	protected override string _GetTemplateForLabelUsernameEmailPhone()
	{
		return "사용자 이름/이메일/전화번호";
	}

	protected override string _GetTemplateForLabelUsernamePhone()
	{
		return "사용자 이름/전화번호";
	}

	protected override string _GetTemplateForLabelUsernameWithColumn()
	{
		return "사용자 이름:";
	}

	protected override string _GetTemplateForLabelVerificationEmailSent()
	{
		return "인증 이메일 전송 완료!";
	}

	protected override string _GetTemplateForLabelWeChatAntiAddictionText()
	{
		return "건전하지 않은 게임과 저작권 문제가 있는 게임은 플레이하지 마시고, 사기 행위에 연루되지 않도록 스스로를 보호하세요. 게임은 두뇌 발달에 도움이 되지만, 지나친 게임 플레이는 건강에 좋지 않습니다. 플레이 시간을 잘 조절해서 건강하게 게임을 즐기세요.";
	}

	protected override string _GetTemplateForMessageUnknownErrorTryAgain()
	{
		return "알 수 없는 오류가 발생했습니다.\u00a0나중에 다시 시도하세요.";
	}

	protected override string _GetTemplateForMessageUsernameAndPasswordRequired()
	{
		return "사용자 이름 및 비밀번호가 필요합니다";
	}

	protected override string _GetTemplateForResponseAccountIssueErrorContactSupport()
	{
		return "계정 오류.\u00a0고객지원으로 문의하세요.";
	}

	protected override string _GetTemplateForResponseAccountLockedRequestReset()
	{
		return "계정이 잠겼습니다. 비밀번호 재설정을 요청하세요.";
	}

	protected override string _GetTemplateForResponseAccountNotFound()
	{
		return "계정을 찾을 수 없습니다. 다시 시도하세요.";
	}

	protected override string _GetTemplateForResponseEmailLinkedToMultipleAccountsLoginWithUsername()
	{
		return "이메일이 1개 이상의 사용자 이름과 연결되어 있습니다. 사용자 이름으로 로그인하세요.";
	}

	protected override string _GetTemplateForResponseEmailSent()
	{
		return "이메일 전송 완료!";
	}

	protected override string _GetTemplateForResponseIncorrectEmailOrPassword()
	{
		return "이메일 또는 비밀번호가 일치하지 않습니다.";
	}

	protected override string _GetTemplateForResponseIncorrectPhoneOrPassword()
	{
		return "전화번호 또는 비밀번호가 일치하지 않습니다.";
	}

	protected override string _GetTemplateForResponseIncorrectUsernamePassword()
	{
		return "사용자 이름 또는 비밀번호가 일치하지 않습니다.";
	}

	protected override string _GetTemplateForResponseLoginWithUsername()
	{
		return "오류가 발생했어요. 사용자 이름으로 로그인하세요.";
	}

	protected override string _GetTemplateForResponsePasswordNotProvided()
	{
		return "비밀번호를 입력해야 합니다.";
	}

	protected override string _GetTemplateForResponseTooManyAttemptsPleaseWait()
	{
		return "시도 가능 횟수를 초과했습니다. 잠시 기다려주세요.";
	}

	protected override string _GetTemplateForResponseUnknownError()
	{
		return "알 수 없는 오류";
	}

	protected override string _GetTemplateForResponseUnknownLoginError()
	{
		return "알 수 없는 로그인 실패.";
	}

	protected override string _GetTemplateForResponseUnverifiedEmailLoginWithUsername()
	{
		return "인증되지 않은 이메일입니다. 사용자 이름으로 로그인하세요.";
	}

	protected override string _GetTemplateForResponseUnverifiedPhoneLoginWithUsername()
	{
		return "인증되지 않은 전화번호입니다. 사용자 이름으로 로그인하세요.";
	}

	protected override string _GetTemplateForResponseUsernameNotProvided()
	{
		return "사용자 이름을 입력해야 합니다.";
	}

	protected override string _GetTemplateForResponseUseSocialSignOn()
	{
		return "로그인 불가. 소셜 네트워크로 로그인하세요.";
	}

	/// <summary>
	/// Key: "Response.WeChatNotRealNameVerified"
	/// English String: "Your WeChat is not real-name verified. Please use a real-name verified WeChat account and try again. Please visit {url}"
	/// </summary>
	public override string ResponseWeChatNotRealNameVerified(string url)
	{
		return $"실명 인증이 되지 않은 WeChat 계정이에요. 실명 인증된 WeChat 계정으로 다시 시도해 주세요. 다음 링크를 방문하세요. {url}";
	}

	protected override string _GetTemplateForResponseWeChatNotRealNameVerified()
	{
		return "실명 인증이 되지 않은 WeChat 계정이에요. 실명 인증된 WeChat 계정으로 다시 시도해 주세요. 다음 링크를 방문하세요. {url}";
	}

	protected override string _GetTemplateForWeChatAntiAddictionText()
	{
		return "건전하지 않은 게임과 저작권 문제가 있는 게임은 플레이하지 마시고, 사기 행위에 연루되지 않도록 스스로를 보호하세요. 게임은 두뇌 발달에 도움이 되지만, 지나친 게임 플레이는 건강에 좋지 않습니다. 플레이 시간을 잘 조절해서 건강하게 게임을 즐기세요.";
	}

	protected override string _GetTemplateForWeChatRealNameNotVerified()
	{
		return "실명 인증이 되지 않은 WeChat 계정이에요. 실명 인증된 WeChat 계정으로 다시 시도해야 해요. 다음 링크를 방문해 주세요. https://jiazhang.qq.com/zk/home.html";
	}
}
