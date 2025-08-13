using System;
using System.Collections.Generic;

namespace Roblox.TranslationResources.Feature;

internal class CatalogResources_en_us : TranslationResourcesBase, ICatalogResources, ITranslationResources
{
	private readonly Lazy<IReadOnlyDictionary<string, string>> _AllKeys;

	/// <summary>
	/// Key: "Action.BuyRobux"
	/// English String: "Buy Robux"
	/// </summary>
	public virtual string ActionBuyRobux => "Buy Robux";

	/// <summary>
	/// Key: "Action.Dialog.AddGearOk"
	/// English String: "OK"
	/// </summary>
	public virtual string ActionDialogAddGearOk => "OK";

	/// <summary>
	/// Key: "Action.Filter.Apply"
	/// English String: "Apply"
	/// </summary>
	public virtual string ActionFilterApply => "Apply";

	/// <summary>
	/// Key: "Action.Filter.Cancel"
	/// English String: "Cancel"
	/// </summary>
	public virtual string ActionFilterCancel => "Cancel";

	/// <summary>
	/// Key: "Action.Go"
	/// English String: "Go"
	/// </summary>
	public virtual string ActionGo => "Go";

	/// <summary>
	/// Key: "Action.ViewAllItems"
	/// English String: "View All Items"
	/// </summary>
	public virtual string ActionViewAllItems => "View All Items";

	/// <summary>
	/// Key: "Description.Dialog.AddGearBody"
	/// English String: "To add gear to your game, find an item in the catalog and click the Add to Game button. The item will automatically be allowed in game, and you'll receive a commission on every copy sold from your game page. (You can only add gear that's for sale.)"
	/// </summary>
	public virtual string DescriptionDialogAddGearBody => "To add gear to your game, find an item in the catalog and click the Add to Game button. The item will automatically be allowed in game, and you'll receive a commission on every copy sold from your game page. (You can only add gear that's for sale.)";

	/// <summary>
	/// Key: "Heading.CatalogCategory"
	/// English String: "Category"
	/// </summary>
	public virtual string HeadingCatalogCategory => "Category";

	/// <summary>
	/// Key: "Heading.CatalogPage"
	/// English String: "Catalog"
	/// </summary>
	public virtual string HeadingCatalogPage => "Catalog";

	/// <summary>
	/// Key: "Label.AllFeaturedItems"
	/// English String: "View All Featured Items"
	/// </summary>
	public virtual string LabelAllFeaturedItems => "View All Featured Items";

	/// <summary>
	/// Key: "Label.AllGenres"
	/// English String: "All Genres"
	/// </summary>
	public virtual string LabelAllGenres => "All Genres";

	/// <summary>
	/// Key: "Label.Amazon"
	/// label
	/// English String: "Amazon"
	/// </summary>
	public virtual string LabelAmazon => "Amazon";

	/// <summary>
	/// Key: "Label.BreadCrumb.Free"
	/// English String: "Free"
	/// </summary>
	public virtual string LabelBreadCrumbFree => "Free";

	/// <summary>
	/// Key: "Label.BreadCrumb.Group"
	/// English String: "Group:"
	/// </summary>
	public virtual string LabelBreadCrumbGroup => "Group:";

	/// <summary>
	/// Key: "Label.Bundle"
	/// Bundle
	/// English String: "Bundle"
	/// </summary>
	public virtual string LabelBundle => "Bundle";

	/// <summary>
	/// Key: "Label.Bundles"
	/// Bundles
	/// English String: "Bundles"
	/// </summary>
	public virtual string LabelBundles => "Bundles";

	/// <summary>
	/// Key: "Label.Card.CreatorBy"
	/// English String: "By"
	/// </summary>
	public virtual string LabelCardCreatorBy => "By";

	/// <summary>
	/// Key: "Label.Card.PriceWas"
	/// English String: "Was"
	/// </summary>
	public virtual string LabelCardPriceWas => "Was";

	/// <summary>
	/// Key: "Label.Card.Remaining"
	/// English String: "Remaining:"
	/// </summary>
	public virtual string LabelCardRemaining => "Remaining:";

	/// <summary>
	/// Key: "Label.CategoryAttributes"
	/// English String: "Attributes"
	/// </summary>
	public virtual string LabelCategoryAttributes => "Attributes";

	/// <summary>
	/// Key: "Label.CategoryType"
	/// English String: "Type"
	/// </summary>
	public virtual string LabelCategoryType => "Type";

	/// <summary>
	/// Key: "Label.CommunityCreations"
	/// UGC items
	/// English String: " Community Creations"
	/// </summary>
	public virtual string LabelCommunityCreations => " Community Creations";

	/// <summary>
	/// Key: "Label.Dialog.AddGearTitle"
	/// English String: "Add Gear to Your Game"
	/// </summary>
	public virtual string LabelDialogAddGearTitle => "Add Gear to Your Game";

	/// <summary>
	/// Key: "Label.Emotes"
	/// Emotes
	/// English String: "Emotes"
	/// </summary>
	public virtual string LabelEmotes => "Emotes";

	/// <summary>
	/// Key: "Label.Favorites"
	/// English String: "Favorites"
	/// </summary>
	public virtual string LabelFavorites => "Favorites";

	/// <summary>
	/// Key: "Label.FeaturedBundles"
	/// Featured Bundles
	/// English String: "Featured Bundles"
	/// </summary>
	public virtual string LabelFeaturedBundles => "Featured Bundles";

	/// <summary>
	/// Key: "Label.FeaturedEmotes"
	/// Featured Emotes
	/// English String: "Featured Emotes"
	/// </summary>
	public virtual string LabelFeaturedEmotes => "Featured Emotes";

	/// <summary>
	/// Key: "Label.Filter.ByTime"
	/// English String: "By Time"
	/// </summary>
	public virtual string LabelFilterByTime => "By Time";

	/// <summary>
	/// Key: "Label.Filter.Category"
	/// English String: "Category"
	/// </summary>
	public virtual string LabelFilterCategory => "Category";

	/// <summary>
	/// Key: "Label.Filter.Creator"
	/// English String: "Creator"
	/// </summary>
	public virtual string LabelFilterCreator => "Creator";

	/// <summary>
	/// Key: "Label.Filter.Filter"
	/// English String: "Filter"
	/// </summary>
	public virtual string LabelFilterFilter => "Filter";

	/// <summary>
	/// Key: "Label.Filter.Filters"
	/// English String: "Filters"
	/// </summary>
	public virtual string LabelFilterFilters => "Filters";

	/// <summary>
	/// Key: "Label.Filter.Genre"
	/// English String: "Genre"
	/// </summary>
	public virtual string LabelFilterGenre => "Genre";

	/// <summary>
	/// Key: "Label.Filter.Hide"
	/// English String: "Hide"
	/// </summary>
	public virtual string LabelFilterHide => "Hide";

	/// <summary>
	/// Key: "Label.Filter.Price"
	/// English String: "Price"
	/// </summary>
	public virtual string LabelFilterPrice => "Price";

	/// <summary>
	/// Key: "Label.Filter.PriceMax"
	/// English String: "Max"
	/// </summary>
	public virtual string LabelFilterPriceMax => "Max";

	/// <summary>
	/// Key: "Label.Filter.PriceMin"
	/// English String: "Min"
	/// </summary>
	public virtual string LabelFilterPriceMin => "Min";

	/// <summary>
	/// Key: "Label.Filter.PriceTo"
	/// English String: "To"
	/// </summary>
	public virtual string LabelFilterPriceTo => "To";

