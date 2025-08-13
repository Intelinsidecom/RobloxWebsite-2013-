namespace Roblox.TranslationResources.Authentication;

/// <summary>
/// This class overrides SignUpResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class SignUpResources_it_it : SignUpResources_en_us, ISignUpResources, ITranslationResources
{
	/// <summary>
	/// Key: "Action.CreateAccount"
	/// create account button label
	/// English String: "Create Account"
	/// </summary>
	public override string ActionCreateAccount => "Crea account";

	/// <summary>
	/// Key: "Action.LinkAccount"
	/// Button text to link 3rd Party Account to a Roblox Account
	/// English String: "Link Account"
	/// </summary>
	public override string ActionLinkAccount => "Collega account";

	/// <summary>
	/// Key: "Action.LogInCapitalized"
	/// button label for capitalized words for Log In
	/// English String: "Log In"
	/// </summary>
	public override string ActionLogInCapitalized => "Accedi";

	/// <summary>
	/// Key: "Action.ReturnHome"
	/// button label to return the user to home page
	/// English String: "Return Home"
	/// </summary>
	public override string ActionReturnHome => "Torna alla Home";

	/// <summary>
	/// Key: "Action.SignUp"
	/// English String: "Sign up"
	/// </summary>
	public override string ActionSignUp => "Registrati";

	public override string ActionSignupAndSync => "Registrati e sincronizza";

	/// <summary>
	/// Key: "Action.Submit"
	/// English String: "Submit"
	/// </summary>
	public override string ActionSubmit => "Invia";

	/// <summary>
	/// Key: "Description.AccountLinkingWarning"
	/// instructions for linking account on signup page for FB based account
	/// English String: "To link to an existing Roblox account, sign in and link them on the account settings page."
	/// </summary>
	public override string DescriptionAccountLinkingWarning => "Per collegare un account di Roblox esistente, accedi e collegalo nella pagina delle impostazioni dell'account.";

	/// <summary>
	/// Key: "Description.NoRealName"
	/// description
	/// English String: "Do not use your real name."
	/// </summary>
	public override string DescriptionNoRealName => "Non utilizzare il tuo vero nome.";

	/// <summary>
	/// Key: "Description.PrivacyPolicy"
	/// English String: "Privacy Policy"
	/// </summary>
	public override string DescriptionPrivacyPolicy => "Informativa sulla privacy";

	/// <summary>
	/// Key: "Description.TermsOfService"
	/// English String: "Terms of Service"
	/// </summary>
	public override string DescriptionTermsOfService => "Termini di servizio";

	/// <summary>
	/// Key: "GuestSignUpAB.Action.SignUp"
	/// English String: "Sign Up"
	/// </summary>
	public override string GuestSignUpABActionSignUp => "Registrati";

	/// <summary>
	/// Key: "Heading.ConnectFacebook"
	/// section heading
	/// English String: "Connect to Facebook"
	/// </summary>
	public override string HeadingConnectFacebook => "Collegati a Facebook";

	/// <summary>
	/// Key: "Heading.CreateAnAccount"
	/// should be capitalized if the language supports capitalization
	/// English String: "CREATE AN ACCOUNT"
	/// </summary>
	public override string HeadingCreateAnAccount => "CREA UN ACCOUNT";

	/// <summary>
	/// Key: "Heading.LoginHaveFun"
	/// heading for login container
	/// English String: "Log in and start having fun!"
	/// </summary>
	public override string HeadingLoginHaveFun => "Accedi e divertiti!";

	/// <summary>
	/// Key: "Heading.SignupHaveFun"
	/// signup form heading
	/// English String: "Sign up and start having fun!"
	/// </summary>
	public override string HeadingSignupHaveFun => "Registrati e divertiti!";

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
	public override string LabelAlreadyHaveRobloxAccount => "Hai già un account Roblox?";

	/// <summary>
	/// Key: "Label.AlreadyRegistered"
	/// label
	/// English String: "Already registered?"
	/// </summary>
	public override string LabelAlreadyRegistered => "Sei già registrato?";

	/// <summary>
	/// Key: "Label.Birthday"
	/// English String: "Birthday"
	/// </summary>
	public override string LabelBirthday => "Data di nascita";

	/// <summary>
	/// Key: "Label.BirthdayWithColumn"
	/// should have column if the language supports it
	/// English String: "Birthday:"
	/// </summary>
	public override string LabelBirthdayWithColumn => "Data di nascita:";

	/// <summary>
	/// Key: "Label.ConfirmPassword"
	/// English String: "Confirm password"
	/// </summary>
	public override string LabelConfirmPassword => "Conferma password";

	/// <summary>
	/// Key: "Label.Day"
	/// English String: "Day"
	/// </summary>
	public override string LabelDay => "Giorno";

	/// <summary>
	/// Key: "Label.DesiredUsername"
	/// should have a column if the language supports it
	/// English String: "Desired Username:"
	/// </summary>
	public override string LabelDesiredUsername => "Nome utente desiderato:";

	/// <summary>
	/// Key: "Label.FacebookNotLinked"
	/// English String: "Your Facebook account is not linked to any Roblox account. Please sign up for a Roblox account."
	/// </summary>
	public override string LabelFacebookNotLinked => "Il tuo account Facebook non è collegato a nessun account Roblox. Crea un account Roblox.";

	/// <summary>
	/// Key: "Label.FacebookSignupUsername"
	/// username field label for FB signup
	/// English String: "Create Roblox username:"
	/// </summary>
	public override string LabelFacebookSignupUsername => "Crea un nome utente di Roblox:";

	/// <summary>
	/// Key: "Label.Female"
	/// label
	/// English String: "Female"
	/// </summary>
	public override string LabelFemale => "Femmina";

	/// <summary>
	/// Key: "Label.Gender"
	/// English String: "Gender"
	/// </summary>
	public override string LabelGender => "Sesso";

	/// <summary>
	/// Key: "Label.GenderRequired"
	/// English String: "Gender is required."
	/// </summary>
	public override string LabelGenderRequired => "Il genere è richiesto.";

	/// <summary>
	/// Key: "Label.GenderWithColumn"
	/// should have column if the language supports it
	/// English String: "Gender:"
	/// </summary>
	public override string LabelGenderWithColumn => "Sesso:";

	/// <summary>
	/// Key: "Label.Male"
	/// label
	/// English String: "Male"
	/// </summary>
	public override string LabelMale => "Maschio";

	/// <summary>
	/// Key: "Label.Month"
	/// English String: "Month"
	/// </summary>
	public override string LabelMonth => "Mese";

	/// <summary>
	/// Key: "Label.Password"
	/// English String: "Password"
	/// </summary>
	public override string LabelPassword => "Password";

	/// <summary>
	/// Key: "Label.PasswordRequirements"
	/// English String: "Password (min length 8)"
	/// </summary>
	public override string LabelPasswordRequirements => "Password (min. 8 caratteri)";

	/// <summary>
	/// Key: "Label.Platforms"
	/// platforms link on roller coaster page
	/// English String: "Platforms"
	/// </summary>
	public override string LabelPlatforms => "Piattaforme";

	/// <summary>
	/// Key: "Label.Play"
	/// Play link on roller coaster page
	/// English String: "Play"
	/// </summary>
	public override string LabelPlay => "Gioca";

	/// <summary>
	/// Key: "Label.PleaseAgreeToTerms"
	/// English String: "Please agree to our Terms of Use and Privacy Policy."
	/// </summary>
	public override string LabelPleaseAgreeToTerms => "Devi accettare i nostri Termini di servizio e l'Informativa sulla privacy.";

	/// <summary>
	/// Key: "Label.Required"
	/// Required
	/// English String: "Required"
	/// </summary>
	public override string LabelRequired => "Necessario";

	/// <summary>
	/// Key: "Label.SignupButtonText"
	/// sign up button text
	/// English String: "Sign Up and Play!"
	/// </summary>
	public override string LabelSignupButtonText => "Registrati e gioca!";

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
	public override string LabelSignUpWith => "oppure registrati con";

	/// <summary>
	/// Key: "Label.TermsOfUse"
	/// terms of use link label
	/// English String: "Terms of Use"
	/// </summary>
	public override string LabelTermsOfUse => "Termini di servizio";

	/// <summary>
	/// Key: "Label.Username"
	/// English String: "Username"
	/// </summary>
	public override string LabelUsername => "Nome utente";

	/// <summary>
	/// Key: "Label.UsernameCharacterLimit"
	/// label
	/// English String: "3-20 alphanumeric characters, no spaces."
	/// </summary>
	public override string LabelUsernameCharacterLimit => "3-20 caratteri alfanumerici, senza spazi.";

	/// <summary>
	/// Key: "Label.UsernameHint"
	/// placeholder for username field
	/// English String: "Username (don't use your real name)"
	/// </summary>
	public override string LabelUsernameHint => "Nome utente (non usare il tuo vero nome)";

	/// <summary>
	/// Key: "Label.UsernameRequirements"
	/// English String: "Username (length 3-20, _ is allowed)"
	/// </summary>
	public override string LabelUsernameRequirements => "Nome utente (lunghezza 3-20, _ è ammesso)";

	/// <summary>
	/// Key: "Label.Year"
	/// English String: "Year"
	/// </summary>
	public override string LabelYear => "Anno";

	/// <summary>
	/// Key: "Message.Password.MinLength"
	/// English String: "Min length 8"
	/// </summary>
	public override string MessagePasswordMinLength => "Min. 8 caratteri";

	/// <summary>
	/// Key: "Message.Username.NoRealNameUse"
	/// English String: "Don't use your real name"
	/// </summary>
	public override string MessageUsernameNoRealNameUse => "Non usare il tuo vero nome";

	/// <summary>
	/// Key: "Response.BadUsername"
	/// English String: "Username not appropriate for Roblox."
	/// </summary>
	public override string ResponseBadUsername => "Nome utente inappropriato per Roblox.";

	/// <summary>
	/// Key: "Response.BadUsernameForWeChat"
	/// message shown when signing up with an inappropriate username
	/// English String: "Username is not appropriate"
	/// </summary>
	public override string ResponseBadUsernameForWeChat => "Il nome utente non è appropriato";

	/// <summary>
	/// Key: "Response.BirthdayInvalid"
	/// English String: "This birthday is invalid."
	/// </summary>
	public override string ResponseBirthdayInvalid => "Data di nascita non valida.";

	/// <summary>
	/// Key: "Response.BirthdayMustBeSetFirst"
	/// English String: "Birthday must be set first."
	/// </summary>
	public override string ResponseBirthdayMustBeSetFirst => "Occorre prima impostare la data di nascita.";

	/// <summary>
	/// Key: "Response.CaptchaMismatchError"
	/// error message
	/// English String: "Words do not match."
	/// </summary>
	public override string ResponseCaptchaMismatchError => "Le parole non corrispondono.";

	/// <summary>
	/// Key: "Response.CaptchaNotEnteredError"
	/// validation error message
	/// English String: "Please fill out the Captcha"
	/// </summary>
	public override string ResponseCaptchaNotEnteredError => "Completa il Captcha";

	/// <summary>
	/// Key: "Response.FacebookConnectionError"
	/// error message
	/// English String: "Error while retrieving values from Facebook."
	/// </summary>
	public override string ResponseFacebookConnectionError => "Errore durante il recupero dei valori da Facebook.";

	/// <summary>
	/// Key: "Response.FacebookLoginAge"
	/// English String: "Facebook login can only be used by users above 13."
	/// </summary>
	public override string ResponseFacebookLoginAge => "Solo gli utenti maggiori di 13 anni possono accedere con Facebook.";

	/// <summary>
	/// Key: "Response.InvalidBirthday"
	/// English String: "Invalid birthday."
	/// </summary>
	public override string ResponseInvalidBirthday => "Data di nascita non valida";

	/// <summary>
	/// Key: "Response.InvalidEmail"
	/// English String: "Invalid email address."
	/// </summary>
	public override string ResponseInvalidEmail => "Indirizzo e-mail non valido.";

	/// <summary>
	/// Key: "Response.JavaScriptRequired"
	/// error to show that JavaScipt is required for the form to work
	/// English String: "JavaScript is required to submit this form."
	/// </summary>
	public override string ResponseJavaScriptRequired => "Serve JavaScript per inviare questo modulo.";

	/// <summary>
	/// Key: "Response.PasswordComplexity"
	/// English String: "Please create a more complex password."
	/// </summary>
	public override string ResponsePasswordComplexity => "Crea una password più complessa.";

	/// <summary>
	/// Key: "Response.PasswordConfirmation"
	/// validation message for password confirmation
	/// English String: "Please enter a password confirmation."
	/// </summary>
	public override string ResponsePasswordConfirmation => "Inserisci la conferma della password.";

	/// <summary>
	/// Key: "Response.PasswordContainsUsernameError"
	/// error when passsword has username in it
	/// English String: "Password shouldn't match username."
	/// </summary>
	public override string ResponsePasswordContainsUsernameError => "La password e il nome utente devono essere diversi.";

	/// <summary>
	/// Key: "Response.PasswordMismatch"
	/// English String: "Passwords do not match."
	/// </summary>
	public override string ResponsePasswordMismatch => "Le password non coincidono.";

	/// <summary>
	/// Key: "Response.PasswordWrongShort"
	/// English String: "Passwords must be at least 8 characters long."
	/// </summary>
	public override string ResponsePasswordWrongShort => "Le password devono essere lunghe almeno 8 caratteri.";

	/// <summary>
	/// Key: "Response.PleaseEnterPassword"
	/// English String: "Please enter a password."
	/// </summary>
	public override string ResponsePleaseEnterPassword => "Inserisci una password.";

	/// <summary>
	/// Key: "Response.PleaseEnterUsername"
	/// English String: "Please enter a username."
	/// </summary>
	public override string ResponsePleaseEnterUsername => "Inserisci un nome utente.";

	/// <summary>
	/// Key: "Response.SocialAccountCreationFailed"
	/// error message
	/// English String: "Account creation failed"
	/// </summary>
	public override string ResponseSocialAccountCreationFailed => "Creazione account non riuscita";

	/// <summary>
	/// Key: "Response.SpaceOrSpecialCharaterError"
	/// Spaces and special characters are not allowed error message
	/// English String: "Spaces and special characters are not allowed."
	/// </summary>
	public override string ResponseSpaceOrSpecialCharaterError => "Spazi e caratteri speciali non consentiti.";

	/// <summary>
	/// Key: "Response.TooManyAccountsWithSameEmailError"
	/// Too many accounts use this email error message
	/// English String: "Too many accounts use this email."
	/// </summary>
	public override string ResponseTooManyAccountsWithSameEmailError => "Troppi account usano questa e-mail.";

	/// <summary>
	/// Key: "Response.UnknownError"
	/// English String: "Sorry! An unknown error occurred. Please try again later."
	/// </summary>
	public override string ResponseUnknownError => "Spiacenti, si è verificato un errore imprevisto. Riprova più tardi.";

	/// <summary>
	/// Key: "Response.UsernameAllowedCharactersError"
	/// error showing which characters are allowed for username
	/// English String: "Usernames may only contain letters, numbers, and _."
	/// </summary>
	public override string ResponseUsernameAllowedCharactersError => "I nomi utenti possono contenere solo lettere, numeri e _.";

	/// <summary>
	/// Key: "Response.UsernameAlreadyInUse"
	/// English String: "This username is already in use."
	/// </summary>
	public override string ResponseUsernameAlreadyInUse => "Questo nome utente è già in uso.";

	/// <summary>
	/// Key: "Response.UsernameExplicit"
	/// English String: "This username is not allowed, please try another."
	/// </summary>
	public override string ResponseUsernameExplicit => "Questo nome utente non è ammesso.";

	/// <summary>
	/// Key: "Response.UsernameInvalid"
	/// English String: "Please enter a valid username."
	/// </summary>
	public override string ResponseUsernameInvalid => "Immetti un nome utente valido.";

	/// <summary>
	/// Key: "Response.UsernameInvalidCharacters"
	/// English String: "Only a-z, A-Z, 0-9 and _ are allowed."
	/// </summary>
	public override string ResponseUsernameInvalidCharacters => "Sono consentiti solo a-z, A-Z, 0-9 e _.";

	/// <summary>
	/// Key: "Response.UsernameInvalidLength"
	/// English String: "Usernames can be 3 to 20 characters long."
	/// </summary>
	public override string ResponseUsernameInvalidLength => "Lunghezza nomi utenti tra 3 e 20 caratteri.";

	/// <summary>
	/// Key: "Response.UsernameInvalidUnderscore"
	/// English String: "Usernames cannot start or end with _."
	/// </summary>
	public override string ResponseUsernameInvalidUnderscore => "I nomi utente non possono iniziare né terminare con _.";

	/// <summary>
	/// Key: "Response.UsernameNotAvailable"
	/// English String: "Username not available. Please try again."
	/// </summary>
	public override string ResponseUsernameNotAvailable => "Nome utente non disponibile. Riprova.";

	/// <summary>
	/// Key: "Response.UsernameOrPasswordIncorrect"
	/// Your username or password is incorrect
	/// English String: "Your username or password is incorrect."
	/// </summary>
	public override string ResponseUsernameOrPasswordIncorrect => "Nome utente o password incorretti.";

	/// <summary>
	/// Key: "Response.UsernamePasswordRequired"
	/// Username and Password are required error message
	/// English String: "Username and Password are required."
	/// </summary>
	public override string ResponseUsernamePasswordRequired => "Nome utente e password necessari.";

	/// <summary>
	/// Key: "Response.UsernamePrivateInfo"
	/// English String: "Username might contain private information."
	/// </summary>
	public override string ResponseUsernamePrivateInfo => "Il nome utente potrebbe contenere informazioni private.";

	/// <summary>
	/// Key: "Response.UsernameRequired"
	/// validation error message
	/// English String: "Username is required."
	/// </summary>
	public override string ResponseUsernameRequired => "Serve un nome utente.";

	/// <summary>
	/// Key: "Response.UsernameTakenTryAgain"
	/// English String: "This username is already taken! Please try a different one."
	/// </summary>
	public override string ResponseUsernameTakenTryAgain => "Questo nome utente è già in uso. Provane un altro.";

	/// <summary>
	/// Key: "Response.UsernameTooManyUnderscores"
	/// English String: "Usernames can have at most one _."
	/// </summary>
	public override string ResponseUsernameTooManyUnderscores => "I nomi utente possono contenere al massimo un _.";

	public SignUpResources_it_it(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionCreateAccount()
	{
		return "Crea account";
	}

	protected override string _GetTemplateForActionLinkAccount()
	{
		return "Collega account";
	}

	protected override string _GetTemplateForActionLogInCapitalized()
	{
		return "Accedi";
	}

	protected override string _GetTemplateForActionReturnHome()
	{
		return "Torna alla Home";
	}

	protected override string _GetTemplateForActionSignUp()
	{
		return "Registrati";
	}

	protected override string _GetTemplateForActionSignupAndSync()
	{
		return "Registrati e sincronizza";
	}

	protected override string _GetTemplateForActionSubmit()
	{
		return "Invia";
	}

	protected override string _GetTemplateForDescriptionAccountLinkingWarning()
	{
		return "Per collegare un account di Roblox esistente, accedi e collegalo nella pagina delle impostazioni dell'account.";
	}

	protected override string _GetTemplateForDescriptionNoRealName()
	{
		return "Non utilizzare il tuo vero nome.";
	}

	protected override string _GetTemplateForDescriptionPrivacyPolicy()
	{
		return "Informativa sulla privacy";
	}

	/// <summary>
	/// Key: "Description.SignUpAgreement"
	/// terms of use agreement checkbox label to signup.
	/// English String: "By clicking {spanStart}Sign Up{spanEnd}, you are agreeing to the {termsOfUseLink} and acknowledging the {privacyPolicyLink}"
	/// </summary>
	public override string DescriptionSignUpAgreement(string spanStart, string spanEnd, string termsOfUseLink, string privacyPolicyLink)
	{
		return $"Facendo clic su {spanStart}Registrati{spanEnd}, accetti {termsOfUseLink} e prendi atto di {privacyPolicyLink}.";
	}

	protected override string _GetTemplateForDescriptionSignUpAgreement()
	{
		return "Facendo clic su {spanStart}Registrati{spanEnd}, accetti {termsOfUseLink} e prendi atto di {privacyPolicyLink}.";
	}

	protected override string _GetTemplateForDescriptionTermsOfService()
	{
		return "Termini di servizio";
	}

	protected override string _GetTemplateForGuestSignUpABActionSignUp()
	{
		return "Registrati";
	}

	protected override string _GetTemplateForHeadingConnectFacebook()
	{
		return "Collegati a Facebook";
	}

	protected override string _GetTemplateForHeadingCreateAnAccount()
	{
		return "CREA UN ACCOUNT";
	}

	/// <summary>
	/// Key: "Heading.FacebookSignupAlmostDone"
	/// when user signs up using Facebook, this is shown in next step to create a password.
	/// English String: "{firstname}, YOU'RE ALMOST DONE"
	/// </summary>
	public override string HeadingFacebookSignupAlmostDone(string firstname)
	{
		return $"{firstname}, CI SEI QUASI";
	}

	protected override string _GetTemplateForHeadingFacebookSignupAlmostDone()
	{
		return "{firstname}, CI SEI QUASI";
	}

	protected override string _GetTemplateForHeadingLoginHaveFun()
	{
		return "Accedi e divertiti!";
	}

	protected override string _GetTemplateForHeadingSignupHaveFun()
	{
		return "Registrati e divertiti!";
	}

	protected override string _GetTemplateForLabelAbout()
	{
		return "Info";
	}

	protected override string _GetTemplateForLabelAlreadyHaveRobloxAccount()
	{
		return "Hai già un account Roblox?";
	}

	protected override string _GetTemplateForLabelAlreadyRegistered()
	{
		return "Sei già registrato?";
	}

	protected override string _GetTemplateForLabelBirthday()
	{
		return "Data di nascita";
	}

	protected override string _GetTemplateForLabelBirthdayWithColumn()
	{
		return "Data di nascita:";
	}

	protected override string _GetTemplateForLabelConfirmPassword()
	{
		return "Conferma password";
	}

	protected override string _GetTemplateForLabelDay()
	{
		return "Giorno";
	}

	protected override string _GetTemplateForLabelDesiredUsername()
	{
		return "Nome utente desiderato:";
	}

	protected override string _GetTemplateForLabelFacebookNotLinked()
	{
		return "Il tuo account Facebook non è collegato a nessun account Roblox. Crea un account Roblox.";
	}

	protected override string _GetTemplateForLabelFacebookSignupUsername()
	{
		return "Crea un nome utente di Roblox:";
	}

	protected override string _GetTemplateForLabelFemale()
	{
		return "Femmina";
	}

	protected override string _GetTemplateForLabelGender()
	{
		return "Sesso";
	}

	protected override string _GetTemplateForLabelGenderRequired()
	{
		return "Il genere è richiesto.";
	}

	protected override string _GetTemplateForLabelGenderWithColumn()
	{
		return "Sesso:";
	}

	protected override string _GetTemplateForLabelMale()
	{
		return "Maschio";
	}

	protected override string _GetTemplateForLabelMonth()
	{
		return "Mese";
	}

	protected override string _GetTemplateForLabelPassword()
	{
		return "Password";
	}

	protected override string _GetTemplateForLabelPasswordRequirements()
	{
		return "Password (min. 8 caratteri)";
	}

	protected override string _GetTemplateForLabelPlatforms()
	{
		return "Piattaforme";
	}

	protected override string _GetTemplateForLabelPlay()
	{
		return "Gioca";
	}

	protected override string _GetTemplateForLabelPleaseAgreeToTerms()
	{
		return "Devi accettare i nostri Termini di servizio e l'Informativa sulla privacy.";
	}

	protected override string _GetTemplateForLabelRequired()
	{
		return "Necessario";
	}

	protected override string _GetTemplateForLabelSignupButtonText()
	{
		return "Registrati e gioca!";
	}

	protected override string _GetTemplateForLabelSignUpWith()
	{
		return "oppure registrati con";
	}

	protected override string _GetTemplateForLabelTermsOfUse()
	{
		return "Termini di servizio";
	}

	protected override string _GetTemplateForLabelUsername()
	{
		return "Nome utente";
	}

	protected override string _GetTemplateForLabelUsernameCharacterLimit()
	{
		return "3-20 caratteri alfanumerici, senza spazi.";
	}

	protected override string _GetTemplateForLabelUsernameHint()
	{
		return "Nome utente (non usare il tuo vero nome)";
	}

	protected override string _GetTemplateForLabelUsernameRequirements()
	{
		return "Nome utente (lunghezza 3-20, _ è ammesso)";
	}

	protected override string _GetTemplateForLabelYear()
	{
		return "Anno";
	}

	protected override string _GetTemplateForMessagePasswordMinLength()
	{
		return "Min. 8 caratteri";
	}

	protected override string _GetTemplateForMessageUsernameNoRealNameUse()
	{
		return "Non usare il tuo vero nome";
	}

	protected override string _GetTemplateForResponseBadUsername()
	{
		return "Nome utente inappropriato per Roblox.";
	}

	protected override string _GetTemplateForResponseBadUsernameForWeChat()
	{
		return "Il nome utente non è appropriato";
	}

	protected override string _GetTemplateForResponseBirthdayInvalid()
	{
		return "Data di nascita non valida.";
	}

	protected override string _GetTemplateForResponseBirthdayMustBeSetFirst()
	{
		return "Occorre prima impostare la data di nascita.";
	}

	protected override string _GetTemplateForResponseCaptchaMismatchError()
	{
		return "Le parole non corrispondono.";
	}

	protected override string _GetTemplateForResponseCaptchaNotEnteredError()
	{
		return "Completa il Captcha";
	}

	protected override string _GetTemplateForResponseFacebookConnectionError()
	{
		return "Errore durante il recupero dei valori da Facebook.";
	}

	protected override string _GetTemplateForResponseFacebookLoginAge()
	{
		return "Solo gli utenti maggiori di 13 anni possono accedere con Facebook.";
	}

	protected override string _GetTemplateForResponseInvalidBirthday()
	{
		return "Data di nascita non valida";
	}

	protected override string _GetTemplateForResponseInvalidEmail()
	{
		return "Indirizzo e-mail non valido.";
	}

	protected override string _GetTemplateForResponseJavaScriptRequired()
	{
		return "Serve JavaScript per inviare questo modulo.";
	}

	protected override string _GetTemplateForResponsePasswordComplexity()
	{
		return "Crea una password più complessa.";
	}

	protected override string _GetTemplateForResponsePasswordConfirmation()
	{
		return "Inserisci la conferma della password.";
	}

	protected override string _GetTemplateForResponsePasswordContainsUsernameError()
	{
		return "La password e il nome utente devono essere diversi.";
	}

	protected override string _GetTemplateForResponsePasswordMismatch()
	{
		return "Le password non coincidono.";
	}

	protected override string _GetTemplateForResponsePasswordWrongShort()
	{
		return "Le password devono essere lunghe almeno 8 caratteri.";
	}

	protected override string _GetTemplateForResponsePleaseEnterPassword()
	{
		return "Inserisci una password.";
	}

	protected override string _GetTemplateForResponsePleaseEnterUsername()
	{
		return "Inserisci un nome utente.";
	}

	protected override string _GetTemplateForResponseSocialAccountCreationFailed()
	{
		return "Creazione account non riuscita";
	}

	protected override string _GetTemplateForResponseSpaceOrSpecialCharaterError()
	{
		return "Spazi e caratteri speciali non consentiti.";
	}

	protected override string _GetTemplateForResponseTooManyAccountsWithSameEmailError()
	{
		return "Troppi account usano questa e-mail.";
	}

	protected override string _GetTemplateForResponseUnknownError()
	{
		return "Spiacenti, si è verificato un errore imprevisto. Riprova più tardi.";
	}

	protected override string _GetTemplateForResponseUsernameAllowedCharactersError()
	{
		return "I nomi utenti possono contenere solo lettere, numeri e _.";
	}

	protected override string _GetTemplateForResponseUsernameAlreadyInUse()
	{
		return "Questo nome utente è già in uso.";
	}

	protected override string _GetTemplateForResponseUsernameExplicit()
	{
		return "Questo nome utente non è ammesso.";
	}

	protected override string _GetTemplateForResponseUsernameInvalid()
	{
		return "Immetti un nome utente valido.";
	}

	protected override string _GetTemplateForResponseUsernameInvalidCharacters()
	{
		return "Sono consentiti solo a-z, A-Z, 0-9 e _.";
	}

	protected override string _GetTemplateForResponseUsernameInvalidLength()
	{
		return "Lunghezza nomi utenti tra 3 e 20 caratteri.";
	}

	protected override string _GetTemplateForResponseUsernameInvalidUnderscore()
	{
		return "I nomi utente non possono iniziare né terminare con _.";
	}

	protected override string _GetTemplateForResponseUsernameNotAvailable()
	{
		return "Nome utente non disponibile. Riprova.";
	}

	protected override string _GetTemplateForResponseUsernameOrPasswordIncorrect()
	{
		return "Nome utente o password incorretti.";
	}

	protected override string _GetTemplateForResponseUsernamePasswordRequired()
	{
		return "Nome utente e password necessari.";
	}

	protected override string _GetTemplateForResponseUsernamePrivateInfo()
	{
		return "Il nome utente potrebbe contenere informazioni private.";
	}

	protected override string _GetTemplateForResponseUsernameRequired()
	{
		return "Serve un nome utente.";
	}

	protected override string _GetTemplateForResponseUsernameTakenTryAgain()
	{
		return "Questo nome utente è già in uso. Provane un altro.";
	}

	protected override string _GetTemplateForResponseUsernameTooManyUnderscores()
	{
		return "I nomi utente possono contenere al massimo un _.";
	}
}
