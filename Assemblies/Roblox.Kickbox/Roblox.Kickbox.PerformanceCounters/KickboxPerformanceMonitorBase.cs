using System;
using System.Net;
using Newtonsoft.Json;
using Roblox.Instrumentation;
using Roblox.Kickbox.Properties;
using Roblox.RestClientBase;
using Roblox.Sentinels;

namespace Roblox.Kickbox.PerformanceCounters;

internal abstract class KickboxPerformanceMonitorBase
{
	internal readonly string _ApiName;

	internal readonly IKickboxSettings _Settings;

	internal IRateOfCountsPerSecondCounter RequestsPerSecond { get; set; }

	internal IAverageValueCounter SendAverageDuration { get; set; }

	internal IRateOfCountsPerSecondCounter ErrorsPerSecond { get; set; }

	internal IRateOfCountsPerSecondCounter BadRequestsPerSecond { get; set; }

	internal IRateOfCountsPerSecondCounter InternalServerErrorsPerSecond { get; set; }

	internal IRateOfCountsPerSecondCounter TimeoutErrorsPerSecond { get; set; }

	internal IRateOfCountsPerSecondCounter NameResolutionFailureErrorsPerSecond { get; set; }

	internal IRateOfCountsPerSecondCounter ConnectionClosedErrorsPerSecond { get; set; }

	internal IRateOfCountsPerSecondCounter OtherWebExceptionStatusErrorsPerSecond { get; set; }

	internal IRateOfCountsPerSecondCounter UnknownErrorsPerSecond { get; set; }

	internal IRateOfCountsPerSecondCounter CircuitBreakerErrorsPerSecond { get; set; }

	internal IRateOfCountsPerSecondCounter ThrottledErrorsPerSecond { get; set; }

	internal IRateOfCountsPerSecondCounter DeserializationErrorsPerSecond { get; set; }

	internal virtual Action<string> LogException => ExceptionHandler.LogException;

	public KickboxPerformanceMonitorBase(string apiName, IKickboxSettings settings)
	{
		if (string.IsNullOrWhiteSpace(apiName))
		{
			throw new ArgumentException("apiName is required");
		}
		_ApiName = apiName;
		_Settings = settings ?? throw new ArgumentException("settings");
	}

	public virtual void Increment(TimeSpan requestTime)
	{
		RequestsPerSecond.Increment();
		SendAverageDuration.Sample(requestTime.Ticks);
	}

	public virtual void IncrementException(object request, TimeSpan requestTime, Exception ex)
	{
		Increment(requestTime);
		ErrorsPerSecond.Increment();
		if (ex is CircuitBreakerException)
		{
			CircuitBreakerErrorsPerSecond.Increment();
		}
		else if (ex is RequestThrottledException)
		{
			ThrottledErrorsPerSecond.Increment();
		}
		else if (ex is JsonSerializationException)
		{
			DeserializationErrorsPerSecond.Increment();
		}
		else if (ex is ApiClientException)
		{
			IncrementSpecificErrorCounters((ApiClientException)ex);
		}
		else
		{
			UnknownErrorsPerSecond.Increment();
		}
		if (_Settings.IsDetailedKickboxErrorLoggingEnabled)
		{
			string requestBody = JsonConvert.SerializeObject(request);
			LogException($"Kickbox. ApiName: {_ApiName}, Request Length: {requestTime:c}, Request Body: {requestBody}, Status Code: {(ex as ApiClientException)?.StatusCode} Exception {ex.Message}");
		}
	}

	private void IncrementSpecificErrorCounters(ApiClientException ex)
	{
		if (ex != null && ex.StatusCode == HttpStatusCode.BadRequest)
		{
			BadRequestsPerSecond.Increment();
		}
		else if (ex != null && ex.StatusCode == HttpStatusCode.InternalServerError)
		{
			InternalServerErrorsPerSecond.Increment();
		}
		else if (ex?.InnerException is WebException)
		{
			switch (((WebException)ex.InnerException).Status)
			{
			case WebExceptionStatus.Timeout:
				TimeoutErrorsPerSecond.Increment();
				break;
			case WebExceptionStatus.NameResolutionFailure:
				NameResolutionFailureErrorsPerSecond.Increment();
				break;
			case WebExceptionStatus.ConnectionClosed:
				ConnectionClosedErrorsPerSecond.Increment();
				break;
			default:
				OtherWebExceptionStatusErrorsPerSecond.Increment();
				break;
			}
		}
		else
		{
			UnknownErrorsPerSecond.Increment();
		}
	}
}
