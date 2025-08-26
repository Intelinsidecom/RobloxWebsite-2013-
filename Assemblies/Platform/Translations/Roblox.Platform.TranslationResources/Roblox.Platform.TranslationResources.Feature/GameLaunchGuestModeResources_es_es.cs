namespace Roblox.Platform.TranslationResources.Feature {
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
	public override string ActionDialogLogin => "Iniciar sesiÃ³n";

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
	public override string ActionDialogSignUp => "RegÃ­strate";

	/// <summary>
	/// Key: "Action.Dialog.SignUpNow"
	/// button text
	/// English String: "Sign up now!"
	/// </summary>
	public override string ActionDialogSignUpNow => "Â¡RegÃ­strate ya!";

	/// <summary>
	/// Key: "Description.Dialog.SignUpOrLogin"
	/// modal body text
	/// English String: "To play games, chat with friends, or customize your avatar, you'll need an account. Sign up for a free account or log in to play now."
	/// </summary>
	public override string DescriptionDialogSignUpOrLogin => "Necesitas una cuenta para jugar, chatear con amigos o personalizar tu avatar. RegÃ­strate para obtener una gratuita o inicia sesiÃ³n para jugar ahora.";

	/// <summary>
	/// Key: "Description.Dialog.SignUpTodayOneDayRemaining"
	/// description text
	/// English String: "You are playing in guest mode. To use all features available on Roblox, you will need to create an account. You have less than a day left before we require free sign up."
	/// </summary>
	public override string DescriptionDialogSignUpTodayOneDayRemaining => "EstÃ¡s jugando en el modo invitado. Para usar todas las funciones disponibles en Roblox, tendrÃ¡s que crear una cuenta. Queda menos de 1 dÃ­a para que el registro gratuito sea necesario.";

	/// <summary>
	/// Key: "Description.Dialog.TrialOver"
	/// description
	/// English String: "Your trial period has ended. Please sign up to play games - it's free!"
	/// </summary>
	public override string DescriptionDialogTrialOver => "Tu periodo de prueba ha finalizado. RegÃ­strate para probar juegos. Â¡Es gratis!";

	/// <summary>
	/// Key: "Description.Dialog.YouArePlayingOneDayRemaining"
	/// description
	/// English String: "You are playing in guest mode. To use all features available on Roblox, you will need to create an account. You have 1 gameplay left before we require free sign up."
	/// </summary>
	public override string DescriptionDialogYouArePlayingOneDayRemaining => "EstÃ¡s jugando en el modo invitado. Para usar todas las funciones disponibles en Roblox, tendrÃ¡s que crear una cuenta. Queda 1 dÃ­a de juego para que el registro gratuito sea necesario.";

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
	public override string HeadingDialogSignUpOrLogin => "Â¡RegÃ­strate para obtener una cuenta gratuita o inicia sesiÃ³n!";

	/// <summary>
	/// Key: "Heading.Dialog.SignUpToday"
	/// modal heading
	/// English String: "Sign Up Today!"
	/// </summary>
	public override string HeadingDialogSignUpToday => "Â¡RegÃ­strate ya!";

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
		return "Iniciar sesiÃ³n";
	}

	protected override string _GetTemplateForActionDialogOk()
	{
		return "Aceptar";
	}

	protected override string _GetTemplateForActionDialogSignUp()
	{
		return "RegÃ­strate";
	}

	protected override string _GetTemplateForActionDialogSignUpNow()
	{
		return "Â¡RegÃ­strate ya!";
	}

	protected override string _GetTemplateForDescriptionDialogSignUpOrLogin()
	{
		return "Necesitas una cuenta para jugar, chatear con amigos o personalizar tu avatar. RegÃ­strate para obtener una gratuita o inicia sesiÃ³n para jugar ahora.";
	}

	protected override string _GetTemplateForDescriptionDialogSignUpTodayOneDayRemaining()
	{
		return "EstÃ¡s jugando en el modo invitado. Para usar todas las funciones disponibles en Roblox, tendrÃ¡s que crear una cuenta. Queda menos de 1 dÃ­a para que el registro gratuito sea necesario.";
	}

	/// <summary>
	/// Key: "Description.Dialog.SignUpTodaySomeDaysRemaining"
	/// description
	/// English String: "You are playing in guest mode. To use all features available on Roblox, you will need to create an account. You have less than {numDays} days left before we require free sign up."
	/// </summary>
	public override string DescriptionDialogSignUpTodaySomeDaysRemaining(string numDays)
	{
		return $"EstÃ¡s jugando en el modo invitado. Para usar todas las funciones disponibles en Roblox, tendrÃ¡s que crear una cuenta. Te queda(n) menos de {numDays} dÃ­a(s) para que el registro gratuito sea necesario.";
	}

	protected override string _GetTemplateForDescriptionDialogSignUpTodaySomeDaysRemaining()
	{
		return "EstÃ¡s jugando en el modo invitado. Para usar todas las funciones disponibles en Roblox, tendrÃ¡s que crear una cuenta. Te queda(n) menos de {numDays} dÃ­a(s) para que el registro gratuito sea necesario.";
	}

	protected override string _GetTemplateForDescriptionDialogTrialOver()
	{
		return "Tu periodo de prueba ha finalizado. RegÃ­strate para probar juegos. Â¡Es gratis!";
	}

	protected override string _GetTemplateForDescriptionDialogYouArePlayingOneDayRemaining()
	{
		return "EstÃ¡s jugando en el modo invitado. Para usar todas las funciones disponibles en Roblox, tendrÃ¡s que crear una cuenta. Queda 1 dÃ­a de juego para que el registro gratuito sea necesario.";
	}

	/// <summary>
	/// Key: "Description.Dialog.YouArePlayingSomeDaysRemaining"
	/// description
	/// English String: "You are playing in guest mode. To use all features available on Roblox, you will need to create an account. You have {numDays} gameplays left before we require free sign up."
	/// </summary>
	public override string DescriptionDialogYouArePlayingSomeDaysRemaining(string numDays)
	{
		return $"EstÃ¡s jugando en el modo invitado. Para usar todas las funciones disponibles en Roblox, tendrÃ¡s que crear una cuenta. Queda(n) {numDays} dÃ­a(s) de juego para que el registro gratuito sea necesario.";
	}

	protected override string _GetTemplateForDescriptionDialogYouArePlayingSomeDaysRemaining()
	{
		return "EstÃ¡s jugando en el modo invitado. Para usar todas las funciones disponibles en Roblox, tendrÃ¡s que crear una cuenta. Queda(n) {numDays} dÃ­a(s) de juego para que el registro gratuito sea necesario.";
	}

	protected override string _GetTemplateForHeadingChooseAvatar()
	{
		return "Elige tu avatar";
	}

	protected override string _GetTemplateForHeadingDialogSignUpOrLogin()
	{
		return "Â¡RegÃ­strate para obtener una cuenta gratuita o inicia sesiÃ³n!";
	}

	protected override string _GetTemplateForHeadingDialogSignUpToday()
	{
		return "Â¡RegÃ­strate ya!";
	}

	protected override string _GetTemplateForLabelHaveAccount()
	{
		return "Tengo una cuenta";
	}
}


}
