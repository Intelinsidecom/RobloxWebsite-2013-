namespace Roblox.Platform.TranslationResources.Notifications {
    /// <summary>

/// This class overrides PushNotificationsResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class PushNotificationsResources_zh_cn : PushNotificationsResources_en_us, IPushNotificationsResources, ITranslationResources
{
	/// <summary>
	/// Key: "Message.AddedToPrivateServerWhiteList.Default"
	/// You have a been invited to a VIP server!
	/// English String: "You have a been invited to a VIP server!"
	/// </summary>
	public override string MessageAddedToPrivateServerWhiteListDefault => "ä½ å·²å—é‚€åŠ å…¥ VIP æœåŠ¡å™¨ï¼";

	/// <summary>
	/// Key: "Message.DefaultSystemMessage.Body"
	/// New activity on Roblox!
	/// English String: "New activity on Roblox!"
	/// </summary>
	public override string MessageDefaultSystemMessageBody => "Roblox æœ‰æ–°æ´»åŠ¨ï¼";

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
	public override string MessageFriendRequestAcceptedDefault => "ä½ çš„å¥½å‹é‚€è¯·å·²è¢«æŽ¥å—ï¼";

	/// <summary>
	/// Key: "Message.FriendRequestReceived.Default"
	/// You have a new friend request!
	/// English String: "You have a new friend request!"
	/// </summary>
	public override string MessageFriendRequestReceivedDefault => "ä½ æœ‰æ–°çš„å¥½å‹é‚€è¯·ï¼";

	/// <summary>
	/// Key: "Message.NewChatMessage.Default"
	/// You have a new chat message.
	/// English String: "You have a new chat message."
	/// </summary>
	public override string MessageNewChatMessageDefault => "ä½ æœ‰æ–°çš„èŠå¤©ä¿¡æ¯ã€‚";

	/// <summary>
	/// Key: "Message.PartyInvitation.Default"
	/// You are invited to a party!
	/// English String: "You are invited to a party!"
	/// </summary>
	public override string MessagePartyInvitationDefault => "ä½ è¢«é‚€è¯·åŠ å…¥æ´¾å¯¹ï¼";

	/// <summary>
	/// Key: "Message.PartyMembersJoined.Default"
	/// A new member joined your party!
	/// English String: "A new member joined your party!"
	/// </summary>
	public override string MessagePartyMembersJoinedDefault => "æœ‰æ–°æˆå‘˜åŠ å…¥ä½ çš„æ´¾å¯¹ï¼";

	/// <summary>
	/// Key: "Message.PrivateMessageReceived.Default"
	/// You have a new private message.
	/// English String: "You have a new private message."
	/// </summary>
	public override string MessagePrivateMessageReceivedDefault => "ä½ æœ‰æ–°çš„ç§äººä¿¡æ¯ã€‚";

	/// <summary>
	/// Key: "Message.TeamCreateInvitation.Default"
	/// A user invites another user to contribute to a team create game.
	/// English String: "You are invited to edit a game!"
	/// </summary>
	public override string MessageTeamCreateInvitationDefault => "ä½ å—é‚€ç¼–è¾‘æ¸¸æˆï¼";

	public PushNotificationsResources_zh_cn(TranslationResourceState state)
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
		return $"â€œ{vipInviter}â€å·²å°†ä½ åŠ å…¥â€œ{place}â€çš„ VIP æœåŠ¡å™¨â€œ{server}â€ï¼";
	}

	protected override string _GetTemplateForMessageAddedToPrivateServerWhiteListAddedToWhiteListMessage()
	{
		return "â€œ{vipInviter}â€å·²å°†ä½ åŠ å…¥â€œ{place}â€çš„ VIP æœåŠ¡å™¨â€œ{server}â€ï¼";
	}

	protected override string _GetTemplateForMessageAddedToPrivateServerWhiteListDefault()
	{
		return "ä½ å·²å—é‚€åŠ å…¥ VIP æœåŠ¡å™¨ï¼";
	}

	protected override string _GetTemplateForMessageDefaultSystemMessageBody()
	{
		return "Roblox æœ‰æ–°æ´»åŠ¨ï¼";
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
		return $"{friend} å·²æŽ¥å—äº†ä½ çš„å¥½å‹é‚€è¯·ï¼";
	}

	protected override string _GetTemplateForMessageFriendRequestAcceptedAcceptedMessage()
	{
		return "{friend} å·²æŽ¥å—äº†ä½ çš„å¥½å‹é‚€è¯·ï¼";
	}

	protected override string _GetTemplateForMessageFriendRequestAcceptedDefault()
	{
		return "ä½ çš„å¥½å‹é‚€è¯·å·²è¢«æŽ¥å—ï¼";
	}

	/// <summary>
	/// Key: "Message.FriendRequestReceived.CompleteMessage"
	/// You have just accepted {friend} as your friend!
	/// English String: "You are now friends with {friend}!"
	/// </summary>
	public override string MessageFriendRequestReceivedCompleteMessage(string friend)
	{
		return $"ä½ çŽ°åœ¨ä¸Ž {friend} æ˜¯å¥½å‹äº†ï¼";
	}

	protected override string _GetTemplateForMessageFriendRequestReceivedCompleteMessage()
	{
		return "ä½ çŽ°åœ¨ä¸Ž {friend} æ˜¯å¥½å‹äº†ï¼";
	}

	protected override string _GetTemplateForMessageFriendRequestReceivedDefault()
	{
		return "ä½ æœ‰æ–°çš„å¥½å‹é‚€è¯·ï¼";
	}

	/// <summary>
	/// Key: "Message.FriendRequestReceived.NewRequestMessage"
	/// {friend} sent you a friend request!
	/// English String: "{friend} sent you a friend request!"
	/// </summary>
	public override string MessageFriendRequestReceivedNewRequestMessage(string friend)
	{
		return $"{friend} å‘ä½ å‘å‡ºäº†å¥½å‹é‚€è¯·ï¼";
	}

	protected override string _GetTemplateForMessageFriendRequestReceivedNewRequestMessage()
	{
		return "{friend} å‘ä½ å‘å‡ºäº†å¥½å‹é‚€è¯·ï¼";
	}

	protected override string _GetTemplateForMessageNewChatMessageDefault()
	{
		return "ä½ æœ‰æ–°çš„èŠå¤©ä¿¡æ¯ã€‚";
	}

	/// <summary>
	/// Key: "Message.NewChatMessage.ReceivedGroupMessage"
	/// notification for a chat message sent in a Group Chat. Conversation title is Group Title.
	/// English String: "{senderUserName} to {conversationTitle}: {messageContent}"
	/// </summary>
	public override string MessageNewChatMessageReceivedGroupMessage(string senderUserName, string conversationTitle, string messageContent)
	{
		return $"{senderUserName} åœ¨â€œ{conversationTitle}â€ä¸­å‘è¨€ï¼š{messageContent}";
	}

	protected override string _GetTemplateForMessageNewChatMessageReceivedGroupMessage()
	{
		return "{senderUserName} åœ¨â€œ{conversationTitle}â€ä¸­å‘è¨€ï¼š{messageContent}";
	}

	/// <summary>
	/// Key: "Message.NewChatMessage.ReceivedMessage"
	/// {friend}: {message}
	/// English String: "{friend}: {message}"
	/// </summary>
	public override string MessageNewChatMessageReceivedMessage(string friend, string message)
	{
		return $"{friend}ï¼š{message}";
	}

	protected override string _GetTemplateForMessageNewChatMessageReceivedMessage()
	{
		return "{friend}ï¼š{message}";
	}

	protected override string _GetTemplateForMessagePartyInvitationDefault()
	{
		return "ä½ è¢«é‚€è¯·åŠ å…¥æ´¾å¯¹ï¼";
	}

	/// <summary>
	/// Key: "Message.PartyInvitation.PartyMessage"
	/// {partyInviter} invited you to a party!
	/// English String: "{partyInviter} invited you to a party!"
	/// </summary>
	public override string MessagePartyInvitationPartyMessage(string partyInviter)
	{
		return $"{partyInviter} é‚€è¯·ä½ åŠ å…¥æ´¾å¯¹ï¼";
	}

	protected override string _GetTemplateForMessagePartyInvitationPartyMessage()
	{
		return "{partyInviter} é‚€è¯·ä½ åŠ å…¥æ´¾å¯¹ï¼";
	}

	/// <summary>
	/// Key: "Message.PartyInvitation.XBoxPartyMessage"
	/// {partyInviter} invited you to an XBOX party!
	/// English String: "{partyInviter} invited you to an XBOX party!"
	/// </summary>
	public override string MessagePartyInvitationXBoxPartyMessage(string partyInviter)
	{
		return $"{partyInviter} é‚€è¯·ä½ åŠ å…¥ XBOX æ´¾å¯¹ï¼";
	}

	protected override string _GetTemplateForMessagePartyInvitationXBoxPartyMessage()
	{
		return "{partyInviter} é‚€è¯·ä½ åŠ å…¥ XBOX æ´¾å¯¹ï¼";
	}

	protected override string _GetTemplateForMessagePartyMembersJoinedDefault()
	{
		return "æœ‰æ–°æˆå‘˜åŠ å…¥ä½ çš„æ´¾å¯¹ï¼";
	}

	/// <summary>
	/// Key: "Message.PartyMembersJoined.JoinMessage"
	/// {partyInvitee} joined your party!
	/// English String: "{partyInvitee} joined your party!"
	/// </summary>
	public override string MessagePartyMembersJoinedJoinMessage(string partyInvitee)
	{
		return $"{partyInvitee} å·²åŠ å…¥ä½ çš„æ´¾å¯¹ï¼";
	}

	protected override string _GetTemplateForMessagePartyMembersJoinedJoinMessage()
	{
		return "{partyInvitee} å·²åŠ å…¥ä½ çš„æ´¾å¯¹ï¼";
	}

	protected override string _GetTemplateForMessagePrivateMessageReceivedDefault()
	{
		return "ä½ æœ‰æ–°çš„ç§äººä¿¡æ¯ã€‚";
	}

	/// <summary>
	/// Key: "Message.PrivateMessageReceived.MessageReceived"
	/// {messageSender} sent you a new private message.
	/// English String: "{messageSender} sent you a new private message."
	/// </summary>
	public override string MessagePrivateMessageReceivedMessageReceived(string messageSender)
	{
		return $"{messageSender} å‘ä½ å‘é€æ–°çš„ç§äººä¿¡æ¯ã€‚";
	}

	protected override string _GetTemplateForMessagePrivateMessageReceivedMessageReceived()
	{
		return "{messageSender} å‘ä½ å‘é€æ–°çš„ç§äººä¿¡æ¯ã€‚";
	}

	/// <summary>
	/// Key: "Message.TeamCreateInvitation"
	/// English String: "{inviter} invited you to edit the game: {gameName}!"
	/// </summary>
	public override string MessageTeamCreateInvitation(string inviter, string gameName)
	{
		return $"{inviter} é‚€è¯·ä½ ç¼–è¾‘æ¸¸æˆï¼š{gameName}ï¼";
	}

	protected override string _GetTemplateForMessageTeamCreateInvitation()
	{
		return "{inviter} é‚€è¯·ä½ ç¼–è¾‘æ¸¸æˆï¼š{gameName}ï¼";
	}

	protected override string _GetTemplateForMessageTeamCreateInvitationDefault()
	{
		return "ä½ å—é‚€ç¼–è¾‘æ¸¸æˆï¼";
	}

	/// <summary>
	/// Key: "Messages.PlayTogether"
	/// English String: "{actorUsername} chose a game to play together: {universeName}"
	/// </summary>
	public override string MessagesPlayTogether(string actorUsername, string universeName)
	{
		return $"â€œ{actorUsername}â€å·²é€‰æ‹©ä¸€ä¸ªå¯ä¸€èµ·çŽ©çš„æ¸¸æˆï¼šâ€œ{universeName}â€";
	}

	protected override string _GetTemplateForMessagesPlayTogether()
	{
		return "â€œ{actorUsername}â€å·²é€‰æ‹©ä¸€ä¸ªå¯ä¸€èµ·çŽ©çš„æ¸¸æˆï¼šâ€œ{universeName}â€";
	}
}


}
