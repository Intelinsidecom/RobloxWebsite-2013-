using System;
using System.Collections.Concurrent;
using Roblox.EventLog;
using Roblox.Platform.Core;
using Roblox.Platform.Membership;
using Roblox.Platform.Universes;
using Roblox.Redis;

namespace Roblox.Platform.Chat;

internal class LinkChatMessageByUserPreProcessor : IChatMessagePreProcessor
{
	private readonly ConcurrentDictionary<ChatMessageLinkType, ILinkChatMessageValidator> _LinkChatMessageValidatorDictionary = new ConcurrentDictionary<ChatMessageLinkType, ILinkChatMessageValidator>();

	private readonly IUserFactory _UserFactory;

	private readonly IConversationDataAccessor _ConversationDataAccessor;

	private readonly IParticipantUtilities _ParticipantUtilities;

	private readonly Predicate<long> _UserHasConnectedToRealTimeRecentlyGetter;

	private readonly ILogger _Logger;

	public LinkChatMessageByUserPreProcessor(IUserFactory userFactory, IUniverseFactory universeFactory, ILogger logger, IRedisClient chatConversationRedisClient, Predicate<long> userHasConnectedToRealTimeRecentlyGetter)
		: this(userFactory, universeFactory, new ParticipantUtilities(userFactory), ConversationDataAccessorFactory.GetConversationDataAccessor(chatConversationRedisClient, logger, universeFactory), userHasConnectedToRealTimeRecentlyGetter, logger)
	{
	}

	internal LinkChatMessageByUserPreProcessor(IUserFactory userFactory, IUniverseFactory universeFactory, IParticipantUtilities participantUtilities, IConversationDataAccessor conversationDataAccessor, Predicate<long> userHasConnectedToRealTimeRecentlyGetter, ILogger logger)
	{
		_LinkChatMessageValidatorDictionary.TryAdd(ChatMessageLinkType.GameLink, new GameLinkChatMessageValidator(universeFactory));
		_UserFactory = userFactory ?? throw new PlatformArgumentNullException("userFactory");
		_ParticipantUtilities = participantUtilities ?? throw new PlatformArgumentNullException("participantUtilities");
		_ConversationDataAccessor = conversationDataAccessor ?? throw new PlatformArgumentNullException("conversationDataAccessor");
		_UserHasConnectedToRealTimeRecentlyGetter = userHasConnectedToRealTimeRecentlyGetter ?? throw new PlatformArgumentNullException("userHasConnectedToRealTimeRecentlyGetter");
		_Logger = logger ?? throw new PlatformArgumentNullException("logger");
	}

	public IRawChatMessage ValidateChatMessage(IRawChatMessage rawChatMessage, long conversationId, out IChatMessageValidationData validationResults)
	{
		if (rawChatMessage == null)
		{
			throw new PlatformArgumentNullException("rawChatMessage");
		}
		if (!(rawChatMessage is IRawLinkChatMessage rawLinkChatMessage))
		{
			throw new PlatformArgumentException(string.Format("Chat Message with Message type : {0} cannot be castes to {1}", rawChatMessage.MessageType, "IRawLinkChatMessage"));
		}
		if (rawChatMessage.MessageSource == null)
		{
			throw new PlatformArgumentException("Cannot send a link card message without a message source");
		}
		IRawChatMessageUserSource obj = (rawChatMessage.MessageSource as IRawChatMessageUserSource) ?? throw new PlatformArgumentException(string.Format("Chat Message with source type : {0} cannot be casted to {1}", rawChatMessage.MessageSource.SourceType, "IChatMessageUserSource"));
		if (_ConversationDataAccessor.GetConversationWithParticipants(conversationId) == null)
		{
			throw new PlatformArgumentException("Specified conversation does not exist");
		}
		long userId = obj.SourceUserId;
		IUser user = _UserFactory.GetUser(userId);
		if (user == null)
		{
			throw new PlatformArgumentException($"Message source User does not exists, UserId : {userId}");
		}
		IParticipant senderParticipant = _ParticipantUtilities.ToParticipant(user);
		if (!_ConversationDataAccessor.DoesContainParticipant(conversationId, senderParticipant))
		{
			throw new ChatPlatformAuthorizationException($"User:{user.Id} not part of the conversation. Cannot send message.");
		}
		if (!IsRealTimeConnected(user))
		{
			validationResults = new ChatMessageByUserValidationData
			{
				IsAllowedToBeSent = false,
				IsRealTimeConnected = false
			};
			return null;
		}
		if (!_LinkChatMessageValidatorDictionary.TryGetValue(rawLinkChatMessage.ChatMessageLinkType, out var linkValidator))
		{
			validationResults = new ChatMessageByUserValidationData
			{
				IsAllowedToBeSent = true,
				IsRealTimeConnected = true
			};
			return rawChatMessage;
		}
		validationResults = new ChatMessageByUserValidationData
		{
			IsAllowedToBeSent = (linkValidator.ValidateLinkChatMessage(rawLinkChatMessage)?.IsAllowedToBeSent ?? false),
			IsRealTimeConnected = true
		};
		return rawChatMessage;
	}

	private bool IsRealTimeConnected(IUser senderUser)
	{
		bool isRealTimeConnected = false;
		try
		{
			isRealTimeConnected = _UserHasConnectedToRealTimeRecentlyGetter(senderUser.Id);
		}
		catch (Exception ex)
		{
			_Logger.Error(ex);
		}
		return isRealTimeConnected;
	}
}
