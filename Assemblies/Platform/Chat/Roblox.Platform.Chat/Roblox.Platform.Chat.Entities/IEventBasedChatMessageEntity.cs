namespace Roblox.Platform.Chat.Entities;

internal interface IEventBasedChatMessageEntity : IChatMessageEntity
{
	ChatMessageEventType ChatMessageEventType { get; set; }
}
