using System;
using System.Collections.Generic;
using Roblox.Platform.Core;
using Roblox.Platform.Notifications.Core.Entities;

namespace Roblox.Platform.Notifications.Core;

internal class NotificationTypeTranslator : INotificationTypeTranslator
{
	private readonly Lazy<Dictionary<short, NotificationSourceType>> _NotificationSourceTypeMapping;

	private readonly Lazy<Dictionary<NotificationSourceType, short>> _NotificationSourceTypeIdMapping;

	private readonly Lazy<Dictionary<short, ReceiverDestinationType>> _ReceiverDestinationTypeMapping;

	private readonly Lazy<Dictionary<ReceiverDestinationType, short>> _ReceiverDestinationTypeIdMapping;

	private readonly Lazy<Dictionary<int, ReceiverType>> _ReceiverTypeMapping;

	private readonly Lazy<Dictionary<ReceiverType, int>> _ReceiverTypeIdMapping;

	internal NotificationTypeTranslator()
	{
		_NotificationSourceTypeMapping = new Lazy<Dictionary<short, NotificationSourceType>>(() => MapIdToEnum<short, NotificationSourceType>((string str) => Roblox.Platform.Notifications.Core.Entities.NotificationSourceType.GetByValue(str).ID));
		_NotificationSourceTypeIdMapping = new Lazy<Dictionary<NotificationSourceType, short>>(() => MapEnumToId<NotificationSourceType, short>((string str) => Roblox.Platform.Notifications.Core.Entities.NotificationSourceType.GetByValue(str).ID));
		_ReceiverDestinationTypeMapping = new Lazy<Dictionary<short, ReceiverDestinationType>>(() => MapIdToEnum<short, ReceiverDestinationType>((string str) => Roblox.Platform.Notifications.Core.Entities.ReceiverDestinationType.GetByValue(str).ID));
		_ReceiverDestinationTypeIdMapping = new Lazy<Dictionary<ReceiverDestinationType, short>>(() => MapEnumToId<ReceiverDestinationType, short>((string str) => Roblox.Platform.Notifications.Core.Entities.ReceiverDestinationType.GetByValue(str).ID));
		_ReceiverTypeMapping = new Lazy<Dictionary<int, ReceiverType>>(() => MapIdToEnum<int, ReceiverType>((string str) => Roblox.Platform.Notifications.Core.Entities.ReceiverType.GetOrCreate(str).ID));
		_ReceiverTypeIdMapping = new Lazy<Dictionary<ReceiverType, int>>(() => MapEnumToId<ReceiverType, int>((string str) => Roblox.Platform.Notifications.Core.Entities.ReceiverType.GetOrCreate(str).ID));
	}

	public int ToEntityId(ReceiverType receiverType)
	{
		if (!_ReceiverTypeIdMapping.Value.ContainsKey(receiverType))
		{
			throw new PlatformArgumentException("This should not be possible, but the receiver type supplied does not correspond to an entity in the database.");
		}
		return _ReceiverTypeIdMapping.Value[receiverType];
	}

	public short ToEntityId(ReceiverDestinationType destinationType)
	{
		if (!_ReceiverDestinationTypeIdMapping.Value.ContainsKey(destinationType))
		{
			throw new PlatformInvalidEnumArgumentException("This should not be possible, but the receiver destination type supplied does not correspond to an entity in the DB.");
		}
		return _ReceiverDestinationTypeIdMapping.Value[destinationType];
	}

	public short ToEntityId(NotificationSourceType sourceType)
	{
		if (!_NotificationSourceTypeIdMapping.Value.ContainsKey(sourceType))
		{
			throw new PlatformInvalidEnumArgumentException("This should not be possible, but the notification source type supplied does not correspond to an entity in the DB.");
		}
		return _NotificationSourceTypeIdMapping.Value[sourceType];
	}

	public ReceiverDestinationType ToDestinationTypeEnumValue(short destinationTypeId)
	{
		if (!_ReceiverDestinationTypeMapping.Value.ContainsKey(destinationTypeId))
		{
			throw new PlatformArgumentException("That destination type does not exist in the database.");
		}
		return _ReceiverDestinationTypeMapping.Value[destinationTypeId];
	}

	public ReceiverType ToReceiverTypeEnumValue(int receiverTypeId)
	{
		if (!_ReceiverTypeMapping.Value.ContainsKey(receiverTypeId))
		{
			throw new PlatformArgumentException("That receiver type does not exist in the database.");
		}
		return _ReceiverTypeMapping.Value[receiverTypeId];
	}

	public NotificationSourceType ToSourceTypeEnumValue(short sourceTypeId)
	{
		if (!_NotificationSourceTypeMapping.Value.ContainsKey(sourceTypeId))
		{
			throw new PlatformArgumentException("That source type does not exist in the database.");
		}
		return _NotificationSourceTypeMapping.Value[sourceTypeId];
	}

	internal Dictionary<TId, TEnum> MapIdToEnum<TId, TEnum>(Func<string, TId> idGetter)
	{
		List<TEnum> list = new List<TEnum>((TEnum[])Enum.GetValues(typeof(TEnum)));
		Dictionary<TId, TEnum> returnDictionary = new Dictionary<TId, TEnum>();
		foreach (TEnum enumValue in list)
		{
			TId id = idGetter(enumValue.ToString());
			returnDictionary[id] = enumValue;
		}
		return returnDictionary;
	}

	internal Dictionary<TEnum, TId> MapEnumToId<TEnum, TId>(Func<string, TId> idGetter)
	{
		List<TEnum> list = new List<TEnum>((TEnum[])Enum.GetValues(typeof(TEnum)));
		Dictionary<TEnum, TId> returnDictionary = new Dictionary<TEnum, TId>();
		foreach (TEnum enumValue in list)
		{
			TId id = idGetter(enumValue.ToString());
			returnDictionary[enumValue] = id;
		}
		return returnDictionary;
	}
}
