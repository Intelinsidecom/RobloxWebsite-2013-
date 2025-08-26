namespace Roblox.Platform.TranslationResources.Feature {
    /// <summary>

/// This class overrides ItemModelResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class ItemModelResources_zh_cn : ItemModelResources_en_us, IItemModelResources, ITranslationResources
{
	/// <summary>
	/// Key: "Label.AmazonExclusiveItem"
	/// English String: "This is an Amazon exclusive item."
	/// </summary>
	public override string LabelAmazonExclusiveItem => "è¿™æ˜¯ Amazon ä¸“å±žç‰©å“ã€‚";

	/// <summary>
	/// Key: "Label.AudioAssetBlockedCopyright"
	/// English String: "This audio asset has been blocked due to copyright violations.\n"
	/// </summary>
	public override string LabelAudioAssetBlockedCopyright => "å› ä¾µçŠ¯ç‰ˆæƒï¼Œæ­¤éŸ³é¢‘ç´ æå·²è¢«å±è”½ã€‚\n";

	/// <summary>
	/// Key: "Label.GooglePlayExclusiveItem"
	/// English String: "This is a Google Play exclusive item."
	/// </summary>
	public override string LabelGooglePlayExclusiveItem => "è¿™æ˜¯ Google Play ä¸“å±žç‰©å“ã€‚";

	/// <summary>
	/// Key: "Label.IosDeviceExclusiveItem"
	/// English String: "This is an iOS exclusive item."
	/// </summary>
	public override string LabelIosDeviceExclusiveItem => "è¿™æ˜¯ iOS ä¸“å±žç‰©å“ã€‚";

	/// <summary>
	/// Key: "Label.ItemAvailableInventory"
	/// English String: "This item is available in your inventory."
	/// </summary>
	public override string LabelItemAvailableInventory => "æ­¤ç‰©å“åœ¨ä½ çš„é“å…·æ ä¸­ã€‚";

	/// <summary>
	/// Key: "Label.ItemHasBeenModerated"
	/// English String: "This item has been moderated."
	/// </summary>
	public override string LabelItemHasBeenModerated => "æ­¤ç‰©å“å·²è¢«è¿‡æ»¤ã€‚";

	/// <summary>
	/// Key: "Label.ItemNoLongerForSale"
	/// English String: "This item is no longer for sale."
	/// </summary>
	public override string LabelItemNoLongerForSale => "æ­¤ç‰©å“å·²åœæ­¢å‡ºå”®ã€‚";

	/// <summary>
	/// Key: "Label.ItemNotCurrentlyForSale"
	/// English String: "This item is not currently for sale."
	/// </summary>
	public override string LabelItemNotCurrentlyForSale => "æ­¤ç‰©å“ç›®å‰ä¸ºéžå–å“ã€‚";

	/// <summary>
	/// Key: "Label.MobileDeviceExclusiveItem"
	/// English String: "This is a mobile exclusive item."
	/// </summary>
	public override string LabelMobileDeviceExclusiveItem => "è¿™æ˜¯ç§»åŠ¨è®¾å¤‡ä¸“å±žç‰©å“ã€‚";

	/// <summary>
	/// Key: "Label.NoDescriptionAvailable"
	/// English String: "No description available."
	/// </summary>
	public override string LabelNoDescriptionAvailable => "æ— å¯ç”¨æè¿°ã€‚";

	/// <summary>
	/// Key: "Label.NoOneCurrentlySelling"
	/// English String: "There is no one currently selling this item."
	/// </summary>
	public override string LabelNoOneCurrentlySelling => "ç›®å‰æ²¡æœ‰äººå‡ºå”®æ­¤ç‰©å“ã€‚";

	/// <summary>
	/// Key: "Label.NoOtherSellers"
	/// English String: "No other sellers."
	/// </summary>
	public override string LabelNoOtherSellers => "æ— å…¶ä»–å–å®¶ã€‚";

	/// <summary>
	/// Key: "Label.NotAvailable"
	/// English String: "N/A"
	/// </summary>
	public override string LabelNotAvailable => "æ— ";

	/// <summary>
	/// Key: "Label.PurchasingTemporarilyUnavailable"
	/// English String: "Purchasing is temporarily unavailable. Please try again later."
	/// </summary>
	public override string LabelPurchasingTemporarilyUnavailable => "æš‚æ—¶æ— æ³•è´­ä¹°ã€‚è¯·ç¨åŽé‡è¯•ã€‚";

	/// <summary>
	/// Key: "Label.Resellers"
	/// English String: "Resellers"
	/// </summary>
	public override string LabelResellers => "è½¬å”®è€…";

	/// <summary>
	/// Key: "Label.RobloxAsset"
	/// English String: "Roblox Asset"
	/// </summary>
	public override string LabelRobloxAsset => "Roblox ç´ æ";

	/// <summary>
	/// Key: "Label.TakeOff"
	/// English String: "Take Off"
	/// </summary>
	public override string LabelTakeOff => "è„±ä¸‹";

	/// <summary>
	/// Key: "Label.ToInstallOpenStudio"
	/// English String: "To install, open this page in Roblox Studio."
	/// </summary>
	public override string LabelToInstallOpenStudio => "è‹¥è¦å®‰è£…ï¼Œè¯·åœ¨ Roblox Studio ä¸­æ‰“å¼€æ­¤é¡µé¢ã€‚";

	/// <summary>
	/// Key: "Label.Wear"
	/// English String: "Wear"
	/// </summary>
	public override string LabelWear => "ç©¿æˆ´";

	/// <summary>
	/// Key: "Label.XboxOneExclusiveItem"
	/// English String: "This is a Xbox One exclusive item."
	/// </summary>
	public override string LabelXboxOneExclusiveItem => "è¿™æ˜¯ Xbox One ä¸“å±žç‰©å“ã€‚";

	/// <summary>
	/// Key: "Label.YouAreSelling"
	/// English String: "You are selling this item."
	/// </summary>
	public override string LabelYouAreSelling => "ä½ æ­£å‡ºå”®æ­¤ç‰©å“ã€‚";

	public ItemModelResources_zh_cn(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForLabelAmazonExclusiveItem()
	{
		return "è¿™æ˜¯ Amazon ä¸“å±žç‰©å“ã€‚";
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
		return $"{assetOption} ç§Ÿç”¨";
	}

	protected override string _GetTemplateForLabelAssetOptionRental()
	{
		return "{assetOption} ç§Ÿç”¨";
	}

	protected override string _GetTemplateForLabelAudioAssetBlockedCopyright()
	{
		return "å› ä¾µçŠ¯ç‰ˆæƒï¼Œæ­¤éŸ³é¢‘ç´ æå·²è¢«å±è”½ã€‚\n";
	}

	/// <summary>
	/// Key: "Label.BcRequirementExclusiveItem"
	/// English String: "{bcRequirementName} exclusive item."
	/// </summary>
	public override string LabelBcRequirementExclusiveItem(string bcRequirementName)
	{
		return $"{bcRequirementName} ä¸“å±žç‰©å“ã€‚";
	}

	protected override string _GetTemplateForLabelBcRequirementExclusiveItem()
	{
		return "{bcRequirementName} ä¸“å±žç‰©å“ã€‚";
	}

	/// <summary>
	/// Key: "Label.ExpiresRentalTime"
	/// English String: "Expires: {rentalTime}"
	/// </summary>
	public override string LabelExpiresRentalTime(string rentalTime)
	{
		return $"å¤±æ•ˆæ—¶é—´ï¼š{rentalTime}";
	}

	protected override string _GetTemplateForLabelExpiresRentalTime()
	{
		return "å¤±æ•ˆæ—¶é—´ï¼š{rentalTime}";
	}

	protected override string _GetTemplateForLabelGooglePlayExclusiveItem()
	{
		return "è¿™æ˜¯ Google Play ä¸“å±žç‰©å“ã€‚";
	}

	protected override string _GetTemplateForLabelIosDeviceExclusiveItem()
	{
		return "è¿™æ˜¯ iOS ä¸“å±žç‰©å“ã€‚";
	}

	protected override string _GetTemplateForLabelItemAvailableInventory()
	{
		return "æ­¤ç‰©å“åœ¨ä½ çš„é“å…·æ ä¸­ã€‚";
	}

	protected override string _GetTemplateForLabelItemHasBeenModerated()
	{
		return "æ­¤ç‰©å“å·²è¢«è¿‡æ»¤ã€‚";
	}

	protected override string _GetTemplateForLabelItemNoLongerForSale()
	{
		return "æ­¤ç‰©å“å·²åœæ­¢å‡ºå”®ã€‚";
	}

	protected override string _GetTemplateForLabelItemNotCurrentlyForSale()
	{
		return "æ­¤ç‰©å“ç›®å‰ä¸ºéžå–å“ã€‚";
	}

	/// <summary>
	/// Key: "Label.LimitedQuantity"
	/// English String: "Limited quantity: {amount}"
	/// </summary>
	public override string LabelLimitedQuantity(string amount)
	{
		return $"é™å®šæ•°é‡ï¼š{amount}";
	}

	protected override string _GetTemplateForLabelLimitedQuantity()
	{
		return "é™å®šæ•°é‡ï¼š{amount}";
	}

	public override string LabelMetaDescriptionCatalog(string assetName, string assetTypeLabel)
	{
		return $"ä½¿ç”¨{assetName}å’Œä¸Šç™¾ä¸‡ç§å…¶ä»–ç‰©å“æ¥è‡ªå®šä¹‰ä½ çš„è™šæ‹Ÿå½¢è±¡ã€‚æ··æ­{assetTypeLabel}åŠå…¶ä»–ç‰©å“ï¼Œæ‰“é€ ç‹¬ä¸€æ— äºŒçš„è™šæ‹Ÿå½¢è±¡ï¼";
	}

	protected override string _GetTemplateForLabelMetaDescriptionCatalog()
	{
		return "ä½¿ç”¨{assetName}å’Œä¸Šç™¾ä¸‡ç§å…¶ä»–ç‰©å“æ¥è‡ªå®šä¹‰ä½ çš„è™šæ‹Ÿå½¢è±¡ã€‚æ··æ­{assetTypeLabel}åŠå…¶ä»–ç‰©å“ï¼Œæ‰“é€ ç‹¬ä¸€æ— äºŒçš„è™šæ‹Ÿå½¢è±¡ï¼";
	}

	/// <summary>
	/// Key: "Label.MetaDescriptionLibrary"
	/// English String: "Use {assetName} and thousands of other {assetTypeLabel} to build an immersive game or experience. Select from a wide range of models, decals, meshes, plugins, or audio that help bring your imagination into reality."
	/// </summary>
	public override string LabelMetaDescriptionLibrary(string assetName, string assetTypeLabel)
	{
		return $"ä½¿ç”¨â€œ{assetName}â€å’Œä¸Šåƒç§å…¶ä»–â€œ{assetTypeLabel}â€æ‰“é€ èº«ä¸´å…¶å¢ƒçš„æ¸¸æˆæˆ–ä½“éªŒã€‚ä½ å¯ä»¥ä»Žå¤šç§æ¨¡åž‹ã€è´´èŠ±ã€ç½‘æ ¼ã€æ’ä»¶æˆ–éŸ³é¢‘ä¸­è¿›è¡Œé€‰æ‹©ï¼Œå°†æƒ³è±¡åŒ–ä¸ºçŽ°å®žã€‚";
	}

	protected override string _GetTemplateForLabelMetaDescriptionLibrary()
	{
		return "ä½¿ç”¨â€œ{assetName}â€å’Œä¸Šåƒç§å…¶ä»–â€œ{assetTypeLabel}â€æ‰“é€ èº«ä¸´å…¶å¢ƒçš„æ¸¸æˆæˆ–ä½“éªŒã€‚ä½ å¯ä»¥ä»Žå¤šç§æ¨¡åž‹ã€è´´èŠ±ã€ç½‘æ ¼ã€æ’ä»¶æˆ–éŸ³é¢‘ä¸­è¿›è¡Œé€‰æ‹©ï¼Œå°†æƒ³è±¡åŒ–ä¸ºçŽ°å®žã€‚";
	}

	/// <summary>
	/// Key: "Label.MetaDescriptionLibraryV2"
	/// new text with no asset type
	/// English String: "Use {assetName} and thousands of other assets to build an immersive game or experience. Select from a wide range of models, decals, meshes, plugins, or audio that help bring your imagination into reality."
	/// </summary>
	public override string LabelMetaDescriptionLibraryV2(string assetName)
	{
		return $"ä½¿ç”¨â€œ{assetName}â€å’Œä¸Šåƒç§å…¶ä»–ç´ ææ¥æ‰“é€ èº«ä¸´å…¶å¢ƒçš„æ¸¸æˆæˆ–ä½“éªŒã€‚ä½ å¯ä»¥ä»Žå¤šç§æ¨¡åž‹ã€è´´èŠ±ã€ç½‘æ ¼ã€æ’ä»¶æˆ–éŸ³é¢‘ä¸­è¿›è¡Œé€‰æ‹©ï¼Œå°†æƒ³è±¡åŒ–ä¸ºçŽ°å®žã€‚";
	}

	protected override string _GetTemplateForLabelMetaDescriptionLibraryV2()
	{
		return "ä½¿ç”¨â€œ{assetName}â€å’Œä¸Šåƒç§å…¶ä»–ç´ ææ¥æ‰“é€ èº«ä¸´å…¶å¢ƒçš„æ¸¸æˆæˆ–ä½“éªŒã€‚ä½ å¯ä»¥ä»Žå¤šç§æ¨¡åž‹ã€è´´èŠ±ã€ç½‘æ ¼ã€æ’ä»¶æˆ–éŸ³é¢‘ä¸­è¿›è¡Œé€‰æ‹©ï¼Œå°†æƒ³è±¡åŒ–ä¸ºçŽ°å®žã€‚";
	}

	protected override string _GetTemplateForLabelMobileDeviceExclusiveItem()
	{
		return "è¿™æ˜¯ç§»åŠ¨è®¾å¤‡ä¸“å±žç‰©å“ã€‚";
	}

	protected override string _GetTemplateForLabelNoDescriptionAvailable()
	{
		return "æ— å¯ç”¨æè¿°ã€‚";
	}

	protected override string _GetTemplateForLabelNoOneCurrentlySelling()
	{
		return "ç›®å‰æ²¡æœ‰äººå‡ºå”®æ­¤ç‰©å“ã€‚";
	}

	protected override string _GetTemplateForLabelNoOtherSellers()
	{
		return "æ— å…¶ä»–å–å®¶ã€‚";
	}

	protected override string _GetTemplateForLabelNotAvailable()
	{
		return "æ— ";
	}

	/// <summary>
	/// Key: "Label.PriceChangedFrom"
	/// English String: "Price changed from {robuxAmount}"
	/// </summary>
	public override string LabelPriceChangedFrom(string robuxAmount)
	{
		return $"ä»·æ ¼å·²ä»Ž {robuxAmount} æ›´æ”¹";
	}

	protected override string _GetTemplateForLabelPriceChangedFrom()
	{
		return "ä»·æ ¼å·²ä»Ž {robuxAmount} æ›´æ”¹";
	}

	protected override string _GetTemplateForLabelPurchasingTemporarilyUnavailable()
	{
		return "æš‚æ—¶æ— æ³•è´­ä¹°ã€‚è¯·ç¨åŽé‡è¯•ã€‚";
	}

	protected override string _GetTemplateForLabelResellers()
	{
		return "è½¬å”®è€…";
	}

	protected override string _GetTemplateForLabelRobloxAsset()
	{
		return "Roblox ç´ æ";
	}

	/// <summary>
	/// Key: "Label.SeeMoreResellers"
	/// English String: "See more {resellers}"
	/// </summary>
	public override string LabelSeeMoreResellers(string resellers)
	{
		return $"æŸ¥çœ‹æ›´å¤š{resellers}";
	}

	protected override string _GetTemplateForLabelSeeMoreResellers()
	{
		return "æŸ¥çœ‹æ›´å¤š{resellers}";
	}

	/// <summary>
	/// Key: "Label.SerialNoOf"
	/// English String: "{serial} of {total}"
	/// </summary>
	public override string LabelSerialNoOf(string serial, string total)
	{
		return $"{serial}/å…± {total}";
	}

	protected override string _GetTemplateForLabelSerialNoOf()
	{
		return "{serial}/å…± {total}";
	}

	protected override string _GetTemplateForLabelTakeOff()
	{
		return "è„±ä¸‹";
	}

	protected override string _GetTemplateForLabelToInstallOpenStudio()
	{
		return "è‹¥è¦å®‰è£…ï¼Œè¯·åœ¨ Roblox Studio ä¸­æ‰“å¼€æ­¤é¡µé¢ã€‚";
	}

	protected override string _GetTemplateForLabelWear()
	{
		return "ç©¿æˆ´";
	}

	protected override string _GetTemplateForLabelXboxOneExclusiveItem()
	{
		return "è¿™æ˜¯ Xbox One ä¸“å±žç‰©å“ã€‚";
	}

	protected override string _GetTemplateForLabelYouAreSelling()
	{
		return "ä½ æ­£å‡ºå”®æ­¤ç‰©å“ã€‚";
	}
}


}
