namespace Roblox.TranslationResources.Feature;

/// <summary>
/// This class overrides ItemModelResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class ItemModelResources_ja_jp : ItemModelResources_en_us, IItemModelResources, ITranslationResources
{
	/// <summary>
	/// Key: "Label.AmazonExclusiveItem"
	/// English String: "This is an Amazon exclusive item."
	/// </summary>
	public override string LabelAmazonExclusiveItem => "これはAmazon限定アイテムです。";

	/// <summary>
	/// Key: "Label.AudioAssetBlockedCopyright"
	/// English String: "This audio asset has been blocked due to copyright violations.\n"
	/// </summary>
	public override string LabelAudioAssetBlockedCopyright => "このオーディオアセットは、著作権違反のため、ブロックされています。\n";

	/// <summary>
	/// Key: "Label.GooglePlayExclusiveItem"
	/// English String: "This is a Google Play exclusive item."
	/// </summary>
	public override string LabelGooglePlayExclusiveItem => "Google Play限定アイテムです。";

	/// <summary>
	/// Key: "Label.IosDeviceExclusiveItem"
	/// English String: "This is an iOS exclusive item."
	/// </summary>
	public override string LabelIosDeviceExclusiveItem => "これはiOS限定アイテムです。";

	/// <summary>
	/// Key: "Label.ItemAvailableInventory"
	/// English String: "This item is available in your inventory."
	/// </summary>
	public override string LabelItemAvailableInventory => "このアイテムはインベントリで利用できます。";

	/// <summary>
	/// Key: "Label.ItemHasBeenModerated"
	/// English String: "This item has been moderated."
	/// </summary>
	public override string LabelItemHasBeenModerated => "このアイテムは規制対象です。";

	/// <summary>
	/// Key: "Label.ItemNoLongerForSale"
	/// English String: "This item is no longer for sale."
	/// </summary>
	public override string LabelItemNoLongerForSale => "このアイテムはもう売られていません。";

	/// <summary>
	/// Key: "Label.ItemNotCurrentlyForSale"
	/// English String: "This item is not currently for sale."
	/// </summary>
	public override string LabelItemNotCurrentlyForSale => "このアイテムは現在売られていません。";

	/// <summary>
	/// Key: "Label.MobileDeviceExclusiveItem"
	/// English String: "This is a mobile exclusive item."
	/// </summary>
	public override string LabelMobileDeviceExclusiveItem => "モバイル限定アイテムです。";

	/// <summary>
	/// Key: "Label.NoDescriptionAvailable"
	/// English String: "No description available."
	/// </summary>
	public override string LabelNoDescriptionAvailable => "詳細はありません。";

	/// <summary>
	/// Key: "Label.NoOneCurrentlySelling"
	/// English String: "There is no one currently selling this item."
	/// </summary>
	public override string LabelNoOneCurrentlySelling => "現在このアイテムを売っている人はいません。";

	/// <summary>
	/// Key: "Label.NoOtherSellers"
	/// English String: "No other sellers."
	/// </summary>
	public override string LabelNoOtherSellers => "他に販売者はいません。";

	/// <summary>
	/// Key: "Label.NotAvailable"
	/// English String: "N/A"
	/// </summary>
	public override string LabelNotAvailable => "該当なし";

	/// <summary>
	/// Key: "Label.PurchasingTemporarilyUnavailable"
	/// English String: "Purchasing is temporarily unavailable. Please try again later."
	/// </summary>
	public override string LabelPurchasingTemporarilyUnavailable => "一時的に購入が利用できません。後でもう一度お試しください。";

	/// <summary>
	/// Key: "Label.Resellers"
	/// English String: "Resellers"
	/// </summary>
	public override string LabelResellers => "再販者";

	/// <summary>
	/// Key: "Label.RobloxAsset"
	/// English String: "Roblox Asset"
	/// </summary>
	public override string LabelRobloxAsset => "Robloxアセット";

	/// <summary>
	/// Key: "Label.TakeOff"
	/// English String: "Take Off"
	/// </summary>
	public override string LabelTakeOff => "外す";

	/// <summary>
	/// Key: "Label.ToInstallOpenStudio"
	/// English String: "To install, open this page in Roblox Studio."
	/// </summary>
	public override string LabelToInstallOpenStudio => "インストールするには、Roblox Studioでこのページを開いてください。";

	/// <summary>
	/// Key: "Label.Wear"
	/// English String: "Wear"
	/// </summary>
	public override string LabelWear => "装備";

	/// <summary>
	/// Key: "Label.XboxOneExclusiveItem"
	/// English String: "This is a Xbox One exclusive item."
	/// </summary>
	public override string LabelXboxOneExclusiveItem => "Xbox One限定アイテムです。";

	/// <summary>
	/// Key: "Label.YouAreSelling"
	/// English String: "You are selling this item."
	/// </summary>
	public override string LabelYouAreSelling => "あなたは、このアイテムを販売中です。";

	public ItemModelResources_ja_jp(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForLabelAmazonExclusiveItem()
	{
		return "これはAmazon限定アイテムです。";
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
		return $"{assetOption}のレンタル";
	}

	protected override string _GetTemplateForLabelAssetOptionRental()
	{
		return "{assetOption}のレンタル";
	}

	protected override string _GetTemplateForLabelAudioAssetBlockedCopyright()
	{
		return "このオーディオアセットは、著作権違反のため、ブロックされています。\n";
	}

	/// <summary>
	/// Key: "Label.BcRequirementExclusiveItem"
	/// English String: "{bcRequirementName} exclusive item."
	/// </summary>
	public override string LabelBcRequirementExclusiveItem(string bcRequirementName)
	{
		return $"{bcRequirementName}限定アイテム。";
	}

	protected override string _GetTemplateForLabelBcRequirementExclusiveItem()
	{
		return "{bcRequirementName}限定アイテム。";
	}

	/// <summary>
	/// Key: "Label.ExpiresRentalTime"
	/// English String: "Expires: {rentalTime}"
	/// </summary>
	public override string LabelExpiresRentalTime(string rentalTime)
	{
		return $"期限: {rentalTime}";
	}

	protected override string _GetTemplateForLabelExpiresRentalTime()
	{
		return "期限: {rentalTime}";
	}

	protected override string _GetTemplateForLabelGooglePlayExclusiveItem()
	{
		return "Google Play限定アイテムです。";
	}

	protected override string _GetTemplateForLabelIosDeviceExclusiveItem()
	{
		return "これはiOS限定アイテムです。";
	}

	protected override string _GetTemplateForLabelItemAvailableInventory()
	{
		return "このアイテムはインベントリで利用できます。";
	}

	protected override string _GetTemplateForLabelItemHasBeenModerated()
	{
		return "このアイテムは規制対象です。";
	}

	protected override string _GetTemplateForLabelItemNoLongerForSale()
	{
		return "このアイテムはもう売られていません。";
	}

	protected override string _GetTemplateForLabelItemNotCurrentlyForSale()
	{
		return "このアイテムは現在売られていません。";
	}

	/// <summary>
	/// Key: "Label.LimitedQuantity"
	/// English String: "Limited quantity: {amount}"
	/// </summary>
	public override string LabelLimitedQuantity(string amount)
	{
		return $"数量限定: {amount}";
	}

	protected override string _GetTemplateForLabelLimitedQuantity()
	{
		return "数量限定: {amount}";
	}

	public override string LabelMetaDescriptionCatalog(string assetName, string assetTypeLabel)
	{
		return $"{assetName}や数百万種類のアイテムでアバターをカスタマイズしよう。この{assetTypeLabel}と他のアイテムを組み合わせて、自分だけのアバターを作り上げてください！";
	}

	protected override string _GetTemplateForLabelMetaDescriptionCatalog()
	{
		return "{assetName}や数百万種類のアイテムでアバターをカスタマイズしよう。この{assetTypeLabel}と他のアイテムを組み合わせて、自分だけのアバターを作り上げてください！";
	}

	/// <summary>
	/// Key: "Label.MetaDescriptionLibrary"
	/// English String: "Use {assetName} and thousands of other {assetTypeLabel} to build an immersive game or experience. Select from a wide range of models, decals, meshes, plugins, or audio that help bring your imagination into reality."
	/// </summary>
	public override string LabelMetaDescriptionLibrary(string assetName, string assetTypeLabel)
	{
		return $"{assetName} や数千種類の{assetTypeLabel} を使って、ハマれるゲームや娯楽体験を作り上げましょう。バラエティ豊富なモデル、デカール、メッシュ、プラグイン、オーディオを使って、イマジネーションを現実にしましょう。";
	}

	protected override string _GetTemplateForLabelMetaDescriptionLibrary()
	{
		return "{assetName} や数千種類の{assetTypeLabel} を使って、ハマれるゲームや娯楽体験を作り上げましょう。バラエティ豊富なモデル、デカール、メッシュ、プラグイン、オーディオを使って、イマジネーションを現実にしましょう。";
	}

	/// <summary>
	/// Key: "Label.MetaDescriptionLibraryV2"
	/// new text with no asset type
	/// English String: "Use {assetName} and thousands of other assets to build an immersive game or experience. Select from a wide range of models, decals, meshes, plugins, or audio that help bring your imagination into reality."
	/// </summary>
	public override string LabelMetaDescriptionLibraryV2(string assetName)
	{
		return $"{assetName} や数千種類のアセットを使って、ハマれるゲームや娯楽体験を作り上げましょう。バラエティ豊富なモデル、デカール、メッシュ、プラグイン、オーディオを使って、イマジネーションを現実にしましょう。";
	}

	protected override string _GetTemplateForLabelMetaDescriptionLibraryV2()
	{
		return "{assetName} や数千種類のアセットを使って、ハマれるゲームや娯楽体験を作り上げましょう。バラエティ豊富なモデル、デカール、メッシュ、プラグイン、オーディオを使って、イマジネーションを現実にしましょう。";
	}

	protected override string _GetTemplateForLabelMobileDeviceExclusiveItem()
	{
		return "モバイル限定アイテムです。";
	}

	protected override string _GetTemplateForLabelNoDescriptionAvailable()
	{
		return "詳細はありません。";
	}

	protected override string _GetTemplateForLabelNoOneCurrentlySelling()
	{
		return "現在このアイテムを売っている人はいません。";
	}

	protected override string _GetTemplateForLabelNoOtherSellers()
	{
		return "他に販売者はいません。";
	}

	protected override string _GetTemplateForLabelNotAvailable()
	{
		return "該当なし";
	}

	/// <summary>
	/// Key: "Label.PriceChangedFrom"
	/// English String: "Price changed from {robuxAmount}"
	/// </summary>
	public override string LabelPriceChangedFrom(string robuxAmount)
	{
		return $"価格が{robuxAmount}から変更されました";
	}

	protected override string _GetTemplateForLabelPriceChangedFrom()
	{
		return "価格が{robuxAmount}から変更されました";
	}

	protected override string _GetTemplateForLabelPurchasingTemporarilyUnavailable()
	{
		return "一時的に購入が利用できません。後でもう一度お試しください。";
	}

	protected override string _GetTemplateForLabelResellers()
	{
		return "再販者";
	}

	protected override string _GetTemplateForLabelRobloxAsset()
	{
		return "Robloxアセット";
	}

	/// <summary>
	/// Key: "Label.SeeMoreResellers"
	/// English String: "See more {resellers}"
	/// </summary>
	public override string LabelSeeMoreResellers(string resellers)
	{
		return $"{resellers} をもっと見る";
	}

	protected override string _GetTemplateForLabelSeeMoreResellers()
	{
		return "{resellers} をもっと見る";
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
		return "外す";
	}

	protected override string _GetTemplateForLabelToInstallOpenStudio()
	{
		return "インストールするには、Roblox Studioでこのページを開いてください。";
	}

	protected override string _GetTemplateForLabelWear()
	{
		return "装備";
	}

	protected override string _GetTemplateForLabelXboxOneExclusiveItem()
	{
		return "Xbox One限定アイテムです。";
	}

	protected override string _GetTemplateForLabelYouAreSelling()
	{
		return "あなたは、このアイテムを販売中です。";
	}
}
