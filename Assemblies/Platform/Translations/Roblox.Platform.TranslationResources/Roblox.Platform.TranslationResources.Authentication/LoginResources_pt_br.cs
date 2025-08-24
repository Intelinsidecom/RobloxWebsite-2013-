namespace Roblox.TranslationResources.Authentication;

/// <summary>
/// This class overrides LoginResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class LoginResources_pt_br : LoginResources_en_us, ILoginResources, ITranslationResources
{
	/// <summary>
	/// Key: "Action.Cancel"
	/// Cancel button text
	/// English String: "Cancel"
	/// </summary>
	public override string ActionCancel => "Cancelar";

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
	public override string ActionForgotPasswordOrUsernameQuestion => "Esqueceu a senha ou nome de usuário?";

	/// <summary>
	/// Key: "Action.ForgotPasswordOrUsernameQuestionCapitalized"
	/// link under login form
	/// English String: "Forgot Password or Username?"
	/// </summary>
	public override string ActionForgotPasswordOrUsernameQuestionCapitalized => "Esqueceu a senha ou nome de usuário?";

	/// <summary>
	/// Key: "Action.Login"
	/// English String: "Login"
	/// </summary>
	public override string ActionLogin => "Conectar-se";

	/// <summary>
	/// Key: "Action.LogInCapitalized"
	/// login button label. please note this is different from 'Login' or 'Log in'.
	/// English String: "Log In"
	/// </summary>
	public override string ActionLogInCapitalized => "Conectar-se";

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
	public override string ActionPlayAsGuest => "Jogar como visitante";

	/// <summary>
	/// Key: "Action.Resend"
	/// button text for resending verification email
	/// English String: "Resend"
	/// </summary>
	public override string ActionResend => "Reenviar";

	/// <summary>
	/// Key: "Action.ResendEmail"
	/// link that resends verification email to user
	/// English String: "Resend Email"
	/// </summary>
	public override string ActionResendEmail => "Reenviar e-mail";

	/// <summary>
	/// Key: "Action.SendVerificationEmail"
	/// button user can click to send a verification link to their email
	/// English String: "Send Verification Email"
	/// </summary>
	public override string ActionSendVerificationEmail => "Enviar e-mail de verificação";

	/// <summary>
	/// Key: "Action.SignIn"
	/// Sign In button text
	/// English String: "Sign In"
	/// </summary>
	public override string ActionSignIn => "Conectar-se";

	/// <summary>
	/// Key: "Action.SignInWithFacebook"
	/// Sign In with Facebook
	/// English String: "Sign In with Facebook"
	/// </summary>
	public override string ActionSignInWithFacebook => "Conectar-se com o Facebook";

	/// <summary>
	/// Key: "Action.SignUp"
	/// English String: "Sign up"
	/// </summary>
	public override string ActionSignUp => "Cadastrar-se";

	/// <summary>
	/// Key: "Action.SignUpCapitalized"
	/// link which takes user to sign up page
	/// English String: "Sign Up"
	/// </summary>
	public override string ActionSignUpCapitalized => "Cadastrar-se";

	/// <summary>
	/// Key: "Action.WeChatLogin"
	/// button text for logging in with WeChat
	/// English String: "WeChat Login"
	/// </summary>
	public override string ActionWeChatLogin => "Login do WeChat";

	/// <summary>
	/// Key: "Heading.Login"
	/// heading on the login page
	/// English String: "Login"
	/// </summary>
	public override string HeadingLogin => "Conectar-se";

	/// <summary>
	/// Key: "Heading.LoginRoblox"
	/// current login page heading
	/// English String: "Login to Roblox"
	/// </summary>
	public override string HeadingLoginRoblox => "Conecte-se ao Roblox";

	public override string HeadingSignUpMakeFriends => "Cadastre-se para construir e fazer amigos";

	/// <summary>
	/// Key: "Label.AccountNotNeeded"
	/// You don't need an account to play Roblox
	/// English String: "You don't need an account to play Roblox"
	/// </summary>
	public override string LabelAccountNotNeeded => "Você não precisa de uma conta para jogar Roblox";

	/// <summary>
	/// Key: "Label.EmailNeedsVerification"
	/// modal header used for prompting user they need to verify their email in order to log in with it
	/// English String: "Your email needs verification"
	/// </summary>
	public override string LabelEmailNeedsVerification => "Seu e-mail precisa ser verificado";

	/// <summary>
	/// Key: "Label.FacebookCreatePasswordWarning"
	/// If you have been signing in with Facebook, you must set a password.
	/// English String: "If you have been signing in with Facebook, you must set a password."
	/// </summary>
	public override string LabelFacebookCreatePasswordWarning => "Se você tem se conectado com o Facebook, você precisa definir uma senha.";

	/// <summary>
	/// Key: "Label.ForgotUsernamePassword"
	/// landing page top right link for password reset
	/// English String: "Forgot Username/Password?"
	/// </summary>
	public override string LabelForgotUsernamePassword => "Esqueceu o nome de usuário/senha?";

	/// <summary>
	/// Key: "Label.LearnMore"
	/// learn more link text
	/// English String: "Learn more"
	/// </summary>
	public override string LabelLearnMore => "Saiba mais";

	/// <summary>
	/// Key: "Label.LoggingInSpinnerText"
	/// English String: "Logging in…"
	/// </summary>
	public override string LabelLoggingInSpinnerText => "Conectando...";

	/// <summary>
	/// Key: "Label.Login"
	/// English String: "Log in"
	/// </summary>
	public override string LabelLogin => "Conectar-se";

	/// <summary>
	/// Key: "Label.LoginWithYour"
	/// Label for a partition line between login with email and facebook login. Please keep the text in lowercase for roman characters.
	/// English String: "login with your"
	/// </summary>
	public override string LabelLoginWithYour => "conectar-se com seu";

	/// <summary>
	/// Key: "Label.NoAccount"
	/// Don't have an account?
	/// English String: "Don't have an account?"
	/// </summary>
	public override string LabelNoAccount => "Não possui uma conta?";

	/// <summary>
	/// Key: "Label.NonAMemberQuestion"
	/// The question heading for the section on the login page to take use to sign up page.
	/// English String: "Not a member?"
	/// </summary>
	public override string LabelNonAMemberQuestion => "Não é um membro?";

	/// <summary>
	/// Key: "Label.NotReceived"
	/// prompt for allowing users to resend verification email
	/// English String: "Didn't receive it?"
	/// </summary>
	public override string LabelNotReceived => "Não recebeu?";

	/// <summary>
	/// Key: "Label.Or"
	/// partition between email login and facebook login
	/// English String: "Or"
	/// </summary>
	public override string LabelOr => "Ou";

	/// <summary>
	/// Key: "Label.Password"
	/// Password
	/// English String: "Password"
	/// </summary>
	public override string LabelPassword => "Senha";

	/// <summary>
	/// Key: "Label.PasswordWithColumn"
	/// label for the password field on the login page
	/// English String: "Password:"
	/// </summary>
	public override string LabelPasswordWithColumn => "Senha:";

	/// <summary>
	/// Key: "Label.StartPlaying"
	/// You can start playing right now, in guest mode!
	/// English String: "You can start playing right now, in guest mode!"
	/// </summary>
	public override string LabelStartPlaying => "Você pode começar a jogar agora mesmo no modo visitante!";

	/// <summary>
	/// Key: "Label.UnverifiedEmailInstructions"
	/// message shown in a modal when user logs in with unverified email
	/// English String: "To log in with your email, it must be verified. You can also log in with your username."
	/// </summary>
	public override string LabelUnverifiedEmailInstructions => "Para se conectar com seu e-mail, ele precisa ser verificado. Você também pode se conectar com seu nome de usuário.";

	/// <summary>
	/// Key: "Label.Username"
	/// English String: "Username"
	/// </summary>
	public override string LabelUsername => "Nome de usuário";

	/// <summary>
	/// Key: "Label.UsernameEmail"
	/// placeholder text for input field that accepts username or email
	/// English String: "Username/Email"
	/// </summary>
	public override string LabelUsernameEmail => "Nome de usuário/E-mail";

	/// <summary>
	/// Key: "Label.UsernameEmailPhone"
	/// placeholder text for input fields that accept username, email or phone
	/// English String: "Username/Email/Phone"
	/// </summary>
	public override string LabelUsernameEmailPhone => "Usuário/e-mail/telefone";

	/// <summary>
	/// Key: "Label.UsernamePhone"
	/// placeholder text for input field that accepts username or phone
	/// English String: "Username/Phone"
	/// </summary>
	public override string LabelUsernamePhone => "Nome de usuário/Telefone";

	/// <summary>
	/// Key: "Label.UsernameWithColumn"
	/// label for username field on login page
	/// English String: "Username:"
	/// </summary>
	public override string LabelUsernameWithColumn => "Nome de usuário:";

	/// <summary>
	/// Key: "Label.VerificationEmailSent"
	/// message telling user a verification email was sent to them
	/// English String: "Verification Email Sent!"
	/// </summary>
	public override string LabelVerificationEmailSent => "E-mail de verificação enviado!";

	/// <summary>
	/// Key: "Label.WeChatAntiAddictionText"
	/// English String: "Boycott bad games, refuse pirated games. Be aware of self-defense and being deceived. Playing games is good for your brain, but too much game play can harm your health. Manage your time well and enjoy a healthy lifestyle."
	/// </summary>
	public override string LabelWeChatAntiAddictionText => "Boicote jogos ruins, recuse jogos pirateados. Saiba se defender e lidar com fraudes. Jogar jogos é bom para o cérebro, mas jogar demais pode prejudicar a saúde. Administre bem o seu tempo e desfrute de um estilo de vida saudável.";

	/// <summary>
	/// Key: "Message.UnknownErrorTryAgain"
	/// An unknown error occurred. Please try again.
	/// English String: "An unknown error occurred. Please try again."
	/// </summary>
	public override string MessageUnknownErrorTryAgain => "Um erro desconhecido ocorreu. Tente novamente.";

	/// <summary>
	/// Key: "Message.UsernameAndPasswordRequired"
	/// message shown to user when they attempt to login without entering a username or password
	/// English String: "Username and password required"
	/// </summary>
	public override string MessageUsernameAndPasswordRequired => "Requer nome de usuário e senha";

	/// <summary>
	/// Key: "Response.AccountIssueErrorContactSupport"
	/// English String: "Account issue. Please contact Support."
	/// </summary>
	public override string ResponseAccountIssueErrorContactSupport => "Problema na conta. Contate o suporte.";

	/// <summary>
	/// Key: "Response.AccountLockedRequestReset"
	/// Account has been locked. Please request a password reset.
	/// English String: "Account has been locked. Please request a password reset."
	/// </summary>
	public override string ResponseAccountLockedRequestReset => "Conta bloqueada. Solicite uma redefinição de senha.";

	/// <summary>
	/// Key: "Response.AccountNotFound"
	/// Account not found. Please try again.
	/// English String: "Account not found. Please try again."
	/// </summary>
	public override string ResponseAccountNotFound => "Conta não encontrada. Tente novamente.";

	/// <summary>
	/// Key: "Response.EmailLinkedToMultipleAccountsLoginWithUsername"
	/// error message displayed when user attempts to log in with an email that is linked to multiple accounts
	/// English String: "Your email is associated with more than 1 username. Please login with your username."
	/// </summary>
	public override string ResponseEmailLinkedToMultipleAccountsLoginWithUsername => "Seu e-mail está associado a mais de um nome de usuário. Conecte-se com seu nome de usuário.";

	/// <summary>
	/// Key: "Response.EmailSent"
	/// response telling user that a verification email has been sent to them
	/// English String: "Email sent!"
	/// </summary>
	public override string ResponseEmailSent => "E-mail enviado!";

	/// <summary>
	/// Key: "Response.IncorrectEmailOrPassword"
	/// error message displayed when user logs in with an invalid email or password
	/// English String: "Incorrect email or password."
	/// </summary>
	public override string ResponseIncorrectEmailOrPassword => "E-mail ou senha incorretos.";

	/// <summary>
	/// Key: "Response.IncorrectPhoneOrPassword"
	/// error message displayed when user logs in with an invalid phone or password
	/// English String: "Incorrect phone or password."
	/// </summary>
	public override string ResponseIncorrectPhoneOrPassword => "Telefone ou senha incorretos.";

	/// <summary>
	/// Key: "Response.IncorrectUsernamePassword"
	/// English String: "Incorrect username or password."
	/// </summary>
	public override string ResponseIncorrectUsernamePassword => "Nome de usuário ou senha incorretos.";

	/// <summary>
	/// Key: "Response.LoginWithUsername"
	/// error message shown when user attempts to login with method other than username and an error occurred
	/// English String: "Something went wrong. Please login with your username."
	/// </summary>
	public override string ResponseLoginWithUsername => "Algo deu errado. Conecte-se com seu nome de usuário.";

	/// <summary>
	/// Key: "Response.PasswordNotProvided"
	/// password field is empty
	/// English String: "You must enter a password."
	/// </summary>
	public override string ResponsePasswordNotProvided => "Você precisa inserir uma senha.";

	/// <summary>
	/// Key: "Response.TooManyAttemptsPleaseWait"
	/// English String: "Too many attempts. Please wait a bit."
	/// </summary>
	public override string ResponseTooManyAttemptsPleaseWait => "Tentativas excessivas. Tente de novo daqui a pouco.";

	/// <summary>
	/// Key: "Response.UnknownError"
	/// English String: "Unknown Error"
	/// </summary>
	public override string ResponseUnknownError => "Erro desconhecido";

	/// <summary>
	/// Key: "Response.UnknownLoginError"
	/// Unknown login failure.
	/// English String: "Unknown login failure."
	/// </summary>
	public override string ResponseUnknownLoginError => "Falha de login desconhecida.";

	/// <summary>
	/// Key: "Response.UnverifiedEmailLoginWithUsername"
	/// error message shown when user attempts to login with unverified email
	/// English String: "Your email is not verified. Please login with your username."
	/// </summary>
	public override string ResponseUnverifiedEmailLoginWithUsername => "Seu e-mail não foi verificado. Conecte-se com seu nome de usuário.";

	/// <summary>
	/// Key: "Response.UnverifiedPhoneLoginWithUsername"
	/// error message shown when user attempts to login with an unverified phone number
	/// English String: "Your phone is not verified. Please login with your username."
	/// </summary>
	public override string ResponseUnverifiedPhoneLoginWithUsername => "Seu telefone não foi verificado. Conecte-se com seu nome de usuário.";

	/// <summary>
	/// Key: "Response.UsernameNotProvided"
	/// username field is empty
	/// English String: "You must enter a username."
	/// </summary>
	public override string ResponseUsernameNotProvided => "Você precisa inserir um nome de usuário.";

	/// <summary>
	/// Key: "Response.UseSocialSignOn"
	/// Unable to login. Please use Social Network sign on.
	/// English String: "Unable to login. Please use Social Network sign on."
	/// </summary>
	public override string ResponseUseSocialSignOn => "Impossível se conectar. Use a conexão por rede social.";

	/// <summary>
	/// Key: "WeChat.AntiAddictionText"
	/// English String: "Boycott bad games, refuse pirated games. Be aware of self-defense and being deceived. Playing games is good for your brain, but too much game play can harm your health. Manage your time well and enjoy a healthy lifestyle."
	/// </summary>
	public override string WeChatAntiAddictionText => "Boicote jogos ruins, recuse jogos pirateados. Saiba se defender e lidar com fraudes. Jogar jogos é bom para o cérebro, mas jogar demais pode prejudicar sua saúde. Administre bem o seu tempo e desfrute de um estilo de vida saudável.";

	/// <summary>
	/// Key: "WeChat.RealNameNotVerified"
	/// English String: "Your WeChat is not real-name verified. Please use a real-name verified WeChat account and try again. Please visit https://jiazhang.qq.com/zk/home.html"
	/// </summary>
	public override string WeChatRealNameNotVerified => "Seu WeChat não tem um nome real verificado. Use uma conta WeChat com nome real verificado e tente novamente. Visite https://jiazhang.qq.com/zk/home.html";

	public LoginResources_pt_br(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionCancel()
	{
		return "Cancelar";
	}

	protected override string _GetTemplateForActionFacebook()
	{
		return "Facebook";
	}

	protected override string _GetTemplateForActionForgotPasswordOrUsernameQuestion()
	{
		return "Esqueceu a senha ou nome de usuário?";
	}

	protected override string _GetTemplateForActionForgotPasswordOrUsernameQuestionCapitalized()
	{
		return "Esqueceu a senha ou nome de usuário?";
	}

	protected override string _GetTemplateForActionLogin()
	{
		return "Conectar-se";
	}

	protected override string _GetTemplateForActionLogInCapitalized()
	{
		return "Conectar-se";
	}

	protected override string _GetTemplateForActionOk()
	{
		return "OK";
	}

	protected override string _GetTemplateForActionPlayAsGuest()
	{
		return "Jogar como visitante";
	}

	protected override string _GetTemplateForActionResend()
	{
		return "Reenviar";
	}

	protected override string _GetTemplateForActionResendEmail()
	{
		return "Reenviar e-mail";
	}

	protected override string _GetTemplateForActionSendVerificationEmail()
	{
		return "Enviar e-mail de verificação";
	}

	protected override string _GetTemplateForActionSignIn()
	{
		return "Conectar-se";
	}

	protected override string _GetTemplateForActionSignInWithFacebook()
	{
		return "Conectar-se com o Facebook";
	}

	protected override string _GetTemplateForActionSignUp()
	{
		return "Cadastrar-se";
	}

	protected override string _GetTemplateForActionSignUpCapitalized()
	{
		return "Cadastrar-se";
	}

	protected override string _GetTemplateForActionWeChatLogin()
	{
		return "Login do WeChat";
	}

	protected override string _GetTemplateForHeadingLogin()
	{
		return "Conectar-se";
	}

	protected override string _GetTemplateForHeadingLoginRoblox()
	{
		return "Conecte-se ao Roblox";
	}

	protected override string _GetTemplateForHeadingSignUpMakeFriends()
	{
		return "Cadastre-se para construir e fazer amigos";
	}

	protected override string _GetTemplateForLabelAccountNotNeeded()
	{
		return "Você não precisa de uma conta para jogar Roblox";
	}

	protected override string _GetTemplateForLabelEmailNeedsVerification()
	{
		return "Seu e-mail precisa ser verificado";
	}

	protected override string _GetTemplateForLabelFacebookCreatePasswordWarning()
	{
		return "Se você tem se conectado com o Facebook, você precisa definir uma senha.";
	}

	protected override string _GetTemplateForLabelForgotUsernamePassword()
	{
		return "Esqueceu o nome de usuário/senha?";
	}

	/// <summary>
	/// Key: "Label.GreetingForNewAccount"
	/// Shown when a username doesn't exist on the login page to invite to create a new account.
	/// English String: "Nice to meet you, {username}. {linkStartSignup}Let's make an account! {linkEndSignup}"
	/// </summary>
	public override string LabelGreetingForNewAccount(string username, string linkStartSignup, string linkEndSignup)
	{
		return $"Prazer em conhecer, {username}. {linkStartSignup}Vamos criar uma conta! {linkEndSignup}";
	}

	protected override string _GetTemplateForLabelGreetingForNewAccount()
	{
		return "Prazer em conhecer, {username}. {linkStartSignup}Vamos criar uma conta! {linkEndSignup}";
	}

	protected override string _GetTemplateForLabelLearnMore()
	{
		return "Saiba mais";
	}

	protected override string _GetTemplateForLabelLoggingInSpinnerText()
	{
		return "Conectando...";
	}

	protected override string _GetTemplateForLabelLogin()
	{
		return "Conectar-se";
	}

	protected override string _GetTemplateForLabelLoginWithYour()
	{
		return "conectar-se com seu";
	}

	protected override string _GetTemplateForLabelNoAccount()
	{
		return "Não possui uma conta?";
	}

	protected override string _GetTemplateForLabelNonAMemberQuestion()
	{
		return "Não é um membro?";
	}

	protected override string _GetTemplateForLabelNotReceived()
	{
		return "Não recebeu?";
	}

	protected override string _GetTemplateForLabelOr()
	{
		return "Ou";
	}

	protected override string _GetTemplateForLabelPassword()
	{
		return "Senha";
	}

	protected override string _GetTemplateForLabelPasswordWithColumn()
	{
		return "Senha:";
	}

	protected override string _GetTemplateForLabelStartPlaying()
	{
		return "Você pode começar a jogar agora mesmo no modo visitante!";
	}

	protected override string _GetTemplateForLabelUnverifiedEmailInstructions()
	{
		return "Para se conectar com seu e-mail, ele precisa ser verificado. Você também pode se conectar com seu nome de usuário.";
	}

	protected override string _GetTemplateForLabelUsername()
	{
		return "Nome de usuário";
	}

	protected override string _GetTemplateForLabelUsernameEmail()
	{
		return "Nome de usuário/E-mail";
	}

	protected override string _GetTemplateForLabelUsernameEmailPhone()
	{
		return "Usuário/e-mail/telefone";
	}

	protected override string _GetTemplateForLabelUsernamePhone()
	{
		return "Nome de usuário/Telefone";
	}

	protected override string _GetTemplateForLabelUsernameWithColumn()
	{
		return "Nome de usuário:";
	}

	protected override string _GetTemplateForLabelVerificationEmailSent()
	{
		return "E-mail de verificação enviado!";
	}

	protected override string _GetTemplateForLabelWeChatAntiAddictionText()
	{
		return "Boicote jogos ruins, recuse jogos pirateados. Saiba se defender e lidar com fraudes. Jogar jogos é bom para o cérebro, mas jogar demais pode prejudicar a saúde. Administre bem o seu tempo e desfrute de um estilo de vida saudável.";
	}

	protected override string _GetTemplateForMessageUnknownErrorTryAgain()
	{
		return "Um erro desconhecido ocorreu. Tente novamente.";
	}

	protected override string _GetTemplateForMessageUsernameAndPasswordRequired()
	{
		return "Requer nome de usuário e senha";
	}

	protected override string _GetTemplateForResponseAccountIssueErrorContactSupport()
	{
		return "Problema na conta. Contate o suporte.";
	}

	protected override string _GetTemplateForResponseAccountLockedRequestReset()
	{
		return "Conta bloqueada. Solicite uma redefinição de senha.";
	}

	protected override string _GetTemplateForResponseAccountNotFound()
	{
		return "Conta não encontrada. Tente novamente.";
	}

	protected override string _GetTemplateForResponseEmailLinkedToMultipleAccountsLoginWithUsername()
	{
		return "Seu e-mail está associado a mais de um nome de usuário. Conecte-se com seu nome de usuário.";
	}

	protected override string _GetTemplateForResponseEmailSent()
	{
		return "E-mail enviado!";
	}

	protected override string _GetTemplateForResponseIncorrectEmailOrPassword()
	{
		return "E-mail ou senha incorretos.";
	}

	protected override string _GetTemplateForResponseIncorrectPhoneOrPassword()
	{
		return "Telefone ou senha incorretos.";
	}

	protected override string _GetTemplateForResponseIncorrectUsernamePassword()
	{
		return "Nome de usuário ou senha incorretos.";
	}

	protected override string _GetTemplateForResponseLoginWithUsername()
	{
		return "Algo deu errado. Conecte-se com seu nome de usuário.";
	}

	protected override string _GetTemplateForResponsePasswordNotProvided()
	{
		return "Você precisa inserir uma senha.";
	}

	protected override string _GetTemplateForResponseTooManyAttemptsPleaseWait()
	{
		return "Tentativas excessivas. Tente de novo daqui a pouco.";
	}

	protected override string _GetTemplateForResponseUnknownError()
	{
		return "Erro desconhecido";
	}

	protected override string _GetTemplateForResponseUnknownLoginError()
	{
		return "Falha de login desconhecida.";
	}

	protected override string _GetTemplateForResponseUnverifiedEmailLoginWithUsername()
	{
		return "Seu e-mail não foi verificado. Conecte-se com seu nome de usuário.";
	}

	protected override string _GetTemplateForResponseUnverifiedPhoneLoginWithUsername()
	{
		return "Seu telefone não foi verificado. Conecte-se com seu nome de usuário.";
	}

	protected override string _GetTemplateForResponseUsernameNotProvided()
	{
		return "Você precisa inserir um nome de usuário.";
	}

	protected override string _GetTemplateForResponseUseSocialSignOn()
	{
		return "Impossível se conectar. Use a conexão por rede social.";
	}

	/// <summary>
	/// Key: "Response.WeChatNotRealNameVerified"
	/// English String: "Your WeChat is not real-name verified. Please use a real-name verified WeChat account and try again. Please visit {url}"
	/// </summary>
	public override string ResponseWeChatNotRealNameVerified(string url)
	{
		return $"Seu WeChat não tem um nome real verificado. Use uma conta WeChat com nome real verificado e tente novamente. Visite {url}";
	}

	protected override string _GetTemplateForResponseWeChatNotRealNameVerified()
	{
		return "Seu WeChat não tem um nome real verificado. Use uma conta WeChat com nome real verificado e tente novamente. Visite {url}";
	}

	protected override string _GetTemplateForWeChatAntiAddictionText()
	{
		return "Boicote jogos ruins, recuse jogos pirateados. Saiba se defender e lidar com fraudes. Jogar jogos é bom para o cérebro, mas jogar demais pode prejudicar sua saúde. Administre bem o seu tempo e desfrute de um estilo de vida saudável.";
	}

	protected override string _GetTemplateForWeChatRealNameNotVerified()
	{
		return "Seu WeChat não tem um nome real verificado. Use uma conta WeChat com nome real verificado e tente novamente. Visite https://jiazhang.qq.com/zk/home.html";
	}
}
