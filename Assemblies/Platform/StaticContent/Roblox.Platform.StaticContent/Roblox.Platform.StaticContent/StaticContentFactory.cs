using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using Roblox.Caching.Shared;
using Roblox.CachingV2.Core;
using Roblox.DataV2.Core;
using Roblox.EventLog;
using Roblox.Instrumentation;
using Roblox.Platform.Core.ExclusiveStartPaging;
using Roblox.StaticContent.Client;

namespace Roblox.Platform.StaticContent;

/// <inheritdoc cref="T:Roblox.Platform.StaticContent.IStaticContentFactory" />
public class StaticContentFactory : IStaticContentFactory
{
	private readonly IStaticContentClient _StaticContentClient;

	private readonly ILogger _Logger;

	private readonly IStaticContentCache<ContentPackResult> _ContentPackCache;

	/// <summary>
	/// Initializes a new <see cref="T:Roblox.Platform.StaticContent.StaticContentFactory" />.
	/// </summary>
	/// <param name="counterRegistry">An <see cref="T:Roblox.Instrumentation.ICounterRegistry" />.</param>
	/// <param name="staticContentClient">An <see cref="T:Roblox.StaticContent.Client.IStaticContentClient" />.</param>
	/// <param name="logger">An <see cref="T:Roblox.EventLog.ILogger" />.</param>
	/// <param name="durableCache">An <see cref="T:Roblox.Caching.Shared.ISharedCacheClient" />.</param>
	/// <param name="cacheOperationFactory">An <see cref="T:Roblox.CachingV2.Core.ICacheOperationFactory" />.</param>
	/// <param name="entitySerializer">An <see cref="T:Roblox.CachingV2.Core.ISerializer" />.</param>
	/// <exception cref="T:System.ArgumentNullException">
	/// - <paramref name="staticContentClient" />
	/// - <paramref name="logger" />
	/// - <paramref name="durableCache" />
	/// - <paramref name="cacheOperationFactory" />
	/// - <paramref name="entitySerializer" />
	/// </exception>
	[ExcludeFromCodeCoverage]
	public StaticContentFactory(ICounterRegistry counterRegistry, IStaticContentClient staticContentClient, ILogger logger, ISharedCacheClient durableCache, ICacheOperationFactory cacheOperationFactory, ISerializer entitySerializer)
		: this(staticContentClient, logger, new StaticContentCache<ContentPackResult>(counterRegistry, logger, durableCache, cacheOperationFactory, entitySerializer))
	{
	}

	/// <summary>
	/// Initializes a new <see cref="T:Roblox.Platform.StaticContent.StaticContentFactory" />.
	/// </summary>
	/// <param name="staticContentClient">An <see cref="T:Roblox.StaticContent.Client.IStaticContentClient" />.</param>
	/// <param name="logger">An <see cref="T:Roblox.EventLog.ILogger" />.</param>
	/// <param name="contentPackCache">An <see cref="T:Roblox.Platform.StaticContent.IStaticContentCache`1" /> for content pack results.</param>
	/// <exception cref="T:System.ArgumentNullException">
	/// - <paramref name="staticContentClient" />
	/// - <paramref name="contentPackCache" />
	/// </exception>
	internal StaticContentFactory(IStaticContentClient staticContentClient, ILogger logger, IStaticContentCache<ContentPackResult> contentPackCache)
	{
		_StaticContentClient = staticContentClient ?? throw new ArgumentNullException("staticContentClient");
		_Logger = logger ?? throw new ArgumentNullException("logger");
		_ContentPackCache = contentPackCache ?? throw new ArgumentNullException("contentPackCache");
	}

