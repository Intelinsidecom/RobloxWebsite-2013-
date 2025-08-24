using System;
using System.Collections.Generic;

namespace Roblox.TranslationResources.Authentication;

internal class SignUpResources_en_us : TranslationResourcesBase, ISignUpResources, ITranslationResources
{
	private readonly Lazy<IReadOnlyDictionary<string, string>> _AllKeys;

	/// <summary>
	/// Key: "Action.CreateAccount"
	/// create account button label
	/// English String: "Create Account"
	/// </summary>
	public virtual string ActionCreateAccount => "Create Account";

	/// <summary>
	/// Key: "Action.LinkAccount"
	/// Button text to link 3rd Party Account to a Roblox Account
	/// English String: "Link Account"
	/// </summary>
	public virtual string ActionLinkAccount => "Link Account";

	/// <summary>
	/// Key: "Action.LogInCapitalized"
	/// button label for capitalized words for Log In
	/// English String: "Log In"
	/// </summary>
	public virtual string ActionLogInCapitalized => "Log In";

	/// <summary>
	/// Key: "Action.ReturnHome"
	/// button label to return the user to home page
	/// English String: "Return Home"
	/// </summary>
	public virtual string ActionReturnHome => "Return Home";

	/// <summary>
	/// Key: "Action.SignUp"
	/// English String: "Sign up"
	/// </summary>
	public virtual string ActionSignUp => "Sign up";

	public virtual string ActionSignupAndSync => "Sign Up & Sync";

	/// <summary>
	/// Key: "Action.Submit"
	/// English String: "Submit"
	/// </summary>
	public virtual string ActionSubmit => "Submit";

	/// <summary>
	/// Key: "Description.AccountLinkingWarning"
	/// instructions for linking account on signup page for FB based account
	/// English String: "To link to an existing Roblox account, sign in and link them on the account settings page."
	/// </summary>
	public virtual string DescriptionAccountLinkingWarning => "To link to an existing Roblox account, sign in and link them on the account settings page.";

	/// <summary>
	/// Key: "Description.NoRealName"
	/// description
	/// English String: "Do not use your real name."
	/// </summary>
	public virtual string DescriptionNoRealName => "Do not use your real name.";

	/// <summary>
	/// Key: "Description.PrivacyPolicy"
	/// English String: "Privacy Policy"
	/// </summary>
	public virtual string DescriptionPrivacyPolicy => "Privacy Policy";

	/// <summary>
	/// Key: "Description.TermsOfService"
	/// English String: "Terms of Service"
	/// </summary>
	public virtual string DescriptionTermsOfService => "Terms of Service";

	/// <summary>
	/// Key: "GuestSignUpAB.Action.SignUp"
	/// English String: "Sign Up"
	/// </summary>
	public virtual string GuestSignUpABActionSignUp => "Sign Up";

	/// <summary>
	/// Key: "Heading.ConnectFacebook"
	/// section heading
	/// English String: "Connect to Facebook"
	/// </summary>
	public virtual string HeadingConnectFacebook => "Connect to Facebook";

	/// <summary>
	/// Key: "Heading.CreateAnAccount"
	/// should be capitalized if the language supports capitalization
	/// English String: "CREATE AN ACCOUNT"
	/// </summary>
	public virtual string HeadingCreateAnAccount => "CREATE AN ACCOUNT";

	/// <summary>
	/// Key: "Heading.LoginHaveFun"
	/// heading for login container
	/// English String: "Log in and start having fun!"
	/// </summary>
	public virtual string HeadingLoginHaveFun => "Log in and start having fun!";

	/// <summary>
	/// Key: "Heading.SignupHaveFun"
	/// signup form heading
	/// English String: "Sign up and start having fun!"
	/// </summary>
	public virtual string HeadingSignupHaveFun => "Sign up and start having fun!";

	/// <summary>
	/// Key: "Label.About"
	/// About link on roller coaster page
	/// English String: "About"
	/// </summary>
	public virtual string LabelAbout => "About";

	/// <summary>
	/// Key: "Label.AlreadyHaveRobloxAccount"
	/// English String: "Already have a Roblox account?"
	/// </summary>
	public virtual string LabelAlreadyHaveRobloxAccount => "Already have a Roblox account?";

	/// <summary>
	/// Key: "Label.AlreadyRegistered"
	/// label
	/// English String: "Already registered?"
	/// </summary>
	public virtual string LabelAlreadyRegistered => "Already registered?";

	/// <summary>
	/// Key: "Label.Birthday"
	/// English String: "Birthday"
	/// </summary>
	public virtual string LabelBirthday => "Birthday";

	/// <summary>
	/// Key: "Label.BirthdayWithColumn"
	/// should have column if the language supports it
	/// English String: "Birthday:"
	/// </summary>
	public virtual string LabelBirthdayWithColumn => "Birthday:";

	/// <summary>
	/// Key: "Label.ConfirmPassword"
	/// English String: "Confirm password"
	/// </summary>
	public virtual string LabelConfirmPassword => "Confirm password";

