using System;
using System.Collections.Generic;

namespace Roblox.TranslationResources.Feature;

internal class ItemResources_en_us : TranslationResourcesBase, IItemResources, ITranslationResources
{
	private readonly Lazy<IReadOnlyDictionary<string, string>> _AllKeys;

	/// <summary>
	/// Key: "Action.Add"
	/// button label
	/// English String: "Add"
	/// </summary>
	public virtual string ActionAdd => "Add";

	/// <summary>
	/// Key: "Action.AddToGame"
	/// English String: "Add To Game"
	/// </summary>
	public virtual string ActionAddToGame => "Add To Game";

	/// <summary>
	/// Key: "Action.AddToProfile"
	/// English String: "Add to Profile"
	/// </summary>
	public virtual string ActionAddToProfile => "Add to Profile";

	/// <summary>
	/// Key: "Action.Advertise"
	/// English String: "Advertise"
	/// </summary>
	public virtual string ActionAdvertise => "Advertise";

	/// <summary>
	/// Key: "Action.Agree"
	/// button label
	/// English String: "Agree"
	/// </summary>
	public virtual string ActionAgree => "Agree";

	/// <summary>
	/// Key: "Action.Buy"
	/// English String: "Buy"
	/// </summary>
	public virtual string ActionBuy => "Buy";

	/// <summary>
	/// Key: "Action.Cancel"
	/// Cancel
	/// English String: "Cancel"
	/// </summary>
	public virtual string ActionCancel => "Cancel";

	/// <summary>
	/// Key: "Action.Configure"
	/// English String: "Configure"
	/// </summary>
	public virtual string ActionConfigure => "Configure";

	/// <summary>
	/// Key: "Action.Confirm"
	/// button label
	/// English String: "Confirm"
	/// </summary>
	public virtual string ActionConfirm => "Confirm";

	/// <summary>
	/// Key: "Action.Delete"
	/// English String: "Delete"
	/// </summary>
	public virtual string ActionDelete => "Delete";

	/// <summary>
	/// Key: "Action.DisableBadge"
	/// English String: "Disable Badge"
	/// </summary>
	public virtual string ActionDisableBadge => "Disable Badge";

	/// <summary>
	/// Key: "Action.EditAvatar"
	/// English String: "Edit Avatar"
	/// </summary>
	public virtual string ActionEditAvatar => "Edit Avatar";

	/// <summary>
	/// Key: "Action.EnableBadge"
	/// English String: "Enable Badge"
	/// </summary>
	public virtual string ActionEnableBadge => "Enable Badge";

	/// <summary>
	/// Key: "Action.Get"
	/// English String: "Get"
	/// </summary>
	public virtual string ActionGet => "Get";

	/// <summary>
	/// Key: "Action.Install"
	/// English String: "Install"
	/// </summary>
	public virtual string ActionInstall => "Install";

	/// <summary>
	/// Key: "Action.Inventory"
	/// English String: "Inventory"
	/// </summary>
	public virtual string ActionInventory => "Inventory";

	/// <summary>
	/// Key: "Action.No"
	/// button label
	/// English String: "No"
	/// </summary>
	public virtual string ActionNo => "No";

	/// <summary>
	/// Key: "Action.Ok"
	/// button label
	/// English String: "OK"
	/// </summary>
	public virtual string ActionOk => "OK";

	/// <summary>
	/// Key: "Action.Remove"
	/// English String: "Remove"
	/// </summary>
	public virtual string ActionRemove => "Remove";

	/// <summary>
	/// Key: "Action.RemoveFromProfile"
	/// English String: "Remove from Profile"
	/// </summary>
	public virtual string ActionRemoveFromProfile => "Remove from Profile";

	/// <summary>
	/// Key: "Action.Rent"
	/// English String: "Rent"
	/// </summary>
	public virtual string ActionRent => "Rent";

	/// <summary>
	/// Key: "Action.ReportItem"
	/// English String: "Report Item"
	/// </summary>
	public virtual string ActionReportItem => "Report Item";

	/// <summary>
	/// Key: "Action.Sell"
	/// English String: "Sell"
	/// </summary>
	public virtual string ActionSell => "Sell";

	/// <summary>
	/// Key: "Action.SellNow"
	/// Sell Now
	/// English String: "Sell Now"
	/// </summary>
	public virtual string ActionSellNow => "Sell Now";

	/// <summary>
	/// Key: "Action.TakeOff"
	/// Action on context menu on owned item detail page.
	/// English String: "Take Off"
	/// </summary>
	public virtual string ActionTakeOff => "Take Off";

	/// <summary>
	/// Key: "Action.TakeOffSale"
	/// English String: "Take Off Sale"
	/// </summary>
	public virtual string ActionTakeOffSale => "Take Off Sale";

	/// <summary>
	/// Key: "Action.TryOn"
	/// English String: "Try On"
	/// </summary>
	public virtual string ActionTryOn => "Try On";

	/// <summary>
	/// Key: "Action.Upgrade"
	/// English String: "Upgrade"
	/// </summary>
	public virtual string ActionUpgrade => "Upgrade";

	/// <summary>
	/// Key: "Action.Wear"
	/// Action on context menu on owned item
	/// English String: "Wear"
	/// </summary>
	public virtual string ActionWear => "Wear";

	/// <summary>
	/// Key: "Action.Yes"
	/// Yes
	/// English String: "Yes"
	/// </summary>
	public virtual string ActionYes => "Yes";

	/// <summary>
	/// Key: "Heading.IncludedItems"
	/// Included items for a bundle of items. User purchases a bundle and will receive all items that will show below this heading.
	/// English String: "Included Items"
	/// </summary>
	public virtual string HeadingIncludedItems => "Included Items";

