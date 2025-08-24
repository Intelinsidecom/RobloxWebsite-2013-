using Roblox.Platform.Chat.Events;
using Roblox.Platform.Devices;

namespace Roblox.Platform.Chat;

public interface IMessagePersister
{
	void Persist(long conversationId, ChatEventMessage chatEventMessage, PlatformType? senderPlatformType);
}
