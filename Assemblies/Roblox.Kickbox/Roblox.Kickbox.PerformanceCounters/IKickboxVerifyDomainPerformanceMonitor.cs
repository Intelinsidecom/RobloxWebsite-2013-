namespace Roblox.Kickbox.PerformanceCounters;

internal interface IKickboxVerifyDomainPerformanceMonitor : IKickboxPerformanceMonitorBase
{
	void IncrementIsDisposableDomain();

	void IncrementIsValidDomain();
}
