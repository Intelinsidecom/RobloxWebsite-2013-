namespace Roblox.TranslationResources.Feature;

/// <summary>
/// This class overrides GameLaunchGuestModeResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class GameLaunchGuestModeResources_de_de : GameLaunchGuestModeResources_en_us, IGameLaunchGuestModeResources, ITranslationResources
{
	/// <summary>
	/// Key: "Action.Dialog.Close"
	/// button text
	/// English String: "Close"
	/// </summary>
	public override string ActionDialogClose => "Schließen";

	/// <summary>
	/// Key: "Action.Dialog.Login"
	/// button text
	/// English String: "Log In"
	/// </summary>
	public override string ActionDialogLogin => "Anmelden";

	/// <summary>
	/// Key: "Action.Dialog.Ok"
	/// button text
	/// English String: "OK"
	/// </summary>
	public override string ActionDialogOk => "Okay";

	/// <summary>
	/// Key: "Action.Dialog.SignUp"
	/// button text
	/// English String: "Sign Up"
	/// </summary>
	public override string ActionDialogSignUp => "Registrieren";

	/// <summary>
	/// Key: "Action.Dialog.SignUpNow"
	/// button text
	/// English String: "Sign up now!"
	/// </summary>
	public override string ActionDialogSignUpNow => "Registriere dich jetzt!";

	/// <summary>
	/// Key: "Description.Dialog.SignUpOrLogin"
	/// modal body text
	/// English String: "To play games, chat with friends, or customize your avatar, you'll need an account. Sign up for a free account or log in to play now."
	/// </summary>
	public override string DescriptionDialogSignUpOrLogin => "Du brauchst ein Konto, um Spiele zu spielen, mit Freunden zu chatten oder deinen Avatar anzupassen. Registriere dich für ein kostenloses Konto oder melde dich an, um sofort zu spielen.";

	/// <summary>
	/// Key: "Description.Dialog.SignUpTodayOneDayRemaining"
	/// description text
	/// English String: "You are playing in guest mode. To use all features available on Roblox, you will need to create an account. You have less than a day left before we require free sign up."
	/// </summary>
	public override string DescriptionDialogSignUpTodayOneDayRemaining => "Du spielst als Gast. Um alle Features von Roblox nutzen zu können, musst du ein Konto erstellen. Du hast weniger als einen Tag Zeit, bevor die kostenlose Registrierung durchgeführt werden muss.";

	/// <summary>
	/// Key: "Description.Dialog.TrialOver"
	/// description
	/// English String: "Your trial period has ended. Please sign up to play games - it's free!"
	/// </summary>
	public override string DescriptionDialogTrialOver => "Deine Demozeit ist vorbei. Bitte registriere dich, um spielen zu können. Es ist kostenlos!";

	/// <summary>
	/// Key: "Description.Dialog.YouArePlayingOneDayRemaining"
	/// description
	/// English String: "You are playing in guest mode. To use all features available on Roblox, you will need to create an account. You have 1 gameplay left before we require free sign up."
	/// </summary>
	public override string DescriptionDialogYouArePlayingOneDayRemaining => "Du spielst als Gast. Um alle Features von Roblox nutzen zu können, musst du ein Konto erstellen. Du kannst noch 1-mal spielen, bevor die kostenlose Registrierung durchgeführt werden muss.";

	/// <summary>
	/// Key: "Heading.ChooseAvatar"
	/// modal heading
	/// English String: "Choose Your Avatar"
	/// </summary>
	public override string HeadingChooseAvatar => "Wähle deinen Avatar";

	/// <summary>
	/// Key: "Heading.Dialog.SignUpOrLogin"
	/// modal heading
	/// English String: "Sign up for a free account or log in!"
	/// </summary>
	public override string HeadingDialogSignUpOrLogin => "Registriere dich für ein kostenloses Konto oder melde dich an!";

	/// <summary>
	/// Key: "Heading.Dialog.SignUpToday"
	/// modal heading
	/// English String: "Sign Up Today!"
	/// </summary>
	public override string HeadingDialogSignUpToday => "Registriere dich noch heute!";

	/// <summary>
	/// Key: "Label.HaveAccount"
	/// label
	/// English String: "I have an account"
	/// </summary>
	public override string LabelHaveAccount => "Ich habe ein Konto";

	public GameLaunchGuestModeResources_de_de(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionDialogClose()
	{
		return "Schließen";
	}

	protected override string _GetTemplateForActionDialogLogin()
	{
		return "Anmelden";
	}

	protected override string _GetTemplateForActionDialogOk()
	{
		return "Okay";
	}

	protected override string _GetTemplateForActionDialogSignUp()
	{
		return "Registrieren";
	}

	protected override string _GetTemplateForActionDialogSignUpNow()
	{
		return "Registriere dich jetzt!";
	}

	protected override string _GetTemplateForDescriptionDialogSignUpOrLogin()
	{
		return "Du brauchst ein Konto, um Spiele zu spielen, mit Freunden zu chatten oder deinen Avatar anzupassen. Registriere dich für ein kostenloses Konto oder melde dich an, um sofort zu spielen.";
	}

	protected override string _GetTemplateForDescriptionDialogSignUpTodayOneDayRemaining()
	{
		return "Du spielst als Gast. Um alle Features von Roblox nutzen zu können, musst du ein Konto erstellen. Du hast weniger als einen Tag Zeit, bevor die kostenlose Registrierung durchgeführt werden muss.";
	}

	/// <summary>
	/// Key: "Description.Dialog.SignUpTodaySomeDaysRemaining"
	/// description
	/// English String: "You are playing in guest mode. To use all features available on Roblox, you will need to create an account. You have less than {numDays} days left before we require free sign up."
	/// </summary>
	public override string DescriptionDialogSignUpTodaySomeDaysRemaining(string numDays)
	{
		return $"Du spielst als Gast. Um alle Features von Roblox nutzen zu können, musst du ein Konto erstellen. Du hast weniger als {numDays} Tage Zeit, bevor die kostenlose Registrierung durchgeführt werden muss.";
	}

	protected override string _GetTemplateForDescriptionDialogSignUpTodaySomeDaysRemaining()
	{
		return "Du spielst als Gast. Um alle Features von Roblox nutzen zu können, musst du ein Konto erstellen. Du hast weniger als {numDays} Tage Zeit, bevor die kostenlose Registrierung durchgeführt werden muss.";
	}

	protected override string _GetTemplateForDescriptionDialogTrialOver()
	{
		return "Deine Demozeit ist vorbei. Bitte registriere dich, um spielen zu können. Es ist kostenlos!";
	}

	protected override string _GetTemplateForDescriptionDialogYouArePlayingOneDayRemaining()
	{
		return "Du spielst als Gast. Um alle Features von Roblox nutzen zu können, musst du ein Konto erstellen. Du kannst noch 1-mal spielen, bevor die kostenlose Registrierung durchgeführt werden muss.";
	}

	/// <summary>
	/// Key: "Description.Dialog.YouArePlayingSomeDaysRemaining"
	/// description
	/// English String: "You are playing in guest mode. To use all features available on Roblox, you will need to create an account. You have {numDays} gameplays left before we require free sign up."
	/// </summary>
	public override string DescriptionDialogYouArePlayingSomeDaysRemaining(string numDays)
	{
		return $"Du spielst als Gast. Um alle Features von Roblox nutzen zu können, musst du ein Konto erstellen. Du kannst noch {numDays}-mal spielen, bevor die kostenlose Registrierung durchgeführt werden muss.";
	}

	protected override string _GetTemplateForDescriptionDialogYouArePlayingSomeDaysRemaining()
	{
		return "Du spielst als Gast. Um alle Features von Roblox nutzen zu können, musst du ein Konto erstellen. Du kannst noch {numDays}-mal spielen, bevor die kostenlose Registrierung durchgeführt werden muss.";
	}

	protected override string _GetTemplateForHeadingChooseAvatar()
	{
		return "Wähle deinen Avatar";
	}

	protected override string _GetTemplateForHeadingDialogSignUpOrLogin()
	{
		return "Registriere dich für ein kostenloses Konto oder melde dich an!";
	}

	protected override string _GetTemplateForHeadingDialogSignUpToday()
	{
		return "Registriere dich noch heute!";
	}

	protected override string _GetTemplateForLabelHaveAccount()
	{
		return "Ich habe ein Konto";
	}
}
