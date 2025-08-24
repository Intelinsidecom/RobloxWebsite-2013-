using Roblox.Redis;

namespace Roblox.Platform.Chat;

public interface IChatRedisClients
{
	IRedisClient ChatConversationRedisClient { get; }

	IRedisClient ChatMessageRedisClient { get; }
}
