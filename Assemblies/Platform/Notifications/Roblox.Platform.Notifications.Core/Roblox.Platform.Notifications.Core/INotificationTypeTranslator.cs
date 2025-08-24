namespace Roblox.Platform.Notifications.Core;

public interface INotificationTypeTranslator
{
	short ToEntityId(NotificationSourceType sourceType);

	short ToEntityId(ReceiverDestinationType destinationType);

	int ToEntityId(ReceiverType receiverType);

	NotificationSourceType ToSourceTypeEnumValue(short sourceTypeId);

	ReceiverDestinationType ToDestinationTypeEnumValue(short destinationTypeId);

	ReceiverType ToReceiverTypeEnumValue(int receiverTypeId);
}
