using System;
using System.Collections.Generic;
using System.Linq;
using Roblox.Common;
using Roblox.EventLog;
using Roblox.Platform.Core;
using Roblox.Platform.Localization.Core;
using Roblox.TranslationStorage.Client;

namespace Roblox.Platform.TranslationStorage;

/// <inheritdoc />
/// <summary>
/// A class for creating and updating translations to the Translation Storage service.
/// </summary>
/// <seealso cref="T:Roblox.Platform.TranslationStorage.ITranslationStorageBuilder" />
internal class TranslationStorageBuilder : ITranslationStorageBuilder
{
	private readonly ITranslationStorageClient _Client;

	private readonly ITranslationStorageResponseConverter _TranslationStorageResponseConverter;

	private readonly ILogger _Logger;

	/// <summary>
	/// Initializes a new instance of the <see cref="T:Roblox.Platform.TranslationStorage.TranslationStorageBuilder" /> class.
	/// </summary>
	/// <param name="client">The client.</param>
	/// <param name="translationStorageResponseConverter"></param>
	/// <param name="logger">The logger.</param>
	/// <exception cref="T:Roblox.Platform.Core.PlatformArgumentNullException">
	/// client
	/// or
	/// translationStorageResponseConverter
	/// or
	/// logger
	/// </exception>
	public TranslationStorageBuilder(ITranslationStorageClient client, ITranslationStorageResponseConverter translationStorageResponseConverter, ILogger logger)
	{
		_Client = client ?? throw new PlatformArgumentNullException("client");
		_TranslationStorageResponseConverter = translationStorageResponseConverter ?? throw new PlatformArgumentNullException("translationStorageResponseConverter");
		_Logger = logger ?? throw new PlatformArgumentNullException("logger");
	}

	/// <inheritdoc cref="M:Roblox.Platform.TranslationStorage.TranslationStorageBuilder.CreateTranslation(Roblox.Platform.Localization.Core.ISupportedLocale,Roblox.Platform.TranslationStorage.ContentSourceType,Roblox.Platform.TranslationStorage.ContentVariantType,System.String,System.String,System.Boolean,Roblox.Platform.TranslationStorage.IChangeAgent)" />
	public void CreateTranslation(ISupportedLocale supportedLocale, ContentSourceType contentSourceType, ContentVariantType contentVariantType, string contentSourceTargetId, string translationValue, bool isSourceContentVariantAndLocale = false, IChangeAgent changeAgent = null)
	{
		if (supportedLocale == null)
		{
			throw new PlatformArgumentNullException("supportedLocale");
		}
		CreateTranslation(contentSourceType, contentVariantType, contentSourceTargetId, supportedLocale.LocaleCode, translationValue, isSourceContentVariantAndLocale, changeAgent);
	}

	/// <inheritdoc cref="M:Roblox.Platform.TranslationStorage.TranslationStorageBuilder.CreateTranslation(Roblox.Platform.Localization.Core.ILanguageFamily,Roblox.Platform.TranslationStorage.ContentSourceType,Roblox.Platform.TranslationStorage.ContentVariantType,System.String,System.String,System.Boolean,Roblox.Platform.TranslationStorage.IChangeAgent)" />
	public void CreateTranslation(ILanguageFamily languageFamily, ContentSourceType contentSourceType, ContentVariantType contentVariantType, string contentSourceTargetId, string translationValue, bool isSourceContentVariantAndLocale = false, IChangeAgent changeAgent = null)
	{
		if (languageFamily == null)
		{
			throw new PlatformArgumentNullException("languageFamily");
		}
		CreateTranslation(contentSourceType, contentVariantType, contentSourceTargetId, languageFamily.LanguageCode, translationValue, isSourceContentVariantAndLocale, changeAgent);
	}

	/// <inheritdoc cref="M:Roblox.Platform.TranslationStorage.TranslationStorageBuilder.CreateOrUpdateTranslation(Roblox.Platform.Localization.Core.ISupportedLocale,Roblox.Platform.TranslationStorage.ContentSourceType,Roblox.Platform.TranslationStorage.ContentVariantType,System.String,System.String,System.Boolean,Roblox.Platform.TranslationStorage.IChangeAgent)" />
	public CreateOrUpdateTranslationStatus CreateOrUpdateTranslation(ISupportedLocale supportedLocale, ContentSourceType contentSourceType, ContentVariantType contentVariantType, string contentSourceTargetId, string translationValue, bool isSourceContentVariantAndLocale = false, IChangeAgent changeAgent = null)
	{
		if (supportedLocale == null)
		{
			throw new PlatformArgumentNullException("supportedLocale");
		}
		return CreateOrUpdateTranslation(contentSourceType, contentVariantType, contentSourceTargetId, supportedLocale.LocaleCode, translationValue, isSourceContentVariantAndLocale, changeAgent);
	}

