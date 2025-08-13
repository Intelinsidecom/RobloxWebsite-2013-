using System.Threading;
using System.Threading.Tasks;

namespace Roblox.CachingV2.Core;

public interface IReadAroundWithCreationOperation
{
	ReadAroundWithCreationOperationResult<TFinalValue> Execute<TFinalValue, TRawValue, TMetadata, TSetArgs>(ICache<TMetadata, TSetArgs> cache, string key, SourceReaderOrCreator<TFinalValue> sourceReaderOrCreator, RawToFinalValueConverter<TRawValue, TFinalValue> rawToFinalValueConverter) where TMetadata : BasicMetadata where TSetArgs : BasicSetArgs;

	ReadAroundWithCreationOperationResult<TFinalValue> Execute<TFinalValue, TRawValue, TMetadata, TSetArgs>(ICache<TMetadata, TSetArgs> cache, string key, IRemoteInvalidator invalidator, SourceReaderOrCreator<TFinalValue> sourceReaderOrCreator, RawToFinalValueConverter<TRawValue, TFinalValue> rawToFinalValueConverter) where TMetadata : BasicMetadata where TSetArgs : BasicSetArgs;

	Task<ReadAroundWithCreationOperationResult<TFinalValue>> ExecuteAsync<TFinalValue, TRawValue, TMetadata, TSetArgs>(ICache<TMetadata, TSetArgs> cache, string key, SourceReaderOrCreatorAsync<TFinalValue> sourceReaderOrCreator, RawToFinalValueConverter<TRawValue, TFinalValue> rawToFinalValueConverter, CancellationToken cancellationToken) where TMetadata : BasicMetadata where TSetArgs : BasicSetArgs;

	Task<ReadAroundWithCreationOperationResult<TFinalValue>> ExecuteAsync<TFinalValue, TRawValue, TMetadata, TSetArgs>(ICache<TMetadata, TSetArgs> cache, string key, IRemoteInvalidator invalidator, SourceReaderOrCreatorAsync<TFinalValue> sourceReaderOrCreator, RawToFinalValueConverter<TRawValue, TFinalValue> rawToFinalValueConverter, CancellationToken cancellationToken) where TMetadata : BasicMetadata where TSetArgs : BasicSetArgs;
}
