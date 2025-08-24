using System.Collections.Generic;
using System.Linq;
using Roblox.Users.Interfaces;

namespace Roblox.Users.Implementation;

/// <summary>
/// This is the interface for a factory for <see cref="T:Roblox.Users.Interfaces.ICountryModel" /> so we can abstract away the entity implementation and to make this unit testable
/// </summary>
public class CountryFactory : ICountryFactory
{
	public ICountryModel CreateNew(string value, string code, bool active)
	{
		Country country = Country.CreateNew(value, code, active);
		return EntityToModel(country);
	}

	public ICountryModel Get(byte id)
	{
		Country country = Country.Get(id);
		return EntityToModel(country);
	}

	public ICountryModel GetUSACountry()
	{
		Country country = Country.GetUSACountry();
		return EntityToModel(country);
	}

	public ICollection<ICountryModel> GetAllCountries()
	{
		return Country.GetAllCountries().Select(EntityToModel).ToList();
	}

	public ICollection<ICountryModel> GetAllActiveCountries()
	{
		return Country.GetAllActiveCountries().Select(EntityToModel).ToList();
	}

	public ICollection<ICountryModel> GetCountriesPaged(byte startRowIndex, byte maximumRows)
	{
		return Country.GetCountriesPaged(startRowIndex, maximumRows).Select(EntityToModel).ToList();
	}

	public ICountryModel GetByCode(string code)
	{
		Country country = Country.GetByCode(code);
		return EntityToModel(country);
	}

	private ICountryModel EntityToModel(Country country)
	{
		if (country != null)
		{
			return new CountryModel(country.ID, country.Value, country.Code, country.Active, country.Created, country.Updated);
		}
		return null;
	}
}
