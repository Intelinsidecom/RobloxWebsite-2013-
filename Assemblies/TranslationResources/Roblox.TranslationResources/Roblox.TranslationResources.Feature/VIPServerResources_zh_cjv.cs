namespace Roblox.TranslationResources.Feature;

/// <summary>
/// This class overrides VIPServerResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class VIPServerResources_zh_cjv : VIPServerResources_en_us, IVIPServerResources, ITranslationResources
{
	/// <summary>
	/// Key: "Action.Add"
	/// English String: "Add"
	/// </summary>
	public override string ActionAdd => "添加";

	/// <summary>
	/// Key: "Action.AddPlayers"
	/// English String: "Add Players"
	/// </summary>
	public override string ActionAddPlayers => "添加玩家";

	/// <summary>
	/// Key: "Action.Cancel"
	/// English String: "Cancel"
	/// </summary>
	public override string ActionCancel => "取消";

	/// <summary>
	/// Key: "Action.CancelPayments"
	/// English String: "Cancel Payments"
	/// </summary>
	public override string ActionCancelPayments => "取消付款";

	/// <summary>
	/// Key: "Action.ChangeName"
	/// English String: "Change Name"
	/// </summary>
	public override string ActionChangeName => "更改名称";

	/// <summary>
	/// Key: "Action.GoBack"
	/// English String: "Go Back"
	/// </summary>
	public override string ActionGoBack => "返回";

	/// <summary>
	/// Key: "Action.RegenerateJoinLink"
	/// English String: "Regenerate"
	/// </summary>
	public override string ActionRegenerateJoinLink => "再生";

	/// <summary>
	/// Key: "Action.Remove"
	/// English String: "Remove"
	/// </summary>
	public override string ActionRemove => "移除";

	/// <summary>
	/// Key: "Action.RenewVipServer"
	/// English String: "Renew VIP Server"
	/// </summary>
	public override string ActionRenewVipServer => "续订 VIP 服务器";

	/// <summary>
	/// Key: "Action.SeeAll"
	/// English String: "See All"
	/// </summary>
	public override string ActionSeeAll => "查看全部";

	/// <summary>
	/// Key: "Heading.CancelPayments"
	/// English String: "Cancel Payments"
	/// </summary>
	public override string HeadingCancelPayments => "取消付款";

	/// <summary>
	/// Key: "Heading.ChangeName"
	/// English String: "Change VIP Server Name"
	/// </summary>
	public override string HeadingChangeName => "更改 VIP 服务器名称";

	/// <summary>
	/// Key: "Heading.ConfigureVipServer"
	/// English String: "Configure VIP Server"
	/// </summary>
	public override string HeadingConfigureVipServer => "配置 VIP 服务器";

	/// <summary>
	/// Key: "Heading.RemovePlayer"
	/// English String: "Remove Player"
	/// </summary>
	public override string HeadingRemovePlayer => "移除玩家";

	/// <summary>
	/// Key: "Heading.RenewVipServer"
	/// English String: "Renew VIP Server"
	/// </summary>
	public override string HeadingRenewVipServer => "续订 VIP 服务器";

	/// <summary>
	/// Key: "Label.ChangeNamePlaceholder"
	/// English String: "VIP Server Name (1-50 Characters)"
	/// </summary>
	public override string LabelChangeNamePlaceholder => "VIP 服务器名称（1-50 个字符）";

	/// <summary>
	/// Key: "Label.ClanAccess"
	/// English String: "Clan Access"
	/// </summary>
	public override string LabelClanAccess => "部落通行证";

	/// <summary>
	/// Key: "Label.FriendsAllowed"
	/// English String: "Friends Allowed"
	/// </summary>
	public override string LabelFriendsAllowed => "允许好友";

	/// <summary>
	/// Key: "Label.GameName"
	/// English String: "Game Name"
	/// </summary>
	public override string LabelGameName => "游戏名称";

	/// <summary>
	/// Key: "Label.JoinGameLink"
	/// English String: "Join Game Link..."
	/// </summary>
	public override string LabelJoinGameLink => "加入游戏链接...";

	/// <summary>
	/// Key: "Label.None"
	/// English String: "None"
	/// </summary>
	public override string LabelNone => "无";

	/// <summary>
	/// Key: "Label.Off"
	/// English String: "Off"
	/// </summary>
	public override string LabelOff => "关闭";

	/// <summary>
	/// Key: "Label.On"
	/// English String: "On"
	/// </summary>
	public override string LabelOn => "开启";

	/// <summary>
	/// Key: "Label.PickEnemyClan"
	/// English String: "Pick Enemy Clan"
	/// </summary>
	public override string LabelPickEnemyClan => "挑选敌人部落";

	/// <summary>
	/// Key: "Label.SearchForPlayers"
	/// English String: "Search for Players"
	/// </summary>
	public override string LabelSearchForPlayers => "搜索玩家";

	/// <summary>
	/// Key: "Label.Server"
	/// English String: "Server"
	/// </summary>
	public override string LabelServer => "服务器";

	/// <summary>
	/// Key: "Label.ServerMembers"
	/// English String: "Server Members"
	/// </summary>
	public override string LabelServerMembers => "服务器成员";

	/// <summary>
	/// Key: "Label.SubscriptionStatus"
	/// English String: "Subscription Status"
	/// </summary>
	public override string LabelSubscriptionStatus => "订阅状态";

	/// <summary>
	/// Key: "Label.VIPServerLink"
	/// English String: "VIP Server Link"
	/// </summary>
	public override string LabelVIPServerLink => "VIP 服务器链接";

	/// <summary>
	/// Key: "Label.VIPServerStatus"
	/// English String: "VIP Server Status"
	/// </summary>
	public override string LabelVIPServerStatus => "VIP 服务器状态";

	/// <summary>
	/// Key: "Label.YourClan"
	/// English String: "Your Clan"
	/// </summary>
	public override string LabelYourClan => "你的部落";

	public VIPServerResources_zh_cjv(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionAdd()
	{
		return "添加";
	}

	protected override string _GetTemplateForActionAddPlayers()
	{
		return "添加玩家";
	}

	protected override string _GetTemplateForActionCancel()
	{
		return "取消";
	}

	protected override string _GetTemplateForActionCancelPayments()
	{
		return "取消付款";
	}

	protected override string _GetTemplateForActionChangeName()
	{
		return "更改名称";
	}

	protected override string _GetTemplateForActionGoBack()
	{
		return "返回";
	}

	protected override string _GetTemplateForActionRegenerateJoinLink()
	{
		return "再生";
	}

	protected override string _GetTemplateForActionRemove()
	{
		return "移除";
	}

	protected override string _GetTemplateForActionRenewVipServer()
	{
		return "续订 VIP 服务器";
	}

	protected override string _GetTemplateForActionSeeAll()
	{
		return "查看全部";
	}

	protected override string _GetTemplateForHeadingCancelPayments()
	{
		return "取消付款";
	}

	protected override string _GetTemplateForHeadingChangeName()
	{
		return "更改 VIP 服务器名称";
	}

	protected override string _GetTemplateForHeadingConfigureVipServer()
	{
		return "配置 VIP 服务器";
	}

	protected override string _GetTemplateForHeadingRemovePlayer()
	{
		return "移除玩家";
	}

	protected override string _GetTemplateForHeadingRenewVipServer()
	{
		return "续订 VIP 服务器";
	}

	/// <summary>
	/// Key: "Label.ChangeNameBodyMessage"
	/// English String: "Are you sure you want to cancel future payments for your VIP Server of {name} by {creator}? If you cancel, your VIP Server will be deactivated on {date}."
	/// </summary>
	public override string LabelChangeNameBodyMessage(string name, string creator, string date)
	{
		return $"是否确定要取消“{creator}”所创作的“{name}”私人 VIP 服务器的预付款？如果取消，你的 VIP 服务器将于 {date} 失效。";
	}

	protected override string _GetTemplateForLabelChangeNameBodyMessage()
	{
		return "是否确定要取消“{creator}”所创作的“{name}”私人 VIP 服务器的预付款？如果取消，你的 VIP 服务器将于 {date} 失效。";
	}

	protected override string _GetTemplateForLabelChangeNamePlaceholder()
	{
		return "VIP 服务器名称（1-50 个字符）";
	}

	protected override string _GetTemplateForLabelClanAccess()
	{
		return "部落通行证";
	}

	protected override string _GetTemplateForLabelFriendsAllowed()
	{
		return "允许好友";
	}

	protected override string _GetTemplateForLabelGameName()
	{
		return "游戏名称";
	}

	protected override string _GetTemplateForLabelJoinGameLink()
	{
		return "加入游戏链接...";
	}

	protected override string _GetTemplateForLabelNone()
	{
		return "无";
	}

	protected override string _GetTemplateForLabelOff()
	{
		return "关闭";
	}

	protected override string _GetTemplateForLabelOn()
	{
		return "开启";
	}

	protected override string _GetTemplateForLabelPickEnemyClan()
	{
		return "挑选敌人部落";
	}

	/// <summary>
	/// Key: "Label.RemovePlayerBodyMessage"
	/// English String: "Are you sure you want to remove {name} from your VIP Server? They will no longer be able to join your VIP Server."
	/// </summary>
	public override string LabelRemovePlayerBodyMessage(string name)
	{
		return $"是否确定要从你的 VIP 服务器移除 {name}？对方将无法再加入你的 VIP 服务器。";
	}

	protected override string _GetTemplateForLabelRemovePlayerBodyMessage()
	{
		return "是否确定要从你的 VIP 服务器移除 {name}？对方将无法再加入你的 VIP 服务器。";
	}

	/// <summary>
	/// Key: "Label.RenewVipServerBodyMessageConfirmation"
	/// English String: "Are you sure you want to enable future payments for your VIP Server of {name} by {creator}?"
	/// </summary>
	public override string LabelRenewVipServerBodyMessageConfirmation(string name, string creator)
	{
		return $"是否确定为“{creator}”所创作的“{name}”启用私人 VIP 服务器版本预付款？";
	}

	protected override string _GetTemplateForLabelRenewVipServerBodyMessageConfirmation()
	{
		return "是否确定为“{creator}”所创作的“{name}”启用私人 VIP 服务器版本预付款？";
	}

	/// <summary>
	/// Key: "Label.RenewVipServerBodyMessageStart"
	/// English String: "This VIP Server will start renewing every month at {date} until you cancel."
	/// </summary>
	public override string LabelRenewVipServerBodyMessageStart(string date)
	{
		return $"此 VIP 服务器将于每月 {date} 续订，直至你取消。";
	}

	protected override string _GetTemplateForLabelRenewVipServerBodyMessageStart()
	{
		return "此 VIP 服务器将于每月 {date} 续订，直至你取消。";
	}

	protected override string _GetTemplateForLabelSearchForPlayers()
	{
		return "搜索玩家";
	}

	protected override string _GetTemplateForLabelServer()
	{
		return "服务器";
	}

	/// <summary>
	/// Key: "Label.ServerExpirationDate"
	/// English String: "Your VIP Server expired on{date}"
	/// </summary>
	public override string LabelServerExpirationDate(string date)
	{
		return $"你 VIP 服务器的失效日期为 {date}";
	}

	protected override string _GetTemplateForLabelServerExpirationDate()
	{
		return "你 VIP 服务器的失效日期为 {date}";
	}

	protected override string _GetTemplateForLabelServerMembers()
	{
		return "服务器成员";
	}

	/// <summary>
	/// Key: "Label.SubscriptionChargeDate"
	/// English String: "You will be charged again on {date}"
	/// </summary>
	public override string LabelSubscriptionChargeDate(string date)
	{
		return $"你将于 {date} 被再次收费";
	}

	protected override string _GetTemplateForLabelSubscriptionChargeDate()
	{
		return "你将于 {date} 被再次收费";
	}

	/// <summary>
	/// Key: "Label.SubscriptionMonthlyPaymentDue"
	/// English String: "Your VIP Server monthly payment is {value}"
	/// </summary>
	public override string LabelSubscriptionMonthlyPaymentDue(string value)
	{
		return $"你的 VIP 服务器月费为 {value}";
	}

	protected override string _GetTemplateForLabelSubscriptionMonthlyPaymentDue()
	{
		return "你的 VIP 服务器月费为 {value}";
	}

	protected override string _GetTemplateForLabelSubscriptionStatus()
	{
		return "订阅状态";
	}

	protected override string _GetTemplateForLabelVIPServerLink()
	{
		return "VIP 服务器链接";
	}

	protected override string _GetTemplateForLabelVIPServerStatus()
	{
		return "VIP 服务器状态";
	}

	protected override string _GetTemplateForLabelYourClan()
	{
		return "你的部落";
	}
}
