namespace Roblox.TranslationResources.Authentication;

/// <summary>
/// This class overrides TwoStepVerificationResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class TwoStepVerificationResources_de_de : TwoStepVerificationResources_en_us, ITwoStepVerificationResources, ITranslationResources
{
	/// <summary>
	/// Key: "Action.Cancel"
	/// English String: "Cancel"
	/// </summary>
	public override string ActionCancel => "Abbrechen";

	/// <summary>
	/// Key: "Action.Resend"
	/// English String: "Resend Code"
	/// </summary>
	public override string ActionResend => "Code erneut senden";

	/// <summary>
	/// Key: "Action.StartOver"
	/// link text to restart verification
	/// English String: "Start Over"
	/// </summary>
	public override string ActionStartOver => "Von vorne anfangen";

	/// <summary>
	/// Key: "Action.Submit"
	/// submit button text
	/// English String: "Submit"
	/// </summary>
	public override string ActionSubmit => "Senden";

	/// <summary>
	/// Key: "Action.Verify"
	/// English String: "Verify"
	/// </summary>
	public override string ActionVerify => "Verifizieren";

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
	public override string LabelDidNotReceive => "Code nicht erhalten?";

	/// <summary>
	/// Key: "Label.EnterCode"
	/// English String: "Enter Code (6-digit)"
	/// </summary>
	public override string LabelEnterCode => "Code eingeben (6-stellig)";

	/// <summary>
	/// Key: "Label.EnterEmailCode"
	/// English String: "Enter the code we just sent you via email"
	/// </summary>
	public override string LabelEnterEmailCode => "Gib den Code ein, den wir dir gerade per E-Mail geschickt haben.";

	/// <summary>
	/// Key: "Label.EnterTextCode"
	/// English String: "Enter the code we just sent you via text message"
	/// </summary>
	public override string LabelEnterTextCode => "Gib den Code ein, den wir dir gerade per SMS geschickt haben.";

	/// <summary>
	/// Key: "Label.EnterTwoStepVerificationCode"
	/// Enter your two step verification code.
	/// English String: "Enter your two step verification code."
	/// </summary>
	public override string LabelEnterTwoStepVerificationCode => "Gib deinen Code für die Verifizierung in zwei Schritten ein.";

	/// <summary>
	/// Key: "Label.FacebookPasswordWarning"
	/// If you have been signing in with Facebook, you must set a password.
	/// English String: "If you have been signing in with Facebook, you must set a password."
	/// </summary>
	public override string LabelFacebookPasswordWarning => "Solltest du dich bisher mit Facebook angemeldet haben, musst du ein Passwort erstellen.";

	/// <summary>
	/// Key: "Label.LearnMore"
	/// Learn More link text
	/// English String: "Learn More"
	/// </summary>
	public override string LabelLearnMore => "Mehr erfahren";

	/// <summary>
	/// Key: "Label.NewCode"
	/// verification code resent, label changes to new code
	/// English String: "New Code"
	/// </summary>
	public override string LabelNewCode => "Neuer Code";

	/// <summary>
	/// Key: "Label.RobloxSupport"
	/// English String: "Roblox Support"
	/// </summary>
	public override string LabelRobloxSupport => "Roblox-Support";

	/// <summary>
	/// Key: "Label.TrustThisDevice"
	/// English String: "Trust this device for 30 days"
	/// </summary>
	public override string LabelTrustThisDevice => "Diesem Gerät für 30 Tage vertrauen";

	/// <summary>
	/// Key: "Label.TwoStepVerification"
	/// English String: "2-Step Verification"
	/// </summary>
	public override string LabelTwoStepVerification => "Verifizierung in 2 Schritten";

	/// <summary>
	/// Key: "Response.CodeSent"
	/// English String: "Code Sent"
	/// </summary>
	public override string ResponseCodeSent => "Code gesendet";

	/// <summary>
	/// Key: "Response.FeatureNotAvailable"
	/// English String: "Feature not available. Please contact support."
	/// </summary>
	public override string ResponseFeatureNotAvailable => "Feature nicht verfügbar. Bitte kontaktiere den Support.";

	/// <summary>
	/// Key: "Response.InvalidCode"
	/// English String: "Invalid code."
	/// </summary>
	public override string ResponseInvalidCode => "Ungültiger Code.";

	/// <summary>
	/// Key: "Response.SystemErrorReturnToLogin"
	/// English String: "System error. Please return to login screen."
	/// </summary>
	public override string ResponseSystemErrorReturnToLogin => "Systemfehler. Bitte kehre zum Anmeldefenster zurück.";

	/// <summary>
	/// Key: "Response.TooManyAttempts"
	/// English String: "Too many attempts. Please try again later."
	/// </summary>
	public override string ResponseTooManyAttempts => "Zu viele Versuche. Bitte versuche es später erneut.";

	/// <summary>
	/// Key: "Response.TooManyCharacters"
	/// error message
	/// English String: "Too many characters"
	/// </summary>
	public override string ResponseTooManyCharacters => "Zu viele Zeichen";

	public TwoStepVerificationResources_de_de(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionCancel()
	{
		return "Abbrechen";
	}

	protected override string _GetTemplateForActionResend()
	{
		return "Code erneut senden";
	}

	protected override string _GetTemplateForActionStartOver()
	{
		return "Von vorne anfangen";
	}

	protected override string _GetTemplateForActionSubmit()
	{
		return "Senden";
	}

	protected override string _GetTemplateForActionVerify()
	{
		return "Verifizieren";
	}

	/// <summary>
	/// Key: "Description.TwoStepVerificationActivationEmail.Body.Over13"
	/// Body for 2SV activation email for over 13 users
	/// English String: "Hi {accountName},{lineBreak}{lineBreak}You have activated 2-Step Verification for your Roblox account. Next time you log in from a new device, you will need to enter a 6-digit security code that Roblox sends to you via email.{lineBreak}{lineBreak}Roblox"
	/// </summary>
	public override string DescriptionTwoStepVerificationActivationEmailBodyOver13(string accountName, string lineBreak)
	{
		return $"Hi {accountName},{lineBreak}{lineBreak}du hast die Verifizierung in 2 Schritten für dein Roblox-Konto aktiviert. Wenn du dich von einem neuen Gerät aus anmeldest, muss ein 6-stelliger Sicherheitscode eingegeben werden, den Roblox dir per E-Mail sendet.{lineBreak}{lineBreak}Roblox";
	}

	protected override string _GetTemplateForDescriptionTwoStepVerificationActivationEmailBodyOver13()
	{
		return "Hi {accountName},{lineBreak}{lineBreak}du hast die Verifizierung in 2 Schritten für dein Roblox-Konto aktiviert. Wenn du dich von einem neuen Gerät aus anmeldest, muss ein 6-stelliger Sicherheitscode eingegeben werden, den Roblox dir per E-Mail sendet.{lineBreak}{lineBreak}Roblox";
	}

	/// <summary>
	/// Key: "Description.TwoStepVerificationActivationEmail.Body.Under13"
	/// Body for 2SV activation email for under 13 users
	/// English String: "Hi,{lineBreak}{lineBreak}2-Step Verification has been activated for your child's Roblox account, {accountName}. Next time they log in from a new device, they will need to enter a 6-digit security code that Roblox sends to you via email.{lineBreak}{lineBreak}Roblox"
	/// </summary>
	public override string DescriptionTwoStepVerificationActivationEmailBodyUnder13(string lineBreak, string accountName)
	{
		return $"Hi,{lineBreak}{lineBreak}die Verifizierung in 2 Schritten wurde für das Roblox-Konto „{accountName}“ deines Kindes aktiviert. Wenn sich dein Kind von einem neuen Gerät aus anmeldet, muss ein 6-stelliger Sicherheitscode eingegeben werden, den Roblox dir per E-Mail sendet.{lineBreak}{lineBreak}Roblox";
	}

	protected override string _GetTemplateForDescriptionTwoStepVerificationActivationEmailBodyUnder13()
	{
		return "Hi,{lineBreak}{lineBreak}die Verifizierung in 2 Schritten wurde für das Roblox-Konto „{accountName}“ deines Kindes aktiviert. Wenn sich dein Kind von einem neuen Gerät aus anmeldet, muss ein 6-stelliger Sicherheitscode eingegeben werden, den Roblox dir per E-Mail sendet.{lineBreak}{lineBreak}Roblox";
	}

	/// <summary>
	/// Key: "Description.TwoStepVerificationActivationEmail.Subject"
	/// Subject for 2SV activation email
	/// English String: "2-Step Verification Activated for Roblox Account: {accountName}"
	/// </summary>
	public override string DescriptionTwoStepVerificationActivationEmailSubject(string accountName)
	{
		return $"Verifizierung in 2 Schritten für folgendes Roblox-Konto aktiviert: {accountName}";
	}

	protected override string _GetTemplateForDescriptionTwoStepVerificationActivationEmailSubject()
	{
		return "Verifizierung in 2 Schritten für folgendes Roblox-Konto aktiviert: {accountName}";
	}

	/// <summary>
	/// Key: "Description.TwoStepVerificationDeactivationEmail.Body.Over13"
	/// Body for 2SV deactivation email for over 13 users
	/// English String: "Hi {accountName},{lineBreak}{lineBreak}You have deactivated 2-Step Verification for your Roblox account. A security code will no longer be required when you log into your account.{lineBreak}{lineBreak}Roblox"
	/// </summary>
	public override string DescriptionTwoStepVerificationDeactivationEmailBodyOver13(string accountName, string lineBreak)
	{
		return $"Hi {accountName},{lineBreak}{lineBreak}du hast die Verifizierung in 2 Schritten für dein Roblox-Konto deaktiviert. Zur Anmeldung bei deinem Konto wird kein Sicherheitscode mehr benötigt.{lineBreak}{lineBreak}Roblox";
	}

	protected override string _GetTemplateForDescriptionTwoStepVerificationDeactivationEmailBodyOver13()
	{
		return "Hi {accountName},{lineBreak}{lineBreak}du hast die Verifizierung in 2 Schritten für dein Roblox-Konto deaktiviert. Zur Anmeldung bei deinem Konto wird kein Sicherheitscode mehr benötigt.{lineBreak}{lineBreak}Roblox";
	}

	/// <summary>
	/// Key: "Description.TwoStepVerificationDeactivationEmail.Body.Under13"
	/// Body for 2SV deactivation email for under 13 users
	/// English String: "Hi,{lineBreak}{lineBreak}2-Step Verification has been deactivated for your child's Roblox account, {accountName}. A security code will no longer be required when they log into the account.{lineBreak}{lineBreak}Roblox"
	/// </summary>
	public override string DescriptionTwoStepVerificationDeactivationEmailBodyUnder13(string lineBreak, string accountName)
	{
		return $"Hi,{lineBreak}{lineBreak}die Verifizierung in 2 Schritten für das Roblox Konto „{accountName}“ deines Kindes wurde deaktiviert. Zur Anmeldung bei seinem Konto wird kein Sicherheitscode mehr benötigt.{lineBreak}{lineBreak}Roblox";
	}

	protected override string _GetTemplateForDescriptionTwoStepVerificationDeactivationEmailBodyUnder13()
	{
		return "Hi,{lineBreak}{lineBreak}die Verifizierung in 2 Schritten für das Roblox Konto „{accountName}“ deines Kindes wurde deaktiviert. Zur Anmeldung bei seinem Konto wird kein Sicherheitscode mehr benötigt.{lineBreak}{lineBreak}Roblox";
	}

	/// <summary>
	/// Key: "Description.TwoStepVerificationDeactivationEmail.Subject	"
	/// Subject for 2SV deactivation email
	/// English String: "2-Step Verification Deactivated for Roblox Account: {accountName}"
	/// </summary>
	public override string DescriptionTwoStepVerificationDeactivationEmailSubject(string accountName)
	{
		return $"Verifizierung in 2 Schritten für folgendes Roblox-Konto deaktiviert: {accountName}";
	}

	protected override string _GetTemplateForDescriptionTwoStepVerificationDeactivationEmailSubject()
	{
		return "Verifizierung in 2 Schritten für folgendes Roblox-Konto deaktiviert: {accountName}";
	}

	/// <summary>
	/// Key: "Description.TwoStepVerificationLoginEmail.Html.GeolocationInfo1"
	/// Geolocation information about IP trying to login
	/// English String: "{spanStartTagWithBold}Login request received from {username} located in {region}, {country} ({ipAddress}).{spanEndTag}{lineBreak}{lineBreak}"
	/// </summary>
	public override string DescriptionTwoStepVerificationLoginEmailHtmlGeolocationInfo1(string spanStartTagWithBold, string username, string region, string country, string ipAddress, string spanEndTag, string lineBreak)
	{
		return $"{spanStartTagWithBold}Anmeldeanfrage von {username} in {region}, {country} ({ipAddress}).{spanEndTag}{lineBreak}{lineBreak}";
	}

	protected override string _GetTemplateForDescriptionTwoStepVerificationLoginEmailHtmlGeolocationInfo1()
	{
		return "{spanStartTagWithBold}Anmeldeanfrage von {username} in {region}, {country} ({ipAddress}).{spanEndTag}{lineBreak}{lineBreak}";
	}

	/// <summary>
	/// Key: "Description.TwoStepVerificationLoginEmail.Html.GeolocationInfo2"
	/// Geolocation info about IP trying to login
	/// English String: "{spanStartTagWithBold}Login request received from {username} located in {country} ({ipAddress}).{spanEndTag}{lineBreak}{lineBreak}\t"
	/// </summary>
	public override string DescriptionTwoStepVerificationLoginEmailHtmlGeolocationInfo2(string spanStartTagWithBold, string username, string country, string ipAddress, string spanEndTag, string lineBreak)
	{
		return $"{spanStartTagWithBold}Anmeldeanfrage von {username} in {country} ({ipAddress}).{spanEndTag}{lineBreak}{lineBreak}";
	}

	protected override string _GetTemplateForDescriptionTwoStepVerificationLoginEmailHtmlGeolocationInfo2()
	{
		return "{spanStartTagWithBold}Anmeldeanfrage von {username} in {country} ({ipAddress}).{spanEndTag}{lineBreak}{lineBreak}";
	}

	/// <summary>
	/// Key: "Description.TwoStepVerificationLoginEmail.Html.GeolocationInfo3"
	/// Geolocation info about IP trying to log in
	/// English String: "{spanStartTagWithBold}Login request received from {username} (From Roblox Internal).{spanEndTag}{lineBreak}{lineBreak}\t"
	/// </summary>
	public override string DescriptionTwoStepVerificationLoginEmailHtmlGeolocationInfo3(string spanStartTagWithBold, string username, string spanEndTag, string lineBreak)
	{
		return $"{spanStartTagWithBold}Anmeldeanfrage von {username} (von Roblox intern).{spanEndTag}{lineBreak}{lineBreak}";
	}

	protected override string _GetTemplateForDescriptionTwoStepVerificationLoginEmailHtmlGeolocationInfo3()
	{
		return "{spanStartTagWithBold}Anmeldeanfrage von {username} (von Roblox intern).{spanEndTag}{lineBreak}{lineBreak}";
	}

	/// <summary>
	/// Key: "Description.TwoStepVerificationLoginEmail.Html.GeolocationInfo4"
	/// Geolocation info of IP trying to login
	/// English String: "{spanStartTagWithBold}Login request received from {username} located in {country}.{spanEndTag}{lineBreak}{lineBreak}"
	/// </summary>
	public override string DescriptionTwoStepVerificationLoginEmailHtmlGeolocationInfo4(string spanStartTagWithBold, string username, string country, string spanEndTag, string lineBreak)
	{
		return $"{spanStartTagWithBold}Anmeldeanfrage von {username} in {country}.{spanEndTag}{lineBreak}{lineBreak}";
	}

	protected override string _GetTemplateForDescriptionTwoStepVerificationLoginEmailHtmlGeolocationInfo4()
	{
		return "{spanStartTagWithBold}Anmeldeanfrage von {username} in {country}.{spanEndTag}{lineBreak}{lineBreak}";
	}

	/// <summary>
	/// Key: "Description.TwoStepVerificationLoginEmail.Html.GeolocationInfo5"
	/// Geolocation info of IP trying to login
	/// English String: "{spanStartTagWithBold}Login request received from {username} located in {region}, {country}.{spanEndTag}{lineBreak}{lineBreak}"
	/// </summary>
	public override string DescriptionTwoStepVerificationLoginEmailHtmlGeolocationInfo5(string spanStartTagWithBold, string username, string region, string country, string spanEndTag, string lineBreak)
	{
		return $"{spanStartTagWithBold}Anmeldeanfrage von {username} in {region}, {country}.{spanEndTag}{lineBreak}{lineBreak}";
	}

	protected override string _GetTemplateForDescriptionTwoStepVerificationLoginEmailHtmlGeolocationInfo5()
	{
		return "{spanStartTagWithBold}Anmeldeanfrage von {username} in {region}, {country}.{spanEndTag}{lineBreak}{lineBreak}";
	}

	/// <summary>
	/// Key: "Description.TwoStepVerificationLoginEmail.Html.GeolocationInfo6"
	/// Geolocation info of IP trying to login
	/// English String: "{spanStartTagWithBold}Login request received from {username} located in {city}, {region}, {country}.{spanEndTag}{lineBreak}{lineBreak}"
	/// </summary>
	public override string DescriptionTwoStepVerificationLoginEmailHtmlGeolocationInfo6(string spanStartTagWithBold, string username, string city, string region, string country, string spanEndTag, string lineBreak)
	{
		return $"{spanStartTagWithBold}Anmeldeanfrage von {username} in {city}, {region}, {country}.{spanEndTag}{lineBreak}{lineBreak}";
	}

	protected override string _GetTemplateForDescriptionTwoStepVerificationLoginEmailHtmlGeolocationInfo6()
	{
		return "{spanStartTagWithBold}Anmeldeanfrage von {username} in {city}, {region}, {country}.{spanEndTag}{lineBreak}{lineBreak}";
	}

	/// <summary>
	/// Key: "Description.TwoStepVerificationLoginEmail.HtmlBody"
	/// Html body for 2SV login email
	/// English String: "{geoLocationInformation}{spanStartTagWithBold}Login code for {accountName}: {lineBreak}{lineBreak}{code} {spanEndTag}{lineBreak}{lineBreak}Enter this code into the 2-Step Verification screen to finish logging in. This code will expire in 15 minutes.{lineBreak}{lineBreak}This email was sent because your account tried to login to Roblox from a new browser or device. If you haven't tried logging into Roblox, someone else may be trying to access your account. You are strongly advised to change your password if you did not generate this request.{lineBreak}{lineBreak}Resources:{lineBreak}{aTagStartWithHref}{ChangePasswordLink}{hrefEnd}Change Your Password{aTagEnd} {lineBreak}{aTagStartWithHref}{TwoStepVerificationArticleLink}{hrefEnd}Learn More About 2-Step Verification{aTagEnd} {lineBreak}{aTagStartWithHref}{AccountSafetyArticleLink}{hrefEnd}Keeping Your Account Safe{aTagEnd} {lineBreak}{aTagStartWithHref}{SupportLink}{hrefEnd}General Roblox Support{aTagEnd} {lineBreak}{lineBreak}Thank you,{lineBreak}{lineBreak}The Roblox Team"
	/// </summary>
	public override string DescriptionTwoStepVerificationLoginEmailHtmlBody(string geoLocationInformation, string spanStartTagWithBold, string accountName, string lineBreak, string code, string spanEndTag, string aTagStartWithHref, string ChangePasswordLink, string hrefEnd, string aTagEnd, string TwoStepVerificationArticleLink, string AccountSafetyArticleLink, string SupportLink)
	{
		return $"{geoLocationInformation}{spanStartTagWithBold}Anmeldungscode für {accountName}: {lineBreak}{lineBreak} {code}{spanEndTag}{lineBreak}{lineBreak}Gib diesen Code im Fenster für die Verifizierung in 2 Schritten ein, um die Anmeldung abzuschließen. Dieser Code läuft in 15 Minuten ab.{lineBreak}{lineBreak}Du erhältst diese E-Mail, weil es einen Anmeldungsversuch für dein Roblox-Konto von einem neuen Browser oder Gerät gab. Solltest du nicht selbst versucht haben, dich bei Roblox anzumelden, könnte jemand anders versuchen, sich Zugang zu deinem Konto zu verschaffen. Wir empfehlen dir dringend, dein Passwort zu ändern, falls diese Anfrage nicht von dir selbst kam.{lineBreak}{lineBreak}Ressourcen:{lineBreak}{aTagStartWithHref}{ChangePasswordLink}{hrefEnd}Ändere dein Passwort{aTagEnd} {lineBreak}{aTagStartWithHref}{TwoStepVerificationArticleLink}{hrefEnd}Erfahre mehr über die Verifizierung in 2 Schritten{aTagEnd} {lineBreak}{aTagStartWithHref}{AccountSafetyArticleLink}{hrefEnd}Sichere dein Konto ab{aTagEnd} {lineBreak}{aTagStartWithHref}{SupportLink}{hrefEnd}Allgemeiner Roblox-Support{aTagEnd} {lineBreak}{lineBreak}Vielen Dank{lineBreak}{lineBreak}Das Roblox-Team";
	}

	protected override string _GetTemplateForDescriptionTwoStepVerificationLoginEmailHtmlBody()
	{
		return "{geoLocationInformation}{spanStartTagWithBold}Anmeldungscode für {accountName}: {lineBreak}{lineBreak} {code}{spanEndTag}{lineBreak}{lineBreak}Gib diesen Code im Fenster für die Verifizierung in 2 Schritten ein, um die Anmeldung abzuschließen. Dieser Code läuft in 15 Minuten ab.{lineBreak}{lineBreak}Du erhältst diese E-Mail, weil es einen Anmeldungsversuch für dein Roblox-Konto von einem neuen Browser oder Gerät gab. Solltest du nicht selbst versucht haben, dich bei Roblox anzumelden, könnte jemand anders versuchen, sich Zugang zu deinem Konto zu verschaffen. Wir empfehlen dir dringend, dein Passwort zu ändern, falls diese Anfrage nicht von dir selbst kam.{lineBreak}{lineBreak}Ressourcen:{lineBreak}{aTagStartWithHref}{ChangePasswordLink}{hrefEnd}Ändere dein Passwort{aTagEnd} {lineBreak}{aTagStartWithHref}{TwoStepVerificationArticleLink}{hrefEnd}Erfahre mehr über die Verifizierung in 2 Schritten{aTagEnd} {lineBreak}{aTagStartWithHref}{AccountSafetyArticleLink}{hrefEnd}Sichere dein Konto ab{aTagEnd} {lineBreak}{aTagStartWithHref}{SupportLink}{hrefEnd}Allgemeiner Roblox-Support{aTagEnd} {lineBreak}{lineBreak}Vielen Dank{lineBreak}{lineBreak}Das Roblox-Team";
	}

	/// <summary>
	/// Key: "Description.TwoStepVerificationLoginEmail.PlainBody"
	/// Plain body for 2SV login email
	/// English String: "{geoLocationInformation}Login code for {accountName}: {lineBreak}{lineBreak} {code} {lineBreak}{lineBreak}Enter this code into the 2-Step Verification screen to finish logging in. This code will expire in 15 minutes. {lineBreak}{lineBreak}This email was sent because your account tried to login to Roblox from a new browser or device. If you haven't tried logging into Roblox, someone else may be trying to access your account. You are strongly advised to change your password if you did not generate this request. {lineBreak}{lineBreak}Resources: {lineBreak}Change Your Password [{accountInfoPageLink}] {lineBreak}Learn More About 2-Step Verification [{twoStepVerificationHelpArticleLink}]{lineBreak}Keeping Your Account Safe [{keepAccountSafeArticleLink}] {lineBreak}General Roblox Support [{supportPageLink}] {lineBreak}{lineBreak}Thank you, {lineBreak}{lineBreak}The Roblox Team"
	/// </summary>
	public override string DescriptionTwoStepVerificationLoginEmailPlainBody(string geoLocationInformation, string accountName, string lineBreak, string code, string accountInfoPageLink, string twoStepVerificationHelpArticleLink, string keepAccountSafeArticleLink, string supportPageLink)
	{
		return $"{geoLocationInformation}Anmeldungscode für {accountName}: {lineBreak}{lineBreak} {code} {lineBreak}{lineBreak}Gib diesen Code im Fenster für die Verifizierung in 2 Schritten ein, um die Anmeldung abzuschließen. Dieser Code läuft in 15 Minuten ab. {lineBreak}{lineBreak}Du erhältst diese E-Mail, weil es einen Anmeldungsversuch für dein Roblox-Konto von einem neuen Browser oder Gerät gab. Solltest du nicht selbst versucht haben, dich bei Roblox anzumelden, könnte jemand anders versuchen, sich Zugang zu deinem Konto zu verschaffen. Wir empfehlen dir dringend, dein Passwort zu ändern, falls diese Anfrage nicht von dir selbst kam. {lineBreak}{lineBreak}Ressourcen: {lineBreak}Ändere dein Passwort [{accountInfoPageLink}] {lineBreak}Erfahre mehr über die Verifizierung in 2 Schritten [{twoStepVerificationHelpArticleLink}]{lineBreak}Sichere dein Konto ab [{keepAccountSafeArticleLink}] {lineBreak}Allgemeiner Roblox-Support [{supportPageLink}] {lineBreak}{lineBreak}Vielen Dank{lineBreak}{lineBreak}Das Roblox-Team";
	}

	protected override string _GetTemplateForDescriptionTwoStepVerificationLoginEmailPlainBody()
	{
		return "{geoLocationInformation}Anmeldungscode für {accountName}: {lineBreak}{lineBreak} {code} {lineBreak}{lineBreak}Gib diesen Code im Fenster für die Verifizierung in 2 Schritten ein, um die Anmeldung abzuschließen. Dieser Code läuft in 15 Minuten ab. {lineBreak}{lineBreak}Du erhältst diese E-Mail, weil es einen Anmeldungsversuch für dein Roblox-Konto von einem neuen Browser oder Gerät gab. Solltest du nicht selbst versucht haben, dich bei Roblox anzumelden, könnte jemand anders versuchen, sich Zugang zu deinem Konto zu verschaffen. Wir empfehlen dir dringend, dein Passwort zu ändern, falls diese Anfrage nicht von dir selbst kam. {lineBreak}{lineBreak}Ressourcen: {lineBreak}Ändere dein Passwort [{accountInfoPageLink}] {lineBreak}Erfahre mehr über die Verifizierung in 2 Schritten [{twoStepVerificationHelpArticleLink}]{lineBreak}Sichere dein Konto ab [{keepAccountSafeArticleLink}] {lineBreak}Allgemeiner Roblox-Support [{supportPageLink}] {lineBreak}{lineBreak}Vielen Dank{lineBreak}{lineBreak}Das Roblox-Team";
	}

	/// <summary>
	/// Key: "Description.TwoStepVerificationLoginEmail.PlainText.GeolocationInfo1"
	/// GeoLocation info of IP trying to login
	/// English String: "Login request received from {username} located in {region}, {country} ({ipAddress}).{lineBreak}{lineBreak}"
	/// </summary>
	public override string DescriptionTwoStepVerificationLoginEmailPlainTextGeolocationInfo1(string username, string region, string country, string ipAddress, string lineBreak)
	{
		return $"Anmeldeanfrage von {username} in {region}, {country} ({ipAddress}).{lineBreak}{lineBreak}";
	}

	protected override string _GetTemplateForDescriptionTwoStepVerificationLoginEmailPlainTextGeolocationInfo1()
	{
		return "Anmeldeanfrage von {username} in {region}, {country} ({ipAddress}).{lineBreak}{lineBreak}";
	}

	/// <summary>
	/// Key: "Description.TwoStepVerificationLoginEmail.PlainText.GeolocationInfo2"
	/// Geolocation info of IP trying to login
	/// English String: "Login request received from {username} located in {country} ({ipAddress}).{lineBreak}{lineBreak}"
	/// </summary>
	public override string DescriptionTwoStepVerificationLoginEmailPlainTextGeolocationInfo2(string username, string country, string ipAddress, string lineBreak)
	{
		return $"Anmeldeanfrage von {username} in {country} ({ipAddress}).{lineBreak}{lineBreak}";
	}

	protected override string _GetTemplateForDescriptionTwoStepVerificationLoginEmailPlainTextGeolocationInfo2()
	{
		return "Anmeldeanfrage von {username} in {country} ({ipAddress}).{lineBreak}{lineBreak}";
	}

	/// <summary>
	/// Key: "Description.TwoStepVerificationLoginEmail.PlainText.GeolocationInfo3"
	/// Geolocation info of IP trying to login
	/// English String: "Login request received from {username} (From Roblox Internal).{lineBreak}{lineBreak}"
	/// </summary>
	public override string DescriptionTwoStepVerificationLoginEmailPlainTextGeolocationInfo3(string username, string lineBreak)
	{
		return $"Anmeldeanfrage von {username} (von Roblox intern).{lineBreak}{lineBreak}";
	}

	protected override string _GetTemplateForDescriptionTwoStepVerificationLoginEmailPlainTextGeolocationInfo3()
	{
		return "Anmeldeanfrage von {username} (von Roblox intern).{lineBreak}{lineBreak}";
	}

	/// <summary>
	/// Key: "Description.TwoStepVerificationLoginEmail.PlainText.GeolocationInfo4"
	/// Geolocation info of IP trying to login
	/// English String: "Login request received from {username} located in {country}.{lineBreak}{lineBreak}"
	/// </summary>
	public override string DescriptionTwoStepVerificationLoginEmailPlainTextGeolocationInfo4(string username, string country, string lineBreak)
	{
		return $"Anmeldeanfrage von {username} in {country}.{lineBreak}{lineBreak}";
	}

	protected override string _GetTemplateForDescriptionTwoStepVerificationLoginEmailPlainTextGeolocationInfo4()
	{
		return "Anmeldeanfrage von {username} in {country}.{lineBreak}{lineBreak}";
	}

	/// <summary>
	/// Key: "Description.TwoStepVerificationLoginEmail.PlainText.GeolocationInfo5"
	/// Geolocation info of IP trying to login
	/// English String: "Login request received from {username} located in {region}, {country}.{lineBreak}{lineBreak}"
	/// </summary>
	public override string DescriptionTwoStepVerificationLoginEmailPlainTextGeolocationInfo5(string username, string region, string country, string lineBreak)
	{
		return $"Anmeldeanfrage von {username} in {region}, {country}.{lineBreak}{lineBreak}";
	}

	protected override string _GetTemplateForDescriptionTwoStepVerificationLoginEmailPlainTextGeolocationInfo5()
	{
		return "Anmeldeanfrage von {username} in {region}, {country}.{lineBreak}{lineBreak}";
	}

	/// <summary>
	/// Key: "Description.TwoStepVerificationLoginEmail.PlainText.GeolocationInfo6"
	/// Geolocation info of IP trying to login
	/// English String: "Login request received from {username} located in {city}, {region}, {country}.{lineBreak}{lineBreak}"
	/// </summary>
	public override string DescriptionTwoStepVerificationLoginEmailPlainTextGeolocationInfo6(string username, string city, string region, string country, string lineBreak)
	{
		return $"Anmeldeanfrage von {username} in {city}, {region}, {country}.{lineBreak}{lineBreak}";
	}

	protected override string _GetTemplateForDescriptionTwoStepVerificationLoginEmailPlainTextGeolocationInfo6()
	{
		return "Anmeldeanfrage von {username} in {city}, {region}, {country}.{lineBreak}{lineBreak}";
	}

	/// <summary>
	/// Key: "Description.TwoStepVerificationLoginEmail.Subject"
	/// Subject for 2SV login email
	/// English String: "Verification Code for Roblox Account: {accountName}"
	/// </summary>
	public override string DescriptionTwoStepVerificationLoginEmailSubject(string accountName)
	{
		return $"Verifizierungscode für Roblox-Konto: {accountName}";
	}

	protected override string _GetTemplateForDescriptionTwoStepVerificationLoginEmailSubject()
	{
		return "Verifizierungscode für Roblox-Konto: {accountName}";
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
		return $"Bitte {codeLength}-stelligen Code eingeben";
	}

	protected override string _GetTemplateForLabelCodeInputPlaceholderText()
	{
		return "Bitte {codeLength}-stelligen Code eingeben";
	}

	protected override string _GetTemplateForLabelDidNotReceive()
	{
		return "Code nicht erhalten?";
	}

	protected override string _GetTemplateForLabelEnterCode()
	{
		return "Code eingeben (6-stellig)";
	}

	protected override string _GetTemplateForLabelEnterEmailCode()
	{
		return "Gib den Code ein, den wir dir gerade per E-Mail geschickt haben.";
	}

	protected override string _GetTemplateForLabelEnterTextCode()
	{
		return "Gib den Code ein, den wir dir gerade per SMS geschickt haben.";
	}

	protected override string _GetTemplateForLabelEnterTwoStepVerificationCode()
	{
		return "Gib deinen Code für die Verifizierung in zwei Schritten ein.";
	}

	protected override string _GetTemplateForLabelFacebookPasswordWarning()
	{
		return "Solltest du dich bisher mit Facebook angemeldet haben, musst du ein Passwort erstellen.";
	}

	protected override string _GetTemplateForLabelLearnMore()
	{
		return "Mehr erfahren";
	}

	/// <summary>
	/// Key: "Label.NeedHelpContactSupport"
	/// label for the support article link
	/// English String: "Need help? Contact {supportLink}"
	/// </summary>
	public override string LabelNeedHelpContactSupport(string supportLink)
	{
		return $"Brauchst du Hilfe? Kontaktiere {supportLink}";
	}

	protected override string _GetTemplateForLabelNeedHelpContactSupport()
	{
		return "Brauchst du Hilfe? Kontaktiere {supportLink}";
	}

	protected override string _GetTemplateForLabelNewCode()
	{
		return "Neuer Code";
	}

	protected override string _GetTemplateForLabelRobloxSupport()
	{
		return "Roblox-Support";
	}

	protected override string _GetTemplateForLabelTrustThisDevice()
	{
		return "Diesem Gerät für 30 Tage vertrauen";
	}

	protected override string _GetTemplateForLabelTwoStepVerification()
	{
		return "Verifizierung in 2 Schritten";
	}

	protected override string _GetTemplateForResponseCodeSent()
	{
		return "Code gesendet";
	}

	protected override string _GetTemplateForResponseFeatureNotAvailable()
	{
		return "Feature nicht verfügbar. Bitte kontaktiere den Support.";
	}

	protected override string _GetTemplateForResponseInvalidCode()
	{
		return "Ungültiger Code.";
	}

	protected override string _GetTemplateForResponseSystemErrorReturnToLogin()
	{
		return "Systemfehler. Bitte kehre zum Anmeldefenster zurück.";
	}

	protected override string _GetTemplateForResponseTooManyAttempts()
	{
		return "Zu viele Versuche. Bitte versuche es später erneut.";
	}

	protected override string _GetTemplateForResponseTooManyCharacters()
	{
		return "Zu viele Zeichen";
	}
}
