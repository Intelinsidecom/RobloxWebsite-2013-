using System;
using Roblox.Configuration;
using Roblox.EventLog;
using Roblox.Instrumentation;
using Roblox.Platform.Notifications.Stream.Properties;
using Roblox.Redis;

namespace Roblox.Platform.Notifications.Stream;

internal static class RedisClientProvider
{
	private const string _EphemeralRedisPerformanceCategoryV2 = "Roblox.Platform.Notifications.Stream.EphemeralRedis.V2";

	private const string _PersistentRedisPerformanceCategoryV2 = "Roblox.Platform.Notifications.Stream.PersistentRedis.V2";

	private static readonly RedisClientFactory _EphemeralRedisClientFactory;

	private static readonly RedisClientFactory _PersistentRedisClientFactory;

	private static readonly RedisClientFactory _EphemeralRedisClientWithConnectionPoolFactory;

	private static readonly RedisClientFactory _PersistentRedisClientWithConnectionPoolFactory;

	static RedisClientProvider()
	{
		_EphemeralRedisClientFactory = new RedisClientFactory(StaticCounterRegistry.Instance);
		_PersistentRedisClientFactory = new RedisClientFactory(StaticCounterRegistry.Instance);
		RedisPooledClientOptions redisClientWithConnectionPoolOptions = new RedisPooledClientOptions(Settings.Default.StreamNotificationsRedisConnectionPoolSize);
		RedisClientOptions redisClientOptions = new RedisClientOptions();
		_EphemeralRedisClientWithConnectionPoolFactory = new RedisClientFactory(StaticCounterRegistry.Instance, useConnectionPooling: true, redisClientOptions, redisClientWithConnectionPoolOptions);
		_PersistentRedisClientWithConnectionPoolFactory = new RedisClientFactory(StaticCounterRegistry.Instance, useConnectionPooling: true, redisClientOptions, redisClientWithConnectionPoolOptions);
	}

	public static IRedisClient GetEphemeralRedisClient(ILogger logger, bool useRedisConnectionPool)
	{
		return GetRedisClient(_EphemeralRedisClientWithConnectionPoolFactory, _EphemeralRedisClientFactory, Settings.Default.RedisEphemeralEndpointsV2, delegate(Action<RedisEndpoints> refresh)
		{
			Settings.Default.MonitorChanges((Settings s) => s.RedisEphemeralEndpointsV2, refresh);
		}, "Roblox.Platform.Notifications.Stream.EphemeralRedis.V2", logger.Error, useRedisConnectionPool);
	}

	public static IRedisClient GetPersistentRedisClient(ILogger logger, bool useRedisConnectionPool)
	{
		return GetRedisClient(_PersistentRedisClientWithConnectionPoolFactory, _PersistentRedisClientFactory, Settings.Default.RedisPersistentEndpointsV2, delegate(Action<RedisEndpoints> refresh)
		{
			Settings.Default.MonitorChanges((Settings s) => s.RedisPersistentEndpointsV2, refresh);
		}, "Roblox.Platform.Notifications.Stream.PersistentRedis.V2", logger.Error, useRedisConnectionPool);
	}

	private static IRedisClient GetRedisClient(RedisClientFactory redisClientWithConnectionPoolFactory, RedisClientFactory redisClientFactory, RedisEndpoints endpoints, Action<Action<RedisEndpoints>> monitorWireup, string performanceMonitorCategory, Action<Exception> errorHandler, bool useRedisConnectionPool)
	{
		return (useRedisConnectionPool ? redisClientWithConnectionPoolFactory : redisClientFactory).GetRedisClient(endpoints, monitorWireup, performanceMonitorCategory, errorHandler);
	}
}
