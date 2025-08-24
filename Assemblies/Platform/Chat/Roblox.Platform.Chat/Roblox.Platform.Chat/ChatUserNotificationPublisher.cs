using System.Collections.Generic;
using System.Linq;
using Roblox.EventLog;
using Roblox.Platform.Chat.Entities;
using Roblox.Platform.Core;
using Roblox.Platform.Membership;
using Roblox.RealTimeNotifications;

namespace Roblox.Platform.Chat;

internal class ChatUserNotificationPublisher
{
	private readonly UserNotificationPublisher<ChatUpdateNotificationMessage> _UserNotificationPublisherForSocialConversations;

	private readonly UserNotificationPublisher<ChatUpdateNotificationMessage> _UserNotificationPublisherForCloudEditConversations;

	private readonly UserNotificationPublisher<ChatPrivacySettingChangeMessage> _UserNotificationPublisherForChatPrivacySettingChangeMessage;

	private readonly IUserFactory _UserFactory;

	public ChatUserNotificationPublisher(ILogger logger, IUserFactory userFactory, IUserNotificationPublisherPerformanceMonitor userNotificationPublisherPerformanceMonitor = null)
	{
		_UserNotificationPublisherForSocialConversations = new UserNotificationPublisher<ChatUpdateNotificationMessage>(logger, "ChatNotifications");
		_UserNotificationPublisherForCloudEditConversations = new UserNotificationPublisher<ChatUpdateNotificationMessage>(logger, "CloudEditChatNotifications");
		_UserNotificationPublisherForChatPrivacySettingChangeMessage = new UserNotificationPublisher<ChatPrivacySettingChangeMessage>(logger, "ChatPrivacySettingNotifications");
		_UserFactory = userFactory;
		if (userNotificationPublisherPerformanceMonitor != null)
		{
			_UserNotificationPublisherForSocialConversations.OnUserNotificationPublished += userNotificationPublisherPerformanceMonitor.LogUserNotificationPublishResult;
			_UserNotificationPublisherForCloudEditConversations.OnUserNotificationPublished += userNotificationPublisherPerformanceMonitor.LogUserNotificationPublishResult;
			_UserNotificationPublisherForChatPrivacySettingChangeMessage.OnUserNotificationPublished += userNotificationPublisherPerformanceMonitor.LogUserNotificationPublishResult;
		}
	}

	public int PublishNewMessageNotification(long conversationId, ConversationType conversationType, IReadOnlyCollection<IParticipant> participants)
	{
		ChatUpdateNotificationMessage notification = new ChatUpdateNotificationMessage(conversationId, ChatUpdateNotificationType.NewMessage);
		UserNotificationPublisher<ChatUpdateNotificationMessage> publisher = GetPublisher(conversationType);
		return PublishToUsers(publisher, notification, participants);
	}

	public void PublishNewSelfMessageNotification(long conversationId, ConversationType conversationType, IUser senderUser)
	{
		ChatUpdateNotificationMessage notification = new ChatUpdateNotificationMessage(conversationId, ChatUpdateNotificationType.NewMessageBySelf);
		UserNotificationPublisher<ChatUpdateNotificationMessage> publisher = GetPublisher(conversationType);
		PublishToUser(publisher, notification, senderUser.Id);
	}

	/// <summary>
	/// Publish a <see cref="T:Roblox.Platform.Chat.Entities.ChatUpdateNotificationMessage" /> with <see cref="F:Roblox.Platform.Chat.ChatUpdateNotificationType.MessageMarkedAsRead" /> notification.
	/// </summary>
	/// <param name="conversationId">The conversation ID</param>
	/// <param name="conversationType">The <see cref="T:Roblox.Platform.Chat.ConversationType" /></param>
	/// <param name="readingUser">The user who read the message</param>
	public void PublishMessageMarkedAsReadNotification(long conversationId, ConversationType conversationType, IUser readingUser)
	{
		ChatUpdateNotificationMessage notification = new ChatUpdateNotificationMessage(conversationId, ChatUpdateNotificationType.MessageMarkedAsRead);
		UserNotificationPublisher<ChatUpdateNotificationMessage> publisher = GetPublisher(conversationType);
		PublishToUser(publisher, notification, readingUser.Id);
	}

	public void PublishNewConversationNotification(long conversationId, ConversationType conversationType, IReadOnlyCollection<IParticipant> addedParticipantIds)
	{
		ChatUpdateNotificationMessage notification = new ChatUpdateNotificationMessage(conversationId, ChatUpdateNotificationType.NewConversation);
		UserNotificationPublisher<ChatUpdateNotificationMessage> publisher = GetPublisher(conversationType);
		PublishToUsers(publisher, notification, addedParticipantIds);
	}

	public void PublishAddedToConversationNotifications(long conversationId, ConversationType conversationType, IReadOnlyCollection<IParticipant> addedParticipantIds)
	{
		ChatUpdateNotificationMessage notification = new ChatUpdateNotificationMessage(conversationId, ChatUpdateNotificationType.AddedToConversation);
		UserNotificationPublisher<ChatUpdateNotificationMessage> publisher = GetPublisher(conversationType);
		PublishToUsers(publisher, notification, addedParticipantIds);
	}

