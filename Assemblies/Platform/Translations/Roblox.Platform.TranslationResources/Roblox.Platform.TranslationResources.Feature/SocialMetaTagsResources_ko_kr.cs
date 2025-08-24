namespace Roblox.TranslationResources.Feature;

/// <summary>
/// This class overrides SocialMetaTagsResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class SocialMetaTagsResources_ko_kr : SocialMetaTagsResources_en_us, ISocialMetaTagsResources, ITranslationResources
{
	/// <summary>
	/// Key: "Description.DevelopLanding"
	/// description shown on Facebook or Twitter when shared
	/// English String: "Create anything you can imagine with Roblox's free and immersive creation engine. Start creating games today!"
	/// </summary>
	public override string DescriptionDevelopLanding => "Roblox가 무료로 제공하는 몰입형 생성 엔진을 사용해 상상하는 모든 것을 만들어 볼 수 있어요. 지금 게임을 만들어보세요!";

	/// <summary>
	/// Key: "Description.GamesPage"
	/// description shown when Games page is shared on Facebook or Twitter
	/// English String: "Play millions of free games on your smartphone, tablet, computer, Xbox One, Oculus Rift, and more."
	/// </summary>
	public override string DescriptionGamesPage => "스마트폰, 태블릿, 컴퓨터, Xbox One, Oculus Rift 등에서 수많은 게임을 무료로 플레이하세요.";

	/// <summary>
	/// Key: "Description.Roblox"
	/// description shown on Facebook or Twitter when Roblox landing page is shared
	/// English String: "Roblox is ushering in the next generation of entertainment. Imagine, create, and play together with millions of players across an infinite variety of immersive, user-generated 3D worlds."
	/// </summary>
	public override string DescriptionRoblox => "Roblox는 차세대 엔터테인먼트의 선두 주자입니다. 수백만 명의 플레이어와 함께 다양하고 흥미진진한 사용자 제작 3D 세상에서 상상의 나래를 펼치면서 게임을 개발하고 즐겨보세요. ";

	/// <summary>
	/// Key: "Label.CatalogPage"
	/// Description shown when the catalog page is shared on Facebook or Twitter
	/// English String: "Customize your avatar with a never-ending variety of clothing options, accessories, gear, and more!"
	/// </summary>
	public override string LabelCatalogPage => "셀 수 없이 많은 복장, 장신구, 장비 등으로 나만의 아바타를 마음껏 꾸며보세요!";

	/// <summary>
	/// Key: "Label.CatalogPageTItle"
	/// title
	/// English String: "Roblox Catalog"
	/// </summary>
	public override string LabelCatalogPageTItle => "Roblox 카탈로그";

	/// <summary>
	/// Key: "Label.GamesPageTitle"
	/// title for social meta tag fro games page
	/// English String: "Roblox Games"
	/// </summary>
	public override string LabelGamesPageTitle => "Roblox 게임";

	public SocialMetaTagsResources_ko_kr(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForDescriptionDevelopLanding()
	{
		return "Roblox가 무료로 제공하는 몰입형 생성 엔진을 사용해 상상하는 모든 것을 만들어 볼 수 있어요. 지금 게임을 만들어보세요!";
	}

	/// <summary>
	/// Key: "Description.FavoritesPage"
	/// social meta tag
	/// English String: "Visit {userName}’s Favorites and see what they like. Browse through their favorite places, accessories, and a lot more. Also, find the favorite gear they use in games and get one for yourself!"
	/// </summary>
	public override string DescriptionFavoritesPage(string userName)
	{
		return $"{userName}의 즐겨찾기를 방문해 {userName}님이 좋아하는 장소, 장신구 등 다양한 아이템을 구경해보세요. 또한 사용자가 게임에서 즐겨 사용하는 장비를 살펴보고 한 번 구입해보세요!";
	}

	protected override string _GetTemplateForDescriptionFavoritesPage()
	{
		return "{userName}의 즐겨찾기를 방문해 {userName}님이 좋아하는 장소, 장신구 등 다양한 아이템을 구경해보세요. 또한 사용자가 게임에서 즐겨 사용하는 장비를 살펴보고 한 번 구입해보세요!";
	}

	/// <summary>
	/// Key: "Description.GamePage"
	/// The game description which shows on social media, when shared
	/// English String: "Check out {gameName}. It’s one of the millions of unique, user-generated 3D experiences created on Roblox. {gameDescription}"
	/// </summary>
	public override string DescriptionGamePage(string gameName, string gameDescription)
	{
		return $"Roblox에서 제작된 수백만 개의  사용자 제작 3D 콘텐츠 중 하나인 {gameName}을(를) 살펴보세요. {gameDescription}";
	}

	protected override string _GetTemplateForDescriptionGamePage()
	{
		return "Roblox에서 제작된 수백만 개의  사용자 제작 3D 콘텐츠 중 하나인 {gameName}을(를) 살펴보세요. {gameDescription}";
	}

	protected override string _GetTemplateForDescriptionGamesPage()
	{
		return "스마트폰, 태블릿, 컴퓨터, Xbox One, Oculus Rift 등에서 수많은 게임을 무료로 플레이하세요.";
	}

	/// <summary>
	/// Key: "Description.InventoryPage"
	/// social meta tag
	/// English String: "Visit {userName1}’s Inventory and see the cool items they have collected. Look out for their game passes and get one for yourself! Browse through {userName2}’s collection of hats, shirts, gear, and more."
	/// </summary>
	public override string DescriptionInventoryPage(string userName1, string userName2)
	{
		return $"{userName1}님의 인벤토리를 방문해 멋진 수집 아이템을 구경해보세요. 게임패스도 살펴보고 한 번 구입해보세요! {userName2}님의 모자, 셔츠, 장비 등의 컬렉션을 구경하세요.";
	}

	protected override string _GetTemplateForDescriptionInventoryPage()
	{
		return "{userName1}님의 인벤토리를 방문해 멋진 수집 아이템을 구경해보세요. 게임패스도 살펴보고 한 번 구입해보세요! {userName2}님의 모자, 셔츠, 장비 등의 컬렉션을 구경하세요.";
	}

	protected override string _GetTemplateForDescriptionRoblox()
	{
		return "Roblox는 차세대 엔터테인먼트의 선두 주자입니다. 수백만 명의 플레이어와 함께 다양하고 흥미진진한 사용자 제작 3D 세상에서 상상의 나래를 펼치면서 게임을 개발하고 즐겨보세요. ";
	}

	/// <summary>
	/// Key: "Description.UserProfilePage"
	/// message when a user profile is shared on Social Media
	/// English String: "{userName1} is one of the millions playing, creating and exploring the endless possibilities of Roblox. Join {userName2} on Roblox and explore together!"
	/// </summary>
	public override string DescriptionUserProfilePage(string userName1, string userName2)
	{
		return $"{userName1}님은 무한한 가능성으로 가득한 Roblox 세상을 즐기고 탐험하며 콘텐츠를 만드는 많은 사용자 중 하나예요. Roblox에서 {userName2}님과 함께하세요!";
	}

	protected override string _GetTemplateForDescriptionUserProfilePage()
	{
		return "{userName1}님은 무한한 가능성으로 가득한 Roblox 세상을 즐기고 탐험하며 콘텐츠를 만드는 많은 사용자 중 하나예요. Roblox에서 {userName2}님과 함께하세요!";
	}

	protected override string _GetTemplateForLabelCatalogPage()
	{
		return "셀 수 없이 많은 복장, 장신구, 장비 등으로 나만의 아바타를 마음껏 꾸며보세요!";
	}

	protected override string _GetTemplateForLabelCatalogPageTItle()
	{
		return "Roblox 카탈로그";
	}

	protected override string _GetTemplateForLabelGamesPageTitle()
	{
		return "Roblox 게임";
	}

	/// <summary>
	/// Key: "Label.UserProfile"
	/// title of the social meta tag
	/// English String: "{userName}'s Profile"
	/// </summary>
	public override string LabelUserProfile(string userName)
	{
		return $"{userName}님의 프로필";
	}

	protected override string _GetTemplateForLabelUserProfile()
	{
		return "{userName}님의 프로필";
	}
}
