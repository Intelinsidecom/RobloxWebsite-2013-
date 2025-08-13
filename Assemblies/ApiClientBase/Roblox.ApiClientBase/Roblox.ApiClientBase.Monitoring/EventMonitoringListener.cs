using System.Collections.Concurrent;
using System.Diagnostics;
using System.Net;
using Roblox.Instrumentation;

namespace Roblox.ApiClientBase.Monitoring;

internal class EventMonitoringListener
{
	private readonly ICounterRegistry _CounterRegistry;

	private readonly ApiClientBase _Client;

	private ClientMonitor _ClientMonitor;

	private bool _IsRegistered;

	private readonly ConcurrentDictionary<long, Stopwatch> _RequestTracker = new ConcurrentDictionary<long, Stopwatch>();

	private readonly object _Sync = new object();

	public EventMonitoringListener(ICounterRegistry counterRegistry, ApiClientBase client)
	{
		_CounterRegistry = counterRegistry;
		_Client = client;
	}

	private void RequestFailed(long requestId, string actionPath, HttpStatusCode? statusCode, string statusDescription)
	{
		_ClientMonitor.AddRequestFailure(actionPath);
	}

	private void RequestFinished(long requestId, string actionPath)
	{
		if (_RequestTracker.TryRemove(requestId, out var value))
		{
			value.Stop();
			_ClientMonitor.AddResponseTime(actionPath, value);
		}
		_ClientMonitor.RemoveOutstandingRequest(actionPath);
	}

	private void RequestStarted(long requestId, string actionPath)
	{
		Stopwatch value = Stopwatch.StartNew();
		_RequestTracker.GetOrAdd(requestId, value);
		_ClientMonitor.AddOutstandingRequest(actionPath);
	}

	private void RequestSucceeded(long requestId, string actionPath)
	{
		_ClientMonitor.AddRequestSuccess(actionPath);
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
