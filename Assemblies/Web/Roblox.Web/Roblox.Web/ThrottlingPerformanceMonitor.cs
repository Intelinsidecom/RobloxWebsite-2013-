using System;
using System.Collections.Concurrent;
using Roblox.Instrumentation;

namespace Roblox.Web;

/// <summary>
/// Class to create <see cref="T:Roblox.Web.ThrottlingPerformanceMonitor" /> to account for throttling. 
/// </summary>
public class ThrottlingPerformanceMonitor : IThrottlingPerformanceMonitor
{
	private const string _TotalInstance = "_Total";

	private ICounterRegistry _CounterRegistry;

	private readonly string _PerformanceCategory;

	private readonly ConcurrentDictionary<string, InstancedPerformanceMonitor> _PerformanceCountersByActionName;

	private static readonly object _Sync = new object();

	/// <summary>
	/// Initializes a new instance of the <see cref="T:Roblox.Web.ThrottlingPerformanceMonitor" /> class.
	/// </summary>
	/// <param name="counterRegistry">The counter registry injected.</param>
	/// <param name="performanceCategory">The performance category.</param>
	public ThrottlingPerformanceMonitor(ICounterRegistry counterRegistry, string performanceCategory)
	{
		_CounterRegistry = counterRegistry ?? throw new ArgumentNullException("counterRegistry");
		_PerformanceCategory = performanceCategory;
		_PerformanceCountersByActionName = new ConcurrentDictionary<string, InstancedPerformanceMonitor>();
	}

	public void IncrementThrottledRequests(RequesterType requester, string actionName)
	{
		InstancedPerformanceMonitor actionCounter = GetInstancedPerformanceMonitorByActionName(actionName);
		InstancedPerformanceMonitor totalCounter = GetInstancedPerformanceMonitorByActionName("_Total");
		totalCounter.TotalRequestsPerSecond.Increment();
		actionCounter.TotalRequestsPerSecond.Increment();
		switch (requester)
		{
		case RequesterType.GameServer:
			actionCounter.ThrottledGameServerRequestsPerSecond.Increment();
			totalCounter.ThrottledGameServerRequestsPerSecond.Increment();
			break;
		case RequesterType.AuthenticatedUser:
			actionCounter.ThrottledRequestsByUserIdPerSecond.Increment();
			totalCounter.ThrottledRequestsByUserIdPerSecond.Increment();
			break;
		case RequesterType.UnauthenticatedUser:
			actionCounter.ThrottledRequestsByIpPerSecond.Increment();
			totalCounter.ThrottledRequestsByIpPerSecond.Increment();
			break;
		}
	}

	public void IncrementTotalRequests(RequesterType requester, string actionName)
	{
		InstancedPerformanceMonitor counter = GetInstancedPerformanceMonitorByActionName(actionName);
		InstancedPerformanceMonitor totalCounter = GetInstancedPerformanceMonitorByActionName("_Total");
		switch (requester)
		{
		case RequesterType.GameServer:
			counter.TotalGameServerRequestsPerSecond.Increment();
			totalCounter.TotalGameServerRequestsPerSecond.Increment();
			break;
		case RequesterType.AuthenticatedUser:
			counter.TotalRequestsByUserIdPerSecond.Increment();
			totalCounter.TotalRequestsByUserIdPerSecond.Increment();
			break;
		case RequesterType.UnauthenticatedUser:
			counter.TotalRequestsByIpPerSecond.Increment();
			totalCounter.TotalRequestsByIpPerSecond.Increment();
			break;
		}
	}

	private InstancedPerformanceMonitor GetInstancedPerformanceMonitorByActionName(string actionName)
	{
		if (_PerformanceCountersByActionName.TryGetValue(actionName, out var counter))
		{
			return counter;
		}
		lock (_Sync)
		{
			if (_PerformanceCountersByActionName.TryGetValue(actionName, out counter))
			{
				return counter;
			}
			return _PerformanceCountersByActionName.GetOrAdd(actionName, (string instanceName) => new InstancedPerformanceMonitor(_CounterRegistry, _PerformanceCategory, actionName));
		}
	}
}
