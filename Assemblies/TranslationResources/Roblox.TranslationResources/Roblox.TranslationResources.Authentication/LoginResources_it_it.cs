namespace Roblox.TranslationResources.Authentication;

/// <summary>
/// This class overrides LoginResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class LoginResources_it_it : LoginResources_en_us, ILoginResources, ITranslationResources
{
	/// <summary>
	/// Key: "Action.Cancel"
	/// Cancel button text
	/// English String: "Cancel"
	/// </summary>
	public override string ActionCancel => "Annulla";

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
	public override string ActionForgotPasswordOrUsernameQuestion => "Hai dimenticato password o nome utente?";

	/// <summary>
	/// Key: "Action.ForgotPasswordOrUsernameQuestionCapitalized"
	/// link under login form
	/// English String: "Forgot Password or Username?"
	/// </summary>
	public override string ActionForgotPasswordOrUsernameQuestionCapitalized => "Hai dimenticato la password o il nome utente?";

	/// <summary>
	/// Key: "Action.Login"
	/// English String: "Login"
	/// </summary>
	public override string ActionLogin => "Accesso";

	/// <summary>
	/// Key: "Action.LogInCapitalized"
	/// login button label. please note this is different from 'Login' or 'Log in'.
	/// English String: "Log In"
	/// </summary>
	public override string ActionLogInCapitalized => "Accedi";

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
	public override string ActionPlayAsGuest => "Gioca come ospite";

	/// <summary>
	/// Key: "Action.Resend"
	/// button text for resending verification email
	/// English String: "Resend"
	/// </summary>
	public override string ActionResend => "Invia di nuovo";

	/// <summary>
	/// Key: "Action.ResendEmail"
	/// link that resends verification email to user
	/// English String: "Resend Email"
	/// </summary>
	public override string ActionResendEmail => "Invia nuovamente e-mail";

	/// <summary>
	/// Key: "Action.SendVerificationEmail"
	/// button user can click to send a verification link to their email
	/// English String: "Send Verification Email"
	/// </summary>
	public override string ActionSendVerificationEmail => "Invia e-mail di verifica";

	/// <summary>
	/// Key: "Action.SignIn"
	/// Sign In button text
	/// English String: "Sign In"
	/// </summary>
	public override string ActionSignIn => "Accedi";

	/// <summary>
	/// Key: "Action.SignInWithFacebook"
	/// Sign In with Facebook
	/// English String: "Sign In with Facebook"
	/// </summary>
	public override string ActionSignInWithFacebook => "Accedi tramite Facebook";

	/// <summary>
	/// Key: "Action.SignUp"
	/// English String: "Sign up"
	/// </summary>
	public override string ActionSignUp => "Registrati";

	/// <summary>
	/// Key: "Action.SignUpCapitalized"
	/// link which takes user to sign up page
	/// English String: "Sign Up"
	/// </summary>
	public override string ActionSignUpCapitalized => "Registrati";

	/// <summary>
	/// Key: "Action.WeChatLogin"
	/// button text for logging in with WeChat
	/// English String: "WeChat Login"
	/// </summary>
	public override string ActionWeChatLogin => "Accesso a WeChat";

	/// <summary>
	/// Key: "Heading.Login"
	/// heading on the login page
	/// English String: "Login"
	/// </summary>
	public override string HeadingLogin => "Accesso";

	/// <summary>
	/// Key: "Heading.LoginRoblox"
	/// current login page heading
	/// English String: "Login to Roblox"
	/// </summary>
	public override string HeadingLoginRoblox => "Accedi a Roblox";

	public override string HeadingSignUpMakeFriends => "Registrati per costruire nuovi mondi e incontrare nuovi amici";

	/// <summary>
	/// Key: "Label.AccountNotNeeded"
	/// You don't need an account to play Roblox
	/// English String: "You don't need an account to play Roblox"
	/// </summary>
	public override string LabelAccountNotNeeded => "Non hai bisogno di un account per giocare a Roblox";

	/// <summary>
	/// Key: "Label.EmailNeedsVerification"
	/// modal header used for prompting user they need to verify their email in order to log in with it
	/// English String: "Your email needs verification"
	/// </summary>
	public override string LabelEmailNeedsVerification => "Devi verificare il tuo indirizzo e-mail";

	/// <summary>
	/// Key: "Label.FacebookCreatePasswordWarning"
	/// If you have been signing in with Facebook, you must set a password.
	/// English String: "If you have been signing in with Facebook, you must set a password."
	/// </summary>
	public override string LabelFacebookCreatePasswordWarning => "Se hai effettuato l'accesso tramite Facebook, devi impostare una password.";

	/// <summary>
	/// Key: "Label.ForgotUsernamePassword"
	/// landing page top right link for password reset
	/// English String: "Forgot Username/Password?"
	/// </summary>
	public override string LabelForgotUsernamePassword => "Password o nome utente dimenticati?";

	/// <summary>
	/// Key: "Label.LearnMore"
	/// learn more link text
	/// English String: "Learn more"
	/// </summary>
	public override string LabelLearnMore => "Maggiori informazioni";

	/// <summary>
	/// Key: "Label.LoggingInSpinnerText"
	/// English String: "Logging in…"
	/// </summary>
	public override string LabelLoggingInSpinnerText => "Accesso in corso...";

	/// <summary>
	/// Key: "Label.Login"
	/// English String: "Log in"
	/// </summary>
	public override string LabelLogin => "Accedi";

	/// <summary>
	/// Key: "Label.LoginWithYour"
	/// Label for a partition line between login with email and facebook login. Please keep the text in lowercase for roman characters.
	/// English String: "login with your"
	/// </summary>
	public override string LabelLoginWithYour => "accedi con";

	/// <summary>
	/// Key: "Label.NoAccount"
	/// Don't have an account?
	/// English String: "Don't have an account?"
	/// </summary>
	public override string LabelNoAccount => "Non hai un account?";

	/// <summary>
	/// Key: "Label.NonAMemberQuestion"
	/// The question heading for the section on the login page to take use to sign up page.
	/// English String: "Not a member?"
	/// </summary>
	public override string LabelNonAMemberQuestion => "Non sei membro?";

	/// <summary>
	/// Key: "Label.NotReceived"
	/// prompt for allowing users to resend verification email
	/// English String: "Didn't receive it?"
	/// </summary>
	public override string LabelNotReceived => "Non l'hai ricevuta?";

	/// <summary>
	/// Key: "Label.Or"
	/// partition between email login and facebook login
	/// English String: "Or"
	/// </summary>
	public override string LabelOr => "Oppure";

	/// <summary>
	/// Key: "Label.Password"
	/// Password
	/// English String: "Password"
	/// </summary>
	public override string LabelPassword => "Password";

	/// <summary>
	/// Key: "Label.PasswordWithColumn"
	/// label for the password field on the login page
	/// English String: "Password:"
	/// </summary>
	public override string LabelPasswordWithColumn => "Password:";

	/// <summary>
	/// Key: "Label.StartPlaying"
	/// You can start playing right now, in guest mode!
	/// English String: "You can start playing right now, in guest mode!"
	/// </summary>
	public override string LabelStartPlaying => "Puoi iniziare a giocare subito, in modalità ospite!";

	/// <summary>
	/// Key: "Label.UnverifiedEmailInstructions"
	/// message shown in a modal when user logs in with unverified email
	/// English String: "To log in with your email, it must be verified. You can also log in with your username."
	/// </summary>
	public override string LabelUnverifiedEmailInstructions => "Per accedere con il tuo indirizzo e-mail, devi prima verificarlo. Puoi accedere anche con il tuo nome utente.";

	/// <summary>
	/// Key: "Label.Username"
	/// English String: "Username"
	/// </summary>
	public override string LabelUsername => "Nome utente";

	/// <summary>
	/// Key: "Label.UsernameEmail"
	/// placeholder text for input field that accepts username or email
	/// English String: "Username/Email"
	/// </summary>
	public override string LabelUsernameEmail => "Nome utente/E-mail";

	/// <summary>
	/// Key: "Label.UsernameEmailPhone"
	/// placeholder text for input fields that accept username, email or phone
	/// English String: "Username/Email/Phone"
	/// </summary>
	public override string LabelUsernameEmailPhone => "Nome utente/E-mail/Tel.";

	/// <summary>
	/// Key: "Label.UsernamePhone"
	/// placeholder text for input field that accepts username or phone
	/// English String: "Username/Phone"
	/// </summary>
	public override string LabelUsernamePhone => "Nome utente/Numero di telefono";

	/// <summary>
	/// Key: "Label.UsernameWithColumn"
	/// label for username field on login page
	/// English String: "Username:"
	/// </summary>
	public override string LabelUsernameWithColumn => "Nome utente:";

	/// <summary>
	/// Key: "Label.VerificationEmailSent"
	/// message telling user a verification email was sent to them
	/// English String: "Verification Email Sent!"
	/// </summary>
	public override string LabelVerificationEmailSent => "E-mail di verifica inviata!";

	/// <summary>
	/// Key: "Label.WeChatAntiAddictionText"
	/// English String: "Boycott bad games, refuse pirated games. Be aware of self-defense and being deceived. Playing games is good for your brain, but too much game play can harm your health. Manage your time well and enjoy a healthy lifestyle."
	/// </summary>
	public override string LabelWeChatAntiAddictionText => "Boicotta i giochi scadenti, rifiuta i giochi pirata. Difenditi e stai attento a non farti ingannare. I videogiochi sono un ottimo esercizio per la mente, ma esagerando diventano dannosi per la salute. Gestisci bene il tuo tempo e goditi uno stile di vita sano.";

	/// <summary>
	/// Key: "Message.UnknownErrorTryAgain"
	/// An unknown error occurred. Please try again.
	/// English String: "An unknown error occurred. Please try again."
	/// </summary>
	public override string MessageUnknownErrorTryAgain => "Si è verificato un errore imprevisto. Riprova.";

	/// <summary>
	/// Key: "Message.UsernameAndPasswordRequired"
	/// message shown to user when they attempt to login without entering a username or password
	/// English String: "Username and password required"
	/// </summary>
	public override string MessageUsernameAndPasswordRequired => "Nome utente e password necessari";

	/// <summary>
	/// Key: "Response.AccountIssueErrorContactSupport"
	/// English String: "Account issue. Please contact Support."
	/// </summary>
	public override string ResponseAccountIssueErrorContactSupport => "Problema con l'account. Contatta l'assistenza.";

	/// <summary>
	/// Key: "Response.AccountLockedRequestReset"
	/// Account has been locked. Please request a password reset.
	/// English String: "Account has been locked. Please request a password reset."
	/// </summary>
	public override string ResponseAccountLockedRequestReset => "L'account è stato bloccato. Richiedi di reimpostare la password.";

	/// <summary>
	/// Key: "Response.AccountNotFound"
	/// Account not found. Please try again.
	/// English String: "Account not found. Please try again."
	/// </summary>
	public override string ResponseAccountNotFound => "Account non trovato. Riprova.";

	/// <summary>
	/// Key: "Response.EmailLinkedToMultipleAccountsLoginWithUsername"
	/// error message displayed when user attempts to log in with an email that is linked to multiple accounts
	/// English String: "Your email is associated with more than 1 username. Please login with your username."
	/// </summary>
	public override string ResponseEmailLinkedToMultipleAccountsLoginWithUsername => "Il tuo indirizzo e-mail è associato a più di un nome utente. Accedi con il tuo nome utente.";

	/// <summary>
	/// Key: "Response.EmailSent"
	/// response telling user that a verification email has been sent to them
	/// English String: "Email sent!"
	/// </summary>
	public override string ResponseEmailSent => "E-mail inviata!";

	/// <summary>
	/// Key: "Response.IncorrectEmailOrPassword"
	/// error message displayed when user logs in with an invalid email or password
	/// English String: "Incorrect email or password."
	/// </summary>
	public override string ResponseIncorrectEmailOrPassword => "E-mail o password non valide.";

	/// <summary>
	/// Key: "Response.IncorrectPhoneOrPassword"
	/// error message displayed when user logs in with an invalid phone or password
	/// English String: "Incorrect phone or password."
	/// </summary>
	public override string ResponseIncorrectPhoneOrPassword => "Numero di telefono o password non validi.";

	/// <summary>
	/// Key: "Response.IncorrectUsernamePassword"
	/// English String: "Incorrect username or password."
	/// </summary>
	public override string ResponseIncorrectUsernamePassword => "Nome utente o password incorretti.";

	/// <summary>
	/// Key: "Response.LoginWithUsername"
	/// error message shown when user attempts to login with method other than username and an error occurred
	/// English String: "Something went wrong. Please login with your username."
	/// </summary>
	public override string ResponseLoginWithUsername => "Qualcosa è andato storto. Accedi con il tuo nome utente.";

	/// <summary>
	/// Key: "Response.PasswordNotProvided"
	/// password field is empty
	/// English String: "You must enter a password."
	/// </summary>
	public override string ResponsePasswordNotProvided => "Devi inserire una password.";

	/// <summary>
	/// Key: "Response.TooManyAttemptsPleaseWait"
	/// English String: "Too many attempts. Please wait a bit."
	/// </summary>
	public override string ResponseTooManyAttemptsPleaseWait => "Troppi tentativi. Riprova più tardi.";

	/// <summary>
	/// Key: "Response.UnknownError"
	/// English String: "Unknown Error"
	/// </summary>
	public override string ResponseUnknownError => "Errore imprevisto";

	/// <summary>
	/// Key: "Response.UnknownLoginError"
	/// Unknown login failure.
	/// English String: "Unknown login failure."
	/// </summary>
	public override string ResponseUnknownLoginError => "Accesso non riuscito.";

	/// <summary>
	/// Key: "Response.UnverifiedEmailLoginWithUsername"
	/// error message shown when user attempts to login with unverified email
	/// English String: "Your email is not verified. Please login with your username."
	/// </summary>
	public override string ResponseUnverifiedEmailLoginWithUsername => "Il tuo indirizzo e-mail non è stato verificato. Accedi con il tuo nome utente.";

	/// <summary>
	/// Key: "Response.UnverifiedPhoneLoginWithUsername"
	/// error message shown when user attempts to login with an unverified phone number
	/// English String: "Your phone is not verified. Please login with your username."
	/// </summary>
	public override string ResponseUnverifiedPhoneLoginWithUsername => "Il tuo numero di telefono non è stato verificato. Accedi con il tuo nome utente.";

	/// <summary>
	/// Key: "Response.UsernameNotProvided"
	/// username field is empty
	/// English String: "You must enter a username."
	/// </summary>
	public override string ResponseUsernameNotProvided => "Devi inserire un nome utente.";

	/// <summary>
	/// Key: "Response.UseSocialSignOn"
	/// Unable to login. Please use Social Network sign on.
	/// English String: "Unable to login. Please use Social Network sign on."
	/// </summary>
	public override string ResponseUseSocialSignOn => "Impossibile effettuare l'accesso. Prova l'accesso da un social network.";

	/// <summary>
	/// Key: "WeChat.AntiAddictionText"
	/// English String: "Boycott bad games, refuse pirated games. Be aware of self-defense and being deceived. Playing games is good for your brain, but too much game play can harm your health. Manage your time well and enjoy a healthy lifestyle."
	/// </summary>
	public override string WeChatAntiAddictionText => "Boicotta i giochi scadenti, rifiuta i giochi pirata. Difenditi e stai attento a non farti ingannare. I videogiochi sono un ottimo esercizio per la mente, ma esagerando diventano dannosi per la salute. Gestisci bene il tuo tempo e goditi uno stile di vita sano.";

	/// <summary>
	/// Key: "WeChat.RealNameNotVerified"
	/// English String: "Your WeChat is not real-name verified. Please use a real-name verified WeChat account and try again. Please visit https://jiazhang.qq.com/zk/home.html"
	/// </summary>
	public override string WeChatRealNameNotVerified => "L'identità associata al tuo account WeChat non è stata verificata. Riprova utilizzando un account WeChat verificato. Vai su https://jiazhang.qq.com/zk/home.html";

	public LoginResources_it_it(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionCancel()
	{
		return "Annulla";
	}

	protected override string _GetTemplateForActionFacebook()
	{
		return "Facebook";
	}

	protected override string _GetTemplateForActionForgotPasswordOrUsernameQuestion()
	{
		return "Hai dimenticato password o nome utente?";
	}

	protected override string _GetTemplateForActionForgotPasswordOrUsernameQuestionCapitalized()
	{
		return "Hai dimenticato la password o il nome utente?";
	}

	protected override string _GetTemplateForActionLogin()
	{
		return "Accesso";
	}

	protected override string _GetTemplateForActionLogInCapitalized()
	{
		return "Accedi";
	}

	protected override string _GetTemplateForActionOk()
	{
		return "OK";
	}

	protected override string _GetTemplateForActionPlayAsGuest()
	{
		return "Gioca come ospite";
	}

	protected override string _GetTemplateForActionResend()
	{
		return "Invia di nuovo";
	}

	protected override string _GetTemplateForActionResendEmail()
	{
		return "Invia nuovamente e-mail";
	}

	protected override string _GetTemplateForActionSendVerificationEmail()
	{
		return "Invia e-mail di verifica";
	}

	protected override string _GetTemplateForActionSignIn()
	{
		return "Accedi";
	}

	protected override string _GetTemplateForActionSignInWithFacebook()
	{
		return "Accedi tramite Facebook";
	}

	protected override string _GetTemplateForActionSignUp()
	{
		return "Registrati";
	}

	protected override string _GetTemplateForActionSignUpCapitalized()
	{
		return "Registrati";
	}

	protected override string _GetTemplateForActionWeChatLogin()
	{
		return "Accesso a WeChat";
	}

	protected override string _GetTemplateForHeadingLogin()
	{
		return "Accesso";
	}

	protected override string _GetTemplateForHeadingLoginRoblox()
	{
		return "Accedi a Roblox";
	}

	protected override string _GetTemplateForHeadingSignUpMakeFriends()
	{
		return "Registrati per costruire nuovi mondi e incontrare nuovi amici";
	}

	protected override string _GetTemplateForLabelAccountNotNeeded()
	{
		return "Non hai bisogno di un account per giocare a Roblox";
	}

	protected override string _GetTemplateForLabelEmailNeedsVerification()
	{
		return "Devi verificare il tuo indirizzo e-mail";
	}

	protected override string _GetTemplateForLabelFacebookCreatePasswordWarning()
	{
		return "Se hai effettuato l'accesso tramite Facebook, devi impostare una password.";
	}

	protected override string _GetTemplateForLabelForgotUsernamePassword()
	{
		return "Password o nome utente dimenticati?";
	}

	/// <summary>
	/// Key: "Label.GreetingForNewAccount"
	/// Shown when a username doesn't exist on the login page to invite to create a new account.
	/// English String: "Nice to meet you, {username}. {linkStartSignup}Let's make an account! {linkEndSignup}"
	/// </summary>
	public override string LabelGreetingForNewAccount(string username, string linkStartSignup, string linkEndSignup)
	{
		return $"Piacere di conoscerti, {username}. {linkStartSignup}Apriamo un account! {linkEndSignup}";
	}

	protected override string _GetTemplateForLabelGreetingForNewAccount()
	{
		return "Piacere di conoscerti, {username}. {linkStartSignup}Apriamo un account! {linkEndSignup}";
	}

	protected override string _GetTemplateForLabelLearnMore()
	{
		return "Maggiori informazioni";
	}

	protected override string _GetTemplateForLabelLoggingInSpinnerText()
	{
		return "Accesso in corso...";
	}

	protected override string _GetTemplateForLabelLogin()
	{
		return "Accedi";
	}

	protected override string _GetTemplateForLabelLoginWithYour()
	{
		return "accedi con";
	}

	protected override string _GetTemplateForLabelNoAccount()
	{
		return "Non hai un account?";
	}

	protected override string _GetTemplateForLabelNonAMemberQuestion()
	{
		return "Non sei membro?";
	}

	protected override string _GetTemplateForLabelNotReceived()
	{
		return "Non l'hai ricevuta?";
	}

	protected override string _GetTemplateForLabelOr()
	{
		return "Oppure";
	}

	protected override string _GetTemplateForLabelPassword()
	{
		return "Password";
	}

	protected override string _GetTemplateForLabelPasswordWithColumn()
	{
		return "Password:";
	}

	protected override string _GetTemplateForLabelStartPlaying()
	{
		return "Puoi iniziare a giocare subito, in modalità ospite!";
	}

	protected override string _GetTemplateForLabelUnverifiedEmailInstructions()
	{
		return "Per accedere con il tuo indirizzo e-mail, devi prima verificarlo. Puoi accedere anche con il tuo nome utente.";
	}

	protected override string _GetTemplateForLabelUsername()
	{
		return "Nome utente";
	}

	protected override string _GetTemplateForLabelUsernameEmail()
	{
		return "Nome utente/E-mail";
	}

	protected override string _GetTemplateForLabelUsernameEmailPhone()
	{
		return "Nome utente/E-mail/Tel.";
	}

	protected override string _GetTemplateForLabelUsernamePhone()
	{
		return "Nome utente/Numero di telefono";
	}

	protected override string _GetTemplateForLabelUsernameWithColumn()
	{
		return "Nome utente:";
	}

	protected override string _GetTemplateForLabelVerificationEmailSent()
	{
		return "E-mail di verifica inviata!";
	}

	protected override string _GetTemplateForLabelWeChatAntiAddictionText()
	{
		return "Boicotta i giochi scadenti, rifiuta i giochi pirata. Difenditi e stai attento a non farti ingannare. I videogiochi sono un ottimo esercizio per la mente, ma esagerando diventano dannosi per la salute. Gestisci bene il tuo tempo e goditi uno stile di vita sano.";
	}

	protected override string _GetTemplateForMessageUnknownErrorTryAgain()
	{
		return "Si è verificato un errore imprevisto. Riprova.";
	}

	protected override string _GetTemplateForMessageUsernameAndPasswordRequired()
	{
		return "Nome utente e password necessari";
	}

	protected override string _GetTemplateForResponseAccountIssueErrorContactSupport()
	{
		return "Problema con l'account. Contatta l'assistenza.";
	}

	protected override string _GetTemplateForResponseAccountLockedRequestReset()
	{
		return "L'account è stato bloccato. Richiedi di reimpostare la password.";
	}

	protected override string _GetTemplateForResponseAccountNotFound()
	{
		return "Account non trovato. Riprova.";
	}

	protected override string _GetTemplateForResponseEmailLinkedToMultipleAccountsLoginWithUsername()
	{
		return "Il tuo indirizzo e-mail è associato a più di un nome utente. Accedi con il tuo nome utente.";
	}

	protected override string _GetTemplateForResponseEmailSent()
	{
		return "E-mail inviata!";
	}

	protected override string _GetTemplateForResponseIncorrectEmailOrPassword()
	{
		return "E-mail o password non valide.";
	}

	protected override string _GetTemplateForResponseIncorrectPhoneOrPassword()
	{
		return "Numero di telefono o password non validi.";
	}

	protected override string _GetTemplateForResponseIncorrectUsernamePassword()
	{
		return "Nome utente o password incorretti.";
	}

	protected override string _GetTemplateForResponseLoginWithUsername()
	{
		return "Qualcosa è andato storto. Accedi con il tuo nome utente.";
	}

	protected override string _GetTemplateForResponsePasswordNotProvided()
	{
		return "Devi inserire una password.";
	}

	protected override string _GetTemplateForResponseTooManyAttemptsPleaseWait()
	{
		return "Troppi tentativi. Riprova più tardi.";
	}

	protected override string _GetTemplateForResponseUnknownError()
	{
		return "Errore imprevisto";
	}

	protected override string _GetTemplateForResponseUnknownLoginError()
	{
		return "Accesso non riuscito.";
	}

	protected override string _GetTemplateForResponseUnverifiedEmailLoginWithUsername()
	{
		return "Il tuo indirizzo e-mail non è stato verificato. Accedi con il tuo nome utente.";
	}

	protected override string _GetTemplateForResponseUnverifiedPhoneLoginWithUsername()
	{
		return "Il tuo numero di telefono non è stato verificato. Accedi con il tuo nome utente.";
	}

	protected override string _GetTemplateForResponseUsernameNotProvided()
	{
		return "Devi inserire un nome utente.";
	}

	protected override string _GetTemplateForResponseUseSocialSignOn()
	{
		return "Impossibile effettuare l'accesso. Prova l'accesso da un social network.";
	}

	/// <summary>
	/// Key: "Response.WeChatNotRealNameVerified"
	/// English String: "Your WeChat is not real-name verified. Please use a real-name verified WeChat account and try again. Please visit {url}"
	/// </summary>
	public override string ResponseWeChatNotRealNameVerified(string url)
	{
		return $"L'identità associata al tuo account WeChat non è stata verificata. Riprova utilizzando un account WeChat verificato. Vai su {url}";
	}

	protected override string _GetTemplateForResponseWeChatNotRealNameVerified()
	{
		return "L'identità associata al tuo account WeChat non è stata verificata. Riprova utilizzando un account WeChat verificato. Vai su {url}";
	}

	protected override string _GetTemplateForWeChatAntiAddictionText()
	{
		return "Boicotta i giochi scadenti, rifiuta i giochi pirata. Difenditi e stai attento a non farti ingannare. I videogiochi sono un ottimo esercizio per la mente, ma esagerando diventano dannosi per la salute. Gestisci bene il tuo tempo e goditi uno stile di vita sano.";
	}

	protected override string _GetTemplateForWeChatRealNameNotVerified()
	{
		return "L'identità associata al tuo account WeChat non è stata verificata. Riprova utilizzando un account WeChat verificato. Vai su https://jiazhang.qq.com/zk/home.html";
	}
}
