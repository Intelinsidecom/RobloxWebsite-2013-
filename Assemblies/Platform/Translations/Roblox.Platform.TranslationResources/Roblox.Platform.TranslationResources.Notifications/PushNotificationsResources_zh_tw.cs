namespace Roblox.Platform.TranslationResources.Notifications {
    /// <summary>

/// This class overrides PushNotificationsResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class PushNotificationsResources_zh_tw : PushNotificationsResources_en_us, IPushNotificationsResources, ITranslationResources
{
	/// <summary>
	/// Key: "Message.AddedToPrivateServerWhiteList.Default"
	/// You have a been invited to a VIP server!
	/// English String: "You have a been invited to a VIP server!"
	/// </summary>
	public override string MessageAddedToPrivateServerWhiteListDefault => "æ‚¨å·²å—é‚€åˆ° VIP ä¼ºæœå™¨ï¼";

	/// <summary>
	/// Key: "Message.DefaultSystemMessage.Body"
	/// New activity on Roblox!
	/// English String: "New activity on Roblox!"
	/// </summary>
	public override string MessageDefaultSystemMessageBody => "Roblox æœ‰æ–°æ´»å‹•ï¼";

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
	public override string MessageFriendRequestAcceptedDefault => "æ‚¨çš„å¥½å‹é‚€è«‹å·²è¢«æŽ¥å—ï¼";

	/// <summary>
	/// Key: "Message.FriendRequestReceived.Default"
	/// You have a new friend request!
	/// English String: "You have a new friend request!"
	/// </summary>
	public override string MessageFriendRequestReceivedDefault => "æ‚¨æœ‰æ–°çš„å¥½å‹é‚€è«‹ï¼";

	/// <summary>
	/// Key: "Message.NewChatMessage.Default"
	/// You have a new chat message.
	/// English String: "You have a new chat message."
	/// </summary>
	public override string MessageNewChatMessageDefault => "æ‚¨æœ‰æ–°çš„èŠå¤©è¨Šæ¯ã€‚";

	/// <summary>
	/// Key: "Message.PartyInvitation.Default"
	/// You are invited to a party!
	/// English String: "You are invited to a party!"
	/// </summary>
	public override string MessagePartyInvitationDefault => "æ‚¨è¢«é‚€è«‹åŠ å…¥éšŠä¼ï¼";

	/// <summary>
	/// Key: "Message.PartyMembersJoined.Default"
	/// A new member joined your party!
	/// English String: "A new member joined your party!"
	/// </summary>
	public override string MessagePartyMembersJoinedDefault => "æœ‰æ–°æˆå“¡åŠ å…¥æ‚¨çš„éšŠä¼ï¼";

	/// <summary>
	/// Key: "Message.PrivateMessageReceived.Default"
	/// You have a new private message.
	/// English String: "You have a new private message."
	/// </summary>
	public override string MessagePrivateMessageReceivedDefault => "æ‚¨æœ‰æ–°çš„ç§äººè¨Šæ¯ã€‚";

	/// <summary>
	/// Key: "Message.TeamCreateInvitation.Default"
	/// A user invites another user to contribute to a team create game.
	/// English String: "You are invited to edit a game!"
	/// </summary>
	public override string MessageTeamCreateInvitationDefault => "æ‚¨è¢«é‚€è«‹ä¸€èµ·ç·¨è¼¯éŠæˆ²ï¼";

	public PushNotificationsResources_zh_tw(TranslationResourceState state)
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
		return $"{vipInviter} å·²å°‡æ‚¨åŠ å…¥ {place} çš„ {server} VIP ä¼ºæœå™¨ï¼";
	}

	protected override string _GetTemplateForMessageAddedToPrivateServerWhiteListAddedToWhiteListMessage()
	{
		return "{vipInviter} å·²å°‡æ‚¨åŠ å…¥ {place} çš„ {server} VIP ä¼ºæœå™¨ï¼";
	}

	protected override string _GetTemplateForMessageAddedToPrivateServerWhiteListDefault()
	{
		return "æ‚¨å·²å—é‚€åˆ° VIP ä¼ºæœå™¨ï¼";
	}

	protected override string _GetTemplateForMessageDefaultSystemMessageBody()
	{
		return "Roblox æœ‰æ–°æ´»å‹•ï¼";
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
		return $"{friend} å·²æŽ¥å—æ‚¨çš„å¥½å‹é‚€è«‹ï¼";
	}

	protected override string _GetTemplateForMessageFriendRequestAcceptedAcceptedMessage()
	{
		return "{friend} å·²æŽ¥å—æ‚¨çš„å¥½å‹é‚€è«‹ï¼";
	}

	protected override string _GetTemplateForMessageFriendRequestAcceptedDefault()
	{
		return "æ‚¨çš„å¥½å‹é‚€è«‹å·²è¢«æŽ¥å—ï¼";
	}

	/// <summary>
	/// Key: "Message.FriendRequestReceived.CompleteMessage"
	/// You have just accepted {friend} as your friend!
	/// English String: "You are now friends with {friend}!"
	/// </summary>
	public override string MessageFriendRequestReceivedCompleteMessage(string friend)
	{
		return $"æ‚¨å·²èˆ‡ {friend} æˆç‚ºå¥½å‹ï¼";
	}

	protected override string _GetTemplateForMessageFriendRequestReceivedCompleteMessage()
	{
		return "æ‚¨å·²èˆ‡ {friend} æˆç‚ºå¥½å‹ï¼";
	}

	protected override string _GetTemplateForMessageFriendRequestReceivedDefault()
	{
		return "æ‚¨æœ‰æ–°çš„å¥½å‹é‚€è«‹ï¼";
	}

	/// <summary>
	/// Key: "Message.FriendRequestReceived.NewRequestMessage"
	/// {friend} sent you a friend request!
	/// English String: "{friend} sent you a friend request!"
	/// </summary>
	public override string MessageFriendRequestReceivedNewRequestMessage(string friend)
	{
		return $"{friend} å‘æ‚¨å‚³é€å¥½å‹é‚€è«‹ï¼";
	}

	protected override string _GetTemplateForMessageFriendRequestReceivedNewRequestMessage()
	{
		return "{friend} å‘æ‚¨å‚³é€å¥½å‹é‚€è«‹ï¼";
	}

	protected override string _GetTemplateForMessageNewChatMessageDefault()
	{
		return "æ‚¨æœ‰æ–°çš„èŠå¤©è¨Šæ¯ã€‚";
	}

	/// <summary>
	/// Key: "Message.NewChatMessage.ReceivedGroupMessage"
	/// notification for a chat message sent in a Group Chat. Conversation title is Group Title.
	/// English String: "{senderUserName} to {conversationTitle}: {messageContent}"
	/// </summary>
	public override string MessageNewChatMessageReceivedGroupMessage(string senderUserName, string conversationTitle, string messageContent)
	{
		return $"{senderUserName} å° {conversationTitle}ï¼š{messageContent}";
	}

	protected override string _GetTemplateForMessageNewChatMessageReceivedGroupMessage()
	{
		return "{senderUserName} å° {conversationTitle}ï¼š{messageContent}";
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
		return "æ‚¨è¢«é‚€è«‹åŠ å…¥éšŠä¼ï¼";
	}

	/// <summary>
	/// Key: "Message.PartyInvitation.PartyMessage"
	/// {partyInviter} invited you to a party!
	/// English String: "{partyInviter} invited you to a party!"
	/// </summary>
	public override string MessagePartyInvitationPartyMessage(string partyInviter)
	{
		return $"{partyInviter} é‚€è«‹æ‚¨åŠ å…¥éšŠä¼ï¼";
	}

	protected override string _GetTemplateForMessagePartyInvitationPartyMessage()
	{
		return "{partyInviter} é‚€è«‹æ‚¨åŠ å…¥éšŠä¼ï¼";
	}

	/// <summary>
	/// Key: "Message.PartyInvitation.XBoxPartyMessage"
	/// {partyInviter} invited you to an XBOX party!
	/// English String: "{partyInviter} invited you to an XBOX party!"
	/// </summary>
	public override string MessagePartyInvitationXBoxPartyMessage(string partyInviter)
	{
		return $"{partyInviter} é‚€è«‹æ‚¨åŠ å…¥ Xbox éšŠä¼ï¼";
	}

	protected override string _GetTemplateForMessagePartyInvitationXBoxPartyMessage()
	{
		return "{partyInviter} é‚€è«‹æ‚¨åŠ å…¥ Xbox éšŠä¼ï¼";
	}

	protected override string _GetTemplateForMessagePartyMembersJoinedDefault()
	{
		return "æœ‰æ–°æˆå“¡åŠ å…¥æ‚¨çš„éšŠä¼ï¼";
	}

	/// <summary>
	/// Key: "Message.PartyMembersJoined.JoinMessage"
	/// {partyInvitee} joined your party!
	/// English String: "{partyInvitee} joined your party!"
	/// </summary>
	public override string MessagePartyMembersJoinedJoinMessage(string partyInvitee)
	{
		return $"{partyInvitee} å·²åŠ å…¥æ‚¨çš„éšŠä¼ï¼";
	}

	protected override string _GetTemplateForMessagePartyMembersJoinedJoinMessage()
	{
		return "{partyInvitee} å·²åŠ å…¥æ‚¨çš„éšŠä¼ï¼";
	}

	protected override string _GetTemplateForMessagePrivateMessageReceivedDefault()
	{
		return "æ‚¨æœ‰æ–°çš„ç§äººè¨Šæ¯ã€‚";
	}

	/// <summary>
	/// Key: "Message.PrivateMessageReceived.MessageReceived"
	/// {messageSender} sent you a new private message.
	/// English String: "{messageSender} sent you a new private message."
	/// </summary>
	public override string MessagePrivateMessageReceivedMessageReceived(string messageSender)
	{
		return $"{messageSender} å‘æ‚¨å‚³é€æ–°çš„ç§äººè¨Šæ¯ã€‚";
	}

	protected override string _GetTemplateForMessagePrivateMessageReceivedMessageReceived()
	{
		return "{messageSender} å‘æ‚¨å‚³é€æ–°çš„ç§äººè¨Šæ¯ã€‚";
	}

	/// <summary>
	/// Key: "Message.TeamCreateInvitation"
	/// English String: "{inviter} invited you to edit the game: {gameName}!"
	/// </summary>
	public override string MessageTeamCreateInvitation(string inviter, string gameName)
	{
		return $"{inviter}é‚€è«‹æ‚¨ç·¨è¼¯æ­¤éŠæˆ²ï¼š{gameName}ï¼";
	}

	protected override string _GetTemplateForMessageTeamCreateInvitation()
	{
		return "{inviter}é‚€è«‹æ‚¨ç·¨è¼¯æ­¤éŠæˆ²ï¼š{gameName}ï¼";
	}

	protected override string _GetTemplateForMessageTeamCreateInvitationDefault()
	{
		return "æ‚¨è¢«é‚€è«‹ä¸€èµ·ç·¨è¼¯éŠæˆ²ï¼";
	}

	/// <summary>
	/// Key: "Messages.PlayTogether"
	/// English String: "{actorUsername} chose a game to play together: {universeName}"
	/// </summary>
	public override string MessagesPlayTogether(string actorUsername, string universeName)
	{
		return $"{actorUsername} é¸æ“‡äº†ä¸€èµ·çŽ©çš„éŠæˆ²ï¼šã€Œ{universeName}ã€";
	}

	protected override string _GetTemplateForMessagesPlayTogether()
	{
		return "{actorUsername} é¸æ“‡äº†ä¸€èµ·çŽ©çš„éŠæˆ²ï¼šã€Œ{universeName}ã€";
	}
}


}
