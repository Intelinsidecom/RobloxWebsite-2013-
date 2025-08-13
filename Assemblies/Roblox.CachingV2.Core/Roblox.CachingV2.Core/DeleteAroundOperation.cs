using System;
using System.IO;
using System.Threading;
using System.Threading.Tasks;
using Roblox.EventLog;

namespace Roblox.CachingV2.Core;

internal class DeleteAroundOperation : IDeleteAroundOperation
{
	private readonly ILogger _Logger;

	public DeleteAroundOperation(ILogger logger)
	{
		_Logger = logger ?? throw new ArgumentNullException("logger");
	}

	public void Delete<TMetadata, TSetArgs>(ICache<TMetadata, TSetArgs> cache, string key, SourceDeleter sourceDeleter) where TMetadata : BasicMetadata where TSetArgs : BasicSetArgs
	{
		Delete(cache, key, NullRemoteInvalidator.Instance, sourceDeleter);
	}

	public void Delete<TMetadata, TSetArgs>(ICache<TMetadata, TSetArgs> cache, string key, IRemoteInvalidator invalidator, SourceDeleter sourceDeleter) where TMetadata : BasicMetadata where TSetArgs : BasicSetArgs
	{
		NullChecker.ThrowIfNull(cache, "cache");
		NullChecker.ThrowIfNull(key, "key");
		NullChecker.ThrowIfNull(invalidator, "invalidator");
		NullChecker.ThrowIfNull(sourceDeleter, "sourceDeleter");
		sourceDeleter();
		try
		{
			cache.Remove(key);
		}
		catch (IOException ex)
		{
			_Logger.Error(ex);
		}
		try
		{
			invalidator.Invalidate(key);
		}
		catch (RemoteInvalidationException ex2)
		{
			_Logger.Error(ex2);
		}
	}

	public Task DeleteAsync<TMetadata, TSetArgs>(ICache<TMetadata, TSetArgs> cache, string key, SourceDeleterAsync sourceDeleter, CancellationToken cancellationToken) where TMetadata : BasicMetadata where TSetArgs : BasicSetArgs
	{
		return DeleteAsync(cache, key, NullRemoteInvalidator.Instance, sourceDeleter, cancellationToken);
	}

	public async Task DeleteAsync<TMetadata, TSetArgs>(ICache<TMetadata, TSetArgs> cache, string key, IRemoteInvalidator invalidator, SourceDeleterAsync sourceDeleter, CancellationToken cancellationToken) where TMetadata : BasicMetadata where TSetArgs : BasicSetArgs
	{
		NullChecker.ThrowIfNull(cache, "cache");
		NullChecker.ThrowIfNull(key, "key");
		NullChecker.ThrowIfNull(invalidator, "invalidator");
		NullChecker.ThrowIfNull(sourceDeleter, "sourceDeleter");
		await sourceDeleter(cancellationToken);
		try
		{
			await cache.RemoveAsync(key, CancellationToken.None);
		}
		catch (IOException ex)
		{
			_Logger.Error(ex);
		}
		try
		{
			await invalidator.InvalidateAsync(key, CancellationToken.None).ConfigureAwait(continueOnCapturedContext: false);
		}
		catch (RemoteInvalidationException ex2)
		{
			_Logger.Error(ex2);
		}
	}
}
