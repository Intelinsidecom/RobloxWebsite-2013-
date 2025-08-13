namespace Roblox.Platform.Chat;

public interface ISetConversationUniverseEventBasedChatMessage : IEventBasedChatMessage, IChatMessage
{
	long ActorUserId { get; set; }

	long UniverseId { get; set; }
}
