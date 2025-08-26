namespace Roblox.Platform.TranslationResources.Feature {
    /// <summary>

/// This class overrides PrivateServersResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class PrivateServersResources_ja_jp : PrivateServersResources_en_us, IPrivateServersResources, ITranslationResources
{
	/// <summary>
	/// Key: "Action.CreateVipServer"
	/// English String: "Create VIP Server"
	/// </summary>
	public override string ActionCreateVipServer => "VIPã‚µãƒ¼ãƒãƒ¼ã®ä½œæˆ";

	/// <summary>
	/// Key: "Action.Refresh"
	/// English String: "Refresh"
	/// </summary>
	public override string ActionRefresh => "ãƒªãƒ•ãƒ¬ãƒƒã‚·ãƒ¥";

	/// <summary>
	/// Key: "Heading.InvalidLink"
	/// Dialog title when the link to a VIP server is invalid
	/// English String: "Invalid Link"
	/// </summary>
	public override string HeadingInvalidLink => "ç„¡åŠ¹ãªãƒªãƒ³ã‚¯";

	/// <summary>
	/// Key: "Heading.VipServers"
	/// English String: "VIP Servers"
	/// </summary>
	public override string HeadingVipServers => "VIPã‚µãƒ¼ãƒãƒ¼";

	/// <summary>
	/// Key: "Label.Cancel"
	/// English String: "Cancel"
	/// </summary>
	public override string LabelCancel => "ã‚­ãƒ£ãƒ³ã‚»ãƒ«";

	/// <summary>
	/// Key: "Label.GameJoinPrivateErrorTitle"
	/// Title of error window when trying to join a private server user does not have access to.
	/// English String: "Unable to join"
	/// </summary>
	public override string LabelGameJoinPrivateErrorTitle => "å‚åŠ ã§ãã¾ã›ã‚“";

	/// <summary>
	/// Key: "Label.GameName"
	/// English String: "Game Name"
	/// </summary>
	public override string LabelGameName => "ã‚²ãƒ¼ãƒ å";

	/// <summary>
	/// Key: "Label.NoVipServers"
	/// No VIP Server Instances Found.
	/// English String: "No VIP Server Instances Found."
	/// </summary>
	public override string LabelNoVipServers => "VIPã‚µãƒ¼ãƒãƒ¼ã®ã‚¤ãƒ³ã‚¹ã‚¿ãƒ³ã‚¹ãŒè¦‹ã¤ã‹ã‚Šã¾ã›ã‚“ã€‚";

	/// <summary>
	/// Key: "Label.PlayWithOthers"
	/// English String: "Play this game with friends and other people you invite."
	/// </summary>
	public override string LabelPlayWithOthers => "å‹é”ã‚„æ‹›å¾…ã—ãŸãƒ—ãƒ¬ã‚¤ãƒ¤ãƒ¼ã¨ä¸€ç·’ã«ã€ã“ã®ã‚²ãƒ¼ãƒ ã‚’ãƒ—ãƒ¬ã‚¤ã—ã‚ˆã†ã€‚";

	/// <summary>
	/// Key: "Label.Renew"
	/// English String: "Renew"
	/// </summary>
	public override string LabelRenew => "æ›´æ–°";

	/// <summary>
	/// Key: "Label.RenewPrivateServer"
	/// English String: "Renew Private Server"
	/// </summary>
	public override string LabelRenewPrivateServer => "ãƒ—ãƒ©ã‚¤ãƒ™ãƒ¼ãƒˆã‚µãƒ¼ãƒãƒ¼ã‚’æ›´æ–°";

	/// <summary>
	/// Key: "Label.ServerName"
	/// English String: "Server Name"
	/// </summary>
	public override string LabelServerName => "ã‚µãƒ¼ãƒãƒ¼å";

	/// <summary>
	/// Key: "Label.Servers"
	/// English String: "Servers"
	/// </summary>
	public override string LabelServers => "ã‚µãƒ¼ãƒãƒ¼";

	/// <summary>
	/// Key: "Label.VIPServerGameJoinErrorAcknowledgement"
	/// Confirmation text for game join private error dialog.
	/// English String: "OK"
	/// </summary>
	public override string LabelVIPServerGameJoinErrorAcknowledgement => "OK";

	/// <summary>
	/// Key: "Label.VipServerJoinGamePrivateError"
	/// Error when user wants to join a VIP server when the game is marked private
	/// English String: "You cannot join this VIP server because the game is private."
	/// </summary>
	public override string LabelVipServerJoinGamePrivateError => "ã‚²ãƒ¼ãƒ ãŒãƒ—ãƒ©ã‚¤ãƒ™ãƒ¼ãƒˆè¨­å®šã«ãªã£ã¦ã„ã‚‹ãŸã‚ã€ã“ã®VIPã‚µãƒ¼ãƒãƒ¼ã«å‚åŠ ã§ãã¾ã›ã‚“ã€‚";

	/// <summary>
	/// Key: "Label.VipServersAbout"
	/// English String: "VIP servers let you play this game privately with friends, your clan, or people you invite!"
	/// </summary>
	public override string LabelVipServersAbout => "VIPã‚µãƒ¼ãƒãƒ¼ã¯ã€ã“ã®ã‚²ãƒ¼ãƒ ã‚’å‹é”ã€ã‚¯ãƒ©ãƒ³ã€æ‹›å¾…ã—ãŸãƒ—ãƒ¬ã‚¤ãƒ¤ãƒ¼ãªã©ã¨ä¸€ç·’ã«éžå…¬é–‹ã§ãƒ—ãƒ¬ã‚¤ã§ãã¾ã™ï¼";

	/// <summary>
	/// Key: "Message.InvalidLink"
	/// Dialog content when the link to a VIP server is invalid
	/// English String: "This VIP Server link is no longer valid."
	/// </summary>
	public override string MessageInvalidLink => "ã“ã®VIPã‚µãƒ¼ãƒãƒ¼ã®ãƒªãƒ³ã‚¯ã¯ç„¡åŠ¹ã«ãªã‚Šã¾ã—ãŸã€‚";

	public PrivateServersResources_ja_jp(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionCreateVipServer()
	{
		return "VIPã‚µãƒ¼ãƒãƒ¼ã®ä½œæˆ";
	}

	protected override string _GetTemplateForActionRefresh()
	{
		return "ãƒªãƒ•ãƒ¬ãƒƒã‚·ãƒ¥";
	}

	protected override string _GetTemplateForHeadingInvalidLink()
	{
		return "ç„¡åŠ¹ãªãƒªãƒ³ã‚¯";
	}

	protected override string _GetTemplateForHeadingVipServers()
	{
		return "VIPã‚µãƒ¼ãƒãƒ¼";
	}

	protected override string _GetTemplateForLabelCancel()
	{
		return "ã‚­ãƒ£ãƒ³ã‚»ãƒ«";
	}

	/// <summary>
	/// Key: "Label.ConfirmEnableFuturePayments"
	/// English String: "Are you sure you want to enable future payments for your private VIP version of {placeName} by {creatorName}?"
	/// </summary>
	public override string LabelConfirmEnableFuturePayments(string placeName, string creatorName)
	{
		return $"{creatorName} ã•ã‚“ãŒä½œã£ãŸ {placeName} ã®ãƒ—ãƒ©ã‚¤ãƒ™ãƒ¼ãƒˆVIPãƒãƒ¼ã‚¸ãƒ§ãƒ³ã¸ã®ä»Šå¾Œã®æ”¯æ‰•ã„ã‚’æœ‰åŠ¹ã«ã—ã¦ã‚ˆã‚ã—ã„ã§ã™ã‹ï¼Ÿ";
	}

	protected override string _GetTemplateForLabelConfirmEnableFuturePayments()
	{
		return "{creatorName} ã•ã‚“ãŒä½œã£ãŸ {placeName} ã®ãƒ—ãƒ©ã‚¤ãƒ™ãƒ¼ãƒˆVIPãƒãƒ¼ã‚¸ãƒ§ãƒ³ã¸ã®ä»Šå¾Œã®æ”¯æ‰•ã„ã‚’æœ‰åŠ¹ã«ã—ã¦ã‚ˆã‚ã—ã„ã§ã™ã‹ï¼Ÿ";
	}

	/// <summary>
	/// Key: "Label.CreateVipServerFor"
	/// English String: "Create a VIP Server for {target}?"
	/// </summary>
	public override string LabelCreateVipServerFor(string target)
	{
		return $"{target} ã®VIPã‚µãƒ¼ãƒãƒ¼ã‚’ä½œã‚Šã¾ã™ã‹ï¼Ÿ";
	}

	protected override string _GetTemplateForLabelCreateVipServerFor()
	{
		return "{target} ã®VIPã‚µãƒ¼ãƒãƒ¼ã‚’ä½œã‚Šã¾ã™ã‹ï¼Ÿ";
	}

	/// <summary>
	/// Key: "Label.FooterText"
	/// English String: "Your balance after this transaction will be {robuxIcon}. This is a subscription-based feature. It will auto-renew once a month until you cancel the subscription."
	/// </summary>
	public override string LabelFooterText(string robuxIcon)
	{
		return $"å–å¼•å¾Œã®æ®‹é«˜ã¯{robuxIcon}ã«ãªã‚Šã¾ã™ã€‚ã“ã‚Œã¯ã‚µãƒ–ã‚¹ã‚¯ãƒªãƒ—ã‚·ãƒ§ãƒ³æ–¹å¼ã®æ©Ÿèƒ½ã§ã™ã€‚ã‚µãƒ–ã‚¹ã‚¯ãƒªãƒ—ã‚·ãƒ§ãƒ³ã‚’ã‚­ãƒ£ãƒ³ã‚»ãƒ«ã™ã‚‹ã¾ã§ã€æ¯Žæœˆ1åº¦è‡ªå‹•æ›´æ–°ã•ã‚Œã¾ã™ã€‚";
	}

	protected override string _GetTemplateForLabelFooterText()
	{
		return "å–å¼•å¾Œã®æ®‹é«˜ã¯{robuxIcon}ã«ãªã‚Šã¾ã™ã€‚ã“ã‚Œã¯ã‚µãƒ–ã‚¹ã‚¯ãƒªãƒ—ã‚·ãƒ§ãƒ³æ–¹å¼ã®æ©Ÿèƒ½ã§ã™ã€‚ã‚µãƒ–ã‚¹ã‚¯ãƒªãƒ—ã‚·ãƒ§ãƒ³ã‚’ã‚­ãƒ£ãƒ³ã‚»ãƒ«ã™ã‚‹ã¾ã§ã€æ¯Žæœˆ1åº¦è‡ªå‹•æ›´æ–°ã•ã‚Œã¾ã™ã€‚";
	}

	protected override string _GetTemplateForLabelGameJoinPrivateErrorTitle()
	{
		return "å‚åŠ ã§ãã¾ã›ã‚“";
	}

	protected override string _GetTemplateForLabelGameName()
	{
		return "ã‚²ãƒ¼ãƒ å";
	}

	protected override string _GetTemplateForLabelNoVipServers()
	{
		return "VIPã‚µãƒ¼ãƒãƒ¼ã®ã‚¤ãƒ³ã‚¹ã‚¿ãƒ³ã‚¹ãŒè¦‹ã¤ã‹ã‚Šã¾ã›ã‚“ã€‚";
	}

	protected override string _GetTemplateForLabelPlayWithOthers()
	{
		return "å‹é”ã‚„æ‹›å¾…ã—ãŸãƒ—ãƒ¬ã‚¤ãƒ¤ãƒ¼ã¨ä¸€ç·’ã«ã€ã“ã®ã‚²ãƒ¼ãƒ ã‚’ãƒ—ãƒ¬ã‚¤ã—ã‚ˆã†ã€‚";
	}

	protected override string _GetTemplateForLabelRenew()
	{
		return "æ›´æ–°";
	}

	protected override string _GetTemplateForLabelRenewPrivateServer()
	{
		return "ãƒ—ãƒ©ã‚¤ãƒ™ãƒ¼ãƒˆã‚µãƒ¼ãƒãƒ¼ã‚’æ›´æ–°";
	}

	/// <summary>
	/// Key: "Label.SeeAllServers"
	/// English String: "See all your VIP servers in the {serversLink} tab."
	/// </summary>
	public override string LabelSeeAllServers(string serversLink)
	{
		return $"{serversLink} ã‚¿ãƒ–ã§ã€ã”è‡ªåˆ†ã®ã™ã¹ã¦ã®VIPã‚µãƒ¼ãƒãƒ¼ã‚’è¦‹ã‚Œã¾ã™ã€‚";
	}

	protected override string _GetTemplateForLabelSeeAllServers()
	{
		return "{serversLink} ã‚¿ãƒ–ã§ã€ã”è‡ªåˆ†ã®ã™ã¹ã¦ã®VIPã‚µãƒ¼ãƒãƒ¼ã‚’è¦‹ã‚Œã¾ã™ã€‚";
	}

	protected override string _GetTemplateForLabelServerName()
	{
		return "ã‚µãƒ¼ãƒãƒ¼å";
	}

	protected override string _GetTemplateForLabelServers()
	{
		return "ã‚µãƒ¼ãƒãƒ¼";
	}

	/// <summary>
	/// Key: "Label.StartRenewingPrice"
	/// English String: "This VIP Server will start renewing every month at {price} until you cancel."
	/// </summary>
	public override string LabelStartRenewingPrice(string price)
	{
		return $"ã“ã®VIPã‚µãƒ¼ãƒãƒ¼ã¯ã€ã‚­ãƒ£ãƒ³ã‚»ãƒ«ã—ãªã„é™ã‚Šæ¯Žæœˆ{price}ã§æ›´æ–°ã•ã‚Œã¾ã™ã€‚";
	}

	protected override string _GetTemplateForLabelStartRenewingPrice()
	{
		return "ã“ã®VIPã‚µãƒ¼ãƒãƒ¼ã¯ã€ã‚­ãƒ£ãƒ³ã‚»ãƒ«ã—ãªã„é™ã‚Šæ¯Žæœˆ{price}ã§æ›´æ–°ã•ã‚Œã¾ã™ã€‚";
	}

	protected override string _GetTemplateForLabelVIPServerGameJoinErrorAcknowledgement()
	{
		return "OK";
	}

	protected override string _GetTemplateForLabelVipServerJoinGamePrivateError()
	{
		return "ã‚²ãƒ¼ãƒ ãŒãƒ—ãƒ©ã‚¤ãƒ™ãƒ¼ãƒˆè¨­å®šã«ãªã£ã¦ã„ã‚‹ãŸã‚ã€ã“ã®VIPã‚µãƒ¼ãƒãƒ¼ã«å‚åŠ ã§ãã¾ã›ã‚“ã€‚";
	}

	protected override string _GetTemplateForLabelVipServersAbout()
	{
		return "VIPã‚µãƒ¼ãƒãƒ¼ã¯ã€ã“ã®ã‚²ãƒ¼ãƒ ã‚’å‹é”ã€ã‚¯ãƒ©ãƒ³ã€æ‹›å¾…ã—ãŸãƒ—ãƒ¬ã‚¤ãƒ¤ãƒ¼ãªã©ã¨ä¸€ç·’ã«éžå…¬é–‹ã§ãƒ—ãƒ¬ã‚¤ã§ãã¾ã™ï¼";
	}

	/// <summary>
	/// Key: "Label.VipServersNotSupported"
	/// English String: "This game does not support {vipServersLink}."
	/// </summary>
	public override string LabelVipServersNotSupported(string vipServersLink)
	{
		return $"ã“ã®ã‚²ãƒ¼ãƒ ã¯ {vipServersLink} ã«å¯¾å¿œã—ã¦ã„ã¾ã›ã‚“ã€‚";
	}

	protected override string _GetTemplateForLabelVipServersNotSupported()
	{
		return "ã“ã®ã‚²ãƒ¼ãƒ ã¯ {vipServersLink} ã«å¯¾å¿œã—ã¦ã„ã¾ã›ã‚“ã€‚";
	}

	protected override string _GetTemplateForMessageInvalidLink()
	{
		return "ã“ã®VIPã‚µãƒ¼ãƒãƒ¼ã®ãƒªãƒ³ã‚¯ã¯ç„¡åŠ¹ã«ãªã‚Šã¾ã—ãŸã€‚";
	}
}


}
