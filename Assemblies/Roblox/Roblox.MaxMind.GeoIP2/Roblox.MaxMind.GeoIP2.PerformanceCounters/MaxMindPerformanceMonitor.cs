using System;
using System.Diagnostics;
using System.Net;
using Newtonsoft.Json;
using Roblox.Diagnostics;

namespace Roblox.MaxMind.GeoIP2.PerformanceCounters;

internal class MaxMindPerformanceMonitor : IMaxMindPerformanceMonitor
{
	private readonly string _ApiName;

	private readonly Func<bool> _EnableDetailedErrorLogging;

	internal PerformanceCounter ResponseHasRegisteredCountry { get; set; }

	internal PerformanceCounter ResponseHasRepresentedCountry { get; set; }

	internal PerformanceCounter RequestsPerSecond { get; set; }

	internal PerformanceCounter SendAverageDuration { get; set; }

	internal PerformanceCounter SendAverageDurationBase { get; set; }

	internal PerformanceCounter ErrorsPerSecond { get; set; }

	internal PerformanceCounter BadRequestsPerSecond { get; set; }

	internal PerformanceCounter NotFoundRequestsPerSecond { get; set; }

	internal PerformanceCounter UnauthorizedRequestsPerSecond { get; set; }

	internal PerformanceCounter PaymentRequiredRequestsPerSecond { get; set; }

	internal PerformanceCounter ForbiddenRequestsPerSecond { get; set; }

	internal PerformanceCounter ServiceNotAvailableErrorsPerSecond { get; set; }

	internal PerformanceCounter UnknownErrorsPerSecond { get; set; }

	internal PerformanceCounter TimeoutErrorsPerSecond { get; set; }

	internal PerformanceCounter NameResolutionFailureErrorsPerSecond { get; set; }

	internal PerformanceCounter ConnectionClosedErrorsPerSecond { get; set; }

	internal PerformanceCounter OtherWebExceptionStatusErrorsPerSecond { get; set; }

	internal virtual Action<string> LogException => ExceptionHandler.LogException;

	public MaxMindPerformanceMonitor(string apiName, Func<bool> enableDetailedErrorLogging)
	{
		if (string.IsNullOrWhiteSpace(apiName))
		{
			throw new ArgumentException("apiName is required");
		}
		_ApiName = apiName;
		_EnableDetailedErrorLogging = enableDetailedErrorLogging;
		CounterDescriptor[] httpCounters = new CounterDescriptor[17]
		{
			new CounterDescriptor(() => ResponseHasRegisteredCountry, delegate(PerformanceCounter v)
			{
				ResponseHasRegisteredCountry = v;
			}, PerformanceCounterType.RateOfCountsPerSecond32),
			new CounterDescriptor(() => ResponseHasRepresentedCountry, delegate(PerformanceCounter v)
			{
				ResponseHasRepresentedCountry = v;
			}, PerformanceCounterType.RateOfCountsPerSecond32),
			new CounterDescriptor(() => RequestsPerSecond, delegate(PerformanceCounter v)
			{
				RequestsPerSecond = v;
			}, PerformanceCounterType.RateOfCountsPerSecond32),
			new CounterDescriptor(() => SendAverageDuration, delegate(PerformanceCounter v)
			{
				SendAverageDuration = v;
			}, PerformanceCounterType.AverageTimer32),
			new CounterDescriptor(() => SendAverageDurationBase, delegate(PerformanceCounter v)
			{
				SendAverageDurationBase = v;
			}, PerformanceCounterType.AverageBase),
			new CounterDescriptor(() => ErrorsPerSecond, delegate(PerformanceCounter v)
			{
				ErrorsPerSecond = v;
			}, PerformanceCounterType.RateOfCountsPerSecond32),
			new CounterDescriptor(() => BadRequestsPerSecond, delegate(PerformanceCounter v)
			{
				BadRequestsPerSecond = v;
			}, PerformanceCounterType.RateOfCountsPerSecond32),
			new CounterDescriptor(() => NotFoundRequestsPerSecond, delegate(PerformanceCounter v)
			{
				NotFoundRequestsPerSecond = v;
			}, PerformanceCounterType.RateOfCountsPerSecond32),
			new CounterDescriptor(() => UnauthorizedRequestsPerSecond, delegate(PerformanceCounter v)
			{
				UnauthorizedRequestsPerSecond = v;
			}, PerformanceCounterType.RateOfCountsPerSecond32),
			new CounterDescriptor(() => PaymentRequiredRequestsPerSecond, delegate(PerformanceCounter v)
			{
				PaymentRequiredRequestsPerSecond = v;
			}, PerformanceCounterType.RateOfCountsPerSecond32),
			new CounterDescriptor(() => ForbiddenRequestsPerSecond, delegate(PerformanceCounter v)
			{
				ForbiddenRequestsPerSecond = v;
			}, PerformanceCounterType.RateOfCountsPerSecond32),
			new CounterDescriptor(() => ServiceNotAvailableErrorsPerSecond, delegate(PerformanceCounter v)
			{
				ServiceNotAvailableErrorsPerSecond = v;
			}, PerformanceCounterType.RateOfCountsPerSecond32),
			new CounterDescriptor(() => UnknownErrorsPerSecond, delegate(PerformanceCounter v)
			{
				UnknownErrorsPerSecond = v;
			}, PerformanceCounterType.RateOfCountsPerSecond32),
			new CounterDescriptor(() => TimeoutErrorsPerSecond, delegate(PerformanceCounter v)
			{
				TimeoutErrorsPerSecond = v;
			}, PerformanceCounterType.RateOfCountsPerSecond32),
			new CounterDescriptor(() => NameResolutionFailureErrorsPerSecond, delegate(PerformanceCounter v)
			{
				NameResolutionFailureErrorsPerSecond = v;
			}, PerformanceCounterType.RateOfCountsPerSecond32),
			new CounterDescriptor(() => ConnectionClosedErrorsPerSecond, delegate(PerformanceCounter v)
			{
				ConnectionClosedErrorsPerSecond = v;
			}, PerformanceCounterType.RateOfCountsPerSecond32),
			new CounterDescriptor(() => OtherWebExceptionStatusErrorsPerSecond, delegate(PerformanceCounter v)
			{
				OtherWebExceptionStatusErrorsPerSecond = v;
			}, PerformanceCounterType.RateOfCountsPerSecond32)
		};
		CounterCreator.InitializeMultiInstance("Roblox.MaxMindV1", _ApiName, httpCounters);
	}