	/// <summary>
	/// Key: "Label.Day"
	/// English String: "Day"
	/// </summary>
	public virtual string LabelDay => "Day";

	/// <summary>
	/// Key: "Label.DesiredUsername"
	/// should have a column if the language supports it
	/// English String: "Desired Username:"
	/// </summary>
	public virtual string LabelDesiredUsername => "Desired Username:";

	/// <summary>
	/// Key: "Label.FacebookNotLinked"
	/// English String: "Your Facebook account is not linked to any Roblox account. Please sign up for a Roblox account."
	/// </summary>
	public virtual string LabelFacebookNotLinked => "Your Facebook account is not linked to any Roblox account. Please sign up for a Roblox account.";

	/// <summary>
	/// Key: "Label.FacebookSignupUsername"
	/// username field label for FB signup
	/// English String: "Create Roblox username:"
	/// </summary>
	public virtual string LabelFacebookSignupUsername => "Create Roblox username:";

	/// <summary>
	/// Key: "Label.Female"
	/// label
	/// English String: "Female"
	/// </summary>
	public virtual string LabelFemale => "Female";

	/// <summary>
	/// Key: "Label.Gender"
	/// English String: "Gender"
	/// </summary>
	public virtual string LabelGender => "Gender";

	/// <summary>
	/// Key: "Label.GenderRequired"
	/// English String: "Gender is required."
	/// </summary>
	public virtual string LabelGenderRequired => "Gender is required.";

	/// <summary>
	/// Key: "Label.GenderWithColumn"
	/// should have column if the language supports it
	/// English String: "Gender:"
	/// </summary>
	public virtual string LabelGenderWithColumn => "Gender:";

	/// <summary>
	/// Key: "Label.Male"
	/// label
	/// English String: "Male"
	/// </summary>
	public virtual string LabelMale => "Male";

	/// <summary>
	/// Key: "Label.Month"
	/// English String: "Month"
	/// </summary>
	public virtual string LabelMonth => "Month";

	/// <summary>
	/// Key: "Label.Password"
	/// English String: "Password"
	/// </summary>
	public virtual string LabelPassword => "Password";

	/// <summary>
	/// Key: "Label.PasswordRequirements"
	/// English String: "Password (min length 8)"
	/// </summary>
	public virtual string LabelPasswordRequirements => "Password (min length 8)";

	/// <summary>
	/// Key: "Label.Platforms"
	/// platforms link on roller coaster page
	/// English String: "Platforms"
	/// </summary>
	public virtual string LabelPlatforms => "Platforms";

	/// <summary>
	/// Key: "Label.Play"
	/// Play link on roller coaster page
	/// English String: "Play"
	/// </summary>
	public virtual string LabelPlay => "Play";

	/// <summary>
	/// Key: "Label.PleaseAgreeToTerms"
	/// English String: "Please agree to our Terms of Use and Privacy Policy."
	/// </summary>
	public virtual string LabelPleaseAgreeToTerms => "Please agree to our Terms of Use and Privacy Policy.";

	/// <summary>
	/// Key: "Label.Required"
	/// Required
	/// English String: "Required"
	/// </summary>
	public virtual string LabelRequired => "Required";

	/// <summary>
	/// Key: "Label.SignupButtonText"
	/// sign up button text
	/// English String: "Sign Up and Play!"
	/// </summary>
	public virtual string LabelSignupButtonText => "Sign Up and Play!";

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
	public virtual string LabelSignUpWith => "or sign up with";

	/// <summary>
	/// Key: "Label.TermsOfUse"
	/// terms of use link label
	/// English String: "Terms of Use"
	/// </summary>
	public virtual string LabelTermsOfUse => "Terms of Use";

	/// <summary>
	/// Key: "Label.Username"
	/// English String: "Username"
	/// </summary>
	public virtual string LabelUsername => "Username";

	/// <summary>
	/// Key: "Label.UsernameCharacterLimit"
	/// label
	/// English String: "3-20 alphanumeric characters, no spaces."
	/// </summary>
	public virtual string LabelUsernameCharacterLimit => "3-20 alphanumeric characters, no spaces.";

	/// <summary>
	/// Key: "Label.UsernameHint"
	/// placeholder for username field
	/// English String: "Username (don't use your real name)"
	/// </summary>
	public virtual string LabelUsernameHint => "Username (don't use your real name)";

	/// <summary>
	/// Key: "Label.UsernameRequirements"
	/// English String: "Username (length 3-20, _ is allowed)"
	/// </summary>
	public virtual string LabelUsernameRequirements => "Username (length 3-20, _ is allowed)";

	/// <summary>
	/// Key: "Label.Year"
	/// English String: "Year"
	/// </summary>
	public virtual string LabelYear => "Year";

	/// <summary>
	/// Key: "Message.Password.MinLength"
	/// English String: "Min length 8"
	/// </summary>
	public virtual string MessagePasswordMinLength => "Min length 8";

	/// <summary>
	/// Key: "Message.Username.NoRealNameUse"
	/// English String: "Don't use your real name"
	/// </summary>
	public virtual string MessageUsernameNoRealNameUse => "Don't use your real name";

