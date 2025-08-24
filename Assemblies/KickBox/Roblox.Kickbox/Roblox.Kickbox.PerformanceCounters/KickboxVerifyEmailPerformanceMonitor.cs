using System;
using Roblox.Instrumentation;
using Roblox.Kickbox.Properties;

namespace Roblox.Kickbox.PerformanceCounters;

internal class KickboxVerifyEmailPerformanceMonitor : KickboxPerformanceMonitorBase, IKickboxVerifyEmailPerformanceMonitor, IKickboxPerformanceMonitorBase
{
	internal const string _PerformanceCategory = "Roblox.Kickbox.EmailVerifyV1";

	internal readonly ICounterRegistry _CounterRegistry;

	internal IRateOfCountsPerSecondCounter ResponseIsSuccess { get; set; }

	internal IRateOfCountsPerSecondCounter ResponseIsInvalidEmail { get; set; }

	internal IRateOfCountsPerSecondCounter ResponseIsRejectedEmail { get; set; }

	internal IRateOfCountsPerSecondCounter ResponseIsLowQualityEmail { get; set; }

	internal IRateOfCountsPerSecondCounter ResponseIsAcceptAllEmail { get; set; }

	internal IRateOfCountsPerSecondCounter ResponseIsDisposableEmail { get; set; }

	internal IRateOfCountsPerSecondCounter ResponseIsRoleAddressEmail { get; set; }

	internal IRateOfCountsPerSecondCounter ResponseIsInvalidEmailFormat { get; set; }

	internal IRateOfCountsPerSecondCounter ResponseIsInvalidEmailDomain { get; set; }

	public KickboxVerifyEmailPerformanceMonitor(ICounterRegistry counterRegistry, string apiName, IKickboxSettings settings)
		: base(apiName, settings)
	{
		_CounterRegistry = counterRegistry ?? throw new ArgumentNullException("counterRegistry");
		ResponseIsSuccess = _CounterRegistry.GetRateOfCountsPerSecondCounter("Roblox.Kickbox.EmailVerifyV1", "ResponseIsSuccess");
		ResponseIsInvalidEmail = _CounterRegistry.GetRateOfCountsPerSecondCounter("Roblox.Kickbox.EmailVerifyV1", "ResponseIsInvalidEmail");
		ResponseIsRejectedEmail = _CounterRegistry.GetRateOfCountsPerSecondCounter("Roblox.Kickbox.EmailVerifyV1", "ResponseIsRejectedEmail");
		ResponseIsLowQualityEmail = _CounterRegistry.GetRateOfCountsPerSecondCounter("Roblox.Kickbox.EmailVerifyV1", "ResponseIsLowQualityEmail");
		ResponseIsAcceptAllEmail = _CounterRegistry.GetRateOfCountsPerSecondCounter("Roblox.Kickbox.EmailVerifyV1", "ResponseIsAcceptAllEmail");
		ResponseIsDisposableEmail = _CounterRegistry.GetRateOfCountsPerSecondCounter("Roblox.Kickbox.EmailVerifyV1", "ResponseIsDisposableEmail");
		ResponseIsRoleAddressEmail = _CounterRegistry.GetRateOfCountsPerSecondCounter("Roblox.Kickbox.EmailVerifyV1", "ResponseIsRoleAddressEmail");
		ResponseIsInvalidEmailFormat = _CounterRegistry.GetRateOfCountsPerSecondCounter("Roblox.Kickbox.EmailVerifyV1", "ResponseIsInvalidEmailFormat");
		ResponseIsInvalidEmailDomain = _CounterRegistry.GetRateOfCountsPerSecondCounter("Roblox.Kickbox.EmailVerifyV1", "ResponseIsInvalidEmailDomain");
		base.RequestsPerSecond = _CounterRegistry.GetRateOfCountsPerSecondCounter("Roblox.Kickbox.EmailVerifyV1", "RequestsPerSecond");
		base.SendAverageDuration = _CounterRegistry.GetAverageValueCounter("Roblox.Kickbox.EmailVerifyV1", "SendAverageDuration");
		base.ErrorsPerSecond = _CounterRegistry.GetRateOfCountsPerSecondCounter("Roblox.Kickbox.EmailVerifyV1", "ErrorsPerSecond");
		base.BadRequestsPerSecond = _CounterRegistry.GetRateOfCountsPerSecondCounter("Roblox.Kickbox.EmailVerifyV1", "BadRequestsPerSecond");
		base.InternalServerErrorsPerSecond = _CounterRegistry.GetRateOfCountsPerSecondCounter("Roblox.Kickbox.EmailVerifyV1", "InternalServerErrorsPerSecond");
		base.TimeoutErrorsPerSecond = _CounterRegistry.GetRateOfCountsPerSecondCounter("Roblox.Kickbox.EmailVerifyV1", "TimeoutErrorsPerSecond");
		base.NameResolutionFailureErrorsPerSecond = _CounterRegistry.GetRateOfCountsPerSecondCounter("Roblox.Kickbox.EmailVerifyV1", "NameResolutionFailureErrorsPerSecond");
		base.ConnectionClosedErrorsPerSecond = _CounterRegistry.GetRateOfCountsPerSecondCounter("Roblox.Kickbox.EmailVerifyV1", "ConnectionClosedErrorsPerSecond");
		base.OtherWebExceptionStatusErrorsPerSecond = _CounterRegistry.GetRateOfCountsPerSecondCounter("Roblox.Kickbox.EmailVerifyV1", "OtherWebExceptionStatusErrorsPerSecond");
		base.UnknownErrorsPerSecond = _CounterRegistry.GetRateOfCountsPerSecondCounter("Roblox.Kickbox.EmailVerifyV1", "UnknownErrorsPerSecond");
		base.CircuitBreakerErrorsPerSecond = _CounterRegistry.GetRateOfCountsPerSecondCounter("Roblox.Kickbox.EmailVerifyV1", "CircuitBreakerErrorsPerSecond");
		base.ThrottledErrorsPerSecond = _CounterRegistry.GetRateOfCountsPerSecondCounter("Roblox.Kickbox.EmailVerifyV1", "ThrottledErrorsPerSecond");
		base.DeserializationErrorsPerSecond = _CounterRegistry.GetRateOfCountsPerSecondCounter("Roblox.Kickbox.EmailVerifyV1", "DeserializationErrorsPerSecond");
	}

	public void IncrementResponseIsSuccess()
	{
		ResponseIsSuccess.Increment();
	}

	public void IncrementResponseIsInvalidEmail()
	{
		ResponseIsInvalidEmail.Increment();
	}

	public void IncrementResponseIsRejectedEmail()
	{
		ResponseIsRejectedEmail.Increment();
	}

	public void IncrementResponseIsLowQualityEmail()
	{
		ResponseIsLowQualityEmail.Increment();
	}

	public void IncrementResponseIsAcceptAllEmail()
	{
		ResponseIsAcceptAllEmail.Increment();
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
}
