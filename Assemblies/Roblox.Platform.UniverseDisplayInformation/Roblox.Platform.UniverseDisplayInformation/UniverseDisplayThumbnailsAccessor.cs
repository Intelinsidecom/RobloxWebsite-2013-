using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using Roblox.EventLog;
using Roblox.Platform.AssetMedia;
using Roblox.Platform.Assets;
using Roblox.Platform.Core;
using Roblox.Platform.Localization.Core;
using Roblox.Platform.TranslationStorage;
using Roblox.Platform.UniverseDisplayInformation.Properties;
using Roblox.Platform.Universes;

namespace Roblox.Platform.UniverseDisplayInformation;

/// <summary>
/// A class used for accessing localized display thumbnails for a <see cref="T:Roblox.Platform.Universes.IUniverse" />.
/// </summary>
/// <seealso cref="T:Roblox.Platform.UniverseDisplayInformation.IUniverseDisplayThumbnailsAccessor" />
/// <inheritdoc />
public class UniverseDisplayThumbnailsAccessor : IUniverseDisplayThumbnailsAccessor
{
	/// <summary>
	/// The delegate to create <see cref="T:Roblox.Platform.TranslationStorage.IGenericTranslationStorageAccessor`1" />.
	/// </summary>
	/// <param name="getIsAccessingEnabledFunc">The get is accessing enabled function.</param>
	/// <param name="getIsReturningEnabledFunc">The get is returning enabled function.</param>
	/// <param name="getShadowRolloutPercentageFunc">The get shadow roll-out percentage function.</param>
	/// <returns>The delegate.</returns>
	public delegate IGenericTranslationStorageAccessor<IUniverse> CreateGenericTranslationStorageAccessor(Func<bool> getIsAccessingEnabledFunc, Func<bool> getIsReturningEnabledFunc, Func<int> getShadowRolloutPercentageFunc);

	private static readonly string _ContentSourceType = ContentSourceType.UniverseDisplayThumbnailsMapping.ToString();

	private static readonly string _ContentVariantType = ContentVariantType.Production.ToString();

	private readonly IPlaceThumbnailFactory _PlaceThumbnailFactory;

	private readonly IGenericTranslationStorageAccessor<IUniverse> _GenericTranslationStorageAccessor;

	private readonly Func<bool> _IsReturningPartialNonApprovedLocalizedThumbnailsEnabledGetter;

	private readonly IImageApprovalStatusGetter _ImageApprovalStatusGetter;

	private readonly IUniverseDisplayThumbnailsUtil _UniverseDisplayThumbnailUtil;

	private readonly ICoreLocalizationAccessor _CoreLocalizationAccessor;

	private readonly ILogger _Logger;

	/// <summary>
	/// Initializes a new instance of the <see cref="T:Roblox.Platform.UniverseDisplayInformation.UniverseDisplayThumbnailsAccessor" /> class.
	/// </summary>
	/// <param name="assetFactory">The <see cref="T:Roblox.Platform.Assets.IAssetFactory" />.</param>
	/// <param name="assetTypeFactory">The <see cref="T:Roblox.Platform.Assets.IAssetTypeFactory" />.</param>
	/// <param name="rawContentFactory">The <see cref="T:Roblox.Platform.Assets.IRawContentFactory" />.</param>
	/// <param name="createGenericTranslationStorageAccessor">The <see cref="T:Roblox.Platform.UniverseDisplayInformation.UniverseDisplayThumbnailsAccessor.CreateGenericTranslationStorageAccessor" />.</param>
	/// <param name="coreLocalizationAccessor">The <see cref="T:Roblox.Platform.Localization.Core.ICoreLocalizationAccessor" />.</param>
	/// <param name="logger">The <see cref="T:Roblox.EventLog.ILogger" />.</param>
	[ExcludeFromCodeCoverage]
	public UniverseDisplayThumbnailsAccessor(IAssetFactory assetFactory, IAssetTypeFactory assetTypeFactory, IRawContentFactory rawContentFactory, CreateGenericTranslationStorageAccessor createGenericTranslationStorageAccessor, ICoreLocalizationAccessor coreLocalizationAccessor, ILogger logger)
		: this(new PlaceThumbnailFactory(), createGenericTranslationStorageAccessor(() => Settings.Default.IsAccessingLocalizedThumbnailsEnabled, () => Settings.Default.IsReturningLocalizedThumbnailsEnabled, () => Settings.Default.ThumbnailLocalizationShadowRolloutPercentage), new ImageApprovalStatusGetter(assetFactory, assetTypeFactory, rawContentFactory, logger), () => Settings.Default.IsReturningPartialNonApprovedLocalizedThumbnailsEnabled, new UniverseDisplayThumbnailsUtil(), coreLocalizationAccessor, logger)
	{
	}

