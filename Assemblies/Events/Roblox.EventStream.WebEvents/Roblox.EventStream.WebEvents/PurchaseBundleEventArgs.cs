namespace Roblox.Platform.EventStream.WebEvents;

/// <summary>
/// Event args for Bundle Purchase event
/// </summary>
public class PurchaseBundleEventArgs : PurchaseEventArgs
{
	public long BundleId { get; set; }
}
