namespace Roblox.Platform.TranslationResources.Authentication {
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
	public override string ActionCreateAccount => "ê³„ì • ë§Œë“¤ê¸°";

	/// <summary>
	/// Key: "Action.LinkAccount"
	/// Button text to link 3rd Party Account to a Roblox Account
	/// English String: "Link Account"
	/// </summary>
	public override string ActionLinkAccount => "ê³„ì • ì—°ê²°";

	/// <summary>
	/// Key: "Action.LogInCapitalized"
	/// button label for capitalized words for Log In
	/// English String: "Log In"
	/// </summary>
	public override string ActionLogInCapitalized => "ë¡œê·¸ì¸";

	/// <summary>
	/// Key: "Action.ReturnHome"
	/// button label to return the user to home page
	/// English String: "Return Home"
	/// </summary>
	public override string ActionReturnHome => "í™ˆìœ¼ë¡œ ëŒì•„ê°€ê¸°";

	/// <summary>
	/// Key: "Action.SignUp"
	/// English String: "Sign up"
	/// </summary>
	public override string ActionSignUp => "íšŒì›ê°€ìž…";

	public override string ActionSignupAndSync => "íšŒì›ê°€ìž… ë° ë™ê¸°í™”";

	/// <summary>
	/// Key: "Action.Submit"
	/// English String: "Submit"
	/// </summary>
	public override string ActionSubmit => "ì œì¶œ";

	/// <summary>
	/// Key: "Description.AccountLinkingWarning"
	/// instructions for linking account on signup page for FB based account
	/// English String: "To link to an existing Roblox account, sign in and link them on the account settings page."
	/// </summary>
	public override string DescriptionAccountLinkingWarning => "ê¸°ì¡´ Roblox ê³„ì •ì— ì—°ê²°í•˜ë ¤ë©´, ë¡œê·¸ì¸í•œ í›„ ê³„ì • ì„¤ì • íŽ˜ì´ì§€ì—ì„œ ì—°ê²°í•˜ì„¸ìš”.";

	/// <summary>
	/// Key: "Description.NoRealName"
	/// description
	/// English String: "Do not use your real name."
	/// </summary>
	public override string DescriptionNoRealName => "ì‹¤ëª…ì„ ì‚¬ìš©í•˜ì§€ ë§ˆì„¸ìš”.";

	/// <summary>
	/// Key: "Description.PrivacyPolicy"
	/// English String: "Privacy Policy"
	/// </summary>
	public override string DescriptionPrivacyPolicy => "ê°œì¸ì •ë³´ ì²˜ë¦¬ë°©ì¹¨";

	/// <summary>
	/// Key: "Description.TermsOfService"
	/// English String: "Terms of Service"
	/// </summary>
	public override string DescriptionTermsOfService => "ì„œë¹„ìŠ¤ ì•½ê´€";

	/// <summary>
	/// Key: "GuestSignUpAB.Action.SignUp"
	/// English String: "Sign Up"
	/// </summary>
	public override string GuestSignUpABActionSignUp => "íšŒì›ê°€ìž…";

	/// <summary>
	/// Key: "Heading.ConnectFacebook"
	/// section heading
	/// English String: "Connect to Facebook"
	/// </summary>
	public override string HeadingConnectFacebook => "Facebookì— ì—°ê²°";

	/// <summary>
	/// Key: "Heading.CreateAnAccount"
	/// should be capitalized if the language supports capitalization
	/// English String: "CREATE AN ACCOUNT"
	/// </summary>
	public override string HeadingCreateAnAccount => "ê³„ì • ë§Œë“¤ê¸°";

	/// <summary>
	/// Key: "Heading.LoginHaveFun"
	/// heading for login container
	/// English String: "Log in and start having fun!"
	/// </summary>
	public override string HeadingLoginHaveFun => "ë¡œê·¸ì¸í•˜ì—¬ ì¦ê²¨ë³´ì„¸ìš”!";

	/// <summary>
	/// Key: "Heading.SignupHaveFun"
	/// signup form heading
	/// English String: "Sign up and start having fun!"
	/// </summary>
	public override string HeadingSignupHaveFun => "ê°€ìž…í•˜ì‹œê³  ì¦ê²¨ë³´ì„¸ìš”!";

	/// <summary>
	/// Key: "Label.About"
	/// About link on roller coaster page
	/// English String: "About"
	/// </summary>
	public override string LabelAbout => "ì†Œê°œ";

	/// <summary>
	/// Key: "Label.AlreadyHaveRobloxAccount"
	/// English String: "Already have a Roblox account?"
	/// </summary>
	public override string LabelAlreadyHaveRobloxAccount => "ì´ë¯¸ Roblox ê³„ì •ì´ ìžˆìœ¼ì‹œë‹¤êµ¬ìš”?";

	/// <summary>
	/// Key: "Label.AlreadyRegistered"
	/// label
	/// English String: "Already registered?"
	/// </summary>
	public override string LabelAlreadyRegistered => "ì´ë¯¸ ê°€ìž…í•˜ì…¨ë‚˜ìš”?";

	/// <summary>
	/// Key: "Label.Birthday"
	/// English String: "Birthday"
	/// </summary>
	public override string LabelBirthday => "ìƒë…„ì›”ì¼";

	/// <summary>
	/// Key: "Label.BirthdayWithColumn"
	/// should have column if the language supports it
	/// English String: "Birthday:"
	/// </summary>
	public override string LabelBirthdayWithColumn => "ìƒë…„ì›”ì¼:";

	/// <summary>
	/// Key: "Label.ConfirmPassword"
	/// English String: "Confirm password"
	/// </summary>
	public override string LabelConfirmPassword => "ë¹„ë°€ë²ˆí˜¸ í™•ì¸";

	/// <summary>
	/// Key: "Label.Day"
	/// English String: "Day"
	/// </summary>
	public override string LabelDay => "ì¼";

