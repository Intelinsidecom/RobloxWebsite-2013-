using System;
using Roblox.Caching.Properties;
using Roblox.Caching.Shared;
using Roblox.EventLog;

namespace Roblox.Caching.MemCached;

internal class MigrationSharedCacheClientProvider : IMigrationSharedCacheClientProvider
{
	private readonly ILogger _Logger;

	private readonly ISettings _Settings;

	public MigrationSharedCacheClientProvider(ISettings settings, ILogger logger)
	{
		_Logger = logger ?? throw new ArgumentNullException("logger");
		_Settings = settings ?? throw new ArgumentNullException("settings");
	}

	public ISharedCacheClient GetMigrationCacheClientForMigrationState(MigrationState migrationState, ISharedCacheClient sourceCacheClient, ISharedCacheClient destinationSharedCacheClient)
	{
		if (!Enum.IsDefined(typeof(MigrationState), migrationState))
		{
			throw new ArgumentException($"MigrationState was invalid. Value was {migrationState}");
		}
		if (sourceCacheClient == null)
		{
			throw new ArgumentNullException("sourceCacheClient");
		}
		if (destinationSharedCacheClient == null)
		{
			throw new ArgumentNullException("destinationSharedCacheClient");
		}
		switch (migrationState)
		{
		case MigrationState.NoMigration:
			return sourceCacheClient;
		case MigrationState.ReadWriteSourceDeleteOnlyDestination:
			return GetReadFirstWriteBothCache(sourceCacheClient, destinationSharedCacheClient, onlyDeleteFromWriteCache: true, readAndDiscardInBackgroundFromWriteCache: false);
		case MigrationState.ReadWriteSourceWriteOnlyDestination:
			return GetReadFirstWriteBothCache(sourceCacheClient, destinationSharedCacheClient, onlyDeleteFromWriteCache: false, readAndDiscardInBackgroundFromWriteCache: false);
		case MigrationState.ReadWriteSourceReadDiscardAndWriteDestination:
			return GetReadFirstWriteBothCache(sourceCacheClient, destinationSharedCacheClient, onlyDeleteFromWriteCache: false, readAndDiscardInBackgroundFromWriteCache: true);
		case MigrationState.WriteOnlySourceReadWriteDestination:
			return GetReadFirstWriteBothCache(destinationSharedCacheClient, sourceCacheClient, onlyDeleteFromWriteCache: false, readAndDiscardInBackgroundFromWriteCache: false);
		case MigrationState.DeleteOnlySourceReadWriteDestination:
			return GetReadFirstWriteBothCache(destinationSharedCacheClient, sourceCacheClient, onlyDeleteFromWriteCache: true, readAndDiscardInBackgroundFromWriteCache: false);
		case MigrationState.MigrationComplete:
			return destinationSharedCacheClient;
		default:
			if (_Settings.IsLoggingMigrationConfigurationErrorsEnabled)
			{
				_Logger.Error($"MigrationState is invalid. It's value is {migrationState}");
			}
			return sourceCacheClient;
		}
	}

	internal ISharedCacheClient GetReadFirstWriteBothCache(ISharedCacheClient readAndWriteCache, ISharedCacheClient writeCache, bool onlyDeleteFromWriteCache, bool readAndDiscardInBackgroundFromWriteCache)
	{
		if (readAndWriteCache == null)
		{
			throw new ArgumentNullException("readAndWriteCache");
		}
		if (writeCache == null)
		{
			throw new ArgumentNullException("writeCache");
		}
		if (readAndWriteCache == writeCache)
		{
			throw new ArgumentException(string.Format("Expected {0} != {1}", "readAndWriteCache", "writeCache"), "writeCache");
		}
		return new MigrationSharedCacheClient(readAndWriteCache, writeCache, onlyDeleteFromWriteCache, readAndDiscardInBackgroundFromWriteCache, _Settings, _Logger);
	}
}
