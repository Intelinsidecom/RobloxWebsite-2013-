using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using Roblox.Common;
using Roblox.Configuration;
using Roblox.Platform.Core;
using Roblox.Platform.Localization.Core.Implementations;
using Roblox.Platform.Localization.Core.Properties;

namespace Roblox.Platform.Localization.Core;

internal class CoreLocalizationAccessor : ICoreLocalizationAccessor
{
	private const int _PageSizeForSupportedLocale = 1000;

	private readonly ILanguageEntityFactory _LanguageEntityFactory;

	private readonly IObservedLocaleEntityFactory _ObservedLocaleEntityFactory;

	private readonly ISupportedLocaleEntityFactory _SupportedLocaleEntityFactory;

	private readonly ILanguageDefaultSupportedLocaleEntityFactory _LanguageDefaultSupportedLocaleEntityFactory;

	private readonly IObservedLocaleEntityTranslator _ObservedLocaleEntityTranslator;

	private readonly ILocaleParser _LocaleParser;

	private readonly ISupportedLocaleEntityTranslator _SupportedLocaleEntityTranslator;

	private readonly ISettings _Settings;

	public CoreLocalizationAccessor(ILanguageEntityFactory languageEntityFactory, IObservedLocaleEntityFactory observedLocaleEntityFactory, ISupportedLocaleEntityFactory supportedLocaleEntityFactory, ILanguageDefaultSupportedLocaleEntityFactory languageDefaultSupportedLocaleEntityFactory, ILocaleParser localeParser, IObservedLocaleEntityTranslator observedLocaleEntityTranslator, ISupportedLocaleEntityTranslator supportedLocaleEntityTranslator, ISettings settings)
	{
		_SupportedLocaleEntityTranslator = supportedLocaleEntityTranslator ?? throw new PlatformArgumentNullException(string.Format("{0}", "supportedLocaleEntityTranslator"));
		_LocaleParser = localeParser ?? throw new PlatformArgumentNullException("localeParser");
		_ObservedLocaleEntityTranslator = observedLocaleEntityTranslator ?? throw new PlatformArgumentNullException("observedLocaleEntityTranslator");
		_LanguageEntityFactory = languageEntityFactory ?? throw new PlatformArgumentNullException("languageEntityFactory");
		_ObservedLocaleEntityFactory = observedLocaleEntityFactory ?? throw new PlatformArgumentNullException("observedLocaleEntityFactory");
		_SupportedLocaleEntityFactory = supportedLocaleEntityFactory ?? throw new PlatformArgumentNullException("supportedLocaleEntityFactory");
		_LanguageDefaultSupportedLocaleEntityFactory = languageDefaultSupportedLocaleEntityFactory ?? throw new PlatformArgumentNullException("languageDefaultSupportedLocaleEntityFactory");
		_Settings = settings ?? throw new PlatformArgumentNullException("settings");
	}

	public ILanguageFamily GetLanguageFamily(ILanguageFamilyIdentifier languageFamilyIdentifier)
	{
		if (languageFamilyIdentifier == null)
		{
			return null;
		}
		return ToLanguage(_LanguageEntityFactory.Get(languageFamilyIdentifier));
	}

	public ILanguageFamily GetLanguageFamily(string languageFamilyCode)
	{
		return ToLanguage(_LanguageEntityFactory.GetByLanguageCode(languageFamilyCode));
	}

	public IReadOnlyCollection<ILanguageFamily> GetAvailableLanguageFamiliesForOutOfGameUgc()
	{
		return (from languageFamily in MultiValueSettingParser.ParseCommaDelimitedListString(_Settings.AvailableUgcLanguageCodesCsv).Select(GetLanguageFamily)
			where languageFamily != null
			select languageFamily).ToList();
	}

	[Obsolete("This is no longer the way to determine what languages are available in game.")]
	public IReadOnlyCollection<ILanguageFamily> GetAvailableLanguageFamiliesForInGameUgc()
	{
		return (from languageFamily in MultiValueSettingParser.ParseCommaDelimitedListString(_Settings.AvailableInGameUgcLanguageCodesCsv).Select(GetLanguageFamily)
			where languageFamily != null
			select languageFamily).ToList();
	}

	public ILanguageFamily GetSupportedInGameUGCLanguageFamily(string languageFamilyCode)
	{
		if (string.IsNullOrWhiteSpace(languageFamilyCode))
		{
			return null;
		}
		if (!MultiValueSettingParser.ParseCommaDelimitedListString(_Settings.AvailableInGameUgcLanguageCodesCsv).Contains(languageFamilyCode))
		{
			return null;
		}
		return GetLanguageFamily(languageFamilyCode);
	}

	public IDeviceReportedLocale GetDeviceReportedLocale(string deviceReportedLocaleCode)
	{
		if (string.IsNullOrEmpty(deviceReportedLocaleCode))
		{
			return null;
		}
		string standardizedLocale = _LocaleParser.GetStandardizedLocaleFromRawLocaleString(deviceReportedLocaleCode);
		IObservedLocaleEntity observedLocaleEntity = _ObservedLocaleEntityFactory.GetByLocale(standardizedLocale);
		return _ObservedLocaleEntityTranslator.TranslateObservedLocaleEntity(observedLocaleEntity);
	}

