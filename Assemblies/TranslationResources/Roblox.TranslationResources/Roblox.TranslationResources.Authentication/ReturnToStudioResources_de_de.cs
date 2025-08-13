namespace Roblox.TranslationResources.Authentication;

/// <summary>
/// This class overrides ReturnToStudioResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class ReturnToStudioResources_de_de : ReturnToStudioResources_en_us, IReturnToStudioResources, ITranslationResources
{
	/// <summary>
	/// Key: "Action.Logout"
	/// Logout the current user
	/// English String: "Switch Accounts"
	/// </summary>
	public override string ActionLogout => "Konten wechseln";

	/// <summary>
	/// Key: "Action.OpenStudio"
	/// Open studio
	/// English String: "Open Studio"
	/// </summary>
	public override string ActionOpenStudio => "Studio öffnen";

	/// <summary>
	/// Key: "Description.OpeningStudio"
	/// English String: "Opening Roblox Studio now..."
	/// </summary>
	public override string DescriptionOpeningStudio => "Roblox Studio wird geöffnet\u00a0...";

	/// <summary>
	/// Key: "Label.StudioHelp"
	/// English String: "If Studio does not open, click here for help"
	/// </summary>
	public override string LabelStudioHelp => "Sollte Studio sich nicht öffnen, klicke hier, um Hilfe zu erhalten.";

	public ReturnToStudioResources_de_de(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionLogout()
	{
		return "Konten wechseln";
	}

	protected override string _GetTemplateForActionOpenStudio()
	{
		return "Studio öffnen";
	}

	/// <summary>
	/// Key: "Description.AttemptedUsername"
	/// The username that the user is using to login to studio
	/// English String: "You were trying to log in to Studio as {username}"
	/// </summary>
	public override string DescriptionAttemptedUsername(string username)
	{
		return $"Du hast versucht, dich als {username} bei Studio anzumelden.";
	}

	protected override string _GetTemplateForDescriptionAttemptedUsername()
	{
		return "Du hast versucht, dich als {username} bei Studio anzumelden.";
	}

	protected override string _GetTemplateForDescriptionOpeningStudio()
	{
		return "Roblox Studio wird geöffnet\u00a0...";
	}

	/// <summary>
	/// Key: "Description.OpenStudioSuggestion"
	/// Open studio as current authenticated user.
	/// English String: "Do you want to open Studio as {username}?"
	/// </summary>
	public override string DescriptionOpenStudioSuggestion(string username)
	{
		return $"Möchtest Du Studio als {username} öffnen?";
	}

	protected override string _GetTemplateForDescriptionOpenStudioSuggestion()
	{
		return "Möchtest Du Studio als {username} öffnen?";
	}

	/// <summary>
	/// Key: "Heading.Greeting"
	/// greeting to user
	/// English String: "Hello, {username}!"
	/// </summary>
	public override string HeadingGreeting(string username)
	{
		return $"Hallo {username}!";
	}

	protected override string _GetTemplateForHeadingGreeting()
	{
		return "Hallo {username}!";
	}

	protected override string _GetTemplateForLabelStudioHelp()
	{
		return "Sollte Studio sich nicht öffnen, klicke hier, um Hilfe zu erhalten.";
	}
}
