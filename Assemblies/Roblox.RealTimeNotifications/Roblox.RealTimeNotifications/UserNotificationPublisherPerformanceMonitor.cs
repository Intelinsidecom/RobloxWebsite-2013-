using System;
using System.Collections.Generic;
using System.Linq;
using Roblox.Diagnostics;
using Roblox.EventLog;
using Roblox.RealTimeNotifications.Properties;

namespace Roblox.RealTimeNotifications;

/// <summary>
/// Performance monitor for <see cref="T:Roblox.RealTimeNotifications.UserNotificationPublisher`1" />
/// </summary>
public class UserNotificationPublisherPerformanceMonitor : IUserNotificationPublisherPerformanceMonitor
{
	private readonly ILogger _Logger;

	private readonly string _PerformanceCategory;

	private readonly Dictionary<string, IPerformanceCounter> UserNotificationPublishResultCounters = new Dictionary<string, IPerformanceCounter>();

	private bool IsUserNotificationPublisherPerformanceMonitorEnabled => Settings.Default.IsUserNotificationPublisherPerformanceMonitorEnabled;

	public UserNotificationPublisherPerformanceMonitor(ILogger logger, string performanceCategory)
	{
		_Logger = logger ?? throw new ArgumentNullException("logger");
		_PerformanceCategory = performanceCategory ?? throw new ArgumentNullException("performanceCategory");
		try
		{
			Enum.GetValues(typeof(UserNotificationPublishResult)).Cast<UserNotificationPublishResult>().Select(TranslateToInstanceName)
				.ToList()
				.ForEach(CreateUserNotificationPublishResultCounter);
		}
		catch (Exception ex)
		{
			_Logger?.Error(ex);
		}
	}

	public void LogUserNotificationPublishResult(UserNotificationPublishResult result, long recipients)
	{
		if (!IsUserNotificationPublisherPerformanceMonitorEnabled)
		{
			return;
		}
		try
		{
			string instanceName = TranslateToInstanceName(result);
			UserNotificationPublishResultCounters[instanceName].Increment();
		}
		catch (Exception ex)
		{
			_Logger?.Error($"Error in LogUserNotificationPublishResult({result.ToString()}) - {ex}");
		}
	}

	private string TranslateToInstanceName(UserNotificationPublishResult result)
	{
		return "UserNotificationPublishResult".ToLower() + result.ToString().ToLower();
	}

	private void CreateUserNotificationPublishResultCounter(string instanceName)
	{
		CounterBuilder counterBuilder = new CounterBuilder(_PerformanceCategory, this, null, instanceName);
		counterBuilder.AddRateOfCountsPerSecond32Counter("UserNotificationPublishResult", delegate(IPerformanceCounter counter)
		{
			UserNotificationPublishResultCounters[instanceName] = counter;
		});
		counterBuilder.Create();
	}
}
