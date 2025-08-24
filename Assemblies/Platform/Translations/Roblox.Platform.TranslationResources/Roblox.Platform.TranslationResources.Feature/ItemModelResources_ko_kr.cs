namespace Roblox.TranslationResources.Feature;

/// <summary>
/// This class overrides ItemModelResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class ItemModelResources_ko_kr : ItemModelResources_en_us, IItemModelResources, ITranslationResources
{
	/// <summary>
	/// Key: "Label.AmazonExclusiveItem"
	/// English String: "This is an Amazon exclusive item."
	/// </summary>
	public override string LabelAmazonExclusiveItem => "Amazon 전용 아이템이에요.";

	/// <summary>
	/// Key: "Label.AudioAssetBlockedCopyright"
	/// English String: "This audio asset has been blocked due to copyright violations.\n"
	/// </summary>
	public override string LabelAudioAssetBlockedCopyright => "본 오디오 애셋은 저작권 위반으로 차단되었습니다.\n";

	/// <summary>
	/// Key: "Label.GooglePlayExclusiveItem"
	/// English String: "This is a Google Play exclusive item."
	/// </summary>
	public override string LabelGooglePlayExclusiveItem => "Google Play 전용 아이템이에요.";

	/// <summary>
	/// Key: "Label.IosDeviceExclusiveItem"
	/// English String: "This is an iOS exclusive item."
	/// </summary>
	public override string LabelIosDeviceExclusiveItem => "iOS 전용 아이템이에요.";

	/// <summary>
	/// Key: "Label.ItemAvailableInventory"
	/// English String: "This item is available in your inventory."
	/// </summary>
	public override string LabelItemAvailableInventory => "본 아이템은 인벤토리에서 찾을 수 있어요.";

	/// <summary>
	/// Key: "Label.ItemHasBeenModerated"
	/// English String: "This item has been moderated."
	/// </summary>
	public override string LabelItemHasBeenModerated => "본 아이템은 검열을 통과하지 못했습니다.";

	/// <summary>
	/// Key: "Label.ItemNoLongerForSale"
	/// English String: "This item is no longer for sale."
	/// </summary>
	public override string LabelItemNoLongerForSale => "본 아이템은 더 이상 판매하지 않습니다.";

	/// <summary>
	/// Key: "Label.ItemNotCurrentlyForSale"
	/// English String: "This item is not currently for sale."
	/// </summary>
	public override string LabelItemNotCurrentlyForSale => "판매 중인 아이템이 아닙니다.";

	/// <summary>
	/// Key: "Label.MobileDeviceExclusiveItem"
	/// English String: "This is a mobile exclusive item."
	/// </summary>
	public override string LabelMobileDeviceExclusiveItem => "모바일 전용 아이템이에요.";

	/// <summary>
	/// Key: "Label.NoDescriptionAvailable"
	/// English String: "No description available."
	/// </summary>
	public override string LabelNoDescriptionAvailable => "설명 없음.";

	/// <summary>
	/// Key: "Label.NoOneCurrentlySelling"
	/// English String: "There is no one currently selling this item."
	/// </summary>
	public override string LabelNoOneCurrentlySelling => "현재 본 아이템을 판매하는 사람이 없어요.";

	/// <summary>
	/// Key: "Label.NoOtherSellers"
	/// English String: "No other sellers."
	/// </summary>
	public override string LabelNoOtherSellers => "다른 판매자가 없습니다.";

	/// <summary>
	/// Key: "Label.NotAvailable"
	/// English String: "N/A"
	/// </summary>
	public override string LabelNotAvailable => "해당 없음";

	/// <summary>
	/// Key: "Label.PurchasingTemporarilyUnavailable"
	/// English String: "Purchasing is temporarily unavailable. Please try again later."
	/// </summary>
	public override string LabelPurchasingTemporarilyUnavailable => "일시적으로 구매할 수 없습니다. 나중에 다시 시도하세요.";

	/// <summary>
	/// Key: "Label.Resellers"
	/// English String: "Resellers"
	/// </summary>
	public override string LabelResellers => "재판매자";

	/// <summary>
	/// Key: "Label.RobloxAsset"
	/// English String: "Roblox Asset"
	/// </summary>
	public override string LabelRobloxAsset => "Roblox 애셋";

	/// <summary>
	/// Key: "Label.TakeOff"
	/// English String: "Take Off"
	/// </summary>
	public override string LabelTakeOff => "해제";

	/// <summary>
	/// Key: "Label.ToInstallOpenStudio"
	/// English String: "To install, open this page in Roblox Studio."
	/// </summary>
	public override string LabelToInstallOpenStudio => "설치하려면 Roblox Studio에서 본 페이지를 여세요.";

	/// <summary>
	/// Key: "Label.Wear"
	/// English String: "Wear"
	/// </summary>
	public override string LabelWear => "착용";

	/// <summary>
	/// Key: "Label.XboxOneExclusiveItem"
	/// English String: "This is a Xbox One exclusive item."
	/// </summary>
	public override string LabelXboxOneExclusiveItem => "Xbox One 전용 아이템이에요.";

	/// <summary>
	/// Key: "Label.YouAreSelling"
	/// English String: "You are selling this item."
	/// </summary>
	public override string LabelYouAreSelling => "회원님이 판매 중인 아이템이에요.";

	public ItemModelResources_ko_kr(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForLabelAmazonExclusiveItem()
	{
		return "Amazon 전용 아이템이에요.";
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
		return $"{assetOption} 빌리기";
	}

	protected override string _GetTemplateForLabelAssetOptionRental()
	{
		return "{assetOption} 빌리기";
	}

	protected override string _GetTemplateForLabelAudioAssetBlockedCopyright()
	{
		return "본 오디오 애셋은 저작권 위반으로 차단되었습니다.\n";
	}

	/// <summary>
	/// Key: "Label.BcRequirementExclusiveItem"
	/// English String: "{bcRequirementName} exclusive item."
	/// </summary>
	public override string LabelBcRequirementExclusiveItem(string bcRequirementName)
	{
		return $"{bcRequirementName} 전용 아이템이에요.";
	}

	protected override string _GetTemplateForLabelBcRequirementExclusiveItem()
	{
		return "{bcRequirementName} 전용 아이템이에요.";
	}

	/// <summary>
	/// Key: "Label.ExpiresRentalTime"
	/// English String: "Expires: {rentalTime}"
	/// </summary>
	public override string LabelExpiresRentalTime(string rentalTime)
	{
		return $"만료: {rentalTime}";
	}

	protected override string _GetTemplateForLabelExpiresRentalTime()
	{
		return "만료: {rentalTime}";
	}

	protected override string _GetTemplateForLabelGooglePlayExclusiveItem()
	{
		return "Google Play 전용 아이템이에요.";
	}

	protected override string _GetTemplateForLabelIosDeviceExclusiveItem()
	{
		return "iOS 전용 아이템이에요.";
	}

	protected override string _GetTemplateForLabelItemAvailableInventory()
	{
		return "본 아이템은 인벤토리에서 찾을 수 있어요.";
	}

	protected override string _GetTemplateForLabelItemHasBeenModerated()
	{
		return "본 아이템은 검열을 통과하지 못했습니다.";
	}

	protected override string _GetTemplateForLabelItemNoLongerForSale()
	{
		return "본 아이템은 더 이상 판매하지 않습니다.";
	}

	protected override string _GetTemplateForLabelItemNotCurrentlyForSale()
	{
		return "판매 중인 아이템이 아닙니다.";
	}

	/// <summary>
	/// Key: "Label.LimitedQuantity"
	/// English String: "Limited quantity: {amount}"
	/// </summary>
	public override string LabelLimitedQuantity(string amount)
	{
		return $"한정 수량: {amount}";
	}

	protected override string _GetTemplateForLabelLimitedQuantity()
	{
		return "한정 수량: {amount}";
	}

	public override string LabelMetaDescriptionCatalog(string assetName, string assetTypeLabel)
	{
		return $"{assetName} 및 수많은 아이템으로 아바타를 마음껏 꾸며보세요. 본 {assetTypeLabel} 및 다른 아이템을 조합하여 나만의 아바타를 만들어보세요!";
	}

	protected override string _GetTemplateForLabelMetaDescriptionCatalog()
	{
		return "{assetName} 및 수많은 아이템으로 아바타를 마음껏 꾸며보세요. 본 {assetTypeLabel} 및 다른 아이템을 조합하여 나만의 아바타를 만들어보세요!";
	}

	/// <summary>
	/// Key: "Label.MetaDescriptionLibrary"
	/// English String: "Use {assetName} and thousands of other {assetTypeLabel} to build an immersive game or experience. Select from a wide range of models, decals, meshes, plugins, or audio that help bring your imagination into reality."
	/// </summary>
	public override string LabelMetaDescriptionLibrary(string assetName, string assetTypeLabel)
	{
		return $"{assetName} 및 다양한 {assetTypeLabel}을(를) 사용하여 흥미진진한 게임이나 콘텐츠를 만들어보세요. 상상을 현실로 만들어 줄 모델, 데칼, 메시, 플러그인 혹은 오디오 파일이 한가득 준비되어 있어요.";
	}

	protected override string _GetTemplateForLabelMetaDescriptionLibrary()
	{
		return "{assetName} 및 다양한 {assetTypeLabel}을(를) 사용하여 흥미진진한 게임이나 콘텐츠를 만들어보세요. 상상을 현실로 만들어 줄 모델, 데칼, 메시, 플러그인 혹은 오디오 파일이 한가득 준비되어 있어요.";
	}

	/// <summary>
	/// Key: "Label.MetaDescriptionLibraryV2"
	/// new text with no asset type
	/// English String: "Use {assetName} and thousands of other assets to build an immersive game or experience. Select from a wide range of models, decals, meshes, plugins, or audio that help bring your imagination into reality."
	/// </summary>
	public override string LabelMetaDescriptionLibraryV2(string assetName)
	{
		return $"{assetName} 및 다양한 애셋을 사용하여 흥미진진한 게임이나 콘텐츠를 만들어보세요. 상상을 현실로 만들어 줄 모델, 데칼, 메시, 플러그인 혹은 오디오 파일이 한가득 준비되어 있어요.";
	}

	protected override string _GetTemplateForLabelMetaDescriptionLibraryV2()
	{
		return "{assetName} 및 다양한 애셋을 사용하여 흥미진진한 게임이나 콘텐츠를 만들어보세요. 상상을 현실로 만들어 줄 모델, 데칼, 메시, 플러그인 혹은 오디오 파일이 한가득 준비되어 있어요.";
	}

	protected override string _GetTemplateForLabelMobileDeviceExclusiveItem()
	{
		return "모바일 전용 아이템이에요.";
	}

	protected override string _GetTemplateForLabelNoDescriptionAvailable()
	{
		return "설명 없음.";
	}

	protected override string _GetTemplateForLabelNoOneCurrentlySelling()
	{
		return "현재 본 아이템을 판매하는 사람이 없어요.";
	}

	protected override string _GetTemplateForLabelNoOtherSellers()
	{
		return "다른 판매자가 없습니다.";
	}

	protected override string _GetTemplateForLabelNotAvailable()
	{
		return "해당 없음";
	}

	/// <summary>
	/// Key: "Label.PriceChangedFrom"
	/// English String: "Price changed from {robuxAmount}"
	/// </summary>
	public override string LabelPriceChangedFrom(string robuxAmount)
	{
		return $"가격 변경됨 - 원래 가격: {robuxAmount}";
	}

	protected override string _GetTemplateForLabelPriceChangedFrom()
	{
		return "가격 변경됨 - 원래 가격: {robuxAmount}";
	}

	protected override string _GetTemplateForLabelPurchasingTemporarilyUnavailable()
	{
		return "일시적으로 구매할 수 없습니다. 나중에 다시 시도하세요.";
	}

	protected override string _GetTemplateForLabelResellers()
	{
		return "재판매자";
	}

	protected override string _GetTemplateForLabelRobloxAsset()
	{
		return "Roblox 애셋";
	}

	/// <summary>
	/// Key: "Label.SeeMoreResellers"
	/// English String: "See more {resellers}"
	/// </summary>
	public override string LabelSeeMoreResellers(string resellers)
	{
		return $"{resellers} 더 보기";
	}

	protected override string _GetTemplateForLabelSeeMoreResellers()
	{
		return "{resellers} 더 보기";
	}

	/// <summary>
	/// Key: "Label.SerialNoOf"
	/// English String: "{serial} of {total}"
	/// </summary>
	public override string LabelSerialNoOf(string serial, string total)
	{
		return $"{serial} / {total}";
	}

	protected override string _GetTemplateForLabelSerialNoOf()
	{
		return "{serial} / {total}";
	}

	protected override string _GetTemplateForLabelTakeOff()
	{
		return "해제";
	}

	protected override string _GetTemplateForLabelToInstallOpenStudio()
	{
		return "설치하려면 Roblox Studio에서 본 페이지를 여세요.";
	}

	protected override string _GetTemplateForLabelWear()
	{
		return "착용";
	}

	protected override string _GetTemplateForLabelXboxOneExclusiveItem()
	{
		return "Xbox One 전용 아이템이에요.";
	}

	protected override string _GetTemplateForLabelYouAreSelling()
	{
		return "회원님이 판매 중인 아이템이에요.";
	}
}
