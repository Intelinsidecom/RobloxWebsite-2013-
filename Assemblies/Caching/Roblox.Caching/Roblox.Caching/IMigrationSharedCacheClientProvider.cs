using Roblox.Caching.Shared;

namespace Roblox.Caching;

internal interface IMigrationSharedCacheClientProvider
{
	ISharedCacheClient GetMigrationCacheClientForMigrationState(MigrationState migrationState, ISharedCacheClient sourceCacheClient, ISharedCacheClient destinationSharedCacheClient);
}
