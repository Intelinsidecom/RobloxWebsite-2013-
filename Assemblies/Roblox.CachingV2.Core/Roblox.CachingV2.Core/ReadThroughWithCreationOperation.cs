using System;
using System.IO;
using System.Threading;
using System.Threading.Tasks;
using Roblox.DataV2.Core;
using Roblox.EventLog;

namespace Roblox.CachingV2.Core;

internal class ReadThroughWithCreationOperation : IReadThroughWithCreationOperation
{
	private readonly ILogger _Logger;

	public ReadThroughWithCreationOperation(ILogger logger)
	{
		_Logger = logger ?? throw new ArgumentNullException("logger");
	}

	public ReadThroughWithCreationOperationResult<TFinalValue, TMetadata> Execute<TFinalValue, TRawValue, TMetadata, TSetArgs>(ICache<TMetadata, TSetArgs> cache, string key, SourceReaderOrCreator<TFinalValue> sourceReaderOrCreator, SetArgsConstructor<GetOrCreateResult<TFinalValue>, TSetArgs> setArgsConstructorFunc, RawToFinalValueConverter<TRawValue, TFinalValue> rawToFinalValueConverter, FinalToRawValueConverter<TFinalValue, TRawValue> finalToRawValueConverter) where TMetadata : BasicMetadata where TSetArgs : BasicSetArgs
	{
		return Execute(cache, key, NullRemoteInvalidator.Instance, sourceReaderOrCreator, setArgsConstructorFunc, rawToFinalValueConverter, finalToRawValueConverter);
	}

	public ReadThroughWithCreationOperationResult<TFinalValue, TMetadata> Execute<TFinalValue, TRawValue, TMetadata, TSetArgs>(ICache<TMetadata, TSetArgs> cache, string key, IRemoteInvalidator invalidator, SourceReaderOrCreator<TFinalValue> sourceReaderOrCreator, SetArgsConstructor<GetOrCreateResult<TFinalValue>, TSetArgs> setArgsConstructorFunc, RawToFinalValueConverter<TRawValue, TFinalValue> rawToFinalValueConverter, FinalToRawValueConverter<TFinalValue, TRawValue> finalToRawValueConverter) where TMetadata : BasicMetadata where TSetArgs : BasicSetArgs
	{
		NullChecker.ThrowIfNull(cache, "cache");
		NullChecker.ThrowIfNull(key, "key");
		NullChecker.ThrowIfNull(invalidator, "invalidator");
		NullChecker.ThrowIfNull(sourceReaderOrCreator, "sourceReaderOrCreator");
		NullChecker.ThrowIfNull(setArgsConstructorFunc, "setArgsConstructorFunc");
		NullChecker.ThrowIfNull(rawToFinalValueConverter, "rawToFinalValueConverter");
		NullChecker.ThrowIfNull(finalToRawValueConverter, "finalToRawValueConverter");
		MetadataCacheGetResult<TRawValue, TMetadata> metadataCacheGetResult;
		bool wasCacheReadError;
		try
		{
			metadataCacheGetResult = cache.Get<TRawValue>(key);
			wasCacheReadError = false;
		}
		catch (IOException ex)
		{
			_Logger.Error(ex);
			metadataCacheGetResult = null;
			wasCacheReadError = true;
		}
		TMetadata metadata;
		bool flag;
		SetResult<TMetadata> setResult;
		bool wasCacheWriteError;
		bool wasRemoteInvalidationError;
		if (metadataCacheGetResult != null && metadataCacheGetResult.IsFound && rawToFinalValueConverter(metadataCacheGetResult.Entry, out var finalValue))
		{
			metadata = metadataCacheGetResult.Metadata;
			flag = false;
			setResult = null;
			wasCacheWriteError = false;
			wasRemoteInvalidationError = false;
		}
		else
		{
			GetOrCreateResult<TFinalValue> getOrCreateResult = sourceReaderOrCreator();
			finalValue = getOrCreateResult.Value;
			flag = getOrCreateResult.Created;
			TSetArgs val;
			try
			{
				val = setArgsConstructorFunc(getOrCreateResult);
			}
			catch (SetArgsConstructionException ex2)
			{
				_Logger.Error(ex2);
				val = null;
			}
			if (val != null)
			{
				TRawValue value = finalToRawValueConverter(finalValue);
				try
				{
					setResult = cache.Set(new SetEntry<TRawValue, TSetArgs>(key, value, val));
					wasCacheWriteError = false;
				}
				catch (IOException ex3)
				{
					_Logger.Error(ex3);
					setResult = null;
					wasCacheWriteError = true;
				}
			}
			else
			{
				setResult = null;
				wasCacheWriteError = true;
			}
			if (flag)
			{
				try
				{
					invalidator.Invalidate(key);
					wasRemoteInvalidationError = false;
				}
				catch (RemoteInvalidationException ex4)
				{
					_Logger.Error(ex4);
					wasRemoteInvalidationError = true;
				}
			}
			else
			{
				wasRemoteInvalidationError = false;
			}
			metadata = ((setResult != null) ? setResult.Metadata : null);
		}
		return new ReadThroughWithCreationOperationResult<TFinalValue, TMetadata>(finalValue, metadataCacheGetResult?.IsFound ?? false, setResult != null, metadata, flag, wasCacheReadError, wasCacheWriteError, wasRemoteInvalidationError);
	}