	/// <summary>
	/// Key: "Label.Filter.Show"
	/// English String: "Show"
	/// </summary>
	public virtual string LabelFilterShow => "Show";

	/// <summary>
	/// Key: "Label.Filter.Sorting"
	/// English String: "Sorting"
	/// </summary>
	public virtual string LabelFilterSorting => "Sorting";

	/// <summary>
	/// Key: "Label.Filter.UnavailableItems"
	/// English String: "Unavailable Items"
	/// </summary>
	public virtual string LabelFilterUnavailableItems => "Unavailable Items";

	/// <summary>
	/// Key: "Label.GoogleOnly"
	/// label
	/// English String: "Google Only"
	/// </summary>
	public virtual string LabelGoogleOnly => "Google Only";

	/// <summary>
	/// Key: "Label.Ios"
	/// label
	/// English String: "IOS"
	/// </summary>
	public virtual string LabelIos => "IOS";

	/// <summary>
	/// Key: "Label.Mobile"
	/// label
	/// English String: "Mobile"
	/// </summary>
	public virtual string LabelMobile => "Mobile";

	/// <summary>
	/// Key: "Label.New"
	/// label
	/// English String: "New"
	/// </summary>
	public virtual string LabelNew => "New";

	/// <summary>
	/// Key: "Label.Rthro"
	/// Rthro is "Anthro" but we replaced the beginning of the word with an "R" to align with "R6" and "R15"
	/// English String: "Rthro"
	/// </summary>
	public virtual string LabelRthro => "Rthro";

	/// <summary>
	/// Key: "Label.Sale"
	/// label
	/// English String: "Sale"
	/// </summary>
	public virtual string LabelSale => "Sale";

	/// <summary>
	/// Key: "Label.SearchField"
	/// English String: "Search"
	/// </summary>
	public virtual string LabelSearchField => "Search";

	/// <summary>
	/// Key: "Label.SeeAll"
	/// English String: "See All"
	/// </summary>
	public virtual string LabelSeeAll => "See All";

	/// <summary>
	/// Key: "Label.Username"
	/// English String: "Username"
	/// </summary>
	public virtual string LabelUsername => "Username";

	/// <summary>
	/// Key: "Label.Xbox"
	/// label
	/// English String: "Xbox"
	/// </summary>
	public virtual string LabelXbox => "Xbox";

	/// <summary>
	/// Key: "LabelAccessories"
	/// English String: "Accessories"
	/// </summary>
	public virtual string LabelAccessories => "Accessories";

	/// <summary>
	/// Key: "LabelAccessoryAll"
	/// English String: "All Accessories"
	/// </summary>
	public virtual string LabelAccessoryAll => "All Accessories";

	/// <summary>
	/// Key: "LabelAccessoryBack"
	/// English String: "Back"
	/// </summary>
	public virtual string LabelAccessoryBack => "Back";

	/// <summary>
	/// Key: "LabelAccessoryFace"
	/// English String: "Face"
	/// </summary>
	public virtual string LabelAccessoryFace => "Face";

	/// <summary>
	/// Key: "LabelAccessoryFront"
	/// English String: "Front"
	/// </summary>
	public virtual string LabelAccessoryFront => "Front";

	/// <summary>
	/// Key: "LabelAccessoryHair"
	/// English String: "Hair"
	/// </summary>
	public virtual string LabelAccessoryHair => "Hair";

	/// <summary>
	/// Key: "LabelAccessoryHats"
	/// English String: "Hats"
	/// </summary>
	public virtual string LabelAccessoryHats => "Hats";

	/// <summary>
	/// Key: "LabelAccessoryNeck"
	/// English String: "Neck"
	/// </summary>
	public virtual string LabelAccessoryNeck => "Neck";

	/// <summary>
	/// Key: "LabelAccessoryShoulder"
	/// English String: "Shoulder"
	/// </summary>
	public virtual string LabelAccessoryShoulder => "Shoulder";

	/// <summary>
	/// Key: "LabelAccessoryWaist"
	/// English String: "Waist"
	/// </summary>
	public virtual string LabelAccessoryWaist => "Waist";

	/// <summary>
	/// Key: "LabelAll"
	/// English String: "All"
	/// </summary>
	public virtual string LabelAll => "All";

	/// <summary>
	/// Key: "LabelAllBodyParts"
	/// English String: "All Body Parts"
	/// </summary>
	public virtual string LabelAllBodyParts => "All Body Parts";

	/// <summary>
	/// Key: "LabelAllCategories"
	/// English String: "All Categories"
	/// </summary>
	public virtual string LabelAllCategories => "All Categories";

	/// <summary>
	/// Key: "LabelAllClothing"
	/// English String: "All Clothing"
	/// </summary>
	public virtual string LabelAllClothing => "All Clothing";

	/// <summary>
	/// Key: "LabelAllCollectibles"
	/// English String: "All Collectibles"
	/// </summary>
	public virtual string LabelAllCollectibles => "All Collectibles";

	/// <summary>
	/// Key: "LabelAllCreators"
	/// English String: "All Creators"
	/// </summary>
	public virtual string LabelAllCreators => "All Creators";

	/// <summary>
	/// Key: "LabelAllCurrency"
	/// English String: "All Currency"
	/// </summary>
	public virtual string LabelAllCurrency => "All Currency";

	/// <summary>
	/// Key: "LabelAllFeatured"
	/// English String: "All Featured Items"
	/// </summary>
	public virtual string LabelAllFeatured => "All Featured Items";

	/// <summary>
	/// Key: "LabelAllTime"
	/// English String: "All Time"
	/// </summary>
	public virtual string LabelAllTime => "All Time";

	/// <summary>
	/// Key: "LabelAnimations"
	/// English String: "Animations"
	/// </summary>
	public virtual string LabelAnimations => "Animations";

	/// <summary>
	/// Key: "LabelAnyPrice"
	/// English String: "Any Price"
	/// </summary>
	public virtual string LabelAnyPrice => "Any Price";

	/// <summary>
	/// Key: "LabelAvatarAnimations"
	/// English String: "Avatar Animations"
	/// </summary>
	public virtual string LabelAvatarAnimations => "Avatar Animations";

	/// <summary>
	/// Key: "LabelBestselling"
	/// English String: "Bestselling"
	/// </summary>
	public virtual string LabelBestselling => "Bestselling";

	/// <summary>
	/// Key: "LabelBodyParts"
	/// English String: "Body Parts"
	/// </summary>
	public virtual string LabelBodyParts => "Body Parts";

	/// <summary>
	/// Key: "LabelClothing"
	/// English String: "Clothing"
	/// </summary>
	public virtual string LabelClothing => "Clothing";

	/// <summary>
	/// Key: "LabelCollectibleAccessories"
	/// English String: "Collectible Accessories"
	/// </summary>
	public virtual string LabelCollectibleAccessories => "Collectible Accessories";

	/// <summary>
	/// Key: "LabelCollectibleFaces"
	/// English String: "Collectible Faces"
	/// </summary>
	public virtual string LabelCollectibleFaces => "Collectible Faces";

	/// <summary>
	/// Key: "LabelCollectibleGear"
	/// English String: "Collectible Gear"
	/// </summary>
	public virtual string LabelCollectibleGear => "Collectible Gear";

	/// <summary>
	/// Key: "LabelCollectibles"
	/// English String: "Collectibles"
	/// </summary>
	public virtual string LabelCollectibles => "Collectibles";

