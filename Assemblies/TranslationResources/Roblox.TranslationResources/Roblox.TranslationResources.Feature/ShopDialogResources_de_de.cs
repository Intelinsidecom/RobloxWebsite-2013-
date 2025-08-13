namespace Roblox.TranslationResources.Feature;

/// <summary>
/// This class overrides ShopDialogResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class ShopDialogResources_de_de : ShopDialogResources_en_us, IShopDialogResources, ITranslationResources
{
	/// <summary>
	/// Key: "Action.Cancel"
	/// button text
	/// English String: "Cancel"
	/// </summary>
	public override string ActionCancel => "Abbrechen";

	/// <summary>
	/// Key: "Action.Continue"
	/// English String: "Continue"
	/// </summary>
	public override string ActionContinue => "Fortsetzen";

	/// <summary>
	/// Key: "Action.ContinueToShop"
	/// button text
	/// English String: "Continue to Shop"
	/// </summary>
	public override string ActionContinueToShop => "Weiter zum Shop";

	/// <summary>
	/// Key: "Description.AgeWarning"
	/// age warning message
	/// English String: "Please note that you need to be over 18 to purchase products online. The Amazon store is not part of Roblox.com and is governed by a separate privacy policy."
	/// </summary>
	public override string DescriptionAgeWarning => "Bitte beachte, dass du mindestens 18 Jahre alt sein musst, um Artikel online kaufen zu können. Der Amazon Store gehört nicht zu Roblox.com und unterliegt seiner eigenen Datenschutzrichtlinie.";

	/// <summary>
	/// Key: "Description.PurchaseAgeWarning"
	/// English String: "Please note that you need to be over 18 to purchase products online. We hope to see you again soon!"
	/// </summary>
	public override string DescriptionPurchaseAgeWarning => "Bitte beachte, dass du mindestens 18 Jahre alt sein musst, um Artikel online kaufen zu können. Wir hoffen, dich bald wiederzusehen!";

	/// <summary>
	/// Key: "Description.RetailWebsiteRedirect"
	/// English String: "Heads up, Robloxian – by clicking “continue,” you will be redirected to a retail website that is not owned or operated by Roblox. They may have different terms and privacy policies."
	/// </summary>
	public override string DescriptionRetailWebsiteRedirect => "Achtung, Roblox-Spieler\u00a0– wenn du auf „Fortsetzen“ klickst, wirst du zu einer Verkaufsseite weitergeleitet, die nicht von Roblox betrieben wird. Sie kann andere Nutzungsbedingungen und Datenschutzrichtlinien haben.";

	/// <summary>
	/// Key: "Heading.LeavingRoblox"
	/// dialog heading
	/// English String: "You are leaving Roblox"
	/// </summary>
	public override string HeadingLeavingRoblox => "Du verlässt jetzt Roblox.";

	public ShopDialogResources_de_de(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionCancel()
	{
		return "Abbrechen";
	}

	protected override string _GetTemplateForActionContinue()
	{
		return "Fortsetzen";
	}

	protected override string _GetTemplateForActionContinueToShop()
	{
		return "Weiter zum Shop";
	}

	protected override string _GetTemplateForDescriptionAgeWarning()
	{
		return "Bitte beachte, dass du mindestens 18 Jahre alt sein musst, um Artikel online kaufen zu können. Der Amazon Store gehört nicht zu Roblox.com und unterliegt seiner eigenen Datenschutzrichtlinie.";
	}

	/// <summary>
	/// Key: "Description.AmazonRedirect"
	/// message in the modal
	/// English String: "Your are about to visit our amazon store. You will be redirected to Roblox merchandise store on {shopLink}."
	/// </summary>
	public override string DescriptionAmazonRedirect(string shopLink)
	{
		return $"Du bist dabei, unseren Amazon Store zu besuchen. Du wirst zum Store für Roblox-Artikel auf {shopLink} weitergeleitet.";
	}

	protected override string _GetTemplateForDescriptionAmazonRedirect()
	{
		return "Du bist dabei, unseren Amazon Store zu besuchen. Du wirst zum Store für Roblox-Artikel auf {shopLink} weitergeleitet.";
	}

	protected override string _GetTemplateForDescriptionPurchaseAgeWarning()
	{
		return "Bitte beachte, dass du mindestens 18 Jahre alt sein musst, um Artikel online kaufen zu können. Wir hoffen, dich bald wiederzusehen!";
	}

	protected override string _GetTemplateForDescriptionRetailWebsiteRedirect()
	{
		return "Achtung, Roblox-Spieler\u00a0– wenn du auf „Fortsetzen“ klickst, wirst du zu einer Verkaufsseite weitergeleitet, die nicht von Roblox betrieben wird. Sie kann andere Nutzungsbedingungen und Datenschutzrichtlinien haben.";
	}

	protected override string _GetTemplateForHeadingLeavingRoblox()
	{
		return "Du verlässt jetzt Roblox.";
	}
}
