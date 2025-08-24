using System;
using System.Collections.Generic;
using System.Linq;
using Roblox.EventLog;
using Roblox.Platform.Core;
using Roblox.Platform.Demographics.Properties;
using Roblox.Platform.Localization.Core;
using Roblox.Platform.TranslationStorage;

namespace Roblox.Platform.Demographics;

internal class LocalizedCountryProvider : ILocalizedCountryProvider
{
	private readonly ITranslationStorageAccessor _TranslationStorageAccessor;

	private readonly ILocalizedCountryProviderSettings _Settings;

	private readonly ICountryNameTranslationCache _CountryNameTranslationCache;

	private readonly ILogger _Logger;

	internal LocalizedCountryProvider(ITranslationStorageAccessor translationStorageAccessor, ILocalizedCountryProviderSettings settings, ICountryNameTranslationCache countryNameTranslationCache, ILogger logger)
	{
		_TranslationStorageAccessor = translationStorageAccessor.AssignOrThrowIfNull("translationStorageAccessor");
		_Settings = settings.AssignOrThrowIfNull("settings");
		_CountryNameTranslationCache = countryNameTranslationCache.AssignOrThrowIfNull("countryNameTranslationCache");
		_Logger = logger.AssignOrThrowIfNull("logger");
	}

	public LocalizedCountryProvider(ITranslationStorageAccessor translationStorageAccessor, ILogger logger)
		: this(translationStorageAccessor, Settings.Default, CountryNameTranslationCache.SingletonInstance, logger)
	{
	}

	public ILocalizedCountry GetLocalizedCountry(ICountry country, ISupportedLocale supportedLocale)
	{
		if (country == null)
		{
			throw new PlatformArgumentNullException("country");
		}
		if (supportedLocale == null)
		{
			throw new PlatformArgumentNullException("supportedLocale");
		}
		return DoGetLocalizedCountries(new List<ICountry> { country }, supportedLocale).First();
	}

	public ICollection<ILocalizedCountry> GetLocalizedCountries(ICollection<ICountry> countries, ISupportedLocale supportedLocale)
	{
		if (countries == null)
		{
			throw new PlatformArgumentNullException("countries");
		}
		if (supportedLocale == null)
		{
			throw new PlatformArgumentNullException("supportedLocale");
		}
		if (!countries.Any())
		{
			return new List<ILocalizedCountry>();
		}
		return DoGetLocalizedCountries(countries, supportedLocale);
	}

	private IEnumerable<ITranslationForContentSourceTargetId> GetCountryNameTranslations(IEnumerable<ICountry> countries, ISupportedLocale supportedLocale)
	{
		List<ITranslationForContentSourceTargetId> translations = new List<ITranslationForContentSourceTargetId>();
		List<string> idsToRequest = new List<string>();
		foreach (ICountry country in countries)
		{
			string id = country.Id.ToString();
			ITranslationForContentSourceTargetId translation2 = (_Settings.IsCountryNameTranslationCachingEnabled ? _CountryNameTranslationCache.Get(id, supportedLocale) : null);
			if (translation2 == null)
			{
				idsToRequest.Add(id);
			}
			else
			{
				translations.Add(translation2);
			}
		}
		if (!idsToRequest.Any())
		{
			return translations;
		}
		IReadOnlyCollection<ITranslationForContentSourceTargetId> translationsFromTss;
		try
		{
			translationsFromTss = _TranslationStorageAccessor.GetTranslationsForContentSourceTargetIds(supportedLocale, ContentSourceType.RobloxCountryDisplayNames, ContentVariantType.Production, idsToRequest);
		}
		catch (Exception ex)
		{
			_Logger.Error(ex);
			return translations;
		}
		foreach (ITranslationForContentSourceTargetId translation in translationsFromTss)
		{
			translations.Add(translation);
			if (_Settings.IsCountryNameTranslationCachingEnabled)
			{
				_CountryNameTranslationCache.Set(translation.ContentSourceTargetId, supportedLocale, translation);
			}
		}
		return translations;
	}

	private ICollection<ILocalizedCountry> DoGetLocalizedCountries(ICollection<ICountry> countries, ISupportedLocale supportedLocale)
	{
		if (_Settings.IsCountryNameTranslationEnabled)
		{
			IEnumerable<ITranslationForContentSourceTargetId> translations = GetCountryNameTranslations(countries, supportedLocale);
			return (from country in countries
				join translation in translations on country.Id.ToString() equals translation.ContentSourceTargetId into translationsForCountry
				select new LocalizedCountry(country, translationsForCountry.FirstOrDefault()?.TranslationValue ?? country.Name)).ToArray();
		}
		return countries.Select((ICountry country) => new LocalizedCountry(country, country.Name)).ToArray();
	}
}
