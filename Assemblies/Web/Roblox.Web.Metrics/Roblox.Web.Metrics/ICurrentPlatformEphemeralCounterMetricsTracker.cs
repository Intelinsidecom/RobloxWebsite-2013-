namespace Roblox.Web.Metrics;

/// <summary>
/// Interface for writing metrics to EphemeralCounters for the current request's <see cref="T:Roblox.Platform.Devices.IPlatform" />.
/// </summary>
/// <remarks>
/// DO NOT USE THIS IN A CHILD THREAD
/// Doing so will result in the HttpContext used below to be null.
/// </remarks>
public interface ICurrentPlatformEphemeralCounterMetricsTracker
{
	/// <summary>
	/// Increments the <see cref="T:Roblox.EphemeralCounters.ICounter" />s for the current <see cref="T:Roblox.Platform.Devices.IPlatform" />, using <paramref name="prefix" /> and <paramref name="suffix" /> to construct counter names.
	/// </summary>
	/// <remarks>This method will do nothing if there is no current <see cref="T:System.Web.HttpContext" />.</remarks>
	/// <param name="prefix">The <see cref="T:Roblox.EphemeralCounters.ICounter" />'s prefix.</param>
	/// <param name="suffix">The <see cref="T:Roblox.EphemeralCounters.ICounter" />'s suffix.</param>
	void IncrementCountersForCurrentPlatform(string prefix, string suffix = null);

	/// <summary>
	/// Increments a counter equivalent to "{prefix}_Global" or "{prefix}_Global_{suffix}" if suffix is defined.
	/// Also increments the <see cref="T:Roblox.EphemeralCounters.ICounter" />s for the current <see cref="T:Roblox.Platform.Devices.IPlatform" />, using <paramref name="prefix" /> and <paramref name="suffix" /> to construct counter names.
	/// </summary>
	/// <remarks>This method will only increment the global counter if there is no <see cref="T:System.Web.HttpContext" />.</remarks>
	/// <param name="prefix">The <see cref="T:Roblox.EphemeralCounters.ICounter" />'s prefix.</param>
	/// <param name="suffix">The <see cref="T:Roblox.EphemeralCounters.ICounter" />'s suffix.</param>
	void IncrementCountersForCurrentPlatformAndGlobalCounter(string prefix, string suffix = null);
}
