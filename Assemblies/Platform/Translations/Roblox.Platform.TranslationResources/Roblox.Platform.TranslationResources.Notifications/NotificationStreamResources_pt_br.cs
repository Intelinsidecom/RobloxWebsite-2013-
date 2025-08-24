namespace Roblox.TranslationResources.Notifications;

/// <summary>
/// This class overrides NotificationStreamResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class NotificationStreamResources_pt_br : NotificationStreamResources_en_us, INotificationStreamResources, ITranslationResources
{
	/// <summary>
	/// Key: "Action.Accept"
	/// English String: "Accept"
	/// </summary>
	public override string ActionAccept => "Aceitar";

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
	public override string ActionPlay => "Jogar";

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
	public override string ActionUndo => "Desfazer";

	/// <summary>
	/// Key: "Action.View"
	/// English String: "View"
	/// </summary>
	public override string ActionView => "Ver";

	/// <summary>
	/// Key: "Action.ViewAll"
	/// English String: "View All"
	/// </summary>
	public override string ActionViewAll => "Ver todos";

	/// <summary>
	/// Key: "Heading.BackToAllNotifications"
	/// Heading displayed in game updates view, containing back link to notifications main view.
	/// English String: "All Notifications"
	/// </summary>
	public override string HeadingBackToAllNotifications => "Todas as notificações";

	/// <summary>
	/// Key: "Label.NoNetworkConnectionText"
	/// English String: "Connecting..."
	/// </summary>
	public override string LabelNoNetworkConnectionText => "Conectando...";

	/// <summary>
	/// Key: "Label.NoNotifications"
	/// English String: "No Notifications"
	/// </summary>
	public override string LabelNoNotifications => "Nenhuma notificação";

	/// <summary>
	/// Key: "Label.Notifications"
	/// English String: "Notifications"
	/// </summary>
	public override string LabelNotifications => "Notificações";

	/// <summary>
	/// Key: "Label.Settings"
	/// English String: "Settings"
	/// </summary>
	public override string LabelSettings => "Configurações";

	/// <summary>
	/// Key: "Message.GameNotPlayableOnDevice"
	/// Message displayed on game update card when the game is not playable on the device type.
	/// English String: "Not playable on this device"
	/// </summary>
	public override string MessageGameNotPlayableOnDevice => "Não é compatível com este dispositivo";

	/// <summary>
	/// Key: "Message.TooManyFriendsOther"
	/// English String: "That user already has the max number of friends."
	/// </summary>
	public override string MessageTooManyFriendsOther => "O usuário já possui o número máximo de amigos.";

	/// <summary>
	/// Key: "Message.TooManyFriendsSelf"
	/// English String: "You already have the max number of friends."
	/// </summary>
	public override string MessageTooManyFriendsSelf => "Você já possui o número máximo de amigos.";

	public NotificationStreamResources_pt_br(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionAccept()
	{
		return "Aceitar";
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
		return "Jogar";
	}

	protected override string _GetTemplateForActionReportAbuse()
	{
		return "Denunciar abuso";
	}

	protected override string _GetTemplateForActionUndo()
	{
		return "Desfazer";
	}

	/// <summary>
	/// Key: "Action.UnfollowGame"
	/// Label of menu item to unfollow the game
	/// English String: "Unfollow {gameName}"
	/// </summary>
	public override string ActionUnfollowGame(string gameName)
	{
		return $"Deixou de seguir {gameName}";
	}

	protected override string _GetTemplateForActionUnfollowGame()
	{
		return "Deixou de seguir {gameName}";
	}

	protected override string _GetTemplateForActionView()
	{
		return "Ver";
	}

	protected override string _GetTemplateForActionViewAll()
	{
		return "Ver todos";
	}

	protected override string _GetTemplateForHeadingBackToAllNotifications()
	{
		return "Todas as notificações";
	}

	protected override string _GetTemplateForLabelNoNetworkConnectionText()
	{
		return "Conectando...";
	}

	protected override string _GetTemplateForLabelNoNotifications()
	{
		return "Nenhuma notificação";
	}

	protected override string _GetTemplateForLabelNotifications()
	{
		return "Notificações";
	}

	protected override string _GetTemplateForLabelSettings()
	{
		return "Configurações";
	}

	/// <summary>
	/// Key: "Message.AggregatedGameUpdateDouble"
	/// Message displayed on aggregated game update notification card, when there are exactly two games sending update.
	/// English String: "{gameOne} and {gameTwo} sent updates."
	/// </summary>
	public override string MessageAggregatedGameUpdateDouble(string gameOne, string gameTwo)
	{
		return $"{gameOne} e {gameTwo} foram atualizados.";
	}

	protected override string _GetTemplateForMessageAggregatedGameUpdateDouble()
	{
		return "{gameOne} e {gameTwo} foram atualizados.";
	}

	protected override string _GetTemplateForMessageAggregatedGameUpdateMultiple()
	{
		return "{gameOne}, {gameTwo} e {otherCount, plural, =1 {# other game} other {# other games}} foram atualizados.";
	}

	/// <summary>
	/// Key: "Message.ConfirmAcceptedDouble"
	/// English String: "{userOne} and {userTwo}"
	/// </summary>
	public override string MessageConfirmAcceptedDouble(string userOne, string userTwo)
	{
		return $"{userOne} e {userTwo}";
	}

	protected override string _GetTemplateForMessageConfirmAcceptedDouble()
	{
		return "{userOne} e {userTwo}";
	}

	protected override string _GetTemplateForMessageConfirmAcceptedMultiple()
	{
		return "{userOne}, {userTwo} e mais {userMultipleCount, plural, =1 {# pessoa} other {# pessoas}}";
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
		return $"Você fez amizade com {userOne} e {userTwo}!";
	}

	protected override string _GetTemplateForMessageConfirmSentDouble()
	{
		return "Você fez amizade com {userOne} e {userTwo}!";
	}

	protected override string _GetTemplateForMessageConfirmSentMultiple()
	{
		return "Você fez amizade com {userOne}, {userTwo} e mais {userMultipleCount, plural, =1 {# pessoa} other {# pessoas}}!";
	}

	/// <summary>
	/// Key: "Message.ConfirmSentSingle"
	/// English String: "{userOne} is now your friend!"
	/// </summary>
	public override string MessageConfirmSentSingle(string userOne)
	{
		return $"Você fez amizade com {userOne}!";
	}

	protected override string _GetTemplateForMessageConfirmSentSingle()
	{
		return "Você fez amizade com {userOne}!";
	}

	/// <summary>
	/// Key: "Message.DeveloperMetricsAvailable"
	/// English String: "{month} {year} Analytics Report for {gameName} available."
	/// </summary>
	public override string MessageDeveloperMetricsAvailable(string month, string year, string gameName)
	{
		return $"Relatório analítico de {month} de {year}  para {gameName} disponível.";
	}

	protected override string _GetTemplateForMessageDeveloperMetricsAvailable()
	{
		return "Relatório analítico de {month} de {year}  para {gameName} disponível.";
	}

	protected override string _GetTemplateForMessageDeveloperMetricsAvailableMultiple()
	{
		return "Relatório analítico de {month} de {year} para {gameName} e {otherCount, plural, =1 {# outro jogo} other {# outros jogos}} disponível";
	}

	/// <summary>
	/// Key: "Message.DeveloperMetricsAvailableMultiple2"
	/// English String: "{month} {year} Analytics Report for {gameCount} games available."
	/// </summary>
	public override string MessageDeveloperMetricsAvailableMultiple2(string month, string year, string gameCount)
	{
		return $"Relatório analítico de {month} de {year}  para {gameCount} jogos disponível.";
	}

	protected override string _GetTemplateForMessageDeveloperMetricsAvailableMultiple2()
	{
		return "Relatório analítico de {month} de {year}  para {gameCount} jogos disponível.";
	}

	/// <summary>
	/// Key: "Message.FriendRequestAcceptedDouble"
	/// English String: "{userOne} and {userTwo} accepted your friend request."
	/// </summary>
	public override string MessageFriendRequestAcceptedDouble(string userOne, string userTwo)
	{
		return $"{userOne} e {userTwo} aceitaram seu pedido de amizade.";
	}

	protected override string _GetTemplateForMessageFriendRequestAcceptedDouble()
	{
		return "{userOne} e {userTwo} aceitaram seu pedido de amizade.";
	}

	protected override string _GetTemplateForMessageFriendRequestAcceptedMultiple()
	{
		return "{userOne}, {userTwo} e mais {userMultipleCount, plural, =1 {# pessoa} other {# pessoas}} aceitaram seu pedido de amizade.";
	}

	/// <summary>
	/// Key: "Message.FriendRequestAcceptedSingle"
	/// English String: "{userOne} accepted your friend request."
	/// </summary>
	public override string MessageFriendRequestAcceptedSingle(string userOne)
	{
		return $"{userOne} aceitou seu pedido de amizade.";
	}

	protected override string _GetTemplateForMessageFriendRequestAcceptedSingle()
	{
		return "{userOne} aceitou seu pedido de amizade.";
	}

	/// <summary>
	/// Key: "Message.FriendRequestSentDouble"
	/// English String: "{userOne} and {userTwo} sent you friend requests."
	/// </summary>
	public override string MessageFriendRequestSentDouble(string userOne, string userTwo)
	{
		return $"{userOne} e {userTwo} enviaram pedidos de amizade para você.";
	}

	protected override string _GetTemplateForMessageFriendRequestSentDouble()
	{
		return "{userOne} e {userTwo} enviaram pedidos de amizade para você.";
	}

	protected override string _GetTemplateForMessageFriendRequestSentMultiple()
	{
		return "{userOne}, {userTwo} e mais {userMultipleCount, plural, =1 {# pessoa} other {# pessoas}} enviaram pedidos de amizade para você.";
	}

	/// <summary>
	/// Key: "Message.FriendRequestSentSingle"
	/// English String: "{userOne} sent you a friend request."
	/// </summary>
	public override string MessageFriendRequestSentSingle(string userOne)
	{
		return $"{userOne} enviou um pedido de amizade para você.";
	}

	protected override string _GetTemplateForMessageFriendRequestSentSingle()
	{
		return "{userOne} enviou um pedido de amizade para você.";
	}

	protected override string _GetTemplateForMessageGameNotPlayableOnDevice()
	{
		return "Não é compatível com este dispositivo";
	}

	/// <summary>
	/// Key: "Message.MessageAndPreview"
	/// English String: "{titleStart}Message from {username}:{titleEnd} {message}"
	/// </summary>
	public override string MessageMessageAndPreview(string titleStart, string username, string titleEnd, string message)
	{
		return $"{titleStart}Mensagem de {username}:{titleEnd} {message}";
	}

	protected override string _GetTemplateForMessageMessageAndPreview()
	{
		return "{titleStart}Mensagem de {username}:{titleEnd} {message}";
	}

	/// <summary>
	/// Key: "Message.MessageFrom"
	/// English String: "Message from {username}:"
	/// </summary>
	public override string MessageMessageFrom(string username)
	{
		return $"Mensagem de {username}: ";
	}

	protected override string _GetTemplateForMessageMessageFrom()
	{
		return "Mensagem de {username}: ";
	}

	protected override string _GetTemplateForMessageNumberofNewNotifications()
	{
		return "{notificationCount, plural, =1 {# nova notificação} other {# novas notificações}}";
	}

	protected override string _GetTemplateForMessageTooManyFriendsOther()
	{
		return "O usuário já possui o número máximo de amigos.";
	}

	protected override string _GetTemplateForMessageTooManyFriendsSelf()
	{
		return "Você já possui o número máximo de amigos.";
	}

	/// <summary>
	/// Key: "Message.UnfollowedGame"
	/// Message displayed in game update card after user unfollowed the game
	/// English String: "Unfollowed {gameName}"
	/// </summary>
	public override string MessageUnfollowedGame(string gameName)
	{
		return $"Deixou de seguir {gameName}";
	}

	protected override string _GetTemplateForMessageUnfollowedGame()
	{
		return "Deixou de seguir {gameName}";
	}

	protected override string _GetTemplateForMessageYouHaveNewFriendRequests()
	{
		return "Você tem {numberOfRequests} novo(s) {numberOfRequests, plural, =1 {pedido de amizade} other {pedidos de amizade}}.";
	}

	protected override string _GetTemplateForMessageYouHaveNewFriends()
	{
		return "Você tem {numberOfFriends} novo(s) {numberOfFriends, plural, =1 {amigo} other {amigos}}.";
	}

	protected override string _GetTemplateForMessageYouReceivedMessages()
	{
		return "Você recebeu {numberOfMessagesText} {numberOfMessages, plural, =1 {mensagem} other {mensagens}}";
	}
}
