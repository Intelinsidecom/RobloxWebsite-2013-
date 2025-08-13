using System;
using System.Collections.Generic;

namespace Roblox.TranslationResources.Feature;

internal class ItemModelResources_en_us : TranslationResourcesBase, IItemModelResources, ITranslationResources
{
	private readonly Lazy<IReadOnlyDictionary<string, string>> _AllKeys;

	/// <summary>
	/// Key: "Label.AmazonExclusiveItem"
	/// English String: "This is an Amazon exclusive item."
	/// </summary>
	public virtual string LabelAmazonExclusiveItem => "This is an Amazon exclusive item.";

	/// <summary>
	/// Key: "Label.AudioAssetBlockedCopyright"
	/// English String: "This audio asset has been blocked due to copyright violations.\n"
	/// </summary>
	public virtual string LabelAudioAssetBlockedCopyright => "This audio asset has been blocked due to copyright violations.\n";

	/// <summary>
	/// Key: "Label.GooglePlayExclusiveItem"
	/// English String: "This is a Google Play exclusive item."
	/// </summary>
	public virtual string LabelGooglePlayExclusiveItem => "This is a Google Play exclusive item.";

	/// <summary>
	/// Key: "Label.IosDeviceExclusiveItem"
	/// English String: "This is an iOS exclusive item."
	/// </summary>
	public virtual string LabelIosDeviceExclusiveItem => "This is an iOS exclusive item.";

	/// <summary>
	/// Key: "Label.ItemAvailableInventory"
	/// English String: "This item is available in your inventory."
	/// </summary>
	public virtual string LabelItemAvailableInventory => "This item is available in your inventory.";

	/// <summary>
	/// Key: "Label.ItemHasBeenModerated"
	/// English String: "This item has been moderated."
	/// </summary>
	public virtual string LabelItemHasBeenModerated => "This item has been moderated.";

	/// <summary>
	/// Key: "Label.ItemNoLongerForSale"
	/// English String: "This item is no longer for sale."
	/// </summary>
	public virtual string LabelItemNoLongerForSale => "This item is no longer for sale.";

	/// <summary>
	/// Key: "Label.ItemNotCurrentlyForSale"
	/// English String: "This item is not currently for sale."
	/// </summary>
	public virtual string LabelItemNotCurrentlyForSale => "This item is not currently for sale.";

	/// <summary>
	/// Key: "Label.MobileDeviceExclusiveItem"
	/// English String: "This is a mobile exclusive item."
	/// </summary>
	public virtual string LabelMobileDeviceExclusiveItem => "This is a mobile exclusive item.";

	/// <summary>
	/// Key: "Label.NoDescriptionAvailable"
	/// English String: "No description available."
	/// </summary>
	public virtual string LabelNoDescriptionAvailable => "No description available.";

	/// <summary>
	/// Key: "Label.NoOneCurrentlySelling"
	/// English String: "There is no one currently selling this item."
	/// </summary>
	public virtual string LabelNoOneCurrentlySelling => "There is no one currently selling this item.";

	/// <summary>
	/// Key: "Label.NoOtherSellers"
	/// English String: "No other sellers."
	/// </summary>
	public virtual string LabelNoOtherSellers => "No other sellers.";

	/// <summary>
	/// Key: "Label.NotAvailable"
	/// English String: "N/A"
	/// </summary>
	public virtual string LabelNotAvailable => "N/A";

	/// <summary>
	/// Key: "Label.PurchasingTemporarilyUnavailable"
	/// English String: "Purchasing is temporarily unavailable. Please try again later."
	/// </summary>
	public virtual string LabelPurchasingTemporarilyUnavailable => "Purchasing is temporarily unavailable. Please try again later.";

	/// <summary>
	/// Key: "Label.Resellers"
	/// English String: "Resellers"
	/// </summary>
	public virtual string LabelResellers => "Resellers";

	/// <summary>
	/// Key: "Label.RobloxAsset"
	/// English String: "Roblox Asset"
	/// </summary>
	public virtual string LabelRobloxAsset => "Roblox Asset";

	/// <summary>
	/// Key: "Label.TakeOff"
	/// English String: "Take Off"
	/// </summary>
	public virtual string LabelTakeOff => "Take Off";

