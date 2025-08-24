namespace Roblox.TranslationResources.Authentication;

/// <summary>
/// This class overrides SignUpResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class SignUpResources_th_th : SignUpResources_en_us, ISignUpResources, ITranslationResources
{
	/// <summary>
	/// Key: "Action.CreateAccount"
	/// create account button label
	/// English String: "Create Account"
	/// </summary>
	public override string ActionCreateAccount => "สร\u0e49างบ\u0e31ญช\u0e35";

	/// <summary>
	/// Key: "Action.LinkAccount"
	/// Button text to link 3rd Party Account to a Roblox Account
	/// English String: "Link Account"
	/// </summary>
	public override string ActionLinkAccount => "เช\u0e37\u0e48อมโยงบ\u0e31ญช\u0e35";

	/// <summary>
	/// Key: "Action.LogInCapitalized"
	/// button label for capitalized words for Log In
	/// English String: "Log In"
	/// </summary>
	public override string ActionLogInCapitalized => "เข\u0e49าส\u0e39\u0e48ระบบ";

	/// <summary>
	/// Key: "Action.ReturnHome"
	/// button label to return the user to home page
	/// English String: "Return Home"
	/// </summary>
	public override string ActionReturnHome => "กล\u0e31บไปหน\u0e49าหล\u0e31ก";

	/// <summary>
	/// Key: "Action.SignUp"
	/// English String: "Sign up"
	/// </summary>
	public override string ActionSignUp => "สม\u0e31ครบ\u0e31ญช\u0e35";

	public override string ActionSignupAndSync => "สม\u0e31ครบ\u0e31ญช\u0e35ผ\u0e39\u0e49ใช\u0e49 แล\u0e49วซ\u0e34งค\u0e4cข\u0e49อม\u0e39ล";

	/// <summary>
	/// Key: "Action.Submit"
	/// English String: "Submit"
	/// </summary>
	public override string ActionSubmit => "ส\u0e48ง";

	/// <summary>
	/// Key: "Description.AccountLinkingWarning"
	/// instructions for linking account on signup page for FB based account
	/// English String: "To link to an existing Roblox account, sign in and link them on the account settings page."
	/// </summary>
	public override string DescriptionAccountLinkingWarning => "กร\u0e38ณาลงช\u0e37\u0e48อเข\u0e49าส\u0e39\u0e48บ\u0e31ญช\u0e35 Roblox ท\u0e35\u0e48ม\u0e35อย\u0e39\u0e48แล\u0e49วเพ\u0e37\u0e48อทำการเช\u0e37\u0e48อมโยงท\u0e35\u0e48หน\u0e49าการต\u0e31\u0e49งค\u0e48าบ\u0e31ญช\u0e35";

	/// <summary>
	/// Key: "Description.NoRealName"
	/// description
	/// English String: "Do not use your real name."
	/// </summary>
	public override string DescriptionNoRealName => "ห\u0e49ามใช\u0e49ช\u0e37\u0e48อจร\u0e34งของค\u0e38ณ";

	/// <summary>
	/// Key: "Description.PrivacyPolicy"
	/// English String: "Privacy Policy"
	/// </summary>
	public override string DescriptionPrivacyPolicy => "นโยบายความเป\u0e47นส\u0e48วนต\u0e31ว";

	/// <summary>
	/// Key: "Description.TermsOfService"
	/// English String: "Terms of Service"
	/// </summary>
	public override string DescriptionTermsOfService => "เง\u0e37\u0e48อนไขการให\u0e49บร\u0e34การ";

	/// <summary>
	/// Key: "GuestSignUpAB.Action.SignUp"
	/// English String: "Sign Up"
	/// </summary>
	public override string GuestSignUpABActionSignUp => "สม\u0e31ครบ\u0e31ญช\u0e35ผ\u0e39\u0e49ใช\u0e49";

	/// <summary>
	/// Key: "Heading.ConnectFacebook"
	/// section heading
	/// English String: "Connect to Facebook"
	/// </summary>
	public override string HeadingConnectFacebook => "เช\u0e37\u0e48อมต\u0e48อก\u0e31บ Facebook";

	/// <summary>
	/// Key: "Heading.CreateAnAccount"
	/// should be capitalized if the language supports capitalization
	/// English String: "CREATE AN ACCOUNT"
	/// </summary>
	public override string HeadingCreateAnAccount => "สร\u0e49างบ\u0e31ญช\u0e35";

	/// <summary>
	/// Key: "Heading.LoginHaveFun"
	/// heading for login container
	/// English String: "Log in and start having fun!"
	/// </summary>
	public override string HeadingLoginHaveFun => "เข\u0e49าส\u0e39\u0e48ระบบ แล\u0e49วเร\u0e34\u0e48มสน\u0e38กก\u0e31นได\u0e49เลย!";

	/// <summary>
	/// Key: "Heading.SignupHaveFun"
	/// signup form heading
	/// English String: "Sign up and start having fun!"
	/// </summary>
	public override string HeadingSignupHaveFun => "สม\u0e31ครบ\u0e31ญช\u0e35ผ\u0e39\u0e49ใช\u0e49 แล\u0e49วเร\u0e34\u0e48มสน\u0e38กก\u0e31นได\u0e49เลย!";

	/// <summary>
	/// Key: "Label.About"
	/// About link on roller coaster page
	/// English String: "About"
	/// </summary>
	public override string LabelAbout => "เก\u0e35\u0e48ยวก\u0e31บ";

	/// <summary>
	/// Key: "Label.AlreadyHaveRobloxAccount"
	/// English String: "Already have a Roblox account?"
	/// </summary>
	public override string LabelAlreadyHaveRobloxAccount => "ม\u0e35บ\u0e31ญช\u0e35 Roblox อย\u0e39\u0e48แล\u0e49ว?";

	/// <summary>
	/// Key: "Label.AlreadyRegistered"
	/// label
	/// English String: "Already registered?"
	/// </summary>
	public override string LabelAlreadyRegistered => "เคยลงทะเบ\u0e35ยนอย\u0e39\u0e48แล\u0e49ว?";

	/// <summary>
	/// Key: "Label.Birthday"
	/// English String: "Birthday"
	/// </summary>
	public override string LabelBirthday => "ว\u0e31นเก\u0e34ด";

	/// <summary>
	/// Key: "Label.BirthdayWithColumn"
	/// should have column if the language supports it
	/// English String: "Birthday:"
	/// </summary>
	public override string LabelBirthdayWithColumn => "ว\u0e31นเก\u0e34ด:";

	/// <summary>
	/// Key: "Label.ConfirmPassword"
	/// English String: "Confirm password"
	/// </summary>
	public override string LabelConfirmPassword => "ย\u0e37นย\u0e31นรห\u0e31สผ\u0e48าน";

	/// <summary>
	/// Key: "Label.Day"
	/// English String: "Day"
	/// </summary>
	public override string LabelDay => "ว\u0e31น";

	/// <summary>
	/// Key: "Label.DesiredUsername"
	/// should have a column if the language supports it
	/// English String: "Desired Username:"
	/// </summary>
	public override string LabelDesiredUsername => "ช\u0e37\u0e48อผ\u0e39\u0e49ใช\u0e49ท\u0e35\u0e48ต\u0e49องการ:";

	/// <summary>
	/// Key: "Label.FacebookNotLinked"
	/// English String: "Your Facebook account is not linked to any Roblox account. Please sign up for a Roblox account."
	/// </summary>
	public override string LabelFacebookNotLinked => "บ\u0e31ญช\u0e35 Facebook ของค\u0e38ณไม\u0e48ได\u0e49เช\u0e37\u0e48อมโยงก\u0e31บบ\u0e31ญช\u0e35 Roblox ใดเลย กร\u0e38ณาสม\u0e31ครบ\u0e31ญช\u0e35 Roblox";

	/// <summary>
	/// Key: "Label.FacebookSignupUsername"
	/// username field label for FB signup
	/// English String: "Create Roblox username:"
	/// </summary>
	public override string LabelFacebookSignupUsername => "สร\u0e49างช\u0e37\u0e48อผ\u0e39\u0e49ใช\u0e49 Roblox:";

	/// <summary>
	/// Key: "Label.Female"
	/// label
	/// English String: "Female"
	/// </summary>
	public override string LabelFemale => "หญ\u0e34ง";

	/// <summary>
	/// Key: "Label.Gender"
	/// English String: "Gender"
	/// </summary>
	public override string LabelGender => "เพศ";

	/// <summary>
	/// Key: "Label.GenderRequired"
	/// English String: "Gender is required."
	/// </summary>
	public override string LabelGenderRequired => "จำเป\u0e47นต\u0e49องระบ\u0e38เพศ";

	/// <summary>
	/// Key: "Label.GenderWithColumn"
	/// should have column if the language supports it
	/// English String: "Gender:"
	/// </summary>
	public override string LabelGenderWithColumn => "เพศ:";

	/// <summary>
	/// Key: "Label.Male"
	/// label
	/// English String: "Male"
	/// </summary>
	public override string LabelMale => "ชาย";

	/// <summary>
	/// Key: "Label.Month"
	/// English String: "Month"
	/// </summary>
	public override string LabelMonth => "เด\u0e37อน";

	/// <summary>
	/// Key: "Label.Password"
	/// English String: "Password"
	/// </summary>
	public override string LabelPassword => "รห\u0e31สผ\u0e48าน";

	/// <summary>
	/// Key: "Label.PasswordRequirements"
	/// English String: "Password (min length 8)"
	/// </summary>
	public override string LabelPasswordRequirements => "รห\u0e31สผ\u0e48าน (ยาวอย\u0e48างน\u0e49อย 8)";

	/// <summary>
	/// Key: "Label.Platforms"
	/// platforms link on roller coaster page
	/// English String: "Platforms"
	/// </summary>
	public override string LabelPlatforms => "แพลตฟอร\u0e4cม";

	/// <summary>
	/// Key: "Label.Play"
	/// Play link on roller coaster page
	/// English String: "Play"
	/// </summary>
	public override string LabelPlay => "เล\u0e48น";

	/// <summary>
	/// Key: "Label.PleaseAgreeToTerms"
	/// English String: "Please agree to our Terms of Use and Privacy Policy."
	/// </summary>
	public override string LabelPleaseAgreeToTerms => "กร\u0e38ณายอมร\u0e31บเง\u0e37\u0e48อนไขการให\u0e49บร\u0e34การและนโยบายความเป\u0e47นส\u0e48วนต\u0e31วของเรา";

	/// <summary>
	/// Key: "Label.Required"
	/// Required
	/// English String: "Required"
	/// </summary>
	public override string LabelRequired => "จำเป\u0e47นต\u0e49องม\u0e35";

	/// <summary>
	/// Key: "Label.SignupButtonText"
	/// sign up button text
	/// English String: "Sign Up and Play!"
	/// </summary>
	public override string LabelSignupButtonText => "สม\u0e31ครแล\u0e49วเล\u0e48นเลย!";

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
	public override string LabelSignUpWith => "หร\u0e37อสม\u0e31ครบ\u0e31ญช\u0e35ผ\u0e39\u0e49ใช\u0e49ด\u0e49วย";

	/// <summary>
	/// Key: "Label.TermsOfUse"
	/// terms of use link label
	/// English String: "Terms of Use"
	/// </summary>
	public override string LabelTermsOfUse => "เง\u0e37\u0e48อนไขการใช\u0e49งาน";

	/// <summary>
	/// Key: "Label.Username"
	/// English String: "Username"
	/// </summary>
	public override string LabelUsername => "ช\u0e37\u0e48อผ\u0e39\u0e49ใช\u0e49";

	/// <summary>
	/// Key: "Label.UsernameCharacterLimit"
	/// label
	/// English String: "3-20 alphanumeric characters, no spaces."
	/// </summary>
	public override string LabelUsernameCharacterLimit => "ต\u0e31วเลขหร\u0e37อต\u0e31วอ\u0e31กษร 3-20 ต\u0e31ว ห\u0e49ามม\u0e35เว\u0e49นวรรค";

	/// <summary>
	/// Key: "Label.UsernameHint"
	/// placeholder for username field
	/// English String: "Username (don't use your real name)"
	/// </summary>
	public override string LabelUsernameHint => "ช\u0e37\u0e48อผ\u0e39\u0e49ใช\u0e49 (ท\u0e35\u0e48ไม\u0e48ใช\u0e48ช\u0e37\u0e48อจร\u0e34งของค\u0e38ณ)";

	/// <summary>
	/// Key: "Label.UsernameRequirements"
	/// English String: "Username (length 3-20, _ is allowed)"
	/// </summary>
	public override string LabelUsernameRequirements => "ช\u0e37\u0e48อผ\u0e39\u0e49ใช\u0e49 (ความยาว 3-20 อน\u0e38ญาตให\u0e49ใช\u0e49 _)";

	/// <summary>
	/// Key: "Label.Year"
	/// English String: "Year"
	/// </summary>
	public override string LabelYear => "ป\u0e35";

	/// <summary>
	/// Key: "Message.Password.MinLength"
	/// English String: "Min length 8"
	/// </summary>
	public override string MessagePasswordMinLength => "ยาวอย\u0e48างน\u0e49อย 8";

	/// <summary>
	/// Key: "Message.Username.NoRealNameUse"
	/// English String: "Don't use your real name"
	/// </summary>
	public override string MessageUsernameNoRealNameUse => "อย\u0e48าใช\u0e49ช\u0e37\u0e48อจร\u0e34งของค\u0e38ณ";

	/// <summary>
	/// Key: "Response.BadUsername"
	/// English String: "Username not appropriate for Roblox."
	/// </summary>
	public override string ResponseBadUsername => "ช\u0e37\u0e48อผ\u0e39\u0e49ใช\u0e49ไม\u0e48เหมาะสมสำหร\u0e31บ Roblox";

	/// <summary>
	/// Key: "Response.BadUsernameForWeChat"
	/// message shown when signing up with an inappropriate username
	/// English String: "Username is not appropriate"
	/// </summary>
	public override string ResponseBadUsernameForWeChat => "ช\u0e37\u0e48อผ\u0e39\u0e49ใช\u0e49ไม\u0e48เหมาะสม";

	/// <summary>
	/// Key: "Response.BirthdayInvalid"
	/// English String: "This birthday is invalid."
	/// </summary>
	public override string ResponseBirthdayInvalid => "ว\u0e31นเก\u0e34ดน\u0e35\u0e49ไม\u0e48ถ\u0e39กต\u0e49อง";

	/// <summary>
	/// Key: "Response.BirthdayMustBeSetFirst"
	/// English String: "Birthday must be set first."
	/// </summary>
	public override string ResponseBirthdayMustBeSetFirst => "จะต\u0e49องระบ\u0e38ว\u0e31นเก\u0e34ดก\u0e48อน";

	/// <summary>
	/// Key: "Response.CaptchaMismatchError"
	/// error message
	/// English String: "Words do not match."
	/// </summary>
	public override string ResponseCaptchaMismatchError => "คำไม\u0e48ตรงก\u0e31น";

	/// <summary>
	/// Key: "Response.CaptchaNotEnteredError"
	/// validation error message
	/// English String: "Please fill out the Captcha"
	/// </summary>
	public override string ResponseCaptchaNotEnteredError => "กร\u0e38ณาป\u0e49อน Captcha";

	/// <summary>
	/// Key: "Response.FacebookConnectionError"
	/// error message
	/// English String: "Error while retrieving values from Facebook."
	/// </summary>
	public override string ResponseFacebookConnectionError => "เก\u0e34ดข\u0e49อผ\u0e34ดพลาดขณะพยายามด\u0e36งข\u0e49อม\u0e39ลของค\u0e38ณจาก Facebook";

	/// <summary>
	/// Key: "Response.FacebookLoginAge"
	/// English String: "Facebook login can only be used by users above 13."
	/// </summary>
	public override string ResponseFacebookLoginAge => "การเข\u0e49าส\u0e39\u0e48ระบบ Facebook จะสามารถใช\u0e49งานได\u0e49โดยผ\u0e39\u0e49ใช\u0e49อาย\u0e38 13 ป\u0e35ข\u0e36\u0e49นไปเท\u0e48าน\u0e31\u0e49น";

	/// <summary>
	/// Key: "Response.InvalidBirthday"
	/// English String: "Invalid birthday."
	/// </summary>
	public override string ResponseInvalidBirthday => "ว\u0e31นเก\u0e34ดไม\u0e48ถ\u0e39กต\u0e49อง";

	/// <summary>
	/// Key: "Response.InvalidEmail"
	/// English String: "Invalid email address."
	/// </summary>
	public override string ResponseInvalidEmail => "ท\u0e35\u0e48อย\u0e39\u0e48อ\u0e35เมลไม\u0e48ถ\u0e39กต\u0e49อง";

	/// <summary>
	/// Key: "Response.JavaScriptRequired"
	/// error to show that JavaScipt is required for the form to work
	/// English String: "JavaScript is required to submit this form."
	/// </summary>
	public override string ResponseJavaScriptRequired => "จำเป\u0e47นต\u0e49องใช\u0e49 JavaScript เพ\u0e37\u0e48อส\u0e48งแบบฟอร\u0e4cมน\u0e35\u0e49";

	/// <summary>
	/// Key: "Response.PasswordComplexity"
	/// English String: "Please create a more complex password."
	/// </summary>
	public override string ResponsePasswordComplexity => "กร\u0e38ณาเล\u0e37อกรห\u0e31สผ\u0e48านท\u0e35\u0e48ซ\u0e31บซ\u0e49อนมากข\u0e36\u0e49น";

	/// <summary>
	/// Key: "Response.PasswordConfirmation"
	/// validation message for password confirmation
	/// English String: "Please enter a password confirmation."
	/// </summary>
	public override string ResponsePasswordConfirmation => "กร\u0e38ณาป\u0e49อนรห\u0e31สผ\u0e48านย\u0e37นย\u0e31น";

	/// <summary>
	/// Key: "Response.PasswordContainsUsernameError"
	/// error when passsword has username in it
	/// English String: "Password shouldn't match username."
	/// </summary>
	public override string ResponsePasswordContainsUsernameError => "รห\u0e31สผ\u0e48านไม\u0e48ควรตรงก\u0e31บช\u0e37\u0e48อผ\u0e39\u0e49ใช\u0e49";

	/// <summary>
	/// Key: "Response.PasswordMismatch"
	/// English String: "Passwords do not match."
	/// </summary>
	public override string ResponsePasswordMismatch => "รห\u0e31สผ\u0e48านไม\u0e48ตรงก\u0e31น";

	/// <summary>
	/// Key: "Response.PasswordWrongShort"
	/// English String: "Passwords must be at least 8 characters long."
	/// </summary>
	public override string ResponsePasswordWrongShort => "รห\u0e31สผ\u0e48านจะต\u0e49องยาวอย\u0e48างน\u0e49อย 8 อ\u0e31กขระ";

	/// <summary>
	/// Key: "Response.PleaseEnterPassword"
	/// English String: "Please enter a password."
	/// </summary>
	public override string ResponsePleaseEnterPassword => "กร\u0e38ณาป\u0e49อนรห\u0e31สผ\u0e48าน";

	/// <summary>
	/// Key: "Response.PleaseEnterUsername"
	/// English String: "Please enter a username."
	/// </summary>
	public override string ResponsePleaseEnterUsername => "กร\u0e38ณาป\u0e49อนช\u0e37\u0e48อผ\u0e39\u0e49ใช\u0e49";

	/// <summary>
	/// Key: "Response.SocialAccountCreationFailed"
	/// error message
	/// English String: "Account creation failed"
	/// </summary>
	public override string ResponseSocialAccountCreationFailed => "การสร\u0e49างบ\u0e31ญช\u0e35ล\u0e49มเหลว";

	/// <summary>
	/// Key: "Response.SpaceOrSpecialCharaterError"
	/// Spaces and special characters are not allowed error message
	/// English String: "Spaces and special characters are not allowed."
	/// </summary>
	public override string ResponseSpaceOrSpecialCharaterError => "ไม\u0e48อน\u0e38ญาตให\u0e49ใช\u0e49ช\u0e48องว\u0e48างและอ\u0e31กขระพ\u0e34เศษ";

	/// <summary>
	/// Key: "Response.TooManyAccountsWithSameEmailError"
	/// Too many accounts use this email error message
	/// English String: "Too many accounts use this email."
	/// </summary>
	public override string ResponseTooManyAccountsWithSameEmailError => "ม\u0e35บ\u0e31ญช\u0e35ท\u0e35\u0e48ใช\u0e49งานอ\u0e35เมลน\u0e35\u0e49มากเก\u0e34นไป";

	/// <summary>
	/// Key: "Response.UnknownError"
	/// English String: "Sorry! An unknown error occurred. Please try again later."
	/// </summary>
	public override string ResponseUnknownError => "ขออภ\u0e31ย! เก\u0e34ดข\u0e49อผ\u0e34ดพลาดท\u0e35\u0e48ไม\u0e48ทราบสาเหต\u0e38 กร\u0e38ณาลองใหม\u0e48อ\u0e35กคร\u0e31\u0e49งในภายหล\u0e31ง";

	/// <summary>
	/// Key: "Response.UsernameAllowedCharactersError"
	/// error showing which characters are allowed for username
	/// English String: "Usernames may only contain letters, numbers, and _."
	/// </summary>
	public override string ResponseUsernameAllowedCharactersError => "ช\u0e37\u0e48อผ\u0e39\u0e49ใช\u0e49สามารถม\u0e35ได\u0e49เพ\u0e35ยงต\u0e31วอ\u0e31กษร, ต\u0e31วเลข และ_";

	/// <summary>
	/// Key: "Response.UsernameAlreadyInUse"
	/// English String: "This username is already in use."
	/// </summary>
	public override string ResponseUsernameAlreadyInUse => "ม\u0e35การใช\u0e49งานช\u0e37\u0e48อผ\u0e39\u0e49ใช\u0e49น\u0e35\u0e49ไปแล\u0e49ว";

	/// <summary>
	/// Key: "Response.UsernameExplicit"
	/// English String: "This username is not allowed, please try another."
	/// </summary>
	public override string ResponseUsernameExplicit => "ไม\u0e48ได\u0e49ร\u0e31บอน\u0e38ญาตให\u0e49ใช\u0e49ช\u0e37\u0e48อผ\u0e39\u0e49ใช\u0e49น\u0e35\u0e49 กร\u0e38ณาลองช\u0e37\u0e48ออ\u0e37\u0e48น";

	/// <summary>
	/// Key: "Response.UsernameInvalid"
	/// English String: "Please enter a valid username."
	/// </summary>
	public override string ResponseUsernameInvalid => "กร\u0e38ณาป\u0e49อนช\u0e37\u0e48อผ\u0e39\u0e49ใช\u0e49ท\u0e35\u0e48ถ\u0e39กต\u0e49อง";

	/// <summary>
	/// Key: "Response.UsernameInvalidCharacters"
	/// English String: "Only a-z, A-Z, 0-9 and _ are allowed."
	/// </summary>
	public override string ResponseUsernameInvalidCharacters => "อน\u0e38ญาตให\u0e49ม\u0e35เพ\u0e35ยงแค\u0e48 a–z, A–Z, 0-9 และ _ เท\u0e48าน\u0e31\u0e49น";

	/// <summary>
	/// Key: "Response.UsernameInvalidLength"
	/// English String: "Usernames can be 3 to 20 characters long."
	/// </summary>
	public override string ResponseUsernameInvalidLength => "ช\u0e37\u0e48อผ\u0e39\u0e49ใช\u0e49สามารถม\u0e35ความยาวได\u0e49ระหว\u0e48าง 3 ถ\u0e36ง 20 อ\u0e31กขระ";

	/// <summary>
	/// Key: "Response.UsernameInvalidUnderscore"
	/// English String: "Usernames cannot start or end with _."
	/// </summary>
	public override string ResponseUsernameInvalidUnderscore => "ช\u0e37\u0e48อผ\u0e39\u0e49ใช\u0e49ไม\u0e48สามารถเร\u0e34\u0e48มต\u0e49นหร\u0e37อลงท\u0e49ายด\u0e49วย _ ได\u0e49";

	/// <summary>
	/// Key: "Response.UsernameNotAvailable"
	/// English String: "Username not available. Please try again."
	/// </summary>
	public override string ResponseUsernameNotAvailable => "ช\u0e37\u0e48อผ\u0e39\u0e49ใช\u0e49ไม\u0e48พร\u0e49อม กร\u0e38ณาลองใหม\u0e48อ\u0e35กคร\u0e31\u0e49ง";

	/// <summary>
	/// Key: "Response.UsernameOrPasswordIncorrect"
	/// Your username or password is incorrect
	/// English String: "Your username or password is incorrect."
	/// </summary>
	public override string ResponseUsernameOrPasswordIncorrect => "ช\u0e37\u0e48อผ\u0e39\u0e49ใช\u0e49หร\u0e37อรห\u0e31สผ\u0e48านของค\u0e38ณไม\u0e48ถ\u0e39กต\u0e49อง";

	/// <summary>
	/// Key: "Response.UsernamePasswordRequired"
	/// Username and Password are required error message
	/// English String: "Username and Password are required."
	/// </summary>
	public override string ResponseUsernamePasswordRequired => "จำเป\u0e47นต\u0e49องม\u0e35ช\u0e37\u0e48อผ\u0e39\u0e49ใช\u0e49และรห\u0e31สผ\u0e48าน";

	/// <summary>
	/// Key: "Response.UsernamePrivateInfo"
	/// English String: "Username might contain private information."
	/// </summary>
	public override string ResponseUsernamePrivateInfo => "ช\u0e37\u0e48อผ\u0e39\u0e49ใช\u0e49อาจม\u0e35ข\u0e49อม\u0e39ลส\u0e48วนต\u0e31ว";

	/// <summary>
	/// Key: "Response.UsernameRequired"
	/// validation error message
	/// English String: "Username is required."
	/// </summary>
	public override string ResponseUsernameRequired => "จำเป\u0e47นต\u0e49องระบ\u0e38ช\u0e37\u0e48อผ\u0e39\u0e49ใช\u0e49";

	/// <summary>
	/// Key: "Response.UsernameTakenTryAgain"
	/// English String: "This username is already taken! Please try a different one."
	/// </summary>
	public override string ResponseUsernameTakenTryAgain => "ช\u0e37\u0e48อผ\u0e39\u0e49ใช\u0e49น\u0e35\u0e49ถ\u0e39กนำไปใช\u0e49งานแล\u0e49ว! กร\u0e38ณาเล\u0e37อกช\u0e37\u0e48ออ\u0e37\u0e48น";

	/// <summary>
	/// Key: "Response.UsernameTooManyUnderscores"
	/// English String: "Usernames can have at most one _."
	/// </summary>
	public override string ResponseUsernameTooManyUnderscores => "ช\u0e37\u0e48อผ\u0e39\u0e49ใช\u0e49สามารถม\u0e35 _ ได\u0e49ส\u0e39งส\u0e38ดหน\u0e36\u0e48งต\u0e31ว";

	public SignUpResources_th_th(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionCreateAccount()
	{
		return "สร\u0e49างบ\u0e31ญช\u0e35";
	}

	protected override string _GetTemplateForActionLinkAccount()
	{
		return "เช\u0e37\u0e48อมโยงบ\u0e31ญช\u0e35";
	}

	protected override string _GetTemplateForActionLogInCapitalized()
	{
		return "เข\u0e49าส\u0e39\u0e48ระบบ";
	}

	protected override string _GetTemplateForActionReturnHome()
	{
		return "กล\u0e31บไปหน\u0e49าหล\u0e31ก";
	}

	protected override string _GetTemplateForActionSignUp()
	{
		return "สม\u0e31ครบ\u0e31ญช\u0e35";
	}

	protected override string _GetTemplateForActionSignupAndSync()
	{
		return "สม\u0e31ครบ\u0e31ญช\u0e35ผ\u0e39\u0e49ใช\u0e49 แล\u0e49วซ\u0e34งค\u0e4cข\u0e49อม\u0e39ล";
	}

	protected override string _GetTemplateForActionSubmit()
	{
		return "ส\u0e48ง";
	}

	protected override string _GetTemplateForDescriptionAccountLinkingWarning()
	{
		return "กร\u0e38ณาลงช\u0e37\u0e48อเข\u0e49าส\u0e39\u0e48บ\u0e31ญช\u0e35 Roblox ท\u0e35\u0e48ม\u0e35อย\u0e39\u0e48แล\u0e49วเพ\u0e37\u0e48อทำการเช\u0e37\u0e48อมโยงท\u0e35\u0e48หน\u0e49าการต\u0e31\u0e49งค\u0e48าบ\u0e31ญช\u0e35";
	}

	protected override string _GetTemplateForDescriptionNoRealName()
	{
		return "ห\u0e49ามใช\u0e49ช\u0e37\u0e48อจร\u0e34งของค\u0e38ณ";
	}

	protected override string _GetTemplateForDescriptionPrivacyPolicy()
	{
		return "นโยบายความเป\u0e47นส\u0e48วนต\u0e31ว";
	}

	/// <summary>
	/// Key: "Description.SignUpAgreement"
	/// terms of use agreement checkbox label to signup.
	/// English String: "By clicking {spanStart}Sign Up{spanEnd}, you are agreeing to the {termsOfUseLink} and acknowledging the {privacyPolicyLink}"
	/// </summary>
	public override string DescriptionSignUpAgreement(string spanStart, string spanEnd, string termsOfUseLink, string privacyPolicyLink)
	{
		return $"การคล\u0e34กท\u0e35\u0e48{spanStart}สม\u0e31ครบ\u0e31ญช\u0e35ผ\u0e39\u0e49ใช\u0e49{spanEnd} จะถ\u0e37อว\u0e48าค\u0e38ณยอมร\u0e31บ {termsOfUseLink} และร\u0e31บทราบถ\u0e36ง {privacyPolicyLink}";
	}

	protected override string _GetTemplateForDescriptionSignUpAgreement()
	{
		return "การคล\u0e34กท\u0e35\u0e48{spanStart}สม\u0e31ครบ\u0e31ญช\u0e35ผ\u0e39\u0e49ใช\u0e49{spanEnd} จะถ\u0e37อว\u0e48าค\u0e38ณยอมร\u0e31บ {termsOfUseLink} และร\u0e31บทราบถ\u0e36ง {privacyPolicyLink}";
	}

	protected override string _GetTemplateForDescriptionTermsOfService()
	{
		return "เง\u0e37\u0e48อนไขการให\u0e49บร\u0e34การ";
	}

	protected override string _GetTemplateForGuestSignUpABActionSignUp()
	{
		return "สม\u0e31ครบ\u0e31ญช\u0e35ผ\u0e39\u0e49ใช\u0e49";
	}

	protected override string _GetTemplateForHeadingConnectFacebook()
	{
		return "เช\u0e37\u0e48อมต\u0e48อก\u0e31บ Facebook";
	}

	protected override string _GetTemplateForHeadingCreateAnAccount()
	{
		return "สร\u0e49างบ\u0e31ญช\u0e35";
	}

	/// <summary>
	/// Key: "Heading.FacebookSignupAlmostDone"
	/// when user signs up using Facebook, this is shown in next step to create a password.
	/// English String: "{firstname}, YOU'RE ALMOST DONE"
	/// </summary>
	public override string HeadingFacebookSignupAlmostDone(string firstname)
	{
		return $"{firstname} ค\u0e38ณดำเน\u0e34นการเก\u0e37อบเสร\u0e47จแล\u0e49ว";
	}

	protected override string _GetTemplateForHeadingFacebookSignupAlmostDone()
	{
		return "{firstname} ค\u0e38ณดำเน\u0e34นการเก\u0e37อบเสร\u0e47จแล\u0e49ว";
	}

	protected override string _GetTemplateForHeadingLoginHaveFun()
	{
		return "เข\u0e49าส\u0e39\u0e48ระบบ แล\u0e49วเร\u0e34\u0e48มสน\u0e38กก\u0e31นได\u0e49เลย!";
	}

	protected override string _GetTemplateForHeadingSignupHaveFun()
	{
		return "สม\u0e31ครบ\u0e31ญช\u0e35ผ\u0e39\u0e49ใช\u0e49 แล\u0e49วเร\u0e34\u0e48มสน\u0e38กก\u0e31นได\u0e49เลย!";
	}

	protected override string _GetTemplateForLabelAbout()
	{
		return "เก\u0e35\u0e48ยวก\u0e31บ";
	}

	protected override string _GetTemplateForLabelAlreadyHaveRobloxAccount()
	{
		return "ม\u0e35บ\u0e31ญช\u0e35 Roblox อย\u0e39\u0e48แล\u0e49ว?";
	}

	protected override string _GetTemplateForLabelAlreadyRegistered()
	{
		return "เคยลงทะเบ\u0e35ยนอย\u0e39\u0e48แล\u0e49ว?";
	}

	protected override string _GetTemplateForLabelBirthday()
	{
		return "ว\u0e31นเก\u0e34ด";
	}

	protected override string _GetTemplateForLabelBirthdayWithColumn()
	{
		return "ว\u0e31นเก\u0e34ด:";
	}

	protected override string _GetTemplateForLabelConfirmPassword()
	{
		return "ย\u0e37นย\u0e31นรห\u0e31สผ\u0e48าน";
	}

	protected override string _GetTemplateForLabelDay()
	{
		return "ว\u0e31น";
	}

	protected override string _GetTemplateForLabelDesiredUsername()
	{
		return "ช\u0e37\u0e48อผ\u0e39\u0e49ใช\u0e49ท\u0e35\u0e48ต\u0e49องการ:";
	}

	protected override string _GetTemplateForLabelFacebookNotLinked()
	{
		return "บ\u0e31ญช\u0e35 Facebook ของค\u0e38ณไม\u0e48ได\u0e49เช\u0e37\u0e48อมโยงก\u0e31บบ\u0e31ญช\u0e35 Roblox ใดเลย กร\u0e38ณาสม\u0e31ครบ\u0e31ญช\u0e35 Roblox";
	}

	protected override string _GetTemplateForLabelFacebookSignupUsername()
	{
		return "สร\u0e49างช\u0e37\u0e48อผ\u0e39\u0e49ใช\u0e49 Roblox:";
	}

	protected override string _GetTemplateForLabelFemale()
	{
		return "หญ\u0e34ง";
	}

	protected override string _GetTemplateForLabelGender()
	{
		return "เพศ";
	}

	protected override string _GetTemplateForLabelGenderRequired()
	{
		return "จำเป\u0e47นต\u0e49องระบ\u0e38เพศ";
	}

	protected override string _GetTemplateForLabelGenderWithColumn()
	{
		return "เพศ:";
	}

	protected override string _GetTemplateForLabelMale()
	{
		return "ชาย";
	}

	protected override string _GetTemplateForLabelMonth()
	{
		return "เด\u0e37อน";
	}

	protected override string _GetTemplateForLabelPassword()
	{
		return "รห\u0e31สผ\u0e48าน";
	}

	protected override string _GetTemplateForLabelPasswordRequirements()
	{
		return "รห\u0e31สผ\u0e48าน (ยาวอย\u0e48างน\u0e49อย 8)";
	}

	protected override string _GetTemplateForLabelPlatforms()
	{
		return "แพลตฟอร\u0e4cม";
	}

	protected override string _GetTemplateForLabelPlay()
	{
		return "เล\u0e48น";
	}

	protected override string _GetTemplateForLabelPleaseAgreeToTerms()
	{
		return "กร\u0e38ณายอมร\u0e31บเง\u0e37\u0e48อนไขการให\u0e49บร\u0e34การและนโยบายความเป\u0e47นส\u0e48วนต\u0e31วของเรา";
	}

	protected override string _GetTemplateForLabelRequired()
	{
		return "จำเป\u0e47นต\u0e49องม\u0e35";
	}

	protected override string _GetTemplateForLabelSignupButtonText()
	{
		return "สม\u0e31ครแล\u0e49วเล\u0e48นเลย!";
	}

	protected override string _GetTemplateForLabelSignUpWith()
	{
		return "หร\u0e37อสม\u0e31ครบ\u0e31ญช\u0e35ผ\u0e39\u0e49ใช\u0e49ด\u0e49วย";
	}

	protected override string _GetTemplateForLabelTermsOfUse()
	{
		return "เง\u0e37\u0e48อนไขการใช\u0e49งาน";
	}

	protected override string _GetTemplateForLabelUsername()
	{
		return "ช\u0e37\u0e48อผ\u0e39\u0e49ใช\u0e49";
	}

	protected override string _GetTemplateForLabelUsernameCharacterLimit()
	{
		return "ต\u0e31วเลขหร\u0e37อต\u0e31วอ\u0e31กษร 3-20 ต\u0e31ว ห\u0e49ามม\u0e35เว\u0e49นวรรค";
	}

	protected override string _GetTemplateForLabelUsernameHint()
	{
		return "ช\u0e37\u0e48อผ\u0e39\u0e49ใช\u0e49 (ท\u0e35\u0e48ไม\u0e48ใช\u0e48ช\u0e37\u0e48อจร\u0e34งของค\u0e38ณ)";
	}

	protected override string _GetTemplateForLabelUsernameRequirements()
	{
		return "ช\u0e37\u0e48อผ\u0e39\u0e49ใช\u0e49 (ความยาว 3-20 อน\u0e38ญาตให\u0e49ใช\u0e49 _)";
	}

	protected override string _GetTemplateForLabelYear()
	{
		return "ป\u0e35";
	}

	protected override string _GetTemplateForMessagePasswordMinLength()
	{
		return "ยาวอย\u0e48างน\u0e49อย 8";
	}

	protected override string _GetTemplateForMessageUsernameNoRealNameUse()
	{
		return "อย\u0e48าใช\u0e49ช\u0e37\u0e48อจร\u0e34งของค\u0e38ณ";
	}

	protected override string _GetTemplateForResponseBadUsername()
	{
		return "ช\u0e37\u0e48อผ\u0e39\u0e49ใช\u0e49ไม\u0e48เหมาะสมสำหร\u0e31บ Roblox";
	}

	protected override string _GetTemplateForResponseBadUsernameForWeChat()
	{
		return "ช\u0e37\u0e48อผ\u0e39\u0e49ใช\u0e49ไม\u0e48เหมาะสม";
	}

	protected override string _GetTemplateForResponseBirthdayInvalid()
	{
		return "ว\u0e31นเก\u0e34ดน\u0e35\u0e49ไม\u0e48ถ\u0e39กต\u0e49อง";
	}

	protected override string _GetTemplateForResponseBirthdayMustBeSetFirst()
	{
		return "จะต\u0e49องระบ\u0e38ว\u0e31นเก\u0e34ดก\u0e48อน";
	}

	protected override string _GetTemplateForResponseCaptchaMismatchError()
	{
		return "คำไม\u0e48ตรงก\u0e31น";
	}

	protected override string _GetTemplateForResponseCaptchaNotEnteredError()
	{
		return "กร\u0e38ณาป\u0e49อน Captcha";
	}

	protected override string _GetTemplateForResponseFacebookConnectionError()
	{
		return "เก\u0e34ดข\u0e49อผ\u0e34ดพลาดขณะพยายามด\u0e36งข\u0e49อม\u0e39ลของค\u0e38ณจาก Facebook";
	}

	protected override string _GetTemplateForResponseFacebookLoginAge()
	{
		return "การเข\u0e49าส\u0e39\u0e48ระบบ Facebook จะสามารถใช\u0e49งานได\u0e49โดยผ\u0e39\u0e49ใช\u0e49อาย\u0e38 13 ป\u0e35ข\u0e36\u0e49นไปเท\u0e48าน\u0e31\u0e49น";
	}

	protected override string _GetTemplateForResponseInvalidBirthday()
	{
		return "ว\u0e31นเก\u0e34ดไม\u0e48ถ\u0e39กต\u0e49อง";
	}

	protected override string _GetTemplateForResponseInvalidEmail()
	{
		return "ท\u0e35\u0e48อย\u0e39\u0e48อ\u0e35เมลไม\u0e48ถ\u0e39กต\u0e49อง";
	}

	protected override string _GetTemplateForResponseJavaScriptRequired()
	{
		return "จำเป\u0e47นต\u0e49องใช\u0e49 JavaScript เพ\u0e37\u0e48อส\u0e48งแบบฟอร\u0e4cมน\u0e35\u0e49";
	}

	protected override string _GetTemplateForResponsePasswordComplexity()
	{
		return "กร\u0e38ณาเล\u0e37อกรห\u0e31สผ\u0e48านท\u0e35\u0e48ซ\u0e31บซ\u0e49อนมากข\u0e36\u0e49น";
	}

	protected override string _GetTemplateForResponsePasswordConfirmation()
	{
		return "กร\u0e38ณาป\u0e49อนรห\u0e31สผ\u0e48านย\u0e37นย\u0e31น";
	}

	protected override string _GetTemplateForResponsePasswordContainsUsernameError()
	{
		return "รห\u0e31สผ\u0e48านไม\u0e48ควรตรงก\u0e31บช\u0e37\u0e48อผ\u0e39\u0e49ใช\u0e49";
	}

	protected override string _GetTemplateForResponsePasswordMismatch()
	{
		return "รห\u0e31สผ\u0e48านไม\u0e48ตรงก\u0e31น";
	}

	protected override string _GetTemplateForResponsePasswordWrongShort()
	{
		return "รห\u0e31สผ\u0e48านจะต\u0e49องยาวอย\u0e48างน\u0e49อย 8 อ\u0e31กขระ";
	}

	protected override string _GetTemplateForResponsePleaseEnterPassword()
	{
		return "กร\u0e38ณาป\u0e49อนรห\u0e31สผ\u0e48าน";
	}

	protected override string _GetTemplateForResponsePleaseEnterUsername()
	{
		return "กร\u0e38ณาป\u0e49อนช\u0e37\u0e48อผ\u0e39\u0e49ใช\u0e49";
	}

	protected override string _GetTemplateForResponseSocialAccountCreationFailed()
	{
		return "การสร\u0e49างบ\u0e31ญช\u0e35ล\u0e49มเหลว";
	}

	protected override string _GetTemplateForResponseSpaceOrSpecialCharaterError()
	{
		return "ไม\u0e48อน\u0e38ญาตให\u0e49ใช\u0e49ช\u0e48องว\u0e48างและอ\u0e31กขระพ\u0e34เศษ";
	}

	protected override string _GetTemplateForResponseTooManyAccountsWithSameEmailError()
	{
		return "ม\u0e35บ\u0e31ญช\u0e35ท\u0e35\u0e48ใช\u0e49งานอ\u0e35เมลน\u0e35\u0e49มากเก\u0e34นไป";
	}

	protected override string _GetTemplateForResponseUnknownError()
	{
		return "ขออภ\u0e31ย! เก\u0e34ดข\u0e49อผ\u0e34ดพลาดท\u0e35\u0e48ไม\u0e48ทราบสาเหต\u0e38 กร\u0e38ณาลองใหม\u0e48อ\u0e35กคร\u0e31\u0e49งในภายหล\u0e31ง";
	}

	protected override string _GetTemplateForResponseUsernameAllowedCharactersError()
	{
		return "ช\u0e37\u0e48อผ\u0e39\u0e49ใช\u0e49สามารถม\u0e35ได\u0e49เพ\u0e35ยงต\u0e31วอ\u0e31กษร, ต\u0e31วเลข และ_";
	}

	protected override string _GetTemplateForResponseUsernameAlreadyInUse()
	{
		return "ม\u0e35การใช\u0e49งานช\u0e37\u0e48อผ\u0e39\u0e49ใช\u0e49น\u0e35\u0e49ไปแล\u0e49ว";
	}

	protected override string _GetTemplateForResponseUsernameExplicit()
	{
		return "ไม\u0e48ได\u0e49ร\u0e31บอน\u0e38ญาตให\u0e49ใช\u0e49ช\u0e37\u0e48อผ\u0e39\u0e49ใช\u0e49น\u0e35\u0e49 กร\u0e38ณาลองช\u0e37\u0e48ออ\u0e37\u0e48น";
	}

	protected override string _GetTemplateForResponseUsernameInvalid()
	{
		return "กร\u0e38ณาป\u0e49อนช\u0e37\u0e48อผ\u0e39\u0e49ใช\u0e49ท\u0e35\u0e48ถ\u0e39กต\u0e49อง";
	}

	protected override string _GetTemplateForResponseUsernameInvalidCharacters()
	{
		return "อน\u0e38ญาตให\u0e49ม\u0e35เพ\u0e35ยงแค\u0e48 a–z, A–Z, 0-9 และ _ เท\u0e48าน\u0e31\u0e49น";
	}

	protected override string _GetTemplateForResponseUsernameInvalidLength()
	{
		return "ช\u0e37\u0e48อผ\u0e39\u0e49ใช\u0e49สามารถม\u0e35ความยาวได\u0e49ระหว\u0e48าง 3 ถ\u0e36ง 20 อ\u0e31กขระ";
	}

	protected override string _GetTemplateForResponseUsernameInvalidUnderscore()
	{
		return "ช\u0e37\u0e48อผ\u0e39\u0e49ใช\u0e49ไม\u0e48สามารถเร\u0e34\u0e48มต\u0e49นหร\u0e37อลงท\u0e49ายด\u0e49วย _ ได\u0e49";
	}

	protected override string _GetTemplateForResponseUsernameNotAvailable()
	{
		return "ช\u0e37\u0e48อผ\u0e39\u0e49ใช\u0e49ไม\u0e48พร\u0e49อม กร\u0e38ณาลองใหม\u0e48อ\u0e35กคร\u0e31\u0e49ง";
	}

	protected override string _GetTemplateForResponseUsernameOrPasswordIncorrect()
	{
		return "ช\u0e37\u0e48อผ\u0e39\u0e49ใช\u0e49หร\u0e37อรห\u0e31สผ\u0e48านของค\u0e38ณไม\u0e48ถ\u0e39กต\u0e49อง";
	}

	protected override string _GetTemplateForResponseUsernamePasswordRequired()
	{
		return "จำเป\u0e47นต\u0e49องม\u0e35ช\u0e37\u0e48อผ\u0e39\u0e49ใช\u0e49และรห\u0e31สผ\u0e48าน";
	}

	protected override string _GetTemplateForResponseUsernamePrivateInfo()
	{
		return "ช\u0e37\u0e48อผ\u0e39\u0e49ใช\u0e49อาจม\u0e35ข\u0e49อม\u0e39ลส\u0e48วนต\u0e31ว";
	}

	protected override string _GetTemplateForResponseUsernameRequired()
	{
		return "จำเป\u0e47นต\u0e49องระบ\u0e38ช\u0e37\u0e48อผ\u0e39\u0e49ใช\u0e49";
	}

	protected override string _GetTemplateForResponseUsernameTakenTryAgain()
	{
		return "ช\u0e37\u0e48อผ\u0e39\u0e49ใช\u0e49น\u0e35\u0e49ถ\u0e39กนำไปใช\u0e49งานแล\u0e49ว! กร\u0e38ณาเล\u0e37อกช\u0e37\u0e48ออ\u0e37\u0e48น";
	}

	protected override string _GetTemplateForResponseUsernameTooManyUnderscores()
	{
		return "ช\u0e37\u0e48อผ\u0e39\u0e49ใช\u0e49สามารถม\u0e35 _ ได\u0e49ส\u0e39งส\u0e38ดหน\u0e36\u0e48งต\u0e31ว";
	}
}
