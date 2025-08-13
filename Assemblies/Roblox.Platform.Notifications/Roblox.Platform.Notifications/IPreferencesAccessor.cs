using System.Collections.Generic;
using Roblox.Platform.Membership;
using Roblox.Platform.Notifications.Core;
using Roblox.Platform.Notifications.Push;

namespace Roblox.Platform.Notifications;

/// <summary>
/// Represents a class that can retrieve information about a notification receiver's preferences.
/// </summary>
public interface IPreferencesAccessor
{
	IReceiverDestinationTypeOptOut GetReceiverDestinationTypeOptOut(IReceiver receiver, ReceiverDestinationType receiverDestinationType);

	IEnumerable<IReceiverDestinationTypeOptOut> GetAllReceiverDestinationTypeOptOuts(IReceiver receiver);

	INotificationSourceTypeOptOut GetNotificationSourceTypeOptOut(IReceiver receiver, NotificationSourceType notificationSourceType);

	IEnumerable<INotificationSourceTypeOptOut> GetAllNotificationSourceTypeOptOuts(IReceiver receiver);

	INotificationBandPreference GetNotificationBandPreference(IReceiver receiver, INotificationBand notificationBand);

	IEnumerable<INotificationBandPreference> GetAllNotificationBandPreferences(IReceiver receiver);

	IReceiverDestinationPreference GetReceiverDestinationPreference(IReceiver receiver, NotificationSourceType notificationSourceType, long destinationId);

	IEnumerable<IReceiverDestinationPreference> GetAllReceiverDestinationPreferences(IReceiver receiver);

	IEnumerable<IReceiverNotificationSettingsGroup> GetAllReceiverNotificationSettings(IUser receiver, IPushRegistrar registrar);
}