	/// <summary>
	/// Key: "Label.ToInstallOpenStudio"
	/// English String: "To install, open this page in Roblox Studio."
	/// </summary>
	public virtual string LabelToInstallOpenStudio => "To install, open this page in Roblox Studio.";

	/// <summary>
	/// Key: "Label.Wear"
	/// English String: "Wear"
	/// </summary>
	public virtual string LabelWear => "Wear";

	/// <summary>
	/// Key: "Label.XboxOneExclusiveItem"
	/// English String: "This is a Xbox One exclusive item."
	/// </summary>
	public virtual string LabelXboxOneExclusiveItem => "This is a Xbox One exclusive item.";

	/// <summary>
	/// Key: "Label.YouAreSelling"
	/// English String: "You are selling this item."
	/// </summary>
	public virtual string LabelYouAreSelling => "You are selling this item.";

	public ItemModelResources_en_us(TranslationResourceState state)
		: base(state)
	{
		_AllKeys = new Lazy<IReadOnlyDictionary<string, string>>(() => new Dictionary<string, string>
		{
			{
				"Label.AmazonExclusiveItem",
				_GetTemplateForLabelAmazonExclusiveItem()
			},
			{
				"Label.AssetName",
				_GetTemplateForLabelAssetName()
			},
			{
				"Label.AssetOptionRental",
				_GetTemplateForLabelAssetOptionRental()
			},
			{
				"Label.AudioAssetBlockedCopyright",
				_GetTemplateForLabelAudioAssetBlockedCopyright()
			},
			{
				"Label.BcRequirementExclusiveItem",
				_GetTemplateForLabelBcRequirementExclusiveItem()
			},
			{
				"Label.ExpiresRentalTime",
				_GetTemplateForLabelExpiresRentalTime()
			},
			{
				"Label.GooglePlayExclusiveItem",
				_GetTemplateForLabelGooglePlayExclusiveItem()
			},
			{
				"Label.IosDeviceExclusiveItem",
				_GetTemplateForLabelIosDeviceExclusiveItem()
			},
			{
				"Label.ItemAvailableInventory",
				_GetTemplateForLabelItemAvailableInventory()
			},
			{
				"Label.ItemHasBeenModerated",
				_GetTemplateForLabelItemHasBeenModerated()
			},
			{
				"Label.ItemNoLongerForSale",
				_GetTemplateForLabelItemNoLongerForSale()
			},
			{
				"Label.ItemNotCurrentlyForSale",
				_GetTemplateForLabelItemNotCurrentlyForSale()
			},
			{
				"Label.LimitedQuantity",
				_GetTemplateForLabelLimitedQuantity()
			},
			{
				"Label.MetaDescriptionCatalog",
				_GetTemplateForLabelMetaDescriptionCatalog()
			},
			{
				"Label.MetaDescriptionLibrary",
				_GetTemplateForLabelMetaDescriptionLibrary()
			},
			{
				"Label.MetaDescriptionLibraryV2",
				_GetTemplateForLabelMetaDescriptionLibraryV2()
			},
			{
				"Label.MobileDeviceExclusiveItem",
				_GetTemplateForLabelMobileDeviceExclusiveItem()
			},
			{
				"Label.NoDescriptionAvailable",
				_GetTemplateForLabelNoDescriptionAvailable()
			},
			{
				"Label.NoOneCurrentlySelling",
				_GetTemplateForLabelNoOneCurrentlySelling()
			},
			{
				"Label.NoOtherSellers",
				_GetTemplateForLabelNoOtherSellers()
			},
			{
				"Label.NotAvailable",
				_GetTemplateForLabelNotAvailable()
			},
			{
				"Label.PriceChangedFrom",
				_GetTemplateForLabelPriceChangedFrom()
			},
			{
				"Label.PurchasingTemporarilyUnavailable",
				_GetTemplateForLabelPurchasingTemporarilyUnavailable()
			},
			{
				"Label.Resellers",
				_GetTemplateForLabelResellers()
			},
			{
				"Label.RobloxAsset",
				_GetTemplateForLabelRobloxAsset()
			},
			{
				"Label.SeeMoreResellers",
				_GetTemplateForLabelSeeMoreResellers()
			},
			{
				"Label.SerialNoOf",
				_GetTemplateForLabelSerialNoOf()
			},
			{
				"Label.TakeOff",
				_GetTemplateForLabelTakeOff()
			},
			{
				"Label.ToInstallOpenStudio",
				_GetTemplateForLabelToInstallOpenStudio()
			},
			{
				"Label.Wear",
				_GetTemplateForLabelWear()
			},
			{
				"Label.XboxOneExclusiveItem",
				_GetTemplateForLabelXboxOneExclusiveItem()
			},
			{
				"Label.YouAreSelling",
				_GetTemplateForLabelYouAreSelling()
			}
		});
	}

