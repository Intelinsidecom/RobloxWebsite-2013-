namespace Roblox.TranslationResources.Authentication;

/// <summary>
/// This class overrides ReturnToStudioResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class ReturnToStudioResources_zh_cjv : ReturnToStudioResources_en_us, IReturnToStudioResources, ITranslationResources
{
	/// <summary>
	/// Key: "Action.Logout"
	/// Logout the current user
	/// English String: "Switch Accounts"
	/// </summary>
	public override string ActionLogout => "切换账户";

	/// <summary>
	/// Key: "Action.OpenStudio"
	/// Open studio
	/// English String: "Open Studio"
	/// </summary>
	public override string ActionOpenStudio => "打开 Studio";

	/// <summary>
	/// Key: "Description.OpeningStudio"
	/// English String: "Opening Roblox Studio now..."
	/// </summary>
	public override string DescriptionOpeningStudio => "正在打开 Roblox Studio...";

	/// <summary>
	/// Key: "Label.StudioHelp"
	/// English String: "If Studio does not open, click here for help"
	/// </summary>
	public override string LabelStudioHelp => "如果 Studio 没有打开，请点按此处获取帮助";

	public ReturnToStudioResources_zh_cjv(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionLogout()
	{
		return "切换账户";
	}

	protected override string _GetTemplateForActionOpenStudio()
	{
		return "打开 Studio";
	}

	/// <summary>
	/// Key: "Description.AttemptedUsername"
	/// The username that the user is using to login to studio
	/// English String: "You were trying to log in to Studio as {username}"
	/// </summary>
	public override string DescriptionAttemptedUsername(string username)
	{
		return $"你刚尝试以 {username} 身份登录 Studio";
	}

	protected override string _GetTemplateForDescriptionAttemptedUsername()
	{
		return "你刚尝试以 {username} 身份登录 Studio";
	}

	protected override string _GetTemplateForDescriptionOpeningStudio()
	{
		return "正在打开 Roblox Studio...";
	}

	/// <summary>
	/// Key: "Description.OpenStudioSuggestion"
	/// Open studio as current authenticated user.
	/// English String: "Do you want to open Studio as {username}?"
	/// </summary>
	public override string DescriptionOpenStudioSuggestion(string username)
	{
		return $"是否要使用 {username} 帐户打开 Studio？";
	}

	protected override string _GetTemplateForDescriptionOpenStudioSuggestion()
	{
		return "是否要使用 {username} 帐户打开 Studio？";
	}

	/// <summary>
	/// Key: "Heading.Greeting"
	/// greeting to user
	/// English String: "Hello, {username}!"
	/// </summary>
	public override string HeadingGreeting(string username)
	{
		return $"你好，{username}！";
	}

	protected override string _GetTemplateForHeadingGreeting()
	{
		return "你好，{username}！";
	}

	protected override string _GetTemplateForLabelStudioHelp()
	{
		return "如果 Studio 没有打开，请点按此处获取帮助";
	}
}
