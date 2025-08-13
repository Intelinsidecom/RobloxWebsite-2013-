namespace Roblox.Platform.Chat;

public interface IEventBasedChatMessage : IChatMessage
{
	ChatMessageEventType ChatMessageEventType { get; set; }
}
