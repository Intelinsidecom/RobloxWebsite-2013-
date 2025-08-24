using System;
using System.Collections.Generic;
using System.Linq;
using Roblox.EventLog;
using Roblox.Instrumentation;
using Roblox.Platform.Chat.Entities;
using Roblox.Platform.Chat.Properties;
using Roblox.Platform.Core;
using Roblox.Platform.Devices;
using Roblox.Platform.Membership;
using Roblox.Platform.Universes;
using Roblox.RealTimeNotifications;

namespace Roblox.Platform.Chat.Events;

public class ChatEventHandlerRegistrar
{
	private readonly ChatEventsPublisherBase<ChatEvent> _ChatEventsPublisher;

	private readonly ChatEventsPublisherBase<ChatConversationEvent> _ChatConversationEventsPublisher;

	private readonly ConversationBuilder _ConversationBuilder;

	private readonly ChatUserNotificationPublisher _RealtimePublisher;

	private readonly IChatMetricsTracker _ChatMetricsTracker;

	private readonly ChatMessageSender _ChatMessageSender;

	private readonly IChatEventStreamer _ChatEventStreamer;

	private readonly IUserFactory _UserFactory;

	private readonly IPlayTogetherEventsPublisher _PlayTogetherSnsPublisher;

	private readonly IChatEventParserFactory _ChatEventParserFactory;

	private readonly ILogger _Logger;

	internal virtual bool IsMessageMarkedAsReadNotificationEnabled => Settings.Default.IsMessageMarkedAsReadNotificationEnabled;

	public ChatEventHandlerRegistrar(ChatMessageSender chatMessageSender, ConversationBuilder conversationBuilder, IChatMetricsTracker chatMetricsTracker, ILogger logger, IUserFactory userFactory, IChatEventStreamer chatEventStreamer, IUserNotificationPublisherPerformanceMonitor userNotificationPublisherPerformanceMonitor, ICounterRegistry counterRegistry)
	{
		_ChatEventsPublisher = new ChatEventsPublisher(logger, counterRegistry);
		_ChatConversationEventsPublisher = new ChatConversationEventsPublisher(logger, counterRegistry);
		_ConversationBuilder = conversationBuilder;
		_RealtimePublisher = new ChatUserNotificationPublisher(logger, userFactory, userNotificationPublisherPerformanceMonitor);
		_ChatMetricsTracker = chatMetricsTracker;
		_ChatMessageSender = chatMessageSender;
		_ChatEventStreamer = chatEventStreamer;
		_UserFactory = userFactory;
		_PlayTogetherSnsPublisher = new PlayTogetherEventsPublisher(logger, counterRegistry);
		_ChatEventParserFactory = ChatMessageParserFactoryCreator.GetChatEventParserFactory(logger);
		_Logger = logger ?? throw new PlatformArgumentNullException("logger");
	}

	public void Register()
	{
		_ConversationBuilder.OnConversationAbandoned += OnConversationAbandoned;
		ConversationDataAccessor.OnMissingParticipantDetected += OnMissingParticipantDetected;
		MessageDataAccessor.OnMessagesMissingFromCache += OnMissingMessageFromCache;
		MessageDataAccessor.OnRedisHit += OnChatRedisHit;
		MessageDataAccessor.OnRedisMiss += OnChatRedisMiss;
		RedisParticipantConversationCache.OnConversationCacheHit += OnConversationRedisHit;
		RedisParticipantConversationCache.OnConversationCacheMiss += OnConversationRedisMiss;
		RedisConversationParticipantCache.OnParticipantCacheHit += OnParticipantRedisHit;
		RedisConversationParticipantCache.OnParticipantCacheMiss += OnParticipantRedisMiss;
		_ChatMessageSender.OnNewMessageSendAttemptedWithoutRealTime += OnNewMessageSendAttemptedWithoutRealTime;
		_ChatMessageSender.OnNewMessageSent += OnNewMessageSent;
		_ChatMessageSender.OnMessageMarkedAsRead += OnMessageMarkedAsRead;
		_ConversationBuilder.OnNewConversationCreated += OnNewConversationCreated;
		_ConversationBuilder.OnUsersAddedToConversation += OnUsersAddedToConversation;
		_ConversationBuilder.OnUsersRemovedFromConversation += OnUsersRemovedFromConversation;
		_ConversationBuilder.OnUserTypingStatusUpdate += OnUserTypingStatusUpdate;
		_ConversationBuilder.OnConversationTitleChanged += OnConversationTitleChanged;
		_ConversationBuilder.OnConversationUniverseChanged += OnConversationUniverseChanged;
		RedisParticipantConversationCache.OnParticipantConversationCacheMissingEntriesDetected += OnParticipantConversationCacheMissingEntriesDetected;
		RedisParticipantConversationCache.OnParticipantAllConversationCacheMiss += OnParticipantAllConversationCacheMiss;
		_ChatMessageSender.OnNewMessageContentModerated += OnNewMessageContentModerated;
	}