	/// <summary>
	/// Key: "Response.BadUsername"
	/// English String: "Username not appropriate for Roblox."
	/// </summary>
	public virtual string ResponseBadUsername => "Username not appropriate for Roblox.";

	/// <summary>
	/// Key: "Response.BadUsernameForWeChat"
	/// message shown when signing up with an inappropriate username
	/// English String: "Username is not appropriate"
	/// </summary>
	public virtual string ResponseBadUsernameForWeChat => "Username is not appropriate";

	/// <summary>
	/// Key: "Response.BirthdayInvalid"
	/// English String: "This birthday is invalid."
	/// </summary>
	public virtual string ResponseBirthdayInvalid => "This birthday is invalid.";

	/// <summary>
	/// Key: "Response.BirthdayMustBeSetFirst"
	/// English String: "Birthday must be set first."
	/// </summary>
	public virtual string ResponseBirthdayMustBeSetFirst => "Birthday must be set first.";

	/// <summary>
	/// Key: "Response.CaptchaMismatchError"
	/// error message
	/// English String: "Words do not match."
	/// </summary>
	public virtual string ResponseCaptchaMismatchError => "Words do not match.";

	/// <summary>
	/// Key: "Response.CaptchaNotEnteredError"
	/// validation error message
	/// English String: "Please fill out the Captcha"
	/// </summary>
	public virtual string ResponseCaptchaNotEnteredError => "Please fill out the Captcha";

	/// <summary>
	/// Key: "Response.FacebookConnectionError"
	/// error message
	/// English String: "Error while retrieving values from Facebook."
	/// </summary>
	public virtual string ResponseFacebookConnectionError => "Error while retrieving values from Facebook.";

	/// <summary>
	/// Key: "Response.FacebookLoginAge"
	/// English String: "Facebook login can only be used by users above 13."
	/// </summary>
	public virtual string ResponseFacebookLoginAge => "Facebook login can only be used by users above 13.";

	/// <summary>
	/// Key: "Response.InvalidBirthday"
	/// English String: "Invalid birthday."
	/// </summary>
	public virtual string ResponseInvalidBirthday => "Invalid birthday.";

	/// <summary>
	/// Key: "Response.InvalidEmail"
	/// English String: "Invalid email address."
	/// </summary>
	public virtual string ResponseInvalidEmail => "Invalid email address.";

	/// <summary>
	/// Key: "Response.JavaScriptRequired"
	/// error to show that JavaScipt is required for the form to work
	/// English String: "JavaScript is required to submit this form."
	/// </summary>
	public virtual string ResponseJavaScriptRequired => "JavaScript is required to submit this form.";

	/// <summary>
	/// Key: "Response.PasswordComplexity"
	/// English String: "Please create a more complex password."
	/// </summary>
	public virtual string ResponsePasswordComplexity => "Please create a more complex password.";

	/// <summary>
	/// Key: "Response.PasswordConfirmation"
	/// validation message for password confirmation
	/// English String: "Please enter a password confirmation."
	/// </summary>
	public virtual string ResponsePasswordConfirmation => "Please enter a password confirmation.";

	/// <summary>
	/// Key: "Response.PasswordContainsUsernameError"
	/// error when passsword has username in it
	/// English String: "Password shouldn't match username."
	/// </summary>
	public virtual string ResponsePasswordContainsUsernameError => "Password shouldn't match username.";

	/// <summary>
	/// Key: "Response.PasswordMismatch"
	/// English String: "Passwords do not match."
	/// </summary>
	public virtual string ResponsePasswordMismatch => "Passwords do not match.";

	/// <summary>
	/// Key: "Response.PasswordWrongShort"
	/// English String: "Passwords must be at least 8 characters long."
	/// </summary>
	public virtual string ResponsePasswordWrongShort => "Passwords must be at least 8 characters long.";

	/// <summary>
	/// Key: "Response.PleaseEnterPassword"
	/// English String: "Please enter a password."
	/// </summary>
	public virtual string ResponsePleaseEnterPassword => "Please enter a password.";

	/// <summary>
	/// Key: "Response.PleaseEnterUsername"
	/// English String: "Please enter a username."
	/// </summary>
	public virtual string ResponsePleaseEnterUsername => "Please enter a username.";

	/// <summary>
	/// Key: "Response.SocialAccountCreationFailed"
	/// error message
	/// English String: "Account creation failed"
	/// </summary>
	public virtual string ResponseSocialAccountCreationFailed => "Account creation failed";

	/// <summary>
	/// Key: "Response.SpaceOrSpecialCharaterError"
	/// Spaces and special characters are not allowed error message
	/// English String: "Spaces and special characters are not allowed."
	/// </summary>
	public virtual string ResponseSpaceOrSpecialCharaterError => "Spaces and special characters are not allowed.";

	/// <summary>
	/// Key: "Response.TooManyAccountsWithSameEmailError"
	/// Too many accounts use this email error message
	/// English String: "Too many accounts use this email."
	/// </summary>
	public virtual string ResponseTooManyAccountsWithSameEmailError => "Too many accounts use this email.";