	/// <summary>
	/// Key: "Heading.PromoteItem"
	/// dialog heading
	/// English String: "Promote Item"
	/// </summary>
	public virtual string HeadingPromoteItem => "Promote Item";

	/// <summary>
	/// Key: "Label.AssetGrantedModalAcceptText"
	/// English String: "OK"
	/// </summary>
	public virtual string LabelAssetGrantedModalAcceptText => "OK";

	/// <summary>
	/// Key: "Label.AssetGrantedModalMessage"
	/// English String: "You just got this item courtesy of our sponsor."
	/// </summary>
	public virtual string LabelAssetGrantedModalMessage => "You just got this item courtesy of our sponsor.";

	/// <summary>
	/// Key: "Label.AssetGrantedModalTitle"
	/// English String: "This item is now yours"
	/// </summary>
	public virtual string LabelAssetGrantedModalTitle => "This item is now yours";

	/// <summary>
	/// Key: "Label.Attributes"
	/// English String: "Attributes"
	/// </summary>
	public virtual string LabelAttributes => "Attributes";

	/// <summary>
	/// Key: "Label.BestPrice"
	/// English String: "Best Price"
	/// </summary>
	public virtual string LabelBestPrice => "Best Price";

	/// <summary>
	/// Key: "Label.BuildersClubExclusive"
	/// label for Builders Club requirement
	/// English String: "Builders Club exclusive."
	/// </summary>
	public virtual string LabelBuildersClubExclusive => "Builders Club exclusive.";

	/// <summary>
	/// Key: "Label.DeleteFromInventoryConfirm"
	/// confirmation message before deletion
	/// English String: "Are you sure you want to permanently DELETE this item from your inventory?"
	/// </summary>
	public virtual string LabelDeleteFromInventoryConfirm => "Are you sure you want to permanently DELETE this item from your inventory?";

	/// <summary>
	/// Key: "Label.DeleteItem"
	/// Delete Item
	/// English String: "Delete Item"
	/// </summary>
	public virtual string LabelDeleteItem => "Delete Item";

	/// <summary>
	/// Key: "Label.Description"
	/// English String: "Description"
	/// </summary>
	public virtual string LabelDescription => "Description";

	/// <summary>
	/// Key: "Label.DisableBadgeConfirm"
	/// Are you sure you want to disable this Badge?
	/// English String: "Are you sure you want to disable this Badge?"
	/// </summary>
	public virtual string LabelDisableBadgeConfirm => "Are you sure you want to disable this Badge?";

	/// <summary>
	/// Key: "Label.DiscontinuedItem"
	/// label
	/// English String: "Discontinued item, resellable."
	/// </summary>
	public virtual string LabelDiscontinuedItem => "Discontinued item, resellable.";

	/// <summary>
	/// Key: "Label.EnableBadgeConfirm"
	/// Are you sure you want to enable this Badge?
	/// English String: "Are you sure you want to enable this Badge?"
	/// </summary>
	public virtual string LabelEnableBadgeConfirm => "Are you sure you want to enable this Badge?";

	/// <summary>
	/// Key: "Label.ErrorOccurred"
	/// English String: "Error occurred"
	/// </summary>
	public virtual string LabelErrorOccurred => "Error occurred";

	/// <summary>
	/// Key: "Label.Free"
	/// English String: "Free"
	/// </summary>
	public virtual string LabelFree => "Free";

	/// <summary>
	/// Key: "Label.Genres"
	/// English String: "Genres"
	/// </summary>
	public virtual string LabelGenres => "Genres";

	/// <summary>
	/// Key: "Label.GetBuildersClub"
	/// Only Builders Club members can re-sell collectible items. Get Builders Club today!
	/// English String: "Only Builders Club members can re-sell collectible items. Get Builders Club today!"
	/// </summary>
	public virtual string LabelGetBuildersClub => "Only Builders Club members can re-sell collectible items. Get Builders Club today!";

	/// <summary>
	/// Key: "Label.GetPremiumMembership"
	/// English String: "Only Premium members can re-sell collectible items. Get Premium today!"
	/// </summary>
	public virtual string LabelGetPremiumMembership => "Only Premium members can re-sell collectible items. Get Premium today!";

	/// <summary>
	/// Key: "Label.InvalidPlace"
	/// text label
	/// English String: "Invalid Place."
	/// </summary>
	public virtual string LabelInvalidPlace => "Invalid Place.";

	/// <summary>
	/// Key: "Label.InvalidProduct"
	/// label
	/// English String: "Invalid Product."
	/// </summary>
	public virtual string LabelInvalidProduct => "Invalid Product.";

	/// <summary>
	/// Key: "Label.ItemAvailable"
	/// User is looking at the details of an item which they already own in their inventory.
	/// English String: "This item is available in your inventory."
	/// </summary>
	public virtual string LabelItemAvailable => "This item is available in your inventory.";

	/// <summary>
	/// Key: "Label.ItemNotForSale"
	/// User is looking at the details of an item that cannot be purchased.
	/// English String: "This item is not currently for sale."
	/// </summary>
	public virtual string LabelItemNotForSale => "This item is not currently for sale.";

	/// <summary>
	/// Key: "Label.ItemOwned"
	/// English String: "Item Owned"
	/// </summary>
	public virtual string LabelItemOwned => "Item Owned";

	/// <summary>
	/// Key: "Label.None"
	/// English String: "None"
	/// </summary>
	public virtual string LabelNone => "None";

	/// <summary>
	/// Key: "Label.NotAvailable"
	/// English String: "N/A"
	/// </summary>
	public virtual string LabelNotAvailable => "N/A";

	/// <summary>
	/// Key: "Label.Price"
	/// English String: "Price"
	/// </summary>
	public virtual string LabelPrice => "Price";

