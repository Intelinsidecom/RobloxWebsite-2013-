namespace Roblox.Web.Metrics;

/// <summary>
/// A performance counter for tracking Http status codes per site
/// </summary>
public interface IHttpStatusCodePerformanceCounter
{
	/// <summary>
	/// Increments the performance counter
	/// </summary>
	void Increment();
}
