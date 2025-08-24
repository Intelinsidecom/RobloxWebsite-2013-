using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using Roblox.Diagnostics;

namespace Roblox.Platform.Notifications.Push;

internal class PerformanceMonitor
{
	private readonly string _PerformanceCounterCategory;

	private readonly object _CounterCreationLock = new object();

	private readonly Dictionary<PerformanceMonitorCategory, PerformanceCounter> _CounterLookup = new Dictionary<PerformanceMonitorCategory, PerformanceCounter>();

	private readonly Dictionary<PerformanceMonitorCategory, Dictionary<string, PerformanceCounter>> _CounterMultiInstanceLookup = new Dictionary<PerformanceMonitorCategory, Dictionary<string, PerformanceCounter>>();

	internal PerformanceMonitor(string performanceCounterCategory)
	{
		_PerformanceCounterCategory = performanceCounterCategory + "V3";
		List<PerformanceMonitorCategory> list = new List<PerformanceMonitorCategory>((PerformanceMonitorCategory[])Enum.GetValues(typeof(PerformanceMonitorCategory)));
		CounterDescriptor[] descriptorCollection = list.Select((PerformanceMonitorCategory entry) => new CounterDescriptor(entry.ToString(), delegate(PerformanceCounter v)
		{
			_CounterLookup[entry] = v;
		}, PerformanceCounterType.RateOfCountsPerSecond32)).ToArray();
		list.ForEach(delegate(PerformanceMonitorCategory category)
		{
			_CounterMultiInstanceLookup[category] = new Dictionary<string, PerformanceCounter>();
		});
		CounterCreator.InitializeMultiInstance(_PerformanceCounterCategory, "_Total", descriptorCollection);
	}

	public void IncrementMetadataRetrieveFailureCounter(PushApplicationType application, PushPlatformType platform)
	{
		_CounterLookup[PerformanceMonitorCategory.MetadataRetrieveFailure].Increment();
		GetDestinationTypeCounter(PerformanceMonitorCategory.MetadataRetrieveFailure, application, platform).Increment();
	}

	public void IncrementRegistrationCounter(PushApplicationType application, PushPlatformType platform)
	{
		_CounterLookup[PerformanceMonitorCategory.RegistrationsPerSecondDestinationType].Increment();
		GetDestinationTypeCounter(PerformanceMonitorCategory.RegistrationsPerSecondDestinationType, application, platform).Increment();
	}

	public void IncrementUserInitiatedRegistrationCounter(PushApplicationType application, PushPlatformType platform)
	{
		_CounterLookup[PerformanceMonitorCategory.UserInitiatedRegistrationsPerSecondDestinationType].Increment();
		GetDestinationTypeCounter(PerformanceMonitorCategory.UserInitiatedRegistrationsPerSecondDestinationType, application, platform).Increment();
	}

	public void IncrementRegistrationEvent(PushApplicationType application, PushPlatformType platform, PushRegistrationEventType registrationEventType)
	{
		_CounterLookup[PerformanceMonitorCategory.RegistrationEventsPerSecond].Increment();
		GetMultiInstanceCounter(PerformanceMonitorCategory.RegistrationEventsPerSecond, registrationEventType.ToString()).Increment();
		_CounterLookup[PerformanceMonitorCategory.RegistrationEventsPerSecondDestinationType].Increment();
		string destinationTypeInstanceName = string.Concat(registrationEventType, "_", InstrumentationUtilties.GetDestinationTypeString(application, platform));
		GetMultiInstanceCounter(PerformanceMonitorCategory.RegistrationEventsPerSecondDestinationType, destinationTypeInstanceName).Increment();
	}

	public void IncrementDeliveriesAttemptedPerSecond(string notificationType, PushApplicationType application, PushPlatformType platform)
	{
		_CounterLookup[PerformanceMonitorCategory.DeliveryAttemptedPerSecondNotificationType].Increment();
		GetNotificationTypeCounter(PerformanceMonitorCategory.DeliveryAttemptedPerSecondNotificationType, notificationType).Increment();
		_CounterLookup[PerformanceMonitorCategory.DeliveryAttemptedPerSecondDestinationType].Increment();
		GetDestinationTypeCounter(PerformanceMonitorCategory.DeliveryAttemptedPerSecondDestinationType, application, platform).Increment();
	}

