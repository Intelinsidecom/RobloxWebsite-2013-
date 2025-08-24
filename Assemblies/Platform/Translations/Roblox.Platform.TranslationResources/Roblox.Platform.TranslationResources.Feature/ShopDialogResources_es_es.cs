namespace Roblox.TranslationResources.Feature;

/// <summary>
/// This class overrides ShopDialogResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class ShopDialogResources_es_es : ShopDialogResources_en_us, IShopDialogResources, ITranslationResources
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
	public override string ActionContinueToShop => "Continuar a la tienda";

	/// <summary>
	/// Key: "Description.AgeWarning"
	/// age warning message
	/// English String: "Please note that you need to be over 18 to purchase products online. The Amazon store is not part of Roblox.com and is governed by a separate privacy policy."
	/// </summary>
	public override string DescriptionAgeWarning => "Ten en cuenta que tienes que ser mayor de 18 años para comprar productos en línea. La tienda de Amazon no forma parte de Roblox.com y se rige por su propia política de privacidad.";

	/// <summary>
	/// Key: "Description.PurchaseAgeWarning"
	/// English String: "Please note that you need to be over 18 to purchase products online. We hope to see you again soon!"
	/// </summary>
	public override string DescriptionPurchaseAgeWarning => "Ten en cuenta que debes ser mayor de 18 años para comprar productos en línea. ¡Esperamos verte pronto!";

	/// <summary>
	/// Key: "Description.RetailWebsiteRedirect"
	/// English String: "Heads up, Robloxian – by clicking “continue,” you will be redirected to a retail website that is not owned or operated by Roblox. They may have different terms and privacy policies."
	/// </summary>
	public override string DescriptionRetailWebsiteRedirect => "¡Hola, robloxianos! Al hacer clic en \"Continuar\", serán redirigidos al sitio de una tienda que no pertenece y no es operada por Roblox. Puede que se rija por términos y políticas de privacidad diferentes.";

	/// <summary>
	/// Key: "Heading.LeavingRoblox"
	/// dialog heading
	/// English String: "You are leaving Roblox"
	/// </summary>
	public override string HeadingLeavingRoblox => "Estás abandonando Roblox";

	public ShopDialogResources_es_es(TranslationResourceState state)
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
		return "Continuar a la tienda";
	}

	protected override string _GetTemplateForDescriptionAgeWarning()
	{
		return "Ten en cuenta que tienes que ser mayor de 18 años para comprar productos en línea. La tienda de Amazon no forma parte de Roblox.com y se rige por su propia política de privacidad.";
	}

	/// <summary>
	/// Key: "Description.AmazonRedirect"
	/// message in the modal
	/// English String: "Your are about to visit our amazon store. You will be redirected to Roblox merchandise store on {shopLink}."
	/// </summary>
	public override string DescriptionAmazonRedirect(string shopLink)
	{
		return $"Estás a punto de entrar a nuestra tienda de Amazon. Serás redirigido a la tienda de Roblox en {shopLink}.";
	}

	protected override string _GetTemplateForDescriptionAmazonRedirect()
	{
		return "Estás a punto de entrar a nuestra tienda de Amazon. Serás redirigido a la tienda de Roblox en {shopLink}.";
	}

	protected override string _GetTemplateForDescriptionPurchaseAgeWarning()
	{
		return "Ten en cuenta que debes ser mayor de 18 años para comprar productos en línea. ¡Esperamos verte pronto!";
	}

	protected override string _GetTemplateForDescriptionRetailWebsiteRedirect()
	{
		return "¡Hola, robloxianos! Al hacer clic en \"Continuar\", serán redirigidos al sitio de una tienda que no pertenece y no es operada por Roblox. Puede que se rija por términos y políticas de privacidad diferentes.";
	}

	protected override string _GetTemplateForHeadingLeavingRoblox()
	{
		return "Estás abandonando Roblox";
	}
}
