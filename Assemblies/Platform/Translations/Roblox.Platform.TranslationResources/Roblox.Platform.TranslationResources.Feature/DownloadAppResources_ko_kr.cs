namespace Roblox.Platform.TranslationResources.Feature {
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
	public override string ActionContinueInApp => "ì•±ì—ì„œ ê³„ì†";

	/// <summary>
	/// Key: "Action.ContinueInBrowser"
	/// button label
	/// English String: "Continue in browser"
	/// </summary>
	public override string ActionContinueInBrowser => "ë¸Œë¼ìš°ì €ì—ì„œ ê³„ì†";

	/// <summary>
	/// Key: "Action.Play"
	/// Button that takes the user to the game.
	/// English String: "Play"
	/// </summary>
	public override string ActionPlay => "í”Œë ˆì´";

	/// <summary>
	/// Key: "Heading.RobloxForAndroid"
	/// heading for the page
	/// English String: "Roblox for Android"
	/// </summary>
	public override string HeadingRobloxForAndroid => "Roblox (Androidìš©)";

	/// <summary>
	/// Key: "Heading.RobloxForIos"
	/// heading for page
	/// English String: "Roblox for iOS"
	/// </summary>
	public override string HeadingRobloxForIos => "Roblox (iOSìš©)";

	/// <summary>
	/// Key: "Label.PlayGamesInMobile"
	/// section title
	/// English String: "Play Roblox in our mobile app!"
	/// </summary>
	public override string LabelPlayGamesInMobile => "ëª¨ë°”ì¼ ì•±ìœ¼ë¡œ Robloxë¥¼ í”Œë ˆì´í•˜ì„¸ìš”!";

	/// <summary>
	/// Key: "Message.AppBumpAndroidDevice"
	/// The user is being encouraged to play on the native mobile Android app
	/// English String: "Play Roblox in our Android app!"
	/// </summary>
	public override string MessageAppBumpAndroidDevice => "Android ì•±ìœ¼ë¡œ Robloxë¥¼ í”Œë ˆì´í•˜ì„¸ìš”!";

	/// <summary>
	/// Key: "Message.AppBumperUpsell"
	/// The user is being encouraged to play through the mobile app.
	/// English String: "Millions of games by players like you"
	/// </summary>
	public override string MessageAppBumperUpsell => "íšŒì›ë‹˜ê³¼ ê°™ì€ í”Œë ˆì´ì–´ë“¤ì´ ë§Œë“  ìˆ˜ë§Žì€ ê²Œìž„";

	/// <summary>
	/// Key: "Message.AppBumpIOSDevice"
	/// The user is being encouraged to play on the native mobile iOS app
	/// English String: "Play Roblox in our iOS app!"
	/// </summary>
	public override string MessageAppBumpIOSDevice => "iOS ì•±ìœ¼ë¡œ Robloxë¥¼ í”Œë ˆì´í•˜ì„¸ìš”!";

	public DownloadAppResources_ko_kr(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionContinueInApp()
	{
		return "ì•±ì—ì„œ ê³„ì†";
	}

	protected override string _GetTemplateForActionContinueInBrowser()
	{
		return "ë¸Œë¼ìš°ì €ì—ì„œ ê³„ì†";
	}

	protected override string _GetTemplateForActionPlay()
	{
		return "í”Œë ˆì´";
	}

	protected override string _GetTemplateForHeadingRobloxForAndroid()
	{
		return "Roblox (Androidìš©)";
	}

	protected override string _GetTemplateForHeadingRobloxForIos()
	{
		return "Roblox (iOSìš©)";
	}

	protected override string _GetTemplateForLabelPlayGamesInMobile()
	{
		return "ëª¨ë°”ì¼ ì•±ìœ¼ë¡œ Robloxë¥¼ í”Œë ˆì´í•˜ì„¸ìš”!";
	}

	/// <summary>
	/// Key: "Label.ReviewsCount"
	/// label
	/// English String: "{reviewCount} reviews"
	/// </summary>
	public override string LabelReviewsCount(string reviewCount)
	{
		return $"ë¦¬ë·° {reviewCount}ê°œ";
	}

	protected override string _GetTemplateForLabelReviewsCount()
	{
		return "ë¦¬ë·° {reviewCount}ê°œ";
	}

	protected override string _GetTemplateForMessageAppBumpAndroidDevice()
	{
		return "Android ì•±ìœ¼ë¡œ Robloxë¥¼ í”Œë ˆì´í•˜ì„¸ìš”!";
	}

	protected override string _GetTemplateForMessageAppBumperUpsell()
	{
		return "íšŒì›ë‹˜ê³¼ ê°™ì€ í”Œë ˆì´ì–´ë“¤ì´ ë§Œë“  ìˆ˜ë§Žì€ ê²Œìž„";
	}

	protected override string _GetTemplateForMessageAppBumpIOSDevice()
	{
		return "iOS ì•±ìœ¼ë¡œ Robloxë¥¼ í”Œë ˆì´í•˜ì„¸ìš”!";
	}
}


}
