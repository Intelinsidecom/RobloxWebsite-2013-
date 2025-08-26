namespace Roblox.Platform.TranslationResources.Feature {
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
	public override string DescriptionDevelopLanding => "ä½¿ç”¨ Roblox å…è²»è€Œèº«æ­·å…¶å¢ƒçš„å‰µä½œå¹³å°ï¼Œè®“æ‚¨å‰µä½œæ‚¨æ‰€æƒ³åƒçš„ä¸€åˆ‡ã€‚ç¾åœ¨å°±ä¾†é–‹å§‹å‰µä½œéŠæˆ²å§ï¼";

	/// <summary>
	/// Key: "Description.GamesPage"
	/// description shown when Games page is shared on Facebook or Twitter
	/// English String: "Play millions of free games on your smartphone, tablet, computer, Xbox One, Oculus Rift, and more."
	/// </summary>
	public override string DescriptionGamesPage => "åœ¨æ‚¨çš„æ™ºæ…§æ‰‹æ©Ÿã€å¹³æ¿é›»è…¦ã€é›»è…¦ã€Xbox Oneã€Oculus Rift ç­‰è£ç½®ç›¡æƒ…éŠçŽ©è¶…éŽä¸€ç™¾è¬æ¬¾éŠæˆ²ã€‚";

	/// <summary>
	/// Key: "Description.Roblox"
	/// description shown on Facebook or Twitter when Roblox landing page is shared
	/// English String: "Roblox is ushering in the next generation of entertainment. Imagine, create, and play together with millions of players across an infinite variety of immersive, user-generated 3D worlds."
	/// </summary>
	public override string DescriptionRoblox => "Roblox æ­£åœ¨é–‹å‰µå¨›æ¨‚çš„æ–°ä¸–ç´€ï¼›åœ¨ä¸€ç³»åˆ—çš„ä½¿ç”¨è€…å‰µä½œã€èº«æ­·å…¶å¢ƒçš„ 3D ä¸–ç•Œä¸­ï¼Œå’Œæ•¸ç™¾è¬åå®¶ç™¼æ®æƒ³åƒåŠ›ï¼Œä¸€èµ·å‰µé€ å’ŒåŒæ¨‚ã€‚";

	/// <summary>
	/// Key: "Label.CatalogPage"
	/// Description shown when the catalog page is shared on Facebook or Twitter
	/// English String: "Customize your avatar with a never-ending variety of clothing options, accessories, gear, and more!"
	/// </summary>
	public override string LabelCatalogPage => "ä»¥æˆåƒä¸Šè¬ç¨®æœè£ã€é£¾å“ã€è£å‚™ç­‰é“å…·è‡ªè¨‚æ‚¨çš„è™›æ“¬äººå¶ï¼";

	/// <summary>
	/// Key: "Label.CatalogPageTItle"
	/// title
	/// English String: "Roblox Catalog"
	/// </summary>
	public override string LabelCatalogPageTItle => "Roblox åž‹éŒ„";

	/// <summary>
	/// Key: "Label.GamesPageTitle"
	/// title for social meta tag fro games page
	/// English String: "Roblox Games"
	/// </summary>
	public override string LabelGamesPageTitle => "Roblox éŠæˆ²";

	public SocialMetaTagsResources_zh_tw(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForDescriptionDevelopLanding()
	{
		return "ä½¿ç”¨ Roblox å…è²»è€Œèº«æ­·å…¶å¢ƒçš„å‰µä½œå¹³å°ï¼Œè®“æ‚¨å‰µä½œæ‚¨æ‰€æƒ³åƒçš„ä¸€åˆ‡ã€‚ç¾åœ¨å°±ä¾†é–‹å§‹å‰µä½œéŠæˆ²å§ï¼";
	}

	/// <summary>
	/// Key: "Description.FavoritesPage"
	/// social meta tag
	/// English String: "Visit {userName}â€™s Favorites and see what they like. Browse through their favorite places, accessories, and a lot more. Also, find the favorite gear they use in games and get one for yourself!"
	/// </summary>
	public override string DescriptionFavoritesPage(string userName)
	{
		return $"çœ‹çœ‹ {userName} çš„æœ€æ„›ï¼Œç€è¦½ä»–å€‘æœ€å–œæ„›çš„ç©ºé–“ã€é£¾å“åŠå…¶å®ƒé …ç›®ã€‚æ‰¾æ‰¾çœ‹ä»–å€‘åœ¨éŠæˆ²ä¸­æœ€å¸¸ç”¨çš„è£å‚™ï¼Œè‡ªå·±ä¹Ÿä¾†è²·ä¸€ä»¶ï¼";
	}

	protected override string _GetTemplateForDescriptionFavoritesPage()
	{
		return "çœ‹çœ‹ {userName} çš„æœ€æ„›ï¼Œç€è¦½ä»–å€‘æœ€å–œæ„›çš„ç©ºé–“ã€é£¾å“åŠå…¶å®ƒé …ç›®ã€‚æ‰¾æ‰¾çœ‹ä»–å€‘åœ¨éŠæˆ²ä¸­æœ€å¸¸ç”¨çš„è£å‚™ï¼Œè‡ªå·±ä¹Ÿä¾†è²·ä¸€ä»¶ï¼";
	}

	/// <summary>
	/// Key: "Description.GamePage"
	/// The game description which shows on social media, when shared
	/// English String: "Check out {gameName}. Itâ€™s one of the millions of unique, user-generated 3D experiences created on Roblox. {gameDescription}"
	/// </summary>
	public override string DescriptionGamePage(string gameName, string gameDescription)
	{
		return $"çœ‹çœ‹ {gameName}ï¼ŒRoblox ä¸Šæ•¸ç™¾è¬ç¨®ç¨ä¸€ç„¡äºŒã€ä½¿ç”¨è€…å‰µä½œçš„ 3D é«”é©—ä¹‹ä¸€ã€‚{gameDescription}";
	}

	protected override string _GetTemplateForDescriptionGamePage()
	{
		return "çœ‹çœ‹ {gameName}ï¼ŒRoblox ä¸Šæ•¸ç™¾è¬ç¨®ç¨ä¸€ç„¡äºŒã€ä½¿ç”¨è€…å‰µä½œçš„ 3D é«”é©—ä¹‹ä¸€ã€‚{gameDescription}";
	}

	protected override string _GetTemplateForDescriptionGamesPage()
	{
		return "åœ¨æ‚¨çš„æ™ºæ…§æ‰‹æ©Ÿã€å¹³æ¿é›»è…¦ã€é›»è…¦ã€Xbox Oneã€Oculus Rift ç­‰è£ç½®ç›¡æƒ…éŠçŽ©è¶…éŽä¸€ç™¾è¬æ¬¾éŠæˆ²ã€‚";
	}

	/// <summary>
	/// Key: "Description.InventoryPage"
	/// social meta tag
	/// English String: "Visit {userName1}â€™s Inventory and see the cool items they have collected. Look out for their game passes and get one for yourself! Browse through {userName2}â€™s collection of hats, shirts, gear, and more."
	/// </summary>
	public override string DescriptionInventoryPage(string userName1, string userName2)
	{
		return $"å‰å¾€ {userName1} çš„é“å…·æ¬„ï¼Œçœ‹çœ‹å°æ–¹æ”¶è—çš„é…·ç‚«é“å…·ã€‚æ³¨æ„å°æ–¹æœ‰å“ªäº›éŠæˆ²é€šè¡Œè­‰ï¼Œè‡ªå·±ä¹Ÿä¾†ä¸€å¼µï¼æ­¡è¿Žä»”ç´°ç€è¦½ {userName2} çš„å¸½å­ã€ä¸Šè¡£ã€è£å‚™åŠå…¶å®ƒæ”¶è—ã€‚";
	}

	protected override string _GetTemplateForDescriptionInventoryPage()
	{
		return "å‰å¾€ {userName1} çš„é“å…·æ¬„ï¼Œçœ‹çœ‹å°æ–¹æ”¶è—çš„é…·ç‚«é“å…·ã€‚æ³¨æ„å°æ–¹æœ‰å“ªäº›éŠæˆ²é€šè¡Œè­‰ï¼Œè‡ªå·±ä¹Ÿä¾†ä¸€å¼µï¼æ­¡è¿Žä»”ç´°ç€è¦½ {userName2} çš„å¸½å­ã€ä¸Šè¡£ã€è£å‚™åŠå…¶å®ƒæ”¶è—ã€‚";
	}

	protected override string _GetTemplateForDescriptionRoblox()
	{
		return "Roblox æ­£åœ¨é–‹å‰µå¨›æ¨‚çš„æ–°ä¸–ç´€ï¼›åœ¨ä¸€ç³»åˆ—çš„ä½¿ç”¨è€…å‰µä½œã€èº«æ­·å…¶å¢ƒçš„ 3D ä¸–ç•Œä¸­ï¼Œå’Œæ•¸ç™¾è¬åå®¶ç™¼æ®æƒ³åƒåŠ›ï¼Œä¸€èµ·å‰µé€ å’ŒåŒæ¨‚ã€‚";
	}

	/// <summary>
	/// Key: "Description.UserProfilePage"
	/// message when a user profile is shared on Social Media
	/// English String: "{userName1} is one of the millions playing, creating and exploring the endless possibilities of Roblox. Join {userName2} on Roblox and explore together!"
	/// </summary>
	public override string DescriptionUserProfilePage(string userName1, string userName2)
	{
		return $"{userName1} æ­£åœ¨å’Œæ•¸ç™¾è¬å Roblox çŽ©å®¶ä¸€èµ·åŒæ¨‚ã€å‰µä½œã€æŽ¢ç´¢ã€‚åŠ å…¥ Robloxï¼Œå’Œ {userName2} ä¸€èµ·æŽ¢ç´¢å§ï¼";
	}

	protected override string _GetTemplateForDescriptionUserProfilePage()
	{
		return "{userName1} æ­£åœ¨å’Œæ•¸ç™¾è¬å Roblox çŽ©å®¶ä¸€èµ·åŒæ¨‚ã€å‰µä½œã€æŽ¢ç´¢ã€‚åŠ å…¥ Robloxï¼Œå’Œ {userName2} ä¸€èµ·æŽ¢ç´¢å§ï¼";
	}

	protected override string _GetTemplateForLabelCatalogPage()
	{
		return "ä»¥æˆåƒä¸Šè¬ç¨®æœè£ã€é£¾å“ã€è£å‚™ç­‰é“å…·è‡ªè¨‚æ‚¨çš„è™›æ“¬äººå¶ï¼";
	}

	protected override string _GetTemplateForLabelCatalogPageTItle()
	{
		return "Roblox åž‹éŒ„";
	}

	protected override string _GetTemplateForLabelGamesPageTitle()
	{
		return "Roblox éŠæˆ²";
	}

	/// <summary>
	/// Key: "Label.UserProfile"
	/// title of the social meta tag
	/// English String: "{userName}'s Profile"
	/// </summary>
	public override string LabelUserProfile(string userName)
	{
		return $"{userName} çš„å€‹äººæª”æ¡ˆ";
	}

	protected override string _GetTemplateForLabelUserProfile()
	{
		return "{userName} çš„å€‹äººæª”æ¡ˆ";
	}
}


}