	/// <inheritdoc cref="M:Roblox.Platform.TranslationStorage.TranslationStorageBuilder.CreateOrUpdateTranslation(Roblox.Platform.Localization.Core.ILanguageFamily,Roblox.Platform.TranslationStorage.ContentSourceType,Roblox.Platform.TranslationStorage.ContentVariantType,System.String,System.String,System.Boolean,Roblox.Platform.TranslationStorage.IChangeAgent)" />
	public CreateOrUpdateTranslationStatus CreateOrUpdateTranslation(ILanguageFamily languageFamily, ContentSourceType contentSourceType, ContentVariantType contentVariantType, string contentSourceTargetId, string translationValue, bool isSourceContentVariantAndLocale = false, IChangeAgent changeAgent = null)
	{
		if (languageFamily == null)
		{
			throw new PlatformArgumentNullException("languageFamily");
		}
		return CreateOrUpdateTranslation(contentSourceType, contentVariantType, contentSourceTargetId, languageFamily.LanguageCode, translationValue, isSourceContentVariantAndLocale, changeAgent);
	}

	/// <inheritdoc cref="M:Roblox.Platform.TranslationStorage.TranslationStorageBuilder.DeleteTranslation(Roblox.Platform.Localization.Core.ISupportedLocale,Roblox.Platform.TranslationStorage.ContentSourceType,Roblox.Platform.TranslationStorage.ContentVariantType,System.String,Roblox.Platform.TranslationStorage.IChangeAgent)" />
	public DeleteTranslationResponse DeleteTranslation(ISupportedLocale supportedLocale, ContentSourceType contentSourceType, ContentVariantType contentVariantType, string contentSourceTargetId, IChangeAgent changeAgent = null)
	{
		if (supportedLocale == null)
		{
			throw new PlatformArgumentNullException("supportedLocale");
		}
		return DeleteTranslation(contentSourceType, contentVariantType, contentSourceTargetId, supportedLocale.LocaleCode, changeAgent);
	}

	/// <inheritdoc cref="M:Roblox.Platform.TranslationStorage.TranslationStorageBuilder.DeleteTranslation(Roblox.Platform.Localization.Core.ILanguageFamily,Roblox.Platform.TranslationStorage.ContentSourceType,Roblox.Platform.TranslationStorage.ContentVariantType,System.String,Roblox.Platform.TranslationStorage.IChangeAgent)" />
	public DeleteTranslationResponse DeleteTranslation(ILanguageFamily languageFamily, ContentSourceType contentSourceType, ContentVariantType contentVariantType, string contentSourceTargetId, IChangeAgent changeAgent = null)
	{
		if (languageFamily == null)
		{
			throw new PlatformArgumentNullException("languageFamily");
		}
		return DeleteTranslation(contentSourceType, contentVariantType, contentSourceTargetId, languageFamily.LanguageCode, changeAgent);
	}

	/// <inheritdoc cref="M:Roblox.Platform.TranslationStorage.TranslationStorageBuilder.UpdateTranslation(Roblox.Platform.Localization.Core.ISupportedLocale,Roblox.Platform.TranslationStorage.ContentSourceType,Roblox.Platform.TranslationStorage.ContentVariantType,System.String,System.String,Roblox.Platform.TranslationStorage.IChangeAgent)" />
	public void UpdateTranslation(ISupportedLocale supportedLocale, ContentSourceType contentSourceType, ContentVariantType contentVariantType, string contentSourceTargetId, string translationValue, IChangeAgent changeAgent = null)
	{
		if (supportedLocale == null)
		{
			throw new PlatformArgumentNullException("supportedLocale");
		}
		UpdateTranslation(contentSourceType, contentVariantType, contentSourceTargetId, supportedLocale.LocaleCode, translationValue, changeAgent);
	}

	/// <inheritdoc cref="M:Roblox.Platform.TranslationStorage.TranslationStorageBuilder.UpdateTranslation(Roblox.Platform.Localization.Core.ILanguageFamily,Roblox.Platform.TranslationStorage.ContentSourceType,Roblox.Platform.TranslationStorage.ContentVariantType,System.String,System.String,Roblox.Platform.TranslationStorage.IChangeAgent)" />
	public void UpdateTranslation(ILanguageFamily languageFamily, ContentSourceType contentSourceType, ContentVariantType contentVariantType, string contentSourceTargetId, string translationValue, IChangeAgent changeAgent = null)
	{
		if (languageFamily == null)
		{
			throw new PlatformArgumentNullException("languageFamily");
		}
		UpdateTranslation(contentSourceType, contentVariantType, contentSourceTargetId, languageFamily.LanguageCode, translationValue, changeAgent);
	}

