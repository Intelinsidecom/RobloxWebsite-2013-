namespace Roblox.TranslationResources.Feature;

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
	public override string ActionCreateVipServer => "建立 VIP 伺服器";

	/// <summary>
	/// Key: "Action.Refresh"
	/// English String: "Refresh"
	/// </summary>
	public override string ActionRefresh => "重新整理";

	/// <summary>
	/// Key: "Heading.InvalidLink"
	/// Dialog title when the link to a VIP server is invalid
	/// English String: "Invalid Link"
	/// </summary>
	public override string HeadingInvalidLink => "連結無效";

	/// <summary>
	/// Key: "Heading.VipServers"
	/// English String: "VIP Servers"
	/// </summary>
	public override string HeadingVipServers => "VIP 伺服器";

	/// <summary>
	/// Key: "Label.Cancel"
	/// English String: "Cancel"
	/// </summary>
	public override string LabelCancel => "取消";

	/// <summary>
	/// Key: "Label.GameJoinPrivateErrorTitle"
	/// Title of error window when trying to join a private server user does not have access to.
	/// English String: "Unable to join"
	/// </summary>
	public override string LabelGameJoinPrivateErrorTitle => "無法加入";

	/// <summary>
	/// Key: "Label.GameName"
	/// English String: "Game Name"
	/// </summary>
	public override string LabelGameName => "遊戲名稱";

	/// <summary>
	/// Key: "Label.NoVipServers"
	/// No VIP Server Instances Found.
	/// English String: "No VIP Server Instances Found."
	/// </summary>
	public override string LabelNoVipServers => "找不到 VIP 伺服器。";

	/// <summary>
	/// Key: "Label.PlayWithOthers"
	/// English String: "Play this game with friends and other people you invite."
	/// </summary>
	public override string LabelPlayWithOthers => "與好友及您邀請的對象玩此遊戲。";

	/// <summary>
	/// Key: "Label.Renew"
	/// English String: "Renew"
	/// </summary>
	public override string LabelRenew => "續訂";

	/// <summary>
	/// Key: "Label.RenewPrivateServer"
	/// English String: "Renew Private Server"
	/// </summary>
	public override string LabelRenewPrivateServer => "續訂私人伺服器";

	/// <summary>
	/// Key: "Label.ServerName"
	/// English String: "Server Name"
	/// </summary>
	public override string LabelServerName => "伺服器名稱";

	/// <summary>
	/// Key: "Label.Servers"
	/// English String: "Servers"
	/// </summary>
	public override string LabelServers => "伺服器";

	/// <summary>
	/// Key: "Label.VIPServerGameJoinErrorAcknowledgement"
	/// Confirmation text for game join private error dialog.
	/// English String: "OK"
	/// </summary>
	public override string LabelVIPServerGameJoinErrorAcknowledgement => "確定";

	/// <summary>
	/// Key: "Label.VipServerJoinGamePrivateError"
	/// Error when user wants to join a VIP server when the game is marked private
	/// English String: "You cannot join this VIP server because the game is private."
	/// </summary>
	public override string LabelVipServerJoinGamePrivateError => "此遊戲設為私人，您無法加入此 VIP 伺服器。";

	/// <summary>
	/// Key: "Label.VipServersAbout"
	/// English String: "VIP servers let you play this game privately with friends, your clan, or people you invite!"
	/// </summary>
	public override string LabelVipServersAbout => "VIP 伺服器能讓您私下與好友、公會或您邀請的對象玩此遊戲！";

	/// <summary>
	/// Key: "Message.InvalidLink"
	/// Dialog content when the link to a VIP server is invalid
	/// English String: "This VIP Server link is no longer valid."
	/// </summary>
	public override string MessageInvalidLink => "此 VIP 伺服器連結已失效。";

	public PrivateServersResources_zh_tw(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionCreateVipServer()
	{
		return "建立 VIP 伺服器";
	}

	protected override string _GetTemplateForActionRefresh()
	{
		return "重新整理";
	}

	protected override string _GetTemplateForHeadingInvalidLink()
	{
		return "連結無效";
	}

	protected override string _GetTemplateForHeadingVipServers()
	{
		return "VIP 伺服器";
	}

	protected override string _GetTemplateForLabelCancel()
	{
		return "取消";
	}

	/// <summary>
	/// Key: "Label.ConfirmEnableFuturePayments"
	/// English String: "Are you sure you want to enable future payments for your private VIP version of {placeName} by {creatorName}?"
	/// </summary>
	public override string LabelConfirmEnableFuturePayments(string placeName, string creatorName)
	{
		return $"確定為 {creatorName} 所創作的 {placeName} 啟用私人 VIP 版本預期付款？";
	}

	protected override string _GetTemplateForLabelConfirmEnableFuturePayments()
	{
		return "確定為 {creatorName} 所創作的 {placeName} 啟用私人 VIP 版本預期付款？";
	}

	/// <summary>
	/// Key: "Label.CreateVipServerFor"
	/// English String: "Create a VIP Server for {target}?"
	/// </summary>
	public override string LabelCreateVipServerFor(string target)
	{
		return $"以 {target} 建立 VIP 伺服器？";
	}

	protected override string _GetTemplateForLabelCreateVipServerFor()
	{
		return "以 {target} 建立 VIP 伺服器？";
	}

	/// <summary>
	/// Key: "Label.FooterText"
	/// English String: "Your balance after this transaction will be {robuxIcon}. This is a subscription-based feature. It will auto-renew once a month until you cancel the subscription."
	/// </summary>
	public override string LabelFooterText(string robuxIcon)
	{
		return $"您在此交易後的餘額將為 {robuxIcon}。此訂閱將會每月自動續訂一次，直到您取消訂閱為止。";
	}

	protected override string _GetTemplateForLabelFooterText()
	{
		return "您在此交易後的餘額將為 {robuxIcon}。此訂閱將會每月自動續訂一次，直到您取消訂閱為止。";
	}

	protected override string _GetTemplateForLabelGameJoinPrivateErrorTitle()
	{
		return "無法加入";
	}

	protected override string _GetTemplateForLabelGameName()
	{
		return "遊戲名稱";
	}

	protected override string _GetTemplateForLabelNoVipServers()
	{
		return "找不到 VIP 伺服器。";
	}

	protected override string _GetTemplateForLabelPlayWithOthers()
	{
		return "與好友及您邀請的對象玩此遊戲。";
	}

	protected override string _GetTemplateForLabelRenew()
	{
		return "續訂";
	}

	protected override string _GetTemplateForLabelRenewPrivateServer()
	{
		return "續訂私人伺服器";
	}

	/// <summary>
	/// Key: "Label.SeeAllServers"
	/// English String: "See all your VIP servers in the {serversLink} tab."
	/// </summary>
	public override string LabelSeeAllServers(string serversLink)
	{
		return $"可以在{serversLink}標籤檢視您所有的 VIP 伺服器。";
	}

	protected override string _GetTemplateForLabelSeeAllServers()
	{
		return "可以在{serversLink}標籤檢視您所有的 VIP 伺服器。";
	}

	protected override string _GetTemplateForLabelServerName()
	{
		return "伺服器名稱";
	}

	protected override string _GetTemplateForLabelServers()
	{
		return "伺服器";
	}

	/// <summary>
	/// Key: "Label.StartRenewingPrice"
	/// English String: "This VIP Server will start renewing every month at {price} until you cancel."
	/// </summary>
	public override string LabelStartRenewingPrice(string price)
	{
		return $"此 VIP 伺服器將會每月以 {price} 續訂，直到您取消為止。";
	}

	protected override string _GetTemplateForLabelStartRenewingPrice()
	{
		return "此 VIP 伺服器將會每月以 {price} 續訂，直到您取消為止。";
	}

	protected override string _GetTemplateForLabelVIPServerGameJoinErrorAcknowledgement()
	{
		return "確定";
	}

	protected override string _GetTemplateForLabelVipServerJoinGamePrivateError()
	{
		return "此遊戲設為私人，您無法加入此 VIP 伺服器。";
	}

	protected override string _GetTemplateForLabelVipServersAbout()
	{
		return "VIP 伺服器能讓您私下與好友、公會或您邀請的對象玩此遊戲！";
	}

	/// <summary>
	/// Key: "Label.VipServersNotSupported"
	/// English String: "This game does not support {vipServersLink}."
	/// </summary>
	public override string LabelVipServersNotSupported(string vipServersLink)
	{
		return $"此遊戲不支援 {vipServersLink}。";
	}

	protected override string _GetTemplateForLabelVipServersNotSupported()
	{
		return "此遊戲不支援 {vipServersLink}。";
	}

	protected override string _GetTemplateForMessageInvalidLink()
	{
		return "此 VIP 伺服器連結已失效。";
	}
}
