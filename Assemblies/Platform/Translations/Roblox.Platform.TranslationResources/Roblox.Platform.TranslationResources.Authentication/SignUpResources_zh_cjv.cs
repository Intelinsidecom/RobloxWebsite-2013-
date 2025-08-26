namespace Roblox.Platform.TranslationResources.Authentication {
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
	public override string ActionCreateAccount => "åˆ›å»ºå¸æˆ·";

	/// <summary>
	/// Key: "Action.LinkAccount"
	/// Button text to link 3rd Party Account to a Roblox Account
	/// English String: "Link Account"
	/// </summary>
	public override string ActionLinkAccount => "é“¾æŽ¥å¸æˆ·";

	/// <summary>
	/// Key: "Action.LogInCapitalized"
	/// button label for capitalized words for Log In
	/// English String: "Log In"
	/// </summary>
	public override string ActionLogInCapitalized => "ç™»å½•";

	/// <summary>
	/// Key: "Action.ReturnHome"
	/// button label to return the user to home page
	/// English String: "Return Home"
	/// </summary>
	public override string ActionReturnHome => "è¿”å›žé¦–é¡µ";

	/// <summary>
	/// Key: "Action.SignUp"
	/// English String: "Sign up"
	/// </summary>
	public override string ActionSignUp => "æ³¨å†Œ";

	public override string ActionSignupAndSync => "æ³¨å†Œå¹¶åŒæ­¥";

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
	public override string DescriptionAccountLinkingWarning => "è‹¥è¦å…³è”çŽ°æœ‰çš„ Roblox å¸æˆ·ï¼Œè¯·ç™»å½•å¹¶åœ¨å¸æˆ·è®¾ç½®é¡µé¢è¿›è¡Œå…³è”ã€‚";

	/// <summary>
	/// Key: "Description.NoRealName"
	/// description
	/// English String: "Do not use your real name."
	/// </summary>
	public override string DescriptionNoRealName => "è¯·å‹¿ä½¿ç”¨ä½ çš„çœŸå®žå§“åã€‚";

	/// <summary>
	/// Key: "Description.PrivacyPolicy"
	/// English String: "Privacy Policy"
	/// </summary>
	public override string DescriptionPrivacyPolicy => "éšç§æ”¿ç­–";

	/// <summary>
	/// Key: "Description.TermsOfService"
	/// English String: "Terms of Service"
	/// </summary>
	public override string DescriptionTermsOfService => "æœåŠ¡æ¡æ¬¾";

	/// <summary>
	/// Key: "GuestSignUpAB.Action.SignUp"
	/// English String: "Sign Up"
	/// </summary>
	public override string GuestSignUpABActionSignUp => "æ³¨å†Œ";

	/// <summary>
	/// Key: "Heading.ConnectFacebook"
	/// section heading
	/// English String: "Connect to Facebook"
	/// </summary>
	public override string HeadingConnectFacebook => "è¿žæŽ¥è‡³ Facebook";

	/// <summary>
	/// Key: "Heading.CreateAnAccount"
	/// should be capitalized if the language supports capitalization
	/// English String: "CREATE AN ACCOUNT"
	/// </summary>
	public override string HeadingCreateAnAccount => "åˆ›å»ºå¸æˆ·";

	/// <summary>
	/// Key: "Heading.LoginHaveFun"
	/// heading for login container
	/// English String: "Log in and start having fun!"
	/// </summary>
	public override string HeadingLoginHaveFun => "ç™»å½•å¹¶å¼€å§‹æ¸¸æˆå§ï¼";

	/// <summary>
	/// Key: "Heading.SignupHaveFun"
	/// signup form heading
	/// English String: "Sign up and start having fun!"
	/// </summary>
	public override string HeadingSignupHaveFun => "æ³¨å†Œå¸æˆ·ï¼ŒåŠ å…¥æ¸¸æˆï¼";

	/// <summary>
	/// Key: "Label.About"
	/// About link on roller coaster page
	/// English String: "About"
	/// </summary>
	public override string LabelAbout => "ç®€ä»‹";

	/// <summary>
	/// Key: "Label.AlreadyHaveRobloxAccount"
	/// English String: "Already have a Roblox account?"
	/// </summary>
	public override string LabelAlreadyHaveRobloxAccount => "å·²æœ‰ Roblox å¸æˆ·äº†å—ï¼Ÿ";

	/// <summary>
	/// Key: "Label.AlreadyRegistered"
	/// label
	/// English String: "Already registered?"
	/// </summary>
	public override string LabelAlreadyRegistered => "å·²æ³¨å†Œï¼Ÿ";

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
	public override string LabelConfirmPassword => "ç¡®è®¤å¯†ç ";

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
	public override string LabelDesiredUsername => "æƒ³ä½¿ç”¨çš„ç”¨æˆ·åï¼š";

	/// <summary>
	/// Key: "Label.FacebookNotLinked"
	/// English String: "Your Facebook account is not linked to any Roblox account. Please sign up for a Roblox account."
	/// </summary>
	public override string LabelFacebookNotLinked => "ä½ çš„ Facebook å¸æˆ·æ²¡æœ‰å…³è”è‡³ä»»ä½• Roblox å¸æˆ·ã€‚è¯·æ³¨å†Œä¸€ä¸ª Roblox å¸æˆ·ã€‚";

	/// <summary>
	/// Key: "Label.FacebookSignupUsername"
	/// username field label for FB signup
	/// English String: "Create Roblox username:"
	/// </summary>
	public override string LabelFacebookSignupUsername => "åˆ›å»º Roblox ç”¨æˆ·åï¼š";

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
	public override string LabelGender => "æ€§åˆ«";

	/// <summary>
	/// Key: "Label.GenderRequired"
	/// English String: "Gender is required."
	/// </summary>
	public override string LabelGenderRequired => "éœ€è¦æä¾›æ€§åˆ«ã€‚";

	/// <summary>
	/// Key: "Label.GenderWithColumn"
	/// should have column if the language supports it
	/// English String: "Gender:"
	/// </summary>
	public override string LabelGenderWithColumn => "æ€§åˆ«ï¼š";

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
	public override string LabelPassword => "å¯†ç ";

	/// <summary>
	/// Key: "Label.PasswordRequirements"
	/// English String: "Password (min length 8)"
	/// </summary>
	public override string LabelPasswordRequirements => "å¯†ç ï¼ˆæœ€çŸ­ 8 ä¸ªå­—ç¬¦ï¼‰";

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
	public override string LabelPlay => "æ¸¸æˆ";

	/// <summary>
	/// Key: "Label.PleaseAgreeToTerms"
	/// English String: "Please agree to our Terms of Use and Privacy Policy."
	/// </summary>
	public override string LabelPleaseAgreeToTerms => "è¯·åŒæ„æˆ‘ä»¬çš„ä½¿ç”¨æ¡æ¬¾ä¸Žéšç§æ”¿ç­–ã€‚";

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
	public override string LabelSignupButtonText => "æ³¨å†Œå¸æˆ·ï¼ŒåŠ å…¥æ¸¸æˆï¼";

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
	public override string LabelSignUpWith => "æˆ–ä½¿ç”¨ä»¥ä¸‹æ–¹å¼æ³¨å†Œ";

	/// <summary>
	/// Key: "Label.TermsOfUse"
	/// terms of use link label
	/// English String: "Terms of Use"
	/// </summary>
	public override string LabelTermsOfUse => "ä½¿ç”¨æ¡æ¬¾";

	/// <summary>
	/// Key: "Label.Username"
	/// English String: "Username"
	/// </summary>
	public override string LabelUsername => "ç”¨æˆ·å";

	/// <summary>
	/// Key: "Label.UsernameCharacterLimit"
	/// label
	/// English String: "3-20 alphanumeric characters, no spaces."
	/// </summary>
	public override string LabelUsernameCharacterLimit => "3-20 ä¸ªå­—æ¯æ•°å­—å­—ç¬¦ï¼Œæ— ç©ºæ ¼ã€‚";

	/// <summary>
	/// Key: "Label.UsernameHint"
	/// placeholder for username field
	/// English String: "Username (don't use your real name)"
	/// </summary>
	public override string LabelUsernameHint => "ç”¨æˆ·åï¼ˆè¯·å‹¿ä½¿ç”¨ä½ çš„çœŸå®žå§“åï¼‰";

	/// <summary>
	/// Key: "Label.UsernameRequirements"
	/// English String: "Username (length 3-20, _ is allowed)"
	/// </summary>
	public override string LabelUsernameRequirements => "ç”¨æˆ·åï¼ˆé•¿åº¦ 3-20ï¼Œ å…è®¸ä½¿ç”¨â€œ_â€ï¼‰";

	/// <summary>
	/// Key: "Label.Year"
	/// English String: "Year"
	/// </summary>
	public override string LabelYear => "å¹´";

	/// <summary>
	/// Key: "Message.Password.MinLength"
	/// English String: "Min length 8"
	/// </summary>
	public override string MessagePasswordMinLength => "æœ€çŸ­ 8 ä¸ªå­—ç¬¦";

	/// <summary>
	/// Key: "Message.Username.NoRealNameUse"
	/// English String: "Don't use your real name"
	/// </summary>
	public override string MessageUsernameNoRealNameUse => "è¯·å‹¿ä½¿ç”¨ä½ çš„çœŸå®žå§“åã€‚";

	/// <summary>
	/// Key: "Response.BadUsername"
	/// English String: "Username not appropriate for Roblox."
	/// </summary>
	public override string ResponseBadUsername => "ç”¨æˆ·åä¸é€‚ç”¨äºŽ Robloxã€‚";

	/// <summary>
	/// Key: "Response.BadUsernameForWeChat"
	/// message shown when signing up with an inappropriate username
	/// English String: "Username is not appropriate"
	/// </summary>
	public override string ResponseBadUsernameForWeChat => "ç”¨æˆ·åç§°ä¸å½“";

	/// <summary>
	/// Key: "Response.BirthdayInvalid"
	/// English String: "This birthday is invalid."
	/// </summary>
	public override string ResponseBirthdayInvalid => "æ­¤ç”Ÿæ—¥æ— æ•ˆã€‚";

	/// <summary>
	/// Key: "Response.BirthdayMustBeSetFirst"
	/// English String: "Birthday must be set first."
	/// </summary>
	public override string ResponseBirthdayMustBeSetFirst => "å¿…é¡»å…ˆè®¾å®šç”Ÿæ—¥ã€‚";

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
	public override string ResponseCaptchaNotEnteredError => "è¯·å¡«å†™éªŒè¯ç ";

	/// <summary>
	/// Key: "Response.FacebookConnectionError"
	/// error message
	/// English String: "Error while retrieving values from Facebook."
	/// </summary>
	public override string ResponseFacebookConnectionError => "ä»Ž Facebook å–å›žæ•°å€¼æ—¶å‡ºé”™ã€‚";

	/// <summary>
	/// Key: "Response.FacebookLoginAge"
	/// English String: "Facebook login can only be used by users above 13."
	/// </summary>
	public override string ResponseFacebookLoginAge => "åªæœ‰ 13 å²ä»¥ä¸Šçš„ç”¨æˆ·æ‰èƒ½ä½¿ç”¨ Facebook ç™»å½•ã€‚";

	/// <summary>
	/// Key: "Response.InvalidBirthday"
	/// English String: "Invalid birthday."
	/// </summary>
	public override string ResponseInvalidBirthday => "ç”Ÿæ—¥æ— æ•ˆã€‚";

	/// <summary>
	/// Key: "Response.InvalidEmail"
	/// English String: "Invalid email address."
	/// </summary>
	public override string ResponseInvalidEmail => "ç”µå­é‚®ä»¶åœ°å€æ— æ•ˆã€‚";

	/// <summary>
	/// Key: "Response.JavaScriptRequired"
	/// error to show that JavaScipt is required for the form to work
	/// English String: "JavaScript is required to submit this form."
	/// </summary>
	public override string ResponseJavaScriptRequired => "æäº¤æ­¤è¡¨å•éœ€è¦ JavaScriptã€‚";

	/// <summary>
	/// Key: "Response.PasswordComplexity"
	/// English String: "Please create a more complex password."
	/// </summary>
	public override string ResponsePasswordComplexity => "è¯·åˆ›å»ºä¸€ä¸ªæ›´å¤æ‚çš„å¯†ç ã€‚";

	/// <summary>
	/// Key: "Response.PasswordConfirmation"
	/// validation message for password confirmation
	/// English String: "Please enter a password confirmation."
	/// </summary>
	public override string ResponsePasswordConfirmation => "è¯·è¾“å…¥å¯†ç ç¡®è®¤ã€‚";

	/// <summary>
	/// Key: "Response.PasswordContainsUsernameError"
	/// error when passsword has username in it
	/// English String: "Password shouldn't match username."
	/// </summary>
	public override string ResponsePasswordContainsUsernameError => "å¯†ç ä¸å¯åŒ…å«ç”¨æˆ·åã€‚";

	/// <summary>
	/// Key: "Response.PasswordMismatch"
	/// English String: "Passwords do not match."
	/// </summary>
	public override string ResponsePasswordMismatch => "å¯†ç ä¸åŒ¹é…ã€‚";

	/// <summary>
	/// Key: "Response.PasswordWrongShort"
	/// English String: "Passwords must be at least 8 characters long."
	/// </summary>
	public override string ResponsePasswordWrongShort => "å¯†ç é•¿åº¦å¿…é¡»è‡³å°‘ä¸º 8 ä¸ªå­—ç¬¦ã€‚";

	/// <summary>
	/// Key: "Response.PleaseEnterPassword"
	/// English String: "Please enter a password."
	/// </summary>
	public override string ResponsePleaseEnterPassword => "è¯·è¾“å…¥å¯†ç ã€‚";

	/// <summary>
	/// Key: "Response.PleaseEnterUsername"
	/// English String: "Please enter a username."
	/// </summary>
	public override string ResponsePleaseEnterUsername => "è¯·è¾“å…¥ç”¨æˆ·åã€‚";

	/// <summary>
	/// Key: "Response.SocialAccountCreationFailed"
	/// error message
	/// English String: "Account creation failed"
	/// </summary>
	public override string ResponseSocialAccountCreationFailed => "å¸æˆ·åˆ›å»ºå¤±è´¥";

	/// <summary>
	/// Key: "Response.SpaceOrSpecialCharaterError"
	/// Spaces and special characters are not allowed error message
	/// English String: "Spaces and special characters are not allowed."
	/// </summary>
	public override string ResponseSpaceOrSpecialCharaterError => "ä¸å…è®¸ä½¿ç”¨ç©ºæ ¼å’Œç‰¹æ®Šå­—ç¬¦ã€‚";

	/// <summary>
	/// Key: "Response.TooManyAccountsWithSameEmailError"
	/// Too many accounts use this email error message
	/// English String: "Too many accounts use this email."
	/// </summary>
	public override string ResponseTooManyAccountsWithSameEmailError => "è¿‡å¤šå¸æˆ·ä½¿ç”¨æ­¤ç”µå­é‚®ä»¶ã€‚";

	/// <summary>
	/// Key: "Response.UnknownError"
	/// English String: "Sorry! An unknown error occurred. Please try again later."
	/// </summary>
	public override string ResponseUnknownError => "æŠ±æ­‰ï¼å‘ç”ŸæœªçŸ¥é”™è¯¯ã€‚è¯·ç¨åŽé‡è¯•ã€‚";

	/// <summary>
	/// Key: "Response.UsernameAllowedCharactersError"
	/// error showing which characters are allowed for username
	/// English String: "Usernames may only contain letters, numbers, and _."
	/// </summary>
	public override string ResponseUsernameAllowedCharactersError => "ç”¨æˆ·åå¯èƒ½ä»…åŒ…å«å­—æ¯ï¼Œæ•°å­—åŠâ€œ_â€ã€‚";

	/// <summary>
	/// Key: "Response.UsernameAlreadyInUse"
	/// English String: "This username is already in use."
	/// </summary>
	public override string ResponseUsernameAlreadyInUse => "æ­¤ç”¨æˆ·åå·²è¢«ä½¿ç”¨ã€‚";

	/// <summary>
	/// Key: "Response.UsernameExplicit"
	/// English String: "This username is not allowed, please try another."
	/// </summary>
	public override string ResponseUsernameExplicit => "æ­¤ç”¨æˆ·åå«æœ‰ä¸å½“å†…å®¹ï¼Œè¯·é‡æ–°å‘½åã€‚";

	/// <summary>
	/// Key: "Response.UsernameInvalid"
	/// English String: "Please enter a valid username."
	/// </summary>
	public override string ResponseUsernameInvalid => "è¯·è¾“å…¥æœ‰æ•ˆç”¨æˆ·åã€‚";

	/// <summary>
	/// Key: "Response.UsernameInvalidCharacters"
	/// English String: "Only a-z, A-Z, 0-9 and _ are allowed."
	/// </summary>
	public override string ResponseUsernameInvalidCharacters => "åªå…è®¸ä½¿ç”¨ a-zã€A-Zã€0-9 åŠ _ã€‚";

	/// <summary>
	/// Key: "Response.UsernameInvalidLength"
	/// English String: "Usernames can be 3 to 20 characters long."
	/// </summary>
	public override string ResponseUsernameInvalidLength => "ç”¨æˆ·åçš„é•¿åº¦é¡»ä¸º 3 è‡³ 20 ä¸ªå­—ç¬¦ã€‚";

	/// <summary>
	/// Key: "Response.UsernameInvalidUnderscore"
	/// English String: "Usernames cannot start or end with _."
	/// </summary>
	public override string ResponseUsernameInvalidUnderscore => "ç”¨æˆ·åçš„å¼€å¤´æˆ–ç»“å°¾ä¸èƒ½æ˜¯â€œ_â€ã€‚";

	/// <summary>
	/// Key: "Response.UsernameNotAvailable"
	/// English String: "Username not available. Please try again."
	/// </summary>
	public override string ResponseUsernameNotAvailable => "ç”¨æˆ·åä¸å¯ç”¨ã€‚è¯·é‡è¯•ã€‚";

	/// <summary>
	/// Key: "Response.UsernameOrPasswordIncorrect"
	/// Your username or password is incorrect
	/// English String: "Your username or password is incorrect."
	/// </summary>
	public override string ResponseUsernameOrPasswordIncorrect => "ä½ çš„ç”¨æˆ·åæˆ–å¯†ç ä¸æ­£ç¡®ã€‚";

	/// <summary>
	/// Key: "Response.UsernamePasswordRequired"
	/// Username and Password are required error message
	/// English String: "Username and Password are required."
	/// </summary>
	public override string ResponseUsernamePasswordRequired => "éœ€è¦æä¾›ç”¨æˆ·ååŠå¯†ç ã€‚";

	/// <summary>
	/// Key: "Response.UsernamePrivateInfo"
	/// English String: "Username might contain private information."
	/// </summary>
	public override string ResponseUsernamePrivateInfo => "ç”¨æˆ·åå¯èƒ½åŒ…å«ç§äººä¿¡æ¯ã€‚";

	/// <summary>
	/// Key: "Response.UsernameRequired"
	/// validation error message
	/// English String: "Username is required."
	/// </summary>
	public override string ResponseUsernameRequired => "éœ€è¦æä¾›ç”¨æˆ·åã€‚";

	/// <summary>
	/// Key: "Response.UsernameTakenTryAgain"
	/// English String: "This username is already taken! Please try a different one."
	/// </summary>
	public override string ResponseUsernameTakenTryAgain => "æ­¤ç”¨æˆ·åå·²è¢«ä½¿ç”¨ï¼Œè¯·é‡æ–°å‘½åã€‚";

	/// <summary>
	/// Key: "Response.UsernameTooManyUnderscores"
	/// English String: "Usernames can have at most one _."
	/// </summary>
	public override string ResponseUsernameTooManyUnderscores => "ç”¨æˆ·åæœ€å¤šå¯åŒ…å«ä¸€ä¸ªâ€œ_â€œã€‚";

	public SignUpResources_zh_cjv(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionCreateAccount()
	{
		return "åˆ›å»ºå¸æˆ·";
	}

	protected override string _GetTemplateForActionLinkAccount()
	{
		return "é“¾æŽ¥å¸æˆ·";
	}

	protected override string _GetTemplateForActionLogInCapitalized()
	{
		return "ç™»å½•";
	}

	protected override string _GetTemplateForActionReturnHome()
	{
		return "è¿”å›žé¦–é¡µ";
	}

	protected override string _GetTemplateForActionSignUp()
	{
		return "æ³¨å†Œ";
	}

	protected override string _GetTemplateForActionSignupAndSync()
	{
		return "æ³¨å†Œå¹¶åŒæ­¥";
	}

	protected override string _GetTemplateForActionSubmit()
	{
		return "æäº¤";
	}

	protected override string _GetTemplateForDescriptionAccountLinkingWarning()
	{
		return "è‹¥è¦å…³è”çŽ°æœ‰çš„ Roblox å¸æˆ·ï¼Œè¯·ç™»å½•å¹¶åœ¨å¸æˆ·è®¾ç½®é¡µé¢è¿›è¡Œå…³è”ã€‚";
	}

	protected override string _GetTemplateForDescriptionNoRealName()
	{
		return "è¯·å‹¿ä½¿ç”¨ä½ çš„çœŸå®žå§“åã€‚";
	}

	protected override string _GetTemplateForDescriptionPrivacyPolicy()
	{
		return "éšç§æ”¿ç­–";
	}

	/// <summary>
	/// Key: "Description.SignUpAgreement"
	/// terms of use agreement checkbox label to signup.
	/// English String: "By clicking {spanStart}Sign Up{spanEnd}, you are agreeing to the {termsOfUseLink} and acknowledging the {privacyPolicyLink}"
	/// </summary>
	public override string DescriptionSignUpAgreement(string spanStart, string spanEnd, string termsOfUseLink, string privacyPolicyLink)
	{
		return $"ç‚¹æŒ‰{spanStart}â€œæ³¨å†Œâ€{spanEnd}ï¼Œå³è¡¨ç¤ºä½ å·²åŒæ„{termsOfUseLink}å¹¶äº†è§£{privacyPolicyLink}";
	}

	protected override string _GetTemplateForDescriptionSignUpAgreement()
	{
		return "ç‚¹æŒ‰{spanStart}â€œæ³¨å†Œâ€{spanEnd}ï¼Œå³è¡¨ç¤ºä½ å·²åŒæ„{termsOfUseLink}å¹¶äº†è§£{privacyPolicyLink}";
	}

	protected override string _GetTemplateForDescriptionTermsOfService()
	{
		return "æœåŠ¡æ¡æ¬¾";
	}

	protected override string _GetTemplateForGuestSignUpABActionSignUp()
	{
		return "æ³¨å†Œ";
	}

	protected override string _GetTemplateForHeadingConnectFacebook()
	{
		return "è¿žæŽ¥è‡³ Facebook";
	}

	protected override string _GetTemplateForHeadingCreateAnAccount()
	{
		return "åˆ›å»ºå¸æˆ·";
	}

	/// <summary>
	/// Key: "Heading.FacebookSignupAlmostDone"
	/// when user signs up using Facebook, this is shown in next step to create a password.
	/// English String: "{firstname}, YOU'RE ALMOST DONE"
	/// </summary>
	public override string HeadingFacebookSignupAlmostDone(string firstname)
	{
		return $"{firstname}ï¼Œä½ é©¬ä¸Šå°±å®Œæˆäº†";
	}

	protected override string _GetTemplateForHeadingFacebookSignupAlmostDone()
	{
		return "{firstname}ï¼Œä½ é©¬ä¸Šå°±å®Œæˆäº†";
	}

	protected override string _GetTemplateForHeadingLoginHaveFun()
	{
		return "ç™»å½•å¹¶å¼€å§‹æ¸¸æˆå§ï¼";
	}

	protected override string _GetTemplateForHeadingSignupHaveFun()
	{
		return "æ³¨å†Œå¸æˆ·ï¼ŒåŠ å…¥æ¸¸æˆï¼";
	}

	protected override string _GetTemplateForLabelAbout()
	{
		return "ç®€ä»‹";
	}

	protected override string _GetTemplateForLabelAlreadyHaveRobloxAccount()
	{
		return "å·²æœ‰ Roblox å¸æˆ·äº†å—ï¼Ÿ";
	}

	protected override string _GetTemplateForLabelAlreadyRegistered()
	{
		return "å·²æ³¨å†Œï¼Ÿ";
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
		return "ç¡®è®¤å¯†ç ";
	}

	protected override string _GetTemplateForLabelDay()
	{
		return "æ—¥";
	}

	protected override string _GetTemplateForLabelDesiredUsername()
	{
		return "æƒ³ä½¿ç”¨çš„ç”¨æˆ·åï¼š";
	}

	protected override string _GetTemplateForLabelFacebookNotLinked()
	{
		return "ä½ çš„ Facebook å¸æˆ·æ²¡æœ‰å…³è”è‡³ä»»ä½• Roblox å¸æˆ·ã€‚è¯·æ³¨å†Œä¸€ä¸ª Roblox å¸æˆ·ã€‚";
	}

	protected override string _GetTemplateForLabelFacebookSignupUsername()
	{
		return "åˆ›å»º Roblox ç”¨æˆ·åï¼š";
	}

	protected override string _GetTemplateForLabelFemale()
	{
		return "å¥³";
	}

	protected override string _GetTemplateForLabelGender()
	{
		return "æ€§åˆ«";
	}

	protected override string _GetTemplateForLabelGenderRequired()
	{
		return "éœ€è¦æä¾›æ€§åˆ«ã€‚";
	}

	protected override string _GetTemplateForLabelGenderWithColumn()
	{
		return "æ€§åˆ«ï¼š";
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
		return "å¯†ç ";
	}

	protected override string _GetTemplateForLabelPasswordRequirements()
	{
		return "å¯†ç ï¼ˆæœ€çŸ­ 8 ä¸ªå­—ç¬¦ï¼‰";
	}

	protected override string _GetTemplateForLabelPlatforms()
	{
		return "å¹³å°";
	}

	protected override string _GetTemplateForLabelPlay()
	{
		return "æ¸¸æˆ";
	}

	protected override string _GetTemplateForLabelPleaseAgreeToTerms()
	{
		return "è¯·åŒæ„æˆ‘ä»¬çš„ä½¿ç”¨æ¡æ¬¾ä¸Žéšç§æ”¿ç­–ã€‚";
	}

	protected override string _GetTemplateForLabelRequired()
	{
		return "å¿…å¡«";
	}

	protected override string _GetTemplateForLabelSignupButtonText()
	{
		return "æ³¨å†Œå¸æˆ·ï¼ŒåŠ å…¥æ¸¸æˆï¼";
	}

	protected override string _GetTemplateForLabelSignUpWith()
	{
		return "æˆ–ä½¿ç”¨ä»¥ä¸‹æ–¹å¼æ³¨å†Œ";
	}

	protected override string _GetTemplateForLabelTermsOfUse()
	{
		return "ä½¿ç”¨æ¡æ¬¾";
	}

	protected override string _GetTemplateForLabelUsername()
	{
		return "ç”¨æˆ·å";
	}

	protected override string _GetTemplateForLabelUsernameCharacterLimit()
	{
		return "3-20 ä¸ªå­—æ¯æ•°å­—å­—ç¬¦ï¼Œæ— ç©ºæ ¼ã€‚";
	}

	protected override string _GetTemplateForLabelUsernameHint()
	{
		return "ç”¨æˆ·åï¼ˆè¯·å‹¿ä½¿ç”¨ä½ çš„çœŸå®žå§“åï¼‰";
	}

	protected override string _GetTemplateForLabelUsernameRequirements()
	{
		return "ç”¨æˆ·åï¼ˆé•¿åº¦ 3-20ï¼Œ å…è®¸ä½¿ç”¨â€œ_â€ï¼‰";
	}

	protected override string _GetTemplateForLabelYear()
	{
		return "å¹´";
	}

	protected override string _GetTemplateForMessagePasswordMinLength()
	{
		return "æœ€çŸ­ 8 ä¸ªå­—ç¬¦";
	}

	protected override string _GetTemplateForMessageUsernameNoRealNameUse()
	{
		return "è¯·å‹¿ä½¿ç”¨ä½ çš„çœŸå®žå§“åã€‚";
	}

	protected override string _GetTemplateForResponseBadUsername()
	{
		return "ç”¨æˆ·åä¸é€‚ç”¨äºŽ Robloxã€‚";
	}

	protected override string _GetTemplateForResponseBadUsernameForWeChat()
	{
		return "ç”¨æˆ·åç§°ä¸å½“";
	}

	protected override string _GetTemplateForResponseBirthdayInvalid()
	{
		return "æ­¤ç”Ÿæ—¥æ— æ•ˆã€‚";
	}

	protected override string _GetTemplateForResponseBirthdayMustBeSetFirst()
	{
		return "å¿…é¡»å…ˆè®¾å®šç”Ÿæ—¥ã€‚";
	}

	protected override string _GetTemplateForResponseCaptchaMismatchError()
	{
		return "æ–‡å­—ä¸ç¬¦ã€‚";
	}

	protected override string _GetTemplateForResponseCaptchaNotEnteredError()
	{
		return "è¯·å¡«å†™éªŒè¯ç ";
	}

	protected override string _GetTemplateForResponseFacebookConnectionError()
	{
		return "ä»Ž Facebook å–å›žæ•°å€¼æ—¶å‡ºé”™ã€‚";
	}

	protected override string _GetTemplateForResponseFacebookLoginAge()
	{
		return "åªæœ‰ 13 å²ä»¥ä¸Šçš„ç”¨æˆ·æ‰èƒ½ä½¿ç”¨ Facebook ç™»å½•ã€‚";
	}

	protected override string _GetTemplateForResponseInvalidBirthday()
	{
		return "ç”Ÿæ—¥æ— æ•ˆã€‚";
	}

	protected override string _GetTemplateForResponseInvalidEmail()
	{
		return "ç”µå­é‚®ä»¶åœ°å€æ— æ•ˆã€‚";
	}

	protected override string _GetTemplateForResponseJavaScriptRequired()
	{
		return "æäº¤æ­¤è¡¨å•éœ€è¦ JavaScriptã€‚";
	}

	protected override string _GetTemplateForResponsePasswordComplexity()
	{
		return "è¯·åˆ›å»ºä¸€ä¸ªæ›´å¤æ‚çš„å¯†ç ã€‚";
	}

	protected override string _GetTemplateForResponsePasswordConfirmation()
	{
		return "è¯·è¾“å…¥å¯†ç ç¡®è®¤ã€‚";
	}

	protected override string _GetTemplateForResponsePasswordContainsUsernameError()
	{
		return "å¯†ç ä¸å¯åŒ…å«ç”¨æˆ·åã€‚";
	}

	protected override string _GetTemplateForResponsePasswordMismatch()
	{
		return "å¯†ç ä¸åŒ¹é…ã€‚";
	}

	protected override string _GetTemplateForResponsePasswordWrongShort()
	{
		return "å¯†ç é•¿åº¦å¿…é¡»è‡³å°‘ä¸º 8 ä¸ªå­—ç¬¦ã€‚";
	}

	protected override string _GetTemplateForResponsePleaseEnterPassword()
	{
		return "è¯·è¾“å…¥å¯†ç ã€‚";
	}

	protected override string _GetTemplateForResponsePleaseEnterUsername()
	{
		return "è¯·è¾“å…¥ç”¨æˆ·åã€‚";
	}

	protected override string _GetTemplateForResponseSocialAccountCreationFailed()
	{
		return "å¸æˆ·åˆ›å»ºå¤±è´¥";
	}

	protected override string _GetTemplateForResponseSpaceOrSpecialCharaterError()
	{
		return "ä¸å…è®¸ä½¿ç”¨ç©ºæ ¼å’Œç‰¹æ®Šå­—ç¬¦ã€‚";
	}

	protected override string _GetTemplateForResponseTooManyAccountsWithSameEmailError()
	{
		return "è¿‡å¤šå¸æˆ·ä½¿ç”¨æ­¤ç”µå­é‚®ä»¶ã€‚";
	}

	protected override string _GetTemplateForResponseUnknownError()
	{
		return "æŠ±æ­‰ï¼å‘ç”ŸæœªçŸ¥é”™è¯¯ã€‚è¯·ç¨åŽé‡è¯•ã€‚";
	}

	protected override string _GetTemplateForResponseUsernameAllowedCharactersError()
	{
		return "ç”¨æˆ·åå¯èƒ½ä»…åŒ…å«å­—æ¯ï¼Œæ•°å­—åŠâ€œ_â€ã€‚";
	}

	protected override string _GetTemplateForResponseUsernameAlreadyInUse()
	{
		return "æ­¤ç”¨æˆ·åå·²è¢«ä½¿ç”¨ã€‚";
	}

	protected override string _GetTemplateForResponseUsernameExplicit()
	{
		return "æ­¤ç”¨æˆ·åå«æœ‰ä¸å½“å†…å®¹ï¼Œè¯·é‡æ–°å‘½åã€‚";
	}

	protected override string _GetTemplateForResponseUsernameInvalid()
	{
		return "è¯·è¾“å…¥æœ‰æ•ˆç”¨æˆ·åã€‚";
	}

	protected override string _GetTemplateForResponseUsernameInvalidCharacters()
	{
		return "åªå…è®¸ä½¿ç”¨ a-zã€A-Zã€0-9 åŠ _ã€‚";
	}

	protected override string _GetTemplateForResponseUsernameInvalidLength()
	{
		return "ç”¨æˆ·åçš„é•¿åº¦é¡»ä¸º 3 è‡³ 20 ä¸ªå­—ç¬¦ã€‚";
	}

	protected override string _GetTemplateForResponseUsernameInvalidUnderscore()
	{
		return "ç”¨æˆ·åçš„å¼€å¤´æˆ–ç»“å°¾ä¸èƒ½æ˜¯â€œ_â€ã€‚";
	}

	protected override string _GetTemplateForResponseUsernameNotAvailable()
	{
		return "ç”¨æˆ·åä¸å¯ç”¨ã€‚è¯·é‡è¯•ã€‚";
	}

	protected override string _GetTemplateForResponseUsernameOrPasswordIncorrect()
	{
		return "ä½ çš„ç”¨æˆ·åæˆ–å¯†ç ä¸æ­£ç¡®ã€‚";
	}

	protected override string _GetTemplateForResponseUsernamePasswordRequired()
	{
		return "éœ€è¦æä¾›ç”¨æˆ·ååŠå¯†ç ã€‚";
	}

	protected override string _GetTemplateForResponseUsernamePrivateInfo()
	{
		return "ç”¨æˆ·åå¯èƒ½åŒ…å«ç§äººä¿¡æ¯ã€‚";
	}

	protected override string _GetTemplateForResponseUsernameRequired()
	{
		return "éœ€è¦æä¾›ç”¨æˆ·åã€‚";
	}

	protected override string _GetTemplateForResponseUsernameTakenTryAgain()
	{
		return "æ­¤ç”¨æˆ·åå·²è¢«ä½¿ç”¨ï¼Œè¯·é‡æ–°å‘½åã€‚";
	}

	protected override string _GetTemplateForResponseUsernameTooManyUnderscores()
	{
		return "ç”¨æˆ·åæœ€å¤šå¯åŒ…å«ä¸€ä¸ªâ€œ_â€œã€‚";
	}
}


}
