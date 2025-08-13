namespace Roblox.TranslationResources.Feature;

/// <summary>
/// This class overrides ShopDialogResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class ShopDialogResources_pt_br : ShopDialogResources_en_us, IShopDialogResources, ITranslationResources
{
	/// <summary>
	/// Key: "Action.Cancel"
	/// button text
	/// English String: "Cancel"
	/// </summary>
	public override string ActionCancel => "Cancelar";

	/// <summary>
	/// Key: "Action.Continue"
	/// English String: "Continue"
	/// </summary>
	public override string ActionContinue => "Continuar";

	/// <summary>
	/// Key: "Action.ContinueToShop"
	/// button text
	/// English String: "Continue to Shop"
	/// </summary>
	public override string ActionContinueToShop => "Continuar para a Loja";

	/// <summary>
	/// Key: "Description.AgeWarning"
	/// age warning message
	/// English String: "Please note that you need to be over 18 to purchase products online. The Amazon store is not part of Roblox.com and is governed by a separate privacy policy."
	/// </summary>
	public override string DescriptionAgeWarning => "Fique ciente de que você precisa ter 18 anos ou mais para comprar produtos online. A loja da Amazon não faz parte de Roblox.com e é regida por uma política de privacidade separada.";

	/// <summary>
	/// Key: "Description.PurchaseAgeWarning"
	/// English String: "Please note that you need to be over 18 to purchase products online. We hope to see you again soon!"
	/// </summary>
	public override string DescriptionPurchaseAgeWarning => "Fique ciente de que você precisa ter 18 anos ou mais para comprar produtos online. Esperamos ver você novamente em breve";

	/// <summary>
	/// Key: "Description.RetailWebsiteRedirect"
	/// English String: "Heads up, Robloxian – by clicking “continue,” you will be redirected to a retail website that is not owned or operated by Roblox. They may have different terms and privacy policies."
	/// </summary>
	public override string DescriptionRetailWebsiteRedirect => "Atenção, robloxiano - ao clicar em \"continuar\", você será redirecionado para um site comercial que não é de propriedade nem operado pela Roblox. Ele pode possuir termos e políticas de privacidade diferentes.";

	/// <summary>
	/// Key: "Heading.LeavingRoblox"
	/// dialog heading
	/// English String: "You are leaving Roblox"
	/// </summary>
	public override string HeadingLeavingRoblox => "Você está saindo do Roblox";

	public ShopDialogResources_pt_br(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionCancel()
	{
		return "Cancelar";
	}

	protected override string _GetTemplateForActionContinue()
	{
		return "Continuar";
	}

	protected override string _GetTemplateForActionContinueToShop()
	{
		return "Continuar para a Loja";
	}

	protected override string _GetTemplateForDescriptionAgeWarning()
	{
		return "Fique ciente de que você precisa ter 18 anos ou mais para comprar produtos online. A loja da Amazon não faz parte de Roblox.com e é regida por uma política de privacidade separada.";
	}

	/// <summary>
	/// Key: "Description.AmazonRedirect"
	/// message in the modal
	/// English String: "Your are about to visit our amazon store. You will be redirected to Roblox merchandise store on {shopLink}."
	/// </summary>
	public override string DescriptionAmazonRedirect(string shopLink)
	{
		return $"Você está prestes a visitar nossa loja da Amazon. Você será redirecionado para a loja de produtos do Roblox em {shopLink}.";
	}

	protected override string _GetTemplateForDescriptionAmazonRedirect()
	{
		return "Você está prestes a visitar nossa loja da Amazon. Você será redirecionado para a loja de produtos do Roblox em {shopLink}.";
	}

	protected override string _GetTemplateForDescriptionPurchaseAgeWarning()
	{
		return "Fique ciente de que você precisa ter 18 anos ou mais para comprar produtos online. Esperamos ver você novamente em breve";
	}

	protected override string _GetTemplateForDescriptionRetailWebsiteRedirect()
	{
		return "Atenção, robloxiano - ao clicar em \"continuar\", você será redirecionado para um site comercial que não é de propriedade nem operado pela Roblox. Ele pode possuir termos e políticas de privacidade diferentes.";
	}

	protected override string _GetTemplateForHeadingLeavingRoblox()
	{
		return "Você está saindo do Roblox";
	}
}
