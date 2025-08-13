namespace Roblox.Platform.EventStream.WebEvents;

public class PushNotificationRegistrationEvent : WebEventBase
{
	private const string _Name = "pushNotificationRegistration";

	public PushNotificationRegistrationEvent(EventStreamer streamer, PushNotificationRegistrationEventArgs args)
		: base(streamer, "pushNotificationRegistration", args)
	{
		base.IsTrustedSource = true;
		AddEventArg("ctx", args.Context);
		AddEventArg("platformType", args.PlatformType);
	}
}
