using System.Collections.Generic;
using System.Linq;
using System.Text;
using Amazon.DynamoDBv2;
using Roblox.EventLog;
using Roblox.Platform.Chat.Entities;
using Roblox.Platform.Chat.Events;
using Roblox.Platform.Chat.Properties;
using Roblox.Platform.Core;
using Roblox.Platform.Membership;
using Roblox.Platform.Universes;
using Roblox.Time;

namespace Roblox.Platform.Chat;

/// <summary>
/// No authorization checks. These methods should not be used from the user facing sites
/// </summary>
public class ConversationPruner : IConversationPruner
{
	private readonly IUserFactory _UserFactory;

	private readonly IConversationDataAccessor _ConversationDataAccessor;

	private readonly ChatUserNotificationPublisher _NotificationPublisher;

	private readonly IMessageDataAccessor _MessageDataAccessor;

	private readonly ILogger _Logger;

	public ConversationPruner(IChatRedisClients chatRedisClients, IAmazonDynamoDB dynamoDbClient, IUserFactory userFactory, ILogger logger, IUniverseFactory universeFactory)
	{
		_UserFactory = userFactory;
		_NotificationPublisher = new ChatUserNotificationPublisher(logger, userFactory);
		_ConversationDataAccessor = ConversationDataAccessorFactory.GetConversationDataAccessor(chatRedisClients.ChatConversationRedisClient, logger, universeFactory);
		_MessageDataAccessor = MessageDataAccessorFactory.GetMessageDataAccessor(chatRedisClients, dynamoDbClient, logger, new InstantProvider());
		_Logger = logger;
	}

	public void RemoveConversationFromUsersLists(long conversationId, long userId)
	{
		IParticipant userAsParticipant = _UserFactory.GetUser(userId).ToParticipant();
		if (!_ConversationDataAccessor.DoesContainParticipant(conversationId, userAsParticipant))
		{
			_ConversationDataAccessor.RemoveConversationParticipant(conversationId, userAsParticipant);
		}
	}

	public void DeleteMessages(long conversationId)
	{
		_MessageDataAccessor.RemoveMessages(conversationId);
	}

	/// <summary>
	/// No authorization checks. This method should not be used from the user facing sites
	/// </summary>
	public void ArchiveOneToOneConversation(IUser firstUser, IUser secondUser)
	{
		if (firstUser == null || secondUser == null)
		{
			throw new PlatformArgumentNullException("Users cannot be null");
		}
		IParticipant[] participants = new IParticipant[2]
		{
			firstUser.ToParticipant(),
			secondUser.ToParticipant()
		};
		long? conversationId = _ConversationDataAccessor.ArchiveOneToOneConversation(participants[0], participants[1]);
		if (conversationId.HasValue)
		{
			_NotificationPublisher.PublishConversationRemovedNotifications(conversationId.Value, ConversationType.OneToOneConversation, (IReadOnlyCollection<IParticipant>)(object)participants);
		}
	}

	/// <summary>
	/// No authorization checks. This method should not be used from the user facing sites
	/// </summary>
	public bool RestoreOneToOneConversation(IUser firstUser, IUser secondUser)
	{
		if (firstUser == null || secondUser == null)
		{
			throw new PlatformArgumentNullException("Users cannot be null");
		}
		IParticipant[] participants = new IParticipant[2]
		{
			firstUser.ToParticipant(),
			secondUser.ToParticipant()
		};
		long? conversationId = _ConversationDataAccessor.RestoreOneToOneConversation(participants[0], participants[1]);
		if (conversationId.HasValue)
		{
			_NotificationPublisher.PublishNewConversationNotification(conversationId.Value, ConversationType.OneToOneConversation, (IReadOnlyCollection<IParticipant>)(object)participants);
			return true;
		}
		return false;
	}

	/// <summary>
	/// This method is invoked async to get particpant's conversations that might have a stale score/last updated timestamp and update them with the correct score,
	/// if there has been a more recent message in the conversation
	/// </summary>
	/// <param name="userId"></param>
	/// <param name="conversationsMissingInCache"></param>
	public void UpdateScoreForParticipantConversationsMissingInCache(long userId, ConversationsMissingInCache conversationsMissingInCache)
	{
		IParticipant userAsParticipant = _UserFactory.GetUser(userId).ToParticipant();
		IReadOnlyCollection<ConversationIdWithScore> convsEligibleForScoreUpdate = _ConversationDataAccessor.GetCacheMissParticipantConversationsEligibleForScoreUpdate(userAsParticipant, conversationsMissingInCache);
		if (convsEligibleForScoreUpdate == null)
		{
			return;
		}
		StringBuilder conversationsRequiringScoreUpdate = new StringBuilder();
		foreach (ConversationIdWithScore conversation in convsEligibleForScoreUpdate)
		{
			IChatMessageEntity latestUpdated = _MessageDataAccessor.GetMessages(userId, conversation.ConversationId, null, 1).FirstOrDefault()?.Message;
			if (latestUpdated?.Sent?.Ticks - conversation.Score > Settings.Default.ConversationScoreUpdateCutoffFromLastMessageTimestamp.Ticks)
			{
				_ConversationDataAccessor.UpdateParticipantConversationScoreInCache(userAsParticipant, conversation.ConversationId, latestUpdated.Sent.Ticks);
				conversationsRequiringScoreUpdate.Append(conversation.ConversationId).Append(", ");
			}
		}
		if (Settings.Default.IsLoggingEnabledForConversationsScoreUpdateOnCacheMissEvents && conversationsRequiringScoreUpdate != null && conversationsRequiringScoreUpdate.Length > 0)
		{
			_Logger.Info($"Updating score in Redis ParticipantConversation cache for participant's: {userId} conversation Ids: {conversationsRequiringScoreUpdate.ToString()}");
		}
	}
}
