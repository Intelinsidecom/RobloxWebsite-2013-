namespace Roblox.Platform.TranslationResources.Feature {
    /// <summary>

/// This class overrides InventoryResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class InventoryResources_zh_cjv : InventoryResources_en_us, IInventoryResources, ITranslationResources
{
	/// <summary>
	/// Key: "Action.GetMore"
	/// Call to action button for the user to get more items or assets
	/// English String: "Get More"
	/// </summary>
	public override string ActionGetMore => "èŽ·å–æ›´å¤š";

	/// <summary>
	/// Key: "Heading.Category"
	/// These categories include different item and asset types such as Accessories, Meshes, Badges, Audio assets, and Pants
	/// English String: "Category"
	/// </summary>
	public override string HeadingCategory => "ç±»åˆ«";

	/// <summary>
	/// Key: "Heading.Inventory"
	/// This is the button that users will click on the navigation menu to go to the Inventory page, which contains items and assets that the user has to improve their appearance or use to develop games.
	/// English String: "Inventory"
	/// </summary>
	public override string HeadingInventory => "é“å…·";

	/// <summary>
	/// Key: "Heading.MyInventory"
	/// This is the page title referring to your own inventory. This page contains the user's items and assets.
	/// English String: "My Inventory"
	/// </summary>
	public override string HeadingMyInventory => "æˆ‘çš„é“å…·";

	/// <summary>
	/// Key: "Heading.Subcategory"
	/// These subcategories include different sub-types of asset types. The subcategories under Accessories could be Hats, Hair, and Face.
	/// English String: "Subcategory"
	/// </summary>
	public override string HeadingSubcategory => "å­ç±»åˆ«";

	/// <summary>
	/// Key: "Label.BodyParts"
	/// English String: "Body Parts"
	/// </summary>
	public override string LabelBodyParts => "èº«ä½“éƒ¨ä»¶";

	/// <summary>
	/// Key: "Label.Bundles"
	/// English String: "Bundles"
	/// </summary>
	public override string LabelBundles => "å¥—è£…";

	/// <summary>
	/// Key: "Label.CreatedByMe"
	/// English String: "Created by Me"
	/// </summary>
	public override string LabelCreatedByMe => "æˆ‘çš„åˆ›ä½œ";

	/// <summary>
	/// Key: "Label.MyGames"
	/// English String: "My Games"
	/// </summary>
	public override string LabelMyGames => "æˆ‘çš„æ¸¸æˆ";

	/// <summary>
	/// Key: "Label.MyVipServers"
	/// English String: "My VIP Servers"
	/// </summary>
	public override string LabelMyVipServers => "æˆ‘çš„ VIP æœåŠ¡å™¨";

	/// <summary>
	/// Key: "Label.Offsale"
	/// An item with this label is no longer on sale and cannot be obtained.
	/// English String: "Offsale"
	/// </summary>
	public override string LabelOffsale => "ä¸‹æž¶";

	/// <summary>
	/// Key: "Label.OtherGames"
	/// English String: "Other Games"
	/// </summary>
	public override string LabelOtherGames => "å…¶ä»–æ¸¸æˆ";

	/// <summary>
	/// Key: "Label.OtherVipServers"
	/// English String: "Other VIP Servers"
	/// </summary>
	public override string LabelOtherVipServers => "å…¶ä»– VIP æœåŠ¡å™¨";

	/// <summary>
	/// Key: "Label.OwnershipPreposition"
	/// This word is used to show that an item was created "By" someone or some entity.
	/// English String: "By"
	/// </summary>
	public override string LabelOwnershipPreposition => "ä½œè€…";

	/// <summary>
	/// Key: "Label.Places"
	/// English String: "Places"
	/// </summary>
	public override string LabelPlaces => "æ¸¸æˆåœºæ™¯";

	/// <summary>
	/// Key: "Label.Purchased"
	/// English String: "Purchased"
	/// </summary>
	public override string LabelPurchased => "å·²è´­ä¹°";

	/// <summary>
	/// Key: "Label.VipServers"
	/// English String: "VIP Servers"
	/// </summary>
	public override string LabelVipServers => "VIP æœåŠ¡å™¨";

	/// <summary>
	/// Key: "Message.TryCatalogForItems"
	/// English String: "Try using the catalog to find new items."
	/// </summary>
	public override string MessageTryCatalogForItems => "å°è¯•åœ¨å•†åº—ä¸­å¯»æ‰¾æ–°ç‰©å“ã€‚";

	/// <summary>
	/// Key: "Message.TryLibraryForItems"
	/// English String: "Try using the library to find new items."
	/// </summary>
	public override string MessageTryLibraryForItems => "è¯·è¯•è¯•åœ¨èµ„æ–™åº“ä¸­å‘çŽ°æ–°ç‰©å“ã€‚";

	/// <summary>
	/// Key: "Message.UserHasNoFavoritesCategory"
	/// English String: "This user has not favorited items in this category."
	/// </summary>
	public override string MessageUserHasNoFavoritesCategory => "æ­¤ç”¨æˆ·åœ¨æ­¤ç±»åˆ«æ²¡æœ‰è®¾ä¸ºæœ€çˆ±çš„é¡¹ç›®ã€‚";

	/// <summary>
	/// Key: "Message.UserHasNoItemsCategory"
	/// English String: "This user doesn't have items in this category."
	/// </summary>
	public override string MessageUserHasNoItemsCategory => "æ­¤ç”¨æˆ·æ²¡æœ‰æ­¤ç±»åˆ«çš„ç‰©å“ã€‚";

	/// <summary>
	/// Key: "Message.UserInventoryHidden"
	/// English String: "You cannot see this player's inventory."
	/// </summary>
	public override string MessageUserInventoryHidden => "ä½ æ— æ³•æŸ¥çœ‹æ­¤çŽ©å®¶çš„é“å…·ã€‚";

	/// <summary>
	/// Key: "Message.YouHaveNoFavoritesCategory"
	/// English String: "You have not favorited items in this category."
	/// </summary>
	public override string MessageYouHaveNoFavoritesCategory => "ä½ åœ¨æ­¤ç±»åˆ«ä¸­æ²¡æœ‰ä»»ä½•æœ€çˆ±çš„ç‰©å“ã€‚";

	/// <summary>
	/// Key: "Message.YouHaveNoItemsCategory"
	/// English String: "You don't have items in this category."
	/// </summary>
	public override string MessageYouHaveNoItemsCategory => "ä½ æ²¡æœ‰æ­¤ç±»åˆ«çš„é¡¹ç›®ã€‚";

	public InventoryResources_zh_cjv(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionGetMore()
	{
		return "èŽ·å–æ›´å¤š";
	}

	protected override string _GetTemplateForHeadingCategory()
	{
		return "ç±»åˆ«";
	}

	protected override string _GetTemplateForHeadingInventory()
	{
		return "é“å…·";
	}

	protected override string _GetTemplateForHeadingMyInventory()
	{
		return "æˆ‘çš„é“å…·";
	}

	protected override string _GetTemplateForHeadingSubcategory()
	{
		return "å­ç±»åˆ«";
	}

	/// <summary>
	/// Key: "Heading.UserInventory"
	/// This is the page title referring to another user's inventory. This page contains another user's items and assets.
	/// English String: "{username}'s Inventory"
	/// </summary>
	public override string HeadingUserInventory(string username)
	{
		return $"â€œ{username}â€çš„é“å…·";
	}

	protected override string _GetTemplateForHeadingUserInventory()
	{
		return "â€œ{username}â€çš„é“å…·";
	}

	protected override string _GetTemplateForLabelBodyParts()
	{
		return "èº«ä½“éƒ¨ä»¶";
	}

	protected override string _GetTemplateForLabelBundles()
	{
		return "å¥—è£…";
	}

	protected override string _GetTemplateForLabelCreatedByMe()
	{
		return "æˆ‘çš„åˆ›ä½œ";
	}

	protected override string _GetTemplateForLabelMyGames()
	{
		return "æˆ‘çš„æ¸¸æˆ";
	}

	protected override string _GetTemplateForLabelMyVipServers()
	{
		return "æˆ‘çš„ VIP æœåŠ¡å™¨";
	}

	protected override string _GetTemplateForLabelOffsale()
	{
		return "ä¸‹æž¶";
	}

	protected override string _GetTemplateForLabelOtherGames()
	{
		return "å…¶ä»–æ¸¸æˆ";
	}

	protected override string _GetTemplateForLabelOtherVipServers()
	{
		return "å…¶ä»– VIP æœåŠ¡å™¨";
	}

	protected override string _GetTemplateForLabelOwnershipPreposition()
	{
		return "ä½œè€…";
	}

	protected override string _GetTemplateForLabelPlaces()
	{
		return "æ¸¸æˆåœºæ™¯";
	}

	protected override string _GetTemplateForLabelPurchased()
	{
		return "å·²è´­ä¹°";
	}

	/// <summary>
	/// Key: "Label.RentalExpireTime"
	/// An abbreviated label for expiration of an item. Once the expire time is surpassed, the item will no longer be available to the user.
	/// English String: "Exp: {expireTime}"
	/// </summary>
	public override string LabelRentalExpireTime(string expireTime)
	{
		return $"å¤±æ•ˆæ—¶é—´ï¼š{expireTime}";
	}

	protected override string _GetTemplateForLabelRentalExpireTime()
	{
		return "å¤±æ•ˆæ—¶é—´ï¼š{expireTime}";
	}

	protected override string _GetTemplateForLabelVipServers()
	{
		return "VIP æœåŠ¡å™¨";
	}

	/// <summary>
	/// Key: "Message.ExploreCatalogForItems"
	/// For example, Explore the catalog to find more Animations! The catalog is a page where the user can find many items that can improve the user's appearance.
	/// English String: "Explore the catalog to find more {itemsPlural}!"
	/// </summary>
	public override string MessageExploreCatalogForItems(string itemsPlural)
	{
		return $"æŽ¢ç´¢å•†åº—ï¼Œå‘çŽ°æ›´å¤š{itemsPlural}ï¼";
	}

	protected override string _GetTemplateForMessageExploreCatalogForItems()
	{
		return "æŽ¢ç´¢å•†åº—ï¼Œå‘çŽ°æ›´å¤š{itemsPlural}ï¼";
	}

	/// <summary>
	/// Key: "Message.ExploreLibraryForItems"
	/// For example, Explore the library to find more Animations! The library is a page where the user can find many assets and items that other users have created.
	/// English String: "Explore the library to find more {itemsPlural}!"
	/// </summary>
	public override string MessageExploreLibraryForItems(string itemsPlural)
	{
		return $"æŽ¢ç´¢èµ„æ–™åº“ï¼Œå‘çŽ°æ›´å¤š{itemsPlural}ï¼";
	}

	protected override string _GetTemplateForMessageExploreLibraryForItems()
	{
		return "æŽ¢ç´¢èµ„æ–™åº“ï¼Œå‘çŽ°æ›´å¤š{itemsPlural}ï¼";
	}

	protected override string _GetTemplateForMessageTryCatalogForItems()
	{
		return "å°è¯•åœ¨å•†åº—ä¸­å¯»æ‰¾æ–°ç‰©å“ã€‚";
	}

	/// <summary>
	/// Key: "Message.TryCatalogLink"
	/// The catalog text will link to the Catalog page to find more items.
	/// English String: "Try using the {startLink}catalog{endLink} to find new items."
	/// </summary>
	public override string MessageTryCatalogLink(string startLink, string endLink)
	{
		return $"è¯·è¯•è¯•åœ¨{startLink}å•†åº—{endLink}ä¸­å‘çŽ°æ–°ç‰©å“ã€‚";
	}

	protected override string _GetTemplateForMessageTryCatalogLink()
	{
		return "è¯·è¯•è¯•åœ¨{startLink}å•†åº—{endLink}ä¸­å‘çŽ°æ–°ç‰©å“ã€‚";
	}

	protected override string _GetTemplateForMessageTryLibraryForItems()
	{
		return "è¯·è¯•è¯•åœ¨èµ„æ–™åº“ä¸­å‘çŽ°æ–°ç‰©å“ã€‚";
	}

	/// <summary>
	/// Key: "Message.TryLibraryLink"
	/// The library text will link to the Library page to find more items.
	/// English String: "Try using the {startLink}library{endLink} to find new items."
	/// </summary>
	public override string MessageTryLibraryLink(string startLink, string endLink)
	{
		return $"è¯·è¯•è¯•ä½¿ç”¨{startLink}èµ„æ–™åº“{endLink}æ¥å‘çŽ°æ–°ç‰©å“ã€‚";
	}

	protected override string _GetTemplateForMessageTryLibraryLink()
	{
		return "è¯·è¯•è¯•ä½¿ç”¨{startLink}èµ„æ–™åº“{endLink}æ¥å‘çŽ°æ–°ç‰©å“ã€‚";
	}

	protected override string _GetTemplateForMessageUserHasNoFavoritesCategory()
	{
		return "æ­¤ç”¨æˆ·åœ¨æ­¤ç±»åˆ«æ²¡æœ‰è®¾ä¸ºæœ€çˆ±çš„é¡¹ç›®ã€‚";
	}

	/// <summary>
	/// Key: "Message.UserHasNoItems"
	/// For example, This user has no shoulder accessories.
	/// English String: "This user has no {itemsPlural}."
	/// </summary>
	public override string MessageUserHasNoItems(string itemsPlural)
	{
		return $"æ­¤ç”¨æˆ·æ²¡æœ‰ä»»ä½•â€œ{itemsPlural}â€ã€‚";
	}

	protected override string _GetTemplateForMessageUserHasNoItems()
	{
		return "æ­¤ç”¨æˆ·æ²¡æœ‰ä»»ä½•â€œ{itemsPlural}â€ã€‚";
	}

	protected override string _GetTemplateForMessageUserHasNoItemsCategory()
	{
		return "æ­¤ç”¨æˆ·æ²¡æœ‰æ­¤ç±»åˆ«çš„ç‰©å“ã€‚";
	}

	protected override string _GetTemplateForMessageUserInventoryHidden()
	{
		return "ä½ æ— æ³•æŸ¥çœ‹æ­¤çŽ©å®¶çš„é“å…·ã€‚";
	}

	/// <summary>
	/// Key: "Message.UserNotFavoritedItems"
	/// For example, This user has not favorited any shoulder accessories. Favoriting is the verb for a user to add an item or asset to their favorites list.
	/// English String: "This user has not favorited any {itemsPlural}."
	/// </summary>
	public override string MessageUserNotFavoritedItems(string itemsPlural)
	{
		return $"æ­¤ç”¨æˆ·æ²¡æœ‰æœ€çˆ±çš„â€œ{itemsPlural}â€ã€‚";
	}

	protected override string _GetTemplateForMessageUserNotFavoritedItems()
	{
		return "æ­¤ç”¨æˆ·æ²¡æœ‰æœ€çˆ±çš„â€œ{itemsPlural}â€ã€‚";
	}

	protected override string _GetTemplateForMessageYouHaveNoFavoritesCategory()
	{
		return "ä½ åœ¨æ­¤ç±»åˆ«ä¸­æ²¡æœ‰ä»»ä½•æœ€çˆ±çš„ç‰©å“ã€‚";
	}

	/// <summary>
	/// Key: "Message.YouHaveNoItems"
	/// For example, You have no shoulder accessories.
	/// English String: "You have no {itemsPlural}."
	/// </summary>
	public override string MessageYouHaveNoItems(string itemsPlural)
	{
		return $"ä½ æ²¡æœ‰ä»»ä½•â€œ{itemsPlural}â€ã€‚";
	}

	protected override string _GetTemplateForMessageYouHaveNoItems()
	{
		return "ä½ æ²¡æœ‰ä»»ä½•â€œ{itemsPlural}â€ã€‚";
	}

	protected override string _GetTemplateForMessageYouHaveNoItemsCategory()
	{
		return "ä½ æ²¡æœ‰æ­¤ç±»åˆ«çš„é¡¹ç›®ã€‚";
	}

	/// <summary>
	/// Key: "Message.YouNotFavoritedItems"
	/// For example, You have not favorited any shoulder accessories. Favoriting is the verb for a user to add an item or asset to their favorites list.
	/// English String: "You have not favorited any {itemsPlural}."
	/// </summary>
	public override string MessageYouNotFavoritedItems(string itemsPlural)
	{
		return $"ä½ æ²¡æœ‰ä»»ä½•æœ€çˆ±çš„â€œ{itemsPlural}â€ã€‚";
	}

	protected override string _GetTemplateForMessageYouNotFavoritedItems()
	{
		return "ä½ æ²¡æœ‰ä»»ä½•æœ€çˆ±çš„â€œ{itemsPlural}â€ã€‚";
	}
}


}
