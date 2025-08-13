namespace Roblox.Kickbox.PerformanceCounters;

internal interface IKickboxVerifyEmailPerformanceMonitor : IKickboxPerformanceMonitorBase
{
	void IncrementResponseIsSuccess();

	void IncrementResponseIsInvalidEmail();

	void IncrementResponseIsRejectedEmail();

	void IncrementResponseIsLowQualityEmail();

	void IncrementResponseIsAcceptAllEmail();

	void IncrementResponseIsDisposableEmail();

	void IncrementResponseIsRoleAddressEmail();

	void IncrementResponseIsInvalidEmailFormat();

	void IncrementResponseIsInvalidEmailDomain();
}
