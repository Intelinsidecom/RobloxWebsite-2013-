using System;
using Roblox.Instrumentation;
using Roblox.Kickbox.Properties;

namespace Roblox.Kickbox.PerformanceCounters;

internal class KickboxVerifyDomainPerformanceMonitor : KickboxPerformanceMonitorBase, IKickboxVerifyDomainPerformanceMonitor, IKickboxPerformanceMonitorBase
{
	public const string _PerformanceCategory = "Roblox.Kickbox.DomainVerifyV1";

	private readonly ICounterRegistry _CounterRegistry;

	public readonly IRateOfCountsPerSecondCounter ResponseIsValidDomainCounter;

	public readonly IRateOfCountsPerSecondCounter ResponseIsDisposableDomainCounter;

	public KickboxVerifyDomainPerformanceMonitor(ICounterRegistry counterRegisry, string apiName, IKickboxSettings settings)
		: base(apiName, settings)
	{
		_CounterRegistry = counterRegisry ?? throw new ArgumentNullException("counterRegisry");
		ResponseIsValidDomainCounter = _CounterRegistry.GetRateOfCountsPerSecondCounter("Roblox.Kickbox.DomainVerifyV1", "ResponseIsValidDomainCounter");
		ResponseIsDisposableDomainCounter = _CounterRegistry.GetRateOfCountsPerSecondCounter("Roblox.Kickbox.DomainVerifyV1", "ResponseIsDisposableDomainCounter");
		base.RequestsPerSecond = _CounterRegistry.GetRateOfCountsPerSecondCounter("Roblox.Kickbox.DomainVerifyV1", "RequestsPerSecond");
		base.SendAverageDuration = _CounterRegistry.GetAverageValueCounter("Roblox.Kickbox.DomainVerifyV1", "SendAverageDuration");
		base.ErrorsPerSecond = _CounterRegistry.GetRateOfCountsPerSecondCounter("Roblox.Kickbox.DomainVerifyV1", "ErrorsPerSecond");
		base.BadRequestsPerSecond = _CounterRegistry.GetRateOfCountsPerSecondCounter("Roblox.Kickbox.DomainVerifyV1", "BadRequestsPerSecond");
		base.InternalServerErrorsPerSecond = _CounterRegistry.GetRateOfCountsPerSecondCounter("Roblox.Kickbox.DomainVerifyV1", "InternalServerErrorsPerSecond");
		base.TimeoutErrorsPerSecond = _CounterRegistry.GetRateOfCountsPerSecondCounter("Roblox.Kickbox.DomainVerifyV1", "TimeoutErrorsPerSecond");
		base.NameResolutionFailureErrorsPerSecond = _CounterRegistry.GetRateOfCountsPerSecondCounter("Roblox.Kickbox.DomainVerifyV1", "NameResolutionFailureErrorsPerSecond");
		base.ConnectionClosedErrorsPerSecond = _CounterRegistry.GetRateOfCountsPerSecondCounter("Roblox.Kickbox.DomainVerifyV1", "ConnectionClosedErrorsPerSecond");
		base.OtherWebExceptionStatusErrorsPerSecond = _CounterRegistry.GetRateOfCountsPerSecondCounter("Roblox.Kickbox.DomainVerifyV1", "OtherWebExceptionStatusErrorsPerSecond");
		base.UnknownErrorsPerSecond = _CounterRegistry.GetRateOfCountsPerSecondCounter("Roblox.Kickbox.DomainVerifyV1", "UnknownErrorsPerSecond");
		base.CircuitBreakerErrorsPerSecond = _CounterRegistry.GetRateOfCountsPerSecondCounter("Roblox.Kickbox.DomainVerifyV1", "CircuitBreakerErrorsPerSecond");
		base.ThrottledErrorsPerSecond = _CounterRegistry.GetRateOfCountsPerSecondCounter("Roblox.Kickbox.DomainVerifyV1", "ThrottledErrorsPerSecond");
		base.DeserializationErrorsPerSecond = _CounterRegistry.GetRateOfCountsPerSecondCounter("Roblox.Kickbox.DomainVerifyV1", "DeserializationErrorsPerSecond");
	}

	public void IncrementIsDisposableDomain()
	{
		ResponseIsDisposableDomainCounter.Increment();
	}

	public void IncrementIsValidDomain()
	{
		ResponseIsValidDomainCounter.Increment();
	}
}
