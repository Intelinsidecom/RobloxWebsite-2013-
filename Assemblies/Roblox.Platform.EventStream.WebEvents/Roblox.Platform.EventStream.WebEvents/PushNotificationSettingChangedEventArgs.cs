using Roblox.Time;

namespace Roblox.Platform.EventStream.WebEvents;

/// <summary>
/// Event Arguments for a push notification change event
/// </summary>
public class PushNotificationSettingChangedEventArgs : WebEventArgs
{
	/// <summary>
	/// The event time <see cref="T:Roblox.Time.UtcInstant" />.
	/// </summary>
	public UtcInstant EventTime { get; set; }

	/// <summary>
	/// Whether Push Notification Setting is enabled or disabled
	/// </summary>
	public bool IsEnabled { get; set; }

	/// <summary>
	/// The receiver destination type
	/// </summary>
	public string ReceiverDestinationType { get; set; }

	/// <summary>
	/// The receiver target id
	/// </summary>
	public string ReceiverDestinationId { get; set; }
}
