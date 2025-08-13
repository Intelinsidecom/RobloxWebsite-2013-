using System.Threading;
using System.Threading.Tasks;
using Roblox.DataV2.Core;

namespace Roblox.CachingV2.Core;

public interface IReadThroughWithCreationOperation
{
	ReadThroughWithCreationOperationResult<TFinalValue, TMetadata> Execute<TFinalValue, TRawValue, TMetadata, TSetArgs>(ICache<TMetadata, TSetArgs> cache, string key, SourceReaderOrCreator<TFinalValue> sourceReaderOrCreator, SetArgsConstructor<GetOrCreateResult<TFinalValue>, TSetArgs> setArgsConstructorFunc, RawToFinalValueConverter<TRawValue, TFinalValue> rawToFinalValueConverter, FinalToRawValueConverter<TFinalValue, TRawValue> finalToRawValueConverter) where TMetadata : BasicMetadata where TSetArgs : BasicSetArgs;

	ReadThroughWithCreationOperationResult<TFinalValue, TMetadata> Execute<TFinalValue, TRawValue, TMetadata, TSetArgs>(ICache<TMetadata, TSetArgs> cache, string key, IRemoteInvalidator invalidator, SourceReaderOrCreator<TFinalValue> sourceReaderOrCreator, SetArgsConstructor<GetOrCreateResult<TFinalValue>, TSetArgs> setArgsConstructorFunc, RawToFinalValueConverter<TRawValue, TFinalValue> rawToFinalValueConverter, FinalToRawValueConverter<TFinalValue, TRawValue> finalToRawValueConverter) where TMetadata : BasicMetadata where TSetArgs : BasicSetArgs;

	Task<ReadThroughWithCreationOperationResult<TFinalValue, TMetadata>> ExecuteAsync<TFinalValue, TRawValue, TMetadata, TSetArgs>(ICache<TMetadata, TSetArgs> cache, string key, SourceReaderOrCreatorAsync<TFinalValue> sourceReaderOrCreator, SetArgsConstructorAsync<GetOrCreateResult<TFinalValue>, TSetArgs> setArgsConstructorFunc, RawToFinalValueConverter<TRawValue, TFinalValue> rawToFinalValueConverter, FinalToRawValueConverter<TFinalValue, TRawValue> finalToRawValueConverter, CancellationToken cancellationToken) where TMetadata : BasicMetadata where TSetArgs : BasicSetArgs;

	Task<ReadThroughWithCreationOperationResult<TFinalValue, TMetadata>> ExecuteAsync<TFinalValue, TRawValue, TMetadata, TSetArgs>(ICache<TMetadata, TSetArgs> cache, string key, IRemoteInvalidator invalidator, SourceReaderOrCreatorAsync<TFinalValue> sourceReaderOrCreator, SetArgsConstructorAsync<GetOrCreateResult<TFinalValue>, TSetArgs> setArgsConstructorFunc, RawToFinalValueConverter<TRawValue, TFinalValue> rawToFinalValueConverter, FinalToRawValueConverter<TFinalValue, TRawValue> finalToRawValueConverter, CancellationToken cancellationToken) where TMetadata : BasicMetadata where TSetArgs : BasicSetArgs;
}
