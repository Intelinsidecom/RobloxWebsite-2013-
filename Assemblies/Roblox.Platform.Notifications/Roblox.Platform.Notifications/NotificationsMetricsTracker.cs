using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using Roblox.Diagnostics;
using Roblox.Platform.Notifications.Core;
using Roblox.Platform.Notifications.Metrics;

namespace Roblox.Platform.Notifications;

public class NotificationsMetricsTracker : INotificationsMetricsTracker
{
	private readonly string _CategoryNameBySource;

	private readonly string _CategoryNameByDestination;

	private readonly string _CategoryNameByStatus;

	private const string TotalName = "_Total";

	private readonly Dictionary<string, Dictionary<string, PerformanceCounter>> _Counters = new Dictionary<string, Dictionary<string, PerformanceCounter>>();

	public NotificationsMetricsTracker(string categoryName)
	{
		_CategoryNameBySource = $"{categoryName}.NotificationMetrics.Source";
		_CategoryNameByDestination = $"{categoryName}.NotificationMetrics.Destination";
		_CategoryNameByStatus = $"{categoryName}.NotificationMetrics.Status";
		List<PerformanceCountersBySource> source = new List<PerformanceCountersBySource>((PerformanceCountersBySource[])Enum.GetValues(typeof(PerformanceCountersBySource)));
		List<PerformanceCountersByDestination> destinationTypes = new List<PerformanceCountersByDestination>((PerformanceCountersByDestination[])Enum.GetValues(typeof(PerformanceCountersByDestination)));
		List<PerformanceCountersByStatus> statusTypes = new List<PerformanceCountersByStatus>((PerformanceCountersByStatus[])Enum.GetValues(typeof(PerformanceCountersByStatus)));
		IEnumerable<CounterDescriptor> sourceTypeDescriptors = source.SelectMany((PerformanceCountersBySource t) => GetCounterDescriptors(t.ToString(), "_Total"));
		CounterCreator.InitializeMultiInstance(_CategoryNameBySource, "_Total", sourceTypeDescriptors.ToArray());
		IEnumerable<CounterDescriptor> destinationTypeDescriptors = destinationTypes.SelectMany((PerformanceCountersByDestination t) => GetCounterDescriptors(t.ToString(), "_Total"));
		CounterCreator.InitializeMultiInstance(_CategoryNameByDestination, "_Total", destinationTypeDescriptors.ToArray());
		IEnumerable<CounterDescriptor> statusTypeDescriptors = statusTypes.SelectMany((PerformanceCountersByStatus t) => GetCounterDescriptors(t.ToString(), "_Total"));
		CounterCreator.InitializeMultiInstance(_CategoryNameByStatus, "_Total", statusTypeDescriptors.ToArray());
	}

	private IEnumerable<CounterDescriptor> GetCounterDescriptors(string performanceCounterName, string instanceName)
	{
		PerformanceCounterType type = GetPerformanceCounterType(performanceCounterName);
		if (type == PerformanceCounterType.AverageCount64 || type == PerformanceCounterType.AverageTimer32)
		{
			if (!_Counters.ContainsKey(performanceCounterName))
			{
				_Counters[performanceCounterName] = new Dictionary<string, PerformanceCounter>();
				_Counters[GetBaseCounterKey(performanceCounterName)] = new Dictionary<string, PerformanceCounter>();
			}
			return new List<CounterDescriptor>
			{
				new CounterDescriptor(performanceCounterName, delegate(PerformanceCounter v)
				{
					_Counters[performanceCounterName][instanceName] = v;
				}, type),
				new CounterDescriptor(GetBaseCounterKey(performanceCounterName), delegate(PerformanceCounter v)
				{
					_Counters[GetBaseCounterKey(performanceCounterName)][instanceName] = v;
				}, PerformanceCounterType.AverageBase)
			};
		}
		if (!_Counters.ContainsKey(performanceCounterName))
		{
			_Counters[performanceCounterName] = new Dictionary<string, PerformanceCounter>();
		}
		return new List<CounterDescriptor>
		{
			new CounterDescriptor(performanceCounterName, delegate(PerformanceCounter v)
			{
				_Counters[performanceCounterName][instanceName] = v;
			}, type)
		};
	}

	private PerformanceCounterType GetPerformanceCounterType(string counterName)
	{
		if (counterName == PerformanceCountersBySource.DistributionTimeBySource.ToString() || counterName == PerformanceCountersBySource.UpdateTimeBySource.ToString())
		{
			return PerformanceCounterType.AverageTimer32;
		}
		if (counterName == PerformanceCountersBySource.ChannelsPerReceiverBySource.ToString() || counterName == PerformanceCountersBySource.ReceiversPerMessageBySource.ToString())
		{
			return PerformanceCounterType.AverageCount64;
		}
		return PerformanceCounterType.RateOfCountsPerSecond32;
	}

