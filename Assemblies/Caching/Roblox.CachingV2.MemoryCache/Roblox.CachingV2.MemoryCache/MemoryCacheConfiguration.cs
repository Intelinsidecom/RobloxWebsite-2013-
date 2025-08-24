using System;

namespace Roblox.CachingV2.MemoryCache;

public class MemoryCacheConfiguration
{
	public int CacheMemoryLimit { get; }

	public long PhysicalMemoryLimit { get; }

	public TimeSpan PollingInterval { get; }

	public TimeSpan DefaultSlidingExpiration { get; set; }

	public MemoryCacheConfiguration(int? cacheMemoryLimit = null, long? physicalMemoryLimit = null, TimeSpan? pollingInterval = null, TimeSpan? defaultSlidingExpiration = null)
	{
		CacheMemoryLimit = cacheMemoryLimit ?? 0;
		PhysicalMemoryLimit = physicalMemoryLimit ?? 0;
		PollingInterval = pollingInterval ?? TimeSpan.FromMinutes(2.0);
		DefaultSlidingExpiration = defaultSlidingExpiration ?? TimeSpan.FromMinutes(15.0);
	}
}
