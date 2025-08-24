using Roblox.Redis;

namespace Roblox.Platform.Notifications.Stream;

public interface INotificationStreamRedisClients
{
	IRedisClient EphemeralRedisClient { get; }

	IRedisClient PersistentRedisClient { get; }
}
