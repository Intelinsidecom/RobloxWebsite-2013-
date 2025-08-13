using System;
using System.Collections.Generic;
using System.Linq;
using Roblox.DataV2.Core;
using Roblox.EventLog;
using Roblox.Platform.Core;
using Roblox.Platform.GameLocalization;
using Roblox.Platform.Localization.Core;
using Roblox.Platform.TranslationStorage;
using Roblox.Platform.UniverseDisplayInformation.Properties;
using Roblox.Platform.Universes;

namespace Roblox.Platform.UniverseDisplayInformation;

/// <inheritdoc />
public class UniverseDisplayInformationAccessor : IUniverseDisplayInformationAccessor
{
	private readonly ICoreLocalizationAccessor _CoreLocalizationAccessor;

	private readonly ITranslationStorageAccessor _TranslationStorageAccessor;

	private readonly IGameLocalizationSettingsAuthority _GameLocalizationSettingsAuthority;

	private readonly IUniverseDisplayInformationAccessorSettings _Settings;

	private readonly ILogger _Logger;

	/// <summary>
	/// Constructor
	/// </summary>
	/// <param name="coreLocalizationAccessor">The <see cref="T:Roblox.Platform.Localization.Core.ICoreLocalizationAccessor" />.</param>
	/// <param name="translationStorageAccessor">The <see cref="T:Roblox.Platform.TranslationStorage.ITranslationStorageAccessor" />.</param>
	/// <param name="gameLocalizationSettingsAuthority">The <see cref="T:Roblox.Platform.GameLocalization.IGameLocalizationSettingsAuthority" />.</param>
	/// <param name="logger">The <see cref="T:Roblox.EventLog.ILogger" />.</param>
	/// <exception cref="T:Roblox.Platform.Core.PlatformArgumentNullException">Thrown if any null argument.</exception>
	public UniverseDisplayInformationAccessor(ICoreLocalizationAccessor coreLocalizationAccessor, ITranslationStorageAccessor translationStorageAccessor, IGameLocalizationSettingsAuthority gameLocalizationSettingsAuthority, ILogger logger)
		: this(coreLocalizationAccessor, translationStorageAccessor, gameLocalizationSettingsAuthority, Settings.Default, logger)
	{
	}

	internal UniverseDisplayInformationAccessor(ICoreLocalizationAccessor coreLocalizationAccessor, ITranslationStorageAccessor translationStorageAccessor, IGameLocalizationSettingsAuthority gameLocalizationSettingsAuthority, IUniverseDisplayInformationAccessorSettings settings, ILogger logger)
	{
		_CoreLocalizationAccessor = coreLocalizationAccessor ?? throw new PlatformArgumentNullException("coreLocalizationAccessor");
		_TranslationStorageAccessor = translationStorageAccessor ?? throw new PlatformArgumentNullException("translationStorageAccessor");
		_GameLocalizationSettingsAuthority = gameLocalizationSettingsAuthority ?? throw new PlatformArgumentNullException("gameLocalizationSettingsAuthority");
		_Settings = settings ?? throw new PlatformArgumentNullException("settings");
		_Logger = logger ?? throw new PlatformArgumentNullException("logger");
	}

	/// <inheritdoc />
	public string GetDisplayName(IUniverse universe, ISupportedLocale supportedLocale)
	{
		if (universe == null)
		{
			throw new PlatformArgumentNullException("universe");
		}
		return DoGetDisplayInformation(universe, supportedLocale?.Language, ContentSourceType.UniverseDisplayNames, (IUniverse x) => x.Name);
	}

	/// <inheritdoc />
	public string GetDisplayDescription(IUniverse universe, ISupportedLocale supportedLocale)
	{
		if (universe == null)
		{
			throw new PlatformArgumentNullException("universe");
		}
		return DoGetDisplayInformation(universe, supportedLocale?.Language, ContentSourceType.UniverseDisplayDescriptions, (IUniverse x) => x.Description);
	}

	/// <inheritdoc />
	public IGetTranslationHistoryResult GetDisplayNameHistory(IUniverse universe, ILanguageFamily language, ILanguageFamily sourceLanguage, string exclusiveStartId, int count, SortOrder sortOrder)
	{
		if (universe == null)
		{
			throw new PlatformArgumentNullException("universe");
		}
		return DoGetDisplayInformationHistory(universe, language, sourceLanguage, ContentSourceType.UniverseDisplayNames, exclusiveStartId, count, sortOrder);
	}

	/// <inheritdoc />
	public IGetTranslationHistoryResult GetDisplayDescriptionHistory(IUniverse universe, ILanguageFamily language, ILanguageFamily sourceLanguage, string exclusiveStartId, int count, SortOrder sortOrder)
	{
		if (universe == null)
		{
			throw new PlatformArgumentNullException("universe");
		}
		return DoGetDisplayInformationHistory(universe, language, sourceLanguage, ContentSourceType.UniverseDisplayDescriptions, exclusiveStartId, count, sortOrder);
	}