	private void OnNewMessageSendAttemptedWithoutRealTime(long conversationId, IPlatform platform, IUser senderUser)
	{
		_ChatMetricsTracker.RecordMessageSendAttemptedWithoutRealTime(platform);
	}

	private void OnParticipantConversationCacheMissingEntriesDetected(long userId, IReadOnlyCollection<ConversationIdWithUpdatedDate> conversations)
	{
		if (conversations == null || conversations.Count <= 0)
		{
			return;
		}
		_ChatMetricsTracker.RecordParticipantConversationCacheMissingEntries();
		IUser user = _UserFactory.GetUser(userId);
		if (user != null && RolloutFeatureSupport.IsFeatureEnabled(user, Settings.Default.IsConversationScoreUpdateOnCacheMissEnabledForSoothsayers, Settings.Default.IsConversationScoreUpdateOnCacheMissEnabledForBetatesters, Settings.Default.ConversationScoreUpdateOnCacheMissRolloutPercentage))
		{
			ConversationIdWithUpdatedDate[] array = conversations.OrderBy((ConversationIdWithUpdatedDate conversation) => conversation.Updated).ToArray();
			List<long> conversationIds = array.Select((ConversationIdWithUpdatedDate conversation) => conversation.ConversationId).ToList();
			long minScore = array[0].Updated.Ticks;
			long maxScore = array[array.Length - 1].Updated.Ticks;
			ChatEvent eventToPublish = new ChatEvent
			{
				ChatEventType = ChatEventType.ParticipantConversationCacheRestore,
				AffectedUserId = userId,
				ConversationsMissingInCacheMessage = new ConversationsMissingInCache(conversationIds, minScore, maxScore)
			};
			_ChatEventsPublisher.Publish(eventToPublish);
		}
	}

	private void OnParticipantAllConversationCacheMiss(long userId)
	{
		IUser user = _UserFactory.GetUser(userId);
		if (user != null && RolloutFeatureSupport.IsFeatureEnabled(user, Settings.Default.IsConversationScoreUpdateOnCacheMissEnabledForSoothsayers, Settings.Default.IsConversationScoreUpdateOnCacheMissEnabledForBetatesters, Settings.Default.ConversationScoreUpdateOnCacheMissRolloutPercentage))
		{
			ChatEvent eventToPublish = new ChatEvent
			{
				ChatEventType = ChatEventType.ParticipantConversationCacheRestore,
				AffectedUserId = userId,
				ConversationsMissingInCacheMessage = new ConversationsMissingInCache(null, double.NegativeInfinity, DateTime.UtcNow.Ticks)
			};
			_ChatEventsPublisher.Publish(eventToPublish);
		}
	}

	private void OnMissingMessageFromCache(long conversationId)
	{
		ChatEvent eventToPublish = new ChatEvent
		{
			ConversationId = conversationId,
			ChatEventType = ChatEventType.ConversationWithMissingMessages
		};
		_ChatEventsPublisher.Publish(eventToPublish);
	}

	private void OnChatRedisHit(int numberOfMessages)
	{
		_ChatMetricsTracker.RecordChatRedisHits(numberOfMessages);
	}

