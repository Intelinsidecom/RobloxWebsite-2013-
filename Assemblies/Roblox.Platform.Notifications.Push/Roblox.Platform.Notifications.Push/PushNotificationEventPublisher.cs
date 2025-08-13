using System;
using System.Linq;
using Amazon;
using Newtonsoft.Json;
using Roblox.Amazon.Sns;
using Roblox.Amazon.Sqs;
using Roblox.Configuration;
using Roblox.EventLog;
using Roblox.Instrumentation;
using Roblox.Platform.Membership;
using Roblox.Platform.Notifications.Core;
using Roblox.Platform.Notifications.Push.Properties;

namespace Roblox.Platform.Notifications.Push;

public class PushNotificationEventPublisher : IPushNotificationEventPublisher
{
	private readonly ILogger _Logger;

	private SnsPublisher _PushPrimaryPublisher;

	private SqsBatchSender _PushFallbackPublisher;

	private readonly object _SqsBatchSenderLock = new object();

	private SnsPublisher _PushNotificationsBrokerPublisher;

	private readonly ICounterRegistry _CounterRegistry;

	public PushNotificationEventPublisher(ILogger logger, ICounterRegistry counterRegistry)
	{
		_Logger = logger;
		_CounterRegistry = counterRegistry;
		InitializePrimaryPublisher();
		Settings.Default.MonitorChanges((Settings s) => s.PushNotificationEventsSnsAwsAccessKeyAndSecret, InitializePrimaryPublisher);
		Settings.Default.MonitorChanges((Settings s) => s.PushNotificationEventsSnsTopicArn, InitializePrimaryPublisher);
		InitializeFallbackPublisher();
		Settings.Default.MonitorChanges((Settings s) => s.PushFallbackDeliverySQSPublisherAccessKeyAndSecretKey, InitializeFallbackPublisher);
		Settings.Default.MonitorChanges((Settings s) => s.PushFallbackDeliverySQSUrl, InitializeFallbackPublisher);
		Settings.Default.MonitorChanges((Settings s) => s.PushFallbackDeliveryDelay, InitializeFallbackPublisher);
		InitializePushNotificationBrokerPublisher();
		Settings.Default.MonitorChanges((Settings s) => s.PushNotificationsBrokerPushNotificationEventsSnsAwsAccessKeyAndSecret, InitializePushNotificationBrokerPublisher);
		Settings.Default.MonitorChanges((Settings s) => s.PushNotificationsBrokerPushNotificationEventsSnsTopicArn, InitializePushNotificationBrokerPublisher);
	}

	private void InitializePushNotificationBrokerPublisher()
	{
		string[] awsKeys = Settings.Default.PushNotificationsBrokerPushNotificationEventsSnsAwsAccessKeyAndSecret.Split(',');
		_PushNotificationsBrokerPublisher = new SnsPublisher(awsKeys[0], awsKeys[1], RegionEndpoint.USEast1, Settings.Default.PushNotificationsBrokerPushNotificationEventsSnsTopicArn, "Roblox.PushNotificationsBrokerPublisher", _CounterRegistry);
		_PushNotificationsBrokerPublisher.SnsError += delegate(Exception exception, string s)
		{
			_Logger.Error(exception);
		};
	}

	private void InitializePrimaryPublisher()
	{
		string[] awsKeys = Settings.Default.PushNotificationEventsSnsAwsAccessKeyAndSecret.Split(',');
		_PushPrimaryPublisher = new SnsPublisher(awsKeys[0], awsKeys[1], RegionEndpoint.USEast1, Settings.Default.PushNotificationEventsSnsTopicArn, "Roblox.PushNotificationEventPublisher", _CounterRegistry);
		_PushPrimaryPublisher.SnsError += delegate(Exception exception, string s)
		{
			_Logger.Error(exception);
		};
	}

	private void InitializeFallbackPublisher()
	{
		lock (_SqsBatchSenderLock)
		{
			if (_PushFallbackPublisher != null)
			{
				_PushFallbackPublisher.Stop();
				_PushFallbackPublisher = null;
			}
			string keyString = Settings.Default.PushFallbackDeliverySQSPublisherAccessKeyAndSecretKey;
			if (!string.IsNullOrEmpty(keyString))
			{
				string[] keys = keyString.Split(',');
				int fallbackDelay = Convert.ToInt32(Settings.Default.PushFallbackDeliveryDelay.TotalSeconds);
				_PushFallbackPublisher = new SqsBatchSender(keys[0], keys[1], Settings.Default.PushFallbackDeliverySQSUrl, 10, 100, fallbackDelay, retryInOtherRegions: true);
				_PushFallbackPublisher.ExceptionOccured += _Logger.Error;
				_PushFallbackPublisher.Start();
			}
		}
	}

