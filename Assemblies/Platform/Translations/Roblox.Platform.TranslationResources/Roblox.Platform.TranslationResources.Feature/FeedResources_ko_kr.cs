namespace Roblox.Platform.TranslationResources.Feature {
    /// <summary>

/// This class overrides FeedResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class FeedResources_ko_kr : FeedResources_en_us, IFeedResources, ITranslationResources
{
	/// <summary>
	/// Key: "HeadingBuildSomething"
	/// English String: "Build Something"
	/// </summary>
	public override string HeadingBuildSomething => "ë§Œë“¤ì–´ ë³´ê¸°";

	/// <summary>
	/// Key: "HeadingCustomizeAvatar"
	/// English String: "Customize Your Avatar"
	/// </summary>
	public override string HeadingCustomizeAvatar => "ì•„ë°”íƒ€ ê¾¸ë¯¸ê¸°";

	/// <summary>
	/// Key: "HeadingForumHelp"
	/// English String: "Roblox forums for help"
	/// </summary>
	public override string HeadingForumHelp => "Roblox í¬ëŸ¼ì—ì„œ ë„ì›€ ì–»ê¸°";

	/// <summary>
	/// Key: "HeadingMakeFriends"
	/// English String: "Make Friends"
	/// </summary>
	public override string HeadingMakeFriends => "ì¹œêµ¬ ì‚¬ê·€ê¸°";

	/// <summary>
	/// Key: "HeadingPlayGames"
	/// English String: "Play Games"
	/// </summary>
	public override string HeadingPlayGames => "ê²Œìž„ í”Œë ˆì´";

	/// <summary>
	/// Key: "LabelNoFeedLink"
	/// English String: "make some best friends now."
	/// </summary>
	public override string LabelNoFeedLink => "ì§€ê¸ˆ ë°”ë¡œ ë² ìŠ¤íŠ¸ í”„ë Œë“œë¥¼ ì‚¬ê·€ì–´ë³´ì„¸ìš”.";

	/// <summary>
	/// Key: "LabelNoFeedText"
	/// English String: "No news about your best friends... want to know what your best friends are up to?"
	/// </summary>
	public override string LabelNoFeedText => "ë² ìŠ¤íŠ¸ í”„ë Œë“œì— ê´€í•œ ìƒˆì†Œì‹ì´ ì—†ë„¤ìš”... ë² ìŠ¤íŠ¸ í”„ë Œë“œ ì†Œì‹ì´ ê¶ê¸ˆí•˜ì„¸ìš”?";

	/// <summary>
	/// Key: "LabelPlayGames"
	/// English String: "Nearly all Roblox games are built by players like you. Here are some of our favorites:"
	/// </summary>
	public override string LabelPlayGames => "ì—¬ëŸ¬ë¶„ê³¼ ê°™ì€ í”Œë ˆì´ì–´ë“¤ì´ Robloxì˜ ê²Œìž„ ëŒ€ë¶€ë¶„ì„ ë§Œë“ ë‹µë‹ˆë‹¤. ìž¬ë¯¸ë‚œ ê²Œìž„ ëª‡ ê°€ì§€ë¥¼ êµ¬ê²½í•´ë³´ì„¸ìš”.";

	public FeedResources_ko_kr(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForHeadingBuildSomething()
	{
		return "ë§Œë“¤ì–´ ë³´ê¸°";
	}

	protected override string _GetTemplateForHeadingCustomizeAvatar()
	{
		return "ì•„ë°”íƒ€ ê¾¸ë¯¸ê¸°";
	}

	protected override string _GetTemplateForHeadingForumHelp()
	{
		return "Roblox í¬ëŸ¼ì—ì„œ ë„ì›€ ì–»ê¸°";
	}

	protected override string _GetTemplateForHeadingMakeFriends()
	{
		return "ì¹œêµ¬ ì‚¬ê·€ê¸°";
	}

	protected override string _GetTemplateForHeadingPlayGames()
	{
		return "ê²Œìž„ í”Œë ˆì´";
	}

	/// <summary>
	/// Key: "LabelBuildSomething"
	/// English String: "Builders will enjoy playing our multiplayer building game. Professional builders will want to check out Roblox Studio, our game development environment on your {linkStart}Develop page{linkEnd}."
	/// </summary>
	public override string LabelBuildSomething(string linkStart, string linkEnd)
	{
		return $"Robloxì—ëŠ” ìž¬ë¯¸ë‚œ ë©€í‹°í”Œë ˆì´ì–´ ê±´ì„¤ ê²Œìž„ì´ ê°€ë“í•˜ì£ . ì§ì ‘ ê²Œìž„ì„ ë§Œë“¤ê³  ì‹¶ë‚˜ìš”? {linkStart}ê°œë°œ íŽ˜ì´ì§€{linkEnd}ì—ì„œ Robloxì˜ ê²Œìž„ ê°œë°œ í™˜ê²½ì¸ Roblox Studioë¥¼ ì‚´íŽ´ë³´ì„¸ìš”.";
	}

	protected override string _GetTemplateForLabelBuildSomething()
	{
		return "Robloxì—ëŠ” ìž¬ë¯¸ë‚œ ë©€í‹°í”Œë ˆì´ì–´ ê±´ì„¤ ê²Œìž„ì´ ê°€ë“í•˜ì£ . ì§ì ‘ ê²Œìž„ì„ ë§Œë“¤ê³  ì‹¶ë‚˜ìš”? {linkStart}ê°œë°œ íŽ˜ì´ì§€{linkEnd}ì—ì„œ Robloxì˜ ê²Œìž„ ê°œë°œ í™˜ê²½ì¸ Roblox Studioë¥¼ ì‚´íŽ´ë³´ì„¸ìš”.";
	}

	/// <summary>
	/// Key: "LabelCustomizeAvatarDesktop"
	/// English String: "Visit the {avatarLinkStart} Avatar page {avatarLinkEnd} to customize your avatar. Get new clothing in the {catalogLinkStart}catalog{catalogLinkEnd}."
	/// </summary>
	public override string LabelCustomizeAvatarDesktop(string avatarLinkStart, string avatarLinkEnd, string catalogLinkStart, string catalogLinkEnd)
	{
		return $"{avatarLinkStart}ì•„ë°”íƒ€{avatarLinkEnd} íŽ˜ì´ì§€ë¥¼ ë°©ë¬¸í•˜ì—¬ ì•„ë°”íƒ€ë¥¼ ë§ˆìŒê» ê¾¸ë©°ë³´ì„¸ìš”. ìƒˆ ë³µìž¥ì€ {catalogLinkStart}ì¹´íƒˆë¡œê·¸{catalogLinkEnd} íŽ˜ì´ì§€ì—ì„œ êµ¬ìž…í•˜ì‹¤ ìˆ˜ ìžˆì–´ìš”.";
	}

	protected override string _GetTemplateForLabelCustomizeAvatarDesktop()
	{
		return "{avatarLinkStart}ì•„ë°”íƒ€{avatarLinkEnd} íŽ˜ì´ì§€ë¥¼ ë°©ë¬¸í•˜ì—¬ ì•„ë°”íƒ€ë¥¼ ë§ˆìŒê» ê¾¸ë©°ë³´ì„¸ìš”. ìƒˆ ë³µìž¥ì€ {catalogLinkStart}ì¹´íƒˆë¡œê·¸{catalogLinkEnd} íŽ˜ì´ì§€ì—ì„œ êµ¬ìž…í•˜ì‹¤ ìˆ˜ ìžˆì–´ìš”.";
	}

	/// <summary>
	/// Key: "LabelCustomizeAvatarPhone"
	/// English String: "Get new clothing in the {linkStart} catalog {linkEnd} and customize your avatar."
	/// </summary>
	public override string LabelCustomizeAvatarPhone(string linkStart, string linkEnd)
	{
		return $"{linkStart}ì¹´íƒˆë¡œê·¸{linkEnd}ì—ì„œ ìƒˆ ë³µìž¥ì„ êµ¬ë§¤í•˜ì—¬ ì•„ë°”íƒ€ë¥¼ ë§ˆìŒê» ê¾¸ë©°ë³´ì„¸ìš”.";
	}

	protected override string _GetTemplateForLabelCustomizeAvatarPhone()
	{
		return "{linkStart}ì¹´íƒˆë¡œê·¸{linkEnd}ì—ì„œ ìƒˆ ë³µìž¥ì„ êµ¬ë§¤í•˜ì—¬ ì•„ë°”íƒ€ë¥¼ ë§ˆìŒê» ê¾¸ë©°ë³´ì„¸ìš”.";
	}

	/// <summary>
	/// Key: "LabelForumHelp"
	/// English String: "No matter what you're looking for, if it's Roblox related, there are people talking about it {linkStart}here{linkEnd}."
	/// </summary>
	public override string LabelForumHelp(string linkStart, string linkEnd)
	{
		return $"Robloxì— ê´€í•´ ê¶ê¸ˆí•œ ì ì´ ë„ˆë¬´ ë§Žë‹¤êµ¬ìš”? {linkStart}ì—¬ê¸°{linkEnd}ì—ì„œ ë‹¤ë¥¸ ì‚¬ëžŒë“¤ì˜ ì´ì•¼ê¸°ë¥¼ ë“¤ì–´ë³´ì„¸ìš”.";
	}

	protected override string _GetTemplateForLabelForumHelp()
	{
		return "Robloxì— ê´€í•´ ê¶ê¸ˆí•œ ì ì´ ë„ˆë¬´ ë§Žë‹¤êµ¬ìš”? {linkStart}ì—¬ê¸°{linkEnd}ì—ì„œ ë‹¤ë¥¸ ì‚¬ëžŒë“¤ì˜ ì´ì•¼ê¸°ë¥¼ ë“¤ì–´ë³´ì„¸ìš”.";
	}

	/// <summary>
	/// Key: "LabelMakeFriends"
	/// English String: "Meet other players in-game and send them a friend request. If you miss your opportunity you can always send a request later by {linkStart}searching{linkEnd} for their user profile."
	/// </summary>
	public override string LabelMakeFriends(string linkStart, string linkEnd)
	{
		return $"ê²Œìž„ì—ì„œ ë§Œë‚œ ë‹¤ë¥¸ í”Œë ˆì´ì–´ë“¤ì—ê²Œ ì¹œêµ¬ ìš”ì²­ì„ ë³´ë‚´ë³´ì„¸ìš”. í˜¹ì‹œ ê¸°íšŒë¥¼ ë†“ì³¤ë‹¤ë©´ ì–¸ì œë“  ì‚¬ìš©ìž í”„ë¡œí•„ì„ {linkStart}ê²€ìƒ‰{linkEnd}í•˜ì—¬ ì¹œêµ¬ ìš”ì²­ì„ ë³´ë‚¼ ìˆ˜ ìžˆìŠµë‹ˆë‹¤.";
	}

	protected override string _GetTemplateForLabelMakeFriends()
	{
		return "ê²Œìž„ì—ì„œ ë§Œë‚œ ë‹¤ë¥¸ í”Œë ˆì´ì–´ë“¤ì—ê²Œ ì¹œêµ¬ ìš”ì²­ì„ ë³´ë‚´ë³´ì„¸ìš”. í˜¹ì‹œ ê¸°íšŒë¥¼ ë†“ì³¤ë‹¤ë©´ ì–¸ì œë“  ì‚¬ìš©ìž í”„ë¡œí•„ì„ {linkStart}ê²€ìƒ‰{linkEnd}í•˜ì—¬ ì¹œêµ¬ ìš”ì²­ì„ ë³´ë‚¼ ìˆ˜ ìžˆìŠµë‹ˆë‹¤.";
	}

	protected override string _GetTemplateForLabelNoFeedLink()
	{
		return "ì§€ê¸ˆ ë°”ë¡œ ë² ìŠ¤íŠ¸ í”„ë Œë“œë¥¼ ì‚¬ê·€ì–´ë³´ì„¸ìš”.";
	}

	protected override string _GetTemplateForLabelNoFeedText()
	{
		return "ë² ìŠ¤íŠ¸ í”„ë Œë“œì— ê´€í•œ ìƒˆì†Œì‹ì´ ì—†ë„¤ìš”... ë² ìŠ¤íŠ¸ í”„ë Œë“œ ì†Œì‹ì´ ê¶ê¸ˆí•˜ì„¸ìš”?";
	}

	protected override string _GetTemplateForLabelPlayGames()
	{
		return "ì—¬ëŸ¬ë¶„ê³¼ ê°™ì€ í”Œë ˆì´ì–´ë“¤ì´ Robloxì˜ ê²Œìž„ ëŒ€ë¶€ë¶„ì„ ë§Œë“ ë‹µë‹ˆë‹¤. ìž¬ë¯¸ë‚œ ê²Œìž„ ëª‡ ê°€ì§€ë¥¼ êµ¬ê²½í•´ë³´ì„¸ìš”.";
	}
}


}
