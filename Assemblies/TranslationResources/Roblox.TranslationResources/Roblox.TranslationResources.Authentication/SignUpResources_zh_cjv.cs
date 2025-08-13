namespace Roblox.TranslationResources.Authentication;

/// <summary>
/// This class overrides SignUpResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class SignUpResources_zh_cjv : SignUpResources_en_us, ISignUpResources, ITranslationResources
{
	/// <summary>
	/// Key: "Action.CreateAccount"
	/// create account button label
	/// English String: "Create Account"
	/// </summary>
	public override string ActionCreateAccount => "创建帐户";

	/// <summary>
	/// Key: "Action.LinkAccount"
	/// Button text to link 3rd Party Account to a Roblox Account
	/// English String: "Link Account"
	/// </summary>
	public override string ActionLinkAccount => "链接帐户";

	/// <summary>
	/// Key: "Action.LogInCapitalized"
	/// button label for capitalized words for Log In
	/// English String: "Log In"
	/// </summary>
	public override string ActionLogInCapitalized => "登录";

	/// <summary>
	/// Key: "Action.ReturnHome"
	/// button label to return the user to home page
	/// English String: "Return Home"
	/// </summary>
	public override string ActionReturnHome => "返回首页";

	/// <summary>
	/// Key: "Action.SignUp"
	/// English String: "Sign up"
	/// </summary>
	public override string ActionSignUp => "注册";

	public override string ActionSignupAndSync => "注册并同步";

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
	public override string DescriptionAccountLinkingWarning => "若要关联现有的 Roblox 帐户，请登录并在帐户设置页面进行关联。";

	/// <summary>
	/// Key: "Description.NoRealName"
	/// description
	/// English String: "Do not use your real name."
	/// </summary>
	public override string DescriptionNoRealName => "请勿使用你的真实姓名。";

	/// <summary>
	/// Key: "Description.PrivacyPolicy"
	/// English String: "Privacy Policy"
	/// </summary>
	public override string DescriptionPrivacyPolicy => "隐私政策";

	/// <summary>
	/// Key: "Description.TermsOfService"
	/// English String: "Terms of Service"
	/// </summary>
	public override string DescriptionTermsOfService => "服务条款";

	/// <summary>
	/// Key: "GuestSignUpAB.Action.SignUp"
	/// English String: "Sign Up"
	/// </summary>
	public override string GuestSignUpABActionSignUp => "注册";

	/// <summary>
	/// Key: "Heading.ConnectFacebook"
	/// section heading
	/// English String: "Connect to Facebook"
	/// </summary>
	public override string HeadingConnectFacebook => "连接至 Facebook";

	/// <summary>
	/// Key: "Heading.CreateAnAccount"
	/// should be capitalized if the language supports capitalization
	/// English String: "CREATE AN ACCOUNT"
	/// </summary>
	public override string HeadingCreateAnAccount => "创建帐户";

	/// <summary>
	/// Key: "Heading.LoginHaveFun"
	/// heading for login container
	/// English String: "Log in and start having fun!"
	/// </summary>
	public override string HeadingLoginHaveFun => "登录并开始游戏吧！";

	/// <summary>
	/// Key: "Heading.SignupHaveFun"
	/// signup form heading
	/// English String: "Sign up and start having fun!"
	/// </summary>
	public override string HeadingSignupHaveFun => "注册帐户，加入游戏！";

	/// <summary>
	/// Key: "Label.About"
	/// About link on roller coaster page
	/// English String: "About"
	/// </summary>
	public override string LabelAbout => "简介";

	/// <summary>
	/// Key: "Label.AlreadyHaveRobloxAccount"
	/// English String: "Already have a Roblox account?"
	/// </summary>
	public override string LabelAlreadyHaveRobloxAccount => "已有 Roblox 帐户了吗？";

	/// <summary>
	/// Key: "Label.AlreadyRegistered"
	/// label
	/// English String: "Already registered?"
	/// </summary>
	public override string LabelAlreadyRegistered => "已注册？";

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
	public override string LabelConfirmPassword => "确认密码";

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
	public override string LabelDesiredUsername => "想使用的用户名：";

	/// <summary>
	/// Key: "Label.FacebookNotLinked"
	/// English String: "Your Facebook account is not linked to any Roblox account. Please sign up for a Roblox account."
	/// </summary>
	public override string LabelFacebookNotLinked => "你的 Facebook 帐户没有关联至任何 Roblox 帐户。请注册一个 Roblox 帐户。";

	/// <summary>
	/// Key: "Label.FacebookSignupUsername"
	/// username field label for FB signup
	/// English String: "Create Roblox username:"
	/// </summary>
	public override string LabelFacebookSignupUsername => "创建 Roblox 用户名：";

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
	public override string LabelGender => "性别";

	/// <summary>
	/// Key: "Label.GenderRequired"
	/// English String: "Gender is required."
	/// </summary>
	public override string LabelGenderRequired => "需要提供性别。";

	/// <summary>
	/// Key: "Label.GenderWithColumn"
	/// should have column if the language supports it
	/// English String: "Gender:"
	/// </summary>
	public override string LabelGenderWithColumn => "性别：";

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
	public override string LabelPassword => "密码";

	/// <summary>
	/// Key: "Label.PasswordRequirements"
	/// English String: "Password (min length 8)"
	/// </summary>
	public override string LabelPasswordRequirements => "密码（最短 8 个字符）";

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
	public override string LabelPlay => "游戏";

	/// <summary>
	/// Key: "Label.PleaseAgreeToTerms"
	/// English String: "Please agree to our Terms of Use and Privacy Policy."
	/// </summary>
	public override string LabelPleaseAgreeToTerms => "请同意我们的使用条款与隐私政策。";

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
	public override string LabelSignupButtonText => "注册帐户，加入游戏！";

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
	public override string LabelSignUpWith => "或使用以下方式注册";

	/// <summary>
	/// Key: "Label.TermsOfUse"
	/// terms of use link label
	/// English String: "Terms of Use"
	/// </summary>
	public override string LabelTermsOfUse => "使用条款";

	/// <summary>
	/// Key: "Label.Username"
	/// English String: "Username"
	/// </summary>
	public override string LabelUsername => "用户名";

	/// <summary>
	/// Key: "Label.UsernameCharacterLimit"
	/// label
	/// English String: "3-20 alphanumeric characters, no spaces."
	/// </summary>
	public override string LabelUsernameCharacterLimit => "3-20 个字母数字字符，无空格。";

	/// <summary>
	/// Key: "Label.UsernameHint"
	/// placeholder for username field
	/// English String: "Username (don't use your real name)"
	/// </summary>
	public override string LabelUsernameHint => "用户名（请勿使用你的真实姓名）";

	/// <summary>
	/// Key: "Label.UsernameRequirements"
	/// English String: "Username (length 3-20, _ is allowed)"
	/// </summary>
	public override string LabelUsernameRequirements => "用户名（长度 3-20， 允许使用“_”）";

	/// <summary>
	/// Key: "Label.Year"
	/// English String: "Year"
	/// </summary>
	public override string LabelYear => "年";

	/// <summary>
	/// Key: "Message.Password.MinLength"
	/// English String: "Min length 8"
	/// </summary>
	public override string MessagePasswordMinLength => "最短 8 个字符";

	/// <summary>
	/// Key: "Message.Username.NoRealNameUse"
	/// English String: "Don't use your real name"
	/// </summary>
	public override string MessageUsernameNoRealNameUse => "请勿使用你的真实姓名。";

	/// <summary>
	/// Key: "Response.BadUsername"
	/// English String: "Username not appropriate for Roblox."
	/// </summary>
	public override string ResponseBadUsername => "用户名不适用于 Roblox。";

	/// <summary>
	/// Key: "Response.BadUsernameForWeChat"
	/// message shown when signing up with an inappropriate username
	/// English String: "Username is not appropriate"
	/// </summary>
	public override string ResponseBadUsernameForWeChat => "用户名称不当";

	/// <summary>
	/// Key: "Response.BirthdayInvalid"
	/// English String: "This birthday is invalid."
	/// </summary>
	public override string ResponseBirthdayInvalid => "此生日无效。";

	/// <summary>
	/// Key: "Response.BirthdayMustBeSetFirst"
	/// English String: "Birthday must be set first."
	/// </summary>
	public override string ResponseBirthdayMustBeSetFirst => "必须先设定生日。";

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
	public override string ResponseCaptchaNotEnteredError => "请填写验证码";

	/// <summary>
	/// Key: "Response.FacebookConnectionError"
	/// error message
	/// English String: "Error while retrieving values from Facebook."
	/// </summary>
	public override string ResponseFacebookConnectionError => "从 Facebook 取回数值时出错。";

	/// <summary>
	/// Key: "Response.FacebookLoginAge"
	/// English String: "Facebook login can only be used by users above 13."
	/// </summary>
	public override string ResponseFacebookLoginAge => "只有 13 岁以上的用户才能使用 Facebook 登录。";

	/// <summary>
	/// Key: "Response.InvalidBirthday"
	/// English String: "Invalid birthday."
	/// </summary>
	public override string ResponseInvalidBirthday => "生日无效。";

	/// <summary>
	/// Key: "Response.InvalidEmail"
	/// English String: "Invalid email address."
	/// </summary>
	public override string ResponseInvalidEmail => "电子邮件地址无效。";

	/// <summary>
	/// Key: "Response.JavaScriptRequired"
	/// error to show that JavaScipt is required for the form to work
	/// English String: "JavaScript is required to submit this form."
	/// </summary>
	public override string ResponseJavaScriptRequired => "提交此表单需要 JavaScript。";

	/// <summary>
	/// Key: "Response.PasswordComplexity"
	/// English String: "Please create a more complex password."
	/// </summary>
	public override string ResponsePasswordComplexity => "请创建一个更复杂的密码。";

	/// <summary>
	/// Key: "Response.PasswordConfirmation"
	/// validation message for password confirmation
	/// English String: "Please enter a password confirmation."
	/// </summary>
	public override string ResponsePasswordConfirmation => "请输入密码确认。";

	/// <summary>
	/// Key: "Response.PasswordContainsUsernameError"
	/// error when passsword has username in it
	/// English String: "Password shouldn't match username."
	/// </summary>
	public override string ResponsePasswordContainsUsernameError => "密码不可包含用户名。";

	/// <summary>
	/// Key: "Response.PasswordMismatch"
	/// English String: "Passwords do not match."
	/// </summary>
	public override string ResponsePasswordMismatch => "密码不匹配。";

	/// <summary>
	/// Key: "Response.PasswordWrongShort"
	/// English String: "Passwords must be at least 8 characters long."
	/// </summary>
	public override string ResponsePasswordWrongShort => "密码长度必须至少为 8 个字符。";

	/// <summary>
	/// Key: "Response.PleaseEnterPassword"
	/// English String: "Please enter a password."
	/// </summary>
	public override string ResponsePleaseEnterPassword => "请输入密码。";

	/// <summary>
	/// Key: "Response.PleaseEnterUsername"
	/// English String: "Please enter a username."
	/// </summary>
	public override string ResponsePleaseEnterUsername => "请输入用户名。";

	/// <summary>
	/// Key: "Response.SocialAccountCreationFailed"
	/// error message
	/// English String: "Account creation failed"
	/// </summary>
	public override string ResponseSocialAccountCreationFailed => "帐户创建失败";

	/// <summary>
	/// Key: "Response.SpaceOrSpecialCharaterError"
	/// Spaces and special characters are not allowed error message
	/// English String: "Spaces and special characters are not allowed."
	/// </summary>
	public override string ResponseSpaceOrSpecialCharaterError => "不允许使用空格和特殊字符。";

	/// <summary>
	/// Key: "Response.TooManyAccountsWithSameEmailError"
	/// Too many accounts use this email error message
	/// English String: "Too many accounts use this email."
	/// </summary>
	public override string ResponseTooManyAccountsWithSameEmailError => "过多帐户使用此电子邮件。";

	/// <summary>
	/// Key: "Response.UnknownError"
	/// English String: "Sorry! An unknown error occurred. Please try again later."
	/// </summary>
	public override string ResponseUnknownError => "抱歉！发生未知错误。请稍后重试。";

	/// <summary>
	/// Key: "Response.UsernameAllowedCharactersError"
	/// error showing which characters are allowed for username
	/// English String: "Usernames may only contain letters, numbers, and _."
	/// </summary>
	public override string ResponseUsernameAllowedCharactersError => "用户名可能仅包含字母，数字及“_”。";

	/// <summary>
	/// Key: "Response.UsernameAlreadyInUse"
	/// English String: "This username is already in use."
	/// </summary>
	public override string ResponseUsernameAlreadyInUse => "此用户名已被使用。";

	/// <summary>
	/// Key: "Response.UsernameExplicit"
	/// English String: "This username is not allowed, please try another."
	/// </summary>
	public override string ResponseUsernameExplicit => "此用户名含有不当内容，请重新命名。";

	/// <summary>
	/// Key: "Response.UsernameInvalid"
	/// English String: "Please enter a valid username."
	/// </summary>
	public override string ResponseUsernameInvalid => "请输入有效用户名。";

	/// <summary>
	/// Key: "Response.UsernameInvalidCharacters"
	/// English String: "Only a-z, A-Z, 0-9 and _ are allowed."
	/// </summary>
	public override string ResponseUsernameInvalidCharacters => "只允许使用 a-z、A-Z、0-9 及 _。";

	/// <summary>
	/// Key: "Response.UsernameInvalidLength"
	/// English String: "Usernames can be 3 to 20 characters long."
	/// </summary>
	public override string ResponseUsernameInvalidLength => "用户名的长度须为 3 至 20 个字符。";

	/// <summary>
	/// Key: "Response.UsernameInvalidUnderscore"
	/// English String: "Usernames cannot start or end with _."
	/// </summary>
	public override string ResponseUsernameInvalidUnderscore => "用户名的开头或结尾不能是“_”。";

	/// <summary>
	/// Key: "Response.UsernameNotAvailable"
	/// English String: "Username not available. Please try again."
	/// </summary>
	public override string ResponseUsernameNotAvailable => "用户名不可用。请重试。";

	/// <summary>
	/// Key: "Response.UsernameOrPasswordIncorrect"
	/// Your username or password is incorrect
	/// English String: "Your username or password is incorrect."
	/// </summary>
	public override string ResponseUsernameOrPasswordIncorrect => "你的用户名或密码不正确。";

	/// <summary>
	/// Key: "Response.UsernamePasswordRequired"
	/// Username and Password are required error message
	/// English String: "Username and Password are required."
	/// </summary>
	public override string ResponseUsernamePasswordRequired => "需要提供用户名及密码。";

	/// <summary>
	/// Key: "Response.UsernamePrivateInfo"
	/// English String: "Username might contain private information."
	/// </summary>
	public override string ResponseUsernamePrivateInfo => "用户名可能包含私人信息。";

	/// <summary>
	/// Key: "Response.UsernameRequired"
	/// validation error message
	/// English String: "Username is required."
	/// </summary>
	public override string ResponseUsernameRequired => "需要提供用户名。";

	/// <summary>
	/// Key: "Response.UsernameTakenTryAgain"
	/// English String: "This username is already taken! Please try a different one."
	/// </summary>
	public override string ResponseUsernameTakenTryAgain => "此用户名已被使用，请重新命名。";

	/// <summary>
	/// Key: "Response.UsernameTooManyUnderscores"
	/// English String: "Usernames can have at most one _."
	/// </summary>
	public override string ResponseUsernameTooManyUnderscores => "用户名最多可包含一个“_“。";

	public SignUpResources_zh_cjv(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionCreateAccount()
	{
		return "创建帐户";
	}

	protected override string _GetTemplateForActionLinkAccount()
	{
		return "链接帐户";
	}

	protected override string _GetTemplateForActionLogInCapitalized()
	{
		return "登录";
	}

	protected override string _GetTemplateForActionReturnHome()
	{
		return "返回首页";
	}

	protected override string _GetTemplateForActionSignUp()
	{
		return "注册";
	}

	protected override string _GetTemplateForActionSignupAndSync()
	{
		return "注册并同步";
	}

	protected override string _GetTemplateForActionSubmit()
	{
		return "提交";
	}

	protected override string _GetTemplateForDescriptionAccountLinkingWarning()
	{
		return "若要关联现有的 Roblox 帐户，请登录并在帐户设置页面进行关联。";
	}

	protected override string _GetTemplateForDescriptionNoRealName()
	{
		return "请勿使用你的真实姓名。";
	}

	protected override string _GetTemplateForDescriptionPrivacyPolicy()
	{
		return "隐私政策";
	}

	/// <summary>
	/// Key: "Description.SignUpAgreement"
	/// terms of use agreement checkbox label to signup.
	/// English String: "By clicking {spanStart}Sign Up{spanEnd}, you are agreeing to the {termsOfUseLink} and acknowledging the {privacyPolicyLink}"
	/// </summary>
	public override string DescriptionSignUpAgreement(string spanStart, string spanEnd, string termsOfUseLink, string privacyPolicyLink)
	{
		return $"点按{spanStart}“注册”{spanEnd}，即表示你已同意{termsOfUseLink}并了解{privacyPolicyLink}";
	}

	protected override string _GetTemplateForDescriptionSignUpAgreement()
	{
		return "点按{spanStart}“注册”{spanEnd}，即表示你已同意{termsOfUseLink}并了解{privacyPolicyLink}";
	}

	protected override string _GetTemplateForDescriptionTermsOfService()
	{
		return "服务条款";
	}

	protected override string _GetTemplateForGuestSignUpABActionSignUp()
	{
		return "注册";
	}

	protected override string _GetTemplateForHeadingConnectFacebook()
	{
		return "连接至 Facebook";
	}

	protected override string _GetTemplateForHeadingCreateAnAccount()
	{
		return "创建帐户";
	}

	/// <summary>
	/// Key: "Heading.FacebookSignupAlmostDone"
	/// when user signs up using Facebook, this is shown in next step to create a password.
	/// English String: "{firstname}, YOU'RE ALMOST DONE"
	/// </summary>
	public override string HeadingFacebookSignupAlmostDone(string firstname)
	{
		return $"{firstname}，你马上就完成了";
	}

	protected override string _GetTemplateForHeadingFacebookSignupAlmostDone()
	{
		return "{firstname}，你马上就完成了";
	}

	protected override string _GetTemplateForHeadingLoginHaveFun()
	{
		return "登录并开始游戏吧！";
	}

	protected override string _GetTemplateForHeadingSignupHaveFun()
	{
		return "注册帐户，加入游戏！";
	}

	protected override string _GetTemplateForLabelAbout()
	{
		return "简介";
	}

	protected override string _GetTemplateForLabelAlreadyHaveRobloxAccount()
	{
		return "已有 Roblox 帐户了吗？";
	}

	protected override string _GetTemplateForLabelAlreadyRegistered()
	{
		return "已注册？";
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
		return "确认密码";
	}

	protected override string _GetTemplateForLabelDay()
	{
		return "日";
	}

	protected override string _GetTemplateForLabelDesiredUsername()
	{
		return "想使用的用户名：";
	}

	protected override string _GetTemplateForLabelFacebookNotLinked()
	{
		return "你的 Facebook 帐户没有关联至任何 Roblox 帐户。请注册一个 Roblox 帐户。";
	}

	protected override string _GetTemplateForLabelFacebookSignupUsername()
	{
		return "创建 Roblox 用户名：";
	}

	protected override string _GetTemplateForLabelFemale()
	{
		return "女";
	}

	protected override string _GetTemplateForLabelGender()
	{
		return "性别";
	}

	protected override string _GetTemplateForLabelGenderRequired()
	{
		return "需要提供性别。";
	}

	protected override string _GetTemplateForLabelGenderWithColumn()
	{
		return "性别：";
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
		return "密码";
	}

	protected override string _GetTemplateForLabelPasswordRequirements()
	{
		return "密码（最短 8 个字符）";
	}

	protected override string _GetTemplateForLabelPlatforms()
	{
		return "平台";
	}

	protected override string _GetTemplateForLabelPlay()
	{
		return "游戏";
	}

	protected override string _GetTemplateForLabelPleaseAgreeToTerms()
	{
		return "请同意我们的使用条款与隐私政策。";
	}

	protected override string _GetTemplateForLabelRequired()
	{
		return "必填";
	}

	protected override string _GetTemplateForLabelSignupButtonText()
	{
		return "注册帐户，加入游戏！";
	}

	protected override string _GetTemplateForLabelSignUpWith()
	{
		return "或使用以下方式注册";
	}

	protected override string _GetTemplateForLabelTermsOfUse()
	{
		return "使用条款";
	}

	protected override string _GetTemplateForLabelUsername()
	{
		return "用户名";
	}

	protected override string _GetTemplateForLabelUsernameCharacterLimit()
	{
		return "3-20 个字母数字字符，无空格。";
	}

	protected override string _GetTemplateForLabelUsernameHint()
	{
		return "用户名（请勿使用你的真实姓名）";
	}

	protected override string _GetTemplateForLabelUsernameRequirements()
	{
		return "用户名（长度 3-20， 允许使用“_”）";
	}

	protected override string _GetTemplateForLabelYear()
	{
		return "年";
	}

	protected override string _GetTemplateForMessagePasswordMinLength()
	{
		return "最短 8 个字符";
	}

	protected override string _GetTemplateForMessageUsernameNoRealNameUse()
	{
		return "请勿使用你的真实姓名。";
	}

	protected override string _GetTemplateForResponseBadUsername()
	{
		return "用户名不适用于 Roblox。";
	}

	protected override string _GetTemplateForResponseBadUsernameForWeChat()
	{
		return "用户名称不当";
	}

	protected override string _GetTemplateForResponseBirthdayInvalid()
	{
		return "此生日无效。";
	}

	protected override string _GetTemplateForResponseBirthdayMustBeSetFirst()
	{
		return "必须先设定生日。";
	}

	protected override string _GetTemplateForResponseCaptchaMismatchError()
	{
		return "文字不符。";
	}

	protected override string _GetTemplateForResponseCaptchaNotEnteredError()
	{
		return "请填写验证码";
	}

	protected override string _GetTemplateForResponseFacebookConnectionError()
	{
		return "从 Facebook 取回数值时出错。";
	}

	protected override string _GetTemplateForResponseFacebookLoginAge()
	{
		return "只有 13 岁以上的用户才能使用 Facebook 登录。";
	}

	protected override string _GetTemplateForResponseInvalidBirthday()
	{
		return "生日无效。";
	}

	protected override string _GetTemplateForResponseInvalidEmail()
	{
		return "电子邮件地址无效。";
	}

	protected override string _GetTemplateForResponseJavaScriptRequired()
	{
		return "提交此表单需要 JavaScript。";
	}

	protected override string _GetTemplateForResponsePasswordComplexity()
	{
		return "请创建一个更复杂的密码。";
	}

	protected override string _GetTemplateForResponsePasswordConfirmation()
	{
		return "请输入密码确认。";
	}

	protected override string _GetTemplateForResponsePasswordContainsUsernameError()
	{
		return "密码不可包含用户名。";
	}

	protected override string _GetTemplateForResponsePasswordMismatch()
	{
		return "密码不匹配。";
	}

	protected override string _GetTemplateForResponsePasswordWrongShort()
	{
		return "密码长度必须至少为 8 个字符。";
	}

	protected override string _GetTemplateForResponsePleaseEnterPassword()
	{
		return "请输入密码。";
	}

	protected override string _GetTemplateForResponsePleaseEnterUsername()
	{
		return "请输入用户名。";
	}

	protected override string _GetTemplateForResponseSocialAccountCreationFailed()
	{
		return "帐户创建失败";
	}

	protected override string _GetTemplateForResponseSpaceOrSpecialCharaterError()
	{
		return "不允许使用空格和特殊字符。";
	}

	protected override string _GetTemplateForResponseTooManyAccountsWithSameEmailError()
	{
		return "过多帐户使用此电子邮件。";
	}

	protected override string _GetTemplateForResponseUnknownError()
	{
		return "抱歉！发生未知错误。请稍后重试。";
	}

	protected override string _GetTemplateForResponseUsernameAllowedCharactersError()
	{
		return "用户名可能仅包含字母，数字及“_”。";
	}

	protected override string _GetTemplateForResponseUsernameAlreadyInUse()
	{
		return "此用户名已被使用。";
	}

	protected override string _GetTemplateForResponseUsernameExplicit()
	{
		return "此用户名含有不当内容，请重新命名。";
	}

	protected override string _GetTemplateForResponseUsernameInvalid()
	{
		return "请输入有效用户名。";
	}

	protected override string _GetTemplateForResponseUsernameInvalidCharacters()
	{
		return "只允许使用 a-z、A-Z、0-9 及 _。";
	}

	protected override string _GetTemplateForResponseUsernameInvalidLength()
	{
		return "用户名的长度须为 3 至 20 个字符。";
	}

	protected override string _GetTemplateForResponseUsernameInvalidUnderscore()
	{
		return "用户名的开头或结尾不能是“_”。";
	}

	protected override string _GetTemplateForResponseUsernameNotAvailable()
	{
		return "用户名不可用。请重试。";
	}

	protected override string _GetTemplateForResponseUsernameOrPasswordIncorrect()
	{
		return "你的用户名或密码不正确。";
	}

	protected override string _GetTemplateForResponseUsernamePasswordRequired()
	{
		return "需要提供用户名及密码。";
	}

	protected override string _GetTemplateForResponseUsernamePrivateInfo()
	{
		return "用户名可能包含私人信息。";
	}

	protected override string _GetTemplateForResponseUsernameRequired()
	{
		return "需要提供用户名。";
	}

	protected override string _GetTemplateForResponseUsernameTakenTryAgain()
	{
		return "此用户名已被使用，请重新命名。";
	}

	protected override string _GetTemplateForResponseUsernameTooManyUnderscores()
	{
		return "用户名最多可包含一个“_“。";
	}
}
