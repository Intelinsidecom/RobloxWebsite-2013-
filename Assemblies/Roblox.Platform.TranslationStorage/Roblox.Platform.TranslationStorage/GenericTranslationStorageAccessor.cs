using System;
using System.Collections.Generic;
using System.Linq;
using Roblox.Common;
using Roblox.EventLog;
using Roblox.Platform.Core;
using Roblox.TranslationStorage.Client;

namespace Roblox.Platform.TranslationStorage;

/// <inheritdoc />
internal class GenericTranslationStorageAccessor<TIdentifier> : IGenericTranslationStorageAccessor<TIdentifier>
{
	private readonly ITranslationStorageClient _TranslationStorageClient;

	private readonly ILogger _Logger;

	private readonly Func<bool> _IsAccessingTranslationsEnabledGetter;

	private readonly Func<bool> _IsReturningTranslationsEnabledGetter;

	private readonly Func<int> _ShadowRolloutPercentageGetter;

	/// <summary>
	/// Initializes a new instance of the <see cref="T:Roblox.Platform.TranslationStorage.GenericTranslationStorageAccessor`1" /> class.
	/// </summary>
	/// <param name="translationStorageClient">The <see cref="T:Roblox.TranslationStorage.Client.ITranslationStorageClient" />.</param>
	/// <param name="logger">The <see cref="T:Roblox.EventLog.ILogger" />.</param>
	/// <param name="isAccessingTranslationsEnabledGetter">The is accessing translations enabled getter.</param>
	/// <param name="isReturningTranslationsEnabledGetter">The is returning translations enabled getter.</param>
	/// <param name="shadowRolloutPercentageGetter">The shadow roll-out percentage getter.</param>
	/// <exception cref="T:Roblox.Platform.Core.PlatformArgumentNullException">translationStorageClient
	/// or
	/// logger
	/// or
	/// isAccessingTranslationsEnabledGetter
	/// or
	/// isReturningTranslationsEnabledGetter
	/// or
	/// shadowRolloutPercentagGetter</exception>
	public GenericTranslationStorageAccessor(ITranslationStorageClient translationStorageClient, ILogger logger, Func<bool> isAccessingTranslationsEnabledGetter, Func<bool> isReturningTranslationsEnabledGetter, Func<int> shadowRolloutPercentageGetter)
	{
		_TranslationStorageClient = translationStorageClient ?? throw new PlatformArgumentNullException("translationStorageClient");
		_Logger = logger ?? throw new PlatformArgumentNullException("logger");
		_IsAccessingTranslationsEnabledGetter = isAccessingTranslationsEnabledGetter ?? throw new PlatformArgumentNullException("isAccessingTranslationsEnabledGetter");
		_IsReturningTranslationsEnabledGetter = isReturningTranslationsEnabledGetter ?? throw new PlatformArgumentNullException("isReturningTranslationsEnabledGetter");
		_ShadowRolloutPercentageGetter = shadowRolloutPercentageGetter ?? throw new PlatformArgumentNullException("shadowRolloutPercentageGetter");
	}

