namespace Roblox.TranslationResources.Authentication;

/// <summary>
/// This class overrides LoginResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class LoginResources_de_de : LoginResources_en_us, ILoginResources, ITranslationResources
{
	/// <summary>
	/// Key: "Action.Cancel"
	/// Cancel button text
	/// English String: "Cancel"
	/// </summary>
	public override string ActionCancel => "Abbrechen";

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
	public override string ActionForgotPasswordOrUsernameQuestion => "Passwort oder Benutzername vergessen?";

	/// <summary>
	/// Key: "Action.ForgotPasswordOrUsernameQuestionCapitalized"
	/// link under login form
	/// English String: "Forgot Password or Username?"
	/// </summary>
	public override string ActionForgotPasswordOrUsernameQuestionCapitalized => "Passwort oder Benutzername vergessen?";

	/// <summary>
	/// Key: "Action.Login"
	/// English String: "Login"
	/// </summary>
	public override string ActionLogin => "Anmelden";

	/// <summary>
	/// Key: "Action.LogInCapitalized"
	/// login button label. please note this is different from 'Login' or 'Log in'.
	/// English String: "Log In"
	/// </summary>
	public override string ActionLogInCapitalized => "Anmelden";

	/// <summary>
	/// Key: "Action.Ok"
	/// button text
	/// English String: "OK"
	/// </summary>
	public override string ActionOk => "Okay";

	/// <summary>
	/// Key: "Action.PlayAsGuest"
	/// Play as Guest
	/// English String: "Play as Guest"
	/// </summary>
	public override string ActionPlayAsGuest => "Als Gast spielen";

	/// <summary>
	/// Key: "Action.Resend"
	/// button text for resending verification email
	/// English String: "Resend"
	/// </summary>
	public override string ActionResend => "Erneut senden";

	/// <summary>
	/// Key: "Action.ResendEmail"
	/// link that resends verification email to user
	/// English String: "Resend Email"
	/// </summary>
	public override string ActionResendEmail => "E-Mail erneut senden";

	/// <summary>
	/// Key: "Action.SendVerificationEmail"
	/// button user can click to send a verification link to their email
	/// English String: "Send Verification Email"
	/// </summary>
	public override string ActionSendVerificationEmail => "E-Mail zur Verifizierung senden";

	/// <summary>
	/// Key: "Action.SignIn"
	/// Sign In button text
	/// English String: "Sign In"
	/// </summary>
	public override string ActionSignIn => "Anmelden";

	/// <summary>
	/// Key: "Action.SignInWithFacebook"
	/// Sign In with Facebook
	/// English String: "Sign In with Facebook"
	/// </summary>
	public override string ActionSignInWithFacebook => "Mit Facebook anmelden";

	/// <summary>
	/// Key: "Action.SignUp"
	/// English String: "Sign up"
	/// </summary>
	public override string ActionSignUp => "Registrieren";

	/// <summary>
	/// Key: "Action.SignUpCapitalized"
	/// link which takes user to sign up page
	/// English String: "Sign Up"
	/// </summary>
	public override string ActionSignUpCapitalized => "Registrieren";

	/// <summary>
	/// Key: "Action.WeChatLogin"
	/// button text for logging in with WeChat
	/// English String: "WeChat Login"
	/// </summary>
	public override string ActionWeChatLogin => "WeChat-Anmeldung";

	/// <summary>
	/// Key: "Heading.Login"
	/// heading on the login page
	/// English String: "Login"
	/// </summary>
	public override string HeadingLogin => "Anmelden";

	/// <summary>
	/// Key: "Heading.LoginRoblox"
	/// current login page heading
	/// English String: "Login to Roblox"
	/// </summary>
	public override string HeadingLoginRoblox => "Bei Roblox anmelden";

	public override string HeadingSignUpMakeFriends => "Registriere dich, um zu bauen und Freunde zu finden";

	/// <summary>
	/// Key: "Label.AccountNotNeeded"
	/// You don't need an account to play Roblox
	/// English String: "You don't need an account to play Roblox"
	/// </summary>
	public override string LabelAccountNotNeeded => "Du benötigst kein Konto, um Roblox zu spielen.";

	/// <summary>
	/// Key: "Label.EmailNeedsVerification"
	/// modal header used for prompting user they need to verify their email in order to log in with it
	/// English String: "Your email needs verification"
	/// </summary>
	public override string LabelEmailNeedsVerification => "Deine E-Mail-Adresse muss verifiziert werden.";

	/// <summary>
	/// Key: "Label.FacebookCreatePasswordWarning"
	/// If you have been signing in with Facebook, you must set a password.
	/// English String: "If you have been signing in with Facebook, you must set a password."
	/// </summary>
	public override string LabelFacebookCreatePasswordWarning => "Solltest du dich bisher mit Facebook angemeldet haben, musst du ein Passwort erstellen.";

	/// <summary>
	/// Key: "Label.ForgotUsernamePassword"
	/// landing page top right link for password reset
	/// English String: "Forgot Username/Password?"
	/// </summary>
	public override string LabelForgotUsernamePassword => "Benutzername/Passwort vergessen?";

	/// <summary>
	/// Key: "Label.LearnMore"
	/// learn more link text
	/// English String: "Learn more"
	/// </summary>
	public override string LabelLearnMore => "Mehr erfahren";

	/// <summary>
	/// Key: "Label.LoggingInSpinnerText"
	/// English String: "Logging in…"
	/// </summary>
	public override string LabelLoggingInSpinnerText => "Anmelden\u00a0...";

	/// <summary>
	/// Key: "Label.Login"
	/// English String: "Log in"
	/// </summary>
	public override string LabelLogin => "Anmelden";

	/// <summary>
	/// Key: "Label.LoginWithYour"
	/// Label for a partition line between login with email and facebook login. Please keep the text in lowercase for roman characters.
	/// English String: "login with your"
	/// </summary>
	public override string LabelLoginWithYour => "melde dich mit deinem";

	/// <summary>
	/// Key: "Label.NoAccount"
	/// Don't have an account?
	/// English String: "Don't have an account?"
	/// </summary>
	public override string LabelNoAccount => "Du hast kein Konto?";

	/// <summary>
	/// Key: "Label.NonAMemberQuestion"
	/// The question heading for the section on the login page to take use to sign up page.
	/// English String: "Not a member?"
	/// </summary>
	public override string LabelNonAMemberQuestion => "Kein Mitglied?";

	/// <summary>
	/// Key: "Label.NotReceived"
	/// prompt for allowing users to resend verification email
	/// English String: "Didn't receive it?"
	/// </summary>
	public override string LabelNotReceived => "Nicht erhalten?";

	/// <summary>
	/// Key: "Label.Or"
	/// partition between email login and facebook login
	/// English String: "Or"
	/// </summary>
	public override string LabelOr => "Oder";

	/// <summary>
	/// Key: "Label.Password"
	/// Password
	/// English String: "Password"
	/// </summary>
	public override string LabelPassword => "Passwort";

	/// <summary>
	/// Key: "Label.PasswordWithColumn"
	/// label for the password field on the login page
	/// English String: "Password:"
	/// </summary>
	public override string LabelPasswordWithColumn => "Passwort:";

	/// <summary>
	/// Key: "Label.StartPlaying"
	/// You can start playing right now, in guest mode!
	/// English String: "You can start playing right now, in guest mode!"
	/// </summary>
	public override string LabelStartPlaying => "Du kannst jetzt sofort im Gastmodus spielen!";

	/// <summary>
	/// Key: "Label.UnverifiedEmailInstructions"
	/// message shown in a modal when user logs in with unverified email
	/// English String: "To log in with your email, it must be verified. You can also log in with your username."
	/// </summary>
	public override string LabelUnverifiedEmailInstructions => "Um dich mit deiner E-Mail-Adresse anmelden zu können, musst du sie zuerst verifizieren. Du kannst dich auch mit deinem Benutzernamen anmelden.";

	/// <summary>
	/// Key: "Label.Username"
	/// English String: "Username"
	/// </summary>
	public override string LabelUsername => "Benutzername";

	/// <summary>
	/// Key: "Label.UsernameEmail"
	/// placeholder text for input field that accepts username or email
	/// English String: "Username/Email"
	/// </summary>
	public override string LabelUsernameEmail => "Benutzername/E-Mail-Adresse";

	/// <summary>
	/// Key: "Label.UsernameEmailPhone"
	/// placeholder text for input fields that accept username, email or phone
	/// English String: "Username/Email/Phone"
	/// </summary>
	public override string LabelUsernameEmailPhone => "Benutzer/E-Mail/Telefon";

	/// <summary>
	/// Key: "Label.UsernamePhone"
	/// placeholder text for input field that accepts username or phone
	/// English String: "Username/Phone"
	/// </summary>
	public override string LabelUsernamePhone => "Benutzername/Telefonnummer";

	/// <summary>
	/// Key: "Label.UsernameWithColumn"
	/// label for username field on login page
	/// English String: "Username:"
	/// </summary>
	public override string LabelUsernameWithColumn => "Benutzername:";

	/// <summary>
	/// Key: "Label.VerificationEmailSent"
	/// message telling user a verification email was sent to them
	/// English String: "Verification Email Sent!"
	/// </summary>
	public override string LabelVerificationEmailSent => "E-Mail zur Verifizierung gesendet!";

	/// <summary>
	/// Key: "Label.WeChatAntiAddictionText"
	/// English String: "Boycott bad games, refuse pirated games. Be aware of self-defense and being deceived. Playing games is good for your brain, but too much game play can harm your health. Manage your time well and enjoy a healthy lifestyle."
	/// </summary>
	public override string LabelWeChatAntiAddictionText => "Boykottiere schlechte Spiele und lehne Raubkopien ab. Sei dir über Selbstverteidigung und Täuschungsversuche im Klaren. Spielen ist gut für dein Gehirn, aber zu viel des Guten kann deine Gesundheit beeinträchtigen. Teile dir deine Zeit gut ein und führe einen gesunden Lebensstil.";

	/// <summary>
	/// Key: "Message.UnknownErrorTryAgain"
	/// An unknown error occurred. Please try again.
	/// English String: "An unknown error occurred. Please try again."
	/// </summary>
	public override string MessageUnknownErrorTryAgain => "Ein unbekannter Fehler ist aufgetreten. Bitte versuche es erneut.";

	/// <summary>
	/// Key: "Message.UsernameAndPasswordRequired"
	/// message shown to user when they attempt to login without entering a username or password
	/// English String: "Username and password required"
	/// </summary>
	public override string MessageUsernameAndPasswordRequired => "Benutzername und Passwort sind erforderlich.";

	/// <summary>
	/// Key: "Response.AccountIssueErrorContactSupport"
	/// English String: "Account issue. Please contact Support."
	/// </summary>
	public override string ResponseAccountIssueErrorContactSupport => "Problem mit dem Konto. Bitte kontaktiere den Support.";

	/// <summary>
	/// Key: "Response.AccountLockedRequestReset"
	/// Account has been locked. Please request a password reset.
	/// English String: "Account has been locked. Please request a password reset."
	/// </summary>
	public override string ResponseAccountLockedRequestReset => "Konto wurde gesperrt. Bitte stelle eine Anfrage zum Zurücksetzen deines Passworts.";

	/// <summary>
	/// Key: "Response.AccountNotFound"
	/// Account not found. Please try again.
	/// English String: "Account not found. Please try again."
	/// </summary>
	public override string ResponseAccountNotFound => "Konto nicht gefunden. Bitte versuche es erneut.";

	/// <summary>
	/// Key: "Response.EmailLinkedToMultipleAccountsLoginWithUsername"
	/// error message displayed when user attempts to log in with an email that is linked to multiple accounts
	/// English String: "Your email is associated with more than 1 username. Please login with your username."
	/// </summary>
	public override string ResponseEmailLinkedToMultipleAccountsLoginWithUsername => "Deine E-Mail-Adresse ist mehr als 1 Benutzernamen zugeordnet. Melde dich bitte mit deinem Benutzernamen an.";

	/// <summary>
	/// Key: "Response.EmailSent"
	/// response telling user that a verification email has been sent to them
	/// English String: "Email sent!"
	/// </summary>
	public override string ResponseEmailSent => "E-Mail gesendet!";

	/// <summary>
	/// Key: "Response.IncorrectEmailOrPassword"
	/// error message displayed when user logs in with an invalid email or password
	/// English String: "Incorrect email or password."
	/// </summary>
	public override string ResponseIncorrectEmailOrPassword => "E-Mail-Adresse oder Passwort falsch.";

	/// <summary>
	/// Key: "Response.IncorrectPhoneOrPassword"
	/// error message displayed when user logs in with an invalid phone or password
	/// English String: "Incorrect phone or password."
	/// </summary>
	public override string ResponseIncorrectPhoneOrPassword => "Telefonnummer oder Passwort falsch.";

	/// <summary>
	/// Key: "Response.IncorrectUsernamePassword"
	/// English String: "Incorrect username or password."
	/// </summary>
	public override string ResponseIncorrectUsernamePassword => "Falscher Benutzername oder falsches Passwort.";

	/// <summary>
	/// Key: "Response.LoginWithUsername"
	/// error message shown when user attempts to login with method other than username and an error occurred
	/// English String: "Something went wrong. Please login with your username."
	/// </summary>
	public override string ResponseLoginWithUsername => "Etwas hat nicht funktioniert. Melde dich bitte mit deinem Benutzernamen an.";

	/// <summary>
	/// Key: "Response.PasswordNotProvided"
	/// password field is empty
	/// English String: "You must enter a password."
	/// </summary>
	public override string ResponsePasswordNotProvided => "Du musst ein Passwort eingeben.";

	/// <summary>
	/// Key: "Response.TooManyAttemptsPleaseWait"
	/// English String: "Too many attempts. Please wait a bit."
	/// </summary>
	public override string ResponseTooManyAttemptsPleaseWait => "Zu viele Versuche. Bitte warte einen Moment.";

	/// <summary>
	/// Key: "Response.UnknownError"
	/// English String: "Unknown Error"
	/// </summary>
	public override string ResponseUnknownError => "Unbekannter Fehler";

	/// <summary>
	/// Key: "Response.UnknownLoginError"
	/// Unknown login failure.
	/// English String: "Unknown login failure."
	/// </summary>
	public override string ResponseUnknownLoginError => "Unbekannter Fehler bei der Anmeldung.";

	/// <summary>
	/// Key: "Response.UnverifiedEmailLoginWithUsername"
	/// error message shown when user attempts to login with unverified email
	/// English String: "Your email is not verified. Please login with your username."
	/// </summary>
	public override string ResponseUnverifiedEmailLoginWithUsername => "Deine E-Mail-Adresse ist nicht verifiziert. Melde dich bitte mit deinem Benutzernamen an.";

	/// <summary>
	/// Key: "Response.UnverifiedPhoneLoginWithUsername"
	/// error message shown when user attempts to login with an unverified phone number
	/// English String: "Your phone is not verified. Please login with your username."
	/// </summary>
	public override string ResponseUnverifiedPhoneLoginWithUsername => "Deine Telefonnummer ist nicht verifiziert. Melde dich bitte mit deinem Benutzernamen an.";

	/// <summary>
	/// Key: "Response.UsernameNotProvided"
	/// username field is empty
	/// English String: "You must enter a username."
	/// </summary>
	public override string ResponseUsernameNotProvided => "Du musst einen Benutzernamen eingeben.";

	/// <summary>
	/// Key: "Response.UseSocialSignOn"
	/// Unable to login. Please use Social Network sign on.
	/// English String: "Unable to login. Please use Social Network sign on."
	/// </summary>
	public override string ResponseUseSocialSignOn => "Anmeldung gescheitert. Bitte melde dich über ein soziales Netzwerk an.";

	/// <summary>
	/// Key: "WeChat.AntiAddictionText"
	/// English String: "Boycott bad games, refuse pirated games. Be aware of self-defense and being deceived. Playing games is good for your brain, but too much game play can harm your health. Manage your time well and enjoy a healthy lifestyle."
	/// </summary>
	public override string WeChatAntiAddictionText => "Boykottiere schlechte Spiele und lehne Raubkopien ab. Sei dir über Selbstverteidigung und Täuschungsversuche im Klaren. Spielen ist gut für dein Gehirn, aber zu viel des Guten kann deine Gesundheit beeinträchtigen. Teile dir deine Zeit gut ein und führe einen gesunden Lebensstil.";

	/// <summary>
	/// Key: "WeChat.RealNameNotVerified"
	/// English String: "Your WeChat is not real-name verified. Please use a real-name verified WeChat account and try again. Please visit https://jiazhang.qq.com/zk/home.html"
	/// </summary>
	public override string WeChatRealNameNotVerified => "Dein WeChat-Konto ist nicht verifiziert. Bitte verwende ein verifiziertes WeChat-Konto und versuch es erneut. Besuche https://jiazhang.qq.com/zk/home.html";

	public LoginResources_de_de(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionCancel()
	{
		return "Abbrechen";
	}

	protected override string _GetTemplateForActionFacebook()
	{
		return "Facebook";
	}

	protected override string _GetTemplateForActionForgotPasswordOrUsernameQuestion()
	{
		return "Passwort oder Benutzername vergessen?";
	}

	protected override string _GetTemplateForActionForgotPasswordOrUsernameQuestionCapitalized()
	{
		return "Passwort oder Benutzername vergessen?";
	}

	protected override string _GetTemplateForActionLogin()
	{
		return "Anmelden";
	}

	protected override string _GetTemplateForActionLogInCapitalized()
	{
		return "Anmelden";
	}

	protected override string _GetTemplateForActionOk()
	{
		return "Okay";
	}

	protected override string _GetTemplateForActionPlayAsGuest()
	{
		return "Als Gast spielen";
	}

	protected override string _GetTemplateForActionResend()
	{
		return "Erneut senden";
	}

	protected override string _GetTemplateForActionResendEmail()
	{
		return "E-Mail erneut senden";
	}

	protected override string _GetTemplateForActionSendVerificationEmail()
	{
		return "E-Mail zur Verifizierung senden";
	}

	protected override string _GetTemplateForActionSignIn()
	{
		return "Anmelden";
	}

	protected override string _GetTemplateForActionSignInWithFacebook()
	{
		return "Mit Facebook anmelden";
	}

	protected override string _GetTemplateForActionSignUp()
	{
		return "Registrieren";
	}

	protected override string _GetTemplateForActionSignUpCapitalized()
	{
		return "Registrieren";
	}

	protected override string _GetTemplateForActionWeChatLogin()
	{
		return "WeChat-Anmeldung";
	}

	protected override string _GetTemplateForHeadingLogin()
	{
		return "Anmelden";
	}

	protected override string _GetTemplateForHeadingLoginRoblox()
	{
		return "Bei Roblox anmelden";
	}

	protected override string _GetTemplateForHeadingSignUpMakeFriends()
	{
		return "Registriere dich, um zu bauen und Freunde zu finden";
	}

	protected override string _GetTemplateForLabelAccountNotNeeded()
	{
		return "Du benötigst kein Konto, um Roblox zu spielen.";
	}

	protected override string _GetTemplateForLabelEmailNeedsVerification()
	{
		return "Deine E-Mail-Adresse muss verifiziert werden.";
	}

	protected override string _GetTemplateForLabelFacebookCreatePasswordWarning()
	{
		return "Solltest du dich bisher mit Facebook angemeldet haben, musst du ein Passwort erstellen.";
	}

	protected override string _GetTemplateForLabelForgotUsernamePassword()
	{
		return "Benutzername/Passwort vergessen?";
	}

	/// <summary>
	/// Key: "Label.GreetingForNewAccount"
	/// Shown when a username doesn't exist on the login page to invite to create a new account.
	/// English String: "Nice to meet you, {username}. {linkStartSignup}Let's make an account! {linkEndSignup}"
	/// </summary>
	public override string LabelGreetingForNewAccount(string username, string linkStartSignup, string linkEndSignup)
	{
		return $"Hallo, {username}. {linkStartSignup}Lass uns ein Konto erstellen! {linkEndSignup}";
	}

	protected override string _GetTemplateForLabelGreetingForNewAccount()
	{
		return "Hallo, {username}. {linkStartSignup}Lass uns ein Konto erstellen! {linkEndSignup}";
	}

	protected override string _GetTemplateForLabelLearnMore()
	{
		return "Mehr erfahren";
	}

	protected override string _GetTemplateForLabelLoggingInSpinnerText()
	{
		return "Anmelden\u00a0...";
	}

	protected override string _GetTemplateForLabelLogin()
	{
		return "Anmelden";
	}

	protected override string _GetTemplateForLabelLoginWithYour()
	{
		return "melde dich mit deinem";
	}

	protected override string _GetTemplateForLabelNoAccount()
	{
		return "Du hast kein Konto?";
	}

	protected override string _GetTemplateForLabelNonAMemberQuestion()
	{
		return "Kein Mitglied?";
	}

	protected override string _GetTemplateForLabelNotReceived()
	{
		return "Nicht erhalten?";
	}

	protected override string _GetTemplateForLabelOr()
	{
		return "Oder";
	}

	protected override string _GetTemplateForLabelPassword()
	{
		return "Passwort";
	}

	protected override string _GetTemplateForLabelPasswordWithColumn()
	{
		return "Passwort:";
	}

	protected override string _GetTemplateForLabelStartPlaying()
	{
		return "Du kannst jetzt sofort im Gastmodus spielen!";
	}

	protected override string _GetTemplateForLabelUnverifiedEmailInstructions()
	{
		return "Um dich mit deiner E-Mail-Adresse anmelden zu können, musst du sie zuerst verifizieren. Du kannst dich auch mit deinem Benutzernamen anmelden.";
	}

	protected override string _GetTemplateForLabelUsername()
	{
		return "Benutzername";
	}

	protected override string _GetTemplateForLabelUsernameEmail()
	{
		return "Benutzername/E-Mail-Adresse";
	}

	protected override string _GetTemplateForLabelUsernameEmailPhone()
	{
		return "Benutzer/E-Mail/Telefon";
	}

	protected override string _GetTemplateForLabelUsernamePhone()
	{
		return "Benutzername/Telefonnummer";
	}

	protected override string _GetTemplateForLabelUsernameWithColumn()
	{
		return "Benutzername:";
	}

	protected override string _GetTemplateForLabelVerificationEmailSent()
	{
		return "E-Mail zur Verifizierung gesendet!";
	}

	protected override string _GetTemplateForLabelWeChatAntiAddictionText()
	{
		return "Boykottiere schlechte Spiele und lehne Raubkopien ab. Sei dir über Selbstverteidigung und Täuschungsversuche im Klaren. Spielen ist gut für dein Gehirn, aber zu viel des Guten kann deine Gesundheit beeinträchtigen. Teile dir deine Zeit gut ein und führe einen gesunden Lebensstil.";
	}

	protected override string _GetTemplateForMessageUnknownErrorTryAgain()
	{
		return "Ein unbekannter Fehler ist aufgetreten. Bitte versuche es erneut.";
	}

	protected override string _GetTemplateForMessageUsernameAndPasswordRequired()
	{
		return "Benutzername und Passwort sind erforderlich.";
	}

	protected override string _GetTemplateForResponseAccountIssueErrorContactSupport()
	{
		return "Problem mit dem Konto. Bitte kontaktiere den Support.";
	}

	protected override string _GetTemplateForResponseAccountLockedRequestReset()
	{
		return "Konto wurde gesperrt. Bitte stelle eine Anfrage zum Zurücksetzen deines Passworts.";
	}

	protected override string _GetTemplateForResponseAccountNotFound()
	{
		return "Konto nicht gefunden. Bitte versuche es erneut.";
	}

	protected override string _GetTemplateForResponseEmailLinkedToMultipleAccountsLoginWithUsername()
	{
		return "Deine E-Mail-Adresse ist mehr als 1 Benutzernamen zugeordnet. Melde dich bitte mit deinem Benutzernamen an.";
	}

	protected override string _GetTemplateForResponseEmailSent()
	{
		return "E-Mail gesendet!";
	}

	protected override string _GetTemplateForResponseIncorrectEmailOrPassword()
	{
		return "E-Mail-Adresse oder Passwort falsch.";
	}

	protected override string _GetTemplateForResponseIncorrectPhoneOrPassword()
	{
		return "Telefonnummer oder Passwort falsch.";
	}

	protected override string _GetTemplateForResponseIncorrectUsernamePassword()
	{
		return "Falscher Benutzername oder falsches Passwort.";
	}

	protected override string _GetTemplateForResponseLoginWithUsername()
	{
		return "Etwas hat nicht funktioniert. Melde dich bitte mit deinem Benutzernamen an.";
	}

	protected override string _GetTemplateForResponsePasswordNotProvided()
	{
		return "Du musst ein Passwort eingeben.";
	}

	protected override string _GetTemplateForResponseTooManyAttemptsPleaseWait()
	{
		return "Zu viele Versuche. Bitte warte einen Moment.";
	}

	protected override string _GetTemplateForResponseUnknownError()
	{
		return "Unbekannter Fehler";
	}

	protected override string _GetTemplateForResponseUnknownLoginError()
	{
		return "Unbekannter Fehler bei der Anmeldung.";
	}

	protected override string _GetTemplateForResponseUnverifiedEmailLoginWithUsername()
	{
		return "Deine E-Mail-Adresse ist nicht verifiziert. Melde dich bitte mit deinem Benutzernamen an.";
	}

	protected override string _GetTemplateForResponseUnverifiedPhoneLoginWithUsername()
	{
		return "Deine Telefonnummer ist nicht verifiziert. Melde dich bitte mit deinem Benutzernamen an.";
	}

	protected override string _GetTemplateForResponseUsernameNotProvided()
	{
		return "Du musst einen Benutzernamen eingeben.";
	}

	protected override string _GetTemplateForResponseUseSocialSignOn()
	{
		return "Anmeldung gescheitert. Bitte melde dich über ein soziales Netzwerk an.";
	}

	/// <summary>
	/// Key: "Response.WeChatNotRealNameVerified"
	/// English String: "Your WeChat is not real-name verified. Please use a real-name verified WeChat account and try again. Please visit {url}"
	/// </summary>
	public override string ResponseWeChatNotRealNameVerified(string url)
	{
		return $"Dein WeChat-Konto ist nicht verifiziert. Bitte verwende ein verifiziertes WeChat-Konto und versuch es erneut. Besuche {url}";
	}

	protected override string _GetTemplateForResponseWeChatNotRealNameVerified()
	{
		return "Dein WeChat-Konto ist nicht verifiziert. Bitte verwende ein verifiziertes WeChat-Konto und versuch es erneut. Besuche {url}";
	}

	protected override string _GetTemplateForWeChatAntiAddictionText()
	{
		return "Boykottiere schlechte Spiele und lehne Raubkopien ab. Sei dir über Selbstverteidigung und Täuschungsversuche im Klaren. Spielen ist gut für dein Gehirn, aber zu viel des Guten kann deine Gesundheit beeinträchtigen. Teile dir deine Zeit gut ein und führe einen gesunden Lebensstil.";
	}

	protected override string _GetTemplateForWeChatRealNameNotVerified()
	{
		return "Dein WeChat-Konto ist nicht verifiziert. Bitte verwende ein verifiziertes WeChat-Konto und versuch es erneut. Besuche https://jiazhang.qq.com/zk/home.html";
	}
}
