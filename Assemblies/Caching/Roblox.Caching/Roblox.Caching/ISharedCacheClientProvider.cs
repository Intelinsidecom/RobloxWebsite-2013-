using Roblox.Caching.Shared;

namespace Roblox.Caching;

public interface ISharedCacheClientProvider
{
	ISharedCacheClient GetCacheClientForEntity(ICacheInfo entityCacheInfo);

	ISharedCacheClient GetCacheClientForSettings(IRemoteCachabilitySettings settings);

	ISharedCacheClient GetCacheClientForSettings(IRemoteCachabilitySettings remoteCachabilitySettings, IMigrationCacheabilitySettings migrationCachabilitySettings, string metricsIdentifier);
}
