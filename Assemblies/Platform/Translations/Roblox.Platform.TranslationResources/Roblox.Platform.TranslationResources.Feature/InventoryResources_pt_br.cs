namespace Roblox.TranslationResources.Feature;

/// <summary>
/// This class overrides InventoryResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class InventoryResources_pt_br : InventoryResources_en_us, IInventoryResources, ITranslationResources
{
	/// <summary>
	/// Key: "Action.GetMore"
	/// Call to action button for the user to get more items or assets
	/// English String: "Get More"
	/// </summary>
	public override string ActionGetMore => "Obter mais";

	/// <summary>
	/// Key: "Heading.Category"
	/// These categories include different item and asset types such as Accessories, Meshes, Badges, Audio assets, and Pants
	/// English String: "Category"
	/// </summary>
	public override string HeadingCategory => "Categoria";

	/// <summary>
	/// Key: "Heading.Inventory"
	/// This is the button that users will click on the navigation menu to go to the Inventory page, which contains items and assets that the user has to improve their appearance or use to develop games.
	/// English String: "Inventory"
	/// </summary>
	public override string HeadingInventory => "Inventário";

	/// <summary>
	/// Key: "Heading.MyInventory"
	/// This is the page title referring to your own inventory. This page contains the user's items and assets.
	/// English String: "My Inventory"
	/// </summary>
	public override string HeadingMyInventory => "Meu inventário";

	/// <summary>
	/// Key: "Heading.Subcategory"
	/// These subcategories include different sub-types of asset types. The subcategories under Accessories could be Hats, Hair, and Face.
	/// English String: "Subcategory"
	/// </summary>
	public override string HeadingSubcategory => "Subcategoria";

	/// <summary>
	/// Key: "Label.BodyParts"
	/// English String: "Body Parts"
	/// </summary>
	public override string LabelBodyParts => "Partes do corpo";

	/// <summary>
	/// Key: "Label.Bundles"
	/// English String: "Bundles"
	/// </summary>
	public override string LabelBundles => "Pacotes";

	/// <summary>
	/// Key: "Label.CreatedByMe"
	/// English String: "Created by Me"
	/// </summary>
	public override string LabelCreatedByMe => "Criado por mim";

	/// <summary>
	/// Key: "Label.MyGames"
	/// English String: "My Games"
	/// </summary>
	public override string LabelMyGames => "Meus jogos";

	/// <summary>
	/// Key: "Label.MyVipServers"
	/// English String: "My VIP Servers"
	/// </summary>
	public override string LabelMyVipServers => "Meus servidores VIP";

	/// <summary>
	/// Key: "Label.Offsale"
	/// An item with this label is no longer on sale and cannot be obtained.
	/// English String: "Offsale"
	/// </summary>
	public override string LabelOffsale => "Indisponível";

	/// <summary>
	/// Key: "Label.OtherGames"
	/// English String: "Other Games"
	/// </summary>
	public override string LabelOtherGames => "Outros jogos";

	/// <summary>
	/// Key: "Label.OtherVipServers"
	/// English String: "Other VIP Servers"
	/// </summary>
	public override string LabelOtherVipServers => "Outros servidores VIP";

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
	public override string LabelPlaces => "Locais";

	/// <summary>
	/// Key: "Label.Purchased"
	/// English String: "Purchased"
	/// </summary>
	public override string LabelPurchased => "Comprado";

	/// <summary>
	/// Key: "Label.VipServers"
	/// English String: "VIP Servers"
	/// </summary>
	public override string LabelVipServers => "Servidores VIP";

	/// <summary>
	/// Key: "Message.TryCatalogForItems"
	/// English String: "Try using the catalog to find new items."
	/// </summary>
	public override string MessageTryCatalogForItems => "Experimente usar o catálogo para encontrar novos itens.";

	/// <summary>
	/// Key: "Message.TryLibraryForItems"
	/// English String: "Try using the library to find new items."
	/// </summary>
	public override string MessageTryLibraryForItems => "Experimente usar a biblioteca para encontrar novos itens.";

	/// <summary>
	/// Key: "Message.UserHasNoFavoritesCategory"
	/// English String: "This user has not favorited items in this category."
	/// </summary>
	public override string MessageUserHasNoFavoritesCategory => "Este usuário não adicionou itens desta categoria aos favoritos.";

	/// <summary>
	/// Key: "Message.UserHasNoItemsCategory"
	/// English String: "This user doesn't have items in this category."
	/// </summary>
	public override string MessageUserHasNoItemsCategory => "Este usuário não possui itens nesta categoria.";

	/// <summary>
	/// Key: "Message.UserInventoryHidden"
	/// English String: "You cannot see this player's inventory."
	/// </summary>
	public override string MessageUserInventoryHidden => "Você não pode visualizar o inventário desse jogador.";

	/// <summary>
	/// Key: "Message.YouHaveNoFavoritesCategory"
	/// English String: "You have not favorited items in this category."
	/// </summary>
	public override string MessageYouHaveNoFavoritesCategory => "Você não adicionou itens desta categoria aos seus favoritos.";

	/// <summary>
	/// Key: "Message.YouHaveNoItemsCategory"
	/// English String: "You don't have items in this category."
	/// </summary>
	public override string MessageYouHaveNoItemsCategory => "Você não possui itens nesta categoria.";

	public InventoryResources_pt_br(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionGetMore()
	{
		return "Obter mais";
	}

	protected override string _GetTemplateForHeadingCategory()
	{
		return "Categoria";
	}

	protected override string _GetTemplateForHeadingInventory()
	{
		return "Inventário";
	}

	protected override string _GetTemplateForHeadingMyInventory()
	{
		return "Meu inventário";
	}

	protected override string _GetTemplateForHeadingSubcategory()
	{
		return "Subcategoria";
	}

	/// <summary>
	/// Key: "Heading.UserInventory"
	/// This is the page title referring to another user's inventory. This page contains another user's items and assets.
	/// English String: "{username}'s Inventory"
	/// </summary>
	public override string HeadingUserInventory(string username)
	{
		return $"Inventário de {username}";
	}

	protected override string _GetTemplateForHeadingUserInventory()
	{
		return "Inventário de {username}";
	}

	protected override string _GetTemplateForLabelBodyParts()
	{
		return "Partes do corpo";
	}

	protected override string _GetTemplateForLabelBundles()
	{
		return "Pacotes";
	}

	protected override string _GetTemplateForLabelCreatedByMe()
	{
		return "Criado por mim";
	}

	protected override string _GetTemplateForLabelMyGames()
	{
		return "Meus jogos";
	}

	protected override string _GetTemplateForLabelMyVipServers()
	{
		return "Meus servidores VIP";
	}

	protected override string _GetTemplateForLabelOffsale()
	{
		return "Indisponível";
	}

	protected override string _GetTemplateForLabelOtherGames()
	{
		return "Outros jogos";
	}

	protected override string _GetTemplateForLabelOtherVipServers()
	{
		return "Outros servidores VIP";
	}

	protected override string _GetTemplateForLabelOwnershipPreposition()
	{
		return "De";
	}

	protected override string _GetTemplateForLabelPlaces()
	{
		return "Locais";
	}

	protected override string _GetTemplateForLabelPurchased()
	{
		return "Comprado";
	}

	/// <summary>
	/// Key: "Label.RentalExpireTime"
	/// An abbreviated label for expiration of an item. Once the expire time is surpassed, the item will no longer be available to the user.
	/// English String: "Exp: {expireTime}"
	/// </summary>
	public override string LabelRentalExpireTime(string expireTime)
	{
		return $"Exp: {expireTime}";
	}

	protected override string _GetTemplateForLabelRentalExpireTime()
	{
		return "Exp: {expireTime}";
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
		return $"Explore o catálogo para encontrar mais {itemsPlural}!";
	}

	protected override string _GetTemplateForMessageExploreCatalogForItems()
	{
		return "Explore o catálogo para encontrar mais {itemsPlural}!";
	}

	/// <summary>
	/// Key: "Message.ExploreLibraryForItems"
	/// For example, Explore the library to find more Animations! The library is a page where the user can find many assets and items that other users have created.
	/// English String: "Explore the library to find more {itemsPlural}!"
	/// </summary>
	public override string MessageExploreLibraryForItems(string itemsPlural)
	{
		return $"Explore a biblioteca para encontrar mais {itemsPlural}!";
	}

	protected override string _GetTemplateForMessageExploreLibraryForItems()
	{
		return "Explore a biblioteca para encontrar mais {itemsPlural}!";
	}

	protected override string _GetTemplateForMessageTryCatalogForItems()
	{
		return "Experimente usar o catálogo para encontrar novos itens.";
	}

	/// <summary>
	/// Key: "Message.TryCatalogLink"
	/// The catalog text will link to the Catalog page to find more items.
	/// English String: "Try using the {startLink}catalog{endLink} to find new items."
	/// </summary>
	public override string MessageTryCatalogLink(string startLink, string endLink)
	{
		return $"Experimente usar o {startLink}catálogo{endLink} para encontrar novos itens.";
	}

	protected override string _GetTemplateForMessageTryCatalogLink()
	{
		return "Experimente usar o {startLink}catálogo{endLink} para encontrar novos itens.";
	}

	protected override string _GetTemplateForMessageTryLibraryForItems()
	{
		return "Experimente usar a biblioteca para encontrar novos itens.";
	}

	/// <summary>
	/// Key: "Message.TryLibraryLink"
	/// The library text will link to the Library page to find more items.
	/// English String: "Try using the {startLink}library{endLink} to find new items."
	/// </summary>
	public override string MessageTryLibraryLink(string startLink, string endLink)
	{
		return $"Experimente usar a {startLink}biblioteca{endLink} para encontrar novos itens.";
	}

	protected override string _GetTemplateForMessageTryLibraryLink()
	{
		return "Experimente usar a {startLink}biblioteca{endLink} para encontrar novos itens.";
	}

	protected override string _GetTemplateForMessageUserHasNoFavoritesCategory()
	{
		return "Este usuário não adicionou itens desta categoria aos favoritos.";
	}

	/// <summary>
	/// Key: "Message.UserHasNoItems"
	/// For example, This user has no shoulder accessories.
	/// English String: "This user has no {itemsPlural}."
	/// </summary>
	public override string MessageUserHasNoItems(string itemsPlural)
	{
		return $"O usuário não possui {itemsPlural}.";
	}

	protected override string _GetTemplateForMessageUserHasNoItems()
	{
		return "O usuário não possui {itemsPlural}.";
	}

	protected override string _GetTemplateForMessageUserHasNoItemsCategory()
	{
		return "Este usuário não possui itens nesta categoria.";
	}

	protected override string _GetTemplateForMessageUserInventoryHidden()
	{
		return "Você não pode visualizar o inventário desse jogador.";
	}

	/// <summary>
	/// Key: "Message.UserNotFavoritedItems"
	/// For example, This user has not favorited any shoulder accessories. Favoriting is the verb for a user to add an item or asset to their favorites list.
	/// English String: "This user has not favorited any {itemsPlural}."
	/// </summary>
	public override string MessageUserNotFavoritedItems(string itemsPlural)
	{
		return $"O usuário não marcou {itemsPlural} como favoritos.";
	}

	protected override string _GetTemplateForMessageUserNotFavoritedItems()
	{
		return "O usuário não marcou {itemsPlural} como favoritos.";
	}

	protected override string _GetTemplateForMessageYouHaveNoFavoritesCategory()
	{
		return "Você não adicionou itens desta categoria aos seus favoritos.";
	}

	/// <summary>
	/// Key: "Message.YouHaveNoItems"
	/// For example, You have no shoulder accessories.
	/// English String: "You have no {itemsPlural}."
	/// </summary>
	public override string MessageYouHaveNoItems(string itemsPlural)
	{
		return $"Você não possui {itemsPlural}.";
	}

	protected override string _GetTemplateForMessageYouHaveNoItems()
	{
		return "Você não possui {itemsPlural}.";
	}

	protected override string _GetTemplateForMessageYouHaveNoItemsCategory()
	{
		return "Você não possui itens nesta categoria.";
	}

	/// <summary>
	/// Key: "Message.YouNotFavoritedItems"
	/// For example, You have not favorited any shoulder accessories. Favoriting is the verb for a user to add an item or asset to their favorites list.
	/// English String: "You have not favorited any {itemsPlural}."
	/// </summary>
	public override string MessageYouNotFavoritedItems(string itemsPlural)
	{
		return $"Você não marcou {itemsPlural} como favoritos.";
	}

	protected override string _GetTemplateForMessageYouNotFavoritedItems()
	{
		return "Você não marcou {itemsPlural} como favoritos.";
	}
}
