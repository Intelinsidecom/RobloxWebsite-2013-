namespace Roblox.Platform.TranslationResources.Authentication {
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
	public override string ActionCreateAccount => "ã‚¢ã‚«ã‚¦ãƒ³ãƒˆã‚’ä½œæˆ";

	/// <summary>
	/// Key: "Action.LinkAccount"
	/// Button text to link 3rd Party Account to a Roblox Account
	/// English String: "Link Account"
	/// </summary>
	public override string ActionLinkAccount => "ã‚¢ã‚«ã‚¦ãƒ³ãƒˆã‚’ãƒªãƒ³ã‚¯ã™ã‚‹";

	/// <summary>
	/// Key: "Action.LogInCapitalized"
	/// button label for capitalized words for Log In
	/// English String: "Log In"
	/// </summary>
	public override string ActionLogInCapitalized => "ãƒ­ã‚°ã‚¤ãƒ³";

	/// <summary>
	/// Key: "Action.ReturnHome"
	/// button label to return the user to home page
	/// English String: "Return Home"
	/// </summary>
	public override string ActionReturnHome => "ãƒ›ãƒ¼ãƒ ç”»é¢ã«æˆ»ã‚‹";

	/// <summary>
	/// Key: "Action.SignUp"
	/// English String: "Sign up"
	/// </summary>
	public override string ActionSignUp => "æ–°è¦ç™»éŒ²";

	public override string ActionSignupAndSync => "æ–°è¦ç™»éŒ²ãŠã‚ˆã³ åŒæœŸåŒ–";

	/// <summary>
	/// Key: "Action.Submit"
	/// English String: "Submit"
	/// </summary>
	public override string ActionSubmit => "é€ä¿¡";

	/// <summary>
	/// Key: "Description.AccountLinkingWarning"
	/// instructions for linking account on signup page for FB based account
	/// English String: "To link to an existing Roblox account, sign in and link them on the account settings page."
	/// </summary>
	public override string DescriptionAccountLinkingWarning => "æ—¢å­˜ã®Robloxã‚¢ã‚«ã‚¦ãƒ³ãƒˆã«ãƒªãƒ³ã‚¯ã™ã‚‹ã«ã¯ã€ãƒ­ã‚°ã‚¤ãƒ³ã—ã¦ã‚¢ã‚«ã‚¦ãƒ³ãƒˆã®è¨­å®šãƒšãƒ¼ã‚¸ã‹ã‚‰é–¢é€£ä»˜ã‘ã¦ãã ã•ã„ã€‚";

	/// <summary>
	/// Key: "Description.NoRealName"
	/// description
	/// English String: "Do not use your real name."
	/// </summary>
	public override string DescriptionNoRealName => "æœ¬åã‚’ä½¿ã‚ãªã„ã§ãã ã•ã„ã€‚";

	/// <summary>
	/// Key: "Description.PrivacyPolicy"
	/// English String: "Privacy Policy"
	/// </summary>
	public override string DescriptionPrivacyPolicy => "ãƒ—ãƒ©ã‚¤ãƒã‚·ãƒ¼ãƒãƒªã‚·ãƒ¼";

	/// <summary>
	/// Key: "Description.TermsOfService"
	/// English String: "Terms of Service"
	/// </summary>
	public override string DescriptionTermsOfService => "åˆ©ç”¨è¦ç´„";

	/// <summary>
	/// Key: "GuestSignUpAB.Action.SignUp"
	/// English String: "Sign Up"
	/// </summary>
	public override string GuestSignUpABActionSignUp => "æ–°è¦ç™»éŒ²";

	/// <summary>
	/// Key: "Heading.ConnectFacebook"
	/// section heading
	/// English String: "Connect to Facebook"
	/// </summary>
	public override string HeadingConnectFacebook => "Facebookã«æŽ¥ç¶šã™ã‚‹";

	/// <summary>
	/// Key: "Heading.CreateAnAccount"
	/// should be capitalized if the language supports capitalization
	/// English String: "CREATE AN ACCOUNT"
	/// </summary>
	public override string HeadingCreateAnAccount => "ã‚¢ã‚«ã‚¦ãƒ³ãƒˆã‚’ä½œæˆã™ã‚‹";

	/// <summary>
	/// Key: "Heading.LoginHaveFun"
	/// heading for login container
	/// English String: "Log in and start having fun!"
	/// </summary>
	public override string HeadingLoginHaveFun => "ãƒ­ã‚°ã‚¤ãƒ³ã—ã¦æ¥½ã—ã¿ã¾ã—ã‚‡ã†ï¼";

	/// <summary>
	/// Key: "Heading.SignupHaveFun"
	/// signup form heading
	/// English String: "Sign up and start having fun!"
	/// </summary>
	public override string HeadingSignupHaveFun => "æ–°è¦ç™»éŒ²ã—ã¦æ¥½ã—ã¿ã¾ã—ã‚‡ã†ï¼";

	/// <summary>
	/// Key: "Label.About"
	/// About link on roller coaster page
	/// English String: "About"
	/// </summary>
	public override string LabelAbout => "æƒ…å ±";

	/// <summary>
	/// Key: "Label.AlreadyHaveRobloxAccount"
	/// English String: "Already have a Roblox account?"
	/// </summary>
	public override string LabelAlreadyHaveRobloxAccount => "ã™ã§ã«Robloxã‚¢ã‚«ã‚¦ãƒ³ãƒˆã‚’ãŠæŒã¡ã§ã™ã‹ï¼Ÿ";

	/// <summary>
	/// Key: "Label.AlreadyRegistered"
	/// label
	/// English String: "Already registered?"
	/// </summary>
	public override string LabelAlreadyRegistered => "ã™ã§ã«ç™»éŒ²æ¸ˆã¿ã§ã™ã‹ï¼Ÿ";

	/// <summary>
	/// Key: "Label.Birthday"
	/// English String: "Birthday"
	/// </summary>
	public override string LabelBirthday => "ç”Ÿå¹´æœˆæ—¥";

	/// <summary>
	/// Key: "Label.BirthdayWithColumn"
	/// should have column if the language supports it
	/// English String: "Birthday:"
	/// </summary>
	public override string LabelBirthdayWithColumn => "ç”Ÿå¹´æœˆæ—¥:";

	/// <summary>
	/// Key: "Label.ConfirmPassword"
	/// English String: "Confirm password"
	/// </summary>
	public override string LabelConfirmPassword => "ãƒ‘ã‚¹ãƒ¯ãƒ¼ãƒ‰å†ç¢ºèª";

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
	public override string LabelDesiredUsername => "æœ›ã¾ã—ã„ãƒ¦ãƒ¼ã‚¶ãƒ¼å:";

	/// <summary>
	/// Key: "Label.FacebookNotLinked"
	/// English String: "Your Facebook account is not linked to any Roblox account. Please sign up for a Roblox account."
	/// </summary>
	public override string LabelFacebookNotLinked => "ã“ã®Facebookã‚¢ã‚«ã‚¦ãƒ³ãƒˆã¯ã©ã®Robloxã‚¢ã‚«ã‚¦ãƒ³ãƒˆã«ã‚‚ãƒªãƒ³ã‚¯ã•ã‚Œã¦ã„ã¾ã›ã‚“ã€‚Robloxã‚¢ã‚«ã‚¦ãƒ³ãƒˆã‚’æ–°è¦ç™»éŒ²ã—ã¦ãã ã•ã„ã€‚";

	/// <summary>
	/// Key: "Label.FacebookSignupUsername"
	/// username field label for FB signup
	/// English String: "Create Roblox username:"
	/// </summary>
	public override string LabelFacebookSignupUsername => "Robloxã®ãƒ¦ãƒ¼ã‚¶ãƒ¼ãƒãƒ¼ãƒ ã‚’ä½œæˆï¼š";

	/// <summary>
	/// Key: "Label.Female"
	/// label
	/// English String: "Female"
	/// </summary>
	public override string LabelFemale => "å¥³æ€§";

	/// <summary>
	/// Key: "Label.Gender"
	/// English String: "Gender"
	/// </summary>
	public override string LabelGender => "æ€§åˆ¥";

	/// <summary>
	/// Key: "Label.GenderRequired"
	/// English String: "Gender is required."
	/// </summary>
	public override string LabelGenderRequired => "æ€§åˆ¥ã¯å¿…é ˆã§ã™ã€‚";

	/// <summary>
	/// Key: "Label.GenderWithColumn"
	/// should have column if the language supports it
	/// English String: "Gender:"
	/// </summary>
	public override string LabelGenderWithColumn => "æ€§åˆ¥:";

	/// <summary>
	/// Key: "Label.Male"
	/// label
	/// English String: "Male"
	/// </summary>
	public override string LabelMale => "ç”·æ€§";

	/// <summary>
	/// Key: "Label.Month"
	/// English String: "Month"
	/// </summary>
	public override string LabelMonth => "æœˆ";

	/// <summary>
	/// Key: "Label.Password"
	/// English String: "Password"
	/// </summary>
	public override string LabelPassword => "ãƒ‘ã‚¹ãƒ¯ãƒ¼ãƒ‰";

	/// <summary>
	/// Key: "Label.PasswordRequirements"
	/// English String: "Password (min length 8)"
	/// </summary>
	public override string LabelPasswordRequirements => "ãƒ‘ã‚¹ãƒ¯ãƒ¼ãƒ‰ï¼ˆ8æ–‡å­—ä»¥ä¸Šï¼‰";

	/// <summary>
	/// Key: "Label.Platforms"
	/// platforms link on roller coaster page
	/// English String: "Platforms"
	/// </summary>
	public override string LabelPlatforms => "ãƒ—ãƒ©ãƒƒãƒˆãƒ•ã‚©ãƒ¼ãƒ ";

	/// <summary>
	/// Key: "Label.Play"
	/// Play link on roller coaster page
	/// English String: "Play"
	/// </summary>
	public override string LabelPlay => "ãƒ—ãƒ¬ã‚¤";

	/// <summary>
	/// Key: "Label.PleaseAgreeToTerms"
	/// English String: "Please agree to our Terms of Use and Privacy Policy."
	/// </summary>
	public override string LabelPleaseAgreeToTerms => "åˆ©ç”¨è¦ç´„ã¨ãƒ—ãƒ©ã‚¤ãƒã‚·ãƒ¼ãƒãƒªã‚·ãƒ¼ã¸ã®åŒæ„ãŒå¿…è¦ã§ã™ã€‚";

	/// <summary>
	/// Key: "Label.Required"
	/// Required
	/// English String: "Required"
	/// </summary>
	public override string LabelRequired => "å¿…é ˆ";

	/// <summary>
	/// Key: "Label.SignupButtonText"
	/// sign up button text
	/// English String: "Sign Up and Play!"
	/// </summary>
	public override string LabelSignupButtonText => "æ–°è¦ç™»éŒ²ã—ã¦ãƒ—ãƒ¬ã‚¤ã™ã‚‹";

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
	public override string LabelSignUpWith => "ã¾ãŸã¯ã“ã¡ã‚‰ã§æ–°è¦ç™»éŒ²";

	/// <summary>
	/// Key: "Label.TermsOfUse"
	/// terms of use link label
	/// English String: "Terms of Use"
	/// </summary>
	public override string LabelTermsOfUse => "åˆ©ç”¨è¦ç´„";

	/// <summary>
	/// Key: "Label.Username"
	/// English String: "Username"
	/// </summary>
	public override string LabelUsername => "ãƒ¦ãƒ¼ã‚¶ãƒ¼ãƒãƒ¼ãƒ ";

	/// <summary>
	/// Key: "Label.UsernameCharacterLimit"
	/// label
	/// English String: "3-20 alphanumeric characters, no spaces."
	/// </summary>
	public override string LabelUsernameCharacterLimit => "3ã€œ20ã®è‹±æ•°å­—ã€ã‚¹ãƒšãƒ¼ã‚¹ã¯ä¸å¯";

	/// <summary>
	/// Key: "Label.UsernameHint"
	/// placeholder for username field
	/// English String: "Username (don't use your real name)"
	/// </summary>
	public override string LabelUsernameHint => "ãƒ¦ãƒ¼ã‚¶ãƒ¼ãƒãƒ¼ãƒ ï¼ˆæœ¬åã‚’ä½¿ç”¨ã—ãªã„ã§ãã ã•ã„ï¼‰";

	/// <summary>
	/// Key: "Label.UsernameRequirements"
	/// English String: "Username (length 3-20, _ is allowed)"
	/// </summary>
	public override string LabelUsernameRequirements => "ãƒ¦ãƒ¼ã‚¶ãƒ¼ãƒãƒ¼ãƒ ï¼ˆé•·ã•ã¯3ï½ž20æ–‡å­—ã€ä¸‹ç·š _ ã¯ä½¿ç”¨å¯èƒ½ï¼‰";

	/// <summary>
	/// Key: "Label.Year"
	/// English String: "Year"
	/// </summary>
	public override string LabelYear => "å¹´";

	/// <summary>
	/// Key: "Message.Password.MinLength"
	/// English String: "Min length 8"
	/// </summary>
	public override string MessagePasswordMinLength => "æœ€ä½Ž8æ–‡å­—";

	/// <summary>
	/// Key: "Message.Username.NoRealNameUse"
	/// English String: "Don't use your real name"
	/// </summary>
	public override string MessageUsernameNoRealNameUse => "æœ¬åã‚’ä½¿ç”¨ã—ãªã„ã§ãã ã•ã„";

	/// <summary>
	/// Key: "Response.BadUsername"
	/// English String: "Username not appropriate for Roblox."
	/// </summary>
	public override string ResponseBadUsername => "ãƒ¦ãƒ¼ã‚¶ãƒ¼ãƒãƒ¼ãƒ ãŒRobloxã«ã¯é©åˆ‡ã§ã¯ã‚ã‚Šã¾ã›ã‚“ã€‚";

	/// <summary>
	/// Key: "Response.BadUsernameForWeChat"
	/// message shown when signing up with an inappropriate username
	/// English String: "Username is not appropriate"
	/// </summary>
	public override string ResponseBadUsernameForWeChat => "ãƒ¦ãƒ¼ã‚¶ãƒ¼ãƒãƒ¼ãƒ ãŒé©åˆ‡ã§ã¯ã‚ã‚Šã¾ã›ã‚“";

	/// <summary>
	/// Key: "Response.BirthdayInvalid"
	/// English String: "This birthday is invalid."
	/// </summary>
	public override string ResponseBirthdayInvalid => "ç”Ÿå¹´æœˆæ—¥ãŒç„¡åŠ¹ã§ã™ã€‚";

	/// <summary>
	/// Key: "Response.BirthdayMustBeSetFirst"
	/// English String: "Birthday must be set first."
	/// </summary>
	public override string ResponseBirthdayMustBeSetFirst => "æœ€åˆã«èª•ç”Ÿæ—¥ã‚’è¨­å®šã™ã‚‹å¿…è¦ãŒã‚ã‚Šã¾ã™ã€‚";

	/// <summary>
	/// Key: "Response.CaptchaMismatchError"
	/// error message
	/// English String: "Words do not match."
	/// </summary>
	public override string ResponseCaptchaMismatchError => "è¨€è‘‰ãŒä¸€è‡´ã—ã¾ã›ã‚“ã€‚";

	/// <summary>
	/// Key: "Response.CaptchaNotEnteredError"
	/// validation error message
	/// English String: "Please fill out the Captcha"
	/// </summary>
	public override string ResponseCaptchaNotEnteredError => "ã‚­ãƒ£ãƒ—ãƒãƒ£èªè¨¼ã‚’å…¥åŠ›ã—ã¦ãã ã•ã„";

	/// <summary>
	/// Key: "Response.FacebookConnectionError"
	/// error message
	/// English String: "Error while retrieving values from Facebook."
	/// </summary>
	public override string ResponseFacebookConnectionError => "Facebookã‹ã‚‰ã®æƒ…å ±ã®å–å¾—ä¸­ã«ã‚¨ãƒ©ãƒ¼ãŒç™ºç”Ÿã—ã¾ã—ãŸã€‚";

	/// <summary>
	/// Key: "Response.FacebookLoginAge"
	/// English String: "Facebook login can only be used by users above 13."
	/// </summary>
	public override string ResponseFacebookLoginAge => "Facebookãƒ­ã‚°ã‚¤ãƒ³ã¯13æ­³ä»¥ä¸Šã®ãƒ¦ãƒ¼ã‚¶ãƒ¼ã®ã¿ä½¿ç”¨ã§ãã¾ã™ã€‚";

	/// <summary>
	/// Key: "Response.InvalidBirthday"
	/// English String: "Invalid birthday."
	/// </summary>
	public override string ResponseInvalidBirthday => "ç”Ÿå¹´æœˆæ—¥ãŒç„¡åŠ¹ã§ã™ã€‚";

	/// <summary>
	/// Key: "Response.InvalidEmail"
	/// English String: "Invalid email address."
	/// </summary>
	public override string ResponseInvalidEmail => "ãƒ¡ãƒ¼ãƒ«ã‚¢ãƒ‰ãƒ¬ã‚¹ãŒç„¡åŠ¹ã§ã™ã€‚";

	/// <summary>
	/// Key: "Response.JavaScriptRequired"
	/// error to show that JavaScipt is required for the form to work
	/// English String: "JavaScript is required to submit this form."
	/// </summary>
	public override string ResponseJavaScriptRequired => "ãƒ•ã‚©ãƒ¼ãƒ ã‚’é€ä¿¡ã™ã‚‹ã«ã¯JavaScriptãŒå¿…è¦ã§ã™ã€‚";

	/// <summary>
	/// Key: "Response.PasswordComplexity"
	/// English String: "Please create a more complex password."
	/// </summary>
	public override string ResponsePasswordComplexity => "ã‚‚ã£ã¨è¤‡é›‘ãªãƒ‘ã‚¹ãƒ¯ãƒ¼ãƒ‰ã‚’ä½œæˆã—ã¦ãã ã•ã„ã€‚";

	/// <summary>
	/// Key: "Response.PasswordConfirmation"
	/// validation message for password confirmation
	/// English String: "Please enter a password confirmation."
	/// </summary>
	public override string ResponsePasswordConfirmation => "ç¢ºèªãƒ‘ã‚¹ãƒ¯ãƒ¼ãƒ‰ã‚’å…¥åŠ›ã—ã¦ãã ã•ã„ã€‚";

	/// <summary>
	/// Key: "Response.PasswordContainsUsernameError"
	/// error when passsword has username in it
	/// English String: "Password shouldn't match username."
	/// </summary>
	public override string ResponsePasswordContainsUsernameError => "ãƒ‘ã‚¹ãƒ¯ãƒ¼ãƒ‰ã‚’ãƒ¦ãƒ¼ã‚¶ãƒ¼ãƒãƒ¼ãƒ ã¨åŒã˜ã«ã™ã‚‹ã“ã¨ã¯ã§ãã¾ã›ã‚“ã€‚";

	/// <summary>
	/// Key: "Response.PasswordMismatch"
	/// English String: "Passwords do not match."
	/// </summary>
	public override string ResponsePasswordMismatch => "ãƒ‘ã‚¹ãƒ¯ãƒ¼ãƒ‰ãŒä¸€è‡´ã—ã¾ã›ã‚“ã€‚";

	/// <summary>
	/// Key: "Response.PasswordWrongShort"
	/// English String: "Passwords must be at least 8 characters long."
	/// </summary>
	public override string ResponsePasswordWrongShort => "ãƒ‘ã‚¹ãƒ¯ãƒ¼ãƒ‰ã¯8æ–‡å­—ä»¥ä¸Šã§ãªã‘ã‚Œã°ãªã‚Šã¾ã›ã‚“ã€‚";

	/// <summary>
	/// Key: "Response.PleaseEnterPassword"
	/// English String: "Please enter a password."
	/// </summary>
	public override string ResponsePleaseEnterPassword => "ãƒ‘ã‚¹ãƒ¯ãƒ¼ãƒ‰ã‚’å…¥åŠ›ã—ã¦ä¸‹ã•ã„ã€‚";

	/// <summary>
	/// Key: "Response.PleaseEnterUsername"
	/// English String: "Please enter a username."
	/// </summary>
	public override string ResponsePleaseEnterUsername => "ãƒ¦ãƒ¼ã‚¶ãƒ¼ãƒãƒ¼ãƒ ã‚’å…¥åŠ›ã—ã¦ä¸‹ã•ã„ã€‚";

	/// <summary>
	/// Key: "Response.SocialAccountCreationFailed"
	/// error message
	/// English String: "Account creation failed"
	/// </summary>
	public override string ResponseSocialAccountCreationFailed => "ã‚¢ã‚«ã‚¦ãƒ³ãƒˆã®ä½œæˆã«å¤±æ•—ã—ã¾ã—ãŸ";

	/// <summary>
	/// Key: "Response.SpaceOrSpecialCharaterError"
	/// Spaces and special characters are not allowed error message
	/// English String: "Spaces and special characters are not allowed."
	/// </summary>
	public override string ResponseSpaceOrSpecialCharaterError => "ã‚¹ãƒšãƒ¼ã‚¹ã‚„ç‰¹æ®Šæ–‡å­—ã¯ä½¿ç”¨ã§ãã¾ã›ã‚“ã€‚";

	/// <summary>
	/// Key: "Response.TooManyAccountsWithSameEmailError"
	/// Too many accounts use this email error message
	/// English String: "Too many accounts use this email."
	/// </summary>
	public override string ResponseTooManyAccountsWithSameEmailError => "ã“ã®ãƒ¡ãƒ¼ãƒ«ã‚¢ãƒ‰ãƒ¬ã‚¹ã¯ã™ã§ã«å¤šãã®ã‚¢ã‚«ã‚¦ãƒ³ãƒˆã§ä½¿ç”¨ã•ã‚Œã¦ã„ã¾ã™ã€‚";

	/// <summary>
	/// Key: "Response.UnknownError"
	/// English String: "Sorry! An unknown error occurred. Please try again later."
	/// </summary>
	public override string ResponseUnknownError => "ã”ã‚ã‚“ãªã•ã„ï¼ä¸æ˜Žãªã‚¨ãƒ©ãƒ¼ãŒç™ºç”Ÿã—ã¾ã—ãŸã€‚å¾Œã§ã‚‚ã†ä¸€åº¦ãŠè©¦ã—ãã ã•ã„ã€‚";

	/// <summary>
	/// Key: "Response.UsernameAllowedCharactersError"
	/// error showing which characters are allowed for username
	/// English String: "Usernames may only contain letters, numbers, and _."
	/// </summary>
	public override string ResponseUsernameAllowedCharactersError => "ãƒ¦ãƒ¼ã‚¶ãƒ¼ãƒãƒ¼ãƒ ã«ä½¿ç”¨ã§ãã‚‹ã®ã¯ã€æ–‡å­—ã€æ•°å­—ã€ ãŠã‚ˆã³ä¸‹ç·š ï¼ˆ _ ï¼‰ã ã‘ã§ã™ã€‚";

	/// <summary>
	/// Key: "Response.UsernameAlreadyInUse"
	/// English String: "This username is already in use."
	/// </summary>
	public override string ResponseUsernameAlreadyInUse => "ã“ã®ãƒ¦ãƒ¼ã‚¶ãƒ¼ãƒãƒ¼ãƒ ã¯ã™ã§ã«ä½¿ã‚ã‚Œã¦ã„ã¾ã™ã€‚";

	/// <summary>
	/// Key: "Response.UsernameExplicit"
	/// English String: "This username is not allowed, please try another."
	/// </summary>
	public override string ResponseUsernameExplicit => "ã“ã®ãƒ¦ãƒ¼ã‚¶ãƒ¼ãƒãƒ¼ãƒ ã¯ä½¿ç”¨ã§ãã¾ã›ã‚“ã€‚";

	/// <summary>
	/// Key: "Response.UsernameInvalid"
	/// English String: "Please enter a valid username."
	/// </summary>
	public override string ResponseUsernameInvalid => "æœ‰åŠ¹ãªãƒ¦ãƒ¼ã‚¶ãƒ¼ãƒãƒ¼ãƒ ã‚’å…¥åŠ›ã—ã¦ä¸‹ã•ã„ã€‚";

	/// <summary>
	/// Key: "Response.UsernameInvalidCharacters"
	/// English String: "Only a-z, A-Z, 0-9 and _ are allowed."
	/// </summary>
	public override string ResponseUsernameInvalidCharacters => "a-zã€A-Zã€0-9ã€ãŠã‚ˆã³ä¸‹ç·šï¼ˆ _ ï¼‰ã®ã¿ã‚’ä½¿ç”¨ã§ãã¾ã™ã€‚";

	/// <summary>
	/// Key: "Response.UsernameInvalidLength"
	/// English String: "Usernames can be 3 to 20 characters long."
	/// </summary>
	public override string ResponseUsernameInvalidLength => "ãƒ¦ãƒ¼ã‚¶ãƒ¼ãƒãƒ¼ãƒ ã¯3ã€œ20æ–‡å­—ä»¥å†…ã«ã™ã‚‹å¿…è¦ãŒã‚ã‚Šã¾ã™ã€‚";

	/// <summary>
	/// Key: "Response.UsernameInvalidUnderscore"
	/// English String: "Usernames cannot start or end with _."
	/// </summary>
	public override string ResponseUsernameInvalidUnderscore => "ãƒ¦ãƒ¼ã‚¶ãƒ¼ãƒãƒ¼ãƒ ã®æœ€åˆã¨æœ€å¾Œã«ä¸‹ç·šï¼ˆ _ ï¼‰ã¯ä½¿ç”¨ä¸å¯ã€‚";

	/// <summary>
	/// Key: "Response.UsernameNotAvailable"
	/// English String: "Username not available. Please try again."
	/// </summary>
	public override string ResponseUsernameNotAvailable => "ãƒ¦ãƒ¼ã‚¶ãƒ¼ãƒãƒ¼ãƒ ãŒåˆ©ç”¨ã§ãã¾ã›ã‚“ã€‚ã‚„ã‚Šç›´ã—ã¦ãã ã•ã„ã€‚";

	/// <summary>
	/// Key: "Response.UsernameOrPasswordIncorrect"
	/// Your username or password is incorrect
	/// English String: "Your username or password is incorrect."
	/// </summary>
	public override string ResponseUsernameOrPasswordIncorrect => "ãƒ¦ãƒ¼ã‚¶ãƒ¼ãƒãƒ¼ãƒ ã€ã¾ãŸã¯ãƒ‘ã‚¹ãƒ¯ãƒ¼ãƒ‰ãŒé–“é•ã£ã¦ã„ã¾ã™ã€‚";

	/// <summary>
	/// Key: "Response.UsernamePasswordRequired"
	/// Username and Password are required error message
	/// English String: "Username and Password are required."
	/// </summary>
	public override string ResponseUsernamePasswordRequired => "ãƒ¦ãƒ¼ã‚¶ãƒ¼åã¨ãƒ‘ã‚¹ãƒ¯ãƒ¼ãƒ‰ãŒå¿…è¦ã§ã™ã€‚";

	/// <summary>
	/// Key: "Response.UsernamePrivateInfo"
	/// English String: "Username might contain private information."
	/// </summary>
	public override string ResponseUsernamePrivateInfo => "ãƒ¦ãƒ¼ã‚¶ãƒ¼ãƒãƒ¼ãƒ ã«å€‹äººæƒ…å ±ãŒå«ã¾ã‚Œã¦ã„ã¾ã™ã€‚";

	/// <summary>
	/// Key: "Response.UsernameRequired"
	/// validation error message
	/// English String: "Username is required."
	/// </summary>
	public override string ResponseUsernameRequired => "ãƒ¦ãƒ¼ã‚¶ãƒ¼ãƒãƒ¼ãƒ ãŒå¿…è¦ã§ã™ã€‚";

	/// <summary>
	/// Key: "Response.UsernameTakenTryAgain"
	/// English String: "This username is already taken! Please try a different one."
	/// </summary>
	public override string ResponseUsernameTakenTryAgain => "ãã®ãƒ¦ãƒ¼ã‚¶ãƒ¼ãƒãƒ¼ãƒ ã¯ã™ã§ã«ä½¿ã‚ã‚Œã¦ã„ã¾ã™ï¼åˆ¥ã®åå‰ã‚’ãŠè©¦ã—ãã ã•ã„ã€‚";

	/// <summary>
	/// Key: "Response.UsernameTooManyUnderscores"
	/// English String: "Usernames can have at most one _."
	/// </summary>
	public override string ResponseUsernameTooManyUnderscores => "ãƒ¦ãƒ¼ã‚¶ãƒ¼ãƒãƒ¼ãƒ ã«ã¯ä¸‹ç·šï¼ˆ _ ï¼‰ã‚’2ã¤ä»¥ä¸Šä½¿ç”¨ã§ãã¾ã›ã‚“ã€‚";

	public SignUpResources_ja_jp(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionCreateAccount()
	{
		return "ã‚¢ã‚«ã‚¦ãƒ³ãƒˆã‚’ä½œæˆ";
	}

	protected override string _GetTemplateForActionLinkAccount()
	{
		return "ã‚¢ã‚«ã‚¦ãƒ³ãƒˆã‚’ãƒªãƒ³ã‚¯ã™ã‚‹";
	}

	protected override string _GetTemplateForActionLogInCapitalized()
	{
		return "ãƒ­ã‚°ã‚¤ãƒ³";
	}

	protected override string _GetTemplateForActionReturnHome()
	{
		return "ãƒ›ãƒ¼ãƒ ç”»é¢ã«æˆ»ã‚‹";
	}

	protected override string _GetTemplateForActionSignUp()
	{
		return "æ–°è¦ç™»éŒ²";
	}

	protected override string _GetTemplateForActionSignupAndSync()
	{
		return "æ–°è¦ç™»éŒ²ãŠã‚ˆã³ åŒæœŸåŒ–";
	}

	protected override string _GetTemplateForActionSubmit()
	{
		return "é€ä¿¡";
	}

	protected override string _GetTemplateForDescriptionAccountLinkingWarning()
	{
		return "æ—¢å­˜ã®Robloxã‚¢ã‚«ã‚¦ãƒ³ãƒˆã«ãƒªãƒ³ã‚¯ã™ã‚‹ã«ã¯ã€ãƒ­ã‚°ã‚¤ãƒ³ã—ã¦ã‚¢ã‚«ã‚¦ãƒ³ãƒˆã®è¨­å®šãƒšãƒ¼ã‚¸ã‹ã‚‰é–¢é€£ä»˜ã‘ã¦ãã ã•ã„ã€‚";
	}

	protected override string _GetTemplateForDescriptionNoRealName()
	{
		return "æœ¬åã‚’ä½¿ã‚ãªã„ã§ãã ã•ã„ã€‚";
	}

	protected override string _GetTemplateForDescriptionPrivacyPolicy()
	{
		return "ãƒ—ãƒ©ã‚¤ãƒã‚·ãƒ¼ãƒãƒªã‚·ãƒ¼";
	}

	/// <summary>
	/// Key: "Description.SignUpAgreement"
	/// terms of use agreement checkbox label to signup.
	/// English String: "By clicking {spanStart}Sign Up{spanEnd}, you are agreeing to the {termsOfUseLink} and acknowledging the {privacyPolicyLink}"
	/// </summary>
	public override string DescriptionSignUpAgreement(string spanStart, string spanEnd, string termsOfUseLink, string privacyPolicyLink)
	{
		return $"{spanStart}æ–°è¦ç™»éŒ²{spanEnd}ã‚’ã‚¯ãƒªãƒƒã‚¯ã™ã‚‹ã¨ã€{termsOfUseLink}ã«åŒæ„ã—ã€{privacyPolicyLink}ã‚’æ‰¿èªã—ãŸã“ã¨ã«ãªã‚Šã¾ã™";
	}

	protected override string _GetTemplateForDescriptionSignUpAgreement()
	{
		return "{spanStart}æ–°è¦ç™»éŒ²{spanEnd}ã‚’ã‚¯ãƒªãƒƒã‚¯ã™ã‚‹ã¨ã€{termsOfUseLink}ã«åŒæ„ã—ã€{privacyPolicyLink}ã‚’æ‰¿èªã—ãŸã“ã¨ã«ãªã‚Šã¾ã™";
	}

	protected override string _GetTemplateForDescriptionTermsOfService()
	{
		return "åˆ©ç”¨è¦ç´„";
	}

	protected override string _GetTemplateForGuestSignUpABActionSignUp()
	{
		return "æ–°è¦ç™»éŒ²";
	}

	protected override string _GetTemplateForHeadingConnectFacebook()
	{
		return "Facebookã«æŽ¥ç¶šã™ã‚‹";
	}

	protected override string _GetTemplateForHeadingCreateAnAccount()
	{
		return "ã‚¢ã‚«ã‚¦ãƒ³ãƒˆã‚’ä½œæˆã™ã‚‹";
	}

	/// <summary>
	/// Key: "Heading.FacebookSignupAlmostDone"
	/// when user signs up using Facebook, this is shown in next step to create a password.
	/// English String: "{firstname}, YOU'RE ALMOST DONE"
	/// </summary>
	public override string HeadingFacebookSignupAlmostDone(string firstname)
	{
		return $"{firstname}æ§˜ã€ã‚‚ã†ã™ãå®Œäº†ã§ã™";
	}

	protected override string _GetTemplateForHeadingFacebookSignupAlmostDone()
	{
		return "{firstname}æ§˜ã€ã‚‚ã†ã™ãå®Œäº†ã§ã™";
	}

	protected override string _GetTemplateForHeadingLoginHaveFun()
	{
		return "ãƒ­ã‚°ã‚¤ãƒ³ã—ã¦æ¥½ã—ã¿ã¾ã—ã‚‡ã†ï¼";
	}

	protected override string _GetTemplateForHeadingSignupHaveFun()
	{
		return "æ–°è¦ç™»éŒ²ã—ã¦æ¥½ã—ã¿ã¾ã—ã‚‡ã†ï¼";
	}

	protected override string _GetTemplateForLabelAbout()
	{
		return "æƒ…å ±";
	}

	protected override string _GetTemplateForLabelAlreadyHaveRobloxAccount()
	{
		return "ã™ã§ã«Robloxã‚¢ã‚«ã‚¦ãƒ³ãƒˆã‚’ãŠæŒã¡ã§ã™ã‹ï¼Ÿ";
	}

	protected override string _GetTemplateForLabelAlreadyRegistered()
	{
		return "ã™ã§ã«ç™»éŒ²æ¸ˆã¿ã§ã™ã‹ï¼Ÿ";
	}

	protected override string _GetTemplateForLabelBirthday()
	{
		return "ç”Ÿå¹´æœˆæ—¥";
	}

	protected override string _GetTemplateForLabelBirthdayWithColumn()
	{
		return "ç”Ÿå¹´æœˆæ—¥:";
	}

	protected override string _GetTemplateForLabelConfirmPassword()
	{
		return "ãƒ‘ã‚¹ãƒ¯ãƒ¼ãƒ‰å†ç¢ºèª";
	}

	protected override string _GetTemplateForLabelDay()
	{
		return "æ—¥";
	}

	protected override string _GetTemplateForLabelDesiredUsername()
	{
		return "æœ›ã¾ã—ã„ãƒ¦ãƒ¼ã‚¶ãƒ¼å:";
	}

	protected override string _GetTemplateForLabelFacebookNotLinked()
	{
		return "ã“ã®Facebookã‚¢ã‚«ã‚¦ãƒ³ãƒˆã¯ã©ã®Robloxã‚¢ã‚«ã‚¦ãƒ³ãƒˆã«ã‚‚ãƒªãƒ³ã‚¯ã•ã‚Œã¦ã„ã¾ã›ã‚“ã€‚Robloxã‚¢ã‚«ã‚¦ãƒ³ãƒˆã‚’æ–°è¦ç™»éŒ²ã—ã¦ãã ã•ã„ã€‚";
	}

	protected override string _GetTemplateForLabelFacebookSignupUsername()
	{
		return "Robloxã®ãƒ¦ãƒ¼ã‚¶ãƒ¼ãƒãƒ¼ãƒ ã‚’ä½œæˆï¼š";
	}

	protected override string _GetTemplateForLabelFemale()
	{
		return "å¥³æ€§";
	}

	protected override string _GetTemplateForLabelGender()
	{
		return "æ€§åˆ¥";
	}

	protected override string _GetTemplateForLabelGenderRequired()
	{
		return "æ€§åˆ¥ã¯å¿…é ˆã§ã™ã€‚";
	}

	protected override string _GetTemplateForLabelGenderWithColumn()
	{
		return "æ€§åˆ¥:";
	}

	protected override string _GetTemplateForLabelMale()
	{
		return "ç”·æ€§";
	}

	protected override string _GetTemplateForLabelMonth()
	{
		return "æœˆ";
	}

	protected override string _GetTemplateForLabelPassword()
	{
		return "ãƒ‘ã‚¹ãƒ¯ãƒ¼ãƒ‰";
	}

	protected override string _GetTemplateForLabelPasswordRequirements()
	{
		return "ãƒ‘ã‚¹ãƒ¯ãƒ¼ãƒ‰ï¼ˆ8æ–‡å­—ä»¥ä¸Šï¼‰";
	}

	protected override string _GetTemplateForLabelPlatforms()
	{
		return "ãƒ—ãƒ©ãƒƒãƒˆãƒ•ã‚©ãƒ¼ãƒ ";
	}

	protected override string _GetTemplateForLabelPlay()
	{
		return "ãƒ—ãƒ¬ã‚¤";
	}

	protected override string _GetTemplateForLabelPleaseAgreeToTerms()
	{
		return "åˆ©ç”¨è¦ç´„ã¨ãƒ—ãƒ©ã‚¤ãƒã‚·ãƒ¼ãƒãƒªã‚·ãƒ¼ã¸ã®åŒæ„ãŒå¿…è¦ã§ã™ã€‚";
	}

	protected override string _GetTemplateForLabelRequired()
	{
		return "å¿…é ˆ";
	}

	protected override string _GetTemplateForLabelSignupButtonText()
	{
		return "æ–°è¦ç™»éŒ²ã—ã¦ãƒ—ãƒ¬ã‚¤ã™ã‚‹";
	}

	protected override string _GetTemplateForLabelSignUpWith()
	{
		return "ã¾ãŸã¯ã“ã¡ã‚‰ã§æ–°è¦ç™»éŒ²";
	}

	protected override string _GetTemplateForLabelTermsOfUse()
	{
		return "åˆ©ç”¨è¦ç´„";
	}

	protected override string _GetTemplateForLabelUsername()
	{
		return "ãƒ¦ãƒ¼ã‚¶ãƒ¼ãƒãƒ¼ãƒ ";
	}

	protected override string _GetTemplateForLabelUsernameCharacterLimit()
	{
		return "3ã€œ20ã®è‹±æ•°å­—ã€ã‚¹ãƒšãƒ¼ã‚¹ã¯ä¸å¯";
	}

	protected override string _GetTemplateForLabelUsernameHint()
	{
		return "ãƒ¦ãƒ¼ã‚¶ãƒ¼ãƒãƒ¼ãƒ ï¼ˆæœ¬åã‚’ä½¿ç”¨ã—ãªã„ã§ãã ã•ã„ï¼‰";
	}

	protected override string _GetTemplateForLabelUsernameRequirements()
	{
		return "ãƒ¦ãƒ¼ã‚¶ãƒ¼ãƒãƒ¼ãƒ ï¼ˆé•·ã•ã¯3ï½ž20æ–‡å­—ã€ä¸‹ç·š _ ã¯ä½¿ç”¨å¯èƒ½ï¼‰";
	}

	protected override string _GetTemplateForLabelYear()
	{
		return "å¹´";
	}

	protected override string _GetTemplateForMessagePasswordMinLength()
	{
		return "æœ€ä½Ž8æ–‡å­—";
	}

	protected override string _GetTemplateForMessageUsernameNoRealNameUse()
	{
		return "æœ¬åã‚’ä½¿ç”¨ã—ãªã„ã§ãã ã•ã„";
	}

	protected override string _GetTemplateForResponseBadUsername()
	{
		return "ãƒ¦ãƒ¼ã‚¶ãƒ¼ãƒãƒ¼ãƒ ãŒRobloxã«ã¯é©åˆ‡ã§ã¯ã‚ã‚Šã¾ã›ã‚“ã€‚";
	}

	protected override string _GetTemplateForResponseBadUsernameForWeChat()
	{
		return "ãƒ¦ãƒ¼ã‚¶ãƒ¼ãƒãƒ¼ãƒ ãŒé©åˆ‡ã§ã¯ã‚ã‚Šã¾ã›ã‚“";
	}

	protected override string _GetTemplateForResponseBirthdayInvalid()
	{
		return "ç”Ÿå¹´æœˆæ—¥ãŒç„¡åŠ¹ã§ã™ã€‚";
	}

	protected override string _GetTemplateForResponseBirthdayMustBeSetFirst()
	{
		return "æœ€åˆã«èª•ç”Ÿæ—¥ã‚’è¨­å®šã™ã‚‹å¿…è¦ãŒã‚ã‚Šã¾ã™ã€‚";
	}

	protected override string _GetTemplateForResponseCaptchaMismatchError()
	{
		return "è¨€è‘‰ãŒä¸€è‡´ã—ã¾ã›ã‚“ã€‚";
	}

	protected override string _GetTemplateForResponseCaptchaNotEnteredError()
	{
		return "ã‚­ãƒ£ãƒ—ãƒãƒ£èªè¨¼ã‚’å…¥åŠ›ã—ã¦ãã ã•ã„";
	}

	protected override string _GetTemplateForResponseFacebookConnectionError()
	{
		return "Facebookã‹ã‚‰ã®æƒ…å ±ã®å–å¾—ä¸­ã«ã‚¨ãƒ©ãƒ¼ãŒç™ºç”Ÿã—ã¾ã—ãŸã€‚";
	}

	protected override string _GetTemplateForResponseFacebookLoginAge()
	{
		return "Facebookãƒ­ã‚°ã‚¤ãƒ³ã¯13æ­³ä»¥ä¸Šã®ãƒ¦ãƒ¼ã‚¶ãƒ¼ã®ã¿ä½¿ç”¨ã§ãã¾ã™ã€‚";
	}

	protected override string _GetTemplateForResponseInvalidBirthday()
	{
		return "ç”Ÿå¹´æœˆæ—¥ãŒç„¡åŠ¹ã§ã™ã€‚";
	}

	protected override string _GetTemplateForResponseInvalidEmail()
	{
		return "ãƒ¡ãƒ¼ãƒ«ã‚¢ãƒ‰ãƒ¬ã‚¹ãŒç„¡åŠ¹ã§ã™ã€‚";
	}

	protected override string _GetTemplateForResponseJavaScriptRequired()
	{
		return "ãƒ•ã‚©ãƒ¼ãƒ ã‚’é€ä¿¡ã™ã‚‹ã«ã¯JavaScriptãŒå¿…è¦ã§ã™ã€‚";
	}

	protected override string _GetTemplateForResponsePasswordComplexity()
	{
		return "ã‚‚ã£ã¨è¤‡é›‘ãªãƒ‘ã‚¹ãƒ¯ãƒ¼ãƒ‰ã‚’ä½œæˆã—ã¦ãã ã•ã„ã€‚";
	}

	protected override string _GetTemplateForResponsePasswordConfirmation()
	{
		return "ç¢ºèªãƒ‘ã‚¹ãƒ¯ãƒ¼ãƒ‰ã‚’å…¥åŠ›ã—ã¦ãã ã•ã„ã€‚";
	}

	protected override string _GetTemplateForResponsePasswordContainsUsernameError()
	{
		return "ãƒ‘ã‚¹ãƒ¯ãƒ¼ãƒ‰ã‚’ãƒ¦ãƒ¼ã‚¶ãƒ¼ãƒãƒ¼ãƒ ã¨åŒã˜ã«ã™ã‚‹ã“ã¨ã¯ã§ãã¾ã›ã‚“ã€‚";
	}

	protected override string _GetTemplateForResponsePasswordMismatch()
	{
		return "ãƒ‘ã‚¹ãƒ¯ãƒ¼ãƒ‰ãŒä¸€è‡´ã—ã¾ã›ã‚“ã€‚";
	}

	protected override string _GetTemplateForResponsePasswordWrongShort()
	{
		return "ãƒ‘ã‚¹ãƒ¯ãƒ¼ãƒ‰ã¯8æ–‡å­—ä»¥ä¸Šã§ãªã‘ã‚Œã°ãªã‚Šã¾ã›ã‚“ã€‚";
	}

	protected override string _GetTemplateForResponsePleaseEnterPassword()
	{
		return "ãƒ‘ã‚¹ãƒ¯ãƒ¼ãƒ‰ã‚’å…¥åŠ›ã—ã¦ä¸‹ã•ã„ã€‚";
	}

	protected override string _GetTemplateForResponsePleaseEnterUsername()
	{
		return "ãƒ¦ãƒ¼ã‚¶ãƒ¼ãƒãƒ¼ãƒ ã‚’å…¥åŠ›ã—ã¦ä¸‹ã•ã„ã€‚";
	}

	protected override string _GetTemplateForResponseSocialAccountCreationFailed()
	{
		return "ã‚¢ã‚«ã‚¦ãƒ³ãƒˆã®ä½œæˆã«å¤±æ•—ã—ã¾ã—ãŸ";
	}

	protected override string _GetTemplateForResponseSpaceOrSpecialCharaterError()
	{
		return "ã‚¹ãƒšãƒ¼ã‚¹ã‚„ç‰¹æ®Šæ–‡å­—ã¯ä½¿ç”¨ã§ãã¾ã›ã‚“ã€‚";
	}

	protected override string _GetTemplateForResponseTooManyAccountsWithSameEmailError()
	{
		return "ã“ã®ãƒ¡ãƒ¼ãƒ«ã‚¢ãƒ‰ãƒ¬ã‚¹ã¯ã™ã§ã«å¤šãã®ã‚¢ã‚«ã‚¦ãƒ³ãƒˆã§ä½¿ç”¨ã•ã‚Œã¦ã„ã¾ã™ã€‚";
	}

	protected override string _GetTemplateForResponseUnknownError()
	{
		return "ã”ã‚ã‚“ãªã•ã„ï¼ä¸æ˜Žãªã‚¨ãƒ©ãƒ¼ãŒç™ºç”Ÿã—ã¾ã—ãŸã€‚å¾Œã§ã‚‚ã†ä¸€åº¦ãŠè©¦ã—ãã ã•ã„ã€‚";
	}

	protected override string _GetTemplateForResponseUsernameAllowedCharactersError()
	{
		return "ãƒ¦ãƒ¼ã‚¶ãƒ¼ãƒãƒ¼ãƒ ã«ä½¿ç”¨ã§ãã‚‹ã®ã¯ã€æ–‡å­—ã€æ•°å­—ã€ ãŠã‚ˆã³ä¸‹ç·š ï¼ˆ _ ï¼‰ã ã‘ã§ã™ã€‚";
	}

	protected override string _GetTemplateForResponseUsernameAlreadyInUse()
	{
		return "ã“ã®ãƒ¦ãƒ¼ã‚¶ãƒ¼ãƒãƒ¼ãƒ ã¯ã™ã§ã«ä½¿ã‚ã‚Œã¦ã„ã¾ã™ã€‚";
	}

	protected override string _GetTemplateForResponseUsernameExplicit()
	{
		return "ã“ã®ãƒ¦ãƒ¼ã‚¶ãƒ¼ãƒãƒ¼ãƒ ã¯ä½¿ç”¨ã§ãã¾ã›ã‚“ã€‚";
	}

	protected override string _GetTemplateForResponseUsernameInvalid()
	{
		return "æœ‰åŠ¹ãªãƒ¦ãƒ¼ã‚¶ãƒ¼ãƒãƒ¼ãƒ ã‚’å…¥åŠ›ã—ã¦ä¸‹ã•ã„ã€‚";
	}

	protected override string _GetTemplateForResponseUsernameInvalidCharacters()
	{
		return "a-zã€A-Zã€0-9ã€ãŠã‚ˆã³ä¸‹ç·šï¼ˆ _ ï¼‰ã®ã¿ã‚’ä½¿ç”¨ã§ãã¾ã™ã€‚";
	}

	protected override string _GetTemplateForResponseUsernameInvalidLength()
	{
		return "ãƒ¦ãƒ¼ã‚¶ãƒ¼ãƒãƒ¼ãƒ ã¯3ã€œ20æ–‡å­—ä»¥å†…ã«ã™ã‚‹å¿…è¦ãŒã‚ã‚Šã¾ã™ã€‚";
	}

	protected override string _GetTemplateForResponseUsernameInvalidUnderscore()
	{
		return "ãƒ¦ãƒ¼ã‚¶ãƒ¼ãƒãƒ¼ãƒ ã®æœ€åˆã¨æœ€å¾Œã«ä¸‹ç·šï¼ˆ _ ï¼‰ã¯ä½¿ç”¨ä¸å¯ã€‚";
	}

	protected override string _GetTemplateForResponseUsernameNotAvailable()
	{
		return "ãƒ¦ãƒ¼ã‚¶ãƒ¼ãƒãƒ¼ãƒ ãŒåˆ©ç”¨ã§ãã¾ã›ã‚“ã€‚ã‚„ã‚Šç›´ã—ã¦ãã ã•ã„ã€‚";
	}

	protected override string _GetTemplateForResponseUsernameOrPasswordIncorrect()
	{
		return "ãƒ¦ãƒ¼ã‚¶ãƒ¼ãƒãƒ¼ãƒ ã€ã¾ãŸã¯ãƒ‘ã‚¹ãƒ¯ãƒ¼ãƒ‰ãŒé–“é•ã£ã¦ã„ã¾ã™ã€‚";
	}

	protected override string _GetTemplateForResponseUsernamePasswordRequired()
	{
		return "ãƒ¦ãƒ¼ã‚¶ãƒ¼åã¨ãƒ‘ã‚¹ãƒ¯ãƒ¼ãƒ‰ãŒå¿…è¦ã§ã™ã€‚";
	}

	protected override string _GetTemplateForResponseUsernamePrivateInfo()
	{
		return "ãƒ¦ãƒ¼ã‚¶ãƒ¼ãƒãƒ¼ãƒ ã«å€‹äººæƒ…å ±ãŒå«ã¾ã‚Œã¦ã„ã¾ã™ã€‚";
	}

	protected override string _GetTemplateForResponseUsernameRequired()
	{
		return "ãƒ¦ãƒ¼ã‚¶ãƒ¼ãƒãƒ¼ãƒ ãŒå¿…è¦ã§ã™ã€‚";
	}

	protected override string _GetTemplateForResponseUsernameTakenTryAgain()
	{
		return "ãã®ãƒ¦ãƒ¼ã‚¶ãƒ¼ãƒãƒ¼ãƒ ã¯ã™ã§ã«ä½¿ã‚ã‚Œã¦ã„ã¾ã™ï¼åˆ¥ã®åå‰ã‚’ãŠè©¦ã—ãã ã•ã„ã€‚";
	}

	protected override string _GetTemplateForResponseUsernameTooManyUnderscores()
	{
		return "ãƒ¦ãƒ¼ã‚¶ãƒ¼ãƒãƒ¼ãƒ ã«ã¯ä¸‹ç·šï¼ˆ _ ï¼‰ã‚’2ã¤ä»¥ä¸Šä½¿ç”¨ã§ãã¾ã›ã‚“ã€‚";
	}
}


}
