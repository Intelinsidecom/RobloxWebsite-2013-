namespace Roblox.TranslationResources.Feature;

/// <summary>
/// This class overrides GameContextMenuResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class GameContextMenuResources_ko_kr : GameContextMenuResources_en_us, IGameContextMenuResources, ITranslationResources
{
	/// <summary>
	/// Key: "ActionDialogAccept"
	/// English String: "Yes"
	/// </summary>
	public override string ActionDialogAccept => "예";

	/// <summary>
	/// Key: "ActionDialogDecline"
	/// English String: "No"
	/// </summary>
	public override string ActionDialogDecline => "아니요";

	/// <summary>
	/// Key: "ActionDialogOk"
	/// English String: "OK"
	/// </summary>
	public override string ActionDialogOk => "확인";

	/// <summary>
	/// Key: "Label.ConfigureLocalization"
	/// The label in context menu that will direct game owner to configure localization page
	/// English String: "Configure Localization"
	/// </summary>
	public override string LabelConfigureLocalization => "로컬리제이션 구성";

	/// <summary>
	/// Key: "Label.TranslateThisGame"
	/// The label in context menu that will direct translators for a game to crowdsource translation page
	/// English String: "Translate this Game"
	/// </summary>
	public override string LabelTranslateThisGame => "본 게임 번역하기";

	/// <summary>
	/// Key: "LabelAddToProfile"
	/// English String: "Add to profile"
	/// </summary>
	public override string LabelAddToProfile => "프로필에 추가";

	/// <summary>
	/// Key: "LabelConfigureGame"
	/// English String: "Configure this Game"
	/// </summary>
	public override string LabelConfigureGame => "본 게임을 구성";

	/// <summary>
	/// Key: "LabelConfigurePlace"
	/// English String: "Configure this Place"
	/// </summary>
	public override string LabelConfigurePlace => "본 장소를 구성";

	/// <summary>
	/// Key: "LabelDeveloperStats"
	/// English String: "Developer Stats"
	/// </summary>
	public override string LabelDeveloperStats => "개발자 통계";

	/// <summary>
	/// Key: "LabelEdit"
	/// English String: "Edit"
	/// </summary>
	public override string LabelEdit => "편집";

	/// <summary>
	/// Key: "LabelRemoveFromProfile"
	/// English String: "Remove from Profile"
	/// </summary>
	public override string LabelRemoveFromProfile => "프로필에서 삭제";

	/// <summary>
	/// Key: "LabelServerError"
	/// English String: "An Error Occured"
	/// </summary>
	public override string LabelServerError => "오류가 발생했어요";

	/// <summary>
	/// Key: "LabelShutDownAllServers"
	/// English String: "Shut Down All Servers"
	/// </summary>
	public override string LabelShutDownAllServers => "모든 서버 종료";

	/// <summary>
	/// Key: "LabelShutDownServersWarning"
	/// English String: "Are you sure you want to shut down all servers for this place?"
	/// </summary>
	public override string LabelShutDownServersWarning => "본 장소에 대한 모든 서버를 정말 종료할까요?";

	/// <summary>
	/// Key: "MessageServerShutDownError"
	/// English String: "Could not shut down servers."
	/// </summary>
	public override string MessageServerShutDownError => "서버를 종료할 수 없습니다.";

	public GameContextMenuResources_ko_kr(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionDialogAccept()
	{
		return "예";
	}

	protected override string _GetTemplateForActionDialogDecline()
	{
		return "아니요";
	}

	protected override string _GetTemplateForActionDialogOk()
	{
		return "확인";
	}

	protected override string _GetTemplateForLabelConfigureLocalization()
	{
		return "로컬리제이션 구성";
	}

	protected override string _GetTemplateForLabelTranslateThisGame()
	{
		return "본 게임 번역하기";
	}

	protected override string _GetTemplateForLabelAddToProfile()
	{
		return "프로필에 추가";
	}

	protected override string _GetTemplateForLabelConfigureGame()
	{
		return "본 게임을 구성";
	}

	protected override string _GetTemplateForLabelConfigurePlace()
	{
		return "본 장소를 구성";
	}

	protected override string _GetTemplateForLabelDeveloperStats()
	{
		return "개발자 통계";
	}

	protected override string _GetTemplateForLabelEdit()
	{
		return "편집";
	}

	protected override string _GetTemplateForLabelRemoveFromProfile()
	{
		return "프로필에서 삭제";
	}

	protected override string _GetTemplateForLabelServerError()
	{
		return "오류가 발생했어요";
	}

	protected override string _GetTemplateForLabelShutDownAllServers()
	{
		return "모든 서버 종료";
	}

	protected override string _GetTemplateForLabelShutDownServersWarning()
	{
		return "본 장소에 대한 모든 서버를 정말 종료할까요?";
	}

	protected override string _GetTemplateForMessageServerShutDownError()
	{
		return "서버를 종료할 수 없습니다.";
	}
}
