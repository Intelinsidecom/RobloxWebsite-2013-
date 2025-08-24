namespace Roblox.TranslationResources.Feature;

/// <summary>
/// This class overrides GameContextMenuResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class GameContextMenuResources_pt_br : GameContextMenuResources_en_us, IGameContextMenuResources, ITranslationResources
{
	/// <summary>
	/// Key: "ActionDialogAccept"
	/// English String: "Yes"
	/// </summary>
	public override string ActionDialogAccept => "Sim";

	/// <summary>
	/// Key: "ActionDialogDecline"
	/// English String: "No"
	/// </summary>
	public override string ActionDialogDecline => "Não";

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
	public override string LabelConfigureLocalization => "Configurar localização";

	/// <summary>
	/// Key: "Label.TranslateThisGame"
	/// The label in context menu that will direct translators for a game to crowdsource translation page
	/// English String: "Translate this Game"
	/// </summary>
	public override string LabelTranslateThisGame => "Traduzir esse jogo";

	/// <summary>
	/// Key: "LabelAddToProfile"
	/// English String: "Add to profile"
	/// </summary>
	public override string LabelAddToProfile => "Adicionar ao perfil";

	/// <summary>
	/// Key: "LabelConfigureGame"
	/// English String: "Configure this Game"
	/// </summary>
	public override string LabelConfigureGame => "Configurar este jogo";

	/// <summary>
	/// Key: "LabelConfigurePlace"
	/// English String: "Configure this Place"
	/// </summary>
	public override string LabelConfigurePlace => "Configurar este local";

	/// <summary>
	/// Key: "LabelDeveloperStats"
	/// English String: "Developer Stats"
	/// </summary>
	public override string LabelDeveloperStats => "Estatísticas do desenvolvedor";

	/// <summary>
	/// Key: "LabelEdit"
	/// English String: "Edit"
	/// </summary>
	public override string LabelEdit => "Editar";

	/// <summary>
	/// Key: "LabelRemoveFromProfile"
	/// English String: "Remove from Profile"
	/// </summary>
	public override string LabelRemoveFromProfile => "Remover do perfil";

	/// <summary>
	/// Key: "LabelServerError"
	/// English String: "An Error Occured"
	/// </summary>
	public override string LabelServerError => "Ocorreu um erro";

	/// <summary>
	/// Key: "LabelShutDownAllServers"
	/// English String: "Shut Down All Servers"
	/// </summary>
	public override string LabelShutDownAllServers => "Desligar todos os servidores";

	/// <summary>
	/// Key: "LabelShutDownServersWarning"
	/// English String: "Are you sure you want to shut down all servers for this place?"
	/// </summary>
	public override string LabelShutDownServersWarning => "Quer mesmo desligar todos os servidores deste local?";

	/// <summary>
	/// Key: "MessageServerShutDownError"
	/// English String: "Could not shut down servers."
	/// </summary>
	public override string MessageServerShutDownError => "Não foi possível desligar os servidores.";

	public GameContextMenuResources_pt_br(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionDialogAccept()
	{
		return "Sim";
	}

	protected override string _GetTemplateForActionDialogDecline()
	{
		return "Não";
	}

	protected override string _GetTemplateForActionDialogOk()
	{
		return "OK";
	}

	protected override string _GetTemplateForLabelConfigureLocalization()
	{
		return "Configurar localização";
	}

	protected override string _GetTemplateForLabelTranslateThisGame()
	{
		return "Traduzir esse jogo";
	}

	protected override string _GetTemplateForLabelAddToProfile()
	{
		return "Adicionar ao perfil";
	}

	protected override string _GetTemplateForLabelConfigureGame()
	{
		return "Configurar este jogo";
	}

	protected override string _GetTemplateForLabelConfigurePlace()
	{
		return "Configurar este local";
	}

	protected override string _GetTemplateForLabelDeveloperStats()
	{
		return "Estatísticas do desenvolvedor";
	}

	protected override string _GetTemplateForLabelEdit()
	{
		return "Editar";
	}

	protected override string _GetTemplateForLabelRemoveFromProfile()
	{
		return "Remover do perfil";
	}

	protected override string _GetTemplateForLabelServerError()
	{
		return "Ocorreu um erro";
	}

	protected override string _GetTemplateForLabelShutDownAllServers()
	{
		return "Desligar todos os servidores";
	}

	protected override string _GetTemplateForLabelShutDownServersWarning()
	{
		return "Quer mesmo desligar todos os servidores deste local?";
	}

	protected override string _GetTemplateForMessageServerShutDownError()
	{
		return "Não foi possível desligar os servidores.";
	}
}
