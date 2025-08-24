namespace Roblox.TranslationResources.Feature;

/// <summary>
/// This class overrides ServerListResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class ServerListResources_de_de : ServerListResources_en_us, IServerListResources, ITranslationResources
{
	/// <summary>
	/// Key: "Action.ConfigureServer"
	/// Configure server
	/// English String: "Configure"
	/// </summary>
	public override string ActionConfigureServer => "Konfigurieren";

	/// <summary>
	/// Key: "Action.LoadMore"
	/// English String: "Load More"
	/// </summary>
	public override string ActionLoadMore => "Mehr laden";

	/// <summary>
	/// Key: "Heading.OtherServers"
	/// English String: "Other Servers"
	/// </summary>
	public override string HeadingOtherServers => "Andere Server";

	/// <summary>
	/// Key: "Heading.RunningServers"
	/// English String: "All Running Servers"
	/// </summary>
	public override string HeadingRunningServers => "Alle laufenden Server";

	/// <summary>
	/// Key: "Heading.ServersMyFriendsAreIn"
	/// English String: "Servers My Friends Are In"
	/// </summary>
	public override string HeadingServersMyFriendsAreIn => "Server, auf denen meine Freunde sind";

	/// <summary>
	/// Key: "Label.Inactive"
	/// English String: "Inactive."
	/// </summary>
	public override string LabelInactive => "Inaktiv.";

	/// <summary>
	/// Key: "Label.InsufficientFunds"
	/// English String: "This Server has been deactivated. We were not able to process the recurring payment due to insufficient funds in your account."
	/// </summary>
	public override string LabelInsufficientFunds => "Dieser Server wurde deaktiviert. Wir konnten die wiederkehrende Bezahlung nicht bearbeiten, da du nicht genügend Guthaben auf deinem Konto hast.";

	/// <summary>
	/// Key: "Label.MyVipServer"
	/// English String: "My VIP Server"
	/// </summary>
	public override string LabelMyVipServer => "Mein VIP-Server";

	/// <summary>
	/// Key: "Label.NoServersFound"
	/// No Servers Found.
	/// English String: "No Servers Found."
	/// </summary>
	public override string LabelNoServersFound => "Keine Server gefunden.";

	/// <summary>
	/// Key: "Label.NoVipServers"
	/// No VIP Server Instances Found.
	/// English String: "No VIP Server Instances Found."
	/// </summary>
	public override string LabelNoVipServers => "Keine VIP-Serverinstanzen gefunden.";

	/// <summary>
	/// Key: "Label.PaymentCancelled"
	/// English String: "Payment Cancelled"
	/// </summary>
	public override string LabelPaymentCancelled => "Bezahlung abgebrochen";

	/// <summary>
	/// Key: "Label.PlacesNotLoading"
	/// The list of places failed to load for some unknown reason.
	/// English String: "Sorry, something went wrong loading places."
	/// </summary>
	public override string LabelPlacesNotLoading => "Beim Laden der Orte ist leider ein Problem aufgetreten.";

	/// <summary>
	/// Key: "Label.ServerListJoin"
	/// English String: "Join"
	/// </summary>
	public override string LabelServerListJoin => "Beitreten";

	/// <summary>
	/// Key: "Label.ServerListRenew"
	/// English String: "Renew"
	/// </summary>
	public override string LabelServerListRenew => "Verlängern";

	/// <summary>
	/// Key: "Label.ShutDownServer"
	/// User chooses to close their game server.
	/// English String: "Shut Down This Server"
	/// </summary>
	public override string LabelShutDownServer => "Diesen Server abschalten";

	/// <summary>
	/// Key: "Label.SlowGame"
	/// English String: "Slow Game"
	/// </summary>
	public override string LabelSlowGame => "Langsames Spiel";

	public ServerListResources_de_de(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionConfigureServer()
	{
		return "Konfigurieren";
	}

	protected override string _GetTemplateForActionLoadMore()
	{
		return "Mehr laden";
	}

	protected override string _GetTemplateForHeadingOtherServers()
	{
		return "Andere Server";
	}

	protected override string _GetTemplateForHeadingRunningServers()
	{
		return "Alle laufenden Server";
	}

	protected override string _GetTemplateForHeadingServersMyFriendsAreIn()
	{
		return "Server, auf denen meine Freunde sind";
	}

	/// <summary>
	/// Key: "Label.CurrentPlayerCount"
	/// English String: "{currentPlayers} of {maximumAllowedPlayers} players max"
	/// </summary>
	public override string LabelCurrentPlayerCount(string currentPlayers, string maximumAllowedPlayers)
	{
		return $"{currentPlayers} von max. {maximumAllowedPlayers} Spielern";
	}

	protected override string _GetTemplateForLabelCurrentPlayerCount()
	{
		return "{currentPlayers} von max. {maximumAllowedPlayers} Spielern";
	}

	protected override string _GetTemplateForLabelInactive()
	{
		return "Inaktiv.";
	}

	protected override string _GetTemplateForLabelInsufficientFunds()
	{
		return "Dieser Server wurde deaktiviert. Wir konnten die wiederkehrende Bezahlung nicht bearbeiten, da du nicht genügend Guthaben auf deinem Konto hast.";
	}

	protected override string _GetTemplateForLabelMyVipServer()
	{
		return "Mein VIP-Server";
	}

	protected override string _GetTemplateForLabelNoServersFound()
	{
		return "Keine Server gefunden.";
	}

	protected override string _GetTemplateForLabelNoVipServers()
	{
		return "Keine VIP-Serverinstanzen gefunden.";
	}

	protected override string _GetTemplateForLabelPaymentCancelled()
	{
		return "Bezahlung abgebrochen";
	}

	protected override string _GetTemplateForLabelPlacesNotLoading()
	{
		return "Beim Laden der Orte ist leider ein Problem aufgetreten.";
	}

	protected override string _GetTemplateForLabelServerListJoin()
	{
		return "Beitreten";
	}

	protected override string _GetTemplateForLabelServerListRenew()
	{
		return "Verlängern";
	}

	protected override string _GetTemplateForLabelShutDownServer()
	{
		return "Diesen Server abschalten";
	}

	protected override string _GetTemplateForLabelSlowGame()
	{
		return "Langsames Spiel";
	}
}
