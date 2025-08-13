using System;
using System.IO;
using System.Threading;
using System.Threading.Tasks;
using Roblox.DataV2.Core;
using Roblox.EventLog;

namespace Roblox.CachingV2.Core;

internal class ReadAroundWithCreationOperation : IReadAroundWithCreationOperation
{
	private readonly ILogger _Logger;

	public ReadAroundWithCreationOperation(ILogger logger)
	{
		_Logger = logger ?? throw new ArgumentNullException("logger");
	}

	public ReadAroundWithCreationOperationResult<TFinalValue> Execute<TFinalValue, TRawValue, TMetadata, TSetArgs>(ICache<TMetadata, TSetArgs> cache, string key, SourceReaderOrCreator<TFinalValue> sourceReaderOrCreator, RawToFinalValueConverter<TRawValue, TFinalValue> rawToFinalValueConverter) where TMetadata : BasicMetadata where TSetArgs : BasicSetArgs
	{
		return Execute(cache, key, NullRemoteInvalidator.Instance, sourceReaderOrCreator, rawToFinalValueConverter);
	}

	public ReadAroundWithCreationOperationResult<TFinalValue> Execute<TFinalValue, TRawValue, TMetadata, TSetArgs>(ICache<TMetadata, TSetArgs> cache, string key, IRemoteInvalidator invalidator, SourceReaderOrCreator<TFinalValue> sourceReaderOrCreator, RawToFinalValueConverter<TRawValue, TFinalValue> rawToFinalValueConverter) where TMetadata : BasicMetadata where TSetArgs : BasicSetArgs
	{
		NullChecker.ThrowIfNull(cache, "cache");
		NullChecker.ThrowIfNull(key, "key");
		NullChecker.ThrowIfNull(invalidator, "invalidator");
		NullChecker.ThrowIfNull(sourceReaderOrCreator, "sourceReaderOrCreator");
		NullChecker.ThrowIfNull(rawToFinalValueConverter, "rawToFinalValueConverter");
		MetadataCacheGetResult<TRawValue, TMetadata> metadataCacheGetResult;
		bool flag;
		try
		{
			metadataCacheGetResult = cache.Get<TRawValue>(key);
			flag = false;
		}
		catch (IOException ex)
		{
			_Logger.Error(ex);
			flag = true;
			metadataCacheGetResult = null;
		}
		bool flag2;
		bool wasCacheWriteError;
		bool wasRemoteInvalidationError;
		if (!flag && metadataCacheGetResult.IsFound && rawToFinalValueConverter(metadataCacheGetResult.Entry, out var finalValue))
		{
			flag2 = false;
			wasCacheWriteError = false;
			wasRemoteInvalidationError = false;
		}
		else
		{
			GetOrCreateResult<TFinalValue> getOrCreateResult = sourceReaderOrCreator();
			finalValue = getOrCreateResult.Value;
			flag2 = getOrCreateResult.Created;
			if (flag || metadataCacheGetResult.IsFound)
			{
				try
				{
					cache.Remove(key);
					wasCacheWriteError = false;
				}
				catch (IOException ex2)
				{
					_Logger.Error(ex2);
					wasCacheWriteError = true;
				}
			}
			else
			{
				wasCacheWriteError = false;
			}
			if (flag2)
			{
				try
				{
					invalidator.Invalidate(key);
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
				wasRemoteInvalidationError = false;
			}
		}
		return new ReadAroundWithCreationOperationResult<TFinalValue>(finalValue, metadataCacheGetResult?.IsFound ?? false, flag2, flag, wasCacheWriteError, wasRemoteInvalidationError);
	}

	public Task<ReadAroundWithCreationOperationResult<TFinalValue>> ExecuteAsync<TFinalValue, TRawValue, TMetadata, TSetArgs>(ICache<TMetadata, TSetArgs> cache, string key, SourceReaderOrCreatorAsync<TFinalValue> sourceReaderOrCreator, RawToFinalValueConverter<TRawValue, TFinalValue> rawToFinalValueConverter, CancellationToken cancellationToken) where TMetadata : BasicMetadata where TSetArgs : BasicSetArgs
	{
		return ExecuteAsync(cache, key, NullRemoteInvalidator.Instance, sourceReaderOrCreator, rawToFinalValueConverter, cancellationToken);
	}

	public async Task<ReadAroundWithCreationOperationResult<TFinalValue>> ExecuteAsync<TFinalValue, TRawValue, TMetadata, TSetArgs>(ICache<TMetadata, TSetArgs> cache, string key, IRemoteInvalidator invalidator, SourceReaderOrCreatorAsync<TFinalValue> sourceReaderOrCreator, RawToFinalValueConverter<TRawValue, TFinalValue> rawToFinalValueConverter, CancellationToken cancellationToken) where TMetadata : BasicMetadata where TSetArgs : BasicSetArgs
	{
		NullChecker.ThrowIfNull(cache, "cache");
		NullChecker.ThrowIfNull(key, "key");
		NullChecker.ThrowIfNull(invalidator, "invalidator");
		NullChecker.ThrowIfNull(sourceReaderOrCreator, "sourceReaderOrCreator");
		NullChecker.ThrowIfNull(rawToFinalValueConverter, "rawToFinalValueConverter");
		MetadataCacheGetResult<TRawValue, TMetadata> result;
		bool wasCacheReadError;
		try
		{
			result = await cache.GetAsync<TRawValue>(key, cancellationToken);
			wasCacheReadError = false;
		}
		catch (IOException ex)
		{
			_Logger.Error(ex);
			wasCacheReadError = true;
			result = null;
		}
		bool wasCreated;
		bool wasCacheWriteError;
		bool wasRemoteInvalidationError;
		if (!wasCacheReadError && result.IsFound && rawToFinalValueConverter(result.Entry, out var finalValue))
		{
			wasCreated = false;
			wasCacheWriteError = false;
			wasRemoteInvalidationError = false;
		}
		else
		{
			GetOrCreateResult<TFinalValue> getOrCreateResult = await sourceReaderOrCreator(cancellationToken);
			finalValue = getOrCreateResult.Value;
			wasCreated = getOrCreateResult.Created;
			if (wasCacheReadError || result.IsFound)
			{
				try
				{
					await cache.RemoveAsync(key, CancellationToken.None).ConfigureAwait(!wasCreated);
					wasCacheWriteError = false;
				}
				catch (IOException ex2)
				{
					_Logger.Error(ex2);
					wasCacheWriteError = true;
				}
			}
			else
			{
				wasCacheWriteError = false;
			}
			if (wasCreated)
			{
				try
				{
					await invalidator.InvalidateAsync(key, CancellationToken.None).ConfigureAwait(continueOnCapturedContext: false);
					wasRemoteInvalidationError = false;
				}
				catch (IOException ex3)
				{
					_Logger.Error(ex3);
					wasRemoteInvalidationError = true;
				}
			}
			else
			{
				wasRemoteInvalidationError = false;
			}
		}
		return new ReadAroundWithCreationOperationResult<TFinalValue>(finalValue, result?.IsFound ?? false, wasCreated, wasCacheReadError, wasCacheWriteError, wasRemoteInvalidationError);
	}
}
