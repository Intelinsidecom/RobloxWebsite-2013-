using System;
using System.Net;
using Roblox.AuthenticationV2.Client.Properties;
using Roblox.Http;
using Roblox.Http.Client;
using Roblox.Http.Client.Monitoring;
using Roblox.Instrumentation;
using Roblox.Pipeline;
using Roblox.Sentinels.CircuitBreakerPolicy;

namespace Roblox.AuthenticationV2.Client;

/// <inheritdoc />
/// <summary>
/// A class for building <see cref="T:Roblox.Http.Client.IHttpClient" />s for the AuthenticationV2 Service
/// </summary>
internal class AuthenticationV2HttpClientBuilder : HttpClientBuilder
{
	private const string _CircuitBreakerPerformanceMetricsCategory = "Roblox.GuardedApiClientV2";

	/// <summary>
	/// Initializes a new <see cref="T:Roblox.Http.Client.HttpClientBuilder" />.
	/// </summary>
	/// <param name="clientSettings">The <see cref="T:Roblox.AuthenticationV2.Client.Properties.ISettings" />.</param>
	/// <param name="counterRegistry"><see cref="T:Roblox.Instrumentation.ICounterRegistry" /></param>
	/// <param name="cookieContainer">The <see cref="T:System.Net.CookieContainer" /> for the requests.</param>
	/// <exception cref="T:System.ArgumentNullException">
	/// - <paramref name="clientSettings" />
	/// - <paramref name="counterRegistry" />
	/// </exception>
	public AuthenticationV2HttpClientBuilder(ISettings clientSettings, ICounterRegistry counterRegistry, CookieContainer cookieContainer = null)
		: base(cookieContainer, clientSettings)
	{
		if (clientSettings == null)
		{
			throw new ArgumentNullException("clientSettings");
		}
		if (counterRegistry == null)
		{
			throw new ArgumentNullException("counterRegistry");
		}
		if (string.IsNullOrWhiteSpace(clientSettings.ClientName))
		{
			throw new ArgumentException(string.Format("{0}.{1} value has to be a non-empty string.", "clientSettings", "ClientName"), "clientSettings");
		}
		AppendHandler(new RequestFailureThrowsHandler());
		HttpRequestMetricsHandler httpRequestMetricsHandler = new HttpRequestMetricsHandler(counterRegistry, "Roblox.ApiClient", clientSettings.ClientName);
		AddHandlerBefore<SendHttpRequestHandler>(httpRequestMetricsHandler);
		DefaultCircuitBreakerPolicy<IExecutionContext<IHttpRequest, IHttpResponse>> circuitBreakerPolicy = new DefaultCircuitBreakerPolicy<IExecutionContext<IHttpRequest, IHttpResponse>>(string.Format("{0}.{1}", "Roblox.GuardedApiClientV2", clientSettings.ClientName), clientSettings, new DefaultTripReasonAuthority());
		new CircuitBreakerPolicyMetricsEventHandler(counterRegistry).RegisterEvents(circuitBreakerPolicy, "Roblox.GuardedApiClientV2", clientSettings.ClientName);
		AddHandlerAfter<RequestFailureThrowsHandler>(new CircuitBreakerHandler(circuitBreakerPolicy));
	}
}
