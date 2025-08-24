namespace Roblox.TranslationResources.Feature;

/// <summary>
/// This class overrides ServerListResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class ServerListResources_ko_kr : ServerListResources_en_us, IServerListResources, ITranslationResources
{
	/// <summary>
	/// Key: "Action.ConfigureServer"
	/// Configure server
	/// English String: "Configure"
	/// </summary>
	public override string ActionConfigureServer => "구성";

	/// <summary>
	/// Key: "Action.LoadMore"
	/// English String: "Load More"
	/// </summary>
	public override string ActionLoadMore => "더 불러오기";

	/// <summary>
	/// Key: "Heading.OtherServers"
	/// English String: "Other Servers"
	/// </summary>
	public override string HeadingOtherServers => "기타 서버";

	/// <summary>
	/// Key: "Heading.RunningServers"
	/// English String: "All Running Servers"
	/// </summary>
	public override string HeadingRunningServers => "가동 중인 모든 서버";

	/// <summary>
	/// Key: "Heading.ServersMyFriendsAreIn"
	/// English String: "Servers My Friends Are In"
	/// </summary>
	public override string HeadingServersMyFriendsAreIn => "내 친구가 있는 서버";

	/// <summary>
	/// Key: "Label.Inactive"
	/// English String: "Inactive."
	/// </summary>
	public override string LabelInactive => "비활성.";

	/// <summary>
	/// Key: "Label.InsufficientFunds"
	/// English String: "This Server has been deactivated. We were not able to process the recurring payment due to insufficient funds in your account."
	/// </summary>
	public override string LabelInsufficientFunds => "서버가 비활성화되었습니다. 회원님 계정의 잔고가 부족하여 자동 이체를 하지 못했습니다. ";

	/// <summary>
	/// Key: "Label.MyVipServer"
	/// English String: "My VIP Server"
	/// </summary>
	public override string LabelMyVipServer => "내 VIP 서버";

	/// <summary>
	/// Key: "Label.NoServersFound"
	/// No Servers Found.
	/// English String: "No Servers Found."
	/// </summary>
	public override string LabelNoServersFound => "서버를 찾을 수 없음.";

	/// <summary>
	/// Key: "Label.NoVipServers"
	/// No VIP Server Instances Found.
	/// English String: "No VIP Server Instances Found."
	/// </summary>
	public override string LabelNoVipServers => "VIP 서버 인스턴스를 찾을 수 없음.";

	/// <summary>
	/// Key: "Label.PaymentCancelled"
	/// English String: "Payment Cancelled"
	/// </summary>
	public override string LabelPaymentCancelled => "결제 취소됨";

	/// <summary>
	/// Key: "Label.PlacesNotLoading"
	/// The list of places failed to load for some unknown reason.
	/// English String: "Sorry, something went wrong loading places."
	/// </summary>
	public override string LabelPlacesNotLoading => "죄송합니다. 장소를 불러오는 중에 오류가 발생했어요.";

	/// <summary>
	/// Key: "Label.ServerListJoin"
	/// English String: "Join"
	/// </summary>
	public override string LabelServerListJoin => "참가";

	/// <summary>
	/// Key: "Label.ServerListRenew"
	/// English String: "Renew"
	/// </summary>
	public override string LabelServerListRenew => "갱신";

	/// <summary>
	/// Key: "Label.ShutDownServer"
	/// User chooses to close their game server.
	/// English String: "Shut Down This Server"
	/// </summary>
	public override string LabelShutDownServer => "서버 종료";

	/// <summary>
	/// Key: "Label.SlowGame"
	/// English String: "Slow Game"
	/// </summary>
	public override string LabelSlowGame => "서버 느림";

	public ServerListResources_ko_kr(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionConfigureServer()
	{
		return "구성";
	}

	protected override string _GetTemplateForActionLoadMore()
	{
		return "더 불러오기";
	}

	protected override string _GetTemplateForHeadingOtherServers()
	{
		return "기타 서버";
	}

	protected override string _GetTemplateForHeadingRunningServers()
	{
		return "가동 중인 모든 서버";
	}

	protected override string _GetTemplateForHeadingServersMyFriendsAreIn()
	{
		return "내 친구가 있는 서버";
	}

	/// <summary>
	/// Key: "Label.CurrentPlayerCount"
	/// English String: "{currentPlayers} of {maximumAllowedPlayers} players max"
	/// </summary>
	public override string LabelCurrentPlayerCount(string currentPlayers, string maximumAllowedPlayers)
	{
		return $"{currentPlayers} / {maximumAllowedPlayers}명 (최대)";
	}

	protected override string _GetTemplateForLabelCurrentPlayerCount()
	{
		return "{currentPlayers} / {maximumAllowedPlayers}명 (최대)";
	}

	protected override string _GetTemplateForLabelInactive()
	{
		return "비활성.";
	}

	protected override string _GetTemplateForLabelInsufficientFunds()
	{
		return "서버가 비활성화되었습니다. 회원님 계정의 잔고가 부족하여 자동 이체를 하지 못했습니다. ";
	}

	protected override string _GetTemplateForLabelMyVipServer()
	{
		return "내 VIP 서버";
	}

	protected override string _GetTemplateForLabelNoServersFound()
	{
		return "서버를 찾을 수 없음.";
	}

	protected override string _GetTemplateForLabelNoVipServers()
	{
		return "VIP 서버 인스턴스를 찾을 수 없음.";
	}

	protected override string _GetTemplateForLabelPaymentCancelled()
	{
		return "결제 취소됨";
	}

	protected override string _GetTemplateForLabelPlacesNotLoading()
	{
		return "죄송합니다. 장소를 불러오는 중에 오류가 발생했어요.";
	}

	protected override string _GetTemplateForLabelServerListJoin()
	{
		return "참가";
	}

	protected override string _GetTemplateForLabelServerListRenew()
	{
		return "갱신";
	}

	protected override string _GetTemplateForLabelShutDownServer()
	{
		return "서버 종료";
	}

	protected override string _GetTemplateForLabelSlowGame()
	{
		return "서버 느림";
	}
}
