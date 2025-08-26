namespace Roblox.Platform.TranslationResources.Feature {
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
	public override string DescriptionDevelopLanding => "Robloxê°€ ë¬´ë£Œë¡œ ì œê³µí•˜ëŠ” ëª°ìž…í˜• ìƒì„± ì—”ì§„ì„ ì‚¬ìš©í•´ ìƒìƒí•˜ëŠ” ëª¨ë“  ê²ƒì„ ë§Œë“¤ì–´ ë³¼ ìˆ˜ ìžˆì–´ìš”. ì§€ê¸ˆ ê²Œìž„ì„ ë§Œë“¤ì–´ë³´ì„¸ìš”!";

	/// <summary>
	/// Key: "Description.GamesPage"
	/// description shown when Games page is shared on Facebook or Twitter
	/// English String: "Play millions of free games on your smartphone, tablet, computer, Xbox One, Oculus Rift, and more."
	/// </summary>
	public override string DescriptionGamesPage => "ìŠ¤ë§ˆíŠ¸í°, íƒœë¸”ë¦¿, ì»´í“¨í„°, Xbox One, Oculus Rift ë“±ì—ì„œ ìˆ˜ë§Žì€ ê²Œìž„ì„ ë¬´ë£Œë¡œ í”Œë ˆì´í•˜ì„¸ìš”.";

	/// <summary>
	/// Key: "Description.Roblox"
	/// description shown on Facebook or Twitter when Roblox landing page is shared
	/// English String: "Roblox is ushering in the next generation of entertainment. Imagine, create, and play together with millions of players across an infinite variety of immersive, user-generated 3D worlds."
	/// </summary>
	public override string DescriptionRoblox => "RobloxëŠ” ì°¨ì„¸ëŒ€ ì—”í„°í…Œì¸ë¨¼íŠ¸ì˜ ì„ ë‘ ì£¼ìžìž…ë‹ˆë‹¤. ìˆ˜ë°±ë§Œ ëª…ì˜ í”Œë ˆì´ì–´ì™€ í•¨ê»˜ ë‹¤ì–‘í•˜ê³  í¥ë¯¸ì§„ì§„í•œ ì‚¬ìš©ìž ì œìž‘ 3D ì„¸ìƒì—ì„œ ìƒìƒì˜ ë‚˜ëž˜ë¥¼ íŽ¼ì¹˜ë©´ì„œ ê²Œìž„ì„ ê°œë°œí•˜ê³  ì¦ê²¨ë³´ì„¸ìš”. ";

	/// <summary>
	/// Key: "Label.CatalogPage"
	/// Description shown when the catalog page is shared on Facebook or Twitter
	/// English String: "Customize your avatar with a never-ending variety of clothing options, accessories, gear, and more!"
	/// </summary>
	public override string LabelCatalogPage => "ì…€ ìˆ˜ ì—†ì´ ë§Žì€ ë³µìž¥, ìž¥ì‹ êµ¬, ìž¥ë¹„ ë“±ìœ¼ë¡œ ë‚˜ë§Œì˜ ì•„ë°”íƒ€ë¥¼ ë§ˆìŒê» ê¾¸ë©°ë³´ì„¸ìš”!";

	/// <summary>
	/// Key: "Label.CatalogPageTItle"
	/// title
	/// English String: "Roblox Catalog"
	/// </summary>
	public override string LabelCatalogPageTItle => "Roblox ì¹´íƒˆë¡œê·¸";

	/// <summary>
	/// Key: "Label.GamesPageTitle"
	/// title for social meta tag fro games page
	/// English String: "Roblox Games"
	/// </summary>
	public override string LabelGamesPageTitle => "Roblox ê²Œìž„";

	public SocialMetaTagsResources_ko_kr(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForDescriptionDevelopLanding()
	{
		return "Robloxê°€ ë¬´ë£Œë¡œ ì œê³µí•˜ëŠ” ëª°ìž…í˜• ìƒì„± ì—”ì§„ì„ ì‚¬ìš©í•´ ìƒìƒí•˜ëŠ” ëª¨ë“  ê²ƒì„ ë§Œë“¤ì–´ ë³¼ ìˆ˜ ìžˆì–´ìš”. ì§€ê¸ˆ ê²Œìž„ì„ ë§Œë“¤ì–´ë³´ì„¸ìš”!";
	}

	/// <summary>
	/// Key: "Description.FavoritesPage"
	/// social meta tag
	/// English String: "Visit {userName}â€™s Favorites and see what they like. Browse through their favorite places, accessories, and a lot more. Also, find the favorite gear they use in games and get one for yourself!"
	/// </summary>
	public override string DescriptionFavoritesPage(string userName)
	{
		return $"{userName}ì˜ ì¦ê²¨ì°¾ê¸°ë¥¼ ë°©ë¬¸í•´ {userName}ë‹˜ì´ ì¢‹ì•„í•˜ëŠ” ìž¥ì†Œ, ìž¥ì‹ êµ¬ ë“± ë‹¤ì–‘í•œ ì•„ì´í…œì„ êµ¬ê²½í•´ë³´ì„¸ìš”. ë˜í•œ ì‚¬ìš©ìžê°€ ê²Œìž„ì—ì„œ ì¦ê²¨ ì‚¬ìš©í•˜ëŠ” ìž¥ë¹„ë¥¼ ì‚´íŽ´ë³´ê³  í•œ ë²ˆ êµ¬ìž…í•´ë³´ì„¸ìš”!";
	}

	protected override string _GetTemplateForDescriptionFavoritesPage()
	{
		return "{userName}ì˜ ì¦ê²¨ì°¾ê¸°ë¥¼ ë°©ë¬¸í•´ {userName}ë‹˜ì´ ì¢‹ì•„í•˜ëŠ” ìž¥ì†Œ, ìž¥ì‹ êµ¬ ë“± ë‹¤ì–‘í•œ ì•„ì´í…œì„ êµ¬ê²½í•´ë³´ì„¸ìš”. ë˜í•œ ì‚¬ìš©ìžê°€ ê²Œìž„ì—ì„œ ì¦ê²¨ ì‚¬ìš©í•˜ëŠ” ìž¥ë¹„ë¥¼ ì‚´íŽ´ë³´ê³  í•œ ë²ˆ êµ¬ìž…í•´ë³´ì„¸ìš”!";
	}

	/// <summary>
	/// Key: "Description.GamePage"
	/// The game description which shows on social media, when shared
	/// English String: "Check out {gameName}. Itâ€™s one of the millions of unique, user-generated 3D experiences created on Roblox. {gameDescription}"
	/// </summary>
	public override string DescriptionGamePage(string gameName, string gameDescription)
	{
		return $"Robloxì—ì„œ ì œìž‘ëœ ìˆ˜ë°±ë§Œ ê°œì˜  ì‚¬ìš©ìž ì œìž‘ 3D ì½˜í…ì¸  ì¤‘ í•˜ë‚˜ì¸ {gameName}ì„(ë¥¼) ì‚´íŽ´ë³´ì„¸ìš”. {gameDescription}";
	}

	protected override string _GetTemplateForDescriptionGamePage()
	{
		return "Robloxì—ì„œ ì œìž‘ëœ ìˆ˜ë°±ë§Œ ê°œì˜  ì‚¬ìš©ìž ì œìž‘ 3D ì½˜í…ì¸  ì¤‘ í•˜ë‚˜ì¸ {gameName}ì„(ë¥¼) ì‚´íŽ´ë³´ì„¸ìš”. {gameDescription}";
	}

	protected override string _GetTemplateForDescriptionGamesPage()
	{
		return "ìŠ¤ë§ˆíŠ¸í°, íƒœë¸”ë¦¿, ì»´í“¨í„°, Xbox One, Oculus Rift ë“±ì—ì„œ ìˆ˜ë§Žì€ ê²Œìž„ì„ ë¬´ë£Œë¡œ í”Œë ˆì´í•˜ì„¸ìš”.";
	}

	/// <summary>
	/// Key: "Description.InventoryPage"
	/// social meta tag
	/// English String: "Visit {userName1}â€™s Inventory and see the cool items they have collected. Look out for their game passes and get one for yourself! Browse through {userName2}â€™s collection of hats, shirts, gear, and more."
	/// </summary>
	public override string DescriptionInventoryPage(string userName1, string userName2)
	{
		return $"{userName1}ë‹˜ì˜ ì¸ë²¤í† ë¦¬ë¥¼ ë°©ë¬¸í•´ ë©‹ì§„ ìˆ˜ì§‘ ì•„ì´í…œì„ êµ¬ê²½í•´ë³´ì„¸ìš”. ê²Œìž„íŒ¨ìŠ¤ë„ ì‚´íŽ´ë³´ê³  í•œ ë²ˆ êµ¬ìž…í•´ë³´ì„¸ìš”! {userName2}ë‹˜ì˜ ëª¨ìž, ì…”ì¸ , ìž¥ë¹„ ë“±ì˜ ì»¬ë ‰ì…˜ì„ êµ¬ê²½í•˜ì„¸ìš”.";
	}

	protected override string _GetTemplateForDescriptionInventoryPage()
	{
		return "{userName1}ë‹˜ì˜ ì¸ë²¤í† ë¦¬ë¥¼ ë°©ë¬¸í•´ ë©‹ì§„ ìˆ˜ì§‘ ì•„ì´í…œì„ êµ¬ê²½í•´ë³´ì„¸ìš”. ê²Œìž„íŒ¨ìŠ¤ë„ ì‚´íŽ´ë³´ê³  í•œ ë²ˆ êµ¬ìž…í•´ë³´ì„¸ìš”! {userName2}ë‹˜ì˜ ëª¨ìž, ì…”ì¸ , ìž¥ë¹„ ë“±ì˜ ì»¬ë ‰ì…˜ì„ êµ¬ê²½í•˜ì„¸ìš”.";
	}

	protected override string _GetTemplateForDescriptionRoblox()
	{
		return "RobloxëŠ” ì°¨ì„¸ëŒ€ ì—”í„°í…Œì¸ë¨¼íŠ¸ì˜ ì„ ë‘ ì£¼ìžìž…ë‹ˆë‹¤. ìˆ˜ë°±ë§Œ ëª…ì˜ í”Œë ˆì´ì–´ì™€ í•¨ê»˜ ë‹¤ì–‘í•˜ê³  í¥ë¯¸ì§„ì§„í•œ ì‚¬ìš©ìž ì œìž‘ 3D ì„¸ìƒì—ì„œ ìƒìƒì˜ ë‚˜ëž˜ë¥¼ íŽ¼ì¹˜ë©´ì„œ ê²Œìž„ì„ ê°œë°œí•˜ê³  ì¦ê²¨ë³´ì„¸ìš”. ";
	}

	/// <summary>
	/// Key: "Description.UserProfilePage"
	/// message when a user profile is shared on Social Media
	/// English String: "{userName1} is one of the millions playing, creating and exploring the endless possibilities of Roblox. Join {userName2} on Roblox and explore together!"
	/// </summary>
	public override string DescriptionUserProfilePage(string userName1, string userName2)
	{
		return $"{userName1}ë‹˜ì€ ë¬´í•œí•œ ê°€ëŠ¥ì„±ìœ¼ë¡œ ê°€ë“í•œ Roblox ì„¸ìƒì„ ì¦ê¸°ê³  íƒí—˜í•˜ë©° ì½˜í…ì¸ ë¥¼ ë§Œë“œëŠ” ë§Žì€ ì‚¬ìš©ìž ì¤‘ í•˜ë‚˜ì˜ˆìš”. Robloxì—ì„œ {userName2}ë‹˜ê³¼ í•¨ê»˜í•˜ì„¸ìš”!";
	}

	protected override string _GetTemplateForDescriptionUserProfilePage()
	{
		return "{userName1}ë‹˜ì€ ë¬´í•œí•œ ê°€ëŠ¥ì„±ìœ¼ë¡œ ê°€ë“í•œ Roblox ì„¸ìƒì„ ì¦ê¸°ê³  íƒí—˜í•˜ë©° ì½˜í…ì¸ ë¥¼ ë§Œë“œëŠ” ë§Žì€ ì‚¬ìš©ìž ì¤‘ í•˜ë‚˜ì˜ˆìš”. Robloxì—ì„œ {userName2}ë‹˜ê³¼ í•¨ê»˜í•˜ì„¸ìš”!";
	}

	protected override string _GetTemplateForLabelCatalogPage()
	{
		return "ì…€ ìˆ˜ ì—†ì´ ë§Žì€ ë³µìž¥, ìž¥ì‹ êµ¬, ìž¥ë¹„ ë“±ìœ¼ë¡œ ë‚˜ë§Œì˜ ì•„ë°”íƒ€ë¥¼ ë§ˆìŒê» ê¾¸ë©°ë³´ì„¸ìš”!";
	}

	protected override string _GetTemplateForLabelCatalogPageTItle()
	{
		return "Roblox ì¹´íƒˆë¡œê·¸";
	}

	protected override string _GetTemplateForLabelGamesPageTitle()
	{
		return "Roblox ê²Œìž„";
	}

	/// <summary>
	/// Key: "Label.UserProfile"
	/// title of the social meta tag
	/// English String: "{userName}'s Profile"
	/// </summary>
	public override string LabelUserProfile(string userName)
	{
		return $"{userName}ë‹˜ì˜ í”„ë¡œí•„";
	}

	protected override string _GetTemplateForLabelUserProfile()
	{
		return "{userName}ë‹˜ì˜ í”„ë¡œí•„";
	}
}


}
