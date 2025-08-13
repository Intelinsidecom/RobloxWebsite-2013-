using System;
using System.Collections.Concurrent;
using System.Diagnostics.CodeAnalysis;
using System.Net;
using Roblox.Instrumentation;

namespace Roblox.Web.Metrics;

/// <inheritdoc cref="T:Roblox.Web.Metrics.IWebResponseMetricsFactory" />
public class WebResponseMetricsFactory : IWebResponseMetricsFactory
{
	private readonly ConcurrentDictionary<HttpStatusCode, Lazy<IHttpStatusCodePerformanceCounter>> _HttpStatusCodePerfCounters = new ConcurrentDictionary<HttpStatusCode, Lazy<IHttpStatusCodePerformanceCounter>>();

	private readonly ConcurrentDictionary<string, Lazy<IEndpointResponsePerformanceCounter>> _EndpointResponsePerfCounters = new ConcurrentDictionary<string, Lazy<IEndpointResponsePerformanceCounter>>();

	private readonly ConcurrentDictionary<string, Lazy<IEndpointFailurePerformanceCounter>> _EndpointFailurePerfCounters = new ConcurrentDictionary<string, Lazy<IEndpointFailurePerformanceCounter>>();

	private readonly ConcurrentDictionary<string, Lazy<IAspNetPerformanceCounter>> _AspNetPerfCounters = new ConcurrentDictionary<string, Lazy<IAspNetPerformanceCounter>>();

	private readonly string _PerformanceCounterCategoryPrefix;

	private readonly ICounterRegistry _CounterRegistry;

	/// <summary>
	/// Initializes a new <see cref="T:Roblox.Web.Metrics.WebResponseMetricsFactory" />
	/// </summary>
	/// <param name="performanceCounterCategoryPrefix">The performance counter category prefix.</param>
	/// <param name="counterRegistry">The counter registry injected.</param>
	/// <exception cref="T:System.ArgumentException"><paramref name="performanceCounterCategoryPrefix" /> is null or whitespace.</exception>
	public WebResponseMetricsFactory(ICounterRegistry counterRegistry, string performanceCounterCategoryPrefix)
	{
		if (string.IsNullOrWhiteSpace(performanceCounterCategoryPrefix))
		{
			throw new ArgumentException("Performance counter prefix must not be null or whitespace.", "performanceCounterCategoryPrefix");
		}
		_CounterRegistry = counterRegistry ?? throw new ArgumentNullException("counterRegistry");
		_PerformanceCounterCategoryPrefix = performanceCounterCategoryPrefix;
	}

	/// <inheritdoc cref="M:Roblox.Web.Metrics.IWebResponseMetricsFactory.GetEndpointResponsePerformanceCounter(System.String,System.String)" />
	public IEndpointResponsePerformanceCounter GetEndpointResponsePerformanceCounter(string controllerName, string actionName)
	{
		if (string.IsNullOrWhiteSpace(controllerName))
		{
			throw new ArgumentException("The controller name must not be null or whitespace.", "controllerName");
		}
		if (string.IsNullOrWhiteSpace(actionName))
		{
			throw new ArgumentException("The action name must not be null or whitespace.", "actionName");
		}
		string id = $"{controllerName}:{actionName}";
		return _EndpointResponsePerfCounters.GetOrAdd(id, (string _) => new Lazy<IEndpointResponsePerformanceCounter>(() => CreateEndpointResponsePerformanceCounter(controllerName, actionName))).Value;
	}

	/// <inheritdoc cref="M:Roblox.Web.Metrics.IWebResponseMetricsFactory.GetEndpointResponsePerformanceCounter(System.String,System.String)" />
	public IEndpointFailurePerformanceCounter GetEndpointFailurePerformanceCounter(string controllerName, string actionName)
	{
		if (string.IsNullOrWhiteSpace(controllerName))
		{
			throw new ArgumentException("The controller name must not be null or whitespace.", "controllerName");
		}
		if (string.IsNullOrWhiteSpace(actionName))
		{
			throw new ArgumentException("The action name must not be null or whitespace.", "actionName");
		}
		string id = $"{controllerName}:{actionName}";
		return _EndpointFailurePerfCounters.GetOrAdd(id, (string _) => new Lazy<IEndpointFailurePerformanceCounter>(() => CreateEndpointFailurePerformanceCounter(controllerName, actionName))).Value;
	}

	/// <inheritdoc cref="M:Roblox.Web.Metrics.IWebResponseMetricsFactory.GetHttpStatusCodePerformanceCounter(System.Net.HttpStatusCode)" />
	public IHttpStatusCodePerformanceCounter GetHttpStatusCodePerformanceCounter(HttpStatusCode statusCode)
	{
		return _HttpStatusCodePerfCounters.GetOrAdd(statusCode, (HttpStatusCode _) => new Lazy<IHttpStatusCodePerformanceCounter>(() => CreateHttpResponseStatusCodePerformanceCounter(statusCode))).Value;
	}

	/// <inheritdoc cref="M:Roblox.Web.Metrics.IWebResponseMetricsFactory.GetAspNetPerformanceCounter(Roblox.Web.Metrics.AspNetPageType,System.String)" />
	public IAspNetPerformanceCounter GetAspNetPerformanceCounter(AspNetPageType pageType, string pageName)
	{
		string id = $"{pageType}:{pageName}";
		return _AspNetPerfCounters.GetOrAdd(id, (string _) => new Lazy<IAspNetPerformanceCounter>(() => CreateAspNetPerformanceCounter(pageType, pageName))).Value;
	}

	[ExcludeFromCodeCoverage]
	internal virtual IHttpStatusCodePerformanceCounter CreateHttpResponseStatusCodePerformanceCounter(HttpStatusCode statusCode)
	{
		return new HttpStatusCodePerformanceCounter(_CounterRegistry, $"{_PerformanceCounterCategoryPrefix}.ResponseStatus", statusCode);
	}

	[ExcludeFromCodeCoverage]
	internal virtual IEndpointResponsePerformanceCounter CreateEndpointResponsePerformanceCounter(string controllerName, string actionName)
	{
		return new EndpointResponsePerformanceCounter(_CounterRegistry, $"{_PerformanceCounterCategoryPrefix}.PerEndpointMetricsV1", controllerName, actionName);
	}

	[ExcludeFromCodeCoverage]
	internal virtual IEndpointFailurePerformanceCounter CreateEndpointFailurePerformanceCounter(string controllerName, string actionName)
	{
		return new EndpointFailurePerformanceCounter(_CounterRegistry, $"{_PerformanceCounterCategoryPrefix}.PerEndpointFailureMetricsV1", controllerName, actionName);
	}

	[ExcludeFromCodeCoverage]
	internal virtual IAspNetPerformanceCounter CreateAspNetPerformanceCounter(AspNetPageType pageType, string pageName)
	{
		return new AspNetPerformanceCounter(_CounterRegistry, $"{_PerformanceCounterCategoryPrefix}.AspNetMetricsV1", pageType, pageName);
	}
}
