namespace Roblox.Platform.TranslationResources.Authentication {
    /// <summary>

/// This class overrides ReturnToStudioResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class ReturnToStudioResources_ja_jp : ReturnToStudioResources_en_us, IReturnToStudioResources, ITranslationResources
{
	/// <summary>
	/// Key: "Action.Logout"
	/// Logout the current user
	/// English String: "Switch Accounts"
	/// </summary>
	public override string ActionLogout => "ã‚¢ã‚«ã‚¦ãƒ³ãƒˆã®åˆ‡ã‚Šæ›¿ãˆ";

	/// <summary>
	/// Key: "Action.OpenStudio"
	/// Open studio
	/// English String: "Open Studio"
	/// </summary>
	public override string ActionOpenStudio => "Studioã‚’é–‹ã";

	/// <summary>
	/// Key: "Description.OpeningStudio"
	/// English String: "Opening Roblox Studio now..."
	/// </summary>
	public override string DescriptionOpeningStudio => "Roblox Studioã‚’é–‹ã„ã¦ã„ã¾ã™...";

	/// <summary>
	/// Key: "Label.StudioHelp"
	/// English String: "If Studio does not open, click here for help"
	/// </summary>
	public override string LabelStudioHelp => "StudioãŒé–‹ã‹ãªã„å ´åˆã¯ã€ã“ã¡ã‚‰ã‚’ã‚¯ãƒªãƒƒã‚¯ã—ã¦ãƒ˜ãƒ«ãƒ—ã‚’ç¢ºèªã—ã¦ãã ã•ã„";

	public ReturnToStudioResources_ja_jp(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionLogout()
	{
		return "ã‚¢ã‚«ã‚¦ãƒ³ãƒˆã®åˆ‡ã‚Šæ›¿ãˆ";
	}

	protected override string _GetTemplateForActionOpenStudio()
	{
		return "Studioã‚’é–‹ã";
	}

	/// <summary>
	/// Key: "Description.AttemptedUsername"
	/// The username that the user is using to login to studio
	/// English String: "You were trying to log in to Studio as {username}"
	/// </summary>
	public override string DescriptionAttemptedUsername(string username)
	{
		return $"{username} ã§Studioã«ãƒ­ã‚°ã‚¤ãƒ³ã—ã¾ã™";
	}

	protected override string _GetTemplateForDescriptionAttemptedUsername()
	{
		return "{username} ã§Studioã«ãƒ­ã‚°ã‚¤ãƒ³ã—ã¾ã™";
	}

	protected override string _GetTemplateForDescriptionOpeningStudio()
	{
		return "Roblox Studioã‚’é–‹ã„ã¦ã„ã¾ã™...";
	}

	/// <summary>
	/// Key: "Description.OpenStudioSuggestion"
	/// Open studio as current authenticated user.
	/// English String: "Do you want to open Studio as {username}?"
	/// </summary>
	public override string DescriptionOpenStudioSuggestion(string username)
	{
		return $"{username} ã§Studioã‚’é–‹ãã¾ã™ã‹ï¼Ÿ";
	}

	protected override string _GetTemplateForDescriptionOpenStudioSuggestion()
	{
		return "{username} ã§Studioã‚’é–‹ãã¾ã™ã‹ï¼Ÿ";
	}

	/// <summary>
	/// Key: "Heading.Greeting"
	/// greeting to user
	/// English String: "Hello, {username}!"
	/// </summary>
	public override string HeadingGreeting(string username)
	{
		return $"ã“ã‚“ã«ã¡ã¯ã€{username}ã•ã‚“ï¼";
	}

	protected override string _GetTemplateForHeadingGreeting()
	{
		return "ã“ã‚“ã«ã¡ã¯ã€{username}ã•ã‚“ï¼";
	}

	protected override string _GetTemplateForLabelStudioHelp()
	{
		return "StudioãŒé–‹ã‹ãªã„å ´åˆã¯ã€ã“ã¡ã‚‰ã‚’ã‚¯ãƒªãƒƒã‚¯ã—ã¦ãƒ˜ãƒ«ãƒ—ã‚’ç¢ºèªã—ã¦ãã ã•ã„";
	}
}


}
