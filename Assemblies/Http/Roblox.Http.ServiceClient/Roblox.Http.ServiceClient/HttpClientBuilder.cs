using System;
using System.Net;
using Roblox.Http.Client;
using Roblox.Http.Client.Monitoring;
using Roblox.Instrumentation;
using Roblox.Pipeline;
using Roblox.RequestContext;
using Roblox.Sentinels.CircuitBreakerPolicy;

namespace Roblox.Http.ServiceClient;

public class HttpClientBuilder : Roblox.Http.Client.HttpClientBuilder
{
	private const string _CircuitBreakerPerformanceMetricsCategory = "Roblox.GuardedApiClientV2";

	public Func<bool> ApiKeyViaHeaderEnabled { get; set; }

	public HttpClientBuilder(IServiceClientSettings serviceClientSettings, ICounterRegistry counterRegistry, Func<string> apiKeyGetter, CookieContainer cookieContainer = null, IRequestContextLoader requestContextLoader = null)
		: base(cookieContainer, serviceClientSettings)
	{
		if (serviceClientSettings == null)
		{
			throw new ArgumentNullException("serviceClientSettings");
		}
		if (counterRegistry == null)
		{
			throw new ArgumentNullException("counterRegistry");
		}
		if (apiKeyGetter == null)
		{
			throw new ArgumentNullException("apiKeyGetter");
		}
		if (string.IsNullOrWhiteSpace(serviceClientSettings.ClientName))
		{
			throw new ArgumentException(string.Format("{0}.{1} value has to be a non-empty string.", "serviceClientSettings", "ClientName"), "serviceClientSettings");
		}
		AppendHandler(new OperationErrorHandler());
		AppendHandler(new ApiKeyHandler(apiKeyGetter, IsApiKeyViaHeaderEnabled));
		if (requestContextLoader != null)
		{
			AppendHandler(new RequestContextHandler(requestContextLoader));
		}
		HttpRequestMetricsHandler handler = new HttpRequestMetricsHandler(counterRegistry, "Roblox.ApiClient", serviceClientSettings.ClientName);
		AddHandlerBefore<SendHttpRequestHandler>(handler);
		DefaultCircuitBreakerPolicy<IExecutionContext<IHttpRequest, IHttpResponse>> circuitBreakerPolicy = new DefaultCircuitBreakerPolicy<IExecutionContext<IHttpRequest, IHttpResponse>>(string.Format("{0}.{1}", "Roblox.GuardedApiClientV2", serviceClientSettings.ClientName), serviceClientSettings, new DefaultTripReasonAuthority());
		new CircuitBreakerPolicyMetricsEventHandler(counterRegistry).RegisterEvents(circuitBreakerPolicy, "Roblox.GuardedApiClientV2", serviceClientSettings.ClientName);
		AddHandlerAfter<RequestFailureThrowsHandler>(new CircuitBreakerHandler(circuitBreakerPolicy));
	}

	private bool IsApiKeyViaHeaderEnabled()
	{
		if (ApiKeyViaHeaderEnabled == null)
		{
			return false;
		}
		return ApiKeyViaHeaderEnabled();
	}
}
