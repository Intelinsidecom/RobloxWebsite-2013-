namespace Roblox.TranslationResources.Feature;

/// <summary>
/// This class overrides InventoryResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class InventoryResources_zh_cn : InventoryResources_en_us, IInventoryResources, ITranslationResources
{
	/// <summary>
	/// Key: "Action.GetMore"
	/// Call to action button for the user to get more items or assets
	/// English String: "Get More"
	/// </summary>
	public override string ActionGetMore => "获取更多";

	/// <summary>
	/// Key: "Heading.Category"
	/// These categories include different item and asset types such as Accessories, Meshes, Badges, Audio assets, and Pants
	/// English String: "Category"
	/// </summary>
	public override string HeadingCategory => "类别";

	/// <summary>
	/// Key: "Heading.Inventory"
	/// This is the button that users will click on the navigation menu to go to the Inventory page, which contains items and assets that the user has to improve their appearance or use to develop games.
	/// English String: "Inventory"
	/// </summary>
	public override string HeadingInventory => "道具";

	/// <summary>
	/// Key: "Heading.MyInventory"
	/// This is the page title referring to your own inventory. This page contains the user's items and assets.
	/// English String: "My Inventory"
	/// </summary>
	public override string HeadingMyInventory => "我的道具";

	/// <summary>
	/// Key: "Heading.Subcategory"
	/// These subcategories include different sub-types of asset types. The subcategories under Accessories could be Hats, Hair, and Face.
	/// English String: "Subcategory"
	/// </summary>
	public override string HeadingSubcategory => "子类别";

	/// <summary>
	/// Key: "Label.BodyParts"
	/// English String: "Body Parts"
	/// </summary>
	public override string LabelBodyParts => "身体部件";

	/// <summary>
	/// Key: "Label.Bundles"
	/// English String: "Bundles"
	/// </summary>
	public override string LabelBundles => "套装";

	/// <summary>
	/// Key: "Label.CreatedByMe"
	/// English String: "Created by Me"
	/// </summary>
	public override string LabelCreatedByMe => "我的创作";

	/// <summary>
	/// Key: "Label.MyGames"
	/// English String: "My Games"
	/// </summary>
	public override string LabelMyGames => "我的游戏";

	/// <summary>
	/// Key: "Label.MyVipServers"
	/// English String: "My VIP Servers"
	/// </summary>
	public override string LabelMyVipServers => "我的 VIP 服务器";

	/// <summary>
	/// Key: "Label.Offsale"
	/// An item with this label is no longer on sale and cannot be obtained.
	/// English String: "Offsale"
	/// </summary>
	public override string LabelOffsale => "下架";

	/// <summary>
	/// Key: "Label.OtherGames"
	/// English String: "Other Games"
	/// </summary>
	public override string LabelOtherGames => "其他游戏";

	/// <summary>
	/// Key: "Label.OtherVipServers"
	/// English String: "Other VIP Servers"
	/// </summary>
	public override string LabelOtherVipServers => "其他 VIP 服务器";

	/// <summary>
	/// Key: "Label.OwnershipPreposition"
	/// This word is used to show that an item was created "By" someone or some entity.
	/// English String: "By"
	/// </summary>
	public override string LabelOwnershipPreposition => "作者";

	/// <summary>
	/// Key: "Label.Places"
	/// English String: "Places"
	/// </summary>
	public override string LabelPlaces => "游戏场景";

	/// <summary>
	/// Key: "Label.Purchased"
	/// English String: "Purchased"
	/// </summary>
	public override string LabelPurchased => "已购买";

	/// <summary>
	/// Key: "Label.VipServers"
	/// English String: "VIP Servers"
	/// </summary>
	public override string LabelVipServers => "VIP 服务器";

	/// <summary>
	/// Key: "Message.TryCatalogForItems"
	/// English String: "Try using the catalog to find new items."
	/// </summary>
	public override string MessageTryCatalogForItems => "尝试在商店中寻找新物品。";

	/// <summary>
	/// Key: "Message.TryLibraryForItems"
	/// English String: "Try using the library to find new items."
	/// </summary>
	public override string MessageTryLibraryForItems => "请试试在资料库中发现新物品。";

	/// <summary>
	/// Key: "Message.UserHasNoFavoritesCategory"
	/// English String: "This user has not favorited items in this category."
	/// </summary>
	public override string MessageUserHasNoFavoritesCategory => "此用户在此类别没有设为最爱的项目。";

	/// <summary>
	/// Key: "Message.UserHasNoItemsCategory"
	/// English String: "This user doesn't have items in this category."
	/// </summary>
	public override string MessageUserHasNoItemsCategory => "此用户没有此类别的物品。";

	/// <summary>
	/// Key: "Message.UserInventoryHidden"
	/// English String: "You cannot see this player's inventory."
	/// </summary>
	public override string MessageUserInventoryHidden => "你无法查看此玩家的道具。";

	/// <summary>
	/// Key: "Message.YouHaveNoFavoritesCategory"
	/// English String: "You have not favorited items in this category."
	/// </summary>
	public override string MessageYouHaveNoFavoritesCategory => "你在此类别中没有任何最爱的物品。";

	/// <summary>
	/// Key: "Message.YouHaveNoItemsCategory"
	/// English String: "You don't have items in this category."
	/// </summary>
	public override string MessageYouHaveNoItemsCategory => "你没有此类别的项目。";

	public InventoryResources_zh_cn(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionGetMore()
	{
		return "获取更多";
	}

	protected override string _GetTemplateForHeadingCategory()
	{
		return "类别";
	}

	protected override string _GetTemplateForHeadingInventory()
	{
		return "道具";
	}

	protected override string _GetTemplateForHeadingMyInventory()
	{
		return "我的道具";
	}

	protected override string _GetTemplateForHeadingSubcategory()
	{
		return "子类别";
	}

	/// <summary>
	/// Key: "Heading.UserInventory"
	/// This is the page title referring to another user's inventory. This page contains another user's items and assets.
	/// English String: "{username}'s Inventory"
	/// </summary>
	public override string HeadingUserInventory(string username)
	{
		return $"“{username}”的道具";
	}

	protected override string _GetTemplateForHeadingUserInventory()
	{
		return "“{username}”的道具";
	}

	protected override string _GetTemplateForLabelBodyParts()
	{
		return "身体部件";
	}

	protected override string _GetTemplateForLabelBundles()
	{
		return "套装";
	}

	protected override string _GetTemplateForLabelCreatedByMe()
	{
		return "我的创作";
	}

	protected override string _GetTemplateForLabelMyGames()
	{
		return "我的游戏";
	}

	protected override string _GetTemplateForLabelMyVipServers()
	{
		return "我的 VIP 服务器";
	}

	protected override string _GetTemplateForLabelOffsale()
	{
		return "下架";
	}

	protected override string _GetTemplateForLabelOtherGames()
	{
		return "其他游戏";
	}

	protected override string _GetTemplateForLabelOtherVipServers()
	{
		return "其他 VIP 服务器";
	}

	protected override string _GetTemplateForLabelOwnershipPreposition()
	{
		return "作者";
	}

	protected override string _GetTemplateForLabelPlaces()
	{
		return "游戏场景";
	}

	protected override string _GetTemplateForLabelPurchased()
	{
		return "已购买";
	}

	/// <summary>
	/// Key: "Label.RentalExpireTime"
	/// An abbreviated label for expiration of an item. Once the expire time is surpassed, the item will no longer be available to the user.
	/// English String: "Exp: {expireTime}"
	/// </summary>
	public override string LabelRentalExpireTime(string expireTime)
	{
		return $"失效时间：{expireTime}";
	}

	protected override string _GetTemplateForLabelRentalExpireTime()
	{
		return "失效时间：{expireTime}";
	}

	protected override string _GetTemplateForLabelVipServers()
	{
		return "VIP 服务器";
	}

	/// <summary>
	/// Key: "Message.ExploreCatalogForItems"
	/// For example, Explore the catalog to find more Animations! The catalog is a page where the user can find many items that can improve the user's appearance.
	/// English String: "Explore the catalog to find more {itemsPlural}!"
	/// </summary>
	public override string MessageExploreCatalogForItems(string itemsPlural)
	{
		return $"探索商店，发现更多{itemsPlural}！";
	}

	protected override string _GetTemplateForMessageExploreCatalogForItems()
	{
		return "探索商店，发现更多{itemsPlural}！";
	}

	/// <summary>
	/// Key: "Message.ExploreLibraryForItems"
	/// For example, Explore the library to find more Animations! The library is a page where the user can find many assets and items that other users have created.
	/// English String: "Explore the library to find more {itemsPlural}!"
	/// </summary>
	public override string MessageExploreLibraryForItems(string itemsPlural)
	{
		return $"探索资料库，发现更多{itemsPlural}！";
	}

	protected override string _GetTemplateForMessageExploreLibraryForItems()
	{
		return "探索资料库，发现更多{itemsPlural}！";
	}

	protected override string _GetTemplateForMessageTryCatalogForItems()
	{
		return "尝试在商店中寻找新物品。";
	}

	/// <summary>
	/// Key: "Message.TryCatalogLink"
	/// The catalog text will link to the Catalog page to find more items.
	/// English String: "Try using the {startLink}catalog{endLink} to find new items."
	/// </summary>
	public override string MessageTryCatalogLink(string startLink, string endLink)
	{
		return $"请试试在{startLink}商店{endLink}中发现新物品。";
	}

	protected override string _GetTemplateForMessageTryCatalogLink()
	{
		return "请试试在{startLink}商店{endLink}中发现新物品。";
	}

	protected override string _GetTemplateForMessageTryLibraryForItems()
	{
		return "请试试在资料库中发现新物品。";
	}

	/// <summary>
	/// Key: "Message.TryLibraryLink"
	/// The library text will link to the Library page to find more items.
	/// English String: "Try using the {startLink}library{endLink} to find new items."
	/// </summary>
	public override string MessageTryLibraryLink(string startLink, string endLink)
	{
		return $"请试试使用{startLink}资料库{endLink}来发现新物品。";
	}

	protected override string _GetTemplateForMessageTryLibraryLink()
	{
		return "请试试使用{startLink}资料库{endLink}来发现新物品。";
	}

	protected override string _GetTemplateForMessageUserHasNoFavoritesCategory()
	{
		return "此用户在此类别没有设为最爱的项目。";
	}

	/// <summary>
	/// Key: "Message.UserHasNoItems"
	/// For example, This user has no shoulder accessories.
	/// English String: "This user has no {itemsPlural}."
	/// </summary>
	public override string MessageUserHasNoItems(string itemsPlural)
	{
		return $"此用户没有任何“{itemsPlural}”。";
	}

	protected override string _GetTemplateForMessageUserHasNoItems()
	{
		return "此用户没有任何“{itemsPlural}”。";
	}

	protected override string _GetTemplateForMessageUserHasNoItemsCategory()
	{
		return "此用户没有此类别的物品。";
	}

	protected override string _GetTemplateForMessageUserInventoryHidden()
	{
		return "你无法查看此玩家的道具。";
	}

	/// <summary>
	/// Key: "Message.UserNotFavoritedItems"
	/// For example, This user has not favorited any shoulder accessories. Favoriting is the verb for a user to add an item or asset to their favorites list.
	/// English String: "This user has not favorited any {itemsPlural}."
	/// </summary>
	public override string MessageUserNotFavoritedItems(string itemsPlural)
	{
		return $"此用户没有最爱的“{itemsPlural}”。";
	}

	protected override string _GetTemplateForMessageUserNotFavoritedItems()
	{
		return "此用户没有最爱的“{itemsPlural}”。";
	}

	protected override string _GetTemplateForMessageYouHaveNoFavoritesCategory()
	{
		return "你在此类别中没有任何最爱的物品。";
	}

	/// <summary>
	/// Key: "Message.YouHaveNoItems"
	/// For example, You have no shoulder accessories.
	/// English String: "You have no {itemsPlural}."
	/// </summary>
	public override string MessageYouHaveNoItems(string itemsPlural)
	{
		return $"你没有任何“{itemsPlural}”。";
	}

	protected override string _GetTemplateForMessageYouHaveNoItems()
	{
		return "你没有任何“{itemsPlural}”。";
	}

	protected override string _GetTemplateForMessageYouHaveNoItemsCategory()
	{
		return "你没有此类别的项目。";
	}

	/// <summary>
	/// Key: "Message.YouNotFavoritedItems"
	/// For example, You have not favorited any shoulder accessories. Favoriting is the verb for a user to add an item or asset to their favorites list.
	/// English String: "You have not favorited any {itemsPlural}."
	/// </summary>
	public override string MessageYouNotFavoritedItems(string itemsPlural)
	{
		return $"你没有任何最爱的“{itemsPlural}”。";
	}

	protected override string _GetTemplateForMessageYouNotFavoritedItems()
	{
		return "你没有任何最爱的“{itemsPlural}”。";
	}
}
