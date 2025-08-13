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

/// <inheritdoc />
public class UniverseDisplayIconAccessor : IUniverseDisplayIconAccessor
{
	/// <summary>
	/// The delegate to create <see cref="T:Roblox.Platform.TranslationStorage.IGenericTranslationStorageAccessor`1" />.
	/// </summary>
	/// <param name="getIsAccessingEnabledFunc"></param>
	/// <param name="getIsReturningEnabledFunc"></param>
	/// <param name="getShadowRolloutPercentageFunc"></param>
	/// <returns></returns>
	public delegate IGenericTranslationStorageAccessor<IUniverse> CreateGenericTranslationStorageAccessor(Func<bool> getIsAccessingEnabledFunc, Func<bool> getIsReturningEnabledFunc, Func<int> getShadowRolloutPercentageFunc);

	private static readonly string _ContentSourceType = ContentSourceType.UniverseDisplayIconMapping.ToString();

	private static readonly string _ContentVariantType = ContentVariantType.Production.ToString();

	private readonly IPlaceIconFactory _PlaceIconFactory;

	private readonly IGenericTranslationStorageAccessor<IUniverse> _GenericTranslationStorageAccessor;

	private readonly IImageApprovalStatusGetter _ImageApprovalStatusGetter;

	private readonly ICoreLocalizationAccessor _CoreLocalizationAccessor;

	private readonly Func<bool> _IsReturningNonApprovedLocalizedIconEnabledGetter;

	private readonly ILogger _Logger;

	/// <summary>
	/// The constructor
	/// </summary>
	/// <param name="placeIconFactory"></param>
	/// <param name="assetFactory"></param>
	/// <param name="assetTypeFactory"></param>
	/// <param name="rawContentFactory"></param>
	/// <param name="createGenericTranslationStorageAccessor"></param>
	/// <param name="coreLocalizationAccessor"></param>
	/// <param name="logger"></param>
	[ExcludeFromCodeCoverage]
	public UniverseDisplayIconAccessor(IPlaceIconFactory placeIconFactory, IAssetFactory assetFactory, IAssetTypeFactory assetTypeFactory, IRawContentFactory rawContentFactory, CreateGenericTranslationStorageAccessor createGenericTranslationStorageAccessor, ICoreLocalizationAccessor coreLocalizationAccessor, ILogger logger)
		: this(placeIconFactory, createGenericTranslationStorageAccessor(() => Settings.Default.IsAccessingLocalizedIconsEnabled, () => Settings.Default.IsReturningLocalizedIconsEnabled, () => Settings.Default.IconLocalizationShadowRolloutPercentage), new ImageApprovalStatusGetter(assetFactory, assetTypeFactory, rawContentFactory, logger), coreLocalizationAccessor, () => Settings.Default.IsReturningNonApprovedLocalizedIconEnabled, logger)
	{
	}

	internal UniverseDisplayIconAccessor(IPlaceIconFactory placeIconFactory, IGenericTranslationStorageAccessor<IUniverse> genericTranslationStorageAccessor, IImageApprovalStatusGetter imageApprovalStatusGetter, ICoreLocalizationAccessor coreLocalizationAccessor, Func<bool> isReturningNonApprovedLocalizedIconEnabledGetter, ILogger logger)
	{
		_PlaceIconFactory = placeIconFactory ?? throw new PlatformArgumentNullException("placeIconFactory");
		_GenericTranslationStorageAccessor = genericTranslationStorageAccessor ?? throw new PlatformArgumentNullException("genericTranslationStorageAccessor");
		_ImageApprovalStatusGetter = imageApprovalStatusGetter ?? throw new PlatformArgumentNullException("imageApprovalStatusGetter");
		_CoreLocalizationAccessor = coreLocalizationAccessor ?? throw new PlatformArgumentNullException("coreLocalizationAccessor");
		_IsReturningNonApprovedLocalizedIconEnabledGetter = isReturningNonApprovedLocalizedIconEnabledGetter ?? throw new PlatformArgumentNullException("isReturningNonApprovedLocalizedIconEnabledGetter");
		_Logger = logger ?? throw new PlatformArgumentNullException("logger");
	}

	/// <inheritdoc />
	public long? GetDisplayIcon(IUniverse universe, ISupportedLocale supportedLocale, ILanguageFamily sourceLanguage)
	{
		if (universe == null)
		{
			throw new PlatformArgumentNullException("universe");
		}
		return DoGetDisplayIconsForUniverses((IReadOnlyCollection<IUniverse>)(object)new IUniverse[1] { universe }, supportedLocale?.Language, new Dictionary<IUniverse, ILanguageFamily> { { universe, sourceLanguage } })[universe];
	}

	/// <inheritdoc />
	public IDictionary<IUniverse, long?> GetDisplayIconsForUniverses(IReadOnlyCollection<IUniverse> universes, ISupportedLocale supportedLocale, IReadOnlyDictionary<IUniverse, ILanguageFamily> sourceLanguageDictionary)
	{
		if (universes == null)
		{
			throw new PlatformArgumentNullException("universes");
		}
		if (sourceLanguageDictionary == null)
		{
			throw new PlatformArgumentNullException("sourceLanguageDictionary");
		}
		return DoGetDisplayIconsForUniverses(universes, supportedLocale?.Language, sourceLanguageDictionary);
	}

