using System;
using System.Collections.Generic;
using System.Linq;
using Roblox.ApiClientBase;
using Roblox.Common;
using Roblox.DataV2.Core;
using Roblox.EventLog;
using Roblox.Platform.Core;
using Roblox.Platform.Localization.Core;
using Roblox.TranslationStorage.Client;

namespace Roblox.Platform.TranslationStorage;

/// <inheritdoc />
/// <seealso cref="T:Roblox.Platform.TranslationStorage.ITranslationStorageAccessor" />
internal class TranslationStorageAccessor : ITranslationStorageAccessor
{
	private readonly ITranslationStorageClient _Client;

	private readonly ILogger _Logger;

	private const string _InvalidExclusiveStartId = "Invalid ExclusiveStartId.";

	/// <summary>
	/// Initializes a new instance of the <see cref="T:Roblox.Platform.TranslationStorage.TranslationStorageAccessor" /> class.
	/// </summary>
	/// <param name="client">The translation storage client.</param>
	/// <param name="logger">The logger.</param>
	/// <exception cref="T:Roblox.Platform.Core.PlatformArgumentNullException">
	/// client
	/// or
	/// logger
	/// </exception>
	public TranslationStorageAccessor(ITranslationStorageClient client, ILogger logger)
	{
		_Client = client ?? throw new PlatformArgumentNullException("client");
		_Logger = logger ?? throw new PlatformArgumentNullException("logger");
	}

	/// <inheritdoc cref="M:Roblox.Platform.TranslationStorage.ITranslationStorageAccessor.GetTranslation(Roblox.Platform.Localization.Core.ISupportedLocale,Roblox.Platform.TranslationStorage.ContentSourceType,Roblox.Platform.TranslationStorage.ContentVariantType,System.String)" />
	public string GetTranslation(ISupportedLocale supportedLocale, ContentSourceType contentSourceType, ContentVariantType contentVariantType, string contentSourceTargetId)
	{
		if (supportedLocale == null)
		{
			throw new PlatformArgumentNullException("supportedLocale");
		}
		return GetTranslation(contentSourceType, contentVariantType, contentSourceTargetId, supportedLocale.LocaleCode);
	}

	/// <inheritdoc cref="M:Roblox.Platform.TranslationStorage.ITranslationStorageAccessor.GetTranslation(Roblox.Platform.Localization.Core.ILanguageFamily,Roblox.Platform.TranslationStorage.ContentSourceType,Roblox.Platform.TranslationStorage.ContentVariantType,System.String)" />
	public string GetTranslation(ILanguageFamily languageFamily, ContentSourceType contentSourceType, ContentVariantType contentVariantType, string contentSourceTargetId)
	{
		if (languageFamily == null)
		{
			throw new PlatformArgumentNullException("languageFamily");
		}
		return GetTranslation(contentSourceType, contentVariantType, contentSourceTargetId, languageFamily.LanguageCode);
	}

	/// <inheritdoc cref="M:Roblox.Platform.TranslationStorage.ITranslationStorageAccessor.GetTranslationsForContentSourceTargetIds(Roblox.Platform.Localization.Core.ISupportedLocale,Roblox.Platform.TranslationStorage.ContentSourceType,Roblox.Platform.TranslationStorage.ContentVariantType,System.Collections.Generic.IReadOnlyCollection{System.String})" />
	public IReadOnlyCollection<ITranslationForContentSourceTargetId> GetTranslationsForContentSourceTargetIds(ISupportedLocale supportedLocale, ContentSourceType contentSourceType, ContentVariantType contentVariantType, IReadOnlyCollection<string> contentSourceTargetIds)
	{
		if (supportedLocale == null)
		{
			throw new PlatformArgumentNullException("supportedLocale");
		}
		return GetTranslationsForContentSourceTargetIds(contentSourceType, contentVariantType, contentSourceTargetIds, supportedLocale.LocaleCode);
	}

