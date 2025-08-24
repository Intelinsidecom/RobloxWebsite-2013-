using Roblox.Platform.Chat.Entities;

namespace Roblox.Platform.Chat;

internal interface IEventBasedChatMessageTranslator
{
	IEventBasedChatMessage Translate(IEventBasedChatMessageEntity eventBasedChatMessageEntity);
}