	/// <inheritdoc />
	public IDictionary<IUniverse, string> GetDisplayNamesForUniverses(IReadOnlyCollection<IUniverse> universes, ISupportedLocale supportedLocale)
	{
		if (universes == null)
		{
			throw new PlatformArgumentNullException("universes");
		}
		return DoGetDisplayInformationForUniverses(universes, supportedLocale?.Language, ContentSourceType.UniverseDisplayNames, (IUniverse x) => x.Name);
	}

	/// <inheritdoc />
	public IDictionary<IUniverse, string> GetDisplayDescriptionsForUniverses(IReadOnlyCollection<IUniverse> universes, ISupportedLocale supportedLocale)
	{
		if (universes == null)
		{
			throw new PlatformArgumentNullException("universes");
		}
		return DoGetDisplayInformationForUniverses(universes, supportedLocale?.Language, ContentSourceType.UniverseDisplayDescriptions, (IUniverse x) => x.Description);
	}

	/// <inheritdoc />
	public IReadOnlyCollection<IUniverseDisplayNameForLanguage> GetDisplayNamesForAllLanguages(IUniverse universe)
	{
		if (universe == null)
		{
			throw new PlatformArgumentNullException("universe");
		}
		return DoGetDisplayInformationForAllLanguages(universe, ContentSourceType.UniverseDisplayNames, (IUniverse x) => x.Name).Select(delegate((ILanguageFamily Language, string Value, bool IsSourceLanguage) x)
		{
			UniverseDisplayNameForLanguage universeDisplayNameForLanguage = new UniverseDisplayNameForLanguage();
			(universeDisplayNameForLanguage.Language, universeDisplayNameForLanguage.Name, universeDisplayNameForLanguage.IsSourceLanguage) = x;
			return universeDisplayNameForLanguage;
		}).ToList();
	}

	/// <inheritdoc />
	public IReadOnlyCollection<IUniverseDisplayDescriptionForLanguage> GetDisplayDescriptionsForAllLanguages(IUniverse universe)
	{
		if (universe == null)
		{
			throw new PlatformArgumentNullException("universe");
		}
		return DoGetDisplayInformationForAllLanguages(universe, ContentSourceType.UniverseDisplayDescriptions, (IUniverse x) => x.Description).Select(delegate((ILanguageFamily Language, string Value, bool IsSourceLanguage) x)
		{
			UniverseDisplayDescriptionForLanguage universeDisplayDescriptionForLanguage = new UniverseDisplayDescriptionForLanguage();
			(universeDisplayDescriptionForLanguage.Language, universeDisplayDescriptionForLanguage.Description, universeDisplayDescriptionForLanguage.IsSourceLanguage) = x;
			return universeDisplayDescriptionForLanguage;
		}).ToList();
	}

	private IGetTranslationHistoryResult DoGetDisplayInformationHistory(IUniverse universe, ILanguageFamily languageFamily, ILanguageFamily sourceLanguageFamily, ContentSourceType contentSourceType, string exclusiveStartId, int count, SortOrder sortOrder)
	{
		if (AreLanguagesNotNullAndSame(languageFamily, sourceLanguageFamily))
		{
			throw new PlatformArgumentException("Cannot get history in source language");
		}
		return _TranslationStorageAccessor.GetTranslationHistory(languageFamily, contentSourceType, ContentVariantType.Production, universe.Id.ToString(), exclusiveStartId, count, sortOrder);
	}

	private bool IsInShadowRolloutRange(IUniverse universe)
	{
		return universe.Id % 100 < _Settings.ShadowRolloutPercentage;
	}

	private string DoGetDisplayInformation(IUniverse universe, ILanguageFamily languageFamily, ContentSourceType contentSourceType, Func<IUniverse, string> propertyGetter)
	{
		string originalValue = propertyGetter(universe);
		bool isReturningTranslationsEnabled = _Settings.IsReturningTranslationsEnabled;
		if (languageFamily == null || !_Settings.IsAccessingTranslationsEnabled || (!isReturningTranslationsEnabled && !IsInShadowRolloutRange(universe)))
		{
			return originalValue;
		}
		try
		{
			ILanguageFamily sourceLanguageFamily = _GameLocalizationSettingsAuthority.GetSourceLanguageFamily(universe);
			if (AreLanguagesNotNullAndSame(languageFamily, sourceLanguageFamily))
			{
				return originalValue;
			}
		}
		catch (Exception ex2)
		{
			_Logger.Error(ex2);
			return originalValue;
		}
		string translation;
		try
		{
			translation = _TranslationStorageAccessor.GetTranslation(languageFamily, contentSourceType, ContentVariantType.Production, universe.Id.ToString());
		}
		catch (Exception ex)
		{
			_Logger.Error(ex);
			return originalValue;
		}
		if (isReturningTranslationsEnabled && !string.IsNullOrWhiteSpace(translation))
		{
			return translation;
		}
		return originalValue;
	}

