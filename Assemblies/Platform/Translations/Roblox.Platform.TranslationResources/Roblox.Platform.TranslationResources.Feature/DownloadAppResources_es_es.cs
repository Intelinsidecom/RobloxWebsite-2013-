namespace Roblox.Platform.TranslationResources.Feature {
    /// <summary>

/// This class overrides DownloadAppResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class DownloadAppResources_es_es : DownloadAppResources_en_us, IDownloadAppResources, ITranslationResources
{
	/// <summary>
	/// Key: "Action.ContinueInApp"
	/// button label
	/// English String: "Continue in App"
	/// </summary>
	public override string ActionContinueInApp => "Continuar en la aplicaciÃ³n";

	/// <summary>
	/// Key: "Action.ContinueInBrowser"
	/// button label
	/// English String: "Continue in browser"
	/// </summary>
	public override string ActionContinueInBrowser => "Continuar en el navegador";

	/// <summary>
	/// Key: "Action.Play"
	/// Button that takes the user to the game.
	/// English String: "Play"
	/// </summary>
	public override string ActionPlay => "Jugar";

	/// <summary>
	/// Key: "Heading.RobloxForAndroid"
	/// heading for the page
	/// English String: "Roblox for Android"
	/// </summary>
	public override string HeadingRobloxForAndroid => "Roblox para Android";

	/// <summary>
	/// Key: "Heading.RobloxForIos"
	/// heading for page
	/// English String: "Roblox for iOS"
	/// </summary>
	public override string HeadingRobloxForIos => "Roblox para iOS";

	/// <summary>
	/// Key: "Label.PlayGamesInMobile"
	/// section title
	/// English String: "Play Roblox in our mobile app!"
	/// </summary>
	public override string LabelPlayGamesInMobile => "Â¡Juega Roblox en nuestra aplicaciÃ³n para mÃ³vil!";

	/// <summary>
	/// Key: "Message.AppBumpAndroidDevice"
	/// The user is being encouraged to play on the native mobile Android app
	/// English String: "Play Roblox in our Android app!"
	/// </summary>
	public override string MessageAppBumpAndroidDevice => "Â¡Juega Roblox en nuestra aplicaciÃ³n para Android!";

	/// <summary>
	/// Key: "Message.AppBumperUpsell"
	/// The user is being encouraged to play through the mobile app.
	/// English String: "Millions of games by players like you"
	/// </summary>
	public override string MessageAppBumperUpsell => "Millones de juegos generados por jugadores como tÃº";

	/// <summary>
	/// Key: "Message.AppBumpIOSDevice"
	/// The user is being encouraged to play on the native mobile iOS app
	/// English String: "Play Roblox in our iOS app!"
	/// </summary>
	public override string MessageAppBumpIOSDevice => "Â¡Juega Roblox en nuestra aplicaciÃ³n para iOS!";

	public DownloadAppResources_es_es(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionContinueInApp()
	{
		return "Continuar en la aplicaciÃ³n";
	}

	protected override string _GetTemplateForActionContinueInBrowser()
	{
		return "Continuar en el navegador";
	}

	protected override string _GetTemplateForActionPlay()
	{
		return "Jugar";
	}

	protected override string _GetTemplateForHeadingRobloxForAndroid()
	{
		return "Roblox para Android";
	}

	protected override string _GetTemplateForHeadingRobloxForIos()
	{
		return "Roblox para iOS";
	}

	protected override string _GetTemplateForLabelPlayGamesInMobile()
	{
		return "Â¡Juega Roblox en nuestra aplicaciÃ³n para mÃ³vil!";
	}

	/// <summary>
	/// Key: "Label.ReviewsCount"
	/// label
	/// English String: "{reviewCount} reviews"
	/// </summary>
	public override string LabelReviewsCount(string reviewCount)
	{
		return $"{reviewCount} reseÃ±as";
	}

	protected override string _GetTemplateForLabelReviewsCount()
	{
		return "{reviewCount} reseÃ±as";
	}

	protected override string _GetTemplateForMessageAppBumpAndroidDevice()
	{
		return "Â¡Juega Roblox en nuestra aplicaciÃ³n para Android!";
	}

	protected override string _GetTemplateForMessageAppBumperUpsell()
	{
		return "Millones de juegos generados por jugadores como tÃº";
	}

	protected override string _GetTemplateForMessageAppBumpIOSDevice()
	{
		return "Â¡Juega Roblox en nuestra aplicaciÃ³n para iOS!";
	}
}


}
