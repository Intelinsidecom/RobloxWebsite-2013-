namespace Roblox.Platform.TranslationResources.Authentication {
    /// <summary>

/// This class overrides ReturnToStudioResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class ReturnToStudioResources_zh_cn : ReturnToStudioResources_en_us, IReturnToStudioResources, ITranslationResources
{
	/// <summary>
	/// Key: "Action.Logout"
	/// Logout the current user
	/// English String: "Switch Accounts"
	/// </summary>
	public override string ActionLogout => "åˆ‡æ¢è´¦æˆ·";

	/// <summary>
	/// Key: "Action.OpenStudio"
	/// Open studio
	/// English String: "Open Studio"
	/// </summary>
	public override string ActionOpenStudio => "æ‰“å¼€ Studio";

	/// <summary>
	/// Key: "Description.OpeningStudio"
	/// English String: "Opening Roblox Studio now..."
	/// </summary>
	public override string DescriptionOpeningStudio => "æ­£åœ¨æ‰“å¼€ Roblox Studio...";

	/// <summary>
	/// Key: "Label.StudioHelp"
	/// English String: "If Studio does not open, click here for help"
	/// </summary>
	public override string LabelStudioHelp => "å¦‚æžœ Studio æ²¡æœ‰æ‰“å¼€ï¼Œè¯·ç‚¹æŒ‰æ­¤å¤„èŽ·å–å¸®åŠ©";

	public ReturnToStudioResources_zh_cn(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionLogout()
	{
		return "åˆ‡æ¢è´¦æˆ·";
	}

	protected override string _GetTemplateForActionOpenStudio()
	{
		return "æ‰“å¼€ Studio";
	}

	/// <summary>
	/// Key: "Description.AttemptedUsername"
	/// The username that the user is using to login to studio
	/// English String: "You were trying to log in to Studio as {username}"
	/// </summary>
	public override string DescriptionAttemptedUsername(string username)
	{
		return $"ä½ åˆšå°è¯•ä»¥ {username} èº«ä»½ç™»å½• Studio";
	}

	protected override string _GetTemplateForDescriptionAttemptedUsername()
	{
		return "ä½ åˆšå°è¯•ä»¥ {username} èº«ä»½ç™»å½• Studio";
	}

	protected override string _GetTemplateForDescriptionOpeningStudio()
	{
		return "æ­£åœ¨æ‰“å¼€ Roblox Studio...";
	}

	/// <summary>
	/// Key: "Description.OpenStudioSuggestion"
	/// Open studio as current authenticated user.
	/// English String: "Do you want to open Studio as {username}?"
	/// </summary>
	public override string DescriptionOpenStudioSuggestion(string username)
	{
		return $"æ˜¯å¦è¦ä½¿ç”¨ {username} å¸æˆ·æ‰“å¼€ Studioï¼Ÿ";
	}

	protected override string _GetTemplateForDescriptionOpenStudioSuggestion()
	{
		return "æ˜¯å¦è¦ä½¿ç”¨ {username} å¸æˆ·æ‰“å¼€ Studioï¼Ÿ";
	}

	/// <summary>
	/// Key: "Heading.Greeting"
	/// greeting to user
	/// English String: "Hello, {username}!"
	/// </summary>
	public override string HeadingGreeting(string username)
	{
		return $"ä½ å¥½ï¼Œ{username}ï¼";
	}

	protected override string _GetTemplateForHeadingGreeting()
	{
		return "ä½ å¥½ï¼Œ{username}ï¼";
	}

	protected override string _GetTemplateForLabelStudioHelp()
	{
		return "å¦‚æžœ Studio æ²¡æœ‰æ‰“å¼€ï¼Œè¯·ç‚¹æŒ‰æ­¤å¤„èŽ·å–å¸®åŠ©";
	}
}


}
