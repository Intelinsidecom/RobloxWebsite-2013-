namespace Roblox.TranslationResources.Feature;

/// <summary>
/// This class overrides CatalogResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class CatalogResources_fr_fr : CatalogResources_en_us, ICatalogResources, ITranslationResources
{
	/// <summary>
	/// Key: "Action.BuyRobux"
	/// English String: "Buy Robux"
	/// </summary>
	public override string ActionBuyRobux => "Acheter des Robux";

	/// <summary>
	/// Key: "Action.Dialog.AddGearOk"
	/// English String: "OK"
	/// </summary>
	public override string ActionDialogAddGearOk => "OK";

	/// <summary>
	/// Key: "Action.Filter.Apply"
	/// English String: "Apply"
	/// </summary>
	public override string ActionFilterApply => "Appliquer";

	/// <summary>
	/// Key: "Action.Filter.Cancel"
	/// English String: "Cancel"
	/// </summary>
	public override string ActionFilterCancel => "Annuler";

	/// <summary>
	/// Key: "Action.Go"
	/// English String: "Go"
	/// </summary>
	public override string ActionGo => "Aller";

	/// <summary>
	/// Key: "Action.ViewAllItems"
	/// English String: "View All Items"
	/// </summary>
	public override string ActionViewAllItems => "Voir tous les objets";

	/// <summary>
	/// Key: "Description.Dialog.AddGearBody"
	/// English String: "To add gear to your game, find an item in the catalog and click the Add to Game button. The item will automatically be allowed in game, and you'll receive a commission on every copy sold from your game page. (You can only add gear that's for sale.)"
	/// </summary>
	public override string DescriptionDialogAddGearBody => "Pour ajouter de l'équipement à ton jeu, sélectionnes un objet du catalogue et cliques sur le bouton Ajouter au jeu. L'objet sera alors autorisé dans le jeu et tu recevras une commission pour chaque exemplaire vendu depuis la page de ton jeu. Seul l'équipement à vendre peut être ajouté.";

	/// <summary>
	/// Key: "Heading.CatalogCategory"
	/// English String: "Category"
	/// </summary>
	public override string HeadingCatalogCategory => "Catégorie";

	/// <summary>
	/// Key: "Heading.CatalogPage"
	/// English String: "Catalog"
	/// </summary>
	public override string HeadingCatalogPage => "Catalogue";

	/// <summary>
	/// Key: "Label.AllFeaturedItems"
	/// English String: "View All Featured Items"
	/// </summary>
	public override string LabelAllFeaturedItems => "Voir tous les objets en vedette";

	/// <summary>
	/// Key: "Label.AllGenres"
	/// English String: "All Genres"
	/// </summary>
	public override string LabelAllGenres => "Tous les genres";

	/// <summary>
	/// Key: "Label.Amazon"
	/// label
	/// English String: "Amazon"
	/// </summary>
	public override string LabelAmazon => "Amazon";

	/// <summary>
	/// Key: "Label.BreadCrumb.Free"
	/// English String: "Free"
	/// </summary>
	public override string LabelBreadCrumbFree => "Gratuit";

	/// <summary>
	/// Key: "Label.BreadCrumb.Group"
	/// English String: "Group:"
	/// </summary>
	public override string LabelBreadCrumbGroup => "Groupe\u00a0:";

	/// <summary>
	/// Key: "Label.Bundle"
	/// Bundle
	/// English String: "Bundle"
	/// </summary>
	public override string LabelBundle => "Paquet";

	/// <summary>
	/// Key: "Label.Bundles"
	/// Bundles
	/// English String: "Bundles"
	/// </summary>
	public override string LabelBundles => "Paquets";

	/// <summary>
	/// Key: "Label.Card.CreatorBy"
	/// English String: "By"
	/// </summary>
	public override string LabelCardCreatorBy => "Par";

	/// <summary>
	/// Key: "Label.Card.PriceWas"
	/// English String: "Was"
	/// </summary>
	public override string LabelCardPriceWas => "Anciennement";

	/// <summary>
	/// Key: "Label.Card.Remaining"
	/// English String: "Remaining:"
	/// </summary>
	public override string LabelCardRemaining => "Reste\u00a0:";

	/// <summary>
	/// Key: "Label.CategoryAttributes"
	/// English String: "Attributes"
	/// </summary>
	public override string LabelCategoryAttributes => "Caractéristiques";

	/// <summary>
	/// Key: "Label.CategoryType"
	/// English String: "Type"
	/// </summary>
	public override string LabelCategoryType => "Type";

	/// <summary>
	/// Key: "Label.CommunityCreations"
	/// UGC items
	/// English String: " Community Creations"
	/// </summary>
	public override string LabelCommunityCreations => " Community Creations";

	/// <summary>
	/// Key: "Label.Dialog.AddGearTitle"
	/// English String: "Add Gear to Your Game"
	/// </summary>
	public override string LabelDialogAddGearTitle => "Ajouter de l'équipement à ton jeu";

	/// <summary>
	/// Key: "Label.Emotes"
	/// Emotes
	/// English String: "Emotes"
	/// </summary>
	public override string LabelEmotes => "Emotes";

	/// <summary>
	/// Key: "Label.Favorites"
	/// English String: "Favorites"
	/// </summary>
	public override string LabelFavorites => "Favoris";

	/// <summary>
	/// Key: "Label.FeaturedBundles"
	/// Featured Bundles
	/// English String: "Featured Bundles"
	/// </summary>
	public override string LabelFeaturedBundles => "Paquets en vedette";

	/// <summary>
	/// Key: "Label.FeaturedEmotes"
	/// Featured Emotes
	/// English String: "Featured Emotes"
	/// </summary>
	public override string LabelFeaturedEmotes => "Emotes en vedette";

	/// <summary>
	/// Key: "Label.Filter.ByTime"
	/// English String: "By Time"
	/// </summary>
	public override string LabelFilterByTime => "Par durée";

	/// <summary>
	/// Key: "Label.Filter.Category"
	/// English String: "Category"
	/// </summary>
	public override string LabelFilterCategory => "Catégorie";

	/// <summary>
	/// Key: "Label.Filter.Creator"
	/// English String: "Creator"
	/// </summary>
	public override string LabelFilterCreator => "Créateur";

	/// <summary>
	/// Key: "Label.Filter.Filter"
	/// English String: "Filter"
	/// </summary>
	public override string LabelFilterFilter => "Filtre";

	/// <summary>
	/// Key: "Label.Filter.Filters"
	/// English String: "Filters"
	/// </summary>
	public override string LabelFilterFilters => "Filtres";

	/// <summary>
	/// Key: "Label.Filter.Genre"
	/// English String: "Genre"
	/// </summary>
	public override string LabelFilterGenre => "Genre";

	/// <summary>
	/// Key: "Label.Filter.Hide"
	/// English String: "Hide"
	/// </summary>
	public override string LabelFilterHide => "Masquer";

	/// <summary>
	/// Key: "Label.Filter.Price"
	/// English String: "Price"
	/// </summary>
	public override string LabelFilterPrice => "Prix";

	/// <summary>
	/// Key: "Label.Filter.PriceMax"
	/// English String: "Max"
	/// </summary>
	public override string LabelFilterPriceMax => "Max";

	/// <summary>
	/// Key: "Label.Filter.PriceMin"
	/// English String: "Min"
	/// </summary>
	public override string LabelFilterPriceMin => "Min";

	/// <summary>
	/// Key: "Label.Filter.PriceTo"
	/// English String: "To"
	/// </summary>
	public override string LabelFilterPriceTo => "À";

	/// <summary>
	/// Key: "Label.Filter.Show"
	/// English String: "Show"
	/// </summary>
	public override string LabelFilterShow => "Afficher";

	/// <summary>
	/// Key: "Label.Filter.Sorting"
	/// English String: "Sorting"
	/// </summary>
	public override string LabelFilterSorting => "Tri";

	/// <summary>
	/// Key: "Label.Filter.UnavailableItems"
	/// English String: "Unavailable Items"
	/// </summary>
	public override string LabelFilterUnavailableItems => "Objets indisponibles";

	/// <summary>
	/// Key: "Label.GoogleOnly"
	/// label
	/// English String: "Google Only"
	/// </summary>
	public override string LabelGoogleOnly => "Google uniquement";

	/// <summary>
	/// Key: "Label.Ios"
	/// label
	/// English String: "IOS"
	/// </summary>
	public override string LabelIos => "iOS";

	/// <summary>
	/// Key: "Label.Mobile"
	/// label
	/// English String: "Mobile"
	/// </summary>
	public override string LabelMobile => "Mobile";

	/// <summary>
	/// Key: "Label.New"
	/// label
	/// English String: "New"
	/// </summary>
	public override string LabelNew => "Nouveau";

	/// <summary>
	/// Key: "Label.Rthro"
	/// Rthro is "Anthro" but we replaced the beginning of the word with an "R" to align with "R6" and "R15"
	/// English String: "Rthro"
	/// </summary>
	public override string LabelRthro => "Rthro";

	/// <summary>
	/// Key: "Label.Sale"
	/// label
	/// English String: "Sale"
	/// </summary>
	public override string LabelSale => "Offre";

	/// <summary>
	/// Key: "Label.SearchField"
	/// English String: "Search"
	/// </summary>
	public override string LabelSearchField => "Rechercher";

	/// <summary>
	/// Key: "Label.SeeAll"
	/// English String: "See All"
	/// </summary>
	public override string LabelSeeAll => "Afficher tout";

	/// <summary>
	/// Key: "Label.Username"
	/// English String: "Username"
	/// </summary>
	public override string LabelUsername => "Nom d'utilisateur";

	/// <summary>
	/// Key: "Label.Xbox"
	/// label
	/// English String: "Xbox"
	/// </summary>
	public override string LabelXbox => "Xbox";

	/// <summary>
	/// Key: "LabelAccessories"
	/// English String: "Accessories"
	/// </summary>
	public override string LabelAccessories => "Accessoires";

	/// <summary>
	/// Key: "LabelAccessoryAll"
	/// English String: "All Accessories"
	/// </summary>
	public override string LabelAccessoryAll => "Tous les accessoires";

	/// <summary>
	/// Key: "LabelAccessoryBack"
	/// English String: "Back"
	/// </summary>
	public override string LabelAccessoryBack => "Dos";

	/// <summary>
	/// Key: "LabelAccessoryFace"
	/// English String: "Face"
	/// </summary>
	public override string LabelAccessoryFace => "Visage";

	/// <summary>
	/// Key: "LabelAccessoryFront"
	/// English String: "Front"
	/// </summary>
	public override string LabelAccessoryFront => "Avant";

	/// <summary>
	/// Key: "LabelAccessoryHair"
	/// English String: "Hair"
	/// </summary>
	public override string LabelAccessoryHair => "Cheveux";

	/// <summary>
	/// Key: "LabelAccessoryHats"
	/// English String: "Hats"
	/// </summary>
	public override string LabelAccessoryHats => "Chapeaux";

	/// <summary>
	/// Key: "LabelAccessoryNeck"
	/// English String: "Neck"
	/// </summary>
	public override string LabelAccessoryNeck => "Cou";

	/// <summary>
	/// Key: "LabelAccessoryShoulder"
	/// English String: "Shoulder"
	/// </summary>
	public override string LabelAccessoryShoulder => "Épaules";

	/// <summary>
	/// Key: "LabelAccessoryWaist"
	/// English String: "Waist"
	/// </summary>
	public override string LabelAccessoryWaist => "Taille";

	/// <summary>
	/// Key: "LabelAll"
	/// English String: "All"
	/// </summary>
	public override string LabelAll => "Tous";

	/// <summary>
	/// Key: "LabelAllBodyParts"
	/// English String: "All Body Parts"
	/// </summary>
	public override string LabelAllBodyParts => "Toutes les parties du corps";

	/// <summary>
	/// Key: "LabelAllCategories"
	/// English String: "All Categories"
	/// </summary>
	public override string LabelAllCategories => "Toutes les catégories";

	/// <summary>
	/// Key: "LabelAllClothing"
	/// English String: "All Clothing"
	/// </summary>
	public override string LabelAllClothing => "Tous les vêtements";

	/// <summary>
	/// Key: "LabelAllCollectibles"
	/// English String: "All Collectibles"
	/// </summary>
	public override string LabelAllCollectibles => "Tous les objets de collection";

	/// <summary>
	/// Key: "LabelAllCreators"
	/// English String: "All Creators"
	/// </summary>
	public override string LabelAllCreators => "Tous les créateurs";

	/// <summary>
	/// Key: "LabelAllCurrency"
	/// English String: "All Currency"
	/// </summary>
	public override string LabelAllCurrency => "Toutes les devises";

	/// <summary>
	/// Key: "LabelAllFeatured"
	/// English String: "All Featured Items"
	/// </summary>
	public override string LabelAllFeatured => "Tous les objets en vedette";

	/// <summary>
	/// Key: "LabelAllTime"
	/// English String: "All Time"
	/// </summary>
	public override string LabelAllTime => "Tous les temps";

	/// <summary>
	/// Key: "LabelAnimations"
	/// English String: "Animations"
	/// </summary>
	public override string LabelAnimations => "Animations";

	/// <summary>
	/// Key: "LabelAnyPrice"
	/// English String: "Any Price"
	/// </summary>
	public override string LabelAnyPrice => "Tous les prix";

	/// <summary>
	/// Key: "LabelAvatarAnimations"
	/// English String: "Avatar Animations"
	/// </summary>
	public override string LabelAvatarAnimations => "Animations d'avatar";

	/// <summary>
	/// Key: "LabelBestselling"
	/// English String: "Bestselling"
	/// </summary>
	public override string LabelBestselling => "Meilleures ventes";

	/// <summary>
	/// Key: "LabelBodyParts"
	/// English String: "Body Parts"
	/// </summary>
	public override string LabelBodyParts => "Parties du corps";

	/// <summary>
	/// Key: "LabelClothing"
	/// English String: "Clothing"
	/// </summary>
	public override string LabelClothing => "Vêtements";

	/// <summary>
	/// Key: "LabelCollectibleAccessories"
	/// English String: "Collectible Accessories"
	/// </summary>
	public override string LabelCollectibleAccessories => "Accessoires de collection";

	/// <summary>
	/// Key: "LabelCollectibleFaces"
	/// English String: "Collectible Faces"
	/// </summary>
	public override string LabelCollectibleFaces => "Visages de collection";

	/// <summary>
	/// Key: "LabelCollectibleGear"
	/// English String: "Collectible Gear"
	/// </summary>
	public override string LabelCollectibleGear => "Équipement de collection";

	/// <summary>
	/// Key: "LabelCollectibles"
	/// English String: "Collectibles"
	/// </summary>
	public override string LabelCollectibles => "Objets de collection";

	/// <summary>
	/// Key: "LabelFaces"
	/// English String: "Faces"
	/// </summary>
	public override string LabelFaces => "Visages";

	/// <summary>
	/// Key: "LabelFeatured"
	/// English String: "Featured"
	/// </summary>
	public override string LabelFeatured => "En vedette";

	/// <summary>
	/// Key: "LabelFeaturedAccesories"
	/// English String: "Featured Accessories"
	/// </summary>
	public override string LabelFeaturedAccesories => "Accessoires en vedette";

	/// <summary>
	/// Key: "LabelFeaturedAnimations"
	/// English String: "Featured Animations"
	/// </summary>
	public override string LabelFeaturedAnimations => "Animations en vedette";

	/// <summary>
	/// Key: "LabelFeaturedFaces"
	/// English String: "Featured Faces"
	/// </summary>
	public override string LabelFeaturedFaces => "Visages en vedette";

	/// <summary>
	/// Key: "LabelFeaturedGear"
	/// English String: "Featured Gear"
	/// </summary>
	public override string LabelFeaturedGear => "Équipement en vedette";

	/// <summary>
	/// Key: "LabelFeaturedPackages"
	/// English String: "Featured Packages"
	/// </summary>
	public override string LabelFeaturedPackages => "Packs en vedette";

	/// <summary>
	/// Key: "LabelFree"
	/// English String: "Free"
	/// </summary>
	public override string LabelFree => "Gratuit";

	/// <summary>
	/// Key: "LabelGear"
	/// English String: "Gear"
	/// </summary>
	public override string LabelGear => "Équipement";

	/// <summary>
	/// Key: "LabelGearAll"
	/// English String: "All Gear"
	/// </summary>
	public override string LabelGearAll => "Tout l'équipement";

	/// <summary>
	/// Key: "LabelGearBuilding"
	/// English String: "Building"
	/// </summary>
	public override string LabelGearBuilding => "Construction";

	/// <summary>
	/// Key: "LabelGearExplosive"
	/// English String: "Explosive"
	/// </summary>
	public override string LabelGearExplosive => "Explosif";

	/// <summary>
	/// Key: "LabelGearMelee"
	/// English String: "Melee"
	/// </summary>
	public override string LabelGearMelee => "Corps-à-corps";

	/// <summary>
	/// Key: "LabelGearMusical"
	/// English String: "Musical"
	/// </summary>
	public override string LabelGearMusical => "Musical";

	/// <summary>
	/// Key: "LabelGearNavigation"
	/// English String: "Navigation"
	/// </summary>
	public override string LabelGearNavigation => "Navigation";

	/// <summary>
	/// Key: "LabelGearPersonalTransport"
	/// English String: "Transport"
	/// </summary>
	public override string LabelGearPersonalTransport => "Transport";

	/// <summary>
	/// Key: "LabelGearPowerUps"
	/// English String: "Power Up"
	/// </summary>
	public override string LabelGearPowerUps => "Renforcement";

	/// <summary>
	/// Key: "LabelGearRanged"
	/// English String: "Ranged"
	/// </summary>
	public override string LabelGearRanged => "À distance";

	/// <summary>
	/// Key: "LabelGearSocial"
	/// English String: "Social"
	/// </summary>
	public override string LabelGearSocial => "Social";

	/// <summary>
	/// Key: "LabelGenreAdventure"
	/// English String: "Adventure"
	/// </summary>
	public override string LabelGenreAdventure => "Aventure";

	/// <summary>
	/// Key: "LabelGenreAll"
	/// English String: "All Genres"
	/// </summary>
	public override string LabelGenreAll => "Tous les genres";

	/// <summary>
	/// Key: "LabelGenreBuilding"
	/// English String: "Building"
	/// </summary>
	public override string LabelGenreBuilding => "Construction";

	/// <summary>
	/// Key: "LabelGenreComedy"
	/// English String: "Comedy"
	/// </summary>
	public override string LabelGenreComedy => "Humour";

	/// <summary>
	/// Key: "LabelGenreFantasy"
	/// English String: "Medieval"
	/// </summary>
	public override string LabelGenreFantasy => "Médiéval";

	/// <summary>
	/// Key: "LabelGenreFighting"
	/// English String: "Fighting"
	/// </summary>
	public override string LabelGenreFighting => "Combat";

	/// <summary>
	/// Key: "LabelGenreFPS"
	/// English String: "FPS"
	/// </summary>
	public override string LabelGenreFPS => "Tir subjectif";

	/// <summary>
	/// Key: "LabelGenreFunny"
	/// English String: "Comedy"
	/// </summary>
	public override string LabelGenreFunny => "Humour";

	/// <summary>
	/// Key: "LabelGenreHorror"
	/// English String: "Horror"
	/// </summary>
	public override string LabelGenreHorror => "Horreur";

	/// <summary>
	/// Key: "LabelGenreMedieval"
	/// English String: "Medieval"
	/// </summary>
	public override string LabelGenreMedieval => "Médiéval";

	/// <summary>
	/// Key: "LabelGenreMilitary"
	/// English String: "Military"
	/// </summary>
	public override string LabelGenreMilitary => "Militaire";

	/// <summary>
	/// Key: "LabelGenreNaval"
	/// English String: "Naval"
	/// </summary>
	public override string LabelGenreNaval => "Naval";

	/// <summary>
	/// Key: "LabelGenreNinja"
	/// English String: "Fighting"
	/// </summary>
	public override string LabelGenreNinja => "Combat";

	/// <summary>
	/// Key: "LabelGenrePirate"
	/// English String: "Naval"
	/// </summary>
	public override string LabelGenrePirate => "Naval";

	/// <summary>
	/// Key: "LabelGenreRPG"
	/// English String: "RPG"
	/// </summary>
	public override string LabelGenreRPG => "Jeu de rôle";

	/// <summary>
	/// Key: "LabelGenreScary"
	/// English String: "Horror"
	/// </summary>
	public override string LabelGenreScary => "Horreur";

	/// <summary>
	/// Key: "LabelGenreSciFi"
	/// English String: "Sci-Fi"
	/// </summary>
	public override string LabelGenreSciFi => "SF";

	/// <summary>
	/// Key: "LabelGenreSports"
	/// English String: "Sports"
	/// </summary>
	public override string LabelGenreSports => "Sports";

	/// <summary>
	/// Key: "LabelGenreTownAndCity"
	/// English String: "Town and City"
	/// </summary>
	public override string LabelGenreTownAndCity => "Villes";

	/// <summary>
	/// Key: "LabelGenreTutorial"
	/// English String: "Building"
	/// </summary>
	public override string LabelGenreTutorial => "Construction";

	/// <summary>
	/// Key: "LabelGenreWar"
	/// English String: "Military"
	/// </summary>
	public override string LabelGenreWar => "Militaire";

	/// <summary>
	/// Key: "LabelGenreWestern"
	/// English String: "Western"
	/// </summary>
	public override string LabelGenreWestern => "Western";

	/// <summary>
	/// Key: "LabelGenreWildWest"
	/// English String: "Western"
	/// </summary>
	public override string LabelGenreWildWest => "Western";

	/// <summary>
	/// Key: "LabelHeads"
	/// English String: "Heads"
	/// </summary>
	public override string LabelHeads => "Têtes";

	/// <summary>
	/// Key: "LabelMostFavorited"
	/// English String: "Most Favorited"
	/// </summary>
	public override string LabelMostFavorited => "Préférés des joueurs";

	/// <summary>
	/// Key: "LabelNoResellers"
	/// English String: "No Resellers"
	/// </summary>
	public override string LabelNoResellers => "Aucun revendeur";

	/// <summary>
	/// Key: "LabelOffSale"
	/// English String: "Offsale"
	/// </summary>
	public override string LabelOffSale => "Plus à vendre";

	/// <summary>
	/// Key: "LabelPackages"
	/// English String: "Packages"
	/// </summary>
	public override string LabelPackages => "Packs";

	/// <summary>
	/// Key: "LabelPants"
	/// English String: "Pants"
	/// </summary>
	public override string LabelPants => "Pantalons";

	/// <summary>
	/// Key: "LabelPastDay"
	/// English String: "Past Day"
	/// </summary>
	public override string LabelPastDay => "Hier";

	/// <summary>
	/// Key: "LabelPastWeek"
	/// English String: "Past Week"
	/// </summary>
	public override string LabelPastWeek => "Semaine dernière";

	/// <summary>
	/// Key: "LabelPriceHighFirst"
	/// English String: "Price (High to Low)"
	/// </summary>
	public override string LabelPriceHighFirst => "Prix (décroissant)";

	/// <summary>
	/// Key: "LabelPriceLowFirst"
	/// English String: "Price (Low to High)"
	/// </summary>
	public override string LabelPriceLowFirst => "Prix (croissant)";

	/// <summary>
	/// Key: "LabelRecentlyUpdated"
	/// English String: "Recently Updated"
	/// </summary>
	public override string LabelRecentlyUpdated => "Mis à jour récemment";

	/// <summary>
	/// Key: "LabelRelevance"
	/// English String: "Relevance"
	/// </summary>
	public override string LabelRelevance => "Pertinence";

	/// <summary>
	/// Key: "LabelRoblox"
	/// English String: "Roblox"
	/// </summary>
	public override string LabelRoblox => "Roblox";

	/// <summary>
	/// Key: "LabelRobux"
	/// English String: "Robux"
	/// </summary>
	public override string LabelRobux => "Robux";

	/// <summary>
	/// Key: "LabelShirts"
	/// English String: "Shirts"
	/// </summary>
	public override string LabelShirts => "Chemises";

	/// <summary>
	/// Key: "LabelTShirts"
	/// English String: "T-Shirts"
	/// </summary>
	public override string LabelTShirts => "Tee-shirts";

	/// <summary>
	/// Key: "Response.Error.Filter"
	/// English String: "Errors exist in Filter tab"
	/// </summary>
	public override string ResponseErrorFilter => "L'onglet Filtre comporte des erreurs.";

	/// <summary>
	/// Key: "Response.GenericError"
	/// English String: "An error occurred. Please try again later."
	/// </summary>
	public override string ResponseGenericError => "Une erreur est survenue. Veuillez réessayer plus tard.";

	/// <summary>
	/// Key: "Response.NoItemsFound"
	/// English String: "No items found."
	/// </summary>
	public override string ResponseNoItemsFound => "Aucun objet trouvé.";

	/// <summary>
	/// Key: "Response.NoSaleItemsFromSearch"
	/// English String: "Your search did not find items for sale. Unavailable items displayed below."
	/// </summary>
	public override string ResponseNoSaleItemsFromSearch => "Ta recherche n'a permis de trouver aucun objet à vendre. Les objets indisponibles sont affichés ci-dessous.";

	/// <summary>
	/// Key: "Response.TemporarilyUnavailable"
	/// English String: "Catalog temporarily unavailable. Please try again later."
	/// </summary>
	public override string ResponseTemporarilyUnavailable => "Le catalogue est temporairement indisponible. Veuillez réessayer plus tard.";

	/// <summary>
	/// Key: "Response.Throttled"
	/// Shown to users when they have made too many requests in a minute and are being throttled.
	/// English String: "You're going too fast! Try again in a minute."
	/// </summary>
	public override string ResponseThrottled => "Tu vas trop vite ! Réessaie dans une minute.";

	public CatalogResources_fr_fr(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionBuyRobux()
	{
		return "Acheter des Robux";
	}

	protected override string _GetTemplateForActionDialogAddGearOk()
	{
		return "OK";
	}

	protected override string _GetTemplateForActionFilterApply()
	{
		return "Appliquer";
	}

	protected override string _GetTemplateForActionFilterCancel()
	{
		return "Annuler";
	}

	protected override string _GetTemplateForActionGo()
	{
		return "Aller";
	}

	protected override string _GetTemplateForActionViewAllItems()
	{
		return "Voir tous les objets";
	}

	protected override string _GetTemplateForDescriptionDialogAddGearBody()
	{
		return "Pour ajouter de l'équipement à ton jeu, sélectionnes un objet du catalogue et cliques sur le bouton Ajouter au jeu. L'objet sera alors autorisé dans le jeu et tu recevras une commission pour chaque exemplaire vendu depuis la page de ton jeu. Seul l'équipement à vendre peut être ajouté.";
	}

	protected override string _GetTemplateForHeadingCatalogCategory()
	{
		return "Catégorie";
	}

	protected override string _GetTemplateForHeadingCatalogPage()
	{
		return "Catalogue";
	}

	protected override string _GetTemplateForLabelAllFeaturedItems()
	{
		return "Voir tous les objets en vedette";
	}

	protected override string _GetTemplateForLabelAllGenres()
	{
		return "Tous les genres";
	}

	protected override string _GetTemplateForLabelAmazon()
	{
		return "Amazon";
	}

	protected override string _GetTemplateForLabelBreadCrumbFree()
	{
		return "Gratuit";
	}

	/// <summary>
	/// Key: "Label.BreadCrumb.GenreOrText"
	/// English String: "{genreName1} or {genreName2}"
	/// </summary>
	public override string LabelBreadCrumbGenreOrText(string genreName1, string genreName2)
	{
		return $"{genreName1} ou {genreName2}";
	}

	protected override string _GetTemplateForLabelBreadCrumbGenreOrText()
	{
		return "{genreName1} ou {genreName2}";
	}

	/// <summary>
	/// Key: "Label.BreadCrumb.GenreSelectedText"
	/// English String: "Genre: {genreCount} selected"
	/// </summary>
	public override string LabelBreadCrumbGenreSelectedText(string genreCount)
	{
		return $"Genre\u00a0: {genreCount} sélectionné(s)";
	}

	protected override string _GetTemplateForLabelBreadCrumbGenreSelectedText()
	{
		return "Genre\u00a0: {genreCount} sélectionné(s)";
	}

	protected override string _GetTemplateForLabelBreadCrumbGroup()
	{
		return "Groupe\u00a0:";
	}

	/// <summary>
	/// Key: "Label.BreadCrumb.PriceAbove"
	/// English String: "{price} and above"
	/// </summary>
	public override string LabelBreadCrumbPriceAbove(string price)
	{
		return $"{price} et plus";
	}

	protected override string _GetTemplateForLabelBreadCrumbPriceAbove()
	{
		return "{price} et plus";
	}

	/// <summary>
	/// Key: "Label.BreadCrumb.PriceBelow"
	/// English String: "{price} and below"
	/// </summary>
	public override string LabelBreadCrumbPriceBelow(string price)
	{
		return $"{price} et moins";
	}

	protected override string _GetTemplateForLabelBreadCrumbPriceBelow()
	{
		return "{price} et moins";
	}

	/// <summary>
	/// Key: "Label.BreadCrumb.ResultsCount"
	/// English String: "{startNumber} - {endNumber} of {resultsCount} Results"
	/// </summary>
	public override string LabelBreadCrumbResultsCount(string startNumber, string endNumber, string resultsCount)
	{
		return $"{startNumber} - {endNumber} sur {resultsCount}\u00a0résultats";
	}

	protected override string _GetTemplateForLabelBreadCrumbResultsCount()
	{
		return "{startNumber} - {endNumber} sur {resultsCount}\u00a0résultats";
	}

	protected override string _GetTemplateForLabelBundle()
	{
		return "Paquet";
	}

	protected override string _GetTemplateForLabelBundles()
	{
		return "Paquets";
	}

	/// <summary>
	/// Key: "Label.ByCreatorLink"
	/// Creator name in item card with link
	/// English String: "By {linkStart}{creator}{linkEnd}"
	/// </summary>
	public override string LabelByCreatorLink(string linkStart, string creator, string linkEnd)
	{
		return $"Par {linkStart}{creator}{linkEnd}";
	}

	protected override string _GetTemplateForLabelByCreatorLink()
	{
		return "Par {linkStart}{creator}{linkEnd}";
	}

	protected override string _GetTemplateForLabelCardCreatorBy()
	{
		return "Par";
	}

	protected override string _GetTemplateForLabelCardPriceWas()
	{
		return "Anciennement";
	}

	protected override string _GetTemplateForLabelCardRemaining()
	{
		return "Reste\u00a0:";
	}

	protected override string _GetTemplateForLabelCategoryAttributes()
	{
		return "Caractéristiques";
	}

	protected override string _GetTemplateForLabelCategoryType()
	{
		return "Type";
	}

	protected override string _GetTemplateForLabelCommunityCreations()
	{
		return " Community Creations";
	}

	protected override string _GetTemplateForLabelDialogAddGearTitle()
	{
		return "Ajouter de l'équipement à ton jeu";
	}

	protected override string _GetTemplateForLabelEmotes()
	{
		return "Emotes";
	}

	protected override string _GetTemplateForLabelFavorites()
	{
		return "Favoris";
	}

	protected override string _GetTemplateForLabelFeaturedBundles()
	{
		return "Paquets en vedette";
	}

	protected override string _GetTemplateForLabelFeaturedEmotes()
	{
		return "Emotes en vedette";
	}

	/// <summary>
	/// Key: "Label.FeaturedItemsOnRoblox"
	/// English String: "Featured Items on {spanStart}{roblox}{spanEnd}"
	/// </summary>
	public override string LabelFeaturedItemsOnRoblox(string spanStart, string roblox, string spanEnd)
	{
		return $"Objets en vedette dans {spanStart}{roblox}{spanEnd}";
	}

	protected override string _GetTemplateForLabelFeaturedItemsOnRoblox()
	{
		return "Objets en vedette dans {spanStart}{roblox}{spanEnd}";
	}

	protected override string _GetTemplateForLabelFilterByTime()
	{
		return "Par durée";
	}

	protected override string _GetTemplateForLabelFilterCategory()
	{
		return "Catégorie";
	}

	protected override string _GetTemplateForLabelFilterCreator()
	{
		return "Créateur";
	}

	protected override string _GetTemplateForLabelFilterFilter()
	{
		return "Filtre";
	}

	protected override string _GetTemplateForLabelFilterFilters()
	{
		return "Filtres";
	}

	protected override string _GetTemplateForLabelFilterGenre()
	{
		return "Genre";
	}

	protected override string _GetTemplateForLabelFilterHide()
	{
		return "Masquer";
	}

	protected override string _GetTemplateForLabelFilterPrice()
	{
		return "Prix";
	}

	protected override string _GetTemplateForLabelFilterPriceMax()
	{
		return "Max";
	}

	protected override string _GetTemplateForLabelFilterPriceMin()
	{
		return "Min";
	}

	protected override string _GetTemplateForLabelFilterPriceTo()
	{
		return "À";
	}

	protected override string _GetTemplateForLabelFilterShow()
	{
		return "Afficher";
	}

	protected override string _GetTemplateForLabelFilterSorting()
	{
		return "Tri";
	}

	protected override string _GetTemplateForLabelFilterUnavailableItems()
	{
		return "Objets indisponibles";
	}

	protected override string _GetTemplateForLabelGoogleOnly()
	{
		return "Google uniquement";
	}

	protected override string _GetTemplateForLabelIos()
	{
		return "iOS";
	}

	protected override string _GetTemplateForLabelMobile()
	{
		return "Mobile";
	}

	protected override string _GetTemplateForLabelNew()
	{
		return "Nouveau";
	}

	protected override string _GetTemplateForLabelRthro()
	{
		return "Rthro";
	}

	protected override string _GetTemplateForLabelSale()
	{
		return "Offre";
	}

	protected override string _GetTemplateForLabelSearchField()
	{
		return "Rechercher";
	}

	protected override string _GetTemplateForLabelSeeAll()
	{
		return "Afficher tout";
	}

	protected override string _GetTemplateForLabelUsername()
	{
		return "Nom d'utilisateur";
	}

	protected override string _GetTemplateForLabelXbox()
	{
		return "Xbox";
	}

	protected override string _GetTemplateForLabelAccessories()
	{
		return "Accessoires";
	}

	protected override string _GetTemplateForLabelAccessoryAll()
	{
		return "Tous les accessoires";
	}

	protected override string _GetTemplateForLabelAccessoryBack()
	{
		return "Dos";
	}

	protected override string _GetTemplateForLabelAccessoryFace()
	{
		return "Visage";
	}

	protected override string _GetTemplateForLabelAccessoryFront()
	{
		return "Avant";
	}

	protected override string _GetTemplateForLabelAccessoryHair()
	{
		return "Cheveux";
	}

	protected override string _GetTemplateForLabelAccessoryHats()
	{
		return "Chapeaux";
	}

	protected override string _GetTemplateForLabelAccessoryNeck()
	{
		return "Cou";
	}

	protected override string _GetTemplateForLabelAccessoryShoulder()
	{
		return "Épaules";
	}

	protected override string _GetTemplateForLabelAccessoryWaist()
	{
		return "Taille";
	}

	protected override string _GetTemplateForLabelAll()
	{
		return "Tous";
	}

	protected override string _GetTemplateForLabelAllBodyParts()
	{
		return "Toutes les parties du corps";
	}

	protected override string _GetTemplateForLabelAllCategories()
	{
		return "Toutes les catégories";
	}

	protected override string _GetTemplateForLabelAllClothing()
	{
		return "Tous les vêtements";
	}

	protected override string _GetTemplateForLabelAllCollectibles()
	{
		return "Tous les objets de collection";
	}

	protected override string _GetTemplateForLabelAllCreators()
	{
		return "Tous les créateurs";
	}

	protected override string _GetTemplateForLabelAllCurrency()
	{
		return "Toutes les devises";
	}

	protected override string _GetTemplateForLabelAllFeatured()
	{
		return "Tous les objets en vedette";
	}

	protected override string _GetTemplateForLabelAllTime()
	{
		return "Tous les temps";
	}

	protected override string _GetTemplateForLabelAnimations()
	{
		return "Animations";
	}

	protected override string _GetTemplateForLabelAnyPrice()
	{
		return "Tous les prix";
	}

	protected override string _GetTemplateForLabelAvatarAnimations()
	{
		return "Animations d'avatar";
	}

	protected override string _GetTemplateForLabelBestselling()
	{
		return "Meilleures ventes";
	}

	protected override string _GetTemplateForLabelBodyParts()
	{
		return "Parties du corps";
	}

	protected override string _GetTemplateForLabelClothing()
	{
		return "Vêtements";
	}

	protected override string _GetTemplateForLabelCollectibleAccessories()
	{
		return "Accessoires de collection";
	}

	protected override string _GetTemplateForLabelCollectibleFaces()
	{
		return "Visages de collection";
	}

	protected override string _GetTemplateForLabelCollectibleGear()
	{
		return "Équipement de collection";
	}

	protected override string _GetTemplateForLabelCollectibles()
	{
		return "Objets de collection";
	}

	protected override string _GetTemplateForLabelFaces()
	{
		return "Visages";
	}

	protected override string _GetTemplateForLabelFeatured()
	{
		return "En vedette";
	}

	protected override string _GetTemplateForLabelFeaturedAccesories()
	{
		return "Accessoires en vedette";
	}

	protected override string _GetTemplateForLabelFeaturedAnimations()
	{
		return "Animations en vedette";
	}

	protected override string _GetTemplateForLabelFeaturedFaces()
	{
		return "Visages en vedette";
	}

	protected override string _GetTemplateForLabelFeaturedGear()
	{
		return "Équipement en vedette";
	}

	protected override string _GetTemplateForLabelFeaturedPackages()
	{
		return "Packs en vedette";
	}

	protected override string _GetTemplateForLabelFree()
	{
		return "Gratuit";
	}

	protected override string _GetTemplateForLabelGear()
	{
		return "Équipement";
	}

	protected override string _GetTemplateForLabelGearAll()
	{
		return "Tout l'équipement";
	}

	protected override string _GetTemplateForLabelGearBuilding()
	{
		return "Construction";
	}

	protected override string _GetTemplateForLabelGearExplosive()
	{
		return "Explosif";
	}

	protected override string _GetTemplateForLabelGearMelee()
	{
		return "Corps-à-corps";
	}

	protected override string _GetTemplateForLabelGearMusical()
	{
		return "Musical";
	}

	protected override string _GetTemplateForLabelGearNavigation()
	{
		return "Navigation";
	}

	protected override string _GetTemplateForLabelGearPersonalTransport()
	{
		return "Transport";
	}

	protected override string _GetTemplateForLabelGearPowerUps()
	{
		return "Renforcement";
	}

	protected override string _GetTemplateForLabelGearRanged()
	{
		return "À distance";
	}

	protected override string _GetTemplateForLabelGearSocial()
	{
		return "Social";
	}

	protected override string _GetTemplateForLabelGenreAdventure()
	{
		return "Aventure";
	}

	protected override string _GetTemplateForLabelGenreAll()
	{
		return "Tous les genres";
	}

	protected override string _GetTemplateForLabelGenreBuilding()
	{
		return "Construction";
	}

	protected override string _GetTemplateForLabelGenreComedy()
	{
		return "Humour";
	}

	protected override string _GetTemplateForLabelGenreFantasy()
	{
		return "Médiéval";
	}

	protected override string _GetTemplateForLabelGenreFighting()
	{
		return "Combat";
	}

	protected override string _GetTemplateForLabelGenreFPS()
	{
		return "Tir subjectif";
	}

	protected override string _GetTemplateForLabelGenreFunny()
	{
		return "Humour";
	}

	protected override string _GetTemplateForLabelGenreHorror()
	{
		return "Horreur";
	}

	protected override string _GetTemplateForLabelGenreMedieval()
	{
		return "Médiéval";
	}

	protected override string _GetTemplateForLabelGenreMilitary()
	{
		return "Militaire";
	}

	protected override string _GetTemplateForLabelGenreNaval()
	{
		return "Naval";
	}

	protected override string _GetTemplateForLabelGenreNinja()
	{
		return "Combat";
	}

	protected override string _GetTemplateForLabelGenrePirate()
	{
		return "Naval";
	}

	protected override string _GetTemplateForLabelGenreRPG()
	{
		return "Jeu de rôle";
	}

	protected override string _GetTemplateForLabelGenreScary()
	{
		return "Horreur";
	}

	protected override string _GetTemplateForLabelGenreSciFi()
	{
		return "SF";
	}

	protected override string _GetTemplateForLabelGenreSports()
	{
		return "Sports";
	}

	protected override string _GetTemplateForLabelGenreTownAndCity()
	{
		return "Villes";
	}

	protected override string _GetTemplateForLabelGenreTutorial()
	{
		return "Construction";
	}

	protected override string _GetTemplateForLabelGenreWar()
	{
		return "Militaire";
	}

	protected override string _GetTemplateForLabelGenreWestern()
	{
		return "Western";
	}

	protected override string _GetTemplateForLabelGenreWildWest()
	{
		return "Western";
	}

	protected override string _GetTemplateForLabelHeads()
	{
		return "Têtes";
	}

	protected override string _GetTemplateForLabelMostFavorited()
	{
		return "Préférés des joueurs";
	}

	protected override string _GetTemplateForLabelNoResellers()
	{
		return "Aucun revendeur";
	}

	protected override string _GetTemplateForLabelOffSale()
	{
		return "Plus à vendre";
	}

	protected override string _GetTemplateForLabelPackages()
	{
		return "Packs";
	}

	protected override string _GetTemplateForLabelPants()
	{
		return "Pantalons";
	}

	protected override string _GetTemplateForLabelPastDay()
	{
		return "Hier";
	}

	protected override string _GetTemplateForLabelPastWeek()
	{
		return "Semaine dernière";
	}

	protected override string _GetTemplateForLabelPriceHighFirst()
	{
		return "Prix (décroissant)";
	}

	protected override string _GetTemplateForLabelPriceLowFirst()
	{
		return "Prix (croissant)";
	}

	protected override string _GetTemplateForLabelRecentlyUpdated()
	{
		return "Mis à jour récemment";
	}

	protected override string _GetTemplateForLabelRelevance()
	{
		return "Pertinence";
	}

	protected override string _GetTemplateForLabelRoblox()
	{
		return "Roblox";
	}

	protected override string _GetTemplateForLabelRobux()
	{
		return "Robux";
	}

	protected override string _GetTemplateForLabelShirts()
	{
		return "Chemises";
	}

	protected override string _GetTemplateForLabelTShirts()
	{
		return "Tee-shirts";
	}

	protected override string _GetTemplateForResponseErrorFilter()
	{
		return "L'onglet Filtre comporte des erreurs.";
	}

	protected override string _GetTemplateForResponseGenericError()
	{
		return "Une erreur est survenue. Veuillez réessayer plus tard.";
	}

	protected override string _GetTemplateForResponseNoItemsFound()
	{
		return "Aucun objet trouvé.";
	}

	protected override string _GetTemplateForResponseNoSaleItemsFromSearch()
	{
		return "Ta recherche n'a permis de trouver aucun objet à vendre. Les objets indisponibles sont affichés ci-dessous.";
	}

	protected override string _GetTemplateForResponseTemporarilyUnavailable()
	{
		return "Le catalogue est temporairement indisponible. Veuillez réessayer plus tard.";
	}

	protected override string _GetTemplateForResponseThrottled()
	{
		return "Tu vas trop vite ! Réessaie dans une minute.";
	}
}
