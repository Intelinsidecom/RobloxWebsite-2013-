using System.Threading;
using System.Threading.Tasks;

namespace Roblox.CachingV2.Core;

public interface IWriteThroughOperation
{
	WriteThroughOperationResult<TMetadata> Write<TValue, TMetadata, TSetArgs>(ICache<TMetadata, TSetArgs> cache, SetEntryBuilder<TValue, TSetArgs> setEntryBuilder, SourceWriter sourceWriter) where TMetadata : BasicMetadata where TSetArgs : BasicSetArgs;

	WriteThroughOperationResult<TMetadata> Write<TValue, TMetadata, TSetArgs>(ICache<TMetadata, TSetArgs> cache, SetEntryBuilder<TValue, TSetArgs> setEntryBuilder, IRemoteInvalidator invalidator, SourceWriter sourceWriter) where TMetadata : BasicMetadata where TSetArgs : BasicSetArgs;

	Task<WriteThroughOperationResult<TMetadata>> WriteAsync<TValue, TMetadata, TSetArgs>(ICache<TMetadata, TSetArgs> cache, SetEntryBuilder<TValue, TSetArgs> setEntryBuilder, SourceWriterAsync sourceWriter, CancellationToken cancellationToken) where TMetadata : BasicMetadata where TSetArgs : BasicSetArgs;

	Task<WriteThroughOperationResult<TMetadata>> WriteAsync<TValue, TMetadata, TSetArgs>(ICache<TMetadata, TSetArgs> cache, SetEntryBuilder<TValue, TSetArgs> setEntryBuilder, IRemoteInvalidator invalidator, SourceWriterAsync sourceWriter, CancellationToken cancellationToken) where TMetadata : BasicMetadata where TSetArgs : BasicSetArgs;
}
