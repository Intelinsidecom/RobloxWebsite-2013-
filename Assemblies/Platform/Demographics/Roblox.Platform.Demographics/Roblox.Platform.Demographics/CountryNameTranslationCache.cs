using System;
using System.Collections.Generic;
using System.Runtime.Caching;
using Roblox.Configuration;
using Roblox.Platform.Core;
using Roblox.Platform.Demographics.Properties;
using Roblox.Platform.Localization.Core;
using Roblox.Platform.TranslationStorage;

namespace Roblox.Platform.Demographics;

internal class CountryNameTranslationCache : ICountryNameTranslationCache
{
	private static readonly Lazy<CountryNameTranslationCache> _Lazy = new Lazy<CountryNameTranslationCache>(() => new CountryNameTranslationCache());

	private readonly MemoryCache _MemoryCache;

	private readonly Func<DateTime> _DateTimeGetter;

	private readonly ICountryNameTranslationCacheSettings _Settings;

	public static CountryNameTranslationCache SingletonInstance => _Lazy.Value;

	private CountryNameTranslationCache()
		: this(new MemoryCache("CountryNameTranslations"), () => DateTime.UtcNow, Settings.Default)
	{
		Settings.Default.MonitorChanges((Settings s) => s.CountryNameTranslationCachingExpiration, UpdateExpiration);
	}

	internal CountryNameTranslationCache(MemoryCache memoryCache, Func<DateTime> dateTimeGetter, ICountryNameTranslationCacheSettings settings)
	{
		_MemoryCache = memoryCache.AssignOrThrowIfNull("memoryCache");
		_DateTimeGetter = dateTimeGetter.AssignOrThrowIfNull("dateTimeGetter");
		_Settings = settings.AssignOrThrowIfNull("settings");
	}

	public ITranslationForContentSourceTargetId Get(string id, ISupportedLocale supportedLocale)
	{
		if (string.IsNullOrWhiteSpace(id))
		{
			throw new PlatformArgumentNullException("id");
		}
		if (supportedLocale == null)
		{
			throw new PlatformArgumentNullException("supportedLocale");
		}
		if (!(_MemoryCache.Get(GenerateCacheItemKey(id, supportedLocale)) is Tuple<ITranslationForContentSourceTargetId, DateTime> translationDatetimeTuple))
		{
			return null;
		}
		return translationDatetimeTuple.Item1;
	}

	public void Set(string id, ISupportedLocale supportedLocale, ITranslationForContentSourceTargetId translation)
	{
		if (string.IsNullOrWhiteSpace(id))
		{
			throw new PlatformArgumentNullException("id");
		}
		if (supportedLocale == null)
		{
			throw new PlatformArgumentNullException("supportedLocale");
		}
		if (translation == null)
		{
			throw new PlatformArgumentNullException("translation");
		}
		CacheItem cacheItem = new CacheItem(GenerateCacheItemKey(id, supportedLocale), new Tuple<ITranslationForContentSourceTargetId, DateTime>(translation, _DateTimeGetter()));
		CacheItemPolicy cacheItemPolicy = new CacheItemPolicy
		{
			AbsoluteExpiration = new DateTimeOffset(DateTime.UtcNow.Add(_Settings.CountryNameTranslationCachingExpiration))
		};
		_MemoryCache.Set(cacheItem, cacheItemPolicy);
	}

	private string GenerateCacheItemKey(string id, ISupportedLocale supportedLocale)
	{
		return $"{id}_{supportedLocale.LocaleCode}";
	}

	private void UpdateExpiration()
	{
		foreach (KeyValuePair<string, object> keyValuePair in (IEnumerable<KeyValuePair<string, object>>)_MemoryCache)
		{
			string key = keyValuePair.Key;
			if (keyValuePair.Value is Tuple<ITranslationForContentSourceTargetId, DateTime> translationDatetimeTuple)
			{
				CacheItem cacheItem = new CacheItem(key, translationDatetimeTuple);
				DateTime timeCached = translationDatetimeTuple.Item2;
				CacheItemPolicy cacheItemPolicy = new CacheItemPolicy
				{
					AbsoluteExpiration = new DateTimeOffset(timeCached.Add(_Settings.CountryNameTranslationCachingExpiration))
				};
				_MemoryCache.Set(cacheItem, cacheItemPolicy);
			}
		}
	}
}