	/// <inheritdoc cref="M:Roblox.Platform.StaticContent.IStaticContentFactory.GetContentPacks(System.String,Roblox.Platform.Core.ExclusiveStartPaging.IExclusiveStartKeyInfo{System.Int64},System.Boolean,System.Nullable{System.Boolean},System.Nullable{System.Boolean})" />
	public IPlatformPageResponse<long, IContentPack> GetContentPacks(string componentName, IExclusiveStartKeyInfo<long> exclusiveStartKey, bool useCache, bool? enabled = null, bool? validated = null)
	{
		if (string.IsNullOrWhiteSpace(componentName))
		{
			throw new ArgumentException("Value cannot be null or whitespace.", "componentName");
		}
		if (exclusiveStartKey == null)
		{
			throw new ArgumentNullException("exclusiveStartKey");
		}
		if (enabled.HasValue && !validated.HasValue)
		{
			throw new ArgumentException(string.Format("If {0} is passed {1} must also be passed.", "enabled", "validated"), "validated");
		}
		if (!enabled.HasValue && validated.HasValue)
		{
			throw new ArgumentException(string.Format("If {0} is passed {1} must also be passed.", "validated", "enabled"), "enabled");
		}
		ICollection<ContentPackResult> contentPackResults;
		if (useCache)
		{
			string cacheKey = BuildContentPackCacheKey(componentName, enabled, validated, exclusiveStartKey);
			contentPackResults = _ContentPackCache.GetCachedPage(cacheKey, RawPageGetter);
		}
		else
		{
			contentPackResults = RawPageGetter();
		}
		return new PlatformPageResponse<long, IContentPack>(contentPackResults.Select(TranslateContentPackResult).ToArray(), exclusiveStartKey, GetExclusiveStartKey);
		ICollection<ContentPackResult> RawPageGetter()
		{
			return GetContentPackPage(componentName, enabled, validated, exclusiveStartKey);
		}
	}

	internal virtual ICollection<ContentPackResult> GetContentPackPage(string componentName, bool? enabled, bool? validated, IExclusiveStartKeyInfo<long> exclusiveStartKey)
	{
		long? exclusiveStartId = null;
		if (exclusiveStartKey.TryGetExclusiveStartKey(out var id))
		{
			exclusiveStartId = id;
		}
		return _StaticContentClient.GetContentPacks(componentName, enabled, validated, exclusiveStartKey.SortOrder, exclusiveStartId, exclusiveStartKey.Count + 1);
	}

	internal string BuildContentPackCacheKey(string componentName, bool? enabled, bool? validated, IExclusiveStartKeyInfo<long> exclusiveStartKey)
	{
		SortOrder sortOrder = exclusiveStartKey.GetDatabaseRequestSortOrder();
		exclusiveStartKey.TryGetExclusiveStartKey(out var exclusiveStartId);
		return $"Component:{componentName}_Enabled:{enabled}_Validated:{validated}_SortOrder:{sortOrder}_ExclusiveStartId:{exclusiveStartId}_Count:{exclusiveStartKey.Count}";
	}

	internal long GetExclusiveStartKey(IContentPack contentPack)
	{
		return contentPack.Id;
	}

	internal ISet<Uri> GetUris(IEnumerable<ContentPackItemResult> contentPackItems)
	{
		HashSet<Uri> urls = new HashSet<Uri>();
		foreach (ContentPackItemResult item in contentPackItems)
		{
			if (Uri.TryCreate(item.Value, UriKind.Absolute, out var uri))
			{
				urls.Add(uri);
			}
			else
			{
				_Logger.Warning($"Content pack item has invalid Uri: {item.Value}");
			}
		}
		return urls;
	}

	private IContentPack TranslateContentPackResult(ContentPackResult contentPackResult)
	{
		if (contentPackResult == null)
		{
			return null;
		}
		return new ContentPack(contentPackResult)
		{
			CssCdnUrls = GetUris(contentPackResult.Items.Where((ContentPackItemResult i) => i.Type == ContentPackItemType.Css)),
			JavaScriptCdnUrls = GetUris(contentPackResult.Items.Where((ContentPackItemResult i) => i.Type == ContentPackItemType.JavaScript))
		};
	}
}
