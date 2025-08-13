using System;
using System.Collections.Generic;
using System.Linq;
using Roblox.EventLog;
using Roblox.Platform.Chat.Entities;
using Roblox.Platform.Chat.Properties;
using Roblox.Platform.Core;
using Roblox.Platform.Devices;
using Roblox.Platform.Membership;
using Roblox.Time;

namespace Roblox.Platform.Chat;

public class ChatMessageSender : IChatMessageSender
{
	internal delegate void OnNewMessageSendAttemptedWithoutRealTimeHandler(long conversationId, IPlatform platform, IUser senderUser);

	internal delegate void OnNewMessageSentHandler(IConversationWithParticipants conversation, IPlatform platform, IUser senderUser, IChatMessageEntity message, IParticipantUtilities participantUtilities);

	internal delegate void OnMessageMarkedAsReadHandler(long conversationId, IUser readerUser, IChatMessageEntity message, IParticipantUtilities participantUtilities, Func<IConversationWithParticipants> conversationParticipantsGetter);

	internal delegate void OnNewMessageContentModeratedHandler(string messageContent);

	private readonly ILogger _Logger;

	private readonly IConversationDataAccessor _ConversationDataAccessor;

	private readonly IMessageDataAccessor _MessageDataAccessor;

	private readonly IParticipantUtilities _ParticipantUtilities;

	private readonly IInstantProvider _InstantProvider;

	private readonly ISettings _Settings;

	private readonly IChatMessagePreProcessorFactory _ChatMessagePreProcessorFactory;

	private readonly IChatMessagePostProcessorFactory _ChatMessagePostProcessorFactory;

	private readonly IDecoratorWhitelistValidator _DecoratorWhitelistValidator;

	private readonly IDecoratorValidatorFactory _DecoratorValidatorFactory;

	internal event OnNewMessageSendAttemptedWithoutRealTimeHandler OnNewMessageSendAttemptedWithoutRealTime;

	internal event OnNewMessageSentHandler OnNewMessageSent;

	internal event OnMessageMarkedAsReadHandler OnMessageMarkedAsRead;

	internal event OnNewMessageContentModeratedHandler OnNewMessageContentModerated;

	internal ChatMessageSender(ILogger logger, IConversationDataAccessor conversationDataAccessor, IMessageDataAccessor messageDataAccessor, IParticipantUtilities participantUtilities, IInstantProvider instantProvider, ISettings settings, IChatMessagePreProcessorFactory chatMessagePreProcessorFactory, IChatMessagePostProcessorFactory chatMessagePostProcessorFactory, IDecoratorWhitelistValidator decoratorWhitelistValidator, IDecoratorValidatorFactory decoratorValidatorFactory)
	{
		_Logger = logger ?? throw new PlatformArgumentNullException("logger");
		_ConversationDataAccessor = conversationDataAccessor ?? throw new PlatformArgumentNullException("conversationDataAccessor");
		_MessageDataAccessor = messageDataAccessor ?? throw new PlatformArgumentNullException("messageDataAccessor");
		_ParticipantUtilities = participantUtilities ?? throw new PlatformArgumentNullException("participantUtilities");
		_InstantProvider = instantProvider ?? throw new PlatformArgumentNullException("instantProvider");
		_Settings = settings ?? throw new PlatformArgumentNullException("settings");
		_ChatMessagePreProcessorFactory = chatMessagePreProcessorFactory ?? throw new PlatformArgumentNullException("chatMessagePreProcessorFactory");
		_ChatMessagePostProcessorFactory = chatMessagePostProcessorFactory ?? throw new PlatformArgumentNullException("chatMessagePostProcessorFactory");
		_DecoratorWhitelistValidator = decoratorWhitelistValidator ?? throw new PlatformArgumentNullException("decoratorWhitelistValidator");
		_DecoratorValidatorFactory = decoratorValidatorFactory ?? throw new PlatformArgumentNullException("decoratorValidatorFactory");
	}

