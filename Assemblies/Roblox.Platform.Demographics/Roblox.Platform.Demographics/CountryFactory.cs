using System.Collections.Generic;
using System.Linq;
using Roblox.Demographics;
using Roblox.Platform.Core;

namespace Roblox.Platform.Demographics;

public class CountryFactory : ICountryFactory
{
	public ICountry Get(ICountryIdentifier countryId)
	{
		if (countryId == null)
		{
			throw new PlatformArgumentNullException("countryId");
		}
		return Get(countryId.Id);
	}

	public ICountry Get(int countryId)
	{
		return CountryCalToICountry(Roblox.Demographics.Country.Get(countryId));
	}

	public ICollection<ICountry> GetAllActive()
	{
		return Roblox.Demographics.Country.GetAllActiveCountries().Select(CountryCalToICountry).ToArray();
	}

	public ICountry GetByCode(string code)
	{
		if (code == null)
		{
			throw new PlatformArgumentNullException("code");
		}
		return CountryCalToICountry(Roblox.Demographics.Country.GetByCode(code));
	}

	private static ICountry CountryCalToICountry(Roblox.Demographics.Country cal)
	{
		if (cal != null)
		{
			return new Country(cal.ID, cal.Value, cal.Code, cal.IsActive);
		}
		return null;
	}
}
