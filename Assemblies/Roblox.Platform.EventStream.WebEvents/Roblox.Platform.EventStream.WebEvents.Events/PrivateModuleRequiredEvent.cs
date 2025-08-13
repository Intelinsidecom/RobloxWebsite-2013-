using Roblox.Platform.EventStream.WebEvents.EventArgs;

namespace Roblox.Platform.EventStream.WebEvents.Events;

/// <summary>
/// Represents an event for when a private module is required.
/// </summary>
public class PrivateModuleRequiredEvent : WebEventBase
{
	private const string _Name = "privateModuleRequired";

	/// <summary>
	/// Initializes a new instance of the <see cref="T:Roblox.Platform.EventStream.WebEvents.Events.PrivateModuleRequiredEvent" />  class.
	/// </summary>
	/// <param name="streamer">The <see cref="T:Roblox.Platform.EventStream.EventStreamer" /> used to stream the event.</param>
	/// <param name="args">The <see cref="T:Roblox.Platform.EventStream.WebEvents.BasicEventArgs" /> containing event info.</param>
	public PrivateModuleRequiredEvent(EventStreamer streamer, PrivateModuleRequiredEventArgs args)
		: base(streamer, "privateModuleRequired", args)
	{
		AddEventArg("aid", args.AssetId.ToString());
		AddEventArg("pid", args.PlaceId.ToString());
	}
}
