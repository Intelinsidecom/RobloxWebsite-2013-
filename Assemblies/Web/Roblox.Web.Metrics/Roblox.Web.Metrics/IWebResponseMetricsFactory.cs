using System.Net;

namespace Roblox.Web.Metrics;

/// <summary>
/// A factory that gets Web.Metrics specific performance counters
/// </summary>
public interface IWebResponseMetricsFactory
{
	/// <summary>
	/// Gets an <see cref="T:Roblox.Web.Metrics.IEndpointResponsePerformanceCounter" /> for an action
	/// </summary>
	/// <remarks>
	/// This interface is reused among multiple calls.
	/// </remarks>
	/// <param name="controllerName">The controller name the action belongs to.</param>
	/// <param name="actionName">The action name.</param>
	/// <returns><see cref="T:Roblox.Web.Metrics.IEndpointResponsePerformanceCounter" /></returns>
	IEndpointResponsePerformanceCounter GetEndpointResponsePerformanceCounter(string controllerName, string actionName);

	/// <summary>
	/// Gets an <see cref="T:Roblox.Web.Metrics.IEndpointFailurePerformanceCounter" /> for an action
	/// </summary>
	/// <remarks>
	/// This interface is reused among multiple calls.
	/// </remarks>
	/// <param name="controllerName">The controller name the action belongs to.</param>
	/// <param name="actionName">The action name.</param>
	/// <returns><see cref="T:Roblox.Web.Metrics.IEndpointFailurePerformanceCounter" /></returns>
	IEndpointFailurePerformanceCounter GetEndpointFailurePerformanceCounter(string controllerName, string actionName);

	/// <summary>
	/// Gets an <see cref="T:Roblox.Web.Metrics.IHttpStatusCodePerformanceCounter" /> for an <see cref="T:System.Net.HttpStatusCode" />
	/// </summary>
	/// <remarks>
	/// This interface is reused among multiple calls.
	/// </remarks>
	/// <param name="statusCode">The <see cref="T:System.Net.HttpStatusCode" />.</param>
	/// <returns><see cref="T:Roblox.Web.Metrics.IHttpStatusCodePerformanceCounter" /></returns>
	IHttpStatusCodePerformanceCounter GetHttpStatusCodePerformanceCounter(HttpStatusCode statusCode);

	/// <summary>
	/// Gets an <see cref="T:Roblox.Web.Metrics.IAspNetPerformanceCounter" /> for an ASP.NET file.
	/// </summary>
	/// <param name="pageType">The file <see cref="T:Roblox.Web.Metrics.AspNetPageType" />.</param>
	/// <param name="pageName">The ASP.NET class name for the file.</param>
	/// <returns><see cref="T:Roblox.Web.Metrics.IAspNetPerformanceCounter" /></returns>
	/// <exception cref="T:System.ArgumentException"><paramref name="pageName" /> is null or whitespace.</exception>
	IAspNetPerformanceCounter GetAspNetPerformanceCounter(AspNetPageType pageType, string pageName);
}
