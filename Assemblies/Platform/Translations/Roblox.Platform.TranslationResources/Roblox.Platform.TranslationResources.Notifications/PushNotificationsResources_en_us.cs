using System;
using System.Collections.Generic;

namespace Roblox.TranslationResources.Notifications;

internal class PushNotificationsResources_en_us : TranslationResourcesBase, IPushNotificationsResources, ITranslationResources
{
	private readonly Lazy<IReadOnlyDictionary<string, string>> _AllKeys;

	/// <summary>
	/// Key: "Message.AddedToPrivateServerWhiteList.Default"
	/// You have a been invited to a VIP server!
	/// English String: "You have a been invited to a VIP server!"
	/// </summary>
	public virtual string MessageAddedToPrivateServerWhiteListDefault => "You have a been invited to a VIP server!";

	/// <summary>
	/// Key: "Message.DefaultSystemMessage.Body"
	/// New activity on Roblox!
	/// English String: "New activity on Roblox!"
	/// </summary>
	public virtual string MessageDefaultSystemMessageBody => "New activity on Roblox!";

	/// <summary>
	/// Key: "Message.DefaultSystemMessage.Title"
	/// Roblox
	/// English String: "Roblox"
	/// </summary>
	public virtual string MessageDefaultSystemMessageTitle => "Roblox";

	/// <summary>
	/// Key: "Message.FriendRequestAccepted.Default"
	/// Your friend request has been accepted!
	/// English String: "Your friend request has been accepted!"
	/// </summary>
	public virtual string MessageFriendRequestAcceptedDefault => "Your friend request has been accepted!";

	/// <summary>
	/// Key: "Message.FriendRequestReceived.Default"
	/// You have a new friend request!
	/// English String: "You have a new friend request!"
	/// </summary>
	public virtual string MessageFriendRequestReceivedDefault => "You have a new friend request!";

	/// <summary>
	/// Key: "Message.NewChatMessage.Default"
	/// You have a new chat message.
	/// English String: "You have a new chat message."
	/// </summary>
	public virtual string MessageNewChatMessageDefault => "You have a new chat message.";

	/// <summary>
	/// Key: "Message.PartyInvitation.Default"
	/// You are invited to a party!
	/// English String: "You are invited to a party!"
	/// </summary>
	public virtual string MessagePartyInvitationDefault => "You are invited to a party!";

	/// <summary>
	/// Key: "Message.PartyMembersJoined.Default"
	/// A new member joined your party!
	/// English String: "A new member joined your party!"
	/// </summary>
	public virtual string MessagePartyMembersJoinedDefault => "A new member joined your party!";

	/// <summary>
	/// Key: "Message.PrivateMessageReceived.Default"
	/// You have a new private message.
	/// English String: "You have a new private message."
	/// </summary>
	public virtual string MessagePrivateMessageReceivedDefault => "You have a new private message.";

	/// <summary>
	/// Key: "Message.TeamCreateInvitation.Default"
	/// A user invites another user to contribute to a team create game.
	/// English String: "You are invited to edit a game!"
	/// </summary>
	public virtual string MessageTeamCreateInvitationDefault => "You are invited to edit a game!";

