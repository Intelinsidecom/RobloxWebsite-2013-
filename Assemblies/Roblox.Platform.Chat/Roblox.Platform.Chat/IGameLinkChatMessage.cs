namespace Roblox.Platform.Chat;

public interface IGameLinkChatMessage : ILinkChatMessage, IChatMessage
{
	long UniverseId { get; set; }
}
