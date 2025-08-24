using Roblox.Platform.Chat.Entities;

namespace Roblox.Platform.Chat;

internal class MessageWithStatus
{
	public IChatMessageEntity Message { get; private set; }

	public MessageStatus Status { get; private set; }

	public MessageWithStatus(IChatMessageEntity message, MessageStatus status)
	{
		Message = message;
		Status = status;
	}
}
