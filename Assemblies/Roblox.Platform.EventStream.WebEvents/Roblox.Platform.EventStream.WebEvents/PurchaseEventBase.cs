namespace Roblox.Platform.EventStream.WebEvents;

/// <summary>
/// Base class for events when a purchase was attempted
/// </summary>
public abstract class PurchaseEventBase : WebEventBase
{
	protected PurchaseEventBase(IEventStreamer streamer, string eventName, PurchaseEventArgs args)
		: base(streamer, eventName, args)
	{
		AddEventArg("price", args.Price?.ToString() ?? string.Empty);
		AddEventArg("wasSuccessful", args.WasSuccessful.ToString());
		AddEventArg("failureReason", args.FailureReason ?? string.Empty);
	}
}
