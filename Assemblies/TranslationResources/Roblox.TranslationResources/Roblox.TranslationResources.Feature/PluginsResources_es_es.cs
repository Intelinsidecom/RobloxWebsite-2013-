namespace Roblox.TranslationResources.Feature;

/// <summary>
/// This class overrides PluginsResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class PluginsResources_es_es : PluginsResources_en_us, IPluginsResources, ITranslationResources
{
	/// <summary>
	/// Key: "Label.ErrorBody"
	/// English String: "There was a problem installing this plugin. Please try again later."
	/// </summary>
	public override string LabelErrorBody => "Ha habido un problema al instalar este complemento. Inténtalo de nuevo más tarde.";

	/// <summary>
	/// Key: "Label.ErrorTitle"
	/// English String: "Error Installing Plugin"
	/// </summary>
	public override string LabelErrorTitle => "Error al instalar el complemento";

	/// <summary>
	/// Key: "Label.Ok"
	/// English String: "OK"
	/// </summary>
	public override string LabelOk => "Aceptar";

	/// <summary>
	/// Key: "Label.Reinstall"
	/// English String: "Reinstall"
	/// </summary>
	public override string LabelReinstall => "Reinstalar";

	/// <summary>
	/// Key: "Label.SuccessTitle"
	/// English String: "Plugin Installed"
	/// </summary>
	public override string LabelSuccessTitle => "Complemento instalado";

	/// <summary>
	/// Key: "Label.UpdateErrorBody"
	/// English String: "There was a problem updating this plugin. Please try again later."
	/// </summary>
	public override string LabelUpdateErrorBody => "Ha habido un problema al actualizar este complemento. Inténtalo de nuevo más tarde.";

	/// <summary>
	/// Key: "Label.UpdateErrorTitle"
	/// English String: "Error Updating Plugin"
	/// </summary>
	public override string LabelUpdateErrorTitle => "Error al actualizar el complemento";

	/// <summary>
	/// Key: "Label.UpdateSuccessTitle"
	/// English String: "Plugin Update"
	/// </summary>
	public override string LabelUpdateSuccessTitle => "Actualización del complemento";

	/// <summary>
	/// Key: "Label.UpdateText"
	/// English String: "Update"
	/// </summary>
	public override string LabelUpdateText => "Actualizar";

	public PluginsResources_es_es(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForLabelErrorBody()
	{
		return "Ha habido un problema al instalar este complemento. Inténtalo de nuevo más tarde.";
	}

	protected override string _GetTemplateForLabelErrorTitle()
	{
		return "Error al instalar el complemento";
	}

	protected override string _GetTemplateForLabelOk()
	{
		return "Aceptar";
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
		return $"¡{item} se ha instalado correctamente!";
	}

	protected override string _GetTemplateForLabelSuccessBody()
	{
		return "¡{item} se ha instalado correctamente!";
	}

	protected override string _GetTemplateForLabelSuccessTitle()
	{
		return "Complemento instalado";
	}

	protected override string _GetTemplateForLabelUpdateErrorBody()
	{
		return "Ha habido un problema al actualizar este complemento. Inténtalo de nuevo más tarde.";
	}

	protected override string _GetTemplateForLabelUpdateErrorTitle()
	{
		return "Error al actualizar el complemento";
	}

	/// <summary>
	/// Key: "Label.UpdateSuccessBody"
	/// English String: "{item} has been successfully updated! Please open a new window for the changes to take effect."
	/// </summary>
	public override string LabelUpdateSuccessBody(string item)
	{
		return $"¡{item} se ha actualizado correctamente! Abre una ventana nueva para aplicar los cambios.";
	}

	protected override string _GetTemplateForLabelUpdateSuccessBody()
	{
		return "¡{item} se ha actualizado correctamente! Abre una ventana nueva para aplicar los cambios.";
	}

	protected override string _GetTemplateForLabelUpdateSuccessTitle()
	{
		return "Actualización del complemento";
	}

	protected override string _GetTemplateForLabelUpdateText()
	{
		return "Actualizar";
	}
}
