namespace Roblox.TranslationResources.Authentication;

/// <summary>
/// This class overrides SignUpResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class SignUpResources_de_de : SignUpResources_en_us, ISignUpResources, ITranslationResources
{
	/// <summary>
	/// Key: "Action.CreateAccount"
	/// create account button label
	/// English String: "Create Account"
	/// </summary>
	public override string ActionCreateAccount => "Konto erstellen";

	/// <summary>
	/// Key: "Action.LinkAccount"
	/// Button text to link 3rd Party Account to a Roblox Account
	/// English String: "Link Account"
	/// </summary>
	public override string ActionLinkAccount => "Konto verlinken";

	/// <summary>
	/// Key: "Action.LogInCapitalized"
	/// button label for capitalized words for Log In
	/// English String: "Log In"
	/// </summary>
	public override string ActionLogInCapitalized => "Anmelden";

	/// <summary>
	/// Key: "Action.ReturnHome"
	/// button label to return the user to home page
	/// English String: "Return Home"
	/// </summary>
	public override string ActionReturnHome => "Zurück zur Homepage";

	/// <summary>
	/// Key: "Action.SignUp"
	/// English String: "Sign up"
	/// </summary>
	public override string ActionSignUp => "Registrieren";

	public override string ActionSignupAndSync => "Registrieren und synchronisieren";

	/// <summary>
	/// Key: "Action.Submit"
	/// English String: "Submit"
	/// </summary>
	public override string ActionSubmit => "Senden";

	/// <summary>
	/// Key: "Description.AccountLinkingWarning"
	/// instructions for linking account on signup page for FB based account
	/// English String: "To link to an existing Roblox account, sign in and link them on the account settings page."
	/// </summary>
	public override string DescriptionAccountLinkingWarning => "Um eine Verknüpfung zu einem bestehenden Roblox-Konto herzustellen, melde dich an und führe die Verknüpfung auf der Kontoeinstellungsseite durch.";

	/// <summary>
	/// Key: "Description.NoRealName"
	/// description
	/// English String: "Do not use your real name."
	/// </summary>
	public override string DescriptionNoRealName => "Verwende nicht deinen echten Namen.";

	/// <summary>
	/// Key: "Description.PrivacyPolicy"
	/// English String: "Privacy Policy"
	/// </summary>
	public override string DescriptionPrivacyPolicy => "Datenschutzrichtlinien";

	/// <summary>
	/// Key: "Description.TermsOfService"
	/// English String: "Terms of Service"
	/// </summary>
	public override string DescriptionTermsOfService => "Nutzungsbedingungen";

	/// <summary>
	/// Key: "GuestSignUpAB.Action.SignUp"
	/// English String: "Sign Up"
	/// </summary>
	public override string GuestSignUpABActionSignUp => "Registrieren";

	/// <summary>
	/// Key: "Heading.ConnectFacebook"
	/// section heading
	/// English String: "Connect to Facebook"
	/// </summary>
	public override string HeadingConnectFacebook => "Mit Facebook verbinden";

	/// <summary>
	/// Key: "Heading.CreateAnAccount"
	/// should be capitalized if the language supports capitalization
	/// English String: "CREATE AN ACCOUNT"
	/// </summary>
	public override string HeadingCreateAnAccount => "ERSTELLE EIN KONTO";

	/// <summary>
	/// Key: "Heading.LoginHaveFun"
	/// heading for login container
	/// English String: "Log in and start having fun!"
	/// </summary>
	public override string HeadingLoginHaveFun => "Melde dich an und leg los!";

	/// <summary>
	/// Key: "Heading.SignupHaveFun"
	/// signup form heading
	/// English String: "Sign up and start having fun!"
	/// </summary>
	public override string HeadingSignupHaveFun => "Registriere dich und leg los!";

	/// <summary>
	/// Key: "Label.About"
	/// About link on roller coaster page
	/// English String: "About"
	/// </summary>
	public override string LabelAbout => "Info";

	/// <summary>
	/// Key: "Label.AlreadyHaveRobloxAccount"
	/// English String: "Already have a Roblox account?"
	/// </summary>
	public override string LabelAlreadyHaveRobloxAccount => "Hast du schon ein Roblox-Konto?";

	/// <summary>
	/// Key: "Label.AlreadyRegistered"
	/// label
	/// English String: "Already registered?"
	/// </summary>
	public override string LabelAlreadyRegistered => "Bereits registriert?";

	/// <summary>
	/// Key: "Label.Birthday"
	/// English String: "Birthday"
	/// </summary>
	public override string LabelBirthday => "Geburtstag";

	/// <summary>
	/// Key: "Label.BirthdayWithColumn"
	/// should have column if the language supports it
	/// English String: "Birthday:"
	/// </summary>
	public override string LabelBirthdayWithColumn => "Geburtstag:";

	/// <summary>
	/// Key: "Label.ConfirmPassword"
	/// English String: "Confirm password"
	/// </summary>
	public override string LabelConfirmPassword => "Passwort bestätigen";

	/// <summary>
	/// Key: "Label.Day"
	/// English String: "Day"
	/// </summary>
	public override string LabelDay => "Tag";

	/// <summary>
	/// Key: "Label.DesiredUsername"
	/// should have a column if the language supports it
	/// English String: "Desired Username:"
	/// </summary>
	public override string LabelDesiredUsername => "Gewünschter Benutzername:";

	/// <summary>
	/// Key: "Label.FacebookNotLinked"
	/// English String: "Your Facebook account is not linked to any Roblox account. Please sign up for a Roblox account."
	/// </summary>
	public override string LabelFacebookNotLinked => "Dein Facebook-Konto ist mit keinem Roblox-Konto verlinkt. Bitte registriere dich für ein Roblox-Konto.";

	/// <summary>
	/// Key: "Label.FacebookSignupUsername"
	/// username field label for FB signup
	/// English String: "Create Roblox username:"
	/// </summary>
	public override string LabelFacebookSignupUsername => "Roblox-Benutzername erstellen:";

	/// <summary>
	/// Key: "Label.Female"
	/// label
	/// English String: "Female"
	/// </summary>
	public override string LabelFemale => "Weiblich";

	/// <summary>
	/// Key: "Label.Gender"
	/// English String: "Gender"
	/// </summary>
	public override string LabelGender => "Geschlecht";

	/// <summary>
	/// Key: "Label.GenderRequired"
	/// English String: "Gender is required."
	/// </summary>
	public override string LabelGenderRequired => "Du musst dein Geschlecht angeben.";

	/// <summary>
	/// Key: "Label.GenderWithColumn"
	/// should have column if the language supports it
	/// English String: "Gender:"
	/// </summary>
	public override string LabelGenderWithColumn => "Geschlecht:";

	/// <summary>
	/// Key: "Label.Male"
	/// label
	/// English String: "Male"
	/// </summary>
	public override string LabelMale => "Männlich";

	/// <summary>
	/// Key: "Label.Month"
	/// English String: "Month"
	/// </summary>
	public override string LabelMonth => "Monat";

	/// <summary>
	/// Key: "Label.Password"
	/// English String: "Password"
	/// </summary>
	public override string LabelPassword => "Passwort";

	/// <summary>
	/// Key: "Label.PasswordRequirements"
	/// English String: "Password (min length 8)"
	/// </summary>
	public override string LabelPasswordRequirements => "Passwort (mind. 8 Zeichen)";

	/// <summary>
	/// Key: "Label.Platforms"
	/// platforms link on roller coaster page
	/// English String: "Platforms"
	/// </summary>
	public override string LabelPlatforms => "Plattformen";

	/// <summary>
	/// Key: "Label.Play"
	/// Play link on roller coaster page
	/// English String: "Play"
	/// </summary>
	public override string LabelPlay => "Spielen";

	/// <summary>
	/// Key: "Label.PleaseAgreeToTerms"
	/// English String: "Please agree to our Terms of Use and Privacy Policy."
	/// </summary>
	public override string LabelPleaseAgreeToTerms => "Bitte stimme unseren Nutzungsbedingungen und Datenschutzrichtlinien zu.";

	/// <summary>
	/// Key: "Label.Required"
	/// Required
	/// English String: "Required"
	/// </summary>
	public override string LabelRequired => "Erforderlich";

	/// <summary>
	/// Key: "Label.SignupButtonText"
	/// sign up button text
	/// English String: "Sign Up and Play!"
	/// </summary>
	public override string LabelSignupButtonText => "Registrieren und spielen!";

	/// <summary>
	/// Key: "Label.SignUpWith"
	/// This is text that will fit go between two buttons, a regular "sign up button" and a "external provider button" (like facebook).
	///
	/// Visually it looks like
	/// [ Signup Button]
	/// - or sign up with -
	/// [facebook button]
	/// English String: "or sign up with"
	/// </summary>
	public override string LabelSignUpWith => "oder anmelden über";

	/// <summary>
	/// Key: "Label.TermsOfUse"
	/// terms of use link label
	/// English String: "Terms of Use"
	/// </summary>
	public override string LabelTermsOfUse => "Nutzungsbedingungen";

	/// <summary>
	/// Key: "Label.Username"
	/// English String: "Username"
	/// </summary>
	public override string LabelUsername => "Benutzername";

	/// <summary>
	/// Key: "Label.UsernameCharacterLimit"
	/// label
	/// English String: "3-20 alphanumeric characters, no spaces."
	/// </summary>
	public override string LabelUsernameCharacterLimit => "3-20 alphanumerische Zeichen, keine Leerzeichen.";

	/// <summary>
	/// Key: "Label.UsernameHint"
	/// placeholder for username field
	/// English String: "Username (don't use your real name)"
	/// </summary>
	public override string LabelUsernameHint => "Benutzername (ausgedachter Name)";

	/// <summary>
	/// Key: "Label.UsernameRequirements"
	/// English String: "Username (length 3-20, _ is allowed)"
	/// </summary>
	public override string LabelUsernameRequirements => "Benutzername (3-20 Zeichen, _ ist erlaubt)";

	/// <summary>
	/// Key: "Label.Year"
	/// English String: "Year"
	/// </summary>
	public override string LabelYear => "Jahr";

	/// <summary>
	/// Key: "Message.Password.MinLength"
	/// English String: "Min length 8"
	/// </summary>
	public override string MessagePasswordMinLength => "Mind. 8 Zeichen";

	/// <summary>
	/// Key: "Message.Username.NoRealNameUse"
	/// English String: "Don't use your real name"
	/// </summary>
	public override string MessageUsernameNoRealNameUse => "Verwende nicht deinen echten Namen";

	/// <summary>
	/// Key: "Response.BadUsername"
	/// English String: "Username not appropriate for Roblox."
	/// </summary>
	public override string ResponseBadUsername => "Der Benutzername ist nicht geeignet für Roblox.";

	/// <summary>
	/// Key: "Response.BadUsernameForWeChat"
	/// message shown when signing up with an inappropriate username
	/// English String: "Username is not appropriate"
	/// </summary>
	public override string ResponseBadUsernameForWeChat => "Benutzername ist nicht zugelassen";

	/// <summary>
	/// Key: "Response.BirthdayInvalid"
	/// English String: "This birthday is invalid."
	/// </summary>
	public override string ResponseBirthdayInvalid => "Dieser Geburtstag ist ungültig.";

	/// <summary>
	/// Key: "Response.BirthdayMustBeSetFirst"
	/// English String: "Birthday must be set first."
	/// </summary>
	public override string ResponseBirthdayMustBeSetFirst => "Der Geburtstag muss zuerst festgelegt werden.";

	/// <summary>
	/// Key: "Response.CaptchaMismatchError"
	/// error message
	/// English String: "Words do not match."
	/// </summary>
	public override string ResponseCaptchaMismatchError => "Die Wörter stimmen nicht überein.";

	/// <summary>
	/// Key: "Response.CaptchaNotEnteredError"
	/// validation error message
	/// English String: "Please fill out the Captcha"
	/// </summary>
	public override string ResponseCaptchaNotEnteredError => "Bitte gib das Captcha ein.";

	/// <summary>
	/// Key: "Response.FacebookConnectionError"
	/// error message
	/// English String: "Error while retrieving values from Facebook."
	/// </summary>
	public override string ResponseFacebookConnectionError => "Beim Abrufen der Daten von Facebook ist ein Fehler aufgetreten.";

	/// <summary>
	/// Key: "Response.FacebookLoginAge"
	/// English String: "Facebook login can only be used by users above 13."
	/// </summary>
	public override string ResponseFacebookLoginAge => "Die Anmeldung mit Facebook ist nur für Benutzer über 13 Jahre möglich.";

	/// <summary>
	/// Key: "Response.InvalidBirthday"
	/// English String: "Invalid birthday."
	/// </summary>
	public override string ResponseInvalidBirthday => "Ungültiger Geburtstag";

	/// <summary>
	/// Key: "Response.InvalidEmail"
	/// English String: "Invalid email address."
	/// </summary>
	public override string ResponseInvalidEmail => "Ungültige E-Mail-Adresse";

	/// <summary>
	/// Key: "Response.JavaScriptRequired"
	/// error to show that JavaScipt is required for the form to work
	/// English String: "JavaScript is required to submit this form."
	/// </summary>
	public override string ResponseJavaScriptRequired => "Zum Senden dieses Formulars wird JavaScript benötigt.";

	/// <summary>
	/// Key: "Response.PasswordComplexity"
	/// English String: "Please create a more complex password."
	/// </summary>
	public override string ResponsePasswordComplexity => "Bitte überlege dir ein schwierigeres Passwort.";

	/// <summary>
	/// Key: "Response.PasswordConfirmation"
	/// validation message for password confirmation
	/// English String: "Please enter a password confirmation."
	/// </summary>
	public override string ResponsePasswordConfirmation => "Bitte gib eine Passwortbestätigung ein.";

	/// <summary>
	/// Key: "Response.PasswordContainsUsernameError"
	/// error when passsword has username in it
	/// English String: "Password shouldn't match username."
	/// </summary>
	public override string ResponsePasswordContainsUsernameError => "Passwort und Benutzername dürfen nicht identisch sein.";

	/// <summary>
	/// Key: "Response.PasswordMismatch"
	/// English String: "Passwords do not match."
	/// </summary>
	public override string ResponsePasswordMismatch => "Passwörter stimmen nicht überein.";

	/// <summary>
	/// Key: "Response.PasswordWrongShort"
	/// English String: "Passwords must be at least 8 characters long."
	/// </summary>
	public override string ResponsePasswordWrongShort => "Passwörter müssen mindestens 8 Zeichen lang sein.";

	/// <summary>
	/// Key: "Response.PleaseEnterPassword"
	/// English String: "Please enter a password."
	/// </summary>
	public override string ResponsePleaseEnterPassword => "Bitte gib ein Passwort ein.";

	/// <summary>
	/// Key: "Response.PleaseEnterUsername"
	/// English String: "Please enter a username."
	/// </summary>
	public override string ResponsePleaseEnterUsername => "Bitte gib einen Benutzernamen ein.";

	/// <summary>
	/// Key: "Response.SocialAccountCreationFailed"
	/// error message
	/// English String: "Account creation failed"
	/// </summary>
	public override string ResponseSocialAccountCreationFailed => "Erstellung des Kontos fehlgeschlagen";

	/// <summary>
	/// Key: "Response.SpaceOrSpecialCharaterError"
	/// Spaces and special characters are not allowed error message
	/// English String: "Spaces and special characters are not allowed."
	/// </summary>
	public override string ResponseSpaceOrSpecialCharaterError => "Leerzeichen und Sonderzeichen sind nicht gestattet.";

	/// <summary>
	/// Key: "Response.TooManyAccountsWithSameEmailError"
	/// Too many accounts use this email error message
	/// English String: "Too many accounts use this email."
	/// </summary>
	public override string ResponseTooManyAccountsWithSameEmailError => "Zu viele Konten verwenden diese E-Mail-Adresse.";

	/// <summary>
	/// Key: "Response.UnknownError"
	/// English String: "Sorry! An unknown error occurred. Please try again later."
	/// </summary>
	public override string ResponseUnknownError => "Tut uns leid! Ein unbekannter Fehler ist aufgetreten. Bitte versuche es später erneut.";

	/// <summary>
	/// Key: "Response.UsernameAllowedCharactersError"
	/// error showing which characters are allowed for username
	/// English String: "Usernames may only contain letters, numbers, and _."
	/// </summary>
	public override string ResponseUsernameAllowedCharactersError => "Benutzernamen dürfen nur Buchstaben, Ziffern und _ enthalten.";

	/// <summary>
	/// Key: "Response.UsernameAlreadyInUse"
	/// English String: "This username is already in use."
	/// </summary>
	public override string ResponseUsernameAlreadyInUse => "Dieser Benutzername wird bereits verwendet.";

	/// <summary>
	/// Key: "Response.UsernameExplicit"
	/// English String: "This username is not allowed, please try another."
	/// </summary>
	public override string ResponseUsernameExplicit => "Dieser Benutzername ist nicht erlaubt. Bitte versuche es mit einem anderen.";

	/// <summary>
	/// Key: "Response.UsernameInvalid"
	/// English String: "Please enter a valid username."
	/// </summary>
	public override string ResponseUsernameInvalid => "Bitte gib einen gültigen Benutzernamen ein.";

	/// <summary>
	/// Key: "Response.UsernameInvalidCharacters"
	/// English String: "Only a-z, A-Z, 0-9 and _ are allowed."
	/// </summary>
	public override string ResponseUsernameInvalidCharacters => "Nur a–z, A–Z, 0–9 und _ sind erlaubt.";

	/// <summary>
	/// Key: "Response.UsernameInvalidLength"
	/// English String: "Usernames can be 3 to 20 characters long."
	/// </summary>
	public override string ResponseUsernameInvalidLength => "Benutzernamen können 3 bis 20 Zeichen lang sein.";

	/// <summary>
	/// Key: "Response.UsernameInvalidUnderscore"
	/// English String: "Usernames cannot start or end with _."
	/// </summary>
	public override string ResponseUsernameInvalidUnderscore => "Benutzernamen dürfen nicht mit _ beginnen oder enden.";

	/// <summary>
	/// Key: "Response.UsernameNotAvailable"
	/// English String: "Username not available. Please try again."
	/// </summary>
	public override string ResponseUsernameNotAvailable => "Der Benutzername ist nicht verfügbar. Bitte versuche es erneut.";

	/// <summary>
	/// Key: "Response.UsernameOrPasswordIncorrect"
	/// Your username or password is incorrect
	/// English String: "Your username or password is incorrect."
	/// </summary>
	public override string ResponseUsernameOrPasswordIncorrect => "Dein Benutzername oder Passwort ist falsch.";

	/// <summary>
	/// Key: "Response.UsernamePasswordRequired"
	/// Username and Password are required error message
	/// English String: "Username and Password are required."
	/// </summary>
	public override string ResponseUsernamePasswordRequired => "Benutzername und Passwort sind erforderlich.";

	/// <summary>
	/// Key: "Response.UsernamePrivateInfo"
	/// English String: "Username might contain private information."
	/// </summary>
	public override string ResponseUsernamePrivateInfo => "Der Benutzername könnte private Informationen beinhalten.";

	/// <summary>
	/// Key: "Response.UsernameRequired"
	/// validation error message
	/// English String: "Username is required."
	/// </summary>
	public override string ResponseUsernameRequired => "Benutzername ist erforderlich.";

	/// <summary>
	/// Key: "Response.UsernameTakenTryAgain"
	/// English String: "This username is already taken! Please try a different one."
	/// </summary>
	public override string ResponseUsernameTakenTryAgain => "Dieser Benutzername wird bereits verwendet! Bitte versuche einen anderen.";

	/// <summary>
	/// Key: "Response.UsernameTooManyUnderscores"
	/// English String: "Usernames can have at most one _."
	/// </summary>
	public override string ResponseUsernameTooManyUnderscores => "Benutzername darf nur ein _ beinhalten.";

	public SignUpResources_de_de(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionCreateAccount()
	{
		return "Konto erstellen";
	}

	protected override string _GetTemplateForActionLinkAccount()
	{
		return "Konto verlinken";
	}

	protected override string _GetTemplateForActionLogInCapitalized()
	{
		return "Anmelden";
	}

	protected override string _GetTemplateForActionReturnHome()
	{
		return "Zurück zur Homepage";
	}

	protected override string _GetTemplateForActionSignUp()
	{
		return "Registrieren";
	}

	protected override string _GetTemplateForActionSignupAndSync()
	{
		return "Registrieren und synchronisieren";
	}

	protected override string _GetTemplateForActionSubmit()
	{
		return "Senden";
	}

	protected override string _GetTemplateForDescriptionAccountLinkingWarning()
	{
		return "Um eine Verknüpfung zu einem bestehenden Roblox-Konto herzustellen, melde dich an und führe die Verknüpfung auf der Kontoeinstellungsseite durch.";
	}

	protected override string _GetTemplateForDescriptionNoRealName()
	{
		return "Verwende nicht deinen echten Namen.";
	}

	protected override string _GetTemplateForDescriptionPrivacyPolicy()
	{
		return "Datenschutzrichtlinien";
	}

	/// <summary>
	/// Key: "Description.SignUpAgreement"
	/// terms of use agreement checkbox label to signup.
	/// English String: "By clicking {spanStart}Sign Up{spanEnd}, you are agreeing to the {termsOfUseLink} and acknowledging the {privacyPolicyLink}"
	/// </summary>
	public override string DescriptionSignUpAgreement(string spanStart, string spanEnd, string termsOfUseLink, string privacyPolicyLink)
	{
		return $"Durch Anklicken von {spanStart}Registrieren{spanEnd} stimmst du unseren {termsOfUseLink} zu und erkennst die {privacyPolicyLink} an.";
	}

	protected override string _GetTemplateForDescriptionSignUpAgreement()
	{
		return "Durch Anklicken von {spanStart}Registrieren{spanEnd} stimmst du unseren {termsOfUseLink} zu und erkennst die {privacyPolicyLink} an.";
	}

	protected override string _GetTemplateForDescriptionTermsOfService()
	{
		return "Nutzungsbedingungen";
	}

	protected override string _GetTemplateForGuestSignUpABActionSignUp()
	{
		return "Registrieren";
	}

	protected override string _GetTemplateForHeadingConnectFacebook()
	{
		return "Mit Facebook verbinden";
	}

	protected override string _GetTemplateForHeadingCreateAnAccount()
	{
		return "ERSTELLE EIN KONTO";
	}

	/// <summary>
	/// Key: "Heading.FacebookSignupAlmostDone"
	/// when user signs up using Facebook, this is shown in next step to create a password.
	/// English String: "{firstname}, YOU'RE ALMOST DONE"
	/// </summary>
	public override string HeadingFacebookSignupAlmostDone(string firstname)
	{
		return $"{firstname}, DU HAST ES FAST GESCHAFFT";
	}

	protected override string _GetTemplateForHeadingFacebookSignupAlmostDone()
	{
		return "{firstname}, DU HAST ES FAST GESCHAFFT";
	}

	protected override string _GetTemplateForHeadingLoginHaveFun()
	{
		return "Melde dich an und leg los!";
	}

	protected override string _GetTemplateForHeadingSignupHaveFun()
	{
		return "Registriere dich und leg los!";
	}

	protected override string _GetTemplateForLabelAbout()
	{
		return "Info";
	}

	protected override string _GetTemplateForLabelAlreadyHaveRobloxAccount()
	{
		return "Hast du schon ein Roblox-Konto?";
	}

	protected override string _GetTemplateForLabelAlreadyRegistered()
	{
		return "Bereits registriert?";
	}

	protected override string _GetTemplateForLabelBirthday()
	{
		return "Geburtstag";
	}

	protected override string _GetTemplateForLabelBirthdayWithColumn()
	{
		return "Geburtstag:";
	}

	protected override string _GetTemplateForLabelConfirmPassword()
	{
		return "Passwort bestätigen";
	}

	protected override string _GetTemplateForLabelDay()
	{
		return "Tag";
	}

	protected override string _GetTemplateForLabelDesiredUsername()
	{
		return "Gewünschter Benutzername:";
	}

	protected override string _GetTemplateForLabelFacebookNotLinked()
	{
		return "Dein Facebook-Konto ist mit keinem Roblox-Konto verlinkt. Bitte registriere dich für ein Roblox-Konto.";
	}

	protected override string _GetTemplateForLabelFacebookSignupUsername()
	{
		return "Roblox-Benutzername erstellen:";
	}

	protected override string _GetTemplateForLabelFemale()
	{
		return "Weiblich";
	}

	protected override string _GetTemplateForLabelGender()
	{
		return "Geschlecht";
	}

	protected override string _GetTemplateForLabelGenderRequired()
	{
		return "Du musst dein Geschlecht angeben.";
	}

	protected override string _GetTemplateForLabelGenderWithColumn()
	{
		return "Geschlecht:";
	}

	protected override string _GetTemplateForLabelMale()
	{
		return "Männlich";
	}

	protected override string _GetTemplateForLabelMonth()
	{
		return "Monat";
	}

	protected override string _GetTemplateForLabelPassword()
	{
		return "Passwort";
	}

	protected override string _GetTemplateForLabelPasswordRequirements()
	{
		return "Passwort (mind. 8 Zeichen)";
	}

	protected override string _GetTemplateForLabelPlatforms()
	{
		return "Plattformen";
	}

	protected override string _GetTemplateForLabelPlay()
	{
		return "Spielen";
	}

	protected override string _GetTemplateForLabelPleaseAgreeToTerms()
	{
		return "Bitte stimme unseren Nutzungsbedingungen und Datenschutzrichtlinien zu.";
	}

	protected override string _GetTemplateForLabelRequired()
	{
		return "Erforderlich";
	}

	protected override string _GetTemplateForLabelSignupButtonText()
	{
		return "Registrieren und spielen!";
	}

	protected override string _GetTemplateForLabelSignUpWith()
	{
		return "oder anmelden über";
	}

	protected override string _GetTemplateForLabelTermsOfUse()
	{
		return "Nutzungsbedingungen";
	}

	protected override string _GetTemplateForLabelUsername()
	{
		return "Benutzername";
	}

	protected override string _GetTemplateForLabelUsernameCharacterLimit()
	{
		return "3-20 alphanumerische Zeichen, keine Leerzeichen.";
	}

	protected override string _GetTemplateForLabelUsernameHint()
	{
		return "Benutzername (ausgedachter Name)";
	}

	protected override string _GetTemplateForLabelUsernameRequirements()
	{
		return "Benutzername (3-20 Zeichen, _ ist erlaubt)";
	}

	protected override string _GetTemplateForLabelYear()
	{
		return "Jahr";
	}

	protected override string _GetTemplateForMessagePasswordMinLength()
	{
		return "Mind. 8 Zeichen";
	}

	protected override string _GetTemplateForMessageUsernameNoRealNameUse()
	{
		return "Verwende nicht deinen echten Namen";
	}

	protected override string _GetTemplateForResponseBadUsername()
	{
		return "Der Benutzername ist nicht geeignet für Roblox.";
	}

	protected override string _GetTemplateForResponseBadUsernameForWeChat()
	{
		return "Benutzername ist nicht zugelassen";
	}

	protected override string _GetTemplateForResponseBirthdayInvalid()
	{
		return "Dieser Geburtstag ist ungültig.";
	}

	protected override string _GetTemplateForResponseBirthdayMustBeSetFirst()
	{
		return "Der Geburtstag muss zuerst festgelegt werden.";
	}

	protected override string _GetTemplateForResponseCaptchaMismatchError()
	{
		return "Die Wörter stimmen nicht überein.";
	}

	protected override string _GetTemplateForResponseCaptchaNotEnteredError()
	{
		return "Bitte gib das Captcha ein.";
	}

	protected override string _GetTemplateForResponseFacebookConnectionError()
	{
		return "Beim Abrufen der Daten von Facebook ist ein Fehler aufgetreten.";
	}

	protected override string _GetTemplateForResponseFacebookLoginAge()
	{
		return "Die Anmeldung mit Facebook ist nur für Benutzer über 13 Jahre möglich.";
	}

	protected override string _GetTemplateForResponseInvalidBirthday()
	{
		return "Ungültiger Geburtstag";
	}

	protected override string _GetTemplateForResponseInvalidEmail()
	{
		return "Ungültige E-Mail-Adresse";
	}

	protected override string _GetTemplateForResponseJavaScriptRequired()
	{
		return "Zum Senden dieses Formulars wird JavaScript benötigt.";
	}

	protected override string _GetTemplateForResponsePasswordComplexity()
	{
		return "Bitte überlege dir ein schwierigeres Passwort.";
	}

	protected override string _GetTemplateForResponsePasswordConfirmation()
	{
		return "Bitte gib eine Passwortbestätigung ein.";
	}

	protected override string _GetTemplateForResponsePasswordContainsUsernameError()
	{
		return "Passwort und Benutzername dürfen nicht identisch sein.";
	}

	protected override string _GetTemplateForResponsePasswordMismatch()
	{
		return "Passwörter stimmen nicht überein.";
	}

	protected override string _GetTemplateForResponsePasswordWrongShort()
	{
		return "Passwörter müssen mindestens 8 Zeichen lang sein.";
	}

	protected override string _GetTemplateForResponsePleaseEnterPassword()
	{
		return "Bitte gib ein Passwort ein.";
	}

	protected override string _GetTemplateForResponsePleaseEnterUsername()
	{
		return "Bitte gib einen Benutzernamen ein.";
	}

	protected override string _GetTemplateForResponseSocialAccountCreationFailed()
	{
		return "Erstellung des Kontos fehlgeschlagen";
	}

	protected override string _GetTemplateForResponseSpaceOrSpecialCharaterError()
	{
		return "Leerzeichen und Sonderzeichen sind nicht gestattet.";
	}

	protected override string _GetTemplateForResponseTooManyAccountsWithSameEmailError()
	{
		return "Zu viele Konten verwenden diese E-Mail-Adresse.";
	}

	protected override string _GetTemplateForResponseUnknownError()
	{
		return "Tut uns leid! Ein unbekannter Fehler ist aufgetreten. Bitte versuche es später erneut.";
	}

	protected override string _GetTemplateForResponseUsernameAllowedCharactersError()
	{
		return "Benutzernamen dürfen nur Buchstaben, Ziffern und _ enthalten.";
	}

	protected override string _GetTemplateForResponseUsernameAlreadyInUse()
	{
		return "Dieser Benutzername wird bereits verwendet.";
	}

	protected override string _GetTemplateForResponseUsernameExplicit()
	{
		return "Dieser Benutzername ist nicht erlaubt. Bitte versuche es mit einem anderen.";
	}

	protected override string _GetTemplateForResponseUsernameInvalid()
	{
		return "Bitte gib einen gültigen Benutzernamen ein.";
	}

	protected override string _GetTemplateForResponseUsernameInvalidCharacters()
	{
		return "Nur a–z, A–Z, 0–9 und _ sind erlaubt.";
	}

	protected override string _GetTemplateForResponseUsernameInvalidLength()
	{
		return "Benutzernamen können 3 bis 20 Zeichen lang sein.";
	}

	protected override string _GetTemplateForResponseUsernameInvalidUnderscore()
	{
		return "Benutzernamen dürfen nicht mit _ beginnen oder enden.";
	}

	protected override string _GetTemplateForResponseUsernameNotAvailable()
	{
		return "Der Benutzername ist nicht verfügbar. Bitte versuche es erneut.";
	}

	protected override string _GetTemplateForResponseUsernameOrPasswordIncorrect()
	{
		return "Dein Benutzername oder Passwort ist falsch.";
	}

	protected override string _GetTemplateForResponseUsernamePasswordRequired()
	{
		return "Benutzername und Passwort sind erforderlich.";
	}

	protected override string _GetTemplateForResponseUsernamePrivateInfo()
	{
		return "Der Benutzername könnte private Informationen beinhalten.";
	}

	protected override string _GetTemplateForResponseUsernameRequired()
	{
		return "Benutzername ist erforderlich.";
	}

	protected override string _GetTemplateForResponseUsernameTakenTryAgain()
	{
		return "Dieser Benutzername wird bereits verwendet! Bitte versuche einen anderen.";
	}

	protected override string _GetTemplateForResponseUsernameTooManyUnderscores()
	{
		return "Benutzername darf nur ein _ beinhalten.";
	}
}
