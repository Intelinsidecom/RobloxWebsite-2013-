using System;
using Roblox.Configuration;
using Roblox.EventLog;
using Roblox.Instrumentation;
using Roblox.Platform.Notifications.Push.Properties;
using Roblox.Redis;

namespace Roblox.Platform.Notifications.Push;

internal static class RedisClientProvider
{
	private const string _PerformanceCategorySuffix = ".Redis";

	private static readonly RedisClientFactory _RedisClientFactory;

	private static readonly RedisClientFactory _RedisClientWithConnectionPoolFactory;

	static RedisClientProvider()
	{
		_RedisClientFactory = new RedisClientFactory(StaticCounterRegistry.Instance);
		RedisPooledClientOptions redisClientWithConnectionPoolOptions = new RedisPooledClientOptions(Settings.Default.PushNotificationsRedisConnectionPoolSize);
		RedisClientOptions redisClientOptions = new RedisClientOptions();
		_RedisClientWithConnectionPoolFactory = new RedisClientFactory(StaticCounterRegistry.Instance, useConnectionPooling: true, redisClientOptions, redisClientWithConnectionPoolOptions);
	}

	public static IRedisClient GetRedisClient(string logSource, ILogger logger, bool useRedisConnectionPool)
	{
		return (useRedisConnectionPool ? _RedisClientWithConnectionPoolFactory : _RedisClientFactory).GetRedisClient(Settings.Default.RedisEndpointsV2, delegate(Action<RedisEndpoints> refresh)
		{
			Settings.Default.MonitorChanges((Settings s) => s.RedisEndpointsV2, refresh);
		}, logSource + ".Redis", logger.Error);
	}
}
