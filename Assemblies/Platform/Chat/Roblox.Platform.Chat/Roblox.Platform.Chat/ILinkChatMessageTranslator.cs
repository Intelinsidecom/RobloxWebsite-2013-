using Roblox.Platform.Chat.Entities;

namespace Roblox.Platform.Chat;

internal interface ILinkChatMessageTranslator
{
	ILinkChatMessage Translate(ILinkChatMessageEntity linkChatMessageEntity);
}
