using System;
using Roblox.Caching;
using Roblox.Caching.MemCached;
using Roblox.Caching.Shared;
using Roblox.Economy.Properties;
using Roblox.EventLog;

namespace Roblox.Economy;

internal class UpdateStatsRemoteLock : IDisposable
{
	private static ISharedCacheClientProvider _SharedCacheClientProvider = new SharedCacheClientProvider(StaticLoggerRegistry.Instance);

	private ICacheInfo _CacheInfo;

	private long _AssetId;

	private const string _UpdateStatsLockKey = "AssetSalesHistory_UpdateStatsLock_";

	public bool IsLockAquired;

	private ISharedCacheClient _SharedCacheClient => _SharedCacheClientProvider.GetCacheClientForEntity(_CacheInfo);

	private static bool _IsUpdateStatsLockEnabled => Settings.Default.IsUpdateStatsLockEnabled;

	private static TimeSpan UpdateStatsLockTimespan => Settings.Default.UpdateStatsLockDuration;

	public UpdateStatsRemoteLock(ICacheInfo cacheInfo, long assetId)
	{
		_CacheInfo = cacheInfo ?? throw new ArgumentNullException("cacheInfo");
		_AssetId = assetId;
		IsLockAquired = GetUpdateStatsLock();
	}

	public void Dispose()
	{
		if (_IsUpdateStatsLockEnabled && IsLockAquired)
		{
			_SharedCacheClient.Delete(GetKey());
		}
	}

	private bool GetUpdateStatsLock()
	{
		if (!_IsUpdateStatsLockEnabled)
		{
			return true;
		}
		string key = GetKey();
		try
		{
			if (_SharedCacheClient.Query(key, out var _))
			{
				return false;
			}
			return _SharedCacheClient.Add(key, "", UpdateStatsLockTimespan);
		}
		catch (Exception)
		{
			return false;
		}
	}

	private string GetKey()
	{
		return "AssetSalesHistory_UpdateStatsLock_" + _AssetId;
	}
}
