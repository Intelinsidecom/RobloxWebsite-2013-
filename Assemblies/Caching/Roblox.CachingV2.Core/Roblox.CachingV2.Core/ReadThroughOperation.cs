using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Roblox.EventLog;

namespace Roblox.CachingV2.Core;

internal class ReadThroughOperation : IReadThroughOperation
{
	private readonly ILogger _Logger;

	public ReadThroughOperation(ILogger logger)
	{
		_Logger = logger ?? throw new ArgumentNullException("logger");
	}

	public ReadThroughOperationResult<TValue, TMetadata> Read<TValue, TMetadata, TSetArgs>(ICache<TMetadata, TSetArgs> cache, string key, SourceReader<TValue> sourceReadFunc, SetArgsConstructor<TValue, TSetArgs> setArgsConstructorFunc, ReadThroughOptions<TValue> options) where TMetadata : BasicMetadata where TSetArgs : BasicSetArgs
	{
		NullChecker.ThrowIfNull(cache, "cache");
		NullChecker.ThrowIfNull(key, "key");
		NullChecker.ThrowIfNull(sourceReadFunc, "sourceReadFunc");
		NullChecker.ThrowIfNull(setArgsConstructorFunc, "setArgsConstructorFunc");
		NullChecker.ThrowIfNull(options, "options");
		bool wasCacheReadError = false;
		bool wasCacheWriteError = false;
		SetResult<TMetadata> setResult = null;
		MetadataCacheGetResult<TValue, TMetadata> metadataCacheGetResult;
		try
		{
			metadataCacheGetResult = cache.Get<TValue>(key);
		}
		catch (IOException ex)
		{
			_Logger.Error(ex);
			metadataCacheGetResult = null;
			wasCacheReadError = true;
		}
		bool num = metadataCacheGetResult?.IsFound ?? false;
		bool cacheHit = num;
		TValue val;
		TMetadata metadata;
		if (num)
		{
			val = metadataCacheGetResult.Entry;
			metadata = metadataCacheGetResult.Metadata;
		}
		else
		{
			val = sourceReadFunc();
			Func<TValue, bool> isCacheableFunc = options.IsCacheableFunc;
			if (isCacheableFunc == null || isCacheableFunc(val))
			{
				TSetArgs val2;
				try
				{
					val2 = setArgsConstructorFunc(val);
				}
				catch (SetArgsConstructionException ex2)
				{
					_Logger.Error(ex2);
					val2 = null;
				}
				if (val2 != null)
				{
					try
					{
						setResult = cache.Set(new SetEntry<TValue, TSetArgs>(key, val, val2));
					}
					catch (IOException ex3)
					{
						_Logger.Error(ex3);
						setResult = null;
						wasCacheWriteError = true;
					}
				}
				else
				{
					wasCacheWriteError = true;
				}
			}
			metadata = ((setResult != null) ? setResult.Metadata : null);
		}
		return new ReadThroughOperationResult<TValue, TMetadata>(val, cacheHit, setResult != null, metadata, wasCacheReadError, wasCacheWriteError);
	}