	/// <summary>
	/// Key: "Response.UnknownError"
	/// English String: "Sorry! An unknown error occurred. Please try again later."
	/// </summary>
	public virtual string ResponseUnknownError => "Sorry! An unknown error occurred. Please try again later.";

	/// <summary>
	/// Key: "Response.UsernameAllowedCharactersError"
	/// error showing which characters are allowed for username
	/// English String: "Usernames may only contain letters, numbers, and _."
	/// </summary>
	public virtual string ResponseUsernameAllowedCharactersError => "Usernames may only contain letters, numbers, and _.";

	/// <summary>
	/// Key: "Response.UsernameAlreadyInUse"
	/// English String: "This username is already in use."
	/// </summary>
	public virtual string ResponseUsernameAlreadyInUse => "This username is already in use.";

	/// <summary>
	/// Key: "Response.UsernameExplicit"
	/// English String: "This username is not allowed, please try another."
	/// </summary>
	public virtual string ResponseUsernameExplicit => "This username is not allowed, please try another.";

	/// <summary>
	/// Key: "Response.UsernameInvalid"
	/// English String: "Please enter a valid username."
	/// </summary>
	public virtual string ResponseUsernameInvalid => "Please enter a valid username.";

	/// <summary>
	/// Key: "Response.UsernameInvalidCharacters"
	/// English String: "Only a-z, A-Z, 0-9 and _ are allowed."
	/// </summary>
	public virtual string ResponseUsernameInvalidCharacters => "Only a-z, A-Z, 0-9 and _ are allowed.";

	/// <summary>
	/// Key: "Response.UsernameInvalidLength"
	/// English String: "Usernames can be 3 to 20 characters long."
	/// </summary>
	public virtual string ResponseUsernameInvalidLength => "Usernames can be 3 to 20 characters long.";

	/// <summary>
	/// Key: "Response.UsernameInvalidUnderscore"
	/// English String: "Usernames cannot start or end with _."
	/// </summary>
	public virtual string ResponseUsernameInvalidUnderscore => "Usernames cannot start or end with _.";

	/// <summary>
	/// Key: "Response.UsernameNotAvailable"
	/// English String: "Username not available. Please try again."
	/// </summary>
	public virtual string ResponseUsernameNotAvailable => "Username not available. Please try again.";

	/// <summary>
	/// Key: "Response.UsernameOrPasswordIncorrect"
	/// Your username or password is incorrect
	/// English String: "Your username or password is incorrect."
	/// </summary>
	public virtual string ResponseUsernameOrPasswordIncorrect => "Your username or password is incorrect.";

	/// <summary>
	/// Key: "Response.UsernamePasswordRequired"
	/// Username and Password are required error message
	/// English String: "Username and Password are required."
	/// </summary>
	public virtual string ResponseUsernamePasswordRequired => "Username and Password are required.";

	/// <summary>
	/// Key: "Response.UsernamePrivateInfo"
	/// English String: "Username might contain private information."
	/// </summary>
	public virtual string ResponseUsernamePrivateInfo => "Username might contain private information.";

	/// <summary>
	/// Key: "Response.UsernameRequired"
	/// validation error message
	/// English String: "Username is required."
	/// </summary>
	public virtual string ResponseUsernameRequired => "Username is required.";

	/// <summary>
	/// Key: "Response.UsernameTakenTryAgain"
	/// English String: "This username is already taken! Please try a different one."
	/// </summary>
	public virtual string ResponseUsernameTakenTryAgain => "This username is already taken! Please try a different one.";

	/// <summary>
	/// Key: "Response.UsernameTooManyUnderscores"
	/// English String: "Usernames can have at most one _."
	/// </summary>
	public virtual string ResponseUsernameTooManyUnderscores => "Usernames can have at most one _.";

