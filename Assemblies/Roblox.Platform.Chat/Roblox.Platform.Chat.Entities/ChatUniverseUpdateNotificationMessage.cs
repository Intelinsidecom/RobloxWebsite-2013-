namespace Roblox.Platform.Chat.Entities;

internal class ChatUniverseUpdateNotificationMessage : ChatUpdateNotificationMessage
{
	public long? UniverseId { get; set; }

	public long? RootPlaceId { get; set; }

	public ChatUniverseUpdateNotificationMessage(long conversationId, long actorTargetId, long? universeId, long? rootPlaceId)
		: base(conversationId, ChatUpdateNotificationType.ConversationUniverseChanged)
	{
		base.ActorTargetId = actorTargetId;
		UniverseId = universeId;
		RootPlaceId = rootPlaceId;
	}
}
