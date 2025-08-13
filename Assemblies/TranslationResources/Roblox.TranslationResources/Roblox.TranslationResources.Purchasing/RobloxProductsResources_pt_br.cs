namespace Roblox.TranslationResources.Purchasing;

/// <summary>
/// This class overrides RobloxProductsResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class RobloxProductsResources_pt_br : RobloxProductsResources_en_us, IRobloxProductsResources, ITranslationResources
{
	/// <summary>
	/// Key: "Heading.Sorry"
	/// English String: "Sorry"
	/// </summary>
	public override string HeadingSorry => "Ops";

	/// <summary>
	/// Key: "Message.BuyRobuxToCustomizeAvatar"
	/// English String: "Buy Robux to customize your avatar and get items in game!"
	/// </summary>
	public override string MessageBuyRobuxToCustomizeAvatar => "Compre Robux para personalizar seu avatar e obter itens no jogo!";

	/// <summary>
	/// Key: "Message.TryAgainLater"
	/// English String: "Robux purchases are temporarily disabled. Please try again later."
	/// </summary>
	public override string MessageTryAgainLater => "Compras de Robux estão desabilitadas no momento. Tente de novo mais tarde.";

	public RobloxProductsResources_pt_br(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForHeadingSorry()
	{
		return "Ops";
	}

	protected override string _GetTemplateForMessageBuyRobuxToCustomizeAvatar()
	{
		return "Compre Robux para personalizar seu avatar e obter itens no jogo!";
	}

	protected override string _GetTemplateForMessageTryAgainLater()
	{
		return "Compras de Robux estão desabilitadas no momento. Tente de novo mais tarde.";
	}
}
