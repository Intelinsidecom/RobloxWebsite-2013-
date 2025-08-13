namespace Roblox.TranslationResources.Feature;

/// <summary>
/// This class overrides PrivateServersResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class PrivateServersResources_fr_fr : PrivateServersResources_en_us, IPrivateServersResources, ITranslationResources
{
	/// <summary>
	/// Key: "Action.CreateVipServer"
	/// English String: "Create VIP Server"
	/// </summary>
	public override string ActionCreateVipServer => "Créer un serveur\u00a0VIP";

	/// <summary>
	/// Key: "Action.Refresh"
	/// English String: "Refresh"
	/// </summary>
	public override string ActionRefresh => "Actualiser";

	/// <summary>
	/// Key: "Heading.InvalidLink"
	/// Dialog title when the link to a VIP server is invalid
	/// English String: "Invalid Link"
	/// </summary>
	public override string HeadingInvalidLink => "Lien invalide";

	/// <summary>
	/// Key: "Heading.VipServers"
	/// English String: "VIP Servers"
	/// </summary>
	public override string HeadingVipServers => "Serveurs\u00a0VIP";

	/// <summary>
	/// Key: "Label.Cancel"
	/// English String: "Cancel"
	/// </summary>
	public override string LabelCancel => "Annuler";

	/// <summary>
	/// Key: "Label.GameJoinPrivateErrorTitle"
	/// Title of error window when trying to join a private server user does not have access to.
	/// English String: "Unable to join"
	/// </summary>
	public override string LabelGameJoinPrivateErrorTitle => "Impossible de joindre";

	/// <summary>
	/// Key: "Label.GameName"
	/// English String: "Game Name"
	/// </summary>
	public override string LabelGameName => "Nom du jeu";

	/// <summary>
	/// Key: "Label.NoVipServers"
	/// No VIP Server Instances Found.
	/// English String: "No VIP Server Instances Found."
	/// </summary>
	public override string LabelNoVipServers => "Aucune instance de serveur\u00a0VIP trouvée.";

	/// <summary>
	/// Key: "Label.PlayWithOthers"
	/// English String: "Play this game with friends and other people you invite."
	/// </summary>
	public override string LabelPlayWithOthers => "Jouez avec vos amis ou vos invités.";

	/// <summary>
	/// Key: "Label.Renew"
	/// English String: "Renew"
	/// </summary>
	public override string LabelRenew => "Renouveler";

	/// <summary>
	/// Key: "Label.RenewPrivateServer"
	/// English String: "Renew Private Server"
	/// </summary>
	public override string LabelRenewPrivateServer => "Renouveler le serveur privé";

	/// <summary>
	/// Key: "Label.ServerName"
	/// English String: "Server Name"
	/// </summary>
	public override string LabelServerName => "Nom du serveur";

	/// <summary>
	/// Key: "Label.Servers"
	/// English String: "Servers"
	/// </summary>
	public override string LabelServers => "Serveurs";

	/// <summary>
	/// Key: "Label.VIPServerGameJoinErrorAcknowledgement"
	/// Confirmation text for game join private error dialog.
	/// English String: "OK"
	/// </summary>
	public override string LabelVIPServerGameJoinErrorAcknowledgement => "OK";

	/// <summary>
	/// Key: "Label.VipServerJoinGamePrivateError"
	/// Error when user wants to join a VIP server when the game is marked private
	/// English String: "You cannot join this VIP server because the game is private."
	/// </summary>
	public override string LabelVipServerJoinGamePrivateError => "Vous ne pouvez pas rejoindre ce serveur VIP car ce jeu est privé.";

	/// <summary>
	/// Key: "Label.VipServersAbout"
	/// English String: "VIP servers let you play this game privately with friends, your clan, or people you invite!"
	/// </summary>
	public override string LabelVipServersAbout => "Les serveurs\u00a0VIP te permettent de jouer à ce jeu en privé avec tes amis, ton clan ou tes invités\u00a0!";

	/// <summary>
	/// Key: "Message.InvalidLink"
	/// Dialog content when the link to a VIP server is invalid
	/// English String: "This VIP Server link is no longer valid."
	/// </summary>
	public override string MessageInvalidLink => "Ce lien de serveur\u00a0VIP n'est plus valide.";

	public PrivateServersResources_fr_fr(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionCreateVipServer()
	{
		return "Créer un serveur\u00a0VIP";
	}

	protected override string _GetTemplateForActionRefresh()
	{
		return "Actualiser";
	}

	protected override string _GetTemplateForHeadingInvalidLink()
	{
		return "Lien invalide";
	}

	protected override string _GetTemplateForHeadingVipServers()
	{
		return "Serveurs\u00a0VIP";
	}

	protected override string _GetTemplateForLabelCancel()
	{
		return "Annuler";
	}

	/// <summary>
	/// Key: "Label.ConfirmEnableFuturePayments"
	/// English String: "Are you sure you want to enable future payments for your private VIP version of {placeName} by {creatorName}?"
	/// </summary>
	public override string LabelConfirmEnableFuturePayments(string placeName, string creatorName)
	{
		return $"Veux-tu vraiment autoriser les paiements futurs pour ta version\u00a0VIP privée de l'emplacement {placeName} par {creatorName}\u00a0?";
	}

	protected override string _GetTemplateForLabelConfirmEnableFuturePayments()
	{
		return "Veux-tu vraiment autoriser les paiements futurs pour ta version\u00a0VIP privée de l'emplacement {placeName} par {creatorName}\u00a0?";
	}

	/// <summary>
	/// Key: "Label.CreateVipServerFor"
	/// English String: "Create a VIP Server for {target}?"
	/// </summary>
	public override string LabelCreateVipServerFor(string target)
	{
		return $"Créer un serveur\u00a0VIP pour {target}\u00a0?";
	}

	protected override string _GetTemplateForLabelCreateVipServerFor()
	{
		return "Créer un serveur\u00a0VIP pour {target}\u00a0?";
	}

	/// <summary>
	/// Key: "Label.FooterText"
	/// English String: "Your balance after this transaction will be {robuxIcon}. This is a subscription-based feature. It will auto-renew once a month until you cancel the subscription."
	/// </summary>
	public override string LabelFooterText(string robuxIcon)
	{
		return $"Ton solde après cette transaction sera de {robuxIcon}. Il s'agit d'une fonctionnalité par abonnement\u00a0; elle sera renouvelée automatiquement tous les mois jusqu'à ce que tu annules l'abonnement.";
	}

	protected override string _GetTemplateForLabelFooterText()
	{
		return "Ton solde après cette transaction sera de {robuxIcon}. Il s'agit d'une fonctionnalité par abonnement\u00a0; elle sera renouvelée automatiquement tous les mois jusqu'à ce que tu annules l'abonnement.";
	}

	protected override string _GetTemplateForLabelGameJoinPrivateErrorTitle()
	{
		return "Impossible de joindre";
	}

	protected override string _GetTemplateForLabelGameName()
	{
		return "Nom du jeu";
	}

	protected override string _GetTemplateForLabelNoVipServers()
	{
		return "Aucune instance de serveur\u00a0VIP trouvée.";
	}

	protected override string _GetTemplateForLabelPlayWithOthers()
	{
		return "Jouez avec vos amis ou vos invités.";
	}

	protected override string _GetTemplateForLabelRenew()
	{
		return "Renouveler";
	}

	protected override string _GetTemplateForLabelRenewPrivateServer()
	{
		return "Renouveler le serveur privé";
	}

	/// <summary>
	/// Key: "Label.SeeAllServers"
	/// English String: "See all your VIP servers in the {serversLink} tab."
	/// </summary>
	public override string LabelSeeAllServers(string serversLink)
	{
		return $"Consultez tous vos serveurs\u00a0VIP dans l'onglet {serversLink}.";
	}

	protected override string _GetTemplateForLabelSeeAllServers()
	{
		return "Consultez tous vos serveurs\u00a0VIP dans l'onglet {serversLink}.";
	}

	protected override string _GetTemplateForLabelServerName()
	{
		return "Nom du serveur";
	}

	protected override string _GetTemplateForLabelServers()
	{
		return "Serveurs";
	}

	/// <summary>
	/// Key: "Label.StartRenewingPrice"
	/// English String: "This VIP Server will start renewing every month at {price} until you cancel."
	/// </summary>
	public override string LabelStartRenewingPrice(string price)
	{
		return $"Ce serveur\u00a0VIP sera renouvelé tous les mois au prix de {price} jusqu'à annulation.";
	}

	protected override string _GetTemplateForLabelStartRenewingPrice()
	{
		return "Ce serveur\u00a0VIP sera renouvelé tous les mois au prix de {price} jusqu'à annulation.";
	}

	protected override string _GetTemplateForLabelVIPServerGameJoinErrorAcknowledgement()
	{
		return "OK";
	}

	protected override string _GetTemplateForLabelVipServerJoinGamePrivateError()
	{
		return "Vous ne pouvez pas rejoindre ce serveur VIP car ce jeu est privé.";
	}

	protected override string _GetTemplateForLabelVipServersAbout()
	{
		return "Les serveurs\u00a0VIP te permettent de jouer à ce jeu en privé avec tes amis, ton clan ou tes invités\u00a0!";
	}

	/// <summary>
	/// Key: "Label.VipServersNotSupported"
	/// English String: "This game does not support {vipServersLink}."
	/// </summary>
	public override string LabelVipServersNotSupported(string vipServersLink)
	{
		return $"Ce jeu ne prend pas en charge les {vipServersLink}.";
	}

	protected override string _GetTemplateForLabelVipServersNotSupported()
	{
		return "Ce jeu ne prend pas en charge les {vipServersLink}.";
	}

	protected override string _GetTemplateForMessageInvalidLink()
	{
		return "Ce lien de serveur\u00a0VIP n'est plus valide.";
	}
}
