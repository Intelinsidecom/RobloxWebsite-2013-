using System;
using System.Collections.Concurrent;
using System.Diagnostics;
using Roblox.Instrumentation;

namespace Roblox.Http.Client.Monitoring;

public class ClientRequestsMonitor
{
	private const string _FailuresPerSecondCounterName = "Failures/s";

	private const string _SuccessesPerSecondCounterName = "Requests/s";

	private const string _AverageResponseTimeCounterName = "Average Response Time";

	private const string _PercentileResponseTimeCounterName = "ResponseTime";

	private const string _TotalInstanceName = "_Total";

	private static readonly byte[] _Percentiles = new byte[5] { 25, 50, 75, 95, 99 };

	private static readonly ConcurrentDictionary<string, ClientRequestsMonitor> _ClientMonitors = new ConcurrentDictionary<string, ClientRequestsMonitor>();

	private readonly ICounterRegistry _CounterRegistry;

	private readonly ConcurrentDictionary<string, PerInstancePerformanceMonitor> _ActionMonitors = new ConcurrentDictionary<string, PerInstancePerformanceMonitor>();

	private readonly string _GlobalCategoryName;

	private readonly string _Category;

	private readonly string _ClientName;

	private IAverageValueCounter _AverageResponseTime;

	private IRateOfCountsPerSecondCounter _FailuresPerSecond;

	private IPercentileCounter _PercentileResponseTime;

	private IRateOfCountsPerSecondCounter _SuccessesPerSecond;

	private PerInstancePerformanceMonitor TotalActionMonitor => GetOrCreateAction("_Total");

	private ClientRequestsMonitor(ICounterRegistry counterRegistry, string globalCategoryName, string clientName)
	{
		if (string.IsNullOrWhiteSpace(globalCategoryName))
		{
			throw new ArgumentException("Must be something like Roblox.Http.ServiceClient", "globalCategoryName");
		}
		if (string.IsNullOrWhiteSpace(clientName))
		{
			throw new ArgumentException("Must identify the client like MyServiceClient", "clientName");
		}
		_CounterRegistry = counterRegistry ?? throw new ArgumentNullException("counterRegistry");
		_ClientName = clientName;
		_GlobalCategoryName = globalCategoryName;
		_Category = globalCategoryName + "." + clientName;
		InitializeCounters();
	}

	public static ClientRequestsMonitor GetOrCreate(ICounterRegistry counterRegistry, string metricsCategoryName, string clientName)
	{
		if (counterRegistry == null)
		{
			throw new ArgumentNullException("counterRegistry");
		}
		if (string.IsNullOrWhiteSpace(metricsCategoryName))
		{
			throw new ArgumentException("Metrics category should be a dot separated namespace", "metricsCategoryName");
		}
		if (string.IsNullOrWhiteSpace(clientName))
		{
			throw new ArgumentException("Client name should be single word without spaces", "clientName");
		}
		return _ClientMonitors.GetOrAdd(clientName, (string counter) => new ClientRequestsMonitor(counterRegistry, metricsCategoryName, clientName));
	}

	public void AddRequestFailure(string actionPath)
	{
		TotalActionMonitor.FailuresPerSecond.Increment();
		GetOrCreateAction(actionPath).FailuresPerSecond.Increment();
		_FailuresPerSecond.Increment();
	}

	public void AddRequestSuccess(string actionPath)
	{
		TotalActionMonitor.SuccessesPerSecond.Increment();
		GetOrCreateAction(actionPath).SuccessesPerSecond.Increment();
		_SuccessesPerSecond.Increment();
	}

	public void AddResponseTime(string actionPath, Stopwatch duration)
	{
		double totalMilliseconds = duration.Elapsed.TotalMilliseconds;
		TotalActionMonitor.AverageResponseTime.Sample(totalMilliseconds);
		GetOrCreateAction(actionPath).AverageResponseTime.Sample(totalMilliseconds);
		_AverageResponseTime.Sample(duration.ElapsedMilliseconds);
		_PercentileResponseTime.Sample(duration.ElapsedMilliseconds);
	}

	public void AddOutstandingRequest(string actionPath)
	{
		TotalActionMonitor.RequestsOutstanding.Increment();
		GetOrCreateAction(actionPath).RequestsOutstanding.Increment();
	}

	public void RemoveOutstandingRequest(string actionPath)
	{
		TotalActionMonitor.RequestsOutstanding.Decrement();
		GetOrCreateAction(actionPath).RequestsOutstanding.Decrement();
	}

	private void InitializeCounters()
	{
		GetOrCreateAction("_Total");
		_FailuresPerSecond = _CounterRegistry.GetRateOfCountsPerSecondCounter(_GlobalCategoryName, "Failures/s", _ClientName);
		_SuccessesPerSecond = _CounterRegistry.GetRateOfCountsPerSecondCounter(_GlobalCategoryName, "Requests/s", _ClientName);
		_AverageResponseTime = _CounterRegistry.GetAverageValueCounter(_GlobalCategoryName, "Average Response Time", _ClientName);
		_PercentileResponseTime = _CounterRegistry.GetPercentileCounter(_GlobalCategoryName, "ResponseTime.Percentile.{0}", _Percentiles, _ClientName);
	}

	private PerInstancePerformanceMonitor GetOrCreateAction(string actionName)
	{
		return _ActionMonitors.GetOrAdd(string.IsNullOrEmpty(actionName) ? "(root)" : actionName, (string result) => new PerInstancePerformanceMonitor(_CounterRegistry, _Category, actionName));
	}
}
