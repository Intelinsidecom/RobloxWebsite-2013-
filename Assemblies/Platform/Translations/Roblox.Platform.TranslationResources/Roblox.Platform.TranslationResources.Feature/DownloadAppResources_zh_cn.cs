namespace Roblox.TranslationResources.Feature;

/// <summary>
/// This class overrides DownloadAppResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class DownloadAppResources_zh_cn : DownloadAppResources_en_us, IDownloadAppResources, ITranslationResources
{
	/// <summary>
	/// Key: "Action.ContinueInApp"
	/// button label
	/// English String: "Continue in App"
	/// </summary>
	public override string ActionContinueInApp => "在 App 中继续";

	/// <summary>
	/// Key: "Action.ContinueInBrowser"
	/// button label
	/// English String: "Continue in browser"
	/// </summary>
	public override string ActionContinueInBrowser => "在浏览器中继续";

	/// <summary>
	/// Key: "Action.Play"
	/// Button that takes the user to the game.
	/// English String: "Play"
	/// </summary>
	public override string ActionPlay => "开始游戏";

	/// <summary>
	/// Key: "Heading.RobloxForAndroid"
	/// heading for the page
	/// English String: "Roblox for Android"
	/// </summary>
	public override string HeadingRobloxForAndroid => "Android 版 Roblox";

	/// <summary>
	/// Key: "Heading.RobloxForIos"
	/// heading for page
	/// English String: "Roblox for iOS"
	/// </summary>
	public override string HeadingRobloxForIos => "iOS 版 Roblox";

	/// <summary>
	/// Key: "Label.PlayGamesInMobile"
	/// section title
	/// English String: "Play Roblox in our mobile app!"
	/// </summary>
	public override string LabelPlayGamesInMobile => "在我们的移动端 App 中玩 Roblox！";

	/// <summary>
	/// Key: "Message.AppBumpAndroidDevice"
	/// The user is being encouraged to play on the native mobile Android app
	/// English String: "Play Roblox in our Android app!"
	/// </summary>
	public override string MessageAppBumpAndroidDevice => "在我们的 Android App 中玩 Roblox！";

	/// <summary>
	/// Key: "Message.AppBumperUpsell"
	/// The user is being encouraged to play through the mobile app.
	/// English String: "Millions of games by players like you"
	/// </summary>
	public override string MessageAppBumperUpsell => "数百万种由像你一样的玩家所创作的游戏";

	/// <summary>
	/// Key: "Message.AppBumpIOSDevice"
	/// The user is being encouraged to play on the native mobile iOS app
	/// English String: "Play Roblox in our iOS app!"
	/// </summary>
	public override string MessageAppBumpIOSDevice => "在我们的 iOS App 中玩 Roblox！";

	public DownloadAppResources_zh_cn(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionContinueInApp()
	{
		return "在 App 中继续";
	}

	protected override string _GetTemplateForActionContinueInBrowser()
	{
		return "在浏览器中继续";
	}

	protected override string _GetTemplateForActionPlay()
	{
		return "开始游戏";
	}

	protected override string _GetTemplateForHeadingRobloxForAndroid()
	{
		return "Android 版 Roblox";
	}

	protected override string _GetTemplateForHeadingRobloxForIos()
	{
		return "iOS 版 Roblox";
	}

	protected override string _GetTemplateForLabelPlayGamesInMobile()
	{
		return "在我们的移动端 App 中玩 Roblox！";
	}

	/// <summary>
	/// Key: "Label.ReviewsCount"
	/// label
	/// English String: "{reviewCount} reviews"
	/// </summary>
	public override string LabelReviewsCount(string reviewCount)
	{
		return $"{reviewCount} 条评论";
	}

	protected override string _GetTemplateForLabelReviewsCount()
	{
		return "{reviewCount} 条评论";
	}

	protected override string _GetTemplateForMessageAppBumpAndroidDevice()
	{
		return "在我们的 Android App 中玩 Roblox！";
	}

	protected override string _GetTemplateForMessageAppBumperUpsell()
	{
		return "数百万种由像你一样的玩家所创作的游戏";
	}

	protected override string _GetTemplateForMessageAppBumpIOSDevice()
	{
		return "在我们的 iOS App 中玩 Roblox！";
	}
}
