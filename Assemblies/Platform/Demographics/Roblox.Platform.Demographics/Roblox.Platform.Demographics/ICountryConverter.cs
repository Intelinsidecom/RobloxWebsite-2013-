using Roblox.Users;

namespace Roblox.Platform.Demographics;

/// <summary>
/// Provides a common interface for an object that convert country object to ICountry.
/// </summary>
public interface ICountryConverter
{
	/// <summary>
	/// Converts <see cref="T:Roblox.Users.Country" /> to <see cref="T:Roblox.Platform.Demographics.ICountry" />.
	/// </summary>
	/// <param name="country">The <see cref="T:Roblox.Users.Country" /> that needs to be converted.</param>
	/// <returns>An converted country that implements <see cref="T:Roblox.Platform.Demographics.ICountry" />.</returns>
	/// <exception cref="T:Roblox.Platform.Core.PlatformArgumentNullException"><paramref name="country" /></exception>
	ICountry ConvertFromUserCountry(Roblox.Users.Country country);
}
