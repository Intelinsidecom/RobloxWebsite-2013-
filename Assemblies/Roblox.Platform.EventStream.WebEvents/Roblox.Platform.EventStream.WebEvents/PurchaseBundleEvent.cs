namespace Roblox.Platform.EventStream.WebEvents;

/// <summary>
/// Represents an event for when a bundle purchase was attempted
/// </summary>
public class PurchaseBundleEvent : PurchaseEventBase
{
	private const string _Name = "purchaseBundle";

	public PurchaseBundleEvent(EventStreamer streamer, PurchaseBundleEventArgs args)
		: base(streamer, "purchaseBundle", args)
	{
		AddEventArg("bundleId", args.BundleId.ToString());
	}
}
