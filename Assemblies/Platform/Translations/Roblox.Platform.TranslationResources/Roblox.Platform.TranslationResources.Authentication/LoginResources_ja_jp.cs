namespace Roblox.TranslationResources.Authentication;

/// <summary>
/// This class overrides LoginResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class LoginResources_ja_jp : LoginResources_en_us, ILoginResources, ITranslationResources
{
	/// <summary>
	/// Key: "Action.Cancel"
	/// Cancel button text
	/// English String: "Cancel"
	/// </summary>
	public override string ActionCancel => "キャンセル";

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
	public override string ActionForgotPasswordOrUsernameQuestion => "パスワード、またはユーザーネームをお忘れですか？";

	/// <summary>
	/// Key: "Action.ForgotPasswordOrUsernameQuestionCapitalized"
	/// link under login form
	/// English String: "Forgot Password or Username?"
	/// </summary>
	public override string ActionForgotPasswordOrUsernameQuestionCapitalized => "パスワード、またはユーザーネームをお忘れですか？";

	/// <summary>
	/// Key: "Action.Login"
	/// English String: "Login"
	/// </summary>
	public override string ActionLogin => "ログイン";

	/// <summary>
	/// Key: "Action.LogInCapitalized"
	/// login button label. please note this is different from 'Login' or 'Log in'.
	/// English String: "Log In"
	/// </summary>
	public override string ActionLogInCapitalized => "ログイン";

	/// <summary>
	/// Key: "Action.Ok"
	/// button text
	/// English String: "OK"
	/// </summary>
	public override string ActionOk => "OK";

	/// <summary>
	/// Key: "Action.PlayAsGuest"
	/// Play as Guest
	/// English String: "Play as Guest"
	/// </summary>
	public override string ActionPlayAsGuest => "ゲストとしてプレイする";

	/// <summary>
	/// Key: "Action.Resend"
	/// button text for resending verification email
	/// English String: "Resend"
	/// </summary>
	public override string ActionResend => "再送信";

	/// <summary>
	/// Key: "Action.ResendEmail"
	/// link that resends verification email to user
	/// English String: "Resend Email"
	/// </summary>
	public override string ActionResendEmail => "メールを再送信";

	/// <summary>
	/// Key: "Action.SendVerificationEmail"
	/// button user can click to send a verification link to their email
	/// English String: "Send Verification Email"
	/// </summary>
	public override string ActionSendVerificationEmail => "確認メールを送信";

	/// <summary>
	/// Key: "Action.SignIn"
	/// Sign In button text
	/// English String: "Sign In"
	/// </summary>
	public override string ActionSignIn => "サインイン";

	/// <summary>
	/// Key: "Action.SignInWithFacebook"
	/// Sign In with Facebook
	/// English String: "Sign In with Facebook"
	/// </summary>
	public override string ActionSignInWithFacebook => "Facebookでサインインする";

	/// <summary>
	/// Key: "Action.SignUp"
	/// English String: "Sign up"
	/// </summary>
	public override string ActionSignUp => "新規登録";

	/// <summary>
	/// Key: "Action.SignUpCapitalized"
	/// link which takes user to sign up page
	/// English String: "Sign Up"
	/// </summary>
	public override string ActionSignUpCapitalized => "新規登録";

	/// <summary>
	/// Key: "Action.WeChatLogin"
	/// button text for logging in with WeChat
	/// English String: "WeChat Login"
	/// </summary>
	public override string ActionWeChatLogin => "WeChatログイン";

	/// <summary>
	/// Key: "Heading.Login"
	/// heading on the login page
	/// English String: "Login"
	/// </summary>
	public override string HeadingLogin => "ログイン";

	/// <summary>
	/// Key: "Heading.LoginRoblox"
	/// current login page heading
	/// English String: "Login to Roblox"
	/// </summary>
	public override string HeadingLoginRoblox => "Robloxにログインする";

	public override string HeadingSignUpMakeFriends => "新規登録してゲーム制作したり、友達を作る";

	/// <summary>
	/// Key: "Label.AccountNotNeeded"
	/// You don't need an account to play Roblox
	/// English String: "You don't need an account to play Roblox"
	/// </summary>
	public override string LabelAccountNotNeeded => "Robloxをプレイするのにアカウントは必要ありません。";

	/// <summary>
	/// Key: "Label.EmailNeedsVerification"
	/// modal header used for prompting user they need to verify their email in order to log in with it
	/// English String: "Your email needs verification"
	/// </summary>
	public override string LabelEmailNeedsVerification => "メール確認の手続きが必要です";

	/// <summary>
	/// Key: "Label.FacebookCreatePasswordWarning"
	/// If you have been signing in with Facebook, you must set a password.
	/// English String: "If you have been signing in with Facebook, you must set a password."
	/// </summary>
	public override string LabelFacebookCreatePasswordWarning => "Facebookでサインインしている場合には、パスワードの設定が必要です。";

	/// <summary>
	/// Key: "Label.ForgotUsernamePassword"
	/// landing page top right link for password reset
	/// English String: "Forgot Username/Password?"
	/// </summary>
	public override string LabelForgotUsernamePassword => "ユーザーネームかパスワードをお忘れですか？";

	/// <summary>
	/// Key: "Label.LearnMore"
	/// learn more link text
	/// English String: "Learn more"
	/// </summary>
	public override string LabelLearnMore => "詳しく知る";

	/// <summary>
	/// Key: "Label.LoggingInSpinnerText"
	/// English String: "Logging in…"
	/// </summary>
	public override string LabelLoggingInSpinnerText => "ログイン中…";

	/// <summary>
	/// Key: "Label.Login"
	/// English String: "Log in"
	/// </summary>
	public override string LabelLogin => "ログイン";

	/// <summary>
	/// Key: "Label.LoginWithYour"
	/// Label for a partition line between login with email and facebook login. Please keep the text in lowercase for roman characters.
	/// English String: "login with your"
	/// </summary>
	public override string LabelLoginWithYour => "以下でログインしてください";

	/// <summary>
	/// Key: "Label.NoAccount"
	/// Don't have an account?
	/// English String: "Don't have an account?"
	/// </summary>
	public override string LabelNoAccount => "アカウントをお持ちではありませんか？";

	/// <summary>
	/// Key: "Label.NonAMemberQuestion"
	/// The question heading for the section on the login page to take use to sign up page.
	/// English String: "Not a member?"
	/// </summary>
	public override string LabelNonAMemberQuestion => "メンバーではありませんか？";

	/// <summary>
	/// Key: "Label.NotReceived"
	/// prompt for allowing users to resend verification email
	/// English String: "Didn't receive it?"
	/// </summary>
	public override string LabelNotReceived => "受信できませんでしたか？";

	/// <summary>
	/// Key: "Label.Or"
	/// partition between email login and facebook login
	/// English String: "Or"
	/// </summary>
	public override string LabelOr => "または";

	/// <summary>
	/// Key: "Label.Password"
	/// Password
	/// English String: "Password"
	/// </summary>
	public override string LabelPassword => "パスワード";

	/// <summary>
	/// Key: "Label.PasswordWithColumn"
	/// label for the password field on the login page
	/// English String: "Password:"
	/// </summary>
	public override string LabelPasswordWithColumn => "パスワード：";

	/// <summary>
	/// Key: "Label.StartPlaying"
	/// You can start playing right now, in guest mode!
	/// English String: "You can start playing right now, in guest mode!"
	/// </summary>
	public override string LabelStartPlaying => "ゲストモードで今すぐプレイできます！";

	/// <summary>
	/// Key: "Label.UnverifiedEmailInstructions"
	/// message shown in a modal when user logs in with unverified email
	/// English String: "To log in with your email, it must be verified. You can also log in with your username."
	/// </summary>
	public override string LabelUnverifiedEmailInstructions => "メールアドレスでログインするためには、まず認証が必要です。ユーザーネームでログインすることもできます。";

	/// <summary>
	/// Key: "Label.Username"
	/// English String: "Username"
	/// </summary>
	public override string LabelUsername => "ユーザーネーム";

	/// <summary>
	/// Key: "Label.UsernameEmail"
	/// placeholder text for input field that accepts username or email
	/// English String: "Username/Email"
	/// </summary>
	public override string LabelUsernameEmail => "ユーザーネーム/メールアドレス";

	/// <summary>
	/// Key: "Label.UsernameEmailPhone"
	/// placeholder text for input fields that accept username, email or phone
	/// English String: "Username/Email/Phone"
	/// </summary>
	public override string LabelUsernameEmailPhone => "ユーザーネーム/メールアドレス/電話番号";

	/// <summary>
	/// Key: "Label.UsernamePhone"
	/// placeholder text for input field that accepts username or phone
	/// English String: "Username/Phone"
	/// </summary>
	public override string LabelUsernamePhone => "ユーザーネーム/電話番号";

	/// <summary>
	/// Key: "Label.UsernameWithColumn"
	/// label for username field on login page
	/// English String: "Username:"
	/// </summary>
	public override string LabelUsernameWithColumn => "ユーザーネーム:";

	/// <summary>
	/// Key: "Label.VerificationEmailSent"
	/// message telling user a verification email was sent to them
	/// English String: "Verification Email Sent!"
	/// </summary>
	public override string LabelVerificationEmailSent => "確認メールが送信されました！";

	/// <summary>
	/// Key: "Label.WeChatAntiAddictionText"
	/// English String: "Boycott bad games, refuse pirated games. Be aware of self-defense and being deceived. Playing games is good for your brain, but too much game play can harm your health. Manage your time well and enjoy a healthy lifestyle."
	/// </summary>
	public override string LabelWeChatAntiAddictionText => "不適切なゲームには参加しないように心掛け、海賊版は拒否しましょう。自衛意識を高め、騙されないようにしましょう。ゲームをプレイすることは脳の働きを高めてくれますが、プレイしすぎると健康を害する恐れがあります。時間管理をきちんと行い、健康的なライフスタイルをお楽しみください。";

	/// <summary>
	/// Key: "Message.UnknownErrorTryAgain"
	/// An unknown error occurred. Please try again.
	/// English String: "An unknown error occurred. Please try again."
	/// </summary>
	public override string MessageUnknownErrorTryAgain => "不明なエラーが発生しました。もう一度お試しください。";

	/// <summary>
	/// Key: "Message.UsernameAndPasswordRequired"
	/// message shown to user when they attempt to login without entering a username or password
	/// English String: "Username and password required"
	/// </summary>
	public override string MessageUsernameAndPasswordRequired => "ユーザーネームとパスワードが必要です";

	/// <summary>
	/// Key: "Response.AccountIssueErrorContactSupport"
	/// English String: "Account issue. Please contact Support."
	/// </summary>
	public override string ResponseAccountIssueErrorContactSupport => "アカウントに関する問題が発生しました。サポートにお問い合わせください。";

	/// <summary>
	/// Key: "Response.AccountLockedRequestReset"
	/// Account has been locked. Please request a password reset.
	/// English String: "Account has been locked. Please request a password reset."
	/// </summary>
	public override string ResponseAccountLockedRequestReset => "アカウントがロックされています。パスワードリセットをリクエストしてください。";

	/// <summary>
	/// Key: "Response.AccountNotFound"
	/// Account not found. Please try again.
	/// English String: "Account not found. Please try again."
	/// </summary>
	public override string ResponseAccountNotFound => "アカウントが見つかりませんでした。もう一度お試しください。";

	/// <summary>
	/// Key: "Response.EmailLinkedToMultipleAccountsLoginWithUsername"
	/// error message displayed when user attempts to log in with an email that is linked to multiple accounts
	/// English String: "Your email is associated with more than 1 username. Please login with your username."
	/// </summary>
	public override string ResponseEmailLinkedToMultipleAccountsLoginWithUsername => "メールアドレスが複数のユーザーネームに関連付けられています。ユーザーネームでログインしてください。";

	/// <summary>
	/// Key: "Response.EmailSent"
	/// response telling user that a verification email has been sent to them
	/// English String: "Email sent!"
	/// </summary>
	public override string ResponseEmailSent => "メールが送信されました！";

	/// <summary>
	/// Key: "Response.IncorrectEmailOrPassword"
	/// error message displayed when user logs in with an invalid email or password
	/// English String: "Incorrect email or password."
	/// </summary>
	public override string ResponseIncorrectEmailOrPassword => "メールアドレスまたはパスワードが間違っています。";

	/// <summary>
	/// Key: "Response.IncorrectPhoneOrPassword"
	/// error message displayed when user logs in with an invalid phone or password
	/// English String: "Incorrect phone or password."
	/// </summary>
	public override string ResponseIncorrectPhoneOrPassword => "電話番号またはパスワードが間違っています。";

	/// <summary>
	/// Key: "Response.IncorrectUsernamePassword"
	/// English String: "Incorrect username or password."
	/// </summary>
	public override string ResponseIncorrectUsernamePassword => "ユーザーネーム、またはパスワードが間違っています。";

	/// <summary>
	/// Key: "Response.LoginWithUsername"
	/// error message shown when user attempts to login with method other than username and an error occurred
	/// English String: "Something went wrong. Please login with your username."
	/// </summary>
	public override string ResponseLoginWithUsername => "何らかの問題が発生しました。もう一度お試しください。";

	/// <summary>
	/// Key: "Response.PasswordNotProvided"
	/// password field is empty
	/// English String: "You must enter a password."
	/// </summary>
	public override string ResponsePasswordNotProvided => "パスワードは必須です。";

	/// <summary>
	/// Key: "Response.TooManyAttemptsPleaseWait"
	/// English String: "Too many attempts. Please wait a bit."
	/// </summary>
	public override string ResponseTooManyAttemptsPleaseWait => "試行回数が多すぎます。しばらくしてからやり直してください。";

	/// <summary>
	/// Key: "Response.UnknownError"
	/// English String: "Unknown Error"
	/// </summary>
	public override string ResponseUnknownError => "不明なエラーが発生しました";

	/// <summary>
	/// Key: "Response.UnknownLoginError"
	/// Unknown login failure.
	/// English String: "Unknown login failure."
	/// </summary>
	public override string ResponseUnknownLoginError => "不明なログインの失敗。";

	/// <summary>
	/// Key: "Response.UnverifiedEmailLoginWithUsername"
	/// error message shown when user attempts to login with unverified email
	/// English String: "Your email is not verified. Please login with your username."
	/// </summary>
	public override string ResponseUnverifiedEmailLoginWithUsername => "メールアドレスが認証されていません。ユーザーネームでログインしてください。";

	/// <summary>
	/// Key: "Response.UnverifiedPhoneLoginWithUsername"
	/// error message shown when user attempts to login with an unverified phone number
	/// English String: "Your phone is not verified. Please login with your username."
	/// </summary>
	public override string ResponseUnverifiedPhoneLoginWithUsername => "電話番号が認証されていません。ユーザーネームでログインしてください。";

	/// <summary>
	/// Key: "Response.UsernameNotProvided"
	/// username field is empty
	/// English String: "You must enter a username."
	/// </summary>
	public override string ResponseUsernameNotProvided => "ユーザーネームは必須です。";

	/// <summary>
	/// Key: "Response.UseSocialSignOn"
	/// Unable to login. Please use Social Network sign on.
	/// English String: "Unable to login. Please use Social Network sign on."
	/// </summary>
	public override string ResponseUseSocialSignOn => "ログインできませんでした。ソーシャルネットワーク・サインオンをご利用ください。";

	/// <summary>
	/// Key: "WeChat.AntiAddictionText"
	/// English String: "Boycott bad games, refuse pirated games. Be aware of self-defense and being deceived. Playing games is good for your brain, but too much game play can harm your health. Manage your time well and enjoy a healthy lifestyle."
	/// </summary>
	public override string WeChatAntiAddictionText => "不適切なゲームには参加しないように心掛け、海賊版は拒否しましょう。自衛意識を高め、騙されないようにしましょう。ゲームをプレイすることは脳の働きを高めてくれますが、プレイしすぎると健康を害する恐れがあります。時間管理をきちんと行い、健康的なライフスタイルをお楽しみください。";

	/// <summary>
	/// Key: "WeChat.RealNameNotVerified"
	/// English String: "Your WeChat is not real-name verified. Please use a real-name verified WeChat account and try again. Please visit https://jiazhang.qq.com/zk/home.html"
	/// </summary>
	public override string WeChatRealNameNotVerified => "WeChatで、本名の認証が行われていません。本名の認証を行ったWeChatアカウントを使用してやり直してください。https://jiazhang.qq.com/zk/home.html にアクセスしてください。";

	public LoginResources_ja_jp(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionCancel()
	{
		return "キャンセル";
	}

	protected override string _GetTemplateForActionFacebook()
	{
		return "Facebook";
	}

	protected override string _GetTemplateForActionForgotPasswordOrUsernameQuestion()
	{
		return "パスワード、またはユーザーネームをお忘れですか？";
	}

	protected override string _GetTemplateForActionForgotPasswordOrUsernameQuestionCapitalized()
	{
		return "パスワード、またはユーザーネームをお忘れですか？";
	}

	protected override string _GetTemplateForActionLogin()
	{
		return "ログイン";
	}

	protected override string _GetTemplateForActionLogInCapitalized()
	{
		return "ログイン";
	}

	protected override string _GetTemplateForActionOk()
	{
		return "OK";
	}

	protected override string _GetTemplateForActionPlayAsGuest()
	{
		return "ゲストとしてプレイする";
	}

	protected override string _GetTemplateForActionResend()
	{
		return "再送信";
	}

	protected override string _GetTemplateForActionResendEmail()
	{
		return "メールを再送信";
	}

	protected override string _GetTemplateForActionSendVerificationEmail()
	{
		return "確認メールを送信";
	}

	protected override string _GetTemplateForActionSignIn()
	{
		return "サインイン";
	}

	protected override string _GetTemplateForActionSignInWithFacebook()
	{
		return "Facebookでサインインする";
	}

	protected override string _GetTemplateForActionSignUp()
	{
		return "新規登録";
	}

	protected override string _GetTemplateForActionSignUpCapitalized()
	{
		return "新規登録";
	}

	protected override string _GetTemplateForActionWeChatLogin()
	{
		return "WeChatログイン";
	}

	protected override string _GetTemplateForHeadingLogin()
	{
		return "ログイン";
	}

	protected override string _GetTemplateForHeadingLoginRoblox()
	{
		return "Robloxにログインする";
	}

	protected override string _GetTemplateForHeadingSignUpMakeFriends()
	{
		return "新規登録してゲーム制作したり、友達を作る";
	}

	protected override string _GetTemplateForLabelAccountNotNeeded()
	{
		return "Robloxをプレイするのにアカウントは必要ありません。";
	}

	protected override string _GetTemplateForLabelEmailNeedsVerification()
	{
		return "メール確認の手続きが必要です";
	}

	protected override string _GetTemplateForLabelFacebookCreatePasswordWarning()
	{
		return "Facebookでサインインしている場合には、パスワードの設定が必要です。";
	}

	protected override string _GetTemplateForLabelForgotUsernamePassword()
	{
		return "ユーザーネームかパスワードをお忘れですか？";
	}

	/// <summary>
	/// Key: "Label.GreetingForNewAccount"
	/// Shown when a username doesn't exist on the login page to invite to create a new account.
	/// English String: "Nice to meet you, {username}. {linkStartSignup}Let's make an account! {linkEndSignup}"
	/// </summary>
	public override string LabelGreetingForNewAccount(string username, string linkStartSignup, string linkEndSignup)
	{
		return $"はじめまして、 {username}さん。 {linkStartSignup}アカウントを作りましょう! {linkEndSignup}";
	}

	protected override string _GetTemplateForLabelGreetingForNewAccount()
	{
		return "はじめまして、 {username}さん。 {linkStartSignup}アカウントを作りましょう! {linkEndSignup}";
	}

	protected override string _GetTemplateForLabelLearnMore()
	{
		return "詳しく知る";
	}

	protected override string _GetTemplateForLabelLoggingInSpinnerText()
	{
		return "ログイン中…";
	}

	protected override string _GetTemplateForLabelLogin()
	{
		return "ログイン";
	}

	protected override string _GetTemplateForLabelLoginWithYour()
	{
		return "以下でログインしてください";
	}

	protected override string _GetTemplateForLabelNoAccount()
	{
		return "アカウントをお持ちではありませんか？";
	}

	protected override string _GetTemplateForLabelNonAMemberQuestion()
	{
		return "メンバーではありませんか？";
	}

	protected override string _GetTemplateForLabelNotReceived()
	{
		return "受信できませんでしたか？";
	}

	protected override string _GetTemplateForLabelOr()
	{
		return "または";
	}

	protected override string _GetTemplateForLabelPassword()
	{
		return "パスワード";
	}

	protected override string _GetTemplateForLabelPasswordWithColumn()
	{
		return "パスワード：";
	}

	protected override string _GetTemplateForLabelStartPlaying()
	{
		return "ゲストモードで今すぐプレイできます！";
	}

	protected override string _GetTemplateForLabelUnverifiedEmailInstructions()
	{
		return "メールアドレスでログインするためには、まず認証が必要です。ユーザーネームでログインすることもできます。";
	}

	protected override string _GetTemplateForLabelUsername()
	{
		return "ユーザーネーム";
	}

	protected override string _GetTemplateForLabelUsernameEmail()
	{
		return "ユーザーネーム/メールアドレス";
	}

	protected override string _GetTemplateForLabelUsernameEmailPhone()
	{
		return "ユーザーネーム/メールアドレス/電話番号";
	}

	protected override string _GetTemplateForLabelUsernamePhone()
	{
		return "ユーザーネーム/電話番号";
	}

	protected override string _GetTemplateForLabelUsernameWithColumn()
	{
		return "ユーザーネーム:";
	}

	protected override string _GetTemplateForLabelVerificationEmailSent()
	{
		return "確認メールが送信されました！";
	}

	protected override string _GetTemplateForLabelWeChatAntiAddictionText()
	{
		return "不適切なゲームには参加しないように心掛け、海賊版は拒否しましょう。自衛意識を高め、騙されないようにしましょう。ゲームをプレイすることは脳の働きを高めてくれますが、プレイしすぎると健康を害する恐れがあります。時間管理をきちんと行い、健康的なライフスタイルをお楽しみください。";
	}

	protected override string _GetTemplateForMessageUnknownErrorTryAgain()
	{
		return "不明なエラーが発生しました。もう一度お試しください。";
	}

	protected override string _GetTemplateForMessageUsernameAndPasswordRequired()
	{
		return "ユーザーネームとパスワードが必要です";
	}

	protected override string _GetTemplateForResponseAccountIssueErrorContactSupport()
	{
		return "アカウントに関する問題が発生しました。サポートにお問い合わせください。";
	}

	protected override string _GetTemplateForResponseAccountLockedRequestReset()
	{
		return "アカウントがロックされています。パスワードリセットをリクエストしてください。";
	}

	protected override string _GetTemplateForResponseAccountNotFound()
	{
		return "アカウントが見つかりませんでした。もう一度お試しください。";
	}

	protected override string _GetTemplateForResponseEmailLinkedToMultipleAccountsLoginWithUsername()
	{
		return "メールアドレスが複数のユーザーネームに関連付けられています。ユーザーネームでログインしてください。";
	}

	protected override string _GetTemplateForResponseEmailSent()
	{
		return "メールが送信されました！";
	}

	protected override string _GetTemplateForResponseIncorrectEmailOrPassword()
	{
		return "メールアドレスまたはパスワードが間違っています。";
	}

	protected override string _GetTemplateForResponseIncorrectPhoneOrPassword()
	{
		return "電話番号またはパスワードが間違っています。";
	}

	protected override string _GetTemplateForResponseIncorrectUsernamePassword()
	{
		return "ユーザーネーム、またはパスワードが間違っています。";
	}

	protected override string _GetTemplateForResponseLoginWithUsername()
	{
		return "何らかの問題が発生しました。もう一度お試しください。";
	}

	protected override string _GetTemplateForResponsePasswordNotProvided()
	{
		return "パスワードは必須です。";
	}

	protected override string _GetTemplateForResponseTooManyAttemptsPleaseWait()
	{
		return "試行回数が多すぎます。しばらくしてからやり直してください。";
	}

	protected override string _GetTemplateForResponseUnknownError()
	{
		return "不明なエラーが発生しました";
	}

	protected override string _GetTemplateForResponseUnknownLoginError()
	{
		return "不明なログインの失敗。";
	}

	protected override string _GetTemplateForResponseUnverifiedEmailLoginWithUsername()
	{
		return "メールアドレスが認証されていません。ユーザーネームでログインしてください。";
	}

	protected override string _GetTemplateForResponseUnverifiedPhoneLoginWithUsername()
	{
		return "電話番号が認証されていません。ユーザーネームでログインしてください。";
	}

	protected override string _GetTemplateForResponseUsernameNotProvided()
	{
		return "ユーザーネームは必須です。";
	}

	protected override string _GetTemplateForResponseUseSocialSignOn()
	{
		return "ログインできませんでした。ソーシャルネットワーク・サインオンをご利用ください。";
	}

	/// <summary>
	/// Key: "Response.WeChatNotRealNameVerified"
	/// English String: "Your WeChat is not real-name verified. Please use a real-name verified WeChat account and try again. Please visit {url}"
	/// </summary>
	public override string ResponseWeChatNotRealNameVerified(string url)
	{
		return $"WeChatで、本名の認証が行われていません。本名の認証を行ったWeChatアカウントを使用してやり直してください。 {url} にアクセスしてください。";
	}

	protected override string _GetTemplateForResponseWeChatNotRealNameVerified()
	{
		return "WeChatで、本名の認証が行われていません。本名の認証を行ったWeChatアカウントを使用してやり直してください。 {url} にアクセスしてください。";
	}

	protected override string _GetTemplateForWeChatAntiAddictionText()
	{
		return "不適切なゲームには参加しないように心掛け、海賊版は拒否しましょう。自衛意識を高め、騙されないようにしましょう。ゲームをプレイすることは脳の働きを高めてくれますが、プレイしすぎると健康を害する恐れがあります。時間管理をきちんと行い、健康的なライフスタイルをお楽しみください。";
	}

	protected override string _GetTemplateForWeChatRealNameNotVerified()
	{
		return "WeChatで、本名の認証が行われていません。本名の認証を行ったWeChatアカウントを使用してやり直してください。https://jiazhang.qq.com/zk/home.html にアクセスしてください。";
	}
}
