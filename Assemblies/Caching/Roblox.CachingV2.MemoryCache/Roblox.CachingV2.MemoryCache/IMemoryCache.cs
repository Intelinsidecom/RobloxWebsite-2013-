using System;
using System.Runtime.Caching;
using Roblox.CachingV2.Core;

namespace Roblox.CachingV2.MemoryCache;

public interface IMemoryCache : IRawCache
{
	long CacheMemoryLimit { get; }

	DefaultCacheCapabilities DefaultCacheCapabilities { get; }

	string Name { get; }

	long PhysicalMemoryLimit { get; }

	TimeSpan PollingInterval { get; }
}
