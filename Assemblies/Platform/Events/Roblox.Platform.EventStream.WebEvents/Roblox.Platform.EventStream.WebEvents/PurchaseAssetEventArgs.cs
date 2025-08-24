namespace Roblox.Platform.EventStream.WebEvents;

/// <summary>
/// Event args for Asset purchase event
/// </summary>
public class PurchaseAssetEventArgs : PurchaseEventArgs
{
	public long AssetId { get; set; }
}
