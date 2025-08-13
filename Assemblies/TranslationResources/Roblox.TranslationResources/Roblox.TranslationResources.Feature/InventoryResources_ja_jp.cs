namespace Roblox.TranslationResources.Feature;

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
	public override string ActionGetMore => "さらにゲット";

	/// <summary>
	/// Key: "Heading.Category"
	/// These categories include different item and asset types such as Accessories, Meshes, Badges, Audio assets, and Pants
	/// English String: "Category"
	/// </summary>
	public override string HeadingCategory => "カテゴリ";

	/// <summary>
	/// Key: "Heading.Inventory"
	/// This is the button that users will click on the navigation menu to go to the Inventory page, which contains items and assets that the user has to improve their appearance or use to develop games.
	/// English String: "Inventory"
	/// </summary>
	public override string HeadingInventory => "インベントリ";

	/// <summary>
	/// Key: "Heading.MyInventory"
	/// This is the page title referring to your own inventory. This page contains the user's items and assets.
	/// English String: "My Inventory"
	/// </summary>
	public override string HeadingMyInventory => "マイインベントリ";

	/// <summary>
	/// Key: "Heading.Subcategory"
	/// These subcategories include different sub-types of asset types. The subcategories under Accessories could be Hats, Hair, and Face.
	/// English String: "Subcategory"
	/// </summary>
	public override string HeadingSubcategory => "サブカテゴリ";

	/// <summary>
	/// Key: "Label.BodyParts"
	/// English String: "Body Parts"
	/// </summary>
	public override string LabelBodyParts => "ボディパーツ";

	/// <summary>
	/// Key: "Label.Bundles"
	/// English String: "Bundles"
	/// </summary>
	public override string LabelBundles => "バンドル";

	/// <summary>
	/// Key: "Label.CreatedByMe"
	/// English String: "Created by Me"
	/// </summary>
	public override string LabelCreatedByMe => "あなたが作成";

	/// <summary>
	/// Key: "Label.MyGames"
	/// English String: "My Games"
	/// </summary>
	public override string LabelMyGames => "マイゲーム";

	/// <summary>
	/// Key: "Label.MyVipServers"
	/// English String: "My VIP Servers"
	/// </summary>
	public override string LabelMyVipServers => "マイVIPサーバー";

	/// <summary>
	/// Key: "Label.Offsale"
	/// An item with this label is no longer on sale and cannot be obtained.
	/// English String: "Offsale"
	/// </summary>
	public override string LabelOffsale => "非売品";

	/// <summary>
	/// Key: "Label.OtherGames"
	/// English String: "Other Games"
	/// </summary>
	public override string LabelOtherGames => "その他のゲーム";

	/// <summary>
	/// Key: "Label.OtherVipServers"
	/// English String: "Other VIP Servers"
	/// </summary>
	public override string LabelOtherVipServers => "その他のVIPサーバー";

	/// <summary>
	/// Key: "Label.OwnershipPreposition"
	/// This word is used to show that an item was created "By" someone or some entity.
	/// English String: "By"
	/// </summary>
	public override string LabelOwnershipPreposition => "作：";

	/// <summary>
	/// Key: "Label.Places"
	/// English String: "Places"
	/// </summary>
	public override string LabelPlaces => "プレース";

	/// <summary>
	/// Key: "Label.Purchased"
	/// English String: "Purchased"
	/// </summary>
	public override string LabelPurchased => "購入済み";

	/// <summary>
	/// Key: "Label.VipServers"
	/// English String: "VIP Servers"
	/// </summary>
	public override string LabelVipServers => "VIPサーバー";

	/// <summary>
	/// Key: "Message.TryCatalogForItems"
	/// English String: "Try using the catalog to find new items."
	/// </summary>
	public override string MessageTryCatalogForItems => "カタログを使って新しいアイテムを見つけよう！";

	/// <summary>
	/// Key: "Message.TryLibraryForItems"
	/// English String: "Try using the library to find new items."
	/// </summary>
	public override string MessageTryLibraryForItems => "ライブラリを使って新しいアイテムを見つけよう！";

	/// <summary>
	/// Key: "Message.UserHasNoFavoritesCategory"
	/// English String: "This user has not favorited items in this category."
	/// </summary>
	public override string MessageUserHasNoFavoritesCategory => "このユーザーは、このカテゴリのアイテムをお気に入りに登録していません。";

	/// <summary>
	/// Key: "Message.UserHasNoItemsCategory"
	/// English String: "This user doesn't have items in this category."
	/// </summary>
	public override string MessageUserHasNoItemsCategory => "このユーザーは、このカテゴリのアイテムを持っていません。";

	/// <summary>
	/// Key: "Message.UserInventoryHidden"
	/// English String: "You cannot see this player's inventory."
	/// </summary>
	public override string MessageUserInventoryHidden => "このプレイヤーのインベントリを見ることはできません。";

	/// <summary>
	/// Key: "Message.YouHaveNoFavoritesCategory"
	/// English String: "You have not favorited items in this category."
	/// </summary>
	public override string MessageYouHaveNoFavoritesCategory => "このカテゴリのアイテムをお気に入りに登録していません。";

	/// <summary>
	/// Key: "Message.YouHaveNoItemsCategory"
	/// English String: "You don't have items in this category."
	/// </summary>
	public override string MessageYouHaveNoItemsCategory => "このカテゴリのアイテムを持っていません。";

	public InventoryResources_ja_jp(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionGetMore()
	{
		return "さらにゲット";
	}

	protected override string _GetTemplateForHeadingCategory()
	{
		return "カテゴリ";
	}

	protected override string _GetTemplateForHeadingInventory()
	{
		return "インベントリ";
	}

	protected override string _GetTemplateForHeadingMyInventory()
	{
		return "マイインベントリ";
	}

	protected override string _GetTemplateForHeadingSubcategory()
	{
		return "サブカテゴリ";
	}

	/// <summary>
	/// Key: "Heading.UserInventory"
	/// This is the page title referring to another user's inventory. This page contains another user's items and assets.
	/// English String: "{username}'s Inventory"
	/// </summary>
	public override string HeadingUserInventory(string username)
	{
		return $"{username}さんのインベントリ";
	}

	protected override string _GetTemplateForHeadingUserInventory()
	{
		return "{username}さんのインベントリ";
	}

	protected override string _GetTemplateForLabelBodyParts()
	{
		return "ボディパーツ";
	}

	protected override string _GetTemplateForLabelBundles()
	{
		return "バンドル";
	}

	protected override string _GetTemplateForLabelCreatedByMe()
	{
		return "あなたが作成";
	}

	protected override string _GetTemplateForLabelMyGames()
	{
		return "マイゲーム";
	}

	protected override string _GetTemplateForLabelMyVipServers()
	{
		return "マイVIPサーバー";
	}

	protected override string _GetTemplateForLabelOffsale()
	{
		return "非売品";
	}

	protected override string _GetTemplateForLabelOtherGames()
	{
		return "その他のゲーム";
	}

	protected override string _GetTemplateForLabelOtherVipServers()
	{
		return "その他のVIPサーバー";
	}

	protected override string _GetTemplateForLabelOwnershipPreposition()
	{
		return "作：";
	}

	protected override string _GetTemplateForLabelPlaces()
	{
		return "プレース";
	}

	protected override string _GetTemplateForLabelPurchased()
	{
		return "購入済み";
	}

	/// <summary>
	/// Key: "Label.RentalExpireTime"
	/// An abbreviated label for expiration of an item. Once the expire time is surpassed, the item will no longer be available to the user.
	/// English String: "Exp: {expireTime}"
	/// </summary>
	public override string LabelRentalExpireTime(string expireTime)
	{
		return $"期限: {expireTime}";
	}

	protected override string _GetTemplateForLabelRentalExpireTime()
	{
		return "期限: {expireTime}";
	}

	protected override string _GetTemplateForLabelVipServers()
	{
		return "VIPサーバー";
	}

	/// <summary>
	/// Key: "Message.ExploreCatalogForItems"
	/// For example, Explore the catalog to find more Animations! The catalog is a page where the user can find many items that can improve the user's appearance.
	/// English String: "Explore the catalog to find more {itemsPlural}!"
	/// </summary>
	public override string MessageExploreCatalogForItems(string itemsPlural)
	{
		return $"カタログをチェックして、{itemsPlural} を見つけよう！";
	}

	protected override string _GetTemplateForMessageExploreCatalogForItems()
	{
		return "カタログをチェックして、{itemsPlural} を見つけよう！";
	}

	/// <summary>
	/// Key: "Message.ExploreLibraryForItems"
	/// For example, Explore the library to find more Animations! The library is a page where the user can find many assets and items that other users have created.
	/// English String: "Explore the library to find more {itemsPlural}!"
	/// </summary>
	public override string MessageExploreLibraryForItems(string itemsPlural)
	{
		return $"ライブラリをチェックして、{itemsPlural} を見つけよう！";
	}

	protected override string _GetTemplateForMessageExploreLibraryForItems()
	{
		return "ライブラリをチェックして、{itemsPlural} を見つけよう！";
	}

	protected override string _GetTemplateForMessageTryCatalogForItems()
	{
		return "カタログを使って新しいアイテムを見つけよう！";
	}

	/// <summary>
	/// Key: "Message.TryCatalogLink"
	/// The catalog text will link to the Catalog page to find more items.
	/// English String: "Try using the {startLink}catalog{endLink} to find new items."
	/// </summary>
	public override string MessageTryCatalogLink(string startLink, string endLink)
	{
		return $"{startLink}カタログ{endLink}を使って新しいアイテムを見つけよう！";
	}

	protected override string _GetTemplateForMessageTryCatalogLink()
	{
		return "{startLink}カタログ{endLink}を使って新しいアイテムを見つけよう！";
	}

	protected override string _GetTemplateForMessageTryLibraryForItems()
	{
		return "ライブラリを使って新しいアイテムを見つけよう！";
	}

	/// <summary>
	/// Key: "Message.TryLibraryLink"
	/// The library text will link to the Library page to find more items.
	/// English String: "Try using the {startLink}library{endLink} to find new items."
	/// </summary>
	public override string MessageTryLibraryLink(string startLink, string endLink)
	{
		return $"{startLink}ライブラリ{endLink}を使って新しいアイテムを見つけよう！";
	}

	protected override string _GetTemplateForMessageTryLibraryLink()
	{
		return "{startLink}ライブラリ{endLink}を使って新しいアイテムを見つけよう！";
	}

	protected override string _GetTemplateForMessageUserHasNoFavoritesCategory()
	{
		return "このユーザーは、このカテゴリのアイテムをお気に入りに登録していません。";
	}

	/// <summary>
	/// Key: "Message.UserHasNoItems"
	/// For example, This user has no shoulder accessories.
	/// English String: "This user has no {itemsPlural}."
	/// </summary>
	public override string MessageUserHasNoItems(string itemsPlural)
	{
		return $"このユーザーは、{itemsPlural}を持っていません。";
	}

	protected override string _GetTemplateForMessageUserHasNoItems()
	{
		return "このユーザーは、{itemsPlural}を持っていません。";
	}

	protected override string _GetTemplateForMessageUserHasNoItemsCategory()
	{
		return "このユーザーは、このカテゴリのアイテムを持っていません。";
	}

	protected override string _GetTemplateForMessageUserInventoryHidden()
	{
		return "このプレイヤーのインベントリを見ることはできません。";
	}

	/// <summary>
	/// Key: "Message.UserNotFavoritedItems"
	/// For example, This user has not favorited any shoulder accessories. Favoriting is the verb for a user to add an item or asset to their favorites list.
	/// English String: "This user has not favorited any {itemsPlural}."
	/// </summary>
	public override string MessageUserNotFavoritedItems(string itemsPlural)
	{
		return $"このユーザーは、{itemsPlural}をお気に入りに登録していません。";
	}

	protected override string _GetTemplateForMessageUserNotFavoritedItems()
	{
		return "このユーザーは、{itemsPlural}をお気に入りに登録していません。";
	}

	protected override string _GetTemplateForMessageYouHaveNoFavoritesCategory()
	{
		return "このカテゴリのアイテムをお気に入りに登録していません。";
	}

	/// <summary>
	/// Key: "Message.YouHaveNoItems"
	/// For example, You have no shoulder accessories.
	/// English String: "You have no {itemsPlural}."
	/// </summary>
	public override string MessageYouHaveNoItems(string itemsPlural)
	{
		return $"あなたは{itemsPlural}を持っていません。";
	}

	protected override string _GetTemplateForMessageYouHaveNoItems()
	{
		return "あなたは{itemsPlural}を持っていません。";
	}

	protected override string _GetTemplateForMessageYouHaveNoItemsCategory()
	{
		return "このカテゴリのアイテムを持っていません。";
	}

	/// <summary>
	/// Key: "Message.YouNotFavoritedItems"
	/// For example, You have not favorited any shoulder accessories. Favoriting is the verb for a user to add an item or asset to their favorites list.
	/// English String: "You have not favorited any {itemsPlural}."
	/// </summary>
	public override string MessageYouNotFavoritedItems(string itemsPlural)
	{
		return $"{itemsPlural}はお気に入りに登録されていません。";
	}

	protected override string _GetTemplateForMessageYouNotFavoritedItems()
	{
		return "{itemsPlural}はお気に入りに登録されていません。";
	}
}
