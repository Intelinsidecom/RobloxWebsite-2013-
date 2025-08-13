using System;
using Roblox.EventLog;
using Roblox.Platform.AbTesting;
using Roblox.Platform.Membership;
using Roblox.Platform.Notifications.AbTesting.Properties;
using Roblox.Platform.Notifications.Core;

namespace Roblox.Platform.Notifications.AbTesting;

public class ExperimentEnrollmentAccessor : IExperimentEnrollmentAccessor
{
	private ILogger _Logger;

	private IUserFactory _UserFactory;

	public ExperimentEnrollmentAccessor(ILogger Logger, IUserFactory userFactory)
	{
		_Logger = Logger;
		_UserFactory = userFactory ?? throw new ArgumentNullException("userFactory");
	}

	public bool IsFriendRequestPushNotificationEnabled(IReceiver receiver)
	{
		int? variation = null;
		try
		{
			variation = ((receiver.ReceiverType == ReceiverType.User) ? _UserFactory.GetUser(receiver.ReceiverTargetId) : null)?.GetActiveEnrollmentTranslated(Settings.Default.FriendRequestPushNotificationDefaultEnrollmentExperimentName);
		}
		catch (Exception exception)
		{
			_Logger.Error(exception);
		}
		return variation == Settings.Default.VariationToEnableFriendRequestPushNotification;
	}
}
