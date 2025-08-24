namespace Roblox.TranslationResources.Feature;

/// <summary>
/// This class overrides PluginsResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class PluginsResources_de_de : PluginsResources_en_us, IPluginsResources, ITranslationResources
{
	/// <summary>
	/// Key: "Label.ErrorBody"
	/// English String: "There was a problem installing this plugin. Please try again later."
	/// </summary>
	public override string LabelErrorBody => "Beim Installieren dieses Plug-ins ist ein Problem aufgetreten. Bitte versuche es später erneut.";

	/// <summary>
	/// Key: "Label.ErrorTitle"
	/// English String: "Error Installing Plugin"
	/// </summary>
	public override string LabelErrorTitle => "Fehler beim Installieren des Plug-ins";

	/// <summary>
	/// Key: "Label.Ok"
	/// English String: "OK"
	/// </summary>
	public override string LabelOk => "Okay";

	/// <summary>
	/// Key: "Label.Reinstall"
	/// English String: "Reinstall"
	/// </summary>
	public override string LabelReinstall => "Neu installieren";

	/// <summary>
	/// Key: "Label.SuccessTitle"
	/// English String: "Plugin Installed"
	/// </summary>
	public override string LabelSuccessTitle => "Plug-in installiert";

	/// <summary>
	/// Key: "Label.UpdateErrorBody"
	/// English String: "There was a problem updating this plugin. Please try again later."
	/// </summary>
	public override string LabelUpdateErrorBody => "Beim Aktualisieren dieses Plug-ins ist ein Problem aufgetreten. Bitte versuche es später erneut.";

	/// <summary>
	/// Key: "Label.UpdateErrorTitle"
	/// English String: "Error Updating Plugin"
	/// </summary>
	public override string LabelUpdateErrorTitle => "Fehler beim Aktualisieren des Plug-ins";

	/// <summary>
	/// Key: "Label.UpdateSuccessTitle"
	/// English String: "Plugin Update"
	/// </summary>
	public override string LabelUpdateSuccessTitle => "Plug-in-Aktualisierung";

	/// <summary>
	/// Key: "Label.UpdateText"
	/// English String: "Update"
	/// </summary>
	public override string LabelUpdateText => "Aktualisieren";

	public PluginsResources_de_de(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForLabelErrorBody()
	{
		return "Beim Installieren dieses Plug-ins ist ein Problem aufgetreten. Bitte versuche es später erneut.";
	}

	protected override string _GetTemplateForLabelErrorTitle()
	{
		return "Fehler beim Installieren des Plug-ins";
	}

	protected override string _GetTemplateForLabelOk()
	{
		return "Okay";
	}

	protected override string _GetTemplateForLabelReinstall()
	{
		return "Neu installieren";
	}

	/// <summary>
	/// Key: "Label.SuccessBody"
	/// English String: "{item} has been successfully installed!"
	/// </summary>
	public override string LabelSuccessBody(string item)
	{
		return $"{item} wurde erfolgreich installiert!";
	}

	protected override string _GetTemplateForLabelSuccessBody()
	{
		return "{item} wurde erfolgreich installiert!";
	}

	protected override string _GetTemplateForLabelSuccessTitle()
	{
		return "Plug-in installiert";
	}

	protected override string _GetTemplateForLabelUpdateErrorBody()
	{
		return "Beim Aktualisieren dieses Plug-ins ist ein Problem aufgetreten. Bitte versuche es später erneut.";
	}

	protected override string _GetTemplateForLabelUpdateErrorTitle()
	{
		return "Fehler beim Aktualisieren des Plug-ins";
	}

	/// <summary>
	/// Key: "Label.UpdateSuccessBody"
	/// English String: "{item} has been successfully updated! Please open a new window for the changes to take effect."
	/// </summary>
	public override string LabelUpdateSuccessBody(string item)
	{
		return $"{item} wurde erfolgreich aktualisiert! Bitte öffne ein neues Fenster, damit die Änderungen wirksam werden.";
	}

	protected override string _GetTemplateForLabelUpdateSuccessBody()
	{
		return "{item} wurde erfolgreich aktualisiert! Bitte öffne ein neues Fenster, damit die Änderungen wirksam werden.";
	}

	protected override string _GetTemplateForLabelUpdateSuccessTitle()
	{
		return "Plug-in-Aktualisierung";
	}

	protected override string _GetTemplateForLabelUpdateText()
	{
		return "Aktualisieren";
	}
}
