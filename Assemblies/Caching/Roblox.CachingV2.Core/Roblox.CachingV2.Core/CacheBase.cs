using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Roblox.CachingV2.Core;

public abstract class CacheBase<TMetadata, TSetArgs> : ICache<TMetadata, TSetArgs> where TMetadata : BasicMetadata where TSetArgs : BasicSetArgs
{
	protected IRawCache RawCache { get; }

	public string Name { get; }

	public event EventHandler<EntryMissedEventArgs> EntryMissed;

	public event EventHandler<EntryRemovedEventArgs> EntryRemoved;

	public event EventHandler<EntryRetrievalEventArgs> EntryRetrieved;

	public event EventHandler<EntrySetEventArgs> EntrySet;

	public event EventHandler<EntryQueriedEventArgs> EntryQueried;

	public event EventHandler<ErrorEventArgs> Error;

	protected CacheBase(IRawCache rawCache, string name)
	{
		RawCache = rawCache ?? throw new ArgumentNullException("rawCache");
		Name = name ?? throw new ArgumentNullException("name");
	}

	public MetadataCacheGetResult<TValue, TMetadata> Get<TValue>(string key)
	{
		NullChecker.ThrowIfNull(key, "key");
		HandleEntryQueried(key);
		MetadataCacheGetResult<TValue, TMetadata> result;
		try
		{
			result = DoGet<TValue>(key);
		}
		catch (Exception ex)
		{
			HandleError(ex);
			throw;
		}
		HandleGetResult(result);
		return result;
	}

