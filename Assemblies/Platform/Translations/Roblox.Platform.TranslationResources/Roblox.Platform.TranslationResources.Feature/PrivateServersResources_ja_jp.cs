namespace Roblox.TranslationResources.Feature;

/// <summary>
/// This class overrides PrivateServersResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class PrivateServersResources_ja_jp : PrivateServersResources_en_us, IPrivateServersResources, ITranslationResources
{
	/// <summary>
	/// Key: "Action.CreateVipServer"
	/// English String: "Create VIP Server"
	/// </summary>
	public override string ActionCreateVipServer => "VIPサーバーの作成";

	/// <summary>
	/// Key: "Action.Refresh"
	/// English String: "Refresh"
	/// </summary>
	public override string ActionRefresh => "リフレッシュ";

	/// <summary>
	/// Key: "Heading.InvalidLink"
	/// Dialog title when the link to a VIP server is invalid
	/// English String: "Invalid Link"
	/// </summary>
	public override string HeadingInvalidLink => "無効なリンク";

	/// <summary>
	/// Key: "Heading.VipServers"
	/// English String: "VIP Servers"
	/// </summary>
	public override string HeadingVipServers => "VIPサーバー";

	/// <summary>
	/// Key: "Label.Cancel"
	/// English String: "Cancel"
	/// </summary>
	public override string LabelCancel => "キャンセル";

	/// <summary>
	/// Key: "Label.GameJoinPrivateErrorTitle"
	/// Title of error window when trying to join a private server user does not have access to.
	/// English String: "Unable to join"
	/// </summary>
	public override string LabelGameJoinPrivateErrorTitle => "参加できません";

	/// <summary>
	/// Key: "Label.GameName"
	/// English String: "Game Name"
	/// </summary>
	public override string LabelGameName => "ゲーム名";

	/// <summary>
	/// Key: "Label.NoVipServers"
	/// No VIP Server Instances Found.
	/// English String: "No VIP Server Instances Found."
	/// </summary>
	public override string LabelNoVipServers => "VIPサーバーのインスタンスが見つかりません。";

	/// <summary>
	/// Key: "Label.PlayWithOthers"
	/// English String: "Play this game with friends and other people you invite."
	/// </summary>
	public override string LabelPlayWithOthers => "友達や招待したプレイヤーと一緒に、このゲームをプレイしよう。";

	/// <summary>
	/// Key: "Label.Renew"
	/// English String: "Renew"
	/// </summary>
	public override string LabelRenew => "更新";

	/// <summary>
	/// Key: "Label.RenewPrivateServer"
	/// English String: "Renew Private Server"
	/// </summary>
	public override string LabelRenewPrivateServer => "プライベートサーバーを更新";

	/// <summary>
	/// Key: "Label.ServerName"
	/// English String: "Server Name"
	/// </summary>
	public override string LabelServerName => "サーバー名";

	/// <summary>
	/// Key: "Label.Servers"
	/// English String: "Servers"
	/// </summary>
	public override string LabelServers => "サーバー";

	/// <summary>
	/// Key: "Label.VIPServerGameJoinErrorAcknowledgement"
	/// Confirmation text for game join private error dialog.
	/// English String: "OK"
	/// </summary>
	public override string LabelVIPServerGameJoinErrorAcknowledgement => "OK";

	/// <summary>
	/// Key: "Label.VipServerJoinGamePrivateError"
	/// Error when user wants to join a VIP server when the game is marked private
	/// English String: "You cannot join this VIP server because the game is private."
	/// </summary>
	public override string LabelVipServerJoinGamePrivateError => "ゲームがプライベート設定になっているため、このVIPサーバーに参加できません。";

	/// <summary>
	/// Key: "Label.VipServersAbout"
	/// English String: "VIP servers let you play this game privately with friends, your clan, or people you invite!"
	/// </summary>
	public override string LabelVipServersAbout => "VIPサーバーは、このゲームを友達、クラン、招待したプレイヤーなどと一緒に非公開でプレイできます！";

	/// <summary>
	/// Key: "Message.InvalidLink"
	/// Dialog content when the link to a VIP server is invalid
	/// English String: "This VIP Server link is no longer valid."
	/// </summary>
	public override string MessageInvalidLink => "このVIPサーバーのリンクは無効になりました。";

	public PrivateServersResources_ja_jp(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionCreateVipServer()
	{
		return "VIPサーバーの作成";
	}

	protected override string _GetTemplateForActionRefresh()
	{
		return "リフレッシュ";
	}

	protected override string _GetTemplateForHeadingInvalidLink()
	{
		return "無効なリンク";
	}

	protected override string _GetTemplateForHeadingVipServers()
	{
		return "VIPサーバー";
	}

	protected override string _GetTemplateForLabelCancel()
	{
		return "キャンセル";
	}

	/// <summary>
	/// Key: "Label.ConfirmEnableFuturePayments"
	/// English String: "Are you sure you want to enable future payments for your private VIP version of {placeName} by {creatorName}?"
	/// </summary>
	public override string LabelConfirmEnableFuturePayments(string placeName, string creatorName)
	{
		return $"{creatorName} さんが作った {placeName} のプライベートVIPバージョンへの今後の支払いを有効にしてよろしいですか？";
	}

	protected override string _GetTemplateForLabelConfirmEnableFuturePayments()
	{
		return "{creatorName} さんが作った {placeName} のプライベートVIPバージョンへの今後の支払いを有効にしてよろしいですか？";
	}

	/// <summary>
	/// Key: "Label.CreateVipServerFor"
	/// English String: "Create a VIP Server for {target}?"
	/// </summary>
	public override string LabelCreateVipServerFor(string target)
	{
		return $"{target} のVIPサーバーを作りますか？";
	}

	protected override string _GetTemplateForLabelCreateVipServerFor()
	{
		return "{target} のVIPサーバーを作りますか？";
	}

	/// <summary>
	/// Key: "Label.FooterText"
	/// English String: "Your balance after this transaction will be {robuxIcon}. This is a subscription-based feature. It will auto-renew once a month until you cancel the subscription."
	/// </summary>
	public override string LabelFooterText(string robuxIcon)
	{
		return $"取引後の残高は{robuxIcon}になります。これはサブスクリプション方式の機能です。サブスクリプションをキャンセルするまで、毎月1度自動更新されます。";
	}

	protected override string _GetTemplateForLabelFooterText()
	{
		return "取引後の残高は{robuxIcon}になります。これはサブスクリプション方式の機能です。サブスクリプションをキャンセルするまで、毎月1度自動更新されます。";
	}

	protected override string _GetTemplateForLabelGameJoinPrivateErrorTitle()
	{
		return "参加できません";
	}

	protected override string _GetTemplateForLabelGameName()
	{
		return "ゲーム名";
	}

	protected override string _GetTemplateForLabelNoVipServers()
	{
		return "VIPサーバーのインスタンスが見つかりません。";
	}

	protected override string _GetTemplateForLabelPlayWithOthers()
	{
		return "友達や招待したプレイヤーと一緒に、このゲームをプレイしよう。";
	}

	protected override string _GetTemplateForLabelRenew()
	{
		return "更新";
	}

	protected override string _GetTemplateForLabelRenewPrivateServer()
	{
		return "プライベートサーバーを更新";
	}

	/// <summary>
	/// Key: "Label.SeeAllServers"
	/// English String: "See all your VIP servers in the {serversLink} tab."
	/// </summary>
	public override string LabelSeeAllServers(string serversLink)
	{
		return $"{serversLink} タブで、ご自分のすべてのVIPサーバーを見れます。";
	}

	protected override string _GetTemplateForLabelSeeAllServers()
	{
		return "{serversLink} タブで、ご自分のすべてのVIPサーバーを見れます。";
	}

	protected override string _GetTemplateForLabelServerName()
	{
		return "サーバー名";
	}

	protected override string _GetTemplateForLabelServers()
	{
		return "サーバー";
	}

	/// <summary>
	/// Key: "Label.StartRenewingPrice"
	/// English String: "This VIP Server will start renewing every month at {price} until you cancel."
	/// </summary>
	public override string LabelStartRenewingPrice(string price)
	{
		return $"このVIPサーバーは、キャンセルしない限り毎月{price}で更新されます。";
	}

	protected override string _GetTemplateForLabelStartRenewingPrice()
	{
		return "このVIPサーバーは、キャンセルしない限り毎月{price}で更新されます。";
	}

	protected override string _GetTemplateForLabelVIPServerGameJoinErrorAcknowledgement()
	{
		return "OK";
	}

	protected override string _GetTemplateForLabelVipServerJoinGamePrivateError()
	{
		return "ゲームがプライベート設定になっているため、このVIPサーバーに参加できません。";
	}

	protected override string _GetTemplateForLabelVipServersAbout()
	{
		return "VIPサーバーは、このゲームを友達、クラン、招待したプレイヤーなどと一緒に非公開でプレイできます！";
	}

	/// <summary>
	/// Key: "Label.VipServersNotSupported"
	/// English String: "This game does not support {vipServersLink}."
	/// </summary>
	public override string LabelVipServersNotSupported(string vipServersLink)
	{
		return $"このゲームは {vipServersLink} に対応していません。";
	}

	protected override string _GetTemplateForLabelVipServersNotSupported()
	{
		return "このゲームは {vipServersLink} に対応していません。";
	}

	protected override string _GetTemplateForMessageInvalidLink()
	{
		return "このVIPサーバーのリンクは無効になりました。";
	}
}
