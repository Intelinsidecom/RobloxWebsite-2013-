using System;
using Roblox.Configuration;
using Roblox.EventLog;
using Roblox.Instrumentation;
using Roblox.Platform.Social.Properties;
using Roblox.Redis;

namespace Roblox.Platform.Social.PlayerInteractions;

internal static class PlayerInteractionsRedisClientFactory
{
	private const string _PerformanceMonitorCategory = "Roblox.Platform.Social.PlayerInteractions.RedisClient";

	private static readonly RedisClientFactory _RedisClientFactory;

	private static readonly RedisClientFactory _RedisClientWithConnectionPoolFactory;

	static PlayerInteractionsRedisClientFactory()
	{
		_RedisClientFactory = new RedisClientFactory(StaticCounterRegistry.Instance);
		RedisPooledClientOptions redisClientWithConnectionPoolOptions = new RedisPooledClientOptions(Settings.Default.PlayerInteractionsRedisConnectionPoolSize, (int)Settings.Default.PlayerInteractionsRedisMaxReconnectTimeout.TotalMilliseconds);
		RedisClientOptions redisClientOptions = new RedisClientOptions();
		_RedisClientWithConnectionPoolFactory = new RedisClientFactory(StaticCounterRegistry.Instance, useConnectionPooling: true, redisClientOptions, redisClientWithConnectionPoolOptions);
	}

	public static IRedisClient GetRedisClient(ILogger logger, bool useRedisConnectionPool)
	{
		return (useRedisConnectionPool ? _RedisClientWithConnectionPoolFactory : _RedisClientFactory).GetRedisClient(Settings.Default.PlayerInteractionsRedisEndpoints, delegate(Action<RedisEndpoints> refresh)
		{
			Settings.Default.MonitorChanges((Settings s) => s.PlayerInteractionsRedisEndpoints, refresh);
		}, "Roblox.Platform.Social.PlayerInteractions.RedisClient", logger.Error);
	}
}
