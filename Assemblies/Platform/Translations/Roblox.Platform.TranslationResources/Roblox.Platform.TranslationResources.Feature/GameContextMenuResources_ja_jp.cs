namespace Roblox.Platform.TranslationResources.Feature {
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
	public override string ActionDialogAccept => "ã¯ã„";

	/// <summary>
	/// Key: "ActionDialogDecline"
	/// English String: "No"
	/// </summary>
	public override string ActionDialogDecline => "ã„ã„ãˆ";

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
	public override string LabelConfigureLocalization => "ç¿»è¨³ã®ç’°å¢ƒè¨­å®š";

	/// <summary>
	/// Key: "Label.TranslateThisGame"
	/// The label in context menu that will direct translators for a game to crowdsource translation page
	/// English String: "Translate this Game"
	/// </summary>
	public override string LabelTranslateThisGame => "ã“ã®ã‚²ãƒ¼ãƒ ã‚’ç¿»è¨³ã™ã‚‹";

	/// <summary>
	/// Key: "LabelAddToProfile"
	/// English String: "Add to profile"
	/// </summary>
	public override string LabelAddToProfile => "ãƒ—ãƒ­ãƒ•ã‚£ãƒ¼ãƒ«ã«è¿½åŠ ";

	/// <summary>
	/// Key: "LabelConfigureGame"
	/// English String: "Configure this Game"
	/// </summary>
	public override string LabelConfigureGame => "ã“ã®ã‚²ãƒ¼ãƒ ã‚’ç’°å¢ƒè¨­å®šã™ã‚‹";

	/// <summary>
	/// Key: "LabelConfigurePlace"
	/// English String: "Configure this Place"
	/// </summary>
	public override string LabelConfigurePlace => "ã“ã®ãƒ—ãƒ¬ãƒ¼ã‚¹ã‚’ç’°å¢ƒè¨­å®šã™ã‚‹";

	/// <summary>
	/// Key: "LabelDeveloperStats"
	/// English String: "Developer Stats"
	/// </summary>
	public override string LabelDeveloperStats => "é–‹ç™ºè€…ãƒ‡ãƒ¼ã‚¿";

	/// <summary>
	/// Key: "LabelEdit"
	/// English String: "Edit"
	/// </summary>
	public override string LabelEdit => "ç·¨é›†";

	/// <summary>
	/// Key: "LabelRemoveFromProfile"
	/// English String: "Remove from Profile"
	/// </summary>
	public override string LabelRemoveFromProfile => "ãƒ—ãƒ­ãƒ•ã‚£ãƒ¼ãƒ«ã‹ã‚‰å‰Šé™¤";

	/// <summary>
	/// Key: "LabelServerError"
	/// English String: "An Error Occured"
	/// </summary>
	public override string LabelServerError => "ã‚¨ãƒ©ãƒ¼ãŒç™ºç”Ÿ";

	/// <summary>
	/// Key: "LabelShutDownAllServers"
	/// English String: "Shut Down All Servers"
	/// </summary>
	public override string LabelShutDownAllServers => "ã™ã¹ã¦ã®ã‚µãƒ¼ãƒãƒ¼ã‚’ã‚·ãƒ£ãƒƒãƒˆãƒ€ã‚¦ãƒ³";

	/// <summary>
	/// Key: "LabelShutDownServersWarning"
	/// English String: "Are you sure you want to shut down all servers for this place?"
	/// </summary>
	public override string LabelShutDownServersWarning => "ã“ã®ãƒ—ãƒ¬ãƒ¼ã‚¹ã®ã™ã¹ã¦ã®ã‚µãƒ¼ãƒãƒ¼ã‚’ã‚·ãƒ£ãƒƒãƒˆãƒ€ã‚¦ãƒ³ã—ã¦ã‚ˆã‚ã—ã„ã§ã™ã‹ï¼Ÿ";

	/// <summary>
	/// Key: "MessageServerShutDownError"
	/// English String: "Could not shut down servers."
	/// </summary>
	public override string MessageServerShutDownError => "ã‚µãƒ¼ãƒãƒ¼ã‚’ã‚·ãƒ£ãƒƒãƒˆãƒ€ã‚¦ãƒ³ã§ãã¾ã›ã‚“ã§ã—ãŸã€‚";

	public GameContextMenuResources_ja_jp(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionDialogAccept()
	{
		return "ã¯ã„";
	}

	protected override string _GetTemplateForActionDialogDecline()
	{
		return "ã„ã„ãˆ";
	}

	protected override string _GetTemplateForActionDialogOk()
	{
		return "OK";
	}

	protected override string _GetTemplateForLabelConfigureLocalization()
	{
		return "ç¿»è¨³ã®ç’°å¢ƒè¨­å®š";
	}

	protected override string _GetTemplateForLabelTranslateThisGame()
	{
		return "ã“ã®ã‚²ãƒ¼ãƒ ã‚’ç¿»è¨³ã™ã‚‹";
	}

	protected override string _GetTemplateForLabelAddToProfile()
	{
		return "ãƒ—ãƒ­ãƒ•ã‚£ãƒ¼ãƒ«ã«è¿½åŠ ";
	}

	protected override string _GetTemplateForLabelConfigureGame()
	{
		return "ã“ã®ã‚²ãƒ¼ãƒ ã‚’ç’°å¢ƒè¨­å®šã™ã‚‹";
	}

	protected override string _GetTemplateForLabelConfigurePlace()
	{
		return "ã“ã®ãƒ—ãƒ¬ãƒ¼ã‚¹ã‚’ç’°å¢ƒè¨­å®šã™ã‚‹";
	}

	protected override string _GetTemplateForLabelDeveloperStats()
	{
		return "é–‹ç™ºè€…ãƒ‡ãƒ¼ã‚¿";
	}

	protected override string _GetTemplateForLabelEdit()
	{
		return "ç·¨é›†";
	}

	protected override string _GetTemplateForLabelRemoveFromProfile()
	{
		return "ãƒ—ãƒ­ãƒ•ã‚£ãƒ¼ãƒ«ã‹ã‚‰å‰Šé™¤";
	}

	protected override string _GetTemplateForLabelServerError()
	{
		return "ã‚¨ãƒ©ãƒ¼ãŒç™ºç”Ÿ";
	}

	protected override string _GetTemplateForLabelShutDownAllServers()
	{
		return "ã™ã¹ã¦ã®ã‚µãƒ¼ãƒãƒ¼ã‚’ã‚·ãƒ£ãƒƒãƒˆãƒ€ã‚¦ãƒ³";
	}

	protected override string _GetTemplateForLabelShutDownServersWarning()
	{
		return "ã“ã®ãƒ—ãƒ¬ãƒ¼ã‚¹ã®ã™ã¹ã¦ã®ã‚µãƒ¼ãƒãƒ¼ã‚’ã‚·ãƒ£ãƒƒãƒˆãƒ€ã‚¦ãƒ³ã—ã¦ã‚ˆã‚ã—ã„ã§ã™ã‹ï¼Ÿ";
	}

	protected override string _GetTemplateForMessageServerShutDownError()
	{
		return "ã‚µãƒ¼ãƒãƒ¼ã‚’ã‚·ãƒ£ãƒƒãƒˆãƒ€ã‚¦ãƒ³ã§ãã¾ã›ã‚“ã§ã—ãŸã€‚";
	}
}


}
