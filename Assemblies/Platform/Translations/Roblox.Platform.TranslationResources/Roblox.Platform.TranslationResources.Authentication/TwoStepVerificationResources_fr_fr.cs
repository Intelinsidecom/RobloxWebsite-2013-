namespace Roblox.TranslationResources.Authentication;

/// <summary>
/// This class overrides TwoStepVerificationResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class TwoStepVerificationResources_fr_fr : TwoStepVerificationResources_en_us, ITwoStepVerificationResources, ITranslationResources
{
	/// <summary>
	/// Key: "Action.Cancel"
	/// English String: "Cancel"
	/// </summary>
	public override string ActionCancel => "Annuler";

	/// <summary>
	/// Key: "Action.Resend"
	/// English String: "Resend Code"
	/// </summary>
	public override string ActionResend => "Renvoyer le code";

	/// <summary>
	/// Key: "Action.StartOver"
	/// link text to restart verification
	/// English String: "Start Over"
	/// </summary>
	public override string ActionStartOver => "Redémarrer";

	/// <summary>
	/// Key: "Action.Submit"
	/// submit button text
	/// English String: "Submit"
	/// </summary>
	public override string ActionSubmit => "Soumettre";

	/// <summary>
	/// Key: "Action.Verify"
	/// English String: "Verify"
	/// </summary>
	public override string ActionVerify => "Vérifier";

	/// <summary>
	/// Key: "Label.Code"
	/// verification code for 2 factor authentication
	/// English String: "Code"
	/// </summary>
	public override string LabelCode => "Code";

	/// <summary>
	/// Key: "Label.DidNotReceive"
	/// English String: "Didn't receive the code?"
	/// </summary>
	public override string LabelDidNotReceive => "Code non reçu\u00a0?";

	/// <summary>
	/// Key: "Label.EnterCode"
	/// English String: "Enter Code (6-digit)"
	/// </summary>
	public override string LabelEnterCode => "Saisir le code (6 chiffres)";

	/// <summary>
	/// Key: "Label.EnterEmailCode"
	/// English String: "Enter the code we just sent you via email"
	/// </summary>
	public override string LabelEnterEmailCode => "Saisissez le code que nous venons de vous envoyer par e-mail.";

	/// <summary>
	/// Key: "Label.EnterTextCode"
	/// English String: "Enter the code we just sent you via text message"
	/// </summary>
	public override string LabelEnterTextCode => "Saisissez le code que nous venons de vous envoyer par SMS.";

	/// <summary>
	/// Key: "Label.EnterTwoStepVerificationCode"
	/// Enter your two step verification code.
	/// English String: "Enter your two step verification code."
	/// </summary>
	public override string LabelEnterTwoStepVerificationCode => "Saisissez votre code de vérification en 2\u00a0étapes.";

	/// <summary>
	/// Key: "Label.FacebookPasswordWarning"
	/// If you have been signing in with Facebook, you must set a password.
	/// English String: "If you have been signing in with Facebook, you must set a password."
	/// </summary>
	public override string LabelFacebookPasswordWarning => "Si vous vous connectez via Facebook, vous devez définir un mot de passe.";

	/// <summary>
	/// Key: "Label.LearnMore"
	/// Learn More link text
	/// English String: "Learn More"
	/// </summary>
	public override string LabelLearnMore => "En savoir plus";

	/// <summary>
	/// Key: "Label.NewCode"
	/// verification code resent, label changes to new code
	/// English String: "New Code"
	/// </summary>
	public override string LabelNewCode => "Nouveau code";

	/// <summary>
	/// Key: "Label.RobloxSupport"
	/// English String: "Roblox Support"
	/// </summary>
	public override string LabelRobloxSupport => "Assistance Roblox";

	/// <summary>
	/// Key: "Label.TrustThisDevice"
	/// English String: "Trust this device for 30 days"
	/// </summary>
	public override string LabelTrustThisDevice => "Faire confiance à cet appareil pendant 30\u00a0jours";

	/// <summary>
	/// Key: "Label.TwoStepVerification"
	/// English String: "2-Step Verification"
	/// </summary>
	public override string LabelTwoStepVerification => "Vérification en 2\u00a0étapes";

	/// <summary>
	/// Key: "Response.CodeSent"
	/// English String: "Code Sent"
	/// </summary>
	public override string ResponseCodeSent => "Code envoyé";

	/// <summary>
	/// Key: "Response.FeatureNotAvailable"
	/// English String: "Feature not available. Please contact support."
	/// </summary>
	public override string ResponseFeatureNotAvailable => "Fonctionnalité non disponible. Veuillez contacter l'assistance.";

	/// <summary>
	/// Key: "Response.InvalidCode"
	/// English String: "Invalid code."
	/// </summary>
	public override string ResponseInvalidCode => "Code invalide.";

	/// <summary>
	/// Key: "Response.SystemErrorReturnToLogin"
	/// English String: "System error. Please return to login screen."
	/// </summary>
	public override string ResponseSystemErrorReturnToLogin => "Erreur système. Veuillez revenir à l'écran de connexion.";

	/// <summary>
	/// Key: "Response.TooManyAttempts"
	/// English String: "Too many attempts. Please try again later."
	/// </summary>
	public override string ResponseTooManyAttempts => "Trop de tentatives. Veuillez réessayer plus tard.";

	/// <summary>
	/// Key: "Response.TooManyCharacters"
	/// error message
	/// English String: "Too many characters"
	/// </summary>
	public override string ResponseTooManyCharacters => "Trop de caractères";

	public TwoStepVerificationResources_fr_fr(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionCancel()
	{
		return "Annuler";
	}

	protected override string _GetTemplateForActionResend()
	{
		return "Renvoyer le code";
	}

	protected override string _GetTemplateForActionStartOver()
	{
		return "Redémarrer";
	}

	protected override string _GetTemplateForActionSubmit()
	{
		return "Soumettre";
	}

	protected override string _GetTemplateForActionVerify()
	{
		return "Vérifier";
	}

	/// <summary>
	/// Key: "Description.TwoStepVerificationActivationEmail.Body.Over13"
	/// Body for 2SV activation email for over 13 users
	/// English String: "Hi {accountName},{lineBreak}{lineBreak}You have activated 2-Step Verification for your Roblox account. Next time you log in from a new device, you will need to enter a 6-digit security code that Roblox sends to you via email.{lineBreak}{lineBreak}Roblox"
	/// </summary>
	public override string DescriptionTwoStepVerificationActivationEmailBodyOver13(string accountName, string lineBreak)
	{
		return $"Bonjour {accountName},{lineBreak}{lineBreak}La vérification en 2\u00a0étapes a été activée pour votre compte Roblox. Lors de votre prochaine connexion depuis un appareil non reconnu, il vous faudra saisir le code de sécurité à 6\u00a0chiffres joint par e-mail.{lineBreak}{lineBreak}Roblox";
	}

	protected override string _GetTemplateForDescriptionTwoStepVerificationActivationEmailBodyOver13()
	{
		return "Bonjour {accountName},{lineBreak}{lineBreak}La vérification en 2\u00a0étapes a été activée pour votre compte Roblox. Lors de votre prochaine connexion depuis un appareil non reconnu, il vous faudra saisir le code de sécurité à 6\u00a0chiffres joint par e-mail.{lineBreak}{lineBreak}Roblox";
	}

	/// <summary>
	/// Key: "Description.TwoStepVerificationActivationEmail.Body.Under13"
	/// Body for 2SV activation email for under 13 users
	/// English String: "Hi,{lineBreak}{lineBreak}2-Step Verification has been activated for your child's Roblox account, {accountName}. Next time they log in from a new device, they will need to enter a 6-digit security code that Roblox sends to you via email.{lineBreak}{lineBreak}Roblox"
	/// </summary>
	public override string DescriptionTwoStepVerificationActivationEmailBodyUnder13(string lineBreak, string accountName)
	{
		return $"Bonjour,{lineBreak}{lineBreak}La vérification en 2\u00a0étapes a été activée pour le compte Roblox de votre enfant, {accountName}. Lors de sa prochaine connexion depuis un appareil non reconnu, il faudra saisir le code de sécurité à 6\u00a0chiffres joint par e-mail.{lineBreak}{lineBreak}Roblox";
	}

	protected override string _GetTemplateForDescriptionTwoStepVerificationActivationEmailBodyUnder13()
	{
		return "Bonjour,{lineBreak}{lineBreak}La vérification en 2\u00a0étapes a été activée pour le compte Roblox de votre enfant, {accountName}. Lors de sa prochaine connexion depuis un appareil non reconnu, il faudra saisir le code de sécurité à 6\u00a0chiffres joint par e-mail.{lineBreak}{lineBreak}Roblox";
	}

	/// <summary>
	/// Key: "Description.TwoStepVerificationActivationEmail.Subject"
	/// Subject for 2SV activation email
	/// English String: "2-Step Verification Activated for Roblox Account: {accountName}"
	/// </summary>
	public override string DescriptionTwoStepVerificationActivationEmailSubject(string accountName)
	{
		return $"Vérification en 2\u00a0étapes activée pour le compte Roblox\u00a0: {accountName}";
	}

	protected override string _GetTemplateForDescriptionTwoStepVerificationActivationEmailSubject()
	{
		return "Vérification en 2\u00a0étapes activée pour le compte Roblox\u00a0: {accountName}";
	}

	/// <summary>
	/// Key: "Description.TwoStepVerificationDeactivationEmail.Body.Over13"
	/// Body for 2SV deactivation email for over 13 users
	/// English String: "Hi {accountName},{lineBreak}{lineBreak}You have deactivated 2-Step Verification for your Roblox account. A security code will no longer be required when you log into your account.{lineBreak}{lineBreak}Roblox"
	/// </summary>
	public override string DescriptionTwoStepVerificationDeactivationEmailBodyOver13(string accountName, string lineBreak)
	{
		return $"Bonjour {accountName},{lineBreak}{lineBreak}. Vous avez désactivé la vérification en 2\u00a0étapes pour votre compte Roblox. Un code de sécurité ne sera dorénavant plus requis pour vous connecter.{lineBreak}{lineBreak}Roblox";
	}

	protected override string _GetTemplateForDescriptionTwoStepVerificationDeactivationEmailBodyOver13()
	{
		return "Bonjour {accountName},{lineBreak}{lineBreak}. Vous avez désactivé la vérification en 2\u00a0étapes pour votre compte Roblox. Un code de sécurité ne sera dorénavant plus requis pour vous connecter.{lineBreak}{lineBreak}Roblox";
	}

	/// <summary>
	/// Key: "Description.TwoStepVerificationDeactivationEmail.Body.Under13"
	/// Body for 2SV deactivation email for under 13 users
	/// English String: "Hi,{lineBreak}{lineBreak}2-Step Verification has been deactivated for your child's Roblox account, {accountName}. A security code will no longer be required when they log into the account.{lineBreak}{lineBreak}Roblox"
	/// </summary>
	public override string DescriptionTwoStepVerificationDeactivationEmailBodyUnder13(string lineBreak, string accountName)
	{
		return $"Bonjour,{lineBreak}{lineBreak}. Vous avez désactivé la vérification en 2\u00a0étapes pour le compte Roblox de votre enfant, {accountName}. Un code de sécurité ne sera dorénavant plus requis pour se connecter.{lineBreak}{lineBreak}Roblox";
	}

	protected override string _GetTemplateForDescriptionTwoStepVerificationDeactivationEmailBodyUnder13()
	{
		return "Bonjour,{lineBreak}{lineBreak}. Vous avez désactivé la vérification en 2\u00a0étapes pour le compte Roblox de votre enfant, {accountName}. Un code de sécurité ne sera dorénavant plus requis pour se connecter.{lineBreak}{lineBreak}Roblox";
	}

	/// <summary>
	/// Key: "Description.TwoStepVerificationDeactivationEmail.Subject	"
	/// Subject for 2SV deactivation email
	/// English String: "2-Step Verification Deactivated for Roblox Account: {accountName}"
	/// </summary>
	public override string DescriptionTwoStepVerificationDeactivationEmailSubject(string accountName)
	{
		return $"Vérification en 2\u00a0étapes désactivée pour le compte Roblox\u00a0: {accountName}";
	}

	protected override string _GetTemplateForDescriptionTwoStepVerificationDeactivationEmailSubject()
	{
		return "Vérification en 2\u00a0étapes désactivée pour le compte Roblox\u00a0: {accountName}";
	}

	/// <summary>
	/// Key: "Description.TwoStepVerificationLoginEmail.Html.GeolocationInfo1"
	/// Geolocation information about IP trying to login
	/// English String: "{spanStartTagWithBold}Login request received from {username} located in {region}, {country} ({ipAddress}).{spanEndTag}{lineBreak}{lineBreak}"
	/// </summary>
	public override string DescriptionTwoStepVerificationLoginEmailHtmlGeolocationInfo1(string spanStartTagWithBold, string username, string region, string country, string ipAddress, string spanEndTag, string lineBreak)
	{
		return $"{spanStartTagWithBold}Requête de connexion reçue de la part de {username} situé ici\u00a0: {region}, {country} ({ipAddress}).{spanEndTag}{lineBreak}{lineBreak}";
	}

	protected override string _GetTemplateForDescriptionTwoStepVerificationLoginEmailHtmlGeolocationInfo1()
	{
		return "{spanStartTagWithBold}Requête de connexion reçue de la part de {username} situé ici\u00a0: {region}, {country} ({ipAddress}).{spanEndTag}{lineBreak}{lineBreak}";
	}

	/// <summary>
	/// Key: "Description.TwoStepVerificationLoginEmail.Html.GeolocationInfo2"
	/// Geolocation info about IP trying to login
	/// English String: "{spanStartTagWithBold}Login request received from {username} located in {country} ({ipAddress}).{spanEndTag}{lineBreak}{lineBreak}\t"
	/// </summary>
	public override string DescriptionTwoStepVerificationLoginEmailHtmlGeolocationInfo2(string spanStartTagWithBold, string username, string country, string ipAddress, string spanEndTag, string lineBreak)
	{
		return $"{spanStartTagWithBold}Requête de connexion reçue de la part de {username} situé ici\u00a0: {country} ({ipAddress}).{spanEndTag}{lineBreak}{lineBreak}\t";
	}

	protected override string _GetTemplateForDescriptionTwoStepVerificationLoginEmailHtmlGeolocationInfo2()
	{
		return "{spanStartTagWithBold}Requête de connexion reçue de la part de {username} situé ici\u00a0: {country} ({ipAddress}).{spanEndTag}{lineBreak}{lineBreak}\t";
	}

	/// <summary>
	/// Key: "Description.TwoStepVerificationLoginEmail.Html.GeolocationInfo3"
	/// Geolocation info about IP trying to log in
	/// English String: "{spanStartTagWithBold}Login request received from {username} (From Roblox Internal).{spanEndTag}{lineBreak}{lineBreak}\t"
	/// </summary>
	public override string DescriptionTwoStepVerificationLoginEmailHtmlGeolocationInfo3(string spanStartTagWithBold, string username, string spanEndTag, string lineBreak)
	{
		return $"{spanStartTagWithBold}Requête de connexion reçue de la part de {username} (en interne chez Roblox).{spanEndTag}{lineBreak}{lineBreak}\t";
	}

	protected override string _GetTemplateForDescriptionTwoStepVerificationLoginEmailHtmlGeolocationInfo3()
	{
		return "{spanStartTagWithBold}Requête de connexion reçue de la part de {username} (en interne chez Roblox).{spanEndTag}{lineBreak}{lineBreak}\t";
	}

	/// <summary>
	/// Key: "Description.TwoStepVerificationLoginEmail.Html.GeolocationInfo4"
	/// Geolocation info of IP trying to login
	/// English String: "{spanStartTagWithBold}Login request received from {username} located in {country}.{spanEndTag}{lineBreak}{lineBreak}"
	/// </summary>
	public override string DescriptionTwoStepVerificationLoginEmailHtmlGeolocationInfo4(string spanStartTagWithBold, string username, string country, string spanEndTag, string lineBreak)
	{
		return $"{spanStartTagWithBold}Requête de connexion reçue de la part de {username} situé ici\u00a0: {country}.{spanEndTag}{lineBreak}{lineBreak}";
	}

	protected override string _GetTemplateForDescriptionTwoStepVerificationLoginEmailHtmlGeolocationInfo4()
	{
		return "{spanStartTagWithBold}Requête de connexion reçue de la part de {username} situé ici\u00a0: {country}.{spanEndTag}{lineBreak}{lineBreak}";
	}

	/// <summary>
	/// Key: "Description.TwoStepVerificationLoginEmail.Html.GeolocationInfo5"
	/// Geolocation info of IP trying to login
	/// English String: "{spanStartTagWithBold}Login request received from {username} located in {region}, {country}.{spanEndTag}{lineBreak}{lineBreak}"
	/// </summary>
	public override string DescriptionTwoStepVerificationLoginEmailHtmlGeolocationInfo5(string spanStartTagWithBold, string username, string region, string country, string spanEndTag, string lineBreak)
	{
		return $"{spanStartTagWithBold}Requête de connexion reçue de la part de {username} situé ici\u00a0: {region}, {country}.{spanEndTag}{lineBreak}{lineBreak}";
	}

	protected override string _GetTemplateForDescriptionTwoStepVerificationLoginEmailHtmlGeolocationInfo5()
	{
		return "{spanStartTagWithBold}Requête de connexion reçue de la part de {username} situé ici\u00a0: {region}, {country}.{spanEndTag}{lineBreak}{lineBreak}";
	}

	/// <summary>
	/// Key: "Description.TwoStepVerificationLoginEmail.Html.GeolocationInfo6"
	/// Geolocation info of IP trying to login
	/// English String: "{spanStartTagWithBold}Login request received from {username} located in {city}, {region}, {country}.{spanEndTag}{lineBreak}{lineBreak}"
	/// </summary>
	public override string DescriptionTwoStepVerificationLoginEmailHtmlGeolocationInfo6(string spanStartTagWithBold, string username, string city, string region, string country, string spanEndTag, string lineBreak)
	{
		return $"{spanStartTagWithBold}Requête de connexion reçue de la part de {username} situé ici\u00a0: {city}, {region}, {country}.{spanEndTag}{lineBreak}{lineBreak}";
	}

	protected override string _GetTemplateForDescriptionTwoStepVerificationLoginEmailHtmlGeolocationInfo6()
	{
		return "{spanStartTagWithBold}Requête de connexion reçue de la part de {username} situé ici\u00a0: {city}, {region}, {country}.{spanEndTag}{lineBreak}{lineBreak}";
	}

	/// <summary>
	/// Key: "Description.TwoStepVerificationLoginEmail.HtmlBody"
	/// Html body for 2SV login email
	/// English String: "{geoLocationInformation}{spanStartTagWithBold}Login code for {accountName}: {lineBreak}{lineBreak}{code} {spanEndTag}{lineBreak}{lineBreak}Enter this code into the 2-Step Verification screen to finish logging in. This code will expire in 15 minutes.{lineBreak}{lineBreak}This email was sent because your account tried to login to Roblox from a new browser or device. If you haven't tried logging into Roblox, someone else may be trying to access your account. You are strongly advised to change your password if you did not generate this request.{lineBreak}{lineBreak}Resources:{lineBreak}{aTagStartWithHref}{ChangePasswordLink}{hrefEnd}Change Your Password{aTagEnd} {lineBreak}{aTagStartWithHref}{TwoStepVerificationArticleLink}{hrefEnd}Learn More About 2-Step Verification{aTagEnd} {lineBreak}{aTagStartWithHref}{AccountSafetyArticleLink}{hrefEnd}Keeping Your Account Safe{aTagEnd} {lineBreak}{aTagStartWithHref}{SupportLink}{hrefEnd}General Roblox Support{aTagEnd} {lineBreak}{lineBreak}Thank you,{lineBreak}{lineBreak}The Roblox Team"
	/// </summary>
	public override string DescriptionTwoStepVerificationLoginEmailHtmlBody(string geoLocationInformation, string spanStartTagWithBold, string accountName, string lineBreak, string code, string spanEndTag, string aTagStartWithHref, string ChangePasswordLink, string hrefEnd, string aTagEnd, string TwoStepVerificationArticleLink, string AccountSafetyArticleLink, string SupportLink)
	{
		return $"{geoLocationInformation}{spanStartTagWithBold}Code d'identification pour {accountName}\u00a0: {lineBreak}{lineBreak}{code} {spanEndTag}{lineBreak}{lineBreak}Saisissez ce code à l'écran de vérification en 2\u00a0étapes pour terminer la connexion. Ce code arriver à expiration dans 15\u00a0minutes.{lineBreak}{lineBreak}Vous recevez cet e-mail en raison d'une tentative de connexion de votre compte à Roblox à partir d'un nouveau navigateur ou d'un autre appareil. Si vous n'êtes pas à l'origine de cette tentative, il se peut que l'on essaie d'accéder à votre compte. Nous vous recommandons fortement de changer de mot de passe si vous n'êtes pas l'auteur de cette requête.{lineBreak}{lineBreak}Ressources\u00a0:{lineBreak}{aTagStartWithHref}{ChangePasswordLink}{hrefEnd}Changer de mot de passe{aTagEnd} {lineBreak}{aTagStartWithHref}{TwoStepVerificationArticleLink}{hrefEnd}En savoir plus sur la vérification en 2\u00a0étapes{aTagEnd} {lineBreak}{aTagStartWithHref}{AccountSafetyArticleLink}{hrefEnd}Maintenir la sécurité de son compte{aTagEnd} {lineBreak}{aTagStartWithHref}{SupportLink}{hrefEnd}Assistance générale Roblox{aTagEnd} {lineBreak}{lineBreak}Merci,{lineBreak}{lineBreak}L'équipe Roblox";
	}

	protected override string _GetTemplateForDescriptionTwoStepVerificationLoginEmailHtmlBody()
	{
		return "{geoLocationInformation}{spanStartTagWithBold}Code d'identification pour {accountName}\u00a0: {lineBreak}{lineBreak}{code} {spanEndTag}{lineBreak}{lineBreak}Saisissez ce code à l'écran de vérification en 2\u00a0étapes pour terminer la connexion. Ce code arriver à expiration dans 15\u00a0minutes.{lineBreak}{lineBreak}Vous recevez cet e-mail en raison d'une tentative de connexion de votre compte à Roblox à partir d'un nouveau navigateur ou d'un autre appareil. Si vous n'êtes pas à l'origine de cette tentative, il se peut que l'on essaie d'accéder à votre compte. Nous vous recommandons fortement de changer de mot de passe si vous n'êtes pas l'auteur de cette requête.{lineBreak}{lineBreak}Ressources\u00a0:{lineBreak}{aTagStartWithHref}{ChangePasswordLink}{hrefEnd}Changer de mot de passe{aTagEnd} {lineBreak}{aTagStartWithHref}{TwoStepVerificationArticleLink}{hrefEnd}En savoir plus sur la vérification en 2\u00a0étapes{aTagEnd} {lineBreak}{aTagStartWithHref}{AccountSafetyArticleLink}{hrefEnd}Maintenir la sécurité de son compte{aTagEnd} {lineBreak}{aTagStartWithHref}{SupportLink}{hrefEnd}Assistance générale Roblox{aTagEnd} {lineBreak}{lineBreak}Merci,{lineBreak}{lineBreak}L'équipe Roblox";
	}

	/// <summary>
	/// Key: "Description.TwoStepVerificationLoginEmail.PlainBody"
	/// Plain body for 2SV login email
	/// English String: "{geoLocationInformation}Login code for {accountName}: {lineBreak}{lineBreak} {code} {lineBreak}{lineBreak}Enter this code into the 2-Step Verification screen to finish logging in. This code will expire in 15 minutes. {lineBreak}{lineBreak}This email was sent because your account tried to login to Roblox from a new browser or device. If you haven't tried logging into Roblox, someone else may be trying to access your account. You are strongly advised to change your password if you did not generate this request. {lineBreak}{lineBreak}Resources: {lineBreak}Change Your Password [{accountInfoPageLink}] {lineBreak}Learn More About 2-Step Verification [{twoStepVerificationHelpArticleLink}]{lineBreak}Keeping Your Account Safe [{keepAccountSafeArticleLink}] {lineBreak}General Roblox Support [{supportPageLink}] {lineBreak}{lineBreak}Thank you, {lineBreak}{lineBreak}The Roblox Team"
	/// </summary>
	public override string DescriptionTwoStepVerificationLoginEmailPlainBody(string geoLocationInformation, string accountName, string lineBreak, string code, string accountInfoPageLink, string twoStepVerificationHelpArticleLink, string keepAccountSafeArticleLink, string supportPageLink)
	{
		return $"{geoLocationInformation}Code d'identification pour {accountName}\u00a0: {lineBreak}{lineBreak}{code} {lineBreak}{lineBreak}Saisissez ce code à l'écran de vérification en 2\u00a0étapes pour terminer la connexion. Ce code arriver à expiration dans 15\u00a0minutes.{lineBreak}{lineBreak}Vous recevez cet e-mail en raison d'une tentative de connexion de votre compte à Roblox à partir d'un nouveau navigateur ou d'un autre appareil. Si vous n'êtes pas à l'origine de cette tentative, il se peut que l'on essaie d'accéder à votre compte. Nous vous recommandons fortement de changer de mot de passe si vous n'êtes pas l'auteur de cette requête.{lineBreak}{lineBreak}Ressources\u00a0:{lineBreak}Changer de mot de passe [{accountInfoPageLink}] {lineBreak}En savoir plus sur la vérification en 2\u00a0étapes [{twoStepVerificationHelpArticleLink}] {lineBreak}Maintenir la sécurité de son compte [{keepAccountSafeArticleLink}] {lineBreak}Assistance générale Roblox [{supportPageLink}] {lineBreak}{lineBreak}Merci,{lineBreak}{lineBreak}L'équipe Roblox";
	}

	protected override string _GetTemplateForDescriptionTwoStepVerificationLoginEmailPlainBody()
	{
		return "{geoLocationInformation}Code d'identification pour {accountName}\u00a0: {lineBreak}{lineBreak}{code} {lineBreak}{lineBreak}Saisissez ce code à l'écran de vérification en 2\u00a0étapes pour terminer la connexion. Ce code arriver à expiration dans 15\u00a0minutes.{lineBreak}{lineBreak}Vous recevez cet e-mail en raison d'une tentative de connexion de votre compte à Roblox à partir d'un nouveau navigateur ou d'un autre appareil. Si vous n'êtes pas à l'origine de cette tentative, il se peut que l'on essaie d'accéder à votre compte. Nous vous recommandons fortement de changer de mot de passe si vous n'êtes pas l'auteur de cette requête.{lineBreak}{lineBreak}Ressources\u00a0:{lineBreak}Changer de mot de passe [{accountInfoPageLink}] {lineBreak}En savoir plus sur la vérification en 2\u00a0étapes [{twoStepVerificationHelpArticleLink}] {lineBreak}Maintenir la sécurité de son compte [{keepAccountSafeArticleLink}] {lineBreak}Assistance générale Roblox [{supportPageLink}] {lineBreak}{lineBreak}Merci,{lineBreak}{lineBreak}L'équipe Roblox";
	}

	/// <summary>
	/// Key: "Description.TwoStepVerificationLoginEmail.PlainText.GeolocationInfo1"
	/// GeoLocation info of IP trying to login
	/// English String: "Login request received from {username} located in {region}, {country} ({ipAddress}).{lineBreak}{lineBreak}"
	/// </summary>
	public override string DescriptionTwoStepVerificationLoginEmailPlainTextGeolocationInfo1(string username, string region, string country, string ipAddress, string lineBreak)
	{
		return $"Requête de connexion reçue de la part de {username} situé ici\u00a0: {region}, {country} ({ipAddress}).{lineBreak}{lineBreak}";
	}

	protected override string _GetTemplateForDescriptionTwoStepVerificationLoginEmailPlainTextGeolocationInfo1()
	{
		return "Requête de connexion reçue de la part de {username} situé ici\u00a0: {region}, {country} ({ipAddress}).{lineBreak}{lineBreak}";
	}

	/// <summary>
	/// Key: "Description.TwoStepVerificationLoginEmail.PlainText.GeolocationInfo2"
	/// Geolocation info of IP trying to login
	/// English String: "Login request received from {username} located in {country} ({ipAddress}).{lineBreak}{lineBreak}"
	/// </summary>
	public override string DescriptionTwoStepVerificationLoginEmailPlainTextGeolocationInfo2(string username, string country, string ipAddress, string lineBreak)
	{
		return $"Requête de connexion reçue de la part de {username} situé ici\u00a0: {country} ({ipAddress}).{lineBreak}{lineBreak}";
	}

	protected override string _GetTemplateForDescriptionTwoStepVerificationLoginEmailPlainTextGeolocationInfo2()
	{
		return "Requête de connexion reçue de la part de {username} situé ici\u00a0: {country} ({ipAddress}).{lineBreak}{lineBreak}";
	}

	/// <summary>
	/// Key: "Description.TwoStepVerificationLoginEmail.PlainText.GeolocationInfo3"
	/// Geolocation info of IP trying to login
	/// English String: "Login request received from {username} (From Roblox Internal).{lineBreak}{lineBreak}"
	/// </summary>
	public override string DescriptionTwoStepVerificationLoginEmailPlainTextGeolocationInfo3(string username, string lineBreak)
	{
		return $"Requête de connexion reçue de la part de {username} (en interne chez Roblox).{lineBreak}{lineBreak}";
	}

	protected override string _GetTemplateForDescriptionTwoStepVerificationLoginEmailPlainTextGeolocationInfo3()
	{
		return "Requête de connexion reçue de la part de {username} (en interne chez Roblox).{lineBreak}{lineBreak}";
	}

	/// <summary>
	/// Key: "Description.TwoStepVerificationLoginEmail.PlainText.GeolocationInfo4"
	/// Geolocation info of IP trying to login
	/// English String: "Login request received from {username} located in {country}.{lineBreak}{lineBreak}"
	/// </summary>
	public override string DescriptionTwoStepVerificationLoginEmailPlainTextGeolocationInfo4(string username, string country, string lineBreak)
	{
		return $"Requête de connexion reçue de la part de {username} situé ici\u00a0: {country}.{lineBreak} {lineBreak}";
	}

	protected override string _GetTemplateForDescriptionTwoStepVerificationLoginEmailPlainTextGeolocationInfo4()
	{
		return "Requête de connexion reçue de la part de {username} situé ici\u00a0: {country}.{lineBreak} {lineBreak}";
	}

	/// <summary>
	/// Key: "Description.TwoStepVerificationLoginEmail.PlainText.GeolocationInfo5"
	/// Geolocation info of IP trying to login
	/// English String: "Login request received from {username} located in {region}, {country}.{lineBreak}{lineBreak}"
	/// </summary>
	public override string DescriptionTwoStepVerificationLoginEmailPlainTextGeolocationInfo5(string username, string region, string country, string lineBreak)
	{
		return $"Requête de connexion reçue de la part de {username} situé ici\u00a0: {region}, {country}.{lineBreak}{lineBreak}";
	}

	protected override string _GetTemplateForDescriptionTwoStepVerificationLoginEmailPlainTextGeolocationInfo5()
	{
		return "Requête de connexion reçue de la part de {username} situé ici\u00a0: {region}, {country}.{lineBreak}{lineBreak}";
	}

	/// <summary>
	/// Key: "Description.TwoStepVerificationLoginEmail.PlainText.GeolocationInfo6"
	/// Geolocation info of IP trying to login
	/// English String: "Login request received from {username} located in {city}, {region}, {country}.{lineBreak}{lineBreak}"
	/// </summary>
	public override string DescriptionTwoStepVerificationLoginEmailPlainTextGeolocationInfo6(string username, string city, string region, string country, string lineBreak)
	{
		return $"Requête de connexion reçue de la part de {username} situé ici\u00a0: {city}, {region}, {country}.{lineBreak}{lineBreak}";
	}

	protected override string _GetTemplateForDescriptionTwoStepVerificationLoginEmailPlainTextGeolocationInfo6()
	{
		return "Requête de connexion reçue de la part de {username} situé ici\u00a0: {city}, {region}, {country}.{lineBreak}{lineBreak}";
	}

	/// <summary>
	/// Key: "Description.TwoStepVerificationLoginEmail.Subject"
	/// Subject for 2SV login email
	/// English String: "Verification Code for Roblox Account: {accountName}"
	/// </summary>
	public override string DescriptionTwoStepVerificationLoginEmailSubject(string accountName)
	{
		return $"Code de vérification du compte Roblox\u00a0: {accountName}";
	}

	protected override string _GetTemplateForDescriptionTwoStepVerificationLoginEmailSubject()
	{
		return "Code de vérification du compte Roblox\u00a0: {accountName}";
	}

	protected override string _GetTemplateForLabelCode()
	{
		return "Code";
	}

	/// <summary>
	/// Key: "Label.CodeInputPlaceholderText"
	/// example: Enter 4-digit code
	/// English String: "Enter {codeLength}-digit Code"
	/// </summary>
	public override string LabelCodeInputPlaceholderText(string codeLength)
	{
		return $"Saisir le code à {codeLength}\u00a0chiffres{codeLength}";
	}

	protected override string _GetTemplateForLabelCodeInputPlaceholderText()
	{
		return "Saisir le code à {codeLength}\u00a0chiffres{codeLength}";
	}

	protected override string _GetTemplateForLabelDidNotReceive()
	{
		return "Code non reçu\u00a0?";
	}

	protected override string _GetTemplateForLabelEnterCode()
	{
		return "Saisir le code (6 chiffres)";
	}

	protected override string _GetTemplateForLabelEnterEmailCode()
	{
		return "Saisissez le code que nous venons de vous envoyer par e-mail.";
	}

	protected override string _GetTemplateForLabelEnterTextCode()
	{
		return "Saisissez le code que nous venons de vous envoyer par SMS.";
	}

	protected override string _GetTemplateForLabelEnterTwoStepVerificationCode()
	{
		return "Saisissez votre code de vérification en 2\u00a0étapes.";
	}

	protected override string _GetTemplateForLabelFacebookPasswordWarning()
	{
		return "Si vous vous connectez via Facebook, vous devez définir un mot de passe.";
	}

	protected override string _GetTemplateForLabelLearnMore()
	{
		return "En savoir plus";
	}

	/// <summary>
	/// Key: "Label.NeedHelpContactSupport"
	/// label for the support article link
	/// English String: "Need help? Contact {supportLink}"
	/// </summary>
	public override string LabelNeedHelpContactSupport(string supportLink)
	{
		return $"Besoin d'aide\u00a0? Contactez {supportLink}";
	}

	protected override string _GetTemplateForLabelNeedHelpContactSupport()
	{
		return "Besoin d'aide\u00a0? Contactez {supportLink}";
	}

	protected override string _GetTemplateForLabelNewCode()
	{
		return "Nouveau code";
	}

	protected override string _GetTemplateForLabelRobloxSupport()
	{
		return "Assistance Roblox";
	}

	protected override string _GetTemplateForLabelTrustThisDevice()
	{
		return "Faire confiance à cet appareil pendant 30\u00a0jours";
	}

	protected override string _GetTemplateForLabelTwoStepVerification()
	{
		return "Vérification en 2\u00a0étapes";
	}

	protected override string _GetTemplateForResponseCodeSent()
	{
		return "Code envoyé";
	}

	protected override string _GetTemplateForResponseFeatureNotAvailable()
	{
		return "Fonctionnalité non disponible. Veuillez contacter l'assistance.";
	}

	protected override string _GetTemplateForResponseInvalidCode()
	{
		return "Code invalide.";
	}

	protected override string _GetTemplateForResponseSystemErrorReturnToLogin()
	{
		return "Erreur système. Veuillez revenir à l'écran de connexion.";
	}

	protected override string _GetTemplateForResponseTooManyAttempts()
	{
		return "Trop de tentatives. Veuillez réessayer plus tard.";
	}

	protected override string _GetTemplateForResponseTooManyCharacters()
	{
		return "Trop de caractères";
	}
}