	public PushNotificationsResources_en_us(TranslationResourceState state)
		: base(state)
	{
		_AllKeys = new Lazy<IReadOnlyDictionary<string, string>>(() => new Dictionary<string, string>
		{
			{
				"Message.AddedToPrivateServerWhiteList.AddedToWhiteListMessage",
				_GetTemplateForMessageAddedToPrivateServerWhiteListAddedToWhiteListMessage()
			},
			{
				"Message.AddedToPrivateServerWhiteList.Default",
				_GetTemplateForMessageAddedToPrivateServerWhiteListDefault()
			},
			{
				"Message.DefaultSystemMessage.Body",
				_GetTemplateForMessageDefaultSystemMessageBody()
			},
			{
				"Message.DefaultSystemMessage.Title",
				_GetTemplateForMessageDefaultSystemMessageTitle()
			},
			{
				"Message.FriendRequestAccepted.AcceptedMessage",
				_GetTemplateForMessageFriendRequestAcceptedAcceptedMessage()
			},
			{
				"Message.FriendRequestAccepted.Default",
				_GetTemplateForMessageFriendRequestAcceptedDefault()
			},
			{
				"Message.FriendRequestReceived.CompleteMessage",
				_GetTemplateForMessageFriendRequestReceivedCompleteMessage()
			},
			{
				"Message.FriendRequestReceived.Default",
				_GetTemplateForMessageFriendRequestReceivedDefault()
			},
			{
				"Message.FriendRequestReceived.NewRequestMessage",
				_GetTemplateForMessageFriendRequestReceivedNewRequestMessage()
			},
			{
				"Message.NewChatMessage.Default",
				_GetTemplateForMessageNewChatMessageDefault()
			},
			{
				"Message.NewChatMessage.ReceivedGroupMessage",
				_GetTemplateForMessageNewChatMessageReceivedGroupMessage()
			},
			{
				"Message.NewChatMessage.ReceivedMessage",
				_GetTemplateForMessageNewChatMessageReceivedMessage()
			},
			{
				"Message.PartyInvitation.Default",
				_GetTemplateForMessagePartyInvitationDefault()
			},
			{
				"Message.PartyInvitation.PartyMessage",
				_GetTemplateForMessagePartyInvitationPartyMessage()
			},
			{
				"Message.PartyInvitation.XBoxPartyMessage",
				_GetTemplateForMessagePartyInvitationXBoxPartyMessage()
			},
			{
				"Message.PartyMembersJoined.Default",
				_GetTemplateForMessagePartyMembersJoinedDefault()
			},
			{
				"Message.PartyMembersJoined.JoinMessage",
				_GetTemplateForMessagePartyMembersJoinedJoinMessage()
			},
			{
				"Message.PrivateMessageReceived.Default",
				_GetTemplateForMessagePrivateMessageReceivedDefault()
			},
			{
				"Message.PrivateMessageReceived.MessageReceived",
				_GetTemplateForMessagePrivateMessageReceivedMessageReceived()
			},
			{
				"Message.TeamCreateInvitation",
				_GetTemplateForMessageTeamCreateInvitation()
			},
			{
				"Message.TeamCreateInvitation.Default",
				_GetTemplateForMessageTeamCreateInvitationDefault()
			},
			{
				"Messages.PlayTogether",
				_GetTemplateForMessagesPlayTogether()
			}
		});
	}

	public IReadOnlyDictionary<string, string> GetAllKeys()
	{
		return _AllKeys.Value;
	}

	public string GetFullContentNamespaceName()
	{
		return "Notifications.PushNotifications";
	}

	/// <summary>
	/// Key: "Message.AddedToPrivateServerWhiteList.AddedToWhiteListMessage"
	/// {vipInviter} added you to their VIP server, {server}, at {place}!
	/// English String: "{vipInviter} added you to their VIP server, {server}, at {place}!"
	/// </summary>
	public virtual string MessageAddedToPrivateServerWhiteListAddedToWhiteListMessage(string vipInviter, string server, string place)
	{
		return $"{vipInviter} added you to their VIP server, {server}, at {place}!";
	}

	protected virtual string _GetTemplateForMessageAddedToPrivateServerWhiteListAddedToWhiteListMessage()
	{
		return "{vipInviter} added you to their VIP server, {server}, at {place}!";
	}

	protected virtual string _GetTemplateForMessageAddedToPrivateServerWhiteListDefault()
	{
		return "You have a been invited to a VIP server!";
	}

	protected virtual string _GetTemplateForMessageDefaultSystemMessageBody()
	{
		return "New activity on Roblox!";
	}

	protected virtual string _GetTemplateForMessageDefaultSystemMessageTitle()
	{
		return "Roblox";
	}

	/// <summary>
	/// Key: "Message.FriendRequestAccepted.AcceptedMessage"
	/// {friend} accepted your friend request!
	/// English String: "{friend} accepted your friend request!"
	/// </summary>
	public virtual string MessageFriendRequestAcceptedAcceptedMessage(string friend)
	{
		return $"{friend} accepted your friend request!";
	}

	protected virtual string _GetTemplateForMessageFriendRequestAcceptedAcceptedMessage()
	{
		return "{friend} accepted your friend request!";
	}

	protected virtual string _GetTemplateForMessageFriendRequestAcceptedDefault()
	{
		return "Your friend request has been accepted!";
	}

	/// <summary>
	/// Key: "Message.FriendRequestReceived.CompleteMessage"
	/// You have just accepted {friend} as your friend!
	/// English String: "You are now friends with {friend}!"
	/// </summary>
	public virtual string MessageFriendRequestReceivedCompleteMessage(string friend)
	{
		return $"You are now friends with {friend}!";
	}

	protected virtual string _GetTemplateForMessageFriendRequestReceivedCompleteMessage()
	{
		return "You are now friends with {friend}!";
	}

	protected virtual string _GetTemplateForMessageFriendRequestReceivedDefault()
	{
		return "You have a new friend request!";
	}

	/// <summary>
	/// Key: "Message.FriendRequestReceived.NewRequestMessage"
	/// {friend} sent you a friend request!
	/// English String: "{friend} sent you a friend request!"
	/// </summary>
	public virtual string MessageFriendRequestReceivedNewRequestMessage(string friend)
	{
		return $"{friend} sent you a friend request!";
	}

	protected virtual string _GetTemplateForMessageFriendRequestReceivedNewRequestMessage()
	{
		return "{friend} sent you a friend request!";
	}

