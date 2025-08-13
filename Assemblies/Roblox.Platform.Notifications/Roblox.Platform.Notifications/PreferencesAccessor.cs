using System;
using System.Collections.Generic;
using System.Linq;
using Roblox.Common.NetStandard;
using Roblox.Platform.Membership;
using Roblox.Platform.Notifications.Core;
using Roblox.Platform.Notifications.Entities;
using Roblox.Platform.Notifications.Extensions;
using Roblox.Platform.Notifications.Implementation;
using Roblox.Platform.Notifications.Push;

namespace Roblox.Platform.Notifications;

internal class PreferencesAccessor : IPreferencesAccessor
{
	private readonly INotificationBandAccessor _NotificationBandAccessor;

	private readonly INotificationTypeTranslator _NotificationTypeTranslator;

	private readonly List<NotificationSourceType> _AllNotificationSourceTypes = new List<NotificationSourceType>((NotificationSourceType[])Enum.GetValues(typeof(NotificationSourceType)));

	public PreferencesAccessor()
		: this(Accessors.NotificationBandAccessor, Roblox.Platform.Notifications.Core.Accessors.NotificationTypeTranslator)
	{
	}

	internal PreferencesAccessor(INotificationBandAccessor notificationBandAccessor, INotificationTypeTranslator typeTranslator)
	{
		_NotificationBandAccessor = notificationBandAccessor;
		_NotificationTypeTranslator = typeTranslator;
	}

	public IReceiverDestinationTypeOptOut GetReceiverDestinationTypeOptOut(IReceiver receiver, ReceiverDestinationType receiverDestinationType)
	{
		short destinationTypeEntityId = _NotificationTypeTranslator.ToEntityId(receiverDestinationType);
		if (Roblox.Platform.Notifications.Entities.ReceiverDestinationTypeOptOut.GetByReceiverIDAndReceiverDestinationTypeID(receiver.Id, destinationTypeEntityId) == null)
		{
			return null;
		}
		return new ReceiverDestinationTypeOptOut
		{
			Receiver = receiver,
			ReceiverDestinationType = receiverDestinationType
		};
	}

	public IEnumerable<IReceiverDestinationTypeOptOut> GetAllReceiverDestinationTypeOptOuts(IReceiver receiver)
	{
		return CollectionsHelper.GetAllPaged((int start, int max) => Roblox.Platform.Notifications.Entities.ReceiverDestinationTypeOptOut.GetReceiverDestinationTypeOptOutsByReceiverIDPaged(receiver.Id, start, max), 20).Select(delegate(Roblox.Platform.Notifications.Entities.ReceiverDestinationTypeOptOut e)
		{
			ReceiverDestinationType receiverDestinationType = _NotificationTypeTranslator.ToDestinationTypeEnumValue(e.ReceiverDestinationTypeID);
			return new ReceiverDestinationTypeOptOut
			{
				Receiver = receiver,
				ReceiverDestinationType = receiverDestinationType
			};
		});
	}

	public INotificationSourceTypeOptOut GetNotificationSourceTypeOptOut(IReceiver receiver, NotificationSourceType notificationSourceType)
	{
		short sourceTypeEntityId = _NotificationTypeTranslator.ToEntityId(notificationSourceType);
		if (Roblox.Platform.Notifications.Entities.NotificationSourceTypeOptOut.GetByReceiverIDAndNotificationSourceTypeID(receiver.Id, sourceTypeEntityId) == null)
		{
			return null;
		}
		return new NotificationSourceTypeOptOut
		{
			Receiver = receiver,
			NotificationSourceType = notificationSourceType
		};
	}

	public IEnumerable<INotificationSourceTypeOptOut> GetAllNotificationSourceTypeOptOuts(IReceiver receiver)
	{
		return CollectionsHelper.GetAllPaged((int start, int max) => Roblox.Platform.Notifications.Entities.NotificationSourceTypeOptOut.GetNotificationSourceTypeOptOutsByReceiverIDPaged(receiver.Id, start, max), 20).Select(delegate(Roblox.Platform.Notifications.Entities.NotificationSourceTypeOptOut e)
		{
			NotificationSourceType notificationSourceType = _NotificationTypeTranslator.ToSourceTypeEnumValue(e.NotificationSourceTypeID);
			return new NotificationSourceTypeOptOut
			{
				Receiver = receiver,
				NotificationSourceType = notificationSourceType
			};
		});
	}

	public INotificationBandPreference GetNotificationBandPreference(IReceiver receiver, INotificationBand notificationBand)
	{
		ReceiverNotificationBandPreference entity = ReceiverNotificationBandPreference.GetByReceiverIDAndNotificationBandID(receiver.Id, notificationBand.Id);
		if (entity == null)
		{
			return null;
		}
		return new NotificationBandPreference
		{
			IsEnabled = entity.IsEnabled,
			NotificationBand = notificationBand,
			Receiver = receiver
		};
	}

