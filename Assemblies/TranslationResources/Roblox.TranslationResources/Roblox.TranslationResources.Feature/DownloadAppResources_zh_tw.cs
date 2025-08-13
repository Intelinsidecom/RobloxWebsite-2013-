namespace Roblox.TranslationResources.Feature;

/// <summary>
/// This class overrides DownloadAppResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class DownloadAppResources_zh_tw : DownloadAppResources_en_us, IDownloadAppResources, ITranslationResources
{
	/// <summary>
	/// Key: "Action.ContinueInApp"
	/// button label
	/// English String: "Continue in App"
	/// </summary>
	public override string ActionContinueInApp => "在 App 繼續";

	/// <summary>
	/// Key: "Action.ContinueInBrowser"
	/// button label
	/// English String: "Continue in browser"
	/// </summary>
	public override string ActionContinueInBrowser => "在瀏覽器繼續";

	/// <summary>
	/// Key: "Action.Play"
	/// Button that takes the user to the game.
	/// English String: "Play"
	/// </summary>
	public override string ActionPlay => "玩";

	/// <summary>
	/// Key: "Heading.RobloxForAndroid"
	/// heading for the page
	/// English String: "Roblox for Android"
	/// </summary>
	public override string HeadingRobloxForAndroid => "Android 版本 Roblox";

	/// <summary>
	/// Key: "Heading.RobloxForIos"
	/// heading for page
	/// English String: "Roblox for iOS"
	/// </summary>
	public override string HeadingRobloxForIos => "iOS 版本 Roblox";

	/// <summary>
	/// Key: "Label.PlayGamesInMobile"
	/// section title
	/// English String: "Play Roblox in our mobile app!"
	/// </summary>
	public override string LabelPlayGamesInMobile => "在我們的行動裝置 App 玩 Roblox！";

	/// <summary>
	/// Key: "Message.AppBumpAndroidDevice"
	/// The user is being encouraged to play on the native mobile Android app
	/// English String: "Play Roblox in our Android app!"
	/// </summary>
	public override string MessageAppBumpAndroidDevice => "在我們的 Android App 玩 Roblox！";

	/// <summary>
	/// Key: "Message.AppBumperUpsell"
	/// The user is being encouraged to play through the mobile app.
	/// English String: "Millions of games by players like you"
	/// </summary>
	public override string MessageAppBumperUpsell => "數百萬款玩家創作的遊戲等您來玩";

	/// <summary>
	/// Key: "Message.AppBumpIOSDevice"
	/// The user is being encouraged to play on the native mobile iOS app
	/// English String: "Play Roblox in our iOS app!"
	/// </summary>
	public override string MessageAppBumpIOSDevice => "在我們的 iOS App 玩 Roblox！";

	public DownloadAppResources_zh_tw(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionContinueInApp()
	{
		return "在 App 繼續";
	}

	protected override string _GetTemplateForActionContinueInBrowser()
	{
		return "在瀏覽器繼續";
	}

	protected override string _GetTemplateForActionPlay()
	{
		return "玩";
	}

	protected override string _GetTemplateForHeadingRobloxForAndroid()
	{
		return "Android 版本 Roblox";
	}

	protected override string _GetTemplateForHeadingRobloxForIos()
	{
		return "iOS 版本 Roblox";
	}

	protected override string _GetTemplateForLabelPlayGamesInMobile()
	{
		return "在我們的行動裝置 App 玩 Roblox！";
	}

	/// <summary>
	/// Key: "Label.ReviewsCount"
	/// label
	/// English String: "{reviewCount} reviews"
	/// </summary>
	public override string LabelReviewsCount(string reviewCount)
	{
		return $"{reviewCount} 則評論";
	}

	protected override string _GetTemplateForLabelReviewsCount()
	{
		return "{reviewCount} 則評論";
	}

	protected override string _GetTemplateForMessageAppBumpAndroidDevice()
	{
		return "在我們的 Android App 玩 Roblox！";
	}

	protected override string _GetTemplateForMessageAppBumperUpsell()
	{
		return "數百萬款玩家創作的遊戲等您來玩";
	}

	protected override string _GetTemplateForMessageAppBumpIOSDevice()
	{
		return "在我們的 iOS App 玩 Roblox！";
	}
}
