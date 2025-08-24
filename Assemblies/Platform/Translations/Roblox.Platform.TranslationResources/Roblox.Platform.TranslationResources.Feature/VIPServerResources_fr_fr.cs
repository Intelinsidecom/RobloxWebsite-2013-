namespace Roblox.TranslationResources.Feature;

/// <summary>
/// This class overrides VIPServerResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class VIPServerResources_fr_fr : VIPServerResources_en_us, IVIPServerResources, ITranslationResources
{
	/// <summary>
	/// Key: "Action.Add"
	/// English String: "Add"
	/// </summary>
	public override string ActionAdd => "Ajouter";

	/// <summary>
	/// Key: "Action.AddPlayers"
	/// English String: "Add Players"
	/// </summary>
	public override string ActionAddPlayers => "Ajouter des joueurs";

	/// <summary>
	/// Key: "Action.Cancel"
	/// English String: "Cancel"
	/// </summary>
	public override string ActionCancel => "Annuler";

	/// <summary>
	/// Key: "Action.CancelPayments"
	/// English String: "Cancel Payments"
	/// </summary>
	public override string ActionCancelPayments => "Annuler les paiements";

	/// <summary>
	/// Key: "Action.ChangeName"
	/// English String: "Change Name"
	/// </summary>
	public override string ActionChangeName => "Renommer";

	/// <summary>
	/// Key: "Action.GoBack"
	/// English String: "Go Back"
	/// </summary>
	public override string ActionGoBack => "Retour";

	/// <summary>
	/// Key: "Action.RegenerateJoinLink"
	/// English String: "Regenerate"
	/// </summary>
	public override string ActionRegenerateJoinLink => "Générer nouveau";

	/// <summary>
	/// Key: "Action.Remove"
	/// English String: "Remove"
	/// </summary>
	public override string ActionRemove => "Retirer";

	/// <summary>
	/// Key: "Action.RenewVipServer"
	/// English String: "Renew VIP Server"
	/// </summary>
	public override string ActionRenewVipServer => "Renouveler le serveur\u00a0VIP";

	/// <summary>
	/// Key: "Action.SeeAll"
	/// English String: "See All"
	/// </summary>
	public override string ActionSeeAll => "Afficher tout";

	/// <summary>
	/// Key: "Heading.CancelPayments"
	/// English String: "Cancel Payments"
	/// </summary>
	public override string HeadingCancelPayments => "Annuler les paiements";

	/// <summary>
	/// Key: "Heading.ChangeName"
	/// English String: "Change VIP Server Name"
	/// </summary>
	public override string HeadingChangeName => "Renommer le serveur\u00a0VIP";

	/// <summary>
	/// Key: "Heading.ConfigureVipServer"
	/// English String: "Configure VIP Server"
	/// </summary>
	public override string HeadingConfigureVipServer => "Configuration du serveur\u00a0VIP";

	/// <summary>
	/// Key: "Heading.RemovePlayer"
	/// English String: "Remove Player"
	/// </summary>
	public override string HeadingRemovePlayer => "Retirer le joueur";

	/// <summary>
	/// Key: "Heading.RenewVipServer"
	/// English String: "Renew VIP Server"
	/// </summary>
	public override string HeadingRenewVipServer => "Renouveler le serveur\u00a0VIP";

	/// <summary>
	/// Key: "Label.ChangeNamePlaceholder"
	/// English String: "VIP Server Name (1-50 Characters)"
	/// </summary>
	public override string LabelChangeNamePlaceholder => "Nom du serveur\u00a0VIP (1-50\u00a0caractères)";

	/// <summary>
	/// Key: "Label.ClanAccess"
	/// English String: "Clan Access"
	/// </summary>
	public override string LabelClanAccess => "Accès de clan";

	/// <summary>
	/// Key: "Label.FriendsAllowed"
	/// English String: "Friends Allowed"
	/// </summary>
	public override string LabelFriendsAllowed => "Amis autorisés";

	/// <summary>
	/// Key: "Label.GameName"
	/// English String: "Game Name"
	/// </summary>
	public override string LabelGameName => "Nom du jeu";

	/// <summary>
	/// Key: "Label.JoinGameLink"
	/// English String: "Join Game Link..."
	/// </summary>
	public override string LabelJoinGameLink => "Lien pour rejoindre le jeu...";

	/// <summary>
	/// Key: "Label.None"
	/// English String: "None"
	/// </summary>
	public override string LabelNone => "Aucun";

	/// <summary>
	/// Key: "Label.Off"
	/// English String: "Off"
	/// </summary>
	public override string LabelOff => "Désactivé";

	/// <summary>
	/// Key: "Label.On"
	/// English String: "On"
	/// </summary>
	public override string LabelOn => "Activé";

	/// <summary>
	/// Key: "Label.PickEnemyClan"
	/// English String: "Pick Enemy Clan"
	/// </summary>
	public override string LabelPickEnemyClan => "Choisissez un clan ennemi";

	/// <summary>
	/// Key: "Label.SearchForPlayers"
	/// English String: "Search for Players"
	/// </summary>
	public override string LabelSearchForPlayers => "Rechercher des joueurs";

	/// <summary>
	/// Key: "Label.Server"
	/// English String: "Server"
	/// </summary>
	public override string LabelServer => "Serveur";

	/// <summary>
	/// Key: "Label.ServerMembers"
	/// English String: "Server Members"
	/// </summary>
	public override string LabelServerMembers => "Membres du serveur";

	/// <summary>
	/// Key: "Label.SubscriptionStatus"
	/// English String: "Subscription Status"
	/// </summary>
	public override string LabelSubscriptionStatus => "Statut de l'abonnement";

	/// <summary>
	/// Key: "Label.VIPServerLink"
	/// English String: "VIP Server Link"
	/// </summary>
	public override string LabelVIPServerLink => "Lien du serveur\u00a0VIP";

	/// <summary>
	/// Key: "Label.VIPServerStatus"
	/// English String: "VIP Server Status"
	/// </summary>
	public override string LabelVIPServerStatus => "Statut du serveur\u00a0VIP";

	/// <summary>
	/// Key: "Label.YourClan"
	/// English String: "Your Clan"
	/// </summary>
	public override string LabelYourClan => "Ton clan";

	public VIPServerResources_fr_fr(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionAdd()
	{
		return "Ajouter";
	}

	protected override string _GetTemplateForActionAddPlayers()
	{
		return "Ajouter des joueurs";
	}

	protected override string _GetTemplateForActionCancel()
	{
		return "Annuler";
	}

	protected override string _GetTemplateForActionCancelPayments()
	{
		return "Annuler les paiements";
	}

	protected override string _GetTemplateForActionChangeName()
	{
		return "Renommer";
	}

	protected override string _GetTemplateForActionGoBack()
	{
		return "Retour";
	}

	protected override string _GetTemplateForActionRegenerateJoinLink()
	{
		return "Générer nouveau";
	}

	protected override string _GetTemplateForActionRemove()
	{
		return "Retirer";
	}

	protected override string _GetTemplateForActionRenewVipServer()
	{
		return "Renouveler le serveur\u00a0VIP";
	}

	protected override string _GetTemplateForActionSeeAll()
	{
		return "Afficher tout";
	}

	protected override string _GetTemplateForHeadingCancelPayments()
	{
		return "Annuler les paiements";
	}

	protected override string _GetTemplateForHeadingChangeName()
	{
		return "Renommer le serveur\u00a0VIP";
	}

	protected override string _GetTemplateForHeadingConfigureVipServer()
	{
		return "Configuration du serveur\u00a0VIP";
	}

	protected override string _GetTemplateForHeadingRemovePlayer()
	{
		return "Retirer le joueur";
	}

	protected override string _GetTemplateForHeadingRenewVipServer()
	{
		return "Renouveler le serveur\u00a0VIP";
	}

	/// <summary>
	/// Key: "Label.ChangeNameBodyMessage"
	/// English String: "Are you sure you want to cancel future payments for your VIP Server of {name} by {creator}? If you cancel, your VIP Server will be deactivated on {date}."
	/// </summary>
	public override string LabelChangeNameBodyMessage(string name, string creator, string date)
	{
		return $"Veux-tu vraiment annuler les paiements futurs pour ton serveur\u00a0VIP de {name} par {creator}\u00a0? Si tu annules, ton serveur\u00a0VIP sera désactivé à compter du {date}.";
	}

	protected override string _GetTemplateForLabelChangeNameBodyMessage()
	{
		return "Veux-tu vraiment annuler les paiements futurs pour ton serveur\u00a0VIP de {name} par {creator}\u00a0? Si tu annules, ton serveur\u00a0VIP sera désactivé à compter du {date}.";
	}

	protected override string _GetTemplateForLabelChangeNamePlaceholder()
	{
		return "Nom du serveur\u00a0VIP (1-50\u00a0caractères)";
	}

	protected override string _GetTemplateForLabelClanAccess()
	{
		return "Accès de clan";
	}

	protected override string _GetTemplateForLabelFriendsAllowed()
	{
		return "Amis autorisés";
	}

	protected override string _GetTemplateForLabelGameName()
	{
		return "Nom du jeu";
	}

	protected override string _GetTemplateForLabelJoinGameLink()
	{
		return "Lien pour rejoindre le jeu...";
	}

	protected override string _GetTemplateForLabelNone()
	{
		return "Aucun";
	}

	protected override string _GetTemplateForLabelOff()
	{
		return "Désactivé";
	}

	protected override string _GetTemplateForLabelOn()
	{
		return "Activé";
	}

	protected override string _GetTemplateForLabelPickEnemyClan()
	{
		return "Choisissez un clan ennemi";
	}

	/// <summary>
	/// Key: "Label.RemovePlayerBodyMessage"
	/// English String: "Are you sure you want to remove {name} from your VIP Server? They will no longer be able to join your VIP Server."
	/// </summary>
	public override string LabelRemovePlayerBodyMessage(string name)
	{
		return $"Veux-tu vraiment retirer {name} de ton serveur\u00a0VIP\u00a0? Le joueur ne pourra plus rejoindre ton serveur\u00a0VIP.";
	}

	protected override string _GetTemplateForLabelRemovePlayerBodyMessage()
	{
		return "Veux-tu vraiment retirer {name} de ton serveur\u00a0VIP\u00a0? Le joueur ne pourra plus rejoindre ton serveur\u00a0VIP.";
	}

	/// <summary>
	/// Key: "Label.RenewVipServerBodyMessageConfirmation"
	/// English String: "Are you sure you want to enable future payments for your VIP Server of {name} by {creator}?"
	/// </summary>
	public override string LabelRenewVipServerBodyMessageConfirmation(string name, string creator)
	{
		return $"Veux-tu vraiment autoriser les paiements futurs pour ton serveur\u00a0VIP de {name} par {creator}\u00a0?";
	}

	protected override string _GetTemplateForLabelRenewVipServerBodyMessageConfirmation()
	{
		return "Veux-tu vraiment autoriser les paiements futurs pour ton serveur\u00a0VIP de {name} par {creator}\u00a0?";
	}

	/// <summary>
	/// Key: "Label.RenewVipServerBodyMessageStart"
	/// English String: "This VIP Server will start renewing every month at {date} until you cancel."
	/// </summary>
	public override string LabelRenewVipServerBodyMessageStart(string date)
	{
		return $"Ce serveur\u00a0VIP sera renouvelé tous les mois le {date} jusqu'à annulation.";
	}

	protected override string _GetTemplateForLabelRenewVipServerBodyMessageStart()
	{
		return "Ce serveur\u00a0VIP sera renouvelé tous les mois le {date} jusqu'à annulation.";
	}

	protected override string _GetTemplateForLabelSearchForPlayers()
	{
		return "Rechercher des joueurs";
	}

	protected override string _GetTemplateForLabelServer()
	{
		return "Serveur";
	}

	/// <summary>
	/// Key: "Label.ServerExpirationDate"
	/// English String: "Your VIP Server expired on{date}"
	/// </summary>
	public override string LabelServerExpirationDate(string date)
	{
		return $"Ton serveur\u00a0VIP expirera le {date}.";
	}

	protected override string _GetTemplateForLabelServerExpirationDate()
	{
		return "Ton serveur\u00a0VIP expirera le {date}.";
	}

	protected override string _GetTemplateForLabelServerMembers()
	{
		return "Membres du serveur";
	}

	/// <summary>
	/// Key: "Label.SubscriptionChargeDate"
	/// English String: "You will be charged again on {date}"
	/// </summary>
	public override string LabelSubscriptionChargeDate(string date)
	{
		return $"Vous serez de nouveau facturé(e) le {date}.";
	}

	protected override string _GetTemplateForLabelSubscriptionChargeDate()
	{
		return "Vous serez de nouveau facturé(e) le {date}.";
	}

	/// <summary>
	/// Key: "Label.SubscriptionMonthlyPaymentDue"
	/// English String: "Your VIP Server monthly payment is {value}"
	/// </summary>
	public override string LabelSubscriptionMonthlyPaymentDue(string value)
	{
		return $"Les mensualités de ton serveur\u00a0VIP s'élèvent à {value}";
	}

	protected override string _GetTemplateForLabelSubscriptionMonthlyPaymentDue()
	{
		return "Les mensualités de ton serveur\u00a0VIP s'élèvent à {value}";
	}

	protected override string _GetTemplateForLabelSubscriptionStatus()
	{
		return "Statut de l'abonnement";
	}

	protected override string _GetTemplateForLabelVIPServerLink()
	{
		return "Lien du serveur\u00a0VIP";
	}

	protected override string _GetTemplateForLabelVIPServerStatus()
	{
		return "Statut du serveur\u00a0VIP";
	}

	protected override string _GetTemplateForLabelYourClan()
	{
		return "Ton clan";
	}
}
