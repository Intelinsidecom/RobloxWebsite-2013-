namespace Roblox.TranslationResources.Feature;

/// <summary>
/// This class overrides ChatResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class ChatResources_fr_fr : ChatResources_en_us, IChatResources, ITranslationResources
{
	/// <summary>
	/// Key: "Action.Add"
	/// English String: "Add"
	/// </summary>
	public override string ActionAdd => "Ajouter";

	/// <summary>
	/// Key: "Action.BuyAccess"
	/// English String: "Buy Access"
	/// </summary>
	public override string ActionBuyAccess => "Acheter accès";

	/// <summary>
	/// Key: "Action.Cancel"
	/// English String: "Cancel"
	/// </summary>
	public override string ActionCancel => "Annuler";

	/// <summary>
	/// Key: "Action.Create"
	/// English String: "Create"
	/// </summary>
	public override string ActionCreate => "Créer";

	/// <summary>
	/// Key: "Action.Join"
	/// join the voice chat conversation
	/// English String: "Join"
	/// </summary>
	public override string ActionJoin => "Rejoindre";

	/// <summary>
	/// Key: "Action.Leave"
	/// English String: "Leave"
	/// </summary>
	public override string ActionLeave => "Quitter";

	/// <summary>
	/// Key: "Action.Remove"
	/// English String: "Remove"
	/// </summary>
	public override string ActionRemove => "Retirer";

	/// <summary>
	/// Key: "Action.Report"
	/// English String: "Report"
	/// </summary>
	public override string ActionReport => "Signaler";

	/// <summary>
	/// Key: "Action.Save"
	/// English String: "Save"
	/// </summary>
	public override string ActionSave => "Enregistrer";

	/// <summary>
	/// Key: "Action.Send"
	/// English String: "Send"
	/// </summary>
	public override string ActionSend => "Envoyer";

	/// <summary>
	/// Key: "Action.Set"
	/// English String: "Set"
	/// </summary>
	public override string ActionSet => "Définir";

	/// <summary>
	/// Key: "Action.StartParty"
	/// button label
	/// English String: "Start a Party"
	/// </summary>
	public override string ActionStartParty => "Former un groupe";

	/// <summary>
	/// Key: "Action.Stay"
	/// English String: "Stay"
	/// </summary>
	public override string ActionStay => "Rester";

	/// <summary>
	/// Key: "Action.TurnOn"
	/// English String: "Turn On"
	/// </summary>
	public override string ActionTurnOn => "Activer";

	/// <summary>
	/// Key: "Heading.BuyItem"
	/// English String: "Buy Item"
	/// </summary>
	public override string HeadingBuyItem => "Acheter objet";

	/// <summary>
	/// Key: "Heading.Chat"
	/// English String: "Chat"
	/// </summary>
	public override string HeadingChat => "Chat";

	public override string HeadingChatAndParty => "Chat et groupe";

	/// <summary>
	/// Key: "Heading.ConfirmLeaving"
	/// English String: "Are you sure to leave this chat group?"
	/// </summary>
	public override string HeadingConfirmLeaving => "Veux-tu vraiment quitter ce groupe de chat\u00a0?";

	/// <summary>
	/// Key: "Heading.ContinueToReport"
	/// English String: "Continue to report?"
	/// </summary>
	public override string HeadingContinueToReport => "Poursuivre le signalement\u00a0?";

	/// <summary>
	/// Key: "Heading.CreateParty"
	/// English String: "Create Party"
	/// </summary>
	public override string HeadingCreateParty => "Créer groupe";

	/// <summary>
	/// Key: "Heading.LeaveChatGroup"
	/// English String: "Leave Chat Group"
	/// </summary>
	public override string HeadingLeaveChatGroup => "Quitter le groupe de chat";

	/// <summary>
	/// Key: "Heading.LeaveChatGroupQ"
	/// English String: "Leave Chat Group?"
	/// </summary>
	public override string HeadingLeaveChatGroupQ => "Quitter le groupe de chat\u00a0?";

	/// <summary>
	/// Key: "Heading.NewChatGroup"
	/// English String: "New Chat Group"
	/// </summary>
	public override string HeadingNewChatGroup => "Nouveau groupe de chat";

	/// <summary>
	/// Key: "Heading.RemoveUser"
	/// English String: "Remove User?"
	/// </summary>
	public override string HeadingRemoveUser => "Retirer l'utilisateur\u00a0?";

	/// <summary>
	/// Key: "Heading.Report"
	/// heading for abuse report dialog
	/// English String: "Report"
	/// </summary>
	public override string HeadingReport => "Signaler";

	/// <summary>
	/// Key: "Label.AddFriends"
	/// English String: "Add Friends"
	/// </summary>
	public override string LabelAddFriends => "Ajouter des amis";

	/// <summary>
	/// Key: "Label.BuyButton"
	/// English String: "Buy"
	/// </summary>
	public override string LabelBuyButton => "Acheter";

	/// <summary>
	/// Key: "Label.ChangeChatGroupName"
	/// English String: "Change your chat group name"
	/// </summary>
	public override string LabelChangeChatGroupName => "Change le nom de ton groupe de chat";

	/// <summary>
	/// Key: "Label.ChatDetails"
	/// English String: "Chat Details"
	/// </summary>
	public override string LabelChatDetails => "Détails du chat";

	/// <summary>
	/// Key: "Label.ChatGroupName"
	/// English String: "Chat Group Name"
	/// </summary>
	public override string LabelChatGroupName => "Nom du groupe de chat";

	/// <summary>
	/// Key: "Label.Close"
	/// English String: "Close"
	/// </summary>
	public override string LabelClose => "Fermer";

	/// <summary>
	/// Key: "Label.ConversationNotifications"
	/// conversation notification
	/// English String: "Notifications"
	/// </summary>
	public override string LabelConversationNotifications => "Notifications";

	/// <summary>
	/// Key: "Label.ConversationNotificationsOn"
	/// conversation notification is on
	/// English String: "On"
	/// </summary>
	public override string LabelConversationNotificationsOn => "Activées";

	/// <summary>
	/// Key: "Label.Details.PlayTogether"
	/// English String: "PlayTogether"
	/// </summary>
	public override string LabelDetailsPlayTogether => "Jouer ensemble";

	/// <summary>
	/// Key: "Label.FindGame"
	/// English String: "Find Game"
	/// </summary>
	public override string LabelFindGame => "Trouver une partie";

	/// <summary>
	/// Key: "Label.GameNotAvailableButton"
	/// English String: "Not Available"
	/// </summary>
	public override string LabelGameNotAvailableButton => "Non disponible";

	/// <summary>
	/// Key: "Label.General"
	/// English String: "General"
	/// </summary>
	public override string LabelGeneral => "Général";

	/// <summary>
	/// Key: "Label.InGame"
	/// English String: "In Game"
	/// </summary>
	public override string LabelInGame => "Dans un jeu";

	/// <summary>
	/// Key: "Label.InputPlaceHolder.SearchForFriends"
	/// English String: "Search for friends"
	/// </summary>
	public override string LabelInputPlaceHolderSearchForFriends => "Rechercher des amis";

	/// <summary>
	/// Key: "Label.InputPlaceHolder.SendMessage"
	/// English String: "Send a message"
	/// </summary>
	public override string LabelInputPlaceHolderSendMessage => "Envoyer un message";

	/// <summary>
	/// Key: "Label.InStudio"
	/// English String: "In Studio"
	/// </summary>
	public override string LabelInStudio => "Dans Studio";

	/// <summary>
	/// Key: "Label.JoinButton"
	/// English String: "Join"
	/// </summary>
	public override string LabelJoinButton => "Rejoindre";

	/// <summary>
	/// Key: "Label.JoinGame"
	/// English String: "Join Game"
	/// </summary>
	public override string LabelJoinGame => "Rejoindre la partie";

	/// <summary>
	/// Key: "Label.JoinParty"
	/// English String: "Join Party"
	/// </summary>
	public override string LabelJoinParty => "Rejoindre le groupe";

	/// <summary>
	/// Key: "Label.LeaveChatGroup"
	/// English String: "Leave Chat Group"
	/// </summary>
	public override string LabelLeaveChatGroup => "Quitter le groupe de chat";

	/// <summary>
	/// Key: "Label.LeaveParty"
	/// English String: "Leave Party"
	/// </summary>
	public override string LabelLeaveParty => "Quitter le groupe";

	/// <summary>
	/// Key: "Label.Member"
	/// English String: "Member"
	/// </summary>
	public override string LabelMember => "Membre";

	/// <summary>
	/// Key: "Label.Members"
	/// English String: "Members"
	/// </summary>
	public override string LabelMembers => "Membres";

	/// <summary>
	/// Key: "Label.Mute15Minutes"
	/// mute conversation for 15 mins
	/// English String: "For 15 minutes"
	/// </summary>
	public override string LabelMute15Minutes => "Pendant 15\u00a0minutes";

	/// <summary>
	/// Key: "Label.Mute1Hour"
	/// Mute conversation for 1 hour
	/// English String: "For an hour"
	/// </summary>
	public override string LabelMute1Hour => "Pendant 1\u00a0heure";

	/// <summary>
	/// Key: "Label.Mute24Hours"
	/// Mute conversation for a day
	/// English String: "For a day"
	/// </summary>
	public override string LabelMute24Hours => "Pendant 1\u00a0jour";

	/// <summary>
	/// Key: "Label.Mute8Hours"
	/// Mute conversation for 8 hours
	/// English String: "For 8 hours"
	/// </summary>
	public override string LabelMute8Hours => "Pendant 8\u00a0heures";

	/// <summary>
	/// Key: "Label.MuteConversationNotificationsForGroup"
	/// English String: "Mute notifications for this chat group"
	/// </summary>
	public override string LabelMuteConversationNotificationsForGroup => "Masquer les notifications pour ce groupe de chat";

	/// <summary>
	/// Key: "Label.MuteConversationNotificationsForOneToOne"
	/// English String: "Mute notifications for this conversation"
	/// </summary>
	public override string LabelMuteConversationNotificationsForOneToOne => "Masquer les notifications pour cette conversation";

	/// <summary>
	/// Key: "Label.MuteInfinite"
	/// Mute conversation until user turns back
	/// English String: "Until I turn them back on"
	/// </summary>
	public override string LabelMuteInfinite => "Jusqu'à nouvel ordre";

	/// <summary>
	/// Key: "Label.NameYourChangeGroup"
	/// English String: "Name your change group"
	/// </summary>
	public override string LabelNameYourChangeGroup => "Nomme ton groupe de chat";

	/// <summary>
	/// Key: "Label.NameYourChatGroup"
	/// English String: "Name your chat group"
	/// </summary>
	public override string LabelNameYourChatGroup => "Nomme ton groupe de chat";

	/// <summary>
	/// Key: "Label.NotImplementedMessageType"
	/// This message is displayed in chat when user receives message type that can't be rendered by current app version and update is not available, yet (e.g. latest version was rolled back, or in deprecated Android native chat)
	/// English String: "This message could not be displayed."
	/// </summary>
	public override string LabelNotImplementedMessageType => "Impossible d’afficher un message.";

	/// <summary>
	/// Key: "Label.Offline"
	/// English String: "Offline"
	/// </summary>
	public override string LabelOffline => "Déconnecté";

	/// <summary>
	/// Key: "Label.Online"
	/// English String: "Online"
	/// </summary>
	public override string LabelOnline => "Connecté";

	/// <summary>
	/// Key: "Label.PinGameTooltip"
	/// English String: "Pin Game"
	/// </summary>
	public override string LabelPinGameTooltip => "Épingler le jeu";

	/// <summary>
	/// Key: "Label.PinnedGame"
	/// This is a title of card, means this game card is pinned game
	/// English String: "Pinned Game"
	/// </summary>
	public override string LabelPinnedGame => "Jeu épinglé";

	/// <summary>
	/// Key: "Label.PlayButton"
	/// English String: "Play"
	/// </summary>
	public override string LabelPlayButton => "Jouer";

	/// <summary>
	/// Key: "Label.PlayGames"
	/// English String: "Play Games"
	/// </summary>
	public override string LabelPlayGames => "Jouer";

	/// <summary>
	/// Key: "Label.PlayTogether"
	/// English String: "Play Together"
	/// </summary>
	public override string LabelPlayTogether => "Jouer ensemble";

	/// <summary>
	/// Key: "Label.RecommendedGames"
	/// English String: "Recommended"
	/// </summary>
	public override string LabelRecommendedGames => "Recommandés";

	/// <summary>
	/// Key: "Label.SeeLess"
	/// English String: "See Less"
	/// </summary>
	public override string LabelSeeLess => "Afficher moins";

	/// <summary>
	/// Key: "Label.SeeMore"
	/// English String: "See More"
	/// </summary>
	public override string LabelSeeMore => "Afficher plus";

	/// <summary>
	/// Key: "Label.ShowLessGames"
	/// English String: "Show Less"
	/// </summary>
	public override string LabelShowLessGames => "Afficher moins";

	/// <summary>
	/// Key: "Label.SpanTitle.CreateGroupNeeds2More"
	/// English String: "Add at least 2 people to create chat group"
	/// </summary>
	public override string LabelSpanTitleCreateGroupNeeds2More => "Ajoute au moins deux personnes pour créer un groupe de chat.";

	/// <summary>
	/// Key: "Label.SpanTitle.Loading"
	/// English String: "loading ..."
	/// </summary>
	public override string LabelSpanTitleLoading => "chargement...";

	/// <summary>
	/// Key: "Label.TimestampOffUntilTomorrow"
	/// English String: "Off until tomorrow"
	/// </summary>
	public override string LabelTimestampOffUntilTomorrow => "Désactivées jusqu'à demain";

	/// <summary>
	/// Key: "Label.TimestampOffUntilTurnedBackOn"
	/// English String: "Off until turned back on\""
	/// </summary>
	public override string LabelTimestampOffUntilTurnedBackOn => "Désactivées jusqu'à nouvel ordre";

	/// <summary>
	/// Key: "Label.TurnOnConversationNotificationsPrompt"
	/// English String: "Do you want to turn on notifications?"
	/// </summary>
	public override string LabelTurnOnConversationNotificationsPrompt => "Souhaitez-vous activer les notifications\u00a0?";

	/// <summary>
	/// Key: "Label.UnpinGameTooltip"
	/// English String: "Unpin Game"
	/// </summary>
	public override string LabelUnpinGameTooltip => "Ne plus épingler le jeu";

	/// <summary>
	/// Key: "Label.ViewDetailsButton"
	/// English String: "View Details"
	/// </summary>
	public override string LabelViewDetailsButton => "Voir les détails";

	/// <summary>
	/// Key: "Label.ViewProfile"
	/// English String: "View Profile"
	/// </summary>
	public override string LabelViewProfile => "Voir le profil";

	/// <summary>
	/// Key: "Label.Yesterday"
	/// time stamp for chat message received yesterday
	/// English String: "Yesterday"
	/// </summary>
	public override string LabelYesterday => "Hier";

	/// <summary>
	/// Key: "Message.ConversationTitleModerated"
	/// Chat group name was moderated.
	/// English String: "Chat group name was moderated."
	/// </summary>
	public override string MessageConversationTitleModerated => "Le nom du groupe de chat a été modéré.";

	/// <summary>
	/// Key: "Message.Default"
	/// English String: "Not everyone in this chat can see your message."
	/// </summary>
	public override string MessageDefault => "Certains membres de ce chat ne peuvent pas lire ton message.";

	/// <summary>
	/// Key: "Message.DefaultErrorMsg"
	/// English String: "An error occurred"
	/// </summary>
	public override string MessageDefaultErrorMsg => "Une erreur est survenue.";

	/// <summary>
	/// Key: "Message.Error"
	/// English String: "Error"
	/// </summary>
	public override string MessageError => "Erreur";

	/// <summary>
	/// Key: "Message.JoinPartyText"
	/// English String: "The party leader is finding a game to play."
	/// </summary>
	public override string MessageJoinPartyText => "Le chef de groupe recherche un jeu.";

	/// <summary>
	/// Key: "Message.MakeFriendsToChatNPlay"
	/// English String: "Make friends to start chatting and partying!"
	/// </summary>
	public override string MessageMakeFriendsToChatNPlay => "Fais-toi des amis pour commencer à discuter et t'amuser\u00a0!";

	/// <summary>
	/// Key: "Message.MessageContentModerated"
	/// English String: "Your message was moderated and not sent."
	/// </summary>
	public override string MessageMessageContentModerated => "Ton message a été modéré et n'a pas été envoyé.";

	/// <summary>
	/// Key: "Message.MessageFilterForReceivers"
	/// English String: "Not everyone in this chat can see your message."
	/// </summary>
	public override string MessageMessageFilterForReceivers => "Certains membres de ce chat ne peuvent pas lire ton message.";

	/// <summary>
	/// Key: "Message.NoConnectionMsg"
	/// English String: "Connecting..."
	/// </summary>
	public override string MessageNoConnectionMsg => "Connexion...";

	/// <summary>
	/// Key: "Message.PartyInviteMsg"
	/// English String: "PARTY INVITE!"
	/// </summary>
	public override string MessagePartyInviteMsg => "INVITATION À REJOINDRE UN GROUPE\u00a0!";

	/// <summary>
	/// Key: "Message.PlayGameUpdate"
	/// English String: " is playing the pinned game: "
	/// </summary>
	public override string MessagePlayGameUpdate => " joue au jeu épinglé\u00a0: ";

	/// <summary>
	/// Key: "Message.TextTooLong"
	/// English String: "Your message was too long and not sent."
	/// </summary>
	public override string MessageTextTooLong => "Ton message était trop long et n'a pas été envoyé.";

	/// <summary>
	/// Key: "Message.UnknownMessageType"
	/// This serves as the fallback string for when an message type is received that the web chat does not know how to render.
	/// English String: "A message cannot be displayed"
	/// </summary>
	public override string MessageUnknownMessageType => "Impossible d’afficher un message";

	/// <summary>
	/// Key: "PlayButton"
	/// English String: "Play"
	/// </summary>
	public override string PlayButton => "Jouer";

	/// <summary>
	/// Key: "Response.PartyInvite"
	/// notification message
	/// English String: "You received a party Invite."
	/// </summary>
	public override string ResponsePartyInvite => "Vous avez reçu une invitation à rejoindre un groupe.";

	public ChatResources_fr_fr(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionAdd()
	{
		return "Ajouter";
	}

	protected override string _GetTemplateForActionBuyAccess()
	{
		return "Acheter accès";
	}

	protected override string _GetTemplateForActionCancel()
	{
		return "Annuler";
	}

	protected override string _GetTemplateForActionCreate()
	{
		return "Créer";
	}

	protected override string _GetTemplateForActionJoin()
	{
		return "Rejoindre";
	}

	protected override string _GetTemplateForActionLeave()
	{
		return "Quitter";
	}

	protected override string _GetTemplateForActionRemove()
	{
		return "Retirer";
	}

	protected override string _GetTemplateForActionReport()
	{
		return "Signaler";
	}

	protected override string _GetTemplateForActionSave()
	{
		return "Enregistrer";
	}

	protected override string _GetTemplateForActionSend()
	{
		return "Envoyer";
	}

	protected override string _GetTemplateForActionSet()
	{
		return "Définir";
	}

	protected override string _GetTemplateForActionStartParty()
	{
		return "Former un groupe";
	}

	protected override string _GetTemplateForActionStay()
	{
		return "Rester";
	}

	protected override string _GetTemplateForActionTurnOn()
	{
		return "Activer";
	}

	protected override string _GetTemplateForHeadingBuyItem()
	{
		return "Acheter objet";
	}

	protected override string _GetTemplateForHeadingChat()
	{
		return "Chat";
	}

	protected override string _GetTemplateForHeadingChatAndParty()
	{
		return "Chat et groupe";
	}

	protected override string _GetTemplateForHeadingConfirmLeaving()
	{
		return "Veux-tu vraiment quitter ce groupe de chat\u00a0?";
	}

	protected override string _GetTemplateForHeadingContinueToReport()
	{
		return "Poursuivre le signalement\u00a0?";
	}

	protected override string _GetTemplateForHeadingCreateParty()
	{
		return "Créer groupe";
	}

	protected override string _GetTemplateForHeadingLeaveChatGroup()
	{
		return "Quitter le groupe de chat";
	}

	protected override string _GetTemplateForHeadingLeaveChatGroupQ()
	{
		return "Quitter le groupe de chat\u00a0?";
	}

	protected override string _GetTemplateForHeadingNewChatGroup()
	{
		return "Nouveau groupe de chat";
	}

	protected override string _GetTemplateForHeadingRemoveUser()
	{
		return "Retirer l'utilisateur\u00a0?";
	}

	protected override string _GetTemplateForHeadingReport()
	{
		return "Signaler";
	}

	protected override string _GetTemplateForLabelAddFriends()
	{
		return "Ajouter des amis";
	}

	/// <summary>
	/// Key: "Label.BuyAccessToGameForModal"
	/// English String: "Would you like to buy access to the Place: {placeName} from {creatorName} for {robux}?"
	/// </summary>
	public override string LabelBuyAccessToGameForModal(string placeName, string creatorName, string robux)
	{
		return $"Souhaitez-vous acheter l'accès à l'emplacement\u00a0: {placeName} de {creatorName} pour {robux}\u00a0?";
	}

	protected override string _GetTemplateForLabelBuyAccessToGameForModal()
	{
		return "Souhaitez-vous acheter l'accès à l'emplacement\u00a0: {placeName} de {creatorName} pour {robux}\u00a0?";
	}

	protected override string _GetTemplateForLabelBuyButton()
	{
		return "Acheter";
	}

	protected override string _GetTemplateForLabelChangeChatGroupName()
	{
		return "Change le nom de ton groupe de chat";
	}

	protected override string _GetTemplateForLabelChatDetails()
	{
		return "Détails du chat";
	}

	protected override string _GetTemplateForLabelChatGroupName()
	{
		return "Nom du groupe de chat";
	}

	protected override string _GetTemplateForLabelClose()
	{
		return "Fermer";
	}

	protected override string _GetTemplateForLabelConversationNotifications()
	{
		return "Notifications";
	}

	protected override string _GetTemplateForLabelConversationNotificationsOn()
	{
		return "Activées";
	}

	protected override string _GetTemplateForLabelDetailsPlayTogether()
	{
		return "Jouer ensemble";
	}

	protected override string _GetTemplateForLabelFindGame()
	{
		return "Trouver une partie";
	}

	protected override string _GetTemplateForLabelGameNotAvailableButton()
	{
		return "Non disponible";
	}

	protected override string _GetTemplateForLabelGeneral()
	{
		return "Général";
	}

	protected override string _GetTemplateForLabelInGame()
	{
		return "Dans un jeu";
	}

	protected override string _GetTemplateForLabelInputPlaceHolderSearchForFriends()
	{
		return "Rechercher des amis";
	}

	protected override string _GetTemplateForLabelInputPlaceHolderSendMessage()
	{
		return "Envoyer un message";
	}

	protected override string _GetTemplateForLabelInStudio()
	{
		return "Dans Studio";
	}

	protected override string _GetTemplateForLabelJoinButton()
	{
		return "Rejoindre";
	}

	protected override string _GetTemplateForLabelJoinGame()
	{
		return "Rejoindre la partie";
	}

	protected override string _GetTemplateForLabelJoinParty()
	{
		return "Rejoindre le groupe";
	}

	protected override string _GetTemplateForLabelLeaveChatGroup()
	{
		return "Quitter le groupe de chat";
	}

	protected override string _GetTemplateForLabelLeaveParty()
	{
		return "Quitter le groupe";
	}

	protected override string _GetTemplateForLabelMember()
	{
		return "Membre";
	}

	/// <summary>
	/// Key: "Label.MemberJoinText"
	/// English String: "{userName} joined the party"
	/// </summary>
	public override string LabelMemberJoinText(string userName)
	{
		return $"{userName} a rejoint le groupe";
	}

	protected override string _GetTemplateForLabelMemberJoinText()
	{
		return "{userName} a rejoint le groupe";
	}

	protected override string _GetTemplateForLabelMembers()
	{
		return "Membres";
	}

	protected override string _GetTemplateForLabelMute15Minutes()
	{
		return "Pendant 15\u00a0minutes";
	}

	protected override string _GetTemplateForLabelMute1Hour()
	{
		return "Pendant 1\u00a0heure";
	}

	protected override string _GetTemplateForLabelMute24Hours()
	{
		return "Pendant 1\u00a0jour";
	}

	protected override string _GetTemplateForLabelMute8Hours()
	{
		return "Pendant 8\u00a0heures";
	}

	protected override string _GetTemplateForLabelMuteConversationNotificationsForGroup()
	{
		return "Masquer les notifications pour ce groupe de chat";
	}

	protected override string _GetTemplateForLabelMuteConversationNotificationsForOneToOne()
	{
		return "Masquer les notifications pour cette conversation";
	}

	protected override string _GetTemplateForLabelMuteInfinite()
	{
		return "Jusqu'à nouvel ordre";
	}

	protected override string _GetTemplateForLabelNameYourChangeGroup()
	{
		return "Nomme ton groupe de chat";
	}

	protected override string _GetTemplateForLabelNameYourChatGroup()
	{
		return "Nomme ton groupe de chat";
	}

	protected override string _GetTemplateForLabelNotImplementedMessageType()
	{
		return "Impossible d’afficher un message.";
	}

	protected override string _GetTemplateForLabelOffline()
	{
		return "Déconnecté";
	}

	protected override string _GetTemplateForLabelOnline()
	{
		return "Connecté";
	}

	/// <summary>
	/// Key: "Label.PartyLeaderTooltip"
	/// English String: "{userName} is the party leader"
	/// </summary>
	public override string LabelPartyLeaderTooltip(string userName)
	{
		return $"{userName} est le chef de groupe";
	}

	protected override string _GetTemplateForLabelPartyLeaderTooltip()
	{
		return "{userName} est le chef de groupe";
	}

	/// <summary>
	/// Key: "Label.PartyMemberTooltip"
	/// English String: "{userName} is in the party"
	/// </summary>
	public override string LabelPartyMemberTooltip(string userName)
	{
		return $"{userName} fait partie du groupe";
	}

	protected override string _GetTemplateForLabelPartyMemberTooltip()
	{
		return "{userName} fait partie du groupe";
	}

	/// <summary>
	/// Key: "Label.PartyName"
	/// English String: "Party : {title}"
	/// </summary>
	public override string LabelPartyName(string title)
	{
		return $"Groupe\u00a0: {title}";
	}

	protected override string _GetTemplateForLabelPartyName()
	{
		return "Groupe\u00a0: {title}";
	}

	/// <summary>
	/// Key: "Label.PendingMemberTooltip"
	/// English String: "{userName} is not in the party"
	/// </summary>
	public override string LabelPendingMemberTooltip(string userName)
	{
		return $"{userName} ne fait pas partie du groupe";
	}

	protected override string _GetTemplateForLabelPendingMemberTooltip()
	{
		return "{userName} ne fait pas partie du groupe";
	}

	protected override string _GetTemplateForLabelPinGameTooltip()
	{
		return "Épingler le jeu";
	}

	protected override string _GetTemplateForLabelPinnedGame()
	{
		return "Jeu épinglé";
	}

	protected override string _GetTemplateForLabelPlayButton()
	{
		return "Jouer";
	}

	protected override string _GetTemplateForLabelPlayGames()
	{
		return "Jouer";
	}

	/// <summary>
	/// Key: "Label.PlayingGame"
	/// English String: "Playing {game}"
	/// </summary>
	public override string LabelPlayingGame(string game)
	{
		return $"Joue à {game}";
	}

	protected override string _GetTemplateForLabelPlayingGame()
	{
		return "Joue à {game}";
	}

	protected override string _GetTemplateForLabelPlayTogether()
	{
		return "Jouer ensemble";
	}

	protected override string _GetTemplateForLabelRecommendedGames()
	{
		return "Recommandés";
	}

	protected override string _GetTemplateForLabelSeeLess()
	{
		return "Afficher moins";
	}

	protected override string _GetTemplateForLabelSeeMore()
	{
		return "Afficher plus";
	}

	protected override string _GetTemplateForLabelShowLessGames()
	{
		return "Afficher moins";
	}

	/// <summary>
	/// Key: "Label.ShowMoreGames"
	/// English String: "Show More (+{count})"
	/// </summary>
	public override string LabelShowMoreGames(string count)
	{
		return $"Afficher plus (+{count})";
	}

	protected override string _GetTemplateForLabelShowMoreGames()
	{
		return "Afficher plus (+{count})";
	}

	protected override string _GetTemplateForLabelSpanTitleCreateGroupNeeds2More()
	{
		return "Ajoute au moins deux personnes pour créer un groupe de chat.";
	}

	protected override string _GetTemplateForLabelSpanTitleLoading()
	{
		return "chargement...";
	}

	/// <summary>
	/// Key: "Label.TimestampOffUntilCertainTime"
	/// English String: "Off until {timestamp}"
	/// </summary>
	public override string LabelTimestampOffUntilCertainTime(string timestamp)
	{
		return $"Désactivées jusqu'au {timestamp}";
	}

	protected override string _GetTemplateForLabelTimestampOffUntilCertainTime()
	{
		return "Désactivées jusqu'au {timestamp}";
	}

	protected override string _GetTemplateForLabelTimestampOffUntilTomorrow()
	{
		return "Désactivées jusqu'à demain";
	}

	protected override string _GetTemplateForLabelTimestampOffUntilTurnedBackOn()
	{
		return "Désactivées jusqu'à nouvel ordre";
	}

	protected override string _GetTemplateForLabelTurnOnConversationNotificationsPrompt()
	{
		return "Souhaitez-vous activer les notifications\u00a0?";
	}

	protected override string _GetTemplateForLabelUnpinGameTooltip()
	{
		return "Ne plus épingler le jeu";
	}

	protected override string _GetTemplateForLabelViewDetailsButton()
	{
		return "Voir les détails";
	}

	protected override string _GetTemplateForLabelViewProfile()
	{
		return "Voir le profil";
	}

	protected override string _GetTemplateForLabelYesterday()
	{
		return "Hier";
	}

	/// <summary>
	/// Key: "Message.ChatPrivacySetting"
	/// English String: "To chat with friends, turn on chat in your {frontLink}Privacy Settings{endLink}"
	/// </summary>
	public override string MessageChatPrivacySetting(string frontLink, string endLink)
	{
		return $"Pour discuter avec vos amis, activez le chat dans vos {frontLink}paramètres de confidentialité{endLink}.";
	}

	protected override string _GetTemplateForMessageChatPrivacySetting()
	{
		return "Pour discuter avec vos amis, activez le chat dans vos {frontLink}paramètres de confidentialité{endLink}.";
	}

	/// <summary>
	/// Key: "Message.conversationTitleChangedText"
	/// English String: "{userName} named the chat group: {groupName}"
	/// </summary>
	public override string MessageconversationTitleChangedText(string userName, string groupName)
	{
		return $"{userName} a nommé ton groupe de chat\u00a0: {groupName}";
	}

	protected override string _GetTemplateForMessageconversationTitleChangedText()
	{
		return "{userName} a nommé ton groupe de chat\u00a0: {groupName}";
	}

	protected override string _GetTemplateForMessageConversationTitleModerated()
	{
		return "Le nom du groupe de chat a été modéré.";
	}

	protected override string _GetTemplateForMessageDefault()
	{
		return "Certains membres de ce chat ne peuvent pas lire ton message.";
	}

	protected override string _GetTemplateForMessageDefaultErrorMsg()
	{
		return "Une erreur est survenue.";
	}

	/// <summary>
	/// Key: "Message.DefaultTitleForMsg"
	/// English String: "{userName} says ..."
	/// </summary>
	public override string MessageDefaultTitleForMsg(string userName)
	{
		return $"{userName} dit...";
	}

	protected override string _GetTemplateForMessageDefaultTitleForMsg()
	{
		return "{userName} dit...";
	}

	/// <summary>
	/// Key: "Message.DefaultTitleForPartyInvite"
	/// English String: "Party invite from {userName}"
	/// </summary>
	public override string MessageDefaultTitleForPartyInvite(string userName)
	{
		return $"{userName} vous invite à rejoindre son groupe.";
	}

	protected override string _GetTemplateForMessageDefaultTitleForPartyInvite()
	{
		return "{userName} vous invite à rejoindre son groupe.";
	}

	protected override string _GetTemplateForMessageError()
	{
		return "Erreur";
	}

	/// <summary>
	/// Key: "Message.FindGameToPlay"
	/// English String: "{frontLink}Find Games{endLink} to play with your friends!"
	/// </summary>
	public override string MessageFindGameToPlay(string frontLink, string endLink)
	{
		return $"{frontLink}Trouvez des jeux{endLink} pour jouer avec vos amis\u00a0!";
	}

	protected override string _GetTemplateForMessageFindGameToPlay()
	{
		return "{frontLink}Trouvez des jeux{endLink} pour jouer avec vos amis\u00a0!";
	}

	protected override string _GetTemplateForMessageJoinPartyText()
	{
		return "Le chef de groupe recherche un jeu.";
	}

	protected override string _GetTemplateForMessageMakeFriendsToChatNPlay()
	{
		return "Fais-toi des amis pour commencer à discuter et t'amuser\u00a0!";
	}

	protected override string _GetTemplateForMessageMessageContentModerated()
	{
		return "Ton message a été modéré et n'a pas été envoyé.";
	}

	protected override string _GetTemplateForMessageMessageFilterForReceivers()
	{
		return "Certains membres de ce chat ne peuvent pas lire ton message.";
	}

	protected override string _GetTemplateForMessageNoConnectionMsg()
	{
		return "Connexion...";
	}

	protected override string _GetTemplateForMessagePartyInviteMsg()
	{
		return "INVITATION À REJOINDRE UN GROUPE\u00a0!";
	}

	/// <summary>
	/// Key: "Message.PinGameUpdate"
	/// users pinned game in conversation
	/// English String: "{userName} chose a game to play together: {gameName}"
	/// </summary>
	public override string MessagePinGameUpdate(string userName, string gameName)
	{
		return $"{userName} a choisi un nouveau jeu auquel jouer ensemble\u00a0: {gameName}";
	}

	protected override string _GetTemplateForMessagePinGameUpdate()
	{
		return "{userName} a choisi un nouveau jeu auquel jouer ensemble\u00a0: {gameName}";
	}

	protected override string _GetTemplateForMessagePlayGameUpdate()
	{
		return " joue au jeu épinglé\u00a0: ";
	}

	protected override string _GetTemplateForMessageTextTooLong()
	{
		return "Ton message était trop long et n'a pas été envoyé.";
	}

	/// <summary>
	/// Key: "Message.ToastText"
	/// English String: "You can have up to {friendNum} friends in chat group."
	/// </summary>
	public override string MessageToastText(string friendNum)
	{
		return $"Un groupe de chat peut compter jusqu'à {friendNum}\u00a0amis.";
	}

	protected override string _GetTemplateForMessageToastText()
	{
		return "Un groupe de chat peut compter jusqu'à {friendNum}\u00a0amis.";
	}

	protected override string _GetTemplateForMessageUnknownMessageType()
	{
		return "Impossible d’afficher un message";
	}

	protected override string _GetTemplateForPlayButton()
	{
		return "Jouer";
	}

	protected override string _GetTemplateForResponsePartyInvite()
	{
		return "Vous avez reçu une invitation à rejoindre un groupe.";
	}
}
