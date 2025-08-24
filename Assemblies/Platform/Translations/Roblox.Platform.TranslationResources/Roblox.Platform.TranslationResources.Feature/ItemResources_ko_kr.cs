namespace Roblox.TranslationResources.Feature;

/// <summary>
/// This class overrides ItemResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class ItemResources_ko_kr : ItemResources_en_us, IItemResources, ITranslationResources
{
	/// <summary>
	/// Key: "Action.Add"
	/// button label
	/// English String: "Add"
	/// </summary>
	public override string ActionAdd => "추가";

	/// <summary>
	/// Key: "Action.AddToGame"
	/// English String: "Add To Game"
	/// </summary>
	public override string ActionAddToGame => "게임에 추가";

	/// <summary>
	/// Key: "Action.AddToProfile"
	/// English String: "Add to Profile"
	/// </summary>
	public override string ActionAddToProfile => "프로필에 추가";

	/// <summary>
	/// Key: "Action.Advertise"
	/// English String: "Advertise"
	/// </summary>
	public override string ActionAdvertise => "광고";

	/// <summary>
	/// Key: "Action.Agree"
	/// button label
	/// English String: "Agree"
	/// </summary>
	public override string ActionAgree => "동의";

	/// <summary>
	/// Key: "Action.Buy"
	/// English String: "Buy"
	/// </summary>
	public override string ActionBuy => "구매";

	/// <summary>
	/// Key: "Action.Cancel"
	/// Cancel
	/// English String: "Cancel"
	/// </summary>
	public override string ActionCancel => "취소";

	/// <summary>
	/// Key: "Action.Configure"
	/// English String: "Configure"
	/// </summary>
	public override string ActionConfigure => "구성";

	/// <summary>
	/// Key: "Action.Confirm"
	/// button label
	/// English String: "Confirm"
	/// </summary>
	public override string ActionConfirm => "확인";

	/// <summary>
	/// Key: "Action.Delete"
	/// English String: "Delete"
	/// </summary>
	public override string ActionDelete => "삭제";

	/// <summary>
	/// Key: "Action.DisableBadge"
	/// English String: "Disable Badge"
	/// </summary>
	public override string ActionDisableBadge => "배지 비활성화";

	/// <summary>
	/// Key: "Action.EditAvatar"
	/// English String: "Edit Avatar"
	/// </summary>
	public override string ActionEditAvatar => "아바타 편집";

	/// <summary>
	/// Key: "Action.EnableBadge"
	/// English String: "Enable Badge"
	/// </summary>
	public override string ActionEnableBadge => "배지 활성화";

	/// <summary>
	/// Key: "Action.Get"
	/// English String: "Get"
	/// </summary>
	public override string ActionGet => "획득";

	/// <summary>
	/// Key: "Action.Install"
	/// English String: "Install"
	/// </summary>
	public override string ActionInstall => "설치";

	/// <summary>
	/// Key: "Action.Inventory"
	/// English String: "Inventory"
	/// </summary>
	public override string ActionInventory => "인벤토리";

	/// <summary>
	/// Key: "Action.No"
	/// button label
	/// English String: "No"
	/// </summary>
	public override string ActionNo => "아니요";

	/// <summary>
	/// Key: "Action.Ok"
	/// button label
	/// English String: "OK"
	/// </summary>
	public override string ActionOk => "확인";

	/// <summary>
	/// Key: "Action.Remove"
	/// English String: "Remove"
	/// </summary>
	public override string ActionRemove => "제거";

	/// <summary>
	/// Key: "Action.RemoveFromProfile"
	/// English String: "Remove from Profile"
	/// </summary>
	public override string ActionRemoveFromProfile => "프로필에서 삭제";

	/// <summary>
	/// Key: "Action.Rent"
	/// English String: "Rent"
	/// </summary>
	public override string ActionRent => "빌리기";

	/// <summary>
	/// Key: "Action.ReportItem"
	/// English String: "Report Item"
	/// </summary>
	public override string ActionReportItem => "아이템 신고";

	/// <summary>
	/// Key: "Action.Sell"
	/// English String: "Sell"
	/// </summary>
	public override string ActionSell => "판매";

	/// <summary>
	/// Key: "Action.SellNow"
	/// Sell Now
	/// English String: "Sell Now"
	/// </summary>
	public override string ActionSellNow => "지금 판매";

	/// <summary>
	/// Key: "Action.TakeOff"
	/// Action on context menu on owned item detail page.
	/// English String: "Take Off"
	/// </summary>
	public override string ActionTakeOff => "해제";

	/// <summary>
	/// Key: "Action.TakeOffSale"
	/// English String: "Take Off Sale"
	/// </summary>
	public override string ActionTakeOffSale => "판매 중단";

	/// <summary>
	/// Key: "Action.TryOn"
	/// English String: "Try On"
	/// </summary>
	public override string ActionTryOn => "장착해 보기";

	/// <summary>
	/// Key: "Action.Upgrade"
	/// English String: "Upgrade"
	/// </summary>
	public override string ActionUpgrade => "업그레이드";

	/// <summary>
	/// Key: "Action.Wear"
	/// Action on context menu on owned item
	/// English String: "Wear"
	/// </summary>
	public override string ActionWear => "착용";

	/// <summary>
	/// Key: "Action.Yes"
	/// Yes
	/// English String: "Yes"
	/// </summary>
	public override string ActionYes => "예";

	/// <summary>
	/// Key: "Heading.IncludedItems"
	/// Included items for a bundle of items. User purchases a bundle and will receive all items that will show below this heading.
	/// English String: "Included Items"
	/// </summary>
	public override string HeadingIncludedItems => "포함된 아이템";

	/// <summary>
	/// Key: "Heading.PromoteItem"
	/// dialog heading
	/// English String: "Promote Item"
	/// </summary>
	public override string HeadingPromoteItem => "아이템 홍보";

	/// <summary>
	/// Key: "Label.AssetGrantedModalAcceptText"
	/// English String: "OK"
	/// </summary>
	public override string LabelAssetGrantedModalAcceptText => "확인";

	/// <summary>
	/// Key: "Label.AssetGrantedModalMessage"
	/// English String: "You just got this item courtesy of our sponsor."
	/// </summary>
	public override string LabelAssetGrantedModalMessage => "스폰서 서비스로 본 아이템이 지급되었어요.";

	/// <summary>
	/// Key: "Label.AssetGrantedModalTitle"
	/// English String: "This item is now yours"
	/// </summary>
	public override string LabelAssetGrantedModalTitle => "이제 회원님의 아이템이예요";

	/// <summary>
	/// Key: "Label.Attributes"
	/// English String: "Attributes"
	/// </summary>
	public override string LabelAttributes => "속성";

	/// <summary>
	/// Key: "Label.BestPrice"
	/// English String: "Best Price"
	/// </summary>
	public override string LabelBestPrice => "최저 가격";

	/// <summary>
	/// Key: "Label.BuildersClubExclusive"
	/// label for Builders Club requirement
	/// English String: "Builders Club exclusive."
	/// </summary>
	public override string LabelBuildersClubExclusive => "Builders Club 전용이에요.";

	/// <summary>
	/// Key: "Label.DeleteFromInventoryConfirm"
	/// confirmation message before deletion
	/// English String: "Are you sure you want to permanently DELETE this item from your inventory?"
	/// </summary>
	public override string LabelDeleteFromInventoryConfirm => "본 아이템을 정말 인벤토리에서 영구 삭제하시겠습니까?";

	/// <summary>
	/// Key: "Label.DeleteItem"
	/// Delete Item
	/// English String: "Delete Item"
	/// </summary>
	public override string LabelDeleteItem => "아이템 삭제";

	/// <summary>
	/// Key: "Label.Description"
	/// English String: "Description"
	/// </summary>
	public override string LabelDescription => "설명";

	/// <summary>
	/// Key: "Label.DisableBadgeConfirm"
	/// Are you sure you want to disable this Badge?
	/// English String: "Are you sure you want to disable this Badge?"
	/// </summary>
	public override string LabelDisableBadgeConfirm => "본 배지를 정말 비활성화하시겠습니까?";

	/// <summary>
	/// Key: "Label.DiscontinuedItem"
	/// label
	/// English String: "Discontinued item, resellable."
	/// </summary>
	public override string LabelDiscontinuedItem => "판매 중단 아이템 (재판매 가능)";

	/// <summary>
	/// Key: "Label.EnableBadgeConfirm"
	/// Are you sure you want to enable this Badge?
	/// English String: "Are you sure you want to enable this Badge?"
	/// </summary>
	public override string LabelEnableBadgeConfirm => "본 배지를 정말 활성화하시겠습니까?";

	/// <summary>
	/// Key: "Label.ErrorOccurred"
	/// English String: "Error occurred"
	/// </summary>
	public override string LabelErrorOccurred => "오류 발생";

	/// <summary>
	/// Key: "Label.Free"
	/// English String: "Free"
	/// </summary>
	public override string LabelFree => "무료";

	/// <summary>
	/// Key: "Label.Genres"
	/// English String: "Genres"
	/// </summary>
	public override string LabelGenres => "장르";

	/// <summary>
	/// Key: "Label.GetBuildersClub"
	/// Only Builders Club members can re-sell collectible items. Get Builders Club today!
	/// English String: "Only Builders Club members can re-sell collectible items. Get Builders Club today!"
	/// </summary>
	public override string LabelGetBuildersClub => "Builders Club 멤버만 한정판 아이템을 재판매할 수 있어요. 지금 Builders Club에 가입하세요!";

	/// <summary>
	/// Key: "Label.GetPremiumMembership"
	/// English String: "Only Premium members can re-sell collectible items. Get Premium today!"
	/// </summary>
	public override string LabelGetPremiumMembership => "Premium 멤버만 한정판 아이템을 재판매할 수 있어요. 지금 Premium에 가입하세요!";

	/// <summary>
	/// Key: "Label.InvalidPlace"
	/// text label
	/// English String: "Invalid Place."
	/// </summary>
	public override string LabelInvalidPlace => "잘못된 장소예요.";

	/// <summary>
	/// Key: "Label.InvalidProduct"
	/// label
	/// English String: "Invalid Product."
	/// </summary>
	public override string LabelInvalidProduct => "유효하지 않은 상품.";

	/// <summary>
	/// Key: "Label.ItemAvailable"
	/// User is looking at the details of an item which they already own in their inventory.
	/// English String: "This item is available in your inventory."
	/// </summary>
	public override string LabelItemAvailable => "본 아이템은 인벤토리에서 찾을 수 있어요.";

	/// <summary>
	/// Key: "Label.ItemNotForSale"
	/// User is looking at the details of an item that cannot be purchased.
	/// English String: "This item is not currently for sale."
	/// </summary>
	public override string LabelItemNotForSale => "판매 중인 아이템이 아닙니다.";

	/// <summary>
	/// Key: "Label.ItemOwned"
	/// English String: "Item Owned"
	/// </summary>
	public override string LabelItemOwned => "보유 아이템";

	/// <summary>
	/// Key: "Label.None"
	/// English String: "None"
	/// </summary>
	public override string LabelNone => "없음";

	/// <summary>
	/// Key: "Label.NotAvailable"
	/// English String: "N/A"
	/// </summary>
	public override string LabelNotAvailable => "해당 없음";

	/// <summary>
	/// Key: "Label.Price"
	/// English String: "Price"
	/// </summary>
	public override string LabelPrice => "가격";

	/// <summary>
	/// Key: "Label.PriceIsInvalid"
	/// English String: "Price is invalid"
	/// </summary>
	public override string LabelPriceIsInvalid => "유효하지 않은 가격입니다";

	/// <summary>
	/// Key: "Label.PriceMinimumOne"
	/// English String: "Price (minimum 1)"
	/// </summary>
	public override string LabelPriceMinimumOne => "가격 (최소 1)";

	/// <summary>
	/// Key: "Label.PurchaseCompleted"
	/// English String: "Purchase Completed"
	/// </summary>
	public override string LabelPurchaseCompleted => "구매 완료";

	/// <summary>
	/// Key: "Label.Rarity"
	/// English String: "Rarity"
	/// </summary>
	public override string LabelRarity => "희귀도";

	/// <summary>
	/// Key: "Label.ReadMore"
	/// English String: "Read More"
	/// </summary>
	public override string LabelReadMore => "더 보기";

	/// <summary>
	/// Key: "Label.RentingItem"
	/// English String: "Renting Item"
	/// </summary>
	public override string LabelRentingItem => "아이템 빌리는 중";

	/// <summary>
	/// Key: "Label.Rthro"
	/// "Anthro" but replace the beginning with "R" to be consistent with "R6" and "R16"
	/// English String: "Rthro"
	/// </summary>
	public override string LabelRthro => "Rthro";

	/// <summary>
	/// Key: "Label.SellYourCollectibleItem"
	/// Sell Your Collectible Item
	/// English String: "Sell Your Collectible Item"
	/// </summary>
	public override string LabelSellYourCollectibleItem => "한정판 아이템 판매";

	/// <summary>
	/// Key: "Label.SerializedLimitedRelease"
	/// label
	/// English String: "Serialized limited release, resellable."
	/// </summary>
	public override string LabelSerializedLimitedRelease => "한정판 시리즈 (재판매 가능)";

	/// <summary>
	/// Key: "Label.SerialNotAvailable"
	/// English String: "Serial N/A"
	/// </summary>
	public override string LabelSerialNotAvailable => "일련번호 없음";

	/// <summary>
	/// Key: "Label.SerialNumber"
	/// English String: "Serial Number"
	/// </summary>
	public override string LabelSerialNumber => "일련번호";

	/// <summary>
	/// Key: "Label.ShowLess"
	/// Show Less
	/// English String: "Show Less"
	/// </summary>
	public override string LabelShowLess => "간략히 보기";

	/// <summary>
	/// Key: "Label.Tags"
	/// A label to indicate a list of tags on an item (i.e. "red, belt, shoes, denim" could be some tags for a Pants item that was red jeans with a belt and shoes)
	/// English String: "Tags"
	/// </summary>
	public override string LabelTags => "태그";

	/// <summary>
	/// Key: "Label.TakeOffSale"
	/// Take off Sale
	/// English String: "Take off Sale"
	/// </summary>
	public override string LabelTakeOffSale => "판매 중단";

	/// <summary>
	/// Key: "Label.TakeOffSaleConfirm"
	/// English String: "Are you sure you want to take the item off sale?"
	/// </summary>
	public override string LabelTakeOffSaleConfirm => "아이템 판매를 정말 중단하시겠습니까?";

	/// <summary>
	/// Key: "Label.ThirteenPlusOnly"
	/// label
	/// English String: "13+ Only."
	/// </summary>
	public override string LabelThirteenPlusOnly => "13+ 전용.";

	/// <summary>
	/// Key: "Label.Type"
	/// English String: "Type"
	/// </summary>
	public override string LabelType => "종류";

	/// <summary>
	/// Key: "Label.Updated"
	/// English String: "Updated"
	/// </summary>
	public override string LabelUpdated => "업데이트";

	/// <summary>
	/// Key: "Label.YouGet"
	/// Amount user gets after Marketplace fee deduction.
	/// English String: "You get"
	/// </summary>
	public override string LabelYouGet => "획득:";

	/// <summary>
	/// Key: "Response.AddedToProfile"
	/// success message when item is added to profile
	/// English String: "Added to your profile"
	/// </summary>
	public override string ResponseAddedToProfile => "프로필에 추가했습니다";

	/// <summary>
	/// Key: "Response.AddedToYourAvater"
	/// Added to your Avatar
	/// English String: "Added to your Avatar"
	/// </summary>
	public override string ResponseAddedToYourAvater => "아바타에 추가했습니다";

	/// <summary>
	/// Key: "Response.AlreadyHaveMaxItems"
	/// error message
	/// English String: "You already have the maximum number of items on your game!"
	/// </summary>
	public override string ResponseAlreadyHaveMaxItems => "게임에 적용한 아이템의 수가 이미 한도에 도달했어요!";

	/// <summary>
	/// Key: "Response.DisabledBadge"
	/// Successfully disabled the badge
	/// English String: "Successfully disabled the badge"
	/// </summary>
	public override string ResponseDisabledBadge => "배지 비활성화 완료";

	/// <summary>
	/// Key: "Response.EnabledBadge"
	/// Successfully enabled the badge
	/// English String: "Successfully enabled the badge"
	/// </summary>
	public override string ResponseEnabledBadge => "배지 활성화 완료";

	/// <summary>
	/// Key: "Response.FailedToAddToProfile"
	/// error message when item could not be added to profile
	/// English String: "Failed to add to profile"
	/// </summary>
	public override string ResponseFailedToAddToProfile => "프로필에 추가하지 못했습니다";

	/// <summary>
	/// Key: "Response.FailedToDeleteFromInventory"
	/// Failed to delete item from inventory
	/// English String: "Failed to delete item from inventory"
	/// </summary>
	public override string ResponseFailedToDeleteFromInventory => "인벤토리에서 아이템을 삭제하지 못했습니다";

	/// <summary>
	/// Key: "Response.FailedToDisableBadge"
	/// Failed to disable badge
	/// English String: "Failed to disable badge"
	/// </summary>
	public override string ResponseFailedToDisableBadge => "배지 비활성화 실패";

	/// <summary>
	/// Key: "Response.FailedToEnableBadge"
	/// Failed to enable badge
	/// English String: "Failed to enable badge"
	/// </summary>
	public override string ResponseFailedToEnableBadge => "배지 활성화 실패";

	/// <summary>
	/// Key: "Response.FailedToRemoveFromProfile"
	/// error message when items could not be removed
	/// English String: "Failed to remove from profile"
	/// </summary>
	public override string ResponseFailedToRemoveFromProfile => "프로필에서 삭제하지 못했습니다";

	/// <summary>
	/// Key: "Response.RemovedFromInventory"
	/// Successfully removed from your inventory
	/// English String: "Successfully removed from your inventory"
	/// </summary>
	public override string ResponseRemovedFromInventory => "인벤토리에서 삭제했습니다";

	/// <summary>
	/// Key: "Response.RemovedFromProfile"
	/// message when an item is removed from profile
	/// English String: "Removed from your profile"
	/// </summary>
	public override string ResponseRemovedFromProfile => "프로필에서 삭제했습니다";

	/// <summary>
	/// Key: "Response.RemovedFromYourAvater"
	/// Removed from your Avatar
	/// English String: "Removed from your Avatar"
	/// </summary>
	public override string ResponseRemovedFromYourAvater => "아바타에서 삭제했습니다";

	public ItemResources_ko_kr(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionAdd()
	{
		return "추가";
	}

	protected override string _GetTemplateForActionAddToGame()
	{
		return "게임에 추가";
	}

	protected override string _GetTemplateForActionAddToProfile()
	{
		return "프로필에 추가";
	}

	protected override string _GetTemplateForActionAdvertise()
	{
		return "광고";
	}

	protected override string _GetTemplateForActionAgree()
	{
		return "동의";
	}

	protected override string _GetTemplateForActionBuy()
	{
		return "구매";
	}

	protected override string _GetTemplateForActionCancel()
	{
		return "취소";
	}

	protected override string _GetTemplateForActionConfigure()
	{
		return "구성";
	}

	protected override string _GetTemplateForActionConfirm()
	{
		return "확인";
	}

	protected override string _GetTemplateForActionDelete()
	{
		return "삭제";
	}

	protected override string _GetTemplateForActionDisableBadge()
	{
		return "배지 비활성화";
	}

	protected override string _GetTemplateForActionEditAvatar()
	{
		return "아바타 편집";
	}

	protected override string _GetTemplateForActionEnableBadge()
	{
		return "배지 활성화";
	}

	protected override string _GetTemplateForActionGet()
	{
		return "획득";
	}

	protected override string _GetTemplateForActionInstall()
	{
		return "설치";
	}

	protected override string _GetTemplateForActionInventory()
	{
		return "인벤토리";
	}

	protected override string _GetTemplateForActionNo()
	{
		return "아니요";
	}

	protected override string _GetTemplateForActionOk()
	{
		return "확인";
	}

	protected override string _GetTemplateForActionRemove()
	{
		return "제거";
	}

	protected override string _GetTemplateForActionRemoveFromProfile()
	{
		return "프로필에서 삭제";
	}

	protected override string _GetTemplateForActionRent()
	{
		return "빌리기";
	}

	protected override string _GetTemplateForActionReportItem()
	{
		return "아이템 신고";
	}

	protected override string _GetTemplateForActionSell()
	{
		return "판매";
	}

	protected override string _GetTemplateForActionSellNow()
	{
		return "지금 판매";
	}

	protected override string _GetTemplateForActionTakeOff()
	{
		return "해제";
	}

	protected override string _GetTemplateForActionTakeOffSale()
	{
		return "판매 중단";
	}

	protected override string _GetTemplateForActionTryOn()
	{
		return "장착해 보기";
	}

	protected override string _GetTemplateForActionUpgrade()
	{
		return "업그레이드";
	}

	protected override string _GetTemplateForActionWear()
	{
		return "착용";
	}

	protected override string _GetTemplateForActionYes()
	{
		return "예";
	}

	protected override string _GetTemplateForHeadingIncludedItems()
	{
		return "포함된 아이템";
	}

	protected override string _GetTemplateForHeadingPromoteItem()
	{
		return "아이템 홍보";
	}

	/// <summary>
	/// Key: "Label.AllowPlayersPlusEarn"
	/// English String: "Allow players to use this gear inside your game plus earn {affiliateSaleTotal} when it's purchased from your game page."
	/// </summary>
	public override string LabelAllowPlayersPlusEarn(string affiliateSaleTotal)
	{
		return $"사용자들이 본 장비를 회원님의 게임에서 사용할 수 있도록 추가해보세요. 사용자가 회원님의 게임 페이지에서 본 장비를 구매시, {affiliateSaleTotal}을(를) 획득할 수 있습니다.";
	}

	protected override string _GetTemplateForLabelAllowPlayersPlusEarn()
	{
		return "사용자들이 본 장비를 회원님의 게임에서 사용할 수 있도록 추가해보세요. 사용자가 회원님의 게임 페이지에서 본 장비를 구매시, {affiliateSaleTotal}을(를) 획득할 수 있습니다.";
	}

	protected override string _GetTemplateForLabelAssetGrantedModalAcceptText()
	{
		return "확인";
	}

	protected override string _GetTemplateForLabelAssetGrantedModalMessage()
	{
		return "스폰서 서비스로 본 아이템이 지급되었어요.";
	}

	protected override string _GetTemplateForLabelAssetGrantedModalTitle()
	{
		return "이제 회원님의 아이템이예요";
	}

	protected override string _GetTemplateForLabelAttributes()
	{
		return "속성";
	}

	protected override string _GetTemplateForLabelBestPrice()
	{
		return "최저 가격";
	}

	protected override string _GetTemplateForLabelBuildersClubExclusive()
	{
		return "Builders Club 전용이에요.";
	}

	/// <summary>
	/// Key: "Label.By"
	/// English String: "By {creator}"
	/// </summary>
	public override string LabelBy(string creator)
	{
		return $"개발자: {creator}";
	}

	protected override string _GetTemplateForLabelBy()
	{
		return "개발자: {creator}";
	}

	/// <summary>
	/// Key: "Label.CountdownTimerDayHourMinute"
	/// Item will go offsale in a variable number of days (d), hours (h), and minutes (m). Please use a narrow translation if possible for d/h/m.
	/// English String: "Offsale in {numberOfDays} d {numberOfHours} h {numberOfMinutes} m"
	/// </summary>
	public override string LabelCountdownTimerDayHourMinute(string numberOfDays, string numberOfHours, string numberOfMinutes)
	{
		return $"{numberOfDays}일 {numberOfHours}시간 {numberOfMinutes}분 후 판매 중단";
	}

	protected override string _GetTemplateForLabelCountdownTimerDayHourMinute()
	{
		return "{numberOfDays}일 {numberOfHours}시간 {numberOfMinutes}분 후 판매 중단";
	}

	protected override string _GetTemplateForLabelDeleteFromInventoryConfirm()
	{
		return "본 아이템을 정말 인벤토리에서 영구 삭제하시겠습니까?";
	}

	protected override string _GetTemplateForLabelDeleteItem()
	{
		return "아이템 삭제";
	}

	protected override string _GetTemplateForLabelDescription()
	{
		return "설명";
	}

	protected override string _GetTemplateForLabelDisableBadgeConfirm()
	{
		return "본 배지를 정말 비활성화하시겠습니까?";
	}

	protected override string _GetTemplateForLabelDiscontinuedItem()
	{
		return "판매 중단 아이템 (재판매 가능)";
	}

	/// <summary>
	/// Key: "Label.EarnBadgeGameLink"
	/// placeLink will carry the game name, which is not localized at the moment.
	/// English String: "Earn this Badge in: {placeLink}"
	/// </summary>
	public override string LabelEarnBadgeGameLink(string placeLink)
	{
		return $"{placeLink}에서 본 배지를 획득하세요";
	}

	protected override string _GetTemplateForLabelEarnBadgeGameLink()
	{
		return "{placeLink}에서 본 배지를 획득하세요";
	}

	protected override string _GetTemplateForLabelEnableBadgeConfirm()
	{
		return "본 배지를 정말 활성화하시겠습니까?";
	}

	protected override string _GetTemplateForLabelErrorOccurred()
	{
		return "오류 발생";
	}

	protected override string _GetTemplateForLabelFree()
	{
		return "무료";
	}

	protected override string _GetTemplateForLabelGenres()
	{
		return "장르";
	}

	protected override string _GetTemplateForLabelGetBuildersClub()
	{
		return "Builders Club 멤버만 한정판 아이템을 재판매할 수 있어요. 지금 Builders Club에 가입하세요!";
	}

	protected override string _GetTemplateForLabelGetPremiumMembership()
	{
		return "Premium 멤버만 한정판 아이템을 재판매할 수 있어요. 지금 Premium에 가입하세요!";
	}

	protected override string _GetTemplateForLabelInvalidPlace()
	{
		return "잘못된 장소예요.";
	}

	protected override string _GetTemplateForLabelInvalidProduct()
	{
		return "유효하지 않은 상품.";
	}

	protected override string _GetTemplateForLabelItemAvailable()
	{
		return "본 아이템은 인벤토리에서 찾을 수 있어요.";
	}

	protected override string _GetTemplateForLabelItemNotForSale()
	{
		return "판매 중인 아이템이 아닙니다.";
	}

	protected override string _GetTemplateForLabelItemOwned()
	{
		return "보유 아이템";
	}

	/// <summary>
	/// Key: "Label.ItemOwnedAmount"
	/// English String: "Item Owned ({amount})"
	/// </summary>
	public override string LabelItemOwnedAmount(string amount)
	{
		return $"보유 아이템 ({amount})";
	}

	protected override string _GetTemplateForLabelItemOwnedAmount()
	{
		return "보유 아이템 ({amount})";
	}

	/// <summary>
	/// Key: "Label.ItemRecentPrice"
	/// English String: "{name}'s recent average price is {price}."
	/// </summary>
	public override string LabelItemRecentPrice(string name, string price)
	{
		return $"{name}의 최근 평균 가격은 {price}입니다.";
	}

	protected override string _GetTemplateForLabelItemRecentPrice()
	{
		return "{name}의 최근 평균 가격은 {price}입니다.";
	}

	/// <summary>
	/// Key: "Label.MarketplaceFee"
	/// Marketplace fee amount
	/// English String: "Marketplace fee (at {percent}%)"
	/// </summary>
	public override string LabelMarketplaceFee(string percent)
	{
		return $"장터 수수료 ({percent}%)";
	}

	protected override string _GetTemplateForLabelMarketplaceFee()
	{
		return "장터 수수료 ({percent}%)";
	}

	protected override string _GetTemplateForLabelNone()
	{
		return "없음";
	}

	protected override string _GetTemplateForLabelNotAvailable()
	{
		return "해당 없음";
	}

	/// <summary>
	/// Key: "Label.OffsaleCountdownHourMinuteSecond"
	/// Item will go offsale in a variable number of hours (h), minutes (m), and seconds (s). Please use a narrow translation if possible for h/m/s.
	/// English String: "Offsale in {numberOfHours} h {numberOfMinutes} m {numberOfSeconds} s"
	/// </summary>
	public override string LabelOffsaleCountdownHourMinuteSecond(string numberOfHours, string numberOfMinutes, string numberOfSeconds)
	{
		return $"{numberOfHours}시간 {numberOfMinutes}분 {numberOfSeconds}초 후 판매 중단";
	}

	protected override string _GetTemplateForLabelOffsaleCountdownHourMinuteSecond()
	{
		return "{numberOfHours}시간 {numberOfMinutes}분 {numberOfSeconds}초 후 판매 중단";
	}

	protected override string _GetTemplateForLabelPrice()
	{
		return "가격";
	}

	protected override string _GetTemplateForLabelPriceIsInvalid()
	{
		return "유효하지 않은 가격입니다";
	}

	protected override string _GetTemplateForLabelPriceMinimumOne()
	{
		return "가격 (최소 1)";
	}

	protected override string _GetTemplateForLabelPurchaseCompleted()
	{
		return "구매 완료";
	}

	protected override string _GetTemplateForLabelRarity()
	{
		return "희귀도";
	}

	protected override string _GetTemplateForLabelReadMore()
	{
		return "더 보기";
	}

	protected override string _GetTemplateForLabelRentingItem()
	{
		return "아이템 빌리는 중";
	}

	protected override string _GetTemplateForLabelRthro()
	{
		return "Rthro";
	}

	/// <summary>
	/// Key: "Label.SellConfirm"
	/// English String: "Are you sure you want to sell {name} for {price}?"
	/// </summary>
	public override string LabelSellConfirm(string name, string price)
	{
		return $"{name}을(를) {price}에 정말 판매하시겠습니까?";
	}

	protected override string _GetTemplateForLabelSellConfirm()
	{
		return "{name}을(를) {price}에 정말 판매하시겠습니까?";
	}

	protected override string _GetTemplateForLabelSellYourCollectibleItem()
	{
		return "한정판 아이템 판매";
	}

	protected override string _GetTemplateForLabelSerializedLimitedRelease()
	{
		return "한정판 시리즈 (재판매 가능)";
	}

	protected override string _GetTemplateForLabelSerialNotAvailable()
	{
		return "일련번호 없음";
	}

	protected override string _GetTemplateForLabelSerialNumber()
	{
		return "일련번호";
	}

	/// <summary>
	/// Key: "Label.SerialNumberOfTotal"
	/// English String: "Serial #{number} of {total}"
	/// </summary>
	public override string LabelSerialNumberOfTotal(string number, string total)
	{
		return $"일련번호 {number} / {total}";
	}

	protected override string _GetTemplateForLabelSerialNumberOfTotal()
	{
		return "일련번호 {number} / {total}";
	}

	protected override string _GetTemplateForLabelShowLess()
	{
		return "간략히 보기";
	}

	protected override string _GetTemplateForLabelTags()
	{
		return "태그";
	}

	protected override string _GetTemplateForLabelTakeOffSale()
	{
		return "판매 중단";
	}

	protected override string _GetTemplateForLabelTakeOffSaleConfirm()
	{
		return "아이템 판매를 정말 중단하시겠습니까?";
	}

	protected override string _GetTemplateForLabelThirteenPlusOnly()
	{
		return "13+ 전용.";
	}

	protected override string _GetTemplateForLabelType()
	{
		return "종류";
	}

	protected override string _GetTemplateForLabelUpdated()
	{
		return "업데이트";
	}

	/// <summary>
	/// Key: "Label.UpdatedBy"
	/// English String: "(by {link})"
	/// </summary>
	public override string LabelUpdatedBy(string link)
	{
		return $"(개발: {link})";
	}

	protected override string _GetTemplateForLabelUpdatedBy()
	{
		return "(개발: {link})";
	}

	/// <summary>
	/// Key: "Label.UseGamePassLink"
	/// placeLink will carry game name which does not need to be localized
	/// English String: "Use this Game Pass in: {placeLink}"
	/// </summary>
	public override string LabelUseGamePassLink(string placeLink)
	{
		return $"{placeLink}에서 본 게임패스를 사용하세요";
	}

	protected override string _GetTemplateForLabelUseGamePassLink()
	{
		return "{placeLink}에서 본 게임패스를 사용하세요";
	}

	protected override string _GetTemplateForLabelYouGet()
	{
		return "획득:";
	}

	protected override string _GetTemplateForResponseAddedToProfile()
	{
		return "프로필에 추가했습니다";
	}

	protected override string _GetTemplateForResponseAddedToYourAvater()
	{
		return "아바타에 추가했습니다";
	}

	protected override string _GetTemplateForResponseAlreadyHaveMaxItems()
	{
		return "게임에 적용한 아이템의 수가 이미 한도에 도달했어요!";
	}

	protected override string _GetTemplateForResponseDisabledBadge()
	{
		return "배지 비활성화 완료";
	}

	protected override string _GetTemplateForResponseEnabledBadge()
	{
		return "배지 활성화 완료";
	}

	protected override string _GetTemplateForResponseFailedToAddToProfile()
	{
		return "프로필에 추가하지 못했습니다";
	}

	protected override string _GetTemplateForResponseFailedToDeleteFromInventory()
	{
		return "인벤토리에서 아이템을 삭제하지 못했습니다";
	}

	protected override string _GetTemplateForResponseFailedToDisableBadge()
	{
		return "배지 비활성화 실패";
	}

	protected override string _GetTemplateForResponseFailedToEnableBadge()
	{
		return "배지 활성화 실패";
	}

	protected override string _GetTemplateForResponseFailedToRemoveFromProfile()
	{
		return "프로필에서 삭제하지 못했습니다";
	}

	/// <summary>
	/// Key: "Response.GearAddSuccess"
	/// success message
	/// English String: "Added to your game, {placeName}."
	/// </summary>
	public override string ResponseGearAddSuccess(string placeName)
	{
		return $"게임 ({placeName})에 추가 완료.";
	}

	protected override string _GetTemplateForResponseGearAddSuccess()
	{
		return "게임 ({placeName})에 추가 완료.";
	}

	/// <summary>
	/// Key: "Response.GearAlreadyAdded"
	/// error message
	/// English String: "You have already added this gear to {placeName}."
	/// </summary>
	public override string ResponseGearAlreadyAdded(string placeName)
	{
		return $"이미 {placeName}에 추가한 장비입니다.";
	}

	protected override string _GetTemplateForResponseGearAlreadyAdded()
	{
		return "이미 {placeName}에 추가한 장비입니다.";
	}

	protected override string _GetTemplateForResponseRemovedFromInventory()
	{
		return "인벤토리에서 삭제했습니다";
	}

	protected override string _GetTemplateForResponseRemovedFromProfile()
	{
		return "프로필에서 삭제했습니다";
	}

	protected override string _GetTemplateForResponseRemovedFromYourAvater()
	{
		return "아바타에서 삭제했습니다";
	}
}
