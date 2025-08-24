namespace Roblox.TranslationResources.Feature;

/// <summary>
/// This class overrides DownloadAppResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class DownloadAppResources_de_de : DownloadAppResources_en_us, IDownloadAppResources, ITranslationResources
{
	/// <summary>
	/// Key: "Action.ContinueInApp"
	/// button label
	/// English String: "Continue in App"
	/// </summary>
	public override string ActionContinueInApp => "In App fortfahren";

	/// <summary>
	/// Key: "Action.ContinueInBrowser"
	/// button label
	/// English String: "Continue in browser"
	/// </summary>
	public override string ActionContinueInBrowser => "In Browser fortfahren";

	/// <summary>
	/// Key: "Action.Play"
	/// Button that takes the user to the game.
	/// English String: "Play"
	/// </summary>
	public override string ActionPlay => "Spielen";

	/// <summary>
	/// Key: "Heading.RobloxForAndroid"
	/// heading for the page
	/// English String: "Roblox for Android"
	/// </summary>
	public override string HeadingRobloxForAndroid => "Roblox für Android";

	/// <summary>
	/// Key: "Heading.RobloxForIos"
	/// heading for page
	/// English String: "Roblox for iOS"
	/// </summary>
	public override string HeadingRobloxForIos => "Roblox für iOS";

	/// <summary>
	/// Key: "Label.PlayGamesInMobile"
	/// section title
	/// English String: "Play Roblox in our mobile app!"
	/// </summary>
	public override string LabelPlayGamesInMobile => "Spiele Roblox in unserer App für Mobilgeräte!";

	/// <summary>
	/// Key: "Message.AppBumpAndroidDevice"
	/// The user is being encouraged to play on the native mobile Android app
	/// English String: "Play Roblox in our Android app!"
	/// </summary>
	public override string MessageAppBumpAndroidDevice => "Spiele Roblox in unserer Android-App!";

	/// <summary>
	/// Key: "Message.AppBumperUpsell"
	/// The user is being encouraged to play through the mobile app.
	/// English String: "Millions of games by players like you"
	/// </summary>
	public override string MessageAppBumperUpsell => "Millionen von Spielen von Benutzern wie dir";

	/// <summary>
	/// Key: "Message.AppBumpIOSDevice"
	/// The user is being encouraged to play on the native mobile iOS app
	/// English String: "Play Roblox in our iOS app!"
	/// </summary>
	public override string MessageAppBumpIOSDevice => "Spiele Roblox in unserer iOS-App!";

	public DownloadAppResources_de_de(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionContinueInApp()
	{
		return "In App fortfahren";
	}

	protected override string _GetTemplateForActionContinueInBrowser()
	{
		return "In Browser fortfahren";
	}

	protected override string _GetTemplateForActionPlay()
	{
		return "Spielen";
	}

	protected override string _GetTemplateForHeadingRobloxForAndroid()
	{
		return "Roblox für Android";
	}

	protected override string _GetTemplateForHeadingRobloxForIos()
	{
		return "Roblox für iOS";
	}

	protected override string _GetTemplateForLabelPlayGamesInMobile()
	{
		return "Spiele Roblox in unserer App für Mobilgeräte!";
	}

	/// <summary>
	/// Key: "Label.ReviewsCount"
	/// label
	/// English String: "{reviewCount} reviews"
	/// </summary>
	public override string LabelReviewsCount(string reviewCount)
	{
		return $"{reviewCount} Bewertungen";
	}

	protected override string _GetTemplateForLabelReviewsCount()
	{
		return "{reviewCount} Bewertungen";
	}

	protected override string _GetTemplateForMessageAppBumpAndroidDevice()
	{
		return "Spiele Roblox in unserer Android-App!";
	}

	protected override string _GetTemplateForMessageAppBumperUpsell()
	{
		return "Millionen von Spielen von Benutzern wie dir";
	}

	protected override string _GetTemplateForMessageAppBumpIOSDevice()
	{
		return "Spiele Roblox in unserer iOS-App!";
	}
}
