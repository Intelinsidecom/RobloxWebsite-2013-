namespace Roblox.Caching;

public interface IMigrationCacheabilitySettings
{
	string MigrationMemcachedGroupName { get; }

	MigrationStateChange MigrationStateChange { get; }
}
