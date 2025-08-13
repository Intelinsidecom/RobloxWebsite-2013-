namespace Roblox.TranslationResources.Feature;

/// <summary>
/// This class overrides ShopDialogResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class ShopDialogResources_fr_fr : ShopDialogResources_en_us, IShopDialogResources, ITranslationResources
{
	/// <summary>
	/// Key: "Action.Cancel"
	/// button text
	/// English String: "Cancel"
	/// </summary>
	public override string ActionCancel => "Annuler";

	/// <summary>
	/// Key: "Action.Continue"
	/// English String: "Continue"
	/// </summary>
	public override string ActionContinue => "Continuer";

	/// <summary>
	/// Key: "Action.ContinueToShop"
	/// button text
	/// English String: "Continue to Shop"
	/// </summary>
	public override string ActionContinueToShop => "Continuer vers la boutique";

	/// <summary>
	/// Key: "Description.AgeWarning"
	/// age warning message
	/// English String: "Please note that you need to be over 18 to purchase products online. The Amazon store is not part of Roblox.com and is governed by a separate privacy policy."
	/// </summary>
	public override string DescriptionAgeWarning => "Remarque\u00a0: Vous devez avoir 18\u00a0ans ou plus afin d'acheter des articles en ligne. La boutique Amazon ne fait pas partie de Roblox.com et est régie par une politique de confidentialité qui lui est propre.";

	/// <summary>
	/// Key: "Description.PurchaseAgeWarning"
	/// English String: "Please note that you need to be over 18 to purchase products online. We hope to see you again soon!"
	/// </summary>
	public override string DescriptionPurchaseAgeWarning => "Remarque\u00a0: Vous devez avoir 18\u00a0ans ou plus afin d'acheter des articles en ligne. Nous espérons vous revoir bientôt\u00a0!";

	/// <summary>
	/// Key: "Description.RetailWebsiteRedirect"
	/// English String: "Heads up, Robloxian – by clicking “continue,” you will be redirected to a retail website that is not owned or operated by Roblox. They may have different terms and privacy policies."
	/// </summary>
	public override string DescriptionRetailWebsiteRedirect => "Oyé, oyé, Robloxien\u00a0: en cliquant sur «\u00a0Continuer\u00a0», tu seras redirigé vers un site de vente dont Roblox n'est ni propriétaire, ni gestionnaire. Les conditions d'utilisation et la politique de confidentialité sont susceptibles d'être différentes.";

	/// <summary>
	/// Key: "Heading.LeavingRoblox"
	/// dialog heading
	/// English String: "You are leaving Roblox"
	/// </summary>
	public override string HeadingLeavingRoblox => "Vous quittez Roblox";

	public ShopDialogResources_fr_fr(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionCancel()
	{
		return "Annuler";
	}

	protected override string _GetTemplateForActionContinue()
	{
		return "Continuer";
	}

	protected override string _GetTemplateForActionContinueToShop()
	{
		return "Continuer vers la boutique";
	}

	protected override string _GetTemplateForDescriptionAgeWarning()
	{
		return "Remarque\u00a0: Vous devez avoir 18\u00a0ans ou plus afin d'acheter des articles en ligne. La boutique Amazon ne fait pas partie de Roblox.com et est régie par une politique de confidentialité qui lui est propre.";
	}

	/// <summary>
	/// Key: "Description.AmazonRedirect"
	/// message in the modal
	/// English String: "Your are about to visit our amazon store. You will be redirected to Roblox merchandise store on {shopLink}."
	/// </summary>
	public override string DescriptionAmazonRedirect(string shopLink)
	{
		return $"Vous êtes sur le point d'entrer dans notre boutique Amazon. Vous serez redirigé(e) vers notre boutique d'articles Roblox à l'adresse {shopLink}.";
	}

	protected override string _GetTemplateForDescriptionAmazonRedirect()
	{
		return "Vous êtes sur le point d'entrer dans notre boutique Amazon. Vous serez redirigé(e) vers notre boutique d'articles Roblox à l'adresse {shopLink}.";
	}

	protected override string _GetTemplateForDescriptionPurchaseAgeWarning()
	{
		return "Remarque\u00a0: Vous devez avoir 18\u00a0ans ou plus afin d'acheter des articles en ligne. Nous espérons vous revoir bientôt\u00a0!";
	}

	protected override string _GetTemplateForDescriptionRetailWebsiteRedirect()
	{
		return "Oyé, oyé, Robloxien\u00a0: en cliquant sur «\u00a0Continuer\u00a0», tu seras redirigé vers un site de vente dont Roblox n'est ni propriétaire, ni gestionnaire. Les conditions d'utilisation et la politique de confidentialité sont susceptibles d'être différentes.";
	}

	protected override string _GetTemplateForHeadingLeavingRoblox()
	{
		return "Vous quittez Roblox";
	}
}