	public SignUpResources_en_us(TranslationResourceState state)
		: base(state)
	{
		_AllKeys = new Lazy<IReadOnlyDictionary<string, string>>(() => new Dictionary<string, string>
		{
			{
				"Action.CreateAccount",
				_GetTemplateForActionCreateAccount()
			},
			{
				"Action.LinkAccount",
				_GetTemplateForActionLinkAccount()
			},
			{
				"Action.LogInCapitalized",
				_GetTemplateForActionLogInCapitalized()
			},
			{
				"Action.ReturnHome",
				_GetTemplateForActionReturnHome()
			},
			{
				"Action.SignUp",
				_GetTemplateForActionSignUp()
			},
			{
				"Action.SignupAndSync",
				_GetTemplateForActionSignupAndSync()
			},
			{
				"Action.Submit",
				_GetTemplateForActionSubmit()
			},
			{
				"Description.AccountLinkingWarning",
				_GetTemplateForDescriptionAccountLinkingWarning()
			},
			{
				"Description.NoRealName",
				_GetTemplateForDescriptionNoRealName()
			},
			{
				"Description.PrivacyPolicy",
				_GetTemplateForDescriptionPrivacyPolicy()
			},
			{
				"Description.SignUpAgreement",
				_GetTemplateForDescriptionSignUpAgreement()
			},
			{
				"Description.TermsOfService",
				_GetTemplateForDescriptionTermsOfService()
			},
			{
				"GuestSignUpAB.Action.SignUp",
				_GetTemplateForGuestSignUpABActionSignUp()
			},
			{
				"Heading.ConnectFacebook",
				_GetTemplateForHeadingConnectFacebook()
			},
			{
				"Heading.CreateAnAccount",
				_GetTemplateForHeadingCreateAnAccount()
			},
			{
				"Heading.FacebookSignupAlmostDone",
				_GetTemplateForHeadingFacebookSignupAlmostDone()
			},
			{
				"Heading.LoginHaveFun",
				_GetTemplateForHeadingLoginHaveFun()
			},
			{
				"Heading.SignupHaveFun",
				_GetTemplateForHeadingSignupHaveFun()
			},
			{
				"Label.About",
				_GetTemplateForLabelAbout()
			},
			{
				"Label.AlreadyHaveRobloxAccount",
				_GetTemplateForLabelAlreadyHaveRobloxAccount()
			},
			{
				"Label.AlreadyRegistered",
				_GetTemplateForLabelAlreadyRegistered()
			},
			{
				"Label.Birthday",
				_GetTemplateForLabelBirthday()
			},
			{
				"Label.BirthdayWithColumn",
				_GetTemplateForLabelBirthdayWithColumn()
			},
			{
				"Label.ConfirmPassword",
				_GetTemplateForLabelConfirmPassword()
			},
			{
				"Label.Day",
				_GetTemplateForLabelDay()
			},
			{
				"Label.DesiredUsername",
				_GetTemplateForLabelDesiredUsername()
			},
			{
				"Label.FacebookNotLinked",
				_GetTemplateForLabelFacebookNotLinked()
			},
			{
				"Label.FacebookSignupUsername",
				_GetTemplateForLabelFacebookSignupUsername()
			},
			{
				"Label.Female",
				_GetTemplateForLabelFemale()
			},
			{
				"Label.Gender",
				_GetTemplateForLabelGender()
			},
			{
				"Label.GenderRequired",
				_GetTemplateForLabelGenderRequired()
			},
			{
				"Label.GenderWithColumn",
				_GetTemplateForLabelGenderWithColumn()
			},
			{
				"Label.Male",
				_GetTemplateForLabelMale()
			},
			{
				"Label.Month",
				_GetTemplateForLabelMonth()
			},
			{
				"Label.Password",
				_GetTemplateForLabelPassword()
			},
			{
				"Label.PasswordRequirements",
				_GetTemplateForLabelPasswordRequirements()
			},
			{
				"Label.Platforms",
				_GetTemplateForLabelPlatforms()
			},
			{
				"Label.Play",
				_GetTemplateForLabelPlay()
			},
			{
				"Label.PleaseAgreeToTerms",
				_GetTemplateForLabelPleaseAgreeToTerms()
			},
			{
				"Label.Required",
				_GetTemplateForLabelRequired()
			},
			{
				"Label.SignupButtonText",
				_GetTemplateForLabelSignupButtonText()
			},
			{
				"Label.SignUpWith",
				_GetTemplateForLabelSignUpWith()
			},
			{
				"Label.TermsOfUse",
				_GetTemplateForLabelTermsOfUse()
			},
			{
				"Label.Username",
				_GetTemplateForLabelUsername()
			},
			{
				"Label.UsernameCharacterLimit",
				_GetTemplateForLabelUsernameCharacterLimit()
			},
			{
				"Label.UsernameHint",
				_GetTemplateForLabelUsernameHint()
			},
			{
				"Label.UsernameRequirements",
				_GetTemplateForLabelUsernameRequirements()
			},
			{
				"Label.Year",
				_GetTemplateForLabelYear()
			},
			{
				"Message.Password.MinLength",
				_GetTemplateForMessagePasswordMinLength()
			},
			{
				"Message.Username.NoRealNameUse",
				_GetTemplateForMessageUsernameNoRealNameUse()
			},
			{
				"Response.BadUsername",
				_GetTemplateForResponseBadUsername()
			},
			{
				"Response.BadUsernameForWeChat",
				_GetTemplateForResponseBadUsernameForWeChat()
			},
			{
				"Response.BirthdayInvalid",
				_GetTemplateForResponseBirthdayInvalid()
			},
			{
				"Response.BirthdayMustBeSetFirst",
				_GetTemplateForResponseBirthdayMustBeSetFirst()
			},
			{
				"Response.CaptchaMismatchError",
				_GetTemplateForResponseCaptchaMismatchError()
			},
			{
				"Response.CaptchaNotEnteredError",
				_GetTemplateForResponseCaptchaNotEnteredError()
			},
			{
				"Response.FacebookConnectionError",
				_GetTemplateForResponseFacebookConnectionError()
			},
			{
				"Response.FacebookLoginAge",
				_GetTemplateForResponseFacebookLoginAge()
			},
			{
				"Response.InvalidBirthday",
				_GetTemplateForResponseInvalidBirthday()
			},
			{
				"Response.InvalidEmail",
				_GetTemplateForResponseInvalidEmail()
			},
			{
				"Response.JavaScriptRequired",
				_GetTemplateForResponseJavaScriptRequired()
			},
			{
				"Response.PasswordComplexity",
				_GetTemplateForResponsePasswordComplexity()
			},
			{
				"Response.PasswordConfirmation",
				_GetTemplateForResponsePasswordConfirmation()
			},
			{
				"Response.PasswordContainsUsernameError",
				_GetTemplateForResponsePasswordContainsUsernameError()
			},
			{
				"Response.PasswordMismatch",
				_GetTemplateForResponsePasswordMismatch()
			},
			{
				"Response.PasswordWrongShort",
				_GetTemplateForResponsePasswordWrongShort()
			},
			{
				"Response.PleaseEnterPassword",
				_GetTemplateForResponsePleaseEnterPassword()
			},
			{
				"Response.PleaseEnterUsername",
				_GetTemplateForResponsePleaseEnterUsername()
			},
			{
				"Response.SocialAccountCreationFailed",
				_GetTemplateForResponseSocialAccountCreationFailed()
			},
			{
				"Response.SpaceOrSpecialCharaterError",
				_GetTemplateForResponseSpaceOrSpecialCharaterError()
			},
			{
				"Response.TooManyAccountsWithSameEmailError",
				_GetTemplateForResponseTooManyAccountsWithSameEmailError()
			},
			{
				"Response.UnknownError",
				_GetTemplateForResponseUnknownError()
			},
			{
				"Response.UsernameAllowedCharactersError",
				_GetTemplateForResponseUsernameAllowedCharactersError()
			},
			{
				"Response.UsernameAlreadyInUse",
				_GetTemplateForResponseUsernameAlreadyInUse()
			},
			{
				"Response.UsernameExplicit",
				_GetTemplateForResponseUsernameExplicit()
			},
			{
				"Response.UsernameInvalid",
				_GetTemplateForResponseUsernameInvalid()
			},
			{
				"Response.UsernameInvalidCharacters",
				_GetTemplateForResponseUsernameInvalidCharacters()
			},
			{
				"Response.UsernameInvalidLength",
				_GetTemplateForResponseUsernameInvalidLength()
			},
			{
				"Response.UsernameInvalidUnderscore",
				_GetTemplateForResponseUsernameInvalidUnderscore()
			},
			{
				"Response.UsernameNotAvailable",
				_GetTemplateForResponseUsernameNotAvailable()
			},
			{
				"Response.UsernameOrPasswordIncorrect",
				_GetTemplateForResponseUsernameOrPasswordIncorrect()
			},
			{
				"Response.UsernamePasswordRequired",
				_GetTemplateForResponseUsernamePasswordRequired()
			},
			{
				"Response.UsernamePrivateInfo",
				_GetTemplateForResponseUsernamePrivateInfo()
			},
			{
				"Response.UsernameRequired",
				_GetTemplateForResponseUsernameRequired()
			},
			{
				"Response.UsernameTakenTryAgain",
				_GetTemplateForResponseUsernameTakenTryAgain()
			},
			{
				"Response.UsernameTooManyUnderscores",
				_GetTemplateForResponseUsernameTooManyUnderscores()
			}
		});
	}

