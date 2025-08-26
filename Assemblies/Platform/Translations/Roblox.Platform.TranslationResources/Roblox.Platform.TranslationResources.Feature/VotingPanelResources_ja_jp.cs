namespace Roblox.Platform.TranslationResources.Feature {
    /// <summary>

/// This class overrides VotingPanelResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class VotingPanelResources_ja_jp : VotingPanelResources_en_us, IVotingPanelResources, ITranslationResources
{
	/// <summary>
	/// Key: "Label.Accept"
	/// English String: "Verify"
	/// </summary>
	public override string LabelAccept => "èªè¨¼";

	/// <summary>
	/// Key: "Label.AccountPageTitle"
	/// English String: "Account"
	/// </summary>
	public override string LabelAccountPageTitle => "ã‚¢ã‚«ã‚¦ãƒ³ãƒˆ";

	/// <summary>
	/// Key: "Label.AccountUnderDayOneMessage"
	/// English String: "You will be able to vote on Games and Studio Models later, after you've had a chance to experience Roblox a bit more. Come back to this page in a couple days."
	/// </summary>
	public override string LabelAccountUnderDayOneMessage => "Robloxã‚’ã‚‚ã†å°‘ã—ä½“é¨“ã™ã‚Œã°ã€ã‚²ãƒ¼ãƒ ã‚„Studioã®ãƒ¢ãƒ‡ãƒ«ã«æŠ•ç¥¨ã§ãã‚‹ã‚ˆã†ã«ãªã‚Šã¾ã™ã€‚æ•°æ—¥å¾Œã«ã‚‚ã†ä¸€åº¦ã“ã®ãƒšãƒ¼ã‚¸ã«ã‚¢ã‚¯ã‚»ã‚¹ã—ã¦ãã ã•ã„ã€‚";

	/// <summary>
	/// Key: "Label.AccountUnderDayOneTitle"
	/// English String: "Voter Feedback"
	/// </summary>
	public override string LabelAccountUnderDayOneTitle => "æŠ•ç¥¨è€…ãƒ•ã‚£ãƒ¼ãƒ‰ãƒãƒƒã‚¯";

	/// <summary>
	/// Key: "Label.AssetNotVoteableMessage"
	/// English String: "This asset may not be voted on at this time."
	/// </summary>
	public override string LabelAssetNotVoteableMessage => "ã“ã®ã‚¢ã‚»ãƒƒãƒˆã«ã¯ç¾åœ¨æŠ•ç¥¨ã§ãã¾ã›ã‚“ã€‚";

	/// <summary>
	/// Key: "Label.AssetNotVoteableTitle"
	/// English String: "Unable to Vote"
	/// </summary>
	public override string LabelAssetNotVoteableTitle => "æŠ•ç¥¨ã§ãã¾ã›ã‚“";

	/// <summary>
	/// Key: "Label.BuyGamePassMessage"
	/// English String: "You must own this game pass before you can vote on it."
	/// </summary>
	public override string LabelBuyGamePassMessage => "æŠ•ç¥¨ã™ã‚‹å‰ã«ã“ã®ã‚²ãƒ¼ãƒ ãƒ‘ã‚¹ã‚’æŒã£ã¦ã„ã‚‹å¿…è¦ãŒã‚ã‚Šã¾ã™ã€‚";

	/// <summary>
	/// Key: "Label.BuyGamePassTitle"
	/// English String: "Buy Game Pass"
	/// </summary>
	public override string LabelBuyGamePassTitle => "ã‚²ãƒ¼ãƒ ãƒ‘ã‚¹ã‚’è²·ã†";

	/// <summary>
	/// Key: "Label.Decline"
	/// English String: "Cancel"
	/// </summary>
	public override string LabelDecline => "ã‚­ãƒ£ãƒ³ã‚»ãƒ«";

	/// <summary>
	/// Key: "Label.EmailVerifiedTitle"
	/// English String: "Verify Your Email"
	/// </summary>
	public override string LabelEmailVerifiedTitle => "ãƒ¡ãƒ¼ãƒ«ã‚¢ãƒ‰ãƒ¬ã‚¹ã‚’èªè¨¼";

	/// <summary>
	/// Key: "Label.FloodCheckMessage"
	/// English String: "You're voting too quickly. Come back later and try again."
	/// </summary>
	public override string LabelFloodCheckMessage => "é »ç¹ã«æŠ•ç¥¨ã—éŽãŽã§ã™ã€‚ã—ã°ã‚‰ãã—ã¦ã‹ã‚‰æˆ»ã£ã¦ãã¦ã‚„ã‚Šç›´ã—ã¦ãã ã•ã„ã€‚";

	/// <summary>
	/// Key: "Label.FloodCheckTitle"
	/// English String: "Slow Down"
	/// </summary>
	public override string LabelFloodCheckTitle => "ãƒšãƒ¼ã‚¹ã‚’è½ã¨ã™";

	/// <summary>
	/// Key: "Label.GuestUserTitle"
	/// English String: "Login to Vote"
	/// </summary>
	public override string LabelGuestUserTitle => "ãƒ­ã‚°ã‚¤ãƒ³ã—ã¦æŠ•ç¥¨ã™ã‚‹";

	/// <summary>
	/// Key: "Label.InstallPluginMessage"
	/// English String: "You must install this plugin before you can vote on it."
	/// </summary>
	public override string LabelInstallPluginMessage => "æŠ•ç¥¨ã™ã‚‹å‰ã«ã“ã®ãƒ—ãƒ©ã‚°ã‚¤ãƒ³ã‚’ã‚¤ãƒ³ã‚¹ãƒˆãƒ¼ãƒ«ã™ã‚‹å¿…è¦ãŒã‚ã‚Šã¾ã™ã€‚";

	/// <summary>
	/// Key: "Label.InstallPluginTitle"
	/// English String: "Install Plugin"
	/// </summary>
	public override string LabelInstallPluginTitle => "ãƒ—ãƒ©ã‚°ã‚¤ãƒ³ã®ã‚¤ãƒ³ã‚¹ãƒˆãƒ¼ãƒ«";

	/// <summary>
	/// Key: "Label.Login"
	/// English String: "Login"
	/// </summary>
	public override string LabelLogin => "ãƒ­ã‚°ã‚¤ãƒ³";

	/// <summary>
	/// Key: "Label.LoginOrRegisterPageTitle"
	/// English String: "login or register"
	/// </summary>
	public override string LabelLoginOrRegisterPageTitle => "ãƒ­ã‚°ã‚¤ãƒ³ã¾ãŸã¯æ–°è¦ç™»éŒ²";

	/// <summary>
	/// Key: "Label.Ok"
	/// English String: "OK"
	/// </summary>
	public override string LabelOk => "OK";

	/// <summary>
	/// Key: "Label.PlayGameMessage"
	/// English String: "You must play the game before you can vote on it."
	/// </summary>
	public override string LabelPlayGameMessage => "æŠ•ç¥¨ã™ã‚‹å‰ã«ã‚²ãƒ¼ãƒ ã‚’ãƒ—ãƒ¬ã‚¤ã™ã‚‹å¿…è¦ãŒã‚ã‚Šã¾ã™ã€‚";

	/// <summary>
	/// Key: "Label.PlayGameTitle"
	/// English String: "Play Game"
	/// </summary>
	public override string LabelPlayGameTitle => "ã‚²ãƒ¼ãƒ ã‚’ãƒ—ãƒ¬ã‚¤";

	/// <summary>
	/// Key: "Label.UnknownProblemMessage"
	/// English String: "There was an unknown problem voting. Please try again."
	/// </summary>
	public override string LabelUnknownProblemMessage => "æŠ•ç¥¨ä¸­ã«ä¸æ˜Žãªã‚¨ãƒ©ãƒ¼ãŒç™ºç”Ÿã—ã¾ã—ãŸã€‚ã‚‚ã†ä¸€åº¦ãŠè©¦ã—ãã ã•ã„ã€‚";

	/// <summary>
	/// Key: "Label.UnknownProblemTitle"
	/// English String: "Something Broke"
	/// </summary>
	public override string LabelUnknownProblemTitle => "å•é¡ŒãŒç™ºç”Ÿ";

	/// <summary>
	/// Key: "Label.UseModelMessage"
	/// English String: "You must use this model before you can vote on it."
	/// </summary>
	public override string LabelUseModelMessage => "æŠ•ç¥¨ã™ã‚‹å‰ã«ã“ã®ãƒ¢ãƒ‡ãƒ«ã‚’ä½¿ã†å¿…è¦ãŒã‚ã‚Šã¾ã™ã€‚";

	/// <summary>
	/// Key: "Label.UseModelTitle"
	/// English String: "Use Model"
	/// </summary>
	public override string LabelUseModelTitle => "ãƒ¢ãƒ‡ãƒ«ã‚’ä½¿ã†";

	/// <summary>
	/// Key: "Label.YouMustLoginToVote"
	/// English String: "You must login to vote."
	/// </summary>
	public override string LabelYouMustLoginToVote => "æŠ•ç¥¨ã‚’è¡Œã†ã«ã¯ãƒ­ã‚°ã‚¤ãƒ³ã™ã‚‹å¿…è¦ãŒã‚ã‚Šã¾ã™ã€‚";

	public VotingPanelResources_ja_jp(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForLabelAccept()
	{
		return "èªè¨¼";
	}

	protected override string _GetTemplateForLabelAccountPageTitle()
	{
		return "ã‚¢ã‚«ã‚¦ãƒ³ãƒˆ";
	}

	protected override string _GetTemplateForLabelAccountUnderDayOneMessage()
	{
		return "Robloxã‚’ã‚‚ã†å°‘ã—ä½“é¨“ã™ã‚Œã°ã€ã‚²ãƒ¼ãƒ ã‚„Studioã®ãƒ¢ãƒ‡ãƒ«ã«æŠ•ç¥¨ã§ãã‚‹ã‚ˆã†ã«ãªã‚Šã¾ã™ã€‚æ•°æ—¥å¾Œã«ã‚‚ã†ä¸€åº¦ã“ã®ãƒšãƒ¼ã‚¸ã«ã‚¢ã‚¯ã‚»ã‚¹ã—ã¦ãã ã•ã„ã€‚";
	}

	protected override string _GetTemplateForLabelAccountUnderDayOneTitle()
	{
		return "æŠ•ç¥¨è€…ãƒ•ã‚£ãƒ¼ãƒ‰ãƒãƒƒã‚¯";
	}

	protected override string _GetTemplateForLabelAssetNotVoteableMessage()
	{
		return "ã“ã®ã‚¢ã‚»ãƒƒãƒˆã«ã¯ç¾åœ¨æŠ•ç¥¨ã§ãã¾ã›ã‚“ã€‚";
	}

	protected override string _GetTemplateForLabelAssetNotVoteableTitle()
	{
		return "æŠ•ç¥¨ã§ãã¾ã›ã‚“";
	}

	protected override string _GetTemplateForLabelBuyGamePassMessage()
	{
		return "æŠ•ç¥¨ã™ã‚‹å‰ã«ã“ã®ã‚²ãƒ¼ãƒ ãƒ‘ã‚¹ã‚’æŒã£ã¦ã„ã‚‹å¿…è¦ãŒã‚ã‚Šã¾ã™ã€‚";
	}

	protected override string _GetTemplateForLabelBuyGamePassTitle()
	{
		return "ã‚²ãƒ¼ãƒ ãƒ‘ã‚¹ã‚’è²·ã†";
	}

	protected override string _GetTemplateForLabelDecline()
	{
		return "ã‚­ãƒ£ãƒ³ã‚»ãƒ«";
	}

	/// <summary>
	/// Key: "Label.EmailVerifiedMessage"
	/// English String: "You must verify your email before you can vote. You can verify your email on the {accountPageLink} page."
	/// </summary>
	public override string LabelEmailVerifiedMessage(string accountPageLink)
	{
		return $"æŠ•ç¥¨ã™ã‚‹å‰ã«ãƒ¡ãƒ¼ãƒ«ã‚¢ãƒ‰ãƒ¬ã‚¹ã®èªè¨¼ã‚’è¡Œã†å¿…è¦ãŒã‚ã‚Šã¾ã™ã€‚ãƒ¡ãƒ¼ãƒ«ã‚¢ãƒ‰ãƒ¬ã‚¹ã®èªè¨¼ã¯ã€{accountPageLink}ãƒšãƒ¼ã‚¸ã§è¡Œãˆã¾ã™ã€‚";
	}

	protected override string _GetTemplateForLabelEmailVerifiedMessage()
	{
		return "æŠ•ç¥¨ã™ã‚‹å‰ã«ãƒ¡ãƒ¼ãƒ«ã‚¢ãƒ‰ãƒ¬ã‚¹ã®èªè¨¼ã‚’è¡Œã†å¿…è¦ãŒã‚ã‚Šã¾ã™ã€‚ãƒ¡ãƒ¼ãƒ«ã‚¢ãƒ‰ãƒ¬ã‚¹ã®èªè¨¼ã¯ã€{accountPageLink}ãƒšãƒ¼ã‚¸ã§è¡Œãˆã¾ã™ã€‚";
	}

	protected override string _GetTemplateForLabelEmailVerifiedTitle()
	{
		return "ãƒ¡ãƒ¼ãƒ«ã‚¢ãƒ‰ãƒ¬ã‚¹ã‚’èªè¨¼";
	}

	protected override string _GetTemplateForLabelFloodCheckMessage()
	{
		return "é »ç¹ã«æŠ•ç¥¨ã—éŽãŽã§ã™ã€‚ã—ã°ã‚‰ãã—ã¦ã‹ã‚‰æˆ»ã£ã¦ãã¦ã‚„ã‚Šç›´ã—ã¦ãã ã•ã„ã€‚";
	}

	protected override string _GetTemplateForLabelFloodCheckTitle()
	{
		return "ãƒšãƒ¼ã‚¹ã‚’è½ã¨ã™";
	}

	/// <summary>
	/// Key: "Label.GuestUserMessage"
	/// English String: "Please {loginOrRegisterPageLink} to continue."
	/// </summary>
	public override string LabelGuestUserMessage(string loginOrRegisterPageLink)
	{
		return $"ç¶šã‘ã‚‹ã«ã¯ {loginOrRegisterPageLink} ã—ã¦ãã ã•ã„ã€‚";
	}

	protected override string _GetTemplateForLabelGuestUserMessage()
	{
		return "ç¶šã‘ã‚‹ã«ã¯ {loginOrRegisterPageLink} ã—ã¦ãã ã•ã„ã€‚";
	}

	protected override string _GetTemplateForLabelGuestUserTitle()
	{
		return "ãƒ­ã‚°ã‚¤ãƒ³ã—ã¦æŠ•ç¥¨ã™ã‚‹";
	}

	protected override string _GetTemplateForLabelInstallPluginMessage()
	{
		return "æŠ•ç¥¨ã™ã‚‹å‰ã«ã“ã®ãƒ—ãƒ©ã‚°ã‚¤ãƒ³ã‚’ã‚¤ãƒ³ã‚¹ãƒˆãƒ¼ãƒ«ã™ã‚‹å¿…è¦ãŒã‚ã‚Šã¾ã™ã€‚";
	}

	protected override string _GetTemplateForLabelInstallPluginTitle()
	{
		return "ãƒ—ãƒ©ã‚°ã‚¤ãƒ³ã®ã‚¤ãƒ³ã‚¹ãƒˆãƒ¼ãƒ«";
	}

	protected override string _GetTemplateForLabelLogin()
	{
		return "ãƒ­ã‚°ã‚¤ãƒ³";
	}

	protected override string _GetTemplateForLabelLoginOrRegisterPageTitle()
	{
		return "ãƒ­ã‚°ã‚¤ãƒ³ã¾ãŸã¯æ–°è¦ç™»éŒ²";
	}

	protected override string _GetTemplateForLabelOk()
	{
		return "OK";
	}

	protected override string _GetTemplateForLabelPlayGameMessage()
	{
		return "æŠ•ç¥¨ã™ã‚‹å‰ã«ã‚²ãƒ¼ãƒ ã‚’ãƒ—ãƒ¬ã‚¤ã™ã‚‹å¿…è¦ãŒã‚ã‚Šã¾ã™ã€‚";
	}

	protected override string _GetTemplateForLabelPlayGameTitle()
	{
		return "ã‚²ãƒ¼ãƒ ã‚’ãƒ—ãƒ¬ã‚¤";
	}

	protected override string _GetTemplateForLabelUnknownProblemMessage()
	{
		return "æŠ•ç¥¨ä¸­ã«ä¸æ˜Žãªã‚¨ãƒ©ãƒ¼ãŒç™ºç”Ÿã—ã¾ã—ãŸã€‚ã‚‚ã†ä¸€åº¦ãŠè©¦ã—ãã ã•ã„ã€‚";
	}

	protected override string _GetTemplateForLabelUnknownProblemTitle()
	{
		return "å•é¡ŒãŒç™ºç”Ÿ";
	}

	protected override string _GetTemplateForLabelUseModelMessage()
	{
		return "æŠ•ç¥¨ã™ã‚‹å‰ã«ã“ã®ãƒ¢ãƒ‡ãƒ«ã‚’ä½¿ã†å¿…è¦ãŒã‚ã‚Šã¾ã™ã€‚";
	}

	protected override string _GetTemplateForLabelUseModelTitle()
	{
		return "ãƒ¢ãƒ‡ãƒ«ã‚’ä½¿ã†";
	}

	protected override string _GetTemplateForLabelYouMustLoginToVote()
	{
		return "æŠ•ç¥¨ã‚’è¡Œã†ã«ã¯ãƒ­ã‚°ã‚¤ãƒ³ã™ã‚‹å¿…è¦ãŒã‚ã‚Šã¾ã™ã€‚";
	}
}


}
