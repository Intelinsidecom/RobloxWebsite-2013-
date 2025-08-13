using System;
using Roblox.Caching.Interfaces;
using Roblox.Caching.MemCached;
using Roblox.Configuration;

namespace Roblox.Caching.Diagnostics;

public class CacheListenerInitializer
{
	private bool _IsRegistered;

	private readonly object _Lock = new object();

	private readonly IRobloxCacheListener _CacheListener;

	private readonly ISingleSetting<bool> _IsListeningSetting;

	private readonly MemcachedCache _MemcachedCache;

	public CacheListenerInitializer(ISingleSetting<bool> isListeningSetting, IRobloxCacheListener cacheListener)
	{
		_CacheListener = cacheListener ?? throw new ArgumentNullException("cacheListener");
		_IsListeningSetting = isListeningSetting ?? throw new ArgumentNullException("isListeningSetting");
		_MemcachedCache = MemcachedCache.GetInstance();
		isListeningSetting.PropertyChanged += delegate
		{
			HandleListenerRegistration();
		};
		HandleListenerRegistration();
	}

	private void HandleListenerRegistration()
	{
		lock (_Lock)
		{
			bool value = _IsListeningSetting.Value;
			if (value && !_IsRegistered)
			{
				_IsRegistered = true;
				_MemcachedCache.AddRobloxCacheListener(_CacheListener);
			}
			else if (!value && _IsRegistered)
			{
				_IsRegistered = false;
				_MemcachedCache.RemoveRobloxCacheListener(_CacheListener);
			}
		}
	}
}