	/// <summary>
	/// Key: "LabelFaces"
	/// English String: "Faces"
	/// </summary>
	public virtual string LabelFaces => "Faces";

	/// <summary>
	/// Key: "LabelFeatured"
	/// English String: "Featured"
	/// </summary>
	public virtual string LabelFeatured => "Featured";

	/// <summary>
	/// Key: "LabelFeaturedAccesories"
	/// English String: "Featured Accessories"
	/// </summary>
	public virtual string LabelFeaturedAccesories => "Featured Accessories";

	/// <summary>
	/// Key: "LabelFeaturedAnimations"
	/// English String: "Featured Animations"
	/// </summary>
	public virtual string LabelFeaturedAnimations => "Featured Animations";

	/// <summary>
	/// Key: "LabelFeaturedFaces"
	/// English String: "Featured Faces"
	/// </summary>
	public virtual string LabelFeaturedFaces => "Featured Faces";

	/// <summary>
	/// Key: "LabelFeaturedGear"
	/// English String: "Featured Gear"
	/// </summary>
	public virtual string LabelFeaturedGear => "Featured Gear";

	/// <summary>
	/// Key: "LabelFeaturedPackages"
	/// English String: "Featured Packages"
	/// </summary>
	public virtual string LabelFeaturedPackages => "Featured Packages";

	/// <summary>
	/// Key: "LabelFree"
	/// English String: "Free"
	/// </summary>
	public virtual string LabelFree => "Free";

	/// <summary>
	/// Key: "LabelGear"
	/// English String: "Gear"
	/// </summary>
	public virtual string LabelGear => "Gear";

	/// <summary>
	/// Key: "LabelGearAll"
	/// English String: "All Gear"
	/// </summary>
	public virtual string LabelGearAll => "All Gear";

	/// <summary>
	/// Key: "LabelGearBuilding"
	/// English String: "Building"
	/// </summary>
	public virtual string LabelGearBuilding => "Building";

	/// <summary>
	/// Key: "LabelGearExplosive"
	/// English String: "Explosive"
	/// </summary>
	public virtual string LabelGearExplosive => "Explosive";

	/// <summary>
	/// Key: "LabelGearMelee"
	/// English String: "Melee"
	/// </summary>
	public virtual string LabelGearMelee => "Melee";

	/// <summary>
	/// Key: "LabelGearMusical"
	/// English String: "Musical"
	/// </summary>
	public virtual string LabelGearMusical => "Musical";

	/// <summary>
	/// Key: "LabelGearNavigation"
	/// English String: "Navigation"
	/// </summary>
	public virtual string LabelGearNavigation => "Navigation";

	/// <summary>
	/// Key: "LabelGearPersonalTransport"
	/// English String: "Transport"
	/// </summary>
	public virtual string LabelGearPersonalTransport => "Transport";

	/// <summary>
	/// Key: "LabelGearPowerUps"
	/// English String: "Power Up"
	/// </summary>
	public virtual string LabelGearPowerUps => "Power Up";

	/// <summary>
	/// Key: "LabelGearRanged"
	/// English String: "Ranged"
	/// </summary>
	public virtual string LabelGearRanged => "Ranged";

	/// <summary>
	/// Key: "LabelGearSocial"
	/// English String: "Social"
	/// </summary>
	public virtual string LabelGearSocial => "Social";

	/// <summary>
	/// Key: "LabelGenreAdventure"
	/// English String: "Adventure"
	/// </summary>
	public virtual string LabelGenreAdventure => "Adventure";

	/// <summary>
	/// Key: "LabelGenreAll"
	/// English String: "All Genres"
	/// </summary>
	public virtual string LabelGenreAll => "All Genres";

	/// <summary>
	/// Key: "LabelGenreBuilding"
	/// English String: "Building"
	/// </summary>
	public virtual string LabelGenreBuilding => "Building";

	/// <summary>
	/// Key: "LabelGenreComedy"
	/// English String: "Comedy"
	/// </summary>
	public virtual string LabelGenreComedy => "Comedy";

	/// <summary>
	/// Key: "LabelGenreFantasy"
	/// English String: "Medieval"
	/// </summary>
	public virtual string LabelGenreFantasy => "Medieval";

	/// <summary>
	/// Key: "LabelGenreFighting"
	/// English String: "Fighting"
	/// </summary>
	public virtual string LabelGenreFighting => "Fighting";

	/// <summary>
	/// Key: "LabelGenreFPS"
	/// English String: "FPS"
	/// </summary>
	public virtual string LabelGenreFPS => "FPS";

	/// <summary>
	/// Key: "LabelGenreFunny"
	/// English String: "Comedy"
	/// </summary>
	public virtual string LabelGenreFunny => "Comedy";

	/// <summary>
	/// Key: "LabelGenreHorror"
	/// English String: "Horror"
	/// </summary>
	public virtual string LabelGenreHorror => "Horror";

	/// <summary>
	/// Key: "LabelGenreMedieval"
	/// English String: "Medieval"
	/// </summary>
	public virtual string LabelGenreMedieval => "Medieval";

	/// <summary>
	/// Key: "LabelGenreMilitary"
	/// English String: "Military"
	/// </summary>
	public virtual string LabelGenreMilitary => "Military";

	/// <summary>
	/// Key: "LabelGenreNaval"
	/// English String: "Naval"
	/// </summary>
	public virtual string LabelGenreNaval => "Naval";

	/// <summary>
	/// Key: "LabelGenreNinja"
	/// English String: "Fighting"
	/// </summary>
	public virtual string LabelGenreNinja => "Fighting";

	/// <summary>
	/// Key: "LabelGenrePirate"
	/// English String: "Naval"
	/// </summary>
	public virtual string LabelGenrePirate => "Naval";

	/// <summary>
	/// Key: "LabelGenreRPG"
	/// English String: "RPG"
	/// </summary>
	public virtual string LabelGenreRPG => "RPG";

	/// <summary>
	/// Key: "LabelGenreScary"
	/// English String: "Horror"
	/// </summary>
	public virtual string LabelGenreScary => "Horror";

	/// <summary>
	/// Key: "LabelGenreSciFi"
	/// English String: "Sci-Fi"
	/// </summary>
	public virtual string LabelGenreSciFi => "Sci-Fi";

	/// <summary>
	/// Key: "LabelGenreSports"
	/// English String: "Sports"
	/// </summary>
	public virtual string LabelGenreSports => "Sports";

	/// <summary>
	/// Key: "LabelGenreTownAndCity"
	/// English String: "Town and City"
	/// </summary>
	public virtual string LabelGenreTownAndCity => "Town and City";

	/// <summary>
	/// Key: "LabelGenreTutorial"
	/// English String: "Building"
	/// </summary>
	public virtual string LabelGenreTutorial => "Building";

	/// <summary>
	/// Key: "LabelGenreWar"
	/// English String: "Military"
	/// </summary>
	public virtual string LabelGenreWar => "Military";

	/// <summary>
	/// Key: "LabelGenreWestern"
	/// English String: "Western"
	/// </summary>
	public virtual string LabelGenreWestern => "Western";

	/// <summary>
	/// Key: "LabelGenreWildWest"
	/// English String: "Western"
	/// </summary>
	public virtual string LabelGenreWildWest => "Western";

	/// <summary>
	/// Key: "LabelHeads"
	/// English String: "Heads"
	/// </summary>
	public virtual string LabelHeads => "Heads";

	/// <summary>
	/// Key: "LabelMostFavorited"
	/// English String: "Most Favorited"
	/// </summary>
	public virtual string LabelMostFavorited => "Most Favorited";

