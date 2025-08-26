namespace Roblox.Platform.TranslationResources.Feature {
    /// <summary>

/// This class overrides FeedResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class FeedResources_ja_jp : FeedResources_en_us, IFeedResources, ITranslationResources
{
	/// <summary>
	/// Key: "HeadingBuildSomething"
	/// English String: "Build Something"
	/// </summary>
	public override string HeadingBuildSomething => "è‡ªåˆ†ã§ä½œã£ã¦ã¿ã‚ˆã†";

	/// <summary>
	/// Key: "HeadingCustomizeAvatar"
	/// English String: "Customize Your Avatar"
	/// </summary>
	public override string HeadingCustomizeAvatar => "ã‚¢ãƒã‚¿ãƒ¼ã‚’ã‚«ã‚¹ã‚¿ãƒžã‚¤ã‚º";

	/// <summary>
	/// Key: "HeadingForumHelp"
	/// English String: "Roblox forums for help"
	/// </summary>
	public override string HeadingForumHelp => "Robloxãƒ˜ãƒ«ãƒ—ãƒ•ã‚©ãƒ¼ãƒ©ãƒ ";

	/// <summary>
	/// Key: "HeadingMakeFriends"
	/// English String: "Make Friends"
	/// </summary>
	public override string HeadingMakeFriends => "å‹é”ã‚’ä½œã‚ã†";

	/// <summary>
	/// Key: "HeadingPlayGames"
	/// English String: "Play Games"
	/// </summary>
	public override string HeadingPlayGames => "ã‚²ãƒ¼ãƒ ã‚’ãƒ—ãƒ¬ã‚¤";

	/// <summary>
	/// Key: "LabelNoFeedLink"
	/// English String: "make some best friends now."
	/// </summary>
	public override string LabelNoFeedLink => "ä»Šã™ãè¦ªå‹ã‚’ä½œã‚ã†ã€‚";

	/// <summary>
	/// Key: "LabelNoFeedText"
	/// English String: "No news about your best friends... want to know what your best friends are up to?"
	/// </summary>
	public override string LabelNoFeedText => "è¦ªå‹ã«é–¢ã™ã‚‹æœ€æ–°æƒ…å ±ã¯ã‚ã‚Šã¾ã›ã‚“... è¦ªå‹ã®çŠ¶æ³ã‚’ç¢ºèªã—ã¾ã™ã‹ï¼Ÿ";

	/// <summary>
	/// Key: "LabelPlayGames"
	/// English String: "Nearly all Roblox games are built by players like you. Here are some of our favorites:"
	/// </summary>
	public override string LabelPlayGames => "Robloxã®ã»ã¨ã‚“ã©ã®ã‚²ãƒ¼ãƒ ã¯ã€ã‚ãªãŸã®ã‚ˆã†ãªãƒ—ãƒ¬ã‚¤ãƒ¤ãƒ¼ãŒåˆ¶ä½œã—ãŸã‚‚ã®ã§ã™ã€‚äººæ°—ã‚²ãƒ¼ãƒ ã®ä¸€éƒ¨ã‚’ã”ç´¹ä»‹ã—ã¾ã™:";

	public FeedResources_ja_jp(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForHeadingBuildSomething()
	{
		return "è‡ªåˆ†ã§ä½œã£ã¦ã¿ã‚ˆã†";
	}

	protected override string _GetTemplateForHeadingCustomizeAvatar()
	{
		return "ã‚¢ãƒã‚¿ãƒ¼ã‚’ã‚«ã‚¹ã‚¿ãƒžã‚¤ã‚º";
	}

	protected override string _GetTemplateForHeadingForumHelp()
	{
		return "Robloxãƒ˜ãƒ«ãƒ—ãƒ•ã‚©ãƒ¼ãƒ©ãƒ ";
	}

	protected override string _GetTemplateForHeadingMakeFriends()
	{
		return "å‹é”ã‚’ä½œã‚ã†";
	}

	protected override string _GetTemplateForHeadingPlayGames()
	{
		return "ã‚²ãƒ¼ãƒ ã‚’ãƒ—ãƒ¬ã‚¤";
	}

	/// <summary>
	/// Key: "LabelBuildSomething"
	/// English String: "Builders will enjoy playing our multiplayer building game. Professional builders will want to check out Roblox Studio, our game development environment on your {linkStart}Develop page{linkEnd}."
	/// </summary>
	public override string LabelBuildSomething(string linkStart, string linkEnd)
	{
		return $"ãƒ“ãƒ«ãƒ€ãƒ¼ã¯ãƒžãƒ«ãƒãƒ—ãƒ¬ã‚¤ãƒ¤ãƒ¼ç”¨ãƒ“ãƒ«ãƒ‡ã‚£ãƒ³ã‚°ã‚²ãƒ¼ãƒ ã‚’ãƒ—ãƒ¬ã‚¤ã™ã‚‹ã®ãŒå¤§å¥½ãã§ã™ã€‚ãƒ—ãƒ­ã®ãƒ“ãƒ«ãƒ€ãƒ¼ãŒã€Roblox Studioã‚„ã€ã‚ãªãŸã®{linkStart}é–‹ç™ºãƒšãƒ¼ã‚¸{linkEnd}ã®ã‚²ãƒ¼ãƒ é–‹ç™ºç’°å¢ƒã«èˆˆå‘³ã‚’æŒã£ã¦ãã‚Œã‚‹ã‹ã‚‚ã—ã‚Œã¾ã›ã‚“ã€‚";
	}

	protected override string _GetTemplateForLabelBuildSomething()
	{
		return "ãƒ“ãƒ«ãƒ€ãƒ¼ã¯ãƒžãƒ«ãƒãƒ—ãƒ¬ã‚¤ãƒ¤ãƒ¼ç”¨ãƒ“ãƒ«ãƒ‡ã‚£ãƒ³ã‚°ã‚²ãƒ¼ãƒ ã‚’ãƒ—ãƒ¬ã‚¤ã™ã‚‹ã®ãŒå¤§å¥½ãã§ã™ã€‚ãƒ—ãƒ­ã®ãƒ“ãƒ«ãƒ€ãƒ¼ãŒã€Roblox Studioã‚„ã€ã‚ãªãŸã®{linkStart}é–‹ç™ºãƒšãƒ¼ã‚¸{linkEnd}ã®ã‚²ãƒ¼ãƒ é–‹ç™ºç’°å¢ƒã«èˆˆå‘³ã‚’æŒã£ã¦ãã‚Œã‚‹ã‹ã‚‚ã—ã‚Œã¾ã›ã‚“ã€‚";
	}

	/// <summary>
	/// Key: "LabelCustomizeAvatarDesktop"
	/// English String: "Visit the {avatarLinkStart} Avatar page {avatarLinkEnd} to customize your avatar. Get new clothing in the {catalogLinkStart}catalog{catalogLinkEnd}."
	/// </summary>
	public override string LabelCustomizeAvatarDesktop(string avatarLinkStart, string avatarLinkEnd, string catalogLinkStart, string catalogLinkEnd)
	{
		return $"{avatarLinkStart}ã‚¢ãƒã‚¿ãƒ¼ãƒšãƒ¼ã‚¸{avatarLinkEnd}ã«ã‚¢ã‚¯ã‚»ã‚¹ã—ã¦ã€ã‚¢ãƒã‚¿ãƒ¼ã‚’ã‚«ã‚¹ã‚¿ãƒžã‚¤ã‚ºã—ã‚ˆã†ã€‚{catalogLinkStart}ã‚«ã‚¿ãƒ­ã‚°{catalogLinkEnd}ã§æ–°ã—ã„ã‚³ã‚¹ãƒãƒ¥ãƒ¼ãƒ ã‚’ã‚²ãƒƒãƒˆã—ã‚ˆã†ã€‚";
	}

	protected override string _GetTemplateForLabelCustomizeAvatarDesktop()
	{
		return "{avatarLinkStart}ã‚¢ãƒã‚¿ãƒ¼ãƒšãƒ¼ã‚¸{avatarLinkEnd}ã«ã‚¢ã‚¯ã‚»ã‚¹ã—ã¦ã€ã‚¢ãƒã‚¿ãƒ¼ã‚’ã‚«ã‚¹ã‚¿ãƒžã‚¤ã‚ºã—ã‚ˆã†ã€‚{catalogLinkStart}ã‚«ã‚¿ãƒ­ã‚°{catalogLinkEnd}ã§æ–°ã—ã„ã‚³ã‚¹ãƒãƒ¥ãƒ¼ãƒ ã‚’ã‚²ãƒƒãƒˆã—ã‚ˆã†ã€‚";
	}

	/// <summary>
	/// Key: "LabelCustomizeAvatarPhone"
	/// English String: "Get new clothing in the {linkStart} catalog {linkEnd} and customize your avatar."
	/// </summary>
	public override string LabelCustomizeAvatarPhone(string linkStart, string linkEnd)
	{
		return $"{linkStart} ã‚«ã‚¿ãƒ­ã‚° {linkEnd} ã§ã‚³ã‚¹ãƒãƒ¥ãƒ¼ãƒ ã‚’ã‚²ãƒƒãƒˆã—ã¦ã‚¢ãƒã‚¿ãƒ¼ã‚’ã‚«ã‚¹ã‚¿ãƒžã‚¤ã‚ºã—ã‚ˆã†ã€‚";
	}

	protected override string _GetTemplateForLabelCustomizeAvatarPhone()
	{
		return "{linkStart} ã‚«ã‚¿ãƒ­ã‚° {linkEnd} ã§ã‚³ã‚¹ãƒãƒ¥ãƒ¼ãƒ ã‚’ã‚²ãƒƒãƒˆã—ã¦ã‚¢ãƒã‚¿ãƒ¼ã‚’ã‚«ã‚¹ã‚¿ãƒžã‚¤ã‚ºã—ã‚ˆã†ã€‚";
	}

	/// <summary>
	/// Key: "LabelForumHelp"
	/// English String: "No matter what you're looking for, if it's Roblox related, there are people talking about it {linkStart}here{linkEnd}."
	/// </summary>
	public override string LabelForumHelp(string linkStart, string linkEnd)
	{
		return $"ã©ã‚“ãªã‚‚ã®ã‚’æŽ¢ã™å ´åˆã§ã‚‚ã€Robloxã«é–¢é€£ã—ãŸã‚‚ã®ã§ã‚ã‚Œã°ã€{linkStart}ã“ã¡ã‚‰{linkEnd}ã§è©±é¡Œã«ä¸Šã‚‹ã“ã¨ãŒã‚ã‚Šã¾ã™ã€‚";
	}

	protected override string _GetTemplateForLabelForumHelp()
	{
		return "ã©ã‚“ãªã‚‚ã®ã‚’æŽ¢ã™å ´åˆã§ã‚‚ã€Robloxã«é–¢é€£ã—ãŸã‚‚ã®ã§ã‚ã‚Œã°ã€{linkStart}ã“ã¡ã‚‰{linkEnd}ã§è©±é¡Œã«ä¸Šã‚‹ã“ã¨ãŒã‚ã‚Šã¾ã™ã€‚";
	}

	/// <summary>
	/// Key: "LabelMakeFriends"
	/// English String: "Meet other players in-game and send them a friend request. If you miss your opportunity you can always send a request later by {linkStart}searching{linkEnd} for their user profile."
	/// </summary>
	public override string LabelMakeFriends(string linkStart, string linkEnd)
	{
		return $"ã‚²ãƒ¼ãƒ å†…ã§ä»–ã®ãƒ—ãƒ¬ã‚¤ãƒ¤ãƒ¼ã¨çŸ¥ã‚Šåˆã„ã«ãªã£ã¦å‹é”ãƒªã‚¯ã‚¨ã‚¹ãƒˆã‚’ã—ã‚ˆã†ã€‚ã‚¿ã‚¤ãƒŸãƒ³ã‚°ã‚’é€ƒã—ãŸå ´åˆã§ã‚‚ã€ãƒ¦ãƒ¼ã‚¶ãƒ¼ãƒ—ãƒ­ãƒ•ã‚£ãƒ¼ãƒ«ã§ {linkStart}æ¤œç´¢{linkEnd} ã—ã¦ã€ã„ã¤ã§ã‚‚ã¾ãŸãƒªã‚¯ã‚¨ã‚¹ãƒˆã§ãã¾ã™ã€‚";
	}

	protected override string _GetTemplateForLabelMakeFriends()
	{
		return "ã‚²ãƒ¼ãƒ å†…ã§ä»–ã®ãƒ—ãƒ¬ã‚¤ãƒ¤ãƒ¼ã¨çŸ¥ã‚Šåˆã„ã«ãªã£ã¦å‹é”ãƒªã‚¯ã‚¨ã‚¹ãƒˆã‚’ã—ã‚ˆã†ã€‚ã‚¿ã‚¤ãƒŸãƒ³ã‚°ã‚’é€ƒã—ãŸå ´åˆã§ã‚‚ã€ãƒ¦ãƒ¼ã‚¶ãƒ¼ãƒ—ãƒ­ãƒ•ã‚£ãƒ¼ãƒ«ã§ {linkStart}æ¤œç´¢{linkEnd} ã—ã¦ã€ã„ã¤ã§ã‚‚ã¾ãŸãƒªã‚¯ã‚¨ã‚¹ãƒˆã§ãã¾ã™ã€‚";
	}

	protected override string _GetTemplateForLabelNoFeedLink()
	{
		return "ä»Šã™ãè¦ªå‹ã‚’ä½œã‚ã†ã€‚";
	}

	protected override string _GetTemplateForLabelNoFeedText()
	{
		return "è¦ªå‹ã«é–¢ã™ã‚‹æœ€æ–°æƒ…å ±ã¯ã‚ã‚Šã¾ã›ã‚“... è¦ªå‹ã®çŠ¶æ³ã‚’ç¢ºèªã—ã¾ã™ã‹ï¼Ÿ";
	}

	protected override string _GetTemplateForLabelPlayGames()
	{
		return "Robloxã®ã»ã¨ã‚“ã©ã®ã‚²ãƒ¼ãƒ ã¯ã€ã‚ãªãŸã®ã‚ˆã†ãªãƒ—ãƒ¬ã‚¤ãƒ¤ãƒ¼ãŒåˆ¶ä½œã—ãŸã‚‚ã®ã§ã™ã€‚äººæ°—ã‚²ãƒ¼ãƒ ã®ä¸€éƒ¨ã‚’ã”ç´¹ä»‹ã—ã¾ã™:";
	}
}


}
