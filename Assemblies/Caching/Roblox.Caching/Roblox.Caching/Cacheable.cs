using Roblox.Caching.Interfaces;

namespace Roblox.Caching;

public static class Cacheable
{
	public static string GetKey<T>(this ICacheableObject<T> self)
	{
		return BuildEntityKey(self.CacheInfo, self.ID.ToString());
	}

	public static string BuildCountKey(ICacheInfo cacheInfo, string countId)
	{
		return $"rbx.{cacheInfo.EntityType}Count_{countId}";
	}

	public static string BuildEntityKey(ICacheInfo cacheInfo, object entityId)
	{
		return $"rbx.{cacheInfo.EntityType}_{entityId}";
	}

	public static string BuildEntityIDCollectionKey(ICacheInfo cacheInfo, string collectionId)
	{
		return $"rbx.{cacheInfo.EntityType}IDCollection_{collectionId}";
	}

	public static string BuildEntityIDLookupKey(ICacheInfo cacheInfo, object lookUp)
	{
		string text = lookUp.ToString();
		string arg = (cacheInfo.Cacheability.IDLookupsAreCaseSensitive ? text : text.ToLower());
		return $"rbx.{cacheInfo.EntityType}.ID.Lookup_{arg}";
	}

	public static string BuildStateTokenKey(ICacheInfo cacheInfo, CacheManager.CacheScopeFilter collectionScope, string qualifier)
	{
		string text = $"rbx.{cacheInfo.EntityType}StateToken_{collectionScope}";
		if (collectionScope == CacheManager.CacheScopeFilter.Qualified)
		{
			text = text + "_" + qualifier;
		}
		return text;
	}
}
