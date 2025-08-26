using Roblox.EventStream.WebEvents.EventArgs;
namespace Roblox.EventStream.WebEvents.Events {
    /// <inheritdoc />

/// Additionally, includes event args specific to Assets
public class AssetItemTagAddDeleteEvent : ItemTagAddDeleteEvent
{
	private const string _Name = "assetItemTagAddDeleteEvent";

	public AssetItemTagAddDeleteEvent(IEventStreamer streamer, AssetItemTagAddDeleteEventArgs eventArgs)
		: base(streamer, eventArgs, "assetItemTagAddDeleteEvent")
	{
		AddEventArgIfNotNullDoesNotThrow("assetType", eventArgs.AssetType);
	}
}


}