	public async Task<MetadataCacheGetResult<TValue, TMetadata>> GetAsync<TValue>(string key, CancellationToken cancellationToken)
	{
		NullChecker.ThrowIfNull(key, "key");
		HandleEntryQueried(key);
		MetadataCacheGetResult<TValue, TMetadata> result;
		try
		{
			result = await DoGetAsync<TValue>(key, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
		}
		catch (Exception ex)
		{
			HandleError(ex);
			throw;
		}
		HandleGetResult(result);
		return result;
	}

	public IEnumerable<MetadataCacheGetResult<TValue, TMetadata>> MultiGet<TValue>(IReadOnlyCollection<string> keys)
	{
		if (keys == null || keys.Any((string k) => k == null))
		{
			throw new ArgumentNullException("keys");
		}
		foreach (string key in keys)
		{
			HandleEntryQueried(key);
		}
		List<MetadataCacheGetResult<TValue, TMetadata>> list;
		try
		{
			list = ((keys.Count > 0) ? DoMultiGet<TValue>(keys).ToList() : new List<MetadataCacheGetResult<TValue, TMetadata>>());
		}
		catch (Exception ex)
		{
			HandleError(ex);
			throw;
		}
		foreach (MetadataCacheGetResult<TValue, TMetadata> item in list)
		{
			HandleGetResult(item);
		}
		return list;
	}

	public async Task<IEnumerable<MetadataCacheGetResult<TValue, TMetadata>>> MultiGetAsync<TValue>(IReadOnlyCollection<string> keys, CancellationToken cancellationToken)
	{
		if (keys == null || keys.Any((string k) => k == null))
		{
			throw new ArgumentNullException("keys");
		}
		foreach (string key in keys)
		{
			HandleEntryQueried(key);
		}
		List<MetadataCacheGetResult<TValue, TMetadata>> list2;
		try
		{
			List<MetadataCacheGetResult<TValue, TMetadata>> list = ((keys.Count <= 0) ? new List<MetadataCacheGetResult<TValue, TMetadata>>() : (await DoMultiGetAsync<TValue>(keys, cancellationToken)).ToList());
			list2 = list;
		}
		catch (Exception ex)
		{
			HandleError(ex);
			throw;
		}
		foreach (MetadataCacheGetResult<TValue, TMetadata> item in list2)
		{
			HandleGetResult(item);
		}
		return list2;
	}

	public void Remove(string key)
	{
		NullChecker.ThrowIfNull(key, "key");
		try
		{
			RawCache.Remove(key);
		}
		catch (Exception ex)
		{
			HandleError(ex);
			throw;
		}
		HandleEntryRemoved(key);
	}

	public async Task RemoveAsync(string key, CancellationToken cancellationToken)
	{
		NullChecker.ThrowIfNull(key, "key");
		try
		{
			await RawCache.RemoveAsync(key, cancellationToken);
		}
		catch (Exception ex)
		{
			HandleError(ex);
			throw;
		}
		HandleEntryRemoved(key);
	}

	public void MultiRemove(IReadOnlyCollection<string> keys)
	{
		if (keys == null || keys.Any((string k) => k == null))
		{
			throw new ArgumentNullException("keys");
		}
		try
		{
			RawCache.MultiRemove(keys);
		}
		catch (Exception ex)
		{
			HandleError(ex);
			throw;
		}
		foreach (string key in keys)
		{
			HandleEntryRemoved(key);
		}
	}

	public async Task MultiRemoveAsync(IReadOnlyCollection<string> keys, CancellationToken cancellationToken)
	{
		if (keys == null || keys.Any((string k) => k == null))
		{
			throw new ArgumentNullException("keys");
		}
		try
		{
			await RawCache.MultiRemoveAsync(keys, cancellationToken);
		}
		catch (Exception ex)
		{
			HandleError(ex);
			throw;
		}
		foreach (string key in keys)
		{
			HandleEntryRemoved(key);
		}
	}

	public SetResult<TMetadata> Set<TValue>(SetEntry<TValue, TSetArgs> entry)
	{
		NullChecker.ThrowIfNull(entry, "entry");
		SetResult<TMetadata> setResult;
		try
		{
			setResult = DoSet(entry);
		}
		catch (Exception ex)
		{
			HandleError(ex);
			throw;
		}
		HandleEntrySet(setResult.Key);
		return setResult;
	}

	public async Task<SetResult<TMetadata>> SetAsync<TValue>(SetEntry<TValue, TSetArgs> entry, CancellationToken cancellationToken)
	{
		NullChecker.ThrowIfNull(entry, "entry");
		SetResult<TMetadata> setResult;
		try
		{
			setResult = await DoSetAsync(entry, cancellationToken);
		}
		catch (Exception ex)
		{
			HandleError(ex);
			throw;
		}
		HandleEntrySet(setResult.Key);
		return setResult;
	}

	public IEnumerable<SetResult<TMetadata>> MultiSet<TValue>(IReadOnlyCollection<SetEntry<TValue, TSetArgs>> entries)
	{
		if (entries == null || entries.Any((SetEntry<TValue, TSetArgs> e) => e == null))
		{
			throw new ArgumentNullException("entries");
		}
		SetResult<TMetadata>[] array;
		try
		{
			array = DoMultiSet(entries).ToArray();
		}
		catch (Exception ex)
		{
			HandleError(ex);
			throw;
		}
		SetResult<TMetadata>[] array2 = array;
		foreach (SetResult<TMetadata> setResult in array2)
		{
			HandleEntrySet(setResult.Key);
		}
		return array;
	}

	public async Task<IEnumerable<SetResult<TMetadata>>> MultiSetAsync<TValue>(IReadOnlyCollection<SetEntry<TValue, TSetArgs>> entries, CancellationToken cancellationToken)
	{
		if (entries == null || entries.Any((SetEntry<TValue, TSetArgs> e) => e == null))
		{
			throw new ArgumentNullException("entries");
		}
		SetResult<TMetadata>[] array;
		try
		{
			array = (await DoMultiSetAsync(entries, cancellationToken)).ToArray();
		}
		catch (Exception ex)
		{
			HandleError(ex);
			throw;
		}
		SetResult<TMetadata>[] array2 = array;
		foreach (SetResult<TMetadata> setResult in array2)
		{
			HandleEntrySet(setResult.Key);
		}
		return array;
	}

	protected abstract MetadataCacheGetResult<TValue, TMetadata> DoGet<TValue>(string key);

	protected abstract Task<MetadataCacheGetResult<TValue, TMetadata>> DoGetAsync<TValue>(string key, CancellationToken cancellationToken);

	protected abstract SetResult<TMetadata> DoSet<TValue>(SetEntry<TValue, TSetArgs> entry);

	protected abstract Task<SetResult<TMetadata>> DoSetAsync<TValue>(SetEntry<TValue, TSetArgs> entry, CancellationToken cancellationToken);

	protected abstract IEnumerable<MetadataCacheGetResult<TValue, TMetadata>> DoMultiGet<TValue>(IReadOnlyCollection<string> keys);

	protected abstract Task<IEnumerable<MetadataCacheGetResult<TValue, TMetadata>>> DoMultiGetAsync<TValue>(IReadOnlyCollection<string> keys, CancellationToken cancellationToken);

	protected abstract IEnumerable<SetResult<TMetadata>> DoMultiSet<TValue>(IReadOnlyCollection<SetEntry<TValue, TSetArgs>> entries);

	protected abstract Task<IEnumerable<SetResult<TMetadata>>> DoMultiSetAsync<TValue>(IReadOnlyCollection<SetEntry<TValue, TSetArgs>> entries, CancellationToken cancellationToken);

	private void HandleGetResult<TValue>(CacheGetResult<TValue> result)
	{
		if (result.IsFound)
		{
			this.EntryRetrieved?.Invoke(this, new EntryRetrievalEventArgs(result.Key, result.Entry));
		}
		else
		{
			this.EntryMissed?.Invoke(this, new EntryMissedEventArgs(result.Key));
		}
	}

	private void HandleEntrySet(string key)
	{
		this.EntrySet?.Invoke(this, new EntrySetEventArgs(key));
	}

	private void HandleEntryRemoved(string key)
	{
		this.EntryRemoved?.Invoke(this, new EntryRemovedEventArgs(key));
	}

	private void HandleEntryQueried(string key)
	{
		this.EntryQueried?.Invoke(this, new EntryQueriedEventArgs(key));
	}

	private void HandleError(Exception ex)
	{
		this.Error?.Invoke(this, new ErrorEventArgs(ex));
	}
}
