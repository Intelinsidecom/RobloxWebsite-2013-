namespace Roblox.TranslationResources.Feature;

/// <summary>
/// This class overrides GameContextMenuResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class GameContextMenuResources_ja_jp : GameContextMenuResources_en_us, IGameContextMenuResources, ITranslationResources
{
	/// <summary>
	/// Key: "ActionDialogAccept"
	/// English String: "Yes"
	/// </summary>
	public override string ActionDialogAccept => "はい";

	/// <summary>
	/// Key: "ActionDialogDecline"
	/// English String: "No"
	/// </summary>
	public override string ActionDialogDecline => "いいえ";

	/// <summary>
	/// Key: "ActionDialogOk"
	/// English String: "OK"
	/// </summary>
	public override string ActionDialogOk => "OK";

	/// <summary>
	/// Key: "Label.ConfigureLocalization"
	/// The label in context menu that will direct game owner to configure localization page
	/// English String: "Configure Localization"
	/// </summary>
	public override string LabelConfigureLocalization => "翻訳の環境設定";

	/// <summary>
	/// Key: "Label.TranslateThisGame"
	/// The label in context menu that will direct translators for a game to crowdsource translation page
	/// English String: "Translate this Game"
	/// </summary>
	public override string LabelTranslateThisGame => "このゲームを翻訳する";

	/// <summary>
	/// Key: "LabelAddToProfile"
	/// English String: "Add to profile"
	/// </summary>
	public override string LabelAddToProfile => "プロフィールに追加";

	/// <summary>
	/// Key: "LabelConfigureGame"
	/// English String: "Configure this Game"
	/// </summary>
	public override string LabelConfigureGame => "このゲームを環境設定する";

	/// <summary>
	/// Key: "LabelConfigurePlace"
	/// English String: "Configure this Place"
	/// </summary>
	public override string LabelConfigurePlace => "このプレースを環境設定する";

	/// <summary>
	/// Key: "LabelDeveloperStats"
	/// English String: "Developer Stats"
	/// </summary>
	public override string LabelDeveloperStats => "開発者データ";

	/// <summary>
	/// Key: "LabelEdit"
	/// English String: "Edit"
	/// </summary>
	public override string LabelEdit => "編集";

	/// <summary>
	/// Key: "LabelRemoveFromProfile"
	/// English String: "Remove from Profile"
	/// </summary>
	public override string LabelRemoveFromProfile => "プロフィールから削除";

	/// <summary>
	/// Key: "LabelServerError"
	/// English String: "An Error Occured"
	/// </summary>
	public override string LabelServerError => "エラーが発生";

	/// <summary>
	/// Key: "LabelShutDownAllServers"
	/// English String: "Shut Down All Servers"
	/// </summary>
	public override string LabelShutDownAllServers => "すべてのサーバーをシャットダウン";

	/// <summary>
	/// Key: "LabelShutDownServersWarning"
	/// English String: "Are you sure you want to shut down all servers for this place?"
	/// </summary>
	public override string LabelShutDownServersWarning => "このプレースのすべてのサーバーをシャットダウンしてよろしいですか？";

	/// <summary>
	/// Key: "MessageServerShutDownError"
	/// English String: "Could not shut down servers."
	/// </summary>
	public override string MessageServerShutDownError => "サーバーをシャットダウンできませんでした。";

	public GameContextMenuResources_ja_jp(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionDialogAccept()
	{
		return "はい";
	}

	protected override string _GetTemplateForActionDialogDecline()
	{
		return "いいえ";
	}

	protected override string _GetTemplateForActionDialogOk()
	{
		return "OK";
	}

	protected override string _GetTemplateForLabelConfigureLocalization()
	{
		return "翻訳の環境設定";
	}

	protected override string _GetTemplateForLabelTranslateThisGame()
	{
		return "このゲームを翻訳する";
	}

	protected override string _GetTemplateForLabelAddToProfile()
	{
		return "プロフィールに追加";
	}

	protected override string _GetTemplateForLabelConfigureGame()
	{
		return "このゲームを環境設定する";
	}

	protected override string _GetTemplateForLabelConfigurePlace()
	{
		return "このプレースを環境設定する";
	}

	protected override string _GetTemplateForLabelDeveloperStats()
	{
		return "開発者データ";
	}

	protected override string _GetTemplateForLabelEdit()
	{
		return "編集";
	}

	protected override string _GetTemplateForLabelRemoveFromProfile()
	{
		return "プロフィールから削除";
	}

	protected override string _GetTemplateForLabelServerError()
	{
		return "エラーが発生";
	}

	protected override string _GetTemplateForLabelShutDownAllServers()
	{
		return "すべてのサーバーをシャットダウン";
	}

	protected override string _GetTemplateForLabelShutDownServersWarning()
	{
		return "このプレースのすべてのサーバーをシャットダウンしてよろしいですか？";
	}

	protected override string _GetTemplateForMessageServerShutDownError()
	{
		return "サーバーをシャットダウンできませんでした。";
	}
}
