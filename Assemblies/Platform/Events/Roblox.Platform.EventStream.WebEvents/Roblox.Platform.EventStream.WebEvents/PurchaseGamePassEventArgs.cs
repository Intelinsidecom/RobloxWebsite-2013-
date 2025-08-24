namespace Roblox.Platform.EventStream.WebEvents;

/// <summary>
/// Event args for Game Pass Purchase event
/// </summary>
public class PurchaseGamePassEventArgs : PurchaseEventArgs
{
	public long GamePassId { get; set; }
}