	/// <inheritdoc cref="M:Roblox.Platform.TranslationStorage.IGenericTranslationStorageAccessor`1.GetTranslationValue(Roblox.Platform.TranslationStorage.ValueSource{`0},System.String,System.String,System.String)" />
	public string GetTranslationValue(ValueSource<TIdentifier> valueSource, string contentSourceType, string contentVariantType, string contentLocaleType)
	{
		//IL_0087: Unknown result type (might be due to invalid IL or missing references)
		//IL_008c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0094: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		//IL_009a: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a6: Expected O, but got Unknown
		//IL_00a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ba: Expected O, but got Unknown
		if (valueSource == null)
		{
			throw new PlatformArgumentNullException("valueSource");
		}
		if (string.IsNullOrWhiteSpace(contentSourceType))
		{
			throw new PlatformArgumentException("contentSourceType");
		}
		if (!TryConvertToClientContentVariantType(contentVariantType, out var clientContentVariantType))
		{
			throw new PlatformArgumentException("contentVariantType");
		}
		if (string.IsNullOrWhiteSpace(contentLocaleType) || valueSource.SourceLocale == contentLocaleType || !_IsAccessingTranslationsEnabledGetter() || (!_IsReturningTranslationsEnabledGetter() && !IsInShadowRolloutRange(valueSource.ShadowRolloutId, _ShadowRolloutPercentageGetter())))
		{
			return valueSource.Value;
		}
		GetTranslationRequest getTranslationRequest = new GetTranslationRequest
		{
			ContentLocaleType = contentLocaleType,
			ContentSourceType = new ContentSourceType
			{
				Value = contentSourceType
			},
			ContentSourceTargetId = valueSource.TargetId,
			ContentVariantType = clientContentVariantType
		};
		try
		{
			GetTranslationResponse translation2 = _TranslationStorageClient.GetTranslation(getTranslationRequest);
			string translation = ((translation2 != null) ? translation2.TranslationValue : null);
			if (_IsReturningTranslationsEnabledGetter() && !string.IsNullOrWhiteSpace(translation))
			{
				return translation;
			}
		}
		catch (Exception ex)
		{
			_Logger.Error(ex);
		}
		return valueSource.Value;
	}

	/// <inheritdoc cref="M:Roblox.Platform.TranslationStorage.IGenericTranslationStorageAccessor`1.MultiGetTranslationValues(System.Collections.Generic.ICollection{Roblox.Platform.TranslationStorage.ValueSource{`0}},System.String,System.String,System.String)" />
	public IReadOnlyDictionary<TIdentifier, string> MultiGetTranslationValues(ICollection<ValueSource<TIdentifier>> valueSources, string contentSourceType, string contentVariantType, string contentLocaleType)
	{
		//IL_013a: Unknown result type (might be due to invalid IL or missing references)
		//IL_013f: Unknown result type (might be due to invalid IL or missing references)
		//IL_014b: Unknown result type (might be due to invalid IL or missing references)
		//IL_014c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0151: Unknown result type (might be due to invalid IL or missing references)
		//IL_015d: Expected O, but got Unknown
		//IL_015d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0164: Unknown result type (might be due to invalid IL or missing references)
		//IL_0165: Unknown result type (might be due to invalid IL or missing references)
		//IL_016d: Expected O, but got Unknown
		if (valueSources == null)
		{
			throw new PlatformArgumentNullException("valueSources");
		}
		if (string.IsNullOrWhiteSpace(contentSourceType))
		{
			throw new PlatformArgumentException("contentSourceType");
		}
		if (!TryConvertToClientContentVariantType(contentVariantType, out var clientContentVariantType))
		{
			throw new PlatformArgumentException("contentVariantType");
		}
		Dictionary<TIdentifier, string> resultDictionary = valueSources.ToDictionary((ValueSource<TIdentifier> x) => x.Identifier, (ValueSource<TIdentifier> y) => y.Value);
		if (string.IsNullOrWhiteSpace(contentLocaleType) || !_IsAccessingTranslationsEnabledGetter())
		{
			return resultDictionary;
		}
		valueSources = valueSources.Where((ValueSource<TIdentifier> x) => x.SourceLocale != contentLocaleType).ToList();
		ICollection<ValueSource<TIdentifier>> collection2;
		if (!_IsReturningTranslationsEnabledGetter())
		{
			ICollection<ValueSource<TIdentifier>> collection = valueSources.Where((ValueSource<TIdentifier> x) => IsInShadowRolloutRange(x.ShadowRolloutId, _ShadowRolloutPercentageGetter())).ToList();
			collection2 = collection;
		}
		else
		{
			collection2 = valueSources;
		}
		ICollection<ValueSource<TIdentifier>> valueSourceItemsToRequest = collection2;
		List<string> contentSourceTargetIds = valueSourceItemsToRequest.Select((ValueSource<TIdentifier> x) => x.TargetId).Distinct().ToList();
		if (!contentSourceTargetIds.Any())
		{
			return resultDictionary;
		}
		GetTranslationsForContentSourceTargetIdsRequest getTranslationsForContentSourceTargetIdsRequest = new GetTranslationsForContentSourceTargetIdsRequest
		{
			ContentLocaleType = contentLocaleType,
			ContentSourceType = new ContentSourceType
			{
				Value = contentSourceType
			},
			ContentSourceTargetIds = contentSourceTargetIds,
			ContentVariantType = clientContentVariantType
		};
		ICollection<ContentSourceTargetIdTranslationValue> contentSourceTargetIdTranslationValues;
		try
		{
			contentSourceTargetIdTranslationValues = _TranslationStorageClient.GetTranslationsForContentSourceTargetIds(getTranslationsForContentSourceTargetIdsRequest).Translations.Where((ContentSourceTargetIdTranslationValue x) => !string.IsNullOrWhiteSpace(x.TranslationValue)).ToList();
		}
		catch (Exception ex)
		{
			_Logger.Error(ex);
			return resultDictionary;
		}
		if (_IsReturningTranslationsEnabledGetter())
		{
			(from identifier in valueSourceItemsToRequest
				join translation in contentSourceTargetIdTranslationValues on identifier.TargetId equals translation.ContentSourceTargetId
				select (identifier, translation.TranslationValue)).ToList().ForEach(delegate((ValueSource<TIdentifier> identifier, string TranslationValue) x)
			{
				resultDictionary[x.identifier.Identifier] = x.TranslationValue;
			});
		}
		return resultDictionary;
	}

