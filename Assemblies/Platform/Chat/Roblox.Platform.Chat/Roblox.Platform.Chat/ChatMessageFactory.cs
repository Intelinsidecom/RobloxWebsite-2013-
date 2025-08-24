using System;
using System.Collections.Generic;
using System.Linq;
using Amazon.DynamoDBv2;
using Roblox.EventLog;
using Roblox.Platform.Chat.Entities;
using Roblox.Platform.Chat.Properties;
using Roblox.Platform.Core;
using Roblox.Platform.Membership;
using Roblox.Platform.Universes;
using Roblox.TextFilter.Client;
using Roblox.Time;

namespace Roblox.Platform.Chat;

public class ChatMessageFactory : IChatMessageFactory
{
	private readonly IConversationDataAccessor _ConversationDataAccessor;

	private readonly IMessageDataAccessor _MessageDataAccessor;

	private readonly IChatMessagePostProcessorFactory _ChatMessagePostProcessorFactory;

	private readonly IInstantProvider _InstantProvider;

	private readonly ISettings _Settings;

	public ChatMessageFactory(IChatRedisClients chatRedisClients, IAmazonDynamoDB dynamoDbClient, IUserFactory userFactory, ITextFilterClientV2 textFilterClientV2, ILogger logger, IUniverseFactory universeFactory)
		: this(new InstantProvider(), Settings.Default, ConversationDataAccessorFactory.GetConversationDataAccessor(chatRedisClients.ChatConversationRedisClient, logger, universeFactory), MessageDataAccessorFactory.GetMessageDataAccessor(chatRedisClients, dynamoDbClient, logger, new InstantProvider()), new ChatMessagePostProcessorFactory(new ChatMessageRemediator(ConversationDataAccessorFactory.GetConversationDataAccessor(chatRedisClients.ChatConversationRedisClient, logger, universeFactory), MessageDataAccessorFactory.GetMessageDataAccessor(chatRedisClients, dynamoDbClient, logger, new InstantProvider()), new ContentValidator(new ContentValidationRules(new ParticipantUtilities(userFactory)), textFilterClientV2, new ParticipantUtilities(userFactory)), userFactory, new ParticipantUtilities(userFactory), logger, Settings.Default)))
	{
	}

	internal ChatMessageFactory(IInstantProvider instantProvider, ISettings settings, IConversationDataAccessor conversationDataAccessor, IMessageDataAccessor messageDataAccessor, IChatMessagePostProcessorFactory chatMessagePostProcessorFactory)
	{
		_InstantProvider = instantProvider ?? throw new PlatformArgumentNullException("instantProvider");
		_Settings = settings ?? throw new PlatformArgumentNullException("settings");
		_ConversationDataAccessor = conversationDataAccessor;
		_MessageDataAccessor = messageDataAccessor;
		_ChatMessagePostProcessorFactory = chatMessagePostProcessorFactory;
	}

	public IReadOnlyCollection<IChatMessage> GetMessages(IUser user, long conversationId, Guid? exclusiveStartMessageId, int maxRows)
	{
		if (user == null)
		{
			throw new PlatformArgumentNullException("User cannot be null");
		}
		if (!_ConversationDataAccessor.DoesContainParticipant(conversationId, user.ToParticipant()))
		{
			throw new ChatPlatformAuthorizationException($"User:{user.Id} not part of the conversation. Cannot get messages.");
		}
		IReadOnlyCollection<MessageWithStatus> messages = _MessageDataAccessor.GetMessages(user.Id, conversationId, exclusiveStartMessageId, maxRows);
		return FilterAndEnhanceMessages(messages, user, getOnlyUnreadMessages: false, conversationId);
	}

	public IChatMessage GetMessage(IUser user, long conversationId, Guid messageId)
	{
		if (user == null)
		{
			throw new PlatformArgumentNullException("User cannot be null");
		}
		if (!_ConversationDataAccessor.DoesContainParticipant(conversationId, user.ToParticipant()))
		{
			throw new ChatPlatformAuthorizationException($"User:{user.Id} not part of the conversation. Cannot get messages.");
		}
		MessageWithStatus message = _MessageDataAccessor.GetWithStatus(user.Id, conversationId, messageId);
		return FilterAndEnhanceMessages(new List<MessageWithStatus> { message }, user, getOnlyUnreadMessages: false, conversationId).FirstOrDefault();
	}

