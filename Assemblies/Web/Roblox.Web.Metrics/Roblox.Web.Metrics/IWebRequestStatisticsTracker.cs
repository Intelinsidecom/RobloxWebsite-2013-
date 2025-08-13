using System.Web;

namespace Roblox.Web.Metrics;

/// <summary>
/// A class for tracking metrics about requests
/// </summary>
public interface IWebRequestStatisticsTracker
{
	/// <summary>
	/// Tracks information on an <see cref="T:System.Web.HttpContextBase" /> about what action is being
	/// used to be tracked when the request ends.
	/// </summary>
	/// <remarks>
	/// It is possible for this to be called multiple times in a single Http request
	/// for cases where multiple actions are called in a single request.
	/// </remarks>
	/// <param name="requestContext">The <see cref="T:System.Web.HttpContextBase" />.</param>
	/// <param name="controllerName">The controller name the action belongs to.</param>
	/// <param name="actionName">The name of the action being called.</param>
	void OnActionChosen(HttpContextBase requestContext, string controllerName, string actionName);

	/// <summary>
	/// Tracks metrics when a request ends
	/// </summary>
	/// <param name="request">The <see cref="T:System.Web.HttpRequestBase" />.</param>
	/// <param name="response">The <see cref="T:System.Web.HttpResponseBase" />.</param>
	void OnRequestEnd(HttpRequestBase request, HttpResponseBase response);
}
