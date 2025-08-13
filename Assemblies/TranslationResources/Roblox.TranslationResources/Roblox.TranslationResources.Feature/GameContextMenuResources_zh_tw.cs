namespace Roblox.TranslationResources.Feature;

/// <summary>
/// This class overrides GameContextMenuResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class GameContextMenuResources_zh_tw : GameContextMenuResources_en_us, IGameContextMenuResources, ITranslationResources
{
	/// <summary>
	/// Key: "ActionDialogAccept"
	/// English String: "Yes"
	/// </summary>
	public override string ActionDialogAccept => "是";

	/// <summary>
	/// Key: "ActionDialogDecline"
	/// English String: "No"
	/// </summary>
	public override string ActionDialogDecline => "否";

	/// <summary>
	/// Key: "ActionDialogOk"
	/// English String: "OK"
	/// </summary>
	public override string ActionDialogOk => "確定";

	/// <summary>
	/// Key: "Label.ConfigureLocalization"
	/// The label in context menu that will direct game owner to configure localization page
	/// English String: "Configure Localization"
	/// </summary>
	public override string LabelConfigureLocalization => "本地化設定";

	/// <summary>
	/// Key: "Label.TranslateThisGame"
	/// The label in context menu that will direct translators for a game to crowdsource translation page
	/// English String: "Translate this Game"
	/// </summary>
	public override string LabelTranslateThisGame => "翻譯此遊戲";

	/// <summary>
	/// Key: "LabelAddToProfile"
	/// English String: "Add to profile"
	/// </summary>
	public override string LabelAddToProfile => "加到個人檔案";

	/// <summary>
	/// Key: "LabelConfigureGame"
	/// English String: "Configure this Game"
	/// </summary>
	public override string LabelConfigureGame => "遊戲設定";

	/// <summary>
	/// Key: "LabelConfigurePlace"
	/// English String: "Configure this Place"
	/// </summary>
	public override string LabelConfigurePlace => "空間設定";

	/// <summary>
	/// Key: "LabelDeveloperStats"
	/// English String: "Developer Stats"
	/// </summary>
	public override string LabelDeveloperStats => "開發人員數據";

	/// <summary>
	/// Key: "LabelEdit"
	/// English String: "Edit"
	/// </summary>
	public override string LabelEdit => "編輯";

	/// <summary>
	/// Key: "LabelRemoveFromProfile"
	/// English String: "Remove from Profile"
	/// </summary>
	public override string LabelRemoveFromProfile => "從個人檔案移除";

	/// <summary>
	/// Key: "LabelServerError"
	/// English String: "An Error Occured"
	/// </summary>
	public override string LabelServerError => "發生錯誤";

	/// <summary>
	/// Key: "LabelShutDownAllServers"
	/// English String: "Shut Down All Servers"
	/// </summary>
	public override string LabelShutDownAllServers => "關閉所有伺服器";

	/// <summary>
	/// Key: "LabelShutDownServersWarning"
	/// English String: "Are you sure you want to shut down all servers for this place?"
	/// </summary>
	public override string LabelShutDownServersWarning => "確定關閉此空間所有伺服器？";

	/// <summary>
	/// Key: "MessageServerShutDownError"
	/// English String: "Could not shut down servers."
	/// </summary>
	public override string MessageServerShutDownError => "無法關閉伺服器。";

	public GameContextMenuResources_zh_tw(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionDialogAccept()
	{
		return "是";
	}

	protected override string _GetTemplateForActionDialogDecline()
	{
		return "否";
	}

	protected override string _GetTemplateForActionDialogOk()
	{
		return "確定";
	}

	protected override string _GetTemplateForLabelConfigureLocalization()
	{
		return "本地化設定";
	}

	protected override string _GetTemplateForLabelTranslateThisGame()
	{
		return "翻譯此遊戲";
	}

	protected override string _GetTemplateForLabelAddToProfile()
	{
		return "加到個人檔案";
	}

	protected override string _GetTemplateForLabelConfigureGame()
	{
		return "遊戲設定";
	}

	protected override string _GetTemplateForLabelConfigurePlace()
	{
		return "空間設定";
	}

	protected override string _GetTemplateForLabelDeveloperStats()
	{
		return "開發人員數據";
	}

	protected override string _GetTemplateForLabelEdit()
	{
		return "編輯";
	}

	protected override string _GetTemplateForLabelRemoveFromProfile()
	{
		return "從個人檔案移除";
	}

	protected override string _GetTemplateForLabelServerError()
	{
		return "發生錯誤";
	}

	protected override string _GetTemplateForLabelShutDownAllServers()
	{
		return "關閉所有伺服器";
	}

	protected override string _GetTemplateForLabelShutDownServersWarning()
	{
		return "確定關閉此空間所有伺服器？";
	}

	protected override string _GetTemplateForMessageServerShutDownError()
	{
		return "無法關閉伺服器。";
	}
}