	/// <summary>
	/// Key: "Label.PriceIsInvalid"
	/// English String: "Price is invalid"
	/// </summary>
	public virtual string LabelPriceIsInvalid => "Price is invalid";

	/// <summary>
	/// Key: "Label.PriceMinimumOne"
	/// English String: "Price (minimum 1)"
	/// </summary>
	public virtual string LabelPriceMinimumOne => "Price (minimum 1)";

	/// <summary>
	/// Key: "Label.PurchaseCompleted"
	/// English String: "Purchase Completed"
	/// </summary>
	public virtual string LabelPurchaseCompleted => "Purchase Completed";

	/// <summary>
	/// Key: "Label.Rarity"
	/// English String: "Rarity"
	/// </summary>
	public virtual string LabelRarity => "Rarity";

	/// <summary>
	/// Key: "Label.ReadMore"
	/// English String: "Read More"
	/// </summary>
	public virtual string LabelReadMore => "Read More";

	/// <summary>
	/// Key: "Label.RentingItem"
	/// English String: "Renting Item"
	/// </summary>
	public virtual string LabelRentingItem => "Renting Item";

	/// <summary>
	/// Key: "Label.Rthro"
	/// "Anthro" but replace the beginning with "R" to be consistent with "R6" and "R16"
	/// English String: "Rthro"
	/// </summary>
	public virtual string LabelRthro => "Rthro";

	/// <summary>
	/// Key: "Label.SellYourCollectibleItem"
	/// Sell Your Collectible Item
	/// English String: "Sell Your Collectible Item"
	/// </summary>
	public virtual string LabelSellYourCollectibleItem => "Sell Your Collectible Item";

	/// <summary>
	/// Key: "Label.SerializedLimitedRelease"
	/// label
	/// English String: "Serialized limited release, resellable."
	/// </summary>
	public virtual string LabelSerializedLimitedRelease => "Serialized limited release, resellable.";

	/// <summary>
	/// Key: "Label.SerialNotAvailable"
	/// English String: "Serial N/A"
	/// </summary>
	public virtual string LabelSerialNotAvailable => "Serial N/A";

	/// <summary>
	/// Key: "Label.SerialNumber"
	/// English String: "Serial Number"
	/// </summary>
	public virtual string LabelSerialNumber => "Serial Number";

	/// <summary>
	/// Key: "Label.ShowLess"
	/// Show Less
	/// English String: "Show Less"
	/// </summary>
	public virtual string LabelShowLess => "Show Less";

	/// <summary>
	/// Key: "Label.Tags"
	/// A label to indicate a list of tags on an item (i.e. "red, belt, shoes, denim" could be some tags for a Pants item that was red jeans with a belt and shoes)
	/// English String: "Tags"
	/// </summary>
	public virtual string LabelTags => "Tags";

	/// <summary>
	/// Key: "Label.TakeOffSale"
	/// Take off Sale
	/// English String: "Take off Sale"
	/// </summary>
	public virtual string LabelTakeOffSale => "Take off Sale";

	/// <summary>
	/// Key: "Label.TakeOffSaleConfirm"
	/// English String: "Are you sure you want to take the item off sale?"
	/// </summary>
	public virtual string LabelTakeOffSaleConfirm => "Are you sure you want to take the item off sale?";

	/// <summary>
	/// Key: "Label.ThirteenPlusOnly"
	/// label
	/// English String: "13+ Only."
	/// </summary>
	public virtual string LabelThirteenPlusOnly => "13+ Only.";

	/// <summary>
	/// Key: "Label.Type"
	/// English String: "Type"
	/// </summary>
	public virtual string LabelType => "Type";

	/// <summary>
	/// Key: "Label.Updated"
	/// English String: "Updated"
	/// </summary>
	public virtual string LabelUpdated => "Updated";

	/// <summary>
	/// Key: "Label.YouGet"
	/// Amount user gets after Marketplace fee deduction.
	/// English String: "You get"
	/// </summary>
	public virtual string LabelYouGet => "You get";

	/// <summary>
	/// Key: "Response.AddedToProfile"
	/// success message when item is added to profile
	/// English String: "Added to your profile"
	/// </summary>
	public virtual string ResponseAddedToProfile => "Added to your profile";

	/// <summary>
	/// Key: "Response.AddedToYourAvater"
	/// Added to your Avatar
	/// English String: "Added to your Avatar"
	/// </summary>
	public virtual string ResponseAddedToYourAvater => "Added to your Avatar";

	/// <summary>
	/// Key: "Response.AlreadyHaveMaxItems"
	/// error message
	/// English String: "You already have the maximum number of items on your game!"
	/// </summary>
	public virtual string ResponseAlreadyHaveMaxItems => "You already have the maximum number of items on your game!";

	/// <summary>
	/// Key: "Response.DisabledBadge"
	/// Successfully disabled the badge
	/// English String: "Successfully disabled the badge"
	/// </summary>
	public virtual string ResponseDisabledBadge => "Successfully disabled the badge";

	/// <summary>
	/// Key: "Response.EnabledBadge"
	/// Successfully enabled the badge
	/// English String: "Successfully enabled the badge"
	/// </summary>
	public virtual string ResponseEnabledBadge => "Successfully enabled the badge";

	/// <summary>
	/// Key: "Response.FailedToAddToProfile"
	/// error message when item could not be added to profile
	/// English String: "Failed to add to profile"
	/// </summary>
	public virtual string ResponseFailedToAddToProfile => "Failed to add to profile";

	/// <summary>
	/// Key: "Response.FailedToDeleteFromInventory"
	/// Failed to delete item from inventory
	/// English String: "Failed to delete item from inventory"
	/// </summary>
	public virtual string ResponseFailedToDeleteFromInventory => "Failed to delete item from inventory";

