namespace Roblox.Platform.TranslationResources.Feature {
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
	public override string LabelErrorBody => "Un problÃ¨me est survenu lors de l'installation de ce plugin. Veuillez rÃ©essayer plus tard.";

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
	public override string LabelReinstall => "RÃ©installer";

	/// <summary>
	/// Key: "Label.SuccessTitle"
	/// English String: "Plugin Installed"
	/// </summary>
	public override string LabelSuccessTitle => "Plugin installÃ©";

	/// <summary>
	/// Key: "Label.UpdateErrorBody"
	/// English String: "There was a problem updating this plugin. Please try again later."
	/// </summary>
	public override string LabelUpdateErrorBody => "Un problÃ¨me est survenu lors de la mise Ã  jour de ce plugin. Veuillez rÃ©essayer plus tard.";

	/// <summary>
	/// Key: "Label.UpdateErrorTitle"
	/// English String: "Error Updating Plugin"
	/// </summary>
	public override string LabelUpdateErrorTitle => "Erreur lors de la mise Ã  jour du plugin";

	/// <summary>
	/// Key: "Label.UpdateSuccessTitle"
	/// English String: "Plugin Update"
	/// </summary>
	public override string LabelUpdateSuccessTitle => "Plugin mis Ã  jour";

	/// <summary>
	/// Key: "Label.UpdateText"
	/// English String: "Update"
	/// </summary>
	public override string LabelUpdateText => "Mise Ã  jour";

	public PluginsResources_fr_fr(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForLabelErrorBody()
	{
		return "Un problÃ¨me est survenu lors de l'installation de ce plugin. Veuillez rÃ©essayer plus tard.";
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
		return "RÃ©installer";
	}

	/// <summary>
	/// Key: "Label.SuccessBody"
	/// English String: "{item} has been successfully installed!"
	/// </summary>
	public override string LabelSuccessBody(string item)
	{
		return $"{item} a Ã©tÃ© installÃ©\u00a0!";
	}

	protected override string _GetTemplateForLabelSuccessBody()
	{
		return "{item} a Ã©tÃ© installÃ©\u00a0!";
	}

	protected override string _GetTemplateForLabelSuccessTitle()
	{
		return "Plugin installÃ©";
	}

	protected override string _GetTemplateForLabelUpdateErrorBody()
	{
		return "Un problÃ¨me est survenu lors de la mise Ã  jour de ce plugin. Veuillez rÃ©essayer plus tard.";
	}

	protected override string _GetTemplateForLabelUpdateErrorTitle()
	{
		return "Erreur lors de la mise Ã  jour du plugin";
	}

	/// <summary>
	/// Key: "Label.UpdateSuccessBody"
	/// English String: "{item} has been successfully updated! Please open a new window for the changes to take effect."
	/// </summary>
	public override string LabelUpdateSuccessBody(string item)
	{
		return $"{item} a Ã©tÃ© mis Ã  jour\u00a0! Veuillez ouvrir une nouvelle fenÃªtre pour que les changements puissent Ãªtre appliquÃ©s.";
	}

	protected override string _GetTemplateForLabelUpdateSuccessBody()
	{
		return "{item} a Ã©tÃ© mis Ã  jour\u00a0! Veuillez ouvrir une nouvelle fenÃªtre pour que les changements puissent Ãªtre appliquÃ©s.";
	}

	protected override string _GetTemplateForLabelUpdateSuccessTitle()
	{
		return "Plugin mis Ã  jour";
	}

	protected override string _GetTemplateForLabelUpdateText()
	{
		return "Mise Ã  jour";
	}
}


}