	public async Task<ReadThroughOperationResult<TValue, TMetadata>> ReadAsync<TValue, TMetadata, TSetArgs>(ICache<TMetadata, TSetArgs> cache, string key, SourceReaderAsync<TValue> sourceReadFunc, SetArgsConstructorAsync<TValue, TSetArgs> setArgsConstructorFunc, ReadThroughOptions<TValue> options, CancellationToken cancellationToken) where TMetadata : BasicMetadata where TSetArgs : BasicSetArgs
	{
		NullChecker.ThrowIfNull(cache, "cache");
		NullChecker.ThrowIfNull(key, "key");
		NullChecker.ThrowIfNull(sourceReadFunc, "sourceReadFunc");
		NullChecker.ThrowIfNull(setArgsConstructorFunc, "setArgsConstructorFunc");
		NullChecker.ThrowIfNull(options, "options");
		bool wasCacheReadError = false;
		bool wasCacheWriteError = false;
		SetResult<TMetadata> setResult = null;
		MetadataCacheGetResult<TValue, TMetadata> metadataCacheGetResult;
		try
		{
			metadataCacheGetResult = await cache.GetAsync<TValue>(key, cancellationToken);
		}
		catch (IOException ex)
		{
			_Logger.Error(ex);
			metadataCacheGetResult = null;
			wasCacheReadError = true;
		}
		bool num = metadataCacheGetResult?.IsFound ?? false;
		bool flag = num;
		bool cacheHit = num;
		TValue value;
		TMetadata metadata;
		if (flag)
		{
			value = metadataCacheGetResult.Entry;
			metadata = metadataCacheGetResult.Metadata;
		}
		else
		{
			value = await sourceReadFunc(cancellationToken);
			if (options.IsCacheableFunc?.Invoke(value) ?? true)
			{
				TSetArgs val;
				try
				{
					val = await setArgsConstructorFunc(value, CancellationToken.None);
				}
				catch (SetArgsConstructionException ex2)
				{
					_Logger.Error(ex2);
					val = null;
				}
				if (val != null)
				{
					try
					{
						setResult = await cache.SetAsync(new SetEntry<TValue, TSetArgs>(key, value, val), CancellationToken.None).ConfigureAwait(continueOnCapturedContext: false);
					}
					catch (IOException ex3)
					{
						_Logger.Error(ex3);
						setResult = null;
						wasCacheWriteError = true;
					}
				}
				else
				{
					wasCacheWriteError = true;
				}
			}
			SetResult<TMetadata> setResult2 = setResult;
			metadata = ((setResult2 != null) ? setResult2.Metadata : null);
		}
		return new ReadThroughOperationResult<TValue, TMetadata>(value, cacheHit, setResult != null, metadata, wasCacheReadError, wasCacheWriteError);
	}

	public IEnumerable<ReadThroughOperationResult<TValue, TMetadata>> MultiRead<TValue, TMetadata, TSetArgs>(ICache<TMetadata, TSetArgs> cache, IReadOnlyCollection<string> keys, MultiSourceReader<TValue, string> sourceReadFunc, MultiSetArgsConstructor<TValue, TSetArgs> setArgsConstructorFunc, ReadThroughOptions<TValue> options) where TMetadata : BasicMetadata where TSetArgs : BasicSetArgs
	{
		NullChecker.ThrowIfNull(cache, "cache");
		if (keys == null || keys.Any((string k) => k == null))
		{
			throw new ArgumentNullException("keys");
		}
		NullChecker.ThrowIfNull(sourceReadFunc, "sourceReadFunc");
		NullChecker.ThrowIfNull(setArgsConstructorFunc, "setArgsConstructorFunc");
		NullChecker.ThrowIfNull(options, "options");
		MetadataCacheGetResult<TValue, TMetadata>[] array;
		bool wasCacheReadError;
		try
		{
			array = cache.MultiGet<TValue>(keys).ToArray();
			wasCacheReadError = false;
		}
		catch (IOException ex)
		{
			_Logger.Error(ex);
			array = keys.Select(MetadataCacheGetResult<TValue, TMetadata>.NotFound).ToArray();
			wasCacheReadError = true;
		}
		int[] array2 = FindIndicesOfMissingResults(array).ToArray();
		ReadThroughOperationResult<TValue, TMetadata>[] array3 = ConvertRawResultsToReadThroughOperationResults(array);
		if (array2.Length != 0)
		{
			string[] keys2 = GetKeysFromMissingIndices(array, array2).ToArray();
			TValue[] array4 = sourceReadFunc((IReadOnlyCollection<string>)(object)keys2).ToArray();
			TValue[] array5 = array4.Where((TValue r) => options.IsCacheableFunc?.Invoke(r) ?? true).ToArray();
			IEnumerable<TSetArgs> enumerable;
			try
			{
				enumerable = setArgsConstructorFunc((IReadOnlyCollection<TValue>)(object)array5);
			}
			catch (SetArgsConstructionException ex2)
			{
				_Logger.Error(ex2);
				enumerable = null;
			}
			IEnumerable<SetResult<TMetadata>> setResults;
			bool wasCacheWriteError;
			if (enumerable != null)
			{
				IReadOnlyCollection<SetEntry<TValue, TSetArgs>> entries = ConstructSetEntriesFromCacheableSourceResultsAndSetArgs(keys2, array5, enumerable);
				try
				{
					setResults = cache.MultiSet(entries);
					wasCacheWriteError = false;
				}
				catch (IOException ex3)
				{
					_Logger.Error(ex3);
					setResults = Enumerable.Repeat<SetResult<TMetadata>>(null, array5.Length);
					wasCacheWriteError = true;
				}
			}
			else
			{
				setResults = Enumerable.Repeat<SetResult<TMetadata>>(null, array5.Length);
				wasCacheWriteError = true;
			}
			InsertMissingResultsIntoProcessedResults(array3, array2, array4, setResults, wasCacheReadError, wasCacheWriteError);
		}
		return array3;
	}