	/// <inheritdoc cref="M:Roblox.Platform.TranslationStorage.ITranslationStorageAccessor.GetTranslationsForContentSourceTargetIds(Roblox.Platform.Localization.Core.ILanguageFamily,Roblox.Platform.TranslationStorage.ContentSourceType,Roblox.Platform.TranslationStorage.ContentVariantType,System.Collections.Generic.IReadOnlyCollection{System.String})" />
	public IReadOnlyCollection<ITranslationForContentSourceTargetId> GetTranslationsForContentSourceTargetIds(ILanguageFamily languageFamily, ContentSourceType contentSourceType, ContentVariantType contentVariantType, IReadOnlyCollection<string> contentSourceTargetIds)
	{
		if (languageFamily == null)
		{
			throw new PlatformArgumentNullException("languageFamily");
		}
		return GetTranslationsForContentSourceTargetIds(contentSourceType, contentVariantType, contentSourceTargetIds, languageFamily.LanguageCode);
	}

	/// <inheritdoc cref="M:Roblox.Platform.TranslationStorage.ITranslationStorageAccessor.GetTranslationForContentLocales(Roblox.Platform.TranslationStorage.ContentSourceType,Roblox.Platform.TranslationStorage.ContentVariantType,System.String)" />
	public IReadOnlyCollection<ITranslationForContentLocale> GetTranslationForContentLocales(ContentSourceType contentSourceType, ContentVariantType contentVariantType, string contentSourceTargetId)
	{
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Expected O, but got Unknown
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Expected O, but got Unknown
		if (string.IsNullOrWhiteSpace(contentSourceTargetId))
		{
			throw new PlatformArgumentException("contentSourceTargetId");
		}
		ContentVariantType clientContentVariantType = ConvertToClientContentVariantType(contentVariantType);
		GetTranslationsForContentLocalesRequest getTranslationsRequest = new GetTranslationsForContentLocalesRequest
		{
			ContentSourceType = new ContentSourceType
			{
				Value = contentSourceType.ToString()
			},
			ContentSourceTargetId = contentSourceTargetId,
			ContentVariantType = clientContentVariantType
		};
		try
		{
			GetTranslationsForContentLocalesResponse getTranslationsResponse = _Client.GetTranslationsForContentLocales(getTranslationsRequest);
			return ConvertToPlatform(getTranslationsResponse);
		}
		catch (Exception ex)
		{
			_Logger.Error(ex);
			throw new PlatformOperationUnavailableException("Unable to get translations from the storage service", ex);
		}
	}

	/// <inheritdoc cref="M:Roblox.Platform.TranslationStorage.ITranslationStorageAccessor.GetTranslationHistory(Roblox.Platform.Localization.Core.ISupportedLocale,Roblox.Platform.TranslationStorage.ContentSourceType,Roblox.Platform.TranslationStorage.ContentVariantType,System.String,System.String,System.Int32,Roblox.DataV2.Core.SortOrder)" />
	public IGetTranslationHistoryResult GetTranslationHistory(ISupportedLocale supportedLocale, ContentSourceType contentSourceType, ContentVariantType contentVariantType, string contentSourceTargetId, string exclusiveStartId, int count, Roblox.DataV2.Core.SortOrder sortOrder)
	{
		if (supportedLocale == null)
		{
			throw new PlatformArgumentNullException("supportedLocale");
		}
		return DoGetTranslationHistory(supportedLocale.LocaleCode, contentSourceType, contentVariantType, contentSourceTargetId, exclusiveStartId, count, sortOrder);
	}

	/// <inheritdoc cref="M:Roblox.Platform.TranslationStorage.ITranslationStorageAccessor.GetTranslationHistory(Roblox.Platform.Localization.Core.ILanguageFamily,Roblox.Platform.TranslationStorage.ContentSourceType,Roblox.Platform.TranslationStorage.ContentVariantType,System.String,System.String,System.Int32,Roblox.DataV2.Core.SortOrder)" />
	public IGetTranslationHistoryResult GetTranslationHistory(ILanguageFamily languageFamily, ContentSourceType contentSourceType, ContentVariantType contentVariantType, string contentSourceTargetId, string exclusiveStartId, int count, Roblox.DataV2.Core.SortOrder sortOrder)
	{
		if (languageFamily == null)
		{
			throw new PlatformArgumentNullException("languageFamily");
		}
		return DoGetTranslationHistory(languageFamily.LanguageCode, contentSourceType, contentVariantType, contentSourceTargetId, exclusiveStartId, count, sortOrder);
	}

