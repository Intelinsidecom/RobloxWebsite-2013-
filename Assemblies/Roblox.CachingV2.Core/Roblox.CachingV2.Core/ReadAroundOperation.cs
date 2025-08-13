using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Roblox.EventLog;

namespace Roblox.CachingV2.Core;

internal class ReadAroundOperation : IReadAroundOperation
{
	private readonly ILogger _Logger;

	public ReadAroundOperation(ILogger logger)
	{
		_Logger = logger ?? throw new ArgumentNullException("logger");
	}

	public CacheReadOperationResult<TValue> Read<TValue, TMetadata, TSetArgs>(ICache<TMetadata, TSetArgs> cache, string key, SourceReader<TValue> sourceReader) where TMetadata : BasicMetadata where TSetArgs : BasicSetArgs
	{
		NullChecker.ThrowIfNull(cache, "cache");
		NullChecker.ThrowIfNull(key, "key");
		NullChecker.ThrowIfNull(sourceReader, "sourceReader");
		MetadataCacheGetResult<TValue, TMetadata> metadataCacheGetResult;
		try
		{
			metadataCacheGetResult = cache.Get<TValue>(key);
		}
		catch (IOException ex)
		{
			_Logger.Error(ex);
			return new CacheReadOperationResult<TValue>(sourceReader(), cacheHit: false, wasCacheReadError: true);
		}
		return new CacheReadOperationResult<TValue>(metadataCacheGetResult.IsFound ? metadataCacheGetResult.Entry : sourceReader(), metadataCacheGetResult.IsFound);
	}

	public async Task<CacheReadOperationResult<TValue>> ReadAsync<TValue, TMetadata, TSetArgs>(ICache<TMetadata, TSetArgs> cache, string key, SourceReaderAsync<TValue> sourceReader, CancellationToken cancellationToken) where TMetadata : BasicMetadata where TSetArgs : BasicSetArgs
	{
		NullChecker.ThrowIfNull(cache, "cache");
		NullChecker.ThrowIfNull(key, "key");
		NullChecker.ThrowIfNull(sourceReader, "sourceReader");
		MetadataCacheGetResult<TValue, TMetadata> result;
		try
		{
			result = await cache.GetAsync<TValue>(key, cancellationToken);
		}
		catch (IOException ex)
		{
			_Logger.Error(ex);
			return new CacheReadOperationResult<TValue>(await sourceReader(cancellationToken).ConfigureAwait(continueOnCapturedContext: false), cacheHit: false, wasCacheReadError: true);
		}
		TValue value = ((!result.IsFound) ? (await sourceReader(cancellationToken).ConfigureAwait(continueOnCapturedContext: false)) : result.Entry);
		return new CacheReadOperationResult<TValue>(value, result.IsFound);
	}

	public IEnumerable<CacheReadOperationResult<TValue>> MultiRead<TValue, TMetadata, TSetArgs>(ICache<TMetadata, TSetArgs> cache, IReadOnlyCollection<string> keys, MultiSourceReader<TValue, string> sourceReader) where TMetadata : BasicMetadata where TSetArgs : BasicSetArgs
	{
		NullChecker.ThrowIfNull(cache, "cache");
		if (keys == null || keys.Any((string k) => k == null))
		{
			throw new ArgumentNullException("keys");
		}
		NullChecker.ThrowIfNull(sourceReader, "sourceReader");
		MetadataCacheGetResult<TValue, TMetadata>[] array;
		try
		{
			array = cache.MultiGet<TValue>(keys).ToArray();
		}
		catch (IOException ex)
		{
			_Logger.Error(ex);
			return ConvertSourceResultsToCacheReadOperationResultsWithError(sourceReader(keys));
		}
		int[] array2 = FindIndicesOfMissingResults(array).ToArray();
		CacheReadOperationResult<TValue>[] array3 = ConvertRawResultsToCacheReadOperationResults(array);
		if (array2.Length != 0)
		{
			string[] keys2 = GetKeysFromMissingIndices(array, array2).ToArray();
			IEnumerable<TValue> values = sourceReader((IReadOnlyCollection<string>)(object)keys2);
			InsertMissingResultsIntoProcessedResults(array3, array2, values);
		}
		return array3;
	}

