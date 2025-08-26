namespace Roblox.Platform.TranslationResources.Feature {
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
	public override string ActionAdd => "ì¶”ê°€";

	/// <summary>
	/// Key: "Action.AddToGame"
	/// English String: "Add To Game"
	/// </summary>
	public override string ActionAddToGame => "ê²Œìž„ì— ì¶”ê°€";

	/// <summary>
	/// Key: "Action.AddToProfile"
	/// English String: "Add to Profile"
	/// </summary>
	public override string ActionAddToProfile => "í”„ë¡œí•„ì— ì¶”ê°€";

	/// <summary>
	/// Key: "Action.Advertise"
	/// English String: "Advertise"
	/// </summary>
	public override string ActionAdvertise => "ê´‘ê³ ";

	/// <summary>
	/// Key: "Action.Agree"
	/// button label
	/// English String: "Agree"
	/// </summary>
	public override string ActionAgree => "ë™ì˜";

	/// <summary>
	/// Key: "Action.Buy"
	/// English String: "Buy"
	/// </summary>
	public override string ActionBuy => "êµ¬ë§¤";

	/// <summary>
	/// Key: "Action.Cancel"
	/// Cancel
	/// English String: "Cancel"
	/// </summary>
	public override string ActionCancel => "ì·¨ì†Œ";

	/// <summary>
	/// Key: "Action.Configure"
	/// English String: "Configure"
	/// </summary>
	public override string ActionConfigure => "êµ¬ì„±";

	/// <summary>
	/// Key: "Action.Confirm"
	/// button label
	/// English String: "Confirm"
	/// </summary>
	public override string ActionConfirm => "í™•ì¸";

	/// <summary>
	/// Key: "Action.Delete"
	/// English String: "Delete"
	/// </summary>
	public override string ActionDelete => "ì‚­ì œ";

	/// <summary>
	/// Key: "Action.DisableBadge"
	/// English String: "Disable Badge"
	/// </summary>
	public override string ActionDisableBadge => "ë°°ì§€ ë¹„í™œì„±í™”";

	/// <summary>
	/// Key: "Action.EditAvatar"
	/// English String: "Edit Avatar"
	/// </summary>
	public override string ActionEditAvatar => "ì•„ë°”íƒ€ íŽ¸ì§‘";

	/// <summary>
	/// Key: "Action.EnableBadge"
	/// English String: "Enable Badge"
	/// </summary>
	public override string ActionEnableBadge => "ë°°ì§€ í™œì„±í™”";

	/// <summary>
	/// Key: "Action.Get"
	/// English String: "Get"
	/// </summary>
	public override string ActionGet => "íšë“";

	/// <summary>
	/// Key: "Action.Install"
	/// English String: "Install"
	/// </summary>
	public override string ActionInstall => "ì„¤ì¹˜";

	/// <summary>
	/// Key: "Action.Inventory"
	/// English String: "Inventory"
	/// </summary>
	public override string ActionInventory => "ì¸ë²¤í† ë¦¬";

	/// <summary>
	/// Key: "Action.No"
	/// button label
	/// English String: "No"
	/// </summary>
	public override string ActionNo => "ì•„ë‹ˆìš”";

	/// <summary>
	/// Key: "Action.Ok"
	/// button label
	/// English String: "OK"
	/// </summary>
	public override string ActionOk => "í™•ì¸";

	/// <summary>
	/// Key: "Action.Remove"
	/// English String: "Remove"
	/// </summary>
	public override string ActionRemove => "ì œê±°";

	/// <summary>
	/// Key: "Action.RemoveFromProfile"
	/// English String: "Remove from Profile"
	/// </summary>
	public override string ActionRemoveFromProfile => "í”„ë¡œí•„ì—ì„œ ì‚­ì œ";

	/// <summary>
	/// Key: "Action.Rent"
	/// English String: "Rent"
	/// </summary>
	public override string ActionRent => "ë¹Œë¦¬ê¸°";

	/// <summary>
	/// Key: "Action.ReportItem"
	/// English String: "Report Item"
	/// </summary>
	public override string ActionReportItem => "ì•„ì´í…œ ì‹ ê³ ";

	/// <summary>
	/// Key: "Action.Sell"
	/// English String: "Sell"
	/// </summary>
	public override string ActionSell => "íŒë§¤";

	/// <summary>
	/// Key: "Action.SellNow"
	/// Sell Now
	/// English String: "Sell Now"
	/// </summary>
	public override string ActionSellNow => "ì§€ê¸ˆ íŒë§¤";

	/// <summary>
	/// Key: "Action.TakeOff"
	/// Action on context menu on owned item detail page.
	/// English String: "Take Off"
	/// </summary>
	public override string ActionTakeOff => "í•´ì œ";

	/// <summary>
	/// Key: "Action.TakeOffSale"
	/// English String: "Take Off Sale"
	/// </summary>
	public override string ActionTakeOffSale => "íŒë§¤ ì¤‘ë‹¨";

	/// <summary>
	/// Key: "Action.TryOn"
	/// English String: "Try On"
	/// </summary>
	public override string ActionTryOn => "ìž¥ì°©í•´ ë³´ê¸°";

	/// <summary>
	/// Key: "Action.Upgrade"
	/// English String: "Upgrade"
	/// </summary>
	public override string ActionUpgrade => "ì—…ê·¸ë ˆì´ë“œ";

	/// <summary>
	/// Key: "Action.Wear"
	/// Action on context menu on owned item
	/// English String: "Wear"
	/// </summary>
	public override string ActionWear => "ì°©ìš©";

	/// <summary>
	/// Key: "Action.Yes"
	/// Yes
	/// English String: "Yes"
	/// </summary>
	public override string ActionYes => "ì˜ˆ";

	/// <summary>
	/// Key: "Heading.IncludedItems"
	/// Included items for a bundle of items. User purchases a bundle and will receive all items that will show below this heading.
	/// English String: "Included Items"
	/// </summary>
	public override string HeadingIncludedItems => "í¬í•¨ëœ ì•„ì´í…œ";

	/// <summary>
	/// Key: "Heading.PromoteItem"
	/// dialog heading
	/// English String: "Promote Item"
	/// </summary>
	public override string HeadingPromoteItem => "ì•„ì´í…œ í™ë³´";

	/// <summary>
	/// Key: "Label.AssetGrantedModalAcceptText"
	/// English String: "OK"
	/// </summary>
	public override string LabelAssetGrantedModalAcceptText => "í™•ì¸";

	/// <summary>
	/// Key: "Label.AssetGrantedModalMessage"
	/// English String: "You just got this item courtesy of our sponsor."
	/// </summary>
	public override string LabelAssetGrantedModalMessage => "ìŠ¤í°ì„œ ì„œë¹„ìŠ¤ë¡œ ë³¸ ì•„ì´í…œì´ ì§€ê¸‰ë˜ì—ˆì–´ìš”.";

	/// <summary>
	/// Key: "Label.AssetGrantedModalTitle"
	/// English String: "This item is now yours"
	/// </summary>
	public override string LabelAssetGrantedModalTitle => "ì´ì œ íšŒì›ë‹˜ì˜ ì•„ì´í…œì´ì˜ˆìš”";

	/// <summary>
	/// Key: "Label.Attributes"
	/// English String: "Attributes"
	/// </summary>
	public override string LabelAttributes => "ì†ì„±";

	/// <summary>
	/// Key: "Label.BestPrice"
	/// English String: "Best Price"
	/// </summary>
	public override string LabelBestPrice => "ìµœì € ê°€ê²©";

	/// <summary>
	/// Key: "Label.BuildersClubExclusive"
	/// label for Builders Club requirement
	/// English String: "Builders Club exclusive."
	/// </summary>
	public override string LabelBuildersClubExclusive => "Builders Club ì „ìš©ì´ì—ìš”.";

	/// <summary>
	/// Key: "Label.DeleteFromInventoryConfirm"
	/// confirmation message before deletion
	/// English String: "Are you sure you want to permanently DELETE this item from your inventory?"
	/// </summary>
	public override string LabelDeleteFromInventoryConfirm => "ë³¸ ì•„ì´í…œì„ ì •ë§ ì¸ë²¤í† ë¦¬ì—ì„œ ì˜êµ¬ ì‚­ì œí•˜ì‹œê² ìŠµë‹ˆê¹Œ?";

	/// <summary>
	/// Key: "Label.DeleteItem"
	/// Delete Item
	/// English String: "Delete Item"
	/// </summary>
	public override string LabelDeleteItem => "ì•„ì´í…œ ì‚­ì œ";

	/// <summary>
	/// Key: "Label.Description"
	/// English String: "Description"
	/// </summary>
	public override string LabelDescription => "ì„¤ëª…";

	/// <summary>
	/// Key: "Label.DisableBadgeConfirm"
	/// Are you sure you want to disable this Badge?
	/// English String: "Are you sure you want to disable this Badge?"
	/// </summary>
	public override string LabelDisableBadgeConfirm => "ë³¸ ë°°ì§€ë¥¼ ì •ë§ ë¹„í™œì„±í™”í•˜ì‹œê² ìŠµë‹ˆê¹Œ?";

	/// <summary>
	/// Key: "Label.DiscontinuedItem"
	/// label
	/// English String: "Discontinued item, resellable."
	/// </summary>
	public override string LabelDiscontinuedItem => "íŒë§¤ ì¤‘ë‹¨ ì•„ì´í…œ (ìž¬íŒë§¤ ê°€ëŠ¥)";

	/// <summary>
	/// Key: "Label.EnableBadgeConfirm"
	/// Are you sure you want to enable this Badge?
	/// English String: "Are you sure you want to enable this Badge?"
	/// </summary>
	public override string LabelEnableBadgeConfirm => "ë³¸ ë°°ì§€ë¥¼ ì •ë§ í™œì„±í™”í•˜ì‹œê² ìŠµë‹ˆê¹Œ?";

	/// <summary>
	/// Key: "Label.ErrorOccurred"
	/// English String: "Error occurred"
	/// </summary>
	public override string LabelErrorOccurred => "ì˜¤ë¥˜ ë°œìƒ";

	/// <summary>
	/// Key: "Label.Free"
	/// English String: "Free"
	/// </summary>
	public override string LabelFree => "ë¬´ë£Œ";

	/// <summary>
	/// Key: "Label.Genres"
	/// English String: "Genres"
	/// </summary>
	public override string LabelGenres => "ìž¥ë¥´";

	/// <summary>
	/// Key: "Label.GetBuildersClub"
	/// Only Builders Club members can re-sell collectible items. Get Builders Club today!
	/// English String: "Only Builders Club members can re-sell collectible items. Get Builders Club today!"
	/// </summary>
	public override string LabelGetBuildersClub => "Builders Club ë©¤ë²„ë§Œ í•œì •íŒ ì•„ì´í…œì„ ìž¬íŒë§¤í•  ìˆ˜ ìžˆì–´ìš”. ì§€ê¸ˆ Builders Clubì— ê°€ìž…í•˜ì„¸ìš”!";

	/// <summary>
	/// Key: "Label.GetPremiumMembership"
	/// English String: "Only Premium members can re-sell collectible items. Get Premium today!"
	/// </summary>
	public override string LabelGetPremiumMembership => "Premium ë©¤ë²„ë§Œ í•œì •íŒ ì•„ì´í…œì„ ìž¬íŒë§¤í•  ìˆ˜ ìžˆì–´ìš”. ì§€ê¸ˆ Premiumì— ê°€ìž…í•˜ì„¸ìš”!";

	/// <summary>
	/// Key: "Label.InvalidPlace"
	/// text label
	/// English String: "Invalid Place."
	/// </summary>
	public override string LabelInvalidPlace => "ìž˜ëª»ëœ ìž¥ì†Œì˜ˆìš”.";

	/// <summary>
	/// Key: "Label.InvalidProduct"
	/// label
	/// English String: "Invalid Product."
	/// </summary>
	public override string LabelInvalidProduct => "ìœ íš¨í•˜ì§€ ì•Šì€ ìƒí’ˆ.";

	/// <summary>
	/// Key: "Label.ItemAvailable"
	/// User is looking at the details of an item which they already own in their inventory.
	/// English String: "This item is available in your inventory."
	/// </summary>
	public override string LabelItemAvailable => "ë³¸ ì•„ì´í…œì€ ì¸ë²¤í† ë¦¬ì—ì„œ ì°¾ì„ ìˆ˜ ìžˆì–´ìš”.";

	/// <summary>
	/// Key: "Label.ItemNotForSale"
	/// User is looking at the details of an item that cannot be purchased.
	/// English String: "This item is not currently for sale."
	/// </summary>
	public override string LabelItemNotForSale => "íŒë§¤ ì¤‘ì¸ ì•„ì´í…œì´ ì•„ë‹™ë‹ˆë‹¤.";

	/// <summary>
	/// Key: "Label.ItemOwned"
	/// English String: "Item Owned"
	/// </summary>
	public override string LabelItemOwned => "ë³´ìœ  ì•„ì´í…œ";

	/// <summary>
	/// Key: "Label.None"
	/// English String: "None"
	/// </summary>
	public override string LabelNone => "ì—†ìŒ";

	/// <summary>
	/// Key: "Label.NotAvailable"
	/// English String: "N/A"
	/// </summary>
	public override string LabelNotAvailable => "í•´ë‹¹ ì—†ìŒ";

	/// <summary>
	/// Key: "Label.Price"
	/// English String: "Price"
	/// </summary>
	public override string LabelPrice => "ê°€ê²©";

	/// <summary>
	/// Key: "Label.PriceIsInvalid"
	/// English String: "Price is invalid"
	/// </summary>
	public override string LabelPriceIsInvalid => "ìœ íš¨í•˜ì§€ ì•Šì€ ê°€ê²©ìž…ë‹ˆë‹¤";

	/// <summary>
	/// Key: "Label.PriceMinimumOne"
	/// English String: "Price (minimum 1)"
	/// </summary>
	public override string LabelPriceMinimumOne => "ê°€ê²© (ìµœì†Œ 1)";

	/// <summary>
	/// Key: "Label.PurchaseCompleted"
	/// English String: "Purchase Completed"
	/// </summary>
	public override string LabelPurchaseCompleted => "êµ¬ë§¤ ì™„ë£Œ";

	/// <summary>
	/// Key: "Label.Rarity"
	/// English String: "Rarity"
	/// </summary>
	public override string LabelRarity => "í¬ê·€ë„";

	/// <summary>
	/// Key: "Label.ReadMore"
	/// English String: "Read More"
	/// </summary>
	public override string LabelReadMore => "ë” ë³´ê¸°";

	/// <summary>
	/// Key: "Label.RentingItem"
	/// English String: "Renting Item"
	/// </summary>
	public override string LabelRentingItem => "ì•„ì´í…œ ë¹Œë¦¬ëŠ” ì¤‘";

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
	public override string LabelSellYourCollectibleItem => "í•œì •íŒ ì•„ì´í…œ íŒë§¤";

	/// <summary>
	/// Key: "Label.SerializedLimitedRelease"
	/// label
	/// English String: "Serialized limited release, resellable."
	/// </summary>
	public override string LabelSerializedLimitedRelease => "í•œì •íŒ ì‹œë¦¬ì¦ˆ (ìž¬íŒë§¤ ê°€ëŠ¥)";

	/// <summary>
	/// Key: "Label.SerialNotAvailable"
	/// English String: "Serial N/A"
	/// </summary>
	public override string LabelSerialNotAvailable => "ì¼ë ¨ë²ˆí˜¸ ì—†ìŒ";

	/// <summary>
	/// Key: "Label.SerialNumber"
	/// English String: "Serial Number"
	/// </summary>
	public override string LabelSerialNumber => "ì¼ë ¨ë²ˆí˜¸";

	/// <summary>
	/// Key: "Label.ShowLess"
	/// Show Less
	/// English String: "Show Less"
	/// </summary>
	public override string LabelShowLess => "ê°„ëžµížˆ ë³´ê¸°";

	/// <summary>
	/// Key: "Label.Tags"
	/// A label to indicate a list of tags on an item (i.e. "red, belt, shoes, denim" could be some tags for a Pants item that was red jeans with a belt and shoes)
	/// English String: "Tags"
	/// </summary>
	public override string LabelTags => "íƒœê·¸";

	/// <summary>
	/// Key: "Label.TakeOffSale"
	/// Take off Sale
	/// English String: "Take off Sale"
	/// </summary>
	public override string LabelTakeOffSale => "íŒë§¤ ì¤‘ë‹¨";

	/// <summary>
	/// Key: "Label.TakeOffSaleConfirm"
	/// English String: "Are you sure you want to take the item off sale?"
	/// </summary>
	public override string LabelTakeOffSaleConfirm => "ì•„ì´í…œ íŒë§¤ë¥¼ ì •ë§ ì¤‘ë‹¨í•˜ì‹œê² ìŠµë‹ˆê¹Œ?";

	/// <summary>
	/// Key: "Label.ThirteenPlusOnly"
	/// label
	/// English String: "13+ Only."
	/// </summary>
	public override string LabelThirteenPlusOnly => "13+ ì „ìš©.";

	/// <summary>
	/// Key: "Label.Type"
	/// English String: "Type"
	/// </summary>
	public override string LabelType => "ì¢…ë¥˜";

	/// <summary>
	/// Key: "Label.Updated"
	/// English String: "Updated"
	/// </summary>
	public override string LabelUpdated => "ì—…ë°ì´íŠ¸";

	/// <summary>
	/// Key: "Label.YouGet"
	/// Amount user gets after Marketplace fee deduction.
	/// English String: "You get"
	/// </summary>
	public override string LabelYouGet => "íšë“:";

	/// <summary>
	/// Key: "Response.AddedToProfile"
	/// success message when item is added to profile
	/// English String: "Added to your profile"
	/// </summary>
	public override string ResponseAddedToProfile => "í”„ë¡œí•„ì— ì¶”ê°€í–ˆìŠµë‹ˆë‹¤";

	/// <summary>
	/// Key: "Response.AddedToYourAvater"
	/// Added to your Avatar
	/// English String: "Added to your Avatar"
	/// </summary>
	public override string ResponseAddedToYourAvater => "ì•„ë°”íƒ€ì— ì¶”ê°€í–ˆìŠµë‹ˆë‹¤";

	/// <summary>
	/// Key: "Response.AlreadyHaveMaxItems"
	/// error message
	/// English String: "You already have the maximum number of items on your game!"
	/// </summary>
	public override string ResponseAlreadyHaveMaxItems => "ê²Œìž„ì— ì ìš©í•œ ì•„ì´í…œì˜ ìˆ˜ê°€ ì´ë¯¸ í•œë„ì— ë„ë‹¬í–ˆì–´ìš”!";

	/// <summary>
	/// Key: "Response.DisabledBadge"
	/// Successfully disabled the badge
	/// English String: "Successfully disabled the badge"
	/// </summary>
	public override string ResponseDisabledBadge => "ë°°ì§€ ë¹„í™œì„±í™” ì™„ë£Œ";

	/// <summary>
	/// Key: "Response.EnabledBadge"
	/// Successfully enabled the badge
	/// English String: "Successfully enabled the badge"
	/// </summary>
	public override string ResponseEnabledBadge => "ë°°ì§€ í™œì„±í™” ì™„ë£Œ";

	/// <summary>
	/// Key: "Response.FailedToAddToProfile"
	/// error message when item could not be added to profile
	/// English String: "Failed to add to profile"
	/// </summary>
	public override string ResponseFailedToAddToProfile => "í”„ë¡œí•„ì— ì¶”ê°€í•˜ì§€ ëª»í–ˆìŠµë‹ˆë‹¤";

	/// <summary>
	/// Key: "Response.FailedToDeleteFromInventory"
	/// Failed to delete item from inventory
	/// English String: "Failed to delete item from inventory"
	/// </summary>
	public override string ResponseFailedToDeleteFromInventory => "ì¸ë²¤í† ë¦¬ì—ì„œ ì•„ì´í…œì„ ì‚­ì œí•˜ì§€ ëª»í–ˆìŠµë‹ˆë‹¤";

	/// <summary>
	/// Key: "Response.FailedToDisableBadge"
	/// Failed to disable badge
	/// English String: "Failed to disable badge"
	/// </summary>
	public override string ResponseFailedToDisableBadge => "ë°°ì§€ ë¹„í™œì„±í™” ì‹¤íŒ¨";

	/// <summary>
	/// Key: "Response.FailedToEnableBadge"
	/// Failed to enable badge
	/// English String: "Failed to enable badge"
	/// </summary>
	public override string ResponseFailedToEnableBadge => "ë°°ì§€ í™œì„±í™” ì‹¤íŒ¨";

	/// <summary>
	/// Key: "Response.FailedToRemoveFromProfile"
	/// error message when items could not be removed
	/// English String: "Failed to remove from profile"
	/// </summary>
	public override string ResponseFailedToRemoveFromProfile => "í”„ë¡œí•„ì—ì„œ ì‚­ì œí•˜ì§€ ëª»í–ˆìŠµë‹ˆë‹¤";

	/// <summary>
	/// Key: "Response.RemovedFromInventory"
	/// Successfully removed from your inventory
	/// English String: "Successfully removed from your inventory"
	/// </summary>
	public override string ResponseRemovedFromInventory => "ì¸ë²¤í† ë¦¬ì—ì„œ ì‚­ì œí–ˆìŠµë‹ˆë‹¤";

	/// <summary>
	/// Key: "Response.RemovedFromProfile"
	/// message when an item is removed from profile
	/// English String: "Removed from your profile"
	/// </summary>
	public override string ResponseRemovedFromProfile => "í”„ë¡œí•„ì—ì„œ ì‚­ì œí–ˆìŠµë‹ˆë‹¤";

	/// <summary>
	/// Key: "Response.RemovedFromYourAvater"
	/// Removed from your Avatar
	/// English String: "Removed from your Avatar"
	/// </summary>
	public override string ResponseRemovedFromYourAvater => "ì•„ë°”íƒ€ì—ì„œ ì‚­ì œí–ˆìŠµë‹ˆë‹¤";

	public ItemResources_ko_kr(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionAdd()
	{
		return "ì¶”ê°€";
	}

	protected override string _GetTemplateForActionAddToGame()
	{
		return "ê²Œìž„ì— ì¶”ê°€";
	}

	protected override string _GetTemplateForActionAddToProfile()
	{
		return "í”„ë¡œí•„ì— ì¶”ê°€";
	}

	protected override string _GetTemplateForActionAdvertise()
	{
		return "ê´‘ê³ ";
	}

	protected override string _GetTemplateForActionAgree()
	{
		return "ë™ì˜";
	}

	protected override string _GetTemplateForActionBuy()
	{
		return "êµ¬ë§¤";
	}

	protected override string _GetTemplateForActionCancel()
	{
		return "ì·¨ì†Œ";
	}

	protected override string _GetTemplateForActionConfigure()
	{
		return "êµ¬ì„±";
	}

	protected override string _GetTemplateForActionConfirm()
	{
		return "í™•ì¸";
	}

	protected override string _GetTemplateForActionDelete()
	{
		return "ì‚­ì œ";
	}

	protected override string _GetTemplateForActionDisableBadge()
	{
		return "ë°°ì§€ ë¹„í™œì„±í™”";
	}

	protected override string _GetTemplateForActionEditAvatar()
	{
		return "ì•„ë°”íƒ€ íŽ¸ì§‘";
	}

	protected override string _GetTemplateForActionEnableBadge()
	{
		return "ë°°ì§€ í™œì„±í™”";
	}

	protected override string _GetTemplateForActionGet()
	{
		return "íšë“";
	}

	protected override string _GetTemplateForActionInstall()
	{
		return "ì„¤ì¹˜";
	}

	protected override string _GetTemplateForActionInventory()
	{
		return "ì¸ë²¤í† ë¦¬";
	}

	protected override string _GetTemplateForActionNo()
	{
		return "ì•„ë‹ˆìš”";
	}

	protected override string _GetTemplateForActionOk()
	{
		return "í™•ì¸";
	}

	protected override string _GetTemplateForActionRemove()
	{
		return "ì œê±°";
	}

	protected override string _GetTemplateForActionRemoveFromProfile()
	{
		return "í”„ë¡œí•„ì—ì„œ ì‚­ì œ";
	}

	protected override string _GetTemplateForActionRent()
	{
		return "ë¹Œë¦¬ê¸°";
	}

	protected override string _GetTemplateForActionReportItem()
	{
		return "ì•„ì´í…œ ì‹ ê³ ";
	}

	protected override string _GetTemplateForActionSell()
	{
		return "íŒë§¤";
	}

	protected override string _GetTemplateForActionSellNow()
	{
		return "ì§€ê¸ˆ íŒë§¤";
	}

	protected override string _GetTemplateForActionTakeOff()
	{
		return "í•´ì œ";
	}

	protected override string _GetTemplateForActionTakeOffSale()
	{
		return "íŒë§¤ ì¤‘ë‹¨";
	}

	protected override string _GetTemplateForActionTryOn()
	{
		return "ìž¥ì°©í•´ ë³´ê¸°";
	}

	protected override string _GetTemplateForActionUpgrade()
	{
		return "ì—…ê·¸ë ˆì´ë“œ";
	}

	protected override string _GetTemplateForActionWear()
	{
		return "ì°©ìš©";
	}

	protected override string _GetTemplateForActionYes()
	{
		return "ì˜ˆ";
	}

	protected override string _GetTemplateForHeadingIncludedItems()
	{
		return "í¬í•¨ëœ ì•„ì´í…œ";
	}

	protected override string _GetTemplateForHeadingPromoteItem()
	{
		return "ì•„ì´í…œ í™ë³´";
	}

	/// <summary>
	/// Key: "Label.AllowPlayersPlusEarn"
	/// English String: "Allow players to use this gear inside your game plus earn {affiliateSaleTotal} when it's purchased from your game page."
	/// </summary>
	public override string LabelAllowPlayersPlusEarn(string affiliateSaleTotal)
	{
		return $"ì‚¬ìš©ìžë“¤ì´ ë³¸ ìž¥ë¹„ë¥¼ íšŒì›ë‹˜ì˜ ê²Œìž„ì—ì„œ ì‚¬ìš©í•  ìˆ˜ ìžˆë„ë¡ ì¶”ê°€í•´ë³´ì„¸ìš”. ì‚¬ìš©ìžê°€ íšŒì›ë‹˜ì˜ ê²Œìž„ íŽ˜ì´ì§€ì—ì„œ ë³¸ ìž¥ë¹„ë¥¼ êµ¬ë§¤ì‹œ, {affiliateSaleTotal}ì„(ë¥¼) íšë“í•  ìˆ˜ ìžˆìŠµë‹ˆë‹¤.";
	}

	protected override string _GetTemplateForLabelAllowPlayersPlusEarn()
	{
		return "ì‚¬ìš©ìžë“¤ì´ ë³¸ ìž¥ë¹„ë¥¼ íšŒì›ë‹˜ì˜ ê²Œìž„ì—ì„œ ì‚¬ìš©í•  ìˆ˜ ìžˆë„ë¡ ì¶”ê°€í•´ë³´ì„¸ìš”. ì‚¬ìš©ìžê°€ íšŒì›ë‹˜ì˜ ê²Œìž„ íŽ˜ì´ì§€ì—ì„œ ë³¸ ìž¥ë¹„ë¥¼ êµ¬ë§¤ì‹œ, {affiliateSaleTotal}ì„(ë¥¼) íšë“í•  ìˆ˜ ìžˆìŠµë‹ˆë‹¤.";
	}

	protected override string _GetTemplateForLabelAssetGrantedModalAcceptText()
	{
		return "í™•ì¸";
	}

	protected override string _GetTemplateForLabelAssetGrantedModalMessage()
	{
		return "ìŠ¤í°ì„œ ì„œë¹„ìŠ¤ë¡œ ë³¸ ì•„ì´í…œì´ ì§€ê¸‰ë˜ì—ˆì–´ìš”.";
	}

	protected override string _GetTemplateForLabelAssetGrantedModalTitle()
	{
		return "ì´ì œ íšŒì›ë‹˜ì˜ ì•„ì´í…œì´ì˜ˆìš”";
	}

	protected override string _GetTemplateForLabelAttributes()
	{
		return "ì†ì„±";
	}

	protected override string _GetTemplateForLabelBestPrice()
	{
		return "ìµœì € ê°€ê²©";
	}

	protected override string _GetTemplateForLabelBuildersClubExclusive()
	{
		return "Builders Club ì „ìš©ì´ì—ìš”.";
	}

	/// <summary>
	/// Key: "Label.By"
	/// English String: "By {creator}"
	/// </summary>
	public override string LabelBy(string creator)
	{
		return $"ê°œë°œìž: {creator}";
	}

	protected override string _GetTemplateForLabelBy()
	{
		return "ê°œë°œìž: {creator}";
	}

	/// <summary>
	/// Key: "Label.CountdownTimerDayHourMinute"
	/// Item will go offsale in a variable number of days (d), hours (h), and minutes (m). Please use a narrow translation if possible for d/h/m.
	/// English String: "Offsale in {numberOfDays} d {numberOfHours} h {numberOfMinutes} m"
	/// </summary>
	public override string LabelCountdownTimerDayHourMinute(string numberOfDays, string numberOfHours, string numberOfMinutes)
	{
		return $"{numberOfDays}ì¼ {numberOfHours}ì‹œê°„ {numberOfMinutes}ë¶„ í›„ íŒë§¤ ì¤‘ë‹¨";
	}

	protected override string _GetTemplateForLabelCountdownTimerDayHourMinute()
	{
		return "{numberOfDays}ì¼ {numberOfHours}ì‹œê°„ {numberOfMinutes}ë¶„ í›„ íŒë§¤ ì¤‘ë‹¨";
	}

	protected override string _GetTemplateForLabelDeleteFromInventoryConfirm()
	{
		return "ë³¸ ì•„ì´í…œì„ ì •ë§ ì¸ë²¤í† ë¦¬ì—ì„œ ì˜êµ¬ ì‚­ì œí•˜ì‹œê² ìŠµë‹ˆê¹Œ?";
	}

	protected override string _GetTemplateForLabelDeleteItem()
	{
		return "ì•„ì´í…œ ì‚­ì œ";
	}

	protected override string _GetTemplateForLabelDescription()
	{
		return "ì„¤ëª…";
	}

	protected override string _GetTemplateForLabelDisableBadgeConfirm()
	{
		return "ë³¸ ë°°ì§€ë¥¼ ì •ë§ ë¹„í™œì„±í™”í•˜ì‹œê² ìŠµë‹ˆê¹Œ?";
	}

	protected override string _GetTemplateForLabelDiscontinuedItem()
	{
		return "íŒë§¤ ì¤‘ë‹¨ ì•„ì´í…œ (ìž¬íŒë§¤ ê°€ëŠ¥)";
	}

	/// <summary>
	/// Key: "Label.EarnBadgeGameLink"
	/// placeLink will carry the game name, which is not localized at the moment.
	/// English String: "Earn this Badge in: {placeLink}"
	/// </summary>
	public override string LabelEarnBadgeGameLink(string placeLink)
	{
		return $"{placeLink}ì—ì„œ ë³¸ ë°°ì§€ë¥¼ íšë“í•˜ì„¸ìš”";
	}

	protected override string _GetTemplateForLabelEarnBadgeGameLink()
	{
		return "{placeLink}ì—ì„œ ë³¸ ë°°ì§€ë¥¼ íšë“í•˜ì„¸ìš”";
	}

	protected override string _GetTemplateForLabelEnableBadgeConfirm()
	{
		return "ë³¸ ë°°ì§€ë¥¼ ì •ë§ í™œì„±í™”í•˜ì‹œê² ìŠµë‹ˆê¹Œ?";
	}

	protected override string _GetTemplateForLabelErrorOccurred()
	{
		return "ì˜¤ë¥˜ ë°œìƒ";
	}

	protected override string _GetTemplateForLabelFree()
	{
		return "ë¬´ë£Œ";
	}

	protected override string _GetTemplateForLabelGenres()
	{
		return "ìž¥ë¥´";
	}

	protected override string _GetTemplateForLabelGetBuildersClub()
	{
		return "Builders Club ë©¤ë²„ë§Œ í•œì •íŒ ì•„ì´í…œì„ ìž¬íŒë§¤í•  ìˆ˜ ìžˆì–´ìš”. ì§€ê¸ˆ Builders Clubì— ê°€ìž…í•˜ì„¸ìš”!";
	}

	protected override string _GetTemplateForLabelGetPremiumMembership()
	{
		return "Premium ë©¤ë²„ë§Œ í•œì •íŒ ì•„ì´í…œì„ ìž¬íŒë§¤í•  ìˆ˜ ìžˆì–´ìš”. ì§€ê¸ˆ Premiumì— ê°€ìž…í•˜ì„¸ìš”!";
	}

	protected override string _GetTemplateForLabelInvalidPlace()
	{
		return "ìž˜ëª»ëœ ìž¥ì†Œì˜ˆìš”.";
	}

	protected override string _GetTemplateForLabelInvalidProduct()
	{
		return "ìœ íš¨í•˜ì§€ ì•Šì€ ìƒí’ˆ.";
	}

	protected override string _GetTemplateForLabelItemAvailable()
	{
		return "ë³¸ ì•„ì´í…œì€ ì¸ë²¤í† ë¦¬ì—ì„œ ì°¾ì„ ìˆ˜ ìžˆì–´ìš”.";
	}

	protected override string _GetTemplateForLabelItemNotForSale()
	{
		return "íŒë§¤ ì¤‘ì¸ ì•„ì´í…œì´ ì•„ë‹™ë‹ˆë‹¤.";
	}

	protected override string _GetTemplateForLabelItemOwned()
	{
		return "ë³´ìœ  ì•„ì´í…œ";
	}

	/// <summary>
	/// Key: "Label.ItemOwnedAmount"
	/// English String: "Item Owned ({amount})"
	/// </summary>
	public override string LabelItemOwnedAmount(string amount)
	{
		return $"ë³´ìœ  ì•„ì´í…œ ({amount})";
	}

	protected override string _GetTemplateForLabelItemOwnedAmount()
	{
		return "ë³´ìœ  ì•„ì´í…œ ({amount})";
	}

	/// <summary>
	/// Key: "Label.ItemRecentPrice"
	/// English String: "{name}'s recent average price is {price}."
	/// </summary>
	public override string LabelItemRecentPrice(string name, string price)
	{
		return $"{name}ì˜ ìµœê·¼ í‰ê·  ê°€ê²©ì€ {price}ìž…ë‹ˆë‹¤.";
	}

	protected override string _GetTemplateForLabelItemRecentPrice()
	{
		return "{name}ì˜ ìµœê·¼ í‰ê·  ê°€ê²©ì€ {price}ìž…ë‹ˆë‹¤.";
	}

	/// <summary>
	/// Key: "Label.MarketplaceFee"
	/// Marketplace fee amount
	/// English String: "Marketplace fee (at {percent}%)"
	/// </summary>
	public override string LabelMarketplaceFee(string percent)
	{
		return $"ìž¥í„° ìˆ˜ìˆ˜ë£Œ ({percent}%)";
	}

	protected override string _GetTemplateForLabelMarketplaceFee()
	{
		return "ìž¥í„° ìˆ˜ìˆ˜ë£Œ ({percent}%)";
	}

	protected override string _GetTemplateForLabelNone()
	{
		return "ì—†ìŒ";
	}

	protected override string _GetTemplateForLabelNotAvailable()
	{
		return "í•´ë‹¹ ì—†ìŒ";
	}

	/// <summary>
	/// Key: "Label.OffsaleCountdownHourMinuteSecond"
	/// Item will go offsale in a variable number of hours (h), minutes (m), and seconds (s). Please use a narrow translation if possible for h/m/s.
	/// English String: "Offsale in {numberOfHours} h {numberOfMinutes} m {numberOfSeconds} s"
	/// </summary>
	public override string LabelOffsaleCountdownHourMinuteSecond(string numberOfHours, string numberOfMinutes, string numberOfSeconds)
	{
		return $"{numberOfHours}ì‹œê°„ {numberOfMinutes}ë¶„ {numberOfSeconds}ì´ˆ í›„ íŒë§¤ ì¤‘ë‹¨";
	}

	protected override string _GetTemplateForLabelOffsaleCountdownHourMinuteSecond()
	{
		return "{numberOfHours}ì‹œê°„ {numberOfMinutes}ë¶„ {numberOfSeconds}ì´ˆ í›„ íŒë§¤ ì¤‘ë‹¨";
	}

	protected override string _GetTemplateForLabelPrice()
	{
		return "ê°€ê²©";
	}

	protected override string _GetTemplateForLabelPriceIsInvalid()
	{
		return "ìœ íš¨í•˜ì§€ ì•Šì€ ê°€ê²©ìž…ë‹ˆë‹¤";
	}

	protected override string _GetTemplateForLabelPriceMinimumOne()
	{
		return "ê°€ê²© (ìµœì†Œ 1)";
	}

	protected override string _GetTemplateForLabelPurchaseCompleted()
	{
		return "êµ¬ë§¤ ì™„ë£Œ";
	}

	protected override string _GetTemplateForLabelRarity()
	{
		return "í¬ê·€ë„";
	}

	protected override string _GetTemplateForLabelReadMore()
	{
		return "ë” ë³´ê¸°";
	}

	protected override string _GetTemplateForLabelRentingItem()
	{
		return "ì•„ì´í…œ ë¹Œë¦¬ëŠ” ì¤‘";
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
		return $"{name}ì„(ë¥¼) {price}ì— ì •ë§ íŒë§¤í•˜ì‹œê² ìŠµë‹ˆê¹Œ?";
	}

	protected override string _GetTemplateForLabelSellConfirm()
	{
		return "{name}ì„(ë¥¼) {price}ì— ì •ë§ íŒë§¤í•˜ì‹œê² ìŠµë‹ˆê¹Œ?";
	}

	protected override string _GetTemplateForLabelSellYourCollectibleItem()
	{
		return "í•œì •íŒ ì•„ì´í…œ íŒë§¤";
	}

	protected override string _GetTemplateForLabelSerializedLimitedRelease()
	{
		return "í•œì •íŒ ì‹œë¦¬ì¦ˆ (ìž¬íŒë§¤ ê°€ëŠ¥)";
	}

	protected override string _GetTemplateForLabelSerialNotAvailable()
	{
		return "ì¼ë ¨ë²ˆí˜¸ ì—†ìŒ";
	}

	protected override string _GetTemplateForLabelSerialNumber()
	{
		return "ì¼ë ¨ë²ˆí˜¸";
	}

	/// <summary>
	/// Key: "Label.SerialNumberOfTotal"
	/// English String: "Serial #{number} of {total}"
	/// </summary>
	public override string LabelSerialNumberOfTotal(string number, string total)
	{
		return $"ì¼ë ¨ë²ˆí˜¸ {number} / {total}";
	}

	protected override string _GetTemplateForLabelSerialNumberOfTotal()
	{
		return "ì¼ë ¨ë²ˆí˜¸ {number} / {total}";
	}

	protected override string _GetTemplateForLabelShowLess()
	{
		return "ê°„ëžµížˆ ë³´ê¸°";
	}

	protected override string _GetTemplateForLabelTags()
	{
		return "íƒœê·¸";
	}

	protected override string _GetTemplateForLabelTakeOffSale()
	{
		return "íŒë§¤ ì¤‘ë‹¨";
	}

	protected override string _GetTemplateForLabelTakeOffSaleConfirm()
	{
		return "ì•„ì´í…œ íŒë§¤ë¥¼ ì •ë§ ì¤‘ë‹¨í•˜ì‹œê² ìŠµë‹ˆê¹Œ?";
	}

	protected override string _GetTemplateForLabelThirteenPlusOnly()
	{
		return "13+ ì „ìš©.";
	}

	protected override string _GetTemplateForLabelType()
	{
		return "ì¢…ë¥˜";
	}

	protected override string _GetTemplateForLabelUpdated()
	{
		return "ì—…ë°ì´íŠ¸";
	}

	/// <summary>
	/// Key: "Label.UpdatedBy"
	/// English String: "(by {link})"
	/// </summary>
	public override string LabelUpdatedBy(string link)
	{
		return $"(ê°œë°œ: {link})";
	}

	protected override string _GetTemplateForLabelUpdatedBy()
	{
		return "(ê°œë°œ: {link})";
	}

	/// <summary>
	/// Key: "Label.UseGamePassLink"
	/// placeLink will carry game name which does not need to be localized
	/// English String: "Use this Game Pass in: {placeLink}"
	/// </summary>
	public override string LabelUseGamePassLink(string placeLink)
	{
		return $"{placeLink}ì—ì„œ ë³¸ ê²Œìž„íŒ¨ìŠ¤ë¥¼ ì‚¬ìš©í•˜ì„¸ìš”";
	}

	protected override string _GetTemplateForLabelUseGamePassLink()
	{
		return "{placeLink}ì—ì„œ ë³¸ ê²Œìž„íŒ¨ìŠ¤ë¥¼ ì‚¬ìš©í•˜ì„¸ìš”";
	}

	protected override string _GetTemplateForLabelYouGet()
	{
		return "íšë“:";
	}

	protected override string _GetTemplateForResponseAddedToProfile()
	{
		return "í”„ë¡œí•„ì— ì¶”ê°€í–ˆìŠµë‹ˆë‹¤";
	}

	protected override string _GetTemplateForResponseAddedToYourAvater()
	{
		return "ì•„ë°”íƒ€ì— ì¶”ê°€í–ˆìŠµë‹ˆë‹¤";
	}

	protected override string _GetTemplateForResponseAlreadyHaveMaxItems()
	{
		return "ê²Œìž„ì— ì ìš©í•œ ì•„ì´í…œì˜ ìˆ˜ê°€ ì´ë¯¸ í•œë„ì— ë„ë‹¬í–ˆì–´ìš”!";
	}

	protected override string _GetTemplateForResponseDisabledBadge()
	{
		return "ë°°ì§€ ë¹„í™œì„±í™” ì™„ë£Œ";
	}

	protected override string _GetTemplateForResponseEnabledBadge()
	{
		return "ë°°ì§€ í™œì„±í™” ì™„ë£Œ";
	}

	protected override string _GetTemplateForResponseFailedToAddToProfile()
	{
		return "í”„ë¡œí•„ì— ì¶”ê°€í•˜ì§€ ëª»í–ˆìŠµë‹ˆë‹¤";
	}

	protected override string _GetTemplateForResponseFailedToDeleteFromInventory()
	{
		return "ì¸ë²¤í† ë¦¬ì—ì„œ ì•„ì´í…œì„ ì‚­ì œí•˜ì§€ ëª»í–ˆìŠµë‹ˆë‹¤";
	}

	protected override string _GetTemplateForResponseFailedToDisableBadge()
	{
		return "ë°°ì§€ ë¹„í™œì„±í™” ì‹¤íŒ¨";
	}

	protected override string _GetTemplateForResponseFailedToEnableBadge()
	{
		return "ë°°ì§€ í™œì„±í™” ì‹¤íŒ¨";
	}

	protected override string _GetTemplateForResponseFailedToRemoveFromProfile()
	{
		return "í”„ë¡œí•„ì—ì„œ ì‚­ì œí•˜ì§€ ëª»í–ˆìŠµë‹ˆë‹¤";
	}

	/// <summary>
	/// Key: "Response.GearAddSuccess"
	/// success message
	/// English String: "Added to your game, {placeName}."
	/// </summary>
	public override string ResponseGearAddSuccess(string placeName)
	{
		return $"ê²Œìž„ ({placeName})ì— ì¶”ê°€ ì™„ë£Œ.";
	}

	protected override string _GetTemplateForResponseGearAddSuccess()
	{
		return "ê²Œìž„ ({placeName})ì— ì¶”ê°€ ì™„ë£Œ.";
	}

	/// <summary>
	/// Key: "Response.GearAlreadyAdded"
	/// error message
	/// English String: "You have already added this gear to {placeName}."
	/// </summary>
	public override string ResponseGearAlreadyAdded(string placeName)
	{
		return $"ì´ë¯¸ {placeName}ì— ì¶”ê°€í•œ ìž¥ë¹„ìž…ë‹ˆë‹¤.";
	}

	protected override string _GetTemplateForResponseGearAlreadyAdded()
	{
		return "ì´ë¯¸ {placeName}ì— ì¶”ê°€í•œ ìž¥ë¹„ìž…ë‹ˆë‹¤.";
	}

	protected override string _GetTemplateForResponseRemovedFromInventory()
	{
		return "ì¸ë²¤í† ë¦¬ì—ì„œ ì‚­ì œí–ˆìŠµë‹ˆë‹¤";
	}

	protected override string _GetTemplateForResponseRemovedFromProfile()
	{
		return "í”„ë¡œí•„ì—ì„œ ì‚­ì œí–ˆìŠµë‹ˆë‹¤";
	}

	protected override string _GetTemplateForResponseRemovedFromYourAvater()
	{
		return "ì•„ë°”íƒ€ì—ì„œ ì‚­ì œí–ˆìŠµë‹ˆë‹¤";
	}
}


}
