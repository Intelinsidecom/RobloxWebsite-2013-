namespace Roblox.TranslationResources.Feature;

/// <summary>
/// This class overrides ItemModelResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class ItemModelResources_fr_fr : ItemModelResources_en_us, IItemModelResources, ITranslationResources
{
	/// <summary>
	/// Key: "Label.AmazonExclusiveItem"
	/// English String: "This is an Amazon exclusive item."
	/// </summary>
	public override string LabelAmazonExclusiveItem => "Il s'agit d'une exclusivité Amazon.";

	/// <summary>
	/// Key: "Label.AudioAssetBlockedCopyright"
	/// English String: "This audio asset has been blocked due to copyright violations.\n"
	/// </summary>
	public override string LabelAudioAssetBlockedCopyright => "Cet élément audio a été bloqué en raison d'une infraction de copyright.\n";

	/// <summary>
	/// Key: "Label.GooglePlayExclusiveItem"
	/// English String: "This is a Google Play exclusive item."
	/// </summary>
	public override string LabelGooglePlayExclusiveItem => "Il s'agit d'une exclusivité Google Play.";

	/// <summary>
	/// Key: "Label.IosDeviceExclusiveItem"
	/// English String: "This is an iOS exclusive item."
	/// </summary>
	public override string LabelIosDeviceExclusiveItem => "Il s'agit d'une exclusivité iOS.";

	/// <summary>
	/// Key: "Label.ItemAvailableInventory"
	/// English String: "This item is available in your inventory."
	/// </summary>
	public override string LabelItemAvailableInventory => "Cet objet se trouve dans ton inventaire.";

	/// <summary>
	/// Key: "Label.ItemHasBeenModerated"
	/// English String: "This item has been moderated."
	/// </summary>
	public override string LabelItemHasBeenModerated => "Cet objet a été modéré.";

	/// <summary>
	/// Key: "Label.ItemNoLongerForSale"
	/// English String: "This item is no longer for sale."
	/// </summary>
	public override string LabelItemNoLongerForSale => "Cet objet n'est plus en vente.";

	/// <summary>
	/// Key: "Label.ItemNotCurrentlyForSale"
	/// English String: "This item is not currently for sale."
	/// </summary>
	public override string LabelItemNotCurrentlyForSale => "Cet objet n'est pas en vente pour l'instant.";

	/// <summary>
	/// Key: "Label.MobileDeviceExclusiveItem"
	/// English String: "This is a mobile exclusive item."
	/// </summary>
	public override string LabelMobileDeviceExclusiveItem => "Il s'agit d'une exclusivité mobile.";

	/// <summary>
	/// Key: "Label.NoDescriptionAvailable"
	/// English String: "No description available."
	/// </summary>
	public override string LabelNoDescriptionAvailable => "Aucune description disponible.";

	/// <summary>
	/// Key: "Label.NoOneCurrentlySelling"
	/// English String: "There is no one currently selling this item."
	/// </summary>
	public override string LabelNoOneCurrentlySelling => "Personne ne vend actuellement cet objet.";

	/// <summary>
	/// Key: "Label.NoOtherSellers"
	/// English String: "No other sellers."
	/// </summary>
	public override string LabelNoOtherSellers => "Aucun autre vendeur.";

	/// <summary>
	/// Key: "Label.NotAvailable"
	/// English String: "N/A"
	/// </summary>
	public override string LabelNotAvailable => "s.\u00a0o.";

	/// <summary>
	/// Key: "Label.PurchasingTemporarilyUnavailable"
	/// English String: "Purchasing is temporarily unavailable. Please try again later."
	/// </summary>
	public override string LabelPurchasingTemporarilyUnavailable => "Les achats sont temporairement indisponibles. Veuillez réessayer plus tard.";

	/// <summary>
	/// Key: "Label.Resellers"
	/// English String: "Resellers"
	/// </summary>
	public override string LabelResellers => "Revendeurs";

	/// <summary>
	/// Key: "Label.RobloxAsset"
	/// English String: "Roblox Asset"
	/// </summary>
	public override string LabelRobloxAsset => "Élément Roblox";

	/// <summary>
	/// Key: "Label.TakeOff"
	/// English String: "Take Off"
	/// </summary>
	public override string LabelTakeOff => "Retirer";

	/// <summary>
	/// Key: "Label.ToInstallOpenStudio"
	/// English String: "To install, open this page in Roblox Studio."
	/// </summary>
	public override string LabelToInstallOpenStudio => "Pour l'installer, ouvrez cette page dans Roblox Studio.";

	/// <summary>
	/// Key: "Label.Wear"
	/// English String: "Wear"
	/// </summary>
	public override string LabelWear => "Porter";

	/// <summary>
	/// Key: "Label.XboxOneExclusiveItem"
	/// English String: "This is a Xbox One exclusive item."
	/// </summary>
	public override string LabelXboxOneExclusiveItem => "Il s'agit d'une exclusivité Xbox One.";

	/// <summary>
	/// Key: "Label.YouAreSelling"
	/// English String: "You are selling this item."
	/// </summary>
	public override string LabelYouAreSelling => "Vous vendez cet objet.";

	public ItemModelResources_fr_fr(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForLabelAmazonExclusiveItem()
	{
		return "Il s'agit d'une exclusivité Amazon.";
	}

	/// <summary>
	/// Key: "Label.AssetName"
	/// English String: "{assetName} - Roblox"
	/// </summary>
	public override string LabelAssetName(string assetName)
	{
		return $"{assetName} - Roblox";
	}

	protected override string _GetTemplateForLabelAssetName()
	{
		return "{assetName} - Roblox";
	}

	/// <summary>
	/// Key: "Label.AssetOptionRental"
	/// English String: "{assetOption} Rental"
	/// </summary>
	public override string LabelAssetOptionRental(string assetOption)
	{
		return $"Location\u00a0: {assetOption}";
	}

	protected override string _GetTemplateForLabelAssetOptionRental()
	{
		return "Location\u00a0: {assetOption}";
	}

	protected override string _GetTemplateForLabelAudioAssetBlockedCopyright()
	{
		return "Cet élément audio a été bloqué en raison d'une infraction de copyright.\n";
	}

	/// <summary>
	/// Key: "Label.BcRequirementExclusiveItem"
	/// English String: "{bcRequirementName} exclusive item."
	/// </summary>
	public override string LabelBcRequirementExclusiveItem(string bcRequirementName)
	{
		return $"Exclusivité {bcRequirementName}";
	}

	protected override string _GetTemplateForLabelBcRequirementExclusiveItem()
	{
		return "Exclusivité {bcRequirementName}";
	}

	/// <summary>
	/// Key: "Label.ExpiresRentalTime"
	/// English String: "Expires: {rentalTime}"
	/// </summary>
	public override string LabelExpiresRentalTime(string rentalTime)
	{
		return $"Expiration\u00a0: {rentalTime}";
	}

	protected override string _GetTemplateForLabelExpiresRentalTime()
	{
		return "Expiration\u00a0: {rentalTime}";
	}

	protected override string _GetTemplateForLabelGooglePlayExclusiveItem()
	{
		return "Il s'agit d'une exclusivité Google Play.";
	}

	protected override string _GetTemplateForLabelIosDeviceExclusiveItem()
	{
		return "Il s'agit d'une exclusivité iOS.";
	}

	protected override string _GetTemplateForLabelItemAvailableInventory()
	{
		return "Cet objet se trouve dans ton inventaire.";
	}

	protected override string _GetTemplateForLabelItemHasBeenModerated()
	{
		return "Cet objet a été modéré.";
	}

	protected override string _GetTemplateForLabelItemNoLongerForSale()
	{
		return "Cet objet n'est plus en vente.";
	}

	protected override string _GetTemplateForLabelItemNotCurrentlyForSale()
	{
		return "Cet objet n'est pas en vente pour l'instant.";
	}

	/// <summary>
	/// Key: "Label.LimitedQuantity"
	/// English String: "Limited quantity: {amount}"
	/// </summary>
	public override string LabelLimitedQuantity(string amount)
	{
		return $"Quantité limitée\u00a0: {amount}";
	}

	protected override string _GetTemplateForLabelLimitedQuantity()
	{
		return "Quantité limitée\u00a0: {amount}";
	}

	public override string LabelMetaDescriptionCatalog(string assetName, string assetTypeLabel)
	{
		return $"Personnalise ton avatar grâce à l'élément {assetName} et des millions d'autres. Associe et mélange l'élément {assetTypeLabel} avec d'autres objets afin de créer un avatar qui t'est propre\u00a0!";
	}

	protected override string _GetTemplateForLabelMetaDescriptionCatalog()
	{
		return "Personnalise ton avatar grâce à l'élément {assetName} et des millions d'autres. Associe et mélange l'élément {assetTypeLabel} avec d'autres objets afin de créer un avatar qui t'est propre\u00a0!";
	}

	/// <summary>
	/// Key: "Label.MetaDescriptionLibrary"
	/// English String: "Use {assetName} and thousands of other {assetTypeLabel} to build an immersive game or experience. Select from a wide range of models, decals, meshes, plugins, or audio that help bring your imagination into reality."
	/// </summary>
	public override string LabelMetaDescriptionLibrary(string assetName, string assetTypeLabel)
	{
		return $"Utilise l'élément {assetName} et des milliers d'autres {assetTypeLabel} pour créer une expérience de jeu immersive. Fais ton choix parmi une vaste gamme de modèles, d'insignes, de formes, de plugins et de sons pour exprimer ta créativité.";
	}

	protected override string _GetTemplateForLabelMetaDescriptionLibrary()
	{
		return "Utilise l'élément {assetName} et des milliers d'autres {assetTypeLabel} pour créer une expérience de jeu immersive. Fais ton choix parmi une vaste gamme de modèles, d'insignes, de formes, de plugins et de sons pour exprimer ta créativité.";
	}

	/// <summary>
	/// Key: "Label.MetaDescriptionLibraryV2"
	/// new text with no asset type
	/// English String: "Use {assetName} and thousands of other assets to build an immersive game or experience. Select from a wide range of models, decals, meshes, plugins, or audio that help bring your imagination into reality."
	/// </summary>
	public override string LabelMetaDescriptionLibraryV2(string assetName)
	{
		return $"Utilise l'élément {assetName} et des milliers d'autres pour créer une expérience de jeu immersive. Fais ton choix parmi une vaste gamme de modèles, d'insignes, de formes, de plugins et de sons pour exprimer ta créativité.";
	}

	protected override string _GetTemplateForLabelMetaDescriptionLibraryV2()
	{
		return "Utilise l'élément {assetName} et des milliers d'autres pour créer une expérience de jeu immersive. Fais ton choix parmi une vaste gamme de modèles, d'insignes, de formes, de plugins et de sons pour exprimer ta créativité.";
	}

	protected override string _GetTemplateForLabelMobileDeviceExclusiveItem()
	{
		return "Il s'agit d'une exclusivité mobile.";
	}

	protected override string _GetTemplateForLabelNoDescriptionAvailable()
	{
		return "Aucune description disponible.";
	}

	protected override string _GetTemplateForLabelNoOneCurrentlySelling()
	{
		return "Personne ne vend actuellement cet objet.";
	}

	protected override string _GetTemplateForLabelNoOtherSellers()
	{
		return "Aucun autre vendeur.";
	}

	protected override string _GetTemplateForLabelNotAvailable()
	{
		return "s.\u00a0o.";
	}

	/// <summary>
	/// Key: "Label.PriceChangedFrom"
	/// English String: "Price changed from {robuxAmount}"
	/// </summary>
	public override string LabelPriceChangedFrom(string robuxAmount)
	{
		return $"Prix changé (anciennement {robuxAmount})";
	}

	protected override string _GetTemplateForLabelPriceChangedFrom()
	{
		return "Prix changé (anciennement {robuxAmount})";
	}

	protected override string _GetTemplateForLabelPurchasingTemporarilyUnavailable()
	{
		return "Les achats sont temporairement indisponibles. Veuillez réessayer plus tard.";
	}

	protected override string _GetTemplateForLabelResellers()
	{
		return "Revendeurs";
	}

	protected override string _GetTemplateForLabelRobloxAsset()
	{
		return "Élément Roblox";
	}

	/// <summary>
	/// Key: "Label.SeeMoreResellers"
	/// English String: "See more {resellers}"
	/// </summary>
	public override string LabelSeeMoreResellers(string resellers)
	{
		return $"Afficher plus de {resellers}";
	}

	protected override string _GetTemplateForLabelSeeMoreResellers()
	{
		return "Afficher plus de {resellers}";
	}

	/// <summary>
	/// Key: "Label.SerialNoOf"
	/// English String: "{serial} of {total}"
	/// </summary>
	public override string LabelSerialNoOf(string serial, string total)
	{
		return $"{serial} sur {total}";
	}

	protected override string _GetTemplateForLabelSerialNoOf()
	{
		return "{serial} sur {total}";
	}

	protected override string _GetTemplateForLabelTakeOff()
	{
		return "Retirer";
	}

	protected override string _GetTemplateForLabelToInstallOpenStudio()
	{
		return "Pour l'installer, ouvrez cette page dans Roblox Studio.";
	}

	protected override string _GetTemplateForLabelWear()
	{
		return "Porter";
	}

	protected override string _GetTemplateForLabelXboxOneExclusiveItem()
	{
		return "Il s'agit d'une exclusivité Xbox One.";
	}

	protected override string _GetTemplateForLabelYouAreSelling()
	{
		return "Vous vendez cet objet.";
	}
}
