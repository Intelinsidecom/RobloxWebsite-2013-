using System;
using System.Web;
using Roblox.EventLog;
using Roblox.Web.Authentication;
using Roblox.Web.Metrics;

namespace Roblox.Web.Code;

/// <inheritdoc cref="T:Roblox.Web.Code.IWebApplicationLifeCycleManager" />
public class WebApplicationLifeCycleManager : IWebApplicationLifeCycleManager
{
	private readonly IWebRequestStatisticsTracker _WebRequestStatisticsTracker;

	private readonly IWebAuthenticator _WebAuthenticator;

	private readonly ILogger _Logger;

	/// <summary>
	/// Initializes a <see cref="T:Roblox.Web.Code.WebApplicationLifeCycleManager" />
	/// </summary>
	/// <param name="logger">An <see cref="T:Roblox.EventLog.ILogger" />.</param>
	/// <param name="webAuthenticator">A <see cref="T:Roblox.Web.Authentication.IWebAuthenticator" />.</param>
	/// <param name="webRequestStatisticsTracker">An <see cref="T:Roblox.Web.Metrics.IWebRequestStatisticsTracker" />.</param>
	public WebApplicationLifeCycleManager(ILogger logger, IWebAuthenticator webAuthenticator, IWebRequestStatisticsTracker webRequestStatisticsTracker)
	{
		_Logger = logger ?? throw new ArgumentNullException("logger");
		_WebRequestStatisticsTracker = webRequestStatisticsTracker ?? throw new ArgumentNullException("webRequestStatisticsTracker");
		_WebAuthenticator = webAuthenticator ?? throw new ArgumentNullException("webAuthenticator");
	}

	/// <inheritdoc cref="M:Roblox.Web.Code.IWebApplicationLifeCycleManager.AuthenticateRequest(System.Web.HttpRequest)" />
	public void AuthenticateRequest(HttpRequest request)
	{
		string verificationIdentifier = $"\n\tUrl: {request.Url}\n\tUser-Agent: {request.UserAgent}";
		_Logger.Verbose($"Verifying authentication for request.{verificationIdentifier}");
		if (!request.IsAuthenticated)
		{
			_Logger.Verbose($"Request considered unauthenticated based on user identity.{verificationIdentifier}");
			return;
		}
		bool authenticationIsValid = _WebAuthenticator.IsAuthCookieAndSessionValid();
		_Logger.Verbose($"Request authentication valid: {authenticationIsValid}{verificationIdentifier}");
	}

	/// <inheritdoc cref="M:Roblox.Web.Code.IWebApplicationLifeCycleManager.BeginRequest(System.Web.HttpRequest,System.Web.HttpResponse)" />
	public void BeginRequest(HttpRequest request, HttpResponse response)
	{
		try
		{
			_WebAuthenticator.RemoveAuthCookiePrefix(request);
		}
		catch (Exception ex)
		{
			_Logger.Info(ex.ToString());
		}
	}

	/// <inheritdoc cref="M:Roblox.Web.Code.IWebApplicationLifeCycleManager.ActionChosen(System.Web.HttpContextBase,System.String,System.String)" />
	public void ActionChosen(HttpContextBase requestContext, string controllerName, string actionName)
	{
		if (requestContext != null && !string.IsNullOrWhiteSpace(controllerName) && !string.IsNullOrWhiteSpace(actionName))
		{
			_WebRequestStatisticsTracker.OnActionChosen(requestContext, controllerName, actionName);
		}
	}

	public void PreSendRequestHeaders(HttpRequest request, HttpResponse response)
	{
		try
		{
			// No-op: AuthenticationV2 synchronizer not available in this build.
			// Maintain method for compatibility; nothing to do here.
		}
		catch (Exception ex)
		{
			_Logger.Info(ex.ToString());
		}
	}

	/// <inheritdoc cref="M:Roblox.Web.Code.IWebApplicationLifeCycleManager.EndRequest(System.Web.HttpRequest,System.Web.HttpResponse)" />
	public void EndRequest(HttpRequest request, HttpResponse response)
	{
		try
		{
			HttpRequestWrapper requestBase = new HttpRequestWrapper(request);
			HttpResponseWrapper responseBase = new HttpResponseWrapper(response);
			_WebRequestStatisticsTracker.OnRequestEnd(requestBase, responseBase);
		}
		catch (Exception ex)
		{
			_Logger.Info(ex.ToString());
		}
	}
}
