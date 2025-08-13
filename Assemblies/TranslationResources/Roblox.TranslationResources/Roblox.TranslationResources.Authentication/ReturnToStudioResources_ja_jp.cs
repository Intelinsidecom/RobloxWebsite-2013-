namespace Roblox.TranslationResources.Authentication;

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
	public override string ActionLogout => "アカウントの切り替え";

	/// <summary>
	/// Key: "Action.OpenStudio"
	/// Open studio
	/// English String: "Open Studio"
	/// </summary>
	public override string ActionOpenStudio => "Studioを開く";

	/// <summary>
	/// Key: "Description.OpeningStudio"
	/// English String: "Opening Roblox Studio now..."
	/// </summary>
	public override string DescriptionOpeningStudio => "Roblox Studioを開いています...";

	/// <summary>
	/// Key: "Label.StudioHelp"
	/// English String: "If Studio does not open, click here for help"
	/// </summary>
	public override string LabelStudioHelp => "Studioが開かない場合は、こちらをクリックしてヘルプを確認してください";

	public ReturnToStudioResources_ja_jp(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionLogout()
	{
		return "アカウントの切り替え";
	}

	protected override string _GetTemplateForActionOpenStudio()
	{
		return "Studioを開く";
	}

	/// <summary>
	/// Key: "Description.AttemptedUsername"
	/// The username that the user is using to login to studio
	/// English String: "You were trying to log in to Studio as {username}"
	/// </summary>
	public override string DescriptionAttemptedUsername(string username)
	{
		return $"{username} でStudioにログインします";
	}

	protected override string _GetTemplateForDescriptionAttemptedUsername()
	{
		return "{username} でStudioにログインします";
	}

	protected override string _GetTemplateForDescriptionOpeningStudio()
	{
		return "Roblox Studioを開いています...";
	}

	/// <summary>
	/// Key: "Description.OpenStudioSuggestion"
	/// Open studio as current authenticated user.
	/// English String: "Do you want to open Studio as {username}?"
	/// </summary>
	public override string DescriptionOpenStudioSuggestion(string username)
	{
		return $"{username} でStudioを開きますか？";
	}

	protected override string _GetTemplateForDescriptionOpenStudioSuggestion()
	{
		return "{username} でStudioを開きますか？";
	}

	/// <summary>
	/// Key: "Heading.Greeting"
	/// greeting to user
	/// English String: "Hello, {username}!"
	/// </summary>
	public override string HeadingGreeting(string username)
	{
		return $"こんにちは、{username}さん！";
	}

	protected override string _GetTemplateForHeadingGreeting()
	{
		return "こんにちは、{username}さん！";
	}

	protected override string _GetTemplateForLabelStudioHelp()
	{
		return "Studioが開かない場合は、こちらをクリックしてヘルプを確認してください";
	}
}
