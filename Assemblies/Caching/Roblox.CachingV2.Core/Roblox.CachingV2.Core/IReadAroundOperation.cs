using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Roblox.CachingV2.Core;

public interface IReadAroundOperation
{
	CacheReadOperationResult<TValue> Read<TValue, TMetadata, TSetArgs>(ICache<TMetadata, TSetArgs> cache, string key, SourceReader<TValue> sourceReadFunc) where TMetadata : BasicMetadata where TSetArgs : BasicSetArgs;

	Task<CacheReadOperationResult<TValue>> ReadAsync<TValue, TMetadata, TSetArgs>(ICache<TMetadata, TSetArgs> cache, string key, SourceReaderAsync<TValue> sourceReadFunc, CancellationToken cancellationToken) where TMetadata : BasicMetadata where TSetArgs : BasicSetArgs;

	IEnumerable<CacheReadOperationResult<TValue>> MultiRead<TValue, TMetadata, TSetArgs>(ICache<TMetadata, TSetArgs> cache, IReadOnlyCollection<string> keys, MultiSourceReader<TValue, string> sourceReadFunc) where TMetadata : BasicMetadata where TSetArgs : BasicSetArgs;

	Task<IEnumerable<CacheReadOperationResult<TValue>>> MultiReadAsync<TValue, TMetadata, TSetArgs>(ICache<TMetadata, TSetArgs> cache, IReadOnlyCollection<string> keys, MultiSourceReaderAsync<TValue, string> sourceReadFunc, CancellationToken cancellationToken) where TMetadata : BasicMetadata where TSetArgs : BasicSetArgs;
}
