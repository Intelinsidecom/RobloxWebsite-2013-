using System;
using Newtonsoft.Json;
using Roblox.Platform.Membership;
using Roblox.Platform.Notifications.Core;
using Roblox.Platform.Notifications.Push.Entities;

namespace Roblox.Platform.Notifications.Push.PushPlatforms;

internal class AndroidAmazon : IPushPlatform
{
	private class SnsAdmWrapper
	{
		public string ADM { get; set; }
	}

	private class AdmPushPayload
	{
		public AdmPushPayloadData data { get; set; }
	}

	private class AdmPushPayloadData
	{
		public Guid robloxNotificationId { get; set; }
	}

	private readonly PushServiceClientFactory _PushServiceClientFactory;

	private readonly IDestinationTypeEntity _DestinationType;

	private readonly IUserFactory _UserFactory;

	private readonly ReceiverTypeLookup _ReceiverTypeLookup;

	public bool SupportsNotificationUpdates => true;

	/// <summary>
	/// This is to support delivering push notifications to Android devices where the Roblox app was installed through the
	/// Amazon app store, and registered with 'Amazon Device Messaging' (ADM)
	/// </summary>
	/// <param name="pushServiceClientFactory"></param>
	/// <param name="destinationType"></param>
	/// <param name="userFactory"></param>
	/// <param name="receiverTypeLookup"></param>
	public AndroidAmazon(PushServiceClientFactory pushServiceClientFactory, IDestinationTypeEntity destinationType, IUserFactory userFactory, ReceiverTypeLookup receiverTypeLookup)
	{
		_PushServiceClientFactory = pushServiceClientFactory;
		_DestinationType = destinationType;
		_UserFactory = userFactory;
		_ReceiverTypeLookup = receiverTypeLookup;
	}

	public bool IsNotificationTokenValid(string token)
	{
		return !string.IsNullOrEmpty(token);
	}

	public bool FallbackRequired(IReceiver receiver, IPushNotificationSpecification specification)
	{
		return false;
	}

	public string ProduceNotificationPayload(IPushNotificationSpecification specification, DeliveryAttemptType attempt, IPushNotificationMetadataManager metadataManager, INotificationBuilderRegistry<IPushNotificationContentBuilder> contentBuilderRegistry, IExtendedReceiverDestination receiver)
	{
		AdmPushPayload admPayload = new AdmPushPayload
		{
			data = new AdmPushPayloadData
			{
				robloxNotificationId = specification.NotificationId
			}
		};
		return JsonConvert.SerializeObject(new SnsAdmWrapper
		{
			ADM = JsonConvert.SerializeObject(admPayload)
		});
	}

	public IPushServiceClient GetPushServiceClient()
	{
		return _PushServiceClientFactory.GetSharedAmazonSnsMobilePushClient();
	}

	public bool DeliveryAllowed(IReceiver receiver, IPushNotificationSpecification specification)
	{
		IUser user = null;
		if (receiver.IsUser(_ReceiverTypeLookup))
		{
			user = _UserFactory.GetUser(receiver.ToUserId(_ReceiverTypeLookup));
		}
		if (user == null || !user.IsPushNotificationsEnabledOnAndroidAmazon())
		{
			return false;
		}
		if (specification.NewContentNotificationType.HasValue && user.IsMobilePushNotificationsBlacklisted(specification.NewContentNotificationType.ToString(), MobilePlatforms.Android))
		{
			return false;
		}
		return true;
	}
}
