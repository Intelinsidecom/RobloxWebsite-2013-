namespace Roblox.TranslationResources.Authentication;

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
	public override string ActionLogout => "切換帳號";

	/// <summary>
	/// Key: "Action.OpenStudio"
	/// Open studio
	/// English String: "Open Studio"
	/// </summary>
	public override string ActionOpenStudio => "開啟 Studio";

	/// <summary>
	/// Key: "Description.OpeningStudio"
	/// English String: "Opening Roblox Studio now..."
	/// </summary>
	public override string DescriptionOpeningStudio => "正在開啟 Roblox Studio…";

	/// <summary>
	/// Key: "Label.StudioHelp"
	/// English String: "If Studio does not open, click here for help"
	/// </summary>
	public override string LabelStudioHelp => "若 Studio 無法開啟，請按下此處取得協助";

	public ReturnToStudioResources_zh_tw(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionLogout()
	{
		return "切換帳號";
	}

	protected override string _GetTemplateForActionOpenStudio()
	{
		return "開啟 Studio";
	}

	/// <summary>
	/// Key: "Description.AttemptedUsername"
	/// The username that the user is using to login to studio
	/// English String: "You were trying to log in to Studio as {username}"
	/// </summary>
	public override string DescriptionAttemptedUsername(string username)
	{
		return $"您剛剛嘗試以 {username} 身份登入 Studio";
	}

	protected override string _GetTemplateForDescriptionAttemptedUsername()
	{
		return "您剛剛嘗試以 {username} 身份登入 Studio";
	}

	protected override string _GetTemplateForDescriptionOpeningStudio()
	{
		return "正在開啟 Roblox Studio…";
	}

	/// <summary>
	/// Key: "Description.OpenStudioSuggestion"
	/// Open studio as current authenticated user.
	/// English String: "Do you want to open Studio as {username}?"
	/// </summary>
	public override string DescriptionOpenStudioSuggestion(string username)
	{
		return $"您想以 {username} 身分開啟 Studio 嗎？";
	}

	protected override string _GetTemplateForDescriptionOpenStudioSuggestion()
	{
		return "您想以 {username} 身分開啟 Studio 嗎？";
	}

	/// <summary>
	/// Key: "Heading.Greeting"
	/// greeting to user
	/// English String: "Hello, {username}!"
	/// </summary>
	public override string HeadingGreeting(string username)
	{
		return $"{username}，您好！";
	}

	protected override string _GetTemplateForHeadingGreeting()
	{
		return "{username}，您好！";
	}

	protected override string _GetTemplateForLabelStudioHelp()
	{
		return "若 Studio 無法開啟，請按下此處取得協助";
	}
}
