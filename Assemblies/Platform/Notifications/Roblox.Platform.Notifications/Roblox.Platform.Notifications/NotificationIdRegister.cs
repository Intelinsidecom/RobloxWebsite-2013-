using System;
using System.Collections.Generic;
using System.Linq;
using Roblox.Configuration;
using Roblox.EventLog;
using Roblox.Platform.Notifications.Core;
using Roblox.Platform.Notifications.Properties;
using Roblox.Redis;
using StackExchange.Redis;

namespace Roblox.Platform.Notifications;

internal class NotificationIdRegister : INotificationIdRegister
{
	private const string _HashNameNotificationSourceType = "SourceType";

	private const string _HashNamePrefixReceiverDestinationType = "ReceiverDestinationType";

	private IRedisClient _RedisClient;

	private readonly ILogger _Logger;

	public NotificationIdRegister(ILogger logger)
	{
		_Logger = logger ?? throw new ArgumentException("logger");
		InitializeRedisClient();
		Settings.Default.MonitorChanges((Settings s) => s.IsUseRedisConnectionPoolEnabled, InitializeRedisClient);
	}

	private void InitializeRedisClient()
	{
		_Logger.LifecycleEvent("Initializing NotificationIdRegister Redis Clients with " + $"useRedisConnectionPool set to {Settings.Default.IsUseRedisConnectionPoolEnabled} and " + $"redisConnectionPoolSize set to {Settings.Default.NotificationsRedisConnectionPoolSize}");
		_RedisClient = RedisClientProvider.GetRedisClient(_Logger, Settings.Default.IsUseRedisConnectionPoolEnabled);
	}

	public void StoreNotificationIdLookupByNotificationKey(Guid notificationId, NotificationSourceType sourceType, string notificationKey)
	{
		string key = GetDeterministicNotificationKey(sourceType, notificationKey);
		_RedisClient.Execute(key, (IDatabase db) => db.StringSet(key, notificationId.ToString()));
		_RedisClient.Execute(key, (IDatabase db) => db.KeyExpire(key, Settings.Default.NotificationIdLookupExpiry));
	}

	public void StoreNotificationIdLookupByDestinationTypeNotificationId(Guid notificationId, ReceiverDestinationType destinationType, string destinationTypeNotificationId)
	{
		string key = GetChannelNotificationKey(destinationType, destinationTypeNotificationId);
		_RedisClient.Execute(key, (IDatabase db) => db.StringSet(key, notificationId.ToString()));
		_RedisClient.Execute(key, (IDatabase db) => db.KeyExpire(key, Settings.Default.NotificationIdLookupExpiry));
	}

	public Guid? RetrieveNotificationIdByNotificationKey(NotificationSourceType sourceType, string notificationKey)
	{
		string key = GetDeterministicNotificationKey(sourceType, notificationKey);
		return RetrieveNotificationIdByKey(key);
	}

	public Guid? RetrieveNotificationIdByDestinationTypeNotificationId(ReceiverDestinationType destinationType, string destinationTypeNotificationId)
	{
		string key = GetChannelNotificationKey(destinationType, destinationTypeNotificationId);
		return RetrieveNotificationIdByKey(key);
	}

	private Guid? RetrieveNotificationIdByKey(string key)
	{
		if (Guid.TryParse(_RedisClient.Execute(key, (IDatabase db) => db.StringGet(key)), out var notificationId))
		{
			return notificationId;
		}
		return null;
	}

	public void StoreNotificationSourceType(Guid notificationId, NotificationSourceType sourceType)
	{
		string key = GetNotificationChannelIdsKey(notificationId);
		_RedisClient.Execute(key, (IDatabase db) => db.HashSet(key, "SourceType", sourceType.ToString()));
		_RedisClient.Execute(key, (IDatabase db) => db.KeyExpire(key, Settings.Default.NotificationIdLookupExpiry));
	}

	public void StoreNotificationDestinationTypeNotificationId(Guid notificationId, ReceiverDestinationType destinationType, string destinationTypeNotificationId)
	{
		string key = GetNotificationChannelIdsKey(notificationId);
		_RedisClient.Execute(key, (IDatabase db) => db.HashSet(key, string.Format("{0}:{1}", "ReceiverDestinationType", destinationType), destinationTypeNotificationId));
		_RedisClient.Execute(key, (IDatabase db) => db.KeyExpire(key, Settings.Default.NotificationIdLookupExpiry));
	}

	public NotificationDistributionData RetrieveNotificationDistributionData(Guid notificationId)
	{
		string key = GetNotificationChannelIdsKey(notificationId);
		HashEntry[] values = _RedisClient.Execute(key, (IDatabase db) => db.HashGetAll(key));
		if (!values.Any((HashEntry entry) => entry.Name == (RedisValue)"SourceType"))
		{
			return null;
		}
		RedisValue sourceTypeEntry = values.First((HashEntry entry) => entry.Name == (RedisValue)"SourceType").Value;
		Dictionary<ReceiverDestinationType, string> destinationNotificationIds = new Dictionary<ReceiverDestinationType, string>();
		HashEntry[] array = values;
		for (int i = 0; i < array.Length; i++)
		{
			HashEntry entry2 = array[i];
			string name = entry2.Name;
			if (name.StartsWith("ReceiverDestinationType"))
			{
				ReceiverDestinationType destinationType = ParseReceiverDestinationType(name.Substring(name.IndexOf(":") + 1));
				destinationNotificationIds[destinationType] = entry2.Value;
			}
		}
		return new NotificationDistributionData
		{
			NotificationSourceType = ParseNotificationSourceType(sourceTypeEntry),
			DestinationTypeNotificationIds = destinationNotificationIds
		};
	}

	private ReceiverDestinationType ParseReceiverDestinationType(string name)
	{
		return (ReceiverDestinationType)Enum.Parse(typeof(ReceiverDestinationType), name);
	}

	private NotificationSourceType ParseNotificationSourceType(string name)
	{
		return (NotificationSourceType)Enum.Parse(typeof(NotificationSourceType), name);
	}

	private string GetNotificationChannelIdsKey(Guid notificationId)
	{
		return $"NotificationChannelIdsLookup:{notificationId}";
	}

	private string GetDeterministicNotificationKey(NotificationSourceType sourceType, string deterministicNotificationKey)
	{
		return $"NotificationIdLookup_SourceType:{sourceType}_Key:{deterministicNotificationKey}";
	}

	private string GetChannelNotificationKey(ReceiverDestinationType destinationType, string channelNotificationId)
	{
		return $"NotificationIdLookup_DestinationType:{destinationType}_ChannelNotificationId:{channelNotificationId}";
	}
}
