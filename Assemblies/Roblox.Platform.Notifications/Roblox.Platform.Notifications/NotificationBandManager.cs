using Roblox.Platform.Core;
using Roblox.Platform.Notifications.Core;
using Roblox.Platform.Notifications.Entities;

namespace Roblox.Platform.Notifications;

public class NotificationBandManager : INotificationBandManager
{
	private readonly INotificationBandAccessor _NotificationBandAccessor;

	private readonly INotificationTypeTranslator _NotificationTypeTranslator;

	public NotificationBandManager()
		: this(Accessors.NotificationBandAccessor, Roblox.Platform.Notifications.Core.Accessors.NotificationTypeTranslator)
	{
	}

	internal NotificationBandManager(INotificationBandAccessor notificationBandAccessor, INotificationTypeTranslator typeTranslator)
	{
		_NotificationBandAccessor = notificationBandAccessor;
		_NotificationTypeTranslator = typeTranslator;
	}

	public void CreateNotificationBand(NotificationSourceType notificationSourceType, ReceiverDestinationType receiverDestinationType, bool isEnabledByDefault = false, bool isOverridableByReceiver = false)
	{
		if (_NotificationBandAccessor.GetByNotificationSourceTypeAndReceiverDestinationType(notificationSourceType, receiverDestinationType) != null)
		{
			throw new PlatformArgumentException("That combination of NotificationSourceType and ReceiverDestinationType already exists. Could not create.");
		}
		short sourceTypeEntityId = _NotificationTypeTranslator.ToEntityId(notificationSourceType);
		short destinationTypeEntityId = _NotificationTypeTranslator.ToEntityId(receiverDestinationType);
		Roblox.Platform.Notifications.Entities.NotificationBand notificationBand = new Roblox.Platform.Notifications.Entities.NotificationBand();
		notificationBand.NotificationSourceTypeID = sourceTypeEntityId;
		notificationBand.ReceiverDestinationTypeID = destinationTypeEntityId;
		notificationBand.IsEnabledByDefault = isEnabledByDefault;
		notificationBand.IsOverridable = isOverridableByReceiver;
		notificationBand.Save();
	}

	public void UpdateNotificationBandDefaults(INotificationBand notificationBand, bool isEnabledByDefault, bool isOverridableByReceiver)
	{
		Roblox.Platform.Notifications.Entities.NotificationBand obj = Roblox.Platform.Notifications.Entities.NotificationBand.Get(notificationBand.Id) ?? throw new PlatformArgumentException("That combination of NotificationSourceType and ReceiverDestinationType does not exist. Could not update.");
		obj.IsEnabledByDefault = isEnabledByDefault;
		obj.IsOverridable = isOverridableByReceiver;
		obj.Save();
	}

	public void DisableNotificationBand(INotificationBand notificationBand)
	{
		UpdateNotificationBandDefaults(notificationBand, isEnabledByDefault: false, isOverridableByReceiver: false);
	}
}
