namespace Roblox.TranslationResources.Feature;

/// <summary>
/// This class overrides ItemModelResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class ItemModelResources_zh_tw : ItemModelResources_en_us, IItemModelResources, ITranslationResources
{
	/// <summary>
	/// Key: "Label.AmazonExclusiveItem"
	/// English String: "This is an Amazon exclusive item."
	/// </summary>
	public override string LabelAmazonExclusiveItem => "此為 Amazon 限定道具。";

	/// <summary>
	/// Key: "Label.AudioAssetBlockedCopyright"
	/// English String: "This audio asset has been blocked due to copyright violations.\n"
	/// </summary>
	public override string LabelAudioAssetBlockedCopyright => "因侵犯著作權，此音訊素材已被封鎖。\n";

	/// <summary>
	/// Key: "Label.GooglePlayExclusiveItem"
	/// English String: "This is a Google Play exclusive item."
	/// </summary>
	public override string LabelGooglePlayExclusiveItem => "此為 Google Play 限定道具。";

	/// <summary>
	/// Key: "Label.IosDeviceExclusiveItem"
	/// English String: "This is an iOS exclusive item."
	/// </summary>
	public override string LabelIosDeviceExclusiveItem => "此為 iOS 限定道具。";

	/// <summary>
	/// Key: "Label.ItemAvailableInventory"
	/// English String: "This item is available in your inventory."
	/// </summary>
	public override string LabelItemAvailableInventory => "此道具在您的道具欄。";

	/// <summary>
	/// Key: "Label.ItemHasBeenModerated"
	/// English String: "This item has been moderated."
	/// </summary>
	public override string LabelItemHasBeenModerated => "此道具遭到過濾。";

	/// <summary>
	/// Key: "Label.ItemNoLongerForSale"
	/// English String: "This item is no longer for sale."
	/// </summary>
	public override string LabelItemNoLongerForSale => "此道具已停止販賣。";

	/// <summary>
	/// Key: "Label.ItemNotCurrentlyForSale"
	/// English String: "This item is not currently for sale."
	/// </summary>
	public override string LabelItemNotCurrentlyForSale => "此道具目前為非賣品。";

	/// <summary>
	/// Key: "Label.MobileDeviceExclusiveItem"
	/// English String: "This is a mobile exclusive item."
	/// </summary>
	public override string LabelMobileDeviceExclusiveItem => "此為行動裝置限定道具。";

	/// <summary>
	/// Key: "Label.NoDescriptionAvailable"
	/// English String: "No description available."
	/// </summary>
	public override string LabelNoDescriptionAvailable => "沒有說明。";

	/// <summary>
	/// Key: "Label.NoOneCurrentlySelling"
	/// English String: "There is no one currently selling this item."
	/// </summary>
	public override string LabelNoOneCurrentlySelling => "目前沒有人販賣此道具。";

	/// <summary>
	/// Key: "Label.NoOtherSellers"
	/// English String: "No other sellers."
	/// </summary>
	public override string LabelNoOtherSellers => "無其他賣家。";

	/// <summary>
	/// Key: "Label.NotAvailable"
	/// English String: "N/A"
	/// </summary>
	public override string LabelNotAvailable => "無";

	/// <summary>
	/// Key: "Label.PurchasingTemporarilyUnavailable"
	/// English String: "Purchasing is temporarily unavailable. Please try again later."
	/// </summary>
	public override string LabelPurchasingTemporarilyUnavailable => "暫時無法購買，請稍後再試。";

	/// <summary>
	/// Key: "Label.Resellers"
	/// English String: "Resellers"
	/// </summary>
	public override string LabelResellers => "轉賣者";

	/// <summary>
	/// Key: "Label.RobloxAsset"
	/// English String: "Roblox Asset"
	/// </summary>
	public override string LabelRobloxAsset => "Roblox 素材";

	/// <summary>
	/// Key: "Label.TakeOff"
	/// English String: "Take Off"
	/// </summary>
	public override string LabelTakeOff => "脫下";

	/// <summary>
	/// Key: "Label.ToInstallOpenStudio"
	/// English String: "To install, open this page in Roblox Studio."
	/// </summary>
	public override string LabelToInstallOpenStudio => "若要安裝，請在 Roblox Studio 開啟此頁面。";

	/// <summary>
	/// Key: "Label.Wear"
	/// English String: "Wear"
	/// </summary>
	public override string LabelWear => "穿戴";

	/// <summary>
	/// Key: "Label.XboxOneExclusiveItem"
	/// English String: "This is a Xbox One exclusive item."
	/// </summary>
	public override string LabelXboxOneExclusiveItem => "此為 Xbox One 限定道具。";

	/// <summary>
	/// Key: "Label.YouAreSelling"
	/// English String: "You are selling this item."
	/// </summary>
	public override string LabelYouAreSelling => "您正在販賣此道具。";

	public ItemModelResources_zh_tw(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForLabelAmazonExclusiveItem()
	{
		return "此為 Amazon 限定道具。";
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
		return $"{assetOption}租用";
	}

	protected override string _GetTemplateForLabelAssetOptionRental()
	{
		return "{assetOption}租用";
	}

	protected override string _GetTemplateForLabelAudioAssetBlockedCopyright()
	{
		return "因侵犯著作權，此音訊素材已被封鎖。\n";
	}

	/// <summary>
	/// Key: "Label.BcRequirementExclusiveItem"
	/// English String: "{bcRequirementName} exclusive item."
	/// </summary>
	public override string LabelBcRequirementExclusiveItem(string bcRequirementName)
	{
		return $"{bcRequirementName} 限定道具。";
	}

	protected override string _GetTemplateForLabelBcRequirementExclusiveItem()
	{
		return "{bcRequirementName} 限定道具。";
	}

	/// <summary>
	/// Key: "Label.ExpiresRentalTime"
	/// English String: "Expires: {rentalTime}"
	/// </summary>
	public override string LabelExpiresRentalTime(string rentalTime)
	{
		return $"有效期限：{rentalTime}。";
	}

	protected override string _GetTemplateForLabelExpiresRentalTime()
	{
		return "有效期限：{rentalTime}。";
	}

	protected override string _GetTemplateForLabelGooglePlayExclusiveItem()
	{
		return "此為 Google Play 限定道具。";
	}

	protected override string _GetTemplateForLabelIosDeviceExclusiveItem()
	{
		return "此為 iOS 限定道具。";
	}

	protected override string _GetTemplateForLabelItemAvailableInventory()
	{
		return "此道具在您的道具欄。";
	}

	protected override string _GetTemplateForLabelItemHasBeenModerated()
	{
		return "此道具遭到過濾。";
	}

	protected override string _GetTemplateForLabelItemNoLongerForSale()
	{
		return "此道具已停止販賣。";
	}

	protected override string _GetTemplateForLabelItemNotCurrentlyForSale()
	{
		return "此道具目前為非賣品。";
	}

	/// <summary>
	/// Key: "Label.LimitedQuantity"
	/// English String: "Limited quantity: {amount}"
	/// </summary>
	public override string LabelLimitedQuantity(string amount)
	{
		return $"限量：{amount}";
	}

	protected override string _GetTemplateForLabelLimitedQuantity()
	{
		return "限量：{amount}";
	}

	public override string LabelMetaDescriptionCatalog(string assetName, string assetTypeLabel)
	{
		return $"以 {assetName} 和其它道具自訂您的虛擬人偶。混搭{assetTypeLabel}與其它道具，創造出獨一無二的虛擬人偶！";
	}

	protected override string _GetTemplateForLabelMetaDescriptionCatalog()
	{
		return "以 {assetName} 和其它道具自訂您的虛擬人偶。混搭{assetTypeLabel}與其它道具，創造出獨一無二的虛擬人偶！";
	}

	/// <summary>
	/// Key: "Label.MetaDescriptionLibrary"
	/// English String: "Use {assetName} and thousands of other {assetTypeLabel} to build an immersive game or experience. Select from a wide range of models, decals, meshes, plugins, or audio that help bring your imagination into reality."
	/// </summary>
	public override string LabelMetaDescriptionLibrary(string assetName, string assetTypeLabel)
	{
		return $"使用 {assetName} 及其它{assetTypeLabel}創作身歷其境的遊戲和體驗。從眾多的模型、貼花、模組、外掛程式或音訊選項中，將您的想像力化為現實。";
	}

	protected override string _GetTemplateForLabelMetaDescriptionLibrary()
	{
		return "使用 {assetName} 及其它{assetTypeLabel}創作身歷其境的遊戲和體驗。從眾多的模型、貼花、模組、外掛程式或音訊選項中，將您的想像力化為現實。";
	}

	/// <summary>
	/// Key: "Label.MetaDescriptionLibraryV2"
	/// new text with no asset type
	/// English String: "Use {assetName} and thousands of other assets to build an immersive game or experience. Select from a wide range of models, decals, meshes, plugins, or audio that help bring your imagination into reality."
	/// </summary>
	public override string LabelMetaDescriptionLibraryV2(string assetName)
	{
		return $"使用{assetName} 及各種素材創作身歷其境的遊戲和體驗。從眾多的模型、貼花、模組、外掛程式或音訊選項中，將您的想像力化為現實。";
	}

	protected override string _GetTemplateForLabelMetaDescriptionLibraryV2()
	{
		return "使用{assetName} 及各種素材創作身歷其境的遊戲和體驗。從眾多的模型、貼花、模組、外掛程式或音訊選項中，將您的想像力化為現實。";
	}

	protected override string _GetTemplateForLabelMobileDeviceExclusiveItem()
	{
		return "此為行動裝置限定道具。";
	}

	protected override string _GetTemplateForLabelNoDescriptionAvailable()
	{
		return "沒有說明。";
	}

	protected override string _GetTemplateForLabelNoOneCurrentlySelling()
	{
		return "目前沒有人販賣此道具。";
	}

	protected override string _GetTemplateForLabelNoOtherSellers()
	{
		return "無其他賣家。";
	}

	protected override string _GetTemplateForLabelNotAvailable()
	{
		return "無";
	}

	/// <summary>
	/// Key: "Label.PriceChangedFrom"
	/// English String: "Price changed from {robuxAmount}"
	/// </summary>
	public override string LabelPriceChangedFrom(string robuxAmount)
	{
		return $"價格已從 {robuxAmount} 變更";
	}

	protected override string _GetTemplateForLabelPriceChangedFrom()
	{
		return "價格已從 {robuxAmount} 變更";
	}

	protected override string _GetTemplateForLabelPurchasingTemporarilyUnavailable()
	{
		return "暫時無法購買，請稍後再試。";
	}

	protected override string _GetTemplateForLabelResellers()
	{
		return "轉賣者";
	}

	protected override string _GetTemplateForLabelRobloxAsset()
	{
		return "Roblox 素材";
	}

	/// <summary>
	/// Key: "Label.SeeMoreResellers"
	/// English String: "See more {resellers}"
	/// </summary>
	public override string LabelSeeMoreResellers(string resellers)
	{
		return $"查看更多{resellers}";
	}

	protected override string _GetTemplateForLabelSeeMoreResellers()
	{
		return "查看更多{resellers}";
	}

	/// <summary>
	/// Key: "Label.SerialNoOf"
	/// English String: "{serial} of {total}"
	/// </summary>
	public override string LabelSerialNoOf(string serial, string total)
	{
		return $"{serial}/{total}";
	}

	protected override string _GetTemplateForLabelSerialNoOf()
	{
		return "{serial}/{total}";
	}

	protected override string _GetTemplateForLabelTakeOff()
	{
		return "脫下";
	}

	protected override string _GetTemplateForLabelToInstallOpenStudio()
	{
		return "若要安裝，請在 Roblox Studio 開啟此頁面。";
	}

	protected override string _GetTemplateForLabelWear()
	{
		return "穿戴";
	}

	protected override string _GetTemplateForLabelXboxOneExclusiveItem()
	{
		return "此為 Xbox One 限定道具。";
	}

	protected override string _GetTemplateForLabelYouAreSelling()
	{
		return "您正在販賣此道具。";
	}
}