	/// <summary>
	/// Key: "Response.FailedToDisableBadge"
	/// Failed to disable badge
	/// English String: "Failed to disable badge"
	/// </summary>
	public virtual string ResponseFailedToDisableBadge => "Failed to disable badge";

	/// <summary>
	/// Key: "Response.FailedToEnableBadge"
	/// Failed to enable badge
	/// English String: "Failed to enable badge"
	/// </summary>
	public virtual string ResponseFailedToEnableBadge => "Failed to enable badge";

	/// <summary>
	/// Key: "Response.FailedToRemoveFromProfile"
	/// error message when items could not be removed
	/// English String: "Failed to remove from profile"
	/// </summary>
	public virtual string ResponseFailedToRemoveFromProfile => "Failed to remove from profile";

	/// <summary>
	/// Key: "Response.RemovedFromInventory"
	/// Successfully removed from your inventory
	/// English String: "Successfully removed from your inventory"
	/// </summary>
	public virtual string ResponseRemovedFromInventory => "Successfully removed from your inventory";

	/// <summary>
	/// Key: "Response.RemovedFromProfile"
	/// message when an item is removed from profile
	/// English String: "Removed from your profile"
	/// </summary>
	public virtual string ResponseRemovedFromProfile => "Removed from your profile";

	/// <summary>
	/// Key: "Response.RemovedFromYourAvater"
	/// Removed from your Avatar
	/// English String: "Removed from your Avatar"
	/// </summary>
	public virtual string ResponseRemovedFromYourAvater => "Removed from your Avatar";

