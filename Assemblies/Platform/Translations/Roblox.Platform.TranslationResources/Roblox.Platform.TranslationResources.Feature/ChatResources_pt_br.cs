namespace Roblox.TranslationResources.Feature;

/// <summary>
/// This class overrides ChatResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class ChatResources_pt_br : ChatResources_en_us, IChatResources, ITranslationResources
{
	/// <summary>
	/// Key: "Action.Add"
	/// English String: "Add"
	/// </summary>
	public override string ActionAdd => "Adicionar";

	/// <summary>
	/// Key: "Action.BuyAccess"
	/// English String: "Buy Access"
	/// </summary>
	public override string ActionBuyAccess => "Comprar acesso";

	/// <summary>
	/// Key: "Action.Cancel"
	/// English String: "Cancel"
	/// </summary>
	public override string ActionCancel => "Cancelar";

	/// <summary>
	/// Key: "Action.Create"
	/// English String: "Create"
	/// </summary>
	public override string ActionCreate => "Criar";

	/// <summary>
	/// Key: "Action.Join"
	/// join the voice chat conversation
	/// English String: "Join"
	/// </summary>
	public override string ActionJoin => "Entrar";

	/// <summary>
	/// Key: "Action.Leave"
	/// English String: "Leave"
	/// </summary>
	public override string ActionLeave => "Sair";

	/// <summary>
	/// Key: "Action.Remove"
	/// English String: "Remove"
	/// </summary>
	public override string ActionRemove => "Remover";

	/// <summary>
	/// Key: "Action.Report"
	/// English String: "Report"
	/// </summary>
	public override string ActionReport => "Denunciar";

	/// <summary>
	/// Key: "Action.Save"
	/// English String: "Save"
	/// </summary>
	public override string ActionSave => "Salvar";

	/// <summary>
	/// Key: "Action.Send"
	/// English String: "Send"
	/// </summary>
	public override string ActionSend => "Enviar";

	/// <summary>
	/// Key: "Action.Set"
	/// English String: "Set"
	/// </summary>
	public override string ActionSet => "Configurar";

	/// <summary>
	/// Key: "Action.StartParty"
	/// button label
	/// English String: "Start a Party"
	/// </summary>
	public override string ActionStartParty => "Iniciar time";

	/// <summary>
	/// Key: "Action.Stay"
	/// English String: "Stay"
	/// </summary>
	public override string ActionStay => "Ficar";

	/// <summary>
	/// Key: "Action.TurnOn"
	/// English String: "Turn On"
	/// </summary>
	public override string ActionTurnOn => "Ativar";

	/// <summary>
	/// Key: "Heading.BuyItem"
	/// English String: "Buy Item"
	/// </summary>
	public override string HeadingBuyItem => "Comprar item";

	/// <summary>
	/// Key: "Heading.Chat"
	/// English String: "Chat"
	/// </summary>
	public override string HeadingChat => "Chat";

	public override string HeadingChatAndParty => "Chat e times";

	/// <summary>
	/// Key: "Heading.ConfirmLeaving"
	/// English String: "Are you sure to leave this chat group?"
	/// </summary>
	public override string HeadingConfirmLeaving => "Quer mesmo sair deste grupo de chat?";

	/// <summary>
	/// Key: "Heading.ContinueToReport"
	/// English String: "Continue to report?"
	/// </summary>
	public override string HeadingContinueToReport => "Prosseguir com a denúncia?";

	/// <summary>
	/// Key: "Heading.CreateParty"
	/// English String: "Create Party"
	/// </summary>
	public override string HeadingCreateParty => "Criar time";

	/// <summary>
	/// Key: "Heading.LeaveChatGroup"
	/// English String: "Leave Chat Group"
	/// </summary>
	public override string HeadingLeaveChatGroup => "Sair do grupo de chat";

	/// <summary>
	/// Key: "Heading.LeaveChatGroupQ"
	/// English String: "Leave Chat Group?"
	/// </summary>
	public override string HeadingLeaveChatGroupQ => "Sair do grupo de chat?";

	/// <summary>
	/// Key: "Heading.NewChatGroup"
	/// English String: "New Chat Group"
	/// </summary>
	public override string HeadingNewChatGroup => "Novo grupo de chat";

	/// <summary>
	/// Key: "Heading.RemoveUser"
	/// English String: "Remove User?"
	/// </summary>
	public override string HeadingRemoveUser => "Remover usuário?";

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
	public override string LabelAddFriends => "Adicionar amigos";

	/// <summary>
	/// Key: "Label.BuyButton"
	/// English String: "Buy"
	/// </summary>
	public override string LabelBuyButton => "Comprar";

	/// <summary>
	/// Key: "Label.ChangeChatGroupName"
	/// English String: "Change your chat group name"
	/// </summary>
	public override string LabelChangeChatGroupName => "Mude o nome do seu grupo de chat";

	/// <summary>
	/// Key: "Label.ChatDetails"
	/// English String: "Chat Details"
	/// </summary>
	public override string LabelChatDetails => "Detalhes do chat";

	/// <summary>
	/// Key: "Label.ChatGroupName"
	/// English String: "Chat Group Name"
	/// </summary>
	public override string LabelChatGroupName => "Nome do grupo de chat";

	/// <summary>
	/// Key: "Label.Close"
	/// English String: "Close"
	/// </summary>
	public override string LabelClose => "Fechar";

	/// <summary>
	/// Key: "Label.ConversationNotifications"
	/// conversation notification
	/// English String: "Notifications"
	/// </summary>
	public override string LabelConversationNotifications => "Notificações";

	/// <summary>
	/// Key: "Label.ConversationNotificationsOn"
	/// conversation notification is on
	/// English String: "On"
	/// </summary>
	public override string LabelConversationNotificationsOn => "Ativado";

	/// <summary>
	/// Key: "Label.Details.PlayTogether"
	/// English String: "PlayTogether"
	/// </summary>
	public override string LabelDetailsPlayTogether => "Jogar junto";

	/// <summary>
	/// Key: "Label.FindGame"
	/// English String: "Find Game"
	/// </summary>
	public override string LabelFindGame => "Encontrar jogo";

	/// <summary>
	/// Key: "Label.GameNotAvailableButton"
	/// English String: "Not Available"
	/// </summary>
	public override string LabelGameNotAvailableButton => "Não disponível";

	/// <summary>
	/// Key: "Label.General"
	/// English String: "General"
	/// </summary>
	public override string LabelGeneral => "Geral";

	/// <summary>
	/// Key: "Label.InGame"
	/// English String: "In Game"
	/// </summary>
	public override string LabelInGame => "No jogo";

	/// <summary>
	/// Key: "Label.InputPlaceHolder.SearchForFriends"
	/// English String: "Search for friends"
	/// </summary>
	public override string LabelInputPlaceHolderSearchForFriends => "Pesquisar amigos";

	/// <summary>
	/// Key: "Label.InputPlaceHolder.SendMessage"
	/// English String: "Send a message"
	/// </summary>
	public override string LabelInputPlaceHolderSendMessage => "Envie uma mensagem";

	/// <summary>
	/// Key: "Label.InStudio"
	/// English String: "In Studio"
	/// </summary>
	public override string LabelInStudio => "No Studio";

	/// <summary>
	/// Key: "Label.JoinButton"
	/// English String: "Join"
	/// </summary>
	public override string LabelJoinButton => "Entrar";

	/// <summary>
	/// Key: "Label.JoinGame"
	/// English String: "Join Game"
	/// </summary>
	public override string LabelJoinGame => "Entrar no jogo";

	/// <summary>
	/// Key: "Label.JoinParty"
	/// English String: "Join Party"
	/// </summary>
	public override string LabelJoinParty => "Entrar no time";

	/// <summary>
	/// Key: "Label.LeaveChatGroup"
	/// English String: "Leave Chat Group"
	/// </summary>
	public override string LabelLeaveChatGroup => "Sair do grupo de chat";

	/// <summary>
	/// Key: "Label.LeaveParty"
	/// English String: "Leave Party"
	/// </summary>
	public override string LabelLeaveParty => "Sair do time";

	/// <summary>
	/// Key: "Label.Member"
	/// English String: "Member"
	/// </summary>
	public override string LabelMember => "Membro";

	/// <summary>
	/// Key: "Label.Members"
	/// English String: "Members"
	/// </summary>
	public override string LabelMembers => "Membros";

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
	public override string LabelMute24Hours => "Por 1 dia";

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
	public override string LabelMuteConversationNotificationsForGroup => "Silenciar as notificações deste grupo de chat";

	/// <summary>
	/// Key: "Label.MuteConversationNotificationsForOneToOne"
	/// English String: "Mute notifications for this conversation"
	/// </summary>
	public override string LabelMuteConversationNotificationsForOneToOne => "Silenciar as notificações desta conversa";

	/// <summary>
	/// Key: "Label.MuteInfinite"
	/// Mute conversation until user turns back
	/// English String: "Until I turn them back on"
	/// </summary>
	public override string LabelMuteInfinite => "Até que eu ative novamente";

	/// <summary>
	/// Key: "Label.NameYourChangeGroup"
	/// English String: "Name your change group"
	/// </summary>
	public override string LabelNameYourChangeGroup => "Mude o nome do seu grupo de chat";

	/// <summary>
	/// Key: "Label.NameYourChatGroup"
	/// English String: "Name your chat group"
	/// </summary>
	public override string LabelNameYourChatGroup => "Dê um nome para seu grupo de chat";

	/// <summary>
	/// Key: "Label.NotImplementedMessageType"
	/// This message is displayed in chat when user receives message type that can't be rendered by current app version and update is not available, yet (e.g. latest version was rolled back, or in deprecated Android native chat)
	/// English String: "This message could not be displayed."
	/// </summary>
	public override string LabelNotImplementedMessageType => "Esta mensagem não pôde ser exibida.";

	/// <summary>
	/// Key: "Label.Offline"
	/// English String: "Offline"
	/// </summary>
	public override string LabelOffline => "Offline";

	/// <summary>
	/// Key: "Label.Online"
	/// English String: "Online"
	/// </summary>
	public override string LabelOnline => "Online";

	/// <summary>
	/// Key: "Label.PinGameTooltip"
	/// English String: "Pin Game"
	/// </summary>
	public override string LabelPinGameTooltip => "Marcar jogo";

	/// <summary>
	/// Key: "Label.PinnedGame"
	/// This is a title of card, means this game card is pinned game
	/// English String: "Pinned Game"
	/// </summary>
	public override string LabelPinnedGame => "Jogo marcado";

	/// <summary>
	/// Key: "Label.PlayButton"
	/// English String: "Play"
	/// </summary>
	public override string LabelPlayButton => "Jogar";

	/// <summary>
	/// Key: "Label.PlayGames"
	/// English String: "Play Games"
	/// </summary>
	public override string LabelPlayGames => "Jogar";

	/// <summary>
	/// Key: "Label.PlayTogether"
	/// English String: "Play Together"
	/// </summary>
	public override string LabelPlayTogether => "Jogar junto";

	/// <summary>
	/// Key: "Label.RecommendedGames"
	/// English String: "Recommended"
	/// </summary>
	public override string LabelRecommendedGames => "Recomendado";

	/// <summary>
	/// Key: "Label.SeeLess"
	/// English String: "See Less"
	/// </summary>
	public override string LabelSeeLess => "Ver menos";

	/// <summary>
	/// Key: "Label.SeeMore"
	/// English String: "See More"
	/// </summary>
	public override string LabelSeeMore => "Ver mais";

	/// <summary>
	/// Key: "Label.ShowLessGames"
	/// English String: "Show Less"
	/// </summary>
	public override string LabelShowLessGames => "Mostrar menos";

	/// <summary>
	/// Key: "Label.SpanTitle.CreateGroupNeeds2More"
	/// English String: "Add at least 2 people to create chat group"
	/// </summary>
	public override string LabelSpanTitleCreateGroupNeeds2More => "Deve haver pelo menos 2 pessoas para criar grupo de chat";

	/// <summary>
	/// Key: "Label.SpanTitle.Loading"
	/// English String: "loading ..."
	/// </summary>
	public override string LabelSpanTitleLoading => "carregando...";

	/// <summary>
	/// Key: "Label.TimestampOffUntilTomorrow"
	/// English String: "Off until tomorrow"
	/// </summary>
	public override string LabelTimestampOffUntilTomorrow => "Desativar até amanhã";

	/// <summary>
	/// Key: "Label.TimestampOffUntilTurnedBackOn"
	/// English String: "Off until turned back on\""
	/// </summary>
	public override string LabelTimestampOffUntilTurnedBackOn => "Desativar até que eu ative novamente";

	/// <summary>
	/// Key: "Label.TurnOnConversationNotificationsPrompt"
	/// English String: "Do you want to turn on notifications?"
	/// </summary>
	public override string LabelTurnOnConversationNotificationsPrompt => "Deseja ativar as notificações?";

	/// <summary>
	/// Key: "Label.UnpinGameTooltip"
	/// English String: "Unpin Game"
	/// </summary>
	public override string LabelUnpinGameTooltip => "Desmarcar jogo";

	/// <summary>
	/// Key: "Label.ViewDetailsButton"
	/// English String: "View Details"
	/// </summary>
	public override string LabelViewDetailsButton => "Ver detalhes";

	/// <summary>
	/// Key: "Label.ViewProfile"
	/// English String: "View Profile"
	/// </summary>
	public override string LabelViewProfile => "Ver perfil";

	/// <summary>
	/// Key: "Label.Yesterday"
	/// time stamp for chat message received yesterday
	/// English String: "Yesterday"
	/// </summary>
	public override string LabelYesterday => "Ontem";

	/// <summary>
	/// Key: "Message.ConversationTitleModerated"
	/// Chat group name was moderated.
	/// English String: "Chat group name was moderated."
	/// </summary>
	public override string MessageConversationTitleModerated => "Nome do grupo de chat foi moderado.";

	/// <summary>
	/// Key: "Message.Default"
	/// English String: "Not everyone in this chat can see your message."
	/// </summary>
	public override string MessageDefault => "Nem todo mundo neste chat pode ver sua mensagem.";

	/// <summary>
	/// Key: "Message.DefaultErrorMsg"
	/// English String: "An error occurred"
	/// </summary>
	public override string MessageDefaultErrorMsg => "Ocorreu um erro";

	/// <summary>
	/// Key: "Message.Error"
	/// English String: "Error"
	/// </summary>
	public override string MessageError => "Erro";

	/// <summary>
	/// Key: "Message.JoinPartyText"
	/// English String: "The party leader is finding a game to play."
	/// </summary>
	public override string MessageJoinPartyText => "O líder do time está procurando por um jogo para jogar.";

	/// <summary>
	/// Key: "Message.MakeFriendsToChatNPlay"
	/// English String: "Make friends to start chatting and partying!"
	/// </summary>
	public override string MessageMakeFriendsToChatNPlay => "Faça amigos para conversar no chat e formar um time!";

	/// <summary>
	/// Key: "Message.MessageContentModerated"
	/// English String: "Your message was moderated and not sent."
	/// </summary>
	public override string MessageMessageContentModerated => "Sua mensagem foi moderada e não foi enviada.";

	/// <summary>
	/// Key: "Message.MessageFilterForReceivers"
	/// English String: "Not everyone in this chat can see your message."
	/// </summary>
	public override string MessageMessageFilterForReceivers => "Nem todo mundo neste chat pode ver sua mensagem.";

	/// <summary>
	/// Key: "Message.NoConnectionMsg"
	/// English String: "Connecting..."
	/// </summary>
	public override string MessageNoConnectionMsg => "Conectando...";

	/// <summary>
	/// Key: "Message.PartyInviteMsg"
	/// English String: "PARTY INVITE!"
	/// </summary>
	public override string MessagePartyInviteMsg => "CONVITE PARA TIME!";

	/// <summary>
	/// Key: "Message.PlayGameUpdate"
	/// English String: " is playing the pinned game: "
	/// </summary>
	public override string MessagePlayGameUpdate => " está jogando o jogo marcado: ";

	/// <summary>
	/// Key: "Message.TextTooLong"
	/// English String: "Your message was too long and not sent."
	/// </summary>
	public override string MessageTextTooLong => "Sua mensagem era longa demais e não foi enviada.";

	/// <summary>
	/// Key: "Message.UnknownMessageType"
	/// This serves as the fallback string for when an message type is received that the web chat does not know how to render.
	/// English String: "A message cannot be displayed"
	/// </summary>
	public override string MessageUnknownMessageType => "Uma mensagem não pôde ser exibida";

	/// <summary>
	/// Key: "PlayButton"
	/// English String: "Play"
	/// </summary>
	public override string PlayButton => "Jogar";

	/// <summary>
	/// Key: "Response.PartyInvite"
	/// notification message
	/// English String: "You received a party Invite."
	/// </summary>
	public override string ResponsePartyInvite => "Você foi convidado para um time.";

	public ChatResources_pt_br(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionAdd()
	{
		return "Adicionar";
	}

	protected override string _GetTemplateForActionBuyAccess()
	{
		return "Comprar acesso";
	}

	protected override string _GetTemplateForActionCancel()
	{
		return "Cancelar";
	}

	protected override string _GetTemplateForActionCreate()
	{
		return "Criar";
	}

	protected override string _GetTemplateForActionJoin()
	{
		return "Entrar";
	}

	protected override string _GetTemplateForActionLeave()
	{
		return "Sair";
	}

	protected override string _GetTemplateForActionRemove()
	{
		return "Remover";
	}

	protected override string _GetTemplateForActionReport()
	{
		return "Denunciar";
	}

	protected override string _GetTemplateForActionSave()
	{
		return "Salvar";
	}

	protected override string _GetTemplateForActionSend()
	{
		return "Enviar";
	}

	protected override string _GetTemplateForActionSet()
	{
		return "Configurar";
	}

	protected override string _GetTemplateForActionStartParty()
	{
		return "Iniciar time";
	}

	protected override string _GetTemplateForActionStay()
	{
		return "Ficar";
	}

	protected override string _GetTemplateForActionTurnOn()
	{
		return "Ativar";
	}

	protected override string _GetTemplateForHeadingBuyItem()
	{
		return "Comprar item";
	}

	protected override string _GetTemplateForHeadingChat()
	{
		return "Chat";
	}

	protected override string _GetTemplateForHeadingChatAndParty()
	{
		return "Chat e times";
	}

	protected override string _GetTemplateForHeadingConfirmLeaving()
	{
		return "Quer mesmo sair deste grupo de chat?";
	}

	protected override string _GetTemplateForHeadingContinueToReport()
	{
		return "Prosseguir com a denúncia?";
	}

	protected override string _GetTemplateForHeadingCreateParty()
	{
		return "Criar time";
	}

	protected override string _GetTemplateForHeadingLeaveChatGroup()
	{
		return "Sair do grupo de chat";
	}

	protected override string _GetTemplateForHeadingLeaveChatGroupQ()
	{
		return "Sair do grupo de chat?";
	}

	protected override string _GetTemplateForHeadingNewChatGroup()
	{
		return "Novo grupo de chat";
	}

	protected override string _GetTemplateForHeadingRemoveUser()
	{
		return "Remover usuário?";
	}

	protected override string _GetTemplateForHeadingReport()
	{
		return "Denunciar";
	}

	protected override string _GetTemplateForLabelAddFriends()
	{
		return "Adicionar amigos";
	}

	/// <summary>
	/// Key: "Label.BuyAccessToGameForModal"
	/// English String: "Would you like to buy access to the Place: {placeName} from {creatorName} for {robux}?"
	/// </summary>
	public override string LabelBuyAccessToGameForModal(string placeName, string creatorName, string robux)
	{
		return $"Gostaria de comprar o acesso a este local: {placeName} de {creatorName} por {robux}?";
	}

	protected override string _GetTemplateForLabelBuyAccessToGameForModal()
	{
		return "Gostaria de comprar o acesso a este local: {placeName} de {creatorName} por {robux}?";
	}

	protected override string _GetTemplateForLabelBuyButton()
	{
		return "Comprar";
	}

	protected override string _GetTemplateForLabelChangeChatGroupName()
	{
		return "Mude o nome do seu grupo de chat";
	}

	protected override string _GetTemplateForLabelChatDetails()
	{
		return "Detalhes do chat";
	}

	protected override string _GetTemplateForLabelChatGroupName()
	{
		return "Nome do grupo de chat";
	}

	protected override string _GetTemplateForLabelClose()
	{
		return "Fechar";
	}

	protected override string _GetTemplateForLabelConversationNotifications()
	{
		return "Notificações";
	}

	protected override string _GetTemplateForLabelConversationNotificationsOn()
	{
		return "Ativado";
	}

	protected override string _GetTemplateForLabelDetailsPlayTogether()
	{
		return "Jogar junto";
	}

	protected override string _GetTemplateForLabelFindGame()
	{
		return "Encontrar jogo";
	}

	protected override string _GetTemplateForLabelGameNotAvailableButton()
	{
		return "Não disponível";
	}

	protected override string _GetTemplateForLabelGeneral()
	{
		return "Geral";
	}

	protected override string _GetTemplateForLabelInGame()
	{
		return "No jogo";
	}

	protected override string _GetTemplateForLabelInputPlaceHolderSearchForFriends()
	{
		return "Pesquisar amigos";
	}

	protected override string _GetTemplateForLabelInputPlaceHolderSendMessage()
	{
		return "Envie uma mensagem";
	}

	protected override string _GetTemplateForLabelInStudio()
	{
		return "No Studio";
	}

	protected override string _GetTemplateForLabelJoinButton()
	{
		return "Entrar";
	}

	protected override string _GetTemplateForLabelJoinGame()
	{
		return "Entrar no jogo";
	}

	protected override string _GetTemplateForLabelJoinParty()
	{
		return "Entrar no time";
	}

	protected override string _GetTemplateForLabelLeaveChatGroup()
	{
		return "Sair do grupo de chat";
	}

	protected override string _GetTemplateForLabelLeaveParty()
	{
		return "Sair do time";
	}

	protected override string _GetTemplateForLabelMember()
	{
		return "Membro";
	}

	/// <summary>
	/// Key: "Label.MemberJoinText"
	/// English String: "{userName} joined the party"
	/// </summary>
	public override string LabelMemberJoinText(string userName)
	{
		return $"{userName} entrou no time";
	}

	protected override string _GetTemplateForLabelMemberJoinText()
	{
		return "{userName} entrou no time";
	}

	protected override string _GetTemplateForLabelMembers()
	{
		return "Membros";
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
		return "Por 1 dia";
	}

	protected override string _GetTemplateForLabelMute8Hours()
	{
		return "Por 8 horas";
	}

	protected override string _GetTemplateForLabelMuteConversationNotificationsForGroup()
	{
		return "Silenciar as notificações deste grupo de chat";
	}

	protected override string _GetTemplateForLabelMuteConversationNotificationsForOneToOne()
	{
		return "Silenciar as notificações desta conversa";
	}

	protected override string _GetTemplateForLabelMuteInfinite()
	{
		return "Até que eu ative novamente";
	}

	protected override string _GetTemplateForLabelNameYourChangeGroup()
	{
		return "Mude o nome do seu grupo de chat";
	}

	protected override string _GetTemplateForLabelNameYourChatGroup()
	{
		return "Dê um nome para seu grupo de chat";
	}

	protected override string _GetTemplateForLabelNotImplementedMessageType()
	{
		return "Esta mensagem não pôde ser exibida.";
	}

	protected override string _GetTemplateForLabelOffline()
	{
		return "Offline";
	}

	protected override string _GetTemplateForLabelOnline()
	{
		return "Online";
	}

	/// <summary>
	/// Key: "Label.PartyLeaderTooltip"
	/// English String: "{userName} is the party leader"
	/// </summary>
	public override string LabelPartyLeaderTooltip(string userName)
	{
		return $"{userName} é o líder do time";
	}

	protected override string _GetTemplateForLabelPartyLeaderTooltip()
	{
		return "{userName} é o líder do time";
	}

	/// <summary>
	/// Key: "Label.PartyMemberTooltip"
	/// English String: "{userName} is in the party"
	/// </summary>
	public override string LabelPartyMemberTooltip(string userName)
	{
		return $"{userName} está no time";
	}

	protected override string _GetTemplateForLabelPartyMemberTooltip()
	{
		return "{userName} está no time";
	}

	/// <summary>
	/// Key: "Label.PartyName"
	/// English String: "Party : {title}"
	/// </summary>
	public override string LabelPartyName(string title)
	{
		return $"Time: {title}";
	}

	protected override string _GetTemplateForLabelPartyName()
	{
		return "Time: {title}";
	}

	/// <summary>
	/// Key: "Label.PendingMemberTooltip"
	/// English String: "{userName} is not in the party"
	/// </summary>
	public override string LabelPendingMemberTooltip(string userName)
	{
		return $"{userName} não está no time";
	}

	protected override string _GetTemplateForLabelPendingMemberTooltip()
	{
		return "{userName} não está no time";
	}

	protected override string _GetTemplateForLabelPinGameTooltip()
	{
		return "Marcar jogo";
	}

	protected override string _GetTemplateForLabelPinnedGame()
	{
		return "Jogo marcado";
	}

	protected override string _GetTemplateForLabelPlayButton()
	{
		return "Jogar";
	}

	protected override string _GetTemplateForLabelPlayGames()
	{
		return "Jogar";
	}

	/// <summary>
	/// Key: "Label.PlayingGame"
	/// English String: "Playing {game}"
	/// </summary>
	public override string LabelPlayingGame(string game)
	{
		return $"Jogando {game}";
	}

	protected override string _GetTemplateForLabelPlayingGame()
	{
		return "Jogando {game}";
	}

	protected override string _GetTemplateForLabelPlayTogether()
	{
		return "Jogar junto";
	}

	protected override string _GetTemplateForLabelRecommendedGames()
	{
		return "Recomendado";
	}

	protected override string _GetTemplateForLabelSeeLess()
	{
		return "Ver menos";
	}

	protected override string _GetTemplateForLabelSeeMore()
	{
		return "Ver mais";
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
		return $"Mostrar mais (+{count})";
	}

	protected override string _GetTemplateForLabelShowMoreGames()
	{
		return "Mostrar mais (+{count})";
	}

	protected override string _GetTemplateForLabelSpanTitleCreateGroupNeeds2More()
	{
		return "Deve haver pelo menos 2 pessoas para criar grupo de chat";
	}

	protected override string _GetTemplateForLabelSpanTitleLoading()
	{
		return "carregando...";
	}

	/// <summary>
	/// Key: "Label.TimestampOffUntilCertainTime"
	/// English String: "Off until {timestamp}"
	/// </summary>
	public override string LabelTimestampOffUntilCertainTime(string timestamp)
	{
		return $"Desativar até {timestamp}";
	}

	protected override string _GetTemplateForLabelTimestampOffUntilCertainTime()
	{
		return "Desativar até {timestamp}";
	}

	protected override string _GetTemplateForLabelTimestampOffUntilTomorrow()
	{
		return "Desativar até amanhã";
	}

	protected override string _GetTemplateForLabelTimestampOffUntilTurnedBackOn()
	{
		return "Desativar até que eu ative novamente";
	}

	protected override string _GetTemplateForLabelTurnOnConversationNotificationsPrompt()
	{
		return "Deseja ativar as notificações?";
	}

	protected override string _GetTemplateForLabelUnpinGameTooltip()
	{
		return "Desmarcar jogo";
	}

	protected override string _GetTemplateForLabelViewDetailsButton()
	{
		return "Ver detalhes";
	}

	protected override string _GetTemplateForLabelViewProfile()
	{
		return "Ver perfil";
	}

	protected override string _GetTemplateForLabelYesterday()
	{
		return "Ontem";
	}

	/// <summary>
	/// Key: "Message.ChatPrivacySetting"
	/// English String: "To chat with friends, turn on chat in your {frontLink}Privacy Settings{endLink}"
	/// </summary>
	public override string MessageChatPrivacySetting(string frontLink, string endLink)
	{
		return $"Para conversar no chat com amigos, ligue o chat em suas {frontLink}Configurações de Privacidade{endLink}.";
	}

	protected override string _GetTemplateForMessageChatPrivacySetting()
	{
		return "Para conversar no chat com amigos, ligue o chat em suas {frontLink}Configurações de Privacidade{endLink}.";
	}

	/// <summary>
	/// Key: "Message.conversationTitleChangedText"
	/// English String: "{userName} named the chat group: {groupName}"
	/// </summary>
	public override string MessageconversationTitleChangedText(string userName, string groupName)
	{
		return $"{userName} nomeou o grupo de chat: {groupName}";
	}

	protected override string _GetTemplateForMessageconversationTitleChangedText()
	{
		return "{userName} nomeou o grupo de chat: {groupName}";
	}

	protected override string _GetTemplateForMessageConversationTitleModerated()
	{
		return "Nome do grupo de chat foi moderado.";
	}

	protected override string _GetTemplateForMessageDefault()
	{
		return "Nem todo mundo neste chat pode ver sua mensagem.";
	}

	protected override string _GetTemplateForMessageDefaultErrorMsg()
	{
		return "Ocorreu um erro";
	}

	/// <summary>
	/// Key: "Message.DefaultTitleForMsg"
	/// English String: "{userName} says ..."
	/// </summary>
	public override string MessageDefaultTitleForMsg(string userName)
	{
		return $"{userName} diz...";
	}

	protected override string _GetTemplateForMessageDefaultTitleForMsg()
	{
		return "{userName} diz...";
	}

	/// <summary>
	/// Key: "Message.DefaultTitleForPartyInvite"
	/// English String: "Party invite from {userName}"
	/// </summary>
	public override string MessageDefaultTitleForPartyInvite(string userName)
	{
		return $"Convite de time de {userName}";
	}

	protected override string _GetTemplateForMessageDefaultTitleForPartyInvite()
	{
		return "Convite de time de {userName}";
	}

	protected override string _GetTemplateForMessageError()
	{
		return "Erro";
	}

	/// <summary>
	/// Key: "Message.FindGameToPlay"
	/// English String: "{frontLink}Find Games{endLink} to play with your friends!"
	/// </summary>
	public override string MessageFindGameToPlay(string frontLink, string endLink)
	{
		return $"{frontLink}Encontre jogos{endLink} para jogar com seus amigos!";
	}

	protected override string _GetTemplateForMessageFindGameToPlay()
	{
		return "{frontLink}Encontre jogos{endLink} para jogar com seus amigos!";
	}

	protected override string _GetTemplateForMessageJoinPartyText()
	{
		return "O líder do time está procurando por um jogo para jogar.";
	}

	protected override string _GetTemplateForMessageMakeFriendsToChatNPlay()
	{
		return "Faça amigos para conversar no chat e formar um time!";
	}

	protected override string _GetTemplateForMessageMessageContentModerated()
	{
		return "Sua mensagem foi moderada e não foi enviada.";
	}

	protected override string _GetTemplateForMessageMessageFilterForReceivers()
	{
		return "Nem todo mundo neste chat pode ver sua mensagem.";
	}

	protected override string _GetTemplateForMessageNoConnectionMsg()
	{
		return "Conectando...";
	}

	protected override string _GetTemplateForMessagePartyInviteMsg()
	{
		return "CONVITE PARA TIME!";
	}

	/// <summary>
	/// Key: "Message.PinGameUpdate"
	/// users pinned game in conversation
	/// English String: "{userName} chose a game to play together: {gameName}"
	/// </summary>
	public override string MessagePinGameUpdate(string userName, string gameName)
	{
		return $"{userName} escolheu um jogo para jogar junto: {gameName}";
	}

	protected override string _GetTemplateForMessagePinGameUpdate()
	{
		return "{userName} escolheu um jogo para jogar junto: {gameName}";
	}

	protected override string _GetTemplateForMessagePlayGameUpdate()
	{
		return " está jogando o jogo marcado: ";
	}

	protected override string _GetTemplateForMessageTextTooLong()
	{
		return "Sua mensagem era longa demais e não foi enviada.";
	}

	/// <summary>
	/// Key: "Message.ToastText"
	/// English String: "You can have up to {friendNum} friends in chat group."
	/// </summary>
	public override string MessageToastText(string friendNum)
	{
		return $"Você pode ter até {friendNum} amigos no grupo de chat.";
	}

	protected override string _GetTemplateForMessageToastText()
	{
		return "Você pode ter até {friendNum} amigos no grupo de chat.";
	}

	protected override string _GetTemplateForMessageUnknownMessageType()
	{
		return "Uma mensagem não pôde ser exibida";
	}

	protected override string _GetTemplateForPlayButton()
	{
		return "Jogar";
	}

	protected override string _GetTemplateForResponsePartyInvite()
	{
		return "Você foi convidado para um time.";
	}
}