	/// <inheritdoc />
	public IReadOnlyCollection<UniverseDisplayIconForLanguage> GetDisplayIconsForAllLanguages(IUniverse universe, ILanguageFamily sourceLanguage)
	{
		if (universe == null)
		{
			throw new PlatformArgumentNullException("universe");
		}
		List<UniverseDisplayIconForLanguage> displayIconsForLanguages = new List<UniverseDisplayIconForLanguage>();
		long? sourceIconImageId = null;
		if (universe.RootPlaceId.HasValue)
		{
			try
			{
				sourceIconImageId = _PlaceIconFactory.GetPlaceIconByPlaceId(universe.RootPlaceId.Value).ImageId;
			}
			catch (Exception ex)
			{
				_Logger.Error(ex);
			}
			displayIconsForLanguages.Add(new UniverseDisplayIconForLanguage
			{
				Language = sourceLanguage,
				IconImageId = sourceIconImageId,
				IsSourceLanguage = true
			});
		}
		foreach (TranslationValue translationValue in _GenericTranslationStorageAccessor.GetTranslationValuesInAllContentLocales(sourceLanguage?.LanguageCode, _ContentSourceType, _ContentVariantType, universe.Id.ToString()))
		{
			ILanguageFamily language = _CoreLocalizationAccessor.GetLanguageFamily(translationValue.ContentLocale);
			if (language == null)
			{
				_Logger.Error($"Unknown language code {translationValue.ContentLocale}. UniverseId = {universe.Id}.");
				continue;
			}
			if (!long.TryParse(translationValue.Translation, out var iconImageId))
			{
				_Logger.Error($"Invalid image id {translationValue.Translation}. UniverseId = {universe.Id}.");
				continue;
			}
			displayIconsForLanguages.Add(new UniverseDisplayIconForLanguage
			{
				IconImageId = iconImageId,
				Language = language,
				IsSourceLanguage = false
			});
		}
		return displayIconsForLanguages;
	}

	internal virtual IDictionary<IUniverse, long?> DoGetDisplayIconsForUniverses(IReadOnlyCollection<IUniverse> universes, ILanguageFamily languageFamily, IReadOnlyDictionary<IUniverse, ILanguageFamily> sourceLanguageDictionary)
	{
		Dictionary<IUniverse, long?> resultDictionary = universes.Where((IUniverse universe) => universe != null).Distinct().ToDictionary((Func<IUniverse, IUniverse>)((IUniverse universe) => universe), (Func<IUniverse, long?>)((IUniverse universe) => null));
		try
		{
			foreach (IGrouping<long, IUniverse> rootPlaceIdUniversesGrouping in (from universe in resultDictionary.Keys
				where universe.RootPlaceId.HasValue
				select universe into x
				group x by x.RootPlaceId.Value).ToList())
			{
				IPlaceIcon placeIcon = _PlaceIconFactory.GetPlaceIconByPlaceId(rootPlaceIdUniversesGrouping.Key);
				foreach (IUniverse universe6 in rootPlaceIdUniversesGrouping)
				{
					resultDictionary[universe6] = placeIcon.ImageId;
				}
			}
		}
		catch (Exception ex2)
		{
			_Logger.Error(ex2);
		}
		if (languageFamily == null)
		{
			return resultDictionary;
		}
		try
		{
			List<ValueSource<IUniverse>> valueSources = new List<ValueSource<IUniverse>>();
			foreach (IUniverse universe5 in resultDictionary.Keys)
			{
				sourceLanguageDictionary.TryGetValue(universe5, out var sourceLanguage);
				valueSources.Add(new ValueSource<IUniverse>(universe5, resultDictionary[universe5].HasValue ? resultDictionary[universe5].ToString() : null, sourceLanguage?.LanguageCode, universe5.Id.ToString(), universe5.Id));
			}
			IReadOnlyDictionary<IUniverse, string> universeIconIdStringDictionary = _GenericTranslationStorageAccessor.MultiGetTranslationValues(valueSources, _ContentSourceType, _ContentVariantType, languageFamily.LanguageCode);
			Dictionary<long, IList<IUniverse>> localizedIconIdUniversesDictionary = new Dictionary<long, IList<IUniverse>>();
			foreach (IUniverse universe4 in universeIconIdStringDictionary.Keys)
			{
				if (long.TryParse(universeIconIdStringDictionary[universe4], out var iconId3) && iconId3 != resultDictionary[universe4])
				{
					if (!localizedIconIdUniversesDictionary.ContainsKey(iconId3))
					{
						localizedIconIdUniversesDictionary[iconId3] = new List<IUniverse>();
					}
					localizedIconIdUniversesDictionary[iconId3].Add(universe4);
				}
			}
			if (_IsReturningNonApprovedLocalizedIconEnabledGetter())
			{
				foreach (long iconId2 in localizedIconIdUniversesDictionary.Keys)
				{
					foreach (IUniverse universe3 in localizedIconIdUniversesDictionary[iconId2])
					{
						resultDictionary[universe3] = iconId2;
					}
				}
				return resultDictionary;
			}
			IDictionary<long, bool> approvalStatusDictionary = _ImageApprovalStatusGetter.GetApprovalStatusForImages(localizedIconIdUniversesDictionary.Keys);
			foreach (long iconId in approvalStatusDictionary.Keys)
			{
				if (!approvalStatusDictionary[iconId])
				{
					continue;
				}
				foreach (IUniverse universe2 in localizedIconIdUniversesDictionary[iconId])
				{
					resultDictionary[universe2] = iconId;
				}
			}
		}
		catch (Exception ex)
		{
			_Logger.Error(ex);
		}
		return resultDictionary;
	}
}
