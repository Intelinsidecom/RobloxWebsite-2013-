using System.Diagnostics.CodeAnalysis;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Roblox.Platform.TeamCreate.Notifications;

/// <summary>
/// The event sent to the TeamCreateEvents SNS publisher.
/// </summary>
[DataContract]
[ExcludeFromCodeCoverage]
internal class TeamCreateEvent
{
	/// <summary>
	/// The type of the event.
	/// </summary>
	[JsonConverter(typeof(StringEnumConverter))]
	[DataMember(Name = "eventType")]
	public TeamCreateEventType EventType { get; set; }

	/// <summary>
	/// A json-seralized object containing arguments based on the <see cref="P:Roblox.Platform.TeamCreate.Notifications.TeamCreateEvent.EventType" />.
	/// </summary>
	[DataMember(Name = "eventArgs")]
	public string EventArgs { get; set; }
}
