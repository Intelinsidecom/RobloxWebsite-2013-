using System;
using Roblox.EphemeralCounters;
using Roblox.EventLog;
using Roblox.Instrumentation;
using Roblox.Platform.EventStream;
using Roblox.Platform.EventStream.WebEvents;

namespace Roblox.Platform.Notifications.Push;

public class PushMetricsTracker : IPushMetricsTracker
{
	private readonly PerformanceMonitor _PerformanceMonitor;

	private readonly EphemeralCounters _EphemeralCounters;

	private readonly EventStreamer _Streamer;

	public PushMetricsTracker(ICounterRegistry counterRegistry, string performanceCategoryPrefix, EphemeralCounterFactory ephemeralCounterFactory, ILogger logger)
	{
		if (counterRegistry == null)
		{
			throw new ArgumentNullException("counterRegistry");
		}
		string performanceCategory = performanceCategoryPrefix + ".Push";
		_PerformanceMonitor = new PerformanceMonitor(performanceCategory);
		_EphemeralCounters = new EphemeralCounters(performanceCategory, ephemeralCounterFactory, logger);
		_Streamer = new EventStreamer(counterRegistry, logger);
	}

	public void IncrementRegistration(PushApplicationType application, PushPlatformType platform, bool userInitiated, bool newReceiverDestinationCreated)
	{
		_PerformanceMonitor.IncrementRegistrationCounter(application, platform);
		if (userInitiated)
		{
			_PerformanceMonitor.IncrementUserInitiatedRegistrationCounter(application, platform);
		}
	}

	public void IncrementRegistrationEvent(PushApplicationType application, PushPlatformType platform, PushRegistrationEventType registrationEventType)
	{
		_PerformanceMonitor.IncrementRegistrationEvent(application, platform, registrationEventType);
	}

	public void IncrementDestinationExpiry(PushApplicationType application, PushPlatformType platform, int? receiverTypeId, long? receiverTargetId)
	{
		_EphemeralCounters.IncrementDeliveryFailedCounter(application, platform, "Permanent Destination Failure");
		new PushNotificationRegistrationEvent(_Streamer, new PushNotificationRegistrationEventArgs
		{
			Target = EventTarget.Www,
			Context = "expired",
			PlatformType = platform.ToString(),
			UserId = receiverTargetId
		}).Stream();
	}

	public void IncrementDeliveryAttempted(string notificationType, PushApplicationType application, PushPlatformType platform, DeliveryAttemptType attempt)
	{
		switch (attempt)
		{
		case DeliveryAttemptType.Primary:
			_PerformanceMonitor.IncrementDeliveriesAttemptedPerSecond(notificationType, application, platform);
			break;
		case DeliveryAttemptType.Fallback:
			_PerformanceMonitor.IncrementFallbackDeliveriesAttemptedPerSecond(notificationType, application, platform);
			break;
		default:
			_PerformanceMonitor.IncrementDeliveriesAttemptedPerSecond(notificationType, application, platform);
			break;
		}
	}

	public void IncrementMetadataRead(string notificationType, PushApplicationType application, PushPlatformType platform, DateTime notificationDeliveryStarted, DateTime metadataRead)
	{
		_PerformanceMonitor.IncrementMetadataReadPerSecond(notificationType, application, platform);
		TimeSpan timespan = metadataRead.Subtract(notificationDeliveryStarted);
		_PerformanceMonitor.RecordDeliveryToDestinationTime(application, platform, timespan);
	}

	public void IncrementMetadataRetrieveFailure(PushApplicationType application, PushPlatformType platform)
	{
		_PerformanceMonitor.IncrementMetadataRetrieveFailureCounter(application, platform);
	}

	public void IncrementInteraction(string notificationType, PushNotificationInteractionType interactionType, PushApplicationType application, PushPlatformType platform, DateTime notificationDelivered, DateTime interactionRecorded)
	{
		_PerformanceMonitor.IncrementInteractionsPerSecond(notificationType, interactionType, application, platform);
		TimeSpan timespan = interactionRecorded.Subtract(notificationDelivered);
		_PerformanceMonitor.RecordFromDeliveryToInteractionTime(notificationType, application, platform, timespan);
	}

	public void IncrementDestinationFlooded(PushApplicationType application, PushPlatformType platform)
	{
		_EphemeralCounters.IncrementDestinationFloodedCounter(application, platform);
	}

	public void IncrementDestinationAndTypeCombinationFlooded(string notificationType, PushApplicationType application)
	{
		_EphemeralCounters.IncrementDestinationAndTypeCombinationFlooded(application, notificationType);
	}
}