	public IEnumerable<INotificationBandPreference> GetAllNotificationBandPreferences(IReceiver receiver)
	{
		return CollectionsHelper.GetAllPaged((int start, int max) => ReceiverNotificationBandPreference.GetReceiverNotificationBandPreferencesByReceiverIDPaged(receiver.Id, start, max), 20).Select(delegate(ReceiverNotificationBandPreference e)
		{
			INotificationBand notificationBand = _NotificationBandAccessor.Get(e.NotificationBandID);
			return new NotificationBandPreference
			{
				IsEnabled = e.IsEnabled,
				NotificationBand = notificationBand,
				Receiver = receiver
			};
		});
	}

	public IReceiverDestinationPreference GetReceiverDestinationPreference(IReceiver receiver, NotificationSourceType notificationSourceType, long destinationId)
	{
		short sourceTypeEntityId = _NotificationTypeTranslator.ToEntityId(notificationSourceType);
		Roblox.Platform.Notifications.Entities.ReceiverDestinationPreference entity = Roblox.Platform.Notifications.Entities.ReceiverDestinationPreference.GetByReceiverIDNotificationSourceTypeIDAndDestinationID(receiver.Id, sourceTypeEntityId, destinationId);
		if (entity == null)
		{
			return null;
		}
		return new ReceiverDestinationPreference
		{
			DestinationId = destinationId,
			Receiver = receiver,
			IsEnabled = entity.IsEnabled,
			NotificationSourceType = notificationSourceType
		};
	}

	public IEnumerable<IReceiverDestinationPreference> GetAllReceiverDestinationPreferences(IReceiver receiver)
	{
		return CollectionsHelper.GetAllPaged((int start, int max) => Roblox.Platform.Notifications.Entities.ReceiverDestinationPreference.GetReceiverDestinationPreferencesByReceiverIDPaged(receiver.Id, start, max), 20).Select(delegate(Roblox.Platform.Notifications.Entities.ReceiverDestinationPreference e)
		{
			NotificationSourceType notificationSourceType = _NotificationTypeTranslator.ToSourceTypeEnumValue(e.NotificationSourceTypeID);
			return new ReceiverDestinationPreference
			{
				DestinationId = e.DestinationID,
				IsEnabled = e.IsEnabled,
				NotificationSourceType = notificationSourceType,
				Receiver = receiver
			};
		});
	}

	public IEnumerable<IReceiverNotificationSettingsGroup> GetAllReceiverNotificationSettings(IUser receiverUser, IPushRegistrar pushRegistrar)
	{
		List<INotificationBand> allNotificationBands = new List<INotificationBand>();
		foreach (NotificationSourceType sourceType in _AllNotificationSourceTypes)
		{
			allNotificationBands.AddRange(Accessors.NotificationBandAccessor.GetAllByNotificationSourceType(sourceType));
		}
		IReceiver receiver = receiverUser.ToReceiver();
		List<IReceiverNotificationSettingsGroup> results = new List<IReceiverNotificationSettingsGroup>();
		List<IReceiverDestinationPreference> allDestinationPreferences = GetAllReceiverDestinationPreferences(receiver).ToList();
		List<IUserPushDestination> allReceiverDestinations = pushRegistrar.GetValidDestinations(PushApplicationType.Roblox, receiverUser).ToList();
		foreach (INotificationBand band in allNotificationBands)
		{
			bool isEnabled = band.IsEnabledByDefault;
			if (!(band.IsOverridable || isEnabled))
			{
				continue;
			}
			INotificationBandPreference userPreference = Accessors.PreferencesAccessor.GetNotificationBandPreference(receiver, band);
			if (band.IsOverridable && userPreference != null)
			{
				isEnabled = userPreference.IsEnabled;
			}
			ReceiverNotificationSettingsGroup bandSetting = new ReceiverNotificationSettingsGroup
			{
				NotificationSourceType = band.NotificationSourceType,
				ReceiverDestinationType = band.ReceiverDestinationType,
				IsOverridable = band.IsOverridable,
				IsEnabled = isEnabled,
				IsSetByReceiver = (band.IsOverridable && userPreference != null)
			};
			foreach (IUserPushDestination receiverDestination in allReceiverDestinations.Where((IUserPushDestination rd) => rd.Platform.GetCorrespondingReceiverDestinationType() == band.ReceiverDestinationType))
			{
				IReceiverDestinationPreference destinationPreference = allDestinationPreferences.FirstOrDefault((IReceiverDestinationPreference dp) => dp.DestinationId == receiverDestination.UserPushNotificationDestinationId && dp.NotificationSourceType == band.NotificationSourceType);
				bool isDestinationEnabled = isEnabled;
				if (isEnabled && destinationPreference != null)
				{
					isDestinationEnabled = destinationPreference.IsEnabled;
				}
				bandSetting.PushNotificationDestinationPreferences.Add(new PushNotificationDestinationSettingGroup
				{
					DestinationId = receiverDestination.UserPushNotificationDestinationId,
					IsEnabled = isDestinationEnabled,
					IsSetByReceiver = (bandSetting.IsSetByReceiver && destinationPreference != null),
					Name = receiverDestination.Name,
					Platform = receiverDestination.Platform
				});
			}
			results.Add(bandSetting);
		}
		return results;
	}
}
