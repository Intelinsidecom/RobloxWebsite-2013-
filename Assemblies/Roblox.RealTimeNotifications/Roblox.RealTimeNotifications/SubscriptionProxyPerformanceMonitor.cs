using System;
using System.Collections.Generic;
using System.Linq;
using Roblox.Diagnostics;
using Roblox.EventLog;
using Roblox.RealTimeNotifications.Properties;
using StackExchange.Redis;

namespace Roblox.RealTimeNotifications;

/// <summary>
/// Performance monitor for <see cref="T:Roblox.RealTimeNotifications.SubscriptionProxy`3" />
/// </summary>
public class SubscriptionProxyPerformanceMonitor
{
	private const string _RedisClientRefreshedReason = "Redis Client Refreshed";

	private const string _RedisClientRefreshedInstanceName = "redisclientrefreshed";

	private const string _UnknownReasonInstanceName = "unknown";

	private const string _EmptyReasonInstanceName = "empty";

	private readonly ILogger _Logger;

	private readonly string _PerformanceCategory;

	private readonly Dictionary<string, IPerformanceCounter> ServerDisconnectedCounters = new Dictionary<string, IPerformanceCounter>();

	private bool IsSubscriptionProxyPerformanceMonitorEnabled => Settings.Default.IsSubscriptionProxyPerformanceMonitorEnabled;

	public SubscriptionProxyPerformanceMonitor(ILogger logger, string performanceCategory)
	{
		_Logger = logger ?? throw new ArgumentNullException("logger");
		_PerformanceCategory = performanceCategory ?? throw new ArgumentNullException("performanceCategory");
		try
		{
			CreateSubscriptionServerDisconnectCounter("empty");
			CreateSubscriptionServerDisconnectCounter("unknown");
			CreateSubscriptionServerDisconnectCounter("redisclientrefreshed");
			Enum.GetValues(typeof(ConnectionFailureType)).Cast<ConnectionFailureType>().Select(TranslateToInstanceName)
				.ToList()
				.ForEach(CreateSubscriptionServerDisconnectCounter);
		}
		catch (Exception ex)
		{
			_Logger.Error(ex);
		}
	}

	/// <summary>
	/// Count the events of subscription server disconnection.
	/// </summary>
	/// <param name="serverId"></param>
	/// <param name="reason"></param>
	public void LogSubscriptionServerDisconnectEvent(string serverId, string reason)
	{
		if (!IsSubscriptionProxyPerformanceMonitorEnabled)
		{
			return;
		}
		try
		{
			string instanceName = TranslateToInstanceName(reason);
			ServerDisconnectedCounters[instanceName].Increment();
		}
		catch (Exception ex)
		{
			_Logger?.Error($"Error in LogSubscriptionServerDisconnectEvent(reason:{reason}) - {ex}");
		}
	}

	private string TranslateToInstanceName(ConnectionFailureType connectionFailureType)
	{
		return "ConnectionFailureType".ToLower() + connectionFailureType.ToString().ToLower();
	}

	private string TranslateToInstanceName(string reason)
	{
		if (string.IsNullOrWhiteSpace(reason))
		{
			return "empty";
		}
		if (reason == "Redis Client Refreshed")
		{
			return "redisclientrefreshed";
		}
		if (Enum.TryParse<ConnectionFailureType>(reason, out var connectionFailureType))
		{
			return TranslateToInstanceName(connectionFailureType);
		}
		_Logger.Error($"Unkown reason {reason}");
		return "unknown";
	}

	private void CreateSubscriptionServerDisconnectCounter(string instanceName)
	{
		CounterBuilder counterBuilder = new CounterBuilder(_PerformanceCategory, this, null, instanceName);
		counterBuilder.AddRateOfCountsPerSecond32Counter("SubscriptionServerDisconnect", delegate(IPerformanceCounter counter)
		{
			ServerDisconnectedCounters[instanceName] = counter;
		});
		counterBuilder.Create();
	}
}