	internal UniverseDisplayThumbnailsAccessor(IPlaceThumbnailFactory placeThumbnailFactory, IGenericTranslationStorageAccessor<IUniverse> genericTranslationStorageAccessor, IImageApprovalStatusGetter imageApprovalStatusGetter, Func<bool> isReturningPartialNonApprovedLocalizedThumbnailsEnabledGetter, IUniverseDisplayThumbnailsUtil universeDisplayThumbnailsUtil, ICoreLocalizationAccessor coreLocalizationAccessor, ILogger logger)
	{
		_PlaceThumbnailFactory = placeThumbnailFactory ?? throw new PlatformArgumentNullException("placeThumbnailFactory");
		_GenericTranslationStorageAccessor = genericTranslationStorageAccessor ?? throw new PlatformArgumentNullException("genericTranslationStorageAccessor");
		_ImageApprovalStatusGetter = imageApprovalStatusGetter ?? throw new PlatformArgumentNullException("imageApprovalStatusGetter");
		_IsReturningPartialNonApprovedLocalizedThumbnailsEnabledGetter = isReturningPartialNonApprovedLocalizedThumbnailsEnabledGetter ?? throw new PlatformArgumentNullException("isReturningPartialNonApprovedLocalizedThumbnailsEnabledGetter");
		_UniverseDisplayThumbnailUtil = universeDisplayThumbnailsUtil ?? throw new PlatformArgumentNullException("universeDisplayThumbnailsUtil");
		_CoreLocalizationAccessor = coreLocalizationAccessor ?? throw new PlatformArgumentNullException("coreLocalizationAccessor");
		_Logger = logger ?? throw new PlatformArgumentNullException("logger");
	}

	/// <inheritdoc cref="M:Roblox.Platform.UniverseDisplayInformation.IUniverseDisplayThumbnailsAccessor.GetDisplayMediaAssets(Roblox.Platform.Universes.IUniverse,Roblox.Platform.Localization.Core.ISupportedLocale,Roblox.Platform.Localization.Core.ILanguageFamily)" />
	public IReadOnlyList<long> GetDisplayMediaAssets(IUniverse universe, ISupportedLocale supportedLocale, ILanguageFamily sourceLanguageFamily)
	{
		if (universe == null)
		{
			throw new PlatformArgumentNullException("universe");
		}
		return DoGetDisplayMediaAssets(universe, supportedLocale?.Language, sourceLanguageFamily);
	}

