using System;
using Roblox.Configuration;
using Roblox.GameInstances.Client.Properties;
using Roblox.Http.Client;
using Roblox.Http.ServiceClient;
using Roblox.Sentinels.CircuitBreakerPolicy;

namespace Roblox.GameInstances.Client;

public class GameInstancesClientSettings : DefaultHttpClientSettings, IServiceClientSettings, IHttpClientSettings, IDefaultCircuitBreakerPolicyConfig
{
	private readonly Func<string> _GameInstancesServiceUrl;

	public string Endpoint => _GameInstancesServiceUrl();

	public string ClientName => "GameInstancesClient";

	public TimeSpan RetryInterval => Settings.Default.RetryInterval;

	public int FailuresAllowedBeforeTrip => Settings.Default.FailuresAllowedBeforeCircuitBreakerTrip;

	TimeSpan IHttpClientSettings.RequestTimeout => Settings.Default.GameInstancesServiceTimeout;

	public GameInstancesClientSettings(Func<string> serviceUrlGetter = null)
	{
		_GameInstancesServiceUrl = serviceUrlGetter ?? ((Func<string>)(() => RobloxEnvironment.GetApiEndpoint("gameinstances")));
	}
}
