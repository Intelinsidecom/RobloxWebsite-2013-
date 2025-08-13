namespace Roblox.TranslationResources.Feature;

/// <summary>
/// This class overrides PluginsResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class PluginsResources_pt_br : PluginsResources_en_us, IPluginsResources, ITranslationResources
{
	/// <summary>
	/// Key: "Label.ErrorBody"
	/// English String: "There was a problem installing this plugin. Please try again later."
	/// </summary>
	public override string LabelErrorBody => "Ocorreu um erro ao instalar este plugin. Tente de novo mais tarde.";

	/// <summary>
	/// Key: "Label.ErrorTitle"
	/// English String: "Error Installing Plugin"
	/// </summary>
	public override string LabelErrorTitle => "Erro ao instalar plugin";

	/// <summary>
	/// Key: "Label.Ok"
	/// English String: "OK"
	/// </summary>
	public override string LabelOk => "OK";

	/// <summary>
	/// Key: "Label.Reinstall"
	/// English String: "Reinstall"
	/// </summary>
	public override string LabelReinstall => "Reinstalar";

	/// <summary>
	/// Key: "Label.SuccessTitle"
	/// English String: "Plugin Installed"
	/// </summary>
	public override string LabelSuccessTitle => "Plugin instalado";

	/// <summary>
	/// Key: "Label.UpdateErrorBody"
	/// English String: "There was a problem updating this plugin. Please try again later."
	/// </summary>
	public override string LabelUpdateErrorBody => "Ocorreu um erro ao atualizar este plugin. Tente de novo mais tarde.";

	/// <summary>
	/// Key: "Label.UpdateErrorTitle"
	/// English String: "Error Updating Plugin"
	/// </summary>
	public override string LabelUpdateErrorTitle => "Erro ao atualizar plugin";

	/// <summary>
	/// Key: "Label.UpdateSuccessTitle"
	/// English String: "Plugin Update"
	/// </summary>
	public override string LabelUpdateSuccessTitle => "Atualização de plugin";

	/// <summary>
	/// Key: "Label.UpdateText"
	/// English String: "Update"
	/// </summary>
	public override string LabelUpdateText => "Atualização";

	public PluginsResources_pt_br(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForLabelErrorBody()
	{
		return "Ocorreu um erro ao instalar este plugin. Tente de novo mais tarde.";
	}

	protected override string _GetTemplateForLabelErrorTitle()
	{
		return "Erro ao instalar plugin";
	}

	protected override string _GetTemplateForLabelOk()
	{
		return "OK";
	}

	protected override string _GetTemplateForLabelReinstall()
	{
		return "Reinstalar";
	}

	/// <summary>
	/// Key: "Label.SuccessBody"
	/// English String: "{item} has been successfully installed!"
	/// </summary>
	public override string LabelSuccessBody(string item)
	{
		return $"{item} foi instalado com sucesso!";
	}

	protected override string _GetTemplateForLabelSuccessBody()
	{
		return "{item} foi instalado com sucesso!";
	}

	protected override string _GetTemplateForLabelSuccessTitle()
	{
		return "Plugin instalado";
	}

	protected override string _GetTemplateForLabelUpdateErrorBody()
	{
		return "Ocorreu um erro ao atualizar este plugin. Tente de novo mais tarde.";
	}

	protected override string _GetTemplateForLabelUpdateErrorTitle()
	{
		return "Erro ao atualizar plugin";
	}

	/// <summary>
	/// Key: "Label.UpdateSuccessBody"
	/// English String: "{item} has been successfully updated! Please open a new window for the changes to take effect."
	/// </summary>
	public override string LabelUpdateSuccessBody(string item)
	{
		return $"{item} foi atualizado com sucesso! Abra uma nova janela para que as alterações tenham efeito.";
	}

	protected override string _GetTemplateForLabelUpdateSuccessBody()
	{
		return "{item} foi atualizado com sucesso! Abra uma nova janela para que as alterações tenham efeito.";
	}

	protected override string _GetTemplateForLabelUpdateSuccessTitle()
	{
		return "Atualização de plugin";
	}

	protected override string _GetTemplateForLabelUpdateText()
	{
		return "Atualização";
	}
}
