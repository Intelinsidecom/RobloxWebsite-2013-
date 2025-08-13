using System;
using Roblox.Configuration;
using Roblox.EventLog;
using Roblox.Instrumentation;
using Roblox.Platform.Notifications.Properties;
using Roblox.Redis;

namespace Roblox.Platform.Notifications;

internal static class RedisClientProvider
{
	private const string _PerformanceCategory = "Roblox.Platform.Notifications.Redis";

	private static readonly RedisClientFactory _RedisClientFactory;

	private static readonly RedisClientFactory _RedisClientWithConnectionPoolFactory;

	static RedisClientProvider()
	{
		_RedisClientFactory = new RedisClientFactory(StaticCounterRegistry.Instance);
		RedisPooledClientOptions redisClientWithConnectionPoolOptions = new RedisPooledClientOptions(Settings.Default.NotificationsRedisConnectionPoolSize);
		RedisClientOptions redisClientOptions = new RedisClientOptions();
		_RedisClientWithConnectionPoolFactory = new RedisClientFactory(StaticCounterRegistry.Instance, useConnectionPooling: true, redisClientOptions, redisClientWithConnectionPoolOptions);
	}

	public static IRedisClient GetRedisClient(ILogger logger, bool useRedisConnectionPool)
	{
		return (useRedisConnectionPool ? _RedisClientWithConnectionPoolFactory : _RedisClientFactory).GetRedisClient(Settings.Default.RedisEndpointsV2, delegate(Action<RedisEndpoints> refresh)
		{
			Settings.Default.MonitorChanges((Settings s) => s.RedisEndpointsV2, refresh);
		}, "Roblox.Platform.Notifications.Redis", logger.Error);
	}
}
