namespace Roblox.Platform.TranslationResources.Feature {
    /// <summary>

/// This class overrides FeedResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class FeedResources_zh_cjv : FeedResources_en_us, IFeedResources, ITranslationResources
{
	/// <summary>
	/// Key: "HeadingBuildSomething"
	/// English String: "Build Something"
	/// </summary>
	public override string HeadingBuildSomething => "å‘æŒ¥åˆ›é€ åŠ›";

	/// <summary>
	/// Key: "HeadingCustomizeAvatar"
	/// English String: "Customize Your Avatar"
	/// </summary>
	public override string HeadingCustomizeAvatar => "è‡ªå®šä¹‰ä½ çš„è™šæ‹Ÿå½¢è±¡";

	/// <summary>
	/// Key: "HeadingForumHelp"
	/// English String: "Roblox forums for help"
	/// </summary>
	public override string HeadingForumHelp => "å‰å¾€ Roblox è®ºå›å¯»æ±‚å¸®åŠ©";

	/// <summary>
	/// Key: "HeadingMakeFriends"
	/// English String: "Make Friends"
	/// </summary>
	public override string HeadingMakeFriends => "ç»“äº¤å¥½å‹";

	/// <summary>
	/// Key: "HeadingPlayGames"
	/// English String: "Play Games"
	/// </summary>
	public override string HeadingPlayGames => "çŽ©æ¸¸æˆ";

	/// <summary>
	/// Key: "LabelNoFeedLink"
	/// English String: "make some best friends now."
	/// </summary>
	public override string LabelNoFeedLink => "ç«‹å³è®¤è¯†æ–°æœ‹å‹ã€‚";

	/// <summary>
	/// Key: "LabelNoFeedText"
	/// English String: "No news about your best friends... want to know what your best friends are up to?"
	/// </summary>
	public override string LabelNoFeedText => "æ²¡æœ‰ä½ å¥½å‹çš„æ¶ˆæ¯... æƒ³çŸ¥é“ä»–ä»¬åœ¨åšä»€ä¹ˆå—ï¼Ÿ";

	/// <summary>
	/// Key: "LabelPlayGames"
	/// English String: "Nearly all Roblox games are built by players like you. Here are some of our favorites:"
	/// </summary>
	public override string LabelPlayGames => "å‡ ä¹Žæ‰€æœ‰çš„ Roblox æ¸¸æˆéƒ½æ˜¯ç”±å’Œä½ ä¸€æ ·çš„çŽ©å®¶åˆ›ä½œçš„ã€‚è¿™é‡Œæ˜¯æˆ‘ä»¬æœ€çˆ±çš„å‡ ä¸ªæ¸¸æˆï¼š";

	public FeedResources_zh_cjv(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForHeadingBuildSomething()
	{
		return "å‘æŒ¥åˆ›é€ åŠ›";
	}

	protected override string _GetTemplateForHeadingCustomizeAvatar()
	{
		return "è‡ªå®šä¹‰ä½ çš„è™šæ‹Ÿå½¢è±¡";
	}

	protected override string _GetTemplateForHeadingForumHelp()
	{
		return "å‰å¾€ Roblox è®ºå›å¯»æ±‚å¸®åŠ©";
	}

	protected override string _GetTemplateForHeadingMakeFriends()
	{
		return "ç»“äº¤å¥½å‹";
	}

	protected override string _GetTemplateForHeadingPlayGames()
	{
		return "çŽ©æ¸¸æˆ";
	}

	/// <summary>
	/// Key: "LabelBuildSomething"
	/// English String: "Builders will enjoy playing our multiplayer building game. Professional builders will want to check out Roblox Studio, our game development environment on your {linkStart}Develop page{linkEnd}."
	/// </summary>
	public override string LabelBuildSomething(string linkStart, string linkEnd)
	{
		return $"ä½ ä¼šåœ¨ Roblox ä¸­å‘çŽ°è®¸å¤šæ·±å—å¤§å®¶æ¬¢è¿Žçš„å¤šäººå»ºé€ æ¸¸æˆã€‚ä¸“ä¸šçš„åˆ›å»ºè€…å¯ä»¥å‰å¾€{linkStart}åˆ›å»ºé¡µé¢{linkEnd}ï¼Œäº†è§£æˆ‘ä»¬çš„æ¸¸æˆå¼€å‘çŽ¯å¢ƒ Roblox Studioã€‚";
	}

	protected override string _GetTemplateForLabelBuildSomething()
	{
		return "ä½ ä¼šåœ¨ Roblox ä¸­å‘çŽ°è®¸å¤šæ·±å—å¤§å®¶æ¬¢è¿Žçš„å¤šäººå»ºé€ æ¸¸æˆã€‚ä¸“ä¸šçš„åˆ›å»ºè€…å¯ä»¥å‰å¾€{linkStart}åˆ›å»ºé¡µé¢{linkEnd}ï¼Œäº†è§£æˆ‘ä»¬çš„æ¸¸æˆå¼€å‘çŽ¯å¢ƒ Roblox Studioã€‚";
	}

	/// <summary>
	/// Key: "LabelCustomizeAvatarDesktop"
	/// English String: "Visit the {avatarLinkStart} Avatar page {avatarLinkEnd} to customize your avatar. Get new clothing in the {catalogLinkStart}catalog{catalogLinkEnd}."
	/// </summary>
	public override string LabelCustomizeAvatarDesktop(string avatarLinkStart, string avatarLinkEnd, string catalogLinkStart, string catalogLinkEnd)
	{
		return $"è®¿é—®{avatarLinkStart}è™šæ‹Ÿå½¢è±¡é¡µé¢{avatarLinkEnd}ï¼Œè‡ªå®šä¹‰ä½ çš„è™šæ‹Ÿå½¢è±¡ã€‚åœ¨{catalogLinkStart}å•†åº—{catalogLinkEnd}ä¸­èŽ·å¾—æ–°æœè£…ã€‚";
	}

	protected override string _GetTemplateForLabelCustomizeAvatarDesktop()
	{
		return "è®¿é—®{avatarLinkStart}è™šæ‹Ÿå½¢è±¡é¡µé¢{avatarLinkEnd}ï¼Œè‡ªå®šä¹‰ä½ çš„è™šæ‹Ÿå½¢è±¡ã€‚åœ¨{catalogLinkStart}å•†åº—{catalogLinkEnd}ä¸­èŽ·å¾—æ–°æœè£…ã€‚";
	}

	/// <summary>
	/// Key: "LabelCustomizeAvatarPhone"
	/// English String: "Get new clothing in the {linkStart} catalog {linkEnd} and customize your avatar."
	/// </summary>
	public override string LabelCustomizeAvatarPhone(string linkStart, string linkEnd)
	{
		return $"åœ¨{linkStart}å•†åº—{linkEnd}ä¸­èŽ·å–æ–°æœè£…ï¼Œè‡ªå®šä¹‰ä½ çš„è™šæ‹Ÿå½¢è±¡ã€‚";
	}

	protected override string _GetTemplateForLabelCustomizeAvatarPhone()
	{
		return "åœ¨{linkStart}å•†åº—{linkEnd}ä¸­èŽ·å–æ–°æœè£…ï¼Œè‡ªå®šä¹‰ä½ çš„è™šæ‹Ÿå½¢è±¡ã€‚";
	}

	/// <summary>
	/// Key: "LabelForumHelp"
	/// English String: "No matter what you're looking for, if it's Roblox related, there are people talking about it {linkStart}here{linkEnd}."
	/// </summary>
	public override string LabelForumHelp(string linkStart, string linkEnd)
	{
		return $"æ— è®ºä½ è¦æ‰¾ä»€ä¹ˆï¼Œåªè¦ä¸Ž Roblox ç›¸å…³ï¼Œå°±æœ‰äººåœ¨{linkStart}æ­¤å¤„{linkEnd}è®¨è®ºã€‚";
	}

	protected override string _GetTemplateForLabelForumHelp()
	{
		return "æ— è®ºä½ è¦æ‰¾ä»€ä¹ˆï¼Œåªè¦ä¸Ž Roblox ç›¸å…³ï¼Œå°±æœ‰äººåœ¨{linkStart}æ­¤å¤„{linkEnd}è®¨è®ºã€‚";
	}

	/// <summary>
	/// Key: "LabelMakeFriends"
	/// English String: "Meet other players in-game and send them a friend request. If you miss your opportunity you can always send a request later by {linkStart}searching{linkEnd} for their user profile."
	/// </summary>
	public override string LabelMakeFriends(string linkStart, string linkEnd)
	{
		return $"åœ¨æ¸¸æˆä¸­è®¤è¯†å…¶ä»–çŽ©å®¶ï¼Œå¹¶å‘ä»–ä»¬å‘å‡ºå¥½å‹é‚€è¯·ã€‚å¦‚æžœä½ é”™è¿‡äº†æœºä¼šï¼Œä¸ç”¨æ‹…å¿ƒï¼Œä½ å¯ä»¥éšæ—¶é€šè¿‡{linkStart}æœç´¢{linkEnd}è¯¥çŽ©å®¶çš„ä¸ªäººèµ„æ–™ï¼Œå†å‘ä»–ä»¬å‘å‡ºå¥½å‹é‚€è¯·ã€‚";
	}

	protected override string _GetTemplateForLabelMakeFriends()
	{
		return "åœ¨æ¸¸æˆä¸­è®¤è¯†å…¶ä»–çŽ©å®¶ï¼Œå¹¶å‘ä»–ä»¬å‘å‡ºå¥½å‹é‚€è¯·ã€‚å¦‚æžœä½ é”™è¿‡äº†æœºä¼šï¼Œä¸ç”¨æ‹…å¿ƒï¼Œä½ å¯ä»¥éšæ—¶é€šè¿‡{linkStart}æœç´¢{linkEnd}è¯¥çŽ©å®¶çš„ä¸ªäººèµ„æ–™ï¼Œå†å‘ä»–ä»¬å‘å‡ºå¥½å‹é‚€è¯·ã€‚";
	}

	protected override string _GetTemplateForLabelNoFeedLink()
	{
		return "ç«‹å³è®¤è¯†æ–°æœ‹å‹ã€‚";
	}

	protected override string _GetTemplateForLabelNoFeedText()
	{
		return "æ²¡æœ‰ä½ å¥½å‹çš„æ¶ˆæ¯... æƒ³çŸ¥é“ä»–ä»¬åœ¨åšä»€ä¹ˆå—ï¼Ÿ";
	}

	protected override string _GetTemplateForLabelPlayGames()
	{
		return "å‡ ä¹Žæ‰€æœ‰çš„ Roblox æ¸¸æˆéƒ½æ˜¯ç”±å’Œä½ ä¸€æ ·çš„çŽ©å®¶åˆ›ä½œçš„ã€‚è¿™é‡Œæ˜¯æˆ‘ä»¬æœ€çˆ±çš„å‡ ä¸ªæ¸¸æˆï¼š";
	}
}


}
