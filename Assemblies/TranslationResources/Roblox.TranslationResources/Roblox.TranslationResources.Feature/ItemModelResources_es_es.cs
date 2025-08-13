namespace Roblox.TranslationResources.Feature;

/// <summary>
/// This class overrides ItemModelResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class ItemModelResources_es_es : ItemModelResources_en_us, IItemModelResources, ITranslationResources
{
	/// <summary>
	/// Key: "Label.AmazonExclusiveItem"
	/// English String: "This is an Amazon exclusive item."
	/// </summary>
	public override string LabelAmazonExclusiveItem => "Este es un objeto exclusivo de Amazon.";

	/// <summary>
	/// Key: "Label.AudioAssetBlockedCopyright"
	/// English String: "This audio asset has been blocked due to copyright violations.\n"
	/// </summary>
	public override string LabelAudioAssetBlockedCopyright => "Este recurso de audio ha sido bloqueado porque infringe los derechos de autor.";

	/// <summary>
	/// Key: "Label.GooglePlayExclusiveItem"
	/// English String: "This is a Google Play exclusive item."
	/// </summary>
	public override string LabelGooglePlayExclusiveItem => "Este es un objeto exclusivo de Google Play.";

	/// <summary>
	/// Key: "Label.IosDeviceExclusiveItem"
	/// English String: "This is an iOS exclusive item."
	/// </summary>
	public override string LabelIosDeviceExclusiveItem => "Este es un objeto exclusivo de iOS.";

	/// <summary>
	/// Key: "Label.ItemAvailableInventory"
	/// English String: "This item is available in your inventory."
	/// </summary>
	public override string LabelItemAvailableInventory => "Este objeto está disponible en tu inventario.";

	/// <summary>
	/// Key: "Label.ItemHasBeenModerated"
	/// English String: "This item has been moderated."
	/// </summary>
	public override string LabelItemHasBeenModerated => "Este objeto ha sido moderado.";

	/// <summary>
	/// Key: "Label.ItemNoLongerForSale"
	/// English String: "This item is no longer for sale."
	/// </summary>
	public override string LabelItemNoLongerForSale => "Este objeto ya no está en venta.";

	/// <summary>
	/// Key: "Label.ItemNotCurrentlyForSale"
	/// English String: "This item is not currently for sale."
	/// </summary>
	public override string LabelItemNotCurrentlyForSale => "Este objeto no está en venta en este momento.";

	/// <summary>
	/// Key: "Label.MobileDeviceExclusiveItem"
	/// English String: "This is a mobile exclusive item."
	/// </summary>
	public override string LabelMobileDeviceExclusiveItem => "Este es un objeto exclusivo en móviles.";

	/// <summary>
	/// Key: "Label.NoDescriptionAvailable"
	/// English String: "No description available."
	/// </summary>
	public override string LabelNoDescriptionAvailable => "Sin descripción disponible.";

	/// <summary>
	/// Key: "Label.NoOneCurrentlySelling"
	/// English String: "There is no one currently selling this item."
	/// </summary>
	public override string LabelNoOneCurrentlySelling => "En este momento no hay nadie que venda este objeto.";

	/// <summary>
	/// Key: "Label.NoOtherSellers"
	/// English String: "No other sellers."
	/// </summary>
	public override string LabelNoOtherSellers => "No hay otros vendedores.";

	/// <summary>
	/// Key: "Label.NotAvailable"
	/// English String: "N/A"
	/// </summary>
	public override string LabelNotAvailable => "No disponible";

	/// <summary>
	/// Key: "Label.PurchasingTemporarilyUnavailable"
	/// English String: "Purchasing is temporarily unavailable. Please try again later."
	/// </summary>
	public override string LabelPurchasingTemporarilyUnavailable => "Las compras no están disponibles temporalmente. Inténtalo de nuevo más tarde.";

	/// <summary>
	/// Key: "Label.Resellers"
	/// English String: "Resellers"
	/// </summary>
	public override string LabelResellers => "Revendedores";

	/// <summary>
	/// Key: "Label.RobloxAsset"
	/// English String: "Roblox Asset"
	/// </summary>
	public override string LabelRobloxAsset => "Recurso de Roblox";

	/// <summary>
	/// Key: "Label.TakeOff"
	/// English String: "Take Off"
	/// </summary>
	public override string LabelTakeOff => "Quitar";

	/// <summary>
	/// Key: "Label.ToInstallOpenStudio"
	/// English String: "To install, open this page in Roblox Studio."
	/// </summary>
	public override string LabelToInstallOpenStudio => "Para instalarlo, abre esta página en Roblox Studio.";

	/// <summary>
	/// Key: "Label.Wear"
	/// English String: "Wear"
	/// </summary>
	public override string LabelWear => "Poner";

	/// <summary>
	/// Key: "Label.XboxOneExclusiveItem"
	/// English String: "This is a Xbox One exclusive item."
	/// </summary>
	public override string LabelXboxOneExclusiveItem => "Este es un objeto exclusivo de Xbox One.";

	/// <summary>
	/// Key: "Label.YouAreSelling"
	/// English String: "You are selling this item."
	/// </summary>
	public override string LabelYouAreSelling => "Tú vendes este objeto.";

	public ItemModelResources_es_es(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForLabelAmazonExclusiveItem()
	{
		return "Este es un objeto exclusivo de Amazon.";
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
		return $"Alquiler de {assetOption}";
	}

	protected override string _GetTemplateForLabelAssetOptionRental()
	{
		return "Alquiler de {assetOption}";
	}

	protected override string _GetTemplateForLabelAudioAssetBlockedCopyright()
	{
		return "Este recurso de audio ha sido bloqueado porque infringe los derechos de autor.";
	}

	/// <summary>
	/// Key: "Label.BcRequirementExclusiveItem"
	/// English String: "{bcRequirementName} exclusive item."
	/// </summary>
	public override string LabelBcRequirementExclusiveItem(string bcRequirementName)
	{
		return $"Objeto exclusivo para {bcRequirementName}.";
	}

	protected override string _GetTemplateForLabelBcRequirementExclusiveItem()
	{
		return "Objeto exclusivo para {bcRequirementName}.";
	}

	/// <summary>
	/// Key: "Label.ExpiresRentalTime"
	/// English String: "Expires: {rentalTime}"
	/// </summary>
	public override string LabelExpiresRentalTime(string rentalTime)
	{
		return $"Caducidad: {rentalTime}";
	}

	protected override string _GetTemplateForLabelExpiresRentalTime()
	{
		return "Caducidad: {rentalTime}";
	}

	protected override string _GetTemplateForLabelGooglePlayExclusiveItem()
	{
		return "Este es un objeto exclusivo de Google Play.";
	}

	protected override string _GetTemplateForLabelIosDeviceExclusiveItem()
	{
		return "Este es un objeto exclusivo de iOS.";
	}

	protected override string _GetTemplateForLabelItemAvailableInventory()
	{
		return "Este objeto está disponible en tu inventario.";
	}

	protected override string _GetTemplateForLabelItemHasBeenModerated()
	{
		return "Este objeto ha sido moderado.";
	}

	protected override string _GetTemplateForLabelItemNoLongerForSale()
	{
		return "Este objeto ya no está en venta.";
	}

	protected override string _GetTemplateForLabelItemNotCurrentlyForSale()
	{
		return "Este objeto no está en venta en este momento.";
	}

	/// <summary>
	/// Key: "Label.LimitedQuantity"
	/// English String: "Limited quantity: {amount}"
	/// </summary>
	public override string LabelLimitedQuantity(string amount)
	{
		return $"Cantidad limitada: {amount}";
	}

	protected override string _GetTemplateForLabelLimitedQuantity()
	{
		return "Cantidad limitada: {amount}";
	}

	public override string LabelMetaDescriptionCatalog(string assetName, string assetTypeLabel)
	{
		return $"Personaliza tu avatar con el objeto {assetName} y millones de objetos más. ¡Mezcla y conjunta este objeto de la clase {assetTypeLabel} con otros objetos para crear un avatar exclusivamente tuyo!";
	}

	protected override string _GetTemplateForLabelMetaDescriptionCatalog()
	{
		return "Personaliza tu avatar con el objeto {assetName} y millones de objetos más. ¡Mezcla y conjunta este objeto de la clase {assetTypeLabel} con otros objetos para crear un avatar exclusivamente tuyo!";
	}

	/// <summary>
	/// Key: "Label.MetaDescriptionLibrary"
	/// English String: "Use {assetName} and thousands of other {assetTypeLabel} to build an immersive game or experience. Select from a wide range of models, decals, meshes, plugins, or audio that help bring your imagination into reality."
	/// </summary>
	public override string LabelMetaDescriptionLibrary(string assetName, string assetTypeLabel)
	{
		return $"Usa el objeto {assetName} y miles de otros objetos de la clase {assetTypeLabel} para construir un juego o una experiencia inmersivos. Elige entre un amplio abanico de modelos, adhesivos, mallas, complementos o sonidos que ayudarán a convertir en realidad todo lo que imagines.";
	}

	protected override string _GetTemplateForLabelMetaDescriptionLibrary()
	{
		return "Usa el objeto {assetName} y miles de otros objetos de la clase {assetTypeLabel} para construir un juego o una experiencia inmersivos. Elige entre un amplio abanico de modelos, adhesivos, mallas, complementos o sonidos que ayudarán a convertir en realidad todo lo que imagines.";
	}

	/// <summary>
	/// Key: "Label.MetaDescriptionLibraryV2"
	/// new text with no asset type
	/// English String: "Use {assetName} and thousands of other assets to build an immersive game or experience. Select from a wide range of models, decals, meshes, plugins, or audio that help bring your imagination into reality."
	/// </summary>
	public override string LabelMetaDescriptionLibraryV2(string assetName)
	{
		return $"Usa el objeto {assetName} y miles de otros recursos para construir un juego o una experiencia inmersivos. Elige entre un amplio abanico de modelos, adhesivos, mallas, complementos o sonidos que ayudarán a convertir en realidad todo lo que imagines.";
	}

	protected override string _GetTemplateForLabelMetaDescriptionLibraryV2()
	{
		return "Usa el objeto {assetName} y miles de otros recursos para construir un juego o una experiencia inmersivos. Elige entre un amplio abanico de modelos, adhesivos, mallas, complementos o sonidos que ayudarán a convertir en realidad todo lo que imagines.";
	}

	protected override string _GetTemplateForLabelMobileDeviceExclusiveItem()
	{
		return "Este es un objeto exclusivo en móviles.";
	}

	protected override string _GetTemplateForLabelNoDescriptionAvailable()
	{
		return "Sin descripción disponible.";
	}

	protected override string _GetTemplateForLabelNoOneCurrentlySelling()
	{
		return "En este momento no hay nadie que venda este objeto.";
	}

	protected override string _GetTemplateForLabelNoOtherSellers()
	{
		return "No hay otros vendedores.";
	}

	protected override string _GetTemplateForLabelNotAvailable()
	{
		return "No disponible";
	}

	/// <summary>
	/// Key: "Label.PriceChangedFrom"
	/// English String: "Price changed from {robuxAmount}"
	/// </summary>
	public override string LabelPriceChangedFrom(string robuxAmount)
	{
		return $"El precio de {robuxAmount} ha cambiado.";
	}

	protected override string _GetTemplateForLabelPriceChangedFrom()
	{
		return "El precio de {robuxAmount} ha cambiado.";
	}

	protected override string _GetTemplateForLabelPurchasingTemporarilyUnavailable()
	{
		return "Las compras no están disponibles temporalmente. Inténtalo de nuevo más tarde.";
	}

	protected override string _GetTemplateForLabelResellers()
	{
		return "Revendedores";
	}

	protected override string _GetTemplateForLabelRobloxAsset()
	{
		return "Recurso de Roblox";
	}

	/// <summary>
	/// Key: "Label.SeeMoreResellers"
	/// English String: "See more {resellers}"
	/// </summary>
	public override string LabelSeeMoreResellers(string resellers)
	{
		return $"Ver más {resellers}";
	}

	protected override string _GetTemplateForLabelSeeMoreResellers()
	{
		return "Ver más {resellers}";
	}

	/// <summary>
	/// Key: "Label.SerialNoOf"
	/// English String: "{serial} of {total}"
	/// </summary>
	public override string LabelSerialNoOf(string serial, string total)
	{
		return $"{serial} de {total}";
	}

	protected override string _GetTemplateForLabelSerialNoOf()
	{
		return "{serial} de {total}";
	}

	protected override string _GetTemplateForLabelTakeOff()
	{
		return "Quitar";
	}

	protected override string _GetTemplateForLabelToInstallOpenStudio()
	{
		return "Para instalarlo, abre esta página en Roblox Studio.";
	}

	protected override string _GetTemplateForLabelWear()
	{
		return "Poner";
	}

	protected override string _GetTemplateForLabelXboxOneExclusiveItem()
	{
		return "Este es un objeto exclusivo de Xbox One.";
	}

	protected override string _GetTemplateForLabelYouAreSelling()
	{
		return "Tú vendes este objeto.";
	}
}