	/// <summary>
	/// Key: "LabelNoResellers"
	/// English String: "No Resellers"
	/// </summary>
	public virtual string LabelNoResellers => "No Resellers";

	/// <summary>
	/// Key: "LabelOffSale"
	/// English String: "Offsale"
	/// </summary>
	public virtual string LabelOffSale => "Offsale";

	/// <summary>
	/// Key: "LabelPackages"
	/// English String: "Packages"
	/// </summary>
	public virtual string LabelPackages => "Packages";

	/// <summary>
	/// Key: "LabelPants"
	/// English String: "Pants"
	/// </summary>
	public virtual string LabelPants => "Pants";

	/// <summary>
	/// Key: "LabelPastDay"
	/// English String: "Past Day"
	/// </summary>
	public virtual string LabelPastDay => "Past Day";

	/// <summary>
	/// Key: "LabelPastWeek"
	/// English String: "Past Week"
	/// </summary>
	public virtual string LabelPastWeek => "Past Week";

	/// <summary>
	/// Key: "LabelPriceHighFirst"
	/// English String: "Price (High to Low)"
	/// </summary>
	public virtual string LabelPriceHighFirst => "Price (High to Low)";

	/// <summary>
	/// Key: "LabelPriceLowFirst"
	/// English String: "Price (Low to High)"
	/// </summary>
	public virtual string LabelPriceLowFirst => "Price (Low to High)";

	/// <summary>
	/// Key: "LabelRecentlyUpdated"
	/// English String: "Recently Updated"
	/// </summary>
	public virtual string LabelRecentlyUpdated => "Recently Updated";

	/// <summary>
	/// Key: "LabelRelevance"
	/// English String: "Relevance"
	/// </summary>
	public virtual string LabelRelevance => "Relevance";

	/// <summary>
	/// Key: "LabelRoblox"
	/// English String: "Roblox"
	/// </summary>
	public virtual string LabelRoblox => "Roblox";

	/// <summary>
	/// Key: "LabelRobux"
	/// English String: "Robux"
	/// </summary>
	public virtual string LabelRobux => "Robux";

	/// <summary>
	/// Key: "LabelShirts"
	/// English String: "Shirts"
	/// </summary>
	public virtual string LabelShirts => "Shirts";

	/// <summary>
	/// Key: "LabelTShirts"
	/// English String: "T-Shirts"
	/// </summary>
	public virtual string LabelTShirts => "T-Shirts";

	/// <summary>
	/// Key: "Response.Error.Filter"
	/// English String: "Errors exist in Filter tab"
	/// </summary>
	public virtual string ResponseErrorFilter => "Errors exist in Filter tab";

	/// <summary>
	/// Key: "Response.GenericError"
	/// English String: "An error occurred. Please try again later."
	/// </summary>
	public virtual string ResponseGenericError => "An error occurred. Please try again later.";

	/// <summary>
	/// Key: "Response.NoItemsFound"
	/// English String: "No items found."
	/// </summary>
	public virtual string ResponseNoItemsFound => "No items found.";

	/// <summary>
	/// Key: "Response.NoSaleItemsFromSearch"
	/// English String: "Your search did not find items for sale. Unavailable items displayed below."
	/// </summary>
	public virtual string ResponseNoSaleItemsFromSearch => "Your search did not find items for sale. Unavailable items displayed below.";

	/// <summary>
	/// Key: "Response.TemporarilyUnavailable"
	/// English String: "Catalog temporarily unavailable. Please try again later."
	/// </summary>
	public virtual string ResponseTemporarilyUnavailable => "Catalog temporarily unavailable. Please try again later.";

	/// <summary>
	/// Key: "Response.Throttled"
	/// Shown to users when they have made too many requests in a minute and are being throttled.
	/// English String: "You're going too fast! Try again in a minute."
	/// </summary>
	public virtual string ResponseThrottled => "You're going too fast! Try again in a minute.";

