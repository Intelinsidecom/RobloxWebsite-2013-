namespace Roblox.TranslationResources.Purchasing;

/// <summary>
/// This class overrides RobloxProductsResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class RobloxProductsResources_de_de : RobloxProductsResources_en_us, IRobloxProductsResources, ITranslationResources
{
	/// <summary>
	/// Key: "Heading.Sorry"
	/// English String: "Sorry"
	/// </summary>
	public override string HeadingSorry => "Tut uns leid";

	/// <summary>
	/// Key: "Message.BuyRobuxToCustomizeAvatar"
	/// English String: "Buy Robux to customize your avatar and get items in game!"
	/// </summary>
	public override string MessageBuyRobuxToCustomizeAvatar => "Kaufe Robux, um deinen Avatar anzupassen und Artikel im Spiel zu erwerben!";

	/// <summary>
	/// Key: "Message.TryAgainLater"
	/// English String: "Robux purchases are temporarily disabled. Please try again later."
	/// </summary>
	public override string MessageTryAgainLater => "Robux-Käufe sind derzeit deaktiviert. Bitte versuche es später erneut.";

	public RobloxProductsResources_de_de(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForHeadingSorry()
	{
		return "Tut uns leid";
	}

	protected override string _GetTemplateForMessageBuyRobuxToCustomizeAvatar()
	{
		return "Kaufe Robux, um deinen Avatar anzupassen und Artikel im Spiel zu erwerben!";
	}

	protected override string _GetTemplateForMessageTryAgainLater()
	{
		return "Robux-Käufe sind derzeit deaktiviert. Bitte versuche es später erneut.";
	}
}
