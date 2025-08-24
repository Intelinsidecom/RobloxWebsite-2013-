namespace Roblox.TranslationResources.Feature;

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
	public override string LabelErrorBody => "問題が発生したためプラグインをインストールできません。後でもう一度お試しください。";

	/// <summary>
	/// Key: "Label.ErrorTitle"
	/// English String: "Error Installing Plugin"
	/// </summary>
	public override string LabelErrorTitle => "プラグインのインストールエラー";

	/// <summary>
	/// Key: "Label.Ok"
	/// English String: "OK"
	/// </summary>
	public override string LabelOk => "OK";

	/// <summary>
	/// Key: "Label.Reinstall"
	/// English String: "Reinstall"
	/// </summary>
	public override string LabelReinstall => "再インストール";

	/// <summary>
	/// Key: "Label.SuccessTitle"
	/// English String: "Plugin Installed"
	/// </summary>
	public override string LabelSuccessTitle => "プラグインをインストールしました";

	/// <summary>
	/// Key: "Label.UpdateErrorBody"
	/// English String: "There was a problem updating this plugin. Please try again later."
	/// </summary>
	public override string LabelUpdateErrorBody => "問題が発生したため、このプラグインをアップデートできません。後でもう一度お試しください。";

	/// <summary>
	/// Key: "Label.UpdateErrorTitle"
	/// English String: "Error Updating Plugin"
	/// </summary>
	public override string LabelUpdateErrorTitle => "プラグインのアップデートエラー";

	/// <summary>
	/// Key: "Label.UpdateSuccessTitle"
	/// English String: "Plugin Update"
	/// </summary>
	public override string LabelUpdateSuccessTitle => "プラグインのアップデート";

	/// <summary>
	/// Key: "Label.UpdateText"
	/// English String: "Update"
	/// </summary>
	public override string LabelUpdateText => "アップデート";

	public PluginsResources_ja_jp(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForLabelErrorBody()
	{
		return "問題が発生したためプラグインをインストールできません。後でもう一度お試しください。";
	}

	protected override string _GetTemplateForLabelErrorTitle()
	{
		return "プラグインのインストールエラー";
	}

	protected override string _GetTemplateForLabelOk()
	{
		return "OK";
	}

	protected override string _GetTemplateForLabelReinstall()
	{
		return "再インストール";
	}

	/// <summary>
	/// Key: "Label.SuccessBody"
	/// English String: "{item} has been successfully installed!"
	/// </summary>
	public override string LabelSuccessBody(string item)
	{
		return $"{item} をインストールしました！";
	}

	protected override string _GetTemplateForLabelSuccessBody()
	{
		return "{item} をインストールしました！";
	}

	protected override string _GetTemplateForLabelSuccessTitle()
	{
		return "プラグインをインストールしました";
	}

	protected override string _GetTemplateForLabelUpdateErrorBody()
	{
		return "問題が発生したため、このプラグインをアップデートできません。後でもう一度お試しください。";
	}

	protected override string _GetTemplateForLabelUpdateErrorTitle()
	{
		return "プラグインのアップデートエラー";
	}

	/// <summary>
	/// Key: "Label.UpdateSuccessBody"
	/// English String: "{item} has been successfully updated! Please open a new window for the changes to take effect."
	/// </summary>
	public override string LabelUpdateSuccessBody(string item)
	{
		return $"{item} をアップデートしました！変更内容を反映させるには、新しいウィンドウを開いてください。";
	}

	protected override string _GetTemplateForLabelUpdateSuccessBody()
	{
		return "{item} をアップデートしました！変更内容を反映させるには、新しいウィンドウを開いてください。";
	}

	protected override string _GetTemplateForLabelUpdateSuccessTitle()
	{
		return "プラグインのアップデート";
	}

	protected override string _GetTemplateForLabelUpdateText()
	{
		return "アップデート";
	}
}
