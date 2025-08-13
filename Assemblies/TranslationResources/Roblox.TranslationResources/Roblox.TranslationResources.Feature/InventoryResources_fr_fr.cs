namespace Roblox.TranslationResources.Feature;

/// <summary>
/// This class overrides InventoryResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class InventoryResources_fr_fr : InventoryResources_en_us, IInventoryResources, ITranslationResources
{
	/// <summary>
	/// Key: "Action.GetMore"
	/// Call to action button for the user to get more items or assets
	/// English String: "Get More"
	/// </summary>
	public override string ActionGetMore => "Obtenir plus";

	/// <summary>
	/// Key: "Heading.Category"
	/// These categories include different item and asset types such as Accessories, Meshes, Badges, Audio assets, and Pants
	/// English String: "Category"
	/// </summary>
	public override string HeadingCategory => "Catégorie";

	/// <summary>
	/// Key: "Heading.Inventory"
	/// This is the button that users will click on the navigation menu to go to the Inventory page, which contains items and assets that the user has to improve their appearance or use to develop games.
	/// English String: "Inventory"
	/// </summary>
	public override string HeadingInventory => "Inventaire";

	/// <summary>
	/// Key: "Heading.MyInventory"
	/// This is the page title referring to your own inventory. This page contains the user's items and assets.
	/// English String: "My Inventory"
	/// </summary>
	public override string HeadingMyInventory => "Mon inventaire";

	/// <summary>
	/// Key: "Heading.Subcategory"
	/// These subcategories include different sub-types of asset types. The subcategories under Accessories could be Hats, Hair, and Face.
	/// English String: "Subcategory"
	/// </summary>
	public override string HeadingSubcategory => "Sous-catégorie";

	/// <summary>
	/// Key: "Label.BodyParts"
	/// English String: "Body Parts"
	/// </summary>
	public override string LabelBodyParts => "Parties du corps";

	/// <summary>
	/// Key: "Label.Bundles"
	/// English String: "Bundles"
	/// </summary>
	public override string LabelBundles => "Ensembles";

	/// <summary>
	/// Key: "Label.CreatedByMe"
	/// English String: "Created by Me"
	/// </summary>
	public override string LabelCreatedByMe => "Mes créations";

	/// <summary>
	/// Key: "Label.MyGames"
	/// English String: "My Games"
	/// </summary>
	public override string LabelMyGames => "Mes jeux";

	/// <summary>
	/// Key: "Label.MyVipServers"
	/// English String: "My VIP Servers"
	/// </summary>
	public override string LabelMyVipServers => "Mes serveurs\u00a0VIP";

	/// <summary>
	/// Key: "Label.Offsale"
	/// An item with this label is no longer on sale and cannot be obtained.
	/// English String: "Offsale"
	/// </summary>
	public override string LabelOffsale => "Plus à vendre";

	/// <summary>
	/// Key: "Label.OtherGames"
	/// English String: "Other Games"
	/// </summary>
	public override string LabelOtherGames => "Autres jeux";

	/// <summary>
	/// Key: "Label.OtherVipServers"
	/// English String: "Other VIP Servers"
	/// </summary>
	public override string LabelOtherVipServers => "Autres serveurs\u00a0VIP";

	/// <summary>
	/// Key: "Label.OwnershipPreposition"
	/// This word is used to show that an item was created "By" someone or some entity.
	/// English String: "By"
	/// </summary>
	public override string LabelOwnershipPreposition => "Par";

	/// <summary>
	/// Key: "Label.Places"
	/// English String: "Places"
	/// </summary>
	public override string LabelPlaces => "Emplacements";

	/// <summary>
	/// Key: "Label.Purchased"
	/// English String: "Purchased"
	/// </summary>
	public override string LabelPurchased => "Achetés";

	/// <summary>
	/// Key: "Label.VipServers"
	/// English String: "VIP Servers"
	/// </summary>
	public override string LabelVipServers => "Serveurs\u00a0VIP";

	/// <summary>
	/// Key: "Message.TryCatalogForItems"
	/// English String: "Try using the catalog to find new items."
	/// </summary>
	public override string MessageTryCatalogForItems => "Essayez de rechercher d'autres objets dans le catalogue.";

	/// <summary>
	/// Key: "Message.TryLibraryForItems"
	/// English String: "Try using the library to find new items."
	/// </summary>
	public override string MessageTryLibraryForItems => "Essayez de rechercher d'autres objets dans la bibliothèque.";

	/// <summary>
	/// Key: "Message.UserHasNoFavoritesCategory"
	/// English String: "This user has not favorited items in this category."
	/// </summary>
	public override string MessageUserHasNoFavoritesCategory => "Cet utilisateur n'a aucun favori dans cette catégorie.";

	/// <summary>
	/// Key: "Message.UserHasNoItemsCategory"
	/// English String: "This user doesn't have items in this category."
	/// </summary>
	public override string MessageUserHasNoItemsCategory => "Cet utilisateur n'a aucun objet dans cette catégorie.";

	/// <summary>
	/// Key: "Message.UserInventoryHidden"
	/// English String: "You cannot see this player's inventory."
	/// </summary>
	public override string MessageUserInventoryHidden => "Vous ne pouvez pas voir l’inventaire de ce joueur.";

	/// <summary>
	/// Key: "Message.YouHaveNoFavoritesCategory"
	/// English String: "You have not favorited items in this category."
	/// </summary>
	public override string MessageYouHaveNoFavoritesCategory => "Vous n'avez aucun favori dans cette catégorie.";

	/// <summary>
	/// Key: "Message.YouHaveNoItemsCategory"
	/// English String: "You don't have items in this category."
	/// </summary>
	public override string MessageYouHaveNoItemsCategory => "Vous n'avez aucun objet dans cette catégorie.";

	public InventoryResources_fr_fr(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionGetMore()
	{
		return "Obtenir plus";
	}

	protected override string _GetTemplateForHeadingCategory()
	{
		return "Catégorie";
	}

	protected override string _GetTemplateForHeadingInventory()
	{
		return "Inventaire";
	}

	protected override string _GetTemplateForHeadingMyInventory()
	{
		return "Mon inventaire";
	}

	protected override string _GetTemplateForHeadingSubcategory()
	{
		return "Sous-catégorie";
	}

	/// <summary>
	/// Key: "Heading.UserInventory"
	/// This is the page title referring to another user's inventory. This page contains another user's items and assets.
	/// English String: "{username}'s Inventory"
	/// </summary>
	public override string HeadingUserInventory(string username)
	{
		return $"Inventaire de {username}";
	}

	protected override string _GetTemplateForHeadingUserInventory()
	{
		return "Inventaire de {username}";
	}

	protected override string _GetTemplateForLabelBodyParts()
	{
		return "Parties du corps";
	}

	protected override string _GetTemplateForLabelBundles()
	{
		return "Ensembles";
	}

	protected override string _GetTemplateForLabelCreatedByMe()
	{
		return "Mes créations";
	}

	protected override string _GetTemplateForLabelMyGames()
	{
		return "Mes jeux";
	}

	protected override string _GetTemplateForLabelMyVipServers()
	{
		return "Mes serveurs\u00a0VIP";
	}

	protected override string _GetTemplateForLabelOffsale()
	{
		return "Plus à vendre";
	}

	protected override string _GetTemplateForLabelOtherGames()
	{
		return "Autres jeux";
	}

	protected override string _GetTemplateForLabelOtherVipServers()
	{
		return "Autres serveurs\u00a0VIP";
	}

	protected override string _GetTemplateForLabelOwnershipPreposition()
	{
		return "Par";
	}

	protected override string _GetTemplateForLabelPlaces()
	{
		return "Emplacements";
	}

	protected override string _GetTemplateForLabelPurchased()
	{
		return "Achetés";
	}

	/// <summary>
	/// Key: "Label.RentalExpireTime"
	/// An abbreviated label for expiration of an item. Once the expire time is surpassed, the item will no longer be available to the user.
	/// English String: "Exp: {expireTime}"
	/// </summary>
	public override string LabelRentalExpireTime(string expireTime)
	{
		return $"Exp.\u00a0: {expireTime}";
	}

	protected override string _GetTemplateForLabelRentalExpireTime()
	{
		return "Exp.\u00a0: {expireTime}";
	}

	protected override string _GetTemplateForLabelVipServers()
	{
		return "Serveurs\u00a0VIP";
	}

	/// <summary>
	/// Key: "Message.ExploreCatalogForItems"
	/// For example, Explore the catalog to find more Animations! The catalog is a page where the user can find many items that can improve the user's appearance.
	/// English String: "Explore the catalog to find more {itemsPlural}!"
	/// </summary>
	public override string MessageExploreCatalogForItems(string itemsPlural)
	{
		return $"Trouvez d'autres {itemsPlural} dans le catalogue\u00a0!";
	}

	protected override string _GetTemplateForMessageExploreCatalogForItems()
	{
		return "Trouvez d'autres {itemsPlural} dans le catalogue\u00a0!";
	}

	/// <summary>
	/// Key: "Message.ExploreLibraryForItems"
	/// For example, Explore the library to find more Animations! The library is a page where the user can find many assets and items that other users have created.
	/// English String: "Explore the library to find more {itemsPlural}!"
	/// </summary>
	public override string MessageExploreLibraryForItems(string itemsPlural)
	{
		return $"Trouvez d'autres {itemsPlural} dans la bibliothèque\u00a0!";
	}

	protected override string _GetTemplateForMessageExploreLibraryForItems()
	{
		return "Trouvez d'autres {itemsPlural} dans la bibliothèque\u00a0!";
	}

	protected override string _GetTemplateForMessageTryCatalogForItems()
	{
		return "Essayez de rechercher d'autres objets dans le catalogue.";
	}

	/// <summary>
	/// Key: "Message.TryCatalogLink"
	/// The catalog text will link to the Catalog page to find more items.
	/// English String: "Try using the {startLink}catalog{endLink} to find new items."
	/// </summary>
	public override string MessageTryCatalogLink(string startLink, string endLink)
	{
		return $"Essayez de rechercher d'autres objets dans le {startLink}catalogue{endLink}.";
	}

	protected override string _GetTemplateForMessageTryCatalogLink()
	{
		return "Essayez de rechercher d'autres objets dans le {startLink}catalogue{endLink}.";
	}

	protected override string _GetTemplateForMessageTryLibraryForItems()
	{
		return "Essayez de rechercher d'autres objets dans la bibliothèque.";
	}

	/// <summary>
	/// Key: "Message.TryLibraryLink"
	/// The library text will link to the Library page to find more items.
	/// English String: "Try using the {startLink}library{endLink} to find new items."
	/// </summary>
	public override string MessageTryLibraryLink(string startLink, string endLink)
	{
		return $"Essayez de rechercher d'autres objets dans la {startLink}bibliothèque{endLink}.";
	}

	protected override string _GetTemplateForMessageTryLibraryLink()
	{
		return "Essayez de rechercher d'autres objets dans la {startLink}bibliothèque{endLink}.";
	}

	protected override string _GetTemplateForMessageUserHasNoFavoritesCategory()
	{
		return "Cet utilisateur n'a aucun favori dans cette catégorie.";
	}

	/// <summary>
	/// Key: "Message.UserHasNoItems"
	/// For example, This user has no shoulder accessories.
	/// English String: "This user has no {itemsPlural}."
	/// </summary>
	public override string MessageUserHasNoItems(string itemsPlural)
	{
		return $"Cet utilisateur n'a pas\u00a0: {itemsPlural}.";
	}

	protected override string _GetTemplateForMessageUserHasNoItems()
	{
		return "Cet utilisateur n'a pas\u00a0: {itemsPlural}.";
	}

	protected override string _GetTemplateForMessageUserHasNoItemsCategory()
	{
		return "Cet utilisateur n'a aucun objet dans cette catégorie.";
	}

	protected override string _GetTemplateForMessageUserInventoryHidden()
	{
		return "Vous ne pouvez pas voir l’inventaire de ce joueur.";
	}

	/// <summary>
	/// Key: "Message.UserNotFavoritedItems"
	/// For example, This user has not favorited any shoulder accessories. Favoriting is the verb for a user to add an item or asset to their favorites list.
	/// English String: "This user has not favorited any {itemsPlural}."
	/// </summary>
	public override string MessageUserNotFavoritedItems(string itemsPlural)
	{
		return $"Les favoris de cet utilisateur ne contiennent pas\u00a0: {itemsPlural}.";
	}

	protected override string _GetTemplateForMessageUserNotFavoritedItems()
	{
		return "Les favoris de cet utilisateur ne contiennent pas\u00a0: {itemsPlural}.";
	}

	protected override string _GetTemplateForMessageYouHaveNoFavoritesCategory()
	{
		return "Vous n'avez aucun favori dans cette catégorie.";
	}

	/// <summary>
	/// Key: "Message.YouHaveNoItems"
	/// For example, You have no shoulder accessories.
	/// English String: "You have no {itemsPlural}."
	/// </summary>
	public override string MessageYouHaveNoItems(string itemsPlural)
	{
		return $"Vous n'avez pas\u00a0: {itemsPlural}.";
	}

	protected override string _GetTemplateForMessageYouHaveNoItems()
	{
		return "Vous n'avez pas\u00a0: {itemsPlural}.";
	}

	protected override string _GetTemplateForMessageYouHaveNoItemsCategory()
	{
		return "Vous n'avez aucun objet dans cette catégorie.";
	}

	/// <summary>
	/// Key: "Message.YouNotFavoritedItems"
	/// For example, You have not favorited any shoulder accessories. Favoriting is the verb for a user to add an item or asset to their favorites list.
	/// English String: "You have not favorited any {itemsPlural}."
	/// </summary>
	public override string MessageYouNotFavoritedItems(string itemsPlural)
	{
		return $"Vos favoris ne contiennent pas\u00a0: {itemsPlural}.";
	}

	protected override string _GetTemplateForMessageYouNotFavoritedItems()
	{
		return "Vos favoris ne contiennent pas\u00a0: {itemsPlural}.";
	}
}
