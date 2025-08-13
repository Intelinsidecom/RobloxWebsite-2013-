namespace Roblox.TranslationResources.Authentication;

/// <summary>
/// This class overrides TwoStepVerificationResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class TwoStepVerificationResources_id_id : TwoStepVerificationResources_en_us, ITwoStepVerificationResources, ITranslationResources
{
	/// <summary>
	/// Key: "Action.Cancel"
	/// English String: "Cancel"
	/// </summary>
	public override string ActionCancel => "Batal";

	/// <summary>
	/// Key: "Action.Resend"
	/// English String: "Resend Code"
	/// </summary>
	public override string ActionResend => "Kirim Ulang Kode";

	/// <summary>
	/// Key: "Action.StartOver"
	/// link text to restart verification
	/// English String: "Start Over"
	/// </summary>
	public override string ActionStartOver => "Mulai Ulang";

	/// <summary>
	/// Key: "Action.Submit"
	/// submit button text
	/// English String: "Submit"
	/// </summary>
	public override string ActionSubmit => "Kirim";

	/// <summary>
	/// Key: "Action.Verify"
	/// English String: "Verify"
	/// </summary>
	public override string ActionVerify => "Verifikasi";

	/// <summary>
	/// Key: "Label.Code"
	/// verification code for 2 factor authentication
	/// English String: "Code"
	/// </summary>
	public override string LabelCode => "Kode";

	/// <summary>
	/// Key: "Label.DidNotReceive"
	/// English String: "Didn't receive the code?"
	/// </summary>
	public override string LabelDidNotReceive => "Belum menerima kode?";

	/// <summary>
	/// Key: "Label.EnterCode"
	/// English String: "Enter Code (6-digit)"
	/// </summary>
	public override string LabelEnterCode => "Masukkan Kode (6 digit)";

	/// <summary>
	/// Key: "Label.EnterEmailCode"
	/// English String: "Enter the code we just sent you via email"
	/// </summary>
	public override string LabelEnterEmailCode => "Masukkan kode yang baru saja kami kirimkan lewat email";

	/// <summary>
	/// Key: "Label.EnterTextCode"
	/// English String: "Enter the code we just sent you via text message"
	/// </summary>
	public override string LabelEnterTextCode => "Masukkan kode yang baru saja kami kirimkan lewat pesan teks";

	/// <summary>
	/// Key: "Label.EnterTwoStepVerificationCode"
	/// Enter your two step verification code.
	/// English String: "Enter your two step verification code."
	/// </summary>
	public override string LabelEnterTwoStepVerificationCode => "Masukkan kode verifikasi dua tahapmu.";

	/// <summary>
	/// Key: "Label.FacebookPasswordWarning"
	/// If you have been signing in with Facebook, you must set a password.
	/// English String: "If you have been signing in with Facebook, you must set a password."
	/// </summary>
	public override string LabelFacebookPasswordWarning => "Jika kamu sudah masuk dengan Facebook, kamu harus membuat kata sandi.";

	/// <summary>
	/// Key: "Label.LearnMore"
	/// Learn More link text
	/// English String: "Learn More"
	/// </summary>
	public override string LabelLearnMore => "Pelajari Selengkapnya";

	/// <summary>
	/// Key: "Label.NewCode"
	/// verification code resent, label changes to new code
	/// English String: "New Code"
	/// </summary>
	public override string LabelNewCode => "Kode Baru";

	/// <summary>
	/// Key: "Label.RobloxSupport"
	/// English String: "Roblox Support"
	/// </summary>
	public override string LabelRobloxSupport => "Dukungan Roblox";

	/// <summary>
	/// Key: "Label.TrustThisDevice"
	/// English String: "Trust this device for 30 days"
	/// </summary>
	public override string LabelTrustThisDevice => "Percayai perangkat ini selama 30 hari";

	/// <summary>
	/// Key: "Label.TwoStepVerification"
	/// English String: "2-Step Verification"
	/// </summary>
	public override string LabelTwoStepVerification => "Verifikasi 2 Tahap";

	/// <summary>
	/// Key: "Response.CodeSent"
	/// English String: "Code Sent"
	/// </summary>
	public override string ResponseCodeSent => "Kode Terkirim";

	/// <summary>
	/// Key: "Response.FeatureNotAvailable"
	/// English String: "Feature not available. Please contact support."
	/// </summary>
	public override string ResponseFeatureNotAvailable => "Fitur tidak tersedia. Harap hubungi dukungan.";

	/// <summary>
	/// Key: "Response.InvalidCode"
	/// English String: "Invalid code."
	/// </summary>
	public override string ResponseInvalidCode => "Kode tidak valid.";

	/// <summary>
	/// Key: "Response.SystemErrorReturnToLogin"
	/// English String: "System error. Please return to login screen."
	/// </summary>
	public override string ResponseSystemErrorReturnToLogin => "Kesalahan sistem. Harap kembali ke halaman masuk.";

	/// <summary>
	/// Key: "Response.TooManyAttempts"
	/// English String: "Too many attempts. Please try again later."
	/// </summary>
	public override string ResponseTooManyAttempts => "Terlalu banyak percobaan. Harap coba lagi nanti.";

	/// <summary>
	/// Key: "Response.TooManyCharacters"
	/// error message
	/// English String: "Too many characters"
	/// </summary>
	public override string ResponseTooManyCharacters => "Terlalu banyak karakter";

	public TwoStepVerificationResources_id_id(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionCancel()
	{
		return "Batal";
	}

	protected override string _GetTemplateForActionResend()
	{
		return "Kirim Ulang Kode";
	}

	protected override string _GetTemplateForActionStartOver()
	{
		return "Mulai Ulang";
	}

	protected override string _GetTemplateForActionSubmit()
	{
		return "Kirim";
	}

	protected override string _GetTemplateForActionVerify()
	{
		return "Verifikasi";
	}

	/// <summary>
	/// Key: "Description.TwoStepVerificationActivationEmail.Body.Over13"
	/// Body for 2SV activation email for over 13 users
	/// English String: "Hi {accountName},{lineBreak}{lineBreak}You have activated 2-Step Verification for your Roblox account. Next time you log in from a new device, you will need to enter a 6-digit security code that Roblox sends to you via email.{lineBreak}{lineBreak}Roblox"
	/// </summary>
	public override string DescriptionTwoStepVerificationActivationEmailBodyOver13(string accountName, string lineBreak)
	{
		return $"Hai {accountName},{lineBreak}{lineBreak}Kamu telah mengaktifkan Verifikasi 2 Tahap untuk akun Roblox-mu. Jika suatu saat kamu masuk dari perangkat baru, kamu akan diminta untuk memasukkan kode keamanan berisi 6 digit yang Roblox kirimkan ke kamu lewat email.{lineBreak}{lineBreak}Roblox";
	}

	protected override string _GetTemplateForDescriptionTwoStepVerificationActivationEmailBodyOver13()
	{
		return "Hai {accountName},{lineBreak}{lineBreak}Kamu telah mengaktifkan Verifikasi 2 Tahap untuk akun Roblox-mu. Jika suatu saat kamu masuk dari perangkat baru, kamu akan diminta untuk memasukkan kode keamanan berisi 6 digit yang Roblox kirimkan ke kamu lewat email.{lineBreak}{lineBreak}Roblox";
	}

	/// <summary>
	/// Key: "Description.TwoStepVerificationActivationEmail.Body.Under13"
	/// Body for 2SV activation email for under 13 users
	/// English String: "Hi,{lineBreak}{lineBreak}2-Step Verification has been activated for your child's Roblox account, {accountName}. Next time they log in from a new device, they will need to enter a 6-digit security code that Roblox sends to you via email.{lineBreak}{lineBreak}Roblox"
	/// </summary>
	public override string DescriptionTwoStepVerificationActivationEmailBodyUnder13(string lineBreak, string accountName)
	{
		return $"Hai,{lineBreak}{lineBreak}Verifikasi 2 Tahap untuk akun Roblox anakmu telah diaktifkan, {accountName}. Jika suatu saat mereka masuk dari perangkat baru, mereka akan diminta untuk memasukkan kode keamanan berisi 6 digit yang Roblox kirimkan ke kamu lewat email.{lineBreak}{lineBreak}Roblox";
	}

	protected override string _GetTemplateForDescriptionTwoStepVerificationActivationEmailBodyUnder13()
	{
		return "Hai,{lineBreak}{lineBreak}Verifikasi 2 Tahap untuk akun Roblox anakmu telah diaktifkan, {accountName}. Jika suatu saat mereka masuk dari perangkat baru, mereka akan diminta untuk memasukkan kode keamanan berisi 6 digit yang Roblox kirimkan ke kamu lewat email.{lineBreak}{lineBreak}Roblox";
	}

	/// <summary>
	/// Key: "Description.TwoStepVerificationActivationEmail.Subject"
	/// Subject for 2SV activation email
	/// English String: "2-Step Verification Activated for Roblox Account: {accountName}"
	/// </summary>
	public override string DescriptionTwoStepVerificationActivationEmailSubject(string accountName)
	{
		return $"Verifikasi 2 Tahap untuk Akun Roblox Diaktifkan: {accountName}";
	}

	protected override string _GetTemplateForDescriptionTwoStepVerificationActivationEmailSubject()
	{
		return "Verifikasi 2 Tahap untuk Akun Roblox Diaktifkan: {accountName}";
	}

	/// <summary>
	/// Key: "Description.TwoStepVerificationDeactivationEmail.Body.Over13"
	/// Body for 2SV deactivation email for over 13 users
	/// English String: "Hi {accountName},{lineBreak}{lineBreak}You have deactivated 2-Step Verification for your Roblox account. A security code will no longer be required when you log into your account.{lineBreak}{lineBreak}Roblox"
	/// </summary>
	public override string DescriptionTwoStepVerificationDeactivationEmailBodyOver13(string accountName, string lineBreak)
	{
		return $"Hai {accountName},{lineBreak}{lineBreak}Kamu telah menonaktifkan Verifikasi 2 Tahap untuk akun Roblox-mu. Kamu tidak akan lagi memerlukan kode keamanan saat masuk ke akunmu.{lineBreak}{lineBreak}Roblox";
	}

	protected override string _GetTemplateForDescriptionTwoStepVerificationDeactivationEmailBodyOver13()
	{
		return "Hai {accountName},{lineBreak}{lineBreak}Kamu telah menonaktifkan Verifikasi 2 Tahap untuk akun Roblox-mu. Kamu tidak akan lagi memerlukan kode keamanan saat masuk ke akunmu.{lineBreak}{lineBreak}Roblox";
	}

	/// <summary>
	/// Key: "Description.TwoStepVerificationDeactivationEmail.Body.Under13"
	/// Body for 2SV deactivation email for under 13 users
	/// English String: "Hi,{lineBreak}{lineBreak}2-Step Verification has been deactivated for your child's Roblox account, {accountName}. A security code will no longer be required when they log into the account.{lineBreak}{lineBreak}Roblox"
	/// </summary>
	public override string DescriptionTwoStepVerificationDeactivationEmailBodyUnder13(string lineBreak, string accountName)
	{
		return $"Hai,{lineBreak}{lineBreak}Verifikasi 2 Tahap untuk akun Roblox anakmu telah dinonaktifkan, {accountName}. Mereka tidak akan lagi memerlukan kode keamanan saat masuk ke akun mereka.{lineBreak}{lineBreak}Roblox";
	}

	protected override string _GetTemplateForDescriptionTwoStepVerificationDeactivationEmailBodyUnder13()
	{
		return "Hai,{lineBreak}{lineBreak}Verifikasi 2 Tahap untuk akun Roblox anakmu telah dinonaktifkan, {accountName}. Mereka tidak akan lagi memerlukan kode keamanan saat masuk ke akun mereka.{lineBreak}{lineBreak}Roblox";
	}

	/// <summary>
	/// Key: "Description.TwoStepVerificationDeactivationEmail.Subject	"
	/// Subject for 2SV deactivation email
	/// English String: "2-Step Verification Deactivated for Roblox Account: {accountName}"
	/// </summary>
	public override string DescriptionTwoStepVerificationDeactivationEmailSubject(string accountName)
	{
		return $"Verifikasi 2 Tahap untuk Akun Roblox Dinonaktifkan: {accountName}";
	}

	protected override string _GetTemplateForDescriptionTwoStepVerificationDeactivationEmailSubject()
	{
		return "Verifikasi 2 Tahap untuk Akun Roblox Dinonaktifkan: {accountName}";
	}

	/// <summary>
	/// Key: "Description.TwoStepVerificationLoginEmail.Html.GeolocationInfo1"
	/// Geolocation information about IP trying to login
	/// English String: "{spanStartTagWithBold}Login request received from {username} located in {region}, {country} ({ipAddress}).{spanEndTag}{lineBreak}{lineBreak}"
	/// </summary>
	public override string DescriptionTwoStepVerificationLoginEmailHtmlGeolocationInfo1(string spanStartTagWithBold, string username, string region, string country, string ipAddress, string spanEndTag, string lineBreak)
	{
		return $"{spanStartTagWithBold}Permintaan masuk diterima dari {username} yang berada di {region}, {country} ({ipAddress}).{spanEndTag}{lineBreak}{lineBreak}";
	}

	protected override string _GetTemplateForDescriptionTwoStepVerificationLoginEmailHtmlGeolocationInfo1()
	{
		return "{spanStartTagWithBold}Permintaan masuk diterima dari {username} yang berada di {region}, {country} ({ipAddress}).{spanEndTag}{lineBreak}{lineBreak}";
	}

	/// <summary>
	/// Key: "Description.TwoStepVerificationLoginEmail.Html.GeolocationInfo2"
	/// Geolocation info about IP trying to login
	/// English String: "{spanStartTagWithBold}Login request received from {username} located in {country} ({ipAddress}).{spanEndTag}{lineBreak}{lineBreak}\t"
	/// </summary>
	public override string DescriptionTwoStepVerificationLoginEmailHtmlGeolocationInfo2(string spanStartTagWithBold, string username, string country, string ipAddress, string spanEndTag, string lineBreak)
	{
		return $"{spanStartTagWithBold}Permintaan masuk diterima dari {username} yang berada di {country}, ({ipAddress}).{spanEndTag}{lineBreak}{lineBreak}\t";
	}

	protected override string _GetTemplateForDescriptionTwoStepVerificationLoginEmailHtmlGeolocationInfo2()
	{
		return "{spanStartTagWithBold}Permintaan masuk diterima dari {username} yang berada di {country}, ({ipAddress}).{spanEndTag}{lineBreak}{lineBreak}\t";
	}

	/// <summary>
	/// Key: "Description.TwoStepVerificationLoginEmail.Html.GeolocationInfo3"
	/// Geolocation info about IP trying to log in
	/// English String: "{spanStartTagWithBold}Login request received from {username} (From Roblox Internal).{spanEndTag}{lineBreak}{lineBreak}\t"
	/// </summary>
	public override string DescriptionTwoStepVerificationLoginEmailHtmlGeolocationInfo3(string spanStartTagWithBold, string username, string spanEndTag, string lineBreak)
	{
		return $"{spanStartTagWithBold}Permintaan masuk diterima dari {username} (Dari Internal Roblox).{spanEndTag}{lineBreak}{lineBreak}\t";
	}

	protected override string _GetTemplateForDescriptionTwoStepVerificationLoginEmailHtmlGeolocationInfo3()
	{
		return "{spanStartTagWithBold}Permintaan masuk diterima dari {username} (Dari Internal Roblox).{spanEndTag}{lineBreak}{lineBreak}\t";
	}

	/// <summary>
	/// Key: "Description.TwoStepVerificationLoginEmail.Html.GeolocationInfo4"
	/// Geolocation info of IP trying to login
	/// English String: "{spanStartTagWithBold}Login request received from {username} located in {country}.{spanEndTag}{lineBreak}{lineBreak}"
	/// </summary>
	public override string DescriptionTwoStepVerificationLoginEmailHtmlGeolocationInfo4(string spanStartTagWithBold, string username, string country, string spanEndTag, string lineBreak)
	{
		return $"{spanStartTagWithBold}Permintaan masuk diterima dari {username} yang berada di {country}.{spanEndTag}{lineBreak}{lineBreak}";
	}

	protected override string _GetTemplateForDescriptionTwoStepVerificationLoginEmailHtmlGeolocationInfo4()
	{
		return "{spanStartTagWithBold}Permintaan masuk diterima dari {username} yang berada di {country}.{spanEndTag}{lineBreak}{lineBreak}";
	}

	/// <summary>
	/// Key: "Description.TwoStepVerificationLoginEmail.Html.GeolocationInfo5"
	/// Geolocation info of IP trying to login
	/// English String: "{spanStartTagWithBold}Login request received from {username} located in {region}, {country}.{spanEndTag}{lineBreak}{lineBreak}"
	/// </summary>
	public override string DescriptionTwoStepVerificationLoginEmailHtmlGeolocationInfo5(string spanStartTagWithBold, string username, string region, string country, string spanEndTag, string lineBreak)
	{
		return $"{spanStartTagWithBold}Permintaan masuk diterima dari {username} yang berada di {region}, {country}.{spanEndTag}{lineBreak}{lineBreak}";
	}

	protected override string _GetTemplateForDescriptionTwoStepVerificationLoginEmailHtmlGeolocationInfo5()
	{
		return "{spanStartTagWithBold}Permintaan masuk diterima dari {username} yang berada di {region}, {country}.{spanEndTag}{lineBreak}{lineBreak}";
	}

	/// <summary>
	/// Key: "Description.TwoStepVerificationLoginEmail.Html.GeolocationInfo6"
	/// Geolocation info of IP trying to login
	/// English String: "{spanStartTagWithBold}Login request received from {username} located in {city}, {region}, {country}.{spanEndTag}{lineBreak}{lineBreak}"
	/// </summary>
	public override string DescriptionTwoStepVerificationLoginEmailHtmlGeolocationInfo6(string spanStartTagWithBold, string username, string city, string region, string country, string spanEndTag, string lineBreak)
	{
		return $"{spanStartTagWithBold}Permintaan masuk diterima dari {username} yang berada di {city}, {region}, {country}.{spanEndTag}{lineBreak}{lineBreak}";
	}

	protected override string _GetTemplateForDescriptionTwoStepVerificationLoginEmailHtmlGeolocationInfo6()
	{
		return "{spanStartTagWithBold}Permintaan masuk diterima dari {username} yang berada di {city}, {region}, {country}.{spanEndTag}{lineBreak}{lineBreak}";
	}

	/// <summary>
	/// Key: "Description.TwoStepVerificationLoginEmail.HtmlBody"
	/// Html body for 2SV login email
	/// English String: "{geoLocationInformation}{spanStartTagWithBold}Login code for {accountName}: {lineBreak}{lineBreak}{code} {spanEndTag}{lineBreak}{lineBreak}Enter this code into the 2-Step Verification screen to finish logging in. This code will expire in 15 minutes.{lineBreak}{lineBreak}This email was sent because your account tried to login to Roblox from a new browser or device. If you haven't tried logging into Roblox, someone else may be trying to access your account. You are strongly advised to change your password if you did not generate this request.{lineBreak}{lineBreak}Resources:{lineBreak}{aTagStartWithHref}{ChangePasswordLink}{hrefEnd}Change Your Password{aTagEnd} {lineBreak}{aTagStartWithHref}{TwoStepVerificationArticleLink}{hrefEnd}Learn More About 2-Step Verification{aTagEnd} {lineBreak}{aTagStartWithHref}{AccountSafetyArticleLink}{hrefEnd}Keeping Your Account Safe{aTagEnd} {lineBreak}{aTagStartWithHref}{SupportLink}{hrefEnd}General Roblox Support{aTagEnd} {lineBreak}{lineBreak}Thank you,{lineBreak}{lineBreak}The Roblox Team"
	/// </summary>
	public override string DescriptionTwoStepVerificationLoginEmailHtmlBody(string geoLocationInformation, string spanStartTagWithBold, string accountName, string lineBreak, string code, string spanEndTag, string aTagStartWithHref, string ChangePasswordLink, string hrefEnd, string aTagEnd, string TwoStepVerificationArticleLink, string AccountSafetyArticleLink, string SupportLink)
	{
		return $"{geoLocationInformation}{spanStartTagWithBold}Kode masuk untuk {accountName}: {lineBreak}{lineBreak}{code} {spanEndTag}{lineBreak}{lineBreak}Masukkan kode ini ke layar Verifikasi 2 Tahap untuk menyelesaikan proses masuk. Kode ini akan kedaluwarsa dalam 15 menit.{lineBreak}{lineBreak}Email ini dikirim karena akunmu mencoba masuk ke Roblox dari browser atau perangkat baru. Jika kamu tidak mencoba masuk ke Roblox, orang lain mungkin mencoba mengakses akunmu. Kamu sangat disarankan untuk mengubah kata sandi jika tidak membuat permintaan ini.{lineBreak}{lineBreak}Sumber daya:{lineBreak}{aTagStartWithHref}{ChangePasswordLink}{hrefEnd}Ubah Kata Sandimu{aTagEnd} {lineBreak}{aTagStartWithHref}{TwoStepVerificationArticleLink}{hrefEnd}Pelajari Selengkapnya tentang Verifikasi 2 Tahap{aTagEnd} {lineBreak}{aTagStartWithHref}{AccountSafetyArticleLink}{hrefEnd}Menjaga Keamanan Akunmu{aTagEnd} {lineBreak}{aTagStartWithHref}{SupportLink}{hrefEnd}Dukungan Umum Roblox{aTagEnd} {lineBreak}{lineBreak}Terima kasih,{lineBreak}{lineBreak}Tim Roblox";
	}

	protected override string _GetTemplateForDescriptionTwoStepVerificationLoginEmailHtmlBody()
	{
		return "{geoLocationInformation}{spanStartTagWithBold}Kode masuk untuk {accountName}: {lineBreak}{lineBreak}{code} {spanEndTag}{lineBreak}{lineBreak}Masukkan kode ini ke layar Verifikasi 2 Tahap untuk menyelesaikan proses masuk. Kode ini akan kedaluwarsa dalam 15 menit.{lineBreak}{lineBreak}Email ini dikirim karena akunmu mencoba masuk ke Roblox dari browser atau perangkat baru. Jika kamu tidak mencoba masuk ke Roblox, orang lain mungkin mencoba mengakses akunmu. Kamu sangat disarankan untuk mengubah kata sandi jika tidak membuat permintaan ini.{lineBreak}{lineBreak}Sumber daya:{lineBreak}{aTagStartWithHref}{ChangePasswordLink}{hrefEnd}Ubah Kata Sandimu{aTagEnd} {lineBreak}{aTagStartWithHref}{TwoStepVerificationArticleLink}{hrefEnd}Pelajari Selengkapnya tentang Verifikasi 2 Tahap{aTagEnd} {lineBreak}{aTagStartWithHref}{AccountSafetyArticleLink}{hrefEnd}Menjaga Keamanan Akunmu{aTagEnd} {lineBreak}{aTagStartWithHref}{SupportLink}{hrefEnd}Dukungan Umum Roblox{aTagEnd} {lineBreak}{lineBreak}Terima kasih,{lineBreak}{lineBreak}Tim Roblox";
	}

	/// <summary>
	/// Key: "Description.TwoStepVerificationLoginEmail.PlainBody"
	/// Plain body for 2SV login email
	/// English String: "{geoLocationInformation}Login code for {accountName}: {lineBreak}{lineBreak} {code} {lineBreak}{lineBreak}Enter this code into the 2-Step Verification screen to finish logging in. This code will expire in 15 minutes. {lineBreak}{lineBreak}This email was sent because your account tried to login to Roblox from a new browser or device. If you haven't tried logging into Roblox, someone else may be trying to access your account. You are strongly advised to change your password if you did not generate this request. {lineBreak}{lineBreak}Resources: {lineBreak}Change Your Password [{accountInfoPageLink}] {lineBreak}Learn More About 2-Step Verification [{twoStepVerificationHelpArticleLink}]{lineBreak}Keeping Your Account Safe [{keepAccountSafeArticleLink}] {lineBreak}General Roblox Support [{supportPageLink}] {lineBreak}{lineBreak}Thank you, {lineBreak}{lineBreak}The Roblox Team"
	/// </summary>
	public override string DescriptionTwoStepVerificationLoginEmailPlainBody(string geoLocationInformation, string accountName, string lineBreak, string code, string accountInfoPageLink, string twoStepVerificationHelpArticleLink, string keepAccountSafeArticleLink, string supportPageLink)
	{
		return $"{geoLocationInformation}Kode masuk untuk {accountName}: {lineBreak}{lineBreak} {code} {lineBreak}{lineBreak}Masukkan kode ini ke layar Verifikasi 2 Tahap untuk menyelesaikan proses masuk. Kode ini akan kedaluwarsa dalam 15 menit. {lineBreak}{lineBreak}Email ini dikirim karena akunmu mencoba masuk ke Roblox dari browser atau perangkat baru. Jika kamu tidak mencoba masuk ke Roblox, orang lain mungkin mencoba mengakses akunmu. Sangat disarankan untuk mengubah kata sandi jika kamu tidak membuat permintaan ini. {lineBreak}{lineBreak}Sumber informasi: {lineBreak}Ubah Kata Sandimu [{accountInfoPageLink}] {lineBreak}Pelajari Selengkapnya tentang Verifikasi 2 Tahap [{twoStepVerificationHelpArticleLink}]{lineBreak}Menjaga Keamanan Akunmu [{keepAccountSafeArticleLink}] {lineBreak}Dukungan Umum Roblox [{supportPageLink}] {lineBreak}{lineBreak}Terima kasih, {lineBreak}{lineBreak}Tim Roblox";
	}

	protected override string _GetTemplateForDescriptionTwoStepVerificationLoginEmailPlainBody()
	{
		return "{geoLocationInformation}Kode masuk untuk {accountName}: {lineBreak}{lineBreak} {code} {lineBreak}{lineBreak}Masukkan kode ini ke layar Verifikasi 2 Tahap untuk menyelesaikan proses masuk. Kode ini akan kedaluwarsa dalam 15 menit. {lineBreak}{lineBreak}Email ini dikirim karena akunmu mencoba masuk ke Roblox dari browser atau perangkat baru. Jika kamu tidak mencoba masuk ke Roblox, orang lain mungkin mencoba mengakses akunmu. Sangat disarankan untuk mengubah kata sandi jika kamu tidak membuat permintaan ini. {lineBreak}{lineBreak}Sumber informasi: {lineBreak}Ubah Kata Sandimu [{accountInfoPageLink}] {lineBreak}Pelajari Selengkapnya tentang Verifikasi 2 Tahap [{twoStepVerificationHelpArticleLink}]{lineBreak}Menjaga Keamanan Akunmu [{keepAccountSafeArticleLink}] {lineBreak}Dukungan Umum Roblox [{supportPageLink}] {lineBreak}{lineBreak}Terima kasih, {lineBreak}{lineBreak}Tim Roblox";
	}

	/// <summary>
	/// Key: "Description.TwoStepVerificationLoginEmail.PlainText.GeolocationInfo1"
	/// GeoLocation info of IP trying to login
	/// English String: "Login request received from {username} located in {region}, {country} ({ipAddress}).{lineBreak}{lineBreak}"
	/// </summary>
	public override string DescriptionTwoStepVerificationLoginEmailPlainTextGeolocationInfo1(string username, string region, string country, string ipAddress, string lineBreak)
	{
		return $"Permintaan masuk diterima dari {username} yang berada di {region}, {country} ({ipAddress}).{lineBreak}{lineBreak}";
	}

	protected override string _GetTemplateForDescriptionTwoStepVerificationLoginEmailPlainTextGeolocationInfo1()
	{
		return "Permintaan masuk diterima dari {username} yang berada di {region}, {country} ({ipAddress}).{lineBreak}{lineBreak}";
	}

	/// <summary>
	/// Key: "Description.TwoStepVerificationLoginEmail.PlainText.GeolocationInfo2"
	/// Geolocation info of IP trying to login
	/// English String: "Login request received from {username} located in {country} ({ipAddress}).{lineBreak}{lineBreak}"
	/// </summary>
	public override string DescriptionTwoStepVerificationLoginEmailPlainTextGeolocationInfo2(string username, string country, string ipAddress, string lineBreak)
	{
		return $"Permintaan masuk diterima dari {username} yang berada di {country}, ({ipAddress}).{lineBreak}{lineBreak}";
	}

	protected override string _GetTemplateForDescriptionTwoStepVerificationLoginEmailPlainTextGeolocationInfo2()
	{
		return "Permintaan masuk diterima dari {username} yang berada di {country}, ({ipAddress}).{lineBreak}{lineBreak}";
	}

	/// <summary>
	/// Key: "Description.TwoStepVerificationLoginEmail.PlainText.GeolocationInfo3"
	/// Geolocation info of IP trying to login
	/// English String: "Login request received from {username} (From Roblox Internal).{lineBreak}{lineBreak}"
	/// </summary>
	public override string DescriptionTwoStepVerificationLoginEmailPlainTextGeolocationInfo3(string username, string lineBreak)
	{
		return $"Permintaan masuk diterima dari {username} (Dari Internal Roblox).{lineBreak}{lineBreak}";
	}

	protected override string _GetTemplateForDescriptionTwoStepVerificationLoginEmailPlainTextGeolocationInfo3()
	{
		return "Permintaan masuk diterima dari {username} (Dari Internal Roblox).{lineBreak}{lineBreak}";
	}

	/// <summary>
	/// Key: "Description.TwoStepVerificationLoginEmail.PlainText.GeolocationInfo4"
	/// Geolocation info of IP trying to login
	/// English String: "Login request received from {username} located in {country}.{lineBreak}{lineBreak}"
	/// </summary>
	public override string DescriptionTwoStepVerificationLoginEmailPlainTextGeolocationInfo4(string username, string country, string lineBreak)
	{
		return $"Permintaan masuk diterima dari {username} yang berada di {country}.{lineBreak}{lineBreak}";
	}

	protected override string _GetTemplateForDescriptionTwoStepVerificationLoginEmailPlainTextGeolocationInfo4()
	{
		return "Permintaan masuk diterima dari {username} yang berada di {country}.{lineBreak}{lineBreak}";
	}

	/// <summary>
	/// Key: "Description.TwoStepVerificationLoginEmail.PlainText.GeolocationInfo5"
	/// Geolocation info of IP trying to login
	/// English String: "Login request received from {username} located in {region}, {country}.{lineBreak}{lineBreak}"
	/// </summary>
	public override string DescriptionTwoStepVerificationLoginEmailPlainTextGeolocationInfo5(string username, string region, string country, string lineBreak)
	{
		return $"Permintaan masuk diterima dari {username} yang berada di {region}, {country}.{lineBreak}{lineBreak}";
	}

	protected override string _GetTemplateForDescriptionTwoStepVerificationLoginEmailPlainTextGeolocationInfo5()
	{
		return "Permintaan masuk diterima dari {username} yang berada di {region}, {country}.{lineBreak}{lineBreak}";
	}

	/// <summary>
	/// Key: "Description.TwoStepVerificationLoginEmail.PlainText.GeolocationInfo6"
	/// Geolocation info of IP trying to login
	/// English String: "Login request received from {username} located in {city}, {region}, {country}.{lineBreak}{lineBreak}"
	/// </summary>
	public override string DescriptionTwoStepVerificationLoginEmailPlainTextGeolocationInfo6(string username, string city, string region, string country, string lineBreak)
	{
		return $"Permintaan masuk diterima dari {username} yang berada di {city}, {region}, {country}.{lineBreak}{lineBreak}";
	}

	protected override string _GetTemplateForDescriptionTwoStepVerificationLoginEmailPlainTextGeolocationInfo6()
	{
		return "Permintaan masuk diterima dari {username} yang berada di {city}, {region}, {country}.{lineBreak}{lineBreak}";
	}

	/// <summary>
	/// Key: "Description.TwoStepVerificationLoginEmail.Subject"
	/// Subject for 2SV login email
	/// English String: "Verification Code for Roblox Account: {accountName}"
	/// </summary>
	public override string DescriptionTwoStepVerificationLoginEmailSubject(string accountName)
	{
		return $"Kode Verifikasi untuk Akun Roblox: {accountName}";
	}

	protected override string _GetTemplateForDescriptionTwoStepVerificationLoginEmailSubject()
	{
		return "Kode Verifikasi untuk Akun Roblox: {accountName}";
	}

	protected override string _GetTemplateForLabelCode()
	{
		return "Kode";
	}

	/// <summary>
	/// Key: "Label.CodeInputPlaceholderText"
	/// example: Enter 4-digit code
	/// English String: "Enter {codeLength}-digit Code"
	/// </summary>
	public override string LabelCodeInputPlaceholderText(string codeLength)
	{
		return $"Masukkan Kode {codeLength} digit";
	}

	protected override string _GetTemplateForLabelCodeInputPlaceholderText()
	{
		return "Masukkan Kode {codeLength} digit";
	}

	protected override string _GetTemplateForLabelDidNotReceive()
	{
		return "Belum menerima kode?";
	}

	protected override string _GetTemplateForLabelEnterCode()
	{
		return "Masukkan Kode (6 digit)";
	}

	protected override string _GetTemplateForLabelEnterEmailCode()
	{
		return "Masukkan kode yang baru saja kami kirimkan lewat email";
	}

	protected override string _GetTemplateForLabelEnterTextCode()
	{
		return "Masukkan kode yang baru saja kami kirimkan lewat pesan teks";
	}

	protected override string _GetTemplateForLabelEnterTwoStepVerificationCode()
	{
		return "Masukkan kode verifikasi dua tahapmu.";
	}

	protected override string _GetTemplateForLabelFacebookPasswordWarning()
	{
		return "Jika kamu sudah masuk dengan Facebook, kamu harus membuat kata sandi.";
	}

	protected override string _GetTemplateForLabelLearnMore()
	{
		return "Pelajari Selengkapnya";
	}

	/// <summary>
	/// Key: "Label.NeedHelpContactSupport"
	/// label for the support article link
	/// English String: "Need help? Contact {supportLink}"
	/// </summary>
	public override string LabelNeedHelpContactSupport(string supportLink)
	{
		return $"Butuh bantuan? Hubungi {supportLink}";
	}

	protected override string _GetTemplateForLabelNeedHelpContactSupport()
	{
		return "Butuh bantuan? Hubungi {supportLink}";
	}

	protected override string _GetTemplateForLabelNewCode()
	{
		return "Kode Baru";
	}

	protected override string _GetTemplateForLabelRobloxSupport()
	{
		return "Dukungan Roblox";
	}

	protected override string _GetTemplateForLabelTrustThisDevice()
	{
		return "Percayai perangkat ini selama 30 hari";
	}

	protected override string _GetTemplateForLabelTwoStepVerification()
	{
		return "Verifikasi 2 Tahap";
	}

	protected override string _GetTemplateForResponseCodeSent()
	{
		return "Kode Terkirim";
	}

	protected override string _GetTemplateForResponseFeatureNotAvailable()
	{
		return "Fitur tidak tersedia. Harap hubungi dukungan.";
	}

	protected override string _GetTemplateForResponseInvalidCode()
	{
		return "Kode tidak valid.";
	}

	protected override string _GetTemplateForResponseSystemErrorReturnToLogin()
	{
		return "Kesalahan sistem. Harap kembali ke halaman masuk.";
	}

	protected override string _GetTemplateForResponseTooManyAttempts()
	{
		return "Terlalu banyak percobaan. Harap coba lagi nanti.";
	}

	protected override string _GetTemplateForResponseTooManyCharacters()
	{
		return "Terlalu banyak karakter";
	}
}
