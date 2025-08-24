using System.Diagnostics.CodeAnalysis;
using System.Runtime.Serialization;

namespace Roblox.RealTimeNotifications.Client;

[DataContract]
[ExcludeFromCodeCoverage]
public class PublishUserNotificationResult
{
	[DataMember(Name = "status")]
	public PublishUserNotificationResultStatus Status { get; set; }
}
