namespace Roblox.TranslationResources.Feature;

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
	public override string ActionBuyRobux => "購買 Robux";

	/// <summary>
	/// Key: "Action.Dialog.AddGearOk"
	/// English String: "OK"
	/// </summary>
	public override string ActionDialogAddGearOk => "確定";

	/// <summary>
	/// Key: "Action.Filter.Apply"
	/// English String: "Apply"
	/// </summary>
	public override string ActionFilterApply => "套用";

	/// <summary>
	/// Key: "Action.Filter.Cancel"
	/// English String: "Cancel"
	/// </summary>
	public override string ActionFilterCancel => "取消";

	/// <summary>
	/// Key: "Action.Go"
	/// English String: "Go"
	/// </summary>
	public override string ActionGo => "開始";

	/// <summary>
	/// Key: "Action.ViewAllItems"
	/// English String: "View All Items"
	/// </summary>
	public override string ActionViewAllItems => "檢視所有道具";

	/// <summary>
	/// Key: "Description.Dialog.AddGearBody"
	/// English String: "To add gear to your game, find an item in the catalog and click the Add to Game button. The item will automatically be allowed in game, and you'll receive a commission on every copy sold from your game page. (You can only add gear that's for sale.)"
	/// </summary>
	public override string DescriptionDialogAddGearBody => "若要在您的遊戲加入裝備，請在型錄中找到道具，按下「加到遊戲」按鈕。此道具會自動在遊戲中允許使用，而您可以從您的遊戲裡販賣的道具抽成（只可以加入販賣中的裝備）。";

	/// <summary>
	/// Key: "Heading.CatalogCategory"
	/// English String: "Category"
	/// </summary>
	public override string HeadingCatalogCategory => "類別";

	/// <summary>
	/// Key: "Heading.CatalogPage"
	/// English String: "Catalog"
	/// </summary>
	public override string HeadingCatalogPage => "型錄";

	/// <summary>
	/// Key: "Label.AllFeaturedItems"
	/// English String: "View All Featured Items"
	/// </summary>
	public override string LabelAllFeaturedItems => "檢視所有精選項目";

	/// <summary>
	/// Key: "Label.AllGenres"
	/// English String: "All Genres"
	/// </summary>
	public override string LabelAllGenres => "所有類別";

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
	public override string LabelBreadCrumbFree => "免費";

	/// <summary>
	/// Key: "Label.BreadCrumb.Group"
	/// English String: "Group:"
	/// </summary>
	public override string LabelBreadCrumbGroup => "群組：";

	/// <summary>
	/// Key: "Label.Bundle"
	/// Bundle
	/// English String: "Bundle"
	/// </summary>
	public override string LabelBundle => "組合";

	/// <summary>
	/// Key: "Label.Bundles"
	/// Bundles
	/// English String: "Bundles"
	/// </summary>
	public override string LabelBundles => "組合";

	/// <summary>
	/// Key: "Label.Card.CreatorBy"
	/// English String: "By"
	/// </summary>
	public override string LabelCardCreatorBy => "創作者 :";

	/// <summary>
	/// Key: "Label.Card.PriceWas"
	/// English String: "Was"
	/// </summary>
	public override string LabelCardPriceWas => "原價";

	/// <summary>
	/// Key: "Label.Card.Remaining"
	/// English String: "Remaining:"
	/// </summary>
	public override string LabelCardRemaining => "還剩：";

	/// <summary>
	/// Key: "Label.CategoryAttributes"
	/// English String: "Attributes"
	/// </summary>
	public override string LabelCategoryAttributes => "屬性";

	/// <summary>
	/// Key: "Label.CategoryType"
	/// English String: "Type"
	/// </summary>
	public override string LabelCategoryType => "類型";

	/// <summary>
	/// Key: "Label.CommunityCreations"
	/// UGC items
	/// English String: " Community Creations"
	/// </summary>
	public override string LabelCommunityCreations => "社群創作";

	/// <summary>
	/// Key: "Label.Dialog.AddGearTitle"
	/// English String: "Add Gear to Your Game"
	/// </summary>
	public override string LabelDialogAddGearTitle => "將裝備加到您的遊戲";

	/// <summary>
	/// Key: "Label.Emotes"
	/// Emotes
	/// English String: "Emotes"
	/// </summary>
	public override string LabelEmotes => "動作";

	/// <summary>
	/// Key: "Label.Favorites"
	/// English String: "Favorites"
	/// </summary>
	public override string LabelFavorites => "設為最愛";

	/// <summary>
	/// Key: "Label.FeaturedBundles"
	/// Featured Bundles
	/// English String: "Featured Bundles"
	/// </summary>
	public override string LabelFeaturedBundles => "精選組合";

	/// <summary>
	/// Key: "Label.FeaturedEmotes"
	/// Featured Emotes
	/// English String: "Featured Emotes"
	/// </summary>
	public override string LabelFeaturedEmotes => "精選動作";

	/// <summary>
	/// Key: "Label.Filter.ByTime"
	/// English String: "By Time"
	/// </summary>
	public override string LabelFilterByTime => "依時間";

	/// <summary>
	/// Key: "Label.Filter.Category"
	/// English String: "Category"
	/// </summary>
	public override string LabelFilterCategory => "類別";

	/// <summary>
	/// Key: "Label.Filter.Creator"
	/// English String: "Creator"
	/// </summary>
	public override string LabelFilterCreator => "創作者";

	/// <summary>
	/// Key: "Label.Filter.Filter"
	/// English String: "Filter"
	/// </summary>
	public override string LabelFilterFilter => "篩選";

	/// <summary>
	/// Key: "Label.Filter.Filters"
	/// English String: "Filters"
	/// </summary>
	public override string LabelFilterFilters => "篩選條件";

	/// <summary>
	/// Key: "Label.Filter.Genre"
	/// English String: "Genre"
	/// </summary>
	public override string LabelFilterGenre => "類別";

	/// <summary>
	/// Key: "Label.Filter.Hide"
	/// English String: "Hide"
	/// </summary>
	public override string LabelFilterHide => "隱藏";

	/// <summary>
	/// Key: "Label.Filter.Price"
	/// English String: "Price"
	/// </summary>
	public override string LabelFilterPrice => "價格";

	/// <summary>
	/// Key: "Label.Filter.PriceMax"
	/// English String: "Max"
	/// </summary>
	public override string LabelFilterPriceMax => "最高";

	/// <summary>
	/// Key: "Label.Filter.PriceMin"
	/// English String: "Min"
	/// </summary>
	public override string LabelFilterPriceMin => "最低";

	/// <summary>
	/// Key: "Label.Filter.PriceTo"
	/// English String: "To"
	/// </summary>
	public override string LabelFilterPriceTo => "到";

	/// <summary>
	/// Key: "Label.Filter.Show"
	/// English String: "Show"
	/// </summary>
	public override string LabelFilterShow => "顯示";

	/// <summary>
	/// Key: "Label.Filter.Sorting"
	/// English String: "Sorting"
	/// </summary>
	public override string LabelFilterSorting => "排序";

	/// <summary>
	/// Key: "Label.Filter.UnavailableItems"
	/// English String: "Unavailable Items"
	/// </summary>
	public override string LabelFilterUnavailableItems => "不開放的道具";

	/// <summary>
	/// Key: "Label.GoogleOnly"
	/// label
	/// English String: "Google Only"
	/// </summary>
	public override string LabelGoogleOnly => "Google 限定";

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
	public override string LabelMobile => "行動電訊";

	/// <summary>
	/// Key: "Label.New"
	/// label
	/// English String: "New"
	/// </summary>
	public override string LabelNew => "新增";

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
	public override string LabelSale => "促銷";

	/// <summary>
	/// Key: "Label.SearchField"
	/// English String: "Search"
	/// </summary>
	public override string LabelSearchField => "搜尋";

	/// <summary>
	/// Key: "Label.SeeAll"
	/// English String: "See All"
	/// </summary>
	public override string LabelSeeAll => "查看全部";

	/// <summary>
	/// Key: "Label.Username"
	/// English String: "Username"
	/// </summary>
	public override string LabelUsername => "使用者名稱";

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
	public override string LabelAccessories => "飾品";

	/// <summary>
	/// Key: "LabelAccessoryAll"
	/// English String: "All Accessories"
	/// </summary>
	public override string LabelAccessoryAll => "所有飾品";

	/// <summary>
	/// Key: "LabelAccessoryBack"
	/// English String: "Back"
	/// </summary>
	public override string LabelAccessoryBack => "背面";

	/// <summary>
	/// Key: "LabelAccessoryFace"
	/// English String: "Face"
	/// </summary>
	public override string LabelAccessoryFace => "臉部";

	/// <summary>
	/// Key: "LabelAccessoryFront"
	/// English String: "Front"
	/// </summary>
	public override string LabelAccessoryFront => "正面";

	/// <summary>
	/// Key: "LabelAccessoryHair"
	/// English String: "Hair"
	/// </summary>
	public override string LabelAccessoryHair => "髮型";

	/// <summary>
	/// Key: "LabelAccessoryHats"
	/// English String: "Hats"
	/// </summary>
	public override string LabelAccessoryHats => "帽子";

	/// <summary>
	/// Key: "LabelAccessoryNeck"
	/// English String: "Neck"
	/// </summary>
	public override string LabelAccessoryNeck => "頸部";

	/// <summary>
	/// Key: "LabelAccessoryShoulder"
	/// English String: "Shoulder"
	/// </summary>
	public override string LabelAccessoryShoulder => "肩膀";

	/// <summary>
	/// Key: "LabelAccessoryWaist"
	/// English String: "Waist"
	/// </summary>
	public override string LabelAccessoryWaist => "腰部";

	/// <summary>
	/// Key: "LabelAll"
	/// English String: "All"
	/// </summary>
	public override string LabelAll => "全部";

	/// <summary>
	/// Key: "LabelAllBodyParts"
	/// English String: "All Body Parts"
	/// </summary>
	public override string LabelAllBodyParts => "所有身體部位";

	/// <summary>
	/// Key: "LabelAllCategories"
	/// English String: "All Categories"
	/// </summary>
	public override string LabelAllCategories => "所有類別";

	/// <summary>
	/// Key: "LabelAllClothing"
	/// English String: "All Clothing"
	/// </summary>
	public override string LabelAllClothing => "所有服裝";

	/// <summary>
	/// Key: "LabelAllCollectibles"
	/// English String: "All Collectibles"
	/// </summary>
	public override string LabelAllCollectibles => "所有收藏品";

	/// <summary>
	/// Key: "LabelAllCreators"
	/// English String: "All Creators"
	/// </summary>
	public override string LabelAllCreators => "所有創作者";

	/// <summary>
	/// Key: "LabelAllCurrency"
	/// English String: "All Currency"
	/// </summary>
	public override string LabelAllCurrency => "所有貨幣";

	/// <summary>
	/// Key: "LabelAllFeatured"
	/// English String: "All Featured Items"
	/// </summary>
	public override string LabelAllFeatured => "所有精選道具";

	/// <summary>
	/// Key: "LabelAllTime"
	/// English String: "All Time"
	/// </summary>
	public override string LabelAllTime => "歷來";

	/// <summary>
	/// Key: "LabelAnimations"
	/// English String: "Animations"
	/// </summary>
	public override string LabelAnimations => "動畫";

	/// <summary>
	/// Key: "LabelAnyPrice"
	/// English String: "Any Price"
	/// </summary>
	public override string LabelAnyPrice => "任何價格";

	/// <summary>
	/// Key: "LabelAvatarAnimations"
	/// English String: "Avatar Animations"
	/// </summary>
	public override string LabelAvatarAnimations => "虛擬人偶動畫";

	/// <summary>
	/// Key: "LabelBestselling"
	/// English String: "Bestselling"
	/// </summary>
	public override string LabelBestselling => "暢銷";

	/// <summary>
	/// Key: "LabelBodyParts"
	/// English String: "Body Parts"
	/// </summary>
	public override string LabelBodyParts => "身體部位";

	/// <summary>
	/// Key: "LabelClothing"
	/// English String: "Clothing"
	/// </summary>
	public override string LabelClothing => "服裝";

	/// <summary>
	/// Key: "LabelCollectibleAccessories"
	/// English String: "Collectible Accessories"
	/// </summary>
	public override string LabelCollectibleAccessories => "可收藏的飾品";

	/// <summary>
	/// Key: "LabelCollectibleFaces"
	/// English String: "Collectible Faces"
	/// </summary>
	public override string LabelCollectibleFaces => "臉部收藏品";

	/// <summary>
	/// Key: "LabelCollectibleGear"
	/// English String: "Collectible Gear"
	/// </summary>
	public override string LabelCollectibleGear => "裝備收藏品";

	/// <summary>
	/// Key: "LabelCollectibles"
	/// English String: "Collectibles"
	/// </summary>
	public override string LabelCollectibles => "收藏品";

	/// <summary>
	/// Key: "LabelFaces"
	/// English String: "Faces"
	/// </summary>
	public override string LabelFaces => "臉部";

	/// <summary>
	/// Key: "LabelFeatured"
	/// English String: "Featured"
	/// </summary>
	public override string LabelFeatured => "精選";

	/// <summary>
	/// Key: "LabelFeaturedAccesories"
	/// English String: "Featured Accessories"
	/// </summary>
	public override string LabelFeaturedAccesories => "精選飾品";

	/// <summary>
	/// Key: "LabelFeaturedAnimations"
	/// English String: "Featured Animations"
	/// </summary>
	public override string LabelFeaturedAnimations => "精選動畫";

	/// <summary>
	/// Key: "LabelFeaturedFaces"
	/// English String: "Featured Faces"
	/// </summary>
	public override string LabelFeaturedFaces => "精選表情";

	/// <summary>
	/// Key: "LabelFeaturedGear"
	/// English String: "Featured Gear"
	/// </summary>
	public override string LabelFeaturedGear => "精選裝備";

	/// <summary>
	/// Key: "LabelFeaturedPackages"
	/// English String: "Featured Packages"
	/// </summary>
	public override string LabelFeaturedPackages => "精選套裝";

	/// <summary>
	/// Key: "LabelFree"
	/// English String: "Free"
	/// </summary>
	public override string LabelFree => "免費";

	/// <summary>
	/// Key: "LabelGear"
	/// English String: "Gear"
	/// </summary>
	public override string LabelGear => "裝備";

	/// <summary>
	/// Key: "LabelGearAll"
	/// English String: "All Gear"
	/// </summary>
	public override string LabelGearAll => "所有裝備";

	/// <summary>
	/// Key: "LabelGearBuilding"
	/// English String: "Building"
	/// </summary>
	public override string LabelGearBuilding => "建築";

	/// <summary>
	/// Key: "LabelGearExplosive"
	/// English String: "Explosive"
	/// </summary>
	public override string LabelGearExplosive => "爆裂";

	/// <summary>
	/// Key: "LabelGearMelee"
	/// English String: "Melee"
	/// </summary>
	public override string LabelGearMelee => "近戰";

	/// <summary>
	/// Key: "LabelGearMusical"
	/// English String: "Musical"
	/// </summary>
	public override string LabelGearMusical => "音樂";

	/// <summary>
	/// Key: "LabelGearNavigation"
	/// English String: "Navigation"
	/// </summary>
	public override string LabelGearNavigation => "導航";

	/// <summary>
	/// Key: "LabelGearPersonalTransport"
	/// English String: "Transport"
	/// </summary>
	public override string LabelGearPersonalTransport => "運輸";

	/// <summary>
	/// Key: "LabelGearPowerUps"
	/// English String: "Power Up"
	/// </summary>
	public override string LabelGearPowerUps => "強化";

	/// <summary>
	/// Key: "LabelGearRanged"
	/// English String: "Ranged"
	/// </summary>
	public override string LabelGearRanged => "遠程";

	/// <summary>
	/// Key: "LabelGearSocial"
	/// English String: "Social"
	/// </summary>
	public override string LabelGearSocial => "社交";

	/// <summary>
	/// Key: "LabelGenreAdventure"
	/// English String: "Adventure"
	/// </summary>
	public override string LabelGenreAdventure => "探險";

	/// <summary>
	/// Key: "LabelGenreAll"
	/// English String: "All Genres"
	/// </summary>
	public override string LabelGenreAll => "所有類別";

	/// <summary>
	/// Key: "LabelGenreBuilding"
	/// English String: "Building"
	/// </summary>
	public override string LabelGenreBuilding => "建造";

	/// <summary>
	/// Key: "LabelGenreComedy"
	/// English String: "Comedy"
	/// </summary>
	public override string LabelGenreComedy => "搞笑";

	/// <summary>
	/// Key: "LabelGenreFantasy"
	/// English String: "Medieval"
	/// </summary>
	public override string LabelGenreFantasy => "中古";

	/// <summary>
	/// Key: "LabelGenreFighting"
	/// English String: "Fighting"
	/// </summary>
	public override string LabelGenreFighting => "格鬥";

	/// <summary>
	/// Key: "LabelGenreFPS"
	/// English String: "FPS"
	/// </summary>
	public override string LabelGenreFPS => "射擊";

	/// <summary>
	/// Key: "LabelGenreFunny"
	/// English String: "Comedy"
	/// </summary>
	public override string LabelGenreFunny => "搞笑";

	/// <summary>
	/// Key: "LabelGenreHorror"
	/// English String: "Horror"
	/// </summary>
	public override string LabelGenreHorror => "恐怖";

	/// <summary>
	/// Key: "LabelGenreMedieval"
	/// English String: "Medieval"
	/// </summary>
	public override string LabelGenreMedieval => "中古";

	/// <summary>
	/// Key: "LabelGenreMilitary"
	/// English String: "Military"
	/// </summary>
	public override string LabelGenreMilitary => "軍事";

	/// <summary>
	/// Key: "LabelGenreNaval"
	/// English String: "Naval"
	/// </summary>
	public override string LabelGenreNaval => "海洋";

	/// <summary>
	/// Key: "LabelGenreNinja"
	/// English String: "Fighting"
	/// </summary>
	public override string LabelGenreNinja => "格鬥";

	/// <summary>
	/// Key: "LabelGenrePirate"
	/// English String: "Naval"
	/// </summary>
	public override string LabelGenrePirate => "海洋";

	/// <summary>
	/// Key: "LabelGenreRPG"
	/// English String: "RPG"
	/// </summary>
	public override string LabelGenreRPG => "角色扮演";

	/// <summary>
	/// Key: "LabelGenreScary"
	/// English String: "Horror"
	/// </summary>
	public override string LabelGenreScary => "恐怖";

	/// <summary>
	/// Key: "LabelGenreSciFi"
	/// English String: "Sci-Fi"
	/// </summary>
	public override string LabelGenreSciFi => "科幻";

	/// <summary>
	/// Key: "LabelGenreSports"
	/// English String: "Sports"
	/// </summary>
	public override string LabelGenreSports => "體育";

	/// <summary>
	/// Key: "LabelGenreTownAndCity"
	/// English String: "Town and City"
	/// </summary>
	public override string LabelGenreTownAndCity => "市鎮";

	/// <summary>
	/// Key: "LabelGenreTutorial"
	/// English String: "Building"
	/// </summary>
	public override string LabelGenreTutorial => "建造";

	/// <summary>
	/// Key: "LabelGenreWar"
	/// English String: "Military"
	/// </summary>
	public override string LabelGenreWar => "軍事";

	/// <summary>
	/// Key: "LabelGenreWestern"
	/// English String: "Western"
	/// </summary>
	public override string LabelGenreWestern => "西方";

	/// <summary>
	/// Key: "LabelGenreWildWest"
	/// English String: "Western"
	/// </summary>
	public override string LabelGenreWildWest => "西方";

	/// <summary>
	/// Key: "LabelHeads"
	/// English String: "Heads"
	/// </summary>
	public override string LabelHeads => "頭部";

	/// <summary>
	/// Key: "LabelMostFavorited"
	/// English String: "Most Favorited"
	/// </summary>
	public override string LabelMostFavorited => "最受喜愛";

	/// <summary>
	/// Key: "LabelNoResellers"
	/// English String: "No Resellers"
	/// </summary>
	public override string LabelNoResellers => "沒有人轉賣";

	/// <summary>
	/// Key: "LabelOffSale"
	/// English String: "Offsale"
	/// </summary>
	public override string LabelOffSale => "下架";

	/// <summary>
	/// Key: "LabelPackages"
	/// English String: "Packages"
	/// </summary>
	public override string LabelPackages => "套裝";

	/// <summary>
	/// Key: "LabelPants"
	/// English String: "Pants"
	/// </summary>
	public override string LabelPants => "褲子";

	/// <summary>
	/// Key: "LabelPastDay"
	/// English String: "Past Day"
	/// </summary>
	public override string LabelPastDay => "前一日";

	/// <summary>
	/// Key: "LabelPastWeek"
	/// English String: "Past Week"
	/// </summary>
	public override string LabelPastWeek => "前一週";

	/// <summary>
	/// Key: "LabelPriceHighFirst"
	/// English String: "Price (High to Low)"
	/// </summary>
	public override string LabelPriceHighFirst => "價格（由高到低）";

	/// <summary>
	/// Key: "LabelPriceLowFirst"
	/// English String: "Price (Low to High)"
	/// </summary>
	public override string LabelPriceLowFirst => "價格（由低到高）";

	/// <summary>
	/// Key: "LabelRecentlyUpdated"
	/// English String: "Recently Updated"
	/// </summary>
	public override string LabelRecentlyUpdated => "最近更新";

	/// <summary>
	/// Key: "LabelRelevance"
	/// English String: "Relevance"
	/// </summary>
	public override string LabelRelevance => "關聯性";

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
	public override string LabelShirts => "襯衫";

	/// <summary>
	/// Key: "LabelTShirts"
	/// English String: "T-Shirts"
	/// </summary>
	public override string LabelTShirts => "T恤";

	/// <summary>
	/// Key: "Response.Error.Filter"
	/// English String: "Errors exist in Filter tab"
	/// </summary>
	public override string ResponseErrorFilter => "篩選標籤有錯誤";

	/// <summary>
	/// Key: "Response.GenericError"
	/// English String: "An error occurred. Please try again later."
	/// </summary>
	public override string ResponseGenericError => "發生錯誤，請稍後再試。";

	/// <summary>
	/// Key: "Response.NoItemsFound"
	/// English String: "No items found."
	/// </summary>
	public override string ResponseNoItemsFound => "找不到道具。";

	/// <summary>
	/// Key: "Response.NoSaleItemsFromSearch"
	/// English String: "Your search did not find items for sale. Unavailable items displayed below."
	/// </summary>
	public override string ResponseNoSaleItemsFromSearch => "您的搜尋找不到販賣中道具，不開放的道具顯示如下。";

	/// <summary>
	/// Key: "Response.TemporarilyUnavailable"
	/// English String: "Catalog temporarily unavailable. Please try again later."
	/// </summary>
	public override string ResponseTemporarilyUnavailable => "暫時無法使用型錄，請稍後再試。";

	/// <summary>
	/// Key: "Response.Throttled"
	/// Shown to users when they have made too many requests in a minute and are being throttled.
	/// English String: "You're going too fast! Try again in a minute."
	/// </summary>
	public override string ResponseThrottled => "請求過於頻繁！請 1 分鐘後再試。";

	public CatalogResources_zh_tw(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionBuyRobux()
	{
		return "購買 Robux";
	}

	protected override string _GetTemplateForActionDialogAddGearOk()
	{
		return "確定";
	}

	protected override string _GetTemplateForActionFilterApply()
	{
		return "套用";
	}

	protected override string _GetTemplateForActionFilterCancel()
	{
		return "取消";
	}

	protected override string _GetTemplateForActionGo()
	{
		return "開始";
	}

	protected override string _GetTemplateForActionViewAllItems()
	{
		return "檢視所有道具";
	}

	protected override string _GetTemplateForDescriptionDialogAddGearBody()
	{
		return "若要在您的遊戲加入裝備，請在型錄中找到道具，按下「加到遊戲」按鈕。此道具會自動在遊戲中允許使用，而您可以從您的遊戲裡販賣的道具抽成（只可以加入販賣中的裝備）。";
	}

	protected override string _GetTemplateForHeadingCatalogCategory()
	{
		return "類別";
	}

	protected override string _GetTemplateForHeadingCatalogPage()
	{
		return "型錄";
	}

	protected override string _GetTemplateForLabelAllFeaturedItems()
	{
		return "檢視所有精選項目";
	}

	protected override string _GetTemplateForLabelAllGenres()
	{
		return "所有類別";
	}

	protected override string _GetTemplateForLabelAmazon()
	{
		return "Amazon";
	}

	protected override string _GetTemplateForLabelBreadCrumbFree()
	{
		return "免費";
	}

	/// <summary>
	/// Key: "Label.BreadCrumb.GenreOrText"
	/// English String: "{genreName1} or {genreName2}"
	/// </summary>
	public override string LabelBreadCrumbGenreOrText(string genreName1, string genreName2)
	{
		return $"{genreName1}或{genreName2}";
	}

	protected override string _GetTemplateForLabelBreadCrumbGenreOrText()
	{
		return "{genreName1}或{genreName2}";
	}

	/// <summary>
	/// Key: "Label.BreadCrumb.GenreSelectedText"
	/// English String: "Genre: {genreCount} selected"
	/// </summary>
	public override string LabelBreadCrumbGenreSelectedText(string genreCount)
	{
		return $"類別：已選擇 {genreCount} 種";
	}

	protected override string _GetTemplateForLabelBreadCrumbGenreSelectedText()
	{
		return "類別：已選擇 {genreCount} 種";
	}

	protected override string _GetTemplateForLabelBreadCrumbGroup()
	{
		return "群組：";
	}

	/// <summary>
	/// Key: "Label.BreadCrumb.PriceAbove"
	/// English String: "{price} and above"
	/// </summary>
	public override string LabelBreadCrumbPriceAbove(string price)
	{
		return $"{price} 及以上";
	}

	protected override string _GetTemplateForLabelBreadCrumbPriceAbove()
	{
		return "{price} 及以上";
	}

	/// <summary>
	/// Key: "Label.BreadCrumb.PriceBelow"
	/// English String: "{price} and below"
	/// </summary>
	public override string LabelBreadCrumbPriceBelow(string price)
	{
		return $"{price} 以下";
	}

	protected override string _GetTemplateForLabelBreadCrumbPriceBelow()
	{
		return "{price} 以下";
	}

	/// <summary>
	/// Key: "Label.BreadCrumb.ResultsCount"
	/// English String: "{startNumber} - {endNumber} of {resultsCount} Results"
	/// </summary>
	public override string LabelBreadCrumbResultsCount(string startNumber, string endNumber, string resultsCount)
	{
		return $"{resultsCount} 個結果中的第 {startNumber} - {endNumber} 項";
	}

	protected override string _GetTemplateForLabelBreadCrumbResultsCount()
	{
		return "{resultsCount} 個結果中的第 {startNumber} - {endNumber} 項";
	}

	protected override string _GetTemplateForLabelBundle()
	{
		return "組合";
	}

	protected override string _GetTemplateForLabelBundles()
	{
		return "組合";
	}

	/// <summary>
	/// Key: "Label.ByCreatorLink"
	/// Creator name in item card with link
	/// English String: "By {linkStart}{creator}{linkEnd}"
	/// </summary>
	public override string LabelByCreatorLink(string linkStart, string creator, string linkEnd)
	{
		return $"創作者：{linkStart}{creator}{linkEnd}";
	}

	protected override string _GetTemplateForLabelByCreatorLink()
	{
		return "創作者：{linkStart}{creator}{linkEnd}";
	}

	protected override string _GetTemplateForLabelCardCreatorBy()
	{
		return "創作者 :";
	}

	protected override string _GetTemplateForLabelCardPriceWas()
	{
		return "原價";
	}

	protected override string _GetTemplateForLabelCardRemaining()
	{
		return "還剩：";
	}

	protected override string _GetTemplateForLabelCategoryAttributes()
	{
		return "屬性";
	}

	protected override string _GetTemplateForLabelCategoryType()
	{
		return "類型";
	}

	protected override string _GetTemplateForLabelCommunityCreations()
	{
		return "社群創作";
	}

	protected override string _GetTemplateForLabelDialogAddGearTitle()
	{
		return "將裝備加到您的遊戲";
	}

	protected override string _GetTemplateForLabelEmotes()
	{
		return "動作";
	}

	protected override string _GetTemplateForLabelFavorites()
	{
		return "設為最愛";
	}

	protected override string _GetTemplateForLabelFeaturedBundles()
	{
		return "精選組合";
	}

	protected override string _GetTemplateForLabelFeaturedEmotes()
	{
		return "精選動作";
	}

	/// <summary>
	/// Key: "Label.FeaturedItemsOnRoblox"
	/// English String: "Featured Items on {spanStart}{roblox}{spanEnd}"
	/// </summary>
	public override string LabelFeaturedItemsOnRoblox(string spanStart, string roblox, string spanEnd)
	{
		return $"{spanStart}{roblox}{spanEnd} 精選道具";
	}

	protected override string _GetTemplateForLabelFeaturedItemsOnRoblox()
	{
		return "{spanStart}{roblox}{spanEnd} 精選道具";
	}

	protected override string _GetTemplateForLabelFilterByTime()
	{
		return "依時間";
	}

	protected override string _GetTemplateForLabelFilterCategory()
	{
		return "類別";
	}

	protected override string _GetTemplateForLabelFilterCreator()
	{
		return "創作者";
	}

	protected override string _GetTemplateForLabelFilterFilter()
	{
		return "篩選";
	}

	protected override string _GetTemplateForLabelFilterFilters()
	{
		return "篩選條件";
	}

	protected override string _GetTemplateForLabelFilterGenre()
	{
		return "類別";
	}

	protected override string _GetTemplateForLabelFilterHide()
	{
		return "隱藏";
	}

	protected override string _GetTemplateForLabelFilterPrice()
	{
		return "價格";
	}

	protected override string _GetTemplateForLabelFilterPriceMax()
	{
		return "最高";
	}

	protected override string _GetTemplateForLabelFilterPriceMin()
	{
		return "最低";
	}

	protected override string _GetTemplateForLabelFilterPriceTo()
	{
		return "到";
	}

	protected override string _GetTemplateForLabelFilterShow()
	{
		return "顯示";
	}

	protected override string _GetTemplateForLabelFilterSorting()
	{
		return "排序";
	}

	protected override string _GetTemplateForLabelFilterUnavailableItems()
	{
		return "不開放的道具";
	}

	protected override string _GetTemplateForLabelGoogleOnly()
	{
		return "Google 限定";
	}

	protected override string _GetTemplateForLabelIos()
	{
		return "IOS";
	}

	protected override string _GetTemplateForLabelMobile()
	{
		return "行動電訊";
	}

	protected override string _GetTemplateForLabelNew()
	{
		return "新增";
	}

	protected override string _GetTemplateForLabelRthro()
	{
		return "Rthro";
	}

	protected override string _GetTemplateForLabelSale()
	{
		return "促銷";
	}

	protected override string _GetTemplateForLabelSearchField()
	{
		return "搜尋";
	}

	protected override string _GetTemplateForLabelSeeAll()
	{
		return "查看全部";
	}

	protected override string _GetTemplateForLabelUsername()
	{
		return "使用者名稱";
	}

	protected override string _GetTemplateForLabelXbox()
	{
		return "Xbox";
	}

	protected override string _GetTemplateForLabelAccessories()
	{
		return "飾品";
	}

	protected override string _GetTemplateForLabelAccessoryAll()
	{
		return "所有飾品";
	}

	protected override string _GetTemplateForLabelAccessoryBack()
	{
		return "背面";
	}

	protected override string _GetTemplateForLabelAccessoryFace()
	{
		return "臉部";
	}

	protected override string _GetTemplateForLabelAccessoryFront()
	{
		return "正面";
	}

	protected override string _GetTemplateForLabelAccessoryHair()
	{
		return "髮型";
	}

	protected override string _GetTemplateForLabelAccessoryHats()
	{
		return "帽子";
	}

	protected override string _GetTemplateForLabelAccessoryNeck()
	{
		return "頸部";
	}

	protected override string _GetTemplateForLabelAccessoryShoulder()
	{
		return "肩膀";
	}

	protected override string _GetTemplateForLabelAccessoryWaist()
	{
		return "腰部";
	}

	protected override string _GetTemplateForLabelAll()
	{
		return "全部";
	}

	protected override string _GetTemplateForLabelAllBodyParts()
	{
		return "所有身體部位";
	}

	protected override string _GetTemplateForLabelAllCategories()
	{
		return "所有類別";
	}

	protected override string _GetTemplateForLabelAllClothing()
	{
		return "所有服裝";
	}

	protected override string _GetTemplateForLabelAllCollectibles()
	{
		return "所有收藏品";
	}

	protected override string _GetTemplateForLabelAllCreators()
	{
		return "所有創作者";
	}

	protected override string _GetTemplateForLabelAllCurrency()
	{
		return "所有貨幣";
	}

	protected override string _GetTemplateForLabelAllFeatured()
	{
		return "所有精選道具";
	}

	protected override string _GetTemplateForLabelAllTime()
	{
		return "歷來";
	}

	protected override string _GetTemplateForLabelAnimations()
	{
		return "動畫";
	}

	protected override string _GetTemplateForLabelAnyPrice()
	{
		return "任何價格";
	}

	protected override string _GetTemplateForLabelAvatarAnimations()
	{
		return "虛擬人偶動畫";
	}

	protected override string _GetTemplateForLabelBestselling()
	{
		return "暢銷";
	}

	protected override string _GetTemplateForLabelBodyParts()
	{
		return "身體部位";
	}

	protected override string _GetTemplateForLabelClothing()
	{
		return "服裝";
	}

	protected override string _GetTemplateForLabelCollectibleAccessories()
	{
		return "可收藏的飾品";
	}

	protected override string _GetTemplateForLabelCollectibleFaces()
	{
		return "臉部收藏品";
	}

	protected override string _GetTemplateForLabelCollectibleGear()
	{
		return "裝備收藏品";
	}

	protected override string _GetTemplateForLabelCollectibles()
	{
		return "收藏品";
	}

	protected override string _GetTemplateForLabelFaces()
	{
		return "臉部";
	}

	protected override string _GetTemplateForLabelFeatured()
	{
		return "精選";
	}

	protected override string _GetTemplateForLabelFeaturedAccesories()
	{
		return "精選飾品";
	}

	protected override string _GetTemplateForLabelFeaturedAnimations()
	{
		return "精選動畫";
	}

	protected override string _GetTemplateForLabelFeaturedFaces()
	{
		return "精選表情";
	}

	protected override string _GetTemplateForLabelFeaturedGear()
	{
		return "精選裝備";
	}

	protected override string _GetTemplateForLabelFeaturedPackages()
	{
		return "精選套裝";
	}

	protected override string _GetTemplateForLabelFree()
	{
		return "免費";
	}

	protected override string _GetTemplateForLabelGear()
	{
		return "裝備";
	}

	protected override string _GetTemplateForLabelGearAll()
	{
		return "所有裝備";
	}

	protected override string _GetTemplateForLabelGearBuilding()
	{
		return "建築";
	}

	protected override string _GetTemplateForLabelGearExplosive()
	{
		return "爆裂";
	}

	protected override string _GetTemplateForLabelGearMelee()
	{
		return "近戰";
	}

	protected override string _GetTemplateForLabelGearMusical()
	{
		return "音樂";
	}

	protected override string _GetTemplateForLabelGearNavigation()
	{
		return "導航";
	}

	protected override string _GetTemplateForLabelGearPersonalTransport()
	{
		return "運輸";
	}

	protected override string _GetTemplateForLabelGearPowerUps()
	{
		return "強化";
	}

	protected override string _GetTemplateForLabelGearRanged()
	{
		return "遠程";
	}

	protected override string _GetTemplateForLabelGearSocial()
	{
		return "社交";
	}

	protected override string _GetTemplateForLabelGenreAdventure()
	{
		return "探險";
	}

	protected override string _GetTemplateForLabelGenreAll()
	{
		return "所有類別";
	}

	protected override string _GetTemplateForLabelGenreBuilding()
	{
		return "建造";
	}

	protected override string _GetTemplateForLabelGenreComedy()
	{
		return "搞笑";
	}

	protected override string _GetTemplateForLabelGenreFantasy()
	{
		return "中古";
	}

	protected override string _GetTemplateForLabelGenreFighting()
	{
		return "格鬥";
	}

	protected override string _GetTemplateForLabelGenreFPS()
	{
		return "射擊";
	}

	protected override string _GetTemplateForLabelGenreFunny()
	{
		return "搞笑";
	}

	protected override string _GetTemplateForLabelGenreHorror()
	{
		return "恐怖";
	}

	protected override string _GetTemplateForLabelGenreMedieval()
	{
		return "中古";
	}

	protected override string _GetTemplateForLabelGenreMilitary()
	{
		return "軍事";
	}

	protected override string _GetTemplateForLabelGenreNaval()
	{
		return "海洋";
	}

	protected override string _GetTemplateForLabelGenreNinja()
	{
		return "格鬥";
	}

	protected override string _GetTemplateForLabelGenrePirate()
	{
		return "海洋";
	}

	protected override string _GetTemplateForLabelGenreRPG()
	{
		return "角色扮演";
	}

	protected override string _GetTemplateForLabelGenreScary()
	{
		return "恐怖";
	}

	protected override string _GetTemplateForLabelGenreSciFi()
	{
		return "科幻";
	}

	protected override string _GetTemplateForLabelGenreSports()
	{
		return "體育";
	}

	protected override string _GetTemplateForLabelGenreTownAndCity()
	{
		return "市鎮";
	}

	protected override string _GetTemplateForLabelGenreTutorial()
	{
		return "建造";
	}

	protected override string _GetTemplateForLabelGenreWar()
	{
		return "軍事";
	}

	protected override string _GetTemplateForLabelGenreWestern()
	{
		return "西方";
	}

	protected override string _GetTemplateForLabelGenreWildWest()
	{
		return "西方";
	}

	protected override string _GetTemplateForLabelHeads()
	{
		return "頭部";
	}

	protected override string _GetTemplateForLabelMostFavorited()
	{
		return "最受喜愛";
	}

	protected override string _GetTemplateForLabelNoResellers()
	{
		return "沒有人轉賣";
	}

	protected override string _GetTemplateForLabelOffSale()
	{
		return "下架";
	}

	protected override string _GetTemplateForLabelPackages()
	{
		return "套裝";
	}

	protected override string _GetTemplateForLabelPants()
	{
		return "褲子";
	}

	protected override string _GetTemplateForLabelPastDay()
	{
		return "前一日";
	}

	protected override string _GetTemplateForLabelPastWeek()
	{
		return "前一週";
	}

	protected override string _GetTemplateForLabelPriceHighFirst()
	{
		return "價格（由高到低）";
	}

	protected override string _GetTemplateForLabelPriceLowFirst()
	{
		return "價格（由低到高）";
	}

	protected override string _GetTemplateForLabelRecentlyUpdated()
	{
		return "最近更新";
	}

	protected override string _GetTemplateForLabelRelevance()
	{
		return "關聯性";
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
		return "襯衫";
	}

	protected override string _GetTemplateForLabelTShirts()
	{
		return "T恤";
	}

	protected override string _GetTemplateForResponseErrorFilter()
	{
		return "篩選標籤有錯誤";
	}

	protected override string _GetTemplateForResponseGenericError()
	{
		return "發生錯誤，請稍後再試。";
	}

	protected override string _GetTemplateForResponseNoItemsFound()
	{
		return "找不到道具。";
	}

	protected override string _GetTemplateForResponseNoSaleItemsFromSearch()
	{
		return "您的搜尋找不到販賣中道具，不開放的道具顯示如下。";
	}

	protected override string _GetTemplateForResponseTemporarilyUnavailable()
	{
		return "暫時無法使用型錄，請稍後再試。";
	}

	protected override string _GetTemplateForResponseThrottled()
	{
		return "請求過於頻繁！請 1 分鐘後再試。";
	}
}
