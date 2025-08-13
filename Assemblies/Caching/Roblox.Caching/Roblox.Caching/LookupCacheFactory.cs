using System;
using System.Diagnostics.CodeAnalysis;
using Roblox.Caching.MemCached;
using Roblox.Caching.Properties;
using Roblox.Caching.Shared;
using Roblox.EventLog;
using Roblox.Instrumentation;

namespace Roblox.Caching;

public class LookupCacheFactory : ILookupCacheFactory
{
	private const string _DefaultMemcachedCacheName = "Default";

	private readonly ISettings _Settings;

	private readonly ILogger _Logger;

	private readonly ISharedCacheClientProvider _CacheClientProvider;

	private readonly ICounterRegistry _CounterRegistry;

	private static readonly object _InstanceLock = new object();

	private static LookupCacheFactory _Instance;

	public static ILookupCacheFactory Instance;

	public static ILookupCacheFactory GetInstance()
	{
		if (_Instance == null)
		{
			lock (_InstanceLock)
			{
				if (_Instance == null)
				{
					ILogger instance = StaticLoggerRegistry.Instance;
					_Instance = new LookupCacheFactory(Settings.Default, instance, new SharedCacheClientProvider(instance), StaticCounterRegistry.Instance);
				}
			}
		}
		return _Instance;
	}

	internal LookupCacheFactory(ISettings settings, ILogger logger, ISharedCacheClientProvider cacheClientProvider, ICounterRegistry counterRegistry)
	{
		_Settings = settings ?? throw new ArgumentNullException("settings");
		_Logger = logger ?? throw new ArgumentNullException("logger");
		_CacheClientProvider = cacheClientProvider ?? throw new ArgumentNullException("cacheClientProvider");
		_CounterRegistry = counterRegistry ?? throw new ArgumentNullException("counterRegistry");
	}

	public ILookupCache GetLookupCache(ICacheInfo cacheInfo)
	{
		if (cacheInfo == null)
		{
			throw new ArgumentNullException("cacheInfo");
		}
		ISharedCacheClient cacheClientForEntity = _CacheClientProvider.GetCacheClientForEntity(cacheInfo);
		string memcachedGroupNameOrDefault = GetMemcachedGroupNameOrDefault(cacheInfo.RemoteCachabilitySettings?.MemcachedGroupName);
		return CreateMemcachedLookupCache(cacheClientForEntity, memcachedGroupNameOrDefault);
	}

	[ExcludeFromCodeCoverage]
	internal virtual ILookupCache CreateMemcachedLookupCache(ISharedCacheClient cacheClient, string name)
	{
		return new MemcachedLookupCache(_Settings, _Logger, cacheClient, _CounterRegistry, name);
	}

	private string GetMemcachedGroupNameOrDefault(string name)
	{
		if (string.IsNullOrEmpty(name))
		{
			return "Default";
		}
		return name;
	}
}
