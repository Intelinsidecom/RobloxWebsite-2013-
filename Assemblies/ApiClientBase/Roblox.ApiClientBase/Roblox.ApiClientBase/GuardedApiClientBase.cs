using System;
using System.Collections.Generic;
using System.Net;
using System.Threading;
using System.Threading.Tasks;
using Roblox.ApiClientBase.Properties;
using Roblox.Instrumentation;
using Roblox.Sentinels;

namespace Roblox.ApiClientBase;

public abstract class GuardedApiClientBase : MonitoringApiClientBase
{
	private readonly ICounterRegistry _CounterRegistry;

	private readonly HashSet<WebExceptionStatus> _StatusesThatTripCircuitBreaker = new HashSet<WebExceptionStatus>
	{
		WebExceptionStatus.Timeout,
		WebExceptionStatus.NameResolutionFailure,
		WebExceptionStatus.ProxyNameResolutionFailure,
		WebExceptionStatus.RequestCanceled,
		WebExceptionStatus.ConnectionClosed,
		WebExceptionStatus.ConnectFailure
	};

	private readonly CircuitBreaker _CircuitBreaker;

	private DateTime _NextRetry = DateTime.MinValue;

	private int _ShouldRetrySignal;

	private int _TimeoutCount;

	private DateTime _TimeoutIntervalEnd = DateTime.MinValue;

	private GuardedApiClientPerformanceMonitor _GlobalMonitor;

	private GuardedApiClientPerformanceMonitor _ClientMonitor;

	protected virtual TimeSpan RetryInterval => Settings.Default.DefaultCircuitBreakerRetryInterval;

	protected virtual int TimeoutCountBeforeTripping => Settings.Default.DefaultCircuitBreakerTimeoutsBeforeTrip;

	protected virtual TimeSpan TimeoutIntervalForTripping => Settings.Default.DefaultCircuitBreakerTimeoutInterval;

	protected GuardedApiClientBase()
		: this(StaticCounterRegistry.Instance)
	{
	}

	protected GuardedApiClientBase(ICounterRegistry counterRegistry)
		: base(counterRegistry)
	{
		_CounterRegistry = counterRegistry ?? throw new ArgumentNullException("counterRegistry");
		_CircuitBreaker = new CircuitBreaker(GetType().Name);
		InitializePerformanceMonitors();
	}

	private void InitializePerformanceMonitors()
	{
		_GlobalMonitor = TryCreateGuardedApiClientPerformanceMonitor("_global_");
		_ClientMonitor = TryCreateGuardedApiClientPerformanceMonitor(Name);
	}

	private GuardedApiClientPerformanceMonitor TryCreateGuardedApiClientPerformanceMonitor(string instanceName)
	{
		return new GuardedApiClientPerformanceMonitor(_CounterRegistry, instanceName);
	}

	private void ResetCircuitBreaker()
	{
		_CircuitBreaker.Reset();
		_NextRetry = DateTime.MinValue;
	}

	private void ResetSignal()
	{
		Interlocked.Exchange(ref _ShouldRetrySignal, 0);
	}

	private void ResetTimeoutCount()
	{
		Interlocked.Exchange(ref _TimeoutCount, 0);
		_TimeoutIntervalEnd = DateTime.UtcNow.Add(TimeoutIntervalForTripping);
	}

	private void TripAndRethrow(WebException ex, string actionPath)
	{
		DateTime utcNow = DateTime.UtcNow;
		_NextRetry = utcNow.Add(RetryInterval);
		_CircuitBreaker.Trip();
		ApiClientBase.GetHttpStatusCodeAndStatusDescription(ex, out var httpStatusCode, out var statusDescription);
		if (ex.Status == WebExceptionStatus.Timeout)
		{
			TimeSpan timeSpan = utcNow - _TimeoutIntervalEnd.Subtract(TimeoutIntervalForTripping);
			statusDescription = statusDescription + "\r\nThere have been " + _TimeoutCount + " timeouts in the last " + timeSpan.TotalSeconds + " seconds.";
		}
		ThrowConvertedException(ex, actionPath, httpStatusCode, statusDescription);
	}

