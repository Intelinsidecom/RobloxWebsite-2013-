using Roblox.Caching.Shared;

namespace Roblox.Caching;

internal interface IRolloutPerThousandSharedCacheClientProvider
{
	ISharedCacheClient GetCacheClientForMigrationStateChange(MigrationStateChange migrationStateChange, ISharedCacheClient sourceCacheClient, ISharedCacheClient destinationCacheClient);
}
