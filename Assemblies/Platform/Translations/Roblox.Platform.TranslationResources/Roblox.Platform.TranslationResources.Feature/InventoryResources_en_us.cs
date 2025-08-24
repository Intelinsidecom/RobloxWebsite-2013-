using System;
using System.Collections.Generic;

namespace Roblox.TranslationResources.Feature;

internal class InventoryResources_en_us : TranslationResourcesBase, IInventoryResources, ITranslationResources
{
	private readonly Lazy<IReadOnlyDictionary<string, string>> _AllKeys;

	/// <summary>
	/// Key: "Action.GetMore"
	/// Call to action button for the user to get more items or assets
	/// English String: "Get More"
	/// </summary>
	public virtual string ActionGetMore => "Get More";

	/// <summary>
	/// Key: "Heading.Category"
	/// These categories include different item and asset types such as Accessories, Meshes, Badges, Audio assets, and Pants
	/// English String: "Category"
	/// </summary>
	public virtual string HeadingCategory => "Category";

	/// <summary>
	/// Key: "Heading.Inventory"
	/// This is the button that users will click on the navigation menu to go to the Inventory page, which contains items and assets that the user has to improve their appearance or use to develop games.
	/// English String: "Inventory"
	/// </summary>
	public virtual string HeadingInventory => "Inventory";

	/// <summary>
	/// Key: "Heading.MyInventory"
	/// This is the page title referring to your own inventory. This page contains the user's items and assets.
	/// English String: "My Inventory"
	/// </summary>
	public virtual string HeadingMyInventory => "My Inventory";

	/// <summary>
	/// Key: "Heading.Subcategory"
	/// These subcategories include different sub-types of asset types. The subcategories under Accessories could be Hats, Hair, and Face.
	/// English String: "Subcategory"
	/// </summary>
	public virtual string HeadingSubcategory => "Subcategory";

	/// <summary>
	/// Key: "Label.BodyParts"
	/// English String: "Body Parts"
	/// </summary>
	public virtual string LabelBodyParts => "Body Parts";

	/// <summary>
	/// Key: "Label.Bundles"
	/// English String: "Bundles"
	/// </summary>
	public virtual string LabelBundles => "Bundles";

	/// <summary>
	/// Key: "Label.CreatedByMe"
	/// English String: "Created by Me"
	/// </summary>
	public virtual string LabelCreatedByMe => "Created by Me";

	/// <summary>
	/// Key: "Label.MyGames"
	/// English String: "My Games"
	/// </summary>
	public virtual string LabelMyGames => "My Games";

	/// <summary>
	/// Key: "Label.MyVipServers"
	/// English String: "My VIP Servers"
	/// </summary>
	public virtual string LabelMyVipServers => "My VIP Servers";

	/// <summary>
	/// Key: "Label.Offsale"
	/// An item with this label is no longer on sale and cannot be obtained.
	/// English String: "Offsale"
	/// </summary>
	public virtual string LabelOffsale => "Offsale";

	/// <summary>
	/// Key: "Label.OtherGames"
	/// English String: "Other Games"
	/// </summary>
	public virtual string LabelOtherGames => "Other Games";

	/// <summary>
	/// Key: "Label.OtherVipServers"
	/// English String: "Other VIP Servers"
	/// </summary>
	public virtual string LabelOtherVipServers => "Other VIP Servers";

	/// <summary>
	/// Key: "Label.OwnershipPreposition"
	/// This word is used to show that an item was created "By" someone or some entity.
	/// English String: "By"
	/// </summary>
	public virtual string LabelOwnershipPreposition => "By";

	/// <summary>
	/// Key: "Label.Places"
	/// English String: "Places"
	/// </summary>
	public virtual string LabelPlaces => "Places";

	/// <summary>
	/// Key: "Label.Purchased"
	/// English String: "Purchased"
	/// </summary>
	public virtual string LabelPurchased => "Purchased";

	/// <summary>
	/// Key: "Label.VipServers"
	/// English String: "VIP Servers"
	/// </summary>
	public virtual string LabelVipServers => "VIP Servers";

	/// <summary>
	/// Key: "Message.TryCatalogForItems"
	/// English String: "Try using the catalog to find new items."
	/// </summary>
	public virtual string MessageTryCatalogForItems => "Try using the catalog to find new items.";

