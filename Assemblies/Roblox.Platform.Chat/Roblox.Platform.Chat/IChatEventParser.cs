using Roblox.Platform.Chat.Entities;
using Roblox.Platform.Chat.Events;

namespace Roblox.Platform.Chat;

internal interface IChatEventParser
{
	ChatEventMessage Translate(IChatMessageEntity chatMessageEntity);

	IChatMessageEntity Translate(IChatEventMessage chatEventMessage);
}
