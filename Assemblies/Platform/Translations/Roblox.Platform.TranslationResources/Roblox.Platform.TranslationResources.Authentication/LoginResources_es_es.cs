namespace Roblox.Platform.TranslationResources.Authentication {
    /// <summary>

/// This class overrides LoginResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class LoginResources_es_es : LoginResources_en_us, ILoginResources, ITranslationResources
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
	public override string ActionForgotPasswordOrUsernameQuestion => "Â¿Has olvidado tu contraseÃ±a o nombre de usuario?";

	/// <summary>
	/// Key: "Action.ForgotPasswordOrUsernameQuestionCapitalized"
	/// link under login form
	/// English String: "Forgot Password or Username?"
	/// </summary>
	public override string ActionForgotPasswordOrUsernameQuestionCapitalized => "Â¿Has olvidado tu contraseÃ±a o nombre de usuario?";

	/// <summary>
	/// Key: "Action.Login"
	/// English String: "Login"
	/// </summary>
	public override string ActionLogin => "Iniciar sesiÃ³n";

	/// <summary>
	/// Key: "Action.LogInCapitalized"
	/// login button label. please note this is different from 'Login' or 'Log in'.
	/// English String: "Log In"
	/// </summary>
	public override string ActionLogInCapitalized => "Iniciar sesiÃ³n";

	/// <summary>
	/// Key: "Action.Ok"
	/// button text
	/// English String: "OK"
	/// </summary>
	public override string ActionOk => "Aceptar";

	/// <summary>
	/// Key: "Action.PlayAsGuest"
	/// Play as Guest
	/// English String: "Play as Guest"
	/// </summary>
	public override string ActionPlayAsGuest => "Jugar como invitado";

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
	public override string ActionResendEmail => "Reenviar correo electrÃ³nico";

	/// <summary>
	/// Key: "Action.SendVerificationEmail"
	/// button user can click to send a verification link to their email
	/// English String: "Send Verification Email"
	/// </summary>
	public override string ActionSendVerificationEmail => "Enviar correo de verificaciÃ³n";

	/// <summary>
	/// Key: "Action.SignIn"
	/// Sign In button text
	/// English String: "Sign In"
	/// </summary>
	public override string ActionSignIn => "Iniciar sesiÃ³n";

	/// <summary>
	/// Key: "Action.SignInWithFacebook"
	/// Sign In with Facebook
	/// English String: "Sign In with Facebook"
	/// </summary>
	public override string ActionSignInWithFacebook => "Iniciar sesiÃ³n con Facebook";

	/// <summary>
	/// Key: "Action.SignUp"
	/// English String: "Sign up"
	/// </summary>
	public override string ActionSignUp => "RegÃ­strate";

	/// <summary>
	/// Key: "Action.SignUpCapitalized"
	/// link which takes user to sign up page
	/// English String: "Sign Up"
	/// </summary>
	public override string ActionSignUpCapitalized => "RegÃ­strate";

	/// <summary>
	/// Key: "Action.WeChatLogin"
	/// button text for logging in with WeChat
	/// English String: "WeChat Login"
	/// </summary>
	public override string ActionWeChatLogin => "Inicio de sesiÃ³n de WeChat";

	/// <summary>
	/// Key: "Heading.Login"
	/// heading on the login page
	/// English String: "Login"
	/// </summary>
	public override string HeadingLogin => "Iniciar sesiÃ³n";

	/// <summary>
	/// Key: "Heading.LoginRoblox"
	/// current login page heading
	/// English String: "Login to Roblox"
	/// </summary>
	public override string HeadingLoginRoblox => "Iniciar sesiÃ³n en Roblox";

	public override string HeadingSignUpMakeFriends => "RegÃ­strate para crear y hacer amigos.";

	/// <summary>
	/// Key: "Label.AccountNotNeeded"
	/// You don't need an account to play Roblox
	/// English String: "You don't need an account to play Roblox"
	/// </summary>
	public override string LabelAccountNotNeeded => "No necesitas una cuenta para jugar a Roblox.";

	/// <summary>
	/// Key: "Label.EmailNeedsVerification"
	/// modal header used for prompting user they need to verify their email in order to log in with it
	/// English String: "Your email needs verification"
	/// </summary>
	public override string LabelEmailNeedsVerification => "Tu correo electrÃ³nico necesita verificaciÃ³n";

	/// <summary>
	/// Key: "Label.FacebookCreatePasswordWarning"
	/// If you have been signing in with Facebook, you must set a password.
	/// English String: "If you have been signing in with Facebook, you must set a password."
	/// </summary>
	public override string LabelFacebookCreatePasswordWarning => "Si has estado iniciando sesiÃ³n con Facebook, debes establecer una contraseÃ±a.";

	/// <summary>
	/// Key: "Label.ForgotUsernamePassword"
	/// landing page top right link for password reset
	/// English String: "Forgot Username/Password?"
	/// </summary>
	public override string LabelForgotUsernamePassword => "Â¿Has olvidado el nombre de usuario o contraseÃ±a?";

	/// <summary>
	/// Key: "Label.LearnMore"
	/// learn more link text
	/// English String: "Learn more"
	/// </summary>
	public override string LabelLearnMore => "MÃ¡s informaciÃ³n";

	/// <summary>
	/// Key: "Label.LoggingInSpinnerText"
	/// English String: "Logging inâ€¦"
	/// </summary>
	public override string LabelLoggingInSpinnerText => "Iniciando sesiÃ³n...";

	/// <summary>
	/// Key: "Label.Login"
	/// English String: "Log in"
	/// </summary>
	public override string LabelLogin => "Iniciar sesiÃ³n";

	/// <summary>
	/// Key: "Label.LoginWithYour"
	/// Label for a partition line between login with email and facebook login. Please keep the text in lowercase for roman characters.
	/// English String: "login with your"
	/// </summary>
	public override string LabelLoginWithYour => "Inicia sesiÃ³n con";

	/// <summary>
	/// Key: "Label.NoAccount"
	/// Don't have an account?
	/// English String: "Don't have an account?"
	/// </summary>
	public override string LabelNoAccount => "Â¿No tienes una cuenta de Roblox?";

	/// <summary>
	/// Key: "Label.NonAMemberQuestion"
	/// The question heading for the section on the login page to take use to sign up page.
	/// English String: "Not a member?"
	/// </summary>
	public override string LabelNonAMemberQuestion => "Â¿No eres miembro?";

	/// <summary>
	/// Key: "Label.NotReceived"
	/// prompt for allowing users to resend verification email
	/// English String: "Didn't receive it?"
	/// </summary>
	public override string LabelNotReceived => "Â¿No lo has recibido?";

	/// <summary>
	/// Key: "Label.Or"
	/// partition between email login and facebook login
	/// English String: "Or"
	/// </summary>
	public override string LabelOr => "O";

	/// <summary>
	/// Key: "Label.Password"
	/// Password
	/// English String: "Password"
	/// </summary>
	public override string LabelPassword => "ContraseÃ±a";

	/// <summary>
	/// Key: "Label.PasswordWithColumn"
	/// label for the password field on the login page
	/// English String: "Password:"
	/// </summary>
	public override string LabelPasswordWithColumn => "ContraseÃ±a:";

	/// <summary>
	/// Key: "Label.StartPlaying"
	/// You can start playing right now, in guest mode!
	/// English String: "You can start playing right now, in guest mode!"
	/// </summary>
	public override string LabelStartPlaying => "Â¡Puedes jugar directamente en modo invitado!";

	/// <summary>
	/// Key: "Label.UnverifiedEmailInstructions"
	/// message shown in a modal when user logs in with unverified email
	/// English String: "To log in with your email, it must be verified. You can also log in with your username."
	/// </summary>
	public override string LabelUnverifiedEmailInstructions => "Para iniciar sesiÃ³n con tu correo electrÃ³nico, primero debes verificarlo. TambiÃ©n puedes iniciar sesiÃ³n con tu nombre de usuario.";

	/// <summary>
	/// Key: "Label.Username"
	/// English String: "Username"
	/// </summary>
	public override string LabelUsername => "Nombre de usuario";

	/// <summary>
	/// Key: "Label.UsernameEmail"
	/// placeholder text for input field that accepts username or email
	/// English String: "Username/Email"
	/// </summary>
	public override string LabelUsernameEmail => "Nombre de usuario o correo";

	/// <summary>
	/// Key: "Label.UsernameEmailPhone"
	/// placeholder text for input fields that accept username, email or phone
	/// English String: "Username/Email/Phone"
	/// </summary>
	public override string LabelUsernameEmailPhone => "Usuario/correo/telÃ©fono";

	/// <summary>
	/// Key: "Label.UsernamePhone"
	/// placeholder text for input field that accepts username or phone
	/// English String: "Username/Phone"
	/// </summary>
	public override string LabelUsernamePhone => "Nombre de usuario o nÃºmero de telÃ©fono";

	/// <summary>
	/// Key: "Label.UsernameWithColumn"
	/// label for username field on login page
	/// English String: "Username:"
	/// </summary>
	public override string LabelUsernameWithColumn => "Nombre de usuario:";

	/// <summary>
	/// Key: "Label.VerificationEmailSent"
	/// message telling user a verification email was sent to them
	/// English String: "Verification Email Sent!"
	/// </summary>
	public override string LabelVerificationEmailSent => "Â¡Correo electrÃ³nico de verificaciÃ³n enviado!";

	/// <summary>
	/// Key: "Label.WeChatAntiAddictionText"
	/// English String: "Boycott bad games, refuse pirated games. Be aware of self-defense and being deceived. Playing games is good for your brain, but too much game play can harm your health. Manage your time well and enjoy a healthy lifestyle."
	/// </summary>
	public override string LabelWeChatAntiAddictionText => "Boicotea juegos con contenido inapropiado y di no a la piraterÃ­a. No permitas que te engaÃ±en. Jugar a videojuegos es bueno, pero jugar demasiado puede perjudicar tu salud. Gestiona bien tu tiempo para vivir una vida balanceada y saludable.";

	/// <summary>
	/// Key: "Message.UnknownErrorTryAgain"
	/// An unknown error occurred. Please try again.
	/// English String: "An unknown error occurred. Please try again."
	/// </summary>
	public override string MessageUnknownErrorTryAgain => "Se ha producido un error desconocido. IntÃ©ntalo de nuevo mÃ¡s tarde.";

	/// <summary>
	/// Key: "Message.UsernameAndPasswordRequired"
	/// message shown to user when they attempt to login without entering a username or password
	/// English String: "Username and password required"
	/// </summary>
	public override string MessageUsernameAndPasswordRequired => "Es necesario especificar el nombre de usuario y la contraseÃ±a.";

	/// <summary>
	/// Key: "Response.AccountIssueErrorContactSupport"
	/// English String: "Account issue. Please contact Support."
	/// </summary>
	public override string ResponseAccountIssueErrorContactSupport => "Problema con la cuenta. Ponte en contacto con asistencia tÃ©cnica.";

	/// <summary>
	/// Key: "Response.AccountLockedRequestReset"
	/// Account has been locked. Please request a password reset.
	/// English String: "Account has been locked. Please request a password reset."
	/// </summary>
	public override string ResponseAccountLockedRequestReset => "Se ha bloqueado la cuenta. Solicita un restablecimiento de contraseÃ±a.";

	/// <summary>
	/// Key: "Response.AccountNotFound"
	/// Account not found. Please try again.
	/// English String: "Account not found. Please try again."
	/// </summary>
	public override string ResponseAccountNotFound => "No se ha encontrado la cuenta. IntÃ©ntalo de nuevo mÃ¡s tarde.";

	/// <summary>
	/// Key: "Response.EmailLinkedToMultipleAccountsLoginWithUsername"
	/// error message displayed when user attempts to log in with an email that is linked to multiple accounts
	/// English String: "Your email is associated with more than 1 username. Please login with your username."
	/// </summary>
	public override string ResponseEmailLinkedToMultipleAccountsLoginWithUsername => "Tu correo electrÃ³nico estÃ¡ asociado a mÃ¡s de un nombre de usuario. Inicia sesiÃ³n con tu nombre de usuario.";

	/// <summary>
	/// Key: "Response.EmailSent"
	/// response telling user that a verification email has been sent to them
	/// English String: "Email sent!"
	/// </summary>
	public override string ResponseEmailSent => "Â¡Correo electrÃ³nico enviado!";

	/// <summary>
	/// Key: "Response.IncorrectEmailOrPassword"
	/// error message displayed when user logs in with an invalid email or password
	/// English String: "Incorrect email or password."
	/// </summary>
	public override string ResponseIncorrectEmailOrPassword => "Correo electrÃ³nico o contraseÃ±a incorrectos.";

	/// <summary>
	/// Key: "Response.IncorrectPhoneOrPassword"
	/// error message displayed when user logs in with an invalid phone or password
	/// English String: "Incorrect phone or password."
	/// </summary>
	public override string ResponseIncorrectPhoneOrPassword => "NÃºmero de telÃ©fono o contraseÃ±a incorrectos.";

	/// <summary>
	/// Key: "Response.IncorrectUsernamePassword"
	/// English String: "Incorrect username or password."
	/// </summary>
	public override string ResponseIncorrectUsernamePassword => "Nombre de usuario o contraseÃ±a incorrectos.";

	/// <summary>
	/// Key: "Response.LoginWithUsername"
	/// error message shown when user attempts to login with method other than username and an error occurred
	/// English String: "Something went wrong. Please login with your username."
	/// </summary>
	public override string ResponseLoginWithUsername => "Algo ha ido mal. Inicia sesiÃ³n con tu nombre de usuario.";

	/// <summary>
	/// Key: "Response.PasswordNotProvided"
	/// password field is empty
	/// English String: "You must enter a password."
	/// </summary>
	public override string ResponsePasswordNotProvided => "Debes introducir una contraseÃ±a.";

	/// <summary>
	/// Key: "Response.TooManyAttemptsPleaseWait"
	/// English String: "Too many attempts. Please wait a bit."
	/// </summary>
	public override string ResponseTooManyAttemptsPleaseWait => "Demasiados intentos. Espera un poco.";

	/// <summary>
	/// Key: "Response.UnknownError"
	/// English String: "Unknown Error"
	/// </summary>
	public override string ResponseUnknownError => "Error desconocido";

	/// <summary>
	/// Key: "Response.UnknownLoginError"
	/// Unknown login failure.
	/// English String: "Unknown login failure."
	/// </summary>
	public override string ResponseUnknownLoginError => "Fallo desconocido al iniciar sesiÃ³n.";

	/// <summary>
	/// Key: "Response.UnverifiedEmailLoginWithUsername"
	/// error message shown when user attempts to login with unverified email
	/// English String: "Your email is not verified. Please login with your username."
	/// </summary>
	public override string ResponseUnverifiedEmailLoginWithUsername => "Tu correo electrÃ³nico no ha sido verificado. Inicia sesiÃ³n con tu nombre de usuario.";

	/// <summary>
	/// Key: "Response.UnverifiedPhoneLoginWithUsername"
	/// error message shown when user attempts to login with an unverified phone number
	/// English String: "Your phone is not verified. Please login with your username."
	/// </summary>
	public override string ResponseUnverifiedPhoneLoginWithUsername => "Tu nÃºmero de telÃ©fono no ha sido verificado. Inicia sesiÃ³n con tu nombre de usuario.";

	/// <summary>
	/// Key: "Response.UsernameNotProvided"
	/// username field is empty
	/// English String: "You must enter a username."
	/// </summary>
	public override string ResponseUsernameNotProvided => "Debes introducir un nombre de usuario.";

	/// <summary>
	/// Key: "Response.UseSocialSignOn"
	/// Unable to login. Please use Social Network sign on.
	/// English String: "Unable to login. Please use Social Network sign on."
	/// </summary>
	public override string ResponseUseSocialSignOn => "Error al iniciar sesiÃ³n. Intenta hacerlo con una red social.";

	/// <summary>
	/// Key: "WeChat.AntiAddictionText"
	/// English String: "Boycott bad games, refuse pirated games. Be aware of self-defense and being deceived. Playing games is good for your brain, but too much game play can harm your health. Manage your time well and enjoy a healthy lifestyle."
	/// </summary>
	public override string WeChatAntiAddictionText => "Boicotea juegos con contenido inapropiado y di no a la piraterÃ­a. ProtÃ©gete y no dejes que te engaÃ±en. Jugar a videojuegos es bueno, pero jugar demasiado puede perjudicar tu salud. Gestiona bien tu tiempo para poder vivir una vida saludable.";

	/// <summary>
	/// Key: "WeChat.RealNameNotVerified"
	/// English String: "Your WeChat is not real-name verified. Please use a real-name verified WeChat account and try again. Please visit https://jiazhang.qq.com/zk/home.html"
	/// </summary>
	public override string WeChatRealNameNotVerified => "Tu nombre real no se ha verificado para la cuenta de WeChat. Utiliza un nombre real verificado para tu cuenta de WeChat e intÃ©ntalo de nuevo. Visita la pÃ¡gina https://jiazhang.qq.com/zk/home.html.";

	public LoginResources_es_es(TranslationResourceState state)
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
		return "Â¿Has olvidado tu contraseÃ±a o nombre de usuario?";
	}

	protected override string _GetTemplateForActionForgotPasswordOrUsernameQuestionCapitalized()
	{
		return "Â¿Has olvidado tu contraseÃ±a o nombre de usuario?";
	}

	protected override string _GetTemplateForActionLogin()
	{
		return "Iniciar sesiÃ³n";
	}

	protected override string _GetTemplateForActionLogInCapitalized()
	{
		return "Iniciar sesiÃ³n";
	}

	protected override string _GetTemplateForActionOk()
	{
		return "Aceptar";
	}

	protected override string _GetTemplateForActionPlayAsGuest()
	{
		return "Jugar como invitado";
	}

	protected override string _GetTemplateForActionResend()
	{
		return "Reenviar";
	}

	protected override string _GetTemplateForActionResendEmail()
	{
		return "Reenviar correo electrÃ³nico";
	}

	protected override string _GetTemplateForActionSendVerificationEmail()
	{
		return "Enviar correo de verificaciÃ³n";
	}

	protected override string _GetTemplateForActionSignIn()
	{
		return "Iniciar sesiÃ³n";
	}

	protected override string _GetTemplateForActionSignInWithFacebook()
	{
		return "Iniciar sesiÃ³n con Facebook";
	}

	protected override string _GetTemplateForActionSignUp()
	{
		return "RegÃ­strate";
	}

	protected override string _GetTemplateForActionSignUpCapitalized()
	{
		return "RegÃ­strate";
	}

	protected override string _GetTemplateForActionWeChatLogin()
	{
		return "Inicio de sesiÃ³n de WeChat";
	}

	protected override string _GetTemplateForHeadingLogin()
	{
		return "Iniciar sesiÃ³n";
	}

	protected override string _GetTemplateForHeadingLoginRoblox()
	{
		return "Iniciar sesiÃ³n en Roblox";
	}

	protected override string _GetTemplateForHeadingSignUpMakeFriends()
	{
		return "RegÃ­strate para crear y hacer amigos.";
	}

	protected override string _GetTemplateForLabelAccountNotNeeded()
	{
		return "No necesitas una cuenta para jugar a Roblox.";
	}

	protected override string _GetTemplateForLabelEmailNeedsVerification()
	{
		return "Tu correo electrÃ³nico necesita verificaciÃ³n";
	}

	protected override string _GetTemplateForLabelFacebookCreatePasswordWarning()
	{
		return "Si has estado iniciando sesiÃ³n con Facebook, debes establecer una contraseÃ±a.";
	}

	protected override string _GetTemplateForLabelForgotUsernamePassword()
	{
		return "Â¿Has olvidado el nombre de usuario o contraseÃ±a?";
	}

	/// <summary>
	/// Key: "Label.GreetingForNewAccount"
	/// Shown when a username doesn't exist on the login page to invite to create a new account.
	/// English String: "Nice to meet you, {username}. {linkStartSignup}Let's make an account! {linkEndSignup}"
	/// </summary>
	public override string LabelGreetingForNewAccount(string username, string linkStartSignup, string linkEndSignup)
	{
		return $"Te damos la bienvenida, {username}. {linkStartSignup}Â¡Vamos a crearte una cuenta!{linkEndSignup}";
	}

	protected override string _GetTemplateForLabelGreetingForNewAccount()
	{
		return "Te damos la bienvenida, {username}. {linkStartSignup}Â¡Vamos a crearte una cuenta!{linkEndSignup}";
	}

	protected override string _GetTemplateForLabelLearnMore()
	{
		return "MÃ¡s informaciÃ³n";
	}

	protected override string _GetTemplateForLabelLoggingInSpinnerText()
	{
		return "Iniciando sesiÃ³n...";
	}

	protected override string _GetTemplateForLabelLogin()
	{
		return "Iniciar sesiÃ³n";
	}

	protected override string _GetTemplateForLabelLoginWithYour()
	{
		return "Inicia sesiÃ³n con";
	}

	protected override string _GetTemplateForLabelNoAccount()
	{
		return "Â¿No tienes una cuenta de Roblox?";
	}

	protected override string _GetTemplateForLabelNonAMemberQuestion()
	{
		return "Â¿No eres miembro?";
	}

	protected override string _GetTemplateForLabelNotReceived()
	{
		return "Â¿No lo has recibido?";
	}

	protected override string _GetTemplateForLabelOr()
	{
		return "O";
	}

	protected override string _GetTemplateForLabelPassword()
	{
		return "ContraseÃ±a";
	}

	protected override string _GetTemplateForLabelPasswordWithColumn()
	{
		return "ContraseÃ±a:";
	}

	protected override string _GetTemplateForLabelStartPlaying()
	{
		return "Â¡Puedes jugar directamente en modo invitado!";
	}

	protected override string _GetTemplateForLabelUnverifiedEmailInstructions()
	{
		return "Para iniciar sesiÃ³n con tu correo electrÃ³nico, primero debes verificarlo. TambiÃ©n puedes iniciar sesiÃ³n con tu nombre de usuario.";
	}

	protected override string _GetTemplateForLabelUsername()
	{
		return "Nombre de usuario";
	}

	protected override string _GetTemplateForLabelUsernameEmail()
	{
		return "Nombre de usuario o correo";
	}

	protected override string _GetTemplateForLabelUsernameEmailPhone()
	{
		return "Usuario/correo/telÃ©fono";
	}

	protected override string _GetTemplateForLabelUsernamePhone()
	{
		return "Nombre de usuario o nÃºmero de telÃ©fono";
	}

	protected override string _GetTemplateForLabelUsernameWithColumn()
	{
		return "Nombre de usuario:";
	}

	protected override string _GetTemplateForLabelVerificationEmailSent()
	{
		return "Â¡Correo electrÃ³nico de verificaciÃ³n enviado!";
	}

	protected override string _GetTemplateForLabelWeChatAntiAddictionText()
	{
		return "Boicotea juegos con contenido inapropiado y di no a la piraterÃ­a. No permitas que te engaÃ±en. Jugar a videojuegos es bueno, pero jugar demasiado puede perjudicar tu salud. Gestiona bien tu tiempo para vivir una vida balanceada y saludable.";
	}

	protected override string _GetTemplateForMessageUnknownErrorTryAgain()
	{
		return "Se ha producido un error desconocido. IntÃ©ntalo de nuevo mÃ¡s tarde.";
	}

	protected override string _GetTemplateForMessageUsernameAndPasswordRequired()
	{
		return "Es necesario especificar el nombre de usuario y la contraseÃ±a.";
	}

	protected override string _GetTemplateForResponseAccountIssueErrorContactSupport()
	{
		return "Problema con la cuenta. Ponte en contacto con asistencia tÃ©cnica.";
	}

	protected override string _GetTemplateForResponseAccountLockedRequestReset()
	{
		return "Se ha bloqueado la cuenta. Solicita un restablecimiento de contraseÃ±a.";
	}

	protected override string _GetTemplateForResponseAccountNotFound()
	{
		return "No se ha encontrado la cuenta. IntÃ©ntalo de nuevo mÃ¡s tarde.";
	}

	protected override string _GetTemplateForResponseEmailLinkedToMultipleAccountsLoginWithUsername()
	{
		return "Tu correo electrÃ³nico estÃ¡ asociado a mÃ¡s de un nombre de usuario. Inicia sesiÃ³n con tu nombre de usuario.";
	}

	protected override string _GetTemplateForResponseEmailSent()
	{
		return "Â¡Correo electrÃ³nico enviado!";
	}

	protected override string _GetTemplateForResponseIncorrectEmailOrPassword()
	{
		return "Correo electrÃ³nico o contraseÃ±a incorrectos.";
	}

	protected override string _GetTemplateForResponseIncorrectPhoneOrPassword()
	{
		return "NÃºmero de telÃ©fono o contraseÃ±a incorrectos.";
	}

	protected override string _GetTemplateForResponseIncorrectUsernamePassword()
	{
		return "Nombre de usuario o contraseÃ±a incorrectos.";
	}

	protected override string _GetTemplateForResponseLoginWithUsername()
	{
		return "Algo ha ido mal. Inicia sesiÃ³n con tu nombre de usuario.";
	}

	protected override string _GetTemplateForResponsePasswordNotProvided()
	{
		return "Debes introducir una contraseÃ±a.";
	}

	protected override string _GetTemplateForResponseTooManyAttemptsPleaseWait()
	{
		return "Demasiados intentos. Espera un poco.";
	}

	protected override string _GetTemplateForResponseUnknownError()
	{
		return "Error desconocido";
	}

	protected override string _GetTemplateForResponseUnknownLoginError()
	{
		return "Fallo desconocido al iniciar sesiÃ³n.";
	}

	protected override string _GetTemplateForResponseUnverifiedEmailLoginWithUsername()
	{
		return "Tu correo electrÃ³nico no ha sido verificado. Inicia sesiÃ³n con tu nombre de usuario.";
	}

	protected override string _GetTemplateForResponseUnverifiedPhoneLoginWithUsername()
	{
		return "Tu nÃºmero de telÃ©fono no ha sido verificado. Inicia sesiÃ³n con tu nombre de usuario.";
	}

	protected override string _GetTemplateForResponseUsernameNotProvided()
	{
		return "Debes introducir un nombre de usuario.";
	}

	protected override string _GetTemplateForResponseUseSocialSignOn()
	{
		return "Error al iniciar sesiÃ³n. Intenta hacerlo con una red social.";
	}

	/// <summary>
	/// Key: "Response.WeChatNotRealNameVerified"
	/// English String: "Your WeChat is not real-name verified. Please use a real-name verified WeChat account and try again. Please visit {url}"
	/// </summary>
	public override string ResponseWeChatNotRealNameVerified(string url)
	{
		return $"Tu nombre real no se ha verificado para la cuenta de WeChat. Utiliza un nombre real verificado para tu cuenta de WeChat e intÃ©ntalo de nuevo. Visita {url}";
	}

	protected override string _GetTemplateForResponseWeChatNotRealNameVerified()
	{
		return "Tu nombre real no se ha verificado para la cuenta de WeChat. Utiliza un nombre real verificado para tu cuenta de WeChat e intÃ©ntalo de nuevo. Visita {url}";
	}

	protected override string _GetTemplateForWeChatAntiAddictionText()
	{
		return "Boicotea juegos con contenido inapropiado y di no a la piraterÃ­a. ProtÃ©gete y no dejes que te engaÃ±en. Jugar a videojuegos es bueno, pero jugar demasiado puede perjudicar tu salud. Gestiona bien tu tiempo para poder vivir una vida saludable.";
	}

	protected override string _GetTemplateForWeChatRealNameNotVerified()
	{
		return "Tu nombre real no se ha verificado para la cuenta de WeChat. Utiliza un nombre real verificado para tu cuenta de WeChat e intÃ©ntalo de nuevo. Visita la pÃ¡gina https://jiazhang.qq.com/zk/home.html.";
	}
}


}
