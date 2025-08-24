using System.Collections.Generic;

namespace Roblox.Localization.Client;

public interface ILocalizationClientCache
{
	bool TryGetLanguageFamilyById(int id, out LanguageFamily languageFamily);

	bool TryGetLanguageFamilyByLanguageCode(string languageCode, out LanguageFamily languageFamily);

	bool TryGetSupportedLocaleById(int id, out SupportedLocale supportedLocale);

	bool TryGetSupportedLocaleByLocaleCode(string code, out SupportedLocale supportedLocale);

	bool TryGetAllSupportedLocales(out IEnumerable<SupportedLocale> allSupportedLocales);

	bool TryGetDeviceReportedLocaleId(string rawDeviceReportedLocaleCode, out int? deviceReportedLocaleId);

	bool TryGetDeviceReportedLocaleById(int id, out DeviceReportedLocale deviceReportedLocale);

	bool TryGetDeviceReportedLocaleByCode(string rawDeviceReportedLocaleCode, out DeviceReportedLocale deviceReportedLocale);

	void SaveSupportedLocale(SupportedLocale supportedLocale);

	void SaveLanguageFamily(LanguageFamily languageFamily);

	void SaveDeviceReportedLocaleById(DeviceReportedLocale deviceReportedLocale);

	void SaveDeviceReportedLocaleByCode(string rawDeviceReportedLocaleCode, DeviceReportedLocale deviceReportedLocale);

	void SaveAllSupportedLocale(IEnumerable<SupportedLocale> allSupportedLocale);

	void SaveDeviceReportedLocaleId(string rawDeviceReportedLocaleCode, int deviceReportedLocaleId);
}
