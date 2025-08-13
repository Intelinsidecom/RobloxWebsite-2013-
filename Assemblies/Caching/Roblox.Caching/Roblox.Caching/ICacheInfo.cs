namespace Roblox.Caching;

public interface ICacheInfo
{
	CacheabilitySettings Cacheability { get; }

	IRemoteCachabilitySettings RemoteCachabilitySettings { get; }

	IMigrationCacheabilitySettings MigrationCacheabilitySettings { get; }

	string EntityType { get; }

	bool IsNullCacheable { get; }
}
