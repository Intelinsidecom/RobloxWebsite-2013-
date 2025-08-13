using System;
using Roblox.Http.Client;
using Roblox.Http.ServiceClient;
using Roblox.Localization.Client.Properties;
using Roblox.Sentinels.CircuitBreakerPolicy;

namespace Roblox.Localization.Client.Implementation;

internal class ConfigurableEndpointServiceClientSettings : IServiceClientSettings, IHttpClientSettings, IDefaultCircuitBreakerPolicyConfig
{
	public string UserAgent => Settings.Default.UserAgent;

	public int MaxRedirects => Settings.Default.MaxRedirects;

	public TimeSpan RequestTimeout => Settings.Default.RequestTimeout;

	public TimeSpan RetryInterval => Settings.Default.RetryInterval;

	public int FailuresAllowedBeforeTrip => Settings.Default.FailuresAllowedBeforeTrip;

	public string Endpoint { get; }

	public string ClientName => Settings.Default.ClientName;

	public event Action<string> SettingChanged;

	public ConfigurableEndpointServiceClientSettings(string endpoint)
	{
		Endpoint = endpoint ?? throw new ArgumentNullException("endpoint");
	}
}
