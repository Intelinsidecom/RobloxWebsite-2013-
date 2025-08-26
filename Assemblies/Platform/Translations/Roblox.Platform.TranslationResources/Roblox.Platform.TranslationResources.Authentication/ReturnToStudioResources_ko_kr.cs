namespace Roblox.Platform.TranslationResources.Authentication {
    /// <summary>

/// This class overrides ReturnToStudioResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class ReturnToStudioResources_ko_kr : ReturnToStudioResources_en_us, IReturnToStudioResources, ITranslationResources
{
	/// <summary>
	/// Key: "Action.Logout"
	/// Logout the current user
	/// English String: "Switch Accounts"
	/// </summary>
	public override string ActionLogout => "ê³„ì • ì „í™˜";

	/// <summary>
	/// Key: "Action.OpenStudio"
	/// Open studio
	/// English String: "Open Studio"
	/// </summary>
	public override string ActionOpenStudio => "Studio ì—´ê¸°";

	/// <summary>
	/// Key: "Description.OpeningStudio"
	/// English String: "Opening Roblox Studio now..."
	/// </summary>
	public override string DescriptionOpeningStudio => "Roblox Studio ì—¬ëŠ” ì¤‘...";

	/// <summary>
	/// Key: "Label.StudioHelp"
	/// English String: "If Studio does not open, click here for help"
	/// </summary>
	public override string LabelStudioHelp => "Roblox Studioê°€ ì—´ë¦¬ì§€ ì•Šìœ¼ë©´ ì—¬ê¸°ë¥¼ í´ë¦­í•´ ë„ì›€ì„ ë°›ì•„ë³´ì„¸ìš”";

	public ReturnToStudioResources_ko_kr(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionLogout()
	{
		return "ê³„ì • ì „í™˜";
	}

	protected override string _GetTemplateForActionOpenStudio()
	{
		return "Studio ì—´ê¸°";
	}

	/// <summary>
	/// Key: "Description.AttemptedUsername"
	/// The username that the user is using to login to studio
	/// English String: "You were trying to log in to Studio as {username}"
	/// </summary>
	public override string DescriptionAttemptedUsername(string username)
	{
		return $"Roblox Studioì— {username}(ìœ¼)ë¡œ ë¡œê·¸ì¸í•˜ë ¤ í•©ë‹ˆë‹¤";
	}

	protected override string _GetTemplateForDescriptionAttemptedUsername()
	{
		return "Roblox Studioì— {username}(ìœ¼)ë¡œ ë¡œê·¸ì¸í•˜ë ¤ í•©ë‹ˆë‹¤";
	}

	protected override string _GetTemplateForDescriptionOpeningStudio()
	{
		return "Roblox Studio ì—¬ëŠ” ì¤‘...";
	}

	/// <summary>
	/// Key: "Description.OpenStudioSuggestion"
	/// Open studio as current authenticated user.
	/// English String: "Do you want to open Studio as {username}?"
	/// </summary>
	public override string DescriptionOpenStudioSuggestion(string username)
	{
		return $"{username}(ìœ¼)ë¡œ Roblox Studioë¥¼ ì—´ê¹Œìš”?";
	}

	protected override string _GetTemplateForDescriptionOpenStudioSuggestion()
	{
		return "{username}(ìœ¼)ë¡œ Roblox Studioë¥¼ ì—´ê¹Œìš”?";
	}

	/// <summary>
	/// Key: "Heading.Greeting"
	/// greeting to user
	/// English String: "Hello, {username}!"
	/// </summary>
	public override string HeadingGreeting(string username)
	{
		return $"{username}ë‹˜, ì•ˆë…•í•˜ì„¸ìš”!";
	}

	protected override string _GetTemplateForHeadingGreeting()
	{
		return "{username}ë‹˜, ì•ˆë…•í•˜ì„¸ìš”!";
	}

	protected override string _GetTemplateForLabelStudioHelp()
	{
		return "Roblox Studioê°€ ì—´ë¦¬ì§€ ì•Šìœ¼ë©´ ì—¬ê¸°ë¥¼ í´ë¦­í•´ ë„ì›€ì„ ë°›ì•„ë³´ì„¸ìš”";
	}
}


}
