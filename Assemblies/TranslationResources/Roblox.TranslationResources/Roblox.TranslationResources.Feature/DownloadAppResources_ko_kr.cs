namespace Roblox.TranslationResources.Feature;

/// <summary>
/// This class overrides DownloadAppResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class DownloadAppResources_ko_kr : DownloadAppResources_en_us, IDownloadAppResources, ITranslationResources
{
	/// <summary>
	/// Key: "Action.ContinueInApp"
	/// button label
	/// English String: "Continue in App"
	/// </summary>
	public override string ActionContinueInApp => "앱에서 계속";

	/// <summary>
	/// Key: "Action.ContinueInBrowser"
	/// button label
	/// English String: "Continue in browser"
	/// </summary>
	public override string ActionContinueInBrowser => "브라우저에서 계속";

	/// <summary>
	/// Key: "Action.Play"
	/// Button that takes the user to the game.
	/// English String: "Play"
	/// </summary>
	public override string ActionPlay => "플레이";

	/// <summary>
	/// Key: "Heading.RobloxForAndroid"
	/// heading for the page
	/// English String: "Roblox for Android"
	/// </summary>
	public override string HeadingRobloxForAndroid => "Roblox (Android용)";

	/// <summary>
	/// Key: "Heading.RobloxForIos"
	/// heading for page
	/// English String: "Roblox for iOS"
	/// </summary>
	public override string HeadingRobloxForIos => "Roblox (iOS용)";

	/// <summary>
	/// Key: "Label.PlayGamesInMobile"
	/// section title
	/// English String: "Play Roblox in our mobile app!"
	/// </summary>
	public override string LabelPlayGamesInMobile => "모바일 앱으로 Roblox를 플레이하세요!";

	/// <summary>
	/// Key: "Message.AppBumpAndroidDevice"
	/// The user is being encouraged to play on the native mobile Android app
	/// English String: "Play Roblox in our Android app!"
	/// </summary>
	public override string MessageAppBumpAndroidDevice => "Android 앱으로 Roblox를 플레이하세요!";

	/// <summary>
	/// Key: "Message.AppBumperUpsell"
	/// The user is being encouraged to play through the mobile app.
	/// English String: "Millions of games by players like you"
	/// </summary>
	public override string MessageAppBumperUpsell => "회원님과 같은 플레이어들이 만든 수많은 게임";

	/// <summary>
	/// Key: "Message.AppBumpIOSDevice"
	/// The user is being encouraged to play on the native mobile iOS app
	/// English String: "Play Roblox in our iOS app!"
	/// </summary>
	public override string MessageAppBumpIOSDevice => "iOS 앱으로 Roblox를 플레이하세요!";

	public DownloadAppResources_ko_kr(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionContinueInApp()
	{
		return "앱에서 계속";
	}

	protected override string _GetTemplateForActionContinueInBrowser()
	{
		return "브라우저에서 계속";
	}

	protected override string _GetTemplateForActionPlay()
	{
		return "플레이";
	}

	protected override string _GetTemplateForHeadingRobloxForAndroid()
	{
		return "Roblox (Android용)";
	}

	protected override string _GetTemplateForHeadingRobloxForIos()
	{
		return "Roblox (iOS용)";
	}

	protected override string _GetTemplateForLabelPlayGamesInMobile()
	{
		return "모바일 앱으로 Roblox를 플레이하세요!";
	}

	/// <summary>
	/// Key: "Label.ReviewsCount"
	/// label
	/// English String: "{reviewCount} reviews"
	/// </summary>
	public override string LabelReviewsCount(string reviewCount)
	{
		return $"리뷰 {reviewCount}개";
	}

	protected override string _GetTemplateForLabelReviewsCount()
	{
		return "리뷰 {reviewCount}개";
	}

	protected override string _GetTemplateForMessageAppBumpAndroidDevice()
	{
		return "Android 앱으로 Roblox를 플레이하세요!";
	}

	protected override string _GetTemplateForMessageAppBumperUpsell()
	{
		return "회원님과 같은 플레이어들이 만든 수많은 게임";
	}

	protected override string _GetTemplateForMessageAppBumpIOSDevice()
	{
		return "iOS 앱으로 Roblox를 플레이하세요!";
	}
}
