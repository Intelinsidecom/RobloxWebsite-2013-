using Roblox.Redis;

namespace Roblox.Platform.Chat;

public class ChatRedisClients : IChatRedisClients
{
	public IRedisClient ChatConversationRedisClient { get; set; }

	public IRedisClient ChatMessageRedisClient { get; set; }
}