	public void IncrementFallbackDeliveriesAttemptedPerSecond(string notificationType, PushApplicationType application, PushPlatformType platform)
	{
		_CounterLookup[PerformanceMonitorCategory.FallbackDeliveryAttemptedPerSecondDestinationType].Increment();
		GetDestinationTypeCounter(PerformanceMonitorCategory.FallbackDeliveryAttemptedPerSecondDestinationType, application, platform).Increment();
	}

	public void IncrementMetadataReadPerSecond(string notificationType, PushApplicationType application, PushPlatformType platform)
	{
		_CounterLookup[PerformanceMonitorCategory.MetadataReadPerSecondNotificationType].Increment();
		GetNotificationTypeCounter(PerformanceMonitorCategory.MetadataReadPerSecondNotificationType, notificationType).Increment();
		_CounterLookup[PerformanceMonitorCategory.MetadataReadPerSecondDestinationType].Increment();
		GetDestinationTypeCounter(PerformanceMonitorCategory.MetadataReadPerSecondDestinationType, application, platform).Increment();
	}

	public void RecordDeliveryToDestinationTime(PushApplicationType application, PushPlatformType platform, TimeSpan deliveryTime)
	{
		if (deliveryTime.TotalSeconds <= 1.0)
		{
			_CounterLookup[PerformanceMonitorCategory.DeliveryToDestinationTime1SecDestinationType].Increment();
			GetDestinationTypeCounter(PerformanceMonitorCategory.DeliveryToDestinationTime1SecDestinationType, application, platform).Increment();
		}
		else if (deliveryTime.TotalSeconds <= 2.0)
		{
			_CounterLookup[PerformanceMonitorCategory.DeliveryToDestinationTime2SecDestinationType].Increment();
			GetDestinationTypeCounter(PerformanceMonitorCategory.DeliveryToDestinationTime2SecDestinationType, application, platform).Increment();
		}
		else if (deliveryTime.TotalSeconds <= 5.0)
		{
			_CounterLookup[PerformanceMonitorCategory.DeliveryToDestinationTime5SecDestinationType].Increment();
			GetDestinationTypeCounter(PerformanceMonitorCategory.DeliveryToDestinationTime5SecDestinationType, application, platform).Increment();
		}
		else if (deliveryTime.TotalSeconds <= 20.0)
		{
			_CounterLookup[PerformanceMonitorCategory.DeliveryToDestinationTime20SecDestinationType].Increment();
			GetDestinationTypeCounter(PerformanceMonitorCategory.DeliveryToDestinationTime20SecDestinationType, application, platform).Increment();
		}
		else if (deliveryTime.TotalMinutes <= 1.0)
		{
			_CounterLookup[PerformanceMonitorCategory.DeliveryToDestinationTime1MinDestinationType].Increment();
			GetDestinationTypeCounter(PerformanceMonitorCategory.DeliveryToDestinationTime1MinDestinationType, application, platform).Increment();
		}
		else if (deliveryTime.TotalMinutes <= 5.0)
		{
			_CounterLookup[PerformanceMonitorCategory.DeliveryToDestinationTime5MinDestinationType].Increment();
			GetDestinationTypeCounter(PerformanceMonitorCategory.DeliveryToDestinationTime5MinDestinationType, application, platform).Increment();
		}
		else if (deliveryTime.TotalMinutes <= 60.0)
		{
			_CounterLookup[PerformanceMonitorCategory.DeliveryToDestinationTime1HourDestinationType].Increment();
			GetDestinationTypeCounter(PerformanceMonitorCategory.DeliveryToDestinationTime1SecDestinationType, application, platform).Increment();
		}
		else
		{
			_CounterLookup[PerformanceMonitorCategory.DeliveryToDestinationTimeOver1HourDestinationType].Increment();
			GetDestinationTypeCounter(PerformanceMonitorCategory.DeliveryToDestinationTimeOver1HourDestinationType, application, platform).Increment();
		}
	}

