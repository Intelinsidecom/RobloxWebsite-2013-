using Roblox.Platform.Chat.Entities;
using Roblox.Platform.Core;
using Roblox.Platform.Membership;

namespace Roblox.Platform.Chat;

internal class EventBasedChatMessageBySystemPostProcessor : IChatMessagePostProcessor
{
	private readonly IEventBasedChatMessageTranslatorFactory _EventBasedChatMessageTranslatorFactory;

	internal EventBasedChatMessageBySystemPostProcessor()
		: this(new EventBasedChatMessageTranslatorFactory())
	{
	}

	public EventBasedChatMessageBySystemPostProcessor(IEventBasedChatMessageTranslatorFactory eventBasedChatMessageTranslatorFactory)
	{
		_EventBasedChatMessageTranslatorFactory = eventBasedChatMessageTranslatorFactory ?? throw new PlatformArgumentNullException("eventBasedChatMessageTranslatorFactory");
	}

	public IChatMessage ProcessMessageForRecipient(IUser viewingUser, IChatMessageEntity chatMessageEntity, MessageStatus status, long conversationId)
	{
		if (viewingUser == null)
		{
			throw new PlatformArgumentNullException("viewingUser");
		}
		if (chatMessageEntity == null)
		{
			throw new PlatformArgumentNullException("chatMessageEntity");
		}
		if (!(chatMessageEntity is IEventBasedChatMessageEntity eventBasedChatMessageEntity))
		{
			throw new PlatformArgumentException(string.Format("{0} should be of type ${1}", "chatMessageEntity", typeof(IEventBasedChatMessageEntity)));
		}
		IChatMessageSourceEntity chatMessageSourceEntity = chatMessageEntity.ChatMessageSourceEntity;
		if (chatMessageSourceEntity == null)
		{
			throw new PlatformArgumentNullException("ChatMessageSourceEntity");
		}
		bool hasMessageBeenRead = status == MessageStatus.Read;
		IEventBasedChatMessage obj = _EventBasedChatMessageTranslatorFactory.GetTranslator(eventBasedChatMessageEntity.ChatMessageEventType)?.Translate(eventBasedChatMessageEntity) ?? new EventBasedChatMessage();
		obj.Id = eventBasedChatMessageEntity.UniqueId;
		obj.Read = hasMessageBeenRead;
		obj.MessageSource = new ChatMessageSource
		{
			SourceType = chatMessageSourceEntity.SourceType
		};
		obj.Sent = eventBasedChatMessageEntity.Sent;
		obj.MessageType = eventBasedChatMessageEntity.MessageType;
		obj.Decorators = eventBasedChatMessageEntity.Decorators;
		obj.ChatMessageEventType = eventBasedChatMessageEntity.ChatMessageEventType;
		return obj;
	}
}
