namespace Roblox.Platform.TranslationResources.Authentication {
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
	public override string ActionCreateAccount => "à¸ªà¸£\u0e49à¸²à¸‡à¸š\u0e31à¸à¸Š\u0e35";

	/// <summary>
	/// Key: "Action.LinkAccount"
	/// Button text to link 3rd Party Account to a Roblox Account
	/// English String: "Link Account"
	/// </summary>
	public override string ActionLinkAccount => "à¹€à¸Š\u0e37\u0e48à¸­à¸¡à¹‚à¸¢à¸‡à¸š\u0e31à¸à¸Š\u0e35";

	/// <summary>
	/// Key: "Action.LogInCapitalized"
	/// button label for capitalized words for Log In
	/// English String: "Log In"
	/// </summary>
	public override string ActionLogInCapitalized => "à¹€à¸‚\u0e49à¸²à¸ª\u0e39\u0e48à¸£à¸°à¸šà¸š";

	/// <summary>
	/// Key: "Action.ReturnHome"
	/// button label to return the user to home page
	/// English String: "Return Home"
	/// </summary>
	public override string ActionReturnHome => "à¸à¸¥\u0e31à¸šà¹„à¸›à¸«à¸™\u0e49à¸²à¸«à¸¥\u0e31à¸";

	/// <summary>
	/// Key: "Action.SignUp"
	/// English String: "Sign up"
	/// </summary>
	public override string ActionSignUp => "à¸ªà¸¡\u0e31à¸„à¸£à¸š\u0e31à¸à¸Š\u0e35";

	public override string ActionSignupAndSync => "à¸ªà¸¡\u0e31à¸„à¸£à¸š\u0e31à¸à¸Š\u0e35à¸œ\u0e39\u0e49à¹ƒà¸Š\u0e49 à¹à¸¥\u0e49à¸§à¸‹\u0e34à¸‡à¸„\u0e4cà¸‚\u0e49à¸­à¸¡\u0e39à¸¥";

	/// <summary>
	/// Key: "Action.Submit"
	/// English String: "Submit"
	/// </summary>
	public override string ActionSubmit => "à¸ª\u0e48à¸‡";

	/// <summary>
	/// Key: "Description.AccountLinkingWarning"
	/// instructions for linking account on signup page for FB based account
	/// English String: "To link to an existing Roblox account, sign in and link them on the account settings page."
	/// </summary>
	public override string DescriptionAccountLinkingWarning => "à¸à¸£\u0e38à¸“à¸²à¸¥à¸‡à¸Š\u0e37\u0e48à¸­à¹€à¸‚\u0e49à¸²à¸ª\u0e39\u0e48à¸š\u0e31à¸à¸Š\u0e35 Roblox à¸—\u0e35\u0e48à¸¡\u0e35à¸­à¸¢\u0e39\u0e48à¹à¸¥\u0e49à¸§à¹€à¸ž\u0e37\u0e48à¸­à¸—à¸³à¸à¸²à¸£à¹€à¸Š\u0e37\u0e48à¸­à¸¡à¹‚à¸¢à¸‡à¸—\u0e35\u0e48à¸«à¸™\u0e49à¸²à¸à¸²à¸£à¸•\u0e31\u0e49à¸‡à¸„\u0e48à¸²à¸š\u0e31à¸à¸Š\u0e35";

	/// <summary>
	/// Key: "Description.NoRealName"
	/// description
	/// English String: "Do not use your real name."
	/// </summary>
	public override string DescriptionNoRealName => "à¸«\u0e49à¸²à¸¡à¹ƒà¸Š\u0e49à¸Š\u0e37\u0e48à¸­à¸ˆà¸£\u0e34à¸‡à¸‚à¸­à¸‡à¸„\u0e38à¸“";

	/// <summary>
	/// Key: "Description.PrivacyPolicy"
	/// English String: "Privacy Policy"
	/// </summary>
	public override string DescriptionPrivacyPolicy => "à¸™à¹‚à¸¢à¸šà¸²à¸¢à¸„à¸§à¸²à¸¡à¹€à¸›\u0e47à¸™à¸ª\u0e48à¸§à¸™à¸•\u0e31à¸§";

	/// <summary>
	/// Key: "Description.TermsOfService"
	/// English String: "Terms of Service"
	/// </summary>
	public override string DescriptionTermsOfService => "à¹€à¸‡\u0e37\u0e48à¸­à¸™à¹„à¸‚à¸à¸²à¸£à¹ƒà¸«\u0e49à¸šà¸£\u0e34à¸à¸²à¸£";

	/// <summary>
	/// Key: "GuestSignUpAB.Action.SignUp"
	/// English String: "Sign Up"
	/// </summary>
	public override string GuestSignUpABActionSignUp => "à¸ªà¸¡\u0e31à¸„à¸£à¸š\u0e31à¸à¸Š\u0e35à¸œ\u0e39\u0e49à¹ƒà¸Š\u0e49";

	/// <summary>
	/// Key: "Heading.ConnectFacebook"
	/// section heading
	/// English String: "Connect to Facebook"
	/// </summary>
	public override string HeadingConnectFacebook => "à¹€à¸Š\u0e37\u0e48à¸­à¸¡à¸•\u0e48à¸­à¸\u0e31à¸š Facebook";

	/// <summary>
	/// Key: "Heading.CreateAnAccount"
	/// should be capitalized if the language supports capitalization
	/// English String: "CREATE AN ACCOUNT"
	/// </summary>
	public override string HeadingCreateAnAccount => "à¸ªà¸£\u0e49à¸²à¸‡à¸š\u0e31à¸à¸Š\u0e35";

	/// <summary>
	/// Key: "Heading.LoginHaveFun"
	/// heading for login container
	/// English String: "Log in and start having fun!"
	/// </summary>
	public override string HeadingLoginHaveFun => "à¹€à¸‚\u0e49à¸²à¸ª\u0e39\u0e48à¸£à¸°à¸šà¸š à¹à¸¥\u0e49à¸§à¹€à¸£\u0e34\u0e48à¸¡à¸ªà¸™\u0e38à¸à¸\u0e31à¸™à¹„à¸”\u0e49à¹€à¸¥à¸¢!";

	/// <summary>
	/// Key: "Heading.SignupHaveFun"
	/// signup form heading
	/// English String: "Sign up and start having fun!"
	/// </summary>
	public override string HeadingSignupHaveFun => "à¸ªà¸¡\u0e31à¸„à¸£à¸š\u0e31à¸à¸Š\u0e35à¸œ\u0e39\u0e49à¹ƒà¸Š\u0e49 à¹à¸¥\u0e49à¸§à¹€à¸£\u0e34\u0e48à¸¡à¸ªà¸™\u0e38à¸à¸\u0e31à¸™à¹„à¸”\u0e49à¹€à¸¥à¸¢!";

	/// <summary>
	/// Key: "Label.About"
	/// About link on roller coaster page
	/// English String: "About"
	/// </summary>
	public override string LabelAbout => "à¹€à¸\u0e35\u0e48à¸¢à¸§à¸\u0e31à¸š";

	/// <summary>
	/// Key: "Label.AlreadyHaveRobloxAccount"
	/// English String: "Already have a Roblox account?"
	/// </summary>
	public override string LabelAlreadyHaveRobloxAccount => "à¸¡\u0e35à¸š\u0e31à¸à¸Š\u0e35 Roblox à¸­à¸¢\u0e39\u0e48à¹à¸¥\u0e49à¸§?";

	/// <summary>
	/// Key: "Label.AlreadyRegistered"
	/// label
	/// English String: "Already registered?"
	/// </summary>
	public override string LabelAlreadyRegistered => "à¹€à¸„à¸¢à¸¥à¸‡à¸—à¸°à¹€à¸š\u0e35à¸¢à¸™à¸­à¸¢\u0e39\u0e48à¹à¸¥\u0e49à¸§?";

	/// <summary>
	/// Key: "Label.Birthday"
	/// English String: "Birthday"
	/// </summary>
	public override string LabelBirthday => "à¸§\u0e31à¸™à¹€à¸\u0e34à¸”";

	/// <summary>
	/// Key: "Label.BirthdayWithColumn"
	/// should have column if the language supports it
	/// English String: "Birthday:"
	/// </summary>
	public override string LabelBirthdayWithColumn => "à¸§\u0e31à¸™à¹€à¸\u0e34à¸”:";

	/// <summary>
	/// Key: "Label.ConfirmPassword"
	/// English String: "Confirm password"
	/// </summary>
	public override string LabelConfirmPassword => "à¸¢\u0e37à¸™à¸¢\u0e31à¸™à¸£à¸«\u0e31à¸ªà¸œ\u0e48à¸²à¸™";

	/// <summary>
	/// Key: "Label.Day"
	/// English String: "Day"
	/// </summary>
	public override string LabelDay => "à¸§\u0e31à¸™";