	public IReadOnlyDictionary<string, string> GetAllKeys()
	{
		return _AllKeys.Value;
	}

	public string GetFullContentNamespaceName()
	{
		return "Authentication.SignUp";
	}

	protected virtual string _GetTemplateForActionCreateAccount()
	{
		return "Create Account";
	}

	protected virtual string _GetTemplateForActionLinkAccount()
	{
		return "Link Account";
	}

	protected virtual string _GetTemplateForActionLogInCapitalized()
	{
		return "Log In";
	}

	protected virtual string _GetTemplateForActionReturnHome()
	{
		return "Return Home";
	}

	protected virtual string _GetTemplateForActionSignUp()
	{
		return "Sign up";
	}

	protected virtual string _GetTemplateForActionSignupAndSync()
	{
		return "Sign Up & Sync";
	}

	protected virtual string _GetTemplateForActionSubmit()
	{
		return "Submit";
	}

	protected virtual string _GetTemplateForDescriptionAccountLinkingWarning()
	{
		return "To link to an existing Roblox account, sign in and link them on the account settings page.";
	}

	protected virtual string _GetTemplateForDescriptionNoRealName()
	{
		return "Do not use your real name.";
	}

	protected virtual string _GetTemplateForDescriptionPrivacyPolicy()
	{
		return "Privacy Policy";
	}

	/// <summary>
	/// Key: "Description.SignUpAgreement"
	/// terms of use agreement checkbox label to signup.
	/// English String: "By clicking {spanStart}Sign Up{spanEnd}, you are agreeing to the {termsOfUseLink} and acknowledging the {privacyPolicyLink}"
	/// </summary>
	public virtual string DescriptionSignUpAgreement(string spanStart, string spanEnd, string termsOfUseLink, string privacyPolicyLink)
	{
		return $"By clicking {spanStart}Sign Up{spanEnd}, you are agreeing to the {termsOfUseLink} and acknowledging the {privacyPolicyLink}";
	}

