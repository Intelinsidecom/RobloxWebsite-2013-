namespace Roblox.Platform.TranslationResources.Feature {
    /// <summary>

/// This class overrides PluginsResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class PluginsResources_ja_jp : PluginsResources_en_us, IPluginsResources, ITranslationResources
{
	/// <summary>
	/// Key: "Label.ErrorBody"
	/// English String: "There was a problem installing this plugin. Please try again later."
	/// </summary>
	public override string LabelErrorBody => "å•é¡ŒãŒç™ºç”Ÿã—ãŸãŸã‚ãƒ—ãƒ©ã‚°ã‚¤ãƒ³ã‚’ã‚¤ãƒ³ã‚¹ãƒˆãƒ¼ãƒ«ã§ãã¾ã›ã‚“ã€‚å¾Œã§ã‚‚ã†ä¸€åº¦ãŠè©¦ã—ãã ã•ã„ã€‚";

	/// <summary>
	/// Key: "Label.ErrorTitle"
	/// English String: "Error Installing Plugin"
	/// </summary>
	public override string LabelErrorTitle => "ãƒ—ãƒ©ã‚°ã‚¤ãƒ³ã®ã‚¤ãƒ³ã‚¹ãƒˆãƒ¼ãƒ«ã‚¨ãƒ©ãƒ¼";

	/// <summary>
	/// Key: "Label.Ok"
	/// English String: "OK"
	/// </summary>
	public override string LabelOk => "OK";

	/// <summary>
	/// Key: "Label.Reinstall"
	/// English String: "Reinstall"
	/// </summary>
	public override string LabelReinstall => "å†ã‚¤ãƒ³ã‚¹ãƒˆãƒ¼ãƒ«";

	/// <summary>
	/// Key: "Label.SuccessTitle"
	/// English String: "Plugin Installed"
	/// </summary>
	public override string LabelSuccessTitle => "ãƒ—ãƒ©ã‚°ã‚¤ãƒ³ã‚’ã‚¤ãƒ³ã‚¹ãƒˆãƒ¼ãƒ«ã—ã¾ã—ãŸ";

	/// <summary>
	/// Key: "Label.UpdateErrorBody"
	/// English String: "There was a problem updating this plugin. Please try again later."
	/// </summary>
	public override string LabelUpdateErrorBody => "å•é¡ŒãŒç™ºç”Ÿã—ãŸãŸã‚ã€ã“ã®ãƒ—ãƒ©ã‚°ã‚¤ãƒ³ã‚’ã‚¢ãƒƒãƒ—ãƒ‡ãƒ¼ãƒˆã§ãã¾ã›ã‚“ã€‚å¾Œã§ã‚‚ã†ä¸€åº¦ãŠè©¦ã—ãã ã•ã„ã€‚";

	/// <summary>
	/// Key: "Label.UpdateErrorTitle"
	/// English String: "Error Updating Plugin"
	/// </summary>
	public override string LabelUpdateErrorTitle => "ãƒ—ãƒ©ã‚°ã‚¤ãƒ³ã®ã‚¢ãƒƒãƒ—ãƒ‡ãƒ¼ãƒˆã‚¨ãƒ©ãƒ¼";

	/// <summary>
	/// Key: "Label.UpdateSuccessTitle"
	/// English String: "Plugin Update"
	/// </summary>
	public override string LabelUpdateSuccessTitle => "ãƒ—ãƒ©ã‚°ã‚¤ãƒ³ã®ã‚¢ãƒƒãƒ—ãƒ‡ãƒ¼ãƒˆ";

	/// <summary>
	/// Key: "Label.UpdateText"
	/// English String: "Update"
	/// </summary>
	public override string LabelUpdateText => "ã‚¢ãƒƒãƒ—ãƒ‡ãƒ¼ãƒˆ";

	public PluginsResources_ja_jp(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForLabelErrorBody()
	{
		return "å•é¡ŒãŒç™ºç”Ÿã—ãŸãŸã‚ãƒ—ãƒ©ã‚°ã‚¤ãƒ³ã‚’ã‚¤ãƒ³ã‚¹ãƒˆãƒ¼ãƒ«ã§ãã¾ã›ã‚“ã€‚å¾Œã§ã‚‚ã†ä¸€åº¦ãŠè©¦ã—ãã ã•ã„ã€‚";
	}

	protected override string _GetTemplateForLabelErrorTitle()
	{
		return "ãƒ—ãƒ©ã‚°ã‚¤ãƒ³ã®ã‚¤ãƒ³ã‚¹ãƒˆãƒ¼ãƒ«ã‚¨ãƒ©ãƒ¼";
	}

	protected override string _GetTemplateForLabelOk()
	{
		return "OK";
	}

	protected override string _GetTemplateForLabelReinstall()
	{
		return "å†ã‚¤ãƒ³ã‚¹ãƒˆãƒ¼ãƒ«";
	}

	/// <summary>
	/// Key: "Label.SuccessBody"
	/// English String: "{item} has been successfully installed!"
	/// </summary>
	public override string LabelSuccessBody(string item)
	{
		return $"{item} ã‚’ã‚¤ãƒ³ã‚¹ãƒˆãƒ¼ãƒ«ã—ã¾ã—ãŸï¼";
	}

	protected override string _GetTemplateForLabelSuccessBody()
	{
		return "{item} ã‚’ã‚¤ãƒ³ã‚¹ãƒˆãƒ¼ãƒ«ã—ã¾ã—ãŸï¼";
	}

	protected override string _GetTemplateForLabelSuccessTitle()
	{
		return "ãƒ—ãƒ©ã‚°ã‚¤ãƒ³ã‚’ã‚¤ãƒ³ã‚¹ãƒˆãƒ¼ãƒ«ã—ã¾ã—ãŸ";
	}

	protected override string _GetTemplateForLabelUpdateErrorBody()
	{
		return "å•é¡ŒãŒç™ºç”Ÿã—ãŸãŸã‚ã€ã“ã®ãƒ—ãƒ©ã‚°ã‚¤ãƒ³ã‚’ã‚¢ãƒƒãƒ—ãƒ‡ãƒ¼ãƒˆã§ãã¾ã›ã‚“ã€‚å¾Œã§ã‚‚ã†ä¸€åº¦ãŠè©¦ã—ãã ã•ã„ã€‚";
	}

	protected override string _GetTemplateForLabelUpdateErrorTitle()
	{
		return "ãƒ—ãƒ©ã‚°ã‚¤ãƒ³ã®ã‚¢ãƒƒãƒ—ãƒ‡ãƒ¼ãƒˆã‚¨ãƒ©ãƒ¼";
	}

	/// <summary>
	/// Key: "Label.UpdateSuccessBody"
	/// English String: "{item} has been successfully updated! Please open a new window for the changes to take effect."
	/// </summary>
	public override string LabelUpdateSuccessBody(string item)
	{
		return $"{item} ã‚’ã‚¢ãƒƒãƒ—ãƒ‡ãƒ¼ãƒˆã—ã¾ã—ãŸï¼å¤‰æ›´å†…å®¹ã‚’åæ˜ ã•ã›ã‚‹ã«ã¯ã€æ–°ã—ã„ã‚¦ã‚£ãƒ³ãƒ‰ã‚¦ã‚’é–‹ã„ã¦ãã ã•ã„ã€‚";
	}

	protected override string _GetTemplateForLabelUpdateSuccessBody()
	{
		return "{item} ã‚’ã‚¢ãƒƒãƒ—ãƒ‡ãƒ¼ãƒˆã—ã¾ã—ãŸï¼å¤‰æ›´å†…å®¹ã‚’åæ˜ ã•ã›ã‚‹ã«ã¯ã€æ–°ã—ã„ã‚¦ã‚£ãƒ³ãƒ‰ã‚¦ã‚’é–‹ã„ã¦ãã ã•ã„ã€‚";
	}

	protected override string _GetTemplateForLabelUpdateSuccessTitle()
	{
		return "ãƒ—ãƒ©ã‚°ã‚¤ãƒ³ã®ã‚¢ãƒƒãƒ—ãƒ‡ãƒ¼ãƒˆ";
	}

	protected override string _GetTemplateForLabelUpdateText()
	{
		return "ã‚¢ãƒƒãƒ—ãƒ‡ãƒ¼ãƒˆ";
	}
}


}
