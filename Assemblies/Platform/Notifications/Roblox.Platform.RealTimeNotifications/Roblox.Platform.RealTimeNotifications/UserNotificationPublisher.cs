using System;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;
using Roblox.EventLog;
using Roblox.RealTimeNotifications.Properties;
using Roblox.Redis;

namespace Roblox.RealTimeNotifications;

public class UserNotificationPublisher<T> : IUserNotificationPublisher<T> where T : UserNotificationMessageBase
{
	/// <summary>
	/// Event handler for user notification publish.
	/// </summary>
	/// <param name="result"></param>
	/// <param name="recipients"></param>
	public delegate void UserNotificationPublishEventHandler(UserNotificationPublishResult result, long recipients);

	private readonly ILogger _Logger;

	private readonly string _NotificationNamespace;

	private readonly UserNotificationPubSub _PubSub;

	private readonly UserNotificationSequenceTracker _UserNotificationSequenceTracker;

	/// <summary>
	/// Callback methods when user notification is published.
	/// </summary>
	public event UserNotificationPublishEventHandler OnUserNotificationPublished;

	/// <summary>
	///
	/// </summary>
	/// <param name="logger">Logger for the application</param>
	/// <param name="notificationNamespace"> Represents the namespace for the notification. 
	/// For example: FriendshipEvents would be the namespace while the notificationDetail would contain a Type FriendshipCreated or FriendshipDestroyed
	/// </param>
	public UserNotificationPublisher(ILogger logger, string notificationNamespace)
	{
		_Logger = logger;
		_NotificationNamespace = notificationNamespace;
		IRedisClient redisClient = UserNotificationRedisClientProvider.GetRedisClient(logger);
		_PubSub = new UserNotificationPubSub(redisClient);
		_UserNotificationSequenceTracker = new UserNotificationSequenceTracker(redisClient, _Logger);
	}

	/// <summary>
	/// create a user notification publisher object for a specific namespace with a redis client passed in as input
	/// </summary>
	/// <param name="logger">Logger for the application</param>
	/// <param name="notificationNamespace"> Represents the namespace for the notification. 
	/// For example: FriendshipEvents would be the namespace while the notificationDetail would contain a Type FriendshipCreated or FriendshipDestroyed</param>        
	/// <param name="redisClient">redis client to publish notifications <see cref="T:Roblox.Redis.IRedisClient" /></param>
	public UserNotificationPublisher(ILogger logger, string notificationNamespace, IRedisClient redisClient)
	{
		if (redisClient == null)
		{
			throw new ArgumentNullException("redisClient");
		}
		_Logger = logger;
		_NotificationNamespace = notificationNamespace;
		_PubSub = new UserNotificationPubSub(redisClient);
		_UserNotificationSequenceTracker = new UserNotificationSequenceTracker(redisClient, _Logger);
	}

	/// <summary>
	/// Publishes a notification for the specified message. Returns true if there were any subscriptions active for that user
	/// </summary>
	/// <param name="userId"></param>
	/// <param name="message"></param>
	/// <param name="sequenceNumberToPublishMessageWith"></param>
	/// <param name="namespaceSequenceNumberToPublishMessageWith"></param>
	/// <returns>True if there were any active subscribers</returns>
	public UserNotificationPublishResult Publish(long userId, T message, long? sequenceNumberToPublishMessageWith = null, long? namespaceSequenceNumberToPublishMessageWith = null)
	{
		try
		{
			UpdateNamespaceSequenceNumber(message, userId, out var namespaceSequenceNumberForPublishedMessage, namespaceSequenceNumberToPublishMessageWith);
			return Publish(userId, JsonConvert.SerializeObject(message), out namespaceSequenceNumberForPublishedMessage, sequenceNumberToPublishMessageWith);
		}
		catch (Exception exception)
		{
			_Logger.Error(exception);
			FireOnUserNotificationPublishedEvent(UserNotificationPublishResult.ErrorPublishingNotification, 0L);
			return UserNotificationPublishResult.ErrorPublishingNotification;
		}
	}

