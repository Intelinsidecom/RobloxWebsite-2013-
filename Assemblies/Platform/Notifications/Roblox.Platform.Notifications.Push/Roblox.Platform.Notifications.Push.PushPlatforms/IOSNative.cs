using System;
using System.Linq;
using Newtonsoft.Json;
using Roblox.EventLog;
using Roblox.Platform.Membership;
using Roblox.Platform.Notifications.Core;
using Roblox.Platform.Notifications.Push.Entities;
using Roblox.Platform.Notifications.Push.Properties;

namespace Roblox.Platform.Notifications.Push.PushPlatforms;

internal class IOSNative : IPushPlatform
{
	private class PushNotificationClientMetadata
	{
		[JsonProperty(PropertyName = "NotificationId")]
		public Guid NotificationId { get; set; }

		[JsonProperty(PropertyName = "notificationId")]
		public Guid NotificationIdLowercase => NotificationId;

		[JsonProperty(PropertyName = "Type")]
		public string Type { get; set; }

		[JsonProperty(PropertyName = "type")]
		public string TypeLowercase => Type;

		[JsonProperty(PropertyName = "Detail")]
		public object Detail { get; set; }

		[JsonProperty(PropertyName = "detail")]
		public object DetailLowercase => Detail;
	}

	private class SilentApnsBody
	{
		[JsonProperty(PropertyName = "aps")]
		public ApnsApsProperty Aps { get; set; }

		[JsonProperty(PropertyName = "roblox")]
		public Guid RobloxNotificationId { get; set; }
	}

	private class ApnsBody
	{
		[JsonProperty(PropertyName = "aps")]
		public ApnsApsProperty Aps { get; set; }

		[JsonProperty(PropertyName = "roblox-notification-id")]
		public Guid RobloxNotificationId { get; set; }

		[JsonProperty(PropertyName = "roblox-metadata")]
		public object RobloxMetadata { get; set; }
	}

	private class ApnsApsProperty
	{
		[JsonProperty(PropertyName = "content-available")]
		public int? ContentAvailable { get; set; }

		[JsonProperty(PropertyName = "category")]
		public string Category { get; set; }

		[JsonProperty(PropertyName = "alert")]
		public ApnsAlertProperty Alert { get; set; }

		[JsonProperty(PropertyName = "sound")]
		public string Sound { get; set; }
	}

	private class ApnsAlertProperty
	{
		[JsonProperty(PropertyName = "title")]
		public string Title { get; set; }

		[JsonProperty(PropertyName = "body")]
		public string Body { get; set; }
	}

	private readonly PushServiceClientFactory _PushServiceClientFactory;

	private readonly IDestinationTypeEntity _DestinationType;

	private readonly IUserFactory _UserFactory;

	private readonly ReceiverTypeLookup _ReceiverTypeLookup;

	private readonly ILogger _Logger;

	private static readonly JsonSerializerSettings _SerializationSettings = new JsonSerializerSettings
	{
		NullValueHandling = NullValueHandling.Ignore,
		DateFormatHandling = DateFormatHandling.IsoDateFormat
	};

	public bool SupportsNotificationUpdates => true;

	public IOSNative(PushServiceClientFactory pushServiceClientFactory, IDestinationTypeEntity destinationType, IUserFactory userFactory, ReceiverTypeLookup receiverTypeLookup, ILogger logger)
	{
		_PushServiceClientFactory = pushServiceClientFactory;
		_DestinationType = destinationType;
		_UserFactory = userFactory;
		_ReceiverTypeLookup = receiverTypeLookup;
		_Logger = logger;
	}

	public bool IsNotificationTokenValid(string token)
	{
		if (string.IsNullOrEmpty(token))
		{
			return false;
		}
		if (token.Length != 64 || !token.All(IsHex))
		{
			return false;
		}
		return true;
	}

	public bool FallbackRequired(IReceiver receiver, IPushNotificationSpecification specification)
	{
		if (specification.Intent != PushNotificationIntent.NewContent)
		{
			return false;
		}
		IUser user = null;
		if (receiver.IsUser(_ReceiverTypeLookup))
		{
			user = _UserFactory.GetUser(receiver.ToUserId(_ReceiverTypeLookup));
		}
		if (user == null)
		{
			return false;
		}
		if (Settings.Default.IsIOSPushFallbackDeliveryEnabled)
		{
			return true;
		}
		if (Settings.Default.IsIOSPushFallbackDeliveryEnabledForSoothsayers && user.IsSoothSayer())
		{
			return true;
		}
		if (Settings.Default.IsIOSPushFallbackDeliveryEnabledForBetaTesters && user.IsBetaTester())
		{
			return true;
		}
		return false;
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
		if (user == null)
		{
			return false;
		}
		if (!user.IsPushNotificationsEnabledOnIOS())
		{
			return false;
		}
		if (user.IsMobilePushNotificationsBlacklisted(specification.NewContentNotificationType?.ToString() ?? specification.Intent.ToString(), MobilePlatforms.IOS))
		{
			return false;
		}
		return true;
	}

