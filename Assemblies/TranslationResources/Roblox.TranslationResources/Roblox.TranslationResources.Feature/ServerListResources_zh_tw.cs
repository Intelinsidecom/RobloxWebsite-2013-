namespace Roblox.TranslationResources.Feature;

/// <summary>
/// This class overrides ServerListResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class ServerListResources_zh_tw : ServerListResources_en_us, IServerListResources, ITranslationResources
{
	/// <summary>
	/// Key: "Action.ConfigureServer"
	/// Configure server
	/// English String: "Configure"
	/// </summary>
	public override string ActionConfigureServer => "設定";

	/// <summary>
	/// Key: "Action.LoadMore"
	/// English String: "Load More"
	/// </summary>
	public override string ActionLoadMore => "載入更多";

	/// <summary>
	/// Key: "Heading.OtherServers"
	/// English String: "Other Servers"
	/// </summary>
	public override string HeadingOtherServers => "其它伺服器";

	/// <summary>
	/// Key: "Heading.RunningServers"
	/// English String: "All Running Servers"
	/// </summary>
	public override string HeadingRunningServers => "所有正在運作的伺服器";

	/// <summary>
	/// Key: "Heading.ServersMyFriendsAreIn"
	/// English String: "Servers My Friends Are In"
	/// </summary>
	public override string HeadingServersMyFriendsAreIn => "我的好友所在的伺服器";

	/// <summary>
	/// Key: "Label.Inactive"
	/// English String: "Inactive."
	/// </summary>
	public override string LabelInactive => "未啟用。";

	/// <summary>
	/// Key: "Label.InsufficientFunds"
	/// English String: "This Server has been deactivated. We were not able to process the recurring payment due to insufficient funds in your account."
	/// </summary>
	public override string LabelInsufficientFunds => "此伺服器已關閉。由於您的帳號資金不足，無法為您進行定期付款。";

	/// <summary>
	/// Key: "Label.MyVipServer"
	/// English String: "My VIP Server"
	/// </summary>
	public override string LabelMyVipServer => "我的 VIP 伺服器";

	/// <summary>
	/// Key: "Label.NoServersFound"
	/// No Servers Found.
	/// English String: "No Servers Found."
	/// </summary>
	public override string LabelNoServersFound => "找不到伺服器。";

	/// <summary>
	/// Key: "Label.NoVipServers"
	/// No VIP Server Instances Found.
	/// English String: "No VIP Server Instances Found."
	/// </summary>
	public override string LabelNoVipServers => "找不到 VIP 伺服器。";

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
	public override string LabelPlacesNotLoading => "對不起，載入空間時發生錯誤。";

	/// <summary>
	/// Key: "Label.ServerListJoin"
	/// English String: "Join"
	/// </summary>
	public override string LabelServerListJoin => "加入";

	/// <summary>
	/// Key: "Label.ServerListRenew"
	/// English String: "Renew"
	/// </summary>
	public override string LabelServerListRenew => "續訂";

	/// <summary>
	/// Key: "Label.ShutDownServer"
	/// User chooses to close their game server.
	/// English String: "Shut Down This Server"
	/// </summary>
	public override string LabelShutDownServer => "關閉此伺服器";

	/// <summary>
	/// Key: "Label.SlowGame"
	/// English String: "Slow Game"
	/// </summary>
	public override string LabelSlowGame => "運作緩慢";

	public ServerListResources_zh_tw(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionConfigureServer()
	{
		return "設定";
	}

	protected override string _GetTemplateForActionLoadMore()
	{
		return "載入更多";
	}

	protected override string _GetTemplateForHeadingOtherServers()
	{
		return "其它伺服器";
	}

	protected override string _GetTemplateForHeadingRunningServers()
	{
		return "所有正在運作的伺服器";
	}

	protected override string _GetTemplateForHeadingServersMyFriendsAreIn()
	{
		return "我的好友所在的伺服器";
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
		return "未啟用。";
	}

	protected override string _GetTemplateForLabelInsufficientFunds()
	{
		return "此伺服器已關閉。由於您的帳號資金不足，無法為您進行定期付款。";
	}

	protected override string _GetTemplateForLabelMyVipServer()
	{
		return "我的 VIP 伺服器";
	}

	protected override string _GetTemplateForLabelNoServersFound()
	{
		return "找不到伺服器。";
	}

	protected override string _GetTemplateForLabelNoVipServers()
	{
		return "找不到 VIP 伺服器。";
	}

	protected override string _GetTemplateForLabelPaymentCancelled()
	{
		return "付款已取消";
	}

	protected override string _GetTemplateForLabelPlacesNotLoading()
	{
		return "對不起，載入空間時發生錯誤。";
	}

	protected override string _GetTemplateForLabelServerListJoin()
	{
		return "加入";
	}

	protected override string _GetTemplateForLabelServerListRenew()
	{
		return "續訂";
	}

	protected override string _GetTemplateForLabelShutDownServer()
	{
		return "關閉此伺服器";
	}

	protected override string _GetTemplateForLabelSlowGame()
	{
		return "運作緩慢";
	}
}
