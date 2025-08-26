namespace Roblox.Platform.TranslationResources.Authentication {
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
	public override string ActionCreateAccount => "Táº¡o TÃ i khoáº£n";

	/// <summary>
	/// Key: "Action.LinkAccount"
	/// Button text to link 3rd Party Account to a Roblox Account
	/// English String: "Link Account"
	/// </summary>
	public override string ActionLinkAccount => "LiÃªn káº¿t TÃ i khoáº£n";

	/// <summary>
	/// Key: "Action.LogInCapitalized"
	/// button label for capitalized words for Log In
	/// English String: "Log In"
	/// </summary>
	public override string ActionLogInCapitalized => "ÄÄƒng nháº­p";

	/// <summary>
	/// Key: "Action.ReturnHome"
	/// button label to return the user to home page
	/// English String: "Return Home"
	/// </summary>
	public override string ActionReturnHome => "Trá»Ÿ láº¡i Trang chá»§";

	/// <summary>
	/// Key: "Action.SignUp"
	/// English String: "Sign up"
	/// </summary>
	public override string ActionSignUp => "ÄÄƒng kÃ½";

	public override string ActionSignupAndSync => "ÄÄƒng kÃ½ & Äá»“ng bá»™";

	/// <summary>
	/// Key: "Action.Submit"
	/// English String: "Submit"
	/// </summary>
	public override string ActionSubmit => "Gá»­i";

	/// <summary>
	/// Key: "Description.AccountLinkingWarning"
	/// instructions for linking account on signup page for FB based account
	/// English String: "To link to an existing Roblox account, sign in and link them on the account settings page."
	/// </summary>
	public override string DescriptionAccountLinkingWarning => "Äá»ƒ liÃªn káº¿t vá»›i tÃ i khoáº£n Roblox cÃ³ sáºµn, hÃ£y Ä‘Äƒng nháº­p vÃ  liÃªn káº¿t chÃºng trÃªn trang cÃ i Ä‘áº·t tÃ i khoáº£n.";

	/// <summary>
	/// Key: "Description.NoRealName"
	/// description
	/// English String: "Do not use your real name."
	/// </summary>
	public override string DescriptionNoRealName => "KhÃ´ng dÃ¹ng tÃªn tháº­t cá»§a báº¡n.";

	/// <summary>
	/// Key: "Description.PrivacyPolicy"
	/// English String: "Privacy Policy"
	/// </summary>
	public override string DescriptionPrivacyPolicy => "ChÃ­nh sÃ¡ch riÃªng tÆ°";

	/// <summary>
	/// Key: "Description.TermsOfService"
	/// English String: "Terms of Service"
	/// </summary>
	public override string DescriptionTermsOfService => "Äiá»u khoáº£n dá»‹ch vá»¥";

	/// <summary>
	/// Key: "GuestSignUpAB.Action.SignUp"
	/// English String: "Sign Up"
	/// </summary>
	public override string GuestSignUpABActionSignUp => "ÄÄƒng kÃ½";

	/// <summary>
	/// Key: "Heading.ConnectFacebook"
	/// section heading
	/// English String: "Connect to Facebook"
	/// </summary>
	public override string HeadingConnectFacebook => "Káº¿t ná»‘i vá»›i Facebook";

	/// <summary>
	/// Key: "Heading.CreateAnAccount"
	/// should be capitalized if the language supports capitalization
	/// English String: "CREATE AN ACCOUNT"
	/// </summary>
	public override string HeadingCreateAnAccount => "Táº O TÃ€I KHOáº¢N";

	/// <summary>
	/// Key: "Heading.LoginHaveFun"
	/// heading for login container
	/// English String: "Log in and start having fun!"
	/// </summary>
	public override string HeadingLoginHaveFun => "ÄÄƒng nháº­p vÃ  giáº£i trÃ­!";

	/// <summary>
	/// Key: "Heading.SignupHaveFun"
	/// signup form heading
	/// English String: "Sign up and start having fun!"
	/// </summary>
	public override string HeadingSignupHaveFun => "ÄÄƒng kÃ½ vÃ  giáº£i trÃ­!";

	/// <summary>
	/// Key: "Label.About"
	/// About link on roller coaster page
	/// English String: "About"
	/// </summary>
	public override string LabelAbout => "Vá» sáº£n pháº©m";

	/// <summary>
	/// Key: "Label.AlreadyHaveRobloxAccount"
	/// English String: "Already have a Roblox account?"
	/// </summary>
	public override string LabelAlreadyHaveRobloxAccount => "Báº¡n Ä‘Ã£ cÃ³ tÃ i khoáº£n Roblox?";

	/// <summary>
	/// Key: "Label.AlreadyRegistered"
	/// label
	/// English String: "Already registered?"
	/// </summary>
	public override string LabelAlreadyRegistered => "ÄÃ£ Ä‘Äƒng kÃ½?";

	/// <summary>
	/// Key: "Label.Birthday"
	/// English String: "Birthday"
	/// </summary>
	public override string LabelBirthday => "NgÃ y sinh";

	/// <summary>
	/// Key: "Label.BirthdayWithColumn"
	/// should have column if the language supports it
	/// English String: "Birthday:"
	/// </summary>
	public override string LabelBirthdayWithColumn => "NgÃ y sinh:";

	/// <summary>
	/// Key: "Label.ConfirmPassword"
	/// English String: "Confirm password"
	/// </summary>
	public override string LabelConfirmPassword => "XÃ¡c nháº­n máº­t kháº©u";

	/// <summary>
	/// Key: "Label.Day"
	/// English String: "Day"
	/// </summary>
	public override string LabelDay => "NgÃ y";

	/// <summary>
	/// Key: "Label.DesiredUsername"
	/// should have a column if the language supports it
	/// English String: "Desired Username:"
	/// </summary>
	public override string LabelDesiredUsername => "TÃªn ngÆ°á»i dÃ¹ng muá»‘n Ä‘áº·t:";

	/// <summary>
	/// Key: "Label.FacebookNotLinked"
	/// English String: "Your Facebook account is not linked to any Roblox account. Please sign up for a Roblox account."
	/// </summary>
	public override string LabelFacebookNotLinked => "TÃ i khoáº£n Facebook cá»§a báº¡n khÃ´ng Ä‘Æ°á»£c liÃªn káº¿t vá»›i báº¥t ká»³ tÃ i khoáº£n Roblox nÃ o. Vui lÃ²ng Ä‘Äƒng kÃ½ má»™t tÃ i khoáº£n Roblox.";

	/// <summary>
	/// Key: "Label.FacebookSignupUsername"
	/// username field label for FB signup
	/// English String: "Create Roblox username:"
	/// </summary>
	public override string LabelFacebookSignupUsername => "Táº¡o tÃªn ngÆ°á»i dÃ¹ng Roblox:";

	/// <summary>
	/// Key: "Label.Female"
	/// label
	/// English String: "Female"
	/// </summary>
	public override string LabelFemale => "Ná»¯";

	/// <summary>
	/// Key: "Label.Gender"
	/// English String: "Gender"
	/// </summary>
	public override string LabelGender => "Giá»›i tÃ­nh";

	/// <summary>
	/// Key: "Label.GenderRequired"
	/// English String: "Gender is required."
	/// </summary>
	public override string LabelGenderRequired => "Cáº§n pháº£i chá»n giá»›i tÃ­nh.";

	/// <summary>
	/// Key: "Label.GenderWithColumn"
	/// should have column if the language supports it
	/// English String: "Gender:"
	/// </summary>
	public override string LabelGenderWithColumn => "Giá»›i tÃ­nh:";

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
	public override string LabelMonth => "ThÃ¡ng";

	/// <summary>
	/// Key: "Label.Password"
	/// English String: "Password"
	/// </summary>
	public override string LabelPassword => "Máº­t kháº©u";

	/// <summary>
	/// Key: "Label.PasswordRequirements"
	/// English String: "Password (min length 8)"
	/// </summary>
	public override string LabelPasswordRequirements => "Máº­t kháº©u (tá»‘i thiá»ƒu 8 kÃ½ tá»±)";

	/// <summary>
	/// Key: "Label.Platforms"
	/// platforms link on roller coaster page
	/// English String: "Platforms"
	/// </summary>
	public override string LabelPlatforms => "Ná»n táº£ng";

	/// <summary>
	/// Key: "Label.Play"
	/// Play link on roller coaster page
	/// English String: "Play"
	/// </summary>
	public override string LabelPlay => "ChÆ¡i";

	/// <summary>
	/// Key: "Label.PleaseAgreeToTerms"
	/// English String: "Please agree to our Terms of Use and Privacy Policy."
	/// </summary>
	public override string LabelPleaseAgreeToTerms => "Vui lÃ²ng Ä‘á»“ng kÃ½ vá»›i Äiá»u khoáº£n sá»­ dá»¥ng vÃ  ChÃ­nh sÃ¡ch riÃªng tÆ° cá»§a chÃºng tÃ´i.";

	/// <summary>
	/// Key: "Label.Required"
	/// Required
	/// English String: "Required"
	/// </summary>
	public override string LabelRequired => "Báº¯t buá»™c";

	/// <summary>
	/// Key: "Label.SignupButtonText"
	/// sign up button text
	/// English String: "Sign Up and Play!"
	/// </summary>
	public override string LabelSignupButtonText => "ÄÄƒng kÃ½ vÃ  ChÆ¡i!";

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
	public override string LabelSignUpWith => "hoáº·c Ä‘Äƒng kÃ½ báº±ng";

	/// <summary>
	/// Key: "Label.TermsOfUse"
	/// terms of use link label
	/// English String: "Terms of Use"
	/// </summary>
	public override string LabelTermsOfUse => "Äiá»u khoáº£n sá»­ dá»¥ng";

	/// <summary>
	/// Key: "Label.Username"
	/// English String: "Username"
	/// </summary>
	public override string LabelUsername => "TÃªn ngÆ°á»i dÃ¹ng";

	/// <summary>
	/// Key: "Label.UsernameCharacterLimit"
	/// label
	/// English String: "3-20 alphanumeric characters, no spaces."
	/// </summary>
	public override string LabelUsernameCharacterLimit => "CÃ³ tá»« 3-20 chá»¯ cÃ¡i vÃ  chá»¯ sá»‘, khÃ´ng chá»©a kÃ½ tá»± trá»‘ng.";

	/// <summary>
	/// Key: "Label.UsernameHint"
	/// placeholder for username field
	/// English String: "Username (don't use your real name)"
	/// </summary>
	public override string LabelUsernameHint => "TÃªn ngÆ°á»i dÃ¹ng (khÃ´ng dÃ¹ng tÃªn tháº­t cá»§a báº¡n)";

	/// <summary>
	/// Key: "Label.UsernameRequirements"
	/// English String: "Username (length 3-20, _ is allowed)"
	/// </summary>
	public override string LabelUsernameRequirements => "TÃªn ngÆ°á»i dÃ¹ng (tá»« 3-20 kÃ½ tá»±, _ Ä‘Æ°á»£c cho phÃ©p)";

	/// <summary>
	/// Key: "Label.Year"
	/// English String: "Year"
	/// </summary>
	public override string LabelYear => "NÄƒm";

	/// <summary>
	/// Key: "Message.Password.MinLength"
	/// English String: "Min length 8"
	/// </summary>
	public override string MessagePasswordMinLength => "Tá»‘i thiá»ƒu 8 kÃ½ tá»±";

	/// <summary>
	/// Key: "Message.Username.NoRealNameUse"
	/// English String: "Don't use your real name"
	/// </summary>
	public override string MessageUsernameNoRealNameUse => "KhÃ´ng dÃ¹ng tÃªn tháº­t cá»§a báº¡n";

	/// <summary>
	/// Key: "Response.BadUsername"
	/// English String: "Username not appropriate for Roblox."
	/// </summary>
	public override string ResponseBadUsername => "TÃªn ngÆ°á»i dÃ¹ng khÃ´ng phÃ¹ há»£p vá»›i Roblox.";

	/// <summary>
	/// Key: "Response.BadUsernameForWeChat"
	/// message shown when signing up with an inappropriate username
	/// English String: "Username is not appropriate"
	/// </summary>
	public override string ResponseBadUsernameForWeChat => "TÃªn ngÆ°á»i dÃ¹ng khÃ´ng phÃ¹ há»£p";

	/// <summary>
	/// Key: "Response.BirthdayInvalid"
	/// English String: "This birthday is invalid."
	/// </summary>
	public override string ResponseBirthdayInvalid => "NgÃ y sinh nÃ y khÃ´ng há»£p lá»‡.";

	/// <summary>
	/// Key: "Response.BirthdayMustBeSetFirst"
	/// English String: "Birthday must be set first."
	/// </summary>
	public override string ResponseBirthdayMustBeSetFirst => "Pháº£i chá»n ngÃ y sinh trÆ°á»›c.";

	/// <summary>
	/// Key: "Response.CaptchaMismatchError"
	/// error message
	/// English String: "Words do not match."
	/// </summary>
	public override string ResponseCaptchaMismatchError => "CÃ¡c tá»« khÃ´ng trÃ¹ng.";

	/// <summary>
	/// Key: "Response.CaptchaNotEnteredError"
	/// validation error message
	/// English String: "Please fill out the Captcha"
	/// </summary>
	public override string ResponseCaptchaNotEnteredError => "Vui lÃ²ng Ä‘iá»n mÃ£ Captcha";

	/// <summary>
	/// Key: "Response.FacebookConnectionError"
	/// error message
	/// English String: "Error while retrieving values from Facebook."
	/// </summary>
	public override string ResponseFacebookConnectionError => "Xáº£y ra lá»—i khi truy xuáº¥t giÃ¡ trá»‹ tá»« Facebook.";

	/// <summary>
	/// Key: "Response.FacebookLoginAge"
	/// English String: "Facebook login can only be used by users above 13."
	/// </summary>
	public override string ResponseFacebookLoginAge => "Chá»‰ ngÆ°á»i dÃ¹ng trÃªn 13 tuá»•i má»›i cÃ³ thá»ƒ sá»­ dá»¥ng Ä‘Äƒng nháº­p báº±ng Facebook.";

	/// <summary>
	/// Key: "Response.InvalidBirthday"
	/// English String: "Invalid birthday."
	/// </summary>
	public override string ResponseInvalidBirthday => "NgÃ y sinh khÃ´ng há»£p lá»‡.";

	/// <summary>
	/// Key: "Response.InvalidEmail"
	/// English String: "Invalid email address."
	/// </summary>
	public override string ResponseInvalidEmail => "Äá»‹a chá»‰ email khÃ´ng há»£p lá»‡.";

	/// <summary>
	/// Key: "Response.JavaScriptRequired"
	/// error to show that JavaScipt is required for the form to work
	/// English String: "JavaScript is required to submit this form."
	/// </summary>
	public override string ResponseJavaScriptRequired => "Pháº£i báº­t JavaScript Ä‘á»ƒ gá»­i máº«u nÃ y.";

	/// <summary>
	/// Key: "Response.PasswordComplexity"
	/// English String: "Please create a more complex password."
	/// </summary>
	public override string ResponsePasswordComplexity => "Vui lÃ²ng táº¡o máº­t kháº©u khÃ³ Ä‘oÃ¡n hÆ¡n.";

	/// <summary>
	/// Key: "Response.PasswordConfirmation"
	/// validation message for password confirmation
	/// English String: "Please enter a password confirmation."
	/// </summary>
	public override string ResponsePasswordConfirmation => "Vui lÃ²ng nháº­p máº­t kháº©u xÃ¡c nháº­n.";

	/// <summary>
	/// Key: "Response.PasswordContainsUsernameError"
	/// error when passsword has username in it
	/// English String: "Password shouldn't match username."
	/// </summary>
	public override string ResponsePasswordContainsUsernameError => "Máº­t kháº©u khÃ´ng nÃªn trÃ¹ng vá»›i tÃªn ngÆ°á»i dÃ¹ng.";

	/// <summary>
	/// Key: "Response.PasswordMismatch"
	/// English String: "Passwords do not match."
	/// </summary>
	public override string ResponsePasswordMismatch => "Máº­t kháº©u khÃ´ng trÃ¹ng nhau.";

	/// <summary>
	/// Key: "Response.PasswordWrongShort"
	/// English String: "Passwords must be at least 8 characters long."
	/// </summary>
	public override string ResponsePasswordWrongShort => "Máº­t kháº©u pháº£i cÃ³ tá»‘i thiá»ƒu 8 kÃ½ tá»±.";

	/// <summary>
	/// Key: "Response.PleaseEnterPassword"
	/// English String: "Please enter a password."
	/// </summary>
	public override string ResponsePleaseEnterPassword => "Vui lÃ²ng nháº­p máº­t kháº©u.";

	/// <summary>
	/// Key: "Response.PleaseEnterUsername"
	/// English String: "Please enter a username."
	/// </summary>
	public override string ResponsePleaseEnterUsername => "Vui lÃ²ng nháº­p tÃªn ngÆ°á»i dÃ¹ng.";

	/// <summary>
	/// Key: "Response.SocialAccountCreationFailed"
	/// error message
	/// English String: "Account creation failed"
	/// </summary>
	public override string ResponseSocialAccountCreationFailed => "KhÃ´ng thá»ƒ táº¡o tÃ i khoáº£n";

	/// <summary>
	/// Key: "Response.SpaceOrSpecialCharaterError"
	/// Spaces and special characters are not allowed error message
	/// English String: "Spaces and special characters are not allowed."
	/// </summary>
	public override string ResponseSpaceOrSpecialCharaterError => "KhÃ´ng Ä‘Æ°á»£c nháº­p kÃ½ tá»± trá»‘ng vÃ  kÃ½ tá»± Ä‘áº·c biá»‡t.";

	/// <summary>
	/// Key: "Response.TooManyAccountsWithSameEmailError"
	/// Too many accounts use this email error message
	/// English String: "Too many accounts use this email."
	/// </summary>
	public override string ResponseTooManyAccountsWithSameEmailError => "CÃ³ quÃ¡ nhiá»u tÃ i khoáº£n sá»­ dá»¥ng email nÃ y.";

	/// <summary>
	/// Key: "Response.UnknownError"
	/// English String: "Sorry! An unknown error occurred. Please try again later."
	/// </summary>
	public override string ResponseUnknownError => "Ráº¥t tiáº¿c! ÄÃ£ xáº£y ra lá»—i khÃ´ng xÃ¡c Ä‘á»‹nh. Vui lÃ²ng thá»­ láº¡i sau.";

	/// <summary>
	/// Key: "Response.UsernameAllowedCharactersError"
	/// error showing which characters are allowed for username
	/// English String: "Usernames may only contain letters, numbers, and _."
	/// </summary>
	public override string ResponseUsernameAllowedCharactersError => "TÃªn ngÆ°á»i dÃ¹ng chá»‰ Ä‘Æ°á»£c chá»©a chá»¯ cÃ¡i, chá»¯ sá»‘ vÃ  kÃ½ tá»± _.";

	/// <summary>
	/// Key: "Response.UsernameAlreadyInUse"
	/// English String: "This username is already in use."
	/// </summary>
	public override string ResponseUsernameAlreadyInUse => "TÃªn ngÆ°á»i dÃ¹ng Ä‘Ã£ Ä‘Æ°á»£c sá»­ dá»¥ng.";

	/// <summary>
	/// Key: "Response.UsernameExplicit"
	/// English String: "This username is not allowed, please try another."
	/// </summary>
	public override string ResponseUsernameExplicit => "KhÃ´ng thá»ƒ sá»­ dá»¥ng tÃªn nÃ y, xin chá»n tÃªn khÃ¡c.";

	/// <summary>
	/// Key: "Response.UsernameInvalid"
	/// English String: "Please enter a valid username."
	/// </summary>
	public override string ResponseUsernameInvalid => "Vui lÃ²ng nháº­p tÃªn ngÆ°á»i dÃ¹ng há»£p lá»‡.";

	/// <summary>
	/// Key: "Response.UsernameInvalidCharacters"
	/// English String: "Only a-z, A-Z, 0-9 and _ are allowed."
	/// </summary>
	public override string ResponseUsernameInvalidCharacters => "Chá»‰ Ä‘Æ°á»£c dÃ¹ng cÃ¡c kÃ½ tá»± a-z, A-Z, 0-9 vÃ  kÃ½ tá»± _.";

	/// <summary>
	/// Key: "Response.UsernameInvalidLength"
	/// English String: "Usernames can be 3 to 20 characters long."
	/// </summary>
	public override string ResponseUsernameInvalidLength => "TÃªn ngÆ°á»i dÃ¹ng cÃ³ thá»ƒ dÃ i tá»« 3 Ä‘áº¿n 20 kÃ½ tá»±.";

	/// <summary>
	/// Key: "Response.UsernameInvalidUnderscore"
	/// English String: "Usernames cannot start or end with _."
	/// </summary>
	public override string ResponseUsernameInvalidUnderscore => "KhÃ´ng thá»ƒ báº¯t Ä‘áº§u/káº¿t thÃºc vá»›i kÃ½ tá»± _.";

	/// <summary>
	/// Key: "Response.UsernameNotAvailable"
	/// English String: "Username not available. Please try again."
	/// </summary>
	public override string ResponseUsernameNotAvailable => "TÃªn ngÆ°á»i dÃ¹ng khÃ´ng kháº£ dá»¥ng. Vui lÃ²ng thá»­ láº¡i.";

	/// <summary>
	/// Key: "Response.UsernameOrPasswordIncorrect"
	/// Your username or password is incorrect
	/// English String: "Your username or password is incorrect."
	/// </summary>
	public override string ResponseUsernameOrPasswordIncorrect => "Sai tÃªn ngÆ°á»i dÃ¹ng hoáº·c máº­t kháº©u.";

	/// <summary>
	/// Key: "Response.UsernamePasswordRequired"
	/// Username and Password are required error message
	/// English String: "Username and Password are required."
	/// </summary>
	public override string ResponseUsernamePasswordRequired => "Pháº£i nháº­p Máº­t kháº©u vÃ  TÃªn ngÆ°á»i dÃ¹ng.";

	/// <summary>
	/// Key: "Response.UsernamePrivateInfo"
	/// English String: "Username might contain private information."
	/// </summary>
	public override string ResponseUsernamePrivateInfo => "TÃªn ngÆ°á»i dÃ¹ng cÃ³ thá»ƒ chá»©a thÃ´ng tin cÃ¡ nhÃ¢n.";

	/// <summary>
	/// Key: "Response.UsernameRequired"
	/// validation error message
	/// English String: "Username is required."
	/// </summary>
	public override string ResponseUsernameRequired => "Báº¯t buá»™c pháº£i cÃ³ tÃªn ngÆ°á»i dÃ¹ng.";

	/// <summary>
	/// Key: "Response.UsernameTakenTryAgain"
	/// English String: "This username is already taken! Please try a different one."
	/// </summary>
	public override string ResponseUsernameTakenTryAgain => "TÃªn ngÆ°á»i dÃ¹ng nÃ y Ä‘Ã£ Ä‘Æ°á»£c sá»­ dá»¥ng! Vui lÃ²ng thá»­ tÃªn khÃ¡c.";

	/// <summary>
	/// Key: "Response.UsernameTooManyUnderscores"
	/// English String: "Usernames can have at most one _."
	/// </summary>
	public override string ResponseUsernameTooManyUnderscores => "TÃªn ngÆ°á»i dÃ¹ng cÃ³ thá»ƒ chá»©a tá»‘i Ä‘a má»™t kÃ½ tá»± _.";

	public SignUpResources_vi_vn(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionCreateAccount()
	{
		return "Táº¡o TÃ i khoáº£n";
	}

	protected override string _GetTemplateForActionLinkAccount()
	{
		return "LiÃªn káº¿t TÃ i khoáº£n";
	}

	protected override string _GetTemplateForActionLogInCapitalized()
	{
		return "ÄÄƒng nháº­p";
	}

	protected override string _GetTemplateForActionReturnHome()
	{
		return "Trá»Ÿ láº¡i Trang chá»§";
	}

	protected override string _GetTemplateForActionSignUp()
	{
		return "ÄÄƒng kÃ½";
	}

	protected override string _GetTemplateForActionSignupAndSync()
	{
		return "ÄÄƒng kÃ½ & Äá»“ng bá»™";
	}

	protected override string _GetTemplateForActionSubmit()
	{
		return "Gá»­i";
	}

	protected override string _GetTemplateForDescriptionAccountLinkingWarning()
	{
		return "Äá»ƒ liÃªn káº¿t vá»›i tÃ i khoáº£n Roblox cÃ³ sáºµn, hÃ£y Ä‘Äƒng nháº­p vÃ  liÃªn káº¿t chÃºng trÃªn trang cÃ i Ä‘áº·t tÃ i khoáº£n.";
	}

	protected override string _GetTemplateForDescriptionNoRealName()
	{
		return "KhÃ´ng dÃ¹ng tÃªn tháº­t cá»§a báº¡n.";
	}

	protected override string _GetTemplateForDescriptionPrivacyPolicy()
	{
		return "ChÃ­nh sÃ¡ch riÃªng tÆ°";
	}

	/// <summary>
	/// Key: "Description.SignUpAgreement"
	/// terms of use agreement checkbox label to signup.
	/// English String: "By clicking {spanStart}Sign Up{spanEnd}, you are agreeing to the {termsOfUseLink} and acknowledging the {privacyPolicyLink}"
	/// </summary>
	public override string DescriptionSignUpAgreement(string spanStart, string spanEnd, string termsOfUseLink, string privacyPolicyLink)
	{
		return $"Báº¥m vÃ o {spanStart}ÄÄƒng kÃ½{spanEnd} Ä‘á»“ng nghÄ©a báº¡n Ä‘á»“ng Ã½ vá»›i {termsOfUseLink} vÃ  thá»«a nháº­n {privacyPolicyLink}";
	}

	protected override string _GetTemplateForDescriptionSignUpAgreement()
	{
		return "Báº¥m vÃ o {spanStart}ÄÄƒng kÃ½{spanEnd} Ä‘á»“ng nghÄ©a báº¡n Ä‘á»“ng Ã½ vá»›i {termsOfUseLink} vÃ  thá»«a nháº­n {privacyPolicyLink}";
	}

	protected override string _GetTemplateForDescriptionTermsOfService()
	{
		return "Äiá»u khoáº£n dá»‹ch vá»¥";
	}

	protected override string _GetTemplateForGuestSignUpABActionSignUp()
	{
		return "ÄÄƒng kÃ½";
	}

	protected override string _GetTemplateForHeadingConnectFacebook()
	{
		return "Káº¿t ná»‘i vá»›i Facebook";
	}

	protected override string _GetTemplateForHeadingCreateAnAccount()
	{
		return "Táº O TÃ€I KHOáº¢N";
	}

	/// <summary>
	/// Key: "Heading.FacebookSignupAlmostDone"
	/// when user signs up using Facebook, this is shown in next step to create a password.
	/// English String: "{firstname}, YOU'RE ALMOST DONE"
	/// </summary>
	public override string HeadingFacebookSignupAlmostDone(string firstname)
	{
		return $"{firstname}, Báº N Sáº®P ÄÄ‚NG KÃ XONG Rá»’I";
	}

	protected override string _GetTemplateForHeadingFacebookSignupAlmostDone()
	{
		return "{firstname}, Báº N Sáº®P ÄÄ‚NG KÃ XONG Rá»’I";
	}

	protected override string _GetTemplateForHeadingLoginHaveFun()
	{
		return "ÄÄƒng nháº­p vÃ  giáº£i trÃ­!";
	}

	protected override string _GetTemplateForHeadingSignupHaveFun()
	{
		return "ÄÄƒng kÃ½ vÃ  giáº£i trÃ­!";
	}

	protected override string _GetTemplateForLabelAbout()
	{
		return "Vá» sáº£n pháº©m";
	}

	protected override string _GetTemplateForLabelAlreadyHaveRobloxAccount()
	{
		return "Báº¡n Ä‘Ã£ cÃ³ tÃ i khoáº£n Roblox?";
	}

	protected override string _GetTemplateForLabelAlreadyRegistered()
	{
		return "ÄÃ£ Ä‘Äƒng kÃ½?";
	}

	protected override string _GetTemplateForLabelBirthday()
	{
		return "NgÃ y sinh";
	}

	protected override string _GetTemplateForLabelBirthdayWithColumn()
	{
		return "NgÃ y sinh:";
	}

	protected override string _GetTemplateForLabelConfirmPassword()
	{
		return "XÃ¡c nháº­n máº­t kháº©u";
	}

	protected override string _GetTemplateForLabelDay()
	{
		return "NgÃ y";
	}

	protected override string _GetTemplateForLabelDesiredUsername()
	{
		return "TÃªn ngÆ°á»i dÃ¹ng muá»‘n Ä‘áº·t:";
	}

	protected override string _GetTemplateForLabelFacebookNotLinked()
	{
		return "TÃ i khoáº£n Facebook cá»§a báº¡n khÃ´ng Ä‘Æ°á»£c liÃªn káº¿t vá»›i báº¥t ká»³ tÃ i khoáº£n Roblox nÃ o. Vui lÃ²ng Ä‘Äƒng kÃ½ má»™t tÃ i khoáº£n Roblox.";
	}

	protected override string _GetTemplateForLabelFacebookSignupUsername()
	{
		return "Táº¡o tÃªn ngÆ°á»i dÃ¹ng Roblox:";
	}

	protected override string _GetTemplateForLabelFemale()
	{
		return "Ná»¯";
	}

	protected override string _GetTemplateForLabelGender()
	{
		return "Giá»›i tÃ­nh";
	}

	protected override string _GetTemplateForLabelGenderRequired()
	{
		return "Cáº§n pháº£i chá»n giá»›i tÃ­nh.";
	}

	protected override string _GetTemplateForLabelGenderWithColumn()
	{
		return "Giá»›i tÃ­nh:";
	}

	protected override string _GetTemplateForLabelMale()
	{
		return "Nam";
	}

	protected override string _GetTemplateForLabelMonth()
	{
		return "ThÃ¡ng";
	}

	protected override string _GetTemplateForLabelPassword()
	{
		return "Máº­t kháº©u";
	}

	protected override string _GetTemplateForLabelPasswordRequirements()
	{
		return "Máº­t kháº©u (tá»‘i thiá»ƒu 8 kÃ½ tá»±)";
	}

	protected override string _GetTemplateForLabelPlatforms()
	{
		return "Ná»n táº£ng";
	}

	protected override string _GetTemplateForLabelPlay()
	{
		return "ChÆ¡i";
	}

	protected override string _GetTemplateForLabelPleaseAgreeToTerms()
	{
		return "Vui lÃ²ng Ä‘á»“ng kÃ½ vá»›i Äiá»u khoáº£n sá»­ dá»¥ng vÃ  ChÃ­nh sÃ¡ch riÃªng tÆ° cá»§a chÃºng tÃ´i.";
	}

	protected override string _GetTemplateForLabelRequired()
	{
		return "Báº¯t buá»™c";
	}

	protected override string _GetTemplateForLabelSignupButtonText()
	{
		return "ÄÄƒng kÃ½ vÃ  ChÆ¡i!";
	}

	protected override string _GetTemplateForLabelSignUpWith()
	{
		return "hoáº·c Ä‘Äƒng kÃ½ báº±ng";
	}

	protected override string _GetTemplateForLabelTermsOfUse()
	{
		return "Äiá»u khoáº£n sá»­ dá»¥ng";
	}

	protected override string _GetTemplateForLabelUsername()
	{
		return "TÃªn ngÆ°á»i dÃ¹ng";
	}

	protected override string _GetTemplateForLabelUsernameCharacterLimit()
	{
		return "CÃ³ tá»« 3-20 chá»¯ cÃ¡i vÃ  chá»¯ sá»‘, khÃ´ng chá»©a kÃ½ tá»± trá»‘ng.";
	}

	protected override string _GetTemplateForLabelUsernameHint()
	{
		return "TÃªn ngÆ°á»i dÃ¹ng (khÃ´ng dÃ¹ng tÃªn tháº­t cá»§a báº¡n)";
	}

	protected override string _GetTemplateForLabelUsernameRequirements()
	{
		return "TÃªn ngÆ°á»i dÃ¹ng (tá»« 3-20 kÃ½ tá»±, _ Ä‘Æ°á»£c cho phÃ©p)";
	}

	protected override string _GetTemplateForLabelYear()
	{
		return "NÄƒm";
	}

	protected override string _GetTemplateForMessagePasswordMinLength()
	{
		return "Tá»‘i thiá»ƒu 8 kÃ½ tá»±";
	}

	protected override string _GetTemplateForMessageUsernameNoRealNameUse()
	{
		return "KhÃ´ng dÃ¹ng tÃªn tháº­t cá»§a báº¡n";
	}

	protected override string _GetTemplateForResponseBadUsername()
	{
		return "TÃªn ngÆ°á»i dÃ¹ng khÃ´ng phÃ¹ há»£p vá»›i Roblox.";
	}

	protected override string _GetTemplateForResponseBadUsernameForWeChat()
	{
		return "TÃªn ngÆ°á»i dÃ¹ng khÃ´ng phÃ¹ há»£p";
	}

	protected override string _GetTemplateForResponseBirthdayInvalid()
	{
		return "NgÃ y sinh nÃ y khÃ´ng há»£p lá»‡.";
	}

	protected override string _GetTemplateForResponseBirthdayMustBeSetFirst()
	{
		return "Pháº£i chá»n ngÃ y sinh trÆ°á»›c.";
	}

	protected override string _GetTemplateForResponseCaptchaMismatchError()
	{
		return "CÃ¡c tá»« khÃ´ng trÃ¹ng.";
	}

	protected override string _GetTemplateForResponseCaptchaNotEnteredError()
	{
		return "Vui lÃ²ng Ä‘iá»n mÃ£ Captcha";
	}

	protected override string _GetTemplateForResponseFacebookConnectionError()
	{
		return "Xáº£y ra lá»—i khi truy xuáº¥t giÃ¡ trá»‹ tá»« Facebook.";
	}

	protected override string _GetTemplateForResponseFacebookLoginAge()
	{
		return "Chá»‰ ngÆ°á»i dÃ¹ng trÃªn 13 tuá»•i má»›i cÃ³ thá»ƒ sá»­ dá»¥ng Ä‘Äƒng nháº­p báº±ng Facebook.";
	}

	protected override string _GetTemplateForResponseInvalidBirthday()
	{
		return "NgÃ y sinh khÃ´ng há»£p lá»‡.";
	}

	protected override string _GetTemplateForResponseInvalidEmail()
	{
		return "Äá»‹a chá»‰ email khÃ´ng há»£p lá»‡.";
	}

	protected override string _GetTemplateForResponseJavaScriptRequired()
	{
		return "Pháº£i báº­t JavaScript Ä‘á»ƒ gá»­i máº«u nÃ y.";
	}

	protected override string _GetTemplateForResponsePasswordComplexity()
	{
		return "Vui lÃ²ng táº¡o máº­t kháº©u khÃ³ Ä‘oÃ¡n hÆ¡n.";
	}

	protected override string _GetTemplateForResponsePasswordConfirmation()
	{
		return "Vui lÃ²ng nháº­p máº­t kháº©u xÃ¡c nháº­n.";
	}

	protected override string _GetTemplateForResponsePasswordContainsUsernameError()
	{
		return "Máº­t kháº©u khÃ´ng nÃªn trÃ¹ng vá»›i tÃªn ngÆ°á»i dÃ¹ng.";
	}

	protected override string _GetTemplateForResponsePasswordMismatch()
	{
		return "Máº­t kháº©u khÃ´ng trÃ¹ng nhau.";
	}

	protected override string _GetTemplateForResponsePasswordWrongShort()
	{
		return "Máº­t kháº©u pháº£i cÃ³ tá»‘i thiá»ƒu 8 kÃ½ tá»±.";
	}

	protected override string _GetTemplateForResponsePleaseEnterPassword()
	{
		return "Vui lÃ²ng nháº­p máº­t kháº©u.";
	}

	protected override string _GetTemplateForResponsePleaseEnterUsername()
	{
		return "Vui lÃ²ng nháº­p tÃªn ngÆ°á»i dÃ¹ng.";
	}

	protected override string _GetTemplateForResponseSocialAccountCreationFailed()
	{
		return "KhÃ´ng thá»ƒ táº¡o tÃ i khoáº£n";
	}

	protected override string _GetTemplateForResponseSpaceOrSpecialCharaterError()
	{
		return "KhÃ´ng Ä‘Æ°á»£c nháº­p kÃ½ tá»± trá»‘ng vÃ  kÃ½ tá»± Ä‘áº·c biá»‡t.";
	}

	protected override string _GetTemplateForResponseTooManyAccountsWithSameEmailError()
	{
		return "CÃ³ quÃ¡ nhiá»u tÃ i khoáº£n sá»­ dá»¥ng email nÃ y.";
	}

	protected override string _GetTemplateForResponseUnknownError()
	{
		return "Ráº¥t tiáº¿c! ÄÃ£ xáº£y ra lá»—i khÃ´ng xÃ¡c Ä‘á»‹nh. Vui lÃ²ng thá»­ láº¡i sau.";
	}

	protected override string _GetTemplateForResponseUsernameAllowedCharactersError()
	{
		return "TÃªn ngÆ°á»i dÃ¹ng chá»‰ Ä‘Æ°á»£c chá»©a chá»¯ cÃ¡i, chá»¯ sá»‘ vÃ  kÃ½ tá»± _.";
	}

	protected override string _GetTemplateForResponseUsernameAlreadyInUse()
	{
		return "TÃªn ngÆ°á»i dÃ¹ng Ä‘Ã£ Ä‘Æ°á»£c sá»­ dá»¥ng.";
	}

	protected override string _GetTemplateForResponseUsernameExplicit()
	{
		return "KhÃ´ng thá»ƒ sá»­ dá»¥ng tÃªn nÃ y, xin chá»n tÃªn khÃ¡c.";
	}

	protected override string _GetTemplateForResponseUsernameInvalid()
	{
		return "Vui lÃ²ng nháº­p tÃªn ngÆ°á»i dÃ¹ng há»£p lá»‡.";
	}

	protected override string _GetTemplateForResponseUsernameInvalidCharacters()
	{
		return "Chá»‰ Ä‘Æ°á»£c dÃ¹ng cÃ¡c kÃ½ tá»± a-z, A-Z, 0-9 vÃ  kÃ½ tá»± _.";
	}

	protected override string _GetTemplateForResponseUsernameInvalidLength()
	{
		return "TÃªn ngÆ°á»i dÃ¹ng cÃ³ thá»ƒ dÃ i tá»« 3 Ä‘áº¿n 20 kÃ½ tá»±.";
	}

	protected override string _GetTemplateForResponseUsernameInvalidUnderscore()
	{
		return "KhÃ´ng thá»ƒ báº¯t Ä‘áº§u/káº¿t thÃºc vá»›i kÃ½ tá»± _.";
	}

	protected override string _GetTemplateForResponseUsernameNotAvailable()
	{
		return "TÃªn ngÆ°á»i dÃ¹ng khÃ´ng kháº£ dá»¥ng. Vui lÃ²ng thá»­ láº¡i.";
	}

	protected override string _GetTemplateForResponseUsernameOrPasswordIncorrect()
	{
		return "Sai tÃªn ngÆ°á»i dÃ¹ng hoáº·c máº­t kháº©u.";
	}

	protected override string _GetTemplateForResponseUsernamePasswordRequired()
	{
		return "Pháº£i nháº­p Máº­t kháº©u vÃ  TÃªn ngÆ°á»i dÃ¹ng.";
	}

	protected override string _GetTemplateForResponseUsernamePrivateInfo()
	{
		return "TÃªn ngÆ°á»i dÃ¹ng cÃ³ thá»ƒ chá»©a thÃ´ng tin cÃ¡ nhÃ¢n.";
	}

	protected override string _GetTemplateForResponseUsernameRequired()
	{
		return "Báº¯t buá»™c pháº£i cÃ³ tÃªn ngÆ°á»i dÃ¹ng.";
	}

	protected override string _GetTemplateForResponseUsernameTakenTryAgain()
	{
		return "TÃªn ngÆ°á»i dÃ¹ng nÃ y Ä‘Ã£ Ä‘Æ°á»£c sá»­ dá»¥ng! Vui lÃ²ng thá»­ tÃªn khÃ¡c.";
	}

	protected override string _GetTemplateForResponseUsernameTooManyUnderscores()
	{
		return "TÃªn ngÆ°á»i dÃ¹ng cÃ³ thá»ƒ chá»©a tá»‘i Ä‘a má»™t kÃ½ tá»± _.";
	}
}


}
