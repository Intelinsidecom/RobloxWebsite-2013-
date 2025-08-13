namespace Roblox.TranslationResources.Feature;

/// <summary>
/// This class overrides GameContextMenuResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class GameContextMenuResources_fr_fr : GameContextMenuResources_en_us, IGameContextMenuResources, ITranslationResources
{
	/// <summary>
	/// Key: "ActionDialogAccept"
	/// English String: "Yes"
	/// </summary>
	public override string ActionDialogAccept => "Oui";

	/// <summary>
	/// Key: "ActionDialogDecline"
	/// English String: "No"
	/// </summary>
	public override string ActionDialogDecline => "Non";

	/// <summary>
	/// Key: "ActionDialogOk"
	/// English String: "OK"
	/// </summary>
	public override string ActionDialogOk => "OK";

	/// <summary>
	/// Key: "Label.ConfigureLocalization"
	/// The label in context menu that will direct game owner to configure localization page
	/// English String: "Configure Localization"
	/// </summary>
	public override string LabelConfigureLocalization => "Configurer la localisation";

	/// <summary>
	/// Key: "Label.TranslateThisGame"
	/// The label in context menu that will direct translators for a game to crowdsource translation page
	/// English String: "Translate this Game"
	/// </summary>
	public override string LabelTranslateThisGame => "Traduire ce jeu";

	/// <summary>
	/// Key: "LabelAddToProfile"
	/// English String: "Add to profile"
	/// </summary>
	public override string LabelAddToProfile => "Ajouter au profil";

	/// <summary>
	/// Key: "LabelConfigureGame"
	/// English String: "Configure this Game"
	/// </summary>
	public override string LabelConfigureGame => "Configurer ce jeu";

	/// <summary>
	/// Key: "LabelConfigurePlace"
	/// English String: "Configure this Place"
	/// </summary>
	public override string LabelConfigurePlace => "Configurer cet emplacement";

	/// <summary>
	/// Key: "LabelDeveloperStats"
	/// English String: "Developer Stats"
	/// </summary>
	public override string LabelDeveloperStats => "Statistiques de développeur";

	/// <summary>
	/// Key: "LabelEdit"
	/// English String: "Edit"
	/// </summary>
	public override string LabelEdit => "Modifier";

	/// <summary>
	/// Key: "LabelRemoveFromProfile"
	/// English String: "Remove from Profile"
	/// </summary>
	public override string LabelRemoveFromProfile => "Retirer du profil";

	/// <summary>
	/// Key: "LabelServerError"
	/// English String: "An Error Occured"
	/// </summary>
	public override string LabelServerError => "Une erreur est survenue";

	/// <summary>
	/// Key: "LabelShutDownAllServers"
	/// English String: "Shut Down All Servers"
	/// </summary>
	public override string LabelShutDownAllServers => "Fermer tous les serveurs";

	/// <summary>
	/// Key: "LabelShutDownServersWarning"
	/// English String: "Are you sure you want to shut down all servers for this place?"
	/// </summary>
	public override string LabelShutDownServersWarning => "Voulez-vous vraiment fermer tous les serveurs pour cet emplacement\u00a0?";

	/// <summary>
	/// Key: "MessageServerShutDownError"
	/// English String: "Could not shut down servers."
	/// </summary>
	public override string MessageServerShutDownError => "Fermeture des serveurs impossible.";

	public GameContextMenuResources_fr_fr(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionDialogAccept()
	{
		return "Oui";
	}

	protected override string _GetTemplateForActionDialogDecline()
	{
		return "Non";
	}

	protected override string _GetTemplateForActionDialogOk()
	{
		return "OK";
	}

	protected override string _GetTemplateForLabelConfigureLocalization()
	{
		return "Configurer la localisation";
	}

	protected override string _GetTemplateForLabelTranslateThisGame()
	{
		return "Traduire ce jeu";
	}

	protected override string _GetTemplateForLabelAddToProfile()
	{
		return "Ajouter au profil";
	}

	protected override string _GetTemplateForLabelConfigureGame()
	{
		return "Configurer ce jeu";
	}

	protected override string _GetTemplateForLabelConfigurePlace()
	{
		return "Configurer cet emplacement";
	}

	protected override string _GetTemplateForLabelDeveloperStats()
	{
		return "Statistiques de développeur";
	}

	protected override string _GetTemplateForLabelEdit()
	{
		return "Modifier";
	}

	protected override string _GetTemplateForLabelRemoveFromProfile()
	{
		return "Retirer du profil";
	}

	protected override string _GetTemplateForLabelServerError()
	{
		return "Une erreur est survenue";
	}

	protected override string _GetTemplateForLabelShutDownAllServers()
	{
		return "Fermer tous les serveurs";
	}

	protected override string _GetTemplateForLabelShutDownServersWarning()
	{
		return "Voulez-vous vraiment fermer tous les serveurs pour cet emplacement\u00a0?";
	}

	protected override string _GetTemplateForMessageServerShutDownError()
	{
		return "Fermeture des serveurs impossible.";
	}
}
