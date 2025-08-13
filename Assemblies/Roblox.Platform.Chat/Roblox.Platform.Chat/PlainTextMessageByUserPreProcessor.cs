using System;
using Roblox.EventLog;
using Roblox.Platform.Core;
using Roblox.Platform.Membership;
using Roblox.Platform.Universes;
using Roblox.Redis;
using Roblox.TextFilter.Client;

namespace Roblox.Platform.Chat;

internal class PlainTextMessageByUserPreProcessor : IChatMessagePreProcessor
{
	private readonly ILogger _Logger;

	private readonly IParticipantUtilities _ParticipantUtilities;

	private readonly IConversationDataAccessor _ConversationDataAccessor;

	private readonly Predicate<long> _UserHasConnectedToRealTimeRecentlyGetter;

	private readonly IUserFactory _UserFactory;

	private readonly IContentValidator _ContentValidator;

	internal PlainTextMessageByUserPreProcessor(ILogger logger, IRedisClient chatConversationRedisClient, IUniverseFactory universeFactory, Predicate<long> userHasConnectedToRealTimeRecentlyGetter, IUserFactory userFactory, ITextFilterClientV2 textFilterClientV2)
		: this(logger, userHasConnectedToRealTimeRecentlyGetter, userFactory, new ParticipantUtilities(userFactory), new ContentValidator(new ContentValidationRules(new ParticipantUtilities(userFactory)), textFilterClientV2, new ParticipantUtilities(userFactory)), ConversationDataAccessorFactory.GetConversationDataAccessor(chatConversationRedisClient, logger, universeFactory))
	{
	}

	internal PlainTextMessageByUserPreProcessor(ILogger logger, Predicate<long> userHasConnectedToRealTimeRecentlyGetter, IUserFactory userFactory, IParticipantUtilities participantUtilities, IContentValidator contentValidator, IConversationDataAccessor conversationDataAccessor)
	{
		_Logger = logger ?? throw new PlatformArgumentNullException("logger");
		_UserHasConnectedToRealTimeRecentlyGetter = userHasConnectedToRealTimeRecentlyGetter ?? throw new PlatformArgumentNullException("userHasConnectedToRealTimeRecentlyGetter");
		_UserFactory = userFactory ?? throw new PlatformArgumentNullException("userFactory");
		_ParticipantUtilities = participantUtilities ?? throw new PlatformArgumentNullException("participantUtilities");
		_ContentValidator = contentValidator ?? throw new PlatformArgumentNullException("contentValidator");
		_ConversationDataAccessor = conversationDataAccessor ?? throw new PlatformArgumentNullException("conversationDataAccessor");
	}

	public IRawChatMessage ValidateChatMessage(IRawChatMessage rawChatMessage, long conversationId, out IChatMessageValidationData validationData)
	{
		if (rawChatMessage == null)
		{
			throw new PlatformArgumentNullException("rawChatMessage");
		}
		if (!(rawChatMessage is IRawPlainTextMessage plainTextMessage))
		{
			throw new PlatformArgumentException(string.Format("{0} needs to be a plainTextMessage", "rawChatMessage"));
		}
		if (!((rawChatMessage.MessageSource ?? throw new PlatformArgumentNullException("chatMessageSource")) is IRawChatMessageUserSource chatMessageUserSource))
		{
			throw new PlatformArgumentException(string.Format("{0} needs to be a user", "chatMessageUserSource"));
		}
		if (string.IsNullOrWhiteSpace(plainTextMessage.Over13Content))
		{
			throw new PlatformArgumentException(string.Format("{0} cannot be null or empty", "Over13Content"));
		}
		IConversationWithParticipants conversation = _ConversationDataAccessor.GetConversationWithParticipants(conversationId);
		if (conversation == null)
		{
			throw new PlatformArgumentException("specified conversation does not exist");
		}
		IUser senderUser = _UserFactory.GetUser(chatMessageUserSource.SourceUserId);
		if (senderUser == null)
		{
			throw new PlatformArgumentNullException("senderUser");
		}
		IParticipant senderParticipant = _ParticipantUtilities.ToParticipant(senderUser);
		if (!_ConversationDataAccessor.DoesContainParticipant(conversationId, senderParticipant))
		{
			throw new ChatPlatformAuthorizationException($"User:{senderUser.Id} not part of the conversation. Cannot send message.");
		}
		if (!IsRealTimeConnected(senderUser))
		{
			validationData = new PlainTextMessageByUserValidationData
			{
				IsAllowedToBeSent = false,
				IsMoreStrictlyModeratedForSomeRecipients = false,
				IsRealTimeConnected = false
			};
			return null;
		}
		IMessageContentValidationResult result = _ContentValidator.Validate(senderParticipant, conversation, ChatContentType.Message, plainTextMessage.Over13Content);
		validationData = new PlainTextMessageByUserValidationData
		{
			IsAllowedToBeSent = result.IsAllowedToBeSent,
			IsMoreStrictlyModeratedForSomeRecipients = result.IsMoreStrictlyModeratedForSomeRecipients,
			IsRealTimeConnected = true
		};
		if (result.IsAllowedToBeSent)
		{
			return new RawPlainTextMessage
			{
				Over13Content = result.Over13Content,
				Under13Content = result.Under13Content,
				MessageSource = rawChatMessage.MessageSource,
				MessageType = ChatMessageType.PlainText,
				Decorators = rawChatMessage.Decorators
			};
		}
		return null;
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
