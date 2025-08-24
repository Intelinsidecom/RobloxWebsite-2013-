namespace Roblox.TranslationResources.Feature;

/// <summary>
/// This class overrides DownloadAppResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class DownloadAppResources_fr_fr : DownloadAppResources_en_us, IDownloadAppResources, ITranslationResources
{
	/// <summary>
	/// Key: "Action.ContinueInApp"
	/// button label
	/// English String: "Continue in App"
	/// </summary>
	public override string ActionContinueInApp => "Continuer dans l'application";

	/// <summary>
	/// Key: "Action.ContinueInBrowser"
	/// button label
	/// English String: "Continue in browser"
	/// </summary>
	public override string ActionContinueInBrowser => "Continuer dans le navigateur";

	/// <summary>
	/// Key: "Action.Play"
	/// Button that takes the user to the game.
	/// English String: "Play"
	/// </summary>
	public override string ActionPlay => "Jouer";

	/// <summary>
	/// Key: "Heading.RobloxForAndroid"
	/// heading for the page
	/// English String: "Roblox for Android"
	/// </summary>
	public override string HeadingRobloxForAndroid => "Roblox pour Android";

	/// <summary>
	/// Key: "Heading.RobloxForIos"
	/// heading for page
	/// English String: "Roblox for iOS"
	/// </summary>
	public override string HeadingRobloxForIos => "Roblox pour iOS";

	/// <summary>
	/// Key: "Label.PlayGamesInMobile"
	/// section title
	/// English String: "Play Roblox in our mobile app!"
	/// </summary>
	public override string LabelPlayGamesInMobile => "Jouez à des jeux Roblox sur notre application mobile!";

	/// <summary>
	/// Key: "Message.AppBumpAndroidDevice"
	/// The user is being encouraged to play on the native mobile Android app
	/// English String: "Play Roblox in our Android app!"
	/// </summary>
	public override string MessageAppBumpAndroidDevice => "Jouer sur l'application Android!";

	/// <summary>
	/// Key: "Message.AppBumperUpsell"
	/// The user is being encouraged to play through the mobile app.
	/// English String: "Millions of games by players like you"
	/// </summary>
	public override string MessageAppBumperUpsell => "Des millions de jeux créés par d'autres joueurs";

	/// <summary>
	/// Key: "Message.AppBumpIOSDevice"
	/// The user is being encouraged to play on the native mobile iOS app
	/// English String: "Play Roblox in our iOS app!"
	/// </summary>
	public override string MessageAppBumpIOSDevice => "Jouez à des jeux Roblox sur notre application iOS!";

	public DownloadAppResources_fr_fr(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionContinueInApp()
	{
		return "Continuer dans l'application";
	}

	protected override string _GetTemplateForActionContinueInBrowser()
	{
		return "Continuer dans le navigateur";
	}

	protected override string _GetTemplateForActionPlay()
	{
		return "Jouer";
	}

	protected override string _GetTemplateForHeadingRobloxForAndroid()
	{
		return "Roblox pour Android";
	}

	protected override string _GetTemplateForHeadingRobloxForIos()
	{
		return "Roblox pour iOS";
	}

	protected override string _GetTemplateForLabelPlayGamesInMobile()
	{
		return "Jouez à des jeux Roblox sur notre application mobile!";
	}

	/// <summary>
	/// Key: "Label.ReviewsCount"
	/// label
	/// English String: "{reviewCount} reviews"
	/// </summary>
	public override string LabelReviewsCount(string reviewCount)
	{
		return $"{reviewCount}\u00a0évaluations";
	}

	protected override string _GetTemplateForLabelReviewsCount()
	{
		return "{reviewCount}\u00a0évaluations";
	}

	protected override string _GetTemplateForMessageAppBumpAndroidDevice()
	{
		return "Jouer sur l'application Android!";
	}

	protected override string _GetTemplateForMessageAppBumperUpsell()
	{
		return "Des millions de jeux créés par d'autres joueurs";
	}

	protected override string _GetTemplateForMessageAppBumpIOSDevice()
	{
		return "Jouez à des jeux Roblox sur notre application iOS!";
	}
}
