namespace Roblox.TranslationResources.Feature;

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
	public override string ActionContinueInApp => "Continuar en la aplicación";

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
	public override string LabelPlayGamesInMobile => "¡Juega Roblox en nuestra aplicación para móvil!";

	/// <summary>
	/// Key: "Message.AppBumpAndroidDevice"
	/// The user is being encouraged to play on the native mobile Android app
	/// English String: "Play Roblox in our Android app!"
	/// </summary>
	public override string MessageAppBumpAndroidDevice => "¡Juega Roblox en nuestra aplicación para Android!";

	/// <summary>
	/// Key: "Message.AppBumperUpsell"
	/// The user is being encouraged to play through the mobile app.
	/// English String: "Millions of games by players like you"
	/// </summary>
	public override string MessageAppBumperUpsell => "Millones de juegos generados por jugadores como tú";

	/// <summary>
	/// Key: "Message.AppBumpIOSDevice"
	/// The user is being encouraged to play on the native mobile iOS app
	/// English String: "Play Roblox in our iOS app!"
	/// </summary>
	public override string MessageAppBumpIOSDevice => "¡Juega Roblox en nuestra aplicación para iOS!";

	public DownloadAppResources_es_es(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionContinueInApp()
	{
		return "Continuar en la aplicación";
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
		return "¡Juega Roblox en nuestra aplicación para móvil!";
	}

	/// <summary>
	/// Key: "Label.ReviewsCount"
	/// label
	/// English String: "{reviewCount} reviews"
	/// </summary>
	public override string LabelReviewsCount(string reviewCount)
	{
		return $"{reviewCount} reseñas";
	}

	protected override string _GetTemplateForLabelReviewsCount()
	{
		return "{reviewCount} reseñas";
	}

	protected override string _GetTemplateForMessageAppBumpAndroidDevice()
	{
		return "¡Juega Roblox en nuestra aplicación para Android!";
	}

	protected override string _GetTemplateForMessageAppBumperUpsell()
	{
		return "Millones de juegos generados por jugadores como tú";
	}

	protected override string _GetTemplateForMessageAppBumpIOSDevice()
	{
		return "¡Juega Roblox en nuestra aplicación para iOS!";
	}
}
