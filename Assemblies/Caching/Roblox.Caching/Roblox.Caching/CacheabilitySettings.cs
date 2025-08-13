namespace Roblox.Caching;

public struct CacheabilitySettings
{
	public bool CollectionsAreCacheable;

	public bool CountsAreCacheable;

	public bool EntityIsCacheable;

	public bool IDLookupsAreCacheable;

	public bool IsNullCacheable;

	public bool HasUnqualifiedCollections;

	public bool IDLookupsAreCaseSensitive;

	public CacheabilitySettings(bool collectionsAreCacheable, bool countsAreCacheable, bool entityIsCacheable, bool idLookupsAreCacheable, bool hasUnqualifiedCollections = true, bool idLookupsAreCaseSensitive = false)
	{
		IsNullCacheable = false;
		CollectionsAreCacheable = collectionsAreCacheable;
		CountsAreCacheable = countsAreCacheable;
		EntityIsCacheable = entityIsCacheable;
		IDLookupsAreCacheable = idLookupsAreCacheable;
		HasUnqualifiedCollections = (collectionsAreCacheable || countsAreCacheable) && hasUnqualifiedCollections;
		IDLookupsAreCaseSensitive = idLookupsAreCaseSensitive;
	}
}
