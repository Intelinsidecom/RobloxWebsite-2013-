namespace Roblox.TranslationResources.Authentication;

/// <summary>
/// This class overrides LoginResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class LoginResources_vi_vn : LoginResources_en_us, ILoginResources, ITranslationResources
{
	/// <summary>
	/// Key: "Action.Cancel"
	/// Cancel button text
	/// English String: "Cancel"
	/// </summary>
	public override string ActionCancel => "Hủy";

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
	public override string ActionForgotPasswordOrUsernameQuestion => "Quên mật khẩu hoặc tên người dùng?";

	/// <summary>
	/// Key: "Action.ForgotPasswordOrUsernameQuestionCapitalized"
	/// link under login form
	/// English String: "Forgot Password or Username?"
	/// </summary>
	public override string ActionForgotPasswordOrUsernameQuestionCapitalized => "Bạn quên Mật khẩu hoặc Tên người dùng?";

	/// <summary>
	/// Key: "Action.Login"
	/// English String: "Login"
	/// </summary>
	public override string ActionLogin => "Đăng nhập";

	/// <summary>
	/// Key: "Action.LogInCapitalized"
	/// login button label. please note this is different from 'Login' or 'Log in'.
	/// English String: "Log In"
	/// </summary>
	public override string ActionLogInCapitalized => "Đăng nhập";

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
	public override string ActionPlayAsGuest => "Chơi dưới dạng Khách";

	/// <summary>
	/// Key: "Action.Resend"
	/// button text for resending verification email
	/// English String: "Resend"
	/// </summary>
	public override string ActionResend => "Gửi lại";

	/// <summary>
	/// Key: "Action.ResendEmail"
	/// link that resends verification email to user
	/// English String: "Resend Email"
	/// </summary>
	public override string ActionResendEmail => "Gửi lại email";

	/// <summary>
	/// Key: "Action.SendVerificationEmail"
	/// button user can click to send a verification link to their email
	/// English String: "Send Verification Email"
	/// </summary>
	public override string ActionSendVerificationEmail => "Gửi email xác minh";

	/// <summary>
	/// Key: "Action.SignIn"
	/// Sign In button text
	/// English String: "Sign In"
	/// </summary>
	public override string ActionSignIn => "Đăng nhập";

	/// <summary>
	/// Key: "Action.SignInWithFacebook"
	/// Sign In with Facebook
	/// English String: "Sign In with Facebook"
	/// </summary>
	public override string ActionSignInWithFacebook => "Đăng nhập bằng Facebook";

	/// <summary>
	/// Key: "Action.SignUp"
	/// English String: "Sign up"
	/// </summary>
	public override string ActionSignUp => "Đăng ký";

	/// <summary>
	/// Key: "Action.SignUpCapitalized"
	/// link which takes user to sign up page
	/// English String: "Sign Up"
	/// </summary>
	public override string ActionSignUpCapitalized => "Đăng ký";

	/// <summary>
	/// Key: "Action.WeChatLogin"
	/// button text for logging in with WeChat
	/// English String: "WeChat Login"
	/// </summary>
	public override string ActionWeChatLogin => "Đăng nhập bằng WeChat";

	/// <summary>
	/// Key: "Heading.Login"
	/// heading on the login page
	/// English String: "Login"
	/// </summary>
	public override string HeadingLogin => "Đăng nhập";

	/// <summary>
	/// Key: "Heading.LoginRoblox"
	/// current login page heading
	/// English String: "Login to Roblox"
	/// </summary>
	public override string HeadingLoginRoblox => "Đăng nhập vào Roblox";

	public override string HeadingSignUpMakeFriends => "Đăng ký để Xây dựng & Kết bạn";

	/// <summary>
	/// Key: "Label.AccountNotNeeded"
	/// You don't need an account to play Roblox
	/// English String: "You don't need an account to play Roblox"
	/// </summary>
	public override string LabelAccountNotNeeded => "Bạn không cần có tài khoản để chơi Roblox";

	/// <summary>
	/// Key: "Label.EmailNeedsVerification"
	/// modal header used for prompting user they need to verify their email in order to log in with it
	/// English String: "Your email needs verification"
	/// </summary>
	public override string LabelEmailNeedsVerification => "Email của bạn cần xác minh";

	/// <summary>
	/// Key: "Label.FacebookCreatePasswordWarning"
	/// If you have been signing in with Facebook, you must set a password.
	/// English String: "If you have been signing in with Facebook, you must set a password."
	/// </summary>
	public override string LabelFacebookCreatePasswordWarning => "Nếu bạn đã đăng nhập bằng Facebook, bạn phải đặt một mật khẩu.";

	/// <summary>
	/// Key: "Label.ForgotUsernamePassword"
	/// landing page top right link for password reset
	/// English String: "Forgot Username/Password?"
	/// </summary>
	public override string LabelForgotUsernamePassword => "Quên Tên người dùng/Mật khẩu?";

	/// <summary>
	/// Key: "Label.LearnMore"
	/// learn more link text
	/// English String: "Learn more"
	/// </summary>
	public override string LabelLearnMore => "Tìm hiểu thêm";

	/// <summary>
	/// Key: "Label.LoggingInSpinnerText"
	/// English String: "Logging in…"
	/// </summary>
	public override string LabelLoggingInSpinnerText => "Đang đăng nhập...";

	/// <summary>
	/// Key: "Label.Login"
	/// English String: "Log in"
	/// </summary>
	public override string LabelLogin => "Đăng nhập";

	/// <summary>
	/// Key: "Label.LoginWithYour"
	/// Label for a partition line between login with email and facebook login. Please keep the text in lowercase for roman characters.
	/// English String: "login with your"
	/// </summary>
	public override string LabelLoginWithYour => "đăng nhập bằng";

	/// <summary>
	/// Key: "Label.NoAccount"
	/// Don't have an account?
	/// English String: "Don't have an account?"
	/// </summary>
	public override string LabelNoAccount => "Bạn không có tài khoản?";

	/// <summary>
	/// Key: "Label.NonAMemberQuestion"
	/// The question heading for the section on the login page to take use to sign up page.
	/// English String: "Not a member?"
	/// </summary>
	public override string LabelNonAMemberQuestion => "Chưa phải là thành viên?";

	/// <summary>
	/// Key: "Label.NotReceived"
	/// prompt for allowing users to resend verification email
	/// English String: "Didn't receive it?"
	/// </summary>
	public override string LabelNotReceived => "Bạn không nhận được?";

	/// <summary>
	/// Key: "Label.Or"
	/// partition between email login and facebook login
	/// English String: "Or"
	/// </summary>
	public override string LabelOr => "Hoặc";

	/// <summary>
	/// Key: "Label.Password"
	/// Password
	/// English String: "Password"
	/// </summary>
	public override string LabelPassword => "Mật khẩu";

	/// <summary>
	/// Key: "Label.PasswordWithColumn"
	/// label for the password field on the login page
	/// English String: "Password:"
	/// </summary>
	public override string LabelPasswordWithColumn => "Mật khẩu:";

	/// <summary>
	/// Key: "Label.StartPlaying"
	/// You can start playing right now, in guest mode!
	/// English String: "You can start playing right now, in guest mode!"
	/// </summary>
	public override string LabelStartPlaying => "Bạn có thể bắt đầu chơi ngay trong chế độ khách!";

	/// <summary>
	/// Key: "Label.UnverifiedEmailInstructions"
	/// message shown in a modal when user logs in with unverified email
	/// English String: "To log in with your email, it must be verified. You can also log in with your username."
	/// </summary>
	public override string LabelUnverifiedEmailInstructions => "Email của bạn phải được xác minh để bạn có thể đăng nhập bằng email. Bạn cũng có thể đăng nhập bằng tên người dùng của mình.";

	/// <summary>
	/// Key: "Label.Username"
	/// English String: "Username"
	/// </summary>
	public override string LabelUsername => "Tên người dùng";

	/// <summary>
	/// Key: "Label.UsernameEmail"
	/// placeholder text for input field that accepts username or email
	/// English String: "Username/Email"
	/// </summary>
	public override string LabelUsernameEmail => "Tên người dùng/Địa chỉ email";

	/// <summary>
	/// Key: "Label.UsernameEmailPhone"
	/// placeholder text for input fields that accept username, email or phone
	/// English String: "Username/Email/Phone"
	/// </summary>
	public override string LabelUsernameEmailPhone => "Tên người dùng/Địa chỉ email/Số điện thoại";

	/// <summary>
	/// Key: "Label.UsernamePhone"
	/// placeholder text for input field that accepts username or phone
	/// English String: "Username/Phone"
	/// </summary>
	public override string LabelUsernamePhone => "Tên người dùng/Số điện thoại";

	/// <summary>
	/// Key: "Label.UsernameWithColumn"
	/// label for username field on login page
	/// English String: "Username:"
	/// </summary>
	public override string LabelUsernameWithColumn => "Tên người dùng:";

	/// <summary>
	/// Key: "Label.VerificationEmailSent"
	/// message telling user a verification email was sent to them
	/// English String: "Verification Email Sent!"
	/// </summary>
	public override string LabelVerificationEmailSent => "Đã gửi email xác minh!";

	/// <summary>
	/// Key: "Label.WeChatAntiAddictionText"
	/// English String: "Boycott bad games, refuse pirated games. Be aware of self-defense and being deceived. Playing games is good for your brain, but too much game play can harm your health. Manage your time well and enjoy a healthy lifestyle."
	/// </summary>
	public override string LabelWeChatAntiAddictionText => "Tẩy chay trò chơi xấu, không chơi trò chơi bị bẻ khóa. Chú ý để tự bảo vệ mình và không bị lừa. Chơi trò chơi có tác động tốt tới não bộ của bạn nhưng chơi quá nhiều trò chơi có thể ảnh hướng xấu tới sức khỏe của bạn. Hãy quản lý thời gian của bạn hiệu quả và tận hưởng lối sống lành mạnh.";

	/// <summary>
	/// Key: "Message.UnknownErrorTryAgain"
	/// An unknown error occurred. Please try again.
	/// English String: "An unknown error occurred. Please try again."
	/// </summary>
	public override string MessageUnknownErrorTryAgain => "Đã xảy ra lỗi không xác định. Vui lòng thử lại.";

	/// <summary>
	/// Key: "Message.UsernameAndPasswordRequired"
	/// message shown to user when they attempt to login without entering a username or password
	/// English String: "Username and password required"
	/// </summary>
	public override string MessageUsernameAndPasswordRequired => "Cần có tên người dùng và mật khẩu";

	/// <summary>
	/// Key: "Response.AccountIssueErrorContactSupport"
	/// English String: "Account issue. Please contact Support."
	/// </summary>
	public override string ResponseAccountIssueErrorContactSupport => "Sự cố về tài khoản. Vui lòng liên hệ Hỗ trợ.";

	/// <summary>
	/// Key: "Response.AccountLockedRequestReset"
	/// Account has been locked. Please request a password reset.
	/// English String: "Account has been locked. Please request a password reset."
	/// </summary>
	public override string ResponseAccountLockedRequestReset => "Tài khoản đã bị khóa. Vui lòng yêu cầu đặt lại mật khẩu.";

	/// <summary>
	/// Key: "Response.AccountNotFound"
	/// Account not found. Please try again.
	/// English String: "Account not found. Please try again."
	/// </summary>
	public override string ResponseAccountNotFound => "Không tìm thấy tài khoản. Vui lòng thử lại.";

	/// <summary>
	/// Key: "Response.EmailLinkedToMultipleAccountsLoginWithUsername"
	/// error message displayed when user attempts to log in with an email that is linked to multiple accounts
	/// English String: "Your email is associated with more than 1 username. Please login with your username."
	/// </summary>
	public override string ResponseEmailLinkedToMultipleAccountsLoginWithUsername => "Địa chỉ email của bạn được liên kết với nhiều hơn 1 tên người dùng. Vui lòng đăng nhập bằng tên người dùng của bạn.";

	/// <summary>
	/// Key: "Response.EmailSent"
	/// response telling user that a verification email has been sent to them
	/// English String: "Email sent!"
	/// </summary>
	public override string ResponseEmailSent => "Đã gửi email!";

	/// <summary>
	/// Key: "Response.IncorrectEmailOrPassword"
	/// error message displayed when user logs in with an invalid email or password
	/// English String: "Incorrect email or password."
	/// </summary>
	public override string ResponseIncorrectEmailOrPassword => "Sai địa chỉ email hoặc mật khẩu.";

	/// <summary>
	/// Key: "Response.IncorrectPhoneOrPassword"
	/// error message displayed when user logs in with an invalid phone or password
	/// English String: "Incorrect phone or password."
	/// </summary>
	public override string ResponseIncorrectPhoneOrPassword => "Sai số điện thoại hoặc mật khẩu.";

	/// <summary>
	/// Key: "Response.IncorrectUsernamePassword"
	/// English String: "Incorrect username or password."
	/// </summary>
	public override string ResponseIncorrectUsernamePassword => "Sai tên người dùng hoặc mật khẩu.";

	/// <summary>
	/// Key: "Response.LoginWithUsername"
	/// error message shown when user attempts to login with method other than username and an error occurred
	/// English String: "Something went wrong. Please login with your username."
	/// </summary>
	public override string ResponseLoginWithUsername => "Đã xảy ra sự cố. Vui lòng đăng nhập bằng tên người dùng của bạn.";

	/// <summary>
	/// Key: "Response.PasswordNotProvided"
	/// password field is empty
	/// English String: "You must enter a password."
	/// </summary>
	public override string ResponsePasswordNotProvided => "Bạn phải nhập mật khẩu.";

	/// <summary>
	/// Key: "Response.TooManyAttemptsPleaseWait"
	/// English String: "Too many attempts. Please wait a bit."
	/// </summary>
	public override string ResponseTooManyAttemptsPleaseWait => "Quá nhiều lần thử. Vui lòng chờ trong ít phút.";

	/// <summary>
	/// Key: "Response.UnknownError"
	/// English String: "Unknown Error"
	/// </summary>
	public override string ResponseUnknownError => "Lỗi không xác định";

	/// <summary>
	/// Key: "Response.UnknownLoginError"
	/// Unknown login failure.
	/// English String: "Unknown login failure."
	/// </summary>
	public override string ResponseUnknownLoginError => "Lỗi đăng nhập không xác định.";

	/// <summary>
	/// Key: "Response.UnverifiedEmailLoginWithUsername"
	/// error message shown when user attempts to login with unverified email
	/// English String: "Your email is not verified. Please login with your username."
	/// </summary>
	public override string ResponseUnverifiedEmailLoginWithUsername => "Địa chỉ email của bạn chưa được xác minh. Vui lòng đăng nhập bằng tên người dùng của bạn.";

	/// <summary>
	/// Key: "Response.UnverifiedPhoneLoginWithUsername"
	/// error message shown when user attempts to login with an unverified phone number
	/// English String: "Your phone is not verified. Please login with your username."
	/// </summary>
	public override string ResponseUnverifiedPhoneLoginWithUsername => "Số điện thoại của bạn chưa được xác minh. Vui lòng đăng nhập bằng tên người dùng của bạn.";

	/// <summary>
	/// Key: "Response.UsernameNotProvided"
	/// username field is empty
	/// English String: "You must enter a username."
	/// </summary>
	public override string ResponseUsernameNotProvided => "Bạn phải nhập tên người dùng.";

	/// <summary>
	/// Key: "Response.UseSocialSignOn"
	/// Unable to login. Please use Social Network sign on.
	/// English String: "Unable to login. Please use Social Network sign on."
	/// </summary>
	public override string ResponseUseSocialSignOn => "Không thể đăng nhập. Vui lòng sử dụng đăng ký bằng Mạng xã hội.";

	/// <summary>
	/// Key: "WeChat.AntiAddictionText"
	/// English String: "Boycott bad games, refuse pirated games. Be aware of self-defense and being deceived. Playing games is good for your brain, but too much game play can harm your health. Manage your time well and enjoy a healthy lifestyle."
	/// </summary>
	public override string WeChatAntiAddictionText => "Tẩy chay trò chơi xấu, không chơi trò chơi bị bẻ khóa. Chú ý để tự bảo vệ mình và không bị lừa. Chơi trò chơi có tác động tốt tới não bộ của bạn nhưng chơi quá nhiều trò chơi có thể ảnh hướng xấu tới sức khỏe của bạn. Hãy quản lý thời gian của bạn hiệu quả và tận hưởng lối sống lành mạnh.";

	/// <summary>
	/// Key: "WeChat.RealNameNotVerified"
	/// English String: "Your WeChat is not real-name verified. Please use a real-name verified WeChat account and try again. Please visit https://jiazhang.qq.com/zk/home.html"
	/// </summary>
	public override string WeChatRealNameNotVerified => "Tài khoản WeChat của bạn chưa được xác minh sử dụng tên thật. Vui lòng sử dụng tài khoản WeChat có tên thật được xác minh và thử lại. Vui lòng truy cập https://jiazhang.qq.com/zk/home.html";

	public LoginResources_vi_vn(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionCancel()
	{
		return "Hủy";
	}

	protected override string _GetTemplateForActionFacebook()
	{
		return "Facebook";
	}

	protected override string _GetTemplateForActionForgotPasswordOrUsernameQuestion()
	{
		return "Quên mật khẩu hoặc tên người dùng?";
	}

	protected override string _GetTemplateForActionForgotPasswordOrUsernameQuestionCapitalized()
	{
		return "Bạn quên Mật khẩu hoặc Tên người dùng?";
	}

	protected override string _GetTemplateForActionLogin()
	{
		return "Đăng nhập";
	}

	protected override string _GetTemplateForActionLogInCapitalized()
	{
		return "Đăng nhập";
	}

	protected override string _GetTemplateForActionOk()
	{
		return "OK";
	}

	protected override string _GetTemplateForActionPlayAsGuest()
	{
		return "Chơi dưới dạng Khách";
	}

	protected override string _GetTemplateForActionResend()
	{
		return "Gửi lại";
	}

	protected override string _GetTemplateForActionResendEmail()
	{
		return "Gửi lại email";
	}

	protected override string _GetTemplateForActionSendVerificationEmail()
	{
		return "Gửi email xác minh";
	}

	protected override string _GetTemplateForActionSignIn()
	{
		return "Đăng nhập";
	}

	protected override string _GetTemplateForActionSignInWithFacebook()
	{
		return "Đăng nhập bằng Facebook";
	}

	protected override string _GetTemplateForActionSignUp()
	{
		return "Đăng ký";
	}

	protected override string _GetTemplateForActionSignUpCapitalized()
	{
		return "Đăng ký";
	}

	protected override string _GetTemplateForActionWeChatLogin()
	{
		return "Đăng nhập bằng WeChat";
	}

	protected override string _GetTemplateForHeadingLogin()
	{
		return "Đăng nhập";
	}

	protected override string _GetTemplateForHeadingLoginRoblox()
	{
		return "Đăng nhập vào Roblox";
	}

	protected override string _GetTemplateForHeadingSignUpMakeFriends()
	{
		return "Đăng ký để Xây dựng & Kết bạn";
	}

	protected override string _GetTemplateForLabelAccountNotNeeded()
	{
		return "Bạn không cần có tài khoản để chơi Roblox";
	}

	protected override string _GetTemplateForLabelEmailNeedsVerification()
	{
		return "Email của bạn cần xác minh";
	}

	protected override string _GetTemplateForLabelFacebookCreatePasswordWarning()
	{
		return "Nếu bạn đã đăng nhập bằng Facebook, bạn phải đặt một mật khẩu.";
	}

	protected override string _GetTemplateForLabelForgotUsernamePassword()
	{
		return "Quên Tên người dùng/Mật khẩu?";
	}

	/// <summary>
	/// Key: "Label.GreetingForNewAccount"
	/// Shown when a username doesn't exist on the login page to invite to create a new account.
	/// English String: "Nice to meet you, {username}. {linkStartSignup}Let's make an account! {linkEndSignup}"
	/// </summary>
	public override string LabelGreetingForNewAccount(string username, string linkStartSignup, string linkEndSignup)
	{
		return $"Rất vui được gặp bạn, {username}. {linkStartSignup}Hãy tạo một tài khoản nào! {linkEndSignup}";
	}

	protected override string _GetTemplateForLabelGreetingForNewAccount()
	{
		return "Rất vui được gặp bạn, {username}. {linkStartSignup}Hãy tạo một tài khoản nào! {linkEndSignup}";
	}

	protected override string _GetTemplateForLabelLearnMore()
	{
		return "Tìm hiểu thêm";
	}

	protected override string _GetTemplateForLabelLoggingInSpinnerText()
	{
		return "Đang đăng nhập...";
	}

	protected override string _GetTemplateForLabelLogin()
	{
		return "Đăng nhập";
	}

	protected override string _GetTemplateForLabelLoginWithYour()
	{
		return "đăng nhập bằng";
	}

	protected override string _GetTemplateForLabelNoAccount()
	{
		return "Bạn không có tài khoản?";
	}

	protected override string _GetTemplateForLabelNonAMemberQuestion()
	{
		return "Chưa phải là thành viên?";
	}

	protected override string _GetTemplateForLabelNotReceived()
	{
		return "Bạn không nhận được?";
	}

	protected override string _GetTemplateForLabelOr()
	{
		return "Hoặc";
	}

	protected override string _GetTemplateForLabelPassword()
	{
		return "Mật khẩu";
	}

	protected override string _GetTemplateForLabelPasswordWithColumn()
	{
		return "Mật khẩu:";
	}

	protected override string _GetTemplateForLabelStartPlaying()
	{
		return "Bạn có thể bắt đầu chơi ngay trong chế độ khách!";
	}

	protected override string _GetTemplateForLabelUnverifiedEmailInstructions()
	{
		return "Email của bạn phải được xác minh để bạn có thể đăng nhập bằng email. Bạn cũng có thể đăng nhập bằng tên người dùng của mình.";
	}

	protected override string _GetTemplateForLabelUsername()
	{
		return "Tên người dùng";
	}

	protected override string _GetTemplateForLabelUsernameEmail()
	{
		return "Tên người dùng/Địa chỉ email";
	}

	protected override string _GetTemplateForLabelUsernameEmailPhone()
	{
		return "Tên người dùng/Địa chỉ email/Số điện thoại";
	}

	protected override string _GetTemplateForLabelUsernamePhone()
	{
		return "Tên người dùng/Số điện thoại";
	}

	protected override string _GetTemplateForLabelUsernameWithColumn()
	{
		return "Tên người dùng:";
	}

	protected override string _GetTemplateForLabelVerificationEmailSent()
	{
		return "Đã gửi email xác minh!";
	}

	protected override string _GetTemplateForLabelWeChatAntiAddictionText()
	{
		return "Tẩy chay trò chơi xấu, không chơi trò chơi bị bẻ khóa. Chú ý để tự bảo vệ mình và không bị lừa. Chơi trò chơi có tác động tốt tới não bộ của bạn nhưng chơi quá nhiều trò chơi có thể ảnh hướng xấu tới sức khỏe của bạn. Hãy quản lý thời gian của bạn hiệu quả và tận hưởng lối sống lành mạnh.";
	}

	protected override string _GetTemplateForMessageUnknownErrorTryAgain()
	{
		return "Đã xảy ra lỗi không xác định. Vui lòng thử lại.";
	}

	protected override string _GetTemplateForMessageUsernameAndPasswordRequired()
	{
		return "Cần có tên người dùng và mật khẩu";
	}

	protected override string _GetTemplateForResponseAccountIssueErrorContactSupport()
	{
		return "Sự cố về tài khoản. Vui lòng liên hệ Hỗ trợ.";
	}

	protected override string _GetTemplateForResponseAccountLockedRequestReset()
	{
		return "Tài khoản đã bị khóa. Vui lòng yêu cầu đặt lại mật khẩu.";
	}

	protected override string _GetTemplateForResponseAccountNotFound()
	{
		return "Không tìm thấy tài khoản. Vui lòng thử lại.";
	}

	protected override string _GetTemplateForResponseEmailLinkedToMultipleAccountsLoginWithUsername()
	{
		return "Địa chỉ email của bạn được liên kết với nhiều hơn 1 tên người dùng. Vui lòng đăng nhập bằng tên người dùng của bạn.";
	}

	protected override string _GetTemplateForResponseEmailSent()
	{
		return "Đã gửi email!";
	}

	protected override string _GetTemplateForResponseIncorrectEmailOrPassword()
	{
		return "Sai địa chỉ email hoặc mật khẩu.";
	}

	protected override string _GetTemplateForResponseIncorrectPhoneOrPassword()
	{
		return "Sai số điện thoại hoặc mật khẩu.";
	}

	protected override string _GetTemplateForResponseIncorrectUsernamePassword()
	{
		return "Sai tên người dùng hoặc mật khẩu.";
	}

	protected override string _GetTemplateForResponseLoginWithUsername()
	{
		return "Đã xảy ra sự cố. Vui lòng đăng nhập bằng tên người dùng của bạn.";
	}

	protected override string _GetTemplateForResponsePasswordNotProvided()
	{
		return "Bạn phải nhập mật khẩu.";
	}

	protected override string _GetTemplateForResponseTooManyAttemptsPleaseWait()
	{
		return "Quá nhiều lần thử. Vui lòng chờ trong ít phút.";
	}

	protected override string _GetTemplateForResponseUnknownError()
	{
		return "Lỗi không xác định";
	}

	protected override string _GetTemplateForResponseUnknownLoginError()
	{
		return "Lỗi đăng nhập không xác định.";
	}

	protected override string _GetTemplateForResponseUnverifiedEmailLoginWithUsername()
	{
		return "Địa chỉ email của bạn chưa được xác minh. Vui lòng đăng nhập bằng tên người dùng của bạn.";
	}

	protected override string _GetTemplateForResponseUnverifiedPhoneLoginWithUsername()
	{
		return "Số điện thoại của bạn chưa được xác minh. Vui lòng đăng nhập bằng tên người dùng của bạn.";
	}

	protected override string _GetTemplateForResponseUsernameNotProvided()
	{
		return "Bạn phải nhập tên người dùng.";
	}

	protected override string _GetTemplateForResponseUseSocialSignOn()
	{
		return "Không thể đăng nhập. Vui lòng sử dụng đăng ký bằng Mạng xã hội.";
	}

	/// <summary>
	/// Key: "Response.WeChatNotRealNameVerified"
	/// English String: "Your WeChat is not real-name verified. Please use a real-name verified WeChat account and try again. Please visit {url}"
	/// </summary>
	public override string ResponseWeChatNotRealNameVerified(string url)
	{
		return $"Tài khoản WeChat của bạn chưa được xác minh sử dụng tên thật. Vui lòng sử dụng tài khoản WeChat có tên thật được xác minh và thử lại. Vui lòng truy cập {url}";
	}

	protected override string _GetTemplateForResponseWeChatNotRealNameVerified()
	{
		return "Tài khoản WeChat của bạn chưa được xác minh sử dụng tên thật. Vui lòng sử dụng tài khoản WeChat có tên thật được xác minh và thử lại. Vui lòng truy cập {url}";
	}

	protected override string _GetTemplateForWeChatAntiAddictionText()
	{
		return "Tẩy chay trò chơi xấu, không chơi trò chơi bị bẻ khóa. Chú ý để tự bảo vệ mình và không bị lừa. Chơi trò chơi có tác động tốt tới não bộ của bạn nhưng chơi quá nhiều trò chơi có thể ảnh hướng xấu tới sức khỏe của bạn. Hãy quản lý thời gian của bạn hiệu quả và tận hưởng lối sống lành mạnh.";
	}

	protected override string _GetTemplateForWeChatRealNameNotVerified()
	{
		return "Tài khoản WeChat của bạn chưa được xác minh sử dụng tên thật. Vui lòng sử dụng tài khoản WeChat có tên thật được xác minh và thử lại. Vui lòng truy cập https://jiazhang.qq.com/zk/home.html";
	}
}
