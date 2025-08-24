namespace Roblox.TranslationResources.Feature;

/// <summary>
/// This class overrides GameContextMenuResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class GameContextMenuResources_zh_cn : GameContextMenuResources_en_us, IGameContextMenuResources, ITranslationResources
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
	public override string ActionDialogOk => "好";

	/// <summary>
	/// Key: "Label.ConfigureLocalization"
	/// The label in context menu that will direct game owner to configure localization page
	/// English String: "Configure Localization"
	/// </summary>
	public override string LabelConfigureLocalization => "配置本地化";

	/// <summary>
	/// Key: "Label.TranslateThisGame"
	/// The label in context menu that will direct translators for a game to crowdsource translation page
	/// English String: "Translate this Game"
	/// </summary>
	public override string LabelTranslateThisGame => "翻译此游戏";

	/// <summary>
	/// Key: "LabelAddToProfile"
	/// English String: "Add to profile"
	/// </summary>
	public override string LabelAddToProfile => "添加至个人资料";

	/// <summary>
	/// Key: "LabelConfigureGame"
	/// English String: "Configure this Game"
	/// </summary>
	public override string LabelConfigureGame => "配置此游戏";

	/// <summary>
	/// Key: "LabelConfigurePlace"
	/// English String: "Configure this Place"
	/// </summary>
	public override string LabelConfigurePlace => "配置此场景";

	/// <summary>
	/// Key: "LabelDeveloperStats"
	/// English String: "Developer Stats"
	/// </summary>
	public override string LabelDeveloperStats => "开发者统计资料";

	/// <summary>
	/// Key: "LabelEdit"
	/// English String: "Edit"
	/// </summary>
	public override string LabelEdit => "编辑";

	/// <summary>
	/// Key: "LabelRemoveFromProfile"
	/// English String: "Remove from Profile"
	/// </summary>
	public override string LabelRemoveFromProfile => "从个人资料移除";

	/// <summary>
	/// Key: "LabelServerError"
	/// English String: "An Error Occured"
	/// </summary>
	public override string LabelServerError => "发生错误";

	/// <summary>
	/// Key: "LabelShutDownAllServers"
	/// English String: "Shut Down All Servers"
	/// </summary>
	public override string LabelShutDownAllServers => "关闭所有服务器";

	/// <summary>
	/// Key: "LabelShutDownServersWarning"
	/// English String: "Are you sure you want to shut down all servers for this place?"
	/// </summary>
	public override string LabelShutDownServersWarning => "是否确定要关闭此场景的所有服务器？";

	/// <summary>
	/// Key: "MessageServerShutDownError"
	/// English String: "Could not shut down servers."
	/// </summary>
	public override string MessageServerShutDownError => "无法关闭服务器。";

	public GameContextMenuResources_zh_cn(TranslationResourceState state)
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
		return "好";
	}

	protected override string _GetTemplateForLabelConfigureLocalization()
	{
		return "配置本地化";
	}

	protected override string _GetTemplateForLabelTranslateThisGame()
	{
		return "翻译此游戏";
	}

	protected override string _GetTemplateForLabelAddToProfile()
	{
		return "添加至个人资料";
	}

	protected override string _GetTemplateForLabelConfigureGame()
	{
		return "配置此游戏";
	}

	protected override string _GetTemplateForLabelConfigurePlace()
	{
		return "配置此场景";
	}

	protected override string _GetTemplateForLabelDeveloperStats()
	{
		return "开发者统计资料";
	}

	protected override string _GetTemplateForLabelEdit()
	{
		return "编辑";
	}

	protected override string _GetTemplateForLabelRemoveFromProfile()
	{
		return "从个人资料移除";
	}

	protected override string _GetTemplateForLabelServerError()
	{
		return "发生错误";
	}

	protected override string _GetTemplateForLabelShutDownAllServers()
	{
		return "关闭所有服务器";
	}

	protected override string _GetTemplateForLabelShutDownServersWarning()
	{
		return "是否确定要关闭此场景的所有服务器？";
	}

	protected override string _GetTemplateForMessageServerShutDownError()
	{
		return "无法关闭服务器。";
	}
}
