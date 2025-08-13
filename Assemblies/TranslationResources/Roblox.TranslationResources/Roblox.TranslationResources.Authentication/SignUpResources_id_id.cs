namespace Roblox.TranslationResources.Authentication;

/// <summary>
/// This class overrides SignUpResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class SignUpResources_id_id : SignUpResources_en_us, ISignUpResources, ITranslationResources
{
	/// <summary>
	/// Key: "Action.CreateAccount"
	/// create account button label
	/// English String: "Create Account"
	/// </summary>
	public override string ActionCreateAccount => "Buat Akun";

	/// <summary>
	/// Key: "Action.LinkAccount"
	/// Button text to link 3rd Party Account to a Roblox Account
	/// English String: "Link Account"
	/// </summary>
	public override string ActionLinkAccount => "Tautkan Akun";

	/// <summary>
	/// Key: "Action.LogInCapitalized"
	/// button label for capitalized words for Log In
	/// English String: "Log In"
	/// </summary>
	public override string ActionLogInCapitalized => "Masuk";

	/// <summary>
	/// Key: "Action.ReturnHome"
	/// button label to return the user to home page
	/// English String: "Return Home"
	/// </summary>
	public override string ActionReturnHome => "Kembali ke Beranda";

	/// <summary>
	/// Key: "Action.SignUp"
	/// English String: "Sign up"
	/// </summary>
	public override string ActionSignUp => "Daftar";

	public override string ActionSignupAndSync => "Daftar & Sinkronisasi";

	/// <summary>
	/// Key: "Action.Submit"
	/// English String: "Submit"
	/// </summary>
	public override string ActionSubmit => "Kirim";

	/// <summary>
	/// Key: "Description.AccountLinkingWarning"
	/// instructions for linking account on signup page for FB based account
	/// English String: "To link to an existing Roblox account, sign in and link them on the account settings page."
	/// </summary>
	public override string DescriptionAccountLinkingWarning => "Untuk menghubungkan ke akun Roblox yang sudah ada, masuk dan hubungkan akun tersebut di halaman pengaturan akun.";

	/// <summary>
	/// Key: "Description.NoRealName"
	/// description
	/// English String: "Do not use your real name."
	/// </summary>
	public override string DescriptionNoRealName => "Jangan gunakan nama aslimu.";

	/// <summary>
	/// Key: "Description.PrivacyPolicy"
	/// English String: "Privacy Policy"
	/// </summary>
	public override string DescriptionPrivacyPolicy => "Kebijakan Privasi";

	/// <summary>
	/// Key: "Description.TermsOfService"
	/// English String: "Terms of Service"
	/// </summary>
	public override string DescriptionTermsOfService => "Ketentuan Layanan";

	/// <summary>
	/// Key: "GuestSignUpAB.Action.SignUp"
	/// English String: "Sign Up"
	/// </summary>
	public override string GuestSignUpABActionSignUp => "Daftar";

	/// <summary>
	/// Key: "Heading.ConnectFacebook"
	/// section heading
	/// English String: "Connect to Facebook"
	/// </summary>
	public override string HeadingConnectFacebook => "Hubungkan ke Facebook";

	/// <summary>
	/// Key: "Heading.CreateAnAccount"
	/// should be capitalized if the language supports capitalization
	/// English String: "CREATE AN ACCOUNT"
	/// </summary>
	public override string HeadingCreateAnAccount => "BUAT AKUN";

	/// <summary>
	/// Key: "Heading.LoginHaveFun"
	/// heading for login container
	/// English String: "Log in and start having fun!"
	/// </summary>
	public override string HeadingLoginHaveFun => "Masuk dan bersenang-senanglah!";

	/// <summary>
	/// Key: "Heading.SignupHaveFun"
	/// signup form heading
	/// English String: "Sign up and start having fun!"
	/// </summary>
	public override string HeadingSignupHaveFun => "Daftar dan bersenang-senanglah!";

	/// <summary>
	/// Key: "Label.About"
	/// About link on roller coaster page
	/// English String: "About"
	/// </summary>
	public override string LabelAbout => "Tentang";

	/// <summary>
	/// Key: "Label.AlreadyHaveRobloxAccount"
	/// English String: "Already have a Roblox account?"
	/// </summary>
	public override string LabelAlreadyHaveRobloxAccount => "Sudah punya akun Roblox?";

	/// <summary>
	/// Key: "Label.AlreadyRegistered"
	/// label
	/// English String: "Already registered?"
	/// </summary>
	public override string LabelAlreadyRegistered => "Sudah terdaftar?";

	/// <summary>
	/// Key: "Label.Birthday"
	/// English String: "Birthday"
	/// </summary>
	public override string LabelBirthday => "Tanggal lahir";

	/// <summary>
	/// Key: "Label.BirthdayWithColumn"
	/// should have column if the language supports it
	/// English String: "Birthday:"
	/// </summary>
	public override string LabelBirthdayWithColumn => "Tanggal Lahir:";

	/// <summary>
	/// Key: "Label.ConfirmPassword"
	/// English String: "Confirm password"
	/// </summary>
	public override string LabelConfirmPassword => "Konfirmasi kata sandi";

	/// <summary>
	/// Key: "Label.Day"
	/// English String: "Day"
	/// </summary>
	public override string LabelDay => "Hari";

	/// <summary>
	/// Key: "Label.DesiredUsername"
	/// should have a column if the language supports it
	/// English String: "Desired Username:"
	/// </summary>
	public override string LabelDesiredUsername => "Nama Pengguna yang Diinginkan:";

	/// <summary>
	/// Key: "Label.FacebookNotLinked"
	/// English String: "Your Facebook account is not linked to any Roblox account. Please sign up for a Roblox account."
	/// </summary>
	public override string LabelFacebookNotLinked => "Akun Facebook Anda tidak terhubung dengan akun Roblox apa pun. Silakan mendaftar akun Roblox.";

	/// <summary>
	/// Key: "Label.FacebookSignupUsername"
	/// username field label for FB signup
	/// English String: "Create Roblox username:"
	/// </summary>
	public override string LabelFacebookSignupUsername => "Buat nama pengguna Roblox:";

	/// <summary>
	/// Key: "Label.Female"
	/// label
	/// English String: "Female"
	/// </summary>
	public override string LabelFemale => "Perempuan";

	/// <summary>
	/// Key: "Label.Gender"
	/// English String: "Gender"
	/// </summary>
	public override string LabelGender => "Jenis Kelamin";

	/// <summary>
	/// Key: "Label.GenderRequired"
	/// English String: "Gender is required."
	/// </summary>
	public override string LabelGenderRequired => "Jenis kelamin wajib diisi.";

	/// <summary>
	/// Key: "Label.GenderWithColumn"
	/// should have column if the language supports it
	/// English String: "Gender:"
	/// </summary>
	public override string LabelGenderWithColumn => "Jenis Kelamin:";

	/// <summary>
	/// Key: "Label.Male"
	/// label
	/// English String: "Male"
	/// </summary>
	public override string LabelMale => "Laki-laki";

	/// <summary>
	/// Key: "Label.Month"
	/// English String: "Month"
	/// </summary>
	public override string LabelMonth => "Bulan";

	/// <summary>
	/// Key: "Label.Password"
	/// English String: "Password"
	/// </summary>
	public override string LabelPassword => "Kata sandi";

	/// <summary>
	/// Key: "Label.PasswordRequirements"
	/// English String: "Password (min length 8)"
	/// </summary>
	public override string LabelPasswordRequirements => "Kata sandi (min 8 karakter)";

	/// <summary>
	/// Key: "Label.Platforms"
	/// platforms link on roller coaster page
	/// English String: "Platforms"
	/// </summary>
	public override string LabelPlatforms => "Platform";

	/// <summary>
	/// Key: "Label.Play"
	/// Play link on roller coaster page
	/// English String: "Play"
	/// </summary>
	public override string LabelPlay => "Mainkan";

	/// <summary>
	/// Key: "Label.PleaseAgreeToTerms"
	/// English String: "Please agree to our Terms of Use and Privacy Policy."
	/// </summary>
	public override string LabelPleaseAgreeToTerms => "Harap setujui Ketentuan Penggunaan dan Kebijakan Privasi.";

	/// <summary>
	/// Key: "Label.Required"
	/// Required
	/// English String: "Required"
	/// </summary>
	public override string LabelRequired => "Diperlukan";

	/// <summary>
	/// Key: "Label.SignupButtonText"
	/// sign up button text
	/// English String: "Sign Up and Play!"
	/// </summary>
	public override string LabelSignupButtonText => "Daftar dan Mainkan!";

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
	public override string LabelSignUpWith => "atau daftar dengan";

	/// <summary>
	/// Key: "Label.TermsOfUse"
	/// terms of use link label
	/// English String: "Terms of Use"
	/// </summary>
	public override string LabelTermsOfUse => "Ketentuan Penggunaan";

	/// <summary>
	/// Key: "Label.Username"
	/// English String: "Username"
	/// </summary>
	public override string LabelUsername => "Nama pengguna";

	/// <summary>
	/// Key: "Label.UsernameCharacterLimit"
	/// label
	/// English String: "3-20 alphanumeric characters, no spaces."
	/// </summary>
	public override string LabelUsernameCharacterLimit => "3-20 karakter alfanumerik, tanpa spasi.";

	/// <summary>
	/// Key: "Label.UsernameHint"
	/// placeholder for username field
	/// English String: "Username (don't use your real name)"
	/// </summary>
	public override string LabelUsernameHint => "Nama pengguna (jangan gunakan nama aslimu)";

	/// <summary>
	/// Key: "Label.UsernameRequirements"
	/// English String: "Username (length 3-20, _ is allowed)"
	/// </summary>
	public override string LabelUsernameRequirements => "Nama pengguna (jumlah karakter 3-20, _ juga boleh digunakan)";

	/// <summary>
	/// Key: "Label.Year"
	/// English String: "Year"
	/// </summary>
	public override string LabelYear => "Tahun";

	/// <summary>
	/// Key: "Message.Password.MinLength"
	/// English String: "Min length 8"
	/// </summary>
	public override string MessagePasswordMinLength => "Min 8 karakter";

	/// <summary>
	/// Key: "Message.Username.NoRealNameUse"
	/// English String: "Don't use your real name"
	/// </summary>
	public override string MessageUsernameNoRealNameUse => "Jangan gunakan nama aslimu";

	/// <summary>
	/// Key: "Response.BadUsername"
	/// English String: "Username not appropriate for Roblox."
	/// </summary>
	public override string ResponseBadUsername => "Nama pengguna tidak pantas untuk Roblox.";

	/// <summary>
	/// Key: "Response.BadUsernameForWeChat"
	/// message shown when signing up with an inappropriate username
	/// English String: "Username is not appropriate"
	/// </summary>
	public override string ResponseBadUsernameForWeChat => "Nama pengguna tidak pantas";

	/// <summary>
	/// Key: "Response.BirthdayInvalid"
	/// English String: "This birthday is invalid."
	/// </summary>
	public override string ResponseBirthdayInvalid => "Tanggal lahir ini tidak valid.";

	/// <summary>
	/// Key: "Response.BirthdayMustBeSetFirst"
	/// English String: "Birthday must be set first."
	/// </summary>
	public override string ResponseBirthdayMustBeSetFirst => "Kamu harus mengatur tanggal lahirmu dahulu.";

	/// <summary>
	/// Key: "Response.CaptchaMismatchError"
	/// error message
	/// English String: "Words do not match."
	/// </summary>
	public override string ResponseCaptchaMismatchError => "Kata tidak sesuai.";

	/// <summary>
	/// Key: "Response.CaptchaNotEnteredError"
	/// validation error message
	/// English String: "Please fill out the Captcha"
	/// </summary>
	public override string ResponseCaptchaNotEnteredError => "Harap mengisi Captcha";

	/// <summary>
	/// Key: "Response.FacebookConnectionError"
	/// error message
	/// English String: "Error while retrieving values from Facebook."
	/// </summary>
	public override string ResponseFacebookConnectionError => "Kesalahan saat mengambil data dari Facebook.";

	/// <summary>
	/// Key: "Response.FacebookLoginAge"
	/// English String: "Facebook login can only be used by users above 13."
	/// </summary>
	public override string ResponseFacebookLoginAge => "Masuk ke Facebook hanya dapat digunakan oleh pengguna di atas 13 tahun.";

	/// <summary>
	/// Key: "Response.InvalidBirthday"
	/// English String: "Invalid birthday."
	/// </summary>
	public override string ResponseInvalidBirthday => "Tanggal lahir tidak valid.";

	/// <summary>
	/// Key: "Response.InvalidEmail"
	/// English String: "Invalid email address."
	/// </summary>
	public override string ResponseInvalidEmail => "Alamat email tidak valid.";

	/// <summary>
	/// Key: "Response.JavaScriptRequired"
	/// error to show that JavaScipt is required for the form to work
	/// English String: "JavaScript is required to submit this form."
	/// </summary>
	public override string ResponseJavaScriptRequired => "JavaScript diperlukan untuk mengirimkan formulir ini.";

	/// <summary>
	/// Key: "Response.PasswordComplexity"
	/// English String: "Please create a more complex password."
	/// </summary>
	public override string ResponsePasswordComplexity => "Harap buat kata sandi yang lebih kompleks.";

	/// <summary>
	/// Key: "Response.PasswordConfirmation"
	/// validation message for password confirmation
	/// English String: "Please enter a password confirmation."
	/// </summary>
	public override string ResponsePasswordConfirmation => "Harap masukkan konfirmasi kata sandi.";

	/// <summary>
	/// Key: "Response.PasswordContainsUsernameError"
	/// error when passsword has username in it
	/// English String: "Password shouldn't match username."
	/// </summary>
	public override string ResponsePasswordContainsUsernameError => "Kata sandi tidak boleh sama dengan nama pengguna.";

	/// <summary>
	/// Key: "Response.PasswordMismatch"
	/// English String: "Passwords do not match."
	/// </summary>
	public override string ResponsePasswordMismatch => "Kata sandi tidak sesuai.";

	/// <summary>
	/// Key: "Response.PasswordWrongShort"
	/// English String: "Passwords must be at least 8 characters long."
	/// </summary>
	public override string ResponsePasswordWrongShort => "Panjang kata sandi minimal 8 karakter.";

	/// <summary>
	/// Key: "Response.PleaseEnterPassword"
	/// English String: "Please enter a password."
	/// </summary>
	public override string ResponsePleaseEnterPassword => "Harap masukkan kata sandi.";

	/// <summary>
	/// Key: "Response.PleaseEnterUsername"
	/// English String: "Please enter a username."
	/// </summary>
	public override string ResponsePleaseEnterUsername => "Harap masukkan nama pengguna.";

	/// <summary>
	/// Key: "Response.SocialAccountCreationFailed"
	/// error message
	/// English String: "Account creation failed"
	/// </summary>
	public override string ResponseSocialAccountCreationFailed => "Pembuatan akun gagal";

	/// <summary>
	/// Key: "Response.SpaceOrSpecialCharaterError"
	/// Spaces and special characters are not allowed error message
	/// English String: "Spaces and special characters are not allowed."
	/// </summary>
	public override string ResponseSpaceOrSpecialCharaterError => "Spasi dan karakter khusus tidak diizinkan.";

	/// <summary>
	/// Key: "Response.TooManyAccountsWithSameEmailError"
	/// Too many accounts use this email error message
	/// English String: "Too many accounts use this email."
	/// </summary>
	public override string ResponseTooManyAccountsWithSameEmailError => "Terlalu banyak akun yang menggunakan email ini.";

	/// <summary>
	/// Key: "Response.UnknownError"
	/// English String: "Sorry! An unknown error occurred. Please try again later."
	/// </summary>
	public override string ResponseUnknownError => "Maaf! Terjadi kesalahan tidak dikenal. Harap coba lagi nanti.";

	/// <summary>
	/// Key: "Response.UsernameAllowedCharactersError"
	/// error showing which characters are allowed for username
	/// English String: "Usernames may only contain letters, numbers, and _."
	/// </summary>
	public override string ResponseUsernameAllowedCharactersError => "Nama pengguna hanya dapat terdiri dari huruf, angka, dan _.";

	/// <summary>
	/// Key: "Response.UsernameAlreadyInUse"
	/// English String: "This username is already in use."
	/// </summary>
	public override string ResponseUsernameAlreadyInUse => "Nama pengguna sudah digunakan.";

	/// <summary>
	/// Key: "Response.UsernameExplicit"
	/// English String: "This username is not allowed, please try another."
	/// </summary>
	public override string ResponseUsernameExplicit => "Nama pengguna tidak diizinkan, coba yang lain.";

	/// <summary>
	/// Key: "Response.UsernameInvalid"
	/// English String: "Please enter a valid username."
	/// </summary>
	public override string ResponseUsernameInvalid => "Harap masukkan nama pengguna yang valid.";

	/// <summary>
	/// Key: "Response.UsernameInvalidCharacters"
	/// English String: "Only a-z, A-Z, 0-9 and _ are allowed."
	/// </summary>
	public override string ResponseUsernameInvalidCharacters => "Karakter yang diizinkan hanyalah a-z, A-Z, 0-9, dan _ .";

	/// <summary>
	/// Key: "Response.UsernameInvalidLength"
	/// English String: "Usernames can be 3 to 20 characters long."
	/// </summary>
	public override string ResponseUsernameInvalidLength => "Nama pengguna dapat terdiri dari 3 hingga 20 karakter.";

	/// <summary>
	/// Key: "Response.UsernameInvalidUnderscore"
	/// English String: "Usernames cannot start or end with _."
	/// </summary>
	public override string ResponseUsernameInvalidUnderscore => "Nama pengguna tak bisa dimulai/diakhiri dengan _.";

	/// <summary>
	/// Key: "Response.UsernameNotAvailable"
	/// English String: "Username not available. Please try again."
	/// </summary>
	public override string ResponseUsernameNotAvailable => "Nama pengguna tidak tersedia. Harap coba lagi.";

	/// <summary>
	/// Key: "Response.UsernameOrPasswordIncorrect"
	/// Your username or password is incorrect
	/// English String: "Your username or password is incorrect."
	/// </summary>
	public override string ResponseUsernameOrPasswordIncorrect => "Nama pengguna dan kata sandimu salah.";

	/// <summary>
	/// Key: "Response.UsernamePasswordRequired"
	/// Username and Password are required error message
	/// English String: "Username and Password are required."
	/// </summary>
	public override string ResponseUsernamePasswordRequired => "Nama Pengguna dan Kata Sandi diperlukan.";

	/// <summary>
	/// Key: "Response.UsernamePrivateInfo"
	/// English String: "Username might contain private information."
	/// </summary>
	public override string ResponseUsernamePrivateInfo => "Nama pengguna mungkin berisi informasi pribadi.";

	/// <summary>
	/// Key: "Response.UsernameRequired"
	/// validation error message
	/// English String: "Username is required."
	/// </summary>
	public override string ResponseUsernameRequired => "Nama pengguna wajib diisi.";

	/// <summary>
	/// Key: "Response.UsernameTakenTryAgain"
	/// English String: "This username is already taken! Please try a different one."
	/// </summary>
	public override string ResponseUsernameTakenTryAgain => "Nama pengguna sudah digunakan!";

	/// <summary>
	/// Key: "Response.UsernameTooManyUnderscores"
	/// English String: "Usernames can have at most one _."
	/// </summary>
	public override string ResponseUsernameTooManyUnderscores => "Nama pengguna boleh menggunakan maks satu _.";

	public SignUpResources_id_id(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionCreateAccount()
	{
		return "Buat Akun";
	}

	protected override string _GetTemplateForActionLinkAccount()
	{
		return "Tautkan Akun";
	}

	protected override string _GetTemplateForActionLogInCapitalized()
	{
		return "Masuk";
	}

	protected override string _GetTemplateForActionReturnHome()
	{
		return "Kembali ke Beranda";
	}

	protected override string _GetTemplateForActionSignUp()
	{
		return "Daftar";
	}

	protected override string _GetTemplateForActionSignupAndSync()
	{
		return "Daftar & Sinkronisasi";
	}

	protected override string _GetTemplateForActionSubmit()
	{
		return "Kirim";
	}

	protected override string _GetTemplateForDescriptionAccountLinkingWarning()
	{
		return "Untuk menghubungkan ke akun Roblox yang sudah ada, masuk dan hubungkan akun tersebut di halaman pengaturan akun.";
	}

	protected override string _GetTemplateForDescriptionNoRealName()
	{
		return "Jangan gunakan nama aslimu.";
	}

	protected override string _GetTemplateForDescriptionPrivacyPolicy()
	{
		return "Kebijakan Privasi";
	}

	/// <summary>
	/// Key: "Description.SignUpAgreement"
	/// terms of use agreement checkbox label to signup.
	/// English String: "By clicking {spanStart}Sign Up{spanEnd}, you are agreeing to the {termsOfUseLink} and acknowledging the {privacyPolicyLink}"
	/// </summary>
	public override string DescriptionSignUpAgreement(string spanStart, string spanEnd, string termsOfUseLink, string privacyPolicyLink)
	{
		return $"Dengan mengeklik {spanStart}Daftar{spanEnd}, kamu menyetujui {termsOfUseLink} dan memahami {privacyPolicyLink}";
	}

	protected override string _GetTemplateForDescriptionSignUpAgreement()
	{
		return "Dengan mengeklik {spanStart}Daftar{spanEnd}, kamu menyetujui {termsOfUseLink} dan memahami {privacyPolicyLink}";
	}

	protected override string _GetTemplateForDescriptionTermsOfService()
	{
		return "Ketentuan Layanan";
	}

	protected override string _GetTemplateForGuestSignUpABActionSignUp()
	{
		return "Daftar";
	}

	protected override string _GetTemplateForHeadingConnectFacebook()
	{
		return "Hubungkan ke Facebook";
	}

	protected override string _GetTemplateForHeadingCreateAnAccount()
	{
		return "BUAT AKUN";
	}

	/// <summary>
	/// Key: "Heading.FacebookSignupAlmostDone"
	/// when user signs up using Facebook, this is shown in next step to create a password.
	/// English String: "{firstname}, YOU'RE ALMOST DONE"
	/// </summary>
	public override string HeadingFacebookSignupAlmostDone(string firstname)
	{
		return $"{firstname}, KAMU HAMPIR SELESAI";
	}

	protected override string _GetTemplateForHeadingFacebookSignupAlmostDone()
	{
		return "{firstname}, KAMU HAMPIR SELESAI";
	}

	protected override string _GetTemplateForHeadingLoginHaveFun()
	{
		return "Masuk dan bersenang-senanglah!";
	}

	protected override string _GetTemplateForHeadingSignupHaveFun()
	{
		return "Daftar dan bersenang-senanglah!";
	}

	protected override string _GetTemplateForLabelAbout()
	{
		return "Tentang";
	}

	protected override string _GetTemplateForLabelAlreadyHaveRobloxAccount()
	{
		return "Sudah punya akun Roblox?";
	}

	protected override string _GetTemplateForLabelAlreadyRegistered()
	{
		return "Sudah terdaftar?";
	}

	protected override string _GetTemplateForLabelBirthday()
	{
		return "Tanggal lahir";
	}

	protected override string _GetTemplateForLabelBirthdayWithColumn()
	{
		return "Tanggal Lahir:";
	}

	protected override string _GetTemplateForLabelConfirmPassword()
	{
		return "Konfirmasi kata sandi";
	}

	protected override string _GetTemplateForLabelDay()
	{
		return "Hari";
	}

	protected override string _GetTemplateForLabelDesiredUsername()
	{
		return "Nama Pengguna yang Diinginkan:";
	}

	protected override string _GetTemplateForLabelFacebookNotLinked()
	{
		return "Akun Facebook Anda tidak terhubung dengan akun Roblox apa pun. Silakan mendaftar akun Roblox.";
	}

	protected override string _GetTemplateForLabelFacebookSignupUsername()
	{
		return "Buat nama pengguna Roblox:";
	}

	protected override string _GetTemplateForLabelFemale()
	{
		return "Perempuan";
	}

	protected override string _GetTemplateForLabelGender()
	{
		return "Jenis Kelamin";
	}

	protected override string _GetTemplateForLabelGenderRequired()
	{
		return "Jenis kelamin wajib diisi.";
	}

	protected override string _GetTemplateForLabelGenderWithColumn()
	{
		return "Jenis Kelamin:";
	}

	protected override string _GetTemplateForLabelMale()
	{
		return "Laki-laki";
	}

	protected override string _GetTemplateForLabelMonth()
	{
		return "Bulan";
	}

	protected override string _GetTemplateForLabelPassword()
	{
		return "Kata sandi";
	}

	protected override string _GetTemplateForLabelPasswordRequirements()
	{
		return "Kata sandi (min 8 karakter)";
	}

	protected override string _GetTemplateForLabelPlatforms()
	{
		return "Platform";
	}

	protected override string _GetTemplateForLabelPlay()
	{
		return "Mainkan";
	}

	protected override string _GetTemplateForLabelPleaseAgreeToTerms()
	{
		return "Harap setujui Ketentuan Penggunaan dan Kebijakan Privasi.";
	}

	protected override string _GetTemplateForLabelRequired()
	{
		return "Diperlukan";
	}

	protected override string _GetTemplateForLabelSignupButtonText()
	{
		return "Daftar dan Mainkan!";
	}

	protected override string _GetTemplateForLabelSignUpWith()
	{
		return "atau daftar dengan";
	}

	protected override string _GetTemplateForLabelTermsOfUse()
	{
		return "Ketentuan Penggunaan";
	}

	protected override string _GetTemplateForLabelUsername()
	{
		return "Nama pengguna";
	}

	protected override string _GetTemplateForLabelUsernameCharacterLimit()
	{
		return "3-20 karakter alfanumerik, tanpa spasi.";
	}

	protected override string _GetTemplateForLabelUsernameHint()
	{
		return "Nama pengguna (jangan gunakan nama aslimu)";
	}

	protected override string _GetTemplateForLabelUsernameRequirements()
	{
		return "Nama pengguna (jumlah karakter 3-20, _ juga boleh digunakan)";
	}

	protected override string _GetTemplateForLabelYear()
	{
		return "Tahun";
	}

	protected override string _GetTemplateForMessagePasswordMinLength()
	{
		return "Min 8 karakter";
	}

	protected override string _GetTemplateForMessageUsernameNoRealNameUse()
	{
		return "Jangan gunakan nama aslimu";
	}

	protected override string _GetTemplateForResponseBadUsername()
	{
		return "Nama pengguna tidak pantas untuk Roblox.";
	}

	protected override string _GetTemplateForResponseBadUsernameForWeChat()
	{
		return "Nama pengguna tidak pantas";
	}

	protected override string _GetTemplateForResponseBirthdayInvalid()
	{
		return "Tanggal lahir ini tidak valid.";
	}

	protected override string _GetTemplateForResponseBirthdayMustBeSetFirst()
	{
		return "Kamu harus mengatur tanggal lahirmu dahulu.";
	}

	protected override string _GetTemplateForResponseCaptchaMismatchError()
	{
		return "Kata tidak sesuai.";
	}

	protected override string _GetTemplateForResponseCaptchaNotEnteredError()
	{
		return "Harap mengisi Captcha";
	}

	protected override string _GetTemplateForResponseFacebookConnectionError()
	{
		return "Kesalahan saat mengambil data dari Facebook.";
	}

	protected override string _GetTemplateForResponseFacebookLoginAge()
	{
		return "Masuk ke Facebook hanya dapat digunakan oleh pengguna di atas 13 tahun.";
	}

	protected override string _GetTemplateForResponseInvalidBirthday()
	{
		return "Tanggal lahir tidak valid.";
	}

	protected override string _GetTemplateForResponseInvalidEmail()
	{
		return "Alamat email tidak valid.";
	}

	protected override string _GetTemplateForResponseJavaScriptRequired()
	{
		return "JavaScript diperlukan untuk mengirimkan formulir ini.";
	}

	protected override string _GetTemplateForResponsePasswordComplexity()
	{
		return "Harap buat kata sandi yang lebih kompleks.";
	}

	protected override string _GetTemplateForResponsePasswordConfirmation()
	{
		return "Harap masukkan konfirmasi kata sandi.";
	}

	protected override string _GetTemplateForResponsePasswordContainsUsernameError()
	{
		return "Kata sandi tidak boleh sama dengan nama pengguna.";
	}

	protected override string _GetTemplateForResponsePasswordMismatch()
	{
		return "Kata sandi tidak sesuai.";
	}

	protected override string _GetTemplateForResponsePasswordWrongShort()
	{
		return "Panjang kata sandi minimal 8 karakter.";
	}

	protected override string _GetTemplateForResponsePleaseEnterPassword()
	{
		return "Harap masukkan kata sandi.";
	}

	protected override string _GetTemplateForResponsePleaseEnterUsername()
	{
		return "Harap masukkan nama pengguna.";
	}

	protected override string _GetTemplateForResponseSocialAccountCreationFailed()
	{
		return "Pembuatan akun gagal";
	}

	protected override string _GetTemplateForResponseSpaceOrSpecialCharaterError()
	{
		return "Spasi dan karakter khusus tidak diizinkan.";
	}

	protected override string _GetTemplateForResponseTooManyAccountsWithSameEmailError()
	{
		return "Terlalu banyak akun yang menggunakan email ini.";
	}

	protected override string _GetTemplateForResponseUnknownError()
	{
		return "Maaf! Terjadi kesalahan tidak dikenal. Harap coba lagi nanti.";
	}

	protected override string _GetTemplateForResponseUsernameAllowedCharactersError()
	{
		return "Nama pengguna hanya dapat terdiri dari huruf, angka, dan _.";
	}

	protected override string _GetTemplateForResponseUsernameAlreadyInUse()
	{
		return "Nama pengguna sudah digunakan.";
	}

	protected override string _GetTemplateForResponseUsernameExplicit()
	{
		return "Nama pengguna tidak diizinkan, coba yang lain.";
	}

	protected override string _GetTemplateForResponseUsernameInvalid()
	{
		return "Harap masukkan nama pengguna yang valid.";
	}

	protected override string _GetTemplateForResponseUsernameInvalidCharacters()
	{
		return "Karakter yang diizinkan hanyalah a-z, A-Z, 0-9, dan _ .";
	}

	protected override string _GetTemplateForResponseUsernameInvalidLength()
	{
		return "Nama pengguna dapat terdiri dari 3 hingga 20 karakter.";
	}

	protected override string _GetTemplateForResponseUsernameInvalidUnderscore()
	{
		return "Nama pengguna tak bisa dimulai/diakhiri dengan _.";
	}

	protected override string _GetTemplateForResponseUsernameNotAvailable()
	{
		return "Nama pengguna tidak tersedia. Harap coba lagi.";
	}

	protected override string _GetTemplateForResponseUsernameOrPasswordIncorrect()
	{
		return "Nama pengguna dan kata sandimu salah.";
	}

	protected override string _GetTemplateForResponseUsernamePasswordRequired()
	{
		return "Nama Pengguna dan Kata Sandi diperlukan.";
	}

	protected override string _GetTemplateForResponseUsernamePrivateInfo()
	{
		return "Nama pengguna mungkin berisi informasi pribadi.";
	}

	protected override string _GetTemplateForResponseUsernameRequired()
	{
		return "Nama pengguna wajib diisi.";
	}

	protected override string _GetTemplateForResponseUsernameTakenTryAgain()
	{
		return "Nama pengguna sudah digunakan!";
	}

	protected override string _GetTemplateForResponseUsernameTooManyUnderscores()
	{
		return "Nama pengguna boleh menggunakan maks satu _.";
	}
}
