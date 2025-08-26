using Roblox.EventStream.WebEvents.EventArgs;
namespace Roblox.EventStream.WebEvents {
    /// <summary>

/// Represents an event for when an asset purchase was attempted
/// </summary>
public class PurchaseAssetEvent : PurchaseEventBase
{
	private const string _Name = "purchaseAsset";

	public PurchaseAssetEvent(IEventStreamer streamer, PurchaseAssetEventArgs args)
		: base(streamer, "purchaseAsset", args)
	{
		AddEventArg("assetId", args.AssetId.ToString());
	}
}


}