	public IReadOnlyDictionary<string, string> GetAllKeys()
	{
		return _AllKeys.Value;
	}

	public string GetFullContentNamespaceName()
	{
		return "Feature.ItemModel";
	}

	protected virtual string _GetTemplateForLabelAmazonExclusiveItem()
	{
		return "This is an Amazon exclusive item.";
	}

	/// <summary>
	/// Key: "Label.AssetName"
	/// English String: "{assetName} - Roblox"
	/// </summary>
	public virtual string LabelAssetName(string assetName)
	{
		return $"{assetName} - Roblox";
	}

	protected virtual string _GetTemplateForLabelAssetName()
	{
		return "{assetName} - Roblox";
	}

	/// <summary>
	/// Key: "Label.AssetOptionRental"
	/// English String: "{assetOption} Rental"
	/// </summary>
	public virtual string LabelAssetOptionRental(string assetOption)
	{
		return $"{assetOption} Rental";
	}

	protected virtual string _GetTemplateForLabelAssetOptionRental()
	{
		return "{assetOption} Rental";
	}

	protected virtual string _GetTemplateForLabelAudioAssetBlockedCopyright()
	{
		return "This audio asset has been blocked due to copyright violations.\n";
	}

	/// <summary>
	/// Key: "Label.BcRequirementExclusiveItem"
	/// English String: "{bcRequirementName} exclusive item."
	/// </summary>
	public virtual string LabelBcRequirementExclusiveItem(string bcRequirementName)
	{
		return $"{bcRequirementName} exclusive item.";
	}

	protected virtual string _GetTemplateForLabelBcRequirementExclusiveItem()
	{
		return "{bcRequirementName} exclusive item.";
	}

	/// <summary>
	/// Key: "Label.ExpiresRentalTime"
	/// English String: "Expires: {rentalTime}"
	/// </summary>
	public virtual string LabelExpiresRentalTime(string rentalTime)
	{
		return $"Expires: {rentalTime}";
	}

	protected virtual string _GetTemplateForLabelExpiresRentalTime()
	{
		return "Expires: {rentalTime}";
	}

	protected virtual string _GetTemplateForLabelGooglePlayExclusiveItem()
	{
		return "This is a Google Play exclusive item.";
	}

	protected virtual string _GetTemplateForLabelIosDeviceExclusiveItem()
	{
		return "This is an iOS exclusive item.";
	}

	protected virtual string _GetTemplateForLabelItemAvailableInventory()
	{
		return "This item is available in your inventory.";
	}

	protected virtual string _GetTemplateForLabelItemHasBeenModerated()
	{
		return "This item has been moderated.";
	}

	protected virtual string _GetTemplateForLabelItemNoLongerForSale()
	{
		return "This item is no longer for sale.";
	}

	protected virtual string _GetTemplateForLabelItemNotCurrentlyForSale()
	{
		return "This item is not currently for sale.";
	}

	/// <summary>
	/// Key: "Label.LimitedQuantity"
	/// English String: "Limited quantity: {amount}"
	/// </summary>
	public virtual string LabelLimitedQuantity(string amount)
	{
		return $"Limited quantity: {amount}";
	}

	protected virtual string _GetTemplateForLabelLimitedQuantity()
	{
		return "Limited quantity: {amount}";
	}

	public virtual string LabelMetaDescriptionCatalog(string assetName, string assetTypeLabel)
	{
		return $"Customize your avatar with the {assetName} and millions of other items. Mix & match this {assetTypeLabel} with other items to create an avatar that is unique to you!";
	}

	protected virtual string _GetTemplateForLabelMetaDescriptionCatalog()
	{
		return "Customize your avatar with the {assetName} and millions of other items. Mix & match this {assetTypeLabel} with other items to create an avatar that is unique to you!";
	}

