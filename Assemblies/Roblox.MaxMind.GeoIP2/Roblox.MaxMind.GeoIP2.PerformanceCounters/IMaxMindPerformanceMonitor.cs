using System;
using System.Net;

namespace Roblox.MaxMind.GeoIP2.PerformanceCounters;

/// <summary>
/// Performance Monitor Interface
/// </summary>
public interface IMaxMindPerformanceMonitor
{
	/// <summary>
	/// Increment API Call
	/// </summary>
	/// <param name="requestTime"></param>
	void IncrementResponse(TimeSpan requestTime);

	/// <summary>
	/// Increment Registered Country
	/// </summary>
	void IncrementResponseHasRegisteredCountry();

	/// <summary>
	/// Increment Represented Country
	/// </summary>
	void IncrementResponseHasRepresentedCountry();

	/// <summary>
	/// Increment Exception
	/// </summary>
	/// <param name="request"></param>
	/// <param name="requestTime"></param>
	/// <param name="ex"></param>
	void IncrementException(object request, TimeSpan requestTime, WebException ex);
}
