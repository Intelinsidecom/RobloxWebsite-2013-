namespace Roblox.TranslationResources.Feature;

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
	public override string LabelAmazonExclusiveItem => "这是 Amazon 专属物品。";

	/// <summary>
	/// Key: "Label.AudioAssetBlockedCopyright"
	/// English String: "This audio asset has been blocked due to copyright violations.\n"
	/// </summary>
	public override string LabelAudioAssetBlockedCopyright => "因侵犯版权，此音频素材已被屏蔽。\n";

	/// <summary>
	/// Key: "Label.GooglePlayExclusiveItem"
	/// English String: "This is a Google Play exclusive item."
	/// </summary>
	public override string LabelGooglePlayExclusiveItem => "这是 Google Play 专属物品。";

	/// <summary>
	/// Key: "Label.IosDeviceExclusiveItem"
	/// English String: "This is an iOS exclusive item."
	/// </summary>
	public override string LabelIosDeviceExclusiveItem => "这是 iOS 专属物品。";

	/// <summary>
	/// Key: "Label.ItemAvailableInventory"
	/// English String: "This item is available in your inventory."
	/// </summary>
	public override string LabelItemAvailableInventory => "此物品在你的道具栏中。";

	/// <summary>
	/// Key: "Label.ItemHasBeenModerated"
	/// English String: "This item has been moderated."
	/// </summary>
	public override string LabelItemHasBeenModerated => "此物品已被过滤。";

	/// <summary>
	/// Key: "Label.ItemNoLongerForSale"
	/// English String: "This item is no longer for sale."
	/// </summary>
	public override string LabelItemNoLongerForSale => "此物品已停止出售。";

	/// <summary>
	/// Key: "Label.ItemNotCurrentlyForSale"
	/// English String: "This item is not currently for sale."
	/// </summary>
	public override string LabelItemNotCurrentlyForSale => "此物品目前为非卖品。";

	/// <summary>
	/// Key: "Label.MobileDeviceExclusiveItem"
	/// English String: "This is a mobile exclusive item."
	/// </summary>
	public override string LabelMobileDeviceExclusiveItem => "这是移动设备专属物品。";

	/// <summary>
	/// Key: "Label.NoDescriptionAvailable"
	/// English String: "No description available."
	/// </summary>
	public override string LabelNoDescriptionAvailable => "无可用描述。";

	/// <summary>
	/// Key: "Label.NoOneCurrentlySelling"
	/// English String: "There is no one currently selling this item."
	/// </summary>
	public override string LabelNoOneCurrentlySelling => "目前没有人出售此物品。";

	/// <summary>
	/// Key: "Label.NoOtherSellers"
	/// English String: "No other sellers."
	/// </summary>
	public override string LabelNoOtherSellers => "无其他卖家。";

	/// <summary>
	/// Key: "Label.NotAvailable"
	/// English String: "N/A"
	/// </summary>
	public override string LabelNotAvailable => "无";

	/// <summary>
	/// Key: "Label.PurchasingTemporarilyUnavailable"
	/// English String: "Purchasing is temporarily unavailable. Please try again later."
	/// </summary>
	public override string LabelPurchasingTemporarilyUnavailable => "暂时无法购买。请稍后重试。";

	/// <summary>
	/// Key: "Label.Resellers"
	/// English String: "Resellers"
	/// </summary>
	public override string LabelResellers => "转售者";

	/// <summary>
	/// Key: "Label.RobloxAsset"
	/// English String: "Roblox Asset"
	/// </summary>
	public override string LabelRobloxAsset => "Roblox 素材";

	/// <summary>
	/// Key: "Label.TakeOff"
	/// English String: "Take Off"
	/// </summary>
	public override string LabelTakeOff => "脱下";

	/// <summary>
	/// Key: "Label.ToInstallOpenStudio"
	/// English String: "To install, open this page in Roblox Studio."
	/// </summary>
	public override string LabelToInstallOpenStudio => "若要安装，请在 Roblox Studio 中打开此页面。";

	/// <summary>
	/// Key: "Label.Wear"
	/// English String: "Wear"
	/// </summary>
	public override string LabelWear => "穿戴";

	/// <summary>
	/// Key: "Label.XboxOneExclusiveItem"
	/// English String: "This is a Xbox One exclusive item."
	/// </summary>
	public override string LabelXboxOneExclusiveItem => "这是 Xbox One 专属物品。";

	/// <summary>
	/// Key: "Label.YouAreSelling"
	/// English String: "You are selling this item."
	/// </summary>
	public override string LabelYouAreSelling => "你正出售此物品。";

	public ItemModelResources_zh_cn(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForLabelAmazonExclusiveItem()
	{
		return "这是 Amazon 专属物品。";
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
		return $"{assetOption} 租用";
	}

	protected override string _GetTemplateForLabelAssetOptionRental()
	{
		return "{assetOption} 租用";
	}

	protected override string _GetTemplateForLabelAudioAssetBlockedCopyright()
	{
		return "因侵犯版权，此音频素材已被屏蔽。\n";
	}

	/// <summary>
	/// Key: "Label.BcRequirementExclusiveItem"
	/// English String: "{bcRequirementName} exclusive item."
	/// </summary>
	public override string LabelBcRequirementExclusiveItem(string bcRequirementName)
	{
		return $"{bcRequirementName} 专属物品。";
	}

	protected override string _GetTemplateForLabelBcRequirementExclusiveItem()
	{
		return "{bcRequirementName} 专属物品。";
	}

	/// <summary>
	/// Key: "Label.ExpiresRentalTime"
	/// English String: "Expires: {rentalTime}"
	/// </summary>
	public override string LabelExpiresRentalTime(string rentalTime)
	{
		return $"失效时间：{rentalTime}";
	}

	protected override string _GetTemplateForLabelExpiresRentalTime()
	{
		return "失效时间：{rentalTime}";
	}

	protected override string _GetTemplateForLabelGooglePlayExclusiveItem()
	{
		return "这是 Google Play 专属物品。";
	}

	protected override string _GetTemplateForLabelIosDeviceExclusiveItem()
	{
		return "这是 iOS 专属物品。";
	}

	protected override string _GetTemplateForLabelItemAvailableInventory()
	{
		return "此物品在你的道具栏中。";
	}

	protected override string _GetTemplateForLabelItemHasBeenModerated()
	{
		return "此物品已被过滤。";
	}

	protected override string _GetTemplateForLabelItemNoLongerForSale()
	{
		return "此物品已停止出售。";
	}

	protected override string _GetTemplateForLabelItemNotCurrentlyForSale()
	{
		return "此物品目前为非卖品。";
	}

	/// <summary>
	/// Key: "Label.LimitedQuantity"
	/// English String: "Limited quantity: {amount}"
	/// </summary>
	public override string LabelLimitedQuantity(string amount)
	{
		return $"限定数量：{amount}";
	}

	protected override string _GetTemplateForLabelLimitedQuantity()
	{
		return "限定数量：{amount}";
	}

	public override string LabelMetaDescriptionCatalog(string assetName, string assetTypeLabel)
	{
		return $"使用{assetName}和上百万种其他物品来自定义你的虚拟形象。混搭{assetTypeLabel}及其他物品，打造独一无二的虚拟形象！";
	}

	protected override string _GetTemplateForLabelMetaDescriptionCatalog()
	{
		return "使用{assetName}和上百万种其他物品来自定义你的虚拟形象。混搭{assetTypeLabel}及其他物品，打造独一无二的虚拟形象！";
	}

	/// <summary>
	/// Key: "Label.MetaDescriptionLibrary"
	/// English String: "Use {assetName} and thousands of other {assetTypeLabel} to build an immersive game or experience. Select from a wide range of models, decals, meshes, plugins, or audio that help bring your imagination into reality."
	/// </summary>
	public override string LabelMetaDescriptionLibrary(string assetName, string assetTypeLabel)
	{
		return $"使用“{assetName}”和上千种其他“{assetTypeLabel}”打造身临其境的游戏或体验。你可以从多种模型、贴花、网格、插件或音频中进行选择，将想象化为现实。";
	}

	protected override string _GetTemplateForLabelMetaDescriptionLibrary()
	{
		return "使用“{assetName}”和上千种其他“{assetTypeLabel}”打造身临其境的游戏或体验。你可以从多种模型、贴花、网格、插件或音频中进行选择，将想象化为现实。";
	}

	/// <summary>
	/// Key: "Label.MetaDescriptionLibraryV2"
	/// new text with no asset type
	/// English String: "Use {assetName} and thousands of other assets to build an immersive game or experience. Select from a wide range of models, decals, meshes, plugins, or audio that help bring your imagination into reality."
	/// </summary>
	public override string LabelMetaDescriptionLibraryV2(string assetName)
	{
		return $"使用“{assetName}”和上千种其他素材来打造身临其境的游戏或体验。你可以从多种模型、贴花、网格、插件或音频中进行选择，将想象化为现实。";
	}

	protected override string _GetTemplateForLabelMetaDescriptionLibraryV2()
	{
		return "使用“{assetName}”和上千种其他素材来打造身临其境的游戏或体验。你可以从多种模型、贴花、网格、插件或音频中进行选择，将想象化为现实。";
	}

	protected override string _GetTemplateForLabelMobileDeviceExclusiveItem()
	{
		return "这是移动设备专属物品。";
	}

	protected override string _GetTemplateForLabelNoDescriptionAvailable()
	{
		return "无可用描述。";
	}

	protected override string _GetTemplateForLabelNoOneCurrentlySelling()
	{
		return "目前没有人出售此物品。";
	}

	protected override string _GetTemplateForLabelNoOtherSellers()
	{
		return "无其他卖家。";
	}

	protected override string _GetTemplateForLabelNotAvailable()
	{
		return "无";
	}

	/// <summary>
	/// Key: "Label.PriceChangedFrom"
	/// English String: "Price changed from {robuxAmount}"
	/// </summary>
	public override string LabelPriceChangedFrom(string robuxAmount)
	{
		return $"价格已从 {robuxAmount} 更改";
	}

	protected override string _GetTemplateForLabelPriceChangedFrom()
	{
		return "价格已从 {robuxAmount} 更改";
	}

	protected override string _GetTemplateForLabelPurchasingTemporarilyUnavailable()
	{
		return "暂时无法购买。请稍后重试。";
	}

	protected override string _GetTemplateForLabelResellers()
	{
		return "转售者";
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
		return $"{serial}/共 {total}";
	}

	protected override string _GetTemplateForLabelSerialNoOf()
	{
		return "{serial}/共 {total}";
	}

	protected override string _GetTemplateForLabelTakeOff()
	{
		return "脱下";
	}

	protected override string _GetTemplateForLabelToInstallOpenStudio()
	{
		return "若要安装，请在 Roblox Studio 中打开此页面。";
	}

	protected override string _GetTemplateForLabelWear()
	{
		return "穿戴";
	}

	protected override string _GetTemplateForLabelXboxOneExclusiveItem()
	{
		return "这是 Xbox One 专属物品。";
	}

	protected override string _GetTemplateForLabelYouAreSelling()
	{
		return "你正出售此物品。";
	}
}