	/// <summary>
	/// Key: "Label.DesiredUsername"
	/// should have a column if the language supports it
	/// English String: "Desired Username:"
	/// </summary>
	public override string LabelDesiredUsername => "à¸Š\u0e37\u0e48à¸­à¸œ\u0e39\u0e49à¹ƒà¸Š\u0e49à¸—\u0e35\u0e48à¸•\u0e49à¸­à¸‡à¸à¸²à¸£:";

	/// <summary>
	/// Key: "Label.FacebookNotLinked"
	/// English String: "Your Facebook account is not linked to any Roblox account. Please sign up for a Roblox account."
	/// </summary>
	public override string LabelFacebookNotLinked => "à¸š\u0e31à¸à¸Š\u0e35 Facebook à¸‚à¸­à¸‡à¸„\u0e38à¸“à¹„à¸¡\u0e48à¹„à¸”\u0e49à¹€à¸Š\u0e37\u0e48à¸­à¸¡à¹‚à¸¢à¸‡à¸\u0e31à¸šà¸š\u0e31à¸à¸Š\u0e35 Roblox à¹ƒà¸”à¹€à¸¥à¸¢ à¸à¸£\u0e38à¸“à¸²à¸ªà¸¡\u0e31à¸„à¸£à¸š\u0e31à¸à¸Š\u0e35 Roblox";

	/// <summary>
	/// Key: "Label.FacebookSignupUsername"
	/// username field label for FB signup
	/// English String: "Create Roblox username:"
	/// </summary>
	public override string LabelFacebookSignupUsername => "à¸ªà¸£\u0e49à¸²à¸‡à¸Š\u0e37\u0e48à¸­à¸œ\u0e39\u0e49à¹ƒà¸Š\u0e49 Roblox:";

	/// <summary>
	/// Key: "Label.Female"
	/// label
	/// English String: "Female"
	/// </summary>
	public override string LabelFemale => "à¸«à¸\u0e34à¸‡";

	/// <summary>
	/// Key: "Label.Gender"
	/// English String: "Gender"
	/// </summary>
	public override string LabelGender => "à¹€à¸žà¸¨";

	/// <summary>
	/// Key: "Label.GenderRequired"
	/// English String: "Gender is required."
	/// </summary>
	public override string LabelGenderRequired => "à¸ˆà¸³à¹€à¸›\u0e47à¸™à¸•\u0e49à¸­à¸‡à¸£à¸°à¸š\u0e38à¹€à¸žà¸¨";

	/// <summary>
	/// Key: "Label.GenderWithColumn"
	/// should have column if the language supports it
	/// English String: "Gender:"
	/// </summary>
	public override string LabelGenderWithColumn => "à¹€à¸žà¸¨:";

	/// <summary>
	/// Key: "Label.Male"
	/// label
	/// English String: "Male"
	/// </summary>
	public override string LabelMale => "à¸Šà¸²à¸¢";

	/// <summary>
	/// Key: "Label.Month"
	/// English String: "Month"
	/// </summary>
	public override string LabelMonth => "à¹€à¸”\u0e37à¸­à¸™";

	/// <summary>
	/// Key: "Label.Password"
	/// English String: "Password"
	/// </summary>
	public override string LabelPassword => "à¸£à¸«\u0e31à¸ªà¸œ\u0e48à¸²à¸™";

	/// <summary>
	/// Key: "Label.PasswordRequirements"
	/// English String: "Password (min length 8)"
	/// </summary>
	public override string LabelPasswordRequirements => "à¸£à¸«\u0e31à¸ªà¸œ\u0e48à¸²à¸™ (à¸¢à¸²à¸§à¸­à¸¢\u0e48à¸²à¸‡à¸™\u0e49à¸­à¸¢ 8)";

	/// <summary>
	/// Key: "Label.Platforms"
	/// platforms link on roller coaster page
	/// English String: "Platforms"
	/// </summary>
	public override string LabelPlatforms => "à¹à¸žà¸¥à¸•à¸Ÿà¸­à¸£\u0e4cà¸¡";

	/// <summary>
	/// Key: "Label.Play"
	/// Play link on roller coaster page
	/// English String: "Play"
	/// </summary>
	public override string LabelPlay => "à¹€à¸¥\u0e48à¸™";

	/// <summary>
	/// Key: "Label.PleaseAgreeToTerms"
	/// English String: "Please agree to our Terms of Use and Privacy Policy."
	/// </summary>
	public override string LabelPleaseAgreeToTerms => "à¸à¸£\u0e38à¸“à¸²à¸¢à¸­à¸¡à¸£\u0e31à¸šà¹€à¸‡\u0e37\u0e48à¸­à¸™à¹„à¸‚à¸à¸²à¸£à¹ƒà¸«\u0e49à¸šà¸£\u0e34à¸à¸²à¸£à¹à¸¥à¸°à¸™à¹‚à¸¢à¸šà¸²à¸¢à¸„à¸§à¸²à¸¡à¹€à¸›\u0e47à¸™à¸ª\u0e48à¸§à¸™à¸•\u0e31à¸§à¸‚à¸­à¸‡à¹€à¸£à¸²";

	/// <summary>
	/// Key: "Label.Required"
	/// Required
	/// English String: "Required"
	/// </summary>
	public override string LabelRequired => "à¸ˆà¸³à¹€à¸›\u0e47à¸™à¸•\u0e49à¸­à¸‡à¸¡\u0e35";

	/// <summary>
	/// Key: "Label.SignupButtonText"
	/// sign up button text
	/// English String: "Sign Up and Play!"
	/// </summary>
	public override string LabelSignupButtonText => "à¸ªà¸¡\u0e31à¸„à¸£à¹à¸¥\u0e49à¸§à¹€à¸¥\u0e48à¸™à¹€à¸¥à¸¢!";

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
	public override string LabelSignUpWith => "à¸«à¸£\u0e37à¸­à¸ªà¸¡\u0e31à¸„à¸£à¸š\u0e31à¸à¸Š\u0e35à¸œ\u0e39\u0e49à¹ƒà¸Š\u0e49à¸”\u0e49à¸§à¸¢";

	/// <summary>
	/// Key: "Label.TermsOfUse"
	/// terms of use link label
	/// English String: "Terms of Use"
	/// </summary>
	public override string LabelTermsOfUse => "à¹€à¸‡\u0e37\u0e48à¸­à¸™à¹„à¸‚à¸à¸²à¸£à¹ƒà¸Š\u0e49à¸‡à¸²à¸™";

	/// <summary>
	/// Key: "Label.Username"
	/// English String: "Username"
	/// </summary>
	public override string LabelUsername => "à¸Š\u0e37\u0e48à¸­à¸œ\u0e39\u0e49à¹ƒà¸Š\u0e49";

	/// <summary>
	/// Key: "Label.UsernameCharacterLimit"
	/// label
	/// English String: "3-20 alphanumeric characters, no spaces."
	/// </summary>
	public override string LabelUsernameCharacterLimit => "à¸•\u0e31à¸§à¹€à¸¥à¸‚à¸«à¸£\u0e37à¸­à¸•\u0e31à¸§à¸­\u0e31à¸à¸©à¸£ 3-20 à¸•\u0e31à¸§ à¸«\u0e49à¸²à¸¡à¸¡\u0e35à¹€à¸§\u0e49à¸™à¸§à¸£à¸£à¸„";

	/// <summary>
	/// Key: "Label.UsernameHint"
	/// placeholder for username field
	/// English String: "Username (don't use your real name)"
	/// </summary>
	public override string LabelUsernameHint => "à¸Š\u0e37\u0e48à¸­à¸œ\u0e39\u0e49à¹ƒà¸Š\u0e49 (à¸—\u0e35\u0e48à¹„à¸¡\u0e48à¹ƒà¸Š\u0e48à¸Š\u0e37\u0e48à¸­à¸ˆà¸£\u0e34à¸‡à¸‚à¸­à¸‡à¸„\u0e38à¸“)";

	/// <summary>
	/// Key: "Label.UsernameRequirements"
	/// English String: "Username (length 3-20, _ is allowed)"
	/// </summary>
	public override string LabelUsernameRequirements => "à¸Š\u0e37\u0e48à¸­à¸œ\u0e39\u0e49à¹ƒà¸Š\u0e49 (à¸„à¸§à¸²à¸¡à¸¢à¸²à¸§ 3-20 à¸­à¸™\u0e38à¸à¸²à¸•à¹ƒà¸«\u0e49à¹ƒà¸Š\u0e49 _)";

	/// <summary>
	/// Key: "Label.Year"
	/// English String: "Year"
	/// </summary>
	public override string LabelYear => "à¸›\u0e35";

	/// <summary>
	/// Key: "Message.Password.MinLength"
	/// English String: "Min length 8"
	/// </summary>
	public override string MessagePasswordMinLength => "à¸¢à¸²à¸§à¸­à¸¢\u0e48à¸²à¸‡à¸™\u0e49à¸­à¸¢ 8";

