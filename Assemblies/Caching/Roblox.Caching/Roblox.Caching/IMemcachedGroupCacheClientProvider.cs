using Roblox.Caching.Shared;

namespace Roblox.Caching;

public interface IMemcachedGroupCacheClientProvider
{
	ISharedCacheClient GetCacheClientForGroup(string name);
}
