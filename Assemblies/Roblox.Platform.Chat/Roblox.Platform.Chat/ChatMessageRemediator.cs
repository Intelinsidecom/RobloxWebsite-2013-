using System;
using Roblox.EventLog;
using Roblox.Platform.Chat.Entities;
using Roblox.Platform.Chat.Properties;
using Roblox.Platform.Core;
using Roblox.Platform.Membership;

namespace Roblox.Platform.Chat;

internal class ChatMessageRemediator : IChatMessageRemediator
{
	private readonly IConversationDataAccessor _ConversationDataAccessor;

	private readonly IMessageDataAccessor _MessageDataAccessor;

	private readonly IContentValidator _ContentValidator;

	private readonly IUserFactory _UserFactory;

	private readonly IParticipantUtilities _ParticipantUtilities;

	private readonly ILogger _Logger;

	private readonly ISettings _Settings;

	public ChatMessageRemediator(IConversationDataAccessor conversationDataAccessor, IMessageDataAccessor messageDataAccessor, IContentValidator contentValidator, IUserFactory userFactory, IParticipantUtilities participantUtilities, ILogger logger, ISettings settings)
	{
		_ConversationDataAccessor = conversationDataAccessor;
		_MessageDataAccessor = messageDataAccessor;
		_ContentValidator = contentValidator;
		_UserFactory = userFactory;
		_ParticipantUtilities = participantUtilities;
		_Logger = logger;
		_Settings = settings;
	}

	public IChatMessageEntity AddUnder13VersionOfContent(IPlainTextMessageEntity message, long conversationId)
	{
		try
		{
			if (!(message.ChatMessageSourceEntity is IChatMessageUserSourceEntity chatMessageUserSourceEntity))
			{
				throw new PlatformException("Cannot add under13 version to messages not sent by user");
			}
			IConversationWithParticipants conversation = _ConversationDataAccessor.GetConversationWithParticipants(conversationId);
			IUser senderUser = _UserFactory.GetUser(chatMessageUserSourceEntity.SourceUserId);
			IParticipant senderParticipant = _ParticipantUtilities.ToParticipant(senderUser);
			IMessageContentValidationResult revalidatedContent = _ContentValidator.Validate(senderParticipant, conversation, ChatContentType.Message, message.Over13Content, isRevalidation: true);
			message.Under13Content = revalidatedContent.Under13Content;
			_MessageDataAccessor.SaveMessage(conversationId, message);
		}
		catch (Exception exception)
		{
			_Logger.Error(exception);
		}
		message.Under13Content = ((!string.IsNullOrEmpty(message.Under13Content)) ? message.Under13Content : _Settings.FallbackTextForUnavailableUnder13Content);
		return message;
	}
}
