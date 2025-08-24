using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Roblox.CachingV2.Core;

public class ContextualRawCache : IRawCache
{
	private class CacheStub : IRawCache
	{
		public static CacheStub Instance { get; } = new CacheStub();


		private CacheStub()
		{
		}

		public void Set<TValue>(RawSetEntry<TValue> entry)
		{
			NullChecker.ThrowIfNull(entry, "entry");
		}

		public Task SetAsync<TValue>(RawSetEntry<TValue> entry, CancellationToken cancellationToken)
		{
			NullChecker.ThrowIfNull(entry, "entry");
			return Task.FromResult(result: true);
		}

		public void Remove(string key)
		{
			NullChecker.ThrowIfNull(key, "key");
		}

		public Task RemoveAsync(string key, CancellationToken cancellationToken)
		{
			NullChecker.ThrowIfNull(key, "key");
			return Task.FromResult(result: true);
		}

		public CacheGetResult<TValue> Get<TValue>(string key)
		{
			NullChecker.ThrowIfNull(key, "key");
			return CacheGetResult<TValue>.NotFound(key);
		}

		public Task<CacheGetResult<TValue>> GetAsync<TValue>(string key, CancellationToken cancellationToken)
		{
			return Task.FromResult(Get<TValue>(key));
		}

		public IEnumerable<CacheGetResult<TValue>> MultiGet<TValue>(IReadOnlyCollection<string> keys)
		{
			if (keys == null || keys.Any((string k) => k == null))
			{
				throw new ArgumentException("keys");
			}
			return keys.Select(CacheGetResult<TValue>.NotFound);
		}

		public Task<IEnumerable<CacheGetResult<TValue>>> MultiGetAsync<TValue>(IReadOnlyCollection<string> keys, CancellationToken cancellationToken)
		{
			return Task.FromResult(MultiGet<TValue>(keys));
		}

		public void MultiSet<TValue>(IReadOnlyCollection<RawSetEntry<TValue>> entries)
		{
			if (entries == null || entries.Any((RawSetEntry<TValue> e) => e == null))
			{
				throw new ArgumentNullException("entries");
			}
		}

		public Task MultiSetAsync<TValue>(IReadOnlyCollection<RawSetEntry<TValue>> entries, CancellationToken cancellationToken)
		{
			if (entries == null || entries.Any((RawSetEntry<TValue> e) => e == null))
			{
				throw new ArgumentNullException("entries");
			}
			return Task.FromResult(result: true);
		}

		public void MultiRemove(IReadOnlyCollection<string> keys)
		{
			if (keys == null || keys.Any((string k) => k == null))
			{
				throw new ArgumentNullException("keys");
			}
		}

		public Task MultiRemoveAsync(IReadOnlyCollection<string> keys, CancellationToken cancellationToken)
		{
			if (keys == null || keys.Any((string e) => e == null))
			{
				throw new ArgumentNullException("keys");
			}
			return Task.FromResult(result: true);
		}
	}

	private readonly IContextCacheFactory _ContextCacheFactory;

	private readonly CacheStub _CacheStub;

	public ContextualRawCache(IContextCacheFactory contextCacheFactory)
	{
		NullChecker.ThrowIfNull(contextCacheFactory, "contextCacheFactory");
		_CacheStub = CacheStub.Instance;
		_ContextCacheFactory = contextCacheFactory;
	}

	public void Set<TValue>(RawSetEntry<TValue> entry)
	{
		(_ContextCacheFactory.GetRawCacheForCurrentContext() ?? _CacheStub).Set(entry);
	}

	public Task SetAsync<TValue>(RawSetEntry<TValue> entry, CancellationToken cancellationToken)
	{
		return (_ContextCacheFactory.GetRawCacheForCurrentContext() ?? _CacheStub).SetAsync(entry, cancellationToken);
	}

	public void Remove(string key)
	{
		(_ContextCacheFactory.GetRawCacheForCurrentContext() ?? _CacheStub).Remove(key);
	}

	public Task RemoveAsync(string key, CancellationToken cancellationToken)
	{
		return (_ContextCacheFactory.GetRawCacheForCurrentContext() ?? _CacheStub).RemoveAsync(key, cancellationToken);
	}

	public CacheGetResult<TValue> Get<TValue>(string key)
	{
		return (_ContextCacheFactory.GetRawCacheForCurrentContext() ?? _CacheStub).Get<TValue>(key);
	}

	public Task<CacheGetResult<TValue>> GetAsync<TValue>(string key, CancellationToken cancellationToken)
	{
		return (_ContextCacheFactory.GetRawCacheForCurrentContext() ?? _CacheStub).GetAsync<TValue>(key, cancellationToken);
	}

	public IEnumerable<CacheGetResult<TValue>> MultiGet<TValue>(IReadOnlyCollection<string> keys)
	{
		return (_ContextCacheFactory.GetRawCacheForCurrentContext() ?? _CacheStub).MultiGet<TValue>(keys);
	}

	public Task<IEnumerable<CacheGetResult<TValue>>> MultiGetAsync<TValue>(IReadOnlyCollection<string> keys, CancellationToken cancellationToken)
	{
		return (_ContextCacheFactory.GetRawCacheForCurrentContext() ?? _CacheStub).MultiGetAsync<TValue>(keys, cancellationToken);
	}

	public void MultiSet<TValue>(IReadOnlyCollection<RawSetEntry<TValue>> entries)
	{
		(_ContextCacheFactory.GetRawCacheForCurrentContext() ?? _CacheStub).MultiSet(entries);
	}

	public Task MultiSetAsync<TValue>(IReadOnlyCollection<RawSetEntry<TValue>> entries, CancellationToken cancellationToken)
	{
		return (_ContextCacheFactory.GetRawCacheForCurrentContext() ?? _CacheStub).MultiSetAsync(entries, cancellationToken);
	}

	public void MultiRemove(IReadOnlyCollection<string> keys)
	{
		(_ContextCacheFactory.GetRawCacheForCurrentContext() ?? _CacheStub).MultiRemove(keys);
	}

	public Task MultiRemoveAsync(IReadOnlyCollection<string> keys, CancellationToken cancellationToken)
	{
		return (_ContextCacheFactory.GetRawCacheForCurrentContext() ?? _CacheStub).MultiRemoveAsync(keys, cancellationToken);
	}
}