	public void IncrementInteractionsPerSecond(string notificationType, PushNotificationInteractionType interactionType, PushApplicationType application, PushPlatformType platform)
	{
		_CounterLookup[PerformanceMonitorCategory.InteractionsPerSecond].Increment();
		GetMultiInstanceCounter(PerformanceMonitorCategory.InteractionsPerSecond, interactionType.ToString()).Increment();
		_CounterLookup[PerformanceMonitorCategory.InteractionsPerSecondNotificationType].Increment();
		GetNotificationTypeCounter(PerformanceMonitorCategory.InteractionsPerSecondNotificationType, notificationType).Increment();
		_CounterLookup[PerformanceMonitorCategory.InteractionsPerSecondDestinationType].Increment();
		GetDestinationTypeCounter(PerformanceMonitorCategory.InteractionsPerSecondDestinationType, application, platform).Increment();
	}

	public void RecordFromDeliveryToInteractionTime(string notificationType, PushApplicationType application, PushPlatformType platform, TimeSpan interactionTime)
	{
		if (interactionTime.TotalSeconds <= 1.0)
		{
			_CounterLookup[PerformanceMonitorCategory.FromDeliveryToInteractionTime1SecNotificationType].Increment();
			GetNotificationTypeCounter(PerformanceMonitorCategory.FromDeliveryToInteractionTime1SecNotificationType, notificationType).Increment();
			_CounterLookup[PerformanceMonitorCategory.FromDeliveryToInteractionTime1SecDestinationType].Increment();
			GetDestinationTypeCounter(PerformanceMonitorCategory.FromDeliveryToInteractionTime1SecDestinationType, application, platform).Increment();
		}
		else if (interactionTime.TotalSeconds <= 2.0)
		{
			_CounterLookup[PerformanceMonitorCategory.FromDeliveryToInteractionTime2SecNotificationType].Increment();
			GetNotificationTypeCounter(PerformanceMonitorCategory.FromDeliveryToInteractionTime2SecNotificationType, notificationType).Increment();
			_CounterLookup[PerformanceMonitorCategory.FromDeliveryToInteractionTime2SecDestinationType].Increment();
			GetDestinationTypeCounter(PerformanceMonitorCategory.FromDeliveryToInteractionTime2SecDestinationType, application, platform).Increment();
		}
		else if (interactionTime.TotalSeconds <= 5.0)
		{
			_CounterLookup[PerformanceMonitorCategory.FromDeliveryToInteractionTime5SecNotificationType].Increment();
			GetNotificationTypeCounter(PerformanceMonitorCategory.FromDeliveryToInteractionTime5SecNotificationType, notificationType).Increment();
			_CounterLookup[PerformanceMonitorCategory.FromDeliveryToInteractionTime5SecDestinationType].Increment();
			GetDestinationTypeCounter(PerformanceMonitorCategory.FromDeliveryToInteractionTime5SecDestinationType, application, platform).Increment();
		}
		else if (interactionTime.TotalSeconds <= 20.0)
		{
			_CounterLookup[PerformanceMonitorCategory.FromDeliveryToInteractionTime20SecNotificationType].Increment();
			GetNotificationTypeCounter(PerformanceMonitorCategory.FromDeliveryToInteractionTime20SecNotificationType, notificationType).Increment();
			_CounterLookup[PerformanceMonitorCategory.FromDeliveryToInteractionTime20SecDestinationType].Increment();
			GetDestinationTypeCounter(PerformanceMonitorCategory.FromDeliveryToInteractionTime20SecDestinationType, application, platform).Increment();
		}
		else if (interactionTime.TotalMinutes <= 1.0)
		{
			_CounterLookup[PerformanceMonitorCategory.FromDeliveryToInteractionTime1MinNotificationType].Increment();
			GetNotificationTypeCounter(PerformanceMonitorCategory.FromDeliveryToInteractionTime1MinNotificationType, notificationType).Increment();
			_CounterLookup[PerformanceMonitorCategory.FromDeliveryToInteractionTime1MinDestinationType].Increment();
			GetDestinationTypeCounter(PerformanceMonitorCategory.FromDeliveryToInteractionTime1MinDestinationType, application, platform).Increment();
		}
		else if (interactionTime.TotalMinutes <= 5.0)
		{
			_CounterLookup[PerformanceMonitorCategory.FromDeliveryToInteractionTime5MinNotificationType].Increment();
			GetNotificationTypeCounter(PerformanceMonitorCategory.FromDeliveryToInteractionTime5MinNotificationType, notificationType).Increment();
			_CounterLookup[PerformanceMonitorCategory.FromDeliveryToInteractionTime5MinDestinationType].Increment();
			GetDestinationTypeCounter(PerformanceMonitorCategory.FromDeliveryToInteractionTime5MinDestinationType, application, platform).Increment();
		}
		else if (interactionTime.TotalMinutes <= 60.0)
		{
			_CounterLookup[PerformanceMonitorCategory.FromDeliveryToInteractionTime1HourNotificationType].Increment();
			GetNotificationTypeCounter(PerformanceMonitorCategory.FromDeliveryToInteractionTime1HourNotificationType, notificationType).Increment();
			_CounterLookup[PerformanceMonitorCategory.FromDeliveryToInteractionTime1HourDestinationType].Increment();
			GetDestinationTypeCounter(PerformanceMonitorCategory.FromDeliveryToInteractionTime1SecDestinationType, application, platform).Increment();
		}
		else
		{
			_CounterLookup[PerformanceMonitorCategory.FromDeliveryToInteractionTimeOver1HourNotificationType].Increment();
			GetNotificationTypeCounter(PerformanceMonitorCategory.FromDeliveryToInteractionTimeOver1HourNotificationType, notificationType).Increment();
			_CounterLookup[PerformanceMonitorCategory.FromDeliveryToInteractionTimeOver1HourDestinationType].Increment();
			GetDestinationTypeCounter(PerformanceMonitorCategory.FromDeliveryToInteractionTimeOver1HourDestinationType, application, platform).Increment();
		}
	}

