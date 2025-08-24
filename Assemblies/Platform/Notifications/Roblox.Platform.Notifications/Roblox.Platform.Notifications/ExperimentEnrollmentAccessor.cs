using Roblox.Platform.Notifications.AbTesting;
using Roblox.Platform.Notifications.Core;

namespace Roblox.Platform.Notifications;

public class ExperimentEnrollmentAccessor : IExperimentEnrollmentAccessor
{
	private readonly Roblox.Platform.Notifications.AbTesting.IExperimentEnrollmentAccessor _AbTestingAccessor;

	public ExperimentEnrollmentAccessor(Roblox.Platform.Notifications.AbTesting.IExperimentEnrollmentAccessor abTestingAccessor)
	{
		_AbTestingAccessor = abTestingAccessor;
	}

	private bool IsFriendRequestPushNotificationEnabled(IReceiver receiver, INotificationBand notificationBand)
	{
		if (notificationBand.NotificationSourceType == NotificationSourceType.FriendRequestReceived && notificationBand.ReceiverDestinationType == ReceiverDestinationType.MobilePush)
		{
			if (receiver != null)
			{
				return _AbTestingAccessor.IsFriendRequestPushNotificationEnabled(receiver);
			}
			return false;
		}
		return false;
	}

	public bool IsNotificationEnabled(IReceiver receiver, INotificationBand notificationBand)
	{
		if (!notificationBand.IsEnabledByDefault)
		{
			return IsFriendRequestPushNotificationEnabled(receiver, notificationBand);
		}
		return true;
	}
}