	private void OnChatRedisMiss(int numberOfMessages)
	{
		_ChatMetricsTracker.RecordChatRedisMisses(numberOfMessages);
	}

	private void OnConversationRedisHit()
	{
		_ChatMetricsTracker.RecordConversationRedisHits();
	}

	private void OnConversationRedisMiss()
	{
		_ChatMetricsTracker.RecordConversationRedisMisses();
	}

	private void OnParticipantRedisHit()
	{
		_ChatMetricsTracker.RecordParticipantRedisHit();
	}

	private void OnParticipantRedisMiss()
	{
		_ChatMetricsTracker.RecordParticipantRedisMiss();
	}

	private void OnMissingParticipantDetected(long conversationId, long userId)
	{
		ChatEvent eventToPublish = new ChatEvent
		{
			ConversationId = conversationId,
			ChatEventType = ChatEventType.ConversationIncorrectlyListedForUser,
			AffectedUserId = userId
		};
		_ChatEventsPublisher.Publish(eventToPublish);
	}

	private void OnConversationAbandoned(long conversationId)
	{
		ChatEvent eventToPublish = new ChatEvent
		{
			ConversationId = conversationId,
			ChatEventType = ChatEventType.ConversationReadyToBeDeleted
		};
		_ChatEventsPublisher.Publish(eventToPublish);
	}

	private void OnNewMessageSent(IConversationWithParticipants conversation, IPlatform platform, IUser senderUser, IChatMessageEntity chatMessageEntity, IParticipantUtilities participantUtilities)
	{
		IReadOnlyCollection<IParticipant> participantsWithoutSender = GetParticipantsWithoutSenderFromConversation(conversation, senderUser, participantUtilities);
		_ChatMetricsTracker.RecordChatsSent(platform, participantsWithoutSender.Count);
		int notified = _RealtimePublisher.PublishNewMessageNotification(conversation.Id, conversation.ConversationType, participantsWithoutSender);
		_ChatMetricsTracker.RecordChatsNotifiedImmediately(notified);
		_RealtimePublisher.PublishNewSelfMessageNotification(conversation.Id, conversation.ConversationType, senderUser);
		if (chatMessageEntity != null)
		{
			ChatEventMessage chatMessage = _ChatEventParserFactory.GetChatMessageParser(chatMessageEntity.MessageType)?.Translate(chatMessageEntity);
			if (chatMessage != null)
			{
				ChatEvent eventToPublish = new ChatEvent
				{
					ConversationId = conversation.Id,
					ChatEventType = ChatEventType.ConversationReadyToBePersisted,
					Message = chatMessage,
					SenderPlatformType = platform?.PlatformType
				};
				_ChatEventsPublisher.Publish(eventToPublish, Settings.Default.IsDelayedNewMessageEventPublishingEnabled);
			}
		}
		Lazy<IReadOnlyCollection<long>> conversationParticipantUserIds = new Lazy<IReadOnlyCollection<long>>(() => GetUsersFromConversation(conversation));
		_ChatEventStreamer.StreamEvents(senderUser, ChatEventStreamContextType.MessageSent, conversationParticipantUserIds, conversation.Id);
	}

	private void OnMessageMarkedAsRead(long conversationId, IUser readerUser, IChatMessageEntity chatMessageEntity, IParticipantUtilities participantUtilities, Func<IConversationWithParticipants> conversationWithParticipantsGetter)
	{
		if (chatMessageEntity != null)
		{
			ChatEventMessage chatMessage = _ChatEventParserFactory.GetChatMessageParser(chatMessageEntity.MessageType)?.Translate(chatMessageEntity);
			if (chatMessage != null)
			{
				ChatEvent eventToPublish = new ChatEvent
				{
					ConversationId = conversationId,
					ChatEventType = ChatEventType.ConversationMarkedAsRead,
					Message = chatMessage,
					AffectedUserId = readerUser.Id
				};
				_ChatEventsPublisher.Publish(eventToPublish);
				try
				{
					PublishMessageMarkedAsReadNotification(conversationId, readerUser, conversationWithParticipantsGetter);
				}
				catch (Exception ex)
				{
					_Logger.Error($"Error on publishing realtime notification of MessageMarkedAsRead - {ex}");
				}
			}
		}
		Lazy<IReadOnlyCollection<long>> conversationParticipantUserIds = new Lazy<IReadOnlyCollection<long>>(() => GetUsersFromConversation(conversationWithParticipantsGetter?.Invoke()));
		_ChatEventStreamer.StreamEvents(readerUser, ChatEventStreamContextType.MessageMarkedAsRead, conversationParticipantUserIds, conversationId);
	}

