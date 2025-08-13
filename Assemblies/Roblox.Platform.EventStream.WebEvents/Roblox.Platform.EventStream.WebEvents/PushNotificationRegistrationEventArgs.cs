namespace Roblox.Platform.EventStream.WebEvents;

public class PushNotificationRegistrationEventArgs : WebEventArgs
{
	public string Context { get; set; }

	public string PlatformType { get; set; }
}
