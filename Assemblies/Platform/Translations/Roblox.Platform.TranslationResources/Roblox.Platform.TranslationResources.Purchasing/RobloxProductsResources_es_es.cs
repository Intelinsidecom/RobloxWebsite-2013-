namespace Roblox.TranslationResources.Purchasing;

/// <summary>
/// This class overrides RobloxProductsResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class RobloxProductsResources_es_es : RobloxProductsResources_en_us, IRobloxProductsResources, ITranslationResources
{
	/// <summary>
	/// Key: "Heading.Sorry"
	/// English String: "Sorry"
	/// </summary>
	public override string HeadingSorry => "Lo sentimos.";

	/// <summary>
	/// Key: "Message.BuyRobuxToCustomizeAvatar"
	/// English String: "Buy Robux to customize your avatar and get items in game!"
	/// </summary>
	public override string MessageBuyRobuxToCustomizeAvatar => "Compra Robux para personalizar tu avatar y obtener objetos en el juego";

	/// <summary>
	/// Key: "Message.TryAgainLater"
	/// English String: "Robux purchases are temporarily disabled. Please try again later."
	/// </summary>
	public override string MessageTryAgainLater => "Las compras con Robux están desactivadas temporalmente. Inténtalo de nuevo más tarde.";

	public RobloxProductsResources_es_es(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForHeadingSorry()
	{
		return "Lo sentimos.";
	}

	protected override string _GetTemplateForMessageBuyRobuxToCustomizeAvatar()
	{
		return "Compra Robux para personalizar tu avatar y obtener objetos en el juego";
	}

	protected override string _GetTemplateForMessageTryAgainLater()
	{
		return "Las compras con Robux están desactivadas temporalmente. Inténtalo de nuevo más tarde.";
	}
}
