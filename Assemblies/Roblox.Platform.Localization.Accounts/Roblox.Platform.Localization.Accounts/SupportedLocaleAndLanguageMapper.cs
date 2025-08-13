using Roblox.Platform.Core;
using Roblox.Platform.Localization.Accounts.Properties;
using Roblox.Platform.Localization.Core;

namespace Roblox.Platform.Localization.Accounts;

internal class SupportedLocaleAndLanguageMapper : ISupportedLocaleAndLanguageMapper
{
	private readonly ICoreLocalizationAccessor _CoreLocalizationAccessor;

	private readonly ISettings _Settings;

	public SupportedLocaleAndLanguageMapper(ICoreLocalizationAccessor coreLocalizationAccessor, ISettings settings)
	{
		_CoreLocalizationAccessor = coreLocalizationAccessor ?? throw new PlatformArgumentNullException("coreLocalizationAccessor");
		_Settings = settings;
	}

	public ISupportedLocale MapSupportedLocale(IAccountLocaleEntity accountLocaleEntity)
	{
		if (accountLocaleEntity == null)
		{
			throw new PlatformArgumentNullException("accountLocaleEntity");
		}
		if (accountLocaleEntity.SupportedLocaleId.HasValue)
		{
			return _CoreLocalizationAccessor.GetSupportedLocaleBySupportedLocaleId(new SupportedLocaleIdentifier(accountLocaleEntity.SupportedLocaleId.Value));
		}
		IDeviceReportedLocale deviceReportedLocale = _CoreLocalizationAccessor.GetDeviceReportedLocale(new DeviceReportedLocaleIdentifier(accountLocaleEntity.ObservedLocaleId));
		if (_Settings.IsRemoveUnneededLocaleMappingLogicEnabled)
		{
			return deviceReportedLocale?.SupportedLocale;
		}
		if (deviceReportedLocale == null)
		{
			return null;
		}
		return deviceReportedLocale.SupportedLocale ?? _CoreLocalizationAccessor.GetDeviceReportedLocale(deviceReportedLocale.StandardizedLocale).SupportedLocale;
	}

	public ILanguageFamily MapLangauge(IAccountLocaleEntity accountLocaleEntity)
	{
		if (accountLocaleEntity == null)
		{
			throw new PlatformArgumentNullException("accountLocaleEntity");
		}
		return _CoreLocalizationAccessor.GetDeviceReportedLocale(new DeviceReportedLocaleIdentifier(accountLocaleEntity.ObservedLocaleId))?.LanguageFamily;
	}
}
