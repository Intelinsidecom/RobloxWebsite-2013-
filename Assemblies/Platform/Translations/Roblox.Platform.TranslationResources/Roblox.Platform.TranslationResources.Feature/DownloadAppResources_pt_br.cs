namespace Roblox.TranslationResources.Feature;

/// <summary>
/// This class overrides DownloadAppResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class DownloadAppResources_pt_br : DownloadAppResources_en_us, IDownloadAppResources, ITranslationResources
{
	/// <summary>
	/// Key: "Action.ContinueInApp"
	/// button label
	/// English String: "Continue in App"
	/// </summary>
	public override string ActionContinueInApp => "Continuar no app";

	/// <summary>
	/// Key: "Action.ContinueInBrowser"
	/// button label
	/// English String: "Continue in browser"
	/// </summary>
	public override string ActionContinueInBrowser => "Continuar no navegador";

	/// <summary>
	/// Key: "Action.Play"
	/// Button that takes the user to the game.
	/// English String: "Play"
	/// </summary>
	public override string ActionPlay => "Jogar";

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
	public override string LabelPlayGamesInMobile => "Jogue Roblox no nosso app para dispositivos móveis!";

	/// <summary>
	/// Key: "Message.AppBumpAndroidDevice"
	/// The user is being encouraged to play on the native mobile Android app
	/// English String: "Play Roblox in our Android app!"
	/// </summary>
	public override string MessageAppBumpAndroidDevice => "Jogue Roblox no nosso app para Android!";

	/// <summary>
	/// Key: "Message.AppBumperUpsell"
	/// The user is being encouraged to play through the mobile app.
	/// English String: "Millions of games by players like you"
	/// </summary>
	public override string MessageAppBumperUpsell => "Milhões de jogos feitos por jogadores como você";

	/// <summary>
	/// Key: "Message.AppBumpIOSDevice"
	/// The user is being encouraged to play on the native mobile iOS app
	/// English String: "Play Roblox in our iOS app!"
	/// </summary>
	public override string MessageAppBumpIOSDevice => "Jogue Roblox no nosso app para iOS!";

	public DownloadAppResources_pt_br(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionContinueInApp()
	{
		return "Continuar no app";
	}

	protected override string _GetTemplateForActionContinueInBrowser()
	{
		return "Continuar no navegador";
	}

	protected override string _GetTemplateForActionPlay()
	{
		return "Jogar";
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
		return "Jogue Roblox no nosso app para dispositivos móveis!";
	}

	/// <summary>
	/// Key: "Label.ReviewsCount"
	/// label
	/// English String: "{reviewCount} reviews"
	/// </summary>
	public override string LabelReviewsCount(string reviewCount)
	{
		return $"{reviewCount} avaliações";
	}

	protected override string _GetTemplateForLabelReviewsCount()
	{
		return "{reviewCount} avaliações";
	}

	protected override string _GetTemplateForMessageAppBumpAndroidDevice()
	{
		return "Jogue Roblox no nosso app para Android!";
	}

	protected override string _GetTemplateForMessageAppBumperUpsell()
	{
		return "Milhões de jogos feitos por jogadores como você";
	}

	protected override string _GetTemplateForMessageAppBumpIOSDevice()
	{
		return "Jogue Roblox no nosso app para iOS!";
	}
}
