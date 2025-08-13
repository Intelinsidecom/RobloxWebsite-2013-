using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using Roblox.Caching.Shared;
using Roblox.CachingV2.Core;
using Roblox.CachingV2.Diagnostics;
using Roblox.CachingV2.MemoryCache;
using Roblox.EventLog;
using Roblox.Instrumentation;
using Roblox.Platform.StaticContent.Properties;

namespace Roblox.Platform.StaticContent;

/// <inheritdoc cref="T:Roblox.Platform.StaticContent.IStaticContentCache`1" />
internal class StaticContentCache<T> : IStaticContentCache<T>
{
	private const string _ExpirableStaticContentCacheName = "Roblox.Platform.StaticContent.StaticContentCache.Expirable";

	private readonly ICounterRegistry _CounterRegistry;

	private readonly ILogger _Logger;

	private readonly ISettings _Settings;

	private readonly ICache<BasicMetadata, BasicSetArgs> _ExpirableCache;

	private readonly ISharedCacheClient _DurableCache;

	private readonly ICacheOperationFactory _CacheOperationFactory;

	private readonly ISerializer _EntitySerializer;

	/// <summary>
	/// Initializes a new <see cref="T:Roblox.Platform.StaticContent.StaticContentCache`1" />.
	/// </summary>
	/// <param name="logger">An <see cref="T:Roblox.EventLog.ILogger" />.</param>
	/// <param name="durableCache">An <see cref="T:Roblox.Caching.Shared.ISharedCacheClient" />.</param>
	/// <param name="cacheOperationFactory">An <see cref="T:Roblox.CachingV2.Core.ICacheOperationFactory" />.</param>
	/// <param name="entitySerializer">An <see cref="T:Roblox.CachingV2.Core.ISerializer" />.</param>
	/// <exception cref="T:System.ArgumentNullException">
	/// - <paramref name="logger" />
	/// - <paramref name="durableCache" />
	/// - <paramref name="cacheOperationFactory" />
	/// - <paramref name="entitySerializer" />
	/// </exception>
	[ExcludeFromCodeCoverage]
	public StaticContentCache(ICounterRegistry counterRegistry, ILogger logger, ISharedCacheClient durableCache, ICacheOperationFactory cacheOperationFactory, ISerializer entitySerializer)
		: this(counterRegistry, logger, (ISettings)Settings.Default, CreateMemoryCache("Roblox.Platform.StaticContent.StaticContentCache.Expirable"), durableCache, cacheOperationFactory, entitySerializer)
	{
	}

	/// <summary>
	/// Initializes a new <see cref="T:Roblox.Platform.StaticContent.StaticContentCache`1" />.
	/// </summary>
	/// <param name="logger">An <see cref="T:Roblox.EventLog.ILogger" />.</param>
	/// <param name="settings">The <see cref="T:Roblox.Platform.StaticContent.Properties.ISettings" />.</param>
	/// <param name="expirableCache">An <see cref="T:Roblox.CachingV2.Core.ICache`2" />.</param>
	/// <param name="durableCache">A backup <see cref="T:Roblox.Caching.Shared.ISharedCacheClient" />.</param>
	/// <param name="cacheOperationFactory">An <see cref="T:Roblox.CachingV2.Core.ICacheOperationFactory" />.</param>
	/// <param name="entitySerializer">An <see cref="T:Roblox.CachingV2.Core.ISerializer" />.</param>
	/// <exception cref="T:System.ArgumentNullException">
	/// - <paramref name="logger" />
	/// - <paramref name="settings" />
	/// - <paramref name="expirableCache" />
	/// - <paramref name="durableCache" />
	/// - <paramref name="cacheOperationFactory" />
	/// - <paramref name="entitySerializer" />
	/// </exception>
	internal StaticContentCache(ICounterRegistry counterRegistry, ILogger logger, ISettings settings, ICache<BasicMetadata, BasicSetArgs> expirableCache, ISharedCacheClient durableCache, ICacheOperationFactory cacheOperationFactory, ISerializer entitySerializer)
	{
		_CounterRegistry = counterRegistry ?? throw new ArgumentNullException("counterRegistry");
		_Logger = logger ?? throw new ArgumentNullException("logger");
		_Settings = settings ?? throw new ArgumentNullException("settings");
		_ExpirableCache = expirableCache ?? throw new ArgumentNullException("expirableCache");
		_DurableCache = durableCache ?? throw new ArgumentNullException("durableCache");
		_CacheOperationFactory = cacheOperationFactory ?? throw new ArgumentNullException("cacheOperationFactory");
		_EntitySerializer = entitySerializer ?? throw new ArgumentNullException("entitySerializer");
		RegisterCacheMetrics(logger, expirableCache);
	}

	/// <inheritdoc cref="M:Roblox.Platform.StaticContent.IStaticContentCache`1.GetCachedPage(System.String,System.Func{System.Collections.Generic.ICollection{`0}})" />
	public ICollection<T> GetCachedPage(string cacheKey, Func<ICollection<T>> rawPageGetter)
	{
		if (rawPageGetter == null)
		{
			throw new ArgumentNullException("rawPageGetter");
		}
		if (string.IsNullOrWhiteSpace(cacheKey))
		{
			throw new ArgumentException("Value cannot be null or whitespace.", "cacheKey");
		}
		return _CacheOperationFactory.GetReadThroughOperation().Read(_ExpirableCache, cacheKey, delegate
		{
			ICollection<T> collection;
			try
			{
				collection = rawPageGetter();
			}
			catch (Exception ex)
			{
				if (_DurableCache.QueryBytes(cacheKey, out var value))
				{
					collection = _EntitySerializer.Deserialize<T[]>(value);
					if (collection != null)
					{
						_Logger.Error(ex);
						return collection;
					}
				}
				throw;
			}
			try
			{
				byte[] value2 = _EntitySerializer.Serialize(collection);
				_DurableCache.SetBytes(cacheKey, value2, _Settings.StaticContentDurableCacheExpiry);
			}
			catch (Exception ex2)
			{
				_Logger.Error(ex2);
			}
			return collection;
		}, (ICollection<T> x) => new BasicSetArgs(DateTime.UtcNow + _Settings.StaticContentCacheExpiry), ReadThroughOptions<ICollection<T>>.Default).Value;
	}

	[ExcludeFromCodeCoverage]
	private static ICache<BasicMetadata, BasicSetArgs> CreateMemoryCache(string cacheName)
	{
		return new BasicCache(new MemoryCacheWrapper(cacheName), cacheName);
	}

	[ExcludeFromCodeCoverage]
	private void RegisterCacheMetrics(ILogger logger, ICache<BasicMetadata, BasicSetArgs> expirableCache)
	{
		try
		{
			new CachePerformanceMonitor<ICache<BasicMetadata, BasicSetArgs>, BasicMetadata, BasicSetArgs>(_CounterRegistry, expirableCache).Register();
		}
		catch (Exception e)
		{
			logger.Error(e);
		}
	}
}
