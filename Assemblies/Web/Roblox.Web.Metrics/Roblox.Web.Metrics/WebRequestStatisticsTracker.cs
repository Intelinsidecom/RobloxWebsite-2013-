using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Net;
using System.Web;
using Roblox.Instrumentation;
using Roblox.Web.Metrics.Properties;

namespace Roblox.Web.Metrics;

/// <inheritdoc cref="T:Roblox.Web.Metrics.IWebRequestStatisticsTracker" />
public class WebRequestStatisticsTracker : IWebRequestStatisticsTracker
{
	internal const string RequestActionMetricsItemName = "WebRequestStatisticsTracker.ActionMetrics";

	private readonly IWebResponseMetricsFactory _WebResponseMetricsFactory;

	private readonly IWebRequestStatisticsEnabler _WebRequestStatisticsEnabler;

	[ExcludeFromCodeCoverage]
	internal virtual bool ArePerEndpointMetricsEnabled => Settings.Default.ArePerEndpointMetricsEnabled;

	[ExcludeFromCodeCoverage]
	internal virtual bool AreFailuresPerEndpointMetricsEnabled => Settings.Default.AreFailuresPerEndpointMetricsEnabled;

	/// <summary>
	/// This virtual seems useless, but exists to be overridable for testing.
	/// </summary>
	[ExcludeFromCodeCoverage]
	internal virtual DateTime UtcNow => DateTime.UtcNow;

	/// <summary>
	/// Initializes a new <see cref="T:Roblox.Web.Metrics.WebRequestStatisticsTracker" />
	/// </summary>
	/// <param name="performanceCounterCategoryPrefix">The performance counter prefix.</param>
	/// <param name="webRequestStatisticsEnabler">The custom extended enabler to use.</param>
	/// <param name="counterRegistry">The counter registry injected.</param>
	/// <exception cref="T:System.ArgumentException"><paramref name="performanceCounterCategoryPrefix" /> is null or whitespace.</exception>
	[ExcludeFromCodeCoverage]
	public WebRequestStatisticsTracker(ICounterRegistry counterRegistry, string performanceCounterCategoryPrefix, IWebRequestStatisticsEnabler webRequestStatisticsEnabler = null)
		: this(new WebResponseMetricsFactory(counterRegistry, performanceCounterCategoryPrefix), webRequestStatisticsEnabler)
	{
	}

	/// <summary>
	/// Initializes a new <see cref="T:Roblox.Web.Metrics.WebRequestStatisticsTracker" />
	/// </summary>
	/// <remarks>
	/// This constructor exists for tests only.
	/// </remarks>
	/// <param name="webResponseMetricsFactory">The <see cref="T:Roblox.Web.Metrics.IWebResponseMetricsFactory" /></param>
	/// <param name="webRequestStatisticsEnabler">The custom extended enabler to use.</param>
	/// <exception cref="T:System.ArgumentNullException">Any argument is null.</exception>
	internal WebRequestStatisticsTracker(IWebResponseMetricsFactory webResponseMetricsFactory, IWebRequestStatisticsEnabler webRequestStatisticsEnabler)
	{
		_WebResponseMetricsFactory = webResponseMetricsFactory;
		_WebRequestStatisticsEnabler = webRequestStatisticsEnabler;
	}

	/// <inheritdoc cref="M:Roblox.Web.Metrics.IWebRequestStatisticsTracker.OnActionChosen(System.Web.HttpContextBase,System.String,System.String)" />
	public void OnActionChosen(HttpContextBase requestContext, string controllerName, string actionName)
	{
		if (requestContext != null && !string.IsNullOrWhiteSpace(controllerName) && !string.IsNullOrWhiteSpace(actionName) && ArePerEndpointMetricsEnabled)
		{
			IList<ActionMetricsModel> actions;
			if ((actions = requestContext.Items["WebRequestStatisticsTracker.ActionMetrics"] as IList<ActionMetricsModel>) == null)
			{
				actions = new List<ActionMetricsModel>();
				requestContext.Items["WebRequestStatisticsTracker.ActionMetrics"] = actions;
			}
			actions.Add(new ActionMetricsModel
			{
				ActionName = actionName,
				ControllerName = controllerName,
				ActionExecutionStartTime = UtcNow
			});
		}
	}

	/// <inheritdoc cref="M:Roblox.Web.Metrics.IWebRequestStatisticsTracker.OnRequestEnd(System.Web.HttpRequestBase,System.Web.HttpResponseBase)" />
	public void OnRequestEnd(HttpRequestBase request, HttpResponseBase response)
	{
		if (response == null)
		{
			return;
		}
		HttpStatusCode statusCode = (HttpStatusCode)response.StatusCode;
		if (_WebRequestStatisticsEnabler == null || _WebRequestStatisticsEnabler.IsStatusCodeTrackingEnabled(response))
		{
			_WebResponseMetricsFactory.GetHttpStatusCodePerformanceCounter(statusCode).Increment();
		}
		if (request == null || !(request.RequestContext.HttpContext.Items["WebRequestStatisticsTracker.ActionMetrics"] is IList<ActionMetricsModel> actions))
		{
			return;
		}
		foreach (ActionMetricsModel actionMetrics in actions)
		{
			string action = actionMetrics?.ActionName;
			string controller = actionMetrics?.ControllerName;
			TimeSpan executionTime = UtcNow - actionMetrics.ActionExecutionStartTime;
			if (!string.IsNullOrWhiteSpace(action) && !string.IsNullOrWhiteSpace(controller))
			{
				if (ArePerEndpointMetricsEnabled && (_WebRequestStatisticsEnabler == null || _WebRequestStatisticsEnabler.IsEndpointResponseTrackingEnabled(response, controller, action, executionTime)))
				{
					_WebResponseMetricsFactory.GetEndpointResponsePerformanceCounter(controller, action).Increment(executionTime);
				}
				if (AreFailuresPerEndpointMetricsEnabled && _WebRequestStatisticsEnabler != null && _WebRequestStatisticsEnabler.IsEndpointFailureTrackingEnabled(response, controller, action, executionTime))
				{
					_WebResponseMetricsFactory.GetEndpointFailurePerformanceCounter(controller, action).Increment(executionTime);
				}
			}
		}
	}
}