	private PerformanceCounter GetOrCreatePerformanceCounter(string category, string counterName, string instanceName)
	{
		if (_Counters.ContainsKey(counterName) && _Counters[counterName].ContainsKey(instanceName))
		{
			return _Counters[counterName][instanceName];
		}
		IEnumerable<CounterDescriptor> descriptor = GetCounterDescriptors(counterName, instanceName);
		CounterCreator.InitializeMultiInstance(category, instanceName, descriptor.ToArray());
		return _Counters[counterName][instanceName];
	}

	private string GetBaseCounterKey(string instanceName)
	{
		return $"{instanceName}_Base";
	}

	public void TrackNotificationDelivery(NotificationSourceType notificationSourceType, ReceiverDestinationType receiverDestinationType, bool wasSuccess)
	{
		GetOrCreatePerformanceCounter(_CategoryNameBySource, PerformanceCountersBySource.DeliveryAttemptsBySource.ToString(), "_Total").Increment();
		GetOrCreatePerformanceCounter(_CategoryNameBySource, PerformanceCountersBySource.DeliveryAttemptsBySource.ToString(), notificationSourceType.ToString()).Increment();
		GetOrCreatePerformanceCounter(_CategoryNameByDestination, PerformanceCountersByDestination.DeliveryAttemptsByDestination.ToString(), "_Total").Increment();
		GetOrCreatePerformanceCounter(_CategoryNameByDestination, PerformanceCountersByDestination.DeliveryAttemptsByDestination.ToString(), receiverDestinationType.ToString()).Increment();
		if (wasSuccess)
		{
			GetOrCreatePerformanceCounter(_CategoryNameBySource, PerformanceCountersBySource.DeliverySuccessBySource.ToString(), "_Total").Increment();
			GetOrCreatePerformanceCounter(_CategoryNameBySource, PerformanceCountersBySource.DeliverySuccessBySource.ToString(), notificationSourceType.ToString()).Increment();
			GetOrCreatePerformanceCounter(_CategoryNameByDestination, PerformanceCountersByDestination.DeliverySuccessByDestination.ToString(), "_Total").Increment();
			GetOrCreatePerformanceCounter(_CategoryNameByDestination, PerformanceCountersByDestination.DeliverySuccessByDestination.ToString(), receiverDestinationType.ToString()).Increment();
		}
		else
		{
			GetOrCreatePerformanceCounter(_CategoryNameBySource, PerformanceCountersBySource.DeliveryErrorsBySource.ToString(), "_Total").Increment();
			GetOrCreatePerformanceCounter(_CategoryNameBySource, PerformanceCountersBySource.DeliveryErrorsBySource.ToString(), notificationSourceType.ToString()).Increment();
			GetOrCreatePerformanceCounter(_CategoryNameByDestination, PerformanceCountersByDestination.DeliveryErrorsByDestination.ToString(), "_Total").Increment();
			GetOrCreatePerformanceCounter(_CategoryNameByDestination, PerformanceCountersByDestination.DeliveryErrorsByDestination.ToString(), receiverDestinationType.ToString()).Increment();
		}
	}

	public void TrackNotificationUpdate(NotificationSourceType notificationSourceType, ReceiverDestinationType receiverDestinationType, bool wasSuccess)
	{
		GetOrCreatePerformanceCounter(_CategoryNameBySource, PerformanceCountersBySource.UpdateAttemptsBySource.ToString(), "_Total").Increment();
		GetOrCreatePerformanceCounter(_CategoryNameBySource, PerformanceCountersBySource.UpdateAttemptsBySource.ToString(), notificationSourceType.ToString()).Increment();
		GetOrCreatePerformanceCounter(_CategoryNameByDestination, PerformanceCountersByDestination.UpdateAttemptsByDestination.ToString(), "_Total").Increment();
		GetOrCreatePerformanceCounter(_CategoryNameByDestination, PerformanceCountersByDestination.UpdateAttemptsByDestination.ToString(), receiverDestinationType.ToString()).Increment();
		if (wasSuccess)
		{
			GetOrCreatePerformanceCounter(_CategoryNameBySource, PerformanceCountersBySource.UpdateSuccessBySource.ToString(), "_Total").Increment();
			GetOrCreatePerformanceCounter(_CategoryNameBySource, PerformanceCountersBySource.UpdateSuccessBySource.ToString(), notificationSourceType.ToString()).Increment();
			GetOrCreatePerformanceCounter(_CategoryNameByDestination, PerformanceCountersByDestination.UpdateSuccessByDestination.ToString(), "_Total").Increment();
			GetOrCreatePerformanceCounter(_CategoryNameByDestination, PerformanceCountersByDestination.UpdateSuccessByDestination.ToString(), receiverDestinationType.ToString()).Increment();
		}
		else
		{
			GetOrCreatePerformanceCounter(_CategoryNameBySource, PerformanceCountersBySource.UpdateErrorsBySource.ToString(), "_Total").Increment();
			GetOrCreatePerformanceCounter(_CategoryNameBySource, PerformanceCountersBySource.UpdateErrorsBySource.ToString(), notificationSourceType.ToString()).Increment();
			GetOrCreatePerformanceCounter(_CategoryNameByDestination, PerformanceCountersByDestination.UpdateErrorsByDestination.ToString(), "_Total").Increment();
			GetOrCreatePerformanceCounter(_CategoryNameByDestination, PerformanceCountersByDestination.UpdateErrorsByDestination.ToString(), receiverDestinationType.ToString()).Increment();
		}
	}

