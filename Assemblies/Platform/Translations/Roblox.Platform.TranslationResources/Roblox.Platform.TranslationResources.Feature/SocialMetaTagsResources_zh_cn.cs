namespace Roblox.Platform.TranslationResources.Feature {
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
	public override string DescriptionDevelopLanding => "ä½¿ç”¨ Roblox å…è´¹çš„æ²‰æµ¸å¼åˆ›æ„å¼•æ“Žï¼Œåˆ›é€ ä½ èƒ½æƒ³è±¡çš„ä¸€åˆ‡ã€‚çŽ°åœ¨å°±å¼€å§‹åˆ›ä½œæ¸¸æˆå§ï¼";

	/// <summary>
	/// Key: "Description.GamesPage"
	/// description shown when Games page is shared on Facebook or Twitter
	/// English String: "Play millions of free games on your smartphone, tablet, computer, Xbox One, Oculus Rift, and more."
	/// </summary>
	public override string DescriptionGamesPage => "æ•°ç™¾ä¸‡æ¬¾å…è´¹æ¸¸æˆï¼Œåœ¨ä½ çš„æ™ºèƒ½æ‰‹æœºã€å¹³æ¿ç”µè„‘ã€ç”µè„‘ã€Xbox Oneã€Oculus Rift åŠæ›´å¤šè®¾å¤‡ä¸Šç•…çŽ©ã€‚";

	/// <summary>
	/// Key: "Description.Roblox"
	/// description shown on Facebook or Twitter when Roblox landing page is shared
	/// English String: "Roblox is ushering in the next generation of entertainment. Imagine, create, and play together with millions of players across an infinite variety of immersive, user-generated 3D worlds."
	/// </summary>
	public override string DescriptionRoblox => "Roblox æ­£åœ¨å¼€åˆ›æ–°ä¸€ä»£çš„å¨±ä¹æ–¹å¼ï¼Œè®©æ•°ç™¾ä¸‡çŽ©å®¶éƒ½èƒ½åœ¨ä¸€ä¸ªç”±ç”¨æˆ·ç”Ÿæˆçš„æ²‰æµ¸å¼ 3D ä¸–ç•Œä¸­æƒ³è±¡ã€åˆ›é€ ã€ä¸€åŒçŽ©è€ã€‚";

	/// <summary>
	/// Key: "Label.CatalogPage"
	/// Description shown when the catalog page is shared on Facebook or Twitter
	/// English String: "Customize your avatar with a never-ending variety of clothing options, accessories, gear, and more!"
	/// </summary>
	public override string LabelCatalogPage => "ä½¿ç”¨æˆåƒä¸Šä¸‡ä»¶æœè£…ã€é¥°å“ã€è£…å¤‡ç­‰ç‰©å“æ¥è‡ªå®šä¹‰ä½ çš„è™šæ‹Ÿå½¢è±¡ï¼";

	/// <summary>
	/// Key: "Label.CatalogPageTItle"
	/// title
	/// English String: "Roblox Catalog"
	/// </summary>
	public override string LabelCatalogPageTItle => "Roblox å•†åº—";

	/// <summary>
	/// Key: "Label.GamesPageTitle"
	/// title for social meta tag fro games page
	/// English String: "Roblox Games"
	/// </summary>
	public override string LabelGamesPageTitle => "Roblox æ¸¸æˆ";

	public SocialMetaTagsResources_zh_cn(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForDescriptionDevelopLanding()
	{
		return "ä½¿ç”¨ Roblox å…è´¹çš„æ²‰æµ¸å¼åˆ›æ„å¼•æ“Žï¼Œåˆ›é€ ä½ èƒ½æƒ³è±¡çš„ä¸€åˆ‡ã€‚çŽ°åœ¨å°±å¼€å§‹åˆ›ä½œæ¸¸æˆå§ï¼";
	}

	/// <summary>
	/// Key: "Description.FavoritesPage"
	/// social meta tag
	/// English String: "Visit {userName}â€™s Favorites and see what they like. Browse through their favorite places, accessories, and a lot more. Also, find the favorite gear they use in games and get one for yourself!"
	/// </summary>
	public override string DescriptionFavoritesPage(string userName)
	{
		return $"è¯·è®¿é—®â€œ{userName}â€çš„æœ€çˆ±ï¼Œçœ‹çœ‹ä»–ä»¬å–œæ¬¢ä»€ä¹ˆã€‚ä½ ä¹Ÿå¯ä»¥æµè§ˆä»–ä»¬æœ€å–œçˆ±çš„æ¸¸æˆåœºæ™¯ã€é¥°å“å’Œå…¶ä»–å†…å®¹ã€‚æ­¤å¤–ï¼Œä½ è¿˜èƒ½æ‰¾åˆ°ä»–ä»¬åœ¨æ¸¸æˆä¸­æœ€å¸¸ä½¿ç”¨çš„è£…å¤‡ï¼Œä½ åŒæ ·å¯ä»¥æ‹¥æœ‰ï¼";
	}

	protected override string _GetTemplateForDescriptionFavoritesPage()
	{
		return "è¯·è®¿é—®â€œ{userName}â€çš„æœ€çˆ±ï¼Œçœ‹çœ‹ä»–ä»¬å–œæ¬¢ä»€ä¹ˆã€‚ä½ ä¹Ÿå¯ä»¥æµè§ˆä»–ä»¬æœ€å–œçˆ±çš„æ¸¸æˆåœºæ™¯ã€é¥°å“å’Œå…¶ä»–å†…å®¹ã€‚æ­¤å¤–ï¼Œä½ è¿˜èƒ½æ‰¾åˆ°ä»–ä»¬åœ¨æ¸¸æˆä¸­æœ€å¸¸ä½¿ç”¨çš„è£…å¤‡ï¼Œä½ åŒæ ·å¯ä»¥æ‹¥æœ‰ï¼";
	}

	/// <summary>
	/// Key: "Description.GamePage"
	/// The game description which shows on social media, when shared
	/// English String: "Check out {gameName}. Itâ€™s one of the millions of unique, user-generated 3D experiences created on Roblox. {gameDescription}"
	/// </summary>
	public override string DescriptionGamePage(string gameName, string gameDescription)
	{
		return $"è¯·å‚è€ƒâ€œ{gameName}â€ï¼Œç»™ä½  Roblox ä¸Šæ•°ç™¾ä¸‡ç§ç‹¬ä¸€æ— äºŒï¼Œç”±ç”¨æˆ·åˆ›ä½œçš„ 3D ä½“éªŒã€‚{gameDescription}";
	}

	protected override string _GetTemplateForDescriptionGamePage()
	{
		return "è¯·å‚è€ƒâ€œ{gameName}â€ï¼Œç»™ä½  Roblox ä¸Šæ•°ç™¾ä¸‡ç§ç‹¬ä¸€æ— äºŒï¼Œç”±ç”¨æˆ·åˆ›ä½œçš„ 3D ä½“éªŒã€‚{gameDescription}";
	}

	protected override string _GetTemplateForDescriptionGamesPage()
	{
		return "æ•°ç™¾ä¸‡æ¬¾å…è´¹æ¸¸æˆï¼Œåœ¨ä½ çš„æ™ºèƒ½æ‰‹æœºã€å¹³æ¿ç”µè„‘ã€ç”µè„‘ã€Xbox Oneã€Oculus Rift åŠæ›´å¤šè®¾å¤‡ä¸Šç•…çŽ©ã€‚";
	}

	/// <summary>
	/// Key: "Description.InventoryPage"
	/// social meta tag
	/// English String: "Visit {userName1}â€™s Inventory and see the cool items they have collected. Look out for their game passes and get one for yourself! Browse through {userName2}â€™s collection of hats, shirts, gear, and more."
	/// </summary>
	public override string DescriptionInventoryPage(string userName1, string userName2)
	{
		return $"è¯·è®¿é—®â€œ{userName1}â€çš„é“å…·åº“ï¼ŒæŸ¥çœ‹ä»–ä»¬çš„é…·ç‚«æ”¶è—ã€‚çœ‹çœ‹ä»–ä»¬çš„æ¸¸æˆé€šè¡Œè¯ï¼Œä½ ä¹Ÿå¯ä»¥åŒæ ·æ‹¥æœ‰ï¼ä½ è¿˜å¯ä»¥æµè§ˆâ€œ{userName2}â€æ”¶è—çš„å¸½å­ã€è¡¬è¡«ã€è£…å¤‡ç­‰é“å…·ã€‚";
	}

	protected override string _GetTemplateForDescriptionInventoryPage()
	{
		return "è¯·è®¿é—®â€œ{userName1}â€çš„é“å…·åº“ï¼ŒæŸ¥çœ‹ä»–ä»¬çš„é…·ç‚«æ”¶è—ã€‚çœ‹çœ‹ä»–ä»¬çš„æ¸¸æˆé€šè¡Œè¯ï¼Œä½ ä¹Ÿå¯ä»¥åŒæ ·æ‹¥æœ‰ï¼ä½ è¿˜å¯ä»¥æµè§ˆâ€œ{userName2}â€æ”¶è—çš„å¸½å­ã€è¡¬è¡«ã€è£…å¤‡ç­‰é“å…·ã€‚";
	}

	protected override string _GetTemplateForDescriptionRoblox()
	{
		return "Roblox æ­£åœ¨å¼€åˆ›æ–°ä¸€ä»£çš„å¨±ä¹æ–¹å¼ï¼Œè®©æ•°ç™¾ä¸‡çŽ©å®¶éƒ½èƒ½åœ¨ä¸€ä¸ªç”±ç”¨æˆ·ç”Ÿæˆçš„æ²‰æµ¸å¼ 3D ä¸–ç•Œä¸­æƒ³è±¡ã€åˆ›é€ ã€ä¸€åŒçŽ©è€ã€‚";
	}

	/// <summary>
	/// Key: "Description.UserProfilePage"
	/// message when a user profile is shared on Social Media
	/// English String: "{userName1} is one of the millions playing, creating and exploring the endless possibilities of Roblox. Join {userName2} on Roblox and explore together!"
	/// </summary>
	public override string DescriptionUserProfilePage(string userName1, string userName2)
	{
		return $"åœ¨ Roblox ä¸­çŽ©æ¸¸æˆã€åˆ›é€ å¹¶æŽ¢ç´¢æ— é™å¯èƒ½æ€§çš„æ•°ç™¾ä¸‡ç”¨æˆ·ä¹‹ä¸­ï¼Œâ€œ{userName1}â€ä¹Ÿæ˜¯å…¶ä¸­ä¸€ä½ã€‚å¿«æ¥ Roblox ä¸ŠåŠ å…¥â€œ{userName2}â€ä¸€åŒæŽ¢ç´¢å§ï¼";
	}

	protected override string _GetTemplateForDescriptionUserProfilePage()
	{
		return "åœ¨ Roblox ä¸­çŽ©æ¸¸æˆã€åˆ›é€ å¹¶æŽ¢ç´¢æ— é™å¯èƒ½æ€§çš„æ•°ç™¾ä¸‡ç”¨æˆ·ä¹‹ä¸­ï¼Œâ€œ{userName1}â€ä¹Ÿæ˜¯å…¶ä¸­ä¸€ä½ã€‚å¿«æ¥ Roblox ä¸ŠåŠ å…¥â€œ{userName2}â€ä¸€åŒæŽ¢ç´¢å§ï¼";
	}

	protected override string _GetTemplateForLabelCatalogPage()
	{
		return "ä½¿ç”¨æˆåƒä¸Šä¸‡ä»¶æœè£…ã€é¥°å“ã€è£…å¤‡ç­‰ç‰©å“æ¥è‡ªå®šä¹‰ä½ çš„è™šæ‹Ÿå½¢è±¡ï¼";
	}

	protected override string _GetTemplateForLabelCatalogPageTItle()
	{
		return "Roblox å•†åº—";
	}

	protected override string _GetTemplateForLabelGamesPageTitle()
	{
		return "Roblox æ¸¸æˆ";
	}

	/// <summary>
	/// Key: "Label.UserProfile"
	/// title of the social meta tag
	/// English String: "{userName}'s Profile"
	/// </summary>
	public override string LabelUserProfile(string userName)
	{
		return $"â€œ{userName}â€çš„ä¸ªäººèµ„æ–™";
	}

	protected override string _GetTemplateForLabelUserProfile()
	{
		return "â€œ{userName}â€çš„ä¸ªäººèµ„æ–™";
	}
}


}
