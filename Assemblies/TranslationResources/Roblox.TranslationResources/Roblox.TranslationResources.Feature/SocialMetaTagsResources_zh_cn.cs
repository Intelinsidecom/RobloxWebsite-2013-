namespace Roblox.TranslationResources.Feature;

/// <summary>
/// This class overrides SocialMetaTagsResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class SocialMetaTagsResources_zh_cn : SocialMetaTagsResources_en_us, ISocialMetaTagsResources, ITranslationResources
{
	/// <summary>
	/// Key: "Description.DevelopLanding"
	/// description shown on Facebook or Twitter when shared
	/// English String: "Create anything you can imagine with Roblox's free and immersive creation engine. Start creating games today!"
	/// </summary>
	public override string DescriptionDevelopLanding => "使用 Roblox 免费的沉浸式创意引擎，创造你能想象的一切。现在就开始创作游戏吧！";

	/// <summary>
	/// Key: "Description.GamesPage"
	/// description shown when Games page is shared on Facebook or Twitter
	/// English String: "Play millions of free games on your smartphone, tablet, computer, Xbox One, Oculus Rift, and more."
	/// </summary>
	public override string DescriptionGamesPage => "数百万款免费游戏，在你的智能手机、平板电脑、电脑、Xbox One、Oculus Rift 及更多设备上畅玩。";

	/// <summary>
	/// Key: "Description.Roblox"
	/// description shown on Facebook or Twitter when Roblox landing page is shared
	/// English String: "Roblox is ushering in the next generation of entertainment. Imagine, create, and play together with millions of players across an infinite variety of immersive, user-generated 3D worlds."
	/// </summary>
	public override string DescriptionRoblox => "Roblox 正在开创新一代的娱乐方式，让数百万玩家都能在一个由用户生成的沉浸式 3D 世界中想象、创造、一同玩耍。";

	/// <summary>
	/// Key: "Label.CatalogPage"
	/// Description shown when the catalog page is shared on Facebook or Twitter
	/// English String: "Customize your avatar with a never-ending variety of clothing options, accessories, gear, and more!"
	/// </summary>
	public override string LabelCatalogPage => "使用成千上万件服装、饰品、装备等物品来自定义你的虚拟形象！";

	/// <summary>
	/// Key: "Label.CatalogPageTItle"
	/// title
	/// English String: "Roblox Catalog"
	/// </summary>
	public override string LabelCatalogPageTItle => "Roblox 商店";

	/// <summary>
	/// Key: "Label.GamesPageTitle"
	/// title for social meta tag fro games page
	/// English String: "Roblox Games"
	/// </summary>
	public override string LabelGamesPageTitle => "Roblox 游戏";

	public SocialMetaTagsResources_zh_cn(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForDescriptionDevelopLanding()
	{
		return "使用 Roblox 免费的沉浸式创意引擎，创造你能想象的一切。现在就开始创作游戏吧！";
	}

	/// <summary>
	/// Key: "Description.FavoritesPage"
	/// social meta tag
	/// English String: "Visit {userName}’s Favorites and see what they like. Browse through their favorite places, accessories, and a lot more. Also, find the favorite gear they use in games and get one for yourself!"
	/// </summary>
	public override string DescriptionFavoritesPage(string userName)
	{
		return $"请访问“{userName}”的最爱，看看他们喜欢什么。你也可以浏览他们最喜爱的游戏场景、饰品和其他内容。此外，你还能找到他们在游戏中最常使用的装备，你同样可以拥有！";
	}

	protected override string _GetTemplateForDescriptionFavoritesPage()
	{
		return "请访问“{userName}”的最爱，看看他们喜欢什么。你也可以浏览他们最喜爱的游戏场景、饰品和其他内容。此外，你还能找到他们在游戏中最常使用的装备，你同样可以拥有！";
	}

	/// <summary>
	/// Key: "Description.GamePage"
	/// The game description which shows on social media, when shared
	/// English String: "Check out {gameName}. It’s one of the millions of unique, user-generated 3D experiences created on Roblox. {gameDescription}"
	/// </summary>
	public override string DescriptionGamePage(string gameName, string gameDescription)
	{
		return $"请参考“{gameName}”，给你 Roblox 上数百万种独一无二，由用户创作的 3D 体验。{gameDescription}";
	}

	protected override string _GetTemplateForDescriptionGamePage()
	{
		return "请参考“{gameName}”，给你 Roblox 上数百万种独一无二，由用户创作的 3D 体验。{gameDescription}";
	}

	protected override string _GetTemplateForDescriptionGamesPage()
	{
		return "数百万款免费游戏，在你的智能手机、平板电脑、电脑、Xbox One、Oculus Rift 及更多设备上畅玩。";
	}

	/// <summary>
	/// Key: "Description.InventoryPage"
	/// social meta tag
	/// English String: "Visit {userName1}’s Inventory and see the cool items they have collected. Look out for their game passes and get one for yourself! Browse through {userName2}’s collection of hats, shirts, gear, and more."
	/// </summary>
	public override string DescriptionInventoryPage(string userName1, string userName2)
	{
		return $"请访问“{userName1}”的道具库，查看他们的酷炫收藏。看看他们的游戏通行证，你也可以同样拥有！你还可以浏览“{userName2}”收藏的帽子、衬衫、装备等道具。";
	}

	protected override string _GetTemplateForDescriptionInventoryPage()
	{
		return "请访问“{userName1}”的道具库，查看他们的酷炫收藏。看看他们的游戏通行证，你也可以同样拥有！你还可以浏览“{userName2}”收藏的帽子、衬衫、装备等道具。";
	}

	protected override string _GetTemplateForDescriptionRoblox()
	{
		return "Roblox 正在开创新一代的娱乐方式，让数百万玩家都能在一个由用户生成的沉浸式 3D 世界中想象、创造、一同玩耍。";
	}

	/// <summary>
	/// Key: "Description.UserProfilePage"
	/// message when a user profile is shared on Social Media
	/// English String: "{userName1} is one of the millions playing, creating and exploring the endless possibilities of Roblox. Join {userName2} on Roblox and explore together!"
	/// </summary>
	public override string DescriptionUserProfilePage(string userName1, string userName2)
	{
		return $"在 Roblox 中玩游戏、创造并探索无限可能性的数百万用户之中，“{userName1}”也是其中一位。快来 Roblox 上加入“{userName2}”一同探索吧！";
	}

	protected override string _GetTemplateForDescriptionUserProfilePage()
	{
		return "在 Roblox 中玩游戏、创造并探索无限可能性的数百万用户之中，“{userName1}”也是其中一位。快来 Roblox 上加入“{userName2}”一同探索吧！";
	}

	protected override string _GetTemplateForLabelCatalogPage()
	{
		return "使用成千上万件服装、饰品、装备等物品来自定义你的虚拟形象！";
	}

	protected override string _GetTemplateForLabelCatalogPageTItle()
	{
		return "Roblox 商店";
	}

	protected override string _GetTemplateForLabelGamesPageTitle()
	{
		return "Roblox 游戏";
	}

	/// <summary>
	/// Key: "Label.UserProfile"
	/// title of the social meta tag
	/// English String: "{userName}'s Profile"
	/// </summary>
	public override string LabelUserProfile(string userName)
	{
		return $"“{userName}”的个人资料";
	}

	protected override string _GetTemplateForLabelUserProfile()
	{
		return "“{userName}”的个人资料";
	}
}
