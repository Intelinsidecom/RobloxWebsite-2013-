using Roblox.Platform.Core;
using Roblox.Platform.Notifications.Core;
using Roblox.Platform.Notifications.Entities;

namespace Roblox.Platform.Notifications;

public class ReceiverPreferencesManager : IReceiverPreferencesManager
{
	private readonly INotificationBandAccessor _NotificationBandAccessor;

	private readonly INotificationTypeTranslator _NotificationTypeTranslator;

	public ReceiverPreferencesManager()
		: this(Accessors.NotificationBandAccessor, Roblox.Platform.Notifications.Core.Accessors.NotificationTypeTranslator)
	{
	}

	internal ReceiverPreferencesManager(INotificationBandAccessor notificationBandAccessor, INotificationTypeTranslator notificationTypeTranslator)
	{
		_NotificationBandAccessor = notificationBandAccessor;
		_NotificationTypeTranslator = notificationTypeTranslator;
	}

	public void OptOutOfReceiverDestinationType(IReceiver receiver, ReceiverDestinationType destinationType)
	{
		short destinationTypeEntityId = _NotificationTypeTranslator.ToEntityId(destinationType);
		if (Roblox.Platform.Notifications.Entities.ReceiverDestinationTypeOptOut.GetByReceiverIDAndReceiverDestinationTypeID(receiver.Id, destinationTypeEntityId) == null)
		{
			Roblox.Platform.Notifications.Entities.ReceiverDestinationTypeOptOut receiverDestinationTypeOptOut = new Roblox.Platform.Notifications.Entities.ReceiverDestinationTypeOptOut();
			receiverDestinationTypeOptOut.ReceiverID = receiver.Id;
			receiverDestinationTypeOptOut.ReceiverDestinationTypeID = destinationTypeEntityId;
			receiverDestinationTypeOptOut.Save();
		}
	}

	public void AllowReceiverDestinationTypeNotifications(IReceiver receiver, ReceiverDestinationType destinationType)
	{
		short destinationTypeEntityId = _NotificationTypeTranslator.ToEntityId(destinationType);
		Roblox.Platform.Notifications.Entities.ReceiverDestinationTypeOptOut.GetByReceiverIDAndReceiverDestinationTypeID(receiver.Id, destinationTypeEntityId)?.Delete();
	}

	public void OptOutOfNotificationSourceType(IReceiver receiver, NotificationSourceType notificationSourceType)
	{
		short sourceTypeEntityId = _NotificationTypeTranslator.ToEntityId(notificationSourceType);
		if (Roblox.Platform.Notifications.Entities.NotificationSourceTypeOptOut.GetByReceiverIDAndNotificationSourceTypeID(receiver.Id, sourceTypeEntityId) == null)
		{
			Roblox.Platform.Notifications.Entities.NotificationSourceTypeOptOut notificationSourceTypeOptOut = new Roblox.Platform.Notifications.Entities.NotificationSourceTypeOptOut();
			notificationSourceTypeOptOut.ReceiverID = receiver.Id;
			notificationSourceTypeOptOut.NotificationSourceTypeID = sourceTypeEntityId;
			notificationSourceTypeOptOut.Save();
		}
	}

	public void AllowNotificationSourceTypeNotifications(IReceiver receiver, NotificationSourceType notificationSourceType)
	{
		short sourceTypeEntityId = _NotificationTypeTranslator.ToEntityId(notificationSourceType);
		Roblox.Platform.Notifications.Entities.NotificationSourceTypeOptOut.GetByReceiverIDAndNotificationSourceTypeID(receiver.Id, sourceTypeEntityId)?.Delete();
	}

	public void SetNotificationBandPreference(IReceiver receiver, NotificationSourceType notificationSourceType, ReceiverDestinationType receiverDestinationType, bool isEnabled)
	{
		INotificationBand notificationBand = _NotificationBandAccessor.GetByNotificationSourceTypeAndReceiverDestinationType(notificationSourceType, receiverDestinationType);
		if (!notificationBand.IsOverridable)
		{
			throw new PlatformArgumentException("The supplied notificationBand cannot be overriden by a receiver.");
		}
		ReceiverNotificationBandPreference existingPreference = ReceiverNotificationBandPreference.GetByReceiverIDAndNotificationBandID(receiver.Id, notificationBand.Id);
		if (existingPreference == null)
		{
			existingPreference = new ReceiverNotificationBandPreference
			{
				IsEnabled = isEnabled,
				ReceiverID = receiver.Id,
				NotificationBandID = notificationBand.Id
			};
		}
		existingPreference.IsEnabled = isEnabled;
		existingPreference.Save();
	}

	public void SetDestinationPreference(IReceiver receiver, NotificationSourceType notificationSourceType, long destinationId, bool isEnabled)
	{
		short sourceTypeEntityId = _NotificationTypeTranslator.ToEntityId(notificationSourceType);
		Roblox.Platform.Notifications.Entities.ReceiverDestinationPreference existingPreference = Roblox.Platform.Notifications.Entities.ReceiverDestinationPreference.GetByReceiverIDNotificationSourceTypeIDAndDestinationID(receiver.Id, sourceTypeEntityId, destinationId);
		if (existingPreference == null)
		{
			existingPreference = new Roblox.Platform.Notifications.Entities.ReceiverDestinationPreference
			{
				IsEnabled = isEnabled,
				ReceiverID = receiver.Id,
				NotificationSourceTypeID = sourceTypeEntityId,
				DestinationID = destinationId
			};
		}
		existingPreference.IsEnabled = isEnabled;
		existingPreference.Save();
	}
}
