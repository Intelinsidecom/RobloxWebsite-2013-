namespace Roblox.Platform.TranslationResources.Feature {
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
	public override string ActionContinueInApp => "åœ¨ App ç¹¼çºŒ";

	/// <summary>
	/// Key: "Action.ContinueInBrowser"
	/// button label
	/// English String: "Continue in browser"
	/// </summary>
	public override string ActionContinueInBrowser => "åœ¨ç€è¦½å™¨ç¹¼çºŒ";

	/// <summary>
	/// Key: "Action.Play"
	/// Button that takes the user to the game.
	/// English String: "Play"
	/// </summary>
	public override string ActionPlay => "çŽ©";

	/// <summary>
	/// Key: "Heading.RobloxForAndroid"
	/// heading for the page
	/// English String: "Roblox for Android"
	/// </summary>
	public override string HeadingRobloxForAndroid => "Android ç‰ˆæœ¬ Roblox";

	/// <summary>
	/// Key: "Heading.RobloxForIos"
	/// heading for page
	/// English String: "Roblox for iOS"
	/// </summary>
	public override string HeadingRobloxForIos => "iOS ç‰ˆæœ¬ Roblox";

	/// <summary>
	/// Key: "Label.PlayGamesInMobile"
	/// section title
	/// English String: "Play Roblox in our mobile app!"
	/// </summary>
	public override string LabelPlayGamesInMobile => "åœ¨æˆ‘å€‘çš„è¡Œå‹•è£ç½® App çŽ© Robloxï¼";

	/// <summary>
	/// Key: "Message.AppBumpAndroidDevice"
	/// The user is being encouraged to play on the native mobile Android app
	/// English String: "Play Roblox in our Android app!"
	/// </summary>
	public override string MessageAppBumpAndroidDevice => "åœ¨æˆ‘å€‘çš„ Android App çŽ© Robloxï¼";

	/// <summary>
	/// Key: "Message.AppBumperUpsell"
	/// The user is being encouraged to play through the mobile app.
	/// English String: "Millions of games by players like you"
	/// </summary>
	public override string MessageAppBumperUpsell => "æ•¸ç™¾è¬æ¬¾çŽ©å®¶å‰µä½œçš„éŠæˆ²ç­‰æ‚¨ä¾†çŽ©";

	/// <summary>
	/// Key: "Message.AppBumpIOSDevice"
	/// The user is being encouraged to play on the native mobile iOS app
	/// English String: "Play Roblox in our iOS app!"
	/// </summary>
	public override string MessageAppBumpIOSDevice => "åœ¨æˆ‘å€‘çš„ iOS App çŽ© Robloxï¼";

	public DownloadAppResources_zh_tw(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionContinueInApp()
	{
		return "åœ¨ App ç¹¼çºŒ";
	}

	protected override string _GetTemplateForActionContinueInBrowser()
	{
		return "åœ¨ç€è¦½å™¨ç¹¼çºŒ";
	}

	protected override string _GetTemplateForActionPlay()
	{
		return "çŽ©";
	}

	protected override string _GetTemplateForHeadingRobloxForAndroid()
	{
		return "Android ç‰ˆæœ¬ Roblox";
	}

	protected override string _GetTemplateForHeadingRobloxForIos()
	{
		return "iOS ç‰ˆæœ¬ Roblox";
	}

	protected override string _GetTemplateForLabelPlayGamesInMobile()
	{
		return "åœ¨æˆ‘å€‘çš„è¡Œå‹•è£ç½® App çŽ© Robloxï¼";
	}

	/// <summary>
	/// Key: "Label.ReviewsCount"
	/// label
	/// English String: "{reviewCount} reviews"
	/// </summary>
	public override string LabelReviewsCount(string reviewCount)
	{
		return $"{reviewCount} å‰‡è©•è«–";
	}

	protected override string _GetTemplateForLabelReviewsCount()
	{
		return "{reviewCount} å‰‡è©•è«–";
	}

	protected override string _GetTemplateForMessageAppBumpAndroidDevice()
	{
		return "åœ¨æˆ‘å€‘çš„ Android App çŽ© Robloxï¼";
	}

	protected override string _GetTemplateForMessageAppBumperUpsell()
	{
		return "æ•¸ç™¾è¬æ¬¾çŽ©å®¶å‰µä½œçš„éŠæˆ²ç­‰æ‚¨ä¾†çŽ©";
	}

	protected override string _GetTemplateForMessageAppBumpIOSDevice()
	{
		return "åœ¨æˆ‘å€‘çš„ iOS App çŽ© Robloxï¼";
	}
}


}
