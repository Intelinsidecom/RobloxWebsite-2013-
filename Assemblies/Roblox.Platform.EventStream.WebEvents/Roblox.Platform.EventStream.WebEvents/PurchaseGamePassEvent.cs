namespace Roblox.Platform.EventStream.WebEvents;

/// <summary>
/// Represents an event for when a game pass purchase was attempted
/// </summary>
public class PurchaseGamePassEvent : PurchaseEventBase
{
	private const string _Name = "purchaseGamePass";

	public PurchaseGamePassEvent(EventStreamer streamer, PurchaseGamePassEventArgs args)
		: base(streamer, "purchaseGamePass", args)
	{
		AddEventArg("gamePassId", args.GamePassId.ToString());
	}
}
