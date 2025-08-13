using System;
using System.Diagnostics;
using System.Net;
using Newtonsoft.Json;
using Roblox.CommunitySift.Properties;
using Roblox.Diagnostics;
using Roblox.RestClientBase;
using Roblox.Sentinels;

namespace Roblox.CommunitySift;

internal class CommunitySiftPerformanceMonitor : ICommunitySiftPerformanceMonitor
{
	private readonly string _ApiName;

	private readonly ICommunitySiftSettings _Settings;

	internal PerformanceCounter OutgoingRequestsPerSecond { get; set; }

	internal PerformanceCounter ShortRequestsPerSecond { get; set; }

	internal PerformanceCounter LongRequestsPerSecond { get; set; }

	internal PerformanceCounter SendAverageDuration { get; set; }

	internal PerformanceCounter SendAverageDurationBase { get; set; }

	internal PerformanceCounter ShortSendAverageDuration { get; set; }

	internal PerformanceCounter ShortSendAverageDurationBase { get; set; }

	internal PerformanceCounter LongSendAverageDuration { get; set; }

	internal PerformanceCounter LongSendAverageDurationBase { get; set; }

	internal PerformanceCounter ErrorsPerSecond { get; set; }

	internal PerformanceCounter BadRequestsPerSecond { get; set; }

	internal PerformanceCounter InternalServerErrorsPerSecond { get; set; }

	internal PerformanceCounter TimeoutErrorsPerSecond { get; set; }

	internal PerformanceCounter NameResolutionFailureErrorsPerSecond { get; set; }

	internal PerformanceCounter ConnectionClosedErrorsPerSecond { get; set; }

	internal PerformanceCounter OtherWebExceptionStatusErrorsPerSecond { get; set; }

	internal PerformanceCounter UnknownErrorsPerSecond { get; set; }

	internal PerformanceCounter DoubleChatRequestsPerSecond { get; set; }

	internal PerformanceCounter DoubleChatSendAverageDuration { get; set; }

	internal PerformanceCounter DoubleChatSendAverageDurationBase { get; set; }

	internal PerformanceCounter CircuitBreakerErrorsPerSecond { get; set; }

	internal PerformanceCounter ThrottledErrorsPerSecond { get; set; }

	internal PerformanceCounter DeserializationErrorsPerSecond { get; set; }

	internal PerformanceCounter UserNameRequestsPerSecond { get; set; }

	internal PerformanceCounter UserNameSendAverageDuration { get; set; }

	internal PerformanceCounter UserNameSendAverageDurationBase { get; set; }

	internal PerformanceCounter ResponseIsFalseHashIsWrong { get; set; }

	internal PerformanceCounter ResponseIsTrueHashIsSet { get; set; }

	internal PerformanceCounter ResponseIsTrueHashesCountDiffers { get; set; }

	internal virtual Action<string> LogException => ExceptionHandler.LogException;

