namespace Roblox.Platform.TranslationResources.Feature {
    /// <summary>

/// This class overrides PrivateServersResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class PrivateServersResources_ko_kr : PrivateServersResources_en_us, IPrivateServersResources, ITranslationResources
{
	/// <summary>
	/// Key: "Action.CreateVipServer"
	/// English String: "Create VIP Server"
	/// </summary>
	public override string ActionCreateVipServer => "VIP ì„œë²„ ë§Œë“¤ê¸°";

	/// <summary>
	/// Key: "Action.Refresh"
	/// English String: "Refresh"
	/// </summary>
	public override string ActionRefresh => "ìƒˆë¡œ ê³ ì¹¨";

	/// <summary>
	/// Key: "Heading.InvalidLink"
	/// Dialog title when the link to a VIP server is invalid
	/// English String: "Invalid Link"
	/// </summary>
	public override string HeadingInvalidLink => "ìœ íš¨í•˜ì§€ ì•Šì€ ë§í¬";

	/// <summary>
	/// Key: "Heading.VipServers"
	/// English String: "VIP Servers"
	/// </summary>
	public override string HeadingVipServers => "VIP ì„œë²„";

	/// <summary>
	/// Key: "Label.Cancel"
	/// English String: "Cancel"
	/// </summary>
	public override string LabelCancel => "ì·¨ì†Œ";

	/// <summary>
	/// Key: "Label.GameJoinPrivateErrorTitle"
	/// Title of error window when trying to join a private server user does not have access to.
	/// English String: "Unable to join"
	/// </summary>
	public override string LabelGameJoinPrivateErrorTitle => "ì°¸ê°€ ë¶ˆê°€";

	/// <summary>
	/// Key: "Label.GameName"
	/// English String: "Game Name"
	/// </summary>
	public override string LabelGameName => "ê²Œìž„ ì´ë¦„";

	/// <summary>
	/// Key: "Label.NoVipServers"
	/// No VIP Server Instances Found.
	/// English String: "No VIP Server Instances Found."
	/// </summary>
	public override string LabelNoVipServers => "VIP ì„œë²„ ì¸ìŠ¤í„´ìŠ¤ë¥¼ ì°¾ì„ ìˆ˜ ì—†ì–´ìš”.";

	/// <summary>
	/// Key: "Label.PlayWithOthers"
	/// English String: "Play this game with friends and other people you invite."
	/// </summary>
	public override string LabelPlayWithOthers => "ì¹œêµ¬ë¿ ì•„ë‹ˆë¼ ë‹¤ë¥¸ ì‚¬ëžŒë“¤ë„ ì´ˆëŒ€í•´ í•¨ê»˜ ê²Œìž„ì„ ì¦ê²¨ë³´ì„¸ìš”.";

	/// <summary>
	/// Key: "Label.Renew"
	/// English String: "Renew"
	/// </summary>
	public override string LabelRenew => "ê°±ì‹ ";

	/// <summary>
	/// Key: "Label.RenewPrivateServer"
	/// English String: "Renew Private Server"
	/// </summary>
	public override string LabelRenewPrivateServer => "ë¹„ê³µê°œ ì„œë²„ ê°±ì‹ ";

	/// <summary>
	/// Key: "Label.ServerName"
	/// English String: "Server Name"
	/// </summary>
	public override string LabelServerName => "ì„œë²„ ì´ë¦„";

	/// <summary>
	/// Key: "Label.Servers"
	/// English String: "Servers"
	/// </summary>
	public override string LabelServers => "ì„œë²„";

	/// <summary>
	/// Key: "Label.VIPServerGameJoinErrorAcknowledgement"
	/// Confirmation text for game join private error dialog.
	/// English String: "OK"
	/// </summary>
	public override string LabelVIPServerGameJoinErrorAcknowledgement => "í™•ì¸";

	/// <summary>
	/// Key: "Label.VipServerJoinGamePrivateError"
	/// Error when user wants to join a VIP server when the game is marked private
	/// English String: "You cannot join this VIP server because the game is private."
	/// </summary>
	public override string LabelVipServerJoinGamePrivateError => "ë¹„ê³µê°œ ê²Œìž„ì´ë¯€ë¡œ ë³¸ VIP ì„œë²„ì— ì—°ê²°í•  ìˆ˜ ì—†ì–´ìš”.";

	/// <summary>
	/// Key: "Label.VipServersAbout"
	/// English String: "VIP servers let you play this game privately with friends, your clan, or people you invite!"
	/// </summary>
	public override string LabelVipServersAbout => "VIP ì„œë²„ì—ì„œëŠ” ì¹œêµ¬, í´ëžœ í˜¹ì€ ì´ˆëŒ€í•œ ì‚¬ëžŒë“¤ê³¼ í•¨ê»˜ ë¹„ê³µê°œë¡œ ê²Œìž„ì„ ì¦ê¸¸ ìˆ˜ ìžˆì–´ìš”!";

	/// <summary>
	/// Key: "Message.InvalidLink"
	/// Dialog content when the link to a VIP server is invalid
	/// English String: "This VIP Server link is no longer valid."
	/// </summary>
	public override string MessageInvalidLink => "VIP ì„œë²„ ë§í¬ê°€ ë” ì´ìƒ ìœ íš¨í•˜ì§€ ì•ŠìŠµë‹ˆë‹¤.";

	public PrivateServersResources_ko_kr(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionCreateVipServer()
	{
		return "VIP ì„œë²„ ë§Œë“¤ê¸°";
	}

	protected override string _GetTemplateForActionRefresh()
	{
		return "ìƒˆë¡œ ê³ ì¹¨";
	}

	protected override string _GetTemplateForHeadingInvalidLink()
	{
		return "ìœ íš¨í•˜ì§€ ì•Šì€ ë§í¬";
	}

	protected override string _GetTemplateForHeadingVipServers()
	{
		return "VIP ì„œë²„";
	}

	protected override string _GetTemplateForLabelCancel()
	{
		return "ì·¨ì†Œ";
	}

	/// <summary>
	/// Key: "Label.ConfirmEnableFuturePayments"
	/// English String: "Are you sure you want to enable future payments for your private VIP version of {placeName} by {creatorName}?"
	/// </summary>
	public override string LabelConfirmEnableFuturePayments(string placeName, string creatorName)
	{
		return $"{creatorName}ë‹˜ì´ ë§Œë“  {placeName} ë¹„ê³µê°œ VIP ë²„ì „ì— ëŒ€í•œ í–¥í›„ ê²°ì œë¥¼ ì •ë§ í™œì„±í™”í•˜ì‹œê² ìŠµë‹ˆê¹Œ?";
	}

	protected override string _GetTemplateForLabelConfirmEnableFuturePayments()
	{
		return "{creatorName}ë‹˜ì´ ë§Œë“  {placeName} ë¹„ê³µê°œ VIP ë²„ì „ì— ëŒ€í•œ í–¥í›„ ê²°ì œë¥¼ ì •ë§ í™œì„±í™”í•˜ì‹œê² ìŠµë‹ˆê¹Œ?";
	}

	/// <summary>
	/// Key: "Label.CreateVipServerFor"
	/// English String: "Create a VIP Server for {target}?"
	/// </summary>
	public override string LabelCreateVipServerFor(string target)
	{
		return $"{target}ì„(ë¥¼) ìœ„í•œ VIP ì„œë²„ë¥¼ ë§Œë“¤ê¹Œìš”?";
	}

	protected override string _GetTemplateForLabelCreateVipServerFor()
	{
		return "{target}ì„(ë¥¼) ìœ„í•œ VIP ì„œë²„ë¥¼ ë§Œë“¤ê¹Œìš”?";
	}

	/// <summary>
	/// Key: "Label.FooterText"
	/// English String: "Your balance after this transaction will be {robuxIcon}. This is a subscription-based feature. It will auto-renew once a month until you cancel the subscription."
	/// </summary>
	public override string LabelFooterText(string robuxIcon)
	{
		return $"ë³¸ ê±°ëž˜ í›„ì˜ ì˜ˆìƒ ìž”ì•¡ì€ {robuxIcon}ìž…ë‹ˆë‹¤. ë³¸ ê¸°ëŠ¥ì€ ê°€ìž…ì„ í•˜ì…”ì•¼ ì‚¬ìš©í•  ìˆ˜ ìžˆëŠ” ê¸°ëŠ¥ìœ¼ë¡œ ì·¨ì†Œí•  ë•Œê¹Œì§€ ë§¤ë‹¬ ìžë™ìœ¼ë¡œ ê°±ì‹ ë©ë‹ˆë‹¤.";
	}

	protected override string _GetTemplateForLabelFooterText()
	{
		return "ë³¸ ê±°ëž˜ í›„ì˜ ì˜ˆìƒ ìž”ì•¡ì€ {robuxIcon}ìž…ë‹ˆë‹¤. ë³¸ ê¸°ëŠ¥ì€ ê°€ìž…ì„ í•˜ì…”ì•¼ ì‚¬ìš©í•  ìˆ˜ ìžˆëŠ” ê¸°ëŠ¥ìœ¼ë¡œ ì·¨ì†Œí•  ë•Œê¹Œì§€ ë§¤ë‹¬ ìžë™ìœ¼ë¡œ ê°±ì‹ ë©ë‹ˆë‹¤.";
	}

	protected override string _GetTemplateForLabelGameJoinPrivateErrorTitle()
	{
		return "ì°¸ê°€ ë¶ˆê°€";
	}

	protected override string _GetTemplateForLabelGameName()
	{
		return "ê²Œìž„ ì´ë¦„";
	}

	protected override string _GetTemplateForLabelNoVipServers()
	{
		return "VIP ì„œë²„ ì¸ìŠ¤í„´ìŠ¤ë¥¼ ì°¾ì„ ìˆ˜ ì—†ì–´ìš”.";
	}

	protected override string _GetTemplateForLabelPlayWithOthers()
	{
		return "ì¹œêµ¬ë¿ ì•„ë‹ˆë¼ ë‹¤ë¥¸ ì‚¬ëžŒë“¤ë„ ì´ˆëŒ€í•´ í•¨ê»˜ ê²Œìž„ì„ ì¦ê²¨ë³´ì„¸ìš”.";
	}

	protected override string _GetTemplateForLabelRenew()
	{
		return "ê°±ì‹ ";
	}

	protected override string _GetTemplateForLabelRenewPrivateServer()
	{
		return "ë¹„ê³µê°œ ì„œë²„ ê°±ì‹ ";
	}

	/// <summary>
	/// Key: "Label.SeeAllServers"
	/// English String: "See all your VIP servers in the {serversLink} tab."
	/// </summary>
	public override string LabelSeeAllServers(string serversLink)
	{
		return $"{serversLink} íƒ­ì—ì„œ ë³¸ì¸ì˜ VIP ì„œë²„ë¥¼ ëª¨ë‘ í™•ì¸í•˜ì‹¤ ìˆ˜ ìžˆìŠµë‹ˆë‹¤. ";
	}

	protected override string _GetTemplateForLabelSeeAllServers()
	{
		return "{serversLink} íƒ­ì—ì„œ ë³¸ì¸ì˜ VIP ì„œë²„ë¥¼ ëª¨ë‘ í™•ì¸í•˜ì‹¤ ìˆ˜ ìžˆìŠµë‹ˆë‹¤. ";
	}

	protected override string _GetTemplateForLabelServerName()
	{
		return "ì„œë²„ ì´ë¦„";
	}

	protected override string _GetTemplateForLabelServers()
	{
		return "ì„œë²„";
	}

	/// <summary>
	/// Key: "Label.StartRenewingPrice"
	/// English String: "This VIP Server will start renewing every month at {price} until you cancel."
	/// </summary>
	public override string LabelStartRenewingPrice(string price)
	{
		return $"ë³¸ VIP ì„œë²„ëŠ” ì·¨ì†Œí•  ë•Œê¹Œì§€ ë§¤ë‹¬ {price} ì˜ ê°€ê²©ì— ê°±ì‹ ë©ë‹ˆë‹¤.";
	}

	protected override string _GetTemplateForLabelStartRenewingPrice()
	{
		return "ë³¸ VIP ì„œë²„ëŠ” ì·¨ì†Œí•  ë•Œê¹Œì§€ ë§¤ë‹¬ {price} ì˜ ê°€ê²©ì— ê°±ì‹ ë©ë‹ˆë‹¤.";
	}

	protected override string _GetTemplateForLabelVIPServerGameJoinErrorAcknowledgement()
	{
		return "í™•ì¸";
	}

	protected override string _GetTemplateForLabelVipServerJoinGamePrivateError()
	{
		return "ë¹„ê³µê°œ ê²Œìž„ì´ë¯€ë¡œ ë³¸ VIP ì„œë²„ì— ì—°ê²°í•  ìˆ˜ ì—†ì–´ìš”.";
	}

	protected override string _GetTemplateForLabelVipServersAbout()
	{
		return "VIP ì„œë²„ì—ì„œëŠ” ì¹œêµ¬, í´ëžœ í˜¹ì€ ì´ˆëŒ€í•œ ì‚¬ëžŒë“¤ê³¼ í•¨ê»˜ ë¹„ê³µê°œë¡œ ê²Œìž„ì„ ì¦ê¸¸ ìˆ˜ ìžˆì–´ìš”!";
	}

	/// <summary>
	/// Key: "Label.VipServersNotSupported"
	/// English String: "This game does not support {vipServersLink}."
	/// </summary>
	public override string LabelVipServersNotSupported(string vipServersLink)
	{
		return $"{vipServersLink}ì„(ë¥¼) ì§€ì›í•˜ì§€ ì•ŠëŠ” ê²Œìž„ìž…ë‹ˆë‹¤.";
	}

	protected override string _GetTemplateForLabelVipServersNotSupported()
	{
		return "{vipServersLink}ì„(ë¥¼) ì§€ì›í•˜ì§€ ì•ŠëŠ” ê²Œìž„ìž…ë‹ˆë‹¤.";
	}

	protected override string _GetTemplateForMessageInvalidLink()
	{
		return "VIP ì„œë²„ ë§í¬ê°€ ë” ì´ìƒ ìœ íš¨í•˜ì§€ ì•ŠìŠµë‹ˆë‹¤.";
	}
}


}
