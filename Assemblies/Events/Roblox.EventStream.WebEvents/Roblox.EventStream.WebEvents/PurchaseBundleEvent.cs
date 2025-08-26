using Roblox.EventStream.WebEvents.EventArgs;
namespace Roblox.EventStream.WebEvents {
    /// <summary>

/// Represents an event for when a bundle purchase was attempted
/// </summary>
public class PurchaseBundleEvent : PurchaseEventBase
{
	private const string _Name = "purchaseBundle";

	public PurchaseBundleEvent(IEventStreamer streamer, PurchaseBundleEventArgs args)
		: base(streamer, "purchaseBundle", args)
	{
		AddEventArg("bundleId", args.BundleId.ToString());
	}
}


}