	public CommunitySiftPerformanceMonitor(string apiName, ICommunitySiftSettings settings)
	{
		if (string.IsNullOrWhiteSpace(apiName))
		{
			throw new ArgumentException("apiName is required");
		}
		_ApiName = apiName;
		if (settings == null)
		{
			throw new ArgumentException("settings");
		}
		_Settings = settings;
		CounterDescriptor[] counters = new CounterDescriptor[4]
		{
			new CounterDescriptor(() => OutgoingRequestsPerSecond, delegate(PerformanceCounter v)
			{
				OutgoingRequestsPerSecond = v;
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
			}, PerformanceCounterType.RateOfCountsPerSecond32)
		};
		CounterCreator.InitializeMultiInstance("Roblox.CommunitySift", _ApiName, counters);
		CounterDescriptor[] counters2 = new CounterDescriptor[6]
		{
			new CounterDescriptor(() => ShortRequestsPerSecond, delegate(PerformanceCounter v)
			{
				ShortRequestsPerSecond = v;
			}, PerformanceCounterType.RateOfCountsPerSecond32),
			new CounterDescriptor(() => LongRequestsPerSecond, delegate(PerformanceCounter v)
			{
				LongRequestsPerSecond = v;
			}, PerformanceCounterType.RateOfCountsPerSecond32),
			new CounterDescriptor(() => ShortSendAverageDuration, delegate(PerformanceCounter v)
			{
				ShortSendAverageDuration = v;
			}, PerformanceCounterType.AverageTimer32),
			new CounterDescriptor(() => ShortSendAverageDurationBase, delegate(PerformanceCounter v)
			{
				ShortSendAverageDurationBase = v;
			}, PerformanceCounterType.AverageBase),
			new CounterDescriptor(() => LongSendAverageDuration, delegate(PerformanceCounter v)
			{
				LongSendAverageDuration = v;
			}, PerformanceCounterType.AverageTimer32),
			new CounterDescriptor(() => LongSendAverageDurationBase, delegate(PerformanceCounter v)
			{
				LongSendAverageDurationBase = v;
			}, PerformanceCounterType.AverageBase)
		};
		CounterCreator.InitializeMultiInstance("Roblox.CommunitySiftV2", _ApiName, counters2);
		CounterDescriptor[] counters3 = new CounterDescriptor[3]
		{
			new CounterDescriptor(() => DoubleChatRequestsPerSecond, delegate(PerformanceCounter v)
			{
				DoubleChatRequestsPerSecond = v;
			}, PerformanceCounterType.RateOfCountsPerSecond32),
			new CounterDescriptor(() => DoubleChatSendAverageDuration, delegate(PerformanceCounter v)
			{
				DoubleChatSendAverageDuration = v;
			}, PerformanceCounterType.AverageTimer32),
			new CounterDescriptor(() => DoubleChatSendAverageDurationBase, delegate(PerformanceCounter v)
			{
				DoubleChatSendAverageDurationBase = v;
			}, PerformanceCounterType.AverageBase)
		};
		CounterCreator.InitializeMultiInstance("Roblox.CommunitySiftV3", _ApiName, counters3);
		CounterDescriptor[] counters4 = new CounterDescriptor[3]
		{
			new CounterDescriptor(() => UserNameRequestsPerSecond, delegate(PerformanceCounter v)
			{
				UserNameRequestsPerSecond = v;
			}, PerformanceCounterType.RateOfCountsPerSecond32),
			new CounterDescriptor(() => UserNameSendAverageDuration, delegate(PerformanceCounter v)
			{
				UserNameSendAverageDuration = v;
			}, PerformanceCounterType.AverageTimer32),
			new CounterDescriptor(() => UserNameSendAverageDurationBase, delegate(PerformanceCounter v)
			{
				UserNameSendAverageDurationBase = v;
			}, PerformanceCounterType.AverageBase)
		};
		CounterCreator.InitializeMultiInstance("Roblox.CommunitySiftV4", _ApiName, counters4);
		CounterDescriptor[] counters5 = new CounterDescriptor[2]
		{
			new CounterDescriptor(() => ResponseIsFalseHashIsWrong, delegate(PerformanceCounter v)
			{
				ResponseIsFalseHashIsWrong = v;
			}, PerformanceCounterType.RateOfCountsPerSecond32),
			new CounterDescriptor(() => ResponseIsTrueHashIsSet, delegate(PerformanceCounter v)
			{
				ResponseIsTrueHashIsSet = v;
			}, PerformanceCounterType.RateOfCountsPerSecond32)
		};
		CounterCreator.InitializeMultiInstance("Roblox.CommunitySiftV5", _ApiName, counters5);
		CounterDescriptor[] counters6 = new CounterDescriptor[10]
		{
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
			}, PerformanceCounterType.RateOfCountsPerSecond32)
		};
		CounterCreator.InitializeMultiInstance("Roblox.CommunitySiftV6", _ApiName, counters6);
		CounterDescriptor[] counters7 = new CounterDescriptor[1]
		{
			new CounterDescriptor(() => ResponseIsTrueHashesCountDiffers, delegate(PerformanceCounter v)
			{
				ResponseIsTrueHashesCountDiffers = v;
			}, PerformanceCounterType.RateOfCountsPerSecond32)
		};
		CounterCreator.InitializeMultiInstance("Roblox.CommunitySiftV7", _ApiName, counters7);
	}

	public virtual void Increment(TimeSpan requestTime, PerformanceCounterRequestType requestType)
	{
		OutgoingRequestsPerSecond.Increment();
		SendAverageDuration.IncrementBy(requestTime.Ticks);
		SendAverageDurationBase.Increment();
		switch (requestType)
		{
		case PerformanceCounterRequestType.Chat:
			ShortRequestsPerSecond.Increment();
			ShortSendAverageDuration.IncrementBy(requestTime.Ticks);
			ShortSendAverageDurationBase.Increment();
			break;
		case PerformanceCounterRequestType.LongText:
			LongRequestsPerSecond.Increment();
			LongSendAverageDuration.IncrementBy(requestTime.Ticks);
			LongSendAverageDurationBase.Increment();
			break;
		case PerformanceCounterRequestType.DoubleChat:
			DoubleChatRequestsPerSecond.Increment();
			DoubleChatSendAverageDuration.IncrementBy(requestTime.Ticks);
			DoubleChatSendAverageDurationBase.Increment();
			break;
		case PerformanceCounterRequestType.UserName:
			UserNameRequestsPerSecond.Increment();
			UserNameSendAverageDuration.IncrementBy(requestTime.Ticks);
			UserNameSendAverageDurationBase.Increment();
			break;
		}
	}

	public virtual void IncrementException(object request, TimeSpan requestTime, PerformanceCounterRequestType requestType, Exception ex)
	{
		Increment(requestTime, requestType);
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
		if (_Settings.IsDetailedCommunitySiftErrorLoggingEnabled)
		{
			string requestBody = JsonConvert.SerializeObject(request);
			LogException($"CommunitySift. ApiName: {_ApiName}, Request Length: {requestTime:c}, Request Body: {requestBody}, Status Code: {(ex as ApiClientException)?.StatusCode} Exception {ex.Message}");
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

	public void IncrementResponseIsFalseHashIsWrong()
	{
		ResponseIsFalseHashIsWrong.Increment();
	}

	public void IncrementResponseIsTrueHashIsSet()
	{
		ResponseIsTrueHashIsSet.Increment();
	}

	public void IncrementResponseIsTrueHashesCountDiffers()
	{
		ResponseIsTrueHashesCountDiffers.Increment();
	}
}
