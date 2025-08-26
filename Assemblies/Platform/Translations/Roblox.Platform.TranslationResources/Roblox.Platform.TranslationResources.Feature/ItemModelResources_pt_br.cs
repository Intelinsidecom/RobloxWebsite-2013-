namespace Roblox.Platform.TranslationResources.Feature {
    /// <summary>

/// This class overrides ItemModelResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class ItemModelResources_pt_br : ItemModelResources_en_us, IItemModelResources, ITranslationResources
{
	/// <summary>
	/// Key: "Label.AmazonExclusiveItem"
	/// English String: "This is an Amazon exclusive item."
	/// </summary>
	public override string LabelAmazonExclusiveItem => "Este Ã© um item exclusivo da Amazon.";

	/// <summary>
	/// Key: "Label.AudioAssetBlockedCopyright"
	/// English String: "This audio asset has been blocked due to copyright violations.\n"
	/// </summary>
	public override string LabelAudioAssetBlockedCopyright => "Este elemento de Ã¡udio foi bloqueado devido a violaÃ§Ãµes de direito autoral.\n";

	/// <summary>
	/// Key: "Label.GooglePlayExclusiveItem"
	/// English String: "This is a Google Play exclusive item."
	/// </summary>
	public override string LabelGooglePlayExclusiveItem => "Este Ã© um item exclusivo do Google Play.";

	/// <summary>
	/// Key: "Label.IosDeviceExclusiveItem"
	/// English String: "This is an iOS exclusive item."
	/// </summary>
	public override string LabelIosDeviceExclusiveItem => "Este Ã© um item exclusivo do iOS.";

	/// <summary>
	/// Key: "Label.ItemAvailableInventory"
	/// English String: "This item is available in your inventory."
	/// </summary>
	public override string LabelItemAvailableInventory => "Este item estÃ¡ disponÃ­vel no seu inventÃ¡rio.";

	/// <summary>
	/// Key: "Label.ItemHasBeenModerated"
	/// English String: "This item has been moderated."
	/// </summary>
	public override string LabelItemHasBeenModerated => "O item foi moderado.";

	/// <summary>
	/// Key: "Label.ItemNoLongerForSale"
	/// English String: "This item is no longer for sale."
	/// </summary>
	public override string LabelItemNoLongerForSale => "Este item nÃ£o estÃ¡ mais Ã  venda.";

	/// <summary>
	/// Key: "Label.ItemNotCurrentlyForSale"
	/// English String: "This item is not currently for sale."
	/// </summary>
	public override string LabelItemNotCurrentlyForSale => "Este item nÃ£o estÃ¡ Ã  venda no momento.";

	/// <summary>
	/// Key: "Label.MobileDeviceExclusiveItem"
	/// English String: "This is a mobile exclusive item."
	/// </summary>
	public override string LabelMobileDeviceExclusiveItem => "Este Ã© um item exclusivo para dispositivos mÃ³veis.";

	/// <summary>
	/// Key: "Label.NoDescriptionAvailable"
	/// English String: "No description available."
	/// </summary>
	public override string LabelNoDescriptionAvailable => "DescriÃ§Ã£o nÃ£o disponÃ­vel.";

	/// <summary>
	/// Key: "Label.NoOneCurrentlySelling"
	/// English String: "There is no one currently selling this item."
	/// </summary>
	public override string LabelNoOneCurrentlySelling => "NinguÃ©m estÃ¡ vendendo este item no momento.";

	/// <summary>
	/// Key: "Label.NoOtherSellers"
	/// English String: "No other sellers."
	/// </summary>
	public override string LabelNoOtherSellers => "Nenhum outro vendedor.";

	/// <summary>
	/// Key: "Label.NotAvailable"
	/// English String: "N/A"
	/// </summary>
	public override string LabelNotAvailable => "N/A";

	/// <summary>
	/// Key: "Label.PurchasingTemporarilyUnavailable"
	/// English String: "Purchasing is temporarily unavailable. Please try again later."
	/// </summary>
	public override string LabelPurchasingTemporarilyUnavailable => "Compra nÃ£o disponÃ­vel temporariamente. Tente novamente mais tarde.";

	/// <summary>
	/// Key: "Label.Resellers"
	/// English String: "Resellers"
	/// </summary>
	public override string LabelResellers => "Revendedores";

	/// <summary>
	/// Key: "Label.RobloxAsset"
	/// English String: "Roblox Asset"
	/// </summary>
	public override string LabelRobloxAsset => "Elemento Roblox";

	/// <summary>
	/// Key: "Label.TakeOff"
	/// English String: "Take Off"
	/// </summary>
	public override string LabelTakeOff => "Remover";

	/// <summary>
	/// Key: "Label.ToInstallOpenStudio"
	/// English String: "To install, open this page in Roblox Studio."
	/// </summary>
	public override string LabelToInstallOpenStudio => "Para instalar, abra esta pÃ¡gina no Roblox Studio.";

	/// <summary>
	/// Key: "Label.Wear"
	/// English String: "Wear"
	/// </summary>
	public override string LabelWear => "Usar";

	/// <summary>
	/// Key: "Label.XboxOneExclusiveItem"
	/// English String: "This is a Xbox One exclusive item."
	/// </summary>
	public override string LabelXboxOneExclusiveItem => "Este Ã© um item exclusivo do Xbox One.";

	/// <summary>
	/// Key: "Label.YouAreSelling"
	/// English String: "You are selling this item."
	/// </summary>
	public override string LabelYouAreSelling => "VocÃª estÃ¡ vendendo este item.";

	public ItemModelResources_pt_br(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForLabelAmazonExclusiveItem()
	{
		return "Este Ã© um item exclusivo da Amazon.";
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
		return $"Aluguel de {assetOption}";
	}

	protected override string _GetTemplateForLabelAssetOptionRental()
	{
		return "Aluguel de {assetOption}";
	}

	protected override string _GetTemplateForLabelAudioAssetBlockedCopyright()
	{
		return "Este elemento de Ã¡udio foi bloqueado devido a violaÃ§Ãµes de direito autoral.\n";
	}

	/// <summary>
	/// Key: "Label.BcRequirementExclusiveItem"
	/// English String: "{bcRequirementName} exclusive item."
	/// </summary>
	public override string LabelBcRequirementExclusiveItem(string bcRequirementName)
	{
		return $"Item exclusivo de {bcRequirementName}.";
	}

	protected override string _GetTemplateForLabelBcRequirementExclusiveItem()
	{
		return "Item exclusivo de {bcRequirementName}.";
	}

	/// <summary>
	/// Key: "Label.ExpiresRentalTime"
	/// English String: "Expires: {rentalTime}"
	/// </summary>
	public override string LabelExpiresRentalTime(string rentalTime)
	{
		return $"Expira: {rentalTime}";
	}

	protected override string _GetTemplateForLabelExpiresRentalTime()
	{
		return "Expira: {rentalTime}";
	}

	protected override string _GetTemplateForLabelGooglePlayExclusiveItem()
	{
		return "Este Ã© um item exclusivo do Google Play.";
	}

	protected override string _GetTemplateForLabelIosDeviceExclusiveItem()
	{
		return "Este Ã© um item exclusivo do iOS.";
	}

	protected override string _GetTemplateForLabelItemAvailableInventory()
	{
		return "Este item estÃ¡ disponÃ­vel no seu inventÃ¡rio.";
	}

	protected override string _GetTemplateForLabelItemHasBeenModerated()
	{
		return "O item foi moderado.";
	}

	protected override string _GetTemplateForLabelItemNoLongerForSale()
	{
		return "Este item nÃ£o estÃ¡ mais Ã  venda.";
	}

	protected override string _GetTemplateForLabelItemNotCurrentlyForSale()
	{
		return "Este item nÃ£o estÃ¡ Ã  venda no momento.";
	}

	/// <summary>
	/// Key: "Label.LimitedQuantity"
	/// English String: "Limited quantity: {amount}"
	/// </summary>
	public override string LabelLimitedQuantity(string amount)
	{
		return $"Quantidade limitada: {amount}";
	}

	protected override string _GetTemplateForLabelLimitedQuantity()
	{
		return "Quantidade limitada: {amount}";
	}

	public override string LabelMetaDescriptionCatalog(string assetName, string assetTypeLabel)
	{
		return $"Personalize seu avatar com {assetName} e milhÃµes de outros itens. Combine {assetTypeLabel} com outros itens para criar um avatar Ãºnico!";
	}

	protected override string _GetTemplateForLabelMetaDescriptionCatalog()
	{
		return "Personalize seu avatar com {assetName} e milhÃµes de outros itens. Combine {assetTypeLabel} com outros itens para criar um avatar Ãºnico!";
	}

	/// <summary>
	/// Key: "Label.MetaDescriptionLibrary"
	/// English String: "Use {assetName} and thousands of other {assetTypeLabel} to build an immersive game or experience. Select from a wide range of models, decals, meshes, plugins, or audio that help bring your imagination into reality."
	/// </summary>
	public override string LabelMetaDescriptionLibrary(string assetName, string assetTypeLabel)
	{
		return $"Use {assetName} e milhares de outros itens do tipo {assetTypeLabel} para construir uma experiÃªncia de jogo imersiva. Selecione dentre uma vasta gama de modelos, adesivos, malhas, plugins ou Ã¡udio que o ajudarÃ£o a tornar sua imaginaÃ§Ã£o realidade.";
	}

	protected override string _GetTemplateForLabelMetaDescriptionLibrary()
	{
		return "Use {assetName} e milhares de outros itens do tipo {assetTypeLabel} para construir uma experiÃªncia de jogo imersiva. Selecione dentre uma vasta gama de modelos, adesivos, malhas, plugins ou Ã¡udio que o ajudarÃ£o a tornar sua imaginaÃ§Ã£o realidade.";
	}

	/// <summary>
	/// Key: "Label.MetaDescriptionLibraryV2"
	/// new text with no asset type
	/// English String: "Use {assetName} and thousands of other assets to build an immersive game or experience. Select from a wide range of models, decals, meshes, plugins, or audio that help bring your imagination into reality."
	/// </summary>
	public override string LabelMetaDescriptionLibraryV2(string assetName)
	{
		return $"Use {assetName} e milhares de outros recursos para construir um jogo ou uma experiÃªncia imersiva. Selecione dentre uma grande variedade de modelos, adesivos, malhas, plugins ou Ã¡udio que o ajudarÃ£o a transformar sua imaginaÃ§Ã£o em realidade.";
	}

	protected override string _GetTemplateForLabelMetaDescriptionLibraryV2()
	{
		return "Use {assetName} e milhares de outros recursos para construir um jogo ou uma experiÃªncia imersiva. Selecione dentre uma grande variedade de modelos, adesivos, malhas, plugins ou Ã¡udio que o ajudarÃ£o a transformar sua imaginaÃ§Ã£o em realidade.";
	}

	protected override string _GetTemplateForLabelMobileDeviceExclusiveItem()
	{
		return "Este Ã© um item exclusivo para dispositivos mÃ³veis.";
	}

	protected override string _GetTemplateForLabelNoDescriptionAvailable()
	{
		return "DescriÃ§Ã£o nÃ£o disponÃ­vel.";
	}

	protected override string _GetTemplateForLabelNoOneCurrentlySelling()
	{
		return "NinguÃ©m estÃ¡ vendendo este item no momento.";
	}

	protected override string _GetTemplateForLabelNoOtherSellers()
	{
		return "Nenhum outro vendedor.";
	}

	protected override string _GetTemplateForLabelNotAvailable()
	{
		return "N/A";
	}

	/// <summary>
	/// Key: "Label.PriceChangedFrom"
	/// English String: "Price changed from {robuxAmount}"
	/// </summary>
	public override string LabelPriceChangedFrom(string robuxAmount)
	{
		return $"O preÃ§o mudou de {robuxAmount}";
	}

	protected override string _GetTemplateForLabelPriceChangedFrom()
	{
		return "O preÃ§o mudou de {robuxAmount}";
	}

	protected override string _GetTemplateForLabelPurchasingTemporarilyUnavailable()
	{
		return "Compra nÃ£o disponÃ­vel temporariamente. Tente novamente mais tarde.";
	}

	protected override string _GetTemplateForLabelResellers()
	{
		return "Revendedores";
	}

	protected override string _GetTemplateForLabelRobloxAsset()
	{
		return "Elemento Roblox";
	}

	/// <summary>
	/// Key: "Label.SeeMoreResellers"
	/// English String: "See more {resellers}"
	/// </summary>
	public override string LabelSeeMoreResellers(string resellers)
	{
		return $"Ver mais {resellers}";
	}

	protected override string _GetTemplateForLabelSeeMoreResellers()
	{
		return "Ver mais {resellers}";
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
		return "Remover";
	}

	protected override string _GetTemplateForLabelToInstallOpenStudio()
	{
		return "Para instalar, abra esta pÃ¡gina no Roblox Studio.";
	}

	protected override string _GetTemplateForLabelWear()
	{
		return "Usar";
	}

	protected override string _GetTemplateForLabelXboxOneExclusiveItem()
	{
		return "Este Ã© um item exclusivo do Xbox One.";
	}

	protected override string _GetTemplateForLabelYouAreSelling()
	{
		return "VocÃª estÃ¡ vendendo este item.";
	}
}


}
