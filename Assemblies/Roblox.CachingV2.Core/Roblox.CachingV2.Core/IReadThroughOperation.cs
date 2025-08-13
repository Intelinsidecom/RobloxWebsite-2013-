using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Roblox.CachingV2.Core;

public interface IReadThroughOperation
{
	ReadThroughOperationResult<TValue, TMetadata> Read<TValue, TMetadata, TSetArgs>(ICache<TMetadata, TSetArgs> cache, string key, SourceReader<TValue> sourceReadFunc, SetArgsConstructor<TValue, TSetArgs> setArgsConstructorFunc, ReadThroughOptions<TValue> options) where TMetadata : BasicMetadata where TSetArgs : BasicSetArgs;

	Task<ReadThroughOperationResult<TValue, TMetadata>> ReadAsync<TValue, TMetadata, TSetArgs>(ICache<TMetadata, TSetArgs> cache, string key, SourceReaderAsync<TValue> sourceReadFunc, SetArgsConstructorAsync<TValue, TSetArgs> setArgsConstructorFunc, ReadThroughOptions<TValue> options, CancellationToken cancellationToken) where TMetadata : BasicMetadata where TSetArgs : BasicSetArgs;

	IEnumerable<ReadThroughOperationResult<TValue, TMetadata>> MultiRead<TValue, TMetadata, TSetArgs>(ICache<TMetadata, TSetArgs> cache, IReadOnlyCollection<string> keys, MultiSourceReader<TValue, string> sourceReadFunc, MultiSetArgsConstructor<TValue, TSetArgs> setArgsConstructorFunc, ReadThroughOptions<TValue> options) where TMetadata : BasicMetadata where TSetArgs : BasicSetArgs;

	Task<IEnumerable<ReadThroughOperationResult<TValue, TMetadata>>> MultiReadAsync<TValue, TMetadata, TSetArgs>(ICache<TMetadata, TSetArgs> cache, IReadOnlyCollection<string> keys, MultiSourceReaderAsync<TValue, string> sourceReadFunc, MultiSetArgsConstructorAsync<TValue, TSetArgs> setArgsConstructorFunc, ReadThroughOptions<TValue> options, CancellationToken cancellationToken) where TMetadata : BasicMetadata where TSetArgs : BasicSetArgs;
}
