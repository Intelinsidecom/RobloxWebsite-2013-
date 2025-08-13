namespace Roblox.TranslationResources.Feature;

/// <summary>
/// This class overrides PrivateServersResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class PrivateServersResources_zh_cn : PrivateServersResources_en_us, IPrivateServersResources, ITranslationResources
{
	/// <summary>
	/// Key: "Action.CreateVipServer"
	/// English String: "Create VIP Server"
	/// </summary>
	public override string ActionCreateVipServer => "创建 VIP 服务器";

	/// <summary>
	/// Key: "Action.Refresh"
	/// English String: "Refresh"
	/// </summary>
	public override string ActionRefresh => "刷新";

	/// <summary>
	/// Key: "Heading.InvalidLink"
	/// Dialog title when the link to a VIP server is invalid
	/// English String: "Invalid Link"
	/// </summary>
	public override string HeadingInvalidLink => "无效链接";

	/// <summary>
	/// Key: "Heading.VipServers"
	/// English String: "VIP Servers"
	/// </summary>
	public override string HeadingVipServers => "VIP 服务器";

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
	public override string LabelGameJoinPrivateErrorTitle => "无法加入";

	/// <summary>
	/// Key: "Label.GameName"
	/// English String: "Game Name"
	/// </summary>
	public override string LabelGameName => "游戏名称";

	/// <summary>
	/// Key: "Label.NoVipServers"
	/// No VIP Server Instances Found.
	/// English String: "No VIP Server Instances Found."
	/// </summary>
	public override string LabelNoVipServers => "未找到 VIP 服务器实例。";

	/// <summary>
	/// Key: "Label.PlayWithOthers"
	/// English String: "Play this game with friends and other people you invite."
	/// </summary>
	public override string LabelPlayWithOthers => "与好友和你邀请的其他人加入此游戏。";

	/// <summary>
	/// Key: "Label.Renew"
	/// English String: "Renew"
	/// </summary>
	public override string LabelRenew => "续订";

	/// <summary>
	/// Key: "Label.RenewPrivateServer"
	/// English String: "Renew Private Server"
	/// </summary>
	public override string LabelRenewPrivateServer => "续订私人服务器";

	/// <summary>
	/// Key: "Label.ServerName"
	/// English String: "Server Name"
	/// </summary>
	public override string LabelServerName => "服务器名称";

	/// <summary>
	/// Key: "Label.Servers"
	/// English String: "Servers"
	/// </summary>
	public override string LabelServers => "服务器";

	/// <summary>
	/// Key: "Label.VIPServerGameJoinErrorAcknowledgement"
	/// Confirmation text for game join private error dialog.
	/// English String: "OK"
	/// </summary>
	public override string LabelVIPServerGameJoinErrorAcknowledgement => "好";

	/// <summary>
	/// Key: "Label.VipServerJoinGamePrivateError"
	/// Error when user wants to join a VIP server when the game is marked private
	/// English String: "You cannot join this VIP server because the game is private."
	/// </summary>
	public override string LabelVipServerJoinGamePrivateError => "你无法加入此 VIP 服务器，因为这是私人游戏。";

	/// <summary>
	/// Key: "Label.VipServersAbout"
	/// English String: "VIP servers let you play this game privately with friends, your clan, or people you invite!"
	/// </summary>
	public override string LabelVipServersAbout => "VIP 服务器让你可以私下与好友、部落或你邀请的人加入这款游戏！";

	/// <summary>
	/// Key: "Message.InvalidLink"
	/// Dialog content when the link to a VIP server is invalid
	/// English String: "This VIP Server link is no longer valid."
	/// </summary>
	public override string MessageInvalidLink => "此 VIP 服务器链接已失效。";

	public PrivateServersResources_zh_cn(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionCreateVipServer()
	{
		return "创建 VIP 服务器";
	}

	protected override string _GetTemplateForActionRefresh()
	{
		return "刷新";
	}

	protected override string _GetTemplateForHeadingInvalidLink()
	{
		return "无效链接";
	}

	protected override string _GetTemplateForHeadingVipServers()
	{
		return "VIP 服务器";
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
		return $"是否确定为“{creatorName}”所创作的“{placeName}”启用私人 VIP 版本预付款？";
	}

	protected override string _GetTemplateForLabelConfirmEnableFuturePayments()
	{
		return "是否确定为“{creatorName}”所创作的“{placeName}”启用私人 VIP 版本预付款？";
	}

	/// <summary>
	/// Key: "Label.CreateVipServerFor"
	/// English String: "Create a VIP Server for {target}?"
	/// </summary>
	public override string LabelCreateVipServerFor(string target)
	{
		return $"要为“{target}”创建一个 VIP 服务器？";
	}

	protected override string _GetTemplateForLabelCreateVipServerFor()
	{
		return "要为“{target}”创建一个 VIP 服务器？";
	}

	/// <summary>
	/// Key: "Label.FooterText"
	/// English String: "Your balance after this transaction will be {robuxIcon}. This is a subscription-based feature. It will auto-renew once a month until you cancel the subscription."
	/// </summary>
	public override string LabelFooterText(string robuxIcon)
	{
		return $"你在此次交易后的余额将为 {robuxIcon}。这是一项基于订阅的功能。它将每月自动续订一次，直至你取消订阅。";
	}

	protected override string _GetTemplateForLabelFooterText()
	{
		return "你在此次交易后的余额将为 {robuxIcon}。这是一项基于订阅的功能。它将每月自动续订一次，直至你取消订阅。";
	}

	protected override string _GetTemplateForLabelGameJoinPrivateErrorTitle()
	{
		return "无法加入";
	}

	protected override string _GetTemplateForLabelGameName()
	{
		return "游戏名称";
	}

	protected override string _GetTemplateForLabelNoVipServers()
	{
		return "未找到 VIP 服务器实例。";
	}

	protected override string _GetTemplateForLabelPlayWithOthers()
	{
		return "与好友和你邀请的其他人加入此游戏。";
	}

	protected override string _GetTemplateForLabelRenew()
	{
		return "续订";
	}

	protected override string _GetTemplateForLabelRenewPrivateServer()
	{
		return "续订私人服务器";
	}

	/// <summary>
	/// Key: "Label.SeeAllServers"
	/// English String: "See all your VIP servers in the {serversLink} tab."
	/// </summary>
	public override string LabelSeeAllServers(string serversLink)
	{
		return $"在{serversLink}标签页中可查看你所有的 VIP 服务器。";
	}

	protected override string _GetTemplateForLabelSeeAllServers()
	{
		return "在{serversLink}标签页中可查看你所有的 VIP 服务器。";
	}

	protected override string _GetTemplateForLabelServerName()
	{
		return "服务器名称";
	}

	protected override string _GetTemplateForLabelServers()
	{
		return "服务器";
	}

	/// <summary>
	/// Key: "Label.StartRenewingPrice"
	/// English String: "This VIP Server will start renewing every month at {price} until you cancel."
	/// </summary>
	public override string LabelStartRenewingPrice(string price)
	{
		return $"此 VIP 服务器每月将以 {price} 续订，直至你取消为止。";
	}

	protected override string _GetTemplateForLabelStartRenewingPrice()
	{
		return "此 VIP 服务器每月将以 {price} 续订，直至你取消为止。";
	}

	protected override string _GetTemplateForLabelVIPServerGameJoinErrorAcknowledgement()
	{
		return "好";
	}

	protected override string _GetTemplateForLabelVipServerJoinGamePrivateError()
	{
		return "你无法加入此 VIP 服务器，因为这是私人游戏。";
	}

	protected override string _GetTemplateForLabelVipServersAbout()
	{
		return "VIP 服务器让你可以私下与好友、部落或你邀请的人加入这款游戏！";
	}

	/// <summary>
	/// Key: "Label.VipServersNotSupported"
	/// English String: "This game does not support {vipServersLink}."
	/// </summary>
	public override string LabelVipServersNotSupported(string vipServersLink)
	{
		return $"此游戏不支持 {vipServersLink}。";
	}

	protected override string _GetTemplateForLabelVipServersNotSupported()
	{
		return "此游戏不支持 {vipServersLink}。";
	}

	protected override string _GetTemplateForMessageInvalidLink()
	{
		return "此 VIP 服务器链接已失效。";
	}
}
