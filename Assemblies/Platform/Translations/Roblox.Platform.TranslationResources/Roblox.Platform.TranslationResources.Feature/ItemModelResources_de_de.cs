namespace Roblox.Platform.TranslationResources.Feature {
    /// <summary>

/// This class overrides ItemModelResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class ItemModelResources_de_de : ItemModelResources_en_us, IItemModelResources, ITranslationResources
{
	/// <summary>
	/// Key: "Label.AmazonExclusiveItem"
	/// English String: "This is an Amazon exclusive item."
	/// </summary>
	public override string LabelAmazonExclusiveItem => "Dieser Artikel ist exklusiv auf Amazon erhÃ¤ltlich.";

	/// <summary>
	/// Key: "Label.AudioAssetBlockedCopyright"
	/// English String: "This audio asset has been blocked due to copyright violations.\n"
	/// </summary>
	public override string LabelAudioAssetBlockedCopyright => "Dieses Audio-Objekt wurde aufgrund eines Copyright-VerstoÃŸes gesperrt.\n";

	/// <summary>
	/// Key: "Label.GooglePlayExclusiveItem"
	/// English String: "This is a Google Play exclusive item."
	/// </summary>
	public override string LabelGooglePlayExclusiveItem => "Dieser Artikel ist exklusiv auf Google Play erhÃ¤ltlich.";

	/// <summary>
	/// Key: "Label.IosDeviceExclusiveItem"
	/// English String: "This is an iOS exclusive item."
	/// </summary>
	public override string LabelIosDeviceExclusiveItem => "Dieser Artikel ist exklusiv auf iOS erhÃ¤ltlich.";

	/// <summary>
	/// Key: "Label.ItemAvailableInventory"
	/// English String: "This item is available in your inventory."
	/// </summary>
	public override string LabelItemAvailableInventory => "Dieser Artikel ist in deinem Inventar verfÃ¼gbar.";

	/// <summary>
	/// Key: "Label.ItemHasBeenModerated"
	/// English String: "This item has been moderated."
	/// </summary>
	public override string LabelItemHasBeenModerated => "Dieser Artikel wurde von einem Moderator angepasst.";

	/// <summary>
	/// Key: "Label.ItemNoLongerForSale"
	/// English String: "This item is no longer for sale."
	/// </summary>
	public override string LabelItemNoLongerForSale => "Dieser Artikel steht nicht mehr zum Verkauf.";

	/// <summary>
	/// Key: "Label.ItemNotCurrentlyForSale"
	/// English String: "This item is not currently for sale."
	/// </summary>
	public override string LabelItemNotCurrentlyForSale => "Dieser Artikel steht derzeit nicht zum Verkauf.";

	/// <summary>
	/// Key: "Label.MobileDeviceExclusiveItem"
	/// English String: "This is a mobile exclusive item."
	/// </summary>
	public override string LabelMobileDeviceExclusiveItem => "Dieser Artikel ist exklusiv fÃ¼r MobilgerÃ¤te erhÃ¤ltlich.";

	/// <summary>
	/// Key: "Label.NoDescriptionAvailable"
	/// English String: "No description available."
	/// </summary>
	public override string LabelNoDescriptionAvailable => "Keine Beschreibung verfÃ¼gbar.";

	/// <summary>
	/// Key: "Label.NoOneCurrentlySelling"
	/// English String: "There is no one currently selling this item."
	/// </summary>
	public override string LabelNoOneCurrentlySelling => "Derzeit verkauft niemand diesen Artikel.";

	/// <summary>
	/// Key: "Label.NoOtherSellers"
	/// English String: "No other sellers."
	/// </summary>
	public override string LabelNoOtherSellers => "Keine weiteren Anbieter.";

	/// <summary>
	/// Key: "Label.NotAvailable"
	/// English String: "N/A"
	/// </summary>
	public override string LabelNotAvailable => "Nicht verfÃ¼gbar";

	/// <summary>
	/// Key: "Label.PurchasingTemporarilyUnavailable"
	/// English String: "Purchasing is temporarily unavailable. Please try again later."
	/// </summary>
	public override string LabelPurchasingTemporarilyUnavailable => "KÃ¤ufe sind derzeit nicht verfÃ¼gbar. Bitte versuche es spÃ¤ter erneut.";

	/// <summary>
	/// Key: "Label.Resellers"
	/// English String: "Resellers"
	/// </summary>
	public override string LabelResellers => "WiederverkÃ¤ufer";

	/// <summary>
	/// Key: "Label.RobloxAsset"
	/// English String: "Roblox Asset"
	/// </summary>
	public override string LabelRobloxAsset => "Roblox-Objekt";

	/// <summary>
	/// Key: "Label.TakeOff"
	/// English String: "Take Off"
	/// </summary>
	public override string LabelTakeOff => "Ablegen";

	/// <summary>
	/// Key: "Label.ToInstallOpenStudio"
	/// English String: "To install, open this page in Roblox Studio."
	/// </summary>
	public override string LabelToInstallOpenStudio => "Zum Installieren musst du diese Seite in Roblox Studio Ã¶ffnen.";

	/// <summary>
	/// Key: "Label.Wear"
	/// English String: "Wear"
	/// </summary>
	public override string LabelWear => "Tragen";

	/// <summary>
	/// Key: "Label.XboxOneExclusiveItem"
	/// English String: "This is a Xbox One exclusive item."
	/// </summary>
	public override string LabelXboxOneExclusiveItem => "Dieser Artikel ist exklusiv fÃ¼r Xbox One erhÃ¤ltlich.";

	/// <summary>
	/// Key: "Label.YouAreSelling"
	/// English String: "You are selling this item."
	/// </summary>
	public override string LabelYouAreSelling => "Du verkaufst diesen Artikel.";

	public ItemModelResources_de_de(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForLabelAmazonExclusiveItem()
	{
		return "Dieser Artikel ist exklusiv auf Amazon erhÃ¤ltlich.";
	}

	/// <summary>
	/// Key: "Label.AssetName"
	/// English String: "{assetName} - Roblox"
	/// </summary>
	public override string LabelAssetName(string assetName)
	{
		return $"{assetName}\u00a0â€“ Roblox";
	}

	protected override string _GetTemplateForLabelAssetName()
	{
		return "{assetName}\u00a0â€“ Roblox";
	}

	/// <summary>
	/// Key: "Label.AssetOptionRental"
	/// English String: "{assetOption} Rental"
	/// </summary>
	public override string LabelAssetOptionRental(string assetOption)
	{
		return $"{assetOption} zur Miete";
	}

	protected override string _GetTemplateForLabelAssetOptionRental()
	{
		return "{assetOption} zur Miete";
	}

	protected override string _GetTemplateForLabelAudioAssetBlockedCopyright()
	{
		return "Dieses Audio-Objekt wurde aufgrund eines Copyright-VerstoÃŸes gesperrt.\n";
	}

	/// <summary>
	/// Key: "Label.BcRequirementExclusiveItem"
	/// English String: "{bcRequirementName} exclusive item."
	/// </summary>
	public override string LabelBcRequirementExclusiveItem(string bcRequirementName)
	{
		return $"Exklusiver Artikel fÃ¼r {bcRequirementName}.";
	}

	protected override string _GetTemplateForLabelBcRequirementExclusiveItem()
	{
		return "Exklusiver Artikel fÃ¼r {bcRequirementName}.";
	}

	/// <summary>
	/// Key: "Label.ExpiresRentalTime"
	/// English String: "Expires: {rentalTime}"
	/// </summary>
	public override string LabelExpiresRentalTime(string rentalTime)
	{
		return $"LÃ¤uft ab: {rentalTime}";
	}

	protected override string _GetTemplateForLabelExpiresRentalTime()
	{
		return "LÃ¤uft ab: {rentalTime}";
	}

	protected override string _GetTemplateForLabelGooglePlayExclusiveItem()
	{
		return "Dieser Artikel ist exklusiv auf Google Play erhÃ¤ltlich.";
	}

	protected override string _GetTemplateForLabelIosDeviceExclusiveItem()
	{
		return "Dieser Artikel ist exklusiv auf iOS erhÃ¤ltlich.";
	}

	protected override string _GetTemplateForLabelItemAvailableInventory()
	{
		return "Dieser Artikel ist in deinem Inventar verfÃ¼gbar.";
	}

	protected override string _GetTemplateForLabelItemHasBeenModerated()
	{
		return "Dieser Artikel wurde von einem Moderator angepasst.";
	}

	protected override string _GetTemplateForLabelItemNoLongerForSale()
	{
		return "Dieser Artikel steht nicht mehr zum Verkauf.";
	}

	protected override string _GetTemplateForLabelItemNotCurrentlyForSale()
	{
		return "Dieser Artikel steht derzeit nicht zum Verkauf.";
	}

	/// <summary>
	/// Key: "Label.LimitedQuantity"
	/// English String: "Limited quantity: {amount}"
	/// </summary>
	public override string LabelLimitedQuantity(string amount)
	{
		return $"Limitierte Anzahl: {amount}";
	}

	protected override string _GetTemplateForLabelLimitedQuantity()
	{
		return "Limitierte Anzahl: {amount}";
	}

	public override string LabelMetaDescriptionCatalog(string assetName, string assetTypeLabel)
	{
		return $"Passe deinen Avatar mit â€ž{assetName}â€œ und Millionen anderer Artikel an. Kombiniere â€ž{assetTypeLabel}â€œ mit anderen Artikeln, um deinen ganz eigenen Avatar zu erschaffen!";
	}

	protected override string _GetTemplateForLabelMetaDescriptionCatalog()
	{
		return "Passe deinen Avatar mit â€ž{assetName}â€œ und Millionen anderer Artikel an. Kombiniere â€ž{assetTypeLabel}â€œ mit anderen Artikeln, um deinen ganz eigenen Avatar zu erschaffen!";
	}

	/// <summary>
	/// Key: "Label.MetaDescriptionLibrary"
	/// English String: "Use {assetName} and thousands of other {assetTypeLabel} to build an immersive game or experience. Select from a wide range of models, decals, meshes, plugins, or audio that help bring your imagination into reality."
	/// </summary>
	public override string LabelMetaDescriptionLibrary(string assetName, string assetTypeLabel)
	{
		return $"Verwende â€ž{assetName}â€œ und Tausende andere â€ž{assetTypeLabel}â€œ, um ein fesselndes Spiel oder Erlebnis zu erschaffen. WÃ¤hle aus einer enormen Auswahl an Modellen, Decals, Meshes, Plug-ins oder Audiodateien, um deine Vorstellungen zu verwirklichen.";
	}

	protected override string _GetTemplateForLabelMetaDescriptionLibrary()
	{
		return "Verwende â€ž{assetName}â€œ und Tausende andere â€ž{assetTypeLabel}â€œ, um ein fesselndes Spiel oder Erlebnis zu erschaffen. WÃ¤hle aus einer enormen Auswahl an Modellen, Decals, Meshes, Plug-ins oder Audiodateien, um deine Vorstellungen zu verwirklichen.";
	}

	/// <summary>
	/// Key: "Label.MetaDescriptionLibraryV2"
	/// new text with no asset type
	/// English String: "Use {assetName} and thousands of other assets to build an immersive game or experience. Select from a wide range of models, decals, meshes, plugins, or audio that help bring your imagination into reality."
	/// </summary>
	public override string LabelMetaDescriptionLibraryV2(string assetName)
	{
		return $"Verwende {assetName} und Tausende andere Objekte, um ein fesselndes Spiel oder Erlebnis zu erschaffen. WÃ¤hle aus einer enormen Auswahl an Modellen, Decals, Meshes, Plug-ins oder Audiodateien, um deine Vorstellungen zu verwirklichen.";
	}

	protected override string _GetTemplateForLabelMetaDescriptionLibraryV2()
	{
		return "Verwende {assetName} und Tausende andere Objekte, um ein fesselndes Spiel oder Erlebnis zu erschaffen. WÃ¤hle aus einer enormen Auswahl an Modellen, Decals, Meshes, Plug-ins oder Audiodateien, um deine Vorstellungen zu verwirklichen.";
	}

	protected override string _GetTemplateForLabelMobileDeviceExclusiveItem()
	{
		return "Dieser Artikel ist exklusiv fÃ¼r MobilgerÃ¤te erhÃ¤ltlich.";
	}

	protected override string _GetTemplateForLabelNoDescriptionAvailable()
	{
		return "Keine Beschreibung verfÃ¼gbar.";
	}

	protected override string _GetTemplateForLabelNoOneCurrentlySelling()
	{
		return "Derzeit verkauft niemand diesen Artikel.";
	}

	protected override string _GetTemplateForLabelNoOtherSellers()
	{
		return "Keine weiteren Anbieter.";
	}

	protected override string _GetTemplateForLabelNotAvailable()
	{
		return "Nicht verfÃ¼gbar";
	}

	/// <summary>
	/// Key: "Label.PriceChangedFrom"
	/// English String: "Price changed from {robuxAmount}"
	/// </summary>
	public override string LabelPriceChangedFrom(string robuxAmount)
	{
		return $"Vorheriger Preis: {robuxAmount}";
	}

	protected override string _GetTemplateForLabelPriceChangedFrom()
	{
		return "Vorheriger Preis: {robuxAmount}";
	}

	protected override string _GetTemplateForLabelPurchasingTemporarilyUnavailable()
	{
		return "KÃ¤ufe sind derzeit nicht verfÃ¼gbar. Bitte versuche es spÃ¤ter erneut.";
	}

	protected override string _GetTemplateForLabelResellers()
	{
		return "WiederverkÃ¤ufer";
	}

	protected override string _GetTemplateForLabelRobloxAsset()
	{
		return "Roblox-Objekt";
	}

	/// <summary>
	/// Key: "Label.SeeMoreResellers"
	/// English String: "See more {resellers}"
	/// </summary>
	public override string LabelSeeMoreResellers(string resellers)
	{
		return $"Mehr {resellers} ansehen";
	}

	protected override string _GetTemplateForLabelSeeMoreResellers()
	{
		return "Mehr {resellers} ansehen";
	}

	/// <summary>
	/// Key: "Label.SerialNoOf"
	/// English String: "{serial} of {total}"
	/// </summary>
	public override string LabelSerialNoOf(string serial, string total)
	{
		return $"{serial}\u00a0von {total}";
	}

	protected override string _GetTemplateForLabelSerialNoOf()
	{
		return "{serial}\u00a0von {total}";
	}

	protected override string _GetTemplateForLabelTakeOff()
	{
		return "Ablegen";
	}

	protected override string _GetTemplateForLabelToInstallOpenStudio()
	{
		return "Zum Installieren musst du diese Seite in Roblox Studio Ã¶ffnen.";
	}

	protected override string _GetTemplateForLabelWear()
	{
		return "Tragen";
	}

	protected override string _GetTemplateForLabelXboxOneExclusiveItem()
	{
		return "Dieser Artikel ist exklusiv fÃ¼r Xbox One erhÃ¤ltlich.";
	}

	protected override string _GetTemplateForLabelYouAreSelling()
	{
		return "Du verkaufst diesen Artikel.";
	}
}


}