	public CatalogResources_en_us(TranslationResourceState state)
		: base(state)
	{
		_AllKeys = new Lazy<IReadOnlyDictionary<string, string>>(() => new Dictionary<string, string>
		{
			{
				"Action.BuyRobux",
				_GetTemplateForActionBuyRobux()
			},
			{
				"Action.Dialog.AddGearOk",
				_GetTemplateForActionDialogAddGearOk()
			},
			{
				"Action.Filter.Apply",
				_GetTemplateForActionFilterApply()
			},
			{
				"Action.Filter.Cancel",
				_GetTemplateForActionFilterCancel()
			},
			{
				"Action.Go",
				_GetTemplateForActionGo()
			},
			{
				"Action.ViewAllItems",
				_GetTemplateForActionViewAllItems()
			},
			{
				"Description.Dialog.AddGearBody",
				_GetTemplateForDescriptionDialogAddGearBody()
			},
			{
				"Heading.CatalogCategory",
				_GetTemplateForHeadingCatalogCategory()
			},
			{
				"Heading.CatalogPage",
				_GetTemplateForHeadingCatalogPage()
			},
			{
				"Label.AllFeaturedItems",
				_GetTemplateForLabelAllFeaturedItems()
			},
			{
				"Label.AllGenres",
				_GetTemplateForLabelAllGenres()
			},
			{
				"Label.Amazon",
				_GetTemplateForLabelAmazon()
			},
			{
				"Label.BreadCrumb.Free",
				_GetTemplateForLabelBreadCrumbFree()
			},
			{
				"Label.BreadCrumb.GenreOrText",
				_GetTemplateForLabelBreadCrumbGenreOrText()
			},
			{
				"Label.BreadCrumb.GenreSelectedText",
				_GetTemplateForLabelBreadCrumbGenreSelectedText()
			},
			{
				"Label.BreadCrumb.Group",
				_GetTemplateForLabelBreadCrumbGroup()
			},
			{
				"Label.BreadCrumb.PriceAbove",
				_GetTemplateForLabelBreadCrumbPriceAbove()
			},
			{
				"Label.BreadCrumb.PriceBelow",
				_GetTemplateForLabelBreadCrumbPriceBelow()
			},
			{
				"Label.BreadCrumb.ResultsCount",
				_GetTemplateForLabelBreadCrumbResultsCount()
			},
			{
				"Label.Bundle",
				_GetTemplateForLabelBundle()
			},
			{
				"Label.Bundles",
				_GetTemplateForLabelBundles()
			},
			{
				"Label.ByCreatorLink",
				_GetTemplateForLabelByCreatorLink()
			},
			{
				"Label.Card.CreatorBy",
				_GetTemplateForLabelCardCreatorBy()
			},
			{
				"Label.Card.PriceWas",
				_GetTemplateForLabelCardPriceWas()
			},
			{
				"Label.Card.Remaining",
				_GetTemplateForLabelCardRemaining()
			},
			{
				"Label.CategoryAttributes",
				_GetTemplateForLabelCategoryAttributes()
			},
			{
				"Label.CategoryType",
				_GetTemplateForLabelCategoryType()
			},
			{
				"Label.CommunityCreations",
				_GetTemplateForLabelCommunityCreations()
			},
			{
				"Label.Dialog.AddGearTitle",
				_GetTemplateForLabelDialogAddGearTitle()
			},
			{
				"Label.Emotes",
				_GetTemplateForLabelEmotes()
			},
			{
				"Label.Favorites",
				_GetTemplateForLabelFavorites()
			},
			{
				"Label.FeaturedBundles",
				_GetTemplateForLabelFeaturedBundles()
			},
			{
				"Label.FeaturedEmotes",
				_GetTemplateForLabelFeaturedEmotes()
			},
			{
				"Label.FeaturedItemsOnRoblox",
				_GetTemplateForLabelFeaturedItemsOnRoblox()
			},
			{
				"Label.Filter.ByTime",
				_GetTemplateForLabelFilterByTime()
			},
			{
				"Label.Filter.Category",
				_GetTemplateForLabelFilterCategory()
			},
			{
				"Label.Filter.Creator",
				_GetTemplateForLabelFilterCreator()
			},
			{
				"Label.Filter.Filter",
				_GetTemplateForLabelFilterFilter()
			},
			{
				"Label.Filter.Filters",
				_GetTemplateForLabelFilterFilters()
			},
			{
				"Label.Filter.Genre",
				_GetTemplateForLabelFilterGenre()
			},
			{
				"Label.Filter.Hide",
				_GetTemplateForLabelFilterHide()
			},
			{
				"Label.Filter.Price",
				_GetTemplateForLabelFilterPrice()
			},
			{
				"Label.Filter.PriceMax",
				_GetTemplateForLabelFilterPriceMax()
			},
			{
				"Label.Filter.PriceMin",
				_GetTemplateForLabelFilterPriceMin()
			},
			{
				"Label.Filter.PriceTo",
				_GetTemplateForLabelFilterPriceTo()
			},
			{
				"Label.Filter.Show",
				_GetTemplateForLabelFilterShow()
			},
			{
				"Label.Filter.Sorting",
				_GetTemplateForLabelFilterSorting()
			},
			{
				"Label.Filter.UnavailableItems",
				_GetTemplateForLabelFilterUnavailableItems()
			},
			{
				"Label.GoogleOnly",
				_GetTemplateForLabelGoogleOnly()
			},
			{
				"Label.Ios",
				_GetTemplateForLabelIos()
			},
			{
				"Label.Mobile",
				_GetTemplateForLabelMobile()
			},
			{
				"Label.New",
				_GetTemplateForLabelNew()
			},
			{
				"Label.Rthro",
				_GetTemplateForLabelRthro()
			},
			{
				"Label.Sale",
				_GetTemplateForLabelSale()
			},
			{
				"Label.SearchField",
				_GetTemplateForLabelSearchField()
			},
			{
				"Label.SeeAll",
				_GetTemplateForLabelSeeAll()
			},
			{
				"Label.Username",
				_GetTemplateForLabelUsername()
			},
			{
				"Label.Xbox",
				_GetTemplateForLabelXbox()
			},
			{
				"LabelAccessories",
				_GetTemplateForLabelAccessories()
			},
			{
				"LabelAccessoryAll",
				_GetTemplateForLabelAccessoryAll()
			},
			{
				"LabelAccessoryBack",
				_GetTemplateForLabelAccessoryBack()
			},
			{
				"LabelAccessoryFace",
				_GetTemplateForLabelAccessoryFace()
			},
			{
				"LabelAccessoryFront",
				_GetTemplateForLabelAccessoryFront()
			},
			{
				"LabelAccessoryHair",
				_GetTemplateForLabelAccessoryHair()
			},
			{
				"LabelAccessoryHats",
				_GetTemplateForLabelAccessoryHats()
			},
			{
				"LabelAccessoryNeck",
				_GetTemplateForLabelAccessoryNeck()
			},
			{
				"LabelAccessoryShoulder",
				_GetTemplateForLabelAccessoryShoulder()
			},
			{
				"LabelAccessoryWaist",
				_GetTemplateForLabelAccessoryWaist()
			},
			{
				"LabelAll",
				_GetTemplateForLabelAll()
			},
			{
				"LabelAllBodyParts",
				_GetTemplateForLabelAllBodyParts()
			},
			{
				"LabelAllCategories",
				_GetTemplateForLabelAllCategories()
			},
			{
				"LabelAllClothing",
				_GetTemplateForLabelAllClothing()
			},
			{
				"LabelAllCollectibles",
				_GetTemplateForLabelAllCollectibles()
			},
			{
				"LabelAllCreators",
				_GetTemplateForLabelAllCreators()
			},
			{
				"LabelAllCurrency",
				_GetTemplateForLabelAllCurrency()
			},
			{
				"LabelAllFeatured",
				_GetTemplateForLabelAllFeatured()
			},
			{
				"LabelAllTime",
				_GetTemplateForLabelAllTime()
			},
			{
				"LabelAnimations",
				_GetTemplateForLabelAnimations()
			},
			{
				"LabelAnyPrice",
				_GetTemplateForLabelAnyPrice()
			},
			{
				"LabelAvatarAnimations",
				_GetTemplateForLabelAvatarAnimations()
			},
			{
				"LabelBestselling",
				_GetTemplateForLabelBestselling()
			},
			{
				"LabelBodyParts",
				_GetTemplateForLabelBodyParts()
			},
			{
				"LabelClothing",
				_GetTemplateForLabelClothing()
			},
			{
				"LabelCollectibleAccessories",
				_GetTemplateForLabelCollectibleAccessories()
			},
			{
				"LabelCollectibleFaces",
				_GetTemplateForLabelCollectibleFaces()
			},
			{
				"LabelCollectibleGear",
				_GetTemplateForLabelCollectibleGear()
			},
			{
				"LabelCollectibles",
				_GetTemplateForLabelCollectibles()
			},
			{
				"LabelFaces",
				_GetTemplateForLabelFaces()
			},
			{
				"LabelFeatured",
				_GetTemplateForLabelFeatured()
			},
			{
				"LabelFeaturedAccesories",
				_GetTemplateForLabelFeaturedAccesories()
			},
			{
				"LabelFeaturedAnimations",
				_GetTemplateForLabelFeaturedAnimations()
			},
			{
				"LabelFeaturedFaces",
				_GetTemplateForLabelFeaturedFaces()
			},
			{
				"LabelFeaturedGear",
				_GetTemplateForLabelFeaturedGear()
			},
			{
				"LabelFeaturedPackages",
				_GetTemplateForLabelFeaturedPackages()
			},
			{
				"LabelFree",
				_GetTemplateForLabelFree()
			},
			{
				"LabelGear",
				_GetTemplateForLabelGear()
			},
			{
				"LabelGearAll",
				_GetTemplateForLabelGearAll()
			},
			{
				"LabelGearBuilding",
				_GetTemplateForLabelGearBuilding()
			},
			{
				"LabelGearExplosive",
				_GetTemplateForLabelGearExplosive()
			},
			{
				"LabelGearMelee",
				_GetTemplateForLabelGearMelee()
			},
			{
				"LabelGearMusical",
				_GetTemplateForLabelGearMusical()
			},
			{
				"LabelGearNavigation",
				_GetTemplateForLabelGearNavigation()
			},
			{
				"LabelGearPersonalTransport",
				_GetTemplateForLabelGearPersonalTransport()
			},
			{
				"LabelGearPowerUps",
				_GetTemplateForLabelGearPowerUps()
			},
			{
				"LabelGearRanged",
				_GetTemplateForLabelGearRanged()
			},
			{
				"LabelGearSocial",
				_GetTemplateForLabelGearSocial()
			},
			{
				"LabelGenreAdventure",
				_GetTemplateForLabelGenreAdventure()
			},
			{
				"LabelGenreAll",
				_GetTemplateForLabelGenreAll()
			},
			{
				"LabelGenreBuilding",
				_GetTemplateForLabelGenreBuilding()
			},
			{
				"LabelGenreComedy",
				_GetTemplateForLabelGenreComedy()
			},
			{
				"LabelGenreFantasy",
				_GetTemplateForLabelGenreFantasy()
			},
			{
				"LabelGenreFighting",
				_GetTemplateForLabelGenreFighting()
			},
			{
				"LabelGenreFPS",
				_GetTemplateForLabelGenreFPS()
			},
			{
				"LabelGenreFunny",
				_GetTemplateForLabelGenreFunny()
			},
			{
				"LabelGenreHorror",
				_GetTemplateForLabelGenreHorror()
			},
			{
				"LabelGenreMedieval",
				_GetTemplateForLabelGenreMedieval()
			},
			{
				"LabelGenreMilitary",
				_GetTemplateForLabelGenreMilitary()
			},
			{
				"LabelGenreNaval",
				_GetTemplateForLabelGenreNaval()
			},
			{
				"LabelGenreNinja",
				_GetTemplateForLabelGenreNinja()
			},
			{
				"LabelGenrePirate",
				_GetTemplateForLabelGenrePirate()
			},
			{
				"LabelGenreRPG",
				_GetTemplateForLabelGenreRPG()
			},
			{
				"LabelGenreScary",
				_GetTemplateForLabelGenreScary()
			},
			{
				"LabelGenreSciFi",
				_GetTemplateForLabelGenreSciFi()
			},
			{
				"LabelGenreSports",
				_GetTemplateForLabelGenreSports()
			},
			{
				"LabelGenreTownAndCity",
				_GetTemplateForLabelGenreTownAndCity()
			},
			{
				"LabelGenreTutorial",
				_GetTemplateForLabelGenreTutorial()
			},
			{
				"LabelGenreWar",
				_GetTemplateForLabelGenreWar()
			},
			{
				"LabelGenreWestern",
				_GetTemplateForLabelGenreWestern()
			},
			{
				"LabelGenreWildWest",
				_GetTemplateForLabelGenreWildWest()
			},
			{
				"LabelHeads",
				_GetTemplateForLabelHeads()
			},
			{
				"LabelMostFavorited",
				_GetTemplateForLabelMostFavorited()
			},
			{
				"LabelNoResellers",
				_GetTemplateForLabelNoResellers()
			},
			{
				"LabelOffSale",
				_GetTemplateForLabelOffSale()
			},
			{
				"LabelPackages",
				_GetTemplateForLabelPackages()
			},
			{
				"LabelPants",
				_GetTemplateForLabelPants()
			},
			{
				"LabelPastDay",
				_GetTemplateForLabelPastDay()
			},
			{
				"LabelPastWeek",
				_GetTemplateForLabelPastWeek()
			},
			{
				"LabelPriceHighFirst",
				_GetTemplateForLabelPriceHighFirst()
			},
			{
				"LabelPriceLowFirst",
				_GetTemplateForLabelPriceLowFirst()
			},
			{
				"LabelRecentlyUpdated",
				_GetTemplateForLabelRecentlyUpdated()
			},
			{
				"LabelRelevance",
				_GetTemplateForLabelRelevance()
			},
			{
				"LabelRoblox",
				_GetTemplateForLabelRoblox()
			},
			{
				"LabelRobux",
				_GetTemplateForLabelRobux()
			},
			{
				"LabelShirts",
				_GetTemplateForLabelShirts()
			},
			{
				"LabelTShirts",
				_GetTemplateForLabelTShirts()
			},
			{
				"Response.Error.Filter",
				_GetTemplateForResponseErrorFilter()
			},
			{
				"Response.GenericError",
				_GetTemplateForResponseGenericError()
			},
			{
				"Response.NoItemsFound",
				_GetTemplateForResponseNoItemsFound()
			},
			{
				"Response.NoSaleItemsFromSearch",
				_GetTemplateForResponseNoSaleItemsFromSearch()
			},
			{
				"Response.TemporarilyUnavailable",
				_GetTemplateForResponseTemporarilyUnavailable()
			},
			{
				"Response.Throttled",
				_GetTemplateForResponseThrottled()
			}
		});
	}