	/// <summary>
	/// Publish a push notification event to be handled by a processor
	/// </summary>
	/// <returns>True if successful, false if not</returns>
	public bool PublishPrimaryNotification(IUserPushDestination destination, Guid notificationId, PushNotificationIntent intent, NotificationSourceType? notificationType)
	{
		if (IsNudgeSystemDeliveryEnabledOnSettings(destination.User, notificationType))
		{
			var eventToPublish3 = new
			{
				NotificationId = $"{destination.UserPushNotificationDestinationId}_{notificationId.ToString()}",
				UserId = destination.User.Id,
				ContentDefinitionName = GetPushNotificationContentDefinition(intent, notificationType),
				IsImportant = true
			};
			_PushNotificationsBrokerPublisher.Publish(eventToPublish3);
			if (Settings.Default.IsNudgeSystemDeliveryToDestinationEnabled)
			{
				return true;
			}
		}
		if (Settings.Default.IsPublishPushNotificationRequestWithIntentFormatEnabled)
		{
			PushNotificationEvent eventToPublish2 = new PushNotificationEvent
			{
				ReceiverDestinationId = destination.UserPushNotificationDestinationId,
				Application = destination.Application,
				NotificationId = notificationId,
				Intent = intent,
				NewContentNotificationType = notificationType
			};
			_PushPrimaryPublisher.Publish(eventToPublish2);
		}
		else
		{
			bool userVisisble = false;
			string legacyNotificationType = LegacyStoredPushNotificationFormat.GetLegacyNotificationType(intent, notificationType);
			if (intent == PushNotificationIntent.NewContent)
			{
				userVisisble = true;
			}
			PushNotificationEventLegacy eventToPublish = new PushNotificationEventLegacy
			{
				ReceiverDestinationId = destination.UserPushNotificationDestinationId,
				Application = destination.Application,
				NotificationId = notificationId,
				NotificationType = legacyNotificationType,
				IsUserVisible = userVisisble
			};
			_PushPrimaryPublisher.Publish(eventToPublish);
		}
		return true;
	}

	public bool PublishFallbackNotification(IPushNotificationSpecification notification)
	{
		PushNotificationEvent eventToPublish = new PushNotificationEvent
		{
			ReceiverDestinationId = notification.ReceiverDestinationId,
			Application = notification.Application,
			NotificationId = notification.NotificationId,
			Intent = notification.Intent,
			NewContentNotificationType = notification.NewContentNotificationType
		};
		lock (_SqsBatchSenderLock)
		{
			SqsBatchSender publisher = _PushFallbackPublisher;
			if (publisher != null)
			{
				publisher.SendMessage(JsonConvert.SerializeObject(eventToPublish));
				return true;
			}
			_Logger.Error("No Publisher available to publish Fallback Notification Delivery Request");
			return false;
		}
	}

	private string GetPushNotificationContentDefinition(PushNotificationIntent intent, NotificationSourceType? notificationType)
	{
		string notificationTypeStr = "Unknown";
		if (notificationType.HasValue)
		{
			notificationTypeStr = notificationType.Value.ToString();
		}
		return $"{notificationTypeStr}_{intent.ToString()}";
	}

	private bool IsNudgeSystemDeliveryEnabledOnSettings(IUser user, NotificationSourceType? notificationType)
	{
		bool featureEnabledOnSettings = IsFeaturedEnabledOnSettings(user, Settings.Default.IsNudgeSystemDeliveryForSoothsayersEnabled, Settings.Default.IsNudgeSystemDeliveryForBetaTestersEnabled, Settings.Default.NudgeSystemDeliveryRolloutPercentage, Settings.Default.IsNudgeSystemDeliveryForAllEnabled);
		if (!notificationType.HasValue || string.IsNullOrWhiteSpace(Settings.Default.NudgeSystemDistributionEnabledSourceTypes))
		{
			return featureEnabledOnSettings;
		}
		string[] enabledTypesList = Settings.Default.NudgeSystemDistributionEnabledSourceTypes.Split(',');
		if (featureEnabledOnSettings)
		{
			return enabledTypesList.Any((string enabledType) => enabledType.Trim().Equals(notificationType.Value.ToString(), StringComparison.InvariantCultureIgnoreCase));
		}
		return false;
	}

	private bool IsFeaturedEnabledOnSettings(IUser user, bool soothsayerSetting = false, bool betaTesterSetting = false, int rolloutPercentageSetting = 0, bool turnOnForAllSetting = false)
	{
		if (user == null)
		{
			return false;
		}
		if (turnOnForAllSetting)
		{
			return true;
		}
		if ((!soothsayerSetting || !user.IsSoothSayer()) && (!betaTesterSetting || !user.IsBetaTester()))
		{
			return rolloutPercentageSetting > user.Id % 100;
		}
		return true;
	}
}
