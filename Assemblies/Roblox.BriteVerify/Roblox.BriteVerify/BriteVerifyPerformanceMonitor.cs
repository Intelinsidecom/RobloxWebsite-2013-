using System;
using System.Diagnostics;
using System.Net;
using Newtonsoft.Json;
using Roblox.BriteVerify.Properties;
using Roblox.Diagnostics;
using Roblox.RestClientBase;
using Roblox.Sentinels;

namespace Roblox.BriteVerify;

internal class BriteVerifyPerformanceMonitor : IBriteVerifyPerformanceMonitor
{
	private readonly string _ApiName;

	private readonly IBriteVerifySettings _Settings;

	internal PerformanceCounter RequestsPerSecond { get; set; }

	internal PerformanceCounter SendAverageDuration { get; set; }

	internal PerformanceCounter SendAverageDurationBase { get; set; }

	internal PerformanceCounter ErrorsPerSecond { get; set; }

	internal PerformanceCounter BadRequestsPerSecond { get; set; }

	internal PerformanceCounter InternalServerErrorsPerSecond { get; set; }

	internal PerformanceCounter TimeoutErrorsPerSecond { get; set; }

	internal PerformanceCounter NameResolutionFailureErrorsPerSecond { get; set; }

	internal PerformanceCounter ConnectionClosedErrorsPerSecond { get; set; }

	internal PerformanceCounter OtherWebExceptionStatusErrorsPerSecond { get; set; }

	internal PerformanceCounter UnknownErrorsPerSecond { get; set; }

	internal PerformanceCounter CircuitBreakerErrorsPerSecond { get; set; }

	internal PerformanceCounter ThrottledErrorsPerSecond { get; set; }

	internal PerformanceCounter DeserializationErrorsPerSecond { get; set; }

	internal PerformanceCounter ResponseIsValidEmail { get; set; }

	internal PerformanceCounter ResponseIsUnknownEmail { get; set; }

	internal PerformanceCounter ResponseIsInvalidEmail { get; set; }

	internal PerformanceCounter ResponseIsAcceptAllEmail { get; set; }

	internal PerformanceCounter ResponseCannotValidate { get; set; }

	internal PerformanceCounter ResponseIsDisposableEmail { get; set; }

	internal PerformanceCounter ResponseIsRoleAddressEmail { get; set; }

	internal PerformanceCounter ResponseIsInvalidEmailFormat { get; set; }

	internal PerformanceCounter ResponseIsInvalidEmailDomain { get; set; }

	internal PerformanceCounter ResponseIsInvalidEmailAccount { get; set; }

	internal virtual Action<string> LogException => ExceptionHandler.LogException;

