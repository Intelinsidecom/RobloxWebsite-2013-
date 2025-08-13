using Roblox.Caching.Interfaces;
using Roblox.Caching.Shared;

namespace Roblox.Caching;

internal interface IEntitySerializer
{
	byte[] Serialize<TEntity>(TEntity entity) where TEntity : ICacheableObject;

	(bool Success, TEntity Entity) TryDeserializeFromRemoteCache<TEntity>(ISharedCacheClient sharedCacheClient, byte[] value, string key) where TEntity : ICacheableObject;
}
