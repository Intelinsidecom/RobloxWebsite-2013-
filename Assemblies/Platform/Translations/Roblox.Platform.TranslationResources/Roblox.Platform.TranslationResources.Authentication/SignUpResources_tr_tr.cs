namespace Roblox.Platform.TranslationResources.Authentication {
    /// <summary>

/// This class overrides SignUpResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class SignUpResources_tr_tr : SignUpResources_en_us, ISignUpResources, ITranslationResources
{
	/// <summary>
	/// Key: "Action.CreateAccount"
	/// create account button label
	/// English String: "Create Account"
	/// </summary>
	public override string ActionCreateAccount => "Hesap OluÅŸtur";

	/// <summary>
	/// Key: "Action.LinkAccount"
	/// Button text to link 3rd Party Account to a Roblox Account
	/// English String: "Link Account"
	/// </summary>
	public override string ActionLinkAccount => "HesabÄ± BaÄŸla";

	/// <summary>
	/// Key: "Action.LogInCapitalized"
	/// button label for capitalized words for Log In
	/// English String: "Log In"
	/// </summary>
	public override string ActionLogInCapitalized => "GiriÅŸ Yap";

	/// <summary>
	/// Key: "Action.ReturnHome"
	/// button label to return the user to home page
	/// English String: "Return Home"
	/// </summary>
	public override string ActionReturnHome => "GiriÅŸe DÃ¶n";

	/// <summary>
	/// Key: "Action.SignUp"
	/// English String: "Sign up"
	/// </summary>
	public override string ActionSignUp => "KayÄ±t ol";

	public override string ActionSignupAndSync => "Kaydol ve Senkronize Et";

	/// <summary>
	/// Key: "Action.Submit"
	/// English String: "Submit"
	/// </summary>
	public override string ActionSubmit => "GÃ¶nder";

	/// <summary>
	/// Key: "Description.AccountLinkingWarning"
	/// instructions for linking account on signup page for FB based account
	/// English String: "To link to an existing Roblox account, sign in and link them on the account settings page."
	/// </summary>
	public override string DescriptionAccountLinkingWarning => "Mevcut bir Roblox hesabÄ±nÄ± baÄŸlamak iÃ§in giriÅŸ yap ve hesap ayarlarÄ± sayfasÄ±ndan baÄŸlantÄ±yÄ± kur.";

	/// <summary>
	/// Key: "Description.NoRealName"
	/// description
	/// English String: "Do not use your real name."
	/// </summary>
	public override string DescriptionNoRealName => "GerÃ§ek adÄ±nÄ± kullanma.";

	/// <summary>
	/// Key: "Description.PrivacyPolicy"
	/// English String: "Privacy Policy"
	/// </summary>
	public override string DescriptionPrivacyPolicy => "Gizlilik PolitikasÄ±";

	/// <summary>
	/// Key: "Description.TermsOfService"
	/// English String: "Terms of Service"
	/// </summary>
	public override string DescriptionTermsOfService => "Hizmet KoÅŸullarÄ±";

	/// <summary>
	/// Key: "GuestSignUpAB.Action.SignUp"
	/// English String: "Sign Up"
	/// </summary>
	public override string GuestSignUpABActionSignUp => "KayÄ±t Ol";

	/// <summary>
	/// Key: "Heading.ConnectFacebook"
	/// section heading
	/// English String: "Connect to Facebook"
	/// </summary>
	public override string HeadingConnectFacebook => "Facebook'a BaÄŸlan";

	/// <summary>
	/// Key: "Heading.CreateAnAccount"
	/// should be capitalized if the language supports capitalization
	/// English String: "CREATE AN ACCOUNT"
	/// </summary>
	public override string HeadingCreateAnAccount => "BÄ°R HESAP OLUÅžTUR";

	/// <summary>
	/// Key: "Heading.LoginHaveFun"
	/// heading for login container
	/// English String: "Log in and start having fun!"
	/// </summary>
	public override string HeadingLoginHaveFun => "GiriÅŸ yap ve eÄŸlenmeye baÅŸla!";

	/// <summary>
	/// Key: "Heading.SignupHaveFun"
	/// signup form heading
	/// English String: "Sign up and start having fun!"
	/// </summary>
	public override string HeadingSignupHaveFun => "Kaydol ve eÄŸlenmeye baÅŸla!";

	/// <summary>
	/// Key: "Label.About"
	/// About link on roller coaster page
	/// English String: "About"
	/// </summary>
	public override string LabelAbout => "HakkÄ±nda";

	/// <summary>
	/// Key: "Label.AlreadyHaveRobloxAccount"
	/// English String: "Already have a Roblox account?"
	/// </summary>
	public override string LabelAlreadyHaveRobloxAccount => "Zaten bir Roblox hesabÄ±n var mÄ±?";

	/// <summary>
	/// Key: "Label.AlreadyRegistered"
	/// label
	/// English String: "Already registered?"
	/// </summary>
	public override string LabelAlreadyRegistered => "Zaten kayÄ±tlÄ± mÄ±sÄ±n?";

	/// <summary>
	/// Key: "Label.Birthday"
	/// English String: "Birthday"
	/// </summary>
	public override string LabelBirthday => "DoÄŸum GÃ¼nÃ¼";

	/// <summary>
	/// Key: "Label.BirthdayWithColumn"
	/// should have column if the language supports it
	/// English String: "Birthday:"
	/// </summary>
	public override string LabelBirthdayWithColumn => "DoÄŸum GÃ¼nÃ¼:";

	/// <summary>
	/// Key: "Label.ConfirmPassword"
	/// English String: "Confirm password"
	/// </summary>
	public override string LabelConfirmPassword => "Åžifreyi doÄŸrula";

	/// <summary>
	/// Key: "Label.Day"
	/// English String: "Day"
	/// </summary>
	public override string LabelDay => "GÃ¼n";

	/// <summary>
	/// Key: "Label.DesiredUsername"
	/// should have a column if the language supports it
	/// English String: "Desired Username:"
	/// </summary>
	public override string LabelDesiredUsername => "Ä°stenen KullanÄ±cÄ± AdÄ±:";

	/// <summary>
	/// Key: "Label.FacebookNotLinked"
	/// English String: "Your Facebook account is not linked to any Roblox account. Please sign up for a Roblox account."
	/// </summary>
	public override string LabelFacebookNotLinked => "Facebook hesabÄ±n herhangi bir Roblox hesabÄ±na baÄŸlÄ± deÄŸil. Bir Roblox hesabÄ± iÃ§in lÃ¼tfen kaydol.";

	/// <summary>
	/// Key: "Label.FacebookSignupUsername"
	/// username field label for FB signup
	/// English String: "Create Roblox username:"
	/// </summary>
	public override string LabelFacebookSignupUsername => "Roblox kullanÄ±cÄ± adÄ± oluÅŸtur:";

	/// <summary>
	/// Key: "Label.Female"
	/// label
	/// English String: "Female"
	/// </summary>
	public override string LabelFemale => "KadÄ±n";

	/// <summary>
	/// Key: "Label.Gender"
	/// English String: "Gender"
	/// </summary>
	public override string LabelGender => "Cinsiyet";

	/// <summary>
	/// Key: "Label.GenderRequired"
	/// English String: "Gender is required."
	/// </summary>
	public override string LabelGenderRequired => "Cinsiyet gereklidir.";

	/// <summary>
	/// Key: "Label.GenderWithColumn"
	/// should have column if the language supports it
	/// English String: "Gender:"
	/// </summary>
	public override string LabelGenderWithColumn => "Cinsiyet:";

	/// <summary>
	/// Key: "Label.Male"
	/// label
	/// English String: "Male"
	/// </summary>
	public override string LabelMale => "Erkek";

	/// <summary>
	/// Key: "Label.Month"
	/// English String: "Month"
	/// </summary>
	public override string LabelMonth => "Ay";

	/// <summary>
	/// Key: "Label.Password"
	/// English String: "Password"
	/// </summary>
	public override string LabelPassword => "Åžifre";

	/// <summary>
	/// Key: "Label.PasswordRequirements"
	/// English String: "Password (min length 8)"
	/// </summary>
	public override string LabelPasswordRequirements => "Åžifre (en az 8 karakter)";

	/// <summary>
	/// Key: "Label.Platforms"
	/// platforms link on roller coaster page
	/// English String: "Platforms"
	/// </summary>
	public override string LabelPlatforms => "Platformlar";

	/// <summary>
	/// Key: "Label.Play"
	/// Play link on roller coaster page
	/// English String: "Play"
	/// </summary>
	public override string LabelPlay => "Oyna";

	/// <summary>
	/// Key: "Label.PleaseAgreeToTerms"
	/// English String: "Please agree to our Terms of Use and Privacy Policy."
	/// </summary>
	public override string LabelPleaseAgreeToTerms => "LÃ¼tfen Hizmet KoÅŸullarÄ± ve Gizlilik PolitikamÄ±zÄ± kabul et.";

	/// <summary>
	/// Key: "Label.Required"
	/// Required
	/// English String: "Required"
	/// </summary>
	public override string LabelRequired => "Gerekli";

	/// <summary>
	/// Key: "Label.SignupButtonText"
	/// sign up button text
	/// English String: "Sign Up and Play!"
	/// </summary>
	public override string LabelSignupButtonText => "Kaydol ve Oyna!";

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
	public override string LabelSignUpWith => "veya ÅŸununla kaydol:";

	/// <summary>
	/// Key: "Label.TermsOfUse"
	/// terms of use link label
	/// English String: "Terms of Use"
	/// </summary>
	public override string LabelTermsOfUse => "KullanÄ±m KoÅŸullarÄ±";

	/// <summary>
	/// Key: "Label.Username"
	/// English String: "Username"
	/// </summary>
	public override string LabelUsername => "KullanÄ±cÄ± AdÄ±";

	/// <summary>
	/// Key: "Label.UsernameCharacterLimit"
	/// label
	/// English String: "3-20 alphanumeric characters, no spaces."
	/// </summary>
	public override string LabelUsernameCharacterLimit => "BoÅŸluk kullanmadan 3-20 alfanÃ¼merik karakter.";

	/// <summary>
	/// Key: "Label.UsernameHint"
	/// placeholder for username field
	/// English String: "Username (don't use your real name)"
	/// </summary>
	public override string LabelUsernameHint => "KullanÄ±cÄ± AdÄ± (gerÃ§ek adÄ±nÄ± kullanma)";

	/// <summary>
	/// Key: "Label.UsernameRequirements"
	/// English String: "Username (length 3-20, _ is allowed)"
	/// </summary>
	public override string LabelUsernameRequirements => "KullanÄ±cÄ± AdÄ± (uzunluk 3-20 karakter, _ kullanÄ±labilir)";

	/// <summary>
	/// Key: "Label.Year"
	/// English String: "Year"
	/// </summary>
	public override string LabelYear => "YÄ±l";

	/// <summary>
	/// Key: "Message.Password.MinLength"
	/// English String: "Min length 8"
	/// </summary>
	public override string MessagePasswordMinLength => "En az 8 karakter";

	/// <summary>
	/// Key: "Message.Username.NoRealNameUse"
	/// English String: "Don't use your real name"
	/// </summary>
	public override string MessageUsernameNoRealNameUse => "GerÃ§ek adÄ±nÄ± kullanma";

	/// <summary>
	/// Key: "Response.BadUsername"
	/// English String: "Username not appropriate for Roblox."
	/// </summary>
	public override string ResponseBadUsername => "KullanÄ±cÄ± adÄ± Roblox iÃ§in uygun deÄŸil.";

	/// <summary>
	/// Key: "Response.BadUsernameForWeChat"
	/// message shown when signing up with an inappropriate username
	/// English String: "Username is not appropriate"
	/// </summary>
	public override string ResponseBadUsernameForWeChat => "KullanÄ±cÄ± adÄ± uygun deÄŸil";

	/// <summary>
	/// Key: "Response.BirthdayInvalid"
	/// English String: "This birthday is invalid."
	/// </summary>
	public override string ResponseBirthdayInvalid => "Bu doÄŸum gÃ¼nÃ¼ geÃ§ersiz.";

	/// <summary>
	/// Key: "Response.BirthdayMustBeSetFirst"
	/// English String: "Birthday must be set first."
	/// </summary>
	public override string ResponseBirthdayMustBeSetFirst => "Ã–nce doÄŸum gÃ¼nÃ¼ ayarlanmalÄ±.";

	/// <summary>
	/// Key: "Response.CaptchaMismatchError"
	/// error message
	/// English String: "Words do not match."
	/// </summary>
	public override string ResponseCaptchaMismatchError => "SÃ¶zcÃ¼kler eÅŸleÅŸmiyor.";

	/// <summary>
	/// Key: "Response.CaptchaNotEnteredError"
	/// validation error message
	/// English String: "Please fill out the Captcha"
	/// </summary>
	public override string ResponseCaptchaNotEnteredError => "LÃ¼tfen Captcha'yÄ± doldur";

	/// <summary>
	/// Key: "Response.FacebookConnectionError"
	/// error message
	/// English String: "Error while retrieving values from Facebook."
	/// </summary>
	public override string ResponseFacebookConnectionError => "Facebook'tan deÄŸerler getirilirken bir hata oluÅŸtu.";

	/// <summary>
	/// Key: "Response.FacebookLoginAge"
	/// English String: "Facebook login can only be used by users above 13."
	/// </summary>
	public override string ResponseFacebookLoginAge => "Facebook ile giriÅŸi, sadece 13 yaÅŸÄ±nÄ±n Ã¼zerindeki kullanÄ±cÄ±lar kullanabilir.";

	/// <summary>
	/// Key: "Response.InvalidBirthday"
	/// English String: "Invalid birthday."
	/// </summary>
	public override string ResponseInvalidBirthday => "GeÃ§ersiz doÄŸum gÃ¼nÃ¼.";

	/// <summary>
	/// Key: "Response.InvalidEmail"
	/// English String: "Invalid email address."
	/// </summary>
	public override string ResponseInvalidEmail => "GeÃ§ersiz e-posta adresi.";

	/// <summary>
	/// Key: "Response.JavaScriptRequired"
	/// error to show that JavaScipt is required for the form to work
	/// English String: "JavaScript is required to submit this form."
	/// </summary>
	public override string ResponseJavaScriptRequired => "Bu formu gÃ¶ndermek iÃ§in JavaScript gereklidir.";

	/// <summary>
	/// Key: "Response.PasswordComplexity"
	/// English String: "Please create a more complex password."
	/// </summary>
	public override string ResponsePasswordComplexity => "LÃ¼tfen daha karmaÅŸÄ±k bir ÅŸifre oluÅŸtur.";

	/// <summary>
	/// Key: "Response.PasswordConfirmation"
	/// validation message for password confirmation
	/// English String: "Please enter a password confirmation."
	/// </summary>
	public override string ResponsePasswordConfirmation => "LÃ¼tfen bir ÅŸifre onayÄ± gir.";

	/// <summary>
	/// Key: "Response.PasswordContainsUsernameError"
	/// error when passsword has username in it
	/// English String: "Password shouldn't match username."
	/// </summary>
	public override string ResponsePasswordContainsUsernameError => "Åžifreler ve kullanÄ±cÄ± adlarÄ± aynÄ± olmamalÄ±.";

	/// <summary>
	/// Key: "Response.PasswordMismatch"
	/// English String: "Passwords do not match."
	/// </summary>
	public override string ResponsePasswordMismatch => "Åžifreler eÅŸleÅŸmiyor.";

	/// <summary>
	/// Key: "Response.PasswordWrongShort"
	/// English String: "Passwords must be at least 8 characters long."
	/// </summary>
	public override string ResponsePasswordWrongShort => "Åžifre en az 8 karakter olmalÄ±dÄ±r.";

	/// <summary>
	/// Key: "Response.PleaseEnterPassword"
	/// English String: "Please enter a password."
	/// </summary>
	public override string ResponsePleaseEnterPassword => "LÃ¼tfen bir ÅŸifre gir.";

	/// <summary>
	/// Key: "Response.PleaseEnterUsername"
	/// English String: "Please enter a username."
	/// </summary>
	public override string ResponsePleaseEnterUsername => "LÃ¼tfen bir kullanÄ±cÄ± adÄ± gir.";

	/// <summary>
	/// Key: "Response.SocialAccountCreationFailed"
	/// error message
	/// English String: "Account creation failed"
	/// </summary>
	public override string ResponseSocialAccountCreationFailed => "Hesap oluÅŸturma baÅŸarÄ±sÄ±z";

	/// <summary>
	/// Key: "Response.SpaceOrSpecialCharaterError"
	/// Spaces and special characters are not allowed error message
	/// English String: "Spaces and special characters are not allowed."
	/// </summary>
	public override string ResponseSpaceOrSpecialCharaterError => "BoÅŸluklara ve Ã¶zel karakterlere izin verilmez.";

	/// <summary>
	/// Key: "Response.TooManyAccountsWithSameEmailError"
	/// Too many accounts use this email error message
	/// English String: "Too many accounts use this email."
	/// </summary>
	public override string ResponseTooManyAccountsWithSameEmailError => "Bu e-posta adresi Ã§ok fazla hesap tarafÄ±ndan kullanÄ±lÄ±yor.";

	/// <summary>
	/// Key: "Response.UnknownError"
	/// English String: "Sorry! An unknown error occurred. Please try again later."
	/// </summary>
	public override string ResponseUnknownError => "Ã–zrÃ¼ dileriz! Bilinmeyen bir hata meydana geldi. LÃ¼tfen daha sonra tekrar dene.";

	/// <summary>
	/// Key: "Response.UsernameAllowedCharactersError"
	/// error showing which characters are allowed for username
	/// English String: "Usernames may only contain letters, numbers, and _."
	/// </summary>
	public override string ResponseUsernameAllowedCharactersError => "KullanÄ±cÄ± adlarÄ± sadece harf, sayÄ± ve _ iÃ§erebilir.";

	/// <summary>
	/// Key: "Response.UsernameAlreadyInUse"
	/// English String: "This username is already in use."
	/// </summary>
	public override string ResponseUsernameAlreadyInUse => "Bu kullanÄ±cÄ± adÄ± zaten kullanÄ±lÄ±yor.";

	/// <summary>
	/// Key: "Response.UsernameExplicit"
	/// English String: "This username is not allowed, please try another."
	/// </summary>
	public override string ResponseUsernameExplicit => "Bu kullanÄ±cÄ± adÄ±na izin verilmiyor, lÃ¼tfen baÅŸka bir tane dene.";

	/// <summary>
	/// Key: "Response.UsernameInvalid"
	/// English String: "Please enter a valid username."
	/// </summary>
	public override string ResponseUsernameInvalid => "LÃ¼tfen geÃ§erli bir kullanÄ±cÄ± adÄ± gir.";

	/// <summary>
	/// Key: "Response.UsernameInvalidCharacters"
	/// English String: "Only a-z, A-Z, 0-9 and _ are allowed."
	/// </summary>
	public override string ResponseUsernameInvalidCharacters => "Sadece a-z, A-Z, 0-9 ve _ kullanÄ±labilir.";

	/// <summary>
	/// Key: "Response.UsernameInvalidLength"
	/// English String: "Usernames can be 3 to 20 characters long."
	/// </summary>
	public override string ResponseUsernameInvalidLength => "KullanÄ±cÄ± adlarÄ± 3 ila 20 karakter uzunluÄŸunda olabilir.";

	/// <summary>
	/// Key: "Response.UsernameInvalidUnderscore"
	/// English String: "Usernames cannot start or end with _."
	/// </summary>
	public override string ResponseUsernameInvalidUnderscore => "KullanÄ±cÄ± adlarÄ± _ ile baÅŸlayamaz veya bitemez.";

	/// <summary>
	/// Key: "Response.UsernameNotAvailable"
	/// English String: "Username not available. Please try again."
	/// </summary>
	public override string ResponseUsernameNotAvailable => "KullanÄ±cÄ± adÄ± uygun deÄŸil. LÃ¼tfen tekrar dene.";

	/// <summary>
	/// Key: "Response.UsernameOrPasswordIncorrect"
	/// Your username or password is incorrect
	/// English String: "Your username or password is incorrect."
	/// </summary>
	public override string ResponseUsernameOrPasswordIncorrect => "KullanÄ±cÄ± adÄ±n ya da ÅŸifren hatalÄ±.";

	/// <summary>
	/// Key: "Response.UsernamePasswordRequired"
	/// Username and Password are required error message
	/// English String: "Username and Password are required."
	/// </summary>
	public override string ResponseUsernamePasswordRequired => "KullanÄ±cÄ± AdÄ± ve Åžifre gereklidir.";

	/// <summary>
	/// Key: "Response.UsernamePrivateInfo"
	/// English String: "Username might contain private information."
	/// </summary>
	public override string ResponseUsernamePrivateInfo => "KullanÄ±cÄ± adÄ± Ã¶zel bilgiler iÃ§eriyor olabilir.";

	/// <summary>
	/// Key: "Response.UsernameRequired"
	/// validation error message
	/// English String: "Username is required."
	/// </summary>
	public override string ResponseUsernameRequired => "KullanÄ±cÄ± adÄ± gereklidir.";

	/// <summary>
	/// Key: "Response.UsernameTakenTryAgain"
	/// English String: "This username is already taken! Please try a different one."
	/// </summary>
	public override string ResponseUsernameTakenTryAgain => "Bu kullanÄ±cÄ± adÄ± alÄ±nmÄ±ÅŸ! LÃ¼tfen farklÄ± bir tane dene.";

	/// <summary>
	/// Key: "Response.UsernameTooManyUnderscores"
	/// English String: "Usernames can have at most one _."
	/// </summary>
	public override string ResponseUsernameTooManyUnderscores => "KullanÄ±cÄ± adÄ±nda en fazla bir tane _ olabilir.";

	public SignUpResources_tr_tr(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionCreateAccount()
	{
		return "Hesap OluÅŸtur";
	}

	protected override string _GetTemplateForActionLinkAccount()
	{
		return "HesabÄ± BaÄŸla";
	}

	protected override string _GetTemplateForActionLogInCapitalized()
	{
		return "GiriÅŸ Yap";
	}

	protected override string _GetTemplateForActionReturnHome()
	{
		return "GiriÅŸe DÃ¶n";
	}

	protected override string _GetTemplateForActionSignUp()
	{
		return "KayÄ±t ol";
	}

	protected override string _GetTemplateForActionSignupAndSync()
	{
		return "Kaydol ve Senkronize Et";
	}

	protected override string _GetTemplateForActionSubmit()
	{
		return "GÃ¶nder";
	}

	protected override string _GetTemplateForDescriptionAccountLinkingWarning()
	{
		return "Mevcut bir Roblox hesabÄ±nÄ± baÄŸlamak iÃ§in giriÅŸ yap ve hesap ayarlarÄ± sayfasÄ±ndan baÄŸlantÄ±yÄ± kur.";
	}

	protected override string _GetTemplateForDescriptionNoRealName()
	{
		return "GerÃ§ek adÄ±nÄ± kullanma.";
	}

	protected override string _GetTemplateForDescriptionPrivacyPolicy()
	{
		return "Gizlilik PolitikasÄ±";
	}

	/// <summary>
	/// Key: "Description.SignUpAgreement"
	/// terms of use agreement checkbox label to signup.
	/// English String: "By clicking {spanStart}Sign Up{spanEnd}, you are agreeing to the {termsOfUseLink} and acknowledging the {privacyPolicyLink}"
	/// </summary>
	public override string DescriptionSignUpAgreement(string spanStart, string spanEnd, string termsOfUseLink, string privacyPolicyLink)
	{
		return $"{spanStart}Kaydol{spanEnd}'a tÄ±klayarak ÅŸunlarÄ± kabul etmiÅŸ ve onaylamÄ±ÅŸ sayÄ±lÄ±rsÄ±n: {termsOfUseLink} ve {privacyPolicyLink}";
	}

	protected override string _GetTemplateForDescriptionSignUpAgreement()
	{
		return "{spanStart}Kaydol{spanEnd}'a tÄ±klayarak ÅŸunlarÄ± kabul etmiÅŸ ve onaylamÄ±ÅŸ sayÄ±lÄ±rsÄ±n: {termsOfUseLink} ve {privacyPolicyLink}";
	}

	protected override string _GetTemplateForDescriptionTermsOfService()
	{
		return "Hizmet KoÅŸullarÄ±";
	}

	protected override string _GetTemplateForGuestSignUpABActionSignUp()
	{
		return "KayÄ±t Ol";
	}

	protected override string _GetTemplateForHeadingConnectFacebook()
	{
		return "Facebook'a BaÄŸlan";
	}

	protected override string _GetTemplateForHeadingCreateAnAccount()
	{
		return "BÄ°R HESAP OLUÅžTUR";
	}

	/// <summary>
	/// Key: "Heading.FacebookSignupAlmostDone"
	/// when user signs up using Facebook, this is shown in next step to create a password.
	/// English String: "{firstname}, YOU'RE ALMOST DONE"
	/// </summary>
	public override string HeadingFacebookSignupAlmostDone(string firstname)
	{
		return $"{firstname}, NEREDEYSE TAMAMLADIN";
	}

	protected override string _GetTemplateForHeadingFacebookSignupAlmostDone()
	{
		return "{firstname}, NEREDEYSE TAMAMLADIN";
	}

	protected override string _GetTemplateForHeadingLoginHaveFun()
	{
		return "GiriÅŸ yap ve eÄŸlenmeye baÅŸla!";
	}

	protected override string _GetTemplateForHeadingSignupHaveFun()
	{
		return "Kaydol ve eÄŸlenmeye baÅŸla!";
	}

	protected override string _GetTemplateForLabelAbout()
	{
		return "HakkÄ±nda";
	}

	protected override string _GetTemplateForLabelAlreadyHaveRobloxAccount()
	{
		return "Zaten bir Roblox hesabÄ±n var mÄ±?";
	}

	protected override string _GetTemplateForLabelAlreadyRegistered()
	{
		return "Zaten kayÄ±tlÄ± mÄ±sÄ±n?";
	}

	protected override string _GetTemplateForLabelBirthday()
	{
		return "DoÄŸum GÃ¼nÃ¼";
	}

	protected override string _GetTemplateForLabelBirthdayWithColumn()
	{
		return "DoÄŸum GÃ¼nÃ¼:";
	}

	protected override string _GetTemplateForLabelConfirmPassword()
	{
		return "Åžifreyi doÄŸrula";
	}

	protected override string _GetTemplateForLabelDay()
	{
		return "GÃ¼n";
	}

	protected override string _GetTemplateForLabelDesiredUsername()
	{
		return "Ä°stenen KullanÄ±cÄ± AdÄ±:";
	}

	protected override string _GetTemplateForLabelFacebookNotLinked()
	{
		return "Facebook hesabÄ±n herhangi bir Roblox hesabÄ±na baÄŸlÄ± deÄŸil. Bir Roblox hesabÄ± iÃ§in lÃ¼tfen kaydol.";
	}

	protected override string _GetTemplateForLabelFacebookSignupUsername()
	{
		return "Roblox kullanÄ±cÄ± adÄ± oluÅŸtur:";
	}

	protected override string _GetTemplateForLabelFemale()
	{
		return "KadÄ±n";
	}

	protected override string _GetTemplateForLabelGender()
	{
		return "Cinsiyet";
	}

	protected override string _GetTemplateForLabelGenderRequired()
	{
		return "Cinsiyet gereklidir.";
	}

	protected override string _GetTemplateForLabelGenderWithColumn()
	{
		return "Cinsiyet:";
	}

	protected override string _GetTemplateForLabelMale()
	{
		return "Erkek";
	}

	protected override string _GetTemplateForLabelMonth()
	{
		return "Ay";
	}

	protected override string _GetTemplateForLabelPassword()
	{
		return "Åžifre";
	}

	protected override string _GetTemplateForLabelPasswordRequirements()
	{
		return "Åžifre (en az 8 karakter)";
	}

	protected override string _GetTemplateForLabelPlatforms()
	{
		return "Platformlar";
	}

	protected override string _GetTemplateForLabelPlay()
	{
		return "Oyna";
	}

	protected override string _GetTemplateForLabelPleaseAgreeToTerms()
	{
		return "LÃ¼tfen Hizmet KoÅŸullarÄ± ve Gizlilik PolitikamÄ±zÄ± kabul et.";
	}

	protected override string _GetTemplateForLabelRequired()
	{
		return "Gerekli";
	}

	protected override string _GetTemplateForLabelSignupButtonText()
	{
		return "Kaydol ve Oyna!";
	}

	protected override string _GetTemplateForLabelSignUpWith()
	{
		return "veya ÅŸununla kaydol:";
	}

	protected override string _GetTemplateForLabelTermsOfUse()
	{
		return "KullanÄ±m KoÅŸullarÄ±";
	}

	protected override string _GetTemplateForLabelUsername()
	{
		return "KullanÄ±cÄ± AdÄ±";
	}

	protected override string _GetTemplateForLabelUsernameCharacterLimit()
	{
		return "BoÅŸluk kullanmadan 3-20 alfanÃ¼merik karakter.";
	}

	protected override string _GetTemplateForLabelUsernameHint()
	{
		return "KullanÄ±cÄ± AdÄ± (gerÃ§ek adÄ±nÄ± kullanma)";
	}

	protected override string _GetTemplateForLabelUsernameRequirements()
	{
		return "KullanÄ±cÄ± AdÄ± (uzunluk 3-20 karakter, _ kullanÄ±labilir)";
	}

	protected override string _GetTemplateForLabelYear()
	{
		return "YÄ±l";
	}

	protected override string _GetTemplateForMessagePasswordMinLength()
	{
		return "En az 8 karakter";
	}

	protected override string _GetTemplateForMessageUsernameNoRealNameUse()
	{
		return "GerÃ§ek adÄ±nÄ± kullanma";
	}

	protected override string _GetTemplateForResponseBadUsername()
	{
		return "KullanÄ±cÄ± adÄ± Roblox iÃ§in uygun deÄŸil.";
	}

	protected override string _GetTemplateForResponseBadUsernameForWeChat()
	{
		return "KullanÄ±cÄ± adÄ± uygun deÄŸil";
	}

	protected override string _GetTemplateForResponseBirthdayInvalid()
	{
		return "Bu doÄŸum gÃ¼nÃ¼ geÃ§ersiz.";
	}

	protected override string _GetTemplateForResponseBirthdayMustBeSetFirst()
	{
		return "Ã–nce doÄŸum gÃ¼nÃ¼ ayarlanmalÄ±.";
	}

	protected override string _GetTemplateForResponseCaptchaMismatchError()
	{
		return "SÃ¶zcÃ¼kler eÅŸleÅŸmiyor.";
	}

	protected override string _GetTemplateForResponseCaptchaNotEnteredError()
	{
		return "LÃ¼tfen Captcha'yÄ± doldur";
	}

	protected override string _GetTemplateForResponseFacebookConnectionError()
	{
		return "Facebook'tan deÄŸerler getirilirken bir hata oluÅŸtu.";
	}

	protected override string _GetTemplateForResponseFacebookLoginAge()
	{
		return "Facebook ile giriÅŸi, sadece 13 yaÅŸÄ±nÄ±n Ã¼zerindeki kullanÄ±cÄ±lar kullanabilir.";
	}

	protected override string _GetTemplateForResponseInvalidBirthday()
	{
		return "GeÃ§ersiz doÄŸum gÃ¼nÃ¼.";
	}

	protected override string _GetTemplateForResponseInvalidEmail()
	{
		return "GeÃ§ersiz e-posta adresi.";
	}

	protected override string _GetTemplateForResponseJavaScriptRequired()
	{
		return "Bu formu gÃ¶ndermek iÃ§in JavaScript gereklidir.";
	}

	protected override string _GetTemplateForResponsePasswordComplexity()
	{
		return "LÃ¼tfen daha karmaÅŸÄ±k bir ÅŸifre oluÅŸtur.";
	}

	protected override string _GetTemplateForResponsePasswordConfirmation()
	{
		return "LÃ¼tfen bir ÅŸifre onayÄ± gir.";
	}

	protected override string _GetTemplateForResponsePasswordContainsUsernameError()
	{
		return "Åžifreler ve kullanÄ±cÄ± adlarÄ± aynÄ± olmamalÄ±.";
	}

	protected override string _GetTemplateForResponsePasswordMismatch()
	{
		return "Åžifreler eÅŸleÅŸmiyor.";
	}

	protected override string _GetTemplateForResponsePasswordWrongShort()
	{
		return "Åžifre en az 8 karakter olmalÄ±dÄ±r.";
	}

	protected override string _GetTemplateForResponsePleaseEnterPassword()
	{
		return "LÃ¼tfen bir ÅŸifre gir.";
	}

	protected override string _GetTemplateForResponsePleaseEnterUsername()
	{
		return "LÃ¼tfen bir kullanÄ±cÄ± adÄ± gir.";
	}

	protected override string _GetTemplateForResponseSocialAccountCreationFailed()
	{
		return "Hesap oluÅŸturma baÅŸarÄ±sÄ±z";
	}

	protected override string _GetTemplateForResponseSpaceOrSpecialCharaterError()
	{
		return "BoÅŸluklara ve Ã¶zel karakterlere izin verilmez.";
	}

	protected override string _GetTemplateForResponseTooManyAccountsWithSameEmailError()
	{
		return "Bu e-posta adresi Ã§ok fazla hesap tarafÄ±ndan kullanÄ±lÄ±yor.";
	}

	protected override string _GetTemplateForResponseUnknownError()
	{
		return "Ã–zrÃ¼ dileriz! Bilinmeyen bir hata meydana geldi. LÃ¼tfen daha sonra tekrar dene.";
	}

	protected override string _GetTemplateForResponseUsernameAllowedCharactersError()
	{
		return "KullanÄ±cÄ± adlarÄ± sadece harf, sayÄ± ve _ iÃ§erebilir.";
	}

	protected override string _GetTemplateForResponseUsernameAlreadyInUse()
	{
		return "Bu kullanÄ±cÄ± adÄ± zaten kullanÄ±lÄ±yor.";
	}

	protected override string _GetTemplateForResponseUsernameExplicit()
	{
		return "Bu kullanÄ±cÄ± adÄ±na izin verilmiyor, lÃ¼tfen baÅŸka bir tane dene.";
	}

	protected override string _GetTemplateForResponseUsernameInvalid()
	{
		return "LÃ¼tfen geÃ§erli bir kullanÄ±cÄ± adÄ± gir.";
	}

	protected override string _GetTemplateForResponseUsernameInvalidCharacters()
	{
		return "Sadece a-z, A-Z, 0-9 ve _ kullanÄ±labilir.";
	}

	protected override string _GetTemplateForResponseUsernameInvalidLength()
	{
		return "KullanÄ±cÄ± adlarÄ± 3 ila 20 karakter uzunluÄŸunda olabilir.";
	}

	protected override string _GetTemplateForResponseUsernameInvalidUnderscore()
	{
		return "KullanÄ±cÄ± adlarÄ± _ ile baÅŸlayamaz veya bitemez.";
	}

	protected override string _GetTemplateForResponseUsernameNotAvailable()
	{
		return "KullanÄ±cÄ± adÄ± uygun deÄŸil. LÃ¼tfen tekrar dene.";
	}

	protected override string _GetTemplateForResponseUsernameOrPasswordIncorrect()
	{
		return "KullanÄ±cÄ± adÄ±n ya da ÅŸifren hatalÄ±.";
	}

	protected override string _GetTemplateForResponseUsernamePasswordRequired()
	{
		return "KullanÄ±cÄ± AdÄ± ve Åžifre gereklidir.";
	}

	protected override string _GetTemplateForResponseUsernamePrivateInfo()
	{
		return "KullanÄ±cÄ± adÄ± Ã¶zel bilgiler iÃ§eriyor olabilir.";
	}

	protected override string _GetTemplateForResponseUsernameRequired()
	{
		return "KullanÄ±cÄ± adÄ± gereklidir.";
	}

	protected override string _GetTemplateForResponseUsernameTakenTryAgain()
	{
		return "Bu kullanÄ±cÄ± adÄ± alÄ±nmÄ±ÅŸ! LÃ¼tfen farklÄ± bir tane dene.";
	}

	protected override string _GetTemplateForResponseUsernameTooManyUnderscores()
	{
		return "KullanÄ±cÄ± adÄ±nda en fazla bir tane _ olabilir.";
	}
}


}
