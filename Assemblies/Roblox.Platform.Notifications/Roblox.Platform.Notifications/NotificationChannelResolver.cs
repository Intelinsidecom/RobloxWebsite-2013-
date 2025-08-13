using System.Collections.Generic;
using System.Linq;
using Roblox.Platform.Membership;
using Roblox.Platform.Notifications.Core;
using Roblox.Platform.Notifications.Extensions;
using Roblox.Platform.Notifications.Push;
using Roblox.Platform.Notifications.Stream;

namespace Roblox.Platform.Notifications;

public class NotificationChannelResolver : INotificationChannelResolver
{
	private readonly INotificationBandAccessor _NotificationBandAccessor;

	private readonly IPreferencesAccessor _PreferencesAccessor;

	private readonly IStreamPermissionChecker _StreamPermissionChecker;

	private readonly IPushRegistrar _PushRegistrar;

	private readonly IUserFactory _UserFactory;

	private readonly IPushNotificationEventPublisher _PushNotificationEventPublisher;

	private readonly IPushNotificationMetadataManager _PushNotificationMetadataManager;

	private readonly INotificationStreamPersister _NotificationStreamPersister;

	public NotificationChannelResolver(INotificationBandAccessor notificationBandAccessor, IPreferencesAccessor preferencesAccessor, IStreamPermissionChecker streamPermissionChecker, IPushRegistrar pushRegistrar, IUserFactory userFactory, IPushNotificationEventPublisher pushNotificationEventPublisher, IPushNotificationMetadataManager pushNotificationMetadataManager, INotificationStreamPersister notificationStreamPersister)
	{
		_NotificationBandAccessor = notificationBandAccessor;
		_PreferencesAccessor = preferencesAccessor;
		_StreamPermissionChecker = streamPermissionChecker;
		_PushRegistrar = pushRegistrar;
		_UserFactory = userFactory;
		_PushNotificationEventPublisher = pushNotificationEventPublisher;
		_PushNotificationMetadataManager = pushNotificationMetadataManager;
		_NotificationStreamPersister = notificationStreamPersister;
	}

	internal virtual INotificationDeliveryConfiguration ResolveDeliveryDestinationTypesForNotification(NotificationSourceType notificationSourceType, IReceiver receiver, ICollection<IUserPushDestination> allReceiversDestinations, ReceiverNotificationStatus status)
	{
		NotificationDeliveryConfiguration result = new NotificationDeliveryConfiguration
		{
			Receiver = receiver,
			SourceType = notificationSourceType
		};
		INotificationSourceTypeOptOut notificationSourceTypeOptOut = _PreferencesAccessor.GetNotificationSourceTypeOptOut(receiver, notificationSourceType);
		List<IReceiverDestinationTypeOptOut> receiverDestinationTypeOptOuts = _PreferencesAccessor.GetAllReceiverDestinationTypeOptOuts(receiver).ToList();
		IEnumerable<INotificationBand> allByNotificationSourceType = _NotificationBandAccessor.GetAllByNotificationSourceType(notificationSourceType);
		List<IReceiverDestinationPreference> destinationPreferences = _PreferencesAccessor.GetAllReceiverDestinationPreferences(receiver).ToList();
		foreach (INotificationBand notificationBand in allByNotificationSourceType)
		{
			if (ReceiverNotificationStatus.Revoked.Equals(status))
			{
				result.ReceiverDestinationTypes.Add(notificationBand.ReceiverDestinationType);
			}
			else if (!notificationBand.IsOverridable)
			{
				if (notificationBand.IsEnabledByDefault)
				{
					result.ReceiverDestinationTypes.Add(notificationBand.ReceiverDestinationType);
				}
			}
			else
			{
				if (notificationSourceTypeOptOut != null || receiverDestinationTypeOptOuts.Any((IReceiverDestinationTypeOptOut optOut) => optOut.ReceiverDestinationType == notificationBand.ReceiverDestinationType))
				{
					continue;
				}
				INotificationBandPreference notificationBandPreference = _PreferencesAccessor.GetNotificationBandPreference(receiver, notificationBand);
				if ((notificationBandPreference != null || !notificationBand.IsEnabledByDefault) && (notificationBandPreference == null || !notificationBandPreference.IsEnabled))
				{
					continue;
				}
				result.ReceiverDestinationTypes.Add(notificationBand.ReceiverDestinationType);
				ICollection<PushPlatformType> correspondingDestinationPlatformTypes = notificationBand.ReceiverDestinationType.GetCorrespondingPushPlatformTypes();
				foreach (IReceiverDestinationPreference preference in destinationPreferences.Where(delegate(IReceiverDestinationPreference p)
				{
					IUserPushDestination userPushDestination = allReceiversDestinations.FirstOrDefault((IUserPushDestination rd) => rd.UserPushNotificationDestinationId == p.DestinationId);
					return userPushDestination != null && correspondingDestinationPlatformTypes.Contains(userPushDestination.Platform) && p.NotificationSourceType == notificationSourceType;
				}))
				{
					if (!preference.IsEnabled)
					{
						result.DisallowedPushNotificationDestinationIds.Add(preference.DestinationId);
					}
				}
			}
		}
		return result;
	}

	public ICollection<INotificationChannel> ResolveNotificationChannelsForNotification(NotificationSourceType sourceType, IReceiver receiver, ReceiverNotificationStatus status)
	{
		IUser user = _UserFactory.GetUser(receiver.ReceiverTargetId);
		List<IUserPushDestination> allReceiversDestinations = _PushRegistrar.GetValidDestinations(PushApplicationType.Roblox, user).ToList();
		INotificationDeliveryConfiguration deliveryConfiguration = ResolveDeliveryDestinationTypesForNotification(sourceType, receiver, allReceiversDestinations, status);
		List<INotificationChannel> notificationChannels = new List<INotificationChannel>();
		foreach (ReceiverDestinationType destinationType in deliveryConfiguration.ReceiverDestinationTypes)
		{
			ICollection<PushPlatformType> pushPlatformTypes = destinationType.GetCorrespondingPushPlatformTypes();
			foreach (IUserPushDestination destination in allReceiversDestinations.Where((IUserPushDestination rd) => pushPlatformTypes.Contains(rd.Platform)))
			{
				if (!deliveryConfiguration.DisallowedPushNotificationDestinationIds.Contains(destination.UserPushNotificationDestinationId))
				{
					notificationChannels.Add(new PushNotificationChannel(destinationType, destination, _PushNotificationEventPublisher, _PushNotificationMetadataManager));
				}
			}
			if (destinationType == ReceiverDestinationType.NotificationStream && _StreamPermissionChecker.IsNotificationStreamPopulationEnabled(user))
			{
				notificationChannels.Add(new NotificationStreamChannel(_NotificationStreamPersister, receiver));
			}
		}
		return notificationChannels;
	}
}
