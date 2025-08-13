namespace Roblox.TranslationResources.Authentication;

/// <summary>
/// This class overrides SignUpResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class SignUpResources_fr_fr : SignUpResources_en_us, ISignUpResources, ITranslationResources
{
	/// <summary>
	/// Key: "Action.CreateAccount"
	/// create account button label
	/// English String: "Create Account"
	/// </summary>
	public override string ActionCreateAccount => "Créer un compte";

	/// <summary>
	/// Key: "Action.LinkAccount"
	/// Button text to link 3rd Party Account to a Roblox Account
	/// English String: "Link Account"
	/// </summary>
	public override string ActionLinkAccount => "Lier le compte";

	/// <summary>
	/// Key: "Action.LogInCapitalized"
	/// button label for capitalized words for Log In
	/// English String: "Log In"
	/// </summary>
	public override string ActionLogInCapitalized => "Connexion";

	/// <summary>
	/// Key: "Action.ReturnHome"
	/// button label to return the user to home page
	/// English String: "Return Home"
	/// </summary>
	public override string ActionReturnHome => "Retour à l'accueil";

	/// <summary>
	/// Key: "Action.SignUp"
	/// English String: "Sign up"
	/// </summary>
	public override string ActionSignUp => "S'inscrire";

	public override string ActionSignupAndSync => "S'inscrire et synchroniser";

	/// <summary>
	/// Key: "Action.Submit"
	/// English String: "Submit"
	/// </summary>
	public override string ActionSubmit => "Soumettre";

	/// <summary>
	/// Key: "Description.AccountLinkingWarning"
	/// instructions for linking account on signup page for FB based account
	/// English String: "To link to an existing Roblox account, sign in and link them on the account settings page."
	/// </summary>
	public override string DescriptionAccountLinkingWarning => "Pour créer un lien avec un compte Roblox existant, inscrivez-vous et liez-les sur la page des paramètres du compte.";

	/// <summary>
	/// Key: "Description.NoRealName"
	/// description
	/// English String: "Do not use your real name."
	/// </summary>
	public override string DescriptionNoRealName => "Veuillez ne pas utiliser votre vrai nom.";

	/// <summary>
	/// Key: "Description.PrivacyPolicy"
	/// English String: "Privacy Policy"
	/// </summary>
	public override string DescriptionPrivacyPolicy => "Politique de confidentialité";

	/// <summary>
	/// Key: "Description.TermsOfService"
	/// English String: "Terms of Service"
	/// </summary>
	public override string DescriptionTermsOfService => "Conditions d'utilisation";

	/// <summary>
	/// Key: "GuestSignUpAB.Action.SignUp"
	/// English String: "Sign Up"
	/// </summary>
	public override string GuestSignUpABActionSignUp => "S'inscrire";

	/// <summary>
	/// Key: "Heading.ConnectFacebook"
	/// section heading
	/// English String: "Connect to Facebook"
	/// </summary>
	public override string HeadingConnectFacebook => "Connexion à Facebook";

	/// <summary>
	/// Key: "Heading.CreateAnAccount"
	/// should be capitalized if the language supports capitalization
	/// English String: "CREATE AN ACCOUNT"
	/// </summary>
	public override string HeadingCreateAnAccount => "CRÉER UN COMPTE";

	/// <summary>
	/// Key: "Heading.LoginHaveFun"
	/// heading for login container
	/// English String: "Log in and start having fun!"
	/// </summary>
	public override string HeadingLoginHaveFun => "Connectez-vous et amusez-vous\u00a0!";

	/// <summary>
	/// Key: "Heading.SignupHaveFun"
	/// signup form heading
	/// English String: "Sign up and start having fun!"
	/// </summary>
	public override string HeadingSignupHaveFun => "Inscrivez-vous et amusez-vous\u00a0!";

	/// <summary>
	/// Key: "Label.About"
	/// About link on roller coaster page
	/// English String: "About"
	/// </summary>
	public override string LabelAbout => "À propos de";

	/// <summary>
	/// Key: "Label.AlreadyHaveRobloxAccount"
	/// English String: "Already have a Roblox account?"
	/// </summary>
	public override string LabelAlreadyHaveRobloxAccount => "Vous avez déjà un compte ROBLOX\u00a0?";

	/// <summary>
	/// Key: "Label.AlreadyRegistered"
	/// label
	/// English String: "Already registered?"
	/// </summary>
	public override string LabelAlreadyRegistered => "Déjà inscrit(e)\u00a0?";

	/// <summary>
	/// Key: "Label.Birthday"
	/// English String: "Birthday"
	/// </summary>
	public override string LabelBirthday => "Date anniversaire";

	/// <summary>
	/// Key: "Label.BirthdayWithColumn"
	/// should have column if the language supports it
	/// English String: "Birthday:"
	/// </summary>
	public override string LabelBirthdayWithColumn => "Anniversaire\u00a0:";

	/// <summary>
	/// Key: "Label.ConfirmPassword"
	/// English String: "Confirm password"
	/// </summary>
	public override string LabelConfirmPassword => "Confirmer le mot de passe";

	/// <summary>
	/// Key: "Label.Day"
	/// English String: "Day"
	/// </summary>
	public override string LabelDay => "Jour";

	/// <summary>
	/// Key: "Label.DesiredUsername"
	/// should have a column if the language supports it
	/// English String: "Desired Username:"
	/// </summary>
	public override string LabelDesiredUsername => "Nom d'utilisateur souhaité\u00a0:";

	/// <summary>
	/// Key: "Label.FacebookNotLinked"
	/// English String: "Your Facebook account is not linked to any Roblox account. Please sign up for a Roblox account."
	/// </summary>
	public override string LabelFacebookNotLinked => "Votre compte Facebook n'est associé à aucun compte Roblox. Veuillez créer un compte Roblox.";

	/// <summary>
	/// Key: "Label.FacebookSignupUsername"
	/// username field label for FB signup
	/// English String: "Create Roblox username:"
	/// </summary>
	public override string LabelFacebookSignupUsername => "Créez un nom d'utilisateur Roblox\u00a0:";

	/// <summary>
	/// Key: "Label.Female"
	/// label
	/// English String: "Female"
	/// </summary>
	public override string LabelFemale => "Femme";

	/// <summary>
	/// Key: "Label.Gender"
	/// English String: "Gender"
	/// </summary>
	public override string LabelGender => "Genre";

	/// <summary>
	/// Key: "Label.GenderRequired"
	/// English String: "Gender is required."
	/// </summary>
	public override string LabelGenderRequired => "Le genre est requis.";

	/// <summary>
	/// Key: "Label.GenderWithColumn"
	/// should have column if the language supports it
	/// English String: "Gender:"
	/// </summary>
	public override string LabelGenderWithColumn => "Genre\u00a0:";

	/// <summary>
	/// Key: "Label.Male"
	/// label
	/// English String: "Male"
	/// </summary>
	public override string LabelMale => "Homme";

	/// <summary>
	/// Key: "Label.Month"
	/// English String: "Month"
	/// </summary>
	public override string LabelMonth => "Mois";

	/// <summary>
	/// Key: "Label.Password"
	/// English String: "Password"
	/// </summary>
	public override string LabelPassword => "Mot de passe";

	/// <summary>
	/// Key: "Label.PasswordRequirements"
	/// English String: "Password (min length 8)"
	/// </summary>
	public override string LabelPasswordRequirements => "Mot de passe (min 8\u00a0caractères)";

	/// <summary>
	/// Key: "Label.Platforms"
	/// platforms link on roller coaster page
	/// English String: "Platforms"
	/// </summary>
	public override string LabelPlatforms => "Plateformes";

	/// <summary>
	/// Key: "Label.Play"
	/// Play link on roller coaster page
	/// English String: "Play"
	/// </summary>
	public override string LabelPlay => "Jouer";

	/// <summary>
	/// Key: "Label.PleaseAgreeToTerms"
	/// English String: "Please agree to our Terms of Use and Privacy Policy."
	/// </summary>
	public override string LabelPleaseAgreeToTerms => "Veuillez accepter nos Conditions d'utilisation et notre Politique de confidentialité.";

	/// <summary>
	/// Key: "Label.Required"
	/// Required
	/// English String: "Required"
	/// </summary>
	public override string LabelRequired => "Requis";

	/// <summary>
	/// Key: "Label.SignupButtonText"
	/// sign up button text
	/// English String: "Sign Up and Play!"
	/// </summary>
	public override string LabelSignupButtonText => "Inscrivez-vous et jouez\u00a0!";

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
	public override string LabelSignUpWith => "ou connecte-toi avec";

	/// <summary>
	/// Key: "Label.TermsOfUse"
	/// terms of use link label
	/// English String: "Terms of Use"
	/// </summary>
	public override string LabelTermsOfUse => "Conditions d'utilisation";

	/// <summary>
	/// Key: "Label.Username"
	/// English String: "Username"
	/// </summary>
	public override string LabelUsername => "Nom d'utilisateur";

	/// <summary>
	/// Key: "Label.UsernameCharacterLimit"
	/// label
	/// English String: "3-20 alphanumeric characters, no spaces."
	/// </summary>
	public override string LabelUsernameCharacterLimit => "3\u00a0à 20\u00a0caractères alphanumériques, aucun espace.";

	/// <summary>
	/// Key: "Label.UsernameHint"
	/// placeholder for username field
	/// English String: "Username (don't use your real name)"
	/// </summary>
	public override string LabelUsernameHint => "Nom d'utilisateur (n'utilisez pas votre véritable nom)";

	/// <summary>
	/// Key: "Label.UsernameRequirements"
	/// English String: "Username (length 3-20, _ is allowed)"
	/// </summary>
	public override string LabelUsernameRequirements => "Nom d'utilisateur (3 à 20\u00a0caractères, _ autorisé)";

	/// <summary>
	/// Key: "Label.Year"
	/// English String: "Year"
	/// </summary>
	public override string LabelYear => "Année";

	/// <summary>
	/// Key: "Message.Password.MinLength"
	/// English String: "Min length 8"
	/// </summary>
	public override string MessagePasswordMinLength => "Longueur min 8";

	/// <summary>
	/// Key: "Message.Username.NoRealNameUse"
	/// English String: "Don't use your real name"
	/// </summary>
	public override string MessageUsernameNoRealNameUse => "Veuillez ne pas utiliser votre vrai nom";

	/// <summary>
	/// Key: "Response.BadUsername"
	/// English String: "Username not appropriate for Roblox."
	/// </summary>
	public override string ResponseBadUsername => "Nom d'utilisateur inapproprié pour Roblox.";

	/// <summary>
	/// Key: "Response.BadUsernameForWeChat"
	/// message shown when signing up with an inappropriate username
	/// English String: "Username is not appropriate"
	/// </summary>
	public override string ResponseBadUsernameForWeChat => "Nom d'utilisateur inapproprié";

	/// <summary>
	/// Key: "Response.BirthdayInvalid"
	/// English String: "This birthday is invalid."
	/// </summary>
	public override string ResponseBirthdayInvalid => "Cette date de naissance est invalide.";

	/// <summary>
	/// Key: "Response.BirthdayMustBeSetFirst"
	/// English String: "Birthday must be set first."
	/// </summary>
	public override string ResponseBirthdayMustBeSetFirst => "La date anniversaire doit d'abord être saisie.";

	/// <summary>
	/// Key: "Response.CaptchaMismatchError"
	/// error message
	/// English String: "Words do not match."
	/// </summary>
	public override string ResponseCaptchaMismatchError => "Les mots ne correspondent pas.";

	/// <summary>
	/// Key: "Response.CaptchaNotEnteredError"
	/// validation error message
	/// English String: "Please fill out the Captcha"
	/// </summary>
	public override string ResponseCaptchaNotEnteredError => "Veuillez saisir le CAPTCHA.";

	/// <summary>
	/// Key: "Response.FacebookConnectionError"
	/// error message
	/// English String: "Error while retrieving values from Facebook."
	/// </summary>
	public override string ResponseFacebookConnectionError => "Erreur durant la récupération des données de Facebook";

	/// <summary>
	/// Key: "Response.FacebookLoginAge"
	/// English String: "Facebook login can only be used by users above 13."
	/// </summary>
	public override string ResponseFacebookLoginAge => "L'identification Facebook ne peut être utilisée que par les joueurs de plus de 13\u00a0ans.";

	/// <summary>
	/// Key: "Response.InvalidBirthday"
	/// English String: "Invalid birthday."
	/// </summary>
	public override string ResponseInvalidBirthday => "Date d'anniversaire invalide.";

	/// <summary>
	/// Key: "Response.InvalidEmail"
	/// English String: "Invalid email address."
	/// </summary>
	public override string ResponseInvalidEmail => "Adresse e-mail invalide.";

	/// <summary>
	/// Key: "Response.JavaScriptRequired"
	/// error to show that JavaScipt is required for the form to work
	/// English String: "JavaScript is required to submit this form."
	/// </summary>
	public override string ResponseJavaScriptRequired => "JavaScript est nécessaire pour envoyer ce formulaire.";

	/// <summary>
	/// Key: "Response.PasswordComplexity"
	/// English String: "Please create a more complex password."
	/// </summary>
	public override string ResponsePasswordComplexity => "Veuillez créer un mot de passe plus complexe.";

	/// <summary>
	/// Key: "Response.PasswordConfirmation"
	/// validation message for password confirmation
	/// English String: "Please enter a password confirmation."
	/// </summary>
	public override string ResponsePasswordConfirmation => "Veuillez saisir une confirmation de mot de passe.";

	/// <summary>
	/// Key: "Response.PasswordContainsUsernameError"
	/// error when passsword has username in it
	/// English String: "Password shouldn't match username."
	/// </summary>
	public override string ResponsePasswordContainsUsernameError => "Le mot de passe ne devrait pas être identique au nom d'utilisateur.";

	/// <summary>
	/// Key: "Response.PasswordMismatch"
	/// English String: "Passwords do not match."
	/// </summary>
	public override string ResponsePasswordMismatch => "Les mots de passe ne correspondent pas.";

	/// <summary>
	/// Key: "Response.PasswordWrongShort"
	/// English String: "Passwords must be at least 8 characters long."
	/// </summary>
	public override string ResponsePasswordWrongShort => "8 caractères minimum sont nécessaires.";

	/// <summary>
	/// Key: "Response.PleaseEnterPassword"
	/// English String: "Please enter a password."
	/// </summary>
	public override string ResponsePleaseEnterPassword => "Veuillez saisir un mot de passe.";

	/// <summary>
	/// Key: "Response.PleaseEnterUsername"
	/// English String: "Please enter a username."
	/// </summary>
	public override string ResponsePleaseEnterUsername => "Veuillez saisir un nom d'utilisateur.";

	/// <summary>
	/// Key: "Response.SocialAccountCreationFailed"
	/// error message
	/// English String: "Account creation failed"
	/// </summary>
	public override string ResponseSocialAccountCreationFailed => "Création de compte échouée";

	/// <summary>
	/// Key: "Response.SpaceOrSpecialCharaterError"
	/// Spaces and special characters are not allowed error message
	/// English String: "Spaces and special characters are not allowed."
	/// </summary>
	public override string ResponseSpaceOrSpecialCharaterError => "Les espaces et caractères spéciaux ne sont pas autorisés.";

	/// <summary>
	/// Key: "Response.TooManyAccountsWithSameEmailError"
	/// Too many accounts use this email error message
	/// English String: "Too many accounts use this email."
	/// </summary>
	public override string ResponseTooManyAccountsWithSameEmailError => "Trop de comptes utilisent cette adresse e-mail.";

	/// <summary>
	/// Key: "Response.UnknownError"
	/// English String: "Sorry! An unknown error occurred. Please try again later."
	/// </summary>
	public override string ResponseUnknownError => "Désolé\u00a0! Une erreur inconnue est survenue. Veuillez réessayer plus tard.";

	/// <summary>
	/// Key: "Response.UsernameAllowedCharactersError"
	/// error showing which characters are allowed for username
	/// English String: "Usernames may only contain letters, numbers, and _."
	/// </summary>
	public override string ResponseUsernameAllowedCharactersError => "Les noms d'utilisateur ne peuvent contenir que des lettres, des chiffres et _.";

	/// <summary>
	/// Key: "Response.UsernameAlreadyInUse"
	/// English String: "This username is already in use."
	/// </summary>
	public override string ResponseUsernameAlreadyInUse => "Ce nom d'utilisateur est déjà pris.";

	/// <summary>
	/// Key: "Response.UsernameExplicit"
	/// English String: "This username is not allowed, please try another."
	/// </summary>
	public override string ResponseUsernameExplicit => "Ce nom d'utilisateur n'est pas autorisé.";

	/// <summary>
	/// Key: "Response.UsernameInvalid"
	/// English String: "Please enter a valid username."
	/// </summary>
	public override string ResponseUsernameInvalid => "Veuillez saisir un nom d'utilisateur valide.";

	/// <summary>
	/// Key: "Response.UsernameInvalidCharacters"
	/// English String: "Only a-z, A-Z, 0-9 and _ are allowed."
	/// </summary>
	public override string ResponseUsernameInvalidCharacters => "Seuls a-z, A-Z, 0-9 et _ sont autorisés.";

	/// <summary>
	/// Key: "Response.UsernameInvalidLength"
	/// English String: "Usernames can be 3 to 20 characters long."
	/// </summary>
	public override string ResponseUsernameInvalidLength => "Les noms d'utilisateur peuvent comporter entre 3 et 20\u00a0caractères.";

	/// <summary>
	/// Key: "Response.UsernameInvalidUnderscore"
	/// English String: "Usernames cannot start or end with _."
	/// </summary>
	public override string ResponseUsernameInvalidUnderscore => "Les noms ne peuvent ni commencer, ni finir par _.";

	/// <summary>
	/// Key: "Response.UsernameNotAvailable"
	/// English String: "Username not available. Please try again."
	/// </summary>
	public override string ResponseUsernameNotAvailable => "Nom d'utilisateur indisponible. Veuillez réessayer plus tard.";

	/// <summary>
	/// Key: "Response.UsernameOrPasswordIncorrect"
	/// Your username or password is incorrect
	/// English String: "Your username or password is incorrect."
	/// </summary>
	public override string ResponseUsernameOrPasswordIncorrect => "Votre nom d'utilisateur et/ou votre mot de passe sont invalides.";

	/// <summary>
	/// Key: "Response.UsernamePasswordRequired"
	/// Username and Password are required error message
	/// English String: "Username and Password are required."
	/// </summary>
	public override string ResponseUsernamePasswordRequired => "Le nom d'utilisateur et le mot de passe sont requis.";

	/// <summary>
	/// Key: "Response.UsernamePrivateInfo"
	/// English String: "Username might contain private information."
	/// </summary>
	public override string ResponseUsernamePrivateInfo => "Le nom d'utilisateur pourrait contenir des informations personnelles.";

	/// <summary>
	/// Key: "Response.UsernameRequired"
	/// validation error message
	/// English String: "Username is required."
	/// </summary>
	public override string ResponseUsernameRequired => "Un nom d'utilisateur est requis.";

	/// <summary>
	/// Key: "Response.UsernameTakenTryAgain"
	/// English String: "This username is already taken! Please try a different one."
	/// </summary>
	public override string ResponseUsernameTakenTryAgain => "Ce nom d'utilisateur est déjà pris !";

	/// <summary>
	/// Key: "Response.UsernameTooManyUnderscores"
	/// English String: "Usernames can have at most one _."
	/// </summary>
	public override string ResponseUsernameTooManyUnderscores => "Les noms ne peuvent contenir plus d'un _.";

	public SignUpResources_fr_fr(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionCreateAccount()
	{
		return "Créer un compte";
	}

	protected override string _GetTemplateForActionLinkAccount()
	{
		return "Lier le compte";
	}

	protected override string _GetTemplateForActionLogInCapitalized()
	{
		return "Connexion";
	}

	protected override string _GetTemplateForActionReturnHome()
	{
		return "Retour à l'accueil";
	}

	protected override string _GetTemplateForActionSignUp()
	{
		return "S'inscrire";
	}

	protected override string _GetTemplateForActionSignupAndSync()
	{
		return "S'inscrire et synchroniser";
	}

	protected override string _GetTemplateForActionSubmit()
	{
		return "Soumettre";
	}

	protected override string _GetTemplateForDescriptionAccountLinkingWarning()
	{
		return "Pour créer un lien avec un compte Roblox existant, inscrivez-vous et liez-les sur la page des paramètres du compte.";
	}

	protected override string _GetTemplateForDescriptionNoRealName()
	{
		return "Veuillez ne pas utiliser votre vrai nom.";
	}

	protected override string _GetTemplateForDescriptionPrivacyPolicy()
	{
		return "Politique de confidentialité";
	}

	/// <summary>
	/// Key: "Description.SignUpAgreement"
	/// terms of use agreement checkbox label to signup.
	/// English String: "By clicking {spanStart}Sign Up{spanEnd}, you are agreeing to the {termsOfUseLink} and acknowledging the {privacyPolicyLink}"
	/// </summary>
	public override string DescriptionSignUpAgreement(string spanStart, string spanEnd, string termsOfUseLink, string privacyPolicyLink)
	{
		return $"En cliquant sur {spanStart}S'inscrire{spanEnd}, vous acceptez les {termsOfUseLink} et la {privacyPolicyLink}";
	}

	protected override string _GetTemplateForDescriptionSignUpAgreement()
	{
		return "En cliquant sur {spanStart}S'inscrire{spanEnd}, vous acceptez les {termsOfUseLink} et la {privacyPolicyLink}";
	}

	protected override string _GetTemplateForDescriptionTermsOfService()
	{
		return "Conditions d'utilisation";
	}

	protected override string _GetTemplateForGuestSignUpABActionSignUp()
	{
		return "S'inscrire";
	}

	protected override string _GetTemplateForHeadingConnectFacebook()
	{
		return "Connexion à Facebook";
	}

	protected override string _GetTemplateForHeadingCreateAnAccount()
	{
		return "CRÉER UN COMPTE";
	}

	/// <summary>
	/// Key: "Heading.FacebookSignupAlmostDone"
	/// when user signs up using Facebook, this is shown in next step to create a password.
	/// English String: "{firstname}, YOU'RE ALMOST DONE"
	/// </summary>
	public override string HeadingFacebookSignupAlmostDone(string firstname)
	{
		return $"{firstname}, VOUS AVEZ PRESQUE TERMINÉ";
	}

	protected override string _GetTemplateForHeadingFacebookSignupAlmostDone()
	{
		return "{firstname}, VOUS AVEZ PRESQUE TERMINÉ";
	}

	protected override string _GetTemplateForHeadingLoginHaveFun()
	{
		return "Connectez-vous et amusez-vous\u00a0!";
	}

	protected override string _GetTemplateForHeadingSignupHaveFun()
	{
		return "Inscrivez-vous et amusez-vous\u00a0!";
	}

	protected override string _GetTemplateForLabelAbout()
	{
		return "À propos de";
	}

	protected override string _GetTemplateForLabelAlreadyHaveRobloxAccount()
	{
		return "Vous avez déjà un compte ROBLOX\u00a0?";
	}

	protected override string _GetTemplateForLabelAlreadyRegistered()
	{
		return "Déjà inscrit(e)\u00a0?";
	}

	protected override string _GetTemplateForLabelBirthday()
	{
		return "Date anniversaire";
	}

	protected override string _GetTemplateForLabelBirthdayWithColumn()
	{
		return "Anniversaire\u00a0:";
	}

	protected override string _GetTemplateForLabelConfirmPassword()
	{
		return "Confirmer le mot de passe";
	}

	protected override string _GetTemplateForLabelDay()
	{
		return "Jour";
	}

	protected override string _GetTemplateForLabelDesiredUsername()
	{
		return "Nom d'utilisateur souhaité\u00a0:";
	}

	protected override string _GetTemplateForLabelFacebookNotLinked()
	{
		return "Votre compte Facebook n'est associé à aucun compte Roblox. Veuillez créer un compte Roblox.";
	}

	protected override string _GetTemplateForLabelFacebookSignupUsername()
	{
		return "Créez un nom d'utilisateur Roblox\u00a0:";
	}

	protected override string _GetTemplateForLabelFemale()
	{
		return "Femme";
	}

	protected override string _GetTemplateForLabelGender()
	{
		return "Genre";
	}

	protected override string _GetTemplateForLabelGenderRequired()
	{
		return "Le genre est requis.";
	}

	protected override string _GetTemplateForLabelGenderWithColumn()
	{
		return "Genre\u00a0:";
	}

	protected override string _GetTemplateForLabelMale()
	{
		return "Homme";
	}

	protected override string _GetTemplateForLabelMonth()
	{
		return "Mois";
	}

	protected override string _GetTemplateForLabelPassword()
	{
		return "Mot de passe";
	}

	protected override string _GetTemplateForLabelPasswordRequirements()
	{
		return "Mot de passe (min 8\u00a0caractères)";
	}

	protected override string _GetTemplateForLabelPlatforms()
	{
		return "Plateformes";
	}

	protected override string _GetTemplateForLabelPlay()
	{
		return "Jouer";
	}

	protected override string _GetTemplateForLabelPleaseAgreeToTerms()
	{
		return "Veuillez accepter nos Conditions d'utilisation et notre Politique de confidentialité.";
	}

	protected override string _GetTemplateForLabelRequired()
	{
		return "Requis";
	}

	protected override string _GetTemplateForLabelSignupButtonText()
	{
		return "Inscrivez-vous et jouez\u00a0!";
	}

	protected override string _GetTemplateForLabelSignUpWith()
	{
		return "ou connecte-toi avec";
	}

	protected override string _GetTemplateForLabelTermsOfUse()
	{
		return "Conditions d'utilisation";
	}

	protected override string _GetTemplateForLabelUsername()
	{
		return "Nom d'utilisateur";
	}

	protected override string _GetTemplateForLabelUsernameCharacterLimit()
	{
		return "3\u00a0à 20\u00a0caractères alphanumériques, aucun espace.";
	}

	protected override string _GetTemplateForLabelUsernameHint()
	{
		return "Nom d'utilisateur (n'utilisez pas votre véritable nom)";
	}

	protected override string _GetTemplateForLabelUsernameRequirements()
	{
		return "Nom d'utilisateur (3 à 20\u00a0caractères, _ autorisé)";
	}

	protected override string _GetTemplateForLabelYear()
	{
		return "Année";
	}

	protected override string _GetTemplateForMessagePasswordMinLength()
	{
		return "Longueur min 8";
	}

	protected override string _GetTemplateForMessageUsernameNoRealNameUse()
	{
		return "Veuillez ne pas utiliser votre vrai nom";
	}

	protected override string _GetTemplateForResponseBadUsername()
	{
		return "Nom d'utilisateur inapproprié pour Roblox.";
	}

	protected override string _GetTemplateForResponseBadUsernameForWeChat()
	{
		return "Nom d'utilisateur inapproprié";
	}

	protected override string _GetTemplateForResponseBirthdayInvalid()
	{
		return "Cette date de naissance est invalide.";
	}

	protected override string _GetTemplateForResponseBirthdayMustBeSetFirst()
	{
		return "La date anniversaire doit d'abord être saisie.";
	}

	protected override string _GetTemplateForResponseCaptchaMismatchError()
	{
		return "Les mots ne correspondent pas.";
	}

	protected override string _GetTemplateForResponseCaptchaNotEnteredError()
	{
		return "Veuillez saisir le CAPTCHA.";
	}

	protected override string _GetTemplateForResponseFacebookConnectionError()
	{
		return "Erreur durant la récupération des données de Facebook";
	}

	protected override string _GetTemplateForResponseFacebookLoginAge()
	{
		return "L'identification Facebook ne peut être utilisée que par les joueurs de plus de 13\u00a0ans.";
	}

	protected override string _GetTemplateForResponseInvalidBirthday()
	{
		return "Date d'anniversaire invalide.";
	}

	protected override string _GetTemplateForResponseInvalidEmail()
	{
		return "Adresse e-mail invalide.";
	}

	protected override string _GetTemplateForResponseJavaScriptRequired()
	{
		return "JavaScript est nécessaire pour envoyer ce formulaire.";
	}

	protected override string _GetTemplateForResponsePasswordComplexity()
	{
		return "Veuillez créer un mot de passe plus complexe.";
	}

	protected override string _GetTemplateForResponsePasswordConfirmation()
	{
		return "Veuillez saisir une confirmation de mot de passe.";
	}

	protected override string _GetTemplateForResponsePasswordContainsUsernameError()
	{
		return "Le mot de passe ne devrait pas être identique au nom d'utilisateur.";
	}

	protected override string _GetTemplateForResponsePasswordMismatch()
	{
		return "Les mots de passe ne correspondent pas.";
	}

	protected override string _GetTemplateForResponsePasswordWrongShort()
	{
		return "8 caractères minimum sont nécessaires.";
	}

	protected override string _GetTemplateForResponsePleaseEnterPassword()
	{
		return "Veuillez saisir un mot de passe.";
	}

	protected override string _GetTemplateForResponsePleaseEnterUsername()
	{
		return "Veuillez saisir un nom d'utilisateur.";
	}

	protected override string _GetTemplateForResponseSocialAccountCreationFailed()
	{
		return "Création de compte échouée";
	}

	protected override string _GetTemplateForResponseSpaceOrSpecialCharaterError()
	{
		return "Les espaces et caractères spéciaux ne sont pas autorisés.";
	}

	protected override string _GetTemplateForResponseTooManyAccountsWithSameEmailError()
	{
		return "Trop de comptes utilisent cette adresse e-mail.";
	}

	protected override string _GetTemplateForResponseUnknownError()
	{
		return "Désolé\u00a0! Une erreur inconnue est survenue. Veuillez réessayer plus tard.";
	}

	protected override string _GetTemplateForResponseUsernameAllowedCharactersError()
	{
		return "Les noms d'utilisateur ne peuvent contenir que des lettres, des chiffres et _.";
	}

	protected override string _GetTemplateForResponseUsernameAlreadyInUse()
	{
		return "Ce nom d'utilisateur est déjà pris.";
	}

	protected override string _GetTemplateForResponseUsernameExplicit()
	{
		return "Ce nom d'utilisateur n'est pas autorisé.";
	}

	protected override string _GetTemplateForResponseUsernameInvalid()
	{
		return "Veuillez saisir un nom d'utilisateur valide.";
	}

	protected override string _GetTemplateForResponseUsernameInvalidCharacters()
	{
		return "Seuls a-z, A-Z, 0-9 et _ sont autorisés.";
	}

	protected override string _GetTemplateForResponseUsernameInvalidLength()
	{
		return "Les noms d'utilisateur peuvent comporter entre 3 et 20\u00a0caractères.";
	}

	protected override string _GetTemplateForResponseUsernameInvalidUnderscore()
	{
		return "Les noms ne peuvent ni commencer, ni finir par _.";
	}

	protected override string _GetTemplateForResponseUsernameNotAvailable()
	{
		return "Nom d'utilisateur indisponible. Veuillez réessayer plus tard.";
	}

	protected override string _GetTemplateForResponseUsernameOrPasswordIncorrect()
	{
		return "Votre nom d'utilisateur et/ou votre mot de passe sont invalides.";
	}

	protected override string _GetTemplateForResponseUsernamePasswordRequired()
	{
		return "Le nom d'utilisateur et le mot de passe sont requis.";
	}

	protected override string _GetTemplateForResponseUsernamePrivateInfo()
	{
		return "Le nom d'utilisateur pourrait contenir des informations personnelles.";
	}

	protected override string _GetTemplateForResponseUsernameRequired()
	{
		return "Un nom d'utilisateur est requis.";
	}

	protected override string _GetTemplateForResponseUsernameTakenTryAgain()
	{
		return "Ce nom d'utilisateur est déjà pris !";
	}

	protected override string _GetTemplateForResponseUsernameTooManyUnderscores()
	{
		return "Les noms ne peuvent contenir plus d'un _.";
	}
}
