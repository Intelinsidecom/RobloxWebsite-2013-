using Roblox.Platform.Chat.Entities;
using Roblox.Platform.Chat.Events;

namespace Roblox.Platform.Chat;

internal interface IChatEventChatMessageSourceParser
{
	ChatEventMessageSource Translate(IChatMessageSourceEntity chatMessageSourceEntity);

	IChatMessageSourceEntity Translate(IChatEventMessageSource chatEventMessageSource);
}