	protected virtual string _GetTemplateForDescriptionSignUpAgreement()
	{
		return "By clicking {spanStart}Sign Up{spanEnd}, you are agreeing to the {termsOfUseLink} and acknowledging the {privacyPolicyLink}";
	}

	protected virtual string _GetTemplateForDescriptionTermsOfService()
	{
		return "Terms of Service";
	}

	protected virtual string _GetTemplateForGuestSignUpABActionSignUp()
	{
		return "Sign Up";
	}

	protected virtual string _GetTemplateForHeadingConnectFacebook()
	{
		return "Connect to Facebook";
	}

	protected virtual string _GetTemplateForHeadingCreateAnAccount()
	{
		return "CREATE AN ACCOUNT";
	}

	/// <summary>
	/// Key: "Heading.FacebookSignupAlmostDone"
	/// when user signs up using Facebook, this is shown in next step to create a password.
	/// English String: "{firstname}, YOU'RE ALMOST DONE"
	/// </summary>
	public virtual string HeadingFacebookSignupAlmostDone(string firstname)
	{
		return $"{firstname}, YOU'RE ALMOST DONE";
	}

	protected virtual string _GetTemplateForHeadingFacebookSignupAlmostDone()
	{
		return "{firstname}, YOU'RE ALMOST DONE";
	}

	protected virtual string _GetTemplateForHeadingLoginHaveFun()
	{
		return "Log in and start having fun!";
	}

	protected virtual string _GetTemplateForHeadingSignupHaveFun()
	{
		return "Sign up and start having fun!";
	}

	protected virtual string _GetTemplateForLabelAbout()
	{
		return "About";
	}

	protected virtual string _GetTemplateForLabelAlreadyHaveRobloxAccount()
	{
		return "Already have a Roblox account?";
	}

	protected virtual string _GetTemplateForLabelAlreadyRegistered()
	{
		return "Already registered?";
	}

	protected virtual string _GetTemplateForLabelBirthday()
	{
		return "Birthday";
	}

	protected virtual string _GetTemplateForLabelBirthdayWithColumn()
	{
		return "Birthday:";
	}

	protected virtual string _GetTemplateForLabelConfirmPassword()
	{
		return "Confirm password";
	}

	protected virtual string _GetTemplateForLabelDay()
	{
		return "Day";
	}

	protected virtual string _GetTemplateForLabelDesiredUsername()
	{
		return "Desired Username:";
	}

	protected virtual string _GetTemplateForLabelFacebookNotLinked()
	{
		return "Your Facebook account is not linked to any Roblox account. Please sign up for a Roblox account.";
	}

	protected virtual string _GetTemplateForLabelFacebookSignupUsername()
	{
		return "Create Roblox username:";
	}

	protected virtual string _GetTemplateForLabelFemale()
	{
		return "Female";
	}

	protected virtual string _GetTemplateForLabelGender()
	{
		return "Gender";
	}

	protected virtual string _GetTemplateForLabelGenderRequired()
	{
		return "Gender is required.";
	}

	protected virtual string _GetTemplateForLabelGenderWithColumn()
	{
		return "Gender:";
	}

	protected virtual string _GetTemplateForLabelMale()
	{
		return "Male";
	}

	protected virtual string _GetTemplateForLabelMonth()
	{
		return "Month";
	}

	protected virtual string _GetTemplateForLabelPassword()
	{
		return "Password";
	}

	protected virtual string _GetTemplateForLabelPasswordRequirements()
	{
		return "Password (min length 8)";
	}

	protected virtual string _GetTemplateForLabelPlatforms()
	{
		return "Platforms";
	}

	protected virtual string _GetTemplateForLabelPlay()
	{
		return "Play";
	}

	protected virtual string _GetTemplateForLabelPleaseAgreeToTerms()
	{
		return "Please agree to our Terms of Use and Privacy Policy.";
	}

	protected virtual string _GetTemplateForLabelRequired()
	{
		return "Required";
	}

	protected virtual string _GetTemplateForLabelSignupButtonText()
	{
		return "Sign Up and Play!";
	}

	protected virtual string _GetTemplateForLabelSignUpWith()
	{
		return "or sign up with";
	}

	protected virtual string _GetTemplateForLabelTermsOfUse()
	{
		return "Terms of Use";
	}

	protected virtual string _GetTemplateForLabelUsername()
	{
		return "Username";
	}

	protected virtual string _GetTemplateForLabelUsernameCharacterLimit()
	{
		return "3-20 alphanumeric characters, no spaces.";
	}

	protected virtual string _GetTemplateForLabelUsernameHint()
	{
		return "Username (don't use your real name)";
	}

	protected virtual string _GetTemplateForLabelUsernameRequirements()
	{
		return "Username (length 3-20, _ is allowed)";
	}

