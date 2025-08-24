namespace Roblox.TranslationResources.Notifications;

/// <summary>
/// This class overrides NotificationStreamResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class NotificationStreamResources_fr_fr : NotificationStreamResources_en_us, INotificationStreamResources, ITranslationResources
{
	/// <summary>
	/// Key: "Action.Accept"
	/// English String: "Accept"
	/// </summary>
	public override string ActionAccept => "Accepter";

	/// <summary>
	/// Key: "Action.Cancel"
	/// English String: "Cancel"
	/// </summary>
	public override string ActionCancel => "Annuler";

	/// <summary>
	/// Key: "Action.Chat"
	/// English String: "Chat"
	/// </summary>
	public override string ActionChat => "Chat";

	/// <summary>
	/// Key: "Action.Ignore"
	/// English String: "Ignore"
	/// </summary>
	public override string ActionIgnore => "Ignorer";

	/// <summary>
	/// Key: "Action.Play"
	/// Label for button to launch game.
	/// English String: "Play"
	/// </summary>
	public override string ActionPlay => "Jouer";

	/// <summary>
	/// Key: "Action.ReportAbuse"
	/// Label for link to report a game update message
	/// English String: "Report Abuse"
	/// </summary>
	public override string ActionReportAbuse => "Signaler une infraction";

	/// <summary>
	/// Key: "Action.Undo"
	/// Label for Undo link to reverse the unfollow action
	/// English String: "Undo"
	/// </summary>
	public override string ActionUndo => "Annuler";

	/// <summary>
	/// Key: "Action.View"
	/// English String: "View"
	/// </summary>
	public override string ActionView => "Voir";

	/// <summary>
	/// Key: "Action.ViewAll"
	/// English String: "View All"
	/// </summary>
	public override string ActionViewAll => "Voir tout";

	/// <summary>
	/// Key: "Heading.BackToAllNotifications"
	/// Heading displayed in game updates view, containing back link to notifications main view.
	/// English String: "All Notifications"
	/// </summary>
	public override string HeadingBackToAllNotifications => "Toutes les notifications";

	/// <summary>
	/// Key: "Label.NoNetworkConnectionText"
	/// English String: "Connecting..."
	/// </summary>
	public override string LabelNoNetworkConnectionText => "Connexion...";

	/// <summary>
	/// Key: "Label.NoNotifications"
	/// English String: "No Notifications"
	/// </summary>
	public override string LabelNoNotifications => "Aucune notification";

	/// <summary>
	/// Key: "Label.Notifications"
	/// English String: "Notifications"
	/// </summary>
	public override string LabelNotifications => "Notifications";

	/// <summary>
	/// Key: "Label.Settings"
	/// English String: "Settings"
	/// </summary>
	public override string LabelSettings => "Paramètres";

	/// <summary>
	/// Key: "Message.GameNotPlayableOnDevice"
	/// Message displayed on game update card when the game is not playable on the device type.
	/// English String: "Not playable on this device"
	/// </summary>
	public override string MessageGameNotPlayableOnDevice => "Pas compatible sur cet appareil";

	/// <summary>
	/// Key: "Message.TooManyFriendsOther"
	/// English String: "That user already has the max number of friends."
	/// </summary>
	public override string MessageTooManyFriendsOther => "L'utilisateur dispose déjà du nombre maximum d'amis autorisé.";

	/// <summary>
	/// Key: "Message.TooManyFriendsSelf"
	/// English String: "You already have the max number of friends."
	/// </summary>
	public override string MessageTooManyFriendsSelf => "Vous disposez déjà du nombre maximum d'amis autorisé.";

	public NotificationStreamResources_fr_fr(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionAccept()
	{
		return "Accepter";
	}

	protected override string _GetTemplateForActionCancel()
	{
		return "Annuler";
	}

	protected override string _GetTemplateForActionChat()
	{
		return "Chat";
	}

	protected override string _GetTemplateForActionIgnore()
	{
		return "Ignorer";
	}

	protected override string _GetTemplateForActionPlay()
	{
		return "Jouer";
	}

	protected override string _GetTemplateForActionReportAbuse()
	{
		return "Signaler une infraction";
	}

	protected override string _GetTemplateForActionUndo()
	{
		return "Annuler";
	}

	/// <summary>
	/// Key: "Action.UnfollowGame"
	/// Label of menu item to unfollow the game
	/// English String: "Unfollow {gameName}"
	/// </summary>
	public override string ActionUnfollowGame(string gameName)
	{
		return $"Désabonner {gameName}";
	}

	protected override string _GetTemplateForActionUnfollowGame()
	{
		return "Désabonner {gameName}";
	}

	protected override string _GetTemplateForActionView()
	{
		return "Voir";
	}

	protected override string _GetTemplateForActionViewAll()
	{
		return "Voir tout";
	}

	protected override string _GetTemplateForHeadingBackToAllNotifications()
	{
		return "Toutes les notifications";
	}

	protected override string _GetTemplateForLabelNoNetworkConnectionText()
	{
		return "Connexion...";
	}

	protected override string _GetTemplateForLabelNoNotifications()
	{
		return "Aucune notification";
	}

	protected override string _GetTemplateForLabelNotifications()
	{
		return "Notifications";
	}

	protected override string _GetTemplateForLabelSettings()
	{
		return "Paramètres";
	}

	/// <summary>
	/// Key: "Message.AggregatedGameUpdateDouble"
	/// Message displayed on aggregated game update notification card, when there are exactly two games sending update.
	/// English String: "{gameOne} and {gameTwo} sent updates."
	/// </summary>
	public override string MessageAggregatedGameUpdateDouble(string gameOne, string gameTwo)
	{
		return $"Mises à jours de {gameOne} et {gameTwo} complétées.";
	}

	protected override string _GetTemplateForMessageAggregatedGameUpdateDouble()
	{
		return "Mises à jours de {gameOne} et {gameTwo} complétées.";
	}

	protected override string _GetTemplateForMessageAggregatedGameUpdateMultiple()
	{
		return "Mises à jours de {gameOne}, {gameTwo} et {otherCount, plural, =1 {other game} other {# other games}} envoyées.";
	}

	/// <summary>
	/// Key: "Message.ConfirmAcceptedDouble"
	/// English String: "{userOne} and {userTwo}"
	/// </summary>
	public override string MessageConfirmAcceptedDouble(string userOne, string userTwo)
	{
		return $"{userOne} et {userTwo}";
	}

	protected override string _GetTemplateForMessageConfirmAcceptedDouble()
	{
		return "{userOne} et {userTwo}";
	}

	protected override string _GetTemplateForMessageConfirmAcceptedMultiple()
	{
		return "{userOne}, {userTwo} et {userMultipleCount, plural, =1 {# autre utilisateur} other {# autres utilisateurs}}";
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
		return $"Vous êtes maintenant ami(e) avec {userOne} et {userTwo}\u00a0!";
	}

	protected override string _GetTemplateForMessageConfirmSentDouble()
	{
		return "Vous êtes maintenant ami(e) avec {userOne} et {userTwo}\u00a0!";
	}

	protected override string _GetTemplateForMessageConfirmSentMultiple()
	{
		return "Vous êtes maintenant ami(e) avec {userOne}, {userTwo} et {userMultipleCount, plural, =1 {# autre utilisateur} other {# autres utilisateurs}}\u00a0!";
	}

	/// <summary>
	/// Key: "Message.ConfirmSentSingle"
	/// English String: "{userOne} is now your friend!"
	/// </summary>
	public override string MessageConfirmSentSingle(string userOne)
	{
		return $"Vous êtes maintenant ami(e) avec {userOne}\u00a0!";
	}

	protected override string _GetTemplateForMessageConfirmSentSingle()
	{
		return "Vous êtes maintenant ami(e) avec {userOne}\u00a0!";
	}

	/// <summary>
	/// Key: "Message.DeveloperMetricsAvailable"
	/// English String: "{month} {year} Analytics Report for {gameName} available."
	/// </summary>
	public override string MessageDeveloperMetricsAvailable(string month, string year, string gameName)
	{
		return $"Rapport d'analyse\u00a0: {month} {year}, pour {gameName} disponible.";
	}

	protected override string _GetTemplateForMessageDeveloperMetricsAvailable()
	{
		return "Rapport d'analyse\u00a0: {month} {year}, pour {gameName} disponible.";
	}

	protected override string _GetTemplateForMessageDeveloperMetricsAvailableMultiple()
	{
		return "Rapport d'analyse\u00a0: {month} {year}, pour {gameName} et {otherCount, plural, =1 {# other game} other {# other games}} disponible";
	}

	/// <summary>
	/// Key: "Message.DeveloperMetricsAvailableMultiple2"
	/// English String: "{month} {year} Analytics Report for {gameCount} games available."
	/// </summary>
	public override string MessageDeveloperMetricsAvailableMultiple2(string month, string year, string gameCount)
	{
		return $"Rapport d'analyse\u00a0: {month} {year}, pour {gameCount} jeux disponible.";
	}

	protected override string _GetTemplateForMessageDeveloperMetricsAvailableMultiple2()
	{
		return "Rapport d'analyse\u00a0: {month} {year}, pour {gameCount} jeux disponible.";
	}

	/// <summary>
	/// Key: "Message.FriendRequestAcceptedDouble"
	/// English String: "{userOne} and {userTwo} accepted your friend request."
	/// </summary>
	public override string MessageFriendRequestAcceptedDouble(string userOne, string userTwo)
	{
		return $"{userOne} et {userTwo} ont accepté tes demandes d'amitié.";
	}

	protected override string _GetTemplateForMessageFriendRequestAcceptedDouble()
	{
		return "{userOne} et {userTwo} ont accepté tes demandes d'amitié.";
	}

	protected override string _GetTemplateForMessageFriendRequestAcceptedMultiple()
	{
		return "{userOne}, {userTwo} et {userMultipleCount, plural, =1 {# autre utilisateur} other {# autres utilisateurs}} ont accepté tes demandes d'amitié.";
	}

	/// <summary>
	/// Key: "Message.FriendRequestAcceptedSingle"
	/// English String: "{userOne} accepted your friend request."
	/// </summary>
	public override string MessageFriendRequestAcceptedSingle(string userOne)
	{
		return $"{userOne} a accepté ta demande d'amitié.";
	}

	protected override string _GetTemplateForMessageFriendRequestAcceptedSingle()
	{
		return "{userOne} a accepté ta demande d'amitié.";
	}

	/// <summary>
	/// Key: "Message.FriendRequestSentDouble"
	/// English String: "{userOne} and {userTwo} sent you friend requests."
	/// </summary>
	public override string MessageFriendRequestSentDouble(string userOne, string userTwo)
	{
		return $"{userOne} et {userTwo} vous ont envoyé une demande d'amitié.";
	}

	protected override string _GetTemplateForMessageFriendRequestSentDouble()
	{
		return "{userOne} et {userTwo} vous ont envoyé une demande d'amitié.";
	}

	protected override string _GetTemplateForMessageFriendRequestSentMultiple()
	{
		return "{userOne}, {userTwo} et {userMultipleCount, plural, =1 {# autre utilisateur} other {# autres utilisateurs}} vous ont envoyé une demande d'amitié.";
	}

	/// <summary>
	/// Key: "Message.FriendRequestSentSingle"
	/// English String: "{userOne} sent you a friend request."
	/// </summary>
	public override string MessageFriendRequestSentSingle(string userOne)
	{
		return $"{userOne} vous a envoyé une demande d'amitié.";
	}

	protected override string _GetTemplateForMessageFriendRequestSentSingle()
	{
		return "{userOne} vous a envoyé une demande d'amitié.";
	}

	protected override string _GetTemplateForMessageGameNotPlayableOnDevice()
	{
		return "Pas compatible sur cet appareil";
	}

	/// <summary>
	/// Key: "Message.MessageAndPreview"
	/// English String: "{titleStart}Message from {username}:{titleEnd} {message}"
	/// </summary>
	public override string MessageMessageAndPreview(string titleStart, string username, string titleEnd, string message)
	{
		return $"{titleStart}Message de {username}\u00a0:{titleEnd} {message}";
	}

	protected override string _GetTemplateForMessageMessageAndPreview()
	{
		return "{titleStart}Message de {username}\u00a0:{titleEnd} {message}";
	}

	/// <summary>
	/// Key: "Message.MessageFrom"
	/// English String: "Message from {username}:"
	/// </summary>
	public override string MessageMessageFrom(string username)
	{
		return $"Message de {username}\u00a0:";
	}

	protected override string _GetTemplateForMessageMessageFrom()
	{
		return "Message de {username}\u00a0:";
	}

	protected override string _GetTemplateForMessageNumberofNewNotifications()
	{
		return "{notificationCount, plural, =1 {#\u00a0nouvelle notification} other {#\u00a0nouvelles notifications}}";
	}

	protected override string _GetTemplateForMessageTooManyFriendsOther()
	{
		return "L'utilisateur dispose déjà du nombre maximum d'amis autorisé.";
	}

	protected override string _GetTemplateForMessageTooManyFriendsSelf()
	{
		return "Vous disposez déjà du nombre maximum d'amis autorisé.";
	}

	/// <summary>
	/// Key: "Message.UnfollowedGame"
	/// Message displayed in game update card after user unfollowed the game
	/// English String: "Unfollowed {gameName}"
	/// </summary>
	public override string MessageUnfollowedGame(string gameName)
	{
		return $"Désabonné {gameName}";
	}

	protected override string _GetTemplateForMessageUnfollowedGame()
	{
		return "Désabonné {gameName}";
	}

	protected override string _GetTemplateForMessageYouHaveNewFriendRequests()
	{
		return "Vous avez {numberOfRequests}\u00a0{numberOfRequests, plural, =1 {nouvelle demande d'amitié} other {nouvelles demandes d'amitié}}.";
	}

	protected override string _GetTemplateForMessageYouHaveNewFriends()
	{
		return "Vous avez {numberOfFriends}\u00a0{numberOfFriends, plural, =1 {nouvel ami} other {nouveaux amis}}.";
	}

	protected override string _GetTemplateForMessageYouReceivedMessages()
	{
		return "Vous avez reçu {numberOfMessagesText}\u00a0{numberOfMessages, plural, =1 {message} other {messages}}";
	}
}