	public IReadOnlyDictionary<string, string> GetAllKeys()
	{
		return _AllKeys.Value;
	}

	public string GetFullContentNamespaceName()
	{
		return "Feature.Catalog";
	}

	protected virtual string _GetTemplateForActionBuyRobux()
	{
		return "Buy Robux";
	}

	protected virtual string _GetTemplateForActionDialogAddGearOk()
	{
		return "OK";
	}

	protected virtual string _GetTemplateForActionFilterApply()
	{
		return "Apply";
	}

	protected virtual string _GetTemplateForActionFilterCancel()
	{
		return "Cancel";
	}

	protected virtual string _GetTemplateForActionGo()
	{
		return "Go";
	}

	protected virtual string _GetTemplateForActionViewAllItems()
	{
		return "View All Items";
	}

	protected virtual string _GetTemplateForDescriptionDialogAddGearBody()
	{
		return "To add gear to your game, find an item in the catalog and click the Add to Game button. The item will automatically be allowed in game, and you'll receive a commission on every copy sold from your game page. (You can only add gear that's for sale.)";
	}

	protected virtual string _GetTemplateForHeadingCatalogCategory()
	{
		return "Category";
	}

	protected virtual string _GetTemplateForHeadingCatalogPage()
	{
		return "Catalog";
	}

	protected virtual string _GetTemplateForLabelAllFeaturedItems()
	{
		return "View All Featured Items";
	}

	protected virtual string _GetTemplateForLabelAllGenres()
	{
		return "All Genres";
	}

	protected virtual string _GetTemplateForLabelAmazon()
	{
		return "Amazon";
	}

	protected virtual string _GetTemplateForLabelBreadCrumbFree()
	{
		return "Free";
	}

	/// <summary>
	/// Key: "Label.BreadCrumb.GenreOrText"
	/// English String: "{genreName1} or {genreName2}"
	/// </summary>
	public virtual string LabelBreadCrumbGenreOrText(string genreName1, string genreName2)
	{
		return $"{genreName1} or {genreName2}";
	}

	protected virtual string _GetTemplateForLabelBreadCrumbGenreOrText()
	{
		return "{genreName1} or {genreName2}";
	}

	/// <summary>
	/// Key: "Label.BreadCrumb.GenreSelectedText"
	/// English String: "Genre: {genreCount} selected"
	/// </summary>
	public virtual string LabelBreadCrumbGenreSelectedText(string genreCount)
	{
		return $"Genre: {genreCount} selected";
	}

	protected virtual string _GetTemplateForLabelBreadCrumbGenreSelectedText()
	{
		return "Genre: {genreCount} selected";
	}

	protected virtual string _GetTemplateForLabelBreadCrumbGroup()
	{
		return "Group:";
	}

	/// <summary>
	/// Key: "Label.BreadCrumb.PriceAbove"
	/// English String: "{price} and above"
	/// </summary>
	public virtual string LabelBreadCrumbPriceAbove(string price)
	{
		return $"{price} and above";
	}

	protected virtual string _GetTemplateForLabelBreadCrumbPriceAbove()
	{
		return "{price} and above";
	}

	/// <summary>
	/// Key: "Label.BreadCrumb.PriceBelow"
	/// English String: "{price} and below"
	/// </summary>
	public virtual string LabelBreadCrumbPriceBelow(string price)
	{
		return $"{price} and below";
	}

	protected virtual string _GetTemplateForLabelBreadCrumbPriceBelow()
	{
		return "{price} and below";
	}

