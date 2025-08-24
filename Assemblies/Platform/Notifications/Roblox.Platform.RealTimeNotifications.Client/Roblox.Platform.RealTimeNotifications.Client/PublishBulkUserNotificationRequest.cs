using System.Diagnostics.CodeAnalysis;
using System.Runtime.Serialization;
using Newtonsoft.Json.Linq;

namespace Roblox.RealTimeNotifications.Client;

[DataContract]
[ExcludeFromCodeCoverage]
public class PublishBulkUserNotificationRequest
{
	[DataMember(Name = "userId")]
	public long UserId { get; set; }

	[DataMember(Name = "messages")]
	public JObject[] Messages { get; set; }

	[DataMember(Name = "notificationNamespace")]
	public string NotificationNamespace { get; set; }

	[DataMember(Name = "isIncrementSequenceNumberEnabled")]
	public bool? IsIncrementSequenceNumberEnabled { get; set; }
}