	private string GetTranslation(ContentSourceType contentSourceType, ContentVariantType contentVariantType, string contentSourceTargetId, string supportedLocaleOrLangaugeCode)
	{
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Expected O, but got Unknown
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Expected O, but got Unknown
		if (string.IsNullOrWhiteSpace(contentSourceTargetId))
		{
			throw new PlatformArgumentException("contentSourceTargetId");
		}
		ContentVariantType clientContentVariantType = ConvertToClientContentVariantType(contentVariantType);
		GetTranslationRequest getTranslationRequest = new GetTranslationRequest
		{
			ContentSourceType = new ContentSourceType
			{
				Value = contentSourceType.ToString()
			},
			ContentLocaleType = supportedLocaleOrLangaugeCode,
			ContentSourceTargetId = contentSourceTargetId,
			ContentVariantType = clientContentVariantType
		};
		try
		{
			return _Client.GetTranslation(getTranslationRequest).TranslationValue;
		}
		catch (Exception ex)
		{
			_Logger.Error(ex);
			throw new PlatformOperationUnavailableException("Unable to get translation from the storage service", ex);
		}
	}

	private IReadOnlyCollection<ITranslationForContentSourceTargetId> GetTranslationsForContentSourceTargetIds(ContentSourceType contentSourceType, ContentVariantType contentVariantType, IReadOnlyCollection<string> contentSourceTargetIds, string supportedLocaleOrLangaugeCode)
	{
		//IL_0088: Unknown result type (might be due to invalid IL or missing references)
		//IL_008d: Unknown result type (might be due to invalid IL or missing references)
		//IL_008e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0093: Unknown result type (might be due to invalid IL or missing references)
		//IL_0094: Unknown result type (might be due to invalid IL or missing references)
		//IL_0099: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b1: Expected O, but got Unknown
		//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c8: Expected O, but got Unknown
		if (contentSourceTargetIds == null || contentSourceTargetIds.Any(string.IsNullOrWhiteSpace))
		{
			throw new PlatformArgumentException("contentSourceTargetIds");
		}
		if ((from x in contentSourceTargetIds
			group x by x).Any((IGrouping<string, string> c) => c.Count() > 1))
		{
			throw new PlatformArgumentException("contentSourceTargetIds");
		}
		if (!contentSourceTargetIds.Any())
		{
			return new List<ITranslationForContentSourceTargetId>();
		}
		ContentVariantType clientContentVariantType = ConvertToClientContentVariantType(contentVariantType);
		GetTranslationsForContentSourceTargetIdsRequest getTranslationsRequest = new GetTranslationsForContentSourceTargetIdsRequest
		{
			ContentSourceType = new ContentSourceType
			{
				Value = contentSourceType.ToString()
			},
			ContentLocaleType = supportedLocaleOrLangaugeCode,
			ContentSourceTargetIds = contentSourceTargetIds,
			ContentVariantType = clientContentVariantType
		};
		try
		{
			GetTranslationsForContentSourceTargetIdsResponse getTranslationsResponse = _Client.GetTranslationsForContentSourceTargetIds(getTranslationsRequest);
			return ConvertToPlatform(getTranslationsResponse);
		}
		catch (Exception ex)
		{
			_Logger.Error(ex);
			throw new PlatformOperationUnavailableException("Unable to get translations from the storage service", ex);
		}
	}

	private IReadOnlyCollection<ITranslationForContentLocale> ConvertToPlatform(GetTranslationsForContentLocalesResponse response)
	{
		List<ITranslationForContentLocale> translations = new List<ITranslationForContentLocale>();
		foreach (ContentLocaleTranslationValue responseEntry in response.Translations)
		{
			if (!string.IsNullOrEmpty(responseEntry.TranslationValue))
			{
				translations.Add(new TranslationForContentLocale
				{
					ContentLocale = responseEntry.ContentLocale,
					TranslationValue = responseEntry.TranslationValue
				});
			}
		}
		return translations;
	}

