namespace Roblox.Platform.TranslationResources.Feature {
    /// <summary>

/// This class overrides PluginsResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class PluginsResources_ko_kr : PluginsResources_en_us, IPluginsResources, ITranslationResources
{
	/// <summary>
	/// Key: "Label.ErrorBody"
	/// English String: "There was a problem installing this plugin. Please try again later."
	/// </summary>
	public override string LabelErrorBody => "í”ŒëŸ¬ê·¸ì¸ì„ ì„¤ì¹˜í•˜ëŠ” ì¤‘ ì˜¤ë¥˜ê°€ ë°œìƒí–ˆì–´ìš”. ë‚˜ì¤‘ì— ë‹¤ì‹œ ì‹œë„í•˜ì„¸ìš”.";

	/// <summary>
	/// Key: "Label.ErrorTitle"
	/// English String: "Error Installing Plugin"
	/// </summary>
	public override string LabelErrorTitle => "í”ŒëŸ¬ê·¸ì¸ ì„¤ì¹˜ ì¤‘ ì˜¤ë¥˜ ë°œìƒ";

	/// <summary>
	/// Key: "Label.Ok"
	/// English String: "OK"
	/// </summary>
	public override string LabelOk => "í™•ì¸";

	/// <summary>
	/// Key: "Label.Reinstall"
	/// English String: "Reinstall"
	/// </summary>
	public override string LabelReinstall => "ë‹¤ì‹œ ì„¤ì¹˜";

	/// <summary>
	/// Key: "Label.SuccessTitle"
	/// English String: "Plugin Installed"
	/// </summary>
	public override string LabelSuccessTitle => "í”ŒëŸ¬ê·¸ì¸ ì„¤ì¹˜ë¨";

	/// <summary>
	/// Key: "Label.UpdateErrorBody"
	/// English String: "There was a problem updating this plugin. Please try again later."
	/// </summary>
	public override string LabelUpdateErrorBody => "í”ŒëŸ¬ê·¸ì¸ì„ ì—…ë°ì´íŠ¸í•˜ëŠ” ì¤‘ ì˜¤ë¥˜ê°€ ë°œìƒí–ˆì–´ìš”. ë‚˜ì¤‘ì— ë‹¤ì‹œ ì‹œë„í•˜ì„¸ìš”.";

	/// <summary>
	/// Key: "Label.UpdateErrorTitle"
	/// English String: "Error Updating Plugin"
	/// </summary>
	public override string LabelUpdateErrorTitle => "í”ŒëŸ¬ê·¸ì¸ ì—…ë°ì´íŠ¸ ì¤‘ ì˜¤ë¥˜ ë°œìƒ";

	/// <summary>
	/// Key: "Label.UpdateSuccessTitle"
	/// English String: "Plugin Update"
	/// </summary>
	public override string LabelUpdateSuccessTitle => "í”ŒëŸ¬ê·¸ì¸ ì—…ë°ì´íŠ¸";

	/// <summary>
	/// Key: "Label.UpdateText"
	/// English String: "Update"
	/// </summary>
	public override string LabelUpdateText => "ì—…ë°ì´íŠ¸";

	public PluginsResources_ko_kr(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForLabelErrorBody()
	{
		return "í”ŒëŸ¬ê·¸ì¸ì„ ì„¤ì¹˜í•˜ëŠ” ì¤‘ ì˜¤ë¥˜ê°€ ë°œìƒí–ˆì–´ìš”. ë‚˜ì¤‘ì— ë‹¤ì‹œ ì‹œë„í•˜ì„¸ìš”.";
	}

	protected override string _GetTemplateForLabelErrorTitle()
	{
		return "í”ŒëŸ¬ê·¸ì¸ ì„¤ì¹˜ ì¤‘ ì˜¤ë¥˜ ë°œìƒ";
	}

	protected override string _GetTemplateForLabelOk()
	{
		return "í™•ì¸";
	}

	protected override string _GetTemplateForLabelReinstall()
	{
		return "ë‹¤ì‹œ ì„¤ì¹˜";
	}

	/// <summary>
	/// Key: "Label.SuccessBody"
	/// English String: "{item} has been successfully installed!"
	/// </summary>
	public override string LabelSuccessBody(string item)
	{
		return $"{item} ì„¤ì¹˜ë¥¼ ì™„ë£Œí–ˆì–´ìš”!";
	}

	protected override string _GetTemplateForLabelSuccessBody()
	{
		return "{item} ì„¤ì¹˜ë¥¼ ì™„ë£Œí–ˆì–´ìš”!";
	}

	protected override string _GetTemplateForLabelSuccessTitle()
	{
		return "í”ŒëŸ¬ê·¸ì¸ ì„¤ì¹˜ë¨";
	}

	protected override string _GetTemplateForLabelUpdateErrorBody()
	{
		return "í”ŒëŸ¬ê·¸ì¸ì„ ì—…ë°ì´íŠ¸í•˜ëŠ” ì¤‘ ì˜¤ë¥˜ê°€ ë°œìƒí–ˆì–´ìš”. ë‚˜ì¤‘ì— ë‹¤ì‹œ ì‹œë„í•˜ì„¸ìš”.";
	}

	protected override string _GetTemplateForLabelUpdateErrorTitle()
	{
		return "í”ŒëŸ¬ê·¸ì¸ ì—…ë°ì´íŠ¸ ì¤‘ ì˜¤ë¥˜ ë°œìƒ";
	}

	/// <summary>
	/// Key: "Label.UpdateSuccessBody"
	/// English String: "{item} has been successfully updated! Please open a new window for the changes to take effect."
	/// </summary>
	public override string LabelUpdateSuccessBody(string item)
	{
		return $"{item} ì—…ë°ì´íŠ¸ë¥¼ ì™„ë£Œí–ˆì–´ìš”! ë³€ê²½ ì‚¬í•­ì„ ì ìš©í•˜ë„ë¡ ìƒˆ ì°½ì„ ì—´ì–´ì£¼ì„¸ìš”.";
	}

	protected override string _GetTemplateForLabelUpdateSuccessBody()
	{
		return "{item} ì—…ë°ì´íŠ¸ë¥¼ ì™„ë£Œí–ˆì–´ìš”! ë³€ê²½ ì‚¬í•­ì„ ì ìš©í•˜ë„ë¡ ìƒˆ ì°½ì„ ì—´ì–´ì£¼ì„¸ìš”.";
	}

	protected override string _GetTemplateForLabelUpdateSuccessTitle()
	{
		return "í”ŒëŸ¬ê·¸ì¸ ì—…ë°ì´íŠ¸";
	}

	protected override string _GetTemplateForLabelUpdateText()
	{
		return "ì—…ë°ì´íŠ¸";
	}
}


}