	public void TrackDistributionComplete(NotificationSourceType notificationSourceType, Stopwatch stopwatch, int numberOfReceivers, int totalNumberOfChannels)
	{
		GetOrCreatePerformanceCounter(_CategoryNameBySource, PerformanceCountersBySource.ReceiversPerMessageBySource.ToString(), "_Total").IncrementBy(numberOfReceivers);
		GetOrCreatePerformanceCounter(_CategoryNameBySource, PerformanceCountersBySource.ReceiversPerMessageBySource.ToString(), notificationSourceType.ToString()).IncrementBy(numberOfReceivers);
		GetOrCreatePerformanceCounter(_CategoryNameBySource, GetBaseCounterKey(PerformanceCountersBySource.ReceiversPerMessageBySource.ToString()), "_Total").Increment();
		GetOrCreatePerformanceCounter(_CategoryNameBySource, GetBaseCounterKey(PerformanceCountersBySource.ReceiversPerMessageBySource.ToString()), notificationSourceType.ToString()).Increment();
		if (numberOfReceivers > 0)
		{
			GetOrCreatePerformanceCounter(_CategoryNameBySource, PerformanceCountersBySource.ChannelsPerReceiverBySource.ToString(), "_Total").IncrementBy(totalNumberOfChannels / numberOfReceivers);
			GetOrCreatePerformanceCounter(_CategoryNameBySource, PerformanceCountersBySource.ChannelsPerReceiverBySource.ToString(), notificationSourceType.ToString()).IncrementBy(totalNumberOfChannels / numberOfReceivers);
			GetOrCreatePerformanceCounter(_CategoryNameBySource, GetBaseCounterKey(PerformanceCountersBySource.ChannelsPerReceiverBySource.ToString()), "_Total").Increment();
			GetOrCreatePerformanceCounter(_CategoryNameBySource, GetBaseCounterKey(PerformanceCountersBySource.ChannelsPerReceiverBySource.ToString()), notificationSourceType.ToString()).Increment();
		}
		GetOrCreatePerformanceCounter(_CategoryNameBySource, PerformanceCountersBySource.DistributionTimeBySource.ToString(), "_Total").IncrementBy(stopwatch.ElapsedTicks * 1000);
		GetOrCreatePerformanceCounter(_CategoryNameBySource, PerformanceCountersBySource.DistributionTimeBySource.ToString(), notificationSourceType.ToString()).IncrementBy(stopwatch.ElapsedTicks * 1000);
		GetOrCreatePerformanceCounter(_CategoryNameBySource, GetBaseCounterKey(PerformanceCountersBySource.DistributionTimeBySource.ToString()), "_Total").Increment();
		GetOrCreatePerformanceCounter(_CategoryNameBySource, GetBaseCounterKey(PerformanceCountersBySource.DistributionTimeBySource.ToString()), notificationSourceType.ToString()).Increment();
	}

	public void TrackUpdateComplete(NotificationSourceType notificationSourceType, Stopwatch stopwatch)
	{
		GetOrCreatePerformanceCounter(_CategoryNameBySource, PerformanceCountersBySource.UpdateTimeBySource.ToString(), "_Total").IncrementBy(stopwatch.ElapsedTicks * 1000);
		GetOrCreatePerformanceCounter(_CategoryNameBySource, PerformanceCountersBySource.UpdateTimeBySource.ToString(), notificationSourceType.ToString()).IncrementBy(stopwatch.ElapsedTicks * 1000);
		GetOrCreatePerformanceCounter(_CategoryNameBySource, GetBaseCounterKey(PerformanceCountersBySource.UpdateTimeBySource.ToString()), "_Total").Increment();
		GetOrCreatePerformanceCounter(_CategoryNameBySource, GetBaseCounterKey(PerformanceCountersBySource.UpdateTimeBySource.ToString()), notificationSourceType.ToString()).Increment();
	}

	public void TrackUpdateLookupFailure(ReceiverNotificationStatus updatedStatus)
	{
		GetOrCreatePerformanceCounter(_CategoryNameByStatus, PerformanceCountersByStatus.UpdateLookupErrorsByStatus.ToString(), "_Total").Increment();
		GetOrCreatePerformanceCounter(_CategoryNameByStatus, PerformanceCountersByStatus.UpdateLookupErrorsByStatus.ToString(), updatedStatus.ToString()).Increment();
	}
}
