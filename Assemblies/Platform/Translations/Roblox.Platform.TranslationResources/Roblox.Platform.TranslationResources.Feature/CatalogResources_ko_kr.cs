namespace Roblox.TranslationResources.Feature;

/// <summary>
/// This class overrides CatalogResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class CatalogResources_ko_kr : CatalogResources_en_us, ICatalogResources, ITranslationResources
{
	/// <summary>
	/// Key: "Action.BuyRobux"
	/// English String: "Buy Robux"
	/// </summary>
	public override string ActionBuyRobux => "Robux 구매";

	/// <summary>
	/// Key: "Action.Dialog.AddGearOk"
	/// English String: "OK"
	/// </summary>
	public override string ActionDialogAddGearOk => "확인";

	/// <summary>
	/// Key: "Action.Filter.Apply"
	/// English String: "Apply"
	/// </summary>
	public override string ActionFilterApply => "적용";

	/// <summary>
	/// Key: "Action.Filter.Cancel"
	/// English String: "Cancel"
	/// </summary>
	public override string ActionFilterCancel => "취소";

	/// <summary>
	/// Key: "Action.Go"
	/// English String: "Go"
	/// </summary>
	public override string ActionGo => "이동";

	/// <summary>
	/// Key: "Action.ViewAllItems"
	/// English String: "View All Items"
	/// </summary>
	public override string ActionViewAllItems => "아이템 전체 보기";

	/// <summary>
	/// Key: "Description.Dialog.AddGearBody"
	/// English String: "To add gear to your game, find an item in the catalog and click the Add to Game button. The item will automatically be allowed in game, and you'll receive a commission on every copy sold from your game page. (You can only add gear that's for sale.)"
	/// </summary>
	public override string DescriptionDialogAddGearBody => "게임에 장비를 추가하고 싶나요? 카탈로그에서 아이템을 검색해 '게임에 추가' 버튼을 클릭하세요. 아이템은 게임에 자동적으로 표시되며, 회원님의 게임 페이지에서 판매가 이루어질 때마다 수수료가 지급됩니다. 판매용 장비만 추가할 수 있어요.";

	/// <summary>
	/// Key: "Heading.CatalogCategory"
	/// English String: "Category"
	/// </summary>
	public override string HeadingCatalogCategory => "카테고리";

	/// <summary>
	/// Key: "Heading.CatalogPage"
	/// English String: "Catalog"
	/// </summary>
	public override string HeadingCatalogPage => "카탈로그";

	/// <summary>
	/// Key: "Label.AllFeaturedItems"
	/// English String: "View All Featured Items"
	/// </summary>
	public override string LabelAllFeaturedItems => "주목 아이템 전체 보기";

	/// <summary>
	/// Key: "Label.AllGenres"
	/// English String: "All Genres"
	/// </summary>
	public override string LabelAllGenres => "전체 장르";

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
	public override string LabelBreadCrumbFree => "무료";

	/// <summary>
	/// Key: "Label.BreadCrumb.Group"
	/// English String: "Group:"
	/// </summary>
	public override string LabelBreadCrumbGroup => "그룹:";

	/// <summary>
	/// Key: "Label.Bundle"
	/// Bundle
	/// English String: "Bundle"
	/// </summary>
	public override string LabelBundle => "번들";

	/// <summary>
	/// Key: "Label.Bundles"
	/// Bundles
	/// English String: "Bundles"
	/// </summary>
	public override string LabelBundles => "번들";

	/// <summary>
	/// Key: "Label.Card.CreatorBy"
	/// English String: "By"
	/// </summary>
	public override string LabelCardCreatorBy => "개발:";

	/// <summary>
	/// Key: "Label.Card.PriceWas"
	/// English String: "Was"
	/// </summary>
	public override string LabelCardPriceWas => "이전 가격:";

	/// <summary>
	/// Key: "Label.Card.Remaining"
	/// English String: "Remaining:"
	/// </summary>
	public override string LabelCardRemaining => "잔여:";

	/// <summary>
	/// Key: "Label.CategoryAttributes"
	/// English String: "Attributes"
	/// </summary>
	public override string LabelCategoryAttributes => "속성";

	/// <summary>
	/// Key: "Label.CategoryType"
	/// English String: "Type"
	/// </summary>
	public override string LabelCategoryType => "종류";

	/// <summary>
	/// Key: "Label.CommunityCreations"
	/// UGC items
	/// English String: " Community Creations"
	/// </summary>
	public override string LabelCommunityCreations => "커뮤니티 작품";

	/// <summary>
	/// Key: "Label.Dialog.AddGearTitle"
	/// English String: "Add Gear to Your Game"
	/// </summary>
	public override string LabelDialogAddGearTitle => "게임에 장비를 추가하세요";

	/// <summary>
	/// Key: "Label.Emotes"
	/// Emotes
	/// English String: "Emotes"
	/// </summary>
	public override string LabelEmotes => "감정 표현";

	/// <summary>
	/// Key: "Label.Favorites"
	/// English String: "Favorites"
	/// </summary>
	public override string LabelFavorites => "즐겨찾기";

	/// <summary>
	/// Key: "Label.FeaturedBundles"
	/// Featured Bundles
	/// English String: "Featured Bundles"
	/// </summary>
	public override string LabelFeaturedBundles => "주목 번들";

	/// <summary>
	/// Key: "Label.FeaturedEmotes"
	/// Featured Emotes
	/// English String: "Featured Emotes"
	/// </summary>
	public override string LabelFeaturedEmotes => "주목 감정 표현";

	/// <summary>
	/// Key: "Label.Filter.ByTime"
	/// English String: "By Time"
	/// </summary>
	public override string LabelFilterByTime => "시간 순";

	/// <summary>
	/// Key: "Label.Filter.Category"
	/// English String: "Category"
	/// </summary>
	public override string LabelFilterCategory => "카테고리";

	/// <summary>
	/// Key: "Label.Filter.Creator"
	/// English String: "Creator"
	/// </summary>
	public override string LabelFilterCreator => "개발자";

	/// <summary>
	/// Key: "Label.Filter.Filter"
	/// English String: "Filter"
	/// </summary>
	public override string LabelFilterFilter => "필터";

	/// <summary>
	/// Key: "Label.Filter.Filters"
	/// English String: "Filters"
	/// </summary>
	public override string LabelFilterFilters => "필터";

	/// <summary>
	/// Key: "Label.Filter.Genre"
	/// English String: "Genre"
	/// </summary>
	public override string LabelFilterGenre => "장르";

	/// <summary>
	/// Key: "Label.Filter.Hide"
	/// English String: "Hide"
	/// </summary>
	public override string LabelFilterHide => "감추기";

	/// <summary>
	/// Key: "Label.Filter.Price"
	/// English String: "Price"
	/// </summary>
	public override string LabelFilterPrice => "가격";

	/// <summary>
	/// Key: "Label.Filter.PriceMax"
	/// English String: "Max"
	/// </summary>
	public override string LabelFilterPriceMax => "최고";

	/// <summary>
	/// Key: "Label.Filter.PriceMin"
	/// English String: "Min"
	/// </summary>
	public override string LabelFilterPriceMin => "최저";

	/// <summary>
	/// Key: "Label.Filter.PriceTo"
	/// English String: "To"
	/// </summary>
	public override string LabelFilterPriceTo => "~";

	/// <summary>
	/// Key: "Label.Filter.Show"
	/// English String: "Show"
	/// </summary>
	public override string LabelFilterShow => "보이기";

	/// <summary>
	/// Key: "Label.Filter.Sorting"
	/// English String: "Sorting"
	/// </summary>
	public override string LabelFilterSorting => "정렬";

	/// <summary>
	/// Key: "Label.Filter.UnavailableItems"
	/// English String: "Unavailable Items"
	/// </summary>
	public override string LabelFilterUnavailableItems => "이용 불가 아이템";

	/// <summary>
	/// Key: "Label.GoogleOnly"
	/// label
	/// English String: "Google Only"
	/// </summary>
	public override string LabelGoogleOnly => "Google 전용";

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
	public override string LabelMobile => "모바일";

	/// <summary>
	/// Key: "Label.New"
	/// label
	/// English String: "New"
	/// </summary>
	public override string LabelNew => "신규";

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
	public override string LabelSale => "판매";

	/// <summary>
	/// Key: "Label.SearchField"
	/// English String: "Search"
	/// </summary>
	public override string LabelSearchField => "검색";

	/// <summary>
	/// Key: "Label.SeeAll"
	/// English String: "See All"
	/// </summary>
	public override string LabelSeeAll => "전체 보기";

	/// <summary>
	/// Key: "Label.Username"
	/// English String: "Username"
	/// </summary>
	public override string LabelUsername => "사용자 이름";

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
	public override string LabelAccessories => "장신구";

	/// <summary>
	/// Key: "LabelAccessoryAll"
	/// English String: "All Accessories"
	/// </summary>
	public override string LabelAccessoryAll => "전체 장신구";

	/// <summary>
	/// Key: "LabelAccessoryBack"
	/// English String: "Back"
	/// </summary>
	public override string LabelAccessoryBack => "등";

	/// <summary>
	/// Key: "LabelAccessoryFace"
	/// English String: "Face"
	/// </summary>
	public override string LabelAccessoryFace => "얼굴";

	/// <summary>
	/// Key: "LabelAccessoryFront"
	/// English String: "Front"
	/// </summary>
	public override string LabelAccessoryFront => "가슴";

	/// <summary>
	/// Key: "LabelAccessoryHair"
	/// English String: "Hair"
	/// </summary>
	public override string LabelAccessoryHair => "헤어";

	/// <summary>
	/// Key: "LabelAccessoryHats"
	/// English String: "Hats"
	/// </summary>
	public override string LabelAccessoryHats => "모자";

	/// <summary>
	/// Key: "LabelAccessoryNeck"
	/// English String: "Neck"
	/// </summary>
	public override string LabelAccessoryNeck => "목";

	/// <summary>
	/// Key: "LabelAccessoryShoulder"
	/// English String: "Shoulder"
	/// </summary>
	public override string LabelAccessoryShoulder => "어깨";

	/// <summary>
	/// Key: "LabelAccessoryWaist"
	/// English String: "Waist"
	/// </summary>
	public override string LabelAccessoryWaist => "허리";

	/// <summary>
	/// Key: "LabelAll"
	/// English String: "All"
	/// </summary>
	public override string LabelAll => "전체";

	/// <summary>
	/// Key: "LabelAllBodyParts"
	/// English String: "All Body Parts"
	/// </summary>
	public override string LabelAllBodyParts => "전체 신체 부위";

	/// <summary>
	/// Key: "LabelAllCategories"
	/// English String: "All Categories"
	/// </summary>
	public override string LabelAllCategories => "전체 카테고리";

	/// <summary>
	/// Key: "LabelAllClothing"
	/// English String: "All Clothing"
	/// </summary>
	public override string LabelAllClothing => "전체 복장";

	/// <summary>
	/// Key: "LabelAllCollectibles"
	/// English String: "All Collectibles"
	/// </summary>
	public override string LabelAllCollectibles => "전체 한정판 아이템";

	/// <summary>
	/// Key: "LabelAllCreators"
	/// English String: "All Creators"
	/// </summary>
	public override string LabelAllCreators => "전체 개발자";

	/// <summary>
	/// Key: "LabelAllCurrency"
	/// English String: "All Currency"
	/// </summary>
	public override string LabelAllCurrency => "전체 통화";

	/// <summary>
	/// Key: "LabelAllFeatured"
	/// English String: "All Featured Items"
	/// </summary>
	public override string LabelAllFeatured => "전체 주목 아이템";

	/// <summary>
	/// Key: "LabelAllTime"
	/// English String: "All Time"
	/// </summary>
	public override string LabelAllTime => "전체 기간";

	/// <summary>
	/// Key: "LabelAnimations"
	/// English String: "Animations"
	/// </summary>
	public override string LabelAnimations => "애니메이션";

	/// <summary>
	/// Key: "LabelAnyPrice"
	/// English String: "Any Price"
	/// </summary>
	public override string LabelAnyPrice => "전체 가격";

	/// <summary>
	/// Key: "LabelAvatarAnimations"
	/// English String: "Avatar Animations"
	/// </summary>
	public override string LabelAvatarAnimations => "아바타 애니메이션";

	/// <summary>
	/// Key: "LabelBestselling"
	/// English String: "Bestselling"
	/// </summary>
	public override string LabelBestselling => "판매도 순";

	/// <summary>
	/// Key: "LabelBodyParts"
	/// English String: "Body Parts"
	/// </summary>
	public override string LabelBodyParts => "신체 부위";

	/// <summary>
	/// Key: "LabelClothing"
	/// English String: "Clothing"
	/// </summary>
	public override string LabelClothing => "복장";

	/// <summary>
	/// Key: "LabelCollectibleAccessories"
	/// English String: "Collectible Accessories"
	/// </summary>
	public override string LabelCollectibleAccessories => "수집 가능 장신구";

	/// <summary>
	/// Key: "LabelCollectibleFaces"
	/// English String: "Collectible Faces"
	/// </summary>
	public override string LabelCollectibleFaces => "한정판 얼굴";

	/// <summary>
	/// Key: "LabelCollectibleGear"
	/// English String: "Collectible Gear"
	/// </summary>
	public override string LabelCollectibleGear => "한정판 장비";

	/// <summary>
	/// Key: "LabelCollectibles"
	/// English String: "Collectibles"
	/// </summary>
	public override string LabelCollectibles => "한정판 아이템";

	/// <summary>
	/// Key: "LabelFaces"
	/// English String: "Faces"
	/// </summary>
	public override string LabelFaces => "얼굴";

	/// <summary>
	/// Key: "LabelFeatured"
	/// English String: "Featured"
	/// </summary>
	public override string LabelFeatured => "주목 아이템";

	/// <summary>
	/// Key: "LabelFeaturedAccesories"
	/// English String: "Featured Accessories"
	/// </summary>
	public override string LabelFeaturedAccesories => "주목 장신구";

	/// <summary>
	/// Key: "LabelFeaturedAnimations"
	/// English String: "Featured Animations"
	/// </summary>
	public override string LabelFeaturedAnimations => "주목 애니메이션";

	/// <summary>
	/// Key: "LabelFeaturedFaces"
	/// English String: "Featured Faces"
	/// </summary>
	public override string LabelFeaturedFaces => "주목 얼굴";

	/// <summary>
	/// Key: "LabelFeaturedGear"
	/// English String: "Featured Gear"
	/// </summary>
	public override string LabelFeaturedGear => "주목 장비";

	/// <summary>
	/// Key: "LabelFeaturedPackages"
	/// English String: "Featured Packages"
	/// </summary>
	public override string LabelFeaturedPackages => "주목 패키지";

	/// <summary>
	/// Key: "LabelFree"
	/// English String: "Free"
	/// </summary>
	public override string LabelFree => "무료";

	/// <summary>
	/// Key: "LabelGear"
	/// English String: "Gear"
	/// </summary>
	public override string LabelGear => "장비";

	/// <summary>
	/// Key: "LabelGearAll"
	/// English String: "All Gear"
	/// </summary>
	public override string LabelGearAll => "전체 장비";

	/// <summary>
	/// Key: "LabelGearBuilding"
	/// English String: "Building"
	/// </summary>
	public override string LabelGearBuilding => "건물";

	/// <summary>
	/// Key: "LabelGearExplosive"
	/// English String: "Explosive"
	/// </summary>
	public override string LabelGearExplosive => "폭발물";

	/// <summary>
	/// Key: "LabelGearMelee"
	/// English String: "Melee"
	/// </summary>
	public override string LabelGearMelee => "근접";

	/// <summary>
	/// Key: "LabelGearMusical"
	/// English String: "Musical"
	/// </summary>
	public override string LabelGearMusical => "음악";

	/// <summary>
	/// Key: "LabelGearNavigation"
	/// English String: "Navigation"
	/// </summary>
	public override string LabelGearNavigation => "내비게이션";

	/// <summary>
	/// Key: "LabelGearPersonalTransport"
	/// English String: "Transport"
	/// </summary>
	public override string LabelGearPersonalTransport => "이동수단";

	/// <summary>
	/// Key: "LabelGearPowerUps"
	/// English String: "Power Up"
	/// </summary>
	public override string LabelGearPowerUps => "파워업";

	/// <summary>
	/// Key: "LabelGearRanged"
	/// English String: "Ranged"
	/// </summary>
	public override string LabelGearRanged => "원거리";

	/// <summary>
	/// Key: "LabelGearSocial"
	/// English String: "Social"
	/// </summary>
	public override string LabelGearSocial => "소셜";

	/// <summary>
	/// Key: "LabelGenreAdventure"
	/// English String: "Adventure"
	/// </summary>
	public override string LabelGenreAdventure => "모험";

	/// <summary>
	/// Key: "LabelGenreAll"
	/// English String: "All Genres"
	/// </summary>
	public override string LabelGenreAll => "전체 장르";

	/// <summary>
	/// Key: "LabelGenreBuilding"
	/// English String: "Building"
	/// </summary>
	public override string LabelGenreBuilding => "건설";

	/// <summary>
	/// Key: "LabelGenreComedy"
	/// English String: "Comedy"
	/// </summary>
	public override string LabelGenreComedy => "코미디";

	/// <summary>
	/// Key: "LabelGenreFantasy"
	/// English String: "Medieval"
	/// </summary>
	public override string LabelGenreFantasy => "중세";

	/// <summary>
	/// Key: "LabelGenreFighting"
	/// English String: "Fighting"
	/// </summary>
	public override string LabelGenreFighting => "대전";

	/// <summary>
	/// Key: "LabelGenreFPS"
	/// English String: "FPS"
	/// </summary>
	public override string LabelGenreFPS => "FPS";

	/// <summary>
	/// Key: "LabelGenreFunny"
	/// English String: "Comedy"
	/// </summary>
	public override string LabelGenreFunny => "코미디";

	/// <summary>
	/// Key: "LabelGenreHorror"
	/// English String: "Horror"
	/// </summary>
	public override string LabelGenreHorror => "공포";

	/// <summary>
	/// Key: "LabelGenreMedieval"
	/// English String: "Medieval"
	/// </summary>
	public override string LabelGenreMedieval => "중세";

	/// <summary>
	/// Key: "LabelGenreMilitary"
	/// English String: "Military"
	/// </summary>
	public override string LabelGenreMilitary => "군사";

	/// <summary>
	/// Key: "LabelGenreNaval"
	/// English String: "Naval"
	/// </summary>
	public override string LabelGenreNaval => "해군";

	/// <summary>
	/// Key: "LabelGenreNinja"
	/// English String: "Fighting"
	/// </summary>
	public override string LabelGenreNinja => "대전";

	/// <summary>
	/// Key: "LabelGenrePirate"
	/// English String: "Naval"
	/// </summary>
	public override string LabelGenrePirate => "해군";

	/// <summary>
	/// Key: "LabelGenreRPG"
	/// English String: "RPG"
	/// </summary>
	public override string LabelGenreRPG => "RPG";

	/// <summary>
	/// Key: "LabelGenreScary"
	/// English String: "Horror"
	/// </summary>
	public override string LabelGenreScary => "공포";

	/// <summary>
	/// Key: "LabelGenreSciFi"
	/// English String: "Sci-Fi"
	/// </summary>
	public override string LabelGenreSciFi => "SF";

	/// <summary>
	/// Key: "LabelGenreSports"
	/// English String: "Sports"
	/// </summary>
	public override string LabelGenreSports => "스포츠";

	/// <summary>
	/// Key: "LabelGenreTownAndCity"
	/// English String: "Town and City"
	/// </summary>
	public override string LabelGenreTownAndCity => "마을 및 도시";

	/// <summary>
	/// Key: "LabelGenreTutorial"
	/// English String: "Building"
	/// </summary>
	public override string LabelGenreTutorial => "건설";

	/// <summary>
	/// Key: "LabelGenreWar"
	/// English String: "Military"
	/// </summary>
	public override string LabelGenreWar => "군사";

	/// <summary>
	/// Key: "LabelGenreWestern"
	/// English String: "Western"
	/// </summary>
	public override string LabelGenreWestern => "서부";

	/// <summary>
	/// Key: "LabelGenreWildWest"
	/// English String: "Western"
	/// </summary>
	public override string LabelGenreWildWest => "서부";

	/// <summary>
	/// Key: "LabelHeads"
	/// English String: "Heads"
	/// </summary>
	public override string LabelHeads => "머리";

	/// <summary>
	/// Key: "LabelMostFavorited"
	/// English String: "Most Favorited"
	/// </summary>
	public override string LabelMostFavorited => "인기 상품 순";

	/// <summary>
	/// Key: "LabelNoResellers"
	/// English String: "No Resellers"
	/// </summary>
	public override string LabelNoResellers => "재판매자 없음";

	/// <summary>
	/// Key: "LabelOffSale"
	/// English String: "Offsale"
	/// </summary>
	public override string LabelOffSale => "판매 중단";

	/// <summary>
	/// Key: "LabelPackages"
	/// English String: "Packages"
	/// </summary>
	public override string LabelPackages => "패키지";

	/// <summary>
	/// Key: "LabelPants"
	/// English String: "Pants"
	/// </summary>
	public override string LabelPants => "바지";

	/// <summary>
	/// Key: "LabelPastDay"
	/// English String: "Past Day"
	/// </summary>
	public override string LabelPastDay => "어제";

	/// <summary>
	/// Key: "LabelPastWeek"
	/// English String: "Past Week"
	/// </summary>
	public override string LabelPastWeek => "지난주";

	/// <summary>
	/// Key: "LabelPriceHighFirst"
	/// English String: "Price (High to Low)"
	/// </summary>
	public override string LabelPriceHighFirst => "높은 가격 순";

	/// <summary>
	/// Key: "LabelPriceLowFirst"
	/// English String: "Price (Low to High)"
	/// </summary>
	public override string LabelPriceLowFirst => "낮은 가격 순";

	/// <summary>
	/// Key: "LabelRecentlyUpdated"
	/// English String: "Recently Updated"
	/// </summary>
	public override string LabelRecentlyUpdated => "신상품 순";

	/// <summary>
	/// Key: "LabelRelevance"
	/// English String: "Relevance"
	/// </summary>
	public override string LabelRelevance => "관련도 순";

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
	public override string LabelShirts => "셔츠";

	/// <summary>
	/// Key: "LabelTShirts"
	/// English String: "T-Shirts"
	/// </summary>
	public override string LabelTShirts => "티셔츠";

	/// <summary>
	/// Key: "Response.Error.Filter"
	/// English String: "Errors exist in Filter tab"
	/// </summary>
	public override string ResponseErrorFilter => "필터 탭에 오류 있음";

	/// <summary>
	/// Key: "Response.GenericError"
	/// English String: "An error occurred. Please try again later."
	/// </summary>
	public override string ResponseGenericError => "오류가 발생했어요. 나중에 다시 시도하세요.";

	/// <summary>
	/// Key: "Response.NoItemsFound"
	/// English String: "No items found."
	/// </summary>
	public override string ResponseNoItemsFound => "아이템을 찾을 수 없습니다.";

	/// <summary>
	/// Key: "Response.NoSaleItemsFromSearch"
	/// English String: "Your search did not find items for sale. Unavailable items displayed below."
	/// </summary>
	public override string ResponseNoSaleItemsFromSearch => "검색 결과에 판매 중인 아이템이 존재하지 않습니다. 판매 불가 아이템은 하단을 확인하세요.";

	/// <summary>
	/// Key: "Response.TemporarilyUnavailable"
	/// English String: "Catalog temporarily unavailable. Please try again later."
	/// </summary>
	public override string ResponseTemporarilyUnavailable => "일시적으로 카탈로그 이용 불가. 나중에 다시 시도하세요.";

	/// <summary>
	/// Key: "Response.Throttled"
	/// Shown to users when they have made too many requests in a minute and are being throttled.
	/// English String: "You're going too fast! Try again in a minute."
	/// </summary>
	public override string ResponseThrottled => "요청 횟수가 너무 많아요! 1분 후에 다시 시도하세요.";

	public CatalogResources_ko_kr(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionBuyRobux()
	{
		return "Robux 구매";
	}

	protected override string _GetTemplateForActionDialogAddGearOk()
	{
		return "확인";
	}

	protected override string _GetTemplateForActionFilterApply()
	{
		return "적용";
	}

	protected override string _GetTemplateForActionFilterCancel()
	{
		return "취소";
	}

	protected override string _GetTemplateForActionGo()
	{
		return "이동";
	}

	protected override string _GetTemplateForActionViewAllItems()
	{
		return "아이템 전체 보기";
	}

	protected override string _GetTemplateForDescriptionDialogAddGearBody()
	{
		return "게임에 장비를 추가하고 싶나요? 카탈로그에서 아이템을 검색해 '게임에 추가' 버튼을 클릭하세요. 아이템은 게임에 자동적으로 표시되며, 회원님의 게임 페이지에서 판매가 이루어질 때마다 수수료가 지급됩니다. 판매용 장비만 추가할 수 있어요.";
	}

	protected override string _GetTemplateForHeadingCatalogCategory()
	{
		return "카테고리";
	}

	protected override string _GetTemplateForHeadingCatalogPage()
	{
		return "카탈로그";
	}

	protected override string _GetTemplateForLabelAllFeaturedItems()
	{
		return "주목 아이템 전체 보기";
	}

	protected override string _GetTemplateForLabelAllGenres()
	{
		return "전체 장르";
	}

	protected override string _GetTemplateForLabelAmazon()
	{
		return "Amazon";
	}

	protected override string _GetTemplateForLabelBreadCrumbFree()
	{
		return "무료";
	}

	/// <summary>
	/// Key: "Label.BreadCrumb.GenreOrText"
	/// English String: "{genreName1} or {genreName2}"
	/// </summary>
	public override string LabelBreadCrumbGenreOrText(string genreName1, string genreName2)
	{
		return $"{genreName1} 또는 {genreName2}";
	}

	protected override string _GetTemplateForLabelBreadCrumbGenreOrText()
	{
		return "{genreName1} 또는 {genreName2}";
	}

	/// <summary>
	/// Key: "Label.BreadCrumb.GenreSelectedText"
	/// English String: "Genre: {genreCount} selected"
	/// </summary>
	public override string LabelBreadCrumbGenreSelectedText(string genreCount)
	{
		return $"장르: {genreCount}개 선택됨";
	}

	protected override string _GetTemplateForLabelBreadCrumbGenreSelectedText()
	{
		return "장르: {genreCount}개 선택됨";
	}

	protected override string _GetTemplateForLabelBreadCrumbGroup()
	{
		return "그룹:";
	}

	/// <summary>
	/// Key: "Label.BreadCrumb.PriceAbove"
	/// English String: "{price} and above"
	/// </summary>
	public override string LabelBreadCrumbPriceAbove(string price)
	{
		return $"{price} 이상";
	}

	protected override string _GetTemplateForLabelBreadCrumbPriceAbove()
	{
		return "{price} 이상";
	}

	/// <summary>
	/// Key: "Label.BreadCrumb.PriceBelow"
	/// English String: "{price} and below"
	/// </summary>
	public override string LabelBreadCrumbPriceBelow(string price)
	{
		return $"{price} 이하";
	}

	protected override string _GetTemplateForLabelBreadCrumbPriceBelow()
	{
		return "{price} 이하";
	}

	/// <summary>
	/// Key: "Label.BreadCrumb.ResultsCount"
	/// English String: "{startNumber} - {endNumber} of {resultsCount} Results"
	/// </summary>
	public override string LabelBreadCrumbResultsCount(string startNumber, string endNumber, string resultsCount)
	{
		return $"{startNumber} ~ {endNumber} / {resultsCount}개 결과";
	}

	protected override string _GetTemplateForLabelBreadCrumbResultsCount()
	{
		return "{startNumber} ~ {endNumber} / {resultsCount}개 결과";
	}

	protected override string _GetTemplateForLabelBundle()
	{
		return "번들";
	}

	protected override string _GetTemplateForLabelBundles()
	{
		return "번들";
	}

	/// <summary>
	/// Key: "Label.ByCreatorLink"
	/// Creator name in item card with link
	/// English String: "By {linkStart}{creator}{linkEnd}"
	/// </summary>
	public override string LabelByCreatorLink(string linkStart, string creator, string linkEnd)
	{
		return $"제작: {linkStart}{creator}{linkEnd}";
	}

	protected override string _GetTemplateForLabelByCreatorLink()
	{
		return "제작: {linkStart}{creator}{linkEnd}";
	}

	protected override string _GetTemplateForLabelCardCreatorBy()
	{
		return "개발:";
	}

	protected override string _GetTemplateForLabelCardPriceWas()
	{
		return "이전 가격:";
	}

	protected override string _GetTemplateForLabelCardRemaining()
	{
		return "잔여:";
	}

	protected override string _GetTemplateForLabelCategoryAttributes()
	{
		return "속성";
	}

	protected override string _GetTemplateForLabelCategoryType()
	{
		return "종류";
	}

	protected override string _GetTemplateForLabelCommunityCreations()
	{
		return "커뮤니티 작품";
	}

	protected override string _GetTemplateForLabelDialogAddGearTitle()
	{
		return "게임에 장비를 추가하세요";
	}

	protected override string _GetTemplateForLabelEmotes()
	{
		return "감정 표현";
	}

	protected override string _GetTemplateForLabelFavorites()
	{
		return "즐겨찾기";
	}

	protected override string _GetTemplateForLabelFeaturedBundles()
	{
		return "주목 번들";
	}

	protected override string _GetTemplateForLabelFeaturedEmotes()
	{
		return "주목 감정 표현";
	}

	/// <summary>
	/// Key: "Label.FeaturedItemsOnRoblox"
	/// English String: "Featured Items on {spanStart}{roblox}{spanEnd}"
	/// </summary>
	public override string LabelFeaturedItemsOnRoblox(string spanStart, string roblox, string spanEnd)
	{
		return $"{spanStart}{roblox}{spanEnd}의 주목 아이템";
	}

	protected override string _GetTemplateForLabelFeaturedItemsOnRoblox()
	{
		return "{spanStart}{roblox}{spanEnd}의 주목 아이템";
	}

	protected override string _GetTemplateForLabelFilterByTime()
	{
		return "시간 순";
	}

	protected override string _GetTemplateForLabelFilterCategory()
	{
		return "카테고리";
	}

	protected override string _GetTemplateForLabelFilterCreator()
	{
		return "개발자";
	}

	protected override string _GetTemplateForLabelFilterFilter()
	{
		return "필터";
	}

	protected override string _GetTemplateForLabelFilterFilters()
	{
		return "필터";
	}

	protected override string _GetTemplateForLabelFilterGenre()
	{
		return "장르";
	}

	protected override string _GetTemplateForLabelFilterHide()
	{
		return "감추기";
	}

	protected override string _GetTemplateForLabelFilterPrice()
	{
		return "가격";
	}

	protected override string _GetTemplateForLabelFilterPriceMax()
	{
		return "최고";
	}

	protected override string _GetTemplateForLabelFilterPriceMin()
	{
		return "최저";
	}

	protected override string _GetTemplateForLabelFilterPriceTo()
	{
		return "~";
	}

	protected override string _GetTemplateForLabelFilterShow()
	{
		return "보이기";
	}

	protected override string _GetTemplateForLabelFilterSorting()
	{
		return "정렬";
	}

	protected override string _GetTemplateForLabelFilterUnavailableItems()
	{
		return "이용 불가 아이템";
	}

	protected override string _GetTemplateForLabelGoogleOnly()
	{
		return "Google 전용";
	}

	protected override string _GetTemplateForLabelIos()
	{
		return "iOS";
	}

	protected override string _GetTemplateForLabelMobile()
	{
		return "모바일";
	}

	protected override string _GetTemplateForLabelNew()
	{
		return "신규";
	}

	protected override string _GetTemplateForLabelRthro()
	{
		return "Rthro";
	}

	protected override string _GetTemplateForLabelSale()
	{
		return "판매";
	}

	protected override string _GetTemplateForLabelSearchField()
	{
		return "검색";
	}

	protected override string _GetTemplateForLabelSeeAll()
	{
		return "전체 보기";
	}

	protected override string _GetTemplateForLabelUsername()
	{
		return "사용자 이름";
	}

	protected override string _GetTemplateForLabelXbox()
	{
		return "Xbox";
	}

	protected override string _GetTemplateForLabelAccessories()
	{
		return "장신구";
	}

	protected override string _GetTemplateForLabelAccessoryAll()
	{
		return "전체 장신구";
	}

	protected override string _GetTemplateForLabelAccessoryBack()
	{
		return "등";
	}

	protected override string _GetTemplateForLabelAccessoryFace()
	{
		return "얼굴";
	}

	protected override string _GetTemplateForLabelAccessoryFront()
	{
		return "가슴";
	}

	protected override string _GetTemplateForLabelAccessoryHair()
	{
		return "헤어";
	}

	protected override string _GetTemplateForLabelAccessoryHats()
	{
		return "모자";
	}

	protected override string _GetTemplateForLabelAccessoryNeck()
	{
		return "목";
	}

	protected override string _GetTemplateForLabelAccessoryShoulder()
	{
		return "어깨";
	}

	protected override string _GetTemplateForLabelAccessoryWaist()
	{
		return "허리";
	}

	protected override string _GetTemplateForLabelAll()
	{
		return "전체";
	}

	protected override string _GetTemplateForLabelAllBodyParts()
	{
		return "전체 신체 부위";
	}

	protected override string _GetTemplateForLabelAllCategories()
	{
		return "전체 카테고리";
	}

	protected override string _GetTemplateForLabelAllClothing()
	{
		return "전체 복장";
	}

	protected override string _GetTemplateForLabelAllCollectibles()
	{
		return "전체 한정판 아이템";
	}

	protected override string _GetTemplateForLabelAllCreators()
	{
		return "전체 개발자";
	}

	protected override string _GetTemplateForLabelAllCurrency()
	{
		return "전체 통화";
	}

	protected override string _GetTemplateForLabelAllFeatured()
	{
		return "전체 주목 아이템";
	}

	protected override string _GetTemplateForLabelAllTime()
	{
		return "전체 기간";
	}

	protected override string _GetTemplateForLabelAnimations()
	{
		return "애니메이션";
	}

	protected override string _GetTemplateForLabelAnyPrice()
	{
		return "전체 가격";
	}

	protected override string _GetTemplateForLabelAvatarAnimations()
	{
		return "아바타 애니메이션";
	}

	protected override string _GetTemplateForLabelBestselling()
	{
		return "판매도 순";
	}

	protected override string _GetTemplateForLabelBodyParts()
	{
		return "신체 부위";
	}

	protected override string _GetTemplateForLabelClothing()
	{
		return "복장";
	}

	protected override string _GetTemplateForLabelCollectibleAccessories()
	{
		return "수집 가능 장신구";
	}

	protected override string _GetTemplateForLabelCollectibleFaces()
	{
		return "한정판 얼굴";
	}

	protected override string _GetTemplateForLabelCollectibleGear()
	{
		return "한정판 장비";
	}

	protected override string _GetTemplateForLabelCollectibles()
	{
		return "한정판 아이템";
	}

	protected override string _GetTemplateForLabelFaces()
	{
		return "얼굴";
	}

	protected override string _GetTemplateForLabelFeatured()
	{
		return "주목 아이템";
	}

	protected override string _GetTemplateForLabelFeaturedAccesories()
	{
		return "주목 장신구";
	}

	protected override string _GetTemplateForLabelFeaturedAnimations()
	{
		return "주목 애니메이션";
	}

	protected override string _GetTemplateForLabelFeaturedFaces()
	{
		return "주목 얼굴";
	}

	protected override string _GetTemplateForLabelFeaturedGear()
	{
		return "주목 장비";
	}

	protected override string _GetTemplateForLabelFeaturedPackages()
	{
		return "주목 패키지";
	}

	protected override string _GetTemplateForLabelFree()
	{
		return "무료";
	}

	protected override string _GetTemplateForLabelGear()
	{
		return "장비";
	}

	protected override string _GetTemplateForLabelGearAll()
	{
		return "전체 장비";
	}

	protected override string _GetTemplateForLabelGearBuilding()
	{
		return "건물";
	}

	protected override string _GetTemplateForLabelGearExplosive()
	{
		return "폭발물";
	}

	protected override string _GetTemplateForLabelGearMelee()
	{
		return "근접";
	}

	protected override string _GetTemplateForLabelGearMusical()
	{
		return "음악";
	}

	protected override string _GetTemplateForLabelGearNavigation()
	{
		return "내비게이션";
	}

	protected override string _GetTemplateForLabelGearPersonalTransport()
	{
		return "이동수단";
	}

	protected override string _GetTemplateForLabelGearPowerUps()
	{
		return "파워업";
	}

	protected override string _GetTemplateForLabelGearRanged()
	{
		return "원거리";
	}

	protected override string _GetTemplateForLabelGearSocial()
	{
		return "소셜";
	}

	protected override string _GetTemplateForLabelGenreAdventure()
	{
		return "모험";
	}

	protected override string _GetTemplateForLabelGenreAll()
	{
		return "전체 장르";
	}

	protected override string _GetTemplateForLabelGenreBuilding()
	{
		return "건설";
	}

	protected override string _GetTemplateForLabelGenreComedy()
	{
		return "코미디";
	}

	protected override string _GetTemplateForLabelGenreFantasy()
	{
		return "중세";
	}

	protected override string _GetTemplateForLabelGenreFighting()
	{
		return "대전";
	}

	protected override string _GetTemplateForLabelGenreFPS()
	{
		return "FPS";
	}

	protected override string _GetTemplateForLabelGenreFunny()
	{
		return "코미디";
	}

	protected override string _GetTemplateForLabelGenreHorror()
	{
		return "공포";
	}

	protected override string _GetTemplateForLabelGenreMedieval()
	{
		return "중세";
	}

	protected override string _GetTemplateForLabelGenreMilitary()
	{
		return "군사";
	}

	protected override string _GetTemplateForLabelGenreNaval()
	{
		return "해군";
	}

	protected override string _GetTemplateForLabelGenreNinja()
	{
		return "대전";
	}

	protected override string _GetTemplateForLabelGenrePirate()
	{
		return "해군";
	}

	protected override string _GetTemplateForLabelGenreRPG()
	{
		return "RPG";
	}

	protected override string _GetTemplateForLabelGenreScary()
	{
		return "공포";
	}

	protected override string _GetTemplateForLabelGenreSciFi()
	{
		return "SF";
	}

	protected override string _GetTemplateForLabelGenreSports()
	{
		return "스포츠";
	}

	protected override string _GetTemplateForLabelGenreTownAndCity()
	{
		return "마을 및 도시";
	}

	protected override string _GetTemplateForLabelGenreTutorial()
	{
		return "건설";
	}

	protected override string _GetTemplateForLabelGenreWar()
	{
		return "군사";
	}

	protected override string _GetTemplateForLabelGenreWestern()
	{
		return "서부";
	}

	protected override string _GetTemplateForLabelGenreWildWest()
	{
		return "서부";
	}

	protected override string _GetTemplateForLabelHeads()
	{
		return "머리";
	}

	protected override string _GetTemplateForLabelMostFavorited()
	{
		return "인기 상품 순";
	}

	protected override string _GetTemplateForLabelNoResellers()
	{
		return "재판매자 없음";
	}

	protected override string _GetTemplateForLabelOffSale()
	{
		return "판매 중단";
	}

	protected override string _GetTemplateForLabelPackages()
	{
		return "패키지";
	}

	protected override string _GetTemplateForLabelPants()
	{
		return "바지";
	}

	protected override string _GetTemplateForLabelPastDay()
	{
		return "어제";
	}

	protected override string _GetTemplateForLabelPastWeek()
	{
		return "지난주";
	}

	protected override string _GetTemplateForLabelPriceHighFirst()
	{
		return "높은 가격 순";
	}

	protected override string _GetTemplateForLabelPriceLowFirst()
	{
		return "낮은 가격 순";
	}

	protected override string _GetTemplateForLabelRecentlyUpdated()
	{
		return "신상품 순";
	}

	protected override string _GetTemplateForLabelRelevance()
	{
		return "관련도 순";
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
		return "셔츠";
	}

	protected override string _GetTemplateForLabelTShirts()
	{
		return "티셔츠";
	}

	protected override string _GetTemplateForResponseErrorFilter()
	{
		return "필터 탭에 오류 있음";
	}

	protected override string _GetTemplateForResponseGenericError()
	{
		return "오류가 발생했어요. 나중에 다시 시도하세요.";
	}

	protected override string _GetTemplateForResponseNoItemsFound()
	{
		return "아이템을 찾을 수 없습니다.";
	}

	protected override string _GetTemplateForResponseNoSaleItemsFromSearch()
	{
		return "검색 결과에 판매 중인 아이템이 존재하지 않습니다. 판매 불가 아이템은 하단을 확인하세요.";
	}

	protected override string _GetTemplateForResponseTemporarilyUnavailable()
	{
		return "일시적으로 카탈로그 이용 불가. 나중에 다시 시도하세요.";
	}

	protected override string _GetTemplateForResponseThrottled()
	{
		return "요청 횟수가 너무 많아요! 1분 후에 다시 시도하세요.";
	}
}
