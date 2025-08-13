using System;
using System.Collections.Generic;
using System.Linq;
using Roblox.Collections;
using Roblox.EventLog;
using Roblox.Localization.Client.Properties;

namespace Roblox.Localization.Client;

public class LocalizationClientCache : ILocalizationClientCache
{
	private const string _AllSupportedLocaleKey = "AllSupportedLocaleKey";

	private readonly ILogger _Logger;

	private readonly ISettings _Settings;

	private readonly ExpirableDictionary<int, LanguageFamily> _LanguageFamilyCacheById;

	private readonly ExpirableDictionary<string, LanguageFamily> _LanguageFamilyCacheByLanguageCode;

	private readonly ExpirableDictionary<int, SupportedLocale> _SupportedLocaleCacheById;

	private readonly ExpirableDictionary<string, SupportedLocale> _SupportedLocaleCacheByCode;

	private readonly ExpirableDictionary<string, IEnumerable<SupportedLocale>> _AllSupportedLocaleDictionary;

	private readonly ExpirableDictionary<string, int?> _RawDeviceReportedLocaleId;

	private readonly ExpirableDictionary<int, DeviceReportedLocale> _DeviceReportedLocaleCacheById;

	private readonly ExpirableDictionary<string, DeviceReportedLocale> _DeviceReportedLocaleCacheByCode;

	public LocalizationClientCache(ILogger logger)
		: this(logger, Settings.Default)
	{
	}

	internal LocalizationClientCache(ILogger logger, ISettings settings)
	{
		_Logger = logger ?? throw new ArgumentNullException("logger");
		_Settings = settings ?? throw new ArgumentNullException("settings");
		_LanguageFamilyCacheById = new ExpirableDictionary<int, LanguageFamily>(() => _Settings.LanguageFamilyLocalCacheExpiry, ExpirationPolicy.NeverRenew);
		_LanguageFamilyCacheByLanguageCode = new ExpirableDictionary<string, LanguageFamily>(() => _Settings.LanguageFamilyLocalCacheExpiry, ExpirationPolicy.NeverRenew);
		_SupportedLocaleCacheById = new ExpirableDictionary<int, SupportedLocale>(() => _Settings.SupportedLocaleLocalCacheExpiry, ExpirationPolicy.NeverRenew);
		_SupportedLocaleCacheByCode = new ExpirableDictionary<string, SupportedLocale>(() => _Settings.SupportedLocaleLocalCacheExpiry, ExpirationPolicy.NeverRenew);
		_AllSupportedLocaleDictionary = new ExpirableDictionary<string, IEnumerable<SupportedLocale>>(() => _Settings.SupportedLocaleLocalCacheExpiry, ExpirationPolicy.NeverRenew);
		_RawDeviceReportedLocaleId = new ExpirableDictionary<string, int?>(() => _Settings.DeviceReportedLocaleCacheExpiry, ExpirationPolicy.NeverRenew);
		_DeviceReportedLocaleCacheById = new ExpirableDictionary<int, DeviceReportedLocale>(() => _Settings.DeviceReportedLocaleCacheExpiry, ExpirationPolicy.NeverRenew);
		_DeviceReportedLocaleCacheByCode = new ExpirableDictionary<string, DeviceReportedLocale>(() => _Settings.DeviceReportedLocaleCacheExpiry, ExpirationPolicy.NeverRenew);
	}

	public bool TryGetLanguageFamilyById(int id, out LanguageFamily languageFamily)
	{
		if (id < 0)
		{
			languageFamily = null;
			return false;
		}
		languageFamily = _LanguageFamilyCacheById.Get(id);
		return languageFamily != null;
	}

	public bool TryGetLanguageFamilyByLanguageCode(string languageCode, out LanguageFamily languageFamily)
	{
		languageFamily = _LanguageFamilyCacheByLanguageCode.Get(languageCode);
		return languageFamily != null;
	}

	public bool TryGetSupportedLocaleById(int id, out SupportedLocale supportedLocale)
	{
		if (id < 0)
		{
			supportedLocale = null;
			return false;
		}
		supportedLocale = _SupportedLocaleCacheById.Get(id);
		return supportedLocale != null;
	}

