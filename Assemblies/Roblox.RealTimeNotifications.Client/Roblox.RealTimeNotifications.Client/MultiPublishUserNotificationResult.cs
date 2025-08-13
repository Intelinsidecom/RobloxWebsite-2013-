using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.Serialization;

namespace Roblox.RealTimeNotifications.Client;

[DataContract]
[ExcludeFromCodeCoverage]
public class MultiPublishUserNotificationResult
{
	[DataMember(Name = "results")]
	public IReadOnlyList<(PublishUserNotificationResult Result, string ErrorCode)> Results { get; set; }
}
