namespace Roblox.TranslationResources.Feature;

/// <summary>
/// This class overrides GameLaunchGuestModeResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class GameLaunchGuestModeResources_pt_br : GameLaunchGuestModeResources_en_us, IGameLaunchGuestModeResources, ITranslationResources
{
	/// <summary>
	/// Key: "Action.Dialog.Close"
	/// button text
	/// English String: "Close"
	/// </summary>
	public override string ActionDialogClose => "Fechar";

	/// <summary>
	/// Key: "Action.Dialog.Login"
	/// button text
	/// English String: "Log In"
	/// </summary>
	public override string ActionDialogLogin => "Conectar-se";

	/// <summary>
	/// Key: "Action.Dialog.Ok"
	/// button text
	/// English String: "OK"
	/// </summary>
	public override string ActionDialogOk => "OK";

	/// <summary>
	/// Key: "Action.Dialog.SignUp"
	/// button text
	/// English String: "Sign Up"
	/// </summary>
	public override string ActionDialogSignUp => "Cadastrar-se";

	/// <summary>
	/// Key: "Action.Dialog.SignUpNow"
	/// button text
	/// English String: "Sign up now!"
	/// </summary>
	public override string ActionDialogSignUpNow => "Cadastre-se agora!";

	/// <summary>
	/// Key: "Description.Dialog.SignUpOrLogin"
	/// modal body text
	/// English String: "To play games, chat with friends, or customize your avatar, you'll need an account. Sign up for a free account or log in to play now."
	/// </summary>
	public override string DescriptionDialogSignUpOrLogin => "Você precisa de uma conta para jogar, falar no chat com amigos ou customizar seu Avatar. Cadastre uma conta grátis ou conecte-se para jogar.";

	/// <summary>
	/// Key: "Description.Dialog.SignUpTodayOneDayRemaining"
	/// description text
	/// English String: "You are playing in guest mode. To use all features available on Roblox, you will need to create an account. You have less than a day left before we require free sign up."
	/// </summary>
	public override string DescriptionDialogSignUpTodayOneDayRemaining => "Você está jogando no modo visitante. Para usar todas as funcionalidades disponíveis no Roblox você terá que criar uma conta. Você tem menos de 1 dia até que o cadastro grátis seja necessário.";

	/// <summary>
	/// Key: "Description.Dialog.TrialOver"
	/// description
	/// English String: "Your trial period has ended. Please sign up to play games - it's free!"
	/// </summary>
	public override string DescriptionDialogTrialOver => "Seu período de teste terminou. Cadastre-se para jogar - é de graça!";

	/// <summary>
	/// Key: "Description.Dialog.YouArePlayingOneDayRemaining"
	/// description
	/// English String: "You are playing in guest mode. To use all features available on Roblox, you will need to create an account. You have 1 gameplay left before we require free sign up."
	/// </summary>
	public override string DescriptionDialogYouArePlayingOneDayRemaining => "Você está jogando no modo visitante. Para usar todas as funcionalidades disponíveis no Roblox você terá que criar uma conta. Você tem 1 jogada até que o cadastro grátis seja necessário.";

	/// <summary>
	/// Key: "Heading.ChooseAvatar"
	/// modal heading
	/// English String: "Choose Your Avatar"
	/// </summary>
	public override string HeadingChooseAvatar => "Escolha o seu avatar";

	/// <summary>
	/// Key: "Heading.Dialog.SignUpOrLogin"
	/// modal heading
	/// English String: "Sign up for a free account or log in!"
	/// </summary>
	public override string HeadingDialogSignUpOrLogin => "Cadastre uma conta grátis ou conecte-se!";

	/// <summary>
	/// Key: "Heading.Dialog.SignUpToday"
	/// modal heading
	/// English String: "Sign Up Today!"
	/// </summary>
	public override string HeadingDialogSignUpToday => "Cadastre-se agora!";

	/// <summary>
	/// Key: "Label.HaveAccount"
	/// label
	/// English String: "I have an account"
	/// </summary>
	public override string LabelHaveAccount => "Já tenho uma conta";

	public GameLaunchGuestModeResources_pt_br(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionDialogClose()
	{
		return "Fechar";
	}

	protected override string _GetTemplateForActionDialogLogin()
	{
		return "Conectar-se";
	}

	protected override string _GetTemplateForActionDialogOk()
	{
		return "OK";
	}

	protected override string _GetTemplateForActionDialogSignUp()
	{
		return "Cadastrar-se";
	}

	protected override string _GetTemplateForActionDialogSignUpNow()
	{
		return "Cadastre-se agora!";
	}

	protected override string _GetTemplateForDescriptionDialogSignUpOrLogin()
	{
		return "Você precisa de uma conta para jogar, falar no chat com amigos ou customizar seu Avatar. Cadastre uma conta grátis ou conecte-se para jogar.";
	}

	protected override string _GetTemplateForDescriptionDialogSignUpTodayOneDayRemaining()
	{
		return "Você está jogando no modo visitante. Para usar todas as funcionalidades disponíveis no Roblox você terá que criar uma conta. Você tem menos de 1 dia até que o cadastro grátis seja necessário.";
	}

	/// <summary>
	/// Key: "Description.Dialog.SignUpTodaySomeDaysRemaining"
	/// description
	/// English String: "You are playing in guest mode. To use all features available on Roblox, you will need to create an account. You have less than {numDays} days left before we require free sign up."
	/// </summary>
	public override string DescriptionDialogSignUpTodaySomeDaysRemaining(string numDays)
	{
		return $"Você está jogando no modo visitante. Para usar todas as funcionalidades disponíveis no Roblox você terá que criar uma conta. Você tem menos de {numDays} dias até que o cadastro grátis seja necessário.";
	}

	protected override string _GetTemplateForDescriptionDialogSignUpTodaySomeDaysRemaining()
	{
		return "Você está jogando no modo visitante. Para usar todas as funcionalidades disponíveis no Roblox você terá que criar uma conta. Você tem menos de {numDays} dias até que o cadastro grátis seja necessário.";
	}

	protected override string _GetTemplateForDescriptionDialogTrialOver()
	{
		return "Seu período de teste terminou. Cadastre-se para jogar - é de graça!";
	}

	protected override string _GetTemplateForDescriptionDialogYouArePlayingOneDayRemaining()
	{
		return "Você está jogando no modo visitante. Para usar todas as funcionalidades disponíveis no Roblox você terá que criar uma conta. Você tem 1 jogada até que o cadastro grátis seja necessário.";
	}

	/// <summary>
	/// Key: "Description.Dialog.YouArePlayingSomeDaysRemaining"
	/// description
	/// English String: "You are playing in guest mode. To use all features available on Roblox, you will need to create an account. You have {numDays} gameplays left before we require free sign up."
	/// </summary>
	public override string DescriptionDialogYouArePlayingSomeDaysRemaining(string numDays)
	{
		return $"Você está jogando no modo visitante. Para usar todas as funcionalidades disponíveis no Roblox você terá que criar uma conta. Você tem {numDays} jogadas até que o cadastro grátis seja necessário.";
	}

	protected override string _GetTemplateForDescriptionDialogYouArePlayingSomeDaysRemaining()
	{
		return "Você está jogando no modo visitante. Para usar todas as funcionalidades disponíveis no Roblox você terá que criar uma conta. Você tem {numDays} jogadas até que o cadastro grátis seja necessário.";
	}

	protected override string _GetTemplateForHeadingChooseAvatar()
	{
		return "Escolha o seu avatar";
	}

	protected override string _GetTemplateForHeadingDialogSignUpOrLogin()
	{
		return "Cadastre uma conta grátis ou conecte-se!";
	}

	protected override string _GetTemplateForHeadingDialogSignUpToday()
	{
		return "Cadastre-se agora!";
	}

	protected override string _GetTemplateForLabelHaveAccount()
	{
		return "Já tenho uma conta";
	}
}
