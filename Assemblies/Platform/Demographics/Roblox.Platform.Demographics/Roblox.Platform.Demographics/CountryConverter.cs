using Roblox.Platform.Core;
using Roblox.Platform.Users;

namespace Roblox.Platform.Demographics;

public class CountryConverter : ICountryConverter
{
	public ICountry ConvertFromUserCountry(Roblox.Platform.Users.Country country)
	{
		if (country == null)
		{
			throw new PlatformArgumentNullException("country");
		}
		return new Country(country.ID, country.Value, country.Code, country.Active);
	}
}
