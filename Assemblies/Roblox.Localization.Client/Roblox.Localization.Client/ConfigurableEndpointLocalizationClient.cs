using System;
using System.Net;
using Roblox.Http.Client;
using Roblox.Http.ServiceClient;
using Roblox.Instrumentation;
using Roblox.Localization.Client.Implementation;
using Roblox.Localization.Client.Properties;
using Roblox.RequestContext;

namespace Roblox.Localization.Client;

public class ConfigurableEndpointLocalizationClient : LocalizationClient
{
	public ConfigurableEndpointLocalizationClient(ICounterRegistry counterRegistry, Func<string> apiKeyGetter, string endpoint, IRequestContextLoader requestContextLoader = null)
		: base(CreateHttpClientBuilder(counterRegistry, apiKeyGetter, requestContextLoader), new ConfigurableEndpointServiceClientSettings(endpoint))
	{
	}

	private static ClientCircuitBreakerType GetClientCircuitBreakerType()
	{
		if (!Settings.Default.PerEndpointCircuitBreakerEnabled)
		{
			return (ClientCircuitBreakerType)1;
		}
		return (ClientCircuitBreakerType)2;
	}

	private static bool ApiKeyViaHeaderEnabled()
	{
		return Settings.Default.ApiKeyViaHeaderEnabled;
	}

	private static IHttpClientBuilder CreateHttpClientBuilder(ICounterRegistry counterRegistry, Func<string> apiKeyGetter, IRequestContextLoader requestContextLoader)
	{
		return new Roblox.Http.ServiceClient.HttpClientBuilder((IServiceClientSettings)Settings.Default, counterRegistry, apiKeyGetter, (Func<bool>)null, (CookieContainer)null, requestContextLoader, (IHttpMessageHandlerBuilder)null, (CircuitBreakerMode)0)
		{
			ApiKeyViaHeaderEnabled = ApiKeyViaHeaderEnabled,
			GetClientCircuitBreakerType = GetClientCircuitBreakerType
		};
	}
}
