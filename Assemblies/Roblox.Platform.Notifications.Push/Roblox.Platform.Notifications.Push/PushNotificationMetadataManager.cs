using System;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json.Linq;
using Roblox.Configuration;
using Roblox.EventLog;
using Roblox.Platform.Notifications.Core;
using Roblox.Platform.Notifications.Push.Properties;
using Roblox.Redis;
using StackExchange.Redis;

namespace Roblox.Platform.Notifications.Push;

public class PushNotificationMetadataManager : IPushNotificationMetadataManager
{
	internal delegate void MetadataReadHandler(string notificationType, PushApplicationType application, PushPlatformType platform, DateTime notificationDeliveryStarted, DateTime metadataRead);

	internal delegate void MetadataRetrieveFailHandler(PushApplicationType application, PushPlatformType platform);

	internal delegate void InteractionRecordedHandler(string notificationType, PushNotificationInteractionType interactionType, PushApplicationType application, PushPlatformType platform, DateTime notificationDelivered, DateTime interactionRecorded);

	private class ReceiverDestinationDeliveryRecord
	{
		public DateTime DeliveryTime { get; set; }

		public bool FallbackNotificationSent { get; set; }
	}

	private const string _GuidFormat = "N";

	private const string _HashFieldIntent = "Intent";

	private const string _HashFieldType = "Type";

	private const string _HashFieldDetail = "Detail";

	private const string _HashFieldCreated = "Created";

	private const string _HashFieldStoredNotificationFormatVersion = "V";

	private const string _ReceiverDelivery_DeliveryTime = "DT";

	private const string _ReceiverDelivery_ReceiptTime = "RT";

	private const string _ReceiverDelivery_Interacted = "I";

	private const string _ReceiverDelivery_FallbackSent = "FS";

	private IRedisClient _RedisClient;

	private readonly ILogger _Logger;

	private readonly string _LogSource;

	internal event MetadataReadHandler OnMetadataRead;

	internal event MetadataRetrieveFailHandler OnMetadataRetrieveFailure;

	internal event InteractionRecordedHandler OnInteractionRecorded;

	public PushNotificationMetadataManager(string logSource, ILogger logger)
	{
		_LogSource = logSource;
		_Logger = logger;
		InitializeRedisClient();
		Settings.Default.MonitorChanges((Settings s) => s.IsUseRedisConnectionPoolEnabled, InitializeRedisClient);
	}

	private void InitializeRedisClient()
	{
		_Logger.LifecycleEvent("Initializing PushNotificationMetadataManager Redis Clients with " + $"useRedisConnectionPool set to {Settings.Default.IsUseRedisConnectionPoolEnabled} and " + $"redisConnectionPoolSize set to {Settings.Default.PushNotificationsRedisConnectionPoolSize}");
		_RedisClient = RedisClientProvider.GetRedisClient(_LogSource, _Logger, Settings.Default.IsUseRedisConnectionPoolEnabled);
	}

	public void StoreNotificationMetadata(Guid notificationId, IStoredPushNotification format)
	{
		string key = GetNotificationMetadataRedisKey(notificationId);
		HashEntry[] hashEntries = GetHashEntries(format);
		_RedisClient.Execute(key, delegate(IDatabase db)
		{
			db.HashSet(key, hashEntries);
		});
		_RedisClient.Execute(key, (IDatabase db) => db.KeyExpire(key, Settings.Default.NotificationMetadataExpiry));
	}

	public void RecordNotificationPrimaryDelivery(Guid notificationId, long receiverDestinationId)
	{
		string hashKey = GetReceiverDestinationNotificationDeliveryKey(receiverDestinationId, notificationId);
		_RedisClient.Execute(hashKey, (IDatabase db) => db.HashSet(hashKey, "DT", DateTime.UtcNow.Ticks));
		_RedisClient.Execute(hashKey, (IDatabase db) => db.KeyExpire(hashKey, Settings.Default.NotificationDeliveryRecordExpiry));
		string listKey = GetReceiverDestinationNotificationsKey(receiverDestinationId);
		_RedisClient.Execute(listKey, (IDatabase db) => db.SortedSetAdd(listKey, notificationId.ToString("N"), DateTime.UtcNow.Ticks));
		_RedisClient.Execute(listKey, (IDatabase db) => db.KeyExpire(listKey, Settings.Default.NotificationDeliveryRecordExpiry));
		try
		{
			long expiredLimit = DateTime.UtcNow.Subtract(Settings.Default.NotificationDeliveryRecordExpiry).Ticks;
			_RedisClient.Execute(listKey, (IDatabase db) => db.SortedSetRemoveRangeByScore(listKey, 0.0, expiredLimit));
		}
		catch (Exception exception)
		{
			_Logger.Error(exception);
		}
	}

