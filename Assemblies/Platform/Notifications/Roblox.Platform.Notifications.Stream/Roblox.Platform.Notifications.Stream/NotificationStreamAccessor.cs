using System;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;
using Roblox.EventLog;
using Roblox.Platform.Notifications.Core;
using Roblox.Platform.Notifications.Core.Events;
using Roblox.Platform.Notifications.Stream.Exceptions;
using Roblox.Platform.Notifications.Stream.Properties;
using Roblox.Redis;
using StackExchange.Redis;

namespace Roblox.Platform.Notifications.Stream;

internal class NotificationStreamAccessor : INotificationStreamAccessor
{
	internal delegate void MissingStreamNotificationHandler(MissingStreamNotificationType type);

	private readonly INotificationEventPublisher _NotificationEventPublisher;

	private readonly IRedisClient _RedisClient;

	private readonly IRedisClient _LruCacheRedisClient;

	private readonly ILogger _Logger;

	private readonly IStreamNotificationEventPublisher _StreamNotificationRealTimeEventPublisher;

	private readonly IUnreadCountTracker _UnreadCountTracker;

	private readonly IHourlyEventCountTracker _HourlyEventCountTracker;

	private const string _SourceTypeHashFieldName = "SourceType";

	private const string _EventDateHashFieldName = "EventDate";

	private const string _EventTargetHashFieldName = "EventTargetId";

	private static readonly TimeSpan _AggregatedBucketCacheExpiration = TimeSpan.FromHours(2.0);

