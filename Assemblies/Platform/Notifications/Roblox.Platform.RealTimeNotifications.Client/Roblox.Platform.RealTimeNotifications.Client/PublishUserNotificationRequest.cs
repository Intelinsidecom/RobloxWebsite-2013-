using System.Diagnostics.CodeAnalysis;
using System.Runtime.Serialization;
using Newtonsoft.Json.Linq;

namespace Roblox.RealTimeNotifications.Client;

[DataContract]
[ExcludeFromCodeCoverage]
internal class PublishUserNotificationRequest
{
	[DataMember(Name = "userId")]
	public long UserId { get; set; }

	[DataMember(Name = "message")]
	public JObject Message { get; set; }

	[DataMember(Name = "notificationNamespace")]
	public string NotificationNamespace { get; set; }

	[DataMember(Name = "isIncrementSequenceNumberEnabled")]
	public bool? IsIncrementSequenceNumberEnabled { get; set; }
}
