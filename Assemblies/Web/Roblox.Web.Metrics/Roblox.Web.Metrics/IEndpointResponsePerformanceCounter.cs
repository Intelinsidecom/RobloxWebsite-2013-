using System;

namespace Roblox.Web.Metrics;

/// <summary>
/// A performance counter for per endpoint metrics
/// </summary>
public interface IEndpointResponsePerformanceCounter
{
	/// <summary>
	/// Increments the web execution, and response count total counters
	/// </summary>
	/// <param name="executionTime">The request execution time.</param>
	void Increment(TimeSpan executionTime);
}
