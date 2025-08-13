namespace Roblox.TranslationResources.Feature;

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
	public override string LabelErrorBody => "安装此插件遇到问题。请稍后重试。";

	/// <summary>
	/// Key: "Label.ErrorTitle"
	/// English String: "Error Installing Plugin"
	/// </summary>
	public override string LabelErrorTitle => "安装插件错误";

	/// <summary>
	/// Key: "Label.Ok"
	/// English String: "OK"
	/// </summary>
	public override string LabelOk => "好";

	/// <summary>
	/// Key: "Label.Reinstall"
	/// English String: "Reinstall"
	/// </summary>
	public override string LabelReinstall => "重新安装";

	/// <summary>
	/// Key: "Label.SuccessTitle"
	/// English String: "Plugin Installed"
	/// </summary>
	public override string LabelSuccessTitle => "插件已安装";

	/// <summary>
	/// Key: "Label.UpdateErrorBody"
	/// English String: "There was a problem updating this plugin. Please try again later."
	/// </summary>
	public override string LabelUpdateErrorBody => "更新此插件时遇到问题。请稍后重试。";

	/// <summary>
	/// Key: "Label.UpdateErrorTitle"
	/// English String: "Error Updating Plugin"
	/// </summary>
	public override string LabelUpdateErrorTitle => "更新插件时发生错误";

	/// <summary>
	/// Key: "Label.UpdateSuccessTitle"
	/// English String: "Plugin Update"
	/// </summary>
	public override string LabelUpdateSuccessTitle => "插件更新";

	/// <summary>
	/// Key: "Label.UpdateText"
	/// English String: "Update"
	/// </summary>
	public override string LabelUpdateText => "更新";

	public PluginsResources_zh_cjv(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForLabelErrorBody()
	{
		return "安装此插件遇到问题。请稍后重试。";
	}

	protected override string _GetTemplateForLabelErrorTitle()
	{
		return "安装插件错误";
	}

	protected override string _GetTemplateForLabelOk()
	{
		return "好";
	}

	protected override string _GetTemplateForLabelReinstall()
	{
		return "重新安装";
	}

	/// <summary>
	/// Key: "Label.SuccessBody"
	/// English String: "{item} has been successfully installed!"
	/// </summary>
	public override string LabelSuccessBody(string item)
	{
		return $"{item}已安装成功！";
	}

	protected override string _GetTemplateForLabelSuccessBody()
	{
		return "{item}已安装成功！";
	}

	protected override string _GetTemplateForLabelSuccessTitle()
	{
		return "插件已安装";
	}

	protected override string _GetTemplateForLabelUpdateErrorBody()
	{
		return "更新此插件时遇到问题。请稍后重试。";
	}

	protected override string _GetTemplateForLabelUpdateErrorTitle()
	{
		return "更新插件时发生错误";
	}

	/// <summary>
	/// Key: "Label.UpdateSuccessBody"
	/// English String: "{item} has been successfully updated! Please open a new window for the changes to take effect."
	/// </summary>
	public override string LabelUpdateSuccessBody(string item)
	{
		return $"{item}已更新成功！请打开新窗口，以让更新生效。";
	}

	protected override string _GetTemplateForLabelUpdateSuccessBody()
	{
		return "{item}已更新成功！请打开新窗口，以让更新生效。";
	}

	protected override string _GetTemplateForLabelUpdateSuccessTitle()
	{
		return "插件更新";
	}

	protected override string _GetTemplateForLabelUpdateText()
	{
		return "更新";
	}
}
