using System.Collections.Generic;
using System.Linq;
using Roblox.Platform.Users.Interfaces;
using Roblox.Platform.Users;

namespace Roblox.Platform.Users.Implementation {
    /// <summary>

/// This is the interface for a factory for <see cref="T:Roblox.Users.Interfaces.ICountryModel" /> so we can abstract away the entity implementation and to make this unit testable
/// </summary>
public class CountryFactory : ICountryFactory
{
	public ICountryModel CreateNew(string value, string code, bool active)
	{
		Roblox.Platform.Users.Country country = Roblox.Platform.Users.Country.CreateNew(value, code, active);
		return EntityToModel(country);
	}

	public ICountryModel Get(byte id)
	{
		Roblox.Platform.Users.Country country = Roblox.Platform.Users.Country.Get(id);
		return EntityToModel(country);
	}

	public ICountryModel GetUSACountry()
	{
		Roblox.Platform.Users.Country country = Roblox.Platform.Users.Country.GetUSACountry();
		return EntityToModel(country);
	}

	public ICollection<ICountryModel> GetAllCountries()
	{
		return Roblox.Platform.Users.Country.GetAllCountries().Select(EntityToModel).ToList();
	}

	public ICollection<ICountryModel> GetAllActiveCountries()
	{
		return Roblox.Platform.Users.Country.GetAllActiveCountries().Select(EntityToModel).ToList();
	}

	public ICollection<ICountryModel> GetCountriesPaged(byte startRowIndex, byte maximumRows)
	{
		return Roblox.Platform.Users.Country.GetCountriesPaged(startRowIndex, maximumRows).Select(EntityToModel).ToList();
	}

	public ICountryModel GetByCode(string code)
	{
		Roblox.Platform.Users.Country country = Roblox.Platform.Users.Country.GetByCode(code);
		return EntityToModel(country);
	}

	private ICountryModel EntityToModel(Roblox.Platform.Users.Country country)
	{
		if (country != null)
		{
			return new Roblox.Platform.Users.CountryModel(country.ID, country.Value, country.Code, country.Active, country.Created, country.Updated);
		}
		return null;
	}
}
