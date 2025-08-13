namespace Roblox.TranslationResources.Authentication;

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
	public override string ActionCancel => "İptal Et";

	/// <summary>
	/// Key: "Action.Resend"
	/// English String: "Resend Code"
	/// </summary>
	public override string ActionResend => "Kodu Tekrar Gönder";

	/// <summary>
	/// Key: "Action.StartOver"
	/// link text to restart verification
	/// English String: "Start Over"
	/// </summary>
	public override string ActionStartOver => "Yeniden Başlat";

	/// <summary>
	/// Key: "Action.Submit"
	/// submit button text
	/// English String: "Submit"
	/// </summary>
	public override string ActionSubmit => "Gönder";

	/// <summary>
	/// Key: "Action.Verify"
	/// English String: "Verify"
	/// </summary>
	public override string ActionVerify => "Doğrula";

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
	public override string LabelDidNotReceive => "Kodu almadın mı?";

	/// <summary>
	/// Key: "Label.EnterCode"
	/// English String: "Enter Code (6-digit)"
	/// </summary>
	public override string LabelEnterCode => "Kodu Gir (6 hane)";

	/// <summary>
	/// Key: "Label.EnterEmailCode"
	/// English String: "Enter the code we just sent you via email"
	/// </summary>
	public override string LabelEnterEmailCode => "E-posta ile gönderdiğimiz kodu gir";

	/// <summary>
	/// Key: "Label.EnterTextCode"
	/// English String: "Enter the code we just sent you via text message"
	/// </summary>
	public override string LabelEnterTextCode => "SMS ile gönderdiğimiz kodu gir";

	/// <summary>
	/// Key: "Label.EnterTwoStepVerificationCode"
	/// Enter your two step verification code.
	/// English String: "Enter your two step verification code."
	/// </summary>
	public override string LabelEnterTwoStepVerificationCode => "İki aşamalı onay kodunu gir.";

	/// <summary>
	/// Key: "Label.FacebookPasswordWarning"
	/// If you have been signing in with Facebook, you must set a password.
	/// English String: "If you have been signing in with Facebook, you must set a password."
	/// </summary>
	public override string LabelFacebookPasswordWarning => "Eğer şimdiye kadar Facebook ile giriş yaptıysan bir şifre seçmelisin.";

	/// <summary>
	/// Key: "Label.LearnMore"
	/// Learn More link text
	/// English String: "Learn More"
	/// </summary>
	public override string LabelLearnMore => "Daha Fazlasını Öğren";

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
	public override string LabelRobloxSupport => "Roblox Desteği";

	/// <summary>
	/// Key: "Label.TrustThisDevice"
	/// English String: "Trust this device for 30 days"
	/// </summary>
	public override string LabelTrustThisDevice => "30 günlüğüne bu cihaza güven";

	/// <summary>
	/// Key: "Label.TwoStepVerification"
	/// English String: "2-Step Verification"
	/// </summary>
	public override string LabelTwoStepVerification => "2-Adımlı Doğrulama";

	/// <summary>
	/// Key: "Response.CodeSent"
	/// English String: "Code Sent"
	/// </summary>
	public override string ResponseCodeSent => "Kod Gönderildi";

	/// <summary>
	/// Key: "Response.FeatureNotAvailable"
	/// English String: "Feature not available. Please contact support."
	/// </summary>
	public override string ResponseFeatureNotAvailable => "Özellik kullanılamıyor. Lütfen destek ile iletişime geç.";

	/// <summary>
	/// Key: "Response.InvalidCode"
	/// English String: "Invalid code."
	/// </summary>
	public override string ResponseInvalidCode => "Geçersiz kod.";

	/// <summary>
	/// Key: "Response.SystemErrorReturnToLogin"
	/// English String: "System error. Please return to login screen."
	/// </summary>
	public override string ResponseSystemErrorReturnToLogin => "Sistem hatası. Lütfen giriş ekranına dön.";

	/// <summary>
	/// Key: "Response.TooManyAttempts"
	/// English String: "Too many attempts. Please try again later."
	/// </summary>
	public override string ResponseTooManyAttempts => "Çok sayıda deneme. Lütfen daha sonra tekrar dene.";

	/// <summary>
	/// Key: "Response.TooManyCharacters"
	/// error message
	/// English String: "Too many characters"
	/// </summary>
	public override string ResponseTooManyCharacters => "Çok fazla karakter";

	public TwoStepVerificationResources_tr_tr(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionCancel()
	{
		return "İptal Et";
	}

	protected override string _GetTemplateForActionResend()
	{
		return "Kodu Tekrar Gönder";
	}

	protected override string _GetTemplateForActionStartOver()
	{
		return "Yeniden Başlat";
	}

	protected override string _GetTemplateForActionSubmit()
	{
		return "Gönder";
	}

	protected override string _GetTemplateForActionVerify()
	{
		return "Doğrula";
	}

	/// <summary>
	/// Key: "Description.TwoStepVerificationActivationEmail.Body.Over13"
	/// Body for 2SV activation email for over 13 users
	/// English String: "Hi {accountName},{lineBreak}{lineBreak}You have activated 2-Step Verification for your Roblox account. Next time you log in from a new device, you will need to enter a 6-digit security code that Roblox sends to you via email.{lineBreak}{lineBreak}Roblox"
	/// </summary>
	public override string DescriptionTwoStepVerificationActivationEmailBodyOver13(string accountName, string lineBreak)
	{
		return $"Merhaba {accountName},{lineBreak}{lineBreak}Roblox hesabın için 2-Adımlı Doğrulamayı etkinleştirdin. Yeni bir cihazdan giriş yaptığında Roblox'un e-postayla göndereceği 6 haneli güvenlik kodunu girmen gerekecek.{lineBreak}{lineBreak}Roblox";
	}

	protected override string _GetTemplateForDescriptionTwoStepVerificationActivationEmailBodyOver13()
	{
		return "Merhaba {accountName},{lineBreak}{lineBreak}Roblox hesabın için 2-Adımlı Doğrulamayı etkinleştirdin. Yeni bir cihazdan giriş yaptığında Roblox'un e-postayla göndereceği 6 haneli güvenlik kodunu girmen gerekecek.{lineBreak}{lineBreak}Roblox";
	}

	/// <summary>
	/// Key: "Description.TwoStepVerificationActivationEmail.Body.Under13"
	/// Body for 2SV activation email for under 13 users
	/// English String: "Hi,{lineBreak}{lineBreak}2-Step Verification has been activated for your child's Roblox account, {accountName}. Next time they log in from a new device, they will need to enter a 6-digit security code that Roblox sends to you via email.{lineBreak}{lineBreak}Roblox"
	/// </summary>
	public override string DescriptionTwoStepVerificationActivationEmailBodyUnder13(string lineBreak, string accountName)
	{
		return $"Merhaba,{lineBreak}{lineBreak}Çocuğunuzun {accountName} adlı Roblox hesabı için 2-Adımlı Doğrulama etkinleştirildi. Yeni bir cihazdan giriş yaptığında Roblox'un e-postayla size göndereceği 6 haneli güvenlik kodunu girmesi gerekecek.{lineBreak}{lineBreak}Roblox";
	}

	protected override string _GetTemplateForDescriptionTwoStepVerificationActivationEmailBodyUnder13()
	{
		return "Merhaba,{lineBreak}{lineBreak}Çocuğunuzun {accountName} adlı Roblox hesabı için 2-Adımlı Doğrulama etkinleştirildi. Yeni bir cihazdan giriş yaptığında Roblox'un e-postayla size göndereceği 6 haneli güvenlik kodunu girmesi gerekecek.{lineBreak}{lineBreak}Roblox";
	}

	/// <summary>
	/// Key: "Description.TwoStepVerificationActivationEmail.Subject"
	/// Subject for 2SV activation email
	/// English String: "2-Step Verification Activated for Roblox Account: {accountName}"
	/// </summary>
	public override string DescriptionTwoStepVerificationActivationEmailSubject(string accountName)
	{
		return $"Roblox Hesabı için 2-Adımlı Doğrulama Etkinleştirildi: {accountName}";
	}

	protected override string _GetTemplateForDescriptionTwoStepVerificationActivationEmailSubject()
	{
		return "Roblox Hesabı için 2-Adımlı Doğrulama Etkinleştirildi: {accountName}";
	}

	/// <summary>
	/// Key: "Description.TwoStepVerificationDeactivationEmail.Body.Over13"
	/// Body for 2SV deactivation email for over 13 users
	/// English String: "Hi {accountName},{lineBreak}{lineBreak}You have deactivated 2-Step Verification for your Roblox account. A security code will no longer be required when you log into your account.{lineBreak}{lineBreak}Roblox"
	/// </summary>
	public override string DescriptionTwoStepVerificationDeactivationEmailBodyOver13(string accountName, string lineBreak)
	{
		return $"Merhaba {accountName},{lineBreak}{lineBreak}Roblox hesabın için 2-Adımlı Doğrulamayı devre dışı bıraktın. Hesabına giriş yaptığında bir güvenlik kodu girmen gerekmeyecek.{lineBreak}{lineBreak}Roblox";
	}

	protected override string _GetTemplateForDescriptionTwoStepVerificationDeactivationEmailBodyOver13()
	{
		return "Merhaba {accountName},{lineBreak}{lineBreak}Roblox hesabın için 2-Adımlı Doğrulamayı devre dışı bıraktın. Hesabına giriş yaptığında bir güvenlik kodu girmen gerekmeyecek.{lineBreak}{lineBreak}Roblox";
	}

	/// <summary>
	/// Key: "Description.TwoStepVerificationDeactivationEmail.Body.Under13"
	/// Body for 2SV deactivation email for under 13 users
	/// English String: "Hi,{lineBreak}{lineBreak}2-Step Verification has been deactivated for your child's Roblox account, {accountName}. A security code will no longer be required when they log into the account.{lineBreak}{lineBreak}Roblox"
	/// </summary>
	public override string DescriptionTwoStepVerificationDeactivationEmailBodyUnder13(string lineBreak, string accountName)
	{
		return $"Merhaba,{lineBreak}{lineBreak}Çocuğunuzun {accountName} adlı Roblox hesabında 2-Adımlı Doğrulama devre dışı bırakıldı. Hesaba giriş yaptığında bir güvenlik kodu girmesi gerekmeyecek.{lineBreak}{lineBreak}Roblox";
	}

	protected override string _GetTemplateForDescriptionTwoStepVerificationDeactivationEmailBodyUnder13()
	{
		return "Merhaba,{lineBreak}{lineBreak}Çocuğunuzun {accountName} adlı Roblox hesabında 2-Adımlı Doğrulama devre dışı bırakıldı. Hesaba giriş yaptığında bir güvenlik kodu girmesi gerekmeyecek.{lineBreak}{lineBreak}Roblox";
	}

	/// <summary>
	/// Key: "Description.TwoStepVerificationDeactivationEmail.Subject	"
	/// Subject for 2SV deactivation email
	/// English String: "2-Step Verification Deactivated for Roblox Account: {accountName}"
	/// </summary>
	public override string DescriptionTwoStepVerificationDeactivationEmailSubject(string accountName)
	{
		return $"Roblox Hesabı için 2-Adımlı Doğrulama Devre Dışı Bırakıldı: {accountName}";
	}

	protected override string _GetTemplateForDescriptionTwoStepVerificationDeactivationEmailSubject()
	{
		return "Roblox Hesabı için 2-Adımlı Doğrulama Devre Dışı Bırakıldı: {accountName}";
	}

	/// <summary>
	/// Key: "Description.TwoStepVerificationLoginEmail.Html.GeolocationInfo1"
	/// Geolocation information about IP trying to login
	/// English String: "{spanStartTagWithBold}Login request received from {username} located in {region}, {country} ({ipAddress}).{spanEndTag}{lineBreak}{lineBreak}"
	/// </summary>
	public override string DescriptionTwoStepVerificationLoginEmailHtmlGeolocationInfo1(string spanStartTagWithBold, string username, string region, string country, string ipAddress, string spanEndTag, string lineBreak)
	{
		return $"{spanStartTagWithBold}{region}, {country} ({ipAddress}) konumunda bulunan {username} tarafından bir giriş talebi alındı.{spanEndTag}{lineBreak}{lineBreak}";
	}

	protected override string _GetTemplateForDescriptionTwoStepVerificationLoginEmailHtmlGeolocationInfo1()
	{
		return "{spanStartTagWithBold}{region}, {country} ({ipAddress}) konumunda bulunan {username} tarafından bir giriş talebi alındı.{spanEndTag}{lineBreak}{lineBreak}";
	}

	/// <summary>
	/// Key: "Description.TwoStepVerificationLoginEmail.Html.GeolocationInfo2"
	/// Geolocation info about IP trying to login
	/// English String: "{spanStartTagWithBold}Login request received from {username} located in {country} ({ipAddress}).{spanEndTag}{lineBreak}{lineBreak}\t"
	/// </summary>
	public override string DescriptionTwoStepVerificationLoginEmailHtmlGeolocationInfo2(string spanStartTagWithBold, string username, string country, string ipAddress, string spanEndTag, string lineBreak)
	{
		return $"{spanStartTagWithBold}{country}, ({ipAddress}) konumunda bulunan {username} tarafından bir giriş talebi alındı.{spanEndTag}{lineBreak}{lineBreak}\t";
	}

	protected override string _GetTemplateForDescriptionTwoStepVerificationLoginEmailHtmlGeolocationInfo2()
	{
		return "{spanStartTagWithBold}{country}, ({ipAddress}) konumunda bulunan {username} tarafından bir giriş talebi alındı.{spanEndTag}{lineBreak}{lineBreak}\t";
	}

	/// <summary>
	/// Key: "Description.TwoStepVerificationLoginEmail.Html.GeolocationInfo3"
	/// Geolocation info about IP trying to log in
	/// English String: "{spanStartTagWithBold}Login request received from {username} (From Roblox Internal).{spanEndTag}{lineBreak}{lineBreak}\t"
	/// </summary>
	public override string DescriptionTwoStepVerificationLoginEmailHtmlGeolocationInfo3(string spanStartTagWithBold, string username, string spanEndTag, string lineBreak)
	{
		return $"{spanStartTagWithBold}{username} (Roblox Dahili) tarafından bir giriş talebi alındı.{spanEndTag}{lineBreak}{lineBreak}\t";
	}

	protected override string _GetTemplateForDescriptionTwoStepVerificationLoginEmailHtmlGeolocationInfo3()
	{
		return "{spanStartTagWithBold}{username} (Roblox Dahili) tarafından bir giriş talebi alındı.{spanEndTag}{lineBreak}{lineBreak}\t";
	}

	/// <summary>
	/// Key: "Description.TwoStepVerificationLoginEmail.Html.GeolocationInfo4"
	/// Geolocation info of IP trying to login
	/// English String: "{spanStartTagWithBold}Login request received from {username} located in {country}.{spanEndTag}{lineBreak}{lineBreak}"
	/// </summary>
	public override string DescriptionTwoStepVerificationLoginEmailHtmlGeolocationInfo4(string spanStartTagWithBold, string username, string country, string spanEndTag, string lineBreak)
	{
		return $"{spanStartTagWithBold}{country} konumunda bulunan {username} tarafından bir giriş talebi alındı.{spanEndTag}{lineBreak}{lineBreak}";
	}

	protected override string _GetTemplateForDescriptionTwoStepVerificationLoginEmailHtmlGeolocationInfo4()
	{
		return "{spanStartTagWithBold}{country} konumunda bulunan {username} tarafından bir giriş talebi alındı.{spanEndTag}{lineBreak}{lineBreak}";
	}

	/// <summary>
	/// Key: "Description.TwoStepVerificationLoginEmail.Html.GeolocationInfo5"
	/// Geolocation info of IP trying to login
	/// English String: "{spanStartTagWithBold}Login request received from {username} located in {region}, {country}.{spanEndTag}{lineBreak}{lineBreak}"
	/// </summary>
	public override string DescriptionTwoStepVerificationLoginEmailHtmlGeolocationInfo5(string spanStartTagWithBold, string username, string region, string country, string spanEndTag, string lineBreak)
	{
		return $"{spanStartTagWithBold}{region}, {country} konumunda bulunan {username} tarafından bir giriş talebi alındı.{spanEndTag}{lineBreak}{lineBreak}";
	}

	protected override string _GetTemplateForDescriptionTwoStepVerificationLoginEmailHtmlGeolocationInfo5()
	{
		return "{spanStartTagWithBold}{region}, {country} konumunda bulunan {username} tarafından bir giriş talebi alındı.{spanEndTag}{lineBreak}{lineBreak}";
	}

	/// <summary>
	/// Key: "Description.TwoStepVerificationLoginEmail.Html.GeolocationInfo6"
	/// Geolocation info of IP trying to login
	/// English String: "{spanStartTagWithBold}Login request received from {username} located in {city}, {region}, {country}.{spanEndTag}{lineBreak}{lineBreak}"
	/// </summary>
	public override string DescriptionTwoStepVerificationLoginEmailHtmlGeolocationInfo6(string spanStartTagWithBold, string username, string city, string region, string country, string spanEndTag, string lineBreak)
	{
		return $"{spanStartTagWithBold}{city}, {region}, {country} konumunda bulunan {username} tarafından bir giriş talebi alındı.{spanEndTag}{lineBreak}{lineBreak}";
	}

	protected override string _GetTemplateForDescriptionTwoStepVerificationLoginEmailHtmlGeolocationInfo6()
	{
		return "{spanStartTagWithBold}{city}, {region}, {country} konumunda bulunan {username} tarafından bir giriş talebi alındı.{spanEndTag}{lineBreak}{lineBreak}";
	}

	/// <summary>
	/// Key: "Description.TwoStepVerificationLoginEmail.HtmlBody"
	/// Html body for 2SV login email
	/// English String: "{geoLocationInformation}{spanStartTagWithBold}Login code for {accountName}: {lineBreak}{lineBreak}{code} {spanEndTag}{lineBreak}{lineBreak}Enter this code into the 2-Step Verification screen to finish logging in. This code will expire in 15 minutes.{lineBreak}{lineBreak}This email was sent because your account tried to login to Roblox from a new browser or device. If you haven't tried logging into Roblox, someone else may be trying to access your account. You are strongly advised to change your password if you did not generate this request.{lineBreak}{lineBreak}Resources:{lineBreak}{aTagStartWithHref}{ChangePasswordLink}{hrefEnd}Change Your Password{aTagEnd} {lineBreak}{aTagStartWithHref}{TwoStepVerificationArticleLink}{hrefEnd}Learn More About 2-Step Verification{aTagEnd} {lineBreak}{aTagStartWithHref}{AccountSafetyArticleLink}{hrefEnd}Keeping Your Account Safe{aTagEnd} {lineBreak}{aTagStartWithHref}{SupportLink}{hrefEnd}General Roblox Support{aTagEnd} {lineBreak}{lineBreak}Thank you,{lineBreak}{lineBreak}The Roblox Team"
	/// </summary>
	public override string DescriptionTwoStepVerificationLoginEmailHtmlBody(string geoLocationInformation, string spanStartTagWithBold, string accountName, string lineBreak, string code, string spanEndTag, string aTagStartWithHref, string ChangePasswordLink, string hrefEnd, string aTagEnd, string TwoStepVerificationArticleLink, string AccountSafetyArticleLink, string SupportLink)
	{
		return $"{geoLocationInformation}{spanStartTagWithBold}{accountName} için giriş yapma kodu: {lineBreak}{lineBreak}{code} {spanEndTag}{lineBreak}{lineBreak}Giriş yapma işlemini bitirmek için bu kodu 2 Adımlı Doğrulama ekranına gir. Bu kodun süresi 15 dakika sonra dolacak.{lineBreak}{lineBreak}Bu e-posta, hesabınla Roblox'a yeni bir tarayıcıdan veya cihazdan girilmeye çalışıldığı için gönderildi. Roblox'a giriş yapmaya çalışmadıysan hesabına erişmeye çalışan başka biri olabilir. Bu isteği sen oluşturmadıysan şifreni değiştirmen şiddetle tavsiye edilir.{lineBreak}{lineBreak}Kaynaklar:{lineBreak}{aTagStartWithHref}{ChangePasswordLink}{hrefEnd}Şifreni Değiştir{aTagEnd} {lineBreak}{aTagStartWithHref}{TwoStepVerificationArticleLink}{hrefEnd}2 Adımlı Doğrulama Kodu Hakkında Daha Fazlasını Öğren{aTagEnd} {lineBreak}{aTagStartWithHref}{AccountSafetyArticleLink}{hrefEnd}Hesabını Güvende Tutmak{aTagEnd} {lineBreak}{aTagStartWithHref}{SupportLink}{hrefEnd}Genel Roblox Desteği{aTagEnd} {lineBreak}{lineBreak}Teşekkürler,{lineBreak}{lineBreak}Roblox Ekibi";
	}

	protected override string _GetTemplateForDescriptionTwoStepVerificationLoginEmailHtmlBody()
	{
		return "{geoLocationInformation}{spanStartTagWithBold}{accountName} için giriş yapma kodu: {lineBreak}{lineBreak}{code} {spanEndTag}{lineBreak}{lineBreak}Giriş yapma işlemini bitirmek için bu kodu 2 Adımlı Doğrulama ekranına gir. Bu kodun süresi 15 dakika sonra dolacak.{lineBreak}{lineBreak}Bu e-posta, hesabınla Roblox'a yeni bir tarayıcıdan veya cihazdan girilmeye çalışıldığı için gönderildi. Roblox'a giriş yapmaya çalışmadıysan hesabına erişmeye çalışan başka biri olabilir. Bu isteği sen oluşturmadıysan şifreni değiştirmen şiddetle tavsiye edilir.{lineBreak}{lineBreak}Kaynaklar:{lineBreak}{aTagStartWithHref}{ChangePasswordLink}{hrefEnd}Şifreni Değiştir{aTagEnd} {lineBreak}{aTagStartWithHref}{TwoStepVerificationArticleLink}{hrefEnd}2 Adımlı Doğrulama Kodu Hakkında Daha Fazlasını Öğren{aTagEnd} {lineBreak}{aTagStartWithHref}{AccountSafetyArticleLink}{hrefEnd}Hesabını Güvende Tutmak{aTagEnd} {lineBreak}{aTagStartWithHref}{SupportLink}{hrefEnd}Genel Roblox Desteği{aTagEnd} {lineBreak}{lineBreak}Teşekkürler,{lineBreak}{lineBreak}Roblox Ekibi";
	}

	/// <summary>
	/// Key: "Description.TwoStepVerificationLoginEmail.PlainBody"
	/// Plain body for 2SV login email
	/// English String: "{geoLocationInformation}Login code for {accountName}: {lineBreak}{lineBreak} {code} {lineBreak}{lineBreak}Enter this code into the 2-Step Verification screen to finish logging in. This code will expire in 15 minutes. {lineBreak}{lineBreak}This email was sent because your account tried to login to Roblox from a new browser or device. If you haven't tried logging into Roblox, someone else may be trying to access your account. You are strongly advised to change your password if you did not generate this request. {lineBreak}{lineBreak}Resources: {lineBreak}Change Your Password [{accountInfoPageLink}] {lineBreak}Learn More About 2-Step Verification [{twoStepVerificationHelpArticleLink}]{lineBreak}Keeping Your Account Safe [{keepAccountSafeArticleLink}] {lineBreak}General Roblox Support [{supportPageLink}] {lineBreak}{lineBreak}Thank you, {lineBreak}{lineBreak}The Roblox Team"
	/// </summary>
	public override string DescriptionTwoStepVerificationLoginEmailPlainBody(string geoLocationInformation, string accountName, string lineBreak, string code, string accountInfoPageLink, string twoStepVerificationHelpArticleLink, string keepAccountSafeArticleLink, string supportPageLink)
	{
		return $"{geoLocationInformation} {accountName} için giriş yapma kodu: {lineBreak}{lineBreak} {code} {lineBreak}{lineBreak}Giriş yapma işlemini bitirmek için bu kodu 2 Adımlı Doğrulama ekranına gir. Bu kodun süresi 15 dakika sonra dolacak.{lineBreak}{lineBreak}Bu e-posta, hesabınla Roblox'a yeni bir tarayıcıdan veya cihazdan girilmeye çalışıldığı için gönderildi. Roblox'a giriş yapmaya çalışmadıysan hesabına erişmeye çalışan başka biri olabilir. Bu isteği sen oluşturmadıysan şifreni değiştirmen şiddetle tavsiye edilir. {lineBreak}{lineBreak}Kaynaklar: {lineBreak}Şifreni Değiştir [{accountInfoPageLink}] {lineBreak}2 Adımlı Doğrulama Kodu Hakkında Daha Fazlasını Öğren [{twoStepVerificationHelpArticleLink}]{lineBreak}Hesabını Güvende Tutmak [{keepAccountSafeArticleLink}] {lineBreak}Genel Roblox Desteği [{supportPageLink}] {lineBreak}{lineBreak}Teşekkürler, {lineBreak}{lineBreak}Roblox Ekibi";
	}

	protected override string _GetTemplateForDescriptionTwoStepVerificationLoginEmailPlainBody()
	{
		return "{geoLocationInformation} {accountName} için giriş yapma kodu: {lineBreak}{lineBreak} {code} {lineBreak}{lineBreak}Giriş yapma işlemini bitirmek için bu kodu 2 Adımlı Doğrulama ekranına gir. Bu kodun süresi 15 dakika sonra dolacak.{lineBreak}{lineBreak}Bu e-posta, hesabınla Roblox'a yeni bir tarayıcıdan veya cihazdan girilmeye çalışıldığı için gönderildi. Roblox'a giriş yapmaya çalışmadıysan hesabına erişmeye çalışan başka biri olabilir. Bu isteği sen oluşturmadıysan şifreni değiştirmen şiddetle tavsiye edilir. {lineBreak}{lineBreak}Kaynaklar: {lineBreak}Şifreni Değiştir [{accountInfoPageLink}] {lineBreak}2 Adımlı Doğrulama Kodu Hakkında Daha Fazlasını Öğren [{twoStepVerificationHelpArticleLink}]{lineBreak}Hesabını Güvende Tutmak [{keepAccountSafeArticleLink}] {lineBreak}Genel Roblox Desteği [{supportPageLink}] {lineBreak}{lineBreak}Teşekkürler, {lineBreak}{lineBreak}Roblox Ekibi";
	}

	/// <summary>
	/// Key: "Description.TwoStepVerificationLoginEmail.PlainText.GeolocationInfo1"
	/// GeoLocation info of IP trying to login
	/// English String: "Login request received from {username} located in {region}, {country} ({ipAddress}).{lineBreak}{lineBreak}"
	/// </summary>
	public override string DescriptionTwoStepVerificationLoginEmailPlainTextGeolocationInfo1(string username, string region, string country, string ipAddress, string lineBreak)
	{
		return $"{region}, {country} ({ipAddress}) konumunda bulunan {username} tarafından bir giriş talebi alındı.{lineBreak}{lineBreak}";
	}

	protected override string _GetTemplateForDescriptionTwoStepVerificationLoginEmailPlainTextGeolocationInfo1()
	{
		return "{region}, {country} ({ipAddress}) konumunda bulunan {username} tarafından bir giriş talebi alındı.{lineBreak}{lineBreak}";
	}

	/// <summary>
	/// Key: "Description.TwoStepVerificationLoginEmail.PlainText.GeolocationInfo2"
	/// Geolocation info of IP trying to login
	/// English String: "Login request received from {username} located in {country} ({ipAddress}).{lineBreak}{lineBreak}"
	/// </summary>
	public override string DescriptionTwoStepVerificationLoginEmailPlainTextGeolocationInfo2(string username, string country, string ipAddress, string lineBreak)
	{
		return $"{country}, ({ipAddress}) konumunda bulunan {username} tarafından bir giriş talebi alındı.{lineBreak}{lineBreak}";
	}

	protected override string _GetTemplateForDescriptionTwoStepVerificationLoginEmailPlainTextGeolocationInfo2()
	{
		return "{country}, ({ipAddress}) konumunda bulunan {username} tarafından bir giriş talebi alındı.{lineBreak}{lineBreak}";
	}

	/// <summary>
	/// Key: "Description.TwoStepVerificationLoginEmail.PlainText.GeolocationInfo3"
	/// Geolocation info of IP trying to login
	/// English String: "Login request received from {username} (From Roblox Internal).{lineBreak}{lineBreak}"
	/// </summary>
	public override string DescriptionTwoStepVerificationLoginEmailPlainTextGeolocationInfo3(string username, string lineBreak)
	{
		return $"{username} (Roblox Dahili) tarafından bir giriş talebi alındı.{lineBreak}{lineBreak}";
	}

	protected override string _GetTemplateForDescriptionTwoStepVerificationLoginEmailPlainTextGeolocationInfo3()
	{
		return "{username} (Roblox Dahili) tarafından bir giriş talebi alındı.{lineBreak}{lineBreak}";
	}

	/// <summary>
	/// Key: "Description.TwoStepVerificationLoginEmail.PlainText.GeolocationInfo4"
	/// Geolocation info of IP trying to login
	/// English String: "Login request received from {username} located in {country}.{lineBreak}{lineBreak}"
	/// </summary>
	public override string DescriptionTwoStepVerificationLoginEmailPlainTextGeolocationInfo4(string username, string country, string lineBreak)
	{
		return $"{country} konumunda bulunan {username} tarafından bir giriş talebi alındı.{lineBreak}{lineBreak}";
	}

	protected override string _GetTemplateForDescriptionTwoStepVerificationLoginEmailPlainTextGeolocationInfo4()
	{
		return "{country} konumunda bulunan {username} tarafından bir giriş talebi alındı.{lineBreak}{lineBreak}";
	}

	/// <summary>
	/// Key: "Description.TwoStepVerificationLoginEmail.PlainText.GeolocationInfo5"
	/// Geolocation info of IP trying to login
	/// English String: "Login request received from {username} located in {region}, {country}.{lineBreak}{lineBreak}"
	/// </summary>
	public override string DescriptionTwoStepVerificationLoginEmailPlainTextGeolocationInfo5(string username, string region, string country, string lineBreak)
	{
		return $"{region}, {country} konumunda bulunan {username} tarafından bir giriş talebi alındı.{lineBreak}{lineBreak}";
	}

	protected override string _GetTemplateForDescriptionTwoStepVerificationLoginEmailPlainTextGeolocationInfo5()
	{
		return "{region}, {country} konumunda bulunan {username} tarafından bir giriş talebi alındı.{lineBreak}{lineBreak}";
	}

	/// <summary>
	/// Key: "Description.TwoStepVerificationLoginEmail.PlainText.GeolocationInfo6"
	/// Geolocation info of IP trying to login
	/// English String: "Login request received from {username} located in {city}, {region}, {country}.{lineBreak}{lineBreak}"
	/// </summary>
	public override string DescriptionTwoStepVerificationLoginEmailPlainTextGeolocationInfo6(string username, string city, string region, string country, string lineBreak)
	{
		return $"{city}, {region}, {country} konumunda bulunan {username} tarafından bir giriş talebi alındı.{lineBreak}{lineBreak}";
	}

	protected override string _GetTemplateForDescriptionTwoStepVerificationLoginEmailPlainTextGeolocationInfo6()
	{
		return "{city}, {region}, {country} konumunda bulunan {username} tarafından bir giriş talebi alındı.{lineBreak}{lineBreak}";
	}

	/// <summary>
	/// Key: "Description.TwoStepVerificationLoginEmail.Subject"
	/// Subject for 2SV login email
	/// English String: "Verification Code for Roblox Account: {accountName}"
	/// </summary>
	public override string DescriptionTwoStepVerificationLoginEmailSubject(string accountName)
	{
		return $"Roblox Hesabı için Doğrulama Kodu: {accountName}";
	}

	protected override string _GetTemplateForDescriptionTwoStepVerificationLoginEmailSubject()
	{
		return "Roblox Hesabı için Doğrulama Kodu: {accountName}";
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
		return "Kodu almadın mı?";
	}

	protected override string _GetTemplateForLabelEnterCode()
	{
		return "Kodu Gir (6 hane)";
	}

	protected override string _GetTemplateForLabelEnterEmailCode()
	{
		return "E-posta ile gönderdiğimiz kodu gir";
	}

	protected override string _GetTemplateForLabelEnterTextCode()
	{
		return "SMS ile gönderdiğimiz kodu gir";
	}

	protected override string _GetTemplateForLabelEnterTwoStepVerificationCode()
	{
		return "İki aşamalı onay kodunu gir.";
	}

	protected override string _GetTemplateForLabelFacebookPasswordWarning()
	{
		return "Eğer şimdiye kadar Facebook ile giriş yaptıysan bir şifre seçmelisin.";
	}

	protected override string _GetTemplateForLabelLearnMore()
	{
		return "Daha Fazlasını Öğren";
	}

	/// <summary>
	/// Key: "Label.NeedHelpContactSupport"
	/// label for the support article link
	/// English String: "Need help? Contact {supportLink}"
	/// </summary>
	public override string LabelNeedHelpContactSupport(string supportLink)
	{
		return $"Yardım mı lazım? {supportLink} ile iletişime geç";
	}

	protected override string _GetTemplateForLabelNeedHelpContactSupport()
	{
		return "Yardım mı lazım? {supportLink} ile iletişime geç";
	}

	protected override string _GetTemplateForLabelNewCode()
	{
		return "Yeni Kod";
	}

	protected override string _GetTemplateForLabelRobloxSupport()
	{
		return "Roblox Desteği";
	}

	protected override string _GetTemplateForLabelTrustThisDevice()
	{
		return "30 günlüğüne bu cihaza güven";
	}

	protected override string _GetTemplateForLabelTwoStepVerification()
	{
		return "2-Adımlı Doğrulama";
	}

	protected override string _GetTemplateForResponseCodeSent()
	{
		return "Kod Gönderildi";
	}

	protected override string _GetTemplateForResponseFeatureNotAvailable()
	{
		return "Özellik kullanılamıyor. Lütfen destek ile iletişime geç.";
	}

	protected override string _GetTemplateForResponseInvalidCode()
	{
		return "Geçersiz kod.";
	}

	protected override string _GetTemplateForResponseSystemErrorReturnToLogin()
	{
		return "Sistem hatası. Lütfen giriş ekranına dön.";
	}

	protected override string _GetTemplateForResponseTooManyAttempts()
	{
		return "Çok sayıda deneme. Lütfen daha sonra tekrar dene.";
	}

	protected override string _GetTemplateForResponseTooManyCharacters()
	{
		return "Çok fazla karakter";
	}
}