	public Task<ReadThroughWithCreationOperationResult<TFinalValue, TMetadata>> ExecuteAsync<TFinalValue, TRawValue, TMetadata, TSetArgs>(ICache<TMetadata, TSetArgs> cache, string key, SourceReaderOrCreatorAsync<TFinalValue> sourceReaderOrCreator, SetArgsConstructorAsync<GetOrCreateResult<TFinalValue>, TSetArgs> setArgsConstructorFunc, RawToFinalValueConverter<TRawValue, TFinalValue> rawToFinalValueConverter, FinalToRawValueConverter<TFinalValue, TRawValue> finalToRawValueConverter, CancellationToken cancellationToken) where TMetadata : BasicMetadata where TSetArgs : BasicSetArgs
	{
		return ExecuteAsync(cache, key, NullRemoteInvalidator.Instance, sourceReaderOrCreator, setArgsConstructorFunc, rawToFinalValueConverter, finalToRawValueConverter, cancellationToken);
	}

	public async Task<ReadThroughWithCreationOperationResult<TFinalValue, TMetadata>> ExecuteAsync<TFinalValue, TRawValue, TMetadata, TSetArgs>(ICache<TMetadata, TSetArgs> cache, string key, IRemoteInvalidator invalidator, SourceReaderOrCreatorAsync<TFinalValue> sourceReaderOrCreator, SetArgsConstructorAsync<GetOrCreateResult<TFinalValue>, TSetArgs> setArgsConstructorFunc, RawToFinalValueConverter<TRawValue, TFinalValue> rawToFinalValueConverter, FinalToRawValueConverter<TFinalValue, TRawValue> finalToRawValueConverter, CancellationToken cancellationToken) where TMetadata : BasicMetadata where TSetArgs : BasicSetArgs
	{
		NullChecker.ThrowIfNull(cache, "cache");
		NullChecker.ThrowIfNull(key, "key");
		NullChecker.ThrowIfNull(invalidator, "invalidator");
		NullChecker.ThrowIfNull(sourceReaderOrCreator, "sourceReaderOrCreator");
		NullChecker.ThrowIfNull(setArgsConstructorFunc, "setArgsConstructorFunc");
		NullChecker.ThrowIfNull(rawToFinalValueConverter, "rawToFinalValueConverter");
		NullChecker.ThrowIfNull(finalToRawValueConverter, "finalToRawValueConverter");
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
			result = null;
			wasCacheReadError = true;
		}
		TMetadata metadata;
		SetResult<TMetadata> setResult;
		bool wasCreated;
		bool wasCacheWriteError;
		bool wasRemoteInvalidationError;
		if ((result?.IsFound ?? false) && rawToFinalValueConverter(result.Entry, out var finalValue))
		{
			metadata = result.Metadata;
			setResult = null;
			wasCreated = false;
			wasCacheWriteError = false;
			wasRemoteInvalidationError = false;
		}
		else
		{
			GetOrCreateResult<TFinalValue> getOrCreateResult = await sourceReaderOrCreator(cancellationToken);
			finalValue = getOrCreateResult.Value;
			wasCreated = getOrCreateResult.Created;
			TSetArgs val;
			try
			{
				val = await setArgsConstructorFunc(getOrCreateResult, CancellationToken.None);
			}
			catch (SetArgsConstructionException ex2)
			{
				_Logger.Error(ex2);
				val = null;
			}
			if (val != null)
			{
				TRawValue value = finalToRawValueConverter(finalValue);
				try
				{
					setResult = await cache.SetAsync(new SetEntry<TRawValue, TSetArgs>(key, value, val), CancellationToken.None).ConfigureAwait(!wasCreated);
					wasCacheWriteError = false;
				}
				catch (IOException ex3)
				{
					_Logger.Error(ex3);
					setResult = null;
					wasCacheWriteError = true;
				}
			}
			else
			{
				setResult = null;
				wasCacheWriteError = true;
			}
			if (wasCreated)
			{
				try
				{
					await invalidator.InvalidateAsync(key, CancellationToken.None).ConfigureAwait(continueOnCapturedContext: false);
					wasRemoteInvalidationError = false;
				}
				catch (RemoteInvalidationException ex4)
				{
					_Logger.Error(ex4);
					wasRemoteInvalidationError = true;
				}
			}
			else
			{
				wasRemoteInvalidationError = false;
			}
			SetResult<TMetadata> setResult2 = setResult;
			metadata = ((setResult2 != null) ? setResult2.Metadata : null);
		}
		return new ReadThroughWithCreationOperationResult<TFinalValue, TMetadata>(finalValue, result?.IsFound ?? false, setResult != null, metadata, wasCreated, wasCacheReadError, wasCacheWriteError, wasRemoteInvalidationError);
	}
}
