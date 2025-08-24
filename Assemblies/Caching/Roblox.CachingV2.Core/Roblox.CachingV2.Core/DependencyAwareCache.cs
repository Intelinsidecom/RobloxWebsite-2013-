using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Roblox.CachingV2.Core;

public sealed class DependencyAwareCache : CacheBase<DependencyAwareMetadata, DependencyAwareSetArgs>, IDependencyAwareCache, ICache<DependencyAwareMetadata, DependencyAwareSetArgs>
{
	[Serializable]
	private class PartialDependencyAwareCacheEntry
	{
		[JsonProperty(PropertyName = "vt")]
		public CacheVersionToken VersionToken { get; set; }

		[JsonProperty(PropertyName = "deps")]
		public DependencyInfo[] Dependencies { get; set; }
	}

	[Serializable]
	private class FullDependencyAwareCacheEntry<T> : PartialDependencyAwareCacheEntry
	{
		[JsonProperty(PropertyName = "v")]
		public T Value { get; set; }
	}

	private readonly ICacheVersionTokenFactory _CacheVersionTokenFactory;

	public event EventHandler<DependencyCheckFailedEventArgs> DependencyCheckFailed;

	public event EventHandler<DependencyCheckSucceededEventArgs> DependencyCheckSucceeded;

	public DependencyAwareCache(ICacheVersionTokenFactory cacheVersionTokenFactory, IRawCache rawCache, string name)
		: base(rawCache, name)
	{
		_CacheVersionTokenFactory = cacheVersionTokenFactory ?? throw new ArgumentNullException("cacheVersionTokenFactory");
	}

	protected override MetadataCacheGetResult<TValue, DependencyAwareMetadata> DoGet<TValue>(string key)
	{
		CacheGetResult<FullDependencyAwareCacheEntry<TValue>> cacheGetResult = base.RawCache.Get<FullDependencyAwareCacheEntry<TValue>>(key);
		if (!cacheGetResult.IsFound)
		{
			return MetadataCacheGetResult<TValue, DependencyAwareMetadata>.NotFound(key);
		}
		Dictionary<string, CacheVersionToken> alreadyVerifiedEntries = new Dictionary<string, CacheVersionToken> { [cacheGetResult.Key] = cacheGetResult.Entry.VersionToken };
		return ConstructGetResult(CheckDependencies(cacheGetResult.Key, cacheGetResult.Entry, alreadyVerifiedEntries), cacheGetResult);
	}

	protected override async Task<MetadataCacheGetResult<TValue, DependencyAwareMetadata>> DoGetAsync<TValue>(string key, CancellationToken cancellationToken)
	{
		CacheGetResult<FullDependencyAwareCacheEntry<TValue>> result = await base.RawCache.GetAsync<FullDependencyAwareCacheEntry<TValue>>(key, cancellationToken);
		if (!result.IsFound)
		{
			return MetadataCacheGetResult<TValue, DependencyAwareMetadata>.NotFound(key);
		}
		Dictionary<string, CacheVersionToken> alreadyVerifiedEntries = new Dictionary<string, CacheVersionToken> { 
		{
			result.Key,
			result.Entry.VersionToken
		} };
		return ConstructGetResult(await CheckDependenciesAsync(result.Key, result.Entry, alreadyVerifiedEntries, cancellationToken).ConfigureAwait(continueOnCapturedContext: false), result);
	}

	protected override SetResult<DependencyAwareMetadata> DoSet<TValue>(SetEntry<TValue, DependencyAwareSetArgs> entry)
	{
		NullChecker.ThrowIfNull(entry, "entry");
		SetResult<DependencyAwareMetadata> setResult;
		RawSetEntry<FullDependencyAwareCacheEntry<TValue>> entry2 = ConstructRawSetEntry(entry, out setResult);
		base.RawCache.Set(entry2);
		return setResult;
	}

