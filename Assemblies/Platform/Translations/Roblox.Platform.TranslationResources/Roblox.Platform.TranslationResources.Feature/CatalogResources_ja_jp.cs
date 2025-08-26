namespace Roblox.Platform.TranslationResources.Feature {
    /// <summary>

/// This class overrides CatalogResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class CatalogResources_ja_jp : CatalogResources_en_us, ICatalogResources, ITranslationResources
{
	/// <summary>
	/// Key: "Action.BuyRobux"
	/// English String: "Buy Robux"
	/// </summary>
	public override string ActionBuyRobux => "Robuxã‚’è²·ã†";

	/// <summary>
	/// Key: "Action.Dialog.AddGearOk"
	/// English String: "OK"
	/// </summary>
	public override string ActionDialogAddGearOk => "OK";

	/// <summary>
	/// Key: "Action.Filter.Apply"
	/// English String: "Apply"
	/// </summary>
	public override string ActionFilterApply => "é©ç”¨";

	/// <summary>
	/// Key: "Action.Filter.Cancel"
	/// English String: "Cancel"
	/// </summary>
	public override string ActionFilterCancel => "ã‚­ãƒ£ãƒ³ã‚»ãƒ«";

	/// <summary>
	/// Key: "Action.Go"
	/// English String: "Go"
	/// </summary>
	public override string ActionGo => "å®Ÿè¡Œ";

	/// <summary>
	/// Key: "Action.ViewAllItems"
	/// English String: "View All Items"
	/// </summary>
	public override string ActionViewAllItems => "ã™ã¹ã¦ã®ã‚¢ã‚¤ãƒ†ãƒ ã‚’è¡¨ç¤º";

	/// <summary>
	/// Key: "Description.Dialog.AddGearBody"
	/// English String: "To add gear to your game, find an item in the catalog and click the Add to Game button. The item will automatically be allowed in game, and you'll receive a commission on every copy sold from your game page. (You can only add gear that's for sale.)"
	/// </summary>
	public override string DescriptionDialogAddGearBody => "ã‚²ãƒ¼ãƒ ã«ã‚®ã‚¢ã‚’è¿½åŠ ã™ã‚‹ã«ã¯ã€ã‚«ã‚¿ãƒ­ã‚°ã§ã‚¢ã‚¤ãƒ†ãƒ ã‚’æŽ¢ã—ã¦ã€Œã‚²ãƒ¼ãƒ ã«è¿½åŠ ã€ãƒœã‚¿ãƒ³ã‚’ã‚¯ãƒªãƒƒã‚¯ã—ã¾ã™ã€‚ã‚¢ã‚¤ãƒ†ãƒ ã¯è‡ªå‹•çš„ã«ã‚²ãƒ¼ãƒ å†…ã§è¨±å¯ã•ã‚Œã€ã‚²ãƒ¼ãƒ ãƒšãƒ¼ã‚¸ã§ã‚¢ã‚¤ãƒ†ãƒ ãŒå£²ã‚Œã‚‹åº¦ã«å ±é…¬ã‚’å—ã‘å–ã‚‹ã“ã¨ãŒã§ãã¾ã™ã€‚ï¼ˆè¿½åŠ ã§ãã‚‹ã®ã¯è²©å£²ä¸­ã®ã‚®ã‚¢ã ã‘ã§ã™ã€‚ï¼‰";

	/// <summary>
	/// Key: "Heading.CatalogCategory"
	/// English String: "Category"
	/// </summary>
	public override string HeadingCatalogCategory => "ã‚«ãƒ†ã‚´ãƒª";

	/// <summary>
	/// Key: "Heading.CatalogPage"
	/// English String: "Catalog"
	/// </summary>
	public override string HeadingCatalogPage => "ã‚«ã‚¿ãƒ­ã‚°";

	/// <summary>
	/// Key: "Label.AllFeaturedItems"
	/// English String: "View All Featured Items"
	/// </summary>
	public override string LabelAllFeaturedItems => "ã™ã¹ã¦ã®æ³¨ç›®ã‚¢ã‚¤ãƒ†ãƒ ã‚’è¡¨ç¤º";

	/// <summary>
	/// Key: "Label.AllGenres"
	/// English String: "All Genres"
	/// </summary>
	public override string LabelAllGenres => "ã™ã¹ã¦ã®ã‚¸ãƒ£ãƒ³ãƒ«";

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
	public override string LabelBreadCrumbFree => "ç„¡æ–™";

	/// <summary>
	/// Key: "Label.BreadCrumb.Group"
	/// English String: "Group:"
	/// </summary>
	public override string LabelBreadCrumbGroup => "ã‚°ãƒ«ãƒ¼ãƒ—:";

	/// <summary>
	/// Key: "Label.Bundle"
	/// Bundle
	/// English String: "Bundle"
	/// </summary>
	public override string LabelBundle => "ãƒãƒ³ãƒ‰ãƒ«";

	/// <summary>
	/// Key: "Label.Bundles"
	/// Bundles
	/// English String: "Bundles"
	/// </summary>
	public override string LabelBundles => "ãƒãƒ³ãƒ‰ãƒ«";

	/// <summary>
	/// Key: "Label.Card.CreatorBy"
	/// English String: "By"
	/// </summary>
	public override string LabelCardCreatorBy => "ä½œ";

	/// <summary>
	/// Key: "Label.Card.PriceWas"
	/// English String: "Was"
	/// </summary>
	public override string LabelCardPriceWas => "ä»¥å‰ã®ä¾¡æ ¼";

	/// <summary>
	/// Key: "Label.Card.Remaining"
	/// English String: "Remaining:"
	/// </summary>
	public override string LabelCardRemaining => "æ®‹ã‚Š:";

	/// <summary>
	/// Key: "Label.CategoryAttributes"
	/// English String: "Attributes"
	/// </summary>
	public override string LabelCategoryAttributes => "å±žæ€§";

	/// <summary>
	/// Key: "Label.CategoryType"
	/// English String: "Type"
	/// </summary>
	public override string LabelCategoryType => "ã‚¿ã‚¤ãƒ—";

	/// <summary>
	/// Key: "Label.CommunityCreations"
	/// UGC items
	/// English String: " Community Creations"
	/// </summary>
	public override string LabelCommunityCreations => " ã‚³ãƒŸãƒ¥ãƒ‹ãƒ†ã‚£ã®ä½œå“";

	/// <summary>
	/// Key: "Label.Dialog.AddGearTitle"
	/// English String: "Add Gear to Your Game"
	/// </summary>
	public override string LabelDialogAddGearTitle => "ã‚²ãƒ¼ãƒ ã«ã‚®ã‚¢ã‚’è¿½åŠ ";

	/// <summary>
	/// Key: "Label.Emotes"
	/// Emotes
	/// English String: "Emotes"
	/// </summary>
	public override string LabelEmotes => "ã‚¨ãƒ¢ãƒ¼ãƒˆ";

	/// <summary>
	/// Key: "Label.Favorites"
	/// English String: "Favorites"
	/// </summary>
	public override string LabelFavorites => "ãŠæ°—ã«å…¥ã‚Š";

	/// <summary>
	/// Key: "Label.FeaturedBundles"
	/// Featured Bundles
	/// English String: "Featured Bundles"
	/// </summary>
	public override string LabelFeaturedBundles => "æ³¨ç›®ã®ãƒãƒ³ãƒ‰ãƒ«";

	/// <summary>
	/// Key: "Label.FeaturedEmotes"
	/// Featured Emotes
	/// English String: "Featured Emotes"
	/// </summary>
	public override string LabelFeaturedEmotes => "æ³¨ç›®ã®ã‚¨ãƒ¢ãƒ¼ãƒˆ";

	/// <summary>
	/// Key: "Label.Filter.ByTime"
	/// English String: "By Time"
	/// </summary>
	public override string LabelFilterByTime => "æ™‚é–“";

	/// <summary>
	/// Key: "Label.Filter.Category"
	/// English String: "Category"
	/// </summary>
	public override string LabelFilterCategory => "ã‚«ãƒ†ã‚´ãƒª";

	/// <summary>
	/// Key: "Label.Filter.Creator"
	/// English String: "Creator"
	/// </summary>
	public override string LabelFilterCreator => "ã‚¯ãƒªã‚¨ãƒ¼ã‚¿ãƒ¼";

	/// <summary>
	/// Key: "Label.Filter.Filter"
	/// English String: "Filter"
	/// </summary>
	public override string LabelFilterFilter => "ãƒ•ã‚£ãƒ«ã‚¿";

	/// <summary>
	/// Key: "Label.Filter.Filters"
	/// English String: "Filters"
	/// </summary>
	public override string LabelFilterFilters => "ãƒ•ã‚£ãƒ«ã‚¿";

	/// <summary>
	/// Key: "Label.Filter.Genre"
	/// English String: "Genre"
	/// </summary>
	public override string LabelFilterGenre => "ã‚¸ãƒ£ãƒ³ãƒ«";

	/// <summary>
	/// Key: "Label.Filter.Hide"
	/// English String: "Hide"
	/// </summary>
	public override string LabelFilterHide => "éžè¡¨ç¤º";

	/// <summary>
	/// Key: "Label.Filter.Price"
	/// English String: "Price"
	/// </summary>
	public override string LabelFilterPrice => "ä¾¡æ ¼";

	/// <summary>
	/// Key: "Label.Filter.PriceMax"
	/// English String: "Max"
	/// </summary>
	public override string LabelFilterPriceMax => "æœ€é«˜é¡";

	/// <summary>
	/// Key: "Label.Filter.PriceMin"
	/// English String: "Min"
	/// </summary>
	public override string LabelFilterPriceMin => "æœ€ä½Žé¡";

	/// <summary>
	/// Key: "Label.Filter.PriceTo"
	/// English String: "To"
	/// </summary>
	public override string LabelFilterPriceTo => "æ–°ã—ã„ä¾¡æ ¼";

	/// <summary>
	/// Key: "Label.Filter.Show"
	/// English String: "Show"
	/// </summary>
	public override string LabelFilterShow => "è¡¨ç¤º";

	/// <summary>
	/// Key: "Label.Filter.Sorting"
	/// English String: "Sorting"
	/// </summary>
	public override string LabelFilterSorting => "ä¸¦ã¹æ›¿ãˆ";

	/// <summary>
	/// Key: "Label.Filter.UnavailableItems"
	/// English String: "Unavailable Items"
	/// </summary>
	public override string LabelFilterUnavailableItems => "åˆ©ç”¨ã§ããªã„ã‚¢ã‚¤ãƒ†ãƒ ";

	/// <summary>
	/// Key: "Label.GoogleOnly"
	/// label
	/// English String: "Google Only"
	/// </summary>
	public override string LabelGoogleOnly => "Googleå°‚ç”¨";

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
	public override string LabelMobile => "ãƒ¢ãƒã‚¤ãƒ«";

	/// <summary>
	/// Key: "Label.New"
	/// label
	/// English String: "New"
	/// </summary>
	public override string LabelNew => "æ–°ç€";

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
	public override string LabelSale => "ã‚»ãƒ¼ãƒ«";

	/// <summary>
	/// Key: "Label.SearchField"
	/// English String: "Search"
	/// </summary>
	public override string LabelSearchField => "æ¤œç´¢";

	/// <summary>
	/// Key: "Label.SeeAll"
	/// English String: "See All"
	/// </summary>
	public override string LabelSeeAll => "ã™ã¹ã¦è¦‹ã‚‹";

	/// <summary>
	/// Key: "Label.Username"
	/// English String: "Username"
	/// </summary>
	public override string LabelUsername => "ãƒ¦ãƒ¼ã‚¶ãƒ¼ãƒãƒ¼ãƒ ";

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
	public override string LabelAccessories => "ã‚¢ã‚¯ã‚»ã‚µãƒª";

	/// <summary>
	/// Key: "LabelAccessoryAll"
	/// English String: "All Accessories"
	/// </summary>
	public override string LabelAccessoryAll => "ã™ã¹ã¦ã®ã‚¢ã‚¯ã‚»ã‚µãƒª";

	/// <summary>
	/// Key: "LabelAccessoryBack"
	/// English String: "Back"
	/// </summary>
	public override string LabelAccessoryBack => "èƒŒé¢";

	/// <summary>
	/// Key: "LabelAccessoryFace"
	/// English String: "Face"
	/// </summary>
	public override string LabelAccessoryFace => "é¡”";

	/// <summary>
	/// Key: "LabelAccessoryFront"
	/// English String: "Front"
	/// </summary>
	public override string LabelAccessoryFront => "æ­£é¢";

	/// <summary>
	/// Key: "LabelAccessoryHair"
	/// English String: "Hair"
	/// </summary>
	public override string LabelAccessoryHair => "é«ª";

	/// <summary>
	/// Key: "LabelAccessoryHats"
	/// English String: "Hats"
	/// </summary>
	public override string LabelAccessoryHats => "å¸½å­";

	/// <summary>
	/// Key: "LabelAccessoryNeck"
	/// English String: "Neck"
	/// </summary>
	public override string LabelAccessoryNeck => "é¦–";

	/// <summary>
	/// Key: "LabelAccessoryShoulder"
	/// English String: "Shoulder"
	/// </summary>
	public override string LabelAccessoryShoulder => "è‚©";

	/// <summary>
	/// Key: "LabelAccessoryWaist"
	/// English String: "Waist"
	/// </summary>
	public override string LabelAccessoryWaist => "è…°";

	/// <summary>
	/// Key: "LabelAll"
	/// English String: "All"
	/// </summary>
	public override string LabelAll => "ã™ã¹ã¦";

	/// <summary>
	/// Key: "LabelAllBodyParts"
	/// English String: "All Body Parts"
	/// </summary>
	public override string LabelAllBodyParts => "ã™ã¹ã¦ã®ãƒœãƒ‡ã‚£ãƒ‘ãƒ¼ãƒ„";

	/// <summary>
	/// Key: "LabelAllCategories"
	/// English String: "All Categories"
	/// </summary>
	public override string LabelAllCategories => "ã™ã¹ã¦ã®ã‚«ãƒ†ã‚´ãƒª";

	/// <summary>
	/// Key: "LabelAllClothing"
	/// English String: "All Clothing"
	/// </summary>
	public override string LabelAllClothing => "ã™ã¹ã¦ã®ã‚³ã‚¹ãƒãƒ¥ãƒ¼ãƒ ";

	/// <summary>
	/// Key: "LabelAllCollectibles"
	/// English String: "All Collectibles"
	/// </summary>
	public override string LabelAllCollectibles => "ã™ã¹ã¦ã®ã‚³ãƒ¬ã‚¯ã‚¿ãƒ–ãƒ«";

	/// <summary>
	/// Key: "LabelAllCreators"
	/// English String: "All Creators"
	/// </summary>
	public override string LabelAllCreators => "ã™ã¹ã¦ã®ã‚¯ãƒªã‚¨ãƒ¼ã‚¿ãƒ¼";

	/// <summary>
	/// Key: "LabelAllCurrency"
	/// English String: "All Currency"
	/// </summary>
	public override string LabelAllCurrency => "ã™ã¹ã¦ã®é€šè²¨";

	/// <summary>
	/// Key: "LabelAllFeatured"
	/// English String: "All Featured Items"
	/// </summary>
	public override string LabelAllFeatured => "ã™ã¹ã¦ã®æ³¨ç›®ã‚¢ã‚¤ãƒ†ãƒ ";

	/// <summary>
	/// Key: "LabelAllTime"
	/// English String: "All Time"
	/// </summary>
	public override string LabelAllTime => "é€šç®—";

	/// <summary>
	/// Key: "LabelAnimations"
	/// English String: "Animations"
	/// </summary>
	public override string LabelAnimations => "ã‚¢ãƒ‹ãƒ¡ãƒ¼ã‚·ãƒ§ãƒ³";

	/// <summary>
	/// Key: "LabelAnyPrice"
	/// English String: "Any Price"
	/// </summary>
	public override string LabelAnyPrice => "ä¾¡æ ¼æŒ‡å®šãªã—";

	/// <summary>
	/// Key: "LabelAvatarAnimations"
	/// English String: "Avatar Animations"
	/// </summary>
	public override string LabelAvatarAnimations => "ã‚¢ãƒã‚¿ãƒ¼ã‚¢ãƒ‹ãƒ¡";

	/// <summary>
	/// Key: "LabelBestselling"
	/// English String: "Bestselling"
	/// </summary>
	public override string LabelBestselling => "ãƒ™ã‚¹ãƒˆã‚»ãƒ©ãƒ¼";

	/// <summary>
	/// Key: "LabelBodyParts"
	/// English String: "Body Parts"
	/// </summary>
	public override string LabelBodyParts => "ãƒœãƒ‡ã‚£ãƒ‘ãƒ¼ãƒ„";

	/// <summary>
	/// Key: "LabelClothing"
	/// English String: "Clothing"
	/// </summary>
	public override string LabelClothing => "ã‚³ã‚¹ãƒãƒ¥ãƒ¼ãƒ ";

	/// <summary>
	/// Key: "LabelCollectibleAccessories"
	/// English String: "Collectible Accessories"
	/// </summary>
	public override string LabelCollectibleAccessories => "ã‚³ãƒ¬ã‚¯ã‚¿ãƒ–ãƒ«ã‚¢ã‚¯ã‚»ã‚µãƒª";

	/// <summary>
	/// Key: "LabelCollectibleFaces"
	/// English String: "Collectible Faces"
	/// </summary>
	public override string LabelCollectibleFaces => "ã‚³ãƒ¬ã‚¯ã‚¿ãƒ–ãƒ«ã®é¡”";

	/// <summary>
	/// Key: "LabelCollectibleGear"
	/// English String: "Collectible Gear"
	/// </summary>
	public override string LabelCollectibleGear => "ã‚³ãƒ¬ã‚¯ã‚¿ãƒ–ãƒ«ã‚®ã‚¢";

	/// <summary>
	/// Key: "LabelCollectibles"
	/// English String: "Collectibles"
	/// </summary>
	public override string LabelCollectibles => "ã‚³ãƒ¬ã‚¯ã‚¿ãƒ–ãƒ«";

	/// <summary>
	/// Key: "LabelFaces"
	/// English String: "Faces"
	/// </summary>
	public override string LabelFaces => "é¡”";

	/// <summary>
	/// Key: "LabelFeatured"
	/// English String: "Featured"
	/// </summary>
	public override string LabelFeatured => "æ³¨ç›®";

	/// <summary>
	/// Key: "LabelFeaturedAccesories"
	/// English String: "Featured Accessories"
	/// </summary>
	public override string LabelFeaturedAccesories => "æ³¨ç›®ã®ã‚¢ã‚¯ã‚»ã‚µãƒª";

	/// <summary>
	/// Key: "LabelFeaturedAnimations"
	/// English String: "Featured Animations"
	/// </summary>
	public override string LabelFeaturedAnimations => "æ³¨ç›®ã®ã‚¢ãƒ‹ãƒ¡ãƒ¼ã‚·ãƒ§ãƒ³";

	/// <summary>
	/// Key: "LabelFeaturedFaces"
	/// English String: "Featured Faces"
	/// </summary>
	public override string LabelFeaturedFaces => "æ³¨ç›®ã®é¡”";

	/// <summary>
	/// Key: "LabelFeaturedGear"
	/// English String: "Featured Gear"
	/// </summary>
	public override string LabelFeaturedGear => "æ³¨ç›®ã®ã‚®ã‚¢";

	/// <summary>
	/// Key: "LabelFeaturedPackages"
	/// English String: "Featured Packages"
	/// </summary>
	public override string LabelFeaturedPackages => "æ³¨ç›®ã®ãƒ‘ãƒƒã‚±ãƒ¼ã‚¸";

	/// <summary>
	/// Key: "LabelFree"
	/// English String: "Free"
	/// </summary>
	public override string LabelFree => "ç„¡æ–™";

	/// <summary>
	/// Key: "LabelGear"
	/// English String: "Gear"
	/// </summary>
	public override string LabelGear => "ã‚®ã‚¢";

	/// <summary>
	/// Key: "LabelGearAll"
	/// English String: "All Gear"
	/// </summary>
	public override string LabelGearAll => "ã™ã¹ã¦ã®ã‚®ã‚¢";

	/// <summary>
	/// Key: "LabelGearBuilding"
	/// English String: "Building"
	/// </summary>
	public override string LabelGearBuilding => "å»ºç¯‰";

	/// <summary>
	/// Key: "LabelGearExplosive"
	/// English String: "Explosive"
	/// </summary>
	public override string LabelGearExplosive => "çˆ†ç™ºç‰©";

	/// <summary>
	/// Key: "LabelGearMelee"
	/// English String: "Melee"
	/// </summary>
	public override string LabelGearMelee => "ãƒ¡ãƒ¬ãƒ¼";

	/// <summary>
	/// Key: "LabelGearMusical"
	/// English String: "Musical"
	/// </summary>
	public override string LabelGearMusical => "éŸ³æ¥½";

	/// <summary>
	/// Key: "LabelGearNavigation"
	/// English String: "Navigation"
	/// </summary>
	public override string LabelGearNavigation => "ãƒŠãƒ“ã‚²ãƒ¼ã‚·ãƒ§ãƒ³";

	/// <summary>
	/// Key: "LabelGearPersonalTransport"
	/// English String: "Transport"
	/// </summary>
	public override string LabelGearPersonalTransport => "ä¹—ã‚Šç‰©";

	/// <summary>
	/// Key: "LabelGearPowerUps"
	/// English String: "Power Up"
	/// </summary>
	public override string LabelGearPowerUps => "ãƒ‘ãƒ¯ãƒ¼ã‚¢ãƒƒãƒ—";

	/// <summary>
	/// Key: "LabelGearRanged"
	/// English String: "Ranged"
	/// </summary>
	public override string LabelGearRanged => "é è·é›¢";

	/// <summary>
	/// Key: "LabelGearSocial"
	/// English String: "Social"
	/// </summary>
	public override string LabelGearSocial => "ã‚½ãƒ¼ã‚·ãƒ£ãƒ«";

	/// <summary>
	/// Key: "LabelGenreAdventure"
	/// English String: "Adventure"
	/// </summary>
	public override string LabelGenreAdventure => "ã‚¢ãƒ‰ãƒ™ãƒ³ãƒãƒ£ãƒ¼";

	/// <summary>
	/// Key: "LabelGenreAll"
	/// English String: "All Genres"
	/// </summary>
	public override string LabelGenreAll => "ã™ã¹ã¦ã®ã‚¸ãƒ£ãƒ³ãƒ«";

	/// <summary>
	/// Key: "LabelGenreBuilding"
	/// English String: "Building"
	/// </summary>
	public override string LabelGenreBuilding => "å»ºç¯‰";

	/// <summary>
	/// Key: "LabelGenreComedy"
	/// English String: "Comedy"
	/// </summary>
	public override string LabelGenreComedy => "ã‚³ãƒ¡ãƒ‡ã‚£";

	/// <summary>
	/// Key: "LabelGenreFantasy"
	/// English String: "Medieval"
	/// </summary>
	public override string LabelGenreFantasy => "ä¸­ä¸–";

	/// <summary>
	/// Key: "LabelGenreFighting"
	/// English String: "Fighting"
	/// </summary>
	public override string LabelGenreFighting => "æ ¼é—˜";

	/// <summary>
	/// Key: "LabelGenreFPS"
	/// English String: "FPS"
	/// </summary>
	public override string LabelGenreFPS => "FPS";

	/// <summary>
	/// Key: "LabelGenreFunny"
	/// English String: "Comedy"
	/// </summary>
	public override string LabelGenreFunny => "ã‚³ãƒ¡ãƒ‡ã‚£";

	/// <summary>
	/// Key: "LabelGenreHorror"
	/// English String: "Horror"
	/// </summary>
	public override string LabelGenreHorror => "ãƒ›ãƒ©ãƒ¼";

	/// <summary>
	/// Key: "LabelGenreMedieval"
	/// English String: "Medieval"
	/// </summary>
	public override string LabelGenreMedieval => "ä¸­ä¸–";

	/// <summary>
	/// Key: "LabelGenreMilitary"
	/// English String: "Military"
	/// </summary>
	public override string LabelGenreMilitary => "ãƒŸãƒªã‚¿ãƒªãƒ¼";

	/// <summary>
	/// Key: "LabelGenreNaval"
	/// English String: "Naval"
	/// </summary>
	public override string LabelGenreNaval => "æµ·è»";

	/// <summary>
	/// Key: "LabelGenreNinja"
	/// English String: "Fighting"
	/// </summary>
	public override string LabelGenreNinja => "æ ¼é—˜";

	/// <summary>
	/// Key: "LabelGenrePirate"
	/// English String: "Naval"
	/// </summary>
	public override string LabelGenrePirate => "æµ·è»";

	/// <summary>
	/// Key: "LabelGenreRPG"
	/// English String: "RPG"
	/// </summary>
	public override string LabelGenreRPG => "RPG";

	/// <summary>
	/// Key: "LabelGenreScary"
	/// English String: "Horror"
	/// </summary>
	public override string LabelGenreScary => "ãƒ›ãƒ©ãƒ¼";

	/// <summary>
	/// Key: "LabelGenreSciFi"
	/// English String: "Sci-Fi"
	/// </summary>
	public override string LabelGenreSciFi => "SF";

	/// <summary>
	/// Key: "LabelGenreSports"
	/// English String: "Sports"
	/// </summary>
	public override string LabelGenreSports => "ã‚¹ãƒãƒ¼ãƒ„";

	/// <summary>
	/// Key: "LabelGenreTownAndCity"
	/// English String: "Town and City"
	/// </summary>
	public override string LabelGenreTownAndCity => "éƒ½å¸‚é–‹ç™º";

	/// <summary>
	/// Key: "LabelGenreTutorial"
	/// English String: "Building"
	/// </summary>
	public override string LabelGenreTutorial => "å»ºç¯‰";

	/// <summary>
	/// Key: "LabelGenreWar"
	/// English String: "Military"
	/// </summary>
	public override string LabelGenreWar => "ãƒŸãƒªã‚¿ãƒªãƒ¼";

	/// <summary>
	/// Key: "LabelGenreWestern"
	/// English String: "Western"
	/// </summary>
	public override string LabelGenreWestern => "ã‚¦ã‚¨ã‚¹ã‚¿ãƒ³";

	/// <summary>
	/// Key: "LabelGenreWildWest"
	/// English String: "Western"
	/// </summary>
	public override string LabelGenreWildWest => "ã‚¦ã‚¨ã‚¹ã‚¿ãƒ³";

	/// <summary>
	/// Key: "LabelHeads"
	/// English String: "Heads"
	/// </summary>
	public override string LabelHeads => "é ­";

	/// <summary>
	/// Key: "LabelMostFavorited"
	/// English String: "Most Favorited"
	/// </summary>
	public override string LabelMostFavorited => "ä¸€ç•ªäººæ°—";

	/// <summary>
	/// Key: "LabelNoResellers"
	/// English String: "No Resellers"
	/// </summary>
	public override string LabelNoResellers => "å†è²©è€…ãªã—";

	/// <summary>
	/// Key: "LabelOffSale"
	/// English String: "Offsale"
	/// </summary>
	public override string LabelOffSale => "éžå£²å“";

	/// <summary>
	/// Key: "LabelPackages"
	/// English String: "Packages"
	/// </summary>
	public override string LabelPackages => "ãƒ‘ãƒƒã‚±ãƒ¼ã‚¸";

	/// <summary>
	/// Key: "LabelPants"
	/// English String: "Pants"
	/// </summary>
	public override string LabelPants => "ãƒ‘ãƒ³ãƒ„";

	/// <summary>
	/// Key: "LabelPastDay"
	/// English String: "Past Day"
	/// </summary>
	public override string LabelPastDay => "æ˜¨æ—¥";

	/// <summary>
	/// Key: "LabelPastWeek"
	/// English String: "Past Week"
	/// </summary>
	public override string LabelPastWeek => "å…ˆé€±";

	/// <summary>
	/// Key: "LabelPriceHighFirst"
	/// English String: "Price (High to Low)"
	/// </summary>
	public override string LabelPriceHighFirst => "ä¾¡æ ¼ï¼ˆé«˜ã„é †ï¼‰";

	/// <summary>
	/// Key: "LabelPriceLowFirst"
	/// English String: "Price (Low to High)"
	/// </summary>
	public override string LabelPriceLowFirst => "ä¾¡æ ¼ï¼ˆå®‰ã„é †ï¼‰";

	/// <summary>
	/// Key: "LabelRecentlyUpdated"
	/// English String: "Recently Updated"
	/// </summary>
	public override string LabelRecentlyUpdated => "æœ€è¿‘ã‚¢ãƒƒãƒ—ãƒ‡ãƒ¼ãƒˆ";

	/// <summary>
	/// Key: "LabelRelevance"
	/// English String: "Relevance"
	/// </summary>
	public override string LabelRelevance => "ä¸¦ã¹æ›¿ãˆ";

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
	public override string LabelShirts => "ã‚·ãƒ£ãƒ„";

	/// <summary>
	/// Key: "LabelTShirts"
	/// English String: "T-Shirts"
	/// </summary>
	public override string LabelTShirts => "Tã‚·ãƒ£ãƒ„";

	/// <summary>
	/// Key: "Response.Error.Filter"
	/// English String: "Errors exist in Filter tab"
	/// </summary>
	public override string ResponseErrorFilter => "ãƒ•ã‚£ãƒ«ã‚¿ã‚¿ãƒ–ã«ã‚¨ãƒ©ãƒ¼ãŒã‚ã‚Šã¾ã™";

	/// <summary>
	/// Key: "Response.GenericError"
	/// English String: "An error occurred. Please try again later."
	/// </summary>
	public override string ResponseGenericError => "ã‚¨ãƒ©ãƒ¼ãŒç™ºç”Ÿã—ã¾ã—ãŸã€‚å¾Œã§ã‚‚ã†ä¸€åº¦ãŠè©¦ã—ãã ã•ã„ã€‚";

	/// <summary>
	/// Key: "Response.NoItemsFound"
	/// English String: "No items found."
	/// </summary>
	public override string ResponseNoItemsFound => "ã‚¢ã‚¤ãƒ†ãƒ ãŒè¦‹ã¤ã‹ã‚Šã¾ã›ã‚“ã€‚";

	/// <summary>
	/// Key: "Response.NoSaleItemsFromSearch"
	/// English String: "Your search did not find items for sale. Unavailable items displayed below."
	/// </summary>
	public override string ResponseNoSaleItemsFromSearch => "æ¤œç´¢ã—ã¾ã—ãŸãŒã€è²©å£²ä¸­ã®ã‚¢ã‚¤ãƒ†ãƒ ãŒè¦‹ã¤ã‹ã‚Šã¾ã›ã‚“ã§ã—ãŸã€‚åˆ©ç”¨ã§ããªã„ã‚¢ã‚¤ãƒ†ãƒ ãŒä»¥ä¸‹ã«è¡¨ç¤ºã•ã‚Œã¾ã™ã€‚";

	/// <summary>
	/// Key: "Response.TemporarilyUnavailable"
	/// English String: "Catalog temporarily unavailable. Please try again later."
	/// </summary>
	public override string ResponseTemporarilyUnavailable => "ã‚«ã‚¿ãƒ­ã‚°ã¯ä¸€æ™‚çš„ã«åˆ©ç”¨ã§ãã¾ã›ã‚“ã€‚å¾Œã§ã‚‚ã†ä¸€åº¦ãŠè©¦ã—ãã ã•ã„ã€‚";

	/// <summary>
	/// Key: "Response.Throttled"
	/// Shown to users when they have made too many requests in a minute and are being throttled.
	/// English String: "You're going too fast! Try again in a minute."
	/// </summary>
	public override string ResponseThrottled => "ãƒªã‚¯ã‚¨ã‚¹ãƒˆã®é–“éš”ãŒçŸ­ã™ãŽã¾ã™ã€‚1åˆ†å¾Œã«ã‚‚ã†ä¸€åº¦ãŠè©¦ã—ãã ã•ã„ã€‚";

	public CatalogResources_ja_jp(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionBuyRobux()
	{
		return "Robuxã‚’è²·ã†";
	}

	protected override string _GetTemplateForActionDialogAddGearOk()
	{
		return "OK";
	}

	protected override string _GetTemplateForActionFilterApply()
	{
		return "é©ç”¨";
	}

	protected override string _GetTemplateForActionFilterCancel()
	{
		return "ã‚­ãƒ£ãƒ³ã‚»ãƒ«";
	}

	protected override string _GetTemplateForActionGo()
	{
		return "å®Ÿè¡Œ";
	}

	protected override string _GetTemplateForActionViewAllItems()
	{
		return "ã™ã¹ã¦ã®ã‚¢ã‚¤ãƒ†ãƒ ã‚’è¡¨ç¤º";
	}

	protected override string _GetTemplateForDescriptionDialogAddGearBody()
	{
		return "ã‚²ãƒ¼ãƒ ã«ã‚®ã‚¢ã‚’è¿½åŠ ã™ã‚‹ã«ã¯ã€ã‚«ã‚¿ãƒ­ã‚°ã§ã‚¢ã‚¤ãƒ†ãƒ ã‚’æŽ¢ã—ã¦ã€Œã‚²ãƒ¼ãƒ ã«è¿½åŠ ã€ãƒœã‚¿ãƒ³ã‚’ã‚¯ãƒªãƒƒã‚¯ã—ã¾ã™ã€‚ã‚¢ã‚¤ãƒ†ãƒ ã¯è‡ªå‹•çš„ã«ã‚²ãƒ¼ãƒ å†…ã§è¨±å¯ã•ã‚Œã€ã‚²ãƒ¼ãƒ ãƒšãƒ¼ã‚¸ã§ã‚¢ã‚¤ãƒ†ãƒ ãŒå£²ã‚Œã‚‹åº¦ã«å ±é…¬ã‚’å—ã‘å–ã‚‹ã“ã¨ãŒã§ãã¾ã™ã€‚ï¼ˆè¿½åŠ ã§ãã‚‹ã®ã¯è²©å£²ä¸­ã®ã‚®ã‚¢ã ã‘ã§ã™ã€‚ï¼‰";
	}

	protected override string _GetTemplateForHeadingCatalogCategory()
	{
		return "ã‚«ãƒ†ã‚´ãƒª";
	}

	protected override string _GetTemplateForHeadingCatalogPage()
	{
		return "ã‚«ã‚¿ãƒ­ã‚°";
	}

	protected override string _GetTemplateForLabelAllFeaturedItems()
	{
		return "ã™ã¹ã¦ã®æ³¨ç›®ã‚¢ã‚¤ãƒ†ãƒ ã‚’è¡¨ç¤º";
	}

	protected override string _GetTemplateForLabelAllGenres()
	{
		return "ã™ã¹ã¦ã®ã‚¸ãƒ£ãƒ³ãƒ«";
	}

	protected override string _GetTemplateForLabelAmazon()
	{
		return "Amazon";
	}

	protected override string _GetTemplateForLabelBreadCrumbFree()
	{
		return "ç„¡æ–™";
	}

	/// <summary>
	/// Key: "Label.BreadCrumb.GenreOrText"
	/// English String: "{genreName1} or {genreName2}"
	/// </summary>
	public override string LabelBreadCrumbGenreOrText(string genreName1, string genreName2)
	{
		return $"{genreName1} ã¾ãŸã¯ {genreName2}";
	}

	protected override string _GetTemplateForLabelBreadCrumbGenreOrText()
	{
		return "{genreName1} ã¾ãŸã¯ {genreName2}";
	}

	/// <summary>
	/// Key: "Label.BreadCrumb.GenreSelectedText"
	/// English String: "Genre: {genreCount} selected"
	/// </summary>
	public override string LabelBreadCrumbGenreSelectedText(string genreCount)
	{
		return $"ã‚¸ãƒ£ãƒ³ãƒ«: {genreCount} ã‚’é¸æŠž";
	}

	protected override string _GetTemplateForLabelBreadCrumbGenreSelectedText()
	{
		return "ã‚¸ãƒ£ãƒ³ãƒ«: {genreCount} ã‚’é¸æŠž";
	}

	protected override string _GetTemplateForLabelBreadCrumbGroup()
	{
		return "ã‚°ãƒ«ãƒ¼ãƒ—:";
	}

	/// <summary>
	/// Key: "Label.BreadCrumb.PriceAbove"
	/// English String: "{price} and above"
	/// </summary>
	public override string LabelBreadCrumbPriceAbove(string price)
	{
		return $"{price}ä»¥ä¸Š";
	}

	protected override string _GetTemplateForLabelBreadCrumbPriceAbove()
	{
		return "{price}ä»¥ä¸Š";
	}

	/// <summary>
	/// Key: "Label.BreadCrumb.PriceBelow"
	/// English String: "{price} and below"
	/// </summary>
	public override string LabelBreadCrumbPriceBelow(string price)
	{
		return $"{price}ä»¥ä¸‹";
	}

	protected override string _GetTemplateForLabelBreadCrumbPriceBelow()
	{
		return "{price}ä»¥ä¸‹";
	}

	/// <summary>
	/// Key: "Label.BreadCrumb.ResultsCount"
	/// English String: "{startNumber} - {endNumber} of {resultsCount} Results"
	/// </summary>
	public override string LabelBreadCrumbResultsCount(string startNumber, string endNumber, string resultsCount)
	{
		return $"{resultsCount}ä¸­{startNumber} - {endNumber}ã®çµæžœ";
	}

	protected override string _GetTemplateForLabelBreadCrumbResultsCount()
	{
		return "{resultsCount}ä¸­{startNumber} - {endNumber}ã®çµæžœ";
	}

	protected override string _GetTemplateForLabelBundle()
	{
		return "ãƒãƒ³ãƒ‰ãƒ«";
	}

	protected override string _GetTemplateForLabelBundles()
	{
		return "ãƒãƒ³ãƒ‰ãƒ«";
	}

	/// <summary>
	/// Key: "Label.ByCreatorLink"
	/// Creator name in item card with link
	/// English String: "By {linkStart}{creator}{linkEnd}"
	/// </summary>
	public override string LabelByCreatorLink(string linkStart, string creator, string linkEnd)
	{
		return $"ä½œï¼š {linkStart}{creator}{linkEnd}";
	}

	protected override string _GetTemplateForLabelByCreatorLink()
	{
		return "ä½œï¼š {linkStart}{creator}{linkEnd}";
	}

	protected override string _GetTemplateForLabelCardCreatorBy()
	{
		return "ä½œ";
	}

	protected override string _GetTemplateForLabelCardPriceWas()
	{
		return "ä»¥å‰ã®ä¾¡æ ¼";
	}

	protected override string _GetTemplateForLabelCardRemaining()
	{
		return "æ®‹ã‚Š:";
	}

	protected override string _GetTemplateForLabelCategoryAttributes()
	{
		return "å±žæ€§";
	}

	protected override string _GetTemplateForLabelCategoryType()
	{
		return "ã‚¿ã‚¤ãƒ—";
	}

	protected override string _GetTemplateForLabelCommunityCreations()
	{
		return " ã‚³ãƒŸãƒ¥ãƒ‹ãƒ†ã‚£ã®ä½œå“";
	}

	protected override string _GetTemplateForLabelDialogAddGearTitle()
	{
		return "ã‚²ãƒ¼ãƒ ã«ã‚®ã‚¢ã‚’è¿½åŠ ";
	}

	protected override string _GetTemplateForLabelEmotes()
	{
		return "ã‚¨ãƒ¢ãƒ¼ãƒˆ";
	}

	protected override string _GetTemplateForLabelFavorites()
	{
		return "ãŠæ°—ã«å…¥ã‚Š";
	}

	protected override string _GetTemplateForLabelFeaturedBundles()
	{
		return "æ³¨ç›®ã®ãƒãƒ³ãƒ‰ãƒ«";
	}

	protected override string _GetTemplateForLabelFeaturedEmotes()
	{
		return "æ³¨ç›®ã®ã‚¨ãƒ¢ãƒ¼ãƒˆ";
	}

	/// <summary>
	/// Key: "Label.FeaturedItemsOnRoblox"
	/// English String: "Featured Items on {spanStart}{roblox}{spanEnd}"
	/// </summary>
	public override string LabelFeaturedItemsOnRoblox(string spanStart, string roblox, string spanEnd)
	{
		return $"{spanStart}{roblox}{spanEnd} ã®æ³¨ç›®ã‚¢ã‚¤ãƒ†ãƒ ";
	}

	protected override string _GetTemplateForLabelFeaturedItemsOnRoblox()
	{
		return "{spanStart}{roblox}{spanEnd} ã®æ³¨ç›®ã‚¢ã‚¤ãƒ†ãƒ ";
	}

	protected override string _GetTemplateForLabelFilterByTime()
	{
		return "æ™‚é–“";
	}

	protected override string _GetTemplateForLabelFilterCategory()
	{
		return "ã‚«ãƒ†ã‚´ãƒª";
	}

	protected override string _GetTemplateForLabelFilterCreator()
	{
		return "ã‚¯ãƒªã‚¨ãƒ¼ã‚¿ãƒ¼";
	}

	protected override string _GetTemplateForLabelFilterFilter()
	{
		return "ãƒ•ã‚£ãƒ«ã‚¿";
	}

	protected override string _GetTemplateForLabelFilterFilters()
	{
		return "ãƒ•ã‚£ãƒ«ã‚¿";
	}

	protected override string _GetTemplateForLabelFilterGenre()
	{
		return "ã‚¸ãƒ£ãƒ³ãƒ«";
	}

	protected override string _GetTemplateForLabelFilterHide()
	{
		return "éžè¡¨ç¤º";
	}

	protected override string _GetTemplateForLabelFilterPrice()
	{
		return "ä¾¡æ ¼";
	}

	protected override string _GetTemplateForLabelFilterPriceMax()
	{
		return "æœ€é«˜é¡";
	}

	protected override string _GetTemplateForLabelFilterPriceMin()
	{
		return "æœ€ä½Žé¡";
	}

	protected override string _GetTemplateForLabelFilterPriceTo()
	{
		return "æ–°ã—ã„ä¾¡æ ¼";
	}

	protected override string _GetTemplateForLabelFilterShow()
	{
		return "è¡¨ç¤º";
	}

	protected override string _GetTemplateForLabelFilterSorting()
	{
		return "ä¸¦ã¹æ›¿ãˆ";
	}

	protected override string _GetTemplateForLabelFilterUnavailableItems()
	{
		return "åˆ©ç”¨ã§ããªã„ã‚¢ã‚¤ãƒ†ãƒ ";
	}

	protected override string _GetTemplateForLabelGoogleOnly()
	{
		return "Googleå°‚ç”¨";
	}

	protected override string _GetTemplateForLabelIos()
	{
		return "iOS";
	}

	protected override string _GetTemplateForLabelMobile()
	{
		return "ãƒ¢ãƒã‚¤ãƒ«";
	}

	protected override string _GetTemplateForLabelNew()
	{
		return "æ–°ç€";
	}

	protected override string _GetTemplateForLabelRthro()
	{
		return "Rthro";
	}

	protected override string _GetTemplateForLabelSale()
	{
		return "ã‚»ãƒ¼ãƒ«";
	}

	protected override string _GetTemplateForLabelSearchField()
	{
		return "æ¤œç´¢";
	}

	protected override string _GetTemplateForLabelSeeAll()
	{
		return "ã™ã¹ã¦è¦‹ã‚‹";
	}

	protected override string _GetTemplateForLabelUsername()
	{
		return "ãƒ¦ãƒ¼ã‚¶ãƒ¼ãƒãƒ¼ãƒ ";
	}

	protected override string _GetTemplateForLabelXbox()
	{
		return "Xbox";
	}

	protected override string _GetTemplateForLabelAccessories()
	{
		return "ã‚¢ã‚¯ã‚»ã‚µãƒª";
	}

	protected override string _GetTemplateForLabelAccessoryAll()
	{
		return "ã™ã¹ã¦ã®ã‚¢ã‚¯ã‚»ã‚µãƒª";
	}

	protected override string _GetTemplateForLabelAccessoryBack()
	{
		return "èƒŒé¢";
	}

	protected override string _GetTemplateForLabelAccessoryFace()
	{
		return "é¡”";
	}

	protected override string _GetTemplateForLabelAccessoryFront()
	{
		return "æ­£é¢";
	}

	protected override string _GetTemplateForLabelAccessoryHair()
	{
		return "é«ª";
	}

	protected override string _GetTemplateForLabelAccessoryHats()
	{
		return "å¸½å­";
	}

	protected override string _GetTemplateForLabelAccessoryNeck()
	{
		return "é¦–";
	}

	protected override string _GetTemplateForLabelAccessoryShoulder()
	{
		return "è‚©";
	}

	protected override string _GetTemplateForLabelAccessoryWaist()
	{
		return "è…°";
	}

	protected override string _GetTemplateForLabelAll()
	{
		return "ã™ã¹ã¦";
	}

	protected override string _GetTemplateForLabelAllBodyParts()
	{
		return "ã™ã¹ã¦ã®ãƒœãƒ‡ã‚£ãƒ‘ãƒ¼ãƒ„";
	}

	protected override string _GetTemplateForLabelAllCategories()
	{
		return "ã™ã¹ã¦ã®ã‚«ãƒ†ã‚´ãƒª";
	}

	protected override string _GetTemplateForLabelAllClothing()
	{
		return "ã™ã¹ã¦ã®ã‚³ã‚¹ãƒãƒ¥ãƒ¼ãƒ ";
	}

	protected override string _GetTemplateForLabelAllCollectibles()
	{
		return "ã™ã¹ã¦ã®ã‚³ãƒ¬ã‚¯ã‚¿ãƒ–ãƒ«";
	}

	protected override string _GetTemplateForLabelAllCreators()
	{
		return "ã™ã¹ã¦ã®ã‚¯ãƒªã‚¨ãƒ¼ã‚¿ãƒ¼";
	}

	protected override string _GetTemplateForLabelAllCurrency()
	{
		return "ã™ã¹ã¦ã®é€šè²¨";
	}

	protected override string _GetTemplateForLabelAllFeatured()
	{
		return "ã™ã¹ã¦ã®æ³¨ç›®ã‚¢ã‚¤ãƒ†ãƒ ";
	}

	protected override string _GetTemplateForLabelAllTime()
	{
		return "é€šç®—";
	}

	protected override string _GetTemplateForLabelAnimations()
	{
		return "ã‚¢ãƒ‹ãƒ¡ãƒ¼ã‚·ãƒ§ãƒ³";
	}

	protected override string _GetTemplateForLabelAnyPrice()
	{
		return "ä¾¡æ ¼æŒ‡å®šãªã—";
	}

	protected override string _GetTemplateForLabelAvatarAnimations()
	{
		return "ã‚¢ãƒã‚¿ãƒ¼ã‚¢ãƒ‹ãƒ¡";
	}

	protected override string _GetTemplateForLabelBestselling()
	{
		return "ãƒ™ã‚¹ãƒˆã‚»ãƒ©ãƒ¼";
	}

	protected override string _GetTemplateForLabelBodyParts()
	{
		return "ãƒœãƒ‡ã‚£ãƒ‘ãƒ¼ãƒ„";
	}

	protected override string _GetTemplateForLabelClothing()
	{
		return "ã‚³ã‚¹ãƒãƒ¥ãƒ¼ãƒ ";
	}

	protected override string _GetTemplateForLabelCollectibleAccessories()
	{
		return "ã‚³ãƒ¬ã‚¯ã‚¿ãƒ–ãƒ«ã‚¢ã‚¯ã‚»ã‚µãƒª";
	}

	protected override string _GetTemplateForLabelCollectibleFaces()
	{
		return "ã‚³ãƒ¬ã‚¯ã‚¿ãƒ–ãƒ«ã®é¡”";
	}

	protected override string _GetTemplateForLabelCollectibleGear()
	{
		return "ã‚³ãƒ¬ã‚¯ã‚¿ãƒ–ãƒ«ã‚®ã‚¢";
	}

	protected override string _GetTemplateForLabelCollectibles()
	{
		return "ã‚³ãƒ¬ã‚¯ã‚¿ãƒ–ãƒ«";
	}

	protected override string _GetTemplateForLabelFaces()
	{
		return "é¡”";
	}

	protected override string _GetTemplateForLabelFeatured()
	{
		return "æ³¨ç›®";
	}

	protected override string _GetTemplateForLabelFeaturedAccesories()
	{
		return "æ³¨ç›®ã®ã‚¢ã‚¯ã‚»ã‚µãƒª";
	}

	protected override string _GetTemplateForLabelFeaturedAnimations()
	{
		return "æ³¨ç›®ã®ã‚¢ãƒ‹ãƒ¡ãƒ¼ã‚·ãƒ§ãƒ³";
	}

	protected override string _GetTemplateForLabelFeaturedFaces()
	{
		return "æ³¨ç›®ã®é¡”";
	}

	protected override string _GetTemplateForLabelFeaturedGear()
	{
		return "æ³¨ç›®ã®ã‚®ã‚¢";
	}

	protected override string _GetTemplateForLabelFeaturedPackages()
	{
		return "æ³¨ç›®ã®ãƒ‘ãƒƒã‚±ãƒ¼ã‚¸";
	}

	protected override string _GetTemplateForLabelFree()
	{
		return "ç„¡æ–™";
	}

	protected override string _GetTemplateForLabelGear()
	{
		return "ã‚®ã‚¢";
	}

	protected override string _GetTemplateForLabelGearAll()
	{
		return "ã™ã¹ã¦ã®ã‚®ã‚¢";
	}

	protected override string _GetTemplateForLabelGearBuilding()
	{
		return "å»ºç¯‰";
	}

	protected override string _GetTemplateForLabelGearExplosive()
	{
		return "çˆ†ç™ºç‰©";
	}

	protected override string _GetTemplateForLabelGearMelee()
	{
		return "ãƒ¡ãƒ¬ãƒ¼";
	}

	protected override string _GetTemplateForLabelGearMusical()
	{
		return "éŸ³æ¥½";
	}

	protected override string _GetTemplateForLabelGearNavigation()
	{
		return "ãƒŠãƒ“ã‚²ãƒ¼ã‚·ãƒ§ãƒ³";
	}

	protected override string _GetTemplateForLabelGearPersonalTransport()
	{
		return "ä¹—ã‚Šç‰©";
	}

	protected override string _GetTemplateForLabelGearPowerUps()
	{
		return "ãƒ‘ãƒ¯ãƒ¼ã‚¢ãƒƒãƒ—";
	}

	protected override string _GetTemplateForLabelGearRanged()
	{
		return "é è·é›¢";
	}

	protected override string _GetTemplateForLabelGearSocial()
	{
		return "ã‚½ãƒ¼ã‚·ãƒ£ãƒ«";
	}

	protected override string _GetTemplateForLabelGenreAdventure()
	{
		return "ã‚¢ãƒ‰ãƒ™ãƒ³ãƒãƒ£ãƒ¼";
	}

	protected override string _GetTemplateForLabelGenreAll()
	{
		return "ã™ã¹ã¦ã®ã‚¸ãƒ£ãƒ³ãƒ«";
	}

	protected override string _GetTemplateForLabelGenreBuilding()
	{
		return "å»ºç¯‰";
	}

	protected override string _GetTemplateForLabelGenreComedy()
	{
		return "ã‚³ãƒ¡ãƒ‡ã‚£";
	}

	protected override string _GetTemplateForLabelGenreFantasy()
	{
		return "ä¸­ä¸–";
	}

	protected override string _GetTemplateForLabelGenreFighting()
	{
		return "æ ¼é—˜";
	}

	protected override string _GetTemplateForLabelGenreFPS()
	{
		return "FPS";
	}

	protected override string _GetTemplateForLabelGenreFunny()
	{
		return "ã‚³ãƒ¡ãƒ‡ã‚£";
	}

	protected override string _GetTemplateForLabelGenreHorror()
	{
		return "ãƒ›ãƒ©ãƒ¼";
	}

	protected override string _GetTemplateForLabelGenreMedieval()
	{
		return "ä¸­ä¸–";
	}

	protected override string _GetTemplateForLabelGenreMilitary()
	{
		return "ãƒŸãƒªã‚¿ãƒªãƒ¼";
	}

	protected override string _GetTemplateForLabelGenreNaval()
	{
		return "æµ·è»";
	}

	protected override string _GetTemplateForLabelGenreNinja()
	{
		return "æ ¼é—˜";
	}

	protected override string _GetTemplateForLabelGenrePirate()
	{
		return "æµ·è»";
	}

	protected override string _GetTemplateForLabelGenreRPG()
	{
		return "RPG";
	}

	protected override string _GetTemplateForLabelGenreScary()
	{
		return "ãƒ›ãƒ©ãƒ¼";
	}

	protected override string _GetTemplateForLabelGenreSciFi()
	{
		return "SF";
	}

	protected override string _GetTemplateForLabelGenreSports()
	{
		return "ã‚¹ãƒãƒ¼ãƒ„";
	}

	protected override string _GetTemplateForLabelGenreTownAndCity()
	{
		return "éƒ½å¸‚é–‹ç™º";
	}

	protected override string _GetTemplateForLabelGenreTutorial()
	{
		return "å»ºç¯‰";
	}

	protected override string _GetTemplateForLabelGenreWar()
	{
		return "ãƒŸãƒªã‚¿ãƒªãƒ¼";
	}

	protected override string _GetTemplateForLabelGenreWestern()
	{
		return "ã‚¦ã‚¨ã‚¹ã‚¿ãƒ³";
	}

	protected override string _GetTemplateForLabelGenreWildWest()
	{
		return "ã‚¦ã‚¨ã‚¹ã‚¿ãƒ³";
	}

	protected override string _GetTemplateForLabelHeads()
	{
		return "é ­";
	}

	protected override string _GetTemplateForLabelMostFavorited()
	{
		return "ä¸€ç•ªäººæ°—";
	}

	protected override string _GetTemplateForLabelNoResellers()
	{
		return "å†è²©è€…ãªã—";
	}

	protected override string _GetTemplateForLabelOffSale()
	{
		return "éžå£²å“";
	}

	protected override string _GetTemplateForLabelPackages()
	{
		return "ãƒ‘ãƒƒã‚±ãƒ¼ã‚¸";
	}

	protected override string _GetTemplateForLabelPants()
	{
		return "ãƒ‘ãƒ³ãƒ„";
	}

	protected override string _GetTemplateForLabelPastDay()
	{
		return "æ˜¨æ—¥";
	}

	protected override string _GetTemplateForLabelPastWeek()
	{
		return "å…ˆé€±";
	}

	protected override string _GetTemplateForLabelPriceHighFirst()
	{
		return "ä¾¡æ ¼ï¼ˆé«˜ã„é †ï¼‰";
	}

	protected override string _GetTemplateForLabelPriceLowFirst()
	{
		return "ä¾¡æ ¼ï¼ˆå®‰ã„é †ï¼‰";
	}

	protected override string _GetTemplateForLabelRecentlyUpdated()
	{
		return "æœ€è¿‘ã‚¢ãƒƒãƒ—ãƒ‡ãƒ¼ãƒˆ";
	}

	protected override string _GetTemplateForLabelRelevance()
	{
		return "ä¸¦ã¹æ›¿ãˆ";
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
		return "ã‚·ãƒ£ãƒ„";
	}

	protected override string _GetTemplateForLabelTShirts()
	{
		return "Tã‚·ãƒ£ãƒ„";
	}

	protected override string _GetTemplateForResponseErrorFilter()
	{
		return "ãƒ•ã‚£ãƒ«ã‚¿ã‚¿ãƒ–ã«ã‚¨ãƒ©ãƒ¼ãŒã‚ã‚Šã¾ã™";
	}

	protected override string _GetTemplateForResponseGenericError()
	{
		return "ã‚¨ãƒ©ãƒ¼ãŒç™ºç”Ÿã—ã¾ã—ãŸã€‚å¾Œã§ã‚‚ã†ä¸€åº¦ãŠè©¦ã—ãã ã•ã„ã€‚";
	}

	protected override string _GetTemplateForResponseNoItemsFound()
	{
		return "ã‚¢ã‚¤ãƒ†ãƒ ãŒè¦‹ã¤ã‹ã‚Šã¾ã›ã‚“ã€‚";
	}

	protected override string _GetTemplateForResponseNoSaleItemsFromSearch()
	{
		return "æ¤œç´¢ã—ã¾ã—ãŸãŒã€è²©å£²ä¸­ã®ã‚¢ã‚¤ãƒ†ãƒ ãŒè¦‹ã¤ã‹ã‚Šã¾ã›ã‚“ã§ã—ãŸã€‚åˆ©ç”¨ã§ããªã„ã‚¢ã‚¤ãƒ†ãƒ ãŒä»¥ä¸‹ã«è¡¨ç¤ºã•ã‚Œã¾ã™ã€‚";
	}

	protected override string _GetTemplateForResponseTemporarilyUnavailable()
	{
		return "ã‚«ã‚¿ãƒ­ã‚°ã¯ä¸€æ™‚çš„ã«åˆ©ç”¨ã§ãã¾ã›ã‚“ã€‚å¾Œã§ã‚‚ã†ä¸€åº¦ãŠè©¦ã—ãã ã•ã„ã€‚";
	}

	protected override string _GetTemplateForResponseThrottled()
	{
		return "ãƒªã‚¯ã‚¨ã‚¹ãƒˆã®é–“éš”ãŒçŸ­ã™ãŽã¾ã™ã€‚1åˆ†å¾Œã«ã‚‚ã†ä¸€åº¦ãŠè©¦ã—ãã ã•ã„ã€‚";
	}
}


}