	/// <summary>
	/// Key: "Message.Username.NoRealNameUse"
	/// English String: "Don't use your real name"
	/// </summary>
	public override string MessageUsernameNoRealNameUse => "à¸­à¸¢\u0e48à¸²à¹ƒà¸Š\u0e49à¸Š\u0e37\u0e48à¸­à¸ˆà¸£\u0e34à¸‡à¸‚à¸­à¸‡à¸„\u0e38à¸“";

	/// <summary>
	/// Key: "Response.BadUsername"
	/// English String: "Username not appropriate for Roblox."
	/// </summary>
	public override string ResponseBadUsername => "à¸Š\u0e37\u0e48à¸­à¸œ\u0e39\u0e49à¹ƒà¸Š\u0e49à¹„à¸¡\u0e48à¹€à¸«à¸¡à¸²à¸°à¸ªà¸¡à¸ªà¸³à¸«à¸£\u0e31à¸š Roblox";

	/// <summary>
	/// Key: "Response.BadUsernameForWeChat"
	/// message shown when signing up with an inappropriate username
	/// English String: "Username is not appropriate"
	/// </summary>
	public override string ResponseBadUsernameForWeChat => "à¸Š\u0e37\u0e48à¸­à¸œ\u0e39\u0e49à¹ƒà¸Š\u0e49à¹„à¸¡\u0e48à¹€à¸«à¸¡à¸²à¸°à¸ªà¸¡";

	/// <summary>
	/// Key: "Response.BirthdayInvalid"
	/// English String: "This birthday is invalid."
	/// </summary>
	public override string ResponseBirthdayInvalid => "à¸§\u0e31à¸™à¹€à¸\u0e34à¸”à¸™\u0e35\u0e49à¹„à¸¡\u0e48à¸–\u0e39à¸à¸•\u0e49à¸­à¸‡";

	/// <summary>
	/// Key: "Response.BirthdayMustBeSetFirst"
	/// English String: "Birthday must be set first."
	/// </summary>
	public override string ResponseBirthdayMustBeSetFirst => "à¸ˆà¸°à¸•\u0e49à¸­à¸‡à¸£à¸°à¸š\u0e38à¸§\u0e31à¸™à¹€à¸\u0e34à¸”à¸\u0e48à¸­à¸™";

	/// <summary>
	/// Key: "Response.CaptchaMismatchError"
	/// error message
	/// English String: "Words do not match."
	/// </summary>
	public override string ResponseCaptchaMismatchError => "à¸„à¸³à¹„à¸¡\u0e48à¸•à¸£à¸‡à¸\u0e31à¸™";

	/// <summary>
	/// Key: "Response.CaptchaNotEnteredError"
	/// validation error message
	/// English String: "Please fill out the Captcha"
	/// </summary>
	public override string ResponseCaptchaNotEnteredError => "à¸à¸£\u0e38à¸“à¸²à¸›\u0e49à¸­à¸™ Captcha";

	/// <summary>
	/// Key: "Response.FacebookConnectionError"
	/// error message
	/// English String: "Error while retrieving values from Facebook."
	/// </summary>
	public override string ResponseFacebookConnectionError => "à¹€à¸\u0e34à¸”à¸‚\u0e49à¸­à¸œ\u0e34à¸”à¸žà¸¥à¸²à¸”à¸‚à¸“à¸°à¸žà¸¢à¸²à¸¢à¸²à¸¡à¸”\u0e36à¸‡à¸‚\u0e49à¸­à¸¡\u0e39à¸¥à¸‚à¸­à¸‡à¸„\u0e38à¸“à¸ˆà¸²à¸ Facebook";

	/// <summary>
	/// Key: "Response.FacebookLoginAge"
	/// English String: "Facebook login can only be used by users above 13."
	/// </summary>
	public override string ResponseFacebookLoginAge => "à¸à¸²à¸£à¹€à¸‚\u0e49à¸²à¸ª\u0e39\u0e48à¸£à¸°à¸šà¸š Facebook à¸ˆà¸°à¸ªà¸²à¸¡à¸²à¸£à¸–à¹ƒà¸Š\u0e49à¸‡à¸²à¸™à¹„à¸”\u0e49à¹‚à¸”à¸¢à¸œ\u0e39\u0e49à¹ƒà¸Š\u0e49à¸­à¸²à¸¢\u0e38 13 à¸›\u0e35à¸‚\u0e36\u0e49à¸™à¹„à¸›à¹€à¸—\u0e48à¸²à¸™\u0e31\u0e49à¸™";

	/// <summary>
	/// Key: "Response.InvalidBirthday"
	/// English String: "Invalid birthday."
	/// </summary>
	public override string ResponseInvalidBirthday => "à¸§\u0e31à¸™à¹€à¸\u0e34à¸”à¹„à¸¡\u0e48à¸–\u0e39à¸à¸•\u0e49à¸­à¸‡";

	/// <summary>
	/// Key: "Response.InvalidEmail"
	/// English String: "Invalid email address."
	/// </summary>
	public override string ResponseInvalidEmail => "à¸—\u0e35\u0e48à¸­à¸¢\u0e39\u0e48à¸­\u0e35à¹€à¸¡à¸¥à¹„à¸¡\u0e48à¸–\u0e39à¸à¸•\u0e49à¸­à¸‡";

	/// <summary>
	/// Key: "Response.JavaScriptRequired"
	/// error to show that JavaScipt is required for the form to work
	/// English String: "JavaScript is required to submit this form."
	/// </summary>
	public override string ResponseJavaScriptRequired => "à¸ˆà¸³à¹€à¸›\u0e47à¸™à¸•\u0e49à¸­à¸‡à¹ƒà¸Š\u0e49 JavaScript à¹€à¸ž\u0e37\u0e48à¸­à¸ª\u0e48à¸‡à¹à¸šà¸šà¸Ÿà¸­à¸£\u0e4cà¸¡à¸™\u0e35\u0e49";

	/// <summary>
	/// Key: "Response.PasswordComplexity"
	/// English String: "Please create a more complex password."
	/// </summary>
	public override string ResponsePasswordComplexity => "à¸à¸£\u0e38à¸“à¸²à¹€à¸¥\u0e37à¸­à¸à¸£à¸«\u0e31à¸ªà¸œ\u0e48à¸²à¸™à¸—\u0e35\u0e48à¸‹\u0e31à¸šà¸‹\u0e49à¸­à¸™à¸¡à¸²à¸à¸‚\u0e36\u0e49à¸™";

	/// <summary>
	/// Key: "Response.PasswordConfirmation"
	/// validation message for password confirmation
	/// English String: "Please enter a password confirmation."
	/// </summary>
	public override string ResponsePasswordConfirmation => "à¸à¸£\u0e38à¸“à¸²à¸›\u0e49à¸­à¸™à¸£à¸«\u0e31à¸ªà¸œ\u0e48à¸²à¸™à¸¢\u0e37à¸™à¸¢\u0e31à¸™";

	/// <summary>
	/// Key: "Response.PasswordContainsUsernameError"
	/// error when passsword has username in it
	/// English String: "Password shouldn't match username."
	/// </summary>
	public override string ResponsePasswordContainsUsernameError => "à¸£à¸«\u0e31à¸ªà¸œ\u0e48à¸²à¸™à¹„à¸¡\u0e48à¸„à¸§à¸£à¸•à¸£à¸‡à¸\u0e31à¸šà¸Š\u0e37\u0e48à¸­à¸œ\u0e39\u0e49à¹ƒà¸Š\u0e49";

	/// <summary>
	/// Key: "Response.PasswordMismatch"
	/// English String: "Passwords do not match."
	/// </summary>
	public override string ResponsePasswordMismatch => "à¸£à¸«\u0e31à¸ªà¸œ\u0e48à¸²à¸™à¹„à¸¡\u0e48à¸•à¸£à¸‡à¸\u0e31à¸™";

	/// <summary>
	/// Key: "Response.PasswordWrongShort"
	/// English String: "Passwords must be at least 8 characters long."
	/// </summary>
	public override string ResponsePasswordWrongShort => "à¸£à¸«\u0e31à¸ªà¸œ\u0e48à¸²à¸™à¸ˆà¸°à¸•\u0e49à¸­à¸‡à¸¢à¸²à¸§à¸­à¸¢\u0e48à¸²à¸‡à¸™\u0e49à¸­à¸¢ 8 à¸­\u0e31à¸à¸‚à¸£à¸°";

	/// <summary>
	/// Key: "Response.PleaseEnterPassword"
	/// English String: "Please enter a password."
	/// </summary>
	public override string ResponsePleaseEnterPassword => "à¸à¸£\u0e38à¸“à¸²à¸›\u0e49à¸­à¸™à¸£à¸«\u0e31à¸ªà¸œ\u0e48à¸²à¸™";

	/// <summary>
	/// Key: "Response.PleaseEnterUsername"
	/// English String: "Please enter a username."
	/// </summary>
	public override string ResponsePleaseEnterUsername => "à¸à¸£\u0e38à¸“à¸²à¸›\u0e49à¸­à¸™à¸Š\u0e37\u0e48à¸­à¸œ\u0e39\u0e49à¹ƒà¸Š\u0e49";

