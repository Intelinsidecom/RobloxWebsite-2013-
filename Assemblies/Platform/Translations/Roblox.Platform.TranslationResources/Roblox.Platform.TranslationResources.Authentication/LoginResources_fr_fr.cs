namespace Roblox.TranslationResources.Authentication;

/// <summary>
/// This class overrides LoginResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class LoginResources_fr_fr : LoginResources_en_us, ILoginResources, ITranslationResources
{
	/// <summary>
	/// Key: "Action.Cancel"
	/// Cancel button text
	/// English String: "Cancel"
	/// </summary>
	public override string ActionCancel => "Annuler";

	/// <summary>
	/// Key: "Action.Facebook"
	/// facebook button label
	/// English String: "Facebook"
	/// </summary>
	public override string ActionFacebook => "Facebook\u00a0";

	/// <summary>
	/// Key: "Action.ForgotPasswordOrUsernameQuestion"
	/// English String: "Forgot password or username?"
	/// </summary>
	public override string ActionForgotPasswordOrUsernameQuestion => "Mot de passe ou nom d'utilisateur oublié\u00a0?";

	/// <summary>
	/// Key: "Action.ForgotPasswordOrUsernameQuestionCapitalized"
	/// link under login form
	/// English String: "Forgot Password or Username?"
	/// </summary>
	public override string ActionForgotPasswordOrUsernameQuestionCapitalized => "Mot de passe ou nom d'utilisateur oublié\u00a0?";

	/// <summary>
	/// Key: "Action.Login"
	/// English String: "Login"
	/// </summary>
	public override string ActionLogin => "Connexion";

	/// <summary>
	/// Key: "Action.LogInCapitalized"
	/// login button label. please note this is different from 'Login' or 'Log in'.
	/// English String: "Log In"
	/// </summary>
	public override string ActionLogInCapitalized => "Connexion";

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
	public override string ActionPlayAsGuest => "Jouer en tant qu'invité";

	/// <summary>
	/// Key: "Action.Resend"
	/// button text for resending verification email
	/// English String: "Resend"
	/// </summary>
	public override string ActionResend => "Renvoyer";

	/// <summary>
	/// Key: "Action.ResendEmail"
	/// link that resends verification email to user
	/// English String: "Resend Email"
	/// </summary>
	public override string ActionResendEmail => "Renvoyer l'e-mail";

	/// <summary>
	/// Key: "Action.SendVerificationEmail"
	/// button user can click to send a verification link to their email
	/// English String: "Send Verification Email"
	/// </summary>
	public override string ActionSendVerificationEmail => "Envoyer l'e-mail de vérification";

	/// <summary>
	/// Key: "Action.SignIn"
	/// Sign In button text
	/// English String: "Sign In"
	/// </summary>
	public override string ActionSignIn => "S'inscrire";

	/// <summary>
	/// Key: "Action.SignInWithFacebook"
	/// Sign In with Facebook
	/// English String: "Sign In with Facebook"
	/// </summary>
	public override string ActionSignInWithFacebook => "Connexion via Facebook";

	/// <summary>
	/// Key: "Action.SignUp"
	/// English String: "Sign up"
	/// </summary>
	public override string ActionSignUp => "S'inscrire";

	/// <summary>
	/// Key: "Action.SignUpCapitalized"
	/// link which takes user to sign up page
	/// English String: "Sign Up"
	/// </summary>
	public override string ActionSignUpCapitalized => "S'inscrire";

	/// <summary>
	/// Key: "Action.WeChatLogin"
	/// button text for logging in with WeChat
	/// English String: "WeChat Login"
	/// </summary>
	public override string ActionWeChatLogin => "Connexion WeChat";

	/// <summary>
	/// Key: "Heading.Login"
	/// heading on the login page
	/// English String: "Login"
	/// </summary>
	public override string HeadingLogin => "Connexion";

	/// <summary>
	/// Key: "Heading.LoginRoblox"
	/// current login page heading
	/// English String: "Login to Roblox"
	/// </summary>
	public override string HeadingLoginRoblox => "Connexion à Roblox";

	public override string HeadingSignUpMakeFriends => "Inscrivez-vous pour construire et vous faire des amis.";

	/// <summary>
	/// Key: "Label.AccountNotNeeded"
	/// You don't need an account to play Roblox
	/// English String: "You don't need an account to play Roblox"
	/// </summary>
	public override string LabelAccountNotNeeded => "Vous n'avez pas besoin de compte pour jouer à Roblox.";

	/// <summary>
	/// Key: "Label.EmailNeedsVerification"
	/// modal header used for prompting user they need to verify their email in order to log in with it
	/// English String: "Your email needs verification"
	/// </summary>
	public override string LabelEmailNeedsVerification => "Vous devez vérifier votre adresse e-mail";

	/// <summary>
	/// Key: "Label.FacebookCreatePasswordWarning"
	/// If you have been signing in with Facebook, you must set a password.
	/// English String: "If you have been signing in with Facebook, you must set a password."
	/// </summary>
	public override string LabelFacebookCreatePasswordWarning => "Si vous vous connectez via Facebook, vous devez définir un mot de passe.";

	/// <summary>
	/// Key: "Label.ForgotUsernamePassword"
	/// landing page top right link for password reset
	/// English String: "Forgot Username/Password?"
	/// </summary>
	public override string LabelForgotUsernamePassword => "Nom d'utilisateur/mot de passe oublié\u00a0?";

	/// <summary>
	/// Key: "Label.LearnMore"
	/// learn more link text
	/// English String: "Learn more"
	/// </summary>
	public override string LabelLearnMore => "En savoir plus";

	/// <summary>
	/// Key: "Label.LoggingInSpinnerText"
	/// English String: "Logging in…"
	/// </summary>
	public override string LabelLoggingInSpinnerText => "Connexion en cours...";

	/// <summary>
	/// Key: "Label.Login"
	/// English String: "Log in"
	/// </summary>
	public override string LabelLogin => "Connexion";

	/// <summary>
	/// Key: "Label.LoginWithYour"
	/// Label for a partition line between login with email and facebook login. Please keep the text in lowercase for roman characters.
	/// English String: "login with your"
	/// </summary>
	public override string LabelLoginWithYour => "connectez-vous avec";

	/// <summary>
	/// Key: "Label.NoAccount"
	/// Don't have an account?
	/// English String: "Don't have an account?"
	/// </summary>
	public override string LabelNoAccount => "Vous n'avez pas de compte\u00a0?";

	/// <summary>
	/// Key: "Label.NonAMemberQuestion"
	/// The question heading for the section on the login page to take use to sign up page.
	/// English String: "Not a member?"
	/// </summary>
	public override string LabelNonAMemberQuestion => "Pas encore membre\u00a0?";

	/// <summary>
	/// Key: "Label.NotReceived"
	/// prompt for allowing users to resend verification email
	/// English String: "Didn't receive it?"
	/// </summary>
	public override string LabelNotReceived => "Vous n'avez pas reçu d'e-mail\u00a0?";

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
	public override string LabelPassword => "Mot de passe";

	/// <summary>
	/// Key: "Label.PasswordWithColumn"
	/// label for the password field on the login page
	/// English String: "Password:"
	/// </summary>
	public override string LabelPasswordWithColumn => "Mot de passe\u00a0:";

	/// <summary>
	/// Key: "Label.StartPlaying"
	/// You can start playing right now, in guest mode!
	/// English String: "You can start playing right now, in guest mode!"
	/// </summary>
	public override string LabelStartPlaying => "Vous pouvez commencer à jouer tout de suite en mode invité\u00a0!";

	/// <summary>
	/// Key: "Label.UnverifiedEmailInstructions"
	/// message shown in a modal when user logs in with unverified email
	/// English String: "To log in with your email, it must be verified. You can also log in with your username."
	/// </summary>
	public override string LabelUnverifiedEmailInstructions => "Avant de vous connecter au moyen de votre adresse e-mail, celle-ci doit être vérifiée. Vous pouvez également vous connecter avec votre nom d'utilisateur.";

	/// <summary>
	/// Key: "Label.Username"
	/// English String: "Username"
	/// </summary>
	public override string LabelUsername => "Nom d'utilisateur";

	/// <summary>
	/// Key: "Label.UsernameEmail"
	/// placeholder text for input field that accepts username or email
	/// English String: "Username/Email"
	/// </summary>
	public override string LabelUsernameEmail => "Nom d'utilisateur/E-mail";

	/// <summary>
	/// Key: "Label.UsernameEmailPhone"
	/// placeholder text for input fields that accept username, email or phone
	/// English String: "Username/Email/Phone"
	/// </summary>
	public override string LabelUsernameEmailPhone => "Identifiant/E-mail/Téléphone";

	/// <summary>
	/// Key: "Label.UsernamePhone"
	/// placeholder text for input field that accepts username or phone
	/// English String: "Username/Phone"
	/// </summary>
	public override string LabelUsernamePhone => "Nom d'utilisateur/Téléphone";

	/// <summary>
	/// Key: "Label.UsernameWithColumn"
	/// label for username field on login page
	/// English String: "Username:"
	/// </summary>
	public override string LabelUsernameWithColumn => "Nom d'utilisateur\u00a0:";

	/// <summary>
	/// Key: "Label.VerificationEmailSent"
	/// message telling user a verification email was sent to them
	/// English String: "Verification Email Sent!"
	/// </summary>
	public override string LabelVerificationEmailSent => "E-mail de vérification envoyé\u00a0!";

	/// <summary>
	/// Key: "Label.WeChatAntiAddictionText"
	/// English String: "Boycott bad games, refuse pirated games. Be aware of self-defense and being deceived. Playing games is good for your brain, but too much game play can harm your health. Manage your time well and enjoy a healthy lifestyle."
	/// </summary>
	public override string LabelWeChatAntiAddictionText => "Boycottez les mauvais jeux, évitez les jeux piratés. Faites attention à votre sécurité et ne vous faites pas berner. Jouer a des effets positifs sur le cerveau, mais en abuser risque de nuire à votre santé. Gérez votre temps convenablement et menez une vie saine.";

	/// <summary>
	/// Key: "Message.UnknownErrorTryAgain"
	/// An unknown error occurred. Please try again.
	/// English String: "An unknown error occurred. Please try again."
	/// </summary>
	public override string MessageUnknownErrorTryAgain => "Une erreur inconnue est survenue. Veuillez réessayer.";

	/// <summary>
	/// Key: "Message.UsernameAndPasswordRequired"
	/// message shown to user when they attempt to login without entering a username or password
	/// English String: "Username and password required"
	/// </summary>
	public override string MessageUsernameAndPasswordRequired => "Nom d'utilisateur et mot de passe requis";

	/// <summary>
	/// Key: "Response.AccountIssueErrorContactSupport"
	/// English String: "Account issue. Please contact Support."
	/// </summary>
	public override string ResponseAccountIssueErrorContactSupport => "Problème de compte. Veuillez contacter l'assistance.";

	/// <summary>
	/// Key: "Response.AccountLockedRequestReset"
	/// Account has been locked. Please request a password reset.
	/// English String: "Account has been locked. Please request a password reset."
	/// </summary>
	public override string ResponseAccountLockedRequestReset => "Le compte a été verrouillé. Veuillez faire une demande de réinitialisation de mot de passe.";

	/// <summary>
	/// Key: "Response.AccountNotFound"
	/// Account not found. Please try again.
	/// English String: "Account not found. Please try again."
	/// </summary>
	public override string ResponseAccountNotFound => "Aucun compte n'a été trouvé. Veuillez réessayer.";

	/// <summary>
	/// Key: "Response.EmailLinkedToMultipleAccountsLoginWithUsername"
	/// error message displayed when user attempts to log in with an email that is linked to multiple accounts
	/// English String: "Your email is associated with more than 1 username. Please login with your username."
	/// </summary>
	public override string ResponseEmailLinkedToMultipleAccountsLoginWithUsername => "Votre adresse e-mail est associée à plus d'un nom d'utilisateur. Veuillez vous connecter avec votre nom d'utilisateur.";

	/// <summary>
	/// Key: "Response.EmailSent"
	/// response telling user that a verification email has been sent to them
	/// English String: "Email sent!"
	/// </summary>
	public override string ResponseEmailSent => "E-mail envoyé\u00a0!";

	/// <summary>
	/// Key: "Response.IncorrectEmailOrPassword"
	/// error message displayed when user logs in with an invalid email or password
	/// English String: "Incorrect email or password."
	/// </summary>
	public override string ResponseIncorrectEmailOrPassword => "Adresse e-mail ou mot de passe invalide.";

	/// <summary>
	/// Key: "Response.IncorrectPhoneOrPassword"
	/// error message displayed when user logs in with an invalid phone or password
	/// English String: "Incorrect phone or password."
	/// </summary>
	public override string ResponseIncorrectPhoneOrPassword => "Numéro de téléphone ou mot de passe invalide.";

	/// <summary>
	/// Key: "Response.IncorrectUsernamePassword"
	/// English String: "Incorrect username or password."
	/// </summary>
	public override string ResponseIncorrectUsernamePassword => "Nom d'utilisateur ou mot de passe incorrect.";

	/// <summary>
	/// Key: "Response.LoginWithUsername"
	/// error message shown when user attempts to login with method other than username and an error occurred
	/// English String: "Something went wrong. Please login with your username."
	/// </summary>
	public override string ResponseLoginWithUsername => "Un problème est survenu. Veuillez vous connecter avec votre nom d'utilisateur.";

	/// <summary>
	/// Key: "Response.PasswordNotProvided"
	/// password field is empty
	/// English String: "You must enter a password."
	/// </summary>
	public override string ResponsePasswordNotProvided => "Vous devez saisir un mot de passe.";

	/// <summary>
	/// Key: "Response.TooManyAttemptsPleaseWait"
	/// English String: "Too many attempts. Please wait a bit."
	/// </summary>
	public override string ResponseTooManyAttemptsPleaseWait => "Trop de tentatives. Veuillez patienter un moment.";

	/// <summary>
	/// Key: "Response.UnknownError"
	/// English String: "Unknown Error"
	/// </summary>
	public override string ResponseUnknownError => "Erreur inconnue";

	/// <summary>
	/// Key: "Response.UnknownLoginError"
	/// Unknown login failure.
	/// English String: "Unknown login failure."
	/// </summary>
	public override string ResponseUnknownLoginError => "Échec de connexion inconnu.";

	/// <summary>
	/// Key: "Response.UnverifiedEmailLoginWithUsername"
	/// error message shown when user attempts to login with unverified email
	/// English String: "Your email is not verified. Please login with your username."
	/// </summary>
	public override string ResponseUnverifiedEmailLoginWithUsername => "Votre adresse e-mail n'a pas été confirmée. Veuillez vous connecter avec votre nom d'utilisateur.";

	/// <summary>
	/// Key: "Response.UnverifiedPhoneLoginWithUsername"
	/// error message shown when user attempts to login with an unverified phone number
	/// English String: "Your phone is not verified. Please login with your username."
	/// </summary>
	public override string ResponseUnverifiedPhoneLoginWithUsername => "Votre numéro de téléphone n'a pas été confirmé. Veuillez vous connecter avec votre nom d'utilisateur.";

	/// <summary>
	/// Key: "Response.UsernameNotProvided"
	/// username field is empty
	/// English String: "You must enter a username."
	/// </summary>
	public override string ResponseUsernameNotProvided => "Vous devez saisir un nom d'utilisateur.";

	/// <summary>
	/// Key: "Response.UseSocialSignOn"
	/// Unable to login. Please use Social Network sign on.
	/// English String: "Unable to login. Please use Social Network sign on."
	/// </summary>
	public override string ResponseUseSocialSignOn => "Connexion impossible. Veuillez utiliser un réseau social pour vous connecter.";

	/// <summary>
	/// Key: "WeChat.AntiAddictionText"
	/// English String: "Boycott bad games, refuse pirated games. Be aware of self-defense and being deceived. Playing games is good for your brain, but too much game play can harm your health. Manage your time well and enjoy a healthy lifestyle."
	/// </summary>
	public override string WeChatAntiAddictionText => "Boycottez les mauvais jeux, évitez les jeux piratés. Faites attention à votre sécurité et ne vous faites pas berner. Jouer a des effets positifs sur le cerveau, mais en abuser risque de nuire à votre santé. Gérez votre temps convenablement et menez une vie saine.";

	/// <summary>
	/// Key: "WeChat.RealNameNotVerified"
	/// English String: "Your WeChat is not real-name verified. Please use a real-name verified WeChat account and try again. Please visit https://jiazhang.qq.com/zk/home.html"
	/// </summary>
	public override string WeChatRealNameNotVerified => "Ton WeChat n’est pas vérifié. Il faut utiliser un compte vérifié WeChat puis réessayer. Rends-toi ici : https://jiazhang.qq.com/zk/home.html";

	public LoginResources_fr_fr(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionCancel()
	{
		return "Annuler";
	}

	protected override string _GetTemplateForActionFacebook()
	{
		return "Facebook\u00a0";
	}

	protected override string _GetTemplateForActionForgotPasswordOrUsernameQuestion()
	{
		return "Mot de passe ou nom d'utilisateur oublié\u00a0?";
	}

	protected override string _GetTemplateForActionForgotPasswordOrUsernameQuestionCapitalized()
	{
		return "Mot de passe ou nom d'utilisateur oublié\u00a0?";
	}

	protected override string _GetTemplateForActionLogin()
	{
		return "Connexion";
	}

	protected override string _GetTemplateForActionLogInCapitalized()
	{
		return "Connexion";
	}

	protected override string _GetTemplateForActionOk()
	{
		return "OK";
	}

	protected override string _GetTemplateForActionPlayAsGuest()
	{
		return "Jouer en tant qu'invité";
	}

	protected override string _GetTemplateForActionResend()
	{
		return "Renvoyer";
	}

	protected override string _GetTemplateForActionResendEmail()
	{
		return "Renvoyer l'e-mail";
	}

	protected override string _GetTemplateForActionSendVerificationEmail()
	{
		return "Envoyer l'e-mail de vérification";
	}

	protected override string _GetTemplateForActionSignIn()
	{
		return "S'inscrire";
	}

	protected override string _GetTemplateForActionSignInWithFacebook()
	{
		return "Connexion via Facebook";
	}

	protected override string _GetTemplateForActionSignUp()
	{
		return "S'inscrire";
	}

	protected override string _GetTemplateForActionSignUpCapitalized()
	{
		return "S'inscrire";
	}

	protected override string _GetTemplateForActionWeChatLogin()
	{
		return "Connexion WeChat";
	}

	protected override string _GetTemplateForHeadingLogin()
	{
		return "Connexion";
	}

	protected override string _GetTemplateForHeadingLoginRoblox()
	{
		return "Connexion à Roblox";
	}

	protected override string _GetTemplateForHeadingSignUpMakeFriends()
	{
		return "Inscrivez-vous pour construire et vous faire des amis.";
	}

	protected override string _GetTemplateForLabelAccountNotNeeded()
	{
		return "Vous n'avez pas besoin de compte pour jouer à Roblox.";
	}

	protected override string _GetTemplateForLabelEmailNeedsVerification()
	{
		return "Vous devez vérifier votre adresse e-mail";
	}

	protected override string _GetTemplateForLabelFacebookCreatePasswordWarning()
	{
		return "Si vous vous connectez via Facebook, vous devez définir un mot de passe.";
	}

	protected override string _GetTemplateForLabelForgotUsernamePassword()
	{
		return "Nom d'utilisateur/mot de passe oublié\u00a0?";
	}

	/// <summary>
	/// Key: "Label.GreetingForNewAccount"
	/// Shown when a username doesn't exist on the login page to invite to create a new account.
	/// English String: "Nice to meet you, {username}. {linkStartSignup}Let's make an account! {linkEndSignup}"
	/// </summary>
	public override string LabelGreetingForNewAccount(string username, string linkStartSignup, string linkEndSignup)
	{
		return $"Bonjour, {username}. {linkStartSignup}Nous allons vous créer un compte\u00a0!{linkEndSignup}";
	}

	protected override string _GetTemplateForLabelGreetingForNewAccount()
	{
		return "Bonjour, {username}. {linkStartSignup}Nous allons vous créer un compte\u00a0!{linkEndSignup}";
	}

	protected override string _GetTemplateForLabelLearnMore()
	{
		return "En savoir plus";
	}

	protected override string _GetTemplateForLabelLoggingInSpinnerText()
	{
		return "Connexion en cours...";
	}

	protected override string _GetTemplateForLabelLogin()
	{
		return "Connexion";
	}

	protected override string _GetTemplateForLabelLoginWithYour()
	{
		return "connectez-vous avec";
	}

	protected override string _GetTemplateForLabelNoAccount()
	{
		return "Vous n'avez pas de compte\u00a0?";
	}

	protected override string _GetTemplateForLabelNonAMemberQuestion()
	{
		return "Pas encore membre\u00a0?";
	}

	protected override string _GetTemplateForLabelNotReceived()
	{
		return "Vous n'avez pas reçu d'e-mail\u00a0?";
	}

	protected override string _GetTemplateForLabelOr()
	{
		return "Ou";
	}

	protected override string _GetTemplateForLabelPassword()
	{
		return "Mot de passe";
	}

	protected override string _GetTemplateForLabelPasswordWithColumn()
	{
		return "Mot de passe\u00a0:";
	}

	protected override string _GetTemplateForLabelStartPlaying()
	{
		return "Vous pouvez commencer à jouer tout de suite en mode invité\u00a0!";
	}

	protected override string _GetTemplateForLabelUnverifiedEmailInstructions()
	{
		return "Avant de vous connecter au moyen de votre adresse e-mail, celle-ci doit être vérifiée. Vous pouvez également vous connecter avec votre nom d'utilisateur.";
	}

	protected override string _GetTemplateForLabelUsername()
	{
		return "Nom d'utilisateur";
	}

	protected override string _GetTemplateForLabelUsernameEmail()
	{
		return "Nom d'utilisateur/E-mail";
	}

	protected override string _GetTemplateForLabelUsernameEmailPhone()
	{
		return "Identifiant/E-mail/Téléphone";
	}

	protected override string _GetTemplateForLabelUsernamePhone()
	{
		return "Nom d'utilisateur/Téléphone";
	}

	protected override string _GetTemplateForLabelUsernameWithColumn()
	{
		return "Nom d'utilisateur\u00a0:";
	}

	protected override string _GetTemplateForLabelVerificationEmailSent()
	{
		return "E-mail de vérification envoyé\u00a0!";
	}

	protected override string _GetTemplateForLabelWeChatAntiAddictionText()
	{
		return "Boycottez les mauvais jeux, évitez les jeux piratés. Faites attention à votre sécurité et ne vous faites pas berner. Jouer a des effets positifs sur le cerveau, mais en abuser risque de nuire à votre santé. Gérez votre temps convenablement et menez une vie saine.";
	}

	protected override string _GetTemplateForMessageUnknownErrorTryAgain()
	{
		return "Une erreur inconnue est survenue. Veuillez réessayer.";
	}

	protected override string _GetTemplateForMessageUsernameAndPasswordRequired()
	{
		return "Nom d'utilisateur et mot de passe requis";
	}

	protected override string _GetTemplateForResponseAccountIssueErrorContactSupport()
	{
		return "Problème de compte. Veuillez contacter l'assistance.";
	}

	protected override string _GetTemplateForResponseAccountLockedRequestReset()
	{
		return "Le compte a été verrouillé. Veuillez faire une demande de réinitialisation de mot de passe.";
	}

	protected override string _GetTemplateForResponseAccountNotFound()
	{
		return "Aucun compte n'a été trouvé. Veuillez réessayer.";
	}

	protected override string _GetTemplateForResponseEmailLinkedToMultipleAccountsLoginWithUsername()
	{
		return "Votre adresse e-mail est associée à plus d'un nom d'utilisateur. Veuillez vous connecter avec votre nom d'utilisateur.";
	}

	protected override string _GetTemplateForResponseEmailSent()
	{
		return "E-mail envoyé\u00a0!";
	}

	protected override string _GetTemplateForResponseIncorrectEmailOrPassword()
	{
		return "Adresse e-mail ou mot de passe invalide.";
	}

	protected override string _GetTemplateForResponseIncorrectPhoneOrPassword()
	{
		return "Numéro de téléphone ou mot de passe invalide.";
	}

	protected override string _GetTemplateForResponseIncorrectUsernamePassword()
	{
		return "Nom d'utilisateur ou mot de passe incorrect.";
	}

	protected override string _GetTemplateForResponseLoginWithUsername()
	{
		return "Un problème est survenu. Veuillez vous connecter avec votre nom d'utilisateur.";
	}

	protected override string _GetTemplateForResponsePasswordNotProvided()
	{
		return "Vous devez saisir un mot de passe.";
	}

	protected override string _GetTemplateForResponseTooManyAttemptsPleaseWait()
	{
		return "Trop de tentatives. Veuillez patienter un moment.";
	}

	protected override string _GetTemplateForResponseUnknownError()
	{
		return "Erreur inconnue";
	}

	protected override string _GetTemplateForResponseUnknownLoginError()
	{
		return "Échec de connexion inconnu.";
	}

	protected override string _GetTemplateForResponseUnverifiedEmailLoginWithUsername()
	{
		return "Votre adresse e-mail n'a pas été confirmée. Veuillez vous connecter avec votre nom d'utilisateur.";
	}

	protected override string _GetTemplateForResponseUnverifiedPhoneLoginWithUsername()
	{
		return "Votre numéro de téléphone n'a pas été confirmé. Veuillez vous connecter avec votre nom d'utilisateur.";
	}

	protected override string _GetTemplateForResponseUsernameNotProvided()
	{
		return "Vous devez saisir un nom d'utilisateur.";
	}

	protected override string _GetTemplateForResponseUseSocialSignOn()
	{
		return "Connexion impossible. Veuillez utiliser un réseau social pour vous connecter.";
	}

	/// <summary>
	/// Key: "Response.WeChatNotRealNameVerified"
	/// English String: "Your WeChat is not real-name verified. Please use a real-name verified WeChat account and try again. Please visit {url}"
	/// </summary>
	public override string ResponseWeChatNotRealNameVerified(string url)
	{
		return $"Votre compte WeChat n'a pas été vérifié à l'aide de votre nom réel. Veuillez utiliser un compte WeChat vérifié et réessayer. Consultez la page {url}";
	}

	protected override string _GetTemplateForResponseWeChatNotRealNameVerified()
	{
		return "Votre compte WeChat n'a pas été vérifié à l'aide de votre nom réel. Veuillez utiliser un compte WeChat vérifié et réessayer. Consultez la page {url}";
	}

	protected override string _GetTemplateForWeChatAntiAddictionText()
	{
		return "Boycottez les mauvais jeux, évitez les jeux piratés. Faites attention à votre sécurité et ne vous faites pas berner. Jouer a des effets positifs sur le cerveau, mais en abuser risque de nuire à votre santé. Gérez votre temps convenablement et menez une vie saine.";
	}

	protected override string _GetTemplateForWeChatRealNameNotVerified()
	{
		return "Ton WeChat n’est pas vérifié. Il faut utiliser un compte vérifié WeChat puis réessayer. Rends-toi ici : https://jiazhang.qq.com/zk/home.html";
	}
}
