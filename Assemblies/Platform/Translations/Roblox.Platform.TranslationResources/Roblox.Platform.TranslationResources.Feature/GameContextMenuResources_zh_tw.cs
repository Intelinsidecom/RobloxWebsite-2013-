namespace Roblox.Platform.TranslationResources.Feature {
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
	public override string ActionDialogOk => "ç¢ºå®š";

	/// <summary>
	/// Key: "Label.ConfigureLocalization"
	/// The label in context menu that will direct game owner to configure localization page
	/// English String: "Configure Localization"
	/// </summary>
	public override string LabelConfigureLocalization => "æœ¬åœ°åŒ–è¨­å®š";

	/// <summary>
	/// Key: "Label.TranslateThisGame"
	/// The label in context menu that will direct translators for a game to crowdsource translation page
	/// English String: "Translate this Game"
	/// </summary>
	public override string LabelTranslateThisGame => "ç¿»è­¯æ­¤éŠæˆ²";

	/// <summary>
	/// Key: "LabelAddToProfile"
	/// English String: "Add to profile"
	/// </summary>
	public override string LabelAddToProfile => "åŠ åˆ°å€‹äººæª”æ¡ˆ";

	/// <summary>
	/// Key: "LabelConfigureGame"
	/// English String: "Configure this Game"
	/// </summary>
	public override string LabelConfigureGame => "éŠæˆ²è¨­å®š";

	/// <summary>
	/// Key: "LabelConfigurePlace"
	/// English String: "Configure this Place"
	/// </summary>
	public override string LabelConfigurePlace => "ç©ºé–“è¨­å®š";

	/// <summary>
	/// Key: "LabelDeveloperStats"
	/// English String: "Developer Stats"
	/// </summary>
	public override string LabelDeveloperStats => "é–‹ç™¼äººå“¡æ•¸æ“š";

	/// <summary>
	/// Key: "LabelEdit"
	/// English String: "Edit"
	/// </summary>
	public override string LabelEdit => "ç·¨è¼¯";

	/// <summary>
	/// Key: "LabelRemoveFromProfile"
	/// English String: "Remove from Profile"
	/// </summary>
	public override string LabelRemoveFromProfile => "å¾žå€‹äººæª”æ¡ˆç§»é™¤";

	/// <summary>
	/// Key: "LabelServerError"
	/// English String: "An Error Occured"
	/// </summary>
	public override string LabelServerError => "ç™¼ç”ŸéŒ¯èª¤";

	/// <summary>
	/// Key: "LabelShutDownAllServers"
	/// English String: "Shut Down All Servers"
	/// </summary>
	public override string LabelShutDownAllServers => "é—œé–‰æ‰€æœ‰ä¼ºæœå™¨";

	/// <summary>
	/// Key: "LabelShutDownServersWarning"
	/// English String: "Are you sure you want to shut down all servers for this place?"
	/// </summary>
	public override string LabelShutDownServersWarning => "ç¢ºå®šé—œé–‰æ­¤ç©ºé–“æ‰€æœ‰ä¼ºæœå™¨ï¼Ÿ";

	/// <summary>
	/// Key: "MessageServerShutDownError"
	/// English String: "Could not shut down servers."
	/// </summary>
	public override string MessageServerShutDownError => "ç„¡æ³•é—œé–‰ä¼ºæœå™¨ã€‚";

	public GameContextMenuResources_zh_tw(TranslationResourceState state)
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
		return "ç¢ºå®š";
	}

	protected override string _GetTemplateForLabelConfigureLocalization()
	{
		return "æœ¬åœ°åŒ–è¨­å®š";
	}

	protected override string _GetTemplateForLabelTranslateThisGame()
	{
		return "ç¿»è­¯æ­¤éŠæˆ²";
	}

	protected override string _GetTemplateForLabelAddToProfile()
	{
		return "åŠ åˆ°å€‹äººæª”æ¡ˆ";
	}

	protected override string _GetTemplateForLabelConfigureGame()
	{
		return "éŠæˆ²è¨­å®š";
	}

	protected override string _GetTemplateForLabelConfigurePlace()
	{
		return "ç©ºé–“è¨­å®š";
	}

	protected override string _GetTemplateForLabelDeveloperStats()
	{
		return "é–‹ç™¼äººå“¡æ•¸æ“š";
	}

	protected override string _GetTemplateForLabelEdit()
	{
		return "ç·¨è¼¯";
	}

	protected override string _GetTemplateForLabelRemoveFromProfile()
	{
		return "å¾žå€‹äººæª”æ¡ˆç§»é™¤";
	}

	protected override string _GetTemplateForLabelServerError()
	{
		return "ç™¼ç”ŸéŒ¯èª¤";
	}

	protected override string _GetTemplateForLabelShutDownAllServers()
	{
		return "é—œé–‰æ‰€æœ‰ä¼ºæœå™¨";
	}

	protected override string _GetTemplateForLabelShutDownServersWarning()
	{
		return "ç¢ºå®šé—œé–‰æ­¤ç©ºé–“æ‰€æœ‰ä¼ºæœå™¨ï¼Ÿ";
	}

	protected override string _GetTemplateForMessageServerShutDownError()
	{
		return "ç„¡æ³•é—œé–‰ä¼ºæœå™¨ã€‚";
	}
}


}
