using System;
using System.Web;
using Gigya.Socialize.SDK;
using Roblox.Common;
using Roblox.Gigya.Properties;
using Roblox.Instrumentation;

namespace Roblox.Gigya;

internal class GigyaPerformanceMonitor
{
	private readonly string _ApiName;

	private const int _ThrottlingErrorCode = 403048;

	private const int _TimeoutErrorCode = 504002;

	private const int _UnauthorizedUserErrorCode = 403005;

	private const string _PerformanceCategory = "Roblox.Gigya";

	internal IRateOfCountsPerSecondCounter OutgoingRequestsPerSecond { get; set; }

	internal IRateOfCountsPerSecondCounter ErrorsPerSecond { get; set; }

	internal IRateOfCountsPerSecondCounter ThrottlingErrorsPerSecond { get; set; }

	internal IRateOfCountsPerSecondCounter TimeoutErrorsPerSecond { get; set; }

	internal IAverageValueCounter SendAverageDuration { get; set; }

	public GigyaPerformanceMonitor(ICounterRegistry counterRegistry, string apiName)
	{
		if (counterRegistry == null)
		{
			throw new ArgumentNullException("counterRegistry");
		}
		if (string.IsNullOrWhiteSpace(apiName))
		{
			throw new ArgumentException("apiName is required");
		}
		_ApiName = apiName;
		OutgoingRequestsPerSecond = counterRegistry.GetRateOfCountsPerSecondCounter("Roblox.Gigya", "OutgoingRequestsPerSecond", _ApiName);
		ErrorsPerSecond = counterRegistry.GetRateOfCountsPerSecondCounter("Roblox.Gigya", "ErrorsPerSecond", _ApiName);
		ThrottlingErrorsPerSecond = counterRegistry.GetRateOfCountsPerSecondCounter("Roblox.Gigya", "ThrottlingErrorsPerSecond", _ApiName);
		TimeoutErrorsPerSecond = counterRegistry.GetRateOfCountsPerSecondCounter("Roblox.Gigya", "TimeoutErrorsPerSecond", _ApiName);
		SendAverageDuration = counterRegistry.GetAverageValueCounter("Roblox.Gigya", "SendAverageDuration", _ApiName);
	}

	internal void Increment(GSRequest request, GSResponse response, TimeSpan requestTime)
	{
		OutgoingRequestsPerSecond.Increment();
		SendAverageDuration.Sample(requestTime.Ticks);
		int errorCode = response.GetErrorCode();
		switch (errorCode)
		{
		case 403005:
			if (_ApiName.ToLower() == "socialize.logout")
			{
				return;
			}
			break;
		case 0:
			return;
		}
		ErrorsPerSecond.Increment();
		switch (errorCode)
		{
		case 403048:
			ThrottlingErrorsPerSecond.Increment();
			break;
		case 504002:
			TimeoutErrorsPerSecond.Increment();
			if (Settings.Default.IsDetailedGigyaTimeoutLoggingEnabled)
			{
				LogDetailedTimeoutInformation(request, requestTime, response);
			}
			break;
		default:
			ExceptionHandler.LogException($"gigya {_ApiName} call failed with error code {errorCode} and message {response.GetErrorMessage()}");
			break;
		}
	}

	private void LogDetailedTimeoutInformation(GSRequest request, TimeSpan requestTime, GSResponse response)
	{
		HttpContext currentContext = HttpContext.Current;
		string errorMessage = $"Gigya Timed Out. ApiName: {_ApiName}, Request Time {requestTime}, Request Body {request.GetParams().ToJsonString()}, Response Headers: {response.GetHeaders().ToJSON()}, Response Data: {response.GetData().ToJsonString()}, Timestamp {DateTime.Now}";
		if (currentContext != null)
		{
			string clientIp = currentContext.GetOriginIP();
			errorMessage += $", Client IP: {clientIp}";
		}
		ExceptionHandler.LogException(errorMessage);
	}
}
