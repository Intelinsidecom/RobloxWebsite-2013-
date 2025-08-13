namespace Roblox.Redis;

public interface IRedisClientProvider
{
	IRedisClient Client { get; }
}