	protected virtual string _GetTemplateForLabelYear()
	{
		return "Year";
	}

	protected virtual string _GetTemplateForMessagePasswordMinLength()
	{
		return "Min length 8";
	}

	protected virtual string _GetTemplateForMessageUsernameNoRealNameUse()
	{
		return "Don't use your real name";
	}

	protected virtual string _GetTemplateForResponseBadUsername()
	{
		return "Username not appropriate for Roblox.";
	}

	protected virtual string _GetTemplateForResponseBadUsernameForWeChat()
	{
		return "Username is not appropriate";
	}

	protected virtual string _GetTemplateForResponseBirthdayInvalid()
	{
		return "This birthday is invalid.";
	}

	protected virtual string _GetTemplateForResponseBirthdayMustBeSetFirst()
	{
		return "Birthday must be set first.";
	}

	protected virtual string _GetTemplateForResponseCaptchaMismatchError()
	{
		return "Words do not match.";
	}

	protected virtual string _GetTemplateForResponseCaptchaNotEnteredError()
	{
		return "Please fill out the Captcha";
	}

	protected virtual string _GetTemplateForResponseFacebookConnectionError()
	{
		return "Error while retrieving values from Facebook.";
	}

	protected virtual string _GetTemplateForResponseFacebookLoginAge()
	{
		return "Facebook login can only be used by users above 13.";
	}

	protected virtual string _GetTemplateForResponseInvalidBirthday()
	{
		return "Invalid birthday.";
	}

	protected virtual string _GetTemplateForResponseInvalidEmail()
	{
		return "Invalid email address.";
	}

	protected virtual string _GetTemplateForResponseJavaScriptRequired()
	{
		return "JavaScript is required to submit this form.";
	}

	protected virtual string _GetTemplateForResponsePasswordComplexity()
	{
		return "Please create a more complex password.";
	}

	protected virtual string _GetTemplateForResponsePasswordConfirmation()
	{
		return "Please enter a password confirmation.";
	}

	protected virtual string _GetTemplateForResponsePasswordContainsUsernameError()
	{
		return "Password shouldn't match username.";
	}

	protected virtual string _GetTemplateForResponsePasswordMismatch()
	{
		return "Passwords do not match.";
	}

	protected virtual string _GetTemplateForResponsePasswordWrongShort()
	{
		return "Passwords must be at least 8 characters long.";
	}

	protected virtual string _GetTemplateForResponsePleaseEnterPassword()
	{
		return "Please enter a password.";
	}

	protected virtual string _GetTemplateForResponsePleaseEnterUsername()
	{
		return "Please enter a username.";
	}

	protected virtual string _GetTemplateForResponseSocialAccountCreationFailed()
	{
		return "Account creation failed";
	}

	protected virtual string _GetTemplateForResponseSpaceOrSpecialCharaterError()
	{
		return "Spaces and special characters are not allowed.";
	}

	protected virtual string _GetTemplateForResponseTooManyAccountsWithSameEmailError()
	{
		return "Too many accounts use this email.";
	}

	protected virtual string _GetTemplateForResponseUnknownError()
	{
		return "Sorry! An unknown error occurred. Please try again later.";
	}

	protected virtual string _GetTemplateForResponseUsernameAllowedCharactersError()
	{
		return "Usernames may only contain letters, numbers, and _.";
	}

	protected virtual string _GetTemplateForResponseUsernameAlreadyInUse()
	{
		return "This username is already in use.";
	}

	protected virtual string _GetTemplateForResponseUsernameExplicit()
	{
		return "This username is not allowed, please try another.";
	}

	protected virtual string _GetTemplateForResponseUsernameInvalid()
	{
		return "Please enter a valid username.";
	}

	protected virtual string _GetTemplateForResponseUsernameInvalidCharacters()
	{
		return "Only a-z, A-Z, 0-9 and _ are allowed.";
	}

	protected virtual string _GetTemplateForResponseUsernameInvalidLength()
	{
		return "Usernames can be 3 to 20 characters long.";
	}

	protected virtual string _GetTemplateForResponseUsernameInvalidUnderscore()
	{
		return "Usernames cannot start or end with _.";
	}

	protected virtual string _GetTemplateForResponseUsernameNotAvailable()
	{
		return "Username not available. Please try again.";
	}

	protected virtual string _GetTemplateForResponseUsernameOrPasswordIncorrect()
	{
		return "Your username or password is incorrect.";
	}

	protected virtual string _GetTemplateForResponseUsernamePasswordRequired()
	{
		return "Username and Password are required.";
	}

	protected virtual string _GetTemplateForResponseUsernamePrivateInfo()
	{
		return "Username might contain private information.";
	}

	protected virtual string _GetTemplateForResponseUsernameRequired()
	{
		return "Username is required.";
	}

	protected virtual string _GetTemplateForResponseUsernameTakenTryAgain()
	{
		return "This username is already taken! Please try a different one.";
	}

	protected virtual string _GetTemplateForResponseUsernameTooManyUnderscores()
	{
		return "Usernames can have at most one _.";
	}
}
