namespace Roblox.TranslationResources.Feature;

/// <summary>
/// This class overrides SocialMetaTagsResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class SocialMetaTagsResources_zh_tw : SocialMetaTagsResources_en_us, ISocialMetaTagsResources, ITranslationResources
{
	/// <summary>
	/// Key: "Description.DevelopLanding"
	/// description shown on Facebook or Twitter when shared
	/// English String: "Create anything you can imagine with Roblox's free and immersive creation engine. Start creating games today!"
	/// </summary>
	public override string DescriptionDevelopLanding => "使用 Roblox 免費而身歷其境的創作平台，讓您創作您所想像的一切。現在就來開始創作遊戲吧！";

	/// <summary>
	/// Key: "Description.GamesPage"
	/// description shown when Games page is shared on Facebook or Twitter
	/// English String: "Play millions of free games on your smartphone, tablet, computer, Xbox One, Oculus Rift, and more."
	/// </summary>
	public override string DescriptionGamesPage => "在您的智慧手機、平板電腦、電腦、Xbox One、Oculus Rift 等裝置盡情遊玩超過一百萬款遊戲。";

	/// <summary>
	/// Key: "Description.Roblox"
	/// description shown on Facebook or Twitter when Roblox landing page is shared
	/// English String: "Roblox is ushering in the next generation of entertainment. Imagine, create, and play together with millions of players across an infinite variety of immersive, user-generated 3D worlds."
	/// </summary>
	public override string DescriptionRoblox => "Roblox 正在開創娛樂的新世紀；在一系列的使用者創作、身歷其境的 3D 世界中，和數百萬名家發揮想像力，一起創造和同樂。";

	/// <summary>
	/// Key: "Label.CatalogPage"
	/// Description shown when the catalog page is shared on Facebook or Twitter
	/// English String: "Customize your avatar with a never-ending variety of clothing options, accessories, gear, and more!"
	/// </summary>
	public override string LabelCatalogPage => "以成千上萬種服裝、飾品、裝備等道具自訂您的虛擬人偶！";

	/// <summary>
	/// Key: "Label.CatalogPageTItle"
	/// title
	/// English String: "Roblox Catalog"
	/// </summary>
	public override string LabelCatalogPageTItle => "Roblox 型錄";

	/// <summary>
	/// Key: "Label.GamesPageTitle"
	/// title for social meta tag fro games page
	/// English String: "Roblox Games"
	/// </summary>
	public override string LabelGamesPageTitle => "Roblox 遊戲";

	public SocialMetaTagsResources_zh_tw(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForDescriptionDevelopLanding()
	{
		return "使用 Roblox 免費而身歷其境的創作平台，讓您創作您所想像的一切。現在就來開始創作遊戲吧！";
	}

	/// <summary>
	/// Key: "Description.FavoritesPage"
	/// social meta tag
	/// English String: "Visit {userName}’s Favorites and see what they like. Browse through their favorite places, accessories, and a lot more. Also, find the favorite gear they use in games and get one for yourself!"
	/// </summary>
	public override string DescriptionFavoritesPage(string userName)
	{
		return $"看看 {userName} 的最愛，瀏覽他們最喜愛的空間、飾品及其它項目。找找看他們在遊戲中最常用的裝備，自己也來買一件！";
	}

	protected override string _GetTemplateForDescriptionFavoritesPage()
	{
		return "看看 {userName} 的最愛，瀏覽他們最喜愛的空間、飾品及其它項目。找找看他們在遊戲中最常用的裝備，自己也來買一件！";
	}

	/// <summary>
	/// Key: "Description.GamePage"
	/// The game description which shows on social media, when shared
	/// English String: "Check out {gameName}. It’s one of the millions of unique, user-generated 3D experiences created on Roblox. {gameDescription}"
	/// </summary>
	public override string DescriptionGamePage(string gameName, string gameDescription)
	{
		return $"看看 {gameName}，Roblox 上數百萬種獨一無二、使用者創作的 3D 體驗之一。{gameDescription}";
	}

	protected override string _GetTemplateForDescriptionGamePage()
	{
		return "看看 {gameName}，Roblox 上數百萬種獨一無二、使用者創作的 3D 體驗之一。{gameDescription}";
	}

	protected override string _GetTemplateForDescriptionGamesPage()
	{
		return "在您的智慧手機、平板電腦、電腦、Xbox One、Oculus Rift 等裝置盡情遊玩超過一百萬款遊戲。";
	}

	/// <summary>
	/// Key: "Description.InventoryPage"
	/// social meta tag
	/// English String: "Visit {userName1}’s Inventory and see the cool items they have collected. Look out for their game passes and get one for yourself! Browse through {userName2}’s collection of hats, shirts, gear, and more."
	/// </summary>
	public override string DescriptionInventoryPage(string userName1, string userName2)
	{
		return $"前往 {userName1} 的道具欄，看看對方收藏的酷炫道具。注意對方有哪些遊戲通行證，自己也來一張！歡迎仔細瀏覽 {userName2} 的帽子、上衣、裝備及其它收藏。";
	}

	protected override string _GetTemplateForDescriptionInventoryPage()
	{
		return "前往 {userName1} 的道具欄，看看對方收藏的酷炫道具。注意對方有哪些遊戲通行證，自己也來一張！歡迎仔細瀏覽 {userName2} 的帽子、上衣、裝備及其它收藏。";
	}

	protected override string _GetTemplateForDescriptionRoblox()
	{
		return "Roblox 正在開創娛樂的新世紀；在一系列的使用者創作、身歷其境的 3D 世界中，和數百萬名家發揮想像力，一起創造和同樂。";
	}

	/// <summary>
	/// Key: "Description.UserProfilePage"
	/// message when a user profile is shared on Social Media
	/// English String: "{userName1} is one of the millions playing, creating and exploring the endless possibilities of Roblox. Join {userName2} on Roblox and explore together!"
	/// </summary>
	public override string DescriptionUserProfilePage(string userName1, string userName2)
	{
		return $"{userName1} 正在和數百萬名 Roblox 玩家一起同樂、創作、探索。加入 Roblox，和 {userName2} 一起探索吧！";
	}

	protected override string _GetTemplateForDescriptionUserProfilePage()
	{
		return "{userName1} 正在和數百萬名 Roblox 玩家一起同樂、創作、探索。加入 Roblox，和 {userName2} 一起探索吧！";
	}

	protected override string _GetTemplateForLabelCatalogPage()
	{
		return "以成千上萬種服裝、飾品、裝備等道具自訂您的虛擬人偶！";
	}

	protected override string _GetTemplateForLabelCatalogPageTItle()
	{
		return "Roblox 型錄";
	}

	protected override string _GetTemplateForLabelGamesPageTitle()
	{
		return "Roblox 遊戲";
	}

	/// <summary>
	/// Key: "Label.UserProfile"
	/// title of the social meta tag
	/// English String: "{userName}'s Profile"
	/// </summary>
	public override string LabelUserProfile(string userName)
	{
		return $"{userName} 的個人檔案";
	}

	protected override string _GetTemplateForLabelUserProfile()
	{
		return "{userName} 的個人檔案";
	}
}
