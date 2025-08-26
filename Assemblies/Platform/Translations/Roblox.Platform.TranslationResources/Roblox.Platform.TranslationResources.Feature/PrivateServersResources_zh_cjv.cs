namespace Roblox.Platform.TranslationResources.Feature {
    /// <summary>

/// This class overrides PrivateServersResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class PrivateServersResources_zh_cjv : PrivateServersResources_en_us, IPrivateServersResources, ITranslationResources
{
	/// <summary>
	/// Key: "Action.CreateVipServer"
	/// English String: "Create VIP Server"
	/// </summary>
	public override string ActionCreateVipServer => "åˆ›å»º VIP æœåŠ¡å™¨";

	/// <summary>
	/// Key: "Action.Refresh"
	/// English String: "Refresh"
	/// </summary>
	public override string ActionRefresh => "åˆ·æ–°";

	/// <summary>
	/// Key: "Heading.InvalidLink"
	/// Dialog title when the link to a VIP server is invalid
	/// English String: "Invalid Link"
	/// </summary>
	public override string HeadingInvalidLink => "æ— æ•ˆé“¾æŽ¥";

	/// <summary>
	/// Key: "Heading.VipServers"
	/// English String: "VIP Servers"
	/// </summary>
	public override string HeadingVipServers => "VIP æœåŠ¡å™¨";

	/// <summary>
	/// Key: "Label.Cancel"
	/// English String: "Cancel"
	/// </summary>
	public override string LabelCancel => "å–æ¶ˆ";

	/// <summary>
	/// Key: "Label.GameJoinPrivateErrorTitle"
	/// Title of error window when trying to join a private server user does not have access to.
	/// English String: "Unable to join"
	/// </summary>
	public override string LabelGameJoinPrivateErrorTitle => "æ— æ³•åŠ å…¥";

	/// <summary>
	/// Key: "Label.GameName"
	/// English String: "Game Name"
	/// </summary>
	public override string LabelGameName => "æ¸¸æˆåç§°";

	/// <summary>
	/// Key: "Label.NoVipServers"
	/// No VIP Server Instances Found.
	/// English String: "No VIP Server Instances Found."
	/// </summary>
	public override string LabelNoVipServers => "æœªæ‰¾åˆ° VIP æœåŠ¡å™¨å®žä¾‹ã€‚";

	/// <summary>
	/// Key: "Label.PlayWithOthers"
	/// English String: "Play this game with friends and other people you invite."
	/// </summary>
	public override string LabelPlayWithOthers => "ä¸Žå¥½å‹å’Œä½ é‚€è¯·çš„å…¶ä»–äººåŠ å…¥æ­¤æ¸¸æˆã€‚";

	/// <summary>
	/// Key: "Label.Renew"
	/// English String: "Renew"
	/// </summary>
	public override string LabelRenew => "ç»­è®¢";

	/// <summary>
	/// Key: "Label.RenewPrivateServer"
	/// English String: "Renew Private Server"
	/// </summary>
	public override string LabelRenewPrivateServer => "ç»­è®¢ç§äººæœåŠ¡å™¨";

	/// <summary>
	/// Key: "Label.ServerName"
	/// English String: "Server Name"
	/// </summary>
	public override string LabelServerName => "æœåŠ¡å™¨åç§°";

	/// <summary>
	/// Key: "Label.Servers"
	/// English String: "Servers"
	/// </summary>
	public override string LabelServers => "æœåŠ¡å™¨";

	/// <summary>
	/// Key: "Label.VIPServerGameJoinErrorAcknowledgement"
	/// Confirmation text for game join private error dialog.
	/// English String: "OK"
	/// </summary>
	public override string LabelVIPServerGameJoinErrorAcknowledgement => "å¥½";

	/// <summary>
	/// Key: "Label.VipServerJoinGamePrivateError"
	/// Error when user wants to join a VIP server when the game is marked private
	/// English String: "You cannot join this VIP server because the game is private."
	/// </summary>
	public override string LabelVipServerJoinGamePrivateError => "ä½ æ— æ³•åŠ å…¥æ­¤ VIP æœåŠ¡å™¨ï¼Œå› ä¸ºè¿™æ˜¯ç§äººæ¸¸æˆã€‚";

	/// <summary>
	/// Key: "Label.VipServersAbout"
	/// English String: "VIP servers let you play this game privately with friends, your clan, or people you invite!"
	/// </summary>
	public override string LabelVipServersAbout => "VIP æœåŠ¡å™¨è®©ä½ å¯ä»¥ç§ä¸‹ä¸Žå¥½å‹ã€éƒ¨è½æˆ–ä½ é‚€è¯·çš„äººåŠ å…¥è¿™æ¬¾æ¸¸æˆï¼";

	/// <summary>
	/// Key: "Message.InvalidLink"
	/// Dialog content when the link to a VIP server is invalid
	/// English String: "This VIP Server link is no longer valid."
	/// </summary>
	public override string MessageInvalidLink => "æ­¤ VIP æœåŠ¡å™¨é“¾æŽ¥å·²å¤±æ•ˆã€‚";

	public PrivateServersResources_zh_cjv(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionCreateVipServer()
	{
		return "åˆ›å»º VIP æœåŠ¡å™¨";
	}

	protected override string _GetTemplateForActionRefresh()
	{
		return "åˆ·æ–°";
	}

	protected override string _GetTemplateForHeadingInvalidLink()
	{
		return "æ— æ•ˆé“¾æŽ¥";
	}

	protected override string _GetTemplateForHeadingVipServers()
	{
		return "VIP æœåŠ¡å™¨";
	}

	protected override string _GetTemplateForLabelCancel()
	{
		return "å–æ¶ˆ";
	}

	/// <summary>
	/// Key: "Label.ConfirmEnableFuturePayments"
	/// English String: "Are you sure you want to enable future payments for your private VIP version of {placeName} by {creatorName}?"
	/// </summary>
	public override string LabelConfirmEnableFuturePayments(string placeName, string creatorName)
	{
		return $"æ˜¯å¦ç¡®å®šä¸ºâ€œ{creatorName}â€æ‰€åˆ›ä½œçš„â€œ{placeName}â€å¯ç”¨ç§äºº VIP ç‰ˆæœ¬é¢„ä»˜æ¬¾ï¼Ÿ";
	}

	protected override string _GetTemplateForLabelConfirmEnableFuturePayments()
	{
		return "æ˜¯å¦ç¡®å®šä¸ºâ€œ{creatorName}â€æ‰€åˆ›ä½œçš„â€œ{placeName}â€å¯ç”¨ç§äºº VIP ç‰ˆæœ¬é¢„ä»˜æ¬¾ï¼Ÿ";
	}

	/// <summary>
	/// Key: "Label.CreateVipServerFor"
	/// English String: "Create a VIP Server for {target}?"
	/// </summary>
	public override string LabelCreateVipServerFor(string target)
	{
		return $"è¦ä¸ºâ€œ{target}â€åˆ›å»ºä¸€ä¸ª VIP æœåŠ¡å™¨ï¼Ÿ";
	}

	protected override string _GetTemplateForLabelCreateVipServerFor()
	{
		return "è¦ä¸ºâ€œ{target}â€åˆ›å»ºä¸€ä¸ª VIP æœåŠ¡å™¨ï¼Ÿ";
	}

	/// <summary>
	/// Key: "Label.FooterText"
	/// English String: "Your balance after this transaction will be {robuxIcon}. This is a subscription-based feature. It will auto-renew once a month until you cancel the subscription."
	/// </summary>
	public override string LabelFooterText(string robuxIcon)
	{
		return $"ä½ åœ¨æ­¤æ¬¡äº¤æ˜“åŽçš„ä½™é¢å°†ä¸º {robuxIcon}ã€‚è¿™æ˜¯ä¸€é¡¹åŸºäºŽè®¢é˜…çš„åŠŸèƒ½ã€‚å®ƒå°†æ¯æœˆè‡ªåŠ¨ç»­è®¢ä¸€æ¬¡ï¼Œç›´è‡³ä½ å–æ¶ˆè®¢é˜…ã€‚";
	}

	protected override string _GetTemplateForLabelFooterText()
	{
		return "ä½ åœ¨æ­¤æ¬¡äº¤æ˜“åŽçš„ä½™é¢å°†ä¸º {robuxIcon}ã€‚è¿™æ˜¯ä¸€é¡¹åŸºäºŽè®¢é˜…çš„åŠŸèƒ½ã€‚å®ƒå°†æ¯æœˆè‡ªåŠ¨ç»­è®¢ä¸€æ¬¡ï¼Œç›´è‡³ä½ å–æ¶ˆè®¢é˜…ã€‚";
	}

	protected override string _GetTemplateForLabelGameJoinPrivateErrorTitle()
	{
		return "æ— æ³•åŠ å…¥";
	}

	protected override string _GetTemplateForLabelGameName()
	{
		return "æ¸¸æˆåç§°";
	}

	protected override string _GetTemplateForLabelNoVipServers()
	{
		return "æœªæ‰¾åˆ° VIP æœåŠ¡å™¨å®žä¾‹ã€‚";
	}

	protected override string _GetTemplateForLabelPlayWithOthers()
	{
		return "ä¸Žå¥½å‹å’Œä½ é‚€è¯·çš„å…¶ä»–äººåŠ å…¥æ­¤æ¸¸æˆã€‚";
	}

	protected override string _GetTemplateForLabelRenew()
	{
		return "ç»­è®¢";
	}

	protected override string _GetTemplateForLabelRenewPrivateServer()
	{
		return "ç»­è®¢ç§äººæœåŠ¡å™¨";
	}

	/// <summary>
	/// Key: "Label.SeeAllServers"
	/// English String: "See all your VIP servers in the {serversLink} tab."
	/// </summary>
	public override string LabelSeeAllServers(string serversLink)
	{
		return $"åœ¨{serversLink}æ ‡ç­¾é¡µä¸­å¯æŸ¥çœ‹ä½ æ‰€æœ‰çš„ VIP æœåŠ¡å™¨ã€‚";
	}

	protected override string _GetTemplateForLabelSeeAllServers()
	{
		return "åœ¨{serversLink}æ ‡ç­¾é¡µä¸­å¯æŸ¥çœ‹ä½ æ‰€æœ‰çš„ VIP æœåŠ¡å™¨ã€‚";
	}

	protected override string _GetTemplateForLabelServerName()
	{
		return "æœåŠ¡å™¨åç§°";
	}

	protected override string _GetTemplateForLabelServers()
	{
		return "æœåŠ¡å™¨";
	}

	/// <summary>
	/// Key: "Label.StartRenewingPrice"
	/// English String: "This VIP Server will start renewing every month at {price} until you cancel."
	/// </summary>
	public override string LabelStartRenewingPrice(string price)
	{
		return $"æ­¤ VIP æœåŠ¡å™¨æ¯æœˆå°†ä»¥ {price} ç»­è®¢ï¼Œç›´è‡³ä½ å–æ¶ˆä¸ºæ­¢ã€‚";
	}

	protected override string _GetTemplateForLabelStartRenewingPrice()
	{
		return "æ­¤ VIP æœåŠ¡å™¨æ¯æœˆå°†ä»¥ {price} ç»­è®¢ï¼Œç›´è‡³ä½ å–æ¶ˆä¸ºæ­¢ã€‚";
	}

	protected override string _GetTemplateForLabelVIPServerGameJoinErrorAcknowledgement()
	{
		return "å¥½";
	}

	protected override string _GetTemplateForLabelVipServerJoinGamePrivateError()
	{
		return "ä½ æ— æ³•åŠ å…¥æ­¤ VIP æœåŠ¡å™¨ï¼Œå› ä¸ºè¿™æ˜¯ç§äººæ¸¸æˆã€‚";
	}

	protected override string _GetTemplateForLabelVipServersAbout()
	{
		return "VIP æœåŠ¡å™¨è®©ä½ å¯ä»¥ç§ä¸‹ä¸Žå¥½å‹ã€éƒ¨è½æˆ–ä½ é‚€è¯·çš„äººåŠ å…¥è¿™æ¬¾æ¸¸æˆï¼";
	}

	/// <summary>
	/// Key: "Label.VipServersNotSupported"
	/// English String: "This game does not support {vipServersLink}."
	/// </summary>
	public override string LabelVipServersNotSupported(string vipServersLink)
	{
		return $"æ­¤æ¸¸æˆä¸æ”¯æŒ {vipServersLink}ã€‚";
	}

	protected override string _GetTemplateForLabelVipServersNotSupported()
	{
		return "æ­¤æ¸¸æˆä¸æ”¯æŒ {vipServersLink}ã€‚";
	}

	protected override string _GetTemplateForMessageInvalidLink()
	{
		return "æ­¤ VIP æœåŠ¡å™¨é“¾æŽ¥å·²å¤±æ•ˆã€‚";
	}
}


}
