namespace Roblox.TranslationResources.Notifications;

/// <summary>
/// This class overrides NotificationStreamResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class NotificationStreamResources_es_es : NotificationStreamResources_en_us, INotificationStreamResources, ITranslationResources
{
	/// <summary>
	/// Key: "Action.Accept"
	/// English String: "Accept"
	/// </summary>
	public override string ActionAccept => "Aceptar";

	/// <summary>
	/// Key: "Action.Cancel"
	/// English String: "Cancel"
	/// </summary>
	public override string ActionCancel => "Cancelar";

	/// <summary>
	/// Key: "Action.Chat"
	/// English String: "Chat"
	/// </summary>
	public override string ActionChat => "Chat";

	/// <summary>
	/// Key: "Action.Ignore"
	/// English String: "Ignore"
	/// </summary>
	public override string ActionIgnore => "Ignorar";

	/// <summary>
	/// Key: "Action.Play"
	/// Label for button to launch game.
	/// English String: "Play"
	/// </summary>
	public override string ActionPlay => "Jugar";

	/// <summary>
	/// Key: "Action.ReportAbuse"
	/// Label for link to report a game update message
	/// English String: "Report Abuse"
	/// </summary>
	public override string ActionReportAbuse => "Denunciar abuso";

	/// <summary>
	/// Key: "Action.Undo"
	/// Label for Undo link to reverse the unfollow action
	/// English String: "Undo"
	/// </summary>
	public override string ActionUndo => "Deshacer";

	/// <summary>
	/// Key: "Action.View"
	/// English String: "View"
	/// </summary>
	public override string ActionView => "Ver";

	/// <summary>
	/// Key: "Action.ViewAll"
	/// English String: "View All"
	/// </summary>
	public override string ActionViewAll => "Ver todo";

	/// <summary>
	/// Key: "Heading.BackToAllNotifications"
	/// Heading displayed in game updates view, containing back link to notifications main view.
	/// English String: "All Notifications"
	/// </summary>
	public override string HeadingBackToAllNotifications => "Todas las notificaciones";

	/// <summary>
	/// Key: "Label.NoNetworkConnectionText"
	/// English String: "Connecting..."
	/// </summary>
	public override string LabelNoNetworkConnectionText => "Conectando...";

	/// <summary>
	/// Key: "Label.NoNotifications"
	/// English String: "No Notifications"
	/// </summary>
	public override string LabelNoNotifications => "No hay notificaciones";

	/// <summary>
	/// Key: "Label.Notifications"
	/// English String: "Notifications"
	/// </summary>
	public override string LabelNotifications => "Notificaciones";

	/// <summary>
	/// Key: "Label.Settings"
	/// English String: "Settings"
	/// </summary>
	public override string LabelSettings => "Configuración";

	/// <summary>
	/// Key: "Message.GameNotPlayableOnDevice"
	/// Message displayed on game update card when the game is not playable on the device type.
	/// English String: "Not playable on this device"
	/// </summary>
	public override string MessageGameNotPlayableOnDevice => "No se puede reproducir en este dispositivo";

	/// <summary>
	/// Key: "Message.TooManyFriendsOther"
	/// English String: "That user already has the max number of friends."
	/// </summary>
	public override string MessageTooManyFriendsOther => "Ese usuario ya tiene el máximo número de amigos.";

	/// <summary>
	/// Key: "Message.TooManyFriendsSelf"
	/// English String: "You already have the max number of friends."
	/// </summary>
	public override string MessageTooManyFriendsSelf => "Ya tienes el máximo número de amigos.";

	public NotificationStreamResources_es_es(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionAccept()
	{
		return "Aceptar";
	}

	protected override string _GetTemplateForActionCancel()
	{
		return "Cancelar";
	}

	protected override string _GetTemplateForActionChat()
	{
		return "Chat";
	}

	protected override string _GetTemplateForActionIgnore()
	{
		return "Ignorar";
	}

	protected override string _GetTemplateForActionPlay()
	{
		return "Jugar";
	}

	protected override string _GetTemplateForActionReportAbuse()
	{
		return "Denunciar abuso";
	}

	protected override string _GetTemplateForActionUndo()
	{
		return "Deshacer";
	}

	/// <summary>
	/// Key: "Action.UnfollowGame"
	/// Label of menu item to unfollow the game
	/// English String: "Unfollow {gameName}"
	/// </summary>
	public override string ActionUnfollowGame(string gameName)
	{
		return $"Dejar de seguir {gameName}";
	}

	protected override string _GetTemplateForActionUnfollowGame()
	{
		return "Dejar de seguir {gameName}";
	}

	protected override string _GetTemplateForActionView()
	{
		return "Ver";
	}

	protected override string _GetTemplateForActionViewAll()
	{
		return "Ver todo";
	}

	protected override string _GetTemplateForHeadingBackToAllNotifications()
	{
		return "Todas las notificaciones";
	}

	protected override string _GetTemplateForLabelNoNetworkConnectionText()
	{
		return "Conectando...";
	}

	protected override string _GetTemplateForLabelNoNotifications()
	{
		return "No hay notificaciones";
	}

	protected override string _GetTemplateForLabelNotifications()
	{
		return "Notificaciones";
	}

	protected override string _GetTemplateForLabelSettings()
	{
		return "Configuración";
	}

	/// <summary>
	/// Key: "Message.AggregatedGameUpdateDouble"
	/// Message displayed on aggregated game update notification card, when there are exactly two games sending update.
	/// English String: "{gameOne} and {gameTwo} sent updates."
	/// </summary>
	public override string MessageAggregatedGameUpdateDouble(string gameOne, string gameTwo)
	{
		return $"{gameOne} y {gameTwo} han enviado actualizaciones.";
	}

	protected override string _GetTemplateForMessageAggregatedGameUpdateDouble()
	{
		return "{gameOne} y {gameTwo} han enviado actualizaciones.";
	}

	protected override string _GetTemplateForMessageAggregatedGameUpdateMultiple()
	{
		return "{gameOne}, {gameTwo}, and {otherCount, plural, =1 {# otro juego} other {# otros juegos}} enviaron actualizaciones.";
	}

	/// <summary>
	/// Key: "Message.ConfirmAcceptedDouble"
	/// English String: "{userOne} and {userTwo}"
	/// </summary>
	public override string MessageConfirmAcceptedDouble(string userOne, string userTwo)
	{
		return $"{userOne} y {userTwo}";
	}

	protected override string _GetTemplateForMessageConfirmAcceptedDouble()
	{
		return "{userOne} y {userTwo}";
	}

	protected override string _GetTemplateForMessageConfirmAcceptedMultiple()
	{
		return "{userOne}, {userTwo} y {userMultipleCount, plural, =1 {#\u00a0más} other {#\u00a0más}}";
	}

	/// <summary>
	/// Key: "Message.ConfirmAcceptedSingle"
	/// English String: "{userOne}"
	/// </summary>
	public override string MessageConfirmAcceptedSingle(string userOne)
	{
		return $"{userOne}";
	}

	protected override string _GetTemplateForMessageConfirmAcceptedSingle()
	{
		return "{userOne}";
	}

	/// <summary>
	/// Key: "Message.ConfirmSentDouble"
	/// English String: "{userOne} and {userTwo} are now your friends!"
	/// </summary>
	public override string MessageConfirmSentDouble(string userOne, string userTwo)
	{
		return $"¡Has trabado amistad {userOne} y {userTwo}!";
	}

	protected override string _GetTemplateForMessageConfirmSentDouble()
	{
		return "¡Has trabado amistad {userOne} y {userTwo}!";
	}

	protected override string _GetTemplateForMessageConfirmSentMultiple()
	{
		return "¡Has trabado amistad con {userOne}, {userTwo} y {userMultipleCount, plural, =1 {#\u00a0más} other {#\u00a0más}}!";
	}

	/// <summary>
	/// Key: "Message.ConfirmSentSingle"
	/// English String: "{userOne} is now your friend!"
	/// </summary>
	public override string MessageConfirmSentSingle(string userOne)
	{
		return $"¡Has trabado amistad con {userOne}!";
	}

	protected override string _GetTemplateForMessageConfirmSentSingle()
	{
		return "¡Has trabado amistad con {userOne}!";
	}

	/// <summary>
	/// Key: "Message.DeveloperMetricsAvailable"
	/// English String: "{month} {year} Analytics Report for {gameName} available."
	/// </summary>
	public override string MessageDeveloperMetricsAvailable(string month, string year, string gameName)
	{
		return $"Informe analítico de {month} de {year} disponible para {gameName}.";
	}

	protected override string _GetTemplateForMessageDeveloperMetricsAvailable()
	{
		return "Informe analítico de {month} de {year} disponible para {gameName}.";
	}

	protected override string _GetTemplateForMessageDeveloperMetricsAvailableMultiple()
	{
		return "Informe analítico de {month} de {year} disponible para {gameName} y {otherCount, plural, =1 {# otro juego} other {# otros juegos}}";
	}

	/// <summary>
	/// Key: "Message.DeveloperMetricsAvailableMultiple2"
	/// English String: "{month} {year} Analytics Report for {gameCount} games available."
	/// </summary>
	public override string MessageDeveloperMetricsAvailableMultiple2(string month, string year, string gameCount)
	{
		return $"Informe analítico de {month} de {year} disponible para {gameCount} juegos.";
	}

	protected override string _GetTemplateForMessageDeveloperMetricsAvailableMultiple2()
	{
		return "Informe analítico de {month} de {year} disponible para {gameCount} juegos.";
	}

	/// <summary>
	/// Key: "Message.FriendRequestAcceptedDouble"
	/// English String: "{userOne} and {userTwo} accepted your friend request."
	/// </summary>
	public override string MessageFriendRequestAcceptedDouble(string userOne, string userTwo)
	{
		return $"{userOne} y {userTwo} han aceptado tus solicitudes de amistad.";
	}

	protected override string _GetTemplateForMessageFriendRequestAcceptedDouble()
	{
		return "{userOne} y {userTwo} han aceptado tus solicitudes de amistad.";
	}

	protected override string _GetTemplateForMessageFriendRequestAcceptedMultiple()
	{
		return "{userOne}, {userTwo} y {userMultipleCount, plural, =1 {#\u00a0más} other {#\u00a0más}} han aceptado tus solicitudes de amistad.";
	}

	/// <summary>
	/// Key: "Message.FriendRequestAcceptedSingle"
	/// English String: "{userOne} accepted your friend request."
	/// </summary>
	public override string MessageFriendRequestAcceptedSingle(string userOne)
	{
		return $"{userOne} ha aceptado tu solicitud de amistad.";
	}

	protected override string _GetTemplateForMessageFriendRequestAcceptedSingle()
	{
		return "{userOne} ha aceptado tu solicitud de amistad.";
	}

	/// <summary>
	/// Key: "Message.FriendRequestSentDouble"
	/// English String: "{userOne} and {userTwo} sent you friend requests."
	/// </summary>
	public override string MessageFriendRequestSentDouble(string userOne, string userTwo)
	{
		return $"{userOne} y {userTwo} te han enviado solicitudes de amistad.";
	}

	protected override string _GetTemplateForMessageFriendRequestSentDouble()
	{
		return "{userOne} y {userTwo} te han enviado solicitudes de amistad.";
	}

	protected override string _GetTemplateForMessageFriendRequestSentMultiple()
	{
		return "{userOne}, {userTwo} y {userMultipleCount, plural, =1 {#\u00a0más} other {#\u00a0más}} te han enviado solicitudes de amistad.";
	}

	/// <summary>
	/// Key: "Message.FriendRequestSentSingle"
	/// English String: "{userOne} sent you a friend request."
	/// </summary>
	public override string MessageFriendRequestSentSingle(string userOne)
	{
		return $"{userOne} te ha enviado una solicitud de amistad.";
	}

	protected override string _GetTemplateForMessageFriendRequestSentSingle()
	{
		return "{userOne} te ha enviado una solicitud de amistad.";
	}

	protected override string _GetTemplateForMessageGameNotPlayableOnDevice()
	{
		return "No se puede reproducir en este dispositivo";
	}

	/// <summary>
	/// Key: "Message.MessageAndPreview"
	/// English String: "{titleStart}Message from {username}:{titleEnd} {message}"
	/// </summary>
	public override string MessageMessageAndPreview(string titleStart, string username, string titleEnd, string message)
	{
		return $"{titleStart}Mensaje de {username}:{titleEnd} {message}";
	}

	protected override string _GetTemplateForMessageMessageAndPreview()
	{
		return "{titleStart}Mensaje de {username}:{titleEnd} {message}";
	}

	/// <summary>
	/// Key: "Message.MessageFrom"
	/// English String: "Message from {username}:"
	/// </summary>
	public override string MessageMessageFrom(string username)
	{
		return $"Mensaje de {username}:";
	}

	protected override string _GetTemplateForMessageMessageFrom()
	{
		return "Mensaje de {username}:";
	}

	protected override string _GetTemplateForMessageNumberofNewNotifications()
	{
		return "{notificationCount, plural, =1 {#\u00a0nueva notificación} other {#\u00a0notificaciones nuevas}}";
	}

	protected override string _GetTemplateForMessageTooManyFriendsOther()
	{
		return "Ese usuario ya tiene el máximo número de amigos.";
	}

	protected override string _GetTemplateForMessageTooManyFriendsSelf()
	{
		return "Ya tienes el máximo número de amigos.";
	}

	/// <summary>
	/// Key: "Message.UnfollowedGame"
	/// Message displayed in game update card after user unfollowed the game
	/// English String: "Unfollowed {gameName}"
	/// </summary>
	public override string MessageUnfollowedGame(string gameName)
	{
		return $"Has dejado de seguir {gameName}";
	}

	protected override string _GetTemplateForMessageUnfollowedGame()
	{
		return "Has dejado de seguir {gameName}";
	}

	protected override string _GetTemplateForMessageYouHaveNewFriendRequests()
	{
		return "Tienes {numberOfRequests} {numberOfRequests, plural, =1 {nueva solicitud de amistad} other {nuevas solicitudes de amistad}}.";
	}

	protected override string _GetTemplateForMessageYouHaveNewFriends()
	{
		return "Tienes {numberOfFriends} {numberOfFriends, plural, =1 {nuevo amigo} other {nuevos amigos}}.";
	}

	protected override string _GetTemplateForMessageYouReceivedMessages()
	{
		return "Has recibido {numberOfMessagesText}\u00a0{numberOfMessages, plural, =1 {mensaje} other {mensajes}}.";
	}
}
