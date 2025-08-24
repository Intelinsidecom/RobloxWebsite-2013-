namespace Roblox.TranslationResources.Feature;

/// <summary>
/// This class overrides VIPServerResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class VIPServerResources_ko_kr : VIPServerResources_en_us, IVIPServerResources, ITranslationResources
{
	/// <summary>
	/// Key: "Action.Add"
	/// English String: "Add"
	/// </summary>
	public override string ActionAdd => "추가";

	/// <summary>
	/// Key: "Action.AddPlayers"
	/// English String: "Add Players"
	/// </summary>
	public override string ActionAddPlayers => "플레이어 추가";

	/// <summary>
	/// Key: "Action.Cancel"
	/// English String: "Cancel"
	/// </summary>
	public override string ActionCancel => "취소";

	/// <summary>
	/// Key: "Action.CancelPayments"
	/// English String: "Cancel Payments"
	/// </summary>
	public override string ActionCancelPayments => "결제 취소";

	/// <summary>
	/// Key: "Action.ChangeName"
	/// English String: "Change Name"
	/// </summary>
	public override string ActionChangeName => "이름 변경";

	/// <summary>
	/// Key: "Action.GoBack"
	/// English String: "Go Back"
	/// </summary>
	public override string ActionGoBack => "돌아가기";

	/// <summary>
	/// Key: "Action.RegenerateJoinLink"
	/// English String: "Regenerate"
	/// </summary>
	public override string ActionRegenerateJoinLink => "다시 만들기";

	/// <summary>
	/// Key: "Action.Remove"
	/// English String: "Remove"
	/// </summary>
	public override string ActionRemove => "삭제";

	/// <summary>
	/// Key: "Action.RenewVipServer"
	/// English String: "Renew VIP Server"
	/// </summary>
	public override string ActionRenewVipServer => "VIP 서버 갱신";

	/// <summary>
	/// Key: "Action.SeeAll"
	/// English String: "See All"
	/// </summary>
	public override string ActionSeeAll => "전체 보기";

	/// <summary>
	/// Key: "Heading.CancelPayments"
	/// English String: "Cancel Payments"
	/// </summary>
	public override string HeadingCancelPayments => "결제 취소";

	/// <summary>
	/// Key: "Heading.ChangeName"
	/// English String: "Change VIP Server Name"
	/// </summary>
	public override string HeadingChangeName => "VIP 서버 이름 변경";

	/// <summary>
	/// Key: "Heading.ConfigureVipServer"
	/// English String: "Configure VIP Server"
	/// </summary>
	public override string HeadingConfigureVipServer => "VIP 서버 구성";

	/// <summary>
	/// Key: "Heading.RemovePlayer"
	/// English String: "Remove Player"
	/// </summary>
	public override string HeadingRemovePlayer => "플레이어 삭제";

	/// <summary>
	/// Key: "Heading.RenewVipServer"
	/// English String: "Renew VIP Server"
	/// </summary>
	public override string HeadingRenewVipServer => "VIP 서버 갱신";

	/// <summary>
	/// Key: "Label.ChangeNamePlaceholder"
	/// English String: "VIP Server Name (1-50 Characters)"
	/// </summary>
	public override string LabelChangeNamePlaceholder => "VIP 서버 이름 (1~50자)";

	/// <summary>
	/// Key: "Label.ClanAccess"
	/// English String: "Clan Access"
	/// </summary>
	public override string LabelClanAccess => "클랜 접근";

	/// <summary>
	/// Key: "Label.FriendsAllowed"
	/// English String: "Friends Allowed"
	/// </summary>
	public override string LabelFriendsAllowed => "허용된 친구";

	/// <summary>
	/// Key: "Label.GameName"
	/// English String: "Game Name"
	/// </summary>
	public override string LabelGameName => "게임 이름";

	/// <summary>
	/// Key: "Label.JoinGameLink"
	/// English String: "Join Game Link..."
	/// </summary>
	public override string LabelJoinGameLink => "게임 링크 참가...";

	/// <summary>
	/// Key: "Label.None"
	/// English String: "None"
	/// </summary>
	public override string LabelNone => "없음";

	/// <summary>
	/// Key: "Label.Off"
	/// English String: "Off"
	/// </summary>
	public override string LabelOff => "끄기";

	/// <summary>
	/// Key: "Label.On"
	/// English String: "On"
	/// </summary>
	public override string LabelOn => "켜기";

	/// <summary>
	/// Key: "Label.PickEnemyClan"
	/// English String: "Pick Enemy Clan"
	/// </summary>
	public override string LabelPickEnemyClan => "적 클랜 선택";

	/// <summary>
	/// Key: "Label.SearchForPlayers"
	/// English String: "Search for Players"
	/// </summary>
	public override string LabelSearchForPlayers => "플레이어 검색";

	/// <summary>
	/// Key: "Label.Server"
	/// English String: "Server"
	/// </summary>
	public override string LabelServer => "서버";

	/// <summary>
	/// Key: "Label.ServerMembers"
	/// English String: "Server Members"
	/// </summary>
	public override string LabelServerMembers => "서버 멤버";

	/// <summary>
	/// Key: "Label.SubscriptionStatus"
	/// English String: "Subscription Status"
	/// </summary>
	public override string LabelSubscriptionStatus => "가입 상태";

	/// <summary>
	/// Key: "Label.VIPServerLink"
	/// English String: "VIP Server Link"
	/// </summary>
	public override string LabelVIPServerLink => "VIP 서버 링크";

	/// <summary>
	/// Key: "Label.VIPServerStatus"
	/// English String: "VIP Server Status"
	/// </summary>
	public override string LabelVIPServerStatus => "VIP 서버 상태";

	/// <summary>
	/// Key: "Label.YourClan"
	/// English String: "Your Clan"
	/// </summary>
	public override string LabelYourClan => "회원님의 클랜";

	public VIPServerResources_ko_kr(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionAdd()
	{
		return "추가";
	}

	protected override string _GetTemplateForActionAddPlayers()
	{
		return "플레이어 추가";
	}

	protected override string _GetTemplateForActionCancel()
	{
		return "취소";
	}

	protected override string _GetTemplateForActionCancelPayments()
	{
		return "결제 취소";
	}

	protected override string _GetTemplateForActionChangeName()
	{
		return "이름 변경";
	}

	protected override string _GetTemplateForActionGoBack()
	{
		return "돌아가기";
	}

	protected override string _GetTemplateForActionRegenerateJoinLink()
	{
		return "다시 만들기";
	}

	protected override string _GetTemplateForActionRemove()
	{
		return "삭제";
	}

	protected override string _GetTemplateForActionRenewVipServer()
	{
		return "VIP 서버 갱신";
	}

	protected override string _GetTemplateForActionSeeAll()
	{
		return "전체 보기";
	}

	protected override string _GetTemplateForHeadingCancelPayments()
	{
		return "결제 취소";
	}

	protected override string _GetTemplateForHeadingChangeName()
	{
		return "VIP 서버 이름 변경";
	}

	protected override string _GetTemplateForHeadingConfigureVipServer()
	{
		return "VIP 서버 구성";
	}

	protected override string _GetTemplateForHeadingRemovePlayer()
	{
		return "플레이어 삭제";
	}

	protected override string _GetTemplateForHeadingRenewVipServer()
	{
		return "VIP 서버 갱신";
	}

	/// <summary>
	/// Key: "Label.ChangeNameBodyMessage"
	/// English String: "Are you sure you want to cancel future payments for your VIP Server of {name} by {creator}? If you cancel, your VIP Server will be deactivated on {date}."
	/// </summary>
	public override string LabelChangeNameBodyMessage(string name, string creator, string date)
	{
		return $"{creator}님이 만든 {name} VIP 서버에 대한 향후 결제를 정말 취소할까요? 취소하면 회원님의 VIP 서버는 {date}에 비활성화 상태로 변경됩니다.";
	}

	protected override string _GetTemplateForLabelChangeNameBodyMessage()
	{
		return "{creator}님이 만든 {name} VIP 서버에 대한 향후 결제를 정말 취소할까요? 취소하면 회원님의 VIP 서버는 {date}에 비활성화 상태로 변경됩니다.";
	}

	protected override string _GetTemplateForLabelChangeNamePlaceholder()
	{
		return "VIP 서버 이름 (1~50자)";
	}

	protected override string _GetTemplateForLabelClanAccess()
	{
		return "클랜 접근";
	}

	protected override string _GetTemplateForLabelFriendsAllowed()
	{
		return "허용된 친구";
	}

	protected override string _GetTemplateForLabelGameName()
	{
		return "게임 이름";
	}

	protected override string _GetTemplateForLabelJoinGameLink()
	{
		return "게임 링크 참가...";
	}

	protected override string _GetTemplateForLabelNone()
	{
		return "없음";
	}

	protected override string _GetTemplateForLabelOff()
	{
		return "끄기";
	}

	protected override string _GetTemplateForLabelOn()
	{
		return "켜기";
	}

	protected override string _GetTemplateForLabelPickEnemyClan()
	{
		return "적 클랜 선택";
	}

	/// <summary>
	/// Key: "Label.RemovePlayerBodyMessage"
	/// English String: "Are you sure you want to remove {name} from your VIP Server? They will no longer be able to join your VIP Server."
	/// </summary>
	public override string LabelRemovePlayerBodyMessage(string name)
	{
		return $"VIP 서버에서 {name}님을 정말 삭제할까요? 삭제된 사용자는 회원님의 VIP 서버에 다시 참가할 수 없습니다.";
	}

	protected override string _GetTemplateForLabelRemovePlayerBodyMessage()
	{
		return "VIP 서버에서 {name}님을 정말 삭제할까요? 삭제된 사용자는 회원님의 VIP 서버에 다시 참가할 수 없습니다.";
	}

	/// <summary>
	/// Key: "Label.RenewVipServerBodyMessageConfirmation"
	/// English String: "Are you sure you want to enable future payments for your VIP Server of {name} by {creator}?"
	/// </summary>
	public override string LabelRenewVipServerBodyMessageConfirmation(string name, string creator)
	{
		return $"{creator}님이 만든 {name} VIP 서버에 대한 향후 결제를 정말 활성화하시겠습니까?";
	}

	protected override string _GetTemplateForLabelRenewVipServerBodyMessageConfirmation()
	{
		return "{creator}님이 만든 {name} VIP 서버에 대한 향후 결제를 정말 활성화하시겠습니까?";
	}

	/// <summary>
	/// Key: "Label.RenewVipServerBodyMessageStart"
	/// English String: "This VIP Server will start renewing every month at {date} until you cancel."
	/// </summary>
	public override string LabelRenewVipServerBodyMessageStart(string date)
	{
		return $"본 VIP 서버는 취소할 때까지 매달 {date}에 갱신됩니다.";
	}

	protected override string _GetTemplateForLabelRenewVipServerBodyMessageStart()
	{
		return "본 VIP 서버는 취소할 때까지 매달 {date}에 갱신됩니다.";
	}

	protected override string _GetTemplateForLabelSearchForPlayers()
	{
		return "플레이어 검색";
	}

	protected override string _GetTemplateForLabelServer()
	{
		return "서버";
	}

	/// <summary>
	/// Key: "Label.ServerExpirationDate"
	/// English String: "Your VIP Server expired on{date}"
	/// </summary>
	public override string LabelServerExpirationDate(string date)
	{
		return $"VIP 서버 종료일: {date}";
	}

	protected override string _GetTemplateForLabelServerExpirationDate()
	{
		return "VIP 서버 종료일: {date}";
	}

	protected override string _GetTemplateForLabelServerMembers()
	{
		return "서버 멤버";
	}

	/// <summary>
	/// Key: "Label.SubscriptionChargeDate"
	/// English String: "You will be charged again on {date}"
	/// </summary>
	public override string LabelSubscriptionChargeDate(string date)
	{
		return $"다음 결제 예정일: {date}";
	}

	protected override string _GetTemplateForLabelSubscriptionChargeDate()
	{
		return "다음 결제 예정일: {date}";
	}

	/// <summary>
	/// Key: "Label.SubscriptionMonthlyPaymentDue"
	/// English String: "Your VIP Server monthly payment is {value}"
	/// </summary>
	public override string LabelSubscriptionMonthlyPaymentDue(string value)
	{
		return $"VIP 월간 서버 요금: {value}";
	}

	protected override string _GetTemplateForLabelSubscriptionMonthlyPaymentDue()
	{
		return "VIP 월간 서버 요금: {value}";
	}

	protected override string _GetTemplateForLabelSubscriptionStatus()
	{
		return "가입 상태";
	}

	protected override string _GetTemplateForLabelVIPServerLink()
	{
		return "VIP 서버 링크";
	}

	protected override string _GetTemplateForLabelVIPServerStatus()
	{
		return "VIP 서버 상태";
	}

	protected override string _GetTemplateForLabelYourClan()
	{
		return "회원님의 클랜";
	}
}
