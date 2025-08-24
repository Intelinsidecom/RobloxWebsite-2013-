namespace Roblox.Platform.EventStream.WebEvents;

/// <summary>
/// Represents an event for logging device initialize.
/// </summary>
public class DeviceInitializeEvent : WebEventBase
{
	private const string _Name = "deviceInitialize";

	public DeviceInitializeEvent(EventStreamer streamer, WebEventArgs args)
		: base(streamer, "deviceInitialize", args)
	{
	}
}
