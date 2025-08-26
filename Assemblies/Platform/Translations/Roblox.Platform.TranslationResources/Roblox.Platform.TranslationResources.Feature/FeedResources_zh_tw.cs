namespace Roblox.Platform.TranslationResources.Feature {
    /// <summary>

/// This class overrides FeedResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class FeedResources_zh_tw : FeedResources_en_us, IFeedResources, ITranslationResources
{
	/// <summary>
	/// Key: "HeadingBuildSomething"
	/// English String: "Build Something"
	/// </summary>
	public override string HeadingBuildSomething => "é–‹å§‹å‰µä½œ";

	/// <summary>
	/// Key: "HeadingCustomizeAvatar"
	/// English String: "Customize Your Avatar"
	/// </summary>
	public override string HeadingCustomizeAvatar => "è‡ªè¨‚æ‚¨çš„è™›æ“¬äººå¶";

	/// <summary>
	/// Key: "HeadingForumHelp"
	/// English String: "Roblox forums for help"
	/// </summary>
	public override string HeadingForumHelp => "ç€è¦½ Roblox è«–å£‡å–å¾—å”åŠ©";

	/// <summary>
	/// Key: "HeadingMakeFriends"
	/// English String: "Make Friends"
	/// </summary>
	public override string HeadingMakeFriends => "çµäº¤å¥½å‹";

	/// <summary>
	/// Key: "HeadingPlayGames"
	/// English String: "Play Games"
	/// </summary>
	public override string HeadingPlayGames => "çŽ©éŠæˆ²";

	/// <summary>
	/// Key: "LabelNoFeedLink"
	/// English String: "make some best friends now."
	/// </summary>
	public override string LabelNoFeedLink => "ç¾åœ¨é–‹å§‹çµäº¤å¥½å‹ã€‚";

	/// <summary>
	/// Key: "LabelNoFeedText"
	/// English String: "No news about your best friends... want to know what your best friends are up to?"
	/// </summary>
	public override string LabelNoFeedText => "æ²’æœ‰æ‚¨çš„å¥½å‹çš„æ¶ˆæ¯â€¦æƒ³çŸ¥é“æ‚¨çš„å¥½å‹åœ¨åšä»€éº¼å—Žï¼Ÿ";

	/// <summary>
	/// Key: "LabelPlayGames"
	/// English String: "Nearly all Roblox games are built by players like you. Here are some of our favorites:"
	/// </summary>
	public override string LabelPlayGames => "Roblox éŠæˆ²å¹¾ä¹Žéƒ½æ˜¯ç”±åƒæ‚¨ä¸€æ¨£çš„çŽ©å®¶å‰µä½œã€‚ä»¥ä¸‹æ˜¯å¹¾å€‹æˆ‘å€‘æœ€æ„›çš„éŠæˆ²ï¼š";

	public FeedResources_zh_tw(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForHeadingBuildSomething()
	{
		return "é–‹å§‹å‰µä½œ";
	}

	protected override string _GetTemplateForHeadingCustomizeAvatar()
	{
		return "è‡ªè¨‚æ‚¨çš„è™›æ“¬äººå¶";
	}

	protected override string _GetTemplateForHeadingForumHelp()
	{
		return "ç€è¦½ Roblox è«–å£‡å–å¾—å”åŠ©";
	}

	protected override string _GetTemplateForHeadingMakeFriends()
	{
		return "çµäº¤å¥½å‹";
	}

	protected override string _GetTemplateForHeadingPlayGames()
	{
		return "çŽ©éŠæˆ²";
	}

	/// <summary>
	/// Key: "LabelBuildSomething"
	/// English String: "Builders will enjoy playing our multiplayer building game. Professional builders will want to check out Roblox Studio, our game development environment on your {linkStart}Develop page{linkEnd}."
	/// </summary>
	public override string LabelBuildSomething(string linkStart, string linkEnd)
	{
		return $"å»ºç¯‰å®¶éƒ½å–œæ­¡çŽ©æˆ‘å€‘çš„å¤šäººå»ºé€ éŠæˆ²ã€‚å°ˆæ¥­å»ºç¯‰å®¶å¯ä»¥å‰å¾€{linkStart}é–‹ç™¼é é¢{linkEnd}çœ‹çœ‹æˆ‘å€‘çš„éŠæˆ²é–‹ç™¼ç’°å¢ƒ Roblox Studioã€‚";
	}

	protected override string _GetTemplateForLabelBuildSomething()
	{
		return "å»ºç¯‰å®¶éƒ½å–œæ­¡çŽ©æˆ‘å€‘çš„å¤šäººå»ºé€ éŠæˆ²ã€‚å°ˆæ¥­å»ºç¯‰å®¶å¯ä»¥å‰å¾€{linkStart}é–‹ç™¼é é¢{linkEnd}çœ‹çœ‹æˆ‘å€‘çš„éŠæˆ²é–‹ç™¼ç’°å¢ƒ Roblox Studioã€‚";
	}

	/// <summary>
	/// Key: "LabelCustomizeAvatarDesktop"
	/// English String: "Visit the {avatarLinkStart} Avatar page {avatarLinkEnd} to customize your avatar. Get new clothing in the {catalogLinkStart}catalog{catalogLinkEnd}."
	/// </summary>
	public override string LabelCustomizeAvatarDesktop(string avatarLinkStart, string avatarLinkEnd, string catalogLinkStart, string catalogLinkEnd)
	{
		return $"å‰å¾€{avatarLinkStart}è™›æ“¬äººå¶é é¢{avatarLinkEnd}è‡ªè¨‚æ‚¨çš„è™›æ“¬äººå¶ã€‚è«‹å¾ž{catalogLinkStart}åž‹éŒ„{catalogLinkEnd}å–å¾—æ–°æœè£ã€‚";
	}

	protected override string _GetTemplateForLabelCustomizeAvatarDesktop()
	{
		return "å‰å¾€{avatarLinkStart}è™›æ“¬äººå¶é é¢{avatarLinkEnd}è‡ªè¨‚æ‚¨çš„è™›æ“¬äººå¶ã€‚è«‹å¾ž{catalogLinkStart}åž‹éŒ„{catalogLinkEnd}å–å¾—æ–°æœè£ã€‚";
	}

	/// <summary>
	/// Key: "LabelCustomizeAvatarPhone"
	/// English String: "Get new clothing in the {linkStart} catalog {linkEnd} and customize your avatar."
	/// </summary>
	public override string LabelCustomizeAvatarPhone(string linkStart, string linkEnd)
	{
		return $"å¾ž{linkStart}åž‹éŒ„{linkEnd}å–å¾—æ–°è¡£ç‰©ï¼Œè‡ªè¨‚æ‚¨çš„è™›æ“¬äººå¶ã€‚";
	}

	protected override string _GetTemplateForLabelCustomizeAvatarPhone()
	{
		return "å¾ž{linkStart}åž‹éŒ„{linkEnd}å–å¾—æ–°è¡£ç‰©ï¼Œè‡ªè¨‚æ‚¨çš„è™›æ“¬äººå¶ã€‚";
	}

	/// <summary>
	/// Key: "LabelForumHelp"
	/// English String: "No matter what you're looking for, if it's Roblox related, there are people talking about it {linkStart}here{linkEnd}."
	/// </summary>
	public override string LabelForumHelp(string linkStart, string linkEnd)
	{
		return $"ä¸ç®¡æ‚¨åœ¨æ‰¾ä»€éº¼ï¼Œåªè¦å’Œ Roblox æœ‰é—œï¼Œå°±æœ‰äººåœ¨{linkStart}é€™è£¡{linkEnd}è¨Žè«–ã€‚";
	}

	protected override string _GetTemplateForLabelForumHelp()
	{
		return "ä¸ç®¡æ‚¨åœ¨æ‰¾ä»€éº¼ï¼Œåªè¦å’Œ Roblox æœ‰é—œï¼Œå°±æœ‰äººåœ¨{linkStart}é€™è£¡{linkEnd}è¨Žè«–ã€‚";
	}

	/// <summary>
	/// Key: "LabelMakeFriends"
	/// English String: "Meet other players in-game and send them a friend request. If you miss your opportunity you can always send a request later by {linkStart}searching{linkEnd} for their user profile."
	/// </summary>
	public override string LabelMakeFriends(string linkStart, string linkEnd)
	{
		return $"åœ¨éŠæˆ²ä¸­èˆ‡å…¶ä»–çŽ©å®¶ç›¸æœƒï¼Œä¸¦å‘å°æ–¹å‚³é€å¥½å‹é‚€è«‹ã€‚è‹¥æ‚¨å·²é›¢é–‹éŠæˆ²ï¼Œæ‚¨å¯ä»¥{linkStart}æœå°‹{linkEnd}è©²ä½¿ç”¨è€…çš„å€‹äººæª”æ¡ˆï¼Œå†å‚³é€å¥½å‹é‚€è«‹ã€‚";
	}

	protected override string _GetTemplateForLabelMakeFriends()
	{
		return "åœ¨éŠæˆ²ä¸­èˆ‡å…¶ä»–çŽ©å®¶ç›¸æœƒï¼Œä¸¦å‘å°æ–¹å‚³é€å¥½å‹é‚€è«‹ã€‚è‹¥æ‚¨å·²é›¢é–‹éŠæˆ²ï¼Œæ‚¨å¯ä»¥{linkStart}æœå°‹{linkEnd}è©²ä½¿ç”¨è€…çš„å€‹äººæª”æ¡ˆï¼Œå†å‚³é€å¥½å‹é‚€è«‹ã€‚";
	}

	protected override string _GetTemplateForLabelNoFeedLink()
	{
		return "ç¾åœ¨é–‹å§‹çµäº¤å¥½å‹ã€‚";
	}

	protected override string _GetTemplateForLabelNoFeedText()
	{
		return "æ²’æœ‰æ‚¨çš„å¥½å‹çš„æ¶ˆæ¯â€¦æƒ³çŸ¥é“æ‚¨çš„å¥½å‹åœ¨åšä»€éº¼å—Žï¼Ÿ";
	}

	protected override string _GetTemplateForLabelPlayGames()
	{
		return "Roblox éŠæˆ²å¹¾ä¹Žéƒ½æ˜¯ç”±åƒæ‚¨ä¸€æ¨£çš„çŽ©å®¶å‰µä½œã€‚ä»¥ä¸‹æ˜¯å¹¾å€‹æˆ‘å€‘æœ€æ„›çš„éŠæˆ²ï¼š";
	}
}


}