	public ItemResources_en_us(TranslationResourceState state)
		: base(state)
	{
		_AllKeys = new Lazy<IReadOnlyDictionary<string, string>>(() => new Dictionary<string, string>
		{
			{
				"Action.Add",
				_GetTemplateForActionAdd()
			},
			{
				"Action.AddToGame",
				_GetTemplateForActionAddToGame()
			},
			{
				"Action.AddToProfile",
				_GetTemplateForActionAddToProfile()
			},
			{
				"Action.Advertise",
				_GetTemplateForActionAdvertise()
			},
			{
				"Action.Agree",
				_GetTemplateForActionAgree()
			},
			{
				"Action.Buy",
				_GetTemplateForActionBuy()
			},
			{
				"Action.Cancel",
				_GetTemplateForActionCancel()
			},
			{
				"Action.Configure",
				_GetTemplateForActionConfigure()
			},
			{
				"Action.Confirm",
				_GetTemplateForActionConfirm()
			},
			{
				"Action.Delete",
				_GetTemplateForActionDelete()
			},
			{
				"Action.DisableBadge",
				_GetTemplateForActionDisableBadge()
			},
			{
				"Action.EditAvatar",
				_GetTemplateForActionEditAvatar()
			},
			{
				"Action.EnableBadge",
				_GetTemplateForActionEnableBadge()
			},
			{
				"Action.Get",
				_GetTemplateForActionGet()
			},
			{
				"Action.Install",
				_GetTemplateForActionInstall()
			},
			{
				"Action.Inventory",
				_GetTemplateForActionInventory()
			},
			{
				"Action.No",
				_GetTemplateForActionNo()
			},
			{
				"Action.Ok",
				_GetTemplateForActionOk()
			},
			{
				"Action.Remove",
				_GetTemplateForActionRemove()
			},
			{
				"Action.RemoveFromProfile",
				_GetTemplateForActionRemoveFromProfile()
			},
			{
				"Action.Rent",
				_GetTemplateForActionRent()
			},
			{
				"Action.ReportItem",
				_GetTemplateForActionReportItem()
			},
			{
				"Action.Sell",
				_GetTemplateForActionSell()
			},
			{
				"Action.SellNow",
				_GetTemplateForActionSellNow()
			},
			{
				"Action.TakeOff",
				_GetTemplateForActionTakeOff()
			},
			{
				"Action.TakeOffSale",
				_GetTemplateForActionTakeOffSale()
			},
			{
				"Action.TryOn",
				_GetTemplateForActionTryOn()
			},
			{
				"Action.Upgrade",
				_GetTemplateForActionUpgrade()
			},
			{
				"Action.Wear",
				_GetTemplateForActionWear()
			},
			{
				"Action.Yes",
				_GetTemplateForActionYes()
			},
			{
				"Heading.IncludedItems",
				_GetTemplateForHeadingIncludedItems()
			},
			{
				"Heading.PromoteItem",
				_GetTemplateForHeadingPromoteItem()
			},
			{
				"Label.AllowPlayersPlusEarn",
				_GetTemplateForLabelAllowPlayersPlusEarn()
			},
			{
				"Label.AssetGrantedModalAcceptText",
				_GetTemplateForLabelAssetGrantedModalAcceptText()
			},
			{
				"Label.AssetGrantedModalMessage",
				_GetTemplateForLabelAssetGrantedModalMessage()
			},
			{
				"Label.AssetGrantedModalTitle",
				_GetTemplateForLabelAssetGrantedModalTitle()
			},
			{
				"Label.Attributes",
				_GetTemplateForLabelAttributes()
			},
			{
				"Label.BestPrice",
				_GetTemplateForLabelBestPrice()
			},
			{
				"Label.BuildersClubExclusive",
				_GetTemplateForLabelBuildersClubExclusive()
			},
			{
				"Label.By",
				_GetTemplateForLabelBy()
			},
			{
				"Label.CountdownTimerDayHourMinute",
				_GetTemplateForLabelCountdownTimerDayHourMinute()
			},
			{
				"Label.DeleteFromInventoryConfirm",
				_GetTemplateForLabelDeleteFromInventoryConfirm()
			},
			{
				"Label.DeleteItem",
				_GetTemplateForLabelDeleteItem()
			},
			{
				"Label.Description",
				_GetTemplateForLabelDescription()
			},
			{
				"Label.DisableBadgeConfirm",
				_GetTemplateForLabelDisableBadgeConfirm()
			},
			{
				"Label.DiscontinuedItem",
				_GetTemplateForLabelDiscontinuedItem()
			},
			{
				"Label.EarnBadgeGameLink",
				_GetTemplateForLabelEarnBadgeGameLink()
			},
			{
				"Label.EnableBadgeConfirm",
				_GetTemplateForLabelEnableBadgeConfirm()
			},
			{
				"Label.ErrorOccurred",
				_GetTemplateForLabelErrorOccurred()
			},
			{
				"Label.Free",
				_GetTemplateForLabelFree()
			},
			{
				"Label.Genres",
				_GetTemplateForLabelGenres()
			},
			{
				"Label.GetBuildersClub",
				_GetTemplateForLabelGetBuildersClub()
			},
			{
				"Label.GetPremiumMembership",
				_GetTemplateForLabelGetPremiumMembership()
			},
			{
				"Label.InvalidPlace",
				_GetTemplateForLabelInvalidPlace()
			},
			{
				"Label.InvalidProduct",
				_GetTemplateForLabelInvalidProduct()
			},
			{
				"Label.ItemAvailable",
				_GetTemplateForLabelItemAvailable()
			},
			{
				"Label.ItemNotForSale",
				_GetTemplateForLabelItemNotForSale()
			},
			{
				"Label.ItemOwned",
				_GetTemplateForLabelItemOwned()
			},
			{
				"Label.ItemOwnedAmount",
				_GetTemplateForLabelItemOwnedAmount()
			},
			{
				"Label.ItemRecentPrice",
				_GetTemplateForLabelItemRecentPrice()
			},
			{
				"Label.MarketplaceFee",
				_GetTemplateForLabelMarketplaceFee()
			},
			{
				"Label.None",
				_GetTemplateForLabelNone()
			},
			{
				"Label.NotAvailable",
				_GetTemplateForLabelNotAvailable()
			},
			{
				"Label.OffsaleCountdownHourMinuteSecond",
				_GetTemplateForLabelOffsaleCountdownHourMinuteSecond()
			},
			{
				"Label.Price",
				_GetTemplateForLabelPrice()
			},
			{
				"Label.PriceIsInvalid",
				_GetTemplateForLabelPriceIsInvalid()
			},
			{
				"Label.PriceMinimumOne",
				_GetTemplateForLabelPriceMinimumOne()
			},
			{
				"Label.PurchaseCompleted",
				_GetTemplateForLabelPurchaseCompleted()
			},
			{
				"Label.Rarity",
				_GetTemplateForLabelRarity()
			},
			{
				"Label.ReadMore",
				_GetTemplateForLabelReadMore()
			},
			{
				"Label.RentingItem",
				_GetTemplateForLabelRentingItem()
			},
			{
				"Label.Rthro",
				_GetTemplateForLabelRthro()
			},
			{
				"Label.SellConfirm",
				_GetTemplateForLabelSellConfirm()
			},
			{
				"Label.SellYourCollectibleItem",
				_GetTemplateForLabelSellYourCollectibleItem()
			},
			{
				"Label.SerializedLimitedRelease",
				_GetTemplateForLabelSerializedLimitedRelease()
			},
			{
				"Label.SerialNotAvailable",
				_GetTemplateForLabelSerialNotAvailable()
			},
			{
				"Label.SerialNumber",
				_GetTemplateForLabelSerialNumber()
			},
			{
				"Label.SerialNumberOfTotal",
				_GetTemplateForLabelSerialNumberOfTotal()
			},
			{
				"Label.ShowLess",
				_GetTemplateForLabelShowLess()
			},
			{
				"Label.Tags",
				_GetTemplateForLabelTags()
			},
			{
				"Label.TakeOffSale",
				_GetTemplateForLabelTakeOffSale()
			},
			{
				"Label.TakeOffSaleConfirm",
				_GetTemplateForLabelTakeOffSaleConfirm()
			},
			{
				"Label.ThirteenPlusOnly",
				_GetTemplateForLabelThirteenPlusOnly()
			},
			{
				"Label.Type",
				_GetTemplateForLabelType()
			},
			{
				"Label.Updated",
				_GetTemplateForLabelUpdated()
			},
			{
				"Label.UpdatedBy",
				_GetTemplateForLabelUpdatedBy()
			},
			{
				"Label.UseGamePassLink",
				_GetTemplateForLabelUseGamePassLink()
			},
			{
				"Label.YouGet",
				_GetTemplateForLabelYouGet()
			},
			{
				"Response.AddedToProfile",
				_GetTemplateForResponseAddedToProfile()
			},
			{
				"Response.AddedToYourAvater",
				_GetTemplateForResponseAddedToYourAvater()
			},
			{
				"Response.AlreadyHaveMaxItems",
				_GetTemplateForResponseAlreadyHaveMaxItems()
			},
			{
				"Response.DisabledBadge",
				_GetTemplateForResponseDisabledBadge()
			},
			{
				"Response.EnabledBadge",
				_GetTemplateForResponseEnabledBadge()
			},
			{
				"Response.FailedToAddToProfile",
				_GetTemplateForResponseFailedToAddToProfile()
			},
			{
				"Response.FailedToDeleteFromInventory",
				_GetTemplateForResponseFailedToDeleteFromInventory()
			},
			{
				"Response.FailedToDisableBadge",
				_GetTemplateForResponseFailedToDisableBadge()
			},
			{
				"Response.FailedToEnableBadge",
				_GetTemplateForResponseFailedToEnableBadge()
			},
			{
				"Response.FailedToRemoveFromProfile",
				_GetTemplateForResponseFailedToRemoveFromProfile()
			},
			{
				"Response.GearAddSuccess",
				_GetTemplateForResponseGearAddSuccess()
			},
			{
				"Response.GearAlreadyAdded",
				_GetTemplateForResponseGearAlreadyAdded()
			},
			{
				"Response.RemovedFromInventory",
				_GetTemplateForResponseRemovedFromInventory()
			},
			{
				"Response.RemovedFromProfile",
				_GetTemplateForResponseRemovedFromProfile()
			},
			{
				"Response.RemovedFromYourAvater",
				_GetTemplateForResponseRemovedFromYourAvater()
			}
		});
	}

