namespace Roblox.TranslationResources.Feature;

/// <summary>
/// This class overrides CatalogResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class CatalogResources_zh_cjv : CatalogResources_en_us, ICatalogResources, ITranslationResources
{
	/// <summary>
	/// Key: "Action.BuyRobux"
	/// English String: "Buy Robux"
	/// </summary>
	public override string ActionBuyRobux => "购买 Robux";

	/// <summary>
	/// Key: "Action.Dialog.AddGearOk"
	/// English String: "OK"
	/// </summary>
	public override string ActionDialogAddGearOk => "好";

	/// <summary>
	/// Key: "Action.Filter.Apply"
	/// English String: "Apply"
	/// </summary>
	public override string ActionFilterApply => "应用";

	/// <summary>
	/// Key: "Action.Filter.Cancel"
	/// English String: "Cancel"
	/// </summary>
	public override string ActionFilterCancel => "取消";

	/// <summary>
	/// Key: "Action.Go"
	/// English String: "Go"
	/// </summary>
	public override string ActionGo => "开始";

	/// <summary>
	/// Key: "Action.ViewAllItems"
	/// English String: "View All Items"
	/// </summary>
	public override string ActionViewAllItems => "查看所有物品";

	/// <summary>
	/// Key: "Description.Dialog.AddGearBody"
	/// English String: "To add gear to your game, find an item in the catalog and click the Add to Game button. The item will automatically be allowed in game, and you'll receive a commission on every copy sold from your game page. (You can only add gear that's for sale.)"
	/// </summary>
	public override string DescriptionDialogAddGearBody => "若要将装备添加至你的游戏，请在商店中找到物品，点按“添加至游戏”按钮，游戏中则将自动允许使用该物品。并且，你的游戏页面每售出一份该物品，你都会获得相应的佣金报酬（你只能添加可出售的装备）。";

	/// <summary>
	/// Key: "Heading.CatalogCategory"
	/// English String: "Category"
	/// </summary>
	public override string HeadingCatalogCategory => "类别";

	/// <summary>
	/// Key: "Heading.CatalogPage"
	/// English String: "Catalog"
	/// </summary>
	public override string HeadingCatalogPage => "商店";

	/// <summary>
	/// Key: "Label.AllFeaturedItems"
	/// English String: "View All Featured Items"
	/// </summary>
	public override string LabelAllFeaturedItems => "查看所有精选物品";

	/// <summary>
	/// Key: "Label.AllGenres"
	/// English String: "All Genres"
	/// </summary>
	public override string LabelAllGenres => "所有主题";

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
	public override string LabelBreadCrumbFree => "免费";

	/// <summary>
	/// Key: "Label.BreadCrumb.Group"
	/// English String: "Group:"
	/// </summary>
	public override string LabelBreadCrumbGroup => "群组：";

	/// <summary>
	/// Key: "Label.Bundle"
	/// Bundle
	/// English String: "Bundle"
	/// </summary>
	public override string LabelBundle => "套装";

	/// <summary>
	/// Key: "Label.Bundles"
	/// Bundles
	/// English String: "Bundles"
	/// </summary>
	public override string LabelBundles => "套装";

	/// <summary>
	/// Key: "Label.Card.CreatorBy"
	/// English String: "By"
	/// </summary>
	public override string LabelCardCreatorBy => "创作者";

	/// <summary>
	/// Key: "Label.Card.PriceWas"
	/// English String: "Was"
	/// </summary>
	public override string LabelCardPriceWas => "原价";

	/// <summary>
	/// Key: "Label.Card.Remaining"
	/// English String: "Remaining:"
	/// </summary>
	public override string LabelCardRemaining => "剩余：";

	/// <summary>
	/// Key: "Label.CategoryAttributes"
	/// English String: "Attributes"
	/// </summary>
	public override string LabelCategoryAttributes => "属性";

	/// <summary>
	/// Key: "Label.CategoryType"
	/// English String: "Type"
	/// </summary>
	public override string LabelCategoryType => "类型";

	/// <summary>
	/// Key: "Label.CommunityCreations"
	/// UGC items
	/// English String: " Community Creations"
	/// </summary>
	public override string LabelCommunityCreations => " 社区创作";

	/// <summary>
	/// Key: "Label.Dialog.AddGearTitle"
	/// English String: "Add Gear to Your Game"
	/// </summary>
	public override string LabelDialogAddGearTitle => "添加装备到你的游戏";

	/// <summary>
	/// Key: "Label.Emotes"
	/// Emotes
	/// English String: "Emotes"
	/// </summary>
	public override string LabelEmotes => "动作";

	/// <summary>
	/// Key: "Label.Favorites"
	/// English String: "Favorites"
	/// </summary>
	public override string LabelFavorites => "最爱";

	/// <summary>
	/// Key: "Label.FeaturedBundles"
	/// Featured Bundles
	/// English String: "Featured Bundles"
	/// </summary>
	public override string LabelFeaturedBundles => "精选套装";

	/// <summary>
	/// Key: "Label.FeaturedEmotes"
	/// Featured Emotes
	/// English String: "Featured Emotes"
	/// </summary>
	public override string LabelFeaturedEmotes => "精选表情";

	/// <summary>
	/// Key: "Label.Filter.ByTime"
	/// English String: "By Time"
	/// </summary>
	public override string LabelFilterByTime => "按时间";

	/// <summary>
	/// Key: "Label.Filter.Category"
	/// English String: "Category"
	/// </summary>
	public override string LabelFilterCategory => "类别";

	/// <summary>
	/// Key: "Label.Filter.Creator"
	/// English String: "Creator"
	/// </summary>
	public override string LabelFilterCreator => "创作者";

	/// <summary>
	/// Key: "Label.Filter.Filter"
	/// English String: "Filter"
	/// </summary>
	public override string LabelFilterFilter => "筛选";

	/// <summary>
	/// Key: "Label.Filter.Filters"
	/// English String: "Filters"
	/// </summary>
	public override string LabelFilterFilters => "筛选条件";

	/// <summary>
	/// Key: "Label.Filter.Genre"
	/// English String: "Genre"
	/// </summary>
	public override string LabelFilterGenre => "主题";

	/// <summary>
	/// Key: "Label.Filter.Hide"
	/// English String: "Hide"
	/// </summary>
	public override string LabelFilterHide => "隐藏";

	/// <summary>
	/// Key: "Label.Filter.Price"
	/// English String: "Price"
	/// </summary>
	public override string LabelFilterPrice => "价格";

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
	public override string LabelFilterPriceTo => "至";

	/// <summary>
	/// Key: "Label.Filter.Show"
	/// English String: "Show"
	/// </summary>
	public override string LabelFilterShow => "显示";

	/// <summary>
	/// Key: "Label.Filter.Sorting"
	/// English String: "Sorting"
	/// </summary>
	public override string LabelFilterSorting => "排序";

	/// <summary>
	/// Key: "Label.Filter.UnavailableItems"
	/// English String: "Unavailable Items"
	/// </summary>
	public override string LabelFilterUnavailableItems => "不可用物品";

	/// <summary>
	/// Key: "Label.GoogleOnly"
	/// label
	/// English String: "Google Only"
	/// </summary>
	public override string LabelGoogleOnly => "仅限 Google";

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
	public override string LabelMobile => "移动端";

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
	public override string LabelSale => "促销";

	/// <summary>
	/// Key: "Label.SearchField"
	/// English String: "Search"
	/// </summary>
	public override string LabelSearchField => "搜索";

	/// <summary>
	/// Key: "Label.SeeAll"
	/// English String: "See All"
	/// </summary>
	public override string LabelSeeAll => "查看全部";

	/// <summary>
	/// Key: "Label.Username"
	/// English String: "Username"
	/// </summary>
	public override string LabelUsername => "用户名";

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
	public override string LabelAccessories => "饰品";

	/// <summary>
	/// Key: "LabelAccessoryAll"
	/// English String: "All Accessories"
	/// </summary>
	public override string LabelAccessoryAll => "所有饰品";

	/// <summary>
	/// Key: "LabelAccessoryBack"
	/// English String: "Back"
	/// </summary>
	public override string LabelAccessoryBack => "背面";

	/// <summary>
	/// Key: "LabelAccessoryFace"
	/// English String: "Face"
	/// </summary>
	public override string LabelAccessoryFace => "脸部";

	/// <summary>
	/// Key: "LabelAccessoryFront"
	/// English String: "Front"
	/// </summary>
	public override string LabelAccessoryFront => "正面";

	/// <summary>
	/// Key: "LabelAccessoryHair"
	/// English String: "Hair"
	/// </summary>
	public override string LabelAccessoryHair => "发型";

	/// <summary>
	/// Key: "LabelAccessoryHats"
	/// English String: "Hats"
	/// </summary>
	public override string LabelAccessoryHats => "帽子";

	/// <summary>
	/// Key: "LabelAccessoryNeck"
	/// English String: "Neck"
	/// </summary>
	public override string LabelAccessoryNeck => "颈部";

	/// <summary>
	/// Key: "LabelAccessoryShoulder"
	/// English String: "Shoulder"
	/// </summary>
	public override string LabelAccessoryShoulder => "肩部";

	/// <summary>
	/// Key: "LabelAccessoryWaist"
	/// English String: "Waist"
	/// </summary>
	public override string LabelAccessoryWaist => "腰部";

	/// <summary>
	/// Key: "LabelAll"
	/// English String: "All"
	/// </summary>
	public override string LabelAll => "所有";

	/// <summary>
	/// Key: "LabelAllBodyParts"
	/// English String: "All Body Parts"
	/// </summary>
	public override string LabelAllBodyParts => "所有身体部件";

	/// <summary>
	/// Key: "LabelAllCategories"
	/// English String: "All Categories"
	/// </summary>
	public override string LabelAllCategories => "所有类型";

	/// <summary>
	/// Key: "LabelAllClothing"
	/// English String: "All Clothing"
	/// </summary>
	public override string LabelAllClothing => "所有服装";

	/// <summary>
	/// Key: "LabelAllCollectibles"
	/// English String: "All Collectibles"
	/// </summary>
	public override string LabelAllCollectibles => "所有收藏品";

	/// <summary>
	/// Key: "LabelAllCreators"
	/// English String: "All Creators"
	/// </summary>
	public override string LabelAllCreators => "所有创作者";

	/// <summary>
	/// Key: "LabelAllCurrency"
	/// English String: "All Currency"
	/// </summary>
	public override string LabelAllCurrency => "所有货币";

	/// <summary>
	/// Key: "LabelAllFeatured"
	/// English String: "All Featured Items"
	/// </summary>
	public override string LabelAllFeatured => "所有精选物品";

	/// <summary>
	/// Key: "LabelAllTime"
	/// English String: "All Time"
	/// </summary>
	public override string LabelAllTime => "所有时间";

	/// <summary>
	/// Key: "LabelAnimations"
	/// English String: "Animations"
	/// </summary>
	public override string LabelAnimations => "动画";

	/// <summary>
	/// Key: "LabelAnyPrice"
	/// English String: "Any Price"
	/// </summary>
	public override string LabelAnyPrice => "任意价格";

	/// <summary>
	/// Key: "LabelAvatarAnimations"
	/// English String: "Avatar Animations"
	/// </summary>
	public override string LabelAvatarAnimations => "虚拟形象动画";

	/// <summary>
	/// Key: "LabelBestselling"
	/// English String: "Bestselling"
	/// </summary>
	public override string LabelBestselling => "人气热销";

	/// <summary>
	/// Key: "LabelBodyParts"
	/// English String: "Body Parts"
	/// </summary>
	public override string LabelBodyParts => "身体部件";

	/// <summary>
	/// Key: "LabelClothing"
	/// English String: "Clothing"
	/// </summary>
	public override string LabelClothing => "服装";

	/// <summary>
	/// Key: "LabelCollectibleAccessories"
	/// English String: "Collectible Accessories"
	/// </summary>
	public override string LabelCollectibleAccessories => "饰品（收藏品）";

	/// <summary>
	/// Key: "LabelCollectibleFaces"
	/// English String: "Collectible Faces"
	/// </summary>
	public override string LabelCollectibleFaces => "表情（收藏品）";

	/// <summary>
	/// Key: "LabelCollectibleGear"
	/// English String: "Collectible Gear"
	/// </summary>
	public override string LabelCollectibleGear => "装备（收藏品）";

	/// <summary>
	/// Key: "LabelCollectibles"
	/// English String: "Collectibles"
	/// </summary>
	public override string LabelCollectibles => "收藏品";

	/// <summary>
	/// Key: "LabelFaces"
	/// English String: "Faces"
	/// </summary>
	public override string LabelFaces => "表情";

	/// <summary>
	/// Key: "LabelFeatured"
	/// English String: "Featured"
	/// </summary>
	public override string LabelFeatured => "精选";

	/// <summary>
	/// Key: "LabelFeaturedAccesories"
	/// English String: "Featured Accessories"
	/// </summary>
	public override string LabelFeaturedAccesories => "精选饰品";

	/// <summary>
	/// Key: "LabelFeaturedAnimations"
	/// English String: "Featured Animations"
	/// </summary>
	public override string LabelFeaturedAnimations => "精选动画";

	/// <summary>
	/// Key: "LabelFeaturedFaces"
	/// English String: "Featured Faces"
	/// </summary>
	public override string LabelFeaturedFaces => "精选表情";

	/// <summary>
	/// Key: "LabelFeaturedGear"
	/// English String: "Featured Gear"
	/// </summary>
	public override string LabelFeaturedGear => "精选装备";

	/// <summary>
	/// Key: "LabelFeaturedPackages"
	/// English String: "Featured Packages"
	/// </summary>
	public override string LabelFeaturedPackages => "精选套装";

	/// <summary>
	/// Key: "LabelFree"
	/// English String: "Free"
	/// </summary>
	public override string LabelFree => "免费";

	/// <summary>
	/// Key: "LabelGear"
	/// English String: "Gear"
	/// </summary>
	public override string LabelGear => "装备";

	/// <summary>
	/// Key: "LabelGearAll"
	/// English String: "All Gear"
	/// </summary>
	public override string LabelGearAll => "所有装备";

	/// <summary>
	/// Key: "LabelGearBuilding"
	/// English String: "Building"
	/// </summary>
	public override string LabelGearBuilding => "建造";

	/// <summary>
	/// Key: "LabelGearExplosive"
	/// English String: "Explosive"
	/// </summary>
	public override string LabelGearExplosive => "炸药";

	/// <summary>
	/// Key: "LabelGearMelee"
	/// English String: "Melee"
	/// </summary>
	public override string LabelGearMelee => "近战";

	/// <summary>
	/// Key: "LabelGearMusical"
	/// English String: "Musical"
	/// </summary>
	public override string LabelGearMusical => "音乐";

	/// <summary>
	/// Key: "LabelGearNavigation"
	/// English String: "Navigation"
	/// </summary>
	public override string LabelGearNavigation => "导航";

	/// <summary>
	/// Key: "LabelGearPersonalTransport"
	/// English String: "Transport"
	/// </summary>
	public override string LabelGearPersonalTransport => "运输";

	/// <summary>
	/// Key: "LabelGearPowerUps"
	/// English String: "Power Up"
	/// </summary>
	public override string LabelGearPowerUps => "强化道具";

	/// <summary>
	/// Key: "LabelGearRanged"
	/// English String: "Ranged"
	/// </summary>
	public override string LabelGearRanged => "远程";

	/// <summary>
	/// Key: "LabelGearSocial"
	/// English String: "Social"
	/// </summary>
	public override string LabelGearSocial => "社交";

	/// <summary>
	/// Key: "LabelGenreAdventure"
	/// English String: "Adventure"
	/// </summary>
	public override string LabelGenreAdventure => "冒险";

	/// <summary>
	/// Key: "LabelGenreAll"
	/// English String: "All Genres"
	/// </summary>
	public override string LabelGenreAll => "所有主题";

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
	public override string LabelGenreFantasy => "中世纪";

	/// <summary>
	/// Key: "LabelGenreFighting"
	/// English String: "Fighting"
	/// </summary>
	public override string LabelGenreFighting => "格斗";

	/// <summary>
	/// Key: "LabelGenreFPS"
	/// English String: "FPS"
	/// </summary>
	public override string LabelGenreFPS => "FPS";

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
	public override string LabelGenreMedieval => "中世纪";

	/// <summary>
	/// Key: "LabelGenreMilitary"
	/// English String: "Military"
	/// </summary>
	public override string LabelGenreMilitary => "军事";

	/// <summary>
	/// Key: "LabelGenreNaval"
	/// English String: "Naval"
	/// </summary>
	public override string LabelGenreNaval => "海军";

	/// <summary>
	/// Key: "LabelGenreNinja"
	/// English String: "Fighting"
	/// </summary>
	public override string LabelGenreNinja => "格斗";

	/// <summary>
	/// Key: "LabelGenrePirate"
	/// English String: "Naval"
	/// </summary>
	public override string LabelGenrePirate => "海军";

	/// <summary>
	/// Key: "LabelGenreRPG"
	/// English String: "RPG"
	/// </summary>
	public override string LabelGenreRPG => "RPG";

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
	public override string LabelGenreSports => "体育";

	/// <summary>
	/// Key: "LabelGenreTownAndCity"
	/// English String: "Town and City"
	/// </summary>
	public override string LabelGenreTownAndCity => "城市建设";

	/// <summary>
	/// Key: "LabelGenreTutorial"
	/// English String: "Building"
	/// </summary>
	public override string LabelGenreTutorial => "创建";

	/// <summary>
	/// Key: "LabelGenreWar"
	/// English String: "Military"
	/// </summary>
	public override string LabelGenreWar => "军事";

	/// <summary>
	/// Key: "LabelGenreWestern"
	/// English String: "Western"
	/// </summary>
	public override string LabelGenreWestern => "西部";

	/// <summary>
	/// Key: "LabelGenreWildWest"
	/// English String: "Western"
	/// </summary>
	public override string LabelGenreWildWest => "西部";

	/// <summary>
	/// Key: "LabelHeads"
	/// English String: "Heads"
	/// </summary>
	public override string LabelHeads => "头型";

	/// <summary>
	/// Key: "LabelMostFavorited"
	/// English String: "Most Favorited"
	/// </summary>
	public override string LabelMostFavorited => "最受喜爱";

	/// <summary>
	/// Key: "LabelNoResellers"
	/// English String: "No Resellers"
	/// </summary>
	public override string LabelNoResellers => "无人转售";

	/// <summary>
	/// Key: "LabelOffSale"
	/// English String: "Offsale"
	/// </summary>
	public override string LabelOffSale => "下架";

	/// <summary>
	/// Key: "LabelPackages"
	/// English String: "Packages"
	/// </summary>
	public override string LabelPackages => "套装";

	/// <summary>
	/// Key: "LabelPants"
	/// English String: "Pants"
	/// </summary>
	public override string LabelPants => "裤子";

	/// <summary>
	/// Key: "LabelPastDay"
	/// English String: "Past Day"
	/// </summary>
	public override string LabelPastDay => "昨天";

	/// <summary>
	/// Key: "LabelPastWeek"
	/// English String: "Past Week"
	/// </summary>
	public override string LabelPastWeek => "上星期";

	/// <summary>
	/// Key: "LabelPriceHighFirst"
	/// English String: "Price (High to Low)"
	/// </summary>
	public override string LabelPriceHighFirst => "价格（从高到低）";

	/// <summary>
	/// Key: "LabelPriceLowFirst"
	/// English String: "Price (Low to High)"
	/// </summary>
	public override string LabelPriceLowFirst => "价格（从低到高）";

	/// <summary>
	/// Key: "LabelRecentlyUpdated"
	/// English String: "Recently Updated"
	/// </summary>
	public override string LabelRecentlyUpdated => "最近更新";

	/// <summary>
	/// Key: "LabelRelevance"
	/// English String: "Relevance"
	/// </summary>
	public override string LabelRelevance => "相关程度";

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
	public override string LabelShirts => "衬衫";

	/// <summary>
	/// Key: "LabelTShirts"
	/// English String: "T-Shirts"
	/// </summary>
	public override string LabelTShirts => "T 恤";

	/// <summary>
	/// Key: "Response.Error.Filter"
	/// English String: "Errors exist in Filter tab"
	/// </summary>
	public override string ResponseErrorFilter => "筛选标签页中存在错误";

	/// <summary>
	/// Key: "Response.GenericError"
	/// English String: "An error occurred. Please try again later."
	/// </summary>
	public override string ResponseGenericError => "发生错误。请稍后重试。";

	/// <summary>
	/// Key: "Response.NoItemsFound"
	/// English String: "No items found."
	/// </summary>
	public override string ResponseNoItemsFound => "未找到物品。";

	/// <summary>
	/// Key: "Response.NoSaleItemsFromSearch"
	/// English String: "Your search did not find items for sale. Unavailable items displayed below."
	/// </summary>
	public override string ResponseNoSaleItemsFromSearch => "你的搜索未找到待售物品。无法提供的物品显示如下。";

	/// <summary>
	/// Key: "Response.TemporarilyUnavailable"
	/// English String: "Catalog temporarily unavailable. Please try again later."
	/// </summary>
	public override string ResponseTemporarilyUnavailable => "商店暂时不可用。请稍后重试。";

	/// <summary>
	/// Key: "Response.Throttled"
	/// Shown to users when they have made too many requests in a minute and are being throttled.
	/// English String: "You're going too fast! Try again in a minute."
	/// </summary>
	public override string ResponseThrottled => "请求过于频繁！请一分钟后重试。";

	public CatalogResources_zh_cjv(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionBuyRobux()
	{
		return "购买 Robux";
	}

	protected override string _GetTemplateForActionDialogAddGearOk()
	{
		return "好";
	}

	protected override string _GetTemplateForActionFilterApply()
	{
		return "应用";
	}

	protected override string _GetTemplateForActionFilterCancel()
	{
		return "取消";
	}

	protected override string _GetTemplateForActionGo()
	{
		return "开始";
	}

	protected override string _GetTemplateForActionViewAllItems()
	{
		return "查看所有物品";
	}

	protected override string _GetTemplateForDescriptionDialogAddGearBody()
	{
		return "若要将装备添加至你的游戏，请在商店中找到物品，点按“添加至游戏”按钮，游戏中则将自动允许使用该物品。并且，你的游戏页面每售出一份该物品，你都会获得相应的佣金报酬（你只能添加可出售的装备）。";
	}

	protected override string _GetTemplateForHeadingCatalogCategory()
	{
		return "类别";
	}

	protected override string _GetTemplateForHeadingCatalogPage()
	{
		return "商店";
	}

	protected override string _GetTemplateForLabelAllFeaturedItems()
	{
		return "查看所有精选物品";
	}

	protected override string _GetTemplateForLabelAllGenres()
	{
		return "所有主题";
	}

	protected override string _GetTemplateForLabelAmazon()
	{
		return "Amazon";
	}

	protected override string _GetTemplateForLabelBreadCrumbFree()
	{
		return "免费";
	}

	/// <summary>
	/// Key: "Label.BreadCrumb.GenreOrText"
	/// English String: "{genreName1} or {genreName2}"
	/// </summary>
	public override string LabelBreadCrumbGenreOrText(string genreName1, string genreName2)
	{
		return $"“{genreName1}”或“{genreName2}”";
	}

	protected override string _GetTemplateForLabelBreadCrumbGenreOrText()
	{
		return "“{genreName1}”或“{genreName2}”";
	}

	/// <summary>
	/// Key: "Label.BreadCrumb.GenreSelectedText"
	/// English String: "Genre: {genreCount} selected"
	/// </summary>
	public override string LabelBreadCrumbGenreSelectedText(string genreCount)
	{
		return $"主题：已选择 {genreCount} 项";
	}

	protected override string _GetTemplateForLabelBreadCrumbGenreSelectedText()
	{
		return "主题：已选择 {genreCount} 项";
	}

	protected override string _GetTemplateForLabelBreadCrumbGroup()
	{
		return "群组：";
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
		return $"{price} 及以下";
	}

	protected override string _GetTemplateForLabelBreadCrumbPriceBelow()
	{
		return "{price} 及以下";
	}

	/// <summary>
	/// Key: "Label.BreadCrumb.ResultsCount"
	/// English String: "{startNumber} - {endNumber} of {resultsCount} Results"
	/// </summary>
	public override string LabelBreadCrumbResultsCount(string startNumber, string endNumber, string resultsCount)
	{
		return $"{resultsCount} 个结果中的第 {startNumber} - {endNumber} 项";
	}

	protected override string _GetTemplateForLabelBreadCrumbResultsCount()
	{
		return "{resultsCount} 个结果中的第 {startNumber} - {endNumber} 项";
	}

	protected override string _GetTemplateForLabelBundle()
	{
		return "套装";
	}

	protected override string _GetTemplateForLabelBundles()
	{
		return "套装";
	}

	/// <summary>
	/// Key: "Label.ByCreatorLink"
	/// Creator name in item card with link
	/// English String: "By {linkStart}{creator}{linkEnd}"
	/// </summary>
	public override string LabelByCreatorLink(string linkStart, string creator, string linkEnd)
	{
		return $"创作者：{linkStart}{creator}{linkEnd}";
	}

	protected override string _GetTemplateForLabelByCreatorLink()
	{
		return "创作者：{linkStart}{creator}{linkEnd}";
	}

	protected override string _GetTemplateForLabelCardCreatorBy()
	{
		return "创作者";
	}

	protected override string _GetTemplateForLabelCardPriceWas()
	{
		return "原价";
	}

	protected override string _GetTemplateForLabelCardRemaining()
	{
		return "剩余：";
	}

	protected override string _GetTemplateForLabelCategoryAttributes()
	{
		return "属性";
	}

	protected override string _GetTemplateForLabelCategoryType()
	{
		return "类型";
	}

	protected override string _GetTemplateForLabelCommunityCreations()
	{
		return " 社区创作";
	}

	protected override string _GetTemplateForLabelDialogAddGearTitle()
	{
		return "添加装备到你的游戏";
	}

	protected override string _GetTemplateForLabelEmotes()
	{
		return "动作";
	}

	protected override string _GetTemplateForLabelFavorites()
	{
		return "最爱";
	}

	protected override string _GetTemplateForLabelFeaturedBundles()
	{
		return "精选套装";
	}

	protected override string _GetTemplateForLabelFeaturedEmotes()
	{
		return "精选表情";
	}

	/// <summary>
	/// Key: "Label.FeaturedItemsOnRoblox"
	/// English String: "Featured Items on {spanStart}{roblox}{spanEnd}"
	/// </summary>
	public override string LabelFeaturedItemsOnRoblox(string spanStart, string roblox, string spanEnd)
	{
		return $"{spanStart}{roblox}{spanEnd} 精选物品";
	}

	protected override string _GetTemplateForLabelFeaturedItemsOnRoblox()
	{
		return "{spanStart}{roblox}{spanEnd} 精选物品";
	}

	protected override string _GetTemplateForLabelFilterByTime()
	{
		return "按时间";
	}

	protected override string _GetTemplateForLabelFilterCategory()
	{
		return "类别";
	}

	protected override string _GetTemplateForLabelFilterCreator()
	{
		return "创作者";
	}

	protected override string _GetTemplateForLabelFilterFilter()
	{
		return "筛选";
	}

	protected override string _GetTemplateForLabelFilterFilters()
	{
		return "筛选条件";
	}

	protected override string _GetTemplateForLabelFilterGenre()
	{
		return "主题";
	}

	protected override string _GetTemplateForLabelFilterHide()
	{
		return "隐藏";
	}

	protected override string _GetTemplateForLabelFilterPrice()
	{
		return "价格";
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
		return "至";
	}

	protected override string _GetTemplateForLabelFilterShow()
	{
		return "显示";
	}

	protected override string _GetTemplateForLabelFilterSorting()
	{
		return "排序";
	}

	protected override string _GetTemplateForLabelFilterUnavailableItems()
	{
		return "不可用物品";
	}

	protected override string _GetTemplateForLabelGoogleOnly()
	{
		return "仅限 Google";
	}

	protected override string _GetTemplateForLabelIos()
	{
		return "IOS";
	}

	protected override string _GetTemplateForLabelMobile()
	{
		return "移动端";
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
		return "促销";
	}

	protected override string _GetTemplateForLabelSearchField()
	{
		return "搜索";
	}

	protected override string _GetTemplateForLabelSeeAll()
	{
		return "查看全部";
	}

	protected override string _GetTemplateForLabelUsername()
	{
		return "用户名";
	}

	protected override string _GetTemplateForLabelXbox()
	{
		return "Xbox";
	}

	protected override string _GetTemplateForLabelAccessories()
	{
		return "饰品";
	}

	protected override string _GetTemplateForLabelAccessoryAll()
	{
		return "所有饰品";
	}

	protected override string _GetTemplateForLabelAccessoryBack()
	{
		return "背面";
	}

	protected override string _GetTemplateForLabelAccessoryFace()
	{
		return "脸部";
	}

	protected override string _GetTemplateForLabelAccessoryFront()
	{
		return "正面";
	}

	protected override string _GetTemplateForLabelAccessoryHair()
	{
		return "发型";
	}

	protected override string _GetTemplateForLabelAccessoryHats()
	{
		return "帽子";
	}

	protected override string _GetTemplateForLabelAccessoryNeck()
	{
		return "颈部";
	}

	protected override string _GetTemplateForLabelAccessoryShoulder()
	{
		return "肩部";
	}

	protected override string _GetTemplateForLabelAccessoryWaist()
	{
		return "腰部";
	}

	protected override string _GetTemplateForLabelAll()
	{
		return "所有";
	}

	protected override string _GetTemplateForLabelAllBodyParts()
	{
		return "所有身体部件";
	}

	protected override string _GetTemplateForLabelAllCategories()
	{
		return "所有类型";
	}

	protected override string _GetTemplateForLabelAllClothing()
	{
		return "所有服装";
	}

	protected override string _GetTemplateForLabelAllCollectibles()
	{
		return "所有收藏品";
	}

	protected override string _GetTemplateForLabelAllCreators()
	{
		return "所有创作者";
	}

	protected override string _GetTemplateForLabelAllCurrency()
	{
		return "所有货币";
	}

	protected override string _GetTemplateForLabelAllFeatured()
	{
		return "所有精选物品";
	}

	protected override string _GetTemplateForLabelAllTime()
	{
		return "所有时间";
	}

	protected override string _GetTemplateForLabelAnimations()
	{
		return "动画";
	}

	protected override string _GetTemplateForLabelAnyPrice()
	{
		return "任意价格";
	}

	protected override string _GetTemplateForLabelAvatarAnimations()
	{
		return "虚拟形象动画";
	}

	protected override string _GetTemplateForLabelBestselling()
	{
		return "人气热销";
	}

	protected override string _GetTemplateForLabelBodyParts()
	{
		return "身体部件";
	}

	protected override string _GetTemplateForLabelClothing()
	{
		return "服装";
	}

	protected override string _GetTemplateForLabelCollectibleAccessories()
	{
		return "饰品（收藏品）";
	}

	protected override string _GetTemplateForLabelCollectibleFaces()
	{
		return "表情（收藏品）";
	}

	protected override string _GetTemplateForLabelCollectibleGear()
	{
		return "装备（收藏品）";
	}

	protected override string _GetTemplateForLabelCollectibles()
	{
		return "收藏品";
	}

	protected override string _GetTemplateForLabelFaces()
	{
		return "表情";
	}

	protected override string _GetTemplateForLabelFeatured()
	{
		return "精选";
	}

	protected override string _GetTemplateForLabelFeaturedAccesories()
	{
		return "精选饰品";
	}

	protected override string _GetTemplateForLabelFeaturedAnimations()
	{
		return "精选动画";
	}

	protected override string _GetTemplateForLabelFeaturedFaces()
	{
		return "精选表情";
	}

	protected override string _GetTemplateForLabelFeaturedGear()
	{
		return "精选装备";
	}

	protected override string _GetTemplateForLabelFeaturedPackages()
	{
		return "精选套装";
	}

	protected override string _GetTemplateForLabelFree()
	{
		return "免费";
	}

	protected override string _GetTemplateForLabelGear()
	{
		return "装备";
	}

	protected override string _GetTemplateForLabelGearAll()
	{
		return "所有装备";
	}

	protected override string _GetTemplateForLabelGearBuilding()
	{
		return "建造";
	}

	protected override string _GetTemplateForLabelGearExplosive()
	{
		return "炸药";
	}

	protected override string _GetTemplateForLabelGearMelee()
	{
		return "近战";
	}

	protected override string _GetTemplateForLabelGearMusical()
	{
		return "音乐";
	}

	protected override string _GetTemplateForLabelGearNavigation()
	{
		return "导航";
	}

	protected override string _GetTemplateForLabelGearPersonalTransport()
	{
		return "运输";
	}

	protected override string _GetTemplateForLabelGearPowerUps()
	{
		return "强化道具";
	}

	protected override string _GetTemplateForLabelGearRanged()
	{
		return "远程";
	}

	protected override string _GetTemplateForLabelGearSocial()
	{
		return "社交";
	}

	protected override string _GetTemplateForLabelGenreAdventure()
	{
		return "冒险";
	}

	protected override string _GetTemplateForLabelGenreAll()
	{
		return "所有主题";
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
		return "中世纪";
	}

	protected override string _GetTemplateForLabelGenreFighting()
	{
		return "格斗";
	}

	protected override string _GetTemplateForLabelGenreFPS()
	{
		return "FPS";
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
		return "中世纪";
	}

	protected override string _GetTemplateForLabelGenreMilitary()
	{
		return "军事";
	}

	protected override string _GetTemplateForLabelGenreNaval()
	{
		return "海军";
	}

	protected override string _GetTemplateForLabelGenreNinja()
	{
		return "格斗";
	}

	protected override string _GetTemplateForLabelGenrePirate()
	{
		return "海军";
	}

	protected override string _GetTemplateForLabelGenreRPG()
	{
		return "RPG";
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
		return "体育";
	}

	protected override string _GetTemplateForLabelGenreTownAndCity()
	{
		return "城市建设";
	}

	protected override string _GetTemplateForLabelGenreTutorial()
	{
		return "创建";
	}

	protected override string _GetTemplateForLabelGenreWar()
	{
		return "军事";
	}

	protected override string _GetTemplateForLabelGenreWestern()
	{
		return "西部";
	}

	protected override string _GetTemplateForLabelGenreWildWest()
	{
		return "西部";
	}

	protected override string _GetTemplateForLabelHeads()
	{
		return "头型";
	}

	protected override string _GetTemplateForLabelMostFavorited()
	{
		return "最受喜爱";
	}

	protected override string _GetTemplateForLabelNoResellers()
	{
		return "无人转售";
	}

	protected override string _GetTemplateForLabelOffSale()
	{
		return "下架";
	}

	protected override string _GetTemplateForLabelPackages()
	{
		return "套装";
	}

	protected override string _GetTemplateForLabelPants()
	{
		return "裤子";
	}

	protected override string _GetTemplateForLabelPastDay()
	{
		return "昨天";
	}

	protected override string _GetTemplateForLabelPastWeek()
	{
		return "上星期";
	}

	protected override string _GetTemplateForLabelPriceHighFirst()
	{
		return "价格（从高到低）";
	}

	protected override string _GetTemplateForLabelPriceLowFirst()
	{
		return "价格（从低到高）";
	}

	protected override string _GetTemplateForLabelRecentlyUpdated()
	{
		return "最近更新";
	}

	protected override string _GetTemplateForLabelRelevance()
	{
		return "相关程度";
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
		return "衬衫";
	}

	protected override string _GetTemplateForLabelTShirts()
	{
		return "T 恤";
	}

	protected override string _GetTemplateForResponseErrorFilter()
	{
		return "筛选标签页中存在错误";
	}

	protected override string _GetTemplateForResponseGenericError()
	{
		return "发生错误。请稍后重试。";
	}

	protected override string _GetTemplateForResponseNoItemsFound()
	{
		return "未找到物品。";
	}

	protected override string _GetTemplateForResponseNoSaleItemsFromSearch()
	{
		return "你的搜索未找到待售物品。无法提供的物品显示如下。";
	}

	protected override string _GetTemplateForResponseTemporarilyUnavailable()
	{
		return "商店暂时不可用。请稍后重试。";
	}

	protected override string _GetTemplateForResponseThrottled()
	{
		return "请求过于频繁！请一分钟后重试。";
	}
}