	/// <summary>
	/// Key: "Message.TryLibraryForItems"
	/// English String: "Try using the library to find new items."
	/// </summary>
	public virtual string MessageTryLibraryForItems => "Try using the library to find new items.";

	/// <summary>
	/// Key: "Message.UserHasNoFavoritesCategory"
	/// English String: "This user has not favorited items in this category."
	/// </summary>
	public virtual string MessageUserHasNoFavoritesCategory => "This user has not favorited items in this category.";

	/// <summary>
	/// Key: "Message.UserHasNoItemsCategory"
	/// English String: "This user doesn't have items in this category."
	/// </summary>
	public virtual string MessageUserHasNoItemsCategory => "This user doesn't have items in this category.";

	/// <summary>
	/// Key: "Message.UserInventoryHidden"
	/// English String: "You cannot see this player's inventory."
	/// </summary>
	public virtual string MessageUserInventoryHidden => "You cannot see this player's inventory.";

	/// <summary>
	/// Key: "Message.YouHaveNoFavoritesCategory"
	/// English String: "You have not favorited items in this category."
	/// </summary>
	public virtual string MessageYouHaveNoFavoritesCategory => "You have not favorited items in this category.";

	/// <summary>
	/// Key: "Message.YouHaveNoItemsCategory"
	/// English String: "You don't have items in this category."
	/// </summary>
	public virtual string MessageYouHaveNoItemsCategory => "You don't have items in this category.";

	public InventoryResources_en_us(TranslationResourceState state)
		: base(state)
	{
		_AllKeys = new Lazy<IReadOnlyDictionary<string, string>>(() => new Dictionary<string, string>
		{
			{
				"Action.GetMore",
				_GetTemplateForActionGetMore()
			},
			{
				"Heading.Category",
				_GetTemplateForHeadingCategory()
			},
			{
				"Heading.Inventory",
				_GetTemplateForHeadingInventory()
			},
			{
				"Heading.MyInventory",
				_GetTemplateForHeadingMyInventory()
			},
			{
				"Heading.Subcategory",
				_GetTemplateForHeadingSubcategory()
			},
			{
				"Heading.UserInventory",
				_GetTemplateForHeadingUserInventory()
			},
			{
				"Label.BodyParts",
				_GetTemplateForLabelBodyParts()
			},
			{
				"Label.Bundles",
				_GetTemplateForLabelBundles()
			},
			{
				"Label.CreatedByMe",
				_GetTemplateForLabelCreatedByMe()
			},
			{
				"Label.MyGames",
				_GetTemplateForLabelMyGames()
			},
			{
				"Label.MyVipServers",
				_GetTemplateForLabelMyVipServers()
			},
			{
				"Label.Offsale",
				_GetTemplateForLabelOffsale()
			},
			{
				"Label.OtherGames",
				_GetTemplateForLabelOtherGames()
			},
			{
				"Label.OtherVipServers",
				_GetTemplateForLabelOtherVipServers()
			},
			{
				"Label.OwnershipPreposition",
				_GetTemplateForLabelOwnershipPreposition()
			},
			{
				"Label.Places",
				_GetTemplateForLabelPlaces()
			},
			{
				"Label.Purchased",
				_GetTemplateForLabelPurchased()
			},
			{
				"Label.RentalExpireTime",
				_GetTemplateForLabelRentalExpireTime()
			},
			{
				"Label.VipServers",
				_GetTemplateForLabelVipServers()
			},
			{
				"Message.ExploreCatalogForItems",
				_GetTemplateForMessageExploreCatalogForItems()
			},
			{
				"Message.ExploreLibraryForItems",
				_GetTemplateForMessageExploreLibraryForItems()
			},
			{
				"Message.TryCatalogForItems",
				_GetTemplateForMessageTryCatalogForItems()
			},
			{
				"Message.TryCatalogLink",
				_GetTemplateForMessageTryCatalogLink()
			},
			{
				"Message.TryLibraryForItems",
				_GetTemplateForMessageTryLibraryForItems()
			},
			{
				"Message.TryLibraryLink",
				_GetTemplateForMessageTryLibraryLink()
			},
			{
				"Message.UserHasNoFavoritesCategory",
				_GetTemplateForMessageUserHasNoFavoritesCategory()
			},
			{
				"Message.UserHasNoItems",
				_GetTemplateForMessageUserHasNoItems()
			},
			{
				"Message.UserHasNoItemsCategory",
				_GetTemplateForMessageUserHasNoItemsCategory()
			},
			{
				"Message.UserInventoryHidden",
				_GetTemplateForMessageUserInventoryHidden()
			},
			{
				"Message.UserNotFavoritedItems",
				_GetTemplateForMessageUserNotFavoritedItems()
			},
			{
				"Message.YouHaveNoFavoritesCategory",
				_GetTemplateForMessageYouHaveNoFavoritesCategory()
			},
			{
				"Message.YouHaveNoItems",
				_GetTemplateForMessageYouHaveNoItems()
			},
			{
				"Message.YouHaveNoItemsCategory",
				_GetTemplateForMessageYouHaveNoItemsCategory()
			},
			{
				"Message.YouNotFavoritedItems",
				_GetTemplateForMessageYouNotFavoritedItems()
			}
		});
	}

