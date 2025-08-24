using System.Collections.Generic;

namespace Roblox.RealTimeNotifications;

public interface IUserNotificationPublisher<T> where T : UserNotificationMessageBase
{
	/// <summary>
	/// Publishes a notification for the specified message. Returns true if there were any subscriptions active for that user
	/// </summary>
	/// <param name="userId"></param>
	/// <param name="message"></param>
	/// <param name="sequenceNumberToPublishMessageWith"></param>
	/// <param name="namespaceSequenceNumberToPublishMessageWith"></param>
	/// <returns>True if there were any active subscribers</returns>
	UserNotificationPublishResult Publish(long userId, T message, long? sequenceNumberToPublishMessageWith = null, long? namespaceSequenceNumberToPublishMessageWith = null);

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
	UserNotificationPublishResult Publish(long userId, IReadOnlyCollection<T> message, out long? sequenceNumberForPublishedMessage, out long? namespaceSequenceNumberForPublishedMessage, long? sequenceNumberToPublishMessageWith = null, long? namespaceSequenceNumberToPublishMessageWith = null);

	/// <summary>
	/// Publishes a notification for the specified message. Returns true if there were any subscriptions active for that user
	/// </summary>
	/// <param name="userId">Id of the notification recipient</param>
	/// <param name="serializedMessage">Serialized string of message to publish</param>
	/// <param name="sequenceNumberForPublishedMessage">Out variable populated with sequence number of the message (if published) for userId</param>
	/// <param name="sequenceNumberToPublishMessageWith">Null by default, will increment the sequence number in that case</param>
	/// <returns></returns>
	UserNotificationPublishResult Publish(long userId, string serializedMessage, out long? sequenceNumberForPublishedMessage, long? sequenceNumberToPublishMessageWith = null);
}
