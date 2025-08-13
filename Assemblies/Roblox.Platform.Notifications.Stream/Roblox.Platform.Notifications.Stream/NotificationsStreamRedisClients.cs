using Roblox.Configuration;
using Roblox.EventLog;
using Roblox.Platform.Notifications.Stream.Properties;
using Roblox.Redis;

namespace Roblox.Platform.Notifications.Stream;

public class NotificationsStreamRedisClients : INotificationStreamRedisClients
{
	private readonly ILogger _Logger;

	public IRedisClient EphemeralRedisClient { get; private set; }

	public IRedisClient PersistentRedisClient { get; private set; }

	public NotificationsStreamRedisClients(ILogger logger)
	{
		_Logger = logger;
		InitializeRedisClients();
		Settings.Default.MonitorChanges((Settings s) => s.IsUseRedisConnectionPoolEnabled, InitializeRedisClients);
	}

	private void InitializeRedisClients()
	{
		_Logger.LifecycleEvent("Initializing NotificationsStreamRedisClients Redis Clients with " + $"useRedisConnectionPool set to {Settings.Default.IsUseRedisConnectionPoolEnabled} and " + $"redisConnectionPoolSize set to {Settings.Default.StreamNotificationsRedisConnectionPoolSize}");
		EphemeralRedisClient = RedisClientProvider.GetEphemeralRedisClient(_Logger, Settings.Default.IsUseRedisConnectionPoolEnabled);
		PersistentRedisClient = RedisClientProvider.GetPersistentRedisClient(_Logger, Settings.Default.IsUseRedisConnectionPoolEnabled);
	}
}
