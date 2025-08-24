using Roblox.EventLog;
using Roblox.Platform.Core;
using Roblox.Platform.TranslationStorage;

namespace Roblox.Platform.Demographics;

public class CountryLocalizationFactory : DomainFactoriesBase
{
	public virtual ILocalizedCountryProvider GetLocalizationCountryProvider(ITranslationStorageAccessor translationStorageAccessor, ILogger logger)
	{
		return new LocalizedCountryProvider(translationStorageAccessor, logger);
	}

	public virtual ICountryFactory GetCountryFactory()
	{
		return new CountryFactory();
	}
}
