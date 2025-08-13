namespace Roblox.TranslationResources.Feature;

/// <summary>
/// This class overrides ServerListResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class ServerListResources_es_es : ServerListResources_en_us, IServerListResources, ITranslationResources
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
	public override string ActionLoadMore => "Cargar más";

	/// <summary>
	/// Key: "Heading.OtherServers"
	/// English String: "Other Servers"
	/// </summary>
	public override string HeadingOtherServers => "Otros servidores";

	/// <summary>
	/// Key: "Heading.RunningServers"
	/// English String: "All Running Servers"
	/// </summary>
	public override string HeadingRunningServers => "Todos los servidores operativos";

	/// <summary>
	/// Key: "Heading.ServersMyFriendsAreIn"
	/// English String: "Servers My Friends Are In"
	/// </summary>
	public override string HeadingServersMyFriendsAreIn => "Servidores en los que están mis amigos";

	/// <summary>
	/// Key: "Label.Inactive"
	/// English String: "Inactive."
	/// </summary>
	public override string LabelInactive => "Inactivo.";

	/// <summary>
	/// Key: "Label.InsufficientFunds"
	/// English String: "This Server has been deactivated. We were not able to process the recurring payment due to insufficient funds in your account."
	/// </summary>
	public override string LabelInsufficientFunds => "Este servidor ha sido desactivado. No hemos podido procesar el pago recurrente porque tu cuenta no tiene fondos suficientes.";

	/// <summary>
	/// Key: "Label.MyVipServer"
	/// English String: "My VIP Server"
	/// </summary>
	public override string LabelMyVipServer => "Mi servidor VIP";

	/// <summary>
	/// Key: "Label.NoServersFound"
	/// No Servers Found.
	/// English String: "No Servers Found."
	/// </summary>
	public override string LabelNoServersFound => "No se han encontrado servidores.";

	/// <summary>
	/// Key: "Label.NoVipServers"
	/// No VIP Server Instances Found.
	/// English String: "No VIP Server Instances Found."
	/// </summary>
	public override string LabelNoVipServers => "No se han encontrado instancias del servidor VIP.";

	/// <summary>
	/// Key: "Label.PaymentCancelled"
	/// English String: "Payment Cancelled"
	/// </summary>
	public override string LabelPaymentCancelled => "Pago cancelado";

	/// <summary>
	/// Key: "Label.PlacesNotLoading"
	/// The list of places failed to load for some unknown reason.
	/// English String: "Sorry, something went wrong loading places."
	/// </summary>
	public override string LabelPlacesNotLoading => "Lo sentimos, algo ha ido mal al cargar los lugares.";

	/// <summary>
	/// Key: "Label.ServerListJoin"
	/// English String: "Join"
	/// </summary>
	public override string LabelServerListJoin => "Unirse";

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
	public override string LabelShutDownServer => "Cerrar este servidor";

	/// <summary>
	/// Key: "Label.SlowGame"
	/// English String: "Slow Game"
	/// </summary>
	public override string LabelSlowGame => "Juego lento";

	public ServerListResources_es_es(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionConfigureServer()
	{
		return "Configurar";
	}

	protected override string _GetTemplateForActionLoadMore()
	{
		return "Cargar más";
	}

	protected override string _GetTemplateForHeadingOtherServers()
	{
		return "Otros servidores";
	}

	protected override string _GetTemplateForHeadingRunningServers()
	{
		return "Todos los servidores operativos";
	}

	protected override string _GetTemplateForHeadingServersMyFriendsAreIn()
	{
		return "Servidores en los que están mis amigos";
	}

	/// <summary>
	/// Key: "Label.CurrentPlayerCount"
	/// English String: "{currentPlayers} of {maximumAllowedPlayers} players max"
	/// </summary>
	public override string LabelCurrentPlayerCount(string currentPlayers, string maximumAllowedPlayers)
	{
		return $"{currentPlayers} de un máx. de {maximumAllowedPlayers} jugadores";
	}

	protected override string _GetTemplateForLabelCurrentPlayerCount()
	{
		return "{currentPlayers} de un máx. de {maximumAllowedPlayers} jugadores";
	}

	protected override string _GetTemplateForLabelInactive()
	{
		return "Inactivo.";
	}

	protected override string _GetTemplateForLabelInsufficientFunds()
	{
		return "Este servidor ha sido desactivado. No hemos podido procesar el pago recurrente porque tu cuenta no tiene fondos suficientes.";
	}

	protected override string _GetTemplateForLabelMyVipServer()
	{
		return "Mi servidor VIP";
	}

	protected override string _GetTemplateForLabelNoServersFound()
	{
		return "No se han encontrado servidores.";
	}

	protected override string _GetTemplateForLabelNoVipServers()
	{
		return "No se han encontrado instancias del servidor VIP.";
	}

	protected override string _GetTemplateForLabelPaymentCancelled()
	{
		return "Pago cancelado";
	}

	protected override string _GetTemplateForLabelPlacesNotLoading()
	{
		return "Lo sentimos, algo ha ido mal al cargar los lugares.";
	}

	protected override string _GetTemplateForLabelServerListJoin()
	{
		return "Unirse";
	}

	protected override string _GetTemplateForLabelServerListRenew()
	{
		return "Renovar";
	}

	protected override string _GetTemplateForLabelShutDownServer()
	{
		return "Cerrar este servidor";
	}

	protected override string _GetTemplateForLabelSlowGame()
	{
		return "Juego lento";
	}
}
