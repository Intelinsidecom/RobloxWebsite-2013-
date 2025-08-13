using System.Web;

namespace Roblox.Web.Code;

/// <summary>
/// This class is used to perform actions which happen through the lifecycle of an application. Do not add www website specific code to this code.
/// </summary>
/// <remarks>
/// Anything added here should in general be applicable for all the user facing sites.
/// </remarks>
public interface IWebApplicationLifeCycleManager
{
	/// <summary>
	/// Checks the authentication status of an <see cref="T:System.Web.HttpRequest" />
	/// </summary>
	/// <param name="request">The <see cref="T:System.Web.HttpRequest" />.</param>
	void AuthenticateRequest(HttpRequest request);

	/// <summary>
	/// Start tracking information about the request
	/// </summary>
	/// <remarks><paramref name="response" /> is not used right now, but should not be null.</remarks>
	/// <param name="request">The <see cref="T:System.Web.HttpRequest" />.</param>
	/// <param name="response">The <see cref="T:System.Web.HttpResponse" />.</param>
	void BeginRequest(HttpRequest request, HttpResponse response);

	/// <summary>
	/// Tracks additionally information about the request once we have it.
	/// </summary>
	/// <param name="requestContext">The <see cref="T:System.Web.HttpContextBase" /> from the request.</param>
	/// <param name="controllerName">The controller name that action belongs to.</param>
	/// <param name="actionName">The action name the request is executing on.</param>
	void ActionChosen(HttpContextBase requestContext, string controllerName, string actionName);

	/// <summary>
	/// Tracks when request headers are sent
	/// </summary>
	/// <param name="request">The <see cref="T:System.Web.HttpRequest" />.</param>
	/// <param name="response">The <see cref="T:System.Web.HttpResponse" />.</param>
	void PreSendRequestHeaders(HttpRequest request, HttpResponse response);

	/// <summary>
	/// Tracks when the request ends.
	/// </summary>
	/// <param name="request">The <see cref="T:System.Web.HttpRequest" />.</param>
	/// <param name="response">The <see cref="T:System.Web.HttpResponse" />.</param>
	void EndRequest(HttpRequest request, HttpResponse response);
}