	/// <summary>
	/// Key: "Label.DesiredUsername"
	/// should have a column if the language supports it
	/// English String: "Desired Username:"
	/// </summary>
	public override string LabelDesiredUsername => "í¬ë§í•˜ëŠ” ì‚¬ìš©ìž ì´ë¦„:";

	/// <summary>
	/// Key: "Label.FacebookNotLinked"
	/// English String: "Your Facebook account is not linked to any Roblox account. Please sign up for a Roblox account."
	/// </summary>
	public override string LabelFacebookNotLinked => "ì‚¬ìš©ìžì˜ Facebook ê³„ì •ê³¼ ì—°ê²°ëœ Roblox ê³„ì •ì´ ì—†ìŠµë‹ˆë‹¤. ê°€ìž…í•˜ì—¬ Roblox ê³„ì •ì„ ë§Œë“¤ì–´ ë³´ì„¸ìš”.";

	/// <summary>
	/// Key: "Label.FacebookSignupUsername"
	/// username field label for FB signup
	/// English String: "Create Roblox username:"
	/// </summary>
	public override string LabelFacebookSignupUsername => "Roblox ì‚¬ìš©ìž ì´ë¦„ ë§Œë“¤ê¸°:";

	/// <summary>
	/// Key: "Label.Female"
	/// label
	/// English String: "Female"
	/// </summary>
	public override string LabelFemale => "ì—¬ì„±";

	/// <summary>
	/// Key: "Label.Gender"
	/// English String: "Gender"
	/// </summary>
	public override string LabelGender => "ì„±ë³„";

	/// <summary>
	/// Key: "Label.GenderRequired"
	/// English String: "Gender is required."
	/// </summary>
	public override string LabelGenderRequired => "ì„±ë³„ì„ ì„ íƒí•˜ì„¸ìš”.";

	/// <summary>
	/// Key: "Label.GenderWithColumn"
	/// should have column if the language supports it
	/// English String: "Gender:"
	/// </summary>
	public override string LabelGenderWithColumn => "ì„±ë³„:";

	/// <summary>
	/// Key: "Label.Male"
	/// label
	/// English String: "Male"
	/// </summary>
	public override string LabelMale => "ë‚¨ì„±";

	/// <summary>
	/// Key: "Label.Month"
	/// English String: "Month"
	/// </summary>
	public override string LabelMonth => "ì›”";

	/// <summary>
	/// Key: "Label.Password"
	/// English String: "Password"
	/// </summary>
	public override string LabelPassword => "ë¹„ë°€ë²ˆí˜¸";

	/// <summary>
	/// Key: "Label.PasswordRequirements"
	/// English String: "Password (min length 8)"
	/// </summary>
	public override string LabelPasswordRequirements => "ë¹„ë°€ë²ˆí˜¸ (8ìž ì´ìƒ)";

	/// <summary>
	/// Key: "Label.Platforms"
	/// platforms link on roller coaster page
	/// English String: "Platforms"
	/// </summary>
	public override string LabelPlatforms => "í”Œëž«í¼";

	/// <summary>
	/// Key: "Label.Play"
	/// Play link on roller coaster page
	/// English String: "Play"
	/// </summary>
	public override string LabelPlay => "í”Œë ˆì´";

	/// <summary>
	/// Key: "Label.PleaseAgreeToTerms"
	/// English String: "Please agree to our Terms of Use and Privacy Policy."
	/// </summary>
	public override string LabelPleaseAgreeToTerms => "ì´ìš© ì•½ê´€ ë° ê°œì¸ì •ë³´ ì²˜ë¦¬ë°©ì¹¨ì— ë™ì˜í•˜ì‹œê¸° ë°”ëžë‹ˆë‹¤.";

	/// <summary>
	/// Key: "Label.Required"
	/// Required
	/// English String: "Required"
	/// </summary>
	public override string LabelRequired => "í•„ìˆ˜";

	/// <summary>
	/// Key: "Label.SignupButtonText"
	/// sign up button text
	/// English String: "Sign Up and Play!"
	/// </summary>
	public override string LabelSignupButtonText => "íšŒì›ê°€ìž…í•˜ì‹œê³  í”Œë ˆì´í•˜ì„¸ìš”!";

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
	public override string LabelSignUpWith => "ë˜ëŠ” ë‹¤ìŒ ë°©ë²•ìœ¼ë¡œ ê°€ìž…í•˜ê¸°";

	/// <summary>
	/// Key: "Label.TermsOfUse"
	/// terms of use link label
	/// English String: "Terms of Use"
	/// </summary>
	public override string LabelTermsOfUse => "ì´ìš© ì•½ê´€";

	/// <summary>
	/// Key: "Label.Username"
	/// English String: "Username"
	/// </summary>
	public override string LabelUsername => "ì‚¬ìš©ìž ì´ë¦„";

	/// <summary>
	/// Key: "Label.UsernameCharacterLimit"
	/// label
	/// English String: "3-20 alphanumeric characters, no spaces."
	/// </summary>
	public override string LabelUsernameCharacterLimit => "3-20ìžì˜ ì˜ìˆ«ìžë§Œ ì‚¬ìš©í•  ìˆ˜ ìžˆìŠµë‹ˆë‹¤. ê³µë°±ì€ ì‚¬ìš©í•  ìˆ˜ ì—†ìŠµë‹ˆë‹¤.";

	/// <summary>
	/// Key: "Label.UsernameHint"
	/// placeholder for username field
	/// English String: "Username (don't use your real name)"
	/// </summary>
	public override string LabelUsernameHint => "ì‚¬ìš©ìž ì´ë¦„ (ì‹¤ëª…ì„ ì‚¬ìš©í•˜ì§€ ë§ˆì„¸ìš”)";

	/// <summary>
	/// Key: "Label.UsernameRequirements"
	/// English String: "Username (length 3-20, _ is allowed)"
	/// </summary>
	public override string LabelUsernameRequirements => "ì‚¬ìš©ìž ì´ë¦„ (3~20ìž, _ ì‚¬ìš© ê°€ëŠ¥)";

