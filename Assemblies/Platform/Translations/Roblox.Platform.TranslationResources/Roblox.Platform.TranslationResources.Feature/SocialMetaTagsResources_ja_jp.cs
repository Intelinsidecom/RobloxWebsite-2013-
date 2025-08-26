namespace Roblox.Platform.TranslationResources.Feature {
    /// <summary>

/// This class overrides SocialMetaTagsResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class SocialMetaTagsResources_ja_jp : SocialMetaTagsResources_en_us, ISocialMetaTagsResources, ITranslationResources
{
	/// <summary>
	/// Key: "Description.DevelopLanding"
	/// description shown on Facebook or Twitter when shared
	/// English String: "Create anything you can imagine with Roblox's free and immersive creation engine. Start creating games today!"
	/// </summary>
	public override string DescriptionDevelopLanding => "Robloxã®ç„¡æ–™ã®æ²¡å…¥åž‹ã‚³ãƒ³ãƒ†ãƒ³ãƒ„åˆ¶ä½œã‚¨ãƒ³ã‚¸ãƒ³ã‚’ä½¿ã£ã¦ã€ã‚¤ãƒžã‚¸ãƒãƒ¼ã‚·ãƒ§ãƒ³ã‚’å½¢ã«ã—ã¾ã—ã‚‡ã†ã€‚ä»Šã™ãã‚²ãƒ¼ãƒ åˆ¶ä½œã‚’å§‹ã‚ã¦ã¿ã¦ãã ã•ã„ï¼";

	/// <summary>
	/// Key: "Description.GamesPage"
	/// description shown when Games page is shared on Facebook or Twitter
	/// English String: "Play millions of free games on your smartphone, tablet, computer, Xbox One, Oculus Rift, and more."
	/// </summary>
	public override string DescriptionGamesPage => "ã‚¹ãƒžãƒ¼ãƒˆãƒ•ã‚©ãƒ³ã€ã‚¿ãƒ–ãƒ¬ãƒƒãƒˆã€ãƒ‘ã‚½ã‚³ãƒ³ã€Xbox Oneã€Oculus Riftãªã©ã§ã€æ•°ç™¾ä¸‡ç¨®é¡žã®ç„¡æ–™ã‚²ãƒ¼ãƒ ã‚’ãƒ—ãƒ¬ã‚¤ã—ã‚ˆã†ã€‚";

	/// <summary>
	/// Key: "Description.Roblox"
	/// description shown on Facebook or Twitter when Roblox landing page is shared
	/// English String: "Roblox is ushering in the next generation of entertainment. Imagine, create, and play together with millions of players across an infinite variety of immersive, user-generated 3D worlds."
	/// </summary>
	public override string DescriptionRoblox => "Robloxã¯ã€æ¬¡ä¸–ä»£ã®ã‚¨ãƒ³ã‚¿ãƒ¼ãƒ†ã‚¤ãƒ¡ãƒ³ãƒˆã¸ã¨çš†ã•ã‚“ã‚’ã”æ¡ˆå†…ã—ã¾ã™ã€‚ãƒ¦ãƒ¼ã‚¶ãƒ¼ãŒä½œã£ãŸé›°å›²æ°—æŠœç¾¤ã®ç„¡é™ã®3Dãƒ¯ãƒ¼ãƒ«ãƒ‰ã§ã€æ•°ç™¾ä¸‡äººã®ãƒ—ãƒ¬ã‚¤ãƒ¤ãƒ¼ãŸã¡ã¨ä¸€ç·’ã«ã‚¤ãƒžã‚¸ãƒãƒ¼ã‚·ãƒ§ãƒ³ã‚’è†¨ã‚‰ã¾ã›ã¦ã€åˆ¶ä½œã‚„ãƒ—ãƒ¬ã‚¤ã‚’ä½“é¨“ã—ã¦ãã ã•ã„ã€‚";

	/// <summary>
	/// Key: "Label.CatalogPage"
	/// Description shown when the catalog page is shared on Facebook or Twitter
	/// English String: "Customize your avatar with a never-ending variety of clothing options, accessories, gear, and more!"
	/// </summary>
	public override string LabelCatalogPage => "ç„¡é™ã®ãƒãƒªã‚¨ãƒ¼ã‚·ãƒ§ãƒ³ãŒç”¨æ„ã•ã‚ŒãŸã‚³ã‚¹ãƒãƒ¥ãƒ¼ãƒ ã€ã‚¢ã‚¯ã‚»ã‚µãƒªã€ã‚®ã‚¢ãªã©ã§ã‚¢ãƒã‚¿ãƒ¼ã‚’ã‚«ã‚¹ã‚¿ãƒžã‚¤ã‚ºã—ã‚ˆã†ï¼";

	/// <summary>
	/// Key: "Label.CatalogPageTItle"
	/// title
	/// English String: "Roblox Catalog"
	/// </summary>
	public override string LabelCatalogPageTItle => "Robloxã‚«ã‚¿ãƒ­ã‚°";

	/// <summary>
	/// Key: "Label.GamesPageTitle"
	/// title for social meta tag fro games page
	/// English String: "Roblox Games"
	/// </summary>
	public override string LabelGamesPageTitle => "Robloxã‚²ãƒ¼ãƒ ";

	public SocialMetaTagsResources_ja_jp(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForDescriptionDevelopLanding()
	{
		return "Robloxã®ç„¡æ–™ã®æ²¡å…¥åž‹ã‚³ãƒ³ãƒ†ãƒ³ãƒ„åˆ¶ä½œã‚¨ãƒ³ã‚¸ãƒ³ã‚’ä½¿ã£ã¦ã€ã‚¤ãƒžã‚¸ãƒãƒ¼ã‚·ãƒ§ãƒ³ã‚’å½¢ã«ã—ã¾ã—ã‚‡ã†ã€‚ä»Šã™ãã‚²ãƒ¼ãƒ åˆ¶ä½œã‚’å§‹ã‚ã¦ã¿ã¦ãã ã•ã„ï¼";
	}

	/// <summary>
	/// Key: "Description.FavoritesPage"
	/// social meta tag
	/// English String: "Visit {userName}â€™s Favorites and see what they like. Browse through their favorite places, accessories, and a lot more. Also, find the favorite gear they use in games and get one for yourself!"
	/// </summary>
	public override string DescriptionFavoritesPage(string userName)
	{
		return $"{userName}ã•ã‚“ã®ãŠæ°—ã«å…¥ã‚Šã«ã‚¢ã‚¯ã‚»ã‚¹ã—ã¦ã€ã©ã‚“ãªè¶£å‘³ã‚’ã—ã¦ã„ã‚‹ã®ã‹è¦‹ã¦ã¿ã¾ã—ã‚‡ã†ã€‚ãŠæ°—ã«å…¥ã‚Šã®ãƒ—ãƒ¬ãƒ¼ã‚¹ã‚„ã‚¢ã‚¯ã‚»ã‚µãƒªãªã©ã‚‚ãƒã‚§ãƒƒã‚¯ã—ã¾ã—ã‚‡ã†ã€‚ã‚‚ã—ã‚²ãƒ¼ãƒ å†…ã§ä½¿ã£ã¦ã„ã‚‹ãŠæ°—ã«å…¥ã‚Šã‚®ã‚¢ãŒæ°—ã«å…¥ã£ãŸã‚‰ã€è‡ªåˆ†ã§ã‚‚æ‰‹ã«å…¥ã‚Œã¾ã—ã‚‡ã†ï¼";
	}

	protected override string _GetTemplateForDescriptionFavoritesPage()
	{
		return "{userName}ã•ã‚“ã®ãŠæ°—ã«å…¥ã‚Šã«ã‚¢ã‚¯ã‚»ã‚¹ã—ã¦ã€ã©ã‚“ãªè¶£å‘³ã‚’ã—ã¦ã„ã‚‹ã®ã‹è¦‹ã¦ã¿ã¾ã—ã‚‡ã†ã€‚ãŠæ°—ã«å…¥ã‚Šã®ãƒ—ãƒ¬ãƒ¼ã‚¹ã‚„ã‚¢ã‚¯ã‚»ã‚µãƒªãªã©ã‚‚ãƒã‚§ãƒƒã‚¯ã—ã¾ã—ã‚‡ã†ã€‚ã‚‚ã—ã‚²ãƒ¼ãƒ å†…ã§ä½¿ã£ã¦ã„ã‚‹ãŠæ°—ã«å…¥ã‚Šã‚®ã‚¢ãŒæ°—ã«å…¥ã£ãŸã‚‰ã€è‡ªåˆ†ã§ã‚‚æ‰‹ã«å…¥ã‚Œã¾ã—ã‚‡ã†ï¼";
	}

	/// <summary>
	/// Key: "Description.GamePage"
	/// The game description which shows on social media, when shared
	/// English String: "Check out {gameName}. Itâ€™s one of the millions of unique, user-generated 3D experiences created on Roblox. {gameDescription}"
	/// </summary>
	public override string DescriptionGamePage(string gameName, string gameDescription)
	{
		return $"{gameName}ã‚’ãƒã‚§ãƒƒã‚¯ã—ã‚ˆã†ã€‚ã“ã‚Œã¯ã€æ•°ç™¾ä¸‡ç¨®é¡žã«åŠã¶ã€Robloxã§ãƒ¦ãƒ¼ã‚¶ãƒ¼ãŒä½œæˆã—ãŸãƒ¦ãƒ‹ãƒ¼ã‚¯ãª3Dã‚³ãƒ³ãƒ†ãƒ³ãƒ„ã®ä¸€ã¤ã§ã™ã€‚{gameDescription}";
	}

	protected override string _GetTemplateForDescriptionGamePage()
	{
		return "{gameName}ã‚’ãƒã‚§ãƒƒã‚¯ã—ã‚ˆã†ã€‚ã“ã‚Œã¯ã€æ•°ç™¾ä¸‡ç¨®é¡žã«åŠã¶ã€Robloxã§ãƒ¦ãƒ¼ã‚¶ãƒ¼ãŒä½œæˆã—ãŸãƒ¦ãƒ‹ãƒ¼ã‚¯ãª3Dã‚³ãƒ³ãƒ†ãƒ³ãƒ„ã®ä¸€ã¤ã§ã™ã€‚{gameDescription}";
	}

	protected override string _GetTemplateForDescriptionGamesPage()
	{
		return "ã‚¹ãƒžãƒ¼ãƒˆãƒ•ã‚©ãƒ³ã€ã‚¿ãƒ–ãƒ¬ãƒƒãƒˆã€ãƒ‘ã‚½ã‚³ãƒ³ã€Xbox Oneã€Oculus Riftãªã©ã§ã€æ•°ç™¾ä¸‡ç¨®é¡žã®ç„¡æ–™ã‚²ãƒ¼ãƒ ã‚’ãƒ—ãƒ¬ã‚¤ã—ã‚ˆã†ã€‚";
	}

	/// <summary>
	/// Key: "Description.InventoryPage"
	/// social meta tag
	/// English String: "Visit {userName1}â€™s Inventory and see the cool items they have collected. Look out for their game passes and get one for yourself! Browse through {userName2}â€™s collection of hats, shirts, gear, and more."
	/// </summary>
	public override string DescriptionInventoryPage(string userName1, string userName2)
	{
		return $"{userName1}ã•ã‚“ã®ã‚¤ãƒ³ãƒ™ãƒ³ãƒˆãƒªã«ã‚¢ã‚¯ã‚»ã‚¹ã—ã¦ã€ã‚³ãƒ¬ã‚¯ã‚·ãƒ§ãƒ³ã—ã¦ã„ã‚‹ã‚¯ãƒ¼ãƒ«ãªã‚¢ã‚¤ãƒ†ãƒ ã‚’ãƒã‚§ãƒƒã‚¯ã—ã¾ã—ã‚‡ã†ã€‚ã‚²ãƒ¼ãƒ ãƒ‘ã‚¹ã‚’ç¢ºèªã—ã¦ã€è‡ªåˆ†ã§ã‚‚æ‰‹ã«å…¥ã‚Œã¾ã—ã‚‡ã†ï¼{userName2}ã•ã‚“ã®å¸½å­ã€ã‚·ãƒ£ãƒ„ã€ã‚®ã‚¢ãªã©ã‚‚ãƒã‚§ãƒƒã‚¯ã—ã¦ã¿ã¦ãã ã•ã„ã€‚";
	}

	protected override string _GetTemplateForDescriptionInventoryPage()
	{
		return "{userName1}ã•ã‚“ã®ã‚¤ãƒ³ãƒ™ãƒ³ãƒˆãƒªã«ã‚¢ã‚¯ã‚»ã‚¹ã—ã¦ã€ã‚³ãƒ¬ã‚¯ã‚·ãƒ§ãƒ³ã—ã¦ã„ã‚‹ã‚¯ãƒ¼ãƒ«ãªã‚¢ã‚¤ãƒ†ãƒ ã‚’ãƒã‚§ãƒƒã‚¯ã—ã¾ã—ã‚‡ã†ã€‚ã‚²ãƒ¼ãƒ ãƒ‘ã‚¹ã‚’ç¢ºèªã—ã¦ã€è‡ªåˆ†ã§ã‚‚æ‰‹ã«å…¥ã‚Œã¾ã—ã‚‡ã†ï¼{userName2}ã•ã‚“ã®å¸½å­ã€ã‚·ãƒ£ãƒ„ã€ã‚®ã‚¢ãªã©ã‚‚ãƒã‚§ãƒƒã‚¯ã—ã¦ã¿ã¦ãã ã•ã„ã€‚";
	}

	protected override string _GetTemplateForDescriptionRoblox()
	{
		return "Robloxã¯ã€æ¬¡ä¸–ä»£ã®ã‚¨ãƒ³ã‚¿ãƒ¼ãƒ†ã‚¤ãƒ¡ãƒ³ãƒˆã¸ã¨çš†ã•ã‚“ã‚’ã”æ¡ˆå†…ã—ã¾ã™ã€‚ãƒ¦ãƒ¼ã‚¶ãƒ¼ãŒä½œã£ãŸé›°å›²æ°—æŠœç¾¤ã®ç„¡é™ã®3Dãƒ¯ãƒ¼ãƒ«ãƒ‰ã§ã€æ•°ç™¾ä¸‡äººã®ãƒ—ãƒ¬ã‚¤ãƒ¤ãƒ¼ãŸã¡ã¨ä¸€ç·’ã«ã‚¤ãƒžã‚¸ãƒãƒ¼ã‚·ãƒ§ãƒ³ã‚’è†¨ã‚‰ã¾ã›ã¦ã€åˆ¶ä½œã‚„ãƒ—ãƒ¬ã‚¤ã‚’ä½“é¨“ã—ã¦ãã ã•ã„ã€‚";
	}

	/// <summary>
	/// Key: "Description.UserProfilePage"
	/// message when a user profile is shared on Social Media
	/// English String: "{userName1} is one of the millions playing, creating and exploring the endless possibilities of Roblox. Join {userName2} on Roblox and explore together!"
	/// </summary>
	public override string DescriptionUserProfilePage(string userName1, string userName2)
	{
		return $"{userName1} ã•ã‚“ã¯ã€Robloxã§åˆ¶ä½œã‚„ãƒ—ãƒ¬ã‚¤ã‚’ã—ãªãŒã‚‰ç„¡é™ã®å¯èƒ½æ€§ã‚’è¿½æ±‚ã—ã¦ã„ã‚‹æ•°ç™¾ä¸‡äººã®ã†ã¡ã®ä¸€äººã§ã™ã€‚Robloxã§ {userName2} ã•ã‚“ã¨ä¸€ç·’ã«å¯èƒ½æ€§ã‚’è¿½æ±‚ã—ã‚ˆã†ï¼";
	}

	protected override string _GetTemplateForDescriptionUserProfilePage()
	{
		return "{userName1} ã•ã‚“ã¯ã€Robloxã§åˆ¶ä½œã‚„ãƒ—ãƒ¬ã‚¤ã‚’ã—ãªãŒã‚‰ç„¡é™ã®å¯èƒ½æ€§ã‚’è¿½æ±‚ã—ã¦ã„ã‚‹æ•°ç™¾ä¸‡äººã®ã†ã¡ã®ä¸€äººã§ã™ã€‚Robloxã§ {userName2} ã•ã‚“ã¨ä¸€ç·’ã«å¯èƒ½æ€§ã‚’è¿½æ±‚ã—ã‚ˆã†ï¼";
	}

	protected override string _GetTemplateForLabelCatalogPage()
	{
		return "ç„¡é™ã®ãƒãƒªã‚¨ãƒ¼ã‚·ãƒ§ãƒ³ãŒç”¨æ„ã•ã‚ŒãŸã‚³ã‚¹ãƒãƒ¥ãƒ¼ãƒ ã€ã‚¢ã‚¯ã‚»ã‚µãƒªã€ã‚®ã‚¢ãªã©ã§ã‚¢ãƒã‚¿ãƒ¼ã‚’ã‚«ã‚¹ã‚¿ãƒžã‚¤ã‚ºã—ã‚ˆã†ï¼";
	}

	protected override string _GetTemplateForLabelCatalogPageTItle()
	{
		return "Robloxã‚«ã‚¿ãƒ­ã‚°";
	}

	protected override string _GetTemplateForLabelGamesPageTitle()
	{
		return "Robloxã‚²ãƒ¼ãƒ ";
	}

	/// <summary>
	/// Key: "Label.UserProfile"
	/// title of the social meta tag
	/// English String: "{userName}'s Profile"
	/// </summary>
	public override string LabelUserProfile(string userName)
	{
		return $"{userName}ã•ã‚“ã®ãƒ—ãƒ­ãƒ•ã‚£ãƒ¼ãƒ«";
	}

	protected override string _GetTemplateForLabelUserProfile()
	{
		return "{userName}ã•ã‚“ã®ãƒ—ãƒ­ãƒ•ã‚£ãƒ¼ãƒ«";
	}
}


}
