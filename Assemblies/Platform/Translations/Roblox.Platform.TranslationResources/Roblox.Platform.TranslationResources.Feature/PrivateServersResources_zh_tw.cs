namespace Roblox.Platform.TranslationResources.Feature {
    /// <summary>

/// This class overrides PrivateServersResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class PrivateServersResources_zh_tw : PrivateServersResources_en_us, IPrivateServersResources, ITranslationResources
{
	/// <summary>
	/// Key: "Action.CreateVipServer"
	/// English String: "Create VIP Server"
	/// </summary>
	public override string ActionCreateVipServer => "å»ºç«‹ VIP ä¼ºæœå™¨";

	/// <summary>
	/// Key: "Action.Refresh"
	/// English String: "Refresh"
	/// </summary>
	public override string ActionRefresh => "é‡æ–°æ•´ç†";

	/// <summary>
	/// Key: "Heading.InvalidLink"
	/// Dialog title when the link to a VIP server is invalid
	/// English String: "Invalid Link"
	/// </summary>
	public override string HeadingInvalidLink => "é€£çµç„¡æ•ˆ";

	/// <summary>
	/// Key: "Heading.VipServers"
	/// English String: "VIP Servers"
	/// </summary>
	public override string HeadingVipServers => "VIP ä¼ºæœå™¨";

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
	public override string LabelGameJoinPrivateErrorTitle => "ç„¡æ³•åŠ å…¥";

	/// <summary>
	/// Key: "Label.GameName"
	/// English String: "Game Name"
	/// </summary>
	public override string LabelGameName => "éŠæˆ²åç¨±";

	/// <summary>
	/// Key: "Label.NoVipServers"
	/// No VIP Server Instances Found.
	/// English String: "No VIP Server Instances Found."
	/// </summary>
	public override string LabelNoVipServers => "æ‰¾ä¸åˆ° VIP ä¼ºæœå™¨ã€‚";

	/// <summary>
	/// Key: "Label.PlayWithOthers"
	/// English String: "Play this game with friends and other people you invite."
	/// </summary>
	public override string LabelPlayWithOthers => "èˆ‡å¥½å‹åŠæ‚¨é‚€è«‹çš„å°è±¡çŽ©æ­¤éŠæˆ²ã€‚";

	/// <summary>
	/// Key: "Label.Renew"
	/// English String: "Renew"
	/// </summary>
	public override string LabelRenew => "çºŒè¨‚";

	/// <summary>
	/// Key: "Label.RenewPrivateServer"
	/// English String: "Renew Private Server"
	/// </summary>
	public override string LabelRenewPrivateServer => "çºŒè¨‚ç§äººä¼ºæœå™¨";

	/// <summary>
	/// Key: "Label.ServerName"
	/// English String: "Server Name"
	/// </summary>
	public override string LabelServerName => "ä¼ºæœå™¨åç¨±";

	/// <summary>
	/// Key: "Label.Servers"
	/// English String: "Servers"
	/// </summary>
	public override string LabelServers => "ä¼ºæœå™¨";

	/// <summary>
	/// Key: "Label.VIPServerGameJoinErrorAcknowledgement"
	/// Confirmation text for game join private error dialog.
	/// English String: "OK"
	/// </summary>
	public override string LabelVIPServerGameJoinErrorAcknowledgement => "ç¢ºå®š";

	/// <summary>
	/// Key: "Label.VipServerJoinGamePrivateError"
	/// Error when user wants to join a VIP server when the game is marked private
	/// English String: "You cannot join this VIP server because the game is private."
	/// </summary>
	public override string LabelVipServerJoinGamePrivateError => "æ­¤éŠæˆ²è¨­ç‚ºç§äººï¼Œæ‚¨ç„¡æ³•åŠ å…¥æ­¤ VIP ä¼ºæœå™¨ã€‚";

	/// <summary>
	/// Key: "Label.VipServersAbout"
	/// English String: "VIP servers let you play this game privately with friends, your clan, or people you invite!"
	/// </summary>
	public override string LabelVipServersAbout => "VIP ä¼ºæœå™¨èƒ½è®“æ‚¨ç§ä¸‹èˆ‡å¥½å‹ã€å…¬æœƒæˆ–æ‚¨é‚€è«‹çš„å°è±¡çŽ©æ­¤éŠæˆ²ï¼";

	/// <summary>
	/// Key: "Message.InvalidLink"
	/// Dialog content when the link to a VIP server is invalid
	/// English String: "This VIP Server link is no longer valid."
	/// </summary>
	public override string MessageInvalidLink => "æ­¤ VIP ä¼ºæœå™¨é€£çµå·²å¤±æ•ˆã€‚";

	public PrivateServersResources_zh_tw(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionCreateVipServer()
	{
		return "å»ºç«‹ VIP ä¼ºæœå™¨";
	}

	protected override string _GetTemplateForActionRefresh()
	{
		return "é‡æ–°æ•´ç†";
	}

	protected override string _GetTemplateForHeadingInvalidLink()
	{
		return "é€£çµç„¡æ•ˆ";
	}

	protected override string _GetTemplateForHeadingVipServers()
	{
		return "VIP ä¼ºæœå™¨";
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
		return $"ç¢ºå®šç‚º {creatorName} æ‰€å‰µä½œçš„ {placeName} å•Ÿç”¨ç§äºº VIP ç‰ˆæœ¬é æœŸä»˜æ¬¾ï¼Ÿ";
	}

	protected override string _GetTemplateForLabelConfirmEnableFuturePayments()
	{
		return "ç¢ºå®šç‚º {creatorName} æ‰€å‰µä½œçš„ {placeName} å•Ÿç”¨ç§äºº VIP ç‰ˆæœ¬é æœŸä»˜æ¬¾ï¼Ÿ";
	}

	/// <summary>
	/// Key: "Label.CreateVipServerFor"
	/// English String: "Create a VIP Server for {target}?"
	/// </summary>
	public override string LabelCreateVipServerFor(string target)
	{
		return $"ä»¥ {target} å»ºç«‹ VIP ä¼ºæœå™¨ï¼Ÿ";
	}

	protected override string _GetTemplateForLabelCreateVipServerFor()
	{
		return "ä»¥ {target} å»ºç«‹ VIP ä¼ºæœå™¨ï¼Ÿ";
	}

	/// <summary>
	/// Key: "Label.FooterText"
	/// English String: "Your balance after this transaction will be {robuxIcon}. This is a subscription-based feature. It will auto-renew once a month until you cancel the subscription."
	/// </summary>
	public override string LabelFooterText(string robuxIcon)
	{
		return $"æ‚¨åœ¨æ­¤äº¤æ˜“å¾Œçš„é¤˜é¡å°‡ç‚º {robuxIcon}ã€‚æ­¤è¨‚é–±å°‡æœƒæ¯æœˆè‡ªå‹•çºŒè¨‚ä¸€æ¬¡ï¼Œç›´åˆ°æ‚¨å–æ¶ˆè¨‚é–±ç‚ºæ­¢ã€‚";
	}

	protected override string _GetTemplateForLabelFooterText()
	{
		return "æ‚¨åœ¨æ­¤äº¤æ˜“å¾Œçš„é¤˜é¡å°‡ç‚º {robuxIcon}ã€‚æ­¤è¨‚é–±å°‡æœƒæ¯æœˆè‡ªå‹•çºŒè¨‚ä¸€æ¬¡ï¼Œç›´åˆ°æ‚¨å–æ¶ˆè¨‚é–±ç‚ºæ­¢ã€‚";
	}

	protected override string _GetTemplateForLabelGameJoinPrivateErrorTitle()
	{
		return "ç„¡æ³•åŠ å…¥";
	}

	protected override string _GetTemplateForLabelGameName()
	{
		return "éŠæˆ²åç¨±";
	}

	protected override string _GetTemplateForLabelNoVipServers()
	{
		return "æ‰¾ä¸åˆ° VIP ä¼ºæœå™¨ã€‚";
	}

	protected override string _GetTemplateForLabelPlayWithOthers()
	{
		return "èˆ‡å¥½å‹åŠæ‚¨é‚€è«‹çš„å°è±¡çŽ©æ­¤éŠæˆ²ã€‚";
	}

	protected override string _GetTemplateForLabelRenew()
	{
		return "çºŒè¨‚";
	}

	protected override string _GetTemplateForLabelRenewPrivateServer()
	{
		return "çºŒè¨‚ç§äººä¼ºæœå™¨";
	}

	/// <summary>
	/// Key: "Label.SeeAllServers"
	/// English String: "See all your VIP servers in the {serversLink} tab."
	/// </summary>
	public override string LabelSeeAllServers(string serversLink)
	{
		return $"å¯ä»¥åœ¨{serversLink}æ¨™ç±¤æª¢è¦–æ‚¨æ‰€æœ‰çš„ VIP ä¼ºæœå™¨ã€‚";
	}

	protected override string _GetTemplateForLabelSeeAllServers()
	{
		return "å¯ä»¥åœ¨{serversLink}æ¨™ç±¤æª¢è¦–æ‚¨æ‰€æœ‰çš„ VIP ä¼ºæœå™¨ã€‚";
	}

	protected override string _GetTemplateForLabelServerName()
	{
		return "ä¼ºæœå™¨åç¨±";
	}

	protected override string _GetTemplateForLabelServers()
	{
		return "ä¼ºæœå™¨";
	}

	/// <summary>
	/// Key: "Label.StartRenewingPrice"
	/// English String: "This VIP Server will start renewing every month at {price} until you cancel."
	/// </summary>
	public override string LabelStartRenewingPrice(string price)
	{
		return $"æ­¤ VIP ä¼ºæœå™¨å°‡æœƒæ¯æœˆä»¥ {price} çºŒè¨‚ï¼Œç›´åˆ°æ‚¨å–æ¶ˆç‚ºæ­¢ã€‚";
	}

	protected override string _GetTemplateForLabelStartRenewingPrice()
	{
		return "æ­¤ VIP ä¼ºæœå™¨å°‡æœƒæ¯æœˆä»¥ {price} çºŒè¨‚ï¼Œç›´åˆ°æ‚¨å–æ¶ˆç‚ºæ­¢ã€‚";
	}

	protected override string _GetTemplateForLabelVIPServerGameJoinErrorAcknowledgement()
	{
		return "ç¢ºå®š";
	}

	protected override string _GetTemplateForLabelVipServerJoinGamePrivateError()
	{
		return "æ­¤éŠæˆ²è¨­ç‚ºç§äººï¼Œæ‚¨ç„¡æ³•åŠ å…¥æ­¤ VIP ä¼ºæœå™¨ã€‚";
	}

	protected override string _GetTemplateForLabelVipServersAbout()
	{
		return "VIP ä¼ºæœå™¨èƒ½è®“æ‚¨ç§ä¸‹èˆ‡å¥½å‹ã€å…¬æœƒæˆ–æ‚¨é‚€è«‹çš„å°è±¡çŽ©æ­¤éŠæˆ²ï¼";
	}

	/// <summary>
	/// Key: "Label.VipServersNotSupported"
	/// English String: "This game does not support {vipServersLink}."
	/// </summary>
	public override string LabelVipServersNotSupported(string vipServersLink)
	{
		return $"æ­¤éŠæˆ²ä¸æ”¯æ´ {vipServersLink}ã€‚";
	}

	protected override string _GetTemplateForLabelVipServersNotSupported()
	{
		return "æ­¤éŠæˆ²ä¸æ”¯æ´ {vipServersLink}ã€‚";
	}

	protected override string _GetTemplateForMessageInvalidLink()
	{
		return "æ­¤ VIP ä¼ºæœå™¨é€£çµå·²å¤±æ•ˆã€‚";
	}
}


}