	/// <summary>
	/// Key: "Response.SocialAccountCreationFailed"
	/// error message
	/// English String: "Account creation failed"
	/// </summary>
	public override string ResponseSocialAccountCreationFailed => "à¸à¸²à¸£à¸ªà¸£\u0e49à¸²à¸‡à¸š\u0e31à¸à¸Š\u0e35à¸¥\u0e49à¸¡à¹€à¸«à¸¥à¸§";

	/// <summary>
	/// Key: "Response.SpaceOrSpecialCharaterError"
	/// Spaces and special characters are not allowed error message
	/// English String: "Spaces and special characters are not allowed."
	/// </summary>
	public override string ResponseSpaceOrSpecialCharaterError => "à¹„à¸¡\u0e48à¸­à¸™\u0e38à¸à¸²à¸•à¹ƒà¸«\u0e49à¹ƒà¸Š\u0e49à¸Š\u0e48à¸­à¸‡à¸§\u0e48à¸²à¸‡à¹à¸¥à¸°à¸­\u0e31à¸à¸‚à¸£à¸°à¸ž\u0e34à¹€à¸¨à¸©";

	/// <summary>
	/// Key: "Response.TooManyAccountsWithSameEmailError"
	/// Too many accounts use this email error message
	/// English String: "Too many accounts use this email."
	/// </summary>
	public override string ResponseTooManyAccountsWithSameEmailError => "à¸¡\u0e35à¸š\u0e31à¸à¸Š\u0e35à¸—\u0e35\u0e48à¹ƒà¸Š\u0e49à¸‡à¸²à¸™à¸­\u0e35à¹€à¸¡à¸¥à¸™\u0e35\u0e49à¸¡à¸²à¸à¹€à¸\u0e34à¸™à¹„à¸›";

	/// <summary>
	/// Key: "Response.UnknownError"
	/// English String: "Sorry! An unknown error occurred. Please try again later."
	/// </summary>
	public override string ResponseUnknownError => "à¸‚à¸­à¸­à¸ \u0e31à¸¢! à¹€à¸\u0e34à¸”à¸‚\u0e49à¸­à¸œ\u0e34à¸”à¸žà¸¥à¸²à¸”à¸—\u0e35\u0e48à¹„à¸¡\u0e48à¸—à¸£à¸²à¸šà¸ªà¸²à¹€à¸«à¸•\u0e38 à¸à¸£\u0e38à¸“à¸²à¸¥à¸­à¸‡à¹ƒà¸«à¸¡\u0e48à¸­\u0e35à¸à¸„à¸£\u0e31\u0e49à¸‡à¹ƒà¸™à¸ à¸²à¸¢à¸«à¸¥\u0e31à¸‡";

	/// <summary>
	/// Key: "Response.UsernameAllowedCharactersError"
	/// error showing which characters are allowed for username
	/// English String: "Usernames may only contain letters, numbers, and _."
	/// </summary>
	public override string ResponseUsernameAllowedCharactersError => "à¸Š\u0e37\u0e48à¸­à¸œ\u0e39\u0e49à¹ƒà¸Š\u0e49à¸ªà¸²à¸¡à¸²à¸£à¸–à¸¡\u0e35à¹„à¸”\u0e49à¹€à¸ž\u0e35à¸¢à¸‡à¸•\u0e31à¸§à¸­\u0e31à¸à¸©à¸£, à¸•\u0e31à¸§à¹€à¸¥à¸‚ à¹à¸¥à¸°_";

	/// <summary>
	/// Key: "Response.UsernameAlreadyInUse"
	/// English String: "This username is already in use."
	/// </summary>
	public override string ResponseUsernameAlreadyInUse => "à¸¡\u0e35à¸à¸²à¸£à¹ƒà¸Š\u0e49à¸‡à¸²à¸™à¸Š\u0e37\u0e48à¸­à¸œ\u0e39\u0e49à¹ƒà¸Š\u0e49à¸™\u0e35\u0e49à¹„à¸›à¹à¸¥\u0e49à¸§";

	/// <summary>
	/// Key: "Response.UsernameExplicit"
	/// English String: "This username is not allowed, please try another."
	/// </summary>
	public override string ResponseUsernameExplicit => "à¹„à¸¡\u0e48à¹„à¸”\u0e49à¸£\u0e31à¸šà¸­à¸™\u0e38à¸à¸²à¸•à¹ƒà¸«\u0e49à¹ƒà¸Š\u0e49à¸Š\u0e37\u0e48à¸­à¸œ\u0e39\u0e49à¹ƒà¸Š\u0e49à¸™\u0e35\u0e49 à¸à¸£\u0e38à¸“à¸²à¸¥à¸­à¸‡à¸Š\u0e37\u0e48à¸­à¸­\u0e37\u0e48à¸™";

	/// <summary>
	/// Key: "Response.UsernameInvalid"
	/// English String: "Please enter a valid username."
	/// </summary>
	public override string ResponseUsernameInvalid => "à¸à¸£\u0e38à¸“à¸²à¸›\u0e49à¸­à¸™à¸Š\u0e37\u0e48à¸­à¸œ\u0e39\u0e49à¹ƒà¸Š\u0e49à¸—\u0e35\u0e48à¸–\u0e39à¸à¸•\u0e49à¸­à¸‡";

	/// <summary>
	/// Key: "Response.UsernameInvalidCharacters"
	/// English String: "Only a-z, A-Z, 0-9 and _ are allowed."
	/// </summary>
	public override string ResponseUsernameInvalidCharacters => "à¸­à¸™\u0e38à¸à¸²à¸•à¹ƒà¸«\u0e49à¸¡\u0e35à¹€à¸ž\u0e35à¸¢à¸‡à¹à¸„\u0e48 aâ€“z, Aâ€“Z, 0-9 à¹à¸¥à¸° _ à¹€à¸—\u0e48à¸²à¸™\u0e31\u0e49à¸™";

	/// <summary>
	/// Key: "Response.UsernameInvalidLength"
	/// English String: "Usernames can be 3 to 20 characters long."
	/// </summary>
	public override string ResponseUsernameInvalidLength => "à¸Š\u0e37\u0e48à¸­à¸œ\u0e39\u0e49à¹ƒà¸Š\u0e49à¸ªà¸²à¸¡à¸²à¸£à¸–à¸¡\u0e35à¸„à¸§à¸²à¸¡à¸¢à¸²à¸§à¹„à¸”\u0e49à¸£à¸°à¸«à¸§\u0e48à¸²à¸‡ 3 à¸–\u0e36à¸‡ 20 à¸­\u0e31à¸à¸‚à¸£à¸°";

	/// <summary>
	/// Key: "Response.UsernameInvalidUnderscore"
	/// English String: "Usernames cannot start or end with _."
	/// </summary>
	public override string ResponseUsernameInvalidUnderscore => "à¸Š\u0e37\u0e48à¸­à¸œ\u0e39\u0e49à¹ƒà¸Š\u0e49à¹„à¸¡\u0e48à¸ªà¸²à¸¡à¸²à¸£à¸–à¹€à¸£\u0e34\u0e48à¸¡à¸•\u0e49à¸™à¸«à¸£\u0e37à¸­à¸¥à¸‡à¸—\u0e49à¸²à¸¢à¸”\u0e49à¸§à¸¢ _ à¹„à¸”\u0e49";

	/// <summary>
	/// Key: "Response.UsernameNotAvailable"
	/// English String: "Username not available. Please try again."
	/// </summary>
	public override string ResponseUsernameNotAvailable => "à¸Š\u0e37\u0e48à¸­à¸œ\u0e39\u0e49à¹ƒà¸Š\u0e49à¹„à¸¡\u0e48à¸žà¸£\u0e49à¸­à¸¡ à¸à¸£\u0e38à¸“à¸²à¸¥à¸­à¸‡à¹ƒà¸«à¸¡\u0e48à¸­\u0e35à¸à¸„à¸£\u0e31\u0e49à¸‡";

	/// <summary>
	/// Key: "Response.UsernameOrPasswordIncorrect"
	/// Your username or password is incorrect
	/// English String: "Your username or password is incorrect."
	/// </summary>
	public override string ResponseUsernameOrPasswordIncorrect => "à¸Š\u0e37\u0e48à¸­à¸œ\u0e39\u0e49à¹ƒà¸Š\u0e49à¸«à¸£\u0e37à¸­à¸£à¸«\u0e31à¸ªà¸œ\u0e48à¸²à¸™à¸‚à¸­à¸‡à¸„\u0e38à¸“à¹„à¸¡\u0e48à¸–\u0e39à¸à¸•\u0e49à¸­à¸‡";

	/// <summary>
	/// Key: "Response.UsernamePasswordRequired"
	/// Username and Password are required error message
	/// English String: "Username and Password are required."
	/// </summary>
	public override string ResponseUsernamePasswordRequired => "à¸ˆà¸³à¹€à¸›\u0e47à¸™à¸•\u0e49à¸­à¸‡à¸¡\u0e35à¸Š\u0e37\u0e48à¸­à¸œ\u0e39\u0e49à¹ƒà¸Š\u0e49à¹à¸¥à¸°à¸£à¸«\u0e31à¸ªà¸œ\u0e48à¸²à¸™";