	public IReadOnlyDictionary<string, string> GetAllKeys()
	{
		return _AllKeys.Value;
	}

	public string GetFullContentNamespaceName()
	{
		return "Feature.Item";
	}

	protected virtual string _GetTemplateForActionAdd()
	{
		return "Add";
	}

	protected virtual string _GetTemplateForActionAddToGame()
	{
		return "Add To Game";
	}

	protected virtual string _GetTemplateForActionAddToProfile()
	{
		return "Add to Profile";
	}

	protected virtual string _GetTemplateForActionAdvertise()
	{
		return "Advertise";
	}

	protected virtual string _GetTemplateForActionAgree()
	{
		return "Agree";
	}

	protected virtual string _GetTemplateForActionBuy()
	{
		return "Buy";
	}

	protected virtual string _GetTemplateForActionCancel()
	{
		return "Cancel";
	}

	protected virtual string _GetTemplateForActionConfigure()
	{
		return "Configure";
	}

	protected virtual string _GetTemplateForActionConfirm()
	{
		return "Confirm";
	}

	protected virtual string _GetTemplateForActionDelete()
	{
		return "Delete";
	}

	protected virtual string _GetTemplateForActionDisableBadge()
	{
		return "Disable Badge";
	}

	protected virtual string _GetTemplateForActionEditAvatar()
	{
		return "Edit Avatar";
	}

	protected virtual string _GetTemplateForActionEnableBadge()
	{
		return "Enable Badge";
	}

	protected virtual string _GetTemplateForActionGet()
	{
		return "Get";
	}

	protected virtual string _GetTemplateForActionInstall()
	{
		return "Install";
	}

	protected virtual string _GetTemplateForActionInventory()
	{
		return "Inventory";
	}

	protected virtual string _GetTemplateForActionNo()
	{
		return "No";
	}

	protected virtual string _GetTemplateForActionOk()
	{
		return "OK";
	}

	protected virtual string _GetTemplateForActionRemove()
	{
		return "Remove";
	}

	protected virtual string _GetTemplateForActionRemoveFromProfile()
	{
		return "Remove from Profile";
	}

	protected virtual string _GetTemplateForActionRent()
	{
		return "Rent";
	}

	protected virtual string _GetTemplateForActionReportItem()
	{
		return "Report Item";
	}

	protected virtual string _GetTemplateForActionSell()
	{
		return "Sell";
	}

	protected virtual string _GetTemplateForActionSellNow()
	{
		return "Sell Now";
	}

	protected virtual string _GetTemplateForActionTakeOff()
	{
		return "Take Off";
	}

	protected virtual string _GetTemplateForActionTakeOffSale()
	{
		return "Take Off Sale";
	}

	protected virtual string _GetTemplateForActionTryOn()
	{
		return "Try On";
	}

	protected virtual string _GetTemplateForActionUpgrade()
	{
		return "Upgrade";
	}

	protected virtual string _GetTemplateForActionWear()
	{
		return "Wear";
	}

	protected virtual string _GetTemplateForActionYes()
	{
		return "Yes";
	}

	protected virtual string _GetTemplateForHeadingIncludedItems()
	{
		return "Included Items";
	}

	protected virtual string _GetTemplateForHeadingPromoteItem()
	{
		return "Promote Item";
	}

	/// <summary>
	/// Key: "Label.AllowPlayersPlusEarn"
	/// English String: "Allow players to use this gear inside your game plus earn {affiliateSaleTotal} when it's purchased from your game page."
	/// </summary>
	public virtual string LabelAllowPlayersPlusEarn(string affiliateSaleTotal)
	{
		return $"Allow players to use this gear inside your game plus earn {affiliateSaleTotal} when it's purchased from your game page.";
	}

	protected virtual string _GetTemplateForLabelAllowPlayersPlusEarn()
	{
		return "Allow players to use this gear inside your game plus earn {affiliateSaleTotal} when it's purchased from your game page.";
	}

	protected virtual string _GetTemplateForLabelAssetGrantedModalAcceptText()
	{
		return "OK";
	}

	protected virtual string _GetTemplateForLabelAssetGrantedModalMessage()
	{
		return "You just got this item courtesy of our sponsor.";
	}

	protected virtual string _GetTemplateForLabelAssetGrantedModalTitle()
	{
		return "This item is now yours";
	}

	protected virtual string _GetTemplateForLabelAttributes()
	{
		return "Attributes";
	}

	protected virtual string _GetTemplateForLabelBestPrice()
	{
		return "Best Price";
	}

	protected virtual string _GetTemplateForLabelBuildersClubExclusive()
	{
		return "Builders Club exclusive.";
	}

	/// <summary>
	/// Key: "Label.By"
	/// English String: "By {creator}"
	/// </summary>
	public virtual string LabelBy(string creator)
	{
		return $"By {creator}";
	}

	protected virtual string _GetTemplateForLabelBy()
	{
		return "By {creator}";
	}

