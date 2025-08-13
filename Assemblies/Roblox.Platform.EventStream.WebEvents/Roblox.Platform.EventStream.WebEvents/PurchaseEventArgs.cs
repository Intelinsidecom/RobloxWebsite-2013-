namespace Roblox.Platform.EventStream.WebEvents;

/// <summary>
/// Base class for purchase events
/// </summary>
public class PurchaseEventArgs : WebEventArgs
{
	public long? Price { get; set; }

	public bool WasSuccessful { get; set; }

	public string FailureReason { get; set; }
}