	protected override async Task<SetResult<DependencyAwareMetadata>> DoSetAsync<TValue>(SetEntry<TValue, DependencyAwareSetArgs> entry, CancellationToken cancellationToken)
	{
		NullChecker.ThrowIfNull(entry, "entry");
		SetResult<DependencyAwareMetadata> result;
		RawSetEntry<FullDependencyAwareCacheEntry<TValue>> entry2 = ConstructRawSetEntry(entry, out result);
		await base.RawCache.SetAsync(entry2, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
		return result;
	}

	protected override IEnumerable<MetadataCacheGetResult<TValue, DependencyAwareMetadata>> DoMultiGet<TValue>(IReadOnlyCollection<string> keys)
	{
		IEnumerable<CacheGetResult<FullDependencyAwareCacheEntry<TValue>>> source = base.RawCache.MultiGet<FullDependencyAwareCacheEntry<TValue>>(keys);
		Dictionary<string, CacheVersionToken> alreadyVerifiedEntries = new Dictionary<string, CacheVersionToken>();
		return source.Select(delegate(CacheGetResult<FullDependencyAwareCacheEntry<TValue>> result)
		{
			if (!result.IsFound)
			{
				return MetadataCacheGetResult<TValue, DependencyAwareMetadata>.NotFound(result.Key);
			}
			alreadyVerifiedEntries[result.Key] = result.Entry.VersionToken;
			return ConstructGetResult(CheckDependencies(result.Key, result.Entry, alreadyVerifiedEntries), result);
		});
	}

	protected override async Task<IEnumerable<MetadataCacheGetResult<TValue, DependencyAwareMetadata>>> DoMultiGetAsync<TValue>(IReadOnlyCollection<string> keys, CancellationToken cancellationToken)
	{
		IEnumerable<CacheGetResult<FullDependencyAwareCacheEntry<TValue>>> enumerable = await base.RawCache.MultiGetAsync<FullDependencyAwareCacheEntry<TValue>>(keys, cancellationToken);
		Dictionary<string, CacheVersionToken> alreadyVerifiedEntries = new Dictionary<string, CacheVersionToken>();
		List<MetadataCacheGetResult<TValue, DependencyAwareMetadata>> getResults = new List<MetadataCacheGetResult<TValue, DependencyAwareMetadata>>(keys.Count);
		foreach (CacheGetResult<FullDependencyAwareCacheEntry<TValue>> result in enumerable)
		{
			cancellationToken.ThrowIfCancellationRequested();
			if (!result.IsFound)
			{
				getResults.Add(MetadataCacheGetResult<TValue, DependencyAwareMetadata>.NotFound(result.Key));
				continue;
			}
			alreadyVerifiedEntries[result.Key] = result.Entry.VersionToken;
			getResults.Add(ConstructGetResult(await CheckDependenciesAsync(result.Key, result.Entry, alreadyVerifiedEntries, cancellationToken), result));
		}
		return getResults;
	}

	protected override IEnumerable<SetResult<DependencyAwareMetadata>> DoMultiSet<TValue>(IReadOnlyCollection<SetEntry<TValue, DependencyAwareSetArgs>> entries)
	{
		if (entries == null || entries.Any((SetEntry<TValue, DependencyAwareSetArgs> e) => e == null))
		{
			throw new ArgumentNullException("entries");
		}
		SetResult<DependencyAwareMetadata>[] setResults;
		RawSetEntry<FullDependencyAwareCacheEntry<TValue>>[] entries2 = ConstructRawSetEntries(entries, out setResults);
		base.RawCache.MultiSet((IReadOnlyCollection<RawSetEntry<FullDependencyAwareCacheEntry<TValue>>>)(object)entries2);
		return setResults;
	}

	protected override async Task<IEnumerable<SetResult<DependencyAwareMetadata>>> DoMultiSetAsync<TValue>(IReadOnlyCollection<SetEntry<TValue, DependencyAwareSetArgs>> entries, CancellationToken cancellationToken)
	{
		if (entries == null || entries.Any((SetEntry<TValue, DependencyAwareSetArgs> e) => e == null))
		{
			throw new ArgumentNullException("entries");
		}
		cancellationToken.ThrowIfCancellationRequested();
		SetResult<DependencyAwareMetadata>[] results;
		RawSetEntry<FullDependencyAwareCacheEntry<TValue>>[] entries2 = ConstructRawSetEntries(entries, out results);
		await base.RawCache.MultiSetAsync((IReadOnlyCollection<RawSetEntry<FullDependencyAwareCacheEntry<TValue>>>)(object)entries2, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
		return results;
	}

	private bool CheckDependencies(string key, PartialDependencyAwareCacheEntry entry, IDictionary<string, CacheVersionToken> alreadyVerifiedEntries)
	{
		if (entry.Dependencies == null || entry.Dependencies.Length == 0)
		{
			return true;
		}
		List<DependencyInfo> list = new List<DependencyInfo>();
		List<DependencyInfo> list2 = new List<DependencyInfo>();
		DependencyInfo[] dependencies = entry.Dependencies;
		foreach (DependencyInfo dependencyInfo in dependencies)
		{
			if (alreadyVerifiedEntries.TryGetValue(dependencyInfo.Key, out var value) && dependencyInfo.VersionToken == value)
			{
				list2.Add(dependencyInfo);
			}
			else
			{
				list.Add(dependencyInfo);
			}
		}
		foreach (DependencyInfo item in list2)
		{
			this.DependencyCheckSucceeded?.Invoke(this, new DependencyCheckSucceededEventArgs(key, item.Key));
		}
		Dictionary<string, CacheGetResult<PartialDependencyAwareCacheEntry>> dictionary = base.RawCache.MultiGet<PartialDependencyAwareCacheEntry>((IReadOnlyCollection<string>)(object)list.Select((DependencyInfo d) => d.Key).ToArray()).ToDictionary((CacheGetResult<PartialDependencyAwareCacheEntry> r) => r.Key, (CacheGetResult<PartialDependencyAwareCacheEntry> r) => r);
		foreach (DependencyInfo item2 in list)
		{
			CacheGetResult<PartialDependencyAwareCacheEntry> cacheGetResult = dictionary[item2.Key];
			bool flag;
			if (!cacheGetResult.IsFound || item2.VersionToken != cacheGetResult.Entry.VersionToken)
			{
				flag = false;
			}
			else
			{
				alreadyVerifiedEntries.Add(item2.Key, item2.VersionToken);
				flag = CheckDependencies(item2.Key, cacheGetResult.Entry, alreadyVerifiedEntries);
			}
			if (!flag)
			{
				Remove(key);
				this.DependencyCheckFailed?.Invoke(this, new DependencyCheckFailedEventArgs(key, item2.Key));
				return false;
			}
			this.DependencyCheckSucceeded?.Invoke(this, new DependencyCheckSucceededEventArgs(key, item2.Key));
		}
		return true;
	}

	private async Task<bool> CheckDependenciesAsync(string key, PartialDependencyAwareCacheEntry entry, IDictionary<string, CacheVersionToken> alreadyVerifiedEntries, CancellationToken cancellationToken)
	{
		if (entry.Dependencies == null || entry.Dependencies.Length == 0)
		{
			return true;
		}
		List<DependencyInfo> unverifiedDependencies = new List<DependencyInfo>();
		List<DependencyInfo> list = new List<DependencyInfo>();
		DependencyInfo[] dependencies = entry.Dependencies;
		foreach (DependencyInfo dependencyInfo in dependencies)
		{
			if (alreadyVerifiedEntries.TryGetValue(dependencyInfo.Key, out var value) && dependencyInfo.VersionToken == value)
			{
				list.Add(dependencyInfo);
			}
			else
			{
				unverifiedDependencies.Add(dependencyInfo);
			}
		}
		foreach (DependencyInfo item in list)
		{
			this.DependencyCheckSucceeded?.Invoke(this, new DependencyCheckSucceededEventArgs(key, item.Key));
		}
		Dictionary<string, CacheGetResult<PartialDependencyAwareCacheEntry>> keyedDependencyResults = (await base.RawCache.MultiGetAsync<PartialDependencyAwareCacheEntry>((IReadOnlyCollection<string>)(object)unverifiedDependencies.Select((DependencyInfo d) => d.Key).ToArray(), cancellationToken)).ToDictionary((CacheGetResult<PartialDependencyAwareCacheEntry> r) => r.Key, (CacheGetResult<PartialDependencyAwareCacheEntry> r) => r);
		foreach (DependencyInfo dependency in unverifiedDependencies)
		{
			CacheGetResult<PartialDependencyAwareCacheEntry> cacheGetResult = keyedDependencyResults[dependency.Key];
			bool flag;
			if (!cacheGetResult.IsFound || dependency.VersionToken != cacheGetResult.Entry.VersionToken)
			{
				flag = false;
			}
			else
			{
				alreadyVerifiedEntries.Add(dependency.Key, dependency.VersionToken);
				flag = await CheckDependenciesAsync(dependency.Key, cacheGetResult.Entry, alreadyVerifiedEntries, cancellationToken);
			}
			if (!flag)
			{
				await RemoveAsync(key, cancellationToken);
				this.DependencyCheckFailed?.Invoke(this, new DependencyCheckFailedEventArgs(key, dependency.Key));
				return false;
			}
			this.DependencyCheckSucceeded?.Invoke(this, new DependencyCheckSucceededEventArgs(key, dependency.Key));
		}
		return true;
	}

	private RawSetEntry<FullDependencyAwareCacheEntry<TValue>> ConstructRawSetEntry<TValue>(SetEntry<TValue, DependencyAwareSetArgs> e, out SetResult<DependencyAwareMetadata> setResult)
	{
		FullDependencyAwareCacheEntry<TValue> fullDependencyAwareCacheEntry = new FullDependencyAwareCacheEntry<TValue>
		{
			VersionToken = _CacheVersionTokenFactory.Create(),
			Dependencies = ((e.SetArgs.Dependencies.Count == 0) ? null : e.SetArgs.Dependencies.ToArray()),
			Value = e.Value
		};
		DependencyAwareMetadata metadata = new DependencyAwareMetadata(fullDependencyAwareCacheEntry.VersionToken);
		setResult = new SetResult<DependencyAwareMetadata>(e.Key, metadata);
		return new RawSetEntry<FullDependencyAwareCacheEntry<TValue>>(e.Key, fullDependencyAwareCacheEntry, e.SetArgs.Expiration);
	}

	private RawSetEntry<FullDependencyAwareCacheEntry<TValue>>[] ConstructRawSetEntries<TValue>(IReadOnlyCollection<SetEntry<TValue, DependencyAwareSetArgs>> entries, out SetResult<DependencyAwareMetadata>[] setResults)
	{
		setResults = new SetResult<DependencyAwareMetadata>[entries.Count];
		RawSetEntry<FullDependencyAwareCacheEntry<TValue>>[] array = new RawSetEntry<FullDependencyAwareCacheEntry<TValue>>[entries.Count];
		using IEnumerator<SetEntry<TValue, DependencyAwareSetArgs>> enumerator = entries.GetEnumerator();
		int num = 0;
		while (enumerator.MoveNext())
		{
			array[num] = ConstructRawSetEntry(enumerator.Current, out var setResult);
			setResults[num] = setResult;
			num++;
		}
		return array;
	}

	private static MetadataCacheGetResult<TValue, DependencyAwareMetadata> ConstructGetResult<TValue>(bool dependenciesOk, CacheGetResult<FullDependencyAwareCacheEntry<TValue>> wrapperResult)
	{
		if (!dependenciesOk)
		{
			return MetadataCacheGetResult<TValue, DependencyAwareMetadata>.NotFound(wrapperResult.Key);
		}
		return new MetadataCacheGetResult<TValue, DependencyAwareMetadata>(wrapperResult.Key, wrapperResult.Entry.Value, new DependencyAwareMetadata(wrapperResult.Entry.VersionToken));
	}
}