	/// <summary>
	/// Key: "Label.Year"
	/// English String: "Year"
	/// </summary>
	public override string LabelYear => "ë…„";

	/// <summary>
	/// Key: "Message.Password.MinLength"
	/// English String: "Min length 8"
	/// </summary>
	public override string MessagePasswordMinLength => "8ìž ì´ìƒ";

	/// <summary>
	/// Key: "Message.Username.NoRealNameUse"
	/// English String: "Don't use your real name"
	/// </summary>
	public override string MessageUsernameNoRealNameUse => "ì‹¤ëª…ì„ ì‚¬ìš©í•˜ì§€ ë§ˆì„¸ìš”";

	/// <summary>
	/// Key: "Response.BadUsername"
	/// English String: "Username not appropriate for Roblox."
	/// </summary>
	public override string ResponseBadUsername => "Robloxì— ì í•©í•˜ì§€ ì•Šì€ ì‚¬ìš©ìž ì´ë¦„ìž…ë‹ˆë‹¤.";

	/// <summary>
	/// Key: "Response.BadUsernameForWeChat"
	/// message shown when signing up with an inappropriate username
	/// English String: "Username is not appropriate"
	/// </summary>
	public override string ResponseBadUsernameForWeChat => "ì í•©í•˜ì§€ ì•Šì€ ì‚¬ìš©ìž ì´ë¦„ìž…ë‹ˆë‹¤.";

	/// <summary>
	/// Key: "Response.BirthdayInvalid"
	/// English String: "This birthday is invalid."
	/// </summary>
	public override string ResponseBirthdayInvalid => "ìœ íš¨í•˜ì§€ ì•Šì€ ìƒë…„ì›”ì¼ìž…ë‹ˆë‹¤.";

	/// <summary>
	/// Key: "Response.BirthdayMustBeSetFirst"
	/// English String: "Birthday must be set first."
	/// </summary>
	public override string ResponseBirthdayMustBeSetFirst => "ë¨¼ì € ìƒë…„ì›”ì¼ì„ ì„¤ì •í•´ì•¼ í•©ë‹ˆë‹¤.";

	/// <summary>
	/// Key: "Response.CaptchaMismatchError"
	/// error message
	/// English String: "Words do not match."
	/// </summary>
	public override string ResponseCaptchaMismatchError => "ë‹¨ì–´ê°€ ì¼ì¹˜í•˜ì§€ ì•ŠìŠµë‹ˆë‹¤.";

	/// <summary>
	/// Key: "Response.CaptchaNotEnteredError"
	/// validation error message
	/// English String: "Please fill out the Captcha"
	/// </summary>
	public override string ResponseCaptchaNotEnteredError => "ë³´ì•ˆ ë¬¸ìžë¥¼ ìž…ë ¥í•˜ì„¸ìš”";

	/// <summary>
	/// Key: "Response.FacebookConnectionError"
	/// error message
	/// English String: "Error while retrieving values from Facebook."
	/// </summary>
	public override string ResponseFacebookConnectionError => "Facebookì—ì„œ ê°’ì„ ë°›ëŠ” ì¤‘ ì˜¤ë¥˜ê°€ ë°œìƒí–ˆì–´ìš”.";

	/// <summary>
	/// Key: "Response.FacebookLoginAge"
	/// English String: "Facebook login can only be used by users above 13."
	/// </summary>
	public override string ResponseFacebookLoginAge => "ë§Œ 13ì„¸ ì´ìƒë§Œ Facebookì— ë¡œê·¸ì¸í•  ìˆ˜ ìžˆì–´ìš”.";

	/// <summary>
	/// Key: "Response.InvalidBirthday"
	/// English String: "Invalid birthday."
	/// </summary>
	public override string ResponseInvalidBirthday => "ìœ íš¨í•˜ì§€ ì•Šì€ ìƒë…„ì›”ì¼";

	/// <summary>
	/// Key: "Response.InvalidEmail"
	/// English String: "Invalid email address."
	/// </summary>
	public override string ResponseInvalidEmail => "ìœ íš¨í•˜ì§€ ì•Šì€ ì´ë©”ì¼ ì£¼ì†Œ.";

	/// <summary>
	/// Key: "Response.JavaScriptRequired"
	/// error to show that JavaScipt is required for the form to work
	/// English String: "JavaScript is required to submit this form."
	/// </summary>
	public override string ResponseJavaScriptRequired => "ë³¸ ì–‘ì‹ì„ ì œì¶œí•˜ë ¤ë©´ JavaScriptê°€ í•„ìš”í•©ë‹ˆë‹¤.";

	/// <summary>
	/// Key: "Response.PasswordComplexity"
	/// English String: "Please create a more complex password."
	/// </summary>
	public override string ResponsePasswordComplexity => "ì¢€ ë” ë³µìž¡í•œ ë¹„ë°€ë²ˆí˜¸ë¥¼ ë§Œë“œì„¸ìš”.";

	/// <summary>
	/// Key: "Response.PasswordConfirmation"
	/// validation message for password confirmation
	/// English String: "Please enter a password confirmation."
	/// </summary>
	public override string ResponsePasswordConfirmation => "ë¹„ë°€ë²ˆí˜¸ë¥¼ ë‹¤ì‹œ í•œ ë²ˆ ìž…ë ¥í•˜ì„¸ìš”.";

	/// <summary>
	/// Key: "Response.PasswordContainsUsernameError"
	/// error when passsword has username in it
	/// English String: "Password shouldn't match username."
	/// </summary>
	public override string ResponsePasswordContainsUsernameError => "ë¹„ë°€ë²ˆí˜¸ëŠ” ì‚¬ìš©ìž ì´ë¦„ê³¼ ê°™ì„ ìˆ˜ ì—†ìŠµë‹ˆë‹¤.";

