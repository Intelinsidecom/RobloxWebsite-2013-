using System.Collections.Concurrent;
using Roblox.Platform.Chat.Entities;
using Roblox.Platform.Core;
using Roblox.Platform.Membership;

namespace Roblox.Platform.Chat;

internal class LinkChatMessageByUserPostProcessor : IChatMessageByUserPostProcessor, IChatMessagePostProcessor
{
	private readonly ConcurrentDictionary<ChatMessageLinkType, ILinkChatMessageTranslator> _LinkChatMessageTranslatorDictionary = new ConcurrentDictionary<ChatMessageLinkType, ILinkChatMessageTranslator>();

	public LinkChatMessageByUserPostProcessor()
	{
		_LinkChatMessageTranslatorDictionary.TryAdd(ChatMessageLinkType.GameLink, new GameLinkChatMessageTranslator());
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
		if (!(chatMessageEntity is ILinkChatMessageEntity linkChatMessageEntity))
		{
			throw new PlatformArgumentException(string.Format("{0} should be of type ${1}", "chatMessageEntity", typeof(ILinkChatMessageEntity)));
		}
		if (!((chatMessageEntity.ChatMessageSourceEntity ?? throw new PlatformArgumentNullException("ChatMessageSourceEntity")) is IChatMessageUserSourceEntity chatMessageUserSourceEntity))
		{
			throw new PlatformArgumentException(string.Format("{0} should be of type ${1}", "chatMessageSourceEntity", typeof(IChatMessageUserSourceEntity)));
		}
		bool hasMessageBeenRead = viewingUser.Id == chatMessageUserSourceEntity.SourceUserId || status == MessageStatus.Read;
		_LinkChatMessageTranslatorDictionary.TryGetValue(linkChatMessageEntity.ChatMessageLinkType, out var linkChatMessageTranslator);
		ILinkChatMessage obj = linkChatMessageTranslator?.Translate(linkChatMessageEntity) ?? new LinkChatMessage();
		obj.Id = linkChatMessageEntity.UniqueId;
		obj.Read = hasMessageBeenRead;
		obj.MessageSource = new ChatMessageUserSource
		{
			SourceType = chatMessageUserSourceEntity.SourceType,
			SourceUserId = chatMessageUserSourceEntity.SourceUserId
		};
		obj.Sent = linkChatMessageEntity.Sent;
		obj.MessageType = linkChatMessageEntity.MessageType;
		obj.Decorators = linkChatMessageEntity.Decorators;
		obj.ChatMessageLinkType = linkChatMessageEntity.ChatMessageLinkType;
		return obj;
	}

	public IChatMessage ProcessMessageForSender(IUser senderUser, IChatMessageEntity chatMessageEntity)
	{
		if (chatMessageEntity == null)
		{
			throw new PlatformArgumentNullException("chatMessageEntity");
		}
		if (!(chatMessageEntity is ILinkChatMessageEntity linkChatMessageEntity))
		{
			throw new PlatformArgumentException(string.Format("{0} should be of type : {1}", "chatMessageEntity", typeof(ILinkChatMessageEntity)));
		}
		_LinkChatMessageTranslatorDictionary.TryGetValue(linkChatMessageEntity.ChatMessageLinkType, out var linkChatMessageTranslator);
		ILinkChatMessage obj = linkChatMessageTranslator?.Translate(linkChatMessageEntity) ?? new LinkChatMessage();
		obj.Id = linkChatMessageEntity.UniqueId;
		obj.Read = false;
		obj.Sent = linkChatMessageEntity.Sent;
		obj.Decorators = linkChatMessageEntity.Decorators;
		obj.ChatMessageLinkType = linkChatMessageEntity.ChatMessageLinkType;
		return obj;
	}
}
