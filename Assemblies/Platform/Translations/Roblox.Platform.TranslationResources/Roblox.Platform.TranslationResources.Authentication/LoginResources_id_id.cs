namespace Roblox.TranslationResources.Authentication;

/// <summary>
/// This class overrides LoginResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class LoginResources_id_id : LoginResources_en_us, ILoginResources, ITranslationResources
{
	/// <summary>
	/// Key: "Action.Cancel"
	/// Cancel button text
	/// English String: "Cancel"
	/// </summary>
	public override string ActionCancel => "Batal";

	/// <summary>
	/// Key: "Action.Facebook"
	/// facebook button label
	/// English String: "Facebook"
	/// </summary>
	public override string ActionFacebook => "Facebook";

	/// <summary>
	/// Key: "Action.ForgotPasswordOrUsernameQuestion"
	/// English String: "Forgot password or username?"
	/// </summary>
	public override string ActionForgotPasswordOrUsernameQuestion => "Lupa kata sandi atau nama pengguna?";

	/// <summary>
	/// Key: "Action.ForgotPasswordOrUsernameQuestionCapitalized"
	/// link under login form
	/// English String: "Forgot Password or Username?"
	/// </summary>
	public override string ActionForgotPasswordOrUsernameQuestionCapitalized => "Lupa Kata Sandi atau Nama Pengguna?";

	/// <summary>
	/// Key: "Action.Login"
	/// English String: "Login"
	/// </summary>
	public override string ActionLogin => "Masuk";

	/// <summary>
	/// Key: "Action.LogInCapitalized"
	/// login button label. please note this is different from 'Login' or 'Log in'.
	/// English String: "Log In"
	/// </summary>
	public override string ActionLogInCapitalized => "Masuk";

	/// <summary>
	/// Key: "Action.Ok"
	/// button text
	/// English String: "OK"
	/// </summary>
	public override string ActionOk => "OKE";

	/// <summary>
	/// Key: "Action.PlayAsGuest"
	/// Play as Guest
	/// English String: "Play as Guest"
	/// </summary>
	public override string ActionPlayAsGuest => "Main sebagai Tamu";

	/// <summary>
	/// Key: "Action.Resend"
	/// button text for resending verification email
	/// English String: "Resend"
	/// </summary>
	public override string ActionResend => "Kirim Ulang";

	/// <summary>
	/// Key: "Action.ResendEmail"
	/// link that resends verification email to user
	/// English String: "Resend Email"
	/// </summary>
	public override string ActionResendEmail => "Kirim Ulang Email";

	/// <summary>
	/// Key: "Action.SendVerificationEmail"
	/// button user can click to send a verification link to their email
	/// English String: "Send Verification Email"
	/// </summary>
	public override string ActionSendVerificationEmail => "Kirim Email Verifikasi";

	/// <summary>
	/// Key: "Action.SignIn"
	/// Sign In button text
	/// English String: "Sign In"
	/// </summary>
	public override string ActionSignIn => "Masuk";

	/// <summary>
	/// Key: "Action.SignInWithFacebook"
	/// Sign In with Facebook
	/// English String: "Sign In with Facebook"
	/// </summary>
	public override string ActionSignInWithFacebook => "Masuk dengan Facebook.";

	/// <summary>
	/// Key: "Action.SignUp"
	/// English String: "Sign up"
	/// </summary>
	public override string ActionSignUp => "Daftar";

	/// <summary>
	/// Key: "Action.SignUpCapitalized"
	/// link which takes user to sign up page
	/// English String: "Sign Up"
	/// </summary>
	public override string ActionSignUpCapitalized => "Daftar";

	/// <summary>
	/// Key: "Action.WeChatLogin"
	/// button text for logging in with WeChat
	/// English String: "WeChat Login"
	/// </summary>
	public override string ActionWeChatLogin => "Masuk WeChat";

	/// <summary>
	/// Key: "Heading.Login"
	/// heading on the login page
	/// English String: "Login"
	/// </summary>
	public override string HeadingLogin => "Masuk";

	/// <summary>
	/// Key: "Heading.LoginRoblox"
	/// current login page heading
	/// English String: "Login to Roblox"
	/// </summary>
	public override string HeadingLoginRoblox => "Masuk ke Roblox";

	public override string HeadingSignUpMakeFriends => "Daftar untuk Membangun & Menjalin Pertemanan";

	/// <summary>
	/// Key: "Label.AccountNotNeeded"
	/// You don't need an account to play Roblox
	/// English String: "You don't need an account to play Roblox"
	/// </summary>
	public override string LabelAccountNotNeeded => "Kamu tidak perlu akun untuk dapat bermain Roblox";

	/// <summary>
	/// Key: "Label.EmailNeedsVerification"
	/// modal header used for prompting user they need to verify their email in order to log in with it
	/// English String: "Your email needs verification"
	/// </summary>
	public override string LabelEmailNeedsVerification => "Emailmu perlu diverifikasi";

	/// <summary>
	/// Key: "Label.FacebookCreatePasswordWarning"
	/// If you have been signing in with Facebook, you must set a password.
	/// English String: "If you have been signing in with Facebook, you must set a password."
	/// </summary>
	public override string LabelFacebookCreatePasswordWarning => "Jika kamu sudah masuk dengan Facebook, kamu harus membuat kata sandi.";

	/// <summary>
	/// Key: "Label.ForgotUsernamePassword"
	/// landing page top right link for password reset
	/// English String: "Forgot Username/Password?"
	/// </summary>
	public override string LabelForgotUsernamePassword => "Lupa Nama Pengguna/Kata Sandi?";

	/// <summary>
	/// Key: "Label.LearnMore"
	/// learn more link text
	/// English String: "Learn more"
	/// </summary>
	public override string LabelLearnMore => "Pelajari selengkapnya";

	/// <summary>
	/// Key: "Label.LoggingInSpinnerText"
	/// English String: "Logging in…"
	/// </summary>
	public override string LabelLoggingInSpinnerText => "Masuk...";

	/// <summary>
	/// Key: "Label.Login"
	/// English String: "Log in"
	/// </summary>
	public override string LabelLogin => "Masuk";

	/// <summary>
	/// Key: "Label.LoginWithYour"
	/// Label for a partition line between login with email and facebook login. Please keep the text in lowercase for roman characters.
	/// English String: "login with your"
	/// </summary>
	public override string LabelLoginWithYour => "masuk dengan";

	/// <summary>
	/// Key: "Label.NoAccount"
	/// Don't have an account?
	/// English String: "Don't have an account?"
	/// </summary>
	public override string LabelNoAccount => "Tidak punya akun?";

	/// <summary>
	/// Key: "Label.NonAMemberQuestion"
	/// The question heading for the section on the login page to take use to sign up page.
	/// English String: "Not a member?"
	/// </summary>
	public override string LabelNonAMemberQuestion => "Bukan anggota?";

	/// <summary>
	/// Key: "Label.NotReceived"
	/// prompt for allowing users to resend verification email
	/// English String: "Didn't receive it?"
	/// </summary>
	public override string LabelNotReceived => "Belum menerimanya?";

	/// <summary>
	/// Key: "Label.Or"
	/// partition between email login and facebook login
	/// English String: "Or"
	/// </summary>
	public override string LabelOr => "Atau";

	/// <summary>
	/// Key: "Label.Password"
	/// Password
	/// English String: "Password"
	/// </summary>
	public override string LabelPassword => "Kata sandi";

	/// <summary>
	/// Key: "Label.PasswordWithColumn"
	/// label for the password field on the login page
	/// English String: "Password:"
	/// </summary>
	public override string LabelPasswordWithColumn => "Kata sandi:";

	/// <summary>
	/// Key: "Label.StartPlaying"
	/// You can start playing right now, in guest mode!
	/// English String: "You can start playing right now, in guest mode!"
	/// </summary>
	public override string LabelStartPlaying => "Kamu bisa bermain sekarang juga, sebagai tamu!";

	/// <summary>
	/// Key: "Label.UnverifiedEmailInstructions"
	/// message shown in a modal when user logs in with unverified email
	/// English String: "To log in with your email, it must be verified. You can also log in with your username."
	/// </summary>
	public override string LabelUnverifiedEmailInstructions => "Untuk masuk menggunakan email, email harus diverifikasi terlebih dahulu. Kamu juga dapat masuk menggunakan nama penggunamu.";

	/// <summary>
	/// Key: "Label.Username"
	/// English String: "Username"
	/// </summary>
	public override string LabelUsername => "Nama pengguna";

	/// <summary>
	/// Key: "Label.UsernameEmail"
	/// placeholder text for input field that accepts username or email
	/// English String: "Username/Email"
	/// </summary>
	public override string LabelUsernameEmail => "Nama Pengguna/Email";

	/// <summary>
	/// Key: "Label.UsernameEmailPhone"
	/// placeholder text for input fields that accept username, email or phone
	/// English String: "Username/Email/Phone"
	/// </summary>
	public override string LabelUsernameEmailPhone => "Nama Pengguna/Email/Nomor Telepon";

	/// <summary>
	/// Key: "Label.UsernamePhone"
	/// placeholder text for input field that accepts username or phone
	/// English String: "Username/Phone"
	/// </summary>
	public override string LabelUsernamePhone => "Nama Pengguna/Nomor Telepon";

	/// <summary>
	/// Key: "Label.UsernameWithColumn"
	/// label for username field on login page
	/// English String: "Username:"
	/// </summary>
	public override string LabelUsernameWithColumn => "Nama pengguna:";

	/// <summary>
	/// Key: "Label.VerificationEmailSent"
	/// message telling user a verification email was sent to them
	/// English String: "Verification Email Sent!"
	/// </summary>
	public override string LabelVerificationEmailSent => "Email Verifikasi Terkirim!";

	/// <summary>
	/// Key: "Label.WeChatAntiAddictionText"
	/// English String: "Boycott bad games, refuse pirated games. Be aware of self-defense and being deceived. Playing games is good for your brain, but too much game play can harm your health. Manage your time well and enjoy a healthy lifestyle."
	/// </summary>
	public override string LabelWeChatAntiAddictionText => "Tinggalkan game yang tidak baik, tolak game bajakan. Pahami cara membela diri dan jangan sampai tertipu. Bermain game baik untuk otak, tapi terlalu banyak bermain game bisa mengganggu kesehatan. Atur waktumu dengan baik dan nikmati hidup sehat.";

	/// <summary>
	/// Key: "Message.UnknownErrorTryAgain"
	/// An unknown error occurred. Please try again.
	/// English String: "An unknown error occurred. Please try again."
	/// </summary>
	public override string MessageUnknownErrorTryAgain => "Terjadi kesalahan tidak diketahui. Coba lagi.";

	/// <summary>
	/// Key: "Message.UsernameAndPasswordRequired"
	/// message shown to user when they attempt to login without entering a username or password
	/// English String: "Username and password required"
	/// </summary>
	public override string MessageUsernameAndPasswordRequired => "Nama pengguna dan kata sandi diperlukan";

	/// <summary>
	/// Key: "Response.AccountIssueErrorContactSupport"
	/// English String: "Account issue. Please contact Support."
	/// </summary>
	public override string ResponseAccountIssueErrorContactSupport => "Masalah akun. Harap hubungi Dukungan.";

	/// <summary>
	/// Key: "Response.AccountLockedRequestReset"
	/// Account has been locked. Please request a password reset.
	/// English String: "Account has been locked. Please request a password reset."
	/// </summary>
	public override string ResponseAccountLockedRequestReset => "Akunmu sudah terkunci. Kirim permintaan pembuatan ulang kata sandi.";

	/// <summary>
	/// Key: "Response.AccountNotFound"
	/// Account not found. Please try again.
	/// English String: "Account not found. Please try again."
	/// </summary>
	public override string ResponseAccountNotFound => "Akun tidak ditemukan. Coba lagi.";

	/// <summary>
	/// Key: "Response.EmailLinkedToMultipleAccountsLoginWithUsername"
	/// error message displayed when user attempts to log in with an email that is linked to multiple accounts
	/// English String: "Your email is associated with more than 1 username. Please login with your username."
	/// </summary>
	public override string ResponseEmailLinkedToMultipleAccountsLoginWithUsername => "Emailmu terhubung dengan lebih dari 1 nama pengguna. Silakan masuk dengan nama penggunamu.";

	/// <summary>
	/// Key: "Response.EmailSent"
	/// response telling user that a verification email has been sent to them
	/// English String: "Email sent!"
	/// </summary>
	public override string ResponseEmailSent => "Email terkirim!";

	/// <summary>
	/// Key: "Response.IncorrectEmailOrPassword"
	/// error message displayed when user logs in with an invalid email or password
	/// English String: "Incorrect email or password."
	/// </summary>
	public override string ResponseIncorrectEmailOrPassword => "Email atau kata sandi salah.";

	/// <summary>
	/// Key: "Response.IncorrectPhoneOrPassword"
	/// error message displayed when user logs in with an invalid phone or password
	/// English String: "Incorrect phone or password."
	/// </summary>
	public override string ResponseIncorrectPhoneOrPassword => "Nomor telepon atau kata sandi salah.";

	/// <summary>
	/// Key: "Response.IncorrectUsernamePassword"
	/// English String: "Incorrect username or password."
	/// </summary>
	public override string ResponseIncorrectUsernamePassword => "Nama pengguna atau kata sandi salah.";

	/// <summary>
	/// Key: "Response.LoginWithUsername"
	/// error message shown when user attempts to login with method other than username and an error occurred
	/// English String: "Something went wrong. Please login with your username."
	/// </summary>
	public override string ResponseLoginWithUsername => "Terjadi kesalahan. Harap masuk dengan nama penggunamu.";

	/// <summary>
	/// Key: "Response.PasswordNotProvided"
	/// password field is empty
	/// English String: "You must enter a password."
	/// </summary>
	public override string ResponsePasswordNotProvided => "Kamu harus memasukkan kata sandi.";

	/// <summary>
	/// Key: "Response.TooManyAttemptsPleaseWait"
	/// English String: "Too many attempts. Please wait a bit."
	/// </summary>
	public override string ResponseTooManyAttemptsPleaseWait => "Terlalu banyak percobaan. Harap tunggu sebentar.";

	/// <summary>
	/// Key: "Response.UnknownError"
	/// English String: "Unknown Error"
	/// </summary>
	public override string ResponseUnknownError => "Kesalahan Tidak Dikenal";

	/// <summary>
	/// Key: "Response.UnknownLoginError"
	/// Unknown login failure.
	/// English String: "Unknown login failure."
	/// </summary>
	public override string ResponseUnknownLoginError => "Kesalahan masuk yang tidak diketahui";

	/// <summary>
	/// Key: "Response.UnverifiedEmailLoginWithUsername"
	/// error message shown when user attempts to login with unverified email
	/// English String: "Your email is not verified. Please login with your username."
	/// </summary>
	public override string ResponseUnverifiedEmailLoginWithUsername => "Emailmu belum terverifikasi. Silakan masuk dengan nama penggunamu.";

	/// <summary>
	/// Key: "Response.UnverifiedPhoneLoginWithUsername"
	/// error message shown when user attempts to login with an unverified phone number
	/// English String: "Your phone is not verified. Please login with your username."
	/// </summary>
	public override string ResponseUnverifiedPhoneLoginWithUsername => "Nomor teleponmu belum terverifikasi. Silakan masuk dengan nama penggunamu.";

	/// <summary>
	/// Key: "Response.UsernameNotProvided"
	/// username field is empty
	/// English String: "You must enter a username."
	/// </summary>
	public override string ResponseUsernameNotProvided => "Kamu harus memasukkan nama pengguna.";

	/// <summary>
	/// Key: "Response.UseSocialSignOn"
	/// Unable to login. Please use Social Network sign on.
	/// English String: "Unable to login. Please use Social Network sign on."
	/// </summary>
	public override string ResponseUseSocialSignOn => "Tidak dapat masuk. Harap gunakan Jaringan Sosial untuk masuk.";

	/// <summary>
	/// Key: "WeChat.AntiAddictionText"
	/// English String: "Boycott bad games, refuse pirated games. Be aware of self-defense and being deceived. Playing games is good for your brain, but too much game play can harm your health. Manage your time well and enjoy a healthy lifestyle."
	/// </summary>
	public override string WeChatAntiAddictionText => "Tinggalkan game yang tidak baik, tolak game bajakan. Pahami cara membela diri dan jangan sampai tertipu. Bermain game baik untuk otak, tapi terlalu banyak bermain game bisa mengganggu kesehatan. Atur waktumu dengan baik dan nikmati hidup sehat.";

	/// <summary>
	/// Key: "WeChat.RealNameNotVerified"
	/// English String: "Your WeChat is not real-name verified. Please use a real-name verified WeChat account and try again. Please visit https://jiazhang.qq.com/zk/home.html"
	/// </summary>
	public override string WeChatRealNameNotVerified => "WeChat kamu tidak terverifikasi sebagai nama asli. Harap gunakan akun WeChat yang terverifikasi sebagai nama asli lalu coba lagi. Kunjungi https://jiazhang.qq.com/zk/home.html";

	public LoginResources_id_id(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionCancel()
	{
		return "Batal";
	}

	protected override string _GetTemplateForActionFacebook()
	{
		return "Facebook";
	}

	protected override string _GetTemplateForActionForgotPasswordOrUsernameQuestion()
	{
		return "Lupa kata sandi atau nama pengguna?";
	}

	protected override string _GetTemplateForActionForgotPasswordOrUsernameQuestionCapitalized()
	{
		return "Lupa Kata Sandi atau Nama Pengguna?";
	}

	protected override string _GetTemplateForActionLogin()
	{
		return "Masuk";
	}

	protected override string _GetTemplateForActionLogInCapitalized()
	{
		return "Masuk";
	}

	protected override string _GetTemplateForActionOk()
	{
		return "OKE";
	}

	protected override string _GetTemplateForActionPlayAsGuest()
	{
		return "Main sebagai Tamu";
	}

	protected override string _GetTemplateForActionResend()
	{
		return "Kirim Ulang";
	}

	protected override string _GetTemplateForActionResendEmail()
	{
		return "Kirim Ulang Email";
	}

	protected override string _GetTemplateForActionSendVerificationEmail()
	{
		return "Kirim Email Verifikasi";
	}

	protected override string _GetTemplateForActionSignIn()
	{
		return "Masuk";
	}

	protected override string _GetTemplateForActionSignInWithFacebook()
	{
		return "Masuk dengan Facebook.";
	}

	protected override string _GetTemplateForActionSignUp()
	{
		return "Daftar";
	}

	protected override string _GetTemplateForActionSignUpCapitalized()
	{
		return "Daftar";
	}

	protected override string _GetTemplateForActionWeChatLogin()
	{
		return "Masuk WeChat";
	}

	protected override string _GetTemplateForHeadingLogin()
	{
		return "Masuk";
	}

	protected override string _GetTemplateForHeadingLoginRoblox()
	{
		return "Masuk ke Roblox";
	}

	protected override string _GetTemplateForHeadingSignUpMakeFriends()
	{
		return "Daftar untuk Membangun & Menjalin Pertemanan";
	}

	protected override string _GetTemplateForLabelAccountNotNeeded()
	{
		return "Kamu tidak perlu akun untuk dapat bermain Roblox";
	}

	protected override string _GetTemplateForLabelEmailNeedsVerification()
	{
		return "Emailmu perlu diverifikasi";
	}

	protected override string _GetTemplateForLabelFacebookCreatePasswordWarning()
	{
		return "Jika kamu sudah masuk dengan Facebook, kamu harus membuat kata sandi.";
	}

	protected override string _GetTemplateForLabelForgotUsernamePassword()
	{
		return "Lupa Nama Pengguna/Kata Sandi?";
	}

	/// <summary>
	/// Key: "Label.GreetingForNewAccount"
	/// Shown when a username doesn't exist on the login page to invite to create a new account.
	/// English String: "Nice to meet you, {username}. {linkStartSignup}Let's make an account! {linkEndSignup}"
	/// </summary>
	public override string LabelGreetingForNewAccount(string username, string linkStartSignup, string linkEndSignup)
	{
		return $"Senang bertemu denganmu, {username}. {linkStartSignup}Ayo kita buat akun! {linkEndSignup}";
	}

	protected override string _GetTemplateForLabelGreetingForNewAccount()
	{
		return "Senang bertemu denganmu, {username}. {linkStartSignup}Ayo kita buat akun! {linkEndSignup}";
	}

	protected override string _GetTemplateForLabelLearnMore()
	{
		return "Pelajari selengkapnya";
	}

	protected override string _GetTemplateForLabelLoggingInSpinnerText()
	{
		return "Masuk...";
	}

	protected override string _GetTemplateForLabelLogin()
	{
		return "Masuk";
	}

	protected override string _GetTemplateForLabelLoginWithYour()
	{
		return "masuk dengan";
	}

	protected override string _GetTemplateForLabelNoAccount()
	{
		return "Tidak punya akun?";
	}

	protected override string _GetTemplateForLabelNonAMemberQuestion()
	{
		return "Bukan anggota?";
	}

	protected override string _GetTemplateForLabelNotReceived()
	{
		return "Belum menerimanya?";
	}

	protected override string _GetTemplateForLabelOr()
	{
		return "Atau";
	}

	protected override string _GetTemplateForLabelPassword()
	{
		return "Kata sandi";
	}

	protected override string _GetTemplateForLabelPasswordWithColumn()
	{
		return "Kata sandi:";
	}

	protected override string _GetTemplateForLabelStartPlaying()
	{
		return "Kamu bisa bermain sekarang juga, sebagai tamu!";
	}

	protected override string _GetTemplateForLabelUnverifiedEmailInstructions()
	{
		return "Untuk masuk menggunakan email, email harus diverifikasi terlebih dahulu. Kamu juga dapat masuk menggunakan nama penggunamu.";
	}

	protected override string _GetTemplateForLabelUsername()
	{
		return "Nama pengguna";
	}

	protected override string _GetTemplateForLabelUsernameEmail()
	{
		return "Nama Pengguna/Email";
	}

	protected override string _GetTemplateForLabelUsernameEmailPhone()
	{
		return "Nama Pengguna/Email/Nomor Telepon";
	}

	protected override string _GetTemplateForLabelUsernamePhone()
	{
		return "Nama Pengguna/Nomor Telepon";
	}

	protected override string _GetTemplateForLabelUsernameWithColumn()
	{
		return "Nama pengguna:";
	}

	protected override string _GetTemplateForLabelVerificationEmailSent()
	{
		return "Email Verifikasi Terkirim!";
	}

	protected override string _GetTemplateForLabelWeChatAntiAddictionText()
	{
		return "Tinggalkan game yang tidak baik, tolak game bajakan. Pahami cara membela diri dan jangan sampai tertipu. Bermain game baik untuk otak, tapi terlalu banyak bermain game bisa mengganggu kesehatan. Atur waktumu dengan baik dan nikmati hidup sehat.";
	}

	protected override string _GetTemplateForMessageUnknownErrorTryAgain()
	{
		return "Terjadi kesalahan tidak diketahui. Coba lagi.";
	}

	protected override string _GetTemplateForMessageUsernameAndPasswordRequired()
	{
		return "Nama pengguna dan kata sandi diperlukan";
	}

	protected override string _GetTemplateForResponseAccountIssueErrorContactSupport()
	{
		return "Masalah akun. Harap hubungi Dukungan.";
	}

	protected override string _GetTemplateForResponseAccountLockedRequestReset()
	{
		return "Akunmu sudah terkunci. Kirim permintaan pembuatan ulang kata sandi.";
	}

	protected override string _GetTemplateForResponseAccountNotFound()
	{
		return "Akun tidak ditemukan. Coba lagi.";
	}

	protected override string _GetTemplateForResponseEmailLinkedToMultipleAccountsLoginWithUsername()
	{
		return "Emailmu terhubung dengan lebih dari 1 nama pengguna. Silakan masuk dengan nama penggunamu.";
	}

	protected override string _GetTemplateForResponseEmailSent()
	{
		return "Email terkirim!";
	}

	protected override string _GetTemplateForResponseIncorrectEmailOrPassword()
	{
		return "Email atau kata sandi salah.";
	}

	protected override string _GetTemplateForResponseIncorrectPhoneOrPassword()
	{
		return "Nomor telepon atau kata sandi salah.";
	}

	protected override string _GetTemplateForResponseIncorrectUsernamePassword()
	{
		return "Nama pengguna atau kata sandi salah.";
	}

	protected override string _GetTemplateForResponseLoginWithUsername()
	{
		return "Terjadi kesalahan. Harap masuk dengan nama penggunamu.";
	}

	protected override string _GetTemplateForResponsePasswordNotProvided()
	{
		return "Kamu harus memasukkan kata sandi.";
	}

	protected override string _GetTemplateForResponseTooManyAttemptsPleaseWait()
	{
		return "Terlalu banyak percobaan. Harap tunggu sebentar.";
	}

	protected override string _GetTemplateForResponseUnknownError()
	{
		return "Kesalahan Tidak Dikenal";
	}

	protected override string _GetTemplateForResponseUnknownLoginError()
	{
		return "Kesalahan masuk yang tidak diketahui";
	}

	protected override string _GetTemplateForResponseUnverifiedEmailLoginWithUsername()
	{
		return "Emailmu belum terverifikasi. Silakan masuk dengan nama penggunamu.";
	}

	protected override string _GetTemplateForResponseUnverifiedPhoneLoginWithUsername()
	{
		return "Nomor teleponmu belum terverifikasi. Silakan masuk dengan nama penggunamu.";
	}

	protected override string _GetTemplateForResponseUsernameNotProvided()
	{
		return "Kamu harus memasukkan nama pengguna.";
	}

	protected override string _GetTemplateForResponseUseSocialSignOn()
	{
		return "Tidak dapat masuk. Harap gunakan Jaringan Sosial untuk masuk.";
	}

	/// <summary>
	/// Key: "Response.WeChatNotRealNameVerified"
	/// English String: "Your WeChat is not real-name verified. Please use a real-name verified WeChat account and try again. Please visit {url}"
	/// </summary>
	public override string ResponseWeChatNotRealNameVerified(string url)
	{
		return $"WeChat milikmu belum melewati verifikasi nama asli. Harap gunakan akun WeChat yang sudah melewati verifikasi nama asli lalu coba lagi. Kunjungi {url}";
	}

	protected override string _GetTemplateForResponseWeChatNotRealNameVerified()
	{
		return "WeChat milikmu belum melewati verifikasi nama asli. Harap gunakan akun WeChat yang sudah melewati verifikasi nama asli lalu coba lagi. Kunjungi {url}";
	}

	protected override string _GetTemplateForWeChatAntiAddictionText()
	{
		return "Tinggalkan game yang tidak baik, tolak game bajakan. Pahami cara membela diri dan jangan sampai tertipu. Bermain game baik untuk otak, tapi terlalu banyak bermain game bisa mengganggu kesehatan. Atur waktumu dengan baik dan nikmati hidup sehat.";
	}

	protected override string _GetTemplateForWeChatRealNameNotVerified()
	{
		return "WeChat kamu tidak terverifikasi sebagai nama asli. Harap gunakan akun WeChat yang terverifikasi sebagai nama asli lalu coba lagi. Kunjungi https://jiazhang.qq.com/zk/home.html";
	}
}
