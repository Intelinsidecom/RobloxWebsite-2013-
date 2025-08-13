namespace Roblox.TranslationResources.Feature;

/// <summary>
/// This class overrides ServerListResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class ServerListResources_ja_jp : ServerListResources_en_us, IServerListResources, ITranslationResources
{
	/// <summary>
	/// Key: "Action.ConfigureServer"
	/// Configure server
	/// English String: "Configure"
	/// </summary>
	public override string ActionConfigureServer => "環境設定する";

	/// <summary>
	/// Key: "Action.LoadMore"
	/// English String: "Load More"
	/// </summary>
	public override string ActionLoadMore => "さらに読み込む";

	/// <summary>
	/// Key: "Heading.OtherServers"
	/// English String: "Other Servers"
	/// </summary>
	public override string HeadingOtherServers => "その他のサーバー";

	/// <summary>
	/// Key: "Heading.RunningServers"
	/// English String: "All Running Servers"
	/// </summary>
	public override string HeadingRunningServers => "すべての実行中サーバー";

	/// <summary>
	/// Key: "Heading.ServersMyFriendsAreIn"
	/// English String: "Servers My Friends Are In"
	/// </summary>
	public override string HeadingServersMyFriendsAreIn => "友達のいるサーバー";

	/// <summary>
	/// Key: "Label.Inactive"
	/// English String: "Inactive."
	/// </summary>
	public override string LabelInactive => "停止。";

	/// <summary>
	/// Key: "Label.InsufficientFunds"
	/// English String: "This Server has been deactivated. We were not able to process the recurring payment due to insufficient funds in your account."
	/// </summary>
	public override string LabelInsufficientFunds => "このサーバーは解除されました。アカウントの資金が不足しているため、支払い処理ができませんでした。";

	/// <summary>
	/// Key: "Label.MyVipServer"
	/// English String: "My VIP Server"
	/// </summary>
	public override string LabelMyVipServer => "あなたのVIPサーバー";

	/// <summary>
	/// Key: "Label.NoServersFound"
	/// No Servers Found.
	/// English String: "No Servers Found."
	/// </summary>
	public override string LabelNoServersFound => "サーバーが見つかりません。";

	/// <summary>
	/// Key: "Label.NoVipServers"
	/// No VIP Server Instances Found.
	/// English String: "No VIP Server Instances Found."
	/// </summary>
	public override string LabelNoVipServers => "VIPサーバーのインスタンスが見つかりません。";

	/// <summary>
	/// Key: "Label.PaymentCancelled"
	/// English String: "Payment Cancelled"
	/// </summary>
	public override string LabelPaymentCancelled => "支払いがキャンセルされました";

	/// <summary>
	/// Key: "Label.PlacesNotLoading"
	/// The list of places failed to load for some unknown reason.
	/// English String: "Sorry, something went wrong loading places."
	/// </summary>
	public override string LabelPlacesNotLoading => "申し訳ありません。プレースの読み込み中に問題が発生しました。";

	/// <summary>
	/// Key: "Label.ServerListJoin"
	/// English String: "Join"
	/// </summary>
	public override string LabelServerListJoin => "参加";

	/// <summary>
	/// Key: "Label.ServerListRenew"
	/// English String: "Renew"
	/// </summary>
	public override string LabelServerListRenew => "更新";

	/// <summary>
	/// Key: "Label.ShutDownServer"
	/// User chooses to close their game server.
	/// English String: "Shut Down This Server"
	/// </summary>
	public override string LabelShutDownServer => "このサーバーをシャットダウンする";

	/// <summary>
	/// Key: "Label.SlowGame"
	/// English String: "Slow Game"
	/// </summary>
	public override string LabelSlowGame => "遅いゲーム";

	public ServerListResources_ja_jp(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionConfigureServer()
	{
		return "環境設定する";
	}

	protected override string _GetTemplateForActionLoadMore()
	{
		return "さらに読み込む";
	}

	protected override string _GetTemplateForHeadingOtherServers()
	{
		return "その他のサーバー";
	}

	protected override string _GetTemplateForHeadingRunningServers()
	{
		return "すべての実行中サーバー";
	}

	protected override string _GetTemplateForHeadingServersMyFriendsAreIn()
	{
		return "友達のいるサーバー";
	}

	/// <summary>
	/// Key: "Label.CurrentPlayerCount"
	/// English String: "{currentPlayers} of {maximumAllowedPlayers} players max"
	/// </summary>
	public override string LabelCurrentPlayerCount(string currentPlayers, string maximumAllowedPlayers)
	{
		return $"最大{maximumAllowedPlayers}人中{currentPlayers}人のプレイヤー";
	}

	protected override string _GetTemplateForLabelCurrentPlayerCount()
	{
		return "最大{maximumAllowedPlayers}人中{currentPlayers}人のプレイヤー";
	}

	protected override string _GetTemplateForLabelInactive()
	{
		return "停止。";
	}

	protected override string _GetTemplateForLabelInsufficientFunds()
	{
		return "このサーバーは解除されました。アカウントの資金が不足しているため、支払い処理ができませんでした。";
	}

	protected override string _GetTemplateForLabelMyVipServer()
	{
		return "あなたのVIPサーバー";
	}

	protected override string _GetTemplateForLabelNoServersFound()
	{
		return "サーバーが見つかりません。";
	}

	protected override string _GetTemplateForLabelNoVipServers()
	{
		return "VIPサーバーのインスタンスが見つかりません。";
	}

	protected override string _GetTemplateForLabelPaymentCancelled()
	{
		return "支払いがキャンセルされました";
	}

	protected override string _GetTemplateForLabelPlacesNotLoading()
	{
		return "申し訳ありません。プレースの読み込み中に問題が発生しました。";
	}

	protected override string _GetTemplateForLabelServerListJoin()
	{
		return "参加";
	}

	protected override string _GetTemplateForLabelServerListRenew()
	{
		return "更新";
	}

	protected override string _GetTemplateForLabelShutDownServer()
	{
		return "このサーバーをシャットダウンする";
	}

	protected override string _GetTemplateForLabelSlowGame()
	{
		return "遅いゲーム";
	}
}
