namespace Roblox.Platform.TranslationResources.Feature {
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
	public override string LabelAmazonExclusiveItem => "æ­¤ç‚º Amazon é™å®šé“å…·ã€‚";

	/// <summary>
	/// Key: "Label.AudioAssetBlockedCopyright"
	/// English String: "This audio asset has been blocked due to copyright violations.\n"
	/// </summary>
	public override string LabelAudioAssetBlockedCopyright => "å› ä¾µçŠ¯è‘—ä½œæ¬Šï¼Œæ­¤éŸ³è¨Šç´ æå·²è¢«å°éŽ–ã€‚\n";

	/// <summary>
	/// Key: "Label.GooglePlayExclusiveItem"
	/// English String: "This is a Google Play exclusive item."
	/// </summary>
	public override string LabelGooglePlayExclusiveItem => "æ­¤ç‚º Google Play é™å®šé“å…·ã€‚";

	/// <summary>
	/// Key: "Label.IosDeviceExclusiveItem"
	/// English String: "This is an iOS exclusive item."
	/// </summary>
	public override string LabelIosDeviceExclusiveItem => "æ­¤ç‚º iOS é™å®šé“å…·ã€‚";

	/// <summary>
	/// Key: "Label.ItemAvailableInventory"
	/// English String: "This item is available in your inventory."
	/// </summary>
	public override string LabelItemAvailableInventory => "æ­¤é“å…·åœ¨æ‚¨çš„é“å…·æ¬„ã€‚";

	/// <summary>
	/// Key: "Label.ItemHasBeenModerated"
	/// English String: "This item has been moderated."
	/// </summary>
	public override string LabelItemHasBeenModerated => "æ­¤é“å…·é­åˆ°éŽæ¿¾ã€‚";

	/// <summary>
	/// Key: "Label.ItemNoLongerForSale"
	/// English String: "This item is no longer for sale."
	/// </summary>
	public override string LabelItemNoLongerForSale => "æ­¤é“å…·å·²åœæ­¢è²©è³£ã€‚";

	/// <summary>
	/// Key: "Label.ItemNotCurrentlyForSale"
	/// English String: "This item is not currently for sale."
	/// </summary>
	public override string LabelItemNotCurrentlyForSale => "æ­¤é“å…·ç›®å‰ç‚ºéžè³£å“ã€‚";

	/// <summary>
	/// Key: "Label.MobileDeviceExclusiveItem"
	/// English String: "This is a mobile exclusive item."
	/// </summary>
	public override string LabelMobileDeviceExclusiveItem => "æ­¤ç‚ºè¡Œå‹•è£ç½®é™å®šé“å…·ã€‚";

	/// <summary>
	/// Key: "Label.NoDescriptionAvailable"
	/// English String: "No description available."
	/// </summary>
	public override string LabelNoDescriptionAvailable => "æ²’æœ‰èªªæ˜Žã€‚";

	/// <summary>
	/// Key: "Label.NoOneCurrentlySelling"
	/// English String: "There is no one currently selling this item."
	/// </summary>
	public override string LabelNoOneCurrentlySelling => "ç›®å‰æ²’æœ‰äººè²©è³£æ­¤é“å…·ã€‚";

	/// <summary>
	/// Key: "Label.NoOtherSellers"
	/// English String: "No other sellers."
	/// </summary>
	public override string LabelNoOtherSellers => "ç„¡å…¶ä»–è³£å®¶ã€‚";

	/// <summary>
	/// Key: "Label.NotAvailable"
	/// English String: "N/A"
	/// </summary>
	public override string LabelNotAvailable => "ç„¡";

	/// <summary>
	/// Key: "Label.PurchasingTemporarilyUnavailable"
	/// English String: "Purchasing is temporarily unavailable. Please try again later."
	/// </summary>
	public override string LabelPurchasingTemporarilyUnavailable => "æš«æ™‚ç„¡æ³•è³¼è²·ï¼Œè«‹ç¨å¾Œå†è©¦ã€‚";

