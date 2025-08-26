namespace Roblox.Platform.TranslationResources.Notifications {
    /// <summary>

/// This class overrides PushNotificationsResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class PushNotificationsResources_ja_jp : PushNotificationsResources_en_us, IPushNotificationsResources, ITranslationResources
{
	/// <summary>
	/// Key: "Message.AddedToPrivateServerWhiteList.Default"
	/// You have a been invited to a VIP server!
	/// English String: "You have a been invited to a VIP server!"
	/// </summary>
	public override string MessageAddedToPrivateServerWhiteListDefault => "VIPã‚µãƒ¼ãƒãƒ¼ã«æ‹›å¾…ã•ã‚Œã¾ã—ãŸï¼";

	/// <summary>
	/// Key: "Message.DefaultSystemMessage.Body"
	/// New activity on Roblox!
	/// English String: "New activity on Roblox!"
	/// </summary>
	public override string MessageDefaultSystemMessageBody => "Robloxã®æ–°ã—ã„ã‚¢ã‚¯ãƒ†ã‚£ãƒ“ãƒ†ã‚£ã§ã™ï¼";

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
	public override string MessageFriendRequestAcceptedDefault => "å‹é”ãƒªã‚¯ã‚¨ã‚¹ãƒˆãŒæ‰¿èªã•ã‚Œã¾ã—ãŸï¼";

	/// <summary>
	/// Key: "Message.FriendRequestReceived.Default"
	/// You have a new friend request!
	/// English String: "You have a new friend request!"
	/// </summary>
	public override string MessageFriendRequestReceivedDefault => "æ–°ã—ã„å‹é”ãƒªã‚¯ã‚¨ã‚¹ãƒˆãŒå±Šãã¾ã—ãŸï¼";

	/// <summary>
	/// Key: "Message.NewChatMessage.Default"
	/// You have a new chat message.
	/// English String: "You have a new chat message."
	/// </summary>
	public override string MessageNewChatMessageDefault => "æ–°ã—ã„ãƒãƒ£ãƒƒãƒˆãƒ¡ãƒƒã‚»ãƒ¼ã‚¸ãŒã‚ã‚Šã¾ã™ã€‚";

	/// <summary>
	/// Key: "Message.PartyInvitation.Default"
	/// You are invited to a party!
	/// English String: "You are invited to a party!"
	/// </summary>
	public override string MessagePartyInvitationDefault => "ãƒ‘ãƒ¼ãƒ†ã‚£ã«æ‹›å¾…ã•ã‚Œã¾ã—ãŸï¼";

	/// <summary>
	/// Key: "Message.PartyMembersJoined.Default"
	/// A new member joined your party!
	/// English String: "A new member joined your party!"
	/// </summary>
	public override string MessagePartyMembersJoinedDefault => "æ–°ã—ã„ãƒ¡ãƒ³ãƒãƒ¼ãŒãƒ‘ãƒ¼ãƒ†ã‚£ã«å‚åŠ ã—ã¾ã—ãŸï¼";

	/// <summary>
	/// Key: "Message.PrivateMessageReceived.Default"
	/// You have a new private message.
	/// English String: "You have a new private message."
	/// </summary>
	public override string MessagePrivateMessageReceivedDefault => "1ä»¶ã®ãƒ—ãƒ©ã‚¤ãƒ™ãƒ¼ãƒˆãƒ¡ãƒƒã‚»ãƒ¼ã‚¸ãŒã‚ã‚Šã¾ã™ã€‚";

	/// <summary>
	/// Key: "Message.TeamCreateInvitation.Default"
	/// A user invites another user to contribute to a team create game.
	/// English String: "You are invited to edit a game!"
	/// </summary>
	public override string MessageTeamCreateInvitationDefault => "ã‚²ãƒ¼ãƒ ã®ç·¨é›†ã«æ‹›å¾…ã•ã‚Œã¾ã—ãŸï¼";

	public PushNotificationsResources_ja_jp(TranslationResourceState state)
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
		return $"{vipInviter}ã•ã‚“ãŒã€{place}ã«ã‚ã‚‹VIPã‚µãƒ¼ãƒãƒ¼{server}ã«ã‚ãªãŸã‚’è¿½åŠ ã—ã¾ã—ãŸï¼";
	}

	protected override string _GetTemplateForMessageAddedToPrivateServerWhiteListAddedToWhiteListMessage()
	{
		return "{vipInviter}ã•ã‚“ãŒã€{place}ã«ã‚ã‚‹VIPã‚µãƒ¼ãƒãƒ¼{server}ã«ã‚ãªãŸã‚’è¿½åŠ ã—ã¾ã—ãŸï¼";
	}

	protected override string _GetTemplateForMessageAddedToPrivateServerWhiteListDefault()
	{
		return "VIPã‚µãƒ¼ãƒãƒ¼ã«æ‹›å¾…ã•ã‚Œã¾ã—ãŸï¼";
	}

	protected override string _GetTemplateForMessageDefaultSystemMessageBody()
	{
		return "Robloxã®æ–°ã—ã„ã‚¢ã‚¯ãƒ†ã‚£ãƒ“ãƒ†ã‚£ã§ã™ï¼";
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
		return $"{friend}ã•ã‚“ãŒã€ã‚ãªãŸã®å‹é”ãƒªã‚¯ã‚¨ã‚¹ãƒˆã‚’æ‰¿èªã—ã¾ã—ãŸï¼";
	}

	protected override string _GetTemplateForMessageFriendRequestAcceptedAcceptedMessage()
	{
		return "{friend}ã•ã‚“ãŒã€ã‚ãªãŸã®å‹é”ãƒªã‚¯ã‚¨ã‚¹ãƒˆã‚’æ‰¿èªã—ã¾ã—ãŸï¼";
	}

	protected override string _GetTemplateForMessageFriendRequestAcceptedDefault()
	{
		return "å‹é”ãƒªã‚¯ã‚¨ã‚¹ãƒˆãŒæ‰¿èªã•ã‚Œã¾ã—ãŸï¼";
	}

	/// <summary>
	/// Key: "Message.FriendRequestReceived.CompleteMessage"
	/// You have just accepted {friend} as your friend!
	/// English String: "You are now friends with {friend}!"
	/// </summary>
	public override string MessageFriendRequestReceivedCompleteMessage(string friend)
	{
		return $"{friend}ã•ã‚“ãŒå‹é”ã«ãªã‚Šã¾ã—ãŸã€‚";
	}

	protected override string _GetTemplateForMessageFriendRequestReceivedCompleteMessage()
	{
		return "{friend}ã•ã‚“ãŒå‹é”ã«ãªã‚Šã¾ã—ãŸã€‚";
	}

	protected override string _GetTemplateForMessageFriendRequestReceivedDefault()
	{
		return "æ–°ã—ã„å‹é”ãƒªã‚¯ã‚¨ã‚¹ãƒˆãŒå±Šãã¾ã—ãŸï¼";
	}

	/// <summary>
	/// Key: "Message.FriendRequestReceived.NewRequestMessage"
	/// {friend} sent you a friend request!
	/// English String: "{friend} sent you a friend request!"
	/// </summary>
	public override string MessageFriendRequestReceivedNewRequestMessage(string friend)
	{
		return $"{friend} ã•ã‚“ã‹ã‚‰å‹é”ãƒªã‚¯ã‚¨ã‚¹ãƒˆãŒå±Šãã¾ã—ãŸï¼";
	}

	protected override string _GetTemplateForMessageFriendRequestReceivedNewRequestMessage()
	{
		return "{friend} ã•ã‚“ã‹ã‚‰å‹é”ãƒªã‚¯ã‚¨ã‚¹ãƒˆãŒå±Šãã¾ã—ãŸï¼";
	}

	protected override string _GetTemplateForMessageNewChatMessageDefault()
	{
		return "æ–°ã—ã„ãƒãƒ£ãƒƒãƒˆãƒ¡ãƒƒã‚»ãƒ¼ã‚¸ãŒã‚ã‚Šã¾ã™ã€‚";
	}

	/// <summary>
	/// Key: "Message.NewChatMessage.ReceivedGroupMessage"
	/// notification for a chat message sent in a Group Chat. Conversation title is Group Title.
	/// English String: "{senderUserName} to {conversationTitle}: {messageContent}"
	/// </summary>
	public override string MessageNewChatMessageReceivedGroupMessage(string senderUserName, string conversationTitle, string messageContent)
	{
		return $"{senderUserName}ã•ã‚“ã‹ã‚‰ã®{conversationTitle}: {messageContent}";
	}

	protected override string _GetTemplateForMessageNewChatMessageReceivedGroupMessage()
	{
		return "{senderUserName}ã•ã‚“ã‹ã‚‰ã®{conversationTitle}: {messageContent}";
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
		return "ãƒ‘ãƒ¼ãƒ†ã‚£ã«æ‹›å¾…ã•ã‚Œã¾ã—ãŸï¼";
	}

	/// <summary>
	/// Key: "Message.PartyInvitation.PartyMessage"
	/// {partyInviter} invited you to a party!
	/// English String: "{partyInviter} invited you to a party!"
	/// </summary>
	public override string MessagePartyInvitationPartyMessage(string partyInviter)
	{
		return $"{partyInviter}ã•ã‚“ã‹ã‚‰ãƒ‘ãƒ¼ãƒ†ã‚£ã«æ‹›å¾…ã•ã‚Œã¾ã—ãŸï¼";
	}

	protected override string _GetTemplateForMessagePartyInvitationPartyMessage()
	{
		return "{partyInviter}ã•ã‚“ã‹ã‚‰ãƒ‘ãƒ¼ãƒ†ã‚£ã«æ‹›å¾…ã•ã‚Œã¾ã—ãŸï¼";
	}

	/// <summary>
	/// Key: "Message.PartyInvitation.XBoxPartyMessage"
	/// {partyInviter} invited you to an XBOX party!
	/// English String: "{partyInviter} invited you to an XBOX party!"
	/// </summary>
	public override string MessagePartyInvitationXBoxPartyMessage(string partyInviter)
	{
		return $"{partyInviter}ã•ã‚“ã‹ã‚‰XBOXãƒ‘ãƒ¼ãƒ†ã‚£ã«æ‹›å¾…ã•ã‚Œã¾ã—ãŸï¼";
	}

	protected override string _GetTemplateForMessagePartyInvitationXBoxPartyMessage()
	{
		return "{partyInviter}ã•ã‚“ã‹ã‚‰XBOXãƒ‘ãƒ¼ãƒ†ã‚£ã«æ‹›å¾…ã•ã‚Œã¾ã—ãŸï¼";
	}

	protected override string _GetTemplateForMessagePartyMembersJoinedDefault()
	{
		return "æ–°ã—ã„ãƒ¡ãƒ³ãƒãƒ¼ãŒãƒ‘ãƒ¼ãƒ†ã‚£ã«å‚åŠ ã—ã¾ã—ãŸï¼";
	}

	/// <summary>
	/// Key: "Message.PartyMembersJoined.JoinMessage"
	/// {partyInvitee} joined your party!
	/// English String: "{partyInvitee} joined your party!"
	/// </summary>
	public override string MessagePartyMembersJoinedJoinMessage(string partyInvitee)
	{
		return $"{partyInvitee}ã•ã‚“ãŒãƒ‘ãƒ¼ãƒ†ã‚£ã«å‚åŠ ã—ã¾ã—ãŸï¼";
	}

	protected override string _GetTemplateForMessagePartyMembersJoinedJoinMessage()
	{
		return "{partyInvitee}ã•ã‚“ãŒãƒ‘ãƒ¼ãƒ†ã‚£ã«å‚åŠ ã—ã¾ã—ãŸï¼";
	}

	protected override string _GetTemplateForMessagePrivateMessageReceivedDefault()
	{
		return "1ä»¶ã®ãƒ—ãƒ©ã‚¤ãƒ™ãƒ¼ãƒˆãƒ¡ãƒƒã‚»ãƒ¼ã‚¸ãŒã‚ã‚Šã¾ã™ã€‚";
	}

	/// <summary>
	/// Key: "Message.PrivateMessageReceived.MessageReceived"
	/// {messageSender} sent you a new private message.
	/// English String: "{messageSender} sent you a new private message."
	/// </summary>
	public override string MessagePrivateMessageReceivedMessageReceived(string messageSender)
	{
		return $"{messageSender} ã•ã‚“ã‹ã‚‰ãƒ—ãƒ©ã‚¤ãƒ™ãƒ¼ãƒˆãƒ¡ãƒƒã‚»ãƒ¼ã‚¸ãŒå±Šãã¾ã—ãŸã€‚";
	}

	protected override string _GetTemplateForMessagePrivateMessageReceivedMessageReceived()
	{
		return "{messageSender} ã•ã‚“ã‹ã‚‰ãƒ—ãƒ©ã‚¤ãƒ™ãƒ¼ãƒˆãƒ¡ãƒƒã‚»ãƒ¼ã‚¸ãŒå±Šãã¾ã—ãŸã€‚";
	}

	/// <summary>
	/// Key: "Message.TeamCreateInvitation"
	/// English String: "{inviter} invited you to edit the game: {gameName}!"
	/// </summary>
	public override string MessageTeamCreateInvitation(string inviter, string gameName)
	{
		return $"{inviter}ã•ã‚“ã‹ã‚‰ã‚²ãƒ¼ãƒ ã®ç·¨é›†ã«æ‹›å¾…ã•ã‚Œã¾ã—ãŸ: {gameName}ï¼";
	}

	protected override string _GetTemplateForMessageTeamCreateInvitation()
	{
		return "{inviter}ã•ã‚“ã‹ã‚‰ã‚²ãƒ¼ãƒ ã®ç·¨é›†ã«æ‹›å¾…ã•ã‚Œã¾ã—ãŸ: {gameName}ï¼";
	}

	protected override string _GetTemplateForMessageTeamCreateInvitationDefault()
	{
		return "ã‚²ãƒ¼ãƒ ã®ç·¨é›†ã«æ‹›å¾…ã•ã‚Œã¾ã—ãŸï¼";
	}

	/// <summary>
	/// Key: "Messages.PlayTogether"
	/// English String: "{actorUsername} chose a game to play together: {universeName}"
	/// </summary>
	public override string MessagesPlayTogether(string actorUsername, string universeName)
	{
		return $"{actorUsername} ã•ã‚“ãŒä¸€ç·’ã«ãƒ—ãƒ¬ã‚¤ã™ã‚‹ã‚²ãƒ¼ãƒ ã‚’é¸ã³ã¾ã—ãŸ: {universeName}";
	}

	protected override string _GetTemplateForMessagesPlayTogether()
	{
		return "{actorUsername} ã•ã‚“ãŒä¸€ç·’ã«ãƒ—ãƒ¬ã‚¤ã™ã‚‹ã‚²ãƒ¼ãƒ ã‚’é¸ã³ã¾ã—ãŸ: {universeName}";
	}
}


}