	public IReadOnlyDictionary<string, string> GetAllKeys()
	{
		return _AllKeys.Value;
	}

	public string GetFullContentNamespaceName()
	{
		return "Feature.Inventory";
	}

	protected virtual string _GetTemplateForActionGetMore()
	{
		return "Get More";
	}

	protected virtual string _GetTemplateForHeadingCategory()
	{
		return "Category";
	}

	protected virtual string _GetTemplateForHeadingInventory()
	{
		return "Inventory";
	}

	protected virtual string _GetTemplateForHeadingMyInventory()
	{
		return "My Inventory";
	}

	protected virtual string _GetTemplateForHeadingSubcategory()
	{
		return "Subcategory";
	}

	/// <summary>
	/// Key: "Heading.UserInventory"
	/// This is the page title referring to another user's inventory. This page contains another user's items and assets.
	/// English String: "{username}'s Inventory"
	/// </summary>
	public virtual string HeadingUserInventory(string username)
	{
		return $"{username}'s Inventory";
	}

	protected virtual string _GetTemplateForHeadingUserInventory()
	{
		return "{username}'s Inventory";
	}

	protected virtual string _GetTemplateForLabelBodyParts()
	{
		return "Body Parts";
	}

	protected virtual string _GetTemplateForLabelBundles()
	{
		return "Bundles";
	}

	protected virtual string _GetTemplateForLabelCreatedByMe()
	{
		return "Created by Me";
	}

	protected virtual string _GetTemplateForLabelMyGames()
	{
		return "My Games";
	}

	protected virtual string _GetTemplateForLabelMyVipServers()
	{
		return "My VIP Servers";
	}

	protected virtual string _GetTemplateForLabelOffsale()
	{
		return "Offsale";
	}

	protected virtual string _GetTemplateForLabelOtherGames()
	{
		return "Other Games";
	}

	protected virtual string _GetTemplateForLabelOtherVipServers()
	{
		return "Other VIP Servers";
	}

	protected virtual string _GetTemplateForLabelOwnershipPreposition()
	{
		return "By";
	}

	protected virtual string _GetTemplateForLabelPlaces()
	{
		return "Places";
	}

	protected virtual string _GetTemplateForLabelPurchased()
	{
		return "Purchased";
	}

	/// <summary>
	/// Key: "Label.RentalExpireTime"
	/// An abbreviated label for expiration of an item. Once the expire time is surpassed, the item will no longer be available to the user.
	/// English String: "Exp: {expireTime}"
	/// </summary>
	public virtual string LabelRentalExpireTime(string expireTime)
	{
		return $"Exp: {expireTime}";
	}

	protected virtual string _GetTemplateForLabelRentalExpireTime()
	{
		return "Exp: {expireTime}";
	}

	protected virtual string _GetTemplateForLabelVipServers()
	{
		return "VIP Servers";
	}

	/// <summary>
	/// Key: "Message.ExploreCatalogForItems"
	/// For example, Explore the catalog to find more Animations! The catalog is a page where the user can find many items that can improve the user's appearance.
	/// English String: "Explore the catalog to find more {itemsPlural}!"
	/// </summary>
	public virtual string MessageExploreCatalogForItems(string itemsPlural)
	{
		return $"Explore the catalog to find more {itemsPlural}!";
	}

	protected virtual string _GetTemplateForMessageExploreCatalogForItems()
	{
		return "Explore the catalog to find more {itemsPlural}!";
	}

	/// <summary>
	/// Key: "Message.ExploreLibraryForItems"
	/// For example, Explore the library to find more Animations! The library is a page where the user can find many assets and items that other users have created.
	/// English String: "Explore the library to find more {itemsPlural}!"
	/// </summary>
	public virtual string MessageExploreLibraryForItems(string itemsPlural)
	{
		return $"Explore the library to find more {itemsPlural}!";
	}