	public bool TryGetSupportedLocaleByLocaleCode(string code, out SupportedLocale supportedLocale)
	{
		supportedLocale = _SupportedLocaleCacheByCode.Get(code);
		return supportedLocale != null;
	}

	public bool TryGetAllSupportedLocales(out IEnumerable<SupportedLocale> allSupportedLocales)
	{
		allSupportedLocales = _AllSupportedLocaleDictionary.Get("AllSupportedLocaleKey");
		if (allSupportedLocales != null)
		{
			return allSupportedLocales.Any();
		}
		return false;
	}

	public bool TryGetDeviceReportedLocaleId(string rawDeviceLocale, out int? deviceReportedLocaleId)
	{
		if (string.IsNullOrEmpty(rawDeviceLocale))
		{
			rawDeviceLocale = string.Empty;
		}
		int? num = default(int?);
		if (_RawDeviceReportedLocaleId.TryGet(rawDeviceLocale, ref num))
		{
			deviceReportedLocaleId = num;
			return true;
		}
		deviceReportedLocaleId = null;
		return false;
	}

	public bool TryGetDeviceReportedLocaleByCode(string rawDeviceLocale, out DeviceReportedLocale deviceReportedLocale)
	{
		if (string.IsNullOrEmpty(rawDeviceLocale))
		{
			rawDeviceLocale = string.Empty;
		}
		return _DeviceReportedLocaleCacheByCode.TryGet(rawDeviceLocale, ref deviceReportedLocale);
	}

	public bool TryGetDeviceReportedLocaleById(int id, out DeviceReportedLocale deviceReportedLocale)
	{
		deviceReportedLocale = _DeviceReportedLocaleCacheById.Get(id);
		return deviceReportedLocale != null;
	}

	public void SaveSupportedLocale(SupportedLocale supportedLocale)
	{
		if (supportedLocale != null)
		{
			_SupportedLocaleCacheByCode.Set(supportedLocale.LocaleCode, supportedLocale);
			_SupportedLocaleCacheById.Set(supportedLocale.Id, supportedLocale);
		}
	}

	public void SaveLanguageFamily(LanguageFamily languageFamily)
	{
		if (languageFamily != null)
		{
			_LanguageFamilyCacheByLanguageCode.Set(languageFamily.LanguageCode, languageFamily);
			_LanguageFamilyCacheById.Set(languageFamily.Id, languageFamily);
		}
	}

	public void SaveDeviceReportedLocaleById(DeviceReportedLocale deviceReportedLocale)
	{
		if (deviceReportedLocale != null)
		{
			_DeviceReportedLocaleCacheById.Set(deviceReportedLocale.Id, deviceReportedLocale);
		}
	}

	public void SaveDeviceReportedLocaleByCode(string rawDeviceReportedLocaleCode, DeviceReportedLocale deviceReportedLocale)
	{
		if (string.IsNullOrEmpty(rawDeviceReportedLocaleCode))
		{
			rawDeviceReportedLocaleCode = string.Empty;
		}
		if (deviceReportedLocale != null || rawDeviceReportedLocaleCode == string.Empty)
		{
			_DeviceReportedLocaleCacheByCode.Set(rawDeviceReportedLocaleCode, deviceReportedLocale);
		}
	}

	public void SaveAllSupportedLocale(IEnumerable<SupportedLocale> allSupportedLocales)
	{
		if (allSupportedLocales != null && allSupportedLocales.Any())
		{
			_AllSupportedLocaleDictionary.Set("AllSupportedLocaleKey", allSupportedLocales);
		}
	}

	public void SaveDeviceReportedLocaleId(string rawLocaleCode, int deviceReportedLocaleId)
	{
		if (string.IsNullOrEmpty(rawLocaleCode))
		{
			rawLocaleCode = string.Empty;
		}
		_RawDeviceReportedLocaleId.Set(rawLocaleCode, deviceReportedLocaleId);
	}
}
