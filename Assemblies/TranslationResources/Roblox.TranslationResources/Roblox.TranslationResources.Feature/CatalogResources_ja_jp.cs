namespace Roblox.TranslationResources.Feature;

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
	public override string ActionBuyRobux => "Robuxを買う";

	/// <summary>
	/// Key: "Action.Dialog.AddGearOk"
	/// English String: "OK"
	/// </summary>
	public override string ActionDialogAddGearOk => "OK";

	/// <summary>
	/// Key: "Action.Filter.Apply"
	/// English String: "Apply"
	/// </summary>
	public override string ActionFilterApply => "適用";

	/// <summary>
	/// Key: "Action.Filter.Cancel"
	/// English String: "Cancel"
	/// </summary>
	public override string ActionFilterCancel => "キャンセル";

	/// <summary>
	/// Key: "Action.Go"
	/// English String: "Go"
	/// </summary>
	public override string ActionGo => "実行";

	/// <summary>
	/// Key: "Action.ViewAllItems"
	/// English String: "View All Items"
	/// </summary>
	public override string ActionViewAllItems => "すべてのアイテムを表示";

	/// <summary>
	/// Key: "Description.Dialog.AddGearBody"
	/// English String: "To add gear to your game, find an item in the catalog and click the Add to Game button. The item will automatically be allowed in game, and you'll receive a commission on every copy sold from your game page. (You can only add gear that's for sale.)"
	/// </summary>
	public override string DescriptionDialogAddGearBody => "ゲームにギアを追加するには、カタログでアイテムを探して「ゲームに追加」ボタンをクリックします。アイテムは自動的にゲーム内で許可され、ゲームページでアイテムが売れる度に報酬を受け取ることができます。（追加できるのは販売中のギアだけです。）";

	/// <summary>
	/// Key: "Heading.CatalogCategory"
	/// English String: "Category"
	/// </summary>
	public override string HeadingCatalogCategory => "カテゴリ";

	/// <summary>
	/// Key: "Heading.CatalogPage"
	/// English String: "Catalog"
	/// </summary>
	public override string HeadingCatalogPage => "カタログ";

	/// <summary>
	/// Key: "Label.AllFeaturedItems"
	/// English String: "View All Featured Items"
	/// </summary>
	public override string LabelAllFeaturedItems => "すべての注目アイテムを表示";

	/// <summary>
	/// Key: "Label.AllGenres"
	/// English String: "All Genres"
	/// </summary>
	public override string LabelAllGenres => "すべてのジャンル";

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
	public override string LabelBreadCrumbFree => "無料";

	/// <summary>
	/// Key: "Label.BreadCrumb.Group"
	/// English String: "Group:"
	/// </summary>
	public override string LabelBreadCrumbGroup => "グループ:";

	/// <summary>
	/// Key: "Label.Bundle"
	/// Bundle
	/// English String: "Bundle"
	/// </summary>
	public override string LabelBundle => "バンドル";

	/// <summary>
	/// Key: "Label.Bundles"
	/// Bundles
	/// English String: "Bundles"
	/// </summary>
	public override string LabelBundles => "バンドル";

	/// <summary>
	/// Key: "Label.Card.CreatorBy"
	/// English String: "By"
	/// </summary>
	public override string LabelCardCreatorBy => "作";

	/// <summary>
	/// Key: "Label.Card.PriceWas"
	/// English String: "Was"
	/// </summary>
	public override string LabelCardPriceWas => "以前の価格";

	/// <summary>
	/// Key: "Label.Card.Remaining"
	/// English String: "Remaining:"
	/// </summary>
	public override string LabelCardRemaining => "残り:";

	/// <summary>
	/// Key: "Label.CategoryAttributes"
	/// English String: "Attributes"
	/// </summary>
	public override string LabelCategoryAttributes => "属性";

	/// <summary>
	/// Key: "Label.CategoryType"
	/// English String: "Type"
	/// </summary>
	public override string LabelCategoryType => "タイプ";

	/// <summary>
	/// Key: "Label.CommunityCreations"
	/// UGC items
	/// English String: " Community Creations"
	/// </summary>
	public override string LabelCommunityCreations => " コミュニティの作品";

	/// <summary>
	/// Key: "Label.Dialog.AddGearTitle"
	/// English String: "Add Gear to Your Game"
	/// </summary>
	public override string LabelDialogAddGearTitle => "ゲームにギアを追加";

	/// <summary>
	/// Key: "Label.Emotes"
	/// Emotes
	/// English String: "Emotes"
	/// </summary>
	public override string LabelEmotes => "エモート";

	/// <summary>
	/// Key: "Label.Favorites"
	/// English String: "Favorites"
	/// </summary>
	public override string LabelFavorites => "お気に入り";

	/// <summary>
	/// Key: "Label.FeaturedBundles"
	/// Featured Bundles
	/// English String: "Featured Bundles"
	/// </summary>
	public override string LabelFeaturedBundles => "注目のバンドル";

	/// <summary>
	/// Key: "Label.FeaturedEmotes"
	/// Featured Emotes
	/// English String: "Featured Emotes"
	/// </summary>
	public override string LabelFeaturedEmotes => "注目のエモート";

	/// <summary>
	/// Key: "Label.Filter.ByTime"
	/// English String: "By Time"
	/// </summary>
	public override string LabelFilterByTime => "時間";

	/// <summary>
	/// Key: "Label.Filter.Category"
	/// English String: "Category"
	/// </summary>
	public override string LabelFilterCategory => "カテゴリ";

	/// <summary>
	/// Key: "Label.Filter.Creator"
	/// English String: "Creator"
	/// </summary>
	public override string LabelFilterCreator => "クリエーター";

	/// <summary>
	/// Key: "Label.Filter.Filter"
	/// English String: "Filter"
	/// </summary>
	public override string LabelFilterFilter => "フィルタ";

	/// <summary>
	/// Key: "Label.Filter.Filters"
	/// English String: "Filters"
	/// </summary>
	public override string LabelFilterFilters => "フィルタ";

	/// <summary>
	/// Key: "Label.Filter.Genre"
	/// English String: "Genre"
	/// </summary>
	public override string LabelFilterGenre => "ジャンル";

	/// <summary>
	/// Key: "Label.Filter.Hide"
	/// English String: "Hide"
	/// </summary>
	public override string LabelFilterHide => "非表示";

	/// <summary>
	/// Key: "Label.Filter.Price"
	/// English String: "Price"
	/// </summary>
	public override string LabelFilterPrice => "価格";

	/// <summary>
	/// Key: "Label.Filter.PriceMax"
	/// English String: "Max"
	/// </summary>
	public override string LabelFilterPriceMax => "最高額";

	/// <summary>
	/// Key: "Label.Filter.PriceMin"
	/// English String: "Min"
	/// </summary>
	public override string LabelFilterPriceMin => "最低額";

	/// <summary>
	/// Key: "Label.Filter.PriceTo"
	/// English String: "To"
	/// </summary>
	public override string LabelFilterPriceTo => "新しい価格";

	/// <summary>
	/// Key: "Label.Filter.Show"
	/// English String: "Show"
	/// </summary>
	public override string LabelFilterShow => "表示";

	/// <summary>
	/// Key: "Label.Filter.Sorting"
	/// English String: "Sorting"
	/// </summary>
	public override string LabelFilterSorting => "並べ替え";

	/// <summary>
	/// Key: "Label.Filter.UnavailableItems"
	/// English String: "Unavailable Items"
	/// </summary>
	public override string LabelFilterUnavailableItems => "利用できないアイテム";

	/// <summary>
	/// Key: "Label.GoogleOnly"
	/// label
	/// English String: "Google Only"
	/// </summary>
	public override string LabelGoogleOnly => "Google専用";

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
	public override string LabelMobile => "モバイル";

	/// <summary>
	/// Key: "Label.New"
	/// label
	/// English String: "New"
	/// </summary>
	public override string LabelNew => "新着";

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
	public override string LabelSale => "セール";

	/// <summary>
	/// Key: "Label.SearchField"
	/// English String: "Search"
	/// </summary>
	public override string LabelSearchField => "検索";

	/// <summary>
	/// Key: "Label.SeeAll"
	/// English String: "See All"
	/// </summary>
	public override string LabelSeeAll => "すべて見る";

	/// <summary>
	/// Key: "Label.Username"
	/// English String: "Username"
	/// </summary>
	public override string LabelUsername => "ユーザーネーム";

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
	public override string LabelAccessories => "アクセサリ";

	/// <summary>
	/// Key: "LabelAccessoryAll"
	/// English String: "All Accessories"
	/// </summary>
	public override string LabelAccessoryAll => "すべてのアクセサリ";

	/// <summary>
	/// Key: "LabelAccessoryBack"
	/// English String: "Back"
	/// </summary>
	public override string LabelAccessoryBack => "背面";

	/// <summary>
	/// Key: "LabelAccessoryFace"
	/// English String: "Face"
	/// </summary>
	public override string LabelAccessoryFace => "顔";

	/// <summary>
	/// Key: "LabelAccessoryFront"
	/// English String: "Front"
	/// </summary>
	public override string LabelAccessoryFront => "正面";

	/// <summary>
	/// Key: "LabelAccessoryHair"
	/// English String: "Hair"
	/// </summary>
	public override string LabelAccessoryHair => "髪";

	/// <summary>
	/// Key: "LabelAccessoryHats"
	/// English String: "Hats"
	/// </summary>
	public override string LabelAccessoryHats => "帽子";

	/// <summary>
	/// Key: "LabelAccessoryNeck"
	/// English String: "Neck"
	/// </summary>
	public override string LabelAccessoryNeck => "首";

	/// <summary>
	/// Key: "LabelAccessoryShoulder"
	/// English String: "Shoulder"
	/// </summary>
	public override string LabelAccessoryShoulder => "肩";

	/// <summary>
	/// Key: "LabelAccessoryWaist"
	/// English String: "Waist"
	/// </summary>
	public override string LabelAccessoryWaist => "腰";

	/// <summary>
	/// Key: "LabelAll"
	/// English String: "All"
	/// </summary>
	public override string LabelAll => "すべて";

	/// <summary>
	/// Key: "LabelAllBodyParts"
	/// English String: "All Body Parts"
	/// </summary>
	public override string LabelAllBodyParts => "すべてのボディパーツ";

	/// <summary>
	/// Key: "LabelAllCategories"
	/// English String: "All Categories"
	/// </summary>
	public override string LabelAllCategories => "すべてのカテゴリ";

	/// <summary>
	/// Key: "LabelAllClothing"
	/// English String: "All Clothing"
	/// </summary>
	public override string LabelAllClothing => "すべてのコスチューム";

	/// <summary>
	/// Key: "LabelAllCollectibles"
	/// English String: "All Collectibles"
	/// </summary>
	public override string LabelAllCollectibles => "すべてのコレクタブル";

	/// <summary>
	/// Key: "LabelAllCreators"
	/// English String: "All Creators"
	/// </summary>
	public override string LabelAllCreators => "すべてのクリエーター";

	/// <summary>
	/// Key: "LabelAllCurrency"
	/// English String: "All Currency"
	/// </summary>
	public override string LabelAllCurrency => "すべての通貨";

	/// <summary>
	/// Key: "LabelAllFeatured"
	/// English String: "All Featured Items"
	/// </summary>
	public override string LabelAllFeatured => "すべての注目アイテム";

	/// <summary>
	/// Key: "LabelAllTime"
	/// English String: "All Time"
	/// </summary>
	public override string LabelAllTime => "通算";

	/// <summary>
	/// Key: "LabelAnimations"
	/// English String: "Animations"
	/// </summary>
	public override string LabelAnimations => "アニメーション";

	/// <summary>
	/// Key: "LabelAnyPrice"
	/// English String: "Any Price"
	/// </summary>
	public override string LabelAnyPrice => "価格指定なし";

	/// <summary>
	/// Key: "LabelAvatarAnimations"
	/// English String: "Avatar Animations"
	/// </summary>
	public override string LabelAvatarAnimations => "アバターアニメ";

	/// <summary>
	/// Key: "LabelBestselling"
	/// English String: "Bestselling"
	/// </summary>
	public override string LabelBestselling => "ベストセラー";

	/// <summary>
	/// Key: "LabelBodyParts"
	/// English String: "Body Parts"
	/// </summary>
	public override string LabelBodyParts => "ボディパーツ";

	/// <summary>
	/// Key: "LabelClothing"
	/// English String: "Clothing"
	/// </summary>
	public override string LabelClothing => "コスチューム";

	/// <summary>
	/// Key: "LabelCollectibleAccessories"
	/// English String: "Collectible Accessories"
	/// </summary>
	public override string LabelCollectibleAccessories => "コレクタブルアクセサリ";

	/// <summary>
	/// Key: "LabelCollectibleFaces"
	/// English String: "Collectible Faces"
	/// </summary>
	public override string LabelCollectibleFaces => "コレクタブルの顔";

	/// <summary>
	/// Key: "LabelCollectibleGear"
	/// English String: "Collectible Gear"
	/// </summary>
	public override string LabelCollectibleGear => "コレクタブルギア";

	/// <summary>
	/// Key: "LabelCollectibles"
	/// English String: "Collectibles"
	/// </summary>
	public override string LabelCollectibles => "コレクタブル";

	/// <summary>
	/// Key: "LabelFaces"
	/// English String: "Faces"
	/// </summary>
	public override string LabelFaces => "顔";

	/// <summary>
	/// Key: "LabelFeatured"
	/// English String: "Featured"
	/// </summary>
	public override string LabelFeatured => "注目";

	/// <summary>
	/// Key: "LabelFeaturedAccesories"
	/// English String: "Featured Accessories"
	/// </summary>
	public override string LabelFeaturedAccesories => "注目のアクセサリ";

	/// <summary>
	/// Key: "LabelFeaturedAnimations"
	/// English String: "Featured Animations"
	/// </summary>
	public override string LabelFeaturedAnimations => "注目のアニメーション";

	/// <summary>
	/// Key: "LabelFeaturedFaces"
	/// English String: "Featured Faces"
	/// </summary>
	public override string LabelFeaturedFaces => "注目の顔";

	/// <summary>
	/// Key: "LabelFeaturedGear"
	/// English String: "Featured Gear"
	/// </summary>
	public override string LabelFeaturedGear => "注目のギア";

	/// <summary>
	/// Key: "LabelFeaturedPackages"
	/// English String: "Featured Packages"
	/// </summary>
	public override string LabelFeaturedPackages => "注目のパッケージ";

	/// <summary>
	/// Key: "LabelFree"
	/// English String: "Free"
	/// </summary>
	public override string LabelFree => "無料";

	/// <summary>
	/// Key: "LabelGear"
	/// English String: "Gear"
	/// </summary>
	public override string LabelGear => "ギア";

	/// <summary>
	/// Key: "LabelGearAll"
	/// English String: "All Gear"
	/// </summary>
	public override string LabelGearAll => "すべてのギア";

	/// <summary>
	/// Key: "LabelGearBuilding"
	/// English String: "Building"
	/// </summary>
	public override string LabelGearBuilding => "建築";

	/// <summary>
	/// Key: "LabelGearExplosive"
	/// English String: "Explosive"
	/// </summary>
	public override string LabelGearExplosive => "爆発物";

	/// <summary>
	/// Key: "LabelGearMelee"
	/// English String: "Melee"
	/// </summary>
	public override string LabelGearMelee => "メレー";

	/// <summary>
	/// Key: "LabelGearMusical"
	/// English String: "Musical"
	/// </summary>
	public override string LabelGearMusical => "音楽";

	/// <summary>
	/// Key: "LabelGearNavigation"
	/// English String: "Navigation"
	/// </summary>
	public override string LabelGearNavigation => "ナビゲーション";

	/// <summary>
	/// Key: "LabelGearPersonalTransport"
	/// English String: "Transport"
	/// </summary>
	public override string LabelGearPersonalTransport => "乗り物";

	/// <summary>
	/// Key: "LabelGearPowerUps"
	/// English String: "Power Up"
	/// </summary>
	public override string LabelGearPowerUps => "パワーアップ";

	/// <summary>
	/// Key: "LabelGearRanged"
	/// English String: "Ranged"
	/// </summary>
	public override string LabelGearRanged => "遠距離";

	/// <summary>
	/// Key: "LabelGearSocial"
	/// English String: "Social"
	/// </summary>
	public override string LabelGearSocial => "ソーシャル";

	/// <summary>
	/// Key: "LabelGenreAdventure"
	/// English String: "Adventure"
	/// </summary>
	public override string LabelGenreAdventure => "アドベンチャー";

	/// <summary>
	/// Key: "LabelGenreAll"
	/// English String: "All Genres"
	/// </summary>
	public override string LabelGenreAll => "すべてのジャンル";

	/// <summary>
	/// Key: "LabelGenreBuilding"
	/// English String: "Building"
	/// </summary>
	public override string LabelGenreBuilding => "建築";

	/// <summary>
	/// Key: "LabelGenreComedy"
	/// English String: "Comedy"
	/// </summary>
	public override string LabelGenreComedy => "コメディ";

	/// <summary>
	/// Key: "LabelGenreFantasy"
	/// English String: "Medieval"
	/// </summary>
	public override string LabelGenreFantasy => "中世";

	/// <summary>
	/// Key: "LabelGenreFighting"
	/// English String: "Fighting"
	/// </summary>
	public override string LabelGenreFighting => "格闘";

	/// <summary>
	/// Key: "LabelGenreFPS"
	/// English String: "FPS"
	/// </summary>
	public override string LabelGenreFPS => "FPS";

	/// <summary>
	/// Key: "LabelGenreFunny"
	/// English String: "Comedy"
	/// </summary>
	public override string LabelGenreFunny => "コメディ";

	/// <summary>
	/// Key: "LabelGenreHorror"
	/// English String: "Horror"
	/// </summary>
	public override string LabelGenreHorror => "ホラー";

	/// <summary>
	/// Key: "LabelGenreMedieval"
	/// English String: "Medieval"
	/// </summary>
	public override string LabelGenreMedieval => "中世";

	/// <summary>
	/// Key: "LabelGenreMilitary"
	/// English String: "Military"
	/// </summary>
	public override string LabelGenreMilitary => "ミリタリー";

	/// <summary>
	/// Key: "LabelGenreNaval"
	/// English String: "Naval"
	/// </summary>
	public override string LabelGenreNaval => "海軍";

	/// <summary>
	/// Key: "LabelGenreNinja"
	/// English String: "Fighting"
	/// </summary>
	public override string LabelGenreNinja => "格闘";

	/// <summary>
	/// Key: "LabelGenrePirate"
	/// English String: "Naval"
	/// </summary>
	public override string LabelGenrePirate => "海軍";

	/// <summary>
	/// Key: "LabelGenreRPG"
	/// English String: "RPG"
	/// </summary>
	public override string LabelGenreRPG => "RPG";

	/// <summary>
	/// Key: "LabelGenreScary"
	/// English String: "Horror"
	/// </summary>
	public override string LabelGenreScary => "ホラー";

	/// <summary>
	/// Key: "LabelGenreSciFi"
	/// English String: "Sci-Fi"
	/// </summary>
	public override string LabelGenreSciFi => "SF";

	/// <summary>
	/// Key: "LabelGenreSports"
	/// English String: "Sports"
	/// </summary>
	public override string LabelGenreSports => "スポーツ";

	/// <summary>
	/// Key: "LabelGenreTownAndCity"
	/// English String: "Town and City"
	/// </summary>
	public override string LabelGenreTownAndCity => "都市開発";

	/// <summary>
	/// Key: "LabelGenreTutorial"
	/// English String: "Building"
	/// </summary>
	public override string LabelGenreTutorial => "建築";

	/// <summary>
	/// Key: "LabelGenreWar"
	/// English String: "Military"
	/// </summary>
	public override string LabelGenreWar => "ミリタリー";

	/// <summary>
	/// Key: "LabelGenreWestern"
	/// English String: "Western"
	/// </summary>
	public override string LabelGenreWestern => "ウエスタン";

	/// <summary>
	/// Key: "LabelGenreWildWest"
	/// English String: "Western"
	/// </summary>
	public override string LabelGenreWildWest => "ウエスタン";

	/// <summary>
	/// Key: "LabelHeads"
	/// English String: "Heads"
	/// </summary>
	public override string LabelHeads => "頭";

	/// <summary>
	/// Key: "LabelMostFavorited"
	/// English String: "Most Favorited"
	/// </summary>
	public override string LabelMostFavorited => "一番人気";

	/// <summary>
	/// Key: "LabelNoResellers"
	/// English String: "No Resellers"
	/// </summary>
	public override string LabelNoResellers => "再販者なし";

	/// <summary>
	/// Key: "LabelOffSale"
	/// English String: "Offsale"
	/// </summary>
	public override string LabelOffSale => "非売品";

	/// <summary>
	/// Key: "LabelPackages"
	/// English String: "Packages"
	/// </summary>
	public override string LabelPackages => "パッケージ";

	/// <summary>
	/// Key: "LabelPants"
	/// English String: "Pants"
	/// </summary>
	public override string LabelPants => "パンツ";

	/// <summary>
	/// Key: "LabelPastDay"
	/// English String: "Past Day"
	/// </summary>
	public override string LabelPastDay => "昨日";

	/// <summary>
	/// Key: "LabelPastWeek"
	/// English String: "Past Week"
	/// </summary>
	public override string LabelPastWeek => "先週";

	/// <summary>
	/// Key: "LabelPriceHighFirst"
	/// English String: "Price (High to Low)"
	/// </summary>
	public override string LabelPriceHighFirst => "価格（高い順）";

	/// <summary>
	/// Key: "LabelPriceLowFirst"
	/// English String: "Price (Low to High)"
	/// </summary>
	public override string LabelPriceLowFirst => "価格（安い順）";

	/// <summary>
	/// Key: "LabelRecentlyUpdated"
	/// English String: "Recently Updated"
	/// </summary>
	public override string LabelRecentlyUpdated => "最近アップデート";

	/// <summary>
	/// Key: "LabelRelevance"
	/// English String: "Relevance"
	/// </summary>
	public override string LabelRelevance => "並べ替え";

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
	public override string LabelShirts => "シャツ";

	/// <summary>
	/// Key: "LabelTShirts"
	/// English String: "T-Shirts"
	/// </summary>
	public override string LabelTShirts => "Tシャツ";

	/// <summary>
	/// Key: "Response.Error.Filter"
	/// English String: "Errors exist in Filter tab"
	/// </summary>
	public override string ResponseErrorFilter => "フィルタタブにエラーがあります";

	/// <summary>
	/// Key: "Response.GenericError"
	/// English String: "An error occurred. Please try again later."
	/// </summary>
	public override string ResponseGenericError => "エラーが発生しました。後でもう一度お試しください。";

	/// <summary>
	/// Key: "Response.NoItemsFound"
	/// English String: "No items found."
	/// </summary>
	public override string ResponseNoItemsFound => "アイテムが見つかりません。";

	/// <summary>
	/// Key: "Response.NoSaleItemsFromSearch"
	/// English String: "Your search did not find items for sale. Unavailable items displayed below."
	/// </summary>
	public override string ResponseNoSaleItemsFromSearch => "検索しましたが、販売中のアイテムが見つかりませんでした。利用できないアイテムが以下に表示されます。";

	/// <summary>
	/// Key: "Response.TemporarilyUnavailable"
	/// English String: "Catalog temporarily unavailable. Please try again later."
	/// </summary>
	public override string ResponseTemporarilyUnavailable => "カタログは一時的に利用できません。後でもう一度お試しください。";

	/// <summary>
	/// Key: "Response.Throttled"
	/// Shown to users when they have made too many requests in a minute and are being throttled.
	/// English String: "You're going too fast! Try again in a minute."
	/// </summary>
	public override string ResponseThrottled => "リクエストの間隔が短すぎます。1分後にもう一度お試しください。";

	public CatalogResources_ja_jp(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionBuyRobux()
	{
		return "Robuxを買う";
	}

	protected override string _GetTemplateForActionDialogAddGearOk()
	{
		return "OK";
	}

	protected override string _GetTemplateForActionFilterApply()
	{
		return "適用";
	}

	protected override string _GetTemplateForActionFilterCancel()
	{
		return "キャンセル";
	}

	protected override string _GetTemplateForActionGo()
	{
		return "実行";
	}

	protected override string _GetTemplateForActionViewAllItems()
	{
		return "すべてのアイテムを表示";
	}

	protected override string _GetTemplateForDescriptionDialogAddGearBody()
	{
		return "ゲームにギアを追加するには、カタログでアイテムを探して「ゲームに追加」ボタンをクリックします。アイテムは自動的にゲーム内で許可され、ゲームページでアイテムが売れる度に報酬を受け取ることができます。（追加できるのは販売中のギアだけです。）";
	}

	protected override string _GetTemplateForHeadingCatalogCategory()
	{
		return "カテゴリ";
	}

	protected override string _GetTemplateForHeadingCatalogPage()
	{
		return "カタログ";
	}

	protected override string _GetTemplateForLabelAllFeaturedItems()
	{
		return "すべての注目アイテムを表示";
	}

	protected override string _GetTemplateForLabelAllGenres()
	{
		return "すべてのジャンル";
	}

	protected override string _GetTemplateForLabelAmazon()
	{
		return "Amazon";
	}

	protected override string _GetTemplateForLabelBreadCrumbFree()
	{
		return "無料";
	}

	/// <summary>
	/// Key: "Label.BreadCrumb.GenreOrText"
	/// English String: "{genreName1} or {genreName2}"
	/// </summary>
	public override string LabelBreadCrumbGenreOrText(string genreName1, string genreName2)
	{
		return $"{genreName1} または {genreName2}";
	}

	protected override string _GetTemplateForLabelBreadCrumbGenreOrText()
	{
		return "{genreName1} または {genreName2}";
	}

	/// <summary>
	/// Key: "Label.BreadCrumb.GenreSelectedText"
	/// English String: "Genre: {genreCount} selected"
	/// </summary>
	public override string LabelBreadCrumbGenreSelectedText(string genreCount)
	{
		return $"ジャンル: {genreCount} を選択";
	}

	protected override string _GetTemplateForLabelBreadCrumbGenreSelectedText()
	{
		return "ジャンル: {genreCount} を選択";
	}

	protected override string _GetTemplateForLabelBreadCrumbGroup()
	{
		return "グループ:";
	}

	/// <summary>
	/// Key: "Label.BreadCrumb.PriceAbove"
	/// English String: "{price} and above"
	/// </summary>
	public override string LabelBreadCrumbPriceAbove(string price)
	{
		return $"{price}以上";
	}

	protected override string _GetTemplateForLabelBreadCrumbPriceAbove()
	{
		return "{price}以上";
	}

	/// <summary>
	/// Key: "Label.BreadCrumb.PriceBelow"
	/// English String: "{price} and below"
	/// </summary>
	public override string LabelBreadCrumbPriceBelow(string price)
	{
		return $"{price}以下";
	}

	protected override string _GetTemplateForLabelBreadCrumbPriceBelow()
	{
		return "{price}以下";
	}

	/// <summary>
	/// Key: "Label.BreadCrumb.ResultsCount"
	/// English String: "{startNumber} - {endNumber} of {resultsCount} Results"
	/// </summary>
	public override string LabelBreadCrumbResultsCount(string startNumber, string endNumber, string resultsCount)
	{
		return $"{resultsCount}中{startNumber} - {endNumber}の結果";
	}

	protected override string _GetTemplateForLabelBreadCrumbResultsCount()
	{
		return "{resultsCount}中{startNumber} - {endNumber}の結果";
	}

	protected override string _GetTemplateForLabelBundle()
	{
		return "バンドル";
	}

	protected override string _GetTemplateForLabelBundles()
	{
		return "バンドル";
	}

	/// <summary>
	/// Key: "Label.ByCreatorLink"
	/// Creator name in item card with link
	/// English String: "By {linkStart}{creator}{linkEnd}"
	/// </summary>
	public override string LabelByCreatorLink(string linkStart, string creator, string linkEnd)
	{
		return $"作： {linkStart}{creator}{linkEnd}";
	}

	protected override string _GetTemplateForLabelByCreatorLink()
	{
		return "作： {linkStart}{creator}{linkEnd}";
	}

	protected override string _GetTemplateForLabelCardCreatorBy()
	{
		return "作";
	}

	protected override string _GetTemplateForLabelCardPriceWas()
	{
		return "以前の価格";
	}

	protected override string _GetTemplateForLabelCardRemaining()
	{
		return "残り:";
	}

	protected override string _GetTemplateForLabelCategoryAttributes()
	{
		return "属性";
	}

	protected override string _GetTemplateForLabelCategoryType()
	{
		return "タイプ";
	}

	protected override string _GetTemplateForLabelCommunityCreations()
	{
		return " コミュニティの作品";
	}

	protected override string _GetTemplateForLabelDialogAddGearTitle()
	{
		return "ゲームにギアを追加";
	}

	protected override string _GetTemplateForLabelEmotes()
	{
		return "エモート";
	}

	protected override string _GetTemplateForLabelFavorites()
	{
		return "お気に入り";
	}

	protected override string _GetTemplateForLabelFeaturedBundles()
	{
		return "注目のバンドル";
	}

	protected override string _GetTemplateForLabelFeaturedEmotes()
	{
		return "注目のエモート";
	}

	/// <summary>
	/// Key: "Label.FeaturedItemsOnRoblox"
	/// English String: "Featured Items on {spanStart}{roblox}{spanEnd}"
	/// </summary>
	public override string LabelFeaturedItemsOnRoblox(string spanStart, string roblox, string spanEnd)
	{
		return $"{spanStart}{roblox}{spanEnd} の注目アイテム";
	}

	protected override string _GetTemplateForLabelFeaturedItemsOnRoblox()
	{
		return "{spanStart}{roblox}{spanEnd} の注目アイテム";
	}

	protected override string _GetTemplateForLabelFilterByTime()
	{
		return "時間";
	}

	protected override string _GetTemplateForLabelFilterCategory()
	{
		return "カテゴリ";
	}

	protected override string _GetTemplateForLabelFilterCreator()
	{
		return "クリエーター";
	}

	protected override string _GetTemplateForLabelFilterFilter()
	{
		return "フィルタ";
	}

	protected override string _GetTemplateForLabelFilterFilters()
	{
		return "フィルタ";
	}

	protected override string _GetTemplateForLabelFilterGenre()
	{
		return "ジャンル";
	}

	protected override string _GetTemplateForLabelFilterHide()
	{
		return "非表示";
	}

	protected override string _GetTemplateForLabelFilterPrice()
	{
		return "価格";
	}

	protected override string _GetTemplateForLabelFilterPriceMax()
	{
		return "最高額";
	}

	protected override string _GetTemplateForLabelFilterPriceMin()
	{
		return "最低額";
	}

	protected override string _GetTemplateForLabelFilterPriceTo()
	{
		return "新しい価格";
	}

	protected override string _GetTemplateForLabelFilterShow()
	{
		return "表示";
	}

	protected override string _GetTemplateForLabelFilterSorting()
	{
		return "並べ替え";
	}

	protected override string _GetTemplateForLabelFilterUnavailableItems()
	{
		return "利用できないアイテム";
	}

	protected override string _GetTemplateForLabelGoogleOnly()
	{
		return "Google専用";
	}

	protected override string _GetTemplateForLabelIos()
	{
		return "iOS";
	}

	protected override string _GetTemplateForLabelMobile()
	{
		return "モバイル";
	}

	protected override string _GetTemplateForLabelNew()
	{
		return "新着";
	}

	protected override string _GetTemplateForLabelRthro()
	{
		return "Rthro";
	}

	protected override string _GetTemplateForLabelSale()
	{
		return "セール";
	}

	protected override string _GetTemplateForLabelSearchField()
	{
		return "検索";
	}

	protected override string _GetTemplateForLabelSeeAll()
	{
		return "すべて見る";
	}

	protected override string _GetTemplateForLabelUsername()
	{
		return "ユーザーネーム";
	}

	protected override string _GetTemplateForLabelXbox()
	{
		return "Xbox";
	}

	protected override string _GetTemplateForLabelAccessories()
	{
		return "アクセサリ";
	}

	protected override string _GetTemplateForLabelAccessoryAll()
	{
		return "すべてのアクセサリ";
	}

	protected override string _GetTemplateForLabelAccessoryBack()
	{
		return "背面";
	}

	protected override string _GetTemplateForLabelAccessoryFace()
	{
		return "顔";
	}

	protected override string _GetTemplateForLabelAccessoryFront()
	{
		return "正面";
	}

	protected override string _GetTemplateForLabelAccessoryHair()
	{
		return "髪";
	}

	protected override string _GetTemplateForLabelAccessoryHats()
	{
		return "帽子";
	}

	protected override string _GetTemplateForLabelAccessoryNeck()
	{
		return "首";
	}

	protected override string _GetTemplateForLabelAccessoryShoulder()
	{
		return "肩";
	}

	protected override string _GetTemplateForLabelAccessoryWaist()
	{
		return "腰";
	}

	protected override string _GetTemplateForLabelAll()
	{
		return "すべて";
	}

	protected override string _GetTemplateForLabelAllBodyParts()
	{
		return "すべてのボディパーツ";
	}

	protected override string _GetTemplateForLabelAllCategories()
	{
		return "すべてのカテゴリ";
	}

	protected override string _GetTemplateForLabelAllClothing()
	{
		return "すべてのコスチューム";
	}

	protected override string _GetTemplateForLabelAllCollectibles()
	{
		return "すべてのコレクタブル";
	}

	protected override string _GetTemplateForLabelAllCreators()
	{
		return "すべてのクリエーター";
	}

	protected override string _GetTemplateForLabelAllCurrency()
	{
		return "すべての通貨";
	}

	protected override string _GetTemplateForLabelAllFeatured()
	{
		return "すべての注目アイテム";
	}

	protected override string _GetTemplateForLabelAllTime()
	{
		return "通算";
	}

	protected override string _GetTemplateForLabelAnimations()
	{
		return "アニメーション";
	}

	protected override string _GetTemplateForLabelAnyPrice()
	{
		return "価格指定なし";
	}

	protected override string _GetTemplateForLabelAvatarAnimations()
	{
		return "アバターアニメ";
	}

	protected override string _GetTemplateForLabelBestselling()
	{
		return "ベストセラー";
	}

	protected override string _GetTemplateForLabelBodyParts()
	{
		return "ボディパーツ";
	}

	protected override string _GetTemplateForLabelClothing()
	{
		return "コスチューム";
	}

	protected override string _GetTemplateForLabelCollectibleAccessories()
	{
		return "コレクタブルアクセサリ";
	}

	protected override string _GetTemplateForLabelCollectibleFaces()
	{
		return "コレクタブルの顔";
	}

	protected override string _GetTemplateForLabelCollectibleGear()
	{
		return "コレクタブルギア";
	}

	protected override string _GetTemplateForLabelCollectibles()
	{
		return "コレクタブル";
	}

	protected override string _GetTemplateForLabelFaces()
	{
		return "顔";
	}

	protected override string _GetTemplateForLabelFeatured()
	{
		return "注目";
	}

	protected override string _GetTemplateForLabelFeaturedAccesories()
	{
		return "注目のアクセサリ";
	}

	protected override string _GetTemplateForLabelFeaturedAnimations()
	{
		return "注目のアニメーション";
	}

	protected override string _GetTemplateForLabelFeaturedFaces()
	{
		return "注目の顔";
	}

	protected override string _GetTemplateForLabelFeaturedGear()
	{
		return "注目のギア";
	}

	protected override string _GetTemplateForLabelFeaturedPackages()
	{
		return "注目のパッケージ";
	}

	protected override string _GetTemplateForLabelFree()
	{
		return "無料";
	}

	protected override string _GetTemplateForLabelGear()
	{
		return "ギア";
	}

	protected override string _GetTemplateForLabelGearAll()
	{
		return "すべてのギア";
	}

	protected override string _GetTemplateForLabelGearBuilding()
	{
		return "建築";
	}

	protected override string _GetTemplateForLabelGearExplosive()
	{
		return "爆発物";
	}

	protected override string _GetTemplateForLabelGearMelee()
	{
		return "メレー";
	}

	protected override string _GetTemplateForLabelGearMusical()
	{
		return "音楽";
	}

	protected override string _GetTemplateForLabelGearNavigation()
	{
		return "ナビゲーション";
	}

	protected override string _GetTemplateForLabelGearPersonalTransport()
	{
		return "乗り物";
	}

	protected override string _GetTemplateForLabelGearPowerUps()
	{
		return "パワーアップ";
	}

	protected override string _GetTemplateForLabelGearRanged()
	{
		return "遠距離";
	}

	protected override string _GetTemplateForLabelGearSocial()
	{
		return "ソーシャル";
	}

	protected override string _GetTemplateForLabelGenreAdventure()
	{
		return "アドベンチャー";
	}

	protected override string _GetTemplateForLabelGenreAll()
	{
		return "すべてのジャンル";
	}

	protected override string _GetTemplateForLabelGenreBuilding()
	{
		return "建築";
	}

	protected override string _GetTemplateForLabelGenreComedy()
	{
		return "コメディ";
	}

	protected override string _GetTemplateForLabelGenreFantasy()
	{
		return "中世";
	}

	protected override string _GetTemplateForLabelGenreFighting()
	{
		return "格闘";
	}

	protected override string _GetTemplateForLabelGenreFPS()
	{
		return "FPS";
	}

	protected override string _GetTemplateForLabelGenreFunny()
	{
		return "コメディ";
	}

	protected override string _GetTemplateForLabelGenreHorror()
	{
		return "ホラー";
	}

	protected override string _GetTemplateForLabelGenreMedieval()
	{
		return "中世";
	}

	protected override string _GetTemplateForLabelGenreMilitary()
	{
		return "ミリタリー";
	}

	protected override string _GetTemplateForLabelGenreNaval()
	{
		return "海軍";
	}

	protected override string _GetTemplateForLabelGenreNinja()
	{
		return "格闘";
	}

	protected override string _GetTemplateForLabelGenrePirate()
	{
		return "海軍";
	}

	protected override string _GetTemplateForLabelGenreRPG()
	{
		return "RPG";
	}

	protected override string _GetTemplateForLabelGenreScary()
	{
		return "ホラー";
	}

	protected override string _GetTemplateForLabelGenreSciFi()
	{
		return "SF";
	}

	protected override string _GetTemplateForLabelGenreSports()
	{
		return "スポーツ";
	}

	protected override string _GetTemplateForLabelGenreTownAndCity()
	{
		return "都市開発";
	}

	protected override string _GetTemplateForLabelGenreTutorial()
	{
		return "建築";
	}

	protected override string _GetTemplateForLabelGenreWar()
	{
		return "ミリタリー";
	}

	protected override string _GetTemplateForLabelGenreWestern()
	{
		return "ウエスタン";
	}

	protected override string _GetTemplateForLabelGenreWildWest()
	{
		return "ウエスタン";
	}

	protected override string _GetTemplateForLabelHeads()
	{
		return "頭";
	}

	protected override string _GetTemplateForLabelMostFavorited()
	{
		return "一番人気";
	}

	protected override string _GetTemplateForLabelNoResellers()
	{
		return "再販者なし";
	}

	protected override string _GetTemplateForLabelOffSale()
	{
		return "非売品";
	}

	protected override string _GetTemplateForLabelPackages()
	{
		return "パッケージ";
	}

	protected override string _GetTemplateForLabelPants()
	{
		return "パンツ";
	}

	protected override string _GetTemplateForLabelPastDay()
	{
		return "昨日";
	}

	protected override string _GetTemplateForLabelPastWeek()
	{
		return "先週";
	}

	protected override string _GetTemplateForLabelPriceHighFirst()
	{
		return "価格（高い順）";
	}

	protected override string _GetTemplateForLabelPriceLowFirst()
	{
		return "価格（安い順）";
	}

	protected override string _GetTemplateForLabelRecentlyUpdated()
	{
		return "最近アップデート";
	}

	protected override string _GetTemplateForLabelRelevance()
	{
		return "並べ替え";
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
		return "シャツ";
	}

	protected override string _GetTemplateForLabelTShirts()
	{
		return "Tシャツ";
	}

	protected override string _GetTemplateForResponseErrorFilter()
	{
		return "フィルタタブにエラーがあります";
	}

	protected override string _GetTemplateForResponseGenericError()
	{
		return "エラーが発生しました。後でもう一度お試しください。";
	}

	protected override string _GetTemplateForResponseNoItemsFound()
	{
		return "アイテムが見つかりません。";
	}

	protected override string _GetTemplateForResponseNoSaleItemsFromSearch()
	{
		return "検索しましたが、販売中のアイテムが見つかりませんでした。利用できないアイテムが以下に表示されます。";
	}

	protected override string _GetTemplateForResponseTemporarilyUnavailable()
	{
		return "カタログは一時的に利用できません。後でもう一度お試しください。";
	}

	protected override string _GetTemplateForResponseThrottled()
	{
		return "リクエストの間隔が短すぎます。1分後にもう一度お試しください。";
	}
}
