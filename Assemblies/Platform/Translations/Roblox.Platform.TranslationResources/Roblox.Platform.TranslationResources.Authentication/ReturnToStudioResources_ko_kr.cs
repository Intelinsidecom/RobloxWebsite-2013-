namespace Roblox.TranslationResources.Authentication;

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
	public override string ActionLogout => "계정 전환";

	/// <summary>
	/// Key: "Action.OpenStudio"
	/// Open studio
	/// English String: "Open Studio"
	/// </summary>
	public override string ActionOpenStudio => "Studio 열기";

	/// <summary>
	/// Key: "Description.OpeningStudio"
	/// English String: "Opening Roblox Studio now..."
	/// </summary>
	public override string DescriptionOpeningStudio => "Roblox Studio 여는 중...";

	/// <summary>
	/// Key: "Label.StudioHelp"
	/// English String: "If Studio does not open, click here for help"
	/// </summary>
	public override string LabelStudioHelp => "Roblox Studio가 열리지 않으면 여기를 클릭해 도움을 받아보세요";

	public ReturnToStudioResources_ko_kr(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionLogout()
	{
		return "계정 전환";
	}

	protected override string _GetTemplateForActionOpenStudio()
	{
		return "Studio 열기";
	}

	/// <summary>
	/// Key: "Description.AttemptedUsername"
	/// The username that the user is using to login to studio
	/// English String: "You were trying to log in to Studio as {username}"
	/// </summary>
	public override string DescriptionAttemptedUsername(string username)
	{
		return $"Roblox Studio에 {username}(으)로 로그인하려 합니다";
	}

	protected override string _GetTemplateForDescriptionAttemptedUsername()
	{
		return "Roblox Studio에 {username}(으)로 로그인하려 합니다";
	}

	protected override string _GetTemplateForDescriptionOpeningStudio()
	{
		return "Roblox Studio 여는 중...";
	}

	/// <summary>
	/// Key: "Description.OpenStudioSuggestion"
	/// Open studio as current authenticated user.
	/// English String: "Do you want to open Studio as {username}?"
	/// </summary>
	public override string DescriptionOpenStudioSuggestion(string username)
	{
		return $"{username}(으)로 Roblox Studio를 열까요?";
	}

	protected override string _GetTemplateForDescriptionOpenStudioSuggestion()
	{
		return "{username}(으)로 Roblox Studio를 열까요?";
	}

	/// <summary>
	/// Key: "Heading.Greeting"
	/// greeting to user
	/// English String: "Hello, {username}!"
	/// </summary>
	public override string HeadingGreeting(string username)
	{
		return $"{username}님, 안녕하세요!";
	}

	protected override string _GetTemplateForHeadingGreeting()
	{
		return "{username}님, 안녕하세요!";
	}

	protected override string _GetTemplateForLabelStudioHelp()
	{
		return "Roblox Studio가 열리지 않으면 여기를 클릭해 도움을 받아보세요";
	}
}
