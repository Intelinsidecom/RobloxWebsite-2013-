using System.Collections.Generic;
using System.Diagnostics;
using Roblox.ApiClientBase.Properties;
using Roblox.Instrumentation;

namespace Roblox.ApiClientBase.Monitoring;

public class ClientMonitor
{
	private readonly Dictionary<string, PerInstancePerformanceMonitor> _ActionMonitors = new Dictionary<string, PerInstancePerformanceMonitor>();

	private readonly string _Category;

	private readonly string _ClientName;

	private IRateOfCountsPerSecondCounter _FailuresPerSecond;

	private IRateOfCountsPerSecondCounter _RequestsPerSecond;

	private IAverageValueCounter _AverageResponseTime;

	private IPercentileCounter _PercentileResponseTime;

	private const string _FailuresPerSecondCounterName = "Failures/s";

	private const string _RequestsPerSecondCounterName = "Requests/s";

	private const string _AverageResponseTimeCounterName = "Average Response Time";

	private const string _PercentileResponseTimeCounterName = "ResponseTime";

	private static readonly Dictionary<string, ClientMonitor> _ClientMonitors = new Dictionary<string, ClientMonitor>();

	private static readonly byte[] _Percentiles = new byte[5] { 25, 50, 75, 95, 99 };

	private ICounterRegistry _CounterRegistry;

	private const string _TotalInstanceName = "_Total";

	private const string _GlobalCategoryName = "Roblox.ApiClient";

	private const string _ClientCategoryPrefix = "Roblox.ApiClient.";

	private PerInstancePerformanceMonitor TotalActionMonitor => GetOrCreateAction("_Total");

	private bool ResponseTimePercentileMonitorsEnabled => Settings.Default.ResponseTimePercentilePerformanceMonitorsEnabled;

	private ClientMonitor(ICounterRegistry counterRegistry, string clientName)
	{
		_ClientName = clientName;
		_Category = "Roblox.ApiClient." + clientName;
		InitializeCounters(counterRegistry);
	}

	private void InitializeCounters(ICounterRegistry counterRegistry)
	{
		_CounterRegistry = counterRegistry;
		GetOrCreateAction("_Total");
		_FailuresPerSecond = counterRegistry.GetRateOfCountsPerSecondCounter("Roblox.ApiClient", "Failures/s", _ClientName);
		_RequestsPerSecond = counterRegistry.GetRateOfCountsPerSecondCounter("Roblox.ApiClient", "Requests/s", _ClientName);
		_AverageResponseTime = counterRegistry.GetAverageValueCounter("Roblox.ApiClient", "Average Response Time", _ClientName);
		_PercentileResponseTime = counterRegistry.GetPercentileCounter("Roblox.ApiClient", "ResponseTime.Percentile.{0}", _Percentiles, _ClientName);
	}

	private PerInstancePerformanceMonitor GetOrCreateAction(string actionName)
	{
		if (_ActionMonitors.TryGetValue(actionName, out var value))
		{
			return value;
		}
		lock (_ActionMonitors)
		{
			if (_ActionMonitors.TryGetValue(actionName, out value))
			{
				return value;
			}
			if (string.IsNullOrEmpty(actionName))
			{
				actionName = "(root)";
			}
			PerInstancePerformanceMonitor perInstancePerformanceMonitor = new PerInstancePerformanceMonitor(_CounterRegistry, _Category, actionName);
			_ActionMonitors.Add(actionName, perInstancePerformanceMonitor);
			return perInstancePerformanceMonitor;
		}
	}

	public void AddRequestFailure(string actionName)
	{
		TotalActionMonitor.FailuresPerSecond.Increment();
		GetOrCreateAction(actionName).FailuresPerSecond.Increment();
		_FailuresPerSecond.Increment();
	}

	public void AddRequestSuccess(string actionName)
	{
		TotalActionMonitor.RequestsPerSecond.Increment();
		GetOrCreateAction(actionName).RequestsPerSecond.Increment();
		_RequestsPerSecond.Increment();
	}

	public void AddResponseTime(string actionName, Stopwatch duration)
	{
		double totalMilliseconds = duration.Elapsed.TotalMilliseconds;
		TotalActionMonitor.AverageResponseTime.Sample(totalMilliseconds);
		GetOrCreateAction(actionName).AverageResponseTime.Sample(totalMilliseconds);
		_AverageResponseTime.Sample(duration.ElapsedMilliseconds);
		if (ResponseTimePercentileMonitorsEnabled)
		{
			_PercentileResponseTime.Sample(duration.ElapsedMilliseconds);
		}
	}

	public void AddOutstandingRequest(string actionName)
	{
		TotalActionMonitor.RequestsOutstanding.Increment();
		GetOrCreateAction(actionName).RequestsOutstanding.Increment();
	}

	public void RemoveOutstandingRequest(string actionName)
	{
		TotalActionMonitor.RequestsOutstanding.Decrement();
		GetOrCreateAction(actionName).RequestsOutstanding.Decrement();
	}

	public static ClientMonitor GetOrCreate(ICounterRegistry counterRegistry, string clientName)
	{
		if (_ClientMonitors.TryGetValue(clientName, out var value))
		{
			return value;
		}
		lock (_ClientMonitors)
		{
			if (_ClientMonitors.TryGetValue(clientName, out value))
			{
				return value;
			}
			value = new ClientMonitor(counterRegistry, clientName);
			_ClientMonitors.Add(clientName, value);
			return value;
		}
	}
}