	public void StoreDeliveryReceiptDestinationMapping(string deliveryReceiptId, long destinationId)
	{
		string key = DeliveryReceiptDestinationMappingKey(deliveryReceiptId);
		_RedisClient.Execute(key, (IDatabase db) => db.StringSet(key, destinationId, Settings.Default.NotificationDeliveryRecordExpiry));
	}

	public IStoredPushNotification GetNotificationMetadataUnguarded(Guid notificationId)
	{
		return GetNotificationMetadata(notificationId);
	}

	public IStoredPushNotification GetNotificationMetadata(IUserPushDestinationCore destination, Guid notificationId, bool markAsReceived)
	{
		long receiverDestinationId = destination.UserPushNotificationDestinationId;
		ReceiverDestinationDeliveryRecord notificationDeliveryRecord = GetNotificationDeliveryRecord(notificationId, receiverDestinationId);
		if (notificationDeliveryRecord != null)
		{
			IStoredPushNotification metadata = GetNotificationMetadata(notificationId, notificationDeliveryRecord.FallbackNotificationSent);
			if (metadata == null)
			{
				this.OnMetadataRetrieveFailure?.Invoke(destination.Application, destination.Platform);
				return null;
			}
			if (markAsReceived)
			{
				try
				{
					MarkAsReceivedIfNotAlready(notificationId, receiverDestinationId, destination, metadata);
				}
				catch (Exception exception)
				{
					_Logger.Error(exception);
				}
			}
			return metadata;
		}
		return null;
	}

	public void MarkNotificationAsReceived(IUserPushDestinationCore destination, Guid notificationId)
	{
		GetNotificationMetadata(destination, notificationId, markAsReceived: true);
	}

	public bool HasNotificationBeenReceived(IUserPushDestinationCore destination, Guid notificationId)
	{
		string key = GetReceiverDestinationNotificationDeliveryKey(destination.UserPushNotificationDestinationId, notificationId);
		return _RedisClient.Execute(key, (IDatabase db) => db.HashExists(key, "RT"));
	}

	public void MarkNotificationAsInteracted(IUserPushDestinationCore destination, Guid notificationId, PushNotificationInteractionType interactionType)
	{
		DateTime interactionTime = DateTime.UtcNow;
		long receiverDestinationId = destination.UserPushNotificationDestinationId;
		if (IsANewInteraction(notificationId, receiverDestinationId, out var receivedTime))
		{
			try
			{
				IStoredPushNotification metadata = GetNotificationMetadata(notificationId);
				this.OnInteractionRecorded?.Invoke((metadata != null) ? GetNotificationTypeForReporting(metadata) : null, interactionType, destination.Application, destination.Platform, receivedTime ?? interactionTime, interactionTime);
			}
			catch (Exception exception)
			{
				_Logger.Error(exception);
			}
		}
	}

	public void RecordNotificationFallbackDelivery(Guid notificationId, long receiverDestinationId)
	{
		string key = GetReceiverDestinationNotificationDeliveryKey(receiverDestinationId, notificationId);
		Dictionary<string, HashEntry> currentValues = _RedisClient.Execute(key, (IDatabase db) => db.HashGetAll(key)).ToDictionary((HashEntry x) => x.Name.ToString());
		if (currentValues.ContainsKey("DT") && !currentValues.ContainsKey("FS"))
		{
			_RedisClient.Execute(key, (IDatabase db) => db.HashSet(key, "FS", true));
			_RedisClient.Execute(key, (IDatabase db) => db.KeyExpire(key, Settings.Default.NotificationDeliveryRecordExpiry, CommandFlags.FireAndForget));
		}
		string fallbackCountKey = GetReceiverDestinationUninterruptedFallbackCountKey(receiverDestinationId);
		_RedisClient.Execute(fallbackCountKey, (IDatabase db) => db.StringIncrement(fallbackCountKey, 1L));
		_RedisClient.Execute(fallbackCountKey, (IDatabase db) => db.KeyExpire(fallbackCountKey, Settings.Default.ReceiverDestinationUninterruptedFallbackExpiry, CommandFlags.FireAndForget));
	}

	public void ResetUninterruptedFallbackCount(IUserPushDestinationCore destination)
	{
		string fallbackCountKey = GetReceiverDestinationUninterruptedFallbackCountKey(destination.UserPushNotificationDestinationId);
		_RedisClient.Execute(fallbackCountKey, (IDatabase db) => db.KeyDelete(fallbackCountKey));
	}