	/// <summary>
	/// Key: "Response.PasswordMismatch"
	/// English String: "Passwords do not match."
	/// </summary>
	public override string ResponsePasswordMismatch => "ë¹„ë°€ë²ˆí˜¸ê°€ ì¼ì¹˜í•˜ì§€ ì•ŠìŠµë‹ˆë‹¤.";

	/// <summary>
	/// Key: "Response.PasswordWrongShort"
	/// English String: "Passwords must be at least 8 characters long."
	/// </summary>
	public override string ResponsePasswordWrongShort => "ë¹„ë°€ë²ˆí˜¸ëŠ” 8ìž ì´ìƒì´ì–´ì•¼ í•©ë‹ˆë‹¤.";

	/// <summary>
	/// Key: "Response.PleaseEnterPassword"
	/// English String: "Please enter a password."
	/// </summary>
	public override string ResponsePleaseEnterPassword => "ë¹„ë°€ë²ˆí˜¸ë¥¼ ìž…ë ¥í•˜ì„¸ìš”.";

	/// <summary>
	/// Key: "Response.PleaseEnterUsername"
	/// English String: "Please enter a username."
	/// </summary>
	public override string ResponsePleaseEnterUsername => "ì‚¬ìš©ìž ì´ë¦„ì„ ìž…ë ¥í•˜ì„¸ìš”.";

	/// <summary>
	/// Key: "Response.SocialAccountCreationFailed"
	/// error message
	/// English String: "Account creation failed"
	/// </summary>
	public override string ResponseSocialAccountCreationFailed => "ê³„ì • ë§Œë“¤ê¸° ì‹¤íŒ¨";

	/// <summary>
	/// Key: "Response.SpaceOrSpecialCharaterError"
	/// Spaces and special characters are not allowed error message
	/// English String: "Spaces and special characters are not allowed."
	/// </summary>
	public override string ResponseSpaceOrSpecialCharaterError => "ê³µë°± ë° íŠ¹ìˆ˜ ë¬¸ìžëŠ” ì‚¬ìš©í•  ìˆ˜ ì—†ìŠµë‹ˆë‹¤.";

	/// <summary>
	/// Key: "Response.TooManyAccountsWithSameEmailError"
	/// Too many accounts use this email error message
	/// English String: "Too many accounts use this email."
	/// </summary>
	public override string ResponseTooManyAccountsWithSameEmailError => "ë„ˆë¬´ ë§Žì€ ê³„ì •ì´ ë³¸ ì´ë©”ì¼ì„ ì‚¬ìš©í•©ë‹ˆë‹¤.";

	/// <summary>
	/// Key: "Response.UnknownError"
	/// English String: "Sorry! An unknown error occurred. Please try again later."
	/// </summary>
	public override string ResponseUnknownError => "ì£„ì†¡í•©ë‹ˆë‹¤!\u00a0ì•Œ ìˆ˜ ì—†ëŠ” ì˜¤ë¥˜ê°€ ë°œìƒí–ˆì–´ìš”.\u00a0ë‚˜ì¤‘ì— ë‹¤ì‹œ ì‹œë„í•˜ì„¸ìš”.";

	/// <summary>
	/// Key: "Response.UsernameAllowedCharactersError"
	/// error showing which characters are allowed for username
	/// English String: "Usernames may only contain letters, numbers, and _."
	/// </summary>
	public override string ResponseUsernameAllowedCharactersError => "ì‚¬ìš©ìž ì´ë¦„ì—ëŠ” ì•ŒíŒŒë²³, ìˆ«ìž ë° _ë§Œ ì‚¬ìš©í•  ìˆ˜ ìžˆìŠµë‹ˆë‹¤.";

	/// <summary>
	/// Key: "Response.UsernameAlreadyInUse"
	/// English String: "This username is already in use."
	/// </summary>
	public override string ResponseUsernameAlreadyInUse => "ì´ë¯¸ ì‚¬ìš© ì¤‘ì¸ ì‚¬ìš©ìž ì´ë¦„ìž…ë‹ˆë‹¤.";

	/// <summary>
	/// Key: "Response.UsernameExplicit"
	/// English String: "This username is not allowed, please try another."
	/// </summary>
	public override string ResponseUsernameExplicit => "ì‚¬ìš©í•  ìˆ˜ ì—†ëŠ” ì‚¬ìš©ìž ì´ë¦„ìž…ë‹ˆë‹¤. ë‹¤ì‹œ ì‹œë„í•˜ì„¸ìš”.";

	/// <summary>
	/// Key: "Response.UsernameInvalid"
	/// English String: "Please enter a valid username."
	/// </summary>
	public override string ResponseUsernameInvalid => "ìœ íš¨í•œ ì‚¬ìš©ìž ì´ë¦„ì„ ìž…ë ¥í•˜ì„¸ìš”.";

	/// <summary>
	/// Key: "Response.UsernameInvalidCharacters"
	/// English String: "Only a-z, A-Z, 0-9 and _ are allowed."
	/// </summary>
	public override string ResponseUsernameInvalidCharacters => "a-z, A-Z, 0-9 ë° _ë§Œ ì‚¬ìš©í•  ìˆ˜ ìžˆìŠµë‹ˆë‹¤.";

	/// <summary>
	/// Key: "Response.UsernameInvalidLength"
	/// English String: "Usernames can be 3 to 20 characters long."
	/// </summary>
	public override string ResponseUsernameInvalidLength => "ì‚¬ìš©ìž ì´ë¦„ì€ 3~20ìžë¡œ êµ¬ì„±ë©ë‹ˆë‹¤.";

	/// <summary>
	/// Key: "Response.UsernameInvalidUnderscore"
	/// English String: "Usernames cannot start or end with _."
	/// </summary>
	public override string ResponseUsernameInvalidUnderscore => "ì‚¬ìš©ìž ì´ë¦„ì€ _ìœ¼ë¡œ ì‹œìž‘í•˜ê±°ë‚˜ ëë‚  ìˆ˜ ì—†ìŠµë‹ˆë‹¤.";

