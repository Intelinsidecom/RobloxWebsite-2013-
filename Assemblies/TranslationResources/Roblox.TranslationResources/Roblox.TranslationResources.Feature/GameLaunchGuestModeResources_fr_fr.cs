namespace Roblox.TranslationResources.Feature;

/// <summary>
/// This class overrides GameLaunchGuestModeResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class GameLaunchGuestModeResources_fr_fr : GameLaunchGuestModeResources_en_us, IGameLaunchGuestModeResources, ITranslationResources
{
	/// <summary>
	/// Key: "Action.Dialog.Close"
	/// button text
	/// English String: "Close"
	/// </summary>
	public override string ActionDialogClose => "Fermer";

	/// <summary>
	/// Key: "Action.Dialog.Login"
	/// button text
	/// English String: "Log In"
	/// </summary>
	public override string ActionDialogLogin => "Connexion";

	/// <summary>
	/// Key: "Action.Dialog.Ok"
	/// button text
	/// English String: "OK"
	/// </summary>
	public override string ActionDialogOk => "Ok";

	/// <summary>
	/// Key: "Action.Dialog.SignUp"
	/// button text
	/// English String: "Sign Up"
	/// </summary>
	public override string ActionDialogSignUp => "S'inscrire";

	/// <summary>
	/// Key: "Action.Dialog.SignUpNow"
	/// button text
	/// English String: "Sign up now!"
	/// </summary>
	public override string ActionDialogSignUpNow => "Inscrivez-vous dès maintenant\u00a0!";

	/// <summary>
	/// Key: "Description.Dialog.SignUpOrLogin"
	/// modal body text
	/// English String: "To play games, chat with friends, or customize your avatar, you'll need an account. Sign up for a free account or log in to play now."
	/// </summary>
	public override string DescriptionDialogSignUpOrLogin => "Pour jouer à des jeux, discuter avec des amis ou personnaliser votre avatar, vous avez besoin d'un compte. Inscrivez-vous pour créer un compte gratuit ou connectez-vous pour jouer maintenant.";

	/// <summary>
	/// Key: "Description.Dialog.SignUpTodayOneDayRemaining"
	/// description text
	/// English String: "You are playing in guest mode. To use all features available on Roblox, you will need to create an account. You have less than a day left before we require free sign up."
	/// </summary>
	public override string DescriptionDialogSignUpTodayOneDayRemaining => "Vous jouez en mode invité. Pour utiliser toutes les fonctionnalités disponibles dans Roblox, vous devrez créer un compte. Il vous reste moins d'un jour avant que l'inscription gratuite ne soit requise.";

	/// <summary>
	/// Key: "Description.Dialog.TrialOver"
	/// description
	/// English String: "Your trial period has ended. Please sign up to play games - it's free!"
	/// </summary>
	public override string DescriptionDialogTrialOver => "Votre période d'essai est terminée. Veuillez vous inscrire pour jouer. C'est gratuit\u00a0!";

	/// <summary>
	/// Key: "Description.Dialog.YouArePlayingOneDayRemaining"
	/// description
	/// English String: "You are playing in guest mode. To use all features available on Roblox, you will need to create an account. You have 1 gameplay left before we require free sign up."
	/// </summary>
	public override string DescriptionDialogYouArePlayingOneDayRemaining => "Vous jouez en mode invité. Pour utiliser toutes les fonctionnalités disponibles dans Roblox, vous devrez créer un compte. Il vous reste 1\u00a0partie avant que l'inscription gratuite ne soit requise.";

	/// <summary>
	/// Key: "Heading.ChooseAvatar"
	/// modal heading
	/// English String: "Choose Your Avatar"
	/// </summary>
	public override string HeadingChooseAvatar => "Choisissez votre avatar";

	/// <summary>
	/// Key: "Heading.Dialog.SignUpOrLogin"
	/// modal heading
	/// English String: "Sign up for a free account or log in!"
	/// </summary>
	public override string HeadingDialogSignUpOrLogin => "Inscrivez-vous pour créer un compte gratuit ou connectez-vous\u00a0!";

	/// <summary>
	/// Key: "Heading.Dialog.SignUpToday"
	/// modal heading
	/// English String: "Sign Up Today!"
	/// </summary>
	public override string HeadingDialogSignUpToday => "Inscrivez-vous aujourd'hui\u00a0!";

	/// <summary>
	/// Key: "Label.HaveAccount"
	/// label
	/// English String: "I have an account"
	/// </summary>
	public override string LabelHaveAccount => "J'ai un compte";

	public GameLaunchGuestModeResources_fr_fr(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionDialogClose()
	{
		return "Fermer";
	}

	protected override string _GetTemplateForActionDialogLogin()
	{
		return "Connexion";
	}

	protected override string _GetTemplateForActionDialogOk()
	{
		return "Ok";
	}

	protected override string _GetTemplateForActionDialogSignUp()
	{
		return "S'inscrire";
	}

	protected override string _GetTemplateForActionDialogSignUpNow()
	{
		return "Inscrivez-vous dès maintenant\u00a0!";
	}

	protected override string _GetTemplateForDescriptionDialogSignUpOrLogin()
	{
		return "Pour jouer à des jeux, discuter avec des amis ou personnaliser votre avatar, vous avez besoin d'un compte. Inscrivez-vous pour créer un compte gratuit ou connectez-vous pour jouer maintenant.";
	}

	protected override string _GetTemplateForDescriptionDialogSignUpTodayOneDayRemaining()
	{
		return "Vous jouez en mode invité. Pour utiliser toutes les fonctionnalités disponibles dans Roblox, vous devrez créer un compte. Il vous reste moins d'un jour avant que l'inscription gratuite ne soit requise.";
	}

	/// <summary>
	/// Key: "Description.Dialog.SignUpTodaySomeDaysRemaining"
	/// description
	/// English String: "You are playing in guest mode. To use all features available on Roblox, you will need to create an account. You have less than {numDays} days left before we require free sign up."
	/// </summary>
	public override string DescriptionDialogSignUpTodaySomeDaysRemaining(string numDays)
	{
		return $"Vous jouez en mode invité. Pour utiliser toutes les fonctionnalités disponibles dans Roblox, vous devrez créer un compte. Il vous reste moins de {numDays}\u00a0jours avant que l'inscription gratuite ne soit requise.";
	}

	protected override string _GetTemplateForDescriptionDialogSignUpTodaySomeDaysRemaining()
	{
		return "Vous jouez en mode invité. Pour utiliser toutes les fonctionnalités disponibles dans Roblox, vous devrez créer un compte. Il vous reste moins de {numDays}\u00a0jours avant que l'inscription gratuite ne soit requise.";
	}

	protected override string _GetTemplateForDescriptionDialogTrialOver()
	{
		return "Votre période d'essai est terminée. Veuillez vous inscrire pour jouer. C'est gratuit\u00a0!";
	}

	protected override string _GetTemplateForDescriptionDialogYouArePlayingOneDayRemaining()
	{
		return "Vous jouez en mode invité. Pour utiliser toutes les fonctionnalités disponibles dans Roblox, vous devrez créer un compte. Il vous reste 1\u00a0partie avant que l'inscription gratuite ne soit requise.";
	}

	/// <summary>
	/// Key: "Description.Dialog.YouArePlayingSomeDaysRemaining"
	/// description
	/// English String: "You are playing in guest mode. To use all features available on Roblox, you will need to create an account. You have {numDays} gameplays left before we require free sign up."
	/// </summary>
	public override string DescriptionDialogYouArePlayingSomeDaysRemaining(string numDays)
	{
		return $"Vous jouez en mode invité. Pour utiliser toutes les fonctionnalités disponibles dans Roblox, vous devrez créer un compte. Il vous reste {numDays}\u00a0parties avant que l'inscription gratuite ne soit requise.";
	}

	protected override string _GetTemplateForDescriptionDialogYouArePlayingSomeDaysRemaining()
	{
		return "Vous jouez en mode invité. Pour utiliser toutes les fonctionnalités disponibles dans Roblox, vous devrez créer un compte. Il vous reste {numDays}\u00a0parties avant que l'inscription gratuite ne soit requise.";
	}

	protected override string _GetTemplateForHeadingChooseAvatar()
	{
		return "Choisissez votre avatar";
	}

	protected override string _GetTemplateForHeadingDialogSignUpOrLogin()
	{
		return "Inscrivez-vous pour créer un compte gratuit ou connectez-vous\u00a0!";
	}

	protected override string _GetTemplateForHeadingDialogSignUpToday()
	{
		return "Inscrivez-vous aujourd'hui\u00a0!";
	}

	protected override string _GetTemplateForLabelHaveAccount()
	{
		return "J'ai un compte";
	}
}
