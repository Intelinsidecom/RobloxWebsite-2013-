namespace Roblox.TranslationResources.Feature;

/// <summary>
/// This class overrides InventoryResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class InventoryResources_de_de : InventoryResources_en_us, IInventoryResources, ITranslationResources
{
	/// <summary>
	/// Key: "Action.GetMore"
	/// Call to action button for the user to get more items or assets
	/// English String: "Get More"
	/// </summary>
	public override string ActionGetMore => "Mehr holen";

	/// <summary>
	/// Key: "Heading.Category"
	/// These categories include different item and asset types such as Accessories, Meshes, Badges, Audio assets, and Pants
	/// English String: "Category"
	/// </summary>
	public override string HeadingCategory => "Kategorie";

	/// <summary>
	/// Key: "Heading.Inventory"
	/// This is the button that users will click on the navigation menu to go to the Inventory page, which contains items and assets that the user has to improve their appearance or use to develop games.
	/// English String: "Inventory"
	/// </summary>
	public override string HeadingInventory => "Inventar";

	/// <summary>
	/// Key: "Heading.MyInventory"
	/// This is the page title referring to your own inventory. This page contains the user's items and assets.
	/// English String: "My Inventory"
	/// </summary>
	public override string HeadingMyInventory => "Mein Inventar";

	/// <summary>
	/// Key: "Heading.Subcategory"
	/// These subcategories include different sub-types of asset types. The subcategories under Accessories could be Hats, Hair, and Face.
	/// English String: "Subcategory"
	/// </summary>
	public override string HeadingSubcategory => "Unterkategorie";

	/// <summary>
	/// Key: "Label.BodyParts"
	/// English String: "Body Parts"
	/// </summary>
	public override string LabelBodyParts => "Körperteile";

	/// <summary>
	/// Key: "Label.Bundles"
	/// English String: "Bundles"
	/// </summary>
	public override string LabelBundles => "Pakete";

	/// <summary>
	/// Key: "Label.CreatedByMe"
	/// English String: "Created by Me"
	/// </summary>
	public override string LabelCreatedByMe => "Von mir erstellt";

	/// <summary>
	/// Key: "Label.MyGames"
	/// English String: "My Games"
	/// </summary>
	public override string LabelMyGames => "Meine Spiele";

	/// <summary>
	/// Key: "Label.MyVipServers"
	/// English String: "My VIP Servers"
	/// </summary>
	public override string LabelMyVipServers => "Meine VIP-Server";

	/// <summary>
	/// Key: "Label.Offsale"
	/// An item with this label is no longer on sale and cannot be obtained.
	/// English String: "Offsale"
	/// </summary>
	public override string LabelOffsale => "Nicht kaufbar";

	/// <summary>
	/// Key: "Label.OtherGames"
	/// English String: "Other Games"
	/// </summary>
	public override string LabelOtherGames => "Andere Spiele";

	/// <summary>
	/// Key: "Label.OtherVipServers"
	/// English String: "Other VIP Servers"
	/// </summary>
	public override string LabelOtherVipServers => "Andere VIP-Server";

	/// <summary>
	/// Key: "Label.OwnershipPreposition"
	/// This word is used to show that an item was created "By" someone or some entity.
	/// English String: "By"
	/// </summary>
	public override string LabelOwnershipPreposition => "Von";

	/// <summary>
	/// Key: "Label.Places"
	/// English String: "Places"
	/// </summary>
	public override string LabelPlaces => "Orte";

	/// <summary>
	/// Key: "Label.Purchased"
	/// English String: "Purchased"
	/// </summary>
	public override string LabelPurchased => "Gekauft";

	/// <summary>
	/// Key: "Label.VipServers"
	/// English String: "VIP Servers"
	/// </summary>
	public override string LabelVipServers => "VIP-Server";

	/// <summary>
	/// Key: "Message.TryCatalogForItems"
	/// English String: "Try using the catalog to find new items."
	/// </summary>
	public override string MessageTryCatalogForItems => "Schau im Katalog nach, um neue Artikel zu finden.";

	/// <summary>
	/// Key: "Message.TryLibraryForItems"
	/// English String: "Try using the library to find new items."
	/// </summary>
	public override string MessageTryLibraryForItems => "Schau in der Bibliothek nach, um neue Artikel zu finden.";

	/// <summary>
	/// Key: "Message.UserHasNoFavoritesCategory"
	/// English String: "This user has not favorited items in this category."
	/// </summary>
	public override string MessageUserHasNoFavoritesCategory => "Dieser Benutzer hat keine Artikel in dieser Kategorie zu seinen Favoriten hinzugefügt.";

	/// <summary>
	/// Key: "Message.UserHasNoItemsCategory"
	/// English String: "This user doesn't have items in this category."
	/// </summary>
	public override string MessageUserHasNoItemsCategory => "Der Benutzer hat keine Artikel in dieser Kategorie.";

	/// <summary>
	/// Key: "Message.UserInventoryHidden"
	/// English String: "You cannot see this player's inventory."
	/// </summary>
	public override string MessageUserInventoryHidden => "Du kannst das Inventar dieses Spielers nicht sehen.";

	/// <summary>
	/// Key: "Message.YouHaveNoFavoritesCategory"
	/// English String: "You have not favorited items in this category."
	/// </summary>
	public override string MessageYouHaveNoFavoritesCategory => "Du hast keine Favoriten in dieser Kategorie.";

	/// <summary>
	/// Key: "Message.YouHaveNoItemsCategory"
	/// English String: "You don't have items in this category."
	/// </summary>
	public override string MessageYouHaveNoItemsCategory => "Du hast keine Artikel aus dieser Kategorie.";

	public InventoryResources_de_de(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionGetMore()
	{
		return "Mehr holen";
	}

	protected override string _GetTemplateForHeadingCategory()
	{
		return "Kategorie";
	}

	protected override string _GetTemplateForHeadingInventory()
	{
		return "Inventar";
	}

	protected override string _GetTemplateForHeadingMyInventory()
	{
		return "Mein Inventar";
	}

	protected override string _GetTemplateForHeadingSubcategory()
	{
		return "Unterkategorie";
	}

	/// <summary>
	/// Key: "Heading.UserInventory"
	/// This is the page title referring to another user's inventory. This page contains another user's items and assets.
	/// English String: "{username}'s Inventory"
	/// </summary>
	public override string HeadingUserInventory(string username)
	{
		return $"Inventar von {username}";
	}

	protected override string _GetTemplateForHeadingUserInventory()
	{
		return "Inventar von {username}";
	}

	protected override string _GetTemplateForLabelBodyParts()
	{
		return "Körperteile";
	}

	protected override string _GetTemplateForLabelBundles()
	{
		return "Pakete";
	}

	protected override string _GetTemplateForLabelCreatedByMe()
	{
		return "Von mir erstellt";
	}

	protected override string _GetTemplateForLabelMyGames()
	{
		return "Meine Spiele";
	}

	protected override string _GetTemplateForLabelMyVipServers()
	{
		return "Meine VIP-Server";
	}

	protected override string _GetTemplateForLabelOffsale()
	{
		return "Nicht kaufbar";
	}

	protected override string _GetTemplateForLabelOtherGames()
	{
		return "Andere Spiele";
	}

	protected override string _GetTemplateForLabelOtherVipServers()
	{
		return "Andere VIP-Server";
	}

	protected override string _GetTemplateForLabelOwnershipPreposition()
	{
		return "Von";
	}

	protected override string _GetTemplateForLabelPlaces()
	{
		return "Orte";
	}

	protected override string _GetTemplateForLabelPurchased()
	{
		return "Gekauft";
	}

	/// <summary>
	/// Key: "Label.RentalExpireTime"
	/// An abbreviated label for expiration of an item. Once the expire time is surpassed, the item will no longer be available to the user.
	/// English String: "Exp: {expireTime}"
	/// </summary>
	public override string LabelRentalExpireTime(string expireTime)
	{
		return $"Läuft ab: {expireTime}";
	}

	protected override string _GetTemplateForLabelRentalExpireTime()
	{
		return "Läuft ab: {expireTime}";
	}

	protected override string _GetTemplateForLabelVipServers()
	{
		return "VIP-Server";
	}

	/// <summary>
	/// Key: "Message.ExploreCatalogForItems"
	/// For example, Explore the catalog to find more Animations! The catalog is a page where the user can find many items that can improve the user's appearance.
	/// English String: "Explore the catalog to find more {itemsPlural}!"
	/// </summary>
	public override string MessageExploreCatalogForItems(string itemsPlural)
	{
		return $"Durchsuche den Katalog, um mehr {itemsPlural} zu finden!";
	}

	protected override string _GetTemplateForMessageExploreCatalogForItems()
	{
		return "Durchsuche den Katalog, um mehr {itemsPlural} zu finden!";
	}

	/// <summary>
	/// Key: "Message.ExploreLibraryForItems"
	/// For example, Explore the library to find more Animations! The library is a page where the user can find many assets and items that other users have created.
	/// English String: "Explore the library to find more {itemsPlural}!"
	/// </summary>
	public override string MessageExploreLibraryForItems(string itemsPlural)
	{
		return $"Durchsuche die Bibliothek, um mehr {itemsPlural} zu finden!";
	}

	protected override string _GetTemplateForMessageExploreLibraryForItems()
	{
		return "Durchsuche die Bibliothek, um mehr {itemsPlural} zu finden!";
	}

	protected override string _GetTemplateForMessageTryCatalogForItems()
	{
		return "Schau im Katalog nach, um neue Artikel zu finden.";
	}

	/// <summary>
	/// Key: "Message.TryCatalogLink"
	/// The catalog text will link to the Catalog page to find more items.
	/// English String: "Try using the {startLink}catalog{endLink} to find new items."
	/// </summary>
	public override string MessageTryCatalogLink(string startLink, string endLink)
	{
		return $"Schau im {startLink}Katalog{endLink} nach, um neue Artikel zu finden.";
	}

	protected override string _GetTemplateForMessageTryCatalogLink()
	{
		return "Schau im {startLink}Katalog{endLink} nach, um neue Artikel zu finden.";
	}

	protected override string _GetTemplateForMessageTryLibraryForItems()
	{
		return "Schau in der Bibliothek nach, um neue Artikel zu finden.";
	}

	/// <summary>
	/// Key: "Message.TryLibraryLink"
	/// The library text will link to the Library page to find more items.
	/// English String: "Try using the {startLink}library{endLink} to find new items."
	/// </summary>
	public override string MessageTryLibraryLink(string startLink, string endLink)
	{
		return $"Schau in der {startLink}Bibliothek{endLink} nach, um neue Artikel zu finden.";
	}

	protected override string _GetTemplateForMessageTryLibraryLink()
	{
		return "Schau in der {startLink}Bibliothek{endLink} nach, um neue Artikel zu finden.";
	}

	protected override string _GetTemplateForMessageUserHasNoFavoritesCategory()
	{
		return "Dieser Benutzer hat keine Artikel in dieser Kategorie zu seinen Favoriten hinzugefügt.";
	}

	/// <summary>
	/// Key: "Message.UserHasNoItems"
	/// For example, This user has no shoulder accessories.
	/// English String: "This user has no {itemsPlural}."
	/// </summary>
	public override string MessageUserHasNoItems(string itemsPlural)
	{
		return $"Dieser Benutzer hat keine {itemsPlural}.";
	}

	protected override string _GetTemplateForMessageUserHasNoItems()
	{
		return "Dieser Benutzer hat keine {itemsPlural}.";
	}

	protected override string _GetTemplateForMessageUserHasNoItemsCategory()
	{
		return "Der Benutzer hat keine Artikel in dieser Kategorie.";
	}

	protected override string _GetTemplateForMessageUserInventoryHidden()
	{
		return "Du kannst das Inventar dieses Spielers nicht sehen.";
	}

	/// <summary>
	/// Key: "Message.UserNotFavoritedItems"
	/// For example, This user has not favorited any shoulder accessories. Favoriting is the verb for a user to add an item or asset to their favorites list.
	/// English String: "This user has not favorited any {itemsPlural}."
	/// </summary>
	public override string MessageUserNotFavoritedItems(string itemsPlural)
	{
		return $"Dieser Benutzer hat keine {itemsPlural} als Favoriten festgelegt.";
	}

	protected override string _GetTemplateForMessageUserNotFavoritedItems()
	{
		return "Dieser Benutzer hat keine {itemsPlural} als Favoriten festgelegt.";
	}

	protected override string _GetTemplateForMessageYouHaveNoFavoritesCategory()
	{
		return "Du hast keine Favoriten in dieser Kategorie.";
	}

	/// <summary>
	/// Key: "Message.YouHaveNoItems"
	/// For example, You have no shoulder accessories.
	/// English String: "You have no {itemsPlural}."
	/// </summary>
	public override string MessageYouHaveNoItems(string itemsPlural)
	{
		return $"Du hast keine {itemsPlural}.";
	}

	protected override string _GetTemplateForMessageYouHaveNoItems()
	{
		return "Du hast keine {itemsPlural}.";
	}

	protected override string _GetTemplateForMessageYouHaveNoItemsCategory()
	{
		return "Du hast keine Artikel aus dieser Kategorie.";
	}

	/// <summary>
	/// Key: "Message.YouNotFavoritedItems"
	/// For example, You have not favorited any shoulder accessories. Favoriting is the verb for a user to add an item or asset to their favorites list.
	/// English String: "You have not favorited any {itemsPlural}."
	/// </summary>
	public override string MessageYouNotFavoritedItems(string itemsPlural)
	{
		return $"Du hast keine {itemsPlural} als Favoriten festgelegt.";
	}

	protected override string _GetTemplateForMessageYouNotFavoritedItems()
	{
		return "Du hast keine {itemsPlural} als Favoriten festgelegt.";
	}
}
