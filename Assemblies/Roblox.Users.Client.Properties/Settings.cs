using System;

namespace Roblox.Users.Client.Properties;

internal sealed class Settings : ISettings
{
    public static Settings Default { get; } = new Settings();

    private Settings() { }

    // Service client identity
    public string Endpoint => "https://users.roblox.com";
    public string ClientName => "Users";

    // HTTP client defaults
    public string UserAgent => "Roblox.Users.Client.Properties/1.0";
    public int MaxRedirects => 10;

    // Circuit breaker / retry defaults
    public TimeSpan RequestTimeout => TimeSpan.FromMilliseconds(500);
    public TimeSpan RetryInterval => TimeSpan.FromMilliseconds(250);
    public int FailuresAllowedBeforeTrip => 5;

    // Cache settings
    public TimeSpan AgentLocalCacheExpiry => TimeSpan.FromMinutes(15);
    public TimeSpan UserLocalCacheExpiry => TimeSpan.FromMinutes(5);
    public TimeSpan UsernameHistoryCacheExpiry => TimeSpan.FromMinutes(10);
    public TimeSpan GetRecentlyUpdatedUsersInterval => TimeSpan.FromSeconds(1);
    public TimeSpan UserLocalCachePurgeLeeway => TimeSpan.FromSeconds(15);
    public int MaxCheckFailuresBeforeClearLocalCache => 5;
    public bool UsersClientLocalCacheEnabled => false;
    public bool PerEndpointCircuitBreakerEnabled => false;
    public bool ApiKeyViaHeaderEnabled => false;
    public TimeSpan UserCreatedCacheThreshold => TimeSpan.FromSeconds(45);
    public int DatabaseMaxUsernameLength => 64;
    public TimeSpan DisplayNameHistoryCacheExpiry => TimeSpan.FromMinutes(10);
}
