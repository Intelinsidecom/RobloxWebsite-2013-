namespace Roblox.TranslationResources.Feature;

/// <summary>
/// This class overrides InventoryResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class InventoryResources_es_es : InventoryResources_en_us, IInventoryResources, ITranslationResources
{
	/// <summary>
	/// Key: "Action.GetMore"
	/// Call to action button for the user to get more items or assets
	/// English String: "Get More"
	/// </summary>
	public override string ActionGetMore => "Obtener más";

	/// <summary>
	/// Key: "Heading.Category"
	/// These categories include different item and asset types such as Accessories, Meshes, Badges, Audio assets, and Pants
	/// English String: "Category"
	/// </summary>
	public override string HeadingCategory => "Categoría";

	/// <summary>
	/// Key: "Heading.Inventory"
	/// This is the button that users will click on the navigation menu to go to the Inventory page, which contains items and assets that the user has to improve their appearance or use to develop games.
	/// English String: "Inventory"
	/// </summary>
	public override string HeadingInventory => "Inventario";

	/// <summary>
	/// Key: "Heading.MyInventory"
	/// This is the page title referring to your own inventory. This page contains the user's items and assets.
	/// English String: "My Inventory"
	/// </summary>
	public override string HeadingMyInventory => "Mi inventario";

	/// <summary>
	/// Key: "Heading.Subcategory"
	/// These subcategories include different sub-types of asset types. The subcategories under Accessories could be Hats, Hair, and Face.
	/// English String: "Subcategory"
	/// </summary>
	public override string HeadingSubcategory => "Subcategoría";

	/// <summary>
	/// Key: "Label.BodyParts"
	/// English String: "Body Parts"
	/// </summary>
	public override string LabelBodyParts => "Partes del cuerpo";

	/// <summary>
	/// Key: "Label.Bundles"
	/// English String: "Bundles"
	/// </summary>
	public override string LabelBundles => "Paquetes";

	/// <summary>
	/// Key: "Label.CreatedByMe"
	/// English String: "Created by Me"
	/// </summary>
	public override string LabelCreatedByMe => "Creados por mí";

	/// <summary>
	/// Key: "Label.MyGames"
	/// English String: "My Games"
	/// </summary>
	public override string LabelMyGames => "Mis juegos";

	/// <summary>
	/// Key: "Label.MyVipServers"
	/// English String: "My VIP Servers"
	/// </summary>
	public override string LabelMyVipServers => "Mis servidores VIP";

	/// <summary>
	/// Key: "Label.Offsale"
	/// An item with this label is no longer on sale and cannot be obtained.
	/// English String: "Offsale"
	/// </summary>
	public override string LabelOffsale => "Fuera de oferta";

	/// <summary>
	/// Key: "Label.OtherGames"
	/// English String: "Other Games"
	/// </summary>
	public override string LabelOtherGames => "Otros juegos";

	/// <summary>
	/// Key: "Label.OtherVipServers"
	/// English String: "Other VIP Servers"
	/// </summary>
	public override string LabelOtherVipServers => "Otros servidores VIP";

	/// <summary>
	/// Key: "Label.OwnershipPreposition"
	/// This word is used to show that an item was created "By" someone or some entity.
	/// English String: "By"
	/// </summary>
	public override string LabelOwnershipPreposition => "De";

	/// <summary>
	/// Key: "Label.Places"
	/// English String: "Places"
	/// </summary>
	public override string LabelPlaces => "Lugares";

	/// <summary>
	/// Key: "Label.Purchased"
	/// English String: "Purchased"
	/// </summary>
	public override string LabelPurchased => "Comprados";

	/// <summary>
	/// Key: "Label.VipServers"
	/// English String: "VIP Servers"
	/// </summary>
	public override string LabelVipServers => "Servidores VIP";

	/// <summary>
	/// Key: "Message.TryCatalogForItems"
	/// English String: "Try using the catalog to find new items."
	/// </summary>
	public override string MessageTryCatalogForItems => "Prueba a utilizar el catálogo para encontrar nuevos objetos.";

	/// <summary>
	/// Key: "Message.TryLibraryForItems"
	/// English String: "Try using the library to find new items."
	/// </summary>
	public override string MessageTryLibraryForItems => "Prueba a utilizar la biblioteca para encontrar nuevos objetos.";

	/// <summary>
	/// Key: "Message.UserHasNoFavoritesCategory"
	/// English String: "This user has not favorited items in this category."
	/// </summary>
	public override string MessageUserHasNoFavoritesCategory => "Este usuario no ha añadido a sus favoritos ningún objeto de esta categoría.";

	/// <summary>
	/// Key: "Message.UserHasNoItemsCategory"
	/// English String: "This user doesn't have items in this category."
	/// </summary>
	public override string MessageUserHasNoItemsCategory => "Este usuario no tiene objetos en esta categoría.";

	/// <summary>
	/// Key: "Message.UserInventoryHidden"
	/// English String: "You cannot see this player's inventory."
	/// </summary>
	public override string MessageUserInventoryHidden => "No puedes ver el inventario de este jugador.";

	/// <summary>
	/// Key: "Message.YouHaveNoFavoritesCategory"
	/// English String: "You have not favorited items in this category."
	/// </summary>
	public override string MessageYouHaveNoFavoritesCategory => "No has añadido a tus favoritos ningún objeto de esta categoría.";

	/// <summary>
	/// Key: "Message.YouHaveNoItemsCategory"
	/// English String: "You don't have items in this category."
	/// </summary>
	public override string MessageYouHaveNoItemsCategory => "No tienes objetos en esta categoría.";

	public InventoryResources_es_es(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionGetMore()
	{
		return "Obtener más";
	}

	protected override string _GetTemplateForHeadingCategory()
	{
		return "Categoría";
	}

	protected override string _GetTemplateForHeadingInventory()
	{
		return "Inventario";
	}

	protected override string _GetTemplateForHeadingMyInventory()
	{
		return "Mi inventario";
	}

	protected override string _GetTemplateForHeadingSubcategory()
	{
		return "Subcategoría";
	}

	/// <summary>
	/// Key: "Heading.UserInventory"
	/// This is the page title referring to another user's inventory. This page contains another user's items and assets.
	/// English String: "{username}'s Inventory"
	/// </summary>
	public override string HeadingUserInventory(string username)
	{
		return $"Inventario de {username}";
	}

	protected override string _GetTemplateForHeadingUserInventory()
	{
		return "Inventario de {username}";
	}

	protected override string _GetTemplateForLabelBodyParts()
	{
		return "Partes del cuerpo";
	}

	protected override string _GetTemplateForLabelBundles()
	{
		return "Paquetes";
	}

	protected override string _GetTemplateForLabelCreatedByMe()
	{
		return "Creados por mí";
	}

	protected override string _GetTemplateForLabelMyGames()
	{
		return "Mis juegos";
	}

	protected override string _GetTemplateForLabelMyVipServers()
	{
		return "Mis servidores VIP";
	}

	protected override string _GetTemplateForLabelOffsale()
	{
		return "Fuera de oferta";
	}

	protected override string _GetTemplateForLabelOtherGames()
	{
		return "Otros juegos";
	}

	protected override string _GetTemplateForLabelOtherVipServers()
	{
		return "Otros servidores VIP";
	}

	protected override string _GetTemplateForLabelOwnershipPreposition()
	{
		return "De";
	}

	protected override string _GetTemplateForLabelPlaces()
	{
		return "Lugares";
	}

	protected override string _GetTemplateForLabelPurchased()
	{
		return "Comprados";
	}

	/// <summary>
	/// Key: "Label.RentalExpireTime"
	/// An abbreviated label for expiration of an item. Once the expire time is surpassed, the item will no longer be available to the user.
	/// English String: "Exp: {expireTime}"
	/// </summary>
	public override string LabelRentalExpireTime(string expireTime)
	{
		return $"Caduca: {expireTime}";
	}

	protected override string _GetTemplateForLabelRentalExpireTime()
	{
		return "Caduca: {expireTime}";
	}

	protected override string _GetTemplateForLabelVipServers()
	{
		return "Servidores VIP";
	}

	/// <summary>
	/// Key: "Message.ExploreCatalogForItems"
	/// For example, Explore the catalog to find more Animations! The catalog is a page where the user can find many items that can improve the user's appearance.
	/// English String: "Explore the catalog to find more {itemsPlural}!"
	/// </summary>
	public override string MessageExploreCatalogForItems(string itemsPlural)
	{
		return $"¡Explora el catálogo para encontrar más {itemsPlural}!";
	}

	protected override string _GetTemplateForMessageExploreCatalogForItems()
	{
		return "¡Explora el catálogo para encontrar más {itemsPlural}!";
	}

	/// <summary>
	/// Key: "Message.ExploreLibraryForItems"
	/// For example, Explore the library to find more Animations! The library is a page where the user can find many assets and items that other users have created.
	/// English String: "Explore the library to find more {itemsPlural}!"
	/// </summary>
	public override string MessageExploreLibraryForItems(string itemsPlural)
	{
		return $"¡Explora la biblioteca para encontrar más {itemsPlural}!";
	}

	protected override string _GetTemplateForMessageExploreLibraryForItems()
	{
		return "¡Explora la biblioteca para encontrar más {itemsPlural}!";
	}

	protected override string _GetTemplateForMessageTryCatalogForItems()
	{
		return "Prueba a utilizar el catálogo para encontrar nuevos objetos.";
	}

	/// <summary>
	/// Key: "Message.TryCatalogLink"
	/// The catalog text will link to the Catalog page to find more items.
	/// English String: "Try using the {startLink}catalog{endLink} to find new items."
	/// </summary>
	public override string MessageTryCatalogLink(string startLink, string endLink)
	{
		return $"Prueba a utilizar el {startLink}Catálogo{endLink} para encontrar nuevos objetos.";
	}

	protected override string _GetTemplateForMessageTryCatalogLink()
	{
		return "Prueba a utilizar el {startLink}Catálogo{endLink} para encontrar nuevos objetos.";
	}

	protected override string _GetTemplateForMessageTryLibraryForItems()
	{
		return "Prueba a utilizar la biblioteca para encontrar nuevos objetos.";
	}

	/// <summary>
	/// Key: "Message.TryLibraryLink"
	/// The library text will link to the Library page to find more items.
	/// English String: "Try using the {startLink}library{endLink} to find new items."
	/// </summary>
	public override string MessageTryLibraryLink(string startLink, string endLink)
	{
		return $"Prueba a utilizar la {startLink}Biblioteca{endLink} para encontrar nuevos objetos.";
	}

	protected override string _GetTemplateForMessageTryLibraryLink()
	{
		return "Prueba a utilizar la {startLink}Biblioteca{endLink} para encontrar nuevos objetos.";
	}

	protected override string _GetTemplateForMessageUserHasNoFavoritesCategory()
	{
		return "Este usuario no ha añadido a sus favoritos ningún objeto de esta categoría.";
	}

	/// <summary>
	/// Key: "Message.UserHasNoItems"
	/// For example, This user has no shoulder accessories.
	/// English String: "This user has no {itemsPlural}."
	/// </summary>
	public override string MessageUserHasNoItems(string itemsPlural)
	{
		return $"Este usuario no tiene {itemsPlural}.";
	}

	protected override string _GetTemplateForMessageUserHasNoItems()
	{
		return "Este usuario no tiene {itemsPlural}.";
	}

	protected override string _GetTemplateForMessageUserHasNoItemsCategory()
	{
		return "Este usuario no tiene objetos en esta categoría.";
	}

	protected override string _GetTemplateForMessageUserInventoryHidden()
	{
		return "No puedes ver el inventario de este jugador.";
	}

	/// <summary>
	/// Key: "Message.UserNotFavoritedItems"
	/// For example, This user has not favorited any shoulder accessories. Favoriting is the verb for a user to add an item or asset to their favorites list.
	/// English String: "This user has not favorited any {itemsPlural}."
	/// </summary>
	public override string MessageUserNotFavoritedItems(string itemsPlural)
	{
		return $"Este usuario no ha añadido {itemsPlural} a sus favoritos.";
	}

	protected override string _GetTemplateForMessageUserNotFavoritedItems()
	{
		return "Este usuario no ha añadido {itemsPlural} a sus favoritos.";
	}

	protected override string _GetTemplateForMessageYouHaveNoFavoritesCategory()
	{
		return "No has añadido a tus favoritos ningún objeto de esta categoría.";
	}

	/// <summary>
	/// Key: "Message.YouHaveNoItems"
	/// For example, You have no shoulder accessories.
	/// English String: "You have no {itemsPlural}."
	/// </summary>
	public override string MessageYouHaveNoItems(string itemsPlural)
	{
		return $"No tienes {itemsPlural}.";
	}

	protected override string _GetTemplateForMessageYouHaveNoItems()
	{
		return "No tienes {itemsPlural}.";
	}

	protected override string _GetTemplateForMessageYouHaveNoItemsCategory()
	{
		return "No tienes objetos en esta categoría.";
	}

	/// <summary>
	/// Key: "Message.YouNotFavoritedItems"
	/// For example, You have not favorited any shoulder accessories. Favoriting is the verb for a user to add an item or asset to their favorites list.
	/// English String: "You have not favorited any {itemsPlural}."
	/// </summary>
	public override string MessageYouNotFavoritedItems(string itemsPlural)
	{
		return $"No has añadido {itemsPlural} a tus favoritos.";
	}

	protected override string _GetTemplateForMessageYouNotFavoritedItems()
	{
		return "No has añadido {itemsPlural} a tus favoritos.";
	}
}
