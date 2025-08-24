namespace Roblox.TranslationResources.Feature;

/// <summary>
/// This class overrides GameContextMenuResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class GameContextMenuResources_es_es : GameContextMenuResources_en_us, IGameContextMenuResources, ITranslationResources
{
	/// <summary>
	/// Key: "ActionDialogAccept"
	/// English String: "Yes"
	/// </summary>
	public override string ActionDialogAccept => "Sí";

	/// <summary>
	/// Key: "ActionDialogDecline"
	/// English String: "No"
	/// </summary>
	public override string ActionDialogDecline => "No";

	/// <summary>
	/// Key: "ActionDialogOk"
	/// English String: "OK"
	/// </summary>
	public override string ActionDialogOk => "Aceptar";

	/// <summary>
	/// Key: "Label.ConfigureLocalization"
	/// The label in context menu that will direct game owner to configure localization page
	/// English String: "Configure Localization"
	/// </summary>
	public override string LabelConfigureLocalization => "Configurar localización";

	/// <summary>
	/// Key: "Label.TranslateThisGame"
	/// The label in context menu that will direct translators for a game to crowdsource translation page
	/// English String: "Translate this Game"
	/// </summary>
	public override string LabelTranslateThisGame => "Traducir este juego";

	/// <summary>
	/// Key: "LabelAddToProfile"
	/// English String: "Add to profile"
	/// </summary>
	public override string LabelAddToProfile => "Añadir al perfil";

	/// <summary>
	/// Key: "LabelConfigureGame"
	/// English String: "Configure this Game"
	/// </summary>
	public override string LabelConfigureGame => "Configurar el juego";

	/// <summary>
	/// Key: "LabelConfigurePlace"
	/// English String: "Configure this Place"
	/// </summary>
	public override string LabelConfigurePlace => "Configurar el lugar";

	/// <summary>
	/// Key: "LabelDeveloperStats"
	/// English String: "Developer Stats"
	/// </summary>
	public override string LabelDeveloperStats => "Estad. del desarrollador";

	/// <summary>
	/// Key: "LabelEdit"
	/// English String: "Edit"
	/// </summary>
	public override string LabelEdit => "Editar";

	/// <summary>
	/// Key: "LabelRemoveFromProfile"
	/// English String: "Remove from Profile"
	/// </summary>
	public override string LabelRemoveFromProfile => "Eliminar del perfil";

	/// <summary>
	/// Key: "LabelServerError"
	/// English String: "An Error Occured"
	/// </summary>
	public override string LabelServerError => "Se ha producido un error";

	/// <summary>
	/// Key: "LabelShutDownAllServers"
	/// English String: "Shut Down All Servers"
	/// </summary>
	public override string LabelShutDownAllServers => "Cerrar servidores";

	/// <summary>
	/// Key: "LabelShutDownServersWarning"
	/// English String: "Are you sure you want to shut down all servers for this place?"
	/// </summary>
	public override string LabelShutDownServersWarning => "¿Seguro que quieres cerrar todos los servidores de este lugar?";

	/// <summary>
	/// Key: "MessageServerShutDownError"
	/// English String: "Could not shut down servers."
	/// </summary>
	public override string MessageServerShutDownError => "No se han podido cerrar los servidores.";

	public GameContextMenuResources_es_es(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionDialogAccept()
	{
		return "Sí";
	}

	protected override string _GetTemplateForActionDialogDecline()
	{
		return "No";
	}

	protected override string _GetTemplateForActionDialogOk()
	{
		return "Aceptar";
	}

	protected override string _GetTemplateForLabelConfigureLocalization()
	{
		return "Configurar localización";
	}

	protected override string _GetTemplateForLabelTranslateThisGame()
	{
		return "Traducir este juego";
	}

	protected override string _GetTemplateForLabelAddToProfile()
	{
		return "Añadir al perfil";
	}

	protected override string _GetTemplateForLabelConfigureGame()
	{
		return "Configurar el juego";
	}

	protected override string _GetTemplateForLabelConfigurePlace()
	{
		return "Configurar el lugar";
	}

	protected override string _GetTemplateForLabelDeveloperStats()
	{
		return "Estad. del desarrollador";
	}

	protected override string _GetTemplateForLabelEdit()
	{
		return "Editar";
	}

	protected override string _GetTemplateForLabelRemoveFromProfile()
	{
		return "Eliminar del perfil";
	}

	protected override string _GetTemplateForLabelServerError()
	{
		return "Se ha producido un error";
	}

	protected override string _GetTemplateForLabelShutDownAllServers()
	{
		return "Cerrar servidores";
	}

	protected override string _GetTemplateForLabelShutDownServersWarning()
	{
		return "¿Seguro que quieres cerrar todos los servidores de este lugar?";
	}

	protected override string _GetTemplateForMessageServerShutDownError()
	{
		return "No se han podido cerrar los servidores.";
	}
}