	/// <inheritdoc cref="M:Roblox.Platform.TranslationStorage.IGenericTranslationStorageAccessor`1.GetTranslationValuesInAllContentLocales(System.String,System.String,System.String,System.String)" />/&gt;
	public IReadOnlyCollection<TranslationValue> GetTranslationValuesInAllContentLocales(string sourceLocale, string contentSourceType, string contentVariantType, string contentSourceTargetId)
	{
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Expected O, but got Unknown
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Expected O, but got Unknown
		if (string.IsNullOrWhiteSpace(contentSourceType))
		{
			throw new PlatformArgumentException("contentSourceType");
		}
		if (!TryConvertToClientContentVariantType(contentVariantType, out var clientContentVariantType))
		{
			throw new PlatformArgumentException("contentVariantType");
		}
		if (string.IsNullOrWhiteSpace(contentSourceTargetId))
		{
			throw new PlatformArgumentException("contentSourceTargetId");
		}
		List<TranslationValue> resultList = new List<TranslationValue>();
		ICollection<ContentLocaleTranslationValue> translationValues;
		try
		{
			GetTranslationsForContentLocalesRequest getTranslationsForContentLocalesRequest = new GetTranslationsForContentLocalesRequest
			{
				ContentSourceType = new ContentSourceType
				{
					Value = contentSourceType
				},
				ContentVariantType = clientContentVariantType,
				ContentSourceTargetId = contentSourceTargetId
			};
			translationValues = _TranslationStorageClient.GetTranslationsForContentLocales(getTranslationsForContentLocalesRequest).Translations.ToList();
		}
		catch (Exception ex)
		{
			_Logger.Error(ex);
			return resultList;
		}
		foreach (ContentLocaleTranslationValue translationForContentLocale in translationValues)
		{
			if (!string.IsNullOrWhiteSpace(translationForContentLocale.TranslationValue) && !(sourceLocale == translationForContentLocale.ContentLocale))
			{
				resultList.Add(new TranslationValue(translationForContentLocale.ContentLocale, translationForContentLocale.TranslationValue));
			}
		}
		return resultList;
	}

	private static bool IsInShadowRolloutRange(long valueSourceRange, int shadowRolloutPercentage)
	{
		return valueSourceRange % 100 < shadowRolloutPercentage;
	}

	private static bool TryConvertToClientContentVariantType(string contentVariantType, out ContentVariantType clientContentVariantType)
	{
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Expected I4, but got Unknown
		clientContentVariantType = (ContentVariantType)0;
		if (!string.IsNullOrWhiteSpace(contentVariantType))
		{
			ContentVariantType? parsedEnum = EnumUtils.StrictTryParseEnum<ContentVariantType>(contentVariantType);
			if (parsedEnum.HasValue)
			{
				clientContentVariantType = (ContentVariantType)(int)parsedEnum.Value;
				return true;
			}
		}
		return false;
	}
}
