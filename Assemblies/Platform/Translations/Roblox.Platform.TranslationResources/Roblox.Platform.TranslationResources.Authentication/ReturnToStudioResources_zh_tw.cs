namespace Roblox.Platform.TranslationResources.Authentication {
    /// <summary>

/// This class overrides ReturnToStudioResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class ReturnToStudioResources_zh_tw : ReturnToStudioResources_en_us, IReturnToStudioResources, ITranslationResources
{
	/// <summary>
	/// Key: "Action.Logout"
	/// Logout the current user
	/// English String: "Switch Accounts"
	/// </summary>
	public override string ActionLogout => "åˆ‡æ›å¸³è™Ÿ";

	/// <summary>
	/// Key: "Action.OpenStudio"
	/// Open studio
	/// English String: "Open Studio"
	/// </summary>
	public override string ActionOpenStudio => "é–‹å•Ÿ Studio";

	/// <summary>
	/// Key: "Description.OpeningStudio"
	/// English String: "Opening Roblox Studio now..."
	/// </summary>
	public override string DescriptionOpeningStudio => "æ­£åœ¨é–‹å•Ÿ Roblox Studioâ€¦";

	/// <summary>
	/// Key: "Label.StudioHelp"
	/// English String: "If Studio does not open, click here for help"
	/// </summary>
	public override string LabelStudioHelp => "è‹¥ Studio ç„¡æ³•é–‹å•Ÿï¼Œè«‹æŒ‰ä¸‹æ­¤è™•å–å¾—å”åŠ©";

	public ReturnToStudioResources_zh_tw(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionLogout()
	{
		return "åˆ‡æ›å¸³è™Ÿ";
	}

	protected override string _GetTemplateForActionOpenStudio()
	{
		return "é–‹å•Ÿ Studio";
	}

	/// <summary>
	/// Key: "Description.AttemptedUsername"
	/// The username that the user is using to login to studio
	/// English String: "You were trying to log in to Studio as {username}"
	/// </summary>
	public override string DescriptionAttemptedUsername(string username)
	{
		return $"æ‚¨å‰›å‰›å˜—è©¦ä»¥ {username} èº«ä»½ç™»å…¥ Studio";
	}

	protected override string _GetTemplateForDescriptionAttemptedUsername()
	{
		return "æ‚¨å‰›å‰›å˜—è©¦ä»¥ {username} èº«ä»½ç™»å…¥ Studio";
	}

	protected override string _GetTemplateForDescriptionOpeningStudio()
	{
		return "æ­£åœ¨é–‹å•Ÿ Roblox Studioâ€¦";
	}

	/// <summary>
	/// Key: "Description.OpenStudioSuggestion"
	/// Open studio as current authenticated user.
	/// English String: "Do you want to open Studio as {username}?"
	/// </summary>
	public override string DescriptionOpenStudioSuggestion(string username)
	{
		return $"æ‚¨æƒ³ä»¥ {username} èº«åˆ†é–‹å•Ÿ Studio å—Žï¼Ÿ";
	}

	protected override string _GetTemplateForDescriptionOpenStudioSuggestion()
	{
		return "æ‚¨æƒ³ä»¥ {username} èº«åˆ†é–‹å•Ÿ Studio å—Žï¼Ÿ";
	}

	/// <summary>
	/// Key: "Heading.Greeting"
	/// greeting to user
	/// English String: "Hello, {username}!"
	/// </summary>
	public override string HeadingGreeting(string username)
	{
		return $"{username}ï¼Œæ‚¨å¥½ï¼";
	}

	protected override string _GetTemplateForHeadingGreeting()
	{
		return "{username}ï¼Œæ‚¨å¥½ï¼";
	}

	protected override string _GetTemplateForLabelStudioHelp()
	{
		return "è‹¥ Studio ç„¡æ³•é–‹å•Ÿï¼Œè«‹æŒ‰ä¸‹æ­¤è™•å–å¾—å”åŠ©";
	}
}


}