	private static readonly DateTime _Epoch = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);

	private static int _EventsToStorePerStreamItem => Settings.Default.EventsToStorePerStreamItem;

	internal virtual int HoursPerBucket => Settings.Default.HoursPerBucket;

	internal virtual DateTime Now => DateTime.UtcNow;

	internal virtual TimeSpan ExpirationDelay => Settings.Default.NotificationStreamEventExpirationDelay;

	internal virtual int MaximumRecentEvents => Settings.Default.NotificationStreamMaximumRecentEvents;

	internal virtual int MaximumEventsPerPage => Settings.Default.NotificationStreamMaximumPageSize;

	internal virtual int MaximumEventTargetIdLength => Settings.Default.MaximumEventTargetIdLength;

	internal static event MissingStreamNotificationHandler OnStreamNotificationMissing;

	internal NotificationStreamAccessor(INotificationEventPublisher notificationEventPublisher, IRedisClient redisClient, IRedisClient lruCacheRedisClient, ILogger logger, IStreamNotificationEventPublisher streamNotificationEventPublisher, IUnreadCountTracker unreadCountTracker, IHourlyEventCountTracker hourlyEventCountTracker)
	{
		_NotificationEventPublisher = notificationEventPublisher;
		_RedisClient = redisClient;
		_LruCacheRedisClient = lruCacheRedisClient;
		_Logger = logger;
		_StreamNotificationRealTimeEventPublisher = streamNotificationEventPublisher;
		_UnreadCountTracker = unreadCountTracker;
		_HourlyEventCountTracker = hourlyEventCountTracker;
	}

	public ICollection<NotificationStreamEventGroup> GetRecentNotifications(IReceiver receiver, int startIndex, int maxRows)
	{
		if (maxRows > MaximumEventsPerPage)
		{
			throw new NotificationStreamPageEventLimitExceededException();
		}
		if (startIndex + maxRows > MaximumRecentEvents)
		{
			throw new NotificationStreamTotalEventLimitExceededException();
		}
		List<SortedSetEntry> initialSortedSetEntries = new List<SortedSetEntry>();
		DateTime now = Now;
		DateTime startTime = BucketedTimeMinimum(now);
		while (startTime > now.Subtract(ExpirationDelay) && initialSortedSetEntries.Count < maxRows + startIndex)
		{
			string storageKey = CurrentReceiverNotificationStreamRedisCacheKey(receiver, startTime, HoursPerBucket);
			SortedSetEntry[] currentResults = _RedisClient.Execute(storageKey, (IDatabase db) => db.SortedSetRangeByScoreWithScores(storageKey, double.NegativeInfinity, double.PositiveInfinity, Exclude.None, Order.Descending, 0L, -1L));
			initialSortedSetEntries.AddRange(currentResults);
			startTime = startTime.Subtract(TimeSpan.FromHours(HoursPerBucket));
		}
		initialSortedSetEntries = initialSortedSetEntries.Skip(startIndex).Take(maxRows).ToList();
		List<NotificationStreamEventGroup> results = new List<NotificationStreamEventGroup>();
		if (initialSortedSetEntries.Count == 0)
		{
			return results;
		}
		DateTime populationBucketTime = BucketedTimeMinimum(new DateTime((long)initialSortedSetEntries.First().Score, DateTimeKind.Utc));
		Dictionary<DateTime, List<SortedSetEntry>> timeBucketedEntries = (from x in initialSortedSetEntries
			group x by BucketedTimeMinimum(new DateTime((long)x.Score, DateTimeKind.Utc))).ToDictionary((IGrouping<DateTime, SortedSetEntry> x) => x.Key, (IGrouping<DateTime, SortedSetEntry> x) => x.ToList());
		while (populationBucketTime > now.Subtract(ExpirationDelay))
		{
			if (timeBucketedEntries.ContainsKey(populationBucketTime))
			{
				List<SortedSetEntry> currentBucketSortedSetEntries = timeBucketedEntries[populationBucketTime];
				List<NotificationStreamEventGroup> bucketResults = GetAggregatedResultsFromCache(receiver, populationBucketTime);
				if (bucketResults.Count == 0)
				{
					bucketResults = (from r in currentBucketSortedSetEntries.Select(ConvertToNotificationStreamGroup)
						select HydrateNotificationStreamGroup(r, receiver, now)).ToList();
					SetAggregatedResultsInCache(receiver, populationBucketTime, bucketResults);
				}
				results.AddRange(bucketResults.Where((NotificationStreamEventGroup cr) => cr.EventCount > 0 && currentBucketSortedSetEntries.Any((SortedSetEntry isse) => (string)isse.Element == cr.SourceType.ToString())));
			}
			populationBucketTime = populationBucketTime.Subtract(TimeSpan.FromHours(HoursPerBucket));
		}
		return results.Take(maxRows).ToList();
	}

	public void ClearUnreadNotifications(IReceiver receiver)
	{
		_UnreadCountTracker.Reset(receiver);
		_StreamNotificationRealTimeEventPublisher.PublishNotificationsRead(receiver);
	}

	public long GetUnreadNotificationCount(IReceiver receiver)
	{
		return _UnreadCountTracker.GetCount(receiver);
	}

	/// <inheritdoc />
	public Guid StoreNotification(NotificationSourceType sourceType, EventTarget eventTarget)
	{
		string eventTargetString = eventTarget ?? ((EventTarget)"");
		if (eventTargetString.Length > MaximumEventTargetIdLength)
		{
			throw new ArgumentException(string.Format("{0} is longer than the maximum length of {1}", "eventTarget", Settings.Default.MaximumEventTargetIdLength), "eventTarget");
		}
		Guid notificationId = Guid.NewGuid();
		string key = NotificationStreamEventCacheKey(notificationId);
		HashEntry[] hashEntries = new HashEntry[3]
		{
			new HashEntry("SourceType", sourceType.ToString()),
			new HashEntry("EventDate", Now.Ticks),
			new HashEntry("EventTargetId", eventTargetString)
		};
		_RedisClient.Execute(key, delegate(IDatabase db)
		{
			db.HashSet(key, hashEntries);
		});
		_RedisClient.Execute(key, (IDatabase db) => db.KeyExpire(key, ExpirationDelay));
		return notificationId;
	}

	public void LogNotificationStreamReceipt(IReceiver recipient, Guid notificationId)
	{
		NotificationStreamEventIdentifier identifier = RetrieveNotificationStreamEvent(notificationId);
		if (identifier == null)
		{
			NotificationStreamAccessor.OnStreamNotificationMissing?.Invoke(MissingStreamNotificationType.Received);
			return;
		}
		DateTime identifierDate = new DateTime(identifier.EventDate, DateTimeKind.Utc);
		DateTime bucketedTime = BucketedTimeMinimum(identifierDate);
		string streamEntriesKey = CurrentReceiverNotificationStreamRedisCacheKey(recipient, bucketedTime, HoursPerBucket);
		if (_RedisClient.Execute(streamEntriesKey, (IDatabase db) => db.SortedSetAdd(streamEntriesKey, identifier.SourceType.ToString(), identifierDate.Ticks)))
		{
			_RedisClient.Execute(streamEntriesKey, (IDatabase db) => db.KeyExpire(streamEntriesKey, ExpirationDelay));
		}
		_UnreadCountTracker.Increment(recipient);
		_HourlyEventCountTracker.Increment(recipient, identifier.SourceType, identifierDate);
		string targetIdsKey = CurrentReceiverNotificationTargetsRedisCacheKey(recipient, bucketedTime, identifier.SourceType);
		_RedisClient.Execute(targetIdsKey, (IDatabase db) => db.ListLeftPush(targetIdsKey, identifier.EventId.ToString()));
		_RedisClient.Execute(targetIdsKey, delegate(IDatabase db)
		{
			db.ListTrim(targetIdsKey, 0L, _EventsToStorePerStreamItem - 1);
		});
		_RedisClient.Execute(targetIdsKey, (IDatabase db) => db.KeyExpire(targetIdsKey, ExpirationDelay));
		RemoveAggregatedResultsFromCache(recipient);
		_StreamNotificationRealTimeEventPublisher.PublishNewStreamNotification(recipient);
	}

	public void MarkNotificationInteracted(Guid notificationId, IReceiver receiver, bool publishToOthers)
	{
		string readKey = NotificationStreamEventIsInteractedCacheKey(notificationId, receiver);
		if (_RedisClient.Execute(readKey, (IDatabase db) => db.StringSet(readKey, true, ExpirationDelay, When.NotExists)))
		{
			RemoveAggregatedResultsFromCache(receiver);
			_StreamNotificationRealTimeEventPublisher.PublishStreamNotificationInteracted(receiver, notificationId);
		}
		if (publishToOthers)
		{
			NotificationStreamEventIdentifier identifier = RetrieveNotificationStreamEvent(notificationId);
			if (identifier == null)
			{
				NotificationStreamAccessor.OnStreamNotificationMissing?.Invoke(MissingStreamNotificationType.Interacted);
				return;
			}
			_NotificationEventPublisher.PublishUpdate(new NotificationUpdate
			{
				Receiver = receiver,
				DestinationType = ReceiverDestinationType.NotificationStream,
				Status = ReceiverNotificationStatus.Read,
				Type = identifier.SourceType,
				NotificationKey = notificationId.ToString()
			});
		}
	}

	public void RevokeNotification(Guid notificationId, IReceiver receiver)
	{
		NotificationStreamEventIdentifier identifier = RetrieveNotificationStreamEvent(notificationId);
		if (identifier == null)
		{
			RemoveAggregatedResultsFromCache(receiver);
			NotificationStreamAccessor.OnStreamNotificationMissing?.Invoke(MissingStreamNotificationType.Revoked);
			return;
		}
		DateTime identifierEventDate = new DateTime(identifier.EventDate, DateTimeKind.Utc);
		RemoveRevokedNotificationFromCurrentNotifications(receiver, identifier, _RedisClient);
		_UnreadCountTracker.DecrementIfNotificationWasUnread(receiver, identifier.EventDate);
		_HourlyEventCountTracker.Decrement(receiver, identifier.SourceType, identifierEventDate);
		RemoveAggregatedResultsFromCache(receiver);
		_StreamNotificationRealTimeEventPublisher.PublishStreamNotificationRevoked(receiver, notificationId);
	}

	private void RemoveRevokedNotificationFromCurrentNotifications(IReceiver receiver, NotificationStreamEventIdentifier identifier, IRedisClient redisClient)
	{
		DateTime bucketedTime = BucketedTimeMinimum(new DateTime(identifier.EventDate, DateTimeKind.Utc));
		string listCacheKey = CurrentReceiverNotificationTargetsRedisCacheKey(receiver, bucketedTime, identifier.SourceType);
		List<Guid> currentItems = (from s in redisClient.Execute(listCacheKey, (IDatabase db) => db.ListRange(listCacheKey, 0L, _EventsToStorePerStreamItem - 1))
			select Guid.Parse(s)).ToList();
		Guid itemToRemove = currentItems.FirstOrDefault((Guid ci) => ci == identifier.EventId);
		if (itemToRemove == Guid.Empty)
		{
			return;
		}
		List<NotificationStreamEventIdentifier> currentEvents = (from currentEvent in currentItems.Select(RetrieveNotificationStreamEvent)
			where currentEvent != null
			select currentEvent).ToList();
		redisClient.Execute(listCacheKey, (IDatabase db) => db.ListRemove(listCacheKey, itemToRemove.ToString(), 0L));
		currentEvents.Remove(currentEvents.FirstOrDefault((NotificationStreamEventIdentifier ce) => ce.EventId == itemToRemove));
		if (!currentEvents.Any())
		{
			return;
		}
		string streamEntriesKey = CurrentReceiverNotificationStreamRedisCacheKey(receiver, bucketedTime, HoursPerBucket);
		if (redisClient.Execute(streamEntriesKey, (IDatabase db) => db.SortedSetAdd(streamEntriesKey, identifier.SourceType.ToString(), currentEvents.Max((NotificationStreamEventIdentifier e) => e.EventDate))))
		{
			redisClient.Execute(streamEntriesKey, (IDatabase db) => db.KeyExpire(streamEntriesKey, ExpirationDelay));
		}
	}

	private void SetAggregatedResultsInCache(IReceiver receiver, DateTime populationBucketTime, List<NotificationStreamEventGroup> bucketResults)
	{
		try
		{
			string bucketResultsCacheKey = AggregatedRecentNotificationsCacheKey(receiver, populationBucketTime);
			_LruCacheRedisClient.Execute(bucketResultsCacheKey, (IDatabase db) => db.StringSet(bucketResultsCacheKey, JsonConvert.SerializeObject(bucketResults), _AggregatedBucketCacheExpiration));
		}
		catch (Exception exception)
		{
			_Logger.Error(new NotificationStreamAggregatedResultCacheException("Error setting cache", exception));
		}
	}

	private List<NotificationStreamEventGroup> GetAggregatedResultsFromCache(IReceiver receiver, DateTime populationBucketTime)
	{
		try
		{
			string bucketResultsCacheKey = AggregatedRecentNotificationsCacheKey(receiver, populationBucketTime);
			RedisValue cachedResultString = _LruCacheRedisClient.Execute(bucketResultsCacheKey, (IDatabase db) => db.StringGet(bucketResultsCacheKey));
			if (!string.IsNullOrWhiteSpace(cachedResultString))
			{
				return JsonConvert.DeserializeObject<List<NotificationStreamEventGroup>>(cachedResultString);
			}
		}
		catch (Exception exception)
		{
			_Logger.Error(new NotificationStreamAggregatedResultCacheException("Error looking up cached results", exception));
		}
		return new List<NotificationStreamEventGroup>();
	}

	private void RemoveAggregatedResultsFromCache(IReceiver receiver)
	{
		DateTime now = Now;
		DateTime bucket = BucketedTimeMinimum(now);
		while (bucket.Add(ExpirationDelay) > now)
		{
			string key = AggregatedRecentNotificationsCacheKey(receiver, bucket);
			_LruCacheRedisClient.Execute(key, (IDatabase db) => db.KeyDelete(key));
			bucket = bucket.AddHours(-1 * HoursPerBucket);
		}
	}

	internal virtual NotificationStreamEventIdentifier RetrieveNotificationStreamEvent(Guid notificationId)
	{
		string key = NotificationStreamEventCacheKey(notificationId);
		Dictionary<RedisValue, RedisValue> hashEntriesDictionary = _RedisClient.Execute(key, (IDatabase db) => db.HashGetAll(key)).ToDictionary();
		if (!hashEntriesDictionary.ContainsKey("EventDate") || !hashEntriesDictionary.ContainsKey("SourceType") || !hashEntriesDictionary.ContainsKey("EventTargetId"))
		{
			return null;
		}
		return new NotificationStreamEventIdentifier
		{
			EventId = notificationId,
			EventDate = (long)hashEntriesDictionary["EventDate"],
			SourceType = (NotificationSourceType)Enum.Parse(typeof(NotificationSourceType), hashEntriesDictionary["SourceType"]),
			EventTarget = hashEntriesDictionary["EventTargetId"].ToString()
		};
	}

	private bool IsNotificationInteracted(Guid notificationId, IReceiver receiver)
	{
		string key = NotificationStreamEventIsInteractedCacheKey(notificationId, receiver);
		return _RedisClient.Execute(key, (IDatabase db) => db.StringGet(key)) != RedisValue.Null;
	}

	private NotificationStreamEventGroup ConvertToNotificationStreamGroup(SortedSetEntry entry)
	{
		NotificationSourceType sourceType = (NotificationSourceType)Enum.Parse(typeof(NotificationSourceType), entry.Element);
		return new NotificationStreamEventGroup
		{
			EventDate = new DateTime((long)entry.Score, DateTimeKind.Utc),
			SourceType = sourceType
		};
	}

	private NotificationStreamEventGroup HydrateNotificationStreamGroup(NotificationStreamEventGroup eventGroup, IReceiver receiver, DateTime currentTime)
	{
		DateTime bucketDate = BucketedTimeMinimum(eventGroup.EventDate);
		bucketDate.AddHours(HoursPerBucket);
		eventGroup.EventCount = _HourlyEventCountTracker.GetCount(receiver, eventGroup.SourceType, bucketDate, HoursPerBucket);
		string listEntriesKey = CurrentReceiverNotificationTargetsRedisCacheKey(receiver, bucketDate, eventGroup.SourceType);
		List<NotificationStreamEventIdentifier> rawEvents = (from le in _RedisClient.Execute(listEntriesKey, (IDatabase db) => db.ListRange(listEntriesKey, 0L, _EventsToStorePerStreamItem - 1))
			select RetrieveNotificationStreamEvent(Guid.Parse(le)) into rawEvent
			where rawEvent != null
			select rawEvent).ToList();
		HashSet<string> alreadyPresentList = new HashSet<string>();
		eventGroup.Events = (from re in rawEvents
			select alreadyPresentList.Add(re.EventTarget) ? new NotificationStreamEvent
			{
				EventId = re.EventId,
				EventTargetId = re.EventTarget,
				IsInteracted = IsNotificationInteracted(re.EventId, receiver)
			} : null into r
			where r != null
			select r).ToList();
		eventGroup.EventCount = Math.Max(eventGroup.EventCount, eventGroup.Events.Count);
		return eventGroup;
	}

	internal DateTime BucketedTimeMinimum(DateTime rawTime)
	{
		rawTime = new DateTime(rawTime.Year, rawTime.Month, rawTime.Day, rawTime.Hour, 0, 0, DateTimeKind.Utc);
		int bucket = (int)(rawTime - _Epoch).TotalHours / HoursPerBucket;
		return _Epoch.AddHours(bucket * HoursPerBucket);
	}

	private string NotificationStreamEventIsInteractedCacheKey(Guid notificationId, IReceiver receiver)
	{
		return $"NotificationStream_IsRead_NotificationId:{notificationId}_ReceiverId:{receiver.Id}";
	}

	private string NotificationStreamEventCacheKey(Guid notificationId)
	{
		return $"NotificationStreamEvents_NotificationId:{notificationId}";
	}

	private string CurrentReceiverNotificationStreamRedisCacheKey(IReceiver receiver, DateTime bucketedTime, int hoursPerBucket)
	{
		return $"NotificationStreamEntries_ReceiverID:{receiver.Id}_StartTime:{bucketedTime.Ticks}_HoursPerBucket:{hoursPerBucket}";
	}

	private string CurrentReceiverNotificationTargetsRedisCacheKey(IReceiver receiver, DateTime bucketedTime, NotificationSourceType sourceType)
	{
		return $"NotificationStreamTargets_ReceiverID:{receiver.Id}_StartTime:{bucketedTime.Ticks}_Source:{sourceType}";
	}

	private string ReceiverNotificationStreamTimeBucketedCounterCacheKey(IReceiver receiver, NotificationSourceType sourceType)
	{
		return $"NotificationStreamEventCount_Receiver:{receiver.Id}_SourceType:{sourceType}";
	}

	private string AggregatedRecentNotificationsCacheKey(IReceiver receiver, DateTime bucketedTime)
	{
		return $"NotificationStream_AggregatedRecentsResult_ReceiverID:{receiver.Id}_Start:{bucketedTime.Ticks}";
	}
}
