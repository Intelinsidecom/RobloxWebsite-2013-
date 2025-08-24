namespace Roblox.Platform.Chat;

internal interface IRawGameLinkChatMessage : IRawLinkChatMessage, IRawChatMessage
{
	long UniverseId { get; set; }
}