	public int GetUninterruptedFallbackCount(IUserPushDestinationCore destination)
	{
		string fallbackCountKey = GetReceiverDestinationUninterruptedFallbackCountKey(destination.UserPushNotificationDestinationId);
		if (int.TryParse(_RedisClient.Execute(fallbackCountKey, (IDatabase db) => db.StringGet(fallbackCountKey)).ToString(), out var count))
		{
			return count;
		}
		return 0;
	}

	public ICollection<Guid> GetNotificationMetadataIdsPaged(IUserPushDestinationCore destination, int start, int count)
	{
		long receiverDestinationId = destination.UserPushNotificationDestinationId;
		string key = GetReceiverDestinationNotificationsKey(receiverDestinationId);
		return (from x in _RedisClient.Execute(key, (IDatabase db) => db.SortedSetRangeByScore(key, double.NegativeInfinity, double.PositiveInfinity, Exclude.None, Order.Descending, take: count, skip: start))
			select Guid.ParseExact(x, "N")).ToList();
	}

	public long? GetDestinationIdFromDeliveryReceipt(string deliveryReceiptId)
	{
		string key = DeliveryReceiptDestinationMappingKey(deliveryReceiptId);
		return (long?)_RedisClient.Execute(key, (IDatabase db) => db.StringGet(key));
	}

	private IStoredPushNotification GetNotificationMetadata(Guid notificationId, bool fallbackDelivered = false)
	{
		string key = GetNotificationMetadataRedisKey(notificationId);
		HashEntry[] hashEntries = _RedisClient.Execute(key, (IDatabase db) => db.HashGetAll(key));
		if (hashEntries == null || hashEntries.Length == 0)
		{
			return null;
		}
		return TranslateHashEntries(hashEntries, fallbackDelivered);
	}

	private ReceiverDestinationDeliveryRecord GetNotificationDeliveryRecord(Guid notificationId, long receiverDestinationId)
	{
		string hashKey = GetReceiverDestinationNotificationDeliveryKey(receiverDestinationId, notificationId);
		Dictionary<RedisValue, RedisValue> hashEntries = _RedisClient.Execute(hashKey, (IDatabase db) => db.HashGetAll(hashKey)).ToDictionary();
		if (hashEntries.ContainsKey("DT"))
		{
			return new ReceiverDestinationDeliveryRecord
			{
				DeliveryTime = new DateTime(Convert.ToInt64(hashEntries["DT"]), DateTimeKind.Utc),
				FallbackNotificationSent = (hashEntries.ContainsKey("FS") && hashEntries["FS"] == true)
			};
		}
		if (Settings.Default.CheckLegacyDeliveryTrackingMethod)
		{
			string listKey = GetReceiverDestinationNotificationsKey(receiverDestinationId);
			double? score = _RedisClient.Execute(listKey, (IDatabase db) => db.SortedSetScore(listKey, notificationId.ToString("N")));
			if (score.HasValue)
			{
				return new ReceiverDestinationDeliveryRecord
				{
					DeliveryTime = new DateTime((long)score.Value, DateTimeKind.Utc),
					FallbackNotificationSent = false
				};
			}
		}
		return null;
	}

	private void MarkAsReceivedIfNotAlready(Guid notificationId, long receiverDestinationId, IUserPushDestinationCore destination, IStoredPushNotification format)
	{
		string key = GetReceiverDestinationNotificationDeliveryKey(receiverDestinationId, notificationId);
		Dictionary<string, HashEntry> currentValues = _RedisClient.Execute(key, (IDatabase db) => db.HashGetAll(key)).ToDictionary((HashEntry x) => x.Name.ToString());
		if (!currentValues.ContainsKey("DT") || currentValues.ContainsKey("RT"))
		{
			return;
		}
		DateTime receiptTime = DateTime.UtcNow;
		_RedisClient.Execute(key, (IDatabase db) => db.HashSet(key, "RT", receiptTime.Ticks));
		_RedisClient.Execute(key, (IDatabase db) => db.KeyExpire(key, Settings.Default.NotificationDeliveryRecordExpiry));
		if (Settings.Default.LegacyInteractionTrackingEnabled)
		{
			string deliveredKey = GetLegacyReceiverDestinationNotificationsDeliveredKey(receiverDestinationId, notificationId);
			long deliveredKeyTimestamp = receiptTime.Ticks;
			_RedisClient.Execute(deliveredKey, (IDatabase db) => db.StringSet(deliveredKey, deliveredKeyTimestamp, Settings.Default.NotificationDeliveryRecordExpiry));
		}
		ResetUninterruptedFallbackCount(destination);
		this.OnMetadataRead?.Invoke(GetNotificationTypeForReporting(format), destination.Application, destination.Platform, new DateTime(Convert.ToInt64(currentValues["DT"].Value), DateTimeKind.Utc), receiptTime);
	}