	/// <summary>
	/// Key: "Response.UsernameNotAvailable"
	/// English String: "Username not available. Please try again."
	/// </summary>
	public override string ResponseUsernameNotAvailable => "ì‚¬ìš©í•  ìˆ˜ ì—†ëŠ” ì‚¬ìš©ìž ì´ë¦„. ë‹¤ì‹œ ì‹œë„í•˜ì„¸ìš”.";

	/// <summary>
	/// Key: "Response.UsernameOrPasswordIncorrect"
	/// Your username or password is incorrect
	/// English String: "Your username or password is incorrect."
	/// </summary>
	public override string ResponseUsernameOrPasswordIncorrect => "ì‚¬ìš©ìž ì´ë¦„ ë˜ëŠ” ë¹„ë°€ë²ˆí˜¸ê°€ ì¼ì¹˜í•˜ì§€ ì•ŠìŠµë‹ˆë‹¤.";

	/// <summary>
	/// Key: "Response.UsernamePasswordRequired"
	/// Username and Password are required error message
	/// English String: "Username and Password are required."
	/// </summary>
	public override string ResponseUsernamePasswordRequired => "ì‚¬ìš©ìž ì´ë¦„ ë° ë¹„ë°€ë²ˆí˜¸ê°€ í•„ìš”í•©ë‹ˆë‹¤.";

	/// <summary>
	/// Key: "Response.UsernamePrivateInfo"
	/// English String: "Username might contain private information."
	/// </summary>
	public override string ResponseUsernamePrivateInfo => "ì‚¬ìš©ìž ì´ë¦„ì— ê°œì¸ ì •ë³´ê°€ í¬í•¨ë  ìˆ˜ë„ ìžˆìŠµë‹ˆë‹¤.";

	/// <summary>
	/// Key: "Response.UsernameRequired"
	/// validation error message
	/// English String: "Username is required."
	/// </summary>
	public override string ResponseUsernameRequired => "ì‚¬ìš©ìž ì´ë¦„ì€ í•„ìˆ˜ìž…ë‹ˆë‹¤.";

	/// <summary>
	/// Key: "Response.UsernameTakenTryAgain"
	/// English String: "This username is already taken! Please try a different one."
	/// </summary>
	public override string ResponseUsernameTakenTryAgain => "ì´ë¯¸ ì‚¬ìš© ì¤‘ì¸ ì‚¬ìš©ìž ì´ë¦„ìž…ë‹ˆë‹¤!\u00a0ë‹¤ë¥¸ ì´ë¦„ì„ ì‚¬ìš©í•˜ì„¸ìš”.";

	/// <summary>
	/// Key: "Response.UsernameTooManyUnderscores"
	/// English String: "Usernames can have at most one _."
	/// </summary>
	public override string ResponseUsernameTooManyUnderscores => "ì‚¬ìš©ìž ì´ë¦„ì€ _ì„ í•˜ë‚˜ë§Œ í¬í•¨í•  ìˆ˜ ìžˆìŠµë‹ˆë‹¤.";

