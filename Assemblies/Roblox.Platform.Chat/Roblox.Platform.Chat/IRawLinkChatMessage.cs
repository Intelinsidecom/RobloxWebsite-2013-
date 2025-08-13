namespace Roblox.Platform.Chat;

internal interface IRawLinkChatMessage : IRawChatMessage
{
	ChatMessageLinkType ChatMessageLinkType { get; set; }
}
