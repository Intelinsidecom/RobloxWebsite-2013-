using System;
using System.IO;
using System.Threading;
using System.Threading.Tasks;
using Roblox.EventLog;

namespace Roblox.CachingV2.Core;

internal class WriteAroundOperation : IWriteAroundOperation
{
	private readonly ILogger _Logger;

	public WriteAroundOperation(ILogger logger)
	{
		_Logger = logger ?? throw new ArgumentNullException("logger");
	}

	public void Write<TMetadata, TSetArgs>(ICache<TMetadata, TSetArgs> cache, string key, SourceWriter sourceWriter) where TMetadata : BasicMetadata where TSetArgs : BasicSetArgs
	{
		Write(cache, key, NullRemoteInvalidator.Instance, sourceWriter);
	}

	public void Write<TMetadata, TSetArgs>(ICache<TMetadata, TSetArgs> cache, string key, IRemoteInvalidator invalidator, SourceWriter sourceWriter) where TMetadata : BasicMetadata where TSetArgs : BasicSetArgs
	{
		if (cache == null)
		{
			throw new ArgumentNullException("cache");
		}
		if (key == null)
		{
			throw new ArgumentNullException("key");
		}
		if (invalidator == null)
		{
			throw new ArgumentNullException("invalidator");
		}
		if (sourceWriter == null)
		{
			throw new ArgumentNullException("sourceWriter");
		}
		sourceWriter();
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

	public Task WriteAsync<TMetadata, TSetArgs>(ICache<TMetadata, TSetArgs> cache, string key, SourceWriterAsync sourceWriter, CancellationToken cancellationToken) where TMetadata : BasicMetadata where TSetArgs : BasicSetArgs
	{
		return WriteAsync(cache, key, NullRemoteInvalidator.Instance, sourceWriter, cancellationToken);
	}

	public async Task WriteAsync<TMetadata, TSetArgs>(ICache<TMetadata, TSetArgs> cache, string key, IRemoteInvalidator invalidator, SourceWriterAsync sourceWriter, CancellationToken cancellationToken) where TMetadata : BasicMetadata where TSetArgs : BasicSetArgs
	{
		if (cache == null)
		{
			throw new ArgumentNullException("cache");
		}
		if (key == null)
		{
			throw new ArgumentNullException("key");
		}
		if (invalidator == null)
		{
			throw new ArgumentNullException("invalidator");
		}
		if (sourceWriter == null)
		{
			throw new ArgumentNullException("sourceWriter");
		}
		await sourceWriter(cancellationToken);
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
