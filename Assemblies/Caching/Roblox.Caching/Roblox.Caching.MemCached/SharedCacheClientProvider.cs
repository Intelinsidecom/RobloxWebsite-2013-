using System;
using Roblox.Caching.Diagnostics;
using Roblox.Caching.Properties;
using Roblox.Caching.Shared;
using Roblox.EventLog;
using Roblox.Instrumentation;

namespace Roblox.Caching.MemCached;

public class SharedCacheClientProvider : ISharedCacheClientProvider
{
	private readonly IMemcachedGroupCacheClientProvider _MemcachedGroupCacheClientProvider;

	private readonly IRolloutPerThousandSharedCacheClientProvider _RolloutPerThousandSharedCacheClientProvider;

	private readonly ISharedCacheClient _DefaultCacheClient;

	private readonly ISettings _Settings;

	private readonly ILogger _Logger;

	private readonly IMigrationStateMonitor _MigrationStateMonitor;

	public SharedCacheClientProvider(ILogger logger)
		: this(SharedCacheDataClient.GetSingleton(), new MigrationStateMonitor(StaticCounterRegistry.Instance), logger)
	{
	}

	public SharedCacheClientProvider(ISharedCacheClient fallbackCache, IMigrationStateMonitor migrationStateMonitor, ILogger logger)
		: this(Settings.Default, fallbackCache, MemcachedGroupCacheClientProvider<MemcachedGroupsSettings>.Instance, new RolloutPerThousandSharedCacheClientProvider(new MigrationSharedCacheClientProvider(Settings.Default, logger)), migrationStateMonitor, logger)
	{
	}

	public SharedCacheClientProvider(ISharedCacheClient fallbackCache, ILogger logger)
		: this(Settings.Default, fallbackCache, MemcachedGroupCacheClientProvider<MemcachedGroupsSettings>.Instance, new RolloutPerThousandSharedCacheClientProvider(new MigrationSharedCacheClientProvider(Settings.Default, logger)), new MigrationStateMonitor(StaticCounterRegistry.Instance), logger)
	{
	}

	internal SharedCacheClientProvider(ISettings settings, ISharedCacheClient fallbackCache, IMemcachedGroupCacheClientProvider memcachedGroupCacheClientProvider, IRolloutPerThousandSharedCacheClientProvider rolloutPerThousandSharedCacheClientProvider, IMigrationStateMonitor migrationStateMonitor, ILogger logger)
	{
		_Settings = settings ?? throw new ArgumentNullException("settings");
		_DefaultCacheClient = fallbackCache ?? throw new ArgumentNullException("fallbackCache");
		_MemcachedGroupCacheClientProvider = memcachedGroupCacheClientProvider ?? throw new ArgumentNullException("memcachedGroupCacheClientProvider");
		_RolloutPerThousandSharedCacheClientProvider = rolloutPerThousandSharedCacheClientProvider ?? throw new ArgumentNullException("rolloutPerThousandSharedCacheClientProvider");
		_MigrationStateMonitor = migrationStateMonitor ?? throw new ArgumentNullException("migrationStateMonitor");
		_Logger = logger ?? throw new ArgumentNullException("logger");
	}

	public ISharedCacheClient GetCacheClientForEntity(ICacheInfo entityCacheInfo)
	{
		if (entityCacheInfo == null)
		{
			throw new ArgumentNullException("entityCacheInfo");
		}
		return GetCacheClientForSettings(entityCacheInfo.RemoteCachabilitySettings, entityCacheInfo.MigrationCacheabilitySettings, entityCacheInfo.EntityType);
	}

	public ISharedCacheClient GetCacheClientForSettings(IRemoteCachabilitySettings remoteCachabilitySettings, IMigrationCacheabilitySettings migrationCacheabilitySettings, string metricsIdentifier)
	{
		if (string.IsNullOrWhiteSpace(metricsIdentifier))
		{
			throw new ArgumentException("metricsIdentifier");
		}
		if (!string.IsNullOrWhiteSpace(migrationCacheabilitySettings?.MigrationMemcachedGroupName) && !(migrationCacheabilitySettings.MigrationStateChange == null))
		{
			MigrationStateChange migrationStateChange = migrationCacheabilitySettings.MigrationStateChange;
			if ((object)migrationStateChange == null || migrationStateChange.SourceState != 0 || !migrationCacheabilitySettings.MigrationStateChange.IsSourceAndDestinationStateSame)
			{
				MigrationStateChange migrationStateChange2 = migrationCacheabilitySettings.MigrationStateChange;
				ISharedCacheClient sharedCacheClient = ResolveMemcachedGroupNameToCache(migrationCacheabilitySettings.MigrationMemcachedGroupName);
				if (migrationStateChange2.SourceState == MigrationState.MigrationComplete && migrationStateChange2.IsSourceAndDestinationStateSame)
				{
					return sharedCacheClient;
				}
				ISharedCacheClient cacheClientForSettings = GetCacheClientForSettings(remoteCachabilitySettings);
				if ((migrationStateChange2.SourceState != 0 || migrationStateChange2.DestinationState != 0) && string.IsNullOrWhiteSpace(migrationCacheabilitySettings.MigrationMemcachedGroupName))
				{
					if (_Settings.IsLoggingMigrationConfigurationErrorsEnabled)
					{
						_Logger.Error($"MetricsIdentifier = {metricsIdentifier}: MigrationCacheabilitySettings.MigrationStateChange was set to {migrationStateChange2} for group name {remoteCachabilitySettings.MemcachedGroupName} but MigrationCacheabilitySettings.MigrationMemcachedGroupName was null or whitespace.");
					}
					return cacheClientForSettings;
				}
				if (cacheClientForSettings == sharedCacheClient)
				{
					return cacheClientForSettings;
				}
				_MigrationStateMonitor.RecordMigrationState(metricsIdentifier, migrationStateChange2);
				return _RolloutPerThousandSharedCacheClientProvider.GetCacheClientForMigrationStateChange(migrationStateChange2, cacheClientForSettings, sharedCacheClient);
			}
		}
		return GetCacheClientForSettings(remoteCachabilitySettings);
	}

	public ISharedCacheClient GetCacheClientForSettings(IRemoteCachabilitySettings settings)
	{
		if (settings == null)
		{
			return _DefaultCacheClient;
		}
		string memcachedGroupName = settings.MemcachedGroupName;
		return ResolveMemcachedGroupNameToCache(memcachedGroupName);
	}

	private ISharedCacheClient ResolveMemcachedGroupNameToCache(string name)
	{
		if (string.IsNullOrWhiteSpace(name))
		{
			return _DefaultCacheClient;
		}
		ISharedCacheClient cacheClientForGroup = _MemcachedGroupCacheClientProvider.GetCacheClientForGroup(name);
		if (cacheClientForGroup != null)
		{
			return cacheClientForGroup;
		}
		return _DefaultCacheClient;
	}
}