	protected virtual string _GetTemplateForMessageNewChatMessageDefault()
	{
		return "You have a new chat message.";
	}

	/// <summary>
	/// Key: "Message.NewChatMessage.ReceivedGroupMessage"
	/// notification for a chat message sent in a Group Chat. Conversation title is Group Title.
	/// English String: "{senderUserName} to {conversationTitle}: {messageContent}"
	/// </summary>
	public virtual string MessageNewChatMessageReceivedGroupMessage(string senderUserName, string conversationTitle, string messageContent)
	{
		return $"{senderUserName} to {conversationTitle}: {messageContent}";
	}

	protected virtual string _GetTemplateForMessageNewChatMessageReceivedGroupMessage()
	{
		return "{senderUserName} to {conversationTitle}: {messageContent}";
	}

	/// <summary>
	/// Key: "Message.NewChatMessage.ReceivedMessage"
	/// {friend}: {message}
	/// English String: "{friend}: {message}"
	/// </summary>
	public virtual string MessageNewChatMessageReceivedMessage(string friend, string message)
	{
		return $"{friend}: {message}";
	}

	protected virtual string _GetTemplateForMessageNewChatMessageReceivedMessage()
	{
		return "{friend}: {message}";
	}

	protected virtual string _GetTemplateForMessagePartyInvitationDefault()
	{
		return "You are invited to a party!";
	}

	/// <summary>
	/// Key: "Message.PartyInvitation.PartyMessage"
	/// {partyInviter} invited you to a party!
	/// English String: "{partyInviter} invited you to a party!"
	/// </summary>
	public virtual string MessagePartyInvitationPartyMessage(string partyInviter)
	{
		return $"{partyInviter} invited you to a party!";
	}

	protected virtual string _GetTemplateForMessagePartyInvitationPartyMessage()
	{
		return "{partyInviter} invited you to a party!";
	}

	/// <summary>
	/// Key: "Message.PartyInvitation.XBoxPartyMessage"
	/// {partyInviter} invited you to an XBOX party!
	/// English String: "{partyInviter} invited you to an XBOX party!"
	/// </summary>
	public virtual string MessagePartyInvitationXBoxPartyMessage(string partyInviter)
	{
		return $"{partyInviter} invited you to an XBOX party!";
	}

	protected virtual string _GetTemplateForMessagePartyInvitationXBoxPartyMessage()
	{
		return "{partyInviter} invited you to an XBOX party!";
	}

	protected virtual string _GetTemplateForMessagePartyMembersJoinedDefault()
	{
		return "A new member joined your party!";
	}

	/// <summary>
	/// Key: "Message.PartyMembersJoined.JoinMessage"
	/// {partyInvitee} joined your party!
	/// English String: "{partyInvitee} joined your party!"
	/// </summary>
	public virtual string MessagePartyMembersJoinedJoinMessage(string partyInvitee)
	{
		return $"{partyInvitee} joined your party!";
	}

	protected virtual string _GetTemplateForMessagePartyMembersJoinedJoinMessage()
	{
		return "{partyInvitee} joined your party!";
	}

	protected virtual string _GetTemplateForMessagePrivateMessageReceivedDefault()
	{
		return "You have a new private message.";
	}

	/// <summary>
	/// Key: "Message.PrivateMessageReceived.MessageReceived"
	/// {messageSender} sent you a new private message.
	/// English String: "{messageSender} sent you a new private message."
	/// </summary>
	public virtual string MessagePrivateMessageReceivedMessageReceived(string messageSender)
	{
		return $"{messageSender} sent you a new private message.";
	}

	protected virtual string _GetTemplateForMessagePrivateMessageReceivedMessageReceived()
	{
		return "{messageSender} sent you a new private message.";
	}

	/// <summary>
	/// Key: "Message.TeamCreateInvitation"
	/// English String: "{inviter} invited you to edit the game: {gameName}!"
	/// </summary>
	public virtual string MessageTeamCreateInvitation(string inviter, string gameName)
	{
		return $"{inviter} invited you to edit the game: {gameName}!";
	}

	protected virtual string _GetTemplateForMessageTeamCreateInvitation()
	{
		return "{inviter} invited you to edit the game: {gameName}!";
	}

	protected virtual string _GetTemplateForMessageTeamCreateInvitationDefault()
	{
		return "You are invited to edit a game!";
	}

	/// <summary>
	/// Key: "Messages.PlayTogether"
	/// English String: "{actorUsername} chose a game to play together: {universeName}"
	/// </summary>
	public virtual string MessagesPlayTogether(string actorUsername, string universeName)
	{
		return $"{actorUsername} chose a game to play together: {universeName}";
	}

	protected virtual string _GetTemplateForMessagesPlayTogether()
	{
		return "{actorUsername} chose a game to play together: {universeName}";
	}
}
