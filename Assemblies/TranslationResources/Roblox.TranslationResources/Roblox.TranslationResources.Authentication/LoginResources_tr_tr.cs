namespace Roblox.TranslationResources.Authentication;

/// <summary>
/// This class overrides LoginResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class LoginResources_tr_tr : LoginResources_en_us, ILoginResources, ITranslationResources
{
	/// <summary>
	/// Key: "Action.Cancel"
	/// Cancel button text
	/// English String: "Cancel"
	/// </summary>
	public override string ActionCancel => "İptal Et";

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
	public override string ActionForgotPasswordOrUsernameQuestion => "Kullanıcı adını veya şifreni mi unuttun?";

	/// <summary>
	/// Key: "Action.ForgotPasswordOrUsernameQuestionCapitalized"
	/// link under login form
	/// English String: "Forgot Password or Username?"
	/// </summary>
	public override string ActionForgotPasswordOrUsernameQuestionCapitalized => "Şifreni veya Kullanıcı Adını mı unuttun?";

	/// <summary>
	/// Key: "Action.Login"
	/// English String: "Login"
	/// </summary>
	public override string ActionLogin => "Giriş Yap";

	/// <summary>
	/// Key: "Action.LogInCapitalized"
	/// login button label. please note this is different from 'Login' or 'Log in'.
	/// English String: "Log In"
	/// </summary>
	public override string ActionLogInCapitalized => "Giriş Yap";

	/// <summary>
	/// Key: "Action.Ok"
	/// button text
	/// English String: "OK"
	/// </summary>
	public override string ActionOk => "TAMAM";

	/// <summary>
	/// Key: "Action.PlayAsGuest"
	/// Play as Guest
	/// English String: "Play as Guest"
	/// </summary>
	public override string ActionPlayAsGuest => "Misafir olarak oyna";

	/// <summary>
	/// Key: "Action.Resend"
	/// button text for resending verification email
	/// English String: "Resend"
	/// </summary>
	public override string ActionResend => "Tekrar Gönder";

	/// <summary>
	/// Key: "Action.ResendEmail"
	/// link that resends verification email to user
	/// English String: "Resend Email"
	/// </summary>
	public override string ActionResendEmail => "Tekrar E-posta Gönder";

	/// <summary>
	/// Key: "Action.SendVerificationEmail"
	/// button user can click to send a verification link to their email
	/// English String: "Send Verification Email"
	/// </summary>
	public override string ActionSendVerificationEmail => "Doğrulama E-postası Gönder";

	/// <summary>
	/// Key: "Action.SignIn"
	/// Sign In button text
	/// English String: "Sign In"
	/// </summary>
	public override string ActionSignIn => "Giriş Yap";

	/// <summary>
	/// Key: "Action.SignInWithFacebook"
	/// Sign In with Facebook
	/// English String: "Sign In with Facebook"
	/// </summary>
	public override string ActionSignInWithFacebook => "Facebook ile Giriş Yap";

	/// <summary>
	/// Key: "Action.SignUp"
	/// English String: "Sign up"
	/// </summary>
	public override string ActionSignUp => "Kayıt ol";

	/// <summary>
	/// Key: "Action.SignUpCapitalized"
	/// link which takes user to sign up page
	/// English String: "Sign Up"
	/// </summary>
	public override string ActionSignUpCapitalized => "Kaydol";

	/// <summary>
	/// Key: "Action.WeChatLogin"
	/// button text for logging in with WeChat
	/// English String: "WeChat Login"
	/// </summary>
	public override string ActionWeChatLogin => "WeChat Girişi";

	/// <summary>
	/// Key: "Heading.Login"
	/// heading on the login page
	/// English String: "Login"
	/// </summary>
	public override string HeadingLogin => "Giriş Yap";

	/// <summary>
	/// Key: "Heading.LoginRoblox"
	/// current login page heading
	/// English String: "Login to Roblox"
	/// </summary>
	public override string HeadingLoginRoblox => "Roblox'a Giriş Yap";

	public override string HeadingSignUpMakeFriends => "İnşa Etmek ve Arkadaşlarla Tanışmak için Kayıt Ol";

	/// <summary>
	/// Key: "Label.AccountNotNeeded"
	/// You don't need an account to play Roblox
	/// English String: "You don't need an account to play Roblox"
	/// </summary>
	public override string LabelAccountNotNeeded => "Roblox oynamak için bir hesaba ihtiyacın yok";

	/// <summary>
	/// Key: "Label.EmailNeedsVerification"
	/// modal header used for prompting user they need to verify their email in order to log in with it
	/// English String: "Your email needs verification"
	/// </summary>
	public override string LabelEmailNeedsVerification => "E-posta'nın doğrulanması gerekiyor";

	/// <summary>
	/// Key: "Label.FacebookCreatePasswordWarning"
	/// If you have been signing in with Facebook, you must set a password.
	/// English String: "If you have been signing in with Facebook, you must set a password."
	/// </summary>
	public override string LabelFacebookCreatePasswordWarning => "Eğer şimdiye kadar Facebook ile giriş yaptıysan bir şifre seçmelisin.";

	/// <summary>
	/// Key: "Label.ForgotUsernamePassword"
	/// landing page top right link for password reset
	/// English String: "Forgot Username/Password?"
	/// </summary>
	public override string LabelForgotUsernamePassword => "Kullanıcı Adı/Şifreni Mi Unuttun?";

	/// <summary>
	/// Key: "Label.LearnMore"
	/// learn more link text
	/// English String: "Learn more"
	/// </summary>
	public override string LabelLearnMore => "Daha fazlasını öğren";

	/// <summary>
	/// Key: "Label.LoggingInSpinnerText"
	/// English String: "Logging in…"
	/// </summary>
	public override string LabelLoggingInSpinnerText => "Giriş yapılıyor...";

	/// <summary>
	/// Key: "Label.Login"
	/// English String: "Log in"
	/// </summary>
	public override string LabelLogin => "Giriş yap";

	/// <summary>
	/// Key: "Label.LoginWithYour"
	/// Label for a partition line between login with email and facebook login. Please keep the text in lowercase for roman characters.
	/// English String: "login with your"
	/// </summary>
	public override string LabelLoginWithYour => "Şununla giriş yap:";

	/// <summary>
	/// Key: "Label.NoAccount"
	/// Don't have an account?
	/// English String: "Don't have an account?"
	/// </summary>
	public override string LabelNoAccount => "Hesabın yok mu?";

	/// <summary>
	/// Key: "Label.NonAMemberQuestion"
	/// The question heading for the section on the login page to take use to sign up page.
	/// English String: "Not a member?"
	/// </summary>
	public override string LabelNonAMemberQuestion => "Üye değil misin?";

	/// <summary>
	/// Key: "Label.NotReceived"
	/// prompt for allowing users to resend verification email
	/// English String: "Didn't receive it?"
	/// </summary>
	public override string LabelNotReceived => "E-postayı almadın mı?";

	/// <summary>
	/// Key: "Label.Or"
	/// partition between email login and facebook login
	/// English String: "Or"
	/// </summary>
	public override string LabelOr => "Veya";

	/// <summary>
	/// Key: "Label.Password"
	/// Password
	/// English String: "Password"
	/// </summary>
	public override string LabelPassword => "Şifre";

	/// <summary>
	/// Key: "Label.PasswordWithColumn"
	/// label for the password field on the login page
	/// English String: "Password:"
	/// </summary>
	public override string LabelPasswordWithColumn => "Şifre:";

	/// <summary>
	/// Key: "Label.StartPlaying"
	/// You can start playing right now, in guest mode!
	/// English String: "You can start playing right now, in guest mode!"
	/// </summary>
	public override string LabelStartPlaying => "Misafir modunda hemen oynamaya başlayabilirsin!";

	/// <summary>
	/// Key: "Label.UnverifiedEmailInstructions"
	/// message shown in a modal when user logs in with unverified email
	/// English String: "To log in with your email, it must be verified. You can also log in with your username."
	/// </summary>
	public override string LabelUnverifiedEmailInstructions => "E-posta adresinle giriş yapmak için adresinin doğrulanması gerekli. Ayrıca kullanıcı adınla da giriş yapabilirsin.";

	/// <summary>
	/// Key: "Label.Username"
	/// English String: "Username"
	/// </summary>
	public override string LabelUsername => "Kullanıcı Adı";

	/// <summary>
	/// Key: "Label.UsernameEmail"
	/// placeholder text for input field that accepts username or email
	/// English String: "Username/Email"
	/// </summary>
	public override string LabelUsernameEmail => "Kullanıcı Adı/E-posta";

	/// <summary>
	/// Key: "Label.UsernameEmailPhone"
	/// placeholder text for input fields that accept username, email or phone
	/// English String: "Username/Email/Phone"
	/// </summary>
	public override string LabelUsernameEmailPhone => "Kullanıcı Adı/E-posta/Telefon";

	/// <summary>
	/// Key: "Label.UsernamePhone"
	/// placeholder text for input field that accepts username or phone
	/// English String: "Username/Phone"
	/// </summary>
	public override string LabelUsernamePhone => "Kullanıcı Adı/Telefon";

	/// <summary>
	/// Key: "Label.UsernameWithColumn"
	/// label for username field on login page
	/// English String: "Username:"
	/// </summary>
	public override string LabelUsernameWithColumn => "Kullanıcı Adı:";

	/// <summary>
	/// Key: "Label.VerificationEmailSent"
	/// message telling user a verification email was sent to them
	/// English String: "Verification Email Sent!"
	/// </summary>
	public override string LabelVerificationEmailSent => "Doğrulama E-postası Gönderildi!";

	/// <summary>
	/// Key: "Label.WeChatAntiAddictionText"
	/// English String: "Boycott bad games, refuse pirated games. Be aware of self-defense and being deceived. Playing games is good for your brain, but too much game play can harm your health. Manage your time well and enjoy a healthy lifestyle."
	/// </summary>
	public override string LabelWeChatAntiAddictionText => "Kötü oyunları boykot et, korsan oyunları reddet. Kendini savunmanın ve aldatılmanın farkında ol. Oyun oynamak beynin için iyidir ancak çok fazla oyun, sağlığına zarar verebilir. Vaktini iyi yönet ve sağlıklı bir yaşam tarzının tadını çıkar.";

	/// <summary>
	/// Key: "Message.UnknownErrorTryAgain"
	/// An unknown error occurred. Please try again.
	/// English String: "An unknown error occurred. Please try again."
	/// </summary>
	public override string MessageUnknownErrorTryAgain => "Bilinmeyen bir hata meydana geldi. Lütfen tekrar dene.";

	/// <summary>
	/// Key: "Message.UsernameAndPasswordRequired"
	/// message shown to user when they attempt to login without entering a username or password
	/// English String: "Username and password required"
	/// </summary>
	public override string MessageUsernameAndPasswordRequired => "Kullanıcı adı ve şifre gerekli";

	/// <summary>
	/// Key: "Response.AccountIssueErrorContactSupport"
	/// English String: "Account issue. Please contact Support."
	/// </summary>
	public override string ResponseAccountIssueErrorContactSupport => "Hesap sorunu. Lütfen destek ile iletişime geç.";

	/// <summary>
	/// Key: "Response.AccountLockedRequestReset"
	/// Account has been locked. Please request a password reset.
	/// English String: "Account has been locked. Please request a password reset."
	/// </summary>
	public override string ResponseAccountLockedRequestReset => "Hesap engellendi. Lütfen bir şifre sıfırlama talep et.";

	/// <summary>
	/// Key: "Response.AccountNotFound"
	/// Account not found. Please try again.
	/// English String: "Account not found. Please try again."
	/// </summary>
	public override string ResponseAccountNotFound => "Hesap bulunamadı. Lütfen tekrar dene.";

	/// <summary>
	/// Key: "Response.EmailLinkedToMultipleAccountsLoginWithUsername"
	/// error message displayed when user attempts to log in with an email that is linked to multiple accounts
	/// English String: "Your email is associated with more than 1 username. Please login with your username."
	/// </summary>
	public override string ResponseEmailLinkedToMultipleAccountsLoginWithUsername => "E-postan 1'den fazla kullanıcı adıyla ilişkili. Lütfen kullanıcı adınla giriş yap.";

	/// <summary>
	/// Key: "Response.EmailSent"
	/// response telling user that a verification email has been sent to them
	/// English String: "Email sent!"
	/// </summary>
	public override string ResponseEmailSent => "E-posta gönderildi!";

	/// <summary>
	/// Key: "Response.IncorrectEmailOrPassword"
	/// error message displayed when user logs in with an invalid email or password
	/// English String: "Incorrect email or password."
	/// </summary>
	public override string ResponseIncorrectEmailOrPassword => "Hatalı e-posta veya şifre.";

	/// <summary>
	/// Key: "Response.IncorrectPhoneOrPassword"
	/// error message displayed when user logs in with an invalid phone or password
	/// English String: "Incorrect phone or password."
	/// </summary>
	public override string ResponseIncorrectPhoneOrPassword => "Hatalı telefon veya şifre.";

	/// <summary>
	/// Key: "Response.IncorrectUsernamePassword"
	/// English String: "Incorrect username or password."
	/// </summary>
	public override string ResponseIncorrectUsernamePassword => "Kullanıcı adı veya şifre geçersiz.";

	/// <summary>
	/// Key: "Response.LoginWithUsername"
	/// error message shown when user attempts to login with method other than username and an error occurred
	/// English String: "Something went wrong. Please login with your username."
	/// </summary>
	public override string ResponseLoginWithUsername => "Bir şeyler yanlış gitti. Lütfen kullanıcı adınla giriş yap.";

	/// <summary>
	/// Key: "Response.PasswordNotProvided"
	/// password field is empty
	/// English String: "You must enter a password."
	/// </summary>
	public override string ResponsePasswordNotProvided => "Bir şifre girmelisin.";

	/// <summary>
	/// Key: "Response.TooManyAttemptsPleaseWait"
	/// English String: "Too many attempts. Please wait a bit."
	/// </summary>
	public override string ResponseTooManyAttemptsPleaseWait => "Çok sayıda deneme. Lütfen biraz bekle.";

	/// <summary>
	/// Key: "Response.UnknownError"
	/// English String: "Unknown Error"
	/// </summary>
	public override string ResponseUnknownError => "Bilinmeyen Hata";

	/// <summary>
	/// Key: "Response.UnknownLoginError"
	/// Unknown login failure.
	/// English String: "Unknown login failure."
	/// </summary>
	public override string ResponseUnknownLoginError => "Bilinmeyen giriş hatası.";

	/// <summary>
	/// Key: "Response.UnverifiedEmailLoginWithUsername"
	/// error message shown when user attempts to login with unverified email
	/// English String: "Your email is not verified. Please login with your username."
	/// </summary>
	public override string ResponseUnverifiedEmailLoginWithUsername => "E-postan doğrulanmadı. Lütfen kullanıcı adınla giriş yap.";

	/// <summary>
	/// Key: "Response.UnverifiedPhoneLoginWithUsername"
	/// error message shown when user attempts to login with an unverified phone number
	/// English String: "Your phone is not verified. Please login with your username."
	/// </summary>
	public override string ResponseUnverifiedPhoneLoginWithUsername => "Telefonun doğrulanmadı. Lütfen kullanıcı adınla giriş yap.";

	/// <summary>
	/// Key: "Response.UsernameNotProvided"
	/// username field is empty
	/// English String: "You must enter a username."
	/// </summary>
	public override string ResponseUsernameNotProvided => "Bir kullanıcı adı girmelisin.";

	/// <summary>
	/// Key: "Response.UseSocialSignOn"
	/// Unable to login. Please use Social Network sign on.
	/// English String: "Unable to login. Please use Social Network sign on."
	/// </summary>
	public override string ResponseUseSocialSignOn => "Giriş yapılamıyor. Lütfen Sosyal Ağ girişini kullan.";

	/// <summary>
	/// Key: "WeChat.AntiAddictionText"
	/// English String: "Boycott bad games, refuse pirated games. Be aware of self-defense and being deceived. Playing games is good for your brain, but too much game play can harm your health. Manage your time well and enjoy a healthy lifestyle."
	/// </summary>
	public override string WeChatAntiAddictionText => "Kötü oyunları boykot et, korsan oyunları reddet. Kendini savunmanın ve aldatılmanın farkında ol. Oyun oynamak beynin için iyidir ancak çok fazla oyun, sağlığına zarar verebilir. Vaktini iyi yönet ve sağlıklı bir yaşam tarzının tadını çıkar.";

	/// <summary>
	/// Key: "WeChat.RealNameNotVerified"
	/// English String: "Your WeChat is not real-name verified. Please use a real-name verified WeChat account and try again. Please visit https://jiazhang.qq.com/zk/home.html"
	/// </summary>
	public override string WeChatRealNameNotVerified => "WeChat'in gerçek isimle doğrulanmış değil. Lütfen gerçek isimle doğrulanmış bir WeChat hesabı gir ve tekrar dene. Lütfen https://jiazhang.qq.com/zk/home.html adresini ziyaret et";

	public LoginResources_tr_tr(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionCancel()
	{
		return "İptal Et";
	}

	protected override string _GetTemplateForActionFacebook()
	{
		return "Facebook";
	}

	protected override string _GetTemplateForActionForgotPasswordOrUsernameQuestion()
	{
		return "Kullanıcı adını veya şifreni mi unuttun?";
	}

	protected override string _GetTemplateForActionForgotPasswordOrUsernameQuestionCapitalized()
	{
		return "Şifreni veya Kullanıcı Adını mı unuttun?";
	}

	protected override string _GetTemplateForActionLogin()
	{
		return "Giriş Yap";
	}

	protected override string _GetTemplateForActionLogInCapitalized()
	{
		return "Giriş Yap";
	}

	protected override string _GetTemplateForActionOk()
	{
		return "TAMAM";
	}

	protected override string _GetTemplateForActionPlayAsGuest()
	{
		return "Misafir olarak oyna";
	}

	protected override string _GetTemplateForActionResend()
	{
		return "Tekrar Gönder";
	}

	protected override string _GetTemplateForActionResendEmail()
	{
		return "Tekrar E-posta Gönder";
	}

	protected override string _GetTemplateForActionSendVerificationEmail()
	{
		return "Doğrulama E-postası Gönder";
	}

	protected override string _GetTemplateForActionSignIn()
	{
		return "Giriş Yap";
	}

	protected override string _GetTemplateForActionSignInWithFacebook()
	{
		return "Facebook ile Giriş Yap";
	}

	protected override string _GetTemplateForActionSignUp()
	{
		return "Kayıt ol";
	}

	protected override string _GetTemplateForActionSignUpCapitalized()
	{
		return "Kaydol";
	}

	protected override string _GetTemplateForActionWeChatLogin()
	{
		return "WeChat Girişi";
	}

	protected override string _GetTemplateForHeadingLogin()
	{
		return "Giriş Yap";
	}

	protected override string _GetTemplateForHeadingLoginRoblox()
	{
		return "Roblox'a Giriş Yap";
	}

	protected override string _GetTemplateForHeadingSignUpMakeFriends()
	{
		return "İnşa Etmek ve Arkadaşlarla Tanışmak için Kayıt Ol";
	}

	protected override string _GetTemplateForLabelAccountNotNeeded()
	{
		return "Roblox oynamak için bir hesaba ihtiyacın yok";
	}

	protected override string _GetTemplateForLabelEmailNeedsVerification()
	{
		return "E-posta'nın doğrulanması gerekiyor";
	}

	protected override string _GetTemplateForLabelFacebookCreatePasswordWarning()
	{
		return "Eğer şimdiye kadar Facebook ile giriş yaptıysan bir şifre seçmelisin.";
	}

	protected override string _GetTemplateForLabelForgotUsernamePassword()
	{
		return "Kullanıcı Adı/Şifreni Mi Unuttun?";
	}

	/// <summary>
	/// Key: "Label.GreetingForNewAccount"
	/// Shown when a username doesn't exist on the login page to invite to create a new account.
	/// English String: "Nice to meet you, {username}. {linkStartSignup}Let's make an account! {linkEndSignup}"
	/// </summary>
	public override string LabelGreetingForNewAccount(string username, string linkStartSignup, string linkEndSignup)
	{
		return $"Tanıştığımıza memnun olduk {username}. {linkStartSignup}Hadi bir hesap oluşturalım! {linkEndSignup}";
	}

	protected override string _GetTemplateForLabelGreetingForNewAccount()
	{
		return "Tanıştığımıza memnun olduk {username}. {linkStartSignup}Hadi bir hesap oluşturalım! {linkEndSignup}";
	}

	protected override string _GetTemplateForLabelLearnMore()
	{
		return "Daha fazlasını öğren";
	}

	protected override string _GetTemplateForLabelLoggingInSpinnerText()
	{
		return "Giriş yapılıyor...";
	}

	protected override string _GetTemplateForLabelLogin()
	{
		return "Giriş yap";
	}

	protected override string _GetTemplateForLabelLoginWithYour()
	{
		return "Şununla giriş yap:";
	}

	protected override string _GetTemplateForLabelNoAccount()
	{
		return "Hesabın yok mu?";
	}

	protected override string _GetTemplateForLabelNonAMemberQuestion()
	{
		return "Üye değil misin?";
	}

	protected override string _GetTemplateForLabelNotReceived()
	{
		return "E-postayı almadın mı?";
	}

	protected override string _GetTemplateForLabelOr()
	{
		return "Veya";
	}

	protected override string _GetTemplateForLabelPassword()
	{
		return "Şifre";
	}

	protected override string _GetTemplateForLabelPasswordWithColumn()
	{
		return "Şifre:";
	}

	protected override string _GetTemplateForLabelStartPlaying()
	{
		return "Misafir modunda hemen oynamaya başlayabilirsin!";
	}

	protected override string _GetTemplateForLabelUnverifiedEmailInstructions()
	{
		return "E-posta adresinle giriş yapmak için adresinin doğrulanması gerekli. Ayrıca kullanıcı adınla da giriş yapabilirsin.";
	}

	protected override string _GetTemplateForLabelUsername()
	{
		return "Kullanıcı Adı";
	}

	protected override string _GetTemplateForLabelUsernameEmail()
	{
		return "Kullanıcı Adı/E-posta";
	}

	protected override string _GetTemplateForLabelUsernameEmailPhone()
	{
		return "Kullanıcı Adı/E-posta/Telefon";
	}

	protected override string _GetTemplateForLabelUsernamePhone()
	{
		return "Kullanıcı Adı/Telefon";
	}

	protected override string _GetTemplateForLabelUsernameWithColumn()
	{
		return "Kullanıcı Adı:";
	}

	protected override string _GetTemplateForLabelVerificationEmailSent()
	{
		return "Doğrulama E-postası Gönderildi!";
	}

	protected override string _GetTemplateForLabelWeChatAntiAddictionText()
	{
		return "Kötü oyunları boykot et, korsan oyunları reddet. Kendini savunmanın ve aldatılmanın farkında ol. Oyun oynamak beynin için iyidir ancak çok fazla oyun, sağlığına zarar verebilir. Vaktini iyi yönet ve sağlıklı bir yaşam tarzının tadını çıkar.";
	}

	protected override string _GetTemplateForMessageUnknownErrorTryAgain()
	{
		return "Bilinmeyen bir hata meydana geldi. Lütfen tekrar dene.";
	}

	protected override string _GetTemplateForMessageUsernameAndPasswordRequired()
	{
		return "Kullanıcı adı ve şifre gerekli";
	}

	protected override string _GetTemplateForResponseAccountIssueErrorContactSupport()
	{
		return "Hesap sorunu. Lütfen destek ile iletişime geç.";
	}

	protected override string _GetTemplateForResponseAccountLockedRequestReset()
	{
		return "Hesap engellendi. Lütfen bir şifre sıfırlama talep et.";
	}

	protected override string _GetTemplateForResponseAccountNotFound()
	{
		return "Hesap bulunamadı. Lütfen tekrar dene.";
	}

	protected override string _GetTemplateForResponseEmailLinkedToMultipleAccountsLoginWithUsername()
	{
		return "E-postan 1'den fazla kullanıcı adıyla ilişkili. Lütfen kullanıcı adınla giriş yap.";
	}

	protected override string _GetTemplateForResponseEmailSent()
	{
		return "E-posta gönderildi!";
	}

	protected override string _GetTemplateForResponseIncorrectEmailOrPassword()
	{
		return "Hatalı e-posta veya şifre.";
	}

	protected override string _GetTemplateForResponseIncorrectPhoneOrPassword()
	{
		return "Hatalı telefon veya şifre.";
	}

	protected override string _GetTemplateForResponseIncorrectUsernamePassword()
	{
		return "Kullanıcı adı veya şifre geçersiz.";
	}

	protected override string _GetTemplateForResponseLoginWithUsername()
	{
		return "Bir şeyler yanlış gitti. Lütfen kullanıcı adınla giriş yap.";
	}

	protected override string _GetTemplateForResponsePasswordNotProvided()
	{
		return "Bir şifre girmelisin.";
	}

	protected override string _GetTemplateForResponseTooManyAttemptsPleaseWait()
	{
		return "Çok sayıda deneme. Lütfen biraz bekle.";
	}

	protected override string _GetTemplateForResponseUnknownError()
	{
		return "Bilinmeyen Hata";
	}

	protected override string _GetTemplateForResponseUnknownLoginError()
	{
		return "Bilinmeyen giriş hatası.";
	}

	protected override string _GetTemplateForResponseUnverifiedEmailLoginWithUsername()
	{
		return "E-postan doğrulanmadı. Lütfen kullanıcı adınla giriş yap.";
	}

	protected override string _GetTemplateForResponseUnverifiedPhoneLoginWithUsername()
	{
		return "Telefonun doğrulanmadı. Lütfen kullanıcı adınla giriş yap.";
	}

	protected override string _GetTemplateForResponseUsernameNotProvided()
	{
		return "Bir kullanıcı adı girmelisin.";
	}

	protected override string _GetTemplateForResponseUseSocialSignOn()
	{
		return "Giriş yapılamıyor. Lütfen Sosyal Ağ girişini kullan.";
	}

	/// <summary>
	/// Key: "Response.WeChatNotRealNameVerified"
	/// English String: "Your WeChat is not real-name verified. Please use a real-name verified WeChat account and try again. Please visit {url}"
	/// </summary>
	public override string ResponseWeChatNotRealNameVerified(string url)
	{
		return $"WeChat'in gerçek isimle doğrulanmış değil. Lütfen gerçek isimle doğrulanmış bir WeChat hesabı gir ve tekrar dene. Lütfen {url} adresini ziyaret et.";
	}

	protected override string _GetTemplateForResponseWeChatNotRealNameVerified()
	{
		return "WeChat'in gerçek isimle doğrulanmış değil. Lütfen gerçek isimle doğrulanmış bir WeChat hesabı gir ve tekrar dene. Lütfen {url} adresini ziyaret et.";
	}

	protected override string _GetTemplateForWeChatAntiAddictionText()
	{
		return "Kötü oyunları boykot et, korsan oyunları reddet. Kendini savunmanın ve aldatılmanın farkında ol. Oyun oynamak beynin için iyidir ancak çok fazla oyun, sağlığına zarar verebilir. Vaktini iyi yönet ve sağlıklı bir yaşam tarzının tadını çıkar.";
	}

	protected override string _GetTemplateForWeChatRealNameNotVerified()
	{
		return "WeChat'in gerçek isimle doğrulanmış değil. Lütfen gerçek isimle doğrulanmış bir WeChat hesabı gir ve tekrar dene. Lütfen https://jiazhang.qq.com/zk/home.html adresini ziyaret et";
	}
}