	protected virtual string _GetTemplateForMessageExploreLibraryForItems()
	{
		return "Explore the library to find more {itemsPlural}!";
	}

	protected virtual string _GetTemplateForMessageTryCatalogForItems()
	{
		return "Try using the catalog to find new items.";
	}

	/// <summary>
	/// Key: "Message.TryCatalogLink"
	/// The catalog text will link to the Catalog page to find more items.
	/// English String: "Try using the {startLink}catalog{endLink} to find new items."
	/// </summary>
	public virtual string MessageTryCatalogLink(string startLink, string endLink)
	{
		return $"Try using the {startLink}catalog{endLink} to find new items.";
	}

	protected virtual string _GetTemplateForMessageTryCatalogLink()
	{
		return "Try using the {startLink}catalog{endLink} to find new items.";
	}

	protected virtual string _GetTemplateForMessageTryLibraryForItems()
	{
		return "Try using the library to find new items.";
	}

	/// <summary>
	/// Key: "Message.TryLibraryLink"
	/// The library text will link to the Library page to find more items.
	/// English String: "Try using the {startLink}library{endLink} to find new items."
	/// </summary>
	public virtual string MessageTryLibraryLink(string startLink, string endLink)
	{
		return $"Try using the {startLink}library{endLink} to find new items.";
	}

	protected virtual string _GetTemplateForMessageTryLibraryLink()
	{
		return "Try using the {startLink}library{endLink} to find new items.";
	}

	protected virtual string _GetTemplateForMessageUserHasNoFavoritesCategory()
	{
		return "This user has not favorited items in this category.";
	}

	/// <summary>
	/// Key: "Message.UserHasNoItems"
	/// For example, This user has no shoulder accessories.
	/// English String: "This user has no {itemsPlural}."
	/// </summary>
	public virtual string MessageUserHasNoItems(string itemsPlural)
	{
		return $"This user has no {itemsPlural}.";
	}

	protected virtual string _GetTemplateForMessageUserHasNoItems()
	{
		return "This user has no {itemsPlural}.";
	}

	protected virtual string _GetTemplateForMessageUserHasNoItemsCategory()
	{
		return "This user doesn't have items in this category.";
	}

	protected virtual string _GetTemplateForMessageUserInventoryHidden()
	{
		return "You cannot see this player's inventory.";
	}

	/// <summary>
	/// Key: "Message.UserNotFavoritedItems"
	/// For example, This user has not favorited any shoulder accessories. Favoriting is the verb for a user to add an item or asset to their favorites list.
	/// English String: "This user has not favorited any {itemsPlural}."
	/// </summary>
	public virtual string MessageUserNotFavoritedItems(string itemsPlural)
	{
		return $"This user has not favorited any {itemsPlural}.";
	}

	protected virtual string _GetTemplateForMessageUserNotFavoritedItems()
	{
		return "This user has not favorited any {itemsPlural}.";
	}

	protected virtual string _GetTemplateForMessageYouHaveNoFavoritesCategory()
	{
		return "You have not favorited items in this category.";
	}

	/// <summary>
	/// Key: "Message.YouHaveNoItems"
	/// For example, You have no shoulder accessories.
	/// English String: "You have no {itemsPlural}."
	/// </summary>
	public virtual string MessageYouHaveNoItems(string itemsPlural)
	{
		return $"You have no {itemsPlural}.";
	}

	protected virtual string _GetTemplateForMessageYouHaveNoItems()
	{
		return "You have no {itemsPlural}.";
	}

	protected virtual string _GetTemplateForMessageYouHaveNoItemsCategory()
	{
		return "You don't have items in this category.";
	}

	/// <summary>
	/// Key: "Message.YouNotFavoritedItems"
	/// For example, You have not favorited any shoulder accessories. Favoriting is the verb for a user to add an item or asset to their favorites list.
	/// English String: "You have not favorited any {itemsPlural}."
	/// </summary>
	public virtual string MessageYouNotFavoritedItems(string itemsPlural)
	{
		return $"You have not favorited any {itemsPlural}.";
	}

	protected virtual string _GetTemplateForMessageYouNotFavoritedItems()
	{
		return "You have not favorited any {itemsPlural}.";
	}
}
