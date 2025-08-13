using System;
using System.ComponentModel;
using Roblox.Http.Client;
using Roblox.Http.ServiceClient;
using Roblox.Sentinels.CircuitBreakerPolicy;

namespace Roblox.Users.Client.Properties;

public interface ISettings : IServiceClientSettings, IHttpClientSettings, IDefaultCircuitBreakerPolicyConfig, INotifyPropertyChanged
{
	TimeSpan AgentLocalCacheExpiry { get; }

	TimeSpan UserLocalCacheExpiry { get; }

	TimeSpan UsernameHistoryCacheExpiry { get; }

	TimeSpan GetRecentlyUpdatedUsersInterval { get; }

	TimeSpan UserLocalCachePurgeLeeway { get; }

	int MaxCheckFailuresBeforeClearLocalCache { get; }

	bool UsersClientLocalCacheEnabled { get; }

	bool PerEndpointCircuitBreakerEnabled { get; }

	bool ApiKeyViaHeaderEnabled { get; }

	TimeSpan UserCreatedCacheThreshold { get; }

	int DatabaseMaxUsernameLength { get; }

	TimeSpan DisplayNameHistoryCacheExpiry { get; }
}
