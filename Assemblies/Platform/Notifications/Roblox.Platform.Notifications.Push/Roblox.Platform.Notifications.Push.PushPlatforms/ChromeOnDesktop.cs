using Newtonsoft.Json;
using Roblox.Platform.Membership;
using Roblox.Platform.Notifications.Core;
using Roblox.Platform.Notifications.Push.Entities;

namespace Roblox.Platform.Notifications.Push.PushPlatforms;

internal class ChromeOnDesktop : IPushPlatform
{
	private readonly PushServiceClientFactory _PushServiceClientFactory;

	private readonly IDestinationTypeEntity _DestinationType;

	private readonly IUserFactory _UserFactory;

	private readonly ReceiverTypeLookup _ReceiverTypeLookup;

	public bool SupportsNotificationUpdates => false;

	public ChromeOnDesktop(PushServiceClientFactory pushServiceClientFactory, IDestinationTypeEntity destinationType, IUserFactory userFactory, ReceiverTypeLookup receiverTypeLookup)
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

	public string ProduceNotificationPayload(IPushNotificationSpecification specification, DeliveryAttemptType deliveryAttempt, IPushNotificationMetadataManager metadataManager, INotificationBuilderRegistry<IPushNotificationContentBuilder> contentBuilderRegistry, IExtendedReceiverDestination receiver)
	{
		return JsonConvert.SerializeObject(new
		{
			GCM = JsonConvert.SerializeObject(new
			{
				data = new
				{
					message = specification.NotificationId
				}
			})
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
		if (user != null)
		{
			return DeliveryAllowed(user);
		}
		return false;
	}

	private bool DeliveryAllowed(IUser user)
	{
		return user.IsPushNotificationsEnabledOnChrome();
	}
}
