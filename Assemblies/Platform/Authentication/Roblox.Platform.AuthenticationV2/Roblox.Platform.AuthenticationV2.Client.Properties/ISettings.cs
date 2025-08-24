using Roblox.Http.Client;
using Roblox.Sentinels.CircuitBreakerPolicy;

namespace Roblox.AuthenticationV2.Client.Properties;

/// <summary>
/// Settings specific to an <see cref="T:Roblox.Http.Client.IHttpClient" /> used for the AuthenticationV2 Service.
/// </summary>
public interface ISettings : IHttpClientSettings, IDefaultCircuitBreakerPolicyConfig
{
	/// <summary>
	/// The url base for the infrastructure service.
	/// </summary>
	/// <remarks>
	/// Due to the way this value is used, anything after the FQDN will be dropped.
	/// E.g. http://example.com/route will simply drop the /route portion.
	///
	/// This is important because the Authentication service is behind Traefik and does not have a unique FQDN.
	/// The full route must be specified in the client.
	/// </remarks>
	string Endpoint { get; }

	/// <summary>
	/// The client name.
	/// </summary>
	/// <remarks>
	/// This value is used primarily for circuit breaking and performance counters.
	/// It should be entirely alphanumeric.
	/// </remarks>
	string ClientName { get; }
}