	/// <summary>
	/// Key: "Label.BreadCrumb.ResultsCount"
	/// English String: "{startNumber} - {endNumber} of {resultsCount} Results"
	/// </summary>
	public virtual string LabelBreadCrumbResultsCount(string startNumber, string endNumber, string resultsCount)
	{
		return $"{startNumber} - {endNumber} of {resultsCount} Results";
	}

	protected virtual string _GetTemplateForLabelBreadCrumbResultsCount()
	{
		return "{startNumber} - {endNumber} of {resultsCount} Results";
	}

	protected virtual string _GetTemplateForLabelBundle()
	{
		return "Bundle";
	}

	protected virtual string _GetTemplateForLabelBundles()
	{
		return "Bundles";
	}

	/// <summary>
	/// Key: "Label.ByCreatorLink"
	/// Creator name in item card with link
	/// English String: "By {linkStart}{creator}{linkEnd}"
	/// </summary>
	public virtual string LabelByCreatorLink(string linkStart, string creator, string linkEnd)
	{
		return $"By {linkStart}{creator}{linkEnd}";
	}

	protected virtual string _GetTemplateForLabelByCreatorLink()
	{
		return "By {linkStart}{creator}{linkEnd}";
	}

	protected virtual string _GetTemplateForLabelCardCreatorBy()
	{
		return "By";
	}

	protected virtual string _GetTemplateForLabelCardPriceWas()
	{
		return "Was";
	}

	protected virtual string _GetTemplateForLabelCardRemaining()
	{
		return "Remaining:";
	}

	protected virtual string _GetTemplateForLabelCategoryAttributes()
	{
		return "Attributes";
	}

	protected virtual string _GetTemplateForLabelCategoryType()
	{
		return "Type";
	}

	protected virtual string _GetTemplateForLabelCommunityCreations()
	{
		return " Community Creations";
	}

	protected virtual string _GetTemplateForLabelDialogAddGearTitle()
	{
		return "Add Gear to Your Game";
	}

	protected virtual string _GetTemplateForLabelEmotes()
	{
		return "Emotes";
	}

	protected virtual string _GetTemplateForLabelFavorites()
	{
		return "Favorites";
	}

	protected virtual string _GetTemplateForLabelFeaturedBundles()
	{
		return "Featured Bundles";
	}

	protected virtual string _GetTemplateForLabelFeaturedEmotes()
	{
		return "Featured Emotes";
	}

	/// <summary>
	/// Key: "Label.FeaturedItemsOnRoblox"
	/// English String: "Featured Items on {spanStart}{roblox}{spanEnd}"
	/// </summary>
	public virtual string LabelFeaturedItemsOnRoblox(string spanStart, string roblox, string spanEnd)
	{
		return $"Featured Items on {spanStart}{roblox}{spanEnd}";
	}

	protected virtual string _GetTemplateForLabelFeaturedItemsOnRoblox()
	{
		return "Featured Items on {spanStart}{roblox}{spanEnd}";
	}

	protected virtual string _GetTemplateForLabelFilterByTime()
	{
		return "By Time";
	}

	protected virtual string _GetTemplateForLabelFilterCategory()
	{
		return "Category";
	}

	protected virtual string _GetTemplateForLabelFilterCreator()
	{
		return "Creator";
	}

	protected virtual string _GetTemplateForLabelFilterFilter()
	{
		return "Filter";
	}

	protected virtual string _GetTemplateForLabelFilterFilters()
	{
		return "Filters";
	}

	protected virtual string _GetTemplateForLabelFilterGenre()
	{
		return "Genre";
	}

	protected virtual string _GetTemplateForLabelFilterHide()
	{
		return "Hide";
	}

	protected virtual string _GetTemplateForLabelFilterPrice()
	{
		return "Price";
	}

	protected virtual string _GetTemplateForLabelFilterPriceMax()
	{
		return "Max";
	}

	protected virtual string _GetTemplateForLabelFilterPriceMin()
	{
		return "Min";
	}

	protected virtual string _GetTemplateForLabelFilterPriceTo()
	{
		return "To";
	}

	protected virtual string _GetTemplateForLabelFilterShow()
	{
		return "Show";
	}

	protected virtual string _GetTemplateForLabelFilterSorting()
	{
		return "Sorting";
	}

	protected virtual string _GetTemplateForLabelFilterUnavailableItems()
	{
		return "Unavailable Items";
	}

	protected virtual string _GetTemplateForLabelGoogleOnly()
	{
		return "Google Only";
	}

	protected virtual string _GetTemplateForLabelIos()
	{
		return "IOS";
	}

	protected virtual string _GetTemplateForLabelMobile()
	{
		return "Mobile";
	}

	protected virtual string _GetTemplateForLabelNew()
	{
		return "New";
	}

	protected virtual string _GetTemplateForLabelRthro()
	{
		return "Rthro";
	}

	protected virtual string _GetTemplateForLabelSale()
	{
		return "Sale";
	}

	protected virtual string _GetTemplateForLabelSearchField()
	{
		return "Search";
	}

	protected virtual string _GetTemplateForLabelSeeAll()
	{
		return "See All";
	}

	protected virtual string _GetTemplateForLabelUsername()
	{
		return "Username";
	}

	protected virtual string _GetTemplateForLabelXbox()
	{
		return "Xbox";
	}

	protected virtual string _GetTemplateForLabelAccessories()
	{
		return "Accessories";
	}

	protected virtual string _GetTemplateForLabelAccessoryAll()
	{
		return "All Accessories";
	}

	protected virtual string _GetTemplateForLabelAccessoryBack()
	{
		return "Back";
	}

	protected virtual string _GetTemplateForLabelAccessoryFace()
	{
		return "Face";
	}

	protected virtual string _GetTemplateForLabelAccessoryFront()
	{
		return "Front";
	}

	protected virtual string _GetTemplateForLabelAccessoryHair()
	{
		return "Hair";
	}

	protected virtual string _GetTemplateForLabelAccessoryHats()
	{
		return "Hats";
	}

	protected virtual string _GetTemplateForLabelAccessoryNeck()
	{
		return "Neck";
	}

	protected virtual string _GetTemplateForLabelAccessoryShoulder()
	{
		return "Shoulder";
	}

	protected virtual string _GetTemplateForLabelAccessoryWaist()
	{
		return "Waist";
	}

	protected virtual string _GetTemplateForLabelAll()
	{
		return "All";
	}

	protected virtual string _GetTemplateForLabelAllBodyParts()
	{
		return "All Body Parts";
	}

	protected virtual string _GetTemplateForLabelAllCategories()
	{
		return "All Categories";
	}

	protected virtual string _GetTemplateForLabelAllClothing()
	{
		return "All Clothing";
	}

	protected virtual string _GetTemplateForLabelAllCollectibles()
	{
		return "All Collectibles";
	}

	protected virtual string _GetTemplateForLabelAllCreators()
	{
		return "All Creators";
	}

	protected virtual string _GetTemplateForLabelAllCurrency()
	{
		return "All Currency";
	}

	protected virtual string _GetTemplateForLabelAllFeatured()
	{
		return "All Featured Items";
	}

	protected virtual string _GetTemplateForLabelAllTime()
	{
		return "All Time";
	}

	protected virtual string _GetTemplateForLabelAnimations()
	{
		return "Animations";
	}

	protected virtual string _GetTemplateForLabelAnyPrice()
	{
		return "Any Price";
	}

