using System.Collections.Generic;
using Roblox.Instrumentation;

namespace Roblox.RestClientBase.Monitoring;

public class ClientMonitor
{
	private readonly Dictionary<string, PerInstancePerformanceMonitor> _ActionMonitors = new Dictionary<string, PerInstancePerformanceMonitor>();

	private readonly string _Category;

	private ICounterRegistry _CounterRegistry;

	private static readonly Dictionary<string, ClientMonitor> _ClientMonitors = new Dictionary<string, ClientMonitor>();

	internal const string AverageResponseTimeCounterName = "Avg Response Time";

	internal const string AverageResponseTimeBaseCounterName = "Avg Response Time Base";

	internal const string FailuresPerSecondCounterName = "Failures/s";

	internal const string RequestsOutstandingCounterName = "Requests Outstanding";

	internal const string RequestsPerSecondCounterName = "Requests/s";

	internal const string TotalInstanceName = "_Total";

	public IAverageValueCounter AverageResponseTime => GetOrCreateAction("_Total").AverageResponseTime;

	public IRateOfCountsPerSecondCounter FailuresPerSecond => GetOrCreateAction("_Total").FailuresPerSecond;

	public IRawValueCounter RequestsOutstanding => GetOrCreateAction("_Total").RequestsOutstanding;

	public IRateOfCountsPerSecondCounter RequestsPerSecond => GetOrCreateAction("_Total").RequestsPerSecond;

	private ClientMonitor(ICounterRegistry counterRegistry, string clientName)
	{
		_Category = "Roblox.ApiClient." + clientName;
		_CounterRegistry = counterRegistry;
	}

	public PerInstancePerformanceMonitor GetOrCreateAction(string actionName)
	{
		if (string.IsNullOrEmpty(actionName))
		{
			actionName = "(root)";
		}
		if (_ActionMonitors.TryGetValue(actionName, out var result))
		{
			return result;
		}
		lock (_ActionMonitors)
		{
			if (_ActionMonitors.TryGetValue(actionName, out result))
			{
				return result;
			}
			IRateOfCountsPerSecondCounter rateOfCountsPerSecondCounter = _CounterRegistry.GetRateOfCountsPerSecondCounter(_Category, "Requests/s", actionName);
			IRateOfCountsPerSecondCounter fps = _CounterRegistry.GetRateOfCountsPerSecondCounter(_Category, "Failures/s", actionName);
			IRawValueCounter ro = _CounterRegistry.GetRawValueCounter(_Category, "Requests Outstanding", actionName);
			IAverageValueCounter art = _CounterRegistry.GetAverageValueCounter(_Category, "Avg Response Time", actionName);
			PerInstancePerformanceMonitor monitor = new PerInstancePerformanceMonitor(rateOfCountsPerSecondCounter, fps, ro, art);
			_ActionMonitors.Add(actionName, monitor);
			return monitor;
		}
	}

	public static ClientMonitor GetOrCreate(ICounterRegistry counterRegistry, string clientName)
	{
		if (_ClientMonitors.TryGetValue(clientName, out var counter))
		{
			return counter;
		}
		lock (_ClientMonitors)
		{
			if (_ClientMonitors.TryGetValue(clientName, out counter))
			{
				return counter;
			}
			counter = new ClientMonitor(counterRegistry, clientName);
			_ClientMonitors.Add(clientName, counter);
			return counter;
		}
	}
}
