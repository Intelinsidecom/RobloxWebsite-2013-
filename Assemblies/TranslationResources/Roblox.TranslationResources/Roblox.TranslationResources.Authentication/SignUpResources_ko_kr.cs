namespace Roblox.TranslationResources.Authentication;

/// <summary>
/// This class overrides SignUpResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class SignUpResources_ko_kr : SignUpResources_en_us, ISignUpResources, ITranslationResources
{
	/// <summary>
	/// Key: "Action.CreateAccount"
	/// create account button label
	/// English String: "Create Account"
	/// </summary>
	public override string ActionCreateAccount => "계정 만들기";

	/// <summary>
	/// Key: "Action.LinkAccount"
	/// Button text to link 3rd Party Account to a Roblox Account
	/// English String: "Link Account"
	/// </summary>
	public override string ActionLinkAccount => "계정 연결";

	/// <summary>
	/// Key: "Action.LogInCapitalized"
	/// button label for capitalized words for Log In
	/// English String: "Log In"
	/// </summary>
	public override string ActionLogInCapitalized => "로그인";

	/// <summary>
	/// Key: "Action.ReturnHome"
	/// button label to return the user to home page
	/// English String: "Return Home"
	/// </summary>
	public override string ActionReturnHome => "홈으로 돌아가기";

	/// <summary>
	/// Key: "Action.SignUp"
	/// English String: "Sign up"
	/// </summary>
	public override string ActionSignUp => "회원가입";

	public override string ActionSignupAndSync => "회원가입 및 동기화";

	/// <summary>
	/// Key: "Action.Submit"
	/// English String: "Submit"
	/// </summary>
	public override string ActionSubmit => "제출";

	/// <summary>
	/// Key: "Description.AccountLinkingWarning"
	/// instructions for linking account on signup page for FB based account
	/// English String: "To link to an existing Roblox account, sign in and link them on the account settings page."
	/// </summary>
	public override string DescriptionAccountLinkingWarning => "기존 Roblox 계정에 연결하려면, 로그인한 후 계정 설정 페이지에서 연결하세요.";

	/// <summary>
	/// Key: "Description.NoRealName"
	/// description
	/// English String: "Do not use your real name."
	/// </summary>
	public override string DescriptionNoRealName => "실명을 사용하지 마세요.";

	/// <summary>
	/// Key: "Description.PrivacyPolicy"
	/// English String: "Privacy Policy"
	/// </summary>
	public override string DescriptionPrivacyPolicy => "개인정보 처리방침";

	/// <summary>
	/// Key: "Description.TermsOfService"
	/// English String: "Terms of Service"
	/// </summary>
	public override string DescriptionTermsOfService => "서비스 약관";

	/// <summary>
	/// Key: "GuestSignUpAB.Action.SignUp"
	/// English String: "Sign Up"
	/// </summary>
	public override string GuestSignUpABActionSignUp => "회원가입";

	/// <summary>
	/// Key: "Heading.ConnectFacebook"
	/// section heading
	/// English String: "Connect to Facebook"
	/// </summary>
	public override string HeadingConnectFacebook => "Facebook에 연결";

	/// <summary>
	/// Key: "Heading.CreateAnAccount"
	/// should be capitalized if the language supports capitalization
	/// English String: "CREATE AN ACCOUNT"
	/// </summary>
	public override string HeadingCreateAnAccount => "계정 만들기";

	/// <summary>
	/// Key: "Heading.LoginHaveFun"
	/// heading for login container
	/// English String: "Log in and start having fun!"
	/// </summary>
	public override string HeadingLoginHaveFun => "로그인하여 즐겨보세요!";

	/// <summary>
	/// Key: "Heading.SignupHaveFun"
	/// signup form heading
	/// English String: "Sign up and start having fun!"
	/// </summary>
	public override string HeadingSignupHaveFun => "가입하시고 즐겨보세요!";

	/// <summary>
	/// Key: "Label.About"
	/// About link on roller coaster page
	/// English String: "About"
	/// </summary>
	public override string LabelAbout => "소개";

	/// <summary>
	/// Key: "Label.AlreadyHaveRobloxAccount"
	/// English String: "Already have a Roblox account?"
	/// </summary>
	public override string LabelAlreadyHaveRobloxAccount => "이미 Roblox 계정이 있으시다구요?";

	/// <summary>
	/// Key: "Label.AlreadyRegistered"
	/// label
	/// English String: "Already registered?"
	/// </summary>
	public override string LabelAlreadyRegistered => "이미 가입하셨나요?";

	/// <summary>
	/// Key: "Label.Birthday"
	/// English String: "Birthday"
	/// </summary>
	public override string LabelBirthday => "생년월일";

	/// <summary>
	/// Key: "Label.BirthdayWithColumn"
	/// should have column if the language supports it
	/// English String: "Birthday:"
	/// </summary>
	public override string LabelBirthdayWithColumn => "생년월일:";

	/// <summary>
	/// Key: "Label.ConfirmPassword"
	/// English String: "Confirm password"
	/// </summary>
	public override string LabelConfirmPassword => "비밀번호 확인";

	/// <summary>
	/// Key: "Label.Day"
	/// English String: "Day"
	/// </summary>
	public override string LabelDay => "일";

	/// <summary>
	/// Key: "Label.DesiredUsername"
	/// should have a column if the language supports it
	/// English String: "Desired Username:"
	/// </summary>
	public override string LabelDesiredUsername => "희망하는 사용자 이름:";

	/// <summary>
	/// Key: "Label.FacebookNotLinked"
	/// English String: "Your Facebook account is not linked to any Roblox account. Please sign up for a Roblox account."
	/// </summary>
	public override string LabelFacebookNotLinked => "사용자의 Facebook 계정과 연결된 Roblox 계정이 없습니다. 가입하여 Roblox 계정을 만들어 보세요.";

	/// <summary>
	/// Key: "Label.FacebookSignupUsername"
	/// username field label for FB signup
	/// English String: "Create Roblox username:"
	/// </summary>
	public override string LabelFacebookSignupUsername => "Roblox 사용자 이름 만들기:";

	/// <summary>
	/// Key: "Label.Female"
	/// label
	/// English String: "Female"
	/// </summary>
	public override string LabelFemale => "여성";

	/// <summary>
	/// Key: "Label.Gender"
	/// English String: "Gender"
	/// </summary>
	public override string LabelGender => "성별";

	/// <summary>
	/// Key: "Label.GenderRequired"
	/// English String: "Gender is required."
	/// </summary>
	public override string LabelGenderRequired => "성별을 선택하세요.";

	/// <summary>
	/// Key: "Label.GenderWithColumn"
	/// should have column if the language supports it
	/// English String: "Gender:"
	/// </summary>
	public override string LabelGenderWithColumn => "성별:";

	/// <summary>
	/// Key: "Label.Male"
	/// label
	/// English String: "Male"
	/// </summary>
	public override string LabelMale => "남성";

	/// <summary>
	/// Key: "Label.Month"
	/// English String: "Month"
	/// </summary>
	public override string LabelMonth => "월";

	/// <summary>
	/// Key: "Label.Password"
	/// English String: "Password"
	/// </summary>
	public override string LabelPassword => "비밀번호";

	/// <summary>
	/// Key: "Label.PasswordRequirements"
	/// English String: "Password (min length 8)"
	/// </summary>
	public override string LabelPasswordRequirements => "비밀번호 (8자 이상)";

	/// <summary>
	/// Key: "Label.Platforms"
	/// platforms link on roller coaster page
	/// English String: "Platforms"
	/// </summary>
	public override string LabelPlatforms => "플랫폼";

	/// <summary>
	/// Key: "Label.Play"
	/// Play link on roller coaster page
	/// English String: "Play"
	/// </summary>
	public override string LabelPlay => "플레이";

	/// <summary>
	/// Key: "Label.PleaseAgreeToTerms"
	/// English String: "Please agree to our Terms of Use and Privacy Policy."
	/// </summary>
	public override string LabelPleaseAgreeToTerms => "이용 약관 및 개인정보 처리방침에 동의하시기 바랍니다.";

	/// <summary>
	/// Key: "Label.Required"
	/// Required
	/// English String: "Required"
	/// </summary>
	public override string LabelRequired => "필수";

	/// <summary>
	/// Key: "Label.SignupButtonText"
	/// sign up button text
	/// English String: "Sign Up and Play!"
	/// </summary>
	public override string LabelSignupButtonText => "회원가입하시고 플레이하세요!";

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
	public override string LabelSignUpWith => "또는 다음 방법으로 가입하기";

	/// <summary>
	/// Key: "Label.TermsOfUse"
	/// terms of use link label
	/// English String: "Terms of Use"
	/// </summary>
	public override string LabelTermsOfUse => "이용 약관";

	/// <summary>
	/// Key: "Label.Username"
	/// English String: "Username"
	/// </summary>
	public override string LabelUsername => "사용자 이름";

	/// <summary>
	/// Key: "Label.UsernameCharacterLimit"
	/// label
	/// English String: "3-20 alphanumeric characters, no spaces."
	/// </summary>
	public override string LabelUsernameCharacterLimit => "3-20자의 영숫자만 사용할 수 있습니다. 공백은 사용할 수 없습니다.";

	/// <summary>
	/// Key: "Label.UsernameHint"
	/// placeholder for username field
	/// English String: "Username (don't use your real name)"
	/// </summary>
	public override string LabelUsernameHint => "사용자 이름 (실명을 사용하지 마세요)";

	/// <summary>
	/// Key: "Label.UsernameRequirements"
	/// English String: "Username (length 3-20, _ is allowed)"
	/// </summary>
	public override string LabelUsernameRequirements => "사용자 이름 (3~20자, _ 사용 가능)";

	/// <summary>
	/// Key: "Label.Year"
	/// English String: "Year"
	/// </summary>
	public override string LabelYear => "년";

	/// <summary>
	/// Key: "Message.Password.MinLength"
	/// English String: "Min length 8"
	/// </summary>
	public override string MessagePasswordMinLength => "8자 이상";

	/// <summary>
	/// Key: "Message.Username.NoRealNameUse"
	/// English String: "Don't use your real name"
	/// </summary>
	public override string MessageUsernameNoRealNameUse => "실명을 사용하지 마세요";

	/// <summary>
	/// Key: "Response.BadUsername"
	/// English String: "Username not appropriate for Roblox."
	/// </summary>
	public override string ResponseBadUsername => "Roblox에 적합하지 않은 사용자 이름입니다.";

	/// <summary>
	/// Key: "Response.BadUsernameForWeChat"
	/// message shown when signing up with an inappropriate username
	/// English String: "Username is not appropriate"
	/// </summary>
	public override string ResponseBadUsernameForWeChat => "적합하지 않은 사용자 이름입니다.";

	/// <summary>
	/// Key: "Response.BirthdayInvalid"
	/// English String: "This birthday is invalid."
	/// </summary>
	public override string ResponseBirthdayInvalid => "유효하지 않은 생년월일입니다.";

	/// <summary>
	/// Key: "Response.BirthdayMustBeSetFirst"
	/// English String: "Birthday must be set first."
	/// </summary>
	public override string ResponseBirthdayMustBeSetFirst => "먼저 생년월일을 설정해야 합니다.";

	/// <summary>
	/// Key: "Response.CaptchaMismatchError"
	/// error message
	/// English String: "Words do not match."
	/// </summary>
	public override string ResponseCaptchaMismatchError => "단어가 일치하지 않습니다.";

	/// <summary>
	/// Key: "Response.CaptchaNotEnteredError"
	/// validation error message
	/// English String: "Please fill out the Captcha"
	/// </summary>
	public override string ResponseCaptchaNotEnteredError => "보안 문자를 입력하세요";

	/// <summary>
	/// Key: "Response.FacebookConnectionError"
	/// error message
	/// English String: "Error while retrieving values from Facebook."
	/// </summary>
	public override string ResponseFacebookConnectionError => "Facebook에서 값을 받는 중 오류가 발생했어요.";

	/// <summary>
	/// Key: "Response.FacebookLoginAge"
	/// English String: "Facebook login can only be used by users above 13."
	/// </summary>
	public override string ResponseFacebookLoginAge => "만 13세 이상만 Facebook에 로그인할 수 있어요.";

	/// <summary>
	/// Key: "Response.InvalidBirthday"
	/// English String: "Invalid birthday."
	/// </summary>
	public override string ResponseInvalidBirthday => "유효하지 않은 생년월일";

	/// <summary>
	/// Key: "Response.InvalidEmail"
	/// English String: "Invalid email address."
	/// </summary>
	public override string ResponseInvalidEmail => "유효하지 않은 이메일 주소.";

	/// <summary>
	/// Key: "Response.JavaScriptRequired"
	/// error to show that JavaScipt is required for the form to work
	/// English String: "JavaScript is required to submit this form."
	/// </summary>
	public override string ResponseJavaScriptRequired => "본 양식을 제출하려면 JavaScript가 필요합니다.";

	/// <summary>
	/// Key: "Response.PasswordComplexity"
	/// English String: "Please create a more complex password."
	/// </summary>
	public override string ResponsePasswordComplexity => "좀 더 복잡한 비밀번호를 만드세요.";

	/// <summary>
	/// Key: "Response.PasswordConfirmation"
	/// validation message for password confirmation
	/// English String: "Please enter a password confirmation."
	/// </summary>
	public override string ResponsePasswordConfirmation => "비밀번호를 다시 한 번 입력하세요.";

	/// <summary>
	/// Key: "Response.PasswordContainsUsernameError"
	/// error when passsword has username in it
	/// English String: "Password shouldn't match username."
	/// </summary>
	public override string ResponsePasswordContainsUsernameError => "비밀번호는 사용자 이름과 같을 수 없습니다.";

	/// <summary>
	/// Key: "Response.PasswordMismatch"
	/// English String: "Passwords do not match."
	/// </summary>
	public override string ResponsePasswordMismatch => "비밀번호가 일치하지 않습니다.";

	/// <summary>
	/// Key: "Response.PasswordWrongShort"
	/// English String: "Passwords must be at least 8 characters long."
	/// </summary>
	public override string ResponsePasswordWrongShort => "비밀번호는 8자 이상이어야 합니다.";

	/// <summary>
	/// Key: "Response.PleaseEnterPassword"
	/// English String: "Please enter a password."
	/// </summary>
	public override string ResponsePleaseEnterPassword => "비밀번호를 입력하세요.";

	/// <summary>
	/// Key: "Response.PleaseEnterUsername"
	/// English String: "Please enter a username."
	/// </summary>
	public override string ResponsePleaseEnterUsername => "사용자 이름을 입력하세요.";

	/// <summary>
	/// Key: "Response.SocialAccountCreationFailed"
	/// error message
	/// English String: "Account creation failed"
	/// </summary>
	public override string ResponseSocialAccountCreationFailed => "계정 만들기 실패";

	/// <summary>
	/// Key: "Response.SpaceOrSpecialCharaterError"
	/// Spaces and special characters are not allowed error message
	/// English String: "Spaces and special characters are not allowed."
	/// </summary>
	public override string ResponseSpaceOrSpecialCharaterError => "공백 및 특수 문자는 사용할 수 없습니다.";

	/// <summary>
	/// Key: "Response.TooManyAccountsWithSameEmailError"
	/// Too many accounts use this email error message
	/// English String: "Too many accounts use this email."
	/// </summary>
	public override string ResponseTooManyAccountsWithSameEmailError => "너무 많은 계정이 본 이메일을 사용합니다.";

	/// <summary>
	/// Key: "Response.UnknownError"
	/// English String: "Sorry! An unknown error occurred. Please try again later."
	/// </summary>
	public override string ResponseUnknownError => "죄송합니다!\u00a0알 수 없는 오류가 발생했어요.\u00a0나중에 다시 시도하세요.";

	/// <summary>
	/// Key: "Response.UsernameAllowedCharactersError"
	/// error showing which characters are allowed for username
	/// English String: "Usernames may only contain letters, numbers, and _."
	/// </summary>
	public override string ResponseUsernameAllowedCharactersError => "사용자 이름에는 알파벳, 숫자 및 _만 사용할 수 있습니다.";

	/// <summary>
	/// Key: "Response.UsernameAlreadyInUse"
	/// English String: "This username is already in use."
	/// </summary>
	public override string ResponseUsernameAlreadyInUse => "이미 사용 중인 사용자 이름입니다.";

	/// <summary>
	/// Key: "Response.UsernameExplicit"
	/// English String: "This username is not allowed, please try another."
	/// </summary>
	public override string ResponseUsernameExplicit => "사용할 수 없는 사용자 이름입니다. 다시 시도하세요.";

	/// <summary>
	/// Key: "Response.UsernameInvalid"
	/// English String: "Please enter a valid username."
	/// </summary>
	public override string ResponseUsernameInvalid => "유효한 사용자 이름을 입력하세요.";

	/// <summary>
	/// Key: "Response.UsernameInvalidCharacters"
	/// English String: "Only a-z, A-Z, 0-9 and _ are allowed."
	/// </summary>
	public override string ResponseUsernameInvalidCharacters => "a-z, A-Z, 0-9 및 _만 사용할 수 있습니다.";

	/// <summary>
	/// Key: "Response.UsernameInvalidLength"
	/// English String: "Usernames can be 3 to 20 characters long."
	/// </summary>
	public override string ResponseUsernameInvalidLength => "사용자 이름은 3~20자로 구성됩니다.";

	/// <summary>
	/// Key: "Response.UsernameInvalidUnderscore"
	/// English String: "Usernames cannot start or end with _."
	/// </summary>
	public override string ResponseUsernameInvalidUnderscore => "사용자 이름은 _으로 시작하거나 끝날 수 없습니다.";

	/// <summary>
	/// Key: "Response.UsernameNotAvailable"
	/// English String: "Username not available. Please try again."
	/// </summary>
	public override string ResponseUsernameNotAvailable => "사용할 수 없는 사용자 이름. 다시 시도하세요.";

	/// <summary>
	/// Key: "Response.UsernameOrPasswordIncorrect"
	/// Your username or password is incorrect
	/// English String: "Your username or password is incorrect."
	/// </summary>
	public override string ResponseUsernameOrPasswordIncorrect => "사용자 이름 또는 비밀번호가 일치하지 않습니다.";

	/// <summary>
	/// Key: "Response.UsernamePasswordRequired"
	/// Username and Password are required error message
	/// English String: "Username and Password are required."
	/// </summary>
	public override string ResponseUsernamePasswordRequired => "사용자 이름 및 비밀번호가 필요합니다.";

	/// <summary>
	/// Key: "Response.UsernamePrivateInfo"
	/// English String: "Username might contain private information."
	/// </summary>
	public override string ResponseUsernamePrivateInfo => "사용자 이름에 개인 정보가 포함될 수도 있습니다.";

	/// <summary>
	/// Key: "Response.UsernameRequired"
	/// validation error message
	/// English String: "Username is required."
	/// </summary>
	public override string ResponseUsernameRequired => "사용자 이름은 필수입니다.";

	/// <summary>
	/// Key: "Response.UsernameTakenTryAgain"
	/// English String: "This username is already taken! Please try a different one."
	/// </summary>
	public override string ResponseUsernameTakenTryAgain => "이미 사용 중인 사용자 이름입니다!\u00a0다른 이름을 사용하세요.";

	/// <summary>
	/// Key: "Response.UsernameTooManyUnderscores"
	/// English String: "Usernames can have at most one _."
	/// </summary>
	public override string ResponseUsernameTooManyUnderscores => "사용자 이름은 _을 하나만 포함할 수 있습니다.";

	public SignUpResources_ko_kr(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionCreateAccount()
	{
		return "계정 만들기";
	}

	protected override string _GetTemplateForActionLinkAccount()
	{
		return "계정 연결";
	}

	protected override string _GetTemplateForActionLogInCapitalized()
	{
		return "로그인";
	}

	protected override string _GetTemplateForActionReturnHome()
	{
		return "홈으로 돌아가기";
	}

	protected override string _GetTemplateForActionSignUp()
	{
		return "회원가입";
	}

	protected override string _GetTemplateForActionSignupAndSync()
	{
		return "회원가입 및 동기화";
	}

	protected override string _GetTemplateForActionSubmit()
	{
		return "제출";
	}

	protected override string _GetTemplateForDescriptionAccountLinkingWarning()
	{
		return "기존 Roblox 계정에 연결하려면, 로그인한 후 계정 설정 페이지에서 연결하세요.";
	}

	protected override string _GetTemplateForDescriptionNoRealName()
	{
		return "실명을 사용하지 마세요.";
	}

	protected override string _GetTemplateForDescriptionPrivacyPolicy()
	{
		return "개인정보 처리방침";
	}

	/// <summary>
	/// Key: "Description.SignUpAgreement"
	/// terms of use agreement checkbox label to signup.
	/// English String: "By clicking {spanStart}Sign Up{spanEnd}, you are agreeing to the {termsOfUseLink} and acknowledging the {privacyPolicyLink}"
	/// </summary>
	public override string DescriptionSignUpAgreement(string spanStart, string spanEnd, string termsOfUseLink, string privacyPolicyLink)
	{
		return $"{spanStart}회원가입{spanEnd}을 클릭하면 {termsOfUseLink}에 동의하고 {privacyPolicyLink}을(를) 승낙하는 것으로 간주됩니다.";
	}

	protected override string _GetTemplateForDescriptionSignUpAgreement()
	{
		return "{spanStart}회원가입{spanEnd}을 클릭하면 {termsOfUseLink}에 동의하고 {privacyPolicyLink}을(를) 승낙하는 것으로 간주됩니다.";
	}

	protected override string _GetTemplateForDescriptionTermsOfService()
	{
		return "서비스 약관";
	}

	protected override string _GetTemplateForGuestSignUpABActionSignUp()
	{
		return "회원가입";
	}

	protected override string _GetTemplateForHeadingConnectFacebook()
	{
		return "Facebook에 연결";
	}

	protected override string _GetTemplateForHeadingCreateAnAccount()
	{
		return "계정 만들기";
	}

	/// <summary>
	/// Key: "Heading.FacebookSignupAlmostDone"
	/// when user signs up using Facebook, this is shown in next step to create a password.
	/// English String: "{firstname}, YOU'RE ALMOST DONE"
	/// </summary>
	public override string HeadingFacebookSignupAlmostDone(string firstname)
	{
		return $"{firstname} 님, 거의 끝났어요.";
	}

	protected override string _GetTemplateForHeadingFacebookSignupAlmostDone()
	{
		return "{firstname} 님, 거의 끝났어요.";
	}

	protected override string _GetTemplateForHeadingLoginHaveFun()
	{
		return "로그인하여 즐겨보세요!";
	}

	protected override string _GetTemplateForHeadingSignupHaveFun()
	{
		return "가입하시고 즐겨보세요!";
	}

	protected override string _GetTemplateForLabelAbout()
	{
		return "소개";
	}

	protected override string _GetTemplateForLabelAlreadyHaveRobloxAccount()
	{
		return "이미 Roblox 계정이 있으시다구요?";
	}

	protected override string _GetTemplateForLabelAlreadyRegistered()
	{
		return "이미 가입하셨나요?";
	}

	protected override string _GetTemplateForLabelBirthday()
	{
		return "생년월일";
	}

	protected override string _GetTemplateForLabelBirthdayWithColumn()
	{
		return "생년월일:";
	}

	protected override string _GetTemplateForLabelConfirmPassword()
	{
		return "비밀번호 확인";
	}

	protected override string _GetTemplateForLabelDay()
	{
		return "일";
	}

	protected override string _GetTemplateForLabelDesiredUsername()
	{
		return "희망하는 사용자 이름:";
	}

	protected override string _GetTemplateForLabelFacebookNotLinked()
	{
		return "사용자의 Facebook 계정과 연결된 Roblox 계정이 없습니다. 가입하여 Roblox 계정을 만들어 보세요.";
	}

	protected override string _GetTemplateForLabelFacebookSignupUsername()
	{
		return "Roblox 사용자 이름 만들기:";
	}

	protected override string _GetTemplateForLabelFemale()
	{
		return "여성";
	}

	protected override string _GetTemplateForLabelGender()
	{
		return "성별";
	}

	protected override string _GetTemplateForLabelGenderRequired()
	{
		return "성별을 선택하세요.";
	}

	protected override string _GetTemplateForLabelGenderWithColumn()
	{
		return "성별:";
	}

	protected override string _GetTemplateForLabelMale()
	{
		return "남성";
	}

	protected override string _GetTemplateForLabelMonth()
	{
		return "월";
	}

	protected override string _GetTemplateForLabelPassword()
	{
		return "비밀번호";
	}

	protected override string _GetTemplateForLabelPasswordRequirements()
	{
		return "비밀번호 (8자 이상)";
	}

	protected override string _GetTemplateForLabelPlatforms()
	{
		return "플랫폼";
	}

	protected override string _GetTemplateForLabelPlay()
	{
		return "플레이";
	}

	protected override string _GetTemplateForLabelPleaseAgreeToTerms()
	{
		return "이용 약관 및 개인정보 처리방침에 동의하시기 바랍니다.";
	}

	protected override string _GetTemplateForLabelRequired()
	{
		return "필수";
	}

	protected override string _GetTemplateForLabelSignupButtonText()
	{
		return "회원가입하시고 플레이하세요!";
	}

	protected override string _GetTemplateForLabelSignUpWith()
	{
		return "또는 다음 방법으로 가입하기";
	}

	protected override string _GetTemplateForLabelTermsOfUse()
	{
		return "이용 약관";
	}

	protected override string _GetTemplateForLabelUsername()
	{
		return "사용자 이름";
	}

	protected override string _GetTemplateForLabelUsernameCharacterLimit()
	{
		return "3-20자의 영숫자만 사용할 수 있습니다. 공백은 사용할 수 없습니다.";
	}

	protected override string _GetTemplateForLabelUsernameHint()
	{
		return "사용자 이름 (실명을 사용하지 마세요)";
	}

	protected override string _GetTemplateForLabelUsernameRequirements()
	{
		return "사용자 이름 (3~20자, _ 사용 가능)";
	}

	protected override string _GetTemplateForLabelYear()
	{
		return "년";
	}

	protected override string _GetTemplateForMessagePasswordMinLength()
	{
		return "8자 이상";
	}

	protected override string _GetTemplateForMessageUsernameNoRealNameUse()
	{
		return "실명을 사용하지 마세요";
	}

	protected override string _GetTemplateForResponseBadUsername()
	{
		return "Roblox에 적합하지 않은 사용자 이름입니다.";
	}

	protected override string _GetTemplateForResponseBadUsernameForWeChat()
	{
		return "적합하지 않은 사용자 이름입니다.";
	}

	protected override string _GetTemplateForResponseBirthdayInvalid()
	{
		return "유효하지 않은 생년월일입니다.";
	}

	protected override string _GetTemplateForResponseBirthdayMustBeSetFirst()
	{
		return "먼저 생년월일을 설정해야 합니다.";
	}

	protected override string _GetTemplateForResponseCaptchaMismatchError()
	{
		return "단어가 일치하지 않습니다.";
	}

	protected override string _GetTemplateForResponseCaptchaNotEnteredError()
	{
		return "보안 문자를 입력하세요";
	}

	protected override string _GetTemplateForResponseFacebookConnectionError()
	{
		return "Facebook에서 값을 받는 중 오류가 발생했어요.";
	}

	protected override string _GetTemplateForResponseFacebookLoginAge()
	{
		return "만 13세 이상만 Facebook에 로그인할 수 있어요.";
	}

	protected override string _GetTemplateForResponseInvalidBirthday()
	{
		return "유효하지 않은 생년월일";
	}

	protected override string _GetTemplateForResponseInvalidEmail()
	{
		return "유효하지 않은 이메일 주소.";
	}

	protected override string _GetTemplateForResponseJavaScriptRequired()
	{
		return "본 양식을 제출하려면 JavaScript가 필요합니다.";
	}

	protected override string _GetTemplateForResponsePasswordComplexity()
	{
		return "좀 더 복잡한 비밀번호를 만드세요.";
	}

	protected override string _GetTemplateForResponsePasswordConfirmation()
	{
		return "비밀번호를 다시 한 번 입력하세요.";
	}

	protected override string _GetTemplateForResponsePasswordContainsUsernameError()
	{
		return "비밀번호는 사용자 이름과 같을 수 없습니다.";
	}

	protected override string _GetTemplateForResponsePasswordMismatch()
	{
		return "비밀번호가 일치하지 않습니다.";
	}

	protected override string _GetTemplateForResponsePasswordWrongShort()
	{
		return "비밀번호는 8자 이상이어야 합니다.";
	}

	protected override string _GetTemplateForResponsePleaseEnterPassword()
	{
		return "비밀번호를 입력하세요.";
	}

	protected override string _GetTemplateForResponsePleaseEnterUsername()
	{
		return "사용자 이름을 입력하세요.";
	}

	protected override string _GetTemplateForResponseSocialAccountCreationFailed()
	{
		return "계정 만들기 실패";
	}

	protected override string _GetTemplateForResponseSpaceOrSpecialCharaterError()
	{
		return "공백 및 특수 문자는 사용할 수 없습니다.";
	}

	protected override string _GetTemplateForResponseTooManyAccountsWithSameEmailError()
	{
		return "너무 많은 계정이 본 이메일을 사용합니다.";
	}

	protected override string _GetTemplateForResponseUnknownError()
	{
		return "죄송합니다!\u00a0알 수 없는 오류가 발생했어요.\u00a0나중에 다시 시도하세요.";
	}

	protected override string _GetTemplateForResponseUsernameAllowedCharactersError()
	{
		return "사용자 이름에는 알파벳, 숫자 및 _만 사용할 수 있습니다.";
	}

	protected override string _GetTemplateForResponseUsernameAlreadyInUse()
	{
		return "이미 사용 중인 사용자 이름입니다.";
	}

	protected override string _GetTemplateForResponseUsernameExplicit()
	{
		return "사용할 수 없는 사용자 이름입니다. 다시 시도하세요.";
	}

	protected override string _GetTemplateForResponseUsernameInvalid()
	{
		return "유효한 사용자 이름을 입력하세요.";
	}

	protected override string _GetTemplateForResponseUsernameInvalidCharacters()
	{
		return "a-z, A-Z, 0-9 및 _만 사용할 수 있습니다.";
	}

	protected override string _GetTemplateForResponseUsernameInvalidLength()
	{
		return "사용자 이름은 3~20자로 구성됩니다.";
	}

	protected override string _GetTemplateForResponseUsernameInvalidUnderscore()
	{
		return "사용자 이름은 _으로 시작하거나 끝날 수 없습니다.";
	}

	protected override string _GetTemplateForResponseUsernameNotAvailable()
	{
		return "사용할 수 없는 사용자 이름. 다시 시도하세요.";
	}

	protected override string _GetTemplateForResponseUsernameOrPasswordIncorrect()
	{
		return "사용자 이름 또는 비밀번호가 일치하지 않습니다.";
	}

	protected override string _GetTemplateForResponseUsernamePasswordRequired()
	{
		return "사용자 이름 및 비밀번호가 필요합니다.";
	}

	protected override string _GetTemplateForResponseUsernamePrivateInfo()
	{
		return "사용자 이름에 개인 정보가 포함될 수도 있습니다.";
	}

	protected override string _GetTemplateForResponseUsernameRequired()
	{
		return "사용자 이름은 필수입니다.";
	}

	protected override string _GetTemplateForResponseUsernameTakenTryAgain()
	{
		return "이미 사용 중인 사용자 이름입니다!\u00a0다른 이름을 사용하세요.";
	}

	protected override string _GetTemplateForResponseUsernameTooManyUnderscores()
	{
		return "사용자 이름은 _을 하나만 포함할 수 있습니다.";
	}
}