	/// <summary>
	/// Publishes a notification for the specified message(collection of events). Returns true if there were any subscriptions active for that user
	/// </summary>
	/// <param name="userId"> notification recipient</param>
	/// <param name="message">message to publish</param>
	/// <param name="sequenceNumberForPublishedMessage"> out variable populated with sequence number of the message (if published) for userId</param>
	/// <param name="namespaceSequenceNumberForPublishedMessage"></param>
	/// <param name="sequenceNumberToPublishMessageWith"> null by default, will increment the sequence number in that case</param>
	/// <param name="namespaceSequenceNumberToPublishMessageWith"></param>
	/// <returns></returns>
	public UserNotificationPublishResult Publish(long userId, IReadOnlyCollection<T> message, out long? sequenceNumberForPublishedMessage, out long? namespaceSequenceNumberForPublishedMessage, long? sequenceNumberToPublishMessageWith = null, long? namespaceSequenceNumberToPublishMessageWith = null)
	{
		sequenceNumberForPublishedMessage = null;
		namespaceSequenceNumberForPublishedMessage = null;
		try
		{
			UpdateNamespaceSequenceNumber(message, userId, out namespaceSequenceNumberForPublishedMessage, namespaceSequenceNumberToPublishMessageWith);
			return Publish(userId, JsonConvert.SerializeObject(message), out sequenceNumberForPublishedMessage, sequenceNumberToPublishMessageWith);
		}
		catch (Exception exception)
		{
			_Logger.Error(exception);
			FireOnUserNotificationPublishedEvent(UserNotificationPublishResult.ErrorPublishingNotification, 0L);
			return UserNotificationPublishResult.ErrorPublishingNotification;
		}
	}

	/// <summary>
	/// Publishes a notification for the specified message. Returns true if there were any subscriptions active for that user
	/// </summary>
	/// <param name="userId">Id of the notification recipient</param>
	/// <param name="serializedMessage">Serialized string of message to publish</param>
	/// <param name="sequenceNumberForPublishedMessage">Out variable populated with sequence number of the message (if published) for userId</param>
	/// <param name="sequenceNumberToPublishMessageWith">Null by default, will increment the sequence number in that case</param>
	/// <returns></returns>
	public UserNotificationPublishResult Publish(long userId, string serializedMessage, out long? sequenceNumberForPublishedMessage, long? sequenceNumberToPublishMessageWith = null)
	{
		sequenceNumberForPublishedMessage = null;
		if (userId > 0)
		{
			long sequenceNumber = sequenceNumberToPublishMessageWith ?? _UserNotificationSequenceTracker.IncrementUserNotificationSequenceNumber(userId);
			long recipients = _PubSub.Publish(userId, new UserNotification(_NotificationNamespace, serializedMessage, sequenceNumber));
			sequenceNumberForPublishedMessage = sequenceNumber;
			UserNotificationPublishResult result = ((recipients <= 0) ? UserNotificationPublishResult.UserDidNotReceiveNotification : UserNotificationPublishResult.UserReceivedNotification);
			FireOnUserNotificationPublishedEvent(result, recipients);
			return result;
		}
		FireOnUserNotificationPublishedEvent(UserNotificationPublishResult.InvalidUser, 0L);
		return UserNotificationPublishResult.InvalidUser;
	}

	private void UpdateNamespaceSequenceNumber(IReadOnlyCollection<T> userNotifications, long userId, out long? namespaceSequenceNumberForPublishedMessage, long? namespaceSequenceNumberToPublishMessageWith = null)
	{
		namespaceSequenceNumberForPublishedMessage = null;
		if (!Settings.Default.IsUserNotificationNamespaceSequenceEnabled || userNotifications == null || userNotifications.Count <= 0 || userNotifications.First() == null || !userNotifications.First().IsIncrementSequenceNumberEnabled)
		{
			return;
		}
		long namespaceSequenceNumber = namespaceSequenceNumberToPublishMessageWith ?? _UserNotificationSequenceTracker.IncrementUserNotificationNamespaceSequenceNumber(_NotificationNamespace, userId);
		foreach (T userNotification in userNotifications)
		{
			userNotification.SequenceNumber = namespaceSequenceNumber;
		}
		namespaceSequenceNumberForPublishedMessage = namespaceSequenceNumber;
	}

	private void UpdateNamespaceSequenceNumber(T userNotification, long userId, out long? namespaceSequenceNumberForPublishedMessage, long? namespaceSequenceNumberToPublishMessageWith = null)
	{
		namespaceSequenceNumberForPublishedMessage = null;
		if (Settings.Default.IsUserNotificationNamespaceSequenceEnabled && userNotification.IsIncrementSequenceNumberEnabled)
		{
			long namespaceSequenceNumber = (userNotification.SequenceNumber = namespaceSequenceNumberToPublishMessageWith ?? _UserNotificationSequenceTracker.IncrementUserNotificationNamespaceSequenceNumber(_NotificationNamespace, userId));
			namespaceSequenceNumberForPublishedMessage = namespaceSequenceNumber;
		}
	}

	private void FireOnUserNotificationPublishedEvent(UserNotificationPublishResult result, long recipients)
	{
		try
		{
			this.OnUserNotificationPublished?.Invoke(result, recipients);
		}
		catch (Exception ex)
		{
			_Logger.Error($"Error in FireOnUserNotificationPublishedEvent({recipients}) - {ex}");
		}
	}
}
