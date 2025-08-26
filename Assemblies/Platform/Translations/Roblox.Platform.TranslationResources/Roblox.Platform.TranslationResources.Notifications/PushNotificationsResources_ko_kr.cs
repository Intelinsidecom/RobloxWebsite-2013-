namespace Roblox.Platform.TranslationResources.Notifications {
    /// <summary>

/// This class overrides PushNotificationsResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class PushNotificationsResources_ko_kr : PushNotificationsResources_en_us, IPushNotificationsResources, ITranslationResources
{
	/// <summary>
	/// Key: "Message.AddedToPrivateServerWhiteList.Default"
	/// You have a been invited to a VIP server!
	/// English String: "You have a been invited to a VIP server!"
	/// </summary>
	public override string MessageAddedToPrivateServerWhiteListDefault => "VIP ì„œë²„ì— ì´ˆëŒ€ë°›ì•˜ì–´ìš”.";

	/// <summary>
	/// Key: "Message.DefaultSystemMessage.Body"
	/// New activity on Roblox!
	/// English String: "New activity on Roblox!"
	/// </summary>
	public override string MessageDefaultSystemMessageBody => "Robloxì— ìƒˆë¡œìš´ ì•¡í‹°ë¹„í‹°ê°€ ìžˆì–´ìš”!";

	/// <summary>
	/// Key: "Message.DefaultSystemMessage.Title"
	/// Roblox
	/// English String: "Roblox"
	/// </summary>
	public override string MessageDefaultSystemMessageTitle => "Roblox";

	/// <summary>
	/// Key: "Message.FriendRequestAccepted.Default"
	/// Your friend request has been accepted!
	/// English String: "Your friend request has been accepted!"
	/// </summary>
	public override string MessageFriendRequestAcceptedDefault => "ì¹œêµ¬ ìš”ì²­ì´ ìˆ˜ë½ë˜ì—ˆì–´ìš”.";

	/// <summary>
	/// Key: "Message.FriendRequestReceived.Default"
	/// You have a new friend request!
	/// English String: "You have a new friend request!"
	/// </summary>
	public override string MessageFriendRequestReceivedDefault => "ìƒˆë¡œìš´ ì¹œêµ¬ ìš”ì²­ì´ ìžˆì–´ìš”.";

	/// <summary>
	/// Key: "Message.NewChatMessage.Default"
	/// You have a new chat message.
	/// English String: "You have a new chat message."
	/// </summary>
	public override string MessageNewChatMessageDefault => "ìƒˆë¡œìš´ ì±„íŒ… ë©”ì‹œì§€ê°€ ìžˆì–´ìš”.";

	/// <summary>
	/// Key: "Message.PartyInvitation.Default"
	/// You are invited to a party!
	/// English String: "You are invited to a party!"
	/// </summary>
	public override string MessagePartyInvitationDefault => "íŒŒí‹° ì´ˆëŒ€ë¥¼ ë°›ì•˜ì–´ìš”!";

	/// <summary>
	/// Key: "Message.PartyMembersJoined.Default"
	/// A new member joined your party!
	/// English String: "A new member joined your party!"
	/// </summary>
	public override string MessagePartyMembersJoinedDefault => "ìƒˆë¡œìš´ ë©¤ë²„ê°€ íšŒì›ë‹˜ì´ íŒŒí‹°ì— ì°¸ê°€í–ˆì–´ìš”.";

	/// <summary>
	/// Key: "Message.PrivateMessageReceived.Default"
	/// You have a new private message.
	/// English String: "You have a new private message."
	/// </summary>
	public override string MessagePrivateMessageReceivedDefault => "ìƒˆ ë¹„ê³µê°œ ë©”ì‹œì§€ê°€ ìžˆì–´ìš”.";

	/// <summary>
	/// Key: "Message.TeamCreateInvitation.Default"
	/// A user invites another user to contribute to a team create game.
	/// English String: "You are invited to edit a game!"
	/// </summary>
	public override string MessageTeamCreateInvitationDefault => "ê²Œìž„ íŽ¸ì§‘ì— ì´ˆëŒ€ë°›ì•˜ì–´ìš”.";

	public PushNotificationsResources_ko_kr(TranslationResourceState state)
		: base(state)
	{
	}

	/// <summary>
	/// Key: "Message.AddedToPrivateServerWhiteList.AddedToWhiteListMessage"
	/// {vipInviter} added you to their VIP server, {server}, at {place}!
	/// English String: "{vipInviter} added you to their VIP server, {server}, at {place}!"
	/// </summary>
	public override string MessageAddedToPrivateServerWhiteListAddedToWhiteListMessage(string vipInviter, string server, string place)
	{
		return $"{vipInviter}ë‹˜ì´ íšŒì›ë‹˜ì„ VIP ì„œë²„({server}, ìž¥ì†Œ: {place})ì— ì¶”ê°€í–ˆì–´ìš”!";
	}

	protected override string _GetTemplateForMessageAddedToPrivateServerWhiteListAddedToWhiteListMessage()
	{
		return "{vipInviter}ë‹˜ì´ íšŒì›ë‹˜ì„ VIP ì„œë²„({server}, ìž¥ì†Œ: {place})ì— ì¶”ê°€í–ˆì–´ìš”!";
	}

	protected override string _GetTemplateForMessageAddedToPrivateServerWhiteListDefault()
	{
		return "VIP ì„œë²„ì— ì´ˆëŒ€ë°›ì•˜ì–´ìš”.";
	}

	protected override string _GetTemplateForMessageDefaultSystemMessageBody()
	{
		return "Robloxì— ìƒˆë¡œìš´ ì•¡í‹°ë¹„í‹°ê°€ ìžˆì–´ìš”!";
	}

	protected override string _GetTemplateForMessageDefaultSystemMessageTitle()
	{
		return "Roblox";
	}

	/// <summary>
	/// Key: "Message.FriendRequestAccepted.AcceptedMessage"
	/// {friend} accepted your friend request!
	/// English String: "{friend} accepted your friend request!"
	/// </summary>
	public override string MessageFriendRequestAcceptedAcceptedMessage(string friend)
	{
		return $"{friend}ë‹˜ì´ ì¹œêµ¬ ìš”ì²­ì„ ìˆ˜ë½í–ˆì–´ìš”.";
	}

	protected override string _GetTemplateForMessageFriendRequestAcceptedAcceptedMessage()
	{
		return "{friend}ë‹˜ì´ ì¹œêµ¬ ìš”ì²­ì„ ìˆ˜ë½í–ˆì–´ìš”.";
	}

	protected override string _GetTemplateForMessageFriendRequestAcceptedDefault()
	{
		return "ì¹œêµ¬ ìš”ì²­ì´ ìˆ˜ë½ë˜ì—ˆì–´ìš”.";
	}

	/// <summary>
	/// Key: "Message.FriendRequestReceived.CompleteMessage"
	/// You have just accepted {friend} as your friend!
	/// English String: "You are now friends with {friend}!"
	/// </summary>
	public override string MessageFriendRequestReceivedCompleteMessage(string friend)
	{
		return $"ì´ì œ {friend}ë‹˜ê³¼ ì¹œêµ¬ì˜ˆìš”!";
	}

	protected override string _GetTemplateForMessageFriendRequestReceivedCompleteMessage()
	{
		return "ì´ì œ {friend}ë‹˜ê³¼ ì¹œêµ¬ì˜ˆìš”!";
	}

	protected override string _GetTemplateForMessageFriendRequestReceivedDefault()
	{
		return "ìƒˆë¡œìš´ ì¹œêµ¬ ìš”ì²­ì´ ìžˆì–´ìš”.";
	}

	/// <summary>
	/// Key: "Message.FriendRequestReceived.NewRequestMessage"
	/// {friend} sent you a friend request!
	/// English String: "{friend} sent you a friend request!"
	/// </summary>
	public override string MessageFriendRequestReceivedNewRequestMessage(string friend)
	{
		return $"{friend}ë‹˜ì—ê²Œ ì¹œêµ¬ ìš”ì²­ì„ ë°›ì•˜ì–´ìš”.";
	}

	protected override string _GetTemplateForMessageFriendRequestReceivedNewRequestMessage()
	{
		return "{friend}ë‹˜ì—ê²Œ ì¹œêµ¬ ìš”ì²­ì„ ë°›ì•˜ì–´ìš”.";
	}

	protected override string _GetTemplateForMessageNewChatMessageDefault()
	{
		return "ìƒˆë¡œìš´ ì±„íŒ… ë©”ì‹œì§€ê°€ ìžˆì–´ìš”.";
	}

	/// <summary>
	/// Key: "Message.NewChatMessage.ReceivedGroupMessage"
	/// notification for a chat message sent in a Group Chat. Conversation title is Group Title.
	/// English String: "{senderUserName} to {conversationTitle}: {messageContent}"
	/// </summary>
	public override string MessageNewChatMessageReceivedGroupMessage(string senderUserName, string conversationTitle, string messageContent)
	{
		return $"{senderUserName} > {conversationTitle}: {messageContent}";
	}

	protected override string _GetTemplateForMessageNewChatMessageReceivedGroupMessage()
	{
		return "{senderUserName} > {conversationTitle}: {messageContent}";
	}

	/// <summary>
	/// Key: "Message.NewChatMessage.ReceivedMessage"
	/// {friend}: {message}
	/// English String: "{friend}: {message}"
	/// </summary>
	public override string MessageNewChatMessageReceivedMessage(string friend, string message)
	{
		return $"{friend}: {message}";
	}

	protected override string _GetTemplateForMessageNewChatMessageReceivedMessage()
	{
		return "{friend}: {message}";
	}

	protected override string _GetTemplateForMessagePartyInvitationDefault()
	{
		return "íŒŒí‹° ì´ˆëŒ€ë¥¼ ë°›ì•˜ì–´ìš”!";
	}

	/// <summary>
	/// Key: "Message.PartyInvitation.PartyMessage"
	/// {partyInviter} invited you to a party!
	/// English String: "{partyInviter} invited you to a party!"
	/// </summary>
	public override string MessagePartyInvitationPartyMessage(string partyInviter)
	{
		return $"{partyInviter}ë‹˜ì´ íšŒì›ë‹˜ì„ íŒŒí‹°ì— ì´ˆëŒ€í–ˆì–´ìš”.";
	}

	protected override string _GetTemplateForMessagePartyInvitationPartyMessage()
	{
		return "{partyInviter}ë‹˜ì´ íšŒì›ë‹˜ì„ íŒŒí‹°ì— ì´ˆëŒ€í–ˆì–´ìš”.";
	}

	/// <summary>
	/// Key: "Message.PartyInvitation.XBoxPartyMessage"
	/// {partyInviter} invited you to an XBOX party!
	/// English String: "{partyInviter} invited you to an XBOX party!"
	/// </summary>
	public override string MessagePartyInvitationXBoxPartyMessage(string partyInviter)
	{
		return $"{partyInviter}ë‹˜ì´ XBOX íŒŒí‹°ì— íšŒì›ë‹˜ì„ ì´ˆëŒ€í–ˆì–´ìš”!";
	}

	protected override string _GetTemplateForMessagePartyInvitationXBoxPartyMessage()
	{
		return "{partyInviter}ë‹˜ì´ XBOX íŒŒí‹°ì— íšŒì›ë‹˜ì„ ì´ˆëŒ€í–ˆì–´ìš”!";
	}

	protected override string _GetTemplateForMessagePartyMembersJoinedDefault()
	{
		return "ìƒˆë¡œìš´ ë©¤ë²„ê°€ íšŒì›ë‹˜ì´ íŒŒí‹°ì— ì°¸ê°€í–ˆì–´ìš”.";
	}

	/// <summary>
	/// Key: "Message.PartyMembersJoined.JoinMessage"
	/// {partyInvitee} joined your party!
	/// English String: "{partyInvitee} joined your party!"
	/// </summary>
	public override string MessagePartyMembersJoinedJoinMessage(string partyInvitee)
	{
		return $"{partyInvitee}ë‹˜ì´ íšŒì›ë‹˜ì˜ íŒŒí‹°ì— ì°¸ê°€í–ˆì–´ìš”.";
	}

	protected override string _GetTemplateForMessagePartyMembersJoinedJoinMessage()
	{
		return "{partyInvitee}ë‹˜ì´ íšŒì›ë‹˜ì˜ íŒŒí‹°ì— ì°¸ê°€í–ˆì–´ìš”.";
	}

	protected override string _GetTemplateForMessagePrivateMessageReceivedDefault()
	{
		return "ìƒˆ ë¹„ê³µê°œ ë©”ì‹œì§€ê°€ ìžˆì–´ìš”.";
	}

	/// <summary>
	/// Key: "Message.PrivateMessageReceived.MessageReceived"
	/// {messageSender} sent you a new private message.
	/// English String: "{messageSender} sent you a new private message."
	/// </summary>
	public override string MessagePrivateMessageReceivedMessageReceived(string messageSender)
	{
		return $"{messageSender}ë‹˜ì´ ìƒˆ ë¹„ê³µê°œ ë©”ì‹œì§€ë¥¼ ë³´ëƒˆì–´ìš”.";
	}

	protected override string _GetTemplateForMessagePrivateMessageReceivedMessageReceived()
	{
		return "{messageSender}ë‹˜ì´ ìƒˆ ë¹„ê³µê°œ ë©”ì‹œì§€ë¥¼ ë³´ëƒˆì–´ìš”.";
	}

	/// <summary>
	/// Key: "Message.TeamCreateInvitation"
	/// English String: "{inviter} invited you to edit the game: {gameName}!"
	/// </summary>
	public override string MessageTeamCreateInvitation(string inviter, string gameName)
	{
		return $"{inviter}ë‹˜ì´ {gameName} íŽ¸ì§‘ì— ì´ˆëŒ€í–ˆì–´ìš”.";
	}

	protected override string _GetTemplateForMessageTeamCreateInvitation()
	{
		return "{inviter}ë‹˜ì´ {gameName} íŽ¸ì§‘ì— ì´ˆëŒ€í–ˆì–´ìš”.";
	}

	protected override string _GetTemplateForMessageTeamCreateInvitationDefault()
	{
		return "ê²Œìž„ íŽ¸ì§‘ì— ì´ˆëŒ€ë°›ì•˜ì–´ìš”.";
	}

	/// <summary>
	/// Key: "Messages.PlayTogether"
	/// English String: "{actorUsername} chose a game to play together: {universeName}"
	/// </summary>
	public override string MessagesPlayTogether(string actorUsername, string universeName)
	{
		return $"{actorUsername}ë‹˜ì´ ì„ íƒí•œ ê²Œìž„: {universeName}";
	}

	protected override string _GetTemplateForMessagesPlayTogether()
	{
		return "{actorUsername}ë‹˜ì´ ì„ íƒí•œ ê²Œìž„: {universeName}";
	}
}


}
