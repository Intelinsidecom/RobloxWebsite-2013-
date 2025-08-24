using System;
using System.IO;
using System.Threading;
using System.Threading.Tasks;
using Roblox.EventLog;

namespace Roblox.CachingV2.Core;

internal class WriteThroughOperation : IWriteThroughOperation
{
	private readonly ILogger _Logger;

	public WriteThroughOperation(ILogger logger)
	{
		_Logger = logger ?? throw new ArgumentNullException("logger");
	}

	public WriteThroughOperationResult<TMetadata> Write<TValue, TMetadata, TSetArgs>(ICache<TMetadata, TSetArgs> cache, SetEntryBuilder<TValue, TSetArgs> setEntryBuilder, SourceWriter sourceWriter) where TMetadata : BasicMetadata where TSetArgs : BasicSetArgs
	{
		return Write(cache, setEntryBuilder, NullRemoteInvalidator.Instance, sourceWriter);
	}

	public WriteThroughOperationResult<TMetadata> Write<TValue, TMetadata, TSetArgs>(ICache<TMetadata, TSetArgs> cache, SetEntryBuilder<TValue, TSetArgs> setEntryBuilder, IRemoteInvalidator invalidator, SourceWriter sourceWriter) where TMetadata : BasicMetadata where TSetArgs : BasicSetArgs
	{
		NullChecker.ThrowIfNull(cache, "cache");
		NullChecker.ThrowIfNull(setEntryBuilder, "setEntryBuilder");
		NullChecker.ThrowIfNull(invalidator, "invalidator");
		NullChecker.ThrowIfNull(sourceWriter, "sourceWriter");
		sourceWriter();
		SetEntry<TValue, TSetArgs> setEntry;
		try
		{
			setEntry = setEntryBuilder();
		}
		catch (Exception innerException)
		{
			Exception ex = new IOException("Exception occurred while constructing set entry.", innerException);
			_Logger.Error(ex);
			setEntry = null;
		}
		SetResult<TMetadata> setResult;
		bool wasCacheWriteError;
		bool wasRemoteInvalidationError;
		if (setEntry != null)
		{
			try
			{
				setResult = cache.Set(setEntry);
				wasCacheWriteError = false;
			}
			catch (IOException ex2)
			{
				_Logger.Error(ex2);
				setResult = null;
				wasCacheWriteError = true;
			}
			try
			{
				invalidator.Invalidate(setEntry.Key);
				wasRemoteInvalidationError = false;
			}
			catch (RemoteInvalidationException ex3)
			{
				_Logger.Error(ex3);
				wasRemoteInvalidationError = true;
			}
		}
		else
		{
			setResult = null;
			wasCacheWriteError = true;
			wasRemoteInvalidationError = true;
		}
		return new WriteThroughOperationResult<TMetadata>(setResult, wasCacheWriteError, wasRemoteInvalidationError);
	}

	public Task<WriteThroughOperationResult<TMetadata>> WriteAsync<TValue, TMetadata, TSetArgs>(ICache<TMetadata, TSetArgs> cache, SetEntryBuilder<TValue, TSetArgs> setEntryBuilder, SourceWriterAsync sourceWriter, CancellationToken cancellationToken) where TMetadata : BasicMetadata where TSetArgs : BasicSetArgs
	{
		return WriteAsync(cache, setEntryBuilder, NullRemoteInvalidator.Instance, sourceWriter, cancellationToken);
	}

	public async Task<WriteThroughOperationResult<TMetadata>> WriteAsync<TValue, TMetadata, TSetArgs>(ICache<TMetadata, TSetArgs> cache, SetEntryBuilder<TValue, TSetArgs> setEntryBuilder, IRemoteInvalidator invalidator, SourceWriterAsync sourceWriter, CancellationToken cancellationToken) where TMetadata : BasicMetadata where TSetArgs : BasicSetArgs
	{
		NullChecker.ThrowIfNull(cache, "cache");
		NullChecker.ThrowIfNull(setEntryBuilder, "setEntryBuilder");
		NullChecker.ThrowIfNull(invalidator, "invalidator");
		NullChecker.ThrowIfNull(sourceWriter, "sourceWriter");
		await sourceWriter(cancellationToken);
		SetEntry<TValue, TSetArgs> entry;
		try
		{
			entry = setEntryBuilder();
		}
		catch (Exception innerException)
		{
			Exception ex = new IOException("Exception occurred while constructing set entry.", innerException);
			_Logger.Error(ex);
			entry = null;
		}
		SetResult<TMetadata> setResult;
		bool wasCacheWriteError;
		bool wasRemoteInvalidationError;
		if (entry != null)
		{
			try
			{
				setResult = await cache.SetAsync(entry, CancellationToken.None);
				wasCacheWriteError = false;
			}
			catch (IOException ex2)
			{
				_Logger.Error(ex2);
				setResult = null;
				wasCacheWriteError = true;
			}
			try
			{
				await invalidator.InvalidateAsync(entry.Key, CancellationToken.None).ConfigureAwait(continueOnCapturedContext: false);
				wasRemoteInvalidationError = false;
			}
			catch (RemoteInvalidationException ex3)
			{
				_Logger.Error(ex3);
				wasRemoteInvalidationError = true;
			}
		}
		else
		{
			setResult = null;
			wasCacheWriteError = true;
			wasRemoteInvalidationError = true;
		}
		return new WriteThroughOperationResult<TMetadata>(setResult, wasCacheWriteError, wasRemoteInvalidationError);
	}
}
