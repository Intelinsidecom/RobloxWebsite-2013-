namespace Roblox.Billing.Metrics;

/// <summary>
/// A performance counter for tracking mobile purchases per country per platform.
/// </summary>
internal interface IPurchaserCountryPerformanceCounter
{
	/// <summary>
	/// Increment the performance counter.
	/// </summary>
	void Increment();
}