	public async Task<IEnumerable<CacheReadOperationResult<TValue>>> MultiReadAsync<TValue, TMetadata, TSetArgs>(ICache<TMetadata, TSetArgs> cache, IReadOnlyCollection<string> keys, MultiSourceReaderAsync<TValue, string> sourceReader, CancellationToken cancellationToken) where TMetadata : BasicMetadata where TSetArgs : BasicSetArgs
	{
		NullChecker.ThrowIfNull(cache, "cache");
		if (keys == null || keys.Any((string k) => k == null))
		{
			throw new ArgumentNullException("keys");
		}
		NullChecker.ThrowIfNull(sourceReader, "sourceReader");
		MetadataCacheGetResult<TValue, TMetadata>[] rawResults;
		try
		{
			rawResults = (await cache.MultiGetAsync<TValue>(keys, cancellationToken)).ToArray();
		}
		catch (IOException ex)
		{
			_Logger.Error(ex);
			return ConvertSourceResultsToCacheReadOperationResultsWithError(await sourceReader(keys, cancellationToken).ConfigureAwait(continueOnCapturedContext: false));
		}
		int[] indicesOfMissingResults = FindIndicesOfMissingResults(rawResults).ToArray();
		CacheReadOperationResult<TValue>[] processedResults = ConvertRawResultsToCacheReadOperationResults(rawResults);
		if (indicesOfMissingResults.Length != 0)
		{
			string[] keys2 = GetKeysFromMissingIndices(rawResults, indicesOfMissingResults).ToArray();
			InsertMissingResultsIntoProcessedResults(processedResults, indicesOfMissingResults, await sourceReader((IReadOnlyCollection<string>)(object)keys2, cancellationToken).ConfigureAwait(continueOnCapturedContext: false));
		}
		return processedResults;
	}

	private static IEnumerable<CacheReadOperationResult<TValue>> ConvertSourceResultsToCacheReadOperationResultsWithError<TValue>(IEnumerable<TValue> sourceResults)
	{
		return sourceResults.Select((TValue sr) => new CacheReadOperationResult<TValue>(sr, cacheHit: false, wasCacheReadError: true));
	}

	private static void InsertMissingResultsIntoProcessedResults<TValue>(CacheReadOperationResult<TValue>[] processedResults, IEnumerable<int> indicesOfMissingResults, IEnumerable<TValue> values)
	{
		using IEnumerator<int> enumerator = indicesOfMissingResults.GetEnumerator();
		using IEnumerator<TValue> enumerator2 = values.GetEnumerator();
		while (enumerator.MoveNext() && enumerator2.MoveNext())
		{
			processedResults[enumerator.Current] = new CacheReadOperationResult<TValue>(enumerator2.Current, cacheHit: false);
		}
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

	private static CacheReadOperationResult<TValue>[] ConvertRawResultsToCacheReadOperationResults<TValue, TMetadata>(IEnumerable<MetadataCacheGetResult<TValue, TMetadata>> rawResults) where TMetadata : BasicMetadata
	{
		return rawResults.Select((MetadataCacheGetResult<TValue, TMetadata> r) => (!r.IsFound) ? null : new CacheReadOperationResult<TValue>(r.Entry, cacheHit: true)).ToArray();
	}

	private static IEnumerable<string> GetKeysFromMissingIndices<TValue, TMetadata>(MetadataCacheGetResult<TValue, TMetadata>[] results, IEnumerable<int> indicesOfMissingKeys) where TMetadata : BasicMetadata
	{
		return indicesOfMissingKeys.Select((int i) => results[i].Key);
	}
}