	/// <summary>
	/// Publish a <see cref="F:Roblox.Platform.Chat.ChatUpdateNotificationType.MessageMarkedAsRead" /> notification.
	/// </summary>
	/// <param name="conversationId">The conversation id which has been marked as read.</param>
	/// <param name="readerUser">The user who marks the message as read.</param>
	/// <param name="conversationWithParticipantsGetter">The function providing <see cref="T:Roblox.Platform.Chat.IConversationWithParticipants" /></param>
	private void PublishMessageMarkedAsReadNotification(long conversationId, IUser readerUser, Func<IConversationWithParticipants> conversationWithParticipantsGetter)
	{
		if (IsMessageMarkedAsReadNotificationEnabled)
		{
			if (conversationWithParticipantsGetter == null)
			{
				throw new PlatformArgumentNullException("conversationWithParticipantsGetter");
			}
			IConversationWithParticipants conversation = conversationWithParticipantsGetter();
			if (conversation == null)
			{
				throw new PlatformDataIntegrityException($"Failed to get conversation by id {conversationId}.");
			}
			_RealtimePublisher.PublishMessageMarkedAsReadNotification(conversationId, conversation.ConversationType, readerUser);
		}
	}

	private void OnNewConversationCreated(IUser creatorUser, IConversationWithParticipants conversation, IParticipantUtilities participantUtilities)
	{
		_RealtimePublisher.PublishNewConversationNotification(conversation.Id, conversation.ConversationType, (IReadOnlyCollection<IParticipant>)(object)conversation.Participants);
		Lazy<IReadOnlyCollection<long>> conversationParticipantUserIds = new Lazy<IReadOnlyCollection<long>>(() => GetUsersFromConversation(conversation));
		if (creatorUser != null)
		{
			_ChatEventStreamer.StreamEvents(creatorUser, ChatEventStreamContextType.ConversationCreated, conversationParticipantUserIds, conversation.Id);
			_ChatConversationEventsPublisher.Publish(new ChatConversationEvent
			{
				ConversationId = conversation.Id,
				ChatConversationEventType = ChatConversationEventType.NewConversationCreated
			});
		}
	}

	private void OnUsersAddedToConversation(IUser currentUser, IConversationWithParticipants conversation, IReadOnlyCollection<IParticipant> newParticipants, IReadOnlyCollection<IParticipant> existingParticipants, IParticipantUtilities participantUtilities, IPlatform platform)
	{
		_RealtimePublisher.PublishAddedToConversationNotifications(conversation.Id, conversation.ConversationType, newParticipants);
		_RealtimePublisher.PublishNewParticipantsToConversationNotifications(conversation.Id, conversation.ConversationType, existingParticipants);
		Lazy<IReadOnlyCollection<long>> conversationParticipantUserIds = new Lazy<IReadOnlyCollection<long>>(() => GetUsersFromConversation(conversation));
		_ChatEventStreamer.StreamEvents(currentUser, ChatEventStreamContextType.UserAddedToConversation, conversationParticipantUserIds, conversation.Id);
		if (newParticipants != null && newParticipants.Count > 0)
		{
			_ChatConversationEventsPublisher.Publish(new ChatConversationEvent
			{
				ConversationId = conversation.Id,
				ChatConversationEventType = ChatConversationEventType.UsersAddedToConversation,
				AffectedUserIds = newParticipants.Select((IParticipant participant) => participant.TargetId).ToList()
			});
		}
	}

