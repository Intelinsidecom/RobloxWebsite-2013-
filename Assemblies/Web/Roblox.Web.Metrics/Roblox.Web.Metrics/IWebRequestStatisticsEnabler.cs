using System;
using System.Web;

namespace Roblox.Web.Metrics;

/// <summary>
/// Describes a facility that checks if counters should be enabled based on the collected information.
/// </summary>
public interface IWebRequestStatisticsEnabler
{
	/// <summary>
	/// Checks when to report the status code counter.
	/// </summary>
	/// <param name="response">The response that completed.</param>
	/// <returns>true if the status code needs to be reported or false otherwise</returns>
	bool IsStatusCodeTrackingEnabled(HttpResponseBase response);

	/// <summary>
	/// Checks when to report the endpoint response counter.
	/// </summary>
	/// <param name="response">The response that completed.</param>
	/// <param name="controller">The controller dispatching the response.</param>
	/// <param name="action">The action dispatching the response.</param>
	/// <param name="executionTime">The execution time it took to dispatch the response.</param>
	/// <returns>true if the endpoint response needs to be reported or false otherwise</returns>
	bool IsEndpointResponseTrackingEnabled(HttpResponseBase response, string controller, string action, TimeSpan executionTime);

	/// <summary>
	/// Checks when to report the endpoint failure counter.
	/// </summary>
	/// <param name="response">The response that completed.</param>
	/// <param name="controller">The controller dispatching the response.</param>
	/// <param name="action">The action dispatching the response.</param>
	/// <param name="executionTime">The execution time it took to dispatch the response.</param>
	/// <returns>true if the endpoint response needs to be reported or false otherwise</returns>
	bool IsEndpointFailureTrackingEnabled(HttpResponseBase response, string controller, string action, TimeSpan executionTime);
}