	public ISentMessageDetails SendPlainTextChatMessage(IUser senderUser, string rawContent, long conversationId, IPlatform platform, IReadOnlyCollection<string> decorators = null)
	{
		if (senderUser == null)
		{
			throw new PlatformArgumentException(string.Format("{0} cannot be null", "senderUser"));
		}
		RawChatMessageUserSource chatMessageSource = new RawChatMessageUserSource
		{
			SourceUserId = senderUser.Id,
			SourceType = ChatMessageSourceType.User
		};
		RawPlainTextMessage chatMessage = new RawPlainTextMessage
		{
			MessageType = ChatMessageType.PlainText,
			Over13Content = rawContent,
			MessageSource = chatMessageSource,
			Under13Content = null,
			Decorators = decorators
		};
		IRawChatMessage validatedChatMessage;
		IPlaintextMessageByUserValidationData plainTextValidationData = ValidateChatMessage<IPlaintextMessageByUserValidationData>(chatMessage, conversationId, senderUser, out validatedChatMessage);
		ValidateRealtimeConnection(plainTextValidationData, conversationId, platform, senderUser, out var isRealtimeConnected);
		if (!isRealtimeConnected)
		{
			return new SentMessageDetails
			{
				IsMoreStrictlyModeratedForSomeRecipients = false,
				SentMessageFailureType = SentMessageFailureType.NoRealtimeConnection,
				SentMessage = null
			};
		}
		bool isMoreStrictlyModeratedForSomeRecipients = plainTextValidationData.IsMoreStrictlyModeratedForSomeRecipients;
		if (isMoreStrictlyModeratedForSomeRecipients && Settings.Default.IsWhitelistMessageContentModeratedMetricsEnabled)
		{
			this.OnNewMessageContentModerated?.Invoke(rawContent);
		}
		if (!plainTextValidationData.IsAllowedToBeSent)
		{
			return new SentMessageDetails
			{
				IsMoreStrictlyModeratedForSomeRecipients = isMoreStrictlyModeratedForSomeRecipients,
				SentMessageFailureType = SentMessageFailureType.Moderated,
				SentMessage = null
			};
		}
		if (validatedChatMessage == null)
		{
			throw new PlatformException("Could not generate validated chat message for unknown reasons");
		}
		IChatMessage sentMessage = PerformSendMessage(senderUser, conversationId, platform, validatedChatMessage);
		return new SentMessageDetails
		{
			IsMoreStrictlyModeratedForSomeRecipients = isMoreStrictlyModeratedForSomeRecipients,
			SentMessageFailureType = SentMessageFailureType.None,
			SentMessage = sentMessage
		};
	}

	public ISentMessageDetails SendGameLinkChatMessage(IUser senderUser, long conversationId, long universeId, IPlatform platform, IReadOnlyCollection<string> decorators = null)
	{
		if (senderUser == null)
		{
			throw new PlatformArgumentNullException("senderUser");
		}
		RawChatMessageUserSource chatMessageSource = new RawChatMessageUserSource
		{
			SourceUserId = senderUser.Id,
			SourceType = ChatMessageSourceType.User
		};
		RawGameLinkChatMessage chatMessage = new RawGameLinkChatMessage
		{
			ChatMessageLinkType = ChatMessageLinkType.GameLink,
			UniverseId = universeId,
			Decorators = decorators,
			MessageSource = chatMessageSource,
			MessageType = ChatMessageType.Link
		};
		IRawChatMessage validatedChatMessage;
		IChatMessageByUserValidationData chatMessageValidationData = ValidateChatMessage<IChatMessageByUserValidationData>(chatMessage, conversationId, senderUser, out validatedChatMessage);
		if (chatMessageValidationData == null)
		{
			throw new PlatformException("Could not generate validated chat message for unknown reasons");
		}
		ValidateRealtimeConnection(chatMessageValidationData, conversationId, platform, senderUser, out var isRealtimeConnected);
		if (!isRealtimeConnected)
		{
			return new SentMessageDetails
			{
				IsMoreStrictlyModeratedForSomeRecipients = false,
				SentMessageFailureType = SentMessageFailureType.NoRealtimeConnection,
				SentMessage = null
			};
		}
		if (!chatMessageValidationData.IsAllowedToBeSent || validatedChatMessage == null)
		{
			throw new PlatformException("Could not generate validated chat message for unknown reasons");
		}
		IChatMessage sentMessage = PerformSendMessage(senderUser, conversationId, platform, validatedChatMessage);
		return new SentMessageDetails
		{
			IsMoreStrictlyModeratedForSomeRecipients = false,
			SentMessageFailureType = SentMessageFailureType.None,
			SentMessage = sentMessage
		};
	}

	internal IChatMessageEntity StoreChatMessage(IUser actorUser, long conversationId, IPlatform platform, IRawChatMessage rawChatMessage)
	{
		if (rawChatMessage == null)
		{
			throw new PlatformArgumentNullException("rawChatMessage");
		}
		IChatMessageEntity storedMessage = _MessageDataAccessor.StoreMessage(actorUser.Id, conversationId, rawChatMessage);
		if (storedMessage == null)
		{
			return null;
		}
		IParticipant senderParticipant = _ParticipantUtilities.ToParticipant(actorUser);
		IConversationWithParticipants conversation = _ConversationDataAccessor.UpdateConversationForNewMessage(conversationId, senderParticipant);
		try
		{
			this.OnNewMessageSent?.Invoke(conversation, platform, actorUser, storedMessage, _ParticipantUtilities);
		}
		catch (Exception ex2)
		{
			_Logger.Error(ex2);
		}
		try
		{
			_MessageDataAccessor.SetMessageExpiry(conversationId, storedMessage, _Settings.MessageExpirationTimespan);
		}
		catch (Exception ex)
		{
			_Logger.Error(ex);
		}
		return storedMessage;
	}

	private IChatMessage PerformSendMessage(IUser senderUser, long conversationId, IPlatform platform, IRawChatMessage validatedRawChatMessage)
	{
		if (validatedRawChatMessage == null)
		{
			return null;
		}
		IChatMessageEntity sentMessage = StoreChatMessage(senderUser, conversationId, platform, validatedRawChatMessage);
		if (sentMessage == null)
		{
			return null;
		}
		ChatMessageType sentMessageType = sentMessage.MessageType;
		return (_ChatMessagePostProcessorFactory.GetPostProcessor(sentMessageType, ChatMessageSourceType.User) as IChatMessageByUserPostProcessor)?.ProcessMessageForSender(senderUser, sentMessage);
	}

