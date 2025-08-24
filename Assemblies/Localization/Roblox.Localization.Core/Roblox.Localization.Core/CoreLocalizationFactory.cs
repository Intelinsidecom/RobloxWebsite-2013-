using System;
using System.Diagnostics.CodeAnalysis;
using Roblox.EventLog;
using Roblox.Platform.Localization.Core.Properties;

namespace Roblox.Platform.Localization.Core;

[ExcludeFromCodeCoverage]
public class CoreLocalizationFactory
{
	private readonly Lazy<ObservedLocaleEntityFactory> _ObservedLocaleEntityFactory = new Lazy<ObservedLocaleEntityFactory>();

	private readonly Lazy<SupportedLocaleEntityFactory> _SupportedLocaleEntityFactory = new Lazy<SupportedLocaleEntityFactory>();

	private readonly Lazy<LanguageEntityFactory> _LanguageEntityFactory = new Lazy<LanguageEntityFactory>();

	private readonly Lazy<LanguageDefaultSupportedLocaleEntityFactory> _LanguageDefaultSupportedLocaleEntityFactory = new Lazy<LanguageDefaultSupportedLocaleEntityFactory>();

	private readonly Lazy<LocaleParser> _LocaleParser = new Lazy<LocaleParser>();

	public ICoreLocalizationAccessor GetCoreLocalizationAccessor(ILogger logger)
	{
		Settings settings = Settings.Default;
		SupportedLocaleEntityTranslator supportedLocaleEntityTranslator = new SupportedLocaleEntityTranslator(_SupportedLocaleEntityFactory.Value, _LanguageEntityFactory.Value, _LocaleParser.Value, settings, logger);
		ObservedLocaleEntityTranslator observedLocaleEntityTranslator = new ObservedLocaleEntityTranslator(_LanguageEntityFactory.Value, _SupportedLocaleEntityFactory.Value, _LanguageDefaultSupportedLocaleEntityFactory.Value, supportedLocaleEntityTranslator);
		return new CoreLocalizationAccessor(_LanguageEntityFactory.Value, _ObservedLocaleEntityFactory.Value, _SupportedLocaleEntityFactory.Value, _LanguageDefaultSupportedLocaleEntityFactory.Value, _LocaleParser.Value, observedLocaleEntityTranslator, supportedLocaleEntityTranslator, settings);
	}

	public ICoreLocalizationBuilder GetCoreLocalizationBuilder()
	{
		return new CoreLocalizationBuilder(_ObservedLocaleEntityFactory.Value, _LanguageEntityFactory.Value, _LocaleParser.Value);
	}
}