	private void Test()
	{
		try
		{
			_CircuitBreaker.Test();
		}
		catch (CircuitBreakerException)
		{
			if (!(DateTime.UtcNow >= _NextRetry))
			{
				IncrementRequestsTrippedByCircuitBreaker();
				throw;
			}
			if (Interlocked.CompareExchange(ref _ShouldRetrySignal, 1, 0) != 0)
			{
				IncrementRequestsTrippedByCircuitBreaker();
				throw;
			}
		}
	}

	private void IncrementRequestsTrippedByCircuitBreaker()
	{
		_GlobalMonitor?.RequestsTrippedByCircuitBreakerPerSecond.Increment();
		_ClientMonitor?.RequestsTrippedByCircuitBreakerPerSecond.Increment();
	}

	protected override string ExecuteHttpRequest(string actionPath, HttpMethod method, IEnumerable<KeyValuePair<string, object>> queryStringParameters = null, IEnumerable<KeyValuePair<string, object>> formParameters = null, IEnumerable<KeyValuePair<string, string>> headers = null, string rawPostData = null, IEnumerable<KeyValuePair<string, byte[]>> multipartFormData = null, string actionName = null)
	{
		Test();
		string result = null;
		try
		{
			result = base.ExecuteHttpRequest(actionPath, method, queryStringParameters, formParameters, headers, rawPostData, multipartFormData, actionName);
		}
		catch (WebException ex)
		{
			TripAndRethrow(ex, actionPath);
		}
		finally
		{
			ResetSignal();
		}
		ResetCircuitBreaker();
		return result;
	}

	protected override async Task<string> ExecuteHttpRequestAsync(string actionPath, HttpMethod method, CancellationToken cancellationToken, IEnumerable<KeyValuePair<string, object>> queryStringParameters = null, IEnumerable<KeyValuePair<string, object>> formParameters = null, IEnumerable<KeyValuePair<string, string>> headers = null, string rawPostData = null, IEnumerable<KeyValuePair<string, byte[]>> multipartFormData = null, string actionName = null)
	{
		Test();
		string response = null;
		try
		{
			response = await base.ExecuteHttpRequestAsync(actionPath, method, cancellationToken, queryStringParameters, formParameters, headers, rawPostData, multipartFormData, actionName);
		}
		catch (WebException ex)
		{
			TripAndRethrow(ex, actionPath);
		}
		finally
		{
			ResetSignal();
		}
		ResetCircuitBreaker();
		return response;
	}

	protected override void OnRequestFailed(WebException ex, long requestId, string actionName, HttpStatusCode? statusCode, string statusDescription)
	{
		HandleRequestFailedEvent(requestId, actionName, statusCode, statusDescription);
		if (_StatusesThatTripCircuitBreaker.Contains(ex.Status))
		{
			HandleFailuresThatTripCircuitBreaker(ex);
		}
		base.OnRequestFailed(ex, requestId, actionName, statusCode, statusDescription);
	}

	private void HandleFailuresThatTripCircuitBreaker(WebException ex)
	{
		if (ex.Status == WebExceptionStatus.Timeout)
		{
			_GlobalMonitor?.RequestsExceedingTimeoutPerSecond.Increment();
			_ClientMonitor?.RequestsExceedingTimeoutPerSecond.Increment();
			if (_TimeoutIntervalEnd < DateTime.UtcNow)
			{
				ResetTimeoutCount();
			}
			Interlocked.Increment(ref _TimeoutCount);
			if (_TimeoutCount > TimeoutCountBeforeTripping)
			{
				UpdateFailedRequestCountersAndThrow(ex);
			}
		}
		else
		{
			UpdateFailedRequestCountersAndThrow(ex);
		}
	}

	private void UpdateFailedRequestCountersAndThrow(WebException ex)
	{
		_GlobalMonitor?.FailedRequestsThatTripCircuitBreakerPerSecond.Increment();
		_ClientMonitor?.FailedRequestsThatTripCircuitBreakerPerSecond.Increment();
		throw ex;
	}
}
