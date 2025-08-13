namespace Roblox.TranslationResources.Feature;

/// <summary>
/// This class overrides VIPServerResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class VIPServerResources_de_de : VIPServerResources_en_us, IVIPServerResources, ITranslationResources
{
	/// <summary>
	/// Key: "Action.Add"
	/// English String: "Add"
	/// </summary>
	public override string ActionAdd => "Hinzufügen";

	/// <summary>
	/// Key: "Action.AddPlayers"
	/// English String: "Add Players"
	/// </summary>
	public override string ActionAddPlayers => "Spieler hinzufügen";

	/// <summary>
	/// Key: "Action.Cancel"
	/// English String: "Cancel"
	/// </summary>
	public override string ActionCancel => "Abbrechen";

	/// <summary>
	/// Key: "Action.CancelPayments"
	/// English String: "Cancel Payments"
	/// </summary>
	public override string ActionCancelPayments => "Zahlungen unterbinden";

	/// <summary>
	/// Key: "Action.ChangeName"
	/// English String: "Change Name"
	/// </summary>
	public override string ActionChangeName => "Name ändern";

	/// <summary>
	/// Key: "Action.GoBack"
	/// English String: "Go Back"
	/// </summary>
	public override string ActionGoBack => "Zurück";

	/// <summary>
	/// Key: "Action.RegenerateJoinLink"
	/// English String: "Regenerate"
	/// </summary>
	public override string ActionRegenerateJoinLink => "Regenerieren";

	/// <summary>
	/// Key: "Action.Remove"
	/// English String: "Remove"
	/// </summary>
	public override string ActionRemove => "Entfernen";

	/// <summary>
	/// Key: "Action.RenewVipServer"
	/// English String: "Renew VIP Server"
	/// </summary>
	public override string ActionRenewVipServer => "VIP-Server verlängern";

	/// <summary>
	/// Key: "Action.SeeAll"
	/// English String: "See All"
	/// </summary>
	public override string ActionSeeAll => "Alle ansehen";

	/// <summary>
	/// Key: "Heading.CancelPayments"
	/// English String: "Cancel Payments"
	/// </summary>
	public override string HeadingCancelPayments => "Zahlungen unterbinden";

	/// <summary>
	/// Key: "Heading.ChangeName"
	/// English String: "Change VIP Server Name"
	/// </summary>
	public override string HeadingChangeName => "VIP-Servername ändern";

	/// <summary>
	/// Key: "Heading.ConfigureVipServer"
	/// English String: "Configure VIP Server"
	/// </summary>
	public override string HeadingConfigureVipServer => "VIP-Server konfigurieren";

	/// <summary>
	/// Key: "Heading.RemovePlayer"
	/// English String: "Remove Player"
	/// </summary>
	public override string HeadingRemovePlayer => "Spieler entfernen";

	/// <summary>
	/// Key: "Heading.RenewVipServer"
	/// English String: "Renew VIP Server"
	/// </summary>
	public override string HeadingRenewVipServer => "VIP-Server verlängern";

	/// <summary>
	/// Key: "Label.ChangeNamePlaceholder"
	/// English String: "VIP Server Name (1-50 Characters)"
	/// </summary>
	public override string LabelChangeNamePlaceholder => "VIP-Servername (1-50 Zeichen)";

	/// <summary>
	/// Key: "Label.ClanAccess"
	/// English String: "Clan Access"
	/// </summary>
	public override string LabelClanAccess => "Klanzugang";

	/// <summary>
	/// Key: "Label.FriendsAllowed"
	/// English String: "Friends Allowed"
	/// </summary>
	public override string LabelFriendsAllowed => "Freunde erlaubt";

	/// <summary>
	/// Key: "Label.GameName"
	/// English String: "Game Name"
	/// </summary>
	public override string LabelGameName => "Spielname";

	/// <summary>
	/// Key: "Label.JoinGameLink"
	/// English String: "Join Game Link..."
	/// </summary>
	public override string LabelJoinGameLink => "Link zum Spielbeitritt\u00a0...";

	/// <summary>
	/// Key: "Label.None"
	/// English String: "None"
	/// </summary>
	public override string LabelNone => "Keine Auswahl";

	/// <summary>
	/// Key: "Label.Off"
	/// English String: "Off"
	/// </summary>
	public override string LabelOff => "Aus";

	/// <summary>
	/// Key: "Label.On"
	/// English String: "On"
	/// </summary>
	public override string LabelOn => "An";

	/// <summary>
	/// Key: "Label.PickEnemyClan"
	/// English String: "Pick Enemy Clan"
	/// </summary>
	public override string LabelPickEnemyClan => "Feindlichen Klan wählen";

	/// <summary>
	/// Key: "Label.SearchForPlayers"
	/// English String: "Search for Players"
	/// </summary>
	public override string LabelSearchForPlayers => "Nach Spielern suchen";

	/// <summary>
	/// Key: "Label.Server"
	/// English String: "Server"
	/// </summary>
	public override string LabelServer => "Server";

	/// <summary>
	/// Key: "Label.ServerMembers"
	/// English String: "Server Members"
	/// </summary>
	public override string LabelServerMembers => "Servermitglieder";

	/// <summary>
	/// Key: "Label.SubscriptionStatus"
	/// English String: "Subscription Status"
	/// </summary>
	public override string LabelSubscriptionStatus => "Abonnementstatus";

	/// <summary>
	/// Key: "Label.VIPServerLink"
	/// English String: "VIP Server Link"
	/// </summary>
	public override string LabelVIPServerLink => "VIP-Serverlink";

	/// <summary>
	/// Key: "Label.VIPServerStatus"
	/// English String: "VIP Server Status"
	/// </summary>
	public override string LabelVIPServerStatus => "VIP-Serverstatus";

	/// <summary>
	/// Key: "Label.YourClan"
	/// English String: "Your Clan"
	/// </summary>
	public override string LabelYourClan => "Dein Klan";

	public VIPServerResources_de_de(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionAdd()
	{
		return "Hinzufügen";
	}

	protected override string _GetTemplateForActionAddPlayers()
	{
		return "Spieler hinzufügen";
	}

	protected override string _GetTemplateForActionCancel()
	{
		return "Abbrechen";
	}

	protected override string _GetTemplateForActionCancelPayments()
	{
		return "Zahlungen unterbinden";
	}

	protected override string _GetTemplateForActionChangeName()
	{
		return "Name ändern";
	}

	protected override string _GetTemplateForActionGoBack()
	{
		return "Zurück";
	}

	protected override string _GetTemplateForActionRegenerateJoinLink()
	{
		return "Regenerieren";
	}

	protected override string _GetTemplateForActionRemove()
	{
		return "Entfernen";
	}

	protected override string _GetTemplateForActionRenewVipServer()
	{
		return "VIP-Server verlängern";
	}

	protected override string _GetTemplateForActionSeeAll()
	{
		return "Alle ansehen";
	}

	protected override string _GetTemplateForHeadingCancelPayments()
	{
		return "Zahlungen unterbinden";
	}

	protected override string _GetTemplateForHeadingChangeName()
	{
		return "VIP-Servername ändern";
	}

	protected override string _GetTemplateForHeadingConfigureVipServer()
	{
		return "VIP-Server konfigurieren";
	}

	protected override string _GetTemplateForHeadingRemovePlayer()
	{
		return "Spieler entfernen";
	}

	protected override string _GetTemplateForHeadingRenewVipServer()
	{
		return "VIP-Server verlängern";
	}

	/// <summary>
	/// Key: "Label.ChangeNameBodyMessage"
	/// English String: "Are you sure you want to cancel future payments for your VIP Server of {name} by {creator}? If you cancel, your VIP Server will be deactivated on {date}."
	/// </summary>
	public override string LabelChangeNameBodyMessage(string name, string creator, string date)
	{
		return $"Möchtest du zukünftige Zahlungen für deinen VIP-Server von {name} (Ersteller: {creator}) wirklich unterbinden? Wenn du keine weiteren Zahlungen erlaubst, wird dein VIP-Server am {date} deaktiviert.";
	}

	protected override string _GetTemplateForLabelChangeNameBodyMessage()
	{
		return "Möchtest du zukünftige Zahlungen für deinen VIP-Server von {name} (Ersteller: {creator}) wirklich unterbinden? Wenn du keine weiteren Zahlungen erlaubst, wird dein VIP-Server am {date} deaktiviert.";
	}

	protected override string _GetTemplateForLabelChangeNamePlaceholder()
	{
		return "VIP-Servername (1-50 Zeichen)";
	}

	protected override string _GetTemplateForLabelClanAccess()
	{
		return "Klanzugang";
	}

	protected override string _GetTemplateForLabelFriendsAllowed()
	{
		return "Freunde erlaubt";
	}

	protected override string _GetTemplateForLabelGameName()
	{
		return "Spielname";
	}

	protected override string _GetTemplateForLabelJoinGameLink()
	{
		return "Link zum Spielbeitritt\u00a0...";
	}

	protected override string _GetTemplateForLabelNone()
	{
		return "Keine Auswahl";
	}

	protected override string _GetTemplateForLabelOff()
	{
		return "Aus";
	}

	protected override string _GetTemplateForLabelOn()
	{
		return "An";
	}

	protected override string _GetTemplateForLabelPickEnemyClan()
	{
		return "Feindlichen Klan wählen";
	}

	/// <summary>
	/// Key: "Label.RemovePlayerBodyMessage"
	/// English String: "Are you sure you want to remove {name} from your VIP Server? They will no longer be able to join your VIP Server."
	/// </summary>
	public override string LabelRemovePlayerBodyMessage(string name)
	{
		return $"Möchtest du {name} wirklich von deinem VIP-Server entfernen? Dieser Benutzer wird deinem VIP-Server dann nicht mehr beitreten können.";
	}

	protected override string _GetTemplateForLabelRemovePlayerBodyMessage()
	{
		return "Möchtest du {name} wirklich von deinem VIP-Server entfernen? Dieser Benutzer wird deinem VIP-Server dann nicht mehr beitreten können.";
	}

	/// <summary>
	/// Key: "Label.RenewVipServerBodyMessageConfirmation"
	/// English String: "Are you sure you want to enable future payments for your VIP Server of {name} by {creator}?"
	/// </summary>
	public override string LabelRenewVipServerBodyMessageConfirmation(string name, string creator)
	{
		return $"Möchtest du zukünftige Zahlungen für deinen VIP-Server von {name} (Ersteller: {creator}) wirklich aktivieren?";
	}

	protected override string _GetTemplateForLabelRenewVipServerBodyMessageConfirmation()
	{
		return "Möchtest du zukünftige Zahlungen für deinen VIP-Server von {name} (Ersteller: {creator}) wirklich aktivieren?";
	}

	/// <summary>
	/// Key: "Label.RenewVipServerBodyMessageStart"
	/// English String: "This VIP Server will start renewing every month at {date} until you cancel."
	/// </summary>
	public override string LabelRenewVipServerBodyMessageStart(string date)
	{
		return $"Dieser VIP-Server wird jeden Monat am {date} verlängert, bis du das Abo kündigst.";
	}

	protected override string _GetTemplateForLabelRenewVipServerBodyMessageStart()
	{
		return "Dieser VIP-Server wird jeden Monat am {date} verlängert, bis du das Abo kündigst.";
	}

	protected override string _GetTemplateForLabelSearchForPlayers()
	{
		return "Nach Spielern suchen";
	}

	protected override string _GetTemplateForLabelServer()
	{
		return "Server";
	}

	/// <summary>
	/// Key: "Label.ServerExpirationDate"
	/// English String: "Your VIP Server expired on{date}"
	/// </summary>
	public override string LabelServerExpirationDate(string date)
	{
		return $"Dein VIP-Server ist am {date} abgelaufen.";
	}

	protected override string _GetTemplateForLabelServerExpirationDate()
	{
		return "Dein VIP-Server ist am {date} abgelaufen.";
	}

	protected override string _GetTemplateForLabelServerMembers()
	{
		return "Servermitglieder";
	}

	/// <summary>
	/// Key: "Label.SubscriptionChargeDate"
	/// English String: "You will be charged again on {date}"
	/// </summary>
	public override string LabelSubscriptionChargeDate(string date)
	{
		return $"Der Preis wird dir das nächste Mal am {date} in Rechnung gestellt.";
	}

	protected override string _GetTemplateForLabelSubscriptionChargeDate()
	{
		return "Der Preis wird dir das nächste Mal am {date} in Rechnung gestellt.";
	}

	/// <summary>
	/// Key: "Label.SubscriptionMonthlyPaymentDue"
	/// English String: "Your VIP Server monthly payment is {value}"
	/// </summary>
	public override string LabelSubscriptionMonthlyPaymentDue(string value)
	{
		return $"Deine monatliche Zahlung für den VIP-Server beträgt {value}.";
	}

	protected override string _GetTemplateForLabelSubscriptionMonthlyPaymentDue()
	{
		return "Deine monatliche Zahlung für den VIP-Server beträgt {value}.";
	}

	protected override string _GetTemplateForLabelSubscriptionStatus()
	{
		return "Abonnementstatus";
	}

	protected override string _GetTemplateForLabelVIPServerLink()
	{
		return "VIP-Serverlink";
	}

	protected override string _GetTemplateForLabelVIPServerStatus()
	{
		return "VIP-Serverstatus";
	}

	protected override string _GetTemplateForLabelYourClan()
	{
		return "Dein Klan";
	}
}
