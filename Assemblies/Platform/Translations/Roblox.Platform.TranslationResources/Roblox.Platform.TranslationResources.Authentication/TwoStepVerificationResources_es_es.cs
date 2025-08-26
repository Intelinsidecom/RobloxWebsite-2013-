namespace Roblox.Platform.TranslationResources.Authentication {
    /// <summary>

/// This class overrides TwoStepVerificationResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class TwoStepVerificationResources_es_es : TwoStepVerificationResources_en_us, ITwoStepVerificationResources, ITranslationResources
{
	/// <summary>
	/// Key: "Action.Cancel"
	/// English String: "Cancel"
	/// </summary>
	public override string ActionCancel => "Cancelar";

	/// <summary>
	/// Key: "Action.Resend"
	/// English String: "Resend Code"
	/// </summary>
	public override string ActionResend => "Reenviar cÃ³digo";

	/// <summary>
	/// Key: "Action.StartOver"
	/// link text to restart verification
	/// English String: "Start Over"
	/// </summary>
	public override string ActionStartOver => "Volver a empezar";

	/// <summary>
	/// Key: "Action.Submit"
	/// submit button text
	/// English String: "Submit"
	/// </summary>
	public override string ActionSubmit => "Enviar";

	/// <summary>
	/// Key: "Action.Verify"
	/// English String: "Verify"
	/// </summary>
	public override string ActionVerify => "Verificar";

	/// <summary>
	/// Key: "Label.Code"
	/// verification code for 2 factor authentication
	/// English String: "Code"
	/// </summary>
	public override string LabelCode => "CÃ³digo";

	/// <summary>
	/// Key: "Label.DidNotReceive"
	/// English String: "Didn't receive the code?"
	/// </summary>
	public override string LabelDidNotReceive => "Â¿No has recibido el cÃ³digo?";

	/// <summary>
	/// Key: "Label.EnterCode"
	/// English String: "Enter Code (6-digit)"
	/// </summary>
	public override string LabelEnterCode => "Introduce el cÃ³digo (6 dÃ­gitos)";

	/// <summary>
	/// Key: "Label.EnterEmailCode"
	/// English String: "Enter the code we just sent you via email"
	/// </summary>
	public override string LabelEnterEmailCode => "Introduce el cÃ³digo que te acabamos de enviar por correo electrÃ³nico";

	/// <summary>
	/// Key: "Label.EnterTextCode"
	/// English String: "Enter the code we just sent you via text message"
	/// </summary>
	public override string LabelEnterTextCode => "Introduce el cÃ³digo que te acabamos de enviar por mensaje de texto.";

	/// <summary>
	/// Key: "Label.EnterTwoStepVerificationCode"
	/// Enter your two step verification code.
	/// English String: "Enter your two step verification code."
	/// </summary>
	public override string LabelEnterTwoStepVerificationCode => "Introduce el cÃ³digo de verificaciÃ³n en dos pasos.";

	/// <summary>
	/// Key: "Label.FacebookPasswordWarning"
	/// If you have been signing in with Facebook, you must set a password.
	/// English String: "If you have been signing in with Facebook, you must set a password."
	/// </summary>
	public override string LabelFacebookPasswordWarning => "Si has estado iniciando sesiÃ³n con Facebook, debes establecer una contraseÃ±a.";

	/// <summary>
	/// Key: "Label.LearnMore"
	/// Learn More link text
	/// English String: "Learn More"
	/// </summary>
	public override string LabelLearnMore => "MÃ¡s informaciÃ³n";

	/// <summary>
	/// Key: "Label.NewCode"
	/// verification code resent, label changes to new code
	/// English String: "New Code"
	/// </summary>
	public override string LabelNewCode => "Nuevo cÃ³digo";

	/// <summary>
	/// Key: "Label.RobloxSupport"
	/// English String: "Roblox Support"
	/// </summary>
	public override string LabelRobloxSupport => "Asistencia tÃ©cnica de Roblox";

	/// <summary>
	/// Key: "Label.TrustThisDevice"
	/// English String: "Trust this device for 30 days"
	/// </summary>
	public override string LabelTrustThisDevice => "Confiar en este dispositivo durante 30 dÃ­as.";

	/// <summary>
	/// Key: "Label.TwoStepVerification"
	/// English String: "2-Step Verification"
	/// </summary>
	public override string LabelTwoStepVerification => "VerificaciÃ³n en dos pasos";

	/// <summary>
	/// Key: "Response.CodeSent"
	/// English String: "Code Sent"
	/// </summary>
	public override string ResponseCodeSent => "CÃ³digo enviado.";

	/// <summary>
	/// Key: "Response.FeatureNotAvailable"
	/// English String: "Feature not available. Please contact support."
	/// </summary>
	public override string ResponseFeatureNotAvailable => "FunciÃ³n no disponible. Ponte en contacto con asistencia tÃ©cnica.";

	/// <summary>
	/// Key: "Response.InvalidCode"
	/// English String: "Invalid code."
	/// </summary>
	public override string ResponseInvalidCode => "El cÃ³digo no es vÃ¡lido.";

	/// <summary>
	/// Key: "Response.SystemErrorReturnToLogin"
	/// English String: "System error. Please return to login screen."
	/// </summary>
	public override string ResponseSystemErrorReturnToLogin => "Error del sistema. Regresa a la pantalla de inicio de sesiÃ³n.";

	/// <summary>
	/// Key: "Response.TooManyAttempts"
	/// English String: "Too many attempts. Please try again later."
	/// </summary>
	public override string ResponseTooManyAttempts => "Demasiados intentos. IntÃ©ntalo de nuevo mÃ¡s tarde.";

	/// <summary>
	/// Key: "Response.TooManyCharacters"
	/// error message
	/// English String: "Too many characters"
	/// </summary>
	public override string ResponseTooManyCharacters => "Demasiados caracteres";

	public TwoStepVerificationResources_es_es(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionCancel()
	{
		return "Cancelar";
	}

	protected override string _GetTemplateForActionResend()
	{
		return "Reenviar cÃ³digo";
	}

	protected override string _GetTemplateForActionStartOver()
	{
		return "Volver a empezar";
	}

	protected override string _GetTemplateForActionSubmit()
	{
		return "Enviar";
	}

	protected override string _GetTemplateForActionVerify()
	{
		return "Verificar";
	}

	/// <summary>
	/// Key: "Description.TwoStepVerificationActivationEmail.Body.Over13"
	/// Body for 2SV activation email for over 13 users
	/// English String: "Hi {accountName},{lineBreak}{lineBreak}You have activated 2-Step Verification for your Roblox account. Next time you log in from a new device, you will need to enter a 6-digit security code that Roblox sends to you via email.{lineBreak}{lineBreak}Roblox"
	/// </summary>
	public override string DescriptionTwoStepVerificationActivationEmailBodyOver13(string accountName, string lineBreak)
	{
		return $"Hola, {accountName}:{lineBreak}{lineBreak}Has activado la verificaciÃ³n en dos pasos para tu cuenta de Roblox. La prÃ³xima vez que inicies sesiÃ³n desde un nuevo dispositivo, tendrÃ¡s que ingresar un cÃ³digo de seguridad de 6 dÃ­gitos que Roblox te envÃ­a por correo electrÃ³nico.{lineBreak}{lineBreak}Roblox";
	}

	protected override string _GetTemplateForDescriptionTwoStepVerificationActivationEmailBodyOver13()
	{
		return "Hola, {accountName}:{lineBreak}{lineBreak}Has activado la verificaciÃ³n en dos pasos para tu cuenta de Roblox. La prÃ³xima vez que inicies sesiÃ³n desde un nuevo dispositivo, tendrÃ¡s que ingresar un cÃ³digo de seguridad de 6 dÃ­gitos que Roblox te envÃ­a por correo electrÃ³nico.{lineBreak}{lineBreak}Roblox";
	}

	/// <summary>
	/// Key: "Description.TwoStepVerificationActivationEmail.Body.Under13"
	/// Body for 2SV activation email for under 13 users
	/// English String: "Hi,{lineBreak}{lineBreak}2-Step Verification has been activated for your child's Roblox account, {accountName}. Next time they log in from a new device, they will need to enter a 6-digit security code that Roblox sends to you via email.{lineBreak}{lineBreak}Roblox"
	/// </summary>
	public override string DescriptionTwoStepVerificationActivationEmailBodyUnder13(string lineBreak, string accountName)
	{
		return $"Estimado padre de familia:{lineBreak}{lineBreak}La verificaciÃ³n en dos pasos ha sido activada para la cuenta de Roblox de su hijo(a), {accountName}. La prÃ³xima vez que el menor inicie sesiÃ³n desde un nuevo dispositivo, tendrÃ¡ que ingresar un cÃ³digo de seguridad de 6 dÃ­gitos que Roblox le envÃ­a a usted por correo electrÃ³nico.{lineBreak}{lineBreak}Roblox";
	}

	protected override string _GetTemplateForDescriptionTwoStepVerificationActivationEmailBodyUnder13()
	{
		return "Estimado padre de familia:{lineBreak}{lineBreak}La verificaciÃ³n en dos pasos ha sido activada para la cuenta de Roblox de su hijo(a), {accountName}. La prÃ³xima vez que el menor inicie sesiÃ³n desde un nuevo dispositivo, tendrÃ¡ que ingresar un cÃ³digo de seguridad de 6 dÃ­gitos que Roblox le envÃ­a a usted por correo electrÃ³nico.{lineBreak}{lineBreak}Roblox";
	}

	/// <summary>
	/// Key: "Description.TwoStepVerificationActivationEmail.Subject"
	/// Subject for 2SV activation email
	/// English String: "2-Step Verification Activated for Roblox Account: {accountName}"
	/// </summary>
	public override string DescriptionTwoStepVerificationActivationEmailSubject(string accountName)
	{
		return $"VerificaciÃ³n en dos pasos activada para la cuenta de Roblox: {accountName}";
	}

	protected override string _GetTemplateForDescriptionTwoStepVerificationActivationEmailSubject()
	{
		return "VerificaciÃ³n en dos pasos activada para la cuenta de Roblox: {accountName}";
	}

	/// <summary>
	/// Key: "Description.TwoStepVerificationDeactivationEmail.Body.Over13"
	/// Body for 2SV deactivation email for over 13 users
	/// English String: "Hi {accountName},{lineBreak}{lineBreak}You have deactivated 2-Step Verification for your Roblox account. A security code will no longer be required when you log into your account.{lineBreak}{lineBreak}Roblox"
	/// </summary>
	public override string DescriptionTwoStepVerificationDeactivationEmailBodyOver13(string accountName, string lineBreak)
	{
		return $"Hola, {accountName}:{lineBreak}{lineBreak}Has desactivado la verificaciÃ³n en dos pasos para tu cuenta de Roblox. Ya no serÃ¡ necesario ingresar un cÃ³digo de seguridad cuando inicies sesiÃ³n en tu cuenta.{lineBreak}{lineBreak}Roblox";
	}

	protected override string _GetTemplateForDescriptionTwoStepVerificationDeactivationEmailBodyOver13()
	{
		return "Hola, {accountName}:{lineBreak}{lineBreak}Has desactivado la verificaciÃ³n en dos pasos para tu cuenta de Roblox. Ya no serÃ¡ necesario ingresar un cÃ³digo de seguridad cuando inicies sesiÃ³n en tu cuenta.{lineBreak}{lineBreak}Roblox";
	}

	/// <summary>
	/// Key: "Description.TwoStepVerificationDeactivationEmail.Body.Under13"
	/// Body for 2SV deactivation email for under 13 users
	/// English String: "Hi,{lineBreak}{lineBreak}2-Step Verification has been deactivated for your child's Roblox account, {accountName}. A security code will no longer be required when they log into the account.{lineBreak}{lineBreak}Roblox"
	/// </summary>
	public override string DescriptionTwoStepVerificationDeactivationEmailBodyUnder13(string lineBreak, string accountName)
	{
		return $"Estimado padre de familia:{lineBreak}{lineBreak}La verificaciÃ³n en dos pasos ha sido desactivada para la cuenta de Roblox de su hijo(a), {accountName}. Ya no serÃ¡ necesario ingresar un cÃ³digo de seguridad cuando el menor inicie sesiÃ³n en su cuenta.{lineBreak}{lineBreak}Roblox";
	}

	protected override string _GetTemplateForDescriptionTwoStepVerificationDeactivationEmailBodyUnder13()
	{
		return "Estimado padre de familia:{lineBreak}{lineBreak}La verificaciÃ³n en dos pasos ha sido desactivada para la cuenta de Roblox de su hijo(a), {accountName}. Ya no serÃ¡ necesario ingresar un cÃ³digo de seguridad cuando el menor inicie sesiÃ³n en su cuenta.{lineBreak}{lineBreak}Roblox";
	}

	/// <summary>
	/// Key: "Description.TwoStepVerificationDeactivationEmail.Subject	"
	/// Subject for 2SV deactivation email
	/// English String: "2-Step Verification Deactivated for Roblox Account: {accountName}"
	/// </summary>
	public override string DescriptionTwoStepVerificationDeactivationEmailSubject(string accountName)
	{
		return $"VerificaciÃ³n en dos pasos desactivada para la cuenta de Roblox: {accountName}";
	}

	protected override string _GetTemplateForDescriptionTwoStepVerificationDeactivationEmailSubject()
	{
		return "VerificaciÃ³n en dos pasos desactivada para la cuenta de Roblox: {accountName}";
	}

	/// <summary>
	/// Key: "Description.TwoStepVerificationLoginEmail.Html.GeolocationInfo1"
	/// Geolocation information about IP trying to login
	/// English String: "{spanStartTagWithBold}Login request received from {username} located in {region}, {country} ({ipAddress}).{spanEndTag}{lineBreak}{lineBreak}"
	/// </summary>
	public override string DescriptionTwoStepVerificationLoginEmailHtmlGeolocationInfo1(string spanStartTagWithBold, string username, string region, string country, string ipAddress, string spanEndTag, string lineBreak)
	{
		return $"{spanStartTagWithBold}Solicitud de inicio de sesiÃ³n recibida de {username} en {region}, {country} ({ipAddress}).{spanEndTag}{lineBreak}{lineBreak}";
	}

	protected override string _GetTemplateForDescriptionTwoStepVerificationLoginEmailHtmlGeolocationInfo1()
	{
		return "{spanStartTagWithBold}Solicitud de inicio de sesiÃ³n recibida de {username} en {region}, {country} ({ipAddress}).{spanEndTag}{lineBreak}{lineBreak}";
	}

	/// <summary>
	/// Key: "Description.TwoStepVerificationLoginEmail.Html.GeolocationInfo2"
	/// Geolocation info about IP trying to login
	/// English String: "{spanStartTagWithBold}Login request received from {username} located in {country} ({ipAddress}).{spanEndTag}{lineBreak}{lineBreak}\t"
	/// </summary>
	public override string DescriptionTwoStepVerificationLoginEmailHtmlGeolocationInfo2(string spanStartTagWithBold, string username, string country, string ipAddress, string spanEndTag, string lineBreak)
	{
		return $"{spanStartTagWithBold}Solicitud de inicio de sesiÃ³n recibida de {username} en {country} ({ipAddress}).{spanEndTag}{lineBreak}{lineBreak}";
	}

	protected override string _GetTemplateForDescriptionTwoStepVerificationLoginEmailHtmlGeolocationInfo2()
	{
		return "{spanStartTagWithBold}Solicitud de inicio de sesiÃ³n recibida de {username} en {country} ({ipAddress}).{spanEndTag}{lineBreak}{lineBreak}";
	}

	/// <summary>
	/// Key: "Description.TwoStepVerificationLoginEmail.Html.GeolocationInfo3"
	/// Geolocation info about IP trying to log in
	/// English String: "{spanStartTagWithBold}Login request received from {username} (From Roblox Internal).{spanEndTag}{lineBreak}{lineBreak}\t"
	/// </summary>
	public override string DescriptionTwoStepVerificationLoginEmailHtmlGeolocationInfo3(string spanStartTagWithBold, string username, string spanEndTag, string lineBreak)
	{
		return $"{spanStartTagWithBold}Solicitud de inicio de sesiÃ³n recibida de {username} (interno a Roblox).{spanEndTag}{lineBreak}{lineBreak}";
	}

	protected override string _GetTemplateForDescriptionTwoStepVerificationLoginEmailHtmlGeolocationInfo3()
	{
		return "{spanStartTagWithBold}Solicitud de inicio de sesiÃ³n recibida de {username} (interno a Roblox).{spanEndTag}{lineBreak}{lineBreak}";
	}

	/// <summary>
	/// Key: "Description.TwoStepVerificationLoginEmail.Html.GeolocationInfo4"
	/// Geolocation info of IP trying to login
	/// English String: "{spanStartTagWithBold}Login request received from {username} located in {country}.{spanEndTag}{lineBreak}{lineBreak}"
	/// </summary>
	public override string DescriptionTwoStepVerificationLoginEmailHtmlGeolocationInfo4(string spanStartTagWithBold, string username, string country, string spanEndTag, string lineBreak)
	{
		return $"{spanStartTagWithBold}Solicitud de inicio de sesiÃ³n recibida de {username} en {country}.{spanEndTag}{lineBreak}{lineBreak}";
	}

	protected override string _GetTemplateForDescriptionTwoStepVerificationLoginEmailHtmlGeolocationInfo4()
	{
		return "{spanStartTagWithBold}Solicitud de inicio de sesiÃ³n recibida de {username} en {country}.{spanEndTag}{lineBreak}{lineBreak}";
	}

	/// <summary>
	/// Key: "Description.TwoStepVerificationLoginEmail.Html.GeolocationInfo5"
	/// Geolocation info of IP trying to login
	/// English String: "{spanStartTagWithBold}Login request received from {username} located in {region}, {country}.{spanEndTag}{lineBreak}{lineBreak}"
	/// </summary>
	public override string DescriptionTwoStepVerificationLoginEmailHtmlGeolocationInfo5(string spanStartTagWithBold, string username, string region, string country, string spanEndTag, string lineBreak)
	{
		return $"{spanStartTagWithBold}Solicitud de inicio de sesiÃ³n recibida de {username} en {region}, {country}.{spanEndTag}{lineBreak}{lineBreak}";
	}

	protected override string _GetTemplateForDescriptionTwoStepVerificationLoginEmailHtmlGeolocationInfo5()
	{
		return "{spanStartTagWithBold}Solicitud de inicio de sesiÃ³n recibida de {username} en {region}, {country}.{spanEndTag}{lineBreak}{lineBreak}";
	}

	/// <summary>
	/// Key: "Description.TwoStepVerificationLoginEmail.Html.GeolocationInfo6"
	/// Geolocation info of IP trying to login
	/// English String: "{spanStartTagWithBold}Login request received from {username} located in {city}, {region}, {country}.{spanEndTag}{lineBreak}{lineBreak}"
	/// </summary>
	public override string DescriptionTwoStepVerificationLoginEmailHtmlGeolocationInfo6(string spanStartTagWithBold, string username, string city, string region, string country, string spanEndTag, string lineBreak)
	{
		return $"{spanStartTagWithBold}Solicitud de inicio de sesiÃ³n recibida de {username} en {city}, {region}, {country}.{spanEndTag}{lineBreak}{lineBreak}";
	}

	protected override string _GetTemplateForDescriptionTwoStepVerificationLoginEmailHtmlGeolocationInfo6()
	{
		return "{spanStartTagWithBold}Solicitud de inicio de sesiÃ³n recibida de {username} en {city}, {region}, {country}.{spanEndTag}{lineBreak}{lineBreak}";
	}

	/// <summary>
	/// Key: "Description.TwoStepVerificationLoginEmail.HtmlBody"
	/// Html body for 2SV login email
	/// English String: "{geoLocationInformation}{spanStartTagWithBold}Login code for {accountName}: {lineBreak}{lineBreak}{code} {spanEndTag}{lineBreak}{lineBreak}Enter this code into the 2-Step Verification screen to finish logging in. This code will expire in 15 minutes.{lineBreak}{lineBreak}This email was sent because your account tried to login to Roblox from a new browser or device. If you haven't tried logging into Roblox, someone else may be trying to access your account. You are strongly advised to change your password if you did not generate this request.{lineBreak}{lineBreak}Resources:{lineBreak}{aTagStartWithHref}{ChangePasswordLink}{hrefEnd}Change Your Password{aTagEnd} {lineBreak}{aTagStartWithHref}{TwoStepVerificationArticleLink}{hrefEnd}Learn More About 2-Step Verification{aTagEnd} {lineBreak}{aTagStartWithHref}{AccountSafetyArticleLink}{hrefEnd}Keeping Your Account Safe{aTagEnd} {lineBreak}{aTagStartWithHref}{SupportLink}{hrefEnd}General Roblox Support{aTagEnd} {lineBreak}{lineBreak}Thank you,{lineBreak}{lineBreak}The Roblox Team"
	/// </summary>
	public override string DescriptionTwoStepVerificationLoginEmailHtmlBody(string geoLocationInformation, string spanStartTagWithBold, string accountName, string lineBreak, string code, string spanEndTag, string aTagStartWithHref, string ChangePasswordLink, string hrefEnd, string aTagEnd, string TwoStepVerificationArticleLink, string AccountSafetyArticleLink, string SupportLink)
	{
		return $"{geoLocationInformation}{spanStartTagWithBold}CÃ³digo de inicio sesiÃ³n para {accountName}: {lineBreak}{lineBreak}{code} {spanEndTag}{lineBreak}{lineBreak}Ingresa este cÃ³digo en la pantalla de VerificaciÃ³n en dos pasos para finalizar el inicio de sesiÃ³n. Este cÃ³digo caducarÃ¡ en 15 minutos.{lineBreak}{lineBreak}Se ha enviado este correo electrÃ³nico porque se intentÃ³ iniciar sesiÃ³n en Roblox desde un nuevo navegador o dispositivo. Si no has intentado iniciar sesiÃ³n en Roblox, puede que alguien mÃ¡s estÃ© tratando de acceder a tu cuenta. Te recomendamos vivamente que cambies tu contraseÃ±a si no enviaste esta solicitud.{lineBreak}{lineBreak}Recursos:{lineBreak}{aTagStartWithHref}{ChangePasswordLink}{hrefEnd}Cambia tu contraseÃ±a{aTagEnd} {lineBreak}{aTagStartWithHref}{TwoStepVerificationArticleLink}{hrefEnd}Aprende mÃ¡s sobre la verificaciÃ³n en dos pasos{aTagEnd} {lineBreak}{aTagStartWithHref}{AccountSafetyArticleLink}{hrefEnd}Protege tu cuenta{aTagEnd} {lineBreak}{aTagStartWithHref}{SupportLink}{hrefEnd}Asistencia tÃ©cnica general de Roblox{aTagEnd} {lineBreak}{lineBreak}Gracias,{lineBreak}{lineBreak}El equipo de Roblox";
	}

	protected override string _GetTemplateForDescriptionTwoStepVerificationLoginEmailHtmlBody()
	{
		return "{geoLocationInformation}{spanStartTagWithBold}CÃ³digo de inicio sesiÃ³n para {accountName}: {lineBreak}{lineBreak}{code} {spanEndTag}{lineBreak}{lineBreak}Ingresa este cÃ³digo en la pantalla de VerificaciÃ³n en dos pasos para finalizar el inicio de sesiÃ³n. Este cÃ³digo caducarÃ¡ en 15 minutos.{lineBreak}{lineBreak}Se ha enviado este correo electrÃ³nico porque se intentÃ³ iniciar sesiÃ³n en Roblox desde un nuevo navegador o dispositivo. Si no has intentado iniciar sesiÃ³n en Roblox, puede que alguien mÃ¡s estÃ© tratando de acceder a tu cuenta. Te recomendamos vivamente que cambies tu contraseÃ±a si no enviaste esta solicitud.{lineBreak}{lineBreak}Recursos:{lineBreak}{aTagStartWithHref}{ChangePasswordLink}{hrefEnd}Cambia tu contraseÃ±a{aTagEnd} {lineBreak}{aTagStartWithHref}{TwoStepVerificationArticleLink}{hrefEnd}Aprende mÃ¡s sobre la verificaciÃ³n en dos pasos{aTagEnd} {lineBreak}{aTagStartWithHref}{AccountSafetyArticleLink}{hrefEnd}Protege tu cuenta{aTagEnd} {lineBreak}{aTagStartWithHref}{SupportLink}{hrefEnd}Asistencia tÃ©cnica general de Roblox{aTagEnd} {lineBreak}{lineBreak}Gracias,{lineBreak}{lineBreak}El equipo de Roblox";
	}

	/// <summary>
	/// Key: "Description.TwoStepVerificationLoginEmail.PlainBody"
	/// Plain body for 2SV login email
	/// English String: "{geoLocationInformation}Login code for {accountName}: {lineBreak}{lineBreak} {code} {lineBreak}{lineBreak}Enter this code into the 2-Step Verification screen to finish logging in. This code will expire in 15 minutes. {lineBreak}{lineBreak}This email was sent because your account tried to login to Roblox from a new browser or device. If you haven't tried logging into Roblox, someone else may be trying to access your account. You are strongly advised to change your password if you did not generate this request. {lineBreak}{lineBreak}Resources: {lineBreak}Change Your Password [{accountInfoPageLink}] {lineBreak}Learn More About 2-Step Verification [{twoStepVerificationHelpArticleLink}]{lineBreak}Keeping Your Account Safe [{keepAccountSafeArticleLink}] {lineBreak}General Roblox Support [{supportPageLink}] {lineBreak}{lineBreak}Thank you, {lineBreak}{lineBreak}The Roblox Team"
	/// </summary>
	public override string DescriptionTwoStepVerificationLoginEmailPlainBody(string geoLocationInformation, string accountName, string lineBreak, string code, string accountInfoPageLink, string twoStepVerificationHelpArticleLink, string keepAccountSafeArticleLink, string supportPageLink)
	{
		return $"{geoLocationInformation}CÃ³digo de inicio sesiÃ³n para {accountName}: {lineBreak}{lineBreak} {code} {lineBreak}{lineBreak}Ingresa este cÃ³digo en la pantalla de VerificaciÃ³n en dos pasos para finalizar el inicio de sesiÃ³n. Este cÃ³digo caducarÃ¡ en 15 minutos. {lineBreak}{lineBreak}Se ha enviado este correo electrÃ³nico porque se intentÃ³ iniciar sesiÃ³n desde un nuevo navegador o dispositivo. Si no has intentado iniciar sesiÃ³n en Roblox, puede que alguien mÃ¡s estÃ© tratando de acceder a tu cuenta. Te recomendamos vivamente que cambies tu contraseÃ±a si no enviaste esta solicitud. {lineBreak}{lineBreak}Recursos: {lineBreak}Cambia tu contraseÃ±a [{accountInfoPageLink}] {lineBreak}Aprende mÃ¡s sobre la verificaciÃ³n en dos pasos [{twoStepVerificationHelpArticleLink}]{lineBreak}Protege tu cuenta [{keepAccountSafeArticleLink}] {lineBreak}Asistencia tÃ©cnica general de Roblox [{supportPageLink}] {lineBreak}{lineBreak}Gracias, {lineBreak}{lineBreak}El equipo de Roblox";
	}

	protected override string _GetTemplateForDescriptionTwoStepVerificationLoginEmailPlainBody()
	{
		return "{geoLocationInformation}CÃ³digo de inicio sesiÃ³n para {accountName}: {lineBreak}{lineBreak} {code} {lineBreak}{lineBreak}Ingresa este cÃ³digo en la pantalla de VerificaciÃ³n en dos pasos para finalizar el inicio de sesiÃ³n. Este cÃ³digo caducarÃ¡ en 15 minutos. {lineBreak}{lineBreak}Se ha enviado este correo electrÃ³nico porque se intentÃ³ iniciar sesiÃ³n desde un nuevo navegador o dispositivo. Si no has intentado iniciar sesiÃ³n en Roblox, puede que alguien mÃ¡s estÃ© tratando de acceder a tu cuenta. Te recomendamos vivamente que cambies tu contraseÃ±a si no enviaste esta solicitud. {lineBreak}{lineBreak}Recursos: {lineBreak}Cambia tu contraseÃ±a [{accountInfoPageLink}] {lineBreak}Aprende mÃ¡s sobre la verificaciÃ³n en dos pasos [{twoStepVerificationHelpArticleLink}]{lineBreak}Protege tu cuenta [{keepAccountSafeArticleLink}] {lineBreak}Asistencia tÃ©cnica general de Roblox [{supportPageLink}] {lineBreak}{lineBreak}Gracias, {lineBreak}{lineBreak}El equipo de Roblox";
	}

	/// <summary>
	/// Key: "Description.TwoStepVerificationLoginEmail.PlainText.GeolocationInfo1"
	/// GeoLocation info of IP trying to login
	/// English String: "Login request received from {username} located in {region}, {country} ({ipAddress}).{lineBreak}{lineBreak}"
	/// </summary>
	public override string DescriptionTwoStepVerificationLoginEmailPlainTextGeolocationInfo1(string username, string region, string country, string ipAddress, string lineBreak)
	{
		return $"Solicitud de inicio de sesiÃ³n recibida de {username} en {region}, {country} ({ipAddress}).{lineBreak}{lineBreak}";
	}

	protected override string _GetTemplateForDescriptionTwoStepVerificationLoginEmailPlainTextGeolocationInfo1()
	{
		return "Solicitud de inicio de sesiÃ³n recibida de {username} en {region}, {country} ({ipAddress}).{lineBreak}{lineBreak}";
	}

	/// <summary>
	/// Key: "Description.TwoStepVerificationLoginEmail.PlainText.GeolocationInfo2"
	/// Geolocation info of IP trying to login
	/// English String: "Login request received from {username} located in {country} ({ipAddress}).{lineBreak}{lineBreak}"
	/// </summary>
	public override string DescriptionTwoStepVerificationLoginEmailPlainTextGeolocationInfo2(string username, string country, string ipAddress, string lineBreak)
	{
		return $"Solicitud de inicio de sesiÃ³n recibida de {username} en {country} ({ipAddress}).{lineBreak}{lineBreak}";
	}

	protected override string _GetTemplateForDescriptionTwoStepVerificationLoginEmailPlainTextGeolocationInfo2()
	{
		return "Solicitud de inicio de sesiÃ³n recibida de {username} en {country} ({ipAddress}).{lineBreak}{lineBreak}";
	}

	/// <summary>
	/// Key: "Description.TwoStepVerificationLoginEmail.PlainText.GeolocationInfo3"
	/// Geolocation info of IP trying to login
	/// English String: "Login request received from {username} (From Roblox Internal).{lineBreak}{lineBreak}"
	/// </summary>
	public override string DescriptionTwoStepVerificationLoginEmailPlainTextGeolocationInfo3(string username, string lineBreak)
	{
		return $"Solicitud de inicio de sesiÃ³n recibida de {username} (interno a Roblox).{lineBreak}{lineBreak}";
	}

	protected override string _GetTemplateForDescriptionTwoStepVerificationLoginEmailPlainTextGeolocationInfo3()
	{
		return "Solicitud de inicio de sesiÃ³n recibida de {username} (interno a Roblox).{lineBreak}{lineBreak}";
	}

	/// <summary>
	/// Key: "Description.TwoStepVerificationLoginEmail.PlainText.GeolocationInfo4"
	/// Geolocation info of IP trying to login
	/// English String: "Login request received from {username} located in {country}.{lineBreak}{lineBreak}"
	/// </summary>
	public override string DescriptionTwoStepVerificationLoginEmailPlainTextGeolocationInfo4(string username, string country, string lineBreak)
	{
		return $"Solicitud de inicio de sesiÃ³n recibida de {username} en {country}.{lineBreak}{lineBreak}";
	}

	protected override string _GetTemplateForDescriptionTwoStepVerificationLoginEmailPlainTextGeolocationInfo4()
	{
		return "Solicitud de inicio de sesiÃ³n recibida de {username} en {country}.{lineBreak}{lineBreak}";
	}

	/// <summary>
	/// Key: "Description.TwoStepVerificationLoginEmail.PlainText.GeolocationInfo5"
	/// Geolocation info of IP trying to login
	/// English String: "Login request received from {username} located in {region}, {country}.{lineBreak}{lineBreak}"
	/// </summary>
	public override string DescriptionTwoStepVerificationLoginEmailPlainTextGeolocationInfo5(string username, string region, string country, string lineBreak)
	{
		return $"Solicitud de inicio de sesiÃ³n recibida de {username} en {region}, {country}.{lineBreak}{lineBreak}";
	}

	protected override string _GetTemplateForDescriptionTwoStepVerificationLoginEmailPlainTextGeolocationInfo5()
	{
		return "Solicitud de inicio de sesiÃ³n recibida de {username} en {region}, {country}.{lineBreak}{lineBreak}";
	}

	/// <summary>
	/// Key: "Description.TwoStepVerificationLoginEmail.PlainText.GeolocationInfo6"
	/// Geolocation info of IP trying to login
	/// English String: "Login request received from {username} located in {city}, {region}, {country}.{lineBreak}{lineBreak}"
	/// </summary>
	public override string DescriptionTwoStepVerificationLoginEmailPlainTextGeolocationInfo6(string username, string city, string region, string country, string lineBreak)
	{
		return $"Solicitud de inicio de sesiÃ³n recibida de {username} en {city}, {region}, {country}.{lineBreak}{lineBreak}";
	}

	protected override string _GetTemplateForDescriptionTwoStepVerificationLoginEmailPlainTextGeolocationInfo6()
	{
		return "Solicitud de inicio de sesiÃ³n recibida de {username} en {city}, {region}, {country}.{lineBreak}{lineBreak}";
	}

	/// <summary>
	/// Key: "Description.TwoStepVerificationLoginEmail.Subject"
	/// Subject for 2SV login email
	/// English String: "Verification Code for Roblox Account: {accountName}"
	/// </summary>
	public override string DescriptionTwoStepVerificationLoginEmailSubject(string accountName)
	{
		return $"CÃ³digo de verificaciÃ³n para la cuenta de Roblox: {accountName}";
	}

	protected override string _GetTemplateForDescriptionTwoStepVerificationLoginEmailSubject()
	{
		return "CÃ³digo de verificaciÃ³n para la cuenta de Roblox: {accountName}";
	}

	protected override string _GetTemplateForLabelCode()
	{
		return "CÃ³digo";
	}

	/// <summary>
	/// Key: "Label.CodeInputPlaceholderText"
	/// example: Enter 4-digit code
	/// English String: "Enter {codeLength}-digit Code"
	/// </summary>
	public override string LabelCodeInputPlaceholderText(string codeLength)
	{
		return $"Introduce el cÃ³digo de {codeLength} dÃ­gitos";
	}

	protected override string _GetTemplateForLabelCodeInputPlaceholderText()
	{
		return "Introduce el cÃ³digo de {codeLength} dÃ­gitos";
	}

	protected override string _GetTemplateForLabelDidNotReceive()
	{
		return "Â¿No has recibido el cÃ³digo?";
	}

	protected override string _GetTemplateForLabelEnterCode()
	{
		return "Introduce el cÃ³digo (6 dÃ­gitos)";
	}

	protected override string _GetTemplateForLabelEnterEmailCode()
	{
		return "Introduce el cÃ³digo que te acabamos de enviar por correo electrÃ³nico";
	}

	protected override string _GetTemplateForLabelEnterTextCode()
	{
		return "Introduce el cÃ³digo que te acabamos de enviar por mensaje de texto.";
	}

	protected override string _GetTemplateForLabelEnterTwoStepVerificationCode()
	{
		return "Introduce el cÃ³digo de verificaciÃ³n en dos pasos.";
	}

	protected override string _GetTemplateForLabelFacebookPasswordWarning()
	{
		return "Si has estado iniciando sesiÃ³n con Facebook, debes establecer una contraseÃ±a.";
	}

	protected override string _GetTemplateForLabelLearnMore()
	{
		return "MÃ¡s informaciÃ³n";
	}

	/// <summary>
	/// Key: "Label.NeedHelpContactSupport"
	/// label for the support article link
	/// English String: "Need help? Contact {supportLink}"
	/// </summary>
	public override string LabelNeedHelpContactSupport(string supportLink)
	{
		return $"Â¿Necesitas ayuda? Ponte en contacto con {supportLink}.";
	}

	protected override string _GetTemplateForLabelNeedHelpContactSupport()
	{
		return "Â¿Necesitas ayuda? Ponte en contacto con {supportLink}.";
	}

	protected override string _GetTemplateForLabelNewCode()
	{
		return "Nuevo cÃ³digo";
	}

	protected override string _GetTemplateForLabelRobloxSupport()
	{
		return "Asistencia tÃ©cnica de Roblox";
	}

	protected override string _GetTemplateForLabelTrustThisDevice()
	{
		return "Confiar en este dispositivo durante 30 dÃ­as.";
	}

	protected override string _GetTemplateForLabelTwoStepVerification()
	{
		return "VerificaciÃ³n en dos pasos";
	}

	protected override string _GetTemplateForResponseCodeSent()
	{
		return "CÃ³digo enviado.";
	}

	protected override string _GetTemplateForResponseFeatureNotAvailable()
	{
		return "FunciÃ³n no disponible. Ponte en contacto con asistencia tÃ©cnica.";
	}

	protected override string _GetTemplateForResponseInvalidCode()
	{
		return "El cÃ³digo no es vÃ¡lido.";
	}

	protected override string _GetTemplateForResponseSystemErrorReturnToLogin()
	{
		return "Error del sistema. Regresa a la pantalla de inicio de sesiÃ³n.";
	}

	protected override string _GetTemplateForResponseTooManyAttempts()
	{
		return "Demasiados intentos. IntÃ©ntalo de nuevo mÃ¡s tarde.";
	}

	protected override string _GetTemplateForResponseTooManyCharacters()
	{
		return "Demasiados caracteres";
	}
}


}