	private IDictionary<IUniverse, string> DoGetDisplayInformationForUniverses(IReadOnlyCollection<IUniverse> universes, ILanguageFamily languageFamily, ContentSourceType contentSourceType, Func<IUniverse, string> propertyGetter)
	{
		universes = universes.Where((IUniverse x) => x != null).ToList();
		Dictionary<IUniverse, string> resultDictionary = universes.ToDictionary((IUniverse x) => x, propertyGetter);
		if (languageFamily == null || !_Settings.IsAccessingTranslationsEnabled)
		{
			return resultDictionary;
		}
		bool isReturningTranslationsEnabled = _Settings.IsReturningTranslationsEnabled;
		List<IUniverse> universesToRequest = (isReturningTranslationsEnabled ? universes.ToList() : universes.Where(IsInShadowRolloutRange).ToList());
		try
		{
			IReadOnlyDictionary<IUniverse, ILanguageFamily> universeSourceLanguageDictionary = _GameLocalizationSettingsAuthority.GetSourceLanguageFamiliesForGames(universesToRequest);
			universesToRequest = universesToRequest.Where((IUniverse universe) => !AreLanguagesNotNullAndSame(languageFamily, universeSourceLanguageDictionary[universe])).ToList();
		}
		catch (Exception ex2)
		{
			_Logger.Error(ex2);
			return resultDictionary;
		}
		List<string> targetIds = universesToRequest.Select((IUniverse x) => x.Id.ToString()).Distinct().ToList();
		IReadOnlyCollection<ITranslationForContentSourceTargetId> translations;
		try
		{
			translations = _TranslationStorageAccessor.GetTranslationsForContentSourceTargetIds(languageFamily, contentSourceType, ContentVariantType.Production, targetIds);
			translations = translations.Where((ITranslationForContentSourceTargetId x) => !string.IsNullOrWhiteSpace(x.TranslationValue)).ToList();
		}
		catch (Exception ex)
		{
			_Logger.Error(ex);
			return resultDictionary;
		}
		if (isReturningTranslationsEnabled)
		{
			(from universe in universesToRequest
				join translation in translations on universe.Id.ToString() equals translation.ContentSourceTargetId
				select (universe, translation.TranslationValue)).ToList().ForEach(delegate((IUniverse universe, string TranslationValue) x)
			{
				resultDictionary[x.universe] = x.TranslationValue;
			});
		}
		return resultDictionary;
	}

	private IReadOnlyCollection<(ILanguageFamily Language, string Value, bool IsSourceLanguage)> DoGetDisplayInformationForAllLanguages(IUniverse universe, ContentSourceType contentSourceType, Func<IUniverse, string> propertyGetter)
	{
		ILanguageFamily sourceLanguage = _GameLocalizationSettingsAuthority.GetSourceLanguageFamily(universe);
		List<(ILanguageFamily, string, bool)> resultList = new List<(ILanguageFamily, string, bool)> { (sourceLanguage, propertyGetter(universe), true) };
		IReadOnlyCollection<ITranslationForContentLocale> translations;
		try
		{
			translations = _TranslationStorageAccessor.GetTranslationForContentLocales(contentSourceType, ContentVariantType.Production, universe.Id.ToString());
		}
		catch (Exception ex)
		{
			_Logger.Error(ex);
			return resultList;
		}
		foreach (ITranslationForContentLocale translationForContentLocale in translations)
		{
			if (!string.IsNullOrWhiteSpace(translationForContentLocale.TranslationValue))
			{
				ILanguageFamily language = _CoreLocalizationAccessor.GetLanguageFamily(translationForContentLocale.ContentLocale);
				if (language == null)
				{
					_Logger.Error($"Unknown language code {translationForContentLocale.ContentLocale}. UniverseId = {universe.Id}, ContentSourceType = {contentSourceType.ToString()}.");
				}
				else if (!AreLanguagesNotNullAndSame(language, sourceLanguage))
				{
					resultList.Add((language, translationForContentLocale.TranslationValue, false));
				}
			}
		}
		return resultList;
	}

	private bool AreLanguagesNotNullAndSame(ILanguageFamily languageA, ILanguageFamily languageB)
	{
		if (languageA != null && languageB != null)
		{
			return languageA.Id == languageB.Id;
		}
		return false;
	}
}
