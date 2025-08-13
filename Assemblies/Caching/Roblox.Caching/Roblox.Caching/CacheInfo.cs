using System;

namespace Roblox.Caching;

public class CacheInfo : ICacheInfo
{
	private static readonly CacheabilitySettings _DefaultCacheabilitySettings = new CacheabilitySettings(collectionsAreCacheable: true, countsAreCacheable: true, entityIsCacheable: true, idLookupsAreCacheable: true);

	public CacheabilitySettings Cacheability { get; }

	public IRemoteCachabilitySettings RemoteCachabilitySettings { get; }

	public IMigrationCacheabilitySettings MigrationCacheabilitySettings { get; }

	public string EntityType { get; }

	public bool IsNullCacheable => Cacheability.IsNullCacheable;

	public CacheInfo(CacheabilitySettings cacheability, string entityType, bool isNullCacheable, string replicationPort = null, IRemoteCachabilitySettings remoteCachabilitySettings = null, IMigrationCacheabilitySettings migrationCacheabilitySettings = null)
	{
		cacheability.IsNullCacheable = isNullCacheable;
		Cacheability = cacheability;
		EntityType = entityType;
		RemoteCachabilitySettings = remoteCachabilitySettings;
		MigrationCacheabilitySettings = migrationCacheabilitySettings;
		EntityCacheInvalidator.AddReplicationPort(EntityType);
	}

	public CacheInfo(string entityType)
		: this(_DefaultCacheabilitySettings, entityType, isNullCacheable: false)
	{
	}

	public CacheInfo(CacheabilitySettings cacheability, Type entityType)
		: this(cacheability, entityType.ToString())
	{
	}

	public CacheInfo(CacheabilitySettings cacheability, string entityType)
		: this(cacheability, entityType, isNullCacheable: false)
	{
	}
}