	public virtual void IncrementResponse(TimeSpan requestTime)
	{
		RequestsPerSecond.Increment();
		SendAverageDuration.IncrementBy(requestTime.Ticks);
		SendAverageDurationBase.Increment();
	}

	public virtual void IncrementResponseHasRegisteredCountry()
	{
		ResponseHasRegisteredCountry.Increment();
	}

	public virtual void IncrementResponseHasRepresentedCountry()
	{
		ResponseHasRepresentedCountry.Increment();
	}

	public virtual void IncrementException(object request, TimeSpan requestTime, WebException ex)
	{
		IncrementResponse(requestTime);
		ErrorsPerSecond.Increment();
		HttpWebResponse httpResponse = (HttpWebResponse)ex.Response;
		WebException webEx = (WebException)ex.InnerException;
		IncrementSpecificErrorCounters(httpResponse?.StatusCode, webEx?.Status);
		if (_EnableDetailedErrorLogging())
		{
			string requestBody = JsonConvert.SerializeObject(request);
			LogException($"MaxMind. ApiName: {_ApiName}, Request Length: {requestTime:c}, Request Body: {requestBody}, Status Code: {httpResponse?.StatusCode} Exception {ex.Message}");
		}
	}

	private void IncrementSpecificErrorCounters(HttpStatusCode? statusCode, WebExceptionStatus? webStatus)
	{
		if (statusCode.HasValue)
		{
			if (statusCode == HttpStatusCode.BadRequest)
			{
				BadRequestsPerSecond.Increment();
			}
			else if (statusCode == HttpStatusCode.NotFound)
			{
				NotFoundRequestsPerSecond.Increment();
			}
			else if (statusCode == HttpStatusCode.Unauthorized)
			{
				UnauthorizedRequestsPerSecond.Increment();
			}
			else if (statusCode == HttpStatusCode.PaymentRequired)
			{
				PaymentRequiredRequestsPerSecond.Increment();
			}
			else if (statusCode == HttpStatusCode.Forbidden)
			{
				ForbiddenRequestsPerSecond.Increment();
			}
			else if (statusCode == HttpStatusCode.ServiceUnavailable)
			{
				ServiceNotAvailableErrorsPerSecond.Increment();
			}
			else
			{
				UnknownErrorsPerSecond.Increment();
			}
		}
		else if (webStatus.HasValue)
		{
			switch (webStatus)
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