	protected virtual string _GetTemplateForLabelAvatarAnimations()
	{
		return "Avatar Animations";
	}

	protected virtual string _GetTemplateForLabelBestselling()
	{
		return "Bestselling";
	}

	protected virtual string _GetTemplateForLabelBodyParts()
	{
		return "Body Parts";
	}

	protected virtual string _GetTemplateForLabelClothing()
	{
		return "Clothing";
	}

	protected virtual string _GetTemplateForLabelCollectibleAccessories()
	{
		return "Collectible Accessories";
	}

	protected virtual string _GetTemplateForLabelCollectibleFaces()
	{
		return "Collectible Faces";
	}

	protected virtual string _GetTemplateForLabelCollectibleGear()
	{
		return "Collectible Gear";
	}

	protected virtual string _GetTemplateForLabelCollectibles()
	{
		return "Collectibles";
	}

	protected virtual string _GetTemplateForLabelFaces()
	{
		return "Faces";
	}

	protected virtual string _GetTemplateForLabelFeatured()
	{
		return "Featured";
	}

	protected virtual string _GetTemplateForLabelFeaturedAccesories()
	{
		return "Featured Accessories";
	}

	protected virtual string _GetTemplateForLabelFeaturedAnimations()
	{
		return "Featured Animations";
	}

	protected virtual string _GetTemplateForLabelFeaturedFaces()
	{
		return "Featured Faces";
	}

	protected virtual string _GetTemplateForLabelFeaturedGear()
	{
		return "Featured Gear";
	}

	protected virtual string _GetTemplateForLabelFeaturedPackages()
	{
		return "Featured Packages";
	}

	protected virtual string _GetTemplateForLabelFree()
	{
		return "Free";
	}

	protected virtual string _GetTemplateForLabelGear()
	{
		return "Gear";
	}

	protected virtual string _GetTemplateForLabelGearAll()
	{
		return "All Gear";
	}

	protected virtual string _GetTemplateForLabelGearBuilding()
	{
		return "Building";
	}

	protected virtual string _GetTemplateForLabelGearExplosive()
	{
		return "Explosive";
	}

	protected virtual string _GetTemplateForLabelGearMelee()
	{
		return "Melee";
	}

	protected virtual string _GetTemplateForLabelGearMusical()
	{
		return "Musical";
	}

	protected virtual string _GetTemplateForLabelGearNavigation()
	{
		return "Navigation";
	}

	protected virtual string _GetTemplateForLabelGearPersonalTransport()
	{
		return "Transport";
	}

	protected virtual string _GetTemplateForLabelGearPowerUps()
	{
		return "Power Up";
	}

	protected virtual string _GetTemplateForLabelGearRanged()
	{
		return "Ranged";
	}

	protected virtual string _GetTemplateForLabelGearSocial()
	{
		return "Social";
	}

	protected virtual string _GetTemplateForLabelGenreAdventure()
	{
		return "Adventure";
	}

	protected virtual string _GetTemplateForLabelGenreAll()
	{
		return "All Genres";
	}

	protected virtual string _GetTemplateForLabelGenreBuilding()
	{
		return "Building";
	}

	protected virtual string _GetTemplateForLabelGenreComedy()
	{
		return "Comedy";
	}

	protected virtual string _GetTemplateForLabelGenreFantasy()
	{
		return "Medieval";
	}

	protected virtual string _GetTemplateForLabelGenreFighting()
	{
		return "Fighting";
	}

	protected virtual string _GetTemplateForLabelGenreFPS()
	{
		return "FPS";
	}

	protected virtual string _GetTemplateForLabelGenreFunny()
	{
		return "Comedy";
	}

	protected virtual string _GetTemplateForLabelGenreHorror()
	{
		return "Horror";
	}

	protected virtual string _GetTemplateForLabelGenreMedieval()
	{
		return "Medieval";
	}

	protected virtual string _GetTemplateForLabelGenreMilitary()
	{
		return "Military";
	}

	protected virtual string _GetTemplateForLabelGenreNaval()
	{
		return "Naval";
	}

	protected virtual string _GetTemplateForLabelGenreNinja()
	{
		return "Fighting";
	}

	protected virtual string _GetTemplateForLabelGenrePirate()
	{
		return "Naval";
	}

	protected virtual string _GetTemplateForLabelGenreRPG()
	{
		return "RPG";
	}

	protected virtual string _GetTemplateForLabelGenreScary()
	{
		return "Horror";
	}

	protected virtual string _GetTemplateForLabelGenreSciFi()
	{
		return "Sci-Fi";
	}

	protected virtual string _GetTemplateForLabelGenreSports()
	{
		return "Sports";
	}

	protected virtual string _GetTemplateForLabelGenreTownAndCity()
	{
		return "Town and City";
	}

	protected virtual string _GetTemplateForLabelGenreTutorial()
	{
		return "Building";
	}

	protected virtual string _GetTemplateForLabelGenreWar()
	{
		return "Military";
	}

	protected virtual string _GetTemplateForLabelGenreWestern()
	{
		return "Western";
	}

	protected virtual string _GetTemplateForLabelGenreWildWest()
	{
		return "Western";
	}

	protected virtual string _GetTemplateForLabelHeads()
	{
		return "Heads";
	}

	protected virtual string _GetTemplateForLabelMostFavorited()
	{
		return "Most Favorited";
	}

	protected virtual string _GetTemplateForLabelNoResellers()
	{
		return "No Resellers";
	}

	protected virtual string _GetTemplateForLabelOffSale()
	{
		return "Offsale";
	}

	protected virtual string _GetTemplateForLabelPackages()
	{
		return "Packages";
	}

	protected virtual string _GetTemplateForLabelPants()
	{
		return "Pants";
	}

	protected virtual string _GetTemplateForLabelPastDay()
	{
		return "Past Day";
	}

	protected virtual string _GetTemplateForLabelPastWeek()
	{
		return "Past Week";
	}

	protected virtual string _GetTemplateForLabelPriceHighFirst()
	{
		return "Price (High to Low)";
	}

	protected virtual string _GetTemplateForLabelPriceLowFirst()
	{
		return "Price (Low to High)";
	}

	protected virtual string _GetTemplateForLabelRecentlyUpdated()
	{
		return "Recently Updated";
	}

	protected virtual string _GetTemplateForLabelRelevance()
	{
		return "Relevance";
	}

	protected virtual string _GetTemplateForLabelRoblox()
	{
		return "Roblox";
	}

	protected virtual string _GetTemplateForLabelRobux()
	{
		return "Robux";
	}

	protected virtual string _GetTemplateForLabelShirts()
	{
		return "Shirts";
	}

	protected virtual string _GetTemplateForLabelTShirts()
	{
		return "T-Shirts";
	}

	protected virtual string _GetTemplateForResponseErrorFilter()
	{
		return "Errors exist in Filter tab";
	}

	protected virtual string _GetTemplateForResponseGenericError()
	{
		return "An error occurred. Please try again later.";
	}

	protected virtual string _GetTemplateForResponseNoItemsFound()
	{
		return "No items found.";
	}

	protected virtual string _GetTemplateForResponseNoSaleItemsFromSearch()
	{
		return "Your search did not find items for sale. Unavailable items displayed below.";
	}

	protected virtual string _GetTemplateForResponseTemporarilyUnavailable()
	{
		return "Catalog temporarily unavailable. Please try again later.";
	}

	protected virtual string _GetTemplateForResponseThrottled()
	{
		return "You're going too fast! Try again in a minute.";
	}
}