	/// <summary>
	/// Key: "Response.UsernamePrivateInfo"
	/// English String: "Username might contain private information."
	/// </summary>
	public override string ResponseUsernamePrivateInfo => "à¸Š\u0e37\u0e48à¸­à¸œ\u0e39\u0e49à¹ƒà¸Š\u0e49à¸­à¸²à¸ˆà¸¡\u0e35à¸‚\u0e49à¸­à¸¡\u0e39à¸¥à¸ª\u0e48à¸§à¸™à¸•\u0e31à¸§";

	/// <summary>
	/// Key: "Response.UsernameRequired"
	/// validation error message
	/// English String: "Username is required."
	/// </summary>
	public override string ResponseUsernameRequired => "à¸ˆà¸³à¹€à¸›\u0e47à¸™à¸•\u0e49à¸­à¸‡à¸£à¸°à¸š\u0e38à¸Š\u0e37\u0e48à¸­à¸œ\u0e39\u0e49à¹ƒà¸Š\u0e49";

	/// <summary>
	/// Key: "Response.UsernameTakenTryAgain"
	/// English String: "This username is already taken! Please try a different one."
	/// </summary>
	public override string ResponseUsernameTakenTryAgain => "à¸Š\u0e37\u0e48à¸­à¸œ\u0e39\u0e49à¹ƒà¸Š\u0e49à¸™\u0e35\u0e49à¸–\u0e39à¸à¸™à¸³à¹„à¸›à¹ƒà¸Š\u0e49à¸‡à¸²à¸™à¹à¸¥\u0e49à¸§! à¸à¸£\u0e38à¸“à¸²à¹€à¸¥\u0e37à¸­à¸à¸Š\u0e37\u0e48à¸­à¸­\u0e37\u0e48à¸™";

	/// <summary>
	/// Key: "Response.UsernameTooManyUnderscores"
	/// English String: "Usernames can have at most one _."
	/// </summary>
	public override string ResponseUsernameTooManyUnderscores => "à¸Š\u0e37\u0e48à¸­à¸œ\u0e39\u0e49à¹ƒà¸Š\u0e49à¸ªà¸²à¸¡à¸²à¸£à¸–à¸¡\u0e35 _ à¹„à¸”\u0e49à¸ª\u0e39à¸‡à¸ª\u0e38à¸”à¸«à¸™\u0e36\u0e48à¸‡à¸•\u0e31à¸§";