	public BriteVerifyPerformanceMonitor(string apiName, IBriteVerifySettings settings)
	{
		if (string.IsNullOrWhiteSpace(apiName))
		{
			throw new ArgumentException("apiName is required");
		}
		_ApiName = apiName;
		_Settings = settings ?? throw new ArgumentException("settings");
		CounterDescriptor[] httpCounters = new CounterDescriptor[23]
		{
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
			new CounterDescriptor(() => InternalServerErrorsPerSecond, delegate(PerformanceCounter v)
			{
				InternalServerErrorsPerSecond = v;
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
			}, PerformanceCounterType.RateOfCountsPerSecond32),
			new CounterDescriptor(() => UnknownErrorsPerSecond, delegate(PerformanceCounter v)
			{
				UnknownErrorsPerSecond = v;
			}, PerformanceCounterType.RateOfCountsPerSecond32),
			new CounterDescriptor(() => CircuitBreakerErrorsPerSecond, delegate(PerformanceCounter v)
			{
				CircuitBreakerErrorsPerSecond = v;
			}, PerformanceCounterType.RateOfCountsPerSecond32),
			new CounterDescriptor(() => ThrottledErrorsPerSecond, delegate(PerformanceCounter v)
			{
				ThrottledErrorsPerSecond = v;
			}, PerformanceCounterType.RateOfCountsPerSecond32),
			new CounterDescriptor(() => DeserializationErrorsPerSecond, delegate(PerformanceCounter v)
			{
				DeserializationErrorsPerSecond = v;
			}, PerformanceCounterType.RateOfCountsPerSecond32),
			new CounterDescriptor(() => ResponseIsValidEmail, delegate(PerformanceCounter v)
			{
				ResponseIsValidEmail = v;
			}, PerformanceCounterType.RateOfCountsPerSecond32),
			new CounterDescriptor(() => ResponseIsInvalidEmail, delegate(PerformanceCounter v)
			{
				ResponseIsInvalidEmail = v;
			}, PerformanceCounterType.RateOfCountsPerSecond32),
			new CounterDescriptor(() => ResponseIsUnknownEmail, delegate(PerformanceCounter v)
			{
				ResponseIsUnknownEmail = v;
			}, PerformanceCounterType.RateOfCountsPerSecond32),
			new CounterDescriptor(() => ResponseCannotValidate, delegate(PerformanceCounter v)
			{
				ResponseCannotValidate = v;
			}, PerformanceCounterType.RateOfCountsPerSecond32),
			new CounterDescriptor(() => ResponseIsDisposableEmail, delegate(PerformanceCounter v)
			{
				ResponseIsDisposableEmail = v;
			}, PerformanceCounterType.RateOfCountsPerSecond32),
			new CounterDescriptor(() => ResponseIsRoleAddressEmail, delegate(PerformanceCounter v)
			{
				ResponseIsRoleAddressEmail = v;
			}, PerformanceCounterType.RateOfCountsPerSecond32),
			new CounterDescriptor(() => ResponseIsInvalidEmailFormat, delegate(PerformanceCounter v)
			{
				ResponseIsInvalidEmailFormat = v;
			}, PerformanceCounterType.RateOfCountsPerSecond32),
			new CounterDescriptor(() => ResponseIsInvalidEmailDomain, delegate(PerformanceCounter v)
			{
				ResponseIsInvalidEmailDomain = v;
			}, PerformanceCounterType.RateOfCountsPerSecond32),
			new CounterDescriptor(() => ResponseIsInvalidEmailAccount, delegate(PerformanceCounter v)
			{
				ResponseIsInvalidEmailAccount = v;
			}, PerformanceCounterType.RateOfCountsPerSecond32)
		};
		CounterCreator.InitializeMultiInstance("Roblox.BriteVerifyV2", _ApiName, httpCounters);
		CounterDescriptor[] counters2 = new CounterDescriptor[1]
		{
			new CounterDescriptor(() => ResponseIsAcceptAllEmail, delegate(PerformanceCounter v)
			{
				ResponseIsAcceptAllEmail = v;
			}, PerformanceCounterType.RateOfCountsPerSecond32)
		};
		CounterCreator.InitializeMultiInstance("Roblox.BriteVerifyV3", _ApiName, counters2);
	}

	public virtual void Increment(TimeSpan requestTime)
	{
		RequestsPerSecond.Increment();
		SendAverageDuration.IncrementBy(requestTime.Ticks);
		SendAverageDurationBase.Increment();
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
		if (_Settings.IsDetailedBriteVerifyErrorLoggingEnabled)
		{
			string requestBody = JsonConvert.SerializeObject(request);
			LogException($"BriteVerify. ApiName: {_ApiName}, Request Length: {requestTime:c}, Request Body: {requestBody}, Status Code: {(ex as ApiClientException)?.StatusCode} Exception {ex.Message}");
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

	public void IncrementResponseIsValidEmail()
	{
		ResponseIsValidEmail.Increment();
	}

	public void IncrementResponseIsInvalidEmail()
	{
		ResponseIsInvalidEmail.Increment();
	}

	public void IncrementResponseIsAcceptAllEmail()
	{
		ResponseIsAcceptAllEmail.Increment();
	}

	public void IncrementResponseIsUnknownEmail()
	{
		ResponseIsUnknownEmail.Increment();
	}

	public void IncrementResponseCannotValidate()
	{
		ResponseCannotValidate.Increment();
	}

	public void IncrementResponseIsDisposableEmail()
	{
		ResponseIsDisposableEmail.Increment();
	}

	public void IncrementResponseIsRoleAddressEmail()
	{
		ResponseIsRoleAddressEmail.Increment();
	}

	public void IncrementResponseIsInvalidEmailFormat()
	{
		ResponseIsInvalidEmailFormat.Increment();
	}

	public void IncrementResponseIsInvalidEmailDomain()
	{
		ResponseIsInvalidEmailDomain.Increment();
	}

	public void IncrementResponseIsInvalidEmailAccount()
	{
		ResponseIsInvalidEmailAccount.Increment();
	}
}