	/// <summary>
	/// Key: "Label.CountdownTimerDayHourMinute"
	/// Item will go offsale in a variable number of days (d), hours (h), and minutes (m). Please use a narrow translation if possible for d/h/m.
	/// English String: "Offsale in {numberOfDays} d {numberOfHours} h {numberOfMinutes} m"
	/// </summary>
	public virtual string LabelCountdownTimerDayHourMinute(string numberOfDays, string numberOfHours, string numberOfMinutes)
	{
		return $"Offsale in {numberOfDays} d {numberOfHours} h {numberOfMinutes} m";
	}

	protected virtual string _GetTemplateForLabelCountdownTimerDayHourMinute()
	{
		return "Offsale in {numberOfDays} d {numberOfHours} h {numberOfMinutes} m";
	}

	protected virtual string _GetTemplateForLabelDeleteFromInventoryConfirm()
	{
		return "Are you sure you want to permanently DELETE this item from your inventory?";
	}

	protected virtual string _GetTemplateForLabelDeleteItem()
	{
		return "Delete Item";
	}

	protected virtual string _GetTemplateForLabelDescription()
	{
		return "Description";
	}

	protected virtual string _GetTemplateForLabelDisableBadgeConfirm()
	{
		return "Are you sure you want to disable this Badge?";
	}

	protected virtual string _GetTemplateForLabelDiscontinuedItem()
	{
		return "Discontinued item, resellable.";
	}

	/// <summary>
	/// Key: "Label.EarnBadgeGameLink"
	/// placeLink will carry the game name, which is not localized at the moment.
	/// English String: "Earn this Badge in: {placeLink}"
	/// </summary>
	public virtual string LabelEarnBadgeGameLink(string placeLink)
	{
		return $"Earn this Badge in: {placeLink}";
	}

	protected virtual string _GetTemplateForLabelEarnBadgeGameLink()
	{
		return "Earn this Badge in: {placeLink}";
	}

	protected virtual string _GetTemplateForLabelEnableBadgeConfirm()
	{
		return "Are you sure you want to enable this Badge?";
	}

	protected virtual string _GetTemplateForLabelErrorOccurred()
	{
		return "Error occurred";
	}

	protected virtual string _GetTemplateForLabelFree()
	{
		return "Free";
	}

	protected virtual string _GetTemplateForLabelGenres()
	{
		return "Genres";
	}

	protected virtual string _GetTemplateForLabelGetBuildersClub()
	{
		return "Only Builders Club members can re-sell collectible items. Get Builders Club today!";
	}

	protected virtual string _GetTemplateForLabelGetPremiumMembership()
	{
		return "Only Premium members can re-sell collectible items. Get Premium today!";
	}

	protected virtual string _GetTemplateForLabelInvalidPlace()
	{
		return "Invalid Place.";
	}

	protected virtual string _GetTemplateForLabelInvalidProduct()
	{
		return "Invalid Product.";
	}

	protected virtual string _GetTemplateForLabelItemAvailable()
	{
		return "This item is available in your inventory.";
	}

	protected virtual string _GetTemplateForLabelItemNotForSale()
	{
		return "This item is not currently for sale.";
	}

	protected virtual string _GetTemplateForLabelItemOwned()
	{
		return "Item Owned";
	}

	/// <summary>
	/// Key: "Label.ItemOwnedAmount"
	/// English String: "Item Owned ({amount})"
	/// </summary>
	public virtual string LabelItemOwnedAmount(string amount)
	{
		return $"Item Owned ({amount})";
	}

	protected virtual string _GetTemplateForLabelItemOwnedAmount()
	{
		return "Item Owned ({amount})";
	}

	/// <summary>
	/// Key: "Label.ItemRecentPrice"
	/// English String: "{name}'s recent average price is {price}."
	/// </summary>
	public virtual string LabelItemRecentPrice(string name, string price)
	{
		return $"{name}'s recent average price is {price}.";
	}

	protected virtual string _GetTemplateForLabelItemRecentPrice()
	{
		return "{name}'s recent average price is {price}.";
	}

	/// <summary>
	/// Key: "Label.MarketplaceFee"
	/// Marketplace fee amount
	/// English String: "Marketplace fee (at {percent}%)"
	/// </summary>
	public virtual string LabelMarketplaceFee(string percent)
	{
		return $"Marketplace fee (at {percent}%)";
	}

	protected virtual string _GetTemplateForLabelMarketplaceFee()
	{
		return "Marketplace fee (at {percent}%)";
	}

	protected virtual string _GetTemplateForLabelNone()
	{
		return "None";
	}

	protected virtual string _GetTemplateForLabelNotAvailable()
	{
		return "N/A";
	}

	/// <summary>
	/// Key: "Label.OffsaleCountdownHourMinuteSecond"
	/// Item will go offsale in a variable number of hours (h), minutes (m), and seconds (s). Please use a narrow translation if possible for h/m/s.
	/// English String: "Offsale in {numberOfHours} h {numberOfMinutes} m {numberOfSeconds} s"
	/// </summary>
	public virtual string LabelOffsaleCountdownHourMinuteSecond(string numberOfHours, string numberOfMinutes, string numberOfSeconds)
	{
		return $"Offsale in {numberOfHours} h {numberOfMinutes} m {numberOfSeconds} s";
	}

	protected virtual string _GetTemplateForLabelOffsaleCountdownHourMinuteSecond()
	{
		return "Offsale in {numberOfHours} h {numberOfMinutes} m {numberOfSeconds} s";
	}

	protected virtual string _GetTemplateForLabelPrice()
	{
		return "Price";
	}

	protected virtual string _GetTemplateForLabelPriceIsInvalid()
	{
		return "Price is invalid";
	}

	protected virtual string _GetTemplateForLabelPriceMinimumOne()
	{
		return "Price (minimum 1)";
	}

	protected virtual string _GetTemplateForLabelPurchaseCompleted()
	{
		return "Purchase Completed";
	}

	protected virtual string _GetTemplateForLabelRarity()
	{
		return "Rarity";
	}

