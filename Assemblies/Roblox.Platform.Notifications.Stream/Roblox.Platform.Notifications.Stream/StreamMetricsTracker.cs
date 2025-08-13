using System;
using Roblox.EventLog;
using Roblox.Platform.Notifications.Core;

namespace Roblox.Platform.Notifications.Stream;

public class StreamMetricsTracker : IStreamMetricsTracker
{
	private readonly PerformanceMonitor _PerformanceMonitor;

	private readonly ILogger _Logger;

	public StreamMetricsTracker(string performanceCategoryPrefix, ILogger logger)
	{
		_PerformanceMonitor = new PerformanceMonitor(performanceCategoryPrefix + ".Stream", logger);
		_Logger = logger;
	}

	public void IncrementMissingStreamNotificationCounter(MissingStreamNotificationType type)
	{
		try
		{
			_PerformanceMonitor.IncrementMissingStreamNotificationCounter(type);
		}
		catch (Exception e)
		{
			_Logger.Error(e);
		}
	}

	public void IncrementBuildNotificationDetailErrorCounter(NotificationSourceType type)
	{
		try
		{
			_PerformanceMonitor.IncrementBuildNotificationDetailErrorCounter(type);
		}
		catch (Exception e)
		{
			_Logger.Error(e);
		}
	}
}