	/// <inheritdoc cref="M:Roblox.Platform.UniverseDisplayInformation.IUniverseDisplayThumbnailsAccessor.GetDisplayMediaAssetsForAllLanguages(Roblox.Platform.Universes.IUniverse,Roblox.Platform.Localization.Core.ILanguageFamily)" />
	public IReadOnlyCollection<UniverseDisplayMediaAssetsForLanguage> GetDisplayMediaAssetsForAllLanguages(IUniverse universe, ILanguageFamily sourceLanguageFamily)
	{
		if (universe == null)
		{
			throw new PlatformArgumentNullException("universe");
		}
		List<UniverseDisplayMediaAssetsForLanguage> universeDisplayMediaAssetsForLanguages = new List<UniverseDisplayMediaAssetsForLanguage>();
		List<long> sourceMediaAssetsForLanguage = new List<long>();
		if (universe.RootPlaceId.HasValue)
		{
			try
			{
				sourceMediaAssetsForLanguage = (from x in _PlaceThumbnailFactory.GetPlaceThumbnailsByPlaceId(universe.RootPlaceId.Value)
					select x.ImageId).ToList();
			}
			catch (Exception ex)
			{
				_Logger.Error(ex);
			}
			universeDisplayMediaAssetsForLanguages.Add(new UniverseDisplayMediaAssetsForLanguage
			{
				Language = sourceLanguageFamily,
				MediaAssetIds = sourceMediaAssetsForLanguage,
				IsSourceLanguage = true
			});
		}
		foreach (TranslationValue translationValue in _GenericTranslationStorageAccessor.GetTranslationValuesInAllContentLocales(sourceLanguageFamily?.LanguageCode, _ContentSourceType, _ContentVariantType, universe.Id.ToString()))
		{
			ILanguageFamily language = _CoreLocalizationAccessor.GetLanguageFamily(translationValue.ContentLocale);
			if (language == null)
			{
				_Logger.Error($"Unknown language code {translationValue.ContentLocale}. UniverseId = {universe.Id}.");
				continue;
			}
			universeDisplayMediaAssetsForLanguages.Add(new UniverseDisplayMediaAssetsForLanguage
			{
				Language = language,
				MediaAssetIds = _UniverseDisplayThumbnailUtil.Deserialize(translationValue.Translation),
				IsSourceLanguage = false
			});
		}
		return universeDisplayMediaAssetsForLanguages;
	}

	private IReadOnlyList<long> DoGetDisplayMediaAssets(IUniverse universe, ILanguageFamily languageFamily, ILanguageFamily sourceLanguageFamily)
	{
		List<long> resultList = new List<long>();
		try
		{
			long? rootPlaceId = universe.RootPlaceId;
			if (!rootPlaceId.HasValue)
			{
				return resultList;
			}
			IReadOnlyList<IPlaceThumbnail> placeThumbnails = _PlaceThumbnailFactory.GetPlaceThumbnailsByPlaceId(rootPlaceId.Value);
			resultList.AddRange(placeThumbnails.Select((IPlaceThumbnail x) => x.ImageId));
		}
		catch (Exception ex2)
		{
			_Logger.Error(ex2);
		}
		if (languageFamily == null)
		{
			return resultList;
		}
		try
		{
			ValueSource<IUniverse> valueSource = new ValueSource<IUniverse>(universe, _UniverseDisplayThumbnailUtil.Serialize(resultList), sourceLanguageFamily?.LanguageCode, universe.Id.ToString(), universe.Id);
			string universeThumbnailIdsString = _GenericTranslationStorageAccessor.GetTranslationValue(valueSource, _ContentSourceType, _ContentVariantType, languageFamily.LanguageCode);
			IReadOnlyList<long> localizedMediaAssetIds = _UniverseDisplayThumbnailUtil.Deserialize(universeThumbnailIdsString);
			if (localizedMediaAssetIds.SequenceEqual(resultList))
			{
				return resultList;
			}
			IDictionary<long, bool> approvalStatusDictionary = _ImageApprovalStatusGetter.GetApprovalStatusForImages(localizedMediaAssetIds);
			if (!approvalStatusDictionary.Any((KeyValuePair<long, bool> x) => x.Value))
			{
				return resultList;
			}
			resultList = (_IsReturningPartialNonApprovedLocalizedThumbnailsEnabledGetter() ? localizedMediaAssetIds.ToList() : localizedMediaAssetIds.Where((long x) => approvalStatusDictionary[x]).ToList());
		}
		catch (Exception ex)
		{
			_Logger.Error(ex);
		}
		return resultList;
	}
}
