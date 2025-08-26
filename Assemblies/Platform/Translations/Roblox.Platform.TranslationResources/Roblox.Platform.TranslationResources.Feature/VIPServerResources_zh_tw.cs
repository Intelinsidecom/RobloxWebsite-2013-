namespace Roblox.Platform.TranslationResources.Feature {
    /// <summary>

/// This class overrides VIPServerResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class VIPServerResources_zh_tw : VIPServerResources_en_us, IVIPServerResources, ITranslationResources
{
	/// <summary>
	/// Key: "Action.Add"
	/// English String: "Add"
	/// </summary>
	public override string ActionAdd => "æ–°å¢ž";

	/// <summary>
	/// Key: "Action.AddPlayers"
	/// English String: "Add Players"
	/// </summary>
	public override string ActionAddPlayers => "æ–°å¢žçŽ©å®¶";

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
	public override string ActionChangeName => "è®Šæ›´åç¨±";

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
	public override string ActionRenewVipServer => "çºŒè¨‚ VIP ä¼ºæœå™¨";

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
	public override string HeadingChangeName => "è®Šæ›´ VIP ä¼ºæœå™¨åç¨±";

	/// <summary>
	/// Key: "Heading.ConfigureVipServer"
	/// English String: "Configure VIP Server"
	/// </summary>
	public override string HeadingConfigureVipServer => "è¨­å®š VIP ä¼ºæœå™¨";

	/// <summary>
	/// Key: "Heading.RemovePlayer"
	/// English String: "Remove Player"
	/// </summary>
	public override string HeadingRemovePlayer => "ç§»é™¤çŽ©å®¶";

	/// <summary>
	/// Key: "Heading.RenewVipServer"
	/// English String: "Renew VIP Server"
	/// </summary>
	public override string HeadingRenewVipServer => "çºŒè¨‚ VIP ä¼ºæœå™¨";

	/// <summary>
	/// Key: "Label.ChangeNamePlaceholder"
	/// English String: "VIP Server Name (1-50 Characters)"
	/// </summary>
	public override string LabelChangeNamePlaceholder => "VIP ä¼ºæœå™¨åç¨±ï¼ˆ1 åˆ° 50 å€‹å­—å…ƒï¼‰";

	/// <summary>
	/// Key: "Label.ClanAccess"
	/// English String: "Clan Access"
	/// </summary>
	public override string LabelClanAccess => "å…¬æœƒæ¬Šé™";

	/// <summary>
	/// Key: "Label.FriendsAllowed"
	/// English String: "Friends Allowed"
	/// </summary>
	public override string LabelFriendsAllowed => "å…è¨±çš„å¥½å‹";

	/// <summary>
	/// Key: "Label.GameName"
	/// English String: "Game Name"
	/// </summary>
	public override string LabelGameName => "éŠæˆ²åç¨±";

	/// <summary>
	/// Key: "Label.JoinGameLink"
	/// English String: "Join Game Link..."
	/// </summary>
	public override string LabelJoinGameLink => "åŠ å…¥éŠæˆ²é€£çµâ€¦";

	/// <summary>
	/// Key: "Label.None"
	/// English String: "None"
	/// </summary>
	public override string LabelNone => "ç„¡";

	/// <summary>
	/// Key: "Label.Off"
	/// English String: "Off"
	/// </summary>
	public override string LabelOff => "é—œé–‰";

	/// <summary>
	/// Key: "Label.On"
	/// English String: "On"
	/// </summary>
	public override string LabelOn => "é–‹å•Ÿ";

	/// <summary>
	/// Key: "Label.PickEnemyClan"
	/// English String: "Pick Enemy Clan"
	/// </summary>
	public override string LabelPickEnemyClan => "é¸æ“‡æ•µå°å…¬æœƒ";

	/// <summary>
	/// Key: "Label.SearchForPlayers"
	/// English String: "Search for Players"
	/// </summary>
	public override string LabelSearchForPlayers => "æœå°‹çŽ©å®¶";

	/// <summary>
	/// Key: "Label.Server"
	/// English String: "Server"
	/// </summary>
	public override string LabelServer => "ä¼ºæœå™¨";

	/// <summary>
	/// Key: "Label.ServerMembers"
	/// English String: "Server Members"
	/// </summary>
	public override string LabelServerMembers => "ä¼ºæœå™¨æˆå“¡";

	/// <summary>
	/// Key: "Label.SubscriptionStatus"
	/// English String: "Subscription Status"
	/// </summary>
	public override string LabelSubscriptionStatus => "è¨‚é–±ç‹€æ…‹";

	/// <summary>
	/// Key: "Label.VIPServerLink"
	/// English String: "VIP Server Link"
	/// </summary>
	public override string LabelVIPServerLink => "VIP ä¼ºæœå™¨é€£çµ";

	/// <summary>
	/// Key: "Label.VIPServerStatus"
	/// English String: "VIP Server Status"
	/// </summary>
	public override string LabelVIPServerStatus => "VIP ä¼ºæœå™¨ç‹€æ…‹";

	/// <summary>
	/// Key: "Label.YourClan"
	/// English String: "Your Clan"
	/// </summary>
	public override string LabelYourClan => "æ‚¨çš„å…¬æœƒ";

	public VIPServerResources_zh_tw(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionAdd()
	{
		return "æ–°å¢ž";
	}

	protected override string _GetTemplateForActionAddPlayers()
	{
		return "æ–°å¢žçŽ©å®¶";
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
		return "è®Šæ›´åç¨±";
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
		return "çºŒè¨‚ VIP ä¼ºæœå™¨";
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
		return "è®Šæ›´ VIP ä¼ºæœå™¨åç¨±";
	}

	protected override string _GetTemplateForHeadingConfigureVipServer()
	{
		return "è¨­å®š VIP ä¼ºæœå™¨";
	}

	protected override string _GetTemplateForHeadingRemovePlayer()
	{
		return "ç§»é™¤çŽ©å®¶";
	}

	protected override string _GetTemplateForHeadingRenewVipServer()
	{
		return "çºŒè¨‚ VIP ä¼ºæœå™¨";
	}

	/// <summary>
	/// Key: "Label.ChangeNameBodyMessage"
	/// English String: "Are you sure you want to cancel future payments for your VIP Server of {name} by {creator}? If you cancel, your VIP Server will be deactivated on {date}."
	/// </summary>
	public override string LabelChangeNameBodyMessage(string name, string creator, string date)
	{
		return $"ç¢ºå®šå–æ¶ˆ {creator} æ‰€å‰µä½œçš„ {name} ç§äºº VIP ä¼ºæœå™¨é æœŸä»˜æ¬¾ï¼Ÿè‹¥æ‚¨å–æ¶ˆï¼Œæ‚¨çš„ VIP ä¼ºæœå™¨å°‡åœ¨ {date} é—œé–‰ã€‚";
	}

	protected override string _GetTemplateForLabelChangeNameBodyMessage()
	{
		return "ç¢ºå®šå–æ¶ˆ {creator} æ‰€å‰µä½œçš„ {name} ç§äºº VIP ä¼ºæœå™¨é æœŸä»˜æ¬¾ï¼Ÿè‹¥æ‚¨å–æ¶ˆï¼Œæ‚¨çš„ VIP ä¼ºæœå™¨å°‡åœ¨ {date} é—œé–‰ã€‚";
	}

	protected override string _GetTemplateForLabelChangeNamePlaceholder()
	{
		return "VIP ä¼ºæœå™¨åç¨±ï¼ˆ1 åˆ° 50 å€‹å­—å…ƒï¼‰";
	}

	protected override string _GetTemplateForLabelClanAccess()
	{
		return "å…¬æœƒæ¬Šé™";
	}

	protected override string _GetTemplateForLabelFriendsAllowed()
	{
		return "å…è¨±çš„å¥½å‹";
	}

	protected override string _GetTemplateForLabelGameName()
	{
		return "éŠæˆ²åç¨±";
	}

	protected override string _GetTemplateForLabelJoinGameLink()
	{
		return "åŠ å…¥éŠæˆ²é€£çµâ€¦";
	}

	protected override string _GetTemplateForLabelNone()
	{
		return "ç„¡";
	}

	protected override string _GetTemplateForLabelOff()
	{
		return "é—œé–‰";
	}

	protected override string _GetTemplateForLabelOn()
	{
		return "é–‹å•Ÿ";
	}

	protected override string _GetTemplateForLabelPickEnemyClan()
	{
		return "é¸æ“‡æ•µå°å…¬æœƒ";
	}

	/// <summary>
	/// Key: "Label.RemovePlayerBodyMessage"
	/// English String: "Are you sure you want to remove {name} from your VIP Server? They will no longer be able to join your VIP Server."
	/// </summary>
	public override string LabelRemovePlayerBodyMessage(string name)
	{
		return $"ç¢ºå®šå°‡ {name} å¾žæ‚¨çš„ VIP ä¼ºæœå™¨ç§»é™¤ï¼Ÿå°æ–¹å°‡å†ä¹Ÿç„¡æ³•å…¥æ‚¨çš„ VIP ä¼ºæœå™¨ã€‚";
	}

	protected override string _GetTemplateForLabelRemovePlayerBodyMessage()
	{
		return "ç¢ºå®šå°‡ {name} å¾žæ‚¨çš„ VIP ä¼ºæœå™¨ç§»é™¤ï¼Ÿå°æ–¹å°‡å†ä¹Ÿç„¡æ³•å…¥æ‚¨çš„ VIP ä¼ºæœå™¨ã€‚";
	}

	/// <summary>
	/// Key: "Label.RenewVipServerBodyMessageConfirmation"
	/// English String: "Are you sure you want to enable future payments for your VIP Server of {name} by {creator}?"
	/// </summary>
	public override string LabelRenewVipServerBodyMessageConfirmation(string name, string creator)
	{
		return $"ç¢ºå®šç‚º {creator} æ‰€å‰µä½œçš„ {name} å•Ÿç”¨ç§äºº VIP ç‰ˆæœ¬é æœŸä»˜æ¬¾ï¼Ÿ";
	}

	protected override string _GetTemplateForLabelRenewVipServerBodyMessageConfirmation()
	{
		return "ç¢ºå®šç‚º {creator} æ‰€å‰µä½œçš„ {name} å•Ÿç”¨ç§äºº VIP ç‰ˆæœ¬é æœŸä»˜æ¬¾ï¼Ÿ";
	}

	/// <summary>
	/// Key: "Label.RenewVipServerBodyMessageStart"
	/// English String: "This VIP Server will start renewing every month at {date} until you cancel."
	/// </summary>
	public override string LabelRenewVipServerBodyMessageStart(string date)
	{
		return $"æ­¤ VIP ä¼ºæœå™¨æœƒå¾ž {date} é–‹å§‹æ¯æœˆçºŒè¨‚ï¼Œç›´åˆ°æ‚¨å–æ¶ˆç‚ºæ­¢ã€‚";
	}

	protected override string _GetTemplateForLabelRenewVipServerBodyMessageStart()
	{
		return "æ­¤ VIP ä¼ºæœå™¨æœƒå¾ž {date} é–‹å§‹æ¯æœˆçºŒè¨‚ï¼Œç›´åˆ°æ‚¨å–æ¶ˆç‚ºæ­¢ã€‚";
	}

	protected override string _GetTemplateForLabelSearchForPlayers()
	{
		return "æœå°‹çŽ©å®¶";
	}

	protected override string _GetTemplateForLabelServer()
	{
		return "ä¼ºæœå™¨";
	}

	/// <summary>
	/// Key: "Label.ServerExpirationDate"
	/// English String: "Your VIP Server expired on{date}"
	/// </summary>
	public override string LabelServerExpirationDate(string date)
	{
		return $"æ‚¨çš„ VIP ä¼ºæœå™¨åœ¨ {date} åˆ°æœŸ";
	}

	protected override string _GetTemplateForLabelServerExpirationDate()
	{
		return "æ‚¨çš„ VIP ä¼ºæœå™¨åœ¨ {date} åˆ°æœŸ";
	}

	protected override string _GetTemplateForLabelServerMembers()
	{
		return "ä¼ºæœå™¨æˆå“¡";
	}

	/// <summary>
	/// Key: "Label.SubscriptionChargeDate"
	/// English String: "You will be charged again on {date}"
	/// </summary>
	public override string LabelSubscriptionChargeDate(string date)
	{
		return $"{date} æœƒå†å‘æ‚¨æ”¶è²»";
	}

	protected override string _GetTemplateForLabelSubscriptionChargeDate()
	{
		return "{date} æœƒå†å‘æ‚¨æ”¶è²»";
	}

	/// <summary>
	/// Key: "Label.SubscriptionMonthlyPaymentDue"
	/// English String: "Your VIP Server monthly payment is {value}"
	/// </summary>
	public override string LabelSubscriptionMonthlyPaymentDue(string value)
	{
		return $"æ‚¨çš„ VIP ä¼ºæœå™¨æœˆè²»æ˜¯ {value}";
	}

	protected override string _GetTemplateForLabelSubscriptionMonthlyPaymentDue()
	{
		return "æ‚¨çš„ VIP ä¼ºæœå™¨æœˆè²»æ˜¯ {value}";
	}

	protected override string _GetTemplateForLabelSubscriptionStatus()
	{
		return "è¨‚é–±ç‹€æ…‹";
	}

	protected override string _GetTemplateForLabelVIPServerLink()
	{
		return "VIP ä¼ºæœå™¨é€£çµ";
	}

	protected override string _GetTemplateForLabelVIPServerStatus()
	{
		return "VIP ä¼ºæœå™¨ç‹€æ…‹";
	}

	protected override string _GetTemplateForLabelYourClan()
	{
		return "æ‚¨çš„å…¬æœƒ";
	}
}


}
