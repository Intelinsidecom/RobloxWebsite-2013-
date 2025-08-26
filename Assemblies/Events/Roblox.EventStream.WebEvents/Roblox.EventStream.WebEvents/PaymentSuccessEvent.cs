using Roblox.EventStream.WebEvents.EventArgs;
namespace Roblox.EventStream.WebEvents {
    public class PaymentSuccessEvent : WebEventBase

{
	private const string _Name = "paymentSuccess";

	public PaymentSuccessEvent(IEventStreamer streamer, PaymentSuccessEventArgs eventArgs)
		: base(streamer, "paymentSuccess", eventArgs)
	{
		AddEventArg("pids", string.Join(",", eventArgs.ProductIds));
	}
}


}