	public async Task<IEnumerable<ReadThroughOperationResult<TValue, TMetadata>>> MultiReadAsync<TValue, TMetadata, TSetArgs>(ICache<TMetadata, TSetArgs> cache, IReadOnlyCollection<string> keys, MultiSourceReaderAsync<TValue, string> sourceReadFunc, MultiSetArgsConstructorAsync<TValue, TSetArgs> setArgsConstructorFunc, ReadThroughOptions<TValue> options, CancellationToken cancellationToken) where TMetadata : BasicMetadata where TSetArgs : BasicSetArgs
	{
		NullChecker.ThrowIfNull(cache, "cache");
		if (keys == null || keys.Any((string k) => k == null))
		{
			throw new ArgumentNullException("keys");
		}
		NullChecker.ThrowIfNull(sourceReadFunc, "sourceReadFunc");
		NullChecker.ThrowIfNull(setArgsConstructorFunc, "setArgsConstructorFunc");
		NullChecker.ThrowIfNull(options, "options");
		MetadataCacheGetResult<TValue, TMetadata>[] array;
		bool wasCacheReadError;
		try
		{
			array = (await cache.MultiGetAsync<TValue>(keys, cancellationToken)).ToArray();
			wasCacheReadError = false;
		}
		catch (IOException ex)
		{
			_Logger.Error(ex);
			array = keys.Select(MetadataCacheGetResult<TValue, TMetadata>.NotFound).ToArray();
			wasCacheReadError = true;
		}
		int[] missingResultIndices = FindIndicesOfMissingResults(array).ToArray();
		ReadThroughOperationResult<TValue, TMetadata>[] processedResults = ConvertRawResultsToReadThroughOperationResults(array);
		if (missingResultIndices.Length != 0)
		{
			string[] missingKeys = GetKeysFromMissingIndices(array, missingResultIndices).ToArray();
			TValue[] sourceResults = (await sourceReadFunc((IReadOnlyCollection<string>)(object)missingKeys, cancellationToken)).ToArray();
			TValue[] cacheableSourceResults = sourceResults.Where((TValue r) => options.IsCacheableFunc?.Invoke(r) ?? true).ToArray();
			IEnumerable<TSetArgs> enumerable;
			try
			{
				enumerable = await setArgsConstructorFunc((IReadOnlyCollection<TValue>)(object)cacheableSourceResults, CancellationToken.None);
			}
			catch (SetArgsConstructionException ex2)
			{
				_Logger.Error(ex2);
				enumerable = null;
			}
			IEnumerable<SetResult<TMetadata>> setResults;
			bool wasCacheWriteError;
			if (enumerable != null)
			{
				IReadOnlyCollection<SetEntry<TValue, TSetArgs>> entries = ConstructSetEntriesFromCacheableSourceResultsAndSetArgs(missingKeys, cacheableSourceResults, enumerable);
				try
				{
					setResults = await cache.MultiSetAsync(entries, CancellationToken.None).ConfigureAwait(continueOnCapturedContext: false);
					wasCacheWriteError = false;
				}
				catch (IOException ex3)
				{
					_Logger.Error(ex3);
					setResults = Enumerable.Repeat<SetResult<TMetadata>>(null, cacheableSourceResults.Length);
					wasCacheWriteError = true;
				}
			}
			else
			{
				setResults = Enumerable.Repeat<SetResult<TMetadata>>(null, cacheableSourceResults.Length);
				wasCacheWriteError = true;
			}
			InsertMissingResultsIntoProcessedResults(processedResults, missingResultIndices, sourceResults, setResults, wasCacheReadError, wasCacheWriteError);
		}
		return processedResults;
	}

