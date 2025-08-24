namespace Roblox.TranslationResources.Authentication;

/// <summary>
/// This class overrides SignUpResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class SignUpResources_es_es : SignUpResources_en_us, ISignUpResources, ITranslationResources
{
	/// <summary>
	/// Key: "Action.CreateAccount"
	/// create account button label
	/// English String: "Create Account"
	/// </summary>
	public override string ActionCreateAccount => "Crear cuenta";

	/// <summary>
	/// Key: "Action.LinkAccount"
	/// Button text to link 3rd Party Account to a Roblox Account
	/// English String: "Link Account"
	/// </summary>
	public override string ActionLinkAccount => "Vincular cuenta";

	/// <summary>
	/// Key: "Action.LogInCapitalized"
	/// button label for capitalized words for Log In
	/// English String: "Log In"
	/// </summary>
	public override string ActionLogInCapitalized => "Iniciar sesión";

	/// <summary>
	/// Key: "Action.ReturnHome"
	/// button label to return the user to home page
	/// English String: "Return Home"
	/// </summary>
	public override string ActionReturnHome => "Volver a Inicio";

	/// <summary>
	/// Key: "Action.SignUp"
	/// English String: "Sign up"
	/// </summary>
	public override string ActionSignUp => "Regístrate";

	public override string ActionSignupAndSync => "Registrarse y sincronizar";

	/// <summary>
	/// Key: "Action.Submit"
	/// English String: "Submit"
	/// </summary>
	public override string ActionSubmit => "Enviar";

	/// <summary>
	/// Key: "Description.AccountLinkingWarning"
	/// instructions for linking account on signup page for FB based account
	/// English String: "To link to an existing Roblox account, sign in and link them on the account settings page."
	/// </summary>
	public override string DescriptionAccountLinkingWarning => "Para vincular la cuenta a una existente de Roblox, inicia sesión y ve a la página de configuración de la cuenta.";

	/// <summary>
	/// Key: "Description.NoRealName"
	/// description
	/// English String: "Do not use your real name."
	/// </summary>
	public override string DescriptionNoRealName => "No utilices tu nombre real.";

	/// <summary>
	/// Key: "Description.PrivacyPolicy"
	/// English String: "Privacy Policy"
	/// </summary>
	public override string DescriptionPrivacyPolicy => "Política de privacidad";

	/// <summary>
	/// Key: "Description.TermsOfService"
	/// English String: "Terms of Service"
	/// </summary>
	public override string DescriptionTermsOfService => "Términos de servicio";

	/// <summary>
	/// Key: "GuestSignUpAB.Action.SignUp"
	/// English String: "Sign Up"
	/// </summary>
	public override string GuestSignUpABActionSignUp => "Regístrate";

	/// <summary>
	/// Key: "Heading.ConnectFacebook"
	/// section heading
	/// English String: "Connect to Facebook"
	/// </summary>
	public override string HeadingConnectFacebook => "Conectar a Facebook";

	/// <summary>
	/// Key: "Heading.CreateAnAccount"
	/// should be capitalized if the language supports capitalization
	/// English String: "CREATE AN ACCOUNT"
	/// </summary>
	public override string HeadingCreateAnAccount => "CREAR UNA CUENTA";

	/// <summary>
	/// Key: "Heading.LoginHaveFun"
	/// heading for login container
	/// English String: "Log in and start having fun!"
	/// </summary>
	public override string HeadingLoginHaveFun => "¡Inicia sesión y diviértete!";

	/// <summary>
	/// Key: "Heading.SignupHaveFun"
	/// signup form heading
	/// English String: "Sign up and start having fun!"
	/// </summary>
	public override string HeadingSignupHaveFun => "¡Regístrate y diviértete!";

	/// <summary>
	/// Key: "Label.About"
	/// About link on roller coaster page
	/// English String: "About"
	/// </summary>
	public override string LabelAbout => "Acerca de Roblox";

	/// <summary>
	/// Key: "Label.AlreadyHaveRobloxAccount"
	/// English String: "Already have a Roblox account?"
	/// </summary>
	public override string LabelAlreadyHaveRobloxAccount => "¿Ya tienes una cuenta de Roblox?";

	/// <summary>
	/// Key: "Label.AlreadyRegistered"
	/// label
	/// English String: "Already registered?"
	/// </summary>
	public override string LabelAlreadyRegistered => "¿Ya te has registrado?";

	/// <summary>
	/// Key: "Label.Birthday"
	/// English String: "Birthday"
	/// </summary>
	public override string LabelBirthday => "Fecha de nacimiento";

	/// <summary>
	/// Key: "Label.BirthdayWithColumn"
	/// should have column if the language supports it
	/// English String: "Birthday:"
	/// </summary>
	public override string LabelBirthdayWithColumn => "Fecha de nacimiento:";

	/// <summary>
	/// Key: "Label.ConfirmPassword"
	/// English String: "Confirm password"
	/// </summary>
	public override string LabelConfirmPassword => "Confirmar contraseña";

	/// <summary>
	/// Key: "Label.Day"
	/// English String: "Day"
	/// </summary>
	public override string LabelDay => "Día";

	/// <summary>
	/// Key: "Label.DesiredUsername"
	/// should have a column if the language supports it
	/// English String: "Desired Username:"
	/// </summary>
	public override string LabelDesiredUsername => "Nombre de usuario preferido:";

	/// <summary>
	/// Key: "Label.FacebookNotLinked"
	/// English String: "Your Facebook account is not linked to any Roblox account. Please sign up for a Roblox account."
	/// </summary>
	public override string LabelFacebookNotLinked => "Tu cuenta de Facebook no está vinculada a ninguna cuenta de Roblox. Regístrate para obtener una cuenta de Roblox.";

	/// <summary>
	/// Key: "Label.FacebookSignupUsername"
	/// username field label for FB signup
	/// English String: "Create Roblox username:"
	/// </summary>
	public override string LabelFacebookSignupUsername => "Crear nombre de usuario de Roblox:";

	/// <summary>
	/// Key: "Label.Female"
	/// label
	/// English String: "Female"
	/// </summary>
	public override string LabelFemale => "Mujer";

	/// <summary>
	/// Key: "Label.Gender"
	/// English String: "Gender"
	/// </summary>
	public override string LabelGender => "Sexo";

	/// <summary>
	/// Key: "Label.GenderRequired"
	/// English String: "Gender is required."
	/// </summary>
	public override string LabelGenderRequired => "Es necesario especificar el sexo.";

	/// <summary>
	/// Key: "Label.GenderWithColumn"
	/// should have column if the language supports it
	/// English String: "Gender:"
	/// </summary>
	public override string LabelGenderWithColumn => "Sexo:";

	/// <summary>
	/// Key: "Label.Male"
	/// label
	/// English String: "Male"
	/// </summary>
	public override string LabelMale => "Hombre";

	/// <summary>
	/// Key: "Label.Month"
	/// English String: "Month"
	/// </summary>
	public override string LabelMonth => "Mes";

	/// <summary>
	/// Key: "Label.Password"
	/// English String: "Password"
	/// </summary>
	public override string LabelPassword => "Contraseña";

	/// <summary>
	/// Key: "Label.PasswordRequirements"
	/// English String: "Password (min length 8)"
	/// </summary>
	public override string LabelPasswordRequirements => "Contraseña (longitud mínima: 8)";

	/// <summary>
	/// Key: "Label.Platforms"
	/// platforms link on roller coaster page
	/// English String: "Platforms"
	/// </summary>
	public override string LabelPlatforms => "Plataformas";

	/// <summary>
	/// Key: "Label.Play"
	/// Play link on roller coaster page
	/// English String: "Play"
	/// </summary>
	public override string LabelPlay => "Jugar";

	/// <summary>
	/// Key: "Label.PleaseAgreeToTerms"
	/// English String: "Please agree to our Terms of Use and Privacy Policy."
	/// </summary>
	public override string LabelPleaseAgreeToTerms => "Por favor, acepta nuestros términos de uso y nuestra política de privacidad.";

	/// <summary>
	/// Key: "Label.Required"
	/// Required
	/// English String: "Required"
	/// </summary>
	public override string LabelRequired => "Necesario";

	/// <summary>
	/// Key: "Label.SignupButtonText"
	/// sign up button text
	/// English String: "Sign Up and Play!"
	/// </summary>
	public override string LabelSignupButtonText => "¡Regístrate y juega!";

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
	public override string LabelSignUpWith => "o inicia sesión con";

	/// <summary>
	/// Key: "Label.TermsOfUse"
	/// terms of use link label
	/// English String: "Terms of Use"
	/// </summary>
	public override string LabelTermsOfUse => "Términos de uso";

	/// <summary>
	/// Key: "Label.Username"
	/// English String: "Username"
	/// </summary>
	public override string LabelUsername => "Usuario";

	/// <summary>
	/// Key: "Label.UsernameCharacterLimit"
	/// label
	/// English String: "3-20 alphanumeric characters, no spaces."
	/// </summary>
	public override string LabelUsernameCharacterLimit => "Entre 3 y 20 caracteres alfanuméricos sin espacios.";

	/// <summary>
	/// Key: "Label.UsernameHint"
	/// placeholder for username field
	/// English String: "Username (don't use your real name)"
	/// </summary>
	public override string LabelUsernameHint => "Nombre de usuario (nombre ficticio)";

	/// <summary>
	/// Key: "Label.UsernameRequirements"
	/// English String: "Username (length 3-20, _ is allowed)"
	/// </summary>
	public override string LabelUsernameRequirements => "Nombre de usuario (de 3 a 20 caracteres)";

	/// <summary>
	/// Key: "Label.Year"
	/// English String: "Year"
	/// </summary>
	public override string LabelYear => "Año";

	/// <summary>
	/// Key: "Message.Password.MinLength"
	/// English String: "Min length 8"
	/// </summary>
	public override string MessagePasswordMinLength => "Longitud mínima: 8";

	/// <summary>
	/// Key: "Message.Username.NoRealNameUse"
	/// English String: "Don't use your real name"
	/// </summary>
	public override string MessageUsernameNoRealNameUse => "No utilices tu nombre real";

	/// <summary>
	/// Key: "Response.BadUsername"
	/// English String: "Username not appropriate for Roblox."
	/// </summary>
	public override string ResponseBadUsername => "Nombre de usuario inadecuado para Roblox.";

	/// <summary>
	/// Key: "Response.BadUsernameForWeChat"
	/// message shown when signing up with an inappropriate username
	/// English String: "Username is not appropriate"
	/// </summary>
	public override string ResponseBadUsernameForWeChat => "El nombre de usuario no es adecuado";

	/// <summary>
	/// Key: "Response.BirthdayInvalid"
	/// English String: "This birthday is invalid."
	/// </summary>
	public override string ResponseBirthdayInvalid => "Esta fecha de nacimiento no es válida.";

	/// <summary>
	/// Key: "Response.BirthdayMustBeSetFirst"
	/// English String: "Birthday must be set first."
	/// </summary>
	public override string ResponseBirthdayMustBeSetFirst => "Antes debes determinar tu fecha de nacimiento.";

	/// <summary>
	/// Key: "Response.CaptchaMismatchError"
	/// error message
	/// English String: "Words do not match."
	/// </summary>
	public override string ResponseCaptchaMismatchError => "Las palabras no coinciden.";

	/// <summary>
	/// Key: "Response.CaptchaNotEnteredError"
	/// validation error message
	/// English String: "Please fill out the Captcha"
	/// </summary>
	public override string ResponseCaptchaNotEnteredError => "Completa el desafío Captcha";

	/// <summary>
	/// Key: "Response.FacebookConnectionError"
	/// error message
	/// English String: "Error while retrieving values from Facebook."
	/// </summary>
	public override string ResponseFacebookConnectionError => "Error al recuperar valores de Facebook";

	/// <summary>
	/// Key: "Response.FacebookLoginAge"
	/// English String: "Facebook login can only be used by users above 13."
	/// </summary>
	public override string ResponseFacebookLoginAge => "Solo los usuarios mayores de 13 años pueden iniciar sesión con Facebook.";

	/// <summary>
	/// Key: "Response.InvalidBirthday"
	/// English String: "Invalid birthday."
	/// </summary>
	public override string ResponseInvalidBirthday => "Fecha de nacimiento no válida.";

	/// <summary>
	/// Key: "Response.InvalidEmail"
	/// English String: "Invalid email address."
	/// </summary>
	public override string ResponseInvalidEmail => "Dirección de correo electrónico no válida.";

	/// <summary>
	/// Key: "Response.JavaScriptRequired"
	/// error to show that JavaScipt is required for the form to work
	/// English String: "JavaScript is required to submit this form."
	/// </summary>
	public override string ResponseJavaScriptRequired => "Se requiere JavaScript para enviar este formulario.";

	/// <summary>
	/// Key: "Response.PasswordComplexity"
	/// English String: "Please create a more complex password."
	/// </summary>
	public override string ResponsePasswordComplexity => "Crea una contraseña más complicada.";

	/// <summary>
	/// Key: "Response.PasswordConfirmation"
	/// validation message for password confirmation
	/// English String: "Please enter a password confirmation."
	/// </summary>
	public override string ResponsePasswordConfirmation => "Introduce la confirmación de la contraseña.";

	/// <summary>
	/// Key: "Response.PasswordContainsUsernameError"
	/// error when passsword has username in it
	/// English String: "Password shouldn't match username."
	/// </summary>
	public override string ResponsePasswordContainsUsernameError => "La contraseña y el nombre de usuario no pueden coincidir.";

	/// <summary>
	/// Key: "Response.PasswordMismatch"
	/// English String: "Passwords do not match."
	/// </summary>
	public override string ResponsePasswordMismatch => "Las contraseñas no coinciden.";

	/// <summary>
	/// Key: "Response.PasswordWrongShort"
	/// English String: "Passwords must be at least 8 characters long."
	/// </summary>
	public override string ResponsePasswordWrongShort => "La contraseña debe tener al menos 8 caracteres.";

	/// <summary>
	/// Key: "Response.PleaseEnterPassword"
	/// English String: "Please enter a password."
	/// </summary>
	public override string ResponsePleaseEnterPassword => "Introduce una contraseña.";

	/// <summary>
	/// Key: "Response.PleaseEnterUsername"
	/// English String: "Please enter a username."
	/// </summary>
	public override string ResponsePleaseEnterUsername => "Introduce un nombre de usuario.";

	/// <summary>
	/// Key: "Response.SocialAccountCreationFailed"
	/// error message
	/// English String: "Account creation failed"
	/// </summary>
	public override string ResponseSocialAccountCreationFailed => "Error al crear una cuenta";

	/// <summary>
	/// Key: "Response.SpaceOrSpecialCharaterError"
	/// Spaces and special characters are not allowed error message
	/// English String: "Spaces and special characters are not allowed."
	/// </summary>
	public override string ResponseSpaceOrSpecialCharaterError => "No se permiten espacios y caracteres especiales.";

	/// <summary>
	/// Key: "Response.TooManyAccountsWithSameEmailError"
	/// Too many accounts use this email error message
	/// English String: "Too many accounts use this email."
	/// </summary>
	public override string ResponseTooManyAccountsWithSameEmailError => "Hay demasiadas cuentas asociadas a este correo electrónico.";

	/// <summary>
	/// Key: "Response.UnknownError"
	/// English String: "Sorry! An unknown error occurred. Please try again later."
	/// </summary>
	public override string ResponseUnknownError => "Lo sentimos, se ha producido un error desconocido. Inténtalo de nuevo más tarde.";

	/// <summary>
	/// Key: "Response.UsernameAllowedCharactersError"
	/// error showing which characters are allowed for username
	/// English String: "Usernames may only contain letters, numbers, and _."
	/// </summary>
	public override string ResponseUsernameAllowedCharactersError => "Los nombres solo pueden contener letras, números y _.";

	/// <summary>
	/// Key: "Response.UsernameAlreadyInUse"
	/// English String: "This username is already in use."
	/// </summary>
	public override string ResponseUsernameAlreadyInUse => "Ese nombre de usuario ya está en uso.";

	/// <summary>
	/// Key: "Response.UsernameExplicit"
	/// English String: "This username is not allowed, please try another."
	/// </summary>
	public override string ResponseUsernameExplicit => "Ese nombre de usuario no está permitido. Inténtalo con otro.";

	/// <summary>
	/// Key: "Response.UsernameInvalid"
	/// English String: "Please enter a valid username."
	/// </summary>
	public override string ResponseUsernameInvalid => "Introduce un nombre de usuario válido.";

	/// <summary>
	/// Key: "Response.UsernameInvalidCharacters"
	/// English String: "Only a-z, A-Z, 0-9 and _ are allowed."
	/// </summary>
	public override string ResponseUsernameInvalidCharacters => "Solo se permiten los caracteres a-z, A-Z, 0-9 y _.";

	/// <summary>
	/// Key: "Response.UsernameInvalidLength"
	/// English String: "Usernames can be 3 to 20 characters long."
	/// </summary>
	public override string ResponseUsernameInvalidLength => "Los nombres de usuario pueden tener entre 3 y 20 caracteres.";

	/// <summary>
	/// Key: "Response.UsernameInvalidUnderscore"
	/// English String: "Usernames cannot start or end with _."
	/// </summary>
	public override string ResponseUsernameInvalidUnderscore => "No puede empezar ni terminar con _.";

	/// <summary>
	/// Key: "Response.UsernameNotAvailable"
	/// English String: "Username not available. Please try again."
	/// </summary>
	public override string ResponseUsernameNotAvailable => "Nombre de usuario no disponible. Inténtalo de nuevo.";

	/// <summary>
	/// Key: "Response.UsernameOrPasswordIncorrect"
	/// Your username or password is incorrect
	/// English String: "Your username or password is incorrect."
	/// </summary>
	public override string ResponseUsernameOrPasswordIncorrect => "Nombre de usuario o contraseña incorrectos.";

	/// <summary>
	/// Key: "Response.UsernamePasswordRequired"
	/// Username and Password are required error message
	/// English String: "Username and Password are required."
	/// </summary>
	public override string ResponseUsernamePasswordRequired => "Es necesario especificar el nombre de usuario y la contraseña.";

	/// <summary>
	/// Key: "Response.UsernamePrivateInfo"
	/// English String: "Username might contain private information."
	/// </summary>
	public override string ResponseUsernamePrivateInfo => "El nombre de usuario podría contener información privada.";

	/// <summary>
	/// Key: "Response.UsernameRequired"
	/// validation error message
	/// English String: "Username is required."
	/// </summary>
	public override string ResponseUsernameRequired => "Es necesario especificar el nombre de usuario.";

	/// <summary>
	/// Key: "Response.UsernameTakenTryAgain"
	/// English String: "This username is already taken! Please try a different one."
	/// </summary>
	public override string ResponseUsernameTakenTryAgain => "Este nombre de usuario ya existe. Intenta otro.";

	/// <summary>
	/// Key: "Response.UsernameTooManyUnderscores"
	/// English String: "Usernames can have at most one _."
	/// </summary>
	public override string ResponseUsernameTooManyUnderscores => "Los nombres de usuario solo pueden tener un _.";

	public SignUpResources_es_es(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionCreateAccount()
	{
		return "Crear cuenta";
	}

	protected override string _GetTemplateForActionLinkAccount()
	{
		return "Vincular cuenta";
	}

	protected override string _GetTemplateForActionLogInCapitalized()
	{
		return "Iniciar sesión";
	}

	protected override string _GetTemplateForActionReturnHome()
	{
		return "Volver a Inicio";
	}

	protected override string _GetTemplateForActionSignUp()
	{
		return "Regístrate";
	}

	protected override string _GetTemplateForActionSignupAndSync()
	{
		return "Registrarse y sincronizar";
	}

	protected override string _GetTemplateForActionSubmit()
	{
		return "Enviar";
	}

	protected override string _GetTemplateForDescriptionAccountLinkingWarning()
	{
		return "Para vincular la cuenta a una existente de Roblox, inicia sesión y ve a la página de configuración de la cuenta.";
	}

	protected override string _GetTemplateForDescriptionNoRealName()
	{
		return "No utilices tu nombre real.";
	}

	protected override string _GetTemplateForDescriptionPrivacyPolicy()
	{
		return "Política de privacidad";
	}

	/// <summary>
	/// Key: "Description.SignUpAgreement"
	/// terms of use agreement checkbox label to signup.
	/// English String: "By clicking {spanStart}Sign Up{spanEnd}, you are agreeing to the {termsOfUseLink} and acknowledging the {privacyPolicyLink}"
	/// </summary>
	public override string DescriptionSignUpAgreement(string spanStart, string spanEnd, string termsOfUseLink, string privacyPolicyLink)
	{
		return $"Al hacer clic en {spanStart}Regístrate{spanEnd}, aceptas los {termsOfUseLink} y la {privacyPolicyLink}.";
	}

	protected override string _GetTemplateForDescriptionSignUpAgreement()
	{
		return "Al hacer clic en {spanStart}Regístrate{spanEnd}, aceptas los {termsOfUseLink} y la {privacyPolicyLink}.";
	}

	protected override string _GetTemplateForDescriptionTermsOfService()
	{
		return "Términos de servicio";
	}

	protected override string _GetTemplateForGuestSignUpABActionSignUp()
	{
		return "Regístrate";
	}

	protected override string _GetTemplateForHeadingConnectFacebook()
	{
		return "Conectar a Facebook";
	}

	protected override string _GetTemplateForHeadingCreateAnAccount()
	{
		return "CREAR UNA CUENTA";
	}

	/// <summary>
	/// Key: "Heading.FacebookSignupAlmostDone"
	/// when user signs up using Facebook, this is shown in next step to create a password.
	/// English String: "{firstname}, YOU'RE ALMOST DONE"
	/// </summary>
	public override string HeadingFacebookSignupAlmostDone(string firstname)
	{
		return $"{firstname}, ya casi hemos terminado.";
	}

	protected override string _GetTemplateForHeadingFacebookSignupAlmostDone()
	{
		return "{firstname}, ya casi hemos terminado.";
	}

	protected override string _GetTemplateForHeadingLoginHaveFun()
	{
		return "¡Inicia sesión y diviértete!";
	}

	protected override string _GetTemplateForHeadingSignupHaveFun()
	{
		return "¡Regístrate y diviértete!";
	}

	protected override string _GetTemplateForLabelAbout()
	{
		return "Acerca de Roblox";
	}

	protected override string _GetTemplateForLabelAlreadyHaveRobloxAccount()
	{
		return "¿Ya tienes una cuenta de Roblox?";
	}

	protected override string _GetTemplateForLabelAlreadyRegistered()
	{
		return "¿Ya te has registrado?";
	}

	protected override string _GetTemplateForLabelBirthday()
	{
		return "Fecha de nacimiento";
	}

	protected override string _GetTemplateForLabelBirthdayWithColumn()
	{
		return "Fecha de nacimiento:";
	}

	protected override string _GetTemplateForLabelConfirmPassword()
	{
		return "Confirmar contraseña";
	}

	protected override string _GetTemplateForLabelDay()
	{
		return "Día";
	}

	protected override string _GetTemplateForLabelDesiredUsername()
	{
		return "Nombre de usuario preferido:";
	}

	protected override string _GetTemplateForLabelFacebookNotLinked()
	{
		return "Tu cuenta de Facebook no está vinculada a ninguna cuenta de Roblox. Regístrate para obtener una cuenta de Roblox.";
	}

	protected override string _GetTemplateForLabelFacebookSignupUsername()
	{
		return "Crear nombre de usuario de Roblox:";
	}

	protected override string _GetTemplateForLabelFemale()
	{
		return "Mujer";
	}

	protected override string _GetTemplateForLabelGender()
	{
		return "Sexo";
	}

	protected override string _GetTemplateForLabelGenderRequired()
	{
		return "Es necesario especificar el sexo.";
	}

	protected override string _GetTemplateForLabelGenderWithColumn()
	{
		return "Sexo:";
	}

	protected override string _GetTemplateForLabelMale()
	{
		return "Hombre";
	}

	protected override string _GetTemplateForLabelMonth()
	{
		return "Mes";
	}

	protected override string _GetTemplateForLabelPassword()
	{
		return "Contraseña";
	}

	protected override string _GetTemplateForLabelPasswordRequirements()
	{
		return "Contraseña (longitud mínima: 8)";
	}

	protected override string _GetTemplateForLabelPlatforms()
	{
		return "Plataformas";
	}

	protected override string _GetTemplateForLabelPlay()
	{
		return "Jugar";
	}

	protected override string _GetTemplateForLabelPleaseAgreeToTerms()
	{
		return "Por favor, acepta nuestros términos de uso y nuestra política de privacidad.";
	}

	protected override string _GetTemplateForLabelRequired()
	{
		return "Necesario";
	}

	protected override string _GetTemplateForLabelSignupButtonText()
	{
		return "¡Regístrate y juega!";
	}

	protected override string _GetTemplateForLabelSignUpWith()
	{
		return "o inicia sesión con";
	}

	protected override string _GetTemplateForLabelTermsOfUse()
	{
		return "Términos de uso";
	}

	protected override string _GetTemplateForLabelUsername()
	{
		return "Usuario";
	}

	protected override string _GetTemplateForLabelUsernameCharacterLimit()
	{
		return "Entre 3 y 20 caracteres alfanuméricos sin espacios.";
	}

	protected override string _GetTemplateForLabelUsernameHint()
	{
		return "Nombre de usuario (nombre ficticio)";
	}

	protected override string _GetTemplateForLabelUsernameRequirements()
	{
		return "Nombre de usuario (de 3 a 20 caracteres)";
	}

	protected override string _GetTemplateForLabelYear()
	{
		return "Año";
	}

	protected override string _GetTemplateForMessagePasswordMinLength()
	{
		return "Longitud mínima: 8";
	}

	protected override string _GetTemplateForMessageUsernameNoRealNameUse()
	{
		return "No utilices tu nombre real";
	}

	protected override string _GetTemplateForResponseBadUsername()
	{
		return "Nombre de usuario inadecuado para Roblox.";
	}

	protected override string _GetTemplateForResponseBadUsernameForWeChat()
	{
		return "El nombre de usuario no es adecuado";
	}

	protected override string _GetTemplateForResponseBirthdayInvalid()
	{
		return "Esta fecha de nacimiento no es válida.";
	}

	protected override string _GetTemplateForResponseBirthdayMustBeSetFirst()
	{
		return "Antes debes determinar tu fecha de nacimiento.";
	}

	protected override string _GetTemplateForResponseCaptchaMismatchError()
	{
		return "Las palabras no coinciden.";
	}

	protected override string _GetTemplateForResponseCaptchaNotEnteredError()
	{
		return "Completa el desafío Captcha";
	}

	protected override string _GetTemplateForResponseFacebookConnectionError()
	{
		return "Error al recuperar valores de Facebook";
	}

	protected override string _GetTemplateForResponseFacebookLoginAge()
	{
		return "Solo los usuarios mayores de 13 años pueden iniciar sesión con Facebook.";
	}

	protected override string _GetTemplateForResponseInvalidBirthday()
	{
		return "Fecha de nacimiento no válida.";
	}

	protected override string _GetTemplateForResponseInvalidEmail()
	{
		return "Dirección de correo electrónico no válida.";
	}

	protected override string _GetTemplateForResponseJavaScriptRequired()
	{
		return "Se requiere JavaScript para enviar este formulario.";
	}

	protected override string _GetTemplateForResponsePasswordComplexity()
	{
		return "Crea una contraseña más complicada.";
	}

	protected override string _GetTemplateForResponsePasswordConfirmation()
	{
		return "Introduce la confirmación de la contraseña.";
	}

	protected override string _GetTemplateForResponsePasswordContainsUsernameError()
	{
		return "La contraseña y el nombre de usuario no pueden coincidir.";
	}

	protected override string _GetTemplateForResponsePasswordMismatch()
	{
		return "Las contraseñas no coinciden.";
	}

	protected override string _GetTemplateForResponsePasswordWrongShort()
	{
		return "La contraseña debe tener al menos 8 caracteres.";
	}

	protected override string _GetTemplateForResponsePleaseEnterPassword()
	{
		return "Introduce una contraseña.";
	}

	protected override string _GetTemplateForResponsePleaseEnterUsername()
	{
		return "Introduce un nombre de usuario.";
	}

	protected override string _GetTemplateForResponseSocialAccountCreationFailed()
	{
		return "Error al crear una cuenta";
	}

	protected override string _GetTemplateForResponseSpaceOrSpecialCharaterError()
	{
		return "No se permiten espacios y caracteres especiales.";
	}

	protected override string _GetTemplateForResponseTooManyAccountsWithSameEmailError()
	{
		return "Hay demasiadas cuentas asociadas a este correo electrónico.";
	}

	protected override string _GetTemplateForResponseUnknownError()
	{
		return "Lo sentimos, se ha producido un error desconocido. Inténtalo de nuevo más tarde.";
	}

	protected override string _GetTemplateForResponseUsernameAllowedCharactersError()
	{
		return "Los nombres solo pueden contener letras, números y _.";
	}

	protected override string _GetTemplateForResponseUsernameAlreadyInUse()
	{
		return "Ese nombre de usuario ya está en uso.";
	}

	protected override string _GetTemplateForResponseUsernameExplicit()
	{
		return "Ese nombre de usuario no está permitido. Inténtalo con otro.";
	}

	protected override string _GetTemplateForResponseUsernameInvalid()
	{
		return "Introduce un nombre de usuario válido.";
	}

	protected override string _GetTemplateForResponseUsernameInvalidCharacters()
	{
		return "Solo se permiten los caracteres a-z, A-Z, 0-9 y _.";
	}

	protected override string _GetTemplateForResponseUsernameInvalidLength()
	{
		return "Los nombres de usuario pueden tener entre 3 y 20 caracteres.";
	}

	protected override string _GetTemplateForResponseUsernameInvalidUnderscore()
	{
		return "No puede empezar ni terminar con _.";
	}

	protected override string _GetTemplateForResponseUsernameNotAvailable()
	{
		return "Nombre de usuario no disponible. Inténtalo de nuevo.";
	}

	protected override string _GetTemplateForResponseUsernameOrPasswordIncorrect()
	{
		return "Nombre de usuario o contraseña incorrectos.";
	}

	protected override string _GetTemplateForResponseUsernamePasswordRequired()
	{
		return "Es necesario especificar el nombre de usuario y la contraseña.";
	}

	protected override string _GetTemplateForResponseUsernamePrivateInfo()
	{
		return "El nombre de usuario podría contener información privada.";
	}

	protected override string _GetTemplateForResponseUsernameRequired()
	{
		return "Es necesario especificar el nombre de usuario.";
	}

	protected override string _GetTemplateForResponseUsernameTakenTryAgain()
	{
		return "Este nombre de usuario ya existe. Intenta otro.";
	}

	protected override string _GetTemplateForResponseUsernameTooManyUnderscores()
	{
		return "Los nombres de usuario solo pueden tener un _.";
	}
}
