using System;
using System.Threading.Tasks;
using Roblox.Caching.MemCached;
using Roblox.Caching.Properties;
using Roblox.Configuration;
using Roblox.EventLog;

namespace Roblox.Caching.Shared;

public class SharedCacheWebClient : SharedCacheClient
{
	private static readonly ILogger _Logger;

	private static readonly IMigrationCacheabilitySettings _MigrationCacheabilitySettings;

	private static readonly object _ClientLock;

	private static readonly DynamicSharedCacheClient _SharedCacheWebClient;

	private static ISharedCacheClient _RawClient;

	private static string _LastAddresses;

	private const int _DelayBeforeDisposingClientOnAddressesChange = 1000;

	static SharedCacheWebClient()
	{
		_Logger = StaticLoggerRegistry.Instance;
		_MigrationCacheabilitySettings = new MigrationCacheabilitySettings(Settings.Default.ToSingleSetting((Settings s) => s.MemcachedWebMigrationCacheGroupName), Settings.Default.ToSingleSetting((Settings s) => s.MemcachedWebMigrationState));
		_ClientLock = new object();
		_SharedCacheWebClient = new DynamicSharedCacheClient(ConfigureRawClientAndProvider(Settings.Default.SharedCacheWebAddresses).Provider, null, _MigrationCacheabilitySettings, "MemcachedWeb");
		Settings.Default.MonitorChanges((Settings s) => s.SharedCacheWebAddresses, delegate(string value)
		{
			var (flag, sharedCacheClientProvider) = ConfigureRawClientAndProvider(value);
			if (flag)
			{
				_SharedCacheWebClient.SetSharedCacheClientProvider(sharedCacheClientProvider);
			}
		});
	}

	internal SharedCacheWebClient(string[] addresses, ILogger logger)
	{
		CreateMemcachedClient(addresses, "Roblox MemcacheD Web", logger);
	}

	public static ISharedCacheClient GetSingleton()
	{
		return _SharedCacheWebClient;
	}

	private static (bool Changed, ISharedCacheClientProvider Provider) ConfigureRawClientAndProvider(string addresses)
	{
		ISharedCacheClient oldClient;
		lock (_ClientLock)
		{
			if (addresses == _LastAddresses)
			{
				return (false, null);
			}
			oldClient = _RawClient;
			_RawClient = new SharedCacheWebClient(SharedCacheClient.GetCacheAddressesFromSetting(addresses), _Logger);
			_LastAddresses = addresses;
		}
		if (oldClient != null)
		{
			Task.Delay(1000).ContinueWith(delegate
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
