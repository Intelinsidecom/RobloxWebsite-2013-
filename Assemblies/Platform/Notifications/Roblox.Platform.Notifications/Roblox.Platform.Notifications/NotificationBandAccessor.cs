using System.Collections.Generic;
using System.Linq;
using Roblox.Common.NetStandard;
using Roblox.Platform.Notifications.Core;
using Roblox.Platform.Notifications.Entities;

namespace Roblox.Platform.Notifications;

internal class NotificationBandAccessor : INotificationBandAccessor
{
	private readonly INotificationTypeTranslator _NotificationTypeTranslator;

	public NotificationBandAccessor()
		: this(Roblox.Platform.Notifications.Core.Accessors.NotificationTypeTranslator)
	{
	}

	internal NotificationBandAccessor(INotificationTypeTranslator typeTranslator)
	{
		_NotificationTypeTranslator = typeTranslator;
	}

	public INotificationBand Get(int notificationBandId)
	{
		Roblox.Platform.Notifications.Entities.NotificationBand entity = Roblox.Platform.Notifications.Entities.NotificationBand.Get(notificationBandId);
		return Translate(entity);
	}

	public INotificationBand GetByNotificationSourceTypeAndReceiverDestinationType(NotificationSourceType notificationSourceType, ReceiverDestinationType receiverDestinationType)
	{
		short notificationSourceTypeID = _NotificationTypeTranslator.ToEntityId(notificationSourceType);
		short destinationEntityId = _NotificationTypeTranslator.ToEntityId(receiverDestinationType);
		Roblox.Platform.Notifications.Entities.NotificationBand entity = Roblox.Platform.Notifications.Entities.NotificationBand.GetByNotificationSourceTypeIDAndReceiverDestinationTypeID(notificationSourceTypeID, destinationEntityId);
		return Translate(entity);
	}

	public IEnumerable<INotificationBand> GetAllByNotificationSourceType(NotificationSourceType notificationSourceType)
	{
		short sourceEntityId = _NotificationTypeTranslator.ToEntityId(notificationSourceType);
		return CollectionsHelper.GetAllPaged((int start, int max) => Roblox.Platform.Notifications.Entities.NotificationBand.GetNotificationBandsByNotificationSourceTypeIDPaged(sourceEntityId, start, max), 20).Select(Translate);
	}

	public IEnumerable<INotificationBand> GetAllByReceiverDestinationType(ReceiverDestinationType receiverDestinationType)
	{
		short destinationEntityId = _NotificationTypeTranslator.ToEntityId(receiverDestinationType);
		return CollectionsHelper.GetAllPaged((int start, int max) => Roblox.Platform.Notifications.Entities.NotificationBand.GetNotificationBandsByReceiverDestinationTypeIDPaged(destinationEntityId, start, max), 20).Select(Translate);
	}

	private INotificationBand Translate(Roblox.Platform.Notifications.Entities.NotificationBand entity)
	{
		if (entity == null)
		{
			return null;
		}
		NotificationSourceType sourceType = _NotificationTypeTranslator.ToSourceTypeEnumValue(entity.NotificationSourceTypeID);
		ReceiverDestinationType destinationType = _NotificationTypeTranslator.ToDestinationTypeEnumValue(entity.ReceiverDestinationTypeID);
		return new NotificationBand
		{
			Id = entity.ID,
			IsEnabledByDefault = entity.IsEnabledByDefault,
			IsOverridable = entity.IsOverridable,
			NotificationSourceType = sourceType,
			ReceiverDestinationType = destinationType
		};
	}
}
