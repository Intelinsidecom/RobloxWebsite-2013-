namespace Roblox.Platform.TranslationResources.Feature {
    /// <summary>

/// This class overrides CatalogResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class CatalogResources_zh_tw : CatalogResources_en_us, ICatalogResources, ITranslationResources
{
	/// <summary>
	/// Key: "Action.BuyRobux"
	/// English String: "Buy Robux"
	/// </summary>
	public override string ActionBuyRobux => "è³¼è²· Robux";

	/// <summary>
	/// Key: "Action.Dialog.AddGearOk"
	/// English String: "OK"
	/// </summary>
	public override string ActionDialogAddGearOk => "ç¢ºå®š";

	/// <summary>
	/// Key: "Action.Filter.Apply"
	/// English String: "Apply"
	/// </summary>
	public override string ActionFilterApply => "å¥—ç”¨";

	/// <summary>
	/// Key: "Action.Filter.Cancel"
	/// English String: "Cancel"
	/// </summary>
	public override string ActionFilterCancel => "å–æ¶ˆ";

	/// <summary>
	/// Key: "Action.Go"
	/// English String: "Go"
	/// </summary>
	public override string ActionGo => "é–‹å§‹";

	/// <summary>
	/// Key: "Action.ViewAllItems"
	/// English String: "View All Items"
	/// </summary>
	public override string ActionViewAllItems => "æª¢è¦–æ‰€æœ‰é“å…·";

	/// <summary>
	/// Key: "Description.Dialog.AddGearBody"
	/// English String: "To add gear to your game, find an item in the catalog and click the Add to Game button. The item will automatically be allowed in game, and you'll receive a commission on every copy sold from your game page. (You can only add gear that's for sale.)"
	/// </summary>
	public override string DescriptionDialogAddGearBody => "è‹¥è¦åœ¨æ‚¨çš„éŠæˆ²åŠ å…¥è£å‚™ï¼Œè«‹åœ¨åž‹éŒ„ä¸­æ‰¾åˆ°é“å…·ï¼ŒæŒ‰ä¸‹ã€ŒåŠ åˆ°éŠæˆ²ã€æŒ‰éˆ•ã€‚æ­¤é“å…·æœƒè‡ªå‹•åœ¨éŠæˆ²ä¸­å…è¨±ä½¿ç”¨ï¼Œè€Œæ‚¨å¯ä»¥å¾žæ‚¨çš„éŠæˆ²è£¡è²©è³£çš„é“å…·æŠ½æˆï¼ˆåªå¯ä»¥åŠ å…¥è²©è³£ä¸­çš„è£å‚™ï¼‰ã€‚";

	/// <summary>
	/// Key: "Heading.CatalogCategory"
	/// English String: "Category"
	/// </summary>
	public override string HeadingCatalogCategory => "é¡žåˆ¥";

	/// <summary>
	/// Key: "Heading.CatalogPage"
	/// English String: "Catalog"
	/// </summary>
	public override string HeadingCatalogPage => "åž‹éŒ„";

	/// <summary>
	/// Key: "Label.AllFeaturedItems"
	/// English String: "View All Featured Items"
	/// </summary>
	public override string LabelAllFeaturedItems => "æª¢è¦–æ‰€æœ‰ç²¾é¸é …ç›®";

	/// <summary>
	/// Key: "Label.AllGenres"
	/// English String: "All Genres"
	/// </summary>
	public override string LabelAllGenres => "æ‰€æœ‰é¡žåˆ¥";

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
	public override string LabelBreadCrumbFree => "å…è²»";

	/// <summary>
	/// Key: "Label.BreadCrumb.Group"
	/// English String: "Group:"
	/// </summary>
	public override string LabelBreadCrumbGroup => "ç¾¤çµ„ï¼š";

	/// <summary>
	/// Key: "Label.Bundle"
	/// Bundle
	/// English String: "Bundle"
	/// </summary>
	public override string LabelBundle => "çµ„åˆ";

	/// <summary>
	/// Key: "Label.Bundles"
	/// Bundles
	/// English String: "Bundles"
	/// </summary>
	public override string LabelBundles => "çµ„åˆ";

	/// <summary>
	/// Key: "Label.Card.CreatorBy"
	/// English String: "By"
	/// </summary>
	public override string LabelCardCreatorBy => "å‰µä½œè€… :";

	/// <summary>
	/// Key: "Label.Card.PriceWas"
	/// English String: "Was"
	/// </summary>
	public override string LabelCardPriceWas => "åŽŸåƒ¹";

	/// <summary>
	/// Key: "Label.Card.Remaining"
	/// English String: "Remaining:"
	/// </summary>
	public override string LabelCardRemaining => "é‚„å‰©ï¼š";

	/// <summary>
	/// Key: "Label.CategoryAttributes"
	/// English String: "Attributes"
	/// </summary>
	public override string LabelCategoryAttributes => "å±¬æ€§";

	/// <summary>
	/// Key: "Label.CategoryType"
	/// English String: "Type"
	/// </summary>
	public override string LabelCategoryType => "é¡žåž‹";

	/// <summary>
	/// Key: "Label.CommunityCreations"
	/// UGC items
	/// English String: " Community Creations"
	/// </summary>
	public override string LabelCommunityCreations => "ç¤¾ç¾¤å‰µä½œ";

	/// <summary>
	/// Key: "Label.Dialog.AddGearTitle"
	/// English String: "Add Gear to Your Game"
	/// </summary>
	public override string LabelDialogAddGearTitle => "å°‡è£å‚™åŠ åˆ°æ‚¨çš„éŠæˆ²";

	/// <summary>
	/// Key: "Label.Emotes"
	/// Emotes
	/// English String: "Emotes"
	/// </summary>
	public override string LabelEmotes => "å‹•ä½œ";

	/// <summary>
	/// Key: "Label.Favorites"
	/// English String: "Favorites"
	/// </summary>
	public override string LabelFavorites => "è¨­ç‚ºæœ€æ„›";

	/// <summary>
	/// Key: "Label.FeaturedBundles"
	/// Featured Bundles
	/// English String: "Featured Bundles"
	/// </summary>
	public override string LabelFeaturedBundles => "ç²¾é¸çµ„åˆ";

	/// <summary>
	/// Key: "Label.FeaturedEmotes"
	/// Featured Emotes
	/// English String: "Featured Emotes"
	/// </summary>
	public override string LabelFeaturedEmotes => "ç²¾é¸å‹•ä½œ";

	/// <summary>
	/// Key: "Label.Filter.ByTime"
	/// English String: "By Time"
	/// </summary>
	public override string LabelFilterByTime => "ä¾æ™‚é–“";

	/// <summary>
	/// Key: "Label.Filter.Category"
	/// English String: "Category"
	/// </summary>
	public override string LabelFilterCategory => "é¡žåˆ¥";

	/// <summary>
	/// Key: "Label.Filter.Creator"
	/// English String: "Creator"
	/// </summary>
	public override string LabelFilterCreator => "å‰µä½œè€…";

	/// <summary>
	/// Key: "Label.Filter.Filter"
	/// English String: "Filter"
	/// </summary>
	public override string LabelFilterFilter => "ç¯©é¸";

	/// <summary>
	/// Key: "Label.Filter.Filters"
	/// English String: "Filters"
	/// </summary>
	public override string LabelFilterFilters => "ç¯©é¸æ¢ä»¶";

	/// <summary>
	/// Key: "Label.Filter.Genre"
	/// English String: "Genre"
	/// </summary>
	public override string LabelFilterGenre => "é¡žåˆ¥";

	/// <summary>
	/// Key: "Label.Filter.Hide"
	/// English String: "Hide"
	/// </summary>
	public override string LabelFilterHide => "éš±è—";

	/// <summary>
	/// Key: "Label.Filter.Price"
	/// English String: "Price"
	/// </summary>
	public override string LabelFilterPrice => "åƒ¹æ ¼";

	/// <summary>
	/// Key: "Label.Filter.PriceMax"
	/// English String: "Max"
	/// </summary>
	public override string LabelFilterPriceMax => "æœ€é«˜";

	/// <summary>
	/// Key: "Label.Filter.PriceMin"
	/// English String: "Min"
	/// </summary>
	public override string LabelFilterPriceMin => "æœ€ä½Ž";

	/// <summary>
	/// Key: "Label.Filter.PriceTo"
	/// English String: "To"
	/// </summary>
	public override string LabelFilterPriceTo => "åˆ°";

	/// <summary>
	/// Key: "Label.Filter.Show"
	/// English String: "Show"
	/// </summary>
	public override string LabelFilterShow => "é¡¯ç¤º";

	/// <summary>
	/// Key: "Label.Filter.Sorting"
	/// English String: "Sorting"
	/// </summary>
	public override string LabelFilterSorting => "æŽ’åº";

	/// <summary>
	/// Key: "Label.Filter.UnavailableItems"
	/// English String: "Unavailable Items"
	/// </summary>
	public override string LabelFilterUnavailableItems => "ä¸é–‹æ”¾çš„é“å…·";

	/// <summary>
	/// Key: "Label.GoogleOnly"
	/// label
	/// English String: "Google Only"
	/// </summary>
	public override string LabelGoogleOnly => "Google é™å®š";

	/// <summary>
	/// Key: "Label.Ios"
	/// label
	/// English String: "IOS"
	/// </summary>
	public override string LabelIos => "IOS";

	/// <summary>
	/// Key: "Label.Mobile"
	/// label
	/// English String: "Mobile"
	/// </summary>
	public override string LabelMobile => "è¡Œå‹•é›»è¨Š";

	/// <summary>
	/// Key: "Label.New"
	/// label
	/// English String: "New"
	/// </summary>
	public override string LabelNew => "æ–°å¢ž";

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
	public override string LabelSale => "ä¿ƒéŠ·";

	/// <summary>
	/// Key: "Label.SearchField"
	/// English String: "Search"
	/// </summary>
	public override string LabelSearchField => "æœå°‹";

	/// <summary>
	/// Key: "Label.SeeAll"
	/// English String: "See All"
	/// </summary>
	public override string LabelSeeAll => "æŸ¥çœ‹å…¨éƒ¨";

	/// <summary>
	/// Key: "Label.Username"
	/// English String: "Username"
	/// </summary>
	public override string LabelUsername => "ä½¿ç”¨è€…åç¨±";

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
	public override string LabelAccessories => "é£¾å“";

	/// <summary>
	/// Key: "LabelAccessoryAll"
	/// English String: "All Accessories"
	/// </summary>
	public override string LabelAccessoryAll => "æ‰€æœ‰é£¾å“";

	/// <summary>
	/// Key: "LabelAccessoryBack"
	/// English String: "Back"
	/// </summary>
	public override string LabelAccessoryBack => "èƒŒé¢";

	/// <summary>
	/// Key: "LabelAccessoryFace"
	/// English String: "Face"
	/// </summary>
	public override string LabelAccessoryFace => "è‡‰éƒ¨";

	/// <summary>
	/// Key: "LabelAccessoryFront"
	/// English String: "Front"
	/// </summary>
	public override string LabelAccessoryFront => "æ­£é¢";

	/// <summary>
	/// Key: "LabelAccessoryHair"
	/// English String: "Hair"
	/// </summary>
	public override string LabelAccessoryHair => "é«®åž‹";

	/// <summary>
	/// Key: "LabelAccessoryHats"
	/// English String: "Hats"
	/// </summary>
	public override string LabelAccessoryHats => "å¸½å­";

	/// <summary>
	/// Key: "LabelAccessoryNeck"
	/// English String: "Neck"
	/// </summary>
	public override string LabelAccessoryNeck => "é ¸éƒ¨";

	/// <summary>
	/// Key: "LabelAccessoryShoulder"
	/// English String: "Shoulder"
	/// </summary>
	public override string LabelAccessoryShoulder => "è‚©è†€";

	/// <summary>
	/// Key: "LabelAccessoryWaist"
	/// English String: "Waist"
	/// </summary>
	public override string LabelAccessoryWaist => "è…°éƒ¨";

	/// <summary>
	/// Key: "LabelAll"
	/// English String: "All"
	/// </summary>
	public override string LabelAll => "å…¨éƒ¨";

	/// <summary>
	/// Key: "LabelAllBodyParts"
	/// English String: "All Body Parts"
	/// </summary>
	public override string LabelAllBodyParts => "æ‰€æœ‰èº«é«”éƒ¨ä½";

	/// <summary>
	/// Key: "LabelAllCategories"
	/// English String: "All Categories"
	/// </summary>
	public override string LabelAllCategories => "æ‰€æœ‰é¡žåˆ¥";

	/// <summary>
	/// Key: "LabelAllClothing"
	/// English String: "All Clothing"
	/// </summary>
	public override string LabelAllClothing => "æ‰€æœ‰æœè£";

	/// <summary>
	/// Key: "LabelAllCollectibles"
	/// English String: "All Collectibles"
	/// </summary>
	public override string LabelAllCollectibles => "æ‰€æœ‰æ”¶è—å“";

	/// <summary>
	/// Key: "LabelAllCreators"
	/// English String: "All Creators"
	/// </summary>
	public override string LabelAllCreators => "æ‰€æœ‰å‰µä½œè€…";

	/// <summary>
	/// Key: "LabelAllCurrency"
	/// English String: "All Currency"
	/// </summary>
	public override string LabelAllCurrency => "æ‰€æœ‰è²¨å¹£";

	/// <summary>
	/// Key: "LabelAllFeatured"
	/// English String: "All Featured Items"
	/// </summary>
	public override string LabelAllFeatured => "æ‰€æœ‰ç²¾é¸é“å…·";

	/// <summary>
	/// Key: "LabelAllTime"
	/// English String: "All Time"
	/// </summary>
	public override string LabelAllTime => "æ­·ä¾†";

	/// <summary>
	/// Key: "LabelAnimations"
	/// English String: "Animations"
	/// </summary>
	public override string LabelAnimations => "å‹•ç•«";

	/// <summary>
	/// Key: "LabelAnyPrice"
	/// English String: "Any Price"
	/// </summary>
	public override string LabelAnyPrice => "ä»»ä½•åƒ¹æ ¼";

	/// <summary>
	/// Key: "LabelAvatarAnimations"
	/// English String: "Avatar Animations"
	/// </summary>
	public override string LabelAvatarAnimations => "è™›æ“¬äººå¶å‹•ç•«";

	/// <summary>
	/// Key: "LabelBestselling"
	/// English String: "Bestselling"
	/// </summary>
	public override string LabelBestselling => "æš¢éŠ·";

	/// <summary>
	/// Key: "LabelBodyParts"
	/// English String: "Body Parts"
	/// </summary>
	public override string LabelBodyParts => "èº«é«”éƒ¨ä½";

	/// <summary>
	/// Key: "LabelClothing"
	/// English String: "Clothing"
	/// </summary>
	public override string LabelClothing => "æœè£";

	/// <summary>
	/// Key: "LabelCollectibleAccessories"
	/// English String: "Collectible Accessories"
	/// </summary>
	public override string LabelCollectibleAccessories => "å¯æ”¶è—çš„é£¾å“";

	/// <summary>
	/// Key: "LabelCollectibleFaces"
	/// English String: "Collectible Faces"
	/// </summary>
	public override string LabelCollectibleFaces => "è‡‰éƒ¨æ”¶è—å“";

	/// <summary>
	/// Key: "LabelCollectibleGear"
	/// English String: "Collectible Gear"
	/// </summary>
	public override string LabelCollectibleGear => "è£å‚™æ”¶è—å“";

	/// <summary>
	/// Key: "LabelCollectibles"
	/// English String: "Collectibles"
	/// </summary>
	public override string LabelCollectibles => "æ”¶è—å“";

	/// <summary>
	/// Key: "LabelFaces"
	/// English String: "Faces"
	/// </summary>
	public override string LabelFaces => "è‡‰éƒ¨";

	/// <summary>
	/// Key: "LabelFeatured"
	/// English String: "Featured"
	/// </summary>
	public override string LabelFeatured => "ç²¾é¸";

	/// <summary>
	/// Key: "LabelFeaturedAccesories"
	/// English String: "Featured Accessories"
	/// </summary>
	public override string LabelFeaturedAccesories => "ç²¾é¸é£¾å“";

	/// <summary>
	/// Key: "LabelFeaturedAnimations"
	/// English String: "Featured Animations"
	/// </summary>
	public override string LabelFeaturedAnimations => "ç²¾é¸å‹•ç•«";

	/// <summary>
	/// Key: "LabelFeaturedFaces"
	/// English String: "Featured Faces"
	/// </summary>
	public override string LabelFeaturedFaces => "ç²¾é¸è¡¨æƒ…";

	/// <summary>
	/// Key: "LabelFeaturedGear"
	/// English String: "Featured Gear"
	/// </summary>
	public override string LabelFeaturedGear => "ç²¾é¸è£å‚™";

	/// <summary>
	/// Key: "LabelFeaturedPackages"
	/// English String: "Featured Packages"
	/// </summary>
	public override string LabelFeaturedPackages => "ç²¾é¸å¥—è£";

	/// <summary>
	/// Key: "LabelFree"
	/// English String: "Free"
	/// </summary>
	public override string LabelFree => "å…è²»";

	/// <summary>
	/// Key: "LabelGear"
	/// English String: "Gear"
	/// </summary>
	public override string LabelGear => "è£å‚™";

	/// <summary>
	/// Key: "LabelGearAll"
	/// English String: "All Gear"
	/// </summary>
	public override string LabelGearAll => "æ‰€æœ‰è£å‚™";

	/// <summary>
	/// Key: "LabelGearBuilding"
	/// English String: "Building"
	/// </summary>
	public override string LabelGearBuilding => "å»ºç¯‰";

	/// <summary>
	/// Key: "LabelGearExplosive"
	/// English String: "Explosive"
	/// </summary>
	public override string LabelGearExplosive => "çˆ†è£‚";

	/// <summary>
	/// Key: "LabelGearMelee"
	/// English String: "Melee"
	/// </summary>
	public override string LabelGearMelee => "è¿‘æˆ°";

	/// <summary>
	/// Key: "LabelGearMusical"
	/// English String: "Musical"
	/// </summary>
	public override string LabelGearMusical => "éŸ³æ¨‚";

	/// <summary>
	/// Key: "LabelGearNavigation"
	/// English String: "Navigation"
	/// </summary>
	public override string LabelGearNavigation => "å°Žèˆª";

	/// <summary>
	/// Key: "LabelGearPersonalTransport"
	/// English String: "Transport"
	/// </summary>
	public override string LabelGearPersonalTransport => "é‹è¼¸";

	/// <summary>
	/// Key: "LabelGearPowerUps"
	/// English String: "Power Up"
	/// </summary>
	public override string LabelGearPowerUps => "å¼·åŒ–";

	/// <summary>
	/// Key: "LabelGearRanged"
	/// English String: "Ranged"
	/// </summary>
	public override string LabelGearRanged => "é ç¨‹";

	/// <summary>
	/// Key: "LabelGearSocial"
	/// English String: "Social"
	/// </summary>
	public override string LabelGearSocial => "ç¤¾äº¤";

	/// <summary>
	/// Key: "LabelGenreAdventure"
	/// English String: "Adventure"
	/// </summary>
	public override string LabelGenreAdventure => "æŽ¢éšª";

	/// <summary>
	/// Key: "LabelGenreAll"
	/// English String: "All Genres"
	/// </summary>
	public override string LabelGenreAll => "æ‰€æœ‰é¡žåˆ¥";

	/// <summary>
	/// Key: "LabelGenreBuilding"
	/// English String: "Building"
	/// </summary>
	public override string LabelGenreBuilding => "å»ºé€ ";

	/// <summary>
	/// Key: "LabelGenreComedy"
	/// English String: "Comedy"
	/// </summary>
	public override string LabelGenreComedy => "æžç¬‘";

	/// <summary>
	/// Key: "LabelGenreFantasy"
	/// English String: "Medieval"
	/// </summary>
	public override string LabelGenreFantasy => "ä¸­å¤";

	/// <summary>
	/// Key: "LabelGenreFighting"
	/// English String: "Fighting"
	/// </summary>
	public override string LabelGenreFighting => "æ ¼é¬¥";

	/// <summary>
	/// Key: "LabelGenreFPS"
	/// English String: "FPS"
	/// </summary>
	public override string LabelGenreFPS => "å°„æ“Š";

	/// <summary>
	/// Key: "LabelGenreFunny"
	/// English String: "Comedy"
	/// </summary>
	public override string LabelGenreFunny => "æžç¬‘";

	/// <summary>
	/// Key: "LabelGenreHorror"
	/// English String: "Horror"
	/// </summary>
	public override string LabelGenreHorror => "ææ€–";

	/// <summary>
	/// Key: "LabelGenreMedieval"
	/// English String: "Medieval"
	/// </summary>
	public override string LabelGenreMedieval => "ä¸­å¤";

	/// <summary>
	/// Key: "LabelGenreMilitary"
	/// English String: "Military"
	/// </summary>
	public override string LabelGenreMilitary => "è»äº‹";

	/// <summary>
	/// Key: "LabelGenreNaval"
	/// English String: "Naval"
	/// </summary>
	public override string LabelGenreNaval => "æµ·æ´‹";

	/// <summary>
	/// Key: "LabelGenreNinja"
	/// English String: "Fighting"
	/// </summary>
	public override string LabelGenreNinja => "æ ¼é¬¥";

	/// <summary>
	/// Key: "LabelGenrePirate"
	/// English String: "Naval"
	/// </summary>
	public override string LabelGenrePirate => "æµ·æ´‹";

	/// <summary>
	/// Key: "LabelGenreRPG"
	/// English String: "RPG"
	/// </summary>
	public override string LabelGenreRPG => "è§’è‰²æ‰®æ¼”";

	/// <summary>
	/// Key: "LabelGenreScary"
	/// English String: "Horror"
	/// </summary>
	public override string LabelGenreScary => "ææ€–";

	/// <summary>
	/// Key: "LabelGenreSciFi"
	/// English String: "Sci-Fi"
	/// </summary>
	public override string LabelGenreSciFi => "ç§‘å¹»";

	/// <summary>
	/// Key: "LabelGenreSports"
	/// English String: "Sports"
	/// </summary>
	public override string LabelGenreSports => "é«”è‚²";

	/// <summary>
	/// Key: "LabelGenreTownAndCity"
	/// English String: "Town and City"
	/// </summary>
	public override string LabelGenreTownAndCity => "å¸‚éŽ®";

	/// <summary>
	/// Key: "LabelGenreTutorial"
	/// English String: "Building"
	/// </summary>
	public override string LabelGenreTutorial => "å»ºé€ ";

	/// <summary>
	/// Key: "LabelGenreWar"
	/// English String: "Military"
	/// </summary>
	public override string LabelGenreWar => "è»äº‹";

	/// <summary>
	/// Key: "LabelGenreWestern"
	/// English String: "Western"
	/// </summary>
	public override string LabelGenreWestern => "è¥¿æ–¹";

	/// <summary>
	/// Key: "LabelGenreWildWest"
	/// English String: "Western"
	/// </summary>
	public override string LabelGenreWildWest => "è¥¿æ–¹";

	/// <summary>
	/// Key: "LabelHeads"
	/// English String: "Heads"
	/// </summary>
	public override string LabelHeads => "é ­éƒ¨";

	/// <summary>
	/// Key: "LabelMostFavorited"
	/// English String: "Most Favorited"
	/// </summary>
	public override string LabelMostFavorited => "æœ€å—å–œæ„›";

	/// <summary>
	/// Key: "LabelNoResellers"
	/// English String: "No Resellers"
	/// </summary>
	public override string LabelNoResellers => "æ²’æœ‰äººè½‰è³£";

	/// <summary>
	/// Key: "LabelOffSale"
	/// English String: "Offsale"
	/// </summary>
	public override string LabelOffSale => "ä¸‹æž¶";

	/// <summary>
	/// Key: "LabelPackages"
	/// English String: "Packages"
	/// </summary>
	public override string LabelPackages => "å¥—è£";

	/// <summary>
	/// Key: "LabelPants"
	/// English String: "Pants"
	/// </summary>
	public override string LabelPants => "è¤²å­";

	/// <summary>
	/// Key: "LabelPastDay"
	/// English String: "Past Day"
	/// </summary>
	public override string LabelPastDay => "å‰ä¸€æ—¥";

	/// <summary>
	/// Key: "LabelPastWeek"
	/// English String: "Past Week"
	/// </summary>
	public override string LabelPastWeek => "å‰ä¸€é€±";

	/// <summary>
	/// Key: "LabelPriceHighFirst"
	/// English String: "Price (High to Low)"
	/// </summary>
	public override string LabelPriceHighFirst => "åƒ¹æ ¼ï¼ˆç”±é«˜åˆ°ä½Žï¼‰";

	/// <summary>
	/// Key: "LabelPriceLowFirst"
	/// English String: "Price (Low to High)"
	/// </summary>
	public override string LabelPriceLowFirst => "åƒ¹æ ¼ï¼ˆç”±ä½Žåˆ°é«˜ï¼‰";

	/// <summary>
	/// Key: "LabelRecentlyUpdated"
	/// English String: "Recently Updated"
	/// </summary>
	public override string LabelRecentlyUpdated => "æœ€è¿‘æ›´æ–°";

	/// <summary>
	/// Key: "LabelRelevance"
	/// English String: "Relevance"
	/// </summary>
	public override string LabelRelevance => "é—œè¯æ€§";

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
	public override string LabelShirts => "è¥¯è¡«";

	/// <summary>
	/// Key: "LabelTShirts"
	/// English String: "T-Shirts"
	/// </summary>
	public override string LabelTShirts => "Tæ¤";

	/// <summary>
	/// Key: "Response.Error.Filter"
	/// English String: "Errors exist in Filter tab"
	/// </summary>
	public override string ResponseErrorFilter => "ç¯©é¸æ¨™ç±¤æœ‰éŒ¯èª¤";

	/// <summary>
	/// Key: "Response.GenericError"
	/// English String: "An error occurred. Please try again later."
	/// </summary>
	public override string ResponseGenericError => "ç™¼ç”ŸéŒ¯èª¤ï¼Œè«‹ç¨å¾Œå†è©¦ã€‚";

	/// <summary>
	/// Key: "Response.NoItemsFound"
	/// English String: "No items found."
	/// </summary>
	public override string ResponseNoItemsFound => "æ‰¾ä¸åˆ°é“å…·ã€‚";

	/// <summary>
	/// Key: "Response.NoSaleItemsFromSearch"
	/// English String: "Your search did not find items for sale. Unavailable items displayed below."
	/// </summary>
	public override string ResponseNoSaleItemsFromSearch => "æ‚¨çš„æœå°‹æ‰¾ä¸åˆ°è²©è³£ä¸­é“å…·ï¼Œä¸é–‹æ”¾çš„é“å…·é¡¯ç¤ºå¦‚ä¸‹ã€‚";

	/// <summary>
	/// Key: "Response.TemporarilyUnavailable"
	/// English String: "Catalog temporarily unavailable. Please try again later."
	/// </summary>
	public override string ResponseTemporarilyUnavailable => "æš«æ™‚ç„¡æ³•ä½¿ç”¨åž‹éŒ„ï¼Œè«‹ç¨å¾Œå†è©¦ã€‚";

	/// <summary>
	/// Key: "Response.Throttled"
	/// Shown to users when they have made too many requests in a minute and are being throttled.
	/// English String: "You're going too fast! Try again in a minute."
	/// </summary>
	public override string ResponseThrottled => "è«‹æ±‚éŽæ–¼é »ç¹ï¼è«‹ 1 åˆ†é˜å¾Œå†è©¦ã€‚";

	public CatalogResources_zh_tw(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionBuyRobux()
	{
		return "è³¼è²· Robux";
	}

	protected override string _GetTemplateForActionDialogAddGearOk()
	{
		return "ç¢ºå®š";
	}

	protected override string _GetTemplateForActionFilterApply()
	{
		return "å¥—ç”¨";
	}

	protected override string _GetTemplateForActionFilterCancel()
	{
		return "å–æ¶ˆ";
	}

	protected override string _GetTemplateForActionGo()
	{
		return "é–‹å§‹";
	}

	protected override string _GetTemplateForActionViewAllItems()
	{
		return "æª¢è¦–æ‰€æœ‰é“å…·";
	}

	protected override string _GetTemplateForDescriptionDialogAddGearBody()
	{
		return "è‹¥è¦åœ¨æ‚¨çš„éŠæˆ²åŠ å…¥è£å‚™ï¼Œè«‹åœ¨åž‹éŒ„ä¸­æ‰¾åˆ°é“å…·ï¼ŒæŒ‰ä¸‹ã€ŒåŠ åˆ°éŠæˆ²ã€æŒ‰éˆ•ã€‚æ­¤é“å…·æœƒè‡ªå‹•åœ¨éŠæˆ²ä¸­å…è¨±ä½¿ç”¨ï¼Œè€Œæ‚¨å¯ä»¥å¾žæ‚¨çš„éŠæˆ²è£¡è²©è³£çš„é“å…·æŠ½æˆï¼ˆåªå¯ä»¥åŠ å…¥è²©è³£ä¸­çš„è£å‚™ï¼‰ã€‚";
	}

	protected override string _GetTemplateForHeadingCatalogCategory()
	{
		return "é¡žåˆ¥";
	}

	protected override string _GetTemplateForHeadingCatalogPage()
	{
		return "åž‹éŒ„";
	}

	protected override string _GetTemplateForLabelAllFeaturedItems()
	{
		return "æª¢è¦–æ‰€æœ‰ç²¾é¸é …ç›®";
	}

	protected override string _GetTemplateForLabelAllGenres()
	{
		return "æ‰€æœ‰é¡žåˆ¥";
	}

	protected override string _GetTemplateForLabelAmazon()
	{
		return "Amazon";
	}

	protected override string _GetTemplateForLabelBreadCrumbFree()
	{
		return "å…è²»";
	}

	/// <summary>
	/// Key: "Label.BreadCrumb.GenreOrText"
	/// English String: "{genreName1} or {genreName2}"
	/// </summary>
	public override string LabelBreadCrumbGenreOrText(string genreName1, string genreName2)
	{
		return $"{genreName1}æˆ–{genreName2}";
	}

	protected override string _GetTemplateForLabelBreadCrumbGenreOrText()
	{
		return "{genreName1}æˆ–{genreName2}";
	}

	/// <summary>
	/// Key: "Label.BreadCrumb.GenreSelectedText"
	/// English String: "Genre: {genreCount} selected"
	/// </summary>
	public override string LabelBreadCrumbGenreSelectedText(string genreCount)
	{
		return $"é¡žåˆ¥ï¼šå·²é¸æ“‡ {genreCount} ç¨®";
	}

	protected override string _GetTemplateForLabelBreadCrumbGenreSelectedText()
	{
		return "é¡žåˆ¥ï¼šå·²é¸æ“‡ {genreCount} ç¨®";
	}

	protected override string _GetTemplateForLabelBreadCrumbGroup()
	{
		return "ç¾¤çµ„ï¼š";
	}

	/// <summary>
	/// Key: "Label.BreadCrumb.PriceAbove"
	/// English String: "{price} and above"
	/// </summary>
	public override string LabelBreadCrumbPriceAbove(string price)
	{
		return $"{price} åŠä»¥ä¸Š";
	}

	protected override string _GetTemplateForLabelBreadCrumbPriceAbove()
	{
		return "{price} åŠä»¥ä¸Š";
	}

	/// <summary>
	/// Key: "Label.BreadCrumb.PriceBelow"
	/// English String: "{price} and below"
	/// </summary>
	public override string LabelBreadCrumbPriceBelow(string price)
	{
		return $"{price} ä»¥ä¸‹";
	}

	protected override string _GetTemplateForLabelBreadCrumbPriceBelow()
	{
		return "{price} ä»¥ä¸‹";
	}

	/// <summary>
	/// Key: "Label.BreadCrumb.ResultsCount"
	/// English String: "{startNumber} - {endNumber} of {resultsCount} Results"
	/// </summary>
	public override string LabelBreadCrumbResultsCount(string startNumber, string endNumber, string resultsCount)
	{
		return $"{resultsCount} å€‹çµæžœä¸­çš„ç¬¬ {startNumber} - {endNumber} é …";
	}

	protected override string _GetTemplateForLabelBreadCrumbResultsCount()
	{
		return "{resultsCount} å€‹çµæžœä¸­çš„ç¬¬ {startNumber} - {endNumber} é …";
	}

	protected override string _GetTemplateForLabelBundle()
	{
		return "çµ„åˆ";
	}

	protected override string _GetTemplateForLabelBundles()
	{
		return "çµ„åˆ";
	}

	/// <summary>
	/// Key: "Label.ByCreatorLink"
	/// Creator name in item card with link
	/// English String: "By {linkStart}{creator}{linkEnd}"
	/// </summary>
	public override string LabelByCreatorLink(string linkStart, string creator, string linkEnd)
	{
		return $"å‰µä½œè€…ï¼š{linkStart}{creator}{linkEnd}";
	}

	protected override string _GetTemplateForLabelByCreatorLink()
	{
		return "å‰µä½œè€…ï¼š{linkStart}{creator}{linkEnd}";
	}

	protected override string _GetTemplateForLabelCardCreatorBy()
	{
		return "å‰µä½œè€… :";
	}

	protected override string _GetTemplateForLabelCardPriceWas()
	{
		return "åŽŸåƒ¹";
	}

	protected override string _GetTemplateForLabelCardRemaining()
	{
		return "é‚„å‰©ï¼š";
	}

	protected override string _GetTemplateForLabelCategoryAttributes()
	{
		return "å±¬æ€§";
	}

	protected override string _GetTemplateForLabelCategoryType()
	{
		return "é¡žåž‹";
	}

	protected override string _GetTemplateForLabelCommunityCreations()
	{
		return "ç¤¾ç¾¤å‰µä½œ";
	}

	protected override string _GetTemplateForLabelDialogAddGearTitle()
	{
		return "å°‡è£å‚™åŠ åˆ°æ‚¨çš„éŠæˆ²";
	}

	protected override string _GetTemplateForLabelEmotes()
	{
		return "å‹•ä½œ";
	}

	protected override string _GetTemplateForLabelFavorites()
	{
		return "è¨­ç‚ºæœ€æ„›";
	}

	protected override string _GetTemplateForLabelFeaturedBundles()
	{
		return "ç²¾é¸çµ„åˆ";
	}

	protected override string _GetTemplateForLabelFeaturedEmotes()
	{
		return "ç²¾é¸å‹•ä½œ";
	}

	/// <summary>
	/// Key: "Label.FeaturedItemsOnRoblox"
	/// English String: "Featured Items on {spanStart}{roblox}{spanEnd}"
	/// </summary>
	public override string LabelFeaturedItemsOnRoblox(string spanStart, string roblox, string spanEnd)
	{
		return $"{spanStart}{roblox}{spanEnd} ç²¾é¸é“å…·";
	}

	protected override string _GetTemplateForLabelFeaturedItemsOnRoblox()
	{
		return "{spanStart}{roblox}{spanEnd} ç²¾é¸é“å…·";
	}

	protected override string _GetTemplateForLabelFilterByTime()
	{
		return "ä¾æ™‚é–“";
	}

	protected override string _GetTemplateForLabelFilterCategory()
	{
		return "é¡žåˆ¥";
	}

	protected override string _GetTemplateForLabelFilterCreator()
	{
		return "å‰µä½œè€…";
	}

	protected override string _GetTemplateForLabelFilterFilter()
	{
		return "ç¯©é¸";
	}

	protected override string _GetTemplateForLabelFilterFilters()
	{
		return "ç¯©é¸æ¢ä»¶";
	}

	protected override string _GetTemplateForLabelFilterGenre()
	{
		return "é¡žåˆ¥";
	}

	protected override string _GetTemplateForLabelFilterHide()
	{
		return "éš±è—";
	}

	protected override string _GetTemplateForLabelFilterPrice()
	{
		return "åƒ¹æ ¼";
	}

	protected override string _GetTemplateForLabelFilterPriceMax()
	{
		return "æœ€é«˜";
	}

	protected override string _GetTemplateForLabelFilterPriceMin()
	{
		return "æœ€ä½Ž";
	}

	protected override string _GetTemplateForLabelFilterPriceTo()
	{
		return "åˆ°";
	}

	protected override string _GetTemplateForLabelFilterShow()
	{
		return "é¡¯ç¤º";
	}

	protected override string _GetTemplateForLabelFilterSorting()
	{
		return "æŽ’åº";
	}

	protected override string _GetTemplateForLabelFilterUnavailableItems()
	{
		return "ä¸é–‹æ”¾çš„é“å…·";
	}

	protected override string _GetTemplateForLabelGoogleOnly()
	{
		return "Google é™å®š";
	}

	protected override string _GetTemplateForLabelIos()
	{
		return "IOS";
	}

	protected override string _GetTemplateForLabelMobile()
	{
		return "è¡Œå‹•é›»è¨Š";
	}

	protected override string _GetTemplateForLabelNew()
	{
		return "æ–°å¢ž";
	}

	protected override string _GetTemplateForLabelRthro()
	{
		return "Rthro";
	}

	protected override string _GetTemplateForLabelSale()
	{
		return "ä¿ƒéŠ·";
	}

	protected override string _GetTemplateForLabelSearchField()
	{
		return "æœå°‹";
	}

	protected override string _GetTemplateForLabelSeeAll()
	{
		return "æŸ¥çœ‹å…¨éƒ¨";
	}

	protected override string _GetTemplateForLabelUsername()
	{
		return "ä½¿ç”¨è€…åç¨±";
	}

	protected override string _GetTemplateForLabelXbox()
	{
		return "Xbox";
	}

	protected override string _GetTemplateForLabelAccessories()
	{
		return "é£¾å“";
	}

	protected override string _GetTemplateForLabelAccessoryAll()
	{
		return "æ‰€æœ‰é£¾å“";
	}

	protected override string _GetTemplateForLabelAccessoryBack()
	{
		return "èƒŒé¢";
	}

	protected override string _GetTemplateForLabelAccessoryFace()
	{
		return "è‡‰éƒ¨";
	}

	protected override string _GetTemplateForLabelAccessoryFront()
	{
		return "æ­£é¢";
	}

	protected override string _GetTemplateForLabelAccessoryHair()
	{
		return "é«®åž‹";
	}

	protected override string _GetTemplateForLabelAccessoryHats()
	{
		return "å¸½å­";
	}

	protected override string _GetTemplateForLabelAccessoryNeck()
	{
		return "é ¸éƒ¨";
	}

	protected override string _GetTemplateForLabelAccessoryShoulder()
	{
		return "è‚©è†€";
	}

	protected override string _GetTemplateForLabelAccessoryWaist()
	{
		return "è…°éƒ¨";
	}

	protected override string _GetTemplateForLabelAll()
	{
		return "å…¨éƒ¨";
	}

	protected override string _GetTemplateForLabelAllBodyParts()
	{
		return "æ‰€æœ‰èº«é«”éƒ¨ä½";
	}

	protected override string _GetTemplateForLabelAllCategories()
	{
		return "æ‰€æœ‰é¡žåˆ¥";
	}

	protected override string _GetTemplateForLabelAllClothing()
	{
		return "æ‰€æœ‰æœè£";
	}

	protected override string _GetTemplateForLabelAllCollectibles()
	{
		return "æ‰€æœ‰æ”¶è—å“";
	}

	protected override string _GetTemplateForLabelAllCreators()
	{
		return "æ‰€æœ‰å‰µä½œè€…";
	}

	protected override string _GetTemplateForLabelAllCurrency()
	{
		return "æ‰€æœ‰è²¨å¹£";
	}

	protected override string _GetTemplateForLabelAllFeatured()
	{
		return "æ‰€æœ‰ç²¾é¸é“å…·";
	}

	protected override string _GetTemplateForLabelAllTime()
	{
		return "æ­·ä¾†";
	}

	protected override string _GetTemplateForLabelAnimations()
	{
		return "å‹•ç•«";
	}

	protected override string _GetTemplateForLabelAnyPrice()
	{
		return "ä»»ä½•åƒ¹æ ¼";
	}

	protected override string _GetTemplateForLabelAvatarAnimations()
	{
		return "è™›æ“¬äººå¶å‹•ç•«";
	}

	protected override string _GetTemplateForLabelBestselling()
	{
		return "æš¢éŠ·";
	}

	protected override string _GetTemplateForLabelBodyParts()
	{
		return "èº«é«”éƒ¨ä½";
	}

	protected override string _GetTemplateForLabelClothing()
	{
		return "æœè£";
	}

	protected override string _GetTemplateForLabelCollectibleAccessories()
	{
		return "å¯æ”¶è—çš„é£¾å“";
	}

	protected override string _GetTemplateForLabelCollectibleFaces()
	{
		return "è‡‰éƒ¨æ”¶è—å“";
	}

	protected override string _GetTemplateForLabelCollectibleGear()
	{
		return "è£å‚™æ”¶è—å“";
	}

	protected override string _GetTemplateForLabelCollectibles()
	{
		return "æ”¶è—å“";
	}

	protected override string _GetTemplateForLabelFaces()
	{
		return "è‡‰éƒ¨";
	}

	protected override string _GetTemplateForLabelFeatured()
	{
		return "ç²¾é¸";
	}

	protected override string _GetTemplateForLabelFeaturedAccesories()
	{
		return "ç²¾é¸é£¾å“";
	}

	protected override string _GetTemplateForLabelFeaturedAnimations()
	{
		return "ç²¾é¸å‹•ç•«";
	}

	protected override string _GetTemplateForLabelFeaturedFaces()
	{
		return "ç²¾é¸è¡¨æƒ…";
	}

	protected override string _GetTemplateForLabelFeaturedGear()
	{
		return "ç²¾é¸è£å‚™";
	}

	protected override string _GetTemplateForLabelFeaturedPackages()
	{
		return "ç²¾é¸å¥—è£";
	}

	protected override string _GetTemplateForLabelFree()
	{
		return "å…è²»";
	}

	protected override string _GetTemplateForLabelGear()
	{
		return "è£å‚™";
	}

	protected override string _GetTemplateForLabelGearAll()
	{
		return "æ‰€æœ‰è£å‚™";
	}

	protected override string _GetTemplateForLabelGearBuilding()
	{
		return "å»ºç¯‰";
	}

	protected override string _GetTemplateForLabelGearExplosive()
	{
		return "çˆ†è£‚";
	}

	protected override string _GetTemplateForLabelGearMelee()
	{
		return "è¿‘æˆ°";
	}

	protected override string _GetTemplateForLabelGearMusical()
	{
		return "éŸ³æ¨‚";
	}

	protected override string _GetTemplateForLabelGearNavigation()
	{
		return "å°Žèˆª";
	}

	protected override string _GetTemplateForLabelGearPersonalTransport()
	{
		return "é‹è¼¸";
	}

	protected override string _GetTemplateForLabelGearPowerUps()
	{
		return "å¼·åŒ–";
	}

	protected override string _GetTemplateForLabelGearRanged()
	{
		return "é ç¨‹";
	}

	protected override string _GetTemplateForLabelGearSocial()
	{
		return "ç¤¾äº¤";
	}

	protected override string _GetTemplateForLabelGenreAdventure()
	{
		return "æŽ¢éšª";
	}

	protected override string _GetTemplateForLabelGenreAll()
	{
		return "æ‰€æœ‰é¡žåˆ¥";
	}

	protected override string _GetTemplateForLabelGenreBuilding()
	{
		return "å»ºé€ ";
	}

	protected override string _GetTemplateForLabelGenreComedy()
	{
		return "æžç¬‘";
	}

	protected override string _GetTemplateForLabelGenreFantasy()
	{
		return "ä¸­å¤";
	}

	protected override string _GetTemplateForLabelGenreFighting()
	{
		return "æ ¼é¬¥";
	}

	protected override string _GetTemplateForLabelGenreFPS()
	{
		return "å°„æ“Š";
	}

	protected override string _GetTemplateForLabelGenreFunny()
	{
		return "æžç¬‘";
	}

	protected override string _GetTemplateForLabelGenreHorror()
	{
		return "ææ€–";
	}

	protected override string _GetTemplateForLabelGenreMedieval()
	{
		return "ä¸­å¤";
	}

	protected override string _GetTemplateForLabelGenreMilitary()
	{
		return "è»äº‹";
	}

	protected override string _GetTemplateForLabelGenreNaval()
	{
		return "æµ·æ´‹";
	}

	protected override string _GetTemplateForLabelGenreNinja()
	{
		return "æ ¼é¬¥";
	}

	protected override string _GetTemplateForLabelGenrePirate()
	{
		return "æµ·æ´‹";
	}

	protected override string _GetTemplateForLabelGenreRPG()
	{
		return "è§’è‰²æ‰®æ¼”";
	}

	protected override string _GetTemplateForLabelGenreScary()
	{
		return "ææ€–";
	}

	protected override string _GetTemplateForLabelGenreSciFi()
	{
		return "ç§‘å¹»";
	}

	protected override string _GetTemplateForLabelGenreSports()
	{
		return "é«”è‚²";
	}

	protected override string _GetTemplateForLabelGenreTownAndCity()
	{
		return "å¸‚éŽ®";
	}

	protected override string _GetTemplateForLabelGenreTutorial()
	{
		return "å»ºé€ ";
	}

	protected override string _GetTemplateForLabelGenreWar()
	{
		return "è»äº‹";
	}

	protected override string _GetTemplateForLabelGenreWestern()
	{
		return "è¥¿æ–¹";
	}

	protected override string _GetTemplateForLabelGenreWildWest()
	{
		return "è¥¿æ–¹";
	}

	protected override string _GetTemplateForLabelHeads()
	{
		return "é ­éƒ¨";
	}

	protected override string _GetTemplateForLabelMostFavorited()
	{
		return "æœ€å—å–œæ„›";
	}

	protected override string _GetTemplateForLabelNoResellers()
	{
		return "æ²’æœ‰äººè½‰è³£";
	}

	protected override string _GetTemplateForLabelOffSale()
	{
		return "ä¸‹æž¶";
	}

	protected override string _GetTemplateForLabelPackages()
	{
		return "å¥—è£";
	}

	protected override string _GetTemplateForLabelPants()
	{
		return "è¤²å­";
	}

	protected override string _GetTemplateForLabelPastDay()
	{
		return "å‰ä¸€æ—¥";
	}

	protected override string _GetTemplateForLabelPastWeek()
	{
		return "å‰ä¸€é€±";
	}

	protected override string _GetTemplateForLabelPriceHighFirst()
	{
		return "åƒ¹æ ¼ï¼ˆç”±é«˜åˆ°ä½Žï¼‰";
	}

	protected override string _GetTemplateForLabelPriceLowFirst()
	{
		return "åƒ¹æ ¼ï¼ˆç”±ä½Žåˆ°é«˜ï¼‰";
	}

	protected override string _GetTemplateForLabelRecentlyUpdated()
	{
		return "æœ€è¿‘æ›´æ–°";
	}

	protected override string _GetTemplateForLabelRelevance()
	{
		return "é—œè¯æ€§";
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
		return "è¥¯è¡«";
	}

	protected override string _GetTemplateForLabelTShirts()
	{
		return "Tæ¤";
	}

	protected override string _GetTemplateForResponseErrorFilter()
	{
		return "ç¯©é¸æ¨™ç±¤æœ‰éŒ¯èª¤";
	}

	protected override string _GetTemplateForResponseGenericError()
	{
		return "ç™¼ç”ŸéŒ¯èª¤ï¼Œè«‹ç¨å¾Œå†è©¦ã€‚";
	}

	protected override string _GetTemplateForResponseNoItemsFound()
	{
		return "æ‰¾ä¸åˆ°é“å…·ã€‚";
	}

	protected override string _GetTemplateForResponseNoSaleItemsFromSearch()
	{
		return "æ‚¨çš„æœå°‹æ‰¾ä¸åˆ°è²©è³£ä¸­é“å…·ï¼Œä¸é–‹æ”¾çš„é“å…·é¡¯ç¤ºå¦‚ä¸‹ã€‚";
	}

	protected override string _GetTemplateForResponseTemporarilyUnavailable()
	{
		return "æš«æ™‚ç„¡æ³•ä½¿ç”¨åž‹éŒ„ï¼Œè«‹ç¨å¾Œå†è©¦ã€‚";
	}

	protected override string _GetTemplateForResponseThrottled()
	{
		return "è«‹æ±‚éŽæ–¼é »ç¹ï¼è«‹ 1 åˆ†é˜å¾Œå†è©¦ã€‚";
	}
}


}
