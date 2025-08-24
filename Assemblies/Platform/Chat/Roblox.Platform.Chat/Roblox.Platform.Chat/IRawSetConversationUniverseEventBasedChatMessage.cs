namespace Roblox.Platform.Chat;

internal interface IRawSetConversationUniverseEventBasedChatMessage : IRawEventBasedChatMessage, IRawChatMessage
{
	long ActorUserId { get; set; }

	long UniverseId { get; set; }
}