	private static void InsertMissingResultsIntoProcessedResults<TValue, TMetadata>(ReadThroughOperationResult<TValue, TMetadata>[] processedResults, IEnumerable<int> indicesOfMissingResults, IEnumerable<TValue> values, IEnumerable<SetResult<TMetadata>> setResults, bool wasCacheReadError, bool wasCacheWriteError) where TMetadata : BasicMetadata
	{
		using IEnumerator<int> enumerator = indicesOfMissingResults.GetEnumerator();
		using IEnumerator<TValue> enumerator2 = values.GetEnumerator();
		using IEnumerator<SetResult<TMetadata>> enumerator3 = setResults.GetEnumerator();
		while (enumerator.MoveNext() && enumerator2.MoveNext() && enumerator3.MoveNext())
		{
			int current = enumerator.Current;
			TValue current2 = enumerator2.Current;
			SetResult<TMetadata> current3 = enumerator3.Current;
			processedResults[current] = new ReadThroughOperationResult<TValue, TMetadata>(current2, cacheHit: false, wasSet: true, (current3 != null) ? current3.Metadata : null, wasCacheReadError, wasCacheWriteError);
		}
	}

	private static ReadThroughOperationResult<TValue, TMetadata>[] ConvertRawResultsToReadThroughOperationResults<TValue, TMetadata>(IEnumerable<MetadataCacheGetResult<TValue, TMetadata>> rawResults) where TMetadata : BasicMetadata
	{
		return rawResults.Select((MetadataCacheGetResult<TValue, TMetadata> r) => (!r.IsFound) ? null : new ReadThroughOperationResult<TValue, TMetadata>(r.Entry, cacheHit: true, wasSet: false, r.Metadata)).ToArray();
	}

	private static IEnumerable<int> FindIndicesOfMissingResults<TValue, TMetadata>(IEnumerable<MetadataCacheGetResult<TValue, TMetadata>> results) where TMetadata : BasicMetadata
	{
		int i = 0;
		foreach (MetadataCacheGetResult<TValue, TMetadata> result in results)
		{
			if (!result.IsFound)
			{
				yield return i;
			}
			i++;
		}
	}

	private static IEnumerable<string> GetKeysFromMissingIndices<TValue, TMetadata>(MetadataCacheGetResult<TValue, TMetadata>[] results, IEnumerable<int> indicesOfMissingKeys) where TMetadata : BasicMetadata
	{
		return indicesOfMissingKeys.Select((int i) => results[i].Key);
	}

	private static IReadOnlyCollection<SetEntry<TValue, TSetArgs>> ConstructSetEntriesFromCacheableSourceResultsAndSetArgs<TValue, TSetArgs>(IEnumerable<string> keys, IEnumerable<TValue> cacheableSourceResults, IEnumerable<TSetArgs> setArgs) where TSetArgs : BasicSetArgs
	{
		List<SetEntry<TValue, TSetArgs>> list = new List<SetEntry<TValue, TSetArgs>>();
		using (IEnumerator<string> enumerator = keys.GetEnumerator())
		{
			using IEnumerator<TValue> enumerator2 = cacheableSourceResults.GetEnumerator();
			using IEnumerator<TSetArgs> enumerator3 = setArgs.GetEnumerator();
			while (enumerator.MoveNext() && enumerator2.MoveNext() && enumerator3.MoveNext())
			{
				list.Add(new SetEntry<TValue, TSetArgs>(enumerator.Current, enumerator2.Current, enumerator3.Current));
			}
		}
		return list;
	}
}
