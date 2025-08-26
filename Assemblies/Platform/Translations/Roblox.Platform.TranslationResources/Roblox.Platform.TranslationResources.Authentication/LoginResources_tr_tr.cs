namespace Roblox.Platform.TranslationResources.Authentication {
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
	public override string ActionCancel => "Ä°ptal Et";

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
	public override string ActionForgotPasswordOrUsernameQuestion => "KullanÄ±cÄ± adÄ±nÄ± veya ÅŸifreni mi unuttun?";

	/// <summary>
	/// Key: "Action.ForgotPasswordOrUsernameQuestionCapitalized"
	/// link under login form
	/// English String: "Forgot Password or Username?"
	/// </summary>
	public override string ActionForgotPasswordOrUsernameQuestionCapitalized => "Åžifreni veya KullanÄ±cÄ± AdÄ±nÄ± mÄ± unuttun?";

	/// <summary>
	/// Key: "Action.Login"
	/// English String: "Login"
	/// </summary>
	public override string ActionLogin => "GiriÅŸ Yap";

	/// <summary>
	/// Key: "Action.LogInCapitalized"
	/// login button label. please note this is different from 'Login' or 'Log in'.
	/// English String: "Log In"
	/// </summary>
	public override string ActionLogInCapitalized => "GiriÅŸ Yap";

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
	public override string ActionResend => "Tekrar GÃ¶nder";

	/// <summary>
	/// Key: "Action.ResendEmail"
	/// link that resends verification email to user
	/// English String: "Resend Email"
	/// </summary>
	public override string ActionResendEmail => "Tekrar E-posta GÃ¶nder";

	/// <summary>
	/// Key: "Action.SendVerificationEmail"
	/// button user can click to send a verification link to their email
	/// English String: "Send Verification Email"
	/// </summary>
	public override string ActionSendVerificationEmail => "DoÄŸrulama E-postasÄ± GÃ¶nder";

	/// <summary>
	/// Key: "Action.SignIn"
	/// Sign In button text
	/// English String: "Sign In"
	/// </summary>
	public override string ActionSignIn => "GiriÅŸ Yap";

	/// <summary>
	/// Key: "Action.SignInWithFacebook"
	/// Sign In with Facebook
	/// English String: "Sign In with Facebook"
	/// </summary>
	public override string ActionSignInWithFacebook => "Facebook ile GiriÅŸ Yap";

	/// <summary>
	/// Key: "Action.SignUp"
	/// English String: "Sign up"
	/// </summary>
	public override string ActionSignUp => "KayÄ±t ol";

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
	public override string ActionWeChatLogin => "WeChat GiriÅŸi";

	/// <summary>
	/// Key: "Heading.Login"
	/// heading on the login page
	/// English String: "Login"
	/// </summary>
	public override string HeadingLogin => "GiriÅŸ Yap";

	/// <summary>
	/// Key: "Heading.LoginRoblox"
	/// current login page heading
	/// English String: "Login to Roblox"
	/// </summary>
	public override string HeadingLoginRoblox => "Roblox'a GiriÅŸ Yap";

	public override string HeadingSignUpMakeFriends => "Ä°nÅŸa Etmek ve ArkadaÅŸlarla TanÄ±ÅŸmak iÃ§in KayÄ±t Ol";

	/// <summary>
	/// Key: "Label.AccountNotNeeded"
	/// You don't need an account to play Roblox
	/// English String: "You don't need an account to play Roblox"
	/// </summary>
	public override string LabelAccountNotNeeded => "Roblox oynamak iÃ§in bir hesaba ihtiyacÄ±n yok";

	/// <summary>
	/// Key: "Label.EmailNeedsVerification"
	/// modal header used for prompting user they need to verify their email in order to log in with it
	/// English String: "Your email needs verification"
	/// </summary>
	public override string LabelEmailNeedsVerification => "E-posta'nÄ±n doÄŸrulanmasÄ± gerekiyor";

	/// <summary>
	/// Key: "Label.FacebookCreatePasswordWarning"
	/// If you have been signing in with Facebook, you must set a password.
	/// English String: "If you have been signing in with Facebook, you must set a password."
	/// </summary>
	public override string LabelFacebookCreatePasswordWarning => "EÄŸer ÅŸimdiye kadar Facebook ile giriÅŸ yaptÄ±ysan bir ÅŸifre seÃ§melisin.";

	/// <summary>
	/// Key: "Label.ForgotUsernamePassword"
	/// landing page top right link for password reset
	/// English String: "Forgot Username/Password?"
	/// </summary>
	public override string LabelForgotUsernamePassword => "KullanÄ±cÄ± AdÄ±/Åžifreni Mi Unuttun?";

	/// <summary>
	/// Key: "Label.LearnMore"
	/// learn more link text
	/// English String: "Learn more"
	/// </summary>
	public override string LabelLearnMore => "Daha fazlasÄ±nÄ± Ã¶ÄŸren";

	/// <summary>
	/// Key: "Label.LoggingInSpinnerText"
	/// English String: "Logging inâ€¦"
	/// </summary>
	public override string LabelLoggingInSpinnerText => "GiriÅŸ yapÄ±lÄ±yor...";

	/// <summary>
	/// Key: "Label.Login"
	/// English String: "Log in"
	/// </summary>
	public override string LabelLogin => "GiriÅŸ yap";

	/// <summary>
	/// Key: "Label.LoginWithYour"
	/// Label for a partition line between login with email and facebook login. Please keep the text in lowercase for roman characters.
	/// English String: "login with your"
	/// </summary>
	public override string LabelLoginWithYour => "Åžununla giriÅŸ yap:";

	/// <summary>
	/// Key: "Label.NoAccount"
	/// Don't have an account?
	/// English String: "Don't have an account?"
	/// </summary>
	public override string LabelNoAccount => "HesabÄ±n yok mu?";

	/// <summary>
	/// Key: "Label.NonAMemberQuestion"
	/// The question heading for the section on the login page to take use to sign up page.
	/// English String: "Not a member?"
	/// </summary>
	public override string LabelNonAMemberQuestion => "Ãœye deÄŸil misin?";

	/// <summary>
	/// Key: "Label.NotReceived"
	/// prompt for allowing users to resend verification email
	/// English String: "Didn't receive it?"
	/// </summary>
	public override string LabelNotReceived => "E-postayÄ± almadÄ±n mÄ±?";

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
	public override string LabelPassword => "Åžifre";

	/// <summary>
	/// Key: "Label.PasswordWithColumn"
	/// label for the password field on the login page
	/// English String: "Password:"
	/// </summary>
	public override string LabelPasswordWithColumn => "Åžifre:";

	/// <summary>
	/// Key: "Label.StartPlaying"
	/// You can start playing right now, in guest mode!
	/// English String: "You can start playing right now, in guest mode!"
	/// </summary>
	public override string LabelStartPlaying => "Misafir modunda hemen oynamaya baÅŸlayabilirsin!";

	/// <summary>
	/// Key: "Label.UnverifiedEmailInstructions"
	/// message shown in a modal when user logs in with unverified email
	/// English String: "To log in with your email, it must be verified. You can also log in with your username."
	/// </summary>
	public override string LabelUnverifiedEmailInstructions => "E-posta adresinle giriÅŸ yapmak iÃ§in adresinin doÄŸrulanmasÄ± gerekli. AyrÄ±ca kullanÄ±cÄ± adÄ±nla da giriÅŸ yapabilirsin.";

	/// <summary>
	/// Key: "Label.Username"
	/// English String: "Username"
	/// </summary>
	public override string LabelUsername => "KullanÄ±cÄ± AdÄ±";

	/// <summary>
	/// Key: "Label.UsernameEmail"
	/// placeholder text for input field that accepts username or email
	/// English String: "Username/Email"
	/// </summary>
	public override string LabelUsernameEmail => "KullanÄ±cÄ± AdÄ±/E-posta";

	/// <summary>
	/// Key: "Label.UsernameEmailPhone"
	/// placeholder text for input fields that accept username, email or phone
	/// English String: "Username/Email/Phone"
	/// </summary>
	public override string LabelUsernameEmailPhone => "KullanÄ±cÄ± AdÄ±/E-posta/Telefon";

	/// <summary>
	/// Key: "Label.UsernamePhone"
	/// placeholder text for input field that accepts username or phone
	/// English String: "Username/Phone"
	/// </summary>
	public override string LabelUsernamePhone => "KullanÄ±cÄ± AdÄ±/Telefon";

	/// <summary>
	/// Key: "Label.UsernameWithColumn"
	/// label for username field on login page
	/// English String: "Username:"
	/// </summary>
	public override string LabelUsernameWithColumn => "KullanÄ±cÄ± AdÄ±:";

	/// <summary>
	/// Key: "Label.VerificationEmailSent"
	/// message telling user a verification email was sent to them
	/// English String: "Verification Email Sent!"
	/// </summary>
	public override string LabelVerificationEmailSent => "DoÄŸrulama E-postasÄ± GÃ¶nderildi!";

	/// <summary>
	/// Key: "Label.WeChatAntiAddictionText"
	/// English String: "Boycott bad games, refuse pirated games. Be aware of self-defense and being deceived. Playing games is good for your brain, but too much game play can harm your health. Manage your time well and enjoy a healthy lifestyle."
	/// </summary>
	public override string LabelWeChatAntiAddictionText => "KÃ¶tÃ¼ oyunlarÄ± boykot et, korsan oyunlarÄ± reddet. Kendini savunmanÄ±n ve aldatÄ±lmanÄ±n farkÄ±nda ol. Oyun oynamak beynin iÃ§in iyidir ancak Ã§ok fazla oyun, saÄŸlÄ±ÄŸÄ±na zarar verebilir. Vaktini iyi yÃ¶net ve saÄŸlÄ±klÄ± bir yaÅŸam tarzÄ±nÄ±n tadÄ±nÄ± Ã§Ä±kar.";

	/// <summary>
	/// Key: "Message.UnknownErrorTryAgain"
	/// An unknown error occurred. Please try again.
	/// English String: "An unknown error occurred. Please try again."
	/// </summary>
	public override string MessageUnknownErrorTryAgain => "Bilinmeyen bir hata meydana geldi. LÃ¼tfen tekrar dene.";

	/// <summary>
	/// Key: "Message.UsernameAndPasswordRequired"
	/// message shown to user when they attempt to login without entering a username or password
	/// English String: "Username and password required"
	/// </summary>
	public override string MessageUsernameAndPasswordRequired => "KullanÄ±cÄ± adÄ± ve ÅŸifre gerekli";

	/// <summary>
	/// Key: "Response.AccountIssueErrorContactSupport"
	/// English String: "Account issue. Please contact Support."
	/// </summary>
	public override string ResponseAccountIssueErrorContactSupport => "Hesap sorunu. LÃ¼tfen destek ile iletiÅŸime geÃ§.";

	/// <summary>
	/// Key: "Response.AccountLockedRequestReset"
	/// Account has been locked. Please request a password reset.
	/// English String: "Account has been locked. Please request a password reset."
	/// </summary>
	public override string ResponseAccountLockedRequestReset => "Hesap engellendi. LÃ¼tfen bir ÅŸifre sÄ±fÄ±rlama talep et.";

	/// <summary>
	/// Key: "Response.AccountNotFound"
	/// Account not found. Please try again.
	/// English String: "Account not found. Please try again."
	/// </summary>
	public override string ResponseAccountNotFound => "Hesap bulunamadÄ±. LÃ¼tfen tekrar dene.";

	/// <summary>
	/// Key: "Response.EmailLinkedToMultipleAccountsLoginWithUsername"
	/// error message displayed when user attempts to log in with an email that is linked to multiple accounts
	/// English String: "Your email is associated with more than 1 username. Please login with your username."
	/// </summary>
	public override string ResponseEmailLinkedToMultipleAccountsLoginWithUsername => "E-postan 1'den fazla kullanÄ±cÄ± adÄ±yla iliÅŸkili. LÃ¼tfen kullanÄ±cÄ± adÄ±nla giriÅŸ yap.";

	/// <summary>
	/// Key: "Response.EmailSent"
	/// response telling user that a verification email has been sent to them
	/// English String: "Email sent!"
	/// </summary>
	public override string ResponseEmailSent => "E-posta gÃ¶nderildi!";

	/// <summary>
	/// Key: "Response.IncorrectEmailOrPassword"
	/// error message displayed when user logs in with an invalid email or password
	/// English String: "Incorrect email or password."
	/// </summary>
	public override string ResponseIncorrectEmailOrPassword => "HatalÄ± e-posta veya ÅŸifre.";

	/// <summary>
	/// Key: "Response.IncorrectPhoneOrPassword"
	/// error message displayed when user logs in with an invalid phone or password
	/// English String: "Incorrect phone or password."
	/// </summary>
	public override string ResponseIncorrectPhoneOrPassword => "HatalÄ± telefon veya ÅŸifre.";

	/// <summary>
	/// Key: "Response.IncorrectUsernamePassword"
	/// English String: "Incorrect username or password."
	/// </summary>
	public override string ResponseIncorrectUsernamePassword => "KullanÄ±cÄ± adÄ± veya ÅŸifre geÃ§ersiz.";

	/// <summary>
	/// Key: "Response.LoginWithUsername"
	/// error message shown when user attempts to login with method other than username and an error occurred
	/// English String: "Something went wrong. Please login with your username."
	/// </summary>
	public override string ResponseLoginWithUsername => "Bir ÅŸeyler yanlÄ±ÅŸ gitti. LÃ¼tfen kullanÄ±cÄ± adÄ±nla giriÅŸ yap.";

	/// <summary>
	/// Key: "Response.PasswordNotProvided"
	/// password field is empty
	/// English String: "You must enter a password."
	/// </summary>
	public override string ResponsePasswordNotProvided => "Bir ÅŸifre girmelisin.";

	/// <summary>
	/// Key: "Response.TooManyAttemptsPleaseWait"
	/// English String: "Too many attempts. Please wait a bit."
	/// </summary>
	public override string ResponseTooManyAttemptsPleaseWait => "Ã‡ok sayÄ±da deneme. LÃ¼tfen biraz bekle.";

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
	public override string ResponseUnknownLoginError => "Bilinmeyen giriÅŸ hatasÄ±.";

	/// <summary>
	/// Key: "Response.UnverifiedEmailLoginWithUsername"
	/// error message shown when user attempts to login with unverified email
	/// English String: "Your email is not verified. Please login with your username."
	/// </summary>
	public override string ResponseUnverifiedEmailLoginWithUsername => "E-postan doÄŸrulanmadÄ±. LÃ¼tfen kullanÄ±cÄ± adÄ±nla giriÅŸ yap.";

	/// <summary>
	/// Key: "Response.UnverifiedPhoneLoginWithUsername"
	/// error message shown when user attempts to login with an unverified phone number
	/// English String: "Your phone is not verified. Please login with your username."
	/// </summary>
	public override string ResponseUnverifiedPhoneLoginWithUsername => "Telefonun doÄŸrulanmadÄ±. LÃ¼tfen kullanÄ±cÄ± adÄ±nla giriÅŸ yap.";

	/// <summary>
	/// Key: "Response.UsernameNotProvided"
	/// username field is empty
	/// English String: "You must enter a username."
	/// </summary>
	public override string ResponseUsernameNotProvided => "Bir kullanÄ±cÄ± adÄ± girmelisin.";

	/// <summary>
	/// Key: "Response.UseSocialSignOn"
	/// Unable to login. Please use Social Network sign on.
	/// English String: "Unable to login. Please use Social Network sign on."
	/// </summary>
	public override string ResponseUseSocialSignOn => "GiriÅŸ yapÄ±lamÄ±yor. LÃ¼tfen Sosyal AÄŸ giriÅŸini kullan.";

	/// <summary>
	/// Key: "WeChat.AntiAddictionText"
	/// English String: "Boycott bad games, refuse pirated games. Be aware of self-defense and being deceived. Playing games is good for your brain, but too much game play can harm your health. Manage your time well and enjoy a healthy lifestyle."
	/// </summary>
	public override string WeChatAntiAddictionText => "KÃ¶tÃ¼ oyunlarÄ± boykot et, korsan oyunlarÄ± reddet. Kendini savunmanÄ±n ve aldatÄ±lmanÄ±n farkÄ±nda ol. Oyun oynamak beynin iÃ§in iyidir ancak Ã§ok fazla oyun, saÄŸlÄ±ÄŸÄ±na zarar verebilir. Vaktini iyi yÃ¶net ve saÄŸlÄ±klÄ± bir yaÅŸam tarzÄ±nÄ±n tadÄ±nÄ± Ã§Ä±kar.";

	/// <summary>
	/// Key: "WeChat.RealNameNotVerified"
	/// English String: "Your WeChat is not real-name verified. Please use a real-name verified WeChat account and try again. Please visit https://jiazhang.qq.com/zk/home.html"
	/// </summary>
	public override string WeChatRealNameNotVerified => "WeChat'in gerÃ§ek isimle doÄŸrulanmÄ±ÅŸ deÄŸil. LÃ¼tfen gerÃ§ek isimle doÄŸrulanmÄ±ÅŸ bir WeChat hesabÄ± gir ve tekrar dene. LÃ¼tfen https://jiazhang.qq.com/zk/home.html adresini ziyaret et";

	public LoginResources_tr_tr(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionCancel()
	{
		return "Ä°ptal Et";
	}

	protected override string _GetTemplateForActionFacebook()
	{
		return "Facebook";
	}

	protected override string _GetTemplateForActionForgotPasswordOrUsernameQuestion()
	{
		return "KullanÄ±cÄ± adÄ±nÄ± veya ÅŸifreni mi unuttun?";
	}

	protected override string _GetTemplateForActionForgotPasswordOrUsernameQuestionCapitalized()
	{
		return "Åžifreni veya KullanÄ±cÄ± AdÄ±nÄ± mÄ± unuttun?";
	}

	protected override string _GetTemplateForActionLogin()
	{
		return "GiriÅŸ Yap";
	}

	protected override string _GetTemplateForActionLogInCapitalized()
	{
		return "GiriÅŸ Yap";
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
		return "Tekrar GÃ¶nder";
	}

	protected override string _GetTemplateForActionResendEmail()
	{
		return "Tekrar E-posta GÃ¶nder";
	}

	protected override string _GetTemplateForActionSendVerificationEmail()
	{
		return "DoÄŸrulama E-postasÄ± GÃ¶nder";
	}

	protected override string _GetTemplateForActionSignIn()
	{
		return "GiriÅŸ Yap";
	}

	protected override string _GetTemplateForActionSignInWithFacebook()
	{
		return "Facebook ile GiriÅŸ Yap";
	}

	protected override string _GetTemplateForActionSignUp()
	{
		return "KayÄ±t ol";
	}

	protected override string _GetTemplateForActionSignUpCapitalized()
	{
		return "Kaydol";
	}

	protected override string _GetTemplateForActionWeChatLogin()
	{
		return "WeChat GiriÅŸi";
	}

	protected override string _GetTemplateForHeadingLogin()
	{
		return "GiriÅŸ Yap";
	}

	protected override string _GetTemplateForHeadingLoginRoblox()
	{
		return "Roblox'a GiriÅŸ Yap";
	}

	protected override string _GetTemplateForHeadingSignUpMakeFriends()
	{
		return "Ä°nÅŸa Etmek ve ArkadaÅŸlarla TanÄ±ÅŸmak iÃ§in KayÄ±t Ol";
	}

	protected override string _GetTemplateForLabelAccountNotNeeded()
	{
		return "Roblox oynamak iÃ§in bir hesaba ihtiyacÄ±n yok";
	}

	protected override string _GetTemplateForLabelEmailNeedsVerification()
	{
		return "E-posta'nÄ±n doÄŸrulanmasÄ± gerekiyor";
	}

	protected override string _GetTemplateForLabelFacebookCreatePasswordWarning()
	{
		return "EÄŸer ÅŸimdiye kadar Facebook ile giriÅŸ yaptÄ±ysan bir ÅŸifre seÃ§melisin.";
	}

	protected override string _GetTemplateForLabelForgotUsernamePassword()
	{
		return "KullanÄ±cÄ± AdÄ±/Åžifreni Mi Unuttun?";
	}

	/// <summary>
	/// Key: "Label.GreetingForNewAccount"
	/// Shown when a username doesn't exist on the login page to invite to create a new account.
	/// English String: "Nice to meet you, {username}. {linkStartSignup}Let's make an account! {linkEndSignup}"
	/// </summary>
	public override string LabelGreetingForNewAccount(string username, string linkStartSignup, string linkEndSignup)
	{
		return $"TanÄ±ÅŸtÄ±ÄŸÄ±mÄ±za memnun olduk {username}. {linkStartSignup}Hadi bir hesap oluÅŸturalÄ±m! {linkEndSignup}";
	}

	protected override string _GetTemplateForLabelGreetingForNewAccount()
	{
		return "TanÄ±ÅŸtÄ±ÄŸÄ±mÄ±za memnun olduk {username}. {linkStartSignup}Hadi bir hesap oluÅŸturalÄ±m! {linkEndSignup}";
	}

	protected override string _GetTemplateForLabelLearnMore()
	{
		return "Daha fazlasÄ±nÄ± Ã¶ÄŸren";
	}

	protected override string _GetTemplateForLabelLoggingInSpinnerText()
	{
		return "GiriÅŸ yapÄ±lÄ±yor...";
	}

	protected override string _GetTemplateForLabelLogin()
	{
		return "GiriÅŸ yap";
	}

	protected override string _GetTemplateForLabelLoginWithYour()
	{
		return "Åžununla giriÅŸ yap:";
	}

	protected override string _GetTemplateForLabelNoAccount()
	{
		return "HesabÄ±n yok mu?";
	}

	protected override string _GetTemplateForLabelNonAMemberQuestion()
	{
		return "Ãœye deÄŸil misin?";
	}

	protected override string _GetTemplateForLabelNotReceived()
	{
		return "E-postayÄ± almadÄ±n mÄ±?";
	}

	protected override string _GetTemplateForLabelOr()
	{
		return "Veya";
	}

	protected override string _GetTemplateForLabelPassword()
	{
		return "Åžifre";
	}

	protected override string _GetTemplateForLabelPasswordWithColumn()
	{
		return "Åžifre:";
	}

	protected override string _GetTemplateForLabelStartPlaying()
	{
		return "Misafir modunda hemen oynamaya baÅŸlayabilirsin!";
	}

	protected override string _GetTemplateForLabelUnverifiedEmailInstructions()
	{
		return "E-posta adresinle giriÅŸ yapmak iÃ§in adresinin doÄŸrulanmasÄ± gerekli. AyrÄ±ca kullanÄ±cÄ± adÄ±nla da giriÅŸ yapabilirsin.";
	}

	protected override string _GetTemplateForLabelUsername()
	{
		return "KullanÄ±cÄ± AdÄ±";
	}

	protected override string _GetTemplateForLabelUsernameEmail()
	{
		return "KullanÄ±cÄ± AdÄ±/E-posta";
	}

	protected override string _GetTemplateForLabelUsernameEmailPhone()
	{
		return "KullanÄ±cÄ± AdÄ±/E-posta/Telefon";
	}

	protected override string _GetTemplateForLabelUsernamePhone()
	{
		return "KullanÄ±cÄ± AdÄ±/Telefon";
	}

	protected override string _GetTemplateForLabelUsernameWithColumn()
	{
		return "KullanÄ±cÄ± AdÄ±:";
	}

	protected override string _GetTemplateForLabelVerificationEmailSent()
	{
		return "DoÄŸrulama E-postasÄ± GÃ¶nderildi!";
	}

	protected override string _GetTemplateForLabelWeChatAntiAddictionText()
	{
		return "KÃ¶tÃ¼ oyunlarÄ± boykot et, korsan oyunlarÄ± reddet. Kendini savunmanÄ±n ve aldatÄ±lmanÄ±n farkÄ±nda ol. Oyun oynamak beynin iÃ§in iyidir ancak Ã§ok fazla oyun, saÄŸlÄ±ÄŸÄ±na zarar verebilir. Vaktini iyi yÃ¶net ve saÄŸlÄ±klÄ± bir yaÅŸam tarzÄ±nÄ±n tadÄ±nÄ± Ã§Ä±kar.";
	}

	protected override string _GetTemplateForMessageUnknownErrorTryAgain()
	{
		return "Bilinmeyen bir hata meydana geldi. LÃ¼tfen tekrar dene.";
	}

	protected override string _GetTemplateForMessageUsernameAndPasswordRequired()
	{
		return "KullanÄ±cÄ± adÄ± ve ÅŸifre gerekli";
	}

	protected override string _GetTemplateForResponseAccountIssueErrorContactSupport()
	{
		return "Hesap sorunu. LÃ¼tfen destek ile iletiÅŸime geÃ§.";
	}

	protected override string _GetTemplateForResponseAccountLockedRequestReset()
	{
		return "Hesap engellendi. LÃ¼tfen bir ÅŸifre sÄ±fÄ±rlama talep et.";
	}

	protected override string _GetTemplateForResponseAccountNotFound()
	{
		return "Hesap bulunamadÄ±. LÃ¼tfen tekrar dene.";
	}

	protected override string _GetTemplateForResponseEmailLinkedToMultipleAccountsLoginWithUsername()
	{
		return "E-postan 1'den fazla kullanÄ±cÄ± adÄ±yla iliÅŸkili. LÃ¼tfen kullanÄ±cÄ± adÄ±nla giriÅŸ yap.";
	}

	protected override string _GetTemplateForResponseEmailSent()
	{
		return "E-posta gÃ¶nderildi!";
	}

	protected override string _GetTemplateForResponseIncorrectEmailOrPassword()
	{
		return "HatalÄ± e-posta veya ÅŸifre.";
	}

	protected override string _GetTemplateForResponseIncorrectPhoneOrPassword()
	{
		return "HatalÄ± telefon veya ÅŸifre.";
	}

	protected override string _GetTemplateForResponseIncorrectUsernamePassword()
	{
		return "KullanÄ±cÄ± adÄ± veya ÅŸifre geÃ§ersiz.";
	}

	protected override string _GetTemplateForResponseLoginWithUsername()
	{
		return "Bir ÅŸeyler yanlÄ±ÅŸ gitti. LÃ¼tfen kullanÄ±cÄ± adÄ±nla giriÅŸ yap.";
	}

	protected override string _GetTemplateForResponsePasswordNotProvided()
	{
		return "Bir ÅŸifre girmelisin.";
	}

	protected override string _GetTemplateForResponseTooManyAttemptsPleaseWait()
	{
		return "Ã‡ok sayÄ±da deneme. LÃ¼tfen biraz bekle.";
	}

	protected override string _GetTemplateForResponseUnknownError()
	{
		return "Bilinmeyen Hata";
	}

	protected override string _GetTemplateForResponseUnknownLoginError()
	{
		return "Bilinmeyen giriÅŸ hatasÄ±.";
	}

	protected override string _GetTemplateForResponseUnverifiedEmailLoginWithUsername()
	{
		return "E-postan doÄŸrulanmadÄ±. LÃ¼tfen kullanÄ±cÄ± adÄ±nla giriÅŸ yap.";
	}

	protected override string _GetTemplateForResponseUnverifiedPhoneLoginWithUsername()
	{
		return "Telefonun doÄŸrulanmadÄ±. LÃ¼tfen kullanÄ±cÄ± adÄ±nla giriÅŸ yap.";
	}

	protected override string _GetTemplateForResponseUsernameNotProvided()
	{
		return "Bir kullanÄ±cÄ± adÄ± girmelisin.";
	}

	protected override string _GetTemplateForResponseUseSocialSignOn()
	{
		return "GiriÅŸ yapÄ±lamÄ±yor. LÃ¼tfen Sosyal AÄŸ giriÅŸini kullan.";
	}

	/// <summary>
	/// Key: "Response.WeChatNotRealNameVerified"
	/// English String: "Your WeChat is not real-name verified. Please use a real-name verified WeChat account and try again. Please visit {url}"
	/// </summary>
	public override string ResponseWeChatNotRealNameVerified(string url)
	{
		return $"WeChat'in gerÃ§ek isimle doÄŸrulanmÄ±ÅŸ deÄŸil. LÃ¼tfen gerÃ§ek isimle doÄŸrulanmÄ±ÅŸ bir WeChat hesabÄ± gir ve tekrar dene. LÃ¼tfen {url} adresini ziyaret et.";
	}

	protected override string _GetTemplateForResponseWeChatNotRealNameVerified()
	{
		return "WeChat'in gerÃ§ek isimle doÄŸrulanmÄ±ÅŸ deÄŸil. LÃ¼tfen gerÃ§ek isimle doÄŸrulanmÄ±ÅŸ bir WeChat hesabÄ± gir ve tekrar dene. LÃ¼tfen {url} adresini ziyaret et.";
	}

	protected override string _GetTemplateForWeChatAntiAddictionText()
	{
		return "KÃ¶tÃ¼ oyunlarÄ± boykot et, korsan oyunlarÄ± reddet. Kendini savunmanÄ±n ve aldatÄ±lmanÄ±n farkÄ±nda ol. Oyun oynamak beynin iÃ§in iyidir ancak Ã§ok fazla oyun, saÄŸlÄ±ÄŸÄ±na zarar verebilir. Vaktini iyi yÃ¶net ve saÄŸlÄ±klÄ± bir yaÅŸam tarzÄ±nÄ±n tadÄ±nÄ± Ã§Ä±kar.";
	}

	protected override string _GetTemplateForWeChatRealNameNotVerified()
	{
		return "WeChat'in gerÃ§ek isimle doÄŸrulanmÄ±ÅŸ deÄŸil. LÃ¼tfen gerÃ§ek isimle doÄŸrulanmÄ±ÅŸ bir WeChat hesabÄ± gir ve tekrar dene. LÃ¼tfen https://jiazhang.qq.com/zk/home.html adresini ziyaret et";
	}
}


}