	/// <summary>
	/// Key: "Label.Resellers"
	/// English String: "Resellers"
	/// </summary>
	public override string LabelResellers => "è½‰è³£è€…";

	/// <summary>
	/// Key: "Label.RobloxAsset"
	/// English String: "Roblox Asset"
	/// </summary>
	public override string LabelRobloxAsset => "Roblox ç´ æ";

	/// <summary>
	/// Key: "Label.TakeOff"
	/// English String: "Take Off"
	/// </summary>
	public override string LabelTakeOff => "è„«ä¸‹";

	/// <summary>
	/// Key: "Label.ToInstallOpenStudio"
	/// English String: "To install, open this page in Roblox Studio."
	/// </summary>
	public override string LabelToInstallOpenStudio => "è‹¥è¦å®‰è£ï¼Œè«‹åœ¨ Roblox Studio é–‹å•Ÿæ­¤é é¢ã€‚";

	/// <summary>
	/// Key: "Label.Wear"
	/// English String: "Wear"
	/// </summary>
	public override string LabelWear => "ç©¿æˆ´";

	/// <summary>
	/// Key: "Label.XboxOneExclusiveItem"
	/// English String: "This is a Xbox One exclusive item."
	/// </summary>
	public override string LabelXboxOneExclusiveItem => "æ­¤ç‚º Xbox One é™å®šé“å…·ã€‚";

	/// <summary>
	/// Key: "Label.YouAreSelling"
	/// English String: "You are selling this item."
	/// </summary>
	public override string LabelYouAreSelling => "æ‚¨æ­£åœ¨è²©è³£æ­¤é“å…·ã€‚";

