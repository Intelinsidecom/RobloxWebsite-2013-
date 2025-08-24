namespace Roblox.TranslationResources.Feature;

/// <summary>
/// This class overrides VIPServerResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class VIPServerResources_ja_jp : VIPServerResources_en_us, IVIPServerResources, ITranslationResources
{
	/// <summary>
	/// Key: "Action.Add"
	/// English String: "Add"
	/// </summary>
	public override string ActionAdd => "追加";

	/// <summary>
	/// Key: "Action.AddPlayers"
	/// English String: "Add Players"
	/// </summary>
	public override string ActionAddPlayers => "プレイヤーを追加";

	/// <summary>
	/// Key: "Action.Cancel"
	/// English String: "Cancel"
	/// </summary>
	public override string ActionCancel => "キャンセル";

	/// <summary>
	/// Key: "Action.CancelPayments"
	/// English String: "Cancel Payments"
	/// </summary>
	public override string ActionCancelPayments => "支払いをキャンセル";

	/// <summary>
	/// Key: "Action.ChangeName"
	/// English String: "Change Name"
	/// </summary>
	public override string ActionChangeName => "名前を変更";

	/// <summary>
	/// Key: "Action.GoBack"
	/// English String: "Go Back"
	/// </summary>
	public override string ActionGoBack => "戻る";

	/// <summary>
	/// Key: "Action.RegenerateJoinLink"
	/// English String: "Regenerate"
	/// </summary>
	public override string ActionRegenerateJoinLink => "生成しなおす";

	/// <summary>
	/// Key: "Action.Remove"
	/// English String: "Remove"
	/// </summary>
	public override string ActionRemove => "削除";

	/// <summary>
	/// Key: "Action.RenewVipServer"
	/// English String: "Renew VIP Server"
	/// </summary>
	public override string ActionRenewVipServer => "VIPサーバーの更新";

	/// <summary>
	/// Key: "Action.SeeAll"
	/// English String: "See All"
	/// </summary>
	public override string ActionSeeAll => "すべて見る";

	/// <summary>
	/// Key: "Heading.CancelPayments"
	/// English String: "Cancel Payments"
	/// </summary>
	public override string HeadingCancelPayments => "支払いをキャンセル";

	/// <summary>
	/// Key: "Heading.ChangeName"
	/// English String: "Change VIP Server Name"
	/// </summary>
	public override string HeadingChangeName => "VIPサーバー名を変更";

	/// <summary>
	/// Key: "Heading.ConfigureVipServer"
	/// English String: "Configure VIP Server"
	/// </summary>
	public override string HeadingConfigureVipServer => "VIPサーバーの環境設定";

	/// <summary>
	/// Key: "Heading.RemovePlayer"
	/// English String: "Remove Player"
	/// </summary>
	public override string HeadingRemovePlayer => "プレイヤーを削除";

	/// <summary>
	/// Key: "Heading.RenewVipServer"
	/// English String: "Renew VIP Server"
	/// </summary>
	public override string HeadingRenewVipServer => "VIPサーバーの更新";

	/// <summary>
	/// Key: "Label.ChangeNamePlaceholder"
	/// English String: "VIP Server Name (1-50 Characters)"
	/// </summary>
	public override string LabelChangeNamePlaceholder => "VIPサーバー名（1〜50文字）";

	/// <summary>
	/// Key: "Label.ClanAccess"
	/// English String: "Clan Access"
	/// </summary>
	public override string LabelClanAccess => "クランアクセス";

	/// <summary>
	/// Key: "Label.FriendsAllowed"
	/// English String: "Friends Allowed"
	/// </summary>
	public override string LabelFriendsAllowed => "許可された友達";

	/// <summary>
	/// Key: "Label.GameName"
	/// English String: "Game Name"
	/// </summary>
	public override string LabelGameName => "ゲーム名";

	/// <summary>
	/// Key: "Label.JoinGameLink"
	/// English String: "Join Game Link..."
	/// </summary>
	public override string LabelJoinGameLink => "ゲームへの参加リンク...";

	/// <summary>
	/// Key: "Label.None"
	/// English String: "None"
	/// </summary>
	public override string LabelNone => "なし";

	/// <summary>
	/// Key: "Label.Off"
	/// English String: "Off"
	/// </summary>
	public override string LabelOff => "オフ";

	/// <summary>
	/// Key: "Label.On"
	/// English String: "On"
	/// </summary>
	public override string LabelOn => "オン";

	/// <summary>
	/// Key: "Label.PickEnemyClan"
	/// English String: "Pick Enemy Clan"
	/// </summary>
	public override string LabelPickEnemyClan => "敵のクランを選択";

	/// <summary>
	/// Key: "Label.SearchForPlayers"
	/// English String: "Search for Players"
	/// </summary>
	public override string LabelSearchForPlayers => "プレイヤーを検索";

	/// <summary>
	/// Key: "Label.Server"
	/// English String: "Server"
	/// </summary>
	public override string LabelServer => "サーバー";

	/// <summary>
	/// Key: "Label.ServerMembers"
	/// English String: "Server Members"
	/// </summary>
	public override string LabelServerMembers => "サーバーメンバー";

	/// <summary>
	/// Key: "Label.SubscriptionStatus"
	/// English String: "Subscription Status"
	/// </summary>
	public override string LabelSubscriptionStatus => "サブスクリプション状況";

	/// <summary>
	/// Key: "Label.VIPServerLink"
	/// English String: "VIP Server Link"
	/// </summary>
	public override string LabelVIPServerLink => "VIPサーバーのリンク";

	/// <summary>
	/// Key: "Label.VIPServerStatus"
	/// English String: "VIP Server Status"
	/// </summary>
	public override string LabelVIPServerStatus => "VIPサーバー状況";

	/// <summary>
	/// Key: "Label.YourClan"
	/// English String: "Your Clan"
	/// </summary>
	public override string LabelYourClan => "あなたのクラン";

	public VIPServerResources_ja_jp(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionAdd()
	{
		return "追加";
	}

	protected override string _GetTemplateForActionAddPlayers()
	{
		return "プレイヤーを追加";
	}

	protected override string _GetTemplateForActionCancel()
	{
		return "キャンセル";
	}

	protected override string _GetTemplateForActionCancelPayments()
	{
		return "支払いをキャンセル";
	}

	protected override string _GetTemplateForActionChangeName()
	{
		return "名前を変更";
	}

	protected override string _GetTemplateForActionGoBack()
	{
		return "戻る";
	}

	protected override string _GetTemplateForActionRegenerateJoinLink()
	{
		return "生成しなおす";
	}

	protected override string _GetTemplateForActionRemove()
	{
		return "削除";
	}

	protected override string _GetTemplateForActionRenewVipServer()
	{
		return "VIPサーバーの更新";
	}

	protected override string _GetTemplateForActionSeeAll()
	{
		return "すべて見る";
	}

	protected override string _GetTemplateForHeadingCancelPayments()
	{
		return "支払いをキャンセル";
	}

	protected override string _GetTemplateForHeadingChangeName()
	{
		return "VIPサーバー名を変更";
	}

	protected override string _GetTemplateForHeadingConfigureVipServer()
	{
		return "VIPサーバーの環境設定";
	}

	protected override string _GetTemplateForHeadingRemovePlayer()
	{
		return "プレイヤーを削除";
	}

	protected override string _GetTemplateForHeadingRenewVipServer()
	{
		return "VIPサーバーの更新";
	}

	/// <summary>
	/// Key: "Label.ChangeNameBodyMessage"
	/// English String: "Are you sure you want to cancel future payments for your VIP Server of {name} by {creator}? If you cancel, your VIP Server will be deactivated on {date}."
	/// </summary>
	public override string LabelChangeNameBodyMessage(string name, string creator, string date)
	{
		return $"{creator} さんが作成した {name} のVIPサーバーへの今後の支払いをキャンセルしてよろしいですか？キャンセルすると、{date} 以降、VIPサーバーは無効になります。";
	}

	protected override string _GetTemplateForLabelChangeNameBodyMessage()
	{
		return "{creator} さんが作成した {name} のVIPサーバーへの今後の支払いをキャンセルしてよろしいですか？キャンセルすると、{date} 以降、VIPサーバーは無効になります。";
	}

	protected override string _GetTemplateForLabelChangeNamePlaceholder()
	{
		return "VIPサーバー名（1〜50文字）";
	}

	protected override string _GetTemplateForLabelClanAccess()
	{
		return "クランアクセス";
	}

	protected override string _GetTemplateForLabelFriendsAllowed()
	{
		return "許可された友達";
	}

	protected override string _GetTemplateForLabelGameName()
	{
		return "ゲーム名";
	}

	protected override string _GetTemplateForLabelJoinGameLink()
	{
		return "ゲームへの参加リンク...";
	}

	protected override string _GetTemplateForLabelNone()
	{
		return "なし";
	}

	protected override string _GetTemplateForLabelOff()
	{
		return "オフ";
	}

	protected override string _GetTemplateForLabelOn()
	{
		return "オン";
	}

	protected override string _GetTemplateForLabelPickEnemyClan()
	{
		return "敵のクランを選択";
	}

	/// <summary>
	/// Key: "Label.RemovePlayerBodyMessage"
	/// English String: "Are you sure you want to remove {name} from your VIP Server? They will no longer be able to join your VIP Server."
	/// </summary>
	public override string LabelRemovePlayerBodyMessage(string name)
	{
		return $"VIPサーバーから{name}さんを削除してよろしいですか？削除すると、あなたのVIPサーバーには参加できなくなります。";
	}

	protected override string _GetTemplateForLabelRemovePlayerBodyMessage()
	{
		return "VIPサーバーから{name}さんを削除してよろしいですか？削除すると、あなたのVIPサーバーには参加できなくなります。";
	}

	/// <summary>
	/// Key: "Label.RenewVipServerBodyMessageConfirmation"
	/// English String: "Are you sure you want to enable future payments for your VIP Server of {name} by {creator}?"
	/// </summary>
	public override string LabelRenewVipServerBodyMessageConfirmation(string name, string creator)
	{
		return $"{creator}さんが作成した{name}のVIPサーバーへの今後の支払いを有効にしてよろしいですか？";
	}

	protected override string _GetTemplateForLabelRenewVipServerBodyMessageConfirmation()
	{
		return "{creator}さんが作成した{name}のVIPサーバーへの今後の支払いを有効にしてよろしいですか？";
	}

	/// <summary>
	/// Key: "Label.RenewVipServerBodyMessageStart"
	/// English String: "This VIP Server will start renewing every month at {date} until you cancel."
	/// </summary>
	public override string LabelRenewVipServerBodyMessageStart(string date)
	{
		return $"このVIPサーバーは、キャンセルしない限り毎月{date}に更新されます。";
	}

	protected override string _GetTemplateForLabelRenewVipServerBodyMessageStart()
	{
		return "このVIPサーバーは、キャンセルしない限り毎月{date}に更新されます。";
	}

	protected override string _GetTemplateForLabelSearchForPlayers()
	{
		return "プレイヤーを検索";
	}

	protected override string _GetTemplateForLabelServer()
	{
		return "サーバー";
	}

	/// <summary>
	/// Key: "Label.ServerExpirationDate"
	/// English String: "Your VIP Server expired on{date}"
	/// </summary>
	public override string LabelServerExpirationDate(string date)
	{
		return $"VIPサーバーは{date}に期限が切れます";
	}

	protected override string _GetTemplateForLabelServerExpirationDate()
	{
		return "VIPサーバーは{date}に期限が切れます";
	}

	protected override string _GetTemplateForLabelServerMembers()
	{
		return "サーバーメンバー";
	}

	/// <summary>
	/// Key: "Label.SubscriptionChargeDate"
	/// English String: "You will be charged again on {date}"
	/// </summary>
	public override string LabelSubscriptionChargeDate(string date)
	{
		return $"{date}に課金されます";
	}

	protected override string _GetTemplateForLabelSubscriptionChargeDate()
	{
		return "{date}に課金されます";
	}

	/// <summary>
	/// Key: "Label.SubscriptionMonthlyPaymentDue"
	/// English String: "Your VIP Server monthly payment is {value}"
	/// </summary>
	public override string LabelSubscriptionMonthlyPaymentDue(string value)
	{
		return $"VIPサーバーの支払いは月額 {value} です";
	}

	protected override string _GetTemplateForLabelSubscriptionMonthlyPaymentDue()
	{
		return "VIPサーバーの支払いは月額 {value} です";
	}

	protected override string _GetTemplateForLabelSubscriptionStatus()
	{
		return "サブスクリプション状況";
	}

	protected override string _GetTemplateForLabelVIPServerLink()
	{
		return "VIPサーバーのリンク";
	}

	protected override string _GetTemplateForLabelVIPServerStatus()
	{
		return "VIPサーバー状況";
	}

	protected override string _GetTemplateForLabelYourClan()
	{
		return "あなたのクラン";
	}
}
