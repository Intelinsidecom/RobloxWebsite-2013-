namespace Roblox.Platform.TranslationResources.Feature {
    /// <summary>

/// This class overrides PrivateServersResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class PrivateServersResources_de_de : PrivateServersResources_en_us, IPrivateServersResources, ITranslationResources
{
	/// <summary>
	/// Key: "Action.CreateVipServer"
	/// English String: "Create VIP Server"
	/// </summary>
	public override string ActionCreateVipServer => "VIP-Server erstellen";

	/// <summary>
	/// Key: "Action.Refresh"
	/// English String: "Refresh"
	/// </summary>
	public override string ActionRefresh => "Aktualisieren";

	/// <summary>
	/// Key: "Heading.InvalidLink"
	/// Dialog title when the link to a VIP server is invalid
	/// English String: "Invalid Link"
	/// </summary>
	public override string HeadingInvalidLink => "UngÃ¼ltiger Link";

	/// <summary>
	/// Key: "Heading.VipServers"
	/// English String: "VIP Servers"
	/// </summary>
	public override string HeadingVipServers => "VIP-Server";

	/// <summary>
	/// Key: "Label.Cancel"
	/// English String: "Cancel"
	/// </summary>
	public override string LabelCancel => "Abbrechen";

	/// <summary>
	/// Key: "Label.GameJoinPrivateErrorTitle"
	/// Title of error window when trying to join a private server user does not have access to.
	/// English String: "Unable to join"
	/// </summary>
	public override string LabelGameJoinPrivateErrorTitle => "Kann nicht beitreten";

	/// <summary>
	/// Key: "Label.GameName"
	/// English String: "Game Name"
	/// </summary>
	public override string LabelGameName => "Spielname";

	/// <summary>
	/// Key: "Label.NoVipServers"
	/// No VIP Server Instances Found.
	/// English String: "No VIP Server Instances Found."
	/// </summary>
	public override string LabelNoVipServers => "Keine VIP-Serverinstanzen gefunden.";

	/// <summary>
	/// Key: "Label.PlayWithOthers"
	/// English String: "Play this game with friends and other people you invite."
	/// </summary>
	public override string LabelPlayWithOthers => "Spiele dieses Spiel mit Freunden und anderen Leuten, die du einlÃ¤dst.";

	/// <summary>
	/// Key: "Label.Renew"
	/// English String: "Renew"
	/// </summary>
	public override string LabelRenew => "VerlÃ¤ngern";

	/// <summary>
	/// Key: "Label.RenewPrivateServer"
	/// English String: "Renew Private Server"
	/// </summary>
	public override string LabelRenewPrivateServer => "Privaten Server verlÃ¤ngern";

	/// <summary>
	/// Key: "Label.ServerName"
	/// English String: "Server Name"
	/// </summary>
	public override string LabelServerName => "Servername";

	/// <summary>
	/// Key: "Label.Servers"
	/// English String: "Servers"
	/// </summary>
	public override string LabelServers => "Server";

	/// <summary>
	/// Key: "Label.VIPServerGameJoinErrorAcknowledgement"
	/// Confirmation text for game join private error dialog.
	/// English String: "OK"
	/// </summary>
	public override string LabelVIPServerGameJoinErrorAcknowledgement => "Okay";

	/// <summary>
	/// Key: "Label.VipServerJoinGamePrivateError"
	/// Error when user wants to join a VIP server when the game is marked private
	/// English String: "You cannot join this VIP server because the game is private."
	/// </summary>
	public override string LabelVipServerJoinGamePrivateError => "Da das Spiel privat ist, kannst du diesem VIP-Server nicht beitreten.";

	/// <summary>
	/// Key: "Label.VipServersAbout"
	/// English String: "VIP servers let you play this game privately with friends, your clan, or people you invite!"
	/// </summary>
	public override string LabelVipServersAbout => "Auf VIP-Servern kannst du dieses Spiel privat mit deinen Freunden, deinem Klan oder Leuten, die du einlÃ¤dst, spielen!";

	/// <summary>
	/// Key: "Message.InvalidLink"
	/// Dialog content when the link to a VIP server is invalid
	/// English String: "This VIP Server link is no longer valid."
	/// </summary>
	public override string MessageInvalidLink => "Dieser VIP-Server ist nicht mehr gÃ¼ltig.";

	public PrivateServersResources_de_de(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionCreateVipServer()
	{
		return "VIP-Server erstellen";
	}

	protected override string _GetTemplateForActionRefresh()
	{
		return "Aktualisieren";
	}

	protected override string _GetTemplateForHeadingInvalidLink()
	{
		return "UngÃ¼ltiger Link";
	}

	protected override string _GetTemplateForHeadingVipServers()
	{
		return "VIP-Server";
	}

	protected override string _GetTemplateForLabelCancel()
	{
		return "Abbrechen";
	}

	/// <summary>
	/// Key: "Label.ConfirmEnableFuturePayments"
	/// English String: "Are you sure you want to enable future payments for your private VIP version of {placeName} by {creatorName}?"
	/// </summary>
	public override string LabelConfirmEnableFuturePayments(string placeName, string creatorName)
	{
		return $"MÃ¶chtest du zukÃ¼nftige Zahlungen fÃ¼r deine private VIP-Version von {placeName} (Ersteller: {creatorName}) wirklich aktivieren?";
	}

	protected override string _GetTemplateForLabelConfirmEnableFuturePayments()
	{
		return "MÃ¶chtest du zukÃ¼nftige Zahlungen fÃ¼r deine private VIP-Version von {placeName} (Ersteller: {creatorName}) wirklich aktivieren?";
	}

	/// <summary>
	/// Key: "Label.CreateVipServerFor"
	/// English String: "Create a VIP Server for {target}?"
	/// </summary>
	public override string LabelCreateVipServerFor(string target)
	{
		return $"VIP-Server fÃ¼r {target} erstellen?";
	}

	protected override string _GetTemplateForLabelCreateVipServerFor()
	{
		return "VIP-Server fÃ¼r {target} erstellen?";
	}

	/// <summary>
	/// Key: "Label.FooterText"
	/// English String: "Your balance after this transaction will be {robuxIcon}. This is a subscription-based feature. It will auto-renew once a month until you cancel the subscription."
	/// </summary>
	public override string LabelFooterText(string robuxIcon)
	{
		return $"Nach dieser Transaktion wird dein Guthaben {robuxIcon} betragen. Bei diesem Feature handelt es sich um ein Abonnement. Wenn du das Abo nicht kÃ¼ndigst, wird es monatlich automatisch verlÃ¤ngert.";
	}

	protected override string _GetTemplateForLabelFooterText()
	{
		return "Nach dieser Transaktion wird dein Guthaben {robuxIcon} betragen. Bei diesem Feature handelt es sich um ein Abonnement. Wenn du das Abo nicht kÃ¼ndigst, wird es monatlich automatisch verlÃ¤ngert.";
	}

	protected override string _GetTemplateForLabelGameJoinPrivateErrorTitle()
	{
		return "Kann nicht beitreten";
	}

	protected override string _GetTemplateForLabelGameName()
	{
		return "Spielname";
	}

	protected override string _GetTemplateForLabelNoVipServers()
	{
		return "Keine VIP-Serverinstanzen gefunden.";
	}

	protected override string _GetTemplateForLabelPlayWithOthers()
	{
		return "Spiele dieses Spiel mit Freunden und anderen Leuten, die du einlÃ¤dst.";
	}

	protected override string _GetTemplateForLabelRenew()
	{
		return "VerlÃ¤ngern";
	}

	protected override string _GetTemplateForLabelRenewPrivateServer()
	{
		return "Privaten Server verlÃ¤ngern";
	}

	/// <summary>
	/// Key: "Label.SeeAllServers"
	/// English String: "See all your VIP servers in the {serversLink} tab."
	/// </summary>
	public override string LabelSeeAllServers(string serversLink)
	{
		return $"Im Reiter â€ž{serversLink}â€œ findest du alle deine VIP-Server.";
	}

	protected override string _GetTemplateForLabelSeeAllServers()
	{
		return "Im Reiter â€ž{serversLink}â€œ findest du alle deine VIP-Server.";
	}

	protected override string _GetTemplateForLabelServerName()
	{
		return "Servername";
	}

	protected override string _GetTemplateForLabelServers()
	{
		return "Server";
	}

	/// <summary>
	/// Key: "Label.StartRenewingPrice"
	/// English String: "This VIP Server will start renewing every month at {price} until you cancel."
	/// </summary>
	public override string LabelStartRenewingPrice(string price)
	{
		return $"Dieser VIP-Server wird monatlich fÃ¼r {price} verlÃ¤ngert, bis du das Abo kÃ¼ndigst.";
	}

	protected override string _GetTemplateForLabelStartRenewingPrice()
	{
		return "Dieser VIP-Server wird monatlich fÃ¼r {price} verlÃ¤ngert, bis du das Abo kÃ¼ndigst.";
	}

	protected override string _GetTemplateForLabelVIPServerGameJoinErrorAcknowledgement()
	{
		return "Okay";
	}

	protected override string _GetTemplateForLabelVipServerJoinGamePrivateError()
	{
		return "Da das Spiel privat ist, kannst du diesem VIP-Server nicht beitreten.";
	}

	protected override string _GetTemplateForLabelVipServersAbout()
	{
		return "Auf VIP-Servern kannst du dieses Spiel privat mit deinen Freunden, deinem Klan oder Leuten, die du einlÃ¤dst, spielen!";
	}

	/// <summary>
	/// Key: "Label.VipServersNotSupported"
	/// English String: "This game does not support {vipServersLink}."
	/// </summary>
	public override string LabelVipServersNotSupported(string vipServersLink)
	{
		return $"Dieses Spiel unterstÃ¼tzt {vipServersLink} nicht.";
	}

	protected override string _GetTemplateForLabelVipServersNotSupported()
	{
		return "Dieses Spiel unterstÃ¼tzt {vipServersLink} nicht.";
	}

	protected override string _GetTemplateForMessageInvalidLink()
	{
		return "Dieser VIP-Server ist nicht mehr gÃ¼ltig.";
	}
}


}
