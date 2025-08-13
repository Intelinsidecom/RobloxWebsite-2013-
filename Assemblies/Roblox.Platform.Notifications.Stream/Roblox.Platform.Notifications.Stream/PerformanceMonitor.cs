using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using Roblox.Diagnostics;
using Roblox.EventLog;
using Roblox.Platform.Notifications.Core;

namespace Roblox.Platform.Notifications.Stream;

internal class PerformanceMonitor
{
	private readonly string _PerformanceCounterCategory;

	private readonly object _CounterCreationLock = new object();

	private Dictionary<MissingStreamNotificationType, PerformanceCounter> _MissingStreamNotificationsCounters;

	private Dictionary<NotificationSourceType, PerformanceCounter> _BuildNotificationDetailErrorCounters;

	internal PerformanceMonitor(string performanceCounterCategory, ILogger logger)
	{
		_PerformanceCounterCategory = performanceCounterCategory;
		try
		{
			CreateMissingStreamNotificationsCounters();
			CreateBuildNotificationDetailErrorCounters();
		}
		catch (Exception e)
		{
			logger?.Error(e);
		}
	}

	public void IncrementMissingStreamNotificationCounter(MissingStreamNotificationType type)
	{
		if (_MissingStreamNotificationsCounters != null && _MissingStreamNotificationsCounters.TryGetValue(type, out var missingStreamNotificationCounter))
		{
			missingStreamNotificationCounter?.Increment();
		}
	}

	public void IncrementBuildNotificationDetailErrorCounter(NotificationSourceType type)
	{
		if (_BuildNotificationDetailErrorCounters != null && _BuildNotificationDetailErrorCounters.TryGetValue(type, out var buildNotificationErrorCounter))
		{
			buildNotificationErrorCounter?.Increment();
		}
	}

	private void CreateMissingStreamNotificationsCounters()
	{
		_MissingStreamNotificationsCounters = new Dictionary<MissingStreamNotificationType, PerformanceCounter>();
		CreateNotificationStreamCounters(_MissingStreamNotificationsCounters, ".MissingStreamNotifications", PerformanceCounterType.RateOfCountsPerSecond32);
	}

	private void CreateBuildNotificationDetailErrorCounters()
	{
		_BuildNotificationDetailErrorCounters = new Dictionary<NotificationSourceType, PerformanceCounter>();
		CreateNotificationStreamCounters(_BuildNotificationDetailErrorCounters, ".BuildNotificationDetailError", PerformanceCounterType.RateOfCountsPerSecond32);
	}

	private void CreateNotificationStreamCounters<T>(Dictionary<T, PerformanceCounter> counters, string perfCategorySuffix, PerformanceCounterType counterType) where T : struct
	{
		if (counters == null)
		{
			throw new ArgumentNullException("counters");
		}
		if (!typeof(T).IsEnum)
		{
			throw new ArgumentException("Create Notification Site Stream counters method expects Enum");
		}
		CounterDescriptor[] descriptors = (from T t in Enum.GetValues(typeof(T))
			select new CounterDescriptor(t.ToString(), delegate(PerformanceCounter pc)
			{
				counters[t] = pc;
			}, counterType)).ToArray();
		CounterCreator.InitializeMultiInstance(_PerformanceCounterCategory + perfCategorySuffix, "_Total", descriptors);
	}
}
