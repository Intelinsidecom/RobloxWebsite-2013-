namespace Roblox.TranslationResources.Feature;

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
	public override string LabelErrorBody => "플러그인을 설치하는 중 오류가 발생했어요. 나중에 다시 시도하세요.";

	/// <summary>
	/// Key: "Label.ErrorTitle"
	/// English String: "Error Installing Plugin"
	/// </summary>
	public override string LabelErrorTitle => "플러그인 설치 중 오류 발생";

	/// <summary>
	/// Key: "Label.Ok"
	/// English String: "OK"
	/// </summary>
	public override string LabelOk => "확인";

	/// <summary>
	/// Key: "Label.Reinstall"
	/// English String: "Reinstall"
	/// </summary>
	public override string LabelReinstall => "다시 설치";

	/// <summary>
	/// Key: "Label.SuccessTitle"
	/// English String: "Plugin Installed"
	/// </summary>
	public override string LabelSuccessTitle => "플러그인 설치됨";

	/// <summary>
	/// Key: "Label.UpdateErrorBody"
	/// English String: "There was a problem updating this plugin. Please try again later."
	/// </summary>
	public override string LabelUpdateErrorBody => "플러그인을 업데이트하는 중 오류가 발생했어요. 나중에 다시 시도하세요.";

	/// <summary>
	/// Key: "Label.UpdateErrorTitle"
	/// English String: "Error Updating Plugin"
	/// </summary>
	public override string LabelUpdateErrorTitle => "플러그인 업데이트 중 오류 발생";

	/// <summary>
	/// Key: "Label.UpdateSuccessTitle"
	/// English String: "Plugin Update"
	/// </summary>
	public override string LabelUpdateSuccessTitle => "플러그인 업데이트";

	/// <summary>
	/// Key: "Label.UpdateText"
	/// English String: "Update"
	/// </summary>
	public override string LabelUpdateText => "업데이트";

	public PluginsResources_ko_kr(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForLabelErrorBody()
	{
		return "플러그인을 설치하는 중 오류가 발생했어요. 나중에 다시 시도하세요.";
	}

	protected override string _GetTemplateForLabelErrorTitle()
	{
		return "플러그인 설치 중 오류 발생";
	}

	protected override string _GetTemplateForLabelOk()
	{
		return "확인";
	}

	protected override string _GetTemplateForLabelReinstall()
	{
		return "다시 설치";
	}

	/// <summary>
	/// Key: "Label.SuccessBody"
	/// English String: "{item} has been successfully installed!"
	/// </summary>
	public override string LabelSuccessBody(string item)
	{
		return $"{item} 설치를 완료했어요!";
	}

	protected override string _GetTemplateForLabelSuccessBody()
	{
		return "{item} 설치를 완료했어요!";
	}

	protected override string _GetTemplateForLabelSuccessTitle()
	{
		return "플러그인 설치됨";
	}

	protected override string _GetTemplateForLabelUpdateErrorBody()
	{
		return "플러그인을 업데이트하는 중 오류가 발생했어요. 나중에 다시 시도하세요.";
	}

	protected override string _GetTemplateForLabelUpdateErrorTitle()
	{
		return "플러그인 업데이트 중 오류 발생";
	}

	/// <summary>
	/// Key: "Label.UpdateSuccessBody"
	/// English String: "{item} has been successfully updated! Please open a new window for the changes to take effect."
	/// </summary>
	public override string LabelUpdateSuccessBody(string item)
	{
		return $"{item} 업데이트를 완료했어요! 변경 사항을 적용하도록 새 창을 열어주세요.";
	}

	protected override string _GetTemplateForLabelUpdateSuccessBody()
	{
		return "{item} 업데이트를 완료했어요! 변경 사항을 적용하도록 새 창을 열어주세요.";
	}

	protected override string _GetTemplateForLabelUpdateSuccessTitle()
	{
		return "플러그인 업데이트";
	}

	protected override string _GetTemplateForLabelUpdateText()
	{
		return "업데이트";
	}
}
