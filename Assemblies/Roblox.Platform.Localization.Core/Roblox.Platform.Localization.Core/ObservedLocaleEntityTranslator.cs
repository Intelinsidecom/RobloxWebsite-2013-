using Roblox.Platform.Core;

namespace Roblox.Platform.Localization.Core;

internal class ObservedLocaleEntityTranslator : IObservedLocaleEntityTranslator
{
	private const string _DefaultLanguage = "en";

	private readonly ILanguageEntityFactory _LanguageEntityFactory;

	private readonly ISupportedLocaleEntityFactory _SupportedLocaleEntityFactory;

	private readonly ILanguageDefaultSupportedLocaleEntityFactory _LanguageDefaultSupportedLocaleEntityFactory;

	private readonly ISupportedLocaleEntityTranslator _SupportedLocaleEntityTranslator;

	public ObservedLocaleEntityTranslator(ILanguageEntityFactory languageEntityFactory, ISupportedLocaleEntityFactory supportedLocaleEntityFactory, ILanguageDefaultSupportedLocaleEntityFactory languageDefaultSupportedLocaleEntityFactory, ISupportedLocaleEntityTranslator supportedLocaleEntityTranslator)
	{
		_SupportedLocaleEntityTranslator = supportedLocaleEntityTranslator ?? throw new PlatformArgumentNullException(string.Format("{0}", "supportedLocaleEntityTranslator"));
		_LanguageEntityFactory = languageEntityFactory ?? throw new PlatformArgumentNullException(string.Format("{0} cannot be null", "languageEntityFactory"));
		_SupportedLocaleEntityFactory = supportedLocaleEntityFactory ?? throw new PlatformArgumentNullException(string.Format("{0} cannot be null", "supportedLocaleEntityFactory"));
		_LanguageDefaultSupportedLocaleEntityFactory = languageDefaultSupportedLocaleEntityFactory ?? throw new PlatformArgumentNullException(string.Format("{0} cannot be null", "languageDefaultSupportedLocaleEntityFactory"));
	}

	public IDeviceReportedLocale TranslateObservedLocaleEntityWithDefaults(IObservedLocaleEntity observedLocaleEntity)
	{
		if (observedLocaleEntity == null)
		{
			return null;
		}
		DeviceReportedLocale deviceReportedLocale = new DeviceReportedLocale
		{
			DeviceReportedLocaleId = new DeviceReportedLocaleIdentifier(observedLocaleEntity.Id),
			StandardizedLocale = observedLocaleEntity.Locale
		};
		if (observedLocaleEntity.LanguageId.HasValue)
		{
			deviceReportedLocale.LanguageFamily = CoreLocalizationAccessor.ToLanguage(_LanguageEntityFactory.Get(observedLocaleEntity.LanguageId.Value));
		}
		else
		{
			deviceReportedLocale.LanguageFamily = CoreLocalizationAccessor.ToLanguage(_LanguageEntityFactory.GetByLanguageCode("en"));
		}
		if (observedLocaleEntity.SupportedLocaleId.HasValue)
		{
			int supportedLocaleId = observedLocaleEntity.SupportedLocaleId.Value;
			deviceReportedLocale.SupportedLocale = _SupportedLocaleEntityTranslator.GetSupportedLocale(_SupportedLocaleEntityFactory.Get(supportedLocaleId));
			return deviceReportedLocale;
		}
		if (deviceReportedLocale.LanguageFamily != null)
		{
			ILanguageDefaultSupportedLocaleEntity langaugeDefaultSupportedLocaleEntity = _LanguageDefaultSupportedLocaleEntityFactory.GetByLanguageId(deviceReportedLocale.LanguageFamily.Id);
			if (langaugeDefaultSupportedLocaleEntity != null)
			{
				int supportedLocaleId = langaugeDefaultSupportedLocaleEntity.SupportedLocaleId;
				deviceReportedLocale.SupportedLocale = _SupportedLocaleEntityTranslator.GetSupportedLocale(_SupportedLocaleEntityFactory.Get(supportedLocaleId));
				return deviceReportedLocale;
			}
		}
		deviceReportedLocale.SupportedLocale = _SupportedLocaleEntityTranslator.GetDefaultSupportedLocale();
		return deviceReportedLocale;
	}

	public IDeviceReportedLocale TranslateObservedLocaleEntity(IObservedLocaleEntity observedLocaleEntity)
	{
		if (observedLocaleEntity == null)
		{
			return null;
		}
		DeviceReportedLocale deviceReportedLocale = new DeviceReportedLocale
		{
			DeviceReportedLocaleId = new DeviceReportedLocaleIdentifier(observedLocaleEntity.Id),
			StandardizedLocale = observedLocaleEntity.Locale
		};
		if (observedLocaleEntity.LanguageId.HasValue)
		{
			deviceReportedLocale.LanguageFamily = CoreLocalizationAccessor.ToLanguage(_LanguageEntityFactory.Get(observedLocaleEntity.LanguageId.Value));
		}
		if (observedLocaleEntity.SupportedLocaleId.HasValue)
		{
			deviceReportedLocale.SupportedLocale = _SupportedLocaleEntityTranslator.GetSupportedLocale(_SupportedLocaleEntityFactory.Get(observedLocaleEntity.SupportedLocaleId.Value));
		}
		return deviceReportedLocale;
	}
}
