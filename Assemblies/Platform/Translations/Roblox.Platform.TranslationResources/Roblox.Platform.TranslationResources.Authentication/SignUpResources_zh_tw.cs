namespace Roblox.Platform.TranslationResources.Authentication {
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
	public override string ActionCreateAccount => "å»ºç«‹å¸³è™Ÿ";

	/// <summary>
	/// Key: "Action.LinkAccount"
	/// Button text to link 3rd Party Account to a Roblox Account
	/// English String: "Link Account"
	/// </summary>
	public override string ActionLinkAccount => "é€£çµå¸³è™Ÿ";

	/// <summary>
	/// Key: "Action.LogInCapitalized"
	/// button label for capitalized words for Log In
	/// English String: "Log In"
	/// </summary>
	public override string ActionLogInCapitalized => "ç™»å…¥";

	/// <summary>
	/// Key: "Action.ReturnHome"
	/// button label to return the user to home page
	/// English String: "Return Home"
	/// </summary>
	public override string ActionReturnHome => "è¿”å›žé¦–é ";

	/// <summary>
	/// Key: "Action.SignUp"
	/// English String: "Sign up"
	/// </summary>
	public override string ActionSignUp => "è¨»å†Š";

	public override string ActionSignupAndSync => "è¨»å†Šä¸¦åŒæ­¥";

	/// <summary>
	/// Key: "Action.Submit"
	/// English String: "Submit"
	/// </summary>
	public override string ActionSubmit => "æäº¤";

	/// <summary>
	/// Key: "Description.AccountLinkingWarning"
	/// instructions for linking account on signup page for FB based account
	/// English String: "To link to an existing Roblox account, sign in and link them on the account settings page."
	/// </summary>
	public override string DescriptionAccountLinkingWarning => "è‹¥è¦é€£æŽ¥å·²å»ºç«‹çš„ Roblox å¸³è™Ÿï¼Œè«‹ç™»å…¥ä¸¦å‰å¾€å¸³è™Ÿè¨­å®šé é¢é€²è¡Œé€£æŽ¥ã€‚";

	/// <summary>
	/// Key: "Description.NoRealName"
	/// description
	/// English String: "Do not use your real name."
	/// </summary>
	public override string DescriptionNoRealName => "è«‹å‹¿å¡«å¯«æ‚¨çš„çœŸå¯¦å§“åã€‚";

	/// <summary>
	/// Key: "Description.PrivacyPolicy"
	/// English String: "Privacy Policy"
	/// </summary>
	public override string DescriptionPrivacyPolicy => "éš±ç§æ¬Šæ”¿ç­–";

	/// <summary>
	/// Key: "Description.TermsOfService"
	/// English String: "Terms of Service"
	/// </summary>
	public override string DescriptionTermsOfService => "æœå‹™æ¢æ¬¾";

	/// <summary>
	/// Key: "GuestSignUpAB.Action.SignUp"
	/// English String: "Sign Up"
	/// </summary>
	public override string GuestSignUpABActionSignUp => "è¨»å†Š";

	/// <summary>
	/// Key: "Heading.ConnectFacebook"
	/// section heading
	/// English String: "Connect to Facebook"
	/// </summary>
	public override string HeadingConnectFacebook => "é€£ç·šåˆ° Facebook";

	/// <summary>
	/// Key: "Heading.CreateAnAccount"
	/// should be capitalized if the language supports capitalization
	/// English String: "CREATE AN ACCOUNT"
	/// </summary>
	public override string HeadingCreateAnAccount => "å»ºç«‹å¸³è™Ÿ";

	/// <summary>
	/// Key: "Heading.LoginHaveFun"
	/// heading for login container
	/// English String: "Log in and start having fun!"
	/// </summary>
	public override string HeadingLoginHaveFun => "ç™»å…¥å¸³è™Ÿï¼Œé–‹å§‹éŠæ¨‚ï¼";

	/// <summary>
	/// Key: "Heading.SignupHaveFun"
	/// signup form heading
	/// English String: "Sign up and start having fun!"
	/// </summary>
	public override string HeadingSignupHaveFun => "è¨»å†Šå¸³è™Ÿï¼Œé–‹å§‹éŠæ¨‚ï¼";

	/// <summary>
	/// Key: "Label.About"
	/// About link on roller coaster page
	/// English String: "About"
	/// </summary>
	public override string LabelAbout => "ä»‹ç´¹";

	/// <summary>
	/// Key: "Label.AlreadyHaveRobloxAccount"
	/// English String: "Already have a Roblox account?"
	/// </summary>
	public override string LabelAlreadyHaveRobloxAccount => "æœ‰ Roblox å¸³è™Ÿäº†å—Žï¼Ÿ";

	/// <summary>
	/// Key: "Label.AlreadyRegistered"
	/// label
	/// English String: "Already registered?"
	/// </summary>
	public override string LabelAlreadyRegistered => "å·²ç¶“è¨»å†Šï¼Ÿ";

	/// <summary>
	/// Key: "Label.Birthday"
	/// English String: "Birthday"
	/// </summary>
	public override string LabelBirthday => "ç”Ÿæ—¥";

	/// <summary>
	/// Key: "Label.BirthdayWithColumn"
	/// should have column if the language supports it
	/// English String: "Birthday:"
	/// </summary>
	public override string LabelBirthdayWithColumn => "ç”Ÿæ—¥ï¼š";

	/// <summary>
	/// Key: "Label.ConfirmPassword"
	/// English String: "Confirm password"
	/// </summary>
	public override string LabelConfirmPassword => "ç¢ºèªå¯†ç¢¼";

	/// <summary>
	/// Key: "Label.Day"
	/// English String: "Day"
	/// </summary>
	public override string LabelDay => "æ—¥";

	/// <summary>
	/// Key: "Label.DesiredUsername"
	/// should have a column if the language supports it
	/// English String: "Desired Username:"
	/// </summary>
	public override string LabelDesiredUsername => "æ¬²ä½¿ç”¨çš„ä½¿ç”¨è€…åç¨±ï¼š";

	/// <summary>
	/// Key: "Label.FacebookNotLinked"
	/// English String: "Your Facebook account is not linked to any Roblox account. Please sign up for a Roblox account."
	/// </summary>
	public override string LabelFacebookNotLinked => "æ‚¨çš„ Facebook å¸³è™Ÿæ²’æœ‰é€£æŽ¥ Roblox å¸³è™Ÿï¼Œè«‹è¨»å†Šæ–°çš„ Roblox å¸³è™Ÿã€‚";

	/// <summary>
	/// Key: "Label.FacebookSignupUsername"
	/// username field label for FB signup
	/// English String: "Create Roblox username:"
	/// </summary>
	public override string LabelFacebookSignupUsername => "å»ºç«‹ Roblox ä½¿ç”¨è€…åç¨±ï¼š";

	/// <summary>
	/// Key: "Label.Female"
	/// label
	/// English String: "Female"
	/// </summary>
	public override string LabelFemale => "å¥³";

	/// <summary>
	/// Key: "Label.Gender"
	/// English String: "Gender"
	/// </summary>
	public override string LabelGender => "æ€§åˆ¥";

	/// <summary>
	/// Key: "Label.GenderRequired"
	/// English String: "Gender is required."
	/// </summary>
	public override string LabelGenderRequired => "æ€§åˆ¥å¿…å¡«ã€‚";

	/// <summary>
	/// Key: "Label.GenderWithColumn"
	/// should have column if the language supports it
	/// English String: "Gender:"
	/// </summary>
	public override string LabelGenderWithColumn => "æ€§åˆ¥ï¼š";

	/// <summary>
	/// Key: "Label.Male"
	/// label
	/// English String: "Male"
	/// </summary>
	public override string LabelMale => "ç”·";

	/// <summary>
	/// Key: "Label.Month"
	/// English String: "Month"
	/// </summary>
	public override string LabelMonth => "æœˆ";

	/// <summary>
	/// Key: "Label.Password"
	/// English String: "Password"
	/// </summary>
	public override string LabelPassword => "å¯†ç¢¼";

	/// <summary>
	/// Key: "Label.PasswordRequirements"
	/// English String: "Password (min length 8)"
	/// </summary>
	public override string LabelPasswordRequirements => "å¯†ç¢¼ï¼ˆè‡³å°‘ 8 å€‹å­—å…ƒï¼‰";

	/// <summary>
	/// Key: "Label.Platforms"
	/// platforms link on roller coaster page
	/// English String: "Platforms"
	/// </summary>
	public override string LabelPlatforms => "å¹³å°";

	/// <summary>
	/// Key: "Label.Play"
	/// Play link on roller coaster page
	/// English String: "Play"
	/// </summary>
	public override string LabelPlay => "é–‹å§‹çŽ©";

	/// <summary>
	/// Key: "Label.PleaseAgreeToTerms"
	/// English String: "Please agree to our Terms of Use and Privacy Policy."
	/// </summary>
	public override string LabelPleaseAgreeToTerms => "è«‹åŒæ„æˆ‘å€‘çš„ä½¿ç”¨æ¢æ¬¾å’Œéš±ç§æ¬Šæ”¿ç­–ã€‚";

	/// <summary>
	/// Key: "Label.Required"
	/// Required
	/// English String: "Required"
	/// </summary>
	public override string LabelRequired => "å¿…å¡«";

	/// <summary>
	/// Key: "Label.SignupButtonText"
	/// sign up button text
	/// English String: "Sign Up and Play!"
	/// </summary>
	public override string LabelSignupButtonText => "è¨»å†Šå¸³è™Ÿï¼Œé–‹å§‹éŠçŽ©ï¼";

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
	public override string LabelSignUpWith => "æˆ–ä½¿ç”¨";

	/// <summary>
	/// Key: "Label.TermsOfUse"
	/// terms of use link label
	/// English String: "Terms of Use"
	/// </summary>
	public override string LabelTermsOfUse => "ä½¿ç”¨æ¢æ¬¾";

	/// <summary>
	/// Key: "Label.Username"
	/// English String: "Username"
	/// </summary>
	public override string LabelUsername => "ä½¿ç”¨è€…åç¨±";

	/// <summary>
	/// Key: "Label.UsernameCharacterLimit"
	/// label
	/// English String: "3-20 alphanumeric characters, no spaces."
	/// </summary>
	public override string LabelUsernameCharacterLimit => "3 åˆ° 20 å€‹è‹±æ•¸å­—å…ƒï¼Œä¸å¯ä½¿ç”¨ç©ºæ ¼ã€‚";

	/// <summary>
	/// Key: "Label.UsernameHint"
	/// placeholder for username field
	/// English String: "Username (don't use your real name)"
	/// </summary>
	public override string LabelUsernameHint => "ä½¿ç”¨è€…åç¨±ï¼ˆè«‹å‹¿å¡«å¯«æ‚¨çš„çœŸå¯¦å§“åï¼‰";

	/// <summary>
	/// Key: "Label.UsernameRequirements"
	/// English String: "Username (length 3-20, _ is allowed)"
	/// </summary>
	public override string LabelUsernameRequirements => "ä½¿ç”¨è€…åç¨±ï¼ˆ 3 åˆ° 20 å€‹å­—æ¯æˆ–æ•¸å­—ï¼Œå¯ä½¿ç”¨ _ï¼‰";

	/// <summary>
	/// Key: "Label.Year"
	/// English String: "Year"
	/// </summary>
	public override string LabelYear => "å¹´";

	/// <summary>
	/// Key: "Message.Password.MinLength"
	/// English String: "Min length 8"
	/// </summary>
	public override string MessagePasswordMinLength => "8 å€‹å­—å…ƒä»¥ä¸Š";

	/// <summary>
	/// Key: "Message.Username.NoRealNameUse"
	/// English String: "Don't use your real name"
	/// </summary>
	public override string MessageUsernameNoRealNameUse => "è«‹å‹¿ä½¿ç”¨æ‚¨çš„çœŸå¯¦å§“å";

	/// <summary>
	/// Key: "Response.BadUsername"
	/// English String: "Username not appropriate for Roblox."
	/// </summary>
	public override string ResponseBadUsername => "æ­¤ä½¿ç”¨è€…åç¨±å«æœ‰ä¸ç•¶å…§å®¹ã€‚";

	/// <summary>
	/// Key: "Response.BadUsernameForWeChat"
	/// message shown when signing up with an inappropriate username
	/// English String: "Username is not appropriate"
	/// </summary>
	public override string ResponseBadUsernameForWeChat => "ä½¿ç”¨è€…åç¨±ä¸ç•¶";

	/// <summary>
	/// Key: "Response.BirthdayInvalid"
	/// English String: "This birthday is invalid."
	/// </summary>
	public override string ResponseBirthdayInvalid => "ç”Ÿæ—¥ç„¡æ•ˆã€‚";

	/// <summary>
	/// Key: "Response.BirthdayMustBeSetFirst"
	/// English String: "Birthday must be set first."
	/// </summary>
	public override string ResponseBirthdayMustBeSetFirst => "è«‹å…ˆè¨­å®šç”Ÿæ—¥ã€‚";

	/// <summary>
	/// Key: "Response.CaptchaMismatchError"
	/// error message
	/// English String: "Words do not match."
	/// </summary>
	public override string ResponseCaptchaMismatchError => "æ–‡å­—ä¸ç¬¦ã€‚";

	/// <summary>
	/// Key: "Response.CaptchaNotEnteredError"
	/// validation error message
	/// English String: "Please fill out the Captcha"
	/// </summary>
	public override string ResponseCaptchaNotEnteredError => "è«‹å¡«å¯« Captcha é©—è­‰ã€‚";

	/// <summary>
	/// Key: "Response.FacebookConnectionError"
	/// error message
	/// English String: "Error while retrieving values from Facebook."
	/// </summary>
	public override string ResponseFacebookConnectionError => "å¾ž Facebook æ“·å–æ•¸å€¼æ™‚ç™¼ç”ŸéŒ¯èª¤ã€‚";

	/// <summary>
	/// Key: "Response.FacebookLoginAge"
	/// English String: "Facebook login can only be used by users above 13."
	/// </summary>
	public override string ResponseFacebookLoginAge => "åªæœ‰ 13 æ­²ä»¥ä¸Šçš„ä½¿ç”¨è€…å¯ä»¥ä½¿ç”¨ Facebook ç™»å…¥ã€‚";

	/// <summary>
	/// Key: "Response.InvalidBirthday"
	/// English String: "Invalid birthday."
	/// </summary>
	public override string ResponseInvalidBirthday => "ç”Ÿæ—¥ç„¡æ•ˆã€‚";

	/// <summary>
	/// Key: "Response.InvalidEmail"
	/// English String: "Invalid email address."
	/// </summary>
	public override string ResponseInvalidEmail => "æ­¤é›»å­éƒµä»¶åœ°å€ç„¡æ•ˆã€‚";

	/// <summary>
	/// Key: "Response.JavaScriptRequired"
	/// error to show that JavaScipt is required for the form to work
	/// English String: "JavaScript is required to submit this form."
	/// </summary>
	public override string ResponseJavaScriptRequired => "æäº¤æ­¤è¡¨æ ¼å¿…é ˆä½¿ç”¨ JavaScriptã€‚";

	/// <summary>
	/// Key: "Response.PasswordComplexity"
	/// English String: "Please create a more complex password."
	/// </summary>
	public override string ResponsePasswordComplexity => "è«‹è¼¸å…¥æ›´è¤‡é›œçš„å¯†ç¢¼ã€‚";

	/// <summary>
	/// Key: "Response.PasswordConfirmation"
	/// validation message for password confirmation
	/// English String: "Please enter a password confirmation."
	/// </summary>
	public override string ResponsePasswordConfirmation => "è«‹è¼¸å…¥å¯†ç¢¼ç¢ºèªã€‚";

	/// <summary>
	/// Key: "Response.PasswordContainsUsernameError"
	/// error when passsword has username in it
	/// English String: "Password shouldn't match username."
	/// </summary>
	public override string ResponsePasswordContainsUsernameError => "å¯†ç¢¼é ˆå’Œä½¿ç”¨è€…åç¨±ä¸åŒã€‚";

	/// <summary>
	/// Key: "Response.PasswordMismatch"
	/// English String: "Passwords do not match."
	/// </summary>
	public override string ResponsePasswordMismatch => "å¯†ç¢¼ä¸ç›¸ç¬¦ã€‚";

	/// <summary>
	/// Key: "Response.PasswordWrongShort"
	/// English String: "Passwords must be at least 8 characters long."
	/// </summary>
	public override string ResponsePasswordWrongShort => "å¯†ç¢¼éœ€è¦ 8 å€‹å­—å…ƒä»¥ä¸Šã€‚";

	/// <summary>
	/// Key: "Response.PleaseEnterPassword"
	/// English String: "Please enter a password."
	/// </summary>
	public override string ResponsePleaseEnterPassword => "è«‹è¼¸å…¥å¯†ç¢¼ã€‚";

	/// <summary>
	/// Key: "Response.PleaseEnterUsername"
	/// English String: "Please enter a username."
	/// </summary>
	public override string ResponsePleaseEnterUsername => "è«‹è¼¸å…¥ä½¿ç”¨è€…åç¨±ã€‚";

	/// <summary>
	/// Key: "Response.SocialAccountCreationFailed"
	/// error message
	/// English String: "Account creation failed"
	/// </summary>
	public override string ResponseSocialAccountCreationFailed => "ç„¡æ³•å»ºç«‹å¸³è™Ÿ";

	/// <summary>
	/// Key: "Response.SpaceOrSpecialCharaterError"
	/// Spaces and special characters are not allowed error message
	/// English String: "Spaces and special characters are not allowed."
	/// </summary>
	public override string ResponseSpaceOrSpecialCharaterError => "ä¸èƒ½ä½¿ç”¨ç©ºæ ¼èˆ‡ç‰¹æ®Šå­—å…ƒã€‚";

	/// <summary>
	/// Key: "Response.TooManyAccountsWithSameEmailError"
	/// Too many accounts use this email error message
	/// English String: "Too many accounts use this email."
	/// </summary>
	public override string ResponseTooManyAccountsWithSameEmailError => "åŠ å…¥æ­¤é›»å­éƒµä»¶åœ°å€çš„å¸³è™ŸéŽå¤šã€‚";

	/// <summary>
	/// Key: "Response.UnknownError"
	/// English String: "Sorry! An unknown error occurred. Please try again later."
	/// </summary>
	public override string ResponseUnknownError => "å°ä¸èµ·ï¼Œç™¼ç”ŸæœªçŸ¥éŒ¯èª¤ã€‚è«‹ç¨å¾Œå†è©¦ã€‚";

	/// <summary>
	/// Key: "Response.UsernameAllowedCharactersError"
	/// error showing which characters are allowed for username
	/// English String: "Usernames may only contain letters, numbers, and _."
	/// </summary>
	public override string ResponseUsernameAllowedCharactersError => "ä½¿ç”¨è€…åç¨±åªèƒ½å«æœ‰å­—æ¯ã€æ•¸å­—åŠ _ã€‚";

	/// <summary>
	/// Key: "Response.UsernameAlreadyInUse"
	/// English String: "This username is already in use."
	/// </summary>
	public override string ResponseUsernameAlreadyInUse => "æ­¤ä½¿ç”¨è€…åç¨±å·²è¢«ä½¿ç”¨ã€‚";

	/// <summary>
	/// Key: "Response.UsernameExplicit"
	/// English String: "This username is not allowed, please try another."
	/// </summary>
	public override string ResponseUsernameExplicit => "æ­¤ä½¿ç”¨è€…åç¨±å«æœ‰ä¸ç•¶å…§å®¹ï¼Œè«‹é‡æ–°å˜—è©¦ã€‚";

	/// <summary>
	/// Key: "Response.UsernameInvalid"
	/// English String: "Please enter a valid username."
	/// </summary>
	public override string ResponseUsernameInvalid => "è«‹è¼¸å…¥æœ‰æ•ˆçš„ä½¿ç”¨è€…åç¨±ã€‚";

	/// <summary>
	/// Key: "Response.UsernameInvalidCharacters"
	/// English String: "Only a-z, A-Z, 0-9 and _ are allowed."
	/// </summary>
	public override string ResponseUsernameInvalidCharacters => "åªå…è¨±ä½¿ç”¨ a-zã€A-Zã€0-9 åŠ _ã€‚";

	/// <summary>
	/// Key: "Response.UsernameInvalidLength"
	/// English String: "Usernames can be 3 to 20 characters long."
	/// </summary>
	public override string ResponseUsernameInvalidLength => "ä½¿ç”¨è€…åç¨±æ‡‰ç‚º 3 åˆ° 20 å€‹å­—å…ƒã€‚";

	/// <summary>
	/// Key: "Response.UsernameInvalidUnderscore"
	/// English String: "Usernames cannot start or end with _."
	/// </summary>
	public override string ResponseUsernameInvalidUnderscore => "ä½¿ç”¨è€…åç¨±ç„¡æ³•ä»¥ _ é–‹é ­æˆ–çµå°¾ã€‚";

	/// <summary>
	/// Key: "Response.UsernameNotAvailable"
	/// English String: "Username not available. Please try again."
	/// </summary>
	public override string ResponseUsernameNotAvailable => "ç„¡æ³•ä½¿ç”¨æ­¤ä½¿ç”¨è€…åç¨±ã€‚è«‹é‡æ–°å˜—è©¦ã€‚";

	/// <summary>
	/// Key: "Response.UsernameOrPasswordIncorrect"
	/// Your username or password is incorrect
	/// English String: "Your username or password is incorrect."
	/// </summary>
	public override string ResponseUsernameOrPasswordIncorrect => "ä½¿ç”¨è€…åç¨±æˆ–å¯†ç¢¼ä¸æ­£ç¢ºã€‚";

	/// <summary>
	/// Key: "Response.UsernamePasswordRequired"
	/// Username and Password are required error message
	/// English String: "Username and Password are required."
	/// </summary>
	public override string ResponseUsernamePasswordRequired => "ä½¿ç”¨è€…åç¨±èˆ‡å¯†ç¢¼ç‚ºå¿…å¡«é …ç›®ã€‚";

	/// <summary>
	/// Key: "Response.UsernamePrivateInfo"
	/// English String: "Username might contain private information."
	/// </summary>
	public override string ResponseUsernamePrivateInfo => "ä½¿ç”¨è€…åç¨±å¯èƒ½å«æœ‰ç§äººè³‡æ–™ã€‚";

	/// <summary>
	/// Key: "Response.UsernameRequired"
	/// validation error message
	/// English String: "Username is required."
	/// </summary>
	public override string ResponseUsernameRequired => "ä½¿ç”¨è€…åç¨±å¿…å¡«ã€‚";

	/// <summary>
	/// Key: "Response.UsernameTakenTryAgain"
	/// English String: "This username is already taken! Please try a different one."
	/// </summary>
	public override string ResponseUsernameTakenTryAgain => "æ­¤ä½¿ç”¨è€…åç¨±å·²è¢«ä½¿ç”¨ï¼Œè«‹è¼¸å…¥æ–°çš„ä½¿ç”¨è€…åç¨±ã€‚";

	/// <summary>
	/// Key: "Response.UsernameTooManyUnderscores"
	/// English String: "Usernames can have at most one _."
	/// </summary>
	public override string ResponseUsernameTooManyUnderscores => "ä½¿ç”¨è€…åç¨±ç„¡æ³•ä½¿ç”¨è¶…éŽä¸€å€‹ _ã€‚";

	public SignUpResources_zh_tw(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionCreateAccount()
	{
		return "å»ºç«‹å¸³è™Ÿ";
	}

	protected override string _GetTemplateForActionLinkAccount()
	{
		return "é€£çµå¸³è™Ÿ";
	}

	protected override string _GetTemplateForActionLogInCapitalized()
	{
		return "ç™»å…¥";
	}

	protected override string _GetTemplateForActionReturnHome()
	{
		return "è¿”å›žé¦–é ";
	}

	protected override string _GetTemplateForActionSignUp()
	{
		return "è¨»å†Š";
	}

	protected override string _GetTemplateForActionSignupAndSync()
	{
		return "è¨»å†Šä¸¦åŒæ­¥";
	}

	protected override string _GetTemplateForActionSubmit()
	{
		return "æäº¤";
	}

	protected override string _GetTemplateForDescriptionAccountLinkingWarning()
	{
		return "è‹¥è¦é€£æŽ¥å·²å»ºç«‹çš„ Roblox å¸³è™Ÿï¼Œè«‹ç™»å…¥ä¸¦å‰å¾€å¸³è™Ÿè¨­å®šé é¢é€²è¡Œé€£æŽ¥ã€‚";
	}

	protected override string _GetTemplateForDescriptionNoRealName()
	{
		return "è«‹å‹¿å¡«å¯«æ‚¨çš„çœŸå¯¦å§“åã€‚";
	}

	protected override string _GetTemplateForDescriptionPrivacyPolicy()
	{
		return "éš±ç§æ¬Šæ”¿ç­–";
	}

	/// <summary>
	/// Key: "Description.SignUpAgreement"
	/// terms of use agreement checkbox label to signup.
	/// English String: "By clicking {spanStart}Sign Up{spanEnd}, you are agreeing to the {termsOfUseLink} and acknowledging the {privacyPolicyLink}"
	/// </summary>
	public override string DescriptionSignUpAgreement(string spanStart, string spanEnd, string termsOfUseLink, string privacyPolicyLink)
	{
		return $"æŒ‰ä¸‹{spanStart}è¨»å†Š{spanEnd}è¡¨ç¤ºæ‚¨åŒæ„{termsOfUseLink}ä¸¦äº†è§£{privacyPolicyLink}";
	}

	protected override string _GetTemplateForDescriptionSignUpAgreement()
	{
		return "æŒ‰ä¸‹{spanStart}è¨»å†Š{spanEnd}è¡¨ç¤ºæ‚¨åŒæ„{termsOfUseLink}ä¸¦äº†è§£{privacyPolicyLink}";
	}

	protected override string _GetTemplateForDescriptionTermsOfService()
	{
		return "æœå‹™æ¢æ¬¾";
	}

	protected override string _GetTemplateForGuestSignUpABActionSignUp()
	{
		return "è¨»å†Š";
	}

	protected override string _GetTemplateForHeadingConnectFacebook()
	{
		return "é€£ç·šåˆ° Facebook";
	}

	protected override string _GetTemplateForHeadingCreateAnAccount()
	{
		return "å»ºç«‹å¸³è™Ÿ";
	}

	/// <summary>
	/// Key: "Heading.FacebookSignupAlmostDone"
	/// when user signs up using Facebook, this is shown in next step to create a password.
	/// English String: "{firstname}, YOU'RE ALMOST DONE"
	/// </summary>
	public override string HeadingFacebookSignupAlmostDone(string firstname)
	{
		return $"{firstname}ï¼Œå¿«å¥½äº†ï¼";
	}

	protected override string _GetTemplateForHeadingFacebookSignupAlmostDone()
	{
		return "{firstname}ï¼Œå¿«å¥½äº†ï¼";
	}

	protected override string _GetTemplateForHeadingLoginHaveFun()
	{
		return "ç™»å…¥å¸³è™Ÿï¼Œé–‹å§‹éŠæ¨‚ï¼";
	}

	protected override string _GetTemplateForHeadingSignupHaveFun()
	{
		return "è¨»å†Šå¸³è™Ÿï¼Œé–‹å§‹éŠæ¨‚ï¼";
	}

	protected override string _GetTemplateForLabelAbout()
	{
		return "ä»‹ç´¹";
	}

	protected override string _GetTemplateForLabelAlreadyHaveRobloxAccount()
	{
		return "æœ‰ Roblox å¸³è™Ÿäº†å—Žï¼Ÿ";
	}

	protected override string _GetTemplateForLabelAlreadyRegistered()
	{
		return "å·²ç¶“è¨»å†Šï¼Ÿ";
	}

	protected override string _GetTemplateForLabelBirthday()
	{
		return "ç”Ÿæ—¥";
	}

	protected override string _GetTemplateForLabelBirthdayWithColumn()
	{
		return "ç”Ÿæ—¥ï¼š";
	}

	protected override string _GetTemplateForLabelConfirmPassword()
	{
		return "ç¢ºèªå¯†ç¢¼";
	}

	protected override string _GetTemplateForLabelDay()
	{
		return "æ—¥";
	}

	protected override string _GetTemplateForLabelDesiredUsername()
	{
		return "æ¬²ä½¿ç”¨çš„ä½¿ç”¨è€…åç¨±ï¼š";
	}

	protected override string _GetTemplateForLabelFacebookNotLinked()
	{
		return "æ‚¨çš„ Facebook å¸³è™Ÿæ²’æœ‰é€£æŽ¥ Roblox å¸³è™Ÿï¼Œè«‹è¨»å†Šæ–°çš„ Roblox å¸³è™Ÿã€‚";
	}

	protected override string _GetTemplateForLabelFacebookSignupUsername()
	{
		return "å»ºç«‹ Roblox ä½¿ç”¨è€…åç¨±ï¼š";
	}

	protected override string _GetTemplateForLabelFemale()
	{
		return "å¥³";
	}

	protected override string _GetTemplateForLabelGender()
	{
		return "æ€§åˆ¥";
	}

	protected override string _GetTemplateForLabelGenderRequired()
	{
		return "æ€§åˆ¥å¿…å¡«ã€‚";
	}

	protected override string _GetTemplateForLabelGenderWithColumn()
	{
		return "æ€§åˆ¥ï¼š";
	}

	protected override string _GetTemplateForLabelMale()
	{
		return "ç”·";
	}

	protected override string _GetTemplateForLabelMonth()
	{
		return "æœˆ";
	}

	protected override string _GetTemplateForLabelPassword()
	{
		return "å¯†ç¢¼";
	}

	protected override string _GetTemplateForLabelPasswordRequirements()
	{
		return "å¯†ç¢¼ï¼ˆè‡³å°‘ 8 å€‹å­—å…ƒï¼‰";
	}

	protected override string _GetTemplateForLabelPlatforms()
	{
		return "å¹³å°";
	}

	protected override string _GetTemplateForLabelPlay()
	{
		return "é–‹å§‹çŽ©";
	}

	protected override string _GetTemplateForLabelPleaseAgreeToTerms()
	{
		return "è«‹åŒæ„æˆ‘å€‘çš„ä½¿ç”¨æ¢æ¬¾å’Œéš±ç§æ¬Šæ”¿ç­–ã€‚";
	}

	protected override string _GetTemplateForLabelRequired()
	{
		return "å¿…å¡«";
	}

	protected override string _GetTemplateForLabelSignupButtonText()
	{
		return "è¨»å†Šå¸³è™Ÿï¼Œé–‹å§‹éŠçŽ©ï¼";
	}

	protected override string _GetTemplateForLabelSignUpWith()
	{
		return "æˆ–ä½¿ç”¨";
	}

	protected override string _GetTemplateForLabelTermsOfUse()
	{
		return "ä½¿ç”¨æ¢æ¬¾";
	}

	protected override string _GetTemplateForLabelUsername()
	{
		return "ä½¿ç”¨è€…åç¨±";
	}

	protected override string _GetTemplateForLabelUsernameCharacterLimit()
	{
		return "3 åˆ° 20 å€‹è‹±æ•¸å­—å…ƒï¼Œä¸å¯ä½¿ç”¨ç©ºæ ¼ã€‚";
	}

	protected override string _GetTemplateForLabelUsernameHint()
	{
		return "ä½¿ç”¨è€…åç¨±ï¼ˆè«‹å‹¿å¡«å¯«æ‚¨çš„çœŸå¯¦å§“åï¼‰";
	}

	protected override string _GetTemplateForLabelUsernameRequirements()
	{
		return "ä½¿ç”¨è€…åç¨±ï¼ˆ 3 åˆ° 20 å€‹å­—æ¯æˆ–æ•¸å­—ï¼Œå¯ä½¿ç”¨ _ï¼‰";
	}

	protected override string _GetTemplateForLabelYear()
	{
		return "å¹´";
	}

	protected override string _GetTemplateForMessagePasswordMinLength()
	{
		return "8 å€‹å­—å…ƒä»¥ä¸Š";
	}

	protected override string _GetTemplateForMessageUsernameNoRealNameUse()
	{
		return "è«‹å‹¿ä½¿ç”¨æ‚¨çš„çœŸå¯¦å§“å";
	}

	protected override string _GetTemplateForResponseBadUsername()
	{
		return "æ­¤ä½¿ç”¨è€…åç¨±å«æœ‰ä¸ç•¶å…§å®¹ã€‚";
	}

	protected override string _GetTemplateForResponseBadUsernameForWeChat()
	{
		return "ä½¿ç”¨è€…åç¨±ä¸ç•¶";
	}

	protected override string _GetTemplateForResponseBirthdayInvalid()
	{
		return "ç”Ÿæ—¥ç„¡æ•ˆã€‚";
	}

	protected override string _GetTemplateForResponseBirthdayMustBeSetFirst()
	{
		return "è«‹å…ˆè¨­å®šç”Ÿæ—¥ã€‚";
	}

	protected override string _GetTemplateForResponseCaptchaMismatchError()
	{
		return "æ–‡å­—ä¸ç¬¦ã€‚";
	}

	protected override string _GetTemplateForResponseCaptchaNotEnteredError()
	{
		return "è«‹å¡«å¯« Captcha é©—è­‰ã€‚";
	}

	protected override string _GetTemplateForResponseFacebookConnectionError()
	{
		return "å¾ž Facebook æ“·å–æ•¸å€¼æ™‚ç™¼ç”ŸéŒ¯èª¤ã€‚";
	}

	protected override string _GetTemplateForResponseFacebookLoginAge()
	{
		return "åªæœ‰ 13 æ­²ä»¥ä¸Šçš„ä½¿ç”¨è€…å¯ä»¥ä½¿ç”¨ Facebook ç™»å…¥ã€‚";
	}

	protected override string _GetTemplateForResponseInvalidBirthday()
	{
		return "ç”Ÿæ—¥ç„¡æ•ˆã€‚";
	}

	protected override string _GetTemplateForResponseInvalidEmail()
	{
		return "æ­¤é›»å­éƒµä»¶åœ°å€ç„¡æ•ˆã€‚";
	}

	protected override string _GetTemplateForResponseJavaScriptRequired()
	{
		return "æäº¤æ­¤è¡¨æ ¼å¿…é ˆä½¿ç”¨ JavaScriptã€‚";
	}

	protected override string _GetTemplateForResponsePasswordComplexity()
	{
		return "è«‹è¼¸å…¥æ›´è¤‡é›œçš„å¯†ç¢¼ã€‚";
	}

	protected override string _GetTemplateForResponsePasswordConfirmation()
	{
		return "è«‹è¼¸å…¥å¯†ç¢¼ç¢ºèªã€‚";
	}

	protected override string _GetTemplateForResponsePasswordContainsUsernameError()
	{
		return "å¯†ç¢¼é ˆå’Œä½¿ç”¨è€…åç¨±ä¸åŒã€‚";
	}

	protected override string _GetTemplateForResponsePasswordMismatch()
	{
		return "å¯†ç¢¼ä¸ç›¸ç¬¦ã€‚";
	}

	protected override string _GetTemplateForResponsePasswordWrongShort()
	{
		return "å¯†ç¢¼éœ€è¦ 8 å€‹å­—å…ƒä»¥ä¸Šã€‚";
	}

	protected override string _GetTemplateForResponsePleaseEnterPassword()
	{
		return "è«‹è¼¸å…¥å¯†ç¢¼ã€‚";
	}

	protected override string _GetTemplateForResponsePleaseEnterUsername()
	{
		return "è«‹è¼¸å…¥ä½¿ç”¨è€…åç¨±ã€‚";
	}

	protected override string _GetTemplateForResponseSocialAccountCreationFailed()
	{
		return "ç„¡æ³•å»ºç«‹å¸³è™Ÿ";
	}

	protected override string _GetTemplateForResponseSpaceOrSpecialCharaterError()
	{
		return "ä¸èƒ½ä½¿ç”¨ç©ºæ ¼èˆ‡ç‰¹æ®Šå­—å…ƒã€‚";
	}

	protected override string _GetTemplateForResponseTooManyAccountsWithSameEmailError()
	{
		return "åŠ å…¥æ­¤é›»å­éƒµä»¶åœ°å€çš„å¸³è™ŸéŽå¤šã€‚";
	}

	protected override string _GetTemplateForResponseUnknownError()
	{
		return "å°ä¸èµ·ï¼Œç™¼ç”ŸæœªçŸ¥éŒ¯èª¤ã€‚è«‹ç¨å¾Œå†è©¦ã€‚";
	}

	protected override string _GetTemplateForResponseUsernameAllowedCharactersError()
	{
		return "ä½¿ç”¨è€…åç¨±åªèƒ½å«æœ‰å­—æ¯ã€æ•¸å­—åŠ _ã€‚";
	}

	protected override string _GetTemplateForResponseUsernameAlreadyInUse()
	{
		return "æ­¤ä½¿ç”¨è€…åç¨±å·²è¢«ä½¿ç”¨ã€‚";
	}

	protected override string _GetTemplateForResponseUsernameExplicit()
	{
		return "æ­¤ä½¿ç”¨è€…åç¨±å«æœ‰ä¸ç•¶å…§å®¹ï¼Œè«‹é‡æ–°å˜—è©¦ã€‚";
	}

	protected override string _GetTemplateForResponseUsernameInvalid()
	{
		return "è«‹è¼¸å…¥æœ‰æ•ˆçš„ä½¿ç”¨è€…åç¨±ã€‚";
	}

	protected override string _GetTemplateForResponseUsernameInvalidCharacters()
	{
		return "åªå…è¨±ä½¿ç”¨ a-zã€A-Zã€0-9 åŠ _ã€‚";
	}

	protected override string _GetTemplateForResponseUsernameInvalidLength()
	{
		return "ä½¿ç”¨è€…åç¨±æ‡‰ç‚º 3 åˆ° 20 å€‹å­—å…ƒã€‚";
	}

	protected override string _GetTemplateForResponseUsernameInvalidUnderscore()
	{
		return "ä½¿ç”¨è€…åç¨±ç„¡æ³•ä»¥ _ é–‹é ­æˆ–çµå°¾ã€‚";
	}

	protected override string _GetTemplateForResponseUsernameNotAvailable()
	{
		return "ç„¡æ³•ä½¿ç”¨æ­¤ä½¿ç”¨è€…åç¨±ã€‚è«‹é‡æ–°å˜—è©¦ã€‚";
	}

	protected override string _GetTemplateForResponseUsernameOrPasswordIncorrect()
	{
		return "ä½¿ç”¨è€…åç¨±æˆ–å¯†ç¢¼ä¸æ­£ç¢ºã€‚";
	}

	protected override string _GetTemplateForResponseUsernamePasswordRequired()
	{
		return "ä½¿ç”¨è€…åç¨±èˆ‡å¯†ç¢¼ç‚ºå¿…å¡«é …ç›®ã€‚";
	}

	protected override string _GetTemplateForResponseUsernamePrivateInfo()
	{
		return "ä½¿ç”¨è€…åç¨±å¯èƒ½å«æœ‰ç§äººè³‡æ–™ã€‚";
	}

	protected override string _GetTemplateForResponseUsernameRequired()
	{
		return "ä½¿ç”¨è€…åç¨±å¿…å¡«ã€‚";
	}

	protected override string _GetTemplateForResponseUsernameTakenTryAgain()
	{
		return "æ­¤ä½¿ç”¨è€…åç¨±å·²è¢«ä½¿ç”¨ï¼Œè«‹è¼¸å…¥æ–°çš„ä½¿ç”¨è€…åç¨±ã€‚";
	}

	protected override string _GetTemplateForResponseUsernameTooManyUnderscores()
	{
		return "ä½¿ç”¨è€…åç¨±ç„¡æ³•ä½¿ç”¨è¶…éŽä¸€å€‹ _ã€‚";
	}
}


}