	public ItemModelResources_zh_tw(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForLabelAmazonExclusiveItem()
	{
		return "æ­¤ç‚º Amazon é™å®šé“å…·ã€‚";
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
		return $"{assetOption}ç§Ÿç”¨";
	}

	protected override string _GetTemplateForLabelAssetOptionRental()
	{
		return "{assetOption}ç§Ÿç”¨";
	}

	protected override string _GetTemplateForLabelAudioAssetBlockedCopyright()
	{
		return "å› ä¾µçŠ¯è‘—ä½œæ¬Šï¼Œæ­¤éŸ³è¨Šç´ æå·²è¢«å°éŽ–ã€‚\n";
	}

	/// <summary>
	/// Key: "Label.BcRequirementExclusiveItem"
	/// English String: "{bcRequirementName} exclusive item."
	/// </summary>
	public override string LabelBcRequirementExclusiveItem(string bcRequirementName)
	{
		return $"{bcRequirementName} é™å®šé“å…·ã€‚";
	}

	protected override string _GetTemplateForLabelBcRequirementExclusiveItem()
	{
		return "{bcRequirementName} é™å®šé“å…·ã€‚";
	}

	/// <summary>
	/// Key: "Label.ExpiresRentalTime"
	/// English String: "Expires: {rentalTime}"
	/// </summary>
	public override string LabelExpiresRentalTime(string rentalTime)
	{
		return $"æœ‰æ•ˆæœŸé™ï¼š{rentalTime}ã€‚";
	}

	protected override string _GetTemplateForLabelExpiresRentalTime()
	{
		return "æœ‰æ•ˆæœŸé™ï¼š{rentalTime}ã€‚";
	}

	protected override string _GetTemplateForLabelGooglePlayExclusiveItem()
	{
		return "æ­¤ç‚º Google Play é™å®šé“å…·ã€‚";
	}

	protected override string _GetTemplateForLabelIosDeviceExclusiveItem()
	{
		return "æ­¤ç‚º iOS é™å®šé“å…·ã€‚";
	}

	protected override string _GetTemplateForLabelItemAvailableInventory()
	{
		return "æ­¤é“å…·åœ¨æ‚¨çš„é“å…·æ¬„ã€‚";
	}

	protected override string _GetTemplateForLabelItemHasBeenModerated()
	{
		return "æ­¤é“å…·é­åˆ°éŽæ¿¾ã€‚";
	}

	protected override string _GetTemplateForLabelItemNoLongerForSale()
	{
		return "æ­¤é“å…·å·²åœæ­¢è²©è³£ã€‚";
	}

	protected override string _GetTemplateForLabelItemNotCurrentlyForSale()
	{
		return "æ­¤é“å…·ç›®å‰ç‚ºéžè³£å“ã€‚";
	}

	/// <summary>
	/// Key: "Label.LimitedQuantity"
	/// English String: "Limited quantity: {amount}"
	/// </summary>
	public override string LabelLimitedQuantity(string amount)
	{
		return $"é™é‡ï¼š{amount}";
	}

	protected override string _GetTemplateForLabelLimitedQuantity()
	{
		return "é™é‡ï¼š{amount}";
	}

	public override string LabelMetaDescriptionCatalog(string assetName, string assetTypeLabel)
	{
		return $"ä»¥ {assetName} å’Œå…¶å®ƒé“å…·è‡ªè¨‚æ‚¨çš„è™›æ“¬äººå¶ã€‚æ··æ­{assetTypeLabel}èˆ‡å…¶å®ƒé“å…·ï¼Œå‰µé€ å‡ºç¨ä¸€ç„¡äºŒçš„è™›æ“¬äººå¶ï¼";
	}

	protected override string _GetTemplateForLabelMetaDescriptionCatalog()
	{
		return "ä»¥ {assetName} å’Œå…¶å®ƒé“å…·è‡ªè¨‚æ‚¨çš„è™›æ“¬äººå¶ã€‚æ··æ­{assetTypeLabel}èˆ‡å…¶å®ƒé“å…·ï¼Œå‰µé€ å‡ºç¨ä¸€ç„¡äºŒçš„è™›æ“¬äººå¶ï¼";
	}

	/// <summary>
	/// Key: "Label.MetaDescriptionLibrary"
	/// English String: "Use {assetName} and thousands of other {assetTypeLabel} to build an immersive game or experience. Select from a wide range of models, decals, meshes, plugins, or audio that help bring your imagination into reality."
	/// </summary>
	public override string LabelMetaDescriptionLibrary(string assetName, string assetTypeLabel)
	{
		return $"ä½¿ç”¨ {assetName} åŠå…¶å®ƒ{assetTypeLabel}å‰µä½œèº«æ­·å…¶å¢ƒçš„éŠæˆ²å’Œé«”é©—ã€‚å¾žçœ¾å¤šçš„æ¨¡åž‹ã€è²¼èŠ±ã€æ¨¡çµ„ã€å¤–æŽ›ç¨‹å¼æˆ–éŸ³è¨Šé¸é …ä¸­ï¼Œå°‡æ‚¨çš„æƒ³åƒåŠ›åŒ–ç‚ºç¾å¯¦ã€‚";
	}

	protected override string _GetTemplateForLabelMetaDescriptionLibrary()
	{
		return "ä½¿ç”¨ {assetName} åŠå…¶å®ƒ{assetTypeLabel}å‰µä½œèº«æ­·å…¶å¢ƒçš„éŠæˆ²å’Œé«”é©—ã€‚å¾žçœ¾å¤šçš„æ¨¡åž‹ã€è²¼èŠ±ã€æ¨¡çµ„ã€å¤–æŽ›ç¨‹å¼æˆ–éŸ³è¨Šé¸é …ä¸­ï¼Œå°‡æ‚¨çš„æƒ³åƒåŠ›åŒ–ç‚ºç¾å¯¦ã€‚";
	}

	/// <summary>
	/// Key: "Label.MetaDescriptionLibraryV2"
	/// new text with no asset type
	/// English String: "Use {assetName} and thousands of other assets to build an immersive game or experience. Select from a wide range of models, decals, meshes, plugins, or audio that help bring your imagination into reality."
	/// </summary>
	public override string LabelMetaDescriptionLibraryV2(string assetName)
	{
		return $"ä½¿ç”¨{assetName} åŠå„ç¨®ç´ æå‰µä½œèº«æ­·å…¶å¢ƒçš„éŠæˆ²å’Œé«”é©—ã€‚å¾žçœ¾å¤šçš„æ¨¡åž‹ã€è²¼èŠ±ã€æ¨¡çµ„ã€å¤–æŽ›ç¨‹å¼æˆ–éŸ³è¨Šé¸é …ä¸­ï¼Œå°‡æ‚¨çš„æƒ³åƒåŠ›åŒ–ç‚ºç¾å¯¦ã€‚";
	}

	protected override string _GetTemplateForLabelMetaDescriptionLibraryV2()
	{
		return "ä½¿ç”¨{assetName} åŠå„ç¨®ç´ æå‰µä½œèº«æ­·å…¶å¢ƒçš„éŠæˆ²å’Œé«”é©—ã€‚å¾žçœ¾å¤šçš„æ¨¡åž‹ã€è²¼èŠ±ã€æ¨¡çµ„ã€å¤–æŽ›ç¨‹å¼æˆ–éŸ³è¨Šé¸é …ä¸­ï¼Œå°‡æ‚¨çš„æƒ³åƒåŠ›åŒ–ç‚ºç¾å¯¦ã€‚";
	}

	protected override string _GetTemplateForLabelMobileDeviceExclusiveItem()
	{
		return "æ­¤ç‚ºè¡Œå‹•è£ç½®é™å®šé“å…·ã€‚";
	}

	protected override string _GetTemplateForLabelNoDescriptionAvailable()
	{
		return "æ²’æœ‰èªªæ˜Žã€‚";
	}

	protected override string _GetTemplateForLabelNoOneCurrentlySelling()
	{
		return "ç›®å‰æ²’æœ‰äººè²©è³£æ­¤é“å…·ã€‚";
	}

	protected override string _GetTemplateForLabelNoOtherSellers()
	{
		return "ç„¡å…¶ä»–è³£å®¶ã€‚";
	}

	protected override string _GetTemplateForLabelNotAvailable()
	{
		return "ç„¡";
	}

	/// <summary>
	/// Key: "Label.PriceChangedFrom"
	/// English String: "Price changed from {robuxAmount}"
	/// </summary>
	public override string LabelPriceChangedFrom(string robuxAmount)
	{
		return $"åƒ¹æ ¼å·²å¾ž {robuxAmount} è®Šæ›´";
	}

	protected override string _GetTemplateForLabelPriceChangedFrom()
	{
		return "åƒ¹æ ¼å·²å¾ž {robuxAmount} è®Šæ›´";
	}

	protected override string _GetTemplateForLabelPurchasingTemporarilyUnavailable()
	{
		return "æš«æ™‚ç„¡æ³•è³¼è²·ï¼Œè«‹ç¨å¾Œå†è©¦ã€‚";
	}

	protected override string _GetTemplateForLabelResellers()
	{
		return "è½‰è³£è€…";
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
		return $"{serial}/{total}";
	}

	protected override string _GetTemplateForLabelSerialNoOf()
	{
		return "{serial}/{total}";
	}

	protected override string _GetTemplateForLabelTakeOff()
	{
		return "è„«ä¸‹";
	}

	protected override string _GetTemplateForLabelToInstallOpenStudio()
	{
		return "è‹¥è¦å®‰è£ï¼Œè«‹åœ¨ Roblox Studio é–‹å•Ÿæ­¤é é¢ã€‚";
	}

	protected override string _GetTemplateForLabelWear()
	{
		return "ç©¿æˆ´";
	}

	protected override string _GetTemplateForLabelXboxOneExclusiveItem()
	{
		return "æ­¤ç‚º Xbox One é™å®šé“å…·ã€‚";
	}

	protected override string _GetTemplateForLabelYouAreSelling()
	{
		return "æ‚¨æ­£åœ¨è²©è³£æ­¤é“å…·ã€‚";
	}
}


}
