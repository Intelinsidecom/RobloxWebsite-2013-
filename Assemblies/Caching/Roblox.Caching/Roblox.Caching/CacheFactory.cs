using Roblox.Caching.DotNet;
using Roblox.Caching.MemCached;
using Roblox.Instrumentation;

namespace Roblox.Caching;

internal class CacheFactory
{
	private static readonly LocalCache _LocalCache = new DotNetCoreCache(StaticCounterRegistry.Instance, replicate: true);

	private static readonly LocalBackedByMemcache _LocalBackedBySharedCache = new LocalBackedByMemcache();

	public static RobloxCache GetCacheForEntity(ICacheInfo cacheInfo)
	{
		IEntityRampUpAuthority instance = EntityRampUpAuthority.GetInstance();
		if (instance != null && instance.IsRemoteCacheable(cacheInfo.EntityType))
		{
			return _LocalBackedBySharedCache;
		}
		return _LocalCache;
	}

	public static LocalCache GetLocalCache()
	{
		return _LocalCache;
	}
}
