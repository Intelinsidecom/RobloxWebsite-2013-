namespace Roblox.TranslationResources.Feature;

/// <summary>
/// This class overrides PrivateServersResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class PrivateServersResources_es_es : PrivateServersResources_en_us, IPrivateServersResources, ITranslationResources
{
	/// <summary>
	/// Key: "Action.CreateVipServer"
	/// English String: "Create VIP Server"
	/// </summary>
	public override string ActionCreateVipServer => "Crear servidor VIP";

	/// <summary>
	/// Key: "Action.Refresh"
	/// English String: "Refresh"
	/// </summary>
	public override string ActionRefresh => "Actualizar";

	/// <summary>
	/// Key: "Heading.InvalidLink"
	/// Dialog title when the link to a VIP server is invalid
	/// English String: "Invalid Link"
	/// </summary>
	public override string HeadingInvalidLink => "El enlace no es válido.";

	/// <summary>
	/// Key: "Heading.VipServers"
	/// English String: "VIP Servers"
	/// </summary>
	public override string HeadingVipServers => "Servidores VIP";

	/// <summary>
	/// Key: "Label.Cancel"
	/// English String: "Cancel"
	/// </summary>
	public override string LabelCancel => "Cancelar";

	/// <summary>
	/// Key: "Label.GameJoinPrivateErrorTitle"
	/// Title of error window when trying to join a private server user does not have access to.
	/// English String: "Unable to join"
	/// </summary>
	public override string LabelGameJoinPrivateErrorTitle => "No se ha podido unirse";

	/// <summary>
	/// Key: "Label.GameName"
	/// English String: "Game Name"
	/// </summary>
	public override string LabelGameName => "Nombre del juego";

	/// <summary>
	/// Key: "Label.NoVipServers"
	/// No VIP Server Instances Found.
	/// English String: "No VIP Server Instances Found."
	/// </summary>
	public override string LabelNoVipServers => "No se han encontrado instancias del servidor VIP.";

	/// <summary>
	/// Key: "Label.PlayWithOthers"
	/// English String: "Play this game with friends and other people you invite."
	/// </summary>
	public override string LabelPlayWithOthers => "Juega a este juego con amigos y otras personas a las que invites.";

	/// <summary>
	/// Key: "Label.Renew"
	/// English String: "Renew"
	/// </summary>
	public override string LabelRenew => "Renovar";

	/// <summary>
	/// Key: "Label.RenewPrivateServer"
	/// English String: "Renew Private Server"
	/// </summary>
	public override string LabelRenewPrivateServer => "Renovar servidor privado";

	/// <summary>
	/// Key: "Label.ServerName"
	/// English String: "Server Name"
	/// </summary>
	public override string LabelServerName => "Nombre del servidor";

	/// <summary>
	/// Key: "Label.Servers"
	/// English String: "Servers"
	/// </summary>
	public override string LabelServers => "Servidores";

	/// <summary>
	/// Key: "Label.VIPServerGameJoinErrorAcknowledgement"
	/// Confirmation text for game join private error dialog.
	/// English String: "OK"
	/// </summary>
	public override string LabelVIPServerGameJoinErrorAcknowledgement => "Aceptar";

	/// <summary>
	/// Key: "Label.VipServerJoinGamePrivateError"
	/// Error when user wants to join a VIP server when the game is marked private
	/// English String: "You cannot join this VIP server because the game is private."
	/// </summary>
	public override string LabelVipServerJoinGamePrivateError => "No puedes unirte a este servidor VIP porque el juego es privado.";

	/// <summary>
	/// Key: "Label.VipServersAbout"
	/// English String: "VIP servers let you play this game privately with friends, your clan, or people you invite!"
	/// </summary>
	public override string LabelVipServersAbout => "Los servidores VIP te permiten jugar a este juego en privado con tus amigos, tu clan ¡o las personas que invites!";

	/// <summary>
	/// Key: "Message.InvalidLink"
	/// Dialog content when the link to a VIP server is invalid
	/// English String: "This VIP Server link is no longer valid."
	/// </summary>
	public override string MessageInvalidLink => "Este enlace al servidor VIP ya no es válido.";

	public PrivateServersResources_es_es(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionCreateVipServer()
	{
		return "Crear servidor VIP";
	}

	protected override string _GetTemplateForActionRefresh()
	{
		return "Actualizar";
	}

	protected override string _GetTemplateForHeadingInvalidLink()
	{
		return "El enlace no es válido.";
	}

	protected override string _GetTemplateForHeadingVipServers()
	{
		return "Servidores VIP";
	}

	protected override string _GetTemplateForLabelCancel()
	{
		return "Cancelar";
	}

	/// <summary>
	/// Key: "Label.ConfirmEnableFuturePayments"
	/// English String: "Are you sure you want to enable future payments for your private VIP version of {placeName} by {creatorName}?"
	/// </summary>
	public override string LabelConfirmEnableFuturePayments(string placeName, string creatorName)
	{
		return $"¿Seguro que quieres activar los pagos futuros por tu versión VIP privada del juego {placeName} de {creatorName}?";
	}

	protected override string _GetTemplateForLabelConfirmEnableFuturePayments()
	{
		return "¿Seguro que quieres activar los pagos futuros por tu versión VIP privada del juego {placeName} de {creatorName}?";
	}

	/// <summary>
	/// Key: "Label.CreateVipServerFor"
	/// English String: "Create a VIP Server for {target}?"
	/// </summary>
	public override string LabelCreateVipServerFor(string target)
	{
		return $"¿Crear un servidor VIP por {target}?";
	}

	protected override string _GetTemplateForLabelCreateVipServerFor()
	{
		return "¿Crear un servidor VIP por {target}?";
	}

	/// <summary>
	/// Key: "Label.FooterText"
	/// English String: "Your balance after this transaction will be {robuxIcon}. This is a subscription-based feature. It will auto-renew once a month until you cancel the subscription."
	/// </summary>
	public override string LabelFooterText(string robuxIcon)
	{
		return $"Tu saldo después de esta transacción será de {robuxIcon}. Esta es una función de suscripción. Se renovará automáticamente una vez al mes hasta que canceles la suscripción.";
	}

	protected override string _GetTemplateForLabelFooterText()
	{
		return "Tu saldo después de esta transacción será de {robuxIcon}. Esta es una función de suscripción. Se renovará automáticamente una vez al mes hasta que canceles la suscripción.";
	}

	protected override string _GetTemplateForLabelGameJoinPrivateErrorTitle()
	{
		return "No se ha podido unirse";
	}

	protected override string _GetTemplateForLabelGameName()
	{
		return "Nombre del juego";
	}

	protected override string _GetTemplateForLabelNoVipServers()
	{
		return "No se han encontrado instancias del servidor VIP.";
	}

	protected override string _GetTemplateForLabelPlayWithOthers()
	{
		return "Juega a este juego con amigos y otras personas a las que invites.";
	}

	protected override string _GetTemplateForLabelRenew()
	{
		return "Renovar";
	}

	protected override string _GetTemplateForLabelRenewPrivateServer()
	{
		return "Renovar servidor privado";
	}

	/// <summary>
	/// Key: "Label.SeeAllServers"
	/// English String: "See all your VIP servers in the {serversLink} tab."
	/// </summary>
	public override string LabelSeeAllServers(string serversLink)
	{
		return $"Mira todos tus servidores VIP en la pestaña {serversLink}.";
	}

	protected override string _GetTemplateForLabelSeeAllServers()
	{
		return "Mira todos tus servidores VIP en la pestaña {serversLink}.";
	}

	protected override string _GetTemplateForLabelServerName()
	{
		return "Nombre del servidor";
	}

	protected override string _GetTemplateForLabelServers()
	{
		return "Servidores";
	}

	/// <summary>
	/// Key: "Label.StartRenewingPrice"
	/// English String: "This VIP Server will start renewing every month at {price} until you cancel."
	/// </summary>
	public override string LabelStartRenewingPrice(string price)
	{
		return $"Este servidor VIP empezará a renovarse cada mes por {price} hasta que lo canceles.";
	}

	protected override string _GetTemplateForLabelStartRenewingPrice()
	{
		return "Este servidor VIP empezará a renovarse cada mes por {price} hasta que lo canceles.";
	}

	protected override string _GetTemplateForLabelVIPServerGameJoinErrorAcknowledgement()
	{
		return "Aceptar";
	}

	protected override string _GetTemplateForLabelVipServerJoinGamePrivateError()
	{
		return "No puedes unirte a este servidor VIP porque el juego es privado.";
	}

	protected override string _GetTemplateForLabelVipServersAbout()
	{
		return "Los servidores VIP te permiten jugar a este juego en privado con tus amigos, tu clan ¡o las personas que invites!";
	}

	/// <summary>
	/// Key: "Label.VipServersNotSupported"
	/// English String: "This game does not support {vipServersLink}."
	/// </summary>
	public override string LabelVipServersNotSupported(string vipServersLink)
	{
		return $"Este juego no cuenta con {vipServersLink}.";
	}

	protected override string _GetTemplateForLabelVipServersNotSupported()
	{
		return "Este juego no cuenta con {vipServersLink}.";
	}

	protected override string _GetTemplateForMessageInvalidLink()
	{
		return "Este enlace al servidor VIP ya no es válido.";
	}
}
