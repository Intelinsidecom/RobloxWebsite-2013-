namespace Roblox.TranslationResources.Feature;

/// <summary>
/// This class overrides ChatResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class ChatResources_de_de : ChatResources_en_us, IChatResources, ITranslationResources
{
	/// <summary>
	/// Key: "Action.Add"
	/// English String: "Add"
	/// </summary>
	public override string ActionAdd => "Hinzufügen";

	/// <summary>
	/// Key: "Action.BuyAccess"
	/// English String: "Buy Access"
	/// </summary>
	public override string ActionBuyAccess => "Zugang kaufen";

	/// <summary>
	/// Key: "Action.Cancel"
	/// English String: "Cancel"
	/// </summary>
	public override string ActionCancel => "Abbrechen";

	/// <summary>
	/// Key: "Action.Create"
	/// English String: "Create"
	/// </summary>
	public override string ActionCreate => "Erstellen";

	/// <summary>
	/// Key: "Action.Join"
	/// join the voice chat conversation
	/// English String: "Join"
	/// </summary>
	public override string ActionJoin => "Beitreten";

	/// <summary>
	/// Key: "Action.JoinVoice"
	/// Join voice call
	/// English String: "Join"
	/// </summary>
	public override string ActionJoinVoice => "Verbinden";

	/// <summary>
	/// Key: "Action.Leave"
	/// English String: "Leave"
	/// </summary>
	public override string ActionLeave => "Verlassen";

	/// <summary>
	/// Key: "Action.LeaveVoice"
	/// Leave voice chat
	/// English String: "Leave"
	/// </summary>
	public override string ActionLeaveVoice => "Verlassen";

	/// <summary>
	/// Key: "Action.Mute"
	/// mute microphone in short term
	/// English String: "Mute"
	/// </summary>
	public override string ActionMute => "Stummschaltung";

	/// <summary>
	/// Key: "Action.Remove"
	/// English String: "Remove"
	/// </summary>
	public override string ActionRemove => "Entfernen";

	/// <summary>
	/// Key: "Action.Report"
	/// English String: "Report"
	/// </summary>
	public override string ActionReport => "Melden";

	/// <summary>
	/// Key: "Action.Save"
	/// English String: "Save"
	/// </summary>
	public override string ActionSave => "Speichern";

	/// <summary>
	/// Key: "Action.Send"
	/// English String: "Send"
	/// </summary>
	public override string ActionSend => "Senden";

	/// <summary>
	/// Key: "Action.Set"
	/// English String: "Set"
	/// </summary>
	public override string ActionSet => "Festlegen";

	/// <summary>
	/// Key: "Action.StartParty"
	/// button label
	/// English String: "Start a Party"
	/// </summary>
	public override string ActionStartParty => "Gründe ein Team";

	/// <summary>
	/// Key: "Action.Stay"
	/// English String: "Stay"
	/// </summary>
	public override string ActionStay => "Bleiben";

	/// <summary>
	/// Key: "Action.TurnOn"
	/// English String: "Turn On"
	/// </summary>
	public override string ActionTurnOn => "Aktivieren";

	/// <summary>
	/// Key: "Action.Unmute"
	/// unmute mic in short term
	/// English String: "Unmute"
	/// </summary>
	public override string ActionUnmute => "Stummschaltung aufheben";

	/// <summary>
	/// Key: "Heading.BuyItem"
	/// English String: "Buy Item"
	/// </summary>
	public override string HeadingBuyItem => "Artikel kaufen";

	/// <summary>
	/// Key: "Heading.Chat"
	/// English String: "Chat"
	/// </summary>
	public override string HeadingChat => "Chat";

	public override string HeadingChatAndParty => "Chat und Party";

	/// <summary>
	/// Key: "Heading.ConfirmLeaving"
	/// English String: "Are you sure to leave this chat group?"
	/// </summary>
	public override string HeadingConfirmLeaving => "Möchtest du diese Chatgruppe wirklich verlassen?";

	/// <summary>
	/// Key: "Heading.ContinueToReport"
	/// English String: "Continue to report?"
	/// </summary>
	public override string HeadingContinueToReport => "Weiter zum Melden?";

	/// <summary>
	/// Key: "Heading.CreateParty"
	/// English String: "Create Party"
	/// </summary>
	public override string HeadingCreateParty => "Team erstellen";

	/// <summary>
	/// Key: "Heading.LeaveChatGroup"
	/// English String: "Leave Chat Group"
	/// </summary>
	public override string HeadingLeaveChatGroup => "Chatgruppe verlassen";

	/// <summary>
	/// Key: "Heading.LeaveChatGroupQ"
	/// English String: "Leave Chat Group?"
	/// </summary>
	public override string HeadingLeaveChatGroupQ => "Chatgruppe verlassen?";

	/// <summary>
	/// Key: "Heading.NewChatGroup"
	/// English String: "New Chat Group"
	/// </summary>
	public override string HeadingNewChatGroup => "Neue Chatgruppe";

	/// <summary>
	/// Key: "Heading.RemoveUser"
	/// English String: "Remove User?"
	/// </summary>
	public override string HeadingRemoveUser => "Benutzer entfernen?";

	/// <summary>
	/// Key: "Heading.Report"
	/// heading for abuse report dialog
	/// English String: "Report"
	/// </summary>
	public override string HeadingReport => "Melden";

	/// <summary>
	/// Key: "Label.AddFriends"
	/// English String: "Add Friends"
	/// </summary>
	public override string LabelAddFriends => "Freunde hinzufügen";

	/// <summary>
	/// Key: "Label.BuyButton"
	/// English String: "Buy"
	/// </summary>
	public override string LabelBuyButton => "Kaufen";

	/// <summary>
	/// Key: "Label.ChangeChatGroupName"
	/// English String: "Change your chat group name"
	/// </summary>
	public override string LabelChangeChatGroupName => "Benenne deine Chatgruppe um";

	/// <summary>
	/// Key: "Label.ChatDetails"
	/// English String: "Chat Details"
	/// </summary>
	public override string LabelChatDetails => "Chatinfos";

	/// <summary>
	/// Key: "Label.ChatGroupName"
	/// English String: "Chat Group Name"
	/// </summary>
	public override string LabelChatGroupName => "Name der Chatgruppe";

	/// <summary>
	/// Key: "Label.Close"
	/// English String: "Close"
	/// </summary>
	public override string LabelClose => "Schließen";

	/// <summary>
	/// Key: "Label.ConversationNotifications"
	/// conversation notification
	/// English String: "Notifications"
	/// </summary>
	public override string LabelConversationNotifications => "Benachrichtigungen";

	/// <summary>
	/// Key: "Label.ConversationNotificationsOn"
	/// conversation notification is on
	/// English String: "On"
	/// </summary>
	public override string LabelConversationNotificationsOn => "An";

	/// <summary>
	/// Key: "Label.Details.PlayTogether"
	/// English String: "PlayTogether"
	/// </summary>
	public override string LabelDetailsPlayTogether => "Spiel mit anderen";

	/// <summary>
	/// Key: "Label.FindGame"
	/// English String: "Find Game"
	/// </summary>
	public override string LabelFindGame => "Spiel suchen";

	/// <summary>
	/// Key: "Label.GameNotAvailableButton"
	/// English String: "Not Available"
	/// </summary>
	public override string LabelGameNotAvailableButton => "Nicht verfügbar";

	/// <summary>
	/// Key: "Label.General"
	/// English String: "General"
	/// </summary>
	public override string LabelGeneral => "Allgemein";

	/// <summary>
	/// Key: "Label.InGame"
	/// English String: "In Game"
	/// </summary>
	public override string LabelInGame => "Im Spiel";

	/// <summary>
	/// Key: "Label.InputPlaceHolder.SearchForFriends"
	/// English String: "Search for friends"
	/// </summary>
	public override string LabelInputPlaceHolderSearchForFriends => "Suche nach Freunden";

	/// <summary>
	/// Key: "Label.InputPlaceHolder.SendMessage"
	/// English String: "Send a message"
	/// </summary>
	public override string LabelInputPlaceHolderSendMessage => "Sende eine Nachricht";

	/// <summary>
	/// Key: "Label.InStudio"
	/// English String: "In Studio"
	/// </summary>
	public override string LabelInStudio => "In Studio";

	/// <summary>
	/// Key: "Label.JoinButton"
	/// English String: "Join"
	/// </summary>
	public override string LabelJoinButton => "Beitreten";

	/// <summary>
	/// Key: "Label.JoinGame"
	/// English String: "Join Game"
	/// </summary>
	public override string LabelJoinGame => "Spiel beitreten";

	/// <summary>
	/// Key: "Label.JoinParty"
	/// English String: "Join Party"
	/// </summary>
	public override string LabelJoinParty => "Team beitreten";

	/// <summary>
	/// Key: "Label.LeaveChatGroup"
	/// English String: "Leave Chat Group"
	/// </summary>
	public override string LabelLeaveChatGroup => "Chatgruppe verlassen";

	/// <summary>
	/// Key: "Label.LeaveParty"
	/// English String: "Leave Party"
	/// </summary>
	public override string LabelLeaveParty => "Team verlassen";

	/// <summary>
	/// Key: "Label.Member"
	/// English String: "Member"
	/// </summary>
	public override string LabelMember => "Mitglied";

	/// <summary>
	/// Key: "Label.Members"
	/// English String: "Members"
	/// </summary>
	public override string LabelMembers => "Mitglieder";

	/// <summary>
	/// Key: "Label.Mute15Minutes"
	/// mute conversation for 15 mins
	/// English String: "For 15 minutes"
	/// </summary>
	public override string LabelMute15Minutes => "15 Minuten";

	/// <summary>
	/// Key: "Label.Mute1Hour"
	/// Mute conversation for 1 hour
	/// English String: "For an hour"
	/// </summary>
	public override string LabelMute1Hour => "Eine Stunde";

	/// <summary>
	/// Key: "Label.Mute24Hours"
	/// Mute conversation for a day
	/// English String: "For a day"
	/// </summary>
	public override string LabelMute24Hours => "Einen Tag";

	/// <summary>
	/// Key: "Label.Mute8Hours"
	/// Mute conversation for 8 hours
	/// English String: "For 8 hours"
	/// </summary>
	public override string LabelMute8Hours => "8 Stunden";

	/// <summary>
	/// Key: "Label.MuteConversationNotificationsForGroup"
	/// English String: "Mute notifications for this chat group"
	/// </summary>
	public override string LabelMuteConversationNotificationsForGroup => "Benachrichtigungen für diese Chatgruppe stummschalten";

	/// <summary>
	/// Key: "Label.MuteConversationNotificationsForOneToOne"
	/// English String: "Mute notifications for this conversation"
	/// </summary>
	public override string LabelMuteConversationNotificationsForOneToOne => "Benachrichtigungen für diese Konversation stummschalten";

	/// <summary>
	/// Key: "Label.MuteInfinite"
	/// Mute conversation until user turns back
	/// English String: "Until I turn them back on"
	/// </summary>
	public override string LabelMuteInfinite => "Bis ich sie wieder aktiviere";

	/// <summary>
	/// Key: "Label.NameYourChangeGroup"
	/// English String: "Name your change group"
	/// </summary>
	public override string LabelNameYourChangeGroup => "Benenne deine Chatgruppe";

	/// <summary>
	/// Key: "Label.NameYourChatGroup"
	/// English String: "Name your chat group"
	/// </summary>
	public override string LabelNameYourChatGroup => "Benenne deine Chatgruppe";

	/// <summary>
	/// Key: "Label.NotImplementedMessageType"
	/// This message is displayed in chat when user receives message type that can't be rendered by current app version and update is not available, yet (e.g. latest version was rolled back, or in deprecated Android native chat)
	/// English String: "This message could not be displayed."
	/// </summary>
	public override string LabelNotImplementedMessageType => "Die Nachricht konnte nicht angezeigt werden.";

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
	public override string LabelPinGameTooltip => "Spiel anheften";

	/// <summary>
	/// Key: "Label.PinnedGame"
	/// This is a title of card, means this game card is pinned game
	/// English String: "Pinned Game"
	/// </summary>
	public override string LabelPinnedGame => "Angeheftetes Spiel";

	/// <summary>
	/// Key: "Label.PlayButton"
	/// English String: "Play"
	/// </summary>
	public override string LabelPlayButton => "Spielen";

	/// <summary>
	/// Key: "Label.PlayGames"
	/// English String: "Play Games"
	/// </summary>
	public override string LabelPlayGames => "Spielen";

	/// <summary>
	/// Key: "Label.PlayTogether"
	/// English String: "Play Together"
	/// </summary>
	public override string LabelPlayTogether => "Spiel mit anderen";

	/// <summary>
	/// Key: "Label.RecommendedGames"
	/// English String: "Recommended"
	/// </summary>
	public override string LabelRecommendedGames => "Empfohlen";

	/// <summary>
	/// Key: "Label.SeeLess"
	/// English String: "See Less"
	/// </summary>
	public override string LabelSeeLess => "Weniger ansehen";

	/// <summary>
	/// Key: "Label.SeeMore"
	/// English String: "See More"
	/// </summary>
	public override string LabelSeeMore => "Mehr ansehen";

	/// <summary>
	/// Key: "Label.ShowLessGames"
	/// English String: "Show Less"
	/// </summary>
	public override string LabelShowLessGames => "Weniger anzeigen";

	/// <summary>
	/// Key: "Label.SpanTitle.CreateGroupNeeds2More"
	/// English String: "Add at least 2 people to create chat group"
	/// </summary>
	public override string LabelSpanTitleCreateGroupNeeds2More => "Füge mindestens 2 Leute hinzu, um eine Chatgruppe zu erstellen.";

	/// <summary>
	/// Key: "Label.SpanTitle.Loading"
	/// English String: "loading ..."
	/// </summary>
	public override string LabelSpanTitleLoading => "Wird geladen\u00a0...";

	/// <summary>
	/// Key: "Label.TimestampOffUntilTomorrow"
	/// English String: "Off until tomorrow"
	/// </summary>
	public override string LabelTimestampOffUntilTomorrow => "Bis morgen ausschalten";

	/// <summary>
	/// Key: "Label.TimestampOffUntilTurnedBackOn"
	/// English String: "Off until turned back on\""
	/// </summary>
	public override string LabelTimestampOffUntilTurnedBackOn => "Ausschalten, bis ich sie wieder aktiviere";

	/// <summary>
	/// Key: "Label.TurnOnConversationNotificationsPrompt"
	/// English String: "Do you want to turn on notifications?"
	/// </summary>
	public override string LabelTurnOnConversationNotificationsPrompt => "Möchtest du Benachrichtigungen aktivieren?";

	/// <summary>
	/// Key: "Label.UnpinGameTooltip"
	/// English String: "Unpin Game"
	/// </summary>
	public override string LabelUnpinGameTooltip => "Spiel nicht mehr anheften";

	/// <summary>
	/// Key: "Label.ViewDetailsButton"
	/// English String: "View Details"
	/// </summary>
	public override string LabelViewDetailsButton => "Infos anzeigen";

	/// <summary>
	/// Key: "Label.ViewProfile"
	/// English String: "View Profile"
	/// </summary>
	public override string LabelViewProfile => "Profil ansehen";

	/// <summary>
	/// Key: "Label.Yesterday"
	/// time stamp for chat message received yesterday
	/// English String: "Yesterday"
	/// </summary>
	public override string LabelYesterday => "Gestern";

	/// <summary>
	/// Key: "Message.ConversationTitleModerated"
	/// Chat group name was moderated.
	/// English String: "Chat group name was moderated."
	/// </summary>
	public override string MessageConversationTitleModerated => "Name der Chatgruppe wurde von einem Moderator angepasst.";

	/// <summary>
	/// Key: "Message.Default"
	/// English String: "Not everyone in this chat can see your message."
	/// </summary>
	public override string MessageDefault => "Nicht jeder Chatteilnehmer kann deine Nachricht sehen.";

	/// <summary>
	/// Key: "Message.DefaultErrorMsg"
	/// English String: "An error occurred"
	/// </summary>
	public override string MessageDefaultErrorMsg => "Ein Fehler ist aufgetreten.";

	/// <summary>
	/// Key: "Message.Error"
	/// English String: "Error"
	/// </summary>
	public override string MessageError => "Fehler";

	/// <summary>
	/// Key: "Message.JoinPartyText"
	/// English String: "The party leader is finding a game to play."
	/// </summary>
	public override string MessageJoinPartyText => "Der Teamleiter sucht nach einem passenden Spiel.";

	/// <summary>
	/// Key: "Message.MakeFriendsToChatNPlay"
	/// English String: "Make friends to start chatting and partying!"
	/// </summary>
	public override string MessageMakeFriendsToChatNPlay => "Finde Freunde für Teams und zum Chatten!";

	/// <summary>
	/// Key: "Message.MessageContentModerated"
	/// English String: "Your message was moderated and not sent."
	/// </summary>
	public override string MessageMessageContentModerated => "Deine Nachricht wurde von einem Moderator angepasst und nicht gesendet.";

	/// <summary>
	/// Key: "Message.MessageFilterForReceivers"
	/// English String: "Not everyone in this chat can see your message."
	/// </summary>
	public override string MessageMessageFilterForReceivers => "Nicht jeder Chatteilnehmer kann deine Nachricht sehen.";

	/// <summary>
	/// Key: "Message.NoConnectionMsg"
	/// English String: "Connecting..."
	/// </summary>
	public override string MessageNoConnectionMsg => "Verbindung\u00a0...";

	/// <summary>
	/// Key: "Message.PartyInviteMsg"
	/// English String: "PARTY INVITE!"
	/// </summary>
	public override string MessagePartyInviteMsg => "TEAMEINLADUNG!";

	/// <summary>
	/// Key: "Message.PlayGameUpdate"
	/// English String: " is playing the pinned game: "
	/// </summary>
	public override string MessagePlayGameUpdate => " spielt das angeheftete Spiel: ";

	/// <summary>
	/// Key: "Message.TextTooLong"
	/// English String: "Your message was too long and not sent."
	/// </summary>
	public override string MessageTextTooLong => "Deine Nachricht war zu lang und wurde nicht gesendet.";

	/// <summary>
	/// Key: "Message.UnknownMessageType"
	/// This serves as the fallback string for when an message type is received that the web chat does not know how to render.
	/// English String: "A message cannot be displayed"
	/// </summary>
	public override string MessageUnknownMessageType => "Eine Nachricht kann nicht angezeigt werden";

	/// <summary>
	/// Key: "PlayButton"
	/// English String: "Play"
	/// </summary>
	public override string PlayButton => "Spielen";

	/// <summary>
	/// Key: "Response.PartyInvite"
	/// notification message
	/// English String: "You received a party Invite."
	/// </summary>
	public override string ResponsePartyInvite => "Du hast eine Teameinladung erhalten.";

	public ChatResources_de_de(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionAdd()
	{
		return "Hinzufügen";
	}

	protected override string _GetTemplateForActionBuyAccess()
	{
		return "Zugang kaufen";
	}

	protected override string _GetTemplateForActionCancel()
	{
		return "Abbrechen";
	}

	protected override string _GetTemplateForActionCreate()
	{
		return "Erstellen";
	}

	protected override string _GetTemplateForActionJoin()
	{
		return "Beitreten";
	}

	protected override string _GetTemplateForActionJoinVoice()
	{
		return "Verbinden";
	}

	protected override string _GetTemplateForActionLeave()
	{
		return "Verlassen";
	}

	protected override string _GetTemplateForActionLeaveVoice()
	{
		return "Verlassen";
	}

	protected override string _GetTemplateForActionMute()
	{
		return "Stummschaltung";
	}

	protected override string _GetTemplateForActionRemove()
	{
		return "Entfernen";
	}

	protected override string _GetTemplateForActionReport()
	{
		return "Melden";
	}

	protected override string _GetTemplateForActionSave()
	{
		return "Speichern";
	}

	protected override string _GetTemplateForActionSend()
	{
		return "Senden";
	}

	protected override string _GetTemplateForActionSet()
	{
		return "Festlegen";
	}

	protected override string _GetTemplateForActionStartParty()
	{
		return "Gründe ein Team";
	}

	protected override string _GetTemplateForActionStay()
	{
		return "Bleiben";
	}

	protected override string _GetTemplateForActionTurnOn()
	{
		return "Aktivieren";
	}

	protected override string _GetTemplateForActionUnmute()
	{
		return "Stummschaltung aufheben";
	}

	protected override string _GetTemplateForHeadingBuyItem()
	{
		return "Artikel kaufen";
	}

	protected override string _GetTemplateForHeadingChat()
	{
		return "Chat";
	}

	protected override string _GetTemplateForHeadingChatAndParty()
	{
		return "Chat und Party";
	}

	protected override string _GetTemplateForHeadingConfirmLeaving()
	{
		return "Möchtest du diese Chatgruppe wirklich verlassen?";
	}

	protected override string _GetTemplateForHeadingContinueToReport()
	{
		return "Weiter zum Melden?";
	}

	protected override string _GetTemplateForHeadingCreateParty()
	{
		return "Team erstellen";
	}

	protected override string _GetTemplateForHeadingLeaveChatGroup()
	{
		return "Chatgruppe verlassen";
	}

	protected override string _GetTemplateForHeadingLeaveChatGroupQ()
	{
		return "Chatgruppe verlassen?";
	}

	protected override string _GetTemplateForHeadingNewChatGroup()
	{
		return "Neue Chatgruppe";
	}

	protected override string _GetTemplateForHeadingRemoveUser()
	{
		return "Benutzer entfernen?";
	}

	protected override string _GetTemplateForHeadingReport()
	{
		return "Melden";
	}

	protected override string _GetTemplateForLabelAddFriends()
	{
		return "Freunde hinzufügen";
	}

	/// <summary>
	/// Key: "Label.BuyAccessToGameForModal"
	/// English String: "Would you like to buy access to the Place: {placeName} from {creatorName} for {robux}?"
	/// </summary>
	public override string LabelBuyAccessToGameForModal(string placeName, string creatorName, string robux)
	{
		return $"Möchtest du Zugang zu diesem Ort kaufen: {placeName} von {creatorName} für {robux}?";
	}

	protected override string _GetTemplateForLabelBuyAccessToGameForModal()
	{
		return "Möchtest du Zugang zu diesem Ort kaufen: {placeName} von {creatorName} für {robux}?";
	}

	protected override string _GetTemplateForLabelBuyButton()
	{
		return "Kaufen";
	}

	protected override string _GetTemplateForLabelChangeChatGroupName()
	{
		return "Benenne deine Chatgruppe um";
	}

	protected override string _GetTemplateForLabelChatDetails()
	{
		return "Chatinfos";
	}

	protected override string _GetTemplateForLabelChatGroupName()
	{
		return "Name der Chatgruppe";
	}

	protected override string _GetTemplateForLabelClose()
	{
		return "Schließen";
	}

	protected override string _GetTemplateForLabelConversationNotifications()
	{
		return "Benachrichtigungen";
	}

	protected override string _GetTemplateForLabelConversationNotificationsOn()
	{
		return "An";
	}

	protected override string _GetTemplateForLabelDetailsPlayTogether()
	{
		return "Spiel mit anderen";
	}

	protected override string _GetTemplateForLabelFindGame()
	{
		return "Spiel suchen";
	}

	protected override string _GetTemplateForLabelGameNotAvailableButton()
	{
		return "Nicht verfügbar";
	}

	protected override string _GetTemplateForLabelGeneral()
	{
		return "Allgemein";
	}

	protected override string _GetTemplateForLabelInGame()
	{
		return "Im Spiel";
	}

	protected override string _GetTemplateForLabelInputPlaceHolderSearchForFriends()
	{
		return "Suche nach Freunden";
	}

	protected override string _GetTemplateForLabelInputPlaceHolderSendMessage()
	{
		return "Sende eine Nachricht";
	}

	protected override string _GetTemplateForLabelInStudio()
	{
		return "In Studio";
	}

	protected override string _GetTemplateForLabelJoinButton()
	{
		return "Beitreten";
	}

	protected override string _GetTemplateForLabelJoinGame()
	{
		return "Spiel beitreten";
	}

	protected override string _GetTemplateForLabelJoinParty()
	{
		return "Team beitreten";
	}

	protected override string _GetTemplateForLabelLeaveChatGroup()
	{
		return "Chatgruppe verlassen";
	}

	protected override string _GetTemplateForLabelLeaveParty()
	{
		return "Team verlassen";
	}

	protected override string _GetTemplateForLabelMember()
	{
		return "Mitglied";
	}

	/// <summary>
	/// Key: "Label.MemberJoinText"
	/// English String: "{userName} joined the party"
	/// </summary>
	public override string LabelMemberJoinText(string userName)
	{
		return $"{userName} ist dem Team beigetreten";
	}

	protected override string _GetTemplateForLabelMemberJoinText()
	{
		return "{userName} ist dem Team beigetreten";
	}

	protected override string _GetTemplateForLabelMembers()
	{
		return "Mitglieder";
	}

	protected override string _GetTemplateForLabelMute15Minutes()
	{
		return "15 Minuten";
	}

	protected override string _GetTemplateForLabelMute1Hour()
	{
		return "Eine Stunde";
	}

	protected override string _GetTemplateForLabelMute24Hours()
	{
		return "Einen Tag";
	}

	protected override string _GetTemplateForLabelMute8Hours()
	{
		return "8 Stunden";
	}

	protected override string _GetTemplateForLabelMuteConversationNotificationsForGroup()
	{
		return "Benachrichtigungen für diese Chatgruppe stummschalten";
	}

	protected override string _GetTemplateForLabelMuteConversationNotificationsForOneToOne()
	{
		return "Benachrichtigungen für diese Konversation stummschalten";
	}

	protected override string _GetTemplateForLabelMuteInfinite()
	{
		return "Bis ich sie wieder aktiviere";
	}

	protected override string _GetTemplateForLabelNameYourChangeGroup()
	{
		return "Benenne deine Chatgruppe";
	}

	protected override string _GetTemplateForLabelNameYourChatGroup()
	{
		return "Benenne deine Chatgruppe";
	}

	protected override string _GetTemplateForLabelNotImplementedMessageType()
	{
		return "Die Nachricht konnte nicht angezeigt werden.";
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
		return $"{userName} leitet das Team";
	}

	protected override string _GetTemplateForLabelPartyLeaderTooltip()
	{
		return "{userName} leitet das Team";
	}

	/// <summary>
	/// Key: "Label.PartyMemberTooltip"
	/// English String: "{userName} is in the party"
	/// </summary>
	public override string LabelPartyMemberTooltip(string userName)
	{
		return $"{userName} ist im Team";
	}

	protected override string _GetTemplateForLabelPartyMemberTooltip()
	{
		return "{userName} ist im Team";
	}

	/// <summary>
	/// Key: "Label.PartyName"
	/// English String: "Party : {title}"
	/// </summary>
	public override string LabelPartyName(string title)
	{
		return $"Team: {title}";
	}

	protected override string _GetTemplateForLabelPartyName()
	{
		return "Team: {title}";
	}

	/// <summary>
	/// Key: "Label.PendingMemberTooltip"
	/// English String: "{userName} is not in the party"
	/// </summary>
	public override string LabelPendingMemberTooltip(string userName)
	{
		return $"{userName} ist nicht im Team";
	}

	protected override string _GetTemplateForLabelPendingMemberTooltip()
	{
		return "{userName} ist nicht im Team";
	}

	protected override string _GetTemplateForLabelPinGameTooltip()
	{
		return "Spiel anheften";
	}

	protected override string _GetTemplateForLabelPinnedGame()
	{
		return "Angeheftetes Spiel";
	}

	protected override string _GetTemplateForLabelPlayButton()
	{
		return "Spielen";
	}

	protected override string _GetTemplateForLabelPlayGames()
	{
		return "Spielen";
	}

	/// <summary>
	/// Key: "Label.PlayingGame"
	/// English String: "Playing {game}"
	/// </summary>
	public override string LabelPlayingGame(string game)
	{
		return $"Spielt {game}";
	}

	protected override string _GetTemplateForLabelPlayingGame()
	{
		return "Spielt {game}";
	}

	protected override string _GetTemplateForLabelPlayTogether()
	{
		return "Spiel mit anderen";
	}

	protected override string _GetTemplateForLabelRecommendedGames()
	{
		return "Empfohlen";
	}

	protected override string _GetTemplateForLabelSeeLess()
	{
		return "Weniger ansehen";
	}

	protected override string _GetTemplateForLabelSeeMore()
	{
		return "Mehr ansehen";
	}

	protected override string _GetTemplateForLabelShowLessGames()
	{
		return "Weniger anzeigen";
	}

	/// <summary>
	/// Key: "Label.ShowMoreGames"
	/// English String: "Show More (+{count})"
	/// </summary>
	public override string LabelShowMoreGames(string count)
	{
		return $"Mehr anzeigen (+{count})";
	}

	protected override string _GetTemplateForLabelShowMoreGames()
	{
		return "Mehr anzeigen (+{count})";
	}

	protected override string _GetTemplateForLabelSpanTitleCreateGroupNeeds2More()
	{
		return "Füge mindestens 2 Leute hinzu, um eine Chatgruppe zu erstellen.";
	}

	protected override string _GetTemplateForLabelSpanTitleLoading()
	{
		return "Wird geladen\u00a0...";
	}

	/// <summary>
	/// Key: "Label.TimestampOffUntilCertainTime"
	/// English String: "Off until {timestamp}"
	/// </summary>
	public override string LabelTimestampOffUntilCertainTime(string timestamp)
	{
		return $"Bis {timestamp} ausschalten";
	}

	protected override string _GetTemplateForLabelTimestampOffUntilCertainTime()
	{
		return "Bis {timestamp} ausschalten";
	}

	protected override string _GetTemplateForLabelTimestampOffUntilTomorrow()
	{
		return "Bis morgen ausschalten";
	}

	protected override string _GetTemplateForLabelTimestampOffUntilTurnedBackOn()
	{
		return "Ausschalten, bis ich sie wieder aktiviere";
	}

	protected override string _GetTemplateForLabelTurnOnConversationNotificationsPrompt()
	{
		return "Möchtest du Benachrichtigungen aktivieren?";
	}

	protected override string _GetTemplateForLabelUnpinGameTooltip()
	{
		return "Spiel nicht mehr anheften";
	}

	protected override string _GetTemplateForLabelViewDetailsButton()
	{
		return "Infos anzeigen";
	}

	protected override string _GetTemplateForLabelViewProfile()
	{
		return "Profil ansehen";
	}

	protected override string _GetTemplateForLabelYesterday()
	{
		return "Gestern";
	}

	/// <summary>
	/// Key: "Message.ChatPrivacySetting"
	/// English String: "To chat with friends, turn on chat in your {frontLink}Privacy Settings{endLink}"
	/// </summary>
	public override string MessageChatPrivacySetting(string frontLink, string endLink)
	{
		return $"Um dich mit deinen Freunden zu unterhalten, aktiviere den Chat in deinen {frontLink}Datenschutzeinstellungen{endLink}.";
	}

	protected override string _GetTemplateForMessageChatPrivacySetting()
	{
		return "Um dich mit deinen Freunden zu unterhalten, aktiviere den Chat in deinen {frontLink}Datenschutzeinstellungen{endLink}.";
	}

	/// <summary>
	/// Key: "Message.conversationTitleChangedText"
	/// English String: "{userName} named the chat group: {groupName}"
	/// </summary>
	public override string MessageconversationTitleChangedText(string userName, string groupName)
	{
		return $"{userName} hat die Chatgruppe benannt: {groupName}";
	}

	protected override string _GetTemplateForMessageconversationTitleChangedText()
	{
		return "{userName} hat die Chatgruppe benannt: {groupName}";
	}

	protected override string _GetTemplateForMessageConversationTitleModerated()
	{
		return "Name der Chatgruppe wurde von einem Moderator angepasst.";
	}

	protected override string _GetTemplateForMessageDefault()
	{
		return "Nicht jeder Chatteilnehmer kann deine Nachricht sehen.";
	}

	protected override string _GetTemplateForMessageDefaultErrorMsg()
	{
		return "Ein Fehler ist aufgetreten.";
	}

	/// <summary>
	/// Key: "Message.DefaultTitleForMsg"
	/// English String: "{userName} says ..."
	/// </summary>
	public override string MessageDefaultTitleForMsg(string userName)
	{
		return $"{userName} sagt\u00a0...";
	}

	protected override string _GetTemplateForMessageDefaultTitleForMsg()
	{
		return "{userName} sagt\u00a0...";
	}

	/// <summary>
	/// Key: "Message.DefaultTitleForPartyInvite"
	/// English String: "Party invite from {userName}"
	/// </summary>
	public override string MessageDefaultTitleForPartyInvite(string userName)
	{
		return $"Teameinladung von {userName}";
	}

	protected override string _GetTemplateForMessageDefaultTitleForPartyInvite()
	{
		return "Teameinladung von {userName}";
	}

	protected override string _GetTemplateForMessageError()
	{
		return "Fehler";
	}

	/// <summary>
	/// Key: "Message.FindGameToPlay"
	/// English String: "{frontLink}Find Games{endLink} to play with your friends!"
	/// </summary>
	public override string MessageFindGameToPlay(string frontLink, string endLink)
	{
		return $"{frontLink}Finde Spiele{endLink}, die du mit Freunden spielen kannst!";
	}

	protected override string _GetTemplateForMessageFindGameToPlay()
	{
		return "{frontLink}Finde Spiele{endLink}, die du mit Freunden spielen kannst!";
	}

	protected override string _GetTemplateForMessageJoinPartyText()
	{
		return "Der Teamleiter sucht nach einem passenden Spiel.";
	}

	protected override string _GetTemplateForMessageMakeFriendsToChatNPlay()
	{
		return "Finde Freunde für Teams und zum Chatten!";
	}

	protected override string _GetTemplateForMessageMessageContentModerated()
	{
		return "Deine Nachricht wurde von einem Moderator angepasst und nicht gesendet.";
	}

	protected override string _GetTemplateForMessageMessageFilterForReceivers()
	{
		return "Nicht jeder Chatteilnehmer kann deine Nachricht sehen.";
	}

	protected override string _GetTemplateForMessageNoConnectionMsg()
	{
		return "Verbindung\u00a0...";
	}

	protected override string _GetTemplateForMessagePartyInviteMsg()
	{
		return "TEAMEINLADUNG!";
	}

	/// <summary>
	/// Key: "Message.PinGameUpdate"
	/// users pinned game in conversation
	/// English String: "{userName} chose a game to play together: {gameName}"
	/// </summary>
	public override string MessagePinGameUpdate(string userName, string gameName)
	{
		return $"{userName} hat ein Spiel zum gemeinsamen Spielen gewählt: {gameName}";
	}

	protected override string _GetTemplateForMessagePinGameUpdate()
	{
		return "{userName} hat ein Spiel zum gemeinsamen Spielen gewählt: {gameName}";
	}

	protected override string _GetTemplateForMessagePlayGameUpdate()
	{
		return " spielt das angeheftete Spiel: ";
	}

	protected override string _GetTemplateForMessageTextTooLong()
	{
		return "Deine Nachricht war zu lang und wurde nicht gesendet.";
	}

	/// <summary>
	/// Key: "Message.ToastText"
	/// English String: "You can have up to {friendNum} friends in chat group."
	/// </summary>
	public override string MessageToastText(string friendNum)
	{
		return $"Du kannst bis zu {friendNum} Freunde in deiner Chatgruppe haben.";
	}

	protected override string _GetTemplateForMessageToastText()
	{
		return "Du kannst bis zu {friendNum} Freunde in deiner Chatgruppe haben.";
	}

	protected override string _GetTemplateForMessageUnknownMessageType()
	{
		return "Eine Nachricht kann nicht angezeigt werden";
	}

	protected override string _GetTemplateForPlayButton()
	{
		return "Spielen";
	}

	protected override string _GetTemplateForResponsePartyInvite()
	{
		return "Du hast eine Teameinladung erhalten.";
	}
}
