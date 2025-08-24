namespace Roblox.Platform.Chat;

internal interface IRawEventBasedChatMessage : IRawChatMessage
{
	ChatMessageEventType ChatMessageEventType { get; set; }
}