	public string ProduceNotificationPayload(IPushNotificationSpecification specification, DeliveryAttemptType attempt, IPushNotificationMetadataManager metadataManager, INotificationBuilderRegistry<IPushNotificationContentBuilder> contentBuilderRegistry, IExtendedReceiverDestination receiverUser)
	{
		IUser receiver = null;
		try
		{
			receiver = _UserFactory.GetUser(receiverUser.ReceiverDestination.ReceiverTargetId);
		}
		catch (Exception)
		{
			_Logger.Error($"Couldn't build the user for translation from id: {receiverUser?.ReceiverDestination?.ReceiverTargetId}");
		}
		string body = attempt switch
		{
			DeliveryAttemptType.Primary => GetSilentAPNSBody(specification), 
			DeliveryAttemptType.Fallback => GetAlertAPNSBody(specification, metadataManager, contentBuilderRegistry, receiver), 
			_ => throw new NotSupportedException($"Cannot build iOS Notification for DeliveryAttempt {attempt}"), 
		};
		object message = ((!(_DestinationType.RegistrationEndpoint?.ToUpper() ?? string.Empty).Contains("APNS_SANDBOX")) ? ((object)new
		{
			APNS = body
		}) : ((object)new
		{
			APNS_SANDBOX = body
		}));
		return JsonConvert.SerializeObject(message);
	}

	private string GetSilentAPNSBody(IPushNotificationSpecification notification)
	{
		return JsonConvert.SerializeObject(new SilentApnsBody
		{
			Aps = new ApnsApsProperty
			{
				ContentAvailable = 1
			},
			RobloxNotificationId = notification.NotificationId
		}, _SerializationSettings);
	}

	private string GetAlertAPNSBody(IPushNotificationSpecification specification, IPushNotificationMetadataManager metadataManager, INotificationBuilderRegistry<IPushNotificationContentBuilder> delayedNotificationBuilderFactory, IUser user)
	{
		ApnsBody body = new ApnsBody();
		switch (specification.Intent)
		{
		case PushNotificationIntent.NewContent:
		{
			IVisibleNewContentPushNotification visibleNotification = null;
			PushNotificationClientMetadata metadata = GetMetadata(metadataManager, specification, delayedNotificationBuilderFactory, user, out visibleNotification);
			body.RobloxMetadata = metadata;
			if (visibleNotification != null)
			{
				body.Aps = new ApnsApsProperty
				{
					Alert = new ApnsAlertProperty
					{
						Title = (Settings.Default.IsIOSPushFallbackDiagnosticTitleEnabled ? "Roblox" : null),
						Body = visibleNotification.Body
					},
					Category = specification.NewContentNotificationType?.ToString(),
					Sound = (ShouldPlaySound(specification, metadataManager) ? Settings.Default.IOSSoundName : null)
				};
				if (Settings.Default.SendContentEnabledForVisibleIOSNotifications)
				{
					body.Aps.ContentAvailable = 1;
				}
				body.RobloxNotificationId = specification.NotificationId;
				return JsonConvert.SerializeObject(body, _SerializationSettings);
			}
			throw new ProduceNotificationPayloadException($"iOS Native: Visible Notification was not constructed - Cannot send Alert APNS Body. Intent: '{specification.Intent}', NotificationSourceType: '{specification.NewContentNotificationType}'");
		}
		default:
			throw new ProduceNotificationPayloadException($"iOS Native: Alert APNS Body Type not supported for notification with intent '{specification.Intent}'");
		}
	}

	private bool ShouldPlaySound(IPushNotificationSpecification specification, IPushNotificationMetadataManager metadataManager)
	{
		UserPushDestinationCore userPushDestination = new UserPushDestinationCore
		{
			Application = specification.Application,
			Platform = PushPlatformType.IOSNative,
			UserPushNotificationDestinationId = specification.ReceiverDestinationId
		};
		return metadataManager.GetUninterruptedFallbackCount(userPushDestination) < Settings.Default.IOSFallbackDeliveryMuteThreshold;
	}

	private static PushNotificationClientMetadata GetMetadata(IPushNotificationMetadataManager metadataManager, IPushNotificationSpecification notification, INotificationBuilderRegistry<IPushNotificationContentBuilder> delayedNotificationBuilderFactory, IUser user, out IVisibleNewContentPushNotification visibleNotification)
	{
		IStoredPushNotification storedMetadata = metadataManager.GetNotificationMetadataUnguarded(notification.NotificationId);
		if (storedMetadata == null)
		{
			throw new PushDeliveryException("Cannot build iOS Alert Notification as Metadata does not exist");
		}
		visibleNotification = null;
		if (notification.Intent != PushNotificationIntent.NewContent || !notification.NewContentNotificationType.HasValue)
		{
			throw new NotSupportedException("Cannot build iOS Alert Notification for an Expiry message");
		}
		IPushNotificationContentBuilder delayedNotificationBuilder = delayedNotificationBuilderFactory.GetBuilder(notification.NewContentNotificationType.Value);
		visibleNotification = delayedNotificationBuilder.BuildVisibleNewContentPushNotification(user, storedMetadata.DetailJson);
		return new PushNotificationClientMetadata
		{
			Type = LegacyStoredPushNotificationFormat.GetLegacyNotificationType(notification.Intent, notification.NewContentNotificationType),
			NotificationId = notification.NotificationId,
			Detail = visibleNotification.Detail
		};
	}

	private static bool IsHex(char c)
	{
		if ((c < '0' || c > '9') && (c < 'a' || c > 'f'))
		{
			if (c >= 'A')
			{
				return c <= 'F';
			}
			return false;
		}
		return true;
	}
}
