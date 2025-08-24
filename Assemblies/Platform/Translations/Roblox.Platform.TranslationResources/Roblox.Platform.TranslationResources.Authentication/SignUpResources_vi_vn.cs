namespace Roblox.TranslationResources.Authentication;

/// <summary>
/// This class overrides SignUpResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class SignUpResources_vi_vn : SignUpResources_en_us, ISignUpResources, ITranslationResources
{
	/// <summary>
	/// Key: "Action.CreateAccount"
	/// create account button label
	/// English String: "Create Account"
	/// </summary>
	public override string ActionCreateAccount => "Tạo Tài khoản";

	/// <summary>
	/// Key: "Action.LinkAccount"
	/// Button text to link 3rd Party Account to a Roblox Account
	/// English String: "Link Account"
	/// </summary>
	public override string ActionLinkAccount => "Liên kết Tài khoản";

	/// <summary>
	/// Key: "Action.LogInCapitalized"
	/// button label for capitalized words for Log In
	/// English String: "Log In"
	/// </summary>
	public override string ActionLogInCapitalized => "Đăng nhập";

	/// <summary>
	/// Key: "Action.ReturnHome"
	/// button label to return the user to home page
	/// English String: "Return Home"
	/// </summary>
	public override string ActionReturnHome => "Trở lại Trang chủ";

	/// <summary>
	/// Key: "Action.SignUp"
	/// English String: "Sign up"
	/// </summary>
	public override string ActionSignUp => "Đăng ký";

	public override string ActionSignupAndSync => "Đăng ký & Đồng bộ";

	/// <summary>
	/// Key: "Action.Submit"
	/// English String: "Submit"
	/// </summary>
	public override string ActionSubmit => "Gửi";

	/// <summary>
	/// Key: "Description.AccountLinkingWarning"
	/// instructions for linking account on signup page for FB based account
	/// English String: "To link to an existing Roblox account, sign in and link them on the account settings page."
	/// </summary>
	public override string DescriptionAccountLinkingWarning => "Để liên kết với tài khoản Roblox có sẵn, hãy đăng nhập và liên kết chúng trên trang cài đặt tài khoản.";

	/// <summary>
	/// Key: "Description.NoRealName"
	/// description
	/// English String: "Do not use your real name."
	/// </summary>
	public override string DescriptionNoRealName => "Không dùng tên thật của bạn.";

	/// <summary>
	/// Key: "Description.PrivacyPolicy"
	/// English String: "Privacy Policy"
	/// </summary>
	public override string DescriptionPrivacyPolicy => "Chính sách riêng tư";

	/// <summary>
	/// Key: "Description.TermsOfService"
	/// English String: "Terms of Service"
	/// </summary>
	public override string DescriptionTermsOfService => "Điều khoản dịch vụ";

	/// <summary>
	/// Key: "GuestSignUpAB.Action.SignUp"
	/// English String: "Sign Up"
	/// </summary>
	public override string GuestSignUpABActionSignUp => "Đăng ký";

	/// <summary>
	/// Key: "Heading.ConnectFacebook"
	/// section heading
	/// English String: "Connect to Facebook"
	/// </summary>
	public override string HeadingConnectFacebook => "Kết nối với Facebook";

	/// <summary>
	/// Key: "Heading.CreateAnAccount"
	/// should be capitalized if the language supports capitalization
	/// English String: "CREATE AN ACCOUNT"
	/// </summary>
	public override string HeadingCreateAnAccount => "TẠO TÀI KHOẢN";

	/// <summary>
	/// Key: "Heading.LoginHaveFun"
	/// heading for login container
	/// English String: "Log in and start having fun!"
	/// </summary>
	public override string HeadingLoginHaveFun => "Đăng nhập và giải trí!";

	/// <summary>
	/// Key: "Heading.SignupHaveFun"
	/// signup form heading
	/// English String: "Sign up and start having fun!"
	/// </summary>
	public override string HeadingSignupHaveFun => "Đăng ký và giải trí!";

	/// <summary>
	/// Key: "Label.About"
	/// About link on roller coaster page
	/// English String: "About"
	/// </summary>
	public override string LabelAbout => "Về sản phẩm";

	/// <summary>
	/// Key: "Label.AlreadyHaveRobloxAccount"
	/// English String: "Already have a Roblox account?"
	/// </summary>
	public override string LabelAlreadyHaveRobloxAccount => "Bạn đã có tài khoản Roblox?";

	/// <summary>
	/// Key: "Label.AlreadyRegistered"
	/// label
	/// English String: "Already registered?"
	/// </summary>
	public override string LabelAlreadyRegistered => "Đã đăng ký?";

	/// <summary>
	/// Key: "Label.Birthday"
	/// English String: "Birthday"
	/// </summary>
	public override string LabelBirthday => "Ngày sinh";

	/// <summary>
	/// Key: "Label.BirthdayWithColumn"
	/// should have column if the language supports it
	/// English String: "Birthday:"
	/// </summary>
	public override string LabelBirthdayWithColumn => "Ngày sinh:";

	/// <summary>
	/// Key: "Label.ConfirmPassword"
	/// English String: "Confirm password"
	/// </summary>
	public override string LabelConfirmPassword => "Xác nhận mật khẩu";

	/// <summary>
	/// Key: "Label.Day"
	/// English String: "Day"
	/// </summary>
	public override string LabelDay => "Ngày";

	/// <summary>
	/// Key: "Label.DesiredUsername"
	/// should have a column if the language supports it
	/// English String: "Desired Username:"
	/// </summary>
	public override string LabelDesiredUsername => "Tên người dùng muốn đặt:";

	/// <summary>
	/// Key: "Label.FacebookNotLinked"
	/// English String: "Your Facebook account is not linked to any Roblox account. Please sign up for a Roblox account."
	/// </summary>
	public override string LabelFacebookNotLinked => "Tài khoản Facebook của bạn không được liên kết với bất kỳ tài khoản Roblox nào. Vui lòng đăng ký một tài khoản Roblox.";

	/// <summary>
	/// Key: "Label.FacebookSignupUsername"
	/// username field label for FB signup
	/// English String: "Create Roblox username:"
	/// </summary>
	public override string LabelFacebookSignupUsername => "Tạo tên người dùng Roblox:";

	/// <summary>
	/// Key: "Label.Female"
	/// label
	/// English String: "Female"
	/// </summary>
	public override string LabelFemale => "Nữ";

	/// <summary>
	/// Key: "Label.Gender"
	/// English String: "Gender"
	/// </summary>
	public override string LabelGender => "Giới tính";

	/// <summary>
	/// Key: "Label.GenderRequired"
	/// English String: "Gender is required."
	/// </summary>
	public override string LabelGenderRequired => "Cần phải chọn giới tính.";

	/// <summary>
	/// Key: "Label.GenderWithColumn"
	/// should have column if the language supports it
	/// English String: "Gender:"
	/// </summary>
	public override string LabelGenderWithColumn => "Giới tính:";

	/// <summary>
	/// Key: "Label.Male"
	/// label
	/// English String: "Male"
	/// </summary>
	public override string LabelMale => "Nam";

	/// <summary>
	/// Key: "Label.Month"
	/// English String: "Month"
	/// </summary>
	public override string LabelMonth => "Tháng";

	/// <summary>
	/// Key: "Label.Password"
	/// English String: "Password"
	/// </summary>
	public override string LabelPassword => "Mật khẩu";

	/// <summary>
	/// Key: "Label.PasswordRequirements"
	/// English String: "Password (min length 8)"
	/// </summary>
	public override string LabelPasswordRequirements => "Mật khẩu (tối thiểu 8 ký tự)";

	/// <summary>
	/// Key: "Label.Platforms"
	/// platforms link on roller coaster page
	/// English String: "Platforms"
	/// </summary>
	public override string LabelPlatforms => "Nền tảng";

	/// <summary>
	/// Key: "Label.Play"
	/// Play link on roller coaster page
	/// English String: "Play"
	/// </summary>
	public override string LabelPlay => "Chơi";

	/// <summary>
	/// Key: "Label.PleaseAgreeToTerms"
	/// English String: "Please agree to our Terms of Use and Privacy Policy."
	/// </summary>
	public override string LabelPleaseAgreeToTerms => "Vui lòng đồng ký với Điều khoản sử dụng và Chính sách riêng tư của chúng tôi.";

	/// <summary>
	/// Key: "Label.Required"
	/// Required
	/// English String: "Required"
	/// </summary>
	public override string LabelRequired => "Bắt buộc";

	/// <summary>
	/// Key: "Label.SignupButtonText"
	/// sign up button text
	/// English String: "Sign Up and Play!"
	/// </summary>
	public override string LabelSignupButtonText => "Đăng ký và Chơi!";

	/// <summary>
	/// Key: "Label.SignUpWith"
	/// This is text that will fit go between two buttons, a regular "sign up button" and a "external provider button" (like facebook).
	///
	/// Visually it looks like
	/// [ Signup Button]
	/// - or sign up with -
	/// [facebook button]
	/// English String: "or sign up with"
	/// </summary>
	public override string LabelSignUpWith => "hoặc đăng ký bằng";

	/// <summary>
	/// Key: "Label.TermsOfUse"
	/// terms of use link label
	/// English String: "Terms of Use"
	/// </summary>
	public override string LabelTermsOfUse => "Điều khoản sử dụng";

	/// <summary>
	/// Key: "Label.Username"
	/// English String: "Username"
	/// </summary>
	public override string LabelUsername => "Tên người dùng";

	/// <summary>
	/// Key: "Label.UsernameCharacterLimit"
	/// label
	/// English String: "3-20 alphanumeric characters, no spaces."
	/// </summary>
	public override string LabelUsernameCharacterLimit => "Có từ 3-20 chữ cái và chữ số, không chứa ký tự trống.";

	/// <summary>
	/// Key: "Label.UsernameHint"
	/// placeholder for username field
	/// English String: "Username (don't use your real name)"
	/// </summary>
	public override string LabelUsernameHint => "Tên người dùng (không dùng tên thật của bạn)";

	/// <summary>
	/// Key: "Label.UsernameRequirements"
	/// English String: "Username (length 3-20, _ is allowed)"
	/// </summary>
	public override string LabelUsernameRequirements => "Tên người dùng (từ 3-20 ký tự, _ được cho phép)";

	/// <summary>
	/// Key: "Label.Year"
	/// English String: "Year"
	/// </summary>
	public override string LabelYear => "Năm";

	/// <summary>
	/// Key: "Message.Password.MinLength"
	/// English String: "Min length 8"
	/// </summary>
	public override string MessagePasswordMinLength => "Tối thiểu 8 ký tự";

	/// <summary>
	/// Key: "Message.Username.NoRealNameUse"
	/// English String: "Don't use your real name"
	/// </summary>
	public override string MessageUsernameNoRealNameUse => "Không dùng tên thật của bạn";

	/// <summary>
	/// Key: "Response.BadUsername"
	/// English String: "Username not appropriate for Roblox."
	/// </summary>
	public override string ResponseBadUsername => "Tên người dùng không phù hợp với Roblox.";

	/// <summary>
	/// Key: "Response.BadUsernameForWeChat"
	/// message shown when signing up with an inappropriate username
	/// English String: "Username is not appropriate"
	/// </summary>
	public override string ResponseBadUsernameForWeChat => "Tên người dùng không phù hợp";

	/// <summary>
	/// Key: "Response.BirthdayInvalid"
	/// English String: "This birthday is invalid."
	/// </summary>
	public override string ResponseBirthdayInvalid => "Ngày sinh này không hợp lệ.";

	/// <summary>
	/// Key: "Response.BirthdayMustBeSetFirst"
	/// English String: "Birthday must be set first."
	/// </summary>
	public override string ResponseBirthdayMustBeSetFirst => "Phải chọn ngày sinh trước.";

	/// <summary>
	/// Key: "Response.CaptchaMismatchError"
	/// error message
	/// English String: "Words do not match."
	/// </summary>
	public override string ResponseCaptchaMismatchError => "Các từ không trùng.";

	/// <summary>
	/// Key: "Response.CaptchaNotEnteredError"
	/// validation error message
	/// English String: "Please fill out the Captcha"
	/// </summary>
	public override string ResponseCaptchaNotEnteredError => "Vui lòng điền mã Captcha";

	/// <summary>
	/// Key: "Response.FacebookConnectionError"
	/// error message
	/// English String: "Error while retrieving values from Facebook."
	/// </summary>
	public override string ResponseFacebookConnectionError => "Xảy ra lỗi khi truy xuất giá trị từ Facebook.";

	/// <summary>
	/// Key: "Response.FacebookLoginAge"
	/// English String: "Facebook login can only be used by users above 13."
	/// </summary>
	public override string ResponseFacebookLoginAge => "Chỉ người dùng trên 13 tuổi mới có thể sử dụng đăng nhập bằng Facebook.";

	/// <summary>
	/// Key: "Response.InvalidBirthday"
	/// English String: "Invalid birthday."
	/// </summary>
	public override string ResponseInvalidBirthday => "Ngày sinh không hợp lệ.";

	/// <summary>
	/// Key: "Response.InvalidEmail"
	/// English String: "Invalid email address."
	/// </summary>
	public override string ResponseInvalidEmail => "Địa chỉ email không hợp lệ.";

	/// <summary>
	/// Key: "Response.JavaScriptRequired"
	/// error to show that JavaScipt is required for the form to work
	/// English String: "JavaScript is required to submit this form."
	/// </summary>
	public override string ResponseJavaScriptRequired => "Phải bật JavaScript để gửi mẫu này.";

	/// <summary>
	/// Key: "Response.PasswordComplexity"
	/// English String: "Please create a more complex password."
	/// </summary>
	public override string ResponsePasswordComplexity => "Vui lòng tạo mật khẩu khó đoán hơn.";

	/// <summary>
	/// Key: "Response.PasswordConfirmation"
	/// validation message for password confirmation
	/// English String: "Please enter a password confirmation."
	/// </summary>
	public override string ResponsePasswordConfirmation => "Vui lòng nhập mật khẩu xác nhận.";

	/// <summary>
	/// Key: "Response.PasswordContainsUsernameError"
	/// error when passsword has username in it
	/// English String: "Password shouldn't match username."
	/// </summary>
	public override string ResponsePasswordContainsUsernameError => "Mật khẩu không nên trùng với tên người dùng.";

	/// <summary>
	/// Key: "Response.PasswordMismatch"
	/// English String: "Passwords do not match."
	/// </summary>
	public override string ResponsePasswordMismatch => "Mật khẩu không trùng nhau.";

	/// <summary>
	/// Key: "Response.PasswordWrongShort"
	/// English String: "Passwords must be at least 8 characters long."
	/// </summary>
	public override string ResponsePasswordWrongShort => "Mật khẩu phải có tối thiểu 8 ký tự.";

	/// <summary>
	/// Key: "Response.PleaseEnterPassword"
	/// English String: "Please enter a password."
	/// </summary>
	public override string ResponsePleaseEnterPassword => "Vui lòng nhập mật khẩu.";

	/// <summary>
	/// Key: "Response.PleaseEnterUsername"
	/// English String: "Please enter a username."
	/// </summary>
	public override string ResponsePleaseEnterUsername => "Vui lòng nhập tên người dùng.";

	/// <summary>
	/// Key: "Response.SocialAccountCreationFailed"
	/// error message
	/// English String: "Account creation failed"
	/// </summary>
	public override string ResponseSocialAccountCreationFailed => "Không thể tạo tài khoản";

	/// <summary>
	/// Key: "Response.SpaceOrSpecialCharaterError"
	/// Spaces and special characters are not allowed error message
	/// English String: "Spaces and special characters are not allowed."
	/// </summary>
	public override string ResponseSpaceOrSpecialCharaterError => "Không được nhập ký tự trống và ký tự đặc biệt.";

	/// <summary>
	/// Key: "Response.TooManyAccountsWithSameEmailError"
	/// Too many accounts use this email error message
	/// English String: "Too many accounts use this email."
	/// </summary>
	public override string ResponseTooManyAccountsWithSameEmailError => "Có quá nhiều tài khoản sử dụng email này.";

	/// <summary>
	/// Key: "Response.UnknownError"
	/// English String: "Sorry! An unknown error occurred. Please try again later."
	/// </summary>
	public override string ResponseUnknownError => "Rất tiếc! Đã xảy ra lỗi không xác định. Vui lòng thử lại sau.";

	/// <summary>
	/// Key: "Response.UsernameAllowedCharactersError"
	/// error showing which characters are allowed for username
	/// English String: "Usernames may only contain letters, numbers, and _."
	/// </summary>
	public override string ResponseUsernameAllowedCharactersError => "Tên người dùng chỉ được chứa chữ cái, chữ số và ký tự _.";

	/// <summary>
	/// Key: "Response.UsernameAlreadyInUse"
	/// English String: "This username is already in use."
	/// </summary>
	public override string ResponseUsernameAlreadyInUse => "Tên người dùng đã được sử dụng.";

	/// <summary>
	/// Key: "Response.UsernameExplicit"
	/// English String: "This username is not allowed, please try another."
	/// </summary>
	public override string ResponseUsernameExplicit => "Không thể sử dụng tên này, xin chọn tên khác.";

	/// <summary>
	/// Key: "Response.UsernameInvalid"
	/// English String: "Please enter a valid username."
	/// </summary>
	public override string ResponseUsernameInvalid => "Vui lòng nhập tên người dùng hợp lệ.";

	/// <summary>
	/// Key: "Response.UsernameInvalidCharacters"
	/// English String: "Only a-z, A-Z, 0-9 and _ are allowed."
	/// </summary>
	public override string ResponseUsernameInvalidCharacters => "Chỉ được dùng các ký tự a-z, A-Z, 0-9 và ký tự _.";

	/// <summary>
	/// Key: "Response.UsernameInvalidLength"
	/// English String: "Usernames can be 3 to 20 characters long."
	/// </summary>
	public override string ResponseUsernameInvalidLength => "Tên người dùng có thể dài từ 3 đến 20 ký tự.";

	/// <summary>
	/// Key: "Response.UsernameInvalidUnderscore"
	/// English String: "Usernames cannot start or end with _."
	/// </summary>
	public override string ResponseUsernameInvalidUnderscore => "Không thể bắt đầu/kết thúc với ký tự _.";

	/// <summary>
	/// Key: "Response.UsernameNotAvailable"
	/// English String: "Username not available. Please try again."
	/// </summary>
	public override string ResponseUsernameNotAvailable => "Tên người dùng không khả dụng. Vui lòng thử lại.";

	/// <summary>
	/// Key: "Response.UsernameOrPasswordIncorrect"
	/// Your username or password is incorrect
	/// English String: "Your username or password is incorrect."
	/// </summary>
	public override string ResponseUsernameOrPasswordIncorrect => "Sai tên người dùng hoặc mật khẩu.";

	/// <summary>
	/// Key: "Response.UsernamePasswordRequired"
	/// Username and Password are required error message
	/// English String: "Username and Password are required."
	/// </summary>
	public override string ResponseUsernamePasswordRequired => "Phải nhập Mật khẩu và Tên người dùng.";

	/// <summary>
	/// Key: "Response.UsernamePrivateInfo"
	/// English String: "Username might contain private information."
	/// </summary>
	public override string ResponseUsernamePrivateInfo => "Tên người dùng có thể chứa thông tin cá nhân.";

	/// <summary>
	/// Key: "Response.UsernameRequired"
	/// validation error message
	/// English String: "Username is required."
	/// </summary>
	public override string ResponseUsernameRequired => "Bắt buộc phải có tên người dùng.";

	/// <summary>
	/// Key: "Response.UsernameTakenTryAgain"
	/// English String: "This username is already taken! Please try a different one."
	/// </summary>
	public override string ResponseUsernameTakenTryAgain => "Tên người dùng này đã được sử dụng! Vui lòng thử tên khác.";

	/// <summary>
	/// Key: "Response.UsernameTooManyUnderscores"
	/// English String: "Usernames can have at most one _."
	/// </summary>
	public override string ResponseUsernameTooManyUnderscores => "Tên người dùng có thể chứa tối đa một ký tự _.";

	public SignUpResources_vi_vn(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionCreateAccount()
	{
		return "Tạo Tài khoản";
	}

	protected override string _GetTemplateForActionLinkAccount()
	{
		return "Liên kết Tài khoản";
	}

	protected override string _GetTemplateForActionLogInCapitalized()
	{
		return "Đăng nhập";
	}

	protected override string _GetTemplateForActionReturnHome()
	{
		return "Trở lại Trang chủ";
	}

	protected override string _GetTemplateForActionSignUp()
	{
		return "Đăng ký";
	}

	protected override string _GetTemplateForActionSignupAndSync()
	{
		return "Đăng ký & Đồng bộ";
	}

	protected override string _GetTemplateForActionSubmit()
	{
		return "Gửi";
	}

	protected override string _GetTemplateForDescriptionAccountLinkingWarning()
	{
		return "Để liên kết với tài khoản Roblox có sẵn, hãy đăng nhập và liên kết chúng trên trang cài đặt tài khoản.";
	}

	protected override string _GetTemplateForDescriptionNoRealName()
	{
		return "Không dùng tên thật của bạn.";
	}

	protected override string _GetTemplateForDescriptionPrivacyPolicy()
	{
		return "Chính sách riêng tư";
	}

	/// <summary>
	/// Key: "Description.SignUpAgreement"
	/// terms of use agreement checkbox label to signup.
	/// English String: "By clicking {spanStart}Sign Up{spanEnd}, you are agreeing to the {termsOfUseLink} and acknowledging the {privacyPolicyLink}"
	/// </summary>
	public override string DescriptionSignUpAgreement(string spanStart, string spanEnd, string termsOfUseLink, string privacyPolicyLink)
	{
		return $"Bấm vào {spanStart}Đăng ký{spanEnd} đồng nghĩa bạn đồng ý với {termsOfUseLink} và thừa nhận {privacyPolicyLink}";
	}

	protected override string _GetTemplateForDescriptionSignUpAgreement()
	{
		return "Bấm vào {spanStart}Đăng ký{spanEnd} đồng nghĩa bạn đồng ý với {termsOfUseLink} và thừa nhận {privacyPolicyLink}";
	}

	protected override string _GetTemplateForDescriptionTermsOfService()
	{
		return "Điều khoản dịch vụ";
	}

	protected override string _GetTemplateForGuestSignUpABActionSignUp()
	{
		return "Đăng ký";
	}

	protected override string _GetTemplateForHeadingConnectFacebook()
	{
		return "Kết nối với Facebook";
	}

	protected override string _GetTemplateForHeadingCreateAnAccount()
	{
		return "TẠO TÀI KHOẢN";
	}

	/// <summary>
	/// Key: "Heading.FacebookSignupAlmostDone"
	/// when user signs up using Facebook, this is shown in next step to create a password.
	/// English String: "{firstname}, YOU'RE ALMOST DONE"
	/// </summary>
	public override string HeadingFacebookSignupAlmostDone(string firstname)
	{
		return $"{firstname}, BẠN SẮP ĐĂNG KÝ XONG RỒI";
	}

	protected override string _GetTemplateForHeadingFacebookSignupAlmostDone()
	{
		return "{firstname}, BẠN SẮP ĐĂNG KÝ XONG RỒI";
	}

	protected override string _GetTemplateForHeadingLoginHaveFun()
	{
		return "Đăng nhập và giải trí!";
	}

	protected override string _GetTemplateForHeadingSignupHaveFun()
	{
		return "Đăng ký và giải trí!";
	}

	protected override string _GetTemplateForLabelAbout()
	{
		return "Về sản phẩm";
	}

	protected override string _GetTemplateForLabelAlreadyHaveRobloxAccount()
	{
		return "Bạn đã có tài khoản Roblox?";
	}

	protected override string _GetTemplateForLabelAlreadyRegistered()
	{
		return "Đã đăng ký?";
	}

	protected override string _GetTemplateForLabelBirthday()
	{
		return "Ngày sinh";
	}

	protected override string _GetTemplateForLabelBirthdayWithColumn()
	{
		return "Ngày sinh:";
	}

	protected override string _GetTemplateForLabelConfirmPassword()
	{
		return "Xác nhận mật khẩu";
	}

	protected override string _GetTemplateForLabelDay()
	{
		return "Ngày";
	}

	protected override string _GetTemplateForLabelDesiredUsername()
	{
		return "Tên người dùng muốn đặt:";
	}

	protected override string _GetTemplateForLabelFacebookNotLinked()
	{
		return "Tài khoản Facebook của bạn không được liên kết với bất kỳ tài khoản Roblox nào. Vui lòng đăng ký một tài khoản Roblox.";
	}

	protected override string _GetTemplateForLabelFacebookSignupUsername()
	{
		return "Tạo tên người dùng Roblox:";
	}

	protected override string _GetTemplateForLabelFemale()
	{
		return "Nữ";
	}

	protected override string _GetTemplateForLabelGender()
	{
		return "Giới tính";
	}

	protected override string _GetTemplateForLabelGenderRequired()
	{
		return "Cần phải chọn giới tính.";
	}

	protected override string _GetTemplateForLabelGenderWithColumn()
	{
		return "Giới tính:";
	}

	protected override string _GetTemplateForLabelMale()
	{
		return "Nam";
	}

	protected override string _GetTemplateForLabelMonth()
	{
		return "Tháng";
	}

	protected override string _GetTemplateForLabelPassword()
	{
		return "Mật khẩu";
	}

	protected override string _GetTemplateForLabelPasswordRequirements()
	{
		return "Mật khẩu (tối thiểu 8 ký tự)";
	}

	protected override string _GetTemplateForLabelPlatforms()
	{
		return "Nền tảng";
	}

	protected override string _GetTemplateForLabelPlay()
	{
		return "Chơi";
	}

	protected override string _GetTemplateForLabelPleaseAgreeToTerms()
	{
		return "Vui lòng đồng ký với Điều khoản sử dụng và Chính sách riêng tư của chúng tôi.";
	}

	protected override string _GetTemplateForLabelRequired()
	{
		return "Bắt buộc";
	}

	protected override string _GetTemplateForLabelSignupButtonText()
	{
		return "Đăng ký và Chơi!";
	}

	protected override string _GetTemplateForLabelSignUpWith()
	{
		return "hoặc đăng ký bằng";
	}

	protected override string _GetTemplateForLabelTermsOfUse()
	{
		return "Điều khoản sử dụng";
	}

	protected override string _GetTemplateForLabelUsername()
	{
		return "Tên người dùng";
	}

	protected override string _GetTemplateForLabelUsernameCharacterLimit()
	{
		return "Có từ 3-20 chữ cái và chữ số, không chứa ký tự trống.";
	}

	protected override string _GetTemplateForLabelUsernameHint()
	{
		return "Tên người dùng (không dùng tên thật của bạn)";
	}

	protected override string _GetTemplateForLabelUsernameRequirements()
	{
		return "Tên người dùng (từ 3-20 ký tự, _ được cho phép)";
	}

	protected override string _GetTemplateForLabelYear()
	{
		return "Năm";
	}

	protected override string _GetTemplateForMessagePasswordMinLength()
	{
		return "Tối thiểu 8 ký tự";
	}

	protected override string _GetTemplateForMessageUsernameNoRealNameUse()
	{
		return "Không dùng tên thật của bạn";
	}

	protected override string _GetTemplateForResponseBadUsername()
	{
		return "Tên người dùng không phù hợp với Roblox.";
	}

	protected override string _GetTemplateForResponseBadUsernameForWeChat()
	{
		return "Tên người dùng không phù hợp";
	}

	protected override string _GetTemplateForResponseBirthdayInvalid()
	{
		return "Ngày sinh này không hợp lệ.";
	}

	protected override string _GetTemplateForResponseBirthdayMustBeSetFirst()
	{
		return "Phải chọn ngày sinh trước.";
	}

	protected override string _GetTemplateForResponseCaptchaMismatchError()
	{
		return "Các từ không trùng.";
	}

	protected override string _GetTemplateForResponseCaptchaNotEnteredError()
	{
		return "Vui lòng điền mã Captcha";
	}

	protected override string _GetTemplateForResponseFacebookConnectionError()
	{
		return "Xảy ra lỗi khi truy xuất giá trị từ Facebook.";
	}

	protected override string _GetTemplateForResponseFacebookLoginAge()
	{
		return "Chỉ người dùng trên 13 tuổi mới có thể sử dụng đăng nhập bằng Facebook.";
	}

	protected override string _GetTemplateForResponseInvalidBirthday()
	{
		return "Ngày sinh không hợp lệ.";
	}

	protected override string _GetTemplateForResponseInvalidEmail()
	{
		return "Địa chỉ email không hợp lệ.";
	}

	protected override string _GetTemplateForResponseJavaScriptRequired()
	{
		return "Phải bật JavaScript để gửi mẫu này.";
	}

	protected override string _GetTemplateForResponsePasswordComplexity()
	{
		return "Vui lòng tạo mật khẩu khó đoán hơn.";
	}

	protected override string _GetTemplateForResponsePasswordConfirmation()
	{
		return "Vui lòng nhập mật khẩu xác nhận.";
	}

	protected override string _GetTemplateForResponsePasswordContainsUsernameError()
	{
		return "Mật khẩu không nên trùng với tên người dùng.";
	}

	protected override string _GetTemplateForResponsePasswordMismatch()
	{
		return "Mật khẩu không trùng nhau.";
	}

	protected override string _GetTemplateForResponsePasswordWrongShort()
	{
		return "Mật khẩu phải có tối thiểu 8 ký tự.";
	}

	protected override string _GetTemplateForResponsePleaseEnterPassword()
	{
		return "Vui lòng nhập mật khẩu.";
	}

	protected override string _GetTemplateForResponsePleaseEnterUsername()
	{
		return "Vui lòng nhập tên người dùng.";
	}

	protected override string _GetTemplateForResponseSocialAccountCreationFailed()
	{
		return "Không thể tạo tài khoản";
	}

	protected override string _GetTemplateForResponseSpaceOrSpecialCharaterError()
	{
		return "Không được nhập ký tự trống và ký tự đặc biệt.";
	}

	protected override string _GetTemplateForResponseTooManyAccountsWithSameEmailError()
	{
		return "Có quá nhiều tài khoản sử dụng email này.";
	}

	protected override string _GetTemplateForResponseUnknownError()
	{
		return "Rất tiếc! Đã xảy ra lỗi không xác định. Vui lòng thử lại sau.";
	}

	protected override string _GetTemplateForResponseUsernameAllowedCharactersError()
	{
		return "Tên người dùng chỉ được chứa chữ cái, chữ số và ký tự _.";
	}

	protected override string _GetTemplateForResponseUsernameAlreadyInUse()
	{
		return "Tên người dùng đã được sử dụng.";
	}

	protected override string _GetTemplateForResponseUsernameExplicit()
	{
		return "Không thể sử dụng tên này, xin chọn tên khác.";
	}

	protected override string _GetTemplateForResponseUsernameInvalid()
	{
		return "Vui lòng nhập tên người dùng hợp lệ.";
	}

	protected override string _GetTemplateForResponseUsernameInvalidCharacters()
	{
		return "Chỉ được dùng các ký tự a-z, A-Z, 0-9 và ký tự _.";
	}

	protected override string _GetTemplateForResponseUsernameInvalidLength()
	{
		return "Tên người dùng có thể dài từ 3 đến 20 ký tự.";
	}

	protected override string _GetTemplateForResponseUsernameInvalidUnderscore()
	{
		return "Không thể bắt đầu/kết thúc với ký tự _.";
	}

	protected override string _GetTemplateForResponseUsernameNotAvailable()
	{
		return "Tên người dùng không khả dụng. Vui lòng thử lại.";
	}

	protected override string _GetTemplateForResponseUsernameOrPasswordIncorrect()
	{
		return "Sai tên người dùng hoặc mật khẩu.";
	}

	protected override string _GetTemplateForResponseUsernamePasswordRequired()
	{
		return "Phải nhập Mật khẩu và Tên người dùng.";
	}

	protected override string _GetTemplateForResponseUsernamePrivateInfo()
	{
		return "Tên người dùng có thể chứa thông tin cá nhân.";
	}

	protected override string _GetTemplateForResponseUsernameRequired()
	{
		return "Bắt buộc phải có tên người dùng.";
	}

	protected override string _GetTemplateForResponseUsernameTakenTryAgain()
	{
		return "Tên người dùng này đã được sử dụng! Vui lòng thử tên khác.";
	}

	protected override string _GetTemplateForResponseUsernameTooManyUnderscores()
	{
		return "Tên người dùng có thể chứa tối đa một ký tự _.";
	}
}
