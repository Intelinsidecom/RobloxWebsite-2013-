namespace Roblox.Http.Client.Monitoring;

public interface ICircuitBreakerPolicyPerformanceMonitor
{
	void IncrementRequestsThatTripCircuitBreakerPerSecond();

	void IncrementRequestsTrippedByCircuitBreakerPerSecond();
}
