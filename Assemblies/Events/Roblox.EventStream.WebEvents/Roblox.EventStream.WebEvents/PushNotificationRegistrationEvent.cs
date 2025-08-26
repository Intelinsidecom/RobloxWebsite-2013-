using Roblox.EventStream.WebEvents.EventArgs;
namespace Roblox.EventStream.WebEvents {
    public class PushNotificationRegistrationEvent : WebEventBase

{
	private const string _Name = "pushNotificationRegistration";

	public PushNotificationRegistrationEvent(IEventStreamer streamer, PushNotificationRegistrationEventArgs args)
		: base(streamer, "pushNotificationRegistration", args)
	{
		base.IsTrustedSource = true;
		AddEventArg("ctx", args.Context);
		AddEventArg("platformType", args.PlatformType);
	}
}


}






