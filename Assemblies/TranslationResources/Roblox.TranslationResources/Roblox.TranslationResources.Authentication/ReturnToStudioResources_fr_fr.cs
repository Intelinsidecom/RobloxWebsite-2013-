namespace Roblox.TranslationResources.Authentication;

/// <summary>
/// This class overrides ReturnToStudioResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class ReturnToStudioResources_fr_fr : ReturnToStudioResources_en_us, IReturnToStudioResources, ITranslationResources
{
	/// <summary>
	/// Key: "Action.Logout"
	/// Logout the current user
	/// English String: "Switch Accounts"
	/// </summary>
	public override string ActionLogout => "Changer de compte";

	/// <summary>
	/// Key: "Action.OpenStudio"
	/// Open studio
	/// English String: "Open Studio"
	/// </summary>
	public override string ActionOpenStudio => "Lancer Studio";

	/// <summary>
	/// Key: "Description.OpeningStudio"
	/// English String: "Opening Roblox Studio now..."
	/// </summary>
	public override string DescriptionOpeningStudio => "Lancement de Roblox Studio...";

	/// <summary>
	/// Key: "Label.StudioHelp"
	/// English String: "If Studio does not open, click here for help"
	/// </summary>
	public override string LabelStudioHelp => "Si Studio ne se lance pas, cliquez ici pour obtenir de l'aide";

	public ReturnToStudioResources_fr_fr(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionLogout()
	{
		return "Changer de compte";
	}

	protected override string _GetTemplateForActionOpenStudio()
	{
		return "Lancer Studio";
	}

	/// <summary>
	/// Key: "Description.AttemptedUsername"
	/// The username that the user is using to login to studio
	/// English String: "You were trying to log in to Studio as {username}"
	/// </summary>
	public override string DescriptionAttemptedUsername(string username)
	{
		return $"Vous essayiez de vous connecter à Studio en tant que {username}.";
	}

	protected override string _GetTemplateForDescriptionAttemptedUsername()
	{
		return "Vous essayiez de vous connecter à Studio en tant que {username}.";
	}

	protected override string _GetTemplateForDescriptionOpeningStudio()
	{
		return "Lancement de Roblox Studio...";
	}

	/// <summary>
	/// Key: "Description.OpenStudioSuggestion"
	/// Open studio as current authenticated user.
	/// English String: "Do you want to open Studio as {username}?"
	/// </summary>
	public override string DescriptionOpenStudioSuggestion(string username)
	{
		return $"Voulez-vous lancer Studio en tant que {username}\u00a0?";
	}

	protected override string _GetTemplateForDescriptionOpenStudioSuggestion()
	{
		return "Voulez-vous lancer Studio en tant que {username}\u00a0?";
	}

	/// <summary>
	/// Key: "Heading.Greeting"
	/// greeting to user
	/// English String: "Hello, {username}!"
	/// </summary>
	public override string HeadingGreeting(string username)
	{
		return $"Bonjour, {username}\u00a0!";
	}

	protected override string _GetTemplateForHeadingGreeting()
	{
		return "Bonjour, {username}\u00a0!";
	}

	protected override string _GetTemplateForLabelStudioHelp()
	{
		return "Si Studio ne se lance pas, cliquez ici pour obtenir de l'aide";
	}
}
