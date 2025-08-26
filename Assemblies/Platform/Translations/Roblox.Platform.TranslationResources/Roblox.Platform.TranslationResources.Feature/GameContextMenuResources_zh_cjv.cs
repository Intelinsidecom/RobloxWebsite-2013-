namespace Roblox.Platform.TranslationResources.Feature {
    /// <summary>

/// This class overrides GameContextMenuResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class GameContextMenuResources_zh_cjv : GameContextMenuResources_en_us, IGameContextMenuResources, ITranslationResources
{
	/// <summary>
	/// Key: "ActionDialogAccept"
	/// English String: "Yes"
	/// </summary>
	public override string ActionDialogAccept => "æ˜¯";

	/// <summary>
	/// Key: "ActionDialogDecline"
	/// English String: "No"
	/// </summary>
	public override string ActionDialogDecline => "å¦";

	/// <summary>
	/// Key: "ActionDialogOk"
	/// English String: "OK"
	/// </summary>
	public override string ActionDialogOk => "å¥½";

	/// <summary>
	/// Key: "Label.ConfigureLocalization"
	/// The label in context menu that will direct game owner to configure localization page
	/// English String: "Configure Localization"
	/// </summary>
	public override string LabelConfigureLocalization => "é…ç½®æœ¬åœ°åŒ–";

	/// <summary>
	/// Key: "Label.TranslateThisGame"
	/// The label in context menu that will direct translators for a game to crowdsource translation page
	/// English String: "Translate this Game"
	/// </summary>
	public override string LabelTranslateThisGame => "ç¿»è¯‘æ­¤æ¸¸æˆ";

	/// <summary>
	/// Key: "LabelAddToProfile"
	/// English String: "Add to profile"
	/// </summary>
	public override string LabelAddToProfile => "æ·»åŠ è‡³ä¸ªäººèµ„æ–™";

	/// <summary>
	/// Key: "LabelConfigureGame"
	/// English String: "Configure this Game"
	/// </summary>
	public override string LabelConfigureGame => "é…ç½®æ­¤æ¸¸æˆ";

	/// <summary>
	/// Key: "LabelConfigurePlace"
	/// English String: "Configure this Place"
	/// </summary>
	public override string LabelConfigurePlace => "é…ç½®æ­¤åœºæ™¯";

	/// <summary>
	/// Key: "LabelDeveloperStats"
	/// English String: "Developer Stats"
	/// </summary>
	public override string LabelDeveloperStats => "å¼€å‘è€…ç»Ÿè®¡èµ„æ–™";

	/// <summary>
	/// Key: "LabelEdit"
	/// English String: "Edit"
	/// </summary>
	public override string LabelEdit => "ç¼–è¾‘";

	/// <summary>
	/// Key: "LabelRemoveFromProfile"
	/// English String: "Remove from Profile"
	/// </summary>
	public override string LabelRemoveFromProfile => "ä»Žä¸ªäººèµ„æ–™ç§»é™¤";

	/// <summary>
	/// Key: "LabelServerError"
	/// English String: "An Error Occured"
	/// </summary>
	public override string LabelServerError => "å‘ç”Ÿé”™è¯¯";

	/// <summary>
	/// Key: "LabelShutDownAllServers"
	/// English String: "Shut Down All Servers"
	/// </summary>
	public override string LabelShutDownAllServers => "å…³é—­æ‰€æœ‰æœåŠ¡å™¨";

	/// <summary>
	/// Key: "LabelShutDownServersWarning"
	/// English String: "Are you sure you want to shut down all servers for this place?"
	/// </summary>
	public override string LabelShutDownServersWarning => "æ˜¯å¦ç¡®å®šè¦å…³é—­æ­¤åœºæ™¯çš„æ‰€æœ‰æœåŠ¡å™¨ï¼Ÿ";

	/// <summary>
	/// Key: "MessageServerShutDownError"
	/// English String: "Could not shut down servers."
	/// </summary>
	public override string MessageServerShutDownError => "æ— æ³•å…³é—­æœåŠ¡å™¨ã€‚";

	public GameContextMenuResources_zh_cjv(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionDialogAccept()
	{
		return "æ˜¯";
	}

	protected override string _GetTemplateForActionDialogDecline()
	{
		return "å¦";
	}

	protected override string _GetTemplateForActionDialogOk()
	{
		return "å¥½";
	}

	protected override string _GetTemplateForLabelConfigureLocalization()
	{
		return "é…ç½®æœ¬åœ°åŒ–";
	}

	protected override string _GetTemplateForLabelTranslateThisGame()
	{
		return "ç¿»è¯‘æ­¤æ¸¸æˆ";
	}

	protected override string _GetTemplateForLabelAddToProfile()
	{
		return "æ·»åŠ è‡³ä¸ªäººèµ„æ–™";
	}

	protected override string _GetTemplateForLabelConfigureGame()
	{
		return "é…ç½®æ­¤æ¸¸æˆ";
	}

	protected override string _GetTemplateForLabelConfigurePlace()
	{
		return "é…ç½®æ­¤åœºæ™¯";
	}

	protected override string _GetTemplateForLabelDeveloperStats()
	{
		return "å¼€å‘è€…ç»Ÿè®¡èµ„æ–™";
	}

	protected override string _GetTemplateForLabelEdit()
	{
		return "ç¼–è¾‘";
	}

	protected override string _GetTemplateForLabelRemoveFromProfile()
	{
		return "ä»Žä¸ªäººèµ„æ–™ç§»é™¤";
	}

	protected override string _GetTemplateForLabelServerError()
	{
		return "å‘ç”Ÿé”™è¯¯";
	}

	protected override string _GetTemplateForLabelShutDownAllServers()
	{
		return "å…³é—­æ‰€æœ‰æœåŠ¡å™¨";
	}

	protected override string _GetTemplateForLabelShutDownServersWarning()
	{
		return "æ˜¯å¦ç¡®å®šè¦å…³é—­æ­¤åœºæ™¯çš„æ‰€æœ‰æœåŠ¡å™¨ï¼Ÿ";
	}

	protected override string _GetTemplateForMessageServerShutDownError()
	{
		return "æ— æ³•å…³é—­æœåŠ¡å™¨ã€‚";
	}
}


}
