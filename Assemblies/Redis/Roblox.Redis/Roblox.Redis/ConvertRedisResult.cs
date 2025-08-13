using StackExchange.Redis;

namespace Roblox.Redis;

public delegate TResult ConvertRedisResult<out TResult>(RedisResult redisResult);
