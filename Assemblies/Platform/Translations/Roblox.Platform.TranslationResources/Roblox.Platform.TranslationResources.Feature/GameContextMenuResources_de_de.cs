namespace Roblox.TranslationResources.Feature;

/// <summary>
/// This class overrides GameContextMenuResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class GameContextMenuResources_de_de : GameContextMenuResources_en_us, IGameContextMenuResources, ITranslationResources
{
	/// <summary>
	/// Key: "ActionDialogAccept"
	/// English String: "Yes"
	/// </summary>
	public override string ActionDialogAccept => "Ja";

	/// <summary>
	/// Key: "ActionDialogDecline"
	/// English String: "No"
	/// </summary>
	public override string ActionDialogDecline => "Nein";

	/// <summary>
	/// Key: "ActionDialogOk"
	/// English String: "OK"
	/// </summary>
	public override string ActionDialogOk => "Okay";

	/// <summary>
	/// Key: "Label.ConfigureLocalization"
	/// The label in context menu that will direct game owner to configure localization page
	/// English String: "Configure Localization"
	/// </summary>
	public override string LabelConfigureLocalization => "Lokalisierung konfigurieren";

	/// <summary>
	/// Key: "Label.TranslateThisGame"
	/// The label in context menu that will direct translators for a game to crowdsource translation page
	/// English String: "Translate this Game"
	/// </summary>
	public override string LabelTranslateThisGame => "Übersetze dieses Spiel";

	/// <summary>
	/// Key: "LabelAddToProfile"
	/// English String: "Add to profile"
	/// </summary>
	public override string LabelAddToProfile => "Zu Profil hinzufügen";

	/// <summary>
	/// Key: "LabelConfigureGame"
	/// English String: "Configure this Game"
	/// </summary>
	public override string LabelConfigureGame => "Dieses Spiel konfigurieren";

	/// <summary>
	/// Key: "LabelConfigurePlace"
	/// English String: "Configure this Place"
	/// </summary>
	public override string LabelConfigurePlace => "Diesen Ort konfigurieren";

	/// <summary>
	/// Key: "LabelDeveloperStats"
	/// English String: "Developer Stats"
	/// </summary>
	public override string LabelDeveloperStats => "Entwicklerstatistiken";

	/// <summary>
	/// Key: "LabelEdit"
	/// English String: "Edit"
	/// </summary>
	public override string LabelEdit => "Bearbeiten";

	/// <summary>
	/// Key: "LabelRemoveFromProfile"
	/// English String: "Remove from Profile"
	/// </summary>
	public override string LabelRemoveFromProfile => "Von Profil entfernen";

	/// <summary>
	/// Key: "LabelServerError"
	/// English String: "An Error Occured"
	/// </summary>
	public override string LabelServerError => "Ein Fehler ist aufgetreten.";

	/// <summary>
	/// Key: "LabelShutDownAllServers"
	/// English String: "Shut Down All Servers"
	/// </summary>
	public override string LabelShutDownAllServers => "Alle Server abschalten";

	/// <summary>
	/// Key: "LabelShutDownServersWarning"
	/// English String: "Are you sure you want to shut down all servers for this place?"
	/// </summary>
	public override string LabelShutDownServersWarning => "Möchtest du wirklich alle Server für diesen Ort abschalten?";

	/// <summary>
	/// Key: "MessageServerShutDownError"
	/// English String: "Could not shut down servers."
	/// </summary>
	public override string MessageServerShutDownError => "Server konnten nicht abgeschaltet werden.";

	public GameContextMenuResources_de_de(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionDialogAccept()
	{
		return "Ja";
	}

	protected override string _GetTemplateForActionDialogDecline()
	{
		return "Nein";
	}

	protected override string _GetTemplateForActionDialogOk()
	{
		return "Okay";
	}

	protected override string _GetTemplateForLabelConfigureLocalization()
	{
		return "Lokalisierung konfigurieren";
	}

	protected override string _GetTemplateForLabelTranslateThisGame()
	{
		return "Übersetze dieses Spiel";
	}

	protected override string _GetTemplateForLabelAddToProfile()
	{
		return "Zu Profil hinzufügen";
	}

	protected override string _GetTemplateForLabelConfigureGame()
	{
		return "Dieses Spiel konfigurieren";
	}

	protected override string _GetTemplateForLabelConfigurePlace()
	{
		return "Diesen Ort konfigurieren";
	}

	protected override string _GetTemplateForLabelDeveloperStats()
	{
		return "Entwicklerstatistiken";
	}

	protected override string _GetTemplateForLabelEdit()
	{
		return "Bearbeiten";
	}

	protected override string _GetTemplateForLabelRemoveFromProfile()
	{
		return "Von Profil entfernen";
	}

	protected override string _GetTemplateForLabelServerError()
	{
		return "Ein Fehler ist aufgetreten.";
	}

	protected override string _GetTemplateForLabelShutDownAllServers()
	{
		return "Alle Server abschalten";
	}

	protected override string _GetTemplateForLabelShutDownServersWarning()
	{
		return "Möchtest du wirklich alle Server für diesen Ort abschalten?";
	}

	protected override string _GetTemplateForMessageServerShutDownError()
	{
		return "Server konnten nicht abgeschaltet werden.";
	}
}
