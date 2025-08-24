using System.Collections.Generic;
using Roblox.Platform.Localization.Core;

namespace Roblox.Platform.Demographics;

/// <summary>
/// Provide <see cref="T:Roblox.Platform.Demographics.ILocalizedCountry" /> for given <see cref="T:Roblox.Platform.Demographics.ICountry" />
/// </summary>
public interface ILocalizedCountryProvider
{
	/// <summary>
	/// Get an <see cref="T:Roblox.Platform.Demographics.ILocalizedCountry" /> of a given <see cref="T:Roblox.Platform.Demographics.ICountry" /> for a specific <see cref="T:Roblox.Platform.Localization.Core.ISupportedLocale" />
	/// </summary>
	/// <param name="country"><see cref="T:Roblox.Platform.Demographics.ICountry" /></param>
	/// <param name="supportedLocale"><see cref="T:Roblox.Platform.Localization.Core.ISupportedLocale" /></param>
	/// <returns><see cref="T:Roblox.Platform.Demographics.ILocalizedCountry" /></returns>
	ILocalizedCountry GetLocalizedCountry(ICountry country, ISupportedLocale supportedLocale);

	/// <summary>
	/// Get <see cref="T:Roblox.Platform.Demographics.ILocalizedCountry" /> collection of a given <see cref="T:Roblox.Platform.Demographics.ICountry" /> collection for a specific <see cref="T:Roblox.Platform.Localization.Core.ISupportedLocale" />
	/// </summary>
	/// <param name="countries"><see cref="T:System.Collections.Generic.ICollection`1" /> of <see cref="T:Roblox.Platform.Demographics.ICountry" /></param>
	/// <param name="supportedLocale"><see cref="T:Roblox.Platform.Localization.Core.ISupportedLocale" /></param>
	/// <returns><see cref="T:System.Collections.Generic.ICollection`1" /> of <see cref="T:Roblox.Platform.Demographics.ILocalizedCountry" /></returns>
	ICollection<ILocalizedCountry> GetLocalizedCountries(ICollection<ICountry> countries, ISupportedLocale supportedLocale);
}