	private void OnConversationTitleChanged(IUser currentUser, long conversationId, ConversationType conversationType, IReadOnlyCollection<IParticipant> participants)
	{
		if (currentUser != null && participants != null && participants.Count > 0)
		{
			_RealtimePublisher.PublishConversationTitleChangedNotification(currentUser.Id, ParticipantType.User.ToString(), conversationId, conversationType, participants);
			_ChatConversationEventsPublisher.Publish(new ChatConversationEvent
			{
				ConversationId = conversationId,
				ChatConversationEventType = ChatConversationEventType.ConversationTitleChanged
			});
		}
	}

	private void OnUsersRemovedFromConversation(IUser currentUser, IConversationWithParticipants conversation, IReadOnlyCollection<IParticipant> removedParticipants, IParticipantUtilities participantUtilities)
	{
		_RealtimePublisher.PublishRemovedParticipantNotifications(conversation.Id, conversation.ConversationType, removedParticipants, (IReadOnlyCollection<IParticipant>)(object)conversation.Participants);
		Lazy<IReadOnlyCollection<long>> conversationParticipantUserIds = new Lazy<IReadOnlyCollection<long>>(() => GetUsersFromConversation(conversation));
		_ChatEventStreamer.StreamEvents(currentUser, ChatEventStreamContextType.UserRemovedFromConversation, conversationParticipantUserIds, conversation.Id);
		if (removedParticipants != null && removedParticipants.Count > 0)
		{
			_ChatConversationEventsPublisher.Publish(new ChatConversationEvent
			{
				ConversationId = conversation.Id,
				ChatConversationEventType = ChatConversationEventType.UsersRemovedFromConversation,
				AffectedUserIds = removedParticipants.Select((IParticipant participant) => participant.TargetId).ToList()
			});
		}
	}

	private void OnUserTypingStatusUpdate(IUser typingUser, bool isTyping, long conversationId, ConversationType conversationType, IReadOnlyCollection<IParticipant> otherParticipants)
	{
		_RealtimePublisher.PublishUserTypingStatusUpdateNotifications(typingUser.Id, isTyping, conversationId, conversationType, otherParticipants);
	}

	private void OnConversationUniverseChanged(IUser currentUser, IConversationWithParticipants conversation, IUniverse universe, IPlatform platform, IParticipantUtilities participantUtilities, DateTime? conversationUniverseChangedDateTime)
	{
		if (universe == null)
		{
			OnConversationUniverseRemoved(currentUser, conversation);
		}
		else
		{
			OnConversationUniverseChanged(currentUser, conversation, universe, platform, conversationUniverseChangedDateTime);
		}
	}

	private void OnConversationUniverseRemoved(IUser currentUser, IConversationWithParticipants conversation)
	{
		_RealtimePublisher.PublishConversationUniverseChanged(conversation.Id, conversation.ConversationType, currentUser.Id, (IReadOnlyCollection<IParticipant>)(object)conversation.Participants, null, null);
		ChatEventStreamContextType contextType = ChatEventStreamContextType.ConversationUniverseRemoved;
		Lazy<IReadOnlyCollection<long>> conversationParticipantUserIds = new Lazy<IReadOnlyCollection<long>>(() => GetUsersFromConversation(conversation));
		_ChatEventStreamer.StreamEvents(currentUser, contextType, conversationParticipantUserIds, conversation.Id);
	}

