namespace Roblox.TranslationResources.Feature;

/// <summary>
/// This class overrides GameLaunchGuestModeResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class GameLaunchGuestModeResources_es_es : GameLaunchGuestModeResources_en_us, IGameLaunchGuestModeResources, ITranslationResources
{
	/// <summary>
	/// Key: "Action.Dialog.Close"
	/// button text
	/// English String: "Close"
	/// </summary>
	public override string ActionDialogClose => "Cerrar";

	/// <summary>
	/// Key: "Action.Dialog.Login"
	/// button text
	/// English String: "Log In"
	/// </summary>
	public override string ActionDialogLogin => "Iniciar sesión";

	/// <summary>
	/// Key: "Action.Dialog.Ok"
	/// button text
	/// English String: "OK"
	/// </summary>
	public override string ActionDialogOk => "Aceptar";

	/// <summary>
	/// Key: "Action.Dialog.SignUp"
	/// button text
	/// English String: "Sign Up"
	/// </summary>
	public override string ActionDialogSignUp => "Regístrate";

	/// <summary>
	/// Key: "Action.Dialog.SignUpNow"
	/// button text
	/// English String: "Sign up now!"
	/// </summary>
	public override string ActionDialogSignUpNow => "¡Regístrate ya!";

	/// <summary>
	/// Key: "Description.Dialog.SignUpOrLogin"
	/// modal body text
	/// English String: "To play games, chat with friends, or customize your avatar, you'll need an account. Sign up for a free account or log in to play now."
	/// </summary>
	public override string DescriptionDialogSignUpOrLogin => "Necesitas una cuenta para jugar, chatear con amigos o personalizar tu avatar. Regístrate para obtener una gratuita o inicia sesión para jugar ahora.";

	/// <summary>
	/// Key: "Description.Dialog.SignUpTodayOneDayRemaining"
	/// description text
	/// English String: "You are playing in guest mode. To use all features available on Roblox, you will need to create an account. You have less than a day left before we require free sign up."
	/// </summary>
	public override string DescriptionDialogSignUpTodayOneDayRemaining => "Estás jugando en el modo invitado. Para usar todas las funciones disponibles en Roblox, tendrás que crear una cuenta. Queda menos de 1 día para que el registro gratuito sea necesario.";

	/// <summary>
	/// Key: "Description.Dialog.TrialOver"
	/// description
	/// English String: "Your trial period has ended. Please sign up to play games - it's free!"
	/// </summary>
	public override string DescriptionDialogTrialOver => "Tu periodo de prueba ha finalizado. Regístrate para probar juegos. ¡Es gratis!";

	/// <summary>
	/// Key: "Description.Dialog.YouArePlayingOneDayRemaining"
	/// description
	/// English String: "You are playing in guest mode. To use all features available on Roblox, you will need to create an account. You have 1 gameplay left before we require free sign up."
	/// </summary>
	public override string DescriptionDialogYouArePlayingOneDayRemaining => "Estás jugando en el modo invitado. Para usar todas las funciones disponibles en Roblox, tendrás que crear una cuenta. Queda 1 día de juego para que el registro gratuito sea necesario.";

	/// <summary>
	/// Key: "Heading.ChooseAvatar"
	/// modal heading
	/// English String: "Choose Your Avatar"
	/// </summary>
	public override string HeadingChooseAvatar => "Elige tu avatar";

	/// <summary>
	/// Key: "Heading.Dialog.SignUpOrLogin"
	/// modal heading
	/// English String: "Sign up for a free account or log in!"
	/// </summary>
	public override string HeadingDialogSignUpOrLogin => "¡Regístrate para obtener una cuenta gratuita o inicia sesión!";

	/// <summary>
	/// Key: "Heading.Dialog.SignUpToday"
	/// modal heading
	/// English String: "Sign Up Today!"
	/// </summary>
	public override string HeadingDialogSignUpToday => "¡Regístrate ya!";

	/// <summary>
	/// Key: "Label.HaveAccount"
	/// label
	/// English String: "I have an account"
	/// </summary>
	public override string LabelHaveAccount => "Tengo una cuenta";

	public GameLaunchGuestModeResources_es_es(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionDialogClose()
	{
		return "Cerrar";
	}

	protected override string _GetTemplateForActionDialogLogin()
	{
		return "Iniciar sesión";
	}

	protected override string _GetTemplateForActionDialogOk()
	{
		return "Aceptar";
	}

	protected override string _GetTemplateForActionDialogSignUp()
	{
		return "Regístrate";
	}

	protected override string _GetTemplateForActionDialogSignUpNow()
	{
		return "¡Regístrate ya!";
	}

	protected override string _GetTemplateForDescriptionDialogSignUpOrLogin()
	{
		return "Necesitas una cuenta para jugar, chatear con amigos o personalizar tu avatar. Regístrate para obtener una gratuita o inicia sesión para jugar ahora.";
	}

	protected override string _GetTemplateForDescriptionDialogSignUpTodayOneDayRemaining()
	{
		return "Estás jugando en el modo invitado. Para usar todas las funciones disponibles en Roblox, tendrás que crear una cuenta. Queda menos de 1 día para que el registro gratuito sea necesario.";
	}

	/// <summary>
	/// Key: "Description.Dialog.SignUpTodaySomeDaysRemaining"
	/// description
	/// English String: "You are playing in guest mode. To use all features available on Roblox, you will need to create an account. You have less than {numDays} days left before we require free sign up."
	/// </summary>
	public override string DescriptionDialogSignUpTodaySomeDaysRemaining(string numDays)
	{
		return $"Estás jugando en el modo invitado. Para usar todas las funciones disponibles en Roblox, tendrás que crear una cuenta. Te queda(n) menos de {numDays} día(s) para que el registro gratuito sea necesario.";
	}

	protected override string _GetTemplateForDescriptionDialogSignUpTodaySomeDaysRemaining()
	{
		return "Estás jugando en el modo invitado. Para usar todas las funciones disponibles en Roblox, tendrás que crear una cuenta. Te queda(n) menos de {numDays} día(s) para que el registro gratuito sea necesario.";
	}

	protected override string _GetTemplateForDescriptionDialogTrialOver()
	{
		return "Tu periodo de prueba ha finalizado. Regístrate para probar juegos. ¡Es gratis!";
	}

	protected override string _GetTemplateForDescriptionDialogYouArePlayingOneDayRemaining()
	{
		return "Estás jugando en el modo invitado. Para usar todas las funciones disponibles en Roblox, tendrás que crear una cuenta. Queda 1 día de juego para que el registro gratuito sea necesario.";
	}

	/// <summary>
	/// Key: "Description.Dialog.YouArePlayingSomeDaysRemaining"
	/// description
	/// English String: "You are playing in guest mode. To use all features available on Roblox, you will need to create an account. You have {numDays} gameplays left before we require free sign up."
	/// </summary>
	public override string DescriptionDialogYouArePlayingSomeDaysRemaining(string numDays)
	{
		return $"Estás jugando en el modo invitado. Para usar todas las funciones disponibles en Roblox, tendrás que crear una cuenta. Queda(n) {numDays} día(s) de juego para que el registro gratuito sea necesario.";
	}

	protected override string _GetTemplateForDescriptionDialogYouArePlayingSomeDaysRemaining()
	{
		return "Estás jugando en el modo invitado. Para usar todas las funciones disponibles en Roblox, tendrás que crear una cuenta. Queda(n) {numDays} día(s) de juego para que el registro gratuito sea necesario.";
	}

	protected override string _GetTemplateForHeadingChooseAvatar()
	{
		return "Elige tu avatar";
	}

	protected override string _GetTemplateForHeadingDialogSignUpOrLogin()
	{
		return "¡Regístrate para obtener una cuenta gratuita o inicia sesión!";
	}

	protected override string _GetTemplateForHeadingDialogSignUpToday()
	{
		return "¡Regístrate ya!";
	}

	protected override string _GetTemplateForLabelHaveAccount()
	{
		return "Tengo una cuenta";
	}
}
