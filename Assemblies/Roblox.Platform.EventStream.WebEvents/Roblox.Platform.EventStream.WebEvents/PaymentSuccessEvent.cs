namespace Roblox.Platform.EventStream.WebEvents;

public class PaymentSuccessEvent : WebEventBase
{
	private const string _Name = "paymentSuccess";

	public PaymentSuccessEvent(EventStreamer streamer, PaymentSuccessEventArgs eventArgs)
		: base(streamer, "paymentSuccess", eventArgs)
	{
		AddEventArg("pids", string.Join(",", eventArgs.ProductIds));
	}
}
