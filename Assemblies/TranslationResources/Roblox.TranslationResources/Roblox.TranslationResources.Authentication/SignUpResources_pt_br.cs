namespace Roblox.TranslationResources.Authentication;

/// <summary>
/// This class overrides SignUpResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class SignUpResources_pt_br : SignUpResources_en_us, ISignUpResources, ITranslationResources
{
	/// <summary>
	/// Key: "Action.CreateAccount"
	/// create account button label
	/// English String: "Create Account"
	/// </summary>
	public override string ActionCreateAccount => "Criar conta";

	/// <summary>
	/// Key: "Action.LinkAccount"
	/// Button text to link 3rd Party Account to a Roblox Account
	/// English String: "Link Account"
	/// </summary>
	public override string ActionLinkAccount => "Vincular Conta";

	/// <summary>
	/// Key: "Action.LogInCapitalized"
	/// button label for capitalized words for Log In
	/// English String: "Log In"
	/// </summary>
	public override string ActionLogInCapitalized => "Conectar-se";

	/// <summary>
	/// Key: "Action.ReturnHome"
	/// button label to return the user to home page
	/// English String: "Return Home"
	/// </summary>
	public override string ActionReturnHome => "Voltar ao início";

	/// <summary>
	/// Key: "Action.SignUp"
	/// English String: "Sign up"
	/// </summary>
	public override string ActionSignUp => "Cadastrar-se";

	public override string ActionSignupAndSync => "Cadastre-se e sincronize";

	/// <summary>
	/// Key: "Action.Submit"
	/// English String: "Submit"
	/// </summary>
	public override string ActionSubmit => "Enviar";

	/// <summary>
	/// Key: "Description.AccountLinkingWarning"
	/// instructions for linking account on signup page for FB based account
	/// English String: "To link to an existing Roblox account, sign in and link them on the account settings page."
	/// </summary>
	public override string DescriptionAccountLinkingWarning => "Para vincular a uma conta Roblox existente, conecte-se e vincule na página de configuração de conta.";

	/// <summary>
	/// Key: "Description.NoRealName"
	/// description
	/// English String: "Do not use your real name."
	/// </summary>
	public override string DescriptionNoRealName => "Não use o seu nome real.";

	/// <summary>
	/// Key: "Description.PrivacyPolicy"
	/// English String: "Privacy Policy"
	/// </summary>
	public override string DescriptionPrivacyPolicy => "Política de Privacidade";

	/// <summary>
	/// Key: "Description.TermsOfService"
	/// English String: "Terms of Service"
	/// </summary>
	public override string DescriptionTermsOfService => "Termos de Serviço";

	/// <summary>
	/// Key: "GuestSignUpAB.Action.SignUp"
	/// English String: "Sign Up"
	/// </summary>
	public override string GuestSignUpABActionSignUp => "Cadastrar-se";

	/// <summary>
	/// Key: "Heading.ConnectFacebook"
	/// section heading
	/// English String: "Connect to Facebook"
	/// </summary>
	public override string HeadingConnectFacebook => "Conecte-se ao Facebook";

	/// <summary>
	/// Key: "Heading.CreateAnAccount"
	/// should be capitalized if the language supports capitalization
	/// English String: "CREATE AN ACCOUNT"
	/// </summary>
	public override string HeadingCreateAnAccount => "CRIAR UMA CONTA";

	/// <summary>
	/// Key: "Heading.LoginHaveFun"
	/// heading for login container
	/// English String: "Log in and start having fun!"
	/// </summary>
	public override string HeadingLoginHaveFun => "Conecte-se e comece a se divertir!";

	/// <summary>
	/// Key: "Heading.SignupHaveFun"
	/// signup form heading
	/// English String: "Sign up and start having fun!"
	/// </summary>
	public override string HeadingSignupHaveFun => "Cadastre-se e comece a se divertir!";

	/// <summary>
	/// Key: "Label.About"
	/// About link on roller coaster page
	/// English String: "About"
	/// </summary>
	public override string LabelAbout => "Sobre";

	/// <summary>
	/// Key: "Label.AlreadyHaveRobloxAccount"
	/// English String: "Already have a Roblox account?"
	/// </summary>
	public override string LabelAlreadyHaveRobloxAccount => "Já tem uma conta Roblox?";

	/// <summary>
	/// Key: "Label.AlreadyRegistered"
	/// label
	/// English String: "Already registered?"
	/// </summary>
	public override string LabelAlreadyRegistered => "Já está inscrito?";

	/// <summary>
	/// Key: "Label.Birthday"
	/// English String: "Birthday"
	/// </summary>
	public override string LabelBirthday => "Data de nascimento";

	/// <summary>
	/// Key: "Label.BirthdayWithColumn"
	/// should have column if the language supports it
	/// English String: "Birthday:"
	/// </summary>
	public override string LabelBirthdayWithColumn => "Data de nascimento:";

	/// <summary>
	/// Key: "Label.ConfirmPassword"
	/// English String: "Confirm password"
	/// </summary>
	public override string LabelConfirmPassword => "Confirmar senha";

	/// <summary>
	/// Key: "Label.Day"
	/// English String: "Day"
	/// </summary>
	public override string LabelDay => "Dia";

	/// <summary>
	/// Key: "Label.DesiredUsername"
	/// should have a column if the language supports it
	/// English String: "Desired Username:"
	/// </summary>
	public override string LabelDesiredUsername => "Nome de usuário desejado:";

	/// <summary>
	/// Key: "Label.FacebookNotLinked"
	/// English String: "Your Facebook account is not linked to any Roblox account. Please sign up for a Roblox account."
	/// </summary>
	public override string LabelFacebookNotLinked => "Sua conta do Facebook não está vinculada a nenhuma conta do Roblox. Cadastre uma conta no Roblox.";

	/// <summary>
	/// Key: "Label.FacebookSignupUsername"
	/// username field label for FB signup
	/// English String: "Create Roblox username:"
	/// </summary>
	public override string LabelFacebookSignupUsername => "Criar nome de usuário Roblox:";

	/// <summary>
	/// Key: "Label.Female"
	/// label
	/// English String: "Female"
	/// </summary>
	public override string LabelFemale => "Feminino";

	/// <summary>
	/// Key: "Label.Gender"
	/// English String: "Gender"
	/// </summary>
	public override string LabelGender => "Gênero";

	/// <summary>
	/// Key: "Label.GenderRequired"
	/// English String: "Gender is required."
	/// </summary>
	public override string LabelGenderRequired => "Requer gênero.";

	/// <summary>
	/// Key: "Label.GenderWithColumn"
	/// should have column if the language supports it
	/// English String: "Gender:"
	/// </summary>
	public override string LabelGenderWithColumn => "Gênero:";

	/// <summary>
	/// Key: "Label.Male"
	/// label
	/// English String: "Male"
	/// </summary>
	public override string LabelMale => "Masculino";

	/// <summary>
	/// Key: "Label.Month"
	/// English String: "Month"
	/// </summary>
	public override string LabelMonth => "Mês";

	/// <summary>
	/// Key: "Label.Password"
	/// English String: "Password"
	/// </summary>
	public override string LabelPassword => "Senha";

	/// <summary>
	/// Key: "Label.PasswordRequirements"
	/// English String: "Password (min length 8)"
	/// </summary>
	public override string LabelPasswordRequirements => "Senha (mínimo de 8 caracteres)";

	/// <summary>
	/// Key: "Label.Platforms"
	/// platforms link on roller coaster page
	/// English String: "Platforms"
	/// </summary>
	public override string LabelPlatforms => "Plataformas";

	/// <summary>
	/// Key: "Label.Play"
	/// Play link on roller coaster page
	/// English String: "Play"
	/// </summary>
	public override string LabelPlay => "Jogar";

	/// <summary>
	/// Key: "Label.PleaseAgreeToTerms"
	/// English String: "Please agree to our Terms of Use and Privacy Policy."
	/// </summary>
	public override string LabelPleaseAgreeToTerms => "Concorde com nossos Termos de Serviço e Política de Privacidade.";

	/// <summary>
	/// Key: "Label.Required"
	/// Required
	/// English String: "Required"
	/// </summary>
	public override string LabelRequired => "Necessário";

	/// <summary>
	/// Key: "Label.SignupButtonText"
	/// sign up button text
	/// English String: "Sign Up and Play!"
	/// </summary>
	public override string LabelSignupButtonText => "Cadastre-se e jogue!";

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
	public override string LabelSignUpWith => "ou cadastre-se com";

	/// <summary>
	/// Key: "Label.TermsOfUse"
	/// terms of use link label
	/// English String: "Terms of Use"
	/// </summary>
	public override string LabelTermsOfUse => "Termos de Uso";

	/// <summary>
	/// Key: "Label.Username"
	/// English String: "Username"
	/// </summary>
	public override string LabelUsername => "Usuário";

	/// <summary>
	/// Key: "Label.UsernameCharacterLimit"
	/// label
	/// English String: "3-20 alphanumeric characters, no spaces."
	/// </summary>
	public override string LabelUsernameCharacterLimit => "3-20 caracteres alfanuméricos, sem espaços.";

	/// <summary>
	/// Key: "Label.UsernameHint"
	/// placeholder for username field
	/// English String: "Username (don't use your real name)"
	/// </summary>
	public override string LabelUsernameHint => "Nome de usuário (não use o seu nome real)";

	/// <summary>
	/// Key: "Label.UsernameRequirements"
	/// English String: "Username (length 3-20, _ is allowed)"
	/// </summary>
	public override string LabelUsernameRequirements => "Nome de usuário (3-20 caracteres, _ permitido)";

	/// <summary>
	/// Key: "Label.Year"
	/// English String: "Year"
	/// </summary>
	public override string LabelYear => "Ano";

	/// <summary>
	/// Key: "Message.Password.MinLength"
	/// English String: "Min length 8"
	/// </summary>
	public override string MessagePasswordMinLength => "Mínimo 8 caracteres";

	/// <summary>
	/// Key: "Message.Username.NoRealNameUse"
	/// English String: "Don't use your real name"
	/// </summary>
	public override string MessageUsernameNoRealNameUse => "Não use o seu nome real";

	/// <summary>
	/// Key: "Response.BadUsername"
	/// English String: "Username not appropriate for Roblox."
	/// </summary>
	public override string ResponseBadUsername => "Nome de usuário inapropriado para Roblox.";

	/// <summary>
	/// Key: "Response.BadUsernameForWeChat"
	/// message shown when signing up with an inappropriate username
	/// English String: "Username is not appropriate"
	/// </summary>
	public override string ResponseBadUsernameForWeChat => "Nome de usuário inapropriado";

	/// <summary>
	/// Key: "Response.BirthdayInvalid"
	/// English String: "This birthday is invalid."
	/// </summary>
	public override string ResponseBirthdayInvalid => "Esta data de nascimento é inválida.";

	/// <summary>
	/// Key: "Response.BirthdayMustBeSetFirst"
	/// English String: "Birthday must be set first."
	/// </summary>
	public override string ResponseBirthdayMustBeSetFirst => "A data de nascimento deve ser definida antes.";

	/// <summary>
	/// Key: "Response.CaptchaMismatchError"
	/// error message
	/// English String: "Words do not match."
	/// </summary>
	public override string ResponseCaptchaMismatchError => "As palavras não conferem.";

	/// <summary>
	/// Key: "Response.CaptchaNotEnteredError"
	/// validation error message
	/// English String: "Please fill out the Captcha"
	/// </summary>
	public override string ResponseCaptchaNotEnteredError => "Preencha o Captcha";

	/// <summary>
	/// Key: "Response.FacebookConnectionError"
	/// error message
	/// English String: "Error while retrieving values from Facebook."
	/// </summary>
	public override string ResponseFacebookConnectionError => "Erro ao recuperar valores do Facebook.";

	/// <summary>
	/// Key: "Response.FacebookLoginAge"
	/// English String: "Facebook login can only be used by users above 13."
	/// </summary>
	public override string ResponseFacebookLoginAge => "O login com o Facebook só pode ser usado por usuários com mais de 13 anos.";

	/// <summary>
	/// Key: "Response.InvalidBirthday"
	/// English String: "Invalid birthday."
	/// </summary>
	public override string ResponseInvalidBirthday => "Data de nascimento inválida.";

	/// <summary>
	/// Key: "Response.InvalidEmail"
	/// English String: "Invalid email address."
	/// </summary>
	public override string ResponseInvalidEmail => "Endereço de e-mail inválido.";

	/// <summary>
	/// Key: "Response.JavaScriptRequired"
	/// error to show that JavaScipt is required for the form to work
	/// English String: "JavaScript is required to submit this form."
	/// </summary>
	public override string ResponseJavaScriptRequired => "JavaScript é necessário para enviar este formulário.";

	/// <summary>
	/// Key: "Response.PasswordComplexity"
	/// English String: "Please create a more complex password."
	/// </summary>
	public override string ResponsePasswordComplexity => "Crie uma senha mais complexa.";

	/// <summary>
	/// Key: "Response.PasswordConfirmation"
	/// validation message for password confirmation
	/// English String: "Please enter a password confirmation."
	/// </summary>
	public override string ResponsePasswordConfirmation => "Insira uma confirmação de senha.";

	/// <summary>
	/// Key: "Response.PasswordContainsUsernameError"
	/// error when passsword has username in it
	/// English String: "Password shouldn't match username."
	/// </summary>
	public override string ResponsePasswordContainsUsernameError => "A senha não deve ser igual ao nome de usuário.";

	/// <summary>
	/// Key: "Response.PasswordMismatch"
	/// English String: "Passwords do not match."
	/// </summary>
	public override string ResponsePasswordMismatch => "As senhas não conferem.";

	/// <summary>
	/// Key: "Response.PasswordWrongShort"
	/// English String: "Passwords must be at least 8 characters long."
	/// </summary>
	public override string ResponsePasswordWrongShort => "A senha deve conter pelo menos 8 caracteres.";

	/// <summary>
	/// Key: "Response.PleaseEnterPassword"
	/// English String: "Please enter a password."
	/// </summary>
	public override string ResponsePleaseEnterPassword => "Insira uma senha.";

	/// <summary>
	/// Key: "Response.PleaseEnterUsername"
	/// English String: "Please enter a username."
	/// </summary>
	public override string ResponsePleaseEnterUsername => "Insira um nome de usuário.";

	/// <summary>
	/// Key: "Response.SocialAccountCreationFailed"
	/// error message
	/// English String: "Account creation failed"
	/// </summary>
	public override string ResponseSocialAccountCreationFailed => "Falha ao criar conta";

	/// <summary>
	/// Key: "Response.SpaceOrSpecialCharaterError"
	/// Spaces and special characters are not allowed error message
	/// English String: "Spaces and special characters are not allowed."
	/// </summary>
	public override string ResponseSpaceOrSpecialCharaterError => "Espaços e caracteres especiais não são permitidos.";

	/// <summary>
	/// Key: "Response.TooManyAccountsWithSameEmailError"
	/// Too many accounts use this email error message
	/// English String: "Too many accounts use this email."
	/// </summary>
	public override string ResponseTooManyAccountsWithSameEmailError => "Contas demais estão usando este e-mail.";

	/// <summary>
	/// Key: "Response.UnknownError"
	/// English String: "Sorry! An unknown error occurred. Please try again later."
	/// </summary>
	public override string ResponseUnknownError => "Um erro desconhecido ocorreu. Tente novamente mais tarde.";

	/// <summary>
	/// Key: "Response.UsernameAllowedCharactersError"
	/// error showing which characters are allowed for username
	/// English String: "Usernames may only contain letters, numbers, and _."
	/// </summary>
	public override string ResponseUsernameAllowedCharactersError => "Nomes de usuário só podem conter letras, números e _.";

	/// <summary>
	/// Key: "Response.UsernameAlreadyInUse"
	/// English String: "This username is already in use."
	/// </summary>
	public override string ResponseUsernameAlreadyInUse => "Este nome de usuário já está sendo usado.";

	/// <summary>
	/// Key: "Response.UsernameExplicit"
	/// English String: "This username is not allowed, please try another."
	/// </summary>
	public override string ResponseUsernameExplicit => "Este nome de usuário não é permitido. Tente outro.";

	/// <summary>
	/// Key: "Response.UsernameInvalid"
	/// English String: "Please enter a valid username."
	/// </summary>
	public override string ResponseUsernameInvalid => "Insira um nome de usuário válido.";

	/// <summary>
	/// Key: "Response.UsernameInvalidCharacters"
	/// English String: "Only a-z, A-Z, 0-9 and _ are allowed."
	/// </summary>
	public override string ResponseUsernameInvalidCharacters => "Apenas a-z, A-Z, 0-9, e _ são permitidos.";

	/// <summary>
	/// Key: "Response.UsernameInvalidLength"
	/// English String: "Usernames can be 3 to 20 characters long."
	/// </summary>
	public override string ResponseUsernameInvalidLength => "Nomes de usuários devem ter de 3 a 20 caracteres.";

	/// <summary>
	/// Key: "Response.UsernameInvalidUnderscore"
	/// English String: "Usernames cannot start or end with _."
	/// </summary>
	public override string ResponseUsernameInvalidUnderscore => "Nomes de usuário não podem começar ou terminar com _.";

	/// <summary>
	/// Key: "Response.UsernameNotAvailable"
	/// English String: "Username not available. Please try again."
	/// </summary>
	public override string ResponseUsernameNotAvailable => "Nome de usuário não disponível. Tente novamente.";

	/// <summary>
	/// Key: "Response.UsernameOrPasswordIncorrect"
	/// Your username or password is incorrect
	/// English String: "Your username or password is incorrect."
	/// </summary>
	public override string ResponseUsernameOrPasswordIncorrect => "Nome de usuário ou senha incorretos.";

	/// <summary>
	/// Key: "Response.UsernamePasswordRequired"
	/// Username and Password are required error message
	/// English String: "Username and Password are required."
	/// </summary>
	public override string ResponseUsernamePasswordRequired => "Requer nome de usuário e senha.";

	/// <summary>
	/// Key: "Response.UsernamePrivateInfo"
	/// English String: "Username might contain private information."
	/// </summary>
	public override string ResponseUsernamePrivateInfo => "O nome de usuário pode conter informações pessoais.";

	/// <summary>
	/// Key: "Response.UsernameRequired"
	/// validation error message
	/// English String: "Username is required."
	/// </summary>
	public override string ResponseUsernameRequired => "Requer nome de usuário.";

	/// <summary>
	/// Key: "Response.UsernameTakenTryAgain"
	/// English String: "This username is already taken! Please try a different one."
	/// </summary>
	public override string ResponseUsernameTakenTryAgain => "Este nome de usuário já está sendo usado! Tente outro.";

	/// <summary>
	/// Key: "Response.UsernameTooManyUnderscores"
	/// English String: "Usernames can have at most one _."
	/// </summary>
	public override string ResponseUsernameTooManyUnderscores => "Nomes de usuário podem conter no máximo um _.";

	public SignUpResources_pt_br(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionCreateAccount()
	{
		return "Criar conta";
	}

	protected override string _GetTemplateForActionLinkAccount()
	{
		return "Vincular Conta";
	}

	protected override string _GetTemplateForActionLogInCapitalized()
	{
		return "Conectar-se";
	}

	protected override string _GetTemplateForActionReturnHome()
	{
		return "Voltar ao início";
	}

	protected override string _GetTemplateForActionSignUp()
	{
		return "Cadastrar-se";
	}

	protected override string _GetTemplateForActionSignupAndSync()
	{
		return "Cadastre-se e sincronize";
	}

	protected override string _GetTemplateForActionSubmit()
	{
		return "Enviar";
	}

	protected override string _GetTemplateForDescriptionAccountLinkingWarning()
	{
		return "Para vincular a uma conta Roblox existente, conecte-se e vincule na página de configuração de conta.";
	}

	protected override string _GetTemplateForDescriptionNoRealName()
	{
		return "Não use o seu nome real.";
	}

	protected override string _GetTemplateForDescriptionPrivacyPolicy()
	{
		return "Política de Privacidade";
	}

	/// <summary>
	/// Key: "Description.SignUpAgreement"
	/// terms of use agreement checkbox label to signup.
	/// English String: "By clicking {spanStart}Sign Up{spanEnd}, you are agreeing to the {termsOfUseLink} and acknowledging the {privacyPolicyLink}"
	/// </summary>
	public override string DescriptionSignUpAgreement(string spanStart, string spanEnd, string termsOfUseLink, string privacyPolicyLink)
	{
		return $"Ao clicar em {spanStart}Cadastrar-se{spanEnd}, você está concordando com os {termsOfUseLink} e aceitando a {privacyPolicyLink}";
	}

	protected override string _GetTemplateForDescriptionSignUpAgreement()
	{
		return "Ao clicar em {spanStart}Cadastrar-se{spanEnd}, você está concordando com os {termsOfUseLink} e aceitando a {privacyPolicyLink}";
	}

	protected override string _GetTemplateForDescriptionTermsOfService()
	{
		return "Termos de Serviço";
	}

	protected override string _GetTemplateForGuestSignUpABActionSignUp()
	{
		return "Cadastrar-se";
	}

	protected override string _GetTemplateForHeadingConnectFacebook()
	{
		return "Conecte-se ao Facebook";
	}

	protected override string _GetTemplateForHeadingCreateAnAccount()
	{
		return "CRIAR UMA CONTA";
	}

	/// <summary>
	/// Key: "Heading.FacebookSignupAlmostDone"
	/// when user signs up using Facebook, this is shown in next step to create a password.
	/// English String: "{firstname}, YOU'RE ALMOST DONE"
	/// </summary>
	public override string HeadingFacebookSignupAlmostDone(string firstname)
	{
		return $"{firstname}, ESTÁ QUASE PRONTRO";
	}

	protected override string _GetTemplateForHeadingFacebookSignupAlmostDone()
	{
		return "{firstname}, ESTÁ QUASE PRONTRO";
	}

	protected override string _GetTemplateForHeadingLoginHaveFun()
	{
		return "Conecte-se e comece a se divertir!";
	}

	protected override string _GetTemplateForHeadingSignupHaveFun()
	{
		return "Cadastre-se e comece a se divertir!";
	}

	protected override string _GetTemplateForLabelAbout()
	{
		return "Sobre";
	}

	protected override string _GetTemplateForLabelAlreadyHaveRobloxAccount()
	{
		return "Já tem uma conta Roblox?";
	}

	protected override string _GetTemplateForLabelAlreadyRegistered()
	{
		return "Já está inscrito?";
	}

	protected override string _GetTemplateForLabelBirthday()
	{
		return "Data de nascimento";
	}

	protected override string _GetTemplateForLabelBirthdayWithColumn()
	{
		return "Data de nascimento:";
	}

	protected override string _GetTemplateForLabelConfirmPassword()
	{
		return "Confirmar senha";
	}

	protected override string _GetTemplateForLabelDay()
	{
		return "Dia";
	}

	protected override string _GetTemplateForLabelDesiredUsername()
	{
		return "Nome de usuário desejado:";
	}

	protected override string _GetTemplateForLabelFacebookNotLinked()
	{
		return "Sua conta do Facebook não está vinculada a nenhuma conta do Roblox. Cadastre uma conta no Roblox.";
	}

	protected override string _GetTemplateForLabelFacebookSignupUsername()
	{
		return "Criar nome de usuário Roblox:";
	}

	protected override string _GetTemplateForLabelFemale()
	{
		return "Feminino";
	}

	protected override string _GetTemplateForLabelGender()
	{
		return "Gênero";
	}

	protected override string _GetTemplateForLabelGenderRequired()
	{
		return "Requer gênero.";
	}

	protected override string _GetTemplateForLabelGenderWithColumn()
	{
		return "Gênero:";
	}

	protected override string _GetTemplateForLabelMale()
	{
		return "Masculino";
	}

	protected override string _GetTemplateForLabelMonth()
	{
		return "Mês";
	}

	protected override string _GetTemplateForLabelPassword()
	{
		return "Senha";
	}

	protected override string _GetTemplateForLabelPasswordRequirements()
	{
		return "Senha (mínimo de 8 caracteres)";
	}

	protected override string _GetTemplateForLabelPlatforms()
	{
		return "Plataformas";
	}

	protected override string _GetTemplateForLabelPlay()
	{
		return "Jogar";
	}

	protected override string _GetTemplateForLabelPleaseAgreeToTerms()
	{
		return "Concorde com nossos Termos de Serviço e Política de Privacidade.";
	}

	protected override string _GetTemplateForLabelRequired()
	{
		return "Necessário";
	}

	protected override string _GetTemplateForLabelSignupButtonText()
	{
		return "Cadastre-se e jogue!";
	}

	protected override string _GetTemplateForLabelSignUpWith()
	{
		return "ou cadastre-se com";
	}

	protected override string _GetTemplateForLabelTermsOfUse()
	{
		return "Termos de Uso";
	}

	protected override string _GetTemplateForLabelUsername()
	{
		return "Usuário";
	}

	protected override string _GetTemplateForLabelUsernameCharacterLimit()
	{
		return "3-20 caracteres alfanuméricos, sem espaços.";
	}

	protected override string _GetTemplateForLabelUsernameHint()
	{
		return "Nome de usuário (não use o seu nome real)";
	}

	protected override string _GetTemplateForLabelUsernameRequirements()
	{
		return "Nome de usuário (3-20 caracteres, _ permitido)";
	}

	protected override string _GetTemplateForLabelYear()
	{
		return "Ano";
	}

	protected override string _GetTemplateForMessagePasswordMinLength()
	{
		return "Mínimo 8 caracteres";
	}

	protected override string _GetTemplateForMessageUsernameNoRealNameUse()
	{
		return "Não use o seu nome real";
	}

	protected override string _GetTemplateForResponseBadUsername()
	{
		return "Nome de usuário inapropriado para Roblox.";
	}

	protected override string _GetTemplateForResponseBadUsernameForWeChat()
	{
		return "Nome de usuário inapropriado";
	}

	protected override string _GetTemplateForResponseBirthdayInvalid()
	{
		return "Esta data de nascimento é inválida.";
	}

	protected override string _GetTemplateForResponseBirthdayMustBeSetFirst()
	{
		return "A data de nascimento deve ser definida antes.";
	}

	protected override string _GetTemplateForResponseCaptchaMismatchError()
	{
		return "As palavras não conferem.";
	}

	protected override string _GetTemplateForResponseCaptchaNotEnteredError()
	{
		return "Preencha o Captcha";
	}

	protected override string _GetTemplateForResponseFacebookConnectionError()
	{
		return "Erro ao recuperar valores do Facebook.";
	}

	protected override string _GetTemplateForResponseFacebookLoginAge()
	{
		return "O login com o Facebook só pode ser usado por usuários com mais de 13 anos.";
	}

	protected override string _GetTemplateForResponseInvalidBirthday()
	{
		return "Data de nascimento inválida.";
	}

	protected override string _GetTemplateForResponseInvalidEmail()
	{
		return "Endereço de e-mail inválido.";
	}

	protected override string _GetTemplateForResponseJavaScriptRequired()
	{
		return "JavaScript é necessário para enviar este formulário.";
	}

	protected override string _GetTemplateForResponsePasswordComplexity()
	{
		return "Crie uma senha mais complexa.";
	}

	protected override string _GetTemplateForResponsePasswordConfirmation()
	{
		return "Insira uma confirmação de senha.";
	}

	protected override string _GetTemplateForResponsePasswordContainsUsernameError()
	{
		return "A senha não deve ser igual ao nome de usuário.";
	}

	protected override string _GetTemplateForResponsePasswordMismatch()
	{
		return "As senhas não conferem.";
	}

	protected override string _GetTemplateForResponsePasswordWrongShort()
	{
		return "A senha deve conter pelo menos 8 caracteres.";
	}

	protected override string _GetTemplateForResponsePleaseEnterPassword()
	{
		return "Insira uma senha.";
	}

	protected override string _GetTemplateForResponsePleaseEnterUsername()
	{
		return "Insira um nome de usuário.";
	}

	protected override string _GetTemplateForResponseSocialAccountCreationFailed()
	{
		return "Falha ao criar conta";
	}

	protected override string _GetTemplateForResponseSpaceOrSpecialCharaterError()
	{
		return "Espaços e caracteres especiais não são permitidos.";
	}

	protected override string _GetTemplateForResponseTooManyAccountsWithSameEmailError()
	{
		return "Contas demais estão usando este e-mail.";
	}

	protected override string _GetTemplateForResponseUnknownError()
	{
		return "Um erro desconhecido ocorreu. Tente novamente mais tarde.";
	}

	protected override string _GetTemplateForResponseUsernameAllowedCharactersError()
	{
		return "Nomes de usuário só podem conter letras, números e _.";
	}

	protected override string _GetTemplateForResponseUsernameAlreadyInUse()
	{
		return "Este nome de usuário já está sendo usado.";
	}

	protected override string _GetTemplateForResponseUsernameExplicit()
	{
		return "Este nome de usuário não é permitido. Tente outro.";
	}

	protected override string _GetTemplateForResponseUsernameInvalid()
	{
		return "Insira um nome de usuário válido.";
	}

	protected override string _GetTemplateForResponseUsernameInvalidCharacters()
	{
		return "Apenas a-z, A-Z, 0-9, e _ são permitidos.";
	}

	protected override string _GetTemplateForResponseUsernameInvalidLength()
	{
		return "Nomes de usuários devem ter de 3 a 20 caracteres.";
	}

	protected override string _GetTemplateForResponseUsernameInvalidUnderscore()
	{
		return "Nomes de usuário não podem começar ou terminar com _.";
	}

	protected override string _GetTemplateForResponseUsernameNotAvailable()
	{
		return "Nome de usuário não disponível. Tente novamente.";
	}

	protected override string _GetTemplateForResponseUsernameOrPasswordIncorrect()
	{
		return "Nome de usuário ou senha incorretos.";
	}

	protected override string _GetTemplateForResponseUsernamePasswordRequired()
	{
		return "Requer nome de usuário e senha.";
	}

	protected override string _GetTemplateForResponseUsernamePrivateInfo()
	{
		return "O nome de usuário pode conter informações pessoais.";
	}

	protected override string _GetTemplateForResponseUsernameRequired()
	{
		return "Requer nome de usuário.";
	}

	protected override string _GetTemplateForResponseUsernameTakenTryAgain()
	{
		return "Este nome de usuário já está sendo usado! Tente outro.";
	}

	protected override string _GetTemplateForResponseUsernameTooManyUnderscores()
	{
		return "Nomes de usuário podem conter no máximo um _.";
	}
}
