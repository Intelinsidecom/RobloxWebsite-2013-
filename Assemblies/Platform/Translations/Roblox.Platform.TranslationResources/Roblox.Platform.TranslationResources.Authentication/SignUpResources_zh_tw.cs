namespace Roblox.TranslationResources.Authentication;

/// <summary>
/// This class overrides SignUpResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class SignUpResources_zh_tw : SignUpResources_en_us, ISignUpResources, ITranslationResources
{
	/// <summary>
	/// Key: "Action.CreateAccount"
	/// create account button label
	/// English String: "Create Account"
	/// </summary>
	public override string ActionCreateAccount => "建立帳號";

	/// <summary>
	/// Key: "Action.LinkAccount"
	/// Button text to link 3rd Party Account to a Roblox Account
	/// English String: "Link Account"
	/// </summary>
	public override string ActionLinkAccount => "連結帳號";

	/// <summary>
	/// Key: "Action.LogInCapitalized"
	/// button label for capitalized words for Log In
	/// English String: "Log In"
	/// </summary>
	public override string ActionLogInCapitalized => "登入";

	/// <summary>
	/// Key: "Action.ReturnHome"
	/// button label to return the user to home page
	/// English String: "Return Home"
	/// </summary>
	public override string ActionReturnHome => "返回首頁";

	/// <summary>
	/// Key: "Action.SignUp"
	/// English String: "Sign up"
	/// </summary>
	public override string ActionSignUp => "註冊";

	public override string ActionSignupAndSync => "註冊並同步";

	/// <summary>
	/// Key: "Action.Submit"
	/// English String: "Submit"
	/// </summary>
	public override string ActionSubmit => "提交";

	/// <summary>
	/// Key: "Description.AccountLinkingWarning"
	/// instructions for linking account on signup page for FB based account
	/// English String: "To link to an existing Roblox account, sign in and link them on the account settings page."
	/// </summary>
	public override string DescriptionAccountLinkingWarning => "若要連接已建立的 Roblox 帳號，請登入並前往帳號設定頁面進行連接。";

	/// <summary>
	/// Key: "Description.NoRealName"
	/// description
	/// English String: "Do not use your real name."
	/// </summary>
	public override string DescriptionNoRealName => "請勿填寫您的真實姓名。";

	/// <summary>
	/// Key: "Description.PrivacyPolicy"
	/// English String: "Privacy Policy"
	/// </summary>
	public override string DescriptionPrivacyPolicy => "隱私權政策";

	/// <summary>
	/// Key: "Description.TermsOfService"
	/// English String: "Terms of Service"
	/// </summary>
	public override string DescriptionTermsOfService => "服務條款";

	/// <summary>
	/// Key: "GuestSignUpAB.Action.SignUp"
	/// English String: "Sign Up"
	/// </summary>
	public override string GuestSignUpABActionSignUp => "註冊";

	/// <summary>
	/// Key: "Heading.ConnectFacebook"
	/// section heading
	/// English String: "Connect to Facebook"
	/// </summary>
	public override string HeadingConnectFacebook => "連線到 Facebook";

	/// <summary>
	/// Key: "Heading.CreateAnAccount"
	/// should be capitalized if the language supports capitalization
	/// English String: "CREATE AN ACCOUNT"
	/// </summary>
	public override string HeadingCreateAnAccount => "建立帳號";

	/// <summary>
	/// Key: "Heading.LoginHaveFun"
	/// heading for login container
	/// English String: "Log in and start having fun!"
	/// </summary>
	public override string HeadingLoginHaveFun => "登入帳號，開始遊樂！";

	/// <summary>
	/// Key: "Heading.SignupHaveFun"
	/// signup form heading
	/// English String: "Sign up and start having fun!"
	/// </summary>
	public override string HeadingSignupHaveFun => "註冊帳號，開始遊樂！";

	/// <summary>
	/// Key: "Label.About"
	/// About link on roller coaster page
	/// English String: "About"
	/// </summary>
	public override string LabelAbout => "介紹";

	/// <summary>
	/// Key: "Label.AlreadyHaveRobloxAccount"
	/// English String: "Already have a Roblox account?"
	/// </summary>
	public override string LabelAlreadyHaveRobloxAccount => "有 Roblox 帳號了嗎？";

	/// <summary>
	/// Key: "Label.AlreadyRegistered"
	/// label
	/// English String: "Already registered?"
	/// </summary>
	public override string LabelAlreadyRegistered => "已經註冊？";

	/// <summary>
	/// Key: "Label.Birthday"
	/// English String: "Birthday"
	/// </summary>
	public override string LabelBirthday => "生日";

	/// <summary>
	/// Key: "Label.BirthdayWithColumn"
	/// should have column if the language supports it
	/// English String: "Birthday:"
	/// </summary>
	public override string LabelBirthdayWithColumn => "生日：";

	/// <summary>
	/// Key: "Label.ConfirmPassword"
	/// English String: "Confirm password"
	/// </summary>
	public override string LabelConfirmPassword => "確認密碼";

	/// <summary>
	/// Key: "Label.Day"
	/// English String: "Day"
	/// </summary>
	public override string LabelDay => "日";

	/// <summary>
	/// Key: "Label.DesiredUsername"
	/// should have a column if the language supports it
	/// English String: "Desired Username:"
	/// </summary>
	public override string LabelDesiredUsername => "欲使用的使用者名稱：";

	/// <summary>
	/// Key: "Label.FacebookNotLinked"
	/// English String: "Your Facebook account is not linked to any Roblox account. Please sign up for a Roblox account."
	/// </summary>
	public override string LabelFacebookNotLinked => "您的 Facebook 帳號沒有連接 Roblox 帳號，請註冊新的 Roblox 帳號。";

	/// <summary>
	/// Key: "Label.FacebookSignupUsername"
	/// username field label for FB signup
	/// English String: "Create Roblox username:"
	/// </summary>
	public override string LabelFacebookSignupUsername => "建立 Roblox 使用者名稱：";

	/// <summary>
	/// Key: "Label.Female"
	/// label
	/// English String: "Female"
	/// </summary>
	public override string LabelFemale => "女";

	/// <summary>
	/// Key: "Label.Gender"
	/// English String: "Gender"
	/// </summary>
	public override string LabelGender => "性別";

	/// <summary>
	/// Key: "Label.GenderRequired"
	/// English String: "Gender is required."
	/// </summary>
	public override string LabelGenderRequired => "性別必填。";

	/// <summary>
	/// Key: "Label.GenderWithColumn"
	/// should have column if the language supports it
	/// English String: "Gender:"
	/// </summary>
	public override string LabelGenderWithColumn => "性別：";

	/// <summary>
	/// Key: "Label.Male"
	/// label
	/// English String: "Male"
	/// </summary>
	public override string LabelMale => "男";

	/// <summary>
	/// Key: "Label.Month"
	/// English String: "Month"
	/// </summary>
	public override string LabelMonth => "月";

	/// <summary>
	/// Key: "Label.Password"
	/// English String: "Password"
	/// </summary>
	public override string LabelPassword => "密碼";

	/// <summary>
	/// Key: "Label.PasswordRequirements"
	/// English String: "Password (min length 8)"
	/// </summary>
	public override string LabelPasswordRequirements => "密碼（至少 8 個字元）";

	/// <summary>
	/// Key: "Label.Platforms"
	/// platforms link on roller coaster page
	/// English String: "Platforms"
	/// </summary>
	public override string LabelPlatforms => "平台";

	/// <summary>
	/// Key: "Label.Play"
	/// Play link on roller coaster page
	/// English String: "Play"
	/// </summary>
	public override string LabelPlay => "開始玩";

	/// <summary>
	/// Key: "Label.PleaseAgreeToTerms"
	/// English String: "Please agree to our Terms of Use and Privacy Policy."
	/// </summary>
	public override string LabelPleaseAgreeToTerms => "請同意我們的使用條款和隱私權政策。";

	/// <summary>
	/// Key: "Label.Required"
	/// Required
	/// English String: "Required"
	/// </summary>
	public override string LabelRequired => "必填";

	/// <summary>
	/// Key: "Label.SignupButtonText"
	/// sign up button text
	/// English String: "Sign Up and Play!"
	/// </summary>
	public override string LabelSignupButtonText => "註冊帳號，開始遊玩！";

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
	public override string LabelSignUpWith => "或使用";

	/// <summary>
	/// Key: "Label.TermsOfUse"
	/// terms of use link label
	/// English String: "Terms of Use"
	/// </summary>
	public override string LabelTermsOfUse => "使用條款";

	/// <summary>
	/// Key: "Label.Username"
	/// English String: "Username"
	/// </summary>
	public override string LabelUsername => "使用者名稱";

	/// <summary>
	/// Key: "Label.UsernameCharacterLimit"
	/// label
	/// English String: "3-20 alphanumeric characters, no spaces."
	/// </summary>
	public override string LabelUsernameCharacterLimit => "3 到 20 個英數字元，不可使用空格。";

	/// <summary>
	/// Key: "Label.UsernameHint"
	/// placeholder for username field
	/// English String: "Username (don't use your real name)"
	/// </summary>
	public override string LabelUsernameHint => "使用者名稱（請勿填寫您的真實姓名）";

	/// <summary>
	/// Key: "Label.UsernameRequirements"
	/// English String: "Username (length 3-20, _ is allowed)"
	/// </summary>
	public override string LabelUsernameRequirements => "使用者名稱（ 3 到 20 個字母或數字，可使用 _）";

	/// <summary>
	/// Key: "Label.Year"
	/// English String: "Year"
	/// </summary>
	public override string LabelYear => "年";

	/// <summary>
	/// Key: "Message.Password.MinLength"
	/// English String: "Min length 8"
	/// </summary>
	public override string MessagePasswordMinLength => "8 個字元以上";

	/// <summary>
	/// Key: "Message.Username.NoRealNameUse"
	/// English String: "Don't use your real name"
	/// </summary>
	public override string MessageUsernameNoRealNameUse => "請勿使用您的真實姓名";

	/// <summary>
	/// Key: "Response.BadUsername"
	/// English String: "Username not appropriate for Roblox."
	/// </summary>
	public override string ResponseBadUsername => "此使用者名稱含有不當內容。";

	/// <summary>
	/// Key: "Response.BadUsernameForWeChat"
	/// message shown when signing up with an inappropriate username
	/// English String: "Username is not appropriate"
	/// </summary>
	public override string ResponseBadUsernameForWeChat => "使用者名稱不當";

	/// <summary>
	/// Key: "Response.BirthdayInvalid"
	/// English String: "This birthday is invalid."
	/// </summary>
	public override string ResponseBirthdayInvalid => "生日無效。";

	/// <summary>
	/// Key: "Response.BirthdayMustBeSetFirst"
	/// English String: "Birthday must be set first."
	/// </summary>
	public override string ResponseBirthdayMustBeSetFirst => "請先設定生日。";

	/// <summary>
	/// Key: "Response.CaptchaMismatchError"
	/// error message
	/// English String: "Words do not match."
	/// </summary>
	public override string ResponseCaptchaMismatchError => "文字不符。";

	/// <summary>
	/// Key: "Response.CaptchaNotEnteredError"
	/// validation error message
	/// English String: "Please fill out the Captcha"
	/// </summary>
	public override string ResponseCaptchaNotEnteredError => "請填寫 Captcha 驗證。";

	/// <summary>
	/// Key: "Response.FacebookConnectionError"
	/// error message
	/// English String: "Error while retrieving values from Facebook."
	/// </summary>
	public override string ResponseFacebookConnectionError => "從 Facebook 擷取數值時發生錯誤。";

	/// <summary>
	/// Key: "Response.FacebookLoginAge"
	/// English String: "Facebook login can only be used by users above 13."
	/// </summary>
	public override string ResponseFacebookLoginAge => "只有 13 歲以上的使用者可以使用 Facebook 登入。";

	/// <summary>
	/// Key: "Response.InvalidBirthday"
	/// English String: "Invalid birthday."
	/// </summary>
	public override string ResponseInvalidBirthday => "生日無效。";

	/// <summary>
	/// Key: "Response.InvalidEmail"
	/// English String: "Invalid email address."
	/// </summary>
	public override string ResponseInvalidEmail => "此電子郵件地址無效。";

	/// <summary>
	/// Key: "Response.JavaScriptRequired"
	/// error to show that JavaScipt is required for the form to work
	/// English String: "JavaScript is required to submit this form."
	/// </summary>
	public override string ResponseJavaScriptRequired => "提交此表格必須使用 JavaScript。";

	/// <summary>
	/// Key: "Response.PasswordComplexity"
	/// English String: "Please create a more complex password."
	/// </summary>
	public override string ResponsePasswordComplexity => "請輸入更複雜的密碼。";

	/// <summary>
	/// Key: "Response.PasswordConfirmation"
	/// validation message for password confirmation
	/// English String: "Please enter a password confirmation."
	/// </summary>
	public override string ResponsePasswordConfirmation => "請輸入密碼確認。";

	/// <summary>
	/// Key: "Response.PasswordContainsUsernameError"
	/// error when passsword has username in it
	/// English String: "Password shouldn't match username."
	/// </summary>
	public override string ResponsePasswordContainsUsernameError => "密碼須和使用者名稱不同。";

	/// <summary>
	/// Key: "Response.PasswordMismatch"
	/// English String: "Passwords do not match."
	/// </summary>
	public override string ResponsePasswordMismatch => "密碼不相符。";

	/// <summary>
	/// Key: "Response.PasswordWrongShort"
	/// English String: "Passwords must be at least 8 characters long."
	/// </summary>
	public override string ResponsePasswordWrongShort => "密碼需要 8 個字元以上。";

	/// <summary>
	/// Key: "Response.PleaseEnterPassword"
	/// English String: "Please enter a password."
	/// </summary>
	public override string ResponsePleaseEnterPassword => "請輸入密碼。";

	/// <summary>
	/// Key: "Response.PleaseEnterUsername"
	/// English String: "Please enter a username."
	/// </summary>
	public override string ResponsePleaseEnterUsername => "請輸入使用者名稱。";

	/// <summary>
	/// Key: "Response.SocialAccountCreationFailed"
	/// error message
	/// English String: "Account creation failed"
	/// </summary>
	public override string ResponseSocialAccountCreationFailed => "無法建立帳號";

	/// <summary>
	/// Key: "Response.SpaceOrSpecialCharaterError"
	/// Spaces and special characters are not allowed error message
	/// English String: "Spaces and special characters are not allowed."
	/// </summary>
	public override string ResponseSpaceOrSpecialCharaterError => "不能使用空格與特殊字元。";

	/// <summary>
	/// Key: "Response.TooManyAccountsWithSameEmailError"
	/// Too many accounts use this email error message
	/// English String: "Too many accounts use this email."
	/// </summary>
	public override string ResponseTooManyAccountsWithSameEmailError => "加入此電子郵件地址的帳號過多。";

	/// <summary>
	/// Key: "Response.UnknownError"
	/// English String: "Sorry! An unknown error occurred. Please try again later."
	/// </summary>
	public override string ResponseUnknownError => "對不起，發生未知錯誤。請稍後再試。";

	/// <summary>
	/// Key: "Response.UsernameAllowedCharactersError"
	/// error showing which characters are allowed for username
	/// English String: "Usernames may only contain letters, numbers, and _."
	/// </summary>
	public override string ResponseUsernameAllowedCharactersError => "使用者名稱只能含有字母、數字及 _。";

	/// <summary>
	/// Key: "Response.UsernameAlreadyInUse"
	/// English String: "This username is already in use."
	/// </summary>
	public override string ResponseUsernameAlreadyInUse => "此使用者名稱已被使用。";

	/// <summary>
	/// Key: "Response.UsernameExplicit"
	/// English String: "This username is not allowed, please try another."
	/// </summary>
	public override string ResponseUsernameExplicit => "此使用者名稱含有不當內容，請重新嘗試。";

	/// <summary>
	/// Key: "Response.UsernameInvalid"
	/// English String: "Please enter a valid username."
	/// </summary>
	public override string ResponseUsernameInvalid => "請輸入有效的使用者名稱。";

	/// <summary>
	/// Key: "Response.UsernameInvalidCharacters"
	/// English String: "Only a-z, A-Z, 0-9 and _ are allowed."
	/// </summary>
	public override string ResponseUsernameInvalidCharacters => "只允許使用 a-z、A-Z、0-9 及 _。";

	/// <summary>
	/// Key: "Response.UsernameInvalidLength"
	/// English String: "Usernames can be 3 to 20 characters long."
	/// </summary>
	public override string ResponseUsernameInvalidLength => "使用者名稱應為 3 到 20 個字元。";

	/// <summary>
	/// Key: "Response.UsernameInvalidUnderscore"
	/// English String: "Usernames cannot start or end with _."
	/// </summary>
	public override string ResponseUsernameInvalidUnderscore => "使用者名稱無法以 _ 開頭或結尾。";

	/// <summary>
	/// Key: "Response.UsernameNotAvailable"
	/// English String: "Username not available. Please try again."
	/// </summary>
	public override string ResponseUsernameNotAvailable => "無法使用此使用者名稱。請重新嘗試。";

	/// <summary>
	/// Key: "Response.UsernameOrPasswordIncorrect"
	/// Your username or password is incorrect
	/// English String: "Your username or password is incorrect."
	/// </summary>
	public override string ResponseUsernameOrPasswordIncorrect => "使用者名稱或密碼不正確。";

	/// <summary>
	/// Key: "Response.UsernamePasswordRequired"
	/// Username and Password are required error message
	/// English String: "Username and Password are required."
	/// </summary>
	public override string ResponseUsernamePasswordRequired => "使用者名稱與密碼為必填項目。";

	/// <summary>
	/// Key: "Response.UsernamePrivateInfo"
	/// English String: "Username might contain private information."
	/// </summary>
	public override string ResponseUsernamePrivateInfo => "使用者名稱可能含有私人資料。";

	/// <summary>
	/// Key: "Response.UsernameRequired"
	/// validation error message
	/// English String: "Username is required."
	/// </summary>
	public override string ResponseUsernameRequired => "使用者名稱必填。";

	/// <summary>
	/// Key: "Response.UsernameTakenTryAgain"
	/// English String: "This username is already taken! Please try a different one."
	/// </summary>
	public override string ResponseUsernameTakenTryAgain => "此使用者名稱已被使用，請輸入新的使用者名稱。";

	/// <summary>
	/// Key: "Response.UsernameTooManyUnderscores"
	/// English String: "Usernames can have at most one _."
	/// </summary>
	public override string ResponseUsernameTooManyUnderscores => "使用者名稱無法使用超過一個 _。";

	public SignUpResources_zh_tw(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionCreateAccount()
	{
		return "建立帳號";
	}

	protected override string _GetTemplateForActionLinkAccount()
	{
		return "連結帳號";
	}

	protected override string _GetTemplateForActionLogInCapitalized()
	{
		return "登入";
	}

	protected override string _GetTemplateForActionReturnHome()
	{
		return "返回首頁";
	}

	protected override string _GetTemplateForActionSignUp()
	{
		return "註冊";
	}

	protected override string _GetTemplateForActionSignupAndSync()
	{
		return "註冊並同步";
	}

	protected override string _GetTemplateForActionSubmit()
	{
		return "提交";
	}

	protected override string _GetTemplateForDescriptionAccountLinkingWarning()
	{
		return "若要連接已建立的 Roblox 帳號，請登入並前往帳號設定頁面進行連接。";
	}

	protected override string _GetTemplateForDescriptionNoRealName()
	{
		return "請勿填寫您的真實姓名。";
	}

	protected override string _GetTemplateForDescriptionPrivacyPolicy()
	{
		return "隱私權政策";
	}

	/// <summary>
	/// Key: "Description.SignUpAgreement"
	/// terms of use agreement checkbox label to signup.
	/// English String: "By clicking {spanStart}Sign Up{spanEnd}, you are agreeing to the {termsOfUseLink} and acknowledging the {privacyPolicyLink}"
	/// </summary>
	public override string DescriptionSignUpAgreement(string spanStart, string spanEnd, string termsOfUseLink, string privacyPolicyLink)
	{
		return $"按下{spanStart}註冊{spanEnd}表示您同意{termsOfUseLink}並了解{privacyPolicyLink}";
	}

	protected override string _GetTemplateForDescriptionSignUpAgreement()
	{
		return "按下{spanStart}註冊{spanEnd}表示您同意{termsOfUseLink}並了解{privacyPolicyLink}";
	}

	protected override string _GetTemplateForDescriptionTermsOfService()
	{
		return "服務條款";
	}

	protected override string _GetTemplateForGuestSignUpABActionSignUp()
	{
		return "註冊";
	}

	protected override string _GetTemplateForHeadingConnectFacebook()
	{
		return "連線到 Facebook";
	}

	protected override string _GetTemplateForHeadingCreateAnAccount()
	{
		return "建立帳號";
	}

	/// <summary>
	/// Key: "Heading.FacebookSignupAlmostDone"
	/// when user signs up using Facebook, this is shown in next step to create a password.
	/// English String: "{firstname}, YOU'RE ALMOST DONE"
	/// </summary>
	public override string HeadingFacebookSignupAlmostDone(string firstname)
	{
		return $"{firstname}，快好了！";
	}

	protected override string _GetTemplateForHeadingFacebookSignupAlmostDone()
	{
		return "{firstname}，快好了！";
	}

	protected override string _GetTemplateForHeadingLoginHaveFun()
	{
		return "登入帳號，開始遊樂！";
	}

	protected override string _GetTemplateForHeadingSignupHaveFun()
	{
		return "註冊帳號，開始遊樂！";
	}

	protected override string _GetTemplateForLabelAbout()
	{
		return "介紹";
	}

	protected override string _GetTemplateForLabelAlreadyHaveRobloxAccount()
	{
		return "有 Roblox 帳號了嗎？";
	}

	protected override string _GetTemplateForLabelAlreadyRegistered()
	{
		return "已經註冊？";
	}

	protected override string _GetTemplateForLabelBirthday()
	{
		return "生日";
	}

	protected override string _GetTemplateForLabelBirthdayWithColumn()
	{
		return "生日：";
	}

	protected override string _GetTemplateForLabelConfirmPassword()
	{
		return "確認密碼";
	}

	protected override string _GetTemplateForLabelDay()
	{
		return "日";
	}

	protected override string _GetTemplateForLabelDesiredUsername()
	{
		return "欲使用的使用者名稱：";
	}

	protected override string _GetTemplateForLabelFacebookNotLinked()
	{
		return "您的 Facebook 帳號沒有連接 Roblox 帳號，請註冊新的 Roblox 帳號。";
	}

	protected override string _GetTemplateForLabelFacebookSignupUsername()
	{
		return "建立 Roblox 使用者名稱：";
	}

	protected override string _GetTemplateForLabelFemale()
	{
		return "女";
	}

	protected override string _GetTemplateForLabelGender()
	{
		return "性別";
	}

	protected override string _GetTemplateForLabelGenderRequired()
	{
		return "性別必填。";
	}

	protected override string _GetTemplateForLabelGenderWithColumn()
	{
		return "性別：";
	}

	protected override string _GetTemplateForLabelMale()
	{
		return "男";
	}

	protected override string _GetTemplateForLabelMonth()
	{
		return "月";
	}

	protected override string _GetTemplateForLabelPassword()
	{
		return "密碼";
	}

	protected override string _GetTemplateForLabelPasswordRequirements()
	{
		return "密碼（至少 8 個字元）";
	}

	protected override string _GetTemplateForLabelPlatforms()
	{
		return "平台";
	}

	protected override string _GetTemplateForLabelPlay()
	{
		return "開始玩";
	}

	protected override string _GetTemplateForLabelPleaseAgreeToTerms()
	{
		return "請同意我們的使用條款和隱私權政策。";
	}

	protected override string _GetTemplateForLabelRequired()
	{
		return "必填";
	}

	protected override string _GetTemplateForLabelSignupButtonText()
	{
		return "註冊帳號，開始遊玩！";
	}

	protected override string _GetTemplateForLabelSignUpWith()
	{
		return "或使用";
	}

	protected override string _GetTemplateForLabelTermsOfUse()
	{
		return "使用條款";
	}

	protected override string _GetTemplateForLabelUsername()
	{
		return "使用者名稱";
	}

	protected override string _GetTemplateForLabelUsernameCharacterLimit()
	{
		return "3 到 20 個英數字元，不可使用空格。";
	}

	protected override string _GetTemplateForLabelUsernameHint()
	{
		return "使用者名稱（請勿填寫您的真實姓名）";
	}

	protected override string _GetTemplateForLabelUsernameRequirements()
	{
		return "使用者名稱（ 3 到 20 個字母或數字，可使用 _）";
	}

	protected override string _GetTemplateForLabelYear()
	{
		return "年";
	}

	protected override string _GetTemplateForMessagePasswordMinLength()
	{
		return "8 個字元以上";
	}

	protected override string _GetTemplateForMessageUsernameNoRealNameUse()
	{
		return "請勿使用您的真實姓名";
	}

	protected override string _GetTemplateForResponseBadUsername()
	{
		return "此使用者名稱含有不當內容。";
	}

	protected override string _GetTemplateForResponseBadUsernameForWeChat()
	{
		return "使用者名稱不當";
	}

	protected override string _GetTemplateForResponseBirthdayInvalid()
	{
		return "生日無效。";
	}

	protected override string _GetTemplateForResponseBirthdayMustBeSetFirst()
	{
		return "請先設定生日。";
	}

	protected override string _GetTemplateForResponseCaptchaMismatchError()
	{
		return "文字不符。";
	}

	protected override string _GetTemplateForResponseCaptchaNotEnteredError()
	{
		return "請填寫 Captcha 驗證。";
	}

	protected override string _GetTemplateForResponseFacebookConnectionError()
	{
		return "從 Facebook 擷取數值時發生錯誤。";
	}

	protected override string _GetTemplateForResponseFacebookLoginAge()
	{
		return "只有 13 歲以上的使用者可以使用 Facebook 登入。";
	}

	protected override string _GetTemplateForResponseInvalidBirthday()
	{
		return "生日無效。";
	}

	protected override string _GetTemplateForResponseInvalidEmail()
	{
		return "此電子郵件地址無效。";
	}

	protected override string _GetTemplateForResponseJavaScriptRequired()
	{
		return "提交此表格必須使用 JavaScript。";
	}

	protected override string _GetTemplateForResponsePasswordComplexity()
	{
		return "請輸入更複雜的密碼。";
	}

	protected override string _GetTemplateForResponsePasswordConfirmation()
	{
		return "請輸入密碼確認。";
	}

	protected override string _GetTemplateForResponsePasswordContainsUsernameError()
	{
		return "密碼須和使用者名稱不同。";
	}

	protected override string _GetTemplateForResponsePasswordMismatch()
	{
		return "密碼不相符。";
	}

	protected override string _GetTemplateForResponsePasswordWrongShort()
	{
		return "密碼需要 8 個字元以上。";
	}

	protected override string _GetTemplateForResponsePleaseEnterPassword()
	{
		return "請輸入密碼。";
	}

	protected override string _GetTemplateForResponsePleaseEnterUsername()
	{
		return "請輸入使用者名稱。";
	}

	protected override string _GetTemplateForResponseSocialAccountCreationFailed()
	{
		return "無法建立帳號";
	}

	protected override string _GetTemplateForResponseSpaceOrSpecialCharaterError()
	{
		return "不能使用空格與特殊字元。";
	}

	protected override string _GetTemplateForResponseTooManyAccountsWithSameEmailError()
	{
		return "加入此電子郵件地址的帳號過多。";
	}

	protected override string _GetTemplateForResponseUnknownError()
	{
		return "對不起，發生未知錯誤。請稍後再試。";
	}

	protected override string _GetTemplateForResponseUsernameAllowedCharactersError()
	{
		return "使用者名稱只能含有字母、數字及 _。";
	}

	protected override string _GetTemplateForResponseUsernameAlreadyInUse()
	{
		return "此使用者名稱已被使用。";
	}

	protected override string _GetTemplateForResponseUsernameExplicit()
	{
		return "此使用者名稱含有不當內容，請重新嘗試。";
	}

	protected override string _GetTemplateForResponseUsernameInvalid()
	{
		return "請輸入有效的使用者名稱。";
	}

	protected override string _GetTemplateForResponseUsernameInvalidCharacters()
	{
		return "只允許使用 a-z、A-Z、0-9 及 _。";
	}

	protected override string _GetTemplateForResponseUsernameInvalidLength()
	{
		return "使用者名稱應為 3 到 20 個字元。";
	}

	protected override string _GetTemplateForResponseUsernameInvalidUnderscore()
	{
		return "使用者名稱無法以 _ 開頭或結尾。";
	}

	protected override string _GetTemplateForResponseUsernameNotAvailable()
	{
		return "無法使用此使用者名稱。請重新嘗試。";
	}

	protected override string _GetTemplateForResponseUsernameOrPasswordIncorrect()
	{
		return "使用者名稱或密碼不正確。";
	}

	protected override string _GetTemplateForResponseUsernamePasswordRequired()
	{
		return "使用者名稱與密碼為必填項目。";
	}

	protected override string _GetTemplateForResponseUsernamePrivateInfo()
	{
		return "使用者名稱可能含有私人資料。";
	}

	protected override string _GetTemplateForResponseUsernameRequired()
	{
		return "使用者名稱必填。";
	}

	protected override string _GetTemplateForResponseUsernameTakenTryAgain()
	{
		return "此使用者名稱已被使用，請輸入新的使用者名稱。";
	}

	protected override string _GetTemplateForResponseUsernameTooManyUnderscores()
	{
		return "使用者名稱無法使用超過一個 _。";
	}
}
