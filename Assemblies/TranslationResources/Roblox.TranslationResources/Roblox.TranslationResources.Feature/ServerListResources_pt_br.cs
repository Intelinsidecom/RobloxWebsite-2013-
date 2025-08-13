namespace Roblox.TranslationResources.Feature;

/// <summary>
/// This class overrides ServerListResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class ServerListResources_pt_br : ServerListResources_en_us, IServerListResources, ITranslationResources
{
	/// <summary>
	/// Key: "Action.ConfigureServer"
	/// Configure server
	/// English String: "Configure"
	/// </summary>
	public override string ActionConfigureServer => "Configurar";

	/// <summary>
	/// Key: "Action.LoadMore"
	/// English String: "Load More"
	/// </summary>
	public override string ActionLoadMore => "Carregar mais";

	/// <summary>
	/// Key: "Heading.OtherServers"
	/// English String: "Other Servers"
	/// </summary>
	public override string HeadingOtherServers => "Outros servidores";

	/// <summary>
	/// Key: "Heading.RunningServers"
	/// English String: "All Running Servers"
	/// </summary>
	public override string HeadingRunningServers => "Todos os servidores rodando";

	/// <summary>
	/// Key: "Heading.ServersMyFriendsAreIn"
	/// English String: "Servers My Friends Are In"
	/// </summary>
	public override string HeadingServersMyFriendsAreIn => "Servidores onde meus amigos estão";

	/// <summary>
	/// Key: "Label.Inactive"
	/// English String: "Inactive."
	/// </summary>
	public override string LabelInactive => "Inativo";

	/// <summary>
	/// Key: "Label.InsufficientFunds"
	/// English String: "This Server has been deactivated. We were not able to process the recurring payment due to insufficient funds in your account."
	/// </summary>
	public override string LabelInsufficientFunds => "Este servidor foi desativado. Não conseguimos processar o pagamento recorrente devido à falta de fundos na sua conta.";

	/// <summary>
	/// Key: "Label.MyVipServer"
	/// English String: "My VIP Server"
	/// </summary>
	public override string LabelMyVipServer => "Meu servidor VIP";

	/// <summary>
	/// Key: "Label.NoServersFound"
	/// No Servers Found.
	/// English String: "No Servers Found."
	/// </summary>
	public override string LabelNoServersFound => "Nenhum servidor VIP encontrado.";

	/// <summary>
	/// Key: "Label.NoVipServers"
	/// No VIP Server Instances Found.
	/// English String: "No VIP Server Instances Found."
	/// </summary>
	public override string LabelNoVipServers => "Nenhuma instância de servidor VIP encontrada.";

	/// <summary>
	/// Key: "Label.PaymentCancelled"
	/// English String: "Payment Cancelled"
	/// </summary>
	public override string LabelPaymentCancelled => "Pagamento cancelado";

	/// <summary>
	/// Key: "Label.PlacesNotLoading"
	/// The list of places failed to load for some unknown reason.
	/// English String: "Sorry, something went wrong loading places."
	/// </summary>
	public override string LabelPlacesNotLoading => "Ops! Algo deu errado ao carregar os locais.";

	/// <summary>
	/// Key: "Label.ServerListJoin"
	/// English String: "Join"
	/// </summary>
	public override string LabelServerListJoin => "Entrar";

	/// <summary>
	/// Key: "Label.ServerListRenew"
	/// English String: "Renew"
	/// </summary>
	public override string LabelServerListRenew => "Renovar";

	/// <summary>
	/// Key: "Label.ShutDownServer"
	/// User chooses to close their game server.
	/// English String: "Shut Down This Server"
	/// </summary>
	public override string LabelShutDownServer => "Desligar este servidor";

	/// <summary>
	/// Key: "Label.SlowGame"
	/// English String: "Slow Game"
	/// </summary>
	public override string LabelSlowGame => "Desacelerar jogo";

	public ServerListResources_pt_br(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionConfigureServer()
	{
		return "Configurar";
	}

	protected override string _GetTemplateForActionLoadMore()
	{
		return "Carregar mais";
	}

	protected override string _GetTemplateForHeadingOtherServers()
	{
		return "Outros servidores";
	}

	protected override string _GetTemplateForHeadingRunningServers()
	{
		return "Todos os servidores rodando";
	}

	protected override string _GetTemplateForHeadingServersMyFriendsAreIn()
	{
		return "Servidores onde meus amigos estão";
	}

	/// <summary>
	/// Key: "Label.CurrentPlayerCount"
	/// English String: "{currentPlayers} of {maximumAllowedPlayers} players max"
	/// </summary>
	public override string LabelCurrentPlayerCount(string currentPlayers, string maximumAllowedPlayers)
	{
		return $"{currentPlayers} de um máximo de {maximumAllowedPlayers} jogadores";
	}

	protected override string _GetTemplateForLabelCurrentPlayerCount()
	{
		return "{currentPlayers} de um máximo de {maximumAllowedPlayers} jogadores";
	}

	protected override string _GetTemplateForLabelInactive()
	{
		return "Inativo";
	}

	protected override string _GetTemplateForLabelInsufficientFunds()
	{
		return "Este servidor foi desativado. Não conseguimos processar o pagamento recorrente devido à falta de fundos na sua conta.";
	}

	protected override string _GetTemplateForLabelMyVipServer()
	{
		return "Meu servidor VIP";
	}

	protected override string _GetTemplateForLabelNoServersFound()
	{
		return "Nenhum servidor VIP encontrado.";
	}

	protected override string _GetTemplateForLabelNoVipServers()
	{
		return "Nenhuma instância de servidor VIP encontrada.";
	}

	protected override string _GetTemplateForLabelPaymentCancelled()
	{
		return "Pagamento cancelado";
	}

	protected override string _GetTemplateForLabelPlacesNotLoading()
	{
		return "Ops! Algo deu errado ao carregar os locais.";
	}

	protected override string _GetTemplateForLabelServerListJoin()
	{
		return "Entrar";
	}

	protected override string _GetTemplateForLabelServerListRenew()
	{
		return "Renovar";
	}

	protected override string _GetTemplateForLabelShutDownServer()
	{
		return "Desligar este servidor";
	}

	protected override string _GetTemplateForLabelSlowGame()
	{
		return "Desacelerar jogo";
	}
}
