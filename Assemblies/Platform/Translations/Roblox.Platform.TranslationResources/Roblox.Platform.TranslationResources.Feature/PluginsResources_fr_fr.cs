namespace Roblox.TranslationResources.Feature;

/// <summary>
/// This class overrides PluginsResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class PluginsResources_fr_fr : PluginsResources_en_us, IPluginsResources, ITranslationResources
{
	/// <summary>
	/// Key: "Label.ErrorBody"
	/// English String: "There was a problem installing this plugin. Please try again later."
	/// </summary>
	public override string LabelErrorBody => "Un problème est survenu lors de l'installation de ce plugin. Veuillez réessayer plus tard.";

	/// <summary>
	/// Key: "Label.ErrorTitle"
	/// English String: "Error Installing Plugin"
	/// </summary>
	public override string LabelErrorTitle => "Erreur lors de l'installation du plugin";

	/// <summary>
	/// Key: "Label.Ok"
	/// English String: "OK"
	/// </summary>
	public override string LabelOk => "OK";

	/// <summary>
	/// Key: "Label.Reinstall"
	/// English String: "Reinstall"
	/// </summary>
	public override string LabelReinstall => "Réinstaller";

	/// <summary>
	/// Key: "Label.SuccessTitle"
	/// English String: "Plugin Installed"
	/// </summary>
	public override string LabelSuccessTitle => "Plugin installé";

	/// <summary>
	/// Key: "Label.UpdateErrorBody"
	/// English String: "There was a problem updating this plugin. Please try again later."
	/// </summary>
	public override string LabelUpdateErrorBody => "Un problème est survenu lors de la mise à jour de ce plugin. Veuillez réessayer plus tard.";

	/// <summary>
	/// Key: "Label.UpdateErrorTitle"
	/// English String: "Error Updating Plugin"
	/// </summary>
	public override string LabelUpdateErrorTitle => "Erreur lors de la mise à jour du plugin";

	/// <summary>
	/// Key: "Label.UpdateSuccessTitle"
	/// English String: "Plugin Update"
	/// </summary>
	public override string LabelUpdateSuccessTitle => "Plugin mis à jour";

	/// <summary>
	/// Key: "Label.UpdateText"
	/// English String: "Update"
	/// </summary>
	public override string LabelUpdateText => "Mise à jour";

	public PluginsResources_fr_fr(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForLabelErrorBody()
	{
		return "Un problème est survenu lors de l'installation de ce plugin. Veuillez réessayer plus tard.";
	}

	protected override string _GetTemplateForLabelErrorTitle()
	{
		return "Erreur lors de l'installation du plugin";
	}

	protected override string _GetTemplateForLabelOk()
	{
		return "OK";
	}

	protected override string _GetTemplateForLabelReinstall()
	{
		return "Réinstaller";
	}

	/// <summary>
	/// Key: "Label.SuccessBody"
	/// English String: "{item} has been successfully installed!"
	/// </summary>
	public override string LabelSuccessBody(string item)
	{
		return $"{item} a été installé\u00a0!";
	}

	protected override string _GetTemplateForLabelSuccessBody()
	{
		return "{item} a été installé\u00a0!";
	}

	protected override string _GetTemplateForLabelSuccessTitle()
	{
		return "Plugin installé";
	}

	protected override string _GetTemplateForLabelUpdateErrorBody()
	{
		return "Un problème est survenu lors de la mise à jour de ce plugin. Veuillez réessayer plus tard.";
	}

	protected override string _GetTemplateForLabelUpdateErrorTitle()
	{
		return "Erreur lors de la mise à jour du plugin";
	}

	/// <summary>
	/// Key: "Label.UpdateSuccessBody"
	/// English String: "{item} has been successfully updated! Please open a new window for the changes to take effect."
	/// </summary>
	public override string LabelUpdateSuccessBody(string item)
	{
		return $"{item} a été mis à jour\u00a0! Veuillez ouvrir une nouvelle fenêtre pour que les changements puissent être appliqués.";
	}

	protected override string _GetTemplateForLabelUpdateSuccessBody()
	{
		return "{item} a été mis à jour\u00a0! Veuillez ouvrir une nouvelle fenêtre pour que les changements puissent être appliqués.";
	}

	protected override string _GetTemplateForLabelUpdateSuccessTitle()
	{
		return "Plugin mis à jour";
	}

	protected override string _GetTemplateForLabelUpdateText()
	{
		return "Mise à jour";
	}
}
