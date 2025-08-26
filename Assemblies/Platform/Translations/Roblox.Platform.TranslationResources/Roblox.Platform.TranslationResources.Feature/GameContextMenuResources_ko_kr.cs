namespace Roblox.Platform.TranslationResources.Feature {
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
	public override string ActionDialogAccept => "ì˜ˆ";

	/// <summary>
	/// Key: "ActionDialogDecline"
	/// English String: "No"
	/// </summary>
	public override string ActionDialogDecline => "ì•„ë‹ˆìš”";

	/// <summary>
	/// Key: "ActionDialogOk"
	/// English String: "OK"
	/// </summary>
	public override string ActionDialogOk => "í™•ì¸";

	/// <summary>
	/// Key: "Label.ConfigureLocalization"
	/// The label in context menu that will direct game owner to configure localization page
	/// English String: "Configure Localization"
	/// </summary>
	public override string LabelConfigureLocalization => "ë¡œì»¬ë¦¬ì œì´ì…˜ êµ¬ì„±";

	/// <summary>
	/// Key: "Label.TranslateThisGame"
	/// The label in context menu that will direct translators for a game to crowdsource translation page
	/// English String: "Translate this Game"
	/// </summary>
	public override string LabelTranslateThisGame => "ë³¸ ê²Œìž„ ë²ˆì—­í•˜ê¸°";

	/// <summary>
	/// Key: "LabelAddToProfile"
	/// English String: "Add to profile"
	/// </summary>
	public override string LabelAddToProfile => "í”„ë¡œí•„ì— ì¶”ê°€";

	/// <summary>
	/// Key: "LabelConfigureGame"
	/// English String: "Configure this Game"
	/// </summary>
	public override string LabelConfigureGame => "ë³¸ ê²Œìž„ì„ êµ¬ì„±";

	/// <summary>
	/// Key: "LabelConfigurePlace"
	/// English String: "Configure this Place"
	/// </summary>
	public override string LabelConfigurePlace => "ë³¸ ìž¥ì†Œë¥¼ êµ¬ì„±";

	/// <summary>
	/// Key: "LabelDeveloperStats"
	/// English String: "Developer Stats"
	/// </summary>
	public override string LabelDeveloperStats => "ê°œë°œìž í†µê³„";

	/// <summary>
	/// Key: "LabelEdit"
	/// English String: "Edit"
	/// </summary>
	public override string LabelEdit => "íŽ¸ì§‘";

	/// <summary>
	/// Key: "LabelRemoveFromProfile"
	/// English String: "Remove from Profile"
	/// </summary>
	public override string LabelRemoveFromProfile => "í”„ë¡œí•„ì—ì„œ ì‚­ì œ";

	/// <summary>
	/// Key: "LabelServerError"
	/// English String: "An Error Occured"
	/// </summary>
	public override string LabelServerError => "ì˜¤ë¥˜ê°€ ë°œìƒí–ˆì–´ìš”";

	/// <summary>
	/// Key: "LabelShutDownAllServers"
	/// English String: "Shut Down All Servers"
	/// </summary>
	public override string LabelShutDownAllServers => "ëª¨ë“  ì„œë²„ ì¢…ë£Œ";

	/// <summary>
	/// Key: "LabelShutDownServersWarning"
	/// English String: "Are you sure you want to shut down all servers for this place?"
	/// </summary>
	public override string LabelShutDownServersWarning => "ë³¸ ìž¥ì†Œì— ëŒ€í•œ ëª¨ë“  ì„œë²„ë¥¼ ì •ë§ ì¢…ë£Œí• ê¹Œìš”?";

	/// <summary>
	/// Key: "MessageServerShutDownError"
	/// English String: "Could not shut down servers."
	/// </summary>
	public override string MessageServerShutDownError => "ì„œë²„ë¥¼ ì¢…ë£Œí•  ìˆ˜ ì—†ìŠµë‹ˆë‹¤.";

	public GameContextMenuResources_ko_kr(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionDialogAccept()
	{
		return "ì˜ˆ";
	}

	protected override string _GetTemplateForActionDialogDecline()
	{
		return "ì•„ë‹ˆìš”";
	}

	protected override string _GetTemplateForActionDialogOk()
	{
		return "í™•ì¸";
	}

	protected override string _GetTemplateForLabelConfigureLocalization()
	{
		return "ë¡œì»¬ë¦¬ì œì´ì…˜ êµ¬ì„±";
	}

	protected override string _GetTemplateForLabelTranslateThisGame()
	{
		return "ë³¸ ê²Œìž„ ë²ˆì—­í•˜ê¸°";
	}

	protected override string _GetTemplateForLabelAddToProfile()
	{
		return "í”„ë¡œí•„ì— ì¶”ê°€";
	}

	protected override string _GetTemplateForLabelConfigureGame()
	{
		return "ë³¸ ê²Œìž„ì„ êµ¬ì„±";
	}

	protected override string _GetTemplateForLabelConfigurePlace()
	{
		return "ë³¸ ìž¥ì†Œë¥¼ êµ¬ì„±";
	}

	protected override string _GetTemplateForLabelDeveloperStats()
	{
		return "ê°œë°œìž í†µê³„";
	}

	protected override string _GetTemplateForLabelEdit()
	{
		return "íŽ¸ì§‘";
	}

	protected override string _GetTemplateForLabelRemoveFromProfile()
	{
		return "í”„ë¡œí•„ì—ì„œ ì‚­ì œ";
	}

	protected override string _GetTemplateForLabelServerError()
	{
		return "ì˜¤ë¥˜ê°€ ë°œìƒí–ˆì–´ìš”";
	}

	protected override string _GetTemplateForLabelShutDownAllServers()
	{
		return "ëª¨ë“  ì„œë²„ ì¢…ë£Œ";
	}

	protected override string _GetTemplateForLabelShutDownServersWarning()
	{
		return "ë³¸ ìž¥ì†Œì— ëŒ€í•œ ëª¨ë“  ì„œë²„ë¥¼ ì •ë§ ì¢…ë£Œí• ê¹Œìš”?";
	}

	protected override string _GetTemplateForMessageServerShutDownError()
	{
		return "ì„œë²„ë¥¼ ì¢…ë£Œí•  ìˆ˜ ì—†ìŠµë‹ˆë‹¤.";
	}
}


}
