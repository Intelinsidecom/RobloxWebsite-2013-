using Roblox.EventLog;
using Roblox.Platform.Membership;
using Roblox.Platform.Notifications.AbTesting;
using Roblox.Platform.Notifications.Core;
using Roblox.Platform.Notifications.Stream;

namespace Roblox.Platform.Notifications;

public static class Accessors
{
	private static INotificationIdRegister _NotificationIdRegister;

	public static IPreferencesAccessor PreferencesAccessor { get; }

	public static INotificationBandAccessor NotificationBandAccessor { get; }

	public static IReceiverPreferencesManager ReceiverPreferencesManager { get; }

	public static INotificationBandManager NotificationBandManager { get; }

	internal static INotificationReceiverResolverRegistry NotificationReceiverResolverRegistry { get; }

	public static ILogger Logger { get; set; }

	public static IStreamPermissionChecker StreamPermissionChecker { get; set; }

	public static IExperimentEnrollmentAccessor ExperimentEnrollmentAccessor { get; set; }

	static Accessors()
	{
		NotificationBandAccessor = new NotificationBandAccessor();
		PreferencesAccessor = new PreferencesAccessor(NotificationBandAccessor, Roblox.Platform.Notifications.Core.Accessors.NotificationTypeTranslator);
		ReceiverPreferencesManager = new ReceiverPreferencesManager(NotificationBandAccessor, Roblox.Platform.Notifications.Core.Accessors.NotificationTypeTranslator);
		NotificationBandManager = new NotificationBandManager(NotificationBandAccessor, Roblox.Platform.Notifications.Core.Accessors.NotificationTypeTranslator);
		NotificationReceiverResolverRegistry = new NotificationReceiverResolverRegistry();
		StreamPermissionChecker = new StreamPermissionChecker();
		UserFactory userFactory = new UserFactory();
		ExperimentEnrollmentAccessor = new ExperimentEnrollmentAccessor(new Roblox.Platform.Notifications.AbTesting.ExperimentEnrollmentAccessor(Logger, userFactory));
	}

	public static INotificationIdRegister GetNotificationIdRegister(ILogger logger)
	{
		if (_NotificationIdRegister == null)
		{
			_NotificationIdRegister = new NotificationIdRegister(logger);
		}
		return _NotificationIdRegister;
	}
}
