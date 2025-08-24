using System;
using Roblox.Configuration;
using Roblox.EventLog;
using Roblox.Instrumentation;
using Roblox.RealTimeNotifications.Properties;
using Roblox.Redis;

namespace Roblox.RealTimeNotifications;

public static class UserNotificationRedisClientProvider
{
	private const string _PerformanceCategory = "Roblox.Platform.Notifications.Redis";

	private static readonly RedisClientFactory _RedisClientFactory = new RedisClientFactory(StaticCounterRegistry.Instance);

	private static readonly RedisClientFactory _RedisClientWithConnectionPoolFactory = new RedisClientFactory(StaticCounterRegistry.Instance, useConnectionPooling: true, null, new RedisPooledClientOptions(Settings.Default.UserNotificationsRedisConnectionPoolSize));

	private static readonly RedisClientFactory _RealTimeActivityMonitoringRedisClientFactory = new RedisClientFactory(StaticCounterRegistry.Instance);

	private static readonly RedisClientFactory _RealTimeActivityMonitoringRedisClientWithConnectionPoolingFactory = new RedisClientFactory(StaticCounterRegistry.Instance, useConnectionPooling: true, null, new RedisPooledClientOptions(Settings.Default.RealTimeActivityMonitoringRedisConnectionPoolSize));

	public static IRedisClient GetRedisClient(ILogger logger, bool useConnectionPooling = false)
	{
		return GetRedisClient(useConnectionPooling ? _RedisClientWithConnectionPoolFactory : _RedisClientFactory, logger);
	}

	public static IRedisClient GetRedisClientForUserRealTimeActivityMonitoring(ILogger logger, bool useConnectionPooling)
	{
		return GetRedisClient(useConnectionPooling ? _RealTimeActivityMonitoringRedisClientWithConnectionPoolingFactory : _RealTimeActivityMonitoringRedisClientFactory, logger);
	}

	private static IRedisClient GetRedisClient(IRedisClientFactory redisClientFactory, ILogger logger)
	{
		return redisClientFactory.GetRedisClient(Settings.Default.UserNotificationsRedisEndpointsV2, delegate(Action<RedisEndpoints> refresh)
		{
			Settings.Default.MonitorChanges((Settings s) => s.UserNotificationsRedisEndpointsV2, refresh);
		}, "Roblox.Platform.Notifications.Redis", logger.Error);
	}
}
