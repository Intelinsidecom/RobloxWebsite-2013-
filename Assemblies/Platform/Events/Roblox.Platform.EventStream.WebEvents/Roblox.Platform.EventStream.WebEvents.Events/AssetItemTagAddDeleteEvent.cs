using Roblox.Platform.EventStream.WebEvents.EventArgs;

namespace Roblox.Platform.EventStream.WebEvents.Events;

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