	private IReadOnlyCollection<ITranslationForContentSourceTargetId> ConvertToPlatform(GetTranslationsForContentSourceTargetIdsResponse response)
	{
		List<ITranslationForContentSourceTargetId> translations = new List<ITranslationForContentSourceTargetId>();
		foreach (ContentSourceTargetIdTranslationValue translation in response.Translations)
		{
			if (!string.IsNullOrEmpty(translation.TranslationValue))
			{
				translations.Add(new TranslationForContentSourceTargetId
				{
					ContentSourceTargetId = translation.ContentSourceTargetId,
					TranslationValue = translation.TranslationValue
				});
			}
		}
		return translations;
	}

	private ContentVariantType ConvertToClientContentVariantType(ContentVariantType contentVariantType)
	{
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		ContentVariantType? clientContentVariantType = EnumUtils.StrictTryParseEnum<ContentVariantType>(contentVariantType.ToString());
		if (!clientContentVariantType.HasValue)
		{
			throw new PlatformArgumentException("contentVariantType");
		}
		return clientContentVariantType.Value;
	}

	private IGetTranslationHistoryResult DoGetTranslationHistory(string supportedLocaleOrLanguageCode, ContentSourceType contentSourceType, ContentVariantType contentVariantType, string contentSourceTargetId, string exclusiveStartId, int count, Roblox.DataV2.Core.SortOrder sortOrder)
	{
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Expected O, but got Unknown
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		//IL_006d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Expected O, but got Unknown
		if (string.IsNullOrWhiteSpace(contentSourceTargetId))
		{
			throw new PlatformArgumentException("contentSourceTargetId");
		}
		if (count <= 0)
		{
			throw new PlatformArgumentException("Count should be at least 1.");
		}
		ContentVariantType clientContentVariantType = ConvertToClientContentVariantType(contentVariantType);
		GetTranslationHistoryRequest getTranslationHistoryRequest = new GetTranslationHistoryRequest
		{
			ContentSourceType = new ContentSourceType
			{
				Value = contentSourceType.ToString()
			},
			ContentVariantType = clientContentVariantType,
			ContentSourceTargetId = contentSourceTargetId,
			ContentLocaleType = supportedLocaleOrLanguageCode,
			ExclusiveStartId = exclusiveStartId,
			PageSize = count,
			SortOrder = sortOrder
		};
		try
		{
			GetTranslationHistoryResponse getTranslationHistoryResponse = _Client.GetTranslationHistory(getTranslationHistoryRequest);
			return ConvertToPlatform(getTranslationHistoryResponse);
		}
		catch (Exception ex)
		{
			if (ex is ApiClientException exception && exception.StatusDescription == "Invalid ExclusiveStartId.")
			{
				throw new PlatformInvalidOperationException("Invalid exclusiveStart Id", exception);
			}
			_Logger.Error(ex);
			throw new PlatformOperationUnavailableException("Unable to get translation history from the storage service", ex);
		}
	}

	private IGetTranslationHistoryResult ConvertToPlatform(GetTranslationHistoryResponse response)
	{
		List<ITranslationSummary> translationSummaries = new List<ITranslationSummary>();
		foreach (TranslationSummary clientTranslationSummary in response.History)
		{
			IChangeAgent changeAgent = CreateChangeAgent(clientTranslationSummary.ChangeAgentType, clientTranslationSummary.ChangeAgentTargetId);
			translationSummaries.Add(new TranslationSummary
			{
				TranslationValue = clientTranslationSummary.TranslationValue,
				ChangeAgent = changeAgent,
				Created = clientTranslationSummary.Created
			});
		}
		return new GetTranslationHistoryResult
		{
			History = translationSummaries,
			LastEvaluatedId = response.LastEvaluatedId
		};
	}

	private IChangeAgent CreateChangeAgent(string changeAgentType, long? changeAgentTargetId)
	{
		if (changeAgentType == null)
		{
			return null;
		}
		if (!changeAgentTargetId.HasValue)
		{
			_Logger.Error("Change agent target id should not be null when change agent type is not null.");
			return null;
		}
		ChangeAgentType? changeAgentTypeEnum = EnumUtils.StrictTryParseEnum<ChangeAgentType>(changeAgentType);
		if (!changeAgentTypeEnum.HasValue)
		{
			_Logger.Error($"Invalid change agent type: {changeAgentType}.");
			return null;
		}
		return new ChangeAgent(changeAgentTypeEnum.Value, changeAgentTargetId.Value);
	}
}
