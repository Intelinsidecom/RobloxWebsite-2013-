namespace Roblox.TranslationResources.Authentication;

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
	public override string ActionCreateAccount => "Создать учетную запись";

	/// <summary>
	/// Key: "Action.LinkAccount"
	/// Button text to link 3rd Party Account to a Roblox Account
	/// English String: "Link Account"
	/// </summary>
	public override string ActionLinkAccount => "Привязать учетную запись";

	/// <summary>
	/// Key: "Action.LogInCapitalized"
	/// button label for capitalized words for Log In
	/// English String: "Log In"
	/// </summary>
	public override string ActionLogInCapitalized => "Вход";

	/// <summary>
	/// Key: "Action.ReturnHome"
	/// button label to return the user to home page
	/// English String: "Return Home"
	/// </summary>
	public override string ActionReturnHome => "Домой";

	/// <summary>
	/// Key: "Action.SignUp"
	/// English String: "Sign up"
	/// </summary>
	public override string ActionSignUp => "Регистрация";

	public override string ActionSignupAndSync => "Регистрация и синхронизация";

	/// <summary>
	/// Key: "Action.Submit"
	/// English String: "Submit"
	/// </summary>
	public override string ActionSubmit => "Отправить";

	/// <summary>
	/// Key: "Description.AccountLinkingWarning"
	/// instructions for linking account on signup page for FB based account
	/// English String: "To link to an existing Roblox account, sign in and link them on the account settings page."
	/// </summary>
	public override string DescriptionAccountLinkingWarning => "Чтобы привязать существующую учетную запись Roblox, войдите и откройте страницу настроек учетной записи.";

	/// <summary>
	/// Key: "Description.NoRealName"
	/// description
	/// English String: "Do not use your real name."
	/// </summary>
	public override string DescriptionNoRealName => "Не используйте настоящее имя.";

	/// <summary>
	/// Key: "Description.PrivacyPolicy"
	/// English String: "Privacy Policy"
	/// </summary>
	public override string DescriptionPrivacyPolicy => "Политику конфиденциальности";

	/// <summary>
	/// Key: "Description.TermsOfService"
	/// English String: "Terms of Service"
	/// </summary>
	public override string DescriptionTermsOfService => "Условия предоставления услуг";

	/// <summary>
	/// Key: "GuestSignUpAB.Action.SignUp"
	/// English String: "Sign Up"
	/// </summary>
	public override string GuestSignUpABActionSignUp => "Регистрация";

	/// <summary>
	/// Key: "Heading.ConnectFacebook"
	/// section heading
	/// English String: "Connect to Facebook"
	/// </summary>
	public override string HeadingConnectFacebook => "Подключиться к Facebook";

	/// <summary>
	/// Key: "Heading.CreateAnAccount"
	/// should be capitalized if the language supports capitalization
	/// English String: "CREATE AN ACCOUNT"
	/// </summary>
	public override string HeadingCreateAnAccount => "СОЗДАТЬ УЧЕТНУЮ ЗАПИСЬ";

	/// <summary>
	/// Key: "Heading.LoginHaveFun"
	/// heading for login container
	/// English String: "Log in and start having fun!"
	/// </summary>
	public override string HeadingLoginHaveFun => "Войдите и наслаждайтесь играми!";

	/// <summary>
	/// Key: "Heading.SignupHaveFun"
	/// signup form heading
	/// English String: "Sign up and start having fun!"
	/// </summary>
	public override string HeadingSignupHaveFun => "Зарегистрируйтесь и наслаждайтесь играми!";

	/// <summary>
	/// Key: "Label.About"
	/// About link on roller coaster page
	/// English String: "About"
	/// </summary>
	public override string LabelAbout => "Сведения";

	/// <summary>
	/// Key: "Label.AlreadyHaveRobloxAccount"
	/// English String: "Already have a Roblox account?"
	/// </summary>
	public override string LabelAlreadyHaveRobloxAccount => "Уже есть учетная запись Roblox?";

	/// <summary>
	/// Key: "Label.AlreadyRegistered"
	/// label
	/// English String: "Already registered?"
	/// </summary>
	public override string LabelAlreadyRegistered => "Уже зарегистрированы?";

	/// <summary>
	/// Key: "Label.Birthday"
	/// English String: "Birthday"
	/// </summary>
	public override string LabelBirthday => "Дата рождения";

	/// <summary>
	/// Key: "Label.BirthdayWithColumn"
	/// should have column if the language supports it
	/// English String: "Birthday:"
	/// </summary>
	public override string LabelBirthdayWithColumn => "Дата рождения:";

	/// <summary>
	/// Key: "Label.ConfirmPassword"
	/// English String: "Confirm password"
	/// </summary>
	public override string LabelConfirmPassword => "Подтверждение пароля";

	/// <summary>
	/// Key: "Label.Day"
	/// English String: "Day"
	/// </summary>
	public override string LabelDay => "День";

	/// <summary>
	/// Key: "Label.DesiredUsername"
	/// should have a column if the language supports it
	/// English String: "Desired Username:"
	/// </summary>
	public override string LabelDesiredUsername => "Желаемое имя пользователя:";

	/// <summary>
	/// Key: "Label.FacebookNotLinked"
	/// English String: "Your Facebook account is not linked to any Roblox account. Please sign up for a Roblox account."
	/// </summary>
	public override string LabelFacebookNotLinked => "€Ваша учетная запись Facebook не привязана к Roblox. Пожалуйста, привяжите ее к Roblox.";

	/// <summary>
	/// Key: "Label.FacebookSignupUsername"
	/// username field label for FB signup
	/// English String: "Create Roblox username:"
	/// </summary>
	public override string LabelFacebookSignupUsername => "Придумайте имя пользователя Roblox:";

	/// <summary>
	/// Key: "Label.Female"
	/// label
	/// English String: "Female"
	/// </summary>
	public override string LabelFemale => "Женский";

	/// <summary>
	/// Key: "Label.Gender"
	/// English String: "Gender"
	/// </summary>
	public override string LabelGender => "Пол";

	/// <summary>
	/// Key: "Label.GenderRequired"
	/// English String: "Gender is required."
	/// </summary>
	public override string LabelGenderRequired => "Требуется указать пол.";

	/// <summary>
	/// Key: "Label.GenderWithColumn"
	/// should have column if the language supports it
	/// English String: "Gender:"
	/// </summary>
	public override string LabelGenderWithColumn => "Пол:";

	/// <summary>
	/// Key: "Label.Male"
	/// label
	/// English String: "Male"
	/// </summary>
	public override string LabelMale => "Мужской";

	/// <summary>
	/// Key: "Label.Month"
	/// English String: "Month"
	/// </summary>
	public override string LabelMonth => "Месяц";

	/// <summary>
	/// Key: "Label.Password"
	/// English String: "Password"
	/// </summary>
	public override string LabelPassword => "Пароль";

	/// <summary>
	/// Key: "Label.PasswordRequirements"
	/// English String: "Password (min length 8)"
	/// </summary>
	public override string LabelPasswordRequirements => "Пароль (не менее 8 символов)";

	/// <summary>
	/// Key: "Label.Platforms"
	/// platforms link on roller coaster page
	/// English String: "Platforms"
	/// </summary>
	public override string LabelPlatforms => "Платформы";

	/// <summary>
	/// Key: "Label.Play"
	/// Play link on roller coaster page
	/// English String: "Play"
	/// </summary>
	public override string LabelPlay => "Играть";

	/// <summary>
	/// Key: "Label.PleaseAgreeToTerms"
	/// English String: "Please agree to our Terms of Use and Privacy Policy."
	/// </summary>
	public override string LabelPleaseAgreeToTerms => "Примите наши Условия предоставления услуг и Политику конфиденциальности.";

	/// <summary>
	/// Key: "Label.Required"
	/// Required
	/// English String: "Required"
	/// </summary>
	public override string LabelRequired => "Обязательно";

	/// <summary>
	/// Key: "Label.SignupButtonText"
	/// sign up button text
	/// English String: "Sign Up and Play!"
	/// </summary>
	public override string LabelSignupButtonText => "Зарегистрируйтесь и играйте!";

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
	public override string LabelSignUpWith => "или войти с помощью";

	/// <summary>
	/// Key: "Label.TermsOfUse"
	/// terms of use link label
	/// English String: "Terms of Use"
	/// </summary>
	public override string LabelTermsOfUse => "Условия использования";

	/// <summary>
	/// Key: "Label.Username"
	/// English String: "Username"
	/// </summary>
	public override string LabelUsername => "Имя пользователя";

	/// <summary>
	/// Key: "Label.UsernameCharacterLimit"
	/// label
	/// English String: "3-20 alphanumeric characters, no spaces."
	/// </summary>
	public override string LabelUsernameCharacterLimit => "От 3 до 20 букв или цифр без пробелов.";

	/// <summary>
	/// Key: "Label.UsernameHint"
	/// placeholder for username field
	/// English String: "Username (don't use your real name)"
	/// </summary>
	public override string LabelUsernameHint => "Имя пользователя (не указывайте настоящее имя)";

	/// <summary>
	/// Key: "Label.UsernameRequirements"
	/// English String: "Username (length 3-20, _ is allowed)"
	/// </summary>
	public override string LabelUsernameRequirements => "Имя пользователя (3-20 символов, допускается символ _)";

	/// <summary>
	/// Key: "Label.Year"
	/// English String: "Year"
	/// </summary>
	public override string LabelYear => "Год";

	/// <summary>
	/// Key: "Message.Password.MinLength"
	/// English String: "Min length 8"
	/// </summary>
	public override string MessagePasswordMinLength => "Не менее 8 символов";

	/// <summary>
	/// Key: "Message.Username.NoRealNameUse"
	/// English String: "Don't use your real name"
	/// </summary>
	public override string MessageUsernameNoRealNameUse => "Не указывайте свое настоящее имя";

	/// <summary>
	/// Key: "Response.BadUsername"
	/// English String: "Username not appropriate for Roblox."
	/// </summary>
	public override string ResponseBadUsername => "Имя пользователя не подходит для Roblox.";

	/// <summary>
	/// Key: "Response.BadUsernameForWeChat"
	/// message shown when signing up with an inappropriate username
	/// English String: "Username is not appropriate"
	/// </summary>
	public override string ResponseBadUsernameForWeChat => "Имя пользователя не разрешено";

	/// <summary>
	/// Key: "Response.BirthdayInvalid"
	/// English String: "This birthday is invalid."
	/// </summary>
	public override string ResponseBirthdayInvalid => "Неверная дата рождения.";

	/// <summary>
	/// Key: "Response.BirthdayMustBeSetFirst"
	/// English String: "Birthday must be set first."
	/// </summary>
	public override string ResponseBirthdayMustBeSetFirst => "Сначала требуется указать дату рождения.";

	/// <summary>
	/// Key: "Response.CaptchaMismatchError"
	/// error message
	/// English String: "Words do not match."
	/// </summary>
	public override string ResponseCaptchaMismatchError => "Слова не совпадают.";

	/// <summary>
	/// Key: "Response.CaptchaNotEnteredError"
	/// validation error message
	/// English String: "Please fill out the Captcha"
	/// </summary>
	public override string ResponseCaptchaNotEnteredError => "Пожалуйста, заполните капчу";

	/// <summary>
	/// Key: "Response.FacebookConnectionError"
	/// error message
	/// English String: "Error while retrieving values from Facebook."
	/// </summary>
	public override string ResponseFacebookConnectionError => "Ошибка при получении данных от Facebook.";

	/// <summary>
	/// Key: "Response.FacebookLoginAge"
	/// English String: "Facebook login can only be used by users above 13."
	/// </summary>
	public override string ResponseFacebookLoginAge => "Вход через Facebook может быть произведен пользователями только старше 13 лет.";

	/// <summary>
	/// Key: "Response.InvalidBirthday"
	/// English String: "Invalid birthday."
	/// </summary>
	public override string ResponseInvalidBirthday => "Недопустимая дата рождения.";

	/// <summary>
	/// Key: "Response.InvalidEmail"
	/// English String: "Invalid email address."
	/// </summary>
	public override string ResponseInvalidEmail => "Недопустимый адрес эл. почты.";

	/// <summary>
	/// Key: "Response.JavaScriptRequired"
	/// error to show that JavaScipt is required for the form to work
	/// English String: "JavaScript is required to submit this form."
	/// </summary>
	public override string ResponseJavaScriptRequired => "Для отправки формы требуется JavaScript.";

	/// <summary>
	/// Key: "Response.PasswordComplexity"
	/// English String: "Please create a more complex password."
	/// </summary>
	public override string ResponsePasswordComplexity => "Придумайте более сложный пароль.";

	/// <summary>
	/// Key: "Response.PasswordConfirmation"
	/// validation message for password confirmation
	/// English String: "Please enter a password confirmation."
	/// </summary>
	public override string ResponsePasswordConfirmation => "Пожалуйста, подтвердите пароль.";

	/// <summary>
	/// Key: "Response.PasswordContainsUsernameError"
	/// error when passsword has username in it
	/// English String: "Password shouldn't match username."
	/// </summary>
	public override string ResponsePasswordContainsUsernameError => "Пароль не должен совпадать с именем пользователя.";

	/// <summary>
	/// Key: "Response.PasswordMismatch"
	/// English String: "Passwords do not match."
	/// </summary>
	public override string ResponsePasswordMismatch => "Пароли не совпадают.";

	/// <summary>
	/// Key: "Response.PasswordWrongShort"
	/// English String: "Passwords must be at least 8 characters long."
	/// </summary>
	public override string ResponsePasswordWrongShort => "Пароль должен содержать не менее 8 знаков.";

	/// <summary>
	/// Key: "Response.PleaseEnterPassword"
	/// English String: "Please enter a password."
	/// </summary>
	public override string ResponsePleaseEnterPassword => "Введите пароль.";

	/// <summary>
	/// Key: "Response.PleaseEnterUsername"
	/// English String: "Please enter a username."
	/// </summary>
	public override string ResponsePleaseEnterUsername => "Введите имя пользователя.";

	/// <summary>
	/// Key: "Response.SocialAccountCreationFailed"
	/// error message
	/// English String: "Account creation failed"
	/// </summary>
	public override string ResponseSocialAccountCreationFailed => "Учетная запись не создана";

	/// <summary>
	/// Key: "Response.SpaceOrSpecialCharaterError"
	/// Spaces and special characters are not allowed error message
	/// English String: "Spaces and special characters are not allowed."
	/// </summary>
	public override string ResponseSpaceOrSpecialCharaterError => "Нельзя использовать пробел и специальные символы.";

	/// <summary>
	/// Key: "Response.TooManyAccountsWithSameEmailError"
	/// Too many accounts use this email error message
	/// English String: "Too many accounts use this email."
	/// </summary>
	public override string ResponseTooManyAccountsWithSameEmailError => "Слишком много учетных записей используют этот адрес эл. почты.";

	/// <summary>
	/// Key: "Response.UnknownError"
	/// English String: "Sorry! An unknown error occurred. Please try again later."
	/// </summary>
	public override string ResponseUnknownError => "К сожалению, произошла неизвестная ошибка. Повторите попытку позже.";

	/// <summary>
	/// Key: "Response.UsernameAllowedCharactersError"
	/// error showing which characters are allowed for username
	/// English String: "Usernames may only contain letters, numbers, and _."
	/// </summary>
	public override string ResponseUsernameAllowedCharactersError => "Имя пользователя может содержать только буквы, цифры и знак _.";

	/// <summary>
	/// Key: "Response.UsernameAlreadyInUse"
	/// English String: "This username is already in use."
	/// </summary>
	public override string ResponseUsernameAlreadyInUse => "Это имя пользователя уже занято.";

	/// <summary>
	/// Key: "Response.UsernameExplicit"
	/// English String: "This username is not allowed, please try another."
	/// </summary>
	public override string ResponseUsernameExplicit => "Недопустимое имя. Выберите другое.";

	/// <summary>
	/// Key: "Response.UsernameInvalid"
	/// English String: "Please enter a valid username."
	/// </summary>
	public override string ResponseUsernameInvalid => "Введите допустимое имя пользователя.";

	/// <summary>
	/// Key: "Response.UsernameInvalidCharacters"
	/// English String: "Only a-z, A-Z, 0-9 and _ are allowed."
	/// </summary>
	public override string ResponseUsernameInvalidCharacters => "Допускаются только символы a–z, A–Z, 0-9 и _.";

	/// <summary>
	/// Key: "Response.UsernameInvalidLength"
	/// English String: "Usernames can be 3 to 20 characters long."
	/// </summary>
	public override string ResponseUsernameInvalidLength => "Введите от 3 до 20 символов.";

	/// <summary>
	/// Key: "Response.UsernameInvalidUnderscore"
	/// English String: "Usernames cannot start or end with _."
	/// </summary>
	public override string ResponseUsernameInvalidUnderscore => "Имя не может начинаться/заканчиваться _.";

	/// <summary>
	/// Key: "Response.UsernameNotAvailable"
	/// English String: "Username not available. Please try again."
	/// </summary>
	public override string ResponseUsernameNotAvailable => "Имя пользователя недоступно. Повторите попытку";

	/// <summary>
	/// Key: "Response.UsernameOrPasswordIncorrect"
	/// Your username or password is incorrect
	/// English String: "Your username or password is incorrect."
	/// </summary>
	public override string ResponseUsernameOrPasswordIncorrect => "Неправильный пароль или имя пользователя.";

	/// <summary>
	/// Key: "Response.UsernamePasswordRequired"
	/// Username and Password are required error message
	/// English String: "Username and Password are required."
	/// </summary>
	public override string ResponseUsernamePasswordRequired => "Необходимо указать имя пользователя и пароль.";

	/// <summary>
	/// Key: "Response.UsernamePrivateInfo"
	/// English String: "Username might contain private information."
	/// </summary>
	public override string ResponseUsernamePrivateInfo => "Имя пользователя может содержать личные данные.";

	/// <summary>
	/// Key: "Response.UsernameRequired"
	/// validation error message
	/// English String: "Username is required."
	/// </summary>
	public override string ResponseUsernameRequired => "Требуется указать имя пользователя.";

	/// <summary>
	/// Key: "Response.UsernameTakenTryAgain"
	/// English String: "This username is already taken! Please try a different one."
	/// </summary>
	public override string ResponseUsernameTakenTryAgain => "Это имя пользователя уже занято!";

	/// <summary>
	/// Key: "Response.UsernameTooManyUnderscores"
	/// English String: "Usernames can have at most one _."
	/// </summary>
	public override string ResponseUsernameTooManyUnderscores => "Имя может содержать не более одного _.";

	public SignUpResources_ru_ru(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionCreateAccount()
	{
		return "Создать учетную запись";
	}

	protected override string _GetTemplateForActionLinkAccount()
	{
		return "Привязать учетную запись";
	}

	protected override string _GetTemplateForActionLogInCapitalized()
	{
		return "Вход";
	}

	protected override string _GetTemplateForActionReturnHome()
	{
		return "Домой";
	}

	protected override string _GetTemplateForActionSignUp()
	{
		return "Регистрация";
	}

	protected override string _GetTemplateForActionSignupAndSync()
	{
		return "Регистрация и синхронизация";
	}

	protected override string _GetTemplateForActionSubmit()
	{
		return "Отправить";
	}

	protected override string _GetTemplateForDescriptionAccountLinkingWarning()
	{
		return "Чтобы привязать существующую учетную запись Roblox, войдите и откройте страницу настроек учетной записи.";
	}

	protected override string _GetTemplateForDescriptionNoRealName()
	{
		return "Не используйте настоящее имя.";
	}

	protected override string _GetTemplateForDescriptionPrivacyPolicy()
	{
		return "Политику конфиденциальности";
	}

	/// <summary>
	/// Key: "Description.SignUpAgreement"
	/// terms of use agreement checkbox label to signup.
	/// English String: "By clicking {spanStart}Sign Up{spanEnd}, you are agreeing to the {termsOfUseLink} and acknowledging the {privacyPolicyLink}"
	/// </summary>
	public override string DescriptionSignUpAgreement(string spanStart, string spanEnd, string termsOfUseLink, string privacyPolicyLink)
	{
		return $"Нажав кнопку {spanStart}«Регистрация»{spanEnd}, вы принимаете условия документов: {termsOfUseLink} и {privacyPolicyLink}";
	}

	protected override string _GetTemplateForDescriptionSignUpAgreement()
	{
		return "Нажав кнопку {spanStart}«Регистрация»{spanEnd}, вы принимаете условия документов: {termsOfUseLink} и {privacyPolicyLink}";
	}

	protected override string _GetTemplateForDescriptionTermsOfService()
	{
		return "Условия предоставления услуг";
	}

	protected override string _GetTemplateForGuestSignUpABActionSignUp()
	{
		return "Регистрация";
	}

	protected override string _GetTemplateForHeadingConnectFacebook()
	{
		return "Подключиться к Facebook";
	}

	protected override string _GetTemplateForHeadingCreateAnAccount()
	{
		return "СОЗДАТЬ УЧЕТНУЮ ЗАПИСЬ";
	}

	/// <summary>
	/// Key: "Heading.FacebookSignupAlmostDone"
	/// when user signs up using Facebook, this is shown in next step to create a password.
	/// English String: "{firstname}, YOU'RE ALMOST DONE"
	/// </summary>
	public override string HeadingFacebookSignupAlmostDone(string firstname)
	{
		return $"{firstname}, ВЫ ПОЧТИ ЗАКОНЧИЛИ";
	}

	protected override string _GetTemplateForHeadingFacebookSignupAlmostDone()
	{
		return "{firstname}, ВЫ ПОЧТИ ЗАКОНЧИЛИ";
	}

	protected override string _GetTemplateForHeadingLoginHaveFun()
	{
		return "Войдите и наслаждайтесь играми!";
	}

	protected override string _GetTemplateForHeadingSignupHaveFun()
	{
		return "Зарегистрируйтесь и наслаждайтесь играми!";
	}

	protected override string _GetTemplateForLabelAbout()
	{
		return "Сведения";
	}

	protected override string _GetTemplateForLabelAlreadyHaveRobloxAccount()
	{
		return "Уже есть учетная запись Roblox?";
	}

	protected override string _GetTemplateForLabelAlreadyRegistered()
	{
		return "Уже зарегистрированы?";
	}

	protected override string _GetTemplateForLabelBirthday()
	{
		return "Дата рождения";
	}

	protected override string _GetTemplateForLabelBirthdayWithColumn()
	{
		return "Дата рождения:";
	}

	protected override string _GetTemplateForLabelConfirmPassword()
	{
		return "Подтверждение пароля";
	}

	protected override string _GetTemplateForLabelDay()
	{
		return "День";
	}

	protected override string _GetTemplateForLabelDesiredUsername()
	{
		return "Желаемое имя пользователя:";
	}

	protected override string _GetTemplateForLabelFacebookNotLinked()
	{
		return "€Ваша учетная запись Facebook не привязана к Roblox. Пожалуйста, привяжите ее к Roblox.";
	}

	protected override string _GetTemplateForLabelFacebookSignupUsername()
	{
		return "Придумайте имя пользователя Roblox:";
	}

	protected override string _GetTemplateForLabelFemale()
	{
		return "Женский";
	}

	protected override string _GetTemplateForLabelGender()
	{
		return "Пол";
	}

	protected override string _GetTemplateForLabelGenderRequired()
	{
		return "Требуется указать пол.";
	}

	protected override string _GetTemplateForLabelGenderWithColumn()
	{
		return "Пол:";
	}

	protected override string _GetTemplateForLabelMale()
	{
		return "Мужской";
	}

	protected override string _GetTemplateForLabelMonth()
	{
		return "Месяц";
	}

	protected override string _GetTemplateForLabelPassword()
	{
		return "Пароль";
	}

	protected override string _GetTemplateForLabelPasswordRequirements()
	{
		return "Пароль (не менее 8 символов)";
	}

	protected override string _GetTemplateForLabelPlatforms()
	{
		return "Платформы";
	}

	protected override string _GetTemplateForLabelPlay()
	{
		return "Играть";
	}

	protected override string _GetTemplateForLabelPleaseAgreeToTerms()
	{
		return "Примите наши Условия предоставления услуг и Политику конфиденциальности.";
	}

	protected override string _GetTemplateForLabelRequired()
	{
		return "Обязательно";
	}

	protected override string _GetTemplateForLabelSignupButtonText()
	{
		return "Зарегистрируйтесь и играйте!";
	}

	protected override string _GetTemplateForLabelSignUpWith()
	{
		return "или войти с помощью";
	}

	protected override string _GetTemplateForLabelTermsOfUse()
	{
		return "Условия использования";
	}

	protected override string _GetTemplateForLabelUsername()
	{
		return "Имя пользователя";
	}

	protected override string _GetTemplateForLabelUsernameCharacterLimit()
	{
		return "От 3 до 20 букв или цифр без пробелов.";
	}

	protected override string _GetTemplateForLabelUsernameHint()
	{
		return "Имя пользователя (не указывайте настоящее имя)";
	}

	protected override string _GetTemplateForLabelUsernameRequirements()
	{
		return "Имя пользователя (3-20 символов, допускается символ _)";
	}

	protected override string _GetTemplateForLabelYear()
	{
		return "Год";
	}

	protected override string _GetTemplateForMessagePasswordMinLength()
	{
		return "Не менее 8 символов";
	}

	protected override string _GetTemplateForMessageUsernameNoRealNameUse()
	{
		return "Не указывайте свое настоящее имя";
	}

	protected override string _GetTemplateForResponseBadUsername()
	{
		return "Имя пользователя не подходит для Roblox.";
	}

	protected override string _GetTemplateForResponseBadUsernameForWeChat()
	{
		return "Имя пользователя не разрешено";
	}

	protected override string _GetTemplateForResponseBirthdayInvalid()
	{
		return "Неверная дата рождения.";
	}

	protected override string _GetTemplateForResponseBirthdayMustBeSetFirst()
	{
		return "Сначала требуется указать дату рождения.";
	}

	protected override string _GetTemplateForResponseCaptchaMismatchError()
	{
		return "Слова не совпадают.";
	}

	protected override string _GetTemplateForResponseCaptchaNotEnteredError()
	{
		return "Пожалуйста, заполните капчу";
	}

	protected override string _GetTemplateForResponseFacebookConnectionError()
	{
		return "Ошибка при получении данных от Facebook.";
	}

	protected override string _GetTemplateForResponseFacebookLoginAge()
	{
		return "Вход через Facebook может быть произведен пользователями только старше 13 лет.";
	}

	protected override string _GetTemplateForResponseInvalidBirthday()
	{
		return "Недопустимая дата рождения.";
	}

	protected override string _GetTemplateForResponseInvalidEmail()
	{
		return "Недопустимый адрес эл. почты.";
	}

	protected override string _GetTemplateForResponseJavaScriptRequired()
	{
		return "Для отправки формы требуется JavaScript.";
	}

	protected override string _GetTemplateForResponsePasswordComplexity()
	{
		return "Придумайте более сложный пароль.";
	}

	protected override string _GetTemplateForResponsePasswordConfirmation()
	{
		return "Пожалуйста, подтвердите пароль.";
	}

	protected override string _GetTemplateForResponsePasswordContainsUsernameError()
	{
		return "Пароль не должен совпадать с именем пользователя.";
	}

	protected override string _GetTemplateForResponsePasswordMismatch()
	{
		return "Пароли не совпадают.";
	}

	protected override string _GetTemplateForResponsePasswordWrongShort()
	{
		return "Пароль должен содержать не менее 8 знаков.";
	}

	protected override string _GetTemplateForResponsePleaseEnterPassword()
	{
		return "Введите пароль.";
	}

	protected override string _GetTemplateForResponsePleaseEnterUsername()
	{
		return "Введите имя пользователя.";
	}

	protected override string _GetTemplateForResponseSocialAccountCreationFailed()
	{
		return "Учетная запись не создана";
	}

	protected override string _GetTemplateForResponseSpaceOrSpecialCharaterError()
	{
		return "Нельзя использовать пробел и специальные символы.";
	}

	protected override string _GetTemplateForResponseTooManyAccountsWithSameEmailError()
	{
		return "Слишком много учетных записей используют этот адрес эл. почты.";
	}

	protected override string _GetTemplateForResponseUnknownError()
	{
		return "К сожалению, произошла неизвестная ошибка. Повторите попытку позже.";
	}

	protected override string _GetTemplateForResponseUsernameAllowedCharactersError()
	{
		return "Имя пользователя может содержать только буквы, цифры и знак _.";
	}

	protected override string _GetTemplateForResponseUsernameAlreadyInUse()
	{
		return "Это имя пользователя уже занято.";
	}

	protected override string _GetTemplateForResponseUsernameExplicit()
	{
		return "Недопустимое имя. Выберите другое.";
	}

	protected override string _GetTemplateForResponseUsernameInvalid()
	{
		return "Введите допустимое имя пользователя.";
	}

	protected override string _GetTemplateForResponseUsernameInvalidCharacters()
	{
		return "Допускаются только символы a–z, A–Z, 0-9 и _.";
	}

	protected override string _GetTemplateForResponseUsernameInvalidLength()
	{
		return "Введите от 3 до 20 символов.";
	}

	protected override string _GetTemplateForResponseUsernameInvalidUnderscore()
	{
		return "Имя не может начинаться/заканчиваться _.";
	}

	protected override string _GetTemplateForResponseUsernameNotAvailable()
	{
		return "Имя пользователя недоступно. Повторите попытку";
	}

	protected override string _GetTemplateForResponseUsernameOrPasswordIncorrect()
	{
		return "Неправильный пароль или имя пользователя.";
	}

	protected override string _GetTemplateForResponseUsernamePasswordRequired()
	{
		return "Необходимо указать имя пользователя и пароль.";
	}

	protected override string _GetTemplateForResponseUsernamePrivateInfo()
	{
		return "Имя пользователя может содержать личные данные.";
	}

	protected override string _GetTemplateForResponseUsernameRequired()
	{
		return "Требуется указать имя пользователя.";
	}

	protected override string _GetTemplateForResponseUsernameTakenTryAgain()
	{
		return "Это имя пользователя уже занято!";
	}

	protected override string _GetTemplateForResponseUsernameTooManyUnderscores()
	{
		return "Имя может содержать не более одного _.";
	}
}