	private void OnConversationUniverseChanged(IUser currentUser, IConversationWithParticipants conversation, IUniverse universe, IPlatform platform, DateTime? conversationUniverseChangedDateTime)
	{
		long universeId = universe.Id;
		long? rootPlaceId = universe.RootPlaceId;
		_RealtimePublisher.PublishConversationUniverseChanged(conversation.Id, conversation.ConversationType, currentUser.Id, (IReadOnlyCollection<IParticipant>)(object)conversation.Participants, universeId, rootPlaceId);
		PlayTogetherEvent playTogetherEvent = new PlayTogetherEvent
		{
			ActorUserId = currentUser.Id,
			ConversationId = conversation.Id,
			PlayTogetherEventType = PlayTogetherEventType.ConversationUniverseChanged,
			UniverseId = universeId,
			EventDateTime = conversationUniverseChangedDateTime
		};
		_PlayTogetherSnsPublisher.Publish(playTogetherEvent);
		ChatEventStreamContextType contextType = ChatEventStreamContextType.ConversationUniverseChanged;
		Lazy<IReadOnlyCollection<long>> conversationParticipantUserIds = new Lazy<IReadOnlyCollection<long>>(() => GetUsersFromConversation(conversation));
		_ChatEventStreamer.StreamEvents(currentUser, contextType, conversationParticipantUserIds, conversation.Id);
		if (Settings.Default.IsConversationUniverseChangedChatMessageEnabled)
		{
			SendConversationUniverseChangedChatMessage(currentUser, conversation.Id, platform, universeId);
		}
	}

	private void OnNewMessageContentModerated(string chatMessage)
	{
		if (string.IsNullOrEmpty(chatMessage))
		{
			return;
		}
		try
		{
			if (Settings.Default.WhitelistMessageContentCsv.Split(',').Contains(chatMessage.ToLower()))
			{
				_ChatMetricsTracker.RecordWhitelistChatModerated(chatMessage);
			}
		}
		catch (Exception exp)
		{
			_Logger.Error(exp);
		}
	}

	private IReadOnlyCollection<IParticipant> GetParticipantsWithoutSenderFromConversation(IConversationWithParticipants conversation, IUser senderUser, IParticipantUtilities participantUtilities)
	{
		List<IParticipant> participantsWithoutSender = new List<IParticipant>(conversation.Participants.Length);
		IParticipant[] participants = conversation.Participants;
		foreach (IParticipant participant in participants)
		{
			if (!participantUtilities.IsUser(participant) || participant.TargetId != senderUser.Id)
			{
				participantsWithoutSender.Add(participant);
			}
		}
		return participantsWithoutSender;
	}

	private IReadOnlyCollection<long> GetUsersFromConversation(IConversationWithParticipants conversation)
	{
		if (conversation?.Participants == null)
		{
			return new List<long>();
		}
		List<long> users = new List<long>(conversation.Participants.Length);
		IParticipant[] participants = conversation.Participants;
		foreach (IParticipant participant in participants)
		{
			if (participant.IsUser())
			{
				users.Add(participant.TargetId);
			}
		}
		return users;
	}

	private void SendConversationUniverseChangedChatMessage(IUser currentUser, long conversationId, IPlatform platform, long universeId)
	{
		if (currentUser == null)
		{
			throw new PlatformArgumentNullException("currentUser");
		}
		RawChatMessageSource messageSource = new RawChatMessageSource
		{
			SourceType = ChatMessageSourceType.System
		};
		RawSetConversationUniverseEventBasedChatMessage rawChatMessage = new RawSetConversationUniverseEventBasedChatMessage
		{
			ActorUserId = currentUser.Id,
			UniverseId = universeId,
			ChatMessageEventType = ChatMessageEventType.SetConversationUniverse,
			MessageSource = messageSource,
			MessageType = ChatMessageType.EventBased,
			Decorators = _ChatMessageSender.GetValidDecorators(conversationId, null, currentUser.ToParticipant())
		};
		IChatMessageEntity sentMessage = _ChatMessageSender.StoreChatMessage(currentUser, conversationId, platform, rawChatMessage);
		if (sentMessage != null)
		{
			ChatEventMessage chatMessage = _ChatEventParserFactory.GetChatMessageParser(sentMessage.MessageType)?.Translate(sentMessage);
			if (chatMessage != null)
			{
				ChatEvent eventToPublish = new ChatEvent
				{
					ConversationId = conversationId,
					ChatEventType = ChatEventType.ConversationReadyToBePersisted,
					Message = chatMessage,
					SenderPlatformType = platform?.PlatformType
				};
				_ChatEventsPublisher.Publish(eventToPublish, Settings.Default.IsDelayedNewMessageEventPublishingEnabled);
			}
		}
	}
}
