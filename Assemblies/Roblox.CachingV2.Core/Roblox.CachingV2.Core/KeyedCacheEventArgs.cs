using System;

namespace Roblox.CachingV2.Core;

public abstract class KeyedCacheEventArgs : CacheEventArgs
{
	public string Key { get; }

	protected KeyedCacheEventArgs(string key)
	{
		Key = key ?? throw new ArgumentNullException("key");
	}
}
