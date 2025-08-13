namespace Roblox.Platform.Chat.Entities;

internal interface ILinkChatMessageEntity : IChatMessageEntity
{
	ChatMessageLinkType ChatMessageLinkType { get; set; }
}
