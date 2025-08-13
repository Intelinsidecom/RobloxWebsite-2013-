namespace Roblox.Platform.Chat;

public interface ILinkChatMessage : IChatMessage
{
	ChatMessageLinkType ChatMessageLinkType { get; set; }
}
