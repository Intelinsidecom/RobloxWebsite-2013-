namespace Roblox.TranslationResources.Authentication;

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
	public override string ActionCancel => "Отмена";

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
	public override string ActionForgotPasswordOrUsernameQuestion => "Забыли пароль или имя пользователя?";

	/// <summary>
	/// Key: "Action.ForgotPasswordOrUsernameQuestionCapitalized"
	/// link under login form
	/// English String: "Forgot Password or Username?"
	/// </summary>
	public override string ActionForgotPasswordOrUsernameQuestionCapitalized => "Забыли пароль или имя пользователя?";

	/// <summary>
	/// Key: "Action.Login"
	/// English String: "Login"
	/// </summary>
	public override string ActionLogin => "Вход";

	/// <summary>
	/// Key: "Action.LogInCapitalized"
	/// login button label. please note this is different from 'Login' or 'Log in'.
	/// English String: "Log In"
	/// </summary>
	public override string ActionLogInCapitalized => "Вход";

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
	public override string ActionPlayAsGuest => "Играть в гостевом режиме";

	/// <summary>
	/// Key: "Action.Resend"
	/// button text for resending verification email
	/// English String: "Resend"
	/// </summary>
	public override string ActionResend => "Отправить заново";

	/// <summary>
	/// Key: "Action.ResendEmail"
	/// link that resends verification email to user
	/// English String: "Resend Email"
	/// </summary>
	public override string ActionResendEmail => "Отправить сообщение заново";

	/// <summary>
	/// Key: "Action.SendVerificationEmail"
	/// button user can click to send a verification link to their email
	/// English String: "Send Verification Email"
	/// </summary>
	public override string ActionSendVerificationEmail => "Выслать письмо для подтверждения";

	/// <summary>
	/// Key: "Action.SignIn"
	/// Sign In button text
	/// English String: "Sign In"
	/// </summary>
	public override string ActionSignIn => "Войти";

	/// <summary>
	/// Key: "Action.SignInWithFacebook"
	/// Sign In with Facebook
	/// English String: "Sign In with Facebook"
	/// </summary>
	public override string ActionSignInWithFacebook => "Войти через Facebook";

	/// <summary>
	/// Key: "Action.SignUp"
	/// English String: "Sign up"
	/// </summary>
	public override string ActionSignUp => "Регистрация";

	/// <summary>
	/// Key: "Action.SignUpCapitalized"
	/// link which takes user to sign up page
	/// English String: "Sign Up"
	/// </summary>
	public override string ActionSignUpCapitalized => "Регистрация";

	/// <summary>
	/// Key: "Action.WeChatLogin"
	/// button text for logging in with WeChat
	/// English String: "WeChat Login"
	/// </summary>
	public override string ActionWeChatLogin => "Вход в WeChat";

	/// <summary>
	/// Key: "Heading.Login"
	/// heading on the login page
	/// English String: "Login"
	/// </summary>
	public override string HeadingLogin => "Вход";

	/// <summary>
	/// Key: "Heading.LoginRoblox"
	/// current login page heading
	/// English String: "Login to Roblox"
	/// </summary>
	public override string HeadingLoginRoblox => "Вход в Roblox";

	public override string HeadingSignUpMakeFriends => "Зарегистрируйтесь, чтобы строить и заводить друзей";

	/// <summary>
	/// Key: "Label.AccountNotNeeded"
	/// You don't need an account to play Roblox
	/// English String: "You don't need an account to play Roblox"
	/// </summary>
	public override string LabelAccountNotNeeded => "Вы можете играть в Roblox без учетной записи";

	/// <summary>
	/// Key: "Label.EmailNeedsVerification"
	/// modal header used for prompting user they need to verify their email in order to log in with it
	/// English String: "Your email needs verification"
	/// </summary>
	public override string LabelEmailNeedsVerification => "Адрес Вашей эл. почты нужно подтвердить";

	/// <summary>
	/// Key: "Label.FacebookCreatePasswordWarning"
	/// If you have been signing in with Facebook, you must set a password.
	/// English String: "If you have been signing in with Facebook, you must set a password."
	/// </summary>
	public override string LabelFacebookCreatePasswordWarning => "Если вы использовали учетную запись Facebook, необходимо указать пароль.";

	/// <summary>
	/// Key: "Label.ForgotUsernamePassword"
	/// landing page top right link for password reset
	/// English String: "Forgot Username/Password?"
	/// </summary>
	public override string LabelForgotUsernamePassword => "Забыли имя пользователя или пароль?";

	/// <summary>
	/// Key: "Label.LearnMore"
	/// learn more link text
	/// English String: "Learn more"
	/// </summary>
	public override string LabelLearnMore => "Подробнее";

	/// <summary>
	/// Key: "Label.LoggingInSpinnerText"
	/// English String: "Logging in…"
	/// </summary>
	public override string LabelLoggingInSpinnerText => "Вход...";

	/// <summary>
	/// Key: "Label.Login"
	/// English String: "Log in"
	/// </summary>
	public override string LabelLogin => "Вход";

	/// <summary>
	/// Key: "Label.LoginWithYour"
	/// Label for a partition line between login with email and facebook login. Please keep the text in lowercase for roman characters.
	/// English String: "login with your"
	/// </summary>
	public override string LabelLoginWithYour => "Вход с помощью";

	/// <summary>
	/// Key: "Label.NoAccount"
	/// Don't have an account?
	/// English String: "Don't have an account?"
	/// </summary>
	public override string LabelNoAccount => "Нет учетной записи?";

	/// <summary>
	/// Key: "Label.NonAMemberQuestion"
	/// The question heading for the section on the login page to take use to sign up page.
	/// English String: "Not a member?"
	/// </summary>
	public override string LabelNonAMemberQuestion => "Не зарегистрированы?";

	/// <summary>
	/// Key: "Label.NotReceived"
	/// prompt for allowing users to resend verification email
	/// English String: "Didn't receive it?"
	/// </summary>
	public override string LabelNotReceived => "Вы не получили его?";

	/// <summary>
	/// Key: "Label.Or"
	/// partition between email login and facebook login
	/// English String: "Or"
	/// </summary>
	public override string LabelOr => "Или";

	/// <summary>
	/// Key: "Label.Password"
	/// Password
	/// English String: "Password"
	/// </summary>
	public override string LabelPassword => "Пароль";

	/// <summary>
	/// Key: "Label.PasswordWithColumn"
	/// label for the password field on the login page
	/// English String: "Password:"
	/// </summary>
	public override string LabelPasswordWithColumn => "Пароль:";

	/// <summary>
	/// Key: "Label.StartPlaying"
	/// You can start playing right now, in guest mode!
	/// English String: "You can start playing right now, in guest mode!"
	/// </summary>
	public override string LabelStartPlaying => "Начните играть прямо сейчас в гостевом режиме!";

	/// <summary>
	/// Key: "Label.UnverifiedEmailInstructions"
	/// message shown in a modal when user logs in with unverified email
	/// English String: "To log in with your email, it must be verified. You can also log in with your username."
	/// </summary>
	public override string LabelUnverifiedEmailInstructions => "Чтобы войти с помощью эл. почты, адрес нужно подтвердить. Вы также можете использовать имя пользователя для входа.";

	/// <summary>
	/// Key: "Label.Username"
	/// English String: "Username"
	/// </summary>
	public override string LabelUsername => "Имя пользователя";

	/// <summary>
	/// Key: "Label.UsernameEmail"
	/// placeholder text for input field that accepts username or email
	/// English String: "Username/Email"
	/// </summary>
	public override string LabelUsernameEmail => "Имя пользователя/эл. почта";

	/// <summary>
	/// Key: "Label.UsernameEmailPhone"
	/// placeholder text for input fields that accept username, email or phone
	/// English String: "Username/Email/Phone"
	/// </summary>
	public override string LabelUsernameEmailPhone => "Имя пользователя/эл. почта/номер телефона";

	/// <summary>
	/// Key: "Label.UsernamePhone"
	/// placeholder text for input field that accepts username or phone
	/// English String: "Username/Phone"
	/// </summary>
	public override string LabelUsernamePhone => "Имя пользователя/номер телефона";

	/// <summary>
	/// Key: "Label.UsernameWithColumn"
	/// label for username field on login page
	/// English String: "Username:"
	/// </summary>
	public override string LabelUsernameWithColumn => "Имя пользователя:";

	/// <summary>
	/// Key: "Label.VerificationEmailSent"
	/// message telling user a verification email was sent to them
	/// English String: "Verification Email Sent!"
	/// </summary>
	public override string LabelVerificationEmailSent => "Письмо для подтверждения отправлено!";

	/// <summary>
	/// Key: "Label.WeChatAntiAddictionText"
	/// English String: "Boycott bad games, refuse pirated games. Be aware of self-defense and being deceived. Playing games is good for your brain, but too much game play can harm your health. Manage your time well and enjoy a healthy lifestyle."
	/// </summary>
	public override string LabelWeChatAntiAddictionText => "Избегайте плохих и пиратских игр. Будьте осторожны, и вас не обманут. Игры помогают развивать мозг, однако не надо ими злоупотреблять – это может нанести вред здоровью. Разумно распределяйте свое время и наслаждайтесь правильным образом жизни!";

	/// <summary>
	/// Key: "Message.UnknownErrorTryAgain"
	/// An unknown error occurred. Please try again.
	/// English String: "An unknown error occurred. Please try again."
	/// </summary>
	public override string MessageUnknownErrorTryAgain => "Произошла неизвестная ошибка. Повторите попытку.";

	/// <summary>
	/// Key: "Message.UsernameAndPasswordRequired"
	/// message shown to user when they attempt to login without entering a username or password
	/// English String: "Username and password required"
	/// </summary>
	public override string MessageUsernameAndPasswordRequired => "Необходимо указать имя пользователя и пароль";

	/// <summary>
	/// Key: "Response.AccountIssueErrorContactSupport"
	/// English String: "Account issue. Please contact Support."
	/// </summary>
	public override string ResponseAccountIssueErrorContactSupport => "Ошибка учетной записи. Обратитесь в службу поддержки.";

	/// <summary>
	/// Key: "Response.AccountLockedRequestReset"
	/// Account has been locked. Please request a password reset.
	/// English String: "Account has been locked. Please request a password reset."
	/// </summary>
	public override string ResponseAccountLockedRequestReset => "Учетная запись заблокирована. Запросите сброс пароля.";

	/// <summary>
	/// Key: "Response.AccountNotFound"
	/// Account not found. Please try again.
	/// English String: "Account not found. Please try again."
	/// </summary>
	public override string ResponseAccountNotFound => "Учетная запись не найдена. Повторите попытку.";

	/// <summary>
	/// Key: "Response.EmailLinkedToMultipleAccountsLoginWithUsername"
	/// error message displayed when user attempts to log in with an email that is linked to multiple accounts
	/// English String: "Your email is associated with more than 1 username. Please login with your username."
	/// </summary>
	public override string ResponseEmailLinkedToMultipleAccountsLoginWithUsername => "Эта эл. почта привязана к нескольким пользователям. Пожалуйста, введите свое имя пользователя.";

	/// <summary>
	/// Key: "Response.EmailSent"
	/// response telling user that a verification email has been sent to them
	/// English String: "Email sent!"
	/// </summary>
	public override string ResponseEmailSent => "Сообщение отправлено!";

	/// <summary>
	/// Key: "Response.IncorrectEmailOrPassword"
	/// error message displayed when user logs in with an invalid email or password
	/// English String: "Incorrect email or password."
	/// </summary>
	public override string ResponseIncorrectEmailOrPassword => "Некорректные эл. почта или пароль.";

	/// <summary>
	/// Key: "Response.IncorrectPhoneOrPassword"
	/// error message displayed when user logs in with an invalid phone or password
	/// English String: "Incorrect phone or password."
	/// </summary>
	public override string ResponseIncorrectPhoneOrPassword => "Некорректные номер телефона или пароль.";

	/// <summary>
	/// Key: "Response.IncorrectUsernamePassword"
	/// English String: "Incorrect username or password."
	/// </summary>
	public override string ResponseIncorrectUsernamePassword => "Неправильные имя пользователя или пароль.";

	/// <summary>
	/// Key: "Response.LoginWithUsername"
	/// error message shown when user attempts to login with method other than username and an error occurred
	/// English String: "Something went wrong. Please login with your username."
	/// </summary>
	public override string ResponseLoginWithUsername => "Возникли проблемы. Пожалуйста, введите свое имя пользователя.";

	/// <summary>
	/// Key: "Response.PasswordNotProvided"
	/// password field is empty
	/// English String: "You must enter a password."
	/// </summary>
	public override string ResponsePasswordNotProvided => "Необходимо ввести пароль.";

	/// <summary>
	/// Key: "Response.TooManyAttemptsPleaseWait"
	/// English String: "Too many attempts. Please wait a bit."
	/// </summary>
	public override string ResponseTooManyAttemptsPleaseWait => "Слишком много попыток. Подождите.";

	/// <summary>
	/// Key: "Response.UnknownError"
	/// English String: "Unknown Error"
	/// </summary>
	public override string ResponseUnknownError => "Неизвестная ошибка";

	/// <summary>
	/// Key: "Response.UnknownLoginError"
	/// Unknown login failure.
	/// English String: "Unknown login failure."
	/// </summary>
	public override string ResponseUnknownLoginError => "Неизвестная ошибка входа";

	/// <summary>
	/// Key: "Response.UnverifiedEmailLoginWithUsername"
	/// error message shown when user attempts to login with unverified email
	/// English String: "Your email is not verified. Please login with your username."
	/// </summary>
	public override string ResponseUnverifiedEmailLoginWithUsername => "Эта эл. почта не подтверждена. Пожалуйста, введите свое имя пользователя.";

	/// <summary>
	/// Key: "Response.UnverifiedPhoneLoginWithUsername"
	/// error message shown when user attempts to login with an unverified phone number
	/// English String: "Your phone is not verified. Please login with your username."
	/// </summary>
	public override string ResponseUnverifiedPhoneLoginWithUsername => "Этот номер телефона не подтвержден. Пожалуйста, введите свое имя пользователя.";

	/// <summary>
	/// Key: "Response.UsernameNotProvided"
	/// username field is empty
	/// English String: "You must enter a username."
	/// </summary>
	public override string ResponseUsernameNotProvided => "Необходимо ввести имя пользователя.";

	/// <summary>
	/// Key: "Response.UseSocialSignOn"
	/// Unable to login. Please use Social Network sign on.
	/// English String: "Unable to login. Please use Social Network sign on."
	/// </summary>
	public override string ResponseUseSocialSignOn => "Не удалось войти в учетную запись. Войдите через социальную сеть.";

	/// <summary>
	/// Key: "WeChat.AntiAddictionText"
	/// English String: "Boycott bad games, refuse pirated games. Be aware of self-defense and being deceived. Playing games is good for your brain, but too much game play can harm your health. Manage your time well and enjoy a healthy lifestyle."
	/// </summary>
	public override string WeChatAntiAddictionText => "Избегайте плохих и пиратских игр. Будьте осторожны, и вас не обманут. Игры помогают развивать мозг, однако не надо с этим злоупотреблять – это может нанести вред здоровью. Разумно распределяйте свое время и наслаждайтесь правильным образом жизни!";

	/// <summary>
	/// Key: "WeChat.RealNameNotVerified"
	/// English String: "Your WeChat is not real-name verified. Please use a real-name verified WeChat account and try again. Please visit https://jiazhang.qq.com/zk/home.html"
	/// </summary>
	public override string WeChatRealNameNotVerified => "Ваше настоящее имя в WeChat не подтверждено. Пожалуйста, используйте свою реальную, подтвержденную в WeChat учетную запись, и попробуйте еще раз. Пожалуйста, перейдите на https://jiazhang.qq.com/zk/home.html";

	public LoginResources_ru_ru(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionCancel()
	{
		return "Отмена";
	}

	protected override string _GetTemplateForActionFacebook()
	{
		return "Facebook";
	}

	protected override string _GetTemplateForActionForgotPasswordOrUsernameQuestion()
	{
		return "Забыли пароль или имя пользователя?";
	}

	protected override string _GetTemplateForActionForgotPasswordOrUsernameQuestionCapitalized()
	{
		return "Забыли пароль или имя пользователя?";
	}

	protected override string _GetTemplateForActionLogin()
	{
		return "Вход";
	}

	protected override string _GetTemplateForActionLogInCapitalized()
	{
		return "Вход";
	}

	protected override string _GetTemplateForActionOk()
	{
		return "OK";
	}

	protected override string _GetTemplateForActionPlayAsGuest()
	{
		return "Играть в гостевом режиме";
	}

	protected override string _GetTemplateForActionResend()
	{
		return "Отправить заново";
	}

	protected override string _GetTemplateForActionResendEmail()
	{
		return "Отправить сообщение заново";
	}

	protected override string _GetTemplateForActionSendVerificationEmail()
	{
		return "Выслать письмо для подтверждения";
	}

	protected override string _GetTemplateForActionSignIn()
	{
		return "Войти";
	}

	protected override string _GetTemplateForActionSignInWithFacebook()
	{
		return "Войти через Facebook";
	}

	protected override string _GetTemplateForActionSignUp()
	{
		return "Регистрация";
	}

	protected override string _GetTemplateForActionSignUpCapitalized()
	{
		return "Регистрация";
	}

	protected override string _GetTemplateForActionWeChatLogin()
	{
		return "Вход в WeChat";
	}

	protected override string _GetTemplateForHeadingLogin()
	{
		return "Вход";
	}

	protected override string _GetTemplateForHeadingLoginRoblox()
	{
		return "Вход в Roblox";
	}

	protected override string _GetTemplateForHeadingSignUpMakeFriends()
	{
		return "Зарегистрируйтесь, чтобы строить и заводить друзей";
	}

	protected override string _GetTemplateForLabelAccountNotNeeded()
	{
		return "Вы можете играть в Roblox без учетной записи";
	}

	protected override string _GetTemplateForLabelEmailNeedsVerification()
	{
		return "Адрес Вашей эл. почты нужно подтвердить";
	}

	protected override string _GetTemplateForLabelFacebookCreatePasswordWarning()
	{
		return "Если вы использовали учетную запись Facebook, необходимо указать пароль.";
	}

	protected override string _GetTemplateForLabelForgotUsernamePassword()
	{
		return "Забыли имя пользователя или пароль?";
	}

	/// <summary>
	/// Key: "Label.GreetingForNewAccount"
	/// Shown when a username doesn't exist on the login page to invite to create a new account.
	/// English String: "Nice to meet you, {username}. {linkStartSignup}Let's make an account! {linkEndSignup}"
	/// </summary>
	public override string LabelGreetingForNewAccount(string username, string linkStartSignup, string linkEndSignup)
	{
		return $"Добро пожаловать, {username}. {linkStartSignup}Давайте создадим учетную запись! {linkEndSignup}";
	}

	protected override string _GetTemplateForLabelGreetingForNewAccount()
	{
		return "Добро пожаловать, {username}. {linkStartSignup}Давайте создадим учетную запись! {linkEndSignup}";
	}

	protected override string _GetTemplateForLabelLearnMore()
	{
		return "Подробнее";
	}

	protected override string _GetTemplateForLabelLoggingInSpinnerText()
	{
		return "Вход...";
	}

	protected override string _GetTemplateForLabelLogin()
	{
		return "Вход";
	}

	protected override string _GetTemplateForLabelLoginWithYour()
	{
		return "Вход с помощью";
	}

	protected override string _GetTemplateForLabelNoAccount()
	{
		return "Нет учетной записи?";
	}

	protected override string _GetTemplateForLabelNonAMemberQuestion()
	{
		return "Не зарегистрированы?";
	}

	protected override string _GetTemplateForLabelNotReceived()
	{
		return "Вы не получили его?";
	}

	protected override string _GetTemplateForLabelOr()
	{
		return "Или";
	}

	protected override string _GetTemplateForLabelPassword()
	{
		return "Пароль";
	}

	protected override string _GetTemplateForLabelPasswordWithColumn()
	{
		return "Пароль:";
	}

	protected override string _GetTemplateForLabelStartPlaying()
	{
		return "Начните играть прямо сейчас в гостевом режиме!";
	}

	protected override string _GetTemplateForLabelUnverifiedEmailInstructions()
	{
		return "Чтобы войти с помощью эл. почты, адрес нужно подтвердить. Вы также можете использовать имя пользователя для входа.";
	}

	protected override string _GetTemplateForLabelUsername()
	{
		return "Имя пользователя";
	}

	protected override string _GetTemplateForLabelUsernameEmail()
	{
		return "Имя пользователя/эл. почта";
	}

	protected override string _GetTemplateForLabelUsernameEmailPhone()
	{
		return "Имя пользователя/эл. почта/номер телефона";
	}

	protected override string _GetTemplateForLabelUsernamePhone()
	{
		return "Имя пользователя/номер телефона";
	}

	protected override string _GetTemplateForLabelUsernameWithColumn()
	{
		return "Имя пользователя:";
	}

	protected override string _GetTemplateForLabelVerificationEmailSent()
	{
		return "Письмо для подтверждения отправлено!";
	}

	protected override string _GetTemplateForLabelWeChatAntiAddictionText()
	{
		return "Избегайте плохих и пиратских игр. Будьте осторожны, и вас не обманут. Игры помогают развивать мозг, однако не надо ими злоупотреблять – это может нанести вред здоровью. Разумно распределяйте свое время и наслаждайтесь правильным образом жизни!";
	}

	protected override string _GetTemplateForMessageUnknownErrorTryAgain()
	{
		return "Произошла неизвестная ошибка. Повторите попытку.";
	}

	protected override string _GetTemplateForMessageUsernameAndPasswordRequired()
	{
		return "Необходимо указать имя пользователя и пароль";
	}

	protected override string _GetTemplateForResponseAccountIssueErrorContactSupport()
	{
		return "Ошибка учетной записи. Обратитесь в службу поддержки.";
	}

	protected override string _GetTemplateForResponseAccountLockedRequestReset()
	{
		return "Учетная запись заблокирована. Запросите сброс пароля.";
	}

	protected override string _GetTemplateForResponseAccountNotFound()
	{
		return "Учетная запись не найдена. Повторите попытку.";
	}

	protected override string _GetTemplateForResponseEmailLinkedToMultipleAccountsLoginWithUsername()
	{
		return "Эта эл. почта привязана к нескольким пользователям. Пожалуйста, введите свое имя пользователя.";
	}

	protected override string _GetTemplateForResponseEmailSent()
	{
		return "Сообщение отправлено!";
	}

	protected override string _GetTemplateForResponseIncorrectEmailOrPassword()
	{
		return "Некорректные эл. почта или пароль.";
	}

	protected override string _GetTemplateForResponseIncorrectPhoneOrPassword()
	{
		return "Некорректные номер телефона или пароль.";
	}

	protected override string _GetTemplateForResponseIncorrectUsernamePassword()
	{
		return "Неправильные имя пользователя или пароль.";
	}

	protected override string _GetTemplateForResponseLoginWithUsername()
	{
		return "Возникли проблемы. Пожалуйста, введите свое имя пользователя.";
	}

	protected override string _GetTemplateForResponsePasswordNotProvided()
	{
		return "Необходимо ввести пароль.";
	}

	protected override string _GetTemplateForResponseTooManyAttemptsPleaseWait()
	{
		return "Слишком много попыток. Подождите.";
	}

	protected override string _GetTemplateForResponseUnknownError()
	{
		return "Неизвестная ошибка";
	}

	protected override string _GetTemplateForResponseUnknownLoginError()
	{
		return "Неизвестная ошибка входа";
	}

	protected override string _GetTemplateForResponseUnverifiedEmailLoginWithUsername()
	{
		return "Эта эл. почта не подтверждена. Пожалуйста, введите свое имя пользователя.";
	}

	protected override string _GetTemplateForResponseUnverifiedPhoneLoginWithUsername()
	{
		return "Этот номер телефона не подтвержден. Пожалуйста, введите свое имя пользователя.";
	}

	protected override string _GetTemplateForResponseUsernameNotProvided()
	{
		return "Необходимо ввести имя пользователя.";
	}

	protected override string _GetTemplateForResponseUseSocialSignOn()
	{
		return "Не удалось войти в учетную запись. Войдите через социальную сеть.";
	}

	/// <summary>
	/// Key: "Response.WeChatNotRealNameVerified"
	/// English String: "Your WeChat is not real-name verified. Please use a real-name verified WeChat account and try again. Please visit {url}"
	/// </summary>
	public override string ResponseWeChatNotRealNameVerified(string url)
	{
		return $"Ваше настоящее имя в WeChat не подтверждено. Пожалуйста, используйте свою реальную, подтвержденную в WeChat учетную запись, и попробуйте еще раз. Пожалуйста, перейдите на {url}";
	}

	protected override string _GetTemplateForResponseWeChatNotRealNameVerified()
	{
		return "Ваше настоящее имя в WeChat не подтверждено. Пожалуйста, используйте свою реальную, подтвержденную в WeChat учетную запись, и попробуйте еще раз. Пожалуйста, перейдите на {url}";
	}

	protected override string _GetTemplateForWeChatAntiAddictionText()
	{
		return "Избегайте плохих и пиратских игр. Будьте осторожны, и вас не обманут. Игры помогают развивать мозг, однако не надо с этим злоупотреблять – это может нанести вред здоровью. Разумно распределяйте свое время и наслаждайтесь правильным образом жизни!";
	}

	protected override string _GetTemplateForWeChatRealNameNotVerified()
	{
		return "Ваше настоящее имя в WeChat не подтверждено. Пожалуйста, используйте свою реальную, подтвержденную в WeChat учетную запись, и попробуйте еще раз. Пожалуйста, перейдите на https://jiazhang.qq.com/zk/home.html";
	}
}
