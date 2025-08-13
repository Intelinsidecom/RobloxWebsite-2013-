namespace Roblox.TranslationResources.Feature;

/// <summary>
/// This class overrides VIPServerResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class VIPServerResources_es_es : VIPServerResources_en_us, IVIPServerResources, ITranslationResources
{
	/// <summary>
	/// Key: "Action.Add"
	/// English String: "Add"
	/// </summary>
	public override string ActionAdd => "Añadir";

	/// <summary>
	/// Key: "Action.AddPlayers"
	/// English String: "Add Players"
	/// </summary>
	public override string ActionAddPlayers => "Añadir jugadores";

	/// <summary>
	/// Key: "Action.Cancel"
	/// English String: "Cancel"
	/// </summary>
	public override string ActionCancel => "Cancelar";

	/// <summary>
	/// Key: "Action.CancelPayments"
	/// English String: "Cancel Payments"
	/// </summary>
	public override string ActionCancelPayments => "Cancelar pagos";

	/// <summary>
	/// Key: "Action.ChangeName"
	/// English String: "Change Name"
	/// </summary>
	public override string ActionChangeName => "Cambiar nombre";

	/// <summary>
	/// Key: "Action.GoBack"
	/// English String: "Go Back"
	/// </summary>
	public override string ActionGoBack => "Volver";

	/// <summary>
	/// Key: "Action.RegenerateJoinLink"
	/// English String: "Regenerate"
	/// </summary>
	public override string ActionRegenerateJoinLink => "Regenerar";

	/// <summary>
	/// Key: "Action.Remove"
	/// English String: "Remove"
	/// </summary>
	public override string ActionRemove => "Eliminar";

	/// <summary>
	/// Key: "Action.RenewVipServer"
	/// English String: "Renew VIP Server"
	/// </summary>
	public override string ActionRenewVipServer => "Renovar el servidor VIP";

	/// <summary>
	/// Key: "Action.SeeAll"
	/// English String: "See All"
	/// </summary>
	public override string ActionSeeAll => "Ver todo";

	/// <summary>
	/// Key: "Heading.CancelPayments"
	/// English String: "Cancel Payments"
	/// </summary>
	public override string HeadingCancelPayments => "Cancelar pagos";

	/// <summary>
	/// Key: "Heading.ChangeName"
	/// English String: "Change VIP Server Name"
	/// </summary>
	public override string HeadingChangeName => "Cambiar el nombre del servidor VIP";

	/// <summary>
	/// Key: "Heading.ConfigureVipServer"
	/// English String: "Configure VIP Server"
	/// </summary>
	public override string HeadingConfigureVipServer => "Configuración del servidor VIP";

	/// <summary>
	/// Key: "Heading.RemovePlayer"
	/// English String: "Remove Player"
	/// </summary>
	public override string HeadingRemovePlayer => "Eliminar jugador";

	/// <summary>
	/// Key: "Heading.RenewVipServer"
	/// English String: "Renew VIP Server"
	/// </summary>
	public override string HeadingRenewVipServer => "Renovar el servidor VIP";

	/// <summary>
	/// Key: "Label.ChangeNamePlaceholder"
	/// English String: "VIP Server Name (1-50 Characters)"
	/// </summary>
	public override string LabelChangeNamePlaceholder => "Nombre del servidor VIP (entre 1 y 50 caracteres)";

	/// <summary>
	/// Key: "Label.ClanAccess"
	/// English String: "Clan Access"
	/// </summary>
	public override string LabelClanAccess => "Acceso al clan";

	/// <summary>
	/// Key: "Label.FriendsAllowed"
	/// English String: "Friends Allowed"
	/// </summary>
	public override string LabelFriendsAllowed => "Amigos permitidos";

	/// <summary>
	/// Key: "Label.GameName"
	/// English String: "Game Name"
	/// </summary>
	public override string LabelGameName => "Nombre del juego";

	/// <summary>
	/// Key: "Label.JoinGameLink"
	/// English String: "Join Game Link..."
	/// </summary>
	public override string LabelJoinGameLink => "Unirse al enlace del juego...";

	/// <summary>
	/// Key: "Label.None"
	/// English String: "None"
	/// </summary>
	public override string LabelNone => "Ninguno";

	/// <summary>
	/// Key: "Label.Off"
	/// English String: "Off"
	/// </summary>
	public override string LabelOff => "No";

	/// <summary>
	/// Key: "Label.On"
	/// English String: "On"
	/// </summary>
	public override string LabelOn => "Sí";

	/// <summary>
	/// Key: "Label.PickEnemyClan"
	/// English String: "Pick Enemy Clan"
	/// </summary>
	public override string LabelPickEnemyClan => "Elegir clan enemigo";

	/// <summary>
	/// Key: "Label.SearchForPlayers"
	/// English String: "Search for Players"
	/// </summary>
	public override string LabelSearchForPlayers => "Buscar jugadores";

	/// <summary>
	/// Key: "Label.Server"
	/// English String: "Server"
	/// </summary>
	public override string LabelServer => "Servidor";

	/// <summary>
	/// Key: "Label.ServerMembers"
	/// English String: "Server Members"
	/// </summary>
	public override string LabelServerMembers => "Miembros del servidor";

	/// <summary>
	/// Key: "Label.SubscriptionStatus"
	/// English String: "Subscription Status"
	/// </summary>
	public override string LabelSubscriptionStatus => "Estado de la suscripción";

	/// <summary>
	/// Key: "Label.VIPServerLink"
	/// English String: "VIP Server Link"
	/// </summary>
	public override string LabelVIPServerLink => "Enlace del servidor VIP";

	/// <summary>
	/// Key: "Label.VIPServerStatus"
	/// English String: "VIP Server Status"
	/// </summary>
	public override string LabelVIPServerStatus => "Estado del servidor VIP";

	/// <summary>
	/// Key: "Label.YourClan"
	/// English String: "Your Clan"
	/// </summary>
	public override string LabelYourClan => "Tu clan";

	public VIPServerResources_es_es(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionAdd()
	{
		return "Añadir";
	}

	protected override string _GetTemplateForActionAddPlayers()
	{
		return "Añadir jugadores";
	}

	protected override string _GetTemplateForActionCancel()
	{
		return "Cancelar";
	}

	protected override string _GetTemplateForActionCancelPayments()
	{
		return "Cancelar pagos";
	}

	protected override string _GetTemplateForActionChangeName()
	{
		return "Cambiar nombre";
	}

	protected override string _GetTemplateForActionGoBack()
	{
		return "Volver";
	}

	protected override string _GetTemplateForActionRegenerateJoinLink()
	{
		return "Regenerar";
	}

	protected override string _GetTemplateForActionRemove()
	{
		return "Eliminar";
	}

	protected override string _GetTemplateForActionRenewVipServer()
	{
		return "Renovar el servidor VIP";
	}

	protected override string _GetTemplateForActionSeeAll()
	{
		return "Ver todo";
	}

	protected override string _GetTemplateForHeadingCancelPayments()
	{
		return "Cancelar pagos";
	}

	protected override string _GetTemplateForHeadingChangeName()
	{
		return "Cambiar el nombre del servidor VIP";
	}

	protected override string _GetTemplateForHeadingConfigureVipServer()
	{
		return "Configuración del servidor VIP";
	}

	protected override string _GetTemplateForHeadingRemovePlayer()
	{
		return "Eliminar jugador";
	}

	protected override string _GetTemplateForHeadingRenewVipServer()
	{
		return "Renovar el servidor VIP";
	}

	/// <summary>
	/// Key: "Label.ChangeNameBodyMessage"
	/// English String: "Are you sure you want to cancel future payments for your VIP Server of {name} by {creator}? If you cancel, your VIP Server will be deactivated on {date}."
	/// </summary>
	public override string LabelChangeNameBodyMessage(string name, string creator, string date)
	{
		return $"¿Seguro que quieres cancelar los pagos futuros para tu servidor VIP {name} de {creator}? Si los cancelas, tu servidor VIP se desactivará el {date}.";
	}

	protected override string _GetTemplateForLabelChangeNameBodyMessage()
	{
		return "¿Seguro que quieres cancelar los pagos futuros para tu servidor VIP {name} de {creator}? Si los cancelas, tu servidor VIP se desactivará el {date}.";
	}

	protected override string _GetTemplateForLabelChangeNamePlaceholder()
	{
		return "Nombre del servidor VIP (entre 1 y 50 caracteres)";
	}

	protected override string _GetTemplateForLabelClanAccess()
	{
		return "Acceso al clan";
	}

	protected override string _GetTemplateForLabelFriendsAllowed()
	{
		return "Amigos permitidos";
	}

	protected override string _GetTemplateForLabelGameName()
	{
		return "Nombre del juego";
	}

	protected override string _GetTemplateForLabelJoinGameLink()
	{
		return "Unirse al enlace del juego...";
	}

	protected override string _GetTemplateForLabelNone()
	{
		return "Ninguno";
	}

	protected override string _GetTemplateForLabelOff()
	{
		return "No";
	}

	protected override string _GetTemplateForLabelOn()
	{
		return "Sí";
	}

	protected override string _GetTemplateForLabelPickEnemyClan()
	{
		return "Elegir clan enemigo";
	}

	/// <summary>
	/// Key: "Label.RemovePlayerBodyMessage"
	/// English String: "Are you sure you want to remove {name} from your VIP Server? They will no longer be able to join your VIP Server."
	/// </summary>
	public override string LabelRemovePlayerBodyMessage(string name)
	{
		return $"¿Seguro que quieres eliminar a {name} de tu servidor VIP? Ya no podrá unirse a él.";
	}

	protected override string _GetTemplateForLabelRemovePlayerBodyMessage()
	{
		return "¿Seguro que quieres eliminar a {name} de tu servidor VIP? Ya no podrá unirse a él.";
	}

	/// <summary>
	/// Key: "Label.RenewVipServerBodyMessageConfirmation"
	/// English String: "Are you sure you want to enable future payments for your VIP Server of {name} by {creator}?"
	/// </summary>
	public override string LabelRenewVipServerBodyMessageConfirmation(string name, string creator)
	{
		return $"¿Seguro que quieres activar los pagos futuros para tu servidor VIP {name} de {creator}?";
	}

	protected override string _GetTemplateForLabelRenewVipServerBodyMessageConfirmation()
	{
		return "¿Seguro que quieres activar los pagos futuros para tu servidor VIP {name} de {creator}?";
	}

	/// <summary>
	/// Key: "Label.RenewVipServerBodyMessageStart"
	/// English String: "This VIP Server will start renewing every month at {date} until you cancel."
	/// </summary>
	public override string LabelRenewVipServerBodyMessageStart(string date)
	{
		return $"Este servidor VIP empezará a renovarse cada mes por {date} hasta que lo canceles.";
	}

	protected override string _GetTemplateForLabelRenewVipServerBodyMessageStart()
	{
		return "Este servidor VIP empezará a renovarse cada mes por {date} hasta que lo canceles.";
	}

	protected override string _GetTemplateForLabelSearchForPlayers()
	{
		return "Buscar jugadores";
	}

	protected override string _GetTemplateForLabelServer()
	{
		return "Servidor";
	}

	/// <summary>
	/// Key: "Label.ServerExpirationDate"
	/// English String: "Your VIP Server expired on{date}"
	/// </summary>
	public override string LabelServerExpirationDate(string date)
	{
		return $"Tu servidor VIP caducó el {date}";
	}

	protected override string _GetTemplateForLabelServerExpirationDate()
	{
		return "Tu servidor VIP caducó el {date}";
	}

	protected override string _GetTemplateForLabelServerMembers()
	{
		return "Miembros del servidor";
	}

	/// <summary>
	/// Key: "Label.SubscriptionChargeDate"
	/// English String: "You will be charged again on {date}"
	/// </summary>
	public override string LabelSubscriptionChargeDate(string date)
	{
		return $"Se te cobrará nuevamente el {date}";
	}

	protected override string _GetTemplateForLabelSubscriptionChargeDate()
	{
		return "Se te cobrará nuevamente el {date}";
	}

	/// <summary>
	/// Key: "Label.SubscriptionMonthlyPaymentDue"
	/// English String: "Your VIP Server monthly payment is {value}"
	/// </summary>
	public override string LabelSubscriptionMonthlyPaymentDue(string value)
	{
		return $"El pago mensual de tu servidor VIP es de {value}";
	}

	protected override string _GetTemplateForLabelSubscriptionMonthlyPaymentDue()
	{
		return "El pago mensual de tu servidor VIP es de {value}";
	}

	protected override string _GetTemplateForLabelSubscriptionStatus()
	{
		return "Estado de la suscripción";
	}

	protected override string _GetTemplateForLabelVIPServerLink()
	{
		return "Enlace del servidor VIP";
	}

	protected override string _GetTemplateForLabelVIPServerStatus()
	{
		return "Estado del servidor VIP";
	}

	protected override string _GetTemplateForLabelYourClan()
	{
		return "Tu clan";
	}
}
