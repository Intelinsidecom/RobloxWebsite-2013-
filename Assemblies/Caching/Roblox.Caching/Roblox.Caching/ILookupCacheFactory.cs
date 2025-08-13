namespace Roblox.Caching;

public interface ILookupCacheFactory
{
	ILookupCache GetLookupCache(ICacheInfo cacheInfo);
}
