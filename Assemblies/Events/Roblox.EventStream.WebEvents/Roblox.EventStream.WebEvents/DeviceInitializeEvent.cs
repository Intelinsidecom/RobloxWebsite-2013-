using Roblox.EventStream.WebEvents.EventArgs;
namespace Roblox.EventStream.WebEvents {
    /// <summary>

/// Represents an event for logging device initialize.
/// </summary>
public class DeviceInitializeEvent : WebEventBase
{
	private const string _Name = "deviceInitialize";

	public DeviceInitializeEvent(IEventStreamer streamer, WebEventArgs args)
		: base(streamer, "deviceInitialize", args)
	{
	}
}


}






