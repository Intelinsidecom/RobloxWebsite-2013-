using System;

namespace Roblox.Platform.EventStream;

/// <summary>
/// Interface for push notification data to be streamed to AWS Kinesis Firehose
/// </summary>
public interface IPushNotificationData
{
	/// <summary>
	/// The Event Type
	/// </summary>
	string Event { get; set; }

	/// <summary>
	/// The time of the event
	/// </summary>
	DateTime DateTime { get; set; }

	/// <summary>
	/// The receiver destination id
	/// </summary>
	long ReceiverDestinationId { get; set; }

	/// <summary>
	/// The notification id
	/// </summary>
	string NotificationId { get; set; }

	/// <summary>
	/// The push notification intent
	/// </summary>
	string PushNotificationIntent { get; set; }

	/// <summary>
	/// The notification source type
	/// </summary>
	string NotificationSourceType { get; set; }
}
