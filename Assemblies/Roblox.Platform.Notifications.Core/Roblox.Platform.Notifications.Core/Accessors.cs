namespace Roblox.Platform.Notifications.Core;

public static class Accessors
{
	public static INotificationTypeTranslator NotificationTypeTranslator { get; private set; }

	public static IReceiverAccessor ReceiverAccessor { get; private set; }

	static Accessors()
	{
		NotificationTypeTranslator = new NotificationTypeTranslator();
		ReceiverAccessor = new ReceiverAccessor();
	}
}
