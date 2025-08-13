namespace Roblox.TranslationResources.Feature;

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
	public override string ActionAdd => "新增";

	/// <summary>
	/// Key: "Action.AddPlayers"
	/// English String: "Add Players"
	/// </summary>
	public override string ActionAddPlayers => "新增玩家";

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
	public override string ActionChangeName => "變更名稱";

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
	public override string ActionRenewVipServer => "續訂 VIP 伺服器";

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
	public override string HeadingChangeName => "變更 VIP 伺服器名稱";

	/// <summary>
	/// Key: "Heading.ConfigureVipServer"
	/// English String: "Configure VIP Server"
	/// </summary>
	public override string HeadingConfigureVipServer => "設定 VIP 伺服器";

	/// <summary>
	/// Key: "Heading.RemovePlayer"
	/// English String: "Remove Player"
	/// </summary>
	public override string HeadingRemovePlayer => "移除玩家";

	/// <summary>
	/// Key: "Heading.RenewVipServer"
	/// English String: "Renew VIP Server"
	/// </summary>
	public override string HeadingRenewVipServer => "續訂 VIP 伺服器";

	/// <summary>
	/// Key: "Label.ChangeNamePlaceholder"
	/// English String: "VIP Server Name (1-50 Characters)"
	/// </summary>
	public override string LabelChangeNamePlaceholder => "VIP 伺服器名稱（1 到 50 個字元）";

	/// <summary>
	/// Key: "Label.ClanAccess"
	/// English String: "Clan Access"
	/// </summary>
	public override string LabelClanAccess => "公會權限";

	/// <summary>
	/// Key: "Label.FriendsAllowed"
	/// English String: "Friends Allowed"
	/// </summary>
	public override string LabelFriendsAllowed => "允許的好友";

	/// <summary>
	/// Key: "Label.GameName"
	/// English String: "Game Name"
	/// </summary>
	public override string LabelGameName => "遊戲名稱";

	/// <summary>
	/// Key: "Label.JoinGameLink"
	/// English String: "Join Game Link..."
	/// </summary>
	public override string LabelJoinGameLink => "加入遊戲連結…";

	/// <summary>
	/// Key: "Label.None"
	/// English String: "None"
	/// </summary>
	public override string LabelNone => "無";

	/// <summary>
	/// Key: "Label.Off"
	/// English String: "Off"
	/// </summary>
	public override string LabelOff => "關閉";

	/// <summary>
	/// Key: "Label.On"
	/// English String: "On"
	/// </summary>
	public override string LabelOn => "開啟";

	/// <summary>
	/// Key: "Label.PickEnemyClan"
	/// English String: "Pick Enemy Clan"
	/// </summary>
	public override string LabelPickEnemyClan => "選擇敵對公會";

	/// <summary>
	/// Key: "Label.SearchForPlayers"
	/// English String: "Search for Players"
	/// </summary>
	public override string LabelSearchForPlayers => "搜尋玩家";

	/// <summary>
	/// Key: "Label.Server"
	/// English String: "Server"
	/// </summary>
	public override string LabelServer => "伺服器";

	/// <summary>
	/// Key: "Label.ServerMembers"
	/// English String: "Server Members"
	/// </summary>
	public override string LabelServerMembers => "伺服器成員";

	/// <summary>
	/// Key: "Label.SubscriptionStatus"
	/// English String: "Subscription Status"
	/// </summary>
	public override string LabelSubscriptionStatus => "訂閱狀態";

	/// <summary>
	/// Key: "Label.VIPServerLink"
	/// English String: "VIP Server Link"
	/// </summary>
	public override string LabelVIPServerLink => "VIP 伺服器連結";

	/// <summary>
	/// Key: "Label.VIPServerStatus"
	/// English String: "VIP Server Status"
	/// </summary>
	public override string LabelVIPServerStatus => "VIP 伺服器狀態";

	/// <summary>
	/// Key: "Label.YourClan"
	/// English String: "Your Clan"
	/// </summary>
	public override string LabelYourClan => "您的公會";

	public VIPServerResources_zh_tw(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionAdd()
	{
		return "新增";
	}

	protected override string _GetTemplateForActionAddPlayers()
	{
		return "新增玩家";
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
		return "變更名稱";
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
		return "續訂 VIP 伺服器";
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
		return "變更 VIP 伺服器名稱";
	}

	protected override string _GetTemplateForHeadingConfigureVipServer()
	{
		return "設定 VIP 伺服器";
	}

	protected override string _GetTemplateForHeadingRemovePlayer()
	{
		return "移除玩家";
	}

	protected override string _GetTemplateForHeadingRenewVipServer()
	{
		return "續訂 VIP 伺服器";
	}

	/// <summary>
	/// Key: "Label.ChangeNameBodyMessage"
	/// English String: "Are you sure you want to cancel future payments for your VIP Server of {name} by {creator}? If you cancel, your VIP Server will be deactivated on {date}."
	/// </summary>
	public override string LabelChangeNameBodyMessage(string name, string creator, string date)
	{
		return $"確定取消 {creator} 所創作的 {name} 私人 VIP 伺服器預期付款？若您取消，您的 VIP 伺服器將在 {date} 關閉。";
	}

	protected override string _GetTemplateForLabelChangeNameBodyMessage()
	{
		return "確定取消 {creator} 所創作的 {name} 私人 VIP 伺服器預期付款？若您取消，您的 VIP 伺服器將在 {date} 關閉。";
	}

	protected override string _GetTemplateForLabelChangeNamePlaceholder()
	{
		return "VIP 伺服器名稱（1 到 50 個字元）";
	}

	protected override string _GetTemplateForLabelClanAccess()
	{
		return "公會權限";
	}

	protected override string _GetTemplateForLabelFriendsAllowed()
	{
		return "允許的好友";
	}

	protected override string _GetTemplateForLabelGameName()
	{
		return "遊戲名稱";
	}

	protected override string _GetTemplateForLabelJoinGameLink()
	{
		return "加入遊戲連結…";
	}

	protected override string _GetTemplateForLabelNone()
	{
		return "無";
	}

	protected override string _GetTemplateForLabelOff()
	{
		return "關閉";
	}

	protected override string _GetTemplateForLabelOn()
	{
		return "開啟";
	}

	protected override string _GetTemplateForLabelPickEnemyClan()
	{
		return "選擇敵對公會";
	}

	/// <summary>
	/// Key: "Label.RemovePlayerBodyMessage"
	/// English String: "Are you sure you want to remove {name} from your VIP Server? They will no longer be able to join your VIP Server."
	/// </summary>
	public override string LabelRemovePlayerBodyMessage(string name)
	{
		return $"確定將 {name} 從您的 VIP 伺服器移除？對方將再也無法入您的 VIP 伺服器。";
	}

	protected override string _GetTemplateForLabelRemovePlayerBodyMessage()
	{
		return "確定將 {name} 從您的 VIP 伺服器移除？對方將再也無法入您的 VIP 伺服器。";
	}

	/// <summary>
	/// Key: "Label.RenewVipServerBodyMessageConfirmation"
	/// English String: "Are you sure you want to enable future payments for your VIP Server of {name} by {creator}?"
	/// </summary>
	public override string LabelRenewVipServerBodyMessageConfirmation(string name, string creator)
	{
		return $"確定為 {creator} 所創作的 {name} 啟用私人 VIP 版本預期付款？";
	}

	protected override string _GetTemplateForLabelRenewVipServerBodyMessageConfirmation()
	{
		return "確定為 {creator} 所創作的 {name} 啟用私人 VIP 版本預期付款？";
	}

	/// <summary>
	/// Key: "Label.RenewVipServerBodyMessageStart"
	/// English String: "This VIP Server will start renewing every month at {date} until you cancel."
	/// </summary>
	public override string LabelRenewVipServerBodyMessageStart(string date)
	{
		return $"此 VIP 伺服器會從 {date} 開始每月續訂，直到您取消為止。";
	}

	protected override string _GetTemplateForLabelRenewVipServerBodyMessageStart()
	{
		return "此 VIP 伺服器會從 {date} 開始每月續訂，直到您取消為止。";
	}

	protected override string _GetTemplateForLabelSearchForPlayers()
	{
		return "搜尋玩家";
	}

	protected override string _GetTemplateForLabelServer()
	{
		return "伺服器";
	}

	/// <summary>
	/// Key: "Label.ServerExpirationDate"
	/// English String: "Your VIP Server expired on{date}"
	/// </summary>
	public override string LabelServerExpirationDate(string date)
	{
		return $"您的 VIP 伺服器在 {date} 到期";
	}

	protected override string _GetTemplateForLabelServerExpirationDate()
	{
		return "您的 VIP 伺服器在 {date} 到期";
	}

	protected override string _GetTemplateForLabelServerMembers()
	{
		return "伺服器成員";
	}

	/// <summary>
	/// Key: "Label.SubscriptionChargeDate"
	/// English String: "You will be charged again on {date}"
	/// </summary>
	public override string LabelSubscriptionChargeDate(string date)
	{
		return $"{date} 會再向您收費";
	}

	protected override string _GetTemplateForLabelSubscriptionChargeDate()
	{
		return "{date} 會再向您收費";
	}

	/// <summary>
	/// Key: "Label.SubscriptionMonthlyPaymentDue"
	/// English String: "Your VIP Server monthly payment is {value}"
	/// </summary>
	public override string LabelSubscriptionMonthlyPaymentDue(string value)
	{
		return $"您的 VIP 伺服器月費是 {value}";
	}

	protected override string _GetTemplateForLabelSubscriptionMonthlyPaymentDue()
	{
		return "您的 VIP 伺服器月費是 {value}";
	}

	protected override string _GetTemplateForLabelSubscriptionStatus()
	{
		return "訂閱狀態";
	}

	protected override string _GetTemplateForLabelVIPServerLink()
	{
		return "VIP 伺服器連結";
	}

	protected override string _GetTemplateForLabelVIPServerStatus()
	{
		return "VIP 伺服器狀態";
	}

	protected override string _GetTemplateForLabelYourClan()
	{
		return "您的公會";
	}
}
