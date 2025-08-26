namespace Roblox.Platform.TranslationResources.Authentication {
    /// <summary>

/// This class overrides TwoStepVerificationResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class TwoStepVerificationResources_tr_tr : TwoStepVerificationResources_en_us, ITwoStepVerificationResources, ITranslationResources
{
	/// <summary>
	/// Key: "Action.Cancel"
	/// English String: "Cancel"
	/// </summary>
	public override string ActionCancel => "Ä°ptal Et";

	/// <summary>
	/// Key: "Action.Resend"
	/// English String: "Resend Code"
	/// </summary>
	public override string ActionResend => "Kodu Tekrar GÃ¶nder";

	/// <summary>
	/// Key: "Action.StartOver"
	/// link text to restart verification
	/// English String: "Start Over"
	/// </summary>
	public override string ActionStartOver => "Yeniden BaÅŸlat";

	/// <summary>
	/// Key: "Action.Submit"
	/// submit button text
	/// English String: "Submit"
	/// </summary>
	public override string ActionSubmit => "GÃ¶nder";

	/// <summary>
	/// Key: "Action.Verify"
	/// English String: "Verify"
	/// </summary>
	public override string ActionVerify => "DoÄŸrula";

	/// <summary>
	/// Key: "Label.Code"
	/// verification code for 2 factor authentication
	/// English String: "Code"
	/// </summary>
	public override string LabelCode => "Kod";

	/// <summary>
	/// Key: "Label.DidNotReceive"
	/// English String: "Didn't receive the code?"
	/// </summary>
	public override string LabelDidNotReceive => "Kodu almadÄ±n mÄ±?";

	/// <summary>
	/// Key: "Label.EnterCode"
	/// English String: "Enter Code (6-digit)"
	/// </summary>
	public override string LabelEnterCode => "Kodu Gir (6 hane)";

	/// <summary>
	/// Key: "Label.EnterEmailCode"
	/// English String: "Enter the code we just sent you via email"
	/// </summary>
	public override string LabelEnterEmailCode => "E-posta ile gÃ¶nderdiÄŸimiz kodu gir";

	/// <summary>
	/// Key: "Label.EnterTextCode"
	/// English String: "Enter the code we just sent you via text message"
	/// </summary>
	public override string LabelEnterTextCode => "SMS ile gÃ¶nderdiÄŸimiz kodu gir";

	/// <summary>
	/// Key: "Label.EnterTwoStepVerificationCode"
	/// Enter your two step verification code.
	/// English String: "Enter your two step verification code."
	/// </summary>
	public override string LabelEnterTwoStepVerificationCode => "Ä°ki aÅŸamalÄ± onay kodunu gir.";

	/// <summary>
	/// Key: "Label.FacebookPasswordWarning"
	/// If you have been signing in with Facebook, you must set a password.
	/// English String: "If you have been signing in with Facebook, you must set a password."
	/// </summary>
	public override string LabelFacebookPasswordWarning => "EÄŸer ÅŸimdiye kadar Facebook ile giriÅŸ yaptÄ±ysan bir ÅŸifre seÃ§melisin.";

	/// <summary>
	/// Key: "Label.LearnMore"
	/// Learn More link text
	/// English String: "Learn More"
	/// </summary>
	public override string LabelLearnMore => "Daha FazlasÄ±nÄ± Ã–ÄŸren";

	/// <summary>
	/// Key: "Label.NewCode"
	/// verification code resent, label changes to new code
	/// English String: "New Code"
	/// </summary>
	public override string LabelNewCode => "Yeni Kod";

	/// <summary>
	/// Key: "Label.RobloxSupport"
	/// English String: "Roblox Support"
	/// </summary>
	public override string LabelRobloxSupport => "Roblox DesteÄŸi";

	/// <summary>
	/// Key: "Label.TrustThisDevice"
	/// English String: "Trust this device for 30 days"
	/// </summary>
	public override string LabelTrustThisDevice => "30 gÃ¼nlÃ¼ÄŸÃ¼ne bu cihaza gÃ¼ven";

	/// <summary>
	/// Key: "Label.TwoStepVerification"
	/// English String: "2-Step Verification"
	/// </summary>
	public override string LabelTwoStepVerification => "2-AdÄ±mlÄ± DoÄŸrulama";

	/// <summary>
	/// Key: "Response.CodeSent"
	/// English String: "Code Sent"
	/// </summary>
	public override string ResponseCodeSent => "Kod GÃ¶nderildi";

	/// <summary>
	/// Key: "Response.FeatureNotAvailable"
	/// English String: "Feature not available. Please contact support."
	/// </summary>
	public override string ResponseFeatureNotAvailable => "Ã–zellik kullanÄ±lamÄ±yor. LÃ¼tfen destek ile iletiÅŸime geÃ§.";

	/// <summary>
	/// Key: "Response.InvalidCode"
	/// English String: "Invalid code."
	/// </summary>
	public override string ResponseInvalidCode => "GeÃ§ersiz kod.";

	/// <summary>
	/// Key: "Response.SystemErrorReturnToLogin"
	/// English String: "System error. Please return to login screen."
	/// </summary>
	public override string ResponseSystemErrorReturnToLogin => "Sistem hatasÄ±. LÃ¼tfen giriÅŸ ekranÄ±na dÃ¶n.";

	/// <summary>
	/// Key: "Response.TooManyAttempts"
	/// English String: "Too many attempts. Please try again later."
	/// </summary>
	public override string ResponseTooManyAttempts => "Ã‡ok sayÄ±da deneme. LÃ¼tfen daha sonra tekrar dene.";

	/// <summary>
	/// Key: "Response.TooManyCharacters"
	/// error message
	/// English String: "Too many characters"
	/// </summary>
	public override string ResponseTooManyCharacters => "Ã‡ok fazla karakter";

	public TwoStepVerificationResources_tr_tr(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionCancel()
	{
		return "Ä°ptal Et";
	}

	protected override string _GetTemplateForActionResend()
	{
		return "Kodu Tekrar GÃ¶nder";
	}

	protected override string _GetTemplateForActionStartOver()
	{
		return "Yeniden BaÅŸlat";
	}

	protected override string _GetTemplateForActionSubmit()
	{
		return "GÃ¶nder";
	}

	protected override string _GetTemplateForActionVerify()
	{
		return "DoÄŸrula";
	}

	/// <summary>
	/// Key: "Description.TwoStepVerificationActivationEmail.Body.Over13"
	/// Body for 2SV activation email for over 13 users
	/// English String: "Hi {accountName},{lineBreak}{lineBreak}You have activated 2-Step Verification for your Roblox account. Next time you log in from a new device, you will need to enter a 6-digit security code that Roblox sends to you via email.{lineBreak}{lineBreak}Roblox"
	/// </summary>
	public override string DescriptionTwoStepVerificationActivationEmailBodyOver13(string accountName, string lineBreak)
	{
		return $"Merhaba {accountName},{lineBreak}{lineBreak}Roblox hesabÄ±n iÃ§in 2-AdÄ±mlÄ± DoÄŸrulamayÄ± etkinleÅŸtirdin. Yeni bir cihazdan giriÅŸ yaptÄ±ÄŸÄ±nda Roblox'un e-postayla gÃ¶ndereceÄŸi 6 haneli gÃ¼venlik kodunu girmen gerekecek.{lineBreak}{lineBreak}Roblox";
	}

	protected override string _GetTemplateForDescriptionTwoStepVerificationActivationEmailBodyOver13()
	{
		return "Merhaba {accountName},{lineBreak}{lineBreak}Roblox hesabÄ±n iÃ§in 2-AdÄ±mlÄ± DoÄŸrulamayÄ± etkinleÅŸtirdin. Yeni bir cihazdan giriÅŸ yaptÄ±ÄŸÄ±nda Roblox'un e-postayla gÃ¶ndereceÄŸi 6 haneli gÃ¼venlik kodunu girmen gerekecek.{lineBreak}{lineBreak}Roblox";
	}

	/// <summary>
	/// Key: "Description.TwoStepVerificationActivationEmail.Body.Under13"
	/// Body for 2SV activation email for under 13 users
	/// English String: "Hi,{lineBreak}{lineBreak}2-Step Verification has been activated for your child's Roblox account, {accountName}. Next time they log in from a new device, they will need to enter a 6-digit security code that Roblox sends to you via email.{lineBreak}{lineBreak}Roblox"
	/// </summary>
	public override string DescriptionTwoStepVerificationActivationEmailBodyUnder13(string lineBreak, string accountName)
	{
		return $"Merhaba,{lineBreak}{lineBreak}Ã‡ocuÄŸunuzun {accountName} adlÄ± Roblox hesabÄ± iÃ§in 2-AdÄ±mlÄ± DoÄŸrulama etkinleÅŸtirildi. Yeni bir cihazdan giriÅŸ yaptÄ±ÄŸÄ±nda Roblox'un e-postayla size gÃ¶ndereceÄŸi 6 haneli gÃ¼venlik kodunu girmesi gerekecek.{lineBreak}{lineBreak}Roblox";
	}

	protected override string _GetTemplateForDescriptionTwoStepVerificationActivationEmailBodyUnder13()
	{
		return "Merhaba,{lineBreak}{lineBreak}Ã‡ocuÄŸunuzun {accountName} adlÄ± Roblox hesabÄ± iÃ§in 2-AdÄ±mlÄ± DoÄŸrulama etkinleÅŸtirildi. Yeni bir cihazdan giriÅŸ yaptÄ±ÄŸÄ±nda Roblox'un e-postayla size gÃ¶ndereceÄŸi 6 haneli gÃ¼venlik kodunu girmesi gerekecek.{lineBreak}{lineBreak}Roblox";
	}

	/// <summary>
	/// Key: "Description.TwoStepVerificationActivationEmail.Subject"
	/// Subject for 2SV activation email
	/// English String: "2-Step Verification Activated for Roblox Account: {accountName}"
	/// </summary>
	public override string DescriptionTwoStepVerificationActivationEmailSubject(string accountName)
	{
		return $"Roblox HesabÄ± iÃ§in 2-AdÄ±mlÄ± DoÄŸrulama EtkinleÅŸtirildi: {accountName}";
	}

	protected override string _GetTemplateForDescriptionTwoStepVerificationActivationEmailSubject()
	{
		return "Roblox HesabÄ± iÃ§in 2-AdÄ±mlÄ± DoÄŸrulama EtkinleÅŸtirildi: {accountName}";
	}

	/// <summary>
	/// Key: "Description.TwoStepVerificationDeactivationEmail.Body.Over13"
	/// Body for 2SV deactivation email for over 13 users
	/// English String: "Hi {accountName},{lineBreak}{lineBreak}You have deactivated 2-Step Verification for your Roblox account. A security code will no longer be required when you log into your account.{lineBreak}{lineBreak}Roblox"
	/// </summary>
	public override string DescriptionTwoStepVerificationDeactivationEmailBodyOver13(string accountName, string lineBreak)
	{
		return $"Merhaba {accountName},{lineBreak}{lineBreak}Roblox hesabÄ±n iÃ§in 2-AdÄ±mlÄ± DoÄŸrulamayÄ± devre dÄ±ÅŸÄ± bÄ±raktÄ±n. HesabÄ±na giriÅŸ yaptÄ±ÄŸÄ±nda bir gÃ¼venlik kodu girmen gerekmeyecek.{lineBreak}{lineBreak}Roblox";
	}

	protected override string _GetTemplateForDescriptionTwoStepVerificationDeactivationEmailBodyOver13()
	{
		return "Merhaba {accountName},{lineBreak}{lineBreak}Roblox hesabÄ±n iÃ§in 2-AdÄ±mlÄ± DoÄŸrulamayÄ± devre dÄ±ÅŸÄ± bÄ±raktÄ±n. HesabÄ±na giriÅŸ yaptÄ±ÄŸÄ±nda bir gÃ¼venlik kodu girmen gerekmeyecek.{lineBreak}{lineBreak}Roblox";
	}

	/// <summary>
	/// Key: "Description.TwoStepVerificationDeactivationEmail.Body.Under13"
	/// Body for 2SV deactivation email for under 13 users
	/// English String: "Hi,{lineBreak}{lineBreak}2-Step Verification has been deactivated for your child's Roblox account, {accountName}. A security code will no longer be required when they log into the account.{lineBreak}{lineBreak}Roblox"
	/// </summary>
	public override string DescriptionTwoStepVerificationDeactivationEmailBodyUnder13(string lineBreak, string accountName)
	{
		return $"Merhaba,{lineBreak}{lineBreak}Ã‡ocuÄŸunuzun {accountName} adlÄ± Roblox hesabÄ±nda 2-AdÄ±mlÄ± DoÄŸrulama devre dÄ±ÅŸÄ± bÄ±rakÄ±ldÄ±. Hesaba giriÅŸ yaptÄ±ÄŸÄ±nda bir gÃ¼venlik kodu girmesi gerekmeyecek.{lineBreak}{lineBreak}Roblox";
	}

	protected override string _GetTemplateForDescriptionTwoStepVerificationDeactivationEmailBodyUnder13()
	{
		return "Merhaba,{lineBreak}{lineBreak}Ã‡ocuÄŸunuzun {accountName} adlÄ± Roblox hesabÄ±nda 2-AdÄ±mlÄ± DoÄŸrulama devre dÄ±ÅŸÄ± bÄ±rakÄ±ldÄ±. Hesaba giriÅŸ yaptÄ±ÄŸÄ±nda bir gÃ¼venlik kodu girmesi gerekmeyecek.{lineBreak}{lineBreak}Roblox";
	}

	/// <summary>
	/// Key: "Description.TwoStepVerificationDeactivationEmail.Subject	"
	/// Subject for 2SV deactivation email
	/// English String: "2-Step Verification Deactivated for Roblox Account: {accountName}"
	/// </summary>
	public override string DescriptionTwoStepVerificationDeactivationEmailSubject(string accountName)
	{
		return $"Roblox HesabÄ± iÃ§in 2-AdÄ±mlÄ± DoÄŸrulama Devre DÄ±ÅŸÄ± BÄ±rakÄ±ldÄ±: {accountName}";
	}

	protected override string _GetTemplateForDescriptionTwoStepVerificationDeactivationEmailSubject()
	{
		return "Roblox HesabÄ± iÃ§in 2-AdÄ±mlÄ± DoÄŸrulama Devre DÄ±ÅŸÄ± BÄ±rakÄ±ldÄ±: {accountName}";
	}

	/// <summary>
	/// Key: "Description.TwoStepVerificationLoginEmail.Html.GeolocationInfo1"
	/// Geolocation information about IP trying to login
	/// English String: "{spanStartTagWithBold}Login request received from {username} located in {region}, {country} ({ipAddress}).{spanEndTag}{lineBreak}{lineBreak}"
	/// </summary>
	public override string DescriptionTwoStepVerificationLoginEmailHtmlGeolocationInfo1(string spanStartTagWithBold, string username, string region, string country, string ipAddress, string spanEndTag, string lineBreak)
	{
		return $"{spanStartTagWithBold}{region}, {country} ({ipAddress}) konumunda bulunan {username} tarafÄ±ndan bir giriÅŸ talebi alÄ±ndÄ±.{spanEndTag}{lineBreak}{lineBreak}";
	}

	protected override string _GetTemplateForDescriptionTwoStepVerificationLoginEmailHtmlGeolocationInfo1()
	{
		return "{spanStartTagWithBold}{region}, {country} ({ipAddress}) konumunda bulunan {username} tarafÄ±ndan bir giriÅŸ talebi alÄ±ndÄ±.{spanEndTag}{lineBreak}{lineBreak}";
	}

	/// <summary>
	/// Key: "Description.TwoStepVerificationLoginEmail.Html.GeolocationInfo2"
	/// Geolocation info about IP trying to login
	/// English String: "{spanStartTagWithBold}Login request received from {username} located in {country} ({ipAddress}).{spanEndTag}{lineBreak}{lineBreak}\t"
	/// </summary>
	public override string DescriptionTwoStepVerificationLoginEmailHtmlGeolocationInfo2(string spanStartTagWithBold, string username, string country, string ipAddress, string spanEndTag, string lineBreak)
	{
		return $"{spanStartTagWithBold}{country}, ({ipAddress}) konumunda bulunan {username} tarafÄ±ndan bir giriÅŸ talebi alÄ±ndÄ±.{spanEndTag}{lineBreak}{lineBreak}\t";
	}

	protected override string _GetTemplateForDescriptionTwoStepVerificationLoginEmailHtmlGeolocationInfo2()
	{
		return "{spanStartTagWithBold}{country}, ({ipAddress}) konumunda bulunan {username} tarafÄ±ndan bir giriÅŸ talebi alÄ±ndÄ±.{spanEndTag}{lineBreak}{lineBreak}\t";
	}

	/// <summary>
	/// Key: "Description.TwoStepVerificationLoginEmail.Html.GeolocationInfo3"
	/// Geolocation info about IP trying to log in
	/// English String: "{spanStartTagWithBold}Login request received from {username} (From Roblox Internal).{spanEndTag}{lineBreak}{lineBreak}\t"
	/// </summary>
	public override string DescriptionTwoStepVerificationLoginEmailHtmlGeolocationInfo3(string spanStartTagWithBold, string username, string spanEndTag, string lineBreak)
	{
		return $"{spanStartTagWithBold}{username} (Roblox Dahili) tarafÄ±ndan bir giriÅŸ talebi alÄ±ndÄ±.{spanEndTag}{lineBreak}{lineBreak}\t";
	}

	protected override string _GetTemplateForDescriptionTwoStepVerificationLoginEmailHtmlGeolocationInfo3()
	{
		return "{spanStartTagWithBold}{username} (Roblox Dahili) tarafÄ±ndan bir giriÅŸ talebi alÄ±ndÄ±.{spanEndTag}{lineBreak}{lineBreak}\t";
	}

	/// <summary>
	/// Key: "Description.TwoStepVerificationLoginEmail.Html.GeolocationInfo4"
	/// Geolocation info of IP trying to login
	/// English String: "{spanStartTagWithBold}Login request received from {username} located in {country}.{spanEndTag}{lineBreak}{lineBreak}"
	/// </summary>
	public override string DescriptionTwoStepVerificationLoginEmailHtmlGeolocationInfo4(string spanStartTagWithBold, string username, string country, string spanEndTag, string lineBreak)
	{
		return $"{spanStartTagWithBold}{country} konumunda bulunan {username} tarafÄ±ndan bir giriÅŸ talebi alÄ±ndÄ±.{spanEndTag}{lineBreak}{lineBreak}";
	}

	protected override string _GetTemplateForDescriptionTwoStepVerificationLoginEmailHtmlGeolocationInfo4()
	{
		return "{spanStartTagWithBold}{country} konumunda bulunan {username} tarafÄ±ndan bir giriÅŸ talebi alÄ±ndÄ±.{spanEndTag}{lineBreak}{lineBreak}";
	}

	/// <summary>
	/// Key: "Description.TwoStepVerificationLoginEmail.Html.GeolocationInfo5"
	/// Geolocation info of IP trying to login
	/// English String: "{spanStartTagWithBold}Login request received from {username} located in {region}, {country}.{spanEndTag}{lineBreak}{lineBreak}"
	/// </summary>
	public override string DescriptionTwoStepVerificationLoginEmailHtmlGeolocationInfo5(string spanStartTagWithBold, string username, string region, string country, string spanEndTag, string lineBreak)
	{
		return $"{spanStartTagWithBold}{region}, {country} konumunda bulunan {username} tarafÄ±ndan bir giriÅŸ talebi alÄ±ndÄ±.{spanEndTag}{lineBreak}{lineBreak}";
	}

	protected override string _GetTemplateForDescriptionTwoStepVerificationLoginEmailHtmlGeolocationInfo5()
	{
		return "{spanStartTagWithBold}{region}, {country} konumunda bulunan {username} tarafÄ±ndan bir giriÅŸ talebi alÄ±ndÄ±.{spanEndTag}{lineBreak}{lineBreak}";
	}

	/// <summary>
	/// Key: "Description.TwoStepVerificationLoginEmail.Html.GeolocationInfo6"
	/// Geolocation info of IP trying to login
	/// English String: "{spanStartTagWithBold}Login request received from {username} located in {city}, {region}, {country}.{spanEndTag}{lineBreak}{lineBreak}"
	/// </summary>
	public override string DescriptionTwoStepVerificationLoginEmailHtmlGeolocationInfo6(string spanStartTagWithBold, string username, string city, string region, string country, string spanEndTag, string lineBreak)
	{
		return $"{spanStartTagWithBold}{city}, {region}, {country} konumunda bulunan {username} tarafÄ±ndan bir giriÅŸ talebi alÄ±ndÄ±.{spanEndTag}{lineBreak}{lineBreak}";
	}

	protected override string _GetTemplateForDescriptionTwoStepVerificationLoginEmailHtmlGeolocationInfo6()
	{
		return "{spanStartTagWithBold}{city}, {region}, {country} konumunda bulunan {username} tarafÄ±ndan bir giriÅŸ talebi alÄ±ndÄ±.{spanEndTag}{lineBreak}{lineBreak}";
	}

	/// <summary>
	/// Key: "Description.TwoStepVerificationLoginEmail.HtmlBody"
	/// Html body for 2SV login email
	/// English String: "{geoLocationInformation}{spanStartTagWithBold}Login code for {accountName}: {lineBreak}{lineBreak}{code} {spanEndTag}{lineBreak}{lineBreak}Enter this code into the 2-Step Verification screen to finish logging in. This code will expire in 15 minutes.{lineBreak}{lineBreak}This email was sent because your account tried to login to Roblox from a new browser or device. If you haven't tried logging into Roblox, someone else may be trying to access your account. You are strongly advised to change your password if you did not generate this request.{lineBreak}{lineBreak}Resources:{lineBreak}{aTagStartWithHref}{ChangePasswordLink}{hrefEnd}Change Your Password{aTagEnd} {lineBreak}{aTagStartWithHref}{TwoStepVerificationArticleLink}{hrefEnd}Learn More About 2-Step Verification{aTagEnd} {lineBreak}{aTagStartWithHref}{AccountSafetyArticleLink}{hrefEnd}Keeping Your Account Safe{aTagEnd} {lineBreak}{aTagStartWithHref}{SupportLink}{hrefEnd}General Roblox Support{aTagEnd} {lineBreak}{lineBreak}Thank you,{lineBreak}{lineBreak}The Roblox Team"
	/// </summary>
	public override string DescriptionTwoStepVerificationLoginEmailHtmlBody(string geoLocationInformation, string spanStartTagWithBold, string accountName, string lineBreak, string code, string spanEndTag, string aTagStartWithHref, string ChangePasswordLink, string hrefEnd, string aTagEnd, string TwoStepVerificationArticleLink, string AccountSafetyArticleLink, string SupportLink)
	{
		return $"{geoLocationInformation}{spanStartTagWithBold}{accountName} iÃ§in giriÅŸ yapma kodu: {lineBreak}{lineBreak}{code} {spanEndTag}{lineBreak}{lineBreak}GiriÅŸ yapma iÅŸlemini bitirmek iÃ§in bu kodu 2 AdÄ±mlÄ± DoÄŸrulama ekranÄ±na gir. Bu kodun sÃ¼resi 15 dakika sonra dolacak.{lineBreak}{lineBreak}Bu e-posta, hesabÄ±nla Roblox'a yeni bir tarayÄ±cÄ±dan veya cihazdan girilmeye Ã§alÄ±ÅŸÄ±ldÄ±ÄŸÄ± iÃ§in gÃ¶nderildi. Roblox'a giriÅŸ yapmaya Ã§alÄ±ÅŸmadÄ±ysan hesabÄ±na eriÅŸmeye Ã§alÄ±ÅŸan baÅŸka biri olabilir. Bu isteÄŸi sen oluÅŸturmadÄ±ysan ÅŸifreni deÄŸiÅŸtirmen ÅŸiddetle tavsiye edilir.{lineBreak}{lineBreak}Kaynaklar:{lineBreak}{aTagStartWithHref}{ChangePasswordLink}{hrefEnd}Åžifreni DeÄŸiÅŸtir{aTagEnd} {lineBreak}{aTagStartWithHref}{TwoStepVerificationArticleLink}{hrefEnd}2 AdÄ±mlÄ± DoÄŸrulama Kodu HakkÄ±nda Daha FazlasÄ±nÄ± Ã–ÄŸren{aTagEnd} {lineBreak}{aTagStartWithHref}{AccountSafetyArticleLink}{hrefEnd}HesabÄ±nÄ± GÃ¼vende Tutmak{aTagEnd} {lineBreak}{aTagStartWithHref}{SupportLink}{hrefEnd}Genel Roblox DesteÄŸi{aTagEnd} {lineBreak}{lineBreak}TeÅŸekkÃ¼rler,{lineBreak}{lineBreak}Roblox Ekibi";
	}

	protected override string _GetTemplateForDescriptionTwoStepVerificationLoginEmailHtmlBody()
	{
		return "{geoLocationInformation}{spanStartTagWithBold}{accountName} iÃ§in giriÅŸ yapma kodu: {lineBreak}{lineBreak}{code} {spanEndTag}{lineBreak}{lineBreak}GiriÅŸ yapma iÅŸlemini bitirmek iÃ§in bu kodu 2 AdÄ±mlÄ± DoÄŸrulama ekranÄ±na gir. Bu kodun sÃ¼resi 15 dakika sonra dolacak.{lineBreak}{lineBreak}Bu e-posta, hesabÄ±nla Roblox'a yeni bir tarayÄ±cÄ±dan veya cihazdan girilmeye Ã§alÄ±ÅŸÄ±ldÄ±ÄŸÄ± iÃ§in gÃ¶nderildi. Roblox'a giriÅŸ yapmaya Ã§alÄ±ÅŸmadÄ±ysan hesabÄ±na eriÅŸmeye Ã§alÄ±ÅŸan baÅŸka biri olabilir. Bu isteÄŸi sen oluÅŸturmadÄ±ysan ÅŸifreni deÄŸiÅŸtirmen ÅŸiddetle tavsiye edilir.{lineBreak}{lineBreak}Kaynaklar:{lineBreak}{aTagStartWithHref}{ChangePasswordLink}{hrefEnd}Åžifreni DeÄŸiÅŸtir{aTagEnd} {lineBreak}{aTagStartWithHref}{TwoStepVerificationArticleLink}{hrefEnd}2 AdÄ±mlÄ± DoÄŸrulama Kodu HakkÄ±nda Daha FazlasÄ±nÄ± Ã–ÄŸren{aTagEnd} {lineBreak}{aTagStartWithHref}{AccountSafetyArticleLink}{hrefEnd}HesabÄ±nÄ± GÃ¼vende Tutmak{aTagEnd} {lineBreak}{aTagStartWithHref}{SupportLink}{hrefEnd}Genel Roblox DesteÄŸi{aTagEnd} {lineBreak}{lineBreak}TeÅŸekkÃ¼rler,{lineBreak}{lineBreak}Roblox Ekibi";
	}

	/// <summary>
	/// Key: "Description.TwoStepVerificationLoginEmail.PlainBody"
	/// Plain body for 2SV login email
	/// English String: "{geoLocationInformation}Login code for {accountName}: {lineBreak}{lineBreak} {code} {lineBreak}{lineBreak}Enter this code into the 2-Step Verification screen to finish logging in. This code will expire in 15 minutes. {lineBreak}{lineBreak}This email was sent because your account tried to login to Roblox from a new browser or device. If you haven't tried logging into Roblox, someone else may be trying to access your account. You are strongly advised to change your password if you did not generate this request. {lineBreak}{lineBreak}Resources: {lineBreak}Change Your Password [{accountInfoPageLink}] {lineBreak}Learn More About 2-Step Verification [{twoStepVerificationHelpArticleLink}]{lineBreak}Keeping Your Account Safe [{keepAccountSafeArticleLink}] {lineBreak}General Roblox Support [{supportPageLink}] {lineBreak}{lineBreak}Thank you, {lineBreak}{lineBreak}The Roblox Team"
	/// </summary>
	public override string DescriptionTwoStepVerificationLoginEmailPlainBody(string geoLocationInformation, string accountName, string lineBreak, string code, string accountInfoPageLink, string twoStepVerificationHelpArticleLink, string keepAccountSafeArticleLink, string supportPageLink)
	{
		return $"{geoLocationInformation} {accountName} iÃ§in giriÅŸ yapma kodu: {lineBreak}{lineBreak} {code} {lineBreak}{lineBreak}GiriÅŸ yapma iÅŸlemini bitirmek iÃ§in bu kodu 2 AdÄ±mlÄ± DoÄŸrulama ekranÄ±na gir. Bu kodun sÃ¼resi 15 dakika sonra dolacak.{lineBreak}{lineBreak}Bu e-posta, hesabÄ±nla Roblox'a yeni bir tarayÄ±cÄ±dan veya cihazdan girilmeye Ã§alÄ±ÅŸÄ±ldÄ±ÄŸÄ± iÃ§in gÃ¶nderildi. Roblox'a giriÅŸ yapmaya Ã§alÄ±ÅŸmadÄ±ysan hesabÄ±na eriÅŸmeye Ã§alÄ±ÅŸan baÅŸka biri olabilir. Bu isteÄŸi sen oluÅŸturmadÄ±ysan ÅŸifreni deÄŸiÅŸtirmen ÅŸiddetle tavsiye edilir. {lineBreak}{lineBreak}Kaynaklar: {lineBreak}Åžifreni DeÄŸiÅŸtir [{accountInfoPageLink}] {lineBreak}2 AdÄ±mlÄ± DoÄŸrulama Kodu HakkÄ±nda Daha FazlasÄ±nÄ± Ã–ÄŸren [{twoStepVerificationHelpArticleLink}]{lineBreak}HesabÄ±nÄ± GÃ¼vende Tutmak [{keepAccountSafeArticleLink}] {lineBreak}Genel Roblox DesteÄŸi [{supportPageLink}] {lineBreak}{lineBreak}TeÅŸekkÃ¼rler, {lineBreak}{lineBreak}Roblox Ekibi";
	}

	protected override string _GetTemplateForDescriptionTwoStepVerificationLoginEmailPlainBody()
	{
		return "{geoLocationInformation} {accountName} iÃ§in giriÅŸ yapma kodu: {lineBreak}{lineBreak} {code} {lineBreak}{lineBreak}GiriÅŸ yapma iÅŸlemini bitirmek iÃ§in bu kodu 2 AdÄ±mlÄ± DoÄŸrulama ekranÄ±na gir. Bu kodun sÃ¼resi 15 dakika sonra dolacak.{lineBreak}{lineBreak}Bu e-posta, hesabÄ±nla Roblox'a yeni bir tarayÄ±cÄ±dan veya cihazdan girilmeye Ã§alÄ±ÅŸÄ±ldÄ±ÄŸÄ± iÃ§in gÃ¶nderildi. Roblox'a giriÅŸ yapmaya Ã§alÄ±ÅŸmadÄ±ysan hesabÄ±na eriÅŸmeye Ã§alÄ±ÅŸan baÅŸka biri olabilir. Bu isteÄŸi sen oluÅŸturmadÄ±ysan ÅŸifreni deÄŸiÅŸtirmen ÅŸiddetle tavsiye edilir. {lineBreak}{lineBreak}Kaynaklar: {lineBreak}Åžifreni DeÄŸiÅŸtir [{accountInfoPageLink}] {lineBreak}2 AdÄ±mlÄ± DoÄŸrulama Kodu HakkÄ±nda Daha FazlasÄ±nÄ± Ã–ÄŸren [{twoStepVerificationHelpArticleLink}]{lineBreak}HesabÄ±nÄ± GÃ¼vende Tutmak [{keepAccountSafeArticleLink}] {lineBreak}Genel Roblox DesteÄŸi [{supportPageLink}] {lineBreak}{lineBreak}TeÅŸekkÃ¼rler, {lineBreak}{lineBreak}Roblox Ekibi";
	}

	/// <summary>
	/// Key: "Description.TwoStepVerificationLoginEmail.PlainText.GeolocationInfo1"
	/// GeoLocation info of IP trying to login
	/// English String: "Login request received from {username} located in {region}, {country} ({ipAddress}).{lineBreak}{lineBreak}"
	/// </summary>
	public override string DescriptionTwoStepVerificationLoginEmailPlainTextGeolocationInfo1(string username, string region, string country, string ipAddress, string lineBreak)
	{
		return $"{region}, {country} ({ipAddress}) konumunda bulunan {username} tarafÄ±ndan bir giriÅŸ talebi alÄ±ndÄ±.{lineBreak}{lineBreak}";
	}

	protected override string _GetTemplateForDescriptionTwoStepVerificationLoginEmailPlainTextGeolocationInfo1()
	{
		return "{region}, {country} ({ipAddress}) konumunda bulunan {username} tarafÄ±ndan bir giriÅŸ talebi alÄ±ndÄ±.{lineBreak}{lineBreak}";
	}

	/// <summary>
	/// Key: "Description.TwoStepVerificationLoginEmail.PlainText.GeolocationInfo2"
	/// Geolocation info of IP trying to login
	/// English String: "Login request received from {username} located in {country} ({ipAddress}).{lineBreak}{lineBreak}"
	/// </summary>
	public override string DescriptionTwoStepVerificationLoginEmailPlainTextGeolocationInfo2(string username, string country, string ipAddress, string lineBreak)
	{
		return $"{country}, ({ipAddress}) konumunda bulunan {username} tarafÄ±ndan bir giriÅŸ talebi alÄ±ndÄ±.{lineBreak}{lineBreak}";
	}

	protected override string _GetTemplateForDescriptionTwoStepVerificationLoginEmailPlainTextGeolocationInfo2()
	{
		return "{country}, ({ipAddress}) konumunda bulunan {username} tarafÄ±ndan bir giriÅŸ talebi alÄ±ndÄ±.{lineBreak}{lineBreak}";
	}

	/// <summary>
	/// Key: "Description.TwoStepVerificationLoginEmail.PlainText.GeolocationInfo3"
	/// Geolocation info of IP trying to login
	/// English String: "Login request received from {username} (From Roblox Internal).{lineBreak}{lineBreak}"
	/// </summary>
	public override string DescriptionTwoStepVerificationLoginEmailPlainTextGeolocationInfo3(string username, string lineBreak)
	{
		return $"{username} (Roblox Dahili) tarafÄ±ndan bir giriÅŸ talebi alÄ±ndÄ±.{lineBreak}{lineBreak}";
	}

	protected override string _GetTemplateForDescriptionTwoStepVerificationLoginEmailPlainTextGeolocationInfo3()
	{
		return "{username} (Roblox Dahili) tarafÄ±ndan bir giriÅŸ talebi alÄ±ndÄ±.{lineBreak}{lineBreak}";
	}

	/// <summary>
	/// Key: "Description.TwoStepVerificationLoginEmail.PlainText.GeolocationInfo4"
	/// Geolocation info of IP trying to login
	/// English String: "Login request received from {username} located in {country}.{lineBreak}{lineBreak}"
	/// </summary>
	public override string DescriptionTwoStepVerificationLoginEmailPlainTextGeolocationInfo4(string username, string country, string lineBreak)
	{
		return $"{country} konumunda bulunan {username} tarafÄ±ndan bir giriÅŸ talebi alÄ±ndÄ±.{lineBreak}{lineBreak}";
	}

	protected override string _GetTemplateForDescriptionTwoStepVerificationLoginEmailPlainTextGeolocationInfo4()
	{
		return "{country} konumunda bulunan {username} tarafÄ±ndan bir giriÅŸ talebi alÄ±ndÄ±.{lineBreak}{lineBreak}";
	}

	/// <summary>
	/// Key: "Description.TwoStepVerificationLoginEmail.PlainText.GeolocationInfo5"
	/// Geolocation info of IP trying to login
	/// English String: "Login request received from {username} located in {region}, {country}.{lineBreak}{lineBreak}"
	/// </summary>
	public override string DescriptionTwoStepVerificationLoginEmailPlainTextGeolocationInfo5(string username, string region, string country, string lineBreak)
	{
		return $"{region}, {country} konumunda bulunan {username} tarafÄ±ndan bir giriÅŸ talebi alÄ±ndÄ±.{lineBreak}{lineBreak}";
	}

	protected override string _GetTemplateForDescriptionTwoStepVerificationLoginEmailPlainTextGeolocationInfo5()
	{
		return "{region}, {country} konumunda bulunan {username} tarafÄ±ndan bir giriÅŸ talebi alÄ±ndÄ±.{lineBreak}{lineBreak}";
	}

	/// <summary>
	/// Key: "Description.TwoStepVerificationLoginEmail.PlainText.GeolocationInfo6"
	/// Geolocation info of IP trying to login
	/// English String: "Login request received from {username} located in {city}, {region}, {country}.{lineBreak}{lineBreak}"
	/// </summary>
	public override string DescriptionTwoStepVerificationLoginEmailPlainTextGeolocationInfo6(string username, string city, string region, string country, string lineBreak)
	{
		return $"{city}, {region}, {country} konumunda bulunan {username} tarafÄ±ndan bir giriÅŸ talebi alÄ±ndÄ±.{lineBreak}{lineBreak}";
	}

	protected override string _GetTemplateForDescriptionTwoStepVerificationLoginEmailPlainTextGeolocationInfo6()
	{
		return "{city}, {region}, {country} konumunda bulunan {username} tarafÄ±ndan bir giriÅŸ talebi alÄ±ndÄ±.{lineBreak}{lineBreak}";
	}

	/// <summary>
	/// Key: "Description.TwoStepVerificationLoginEmail.Subject"
	/// Subject for 2SV login email
	/// English String: "Verification Code for Roblox Account: {accountName}"
	/// </summary>
	public override string DescriptionTwoStepVerificationLoginEmailSubject(string accountName)
	{
		return $"Roblox HesabÄ± iÃ§in DoÄŸrulama Kodu: {accountName}";
	}

	protected override string _GetTemplateForDescriptionTwoStepVerificationLoginEmailSubject()
	{
		return "Roblox HesabÄ± iÃ§in DoÄŸrulama Kodu: {accountName}";
	}

	protected override string _GetTemplateForLabelCode()
	{
		return "Kod";
	}

	/// <summary>
	/// Key: "Label.CodeInputPlaceholderText"
	/// example: Enter 4-digit code
	/// English String: "Enter {codeLength}-digit Code"
	/// </summary>
	public override string LabelCodeInputPlaceholderText(string codeLength)
	{
		return $"{codeLength} haneli Kodu gir";
	}

	protected override string _GetTemplateForLabelCodeInputPlaceholderText()
	{
		return "{codeLength} haneli Kodu gir";
	}

	protected override string _GetTemplateForLabelDidNotReceive()
	{
		return "Kodu almadÄ±n mÄ±?";
	}

	protected override string _GetTemplateForLabelEnterCode()
	{
		return "Kodu Gir (6 hane)";
	}

	protected override string _GetTemplateForLabelEnterEmailCode()
	{
		return "E-posta ile gÃ¶nderdiÄŸimiz kodu gir";
	}

	protected override string _GetTemplateForLabelEnterTextCode()
	{
		return "SMS ile gÃ¶nderdiÄŸimiz kodu gir";
	}

	protected override string _GetTemplateForLabelEnterTwoStepVerificationCode()
	{
		return "Ä°ki aÅŸamalÄ± onay kodunu gir.";
	}

	protected override string _GetTemplateForLabelFacebookPasswordWarning()
	{
		return "EÄŸer ÅŸimdiye kadar Facebook ile giriÅŸ yaptÄ±ysan bir ÅŸifre seÃ§melisin.";
	}

	protected override string _GetTemplateForLabelLearnMore()
	{
		return "Daha FazlasÄ±nÄ± Ã–ÄŸren";
	}

	/// <summary>
	/// Key: "Label.NeedHelpContactSupport"
	/// label for the support article link
	/// English String: "Need help? Contact {supportLink}"
	/// </summary>
	public override string LabelNeedHelpContactSupport(string supportLink)
	{
		return $"YardÄ±m mÄ± lazÄ±m? {supportLink} ile iletiÅŸime geÃ§";
	}

	protected override string _GetTemplateForLabelNeedHelpContactSupport()
	{
		return "YardÄ±m mÄ± lazÄ±m? {supportLink} ile iletiÅŸime geÃ§";
	}

	protected override string _GetTemplateForLabelNewCode()
	{
		return "Yeni Kod";
	}

	protected override string _GetTemplateForLabelRobloxSupport()
	{
		return "Roblox DesteÄŸi";
	}

	protected override string _GetTemplateForLabelTrustThisDevice()
	{
		return "30 gÃ¼nlÃ¼ÄŸÃ¼ne bu cihaza gÃ¼ven";
	}

	protected override string _GetTemplateForLabelTwoStepVerification()
	{
		return "2-AdÄ±mlÄ± DoÄŸrulama";
	}

	protected override string _GetTemplateForResponseCodeSent()
	{
		return "Kod GÃ¶nderildi";
	}

	protected override string _GetTemplateForResponseFeatureNotAvailable()
	{
		return "Ã–zellik kullanÄ±lamÄ±yor. LÃ¼tfen destek ile iletiÅŸime geÃ§.";
	}

	protected override string _GetTemplateForResponseInvalidCode()
	{
		return "GeÃ§ersiz kod.";
	}

	protected override string _GetTemplateForResponseSystemErrorReturnToLogin()
	{
		return "Sistem hatasÄ±. LÃ¼tfen giriÅŸ ekranÄ±na dÃ¶n.";
	}

	protected override string _GetTemplateForResponseTooManyAttempts()
	{
		return "Ã‡ok sayÄ±da deneme. LÃ¼tfen daha sonra tekrar dene.";
	}

	protected override string _GetTemplateForResponseTooManyCharacters()
	{
		return "Ã‡ok fazla karakter";
	}
}


}
