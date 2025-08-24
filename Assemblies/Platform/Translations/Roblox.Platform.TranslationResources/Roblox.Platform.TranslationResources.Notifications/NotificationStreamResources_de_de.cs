namespace Roblox.TranslationResources.Notifications;

/// <summary>
/// This class overrides NotificationStreamResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class NotificationStreamResources_de_de : NotificationStreamResources_en_us, INotificationStreamResources, ITranslationResources
{
	/// <summary>
	/// Key: "Action.Accept"
	/// English String: "Accept"
	/// </summary>
	public override string ActionAccept => "Annehmen";

	/// <summary>
	/// Key: "Action.Cancel"
	/// English String: "Cancel"
	/// </summary>
	public override string ActionCancel => "Abbrechen";

	/// <summary>
	/// Key: "Action.Chat"
	/// English String: "Chat"
	/// </summary>
	public override string ActionChat => "Chatten";

	/// <summary>
	/// Key: "Action.Ignore"
	/// English String: "Ignore"
	/// </summary>
	public override string ActionIgnore => "Ignorieren";

	/// <summary>
	/// Key: "Action.Play"
	/// Label for button to launch game.
	/// English String: "Play"
	/// </summary>
	public override string ActionPlay => "Spielen";

	/// <summary>
	/// Key: "Action.ReportAbuse"
	/// Label for link to report a game update message
	/// English String: "Report Abuse"
	/// </summary>
	public override string ActionReportAbuse => "Verstoß melden";

	/// <summary>
	/// Key: "Action.Undo"
	/// Label for Undo link to reverse the unfollow action
	/// English String: "Undo"
	/// </summary>
	public override string ActionUndo => "Rückgängig machen";

	/// <summary>
	/// Key: "Action.View"
	/// English String: "View"
	/// </summary>
	public override string ActionView => "Ansehen";

	/// <summary>
	/// Key: "Action.ViewAll"
	/// English String: "View All"
	/// </summary>
	public override string ActionViewAll => "Alle ansehen";

	/// <summary>
	/// Key: "Heading.BackToAllNotifications"
	/// Heading displayed in game updates view, containing back link to notifications main view.
	/// English String: "All Notifications"
	/// </summary>
	public override string HeadingBackToAllNotifications => "Alle Benachrichtigungen";

	/// <summary>
	/// Key: "Label.NoNetworkConnectionText"
	/// English String: "Connecting..."
	/// </summary>
	public override string LabelNoNetworkConnectionText => "Verbindung\u00a0...";

	/// <summary>
	/// Key: "Label.NoNotifications"
	/// English String: "No Notifications"
	/// </summary>
	public override string LabelNoNotifications => "Keine Benachrichtigungen";

	/// <summary>
	/// Key: "Label.Notifications"
	/// English String: "Notifications"
	/// </summary>
	public override string LabelNotifications => "Benachrichtigungen";

	/// <summary>
	/// Key: "Label.Settings"
	/// English String: "Settings"
	/// </summary>
	public override string LabelSettings => "Einstellungen";

	/// <summary>
	/// Key: "Message.GameNotPlayableOnDevice"
	/// Message displayed on game update card when the game is not playable on the device type.
	/// English String: "Not playable on this device"
	/// </summary>
	public override string MessageGameNotPlayableOnDevice => "Auf diesem Gerät nicht spielbar";

	/// <summary>
	/// Key: "Message.TooManyFriendsOther"
	/// English String: "That user already has the max number of friends."
	/// </summary>
	public override string MessageTooManyFriendsOther => "Dieser Benutzer hat bereits die maximale Anzahl an Freunden.";

	/// <summary>
	/// Key: "Message.TooManyFriendsSelf"
	/// English String: "You already have the max number of friends."
	/// </summary>
	public override string MessageTooManyFriendsSelf => "Du hast bereits die maximale Anzahl an Freunden.";

	public NotificationStreamResources_de_de(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionAccept()
	{
		return "Annehmen";
	}

	protected override string _GetTemplateForActionCancel()
	{
		return "Abbrechen";
	}

	protected override string _GetTemplateForActionChat()
	{
		return "Chatten";
	}

	protected override string _GetTemplateForActionIgnore()
	{
		return "Ignorieren";
	}

	protected override string _GetTemplateForActionPlay()
	{
		return "Spielen";
	}

	protected override string _GetTemplateForActionReportAbuse()
	{
		return "Verstoß melden";
	}

	protected override string _GetTemplateForActionUndo()
	{
		return "Rückgängig machen";
	}

	/// <summary>
	/// Key: "Action.UnfollowGame"
	/// Label of menu item to unfollow the game
	/// English String: "Unfollow {gameName}"
	/// </summary>
	public override string ActionUnfollowGame(string gameName)
	{
		return $"{gameName} nicht mehr folgen";
	}

	protected override string _GetTemplateForActionUnfollowGame()
	{
		return "{gameName} nicht mehr folgen";
	}

	protected override string _GetTemplateForActionView()
	{
		return "Ansehen";
	}

	protected override string _GetTemplateForActionViewAll()
	{
		return "Alle ansehen";
	}

	protected override string _GetTemplateForHeadingBackToAllNotifications()
	{
		return "Alle Benachrichtigungen";
	}

	protected override string _GetTemplateForLabelNoNetworkConnectionText()
	{
		return "Verbindung\u00a0...";
	}

	protected override string _GetTemplateForLabelNoNotifications()
	{
		return "Keine Benachrichtigungen";
	}

	protected override string _GetTemplateForLabelNotifications()
	{
		return "Benachrichtigungen";
	}

	protected override string _GetTemplateForLabelSettings()
	{
		return "Einstellungen";
	}

	/// <summary>
	/// Key: "Message.AggregatedGameUpdateDouble"
	/// Message displayed on aggregated game update notification card, when there are exactly two games sending update.
	/// English String: "{gameOne} and {gameTwo} sent updates."
	/// </summary>
	public override string MessageAggregatedGameUpdateDouble(string gameOne, string gameTwo)
	{
		return $"{gameOne} und {gameTwo} haben Aktualisierungen gesendet.";
	}

	protected override string _GetTemplateForMessageAggregatedGameUpdateDouble()
	{
		return "{gameOne} und {gameTwo} haben Aktualisierungen gesendet.";
	}

	protected override string _GetTemplateForMessageAggregatedGameUpdateMultiple()
	{
		return "{gameOne}, {gameTwo} und {otherCount, plural, =1 {# other game} other {# other games}} haben Aktualisierungen gesendet.";
	}

	/// <summary>
	/// Key: "Message.ConfirmAcceptedDouble"
	/// English String: "{userOne} and {userTwo}"
	/// </summary>
	public override string MessageConfirmAcceptedDouble(string userOne, string userTwo)
	{
		return $"{userOne} und {userTwo}";
	}

	protected override string _GetTemplateForMessageConfirmAcceptedDouble()
	{
		return "{userOne} und {userTwo}";
	}

	protected override string _GetTemplateForMessageConfirmAcceptedMultiple()
	{
		return "{userOne}, {userTwo} und {userMultipleCount, plural, =1 {# weiterer Benutzer} other {# weitere Benutzer}}";
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
		return $"{userOne} und {userTwo} sind jetzt mit dir befreundet!";
	}

	protected override string _GetTemplateForMessageConfirmSentDouble()
	{
		return "{userOne} und {userTwo} sind jetzt mit dir befreundet!";
	}

	protected override string _GetTemplateForMessageConfirmSentMultiple()
	{
		return "{userOne}, {userTwo} und {userMultipleCount, plural, =1 {# weiterer Benutzer} other {# weitere Benutzer}} sind jetzt mit dir befreundet!";
	}

	/// <summary>
	/// Key: "Message.ConfirmSentSingle"
	/// English String: "{userOne} is now your friend!"
	/// </summary>
	public override string MessageConfirmSentSingle(string userOne)
	{
		return $"{userOne} ist jetzt mit dir befreundet!";
	}

	protected override string _GetTemplateForMessageConfirmSentSingle()
	{
		return "{userOne} ist jetzt mit dir befreundet!";
	}

	/// <summary>
	/// Key: "Message.DeveloperMetricsAvailable"
	/// English String: "{month} {year} Analytics Report for {gameName} available."
	/// </summary>
	public override string MessageDeveloperMetricsAvailable(string month, string year, string gameName)
	{
		return $"{month} {year} Analysebericht für {gameName} verfügbar.";
	}

	protected override string _GetTemplateForMessageDeveloperMetricsAvailable()
	{
		return "{month} {year} Analysebericht für {gameName} verfügbar.";
	}

	protected override string _GetTemplateForMessageDeveloperMetricsAvailableMultiple()
	{
		return "{month} {year} Analysebericht für {gameName} und {otherCount, plural, =1 {# andere Spiel} other {# andere Spiele}} verfügbar";
	}

	/// <summary>
	/// Key: "Message.DeveloperMetricsAvailableMultiple2"
	/// English String: "{month} {year} Analytics Report for {gameCount} games available."
	/// </summary>
	public override string MessageDeveloperMetricsAvailableMultiple2(string month, string year, string gameCount)
	{
		return $"{month} {year} Analysebericht für {gameCount} Spiele verfügbar.";
	}

	protected override string _GetTemplateForMessageDeveloperMetricsAvailableMultiple2()
	{
		return "{month} {year} Analysebericht für {gameCount} Spiele verfügbar.";
	}

	/// <summary>
	/// Key: "Message.FriendRequestAcceptedDouble"
	/// English String: "{userOne} and {userTwo} accepted your friend request."
	/// </summary>
	public override string MessageFriendRequestAcceptedDouble(string userOne, string userTwo)
	{
		return $"{userOne} und {userTwo} haben deine Freundesanfragen angenommen.";
	}

	protected override string _GetTemplateForMessageFriendRequestAcceptedDouble()
	{
		return "{userOne} und {userTwo} haben deine Freundesanfragen angenommen.";
	}

	protected override string _GetTemplateForMessageFriendRequestAcceptedMultiple()
	{
		return "{userOne}, {userTwo} und {userMultipleCount, plural, =1 {# weiterer Benutzer} other {# weitere Benutzer}} haben deine Freundesanfragen angenommen.";
	}

	/// <summary>
	/// Key: "Message.FriendRequestAcceptedSingle"
	/// English String: "{userOne} accepted your friend request."
	/// </summary>
	public override string MessageFriendRequestAcceptedSingle(string userOne)
	{
		return $"{userOne} hat deine Freundesanfrage angenommen.";
	}

	protected override string _GetTemplateForMessageFriendRequestAcceptedSingle()
	{
		return "{userOne} hat deine Freundesanfrage angenommen.";
	}

	/// <summary>
	/// Key: "Message.FriendRequestSentDouble"
	/// English String: "{userOne} and {userTwo} sent you friend requests."
	/// </summary>
	public override string MessageFriendRequestSentDouble(string userOne, string userTwo)
	{
		return $"{userOne} und {userTwo} haben dir Freundesanfragen gesendet.";
	}

	protected override string _GetTemplateForMessageFriendRequestSentDouble()
	{
		return "{userOne} und {userTwo} haben dir Freundesanfragen gesendet.";
	}

	protected override string _GetTemplateForMessageFriendRequestSentMultiple()
	{
		return "{userOne}, {userTwo} und {userMultipleCount, plural, =1 {# weiterer Benutzer} other {# weitere Benutzer}} haben dir Freundesanfragen gesendet.";
	}

	/// <summary>
	/// Key: "Message.FriendRequestSentSingle"
	/// English String: "{userOne} sent you a friend request."
	/// </summary>
	public override string MessageFriendRequestSentSingle(string userOne)
	{
		return $"{userOne} hat dir eine Freundesanfrage gesendet.";
	}

	protected override string _GetTemplateForMessageFriendRequestSentSingle()
	{
		return "{userOne} hat dir eine Freundesanfrage gesendet.";
	}

	protected override string _GetTemplateForMessageGameNotPlayableOnDevice()
	{
		return "Auf diesem Gerät nicht spielbar";
	}

	/// <summary>
	/// Key: "Message.MessageAndPreview"
	/// English String: "{titleStart}Message from {username}:{titleEnd} {message}"
	/// </summary>
	public override string MessageMessageAndPreview(string titleStart, string username, string titleEnd, string message)
	{
		return $"{titleStart}Nachricht von {username}:{titleEnd} {message}";
	}

	protected override string _GetTemplateForMessageMessageAndPreview()
	{
		return "{titleStart}Nachricht von {username}:{titleEnd} {message}";
	}

	/// <summary>
	/// Key: "Message.MessageFrom"
	/// English String: "Message from {username}:"
	/// </summary>
	public override string MessageMessageFrom(string username)
	{
		return $"Nachricht von {username}:";
	}

	protected override string _GetTemplateForMessageMessageFrom()
	{
		return "Nachricht von {username}:";
	}

	protected override string _GetTemplateForMessageNumberofNewNotifications()
	{
		return "{notificationCount, plural, =1 {# Neue Benachrichtigung} other {# Neue Benachrichtigungen}}";
	}

	protected override string _GetTemplateForMessageTooManyFriendsOther()
	{
		return "Dieser Benutzer hat bereits die maximale Anzahl an Freunden.";
	}

	protected override string _GetTemplateForMessageTooManyFriendsSelf()
	{
		return "Du hast bereits die maximale Anzahl an Freunden.";
	}

	/// <summary>
	/// Key: "Message.UnfollowedGame"
	/// Message displayed in game update card after user unfollowed the game
	/// English String: "Unfollowed {gameName}"
	/// </summary>
	public override string MessageUnfollowedGame(string gameName)
	{
		return $"{gameName} wird nicht mehr gefolgt";
	}

	protected override string _GetTemplateForMessageUnfollowedGame()
	{
		return "{gameName} wird nicht mehr gefolgt";
	}

	protected override string _GetTemplateForMessageYouHaveNewFriendRequests()
	{
		return "Du hast {numberOfRequests} neue {numberOfRequests, plural, =1 {Freundesanfrage} other {Freundesanfragen}}.";
	}

	protected override string _GetTemplateForMessageYouHaveNewFriends()
	{
		return "Du hast {numberOfFriends} {numberOfFriends, plural, =1 {neuen Freund} other {neue Freunde}}.";
	}

	protected override string _GetTemplateForMessageYouReceivedMessages()
	{
		return "Du hast {numberOfMessagesText} {numberOfMessages, plural, =1 {Nachricht} other {Nachrichten}} erhalten.";
	}
}