	public SignUpResources_ko_kr(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionCreateAccount()
	{
		return "ê³„ì • ë§Œë“¤ê¸°";
	}

	protected override string _GetTemplateForActionLinkAccount()
	{
		return "ê³„ì • ì—°ê²°";
	}

	protected override string _GetTemplateForActionLogInCapitalized()
	{
		return "ë¡œê·¸ì¸";
	}

	protected override string _GetTemplateForActionReturnHome()
	{
		return "í™ˆìœ¼ë¡œ ëŒì•„ê°€ê¸°";
	}

	protected override string _GetTemplateForActionSignUp()
	{
		return "íšŒì›ê°€ìž…";
	}

	protected override string _GetTemplateForActionSignupAndSync()
	{
		return "íšŒì›ê°€ìž… ë° ë™ê¸°í™”";
	}

	protected override string _GetTemplateForActionSubmit()
	{
		return "ì œì¶œ";
	}

	protected override string _GetTemplateForDescriptionAccountLinkingWarning()
	{
		return "ê¸°ì¡´ Roblox ê³„ì •ì— ì—°ê²°í•˜ë ¤ë©´, ë¡œê·¸ì¸í•œ í›„ ê³„ì • ì„¤ì • íŽ˜ì´ì§€ì—ì„œ ì—°ê²°í•˜ì„¸ìš”.";
	}

	protected override string _GetTemplateForDescriptionNoRealName()
	{
		return "ì‹¤ëª…ì„ ì‚¬ìš©í•˜ì§€ ë§ˆì„¸ìš”.";
	}

	protected override string _GetTemplateForDescriptionPrivacyPolicy()
	{
		return "ê°œì¸ì •ë³´ ì²˜ë¦¬ë°©ì¹¨";
	}

	/// <summary>
	/// Key: "Description.SignUpAgreement"
	/// terms of use agreement checkbox label to signup.
	/// English String: "By clicking {spanStart}Sign Up{spanEnd}, you are agreeing to the {termsOfUseLink} and acknowledging the {privacyPolicyLink}"
	/// </summary>
	public override string DescriptionSignUpAgreement(string spanStart, string spanEnd, string termsOfUseLink, string privacyPolicyLink)
	{
		return $"{spanStart}íšŒì›ê°€ìž…{spanEnd}ì„ í´ë¦­í•˜ë©´ {termsOfUseLink}ì— ë™ì˜í•˜ê³  {privacyPolicyLink}ì„(ë¥¼) ìŠ¹ë‚™í•˜ëŠ” ê²ƒìœ¼ë¡œ ê°„ì£¼ë©ë‹ˆë‹¤.";
	}

	protected override string _GetTemplateForDescriptionSignUpAgreement()
	{
		return "{spanStart}íšŒì›ê°€ìž…{spanEnd}ì„ í´ë¦­í•˜ë©´ {termsOfUseLink}ì— ë™ì˜í•˜ê³  {privacyPolicyLink}ì„(ë¥¼) ìŠ¹ë‚™í•˜ëŠ” ê²ƒìœ¼ë¡œ ê°„ì£¼ë©ë‹ˆë‹¤.";
	}

	protected override string _GetTemplateForDescriptionTermsOfService()
	{
		return "ì„œë¹„ìŠ¤ ì•½ê´€";
	}

	protected override string _GetTemplateForGuestSignUpABActionSignUp()
	{
		return "íšŒì›ê°€ìž…";
	}

	protected override string _GetTemplateForHeadingConnectFacebook()
	{
		return "Facebookì— ì—°ê²°";
	}

	protected override string _GetTemplateForHeadingCreateAnAccount()
	{
		return "ê³„ì • ë§Œë“¤ê¸°";
	}

	/// <summary>
	/// Key: "Heading.FacebookSignupAlmostDone"
	/// when user signs up using Facebook, this is shown in next step to create a password.
	/// English String: "{firstname}, YOU'RE ALMOST DONE"
	/// </summary>
	public override string HeadingFacebookSignupAlmostDone(string firstname)
	{
		return $"{firstname} ë‹˜, ê±°ì˜ ëë‚¬ì–´ìš”.";
	}

	protected override string _GetTemplateForHeadingFacebookSignupAlmostDone()
	{
		return "{firstname} ë‹˜, ê±°ì˜ ëë‚¬ì–´ìš”.";
	}

	protected override string _GetTemplateForHeadingLoginHaveFun()
	{
		return "ë¡œê·¸ì¸í•˜ì—¬ ì¦ê²¨ë³´ì„¸ìš”!";
	}

	protected override string _GetTemplateForHeadingSignupHaveFun()
	{
		return "ê°€ìž…í•˜ì‹œê³  ì¦ê²¨ë³´ì„¸ìš”!";
	}

	protected override string _GetTemplateForLabelAbout()
	{
		return "ì†Œê°œ";
	}

	protected override string _GetTemplateForLabelAlreadyHaveRobloxAccount()
	{
		return "ì´ë¯¸ Roblox ê³„ì •ì´ ìžˆìœ¼ì‹œë‹¤êµ¬ìš”?";
	}

	protected override string _GetTemplateForLabelAlreadyRegistered()
	{
		return "ì´ë¯¸ ê°€ìž…í•˜ì…¨ë‚˜ìš”?";
	}

	protected override string _GetTemplateForLabelBirthday()
	{
		return "ìƒë…„ì›”ì¼";
	}

	protected override string _GetTemplateForLabelBirthdayWithColumn()
	{
		return "ìƒë…„ì›”ì¼:";
	}

	protected override string _GetTemplateForLabelConfirmPassword()
	{
		return "ë¹„ë°€ë²ˆí˜¸ í™•ì¸";
	}

	protected override string _GetTemplateForLabelDay()
	{
		return "ì¼";
	}

	protected override string _GetTemplateForLabelDesiredUsername()
	{
		return "í¬ë§í•˜ëŠ” ì‚¬ìš©ìž ì´ë¦„:";
	}

	protected override string _GetTemplateForLabelFacebookNotLinked()
	{
		return "ì‚¬ìš©ìžì˜ Facebook ê³„ì •ê³¼ ì—°ê²°ëœ Roblox ê³„ì •ì´ ì—†ìŠµë‹ˆë‹¤. ê°€ìž…í•˜ì—¬ Roblox ê³„ì •ì„ ë§Œë“¤ì–´ ë³´ì„¸ìš”.";
	}

	protected override string _GetTemplateForLabelFacebookSignupUsername()
	{
		return "Roblox ì‚¬ìš©ìž ì´ë¦„ ë§Œë“¤ê¸°:";
	}

	protected override string _GetTemplateForLabelFemale()
	{
		return "ì—¬ì„±";
	}

	protected override string _GetTemplateForLabelGender()
	{
		return "ì„±ë³„";
	}

	protected override string _GetTemplateForLabelGenderRequired()
	{
		return "ì„±ë³„ì„ ì„ íƒí•˜ì„¸ìš”.";
	}

	protected override string _GetTemplateForLabelGenderWithColumn()
	{
		return "ì„±ë³„:";
	}

	protected override string _GetTemplateForLabelMale()
	{
		return "ë‚¨ì„±";
	}

	protected override string _GetTemplateForLabelMonth()
	{
		return "ì›”";
	}

	protected override string _GetTemplateForLabelPassword()
	{
		return "ë¹„ë°€ë²ˆí˜¸";
	}

	protected override string _GetTemplateForLabelPasswordRequirements()
	{
		return "ë¹„ë°€ë²ˆí˜¸ (8ìž ì´ìƒ)";
	}

	protected override string _GetTemplateForLabelPlatforms()
	{
		return "í”Œëž«í¼";
	}

	protected override string _GetTemplateForLabelPlay()
	{
		return "í”Œë ˆì´";
	}

	protected override string _GetTemplateForLabelPleaseAgreeToTerms()
	{
		return "ì´ìš© ì•½ê´€ ë° ê°œì¸ì •ë³´ ì²˜ë¦¬ë°©ì¹¨ì— ë™ì˜í•˜ì‹œê¸° ë°”ëžë‹ˆë‹¤.";
	}

	protected override string _GetTemplateForLabelRequired()
	{
		return "í•„ìˆ˜";
	}

	protected override string _GetTemplateForLabelSignupButtonText()
	{
		return "íšŒì›ê°€ìž…í•˜ì‹œê³  í”Œë ˆì´í•˜ì„¸ìš”!";
	}

	protected override string _GetTemplateForLabelSignUpWith()
	{
		return "ë˜ëŠ” ë‹¤ìŒ ë°©ë²•ìœ¼ë¡œ ê°€ìž…í•˜ê¸°";
	}

	protected override string _GetTemplateForLabelTermsOfUse()
	{
		return "ì´ìš© ì•½ê´€";
	}

	protected override string _GetTemplateForLabelUsername()
	{
		return "ì‚¬ìš©ìž ì´ë¦„";
	}

	protected override string _GetTemplateForLabelUsernameCharacterLimit()
	{
		return "3-20ìžì˜ ì˜ìˆ«ìžë§Œ ì‚¬ìš©í•  ìˆ˜ ìžˆìŠµë‹ˆë‹¤. ê³µë°±ì€ ì‚¬ìš©í•  ìˆ˜ ì—†ìŠµë‹ˆë‹¤.";
	}

	protected override string _GetTemplateForLabelUsernameHint()
	{
		return "ì‚¬ìš©ìž ì´ë¦„ (ì‹¤ëª…ì„ ì‚¬ìš©í•˜ì§€ ë§ˆì„¸ìš”)";
	}

	protected override string _GetTemplateForLabelUsernameRequirements()
	{
		return "ì‚¬ìš©ìž ì´ë¦„ (3~20ìž, _ ì‚¬ìš© ê°€ëŠ¥)";
	}

	protected override string _GetTemplateForLabelYear()
	{
		return "ë…„";
	}

	protected override string _GetTemplateForMessagePasswordMinLength()
	{
		return "8ìž ì´ìƒ";
	}

	protected override string _GetTemplateForMessageUsernameNoRealNameUse()
	{
		return "ì‹¤ëª…ì„ ì‚¬ìš©í•˜ì§€ ë§ˆì„¸ìš”";
	}

	protected override string _GetTemplateForResponseBadUsername()
	{
		return "Robloxì— ì í•©í•˜ì§€ ì•Šì€ ì‚¬ìš©ìž ì´ë¦„ìž…ë‹ˆë‹¤.";
	}

	protected override string _GetTemplateForResponseBadUsernameForWeChat()
	{
		return "ì í•©í•˜ì§€ ì•Šì€ ì‚¬ìš©ìž ì´ë¦„ìž…ë‹ˆë‹¤.";
	}

	protected override string _GetTemplateForResponseBirthdayInvalid()
	{
		return "ìœ íš¨í•˜ì§€ ì•Šì€ ìƒë…„ì›”ì¼ìž…ë‹ˆë‹¤.";
	}

	protected override string _GetTemplateForResponseBirthdayMustBeSetFirst()
	{
		return "ë¨¼ì € ìƒë…„ì›”ì¼ì„ ì„¤ì •í•´ì•¼ í•©ë‹ˆë‹¤.";
	}

	protected override string _GetTemplateForResponseCaptchaMismatchError()
	{
		return "ë‹¨ì–´ê°€ ì¼ì¹˜í•˜ì§€ ì•ŠìŠµë‹ˆë‹¤.";
	}

	protected override string _GetTemplateForResponseCaptchaNotEnteredError()
	{
		return "ë³´ì•ˆ ë¬¸ìžë¥¼ ìž…ë ¥í•˜ì„¸ìš”";
	}

	protected override string _GetTemplateForResponseFacebookConnectionError()
	{
		return "Facebookì—ì„œ ê°’ì„ ë°›ëŠ” ì¤‘ ì˜¤ë¥˜ê°€ ë°œìƒí–ˆì–´ìš”.";
	}

	protected override string _GetTemplateForResponseFacebookLoginAge()
	{
		return "ë§Œ 13ì„¸ ì´ìƒë§Œ Facebookì— ë¡œê·¸ì¸í•  ìˆ˜ ìžˆì–´ìš”.";
	}

	protected override string _GetTemplateForResponseInvalidBirthday()
	{
		return "ìœ íš¨í•˜ì§€ ì•Šì€ ìƒë…„ì›”ì¼";
	}

	protected override string _GetTemplateForResponseInvalidEmail()
	{
		return "ìœ íš¨í•˜ì§€ ì•Šì€ ì´ë©”ì¼ ì£¼ì†Œ.";
	}

	protected override string _GetTemplateForResponseJavaScriptRequired()
	{
		return "ë³¸ ì–‘ì‹ì„ ì œì¶œí•˜ë ¤ë©´ JavaScriptê°€ í•„ìš”í•©ë‹ˆë‹¤.";
	}

	protected override string _GetTemplateForResponsePasswordComplexity()
	{
		return "ì¢€ ë” ë³µìž¡í•œ ë¹„ë°€ë²ˆí˜¸ë¥¼ ë§Œë“œì„¸ìš”.";
	}

	protected override string _GetTemplateForResponsePasswordConfirmation()
	{
		return "ë¹„ë°€ë²ˆí˜¸ë¥¼ ë‹¤ì‹œ í•œ ë²ˆ ìž…ë ¥í•˜ì„¸ìš”.";
	}

	protected override string _GetTemplateForResponsePasswordContainsUsernameError()
	{
		return "ë¹„ë°€ë²ˆí˜¸ëŠ” ì‚¬ìš©ìž ì´ë¦„ê³¼ ê°™ì„ ìˆ˜ ì—†ìŠµë‹ˆë‹¤.";
	}

	protected override string _GetTemplateForResponsePasswordMismatch()
	{
		return "ë¹„ë°€ë²ˆí˜¸ê°€ ì¼ì¹˜í•˜ì§€ ì•ŠìŠµë‹ˆë‹¤.";
	}

	protected override string _GetTemplateForResponsePasswordWrongShort()
	{
		return "ë¹„ë°€ë²ˆí˜¸ëŠ” 8ìž ì´ìƒì´ì–´ì•¼ í•©ë‹ˆë‹¤.";
	}

	protected override string _GetTemplateForResponsePleaseEnterPassword()
	{
		return "ë¹„ë°€ë²ˆí˜¸ë¥¼ ìž…ë ¥í•˜ì„¸ìš”.";
	}

	protected override string _GetTemplateForResponsePleaseEnterUsername()
	{
		return "ì‚¬ìš©ìž ì´ë¦„ì„ ìž…ë ¥í•˜ì„¸ìš”.";
	}

	protected override string _GetTemplateForResponseSocialAccountCreationFailed()
	{
		return "ê³„ì • ë§Œë“¤ê¸° ì‹¤íŒ¨";
	}

	protected override string _GetTemplateForResponseSpaceOrSpecialCharaterError()
	{
		return "ê³µë°± ë° íŠ¹ìˆ˜ ë¬¸ìžëŠ” ì‚¬ìš©í•  ìˆ˜ ì—†ìŠµë‹ˆë‹¤.";
	}

	protected override string _GetTemplateForResponseTooManyAccountsWithSameEmailError()
	{
		return "ë„ˆë¬´ ë§Žì€ ê³„ì •ì´ ë³¸ ì´ë©”ì¼ì„ ì‚¬ìš©í•©ë‹ˆë‹¤.";
	}

	protected override string _GetTemplateForResponseUnknownError()
	{
		return "ì£„ì†¡í•©ë‹ˆë‹¤!\u00a0ì•Œ ìˆ˜ ì—†ëŠ” ì˜¤ë¥˜ê°€ ë°œìƒí–ˆì–´ìš”.\u00a0ë‚˜ì¤‘ì— ë‹¤ì‹œ ì‹œë„í•˜ì„¸ìš”.";
	}

	protected override string _GetTemplateForResponseUsernameAllowedCharactersError()
	{
		return "ì‚¬ìš©ìž ì´ë¦„ì—ëŠ” ì•ŒíŒŒë²³, ìˆ«ìž ë° _ë§Œ ì‚¬ìš©í•  ìˆ˜ ìžˆìŠµë‹ˆë‹¤.";
	}

	protected override string _GetTemplateForResponseUsernameAlreadyInUse()
	{
		return "ì´ë¯¸ ì‚¬ìš© ì¤‘ì¸ ì‚¬ìš©ìž ì´ë¦„ìž…ë‹ˆë‹¤.";
	}

	protected override string _GetTemplateForResponseUsernameExplicit()
	{
		return "ì‚¬ìš©í•  ìˆ˜ ì—†ëŠ” ì‚¬ìš©ìž ì´ë¦„ìž…ë‹ˆë‹¤. ë‹¤ì‹œ ì‹œë„í•˜ì„¸ìš”.";
	}

	protected override string _GetTemplateForResponseUsernameInvalid()
	{
		return "ìœ íš¨í•œ ì‚¬ìš©ìž ì´ë¦„ì„ ìž…ë ¥í•˜ì„¸ìš”.";
	}

	protected override string _GetTemplateForResponseUsernameInvalidCharacters()
	{
		return "a-z, A-Z, 0-9 ë° _ë§Œ ì‚¬ìš©í•  ìˆ˜ ìžˆìŠµë‹ˆë‹¤.";
	}

	protected override string _GetTemplateForResponseUsernameInvalidLength()
	{
		return "ì‚¬ìš©ìž ì´ë¦„ì€ 3~20ìžë¡œ êµ¬ì„±ë©ë‹ˆë‹¤.";
	}

	protected override string _GetTemplateForResponseUsernameInvalidUnderscore()
	{
		return "ì‚¬ìš©ìž ì´ë¦„ì€ _ìœ¼ë¡œ ì‹œìž‘í•˜ê±°ë‚˜ ëë‚  ìˆ˜ ì—†ìŠµë‹ˆë‹¤.";
	}

	protected override string _GetTemplateForResponseUsernameNotAvailable()
	{
		return "ì‚¬ìš©í•  ìˆ˜ ì—†ëŠ” ì‚¬ìš©ìž ì´ë¦„. ë‹¤ì‹œ ì‹œë„í•˜ì„¸ìš”.";
	}

	protected override string _GetTemplateForResponseUsernameOrPasswordIncorrect()
	{
		return "ì‚¬ìš©ìž ì´ë¦„ ë˜ëŠ” ë¹„ë°€ë²ˆí˜¸ê°€ ì¼ì¹˜í•˜ì§€ ì•ŠìŠµë‹ˆë‹¤.";
	}

	protected override string _GetTemplateForResponseUsernamePasswordRequired()
	{
		return "ì‚¬ìš©ìž ì´ë¦„ ë° ë¹„ë°€ë²ˆí˜¸ê°€ í•„ìš”í•©ë‹ˆë‹¤.";
	}

	protected override string _GetTemplateForResponseUsernamePrivateInfo()
	{
		return "ì‚¬ìš©ìž ì´ë¦„ì— ê°œì¸ ì •ë³´ê°€ í¬í•¨ë  ìˆ˜ë„ ìžˆìŠµë‹ˆë‹¤.";
	}

	protected override string _GetTemplateForResponseUsernameRequired()
	{
		return "ì‚¬ìš©ìž ì´ë¦„ì€ í•„ìˆ˜ìž…ë‹ˆë‹¤.";
	}

	protected override string _GetTemplateForResponseUsernameTakenTryAgain()
	{
		return "ì´ë¯¸ ì‚¬ìš© ì¤‘ì¸ ì‚¬ìš©ìž ì´ë¦„ìž…ë‹ˆë‹¤!\u00a0ë‹¤ë¥¸ ì´ë¦„ì„ ì‚¬ìš©í•˜ì„¸ìš”.";
	}

	protected override string _GetTemplateForResponseUsernameTooManyUnderscores()
	{
		return "ì‚¬ìš©ìž ì´ë¦„ì€ _ì„ í•˜ë‚˜ë§Œ í¬í•¨í•  ìˆ˜ ìžˆìŠµë‹ˆë‹¤.";
	}
}


}
