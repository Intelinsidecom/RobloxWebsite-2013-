using Roblox.Platform.EventStream.WebEvents.EventArgs;

namespace Roblox.Platform.EventStream.WebEvents.Events;

public class AssetTypeHeaderMismatchEvent : WebEventBase
{
	private const string _Name = "assetTypeHeaderMismatch";

	public AssetTypeHeaderMismatchEvent(IEventStreamer streamer, AssetTypeHeaderMismatchEventArgs args)
		: base(streamer, "assetTypeHeaderMismatch", args)
	{
		AddEventArg("actual", args.ActualType);
		AddEventArg("expected", args.ExpectedType);
		AddEventArg("assetId", args.AssetId.ToString());
	}
}
