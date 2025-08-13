namespace Roblox.TranslationResources.Authentication;

/// <summary>
/// This class overrides TwoStepVerificationResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class TwoStepVerificationResources_it_it : TwoStepVerificationResources_en_us, ITwoStepVerificationResources, ITranslationResources
{
	/// <summary>
	/// Key: "Action.Cancel"
	/// English String: "Cancel"
	/// </summary>
	public override string ActionCancel => "Annulla";

	/// <summary>
	/// Key: "Action.Resend"
	/// English String: "Resend Code"
	/// </summary>
	public override string ActionResend => "Reinvia codice";

	/// <summary>
	/// Key: "Action.StartOver"
	/// link text to restart verification
	/// English String: "Start Over"
	/// </summary>
	public override string ActionStartOver => "Ricomincia";

	/// <summary>
	/// Key: "Action.Submit"
	/// submit button text
	/// English String: "Submit"
	/// </summary>
	public override string ActionSubmit => "Invia";

	/// <summary>
	/// Key: "Action.Verify"
	/// English String: "Verify"
	/// </summary>
	public override string ActionVerify => "Verifica";

	/// <summary>
	/// Key: "Label.Code"
	/// verification code for 2 factor authentication
	/// English String: "Code"
	/// </summary>
	public override string LabelCode => "Codice";

	/// <summary>
	/// Key: "Label.DidNotReceive"
	/// English String: "Didn't receive the code?"
	/// </summary>
	public override string LabelDidNotReceive => "Non hai ricevuto il codice?";

	/// <summary>
	/// Key: "Label.EnterCode"
	/// English String: "Enter Code (6-digit)"
	/// </summary>
	public override string LabelEnterCode => "Inserisci codice (6 cifre)";

	/// <summary>
	/// Key: "Label.EnterEmailCode"
	/// English String: "Enter the code we just sent you via email"
	/// </summary>
	public override string LabelEnterEmailCode => "Inserisci il codice che ti abbiamo inviato tramite e-mail";

	/// <summary>
	/// Key: "Label.EnterTextCode"
	/// English String: "Enter the code we just sent you via text message"
	/// </summary>
	public override string LabelEnterTextCode => "Inserisci il codice che ti abbiamo inviato tramite messaggio di testo";

	/// <summary>
	/// Key: "Label.EnterTwoStepVerificationCode"
	/// Enter your two step verification code.
	/// English String: "Enter your two step verification code."
	/// </summary>
	public override string LabelEnterTwoStepVerificationCode => "Inserisci il codice di verifica in 2 passaggi.";

	/// <summary>
	/// Key: "Label.FacebookPasswordWarning"
	/// If you have been signing in with Facebook, you must set a password.
	/// English String: "If you have been signing in with Facebook, you must set a password."
	/// </summary>
	public override string LabelFacebookPasswordWarning => "Se hai effettuato l'accesso tramite Facebook, devi impostare una password.";

	/// <summary>
	/// Key: "Label.LearnMore"
	/// Learn More link text
	/// English String: "Learn More"
	/// </summary>
	public override string LabelLearnMore => "Maggiori informazioni";

	/// <summary>
	/// Key: "Label.NewCode"
	/// verification code resent, label changes to new code
	/// English String: "New Code"
	/// </summary>
	public override string LabelNewCode => "Nuovo codice";

	/// <summary>
	/// Key: "Label.RobloxSupport"
	/// English String: "Roblox Support"
	/// </summary>
	public override string LabelRobloxSupport => "Assistenza Roblox";

	/// <summary>
	/// Key: "Label.TrustThisDevice"
	/// English String: "Trust this device for 30 days"
	/// </summary>
	public override string LabelTrustThisDevice => "Marca il dispositivo come affidabile per 30 giorni";

	/// <summary>
	/// Key: "Label.TwoStepVerification"
	/// English String: "2-Step Verification"
	/// </summary>
	public override string LabelTwoStepVerification => "Verifica in 2 passaggi";

	/// <summary>
	/// Key: "Response.CodeSent"
	/// English String: "Code Sent"
	/// </summary>
	public override string ResponseCodeSent => "Codice inviato";

	/// <summary>
	/// Key: "Response.FeatureNotAvailable"
	/// English String: "Feature not available. Please contact support."
	/// </summary>
	public override string ResponseFeatureNotAvailable => "Funzione non disponibile. Contatta l'assistenza.";

	/// <summary>
	/// Key: "Response.InvalidCode"
	/// English String: "Invalid code."
	/// </summary>
	public override string ResponseInvalidCode => "Codice non valido.";

	/// <summary>
	/// Key: "Response.SystemErrorReturnToLogin"
	/// English String: "System error. Please return to login screen."
	/// </summary>
	public override string ResponseSystemErrorReturnToLogin => "Errore di sistema. Torna alla schermata di accesso.";

	/// <summary>
	/// Key: "Response.TooManyAttempts"
	/// English String: "Too many attempts. Please try again later."
	/// </summary>
	public override string ResponseTooManyAttempts => "Troppi tentativi. Riprova più tardi.";

	/// <summary>
	/// Key: "Response.TooManyCharacters"
	/// error message
	/// English String: "Too many characters"
	/// </summary>
	public override string ResponseTooManyCharacters => "Troppi caratteri";

	public TwoStepVerificationResources_it_it(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionCancel()
	{
		return "Annulla";
	}

	protected override string _GetTemplateForActionResend()
	{
		return "Reinvia codice";
	}

	protected override string _GetTemplateForActionStartOver()
	{
		return "Ricomincia";
	}

	protected override string _GetTemplateForActionSubmit()
	{
		return "Invia";
	}

	protected override string _GetTemplateForActionVerify()
	{
		return "Verifica";
	}

	/// <summary>
	/// Key: "Description.TwoStepVerificationActivationEmail.Body.Over13"
	/// Body for 2SV activation email for over 13 users
	/// English String: "Hi {accountName},{lineBreak}{lineBreak}You have activated 2-Step Verification for your Roblox account. Next time you log in from a new device, you will need to enter a 6-digit security code that Roblox sends to you via email.{lineBreak}{lineBreak}Roblox"
	/// </summary>
	public override string DescriptionTwoStepVerificationActivationEmailBodyOver13(string accountName, string lineBreak)
	{
		return $"Salve {accountName},{lineBreak}{lineBreak}hai attivato la doppia verifica per il tuo account Roblox. La prossima volta che effettuerai l'accesso da un nuovo dispositivo, dovrai inserire un codice di sicurezza di 6 cifre, che Roblox ti invierà tramite e-mail.{lineBreak}{lineBreak}Roblox";
	}

	protected override string _GetTemplateForDescriptionTwoStepVerificationActivationEmailBodyOver13()
	{
		return "Salve {accountName},{lineBreak}{lineBreak}hai attivato la doppia verifica per il tuo account Roblox. La prossima volta che effettuerai l'accesso da un nuovo dispositivo, dovrai inserire un codice di sicurezza di 6 cifre, che Roblox ti invierà tramite e-mail.{lineBreak}{lineBreak}Roblox";
	}

	/// <summary>
	/// Key: "Description.TwoStepVerificationActivationEmail.Body.Under13"
	/// Body for 2SV activation email for under 13 users
	/// English String: "Hi,{lineBreak}{lineBreak}2-Step Verification has been activated for your child's Roblox account, {accountName}. Next time they log in from a new device, they will need to enter a 6-digit security code that Roblox sends to you via email.{lineBreak}{lineBreak}Roblox"
	/// </summary>
	public override string DescriptionTwoStepVerificationActivationEmailBodyUnder13(string lineBreak, string accountName)
	{
		return $"Salve,{lineBreak}{lineBreak}la doppia verifica è stata attivata per l'account Roblox di tuo figlio, {accountName}. La prossima volta che effettuerà l'accesso da un nuovo dispositivo, dovrà inserire un codice di sicurezza di 6 cifre, che Roblox ti invierà tramite e-mail.{lineBreak}{lineBreak}Roblox";
	}

	protected override string _GetTemplateForDescriptionTwoStepVerificationActivationEmailBodyUnder13()
	{
		return "Salve,{lineBreak}{lineBreak}la doppia verifica è stata attivata per l'account Roblox di tuo figlio, {accountName}. La prossima volta che effettuerà l'accesso da un nuovo dispositivo, dovrà inserire un codice di sicurezza di 6 cifre, che Roblox ti invierà tramite e-mail.{lineBreak}{lineBreak}Roblox";
	}

	/// <summary>
	/// Key: "Description.TwoStepVerificationActivationEmail.Subject"
	/// Subject for 2SV activation email
	/// English String: "2-Step Verification Activated for Roblox Account: {accountName}"
	/// </summary>
	public override string DescriptionTwoStepVerificationActivationEmailSubject(string accountName)
	{
		return $"Doppia verifica attivata per l'account Roblox: {accountName}";
	}

	protected override string _GetTemplateForDescriptionTwoStepVerificationActivationEmailSubject()
	{
		return "Doppia verifica attivata per l'account Roblox: {accountName}";
	}

	/// <summary>
	/// Key: "Description.TwoStepVerificationDeactivationEmail.Body.Over13"
	/// Body for 2SV deactivation email for over 13 users
	/// English String: "Hi {accountName},{lineBreak}{lineBreak}You have deactivated 2-Step Verification for your Roblox account. A security code will no longer be required when you log into your account.{lineBreak}{lineBreak}Roblox"
	/// </summary>
	public override string DescriptionTwoStepVerificationDeactivationEmailBodyOver13(string accountName, string lineBreak)
	{
		return $"Salve {accountName},{lineBreak}{lineBreak}hai disattivato la doppia verifica per il tuo account Roblox. Non sarà più necessario un codice di sicurezza per accedere al tuo account.{lineBreak}{lineBreak}Roblox";
	}

	protected override string _GetTemplateForDescriptionTwoStepVerificationDeactivationEmailBodyOver13()
	{
		return "Salve {accountName},{lineBreak}{lineBreak}hai disattivato la doppia verifica per il tuo account Roblox. Non sarà più necessario un codice di sicurezza per accedere al tuo account.{lineBreak}{lineBreak}Roblox";
	}

	/// <summary>
	/// Key: "Description.TwoStepVerificationDeactivationEmail.Body.Under13"
	/// Body for 2SV deactivation email for under 13 users
	/// English String: "Hi,{lineBreak}{lineBreak}2-Step Verification has been deactivated for your child's Roblox account, {accountName}. A security code will no longer be required when they log into the account.{lineBreak}{lineBreak}Roblox"
	/// </summary>
	public override string DescriptionTwoStepVerificationDeactivationEmailBodyUnder13(string lineBreak, string accountName)
	{
		return $"Salve,{lineBreak}{lineBreak}hai disattivato la doppia verifica per l'account Roblox di tuo figlio, {accountName}. Non sarà più necessario un codice di sicurezza per accedere al suo account.{lineBreak}{lineBreak}Roblox";
	}

	protected override string _GetTemplateForDescriptionTwoStepVerificationDeactivationEmailBodyUnder13()
	{
		return "Salve,{lineBreak}{lineBreak}hai disattivato la doppia verifica per l'account Roblox di tuo figlio, {accountName}. Non sarà più necessario un codice di sicurezza per accedere al suo account.{lineBreak}{lineBreak}Roblox";
	}

	/// <summary>
	/// Key: "Description.TwoStepVerificationDeactivationEmail.Subject	"
	/// Subject for 2SV deactivation email
	/// English String: "2-Step Verification Deactivated for Roblox Account: {accountName}"
	/// </summary>
	public override string DescriptionTwoStepVerificationDeactivationEmailSubject(string accountName)
	{
		return $"Doppia verifica disattivata per l'account Roblox: {accountName}";
	}

	protected override string _GetTemplateForDescriptionTwoStepVerificationDeactivationEmailSubject()
	{
		return "Doppia verifica disattivata per l'account Roblox: {accountName}";
	}

	/// <summary>
	/// Key: "Description.TwoStepVerificationLoginEmail.Html.GeolocationInfo1"
	/// Geolocation information about IP trying to login
	/// English String: "{spanStartTagWithBold}Login request received from {username} located in {region}, {country} ({ipAddress}).{spanEndTag}{lineBreak}{lineBreak}"
	/// </summary>
	public override string DescriptionTwoStepVerificationLoginEmailHtmlGeolocationInfo1(string spanStartTagWithBold, string username, string region, string country, string ipAddress, string spanEndTag, string lineBreak)
	{
		return $"{spanStartTagWithBold}Richiesta di accesso ricevuta da {username}, proveniente da: {region}, {country} ({ipAddress}).{spanEndTag}{lineBreak}{lineBreak}";
	}

	protected override string _GetTemplateForDescriptionTwoStepVerificationLoginEmailHtmlGeolocationInfo1()
	{
		return "{spanStartTagWithBold}Richiesta di accesso ricevuta da {username}, proveniente da: {region}, {country} ({ipAddress}).{spanEndTag}{lineBreak}{lineBreak}";
	}

	/// <summary>
	/// Key: "Description.TwoStepVerificationLoginEmail.Html.GeolocationInfo2"
	/// Geolocation info about IP trying to login
	/// English String: "{spanStartTagWithBold}Login request received from {username} located in {country} ({ipAddress}).{spanEndTag}{lineBreak}{lineBreak}\t"
	/// </summary>
	public override string DescriptionTwoStepVerificationLoginEmailHtmlGeolocationInfo2(string spanStartTagWithBold, string username, string country, string ipAddress, string spanEndTag, string lineBreak)
	{
		return $"{spanStartTagWithBold}Richiesta di accesso ricevuta da {username}, proveniente da: {country} ({ipAddress}).{spanEndTag}{lineBreak}{lineBreak}\t";
	}

	protected override string _GetTemplateForDescriptionTwoStepVerificationLoginEmailHtmlGeolocationInfo2()
	{
		return "{spanStartTagWithBold}Richiesta di accesso ricevuta da {username}, proveniente da: {country} ({ipAddress}).{spanEndTag}{lineBreak}{lineBreak}\t";
	}

	/// <summary>
	/// Key: "Description.TwoStepVerificationLoginEmail.Html.GeolocationInfo3"
	/// Geolocation info about IP trying to log in
	/// English String: "{spanStartTagWithBold}Login request received from {username} (From Roblox Internal).{spanEndTag}{lineBreak}{lineBreak}\t"
	/// </summary>
	public override string DescriptionTwoStepVerificationLoginEmailHtmlGeolocationInfo3(string spanStartTagWithBold, string username, string spanEndTag, string lineBreak)
	{
		return $"{spanStartTagWithBold}Richiesta di accesso ricevuta da {username} (interno a Roblox).{spanEndTag}{lineBreak}{lineBreak}\t";
	}

	protected override string _GetTemplateForDescriptionTwoStepVerificationLoginEmailHtmlGeolocationInfo3()
	{
		return "{spanStartTagWithBold}Richiesta di accesso ricevuta da {username} (interno a Roblox).{spanEndTag}{lineBreak}{lineBreak}\t";
	}

	/// <summary>
	/// Key: "Description.TwoStepVerificationLoginEmail.Html.GeolocationInfo4"
	/// Geolocation info of IP trying to login
	/// English String: "{spanStartTagWithBold}Login request received from {username} located in {country}.{spanEndTag}{lineBreak}{lineBreak}"
	/// </summary>
	public override string DescriptionTwoStepVerificationLoginEmailHtmlGeolocationInfo4(string spanStartTagWithBold, string username, string country, string spanEndTag, string lineBreak)
	{
		return $"{spanStartTagWithBold}Richiesta di accesso ricevuta da {username}, proveniente da: {country}.{spanEndTag}{lineBreak}{lineBreak}";
	}

	protected override string _GetTemplateForDescriptionTwoStepVerificationLoginEmailHtmlGeolocationInfo4()
	{
		return "{spanStartTagWithBold}Richiesta di accesso ricevuta da {username}, proveniente da: {country}.{spanEndTag}{lineBreak}{lineBreak}";
	}

	/// <summary>
	/// Key: "Description.TwoStepVerificationLoginEmail.Html.GeolocationInfo5"
	/// Geolocation info of IP trying to login
	/// English String: "{spanStartTagWithBold}Login request received from {username} located in {region}, {country}.{spanEndTag}{lineBreak}{lineBreak}"
	/// </summary>
	public override string DescriptionTwoStepVerificationLoginEmailHtmlGeolocationInfo5(string spanStartTagWithBold, string username, string region, string country, string spanEndTag, string lineBreak)
	{
		return $"{spanStartTagWithBold}Richiesta di accesso ricevuta da {username}, proveniente da: {region}, {country}.{spanEndTag}{lineBreak}{lineBreak}";
	}

	protected override string _GetTemplateForDescriptionTwoStepVerificationLoginEmailHtmlGeolocationInfo5()
	{
		return "{spanStartTagWithBold}Richiesta di accesso ricevuta da {username}, proveniente da: {region}, {country}.{spanEndTag}{lineBreak}{lineBreak}";
	}

	/// <summary>
	/// Key: "Description.TwoStepVerificationLoginEmail.Html.GeolocationInfo6"
	/// Geolocation info of IP trying to login
	/// English String: "{spanStartTagWithBold}Login request received from {username} located in {city}, {region}, {country}.{spanEndTag}{lineBreak}{lineBreak}"
	/// </summary>
	public override string DescriptionTwoStepVerificationLoginEmailHtmlGeolocationInfo6(string spanStartTagWithBold, string username, string city, string region, string country, string spanEndTag, string lineBreak)
	{
		return $"{spanStartTagWithBold}Richiesta di accesso ricevuta da {username}, proveniente da: {city}, {region}, {country}.{spanEndTag}{lineBreak}{lineBreak}";
	}

	protected override string _GetTemplateForDescriptionTwoStepVerificationLoginEmailHtmlGeolocationInfo6()
	{
		return "{spanStartTagWithBold}Richiesta di accesso ricevuta da {username}, proveniente da: {city}, {region}, {country}.{spanEndTag}{lineBreak}{lineBreak}";
	}

	/// <summary>
	/// Key: "Description.TwoStepVerificationLoginEmail.HtmlBody"
	/// Html body for 2SV login email
	/// English String: "{geoLocationInformation}{spanStartTagWithBold}Login code for {accountName}: {lineBreak}{lineBreak}{code} {spanEndTag}{lineBreak}{lineBreak}Enter this code into the 2-Step Verification screen to finish logging in. This code will expire in 15 minutes.{lineBreak}{lineBreak}This email was sent because your account tried to login to Roblox from a new browser or device. If you haven't tried logging into Roblox, someone else may be trying to access your account. You are strongly advised to change your password if you did not generate this request.{lineBreak}{lineBreak}Resources:{lineBreak}{aTagStartWithHref}{ChangePasswordLink}{hrefEnd}Change Your Password{aTagEnd} {lineBreak}{aTagStartWithHref}{TwoStepVerificationArticleLink}{hrefEnd}Learn More About 2-Step Verification{aTagEnd} {lineBreak}{aTagStartWithHref}{AccountSafetyArticleLink}{hrefEnd}Keeping Your Account Safe{aTagEnd} {lineBreak}{aTagStartWithHref}{SupportLink}{hrefEnd}General Roblox Support{aTagEnd} {lineBreak}{lineBreak}Thank you,{lineBreak}{lineBreak}The Roblox Team"
	/// </summary>
	public override string DescriptionTwoStepVerificationLoginEmailHtmlBody(string geoLocationInformation, string spanStartTagWithBold, string accountName, string lineBreak, string code, string spanEndTag, string aTagStartWithHref, string ChangePasswordLink, string hrefEnd, string aTagEnd, string TwoStepVerificationArticleLink, string AccountSafetyArticleLink, string SupportLink)
	{
		return $"{geoLocationInformation}{spanStartTagWithBold}Codice di accesso per {accountName}: {lineBreak}{lineBreak}{code} {spanEndTag}{lineBreak}{lineBreak}Inserisci questo codice nella schermata della doppia verifica per completare l'accesso. Il codice scadrà tra 15 minuti.{lineBreak}{lineBreak}Hai ricevuto questa e-mail in seguito a un tentativo di accesso a Roblox con il tuo account da un nuovo browser o dispositivo. Se la richiesta non è partita da te, è possibile che qualcun altro abbia tentato di accedere al tuo account. In tal caso ti consigliamo vivamente di modificare la tua password.{lineBreak}{lineBreak}Risorse:{lineBreak}{aTagStartWithHref}{ChangePasswordLink}{hrefEnd}Modifica la password{aTagEnd} {lineBreak}{aTagStartWithHref}{TwoStepVerificationArticleLink}{hrefEnd}Maggiori informazioni sulla doppia verifica{aTagEnd} {lineBreak}{aTagStartWithHref}{AccountSafetyArticleLink}{hrefEnd}Garantire la sicurezza del tuo account{aTagEnd} {lineBreak}{aTagStartWithHref}{SupportLink}{hrefEnd}Assistenza generale Roblox{aTagEnd} {lineBreak}{lineBreak}Grazie,{lineBreak}{lineBreak}la squadra Roblox";
	}

	protected override string _GetTemplateForDescriptionTwoStepVerificationLoginEmailHtmlBody()
	{
		return "{geoLocationInformation}{spanStartTagWithBold}Codice di accesso per {accountName}: {lineBreak}{lineBreak}{code} {spanEndTag}{lineBreak}{lineBreak}Inserisci questo codice nella schermata della doppia verifica per completare l'accesso. Il codice scadrà tra 15 minuti.{lineBreak}{lineBreak}Hai ricevuto questa e-mail in seguito a un tentativo di accesso a Roblox con il tuo account da un nuovo browser o dispositivo. Se la richiesta non è partita da te, è possibile che qualcun altro abbia tentato di accedere al tuo account. In tal caso ti consigliamo vivamente di modificare la tua password.{lineBreak}{lineBreak}Risorse:{lineBreak}{aTagStartWithHref}{ChangePasswordLink}{hrefEnd}Modifica la password{aTagEnd} {lineBreak}{aTagStartWithHref}{TwoStepVerificationArticleLink}{hrefEnd}Maggiori informazioni sulla doppia verifica{aTagEnd} {lineBreak}{aTagStartWithHref}{AccountSafetyArticleLink}{hrefEnd}Garantire la sicurezza del tuo account{aTagEnd} {lineBreak}{aTagStartWithHref}{SupportLink}{hrefEnd}Assistenza generale Roblox{aTagEnd} {lineBreak}{lineBreak}Grazie,{lineBreak}{lineBreak}la squadra Roblox";
	}

	/// <summary>
	/// Key: "Description.TwoStepVerificationLoginEmail.PlainBody"
	/// Plain body for 2SV login email
	/// English String: "{geoLocationInformation}Login code for {accountName}: {lineBreak}{lineBreak} {code} {lineBreak}{lineBreak}Enter this code into the 2-Step Verification screen to finish logging in. This code will expire in 15 minutes. {lineBreak}{lineBreak}This email was sent because your account tried to login to Roblox from a new browser or device. If you haven't tried logging into Roblox, someone else may be trying to access your account. You are strongly advised to change your password if you did not generate this request. {lineBreak}{lineBreak}Resources: {lineBreak}Change Your Password [{accountInfoPageLink}] {lineBreak}Learn More About 2-Step Verification [{twoStepVerificationHelpArticleLink}]{lineBreak}Keeping Your Account Safe [{keepAccountSafeArticleLink}] {lineBreak}General Roblox Support [{supportPageLink}] {lineBreak}{lineBreak}Thank you, {lineBreak}{lineBreak}The Roblox Team"
	/// </summary>
	public override string DescriptionTwoStepVerificationLoginEmailPlainBody(string geoLocationInformation, string accountName, string lineBreak, string code, string accountInfoPageLink, string twoStepVerificationHelpArticleLink, string keepAccountSafeArticleLink, string supportPageLink)
	{
		return $"{geoLocationInformation}Codice di accesso per {accountName}: {lineBreak}{lineBreak} {code} {lineBreak}{lineBreak}Inserisci questo codice nella schermata della doppia verifica per completare l'accesso. Il codice scadrà tra 15 minuti. {lineBreak}{lineBreak}Hai ricevuto questa e-mail in seguito a un tentativo di accesso a Roblox con il tuo account da un nuovo browser o dispositivo. Se la richiesta non è partita da te, è possibile che qualcun altro abbia tentato di accedere al tuo account. In tal caso, ti consigliamo vivamente di modificare la tua password. {lineBreak}{lineBreak}Risorse: {lineBreak}Modifica la password [{accountInfoPageLink}] {lineBreak}Maggiori informazioni sulla doppia verifica [{twoStepVerificationHelpArticleLink}]{lineBreak}Garantire la sicurezza del tuo account [{keepAccountSafeArticleLink}] {lineBreak}Assistenza generale Roblox [{supportPageLink}] {lineBreak}{lineBreak}Grazie, {lineBreak}{lineBreak}la squadra Roblox";
	}

	protected override string _GetTemplateForDescriptionTwoStepVerificationLoginEmailPlainBody()
	{
		return "{geoLocationInformation}Codice di accesso per {accountName}: {lineBreak}{lineBreak} {code} {lineBreak}{lineBreak}Inserisci questo codice nella schermata della doppia verifica per completare l'accesso. Il codice scadrà tra 15 minuti. {lineBreak}{lineBreak}Hai ricevuto questa e-mail in seguito a un tentativo di accesso a Roblox con il tuo account da un nuovo browser o dispositivo. Se la richiesta non è partita da te, è possibile che qualcun altro abbia tentato di accedere al tuo account. In tal caso, ti consigliamo vivamente di modificare la tua password. {lineBreak}{lineBreak}Risorse: {lineBreak}Modifica la password [{accountInfoPageLink}] {lineBreak}Maggiori informazioni sulla doppia verifica [{twoStepVerificationHelpArticleLink}]{lineBreak}Garantire la sicurezza del tuo account [{keepAccountSafeArticleLink}] {lineBreak}Assistenza generale Roblox [{supportPageLink}] {lineBreak}{lineBreak}Grazie, {lineBreak}{lineBreak}la squadra Roblox";
	}

	/// <summary>
	/// Key: "Description.TwoStepVerificationLoginEmail.PlainText.GeolocationInfo1"
	/// GeoLocation info of IP trying to login
	/// English String: "Login request received from {username} located in {region}, {country} ({ipAddress}).{lineBreak}{lineBreak}"
	/// </summary>
	public override string DescriptionTwoStepVerificationLoginEmailPlainTextGeolocationInfo1(string username, string region, string country, string ipAddress, string lineBreak)
	{
		return $"Richiesta di accesso ricevuta da {username}, proveniente da: {region}, {country} ({ipAddress}).{lineBreak}{lineBreak}";
	}

	protected override string _GetTemplateForDescriptionTwoStepVerificationLoginEmailPlainTextGeolocationInfo1()
	{
		return "Richiesta di accesso ricevuta da {username}, proveniente da: {region}, {country} ({ipAddress}).{lineBreak}{lineBreak}";
	}

	/// <summary>
	/// Key: "Description.TwoStepVerificationLoginEmail.PlainText.GeolocationInfo2"
	/// Geolocation info of IP trying to login
	/// English String: "Login request received from {username} located in {country} ({ipAddress}).{lineBreak}{lineBreak}"
	/// </summary>
	public override string DescriptionTwoStepVerificationLoginEmailPlainTextGeolocationInfo2(string username, string country, string ipAddress, string lineBreak)
	{
		return $"Richiesta di accesso ricevuta da {username}, proveniente da: {country} ({ipAddress}).{lineBreak}{lineBreak}";
	}

	protected override string _GetTemplateForDescriptionTwoStepVerificationLoginEmailPlainTextGeolocationInfo2()
	{
		return "Richiesta di accesso ricevuta da {username}, proveniente da: {country} ({ipAddress}).{lineBreak}{lineBreak}";
	}

	/// <summary>
	/// Key: "Description.TwoStepVerificationLoginEmail.PlainText.GeolocationInfo3"
	/// Geolocation info of IP trying to login
	/// English String: "Login request received from {username} (From Roblox Internal).{lineBreak}{lineBreak}"
	/// </summary>
	public override string DescriptionTwoStepVerificationLoginEmailPlainTextGeolocationInfo3(string username, string lineBreak)
	{
		return $"Richiesta di accesso ricevuta da {username} (interno a Roblox).{lineBreak}{lineBreak}";
	}

	protected override string _GetTemplateForDescriptionTwoStepVerificationLoginEmailPlainTextGeolocationInfo3()
	{
		return "Richiesta di accesso ricevuta da {username} (interno a Roblox).{lineBreak}{lineBreak}";
	}

	/// <summary>
	/// Key: "Description.TwoStepVerificationLoginEmail.PlainText.GeolocationInfo4"
	/// Geolocation info of IP trying to login
	/// English String: "Login request received from {username} located in {country}.{lineBreak}{lineBreak}"
	/// </summary>
	public override string DescriptionTwoStepVerificationLoginEmailPlainTextGeolocationInfo4(string username, string country, string lineBreak)
	{
		return $"Richiesta di accesso ricevuta da {username}, proveniente da: {country}.{lineBreak}{lineBreak}";
	}

	protected override string _GetTemplateForDescriptionTwoStepVerificationLoginEmailPlainTextGeolocationInfo4()
	{
		return "Richiesta di accesso ricevuta da {username}, proveniente da: {country}.{lineBreak}{lineBreak}";
	}

	/// <summary>
	/// Key: "Description.TwoStepVerificationLoginEmail.PlainText.GeolocationInfo5"
	/// Geolocation info of IP trying to login
	/// English String: "Login request received from {username} located in {region}, {country}.{lineBreak}{lineBreak}"
	/// </summary>
	public override string DescriptionTwoStepVerificationLoginEmailPlainTextGeolocationInfo5(string username, string region, string country, string lineBreak)
	{
		return $"Richiesta di accesso ricevuta da {username}, proveniente da: {region}, {country}.{lineBreak}{lineBreak}";
	}

	protected override string _GetTemplateForDescriptionTwoStepVerificationLoginEmailPlainTextGeolocationInfo5()
	{
		return "Richiesta di accesso ricevuta da {username}, proveniente da: {region}, {country}.{lineBreak}{lineBreak}";
	}

	/// <summary>
	/// Key: "Description.TwoStepVerificationLoginEmail.PlainText.GeolocationInfo6"
	/// Geolocation info of IP trying to login
	/// English String: "Login request received from {username} located in {city}, {region}, {country}.{lineBreak}{lineBreak}"
	/// </summary>
	public override string DescriptionTwoStepVerificationLoginEmailPlainTextGeolocationInfo6(string username, string city, string region, string country, string lineBreak)
	{
		return $"Richiesta di accesso ricevuta da {username}, proveniente da: {city}, {region}, {country}.{lineBreak}{lineBreak}";
	}

	protected override string _GetTemplateForDescriptionTwoStepVerificationLoginEmailPlainTextGeolocationInfo6()
	{
		return "Richiesta di accesso ricevuta da {username}, proveniente da: {city}, {region}, {country}.{lineBreak}{lineBreak}";
	}

	/// <summary>
	/// Key: "Description.TwoStepVerificationLoginEmail.Subject"
	/// Subject for 2SV login email
	/// English String: "Verification Code for Roblox Account: {accountName}"
	/// </summary>
	public override string DescriptionTwoStepVerificationLoginEmailSubject(string accountName)
	{
		return $"Codice di verifica per l’account Roblox: {accountName}";
	}

	protected override string _GetTemplateForDescriptionTwoStepVerificationLoginEmailSubject()
	{
		return "Codice di verifica per l’account Roblox: {accountName}";
	}

	protected override string _GetTemplateForLabelCode()
	{
		return "Codice";
	}

	/// <summary>
	/// Key: "Label.CodeInputPlaceholderText"
	/// example: Enter 4-digit code
	/// English String: "Enter {codeLength}-digit Code"
	/// </summary>
	public override string LabelCodeInputPlaceholderText(string codeLength)
	{
		return $"Inserisci il codice a {codeLength} cifre";
	}

	protected override string _GetTemplateForLabelCodeInputPlaceholderText()
	{
		return "Inserisci il codice a {codeLength} cifre";
	}

	protected override string _GetTemplateForLabelDidNotReceive()
	{
		return "Non hai ricevuto il codice?";
	}

	protected override string _GetTemplateForLabelEnterCode()
	{
		return "Inserisci codice (6 cifre)";
	}

	protected override string _GetTemplateForLabelEnterEmailCode()
	{
		return "Inserisci il codice che ti abbiamo inviato tramite e-mail";
	}

	protected override string _GetTemplateForLabelEnterTextCode()
	{
		return "Inserisci il codice che ti abbiamo inviato tramite messaggio di testo";
	}

	protected override string _GetTemplateForLabelEnterTwoStepVerificationCode()
	{
		return "Inserisci il codice di verifica in 2 passaggi.";
	}

	protected override string _GetTemplateForLabelFacebookPasswordWarning()
	{
		return "Se hai effettuato l'accesso tramite Facebook, devi impostare una password.";
	}

	protected override string _GetTemplateForLabelLearnMore()
	{
		return "Maggiori informazioni";
	}

	/// <summary>
	/// Key: "Label.NeedHelpContactSupport"
	/// label for the support article link
	/// English String: "Need help? Contact {supportLink}"
	/// </summary>
	public override string LabelNeedHelpContactSupport(string supportLink)
	{
		return $"Hai bisogno d'aiuto? Contatta {supportLink}";
	}

	protected override string _GetTemplateForLabelNeedHelpContactSupport()
	{
		return "Hai bisogno d'aiuto? Contatta {supportLink}";
	}

	protected override string _GetTemplateForLabelNewCode()
	{
		return "Nuovo codice";
	}

	protected override string _GetTemplateForLabelRobloxSupport()
	{
		return "Assistenza Roblox";
	}

	protected override string _GetTemplateForLabelTrustThisDevice()
	{
		return "Marca il dispositivo come affidabile per 30 giorni";
	}

	protected override string _GetTemplateForLabelTwoStepVerification()
	{
		return "Verifica in 2 passaggi";
	}

	protected override string _GetTemplateForResponseCodeSent()
	{
		return "Codice inviato";
	}

	protected override string _GetTemplateForResponseFeatureNotAvailable()
	{
		return "Funzione non disponibile. Contatta l'assistenza.";
	}

	protected override string _GetTemplateForResponseInvalidCode()
	{
		return "Codice non valido.";
	}

	protected override string _GetTemplateForResponseSystemErrorReturnToLogin()
	{
		return "Errore di sistema. Torna alla schermata di accesso.";
	}

	protected override string _GetTemplateForResponseTooManyAttempts()
	{
		return "Troppi tentativi. Riprova più tardi.";
	}

	protected override string _GetTemplateForResponseTooManyCharacters()
	{
		return "Troppi caratteri";
	}
}
