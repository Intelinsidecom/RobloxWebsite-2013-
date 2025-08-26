namespace Roblox.Platform.TranslationResources.Feature {
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
	public override string ActionContinueInApp => "ã‚¢ãƒ—ãƒªã§ç¶šã‘ã‚‹";

	/// <summary>
	/// Key: "Action.ContinueInBrowser"
	/// button label
	/// English String: "Continue in browser"
	/// </summary>
	public override string ActionContinueInBrowser => "ãƒ–ãƒ©ã‚¦ã‚¶ã§ç¶šã‘ã‚‹";

	/// <summary>
	/// Key: "Action.Play"
	/// Button that takes the user to the game.
	/// English String: "Play"
	/// </summary>
	public override string ActionPlay => "ãƒ—ãƒ¬ã‚¤";

	/// <summary>
	/// Key: "Heading.RobloxForAndroid"
	/// heading for the page
	/// English String: "Roblox for Android"
	/// </summary>
	public override string HeadingRobloxForAndroid => "Robloxï¼ˆAndroidç‰ˆï¼‰";

	/// <summary>
	/// Key: "Heading.RobloxForIos"
	/// heading for page
	/// English String: "Roblox for iOS"
	/// </summary>
	public override string HeadingRobloxForIos => "Robloxï¼ˆiOSç‰ˆï¼‰";

	/// <summary>
	/// Key: "Label.PlayGamesInMobile"
	/// section title
	/// English String: "Play Roblox in our mobile app!"
	/// </summary>
	public override string LabelPlayGamesInMobile => "ãƒ¢ãƒã‚¤ãƒ«ã‚¢ãƒ—ãƒªã§Robloxã‚’ãƒ—ãƒ¬ã‚¤ã™ã‚‹ï¼";

	/// <summary>
	/// Key: "Message.AppBumpAndroidDevice"
	/// The user is being encouraged to play on the native mobile Android app
	/// English String: "Play Roblox in our Android app!"
	/// </summary>
	public override string MessageAppBumpAndroidDevice => "Androidã®ã‚¢ãƒ—ãƒªã§Robloxã‚’ãƒ—ãƒ¬ã‚¤ã™ã‚‹ï¼";

	/// <summary>
	/// Key: "Message.AppBumperUpsell"
	/// The user is being encouraged to play through the mobile app.
	/// English String: "Millions of games by players like you"
	/// </summary>
	public override string MessageAppBumperUpsell => "ã‚ãªãŸã®ã‚ˆã†ãªãƒ—ãƒ¬ã‚¤ãƒ¤ãƒ¼ãŒåˆ¶ä½œã—ãŸæ•°ç™¾ä¸‡ã‚‚ã®ã‚²ãƒ¼ãƒ ";

	/// <summary>
	/// Key: "Message.AppBumpIOSDevice"
	/// The user is being encouraged to play on the native mobile iOS app
	/// English String: "Play Roblox in our iOS app!"
	/// </summary>
	public override string MessageAppBumpIOSDevice => "iOSã®ã‚¢ãƒ—ãƒªã§ Robloxã‚’ãƒ—ãƒ¬ã‚¤ã™ã‚‹ï¼";

	public DownloadAppResources_ja_jp(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionContinueInApp()
	{
		return "ã‚¢ãƒ—ãƒªã§ç¶šã‘ã‚‹";
	}

	protected override string _GetTemplateForActionContinueInBrowser()
	{
		return "ãƒ–ãƒ©ã‚¦ã‚¶ã§ç¶šã‘ã‚‹";
	}

	protected override string _GetTemplateForActionPlay()
	{
		return "ãƒ—ãƒ¬ã‚¤";
	}

	protected override string _GetTemplateForHeadingRobloxForAndroid()
	{
		return "Robloxï¼ˆAndroidç‰ˆï¼‰";
	}

	protected override string _GetTemplateForHeadingRobloxForIos()
	{
		return "Robloxï¼ˆiOSç‰ˆï¼‰";
	}

	protected override string _GetTemplateForLabelPlayGamesInMobile()
	{
		return "ãƒ¢ãƒã‚¤ãƒ«ã‚¢ãƒ—ãƒªã§Robloxã‚’ãƒ—ãƒ¬ã‚¤ã™ã‚‹ï¼";
	}

	/// <summary>
	/// Key: "Label.ReviewsCount"
	/// label
	/// English String: "{reviewCount} reviews"
	/// </summary>
	public override string LabelReviewsCount(string reviewCount)
	{
		return $"{reviewCount} ä»¶ã®ãƒ¬ãƒ“ãƒ¥ãƒ¼";
	}

	protected override string _GetTemplateForLabelReviewsCount()
	{
		return "{reviewCount} ä»¶ã®ãƒ¬ãƒ“ãƒ¥ãƒ¼";
	}

	protected override string _GetTemplateForMessageAppBumpAndroidDevice()
	{
		return "Androidã®ã‚¢ãƒ—ãƒªã§Robloxã‚’ãƒ—ãƒ¬ã‚¤ã™ã‚‹ï¼";
	}

	protected override string _GetTemplateForMessageAppBumperUpsell()
	{
		return "ã‚ãªãŸã®ã‚ˆã†ãªãƒ—ãƒ¬ã‚¤ãƒ¤ãƒ¼ãŒåˆ¶ä½œã—ãŸæ•°ç™¾ä¸‡ã‚‚ã®ã‚²ãƒ¼ãƒ ";
	}

	protected override string _GetTemplateForMessageAppBumpIOSDevice()
	{
		return "iOSã®ã‚¢ãƒ—ãƒªã§ Robloxã‚’ãƒ—ãƒ¬ã‚¤ã™ã‚‹ï¼";
	}
}


}
