using System.Collections.Concurrent;
using System.Diagnostics;
using System.Net;
using Roblox.Instrumentation;

namespace Roblox.RestClientBase.Monitoring;

internal class EventMonitoringListener
{
	private readonly ICounterRegistry _CounterRegistry;

	private readonly RestClientBase _Client;

	private ClientMonitor _ClientMonitor;

	private bool _IsRegistered;

	private readonly ConcurrentDictionary<long, Stopwatch> _RequestTracker = new ConcurrentDictionary<long, Stopwatch>();

	private readonly object _Sync = new object();

	public EventMonitoringListener(ICounterRegistry counterRegistry, RestClientBase client)
	{
		_CounterRegistry = counterRegistry;
		_Client = client;
	}

	private void RequestFailed(long requestId, string actionPath, HttpStatusCode? statusCode, string statusDescription)
	{
		_ClientMonitor.FailuresPerSecond.Increment();
		_ClientMonitor.GetOrCreateAction(actionPath).FailuresPerSecond.Increment();
	}

	private void RequestFinished(long requestId, string actionPath)
	{
		PerInstancePerformanceMonitor actionPerformanceMonitor = _ClientMonitor.GetOrCreateAction(actionPath);
		if (_RequestTracker.TryRemove(requestId, out var stopwatch))
		{
			stopwatch.Stop();
			_ClientMonitor.AverageResponseTime.Sample(stopwatch.Elapsed.TotalMilliseconds);
			actionPerformanceMonitor.AverageResponseTime.Sample(stopwatch.Elapsed.TotalMilliseconds);
		}
		_ClientMonitor.RequestsOutstanding.Decrement();
		actionPerformanceMonitor.RequestsOutstanding.Decrement();
	}

	private void RequestStarted(long requestId, string actionPath)
	{
		Stopwatch stopwatch = Stopwatch.StartNew();
		_RequestTracker.GetOrAdd(requestId, stopwatch);
		_ClientMonitor.RequestsOutstanding.Increment();
		_ClientMonitor.GetOrCreateAction(actionPath).RequestsOutstanding.Increment();
	}

	private void RequestSucceeded(long requestId, string actionPath)
	{
		_ClientMonitor.RequestsPerSecond.Increment();
		_ClientMonitor.GetOrCreateAction(actionPath).RequestsPerSecond.Increment();
	}

	public void Register()
	{
		if (_IsRegistered)
		{
			return;
		}
		lock (_Sync)
		{
			if (_IsRegistered)
			{
				return;
			}
			_IsRegistered = true;
		}
		_ClientMonitor = ClientMonitor.GetOrCreate(_CounterRegistry, _Client.Name);
		_Client.RequestStarted += RequestStarted;
		_Client.RequestSucceeded += RequestSucceeded;
		_Client.RequestFailed += RequestFailed;
		_Client.RequestFinished += RequestFinished;
	}

	public void Unregister()
	{
		if (!_IsRegistered)
		{
			return;
		}
		lock (_Sync)
		{
			if (!_IsRegistered)
			{
				return;
			}
			_IsRegistered = false;
		}
		_Client.RequestStarted -= RequestStarted;
		_Client.RequestSucceeded -= RequestSucceeded;
		_Client.RequestFailed -= RequestFailed;
		_Client.RequestFinished -= RequestFinished;
		_ClientMonitor = null;
	}
}