	public SupportedLocaleEnum? GetSupportedLocaleEnum(string supportedLocaleCode)
	{
		if (string.IsNullOrWhiteSpace(supportedLocaleCode))
		{
			return null;
		}
		return EnumUtils.StrictTryParseEnum<SupportedLocaleEnum>(supportedLocaleCode.Replace("-", "_").ToLower());
	}

	public ISupportedLocale GetDefaultSupportedLocaleFromLanguage(ILanguageFamily language)
	{
		if (language == null)
		{
			return null;
		}
		ILanguageDefaultSupportedLocaleEntity defaultSupportedLocale = _LanguageDefaultSupportedLocaleEntityFactory.GetByLanguageId(language.Id);
		if (defaultSupportedLocale == null)
		{
			return null;
		}
		ISupportedLocaleEntity supportedLocaleEntity = _SupportedLocaleEntityFactory.Get(defaultSupportedLocale.SupportedLocaleId);
		return _SupportedLocaleEntityTranslator.GetSupportedLocale(supportedLocaleEntity);
	}

	public IDeviceReportedLocale GetDeviceReportedLocale(IDeviceReportedLocaleIdentifier deviceReportedLocaleId)
	{
		if (deviceReportedLocaleId == null)
		{
			return null;
		}
		IObservedLocaleEntity observedLocaleEntity = _ObservedLocaleEntityFactory.Get(deviceReportedLocaleId);
		if (observedLocaleEntity != null)
		{
			return _ObservedLocaleEntityTranslator.TranslateObservedLocaleEntityWithDefaults(observedLocaleEntity);
		}
		return null;
	}

	public ISupportedLocale GetSupportedLocaleBySupportedLocaleId(ISupportedLocaleIdentifier supportedLocaleId)
	{
		if (supportedLocaleId != null)
		{
			return _SupportedLocaleEntityTranslator.GetSupportedLocale(_SupportedLocaleEntityFactory.Get(supportedLocaleId));
		}
		return null;
	}

	public ISupportedLocale GetSupportedLocaleBySupportedLocaleCode(string supportedLocaleCode)
	{
		return _SupportedLocaleEntityTranslator.GetSupportedLocale(_SupportedLocaleEntityFactory.GetByLocale(supportedLocaleCode));
	}

	public IReadOnlyCollection<ISupportedLocale> GetSupportedLocales(bool isChinaJvUser = false)
	{
		if (!isChinaJvUser)
		{
			return GetSupportedLocalesFromEntityFactory().Locales;
		}
		return GetSupportedLocalesFromEntityFactory().CjvLocales;
	}

	public IReadOnlyCollection<ISupportedLocale> GetSupportedLocalesInternal()
	{
		return GetSupportedLocalesFromEntityFactory().UnfilteredLocales;
	}

	public ISupportedLocale GetDefaultSupportedLocale()
	{
		return _SupportedLocaleEntityTranslator.GetDefaultSupportedLocale();
	}

	private (IReadOnlyCollection<ISupportedLocale> UnfilteredLocales, IReadOnlyCollection<ISupportedLocale> Locales, IReadOnlyCollection<ISupportedLocale> CjvLocales) GetSupportedLocalesFromEntityFactory()
	{
		List<ISupportedLocale> locales = new List<ISupportedLocale>();
		List<ISupportedLocale> unfilteredLocales = new List<ISupportedLocale>();
		List<ISupportedLocale> cjvLocales = new List<ISupportedLocale>();
		int startRowIndex = 0;
		List<ISupportedLocaleEntity> supportedLocales;
		do
		{
			supportedLocales = _SupportedLocaleEntityFactory.GetSupportedLocalesPaged(startRowIndex, 1000).ToList();
			foreach (ISupportedLocaleEntity localeEntity in supportedLocales)
			{
				ISupportedLocale supportedLocale = _SupportedLocaleEntityTranslator.GetSupportedLocale(localeEntity);
				if (supportedLocale != null)
				{
					unfilteredLocales.Add(supportedLocale);
					if (supportedLocale.Locale == SupportedLocaleEnum.zh_cjv)
					{
						cjvLocales.Add(supportedLocale);
					}
					else
					{
						locales.Add(supportedLocale);
					}
				}
			}
			startRowIndex += 1000;
		}
		while (supportedLocales.Count >= 1000);
		return (new ReadOnlyCollection<ISupportedLocale>(unfilteredLocales), new ReadOnlyCollection<ISupportedLocale>(locales), new ReadOnlyCollection<ISupportedLocale>(cjvLocales));
	}

	internal static ILanguageFamily ToLanguage(ILanguageEntity languageEntity)
	{
		if (languageEntity != null)
		{
			return new LanguageFamily(languageEntity.Id, languageEntity.Name, languageEntity.NativeName, languageEntity.LanguageCode);
		}
		return null;
	}
}
