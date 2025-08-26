namespace Roblox.Platform.TranslationResources.Feature {
    /// <summary>

/// This class overrides InventoryResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class InventoryResources_ko_kr : InventoryResources_en_us, IInventoryResources, ITranslationResources
{
	/// <summary>
	/// Key: "Action.GetMore"
	/// Call to action button for the user to get more items or assets
	/// English String: "Get More"
	/// </summary>
	public override string ActionGetMore => "ë” ë³´ê¸°";

	/// <summary>
	/// Key: "Heading.Category"
	/// These categories include different item and asset types such as Accessories, Meshes, Badges, Audio assets, and Pants
	/// English String: "Category"
	/// </summary>
	public override string HeadingCategory => "ì¹´í…Œê³ ë¦¬";

	/// <summary>
	/// Key: "Heading.Inventory"
	/// This is the button that users will click on the navigation menu to go to the Inventory page, which contains items and assets that the user has to improve their appearance or use to develop games.
	/// English String: "Inventory"
	/// </summary>
	public override string HeadingInventory => "ì¸ë²¤í† ë¦¬";

	/// <summary>
	/// Key: "Heading.MyInventory"
	/// This is the page title referring to your own inventory. This page contains the user's items and assets.
	/// English String: "My Inventory"
	/// </summary>
	public override string HeadingMyInventory => "ë‚´ ì¸ë²¤í† ë¦¬";

	/// <summary>
	/// Key: "Heading.Subcategory"
	/// These subcategories include different sub-types of asset types. The subcategories under Accessories could be Hats, Hair, and Face.
	/// English String: "Subcategory"
	/// </summary>
	public override string HeadingSubcategory => "í•˜ìœ„ ì¹´í…Œê³ ë¦¬";

	/// <summary>
	/// Key: "Label.BodyParts"
	/// English String: "Body Parts"
	/// </summary>
	public override string LabelBodyParts => "ì‹ ì²´ ë¶€ìœ„";

	/// <summary>
	/// Key: "Label.Bundles"
	/// English String: "Bundles"
	/// </summary>
	public override string LabelBundles => "ë²ˆë“¤";

	/// <summary>
	/// Key: "Label.CreatedByMe"
	/// English String: "Created by Me"
	/// </summary>
	public override string LabelCreatedByMe => "ë‚´ê°€ ë§Œë“  ìž¥ì†Œ";

	/// <summary>
	/// Key: "Label.MyGames"
	/// English String: "My Games"
	/// </summary>
	public override string LabelMyGames => "ë‚´ ê²Œìž„";

	/// <summary>
	/// Key: "Label.MyVipServers"
	/// English String: "My VIP Servers"
	/// </summary>
	public override string LabelMyVipServers => "ë‚´ VIP ì„œë²„";

	/// <summary>
	/// Key: "Label.Offsale"
	/// An item with this label is no longer on sale and cannot be obtained.
	/// English String: "Offsale"
	/// </summary>
	public override string LabelOffsale => "íŒë§¤ ì¤‘ë‹¨";

	/// <summary>
	/// Key: "Label.OtherGames"
	/// English String: "Other Games"
	/// </summary>
	public override string LabelOtherGames => "ê¸°íƒ€ ê²Œìž„";

	/// <summary>
	/// Key: "Label.OtherVipServers"
	/// English String: "Other VIP Servers"
	/// </summary>
	public override string LabelOtherVipServers => "ê¸°íƒ€ VIP ì„œë²„";

	/// <summary>
	/// Key: "Label.OwnershipPreposition"
	/// This word is used to show that an item was created "By" someone or some entity.
	/// English String: "By"
	/// </summary>
	public override string LabelOwnershipPreposition => "ê°œë°œ:";

	/// <summary>
	/// Key: "Label.Places"
	/// English String: "Places"
	/// </summary>
	public override string LabelPlaces => "ìž¥ì†Œ";

	/// <summary>
	/// Key: "Label.Purchased"
	/// English String: "Purchased"
	/// </summary>
	public override string LabelPurchased => "êµ¬ìž…í•œ ìž¥ì†Œ";

	/// <summary>
	/// Key: "Label.VipServers"
	/// English String: "VIP Servers"
	/// </summary>
	public override string LabelVipServers => "VIP ì„œë²„";

	/// <summary>
	/// Key: "Message.TryCatalogForItems"
	/// English String: "Try using the catalog to find new items."
	/// </summary>
	public override string MessageTryCatalogForItems => "ì¹´íƒˆë¡œê·¸ì—ì„œ ìƒˆë¡œìš´ ì•„ì´í…œì„ ì°¾ì•„ë³´ì„¸ìš”.";

	/// <summary>
	/// Key: "Message.TryLibraryForItems"
	/// English String: "Try using the library to find new items."
	/// </summary>
	public override string MessageTryLibraryForItems => "ë¼ì´ë¸ŒëŸ¬ë¦¬ì—ì„œ ìƒˆë¡œìš´ ì•„ì´í…œì„ ì°¾ì•„ë³´ì„¸ìš”.";

	/// <summary>
	/// Key: "Message.UserHasNoFavoritesCategory"
	/// English String: "This user has not favorited items in this category."
	/// </summary>
	public override string MessageUserHasNoFavoritesCategory => "ë³¸ ì¹´í…Œê³ ë¦¬ì— ì¦ê²¨ì°¾ê¸° ì•„ì´í…œì„ ë³´ìœ í•˜ì§€ ì•Šì€ ì‚¬ìš©ìžìž…ë‹ˆë‹¤.";

	/// <summary>
	/// Key: "Message.UserHasNoItemsCategory"
	/// English String: "This user doesn't have items in this category."
	/// </summary>
	public override string MessageUserHasNoItemsCategory => "ë³¸ ì¹´í…Œê³ ë¦¬ì— ì†í•˜ëŠ” ì•„ì´í…œì„ ë³´ìœ í•˜ê³  ìžˆì§€ ì•Šì€ ì‚¬ìš©ìžìž…ë‹ˆë‹¤.";

	/// <summary>
	/// Key: "Message.UserInventoryHidden"
	/// English String: "You cannot see this player's inventory."
	/// </summary>
	public override string MessageUserInventoryHidden => "ë³¸ í”Œë ˆì´ì–´ì˜ ì¸ë²¤í† ë¦¬ë¥¼ ë³¼ ìˆ˜ ì—†ì–´ìš”.";

	/// <summary>
	/// Key: "Message.YouHaveNoFavoritesCategory"
	/// English String: "You have not favorited items in this category."
	/// </summary>
	public override string MessageYouHaveNoFavoritesCategory => "ë³¸ ì¹´í…Œê³ ë¦¬ì—ì„œ ì¦ê²¨ì°¾ê¸°ì— ì¶”ê°€í•œ ì•„ì´í…œì´ ì—†ì–´ìš”.";

	/// <summary>
	/// Key: "Message.YouHaveNoItemsCategory"
	/// English String: "You don't have items in this category."
	/// </summary>
	public override string MessageYouHaveNoItemsCategory => "ë³¸ ì¹´í…Œê³ ë¦¬ì— ì†í•˜ëŠ” ì•„ì´í…œì´ ì—†ë„¤ìš”.";

	public InventoryResources_ko_kr(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionGetMore()
	{
		return "ë” ë³´ê¸°";
	}

	protected override string _GetTemplateForHeadingCategory()
	{
		return "ì¹´í…Œê³ ë¦¬";
	}

	protected override string _GetTemplateForHeadingInventory()
	{
		return "ì¸ë²¤í† ë¦¬";
	}

	protected override string _GetTemplateForHeadingMyInventory()
	{
		return "ë‚´ ì¸ë²¤í† ë¦¬";
	}

	protected override string _GetTemplateForHeadingSubcategory()
	{
		return "í•˜ìœ„ ì¹´í…Œê³ ë¦¬";
	}

	/// <summary>
	/// Key: "Heading.UserInventory"
	/// This is the page title referring to another user's inventory. This page contains another user's items and assets.
	/// English String: "{username}'s Inventory"
	/// </summary>
	public override string HeadingUserInventory(string username)
	{
		return $"{username}ë‹˜ì˜ ì¸ë²¤í† ë¦¬";
	}

	protected override string _GetTemplateForHeadingUserInventory()
	{
		return "{username}ë‹˜ì˜ ì¸ë²¤í† ë¦¬";
	}

	protected override string _GetTemplateForLabelBodyParts()
	{
		return "ì‹ ì²´ ë¶€ìœ„";
	}

	protected override string _GetTemplateForLabelBundles()
	{
		return "ë²ˆë“¤";
	}

	protected override string _GetTemplateForLabelCreatedByMe()
	{
		return "ë‚´ê°€ ë§Œë“  ìž¥ì†Œ";
	}

	protected override string _GetTemplateForLabelMyGames()
	{
		return "ë‚´ ê²Œìž„";
	}

	protected override string _GetTemplateForLabelMyVipServers()
	{
		return "ë‚´ VIP ì„œë²„";
	}

	protected override string _GetTemplateForLabelOffsale()
	{
		return "íŒë§¤ ì¤‘ë‹¨";
	}

	protected override string _GetTemplateForLabelOtherGames()
	{
		return "ê¸°íƒ€ ê²Œìž„";
	}

	protected override string _GetTemplateForLabelOtherVipServers()
	{
		return "ê¸°íƒ€ VIP ì„œë²„";
	}

	protected override string _GetTemplateForLabelOwnershipPreposition()
	{
		return "ê°œë°œ:";
	}

	protected override string _GetTemplateForLabelPlaces()
	{
		return "ìž¥ì†Œ";
	}

	protected override string _GetTemplateForLabelPurchased()
	{
		return "êµ¬ìž…í•œ ìž¥ì†Œ";
	}

	/// <summary>
	/// Key: "Label.RentalExpireTime"
	/// An abbreviated label for expiration of an item. Once the expire time is surpassed, the item will no longer be available to the user.
	/// English String: "Exp: {expireTime}"
	/// </summary>
	public override string LabelRentalExpireTime(string expireTime)
	{
		return $"ë§Œë£Œ: {expireTime}";
	}

	protected override string _GetTemplateForLabelRentalExpireTime()
	{
		return "ë§Œë£Œ: {expireTime}";
	}

	protected override string _GetTemplateForLabelVipServers()
	{
		return "VIP ì„œë²„";
	}

	/// <summary>
	/// Key: "Message.ExploreCatalogForItems"
	/// For example, Explore the catalog to find more Animations! The catalog is a page where the user can find many items that can improve the user's appearance.
	/// English String: "Explore the catalog to find more {itemsPlural}!"
	/// </summary>
	public override string MessageExploreCatalogForItems(string itemsPlural)
	{
		return $"ì¹´íƒˆë¡œê·¸ì—ì„œ ë” ë§Žì€ {itemsPlural}(ì„)ë¥¼ ì°¾ì•„ë³´ì„¸ìš”!";
	}

	protected override string _GetTemplateForMessageExploreCatalogForItems()
	{
		return "ì¹´íƒˆë¡œê·¸ì—ì„œ ë” ë§Žì€ {itemsPlural}(ì„)ë¥¼ ì°¾ì•„ë³´ì„¸ìš”!";
	}

	/// <summary>
	/// Key: "Message.ExploreLibraryForItems"
	/// For example, Explore the library to find more Animations! The library is a page where the user can find many assets and items that other users have created.
	/// English String: "Explore the library to find more {itemsPlural}!"
	/// </summary>
	public override string MessageExploreLibraryForItems(string itemsPlural)
	{
		return $"ë¼ì´ë¸ŒëŸ¬ë¦¬ì—ì„œ ë” ë§Žì€ {itemsPlural}ì„(ë¥¼) ì°¾ì•„ë³´ì„¸ìš”!";
	}

	protected override string _GetTemplateForMessageExploreLibraryForItems()
	{
		return "ë¼ì´ë¸ŒëŸ¬ë¦¬ì—ì„œ ë” ë§Žì€ {itemsPlural}ì„(ë¥¼) ì°¾ì•„ë³´ì„¸ìš”!";
	}

	protected override string _GetTemplateForMessageTryCatalogForItems()
	{
		return "ì¹´íƒˆë¡œê·¸ì—ì„œ ìƒˆë¡œìš´ ì•„ì´í…œì„ ì°¾ì•„ë³´ì„¸ìš”.";
	}

	/// <summary>
	/// Key: "Message.TryCatalogLink"
	/// The catalog text will link to the Catalog page to find more items.
	/// English String: "Try using the {startLink}catalog{endLink} to find new items."
	/// </summary>
	public override string MessageTryCatalogLink(string startLink, string endLink)
	{
		return $"{startLink}ì¹´íƒˆë¡œê·¸{endLink}ì—ì„œ ìƒˆë¡œìš´ ì•„ì´í…œì„ ì°¾ì•„ë³´ì„¸ìš”.";
	}

	protected override string _GetTemplateForMessageTryCatalogLink()
	{
		return "{startLink}ì¹´íƒˆë¡œê·¸{endLink}ì—ì„œ ìƒˆë¡œìš´ ì•„ì´í…œì„ ì°¾ì•„ë³´ì„¸ìš”.";
	}

	protected override string _GetTemplateForMessageTryLibraryForItems()
	{
		return "ë¼ì´ë¸ŒëŸ¬ë¦¬ì—ì„œ ìƒˆë¡œìš´ ì•„ì´í…œì„ ì°¾ì•„ë³´ì„¸ìš”.";
	}

	/// <summary>
	/// Key: "Message.TryLibraryLink"
	/// The library text will link to the Library page to find more items.
	/// English String: "Try using the {startLink}library{endLink} to find new items."
	/// </summary>
	public override string MessageTryLibraryLink(string startLink, string endLink)
	{
		return $"{startLink}ë¼ì´ë¸ŒëŸ¬ë¦¬{endLink}ì—ì„œ ìƒˆë¡œìš´ ì•„ì´í…œì„ ì°¾ì•„ë³´ì„¸ìš”.";
	}

	protected override string _GetTemplateForMessageTryLibraryLink()
	{
		return "{startLink}ë¼ì´ë¸ŒëŸ¬ë¦¬{endLink}ì—ì„œ ìƒˆë¡œìš´ ì•„ì´í…œì„ ì°¾ì•„ë³´ì„¸ìš”.";
	}

	protected override string _GetTemplateForMessageUserHasNoFavoritesCategory()
	{
		return "ë³¸ ì¹´í…Œê³ ë¦¬ì— ì¦ê²¨ì°¾ê¸° ì•„ì´í…œì„ ë³´ìœ í•˜ì§€ ì•Šì€ ì‚¬ìš©ìžìž…ë‹ˆë‹¤.";
	}

	/// <summary>
	/// Key: "Message.UserHasNoItems"
	/// For example, This user has no shoulder accessories.
	/// English String: "This user has no {itemsPlural}."
	/// </summary>
	public override string MessageUserHasNoItems(string itemsPlural)
	{
		return $"ë³¸ ì‚¬ìš©ìžëŠ” {itemsPlural}ì´(ê°€) ì—†ìŠµë‹ˆë‹¤.";
	}

	protected override string _GetTemplateForMessageUserHasNoItems()
	{
		return "ë³¸ ì‚¬ìš©ìžëŠ” {itemsPlural}ì´(ê°€) ì—†ìŠµë‹ˆë‹¤.";
	}

	protected override string _GetTemplateForMessageUserHasNoItemsCategory()
	{
		return "ë³¸ ì¹´í…Œê³ ë¦¬ì— ì†í•˜ëŠ” ì•„ì´í…œì„ ë³´ìœ í•˜ê³  ìžˆì§€ ì•Šì€ ì‚¬ìš©ìžìž…ë‹ˆë‹¤.";
	}

	protected override string _GetTemplateForMessageUserInventoryHidden()
	{
		return "ë³¸ í”Œë ˆì´ì–´ì˜ ì¸ë²¤í† ë¦¬ë¥¼ ë³¼ ìˆ˜ ì—†ì–´ìš”.";
	}

	/// <summary>
	/// Key: "Message.UserNotFavoritedItems"
	/// For example, This user has not favorited any shoulder accessories. Favoriting is the verb for a user to add an item or asset to their favorites list.
	/// English String: "This user has not favorited any {itemsPlural}."
	/// </summary>
	public override string MessageUserNotFavoritedItems(string itemsPlural)
	{
		return $"ë³¸ ì‚¬ìš©ìžê°€ ì¦ê²¨ì°¾ê¸°ì— ì¶”ê°€í•œ {itemsPlural}ì´(ê°€) ì—†ìŠµë‹ˆë‹¤.";
	}

	protected override string _GetTemplateForMessageUserNotFavoritedItems()
	{
		return "ë³¸ ì‚¬ìš©ìžê°€ ì¦ê²¨ì°¾ê¸°ì— ì¶”ê°€í•œ {itemsPlural}ì´(ê°€) ì—†ìŠµë‹ˆë‹¤.";
	}

	protected override string _GetTemplateForMessageYouHaveNoFavoritesCategory()
	{
		return "ë³¸ ì¹´í…Œê³ ë¦¬ì—ì„œ ì¦ê²¨ì°¾ê¸°ì— ì¶”ê°€í•œ ì•„ì´í…œì´ ì—†ì–´ìš”.";
	}

	/// <summary>
	/// Key: "Message.YouHaveNoItems"
	/// For example, You have no shoulder accessories.
	/// English String: "You have no {itemsPlural}."
	/// </summary>
	public override string MessageYouHaveNoItems(string itemsPlural)
	{
		return $"íšŒì›ë‹˜ì€ {itemsPlural}ì´(ê°€) ì—†ìŠµë‹ˆë‹¤.";
	}

	protected override string _GetTemplateForMessageYouHaveNoItems()
	{
		return "íšŒì›ë‹˜ì€ {itemsPlural}ì´(ê°€) ì—†ìŠµë‹ˆë‹¤.";
	}

	protected override string _GetTemplateForMessageYouHaveNoItemsCategory()
	{
		return "ë³¸ ì¹´í…Œê³ ë¦¬ì— ì†í•˜ëŠ” ì•„ì´í…œì´ ì—†ë„¤ìš”.";
	}

	/// <summary>
	/// Key: "Message.YouNotFavoritedItems"
	/// For example, You have not favorited any shoulder accessories. Favoriting is the verb for a user to add an item or asset to their favorites list.
	/// English String: "You have not favorited any {itemsPlural}."
	/// </summary>
	public override string MessageYouNotFavoritedItems(string itemsPlural)
	{
		return $"ì¦ê²¨ì°¾ê¸°ì— ì¶”ê°€í•œ {itemsPlural}ì´(ê°€) ì—†ìŠµë‹ˆë‹¤.";
	}

	protected override string _GetTemplateForMessageYouNotFavoritedItems()
	{
		return "ì¦ê²¨ì°¾ê¸°ì— ì¶”ê°€í•œ {itemsPlural}ì´(ê°€) ì—†ìŠµë‹ˆë‹¤.";
	}
}


}
