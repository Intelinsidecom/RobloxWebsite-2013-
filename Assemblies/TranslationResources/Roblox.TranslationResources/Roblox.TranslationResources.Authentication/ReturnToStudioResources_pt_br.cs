namespace Roblox.TranslationResources.Authentication;

/// <summary>
/// This class overrides ReturnToStudioResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class ReturnToStudioResources_pt_br : ReturnToStudioResources_en_us, IReturnToStudioResources, ITranslationResources
{
	/// <summary>
	/// Key: "Action.Logout"
	/// Logout the current user
	/// English String: "Switch Accounts"
	/// </summary>
	public override string ActionLogout => "Trocar conta";

	/// <summary>
	/// Key: "Action.OpenStudio"
	/// Open studio
	/// English String: "Open Studio"
	/// </summary>
	public override string ActionOpenStudio => "Abrir Studio";

	/// <summary>
	/// Key: "Description.OpeningStudio"
	/// English String: "Opening Roblox Studio now..."
	/// </summary>
	public override string DescriptionOpeningStudio => "Abrindo Roblox Studio agora...";

	/// <summary>
	/// Key: "Label.StudioHelp"
	/// English String: "If Studio does not open, click here for help"
	/// </summary>
	public override string LabelStudioHelp => "Se o Studio não abrir, clique aqui para obter ajuda";

	public ReturnToStudioResources_pt_br(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionLogout()
	{
		return "Trocar conta";
	}

	protected override string _GetTemplateForActionOpenStudio()
	{
		return "Abrir Studio";
	}

	/// <summary>
	/// Key: "Description.AttemptedUsername"
	/// The username that the user is using to login to studio
	/// English String: "You were trying to log in to Studio as {username}"
	/// </summary>
	public override string DescriptionAttemptedUsername(string username)
	{
		return $"Você estava tentando entrar no Studio como {username}";
	}

	protected override string _GetTemplateForDescriptionAttemptedUsername()
	{
		return "Você estava tentando entrar no Studio como {username}";
	}

	protected override string _GetTemplateForDescriptionOpeningStudio()
	{
		return "Abrindo Roblox Studio agora...";
	}

	/// <summary>
	/// Key: "Description.OpenStudioSuggestion"
	/// Open studio as current authenticated user.
	/// English String: "Do you want to open Studio as {username}?"
	/// </summary>
	public override string DescriptionOpenStudioSuggestion(string username)
	{
		return $"Deseja abrir o Studio como {username}?";
	}

	protected override string _GetTemplateForDescriptionOpenStudioSuggestion()
	{
		return "Deseja abrir o Studio como {username}?";
	}

	/// <summary>
	/// Key: "Heading.Greeting"
	/// greeting to user
	/// English String: "Hello, {username}!"
	/// </summary>
	public override string HeadingGreeting(string username)
	{
		return $"Olá, {username}!";
	}

	protected override string _GetTemplateForHeadingGreeting()
	{
		return "Olá, {username}!";
	}

	protected override string _GetTemplateForLabelStudioHelp()
	{
		return "Se o Studio não abrir, clique aqui para obter ajuda";
	}
}