	private bool IsANewInteraction(Guid notificationId, long receiverDestinationId, out DateTime? receivedTime)
	{
		string key = GetReceiverDestinationNotificationDeliveryKey(receiverDestinationId, notificationId);
		Dictionary<string, RedisValue> currentValues = _RedisClient.Execute(key, (IDatabase db) => db.HashGetAll(key)).ToDictionary((HashEntry x) => x.Name.ToString(), (HashEntry x) => x.Value);
		if (currentValues.ContainsKey("DT") && !currentValues.ContainsKey("I"))
		{
			_RedisClient.Execute(key, (IDatabase db) => db.HashSet(key, "I", true));
			RedisValue receivedTimeValue = (currentValues.ContainsKey("RT") ? currentValues["RT"] : currentValues["DT"]);
			receivedTime = new DateTime(Convert.ToInt64(receivedTimeValue), DateTimeKind.Utc);
			return true;
		}
		if (Settings.Default.LegacyInteractionTrackingEnabled)
		{
			string legacyKey = GetLegacyReceiverDestinationNotificationsDeliveredKey(receiverDestinationId, notificationId);
			RedisValue score = _RedisClient.Execute(legacyKey, (IDatabase db) => db.StringGet(legacyKey));
			if (score.HasValue)
			{
				receivedTime = new DateTime(Convert.ToInt64(score), DateTimeKind.Utc);
				return true;
			}
		}
		receivedTime = null;
		return false;
	}

	private string GetNotificationTypeForReporting(IStoredPushNotification format)
	{
		try
		{
			NotificationSourceType? sourceType = null;
			try
			{
				int? sourceTypeInt = JObject.Parse(format.DetailJson).SelectToken("SourceType")?.Value<int?>();
				if (sourceTypeInt.HasValue)
				{
					sourceType = (NotificationSourceType)sourceTypeInt.Value;
				}
			}
			catch (Exception)
			{
			}
			return LegacyStoredPushNotificationFormat.GetLegacyNotificationType(format.Intent, sourceType);
		}
		catch (Exception exception)
		{
			_Logger.Error(exception);
		}
		return null;
	}

	private HashEntry[] GetHashEntries(IStoredPushNotification format)
	{
		return new HashEntry[5]
		{
			new HashEntry("V", 2),
			new HashEntry("Intent", (int)format.Intent),
			new HashEntry("Detail", format.DetailJson),
			new HashEntry("Created", format.Created.Ticks),
			new HashEntry("Type", GetNotificationTypeForReporting(format))
		};
	}

	private IStoredPushNotification TranslateHashEntries(HashEntry[] hashEntries, bool fallbackDelivered)
	{
		Dictionary<RedisValue, RedisValue> dictionary = hashEntries.ToDictionary();
		int version = 1;
		if (dictionary.ContainsKey("V"))
		{
			version = (int)dictionary["V"];
		}
		if (version == 1)
		{
			PushNotificationIntent intent = LegacyStoredPushNotificationFormat.GetIntentFromLegacyNotificationType(dictionary["Type"]);
			return new StoredPushNotification
			{
				Intent = intent,
				Created = new DateTime((long)dictionary["Created"], DateTimeKind.Utc),
				DetailJson = dictionary["Detail"],
				FallbackDelivered = false
			};
		}
		return new StoredPushNotification
		{
			Intent = (PushNotificationIntent)(int)dictionary["Intent"],
			Created = new DateTime((long)dictionary["Created"], DateTimeKind.Utc),
			DetailJson = dictionary["Detail"],
			FallbackDelivered = fallbackDelivered
		};
	}

	private static string GetReceiverDestinationNotificationsKey(long receiverDestinationId)
	{
		return "ReceiverDestinationNotificationIds_ID:" + receiverDestinationId;
	}

	private static string GetReceiverDestinationNotificationDeliveryKey(long receiverDestinationId, Guid notificationId)
	{
		return "rdId:" + receiverDestinationId + "_nId:" + notificationId.ToString("N");
	}

	private static string GetLegacyReceiverDestinationNotificationsDeliveredKey(long receiverDestinationId, Guid notificationId)
	{
		return "ReceiverDestinationDelivery_ID:" + receiverDestinationId + "_Notification:" + notificationId.ToString("N");
	}

	private static string GetNotificationMetadataRedisKey(Guid notificationId)
	{
		return "NotificationMetadata_ID:" + notificationId.ToString("N");
	}

	private static string DeliveryReceiptDestinationMappingKey(string deliveryReceipt)
	{
		return "PushDeliveryReceipt_ID:" + deliveryReceipt;
	}

	private string GetReceiverDestinationUninterruptedFallbackCountKey(long receiverDestinationId)
	{
		return "rdufc:" + receiverDestinationId;
	}
}
