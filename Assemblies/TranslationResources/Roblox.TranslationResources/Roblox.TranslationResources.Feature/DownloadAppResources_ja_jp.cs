namespace Roblox.TranslationResources.Feature;

/// <summary>
/// This class overrides DownloadAppResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class DownloadAppResources_ja_jp : DownloadAppResources_en_us, IDownloadAppResources, ITranslationResources
{
	/// <summary>
	/// Key: "Action.ContinueInApp"
	/// button label
	/// English String: "Continue in App"
	/// </summary>
	public override string ActionContinueInApp => "アプリで続ける";

	/// <summary>
	/// Key: "Action.ContinueInBrowser"
	/// button label
	/// English String: "Continue in browser"
	/// </summary>
	public override string ActionContinueInBrowser => "ブラウザで続ける";

	/// <summary>
	/// Key: "Action.Play"
	/// Button that takes the user to the game.
	/// English String: "Play"
	/// </summary>
	public override string ActionPlay => "プレイ";

	/// <summary>
	/// Key: "Heading.RobloxForAndroid"
	/// heading for the page
	/// English String: "Roblox for Android"
	/// </summary>
	public override string HeadingRobloxForAndroid => "Roblox（Android版）";

	/// <summary>
	/// Key: "Heading.RobloxForIos"
	/// heading for page
	/// English String: "Roblox for iOS"
	/// </summary>
	public override string HeadingRobloxForIos => "Roblox（iOS版）";

	/// <summary>
	/// Key: "Label.PlayGamesInMobile"
	/// section title
	/// English String: "Play Roblox in our mobile app!"
	/// </summary>
	public override string LabelPlayGamesInMobile => "モバイルアプリでRobloxをプレイする！";

	/// <summary>
	/// Key: "Message.AppBumpAndroidDevice"
	/// The user is being encouraged to play on the native mobile Android app
	/// English String: "Play Roblox in our Android app!"
	/// </summary>
	public override string MessageAppBumpAndroidDevice => "AndroidのアプリでRobloxをプレイする！";

	/// <summary>
	/// Key: "Message.AppBumperUpsell"
	/// The user is being encouraged to play through the mobile app.
	/// English String: "Millions of games by players like you"
	/// </summary>
	public override string MessageAppBumperUpsell => "あなたのようなプレイヤーが制作した数百万ものゲーム";

	/// <summary>
	/// Key: "Message.AppBumpIOSDevice"
	/// The user is being encouraged to play on the native mobile iOS app
	/// English String: "Play Roblox in our iOS app!"
	/// </summary>
	public override string MessageAppBumpIOSDevice => "iOSのアプリで Robloxをプレイする！";

	public DownloadAppResources_ja_jp(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionContinueInApp()
	{
		return "アプリで続ける";
	}

	protected override string _GetTemplateForActionContinueInBrowser()
	{
		return "ブラウザで続ける";
	}

	protected override string _GetTemplateForActionPlay()
	{
		return "プレイ";
	}

	protected override string _GetTemplateForHeadingRobloxForAndroid()
	{
		return "Roblox（Android版）";
	}

	protected override string _GetTemplateForHeadingRobloxForIos()
	{
		return "Roblox（iOS版）";
	}

	protected override string _GetTemplateForLabelPlayGamesInMobile()
	{
		return "モバイルアプリでRobloxをプレイする！";
	}

	/// <summary>
	/// Key: "Label.ReviewsCount"
	/// label
	/// English String: "{reviewCount} reviews"
	/// </summary>
	public override string LabelReviewsCount(string reviewCount)
	{
		return $"{reviewCount} 件のレビュー";
	}

	protected override string _GetTemplateForLabelReviewsCount()
	{
		return "{reviewCount} 件のレビュー";
	}

	protected override string _GetTemplateForMessageAppBumpAndroidDevice()
	{
		return "AndroidのアプリでRobloxをプレイする！";
	}

	protected override string _GetTemplateForMessageAppBumperUpsell()
	{
		return "あなたのようなプレイヤーが制作した数百万ものゲーム";
	}

	protected override string _GetTemplateForMessageAppBumpIOSDevice()
	{
		return "iOSのアプリで Robloxをプレイする！";
	}
}
