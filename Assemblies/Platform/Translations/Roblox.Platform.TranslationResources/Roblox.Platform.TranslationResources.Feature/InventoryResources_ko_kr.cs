namespace Roblox.TranslationResources.Feature;

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
	public override string ActionGetMore => "더 보기";

	/// <summary>
	/// Key: "Heading.Category"
	/// These categories include different item and asset types such as Accessories, Meshes, Badges, Audio assets, and Pants
	/// English String: "Category"
	/// </summary>
	public override string HeadingCategory => "카테고리";

	/// <summary>
	/// Key: "Heading.Inventory"
	/// This is the button that users will click on the navigation menu to go to the Inventory page, which contains items and assets that the user has to improve their appearance or use to develop games.
	/// English String: "Inventory"
	/// </summary>
	public override string HeadingInventory => "인벤토리";

	/// <summary>
	/// Key: "Heading.MyInventory"
	/// This is the page title referring to your own inventory. This page contains the user's items and assets.
	/// English String: "My Inventory"
	/// </summary>
	public override string HeadingMyInventory => "내 인벤토리";

	/// <summary>
	/// Key: "Heading.Subcategory"
	/// These subcategories include different sub-types of asset types. The subcategories under Accessories could be Hats, Hair, and Face.
	/// English String: "Subcategory"
	/// </summary>
	public override string HeadingSubcategory => "하위 카테고리";

	/// <summary>
	/// Key: "Label.BodyParts"
	/// English String: "Body Parts"
	/// </summary>
	public override string LabelBodyParts => "신체 부위";

	/// <summary>
	/// Key: "Label.Bundles"
	/// English String: "Bundles"
	/// </summary>
	public override string LabelBundles => "번들";

	/// <summary>
	/// Key: "Label.CreatedByMe"
	/// English String: "Created by Me"
	/// </summary>
	public override string LabelCreatedByMe => "내가 만든 장소";

	/// <summary>
	/// Key: "Label.MyGames"
	/// English String: "My Games"
	/// </summary>
	public override string LabelMyGames => "내 게임";

	/// <summary>
	/// Key: "Label.MyVipServers"
	/// English String: "My VIP Servers"
	/// </summary>
	public override string LabelMyVipServers => "내 VIP 서버";

	/// <summary>
	/// Key: "Label.Offsale"
	/// An item with this label is no longer on sale and cannot be obtained.
	/// English String: "Offsale"
	/// </summary>
	public override string LabelOffsale => "판매 중단";

	/// <summary>
	/// Key: "Label.OtherGames"
	/// English String: "Other Games"
	/// </summary>
	public override string LabelOtherGames => "기타 게임";

	/// <summary>
	/// Key: "Label.OtherVipServers"
	/// English String: "Other VIP Servers"
	/// </summary>
	public override string LabelOtherVipServers => "기타 VIP 서버";

	/// <summary>
	/// Key: "Label.OwnershipPreposition"
	/// This word is used to show that an item was created "By" someone or some entity.
	/// English String: "By"
	/// </summary>
	public override string LabelOwnershipPreposition => "개발:";

	/// <summary>
	/// Key: "Label.Places"
	/// English String: "Places"
	/// </summary>
	public override string LabelPlaces => "장소";

	/// <summary>
	/// Key: "Label.Purchased"
	/// English String: "Purchased"
	/// </summary>
	public override string LabelPurchased => "구입한 장소";

	/// <summary>
	/// Key: "Label.VipServers"
	/// English String: "VIP Servers"
	/// </summary>
	public override string LabelVipServers => "VIP 서버";

	/// <summary>
	/// Key: "Message.TryCatalogForItems"
	/// English String: "Try using the catalog to find new items."
	/// </summary>
	public override string MessageTryCatalogForItems => "카탈로그에서 새로운 아이템을 찾아보세요.";

	/// <summary>
	/// Key: "Message.TryLibraryForItems"
	/// English String: "Try using the library to find new items."
	/// </summary>
	public override string MessageTryLibraryForItems => "라이브러리에서 새로운 아이템을 찾아보세요.";

	/// <summary>
	/// Key: "Message.UserHasNoFavoritesCategory"
	/// English String: "This user has not favorited items in this category."
	/// </summary>
	public override string MessageUserHasNoFavoritesCategory => "본 카테고리에 즐겨찾기 아이템을 보유하지 않은 사용자입니다.";

	/// <summary>
	/// Key: "Message.UserHasNoItemsCategory"
	/// English String: "This user doesn't have items in this category."
	/// </summary>
	public override string MessageUserHasNoItemsCategory => "본 카테고리에 속하는 아이템을 보유하고 있지 않은 사용자입니다.";

	/// <summary>
	/// Key: "Message.UserInventoryHidden"
	/// English String: "You cannot see this player's inventory."
	/// </summary>
	public override string MessageUserInventoryHidden => "본 플레이어의 인벤토리를 볼 수 없어요.";

	/// <summary>
	/// Key: "Message.YouHaveNoFavoritesCategory"
	/// English String: "You have not favorited items in this category."
	/// </summary>
	public override string MessageYouHaveNoFavoritesCategory => "본 카테고리에서 즐겨찾기에 추가한 아이템이 없어요.";

	/// <summary>
	/// Key: "Message.YouHaveNoItemsCategory"
	/// English String: "You don't have items in this category."
	/// </summary>
	public override string MessageYouHaveNoItemsCategory => "본 카테고리에 속하는 아이템이 없네요.";

	public InventoryResources_ko_kr(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionGetMore()
	{
		return "더 보기";
	}

	protected override string _GetTemplateForHeadingCategory()
	{
		return "카테고리";
	}

	protected override string _GetTemplateForHeadingInventory()
	{
		return "인벤토리";
	}

	protected override string _GetTemplateForHeadingMyInventory()
	{
		return "내 인벤토리";
	}

	protected override string _GetTemplateForHeadingSubcategory()
	{
		return "하위 카테고리";
	}

	/// <summary>
	/// Key: "Heading.UserInventory"
	/// This is the page title referring to another user's inventory. This page contains another user's items and assets.
	/// English String: "{username}'s Inventory"
	/// </summary>
	public override string HeadingUserInventory(string username)
	{
		return $"{username}님의 인벤토리";
	}

	protected override string _GetTemplateForHeadingUserInventory()
	{
		return "{username}님의 인벤토리";
	}

	protected override string _GetTemplateForLabelBodyParts()
	{
		return "신체 부위";
	}

	protected override string _GetTemplateForLabelBundles()
	{
		return "번들";
	}

	protected override string _GetTemplateForLabelCreatedByMe()
	{
		return "내가 만든 장소";
	}

	protected override string _GetTemplateForLabelMyGames()
	{
		return "내 게임";
	}

	protected override string _GetTemplateForLabelMyVipServers()
	{
		return "내 VIP 서버";
	}

	protected override string _GetTemplateForLabelOffsale()
	{
		return "판매 중단";
	}

	protected override string _GetTemplateForLabelOtherGames()
	{
		return "기타 게임";
	}

	protected override string _GetTemplateForLabelOtherVipServers()
	{
		return "기타 VIP 서버";
	}

	protected override string _GetTemplateForLabelOwnershipPreposition()
	{
		return "개발:";
	}

	protected override string _GetTemplateForLabelPlaces()
	{
		return "장소";
	}

	protected override string _GetTemplateForLabelPurchased()
	{
		return "구입한 장소";
	}

	/// <summary>
	/// Key: "Label.RentalExpireTime"
	/// An abbreviated label for expiration of an item. Once the expire time is surpassed, the item will no longer be available to the user.
	/// English String: "Exp: {expireTime}"
	/// </summary>
	public override string LabelRentalExpireTime(string expireTime)
	{
		return $"만료: {expireTime}";
	}

	protected override string _GetTemplateForLabelRentalExpireTime()
	{
		return "만료: {expireTime}";
	}

	protected override string _GetTemplateForLabelVipServers()
	{
		return "VIP 서버";
	}

	/// <summary>
	/// Key: "Message.ExploreCatalogForItems"
	/// For example, Explore the catalog to find more Animations! The catalog is a page where the user can find many items that can improve the user's appearance.
	/// English String: "Explore the catalog to find more {itemsPlural}!"
	/// </summary>
	public override string MessageExploreCatalogForItems(string itemsPlural)
	{
		return $"카탈로그에서 더 많은 {itemsPlural}(을)를 찾아보세요!";
	}

	protected override string _GetTemplateForMessageExploreCatalogForItems()
	{
		return "카탈로그에서 더 많은 {itemsPlural}(을)를 찾아보세요!";
	}

	/// <summary>
	/// Key: "Message.ExploreLibraryForItems"
	/// For example, Explore the library to find more Animations! The library is a page where the user can find many assets and items that other users have created.
	/// English String: "Explore the library to find more {itemsPlural}!"
	/// </summary>
	public override string MessageExploreLibraryForItems(string itemsPlural)
	{
		return $"라이브러리에서 더 많은 {itemsPlural}을(를) 찾아보세요!";
	}

	protected override string _GetTemplateForMessageExploreLibraryForItems()
	{
		return "라이브러리에서 더 많은 {itemsPlural}을(를) 찾아보세요!";
	}

	protected override string _GetTemplateForMessageTryCatalogForItems()
	{
		return "카탈로그에서 새로운 아이템을 찾아보세요.";
	}

	/// <summary>
	/// Key: "Message.TryCatalogLink"
	/// The catalog text will link to the Catalog page to find more items.
	/// English String: "Try using the {startLink}catalog{endLink} to find new items."
	/// </summary>
	public override string MessageTryCatalogLink(string startLink, string endLink)
	{
		return $"{startLink}카탈로그{endLink}에서 새로운 아이템을 찾아보세요.";
	}

	protected override string _GetTemplateForMessageTryCatalogLink()
	{
		return "{startLink}카탈로그{endLink}에서 새로운 아이템을 찾아보세요.";
	}

	protected override string _GetTemplateForMessageTryLibraryForItems()
	{
		return "라이브러리에서 새로운 아이템을 찾아보세요.";
	}

	/// <summary>
	/// Key: "Message.TryLibraryLink"
	/// The library text will link to the Library page to find more items.
	/// English String: "Try using the {startLink}library{endLink} to find new items."
	/// </summary>
	public override string MessageTryLibraryLink(string startLink, string endLink)
	{
		return $"{startLink}라이브러리{endLink}에서 새로운 아이템을 찾아보세요.";
	}

	protected override string _GetTemplateForMessageTryLibraryLink()
	{
		return "{startLink}라이브러리{endLink}에서 새로운 아이템을 찾아보세요.";
	}

	protected override string _GetTemplateForMessageUserHasNoFavoritesCategory()
	{
		return "본 카테고리에 즐겨찾기 아이템을 보유하지 않은 사용자입니다.";
	}

	/// <summary>
	/// Key: "Message.UserHasNoItems"
	/// For example, This user has no shoulder accessories.
	/// English String: "This user has no {itemsPlural}."
	/// </summary>
	public override string MessageUserHasNoItems(string itemsPlural)
	{
		return $"본 사용자는 {itemsPlural}이(가) 없습니다.";
	}

	protected override string _GetTemplateForMessageUserHasNoItems()
	{
		return "본 사용자는 {itemsPlural}이(가) 없습니다.";
	}

	protected override string _GetTemplateForMessageUserHasNoItemsCategory()
	{
		return "본 카테고리에 속하는 아이템을 보유하고 있지 않은 사용자입니다.";
	}

	protected override string _GetTemplateForMessageUserInventoryHidden()
	{
		return "본 플레이어의 인벤토리를 볼 수 없어요.";
	}

	/// <summary>
	/// Key: "Message.UserNotFavoritedItems"
	/// For example, This user has not favorited any shoulder accessories. Favoriting is the verb for a user to add an item or asset to their favorites list.
	/// English String: "This user has not favorited any {itemsPlural}."
	/// </summary>
	public override string MessageUserNotFavoritedItems(string itemsPlural)
	{
		return $"본 사용자가 즐겨찾기에 추가한 {itemsPlural}이(가) 없습니다.";
	}

	protected override string _GetTemplateForMessageUserNotFavoritedItems()
	{
		return "본 사용자가 즐겨찾기에 추가한 {itemsPlural}이(가) 없습니다.";
	}

	protected override string _GetTemplateForMessageYouHaveNoFavoritesCategory()
	{
		return "본 카테고리에서 즐겨찾기에 추가한 아이템이 없어요.";
	}

	/// <summary>
	/// Key: "Message.YouHaveNoItems"
	/// For example, You have no shoulder accessories.
	/// English String: "You have no {itemsPlural}."
	/// </summary>
	public override string MessageYouHaveNoItems(string itemsPlural)
	{
		return $"회원님은 {itemsPlural}이(가) 없습니다.";
	}

	protected override string _GetTemplateForMessageYouHaveNoItems()
	{
		return "회원님은 {itemsPlural}이(가) 없습니다.";
	}

	protected override string _GetTemplateForMessageYouHaveNoItemsCategory()
	{
		return "본 카테고리에 속하는 아이템이 없네요.";
	}

	/// <summary>
	/// Key: "Message.YouNotFavoritedItems"
	/// For example, You have not favorited any shoulder accessories. Favoriting is the verb for a user to add an item or asset to their favorites list.
	/// English String: "You have not favorited any {itemsPlural}."
	/// </summary>
	public override string MessageYouNotFavoritedItems(string itemsPlural)
	{
		return $"즐겨찾기에 추가한 {itemsPlural}이(가) 없습니다.";
	}

	protected override string _GetTemplateForMessageYouNotFavoritedItems()
	{
		return "즐겨찾기에 추가한 {itemsPlural}이(가) 없습니다.";
	}
}