	/// <inheritdoc cref="!:MigrateTranslations(IDictionary, ContentSourceType, ContentVariantType)" />
	public void MigrateTranslations(IEnumerable<MigrateTranslationId> migrateTranslationIds, ContentSourceType contentSourceType, ContentVariantType contentVariantType)
	{
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Expected O, but got Unknown
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Expected O, but got Unknown
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_007d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		//IL_0089: Unknown result type (might be due to invalid IL or missing references)
		//IL_0096: Unknown result type (might be due to invalid IL or missing references)
		//IL_009d: Unknown result type (might be due to invalid IL or missing references)
		//IL_00af: Expected O, but got Unknown
		//IL_00d0: Unknown result type (might be due to invalid IL or missing references)
		if (migrateTranslationIds == null || !migrateTranslationIds.Any())
		{
			throw new PlatformArgumentNullException("migrateTranslationIds");
		}
		MigrateTranslationsRequest migrationRequest = new MigrateTranslationsRequest();
		List<MigrateTranslation> migrations = new List<MigrateTranslation>();
		ContentSourceType contentSource = new ContentSourceType
		{
			Value = contentSourceType.ToString(),
			Description = contentSourceType.ToDescription()
		};
		ContentVariantType variantType = GetClientContentVariantType(contentVariantType);
		foreach (MigrateTranslationId migrateTranslationId in migrateTranslationIds)
		{
			if (!migrateTranslationId.OldId.Equals(migrateTranslationId.NewId))
			{
				migrations.Add(new MigrateTranslation
				{
					OldContentSourceType = contentSource,
					OldContentSourceTargetId = migrateTranslationId.OldId,
					NewContentSourceType = contentSource,
					NewContentSourceTargetId = migrateTranslationId.NewId
				});
			}
		}
		if (migrations.Any())
		{
			migrationRequest.ContentVariantType = variantType;
			migrationRequest.Migrations = migrations;
			_Client.MigrateTranslations(migrationRequest);
		}
	}

