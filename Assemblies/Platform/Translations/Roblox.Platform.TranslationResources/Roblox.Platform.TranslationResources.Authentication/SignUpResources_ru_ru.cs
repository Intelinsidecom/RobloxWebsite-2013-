namespace Roblox.Platform.TranslationResources.Authentication {
    /// <summary>

/// This class overrides SignUpResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class SignUpResources_ru_ru : SignUpResources_en_us, ISignUpResources, ITranslationResources
{
	/// <summary>
	/// Key: "Action.CreateAccount"
	/// create account button label
	/// English String: "Create Account"
	/// </summary>
	public override string ActionCreateAccount => "Ð¡Ð¾Ð·Ð´Ð°Ñ‚ÑŒ ÑƒÑ‡ÐµÑ‚Ð½ÑƒÑŽ Ð·Ð°Ð¿Ð¸ÑÑŒ";

	/// <summary>
	/// Key: "Action.LinkAccount"
	/// Button text to link 3rd Party Account to a Roblox Account
	/// English String: "Link Account"
	/// </summary>
	public override string ActionLinkAccount => "ÐŸÑ€Ð¸Ð²ÑÐ·Ð°Ñ‚ÑŒ ÑƒÑ‡ÐµÑ‚Ð½ÑƒÑŽ Ð·Ð°Ð¿Ð¸ÑÑŒ";

	/// <summary>
	/// Key: "Action.LogInCapitalized"
	/// button label for capitalized words for Log In
	/// English String: "Log In"
	/// </summary>
	public override string ActionLogInCapitalized => "Ð’Ñ…Ð¾Ð´";

	/// <summary>
	/// Key: "Action.ReturnHome"
	/// button label to return the user to home page
	/// English String: "Return Home"
	/// </summary>
	public override string ActionReturnHome => "Ð”Ð¾Ð¼Ð¾Ð¹";

	/// <summary>
	/// Key: "Action.SignUp"
	/// English String: "Sign up"
	/// </summary>
	public override string ActionSignUp => "Ð ÐµÐ³Ð¸ÑÑ‚Ñ€Ð°Ñ†Ð¸Ñ";

	public override string ActionSignupAndSync => "Ð ÐµÐ³Ð¸ÑÑ‚Ñ€Ð°Ñ†Ð¸Ñ Ð¸ ÑÐ¸Ð½Ñ…Ñ€Ð¾Ð½Ð¸Ð·Ð°Ñ†Ð¸Ñ";

	/// <summary>
	/// Key: "Action.Submit"
	/// English String: "Submit"
	/// </summary>
	public override string ActionSubmit => "ÐžÑ‚Ð¿Ñ€Ð°Ð²Ð¸Ñ‚ÑŒ";

	/// <summary>
	/// Key: "Description.AccountLinkingWarning"
	/// instructions for linking account on signup page for FB based account
	/// English String: "To link to an existing Roblox account, sign in and link them on the account settings page."
	/// </summary>
	public override string DescriptionAccountLinkingWarning => "Ð§Ñ‚Ð¾Ð±Ñ‹ Ð¿Ñ€Ð¸Ð²ÑÐ·Ð°Ñ‚ÑŒ ÑÑƒÑ‰ÐµÑÑ‚Ð²ÑƒÑŽÑ‰ÑƒÑŽ ÑƒÑ‡ÐµÑ‚Ð½ÑƒÑŽ Ð·Ð°Ð¿Ð¸ÑÑŒ Roblox, Ð²Ð¾Ð¹Ð´Ð¸Ñ‚Ðµ Ð¸ Ð¾Ñ‚ÐºÑ€Ð¾Ð¹Ñ‚Ðµ ÑÑ‚Ñ€Ð°Ð½Ð¸Ñ†Ñƒ Ð½Ð°ÑÑ‚Ñ€Ð¾ÐµÐº ÑƒÑ‡ÐµÑ‚Ð½Ð¾Ð¹ Ð·Ð°Ð¿Ð¸ÑÐ¸.";

	/// <summary>
	/// Key: "Description.NoRealName"
	/// description
	/// English String: "Do not use your real name."
	/// </summary>
	public override string DescriptionNoRealName => "ÐÐµ Ð¸ÑÐ¿Ð¾Ð»ÑŒÐ·ÑƒÐ¹Ñ‚Ðµ Ð½Ð°ÑÑ‚Ð¾ÑÑ‰ÐµÐµ Ð¸Ð¼Ñ.";

	/// <summary>
	/// Key: "Description.PrivacyPolicy"
	/// English String: "Privacy Policy"
	/// </summary>
	public override string DescriptionPrivacyPolicy => "ÐŸÐ¾Ð»Ð¸Ñ‚Ð¸ÐºÑƒ ÐºÐ¾Ð½Ñ„Ð¸Ð´ÐµÐ½Ñ†Ð¸Ð°Ð»ÑŒÐ½Ð¾ÑÑ‚Ð¸";

	/// <summary>
	/// Key: "Description.TermsOfService"
	/// English String: "Terms of Service"
	/// </summary>
	public override string DescriptionTermsOfService => "Ð£ÑÐ»Ð¾Ð²Ð¸Ñ Ð¿Ñ€ÐµÐ´Ð¾ÑÑ‚Ð°Ð²Ð»ÐµÐ½Ð¸Ñ ÑƒÑÐ»ÑƒÐ³";

	/// <summary>
	/// Key: "GuestSignUpAB.Action.SignUp"
	/// English String: "Sign Up"
	/// </summary>
	public override string GuestSignUpABActionSignUp => "Ð ÐµÐ³Ð¸ÑÑ‚Ñ€Ð°Ñ†Ð¸Ñ";

	/// <summary>
	/// Key: "Heading.ConnectFacebook"
	/// section heading
	/// English String: "Connect to Facebook"
	/// </summary>
	public override string HeadingConnectFacebook => "ÐŸÐ¾Ð´ÐºÐ»ÑŽÑ‡Ð¸Ñ‚ÑŒÑÑ Ðº Facebook";

	/// <summary>
	/// Key: "Heading.CreateAnAccount"
	/// should be capitalized if the language supports capitalization
	/// English String: "CREATE AN ACCOUNT"
	/// </summary>
	public override string HeadingCreateAnAccount => "Ð¡ÐžÐ—Ð”ÐÐ¢Ð¬ Ð£Ð§Ð•Ð¢ÐÐ£Ð® Ð—ÐÐŸÐ˜Ð¡Ð¬";

	/// <summary>
	/// Key: "Heading.LoginHaveFun"
	/// heading for login container
	/// English String: "Log in and start having fun!"
	/// </summary>
	public override string HeadingLoginHaveFun => "Ð’Ð¾Ð¹Ð´Ð¸Ñ‚Ðµ Ð¸ Ð½Ð°ÑÐ»Ð°Ð¶Ð´Ð°Ð¹Ñ‚ÐµÑÑŒ Ð¸Ð³Ñ€Ð°Ð¼Ð¸!";

	/// <summary>
	/// Key: "Heading.SignupHaveFun"
	/// signup form heading
	/// English String: "Sign up and start having fun!"
	/// </summary>
	public override string HeadingSignupHaveFun => "Ð—Ð°Ñ€ÐµÐ³Ð¸ÑÑ‚Ñ€Ð¸Ñ€ÑƒÐ¹Ñ‚ÐµÑÑŒ Ð¸ Ð½Ð°ÑÐ»Ð°Ð¶Ð´Ð°Ð¹Ñ‚ÐµÑÑŒ Ð¸Ð³Ñ€Ð°Ð¼Ð¸!";

	/// <summary>
	/// Key: "Label.About"
	/// About link on roller coaster page
	/// English String: "About"
	/// </summary>
	public override string LabelAbout => "Ð¡Ð²ÐµÐ´ÐµÐ½Ð¸Ñ";

	/// <summary>
	/// Key: "Label.AlreadyHaveRobloxAccount"
	/// English String: "Already have a Roblox account?"
	/// </summary>
	public override string LabelAlreadyHaveRobloxAccount => "Ð£Ð¶Ðµ ÐµÑÑ‚ÑŒ ÑƒÑ‡ÐµÑ‚Ð½Ð°Ñ Ð·Ð°Ð¿Ð¸ÑÑŒ Roblox?";

	/// <summary>
	/// Key: "Label.AlreadyRegistered"
	/// label
	/// English String: "Already registered?"
	/// </summary>
	public override string LabelAlreadyRegistered => "Ð£Ð¶Ðµ Ð·Ð°Ñ€ÐµÐ³Ð¸ÑÑ‚Ñ€Ð¸Ñ€Ð¾Ð²Ð°Ð½Ñ‹?";

	/// <summary>
	/// Key: "Label.Birthday"
	/// English String: "Birthday"
	/// </summary>
	public override string LabelBirthday => "Ð”Ð°Ñ‚Ð° Ñ€Ð¾Ð¶Ð´ÐµÐ½Ð¸Ñ";

	/// <summary>
	/// Key: "Label.BirthdayWithColumn"
	/// should have column if the language supports it
	/// English String: "Birthday:"
	/// </summary>
	public override string LabelBirthdayWithColumn => "Ð”Ð°Ñ‚Ð° Ñ€Ð¾Ð¶Ð´ÐµÐ½Ð¸Ñ:";

	/// <summary>
	/// Key: "Label.ConfirmPassword"
	/// English String: "Confirm password"
	/// </summary>
	public override string LabelConfirmPassword => "ÐŸÐ¾Ð´Ñ‚Ð²ÐµÑ€Ð¶Ð´ÐµÐ½Ð¸Ðµ Ð¿Ð°Ñ€Ð¾Ð»Ñ";

	/// <summary>
	/// Key: "Label.Day"
	/// English String: "Day"
	/// </summary>
	public override string LabelDay => "Ð”ÐµÐ½ÑŒ";

	/// <summary>
	/// Key: "Label.DesiredUsername"
	/// should have a column if the language supports it
	/// English String: "Desired Username:"
	/// </summary>
	public override string LabelDesiredUsername => "Ð–ÐµÐ»Ð°ÐµÐ¼Ð¾Ðµ Ð¸Ð¼Ñ Ð¿Ð¾Ð»ÑŒÐ·Ð¾Ð²Ð°Ñ‚ÐµÐ»Ñ:";

	/// <summary>
	/// Key: "Label.FacebookNotLinked"
	/// English String: "Your Facebook account is not linked to any Roblox account. Please sign up for a Roblox account."
	/// </summary>
	public override string LabelFacebookNotLinked => "â‚¬Ð’Ð°ÑˆÐ° ÑƒÑ‡ÐµÑ‚Ð½Ð°Ñ Ð·Ð°Ð¿Ð¸ÑÑŒ Facebook Ð½Ðµ Ð¿Ñ€Ð¸Ð²ÑÐ·Ð°Ð½Ð° Ðº Roblox. ÐŸÐ¾Ð¶Ð°Ð»ÑƒÐ¹ÑÑ‚Ð°, Ð¿Ñ€Ð¸Ð²ÑÐ¶Ð¸Ñ‚Ðµ ÐµÐµ Ðº Roblox.";

	/// <summary>
	/// Key: "Label.FacebookSignupUsername"
	/// username field label for FB signup
	/// English String: "Create Roblox username:"
	/// </summary>
	public override string LabelFacebookSignupUsername => "ÐŸÑ€Ð¸Ð´ÑƒÐ¼Ð°Ð¹Ñ‚Ðµ Ð¸Ð¼Ñ Ð¿Ð¾Ð»ÑŒÐ·Ð¾Ð²Ð°Ñ‚ÐµÐ»Ñ Roblox:";

	/// <summary>
	/// Key: "Label.Female"
	/// label
	/// English String: "Female"
	/// </summary>
	public override string LabelFemale => "Ð–ÐµÐ½ÑÐºÐ¸Ð¹";

	/// <summary>
	/// Key: "Label.Gender"
	/// English String: "Gender"
	/// </summary>
	public override string LabelGender => "ÐŸÐ¾Ð»";

	/// <summary>
	/// Key: "Label.GenderRequired"
	/// English String: "Gender is required."
	/// </summary>
	public override string LabelGenderRequired => "Ð¢Ñ€ÐµÐ±ÑƒÐµÑ‚ÑÑ ÑƒÐºÐ°Ð·Ð°Ñ‚ÑŒ Ð¿Ð¾Ð».";

	/// <summary>
	/// Key: "Label.GenderWithColumn"
	/// should have column if the language supports it
	/// English String: "Gender:"
	/// </summary>
	public override string LabelGenderWithColumn => "ÐŸÐ¾Ð»:";

	/// <summary>
	/// Key: "Label.Male"
	/// label
	/// English String: "Male"
	/// </summary>
	public override string LabelMale => "ÐœÑƒÐ¶ÑÐºÐ¾Ð¹";

	/// <summary>
	/// Key: "Label.Month"
	/// English String: "Month"
	/// </summary>
	public override string LabelMonth => "ÐœÐµÑÑÑ†";

	/// <summary>
	/// Key: "Label.Password"
	/// English String: "Password"
	/// </summary>
	public override string LabelPassword => "ÐŸÐ°Ñ€Ð¾Ð»ÑŒ";

	/// <summary>
	/// Key: "Label.PasswordRequirements"
	/// English String: "Password (min length 8)"
	/// </summary>
	public override string LabelPasswordRequirements => "ÐŸÐ°Ñ€Ð¾Ð»ÑŒ (Ð½Ðµ Ð¼ÐµÐ½ÐµÐµ 8 ÑÐ¸Ð¼Ð²Ð¾Ð»Ð¾Ð²)";

	/// <summary>
	/// Key: "Label.Platforms"
	/// platforms link on roller coaster page
	/// English String: "Platforms"
	/// </summary>
	public override string LabelPlatforms => "ÐŸÐ»Ð°Ñ‚Ñ„Ð¾Ñ€Ð¼Ñ‹";

	/// <summary>
	/// Key: "Label.Play"
	/// Play link on roller coaster page
	/// English String: "Play"
	/// </summary>
	public override string LabelPlay => "Ð˜Ð³Ñ€Ð°Ñ‚ÑŒ";

	/// <summary>
	/// Key: "Label.PleaseAgreeToTerms"
	/// English String: "Please agree to our Terms of Use and Privacy Policy."
	/// </summary>
	public override string LabelPleaseAgreeToTerms => "ÐŸÑ€Ð¸Ð¼Ð¸Ñ‚Ðµ Ð½Ð°ÑˆÐ¸ Ð£ÑÐ»Ð¾Ð²Ð¸Ñ Ð¿Ñ€ÐµÐ´Ð¾ÑÑ‚Ð°Ð²Ð»ÐµÐ½Ð¸Ñ ÑƒÑÐ»ÑƒÐ³ Ð¸ ÐŸÐ¾Ð»Ð¸Ñ‚Ð¸ÐºÑƒ ÐºÐ¾Ð½Ñ„Ð¸Ð´ÐµÐ½Ñ†Ð¸Ð°Ð»ÑŒÐ½Ð¾ÑÑ‚Ð¸.";

	/// <summary>
	/// Key: "Label.Required"
	/// Required
	/// English String: "Required"
	/// </summary>
	public override string LabelRequired => "ÐžÐ±ÑÐ·Ð°Ñ‚ÐµÐ»ÑŒÐ½Ð¾";

	/// <summary>
	/// Key: "Label.SignupButtonText"
	/// sign up button text
	/// English String: "Sign Up and Play!"
	/// </summary>
	public override string LabelSignupButtonText => "Ð—Ð°Ñ€ÐµÐ³Ð¸ÑÑ‚Ñ€Ð¸Ñ€ÑƒÐ¹Ñ‚ÐµÑÑŒ Ð¸ Ð¸Ð³Ñ€Ð°Ð¹Ñ‚Ðµ!";

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
	public override string LabelSignUpWith => "Ð¸Ð»Ð¸ Ð²Ð¾Ð¹Ñ‚Ð¸ Ñ Ð¿Ð¾Ð¼Ð¾Ñ‰ÑŒÑŽ";

	/// <summary>
	/// Key: "Label.TermsOfUse"
	/// terms of use link label
	/// English String: "Terms of Use"
	/// </summary>
	public override string LabelTermsOfUse => "Ð£ÑÐ»Ð¾Ð²Ð¸Ñ Ð¸ÑÐ¿Ð¾Ð»ÑŒÐ·Ð¾Ð²Ð°Ð½Ð¸Ñ";

	/// <summary>
	/// Key: "Label.Username"
	/// English String: "Username"
	/// </summary>
	public override string LabelUsername => "Ð˜Ð¼Ñ Ð¿Ð¾Ð»ÑŒÐ·Ð¾Ð²Ð°Ñ‚ÐµÐ»Ñ";

	/// <summary>
	/// Key: "Label.UsernameCharacterLimit"
	/// label
	/// English String: "3-20 alphanumeric characters, no spaces."
	/// </summary>
	public override string LabelUsernameCharacterLimit => "ÐžÑ‚ 3 Ð´Ð¾ 20 Ð±ÑƒÐºÐ² Ð¸Ð»Ð¸ Ñ†Ð¸Ñ„Ñ€ Ð±ÐµÐ· Ð¿Ñ€Ð¾Ð±ÐµÐ»Ð¾Ð².";

	/// <summary>
	/// Key: "Label.UsernameHint"
	/// placeholder for username field
	/// English String: "Username (don't use your real name)"
	/// </summary>
	public override string LabelUsernameHint => "Ð˜Ð¼Ñ Ð¿Ð¾Ð»ÑŒÐ·Ð¾Ð²Ð°Ñ‚ÐµÐ»Ñ (Ð½Ðµ ÑƒÐºÐ°Ð·Ñ‹Ð²Ð°Ð¹Ñ‚Ðµ Ð½Ð°ÑÑ‚Ð¾ÑÑ‰ÐµÐµ Ð¸Ð¼Ñ)";

	/// <summary>
	/// Key: "Label.UsernameRequirements"
	/// English String: "Username (length 3-20, _ is allowed)"
	/// </summary>
	public override string LabelUsernameRequirements => "Ð˜Ð¼Ñ Ð¿Ð¾Ð»ÑŒÐ·Ð¾Ð²Ð°Ñ‚ÐµÐ»Ñ (3-20 ÑÐ¸Ð¼Ð²Ð¾Ð»Ð¾Ð², Ð´Ð¾Ð¿ÑƒÑÐºÐ°ÐµÑ‚ÑÑ ÑÐ¸Ð¼Ð²Ð¾Ð» _)";

	/// <summary>
	/// Key: "Label.Year"
	/// English String: "Year"
	/// </summary>
	public override string LabelYear => "Ð“Ð¾Ð´";

	/// <summary>
	/// Key: "Message.Password.MinLength"
	/// English String: "Min length 8"
	/// </summary>
	public override string MessagePasswordMinLength => "ÐÐµ Ð¼ÐµÐ½ÐµÐµ 8 ÑÐ¸Ð¼Ð²Ð¾Ð»Ð¾Ð²";

	/// <summary>
	/// Key: "Message.Username.NoRealNameUse"
	/// English String: "Don't use your real name"
	/// </summary>
	public override string MessageUsernameNoRealNameUse => "ÐÐµ ÑƒÐºÐ°Ð·Ñ‹Ð²Ð°Ð¹Ñ‚Ðµ ÑÐ²Ð¾Ðµ Ð½Ð°ÑÑ‚Ð¾ÑÑ‰ÐµÐµ Ð¸Ð¼Ñ";

	/// <summary>
	/// Key: "Response.BadUsername"
	/// English String: "Username not appropriate for Roblox."
	/// </summary>
	public override string ResponseBadUsername => "Ð˜Ð¼Ñ Ð¿Ð¾Ð»ÑŒÐ·Ð¾Ð²Ð°Ñ‚ÐµÐ»Ñ Ð½Ðµ Ð¿Ð¾Ð´Ñ…Ð¾Ð´Ð¸Ñ‚ Ð´Ð»Ñ Roblox.";

	/// <summary>
	/// Key: "Response.BadUsernameForWeChat"
	/// message shown when signing up with an inappropriate username
	/// English String: "Username is not appropriate"
	/// </summary>
	public override string ResponseBadUsernameForWeChat => "Ð˜Ð¼Ñ Ð¿Ð¾Ð»ÑŒÐ·Ð¾Ð²Ð°Ñ‚ÐµÐ»Ñ Ð½Ðµ Ñ€Ð°Ð·Ñ€ÐµÑˆÐµÐ½Ð¾";

	/// <summary>
	/// Key: "Response.BirthdayInvalid"
	/// English String: "This birthday is invalid."
	/// </summary>
	public override string ResponseBirthdayInvalid => "ÐÐµÐ²ÐµÑ€Ð½Ð°Ñ Ð´Ð°Ñ‚Ð° Ñ€Ð¾Ð¶Ð´ÐµÐ½Ð¸Ñ.";

	/// <summary>
	/// Key: "Response.BirthdayMustBeSetFirst"
	/// English String: "Birthday must be set first."
	/// </summary>
	public override string ResponseBirthdayMustBeSetFirst => "Ð¡Ð½Ð°Ñ‡Ð°Ð»Ð° Ñ‚Ñ€ÐµÐ±ÑƒÐµÑ‚ÑÑ ÑƒÐºÐ°Ð·Ð°Ñ‚ÑŒ Ð´Ð°Ñ‚Ñƒ Ñ€Ð¾Ð¶Ð´ÐµÐ½Ð¸Ñ.";

	/// <summary>
	/// Key: "Response.CaptchaMismatchError"
	/// error message
	/// English String: "Words do not match."
	/// </summary>
	public override string ResponseCaptchaMismatchError => "Ð¡Ð»Ð¾Ð²Ð° Ð½Ðµ ÑÐ¾Ð²Ð¿Ð°Ð´Ð°ÑŽÑ‚.";

	/// <summary>
	/// Key: "Response.CaptchaNotEnteredError"
	/// validation error message
	/// English String: "Please fill out the Captcha"
	/// </summary>
	public override string ResponseCaptchaNotEnteredError => "ÐŸÐ¾Ð¶Ð°Ð»ÑƒÐ¹ÑÑ‚Ð°, Ð·Ð°Ð¿Ð¾Ð»Ð½Ð¸Ñ‚Ðµ ÐºÐ°Ð¿Ñ‡Ñƒ";

	/// <summary>
	/// Key: "Response.FacebookConnectionError"
	/// error message
	/// English String: "Error while retrieving values from Facebook."
	/// </summary>
	public override string ResponseFacebookConnectionError => "ÐžÑˆÐ¸Ð±ÐºÐ° Ð¿Ñ€Ð¸ Ð¿Ð¾Ð»ÑƒÑ‡ÐµÐ½Ð¸Ð¸ Ð´Ð°Ð½Ð½Ñ‹Ñ… Ð¾Ñ‚ Facebook.";

	/// <summary>
	/// Key: "Response.FacebookLoginAge"
	/// English String: "Facebook login can only be used by users above 13."
	/// </summary>
	public override string ResponseFacebookLoginAge => "Ð’Ñ…Ð¾Ð´ Ñ‡ÐµÑ€ÐµÐ· Facebook Ð¼Ð¾Ð¶ÐµÑ‚ Ð±Ñ‹Ñ‚ÑŒ Ð¿Ñ€Ð¾Ð¸Ð·Ð²ÐµÐ´ÐµÐ½ Ð¿Ð¾Ð»ÑŒÐ·Ð¾Ð²Ð°Ñ‚ÐµÐ»ÑÐ¼Ð¸ Ñ‚Ð¾Ð»ÑŒÐºÐ¾ ÑÑ‚Ð°Ñ€ÑˆÐµ 13 Ð»ÐµÑ‚.";

	/// <summary>
	/// Key: "Response.InvalidBirthday"
	/// English String: "Invalid birthday."
	/// </summary>
	public override string ResponseInvalidBirthday => "ÐÐµÐ´Ð¾Ð¿ÑƒÑÑ‚Ð¸Ð¼Ð°Ñ Ð´Ð°Ñ‚Ð° Ñ€Ð¾Ð¶Ð´ÐµÐ½Ð¸Ñ.";

	/// <summary>
	/// Key: "Response.InvalidEmail"
	/// English String: "Invalid email address."
	/// </summary>
	public override string ResponseInvalidEmail => "ÐÐµÐ´Ð¾Ð¿ÑƒÑÑ‚Ð¸Ð¼Ñ‹Ð¹ Ð°Ð´Ñ€ÐµÑ ÑÐ». Ð¿Ð¾Ñ‡Ñ‚Ñ‹.";

	/// <summary>
	/// Key: "Response.JavaScriptRequired"
	/// error to show that JavaScipt is required for the form to work
	/// English String: "JavaScript is required to submit this form."
	/// </summary>
	public override string ResponseJavaScriptRequired => "Ð”Ð»Ñ Ð¾Ñ‚Ð¿Ñ€Ð°Ð²ÐºÐ¸ Ñ„Ð¾Ñ€Ð¼Ñ‹ Ñ‚Ñ€ÐµÐ±ÑƒÐµÑ‚ÑÑ JavaScript.";

	/// <summary>
	/// Key: "Response.PasswordComplexity"
	/// English String: "Please create a more complex password."
	/// </summary>
	public override string ResponsePasswordComplexity => "ÐŸÑ€Ð¸Ð´ÑƒÐ¼Ð°Ð¹Ñ‚Ðµ Ð±Ð¾Ð»ÐµÐµ ÑÐ»Ð¾Ð¶Ð½Ñ‹Ð¹ Ð¿Ð°Ñ€Ð¾Ð»ÑŒ.";

	/// <summary>
	/// Key: "Response.PasswordConfirmation"
	/// validation message for password confirmation
	/// English String: "Please enter a password confirmation."
	/// </summary>
	public override string ResponsePasswordConfirmation => "ÐŸÐ¾Ð¶Ð°Ð»ÑƒÐ¹ÑÑ‚Ð°, Ð¿Ð¾Ð´Ñ‚Ð²ÐµÑ€Ð´Ð¸Ñ‚Ðµ Ð¿Ð°Ñ€Ð¾Ð»ÑŒ.";

	/// <summary>
	/// Key: "Response.PasswordContainsUsernameError"
	/// error when passsword has username in it
	/// English String: "Password shouldn't match username."
	/// </summary>
	public override string ResponsePasswordContainsUsernameError => "ÐŸÐ°Ñ€Ð¾Ð»ÑŒ Ð½Ðµ Ð´Ð¾Ð»Ð¶ÐµÐ½ ÑÐ¾Ð²Ð¿Ð°Ð´Ð°Ñ‚ÑŒ Ñ Ð¸Ð¼ÐµÐ½ÐµÐ¼ Ð¿Ð¾Ð»ÑŒÐ·Ð¾Ð²Ð°Ñ‚ÐµÐ»Ñ.";

	/// <summary>
	/// Key: "Response.PasswordMismatch"
	/// English String: "Passwords do not match."
	/// </summary>
	public override string ResponsePasswordMismatch => "ÐŸÐ°Ñ€Ð¾Ð»Ð¸ Ð½Ðµ ÑÐ¾Ð²Ð¿Ð°Ð´Ð°ÑŽÑ‚.";

	/// <summary>
	/// Key: "Response.PasswordWrongShort"
	/// English String: "Passwords must be at least 8 characters long."
	/// </summary>
	public override string ResponsePasswordWrongShort => "ÐŸÐ°Ñ€Ð¾Ð»ÑŒ Ð´Ð¾Ð»Ð¶ÐµÐ½ ÑÐ¾Ð´ÐµÑ€Ð¶Ð°Ñ‚ÑŒ Ð½Ðµ Ð¼ÐµÐ½ÐµÐµ 8 Ð·Ð½Ð°ÐºÐ¾Ð².";

	/// <summary>
	/// Key: "Response.PleaseEnterPassword"
	/// English String: "Please enter a password."
	/// </summary>
	public override string ResponsePleaseEnterPassword => "Ð’Ð²ÐµÐ´Ð¸Ñ‚Ðµ Ð¿Ð°Ñ€Ð¾Ð»ÑŒ.";

	/// <summary>
	/// Key: "Response.PleaseEnterUsername"
	/// English String: "Please enter a username."
	/// </summary>
	public override string ResponsePleaseEnterUsername => "Ð’Ð²ÐµÐ´Ð¸Ñ‚Ðµ Ð¸Ð¼Ñ Ð¿Ð¾Ð»ÑŒÐ·Ð¾Ð²Ð°Ñ‚ÐµÐ»Ñ.";

	/// <summary>
	/// Key: "Response.SocialAccountCreationFailed"
	/// error message
	/// English String: "Account creation failed"
	/// </summary>
	public override string ResponseSocialAccountCreationFailed => "Ð£Ñ‡ÐµÑ‚Ð½Ð°Ñ Ð·Ð°Ð¿Ð¸ÑÑŒ Ð½Ðµ ÑÐ¾Ð·Ð´Ð°Ð½Ð°";

	/// <summary>
	/// Key: "Response.SpaceOrSpecialCharaterError"
	/// Spaces and special characters are not allowed error message
	/// English String: "Spaces and special characters are not allowed."
	/// </summary>
	public override string ResponseSpaceOrSpecialCharaterError => "ÐÐµÐ»ÑŒÐ·Ñ Ð¸ÑÐ¿Ð¾Ð»ÑŒÐ·Ð¾Ð²Ð°Ñ‚ÑŒ Ð¿Ñ€Ð¾Ð±ÐµÐ» Ð¸ ÑÐ¿ÐµÑ†Ð¸Ð°Ð»ÑŒÐ½Ñ‹Ðµ ÑÐ¸Ð¼Ð²Ð¾Ð»Ñ‹.";

	/// <summary>
	/// Key: "Response.TooManyAccountsWithSameEmailError"
	/// Too many accounts use this email error message
	/// English String: "Too many accounts use this email."
	/// </summary>
	public override string ResponseTooManyAccountsWithSameEmailError => "Ð¡Ð»Ð¸ÑˆÐºÐ¾Ð¼ Ð¼Ð½Ð¾Ð³Ð¾ ÑƒÑ‡ÐµÑ‚Ð½Ñ‹Ñ… Ð·Ð°Ð¿Ð¸ÑÐµÐ¹ Ð¸ÑÐ¿Ð¾Ð»ÑŒÐ·ÑƒÑŽÑ‚ ÑÑ‚Ð¾Ñ‚ Ð°Ð´Ñ€ÐµÑ ÑÐ». Ð¿Ð¾Ñ‡Ñ‚Ñ‹.";

	/// <summary>
	/// Key: "Response.UnknownError"
	/// English String: "Sorry! An unknown error occurred. Please try again later."
	/// </summary>
	public override string ResponseUnknownError => "Ðš ÑÐ¾Ð¶Ð°Ð»ÐµÐ½Ð¸ÑŽ, Ð¿Ñ€Ð¾Ð¸Ð·Ð¾ÑˆÐ»Ð° Ð½ÐµÐ¸Ð·Ð²ÐµÑÑ‚Ð½Ð°Ñ Ð¾ÑˆÐ¸Ð±ÐºÐ°. ÐŸÐ¾Ð²Ñ‚Ð¾Ñ€Ð¸Ñ‚Ðµ Ð¿Ð¾Ð¿Ñ‹Ñ‚ÐºÑƒ Ð¿Ð¾Ð·Ð¶Ðµ.";

	/// <summary>
	/// Key: "Response.UsernameAllowedCharactersError"
	/// error showing which characters are allowed for username
	/// English String: "Usernames may only contain letters, numbers, and _."
	/// </summary>
	public override string ResponseUsernameAllowedCharactersError => "Ð˜Ð¼Ñ Ð¿Ð¾Ð»ÑŒÐ·Ð¾Ð²Ð°Ñ‚ÐµÐ»Ñ Ð¼Ð¾Ð¶ÐµÑ‚ ÑÐ¾Ð´ÐµÑ€Ð¶Ð°Ñ‚ÑŒ Ñ‚Ð¾Ð»ÑŒÐºÐ¾ Ð±ÑƒÐºÐ²Ñ‹, Ñ†Ð¸Ñ„Ñ€Ñ‹ Ð¸ Ð·Ð½Ð°Ðº _.";

	/// <summary>
	/// Key: "Response.UsernameAlreadyInUse"
	/// English String: "This username is already in use."
	/// </summary>
	public override string ResponseUsernameAlreadyInUse => "Ð­Ñ‚Ð¾ Ð¸Ð¼Ñ Ð¿Ð¾Ð»ÑŒÐ·Ð¾Ð²Ð°Ñ‚ÐµÐ»Ñ ÑƒÐ¶Ðµ Ð·Ð°Ð½ÑÑ‚Ð¾.";

	/// <summary>
	/// Key: "Response.UsernameExplicit"
	/// English String: "This username is not allowed, please try another."
	/// </summary>
	public override string ResponseUsernameExplicit => "ÐÐµÐ´Ð¾Ð¿ÑƒÑÑ‚Ð¸Ð¼Ð¾Ðµ Ð¸Ð¼Ñ. Ð’Ñ‹Ð±ÐµÑ€Ð¸Ñ‚Ðµ Ð´Ñ€ÑƒÐ³Ð¾Ðµ.";

	/// <summary>
	/// Key: "Response.UsernameInvalid"
	/// English String: "Please enter a valid username."
	/// </summary>
	public override string ResponseUsernameInvalid => "Ð’Ð²ÐµÐ´Ð¸Ñ‚Ðµ Ð´Ð¾Ð¿ÑƒÑÑ‚Ð¸Ð¼Ð¾Ðµ Ð¸Ð¼Ñ Ð¿Ð¾Ð»ÑŒÐ·Ð¾Ð²Ð°Ñ‚ÐµÐ»Ñ.";

	/// <summary>
	/// Key: "Response.UsernameInvalidCharacters"
	/// English String: "Only a-z, A-Z, 0-9 and _ are allowed."
	/// </summary>
	public override string ResponseUsernameInvalidCharacters => "Ð”Ð¾Ð¿ÑƒÑÐºÐ°ÑŽÑ‚ÑÑ Ñ‚Ð¾Ð»ÑŒÐºÐ¾ ÑÐ¸Ð¼Ð²Ð¾Ð»Ñ‹ aâ€“z, Aâ€“Z, 0-9 Ð¸ _.";

	/// <summary>
	/// Key: "Response.UsernameInvalidLength"
	/// English String: "Usernames can be 3 to 20 characters long."
	/// </summary>
	public override string ResponseUsernameInvalidLength => "Ð’Ð²ÐµÐ´Ð¸Ñ‚Ðµ Ð¾Ñ‚ 3 Ð´Ð¾ 20 ÑÐ¸Ð¼Ð²Ð¾Ð»Ð¾Ð².";

	/// <summary>
	/// Key: "Response.UsernameInvalidUnderscore"
	/// English String: "Usernames cannot start or end with _."
	/// </summary>
	public override string ResponseUsernameInvalidUnderscore => "Ð˜Ð¼Ñ Ð½Ðµ Ð¼Ð¾Ð¶ÐµÑ‚ Ð½Ð°Ñ‡Ð¸Ð½Ð°Ñ‚ÑŒÑÑ/Ð·Ð°ÐºÐ°Ð½Ñ‡Ð¸Ð²Ð°Ñ‚ÑŒÑÑ _.";

	/// <summary>
	/// Key: "Response.UsernameNotAvailable"
	/// English String: "Username not available. Please try again."
	/// </summary>
	public override string ResponseUsernameNotAvailable => "Ð˜Ð¼Ñ Ð¿Ð¾Ð»ÑŒÐ·Ð¾Ð²Ð°Ñ‚ÐµÐ»Ñ Ð½ÐµÐ´Ð¾ÑÑ‚ÑƒÐ¿Ð½Ð¾. ÐŸÐ¾Ð²Ñ‚Ð¾Ñ€Ð¸Ñ‚Ðµ Ð¿Ð¾Ð¿Ñ‹Ñ‚ÐºÑƒ";

	/// <summary>
	/// Key: "Response.UsernameOrPasswordIncorrect"
	/// Your username or password is incorrect
	/// English String: "Your username or password is incorrect."
	/// </summary>
	public override string ResponseUsernameOrPasswordIncorrect => "ÐÐµÐ¿Ñ€Ð°Ð²Ð¸Ð»ÑŒÐ½Ñ‹Ð¹ Ð¿Ð°Ñ€Ð¾Ð»ÑŒ Ð¸Ð»Ð¸ Ð¸Ð¼Ñ Ð¿Ð¾Ð»ÑŒÐ·Ð¾Ð²Ð°Ñ‚ÐµÐ»Ñ.";

	/// <summary>
	/// Key: "Response.UsernamePasswordRequired"
	/// Username and Password are required error message
	/// English String: "Username and Password are required."
	/// </summary>
	public override string ResponseUsernamePasswordRequired => "ÐÐµÐ¾Ð±Ñ…Ð¾Ð´Ð¸Ð¼Ð¾ ÑƒÐºÐ°Ð·Ð°Ñ‚ÑŒ Ð¸Ð¼Ñ Ð¿Ð¾Ð»ÑŒÐ·Ð¾Ð²Ð°Ñ‚ÐµÐ»Ñ Ð¸ Ð¿Ð°Ñ€Ð¾Ð»ÑŒ.";

	/// <summary>
	/// Key: "Response.UsernamePrivateInfo"
	/// English String: "Username might contain private information."
	/// </summary>
	public override string ResponseUsernamePrivateInfo => "Ð˜Ð¼Ñ Ð¿Ð¾Ð»ÑŒÐ·Ð¾Ð²Ð°Ñ‚ÐµÐ»Ñ Ð¼Ð¾Ð¶ÐµÑ‚ ÑÐ¾Ð´ÐµÑ€Ð¶Ð°Ñ‚ÑŒ Ð»Ð¸Ñ‡Ð½Ñ‹Ðµ Ð´Ð°Ð½Ð½Ñ‹Ðµ.";

	/// <summary>
	/// Key: "Response.UsernameRequired"
	/// validation error message
	/// English String: "Username is required."
	/// </summary>
	public override string ResponseUsernameRequired => "Ð¢Ñ€ÐµÐ±ÑƒÐµÑ‚ÑÑ ÑƒÐºÐ°Ð·Ð°Ñ‚ÑŒ Ð¸Ð¼Ñ Ð¿Ð¾Ð»ÑŒÐ·Ð¾Ð²Ð°Ñ‚ÐµÐ»Ñ.";

	/// <summary>
	/// Key: "Response.UsernameTakenTryAgain"
	/// English String: "This username is already taken! Please try a different one."
	/// </summary>
	public override string ResponseUsernameTakenTryAgain => "Ð­Ñ‚Ð¾ Ð¸Ð¼Ñ Ð¿Ð¾Ð»ÑŒÐ·Ð¾Ð²Ð°Ñ‚ÐµÐ»Ñ ÑƒÐ¶Ðµ Ð·Ð°Ð½ÑÑ‚Ð¾!";

	/// <summary>
	/// Key: "Response.UsernameTooManyUnderscores"
	/// English String: "Usernames can have at most one _."
	/// </summary>
	public override string ResponseUsernameTooManyUnderscores => "Ð˜Ð¼Ñ Ð¼Ð¾Ð¶ÐµÑ‚ ÑÐ¾Ð´ÐµÑ€Ð¶Ð°Ñ‚ÑŒ Ð½Ðµ Ð±Ð¾Ð»ÐµÐµ Ð¾Ð´Ð½Ð¾Ð³Ð¾ _.";

	public SignUpResources_ru_ru(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionCreateAccount()
	{
		return "Ð¡Ð¾Ð·Ð´Ð°Ñ‚ÑŒ ÑƒÑ‡ÐµÑ‚Ð½ÑƒÑŽ Ð·Ð°Ð¿Ð¸ÑÑŒ";
	}

	protected override string _GetTemplateForActionLinkAccount()
	{
		return "ÐŸÑ€Ð¸Ð²ÑÐ·Ð°Ñ‚ÑŒ ÑƒÑ‡ÐµÑ‚Ð½ÑƒÑŽ Ð·Ð°Ð¿Ð¸ÑÑŒ";
	}

	protected override string _GetTemplateForActionLogInCapitalized()
	{
		return "Ð’Ñ…Ð¾Ð´";
	}

	protected override string _GetTemplateForActionReturnHome()
	{
		return "Ð”Ð¾Ð¼Ð¾Ð¹";
	}

	protected override string _GetTemplateForActionSignUp()
	{
		return "Ð ÐµÐ³Ð¸ÑÑ‚Ñ€Ð°Ñ†Ð¸Ñ";
	}

	protected override string _GetTemplateForActionSignupAndSync()
	{
		return "Ð ÐµÐ³Ð¸ÑÑ‚Ñ€Ð°Ñ†Ð¸Ñ Ð¸ ÑÐ¸Ð½Ñ…Ñ€Ð¾Ð½Ð¸Ð·Ð°Ñ†Ð¸Ñ";
	}

	protected override string _GetTemplateForActionSubmit()
	{
		return "ÐžÑ‚Ð¿Ñ€Ð°Ð²Ð¸Ñ‚ÑŒ";
	}

	protected override string _GetTemplateForDescriptionAccountLinkingWarning()
	{
		return "Ð§Ñ‚Ð¾Ð±Ñ‹ Ð¿Ñ€Ð¸Ð²ÑÐ·Ð°Ñ‚ÑŒ ÑÑƒÑ‰ÐµÑÑ‚Ð²ÑƒÑŽÑ‰ÑƒÑŽ ÑƒÑ‡ÐµÑ‚Ð½ÑƒÑŽ Ð·Ð°Ð¿Ð¸ÑÑŒ Roblox, Ð²Ð¾Ð¹Ð´Ð¸Ñ‚Ðµ Ð¸ Ð¾Ñ‚ÐºÑ€Ð¾Ð¹Ñ‚Ðµ ÑÑ‚Ñ€Ð°Ð½Ð¸Ñ†Ñƒ Ð½Ð°ÑÑ‚Ñ€Ð¾ÐµÐº ÑƒÑ‡ÐµÑ‚Ð½Ð¾Ð¹ Ð·Ð°Ð¿Ð¸ÑÐ¸.";
	}

	protected override string _GetTemplateForDescriptionNoRealName()
	{
		return "ÐÐµ Ð¸ÑÐ¿Ð¾Ð»ÑŒÐ·ÑƒÐ¹Ñ‚Ðµ Ð½Ð°ÑÑ‚Ð¾ÑÑ‰ÐµÐµ Ð¸Ð¼Ñ.";
	}

	protected override string _GetTemplateForDescriptionPrivacyPolicy()
	{
		return "ÐŸÐ¾Ð»Ð¸Ñ‚Ð¸ÐºÑƒ ÐºÐ¾Ð½Ñ„Ð¸Ð´ÐµÐ½Ñ†Ð¸Ð°Ð»ÑŒÐ½Ð¾ÑÑ‚Ð¸";
	}

	/// <summary>
	/// Key: "Description.SignUpAgreement"
	/// terms of use agreement checkbox label to signup.
	/// English String: "By clicking {spanStart}Sign Up{spanEnd}, you are agreeing to the {termsOfUseLink} and acknowledging the {privacyPolicyLink}"
	/// </summary>
	public override string DescriptionSignUpAgreement(string spanStart, string spanEnd, string termsOfUseLink, string privacyPolicyLink)
	{
		return $"ÐÐ°Ð¶Ð°Ð² ÐºÐ½Ð¾Ð¿ÐºÑƒ {spanStart}Â«Ð ÐµÐ³Ð¸ÑÑ‚Ñ€Ð°Ñ†Ð¸ÑÂ»{spanEnd}, Ð²Ñ‹ Ð¿Ñ€Ð¸Ð½Ð¸Ð¼Ð°ÐµÑ‚Ðµ ÑƒÑÐ»Ð¾Ð²Ð¸Ñ Ð´Ð¾ÐºÑƒÐ¼ÐµÐ½Ñ‚Ð¾Ð²: {termsOfUseLink} Ð¸ {privacyPolicyLink}";
	}

	protected override string _GetTemplateForDescriptionSignUpAgreement()
	{
		return "ÐÐ°Ð¶Ð°Ð² ÐºÐ½Ð¾Ð¿ÐºÑƒ {spanStart}Â«Ð ÐµÐ³Ð¸ÑÑ‚Ñ€Ð°Ñ†Ð¸ÑÂ»{spanEnd}, Ð²Ñ‹ Ð¿Ñ€Ð¸Ð½Ð¸Ð¼Ð°ÐµÑ‚Ðµ ÑƒÑÐ»Ð¾Ð²Ð¸Ñ Ð´Ð¾ÐºÑƒÐ¼ÐµÐ½Ñ‚Ð¾Ð²: {termsOfUseLink} Ð¸ {privacyPolicyLink}";
	}

	protected override string _GetTemplateForDescriptionTermsOfService()
	{
		return "Ð£ÑÐ»Ð¾Ð²Ð¸Ñ Ð¿Ñ€ÐµÐ´Ð¾ÑÑ‚Ð°Ð²Ð»ÐµÐ½Ð¸Ñ ÑƒÑÐ»ÑƒÐ³";
	}

	protected override string _GetTemplateForGuestSignUpABActionSignUp()
	{
		return "Ð ÐµÐ³Ð¸ÑÑ‚Ñ€Ð°Ñ†Ð¸Ñ";
	}

	protected override string _GetTemplateForHeadingConnectFacebook()
	{
		return "ÐŸÐ¾Ð´ÐºÐ»ÑŽÑ‡Ð¸Ñ‚ÑŒÑÑ Ðº Facebook";
	}

	protected override string _GetTemplateForHeadingCreateAnAccount()
	{
		return "Ð¡ÐžÐ—Ð”ÐÐ¢Ð¬ Ð£Ð§Ð•Ð¢ÐÐ£Ð® Ð—ÐÐŸÐ˜Ð¡Ð¬";
	}

	/// <summary>
	/// Key: "Heading.FacebookSignupAlmostDone"
	/// when user signs up using Facebook, this is shown in next step to create a password.
	/// English String: "{firstname}, YOU'RE ALMOST DONE"
	/// </summary>
	public override string HeadingFacebookSignupAlmostDone(string firstname)
	{
		return $"{firstname}, Ð’Ð« ÐŸÐžÐ§Ð¢Ð˜ Ð—ÐÐšÐžÐÐ§Ð˜Ð›Ð˜";
	}

	protected override string _GetTemplateForHeadingFacebookSignupAlmostDone()
	{
		return "{firstname}, Ð’Ð« ÐŸÐžÐ§Ð¢Ð˜ Ð—ÐÐšÐžÐÐ§Ð˜Ð›Ð˜";
	}

	protected override string _GetTemplateForHeadingLoginHaveFun()
	{
		return "Ð’Ð¾Ð¹Ð´Ð¸Ñ‚Ðµ Ð¸ Ð½Ð°ÑÐ»Ð°Ð¶Ð´Ð°Ð¹Ñ‚ÐµÑÑŒ Ð¸Ð³Ñ€Ð°Ð¼Ð¸!";
	}

	protected override string _GetTemplateForHeadingSignupHaveFun()
	{
		return "Ð—Ð°Ñ€ÐµÐ³Ð¸ÑÑ‚Ñ€Ð¸Ñ€ÑƒÐ¹Ñ‚ÐµÑÑŒ Ð¸ Ð½Ð°ÑÐ»Ð°Ð¶Ð´Ð°Ð¹Ñ‚ÐµÑÑŒ Ð¸Ð³Ñ€Ð°Ð¼Ð¸!";
	}

	protected override string _GetTemplateForLabelAbout()
	{
		return "Ð¡Ð²ÐµÐ´ÐµÐ½Ð¸Ñ";
	}

	protected override string _GetTemplateForLabelAlreadyHaveRobloxAccount()
	{
		return "Ð£Ð¶Ðµ ÐµÑÑ‚ÑŒ ÑƒÑ‡ÐµÑ‚Ð½Ð°Ñ Ð·Ð°Ð¿Ð¸ÑÑŒ Roblox?";
	}

	protected override string _GetTemplateForLabelAlreadyRegistered()
	{
		return "Ð£Ð¶Ðµ Ð·Ð°Ñ€ÐµÐ³Ð¸ÑÑ‚Ñ€Ð¸Ñ€Ð¾Ð²Ð°Ð½Ñ‹?";
	}

	protected override string _GetTemplateForLabelBirthday()
	{
		return "Ð”Ð°Ñ‚Ð° Ñ€Ð¾Ð¶Ð´ÐµÐ½Ð¸Ñ";
	}

	protected override string _GetTemplateForLabelBirthdayWithColumn()
	{
		return "Ð”Ð°Ñ‚Ð° Ñ€Ð¾Ð¶Ð´ÐµÐ½Ð¸Ñ:";
	}

	protected override string _GetTemplateForLabelConfirmPassword()
	{
		return "ÐŸÐ¾Ð´Ñ‚Ð²ÐµÑ€Ð¶Ð´ÐµÐ½Ð¸Ðµ Ð¿Ð°Ñ€Ð¾Ð»Ñ";
	}

	protected override string _GetTemplateForLabelDay()
	{
		return "Ð”ÐµÐ½ÑŒ";
	}

	protected override string _GetTemplateForLabelDesiredUsername()
	{
		return "Ð–ÐµÐ»Ð°ÐµÐ¼Ð¾Ðµ Ð¸Ð¼Ñ Ð¿Ð¾Ð»ÑŒÐ·Ð¾Ð²Ð°Ñ‚ÐµÐ»Ñ:";
	}

	protected override string _GetTemplateForLabelFacebookNotLinked()
	{
		return "â‚¬Ð’Ð°ÑˆÐ° ÑƒÑ‡ÐµÑ‚Ð½Ð°Ñ Ð·Ð°Ð¿Ð¸ÑÑŒ Facebook Ð½Ðµ Ð¿Ñ€Ð¸Ð²ÑÐ·Ð°Ð½Ð° Ðº Roblox. ÐŸÐ¾Ð¶Ð°Ð»ÑƒÐ¹ÑÑ‚Ð°, Ð¿Ñ€Ð¸Ð²ÑÐ¶Ð¸Ñ‚Ðµ ÐµÐµ Ðº Roblox.";
	}

	protected override string _GetTemplateForLabelFacebookSignupUsername()
	{
		return "ÐŸÑ€Ð¸Ð´ÑƒÐ¼Ð°Ð¹Ñ‚Ðµ Ð¸Ð¼Ñ Ð¿Ð¾Ð»ÑŒÐ·Ð¾Ð²Ð°Ñ‚ÐµÐ»Ñ Roblox:";
	}

	protected override string _GetTemplateForLabelFemale()
	{
		return "Ð–ÐµÐ½ÑÐºÐ¸Ð¹";
	}

	protected override string _GetTemplateForLabelGender()
	{
		return "ÐŸÐ¾Ð»";
	}

	protected override string _GetTemplateForLabelGenderRequired()
	{
		return "Ð¢Ñ€ÐµÐ±ÑƒÐµÑ‚ÑÑ ÑƒÐºÐ°Ð·Ð°Ñ‚ÑŒ Ð¿Ð¾Ð».";
	}

	protected override string _GetTemplateForLabelGenderWithColumn()
	{
		return "ÐŸÐ¾Ð»:";
	}

	protected override string _GetTemplateForLabelMale()
	{
		return "ÐœÑƒÐ¶ÑÐºÐ¾Ð¹";
	}

	protected override string _GetTemplateForLabelMonth()
	{
		return "ÐœÐµÑÑÑ†";
	}

	protected override string _GetTemplateForLabelPassword()
	{
		return "ÐŸÐ°Ñ€Ð¾Ð»ÑŒ";
	}

	protected override string _GetTemplateForLabelPasswordRequirements()
	{
		return "ÐŸÐ°Ñ€Ð¾Ð»ÑŒ (Ð½Ðµ Ð¼ÐµÐ½ÐµÐµ 8 ÑÐ¸Ð¼Ð²Ð¾Ð»Ð¾Ð²)";
	}

	protected override string _GetTemplateForLabelPlatforms()
	{
		return "ÐŸÐ»Ð°Ñ‚Ñ„Ð¾Ñ€Ð¼Ñ‹";
	}

	protected override string _GetTemplateForLabelPlay()
	{
		return "Ð˜Ð³Ñ€Ð°Ñ‚ÑŒ";
	}

	protected override string _GetTemplateForLabelPleaseAgreeToTerms()
	{
		return "ÐŸÑ€Ð¸Ð¼Ð¸Ñ‚Ðµ Ð½Ð°ÑˆÐ¸ Ð£ÑÐ»Ð¾Ð²Ð¸Ñ Ð¿Ñ€ÐµÐ´Ð¾ÑÑ‚Ð°Ð²Ð»ÐµÐ½Ð¸Ñ ÑƒÑÐ»ÑƒÐ³ Ð¸ ÐŸÐ¾Ð»Ð¸Ñ‚Ð¸ÐºÑƒ ÐºÐ¾Ð½Ñ„Ð¸Ð´ÐµÐ½Ñ†Ð¸Ð°Ð»ÑŒÐ½Ð¾ÑÑ‚Ð¸.";
	}

	protected override string _GetTemplateForLabelRequired()
	{
		return "ÐžÐ±ÑÐ·Ð°Ñ‚ÐµÐ»ÑŒÐ½Ð¾";
	}

	protected override string _GetTemplateForLabelSignupButtonText()
	{
		return "Ð—Ð°Ñ€ÐµÐ³Ð¸ÑÑ‚Ñ€Ð¸Ñ€ÑƒÐ¹Ñ‚ÐµÑÑŒ Ð¸ Ð¸Ð³Ñ€Ð°Ð¹Ñ‚Ðµ!";
	}

	protected override string _GetTemplateForLabelSignUpWith()
	{
		return "Ð¸Ð»Ð¸ Ð²Ð¾Ð¹Ñ‚Ð¸ Ñ Ð¿Ð¾Ð¼Ð¾Ñ‰ÑŒÑŽ";
	}

	protected override string _GetTemplateForLabelTermsOfUse()
	{
		return "Ð£ÑÐ»Ð¾Ð²Ð¸Ñ Ð¸ÑÐ¿Ð¾Ð»ÑŒÐ·Ð¾Ð²Ð°Ð½Ð¸Ñ";
	}

	protected override string _GetTemplateForLabelUsername()
	{
		return "Ð˜Ð¼Ñ Ð¿Ð¾Ð»ÑŒÐ·Ð¾Ð²Ð°Ñ‚ÐµÐ»Ñ";
	}

	protected override string _GetTemplateForLabelUsernameCharacterLimit()
	{
		return "ÐžÑ‚ 3 Ð´Ð¾ 20 Ð±ÑƒÐºÐ² Ð¸Ð»Ð¸ Ñ†Ð¸Ñ„Ñ€ Ð±ÐµÐ· Ð¿Ñ€Ð¾Ð±ÐµÐ»Ð¾Ð².";
	}

	protected override string _GetTemplateForLabelUsernameHint()
	{
		return "Ð˜Ð¼Ñ Ð¿Ð¾Ð»ÑŒÐ·Ð¾Ð²Ð°Ñ‚ÐµÐ»Ñ (Ð½Ðµ ÑƒÐºÐ°Ð·Ñ‹Ð²Ð°Ð¹Ñ‚Ðµ Ð½Ð°ÑÑ‚Ð¾ÑÑ‰ÐµÐµ Ð¸Ð¼Ñ)";
	}

	protected override string _GetTemplateForLabelUsernameRequirements()
	{
		return "Ð˜Ð¼Ñ Ð¿Ð¾Ð»ÑŒÐ·Ð¾Ð²Ð°Ñ‚ÐµÐ»Ñ (3-20 ÑÐ¸Ð¼Ð²Ð¾Ð»Ð¾Ð², Ð´Ð¾Ð¿ÑƒÑÐºÐ°ÐµÑ‚ÑÑ ÑÐ¸Ð¼Ð²Ð¾Ð» _)";
	}

	protected override string _GetTemplateForLabelYear()
	{
		return "Ð“Ð¾Ð´";
	}

	protected override string _GetTemplateForMessagePasswordMinLength()
	{
		return "ÐÐµ Ð¼ÐµÐ½ÐµÐµ 8 ÑÐ¸Ð¼Ð²Ð¾Ð»Ð¾Ð²";
	}

	protected override string _GetTemplateForMessageUsernameNoRealNameUse()
	{
		return "ÐÐµ ÑƒÐºÐ°Ð·Ñ‹Ð²Ð°Ð¹Ñ‚Ðµ ÑÐ²Ð¾Ðµ Ð½Ð°ÑÑ‚Ð¾ÑÑ‰ÐµÐµ Ð¸Ð¼Ñ";
	}

	protected override string _GetTemplateForResponseBadUsername()
	{
		return "Ð˜Ð¼Ñ Ð¿Ð¾Ð»ÑŒÐ·Ð¾Ð²Ð°Ñ‚ÐµÐ»Ñ Ð½Ðµ Ð¿Ð¾Ð´Ñ…Ð¾Ð´Ð¸Ñ‚ Ð´Ð»Ñ Roblox.";
	}

	protected override string _GetTemplateForResponseBadUsernameForWeChat()
	{
		return "Ð˜Ð¼Ñ Ð¿Ð¾Ð»ÑŒÐ·Ð¾Ð²Ð°Ñ‚ÐµÐ»Ñ Ð½Ðµ Ñ€Ð°Ð·Ñ€ÐµÑˆÐµÐ½Ð¾";
	}

	protected override string _GetTemplateForResponseBirthdayInvalid()
	{
		return "ÐÐµÐ²ÐµÑ€Ð½Ð°Ñ Ð´Ð°Ñ‚Ð° Ñ€Ð¾Ð¶Ð´ÐµÐ½Ð¸Ñ.";
	}

	protected override string _GetTemplateForResponseBirthdayMustBeSetFirst()
	{
		return "Ð¡Ð½Ð°Ñ‡Ð°Ð»Ð° Ñ‚Ñ€ÐµÐ±ÑƒÐµÑ‚ÑÑ ÑƒÐºÐ°Ð·Ð°Ñ‚ÑŒ Ð´Ð°Ñ‚Ñƒ Ñ€Ð¾Ð¶Ð´ÐµÐ½Ð¸Ñ.";
	}

	protected override string _GetTemplateForResponseCaptchaMismatchError()
	{
		return "Ð¡Ð»Ð¾Ð²Ð° Ð½Ðµ ÑÐ¾Ð²Ð¿Ð°Ð´Ð°ÑŽÑ‚.";
	}

	protected override string _GetTemplateForResponseCaptchaNotEnteredError()
	{
		return "ÐŸÐ¾Ð¶Ð°Ð»ÑƒÐ¹ÑÑ‚Ð°, Ð·Ð°Ð¿Ð¾Ð»Ð½Ð¸Ñ‚Ðµ ÐºÐ°Ð¿Ñ‡Ñƒ";
	}

	protected override string _GetTemplateForResponseFacebookConnectionError()
	{
		return "ÐžÑˆÐ¸Ð±ÐºÐ° Ð¿Ñ€Ð¸ Ð¿Ð¾Ð»ÑƒÑ‡ÐµÐ½Ð¸Ð¸ Ð´Ð°Ð½Ð½Ñ‹Ñ… Ð¾Ñ‚ Facebook.";
	}

	protected override string _GetTemplateForResponseFacebookLoginAge()
	{
		return "Ð’Ñ…Ð¾Ð´ Ñ‡ÐµÑ€ÐµÐ· Facebook Ð¼Ð¾Ð¶ÐµÑ‚ Ð±Ñ‹Ñ‚ÑŒ Ð¿Ñ€Ð¾Ð¸Ð·Ð²ÐµÐ´ÐµÐ½ Ð¿Ð¾Ð»ÑŒÐ·Ð¾Ð²Ð°Ñ‚ÐµÐ»ÑÐ¼Ð¸ Ñ‚Ð¾Ð»ÑŒÐºÐ¾ ÑÑ‚Ð°Ñ€ÑˆÐµ 13 Ð»ÐµÑ‚.";
	}

	protected override string _GetTemplateForResponseInvalidBirthday()
	{
		return "ÐÐµÐ´Ð¾Ð¿ÑƒÑÑ‚Ð¸Ð¼Ð°Ñ Ð´Ð°Ñ‚Ð° Ñ€Ð¾Ð¶Ð´ÐµÐ½Ð¸Ñ.";
	}

	protected override string _GetTemplateForResponseInvalidEmail()
	{
		return "ÐÐµÐ´Ð¾Ð¿ÑƒÑÑ‚Ð¸Ð¼Ñ‹Ð¹ Ð°Ð´Ñ€ÐµÑ ÑÐ». Ð¿Ð¾Ñ‡Ñ‚Ñ‹.";
	}

	protected override string _GetTemplateForResponseJavaScriptRequired()
	{
		return "Ð”Ð»Ñ Ð¾Ñ‚Ð¿Ñ€Ð°Ð²ÐºÐ¸ Ñ„Ð¾Ñ€Ð¼Ñ‹ Ñ‚Ñ€ÐµÐ±ÑƒÐµÑ‚ÑÑ JavaScript.";
	}

	protected override string _GetTemplateForResponsePasswordComplexity()
	{
		return "ÐŸÑ€Ð¸Ð´ÑƒÐ¼Ð°Ð¹Ñ‚Ðµ Ð±Ð¾Ð»ÐµÐµ ÑÐ»Ð¾Ð¶Ð½Ñ‹Ð¹ Ð¿Ð°Ñ€Ð¾Ð»ÑŒ.";
	}

	protected override string _GetTemplateForResponsePasswordConfirmation()
	{
		return "ÐŸÐ¾Ð¶Ð°Ð»ÑƒÐ¹ÑÑ‚Ð°, Ð¿Ð¾Ð´Ñ‚Ð²ÐµÑ€Ð´Ð¸Ñ‚Ðµ Ð¿Ð°Ñ€Ð¾Ð»ÑŒ.";
	}

	protected override string _GetTemplateForResponsePasswordContainsUsernameError()
	{
		return "ÐŸÐ°Ñ€Ð¾Ð»ÑŒ Ð½Ðµ Ð´Ð¾Ð»Ð¶ÐµÐ½ ÑÐ¾Ð²Ð¿Ð°Ð´Ð°Ñ‚ÑŒ Ñ Ð¸Ð¼ÐµÐ½ÐµÐ¼ Ð¿Ð¾Ð»ÑŒÐ·Ð¾Ð²Ð°Ñ‚ÐµÐ»Ñ.";
	}

	protected override string _GetTemplateForResponsePasswordMismatch()
	{
		return "ÐŸÐ°Ñ€Ð¾Ð»Ð¸ Ð½Ðµ ÑÐ¾Ð²Ð¿Ð°Ð´Ð°ÑŽÑ‚.";
	}

	protected override string _GetTemplateForResponsePasswordWrongShort()
	{
		return "ÐŸÐ°Ñ€Ð¾Ð»ÑŒ Ð´Ð¾Ð»Ð¶ÐµÐ½ ÑÐ¾Ð´ÐµÑ€Ð¶Ð°Ñ‚ÑŒ Ð½Ðµ Ð¼ÐµÐ½ÐµÐµ 8 Ð·Ð½Ð°ÐºÐ¾Ð².";
	}

	protected override string _GetTemplateForResponsePleaseEnterPassword()
	{
		return "Ð’Ð²ÐµÐ´Ð¸Ñ‚Ðµ Ð¿Ð°Ñ€Ð¾Ð»ÑŒ.";
	}

	protected override string _GetTemplateForResponsePleaseEnterUsername()
	{
		return "Ð’Ð²ÐµÐ´Ð¸Ñ‚Ðµ Ð¸Ð¼Ñ Ð¿Ð¾Ð»ÑŒÐ·Ð¾Ð²Ð°Ñ‚ÐµÐ»Ñ.";
	}

	protected override string _GetTemplateForResponseSocialAccountCreationFailed()
	{
		return "Ð£Ñ‡ÐµÑ‚Ð½Ð°Ñ Ð·Ð°Ð¿Ð¸ÑÑŒ Ð½Ðµ ÑÐ¾Ð·Ð´Ð°Ð½Ð°";
	}

	protected override string _GetTemplateForResponseSpaceOrSpecialCharaterError()
	{
		return "ÐÐµÐ»ÑŒÐ·Ñ Ð¸ÑÐ¿Ð¾Ð»ÑŒÐ·Ð¾Ð²Ð°Ñ‚ÑŒ Ð¿Ñ€Ð¾Ð±ÐµÐ» Ð¸ ÑÐ¿ÐµÑ†Ð¸Ð°Ð»ÑŒÐ½Ñ‹Ðµ ÑÐ¸Ð¼Ð²Ð¾Ð»Ñ‹.";
	}

	protected override string _GetTemplateForResponseTooManyAccountsWithSameEmailError()
	{
		return "Ð¡Ð»Ð¸ÑˆÐºÐ¾Ð¼ Ð¼Ð½Ð¾Ð³Ð¾ ÑƒÑ‡ÐµÑ‚Ð½Ñ‹Ñ… Ð·Ð°Ð¿Ð¸ÑÐµÐ¹ Ð¸ÑÐ¿Ð¾Ð»ÑŒÐ·ÑƒÑŽÑ‚ ÑÑ‚Ð¾Ñ‚ Ð°Ð´Ñ€ÐµÑ ÑÐ». Ð¿Ð¾Ñ‡Ñ‚Ñ‹.";
	}

	protected override string _GetTemplateForResponseUnknownError()
	{
		return "Ðš ÑÐ¾Ð¶Ð°Ð»ÐµÐ½Ð¸ÑŽ, Ð¿Ñ€Ð¾Ð¸Ð·Ð¾ÑˆÐ»Ð° Ð½ÐµÐ¸Ð·Ð²ÐµÑÑ‚Ð½Ð°Ñ Ð¾ÑˆÐ¸Ð±ÐºÐ°. ÐŸÐ¾Ð²Ñ‚Ð¾Ñ€Ð¸Ñ‚Ðµ Ð¿Ð¾Ð¿Ñ‹Ñ‚ÐºÑƒ Ð¿Ð¾Ð·Ð¶Ðµ.";
	}

	protected override string _GetTemplateForResponseUsernameAllowedCharactersError()
	{
		return "Ð˜Ð¼Ñ Ð¿Ð¾Ð»ÑŒÐ·Ð¾Ð²Ð°Ñ‚ÐµÐ»Ñ Ð¼Ð¾Ð¶ÐµÑ‚ ÑÐ¾Ð´ÐµÑ€Ð¶Ð°Ñ‚ÑŒ Ñ‚Ð¾Ð»ÑŒÐºÐ¾ Ð±ÑƒÐºÐ²Ñ‹, Ñ†Ð¸Ñ„Ñ€Ñ‹ Ð¸ Ð·Ð½Ð°Ðº _.";
	}

	protected override string _GetTemplateForResponseUsernameAlreadyInUse()
	{
		return "Ð­Ñ‚Ð¾ Ð¸Ð¼Ñ Ð¿Ð¾Ð»ÑŒÐ·Ð¾Ð²Ð°Ñ‚ÐµÐ»Ñ ÑƒÐ¶Ðµ Ð·Ð°Ð½ÑÑ‚Ð¾.";
	}

	protected override string _GetTemplateForResponseUsernameExplicit()
	{
		return "ÐÐµÐ´Ð¾Ð¿ÑƒÑÑ‚Ð¸Ð¼Ð¾Ðµ Ð¸Ð¼Ñ. Ð’Ñ‹Ð±ÐµÑ€Ð¸Ñ‚Ðµ Ð´Ñ€ÑƒÐ³Ð¾Ðµ.";
	}

	protected override string _GetTemplateForResponseUsernameInvalid()
	{
		return "Ð’Ð²ÐµÐ´Ð¸Ñ‚Ðµ Ð´Ð¾Ð¿ÑƒÑÑ‚Ð¸Ð¼Ð¾Ðµ Ð¸Ð¼Ñ Ð¿Ð¾Ð»ÑŒÐ·Ð¾Ð²Ð°Ñ‚ÐµÐ»Ñ.";
	}

	protected override string _GetTemplateForResponseUsernameInvalidCharacters()
	{
		return "Ð”Ð¾Ð¿ÑƒÑÐºÐ°ÑŽÑ‚ÑÑ Ñ‚Ð¾Ð»ÑŒÐºÐ¾ ÑÐ¸Ð¼Ð²Ð¾Ð»Ñ‹ aâ€“z, Aâ€“Z, 0-9 Ð¸ _.";
	}

	protected override string _GetTemplateForResponseUsernameInvalidLength()
	{
		return "Ð’Ð²ÐµÐ´Ð¸Ñ‚Ðµ Ð¾Ñ‚ 3 Ð´Ð¾ 20 ÑÐ¸Ð¼Ð²Ð¾Ð»Ð¾Ð².";
	}

	protected override string _GetTemplateForResponseUsernameInvalidUnderscore()
	{
		return "Ð˜Ð¼Ñ Ð½Ðµ Ð¼Ð¾Ð¶ÐµÑ‚ Ð½Ð°Ñ‡Ð¸Ð½Ð°Ñ‚ÑŒÑÑ/Ð·Ð°ÐºÐ°Ð½Ñ‡Ð¸Ð²Ð°Ñ‚ÑŒÑÑ _.";
	}

	protected override string _GetTemplateForResponseUsernameNotAvailable()
	{
		return "Ð˜Ð¼Ñ Ð¿Ð¾Ð»ÑŒÐ·Ð¾Ð²Ð°Ñ‚ÐµÐ»Ñ Ð½ÐµÐ´Ð¾ÑÑ‚ÑƒÐ¿Ð½Ð¾. ÐŸÐ¾Ð²Ñ‚Ð¾Ñ€Ð¸Ñ‚Ðµ Ð¿Ð¾Ð¿Ñ‹Ñ‚ÐºÑƒ";
	}

	protected override string _GetTemplateForResponseUsernameOrPasswordIncorrect()
	{
		return "ÐÐµÐ¿Ñ€Ð°Ð²Ð¸Ð»ÑŒÐ½Ñ‹Ð¹ Ð¿Ð°Ñ€Ð¾Ð»ÑŒ Ð¸Ð»Ð¸ Ð¸Ð¼Ñ Ð¿Ð¾Ð»ÑŒÐ·Ð¾Ð²Ð°Ñ‚ÐµÐ»Ñ.";
	}

	protected override string _GetTemplateForResponseUsernamePasswordRequired()
	{
		return "ÐÐµÐ¾Ð±Ñ…Ð¾Ð´Ð¸Ð¼Ð¾ ÑƒÐºÐ°Ð·Ð°Ñ‚ÑŒ Ð¸Ð¼Ñ Ð¿Ð¾Ð»ÑŒÐ·Ð¾Ð²Ð°Ñ‚ÐµÐ»Ñ Ð¸ Ð¿Ð°Ñ€Ð¾Ð»ÑŒ.";
	}

	protected override string _GetTemplateForResponseUsernamePrivateInfo()
	{
		return "Ð˜Ð¼Ñ Ð¿Ð¾Ð»ÑŒÐ·Ð¾Ð²Ð°Ñ‚ÐµÐ»Ñ Ð¼Ð¾Ð¶ÐµÑ‚ ÑÐ¾Ð´ÐµÑ€Ð¶Ð°Ñ‚ÑŒ Ð»Ð¸Ñ‡Ð½Ñ‹Ðµ Ð´Ð°Ð½Ð½Ñ‹Ðµ.";
	}

	protected override string _GetTemplateForResponseUsernameRequired()
	{
		return "Ð¢Ñ€ÐµÐ±ÑƒÐµÑ‚ÑÑ ÑƒÐºÐ°Ð·Ð°Ñ‚ÑŒ Ð¸Ð¼Ñ Ð¿Ð¾Ð»ÑŒÐ·Ð¾Ð²Ð°Ñ‚ÐµÐ»Ñ.";
	}

	protected override string _GetTemplateForResponseUsernameTakenTryAgain()
	{
		return "Ð­Ñ‚Ð¾ Ð¸Ð¼Ñ Ð¿Ð¾Ð»ÑŒÐ·Ð¾Ð²Ð°Ñ‚ÐµÐ»Ñ ÑƒÐ¶Ðµ Ð·Ð°Ð½ÑÑ‚Ð¾!";
	}

	protected override string _GetTemplateForResponseUsernameTooManyUnderscores()
	{
		return "Ð˜Ð¼Ñ Ð¼Ð¾Ð¶ÐµÑ‚ ÑÐ¾Ð´ÐµÑ€Ð¶Ð°Ñ‚ÑŒ Ð½Ðµ Ð±Ð¾Ð»ÐµÐµ Ð¾Ð´Ð½Ð¾Ð³Ð¾ _.";
	}
}


}
