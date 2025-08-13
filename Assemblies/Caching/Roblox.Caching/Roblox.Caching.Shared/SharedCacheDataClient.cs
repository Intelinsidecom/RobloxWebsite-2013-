using System;
using System.Threading.Tasks;
using Roblox.Caching.MemCached;
using Roblox.Caching.Properties;
using Roblox.Configuration;
using Roblox.EventLog;

namespace Roblox.Caching.Shared;

internal class SharedCacheDataClient : SharedCacheClient
{
	private static readonly ILogger _Logger;

	private static readonly IMigrationCacheabilitySettings _MigrationCacheabilitySettings;

	private static readonly object _ClientLock;

	private static readonly DynamicSharedCacheClient _SharedCacheDataClient;

	private static ISharedCacheClient _RawClient;

	private static string _LastSharedCacheAddresses;

	private static string _LastSharedCacheKeyPrefix;

	static SharedCacheDataClient()
	{
		_Logger = StaticLoggerRegistry.Instance;
		_MigrationCacheabilitySettings = new MigrationCacheabilitySettings(Settings.Default.ToSingleSetting((Settings s) => s.MemcachedObjectMigrationCacheGroupName), Settings.Default.ToSingleSetting((Settings s) => s.MemcachedObjectMigrationState));
		_ClientLock = new object();
		_SharedCacheDataClient = new DynamicSharedCacheClient(ConfigureRawClientAndProvider(Settings.Default.SharedCacheAddresses).Provider, null, _MigrationCacheabilitySettings, "MemcachedObject");
		Settings.Default.MonitorChanges((Settings s) => s.SharedCacheAddresses, delegate(string value)
		{
			var (flag, sharedCacheClientProvider) = ConfigureRawClientAndProvider(value);
			if (flag)
			{
				_SharedCacheDataClient.SetSharedCacheClientProvider(sharedCacheClientProvider);
			}
		});
		Settings.Default.ReadValueAndMonitorChanges((Settings s) => s.SharedCacheKeyPrefix, delegate(string value)
		{
			if (value != _LastSharedCacheKeyPrefix)
			{
				if (_LastSharedCacheKeyPrefix != null)
				{
					EntityRampUpAuthority.GetInstance()?.TouchRampUp();
				}
				_LastSharedCacheKeyPrefix = value;
			}
		});
	}

	internal SharedCacheDataClient(string[] addresses, ILogger logger)
	{
		CreateMemcachedClient(addresses, "Roblox MemcacheD", logger);
	}

	public static ISharedCacheClient GetSingleton()
	{
		return _SharedCacheDataClient;
	}

	private static (bool Changed, ISharedCacheClientProvider Provider) ConfigureRawClientAndProvider(string addresses)
	{
		ISharedCacheClient oldClient;
		lock (_ClientLock)
		{
			if (addresses == _LastSharedCacheAddresses)
			{
				return (false, null);
			}
			oldClient = _RawClient;
			_RawClient = new SharedCacheDataClient(SharedCacheClient.GetCacheAddressesFromSetting(addresses), _Logger);
			_LastSharedCacheAddresses = addresses;
		}
		if (oldClient != null)
		{
			Task.Delay(Settings.Default.DelayBeforeDisposingMemcachedObjectClientOnAddressesChange).ContinueWith(delegate
			{
				try
				{
					oldClient.Dispose();
				}
				catch (Exception ex)
				{
					_Logger.Error(ex);
				}
			});
		}
		SharedCacheClientProvider item = new SharedCacheClientProvider(_RawClient, _Logger);
		return (true, item);
	}
}