	private void CreateTranslation(ContentSourceType contentSourceType, ContentVariantType contentVariantType, string contentSourceTargetId, string supportedLocaleOrLanguageCode, string translationValue, bool isSourceContentVariantAndLocale, IChangeAgent changeAgent = null)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Expected O, but got Unknown
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		//IL_006b: Unknown result type (might be due to invalid IL or missing references)
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0072: Unknown result type (might be due to invalid IL or missing references)
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0081: Unknown result type (might be due to invalid IL or missing references)
		//IL_0089: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cd: Expected O, but got Unknown
		ContentVariantType variantType = GetClientContentVariantType(contentVariantType);
		if (string.IsNullOrWhiteSpace(contentSourceTargetId))
		{
			throw new PlatformArgumentException("contentSourceTargetId");
		}
		if (string.IsNullOrWhiteSpace(translationValue))
		{
			throw new PlatformArgumentException("translationValue");
		}
		CreateTranslationRequest createTranslationRequest = new CreateTranslationRequest
		{
			ContentSourceType = new ContentSourceType
			{
				Value = contentSourceType.ToString(),
				Description = contentSourceType.ToDescription()
			},
			IsSourceVariantAndLocale = isSourceContentVariantAndLocale,
			ContentVariantType = variantType,
			ContentLocaleType = supportedLocaleOrLanguageCode,
			ContentSourceTargetId = contentSourceTargetId,
			TranslationValue = translationValue,
			ChangeAgentType = changeAgent?.ChangeAgentType.ToString(),
			ChangeAgentTargetId = changeAgent?.ChangeAgentTargetId
		};
		try
		{
			_Client.CreateTranslation(createTranslationRequest);
		}
		catch (Exception ex)
		{
			_Logger.Error(ex);
			throw new PlatformOperationUnavailableException("Unable to create translation..", ex);
		}
	}

	private CreateOrUpdateTranslationStatus CreateOrUpdateTranslation(ContentSourceType contentSourceType, ContentVariantType contentVariantType, string contentSourceTargetId, string supportedLocaleOrLanguageCode, string translationValue, bool isSourceContentVariantAndLocale, IChangeAgent changeAgent = null)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Expected O, but got Unknown
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		//IL_006b: Unknown result type (might be due to invalid IL or missing references)
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0072: Unknown result type (might be due to invalid IL or missing references)
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0081: Unknown result type (might be due to invalid IL or missing references)
		//IL_0089: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cd: Expected O, but got Unknown
		ContentVariantType variantType = GetClientContentVariantType(contentVariantType);
		if (string.IsNullOrWhiteSpace(contentSourceTargetId))
		{
			throw new PlatformArgumentException("contentSourceTargetId");
		}
		if (string.IsNullOrWhiteSpace(translationValue))
		{
			throw new PlatformArgumentException("translationValue");
		}
		CreateOrUpdateTranslationRequest createOrUpdateCreateTranslationRequest = new CreateOrUpdateTranslationRequest
		{
			ContentSourceType = new ContentSourceType
			{
				Value = contentSourceType.ToString(),
				Description = contentSourceType.ToDescription()
			},
			IsSourceVariantAndLocale = isSourceContentVariantAndLocale,
			ContentVariantType = variantType,
			ContentLocaleType = supportedLocaleOrLanguageCode,
			ContentSourceTargetId = contentSourceTargetId,
			TranslationValue = translationValue,
			ChangeAgentType = changeAgent?.ChangeAgentType.ToString(),
			ChangeAgentTargetId = changeAgent?.ChangeAgentTargetId
		};
		try
		{
			CreateOrUpdateTranslationResponse clientResponse = _Client.CreateOrUpdateTranslation(createOrUpdateCreateTranslationRequest);
			return _TranslationStorageResponseConverter.ConvertCreateOrUpdateTranslationResponse(clientResponse);
		}
		catch (Exception ex)
		{
			_Logger.Error(ex);
			throw new PlatformOperationUnavailableException("Unable to create or update translation..", ex);
		}
	}

	private DeleteTranslationResponse DeleteTranslation(ContentSourceType contentSourceType, ContentVariantType contentVariantType, string contentSourceTargetId, string supportedLocaleOrLanguageCode, IChangeAgent changeAgent = null)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Expected O, but got Unknown
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a9: Expected O, but got Unknown
		ContentVariantType variantType = GetClientContentVariantType(contentVariantType);
		if (string.IsNullOrWhiteSpace(contentSourceTargetId))
		{
			throw new PlatformArgumentException("contentSourceTargetId");
		}
		DeleteTranslationRequest deleteTranslationRequest = new DeleteTranslationRequest
		{
			ContentSourceType = new ContentSourceType
			{
				Value = contentSourceType.ToString(),
				Description = contentSourceType.ToDescription()
			},
			ContentVariantType = variantType,
			ContentLocaleType = supportedLocaleOrLanguageCode,
			ContentSourceTargetId = contentSourceTargetId,
			ChangeAgentType = changeAgent?.ChangeAgentType.ToString(),
			ChangeAgentTargetId = changeAgent?.ChangeAgentTargetId
		};
		try
		{
			DeleteTranslationResponse clientResponse = _Client.DeleteTranslation(deleteTranslationRequest);
			return _TranslationStorageResponseConverter.ConvertDeleteTranslationResponse(clientResponse);
		}
		catch (Exception ex)
		{
			_Logger.Error(ex);
			throw new PlatformOperationUnavailableException("Unable to delete translation..", ex);
		}
	}

	private void UpdateTranslation(ContentSourceType contentSourceType, ContentVariantType contentVariantType, string contentSourceTargetId, string supportedLocaleOrLanguageCode, string translationValue, IChangeAgent changeAgent = null)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Expected O, but got Unknown
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_006b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		//IL_0079: Unknown result type (might be due to invalid IL or missing references)
		//IL_0081: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c5: Expected O, but got Unknown
		ContentVariantType variantType = GetClientContentVariantType(contentVariantType);
		if (string.IsNullOrWhiteSpace(contentSourceTargetId))
		{
			throw new PlatformArgumentException("contentSourceTargetId");
		}
		if (string.IsNullOrWhiteSpace(translationValue))
		{
			throw new PlatformArgumentException("translationValue");
		}
		UpdateTranslationRequest updateTranslationRequest = new UpdateTranslationRequest
		{
			ContentSourceType = new ContentSourceType
			{
				Value = contentSourceType.ToString(),
				Description = contentSourceType.ToDescription()
			},
			ContentSourceTargetId = contentSourceTargetId,
			ContentVariantType = variantType,
			ContentLocaleType = supportedLocaleOrLanguageCode,
			TranslationValue = translationValue,
			ChangeAgentType = changeAgent?.ChangeAgentType.ToString(),
			ChangeAgentTargetId = changeAgent?.ChangeAgentTargetId
		};
		try
		{
			_Client.UpdateTranslation(updateTranslationRequest);
		}
		catch (Exception ex)
		{
			_Logger.Error(ex);
			throw new PlatformOperationUnavailableException("Unable to update translation..", ex);
		}
	}

	private ContentVariantType GetClientContentVariantType(ContentVariantType contentVariantType)
	{
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		ContentVariantType? variantType = EnumUtils.StrictTryParseEnum<ContentVariantType>(contentVariantType.ToString());
		if (!variantType.HasValue)
		{
			throw new PlatformArgumentException("contentVariantType");
		}
		return variantType.Value;
	}
}
