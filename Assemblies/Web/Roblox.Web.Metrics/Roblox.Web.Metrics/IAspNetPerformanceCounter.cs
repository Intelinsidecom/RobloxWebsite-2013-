namespace Roblox.Web.Metrics;

/// <summary>
/// A performance counter for increment 
/// </summary>
public interface IAspNetPerformanceCounter
{
	/// <summary>
	/// Increments the counter instance for request tracking.
	/// </summary>
	/// <remarks>
	/// For now we don't need to track ASP.NET responses, just requests
	/// so we know whether or not they get traffic so we know if we can
	/// remove them.
	///
	/// If we need responses too at some point we can add it here as a separate method.
	/// </remarks>
	void IncrementRequest();
}