	/// <summary>
	/// Key: "Label.MetaDescriptionLibrary"
	/// English String: "Use {assetName} and thousands of other {assetTypeLabel} to build an immersive game or experience. Select from a wide range of models, decals, meshes, plugins, or audio that help bring your imagination into reality."
	/// </summary>
	public virtual string LabelMetaDescriptionLibrary(string assetName, string assetTypeLabel)
	{
		return $"Use {assetName} and thousands of other {assetTypeLabel} to build an immersive game or experience. Select from a wide range of models, decals, meshes, plugins, or audio that help bring your imagination into reality.";
	}

	protected virtual string _GetTemplateForLabelMetaDescriptionLibrary()
	{
		return "Use {assetName} and thousands of other {assetTypeLabel} to build an immersive game or experience. Select from a wide range of models, decals, meshes, plugins, or audio that help bring your imagination into reality.";
	}

	/// <summary>
	/// Key: "Label.MetaDescriptionLibraryV2"
	/// new text with no asset type
	/// English String: "Use {assetName} and thousands of other assets to build an immersive game or experience. Select from a wide range of models, decals, meshes, plugins, or audio that help bring your imagination into reality."
	/// </summary>
	public virtual string LabelMetaDescriptionLibraryV2(string assetName)
	{
		return $"Use {assetName} and thousands of other assets to build an immersive game or experience. Select from a wide range of models, decals, meshes, plugins, or audio that help bring your imagination into reality.";
	}

	protected virtual string _GetTemplateForLabelMetaDescriptionLibraryV2()
	{
		return "Use {assetName} and thousands of other assets to build an immersive game or experience. Select from a wide range of models, decals, meshes, plugins, or audio that help bring your imagination into reality.";
	}

	protected virtual string _GetTemplateForLabelMobileDeviceExclusiveItem()
	{
		return "This is a mobile exclusive item.";
	}

	protected virtual string _GetTemplateForLabelNoDescriptionAvailable()
	{
		return "No description available.";
	}

	protected virtual string _GetTemplateForLabelNoOneCurrentlySelling()
	{
		return "There is no one currently selling this item.";
	}

	protected virtual string _GetTemplateForLabelNoOtherSellers()
	{
		return "No other sellers.";
	}

	protected virtual string _GetTemplateForLabelNotAvailable()
	{
		return "N/A";
	}

	/// <summary>
	/// Key: "Label.PriceChangedFrom"
	/// English String: "Price changed from {robuxAmount}"
	/// </summary>
	public virtual string LabelPriceChangedFrom(string robuxAmount)
	{
		return $"Price changed from {robuxAmount}";
	}

	protected virtual string _GetTemplateForLabelPriceChangedFrom()
	{
		return "Price changed from {robuxAmount}";
	}

	protected virtual string _GetTemplateForLabelPurchasingTemporarilyUnavailable()
	{
		return "Purchasing is temporarily unavailable. Please try again later.";
	}

	protected virtual string _GetTemplateForLabelResellers()
	{
		return "Resellers";
	}

	protected virtual string _GetTemplateForLabelRobloxAsset()
	{
		return "Roblox Asset";
	}

	/// <summary>
	/// Key: "Label.SeeMoreResellers"
	/// English String: "See more {resellers}"
	/// </summary>
	public virtual string LabelSeeMoreResellers(string resellers)
	{
		return $"See more {resellers}";
	}

	protected virtual string _GetTemplateForLabelSeeMoreResellers()
	{
		return "See more {resellers}";
	}

	/// <summary>
	/// Key: "Label.SerialNoOf"
	/// English String: "{serial} of {total}"
	/// </summary>
	public virtual string LabelSerialNoOf(string serial, string total)
	{
		return $"{serial} of {total}";
	}

	protected virtual string _GetTemplateForLabelSerialNoOf()
	{
		return "{serial} of {total}";
	}

	protected virtual string _GetTemplateForLabelTakeOff()
	{
		return "Take Off";
	}

	protected virtual string _GetTemplateForLabelToInstallOpenStudio()
	{
		return "To install, open this page in Roblox Studio.";
	}

	protected virtual string _GetTemplateForLabelWear()
	{
		return "Wear";
	}

	protected virtual string _GetTemplateForLabelXboxOneExclusiveItem()
	{
		return "This is a Xbox One exclusive item.";
	}

	protected virtual string _GetTemplateForLabelYouAreSelling()
	{
		return "You are selling this item.";
	}
}