	public IReadOnlyCollection<IChatMessage> GetUnreadMessages(IUser user, long conversationId, int maxRows)
	{
		if (user == null)
		{
			throw new PlatformArgumentNullException("User cannot be null");
		}
		if (!_ConversationDataAccessor.DoesContainParticipant(conversationId, user.ToParticipant()))
		{
			throw new ChatPlatformAuthorizationException($"User:{user.Id} not part of the conversation. Cannot retrieve unread messages.");
		}
		IReadOnlyCollection<MessageWithStatus> messages = _MessageDataAccessor.GetUnreadMessages(user.Id, conversationId, maxRows);
		return FilterAndEnhanceMessages(messages, user, getOnlyUnreadMessages: true, conversationId);
	}

	public bool IsConversationSeen(IUser user, long conversationId, UtcInstant timeSeen)
	{
		if (user == null)
		{
			throw new PlatformArgumentNullException("User cannot be null");
		}
		if (!_ConversationDataAccessor.DoesContainParticipant(conversationId, user.ToParticipant()))
		{
			throw new ChatPlatformAuthorizationException($"User:{user.Id} not part of the conversation. Cannot retrieve seen messages.");
		}
		return _MessageDataAccessor.IsConversationSeen(user.Id, conversationId, timeSeen);
	}

	public bool IsActiveChatUser(IUser user)
	{
		if (user == null)
		{
			return false;
		}
		long currentTimeStampTicks = _InstantProvider.GetCurrentUtcInstant().Ticks;
		long lastSentMessageTimeStampTicks = _MessageDataAccessor.GetLastSentMessageTimeStampTicks(user.Id);
		if (lastSentMessageTimeStampTicks > 0)
		{
			return currentTimeStampTicks <= new DateTime(lastSentMessageTimeStampTicks, DateTimeKind.Utc).Add(_Settings.ChatMessageSentRecentTimeSpan).Ticks;
		}
		return currentTimeStampTicks <= user.Created.ToUniversalTime().Add(_Settings.ChatMessageSentRecentTimeSpan).Ticks;
	}

	/// <summary>
	/// Filter and transform the messages and mark them as read/unread based on the authorship of the message
	/// </summary>
	/// <param name="messages"></param>
	/// <param name="viewingUser"></param>
	/// <param name="getOnlyUnreadMessages">getOnlyUnreadMessages is used to counteract the race conditions present while marking messages as read in the entity layer</param>
	/// <param name="conversationId"></param>
	/// <returns></returns>
	internal IReadOnlyCollection<IChatMessage> FilterAndEnhanceMessages(IReadOnlyCollection<MessageWithStatus> messages, IUser viewingUser, bool getOnlyUnreadMessages, long conversationId)
	{
		if (messages == null)
		{
			return null;
		}
		List<IChatMessage> translatedChatMessages = new List<IChatMessage>(messages.Count);
		foreach (MessageWithStatus sortedMessage in messages)
		{
			IChatMessageEntity message = sortedMessage.Message;
			IChatMessageSourceEntity chatMessageSource = message?.ChatMessageSourceEntity;
			if (chatMessageSource == null)
			{
				continue;
			}
			ChatMessageType messageType = message.MessageType;
			ChatMessageSourceType sourceType = chatMessageSource.SourceType;
			IChatMessagePostProcessor postProcessor = _ChatMessagePostProcessorFactory.GetPostProcessor(messageType, sourceType);
			if (postProcessor != null)
			{
				if (getOnlyUnreadMessages && viewingUser.IsUserSameAsMessageSource(chatMessageSource))
				{
					break;
				}
				IChatMessage processedMessage = postProcessor.ProcessMessageForRecipient(viewingUser, message, sortedMessage.Status, conversationId);
				if (processedMessage != null)
				{
					translatedChatMessages.Add(processedMessage);
				}
			}
		}
		return translatedChatMessages;
	}
}
