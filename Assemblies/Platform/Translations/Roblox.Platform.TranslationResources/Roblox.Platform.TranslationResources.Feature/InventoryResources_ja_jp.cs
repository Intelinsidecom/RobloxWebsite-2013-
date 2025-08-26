namespace Roblox.Platform.TranslationResources.Feature {
    /// <summary>

/// This class overrides InventoryResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class InventoryResources_ja_jp : InventoryResources_en_us, IInventoryResources, ITranslationResources
{
	/// <summary>
	/// Key: "Action.GetMore"
	/// Call to action button for the user to get more items or assets
	/// English String: "Get More"
	/// </summary>
	public override string ActionGetMore => "ã•ã‚‰ã«ã‚²ãƒƒãƒˆ";

	/// <summary>
	/// Key: "Heading.Category"
	/// These categories include different item and asset types such as Accessories, Meshes, Badges, Audio assets, and Pants
	/// English String: "Category"
	/// </summary>
	public override string HeadingCategory => "ã‚«ãƒ†ã‚´ãƒª";

	/// <summary>
	/// Key: "Heading.Inventory"
	/// This is the button that users will click on the navigation menu to go to the Inventory page, which contains items and assets that the user has to improve their appearance or use to develop games.
	/// English String: "Inventory"
	/// </summary>
	public override string HeadingInventory => "ã‚¤ãƒ³ãƒ™ãƒ³ãƒˆãƒª";

	/// <summary>
	/// Key: "Heading.MyInventory"
	/// This is the page title referring to your own inventory. This page contains the user's items and assets.
	/// English String: "My Inventory"
	/// </summary>
	public override string HeadingMyInventory => "ãƒžã‚¤ã‚¤ãƒ³ãƒ™ãƒ³ãƒˆãƒª";

	/// <summary>
	/// Key: "Heading.Subcategory"
	/// These subcategories include different sub-types of asset types. The subcategories under Accessories could be Hats, Hair, and Face.
	/// English String: "Subcategory"
	/// </summary>
	public override string HeadingSubcategory => "ã‚µãƒ–ã‚«ãƒ†ã‚´ãƒª";

	/// <summary>
	/// Key: "Label.BodyParts"
	/// English String: "Body Parts"
	/// </summary>
	public override string LabelBodyParts => "ãƒœãƒ‡ã‚£ãƒ‘ãƒ¼ãƒ„";

	/// <summary>
	/// Key: "Label.Bundles"
	/// English String: "Bundles"
	/// </summary>
	public override string LabelBundles => "ãƒãƒ³ãƒ‰ãƒ«";

	/// <summary>
	/// Key: "Label.CreatedByMe"
	/// English String: "Created by Me"
	/// </summary>
	public override string LabelCreatedByMe => "ã‚ãªãŸãŒä½œæˆ";

	/// <summary>
	/// Key: "Label.MyGames"
	/// English String: "My Games"
	/// </summary>
	public override string LabelMyGames => "ãƒžã‚¤ã‚²ãƒ¼ãƒ ";

	/// <summary>
	/// Key: "Label.MyVipServers"
	/// English String: "My VIP Servers"
	/// </summary>
	public override string LabelMyVipServers => "ãƒžã‚¤VIPã‚µãƒ¼ãƒãƒ¼";

	/// <summary>
	/// Key: "Label.Offsale"
	/// An item with this label is no longer on sale and cannot be obtained.
	/// English String: "Offsale"
	/// </summary>
	public override string LabelOffsale => "éžå£²å“";

	/// <summary>
	/// Key: "Label.OtherGames"
	/// English String: "Other Games"
	/// </summary>
	public override string LabelOtherGames => "ãã®ä»–ã®ã‚²ãƒ¼ãƒ ";

	/// <summary>
	/// Key: "Label.OtherVipServers"
	/// English String: "Other VIP Servers"
	/// </summary>
	public override string LabelOtherVipServers => "ãã®ä»–ã®VIPã‚µãƒ¼ãƒãƒ¼";

	/// <summary>
	/// Key: "Label.OwnershipPreposition"
	/// This word is used to show that an item was created "By" someone or some entity.
	/// English String: "By"
	/// </summary>
	public override string LabelOwnershipPreposition => "ä½œï¼š";

	/// <summary>
	/// Key: "Label.Places"
	/// English String: "Places"
	/// </summary>
	public override string LabelPlaces => "ãƒ—ãƒ¬ãƒ¼ã‚¹";

	/// <summary>
	/// Key: "Label.Purchased"
	/// English String: "Purchased"
	/// </summary>
	public override string LabelPurchased => "è³¼å…¥æ¸ˆã¿";

	/// <summary>
	/// Key: "Label.VipServers"
	/// English String: "VIP Servers"
	/// </summary>
	public override string LabelVipServers => "VIPã‚µãƒ¼ãƒãƒ¼";

	/// <summary>
	/// Key: "Message.TryCatalogForItems"
	/// English String: "Try using the catalog to find new items."
	/// </summary>
	public override string MessageTryCatalogForItems => "ã‚«ã‚¿ãƒ­ã‚°ã‚’ä½¿ã£ã¦æ–°ã—ã„ã‚¢ã‚¤ãƒ†ãƒ ã‚’è¦‹ã¤ã‘ã‚ˆã†ï¼";

	/// <summary>
	/// Key: "Message.TryLibraryForItems"
	/// English String: "Try using the library to find new items."
	/// </summary>
	public override string MessageTryLibraryForItems => "ãƒ©ã‚¤ãƒ–ãƒ©ãƒªã‚’ä½¿ã£ã¦æ–°ã—ã„ã‚¢ã‚¤ãƒ†ãƒ ã‚’è¦‹ã¤ã‘ã‚ˆã†ï¼";

	/// <summary>
	/// Key: "Message.UserHasNoFavoritesCategory"
	/// English String: "This user has not favorited items in this category."
	/// </summary>
	public override string MessageUserHasNoFavoritesCategory => "ã“ã®ãƒ¦ãƒ¼ã‚¶ãƒ¼ã¯ã€ã“ã®ã‚«ãƒ†ã‚´ãƒªã®ã‚¢ã‚¤ãƒ†ãƒ ã‚’ãŠæ°—ã«å…¥ã‚Šã«ç™»éŒ²ã—ã¦ã„ã¾ã›ã‚“ã€‚";

	/// <summary>
	/// Key: "Message.UserHasNoItemsCategory"
	/// English String: "This user doesn't have items in this category."
	/// </summary>
	public override string MessageUserHasNoItemsCategory => "ã“ã®ãƒ¦ãƒ¼ã‚¶ãƒ¼ã¯ã€ã“ã®ã‚«ãƒ†ã‚´ãƒªã®ã‚¢ã‚¤ãƒ†ãƒ ã‚’æŒã£ã¦ã„ã¾ã›ã‚“ã€‚";

	/// <summary>
	/// Key: "Message.UserInventoryHidden"
	/// English String: "You cannot see this player's inventory."
	/// </summary>
	public override string MessageUserInventoryHidden => "ã“ã®ãƒ—ãƒ¬ã‚¤ãƒ¤ãƒ¼ã®ã‚¤ãƒ³ãƒ™ãƒ³ãƒˆãƒªã‚’è¦‹ã‚‹ã“ã¨ã¯ã§ãã¾ã›ã‚“ã€‚";

	/// <summary>
	/// Key: "Message.YouHaveNoFavoritesCategory"
	/// English String: "You have not favorited items in this category."
	/// </summary>
	public override string MessageYouHaveNoFavoritesCategory => "ã“ã®ã‚«ãƒ†ã‚´ãƒªã®ã‚¢ã‚¤ãƒ†ãƒ ã‚’ãŠæ°—ã«å…¥ã‚Šã«ç™»éŒ²ã—ã¦ã„ã¾ã›ã‚“ã€‚";

	/// <summary>
	/// Key: "Message.YouHaveNoItemsCategory"
	/// English String: "You don't have items in this category."
	/// </summary>
	public override string MessageYouHaveNoItemsCategory => "ã“ã®ã‚«ãƒ†ã‚´ãƒªã®ã‚¢ã‚¤ãƒ†ãƒ ã‚’æŒã£ã¦ã„ã¾ã›ã‚“ã€‚";

	public InventoryResources_ja_jp(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionGetMore()
	{
		return "ã•ã‚‰ã«ã‚²ãƒƒãƒˆ";
	}

	protected override string _GetTemplateForHeadingCategory()
	{
		return "ã‚«ãƒ†ã‚´ãƒª";
	}

	protected override string _GetTemplateForHeadingInventory()
	{
		return "ã‚¤ãƒ³ãƒ™ãƒ³ãƒˆãƒª";
	}

	protected override string _GetTemplateForHeadingMyInventory()
	{
		return "ãƒžã‚¤ã‚¤ãƒ³ãƒ™ãƒ³ãƒˆãƒª";
	}

	protected override string _GetTemplateForHeadingSubcategory()
	{
		return "ã‚µãƒ–ã‚«ãƒ†ã‚´ãƒª";
	}

	/// <summary>
	/// Key: "Heading.UserInventory"
	/// This is the page title referring to another user's inventory. This page contains another user's items and assets.
	/// English String: "{username}'s Inventory"
	/// </summary>
	public override string HeadingUserInventory(string username)
	{
		return $"{username}ã•ã‚“ã®ã‚¤ãƒ³ãƒ™ãƒ³ãƒˆãƒª";
	}

	protected override string _GetTemplateForHeadingUserInventory()
	{
		return "{username}ã•ã‚“ã®ã‚¤ãƒ³ãƒ™ãƒ³ãƒˆãƒª";
	}

	protected override string _GetTemplateForLabelBodyParts()
	{
		return "ãƒœãƒ‡ã‚£ãƒ‘ãƒ¼ãƒ„";
	}

	protected override string _GetTemplateForLabelBundles()
	{
		return "ãƒãƒ³ãƒ‰ãƒ«";
	}

	protected override string _GetTemplateForLabelCreatedByMe()
	{
		return "ã‚ãªãŸãŒä½œæˆ";
	}

	protected override string _GetTemplateForLabelMyGames()
	{
		return "ãƒžã‚¤ã‚²ãƒ¼ãƒ ";
	}

	protected override string _GetTemplateForLabelMyVipServers()
	{
		return "ãƒžã‚¤VIPã‚µãƒ¼ãƒãƒ¼";
	}

	protected override string _GetTemplateForLabelOffsale()
	{
		return "éžå£²å“";
	}

	protected override string _GetTemplateForLabelOtherGames()
	{
		return "ãã®ä»–ã®ã‚²ãƒ¼ãƒ ";
	}

	protected override string _GetTemplateForLabelOtherVipServers()
	{
		return "ãã®ä»–ã®VIPã‚µãƒ¼ãƒãƒ¼";
	}

	protected override string _GetTemplateForLabelOwnershipPreposition()
	{
		return "ä½œï¼š";
	}

	protected override string _GetTemplateForLabelPlaces()
	{
		return "ãƒ—ãƒ¬ãƒ¼ã‚¹";
	}

	protected override string _GetTemplateForLabelPurchased()
	{
		return "è³¼å…¥æ¸ˆã¿";
	}

	/// <summary>
	/// Key: "Label.RentalExpireTime"
	/// An abbreviated label for expiration of an item. Once the expire time is surpassed, the item will no longer be available to the user.
	/// English String: "Exp: {expireTime}"
	/// </summary>
	public override string LabelRentalExpireTime(string expireTime)
	{
		return $"æœŸé™: {expireTime}";
	}

	protected override string _GetTemplateForLabelRentalExpireTime()
	{
		return "æœŸé™: {expireTime}";
	}

	protected override string _GetTemplateForLabelVipServers()
	{
		return "VIPã‚µãƒ¼ãƒãƒ¼";
	}

	/// <summary>
	/// Key: "Message.ExploreCatalogForItems"
	/// For example, Explore the catalog to find more Animations! The catalog is a page where the user can find many items that can improve the user's appearance.
	/// English String: "Explore the catalog to find more {itemsPlural}!"
	/// </summary>
	public override string MessageExploreCatalogForItems(string itemsPlural)
	{
		return $"ã‚«ã‚¿ãƒ­ã‚°ã‚’ãƒã‚§ãƒƒã‚¯ã—ã¦ã€{itemsPlural} ã‚’è¦‹ã¤ã‘ã‚ˆã†ï¼";
	}

	protected override string _GetTemplateForMessageExploreCatalogForItems()
	{
		return "ã‚«ã‚¿ãƒ­ã‚°ã‚’ãƒã‚§ãƒƒã‚¯ã—ã¦ã€{itemsPlural} ã‚’è¦‹ã¤ã‘ã‚ˆã†ï¼";
	}

	/// <summary>
	/// Key: "Message.ExploreLibraryForItems"
	/// For example, Explore the library to find more Animations! The library is a page where the user can find many assets and items that other users have created.
	/// English String: "Explore the library to find more {itemsPlural}!"
	/// </summary>
	public override string MessageExploreLibraryForItems(string itemsPlural)
	{
		return $"ãƒ©ã‚¤ãƒ–ãƒ©ãƒªã‚’ãƒã‚§ãƒƒã‚¯ã—ã¦ã€{itemsPlural} ã‚’è¦‹ã¤ã‘ã‚ˆã†ï¼";
	}

	protected override string _GetTemplateForMessageExploreLibraryForItems()
	{
		return "ãƒ©ã‚¤ãƒ–ãƒ©ãƒªã‚’ãƒã‚§ãƒƒã‚¯ã—ã¦ã€{itemsPlural} ã‚’è¦‹ã¤ã‘ã‚ˆã†ï¼";
	}

	protected override string _GetTemplateForMessageTryCatalogForItems()
	{
		return "ã‚«ã‚¿ãƒ­ã‚°ã‚’ä½¿ã£ã¦æ–°ã—ã„ã‚¢ã‚¤ãƒ†ãƒ ã‚’è¦‹ã¤ã‘ã‚ˆã†ï¼";
	}

	/// <summary>
	/// Key: "Message.TryCatalogLink"
	/// The catalog text will link to the Catalog page to find more items.
	/// English String: "Try using the {startLink}catalog{endLink} to find new items."
	/// </summary>
	public override string MessageTryCatalogLink(string startLink, string endLink)
	{
		return $"{startLink}ã‚«ã‚¿ãƒ­ã‚°{endLink}ã‚’ä½¿ã£ã¦æ–°ã—ã„ã‚¢ã‚¤ãƒ†ãƒ ã‚’è¦‹ã¤ã‘ã‚ˆã†ï¼";
	}

	protected override string _GetTemplateForMessageTryCatalogLink()
	{
		return "{startLink}ã‚«ã‚¿ãƒ­ã‚°{endLink}ã‚’ä½¿ã£ã¦æ–°ã—ã„ã‚¢ã‚¤ãƒ†ãƒ ã‚’è¦‹ã¤ã‘ã‚ˆã†ï¼";
	}

	protected override string _GetTemplateForMessageTryLibraryForItems()
	{
		return "ãƒ©ã‚¤ãƒ–ãƒ©ãƒªã‚’ä½¿ã£ã¦æ–°ã—ã„ã‚¢ã‚¤ãƒ†ãƒ ã‚’è¦‹ã¤ã‘ã‚ˆã†ï¼";
	}

	/// <summary>
	/// Key: "Message.TryLibraryLink"
	/// The library text will link to the Library page to find more items.
	/// English String: "Try using the {startLink}library{endLink} to find new items."
	/// </summary>
	public override string MessageTryLibraryLink(string startLink, string endLink)
	{
		return $"{startLink}ãƒ©ã‚¤ãƒ–ãƒ©ãƒª{endLink}ã‚’ä½¿ã£ã¦æ–°ã—ã„ã‚¢ã‚¤ãƒ†ãƒ ã‚’è¦‹ã¤ã‘ã‚ˆã†ï¼";
	}

	protected override string _GetTemplateForMessageTryLibraryLink()
	{
		return "{startLink}ãƒ©ã‚¤ãƒ–ãƒ©ãƒª{endLink}ã‚’ä½¿ã£ã¦æ–°ã—ã„ã‚¢ã‚¤ãƒ†ãƒ ã‚’è¦‹ã¤ã‘ã‚ˆã†ï¼";
	}

	protected override string _GetTemplateForMessageUserHasNoFavoritesCategory()
	{
		return "ã“ã®ãƒ¦ãƒ¼ã‚¶ãƒ¼ã¯ã€ã“ã®ã‚«ãƒ†ã‚´ãƒªã®ã‚¢ã‚¤ãƒ†ãƒ ã‚’ãŠæ°—ã«å…¥ã‚Šã«ç™»éŒ²ã—ã¦ã„ã¾ã›ã‚“ã€‚";
	}

	/// <summary>
	/// Key: "Message.UserHasNoItems"
	/// For example, This user has no shoulder accessories.
	/// English String: "This user has no {itemsPlural}."
	/// </summary>
	public override string MessageUserHasNoItems(string itemsPlural)
	{
		return $"ã“ã®ãƒ¦ãƒ¼ã‚¶ãƒ¼ã¯ã€{itemsPlural}ã‚’æŒã£ã¦ã„ã¾ã›ã‚“ã€‚";
	}

	protected override string _GetTemplateForMessageUserHasNoItems()
	{
		return "ã“ã®ãƒ¦ãƒ¼ã‚¶ãƒ¼ã¯ã€{itemsPlural}ã‚’æŒã£ã¦ã„ã¾ã›ã‚“ã€‚";
	}

	protected override string _GetTemplateForMessageUserHasNoItemsCategory()
	{
		return "ã“ã®ãƒ¦ãƒ¼ã‚¶ãƒ¼ã¯ã€ã“ã®ã‚«ãƒ†ã‚´ãƒªã®ã‚¢ã‚¤ãƒ†ãƒ ã‚’æŒã£ã¦ã„ã¾ã›ã‚“ã€‚";
	}

	protected override string _GetTemplateForMessageUserInventoryHidden()
	{
		return "ã“ã®ãƒ—ãƒ¬ã‚¤ãƒ¤ãƒ¼ã®ã‚¤ãƒ³ãƒ™ãƒ³ãƒˆãƒªã‚’è¦‹ã‚‹ã“ã¨ã¯ã§ãã¾ã›ã‚“ã€‚";
	}

	/// <summary>
	/// Key: "Message.UserNotFavoritedItems"
	/// For example, This user has not favorited any shoulder accessories. Favoriting is the verb for a user to add an item or asset to their favorites list.
	/// English String: "This user has not favorited any {itemsPlural}."
	/// </summary>
	public override string MessageUserNotFavoritedItems(string itemsPlural)
	{
		return $"ã“ã®ãƒ¦ãƒ¼ã‚¶ãƒ¼ã¯ã€{itemsPlural}ã‚’ãŠæ°—ã«å…¥ã‚Šã«ç™»éŒ²ã—ã¦ã„ã¾ã›ã‚“ã€‚";
	}

	protected override string _GetTemplateForMessageUserNotFavoritedItems()
	{
		return "ã“ã®ãƒ¦ãƒ¼ã‚¶ãƒ¼ã¯ã€{itemsPlural}ã‚’ãŠæ°—ã«å…¥ã‚Šã«ç™»éŒ²ã—ã¦ã„ã¾ã›ã‚“ã€‚";
	}

	protected override string _GetTemplateForMessageYouHaveNoFavoritesCategory()
	{
		return "ã“ã®ã‚«ãƒ†ã‚´ãƒªã®ã‚¢ã‚¤ãƒ†ãƒ ã‚’ãŠæ°—ã«å…¥ã‚Šã«ç™»éŒ²ã—ã¦ã„ã¾ã›ã‚“ã€‚";
	}

	/// <summary>
	/// Key: "Message.YouHaveNoItems"
	/// For example, You have no shoulder accessories.
	/// English String: "You have no {itemsPlural}."
	/// </summary>
	public override string MessageYouHaveNoItems(string itemsPlural)
	{
		return $"ã‚ãªãŸã¯{itemsPlural}ã‚’æŒã£ã¦ã„ã¾ã›ã‚“ã€‚";
	}

	protected override string _GetTemplateForMessageYouHaveNoItems()
	{
		return "ã‚ãªãŸã¯{itemsPlural}ã‚’æŒã£ã¦ã„ã¾ã›ã‚“ã€‚";
	}

	protected override string _GetTemplateForMessageYouHaveNoItemsCategory()
	{
		return "ã“ã®ã‚«ãƒ†ã‚´ãƒªã®ã‚¢ã‚¤ãƒ†ãƒ ã‚’æŒã£ã¦ã„ã¾ã›ã‚“ã€‚";
	}

	/// <summary>
	/// Key: "Message.YouNotFavoritedItems"
	/// For example, You have not favorited any shoulder accessories. Favoriting is the verb for a user to add an item or asset to their favorites list.
	/// English String: "You have not favorited any {itemsPlural}."
	/// </summary>
	public override string MessageYouNotFavoritedItems(string itemsPlural)
	{
		return $"{itemsPlural}ã¯ãŠæ°—ã«å…¥ã‚Šã«ç™»éŒ²ã•ã‚Œã¦ã„ã¾ã›ã‚“ã€‚";
	}

	protected override string _GetTemplateForMessageYouNotFavoritedItems()
	{
		return "{itemsPlural}ã¯ãŠæ°—ã«å…¥ã‚Šã«ç™»éŒ²ã•ã‚Œã¦ã„ã¾ã›ã‚“ã€‚";
	}
}


}