	internal IReadOnlyCollection<string> GetValidDecorators(long conversationId, IReadOnlyCollection<string> decorators, IParticipant senderParticipant)
	{
		if (decorators == null)
		{
			return new List<string>();
		}
		List<string> validDecorators = new List<string>();
		foreach (string decorator in decorators)
		{
			if (_DecoratorWhitelistValidator.IsDecoratorWhitelisted(decorator))
			{
				IDecoratorValidator validator = _DecoratorValidatorFactory.GetDecoratorValidator(decorator);
				if (validator == null || validator.Validate(conversationId, senderParticipant))
				{
					validDecorators.Add(decorator);
				}
			}
		}
		return validDecorators;
	}

	private T ValidateChatMessage<T>(IRawChatMessage chatMessage, long conversationId, IUser senderUser, out IRawChatMessage validatedChatMessage) where T : IChatMessageValidationData
	{
		IChatMessagePreProcessor preProcessor = _ChatMessagePreProcessorFactory.GetPreProcessor(chatMessage.MessageType, ChatMessageSourceType.User);
		if (preProcessor == null)
		{
			throw new PlatformException($"No PreProcessor found for ChatMessageType: {chatMessage.MessageType.ToString()}");
		}
		validatedChatMessage = preProcessor.ValidateChatMessage(chatMessage, conversationId, out var validationData);
		if (validationData == null)
		{
			throw new PlatformException("Chat Message could not be validated");
		}
		if (!(validationData is T expectedTypeValidationData))
		{
			throw new PlatformException("Chat message does not have the right validation data");
		}
		IParticipant senderParticipant = _ParticipantUtilities.ToParticipant(senderUser);
		if (validatedChatMessage != null)
		{
			validatedChatMessage.Decorators = GetValidDecorators(conversationId, chatMessage.Decorators, senderParticipant);
		}
		return expectedTypeValidationData;
	}

	public bool MarkAsRead(IUser currentUser, long conversationId, Guid? endMessageId = null)
	{
		if (currentUser == null)
		{
			throw new PlatformArgumentException(string.Format("{0} cannot be null", "currentUser"));
		}
		IParticipant currentParticipant = _ParticipantUtilities.ToParticipant(currentUser);
		if (!_ConversationDataAccessor.DoesContainParticipant(conversationId, currentParticipant))
		{
			throw new ChatPlatformAuthorizationException($"User:{currentUser.Id} not part of the conversation. Cannot mark message as read.");
		}
		bool success = _ConversationDataAccessor.TryToMarkConversationAsReadForParticipant(conversationId, currentParticipant);
		bool messageMarkedAsRead = true;
		if (success && endMessageId.HasValue)
		{
			messageMarkedAsRead = _MessageDataAccessor.MarkMessageAsRead(currentUser.Id, conversationId, endMessageId.Value);
		}
		if (messageMarkedAsRead)
		{
			try
			{
				IChatMessageEntity message = ((!endMessageId.HasValue) ? _MessageDataAccessor.GetMessages(currentUser.Id, conversationId, null, 1).FirstOrDefault()?.Message : _MessageDataAccessor.Get(conversationId, endMessageId.Value));
				if (message != null)
				{
					this.OnMessageMarkedAsRead?.Invoke(conversationId, currentUser, message, _ParticipantUtilities, () => _ConversationDataAccessor.GetConversationWithParticipants(conversationId));
				}
			}
			catch (Exception ex)
			{
				_Logger.Error(ex);
			}
		}
		return success;
	}

	public void MarkAsSeen(IUser seeingUser, long conversationId)
	{
		if (seeingUser == null)
		{
			throw new PlatformArgumentException(string.Format("{0} cannot be null", "seeingUser"));
		}
		if (!_ConversationDataAccessor.DoesContainParticipant(conversationId, _ParticipantUtilities.ToParticipant(seeingUser)))
		{
			throw new ChatPlatformAuthorizationException($"User: {seeingUser.Id} not part of the conversation. Cannot mark message seen");
		}
		_MessageDataAccessor.MarkConversationAsSeen(seeingUser.Id, conversationId, _InstantProvider.GetCurrentUtcInstant());
	}

	private void ValidateRealtimeConnection(IChatMessageByUserValidationData validationData, long conversationId, IPlatform platform, IUser senderUser, out bool isRealtimeConnected)
	{
		isRealtimeConnected = validationData.IsRealTimeConnected;
		if (!isRealtimeConnected)
		{
			this.OnNewMessageSendAttemptedWithoutRealTime?.Invoke(conversationId, platform, senderUser);
			if (_Settings.IsBlockMessagesFromUsersNotConnectedToRealTimeEnabled)
			{
				throw new SuspectBehaviorException("Users not connected to the RealTime system cannot chat messages");
			}
		}
	}
}
