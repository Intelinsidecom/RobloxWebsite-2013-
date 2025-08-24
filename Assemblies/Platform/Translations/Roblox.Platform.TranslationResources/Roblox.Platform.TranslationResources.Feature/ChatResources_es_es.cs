namespace Roblox.TranslationResources.Feature;

/// <summary>
/// This class overrides ChatResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class ChatResources_es_es : ChatResources_en_us, IChatResources, ITranslationResources
{
	/// <summary>
	/// Key: "Action.Add"
	/// English String: "Add"
	/// </summary>
	public override string ActionAdd => "Añadir";

	/// <summary>
	/// Key: "Action.BuyAccess"
	/// English String: "Buy Access"
	/// </summary>
	public override string ActionBuyAccess => "Comprar acceso";

	/// <summary>
	/// Key: "Action.Cancel"
	/// English String: "Cancel"
	/// </summary>
	public override string ActionCancel => "Cancelar";

	/// <summary>
	/// Key: "Action.Create"
	/// English String: "Create"
	/// </summary>
	public override string ActionCreate => "Crear";

	/// <summary>
	/// Key: "Action.Join"
	/// join the voice chat conversation
	/// English String: "Join"
	/// </summary>
	public override string ActionJoin => "Unirse";

	/// <summary>
	/// Key: "Action.JoinVoice"
	/// Join voice call
	/// English String: "Join"
	/// </summary>
	public override string ActionJoinVoice => "Unirse";

	/// <summary>
	/// Key: "Action.Leave"
	/// English String: "Leave"
	/// </summary>
	public override string ActionLeave => "Salir";

	/// <summary>
	/// Key: "Action.LeaveVoice"
	/// Leave voice chat
	/// English String: "Leave"
	/// </summary>
	public override string ActionLeaveVoice => "Salir";

	/// <summary>
	/// Key: "Action.Mute"
	/// mute microphone in short term
	/// English String: "Mute"
	/// </summary>
	public override string ActionMute => "Silenciar";

	/// <summary>
	/// Key: "Action.MuteMic"
	/// English String: "Mute Your Microphone"
	/// </summary>
	public override string ActionMuteMic => "Desactivar tu micrófono";

	/// <summary>
	/// Key: "Action.Remove"
	/// English String: "Remove"
	/// </summary>
	public override string ActionRemove => "Eliminar";

	/// <summary>
	/// Key: "Action.Report"
	/// English String: "Report"
	/// </summary>
	public override string ActionReport => "Denunciar";

	/// <summary>
	/// Key: "Action.Save"
	/// English String: "Save"
	/// </summary>
	public override string ActionSave => "Guardar";

	/// <summary>
	/// Key: "Action.Send"
	/// English String: "Send"
	/// </summary>
	public override string ActionSend => "Enviar";

	/// <summary>
	/// Key: "Action.Set"
	/// English String: "Set"
	/// </summary>
	public override string ActionSet => "Establecer";

	/// <summary>
	/// Key: "Action.StartParty"
	/// button label
	/// English String: "Start a Party"
	/// </summary>
	public override string ActionStartParty => "Formar un equipo";

	/// <summary>
	/// Key: "Action.Stay"
	/// English String: "Stay"
	/// </summary>
	public override string ActionStay => "Quedarse";

	/// <summary>
	/// Key: "Action.TurnOn"
	/// English String: "Turn On"
	/// </summary>
	public override string ActionTurnOn => "Activar";

	/// <summary>
	/// Key: "Action.Unmute"
	/// unmute mic in short term
	/// English String: "Unmute"
	/// </summary>
	public override string ActionUnmute => "No silenciar";

	/// <summary>
	/// Key: "Action.UnmuteMic"
	/// English String: "Unmute Your Microphone"
	/// </summary>
	public override string ActionUnmuteMic => "Reactivar tu micrófono";

	/// <summary>
	/// Key: "Description.JoinInVoiceChat"
	/// English String: "Click Join to join the call"
	/// </summary>
	public override string DescriptionJoinInVoiceChat => "Haz clic en Unirse para unirte a la llamada";

	/// <summary>
	/// Key: "Description.LeaveVoiceChat"
	/// English String: "Click Leave to leave the call"
	/// </summary>
	public override string DescriptionLeaveVoiceChat => "Haz clic en Salir para salir de la llamada";

	/// <summary>
	/// Key: "Description.UserInVoice"
	/// User is actively in voice chat
	/// English String: "You are in the voice chat"
	/// </summary>
	public override string DescriptionUserInVoice => "Estás en el chat de voz";

	/// <summary>
	/// Key: "Description.VoiceNotConnect"
	/// Error handling message when voice chat api return errors
	/// English String: "Could not connect to voice chat"
	/// </summary>
	public override string DescriptionVoiceNotConnect => "No se ha podido conectar al chat de voz";

	/// <summary>
	/// Key: "Heading.BuyItem"
	/// English String: "Buy Item"
	/// </summary>
	public override string HeadingBuyItem => "Comprar objeto";

	/// <summary>
	/// Key: "Heading.Chat"
	/// English String: "Chat"
	/// </summary>
	public override string HeadingChat => "Chat";

	public override string HeadingChatAndParty => "Chat y equipo";

	/// <summary>
	/// Key: "Heading.ConfirmLeaving"
	/// English String: "Are you sure to leave this chat group?"
	/// </summary>
	public override string HeadingConfirmLeaving => "¿Seguro que quieres salir de este grupo de chat?";

	/// <summary>
	/// Key: "Heading.ContinueToReport"
	/// English String: "Continue to report?"
	/// </summary>
	public override string HeadingContinueToReport => "¿Ver la denuncia?";

	/// <summary>
	/// Key: "Heading.CreateParty"
	/// English String: "Create Party"
	/// </summary>
	public override string HeadingCreateParty => "Crear equipo";

	/// <summary>
	/// Key: "Heading.LeaveChatGroup"
	/// English String: "Leave Chat Group"
	/// </summary>
	public override string HeadingLeaveChatGroup => "Salir del grupo de chat";

	/// <summary>
	/// Key: "Heading.LeaveChatGroupQ"
	/// English String: "Leave Chat Group?"
	/// </summary>
	public override string HeadingLeaveChatGroupQ => "¿Salir del grupo de chat?";

	/// <summary>
	/// Key: "Heading.NewChatGroup"
	/// English String: "New Chat Group"
	/// </summary>
	public override string HeadingNewChatGroup => "Nuevo grupo de chat";

	/// <summary>
	/// Key: "Heading.RemoveUser"
	/// English String: "Remove User?"
	/// </summary>
	public override string HeadingRemoveUser => "¿Eliminar usuario?";

	/// <summary>
	/// Key: "Heading.Report"
	/// heading for abuse report dialog
	/// English String: "Report"
	/// </summary>
	public override string HeadingReport => "Denunciar";

	/// <summary>
	/// Key: "Label.AddFriends"
	/// English String: "Add Friends"
	/// </summary>
	public override string LabelAddFriends => "Añadir amigos";

	/// <summary>
	/// Key: "Label.BuyButton"
	/// English String: "Buy"
	/// </summary>
	public override string LabelBuyButton => "Comprar";

	/// <summary>
	/// Key: "Label.ChangeChatGroupName"
	/// English String: "Change your chat group name"
	/// </summary>
	public override string LabelChangeChatGroupName => "Cambiar el nombre del grupo de chat";

	/// <summary>
	/// Key: "Label.ChatDetails"
	/// English String: "Chat Details"
	/// </summary>
	public override string LabelChatDetails => "Detalles del chat";

	/// <summary>
	/// Key: "Label.ChatGroupName"
	/// English String: "Chat Group Name"
	/// </summary>
	public override string LabelChatGroupName => "Nombre del grupo de chat";

	/// <summary>
	/// Key: "Label.Close"
	/// English String: "Close"
	/// </summary>
	public override string LabelClose => "Cerrar";

	/// <summary>
	/// Key: "Label.ConversationNotifications"
	/// conversation notification
	/// English String: "Notifications"
	/// </summary>
	public override string LabelConversationNotifications => "Notificaciones";

	/// <summary>
	/// Key: "Label.ConversationNotificationsOn"
	/// conversation notification is on
	/// English String: "On"
	/// </summary>
	public override string LabelConversationNotificationsOn => "Sí";

	/// <summary>
	/// Key: "Label.Details.PlayTogether"
	/// English String: "PlayTogether"
	/// </summary>
	public override string LabelDetailsPlayTogether => "Jugar juntos";

	/// <summary>
	/// Key: "Label.FindGame"
	/// English String: "Find Game"
	/// </summary>
	public override string LabelFindGame => "Buscar juego";

	/// <summary>
	/// Key: "Label.GameNotAvailableButton"
	/// English String: "Not Available"
	/// </summary>
	public override string LabelGameNotAvailableButton => "No disponible";

	/// <summary>
	/// Key: "Label.General"
	/// English String: "General"
	/// </summary>
	public override string LabelGeneral => "General";

	/// <summary>
	/// Key: "Label.InCall"
	/// In voice call
	/// English String: "In Call"
	/// </summary>
	public override string LabelInCall => "En una llamada";

	/// <summary>
	/// Key: "Label.InGame"
	/// English String: "In Game"
	/// </summary>
	public override string LabelInGame => "En un juego";

	/// <summary>
	/// Key: "Label.InputPlaceHolder.SearchForFriends"
	/// English String: "Search for friends"
	/// </summary>
	public override string LabelInputPlaceHolderSearchForFriends => "Buscar amigos";

	/// <summary>
	/// Key: "Label.InputPlaceHolder.SendMessage"
	/// English String: "Send a message"
	/// </summary>
	public override string LabelInputPlaceHolderSendMessage => "Enviar un mensaje";

	/// <summary>
	/// Key: "Label.InStudio"
	/// English String: "In Studio"
	/// </summary>
	public override string LabelInStudio => "En Studio";

	/// <summary>
	/// Key: "Label.JoinButton"
	/// English String: "Join"
	/// </summary>
	public override string LabelJoinButton => "Unirse";

	/// <summary>
	/// Key: "Label.JoinGame"
	/// English String: "Join Game"
	/// </summary>
	public override string LabelJoinGame => "Unirse al juego";

	/// <summary>
	/// Key: "Label.JoinParty"
	/// English String: "Join Party"
	/// </summary>
	public override string LabelJoinParty => "Unirse al equipo";

	/// <summary>
	/// Key: "Label.LeaveChatGroup"
	/// English String: "Leave Chat Group"
	/// </summary>
	public override string LabelLeaveChatGroup => "Salir del grupo de chat";

	/// <summary>
	/// Key: "Label.LeaveParty"
	/// English String: "Leave Party"
	/// </summary>
	public override string LabelLeaveParty => "Salir del equipo";

	/// <summary>
	/// Key: "Label.Member"
	/// English String: "Member"
	/// </summary>
	public override string LabelMember => "Miembro";

	/// <summary>
	/// Key: "Label.Members"
	/// English String: "Members"
	/// </summary>
	public override string LabelMembers => "Miembros";

	/// <summary>
	/// Key: "Label.Mute15Minutes"
	/// mute conversation for 15 mins
	/// English String: "For 15 minutes"
	/// </summary>
	public override string LabelMute15Minutes => "Por 15 minutos";

	/// <summary>
	/// Key: "Label.Mute1Hour"
	/// Mute conversation for 1 hour
	/// English String: "For an hour"
	/// </summary>
	public override string LabelMute1Hour => "Por 1 hora";

	/// <summary>
	/// Key: "Label.Mute24Hours"
	/// Mute conversation for a day
	/// English String: "For a day"
	/// </summary>
	public override string LabelMute24Hours => "Por 1 día";

	/// <summary>
	/// Key: "Label.Mute8Hours"
	/// Mute conversation for 8 hours
	/// English String: "For 8 hours"
	/// </summary>
	public override string LabelMute8Hours => "Por 8 horas";

	/// <summary>
	/// Key: "Label.MuteConversationNotificationsForGroup"
	/// English String: "Mute notifications for this chat group"
	/// </summary>
	public override string LabelMuteConversationNotificationsForGroup => "Silenciar las notificaciones para este grupo de chat";

	/// <summary>
	/// Key: "Label.MuteConversationNotificationsForOneToOne"
	/// English String: "Mute notifications for this conversation"
	/// </summary>
	public override string LabelMuteConversationNotificationsForOneToOne => "Silenciar las notificaciones para esta conversación";

	/// <summary>
	/// Key: "Label.MuteInfinite"
	/// Mute conversation until user turns back
	/// English String: "Until I turn them back on"
	/// </summary>
	public override string LabelMuteInfinite => "Hasta que yo las vuelva a activar";

	/// <summary>
	/// Key: "Label.NameYourChangeGroup"
	/// English String: "Name your change group"
	/// </summary>
	public override string LabelNameYourChangeGroup => "Poner nombre a tu grupo de chat";

	/// <summary>
	/// Key: "Label.NameYourChatGroup"
	/// English String: "Name your chat group"
	/// </summary>
	public override string LabelNameYourChatGroup => "Poner nombre al grupo de chat";

	/// <summary>
	/// Key: "Label.NotImplementedMessageType"
	/// This message is displayed in chat when user receives message type that can't be rendered by current app version and update is not available, yet (e.g. latest version was rolled back, or in deprecated Android native chat)
	/// English String: "This message could not be displayed."
	/// </summary>
	public override string LabelNotImplementedMessageType => "No se puede mostrar este mensaje.";

	/// <summary>
	/// Key: "Label.NotInCall"
	/// English String: "Not in call"
	/// </summary>
	public override string LabelNotInCall => "No está en la llamada";

	/// <summary>
	/// Key: "Label.Offline"
	/// English String: "Offline"
	/// </summary>
	public override string LabelOffline => "Sin conexión";

	/// <summary>
	/// Key: "Label.Online"
	/// English String: "Online"
	/// </summary>
	public override string LabelOnline => "Conectado";

	/// <summary>
	/// Key: "Label.PinGameTooltip"
	/// English String: "Pin Game"
	/// </summary>
	public override string LabelPinGameTooltip => "Anclar juego";

	/// <summary>
	/// Key: "Label.PinnedGame"
	/// This is a title of card, means this game card is pinned game
	/// English String: "Pinned Game"
	/// </summary>
	public override string LabelPinnedGame => "Juego anclado";

	/// <summary>
	/// Key: "Label.PlayButton"
	/// English String: "Play"
	/// </summary>
	public override string LabelPlayButton => "Jugar";

	/// <summary>
	/// Key: "Label.PlayGames"
	/// English String: "Play Games"
	/// </summary>
	public override string LabelPlayGames => "Jugar";

	/// <summary>
	/// Key: "Label.PlayTogether"
	/// English String: "Play Together"
	/// </summary>
	public override string LabelPlayTogether => "Jugar juntos";

	/// <summary>
	/// Key: "Label.RecommendedGames"
	/// English String: "Recommended"
	/// </summary>
	public override string LabelRecommendedGames => "Recomendados";

	/// <summary>
	/// Key: "Label.SeeLess"
	/// English String: "See Less"
	/// </summary>
	public override string LabelSeeLess => "Ver menos";

	/// <summary>
	/// Key: "Label.SeeMore"
	/// English String: "See More"
	/// </summary>
	public override string LabelSeeMore => "Ver más";

	/// <summary>
	/// Key: "Label.ShowLessGames"
	/// English String: "Show Less"
	/// </summary>
	public override string LabelShowLessGames => "Mostrar menos";

	/// <summary>
	/// Key: "Label.SpanTitle.CreateGroupNeeds2More"
	/// English String: "Add at least 2 people to create chat group"
	/// </summary>
	public override string LabelSpanTitleCreateGroupNeeds2More => "Añade al menos a 2\u00a0personas para crear un grupo de chat.";

	/// <summary>
	/// Key: "Label.SpanTitle.Loading"
	/// English String: "loading ..."
	/// </summary>
	public override string LabelSpanTitleLoading => "cargando...";

	/// <summary>
	/// Key: "Label.TimestampOffUntilTomorrow"
	/// English String: "Off until tomorrow"
	/// </summary>
	public override string LabelTimestampOffUntilTomorrow => "Desactivadas hasta mañana";

	/// <summary>
	/// Key: "Label.TimestampOffUntilTurnedBackOn"
	/// English String: "Off until turned back on\""
	/// </summary>
	public override string LabelTimestampOffUntilTurnedBackOn => "Desactivadas hasta que las vuelva a activar";

	/// <summary>
	/// Key: "Label.TurnOnConversationNotificationsPrompt"
	/// English String: "Do you want to turn on notifications?"
	/// </summary>
	public override string LabelTurnOnConversationNotificationsPrompt => "¿Quieres activar las notificaciones?";

	/// <summary>
	/// Key: "Label.UnpinGameTooltip"
	/// English String: "Unpin Game"
	/// </summary>
	public override string LabelUnpinGameTooltip => "Desanclar juego";

	/// <summary>
	/// Key: "Label.ViewDetailsButton"
	/// English String: "View Details"
	/// </summary>
	public override string LabelViewDetailsButton => "Ver detalles";

	/// <summary>
	/// Key: "Label.ViewProfile"
	/// English String: "View Profile"
	/// </summary>
	public override string LabelViewProfile => "Ver perfil";

	/// <summary>
	/// Key: "Label.VoiceSetting"
	/// Voice chat setting label
	/// English String: "Voice Settings"
	/// </summary>
	public override string LabelVoiceSetting => "Configuración de voz";

	/// <summary>
	/// Key: "Label.Yesterday"
	/// time stamp for chat message received yesterday
	/// English String: "Yesterday"
	/// </summary>
	public override string LabelYesterday => "Ayer";

	/// <summary>
	/// Key: "Message.ConversationTitleModerated"
	/// Chat group name was moderated.
	/// English String: "Chat group name was moderated."
	/// </summary>
	public override string MessageConversationTitleModerated => "El nombre del grupo de chat ha sido moderado.";

	/// <summary>
	/// Key: "Message.Default"
	/// English String: "Not everyone in this chat can see your message."
	/// </summary>
	public override string MessageDefault => "No todos los miembros del chat pueden ver tu mensaje.";

	/// <summary>
	/// Key: "Message.DefaultErrorMsg"
	/// English String: "An error occurred"
	/// </summary>
	public override string MessageDefaultErrorMsg => "Se ha producido un error.";

	/// <summary>
	/// Key: "Message.Error"
	/// English String: "Error"
	/// </summary>
	public override string MessageError => "Error";

	/// <summary>
	/// Key: "Message.JoinPartyText"
	/// English String: "The party leader is finding a game to play."
	/// </summary>
	public override string MessageJoinPartyText => "El líder del equipo está buscando una partida.";

	/// <summary>
	/// Key: "Message.MakeFriendsToChatNPlay"
	/// English String: "Make friends to start chatting and partying!"
	/// </summary>
	public override string MessageMakeFriendsToChatNPlay => "Haz amigos para empezar a chatear y a formar equipos.";

	/// <summary>
	/// Key: "Message.MessageContentModerated"
	/// English String: "Your message was moderated and not sent."
	/// </summary>
	public override string MessageMessageContentModerated => "Tu mensaje ha sido moderado y no se ha enviado.";

	/// <summary>
	/// Key: "Message.MessageFilterForReceivers"
	/// English String: "Not everyone in this chat can see your message."
	/// </summary>
	public override string MessageMessageFilterForReceivers => "No todos los miembros del chat pueden ver tu mensaje.";

	/// <summary>
	/// Key: "Message.NoConnectionMsg"
	/// English String: "Connecting..."
	/// </summary>
	public override string MessageNoConnectionMsg => "Conectando...";

	/// <summary>
	/// Key: "Message.PartyInviteMsg"
	/// English String: "PARTY INVITE!"
	/// </summary>
	public override string MessagePartyInviteMsg => "INVITACIÓN A UN EQUIPO";

	/// <summary>
	/// Key: "Message.PlayGameUpdate"
	/// English String: " is playing the pinned game: "
	/// </summary>
	public override string MessagePlayGameUpdate => " está jugando al juego anclado: ";

	/// <summary>
	/// Key: "Message.TextTooLong"
	/// English String: "Your message was too long and not sent."
	/// </summary>
	public override string MessageTextTooLong => "Tu mensaje era demasiado largo y no se ha enviado.";

	/// <summary>
	/// Key: "Message.UnknownMessageType"
	/// This serves as the fallback string for when an message type is received that the web chat does not know how to render.
	/// English String: "A message cannot be displayed"
	/// </summary>
	public override string MessageUnknownMessageType => "No se puede mostrar un mensaje";

	/// <summary>
	/// Key: "PlayButton"
	/// English String: "Play"
	/// </summary>
	public override string PlayButton => "Jugar";

	/// <summary>
	/// Key: "Response.PartyInvite"
	/// notification message
	/// English String: "You received a party Invite."
	/// </summary>
	public override string ResponsePartyInvite => "Has recibido una invitación para unirte a un equipo.";

	public ChatResources_es_es(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionAdd()
	{
		return "Añadir";
	}

	protected override string _GetTemplateForActionBuyAccess()
	{
		return "Comprar acceso";
	}

	protected override string _GetTemplateForActionCancel()
	{
		return "Cancelar";
	}

	protected override string _GetTemplateForActionCreate()
	{
		return "Crear";
	}

	protected override string _GetTemplateForActionJoin()
	{
		return "Unirse";
	}

	protected override string _GetTemplateForActionJoinVoice()
	{
		return "Unirse";
	}

	protected override string _GetTemplateForActionLeave()
	{
		return "Salir";
	}

	protected override string _GetTemplateForActionLeaveVoice()
	{
		return "Salir";
	}

	protected override string _GetTemplateForActionMute()
	{
		return "Silenciar";
	}

	protected override string _GetTemplateForActionMuteMic()
	{
		return "Desactivar tu micrófono";
	}

	protected override string _GetTemplateForActionRemove()
	{
		return "Eliminar";
	}

	protected override string _GetTemplateForActionReport()
	{
		return "Denunciar";
	}

	protected override string _GetTemplateForActionSave()
	{
		return "Guardar";
	}

	protected override string _GetTemplateForActionSend()
	{
		return "Enviar";
	}

	protected override string _GetTemplateForActionSet()
	{
		return "Establecer";
	}

	protected override string _GetTemplateForActionStartParty()
	{
		return "Formar un equipo";
	}

	protected override string _GetTemplateForActionStay()
	{
		return "Quedarse";
	}

	protected override string _GetTemplateForActionTurnOn()
	{
		return "Activar";
	}

	protected override string _GetTemplateForActionUnmute()
	{
		return "No silenciar";
	}

	protected override string _GetTemplateForActionUnmuteMic()
	{
		return "Reactivar tu micrófono";
	}

	protected override string _GetTemplateForDescriptionJoinInVoiceChat()
	{
		return "Haz clic en Unirse para unirte a la llamada";
	}

	protected override string _GetTemplateForDescriptionLeaveVoiceChat()
	{
		return "Haz clic en Salir para salir de la llamada";
	}

	protected override string _GetTemplateForDescriptionUserInVoice()
	{
		return "Estás en el chat de voz";
	}

	protected override string _GetTemplateForDescriptionVoiceNotConnect()
	{
		return "No se ha podido conectar al chat de voz";
	}

	protected override string _GetTemplateForHeadingBuyItem()
	{
		return "Comprar objeto";
	}

	protected override string _GetTemplateForHeadingChat()
	{
		return "Chat";
	}

	protected override string _GetTemplateForHeadingChatAndParty()
	{
		return "Chat y equipo";
	}

	protected override string _GetTemplateForHeadingConfirmLeaving()
	{
		return "¿Seguro que quieres salir de este grupo de chat?";
	}

	protected override string _GetTemplateForHeadingContinueToReport()
	{
		return "¿Ver la denuncia?";
	}

	protected override string _GetTemplateForHeadingCreateParty()
	{
		return "Crear equipo";
	}

	protected override string _GetTemplateForHeadingLeaveChatGroup()
	{
		return "Salir del grupo de chat";
	}

	protected override string _GetTemplateForHeadingLeaveChatGroupQ()
	{
		return "¿Salir del grupo de chat?";
	}

	protected override string _GetTemplateForHeadingNewChatGroup()
	{
		return "Nuevo grupo de chat";
	}

	protected override string _GetTemplateForHeadingRemoveUser()
	{
		return "¿Eliminar usuario?";
	}

	protected override string _GetTemplateForHeadingReport()
	{
		return "Denunciar";
	}

	protected override string _GetTemplateForLabelAddFriends()
	{
		return "Añadir amigos";
	}

	/// <summary>
	/// Key: "Label.BuyAccessToGameForModal"
	/// English String: "Would you like to buy access to the Place: {placeName} from {creatorName} for {robux}?"
	/// </summary>
	public override string LabelBuyAccessToGameForModal(string placeName, string creatorName, string robux)
	{
		return $"¿Quieres comprarle el acceso al lugar: {placeName} de {creatorName} por {robux}?";
	}

	protected override string _GetTemplateForLabelBuyAccessToGameForModal()
	{
		return "¿Quieres comprarle el acceso al lugar: {placeName} de {creatorName} por {robux}?";
	}

	protected override string _GetTemplateForLabelBuyButton()
	{
		return "Comprar";
	}

	protected override string _GetTemplateForLabelChangeChatGroupName()
	{
		return "Cambiar el nombre del grupo de chat";
	}

	protected override string _GetTemplateForLabelChatDetails()
	{
		return "Detalles del chat";
	}

	protected override string _GetTemplateForLabelChatGroupName()
	{
		return "Nombre del grupo de chat";
	}

	protected override string _GetTemplateForLabelClose()
	{
		return "Cerrar";
	}

	protected override string _GetTemplateForLabelConversationNotifications()
	{
		return "Notificaciones";
	}

	protected override string _GetTemplateForLabelConversationNotificationsOn()
	{
		return "Sí";
	}

	protected override string _GetTemplateForLabelDetailsPlayTogether()
	{
		return "Jugar juntos";
	}

	protected override string _GetTemplateForLabelFindGame()
	{
		return "Buscar juego";
	}

	protected override string _GetTemplateForLabelGameNotAvailableButton()
	{
		return "No disponible";
	}

	protected override string _GetTemplateForLabelGeneral()
	{
		return "General";
	}

	protected override string _GetTemplateForLabelInCall()
	{
		return "En una llamada";
	}

	protected override string _GetTemplateForLabelInGame()
	{
		return "En un juego";
	}

	protected override string _GetTemplateForLabelInputPlaceHolderSearchForFriends()
	{
		return "Buscar amigos";
	}

	protected override string _GetTemplateForLabelInputPlaceHolderSendMessage()
	{
		return "Enviar un mensaje";
	}

	protected override string _GetTemplateForLabelInStudio()
	{
		return "En Studio";
	}

	protected override string _GetTemplateForLabelJoinButton()
	{
		return "Unirse";
	}

	protected override string _GetTemplateForLabelJoinGame()
	{
		return "Unirse al juego";
	}

	protected override string _GetTemplateForLabelJoinParty()
	{
		return "Unirse al equipo";
	}

	protected override string _GetTemplateForLabelLeaveChatGroup()
	{
		return "Salir del grupo de chat";
	}

	protected override string _GetTemplateForLabelLeaveParty()
	{
		return "Salir del equipo";
	}

	protected override string _GetTemplateForLabelMember()
	{
		return "Miembro";
	}

	/// <summary>
	/// Key: "Label.MemberJoinText"
	/// English String: "{userName} joined the party"
	/// </summary>
	public override string LabelMemberJoinText(string userName)
	{
		return $"{userName} se ha unido al equipo.";
	}

	protected override string _GetTemplateForLabelMemberJoinText()
	{
		return "{userName} se ha unido al equipo.";
	}

	protected override string _GetTemplateForLabelMembers()
	{
		return "Miembros";
	}

	protected override string _GetTemplateForLabelMute15Minutes()
	{
		return "Por 15 minutos";
	}

	protected override string _GetTemplateForLabelMute1Hour()
	{
		return "Por 1 hora";
	}

	protected override string _GetTemplateForLabelMute24Hours()
	{
		return "Por 1 día";
	}

	protected override string _GetTemplateForLabelMute8Hours()
	{
		return "Por 8 horas";
	}

	protected override string _GetTemplateForLabelMuteConversationNotificationsForGroup()
	{
		return "Silenciar las notificaciones para este grupo de chat";
	}

	protected override string _GetTemplateForLabelMuteConversationNotificationsForOneToOne()
	{
		return "Silenciar las notificaciones para esta conversación";
	}

	protected override string _GetTemplateForLabelMuteInfinite()
	{
		return "Hasta que yo las vuelva a activar";
	}

	protected override string _GetTemplateForLabelNameYourChangeGroup()
	{
		return "Poner nombre a tu grupo de chat";
	}

	protected override string _GetTemplateForLabelNameYourChatGroup()
	{
		return "Poner nombre al grupo de chat";
	}

	protected override string _GetTemplateForLabelNotImplementedMessageType()
	{
		return "No se puede mostrar este mensaje.";
	}

	protected override string _GetTemplateForLabelNotInCall()
	{
		return "No está en la llamada";
	}

	protected override string _GetTemplateForLabelOffline()
	{
		return "Sin conexión";
	}

	protected override string _GetTemplateForLabelOnline()
	{
		return "Conectado";
	}

	/// <summary>
	/// Key: "Label.PartyLeaderTooltip"
	/// English String: "{userName} is the party leader"
	/// </summary>
	public override string LabelPartyLeaderTooltip(string userName)
	{
		return $"{userName} es el líder del equipo.";
	}

	protected override string _GetTemplateForLabelPartyLeaderTooltip()
	{
		return "{userName} es el líder del equipo.";
	}

	/// <summary>
	/// Key: "Label.PartyMemberTooltip"
	/// English String: "{userName} is in the party"
	/// </summary>
	public override string LabelPartyMemberTooltip(string userName)
	{
		return $"{userName} está en el equipo.";
	}

	protected override string _GetTemplateForLabelPartyMemberTooltip()
	{
		return "{userName} está en el equipo.";
	}

	/// <summary>
	/// Key: "Label.PartyName"
	/// English String: "Party : {title}"
	/// </summary>
	public override string LabelPartyName(string title)
	{
		return $"Equipo: {title}";
	}

	protected override string _GetTemplateForLabelPartyName()
	{
		return "Equipo: {title}";
	}

	/// <summary>
	/// Key: "Label.PendingMemberTooltip"
	/// English String: "{userName} is not in the party"
	/// </summary>
	public override string LabelPendingMemberTooltip(string userName)
	{
		return $"{userName} no está en el equipo.";
	}

	protected override string _GetTemplateForLabelPendingMemberTooltip()
	{
		return "{userName} no está en el equipo.";
	}

	protected override string _GetTemplateForLabelPinGameTooltip()
	{
		return "Anclar juego";
	}

	protected override string _GetTemplateForLabelPinnedGame()
	{
		return "Juego anclado";
	}

	protected override string _GetTemplateForLabelPlayButton()
	{
		return "Jugar";
	}

	protected override string _GetTemplateForLabelPlayGames()
	{
		return "Jugar";
	}

	/// <summary>
	/// Key: "Label.PlayingGame"
	/// English String: "Playing {game}"
	/// </summary>
	public override string LabelPlayingGame(string game)
	{
		return $"Jugando a {game}";
	}

	protected override string _GetTemplateForLabelPlayingGame()
	{
		return "Jugando a {game}";
	}

	protected override string _GetTemplateForLabelPlayTogether()
	{
		return "Jugar juntos";
	}

	protected override string _GetTemplateForLabelRecommendedGames()
	{
		return "Recomendados";
	}

	protected override string _GetTemplateForLabelSeeLess()
	{
		return "Ver menos";
	}

	protected override string _GetTemplateForLabelSeeMore()
	{
		return "Ver más";
	}

	protected override string _GetTemplateForLabelShowLessGames()
	{
		return "Mostrar menos";
	}

	/// <summary>
	/// Key: "Label.ShowMoreGames"
	/// English String: "Show More (+{count})"
	/// </summary>
	public override string LabelShowMoreGames(string count)
	{
		return $"Mostrar más (+{count})";
	}

	protected override string _GetTemplateForLabelShowMoreGames()
	{
		return "Mostrar más (+{count})";
	}

	protected override string _GetTemplateForLabelSpanTitleCreateGroupNeeds2More()
	{
		return "Añade al menos a 2\u00a0personas para crear un grupo de chat.";
	}

	protected override string _GetTemplateForLabelSpanTitleLoading()
	{
		return "cargando...";
	}

	/// <summary>
	/// Key: "Label.TimestampOffUntilCertainTime"
	/// English String: "Off until {timestamp}"
	/// </summary>
	public override string LabelTimestampOffUntilCertainTime(string timestamp)
	{
		return $"Desactivadas hasta {timestamp}";
	}

	protected override string _GetTemplateForLabelTimestampOffUntilCertainTime()
	{
		return "Desactivadas hasta {timestamp}";
	}

	protected override string _GetTemplateForLabelTimestampOffUntilTomorrow()
	{
		return "Desactivadas hasta mañana";
	}

	protected override string _GetTemplateForLabelTimestampOffUntilTurnedBackOn()
	{
		return "Desactivadas hasta que las vuelva a activar";
	}

	protected override string _GetTemplateForLabelTurnOnConversationNotificationsPrompt()
	{
		return "¿Quieres activar las notificaciones?";
	}

	protected override string _GetTemplateForLabelUnpinGameTooltip()
	{
		return "Desanclar juego";
	}

	protected override string _GetTemplateForLabelViewDetailsButton()
	{
		return "Ver detalles";
	}

	protected override string _GetTemplateForLabelViewProfile()
	{
		return "Ver perfil";
	}

	protected override string _GetTemplateForLabelVoiceSetting()
	{
		return "Configuración de voz";
	}

	protected override string _GetTemplateForLabelYesterday()
	{
		return "Ayer";
	}

	/// <summary>
	/// Key: "Message.ChatPrivacySetting"
	/// English String: "To chat with friends, turn on chat in your {frontLink}Privacy Settings{endLink}"
	/// </summary>
	public override string MessageChatPrivacySetting(string frontLink, string endLink)
	{
		return $"Para chatear con tus amigos, activa el chat en la {frontLink}configuración de privacidad{endLink}.";
	}

	protected override string _GetTemplateForMessageChatPrivacySetting()
	{
		return "Para chatear con tus amigos, activa el chat en la {frontLink}configuración de privacidad{endLink}.";
	}

	/// <summary>
	/// Key: "Message.conversationTitleChangedText"
	/// English String: "{userName} named the chat group: {groupName}"
	/// </summary>
	public override string MessageconversationTitleChangedText(string userName, string groupName)
	{
		return $"{userName} ha puesto un nombre al grupo de chat: {groupName}.";
	}

	protected override string _GetTemplateForMessageconversationTitleChangedText()
	{
		return "{userName} ha puesto un nombre al grupo de chat: {groupName}.";
	}

	protected override string _GetTemplateForMessageConversationTitleModerated()
	{
		return "El nombre del grupo de chat ha sido moderado.";
	}

	protected override string _GetTemplateForMessageDefault()
	{
		return "No todos los miembros del chat pueden ver tu mensaje.";
	}

	protected override string _GetTemplateForMessageDefaultErrorMsg()
	{
		return "Se ha producido un error.";
	}

	/// <summary>
	/// Key: "Message.DefaultTitleForMsg"
	/// English String: "{userName} says ..."
	/// </summary>
	public override string MessageDefaultTitleForMsg(string userName)
	{
		return $"{userName} dice...";
	}

	protected override string _GetTemplateForMessageDefaultTitleForMsg()
	{
		return "{userName} dice...";
	}

	/// <summary>
	/// Key: "Message.DefaultTitleForPartyInvite"
	/// English String: "Party invite from {userName}"
	/// </summary>
	public override string MessageDefaultTitleForPartyInvite(string userName)
	{
		return $"{userName} te ha invitado a un equipo";
	}

	protected override string _GetTemplateForMessageDefaultTitleForPartyInvite()
	{
		return "{userName} te ha invitado a un equipo";
	}

	protected override string _GetTemplateForMessageError()
	{
		return "Error";
	}

	/// <summary>
	/// Key: "Message.FindGameToPlay"
	/// English String: "{frontLink}Find Games{endLink} to play with your friends!"
	/// </summary>
	public override string MessageFindGameToPlay(string frontLink, string endLink)
	{
		return $"{frontLink}Busca juegos{endLink} para jugar con tus amigos.";
	}

	protected override string _GetTemplateForMessageFindGameToPlay()
	{
		return "{frontLink}Busca juegos{endLink} para jugar con tus amigos.";
	}

	protected override string _GetTemplateForMessageJoinPartyText()
	{
		return "El líder del equipo está buscando una partida.";
	}

	protected override string _GetTemplateForMessageMakeFriendsToChatNPlay()
	{
		return "Haz amigos para empezar a chatear y a formar equipos.";
	}

	protected override string _GetTemplateForMessageMessageContentModerated()
	{
		return "Tu mensaje ha sido moderado y no se ha enviado.";
	}

	protected override string _GetTemplateForMessageMessageFilterForReceivers()
	{
		return "No todos los miembros del chat pueden ver tu mensaje.";
	}

	protected override string _GetTemplateForMessageNoConnectionMsg()
	{
		return "Conectando...";
	}

	protected override string _GetTemplateForMessagePartyInviteMsg()
	{
		return "INVITACIÓN A UN EQUIPO";
	}

	/// <summary>
	/// Key: "Message.PinGameUpdate"
	/// users pinned game in conversation
	/// English String: "{userName} chose a game to play together: {gameName}"
	/// </summary>
	public override string MessagePinGameUpdate(string userName, string gameName)
	{
		return $"{userName} ha elegido un juego para jugar juntos: {gameName}";
	}

	protected override string _GetTemplateForMessagePinGameUpdate()
	{
		return "{userName} ha elegido un juego para jugar juntos: {gameName}";
	}

	protected override string _GetTemplateForMessagePlayGameUpdate()
	{
		return " está jugando al juego anclado: ";
	}

	protected override string _GetTemplateForMessageTextTooLong()
	{
		return "Tu mensaje era demasiado largo y no se ha enviado.";
	}

	/// <summary>
	/// Key: "Message.ToastText"
	/// English String: "You can have up to {friendNum} friends in chat group."
	/// </summary>
	public override string MessageToastText(string friendNum)
	{
		return $"Puedes tener hasta {friendNum}\u00a0amigos en un grupo de chat.";
	}

	protected override string _GetTemplateForMessageToastText()
	{
		return "Puedes tener hasta {friendNum}\u00a0amigos en un grupo de chat.";
	}

	protected override string _GetTemplateForMessageUnknownMessageType()
	{
		return "No se puede mostrar un mensaje";
	}

	protected override string _GetTemplateForPlayButton()
	{
		return "Jugar";
	}

	protected override string _GetTemplateForResponsePartyInvite()
	{
		return "Has recibido una invitación para unirte a un equipo.";
	}
}
