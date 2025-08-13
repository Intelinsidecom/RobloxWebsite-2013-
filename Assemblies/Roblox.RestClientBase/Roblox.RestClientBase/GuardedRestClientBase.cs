using System;
using System.Collections.Generic;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Roblox.Instrumentation;
using Roblox.RestClientBase.Properties;
using Roblox.Sentinels;

namespace Roblox.RestClientBase;

/// <summary>
/// Provides a base REST client that implements a step down failover retry circuit breaker and monitoring.
/// </summary>
/// <seealso cref="T:Roblox.RestClientBase.MonitoringRestClientBase" />
public abstract class GuardedRestClientBase : MonitoringRestClientBase
{
	private readonly ICounterRegistry _CounterRegistry;

	private readonly HashSet<WebExceptionStatus> _StatusesThatTripCurcuitBreaker = new HashSet<WebExceptionStatus>
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

	private GuardedRestClientPerformanceMonitor _GlobalMonitor;

	private GuardedRestClientPerformanceMonitor _ClientMonitor;

	protected override TimeSpan Timeout => TimeSpan.FromMilliseconds(1000.0);

	protected virtual TimeSpan RetryInterval => Settings.Default.DefaultCircuitBreakerRetryInterval;

	protected virtual int TimeoutCountBeforeTripping => Settings.Default.DefaultCircuitBreakerTimeoutsBeforeTrip;

	protected virtual TimeSpan TimeoutIntervalForTripping => Settings.Default.DefaultCircuitBreakerTimeoutInterval;

	protected GuardedRestClientBase()
		: this(StaticCounterRegistry.Instance)
	{
	}

	protected GuardedRestClientBase(ICounterRegistry counterRegistry)
		: base(counterRegistry)
	{
		_CounterRegistry = counterRegistry ?? throw new ArgumentNullException("counterRegistry");
		_CircuitBreaker = new CircuitBreaker(GetType().Name);
		InitializePerformanceMonitors();
	}

	private void InitializePerformanceMonitors()
	{
		_GlobalMonitor = new GuardedRestClientPerformanceMonitor(_CounterRegistry, "_global_");
		_ClientMonitor = new GuardedRestClientPerformanceMonitor(_CounterRegistry, Name);
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
		RestClientBase.GetHttpStatusCodeAndStatusDescription(ex, out var httpStatusCode, out var statusDescription);
		if (ex.Status == WebExceptionStatus.Timeout)
		{
			TimeSpan elapsedTime = utcNow - _TimeoutIntervalEnd.Subtract(TimeoutIntervalForTripping);
			statusDescription = statusDescription + "\r\nThere have been " + _TimeoutCount + " timeouts in the last " + elapsedTime.TotalSeconds + " seconds.";
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
		_GlobalMonitor.RequestsTrippedByCircuitBreakerPerSecond.Increment();
		_ClientMonitor.RequestsTrippedByCircuitBreakerPerSecond.Increment();
	}

	protected override string ExecuteHttpRequest(string actionPath, HttpMethod method, IEnumerable<KeyValuePair<string, object>> queryStringParameters = null, string bodyString = null, IEnumerable<KeyValuePair<string, string>> headers = null, Encoding specificEncoding = null, string recordActionPathAs = null)
	{
		Test();
		string response = null;
		try
		{
			response = base.ExecuteHttpRequest(actionPath, method, queryStringParameters, bodyString, headers, specificEncoding, recordActionPathAs);
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

	protected override async Task<string> ExecuteHttpRequestAsync(string actionPath, HttpMethod method, CancellationToken cancellationToken, IEnumerable<KeyValuePair<string, object>> queryStringParameters = null, string bodyString = null, IEnumerable<KeyValuePair<string, string>> headers = null, Encoding specificEncoding = null, string recordActionPathAs = null)
	{
		Test();
		string response = null;
		try
		{
			response = await base.ExecuteHttpRequestAsync(actionPath, method, cancellationToken, queryStringParameters, bodyString, headers, specificEncoding, recordActionPathAs);
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

	protected override void OnRequestFailed(WebException ex, long requestId, string actionPath, HttpStatusCode? statusCode, string statusDescription)
	{
		HandleRequestFailedEvent(requestId, actionPath, statusCode, statusDescription);
		if (_StatusesThatTripCurcuitBreaker.Contains(ex.Status))
		{
			HandleFailuresThatTripCircuitBreaker(ex);
		}
		base.OnRequestFailed(ex, requestId, actionPath, statusCode, statusDescription);
	}

	private void HandleFailuresThatTripCircuitBreaker(WebException ex)
	{
		if (ex.Status == WebExceptionStatus.Timeout)
		{
			_GlobalMonitor.RequestsExceedingTimeoutPerSecond.Increment();
			_ClientMonitor.RequestsExceedingTimeoutPerSecond.Increment();
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
		_GlobalMonitor.FailedRequestsThatTripCircuitBreakerPerSecond.Increment();
		_ClientMonitor.FailedRequestsThatTripCircuitBreakerPerSecond.Increment();
		throw ex;
	}
}
