using Roblox.Entities;

namespace Roblox.Platform.Chat.Entities;

internal interface IConversationUniverseEntity : IUpdateableEntity<long>, IEntity<long>
{
	long ConversationId { get; set; }

	long UniverseId { get; set; }
}
