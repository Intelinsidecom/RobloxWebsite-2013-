namespace Roblox.TranslationResources.Feature;

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
	public override string ActionCreateVipServer => "VIP 서버 만들기";

	/// <summary>
	/// Key: "Action.Refresh"
	/// English String: "Refresh"
	/// </summary>
	public override string ActionRefresh => "새로 고침";

	/// <summary>
	/// Key: "Heading.InvalidLink"
	/// Dialog title when the link to a VIP server is invalid
	/// English String: "Invalid Link"
	/// </summary>
	public override string HeadingInvalidLink => "유효하지 않은 링크";

	/// <summary>
	/// Key: "Heading.VipServers"
	/// English String: "VIP Servers"
	/// </summary>
	public override string HeadingVipServers => "VIP 서버";

	/// <summary>
	/// Key: "Label.Cancel"
	/// English String: "Cancel"
	/// </summary>
	public override string LabelCancel => "취소";

	/// <summary>
	/// Key: "Label.GameJoinPrivateErrorTitle"
	/// Title of error window when trying to join a private server user does not have access to.
	/// English String: "Unable to join"
	/// </summary>
	public override string LabelGameJoinPrivateErrorTitle => "참가 불가";

	/// <summary>
	/// Key: "Label.GameName"
	/// English String: "Game Name"
	/// </summary>
	public override string LabelGameName => "게임 이름";

	/// <summary>
	/// Key: "Label.NoVipServers"
	/// No VIP Server Instances Found.
	/// English String: "No VIP Server Instances Found."
	/// </summary>
	public override string LabelNoVipServers => "VIP 서버 인스턴스를 찾을 수 없어요.";

	/// <summary>
	/// Key: "Label.PlayWithOthers"
	/// English String: "Play this game with friends and other people you invite."
	/// </summary>
	public override string LabelPlayWithOthers => "친구뿐 아니라 다른 사람들도 초대해 함께 게임을 즐겨보세요.";

	/// <summary>
	/// Key: "Label.Renew"
	/// English String: "Renew"
	/// </summary>
	public override string LabelRenew => "갱신";

	/// <summary>
	/// Key: "Label.RenewPrivateServer"
	/// English String: "Renew Private Server"
	/// </summary>
	public override string LabelRenewPrivateServer => "비공개 서버 갱신";

	/// <summary>
	/// Key: "Label.ServerName"
	/// English String: "Server Name"
	/// </summary>
	public override string LabelServerName => "서버 이름";

	/// <summary>
	/// Key: "Label.Servers"
	/// English String: "Servers"
	/// </summary>
	public override string LabelServers => "서버";

	/// <summary>
	/// Key: "Label.VIPServerGameJoinErrorAcknowledgement"
	/// Confirmation text for game join private error dialog.
	/// English String: "OK"
	/// </summary>
	public override string LabelVIPServerGameJoinErrorAcknowledgement => "확인";

	/// <summary>
	/// Key: "Label.VipServerJoinGamePrivateError"
	/// Error when user wants to join a VIP server when the game is marked private
	/// English String: "You cannot join this VIP server because the game is private."
	/// </summary>
	public override string LabelVipServerJoinGamePrivateError => "비공개 게임이므로 본 VIP 서버에 연결할 수 없어요.";

	/// <summary>
	/// Key: "Label.VipServersAbout"
	/// English String: "VIP servers let you play this game privately with friends, your clan, or people you invite!"
	/// </summary>
	public override string LabelVipServersAbout => "VIP 서버에서는 친구, 클랜 혹은 초대한 사람들과 함께 비공개로 게임을 즐길 수 있어요!";

	/// <summary>
	/// Key: "Message.InvalidLink"
	/// Dialog content when the link to a VIP server is invalid
	/// English String: "This VIP Server link is no longer valid."
	/// </summary>
	public override string MessageInvalidLink => "VIP 서버 링크가 더 이상 유효하지 않습니다.";

	public PrivateServersResources_ko_kr(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionCreateVipServer()
	{
		return "VIP 서버 만들기";
	}

	protected override string _GetTemplateForActionRefresh()
	{
		return "새로 고침";
	}

	protected override string _GetTemplateForHeadingInvalidLink()
	{
		return "유효하지 않은 링크";
	}

	protected override string _GetTemplateForHeadingVipServers()
	{
		return "VIP 서버";
	}

	protected override string _GetTemplateForLabelCancel()
	{
		return "취소";
	}

	/// <summary>
	/// Key: "Label.ConfirmEnableFuturePayments"
	/// English String: "Are you sure you want to enable future payments for your private VIP version of {placeName} by {creatorName}?"
	/// </summary>
	public override string LabelConfirmEnableFuturePayments(string placeName, string creatorName)
	{
		return $"{creatorName}님이 만든 {placeName} 비공개 VIP 버전에 대한 향후 결제를 정말 활성화하시겠습니까?";
	}

	protected override string _GetTemplateForLabelConfirmEnableFuturePayments()
	{
		return "{creatorName}님이 만든 {placeName} 비공개 VIP 버전에 대한 향후 결제를 정말 활성화하시겠습니까?";
	}

	/// <summary>
	/// Key: "Label.CreateVipServerFor"
	/// English String: "Create a VIP Server for {target}?"
	/// </summary>
	public override string LabelCreateVipServerFor(string target)
	{
		return $"{target}을(를) 위한 VIP 서버를 만들까요?";
	}

	protected override string _GetTemplateForLabelCreateVipServerFor()
	{
		return "{target}을(를) 위한 VIP 서버를 만들까요?";
	}

	/// <summary>
	/// Key: "Label.FooterText"
	/// English String: "Your balance after this transaction will be {robuxIcon}. This is a subscription-based feature. It will auto-renew once a month until you cancel the subscription."
	/// </summary>
	public override string LabelFooterText(string robuxIcon)
	{
		return $"본 거래 후의 예상 잔액은 {robuxIcon}입니다. 본 기능은 가입을 하셔야 사용할 수 있는 기능으로 취소할 때까지 매달 자동으로 갱신됩니다.";
	}

	protected override string _GetTemplateForLabelFooterText()
	{
		return "본 거래 후의 예상 잔액은 {robuxIcon}입니다. 본 기능은 가입을 하셔야 사용할 수 있는 기능으로 취소할 때까지 매달 자동으로 갱신됩니다.";
	}

	protected override string _GetTemplateForLabelGameJoinPrivateErrorTitle()
	{
		return "참가 불가";
	}

	protected override string _GetTemplateForLabelGameName()
	{
		return "게임 이름";
	}

	protected override string _GetTemplateForLabelNoVipServers()
	{
		return "VIP 서버 인스턴스를 찾을 수 없어요.";
	}

	protected override string _GetTemplateForLabelPlayWithOthers()
	{
		return "친구뿐 아니라 다른 사람들도 초대해 함께 게임을 즐겨보세요.";
	}

	protected override string _GetTemplateForLabelRenew()
	{
		return "갱신";
	}

	protected override string _GetTemplateForLabelRenewPrivateServer()
	{
		return "비공개 서버 갱신";
	}

	/// <summary>
	/// Key: "Label.SeeAllServers"
	/// English String: "See all your VIP servers in the {serversLink} tab."
	/// </summary>
	public override string LabelSeeAllServers(string serversLink)
	{
		return $"{serversLink} 탭에서 본인의 VIP 서버를 모두 확인하실 수 있습니다. ";
	}

	protected override string _GetTemplateForLabelSeeAllServers()
	{
		return "{serversLink} 탭에서 본인의 VIP 서버를 모두 확인하실 수 있습니다. ";
	}

	protected override string _GetTemplateForLabelServerName()
	{
		return "서버 이름";
	}

	protected override string _GetTemplateForLabelServers()
	{
		return "서버";
	}

	/// <summary>
	/// Key: "Label.StartRenewingPrice"
	/// English String: "This VIP Server will start renewing every month at {price} until you cancel."
	/// </summary>
	public override string LabelStartRenewingPrice(string price)
	{
		return $"본 VIP 서버는 취소할 때까지 매달 {price} 의 가격에 갱신됩니다.";
	}

	protected override string _GetTemplateForLabelStartRenewingPrice()
	{
		return "본 VIP 서버는 취소할 때까지 매달 {price} 의 가격에 갱신됩니다.";
	}

	protected override string _GetTemplateForLabelVIPServerGameJoinErrorAcknowledgement()
	{
		return "확인";
	}

	protected override string _GetTemplateForLabelVipServerJoinGamePrivateError()
	{
		return "비공개 게임이므로 본 VIP 서버에 연결할 수 없어요.";
	}

	protected override string _GetTemplateForLabelVipServersAbout()
	{
		return "VIP 서버에서는 친구, 클랜 혹은 초대한 사람들과 함께 비공개로 게임을 즐길 수 있어요!";
	}

	/// <summary>
	/// Key: "Label.VipServersNotSupported"
	/// English String: "This game does not support {vipServersLink}."
	/// </summary>
	public override string LabelVipServersNotSupported(string vipServersLink)
	{
		return $"{vipServersLink}을(를) 지원하지 않는 게임입니다.";
	}

	protected override string _GetTemplateForLabelVipServersNotSupported()
	{
		return "{vipServersLink}을(를) 지원하지 않는 게임입니다.";
	}

	protected override string _GetTemplateForMessageInvalidLink()
	{
		return "VIP 서버 링크가 더 이상 유효하지 않습니다.";
	}
}