	public SignUpResources_th_th(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionCreateAccount()
	{
		return "à¸ªà¸£\u0e49à¸²à¸‡à¸š\u0e31à¸à¸Š\u0e35";
	}

	protected override string _GetTemplateForActionLinkAccount()
	{
		return "à¹€à¸Š\u0e37\u0e48à¸­à¸¡à¹‚à¸¢à¸‡à¸š\u0e31à¸à¸Š\u0e35";
	}

	protected override string _GetTemplateForActionLogInCapitalized()
	{
		return "à¹€à¸‚\u0e49à¸²à¸ª\u0e39\u0e48à¸£à¸°à¸šà¸š";
	}

	protected override string _GetTemplateForActionReturnHome()
	{
		return "à¸à¸¥\u0e31à¸šà¹„à¸›à¸«à¸™\u0e49à¸²à¸«à¸¥\u0e31à¸";
	}

	protected override string _GetTemplateForActionSignUp()
	{
		return "à¸ªà¸¡\u0e31à¸„à¸£à¸š\u0e31à¸à¸Š\u0e35";
	}

	protected override string _GetTemplateForActionSignupAndSync()
	{
		return "à¸ªà¸¡\u0e31à¸„à¸£à¸š\u0e31à¸à¸Š\u0e35à¸œ\u0e39\u0e49à¹ƒà¸Š\u0e49 à¹à¸¥\u0e49à¸§à¸‹\u0e34à¸‡à¸„\u0e4cà¸‚\u0e49à¸­à¸¡\u0e39à¸¥";
	}

	protected override string _GetTemplateForActionSubmit()
	{
		return "à¸ª\u0e48à¸‡";
	}

	protected override string _GetTemplateForDescriptionAccountLinkingWarning()
	{
		return "à¸à¸£\u0e38à¸“à¸²à¸¥à¸‡à¸Š\u0e37\u0e48à¸­à¹€à¸‚\u0e49à¸²à¸ª\u0e39\u0e48à¸š\u0e31à¸à¸Š\u0e35 Roblox à¸—\u0e35\u0e48à¸¡\u0e35à¸­à¸¢\u0e39\u0e48à¹à¸¥\u0e49à¸§à¹€à¸ž\u0e37\u0e48à¸­à¸—à¸³à¸à¸²à¸£à¹€à¸Š\u0e37\u0e48à¸­à¸¡à¹‚à¸¢à¸‡à¸—\u0e35\u0e48à¸«à¸™\u0e49à¸²à¸à¸²à¸£à¸•\u0e31\u0e49à¸‡à¸„\u0e48à¸²à¸š\u0e31à¸à¸Š\u0e35";
	}

	protected override string _GetTemplateForDescriptionNoRealName()
	{
		return "à¸«\u0e49à¸²à¸¡à¹ƒà¸Š\u0e49à¸Š\u0e37\u0e48à¸­à¸ˆà¸£\u0e34à¸‡à¸‚à¸­à¸‡à¸„\u0e38à¸“";
	}

	protected override string _GetTemplateForDescriptionPrivacyPolicy()
	{
		return "à¸™à¹‚à¸¢à¸šà¸²à¸¢à¸„à¸§à¸²à¸¡à¹€à¸›\u0e47à¸™à¸ª\u0e48à¸§à¸™à¸•\u0e31à¸§";
	}

	/// <summary>
	/// Key: "Description.SignUpAgreement"
	/// terms of use agreement checkbox label to signup.
	/// English String: "By clicking {spanStart}Sign Up{spanEnd}, you are agreeing to the {termsOfUseLink} and acknowledging the {privacyPolicyLink}"
	/// </summary>
	public override string DescriptionSignUpAgreement(string spanStart, string spanEnd, string termsOfUseLink, string privacyPolicyLink)
	{
		return $"à¸à¸²à¸£à¸„à¸¥\u0e34à¸à¸—\u0e35\u0e48{spanStart}à¸ªà¸¡\u0e31à¸„à¸£à¸š\u0e31à¸à¸Š\u0e35à¸œ\u0e39\u0e49à¹ƒà¸Š\u0e49{spanEnd} à¸ˆà¸°à¸–\u0e37à¸­à¸§\u0e48à¸²à¸„\u0e38à¸“à¸¢à¸­à¸¡à¸£\u0e31à¸š {termsOfUseLink} à¹à¸¥à¸°à¸£\u0e31à¸šà¸—à¸£à¸²à¸šà¸–\u0e36à¸‡ {privacyPolicyLink}";
	}

	protected override string _GetTemplateForDescriptionSignUpAgreement()
	{
		return "à¸à¸²à¸£à¸„à¸¥\u0e34à¸à¸—\u0e35\u0e48{spanStart}à¸ªà¸¡\u0e31à¸„à¸£à¸š\u0e31à¸à¸Š\u0e35à¸œ\u0e39\u0e49à¹ƒà¸Š\u0e49{spanEnd} à¸ˆà¸°à¸–\u0e37à¸­à¸§\u0e48à¸²à¸„\u0e38à¸“à¸¢à¸­à¸¡à¸£\u0e31à¸š {termsOfUseLink} à¹à¸¥à¸°à¸£\u0e31à¸šà¸—à¸£à¸²à¸šà¸–\u0e36à¸‡ {privacyPolicyLink}";
	}

	protected override string _GetTemplateForDescriptionTermsOfService()
	{
		return "à¹€à¸‡\u0e37\u0e48à¸­à¸™à¹„à¸‚à¸à¸²à¸£à¹ƒà¸«\u0e49à¸šà¸£\u0e34à¸à¸²à¸£";
	}

	protected override string _GetTemplateForGuestSignUpABActionSignUp()
	{
		return "à¸ªà¸¡\u0e31à¸„à¸£à¸š\u0e31à¸à¸Š\u0e35à¸œ\u0e39\u0e49à¹ƒà¸Š\u0e49";
	}

	protected override string _GetTemplateForHeadingConnectFacebook()
	{
		return "à¹€à¸Š\u0e37\u0e48à¸­à¸¡à¸•\u0e48à¸­à¸\u0e31à¸š Facebook";
	}

	protected override string _GetTemplateForHeadingCreateAnAccount()
	{
		return "à¸ªà¸£\u0e49à¸²à¸‡à¸š\u0e31à¸à¸Š\u0e35";
	}

	/// <summary>
	/// Key: "Heading.FacebookSignupAlmostDone"
	/// when user signs up using Facebook, this is shown in next step to create a password.
	/// English String: "{firstname}, YOU'RE ALMOST DONE"
	/// </summary>
	public override string HeadingFacebookSignupAlmostDone(string firstname)
	{
		return $"{firstname} à¸„\u0e38à¸“à¸”à¸³à¹€à¸™\u0e34à¸™à¸à¸²à¸£à¹€à¸\u0e37à¸­à¸šà¹€à¸ªà¸£\u0e47à¸ˆà¹à¸¥\u0e49à¸§";
	}

	protected override string _GetTemplateForHeadingFacebookSignupAlmostDone()
	{
		return "{firstname} à¸„\u0e38à¸“à¸”à¸³à¹€à¸™\u0e34à¸™à¸à¸²à¸£à¹€à¸\u0e37à¸­à¸šà¹€à¸ªà¸£\u0e47à¸ˆà¹à¸¥\u0e49à¸§";
	}

	protected override string _GetTemplateForHeadingLoginHaveFun()
	{
		return "à¹€à¸‚\u0e49à¸²à¸ª\u0e39\u0e48à¸£à¸°à¸šà¸š à¹à¸¥\u0e49à¸§à¹€à¸£\u0e34\u0e48à¸¡à¸ªà¸™\u0e38à¸à¸\u0e31à¸™à¹„à¸”\u0e49à¹€à¸¥à¸¢!";
	}

	protected override string _GetTemplateForHeadingSignupHaveFun()
	{
		return "à¸ªà¸¡\u0e31à¸„à¸£à¸š\u0e31à¸à¸Š\u0e35à¸œ\u0e39\u0e49à¹ƒà¸Š\u0e49 à¹à¸¥\u0e49à¸§à¹€à¸£\u0e34\u0e48à¸¡à¸ªà¸™\u0e38à¸à¸\u0e31à¸™à¹„à¸”\u0e49à¹€à¸¥à¸¢!";
	}

	protected override string _GetTemplateForLabelAbout()
	{
		return "à¹€à¸\u0e35\u0e48à¸¢à¸§à¸\u0e31à¸š";
	}

	protected override string _GetTemplateForLabelAlreadyHaveRobloxAccount()
	{
		return "à¸¡\u0e35à¸š\u0e31à¸à¸Š\u0e35 Roblox à¸­à¸¢\u0e39\u0e48à¹à¸¥\u0e49à¸§?";
	}

	protected override string _GetTemplateForLabelAlreadyRegistered()
	{
		return "à¹€à¸„à¸¢à¸¥à¸‡à¸—à¸°à¹€à¸š\u0e35à¸¢à¸™à¸­à¸¢\u0e39\u0e48à¹à¸¥\u0e49à¸§?";
	}

	protected override string _GetTemplateForLabelBirthday()
	{
		return "à¸§\u0e31à¸™à¹€à¸\u0e34à¸”";
	}

	protected override string _GetTemplateForLabelBirthdayWithColumn()
	{
		return "à¸§\u0e31à¸™à¹€à¸\u0e34à¸”:";
	}

	protected override string _GetTemplateForLabelConfirmPassword()
	{
		return "à¸¢\u0e37à¸™à¸¢\u0e31à¸™à¸£à¸«\u0e31à¸ªà¸œ\u0e48à¸²à¸™";
	}

	protected override string _GetTemplateForLabelDay()
	{
		return "à¸§\u0e31à¸™";
	}

	protected override string _GetTemplateForLabelDesiredUsername()
	{
		return "à¸Š\u0e37\u0e48à¸­à¸œ\u0e39\u0e49à¹ƒà¸Š\u0e49à¸—\u0e35\u0e48à¸•\u0e49à¸­à¸‡à¸à¸²à¸£:";
	}

	protected override string _GetTemplateForLabelFacebookNotLinked()
	{
		return "à¸š\u0e31à¸à¸Š\u0e35 Facebook à¸‚à¸­à¸‡à¸„\u0e38à¸“à¹„à¸¡\u0e48à¹„à¸”\u0e49à¹€à¸Š\u0e37\u0e48à¸­à¸¡à¹‚à¸¢à¸‡à¸\u0e31à¸šà¸š\u0e31à¸à¸Š\u0e35 Roblox à¹ƒà¸”à¹€à¸¥à¸¢ à¸à¸£\u0e38à¸“à¸²à¸ªà¸¡\u0e31à¸„à¸£à¸š\u0e31à¸à¸Š\u0e35 Roblox";
	}

	protected override string _GetTemplateForLabelFacebookSignupUsername()
	{
		return "à¸ªà¸£\u0e49à¸²à¸‡à¸Š\u0e37\u0e48à¸­à¸œ\u0e39\u0e49à¹ƒà¸Š\u0e49 Roblox:";
	}

	protected override string _GetTemplateForLabelFemale()
	{
		return "à¸«à¸\u0e34à¸‡";
	}

	protected override string _GetTemplateForLabelGender()
	{
		return "à¹€à¸žà¸¨";
	}

	protected override string _GetTemplateForLabelGenderRequired()
	{
		return "à¸ˆà¸³à¹€à¸›\u0e47à¸™à¸•\u0e49à¸­à¸‡à¸£à¸°à¸š\u0e38à¹€à¸žà¸¨";
	}

	protected override string _GetTemplateForLabelGenderWithColumn()
	{
		return "à¹€à¸žà¸¨:";
	}

	protected override string _GetTemplateForLabelMale()
	{
		return "à¸Šà¸²à¸¢";
	}

	protected override string _GetTemplateForLabelMonth()
	{
		return "à¹€à¸”\u0e37à¸­à¸™";
	}

	protected override string _GetTemplateForLabelPassword()
	{
		return "à¸£à¸«\u0e31à¸ªà¸œ\u0e48à¸²à¸™";
	}

	protected override string _GetTemplateForLabelPasswordRequirements()
	{
		return "à¸£à¸«\u0e31à¸ªà¸œ\u0e48à¸²à¸™ (à¸¢à¸²à¸§à¸­à¸¢\u0e48à¸²à¸‡à¸™\u0e49à¸­à¸¢ 8)";
	}

	protected override string _GetTemplateForLabelPlatforms()
	{
		return "à¹à¸žà¸¥à¸•à¸Ÿà¸­à¸£\u0e4cà¸¡";
	}

	protected override string _GetTemplateForLabelPlay()
	{
		return "à¹€à¸¥\u0e48à¸™";
	}

	protected override string _GetTemplateForLabelPleaseAgreeToTerms()
	{
		return "à¸à¸£\u0e38à¸“à¸²à¸¢à¸­à¸¡à¸£\u0e31à¸šà¹€à¸‡\u0e37\u0e48à¸­à¸™à¹„à¸‚à¸à¸²à¸£à¹ƒà¸«\u0e49à¸šà¸£\u0e34à¸à¸²à¸£à¹à¸¥à¸°à¸™à¹‚à¸¢à¸šà¸²à¸¢à¸„à¸§à¸²à¸¡à¹€à¸›\u0e47à¸™à¸ª\u0e48à¸§à¸™à¸•\u0e31à¸§à¸‚à¸­à¸‡à¹€à¸£à¸²";
	}

	protected override string _GetTemplateForLabelRequired()
	{
		return "à¸ˆà¸³à¹€à¸›\u0e47à¸™à¸•\u0e49à¸­à¸‡à¸¡\u0e35";
	}

	protected override string _GetTemplateForLabelSignupButtonText()
	{
		return "à¸ªà¸¡\u0e31à¸„à¸£à¹à¸¥\u0e49à¸§à¹€à¸¥\u0e48à¸™à¹€à¸¥à¸¢!";
	}

	protected override string _GetTemplateForLabelSignUpWith()
	{
		return "à¸«à¸£\u0e37à¸­à¸ªà¸¡\u0e31à¸„à¸£à¸š\u0e31à¸à¸Š\u0e35à¸œ\u0e39\u0e49à¹ƒà¸Š\u0e49à¸”\u0e49à¸§à¸¢";
	}

	protected override string _GetTemplateForLabelTermsOfUse()
	{
		return "à¹€à¸‡\u0e37\u0e48à¸­à¸™à¹„à¸‚à¸à¸²à¸£à¹ƒà¸Š\u0e49à¸‡à¸²à¸™";
	}

	protected override string _GetTemplateForLabelUsername()
	{
		return "à¸Š\u0e37\u0e48à¸­à¸œ\u0e39\u0e49à¹ƒà¸Š\u0e49";
	}

	protected override string _GetTemplateForLabelUsernameCharacterLimit()
	{
		return "à¸•\u0e31à¸§à¹€à¸¥à¸‚à¸«à¸£\u0e37à¸­à¸•\u0e31à¸§à¸­\u0e31à¸à¸©à¸£ 3-20 à¸•\u0e31à¸§ à¸«\u0e49à¸²à¸¡à¸¡\u0e35à¹€à¸§\u0e49à¸™à¸§à¸£à¸£à¸„";
	}

	protected override string _GetTemplateForLabelUsernameHint()
	{
		return "à¸Š\u0e37\u0e48à¸­à¸œ\u0e39\u0e49à¹ƒà¸Š\u0e49 (à¸—\u0e35\u0e48à¹„à¸¡\u0e48à¹ƒà¸Š\u0e48à¸Š\u0e37\u0e48à¸­à¸ˆà¸£\u0e34à¸‡à¸‚à¸­à¸‡à¸„\u0e38à¸“)";
	}

	protected override string _GetTemplateForLabelUsernameRequirements()
	{
		return "à¸Š\u0e37\u0e48à¸­à¸œ\u0e39\u0e49à¹ƒà¸Š\u0e49 (à¸„à¸§à¸²à¸¡à¸¢à¸²à¸§ 3-20 à¸­à¸™\u0e38à¸à¸²à¸•à¹ƒà¸«\u0e49à¹ƒà¸Š\u0e49 _)";
	}

	protected override string _GetTemplateForLabelYear()
	{
		return "à¸›\u0e35";
	}

	protected override string _GetTemplateForMessagePasswordMinLength()
	{
		return "à¸¢à¸²à¸§à¸­à¸¢\u0e48à¸²à¸‡à¸™\u0e49à¸­à¸¢ 8";
	}

	protected override string _GetTemplateForMessageUsernameNoRealNameUse()
	{
		return "à¸­à¸¢\u0e48à¸²à¹ƒà¸Š\u0e49à¸Š\u0e37\u0e48à¸­à¸ˆà¸£\u0e34à¸‡à¸‚à¸­à¸‡à¸„\u0e38à¸“";
	}

	protected override string _GetTemplateForResponseBadUsername()
	{
		return "à¸Š\u0e37\u0e48à¸­à¸œ\u0e39\u0e49à¹ƒà¸Š\u0e49à¹„à¸¡\u0e48à¹€à¸«à¸¡à¸²à¸°à¸ªà¸¡à¸ªà¸³à¸«à¸£\u0e31à¸š Roblox";
	}

	protected override string _GetTemplateForResponseBadUsernameForWeChat()
	{
		return "à¸Š\u0e37\u0e48à¸­à¸œ\u0e39\u0e49à¹ƒà¸Š\u0e49à¹„à¸¡\u0e48à¹€à¸«à¸¡à¸²à¸°à¸ªà¸¡";
	}

	protected override string _GetTemplateForResponseBirthdayInvalid()
	{
		return "à¸§\u0e31à¸™à¹€à¸\u0e34à¸”à¸™\u0e35\u0e49à¹„à¸¡\u0e48à¸–\u0e39à¸à¸•\u0e49à¸­à¸‡";
	}

	protected override string _GetTemplateForResponseBirthdayMustBeSetFirst()
	{
		return "à¸ˆà¸°à¸•\u0e49à¸­à¸‡à¸£à¸°à¸š\u0e38à¸§\u0e31à¸™à¹€à¸\u0e34à¸”à¸\u0e48à¸­à¸™";
	}

	protected override string _GetTemplateForResponseCaptchaMismatchError()
	{
		return "à¸„à¸³à¹„à¸¡\u0e48à¸•à¸£à¸‡à¸\u0e31à¸™";
	}

	protected override string _GetTemplateForResponseCaptchaNotEnteredError()
	{
		return "à¸à¸£\u0e38à¸“à¸²à¸›\u0e49à¸­à¸™ Captcha";
	}

	protected override string _GetTemplateForResponseFacebookConnectionError()
	{
		return "à¹€à¸\u0e34à¸”à¸‚\u0e49à¸­à¸œ\u0e34à¸”à¸žà¸¥à¸²à¸”à¸‚à¸“à¸°à¸žà¸¢à¸²à¸¢à¸²à¸¡à¸”\u0e36à¸‡à¸‚\u0e49à¸­à¸¡\u0e39à¸¥à¸‚à¸­à¸‡à¸„\u0e38à¸“à¸ˆà¸²à¸ Facebook";
	}

	protected override string _GetTemplateForResponseFacebookLoginAge()
	{
		return "à¸à¸²à¸£à¹€à¸‚\u0e49à¸²à¸ª\u0e39\u0e48à¸£à¸°à¸šà¸š Facebook à¸ˆà¸°à¸ªà¸²à¸¡à¸²à¸£à¸–à¹ƒà¸Š\u0e49à¸‡à¸²à¸™à¹„à¸”\u0e49à¹‚à¸”à¸¢à¸œ\u0e39\u0e49à¹ƒà¸Š\u0e49à¸­à¸²à¸¢\u0e38 13 à¸›\u0e35à¸‚\u0e36\u0e49à¸™à¹„à¸›à¹€à¸—\u0e48à¸²à¸™\u0e31\u0e49à¸™";
	}

	protected override string _GetTemplateForResponseInvalidBirthday()
	{
		return "à¸§\u0e31à¸™à¹€à¸\u0e34à¸”à¹„à¸¡\u0e48à¸–\u0e39à¸à¸•\u0e49à¸­à¸‡";
	}

	protected override string _GetTemplateForResponseInvalidEmail()
	{
		return "à¸—\u0e35\u0e48à¸­à¸¢\u0e39\u0e48à¸­\u0e35à¹€à¸¡à¸¥à¹„à¸¡\u0e48à¸–\u0e39à¸à¸•\u0e49à¸­à¸‡";
	}

	protected override string _GetTemplateForResponseJavaScriptRequired()
	{
		return "à¸ˆà¸³à¹€à¸›\u0e47à¸™à¸•\u0e49à¸­à¸‡à¹ƒà¸Š\u0e49 JavaScript à¹€à¸ž\u0e37\u0e48à¸­à¸ª\u0e48à¸‡à¹à¸šà¸šà¸Ÿà¸­à¸£\u0e4cà¸¡à¸™\u0e35\u0e49";
	}

	protected override string _GetTemplateForResponsePasswordComplexity()
	{
		return "à¸à¸£\u0e38à¸“à¸²à¹€à¸¥\u0e37à¸­à¸à¸£à¸«\u0e31à¸ªà¸œ\u0e48à¸²à¸™à¸—\u0e35\u0e48à¸‹\u0e31à¸šà¸‹\u0e49à¸­à¸™à¸¡à¸²à¸à¸‚\u0e36\u0e49à¸™";
	}

	protected override string _GetTemplateForResponsePasswordConfirmation()
	{
		return "à¸à¸£\u0e38à¸“à¸²à¸›\u0e49à¸­à¸™à¸£à¸«\u0e31à¸ªà¸œ\u0e48à¸²à¸™à¸¢\u0e37à¸™à¸¢\u0e31à¸™";
	}

	protected override string _GetTemplateForResponsePasswordContainsUsernameError()
	{
		return "à¸£à¸«\u0e31à¸ªà¸œ\u0e48à¸²à¸™à¹„à¸¡\u0e48à¸„à¸§à¸£à¸•à¸£à¸‡à¸\u0e31à¸šà¸Š\u0e37\u0e48à¸­à¸œ\u0e39\u0e49à¹ƒà¸Š\u0e49";
	}

	protected override string _GetTemplateForResponsePasswordMismatch()
	{
		return "à¸£à¸«\u0e31à¸ªà¸œ\u0e48à¸²à¸™à¹„à¸¡\u0e48à¸•à¸£à¸‡à¸\u0e31à¸™";
	}

	protected override string _GetTemplateForResponsePasswordWrongShort()
	{
		return "à¸£à¸«\u0e31à¸ªà¸œ\u0e48à¸²à¸™à¸ˆà¸°à¸•\u0e49à¸­à¸‡à¸¢à¸²à¸§à¸­à¸¢\u0e48à¸²à¸‡à¸™\u0e49à¸­à¸¢ 8 à¸­\u0e31à¸à¸‚à¸£à¸°";
	}

	protected override string _GetTemplateForResponsePleaseEnterPassword()
	{
		return "à¸à¸£\u0e38à¸“à¸²à¸›\u0e49à¸­à¸™à¸£à¸«\u0e31à¸ªà¸œ\u0e48à¸²à¸™";
	}

	protected override string _GetTemplateForResponsePleaseEnterUsername()
	{
		return "à¸à¸£\u0e38à¸“à¸²à¸›\u0e49à¸­à¸™à¸Š\u0e37\u0e48à¸­à¸œ\u0e39\u0e49à¹ƒà¸Š\u0e49";
	}

	protected override string _GetTemplateForResponseSocialAccountCreationFailed()
	{
		return "à¸à¸²à¸£à¸ªà¸£\u0e49à¸²à¸‡à¸š\u0e31à¸à¸Š\u0e35à¸¥\u0e49à¸¡à¹€à¸«à¸¥à¸§";
	}

	protected override string _GetTemplateForResponseSpaceOrSpecialCharaterError()
	{
		return "à¹„à¸¡\u0e48à¸­à¸™\u0e38à¸à¸²à¸•à¹ƒà¸«\u0e49à¹ƒà¸Š\u0e49à¸Š\u0e48à¸­à¸‡à¸§\u0e48à¸²à¸‡à¹à¸¥à¸°à¸­\u0e31à¸à¸‚à¸£à¸°à¸ž\u0e34à¹€à¸¨à¸©";
	}

	protected override string _GetTemplateForResponseTooManyAccountsWithSameEmailError()
	{
		return "à¸¡\u0e35à¸š\u0e31à¸à¸Š\u0e35à¸—\u0e35\u0e48à¹ƒà¸Š\u0e49à¸‡à¸²à¸™à¸­\u0e35à¹€à¸¡à¸¥à¸™\u0e35\u0e49à¸¡à¸²à¸à¹€à¸\u0e34à¸™à¹„à¸›";
	}

	protected override string _GetTemplateForResponseUnknownError()
	{
		return "à¸‚à¸­à¸­à¸ \u0e31à¸¢! à¹€à¸\u0e34à¸”à¸‚\u0e49à¸­à¸œ\u0e34à¸”à¸žà¸¥à¸²à¸”à¸—\u0e35\u0e48à¹„à¸¡\u0e48à¸—à¸£à¸²à¸šà¸ªà¸²à¹€à¸«à¸•\u0e38 à¸à¸£\u0e38à¸“à¸²à¸¥à¸­à¸‡à¹ƒà¸«à¸¡\u0e48à¸­\u0e35à¸à¸„à¸£\u0e31\u0e49à¸‡à¹ƒà¸™à¸ à¸²à¸¢à¸«à¸¥\u0e31à¸‡";
	}

	protected override string _GetTemplateForResponseUsernameAllowedCharactersError()
	{
		return "à¸Š\u0e37\u0e48à¸­à¸œ\u0e39\u0e49à¹ƒà¸Š\u0e49à¸ªà¸²à¸¡à¸²à¸£à¸–à¸¡\u0e35à¹„à¸”\u0e49à¹€à¸ž\u0e35à¸¢à¸‡à¸•\u0e31à¸§à¸­\u0e31à¸à¸©à¸£, à¸•\u0e31à¸§à¹€à¸¥à¸‚ à¹à¸¥à¸°_";
	}

	protected override string _GetTemplateForResponseUsernameAlreadyInUse()
	{
		return "à¸¡\u0e35à¸à¸²à¸£à¹ƒà¸Š\u0e49à¸‡à¸²à¸™à¸Š\u0e37\u0e48à¸­à¸œ\u0e39\u0e49à¹ƒà¸Š\u0e49à¸™\u0e35\u0e49à¹„à¸›à¹à¸¥\u0e49à¸§";
	}

	protected override string _GetTemplateForResponseUsernameExplicit()
	{
		return "à¹„à¸¡\u0e48à¹„à¸”\u0e49à¸£\u0e31à¸šà¸­à¸™\u0e38à¸à¸²à¸•à¹ƒà¸«\u0e49à¹ƒà¸Š\u0e49à¸Š\u0e37\u0e48à¸­à¸œ\u0e39\u0e49à¹ƒà¸Š\u0e49à¸™\u0e35\u0e49 à¸à¸£\u0e38à¸“à¸²à¸¥à¸­à¸‡à¸Š\u0e37\u0e48à¸­à¸­\u0e37\u0e48à¸™";
	}

	protected override string _GetTemplateForResponseUsernameInvalid()
	{
		return "à¸à¸£\u0e38à¸“à¸²à¸›\u0e49à¸­à¸™à¸Š\u0e37\u0e48à¸­à¸œ\u0e39\u0e49à¹ƒà¸Š\u0e49à¸—\u0e35\u0e48à¸–\u0e39à¸à¸•\u0e49à¸­à¸‡";
	}

	protected override string _GetTemplateForResponseUsernameInvalidCharacters()
	{
		return "à¸­à¸™\u0e38à¸à¸²à¸•à¹ƒà¸«\u0e49à¸¡\u0e35à¹€à¸ž\u0e35à¸¢à¸‡à¹à¸„\u0e48 aâ€“z, Aâ€“Z, 0-9 à¹à¸¥à¸° _ à¹€à¸—\u0e48à¸²à¸™\u0e31\u0e49à¸™";
	}

	protected override string _GetTemplateForResponseUsernameInvalidLength()
	{
		return "à¸Š\u0e37\u0e48à¸­à¸œ\u0e39\u0e49à¹ƒà¸Š\u0e49à¸ªà¸²à¸¡à¸²à¸£à¸–à¸¡\u0e35à¸„à¸§à¸²à¸¡à¸¢à¸²à¸§à¹„à¸”\u0e49à¸£à¸°à¸«à¸§\u0e48à¸²à¸‡ 3 à¸–\u0e36à¸‡ 20 à¸­\u0e31à¸à¸‚à¸£à¸°";
	}

	protected override string _GetTemplateForResponseUsernameInvalidUnderscore()
	{
		return "à¸Š\u0e37\u0e48à¸­à¸œ\u0e39\u0e49à¹ƒà¸Š\u0e49à¹„à¸¡\u0e48à¸ªà¸²à¸¡à¸²à¸£à¸–à¹€à¸£\u0e34\u0e48à¸¡à¸•\u0e49à¸™à¸«à¸£\u0e37à¸­à¸¥à¸‡à¸—\u0e49à¸²à¸¢à¸”\u0e49à¸§à¸¢ _ à¹„à¸”\u0e49";
	}

	protected override string _GetTemplateForResponseUsernameNotAvailable()
	{
		return "à¸Š\u0e37\u0e48à¸­à¸œ\u0e39\u0e49à¹ƒà¸Š\u0e49à¹„à¸¡\u0e48à¸žà¸£\u0e49à¸­à¸¡ à¸à¸£\u0e38à¸“à¸²à¸¥à¸­à¸‡à¹ƒà¸«à¸¡\u0e48à¸­\u0e35à¸à¸„à¸£\u0e31\u0e49à¸‡";
	}

	protected override string _GetTemplateForResponseUsernameOrPasswordIncorrect()
	{
		return "à¸Š\u0e37\u0e48à¸­à¸œ\u0e39\u0e49à¹ƒà¸Š\u0e49à¸«à¸£\u0e37à¸­à¸£à¸«\u0e31à¸ªà¸œ\u0e48à¸²à¸™à¸‚à¸­à¸‡à¸„\u0e38à¸“à¹„à¸¡\u0e48à¸–\u0e39à¸à¸•\u0e49à¸­à¸‡";
	}

	protected override string _GetTemplateForResponseUsernamePasswordRequired()
	{
		return "à¸ˆà¸³à¹€à¸›\u0e47à¸™à¸•\u0e49à¸­à¸‡à¸¡\u0e35à¸Š\u0e37\u0e48à¸­à¸œ\u0e39\u0e49à¹ƒà¸Š\u0e49à¹à¸¥à¸°à¸£à¸«\u0e31à¸ªà¸œ\u0e48à¸²à¸™";
	}

	protected override string _GetTemplateForResponseUsernamePrivateInfo()
	{
		return "à¸Š\u0e37\u0e48à¸­à¸œ\u0e39\u0e49à¹ƒà¸Š\u0e49à¸­à¸²à¸ˆà¸¡\u0e35à¸‚\u0e49à¸­à¸¡\u0e39à¸¥à¸ª\u0e48à¸§à¸™à¸•\u0e31à¸§";
	}

	protected override string _GetTemplateForResponseUsernameRequired()
	{
		return "à¸ˆà¸³à¹€à¸›\u0e47à¸™à¸•\u0e49à¸­à¸‡à¸£à¸°à¸š\u0e38à¸Š\u0e37\u0e48à¸­à¸œ\u0e39\u0e49à¹ƒà¸Š\u0e49";
	}

	protected override string _GetTemplateForResponseUsernameTakenTryAgain()
	{
		return "à¸Š\u0e37\u0e48à¸­à¸œ\u0e39\u0e49à¹ƒà¸Š\u0e49à¸™\u0e35\u0e49à¸–\u0e39à¸à¸™à¸³à¹„à¸›à¹ƒà¸Š\u0e49à¸‡à¸²à¸™à¹à¸¥\u0e49à¸§! à¸à¸£\u0e38à¸“à¸²à¹€à¸¥\u0e37à¸­à¸à¸Š\u0e37\u0e48à¸­à¸­\u0e37\u0e48à¸™";
	}

	protected override string _GetTemplateForResponseUsernameTooManyUnderscores()
	{
		return "à¸Š\u0e37\u0e48à¸­à¸œ\u0e39\u0e49à¹ƒà¸Š\u0e49à¸ªà¸²à¸¡à¸²à¸£à¸–à¸¡\u0e35 _ à¹„à¸”\u0e49à¸ª\u0e39à¸‡à¸ª\u0e38à¸”à¸«à¸™\u0e36\u0e48à¸‡à¸•\u0e31à¸§";
	}
}


}
