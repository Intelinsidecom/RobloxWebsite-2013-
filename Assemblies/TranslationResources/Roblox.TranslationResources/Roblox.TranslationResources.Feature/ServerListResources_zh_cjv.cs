namespace Roblox.TranslationResources.Feature;

/// <summary>
/// This class overrides ServerListResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class ServerListResources_zh_cjv : ServerListResources_en_us, IServerListResources, ITranslationResources
{
	/// <summary>
	/// Key: "Action.ConfigureServer"
	/// Configure server
	/// English String: "Configure"
	/// </summary>
	public override string ActionConfigureServer => "配置";

	/// <summary>
	/// Key: "Action.LoadMore"
	/// English String: "Load More"
	/// </summary>
	public override string ActionLoadMore => "加载更多";

	/// <summary>
	/// Key: "Heading.OtherServers"
	/// English String: "Other Servers"
	/// </summary>
	public override string HeadingOtherServers => "其他服务器";

	/// <summary>
	/// Key: "Heading.RunningServers"
	/// English String: "All Running Servers"
	/// </summary>
	public override string HeadingRunningServers => "所有运行中的服务器";

	/// <summary>
	/// Key: "Heading.ServersMyFriendsAreIn"
	/// English String: "Servers My Friends Are In"
	/// </summary>
	public override string HeadingServersMyFriendsAreIn => "我好友所在的服务器";

	/// <summary>
	/// Key: "Label.Inactive"
	/// English String: "Inactive."
	/// </summary>
	public override string LabelInactive => "不活跃。";

	/// <summary>
	/// Key: "Label.InsufficientFunds"
	/// English String: "This Server has been deactivated. We were not able to process the recurring payment due to insufficient funds in your account."
	/// </summary>
	public override string LabelInsufficientFunds => "此服务器已停用。由于你的帐户资金不足，我们无法处理周期性付款。";

	/// <summary>
	/// Key: "Label.MyVipServer"
	/// English String: "My VIP Server"
	/// </summary>
	public override string LabelMyVipServer => "我的 VIP 服务器";

	/// <summary>
	/// Key: "Label.NoServersFound"
	/// No Servers Found.
	/// English String: "No Servers Found."
	/// </summary>
	public override string LabelNoServersFound => "未找到服务器。";

	/// <summary>
	/// Key: "Label.NoVipServers"
	/// No VIP Server Instances Found.
	/// English String: "No VIP Server Instances Found."
	/// </summary>
	public override string LabelNoVipServers => "未找到 VIP 服务器实例。";

	/// <summary>
	/// Key: "Label.PaymentCancelled"
	/// English String: "Payment Cancelled"
	/// </summary>
	public override string LabelPaymentCancelled => "付款已取消";

	/// <summary>
	/// Key: "Label.PlacesNotLoading"
	/// The list of places failed to load for some unknown reason.
	/// English String: "Sorry, something went wrong loading places."
	/// </summary>
	public override string LabelPlacesNotLoading => "抱歉，加载地点时发生错误。";

	/// <summary>
	/// Key: "Label.ServerListJoin"
	/// English String: "Join"
	/// </summary>
	public override string LabelServerListJoin => "加入";

	/// <summary>
	/// Key: "Label.ServerListRenew"
	/// English String: "Renew"
	/// </summary>
	public override string LabelServerListRenew => "续订";

	/// <summary>
	/// Key: "Label.ShutDownServer"
	/// User chooses to close their game server.
	/// English String: "Shut Down This Server"
	/// </summary>
	public override string LabelShutDownServer => "关闭此服务器";

	/// <summary>
	/// Key: "Label.SlowGame"
	/// English String: "Slow Game"
	/// </summary>
	public override string LabelSlowGame => "慢速游戏";

	public ServerListResources_zh_cjv(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionConfigureServer()
	{
		return "配置";
	}

	protected override string _GetTemplateForActionLoadMore()
	{
		return "加载更多";
	}

	protected override string _GetTemplateForHeadingOtherServers()
	{
		return "其他服务器";
	}

	protected override string _GetTemplateForHeadingRunningServers()
	{
		return "所有运行中的服务器";
	}

	protected override string _GetTemplateForHeadingServersMyFriendsAreIn()
	{
		return "我好友所在的服务器";
	}

	/// <summary>
	/// Key: "Label.CurrentPlayerCount"
	/// English String: "{currentPlayers} of {maximumAllowedPlayers} players max"
	/// </summary>
	public override string LabelCurrentPlayerCount(string currentPlayers, string maximumAllowedPlayers)
	{
		return $"{currentPlayers} 位玩家，最多 {maximumAllowedPlayers} 位";
	}

	protected override string _GetTemplateForLabelCurrentPlayerCount()
	{
		return "{currentPlayers} 位玩家，最多 {maximumAllowedPlayers} 位";
	}

	protected override string _GetTemplateForLabelInactive()
	{
		return "不活跃。";
	}

	protected override string _GetTemplateForLabelInsufficientFunds()
	{
		return "此服务器已停用。由于你的帐户资金不足，我们无法处理周期性付款。";
	}

	protected override string _GetTemplateForLabelMyVipServer()
	{
		return "我的 VIP 服务器";
	}

	protected override string _GetTemplateForLabelNoServersFound()
	{
		return "未找到服务器。";
	}

	protected override string _GetTemplateForLabelNoVipServers()
	{
		return "未找到 VIP 服务器实例。";
	}

	protected override string _GetTemplateForLabelPaymentCancelled()
	{
		return "付款已取消";
	}

	protected override string _GetTemplateForLabelPlacesNotLoading()
	{
		return "抱歉，加载地点时发生错误。";
	}

	protected override string _GetTemplateForLabelServerListJoin()
	{
		return "加入";
	}

	protected override string _GetTemplateForLabelServerListRenew()
	{
		return "续订";
	}

	protected override string _GetTemplateForLabelShutDownServer()
	{
		return "关闭此服务器";
	}

	protected override string _GetTemplateForLabelSlowGame()
	{
		return "慢速游戏";
	}
}
