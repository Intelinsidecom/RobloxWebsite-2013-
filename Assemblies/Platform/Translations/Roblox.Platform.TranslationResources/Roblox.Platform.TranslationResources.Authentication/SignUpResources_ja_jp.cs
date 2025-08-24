namespace Roblox.TranslationResources.Authentication;

/// <summary>
/// This class overrides SignUpResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class SignUpResources_ja_jp : SignUpResources_en_us, ISignUpResources, ITranslationResources
{
	/// <summary>
	/// Key: "Action.CreateAccount"
	/// create account button label
	/// English String: "Create Account"
	/// </summary>
	public override string ActionCreateAccount => "アカウントを作成";

	/// <summary>
	/// Key: "Action.LinkAccount"
	/// Button text to link 3rd Party Account to a Roblox Account
	/// English String: "Link Account"
	/// </summary>
	public override string ActionLinkAccount => "アカウントをリンクする";

	/// <summary>
	/// Key: "Action.LogInCapitalized"
	/// button label for capitalized words for Log In
	/// English String: "Log In"
	/// </summary>
	public override string ActionLogInCapitalized => "ログイン";

	/// <summary>
	/// Key: "Action.ReturnHome"
	/// button label to return the user to home page
	/// English String: "Return Home"
	/// </summary>
	public override string ActionReturnHome => "ホーム画面に戻る";

	/// <summary>
	/// Key: "Action.SignUp"
	/// English String: "Sign up"
	/// </summary>
	public override string ActionSignUp => "新規登録";

	public override string ActionSignupAndSync => "新規登録および 同期化";

	/// <summary>
	/// Key: "Action.Submit"
	/// English String: "Submit"
	/// </summary>
	public override string ActionSubmit => "送信";

	/// <summary>
	/// Key: "Description.AccountLinkingWarning"
	/// instructions for linking account on signup page for FB based account
	/// English String: "To link to an existing Roblox account, sign in and link them on the account settings page."
	/// </summary>
	public override string DescriptionAccountLinkingWarning => "既存のRobloxアカウントにリンクするには、ログインしてアカウントの設定ページから関連付けてください。";

	/// <summary>
	/// Key: "Description.NoRealName"
	/// description
	/// English String: "Do not use your real name."
	/// </summary>
	public override string DescriptionNoRealName => "本名を使わないでください。";

	/// <summary>
	/// Key: "Description.PrivacyPolicy"
	/// English String: "Privacy Policy"
	/// </summary>
	public override string DescriptionPrivacyPolicy => "プライバシーポリシー";

	/// <summary>
	/// Key: "Description.TermsOfService"
	/// English String: "Terms of Service"
	/// </summary>
	public override string DescriptionTermsOfService => "利用規約";

	/// <summary>
	/// Key: "GuestSignUpAB.Action.SignUp"
	/// English String: "Sign Up"
	/// </summary>
	public override string GuestSignUpABActionSignUp => "新規登録";

	/// <summary>
	/// Key: "Heading.ConnectFacebook"
	/// section heading
	/// English String: "Connect to Facebook"
	/// </summary>
	public override string HeadingConnectFacebook => "Facebookに接続する";

	/// <summary>
	/// Key: "Heading.CreateAnAccount"
	/// should be capitalized if the language supports capitalization
	/// English String: "CREATE AN ACCOUNT"
	/// </summary>
	public override string HeadingCreateAnAccount => "アカウントを作成する";

	/// <summary>
	/// Key: "Heading.LoginHaveFun"
	/// heading for login container
	/// English String: "Log in and start having fun!"
	/// </summary>
	public override string HeadingLoginHaveFun => "ログインして楽しみましょう！";

	/// <summary>
	/// Key: "Heading.SignupHaveFun"
	/// signup form heading
	/// English String: "Sign up and start having fun!"
	/// </summary>
	public override string HeadingSignupHaveFun => "新規登録して楽しみましょう！";

	/// <summary>
	/// Key: "Label.About"
	/// About link on roller coaster page
	/// English String: "About"
	/// </summary>
	public override string LabelAbout => "情報";

	/// <summary>
	/// Key: "Label.AlreadyHaveRobloxAccount"
	/// English String: "Already have a Roblox account?"
	/// </summary>
	public override string LabelAlreadyHaveRobloxAccount => "すでにRobloxアカウントをお持ちですか？";

	/// <summary>
	/// Key: "Label.AlreadyRegistered"
	/// label
	/// English String: "Already registered?"
	/// </summary>
	public override string LabelAlreadyRegistered => "すでに登録済みですか？";

	/// <summary>
	/// Key: "Label.Birthday"
	/// English String: "Birthday"
	/// </summary>
	public override string LabelBirthday => "生年月日";

	/// <summary>
	/// Key: "Label.BirthdayWithColumn"
	/// should have column if the language supports it
	/// English String: "Birthday:"
	/// </summary>
	public override string LabelBirthdayWithColumn => "生年月日:";

	/// <summary>
	/// Key: "Label.ConfirmPassword"
	/// English String: "Confirm password"
	/// </summary>
	public override string LabelConfirmPassword => "パスワード再確認";

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
	public override string LabelDesiredUsername => "望ましいユーザー名:";

	/// <summary>
	/// Key: "Label.FacebookNotLinked"
	/// English String: "Your Facebook account is not linked to any Roblox account. Please sign up for a Roblox account."
	/// </summary>
	public override string LabelFacebookNotLinked => "このFacebookアカウントはどのRobloxアカウントにもリンクされていません。Robloxアカウントを新規登録してください。";

	/// <summary>
	/// Key: "Label.FacebookSignupUsername"
	/// username field label for FB signup
	/// English String: "Create Roblox username:"
	/// </summary>
	public override string LabelFacebookSignupUsername => "Robloxのユーザーネームを作成：";

	/// <summary>
	/// Key: "Label.Female"
	/// label
	/// English String: "Female"
	/// </summary>
	public override string LabelFemale => "女性";

	/// <summary>
	/// Key: "Label.Gender"
	/// English String: "Gender"
	/// </summary>
	public override string LabelGender => "性別";

	/// <summary>
	/// Key: "Label.GenderRequired"
	/// English String: "Gender is required."
	/// </summary>
	public override string LabelGenderRequired => "性別は必須です。";

	/// <summary>
	/// Key: "Label.GenderWithColumn"
	/// should have column if the language supports it
	/// English String: "Gender:"
	/// </summary>
	public override string LabelGenderWithColumn => "性別:";

	/// <summary>
	/// Key: "Label.Male"
	/// label
	/// English String: "Male"
	/// </summary>
	public override string LabelMale => "男性";

	/// <summary>
	/// Key: "Label.Month"
	/// English String: "Month"
	/// </summary>
	public override string LabelMonth => "月";

	/// <summary>
	/// Key: "Label.Password"
	/// English String: "Password"
	/// </summary>
	public override string LabelPassword => "パスワード";

	/// <summary>
	/// Key: "Label.PasswordRequirements"
	/// English String: "Password (min length 8)"
	/// </summary>
	public override string LabelPasswordRequirements => "パスワード（8文字以上）";

	/// <summary>
	/// Key: "Label.Platforms"
	/// platforms link on roller coaster page
	/// English String: "Platforms"
	/// </summary>
	public override string LabelPlatforms => "プラットフォーム";

	/// <summary>
	/// Key: "Label.Play"
	/// Play link on roller coaster page
	/// English String: "Play"
	/// </summary>
	public override string LabelPlay => "プレイ";

	/// <summary>
	/// Key: "Label.PleaseAgreeToTerms"
	/// English String: "Please agree to our Terms of Use and Privacy Policy."
	/// </summary>
	public override string LabelPleaseAgreeToTerms => "利用規約とプライバシーポリシーへの同意が必要です。";

	/// <summary>
	/// Key: "Label.Required"
	/// Required
	/// English String: "Required"
	/// </summary>
	public override string LabelRequired => "必須";

	/// <summary>
	/// Key: "Label.SignupButtonText"
	/// sign up button text
	/// English String: "Sign Up and Play!"
	/// </summary>
	public override string LabelSignupButtonText => "新規登録してプレイする";

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
	public override string LabelSignUpWith => "またはこちらで新規登録";

	/// <summary>
	/// Key: "Label.TermsOfUse"
	/// terms of use link label
	/// English String: "Terms of Use"
	/// </summary>
	public override string LabelTermsOfUse => "利用規約";

	/// <summary>
	/// Key: "Label.Username"
	/// English String: "Username"
	/// </summary>
	public override string LabelUsername => "ユーザーネーム";

	/// <summary>
	/// Key: "Label.UsernameCharacterLimit"
	/// label
	/// English String: "3-20 alphanumeric characters, no spaces."
	/// </summary>
	public override string LabelUsernameCharacterLimit => "3〜20の英数字、スペースは不可";

	/// <summary>
	/// Key: "Label.UsernameHint"
	/// placeholder for username field
	/// English String: "Username (don't use your real name)"
	/// </summary>
	public override string LabelUsernameHint => "ユーザーネーム（本名を使用しないでください）";

	/// <summary>
	/// Key: "Label.UsernameRequirements"
	/// English String: "Username (length 3-20, _ is allowed)"
	/// </summary>
	public override string LabelUsernameRequirements => "ユーザーネーム（長さは3～20文字、下線 _ は使用可能）";

	/// <summary>
	/// Key: "Label.Year"
	/// English String: "Year"
	/// </summary>
	public override string LabelYear => "年";

	/// <summary>
	/// Key: "Message.Password.MinLength"
	/// English String: "Min length 8"
	/// </summary>
	public override string MessagePasswordMinLength => "最低8文字";

	/// <summary>
	/// Key: "Message.Username.NoRealNameUse"
	/// English String: "Don't use your real name"
	/// </summary>
	public override string MessageUsernameNoRealNameUse => "本名を使用しないでください";

	/// <summary>
	/// Key: "Response.BadUsername"
	/// English String: "Username not appropriate for Roblox."
	/// </summary>
	public override string ResponseBadUsername => "ユーザーネームがRobloxには適切ではありません。";

	/// <summary>
	/// Key: "Response.BadUsernameForWeChat"
	/// message shown when signing up with an inappropriate username
	/// English String: "Username is not appropriate"
	/// </summary>
	public override string ResponseBadUsernameForWeChat => "ユーザーネームが適切ではありません";

	/// <summary>
	/// Key: "Response.BirthdayInvalid"
	/// English String: "This birthday is invalid."
	/// </summary>
	public override string ResponseBirthdayInvalid => "生年月日が無効です。";

	/// <summary>
	/// Key: "Response.BirthdayMustBeSetFirst"
	/// English String: "Birthday must be set first."
	/// </summary>
	public override string ResponseBirthdayMustBeSetFirst => "最初に誕生日を設定する必要があります。";

	/// <summary>
	/// Key: "Response.CaptchaMismatchError"
	/// error message
	/// English String: "Words do not match."
	/// </summary>
	public override string ResponseCaptchaMismatchError => "言葉が一致しません。";

	/// <summary>
	/// Key: "Response.CaptchaNotEnteredError"
	/// validation error message
	/// English String: "Please fill out the Captcha"
	/// </summary>
	public override string ResponseCaptchaNotEnteredError => "キャプチャ認証を入力してください";

	/// <summary>
	/// Key: "Response.FacebookConnectionError"
	/// error message
	/// English String: "Error while retrieving values from Facebook."
	/// </summary>
	public override string ResponseFacebookConnectionError => "Facebookからの情報の取得中にエラーが発生しました。";

	/// <summary>
	/// Key: "Response.FacebookLoginAge"
	/// English String: "Facebook login can only be used by users above 13."
	/// </summary>
	public override string ResponseFacebookLoginAge => "Facebookログインは13歳以上のユーザーのみ使用できます。";

	/// <summary>
	/// Key: "Response.InvalidBirthday"
	/// English String: "Invalid birthday."
	/// </summary>
	public override string ResponseInvalidBirthday => "生年月日が無効です。";

	/// <summary>
	/// Key: "Response.InvalidEmail"
	/// English String: "Invalid email address."
	/// </summary>
	public override string ResponseInvalidEmail => "メールアドレスが無効です。";

	/// <summary>
	/// Key: "Response.JavaScriptRequired"
	/// error to show that JavaScipt is required for the form to work
	/// English String: "JavaScript is required to submit this form."
	/// </summary>
	public override string ResponseJavaScriptRequired => "フォームを送信するにはJavaScriptが必要です。";

	/// <summary>
	/// Key: "Response.PasswordComplexity"
	/// English String: "Please create a more complex password."
	/// </summary>
	public override string ResponsePasswordComplexity => "もっと複雑なパスワードを作成してください。";

	/// <summary>
	/// Key: "Response.PasswordConfirmation"
	/// validation message for password confirmation
	/// English String: "Please enter a password confirmation."
	/// </summary>
	public override string ResponsePasswordConfirmation => "確認パスワードを入力してください。";

	/// <summary>
	/// Key: "Response.PasswordContainsUsernameError"
	/// error when passsword has username in it
	/// English String: "Password shouldn't match username."
	/// </summary>
	public override string ResponsePasswordContainsUsernameError => "パスワードをユーザーネームと同じにすることはできません。";

	/// <summary>
	/// Key: "Response.PasswordMismatch"
	/// English String: "Passwords do not match."
	/// </summary>
	public override string ResponsePasswordMismatch => "パスワードが一致しません。";

	/// <summary>
	/// Key: "Response.PasswordWrongShort"
	/// English String: "Passwords must be at least 8 characters long."
	/// </summary>
	public override string ResponsePasswordWrongShort => "パスワードは8文字以上でなければなりません。";

	/// <summary>
	/// Key: "Response.PleaseEnterPassword"
	/// English String: "Please enter a password."
	/// </summary>
	public override string ResponsePleaseEnterPassword => "パスワードを入力して下さい。";

	/// <summary>
	/// Key: "Response.PleaseEnterUsername"
	/// English String: "Please enter a username."
	/// </summary>
	public override string ResponsePleaseEnterUsername => "ユーザーネームを入力して下さい。";

	/// <summary>
	/// Key: "Response.SocialAccountCreationFailed"
	/// error message
	/// English String: "Account creation failed"
	/// </summary>
	public override string ResponseSocialAccountCreationFailed => "アカウントの作成に失敗しました";

	/// <summary>
	/// Key: "Response.SpaceOrSpecialCharaterError"
	/// Spaces and special characters are not allowed error message
	/// English String: "Spaces and special characters are not allowed."
	/// </summary>
	public override string ResponseSpaceOrSpecialCharaterError => "スペースや特殊文字は使用できません。";

	/// <summary>
	/// Key: "Response.TooManyAccountsWithSameEmailError"
	/// Too many accounts use this email error message
	/// English String: "Too many accounts use this email."
	/// </summary>
	public override string ResponseTooManyAccountsWithSameEmailError => "このメールアドレスはすでに多くのアカウントで使用されています。";

	/// <summary>
	/// Key: "Response.UnknownError"
	/// English String: "Sorry! An unknown error occurred. Please try again later."
	/// </summary>
	public override string ResponseUnknownError => "ごめんなさい！不明なエラーが発生しました。後でもう一度お試しください。";

	/// <summary>
	/// Key: "Response.UsernameAllowedCharactersError"
	/// error showing which characters are allowed for username
	/// English String: "Usernames may only contain letters, numbers, and _."
	/// </summary>
	public override string ResponseUsernameAllowedCharactersError => "ユーザーネームに使用できるのは、文字、数字、 および下線 （ _ ）だけです。";

	/// <summary>
	/// Key: "Response.UsernameAlreadyInUse"
	/// English String: "This username is already in use."
	/// </summary>
	public override string ResponseUsernameAlreadyInUse => "このユーザーネームはすでに使われています。";

	/// <summary>
	/// Key: "Response.UsernameExplicit"
	/// English String: "This username is not allowed, please try another."
	/// </summary>
	public override string ResponseUsernameExplicit => "このユーザーネームは使用できません。";

	/// <summary>
	/// Key: "Response.UsernameInvalid"
	/// English String: "Please enter a valid username."
	/// </summary>
	public override string ResponseUsernameInvalid => "有効なユーザーネームを入力して下さい。";

	/// <summary>
	/// Key: "Response.UsernameInvalidCharacters"
	/// English String: "Only a-z, A-Z, 0-9 and _ are allowed."
	/// </summary>
	public override string ResponseUsernameInvalidCharacters => "a-z、A-Z、0-9、および下線（ _ ）のみを使用できます。";

	/// <summary>
	/// Key: "Response.UsernameInvalidLength"
	/// English String: "Usernames can be 3 to 20 characters long."
	/// </summary>
	public override string ResponseUsernameInvalidLength => "ユーザーネームは3〜20文字以内にする必要があります。";

	/// <summary>
	/// Key: "Response.UsernameInvalidUnderscore"
	/// English String: "Usernames cannot start or end with _."
	/// </summary>
	public override string ResponseUsernameInvalidUnderscore => "ユーザーネームの最初と最後に下線（ _ ）は使用不可。";

	/// <summary>
	/// Key: "Response.UsernameNotAvailable"
	/// English String: "Username not available. Please try again."
	/// </summary>
	public override string ResponseUsernameNotAvailable => "ユーザーネームが利用できません。やり直してください。";

	/// <summary>
	/// Key: "Response.UsernameOrPasswordIncorrect"
	/// Your username or password is incorrect
	/// English String: "Your username or password is incorrect."
	/// </summary>
	public override string ResponseUsernameOrPasswordIncorrect => "ユーザーネーム、またはパスワードが間違っています。";

	/// <summary>
	/// Key: "Response.UsernamePasswordRequired"
	/// Username and Password are required error message
	/// English String: "Username and Password are required."
	/// </summary>
	public override string ResponseUsernamePasswordRequired => "ユーザー名とパスワードが必要です。";

	/// <summary>
	/// Key: "Response.UsernamePrivateInfo"
	/// English String: "Username might contain private information."
	/// </summary>
	public override string ResponseUsernamePrivateInfo => "ユーザーネームに個人情報が含まれています。";

	/// <summary>
	/// Key: "Response.UsernameRequired"
	/// validation error message
	/// English String: "Username is required."
	/// </summary>
	public override string ResponseUsernameRequired => "ユーザーネームが必要です。";

	/// <summary>
	/// Key: "Response.UsernameTakenTryAgain"
	/// English String: "This username is already taken! Please try a different one."
	/// </summary>
	public override string ResponseUsernameTakenTryAgain => "そのユーザーネームはすでに使われています！別の名前をお試しください。";

	/// <summary>
	/// Key: "Response.UsernameTooManyUnderscores"
	/// English String: "Usernames can have at most one _."
	/// </summary>
	public override string ResponseUsernameTooManyUnderscores => "ユーザーネームには下線（ _ ）を2つ以上使用できません。";

	public SignUpResources_ja_jp(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionCreateAccount()
	{
		return "アカウントを作成";
	}

	protected override string _GetTemplateForActionLinkAccount()
	{
		return "アカウントをリンクする";
	}

	protected override string _GetTemplateForActionLogInCapitalized()
	{
		return "ログイン";
	}

	protected override string _GetTemplateForActionReturnHome()
	{
		return "ホーム画面に戻る";
	}

	protected override string _GetTemplateForActionSignUp()
	{
		return "新規登録";
	}

	protected override string _GetTemplateForActionSignupAndSync()
	{
		return "新規登録および 同期化";
	}

	protected override string _GetTemplateForActionSubmit()
	{
		return "送信";
	}

	protected override string _GetTemplateForDescriptionAccountLinkingWarning()
	{
		return "既存のRobloxアカウントにリンクするには、ログインしてアカウントの設定ページから関連付けてください。";
	}

	protected override string _GetTemplateForDescriptionNoRealName()
	{
		return "本名を使わないでください。";
	}

	protected override string _GetTemplateForDescriptionPrivacyPolicy()
	{
		return "プライバシーポリシー";
	}

	/// <summary>
	/// Key: "Description.SignUpAgreement"
	/// terms of use agreement checkbox label to signup.
	/// English String: "By clicking {spanStart}Sign Up{spanEnd}, you are agreeing to the {termsOfUseLink} and acknowledging the {privacyPolicyLink}"
	/// </summary>
	public override string DescriptionSignUpAgreement(string spanStart, string spanEnd, string termsOfUseLink, string privacyPolicyLink)
	{
		return $"{spanStart}新規登録{spanEnd}をクリックすると、{termsOfUseLink}に同意し、{privacyPolicyLink}を承認したことになります";
	}

	protected override string _GetTemplateForDescriptionSignUpAgreement()
	{
		return "{spanStart}新規登録{spanEnd}をクリックすると、{termsOfUseLink}に同意し、{privacyPolicyLink}を承認したことになります";
	}

	protected override string _GetTemplateForDescriptionTermsOfService()
	{
		return "利用規約";
	}

	protected override string _GetTemplateForGuestSignUpABActionSignUp()
	{
		return "新規登録";
	}

	protected override string _GetTemplateForHeadingConnectFacebook()
	{
		return "Facebookに接続する";
	}

	protected override string _GetTemplateForHeadingCreateAnAccount()
	{
		return "アカウントを作成する";
	}

	/// <summary>
	/// Key: "Heading.FacebookSignupAlmostDone"
	/// when user signs up using Facebook, this is shown in next step to create a password.
	/// English String: "{firstname}, YOU'RE ALMOST DONE"
	/// </summary>
	public override string HeadingFacebookSignupAlmostDone(string firstname)
	{
		return $"{firstname}様、もうすぐ完了です";
	}

	protected override string _GetTemplateForHeadingFacebookSignupAlmostDone()
	{
		return "{firstname}様、もうすぐ完了です";
	}

	protected override string _GetTemplateForHeadingLoginHaveFun()
	{
		return "ログインして楽しみましょう！";
	}

	protected override string _GetTemplateForHeadingSignupHaveFun()
	{
		return "新規登録して楽しみましょう！";
	}

	protected override string _GetTemplateForLabelAbout()
	{
		return "情報";
	}

	protected override string _GetTemplateForLabelAlreadyHaveRobloxAccount()
	{
		return "すでにRobloxアカウントをお持ちですか？";
	}

	protected override string _GetTemplateForLabelAlreadyRegistered()
	{
		return "すでに登録済みですか？";
	}

	protected override string _GetTemplateForLabelBirthday()
	{
		return "生年月日";
	}

	protected override string _GetTemplateForLabelBirthdayWithColumn()
	{
		return "生年月日:";
	}

	protected override string _GetTemplateForLabelConfirmPassword()
	{
		return "パスワード再確認";
	}

	protected override string _GetTemplateForLabelDay()
	{
		return "日";
	}

	protected override string _GetTemplateForLabelDesiredUsername()
	{
		return "望ましいユーザー名:";
	}

	protected override string _GetTemplateForLabelFacebookNotLinked()
	{
		return "このFacebookアカウントはどのRobloxアカウントにもリンクされていません。Robloxアカウントを新規登録してください。";
	}

	protected override string _GetTemplateForLabelFacebookSignupUsername()
	{
		return "Robloxのユーザーネームを作成：";
	}

	protected override string _GetTemplateForLabelFemale()
	{
		return "女性";
	}

	protected override string _GetTemplateForLabelGender()
	{
		return "性別";
	}

	protected override string _GetTemplateForLabelGenderRequired()
	{
		return "性別は必須です。";
	}

	protected override string _GetTemplateForLabelGenderWithColumn()
	{
		return "性別:";
	}

	protected override string _GetTemplateForLabelMale()
	{
		return "男性";
	}

	protected override string _GetTemplateForLabelMonth()
	{
		return "月";
	}

	protected override string _GetTemplateForLabelPassword()
	{
		return "パスワード";
	}

	protected override string _GetTemplateForLabelPasswordRequirements()
	{
		return "パスワード（8文字以上）";
	}

	protected override string _GetTemplateForLabelPlatforms()
	{
		return "プラットフォーム";
	}

	protected override string _GetTemplateForLabelPlay()
	{
		return "プレイ";
	}

	protected override string _GetTemplateForLabelPleaseAgreeToTerms()
	{
		return "利用規約とプライバシーポリシーへの同意が必要です。";
	}

	protected override string _GetTemplateForLabelRequired()
	{
		return "必須";
	}

	protected override string _GetTemplateForLabelSignupButtonText()
	{
		return "新規登録してプレイする";
	}

	protected override string _GetTemplateForLabelSignUpWith()
	{
		return "またはこちらで新規登録";
	}

	protected override string _GetTemplateForLabelTermsOfUse()
	{
		return "利用規約";
	}

	protected override string _GetTemplateForLabelUsername()
	{
		return "ユーザーネーム";
	}

	protected override string _GetTemplateForLabelUsernameCharacterLimit()
	{
		return "3〜20の英数字、スペースは不可";
	}

	protected override string _GetTemplateForLabelUsernameHint()
	{
		return "ユーザーネーム（本名を使用しないでください）";
	}

	protected override string _GetTemplateForLabelUsernameRequirements()
	{
		return "ユーザーネーム（長さは3～20文字、下線 _ は使用可能）";
	}

	protected override string _GetTemplateForLabelYear()
	{
		return "年";
	}

	protected override string _GetTemplateForMessagePasswordMinLength()
	{
		return "最低8文字";
	}

	protected override string _GetTemplateForMessageUsernameNoRealNameUse()
	{
		return "本名を使用しないでください";
	}

	protected override string _GetTemplateForResponseBadUsername()
	{
		return "ユーザーネームがRobloxには適切ではありません。";
	}

	protected override string _GetTemplateForResponseBadUsernameForWeChat()
	{
		return "ユーザーネームが適切ではありません";
	}

	protected override string _GetTemplateForResponseBirthdayInvalid()
	{
		return "生年月日が無効です。";
	}

	protected override string _GetTemplateForResponseBirthdayMustBeSetFirst()
	{
		return "最初に誕生日を設定する必要があります。";
	}

	protected override string _GetTemplateForResponseCaptchaMismatchError()
	{
		return "言葉が一致しません。";
	}

	protected override string _GetTemplateForResponseCaptchaNotEnteredError()
	{
		return "キャプチャ認証を入力してください";
	}

	protected override string _GetTemplateForResponseFacebookConnectionError()
	{
		return "Facebookからの情報の取得中にエラーが発生しました。";
	}

	protected override string _GetTemplateForResponseFacebookLoginAge()
	{
		return "Facebookログインは13歳以上のユーザーのみ使用できます。";
	}

	protected override string _GetTemplateForResponseInvalidBirthday()
	{
		return "生年月日が無効です。";
	}

	protected override string _GetTemplateForResponseInvalidEmail()
	{
		return "メールアドレスが無効です。";
	}

	protected override string _GetTemplateForResponseJavaScriptRequired()
	{
		return "フォームを送信するにはJavaScriptが必要です。";
	}

	protected override string _GetTemplateForResponsePasswordComplexity()
	{
		return "もっと複雑なパスワードを作成してください。";
	}

	protected override string _GetTemplateForResponsePasswordConfirmation()
	{
		return "確認パスワードを入力してください。";
	}

	protected override string _GetTemplateForResponsePasswordContainsUsernameError()
	{
		return "パスワードをユーザーネームと同じにすることはできません。";
	}

	protected override string _GetTemplateForResponsePasswordMismatch()
	{
		return "パスワードが一致しません。";
	}

	protected override string _GetTemplateForResponsePasswordWrongShort()
	{
		return "パスワードは8文字以上でなければなりません。";
	}

	protected override string _GetTemplateForResponsePleaseEnterPassword()
	{
		return "パスワードを入力して下さい。";
	}

	protected override string _GetTemplateForResponsePleaseEnterUsername()
	{
		return "ユーザーネームを入力して下さい。";
	}

	protected override string _GetTemplateForResponseSocialAccountCreationFailed()
	{
		return "アカウントの作成に失敗しました";
	}

	protected override string _GetTemplateForResponseSpaceOrSpecialCharaterError()
	{
		return "スペースや特殊文字は使用できません。";
	}

	protected override string _GetTemplateForResponseTooManyAccountsWithSameEmailError()
	{
		return "このメールアドレスはすでに多くのアカウントで使用されています。";
	}

	protected override string _GetTemplateForResponseUnknownError()
	{
		return "ごめんなさい！不明なエラーが発生しました。後でもう一度お試しください。";
	}

	protected override string _GetTemplateForResponseUsernameAllowedCharactersError()
	{
		return "ユーザーネームに使用できるのは、文字、数字、 および下線 （ _ ）だけです。";
	}

	protected override string _GetTemplateForResponseUsernameAlreadyInUse()
	{
		return "このユーザーネームはすでに使われています。";
	}

	protected override string _GetTemplateForResponseUsernameExplicit()
	{
		return "このユーザーネームは使用できません。";
	}

	protected override string _GetTemplateForResponseUsernameInvalid()
	{
		return "有効なユーザーネームを入力して下さい。";
	}

	protected override string _GetTemplateForResponseUsernameInvalidCharacters()
	{
		return "a-z、A-Z、0-9、および下線（ _ ）のみを使用できます。";
	}

	protected override string _GetTemplateForResponseUsernameInvalidLength()
	{
		return "ユーザーネームは3〜20文字以内にする必要があります。";
	}

	protected override string _GetTemplateForResponseUsernameInvalidUnderscore()
	{
		return "ユーザーネームの最初と最後に下線（ _ ）は使用不可。";
	}

	protected override string _GetTemplateForResponseUsernameNotAvailable()
	{
		return "ユーザーネームが利用できません。やり直してください。";
	}

	protected override string _GetTemplateForResponseUsernameOrPasswordIncorrect()
	{
		return "ユーザーネーム、またはパスワードが間違っています。";
	}

	protected override string _GetTemplateForResponseUsernamePasswordRequired()
	{
		return "ユーザー名とパスワードが必要です。";
	}

	protected override string _GetTemplateForResponseUsernamePrivateInfo()
	{
		return "ユーザーネームに個人情報が含まれています。";
	}

	protected override string _GetTemplateForResponseUsernameRequired()
	{
		return "ユーザーネームが必要です。";
	}

	protected override string _GetTemplateForResponseUsernameTakenTryAgain()
	{
		return "そのユーザーネームはすでに使われています！別の名前をお試しください。";
	}

	protected override string _GetTemplateForResponseUsernameTooManyUnderscores()
	{
		return "ユーザーネームには下線（ _ ）を2つ以上使用できません。";
	}
}
