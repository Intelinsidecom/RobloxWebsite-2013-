using System;
using Newtonsoft.Json;

namespace Roblox.Platform.EventStream;

public class PushNotificationData : IPushNotificationData
{
	[JsonProperty(PropertyName = "evt")]
	public string Event { get; set; }

	[JsonProperty(PropertyName = "datetime")]
	public DateTime DateTime { get; set; }

	[JsonProperty(PropertyName = "receiverDestinationId")]
	public long ReceiverDestinationId { get; set; }

	[JsonProperty(PropertyName = "notificationId")]
	public string NotificationId { get; set; }

	[JsonProperty(PropertyName = "pushNotificationIntent")]
	public string PushNotificationIntent { get; set; }

	[JsonProperty(PropertyName = "notificationSourceType")]
	public string NotificationSourceType { get; set; }
}
