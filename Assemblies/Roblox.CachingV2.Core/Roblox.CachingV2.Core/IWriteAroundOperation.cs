using System.Threading;
using System.Threading.Tasks;

namespace Roblox.CachingV2.Core;

public interface IWriteAroundOperation
{
	void Write<TMetadata, TSetArgs>(ICache<TMetadata, TSetArgs> cache, string key, SourceWriter sourceWriter) where TMetadata : BasicMetadata where TSetArgs : BasicSetArgs;

	void Write<TMetadata, TSetArgs>(ICache<TMetadata, TSetArgs> cache, string key, IRemoteInvalidator invalidator, SourceWriter sourceWriter) where TMetadata : BasicMetadata where TSetArgs : BasicSetArgs;

	Task WriteAsync<TMetadata, TSetArgs>(ICache<TMetadata, TSetArgs> cache, string key, SourceWriterAsync sourceWriter, CancellationToken cancellationToken) where TMetadata : BasicMetadata where TSetArgs : BasicSetArgs;

	Task WriteAsync<TMetadata, TSetArgs>(ICache<TMetadata, TSetArgs> cache, string key, IRemoteInvalidator invalidator, SourceWriterAsync sourceWriter, CancellationToken cancellationToken) where TMetadata : BasicMetadata where TSetArgs : BasicSetArgs;
}
