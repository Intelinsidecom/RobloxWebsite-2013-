using Roblox.Platform.Chat.Entities;
using Roblox.Platform.Core;
using Roblox.Platform.Membership;

namespace Roblox.Platform.Chat;

internal class PlainTextMessageByUserPostProcessor : IChatMessageByUserPostProcessor, IChatMessagePostProcessor
{
	private readonly IChatMessageRemediator _ChatMessageRemediator;

	public PlainTextMessageByUserPostProcessor(IChatMessageRemediator chatMessageRemediator)
	{
		_ChatMessageRemediator = chatMessageRemediator ?? throw new PlatformArgumentNullException("chatMessageRemediator");
	}

	public IChatMessage ProcessMessageForSender(IUser senderUser, IChatMessageEntity chatMessageEntity)
	{
		if (chatMessageEntity == null)
		{
			throw new PlatformArgumentNullException("chatMessageEntity");
		}
		if (!(chatMessageEntity is IPlainTextMessageEntity plainTextChatMessageEntity))
		{
			throw new PlatformArgumentException(string.Format("{0} should be of type : {1}", "chatMessageEntity", typeof(IPlainTextMessageEntity)));
		}
		string contentForViewer = ((senderUser == null || senderUser.IsUnder13()) ? plainTextChatMessageEntity.Under13Content : plainTextChatMessageEntity.Over13Content);
		return new PlainTextChatMessage
		{
			ContentForViewer = contentForViewer,
			Id = plainTextChatMessageEntity.UniqueId,
			Read = false,
			Sent = plainTextChatMessageEntity.Sent,
			Decorators = plainTextChatMessageEntity.Decorators
		};
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
		if (!(chatMessageEntity is IPlainTextMessageEntity plainTextChatMessageEntity))
		{
			throw new PlatformArgumentException(string.Format("{0} should be of type ${1}", "chatMessageEntity", typeof(IPlainTextMessageEntity)));
		}
		if (!((chatMessageEntity.ChatMessageSourceEntity ?? throw new PlatformArgumentNullException("ChatMessageSourceEntity")) is IChatMessageUserSourceEntity chatMessageUserSourceEntity))
		{
			throw new PlatformArgumentException(string.Format("{0} should be of type ${1}", "chatMessageSourceEntity", typeof(IChatMessageUserSourceEntity)));
		}
		bool hasMessageBeenRead = viewingUser.Id == chatMessageUserSourceEntity.SourceUserId || status == MessageStatus.Read;
		if (viewingUser.IsUnder13() && string.IsNullOrEmpty(plainTextChatMessageEntity.Under13Content))
		{
			plainTextChatMessageEntity = _ChatMessageRemediator.AddUnder13VersionOfContent(plainTextChatMessageEntity, conversationId) as IPlainTextMessageEntity;
		}
		if (plainTextChatMessageEntity == null)
		{
			return null;
		}
		return new PlainTextChatMessage
		{
			Id = plainTextChatMessageEntity.UniqueId,
			ContentForViewer = (viewingUser.IsUnder13() ? plainTextChatMessageEntity.Under13Content : plainTextChatMessageEntity.Over13Content),
			Read = hasMessageBeenRead,
			MessageSource = new ChatMessageUserSource
			{
				SourceType = chatMessageUserSourceEntity.SourceType,
				SourceUserId = chatMessageUserSourceEntity.SourceUserId
			},
			Sent = plainTextChatMessageEntity.Sent,
			MessageType = plainTextChatMessageEntity.MessageType,
			Decorators = plainTextChatMessageEntity.Decorators
		};
	}
}
