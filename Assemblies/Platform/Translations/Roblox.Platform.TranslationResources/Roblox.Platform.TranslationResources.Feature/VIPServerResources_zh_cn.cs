namespace Roblox.Platform.TranslationResources.Feature {
    /// <summary>

/// This class overrides VIPServerResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class VIPServerResources_zh_cn : VIPServerResources_en_us, IVIPServerResources, ITranslationResources
{
	/// <summary>
	/// Key: "Action.Add"
	/// English String: "Add"
	/// </summary>
	public override string ActionAdd => "æ·»åŠ ";

	/// <summary>
	/// Key: "Action.AddPlayers"
	/// English String: "Add Players"
	/// </summary>
	public override string ActionAddPlayers => "æ·»åŠ çŽ©å®¶";

	/// <summary>
	/// Key: "Action.Cancel"
	/// English String: "Cancel"
	/// </summary>
	public override string ActionCancel => "å–æ¶ˆ";

	/// <summary>
	/// Key: "Action.CancelPayments"
	/// English String: "Cancel Payments"
	/// </summary>
	public override string ActionCancelPayments => "å–æ¶ˆä»˜æ¬¾";

	/// <summary>
	/// Key: "Action.ChangeName"
	/// English String: "Change Name"
	/// </summary>
	public override string ActionChangeName => "æ›´æ”¹åç§°";

	/// <summary>
	/// Key: "Action.GoBack"
	/// English String: "Go Back"
	/// </summary>
	public override string ActionGoBack => "è¿”å›ž";

	/// <summary>
	/// Key: "Action.RegenerateJoinLink"
	/// English String: "Regenerate"
	/// </summary>
	public override string ActionRegenerateJoinLink => "å†ç”Ÿ";

	/// <summary>
	/// Key: "Action.Remove"
	/// English String: "Remove"
	/// </summary>
	public override string ActionRemove => "ç§»é™¤";

	/// <summary>
	/// Key: "Action.RenewVipServer"
	/// English String: "Renew VIP Server"
	/// </summary>
	public override string ActionRenewVipServer => "ç»­è®¢ VIP æœåŠ¡å™¨";

	/// <summary>
	/// Key: "Action.SeeAll"
	/// English String: "See All"
	/// </summary>
	public override string ActionSeeAll => "æŸ¥çœ‹å…¨éƒ¨";

	/// <summary>
	/// Key: "Heading.CancelPayments"
	/// English String: "Cancel Payments"
	/// </summary>
	public override string HeadingCancelPayments => "å–æ¶ˆä»˜æ¬¾";

	/// <summary>
	/// Key: "Heading.ChangeName"
	/// English String: "Change VIP Server Name"
	/// </summary>
	public override string HeadingChangeName => "æ›´æ”¹ VIP æœåŠ¡å™¨åç§°";

	/// <summary>
	/// Key: "Heading.ConfigureVipServer"
	/// English String: "Configure VIP Server"
	/// </summary>
	public override string HeadingConfigureVipServer => "é…ç½® VIP æœåŠ¡å™¨";

	/// <summary>
	/// Key: "Heading.RemovePlayer"
	/// English String: "Remove Player"
	/// </summary>
	public override string HeadingRemovePlayer => "ç§»é™¤çŽ©å®¶";

	/// <summary>
	/// Key: "Heading.RenewVipServer"
	/// English String: "Renew VIP Server"
	/// </summary>
	public override string HeadingRenewVipServer => "ç»­è®¢ VIP æœåŠ¡å™¨";

	/// <summary>
	/// Key: "Label.ChangeNamePlaceholder"
	/// English String: "VIP Server Name (1-50 Characters)"
	/// </summary>
	public override string LabelChangeNamePlaceholder => "VIP æœåŠ¡å™¨åç§°ï¼ˆ1-50 ä¸ªå­—ç¬¦ï¼‰";

	/// <summary>
	/// Key: "Label.ClanAccess"
	/// English String: "Clan Access"
	/// </summary>
	public override string LabelClanAccess => "éƒ¨è½é€šè¡Œè¯";

	/// <summary>
	/// Key: "Label.FriendsAllowed"
	/// English String: "Friends Allowed"
	/// </summary>
	public override string LabelFriendsAllowed => "å…è®¸å¥½å‹";

	/// <summary>
	/// Key: "Label.GameName"
	/// English String: "Game Name"
	/// </summary>
	public override string LabelGameName => "æ¸¸æˆåç§°";

	/// <summary>
	/// Key: "Label.JoinGameLink"
	/// English String: "Join Game Link..."
	/// </summary>
	public override string LabelJoinGameLink => "åŠ å…¥æ¸¸æˆé“¾æŽ¥...";

	/// <summary>
	/// Key: "Label.None"
	/// English String: "None"
	/// </summary>
	public override string LabelNone => "æ— ";

	/// <summary>
	/// Key: "Label.Off"
	/// English String: "Off"
	/// </summary>
	public override string LabelOff => "å…³é—­";

	/// <summary>
	/// Key: "Label.On"
	/// English String: "On"
	/// </summary>
	public override string LabelOn => "å¼€å¯";

	/// <summary>
	/// Key: "Label.PickEnemyClan"
	/// English String: "Pick Enemy Clan"
	/// </summary>
	public override string LabelPickEnemyClan => "æŒ‘é€‰æ•Œäººéƒ¨è½";

	/// <summary>
	/// Key: "Label.SearchForPlayers"
	/// English String: "Search for Players"
	/// </summary>
	public override string LabelSearchForPlayers => "æœç´¢çŽ©å®¶";

	/// <summary>
	/// Key: "Label.Server"
	/// English String: "Server"
	/// </summary>
	public override string LabelServer => "æœåŠ¡å™¨";

	/// <summary>
	/// Key: "Label.ServerMembers"
	/// English String: "Server Members"
	/// </summary>
	public override string LabelServerMembers => "æœåŠ¡å™¨æˆå‘˜";

	/// <summary>
	/// Key: "Label.SubscriptionStatus"
	/// English String: "Subscription Status"
	/// </summary>
	public override string LabelSubscriptionStatus => "è®¢é˜…çŠ¶æ€";

	/// <summary>
	/// Key: "Label.VIPServerLink"
	/// English String: "VIP Server Link"
	/// </summary>
	public override string LabelVIPServerLink => "VIP æœåŠ¡å™¨é“¾æŽ¥";

	/// <summary>
	/// Key: "Label.VIPServerStatus"
	/// English String: "VIP Server Status"
	/// </summary>
	public override string LabelVIPServerStatus => "VIP æœåŠ¡å™¨çŠ¶æ€";

	/// <summary>
	/// Key: "Label.YourClan"
	/// English String: "Your Clan"
	/// </summary>
	public override string LabelYourClan => "ä½ çš„éƒ¨è½";

	public VIPServerResources_zh_cn(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionAdd()
	{
		return "æ·»åŠ ";
	}

	protected override string _GetTemplateForActionAddPlayers()
	{
		return "æ·»åŠ çŽ©å®¶";
	}

	protected override string _GetTemplateForActionCancel()
	{
		return "å–æ¶ˆ";
	}

	protected override string _GetTemplateForActionCancelPayments()
	{
		return "å–æ¶ˆä»˜æ¬¾";
	}

	protected override string _GetTemplateForActionChangeName()
	{
		return "æ›´æ”¹åç§°";
	}

	protected override string _GetTemplateForActionGoBack()
	{
		return "è¿”å›ž";
	}

	protected override string _GetTemplateForActionRegenerateJoinLink()
	{
		return "å†ç”Ÿ";
	}

	protected override string _GetTemplateForActionRemove()
	{
		return "ç§»é™¤";
	}

	protected override string _GetTemplateForActionRenewVipServer()
	{
		return "ç»­è®¢ VIP æœåŠ¡å™¨";
	}

	protected override string _GetTemplateForActionSeeAll()
	{
		return "æŸ¥çœ‹å…¨éƒ¨";
	}

	protected override string _GetTemplateForHeadingCancelPayments()
	{
		return "å–æ¶ˆä»˜æ¬¾";
	}

	protected override string _GetTemplateForHeadingChangeName()
	{
		return "æ›´æ”¹ VIP æœåŠ¡å™¨åç§°";
	}

	protected override string _GetTemplateForHeadingConfigureVipServer()
	{
		return "é…ç½® VIP æœåŠ¡å™¨";
	}

	protected override string _GetTemplateForHeadingRemovePlayer()
	{
		return "ç§»é™¤çŽ©å®¶";
	}

	protected override string _GetTemplateForHeadingRenewVipServer()
	{
		return "ç»­è®¢ VIP æœåŠ¡å™¨";
	}

	/// <summary>
	/// Key: "Label.ChangeNameBodyMessage"
	/// English String: "Are you sure you want to cancel future payments for your VIP Server of {name} by {creator}? If you cancel, your VIP Server will be deactivated on {date}."
	/// </summary>
	public override string LabelChangeNameBodyMessage(string name, string creator, string date)
	{
		return $"æ˜¯å¦ç¡®å®šè¦å–æ¶ˆâ€œ{creator}â€æ‰€åˆ›ä½œçš„â€œ{name}â€ç§äºº VIP æœåŠ¡å™¨çš„é¢„ä»˜æ¬¾ï¼Ÿå¦‚æžœå–æ¶ˆï¼Œä½ çš„ VIP æœåŠ¡å™¨å°†äºŽ {date} å¤±æ•ˆã€‚";
	}

	protected override string _GetTemplateForLabelChangeNameBodyMessage()
	{
		return "æ˜¯å¦ç¡®å®šè¦å–æ¶ˆâ€œ{creator}â€æ‰€åˆ›ä½œçš„â€œ{name}â€ç§äºº VIP æœåŠ¡å™¨çš„é¢„ä»˜æ¬¾ï¼Ÿå¦‚æžœå–æ¶ˆï¼Œä½ çš„ VIP æœåŠ¡å™¨å°†äºŽ {date} å¤±æ•ˆã€‚";
	}

	protected override string _GetTemplateForLabelChangeNamePlaceholder()
	{
		return "VIP æœåŠ¡å™¨åç§°ï¼ˆ1-50 ä¸ªå­—ç¬¦ï¼‰";
	}

	protected override string _GetTemplateForLabelClanAccess()
	{
		return "éƒ¨è½é€šè¡Œè¯";
	}

	protected override string _GetTemplateForLabelFriendsAllowed()
	{
		return "å…è®¸å¥½å‹";
	}

	protected override string _GetTemplateForLabelGameName()
	{
		return "æ¸¸æˆåç§°";
	}

	protected override string _GetTemplateForLabelJoinGameLink()
	{
		return "åŠ å…¥æ¸¸æˆé“¾æŽ¥...";
	}

	protected override string _GetTemplateForLabelNone()
	{
		return "æ— ";
	}

	protected override string _GetTemplateForLabelOff()
	{
		return "å…³é—­";
	}

	protected override string _GetTemplateForLabelOn()
	{
		return "å¼€å¯";
	}

	protected override string _GetTemplateForLabelPickEnemyClan()
	{
		return "æŒ‘é€‰æ•Œäººéƒ¨è½";
	}

	/// <summary>
	/// Key: "Label.RemovePlayerBodyMessage"
	/// English String: "Are you sure you want to remove {name} from your VIP Server? They will no longer be able to join your VIP Server."
	/// </summary>
	public override string LabelRemovePlayerBodyMessage(string name)
	{
		return $"æ˜¯å¦ç¡®å®šè¦ä»Žä½ çš„ VIP æœåŠ¡å™¨ç§»é™¤ {name}ï¼Ÿå¯¹æ–¹å°†æ— æ³•å†åŠ å…¥ä½ çš„ VIP æœåŠ¡å™¨ã€‚";
	}

	protected override string _GetTemplateForLabelRemovePlayerBodyMessage()
	{
		return "æ˜¯å¦ç¡®å®šè¦ä»Žä½ çš„ VIP æœåŠ¡å™¨ç§»é™¤ {name}ï¼Ÿå¯¹æ–¹å°†æ— æ³•å†åŠ å…¥ä½ çš„ VIP æœåŠ¡å™¨ã€‚";
	}

	/// <summary>
	/// Key: "Label.RenewVipServerBodyMessageConfirmation"
	/// English String: "Are you sure you want to enable future payments for your VIP Server of {name} by {creator}?"
	/// </summary>
	public override string LabelRenewVipServerBodyMessageConfirmation(string name, string creator)
	{
		return $"æ˜¯å¦ç¡®å®šä¸ºâ€œ{creator}â€æ‰€åˆ›ä½œçš„â€œ{name}â€å¯ç”¨ç§äºº VIP æœåŠ¡å™¨ç‰ˆæœ¬é¢„ä»˜æ¬¾ï¼Ÿ";
	}

	protected override string _GetTemplateForLabelRenewVipServerBodyMessageConfirmation()
	{
		return "æ˜¯å¦ç¡®å®šä¸ºâ€œ{creator}â€æ‰€åˆ›ä½œçš„â€œ{name}â€å¯ç”¨ç§äºº VIP æœåŠ¡å™¨ç‰ˆæœ¬é¢„ä»˜æ¬¾ï¼Ÿ";
	}

	/// <summary>
	/// Key: "Label.RenewVipServerBodyMessageStart"
	/// English String: "This VIP Server will start renewing every month at {date} until you cancel."
	/// </summary>
	public override string LabelRenewVipServerBodyMessageStart(string date)
	{
		return $"æ­¤ VIP æœåŠ¡å™¨å°†äºŽæ¯æœˆ {date} ç»­è®¢ï¼Œç›´è‡³ä½ å–æ¶ˆã€‚";
	}

	protected override string _GetTemplateForLabelRenewVipServerBodyMessageStart()
	{
		return "æ­¤ VIP æœåŠ¡å™¨å°†äºŽæ¯æœˆ {date} ç»­è®¢ï¼Œç›´è‡³ä½ å–æ¶ˆã€‚";
	}

	protected override string _GetTemplateForLabelSearchForPlayers()
	{
		return "æœç´¢çŽ©å®¶";
	}

	protected override string _GetTemplateForLabelServer()
	{
		return "æœåŠ¡å™¨";
	}

	/// <summary>
	/// Key: "Label.ServerExpirationDate"
	/// English String: "Your VIP Server expired on{date}"
	/// </summary>
	public override string LabelServerExpirationDate(string date)
	{
		return $"ä½  VIP æœåŠ¡å™¨çš„å¤±æ•ˆæ—¥æœŸä¸º {date}";
	}

	protected override string _GetTemplateForLabelServerExpirationDate()
	{
		return "ä½  VIP æœåŠ¡å™¨çš„å¤±æ•ˆæ—¥æœŸä¸º {date}";
	}

	protected override string _GetTemplateForLabelServerMembers()
	{
		return "æœåŠ¡å™¨æˆå‘˜";
	}

	/// <summary>
	/// Key: "Label.SubscriptionChargeDate"
	/// English String: "You will be charged again on {date}"
	/// </summary>
	public override string LabelSubscriptionChargeDate(string date)
	{
		return $"ä½ å°†äºŽ {date} è¢«å†æ¬¡æ”¶è´¹";
	}

	protected override string _GetTemplateForLabelSubscriptionChargeDate()
	{
		return "ä½ å°†äºŽ {date} è¢«å†æ¬¡æ”¶è´¹";
	}

	/// <summary>
	/// Key: "Label.SubscriptionMonthlyPaymentDue"
	/// English String: "Your VIP Server monthly payment is {value}"
	/// </summary>
	public override string LabelSubscriptionMonthlyPaymentDue(string value)
	{
		return $"ä½ çš„ VIP æœåŠ¡å™¨æœˆè´¹ä¸º {value}";
	}

	protected override string _GetTemplateForLabelSubscriptionMonthlyPaymentDue()
	{
		return "ä½ çš„ VIP æœåŠ¡å™¨æœˆè´¹ä¸º {value}";
	}

	protected override string _GetTemplateForLabelSubscriptionStatus()
	{
		return "è®¢é˜…çŠ¶æ€";
	}

	protected override string _GetTemplateForLabelVIPServerLink()
	{
		return "VIP æœåŠ¡å™¨é“¾æŽ¥";
	}

	protected override string _GetTemplateForLabelVIPServerStatus()
	{
		return "VIP æœåŠ¡å™¨çŠ¶æ€";
	}

	protected override string _GetTemplateForLabelYourClan()
	{
		return "ä½ çš„éƒ¨è½";
	}
}


}
