using Roblox.Http.Client;
using Roblox.Sentinels.CircuitBreakerPolicy;

namespace Roblox.Http.ServiceClient;

public interface IServiceClientSettings : IHttpClientSettings, IDefaultCircuitBreakerPolicyConfig
{
	string Endpoint { get; }

	string ClientName { get; }
}