	protected virtual string _GetTemplateForLabelReadMore()
	{
		return "Read More";
	}

	protected virtual string _GetTemplateForLabelRentingItem()
	{
		return "Renting Item";
	}

	protected virtual string _GetTemplateForLabelRthro()
	{
		return "Rthro";
	}

	/// <summary>
	/// Key: "Label.SellConfirm"
	/// English String: "Are you sure you want to sell {name} for {price}?"
	/// </summary>
	public virtual string LabelSellConfirm(string name, string price)
	{
		return $"Are you sure you want to sell {name} for {price}?";
	}

	protected virtual string _GetTemplateForLabelSellConfirm()
	{
		return "Are you sure you want to sell {name} for {price}?";
	}

	protected virtual string _GetTemplateForLabelSellYourCollectibleItem()
	{
		return "Sell Your Collectible Item";
	}

	protected virtual string _GetTemplateForLabelSerializedLimitedRelease()
	{
		return "Serialized limited release, resellable.";
	}

	protected virtual string _GetTemplateForLabelSerialNotAvailable()
	{
		return "Serial N/A";
	}

	protected virtual string _GetTemplateForLabelSerialNumber()
	{
		return "Serial Number";
	}

	/// <summary>
	/// Key: "Label.SerialNumberOfTotal"
	/// English String: "Serial #{number} of {total}"
	/// </summary>
	public virtual string LabelSerialNumberOfTotal(string number, string total)
	{
		return $"Serial #{number} of {total}";
	}

	protected virtual string _GetTemplateForLabelSerialNumberOfTotal()
	{
		return "Serial #{number} of {total}";
	}

	protected virtual string _GetTemplateForLabelShowLess()
	{
		return "Show Less";
	}

	protected virtual string _GetTemplateForLabelTags()
	{
		return "Tags";
	}

	protected virtual string _GetTemplateForLabelTakeOffSale()
	{
		return "Take off Sale";
	}

	protected virtual string _GetTemplateForLabelTakeOffSaleConfirm()
	{
		return "Are you sure you want to take the item off sale?";
	}

	protected virtual string _GetTemplateForLabelThirteenPlusOnly()
	{
		return "13+ Only.";
	}

	protected virtual string _GetTemplateForLabelType()
	{
		return "Type";
	}

	protected virtual string _GetTemplateForLabelUpdated()
	{
		return "Updated";
	}

	/// <summary>
	/// Key: "Label.UpdatedBy"
	/// English String: "(by {link})"
	/// </summary>
	public virtual string LabelUpdatedBy(string link)
	{
		return $"(by {link})";
	}

	protected virtual string _GetTemplateForLabelUpdatedBy()
	{
		return "(by {link})";
	}

	/// <summary>
	/// Key: "Label.UseGamePassLink"
	/// placeLink will carry game name which does not need to be localized
	/// English String: "Use this Game Pass in: {placeLink}"
	/// </summary>
	public virtual string LabelUseGamePassLink(string placeLink)
	{
		return $"Use this Game Pass in: {placeLink}";
	}

	protected virtual string _GetTemplateForLabelUseGamePassLink()
	{
		return "Use this Game Pass in: {placeLink}";
	}

	protected virtual string _GetTemplateForLabelYouGet()
	{
		return "You get";
	}

	protected virtual string _GetTemplateForResponseAddedToProfile()
	{
		return "Added to your profile";
	}

	protected virtual string _GetTemplateForResponseAddedToYourAvater()
	{
		return "Added to your Avatar";
	}

	protected virtual string _GetTemplateForResponseAlreadyHaveMaxItems()
	{
		return "You already have the maximum number of items on your game!";
	}

	protected virtual string _GetTemplateForResponseDisabledBadge()
	{
		return "Successfully disabled the badge";
	}

	protected virtual string _GetTemplateForResponseEnabledBadge()
	{
		return "Successfully enabled the badge";
	}

	protected virtual string _GetTemplateForResponseFailedToAddToProfile()
	{
		return "Failed to add to profile";
	}

	protected virtual string _GetTemplateForResponseFailedToDeleteFromInventory()
	{
		return "Failed to delete item from inventory";
	}

	protected virtual string _GetTemplateForResponseFailedToDisableBadge()
	{
		return "Failed to disable badge";
	}

	protected virtual string _GetTemplateForResponseFailedToEnableBadge()
	{
		return "Failed to enable badge";
	}

	protected virtual string _GetTemplateForResponseFailedToRemoveFromProfile()
	{
		return "Failed to remove from profile";
	}

	/// <summary>
	/// Key: "Response.GearAddSuccess"
	/// success message
	/// English String: "Added to your game, {placeName}."
	/// </summary>
	public virtual string ResponseGearAddSuccess(string placeName)
	{
		return $"Added to your game, {placeName}.";
	}

	protected virtual string _GetTemplateForResponseGearAddSuccess()
	{
		return "Added to your game, {placeName}.";
	}

	/// <summary>
	/// Key: "Response.GearAlreadyAdded"
	/// error message
	/// English String: "You have already added this gear to {placeName}."
	/// </summary>
	public virtual string ResponseGearAlreadyAdded(string placeName)
	{
		return $"You have already added this gear to {placeName}.";
	}

	protected virtual string _GetTemplateForResponseGearAlreadyAdded()
	{
		return "You have already added this gear to {placeName}.";
	}

	protected virtual string _GetTemplateForResponseRemovedFromInventory()
	{
		return "Successfully removed from your inventory";
	}

	protected virtual string _GetTemplateForResponseRemovedFromProfile()
	{
		return "Removed from your profile";
	}

	protected virtual string _GetTemplateForResponseRemovedFromYourAvater()
	{
		return "Removed from your Avatar";
	}
}
