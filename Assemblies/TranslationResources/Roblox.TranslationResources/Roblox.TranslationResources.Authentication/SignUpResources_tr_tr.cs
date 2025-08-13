namespace Roblox.TranslationResources.Authentication;

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
	public override string ActionCreateAccount => "Hesap Oluştur";

	/// <summary>
	/// Key: "Action.LinkAccount"
	/// Button text to link 3rd Party Account to a Roblox Account
	/// English String: "Link Account"
	/// </summary>
	public override string ActionLinkAccount => "Hesabı Bağla";

	/// <summary>
	/// Key: "Action.LogInCapitalized"
	/// button label for capitalized words for Log In
	/// English String: "Log In"
	/// </summary>
	public override string ActionLogInCapitalized => "Giriş Yap";

	/// <summary>
	/// Key: "Action.ReturnHome"
	/// button label to return the user to home page
	/// English String: "Return Home"
	/// </summary>
	public override string ActionReturnHome => "Girişe Dön";

	/// <summary>
	/// Key: "Action.SignUp"
	/// English String: "Sign up"
	/// </summary>
	public override string ActionSignUp => "Kayıt ol";

	public override string ActionSignupAndSync => "Kaydol ve Senkronize Et";

	/// <summary>
	/// Key: "Action.Submit"
	/// English String: "Submit"
	/// </summary>
	public override string ActionSubmit => "Gönder";

	/// <summary>
	/// Key: "Description.AccountLinkingWarning"
	/// instructions for linking account on signup page for FB based account
	/// English String: "To link to an existing Roblox account, sign in and link them on the account settings page."
	/// </summary>
	public override string DescriptionAccountLinkingWarning => "Mevcut bir Roblox hesabını bağlamak için giriş yap ve hesap ayarları sayfasından bağlantıyı kur.";

	/// <summary>
	/// Key: "Description.NoRealName"
	/// description
	/// English String: "Do not use your real name."
	/// </summary>
	public override string DescriptionNoRealName => "Gerçek adını kullanma.";

	/// <summary>
	/// Key: "Description.PrivacyPolicy"
	/// English String: "Privacy Policy"
	/// </summary>
	public override string DescriptionPrivacyPolicy => "Gizlilik Politikası";

	/// <summary>
	/// Key: "Description.TermsOfService"
	/// English String: "Terms of Service"
	/// </summary>
	public override string DescriptionTermsOfService => "Hizmet Koşulları";

	/// <summary>
	/// Key: "GuestSignUpAB.Action.SignUp"
	/// English String: "Sign Up"
	/// </summary>
	public override string GuestSignUpABActionSignUp => "Kayıt Ol";

	/// <summary>
	/// Key: "Heading.ConnectFacebook"
	/// section heading
	/// English String: "Connect to Facebook"
	/// </summary>
	public override string HeadingConnectFacebook => "Facebook'a Bağlan";

	/// <summary>
	/// Key: "Heading.CreateAnAccount"
	/// should be capitalized if the language supports capitalization
	/// English String: "CREATE AN ACCOUNT"
	/// </summary>
	public override string HeadingCreateAnAccount => "BİR HESAP OLUŞTUR";

	/// <summary>
	/// Key: "Heading.LoginHaveFun"
	/// heading for login container
	/// English String: "Log in and start having fun!"
	/// </summary>
	public override string HeadingLoginHaveFun => "Giriş yap ve eğlenmeye başla!";

	/// <summary>
	/// Key: "Heading.SignupHaveFun"
	/// signup form heading
	/// English String: "Sign up and start having fun!"
	/// </summary>
	public override string HeadingSignupHaveFun => "Kaydol ve eğlenmeye başla!";

	/// <summary>
	/// Key: "Label.About"
	/// About link on roller coaster page
	/// English String: "About"
	/// </summary>
	public override string LabelAbout => "Hakkında";

	/// <summary>
	/// Key: "Label.AlreadyHaveRobloxAccount"
	/// English String: "Already have a Roblox account?"
	/// </summary>
	public override string LabelAlreadyHaveRobloxAccount => "Zaten bir Roblox hesabın var mı?";

	/// <summary>
	/// Key: "Label.AlreadyRegistered"
	/// label
	/// English String: "Already registered?"
	/// </summary>
	public override string LabelAlreadyRegistered => "Zaten kayıtlı mısın?";

	/// <summary>
	/// Key: "Label.Birthday"
	/// English String: "Birthday"
	/// </summary>
	public override string LabelBirthday => "Doğum Günü";

	/// <summary>
	/// Key: "Label.BirthdayWithColumn"
	/// should have column if the language supports it
	/// English String: "Birthday:"
	/// </summary>
	public override string LabelBirthdayWithColumn => "Doğum Günü:";

	/// <summary>
	/// Key: "Label.ConfirmPassword"
	/// English String: "Confirm password"
	/// </summary>
	public override string LabelConfirmPassword => "Şifreyi doğrula";

	/// <summary>
	/// Key: "Label.Day"
	/// English String: "Day"
	/// </summary>
	public override string LabelDay => "Gün";

	/// <summary>
	/// Key: "Label.DesiredUsername"
	/// should have a column if the language supports it
	/// English String: "Desired Username:"
	/// </summary>
	public override string LabelDesiredUsername => "İstenen Kullanıcı Adı:";

	/// <summary>
	/// Key: "Label.FacebookNotLinked"
	/// English String: "Your Facebook account is not linked to any Roblox account. Please sign up for a Roblox account."
	/// </summary>
	public override string LabelFacebookNotLinked => "Facebook hesabın herhangi bir Roblox hesabına bağlı değil. Bir Roblox hesabı için lütfen kaydol.";

	/// <summary>
	/// Key: "Label.FacebookSignupUsername"
	/// username field label for FB signup
	/// English String: "Create Roblox username:"
	/// </summary>
	public override string LabelFacebookSignupUsername => "Roblox kullanıcı adı oluştur:";

	/// <summary>
	/// Key: "Label.Female"
	/// label
	/// English String: "Female"
	/// </summary>
	public override string LabelFemale => "Kadın";

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
	public override string LabelPassword => "Şifre";

	/// <summary>
	/// Key: "Label.PasswordRequirements"
	/// English String: "Password (min length 8)"
	/// </summary>
	public override string LabelPasswordRequirements => "Şifre (en az 8 karakter)";

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
	public override string LabelPleaseAgreeToTerms => "Lütfen Hizmet Koşulları ve Gizlilik Politikamızı kabul et.";

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
	public override string LabelSignUpWith => "veya şununla kaydol:";

	/// <summary>
	/// Key: "Label.TermsOfUse"
	/// terms of use link label
	/// English String: "Terms of Use"
	/// </summary>
	public override string LabelTermsOfUse => "Kullanım Koşulları";

	/// <summary>
	/// Key: "Label.Username"
	/// English String: "Username"
	/// </summary>
	public override string LabelUsername => "Kullanıcı Adı";

	/// <summary>
	/// Key: "Label.UsernameCharacterLimit"
	/// label
	/// English String: "3-20 alphanumeric characters, no spaces."
	/// </summary>
	public override string LabelUsernameCharacterLimit => "Boşluk kullanmadan 3-20 alfanümerik karakter.";

	/// <summary>
	/// Key: "Label.UsernameHint"
	/// placeholder for username field
	/// English String: "Username (don't use your real name)"
	/// </summary>
	public override string LabelUsernameHint => "Kullanıcı Adı (gerçek adını kullanma)";

	/// <summary>
	/// Key: "Label.UsernameRequirements"
	/// English String: "Username (length 3-20, _ is allowed)"
	/// </summary>
	public override string LabelUsernameRequirements => "Kullanıcı Adı (uzunluk 3-20 karakter, _ kullanılabilir)";

	/// <summary>
	/// Key: "Label.Year"
	/// English String: "Year"
	/// </summary>
	public override string LabelYear => "Yıl";

	/// <summary>
	/// Key: "Message.Password.MinLength"
	/// English String: "Min length 8"
	/// </summary>
	public override string MessagePasswordMinLength => "En az 8 karakter";

	/// <summary>
	/// Key: "Message.Username.NoRealNameUse"
	/// English String: "Don't use your real name"
	/// </summary>
	public override string MessageUsernameNoRealNameUse => "Gerçek adını kullanma";

	/// <summary>
	/// Key: "Response.BadUsername"
	/// English String: "Username not appropriate for Roblox."
	/// </summary>
	public override string ResponseBadUsername => "Kullanıcı adı Roblox için uygun değil.";

	/// <summary>
	/// Key: "Response.BadUsernameForWeChat"
	/// message shown when signing up with an inappropriate username
	/// English String: "Username is not appropriate"
	/// </summary>
	public override string ResponseBadUsernameForWeChat => "Kullanıcı adı uygun değil";

	/// <summary>
	/// Key: "Response.BirthdayInvalid"
	/// English String: "This birthday is invalid."
	/// </summary>
	public override string ResponseBirthdayInvalid => "Bu doğum günü geçersiz.";

	/// <summary>
	/// Key: "Response.BirthdayMustBeSetFirst"
	/// English String: "Birthday must be set first."
	/// </summary>
	public override string ResponseBirthdayMustBeSetFirst => "Önce doğum günü ayarlanmalı.";

	/// <summary>
	/// Key: "Response.CaptchaMismatchError"
	/// error message
	/// English String: "Words do not match."
	/// </summary>
	public override string ResponseCaptchaMismatchError => "Sözcükler eşleşmiyor.";

	/// <summary>
	/// Key: "Response.CaptchaNotEnteredError"
	/// validation error message
	/// English String: "Please fill out the Captcha"
	/// </summary>
	public override string ResponseCaptchaNotEnteredError => "Lütfen Captcha'yı doldur";

	/// <summary>
	/// Key: "Response.FacebookConnectionError"
	/// error message
	/// English String: "Error while retrieving values from Facebook."
	/// </summary>
	public override string ResponseFacebookConnectionError => "Facebook'tan değerler getirilirken bir hata oluştu.";

	/// <summary>
	/// Key: "Response.FacebookLoginAge"
	/// English String: "Facebook login can only be used by users above 13."
	/// </summary>
	public override string ResponseFacebookLoginAge => "Facebook ile girişi, sadece 13 yaşının üzerindeki kullanıcılar kullanabilir.";

	/// <summary>
	/// Key: "Response.InvalidBirthday"
	/// English String: "Invalid birthday."
	/// </summary>
	public override string ResponseInvalidBirthday => "Geçersiz doğum günü.";

	/// <summary>
	/// Key: "Response.InvalidEmail"
	/// English String: "Invalid email address."
	/// </summary>
	public override string ResponseInvalidEmail => "Geçersiz e-posta adresi.";

	/// <summary>
	/// Key: "Response.JavaScriptRequired"
	/// error to show that JavaScipt is required for the form to work
	/// English String: "JavaScript is required to submit this form."
	/// </summary>
	public override string ResponseJavaScriptRequired => "Bu formu göndermek için JavaScript gereklidir.";

	/// <summary>
	/// Key: "Response.PasswordComplexity"
	/// English String: "Please create a more complex password."
	/// </summary>
	public override string ResponsePasswordComplexity => "Lütfen daha karmaşık bir şifre oluştur.";

	/// <summary>
	/// Key: "Response.PasswordConfirmation"
	/// validation message for password confirmation
	/// English String: "Please enter a password confirmation."
	/// </summary>
	public override string ResponsePasswordConfirmation => "Lütfen bir şifre onayı gir.";

	/// <summary>
	/// Key: "Response.PasswordContainsUsernameError"
	/// error when passsword has username in it
	/// English String: "Password shouldn't match username."
	/// </summary>
	public override string ResponsePasswordContainsUsernameError => "Şifreler ve kullanıcı adları aynı olmamalı.";

	/// <summary>
	/// Key: "Response.PasswordMismatch"
	/// English String: "Passwords do not match."
	/// </summary>
	public override string ResponsePasswordMismatch => "Şifreler eşleşmiyor.";

	/// <summary>
	/// Key: "Response.PasswordWrongShort"
	/// English String: "Passwords must be at least 8 characters long."
	/// </summary>
	public override string ResponsePasswordWrongShort => "Şifre en az 8 karakter olmalıdır.";

	/// <summary>
	/// Key: "Response.PleaseEnterPassword"
	/// English String: "Please enter a password."
	/// </summary>
	public override string ResponsePleaseEnterPassword => "Lütfen bir şifre gir.";

	/// <summary>
	/// Key: "Response.PleaseEnterUsername"
	/// English String: "Please enter a username."
	/// </summary>
	public override string ResponsePleaseEnterUsername => "Lütfen bir kullanıcı adı gir.";

	/// <summary>
	/// Key: "Response.SocialAccountCreationFailed"
	/// error message
	/// English String: "Account creation failed"
	/// </summary>
	public override string ResponseSocialAccountCreationFailed => "Hesap oluşturma başarısız";

	/// <summary>
	/// Key: "Response.SpaceOrSpecialCharaterError"
	/// Spaces and special characters are not allowed error message
	/// English String: "Spaces and special characters are not allowed."
	/// </summary>
	public override string ResponseSpaceOrSpecialCharaterError => "Boşluklara ve özel karakterlere izin verilmez.";

	/// <summary>
	/// Key: "Response.TooManyAccountsWithSameEmailError"
	/// Too many accounts use this email error message
	/// English String: "Too many accounts use this email."
	/// </summary>
	public override string ResponseTooManyAccountsWithSameEmailError => "Bu e-posta adresi çok fazla hesap tarafından kullanılıyor.";

	/// <summary>
	/// Key: "Response.UnknownError"
	/// English String: "Sorry! An unknown error occurred. Please try again later."
	/// </summary>
	public override string ResponseUnknownError => "Özrü dileriz! Bilinmeyen bir hata meydana geldi. Lütfen daha sonra tekrar dene.";

	/// <summary>
	/// Key: "Response.UsernameAllowedCharactersError"
	/// error showing which characters are allowed for username
	/// English String: "Usernames may only contain letters, numbers, and _."
	/// </summary>
	public override string ResponseUsernameAllowedCharactersError => "Kullanıcı adları sadece harf, sayı ve _ içerebilir.";

	/// <summary>
	/// Key: "Response.UsernameAlreadyInUse"
	/// English String: "This username is already in use."
	/// </summary>
	public override string ResponseUsernameAlreadyInUse => "Bu kullanıcı adı zaten kullanılıyor.";

	/// <summary>
	/// Key: "Response.UsernameExplicit"
	/// English String: "This username is not allowed, please try another."
	/// </summary>
	public override string ResponseUsernameExplicit => "Bu kullanıcı adına izin verilmiyor, lütfen başka bir tane dene.";

	/// <summary>
	/// Key: "Response.UsernameInvalid"
	/// English String: "Please enter a valid username."
	/// </summary>
	public override string ResponseUsernameInvalid => "Lütfen geçerli bir kullanıcı adı gir.";

	/// <summary>
	/// Key: "Response.UsernameInvalidCharacters"
	/// English String: "Only a-z, A-Z, 0-9 and _ are allowed."
	/// </summary>
	public override string ResponseUsernameInvalidCharacters => "Sadece a-z, A-Z, 0-9 ve _ kullanılabilir.";

	/// <summary>
	/// Key: "Response.UsernameInvalidLength"
	/// English String: "Usernames can be 3 to 20 characters long."
	/// </summary>
	public override string ResponseUsernameInvalidLength => "Kullanıcı adları 3 ila 20 karakter uzunluğunda olabilir.";

	/// <summary>
	/// Key: "Response.UsernameInvalidUnderscore"
	/// English String: "Usernames cannot start or end with _."
	/// </summary>
	public override string ResponseUsernameInvalidUnderscore => "Kullanıcı adları _ ile başlayamaz veya bitemez.";

	/// <summary>
	/// Key: "Response.UsernameNotAvailable"
	/// English String: "Username not available. Please try again."
	/// </summary>
	public override string ResponseUsernameNotAvailable => "Kullanıcı adı uygun değil. Lütfen tekrar dene.";

	/// <summary>
	/// Key: "Response.UsernameOrPasswordIncorrect"
	/// Your username or password is incorrect
	/// English String: "Your username or password is incorrect."
	/// </summary>
	public override string ResponseUsernameOrPasswordIncorrect => "Kullanıcı adın ya da şifren hatalı.";

	/// <summary>
	/// Key: "Response.UsernamePasswordRequired"
	/// Username and Password are required error message
	/// English String: "Username and Password are required."
	/// </summary>
	public override string ResponseUsernamePasswordRequired => "Kullanıcı Adı ve Şifre gereklidir.";

	/// <summary>
	/// Key: "Response.UsernamePrivateInfo"
	/// English String: "Username might contain private information."
	/// </summary>
	public override string ResponseUsernamePrivateInfo => "Kullanıcı adı özel bilgiler içeriyor olabilir.";

	/// <summary>
	/// Key: "Response.UsernameRequired"
	/// validation error message
	/// English String: "Username is required."
	/// </summary>
	public override string ResponseUsernameRequired => "Kullanıcı adı gereklidir.";

	/// <summary>
	/// Key: "Response.UsernameTakenTryAgain"
	/// English String: "This username is already taken! Please try a different one."
	/// </summary>
	public override string ResponseUsernameTakenTryAgain => "Bu kullanıcı adı alınmış! Lütfen farklı bir tane dene.";

	/// <summary>
	/// Key: "Response.UsernameTooManyUnderscores"
	/// English String: "Usernames can have at most one _."
	/// </summary>
	public override string ResponseUsernameTooManyUnderscores => "Kullanıcı adında en fazla bir tane _ olabilir.";

	public SignUpResources_tr_tr(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionCreateAccount()
	{
		return "Hesap Oluştur";
	}

	protected override string _GetTemplateForActionLinkAccount()
	{
		return "Hesabı Bağla";
	}

	protected override string _GetTemplateForActionLogInCapitalized()
	{
		return "Giriş Yap";
	}

	protected override string _GetTemplateForActionReturnHome()
	{
		return "Girişe Dön";
	}

	protected override string _GetTemplateForActionSignUp()
	{
		return "Kayıt ol";
	}

	protected override string _GetTemplateForActionSignupAndSync()
	{
		return "Kaydol ve Senkronize Et";
	}

	protected override string _GetTemplateForActionSubmit()
	{
		return "Gönder";
	}

	protected override string _GetTemplateForDescriptionAccountLinkingWarning()
	{
		return "Mevcut bir Roblox hesabını bağlamak için giriş yap ve hesap ayarları sayfasından bağlantıyı kur.";
	}

	protected override string _GetTemplateForDescriptionNoRealName()
	{
		return "Gerçek adını kullanma.";
	}

	protected override string _GetTemplateForDescriptionPrivacyPolicy()
	{
		return "Gizlilik Politikası";
	}

	/// <summary>
	/// Key: "Description.SignUpAgreement"
	/// terms of use agreement checkbox label to signup.
	/// English String: "By clicking {spanStart}Sign Up{spanEnd}, you are agreeing to the {termsOfUseLink} and acknowledging the {privacyPolicyLink}"
	/// </summary>
	public override string DescriptionSignUpAgreement(string spanStart, string spanEnd, string termsOfUseLink, string privacyPolicyLink)
	{
		return $"{spanStart}Kaydol{spanEnd}'a tıklayarak şunları kabul etmiş ve onaylamış sayılırsın: {termsOfUseLink} ve {privacyPolicyLink}";
	}

	protected override string _GetTemplateForDescriptionSignUpAgreement()
	{
		return "{spanStart}Kaydol{spanEnd}'a tıklayarak şunları kabul etmiş ve onaylamış sayılırsın: {termsOfUseLink} ve {privacyPolicyLink}";
	}

	protected override string _GetTemplateForDescriptionTermsOfService()
	{
		return "Hizmet Koşulları";
	}

	protected override string _GetTemplateForGuestSignUpABActionSignUp()
	{
		return "Kayıt Ol";
	}

	protected override string _GetTemplateForHeadingConnectFacebook()
	{
		return "Facebook'a Bağlan";
	}

	protected override string _GetTemplateForHeadingCreateAnAccount()
	{
		return "BİR HESAP OLUŞTUR";
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
		return "Giriş yap ve eğlenmeye başla!";
	}

	protected override string _GetTemplateForHeadingSignupHaveFun()
	{
		return "Kaydol ve eğlenmeye başla!";
	}

	protected override string _GetTemplateForLabelAbout()
	{
		return "Hakkında";
	}

	protected override string _GetTemplateForLabelAlreadyHaveRobloxAccount()
	{
		return "Zaten bir Roblox hesabın var mı?";
	}

	protected override string _GetTemplateForLabelAlreadyRegistered()
	{
		return "Zaten kayıtlı mısın?";
	}

	protected override string _GetTemplateForLabelBirthday()
	{
		return "Doğum Günü";
	}

	protected override string _GetTemplateForLabelBirthdayWithColumn()
	{
		return "Doğum Günü:";
	}

	protected override string _GetTemplateForLabelConfirmPassword()
	{
		return "Şifreyi doğrula";
	}

	protected override string _GetTemplateForLabelDay()
	{
		return "Gün";
	}

	protected override string _GetTemplateForLabelDesiredUsername()
	{
		return "İstenen Kullanıcı Adı:";
	}

	protected override string _GetTemplateForLabelFacebookNotLinked()
	{
		return "Facebook hesabın herhangi bir Roblox hesabına bağlı değil. Bir Roblox hesabı için lütfen kaydol.";
	}

	protected override string _GetTemplateForLabelFacebookSignupUsername()
	{
		return "Roblox kullanıcı adı oluştur:";
	}

	protected override string _GetTemplateForLabelFemale()
	{
		return "Kadın";
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
		return "Şifre";
	}

	protected override string _GetTemplateForLabelPasswordRequirements()
	{
		return "Şifre (en az 8 karakter)";
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
		return "Lütfen Hizmet Koşulları ve Gizlilik Politikamızı kabul et.";
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
		return "veya şununla kaydol:";
	}

	protected override string _GetTemplateForLabelTermsOfUse()
	{
		return "Kullanım Koşulları";
	}

	protected override string _GetTemplateForLabelUsername()
	{
		return "Kullanıcı Adı";
	}

	protected override string _GetTemplateForLabelUsernameCharacterLimit()
	{
		return "Boşluk kullanmadan 3-20 alfanümerik karakter.";
	}

	protected override string _GetTemplateForLabelUsernameHint()
	{
		return "Kullanıcı Adı (gerçek adını kullanma)";
	}

	protected override string _GetTemplateForLabelUsernameRequirements()
	{
		return "Kullanıcı Adı (uzunluk 3-20 karakter, _ kullanılabilir)";
	}

	protected override string _GetTemplateForLabelYear()
	{
		return "Yıl";
	}

	protected override string _GetTemplateForMessagePasswordMinLength()
	{
		return "En az 8 karakter";
	}

	protected override string _GetTemplateForMessageUsernameNoRealNameUse()
	{
		return "Gerçek adını kullanma";
	}

	protected override string _GetTemplateForResponseBadUsername()
	{
		return "Kullanıcı adı Roblox için uygun değil.";
	}

	protected override string _GetTemplateForResponseBadUsernameForWeChat()
	{
		return "Kullanıcı adı uygun değil";
	}

	protected override string _GetTemplateForResponseBirthdayInvalid()
	{
		return "Bu doğum günü geçersiz.";
	}

	protected override string _GetTemplateForResponseBirthdayMustBeSetFirst()
	{
		return "Önce doğum günü ayarlanmalı.";
	}

	protected override string _GetTemplateForResponseCaptchaMismatchError()
	{
		return "Sözcükler eşleşmiyor.";
	}

	protected override string _GetTemplateForResponseCaptchaNotEnteredError()
	{
		return "Lütfen Captcha'yı doldur";
	}

	protected override string _GetTemplateForResponseFacebookConnectionError()
	{
		return "Facebook'tan değerler getirilirken bir hata oluştu.";
	}

	protected override string _GetTemplateForResponseFacebookLoginAge()
	{
		return "Facebook ile girişi, sadece 13 yaşının üzerindeki kullanıcılar kullanabilir.";
	}

	protected override string _GetTemplateForResponseInvalidBirthday()
	{
		return "Geçersiz doğum günü.";
	}

	protected override string _GetTemplateForResponseInvalidEmail()
	{
		return "Geçersiz e-posta adresi.";
	}

	protected override string _GetTemplateForResponseJavaScriptRequired()
	{
		return "Bu formu göndermek için JavaScript gereklidir.";
	}

	protected override string _GetTemplateForResponsePasswordComplexity()
	{
		return "Lütfen daha karmaşık bir şifre oluştur.";
	}

	protected override string _GetTemplateForResponsePasswordConfirmation()
	{
		return "Lütfen bir şifre onayı gir.";
	}

	protected override string _GetTemplateForResponsePasswordContainsUsernameError()
	{
		return "Şifreler ve kullanıcı adları aynı olmamalı.";
	}

	protected override string _GetTemplateForResponsePasswordMismatch()
	{
		return "Şifreler eşleşmiyor.";
	}

	protected override string _GetTemplateForResponsePasswordWrongShort()
	{
		return "Şifre en az 8 karakter olmalıdır.";
	}

	protected override string _GetTemplateForResponsePleaseEnterPassword()
	{
		return "Lütfen bir şifre gir.";
	}

	protected override string _GetTemplateForResponsePleaseEnterUsername()
	{
		return "Lütfen bir kullanıcı adı gir.";
	}

	protected override string _GetTemplateForResponseSocialAccountCreationFailed()
	{
		return "Hesap oluşturma başarısız";
	}

	protected override string _GetTemplateForResponseSpaceOrSpecialCharaterError()
	{
		return "Boşluklara ve özel karakterlere izin verilmez.";
	}

	protected override string _GetTemplateForResponseTooManyAccountsWithSameEmailError()
	{
		return "Bu e-posta adresi çok fazla hesap tarafından kullanılıyor.";
	}

	protected override string _GetTemplateForResponseUnknownError()
	{
		return "Özrü dileriz! Bilinmeyen bir hata meydana geldi. Lütfen daha sonra tekrar dene.";
	}

	protected override string _GetTemplateForResponseUsernameAllowedCharactersError()
	{
		return "Kullanıcı adları sadece harf, sayı ve _ içerebilir.";
	}

	protected override string _GetTemplateForResponseUsernameAlreadyInUse()
	{
		return "Bu kullanıcı adı zaten kullanılıyor.";
	}

	protected override string _GetTemplateForResponseUsernameExplicit()
	{
		return "Bu kullanıcı adına izin verilmiyor, lütfen başka bir tane dene.";
	}

	protected override string _GetTemplateForResponseUsernameInvalid()
	{
		return "Lütfen geçerli bir kullanıcı adı gir.";
	}

	protected override string _GetTemplateForResponseUsernameInvalidCharacters()
	{
		return "Sadece a-z, A-Z, 0-9 ve _ kullanılabilir.";
	}

	protected override string _GetTemplateForResponseUsernameInvalidLength()
	{
		return "Kullanıcı adları 3 ila 20 karakter uzunluğunda olabilir.";
	}

	protected override string _GetTemplateForResponseUsernameInvalidUnderscore()
	{
		return "Kullanıcı adları _ ile başlayamaz veya bitemez.";
	}

	protected override string _GetTemplateForResponseUsernameNotAvailable()
	{
		return "Kullanıcı adı uygun değil. Lütfen tekrar dene.";
	}

	protected override string _GetTemplateForResponseUsernameOrPasswordIncorrect()
	{
		return "Kullanıcı adın ya da şifren hatalı.";
	}

	protected override string _GetTemplateForResponseUsernamePasswordRequired()
	{
		return "Kullanıcı Adı ve Şifre gereklidir.";
	}

	protected override string _GetTemplateForResponseUsernamePrivateInfo()
	{
		return "Kullanıcı adı özel bilgiler içeriyor olabilir.";
	}

	protected override string _GetTemplateForResponseUsernameRequired()
	{
		return "Kullanıcı adı gereklidir.";
	}

	protected override string _GetTemplateForResponseUsernameTakenTryAgain()
	{
		return "Bu kullanıcı adı alınmış! Lütfen farklı bir tane dene.";
	}

	protected override string _GetTemplateForResponseUsernameTooManyUnderscores()
	{
		return "Kullanıcı adında en fazla bir tane _ olabilir.";
	}
}