	public void PublishNewParticipantsToConversationNotifications(long conversationId, ConversationType conversationType, IReadOnlyCollection<IParticipant> existingParticipantIds)
	{
		ChatUpdateNotificationMessage notification = new ChatUpdateNotificationMessage(conversationId, ChatUpdateNotificationType.ParticipantAdded);
		UserNotificationPublisher<ChatUpdateNotificationMessage> publisher = GetPublisher(conversationType);
		PublishToUsers(publisher, notification, existingParticipantIds);
	}

	public void PublishRemovedParticipantNotifications(long conversationId, ConversationType conversationType, IReadOnlyCollection<IParticipant> removedParticipants, IReadOnlyCollection<IParticipant> remainingParticipantIds)
	{
		ChatUpdateNotificationMessage participantLeftNotification = new ChatUpdateNotificationMessage(conversationId, ChatUpdateNotificationType.ParticipantLeft);
		ChatUpdateNotificationMessage removedFromConversationNotification = new ChatUpdateNotificationMessage(conversationId, ChatUpdateNotificationType.RemovedFromConversation);
		UserNotificationPublisher<ChatUpdateNotificationMessage> publisher = GetPublisher(conversationType);
		PublishToUsers(publisher, participantLeftNotification, remainingParticipantIds);
		PublishToUsers(publisher, removedFromConversationNotification, removedParticipants);
	}

	public void PublishConversationRemovedNotifications(long conversationId, ConversationType conversationType, IReadOnlyCollection<IParticipant> remainingParticipantIds)
	{
		ChatUpdateNotificationMessage notification = new ChatUpdateNotificationMessage(conversationId, ChatUpdateNotificationType.ConversationRemoved);
		UserNotificationPublisher<ChatUpdateNotificationMessage> publisher = GetPublisher(conversationType);
		PublishToUsers(publisher, notification, remainingParticipantIds);
	}

	public void PublishConversationTitleChangedNotification(long actorTargetId, string actorType, long conversationId, ConversationType conversationType, IReadOnlyCollection<IParticipant> participantIds)
	{
		ChatUpdateNotificationMessage notification = new ChatUpdateNotificationMessage(conversationId, actorTargetId, actorType, ChatUpdateNotificationType.ConversationTitleChanged);
		UserNotificationPublisher<ChatUpdateNotificationMessage> publisher = GetPublisher(conversationType);
		PublishToUsers(publisher, notification, participantIds);
	}

	public void PublishUserTypingStatusUpdateNotifications(long typingUserId, bool isTyping, long conversationId, ConversationType conversationType, IReadOnlyCollection<IParticipant> otherParticipants)
	{
		ChatTypingStatusUpdateNotificationMessage notification = new ChatTypingStatusUpdateNotificationMessage(conversationId, typingUserId, isTyping);
		UserNotificationPublisher<ChatUpdateNotificationMessage> publisher = GetPublisher(conversationType);
		PublishToUsers(publisher, notification, otherParticipants);
	}

	public void PublishUserPrivacySettingsChanged(IUser affectedUser, ChatPrivacySettingChangeMessageType chatPrivacySettingChangeMessageType)
	{
		ChatPrivacySettingChangeMessage notification = new ChatPrivacySettingChangeMessage(chatPrivacySettingChangeMessageType);
		_UserNotificationPublisherForChatPrivacySettingChangeMessage.Publish(affectedUser.Id, notification);
	}

	public void PublishConversationUniverseChanged(long conversationId, ConversationType conversationType, long actorTargetId, IReadOnlyCollection<IParticipant> participants, long? universeId, long? rootPlaceId)
	{
		ChatUniverseUpdateNotificationMessage notification = new ChatUniverseUpdateNotificationMessage(conversationId, actorTargetId, universeId, rootPlaceId);
		UserNotificationPublisher<ChatUpdateNotificationMessage> publisher = GetPublisher(conversationType);
		PublishToUsers(publisher, notification, participants);
	}

	private int PublishToUsers(UserNotificationPublisher<ChatUpdateNotificationMessage> publisher, ChatUpdateNotificationMessage notification, IReadOnlyCollection<IParticipant> participants)
	{
		int usersWithActiveSubscriptions = 0;
		foreach (IParticipant participant2 in participants.Where((IParticipant participant) => participant.IsUser()))
		{
			if (PublishToUser(publisher, notification, participant2.ToUser(_UserFactory).Id))
			{
				usersWithActiveSubscriptions++;
			}
		}
		return usersWithActiveSubscriptions;
	}

	private bool PublishToUser(UserNotificationPublisher<ChatUpdateNotificationMessage> publisher, ChatUpdateNotificationMessage notification, long userId)
	{
		return publisher.Publish(userId, notification).IsSuccess();
	}

	private UserNotificationPublisher<ChatUpdateNotificationMessage> GetPublisher(ConversationType conversationType)
	{
		switch (conversationType)
		{
		case ConversationType.OneToOneConversation:
		case ConversationType.MultiUserConversation:
			return _UserNotificationPublisherForSocialConversations;
		case ConversationType.CloudEditConversation:
			return _UserNotificationPublisherForCloudEditConversations;
		default:
			throw new PlatformDataIntegrityException("Invalid conversation type" + conversationType);
		}
	}
}
