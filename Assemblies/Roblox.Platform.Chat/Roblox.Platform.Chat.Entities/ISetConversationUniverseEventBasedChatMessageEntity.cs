namespace Roblox.Platform.Chat.Entities;

internal interface ISetConversationUniverseEventBasedChatMessageEntity : IEventBasedChatMessageEntity, IChatMessageEntity
{
	long ActorUserId { get; set; }

	long UniverseId { get; set; }
}
