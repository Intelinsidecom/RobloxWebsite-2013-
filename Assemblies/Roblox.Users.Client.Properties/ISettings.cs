using System;

namespace Roblox.Users.Client.Properties;

public interface ISettings
{
    // Service client identity
    string Endpoint { get; }

    string ClientName { get; }

    // HTTP client defaults
    string UserAgent { get; }

    int MaxRedirects { get; }

    // Circuit breaker / retry defaults
    TimeSpan RequestTimeout { get; }

    TimeSpan RetryInterval { get; }

    int FailuresAllowedBeforeTrip { get; }

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
