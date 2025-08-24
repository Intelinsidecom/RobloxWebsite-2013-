namespace Roblox.TranslationResources.Feature;

/// <summary>
/// This class overrides ServerListResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class ServerListResources_fr_fr : ServerListResources_en_us, IServerListResources, ITranslationResources
{
	/// <summary>
	/// Key: "Action.ConfigureServer"
	/// Configure server
	/// English String: "Configure"
	/// </summary>
	public override string ActionConfigureServer => "Configurer";

	/// <summary>
	/// Key: "Action.LoadMore"
	/// English String: "Load More"
	/// </summary>
	public override string ActionLoadMore => "Charger plus";

	/// <summary>
	/// Key: "Heading.OtherServers"
	/// English String: "Other Servers"
	/// </summary>
	public override string HeadingOtherServers => "Autres serveurs";

	/// <summary>
	/// Key: "Heading.RunningServers"
	/// English String: "All Running Servers"
	/// </summary>
	public override string HeadingRunningServers => "Tous les serveurs en ligne";

	/// <summary>
	/// Key: "Heading.ServersMyFriendsAreIn"
	/// English String: "Servers My Friends Are In"
	/// </summary>
	public override string HeadingServersMyFriendsAreIn => "Serveurs où se trouvent mes amis";

	/// <summary>
	/// Key: "Label.Inactive"
	/// English String: "Inactive."
	/// </summary>
	public override string LabelInactive => "Inactif.";

	/// <summary>
	/// Key: "Label.InsufficientFunds"
	/// English String: "This Server has been deactivated. We were not able to process the recurring payment due to insufficient funds in your account."
	/// </summary>
	public override string LabelInsufficientFunds => "Ce serveur a été désactivé. Nous n'avons pas pu traiter le paiement récurrent car ton compte ne dispose pas des fonds suffisants.";

	/// <summary>
	/// Key: "Label.MyVipServer"
	/// English String: "My VIP Server"
	/// </summary>
	public override string LabelMyVipServer => "Mon serveur\u00a0VIP";

	/// <summary>
	/// Key: "Label.NoServersFound"
	/// No Servers Found.
	/// English String: "No Servers Found."
	/// </summary>
	public override string LabelNoServersFound => "Aucun serveur trouvé.";

	/// <summary>
	/// Key: "Label.NoVipServers"
	/// No VIP Server Instances Found.
	/// English String: "No VIP Server Instances Found."
	/// </summary>
	public override string LabelNoVipServers => "Aucune instance de serveur\u00a0VIP trouvée.";

	/// <summary>
	/// Key: "Label.PaymentCancelled"
	/// English String: "Payment Cancelled"
	/// </summary>
	public override string LabelPaymentCancelled => "Paiement annulé";

	/// <summary>
	/// Key: "Label.PlacesNotLoading"
	/// The list of places failed to load for some unknown reason.
	/// English String: "Sorry, something went wrong loading places."
	/// </summary>
	public override string LabelPlacesNotLoading => "Désolé, un problème est survenu lors du chargement des emplacements.";

	/// <summary>
	/// Key: "Label.ServerListJoin"
	/// English String: "Join"
	/// </summary>
	public override string LabelServerListJoin => "Rejoindre";

	/// <summary>
	/// Key: "Label.ServerListRenew"
	/// English String: "Renew"
	/// </summary>
	public override string LabelServerListRenew => "Renouveler";

	/// <summary>
	/// Key: "Label.ShutDownServer"
	/// User chooses to close their game server.
	/// English String: "Shut Down This Server"
	/// </summary>
	public override string LabelShutDownServer => "Fermer ce serveur";

	/// <summary>
	/// Key: "Label.SlowGame"
	/// English String: "Slow Game"
	/// </summary>
	public override string LabelSlowGame => "Serveur lent";

	public ServerListResources_fr_fr(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionConfigureServer()
	{
		return "Configurer";
	}

	protected override string _GetTemplateForActionLoadMore()
	{
		return "Charger plus";
	}

	protected override string _GetTemplateForHeadingOtherServers()
	{
		return "Autres serveurs";
	}

	protected override string _GetTemplateForHeadingRunningServers()
	{
		return "Tous les serveurs en ligne";
	}

	protected override string _GetTemplateForHeadingServersMyFriendsAreIn()
	{
		return "Serveurs où se trouvent mes amis";
	}

	/// <summary>
	/// Key: "Label.CurrentPlayerCount"
	/// English String: "{currentPlayers} of {maximumAllowedPlayers} players max"
	/// </summary>
	public override string LabelCurrentPlayerCount(string currentPlayers, string maximumAllowedPlayers)
	{
		return $"{currentPlayers} sur {maximumAllowedPlayers} joueurs max.";
	}

	protected override string _GetTemplateForLabelCurrentPlayerCount()
	{
		return "{currentPlayers} sur {maximumAllowedPlayers} joueurs max.";
	}

	protected override string _GetTemplateForLabelInactive()
	{
		return "Inactif.";
	}

	protected override string _GetTemplateForLabelInsufficientFunds()
	{
		return "Ce serveur a été désactivé. Nous n'avons pas pu traiter le paiement récurrent car ton compte ne dispose pas des fonds suffisants.";
	}

	protected override string _GetTemplateForLabelMyVipServer()
	{
		return "Mon serveur\u00a0VIP";
	}

	protected override string _GetTemplateForLabelNoServersFound()
	{
		return "Aucun serveur trouvé.";
	}

	protected override string _GetTemplateForLabelNoVipServers()
	{
		return "Aucune instance de serveur\u00a0VIP trouvée.";
	}

	protected override string _GetTemplateForLabelPaymentCancelled()
	{
		return "Paiement annulé";
	}

	protected override string _GetTemplateForLabelPlacesNotLoading()
	{
		return "Désolé, un problème est survenu lors du chargement des emplacements.";
	}

	protected override string _GetTemplateForLabelServerListJoin()
	{
		return "Rejoindre";
	}

	protected override string _GetTemplateForLabelServerListRenew()
	{
		return "Renouveler";
	}

	protected override string _GetTemplateForLabelShutDownServer()
	{
		return "Fermer ce serveur";
	}

	protected override string _GetTemplateForLabelSlowGame()
	{
		return "Serveur lent";
	}
}
