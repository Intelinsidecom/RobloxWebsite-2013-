namespace Roblox.Platform.TranslationResources.Feature {
    /// <summary>

/// This class overrides PluginsResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class PluginsResources_zh_cjv : PluginsResources_en_us, IPluginsResources, ITranslationResources
{
	/// <summary>
	/// Key: "Label.ErrorBody"
	/// English String: "There was a problem installing this plugin. Please try again later."
	/// </summary>
	public override string LabelErrorBody => "å®‰è£…æ­¤æ’ä»¶é‡åˆ°é—®é¢˜ã€‚è¯·ç¨åŽé‡è¯•ã€‚";

	/// <summary>
	/// Key: "Label.ErrorTitle"
	/// English String: "Error Installing Plugin"
	/// </summary>
	public override string LabelErrorTitle => "å®‰è£…æ’ä»¶é”™è¯¯";

	/// <summary>
	/// Key: "Label.Ok"
	/// English String: "OK"
	/// </summary>
	public override string LabelOk => "å¥½";

	/// <summary>
	/// Key: "Label.Reinstall"
	/// English String: "Reinstall"
	/// </summary>
	public override string LabelReinstall => "é‡æ–°å®‰è£…";

	/// <summary>
	/// Key: "Label.SuccessTitle"
	/// English String: "Plugin Installed"
	/// </summary>
	public override string LabelSuccessTitle => "æ’ä»¶å·²å®‰è£…";

	/// <summary>
	/// Key: "Label.UpdateErrorBody"
	/// English String: "There was a problem updating this plugin. Please try again later."
	/// </summary>
	public override string LabelUpdateErrorBody => "æ›´æ–°æ­¤æ’ä»¶æ—¶é‡åˆ°é—®é¢˜ã€‚è¯·ç¨åŽé‡è¯•ã€‚";

	/// <summary>
	/// Key: "Label.UpdateErrorTitle"
	/// English String: "Error Updating Plugin"
	/// </summary>
	public override string LabelUpdateErrorTitle => "æ›´æ–°æ’ä»¶æ—¶å‘ç”Ÿé”™è¯¯";

	/// <summary>
	/// Key: "Label.UpdateSuccessTitle"
	/// English String: "Plugin Update"
	/// </summary>
	public override string LabelUpdateSuccessTitle => "æ’ä»¶æ›´æ–°";

	/// <summary>
	/// Key: "Label.UpdateText"
	/// English String: "Update"
	/// </summary>
	public override string LabelUpdateText => "æ›´æ–°";

	public PluginsResources_zh_cjv(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForLabelErrorBody()
	{
		return "å®‰è£…æ­¤æ’ä»¶é‡åˆ°é—®é¢˜ã€‚è¯·ç¨åŽé‡è¯•ã€‚";
	}

	protected override string _GetTemplateForLabelErrorTitle()
	{
		return "å®‰è£…æ’ä»¶é”™è¯¯";
	}

	protected override string _GetTemplateForLabelOk()
	{
		return "å¥½";
	}

	protected override string _GetTemplateForLabelReinstall()
	{
		return "é‡æ–°å®‰è£…";
	}

	/// <summary>
	/// Key: "Label.SuccessBody"
	/// English String: "{item} has been successfully installed!"
	/// </summary>
	public override string LabelSuccessBody(string item)
	{
		return $"{item}å·²å®‰è£…æˆåŠŸï¼";
	}

	protected override string _GetTemplateForLabelSuccessBody()
	{
		return "{item}å·²å®‰è£…æˆåŠŸï¼";
	}

	protected override string _GetTemplateForLabelSuccessTitle()
	{
		return "æ’ä»¶å·²å®‰è£…";
	}

	protected override string _GetTemplateForLabelUpdateErrorBody()
	{
		return "æ›´æ–°æ­¤æ’ä»¶æ—¶é‡åˆ°é—®é¢˜ã€‚è¯·ç¨åŽé‡è¯•ã€‚";
	}

	protected override string _GetTemplateForLabelUpdateErrorTitle()
	{
		return "æ›´æ–°æ’ä»¶æ—¶å‘ç”Ÿé”™è¯¯";
	}

	/// <summary>
	/// Key: "Label.UpdateSuccessBody"
	/// English String: "{item} has been successfully updated! Please open a new window for the changes to take effect."
	/// </summary>
	public override string LabelUpdateSuccessBody(string item)
	{
		return $"{item}å·²æ›´æ–°æˆåŠŸï¼è¯·æ‰“å¼€æ–°çª—å£ï¼Œä»¥è®©æ›´æ–°ç”Ÿæ•ˆã€‚";
	}

	protected override string _GetTemplateForLabelUpdateSuccessBody()
	{
		return "{item}å·²æ›´æ–°æˆåŠŸï¼è¯·æ‰“å¼€æ–°çª—å£ï¼Œä»¥è®©æ›´æ–°ç”Ÿæ•ˆã€‚";
	}

	protected override string _GetTemplateForLabelUpdateSuccessTitle()
	{
		return "æ’ä»¶æ›´æ–°";
	}

	protected override string _GetTemplateForLabelUpdateText()
	{
		return "æ›´æ–°";
	}
}


}
