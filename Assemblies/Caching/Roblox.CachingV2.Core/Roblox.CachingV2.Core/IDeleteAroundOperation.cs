using System.Threading;
using System.Threading.Tasks;

namespace Roblox.CachingV2.Core;

public interface IDeleteAroundOperation
{
	void Delete<TMetadata, TSetArgs>(ICache<TMetadata, TSetArgs> cache, string key, SourceDeleter sourceDeleter) where TMetadata : BasicMetadata where TSetArgs : BasicSetArgs;

	void Delete<TMetadata, TSetArgs>(ICache<TMetadata, TSetArgs> cache, string key, IRemoteInvalidator invalidator, SourceDeleter sourceDeleter) where TMetadata : BasicMetadata where TSetArgs : BasicSetArgs;

	Task DeleteAsync<TMetadata, TSetArgs>(ICache<TMetadata, TSetArgs> cache, string key, SourceDeleterAsync sourceDeleter, CancellationToken cancellationToken) where TMetadata : BasicMetadata where TSetArgs : BasicSetArgs;

	Task DeleteAsync<TMetadata, TSetArgs>(ICache<TMetadata, TSetArgs> cache, string key, IRemoteInvalidator invalidator, SourceDeleterAsync sourceDeleter, CancellationToken cancellationToken) where TMetadata : BasicMetadata where TSetArgs : BasicSetArgs;
}