	private PerformanceCounter GetNotificationTypeCounter(PerformanceMonitorCategory performanceMonitorCategory, string notificationType)
	{
		return GetMultiInstanceCounter(performanceMonitorCategory, notificationType);
	}

	private PerformanceCounter GetDestinationTypeCounter(PerformanceMonitorCategory performanceMonitorCategory, PushApplicationType application, PushPlatformType platform)
	{
		string destinationTypeString = InstrumentationUtilties.GetDestinationTypeString(application, platform);
		return GetMultiInstanceCounter(performanceMonitorCategory, destinationTypeString);
	}

	private PerformanceCounter GetMultiInstanceCounter(PerformanceMonitorCategory performanceMonitorCategory, string instanceName)
	{
		if (_CounterMultiInstanceLookup[performanceMonitorCategory].TryGetValue(instanceName, out var notificationTypeCounter))
		{
			return notificationTypeCounter;
		}
		lock (_CounterCreationLock)
		{
			if (_CounterMultiInstanceLookup[performanceMonitorCategory].TryGetValue(instanceName, out notificationTypeCounter))
			{
				return notificationTypeCounter;
			}
			notificationTypeCounter = CreateMultiInstanceCounter(performanceMonitorCategory, instanceName);
			_CounterMultiInstanceLookup[performanceMonitorCategory].Add(instanceName, notificationTypeCounter);
			return notificationTypeCounter;
		}
	}

	private PerformanceCounter CreateMultiInstanceCounter(PerformanceMonitorCategory performanceMonitorCategory, string instanceName)
	{
		PerformanceCounter counter = null;
		CounterDescriptor[] collection = new CounterDescriptor[1]
		{
			new CounterDescriptor(performanceMonitorCategory.ToString(), delegate(PerformanceCounter v)
			{
				counter = v;
			}, PerformanceCounterType.RateOfCountsPerSecond32)
		};
		CounterCreator.InitializeMultiInstance(_PerformanceCounterCategory, instanceName, collection);
		return counter;
	}
}
